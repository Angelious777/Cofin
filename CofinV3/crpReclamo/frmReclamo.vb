Public Class frmReclamo

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If ValidarCampos() Then
            RegistrarDatos()
            Dim reclamo2Frm As New frmReclamo2(Me)
            reclamo2Frm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Campos Faltantes")
        End If
    End Sub

    Private Sub frmReclamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxTipoReclamante.Items.Add("Persona Natural")
        cbxTipoReclamante.Items.Add("Persona Jurídica")
        cbxTipoReclamante.Items.Add("Apoderado Persona Natural")
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub RegistrarDatos()
        Reclamo.registroActualReclamo.nombreRazonSocial = txtNombreReclamante.Text
        Reclamo.registroActualReclamo.tipoReclamante = cbxTipoReclamante.SelectedItem.ToString
        Reclamo.registroActualReclamo.ciNIT = txtCIReclamante.Text
        Reclamo.registroActualReclamo.repreApoderado = txtNombreRepresentante.Text
        Reclamo.registroActualReclamo.testimonio = txtNroTestimonio.Text
        Reclamo.registroActualReclamo.direccionCalle = txtDireccionCalle.Text
        Reclamo.registroActualReclamo.direccionZona = txtDireccionZona.Text
        Reclamo.registroActualReclamo.telefonoDomicilio = txtTelefonoDomicilio.Text
        Reclamo.registroActualReclamo.telefonoCelular = txtTelefonoCelular.Text
        Reclamo.registroActualReclamo.correo = txtCorreoElectronico.Text
        Reclamo.registroActualReclamo.fechaDia = txtFechaDia.Text
        Reclamo.registroActualReclamo.fechaMes = txtFechaMes.Text
        Reclamo.registroActualReclamo.fechaAnio = txtFechaAnio.Text
        Reclamo.registroActualReclamo.descripcion = txtDescripcionReclamo.Text
        Reclamo.registroActualReclamo.monto = txtMontoReclamo.Text
    End Sub

    Private Function ValidarCampos() As Boolean
        Dim valido As Boolean = True

        If String.IsNullOrWhiteSpace(txtNombreReclamante.Text) Then valido = False
        If cbxTipoReclamante.SelectedIndex = -1 Then valido = False
        If String.IsNullOrWhiteSpace(txtCIReclamante.Text) Then valido = False
        If String.IsNullOrWhiteSpace(txtNombreRepresentante.Text) Then valido = False
        If String.IsNullOrWhiteSpace(txtNroTestimonio.Text) Then valido = False
        If String.IsNullOrWhiteSpace(txtDireccionZona.Text) Then valido = False
        If String.IsNullOrWhiteSpace(txtCorreoElectronico.Text) Then valido = False
        If String.IsNullOrWhiteSpace(txtFechaDia.Text) Then valido = False
        If String.IsNullOrWhiteSpace(txtFechaMes.Text) Then valido = False
        If String.IsNullOrWhiteSpace(txtFechaAnio.Text) Then valido = False
        If String.IsNullOrWhiteSpace(txtDescripcionReclamo.Text) Then valido = False
        If String.IsNullOrWhiteSpace(txtMontoReclamo.Text) Then valido = False

        If String.IsNullOrWhiteSpace(txtTelefonoCelular.Text) AndAlso
           String.IsNullOrWhiteSpace(txtTelefonoDomicilio.Text) Then
            valido = False
        End If

        Return valido
    End Function

End Class