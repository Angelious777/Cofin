Public Class frmCACPN3

    Private anteriorForm As Form

    Public nuevo = True

    Public Sub New(anterior As Form)
        InitializeComponent()
        anteriorForm = anterior
    End Sub
    Private Sub frmCACPN3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not nuevo Then
            rellenarcampos()
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If ValidarCampos() Then
            RegistrarDatos()

            formCACPN4 = New frmCACPN4(Me)
            If Not nuevo Then
                formCACPN4.nuevo = False
            End If
            formCACPN4.show()
            Me.Hide()
        End If
    End Sub

    Private Sub RellenarCampos()
        Dim reg = CACPN.RegistroActualCACPN
        If reg IsNot Nothing Then
            With reg
                txtEnvioCorrespondencia.Text = .envio_correspondencia
                txtCalleAvCorrespondencia.Text = .calle_av_correspondencia
                txtNumCorrespondencia.Text = .num_correspondencia
                txtDepCorrespondencia.Text = .departamento_correspondencia
                txtProvCorrespondencia.Text = .provincia_correspondencia
                txtDistCorrespondencia.Text = .distrito_correspondencia
                txtEstadoCivil.Text = .estado_civil
                txtVivienda.Text = .vivienda
                txtGradoInstruccion.Text = .grado_instruccion
                txtSituacionLaboral.Text = .situacion_laboral
                txtProfesionOcupacion.Text = .profesion_ocupacion
                txtNombreConyuge.Text = .nombre_completo_conyuge
                txtCiConyuge.Text = .ci_conyuge
                txtNacConyuge.Text = .nacionalidad_conyuge
                txtResiConyuge.Text = .residente_conyuge
                txtGiroActConyuge.Text = .giro_actividad_conyuge
            End With
        Else
            MessageBox.Show("No hay un registro cargado en memoria.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        anteriorForm.Show()
        Me.Close()
    End Sub

    Private Function ValidarCampos() As Boolean
        If String.IsNullOrWhiteSpace(txtEnvioCorrespondencia.Text) Then
            MessageBox.Show("El campo de direccion de correspondencia es obligatorio.", "Campo Requerido", MessageBoxButtons.OK)
            txtEnvioCorrespondencia.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub RegistrarDatos()
        CACPN.RegistroActualCACPN.envio_correspondencia = txtEnvioCorrespondencia.Text
        CACPN.RegistroActualCACPN.calle_av_correspondencia = txtCalleAvCorrespondencia.Text
        CACPN.RegistroActualCACPN.num_correspondencia = txtNumCorrespondencia.Text
        CACPN.RegistroActualCACPN.departamento_correspondencia = txtDepCorrespondencia.Text
        CACPN.RegistroActualCACPN.provincia_correspondencia = txtProvCorrespondencia.Text
        CACPN.RegistroActualCACPN.distrito_correspondencia = txtDistCorrespondencia.Text
        CACPN.RegistroActualCACPN.estado_civil = txtEstadoCivil.Text
        CACPN.RegistroActualCACPN.vivienda = txtVivienda.Text
        CACPN.RegistroActualCACPN.grado_instruccion = txtGradoInstruccion.Text
        CACPN.RegistroActualCACPN.situacion_laboral = txtSituacionLaboral.Text
        CACPN.RegistroActualCACPN.profesion_ocupacion = txtProfesionOcupacion.Text
        CACPN.RegistroActualCACPN.nombre_completo_conyuge = txtNombreConyuge.Text
        CACPN.RegistroActualCACPN.ci_conyuge = txtCiConyuge.Text
        CACPN.RegistroActualCACPN.nacionalidad_conyuge = txtNacConyuge.Text
        CACPN.RegistroActualCACPN.residente_conyuge = txtResiConyuge.Text
        CACPN.RegistroActualCACPN.giro_actividad_conyuge = txtGiroActConyuge.Text
    End Sub
End Class