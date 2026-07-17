Imports System.IO
Module CACPN
    ' Definimos una clase para un registro

    Private ReadOnly carpetaPlataforma As String = Path.Combine(Application.StartupPath, "csv", "Plataforma")
    Private ReadOnly rutaArchivoCSV As String = Path.Combine(carpetaPlataforma, "BCP_cr_act_pers_natural")
    Private ReadOnly rutaArchivoBase As String = Path.Combine(carpetaPlataforma, "Bases", "BCP_cr_act_pers_natural_Base.csv")

    Public Class RegistroCACPN
        Public datos_titular As String = ""
        Public ID_nro As String = ""
        Public ID_ext As String = ""
        Public ID_tipo As String = ""
        Public ID_sexo As String = ""
        Public ID_fecnac As String = ""
        Public ID_nacionalidad As String = ""
        Public ID_2da_nacionalidad As String = ""
        Public ID_residente As String = ""
        Public ID_pais_residencia As String = ""
        Public ID_pais_nacimiento As String = ""
        Public ID_EEUU As String = ""
        Public calle_av As String = ""
        Public calle_av2 As String = ""
        Public numero_domicilio As String = ""
        Public departamento As String = ""
        Public provincia As String = ""
        Public distrito As String = ""
        Public telefono_fijo As String = ""
        Public telefono_celular As String = ""
        Public correo As String = ""
        Public nombre_empresa As String = ""
        Public nit As String = ""
        Public negocio_propio As String = ""
        Public actividad_economica As String = ""
        Public calle_av_laboral As String = ""
        Public calle_av_laboral2 As String = ""
        Public numero_laboral As String = ""
        Public departamento_laboral As String = ""
        Public provincia_laboral As String = ""
        Public distrito_laboral As String = ""
        Public telefono_fijo_laboral As String = ""
        Public telefono_celular_laboral As String = ""
        Public correo_laboral As String = ""
        Public cargo_puesto_laboral As String = ""
        Public tiempo_servicio_laboral As String = ""
        Public fecha_ingreso_laboral As String = ""
        Public ingreso_total_US As String = ""
        Public giro_actividad_1 As String = ""
        Public giro_actividad_2 As String = ""
        Public giro_actividad_3 As String = ""
        Public giro_actividad_4 As String = ""
        Public persona_politica As String = ""
        Public cargo_politico As String = ""
        Public envio_correspondencia As String = ""
        Public calle_av_correspondencia As String = ""
        Public num_correspondencia As String = ""
        Public departamento_correspondencia As String = ""
        Public provincia_correspondencia As String = ""
        Public distrito_correspondencia As String = ""
        Public estado_civil As String = ""
        Public vivienda As String = ""
        Public grado_instruccion As String = ""
        Public situacion_laboral As String = ""
        Public profesion_ocupacion As String = ""
        Public nombre_completo_conyuge As String = ""
        Public ci_conyuge As String = ""
        Public nacionalidad_conyuge As String = ""
        Public residente_conyuge As String = ""
        Public giro_actividad_conyuge As String = ""
        Public banco1 As String = ""
        Public tipo_cuenta1 As String = ""
        Public banco2 As String = ""
        Public tipo_cuenta2 As String = ""
        Public banco3 As String = ""
        Public tipo_cuenta3 As String = ""
        Public nombre_referente1 As String = ""
        Public direccion1 As String = ""
        Public telefono1 As String = ""
        Public nombre_referente2 As String = ""
        Public direccion2 As String = ""
        Public telefono2 As String = ""
        Public nombre_referente3 As String = ""
        Public direccion3 As String = ""
        Public telefono3 As String = ""
        Public nombre_empresa1 As String = ""
        Public direccion_empresa1 As String = ""
        Public telefono_empresa1 As String = ""
        Public nombre_empresa2 As String = ""
        Public direccion_empresa2 As String = ""
        Public telefono_empresa2 As String = ""
        Public nombre_empresa3 As String = ""
        Public direccion_empresa3 As String = ""
        Public telefono_empresa3 As String = ""
        Public firma_declaracion As String = ""
        Public lugar_declaracion As String = ""
        Public fecha1 As String = ""
        Public fecha2 As String = ""
        Public fecha3 As String = ""
        Public firma_plataforma As String = ""
        Public firma_operaciones As String = ""
        Public matricula_vendedor As String = ""
        Public oficina As String = ""
        Public nombre_banco As String = ""


        Public Function ToCsv() As String
            Dim campos = Me.GetType.GetFields()
            Dim valoresConComillas = campos.Select(Function(f)
                                                       Dim valor As String = If(f.GetValue(Me)?.ToString(), "")
                                                       valor = valor.Replace("'", "''") ' Escapar comillas simples
                                                       Return $"'{valor}'"
                                                   End Function)
            Return String.Join(",", valoresConComillas)
        End Function
    End Class

    ' Lista global de registros
    Public ReadOnly Property ListaRegistrosCACPN As New List(Of RegistroCACPN)

    ' Registro temporal que vamos llenando en los forms
    Public Property RegistroActualCACPN As New RegistroCACPN()

    ' Método para reiniciar el registro actual
    Public Sub GenerarNuevoRegistroCACPN()
        RegistroActualCACPN = New RegistroCACPN()
    End Sub

    Private Sub CargarRegistrosDesdeCSVCACPN()
        ListaRegistrosCACPN.Clear()

        If Not IO.File.Exists(rutaArchivoCSV) Then Exit Sub

        Dim lineas = IO.File.ReadAllLines(rutaArchivoCSV)

        For Each linea In lineas.Skip(1)

            Dim valores = linea.Split(","c).Select(Function(v) v.Trim("'"c)).ToArray()
            Dim campos = GetType(RegistroCACPN).GetFields()

            If valores.Length >= campos.Length Then
                Dim r As New RegistroCACPN()

                For i = 0 To campos.Length - 1
                    campos(i).SetValue(r, valores(i))
                Next

                ListaRegistrosCACPN.Add(r)
            End If
        Next
    End Sub

    Public Function BuscarRegistroPorIDCACPN(id As String) As RegistroCACPN
        ' Buscar normalmente
        Return ListaRegistrosCACPN.FirstOrDefault(Function(r) r.ID_nro.Trim() = id.Trim())
    End Function

    Public Function VerificarNuevoRegistroCACPN(id As String) As Boolean
        ' Verifica si el ID ya existe en la lista de registros
        Return ListaRegistrosCACPN.Any(Function(r) r.ID_nro.Trim() = id.Trim())
    End Function

    Public Function CargarDatosCACPN() As List(Of RegistroCACPN)
        CargarRegistrosDesdeCSVCACPN()
        Return ListaRegistrosCACPN
    End Function

    Public Sub RestaurarDatosBaseCACPN()
        If Not File.Exists(rutaArchivoBase) Then
            MessageBox.Show("No se encontró el archivo base en: " & rutaArchivoBase, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        File.Copy(rutaArchivoBase, rutaArchivoCSV, True)
        CargarDatosCACPN()
        MessageBox.Show("La lista se ha restaurado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Console.WriteLine("Datos restaurados de CACPN")
    End Sub

    Public Sub SubirRegistroCSVCACPN(nuevo As Boolean)

        AsegurarArchivoExite()

        Try
            If nuevo Then
                File.AppendAllText(rutaArchivoCSV, RegistroActualCACPN.ToCsv() & Environment.NewLine)
                MessageBox.Show("Datos guardados correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim lineas() As String = File.ReadAllLines(rutaArchivoCSV)
                Dim encontrado As Boolean = False

                For i = 1 To lineas.Length - 1
                    Dim campos() As String = lineas(i).Split(","c)
                    If campos.Length > 1 Then
                        ' Limpiar comillas simples y espacios
                        Dim idCSV As String = campos(1).Trim("'"c).Trim()
                        Dim idActual As String = RegistroActualCACPN.ID_nro.Trim()

                        If idCSV = idActual Then
                            lineas(i) = CACPN.RegistroActualCACPN.ToCsv()
                            encontrado = True
                            Exit For
                        End If
                    End If
                Next

                If encontrado Then
                    File.WriteAllLines(rutaArchivoCSV, lineas)
                    MessageBox.Show("Datos guardados correctamente")
                Else
                    MessageBox.Show("No se encontró el registro para actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error al guardar los datos en CSV: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Atributos() As String
        Return "datos_titular,ID_nro,ID_ext,ID_tipo,ID_sexo,ID_fecnac,ID_nacionalidad,ID_2da_nacionalidad,ID_residente,ID_pais_residencia,ID_pais_nacimiento,ID_EEUU,calle_av,calle_av2,numero_domicilio,departamento,provincia,distrito,telefono_fijo,telefono_celular,correo,nombre_empresa,nit,negocio_propio,actividad_economica,calle_av_laboral,calle_av_laboral2,numero_laboral,departamento_laboral,provincia_laboral,distrito_laboral,telefono_fijo_laboral,telefono_celular_laboral,correo_laboral,cargo_puesto_laboral,tiempo_servicio_laboral,fecha_ingreso_laboral,ingreso_total_US,giro_actividad_1,giro_actividad_2,giro_actividad_3,giro_actividad_4,persona_politica,cargo_politico,envio_correspondencia,calle_av_correspondencia,num_correspondencia,departamento_correspondencia,provincia_correspondencia,distrito_correspondencia,estado_civil,vivienda,grado_instruccion,situacion_laboral,profesion_ocupacion,nombre_completo_conyuge,ci_conyuge,nacionalidad_conyuge,residente_conyuge,giro_actividad_conyuge,banco1,tipo_cuenta1,banco2,tipo_cuenta2,banco3,tipo_cuenta3,nombre_referente1,direccion1,telefono1,nombre_referente2,direccion2,telefono2,nombre_referente3,direccion3,telefono3,nombre_empresa1,direccion_empresa1,telefono_empresa1,nombre_empresa2,direccion_empresa2,telefono_empresa2,nombre_empresa3,direccion_empresa3,telefono_empresa3,firma_declaracion,lugar_declaracion,fecha1,fecha2,fecha3,firma_plataforma,firma_operaciones,matricula_vendedor,oficina,nombre_banco"
    End Function

    Private Sub AsegurarArchivoExite()
        If Not Directory.Exists(carpetaPlataforma) Then
            Directory.CreateDirectory(carpetaPlataforma)
        End If

        If Not File.Exists(rutaArchivoCSV) Then
            File.WriteAllText(rutaArchivoCSV, Atributos() & Environment.NewLine)
        End If
    End Sub
End Module
