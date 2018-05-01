Imports System.Net
Imports System.Net.Mail
Imports System.IO

Public Class motDePasse


    Public idParieurConnexion As Integer
    Private Sub motDePasse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles labelTextCouriel.Click

    End Sub

    Private Sub bouttonConexion_Click(sender As Object, e As EventArgs) Handles bouttonConexion.Click



        'Utiliser la procedure pour prendre le Hash + sel + mpd dans la BDD 

        Dim QTA As New ALHDataSetTableAdapters.P_SELECT_MPD_PARIEURTableAdapter 'selecteur 
        Dim maTableDeMotDePasse As New DataTable
        maTableDeMotDePasse = QTA.GetData(TBCouriel.Text.ToString)



        If maTableDeMotDePasse.Rows.Count = 0 Then
            'si le n'est pas reconue 
            TBMPD.Text = ""
            MsgBox("Erreur votre login est inexistant  ", vbCritical, "Erreur login")
        Else
            'si le log est bon 

            'verrifier le MPD
            If VerifierMDP(TBMPD.Text.ToString, maTableDeMotDePasse.Rows(0).Item("sel"), maTableDeMotDePasse.Rows(0).Item("hash")) Then

                idParieurConnexion = CInt(Int(maTableDeMotDePasse.Rows(0).Item("idPar")))

                main.Show()
                Me.Close()
            Else
                MsgBox("Erreur mot de passe incorect ", vbCritical, "Erreur mot de passe")
                TBMPD.Text = ""
            End If



        End If


        'si non tester le MDP pour sa : 
        'utiliser verifier mot de passe 

        'si vrai se connecter si non dire probleme 





    End Sub

    'get le sel dans la BDD 
    Const PBKDF2_ITERATIONS = 1000 'nombre d'itéarations pour le key stretching
    Const NB_OCTETS_HASH_SEL = 32 'les hash et les sel auront la même taille (32 octets = 256 bits = format généré par SHA256)

    Public Function GenererSel() As String




        '-------------------------------------------------------------------------------------------------------------------
        'génération ALÉATOIRE du sel, qui doit IMPÉRATIVEMENT être suffisamment long et différent d'un utilisateur à l'autre
        '-------------------------------------------------------------------------------------------------------------------

        Dim csprng As New System.Security.Cryptography.RNGCryptoServiceProvider
        Dim sel(NB_OCTETS_HASH_SEL) As Byte
        Dim strSel As String

        'génère le sel et le convertit en string
        csprng.GetBytes(sel)
        strSel = Convert.ToBase64String(sel)

        Return strSel

    End Function

    Public Function GenererHash(motDePasse As String, sel As String) As String

        Dim hashAlg As New System.Security.Cryptography.SHA256CryptoServiceProvider

        '-----------------------------------------
        'calcule le hash et le convertit en string
        '-----------------------------------------

        'le hash est généré à partir de la concaténation du sel et du mot de passe
        Dim hashvalue() As Byte = hashAlg.ComputeHash(System.Text.Encoding.Default.GetBytes(sel + motDePasse))

        'on pourrait remplacer l'instruction précédente par du key stretching en faisant un appel à PBKDF2()
        'ça diminue les risques si le hacker est très sérieux, mais ça alourdit le traitement sur un serveur web (denial of service, DoS)
        'Dim hashvalue = PBKDF2(motDePasse, sel, PBKDF2_ITERATIONS)

        Return Convert.ToBase64String(hashvalue)

    End Function

    Public Function VerifierMDP(motDePasse As String, sel As String, hashOriginal As String) As Boolean

        '-----------------------------------------------------------------------------------------
        'on doit concaténer le sel et le mot de passe entré, passer ça dans le hachoir et vérifier
        'si ça donne le même résultat que le hash calculé précédemment
        '-----------------------------------------------------------------------------------------

        Dim hashAlg As New System.Security.Cryptography.SHA256CryptoServiceProvider 'on utilise le hachage SHA256
        Dim nouveauHash As String

        'calcule le hash et le convertit en string
        Dim hashvalue() As Byte = hashAlg.ComputeHash(System.Text.Encoding.Default.GetBytes(sel + motDePasse))

        'encore une fois, on pourrait utiliser le key stretching pour rentre ça encore plus sécure, mais c'est très lourd pour un serveur web...
        'Dim hashvalue() As Byte = PBKDF2(motDePasse, sel, PBKDF2_ITERATIONS)

        nouveauHash = Convert.ToBase64String(hashvalue)

        If nouveauHash = hashOriginal Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function PBKDF2(motDePasse As String, sel As String, iterations As Integer) As Byte()

        'utilisation du key stretching au lieu de SHA256
        'ça rend la résolution de mot de passe encore plus difficile, 
        'mais ça peut provoquer un denial of service (DoS) si un hacker s'attaque à un SERVEUR WEB

        Dim hashAlg As New System.Security.Cryptography.Rfc2898DeriveBytes(motDePasse, Convert.FromBase64String(sel))
        hashAlg.IterationCount = iterations

        Return hashAlg.GetBytes(NB_OCTETS_HASH_SEL)

    End Function

    Public Function GenererChaineDeCaracteres(Optional ByVal length As Integer = 10) As String

        'cette fonction peut être utilisée pour générer aléatoirement un mot de passe
        'IMPORTANT: ne PAS l'utiliser pour générer le sel qu'on doit concaténer au mot de passe avant le hachage!

        Dim strChaine As String = ""
        Dim rand As New Random()

        For i As Integer = 1 To length
            Dim charNo As Integer = rand.Next(1, 62) ' Represents the 26 letters (lower and uppercase) and the 10 digits

            If charNo <= 10 Then ' Digits (1-10) : ASCII[48-57]
                charNo += 47
            ElseIf charNo <= 36 Then ' Uppercase letters (11-36) : ASCII[65-90]
                charNo += 54
            Else ' Lowercase letters (36-62) : ASCII[97-122]
                charNo += 60
            End If

            strChaine &= Chr(charNo)
        Next i

        Return strChaine

    End Function

    Public Function envoyerCourriel(sujet As String, nouveauMotDePasse As String, adresse As String) As Boolean
        Dim Mailmsg As New MailMessage()

        Try
            'définit L'adresse  
            '------------------
            Mailmsg.To.Add(New MailAddress(adresse))


            '------------------------------
            ' autres paramètres du courriel
            '------------------------------

            Mailmsg.Subject = sujet
            Mailmsg.Body = nouveauMotDePasse
            Mailmsg.IsBodyHtml = True
            Mailmsg.From = New MailAddress(PoolHockeyV1.My.Settings.SMTPAccount) ' voir le App.config

            '----------------------------
            ' prépare l'envoi du courriel
            '----------------------------

            Dim Smtp As New SmtpClient

            'ces 2 valeurs proviennent des paramètres du projet (sous "propriétés")
            'elles sont stockées dans le fichier App.config, où nous pouvons les modifier
            Smtp.Host = PoolHockeyV1.My.Settings.SMTPHost ' le serveur du cégep n'envoie que des courriel @cgmatane.qc.ca
            Smtp.Port = PoolHockeyV1.My.Settings.SMTPPort

            If False Then
                ' si on s'authentifie au serveur...
                ' (c'est ce qu'on doit faire pour éviter que nos courriels soient identifiés comme du spam)
                ' (ce code fonctionne si on utilise un compte gmail, SMTPHost=smtp.gmail.com)
                ' (facultatif si on utilise le serveur du cégep)
                Smtp.EnableSsl = True
                Smtp.UseDefaultCredentials = False
                ' la ligne suivante fonctionne sur gmail
                'Smtp.Credentials = New NetworkCredential(Courriel.My.Settings.SMTPAccount, Courriel.My.Settings.SMTPPassword) ' voir le App.config
                ' la ligne suivante fonctionnera éventuellement au cégep...
                Smtp.Credentials = New NetworkCredential("nicolasgagnon", "monmotdepasse", "cgmatane")
                Smtp.DeliveryMethod = SmtpDeliveryMethod.Network
            End If

            '-------------------
            ' envoie le courriel
            '-------------------

            Smtp.Send(Mailmsg)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Private Sub resetMPD_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles resetMPD.LinkClicked

        Dim QTA As New ALHDataSetTableAdapters.P_SELECT_MPD_PARIEURTableAdapter 'selecteur 
        Dim maTableDeMotDePasse As New DataTable
        Dim newPassWord As String
        Dim newSel As String
        maTableDeMotDePasse = QTA.GetData(TBCouriel.Text.ToString)


        Dim updatePasseword As New ALHDataSetTableAdapters.QueriesTableAdapter


        If maTableDeMotDePasse.Rows.Count = 0 Then
            'si le courriel n'existe pas
            MsgBox("renseigné un courriel valide  ", vbCritical, "Erreur lors de l'envoi du courriel")
        Else
            newSel = GenererSel()
            newPassWord = GenererChaineDeCaracteres()
            If envoyerCourriel("Voici votre nouveau mot de passe :D ", newPassWord, TBCouriel.Text.ToString) Then
                updatePasseword.P_UPDATE_NOUVEAU_PASSWORD(maTableDeMotDePasse.Rows(0).Item("idPar"), newSel, GenererHash(newPassWord, newSel))

                MsgBox("Votre mot de passe vous a été envoyer par mail (" + TBCouriel.Text.ToString + ")", vbInformation, "Changement réussi ")
            Else
                MsgBox("erreur lors de l'envoie du mail ,l'addresse courielle n'existe peut être pas ", vbCritical, "erreur envoie mail")
            End If
        End If

    End Sub

End Class