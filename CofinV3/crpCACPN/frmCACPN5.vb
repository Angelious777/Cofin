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
            rellenarcampos()
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
        If firma1 And firma2 And firma3 Then

            ' Actualizar datos de RegistroActual
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

            Dim carpeta As String = Path.Combine(Application.StartupPath, "csv", "Plataforma")
            If Not Directory.Exists(carpeta) Then Directory.CreateDirectory(carpeta)
            Dim ruta As String = Path.Combine(carpeta, "BCP_cr_act_pers_natural.csv")

            ' Crear el archivo si no existe
            If Not File.Exists(ruta) Then
                File.WriteAllText(ruta, atributos() & Environment.NewLine)
            End If

            If nuevo Then
                File.AppendAllText(ruta, CACPN.RegistroActualCACPN.ToCsv() & Environment.NewLine)
            Else
                Dim lineas() As String = File.ReadAllLines(ruta)
                Dim encontrado As Boolean = False

                For i = 1 To lineas.Length - 1 ' empieza en 1 para saltar cabecera
                    Dim campos() As String = lineas(i).Split(","c)
                    If campos.Length > 1 Then
                        Dim idCSV As String = campos(1).Trim("'"c).Trim()
                        Dim idActual As String = CACPN.RegistroActualCACPN.ID_nro.Trim()
                        If idCSV = idActual Then
                            lineas(i) = CACPN.RegistroActualCACPN.ToCsv()
                            encontrado = True
                            Exit For
                        End If
                    End If
                Next

                If encontrado Then
                    File.WriteAllLines(ruta, lineas)
                Else
                    MessageBox.Show("No se encontró el registro para actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If


            MessageBox.Show("Datos guardados correctamente")
            Me.Close()
        Else
            MessageBox.Show("Complete los campos de firmas")
        End If
    End Sub


    Public Function atributos() As String
        Return "datos_titular,ID_nro,ID_ext,ID_tipo,ID_sexo,ID_fecnac,ID_nacionalidad,ID_2da_nacionalidad,ID_residente,ID_pais_residencia,ID_pais_nacimiento,ID_EEUU,calle_av,calle_av2,numero_domicilio,departamento,provincia,distrito,telefono_fijo,telefono_celular,correo,nombre_empresa,nit,negocio_propio,actividad_economica,calle_av_laboral,calle_av_laboral2,numero_laboral,departamento_laboral,provincia_laboral,distrito_laboral,telefono_fijo_laboral,telefono_celular_laboral,correo_laboral,cargo_puesto_laboral,tiempo_servicio_laboral,fecha_ingreso_laboral,ingreso_total_US,giro_actividad_1,giro_actividad_2,giro_actividad_3,giro_actividad_4,persona_politica,cargo_politico,envio_correspondencia,calle_av_correspondencia,num_correspondencia,departamento_correspondencia,provincia_correspondencia,distrito_correspondencia,estado_civil,vivienda,grado_instruccion,situacion_laboral,profesion_ocupacion,nombre_completo_conyuge,ci_conyuge,nacionalidad_conyuge,residente_conyuge,giro_actividad_conyuge,banco1,tipo_cuenta1,banco2,tipo_cuenta2,banco3,tipo_cuenta3,nombre_referente1,direccion1,telefono1,nombre_referente2,direccion2,telefono2,nombre_referente3,direccion3,telefono3,nombre_empresa1,direccion_empresa1,telefono_empresa1,nombre_empresa2,direccion_empresa2,telefono_empresa2,nombre_empresa3,direccion_empresa3,telefono_empresa3,firma_declaracion,lugar_declaracion,fecha1,fecha2,fecha3,firma_plataforma,firma_operaciones,matricula_vendedor,oficina"
    End Function

    Private Sub rellenarcampos()
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
End Class

