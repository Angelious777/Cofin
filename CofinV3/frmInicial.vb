Public Class frmInicial
    Private Sub btnCajero_Click(sender As Object, e As EventArgs) Handles btnCajero.Click
        Dim cajeroFrm As New frmCajero()
        cajeroFrm.Show()
    End Sub

    Private Sub btnPlataforma_Click(sender As Object, e As EventArgs) Handles btnPlataforma.Click
        Dim plataformaFrm As New frmPlataforma()
        plataformaFrm.Show()
    End Sub

End Class