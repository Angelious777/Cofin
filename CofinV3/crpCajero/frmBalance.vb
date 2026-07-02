Imports System.ComponentModel
Imports System.IO
Imports System.Text

Public Class frmBalance
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarVacios()
        rellenar()
        verificarDiferencia()
    End Sub
    Private Sub abrirFormCaja(tipo As String)
        Dim formcaja As New frmBilletaje()
        formcaja.tipo = tipo
        formcaja.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub
    Private Sub rellenar()
        Dim ruta As String = Path.Combine(Application.StartupPath, "csv\Cajero", "movimientos.csv")
        Dim ruta2 As String = Path.Combine(Application.StartupPath, "csv\Cajero", "cajero.csv")

        Dim saldoInicial As Double = 0
        Dim dineroRecibido As Double = 0
        Dim dineroEntregado As Double = 0
        Dim saldoFinal As Double = 0
        Dim totalEntradas As Double = 0
        Dim totalSalidas As Double = 0
        Dim cuadre As Double = 0

        If File.Exists(ruta2) Then
            Dim lineasCajero() As String = File.ReadAllLines(ruta2, Encoding.UTF8)
            For i As Integer = 1 To lineasCajero.Length - 1
                Dim partes() As String = lineasCajero(i).Split(","c)
                If partes.Length < 12 Then Continue For

                ' buscar para cada valor de cajero
                Select Case partes(0).Trim().ToLower()
                    Case "saldo inicial"
                        saldoInicial = pedirTotal(partes)
                        txtSaldoInicial.Text = saldoInicial.ToString("F2")
                    Case "cuadre"
                        cuadre = pedirTotal(partes)
                        txtCuadre.Text = cuadre.ToString("F2")
                End Select
            Next
        End If

        If File.Exists(ruta) Then
            Dim lineasMovimientos() As String = File.ReadAllLines(ruta, Encoding.UTF8)
            Dim dinRecibido As Integer = 0
            Dim dinEntregado As Integer = 0

            For i As Integer = 1 To lineasMovimientos.Length - 1
                Dim datos() As String = lineasMovimientos(i).Split(","c)
                ' REVISAR SI ESTO ASI FUNCIONA TODA ESTA FORMA
                If (datos(1) = "Depósito" Or datos(1) = "Pago de Servicios" Or datos(1) = "Transferencia (Entrada)" Or datos(1) = "Dinero Recibido") Then
                    totalEntradas += Val(datos(2))
                ElseIf (datos(1) = "Retiro" Or datos(1) = "Transferencia (Salida)" Or datos(1) = "Dinero Entregado") Then
                    totalSalidas += Val(datos(2))
                End If
                If datos(1) = "Dinero Recibido" Then
                    dinRecibido += datos(2)
                    txtDineroRecibido.Text = dinRecibido.ToString
                ElseIf datos(1) = "Dinero Entregado" Then
                    dinEntregado += datos(2)
                    txtDineroEntregado.Text = dinEntregado.ToString
                End If
            Next
            saldoFinal = totalEntradas - totalSalidas + saldoInicial + dineroRecibido - dineroEntregado
            txtSaldoFinal.Text = saldoFinal.ToString("F2")
            txtTotalIngreso.Text = totalEntradas.ToString("F2")
            txtTotalEgreso.Text = totalSalidas.ToString("F2")
        End If

        txtDiferencia.Text = (cuadre - saldoFinal).ToString("F2")
    End Sub

    Private Function pedirTotal(partes() As String) As Double
        Dim total As Double = 0
        total += partes(1) * 200
        total += partes(2) * 100
        total += partes(3) * 50
        total += partes(4) * 20
        total += partes(5) * 10
        total += partes(6) * 5
        total += partes(7) * 2
        total += partes(8) * 1
        total += partes(9) * 0.5
        total += partes(10) * 0.2
        total += partes(11) * 0.1
        Return total
    End Function
    Private Sub llenarVacios()
        txtSaldoFinal.Text = "0,00"
        txtSaldoInicial.Text = "0,00"
        txtCuadre.Text = "0,00"
        txtDiferencia.Text = "0,00"
        txtDineroEntregado.Text = "0,00"
        txtDineroRecibido.Text = "0,00"
        txtTotalIngreso.Text = "0,00"
        txtTotalEgreso.Text = "0,00"
        lblDiferencia.Text = ""
    End Sub

    Private Sub verificarDiferencia()
        Dim diferencia As Double = txtDiferencia.Text
        If (diferencia <> 0) Then
            If (diferencia > 0) Then
                lblDiferencia.Text = "Dinero Sobrante"
            Else
                lblDiferencia.Text = "Dinero Faltante"
            End If
            lblTituloDiferencia.ForeColor = Color.Red
            txtDiferencia.BackColor = Color.MistyRose
        Else
            lblDiferencia.Text = ""
            lblTituloDiferencia.ForeColor = Color.Green
            txtDiferencia.BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub btnCuadre_Click(sender As Object, e As EventArgs) Handles btnCuadre.Click
        abrirFormCaja("Cuadre")
        rellenar()
        verificarDiferencia()
    End Sub
End Class