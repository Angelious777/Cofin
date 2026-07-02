Public Class frmTransferenciaInt
    Private bancos As New List(Of String) From {
        "Banco COFIN",
        "Banco Nacional de Bolivia (BNB)",
        "Banco de Crédito de Bolivia (BCP)",
        "Banco Mercantil Santa Cruz (BMSC)",
        "Banco Bisa",
        "Banco Ganadero",
        "Banco Económico",
        "Banco Fortaleza",
        "Banco Unión",
        "Banco FIE"
    }

    ' Bandera para evitar recursividad
    Private actualizando As Boolean = False

    Private Sub frmTransferenciaInt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxBancoOrigen.Items.AddRange(bancos.ToArray())
        cbxBancoDestino.Items.AddRange(bancos.ToArray())
    End Sub

    Private Sub cbxBancoOrigen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxBancoOrigen.SelectedIndexChanged
        If actualizando Then Exit Sub
        ActualizarDestino()
    End Sub

    Private Sub cbxBancoDestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxBancoDestino.SelectedIndexChanged
        If actualizando Then Exit Sub
        ActualizarOrigen()
    End Sub

    Private Sub ActualizarDestino()
        actualizando = True

        Dim bancoOrigenSeleccionado As String = cbxBancoOrigen.SelectedItem?.ToString()
        Dim bancoDestinoSeleccionado As String = cbxBancoDestino.SelectedItem?.ToString()

        cbxBancoDestino.Items.Clear()
        cbxBancoDestino.Items.AddRange(bancos.Where(Function(b) b <> bancoOrigenSeleccionado).ToArray())

        ' Restaurar selección si sigue disponible
        If bancoDestinoSeleccionado IsNot Nothing AndAlso cbxBancoDestino.Items.Contains(bancoDestinoSeleccionado) Then
            cbxBancoDestino.SelectedItem = bancoDestinoSeleccionado
        Else
            cbxBancoDestino.SelectedIndex = -1
        End If

        actualizando = False
    End Sub

    Private Sub ActualizarOrigen()
        actualizando = True

        Dim bancoDestinoSeleccionado As String = cbxBancoDestino.SelectedItem?.ToString()
        Dim bancoOrigenSeleccionado As String = cbxBancoOrigen.SelectedItem?.ToString()

        cbxBancoOrigen.Items.Clear()
        cbxBancoOrigen.Items.AddRange(bancos.Where(Function(b) b <> bancoDestinoSeleccionado).ToArray())

        ' Restaurar selección si sigue disponible
        If bancoOrigenSeleccionado IsNot Nothing AndAlso cbxBancoOrigen.Items.Contains(bancoOrigenSeleccionado) Then
            cbxBancoOrigen.SelectedItem = bancoOrigenSeleccionado
        Else
            cbxBancoOrigen.SelectedIndex = -1
        End If

        actualizando = False
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If ValidarCampos() Then
            If txtMonto.Text >= 70000 Then
                MessageBox.Show("Es necesario llenar el formulario PCC-01")
                Dim PCC01frm As New frmPCC01()
                PCC01frm.ShowDialog()
            End If
            ReporteTransferenciaInt.GenerarPDF(Me, "ReporteTransferencia.pdf", "Informe de Transferencia Interbancaria")
            Me.Close()
        Else
            MessageBox.Show("Campos Faltantes")
        End If
    End Sub

    Private Function ValidarCampos() As Boolean
        Dim bandera As Boolean = True

        If String.IsNullOrWhiteSpace(txtNombre.Text) Then bandera = False
        If String.IsNullOrWhiteSpace(txtCuentaOrigen.Text) Then bandera = False
        If String.IsNullOrWhiteSpace(txtCuentaDestino.Text) Then bandera = False
        If String.IsNullOrWhiteSpace(txtMonto.Text) Then bandera = False
        If cbxBancoOrigen.SelectedIndex = -1 Then bandera = False
        If cbxBancoDestino.SelectedIndex = -1 Then bandera = False

        Return bandera
    End Function

    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
        ' Permitir solo números y teclas de control (como retroceso)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


End Class
