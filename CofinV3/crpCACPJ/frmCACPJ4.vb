Imports System.IO

Public Class frmCACPJ4
    Dim anteriorForm As Form
    Public nuevo As Boolean = True

    Private firma1 As Boolean = False
    Private firma2 As Boolean = False
    Private firma3 As Boolean = False
    Private firma4 As Boolean = False
    Private firmasBancarias As Boolean = False

    Private rutaFirmas = Path.Combine(Application.StartupPath, "img\imagenes_firmas")
    Private rutaIconos = Path.Combine(Application.StartupPath, "img\iconos")

    Dim rnd As New Random()
    Dim img1 As String
    Dim img2 As String
    Dim img3 As String
    Dim img4 As String
    Dim imgBancos As String

    Public Sub New(anterior As Form)
        InitializeComponent()
        anteriorForm = anterior
    End Sub

    Private Sub frmCACPJ4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not nuevo Then
            RellenarCampos()
        End If
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        If ValidarCampos() Then
            RegistrarDatos()
            Dim carpeta As String = Path.Combine(Application.StartupPath, "csv", "Plataforma")
            If Not Directory.Exists(carpeta) Then Directory.CreateDirectory(carpeta)
            Dim ruta As String = Path.Combine(carpeta, "BCP_cr_act_pers_juridica.csv")

            If Not File.Exists(ruta) Then
                MessageBox.Show("Error: Archivo no existente")
            End If

            If nuevo Then
                File.AppendAllText(ruta, CACPJ.RegistroActualCACPJ.ToCsv() & Environment.NewLine)
            Else
                Dim lineas() As String = File.ReadAllLines(ruta)
                Dim encontrado As Boolean = False

                For i = 1 To lineas.Length - 1
                    Dim campos() As String = lineas(i).Split(","c)
                    If campos.Length > 1 Then
                        Dim idCSV As String = campos(0).Trim("'"c).Trim()
                        Dim idActual As String = CACPJ.RegistroActualCACPJ.id_razonsocial.Trim()
                        If idCSV = idActual Then
                            lineas(i) = CACPJ.RegistroActualCACPJ.ToCsv()
                            encontrado = True
                            Exit For
                        End If
                    End If
                Next

                If encontrado Then
                    File.WriteAllLines(ruta, lineas)
                Else
                    MessageBox.Show("Error: No se encontro el registro para actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If

            MessageBox.Show("Datos guardados correctamente")
            Me.Close()
        Else
            MessageBox.Show("Campos Faltantes")
        End If
    End Sub

    Private Sub RegistrarDatos()
        CACPJ.RegistroActualCACPJ.firma1 = img1
        CACPJ.RegistroActualCACPJ.nombre_firma1 = txtNombreFirma1.Text
        CACPJ.RegistroActualCACPJ.firma2 = img2
        CACPJ.RegistroActualCACPJ.nombre_firma2 = txtNombreFirma2.Text
        CACPJ.RegistroActualCACPJ.firma3 = img3
        CACPJ.RegistroActualCACPJ.nombre_firma3 = txtNombreFirma3.Text
        CACPJ.RegistroActualCACPJ.firma4 = img4
        CACPJ.RegistroActualCACPJ.nombre_firma4 = txtNombreFirma4.Text
        CACPJ.RegistroActualCACPJ.firma_sello1 = "si"
        CACPJ.RegistroActualCACPJ.firma_sello2 = "si"
        CACPJ.RegistroActualCACPJ.firma_sello3 = "si"
        CACPJ.RegistroActualCACPJ.firma_sello4 = "si"
    End Sub

    Private Sub RellenarCampos()
        firma1 = True
        firma2 = True
        firma3 = True
        firma4 = True
        firmasBancarias = True

        Dim reg = CACPJ.RegistroActualCACPJ
        If reg IsNot Nothing Then
            With reg
                txtNombreFirma1.Text = .nombre_firma1
                txtNombreFirma2.Text = .nombre_firma2
                txtNombreFirma3.Text = .nombre_firma3
                txtNombreFirma4.Text = .nombre_firma4

                img1 = .firma1
                img2 = .firma2
                img3 = .firma3
                img4 = .firma4

                Dim rutaCompleta1 As String = Path.Combine(rutaFirmas, img1)
                If File.Exists(rutaCompleta1) Then
                    pctbFirma1.Image = Image.FromFile(rutaCompleta1)
                End If
                Dim rutaCompleta2 As String = Path.Combine(rutaFirmas, img2)
                If File.Exists(rutaCompleta2) Then
                    pctbFirma2.Image = Image.FromFile(rutaCompleta2)
                End If
                Dim rutaCompleta3 As String = Path.Combine(rutaFirmas, img3)
                If File.Exists(rutaCompleta3) Then
                    pctbFirma3.Image = Image.FromFile(rutaCompleta3)
                End If
                Dim rutaCompleta4 As String = Path.Combine(rutaFirmas, img4)
                If File.Exists(rutaCompleta4) Then
                    pctbFirma4.Image = Image.FromFile(rutaCompleta4)
                End If

                If .firma_sello1 = "si" Then
                    Dim rutaCompletaBanco As String = Path.Combine(rutaIconos, "aprobado.png")
                    If File.Exists(rutaCompletaBanco) Then
                        pctbBancaria1.Image = Image.FromFile(rutaCompletaBanco)
                        pctbBancaria2.Image = Image.FromFile(rutaCompletaBanco)
                        pctbBancaria3.Image = Image.FromFile(rutaCompletaBanco)
                        pctbBancaria4.Image = Image.FromFile(rutaCompletaBanco)
                    End If
                End If
            End With
        Else
            MessageBox.Show("No se encontró ningún registro para rellenar los campos.")
        End If

    End Sub

    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        anteriorForm.Show()
        Me.Close()
    End Sub

    Private Function ValidarCampos() As Boolean
        ' return para pruebas, borrar cuando se haya acabado
        Return True
    End Function

    Private Sub btnFirma1_Click(sender As Object, e As EventArgs) Handles btnFirma1.Click
        Dim num As Integer = rnd.Next(1, 10)
        img1 = $"firma000{num}.png"
        firma1 = True

        Dim rutaCompleta As String = Path.Combine(rutaFirmas, img1)
        If File.Exists(rutaCompleta) Then
            pctbFirma1.Image = Image.FromFile(rutaCompleta)
        End If
    End Sub

    Private Sub btnFirma2_Click(sender As Object, e As EventArgs) Handles btnFirma2.Click
        Dim num As Integer = rnd.Next(1, 10)
        img2 = $"firma000{num}.png"
        firma2 = True

        Dim rutaCompleta As String = Path.Combine(rutaFirmas, img2)
        If File.Exists(rutaCompleta) Then
            pctbFirma2.Image = Image.FromFile(rutaCompleta)
        End If
    End Sub

    Private Sub btnFirma3_Click(sender As Object, e As EventArgs) Handles btnFirma3.Click
        Dim num As Integer = rnd.Next(1, 10)
        img3 = $"firma000{num}.png"
        firma3 = True

        Dim rutaCompleta As String = Path.Combine(rutaFirmas, img3)
        If File.Exists(rutaCompleta) Then
            pctbFirma3.Image = Image.FromFile(rutaCompleta)
        End If
    End Sub

    Private Sub btnFirma4_Click(sender As Object, e As EventArgs) Handles btnFirma4.Click
        Dim num As Integer = rnd.Next(1, 10)
        img4 = $"firma000{num}.png"
        firma4 = True

        Dim rutaCompleta As String = Path.Combine(rutaFirmas, img4)
        If File.Exists(rutaCompleta) Then
            pctbFirma4.Image = Image.FromFile(rutaCompleta)
        End If
    End Sub

    Private Sub btnFirmasBancarias_Click(sender As Object, e As EventArgs) Handles btnFirmasBancarias.Click
        firmasBancarias = True

        Dim rutaCompleta As String = Path.Combine(rutaIconos, "aprobado.png")
        If File.Exists(rutaCompleta) Then
            pctbBancaria1.Image = Image.FromFile(rutaCompleta)
            pctbBancaria2.Image = Image.FromFile(rutaCompleta)
            pctbBancaria3.Image = Image.FromFile(rutaCompleta)
            pctbBancaria4.Image = Image.FromFile(rutaCompleta)
        End If
    End Sub

End Class
