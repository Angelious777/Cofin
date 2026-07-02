Public Class frmCliente
    Public Sub mostrarImagen(imagen As Image, firma As Image, huella As Image, nro As String, nombre As String)
        pctbFoto.Image = imagen
        pctbFirma.Image = firma
        pctbHuella.Image = huella
        lblNombreCliente.Text = $"Nombre: {nombre}"
        lblNroCliente.Text = $"Nro de Cuenta: {nro}"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

End Class