Imports System.IO

Public Class frmBuscarTarjeta

    Dim tipo As String
    Dim formAnterior As Form
    Dim encontrado As Boolean = False
    Dim ciTarjeta As String

    Public Sub New(tipoTarjeta As String, anterior As Form)
        InitializeComponent()
        tipo = tipoTarjeta
        formAnterior = anterior
    End Sub

    Private Sub frmBuscarTarjeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInfo.Text = " "
        If tipo = "debito" Then
            lblTituloForm.Text = lblTituloForm.Text + " DE DÉBITO"
        ElseIf tipo = "credito" Then
            lblTituloForm.Text = lblTituloForm.Text + " DE CRÉDITO"
        Else
            MessageBox.Show("Tipo mal especificado")
        End If
    End Sub

    Dim rutaTarjeta As String = Application.StartupPath & "\csv\Plataforma\Tarjeta.csv"

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Dim ciBusqueda = txtBusqueda.Text.Trim()

        If String.IsNullOrWhiteSpace(ciBusqueda) Then
            MessageBox.Show("Ingrese el CI de la cuenta")
            Return
        End If

        Dim lineas() As String = File.ReadAllLines(rutaTarjeta)


        ' formato de tarjeta: ci,nombre,tarjeta,tipo
        For i As Integer = 1 To lineas.Length - 1
            Dim campos() As String = lineas(i).Split(","c)

            If campos(0).Trim() = ciBusqueda And campos(3) = tipo Then
                lblInfo.Text = "Nombre: " & campos(1) & vbCrLf &
                               "Nro de Tarjeta: " & campos(2) & vbCrLf &
                               "Tipo: " & campos(3)
                ciTarjeta = campos(0)
                encontrado = True
                Exit For
            End If
        Next

        If Not encontrado Then
            MessageBox.Show("CI no encontrado")
        End If
    End Sub

    Public Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        formAnterior.Show()
        Me.Close()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If encontrado Then
            Dim asignacionTarjetaForm As New frmAsignacionTarjeta(ciTarjeta, Me, formAnterior)
            asignacionTarjetaForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Llene el CI o Verifique los Datos")
        End If
    End Sub

    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqueda.KeyPress
        ' Permitir solo números y la tecla de retroceso
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            encontrado = False
        End If
    End Sub

    Private Sub btnAlmacenados_Click(sender As Object, e As EventArgs) Handles btnAlmacenados.Click
        Dim listasFrm As New frmListas("tarjeta")
        listasFrm.Show()
    End Sub
End Class