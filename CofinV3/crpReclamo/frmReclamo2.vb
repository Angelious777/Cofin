Public Class frmReclamo2

    Private anteriorForm As Form

    Public Sub New(anterior As Form)
        InitializeComponent()
        anteriorForm = anterior
    End Sub

    Private Sub frmReclamo2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxMedioComunicacion.Items.Add("Generado en línea")
        cbxMedioComunicacion.Items.Add("Vía SMS")
        cbxMedioComunicacion.Items.Add("Vía Email")
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        If ValidarCampos() Then
            RegistrarDatos()
            MessageBox.Show("Formulario completado exitosamente.")
            ReporteReclamo.GenerarPDF("ReporteReclamo.pdf", "Informe de Reporte")
            Me.Close()
        Else
            MessageBox.Show("Campos Faltantes")
        End If
    End Sub

    Private Function ValidarCampos() As Boolean
        Dim valido As Boolean = True

        'If String.IsNullOrWhiteSpace(txtNombreReclamante.Text) Then valido = False
        If String.IsNullOrWhiteSpace(txtDepartamento.Text) Then valido = False
        If String.IsNullOrWhiteSpace(txtCiudad.Text) Then valido = False
        If String.IsNullOrWhiteSpace(txtNumeroReclamo.Text) Then valido = False
        If cbxMedioComunicacion.SelectedIndex = -1 Then valido = False
        If String.IsNullOrWhiteSpace(txtMedioEntrega.Text) Then valido = False

        Return valido
    End Function

    Private Sub RegistrarDatos()
        Reclamo.registroActualReclamo.origenDepartamento = txtDepartamento.Text
        Reclamo.registroActualReclamo.origenCiudad = txtCiudad.Text
        Reclamo.registroActualReclamo.numReclamo = txtNumeroReclamo.Text
        Reclamo.registroActualReclamo.medioReclamo = cbxMedioComunicacion.SelectedItem.ToString
        Reclamo.registroActualReclamo.medioEntrega = txtMedioEntrega.Text
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        anteriorForm.Show()
        Me.Close()
    End Sub
End Class