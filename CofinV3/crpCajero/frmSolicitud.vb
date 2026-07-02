Imports System.IO
Imports System.Text

Public Class frmSolicitud

    Public tipo As String
    Dim ruta As String = Path.Combine(Application.StartupPath, "csv\Cajero", "movimientos.csv")
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = "Seleccione Cantidad para " + tipo
        btnGuardar.Enabled = False
    End Sub

    Private Sub bntCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Not String.IsNullOrEmpty(txtMonto.Text) Then
            Dim nro As Integer = 1
            Dim monto As String = txtMonto.Text

            If File.Exists(ruta) Then
                Dim lineas() As String = File.ReadAllLines(ruta, Encoding.UTF8)
                ' Restar 1 por encabezado
                nro = Math.Max(1, lineas.Length)
            Else
                ' Si no existe, crear archivo con encabezado
                File.WriteAllText(ruta, "nro,tipo,monto,detalle" & Environment.NewLine, Encoding.UTF8)
            End If

            Dim linea As String = $"{nro},{tipo},{monto}, "
            File.AppendAllText(ruta, linea & Environment.NewLine, Encoding.UTF8)
            MessageBox.Show("Datos guardados correctamente")
            Me.Close()
        Else
            MessageBox.Show("Ingrese un dato antes de guardar")
        End If
    End Sub

    Private Sub txtMonto_TextChanged(sender As Object, e As EventArgs) Handles txtMonto.TextChanged
        If String.IsNullOrWhiteSpace(txtMonto.Text) Then
            btnGuardar.Enabled = False
        Else
            btnGuardar.Enabled = True
        End If
    End Sub

    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
        Dim tb = CType(sender, TextBox)

        ' Permitir teclas de control (borrar, flechas, etc)
        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
            Return
        End If

        ' Permitir solo dígitos y un punto decimal
        If Char.IsDigit(e.KeyChar) Then
            ' Validar que no se pase de un dígito decimal
            Dim textoAntes = tb.Text
            Dim cursorPos = tb.SelectionStart
            Dim textoSimulado = textoAntes.Substring(0, cursorPos) & e.KeyChar & textoAntes.Substring(cursorPos)

            If textoSimulado.Contains(".") Then
                Dim decimales = textoSimulado.Split("."c)(1)
                If decimales.Length > 2 Then
                    e.Handled = True
                    Return
                End If
            End If
            e.Handled = False
        ElseIf e.KeyChar = "."c Then
            ' Permitir un solo punto y no al inicio
            If tb.Text.Contains(".") OrElse tb.SelectionStart = 0 Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Else
            ' Bloquear todo lo demás
            e.Handled = True
        End If
    End Sub
End Class