Imports System.IO

Public Class frmCACPN5

    Private anteriorForm As Form

    Public nuevo As Boolean = True

    Private firma1 As Boolean = False
    Private firma2 As Boolean = False
    Private firma3 As Boolean = False

    Dim rnd As New Random()
    Dim img1 As String
    Dim img2 As String
    Dim img3 As String

    Private rutaFirmas = Path.Combine(Application.StartupPath, "img\imagenes_firmas")

    Public Sub New(anterior As Form)
        InitializeComponent()
        anteriorForm = anterior
    End Sub

    Private Sub frmCACPN5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not nuevo Then
            RellenarCampos()
            firma1 = True
            firma2 = True
            firma3 = True
        End If
    End Sub

    Private Sub btnFirma1_Click(sender As Object, e As EventArgs) Handles btnFirma1.Click
        GenerarImagenFirma(img1, firma1, pctbxFirma1)
    End Sub

    Private Sub btnFirma2_Click(sender As Object, e As EventArgs) Handles btnFirma2.Click
        GenerarImagenFirma(img2, firma2, pctbxFirma2)
    End Sub

    Private Sub btnFirma3_Click(sender As Object, e As EventArgs) Handles btnFirma3.Click
        GenerarImagenFirma(img3, firma3, pctbxFirma3)
    End Sub

    Private Sub GenerarImagenFirma(ByRef img As String, ByRef firma As Boolean, pctbFirma As PictureBox)
        Dim num As Integer = rnd.Next(1, 10)
        img = $"firma000{num}.png"
        firma = True


        Dim rutacompleta As String = Path.Combine(rutaFirmas, img)
        If File.Exists(rutacompleta) Then
            pctbFirma.Image = Image.FromFile(rutacompleta)
        End If
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        If ValidarCampos() Then

            RegistrarDatos()
            SubirRegistroCSVCACPN(nuevo)
            Me.Close()
        End If
    End Sub

    Private Sub RellenarCampos()
        Dim reg = CACPN.RegistroActualCACPN
        If reg IsNot Nothing Then
            With reg
                txtLugarDeclaracion.Text = .lugar_declaracion
                txtFecha1.Text = .fecha1
                txtFecha2.Text = .fecha2
                txtFecha3.Text = .fecha3

                txtMatricula.Text = .matricula_vendedor
                txtOficina.Text = .oficina

                Dim ruta1 = Path.Combine(rutaFirmas, .firma_declaracion)
                If File.Exists(ruta1) Then pctbxFirma1.Image = Image.FromFile(ruta1)

                Dim ruta2 = Path.Combine(rutaFirmas, .firma_plataforma)
                If File.Exists(ruta2) Then pctbxFirma2.Image = Image.FromFile(ruta2)

                Dim ruta3 = Path.Combine(rutaFirmas, .firma_operaciones)
                If File.Exists(ruta3) Then pctbxFirma3.Image = Image.FromFile(ruta3)

            End With
        Else
            MessageBox.Show("No hay un registro cargado en memoria.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        anteriorForm.Show()
        Me.Close()
    End Sub

    Private Function ValidarCampos() As Boolean
        If firma1 Then
            MessageBox.Show("Generar las firmas es obligatorio.", "Campo Requerido", MessageBoxButtons.OK)
            Return False
        End If
        If firma2 Then
            MessageBox.Show("Generar las firmas es obligatorio.", "Campo Requerido", MessageBoxButtons.OK)
            Return False
        End If
        If firma3 Then
            MessageBox.Show("Generar las firmas es obligatorio.", "Campo Requerido", MessageBoxButtons.OK)
            Return False
        End If

        If String.IsNullOrEmpty(txtLugarDeclaracion.Text) Then
            MessageBox.Show("El campo de lugar de declaración es obligatorio.", "Campo Requerido", MessageBoxButtons.OK)
            txtLugarDeclaracion.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(txtFecha1.Text) Then
            MessageBox.Show("El campo de fecha es obligatorio.", "Campo Requerido", MessageBoxButtons.OK)
            txtFecha1.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txtFecha2.Text) Then
            MessageBox.Show("El campo de fecha es obligatorio.", "Campo Requerido", MessageBoxButtons.OK)
            txtFecha2.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txtFecha3.Text) Then
            MessageBox.Show("El campo de fecha es obligatorio.", "Campo Requerido", MessageBoxButtons.OK)
            txtFecha3.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub RegistrarDatos()
        With CACPN.RegistroActualCACPN
            .firma_declaracion = img1
            .firma_plataforma = img2
            .firma_operaciones = img3

            .lugar_declaracion = txtLugarDeclaracion.Text
            .fecha1 = txtFecha1.Text
            .fecha2 = txtFecha2.Text
            .fecha3 = txtFecha3.Text

            .matricula_vendedor = txtMatricula.Text
            .oficina = txtOficina.Text
        End With
    End Sub
End Class

