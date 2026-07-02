Imports System.IO
Imports System.Linq

Module CACPJ
    ' --- Clase de registro ---
    Public Class registroCACPJ
        ' --- Datos de empresa ---
        Public id_razonsocial As String
        Public id_nombrecomercial As String
        Public id_telefonoempresa As String
        Public id_referenciacomercial As String
        Public id_sucursal As String
        Public id_nombresucursal As String
        Public id_direccionsucursal As String

        ' Persona 1
        Public nombre_razon_persona1 As String
        Public fecnac_constitucion_persona1 As String
        Public lugar_nacimiento_persona1 As String
        Public documento_identidad_persona1 As String
        Public lugar_emision_persona1 As String
        Public numero_matricula_persona1 As String
        Public nacionalidad_persona1 As String
        Public segunda_nacionalidad_persona1 As String
        Public telefono_persona1 As String
        Public domicilio_persona1 As String
        Public profesion_actividad_persona1 As String
        Public tipo_relacion_persona1 As String
        Public correo_electronico_persona1 As String
        Public nombre_persona_natural_persona1 As String
        Public porc_participacion_persona1 As String
        Public actividad_ocupacion1_persona1 As String
        Public actividad_ocupacion2_persona1 As String
        Public actividad_ocupacion3_persona1 As String
        Public actividad_ocupacion4_persona1 As String
        Public ocupa_agencia_persona1 As String
        Public cargo_persona1 As String
        Public fecha_ingreso_persona1 As String
        Public ingreso_mensual_persona1 As String
        Public estado_civil_persona1 As String
        Public referencias_personales_persona1 As String
        Public residente_bolivia_persona1 As String
        Public pais_residencia_persona1 As String
        Public nacio_eeuu_persona1 As String

        ' Persona 2
        Public nombre_razon_persona2 As String
        Public fecnac_constitucion_persona2 As String
        Public lugar_nacimiento_persona2 As String
        Public documento_identidad_persona2 As String
        Public lugar_emision_persona2 As String
        Public numero_matricula_persona2 As String
        Public nacionalidad_persona2 As String
        Public segunda_nacionalidad_persona2 As String
        Public telefono_persona2 As String
        Public domicilio_persona2 As String
        Public profesion_actividad_persona2 As String
        Public tipo_relacion_persona2 As String
        Public correo_electronico_persona2 As String
        Public nombre_persona_natural_persona2 As String
        Public porc_participacion_persona2 As String
        Public actividad_ocupacion1_persona2 As String
        Public actividad_ocupacion2_persona2 As String
        Public actividad_ocupacion3_persona2 As String
        Public actividad_ocupacion4_persona2 As String
        Public ocupa_agencia_persona2 As String
        Public cargo_persona2 As String
        Public fecha_ingreso_persona2 As String
        Public ingreso_mensual_persona2 As String
        Public estado_civil_persona2 As String
        Public referencias_personales_persona2 As String
        Public residente_bolivia_persona2 As String
        Public pais_residencia_persona2 As String
        Public nacio_eeuu_persona2 As String

        ' Persona 3
        Public nombre_razon_persona3 As String
        Public fecnac_constitucion_persona3 As String
        Public lugar_nacimiento_persona3 As String
        Public documento_identidad_persona3 As String
        Public lugar_emision_persona3 As String
        Public numero_matricula_persona3 As String
        Public nacionalidad_persona3 As String
        Public segunda_nacionalidad_persona3 As String
        Public telefono_persona3 As String
        Public domicilio_persona3 As String
        Public profesion_actividad_persona3 As String
        Public tipo_relacion_persona3 As String
        Public correo_electronico_persona3 As String
        Public nombre_persona_natural_persona3 As String
        Public porc_participacion_persona3 As String
        Public actividad_ocupacion1_persona3 As String
        Public actividad_ocupacion2_persona3 As String
        Public actividad_ocupacion3_persona3 As String
        Public actividad_ocupacion4_persona3 As String
        Public ocupa_agencia_persona3 As String
        Public cargo_persona3 As String
        Public fecha_ingreso_persona3 As String
        Public ingreso_mensual_persona3 As String
        Public estado_civil_persona3 As String
        Public referencias_personales_persona3 As String
        Public residente_bolivia_persona3 As String
        Public pais_residencia_persona3 As String
        Public nacio_eeuu_persona3 As String

        ' --- Firmas y sellos ---
        Public firma1 As String
        Public nombre_firma1 As String
        Public firma2 As String
        Public nombre_firma2 As String
        Public firma3 As String
        Public nombre_firma3 As String
        Public firma4 As String
        Public nombre_firma4 As String

        Public firma_sello1 As String
        Public firma_sello2 As String
        Public firma_sello3 As String
        Public firma_sello4 As String

        ' Nombre del banco
        Public nombre_banco As String

        ' --- Método para convertir el registro a CSV ---
        Public Function ToCsv() As String
            Dim valores = Me.GetType().GetFields().Select(Function(f) f.GetValue(Me)?.ToString()).ToArray()
            Dim valoresConComillas = valores.Select(Function(v) $"'{v}'")
            Return String.Join(",", valoresConComillas)
        End Function
    End Class

    ' --- Lista global de registros ---
    Public ListaRegistrosCACPJ As New List(Of registroCACPJ)

    ' --- Registro temporal actual ---
    Public RegistroActualCACPJ As New registroCACPJ()

    ' --- Reiniciar registro actual ---
    Public Sub NuevoRegistroCACPJ()
        RegistroActualCACPJ = New registroCACPJ()
    End Sub

    ' --- Cargar registros desde CSV ---
    Public Sub CargarRegistrosDesdeCSVCACPJ(rutaArchivo As String)
        ListaRegistrosCACPJ.Clear()

        If Not File.Exists(rutaArchivo) Then Exit Sub

        Dim lineas = File.ReadAllLines(rutaArchivo)

        For Each linea In lineas
            Dim valores = linea.Split(","c).Select(Function(v) v.Trim("'"c)).ToArray()
            Dim campos = GetType(registroCACPJ).GetFields()

            If valores.Length >= campos.Length Then
                Dim r As New registroCACPJ()

                For i = 0 To campos.Length - 1
                    campos(i).SetValue(r, valores(i))
                Next

                ListaRegistrosCACPJ.Add(r)
                'Debug.Print($"Razon Social: '{r.id_razonsocial}', Banco: '{r.nombre_banco}'")
            End If
        Next
    End Sub

    ' --- Buscar registro por ID ---
    Public Function BuscarRegistroPorIDCACPJ(id As String) As registroCACPJ
        Return ListaRegistrosCACPJ.FirstOrDefault(Function(r) r.id_razonsocial.Trim() = id.Trim())
    End Function

End Module
