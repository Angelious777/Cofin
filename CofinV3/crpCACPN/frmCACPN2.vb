Public Class frmCACPN2

    Private anteriorForm As Form
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
        If ValidarCampos() Then

            RegistrarDatos()

            Dim formcacpn3 As New frmCACPN3(Me)
            If Not nuevo Then
                formcacpn3.nuevo = False
            End If
            formcacpn3.Show()
            Me.Hide()
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

    Private Function ValidarCampos() As Boolean
        ' Validar campos obligatorios
        If String.IsNullOrWhiteSpace(txtNombreEmpresa.Text) Then
            MessageBox.Show("El campo 'Nombre de la Empresa' es obligatorio", "Campo Requerido", MessageBoxButtons.OK)
            txtNombreEmpresa.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtNit.Text) Then
            MessageBox.Show("El campo 'NIT' es obligatorio.", "Campo Requerido", MessageBoxButtons.OK)
            txtNit.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtCalleAvLaboral.Text) Then
            MessageBox.Show("El campo 'Calle/Av. Laboral' es obligatorio.", "Campo Requerido", MessageBoxButtons.OK)
            txtCalleAvLaboral.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtNumeroLaboral.Text) Then
            MessageBox.Show("El campo 'Número Laboral' es obligatorio.", "Campo Requerido", MessageBoxButtons.OK)
            txtNumeroLaboral.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtCargoPuestoLaboral.Text) Then
            MessageBox.Show("El campo 'Cargo / Puesto que ocupa' es obligatorio.", "Campo Requerido", MessageBoxButtons.OK)
            txtCargoPuestoLaboral.Focus()
            Return False
        End If
        If Not chbxPersonaPolitica1.Checked And Not chbxPersonaPolitica2.Checked Then
            MessageBox.Show("Debe seleccionar si es una persona política o no.", "Campo Requerido", MessageBoxButtons.OK)
            Return False
        End If
        If Not chbxCargoPolitico1.Checked And Not chbxCargoPolitico2.Checked Then
            MessageBox.Show("Debe seleccionar si ocupa un cargo político o no.", "Campo Requerido", MessageBoxButtons.OK)
            Return False
        End If

        Return True
    End Function

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

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        anteriorForm.Show()
        Me.Close()
    End Sub

    Private Sub RegistrarDatos()
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
    End Sub
End Class