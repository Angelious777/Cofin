Public Class frmCACPN2

    Private anteriorForm As Form

    Private checkedSeleccionado1 = False ' chekbox de persona politica
    Private checkedSeleccionado2 = False ' checkbox de cargo politico

    Public nuevo = True

    Public Sub New(anterior As Form)
        InitializeComponent()
        anteriorForm = anterior
    End Sub

    Private Sub frmCACPN2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not nuevo Then
            rellenarcampos()
        End If
    End Sub


    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If checkedSeleccionado1 And checkedSeleccionado2 Then
            CACPN.RegistroActualCACPN.nombre_empresa = txtNombreEmpresa.Text
            CACPN.RegistroActualCACPN.nit = txtNit.Text
            CACPN.RegistroActualCACPN.negocio_propio = txtNegocioPropio.Text
            CACPN.RegistroActualCACPN.actividad_economica = txtActividadEconomica.Text
            CACPN.RegistroActualCACPN.calle_av_laboral = txtCalleAvLaboral.Text
            CACPN.RegistroActualCACPN.numero_laboral = txtNumeroLaboral.Text
            CACPN.RegistroActualCACPN.calle_av_laboral2 = txtCalleAvLaboral2.Text
            CACPN.RegistroActualCACPN.departamento_laboral = txtDepartamentoLaboral.Text
            CACPN.RegistroActualCACPN.provincia_laboral = txtProvinciaLaboral.Text
            CACPN.RegistroActualCACPN.distrito_laboral = txtDistritoLaboral.Text
            CACPN.RegistroActualCACPN.telefono_fijo_laboral = txtTelFijoLaboral.Text
            CACPN.RegistroActualCACPN.telefono_celular_laboral = txtTelCelLaboral.Text
            CACPN.RegistroActualCACPN.correo_laboral = txtCorreoLaboral.Text
            CACPN.RegistroActualCACPN.cargo_puesto_laboral = txtCargoPuestoLaboral.Text
            CACPN.RegistroActualCACPN.tiempo_servicio_laboral = txtTiempoServLaboral.Text
            CACPN.RegistroActualCACPN.fecha_ingreso_laboral = txtFechaIngresoLaboral.Text
            CACPN.RegistroActualCACPN.ingreso_total_US = txtIngresoTotUS.Text
            CACPN.RegistroActualCACPN.giro_actividad_1 = txtGiroActv1.Text
            CACPN.RegistroActualCACPN.giro_actividad_2 = txtGiroActv2.Text
            CACPN.RegistroActualCACPN.giro_actividad_3 = txtGiroActv3.Text
            CACPN.RegistroActualCACPN.giro_actividad_4 = txtGiroActv4.Text
            If chbxPersonaPolitica1.Checked Then
                CACPN.RegistroActualCACPN.persona_politica = "Si"
            End If
            If chbxPersonaPolitica2.Checked Then
                CACPN.RegistroActualCACPN.persona_politica = "No"
            End If
            If chbxCargoPolitico1.Checked Then
                CACPN.RegistroActualCACPN.cargo_politico = "Si"
            End If
            If chbxCargoPolitico2.Checked Then
                CACPN.RegistroActualCACPN.cargo_politico = "No"
            End If


            Dim formcacpn3 As New frmCACPN3(Me)
            If Not nuevo Then
                formcacpn3.nuevo = False
            End If
            formcacpn3.Show()
            Me.Hide()
        Else
            If Not checkedSeleccionado1 Then
                MessageBox.Show("Falta seleccionar si es una persona juridica")
            ElseIf Not checkedSeleccionado2 Then
                MessageBox.Show("Falta seleccionar si ocupa un cargo politico")
            Else
                MessageBox.Show("Falta seleccionar campos")
            End If
        End If
    End Sub

    ' Persona Política
    Private Sub chbxPersonaPolitica1_CheckedChanged(sender As Object, e As EventArgs) Handles chbxPersonaPolitica1.CheckedChanged
        If chbxPersonaPolitica1.Checked Then
            chbxPersonaPolitica2.Checked = False
            checkedSeleccionado1 = True
        ElseIf Not chbxPersonaPolitica2.Checked Then
            checkedSeleccionado1 = False
        End If
    End Sub

    Private Sub chbxPersonaPolitica2_CheckedChanged(sender As Object, e As EventArgs) Handles chbxPersonaPolitica2.CheckedChanged
        If chbxPersonaPolitica2.Checked Then
            chbxPersonaPolitica1.Checked = False
            checkedSeleccionado1 = True
        ElseIf Not chbxPersonaPolitica1.Checked Then
            checkedSeleccionado1 = False
        End If
    End Sub

    ' Cargo Político
    Private Sub chbxCargoPolitico1_CheckedChanged(sender As Object, e As EventArgs) Handles chbxCargoPolitico1.CheckedChanged
        If chbxCargoPolitico1.Checked Then
            chbxCargoPolitico2.Checked = False
            checkedSeleccionado2 = True
        ElseIf Not chbxCargoPolitico2.Checked Then
            checkedSeleccionado2 = False
        End If
    End Sub

    Private Sub chbxCargoPolitico2_CheckedChanged(sender As Object, e As EventArgs) Handles chbxCargoPolitico2.CheckedChanged
        If chbxCargoPolitico2.Checked Then
            chbxCargoPolitico1.Checked = False
            checkedSeleccionado2 = True
        ElseIf Not chbxCargoPolitico1.Checked Then
            checkedSeleccionado2 = False
        End If
    End Sub

    Private Sub rellenarcampos()
        Dim reg = CACPN.RegistroActualCACPN
        If reg IsNot Nothing Then
            With reg
                txtNombreEmpresa.Text = .nombre_empresa
                txtNit.Text = .nit
                txtNegocioPropio.Text = .negocio_propio
                txtActividadEconomica.Text = .actividad_economica
                txtCalleAvLaboral.Text = .calle_av_laboral
                txtNumeroLaboral.Text = .numero_laboral
                txtCalleAvLaboral2.Text = .calle_av_laboral2
                txtDepartamentoLaboral.Text = .departamento_laboral
                txtProvinciaLaboral.Text = .provincia_laboral
                txtDistritoLaboral.Text = .distrito_laboral
                txtTelFijoLaboral.Text = .telefono_fijo_laboral
                txtTelCelLaboral.Text = .telefono_celular_laboral
                txtCorreoLaboral.Text = .correo_laboral
                txtCargoPuestoLaboral.Text = .cargo_puesto_laboral
                txtTiempoServLaboral.Text = .tiempo_servicio_laboral
                txtFechaIngresoLaboral.Text = .fecha_ingreso_laboral
                txtIngresoTotUS.Text = .ingreso_total_US
                txtGiroActv1.Text = .giro_actividad_1
                txtGiroActv2.Text = .giro_actividad_2
                txtGiroActv3.Text = .giro_actividad_3
                txtGiroActv4.Text = .giro_actividad_4

                ' Marcar checkboxes
                chbxPersonaPolitica1.Checked = (.persona_politica = "Si")
                chbxPersonaPolitica2.Checked = (.persona_politica = "No")
                chbxCargoPolitico1.Checked = (.cargo_politico = "Si")
                chbxCargoPolitico2.Checked = (.cargo_politico = "No")
            End With
        End If
    End Sub

    Private Sub DebugRegistroActual()
        Dim reg = CACPN.RegistroActualCACPN
        If reg IsNot Nothing Then
            Debug.Print($"datos_titular: '{reg.datos_titular}'")
            Debug.Print($"ID_nro: '{reg.ID_nro}'")
            Debug.Print($"ID_ext: '{reg.ID_ext}'")
            Debug.Print($"ID_tipo: '{reg.ID_tipo}'")
            Debug.Print($"ID_sexo: '{reg.ID_sexo}'")
            Debug.Print($"ID_fecnac: '{reg.ID_fecnac}'")
            Debug.Print($"ID_nacionalidad: '{reg.ID_nacionalidad}'")
            Debug.Print($"ID_2da_nacionalidad: '{reg.ID_2da_nacionalidad}'")
            Debug.Print($"ID_residente: '{reg.ID_residente}'")
            Debug.Print($"ID_pais_residencia: '{reg.ID_pais_residencia}'")
            Debug.Print($"ID_pais_nacimiento: '{reg.ID_pais_nacimiento}'")
            Debug.Print($"ID_EEUU: '{reg.ID_EEUU}'")
            Debug.Print($"calle_av: '{reg.calle_av}'")
            Debug.Print($"numero_domicilio: '{reg.numero_domicilio}'")
            Debug.Print($"calle_av2: '{reg.calle_av2}'")
            Debug.Print($"departamento: '{reg.departamento}'")
            Debug.Print($"provincia: '{reg.provincia}'")
            Debug.Print($"distrito: '{reg.distrito}'")
            Debug.Print($"telefono_fijo: '{reg.telefono_fijo}'")
            Debug.Print($"telefono_celular: '{reg.telefono_celular}'")
            Debug.Print($"correo: '{reg.correo}'")

            Debug.Print($"nombre_empresa: '{reg.nombre_empresa}'")
            Debug.Print($"nit: '{reg.nit}'")
            Debug.Print($"negocio_propio: '{reg.negocio_propio}'")
            Debug.Print($"actividad_economica: '{reg.actividad_economica}'")
            Debug.Print($"calle_av_laboral: '{reg.calle_av_laboral}'")
            Debug.Print($"numero_laboral: '{reg.numero_laboral}'")
            Debug.Print($"calle_av_laboral2: '{reg.calle_av_laboral2}'")
            Debug.Print($"departamento_laboral: '{reg.departamento_laboral}'")
            Debug.Print($"provincia_laboral: '{reg.provincia_laboral}'")
            Debug.Print($"distrito_laboral: '{reg.distrito_laboral}'")
            Debug.Print($"telefono_fijo_laboral: '{reg.telefono_fijo_laboral}'")
            Debug.Print($"telefono_celular_laboral: '{reg.telefono_celular_laboral}'")
            Debug.Print($"correo_laboral: '{reg.correo_laboral}'")
            Debug.Print($"cargo_puesto_laboral: '{reg.cargo_puesto_laboral}'")
            Debug.Print($"tiempo_servicio_laboral: '{reg.tiempo_servicio_laboral}'")
            Debug.Print($"fecha_ingreso_laboral: '{reg.fecha_ingreso_laboral}'")
            Debug.Print($"ingreso_total_US: '{reg.ingreso_total_US}'")
            Debug.Print($"giro_actividad_1: '{reg.giro_actividad_1}'")
            Debug.Print($"giro_actividad_2: '{reg.giro_actividad_2}'")
            Debug.Print($"giro_actividad_3: '{reg.giro_actividad_3}'")
            Debug.Print($"giro_actividad_4: '{reg.giro_actividad_4}'")

            Debug.Print($"persona_politica: '{reg.persona_politica}'")
            Debug.Print($"cargo_politico: '{reg.cargo_politico}'")
        Else
            Debug.Print("RegistroActual es Nothing (no hay datos cargados).")
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        anteriorForm.Show()
        Me.Close()
    End Sub
End Class