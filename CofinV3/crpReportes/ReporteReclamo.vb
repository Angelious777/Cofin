Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf



Module ReporteReclamo
    Public Sub GenerarPDF(nombreArchivo As String, titulo As String)
        Try
            Dim carpetaDescargas As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")
            Dim rutaCompleta As String = Path.Combine(carpetaDescargas, "ReporteReclamo.pdf")

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
            doc.Add(New Paragraph("Nombre o Razón Social: ", fuenteBold))
            doc.Add(New Paragraph(Reclamo.registroActualReclamo.nombreRazonSocial, fuenteDato))
            doc.Add(New Paragraph(" "))

            doc.Add(New Paragraph("Tipo de Reclamante: ", fuenteBold))
            doc.Add(New Paragraph(Reclamo.registroActualReclamo.tipoReclamante, fuenteDato))
            doc.Add(New Paragraph(" "))

            doc.Add(New Paragraph("CI o NIT: ", fuenteBold))
            doc.Add(New Paragraph(Reclamo.registroActualReclamo.ciNIT, fuenteDato))
            doc.Add(New Paragraph(" "))

            doc.Add(New Paragraph("Representante o Apoderado: ", fuenteBold))
            doc.Add(New Paragraph(Reclamo.registroActualReclamo.repreApoderado, fuenteDato))
            doc.Add(New Paragraph(" "))

            doc.Add(New Paragraph("Testimonio: ", fuenteBold))
            doc.Add(New Paragraph(Reclamo.registroActualReclamo.testimonio, fuenteDato))
            doc.Add(New Paragraph(" "))

            doc.Add(New Paragraph("Dirección (Calle - Zona): ", fuenteBold))
            doc.Add(New Paragraph(Reclamo.registroActualReclamo.direccionCalle & " - " & Reclamo.registroActualReclamo.direccionZona, fuenteDato))
            doc.Add(New Paragraph(" "))

            doc.Add(New Paragraph("Teléfono de Domicilio: ", fuenteBold))
            doc.Add(New Paragraph(Reclamo.registroActualReclamo.telefonoDomicilio, fuenteDato))
            doc.Add(New Paragraph(" "))

            doc.Add(New Paragraph("Teléfono Celular: ", fuenteBold))
            doc.Add(New Paragraph(Reclamo.registroActualReclamo.telefonoCelular, fuenteDato))
            doc.Add(New Paragraph(" "))

            doc.Add(New Paragraph("Correo Electrónico: ", fuenteBold))
            doc.Add(New Paragraph(Reclamo.registroActualReclamo.correo, fuenteDato))
            doc.Add(New Paragraph(" "))

            doc.Add(New Paragraph("Fecha del Reclamo: ", fuenteBold))
            doc.Add(New Paragraph(Reclamo.registroActualReclamo.fechaDia & " de " & Reclamo.registroActualReclamo.fechaMes & " de " & Reclamo.registroActualReclamo.fechaAnio, fuenteDato))
            doc.Add(New Paragraph(" "))

            doc.Add(New Paragraph("Descripción del Reclamo: ", fuenteBold))
            doc.Add(New Paragraph(Reclamo.registroActualReclamo.descripcion, fuenteDato))
            doc.Add(New Paragraph(" "))

            doc.Add(New Paragraph("Monto Reclamado: ", fuenteBold))
            doc.Add(New Paragraph(Reclamo.registroActualReclamo.monto, fuenteDato))
            doc.Add(New Paragraph(" "))

            doc.Add(New Paragraph("Origen del Reclamo: ", fuenteBold))
            doc.Add(New Paragraph(Reclamo.registroActualReclamo.origenDepartamento & " - " & Reclamo.registroActualReclamo.origenCiudad, fuenteDato))
            doc.Add(New Paragraph(" "))

            doc.Add(New Paragraph("Número de Reclamo: ", fuenteBold))
            doc.Add(New Paragraph(Reclamo.registroActualReclamo.numReclamo, fuenteDato))
            doc.Add(New Paragraph(" "))

            doc.Add(New Paragraph("Medio de Reclamo: ", fuenteBold))
            doc.Add(New Paragraph(Reclamo.registroActualReclamo.medioReclamo, fuenteDato))
            doc.Add(New Paragraph(" "))

            doc.Add(New Paragraph("Medio de Entrega: ", fuenteBold))
            doc.Add(New Paragraph(Reclamo.registroActualReclamo.medioEntrega, fuenteDato))
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
