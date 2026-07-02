Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf


Module ReporteCACPN
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

            Dim tablaDatos As New PdfPTable(2)
            tablaDatos.WidthPercentage = 100
            tablaDatos.DefaultCell.Border = Rectangle.NO_BORDER
            tablaDatos.SetWidths({50, 50})

            Dim celdaIzq As New PdfPCell()
            celdaIzq.Border = Rectangle.NO_BORDER
            celdaIzq.AddElement(New Paragraph(" "))
            celdaIzq.AddElement(New Paragraph("Titular: ", fuenteBold))
            celdaIzq.AddElement(New Paragraph(CACPN.RegistroActualCACPN.datos_titular, fuenteDato))

            celdaIzq.AddElement(New Paragraph(" "))
            celdaIzq.AddElement(New Paragraph("Documento de Identidad: ", fuenteBold))
            celdaIzq.AddElement(New Paragraph("Nro de Identidad: ", fuenteBold))
            celdaIzq.AddElement(New Paragraph(CACPN.RegistroActualCACPN.ID_nro, fuenteDato))
            celdaIzq.AddElement(New Paragraph("Extension: ", fuenteBold))
            celdaIzq.AddElement(New Paragraph(CACPN.RegistroActualCACPN.ID_ext, fuenteDato))
            celdaIzq.AddElement(New Paragraph("Tipo de cuenta: ", fuenteBold))
            celdaIzq.AddElement(New Paragraph(CACPN.RegistroActualCACPN.ID_tipo, fuenteDato))
            celdaIzq.AddElement(New Paragraph("Sexo: ", fuenteBold))
            celdaIzq.AddElement(New Paragraph(CACPN.RegistroActualCACPN.ID_sexo, fuenteDato))
            celdaIzq.AddElement(New Paragraph("Fecha de Nacimiento: ", fuenteBold))
            celdaIzq.AddElement(New Paragraph(CACPN.RegistroActualCACPN.ID_fecnac, fuenteDato))
            celdaIzq.AddElement(New Paragraph("Nacionalidad: ", fuenteBold))
            celdaIzq.AddElement(New Paragraph(CACPN.RegistroActualCACPN.ID_nacionalidad, fuenteDato))
            celdaIzq.AddElement(New Paragraph("2da Nacionalidad: ", fuenteBold))
            celdaIzq.AddElement(New Paragraph(CACPN.RegistroActualCACPN.ID_2da_nacionalidad, fuenteDato))
            celdaIzq.AddElement(New Paragraph("Residente: ", fuenteBold))
            celdaIzq.AddElement(New Paragraph(CACPN.RegistroActualCACPN.ID_residente, fuenteDato))
            celdaIzq.AddElement(New Paragraph("Pais de Residencia: ", fuenteBold))
            celdaIzq.AddElement(New Paragraph(CACPN.RegistroActualCACPN.ID_pais_residencia, fuenteDato))
            celdaIzq.AddElement(New Paragraph("Pais de Nacimiento: ", fuenteBold))
            celdaIzq.AddElement(New Paragraph(CACPN.RegistroActualCACPN.ID_pais_nacimiento, fuenteDato))
            celdaIzq.AddElement(New Paragraph("Residencia en EEUU: ", fuenteBold))
            celdaIzq.AddElement(New Paragraph(CACPN.RegistroActualCACPN.ID_EEUU, fuenteDato))
            celdaIzq.AddElement(New Paragraph("Calle / Av: ", fuenteBold))
            celdaIzq.AddElement(New Paragraph(CACPN.RegistroActualCACPN.calle_av, fuenteDato))
            celdaIzq.AddElement(New Paragraph(CACPN.RegistroActualCACPN.calle_av2, fuenteDato))
            celdaIzq.AddElement(New Paragraph("Numero: ", fuenteBold))
            celdaIzq.AddElement(New Paragraph(CACPN.RegistroActualCACPN.numero_domicilio, fuenteDato))
            celdaIzq.AddElement(New Paragraph("Departamento: ", fuenteBold))
            celdaIzq.AddElement(New Paragraph(CACPN.RegistroActualCACPN.departamento, fuenteDato))
            celdaIzq.AddElement(New Paragraph("Provincia: ", fuenteBold))
            celdaIzq.AddElement(New Paragraph(CACPN.RegistroActualCACPN.provincia, fuenteDato))
            ' 36




            tablaDatos.AddCell(celdaIzq)

            ' tabla derecha
            Dim celdaDer As New PdfPCell()
            celdaDer.Border = Rectangle.NO_BORDER
            celdaDer.AddElement(New Paragraph(" "))
            celdaDer.AddElement(New Paragraph(" "))
            celdaDer.AddElement(New Paragraph(" "))
            celdaDer.AddElement(New Paragraph(" "))
            celdaDer.AddElement(New Paragraph("Distrito: ", fuenteBold))
            celdaDer.AddElement(New Paragraph(CACPN.RegistroActualCACPN.distrito, fuenteDato))
            celdaDer.AddElement(New Paragraph("Telefono Fijo: ", fuenteBold))
            celdaDer.AddElement(New Paragraph(CACPN.RegistroActualCACPN.telefono_fijo, fuenteDato))
            celdaDer.AddElement(New Paragraph("Telefono Celular: ", fuenteBold))
            celdaDer.AddElement(New Paragraph(CACPN.RegistroActualCACPN.telefono_celular, fuenteDato))
            celdaDer.AddElement(New Paragraph("Correo Electronico: ", fuenteBold))
            celdaDer.AddElement(New Paragraph(CACPN.RegistroActualCACPN.correo, fuenteDato))
            celdaDer.AddElement(New Paragraph(" "))
            celdaDer.AddElement(New Paragraph("Datos Laborales / Negocio Propio: ", fuenteBold))
            celdaDer.AddElement(New Paragraph("Nombre de la Empresa: ", fuenteBold))
            celdaDer.AddElement(New Paragraph(CACPN.RegistroActualCACPN.nombre_empresa, fuenteDato))
            celdaDer.AddElement(New Paragraph("NIT: ", fuenteBold))
            celdaDer.AddElement(New Paragraph(CACPN.RegistroActualCACPN.nit, fuenteDato))
            celdaDer.AddElement(New Paragraph("Negocio Propio: ", fuenteBold))
            celdaDer.AddElement(New Paragraph(CACPN.RegistroActualCACPN.negocio_propio, fuenteDato))
            celdaDer.AddElement(New Paragraph("Giro o Actividad Economica Principal: ", fuenteBold))
            celdaDer.AddElement(New Paragraph(CACPN.RegistroActualCACPN.actividad_economica, fuenteDato))
            celdaDer.AddElement(New Paragraph("Direccion Laboral: ", fuenteBold))
            celdaDer.AddElement(New Paragraph("Calle / Av: ", fuenteBold))
            celdaDer.AddElement(New Paragraph(CACPN.RegistroActualCACPN.calle_av_laboral, fuenteDato))
            celdaDer.AddElement(New Paragraph("Numero: ", fuenteBold))
            celdaDer.AddElement(New Paragraph(CACPN.RegistroActualCACPN.numero_laboral, fuenteDato))
            celdaDer.AddElement(New Paragraph("Departamento: ", fuenteBold))
            celdaDer.AddElement(New Paragraph(CACPN.RegistroActualCACPN.departamento_laboral, fuenteDato))
            celdaDer.AddElement(New Paragraph("Provincia: ", fuenteBold))
            celdaDer.AddElement(New Paragraph(CACPN.RegistroActualCACPN.provincia_laboral, fuenteDato))
            celdaDer.AddElement(New Paragraph("Distrito: ", fuenteBold))
            celdaDer.AddElement(New Paragraph(CACPN.RegistroActualCACPN.distrito_laboral, fuenteDato))
            celdaDer.AddElement(New Paragraph("Telefono Fijo: ", fuenteBold))
            celdaDer.AddElement(New Paragraph(CACPN.RegistroActualCACPN.telefono_fijo_laboral, fuenteDato))
            'celdaDer.AddElement(New Paragraph("Telefono Celular: ", fuenteBold))
            'celdaDer.AddElement(New Paragraph(CACPN.RegistroActualCACPN.telefono_celular_laboral, fuenteDato))
            'celdaDer.AddElement(New Paragraph("Correo Electronico: ", fuenteBold))
            'celdaDer.AddElement(New Paragraph(CACPN.RegistroActualCACPN.correo_laboral, fuenteDato))
            'celdaDer.AddElement(New Paragraph("Cargo / Puesto que Ocupa: ", fuenteBold))
            'celdaDer.AddElement(New Paragraph(CACPN.RegistroActualCACPN.cargo_puesto_laboral, fuenteDato))


            tablaDatos.AddCell(celdaDer)

            doc.Add(tablaDatos)

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
