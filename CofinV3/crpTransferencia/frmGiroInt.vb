Public Class frmGiroInt
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If ValidarCampos() Then
            If txtMonto.Text >= 70000 Then
                MessageBox.Show("Es necesario llenar el formulario PCC-01")
                Dim PCC01frm As New frmPCC01()
                PCC01frm.ShowDialog()
            End If
            ReporteGiroInt.GenerarPDF(Me, "ReporteGiro.pdf", "Informe de Giro Internacional")
            Me.Close()
        Else
            MessageBox.Show("Campos Faltantes")
        End If
    End Sub

    Private Function ValidarCampos()
        Dim bandera = True

        If String.IsNullOrWhiteSpace(txtNombre.Text) Then bandera = False
        If String.IsNullOrWhiteSpace(txtCuentaOrigen.Text) Then bandera = False
        If String.IsNullOrWhiteSpace(txtCuentaDestino.Text) Then bandera = False
        If String.IsNullOrWhiteSpace(txtPaisOrigen.Text) Then bandera = False
        If String.IsNullOrWhiteSpace(txtPaisDestino.Text) Then bandera = False
        If String.IsNullOrWhiteSpace(txtMonto.Text) Then bandera = False
        If String.IsNullOrWhiteSpace(txtComision.Text) Then bandera = False

        Return bandera
    End Function

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
        ' Permitir solo números y teclas de control (como retroceso)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtComision_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtComision.KeyPress
        ' Permitir solo números y teclas de control (como retroceso)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class