Public Class ModifierMPD

    Private Sub ButAnnulerMDP_Click(sender As Object, e As EventArgs) Handles ButAnnulerMDP.Click
        TBAncienMDP.Text = ""
        TBNewMPD.Text = ""
        TBConfirmerNewMPD.Text = ""
        Me.Close()
    End Sub

    Private Sub ButModifierMDP_Click(sender As Object, e As EventArgs) Handles ButModifierMDP.Click
        Dim ancienMPD As String
        Dim newMPD As String
        Dim confirmerNewMPD As String

        Dim QTA As New ALHDataSetTableAdapters.P_SELECT_SEL_AND_HASH_AVEC_IDPARIEURTableAdapter 'selecteur Dim maTableDeMotDePasse As New DataTable
        Dim monHashEtSel As New DataTable

        monHashEtSel = QTA.GetData(main.idParieur)

        Dim sel As String
        sel = monHashEtSel.Rows(0).Item("sel")

        Dim updatePasseword As New ALHDataSetTableAdapters.QueriesTableAdapter

        ancienMPD = TBAncienMDP.Text.ToString
        newMPD = TBNewMPD.Text.ToString
        confirmerNewMPD = TBConfirmerNewMPD.Text.ToString
        If newMPD.Count < 7 Then
            MsgBox("le mot de passe doit être de 7 caractère minimun ", vbCritical, "Erreur confirmation ")
        Else
            If newMPD = confirmerNewMPD Then
                'On vérifie si l'utilisateur a taper le bon mot de passe 2 fois 
                If motDePasse.VerifierMDP(ancienMPD, sel, monHashEtSel.Rows(0).Item("hash")) Then
                    'on vérifie si l'ancien mot de passe est OK
                    updatePasseword.P_UPDATE_NOUVEAU_PASSWORD(main.idParieur, sel, motDePasse.GenererHash(newMPD, sel))
                    TBAncienMDP.Text = ""
                    TBNewMPD.Text = ""
                    TBConfirmerNewMPD.Text = ""
                    Me.Close()
                Else
                    MsgBox("l'ancien mot de passe n'est pas le bon  ", vbCritical, "Erreur ancien mot de passe")

                End If
            Else
                MsgBox("erreur confirmation du mot de passe  ", vbCritical, "Erreur confirmation ")
            End If
        End If


        




    End Sub

    Private Sub ModifierMPD_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class