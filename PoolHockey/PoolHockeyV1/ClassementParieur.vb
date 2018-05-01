Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Imports System.Drawing
Imports PoolHockeyV1.ALHDataSetTableAdapters

Public Class ClassementParieur

    Private Sub ClassementParieur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'ALHDataSet.P_SELECT_ANNEE_FOR_DGV_CHOIX'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.P_SELECT_ANNEE_FOR_DGV_CHOIXTableAdapter.Fill(Me.ALHDataSet.P_SELECT_ANNEE_FOR_DGV_CHOIX)


    End Sub

    Private Sub butAnnuler_Click(sender As Object, e As EventArgs) Handles butAnnuler.Click
        Me.Close()
    End Sub

    Private Sub butGeneration_Click(sender As Object, e As EventArgs) Handles butGeneration.Click
        Dim sfdEnregistrerSous As New SaveFileDialog

        sfdEnregistrerSous.FileName = "Classement des parieurs"
        sfdEnregistrerSous.DefaultExt = "pdf"
        sfdEnregistrerSous.Filter = "PDF files (*.pdf)|*.pdf"
        sfdEnregistrerSous.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        Dim taPDF1 As New P_SELECT_PDF1TableAdapter
        Dim dtPDF1 As DataTable
        Dim drPDF1 As DataRow

        dtPDF1 = taPDF1.GetData(CBClassementParieurs.SelectedValue)
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
                leParagraphe = New Paragraph("Pool de hockey – Classement des parieurs (" + CBClassementParieurs.Text + ")")
                leParagraphe.Alignment = iTextSharp.text.Image.ALIGN_CENTER
                leParagraphe.Font.SetStyle(FontStyle.Bold)
                pdfDoc.Add(leParagraphe)


                pdfDoc.Add(New Paragraph(" "))
                'le soulignez et les titres  
                Dim ptTableau As New PdfPTable(2)
                Dim pcCellule As PdfPCell

                ptTableau.SpacingAfter = 4

                pcCellule = New PdfPCell(New Phrase("Parieur"))
                pcCellule.HorizontalAlignment = iTextSharp.text.Image.ALIGN_LEFT
                pcCellule.Border = PdfPCell.BOTTOM_BORDER
                pcCellule.Phrase.Font.SetStyle(FontStyle.Bold)

                pcCellule.Phrase.Font.Size = 10
                ptTableau.AddCell(pcCellule)

                pcCellule = New PdfPCell(New Phrase("Points"))
                pcCellule.HorizontalAlignment = iTextSharp.text.Image.ALIGN_RIGHT
                pcCellule.Border = PdfPCell.BOTTOM_BORDER
                pcCellule.Phrase.Font.Size = 10
                pcCellule.Phrase.Font.SetStyle(FontStyle.Bold)
                ptTableau.AddCell(pcCellule)





                'ajouter les élements 
                For Each drPDF1 In dtPDF1.Rows

                    pcCellule = New PdfPCell(New Phrase(drPDF1("nomParieur").ToString))
                    pcCellule.HorizontalAlignment = iTextSharp.text.Image.ALIGN_LEFT
                    pcCellule.Border = PdfPCell.NO_BORDER
                    ptTableau.AddCell(pcCellule)

                    pcCellule = New PdfPCell(New Phrase(drPDF1("points").ToString))
                    pcCellule.HorizontalAlignment = iTextSharp.text.Image.ALIGN_RIGHT
                    pcCellule.Border = PdfPCell.NO_BORDER
                    ptTableau.AddCell(pcCellule)



                Next

                leParagraphe = New Paragraph()
                leParagraphe.Add(ptTableau)
                pdfDoc.Add(leParagraphe)



                ' on libère la mémoire...
                pdfDoc.Close()
                pdfDoc.Dispose()
                pdfWrite.Close()
                pdfWrite.Dispose()


                MsgBox("le fichier a bien été généré", vbInformation, "Classement des parieurs")
                Me.Close()

            End If

        Catch ex As Exception
            MsgBox("une erreur c'est produite lors de la génération du PDF (vérifier que le PDF n'est pas ouvert  ) ", vbCritical, "Erreur génération PDF")
        End Try
    End Sub
End Class