Public Class frmPlataforma

    Private cont As Integer = 0
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnCrearBCP_CACPN_Click(sender As Object, e As EventArgs) Handles btnCrearBCP_CACPN.Click
        CACPN.NuevoRegistroCACPN()
        CACPN.RegistroActualCACPN.nombre_banco = nombreBanco()

        Dim formCACPN1 As New frmCACPN1()
        formCACPN1.Show()
    End Sub

    Private Sub btnActualizarBCP_Click(sender As Object, e As EventArgs) Handles btnActualizarBCP.Click
        frmBusqueda = New frmBuscarFormulario()
        frmBusqueda.show()
    End Sub

    Private Sub btnCrearBCP_CACPJ_Click(sender As Object, e As EventArgs) Handles btnCrearBCP_CACPJ.Click
        CACPJ.NuevoRegistroCACPJ()
        CACPJ.RegistroActualCACPJ.nombre_banco = nombreBanco()

        Dim formCACPJ1 As New frmCACPJ1
        formCACPJ1.Show()
    End Sub

    Private Sub frmPlataforma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxBanco.Items.Add("BCP")
        cbxBanco.Items.Add("BISA")
        cbxBanco.Items.Add("BANCO ECONOMICO")
        cbxBanco.SelectedIndex = 0
    End Sub

    Private Function nombreBanco() As String
        Dim banco As String = If(cbxBanco.SelectedItem?.ToString(), String.Empty)
        Select Case banco
            Case "BCP" : Return "BCP"
            Case "BISA" : Return "BISA"
            Case "BANCO ECONOMICO" : Return "ECONOMICO"
            Case Else : Return String.Empty
        End Select
    End Function

    Private Sub btnReclamo_Click(sender As Object, e As EventArgs) Handles btnReclamo.Click
        Dim reclamoForm As New frmReclamo()
        Reclamo.nuevoRegistroReclamo()
        reclamoForm.Show()
    End Sub

    Private Sub btnTransferencia_Click(sender As Object, e As EventArgs) Handles btnTransferencia.Click
        Dim transferenciaIntForm As New frmTransferenciaInt()
        transferenciaIntForm.Show()
    End Sub

    Private Sub btnTarjetaDebito_Click(sender As Object, e As EventArgs) Handles btnTarjetaDebito.Click
        Dim busquedaTarjetaForm As New frmBuscarTarjeta("debito", Me)
        Tarjeta.nuevoRegistroTarjeta()
        busquedaTarjetaForm.Show()
    End Sub

    Private Sub btnTarjetaCredito_Click(sender As Object, e As EventArgs) Handles btnTarjetaCredito.Click
        Dim busquedaTarjetaForm As New frmBuscarTarjeta("credito", Me)
        Tarjeta.nuevoRegistroTarjeta()
        busquedaTarjetaForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim pcc01frm As New frmPCC01()
        pcc01frm.Show()
    End Sub

    Private Sub btnGiroInt_Click(sender As Object, e As EventArgs) Handles btnGiroInt.Click
        Dim giroIntFrm As New frmGiroInt()
        giroIntFrm.Show()
    End Sub

    Private Sub btnAtencionFin_Click(sender As Object, e As EventArgs) Handles btnAtencionFin.Click
        cont = cont + 1
        lblAtencionCont.Text = "CLIENTES ATENDIDOS: " + cont.ToString
    End Sub
End Class