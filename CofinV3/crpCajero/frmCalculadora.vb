Imports System.Globalization

Public Class frmCalculadora

    Private listaVisible As Boolean = False
    Private tamanioOriginal As Size

    Dim puntoDecimal As Boolean
    Dim ultimaEntrada As String
    Dim contadorSigno As Integer

    Dim valor1 As String
    Dim signo As String
    Dim valor2 As String
    Dim repetirOperacion As Boolean = False

    Dim pilaHistorial As New Stack(Of Tuple(Of String, String))

    Private backspaceCount As Integer = 0
    Private backspaceTimer As New Timer With {.Interval = 500} ' 500 ms para doble pulsación

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(550, 520)
        Me.ActiveControl = Nothing

        AddHandler backspaceTimer.Tick, AddressOf BackspaceTimer_Tick

        lstbHistorial.Visible = False
        lstbHistorial.DrawMode = DrawMode.OwnerDrawFixed
        lstbHistorial.ItemHeight = 30

        tamanioOriginal = Me.Size
        limpiarOperaciones()

        ActiveControl = lblFoco
        lblFoco.TabStop = False
        lblFoco.Focus()

    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs)
        If listaVisible Then
            lstbHistorial.Visible = False
            Size = tamanioOriginal
            listaVisible = False
        Else
            lstbHistorial.Width = 250
            Size = New Size(tamanioOriginal.Width + lstbHistorial.Width, tamanioOriginal.Height)
            lstbHistorial.Visible = True
            lstbHistorial.Refresh()
            listaVisible = True
        End If
    End Sub

    Private Sub btnDigito_Click(sender As Object, e As EventArgs) Handles btnDigito0.Click, btnDigito1.Click, btnDigito2.Click,
            btnDigito3.Click, btnDigito4.Click, btnDigito5.Click, btnDigito6.Click, btnDigito7.Click, btnDigito8.Click, btnDigito9.Click

        Dim numero As String = CType(sender, Button).Text

        If ultimaEntrada = "Igual" Then
            txtPantalla.Text = ""
            lblSuperior.Text = ""
            valor1 = ""
            signo = ""
            contadorSigno = 0
        End If

        If txtPantalla.Text = "0" OrElse ultimaEntrada <> "Digito" Then
            txtPantalla.Text = ""
        End If

        txtPantalla.Text &= numero
        ultimaEntrada = "Digito"
    End Sub

    Private Sub limpiarOperaciones()
        txtPantalla.Text = "0"
        lblSuperior.Text = ""
        puntoDecimal = False
        ultimaEntrada = "Digito"
        valor1 = "0"
        signo = ""
        contadorSigno = 0
    End Sub

    Private Sub btnOperaciones_Click(sender As Object, e As EventArgs) Handles btnOperacionSuma.Click, btnOperacionResta.Click, btnOperacionMultiplicacion.Click, btnOperacionDivision.Click
        Dim boton As Button = CType(sender, Button)
        Dim nuevaOperacion As String = boton.Text

        If ultimaEntrada = "Digito" Then
            If contadorSigno = 0 Then
                valor1 = txtPantalla.Text
                lblSuperior.Text = valor1 & " " & nuevaOperacion & " "
            Else
                Dim valorPantalla = txtPantalla.Text
                valor1 = calcular(valor1, valorPantalla)
                txtPantalla.Text = valor1
                lblSuperior.Text = valor1 & " " & nuevaOperacion & " "
            End If
            signo = nuevaOperacion
            contadorSigno += 1
        ElseIf ultimaEntrada = "Operador" Then
            signo = nuevaOperacion
            lblSuperior.Text = valor1 & " " & signo & " "
        ElseIf ultimaEntrada = "Igual" Then
            valor1 = txtPantalla.Text
            signo = nuevaOperacion
            lblSuperior.Text = valor1 & " " & signo & " "
            contadorSigno = 1
        End If

        puntoDecimal = False
        ultimaEntrada = "Operador"
    End Sub

    Private Sub btnPuntoDecimal_Click(sender As Object, e As EventArgs) Handles btnPuntoDecimal.Click
        If Not puntoDecimal Then
            If ultimaEntrada <> "Digito" Then
                txtPantalla.Text = "0"
            End If
            txtPantalla.Text &= "."
            puntoDecimal = True
            ultimaEntrada = "Digito"
        End If
    End Sub
    Private Function calcular(val1 As String, val2 As String) As String
        Dim x, y, r As Double
        valor2 = val2

        ' Intentar convertir los valores usando punto decimal como separador
        If Not Double.TryParse(val1, NumberStyles.Any, CultureInfo.InvariantCulture, x) OrElse
       Not Double.TryParse(val2, NumberStyles.Any, CultureInfo.InvariantCulture, y) Then
            Return "Error"
        End If

        Select Case signo
            Case "+"
                r = x + y
            Case "-"
                r = x - y
            Case "x"
                r = x * y
            Case "/"
                If y = 0 Then
                    Return "Error"
                End If
                r = x / y
            Case Else
                Return "Error"
        End Select

        Dim resultadoFormateado = r.ToString("0.#######", CultureInfo.InvariantCulture)
        pilaHistorial.Push(Tuple.Create($"{val1} {signo} {val2}", resultadoFormateado))
        actualizarHistorial()

        Return resultadoFormateado

    End Function


    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click

        If String.IsNullOrEmpty(valor1) OrElse String.IsNullOrEmpty(signo) Then
            Return
        End If

        If ultimaEntrada = "Igual" Then
            lblSuperior.Text = $"{valor1} {signo} {valor2} ="
            Dim resultado = calcular(valor1, valor2)
            txtPantalla.Text = resultado
            valor1 = resultado
            ultimaEntrada = "Igual"
            contadorSigno = 0
            puntoDecimal = resultado.Contains(".")
        Else
            valor2 = txtPantalla.Text
            lblSuperior.Text = $"{valor1} {signo} {valor2} ="
            Dim resultado = calcular(valor1, valor2)
            txtPantalla.Text = resultado
            valor1 = resultado
            ultimaEntrada = "Igual"
            contadorSigno = 0
            puntoDecimal = resultado.Contains(".")
        End If

        puntoDecimal = False
    End Sub

    Private Sub btnInvertirSigno_Click(sender As Object, e As EventArgs) Handles btnInvertirSigno.Click
        Dim num As String = txtPantalla.Text.Replace(".", ",")
        Dim x As Double

        If Double.TryParse(num, x) Then
            x *= -1
            txtPantalla.Text = x.ToString().Replace(",", ".")
        End If
    End Sub


    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnCE.Click, btnC.Click
        Dim boton As Button = CType(sender, Button)
        Dim borrado As String = boton.Text

        Select Case borrado
            Case "CE"
                If ultimaEntrada = "Igual" Then
                    limpiarOperaciones()
                Else
                    txtPantalla.Text = "0"
                    puntoDecimal = False
                End If
            Case "C"
                limpiarOperaciones()
        End Select
    End Sub

    Private Sub bntPorcentaje_Click(sender As Object, e As EventArgs) Handles btnPorcentaje.Click
        Dim num As String = txtPantalla.Text.Replace(".", ",")
        Dim x As Double

        If Double.TryParse(num, x) Then
            x = x / 100
            txtPantalla.Text = x.ToString().Replace(",", ".")
        End If
    End Sub

    Private Sub actualizarHistorial()
        lstbHistorial.Items.Clear()
        For Each item As Tuple(Of String, String) In pilaHistorial
            lstbHistorial.Items.Add(item.Item1 & " = ")
            lstbHistorial.Items.Add(item.Item2)
        Next
    End Sub

    Private Sub lstbHistorial_DrawItem(sender As Object, e As DrawItemEventArgs) Handles lstbHistorial.DrawItem
        If e.Index < 0 Then Return

        Dim texto As String = lstbHistorial.Items(e.Index).ToString()
        Dim esOperacion As Boolean = e.Index Mod 2 = 0

        Dim fondoOperacion As New SolidBrush(Color.FromArgb(199, 199, 199)) ' Gris muy claro
        Dim fondoResultado As New SolidBrush(Color.FromArgb(250, 250, 250)) ' Casi blanco
        Dim textoOperacion As New SolidBrush(Color.FromArgb(50, 50, 50)) ' Gris oscuro
        Dim textoResultado As New SolidBrush(Color.FromArgb(50, 50, 50)) ' Gris oscuro

        Dim fondo As Brush = If(esOperacion, fondoOperacion, fondoResultado)
        Dim colorTexto As Brush = If(esOperacion, textoOperacion, textoResultado)
        Dim fuente As Font = e.Font ' Ningún texto en negrita

        e.Graphics.FillRectangle(fondo, e.Bounds)

        Dim formato As New StringFormat()
        formato.Alignment = StringAlignment.Far
        formato.LineAlignment = StringAlignment.Center

        Dim paddingHorizontal As Integer = 10
        Dim paddingVertical As Integer = 4

        Dim rectTexto As New Rectangle(
            e.Bounds.Left + paddingHorizontal,
            e.Bounds.Top + paddingVertical,
            e.Bounds.Width - 2 * paddingHorizontal,
            e.Bounds.Height - 2 * paddingVertical)

        e.Graphics.DrawString(texto, fuente, colorTexto, rectTexto, formato)

        e.DrawFocusRectangle()

        fondoOperacion.Dispose()
        fondoResultado.Dispose()
        textoOperacion.Dispose()
        textoResultado.Dispose()
    End Sub


    Private Sub Form7_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.D0, Keys.NumPad0 : btnDigito0.PerformClick()
            Case Keys.D1, Keys.NumPad1 : btnDigito1.PerformClick()
            Case Keys.D2, Keys.NumPad2 : btnDigito2.PerformClick()
            Case Keys.D3, Keys.NumPad3 : btnDigito3.PerformClick()
            Case Keys.D4, Keys.NumPad4 : btnDigito4.PerformClick()
            Case Keys.D5, Keys.NumPad5 : btnDigito5.PerformClick()
            Case Keys.D6, Keys.NumPad6 : btnDigito6.PerformClick()
            Case Keys.D7, Keys.NumPad7 : btnDigito7.PerformClick()
            Case Keys.D8, Keys.NumPad8
                If e.Shift Then
                    ' Shift + 8 = *
                    btnOperacionMultiplicacion.PerformClick()
                Else
                    btnDigito8.PerformClick()
                End If
            Case Keys.D9, Keys.NumPad9 : btnDigito9.PerformClick()

            Case Keys.Add, Keys.Oemplus
                If Not e.Shift Then
                    btnOperacionSuma.PerformClick()
                End If

            Case Keys.Subtract, Keys.OemMinus : btnOperacionResta.PerformClick()

            Case Keys.Multiply
                btnOperacionMultiplicacion.PerformClick()

            Case Keys.Divide, Keys.OemQuestion
                btnOperacionDivision.PerformClick()

            Case Keys.Enter, Keys.Return
                btnIgual.PerformClick()

            Case Keys.Back
                backspaceCount += 1
                backspaceTimer.Stop()
                backspaceTimer.Start()
                ' Evitamos que haga el comportamiento normal para que solo se ejecute lo nuestro
                e.Handled = True
                e.SuppressKeyPress = True

            Case Keys.Delete : btnC.PerformClick()
            Case Keys.OemPeriod, Keys.Decimal : btnPuntoDecimal.PerformClick()
        End Select
    End Sub

    Private Sub Form7_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        lblFoco.Select()
    End Sub

    Private Sub BackspaceTimer_Tick(sender As Object, e As EventArgs)
        backspaceTimer.Stop()

        If backspaceCount = 1 Then
            ' Una pulsación -> CE
            btnCE.PerformClick()
        ElseIf backspaceCount >= 2 Then
            ' Dos o más -> C
            btnC.PerformClick()
        End If

        backspaceCount = 0
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If listaVisible Then
            lstbHistorial.Visible = False
            Me.Size = tamanioOriginal
            listaVisible = False
        Else
            lstbHistorial.Width = 250
            Me.Size = New Size(tamanioOriginal.Width + lstbHistorial.Width, tamanioOriginal.Height)
            lstbHistorial.Visible = True
            lstbHistorial.Refresh()
            listaVisible = True
        End If
    End Sub
End Class