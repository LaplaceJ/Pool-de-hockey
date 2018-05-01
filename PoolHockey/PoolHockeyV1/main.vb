Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Imports System.Drawing
Imports System.Text.RegularExpressions
Public Class main

    Public QTAPublic As New ALHDataSetTableAdapters.QueriesTableAdapter
    Public idParieur As Integer   'constante parieur 
    Public coteMax As Integer  'cote max
    Public joueurMax As Integer



    Private Sub main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'action a la fermeture 
        e.Cancel = True

        Dim jeQuitte As Boolean = True
        'faire avec l'enum
        If demandeSauvegarde Then

            If MsgBox("vous devez sauvegarder vos informations", 36, "Erreur sauvegarde") = 6 Then
                Dim erreur = sauvegarderAvantDeQuitter()
                If erreur = "" Then
                Else
                    MsgBox(erreur, vbCritical, "Erreur sauvegarde")
                    jeQuitte = False
                End If
            End If
        Else
        End If

        If jeQuitte Then
            e.Cancel = False
        End If


    End Sub
    'joueur max

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'ALHDataSet4.P_SELECT_ANNEE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.P_SELECT_ANNEETableAdapter.Fill(Me.ALHDataSet4.P_SELECT_ANNEE)

        idParieur = motDePasse.idParieurConnexion
        'TODO: cette ligne de code charge les données dans la table 'ALHDataSet3.P_SELECT_EQUIPE_MODIFICATION_JOUEUR'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.P_SELECT_EQUIPE_MODIFICATION_JOUEURTableAdapter.Fill(Me.ALHDataSet3.P_SELECT_EQUIPE_MODIFICATION_JOUEUR)
        'TODO: cette ligne de code charge les données dans la table 'ALHDataSet.P_SELECT_REF_PARIEUR'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.P_SELECT_REF_PARIEURTableAdapter.Fill(Me.ALHDataSet.P_SELECT_REF_PARIEUR)
        'TODO: cette ligne de code charge les données dans la table 'ALHDataSet.P_SELECT_POSITION_MODIFICATION_JOUEUR'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.P_SELECT_POSITION_MODIFICATION_JOUEURTableAdapter.Fill(Me.ALHDataSet.P_SELECT_POSITION_MODIFICATION_JOUEUR)
        'TODO: cette ligne de code charge les données dans la table 'ALHDataSet2.P_SELECT_EQUIPE_MODIFICATION_JOUEUR'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.P_SELECT_EQUIPE_MODIFICATION_JOUEURTableAdapter.Fill(Me.ALHDataSet2.P_SELECT_EQUIPE_MODIFICATION_JOUEUR)
        'TODO: cette ligne de code charge les données dans la table 'ALHDataSet1.P_SELECT_PARIEUR_DGV'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.P_SELECT_PARIEUR_DGVTableAdapter.Fill(Me.ALHDataSet1.P_SELECT_PARIEUR_DGV)
        'TODO: cette ligne de code charge les données dans la table 'ALHDataSet.P_SELECT_ANNEE_FOR_DGV_CHOIX'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.P_SELECT_ANNEE_FOR_DGV_CHOIXTableAdapter.Fill(Me.ALHDataSet.P_SELECT_ANNEE_FOR_DGV_CHOIX)
        'TODO: cette ligne de code charge les données dans la table 'ALHDataSet.P_SELECT_ANNEE_FOR_DGV_CHOIX'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.P_SELECT_ANNEE_FOR_DGV_CHOIXTableAdapter.Fill(Me.ALHDataSet.P_SELECT_ANNEE_FOR_DGV_CHOIX)



        initParametre()


        Me.Text = "Système de gestion du pool d'hoskey ( " + QTAPublic.P_SELECT_NOM_PRENOM_PARIEUR(idParieur) + " )"




        'si utilisateur on masque la gestion 
        If QTAPublic.P_SELECT_TYPE_PARIEUR(idParieur) = 2 Then
        Else

            tableauControl1.TabPages.Remove(TabPage2)
            tableauControl1.TabPages.Remove(TabPage3)
            tableauControl1.TabPages.Remove(TabPage4)
        End If

        'init du texte de gestion parametre 
        TBMAXJoueur.Text = joueurMax.ToString
        TBMAXCote.Text = coteMax.ToString


        'init le DGV de gestion joueur
        If ComboBoxGestionJoueur.Items.Count = 0 Then
            gestionBoutonDGVJoueur()
        Else
            DGVGestionJoueur.DataSource = P_SELECT_JOUEUR_DGV_CHOIXTableAdapter.GetData(2, ComboBoxGestionJoueur.SelectedValue, idParieur)
            initDGV2()
        End If
        

        'init dgv Annee
        DGVAnnee.DataSource = P_SELECT_ANNEETableAdapter.GetData()
        initDGVAnnee()


        'init le DGV de gestion parieurs 
        DataGridViewGestionParieurs.DataSource = P_SELECT_PARIEUR_DGVTableAdapter.GetData()
        initDGV1()

        'init le DGV de mes choix 
        refreshDGVMesChoix()

        gestionBoutonDGVChoix()


    End Sub

    Private Enum casSauvegardeDGVChoix
        anneePasEnCourOuCB
        lesJoueursSelectSontExactementCeuxDuParieurs
        lesJoueursSelectneSontPasCeuxDuParieurs
    End Enum

    Private Enum quelleSauvegardeEstAFaire
        'permet de sauvegarder les infos de la bonne fenetre avant de quiter l'application ou de changer d'onglet 
        dgvMesChoix
        dgvJoueur
        dgvParieur
        dgvAnnee
        parametre
    End Enum

    Private demandeSauvegarde As Boolean 'demande la souvegarde avant de quiter
    Private sauvegardeAFaire As quelleSauvegardeEstAFaire
    Private casSauvegarde As casSauvegardeDGVChoix


    Private Sub ComboBoxMesChoix_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMesChoix.SelectedIndexChanged

        refreshDGVMesChoix()
        gestionBoutonDGVChoix()


    End Sub
    Private Sub DGVMesChoix_SelectionChanged(sender As Object, e As EventArgs) Handles DGVMesChoix.SelectionChanged
        softRefreshDGVMesChoix()

        'appeler le controleur bouton TODO + la pour verifier si le bouton save doit etre activé 
        gestionBoutonDGVChoix()
    End Sub

    Private Sub CheckBoxMesChoixJoueurSeulement_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMesChoixJoueurSeulement.CheckedChanged
        refreshDGVMesChoix()

    End Sub

    Private Sub SauvegarderLesModifications_Click(sender As Object, e As EventArgs) Handles SauvegarderLesModifications.Click
        Dim erreur As String = sauvegarderChoixParieur()
        If erreur = "" Then
            gestionBoutonDGVChoix()
            softRefreshDGVMesChoix()
        Else
            MsgBox(erreur, vbCritical, "Erreur sauvegarde ")
        End If

    End Sub
    Public Function refreshDGVMesChoix() As [Type]
        Dim allJoueur As Integer
        Dim nbJoueur As Integer = 0
        Dim coteTotal As Integer = 0

        Dim nbJoeurSelect As Integer
        Dim coteSomme As Integer

        If CheckBoxMesChoixJoueurSeulement.Checked Then
            allJoueur = 1
        Else
            allJoueur = 2
        End If

        'DAM c'est ici que je lance la recherche :D 
        DGVMesChoix.DataSource = P_SELECT_JOUEUR_DGV_CHOIXTableAdapter.GetData(allJoueur, ComboBoxMesChoix.SelectedValue, idParieur)
        Dim drChoix As DataRow

        Dim taChoixParieur As New ALHDataSetTableAdapters.P_SELECT_JOUEUR_DGV_CHOIXTableAdapter
        Dim dtChoixParieur As DataTable
        dtChoixParieur = taChoixParieur.GetData(1, ComboBoxMesChoix.SelectedValue, idParieur) 'parie²ééur seulement 

        DGVMesChoix.ClearSelection()

        If CheckBoxMesChoixJoueurSeulement.Checked Then
            DGVMesChoix.Enabled = False

            'on selectionne tous les joueur du parieur 
            nbJoeurSelect = DGVMesChoix.Rows.Count

            'on selectionne la cote total du parieur 
            coteSomme = (From row As DataGridViewRow In DGVMesChoix.Rows.Cast(Of DataGridViewRow)() _
                     Where row.Selected = False _
                     Select CInt(row.Cells(3).Value)).Sum

        Else
            DGVMesChoix.Enabled = True
            ' on boucle parmi les choix du parieur
            For Each drChoix In dtChoixParieur.Rows()
                ' on boucle parmi les joueurs affichés dans la datagridview
                For Each dgvrJoueur In DGVMesChoix.Rows
                    ' si on a une correspondance  entre les 2 joueurs
                    If dgvrJoueur.Cells(7).Value = drChoix("idJoueur") Then
                        ' on sélectionne la ligne du joueur car il fait partie des choix du parieur
                        dgvrJoueur.Selected = True
                    End If
                Next
            Next

            nbJoeurSelect = DGVMesChoix.SelectedRows.Count

            coteSomme = (From row As DataGridViewRow In DGVMesChoix.Rows.Cast(Of DataGridViewRow)() _
                     Where row.Selected = True _
                     Select CInt(row.Cells(3).Value)).Sum

        End If



        TBJSelectMesChoix.Text = nbJoeurSelect.ToString
        TBCSeclectMesChoix.Text = coteSomme.ToString

        If nbJoeurSelect > joueurMax Then
            TBJSelectMesChoix.BackColor = Color.Red
        Else
            TBJSelectMesChoix.BackColor = Color.Green
        End If

        If coteSomme > coteMax Then
            TBCSeclectMesChoix.BackColor = Color.Red
        Else
            TBCSeclectMesChoix.BackColor = Color.Green
        End If

        Return Nothing
    End Function

    Public Function isAnneeEnCours() As Boolean
        Dim touteLesAnnees As New ALHDataSetTableAdapters.P_SELECT_ANNEETableAdapter
        Dim dtTouteLesAnnees As DataTable
        Dim drTouteLesAnnees As DataRow

        'true annee => en cours 
        'false annee pas en cours 

        dtTouteLesAnnees = touteLesAnnees.GetData()
        For Each drTouteLesAnnees In dtTouteLesAnnees.Rows
            If (drTouteLesAnnees("idAnnee").ToString = ComboBoxMesChoix.SelectedValue) And (drTouteLesAnnees("SaisiEnCoursAnnee").ToString) Then
                Return True
            End If
        Next

        Return False
        Return Nothing
    End Function
    Public Function softRefreshDGVMesChoix() As [Type]

        Dim nbJoeurSelect As Integer
        Dim coteSomme As Integer




        nbJoeurSelect = DGVMesChoix.SelectedRows.Count

        'on selectionne la cote total du parieur 
        coteSomme = (From row As DataGridViewRow In DGVMesChoix.Rows.Cast(Of DataGridViewRow)() _
                 Where row.Selected = True _
                 Select CInt(row.Cells(3).Value)).Sum




        TBJSelectMesChoix.Text = nbJoeurSelect.ToString
        TBCSeclectMesChoix.Text = coteSomme.ToString

        If nbJoeurSelect > joueurMax Then
            TBJSelectMesChoix.BackColor = Color.Red
        Else
            TBJSelectMesChoix.BackColor = Color.Green
        End If

        If coteSomme > coteMax Then
            TBCSeclectMesChoix.BackColor = Color.Red
        Else
            TBCSeclectMesChoix.BackColor = Color.Green
        End If

        Return Nothing
    End Function
    Public Function joueurSelectTestParieurOuNon() As Type
        Dim drChoix As DataRow

        Dim taChoixParieur As New ALHDataSetTableAdapters.P_SELECT_JOUEUR_DGV_CHOIXTableAdapter
        Dim dtChoixParieur As DataTable
        dtChoixParieur = taChoixParieur.GetData(1, ComboBoxMesChoix.SelectedValue, idParieur) 'parie²ééur seulement 

        Dim monBooleanEnStockPourSavoirSiLeJoueurSelectionerEstUnJoueurDuParieurLaVariableEstTropLongue As Boolean = False
        Dim compteurDeJoueurDuParieur As Integer = 0


        ' on boucle parmi les joueurs affichés dans la datagridview
        For Each dgvrJoueur In DGVMesChoix.Rows
            ' on vérifie si seulement les joueur du parieur sont selectioné 
            If dgvrJoueur.Selected = True Then
                monBooleanEnStockPourSavoirSiLeJoueurSelectionerEstUnJoueurDuParieurLaVariableEstTropLongue = False
                For Each drChoix In dtChoixParieur.Rows()
                    If (dgvrJoueur.Cells(7).Value = drChoix("idJoueur")) Then
                        monBooleanEnStockPourSavoirSiLeJoueurSelectionerEstUnJoueurDuParieurLaVariableEstTropLongue = True
                    End If
                Next
                If monBooleanEnStockPourSavoirSiLeJoueurSelectionerEstUnJoueurDuParieurLaVariableEstTropLongue Then
                    'on compte le nombre de joueur trouver 
                    compteurDeJoueurDuParieur += 1
                Else
                    Me.SauvegarderLesModifications.Enabled = True
                    casSauvegarde = casSauvegardeDGVChoix.lesJoueursSelectneSontPasCeuxDuParieurs
                    Return Nothing
                End If
            End If
        Next

        'si on a trouver tous les joueur du parieur 
        If dtChoixParieur.Rows().Count = compteurDeJoueurDuParieur Then
            casSauvegarde = casSauvegardeDGVChoix.lesJoueursSelectSontExactementCeuxDuParieurs
            Return Nothing
        End If
        casSauvegarde = casSauvegardeDGVChoix.lesJoueursSelectneSontPasCeuxDuParieurs
        Return Nothing


    End Function
    

    Public Function sauvegarderChoixParieur() As String 'false => erreur sauvegarde / true sauvegarde réussie 
        'Si le nombre de joueur ou la cote est dépassés 
        Dim nbJoeurSelect As Integer
        Dim coteSomme As Integer
        Dim erreur As String = ""

        nbJoeurSelect = DGVMesChoix.SelectedRows.Count

        'on selectionne la cote total du parieur 
        coteSomme = (From row As DataGridViewRow In DGVMesChoix.Rows.Cast(Of DataGridViewRow)() _
                 Where row.Selected = True _
                 Select CInt(row.Cells(3).Value)).Sum

        TBJSelectMesChoix.Text = nbJoeurSelect.ToString
        TBCSeclectMesChoix.Text = coteSomme.ToString

        If nbJoeurSelect > joueurMax Or coteSomme > coteMax Then
            Return "Erreur le nombre de joueurs ou la côte totale est dépassé"
        End If


        Dim connexion As New System.Data.SqlClient.SqlConnection
        Dim commande As New System.Data.SqlClient.SqlCommand
        Dim transaction As System.Data.SqlClient.SqlTransaction

        Try

            'ouverture de la connexion
            connexion.ConnectionString = PoolHockeyV1.My.Settings.ALHConnectionString
            connexion.Open()

            'BEGIN TRANSACTION
            transaction = connexion.BeginTransaction

            'création de la commande Supprimer
            commande.Connection = connexion
            commande.CommandType = CommandType.StoredProcedure
            commande.CommandText = "P_INSERT_NOUVEAU_JOUEUR_POUR_PARIEUR"

            commande.Transaction = transaction

            '--------------------------
            'SUPPRESSION 

            commande.Parameters.Add("idJoueur", SqlDbType.Int)
            commande.Parameters.Add("idParieur", SqlDbType.Int)
            commande.Parameters.Add("idAnnee", SqlDbType.Int)
            commande.Parameters.Add("suppression", SqlDbType.Int)
            commande.Parameters(0).Value = 0
            commande.Parameters(1).Value = idParieur
            commande.Parameters(2).Value = ComboBoxMesChoix.SelectedValue
            commande.Parameters(3).Value = 1

            commande.ExecuteNonQuery()


            For Each row As DataGridViewRow In DGVMesChoix.Rows
                ' on vérifie si seulement les joueur du parieur sont selectioné 
                If row.Selected = True Then
                    commande.Parameters.Clear()
                    commande.Parameters.Add("idJoueur", SqlDbType.Int)
                    commande.Parameters.Add("idParieur", SqlDbType.Int)
                    commande.Parameters.Add("idAnnee", SqlDbType.Int)
                    commande.Parameters.Add("suppression", SqlDbType.Int)
                    commande.Parameters(0).Value = row.Cells(7).Value()
                    commande.Parameters(1).Value = idParieur
                    commande.Parameters(2).Value = ComboBoxMesChoix.SelectedValue
                    commande.Parameters(3).Value = 0

                    commande.ExecuteNonQuery()
                End If
            Next


            '--------------------------

            'COMMIT TRANSACTION
            transaction.Commit()





        Catch ex As Exception

            'ROLLBACK TRANSACTION
            transaction.Rollback()
            erreur = "Erreur lors de la sauvegarde"
        Finally

            'fermeture de la connexion
            connexion.Close()

        End Try


        'faire la transaction 

        'Dim QTA As New ALHDataSetTableAdapters.QueriesTableAdapter

        'QTA.P_INSERT_NOUVEAU_JOUEUR_POUR_PARIEUR(0, idParieur, ComboBoxMesChoix.SelectedValue, 1)

        '' on boucle parmi les joueurs affichés dans la datagridview
        'For Each dgvrJoueur In DGVMesChoix.Rows
        '    'on vérifie si seulement les joueur du parieur sont selectioné 
        '    If dgvrJoueur.Selected = True Then
        '        'insert
        '        QTA.P_INSERT_NOUVEAU_JOUEUR_POUR_PARIEUR(dgvrJoueur.Cells(7).Value(), idParieur, ComboBoxMesChoix.SelectedValue, 0)
        '    End If
        'Next

        
        Return erreur
    End Function

    Public Function gestionBoutonDGVChoix() As [Type]

        'set les différent état 
        If isAnneeEnCours() Then
            joueurSelectTestParieurOuNon()
        Else
            casSauvegarde = casSauvegardeDGVChoix.anneePasEnCourOuCB
        End If
        If CheckBoxMesChoixJoueurSeulement.Checked = True Then
            casSauvegarde = casSauvegardeDGVChoix.anneePasEnCourOuCB
        End If




        Select Case casSauvegarde
            Case casSauvegardeDGVChoix.anneePasEnCourOuCB
                DGVMesChoix.Enabled = True
                SauvegarderLesModifications.Enabled = False


                demandeSauvegarde = False


            Case casSauvegardeDGVChoix.lesJoueursSelectSontExactementCeuxDuParieurs
                DGVMesChoix.Enabled = True
                SauvegarderLesModifications.Enabled = False

                demandeSauvegarde = False
                'modif

            Case casSauvegardeDGVChoix.lesJoueursSelectneSontPasCeuxDuParieurs

                DGVMesChoix.Enabled = True
                SauvegarderLesModifications.Enabled = True

                demandeSauvegarde = True
                'modif

                'type de sauvegarde a faire 
                sauvegardeAFaire = quelleSauvegardeEstAFaire.dgvMesChoix

        End Select


        'refresh le DGV 

        softRefreshDGVMesChoix()


        Return Nothing


    End Function









    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV MES JOUEURS////////////////////////////////////////////////

    Private Enum operationEnableBoutonDGVJoueur
        noSelect
        cellSelect
        inAjout_modifier
    End Enum

    Private Enum operationUpOrInDGVJoueur
        insert
        update
    End Enum
    Private opUpOrInDGVJoueur As operationUpOrInDGVJoueur
    Private opDGVJoueurBoutton As operationEnableBoutonDGVJoueur
    Private currentRowJoueurs As Integer
    Private Sub ComboBoxGestionJoueur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxGestionJoueur.SelectedIndexChanged

        'init le DGV de gestion joueur
        DGVGestionJoueur.DataSource = P_SELECT_JOUEUR_DGV_CHOIXTableAdapter.GetData(2, ComboBoxGestionJoueur.SelectedValue, idParieur)

        'le clique date va set operationEnableBoutonDGVJoueur 
        setOpDGVJoueurBoutton(False)
    End Sub

    Private Sub DGVGestionJoueur_SelectionChanged(sender As Object, e As EventArgs) Handles DGVGestionJoueur.SelectionChanged
        'le clique dans le DGV set operationEnableBoutonDGVJoueur 
        currentRowJoueurs = DGVGestionJoueur.CurrentRow.Index
        refreshDGVGestionJoueur()
        setOpDGVJoueurBoutton(False)

    End Sub


    Private Sub BouttonAjouterDGVJoueur_Click(sender As Object, e As EventArgs) Handles BouttonAjouterDGVJoueur.Click
        'le clique va set operationEnableBoutonDGVJoueur 
        setOpDGVJoueurBoutton(True)
        opUpOrInDGVJoueur = operationUpOrInDGVJoueur.insert
        'on vide les informations du bas 
        viderLesChoixDGVJoueur()
    End Sub

    Private Sub boutonModifierDGVJoueur_Click(sender As Object, e As EventArgs) Handles boutonModifierDGVJoueur.Click
        'le clique va set operationEnableBoutonDGVJoueur 
        setOpDGVJoueurBoutton(True)
        opUpOrInDGVJoueur = operationUpOrInDGVJoueur.update
    End Sub

    Private Sub boutonSupprimerDGVJoueur_Click(sender As Object, e As EventArgs) Handles boutonSupprimerDGVJoueur.Click
        'le clique va set operationEnableBoutonDGVJoueur 

        Dim reponse As Integer = MsgBox("Désirez-vous supprimer l'élément sélectionné", 36, "Supprimer ? ")
        If reponse = 6 Then
            'Ok

            'suppression
            QTAPublic.P_DELETE_JOUEUR_ET_JOUE(DGVGestionJoueur.Item(7, currentRowJoueurs).Value, ComboBoxGestionJoueur.SelectedValue)

            'on actualise le DGV
            DGVGestionJoueur.DataSource = P_SELECT_JOUEUR_DGV_CHOIXTableAdapter.GetData(2, ComboBoxGestionJoueur.SelectedValue, idParieur)
            setOpDGVJoueurBoutton(False)
        End If


    End Sub

    Private Sub boutonSauvegarderDGVJoueur_Click(sender As Object, e As EventArgs) Handles boutonSauvegarderDGVJoueur.Click
        'le clique va set operationEnableBoutonDGVJoueur 
        Dim erreur As String = sauvegardeDGVJoueur()
        If erreur = "" Then
        Else
            MsgBox(erreur, vbCritical, "Erreur sélection")

        End If
    End Sub

    Private Sub boutonAnnulerDGVJoueur_Click(sender As Object, e As EventArgs) Handles boutonAnnulerDGVJoueur.Click
        'le clique va set operationEnableBoutonDGVJoueur 
        setOpDGVJoueurBoutton(False)

        refreshDGVGestionJoueur()
    End Sub

    Public Function sauvegardeDGVJoueur() As String
        Dim erreur As String = isInformationNonRempli()
        If erreur = "" Then
            setUporInApresSave()
            setOpDGVJoueurBoutton(False)
            'on actualise le DGV
            DGVGestionJoueur.DataSource = P_SELECT_JOUEUR_DGV_CHOIXTableAdapter.GetData(2, ComboBoxGestionJoueur.SelectedValue, idParieur)
            selectElementModifierInsererJoueur()
            refreshDGVGestionJoueur()
            refreshDGVMesChoix()

        End If

        Return erreur
    End Function
    Public Function selectElementModifierInsererJoueur() As [Type]
        Dim dernierIdJoueur As Integer = QTAPublic.P_SELECT_lastIdModifierInserer()
        DGVGestionJoueur.ClearSelection()
        For Each row In DGVGestionJoueur.Rows
            ' on vérifie si seulement les joueur du parieur sont selectioné 
            If row.Cells(7).Value() = dernierIdJoueur Then
                DGVGestionJoueur.Rows(row.index).Selected = True
                currentRowJoueurs = row.index



                Return Nothing
            End If
        Next

        Return Nothing
    End Function
    Public Function setUporInApresSave() As [Type]
        Dim nomJoueur As String = TextBoxGestionJoueurNom.Text
        Dim prenomJoueur As String = TextBoxGestionJoueurPrenom.Text
        Dim position As String = ComboBoxGestionJoueurPosition.SelectedValue

        Dim cote As Integer = TextBoxGestionJoueurCote.Text
        Dim passes As Integer = TextBoxGestionJoueurPasses.Text
        Dim buts As Integer = TextBoxGestionJoueurButs.Text

        Dim idEquipe As Integer = ComboBoxGestionJoueurEquipe.SelectedValue
        Dim idAnnee As Integer = ComboBoxGestionJoueur.SelectedValue



        Select Case opUpOrInDGVJoueur
            Case operationUpOrInDGVJoueur.insert
                QTAPublic.P_INSERT_JOUEUR_ET_JOUE(nomJoueur, prenomJoueur, position, cote, buts, passes, idEquipe, idAnnee)
            Case operationUpOrInDGVJoueur.update
                Dim idJoueur As Integer = DGVGestionJoueur.Item(7, currentRowJoueurs).Value
                QTAPublic.P_UPDATE_JOUEUR_ET_JOUE(nomJoueur, prenomJoueur, position, cote, buts, passes, idEquipe, idAnnee, idJoueur)

        End Select



        Return Nothing
    End Function

    'set opDGVJoueurBoutton
    Public Function setOpDGVJoueurBoutton(jeSuisIn As Boolean) As [Type]
        If jeSuisIn Then
            opDGVJoueurBoutton = operationEnableBoutonDGVJoueur.inAjout_modifier
        Else
            'aucune ranger selectionner 
            If DGVGestionJoueur.SelectedRows.Count = 0 Then
                opDGVJoueurBoutton = operationEnableBoutonDGVJoueur.noSelect

            Else
                opDGVJoueurBoutton = operationEnableBoutonDGVJoueur.cellSelect
            End If


        End If
        gestionBoutonDGVJoueur()


        Return Nothing
    End Function

    'cette fonction permet de selectionner/déseclionner les boutons 
    Public Function gestionBoutonDGVJoueur() As [Type]
       

        Select Case opDGVJoueurBoutton
            Case operationEnableBoutonDGVJoueur.noSelect

                'date
                ComboBoxGestionJoueur.Enabled = True
                DGVGestionJoueur.Enabled = True


                'but action sup/in/mod
                BouttonAjouterDGVJoueur.Enabled = True
                boutonModifierDGVJoueur.Enabled = False
                boutonSupprimerDGVJoueur.Enabled = False

                'bas but 
                boutonSauvegarderDGVJoueur.Enabled = False
                boutonAnnulerDGVJoueur.Enabled = False

                'bas form
                TextBoxGestionJoueurNom.Enabled = False
                TextBoxGestionJoueurPrenom.Enabled = False
                TextBoxGestionJoueurCote.Enabled = False
                TextBoxGestionJoueurButs.Enabled = False
                TextBoxGestionJoueurPasses.Enabled = False
                ComboBoxGestionJoueurEquipe.Enabled = False
                ComboBoxGestionJoueurPosition.Enabled = False

                viderLesChoixDGVJoueur()
                demandeSauvegarde = False

            Case operationEnableBoutonDGVJoueur.cellSelect

                'date
                ComboBoxGestionJoueur.Enabled = True
                DGVGestionJoueur.Enabled = True


                'but action sup/in/mod
                BouttonAjouterDGVJoueur.Enabled = True
                boutonModifierDGVJoueur.Enabled = True
                boutonSupprimerDGVJoueur.Enabled = True

                'bas but 
                boutonSauvegarderDGVJoueur.Enabled = False
                boutonAnnulerDGVJoueur.Enabled = False

                'bas form
                TextBoxGestionJoueurNom.Enabled = False
                TextBoxGestionJoueurPrenom.Enabled = False
                TextBoxGestionJoueurCote.Enabled = False
                TextBoxGestionJoueurButs.Enabled = False
                TextBoxGestionJoueurPasses.Enabled = False

                ComboBoxGestionJoueurEquipe.Enabled = False


                ComboBoxGestionJoueurPosition.Enabled = False
                demandeSauvegarde = False

            Case operationEnableBoutonDGVJoueur.inAjout_modifier

                'date
                ComboBoxGestionJoueur.Enabled = False

                DGVGestionJoueur.Enabled = False


                'but action sup/in/mod
                BouttonAjouterDGVJoueur.Enabled = False
                boutonModifierDGVJoueur.Enabled = False
                boutonSupprimerDGVJoueur.Enabled = False

                'bas but 
                boutonSauvegarderDGVJoueur.Enabled = True
                boutonAnnulerDGVJoueur.Enabled = True

                'bas form
                TextBoxGestionJoueurNom.Enabled = True
                TextBoxGestionJoueurPrenom.Enabled = True
                TextBoxGestionJoueurCote.Enabled = True
                TextBoxGestionJoueurButs.Enabled = True
                TextBoxGestionJoueurPasses.Enabled = True
                ComboBoxGestionJoueurEquipe.Enabled = True
                ComboBoxGestionJoueurPosition.Enabled = True

                demandeSauvegarde = True

                sauvegardeAFaire = quelleSauvegardeEstAFaire.dgvJoueur

        End Select

        If ComboBoxGestionJoueur.Items.Count = 0 Then
            'date
            ComboBoxGestionJoueur.Enabled = True
            DGVGestionJoueur.Enabled = True


            'but action sup/in/mod
            BouttonAjouterDGVJoueur.Enabled = False
            boutonModifierDGVJoueur.Enabled = False
            boutonSupprimerDGVJoueur.Enabled = False

            'bas but 
            boutonSauvegarderDGVJoueur.Enabled = False
            boutonAnnulerDGVJoueur.Enabled = False

            'bas form
            TextBoxGestionJoueurNom.Enabled = False
            TextBoxGestionJoueurPrenom.Enabled = False
            TextBoxGestionJoueurCote.Enabled = False
            TextBoxGestionJoueurButs.Enabled = False
            TextBoxGestionJoueurPasses.Enabled = False
            ComboBoxGestionJoueurEquipe.Enabled = False
            ComboBoxGestionJoueurPosition.Enabled = False

            viderLesChoixDGVJoueur()
            demandeSauvegarde = False
        End If


        Return Nothing


    End Function
    Public Function isInformationNonRempli() As String
        Dim patterne As String = "[0-9]"
        Dim expressionPourCote As Match = Regex.Match(TextBoxGestionJoueurCote.Text, patterne, RegexOptions.IgnoreCase)
        Dim expressionPourButs As Match = Regex.Match(TextBoxGestionJoueurButs.Text, patterne, RegexOptions.IgnoreCase)
        Dim expressionPourPasses As Match = Regex.Match(TextBoxGestionJoueurPasses.Text, patterne, RegexOptions.IgnoreCase)

        If TextBoxGestionJoueurNom.Text = "" Then
            Return "Erreur un ou des champ(s) sont vide(s)"
        ElseIf TextBoxGestionJoueurPrenom.Text = "" Then
            Return "Erreur un ou des champ(s) sont vide(s)"
        ElseIf TextBoxGestionJoueurCote.Text = "" Then
            Return "Erreur un ou des champ(s) sont vide(s)"
        ElseIf TextBoxGestionJoueurButs.Text = "" Then
            Return "Erreur un ou des champ(s) sont vide(s)"
        ElseIf TextBoxGestionJoueurPasses.Text = "" Then
            Return "Erreur un ou des champ(s) sont vide(s)"
        ElseIf ComboBoxGestionJoueurEquipe.SelectedIndex = -1 Then
            Return "Erreur un ou des champ(s) sont vide(s)"
        ElseIf ComboBoxGestionJoueurPosition.SelectedIndex = -1 Then
            Return "Erreur un ou des champ(s) sont vide(s)"
        ElseIf expressionPourCote.Success = False Then
            Return "Erreur le texte de côte n'est pas numérique"
        ElseIf expressionPourButs.Success = False Then
            Return "Erreur le texte de buts n'est pas numérique"
        ElseIf expressionPourPasses.Success = False Then
            Return "Erreur le texte de passes n'est pas numérique"

        End If

        Try
            If Convert.ToInt32(TextBoxGestionJoueurButs.Text) < 0 Then
                Return "Le nombre de buts ne doit pas être négatif"
            End If
            If Convert.ToInt32(TextBoxGestionJoueurPasses.Text) < 0 Then
                Return "Le nombre de passes ne doit pas être négatif"
            End If
            If Convert.ToInt32(TextBoxGestionJoueurCote.Text) < 0 Then
                Return "La côte ne doit pas être négative"
            End If
        Catch ex As Exception
            Return "Le nombre rentré ne doit pas être supérieur à 2 147 483 647 (taille maximum d'un integer 32 bits)"
        End Try



        Return ""


    End Function
    Public Function viderLesChoixDGVJoueur() As [Type]

        TextBoxGestionJoueurNom.Text = ""
        TextBoxGestionJoueurPrenom.Text = ""
        TextBoxGestionJoueurCote.Text = ""
        TextBoxGestionJoueurButs.Text = ""
        TextBoxGestionJoueurPasses.Text = ""
        ComboBoxGestionJoueurEquipe.SelectedIndex = -1
        ComboBoxGestionJoueurPosition.SelectedIndex = -1

        Return Nothing
    End Function

    Public Function refreshDGVGestionJoueur() As [Type]
        If DGVGestionJoueur.RowCount = 0 Then
        Else
            Dim indexLigne As Integer
            indexLigne = currentRowJoueurs

            Dim parts As String() = DGVGestionJoueur.Item(0, indexLigne).Value.Split(New Char() {" "c})

            TextBoxGestionJoueurNom.Text = parts(0)
            TextBoxGestionJoueurPrenom.Text = parts(1)
            TextBoxGestionJoueurCote.Text = DGVGestionJoueur.Item(3, indexLigne).Value
            TextBoxGestionJoueurButs.Text = DGVGestionJoueur.Item(4, indexLigne).Value
            TextBoxGestionJoueurPasses.Text = DGVGestionJoueur.Item(5, indexLigne).Value
            ComboBoxGestionJoueurEquipe.Text = DGVGestionJoueur.Item(1, indexLigne).Value
            ComboBoxGestionJoueurPosition.Text = DGVGestionJoueur.Item(2, indexLigne).Value

        End If
        Return Nothing
    End Function

    Public Function initDGV2() As [Type]

        If DGVGestionJoueur.RowCount = 0 Then

        Else
            Dim indexLigne As Integer = 0

            Dim parts As String() = DGVGestionJoueur.Item(0, indexLigne).Value.Split(New Char() {" "c})

            TextBoxGestionJoueurNom.Text = parts(0)
            TextBoxGestionJoueurPrenom.Text = parts(1)
            TextBoxGestionJoueurCote.Text = DGVGestionJoueur.Item(3, indexLigne).Value
            TextBoxGestionJoueurButs.Text = DGVGestionJoueur.Item(4, indexLigne).Value
            TextBoxGestionJoueurPasses.Text = DGVGestionJoueur.Item(5, indexLigne).Value
            ComboBoxGestionJoueurEquipe.Text = DGVGestionJoueur.Item(1, indexLigne).Value
            ComboBoxGestionJoueurPosition.Text = DGVGestionJoueur.Item(2, indexLigne).Value
        End If

        Return Nothing
    End Function

    '/////////////////////////////////////////////////////DGV PARIEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV PARIEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV PARIEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV PARIEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV PARIEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV PARIEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV PARIEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV PARIEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV PARIEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV PARIEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV PARIEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV PARIEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV PARIEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV PARIEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV PARIEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV PARIEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV PARIEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV PARIEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV PARIEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV PARIEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV PARIEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV PARIEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV PARIEURS////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV PARIEURS////////////////////////////////////////////////
    Private Enum operationEnableBoutonDGVParieur
        noSelect
        cellSelect
        inAjout_modifier
    End Enum
    Private Enum operationUpOrInDGVParieur
        insert
        update

    End Enum

    Dim opEnableBoutonDGVParieur As operationEnableBoutonDGVParieur
    Dim opUpOrInDGVParieur As operationEnableBoutonDGVParieur
    Dim currentRowParieur As Integer

    Private Sub DataGridViewGestionParieurs_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewGestionParieurs.SelectionChanged
        currentRowParieur = DataGridViewGestionParieurs.CurrentRow.Index
        refreshDGVGestionParieur()
        setOpDGVParieurBoutton(False)
    End Sub
    Private Sub boutonAjouterDGVParieur_Click(sender As Object, e As EventArgs) Handles boutonAjouterDGVParieur.Click
        setOpDGVParieurBoutton(True)
        opUpOrInDGVParieur = operationUpOrInDGVParieur.insert
        viderLesChoixDGVParieur()
    End Sub

    Private Sub boutonModifierDGVParieur_Click(sender As Object, e As EventArgs) Handles boutonModifierDGVParieur.Click
        setOpDGVParieurBoutton(True)
        opUpOrInDGVParieur = operationUpOrInDGVParieur.update
    End Sub

    Private Sub boutonSupprimerDGVParieur_Click(sender As Object, e As EventArgs) Handles boutonSupprimerDGVParieur.Click
        Dim reponse As Integer = MsgBox("Désirez-vous supprimer l'élément sélectionné", 36, "Supprimer ? ")
        If reponse = 6 Then
            If DataGridViewGestionParieurs.Item(3, currentRowParieur).Value = idParieur Then
                MsgBox("vous ne pouvez pas vous supprimer vous-même >< ", vbCritical, "Erreur sélection ")
            Else
                'suppression
                QTAPublic.P_DELETE_PARIEUR(DataGridViewGestionParieurs.Item(3, currentRowParieur).Value)
                'on actualise le DGV
                DataGridViewGestionParieurs.DataSource = P_SELECT_PARIEUR_DGVTableAdapter.GetData()
                setOpDGVParieurBoutton(False)
            End If

            
        End If
    End Sub

    Private Sub boutonSauvegarderDGVParieur_Click(sender As Object, e As EventArgs) Handles boutonSauvegarderDGVParieur.Click
        Dim erreur As String = sauvegarderDGVParieur()

        If erreur = "" Then
        Else

            MsgBox(erreur, vbCritical, "Erreur sélection")

        End If
    End Sub

    Private Sub boutonAnnulerDGVParieur_Click(sender As Object, e As EventArgs) Handles boutonAnnulerDGVParieur.Click
        setOpDGVParieurBoutton(False)

        refreshDGVGestionParieur()
    End Sub
    Public Function selectElementModifierInsererParieur() As [Type]
        Dim dernierIdParieur As Integer = QTAPublic.P_SELECT_lastIdModifierInserer()


        For Each row In DataGridViewGestionParieurs.Rows
            ' on vérifie si seulement les joueur du parieur sont selectioné 
            If row.Cells(3).Value() = dernierIdParieur Then
                DataGridViewGestionParieurs.Rows(row.index).Selected = True
                currentRowParieur = row.index
            End If
        Next

        Return Nothing

    End Function
    Public Function sauvegarderDGVParieur() As String
        Dim erreur As String = isInformationNonRempliParieur()

        If erreur = "" Then
            setUporInApresSaveParieur()
            setOpDGVParieurBoutton(False)
            'on actualise le DGV
            DataGridViewGestionParieurs.DataSource = P_SELECT_PARIEUR_DGVTableAdapter.GetData()
            selectElementModifierInsererParieur()
            refreshDGVGestionParieur()

        Else
        End If
        Return erreur

    End Function

    'cette fonction permet de selectionner/déseclionner les boutons 
    Public Function gestionBoutonDGVParieur() As [Type]

        Select Case opEnableBoutonDGVParieur
            Case operationEnableBoutonDGVParieur.noSelect

                DataGridViewGestionParieurs.Enabled = True


                'but action sup/in/mod
                boutonAjouterDGVParieur.Enabled = True
                boutonModifierDGVParieur.Enabled = False
                boutonSupprimerDGVParieur.Enabled = False

                'bas but 
                boutonSauvegarderDGVParieur.Enabled = False
                boutonAnnulerDGVParieur.Enabled = False

                'bas form
                TextBoxNomGestionParieur.Enabled = False
                TextBoxPrenomGestionParieurs.Enabled = False
                TextBoxCourielleGestionParieurs.Enabled = False
                ComboBoxTypesGestionParieurs.Enabled = False

                'modif
                viderLesChoixDGVParieur()
                demandeSauvegarde = False
                'modif
            Case operationEnableBoutonDGVParieur.cellSelect

                DataGridViewGestionParieurs.Enabled = True

                'but action sup/in/mod
                boutonAjouterDGVParieur.Enabled = True
                boutonModifierDGVParieur.Enabled = True
                boutonSupprimerDGVParieur.Enabled = True

                'bas but 
                boutonSauvegarderDGVParieur.Enabled = False
                boutonAnnulerDGVParieur.Enabled = False

                'bas form
                TextBoxNomGestionParieur.Enabled = False
                TextBoxPrenomGestionParieurs.Enabled = False
                TextBoxCourielleGestionParieurs.Enabled = False
                ComboBoxTypesGestionParieurs.Enabled = False



                'modif
                demandeSauvegarde = False
                'modif

            Case operationEnableBoutonDGVParieur.inAjout_modifier

                DataGridViewGestionParieurs.Enabled = False

                'but action sup/in/mod
                boutonAjouterDGVParieur.Enabled = False
                boutonModifierDGVParieur.Enabled = False
                boutonSupprimerDGVParieur.Enabled = False

                'bas but 
                boutonSauvegarderDGVParieur.Enabled = True
                boutonAnnulerDGVParieur.Enabled = True

                'bas form
                TextBoxNomGestionParieur.Enabled = True
                TextBoxPrenomGestionParieurs.Enabled = True
                TextBoxCourielleGestionParieurs.Enabled = True
                ComboBoxTypesGestionParieurs.Enabled = True

                'modif
                demandeSauvegarde = True

                sauvegardeAFaire = quelleSauvegardeEstAFaire.dgvParieur

        End Select


        Return Nothing


    End Function
    Public Function viderLesChoixDGVParieur() As [Type]

        TextBoxNomGestionParieur.Text = ""
        TextBoxPrenomGestionParieurs.Text = ""
        TextBoxCourielleGestionParieurs.Text = ""
        ComboBoxTypesGestionParieurs.SelectedIndex = -1


        Return Nothing
    End Function

    Public Function refreshDGVGestionParieur() As [Type]

        Dim indexLigne As Integer
        indexLigne = currentRowParieur

        Dim parts As String() = DataGridViewGestionParieurs.Item(0, indexLigne).Value.Split(",")

        TextBoxNomGestionParieur.Text = parts(0)
        TextBoxPrenomGestionParieurs.Text = parts(1)
        TextBoxCourielleGestionParieurs.Text = DataGridViewGestionParieurs.Item(2, indexLigne).Value
        ComboBoxTypesGestionParieurs.Text = DataGridViewGestionParieurs.Item(1, indexLigne).Value

        Return Nothing
    End Function



    Public Function initDGV1() As [Type]

        If DataGridViewGestionParieurs.RowCount = 0 Then

        Else
            Dim indexLigne As Integer = 0

            Dim parts As String() = DataGridViewGestionParieurs.Item(0, indexLigne).Value.Split(",")

            TextBoxNomGestionParieur.Text = parts(0)
            TextBoxPrenomGestionParieurs.Text = parts(1)
            TextBoxCourielleGestionParieurs.Text = DataGridViewGestionParieurs.Item(2, indexLigne).Value
            ComboBoxTypesGestionParieurs.Text = DataGridViewGestionParieurs.Item(1, indexLigne).Value
        End If

        Return Nothing
    End Function

    Public Function isInformationNonRempliParieur() As String
        'paterne juste pour matane 
        '  Dim patterne As String = "(\w{1,})@(cgmatane\.qc\.ca)"
        Dim patterne As String = "(\w{1,})@(\w{1,})"
        Dim expressionPourMail As Match = Regex.Match(TextBoxCourielleGestionParieurs.Text, patterne, RegexOptions.IgnoreCase)

        If TextBoxNomGestionParieur.Text = "" Then
            Return "Erreur un ou des champ(s) sont vide(s)"
        ElseIf TextBoxPrenomGestionParieurs.Text = "" Then
            Return "Erreur un ou des champ(s) sont vide(s)"
        ElseIf TextBoxCourielleGestionParieurs.Text = "" Then
            Return "Erreur un ou des champ(s) sont vide(s)"
        ElseIf ComboBoxTypesGestionParieurs.SelectedIndex = -1 Then
            Return "Erreur un ou des champ(s) sont vide(s)"
        ElseIf expressionPourMail.Success = False Then
            ' Return "erreur format mail (x@cgmatane.qc.ca  pour x étant n'importe quel caractère alphanumérique) "
            Return "Erreur format mail (x@x  pour x étant n'importe quel caractère alphanumérique) "

        End If

        Return ""


    End Function

    Public Function setOpDGVParieurBoutton(jeSuisIn As Boolean) As [Type]
        If jeSuisIn Then
            opEnableBoutonDGVParieur = operationEnableBoutonDGVParieur.inAjout_modifier
        Else
            'aucune ranger selectionner 
            If DataGridViewGestionParieurs.SelectedRows.Count = 0 Then
                opEnableBoutonDGVParieur = operationEnableBoutonDGVParieur.noSelect

            Else
                opEnableBoutonDGVParieur = operationEnableBoutonDGVParieur.cellSelect
            End If


        End If
        gestionBoutonDGVParieur()


        Return Nothing
    End Function

    Public Function setUporInApresSaveParieur() As [Type]
        Dim nomParieur As String = TextBoxNomGestionParieur.Text
        Dim prenomParieur As String = TextBoxPrenomGestionParieurs.Text
        Dim mailParieur As String = TextBoxCourielleGestionParieurs.Text

        Dim typeParieur As Integer = ComboBoxTypesGestionParieurs.SelectedValue




        Select Case opUpOrInDGVParieur
            Case operationUpOrInDGVJoueur.insert
                QTAPublic.P_INSERT_Parieur(nomParieur, prenomParieur, mailParieur, typeParieur)
            Case operationUpOrInDGVJoueur.update
                Dim idParieurici As Integer = DataGridViewGestionParieurs.Item(3, currentRowParieur).Value
                QTAPublic.P_UPDATE_PARIEUR(nomParieur, prenomParieur, mailParieur, typeParieur, idParieurici)

        End Select



        Return Nothing
    End Function
    '/////////////////////////////////////////////////////DGV ANNEE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV ANNEE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV ANNEE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV ANNEE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV ANNEE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV ANNEE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV ANNEE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV ANNEE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV ANNEE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV ANNEE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV ANNEE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV ANNEE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV ANNEE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV ANNEE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV ANNEE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV ANNEE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV ANNEE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV ANNEE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV ANNEE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV ANNEE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV ANNEE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV ANNEE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV ANNEE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////DGV ANNEE//////////////////////////////////////////////////
    Private Enum operationEnableBoutonDGVAnnee
        noSelect
        cellSelect
        inAjout
        inModifier
    End Enum
    Private Enum operationUpOrInDGVAnnee
        insert
        update

    End Enum

    Dim opEnableBoutonDGVAnnee As operationEnableBoutonDGVAnnee
    Dim opUpOrInDGVAnnee As operationUpOrInDGVAnnee
    Dim currentRowAnnee As Integer
    Dim currentRowModifier As Integer



    Private Sub DGVAnnee_SelectionChanged(sender As Object, e As EventArgs) Handles DGVAnnee.SelectionChanged
        currentRowAnnee = DGVAnnee.CurrentRow.Index
        refreshDGVAnnee()
        setOpDGVAnneeBoutton(False, False)
    End Sub
    Private Sub boutonAjouterAnnee_Click(sender As Object, e As EventArgs) Handles boutonAjouterAnnee.Click
        'le clique va set operationEnableBoutonDGVJoueur 
        setOpDGVAnneeBoutton(True, True)
        opUpOrInDGVAnnee = operationUpOrInDGVAnnee.insert
        'on vide les informations du bas 
        viderLesChoixDGVAnnee()
    End Sub

    Private Sub boutonModifierAnnee_Click(sender As Object, e As EventArgs) Handles boutonModifierAnnee.Click
        'le clique va set operationEnableBoutonDGVJoueur 
        currentRowModifier = DGVAnnee.CurrentRow.Index
        setOpDGVAnneeBoutton(True, False)
        opUpOrInDGVAnnee = operationUpOrInDGVAnnee.update
    End Sub

    Private Sub boutonSupprimerAnnee_Click(sender As Object, e As EventArgs) Handles boutonSupprimerAnnee.Click
        Dim reponse As Integer = MsgBox("Désirez-vous supprimer l'élément sélectionné", 36, "Supprimer ? ")
        If reponse = 6 Then
            'suppression 
            QTAPublic.P_DELETE_ANNEE(DGVAnnee.Item(2, currentRowAnnee).Value)

            'on actualise le DGV
            DGVAnnee.DataSource = P_SELECT_ANNEETableAdapter.GetData()
            setOpDGVAnneeBoutton(False, False)
            refreshComboBoxAnnee()
        End If
    End Sub

    Private Sub boutonSauvegarderAnnee_Click(sender As Object, e As EventArgs) Handles boutonSauvegarderAnnee.Click
        Dim erreur As String = sauvegarderDGVAnnee()
        If erreur = "" Then
        Else

            MsgBox(erreur, vbCritical, "Erreur sélection ")

        End If
    End Sub

    Private Sub boutonAnnulerAnnee_Click(sender As Object, e As EventArgs) Handles boutonAnnulerAnnee.Click
        'le clique va set operationEnableBoutonDGVJoueur 
        setOpDGVAnneeBoutton(False, False)
        refreshDGVAnnee()
    End Sub


    Public Function sauvegarderDGVAnnee() As String
        Dim erreur As String = isInformationNonRempliAnnee()
        If erreur = "" Then
            Dim booleanPourSavoirSiIlfautModifierOuAjouter As Boolean = False
            If opEnableBoutonDGVAnnee = operationEnableBoutonDGVAnnee.inAjout Then
                booleanPourSavoirSiIlfautModifierOuAjouter = True
            End If
            setUporInApresSaveAnnee()
            setOpDGVAnneeBoutton(False, False)
            'on actualise le DGV
            DGVAnnee.DataSource = P_SELECT_ANNEETableAdapter.GetData()
            selectElementModifierInsererAnnee(booleanPourSavoirSiIlfautModifierOuAjouter)
            refreshDGVAnnee()

            'refresh les combo box de mes choix 
            refreshComboBoxAnnee()
            refreshDGVMesChoix()

        End If
        Return erreur
    End Function
    Public Function selectElementModifierInsererAnnee(insertOrUpdate As Boolean) As [Type]
        If insertOrUpdate Then
            Dim dernierIdAnnee As Integer = QTAPublic.P_SELECT_LAST_ID_ANNEE


            For Each row In DGVAnnee.Rows
                ' on vérifie si seulement les joueur du parieur sont selectioné 
                If row.Cells(2).Value() = dernierIdAnnee Then
                    DGVAnnee.Rows(row.index).Selected = True
                    currentRowAnnee = row.index
                End If
            Next
        Else
            DGVAnnee.Rows(currentRowModifier).Selected = True
            currentRowAnnee = currentRowModifier
        End If

       

        Return Nothing

    End Function

    Public Function refreshDGVAnnee() As [Type]
        If DGVAnnee.RowCount = 0 Then
        Else
            Dim indexLigne As Integer = currentRowAnnee

            TBAnnee.Text = DGVAnnee.Item(0, indexLigne).Value
            CBSaisieEnCours.Checked = DGVAnnee.Item(1, indexLigne).Value

        End If
        Return Nothing
    End Function

    Public Function initDGVAnnee() As [Type]
        If DGVAnnee.RowCount = 0 Then
        Else
            TBAnnee.Text = DGVAnnee.Item(0, 0).Value
            CBSaisieEnCours.Checked = DGVAnnee.Item(1, 0).Value

        End If
        Return Nothing
    End Function

    Public Function setOpDGVAnneeBoutton(jeSuisIn As Boolean, jeSuisUnAjout As Boolean) As [Type]
        'true + true => ajouter
        'true + false => modifier
        If jeSuisIn Then
            If jeSuisUnAjout Then
                opEnableBoutonDGVAnnee = operationEnableBoutonDGVAnnee.inAjout
            Else
                opEnableBoutonDGVAnnee = operationEnableBoutonDGVAnnee.inModifier
            End If
        Else
            'aucune ranger selectionner 
            If DGVAnnee.SelectedRows.Count = 0 Then
                opEnableBoutonDGVAnnee = operationEnableBoutonDGVAnnee.noSelect
            Else
                opEnableBoutonDGVAnnee = operationEnableBoutonDGVAnnee.cellSelect
            End If


        End If
        gestionBoutonDGVAnnee()


        Return Nothing
    End Function
    'cette fonction permet de selectionner/déseclionner les boutons 
    Public Function gestionBoutonDGVAnnee() As [Type]

        Select Case opEnableBoutonDGVAnnee
            Case operationEnableBoutonDGVAnnee.noSelect

                DGVAnnee.Enabled = True
                'but action sup/in/mod
                boutonAjouterAnnee.Enabled = True
                boutonModifierAnnee.Enabled = False
                boutonSupprimerAnnee.Enabled = False

                'bas but 
                boutonSauvegarderAnnee.Enabled = False
                boutonAnnulerAnnee.Enabled = False

                'bas form
                TBAnnee.Enabled = False
                CBSaisieEnCours.Enabled = False

                CBImportJoueur.Visible = False

                viderLesChoixDGVAnnee()

                demandeSauvegarde = False


                etatSauvegardeParametre()
                TBMAXCote.Enabled = True
                TBMAXJoueur.Enabled = True


            Case operationEnableBoutonDGVAnnee.cellSelect

                DGVAnnee.Enabled = True

                'but action sup/in/mod
                boutonAjouterAnnee.Enabled = True
                boutonModifierAnnee.Enabled = True
                boutonSupprimerAnnee.Enabled = True

                'bas but 
                boutonSauvegarderAnnee.Enabled = False
                boutonAnnulerAnnee.Enabled = False

                'bas form
                TBAnnee.Enabled = False
                CBSaisieEnCours.Enabled = False

                CBImportJoueur.Visible = False

                demandeSauvegarde = False

                etatSauvegardeParametre()
                TBMAXCote.Enabled = True
                TBMAXJoueur.Enabled = True


            Case operationEnableBoutonDGVAnnee.inAjout

                DGVAnnee.Enabled = False

                'but action sup/in/mod
                boutonAjouterAnnee.Enabled = False
                boutonModifierAnnee.Enabled = False
                boutonSupprimerAnnee.Enabled = False

                'bas but 
                boutonSauvegarderAnnee.Enabled = True
                boutonAnnulerAnnee.Enabled = True

                'bas form
                TBAnnee.Enabled = True
                CBSaisieEnCours.Enabled = True

                CBImportJoueur.Visible = True

                SauvegarderParametre.Enabled = False
                TBMAXCote.Enabled = False
                TBMAXJoueur.Enabled = False

                demandeSauvegarde = True
                sauvegardeAFaire = quelleSauvegardeEstAFaire.dgvAnnee






            Case operationEnableBoutonDGVAnnee.inModifier

                DGVAnnee.Enabled = False

                'but action sup/in/mod
                boutonAjouterAnnee.Enabled = False
                boutonModifierAnnee.Enabled = False
                boutonSupprimerAnnee.Enabled = False

                'bas but 
                boutonSauvegarderAnnee.Enabled = True
                boutonAnnulerAnnee.Enabled = True

                'bas form
                TBAnnee.Enabled = True
                CBSaisieEnCours.Enabled = True

                CBImportJoueur.Visible = False
                SauvegarderParametre.Enabled = False
                TBMAXCote.Enabled = False
                TBMAXJoueur.Enabled = False

                demandeSauvegarde = True
                sauvegardeAFaire = quelleSauvegardeEstAFaire.dgvAnnee
        End Select


        Return Nothing


    End Function

    Public Function viderLesChoixDGVAnnee() As [Type]

        TBAnnee.Text = ""
        TextBoxPrenomGestionParieurs.Text = ""
        CBSaisieEnCours.Checked = True
        CBImportJoueur.Checked = True


        Return Nothing
    End Function

    Public Function isInformationNonRempliAnnee() As String
        Dim patterne As String = "(\d{4})\-(\d{4})"
        Dim expressionAnnee As Match = Regex.Match(TBAnnee.Text, patterne, RegexOptions.IgnoreCase)



        If expressionAnnee.Success = False Then
            Return "Erreur la date doit être sous le format (xxxx-xxxx) "
        End If

        Dim maDate As String() = TBAnnee.Text.Split("-")

        If Convert.ToInt32(maDate(0) + 1) = (Convert.ToInt32(maDate(1))) Then
            Return ""
        End If


        Return "Erreur la date doit vérifier l'expression ( xxxx + 1 ) == yyyy  pour (xxxx-yyyy)"
    End Function

    Public Function setUporInApresSaveAnnee() As [Type]
        Dim descriptionAnnee As String = TBAnnee.Text
        Dim saisieEnCours As Boolean = CBSaisieEnCours.Checked
        Dim importJoueur As Boolean = CBImportJoueur.Checked




        Select Case opUpOrInDGVAnnee
            Case operationUpOrInDGVAnnee.insert
                QTAPublic.P_AJOUTER_ANNEE(descriptionAnnee, saisieEnCours, importJoueur)
            Case operationUpOrInDGVAnnee.update
                Dim idAnneeICI As Integer = DGVAnnee.Item(2, currentRowAnnee).Value
                QTAPublic.P_UPDATE_ANNEE(idAnneeICI, descriptionAnnee, saisieEnCours)

        End Select



        Return Nothing
    End Function
    '/////////////////////////////////////////////////////PARAMETRE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////PARAMETRE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////PARAMETRE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////PARAMETRE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////PARAMETRE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////PARAMETRE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////PARAMETRE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////PARAMETRE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////PARAMETRE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////PARAMETRE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////PARAMETRE//////////////////////////////////////////////////
    '/////////////////////////////////////////////////////PARAMETRE//////////////////////////////////////////////////


    Public Function initParametre() As [Type]
        joueurMax = QTAPublic.P_SELECT_NOMBRE_JOUEUR_MAX 'recup data 
        coteMax = QTAPublic.P_SELECT_COTE_MAX 'recup data 

        'init le text de mes choix
        testASet.Text = "Sélectionner jusqu'à " + joueurMax.ToString + " joueurs pour une cote totale de " + coteMax.ToString + " ou moins"
        Return Nothing
    End Function
    Public Function etatSauvegardeParametre() As [Type]
        If Val(TBMAXJoueur.Text) = joueurMax And coteMax = Val(TBMAXCote.Text) Then
            SauvegarderParametre.Enabled = False
            demandeSauvegarde = False

        Else
            sauvegardeAFaire = quelleSauvegardeEstAFaire.parametre
            demandeSauvegarde = True
            SauvegarderParametre.Enabled = True
        End If
        Return Nothing
    End Function

    Public Function refreshComboBoxAnnee() As [Type]
        ComboBoxMesChoix.DataSource = P_SELECT_ANNEE_FOR_DGV_CHOIXTableAdapter.GetData()
        ComboBoxGestionJoueur.DataSource = P_SELECT_ANNEE_FOR_DGV_CHOIXTableAdapter.GetData()
        Return Nothing
    End Function
    
    Public Function informationParametreExacte() As String
        Dim patterne As String = "[0-9]"
        Dim expressionCote As Match = Regex.Match(TBMAXCote.Text, patterne, RegexOptions.IgnoreCase)
        Dim expressionJoueur As Match = Regex.Match(TBMAXJoueur.Text, patterne, RegexOptions.IgnoreCase)

        If expressionCote.Success = False Then
            Return "la côte n'est pas un numérique"
        ElseIf expressionJoueur.Success = False Then
            Return "Le nombre de joueur n'est pas un numérique"
        End If
        Try
            If Convert.ToInt32(TBMAXCote.Text) < 0 Then
                Return "La cote ne doit pas être négative"
            End If
            If Convert.ToInt32(TBMAXJoueur.Text) < 0 Then
                Return "Le nombre de joueur maximun ne doit pas être négatif"
            End If
        Catch ex As Exception
            Return "Le nombre rentrer ne doit pas être supérieur à  2 147 483 647 (taille maximun d'un integer 32 bit )"
        End Try
        Return ""

        Return Nothing
    End Function

    Private Sub SauvegarderParametre_Click(sender As Object, e As EventArgs) Handles SauvegarderParametre.Click
        Dim erreur As String = sauvegarderParametreCoteEtJoueurMax()
        If erreur = "" Then
        Else
            MsgBox(erreur, vbCritical, "Erreur sauvegarde")
        End If

        
    End Sub
    Public Function sauvegarderParametreCoteEtJoueurMax() As String
        Dim erreur As String = informationParametreExacte()
        If erreur = "" Then
            QTAPublic.P_UPDATE_PARAMETRE_CHOIX_PARIEUR(Val(TBMAXCote.Text), Val(TBMAXJoueur.Text))
            initParametre()
            etatSauvegardeParametre()
            refreshDGVMesChoix()

        End If
        Return erreur
    End Function

    Private Sub TBMAXJoueur_TextChanged(sender As Object, e As EventArgs) Handles TBMAXJoueur.TextChanged
        etatSauvegardeParametre()
    End Sub

    Private Sub TBMAXCote_TextChanged(sender As Object, e As EventArgs) Handles TBMAXCote.TextChanged
        etatSauvegardeParametre()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

        Dim jeQuitte As Boolean = True
        'faire avec l'enum
        If demandeSauvegarde Then

            If MsgBox("vous devez sauvegarder vos informations", 36, "erreur Sauvegarde") = 6 Then
                Dim erreur = sauvegarderAvantDeQuitter()
                If erreur = "" Then
                    annulerAvantDeQuitter()

                Else
                    MsgBox(erreur, vbCritical, "erreur Sauvegarde")
                    jeQuitte = False
                End If
            Else
                annulerAvantDeQuitter()
            End If
        Else
        End If

        If jeQuitte Then
            sauvegardeAFaire = False
            ClassementParieur.ShowDialog()
        End If

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim jeQuitte As Boolean = True
        'faire avec l'enum
        If demandeSauvegarde Then

            If MsgBox("vous devez sauvegarder vos informations", 36, "erreur Sauvegarde") = 6 Then
                Dim erreur = sauvegarderAvantDeQuitter()
                If erreur = "" Then
                    annulerAvantDeQuitter()

                Else
                    MsgBox(erreur, vbCritical, "erreur Sauvegarde")
                    jeQuitte = False
                End If
            Else
                annulerAvantDeQuitter()
            End If
        Else
        End If

        If jeQuitte Then
            sauvegardeAFaire = False
            ClassementDesParieursDetaille.ShowDialog()
        End If

    End Sub


    Private Sub ModifierMotDePasseMenuStrip_Click(sender As Object, e As EventArgs) Handles ModifierMotDePasseMenuStrip.Click
        ModifierMPD.ShowDialog()
    End Sub


    Public Function sauvegarderAvantDeQuitter() As String
        ' sauvegardeAFaire As quelleSauvegardeEstAFaire
        Select Case sauvegardeAFaire
            Case quelleSauvegardeEstAFaire.dgvMesChoix

                Return sauvegarderChoixParieur()

            Case quelleSauvegardeEstAFaire.dgvJoueur

                Return sauvegardeDGVJoueur()


            Case quelleSauvegardeEstAFaire.dgvParieur

                Return sauvegarderDGVParieur()



            Case quelleSauvegardeEstAFaire.dgvAnnee

                Return sauvegarderDGVAnnee()

            Case quelleSauvegardeEstAFaire.parametre

                Return sauvegarderParametreCoteEtJoueurMax()
        End Select


        Return Nothing


    End Function

    Public Function annulerAvantDeQuitter() As Type
        ' sauvegardeAFaire As quelleSauvegardeEstAFaire
        Select Case sauvegardeAFaire
            Case quelleSauvegardeEstAFaire.dgvMesChoix

                refreshDGVMesChoix()
                gestionBoutonDGVChoix()

            Case quelleSauvegardeEstAFaire.dgvJoueur

                setOpDGVJoueurBoutton(False)

                refreshDGVGestionJoueur()


            Case quelleSauvegardeEstAFaire.dgvParieur

                setOpDGVParieurBoutton(False)

                refreshDGVGestionParieur()



            Case quelleSauvegardeEstAFaire.dgvAnnee

                setOpDGVAnneeBoutton(False, False)
                refreshDGVAnnee()

            Case quelleSauvegardeEstAFaire.parametre
                initParametre()

                TBMAXJoueur.Text = joueurMax.ToString
                TBMAXCote.Text = coteMax.ToString

                etatSauvegardeParametre()
        End Select


        Return Nothing


    End Function

    
   

    
    Private Sub tableauControl1_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles tableauControl1.Selecting
        'action a la fermeture 
        e.Cancel = True

        Dim jeQuitte As Boolean = True
        'faire avec l'enum
        If demandeSauvegarde Then

            If MsgBox("vous devez sauvegarder vos informations", 36, "erreur Sauvegarde") = 6 Then
                Dim erreur = sauvegarderAvantDeQuitter()
                If erreur = "" Then
                    annulerAvantDeQuitter()
                    sauvegardeAFaire = False

                Else
                    MsgBox(erreur, vbCritical, "erreur Sauvegarde")
                    jeQuitte = False
                End If
            Else
                annulerAvantDeQuitter()
            End If
        Else
        End If

        If jeQuitte Then
            sauvegardeAFaire = False
            e.Cancel = False
        End If
    End Sub

End Class
