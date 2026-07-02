Module CACPN
    ' Definimos una clase para un registro
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
            Dim valores = {
                datos_titular, ID_nro, ID_ext, ID_tipo, ID_sexo, ID_fecnac, ID_nacionalidad,
                ID_2da_nacionalidad, ID_residente, ID_pais_residencia, ID_pais_nacimiento, ID_EEUU,
                calle_av, calle_av2, numero_domicilio, departamento, provincia, distrito,
                telefono_fijo, telefono_celular, correo, nombre_empresa, nit, negocio_propio,
                actividad_economica, calle_av_laboral, calle_av_laboral2, numero_laboral,
                departamento_laboral, provincia_laboral, distrito_laboral,
                telefono_fijo_laboral, telefono_celular_laboral, correo_laboral,
                cargo_puesto_laboral, tiempo_servicio_laboral, fecha_ingreso_laboral, ingreso_total_US,
                giro_actividad_1, giro_actividad_2, giro_actividad_3, giro_actividad_4,
                persona_politica, cargo_politico, envio_correspondencia, calle_av_correspondencia,
                num_correspondencia, departamento_correspondencia, provincia_correspondencia,
                distrito_correspondencia, estado_civil, vivienda, grado_instruccion,
                situacion_laboral, profesion_ocupacion, nombre_completo_conyuge, ci_conyuge,
                nacionalidad_conyuge, residente_conyuge, giro_actividad_conyuge,
                banco1, tipo_cuenta1, banco2, tipo_cuenta2, banco3, tipo_cuenta3,
                nombre_referente1, direccion1, telefono1,
                nombre_referente2, direccion2, telefono2,
                nombre_referente3, direccion3, telefono3,
                nombre_empresa1, direccion_empresa1, telefono_empresa1,
                nombre_empresa2, direccion_empresa2, telefono_empresa2,
                nombre_empresa3, direccion_empresa3, telefono_empresa3,
                firma_declaracion, lugar_declaracion, fecha1, fecha2, fecha3,
                firma_plataforma, firma_operaciones, matricula_vendedor, oficina,
                nombre_banco
            }

            ' Envolver cada valor entre comillas simples
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

    Public Sub CargarRegistrosDesdeCSVCACPN(rutaArchivo As String)
        ListaRegistrosCACPN.Clear()

        If Not IO.File.Exists(rutaArchivo) Then Exit Sub

        Dim lineas = IO.File.ReadAllLines(rutaArchivo)

        For Each linea In lineas

            linea = linea.Replace("'", "")

            Dim valores = linea.Split(","c)

            If valores.Length >= 94 Then
                Dim reg As New RegistroCACPN With {
                    .datos_titular = valores(0).Trim(),
                    .ID_nro = valores(1).Trim(),
                    .ID_ext = valores(2).Trim(),
                    .ID_tipo = valores(3).Trim(),
                    .ID_sexo = valores(4).Trim(),
                    .ID_fecnac = valores(5).Trim(),
                    .ID_nacionalidad = valores(6).Trim(),
                    .ID_2da_nacionalidad = valores(7).Trim(),
                    .ID_residente = valores(8).Trim(),
                    .ID_pais_residencia = valores(9).Trim(),
                    .ID_pais_nacimiento = valores(10).Trim(),
                    .ID_EEUU = valores(11).Trim(),
                    .calle_av = valores(12).Trim(),
                    .calle_av2 = valores(13).Trim(),
                    .numero_domicilio = valores(14).Trim(),
                    .departamento = valores(15).Trim(),
                    .provincia = valores(16).Trim(),
                    .distrito = valores(17).Trim(),
                    .telefono_fijo = valores(18).Trim(),
                    .telefono_celular = valores(19).Trim(),
                    .correo = valores(20).Trim(),
                    .nombre_empresa = valores(21).Trim(),
                    .nit = valores(22).Trim(),
                    .negocio_propio = valores(23).Trim(),
                    .actividad_economica = valores(24).Trim(),
                    .calle_av_laboral = valores(25).Trim(),
                    .calle_av_laboral2 = valores(26).Trim(),
                    .numero_laboral = valores(27).Trim(),
                    .departamento_laboral = valores(28).Trim(),
                    .provincia_laboral = valores(29).Trim(),
                    .distrito_laboral = valores(30).Trim(),
                    .telefono_fijo_laboral = valores(31).Trim(),
                    .telefono_celular_laboral = valores(32).Trim(),
                    .correo_laboral = valores(33).Trim(),
                    .cargo_puesto_laboral = valores(34).Trim(),
                    .tiempo_servicio_laboral = valores(35).Trim(),
                    .fecha_ingreso_laboral = valores(36).Trim(),
                    .ingreso_total_US = valores(37).Trim(),
                    .giro_actividad_1 = valores(38).Trim(),
                    .giro_actividad_2 = valores(39).Trim(),
                    .giro_actividad_3 = valores(40).Trim(),
                    .giro_actividad_4 = valores(41).Trim(),
                    .persona_politica = valores(42).Trim(),
                    .cargo_politico = valores(43).Trim(),
                    .envio_correspondencia = valores(44).Trim(),
                    .calle_av_correspondencia = valores(45).Trim(),
                    .num_correspondencia = valores(46).Trim(),
                    .departamento_correspondencia = valores(47).Trim(),
                    .provincia_correspondencia = valores(48).Trim(),
                    .distrito_correspondencia = valores(49).Trim(),
                    .estado_civil = valores(50).Trim(),
                    .vivienda = valores(51).Trim(),
                    .grado_instruccion = valores(52).Trim(),
                    .situacion_laboral = valores(53).Trim(),
                    .profesion_ocupacion = valores(54).Trim(),
                    .nombre_completo_conyuge = valores(55).Trim(),
                    .ci_conyuge = valores(56).Trim(),
                    .nacionalidad_conyuge = valores(57).Trim(),
                    .residente_conyuge = valores(58).Trim(),
                    .giro_actividad_conyuge = valores(59).Trim(),
                    .banco1 = valores(60).Trim(),
                    .tipo_cuenta1 = valores(61).Trim(),
                    .banco2 = valores(62).Trim(),
                    .tipo_cuenta2 = valores(63).Trim(),
                    .banco3 = valores(64).Trim(),
                    .tipo_cuenta3 = valores(65).Trim(),
                    .nombre_referente1 = valores(66).Trim(),
                    .direccion1 = valores(67).Trim(),
                    .telefono1 = valores(68).Trim(),
                    .nombre_referente2 = valores(69).Trim(),
                    .direccion2 = valores(70).Trim(),
                    .telefono2 = valores(71).Trim(),
                    .nombre_referente3 = valores(72).Trim(),
                    .direccion3 = valores(73).Trim(),
                    .telefono3 = valores(74).Trim(),
                    .nombre_empresa1 = valores(75).Trim(),
                    .direccion_empresa1 = valores(76).Trim(),
                    .telefono_empresa1 = valores(77).Trim(),
                    .nombre_empresa2 = valores(78).Trim(),
                    .direccion_empresa2 = valores(79).Trim(),
                    .telefono_empresa2 = valores(80).Trim(),
                    .nombre_empresa3 = valores(81).Trim(),
                    .direccion_empresa3 = valores(82).Trim(),
                    .telefono_empresa3 = valores(83).Trim(),
                    .firma_declaracion = valores(84).Trim(),
                    .lugar_declaracion = valores(85).Trim(),
                    .fecha1 = valores(86).Trim(),
                    .fecha2 = valores(87).Trim(),
                    .fecha3 = valores(88).Trim(),
                    .firma_plataforma = valores(89).Trim(),
                    .firma_operaciones = valores(90).Trim(),
                    .matricula_vendedor = valores(91).Trim(),
                    .oficina = valores(92).Trim(),
                    .nombre_banco = valores(93).Trim()
                }
                ListaRegistrosCACPN.Add(reg)

                Debug.Print($"ID cargado: '{reg.ID_nro}', Banco: '{reg.nombre_banco}'")
            Else
                MessageBox.Show("Línea ignorada por longitud:" & valores.Length() & "7777777" & linea)
            End If

        Next
    End Sub

    Public Function BuscarRegistroPorIDCACPN(id As String) As RegistroCACPN

        ' Mostrar todos los ID_nro que se cargaron
        For Each reg In ListaRegistrosCACPN
            MessageBox.Show("ID_nro: " & reg.ID_nro)
        Next

        ' Buscar normalmente
        Return ListaRegistrosCACPN.FirstOrDefault(Function(r) r.ID_nro.Trim() = id.Trim())
    End Function


End Module
