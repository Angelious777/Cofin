Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class BordeEnCadaPagina
    Inherits PdfPageEventHelper

    Public Overrides Sub OnEndPage(writer As PdfWriter, document As Document)
        Dim cb As PdfContentByte = writer.DirectContent
        Dim pageRect As Rectangle = document.PageSize

        cb.SaveState()
        cb.SetLineWidth(2)
        cb.SetColorStroke(BaseColor.BLACK)

        ' Dibuja un borde dentro de los márgenes
        cb.Rectangle(document.LeftMargin / 2, document.BottomMargin / 2,
                     pageRect.Width - document.LeftMargin, pageRect.Height - document.TopMargin)
        cb.Stroke()
        cb.RestoreState()
    End Sub
End Class