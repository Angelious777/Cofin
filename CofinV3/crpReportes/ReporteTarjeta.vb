Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Module ReporteTarjeta
    Public Sub GenerarPDF(nombreArchivo As String, titulo As String)
        Try
            Dim carpetaDescargas As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")
            Dim rutaCompleta As String = Path.Combine(carpetaDescargas, nombreArchivo)

            Dim doc As New Document(PageSize.A4, 40, 40, 40, 40)

            Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(rutaCompleta, FileMode.Create))
            Dim eventoBorde As New BordeEnCadaPagina()
            writer.PageEvent = eventoBorde

            doc.Open()

            ' --- Título con imagen ---
            Dim tabla As New PdfPTable(2)
            tabla.WidthPercentage = 100
            tabla.HorizontalAlignment = Element.ALIGN_CENTER
            tabla.DefaultCell.Border = Rectangle.NO_BORDER
            tabla.SetWidths({40, 60}) ' 40% para imagen, 60% para título

            ' Imagen
            Dim rutaImagen As String = Path.Combine(Application.StartupPath, "img\iconos", "cofin image.jpg")
            Dim img As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(rutaImagen)
            img.ScaleToFit(200, 200) ' Ajusta tamaño
            img.Alignment = Element.ALIGN_CENTER
            Dim celdaImg As New PdfPCell(img)
            celdaImg.Border = Rectangle.NO_BORDER
            celdaImg.VerticalAlignment = Element.ALIGN_MIDDLE
            celdaImg.HorizontalAlignment = Element.ALIGN_CENTER
            tabla.AddCell(celdaImg)

            ' Título
            Dim fuenteTitulo As New Font(Font.FontFamily.HELVETICA, 18, Font.BOLD)
            Dim celdaTitulo As New PdfPCell(New Phrase(titulo, fuenteTitulo))
            celdaTitulo.Border = Rectangle.NO_BORDER
            celdaTitulo.VerticalAlignment = Element.ALIGN_MIDDLE
            celdaTitulo.HorizontalAlignment = Element.ALIGN_CENTER
            tabla.AddCell(celdaTitulo)

            doc.Add(tabla)

            Dim fuenteDato = FontFactory.GetFont(FontFactory.HELVETICA, 12)
            Dim fuenteBold = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)

            doc.Add(New Paragraph(" "))
            doc.Add(New Paragraph("Nombre del Cliente: ", fuenteBold))
            doc.Add(New Paragraph(Tarjeta.registroActualTarjeta.nombre, fuenteDato))
            doc.Add(New Paragraph(" "))

            doc.Add(New Paragraph("CI: ", fuenteBold))
            doc.Add(New Paragraph(Tarjeta.registroActualTarjeta.ci, fuenteDato))
            doc.Add(New Paragraph(" "))

            doc.Add(New Paragraph("Nro de Tarjeta: ", fuenteBold))
            doc.Add(New Paragraph(Tarjeta.registroActualTarjeta.tarjeta, fuenteDato))
            doc.Add(New Paragraph(" "))

            doc.Add(New Paragraph("Tipo de Tarjeta: ", fuenteBold))
            doc.Add(New Paragraph(Tarjeta.registroActualTarjeta.tipo, fuenteDato))
            doc.Add(New Paragraph(" "))

            doc.Close()

            MessageBox.Show("PDF generado correctamente en: " & rutaCompleta, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Try
                Process.Start(New ProcessStartInfo(rutaCompleta) With {.UseShellExecute = True})
            Catch ex As Exception
                MessageBox.Show("No se pudo abrir el PDF automáticamente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try

        Catch ex As Exception
            MessageBox.Show("Error al generar el PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
