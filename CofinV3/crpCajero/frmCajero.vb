Imports System.IO
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class frmCajero

    Dim ruta As String = Path.Combine(Application.StartupPath, "csv\Cajero", "movimientos.csv")
    Dim ruta2 As String = Path.Combine(Application.StartupPath, "csv\Cajero", "cajero.csv")
    Dim ruta3 As String = Path.Combine(Application.StartupPath, "csv\Cajero", "usuarios.csv")

    Dim contAtencion As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.Dpi

        ' Configurar columnas del ListView Entradas

        With lstEntradas
            .View = View.Details
            .Columns.Clear()

            Dim anchoTotal As Integer = .ClientSize.Width
            Dim anchoRestante As Integer = anchoTotal - 70
            Dim anchoColumna As Integer = anchoRestante \ 3

            .Columns.Add("Nro", 70)
            .Columns.Add("Tipo", anchoColumna)
            .Columns.Add("Monto", anchoColumna)
            .Columns.Add("Detalle", anchoTotal - (70 + 2 * anchoColumna)) ' Ajuste final
        End With

        ' Configurar columnas del ListView Salidas
        With lstSalidas
            .View = View.Details
            .Columns.Clear()

            Dim anchoTotal As Integer = .ClientSize.Width
            Dim anchoRestante As Integer = anchoTotal - 70
            Dim anchoColumna As Integer = anchoRestante \ 3

            .Columns.Add("Nro", 70)
            .Columns.Add("Tipo", anchoColumna)
            .Columns.Add("Monto", anchoColumna)
            .Columns.Add("Detalle", anchoTotal - (70 + 2 * anchoColumna)) ' Ajuste final
        End With

        lstEntradas.Items.Clear()
        lstSalidas.Items.Clear()

        cargarOperacionesCSV()
    End Sub


    Private Sub agregarOperacion(nro As Integer, tipo As String, monto As String, detalle As String)
        Dim item As New ListViewItem(nro.ToString())
        item.SubItems.Add(tipo)
        item.SubItems.Add(monto)
        item.SubItems.Add(detalle)
        If (tipo = "Depósito" Or tipo = "Pago de Servicios" Or tipo = "Transferencia (Entrada)" Or tipo = "Dinero Recibido") Then
            lstEntradas.Items.Add(item)
        ElseIf (tipo = "Retiro" Or tipo = "Transferencia (Salida)" Or tipo = "Dinero Entregado") Then
            lstSalidas.Items.Add(item)
        End If

    End Sub

    Private Sub btnGenerarOp_Click(sender As Object, e As EventArgs) Handles btnGenerarOp.Click
        Dim form2 = New frmOperaciones()
        form2.ShowDialog()
        cargarOperacionesCSV()
    End Sub

    Private Sub cargarOperacionesCSV()
        If File.Exists(ruta) Then
            lstEntradas.Items.Clear()
            lstSalidas.Items.Clear()

            Dim lineas() As String = File.ReadAllLines(ruta, Encoding.UTF8)

            Dim esPrimera As Boolean = True
            For Each linea In lineas
                If esPrimera Then
                    esPrimera = False
                    Continue For
                End If

                Dim partes() As String = linea.Split(","c)
                If partes.Length >= 4 Then
                    agregarOperacion(CInt(partes(0)), partes(1), partes(2), partes(3))
                End If
            Next

            lstEntradas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            lstEntradas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

            lstSalidas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            lstSalidas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        Else
            lstEntradas.Items.Clear()
            lstSalidas.Items.Clear()
        End If
    End Sub


    Private Sub abrirFormCaja(tipo As String)
        Dim formCaja As New frmBilletaje()
        formCaja.tipo = tipo
        formCaja.ShowDialog()
    End Sub

    Private Sub abrirSolicitud(tipo As String)
        Dim formSolicitud As New frmSolicitud
        formSolicitud.tipo = tipo
        formSolicitud.ShowDialog()
        cargarOperacionesCSV()
    End Sub

    Private Sub btnCuadre_Click(sender As Object, e As EventArgs) Handles btnCuadre.Click
        abrirFormCaja("Cuadre")
    End Sub

    Private Sub btnSaldoInicial_Click(sender As Object, e As EventArgs) Handles btnSaldoInicial.Click
        abrirFormCaja("Saldo Inicial")
    End Sub

    Private Sub btnDineroRecibido_Click(sender As Object, e As EventArgs) Handles btnDineroRecibido.Click
        abrirSolicitud("Dinero Recibido")
    End Sub
    Private Sub btnDineroEntregado_Click(sender As Object, e As EventArgs) Handles btnDineroEntregado.Click
        abrirSolicitud("Dinero Entregado")
    End Sub

    Private Sub btnBalance_Click(sender As Object, e As EventArgs) Handles btnBalance.Click
        Dim balance As New frmBalance()
        frmBalance.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLimpiarOperaciones.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("Se borraran todos los clientes y sus datos relacionados", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        If resultado = DialogResult.OK Then
            File.WriteAllText(ruta, "nro,tipo,monto,detalle" & Environment.NewLine, Encoding.UTF8)
            File.WriteAllText(ruta2, "tipo,200,100,50,20,10,5,2,1,0.50,0.20,0.10" & Environment.NewLine, Encoding.UTF8)
            cargarOperacionesCSV()
            lblAtencionCont.Text = 0
        End If
    End Sub

    Private Sub btnAtencionFin_Click(sender As Object, e As EventArgs) Handles btnAtencionFin.Click
        contAtencion += 1
        lblAtencionCont.Text = "Clientes Atendidos: " + contAtencion.ToString
    End Sub

    Private Sub ListView1_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles lstEntradas.DrawColumnHeader
        ' Cambiar fondo del encabezado
        e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(234, 235, 237)), e.Bounds)

        ' Cambiar texto del encabezado
        TextRenderer.DrawText(e.Graphics, e.Header.Text, lstEntradas.Font, e.Bounds, Color.Black, TextFormatFlags.Left)
    End Sub

    Private Sub ListView1_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles lstEntradas.DrawSubItem
        e.DrawBackground()
        TextRenderer.DrawText(e.Graphics, e.SubItem.Text, lstEntradas.Font, e.Bounds, Color.Black, TextFormatFlags.Left)

        ' Borde sutil
        Dim pen As New Pen(Color.LightGray, 1)
        e.Graphics.DrawRectangle(pen, e.Bounds)
    End Sub


    Private Sub ListView2_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles lstSalidas.DrawColumnHeader
        ' Cambiar fondo del encabezado
        e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(234, 235, 237)), e.Bounds)

        ' Cambiar texto del encabezado
        TextRenderer.DrawText(e.Graphics, e.Header.Text, lstSalidas.Font, e.Bounds, Color.Black, TextFormatFlags.Left)
    End Sub

    Private Sub ListView2_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles lstSalidas.DrawSubItem
        e.DrawBackground()
        TextRenderer.DrawText(e.Graphics, e.SubItem.Text, lstSalidas.Font, e.Bounds, Color.Black, TextFormatFlags.Left)

        ' Borde sutil
        Dim pen As New Pen(Color.LightGray, 1)
        e.Graphics.DrawRectangle(pen, e.Bounds)
    End Sub

    Private Sub frmInicial_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim controlesACentrar As Control() = {
            btnIncautacion,
            btnLimpiarOperaciones,
            btnCuadre,
            btnSaldoInicial,
            btnDineroRecibido,
            btnDineroEntregado,
            btnBalance,
            lstSalidas,
            lstEntradas,
            btnGenerarOp,
            btnAtencionFin,
            lblAtencionCont,
            lblEntradas,
            lblSalidas,
            pctbLogo
        }

        If controlesACentrar.Length = 0 Then Exit Sub

        Dim minLeft = controlesACentrar.Min(Function(c) c.Left)
        Dim maxRight = controlesACentrar.Max(Function(c) c.Right)
        Dim minTop = controlesACentrar.Min(Function(c) c.Top)
        Dim maxBottom = controlesACentrar.Max(Function(c) c.Bottom)

        Dim totalWidth = maxRight - minLeft
        Dim totalHeight = maxBottom - minTop

        Dim offsetX = (Me.ClientSize.Width - totalWidth) \ 2 - minLeft
        Dim offsetY = (Me.ClientSize.Height - totalHeight) \ 2 - minTop

        For Each ctrl In controlesACentrar
            ctrl.Left += offsetX
            ctrl.Top += offsetY
        Next

        ' Reajustar columnas dinámicamente
        If lstEntradas.Items.Count > 0 Then
            lstEntradas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            lstEntradas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        End If

        If lstSalidas.Items.Count > 0 Then
            lstSalidas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            lstSalidas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        End If
    End Sub

    Private Sub btnIncautacion_Click(sender As Object, e As EventArgs) Handles btnIncautacion.Click
        Dim IncautarFrm As New frmIncautacion()
        IncautarFrm.Show()
    End Sub
End Class
