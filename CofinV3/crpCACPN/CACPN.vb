Imports System.IO
Module CACPN
    ' Definimos una clase para un registro

    Private rutaArchivo As String = "csv/Plataforma/BCP_cr_act_pers_natural.csv"
    Private rutaBase As String = "csv/Plataforma/Bases/BCP_cr_act_pers_natural_Base.csv"

    Public Class RegistroCACPN
        Public datos_titular As String
        Public ID_nro As String
        Public ID_ext As String
        Public ID_tipo As String
        Public ID_sexo As String
        Public ID_fecnac As String
        Public ID_nacionalidad As String
        Public ID_2da_nacionalidad As String
        Public ID_residente As String
        Public ID_pais_residencia As String
        Public ID_pais_nacimiento As String
        Public ID_EEUU As String
        Public calle_av As String
        Public calle_av2 As String
        Public numero_domicilio As String
        Public departamento As String
        Public provincia As String
        Public distrito As String
        Public telefono_fijo As String
        Public telefono_celular As String
        Public correo As String
        Public nombre_empresa As String
        Public nit As String
        Public negocio_propio As String
        Public actividad_economica As String
        Public calle_av_laboral As String
        Public calle_av_laboral2 As String
        Public numero_laboral As String
        Public departamento_laboral As String
        Public provincia_laboral As String
        Public distrito_laboral As String
        Public telefono_fijo_laboral As String
        Public telefono_celular_laboral As String
        Public correo_laboral As String
        Public cargo_puesto_laboral As String
        Public tiempo_servicio_laboral As String
        Public fecha_ingreso_laboral As String
        Public ingreso_total_US As String
        Public giro_actividad_1 As String
        Public giro_actividad_2 As String
        Public giro_actividad_3 As String
        Public giro_actividad_4 As String
        Public persona_politica As String
        Public cargo_politico As String
        Public envio_correspondencia As String
        Public calle_av_correspondencia As String
        Public num_correspondencia As String
        Public departamento_correspondencia As String
        Public provincia_correspondencia As String
        Public distrito_correspondencia As String
        Public estado_civil As String
        Public vivienda As String
        Public grado_instruccion As String
        Public situacion_laboral As String
        Public profesion_ocupacion As String
        Public nombre_completo_conyuge As String
        Public ci_conyuge As String
        Public nacionalidad_conyuge As String
        Public residente_conyuge As String
        Public giro_actividad_conyuge As String
        Public banco1 As String
        Public tipo_cuenta1 As String
        Public banco2 As String
        Public tipo_cuenta2 As String
        Public banco3 As String
        Public tipo_cuenta3 As String
        Public nombre_referente1 As String
        Public direccion1 As String
        Public telefono1 As String
        Public nombre_referente2 As String
        Public direccion2 As String
        Public telefono2 As String
        Public nombre_referente3 As String
        Public direccion3 As String
        Public telefono3 As String
        Public nombre_empresa1 As String
        Public direccion_empresa1 As String
        Public telefono_empresa1 As String
        Public nombre_empresa2 As String
        Public direccion_empresa2 As String
        Public telefono_empresa2 As String
        Public nombre_empresa3 As String
        Public direccion_empresa3 As String
        Public telefono_empresa3 As String
        Public firma_declaracion As String
        Public lugar_declaracion As String
        Public fecha1 As String
        Public fecha2 As String
        Public fecha3 As String
        Public firma_plataforma As String
        Public firma_operaciones As String
        Public matricula_vendedor As String
        Public oficina As String
        Public nombre_banco As String


        Public Function ToCsv() As String
            Dim valores = Me.GetType().GetFields().Select(Function(f) f.GetValue(Me)?.ToString()).ToArray()
            Dim valoresConComillas = valores.Select(Function(v) $"'{v}'")
            Return String.Join(",", valoresConComillas)
        End Function
    End Class

    ' Lista global de registros
    Public ListaRegistrosCACPN As New List(Of RegistroCACPN)

    ' Registro temporal que vamos llenando en los forms
    Public RegistroActualCACPN As New RegistroCACPN()

    ' Método para reiniciar el registro actual
    Public Sub NuevoRegistroCACPN()
        RegistroActualCACPN = New RegistroCACPN()
    End Sub

    Private Sub CargarRegistrosDesdeCSVCACPN()
        ListaRegistrosCACPN.Clear()

        If Not IO.File.Exists(rutaArchivo) Then Exit Sub

        Dim lineas = IO.File.ReadAllLines(rutaArchivo)

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
        If Not File.Exists(rutaBase) Then
            MessageBox.Show("No se encontró el archivo base en: " & rutaBase, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        File.Copy(rutaBase, rutaArchivo, True)
        CargarDatosCACPN()
        MessageBox.Show("La lista se ha restaurado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Console.WriteLine("Datos restaurados de CACPN")
    End Sub

End Module
