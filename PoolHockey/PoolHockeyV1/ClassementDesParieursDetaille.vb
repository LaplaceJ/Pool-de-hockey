Imports PoolHockeyV1.ALHDataSetTableAdapters
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Imports System.Drawing

Public Class ClassementDesParieursDetaille

    Private Sub ClassementDesParieursDetaille_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'ALHDataSet.P_SELECT_ANNEE_FOR_DGV_CHOIX'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.P_SELECT_ANNEE_FOR_DGV_CHOIXTableAdapter.Fill(Me.ALHDataSet.P_SELECT_ANNEE_FOR_DGV_CHOIX)

    End Sub

    Private Sub butAnnulerDetaille_Click(sender As Object, e As EventArgs) Handles butAnnulerDetaille.Click
        Me.Close()
    End Sub

    Private Sub butGenerationDetaille_Click(sender As Object, e As EventArgs) Handles butGenerationDetaille.Click

        Dim sfdEnregistrerSous As New SaveFileDialog

        sfdEnregistrerSous.FileName = "Classement des parieurs détaillé"
        sfdEnregistrerSous.DefaultExt = "pdf"
        sfdEnregistrerSous.Filter = "PDF files (*.pdf)|*.pdf"
        sfdEnregistrerSous.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        Dim taPDF1 As New P_SELECT_PDF1TableAdapter
        Dim dtPDF1 As DataTable
        Dim drPDF1 As DataRow

        dtPDF1 = taPDF1.GetData(CBClassementParieursDetaille.SelectedValue)

        Dim taPDF2 As New P_SELECT_PDF2TableAdapter
        Dim dtPDF2 As DataTable
        Dim drPDF2 As DataRow

        Try

            If sfdEnregistrerSous.ShowDialog = Windows.Forms.DialogResult.OK Then


                Dim pdfDoc As New Document()
                Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(sfdEnregistrerSous.FileName, FileMode.Create))
                Dim leParagraphe As Paragraph
                Dim leChunk As Chunk

                pdfDoc.Open()

                '=============================================================================================================
                ' EN RÉSUMÉ: le document est composé de plusieurs paragraphes (1 paragraphe = une ligne ou un bloc de lignes), 
                ' chaque paragraphe regroupant un ou plusieurs "chunk" (pour lesquels on peut définir un style différent)
                '=============================================================================================================

                ' ajout du logo (aligné à droite)
                '--------------------------------

                ' le fichier logo.jpg doit être copié dans le même dossier que l'exécutable de votre application  ("bin\debug" sous le dossier de votre projet)
                '  Dim leLogo As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(System.AppDomain.CurrentDomain.BaseDirectory() + "Ressources\lescegeps.jpg")
                ' leLogo.ScaleToFit(150, 150)
                'leLogo.Border = iTextSharp.text.Rectangle.BOX
                'leLogo.BorderWidth = 5
                '  leLogo.Alignment = iTextSharp.text.Image.ALIGN_CENTER
                '  pdfDoc.Add(leLogo)

                'Logo
                ' le fichier logo.jpg doit être copié dans le même dossier que l'exécutable de votre application  ("bin\debug" sous le dossier de votre projet)
                Dim leLogo As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(System.AppDomain.CurrentDomain.BaseDirectory() + "\logo.jpg")
                leLogo.ScaleToFit(150, 150)
                'leLogo.Border = iTextSharp.text.Rectangle.BOX
                'leLogo.BorderWidth = 5
                leLogo.Alignment = iTextSharp.text.Image.ALIGN_CENTER
                pdfDoc.Add(leLogo)


                ' ajout du titre du rapport (centré)
                '-----------------------------------

                pdfDoc.Add(New Paragraph(" "))
                leParagraphe = New Paragraph("Pool de hockey – Classement détaillé des parieurs (" + CBClassementParieursDetaille.Text + ")")
                leParagraphe.Alignment = iTextSharp.text.Image.ALIGN_CENTER
                leParagraphe.Font.SetStyle(FontStyle.Bold)
                pdfDoc.Add(leParagraphe)
                pdfDoc.Add(New Paragraph(" "))


                'le soulignez et les titres  
                Dim tableauCentral As New PdfPTable(2)
                Dim celluleCentral As PdfPCell

                tableauCentral.SpacingAfter = 4


                'FOR 1  dtPDF2 = taPDF2.GetData(CBClassementParieursDetaille.SelectedValue)

                For Each drPDF1 In dtPDF1.Rows
                    ' nom,prenom(points) 
                    celluleCentral = New PdfPCell(New Phrase(drPDF1("nomParieur").ToString + " (" + drPDF1("points").ToString + " " + "Points)"))
                    celluleCentral.HorizontalAlignment = iTextSharp.text.Image.ALIGN_LEFT
                    celluleCentral.Border = PdfPCell.BOTTOM_BORDER
                    celluleCentral.Phrase.Font.SetStyle(FontStyle.Bold)
                    celluleCentral.PaddingBottom = 10
                    celluleCentral.PaddingTop = 30
                    tableauCentral.AddCell(celluleCentral)

                    celluleCentral = New PdfPCell(New Phrase(""))
                    celluleCentral.HorizontalAlignment = iTextSharp.text.Image.ALIGN_MIDDLE
                    celluleCentral.Border = PdfPCell.BOTTOM_BORDER
                    celluleCentral.Phrase.Font.SetStyle(FontStyle.Bold)
                    celluleCentral.PaddingBottom = 10
                    celluleCentral.PaddingTop = 30
                    tableauCentral.AddCell(celluleCentral)


                    'selection des détailles des joueurs 
                    dtPDF2 = taPDF2.GetData(drPDF1("idPar").ToString, CBClassementParieursDetaille.SelectedValue)




                    Dim tableauGaucheJoueur As New PdfPTable(1)
                    Dim celluleGaucheJoueur As PdfPCell

                    'Joueur en gras apres le nom Parieur
                    celluleGaucheJoueur = New PdfPCell(New Phrase("Joueur"))
                    celluleGaucheJoueur.HorizontalAlignment = iTextSharp.text.Image.ALIGN_LEFT
                    celluleGaucheJoueur.Border = PdfPCell.NO_BORDER
                    celluleGaucheJoueur.Phrase.Font.SetStyle(FontStyle.Bold)
                    tableauGaucheJoueur.AddCell(celluleGaucheJoueur)



                    Dim tableauMidScore As New PdfPTable(3)
                    Dim celluleMidScore As PdfPCell
                    'B A P en gras apres le nom Parieur

                    celluleMidScore = New PdfPCell(New Phrase("B"))
                    celluleMidScore.HorizontalAlignment = iTextSharp.text.Image.ALIGN_LEFT
                    celluleMidScore.Border = PdfPCell.NO_BORDER
                    celluleMidScore.Phrase.Font.SetStyle(FontStyle.Bold)
                    tableauMidScore.AddCell(celluleMidScore)

                    celluleMidScore = New PdfPCell(New Phrase("A"))
                    celluleMidScore.HorizontalAlignment = iTextSharp.text.Image.ALIGN_MIDDLE
                    celluleMidScore.Border = PdfPCell.NO_BORDER
                    celluleMidScore.Phrase.Font.SetStyle(FontStyle.Bold)
                    tableauMidScore.AddCell(celluleMidScore)

                    celluleMidScore = New PdfPCell(New Phrase("P"))
                    celluleMidScore.HorizontalAlignment = iTextSharp.text.Image.ALIGN_MIDDLE
                    celluleMidScore.Border = PdfPCell.NO_BORDER
                    celluleMidScore.Phrase.Font.SetStyle(FontStyle.Bold)
                    tableauMidScore.AddCell(celluleMidScore)


                    'BOUCLE AJOUT DES DETAILLES DES JOUEURS 
                    For Each drPDF2 In dtPDF2.Rows



                        'Joueur en gras apres le nom Parieur
                        celluleGaucheJoueur = New PdfPCell(New Phrase(drPDF2("nomJoueur").ToString + "," + drPDF2("prenomJoueur").ToString + "(" + drPDF2("nomEquipe").ToString + "," + drPDF2("villeEquipe").ToString + ")"))
                        celluleGaucheJoueur.HorizontalAlignment = iTextSharp.text.Image.ALIGN_LEFT
                        celluleGaucheJoueur.Border = PdfPCell.NO_BORDER
                        celluleGaucheJoueur.PaddingTop = 5
                        celluleGaucheJoueur.PaddingBottom = 5
                        tableauGaucheJoueur.AddCell(celluleGaucheJoueur)

                        'ajout de B 
                        celluleMidScore = New PdfPCell(New Phrase(drPDF2("buts").ToString))
                        celluleMidScore.HorizontalAlignment = iTextSharp.text.Image.ALIGN_LEFT
                        celluleMidScore.Border = PdfPCell.NO_BORDER
                        celluleMidScore.PaddingTop = 5
                        celluleMidScore.PaddingBottom = 5
                        tableauMidScore.AddCell(celluleMidScore)

                        celluleMidScore = New PdfPCell(New Phrase(drPDF2("passes").ToString))
                        celluleMidScore.HorizontalAlignment = iTextSharp.text.Image.ALIGN_MIDDLE
                        celluleMidScore.Border = PdfPCell.NO_BORDER
                        celluleMidScore.PaddingTop = 5
                        celluleMidScore.PaddingBottom = 5
                        tableauMidScore.AddCell(celluleMidScore)

                        celluleMidScore = New PdfPCell(New Phrase(drPDF2("points").ToString))
                        celluleMidScore.HorizontalAlignment = iTextSharp.text.Image.ALIGN_MIDDLE
                        celluleMidScore.Border = PdfPCell.NO_BORDER
                        celluleMidScore.PaddingTop = 5
                        celluleMidScore.PaddingBottom = 5
                        tableauMidScore.AddCell(celluleMidScore)

                    Next

                    celluleCentral = New PdfPCell(tableauGaucheJoueur)
                    celluleCentral.HorizontalAlignment = iTextSharp.text.Image.ALIGN_LEFT
                    celluleCentral.Border = PdfPCell.NO_BORDER
                    tableauCentral.AddCell(celluleCentral)


                    celluleCentral = New PdfPCell(tableauMidScore)
                    celluleCentral.HorizontalAlignment = iTextSharp.text.Image.ALIGN_MIDDLE
                    celluleCentral.Border = PdfPCell.NO_BORDER
                    tableauCentral.AddCell(celluleCentral)

                Next




                leParagraphe = New Paragraph()
                leParagraphe.Add(tableauCentral)
                pdfDoc.Add(leParagraphe)



                ' on libère la mémoire...
                pdfDoc.Close()
                pdfDoc.Dispose()
                pdfWrite.Close()
                pdfWrite.Dispose()


                MsgBox("le fichier a bien été généré", vbInformation, "Classement des parieurs détaillé")
                Me.Close()

            End If

        Catch ex As Exception
            MsgBox("une erreur c'est produite lors de la génération du PDF (vérifier que le PDF n'est pas ouvert  ) ", vbCritical, "Erreur génération PDF")
        End Try

        

    End Sub
End Class