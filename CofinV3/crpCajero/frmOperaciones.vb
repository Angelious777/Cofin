Imports System.IO
Imports System.Text

Public Class frmOperaciones

    Dim ruta As String = Path.Combine(Application.StartupPath, "csv\Cajero\movimientos.csv")
    Dim ruta3 As String = Path.Combine(Application.StartupPath, "csv\Cajero\usuarios.csv")

    Dim cuentaEncontrada = False
    Private instanciaCalculadora As frmCalculadora = Nothing
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxSubTipo.Enabled = False
        btnVerificarUsuario.Enabled = False

        lblCuentaDestino.Visible = False
        txtCuentaDestino.Visible = False
        txtCuentaDestino.Enabled = False

        lblVerificacionCuenta.Text = "Cuenta no Verificada"
        iconoVerificado(2)
    End Sub

    Private Sub cbxTipoOp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTipoOp.SelectedIndexChanged
        cbxSubTipo.Items.Clear() ' Limpiar opciones anteriores

        Select Case cbxTipoOp.SelectedItem.ToString()
            Case "Depósito"
                lblSubTipo.Text = "Tipo de Depósito"
                cbxSubTipo.Items.Add("Depósito en caja de ahorros")
                cbxSubTipo.Items.Add("Amortización de Crédito")
                cbxSubTipo.Items.Add("Aportes a gestora")
                cbxSubTipo.Items.Add("Depósito a Plazo Fijo")
                cbxSubTipo.Items.Add("Depósito CTA CTE")
                cbxSubTipo.Items.Add("Pago de Cuota de Crédito")
                cbxSubTipo.Items.Add("Pago de Tarjeta de Crédito")
                cbxSubTipo.Items.Add("Pago de Impuestos")
            Case "Retiro"
                lblSubTipo.Text = "Tipo de Retiro"
                cbxSubTipo.Items.Add("Cobro Cheque Gerencia")
                cbxSubTipo.Items.Add("Cobro de Cheque")
                cbxSubTipo.Items.Add("Cobro Depósito a Plazo Fijo")
                cbxSubTipo.Items.Add("Desembolso de Crédito")
                cbxSubTipo.Items.Add("Retiro AFP")
                cbxSubTipo.Items.Add("Retiro CTA CTE")
                cbxSubTipo.Items.Add("Retiro Caja de Ahorros")
                cbxSubTipo.Items.Add("Retiro de Sueldo")
                cbxSubTipo.Items.Add("Retiro DPF")
                cbxSubTipo.Items.Add("Retiro Fondo de Inversión")
                cbxSubTipo.Items.Add("Adelanto de Efectivo Tarjeta de Crédito")
            Case "Pago de Servicios"
                lblSubTipo.Text = "Tipo de Servicio"
                cbxSubTipo.Items.Add("DELAPAZ")
                cbxSubTipo.Items.Add("EPSAS")
                cbxSubTipo.Items.Add("Tigo")
                cbxSubTipo.Items.Add("Viva")
                cbxSubTipo.Items.Add("Entel")
                cbxSubTipo.Items.Add("YPFB")
                cbxSubTipo.Items.Add("Cotel")
            Case "Transferencia"
                lblSubTipo.Text = ""
        End Select

        ' Habilitar el sub tipo si hay selección
        cbxSubTipo.Enabled = (cbxTipoOp.SelectedIndex <> -1 AndAlso cbxTipoOp.SelectedIndex <> 3)
        If cbxTipoOp.SelectedIndex = 3 Then
            txtCuentaDestino.Visible = True
            lblCuentaDestino.Visible = True
            txtCuentaDestino.Enabled = True
        Else
            txtCuentaDestino.Visible = False
            lblCuentaDestino.Visible = False
            txtCuentaDestino.Enabled = False
        End If
        cbxSubTipo.SelectedIndex = -1 ' Que inicie sin selección
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        txtMonto.Text = txtMonto.Text.Trim()
        Dim camposCompleto = False
        Dim aceptado = False

        If cbxTipoOp.SelectedIndex = 3 Then
            If Not String.IsNullOrWhiteSpace(txtCuentaDestino.Text) Then
                aceptado = True
            End If
        ElseIf cbxSubTipo.SelectedIndex <> -1 And cbxTipoOp.SelectedIndex <> 3 Then
            If Not String.IsNullOrWhiteSpace(txtMonto.Text) And cuentaEncontrada Then
                aceptado = True
            End If
        End If

        If aceptado Then

            Dim montoValor As Decimal
            If Decimal.TryParse(txtMonto.Text, montoValor) AndAlso montoValor >= 70000 Then
                Dim resp As DialogResult = MessageBox.Show(
                    "Se necesita llenar el formulario PCC-01",
                    "Aviso",
                    MessageBoxButtons.OKCancel
                )

                If resp = DialogResult.OK Then
                    Dim PCC01frm As New frmPCC01()
                    PCC01frm.ShowDialog()

                    If Not PCC01frm.FormularioCompleto Then
                        MessageBox.Show("Debe completar el formulario PCC-01 antes de guardar.")
                        Exit Sub
                    End If
                Else
                    exit Sub
                End If
            End If

            ' Generar número de operación basado en la cantidad de líneas existentes
            camposCompleto = True
            Dim nro As Integer = 1
            If File.Exists(ruta) Then
                Dim lineas() As String = File.ReadAllLines(ruta, Encoding.UTF8)
                ' Restar 1 por encabezado
                nro = Math.Max(1, lineas.Length)
            Else
                ' Si no existe, crear archivo con encabezado
                File.WriteAllText(ruta, "nro,tipo,monto,detalle" & Environment.NewLine, Encoding.UTF8)
            End If

            Dim tipo As String = cbxTipoOp.SelectedItem.ToString()
            Dim detalle As String = ""
            If cbxTipoOp.SelectedIndex <> 3 Then
                detalle = cbxSubTipo.SelectedItem.ToString()
            End If

            Dim monto As String = txtMonto.Text

            If cbxTipoOp.SelectedIndex = 3 Then
                Dim linea1 As String = $"{nro},Transferencia (Entrada),{monto},{detalle}"
                Dim linea2 As String = $"{nro + 1},Transferencia (Salida),{monto},{detalle}"
                File.AppendAllText(ruta, linea1 & Environment.NewLine & linea2 & Environment.NewLine, Encoding.UTF8)
            Else
                Dim linea As String = $"{nro},{tipo},{monto},{detalle}"
                File.AppendAllText(ruta, linea & Environment.NewLine, Encoding.UTF8)
            End If


            MessageBox.Show("Guardado Correctamente")
            Me.Close()
        Else
            If cuentaEncontrada Then
                MessageBox.Show("Por favor completa todos los campos")
            Else
                MessageBox.Show("Por favor completa todos los campos" & Environment.NewLine & "Verifique al cliente")
            End If
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

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        btnVerificarUsuario.Enabled = Not String.IsNullOrWhiteSpace(txtUsuario.Text)
        cuentaEncontrada = False
        iconoVerificado(2)
        lblVerificacionCuenta.Text = "Cuenta no Verificada"
    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Bloquear la tecla
        End If
    End Sub

    Private Sub txtCuentaDestino_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuentaDestino.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnVerificarUsuario_Click(sender As Object, e As EventArgs) Handles btnVerificarUsuario.Click
        cuentaEncontrada = False
        Dim nro As String = ""

        nro = txtUsuario.Text
        Dim lineas() As String = File.ReadAllLines(ruta3, Encoding.UTF8)
        Dim esPrimera As Boolean = True

        For Each linea In lineas
            If esPrimera Then
                esPrimera = False
                Continue For ' Saltar la línea de encabezado
            End If

            Dim partes() As String = linea.Split(","c)
            If (partes(0) = nro) Then
                Dim imagen1 As String = partes(3) ' imagen cliente
                Dim imagen2 As String = partes(4) ' imagen firma
                Dim imagen3 As String = partes(5) ' imagen huella
                Dim rutaImagen1 As String = Path.Combine(Application.StartupPath, "img\imagenes_clientes", imagen1)
                Dim rutaImagen2 As String = Path.Combine(Application.StartupPath, "img\imagenes_firmas", imagen2)
                Dim rutaImagen3 As String = Path.Combine(Application.StartupPath, "img\imagenes_huellas", imagen3)
                If (File.Exists(rutaImagen1) And File.Exists(rutaImagen2) And File.Exists(rutaImagen3)) Then
                    Dim img1 As Image = Image.FromFile(rutaImagen1)
                    Dim img2 As Image = Image.FromFile(rutaImagen2)
                    Dim img3 As Image = Image.FromFile(rutaImagen3)
                    Dim datosCliente As New frmCliente()
                    datosCliente.mostrarImagen(img1, img2, img3, nro, partes(1))
                    datosCliente.ShowDialog()
                Else
                    MessageBox.Show("Imagenes no encontrada para esta cuenta")
                End If
                cuentaEncontrada = True
                lblVerificacionCuenta.Text = "Cuenta Verificada"
                iconoVerificado(1)
                Exit For
            End If
        Next

        If Not cuentaEncontrada Then
            MessageBox.Show("Cuenta no Encontrada")
        End If
    End Sub

    Private Sub iconoVerificado(n As Integer)
        If (n = 1) Then
            Dim iconruta As String = Path.Combine(Application.StartupPath, "img\iconos\check.png")
            pctbVerificado.Image = Image.FromFile(iconruta)
        Else
            Dim iconruta As String = Path.Combine(Application.StartupPath, "img\iconos\notcheck.png")
            pctbVerificado.Image = Image.FromFile(iconruta)
        End If
    End Sub

    Private Sub btnCalculadora_Click(sender As Object, e As EventArgs)
        If instanciaCalculadora Is Nothing OrElse instanciaCalculadora.IsDisposed Then
            instanciaCalculadora = New frmCalculadora
            instanciaCalculadora.Show()
        Else
            instanciaCalculadora.BringToFront()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pctbBtnCalculadora.Click
        If instanciaCalculadora Is Nothing OrElse instanciaCalculadora.IsDisposed Then
            instanciaCalculadora = New frmCalculadora()
            instanciaCalculadora.Show()
        Else
            instanciaCalculadora.BringToFront()
        End If
    End Sub
End Class