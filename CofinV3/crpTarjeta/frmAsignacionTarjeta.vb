Imports System.Drawing.Drawing2D
Imports System.IO

Public Class frmAsignacionTarjeta

    Dim rutaTarjeta As String = Application.StartupPath & "\csv\Plataforma\Tarjeta.csv"
    Dim ci As String
    Dim formAnterior As Form
    Dim formPlataforma As Form

    Public Sub New(ciTarjeta As String, anterior As Form, plataforma As Form)
        InitializeComponent()
        ci = ciTarjeta
        formAnterior = anterior
        formPlataforma = plataforma
    End Sub

    Private Sub frmAsignacionTarjeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim lineas() As String = File.ReadAllLines(rutaTarjeta)

        For i As Integer = 1 To lineas.Length - 1
            Dim campos() As String = lineas(i).Split(","c)

            If campos(0).Trim() = ci Then
                lblInfo.Text = "Nombre: " & campos(1) & vbCrLf &
                               "Tipo de Tarjeta: " & If(campos(3) = "debito", "Débito", "Crédito")
                txtTarjetaActual.Text = campos(2)
                Exit For
            End If
        Next
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        formAnterior.Show()
        Me.Close()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim nuevaTarjeta As String = txtTarjetaNueva.Text.Trim()

        ' Verificar que tenga exactamente 8 dígitos
        If nuevaTarjeta.Length <> 8 Then
            MessageBox.Show("El número de tarjeta debe tener exactamente 8 dígitos.")
            Return
        End If

        Dim lineas() As String = File.ReadAllLines(rutaTarjeta)

        For i As Integer = 1 To lineas.Length - 1
            Dim campos() As String = lineas(i).Split(","c)

            If campos(0).Trim() = ci Then
                campos(2) = txtTarjetaNueva.Text
                lineas(i) = String.Join(",", campos)
                File.WriteAllLines(rutaTarjeta, lineas)
                MessageBox.Show("Número de tarjeta actualizado correctamente.")
                RegistrarDatos(campos)
                ReporteTarjeta.GenerarPDF("ReporteTarjeta.pdf", "Informe de Actualizacion de Tarjeta")
                formPlataforma.Show()
                Me.Close()
                Exit For
            End If
        Next
    End Sub

    Private Sub RegistrarDatos(campos() As String)
        Tarjeta.registroActualTarjeta.ci = campos(0)
        Tarjeta.registroActualTarjeta.nombre = campos(1)
        Tarjeta.registroActualTarjeta.tarjeta = campos(2)
        Tarjeta.registroActualTarjeta.tipo = campos(3)
    End Sub

    Private Sub txtTarjetaNueva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTarjetaNueva.KeyPress
        ' Permitir solo números y la tecla de retroceso
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class