Imports System.IO
Imports System.Text
Public Class frmBilletaje
    Public tipo As String = ""
    Dim ruta2 As String = Path.Combine(Application.StartupPath, "csv\Cajero", "cajero.csv")
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblTituloForm.Text = "Formulario para " + tipo
        Dim encontrado = False

        If File.Exists(ruta2) Then
            Dim lineas() As String = File.ReadAllLines(ruta2, Encoding.UTF8)
            For i As Integer = 1 To lineas.Length - 1
                Dim partes() As String = lineas(i).Split(","c)
                If partes.Length > 0 AndAlso partes(0).Trim().ToLower = tipo.Trim().ToLower() Then
                    mostrarDatos(partes)
                    encontrado = True
                    Exit For
                End If
            Next
        End If

        If Not encontrado Then
            mostrarVacio()
        End If
        calcularMontos()
    End Sub

    Private Sub mostrarVacio()
        txtCant200.Text = "0"
        txtCant100.Text = "0"
        txtCant50.Text = "0"
        txtCant20.Text = "0"
        txtCant10.Text = "0"
        txtCant5.Text = "0"
        txtCant2.Text = "0"
        txtCant1.Text = "0"
        txtCant050.Text = "0"
        txtCant020.Text = "0"
        txtCant010.Text = "0"

        calcularMontos()
    End Sub

    Private Sub mostrarDatos(lista() As String)
        txtCant200.Text = lista(1)
        txtCant100.Text = lista(2)
        txtCant50.Text = lista(3)
        txtCant20.Text = lista(4)
        txtCant10.Text = lista(5)
        txtCant5.Text = lista(6)
        txtCant2.Text = lista(7)
        txtCant1.Text = lista(8)
        txtCant050.Text = lista(9)
        txtCant020.Text = lista(10)
        txtCant010.Text = lista(11)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim linea As String = $"{tipo},{txtCant200.Text},{txtCant100.Text},{txtCant50.Text},{txtCant20.Text},{txtCant10.Text},{txtCant5.Text},{txtCant2.Text},{txtCant1.Text},{txtCant050.Text},{txtCant020.Text},{txtCant010.Text}"
        Dim encabezado As String = "tipo,200,100,50,20,10,5,2,1,0.50,0.20,0.10"
        Dim nuevasLineas As New List(Of String)
        Dim yaExiste As Boolean = False

        If File.Exists(ruta2) Then
            Dim lineas() As String = File.ReadAllLines(ruta2, Encoding.UTF8)

            For Each l In lineas
                If l.Trim() = "" Then Continue For
                If l.StartsWith("tipo") Then
                    nuevasLineas.Add(encabezado)
                Else
                    Dim partes() As String = l.Split(","c)
                    If partes(0).Trim().ToLower() = tipo.Trim().ToLower() Then
                        nuevasLineas.Add(linea) ' Reemplaza
                        yaExiste = True
                    Else
                        nuevasLineas.Add(l)
                    End If
                End If
            Next
        Else
            nuevasLineas.Add(encabezado)
        End If

        If Not yaExiste Then
            nuevasLineas.Add(linea)
        End If

        File.WriteAllLines(ruta2, nuevasLineas.ToArray(), Encoding.UTF8)
        MessageBox.Show("Datos guardados correctamente")
        Me.Close()

    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCant200.KeyPress, txtCant100.KeyPress, txtCant50.KeyPress, txtCant20.KeyPress, txtCant10.KeyPress, txtCant5.KeyPress, txtCant2.KeyPress, txtCant1.KeyPress, txtCant050.KeyPress, txtCant020.KeyPress, txtCant010.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox_Leave(sender As Object, e As EventArgs) Handles txtCant200.Leave, txtCant100.Leave, txtCant50.Leave, txtCant20.Leave, txtCant10.Leave, txtCant5.Leave, txtCant2.Leave, txtCant1.Leave, txtCant050.Leave, txtCant020.Leave, txtCant010.Leave
        ValidarVacio(CType(sender, TextBox))
        calcularMontos()
    End Sub

    Private Sub ValidarVacio(txt As TextBox)
        If String.IsNullOrWhiteSpace(txt.Text) Then
            txt.Text = "0"
        End If
    End Sub

    Private Sub calcularMontos()
        ' Variables individuales
        Dim c200 As Integer = Val(txtCant200.Text)
        Dim c100 As Integer = Val(txtCant100.Text)
        Dim c50 As Integer = Val(txtCant50.Text)
        Dim c20 As Integer = Val(txtCant20.Text)
        Dim c10 As Integer = Val(txtCant10.Text)
        Dim c5 As Integer = Val(txtCant5.Text)
        Dim c2 As Integer = Val(txtCant2.Text)
        Dim c1 As Integer = Val(txtCant1.Text)
        Dim c050 As Integer = Val(txtCant050.Text)
        Dim c020 As Integer = Val(txtCant020.Text)
        Dim c010 As Integer = Val(txtCant010.Text)

        ' Calcular montos
        txtMont200.Text = (c200 * 200D).ToString("N2")
        txtMont100.Text = (c100 * 100D).ToString("N2")
        txtMont50.Text = (c50 * 50D).ToString("N2")
        txtMont20.Text = (c20 * 20D).ToString("N2")
        txtMont10.Text = (c10 * 10D).ToString("N2")
        txtMont5.Text = (c5 * 5D).ToString("N2")
        txtMont2.Text = (c2 * 2D).ToString("N2")
        txtMont1.Text = (c1 * 1D).ToString("N2")
        txtMont050.Text = (c050 * 0.5D).ToString("N2")
        txtMont020.Text = (c020 * 0.2D).ToString("N2")
        txtMont010.Text = (c010 * 0.1D).ToString("N2")

        ' Sumar totales
        Dim totalBilletes As Decimal = c200 * 200D + c100 * 100D + c50 * 50D + c20 * 20D + c10 * 10D
        Dim totalMonedas As Decimal = c5 * 5D + c2 * 2D + c1 * 1D + c050 * 0.5D + c020 * 0.2D + c010 * 0.1D
        Dim totalCompleto As Decimal = totalBilletes + totalMonedas

        txtTotalBill.Text = totalBilletes.ToString("N2")
        txtTotalMon.Text = totalMonedas.ToString("N2")
        txtTotalCompleto.Text = totalCompleto.ToString("N2")
    End Sub
End Class