Public Class frmCACPJ2

    Public nuevo As Boolean = True
    Private anteriorForm As Form

    Public Sub New(anterior As Form)
        InitializeComponent()
        anteriorForm = anterior
    End Sub

    Private Sub frmCACPJ2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not nuevo Then
            RellenarCampos()
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If ValidarCampos() Then
            RegistrarDatos()
            ' cambiar
            Dim frmcacj3 As New frmCACPJ3(Me)
            If Not nuevo Then
                frmcacj3.nuevo = False
            End If
            frmcacj3.Show()
            Me.Hide()
        Else
            MessageBox.Show("campos faltantes")
        End If

        'Dim frmcacj3 As New frmCACPJ3()
        'frmcacj3.Show()
    End Sub


    Private Function ValidarCampos() As Boolean
        Dim valido As Boolean = True

        ' retornar true en caso de que esten llenos, para verificar campos obligatorios
        ' Grupo Persona 1
        If Not String.IsNullOrWhiteSpace(CACPJ.RegistroActualCACPJ.nombre_razon_persona1) Then
            If Not validarP1() Then valido = False
        End If

        ' Grupo Persona 2
        If Not String.IsNullOrWhiteSpace(CACPJ.RegistroActualCACPJ.nombre_razon_persona2) Then
            If Not validarP2() Then valido = False
        End If

        ' Grupo Persona 3
        If Not String.IsNullOrWhiteSpace(CACPJ.RegistroActualCACPJ.nombre_razon_persona3) Then
            If Not validarP3() Then valido = False
        End If

        Return valido
    End Function

    Private Function validarP1() As Boolean
        If String.IsNullOrWhiteSpace(txtTelefonoP1.Text) Then Return False
        If String.IsNullOrWhiteSpace(txtDomicilioP1.Text) Then Return False
        If String.IsNullOrWhiteSpace(txtProfesionP1.Text) Then Return False

        Return True
    End Function

    Private Function validarP2() As Boolean
        If String.IsNullOrWhiteSpace(txtTelefonoP2.Text) Then Return False
        If String.IsNullOrWhiteSpace(txtDomicilioP2.Text) Then Return False
        ' agrega más campos obligatorios del grupo 2 aquí...
        Return True
    End Function

    Private Function validarP3() As Boolean
        If String.IsNullOrWhiteSpace(txtTelefonoP3.Text) Then Return False
        If String.IsNullOrWhiteSpace(txtDomicilioP3.Text) Then Return False
        ' agrega más campos obligatorios del grupo 3 aquí...
        Return True
    End Function

    Private Sub RegistrarDatos()
        ' --- Grupo Persona 1 ---
        If Not String.IsNullOrWhiteSpace(CACPJ.RegistroActualCACPJ.nombre_razon_persona1) Then
            CACPJ.RegistroActualCACPJ.telefono_persona1 = txtTelefonoP1.Text
            CACPJ.RegistroActualCACPJ.domicilio_persona1 = txtDomicilioP1.Text
            CACPJ.RegistroActualCACPJ.profesion_actividad_persona1 = txtProfesionP1.Text
            If chbxRelacion1P1.Checked Then
                CACPJ.RegistroActualCACPJ.tipo_relacion_persona1 = "socio/accionista"
            ElseIf chbxRelacion2P1.Checked Then
                CACPJ.RegistroActualCACPJ.tipo_relacion_persona1 = "representante legal"
            ElseIf chbxRelacion3P1.Checked Then
                CACPJ.RegistroActualCACPJ.tipo_relacion_persona1 = "controlling person"
            End If
            CACPJ.RegistroActualCACPJ.correo_electronico_persona1 = txtCorreoP1.Text
            CACPJ.RegistroActualCACPJ.nombre_persona_natural_persona1 = txtNomPNP1.Text
            CACPJ.RegistroActualCACPJ.porc_participacion_persona1 = txtPorPartP1.Text
            CACPJ.RegistroActualCACPJ.actividad_ocupacion1_persona1 = txtActOc1P1.Text
            CACPJ.RegistroActualCACPJ.actividad_ocupacion2_persona1 = txtActOc2P1.Text
            CACPJ.RegistroActualCACPJ.actividad_ocupacion3_persona1 = txtActOc3P1.Text
            CACPJ.RegistroActualCACPJ.actividad_ocupacion4_persona1 = txtActOc4P1.Text
            If chbxSIP1.Checked Then
                CACPJ.RegistroActualCACPJ.ocupa_agencia_persona1 = "si"
            ElseIf chbxNOP1.Checked Then
                CACPJ.RegistroActualCACPJ.ocupa_agencia_persona1 = "no"
            End If
            CACPJ.RegistroActualCACPJ.cargo_persona1 = txtCargoP1.Text
        End If

        ' --- Grupo Persona 2 ---
        If Not String.IsNullOrWhiteSpace(CACPJ.RegistroActualCACPJ.nombre_razon_persona2) Then
            CACPJ.RegistroActualCACPJ.telefono_persona2 = txtTelefonoP2.Text
            CACPJ.RegistroActualCACPJ.domicilio_persona2 = txtDomicilioP2.Text
            CACPJ.RegistroActualCACPJ.profesion_actividad_persona2 = txtProfesionP2.Text
            If chbxRelacion1P2.Checked Then
                CACPJ.RegistroActualCACPJ.tipo_relacion_persona2 = "socio/accionista"
            ElseIf chbxRelacion2P2.Checked Then
                CACPJ.RegistroActualCACPJ.tipo_relacion_persona2 = "representante legal"
            ElseIf chbxRelacion3P2.Checked Then
                CACPJ.RegistroActualCACPJ.tipo_relacion_persona2 = "controlling person"
            End If
            CACPJ.RegistroActualCACPJ.correo_electronico_persona2 = txtCorreoP2.Text
            CACPJ.RegistroActualCACPJ.nombre_persona_natural_persona2 = txtNomPNP2.Text
            CACPJ.RegistroActualCACPJ.porc_participacion_persona2 = txtPorPartP2.Text
            CACPJ.RegistroActualCACPJ.actividad_ocupacion1_persona2 = txtActOc1P2.Text
            CACPJ.RegistroActualCACPJ.actividad_ocupacion2_persona2 = txtActOc2P2.Text
            CACPJ.RegistroActualCACPJ.actividad_ocupacion3_persona2 = txtActOc3P2.Text
            CACPJ.RegistroActualCACPJ.actividad_ocupacion4_persona2 = txtActOc4P2.Text
            If chbxSIP2.Checked Then
                CACPJ.RegistroActualCACPJ.ocupa_agencia_persona2 = "si"
            ElseIf chbxNOP2.Checked Then
                CACPJ.RegistroActualCACPJ.ocupa_agencia_persona2 = "no"
            End If
            CACPJ.RegistroActualCACPJ.cargo_persona2 = txtCargoP2.Text
        End If

        ' --- Grupo Persona 3 ---
        If Not String.IsNullOrWhiteSpace(CACPJ.RegistroActualCACPJ.nombre_razon_persona3) Then
            CACPJ.RegistroActualCACPJ.telefono_persona3 = txtTelefonoP3.Text
            CACPJ.RegistroActualCACPJ.domicilio_persona3 = txtDomicilioP3.Text
            CACPJ.RegistroActualCACPJ.profesion_actividad_persona3 = txtProfesionP3.Text
            If chbxRelacion1P3.Checked Then
                CACPJ.RegistroActualCACPJ.tipo_relacion_persona3 = "socio/accionista"
            ElseIf chbxRelacion2P3.Checked Then
                CACPJ.RegistroActualCACPJ.tipo_relacion_persona3 = "representante legal"
            ElseIf chbxRelacion3P3.Checked Then
                CACPJ.RegistroActualCACPJ.tipo_relacion_persona3 = "controlling person"
            End If
            CACPJ.RegistroActualCACPJ.correo_electronico_persona3 = txtCorreoP3.Text
            CACPJ.RegistroActualCACPJ.nombre_persona_natural_persona3 = txtNomPNP3.Text
            CACPJ.RegistroActualCACPJ.porc_participacion_persona3 = txtPorPartP3.Text
            CACPJ.RegistroActualCACPJ.actividad_ocupacion1_persona3 = txtActOc1P3.Text
            CACPJ.RegistroActualCACPJ.actividad_ocupacion2_persona3 = txtActOc2P3.Text
            CACPJ.RegistroActualCACPJ.actividad_ocupacion3_persona3 = txtActOc3P3.Text
            CACPJ.RegistroActualCACPJ.actividad_ocupacion4_persona3 = txtActOc4P3.Text
            If chbxSIP3.Checked Then
                CACPJ.RegistroActualCACPJ.ocupa_agencia_persona3 = "si"
            ElseIf chbxNOP3.Checked Then
                CACPJ.RegistroActualCACPJ.ocupa_agencia_persona3 = "no"
            End If
            CACPJ.RegistroActualCACPJ.cargo_persona3 = txtCargoP3.Text
        End If
    End Sub

    Private Sub RellenarCampos()
        Dim reg = CACPJ.RegistroActualCACPJ
        If reg IsNot Nothing Then
            With reg
                ' --- Persona 1 ---
                txtTelefonoP1.Text = .telefono_persona1
                txtDomicilioP1.Text = .domicilio_persona1
                txtProfesionP1.Text = .profesion_actividad_persona1
                txtCorreoP1.Text = .correo_electronico_persona1
                txtNomPNP1.Text = .nombre_persona_natural_persona1
                txtPorPartP1.Text = .porc_participacion_persona1
                txtActOc1P1.Text = .actividad_ocupacion1_persona1
                txtActOc2P1.Text = .actividad_ocupacion2_persona1
                txtActOc3P1.Text = .actividad_ocupacion3_persona1
                txtActOc4P1.Text = .actividad_ocupacion4_persona1
                txtCargoP1.Text = .cargo_persona1

                ' Checkboxes Persona 1
                chbxRelacion1P1.Checked = (.tipo_relacion_persona1 = "socio/accionista")
                chbxRelacion2P1.Checked = (.tipo_relacion_persona1 = "representante legal")
                chbxRelacion3P1.Checked = (.tipo_relacion_persona1 = "controlling person")
                chbxSIP1.Checked = (.ocupa_agencia_persona1 = "si")
                chbxNOP1.Checked = (.ocupa_agencia_persona1 = "no")

                ' --- Persona 2 ---
                txtTelefonoP2.Text = .telefono_persona2
                txtDomicilioP2.Text = .domicilio_persona2
                txtProfesionP2.Text = .profesion_actividad_persona2
                txtCorreoP2.Text = .correo_electronico_persona2
                txtNomPNP2.Text = .nombre_persona_natural_persona2
                txtPorPartP2.Text = .porc_participacion_persona2
                txtActOc1P2.Text = .actividad_ocupacion1_persona2
                txtActOc2P2.Text = .actividad_ocupacion2_persona2
                txtActOc3P2.Text = .actividad_ocupacion3_persona2
                txtActOc4P2.Text = .actividad_ocupacion4_persona2
                txtCargoP2.Text = .cargo_persona2

                ' Checkboxes Persona 2
                chbxRelacion1P2.Checked = (.tipo_relacion_persona2 = "socio/accionista")
                chbxRelacion2P2.Checked = (.tipo_relacion_persona2 = "representante legal")
                chbxRelacion3P2.Checked = (.tipo_relacion_persona2 = "controlling person")
                chbxSIP2.Checked = (.ocupa_agencia_persona2 = "si")
                chbxNOP2.Checked = (.ocupa_agencia_persona2 = "no")

                ' --- Persona 3 ---
                txtTelefonoP3.Text = .telefono_persona3
                txtDomicilioP3.Text = .domicilio_persona3
                txtProfesionP3.Text = .profesion_actividad_persona3
                txtCorreoP3.Text = .correo_electronico_persona3
                txtNomPNP3.Text = .nombre_persona_natural_persona3
                txtPorPartP3.Text = .porc_participacion_persona3
                txtActOc1P3.Text = .actividad_ocupacion1_persona3
                txtActOc2P3.Text = .actividad_ocupacion2_persona3
                txtActOc3P3.Text = .actividad_ocupacion3_persona3
                txtActOc4P3.Text = .actividad_ocupacion4_persona3
                txtCargoP3.Text = .cargo_persona3

                ' Checkboxes Persona 3
                chbxRelacion1P3.Checked = (.tipo_relacion_persona3 = "socio/accionista")
                chbxRelacion2P3.Checked = (.tipo_relacion_persona3 = "representante legal")
                chbxRelacion3P3.Checked = (.tipo_relacion_persona3 = "controlling person")
                chbxSIP3.Checked = (.ocupa_agencia_persona3 = "si")
                chbxNOP3.Checked = (.ocupa_agencia_persona3 = "no")
            End With
        End If
    End Sub


    Private Sub chbxRelacion1P1_CheckedChanged(sender As Object, e As EventArgs) Handles chbxRelacion1P1.CheckedChanged
        If chbxRelacion1P1.Checked Then
            chbxRelacion2P1.Checked = False
            chbxRelacion3P1.Checked = False
        End If
    End Sub

    Private Sub chbxRelacion2P1_CheckedChanged(sender As Object, e As EventArgs) Handles chbxRelacion2P1.CheckedChanged
        If chbxRelacion2P1.Checked Then
            chbxRelacion1P1.Checked = False
            chbxRelacion3P1.Checked = False
        End If
    End Sub

    Private Sub chbxRelacion3P1_CheckedChanged(sender As Object, e As EventArgs) Handles chbxRelacion3P1.CheckedChanged
        If chbxRelacion3P1.Checked Then
            chbxRelacion2P1.Checked = False
            chbxRelacion1P1.Checked = False
        End If
    End Sub

    Private Sub chbxRelacion1P2_CheckedChanged(sender As Object, e As EventArgs) Handles chbxRelacion1P2.CheckedChanged
        If chbxRelacion1P2.Checked Then
            chbxRelacion2P2.Checked = False
            chbxRelacion3P2.Checked = False
        End If
    End Sub

    Private Sub chbxRelacion2P2_CheckedChanged(sender As Object, e As EventArgs) Handles chbxRelacion2P2.CheckedChanged
        If chbxRelacion2P2.Checked Then
            chbxRelacion1P2.Checked = False
            chbxRelacion3P2.Checked = False
        End If
    End Sub

    Private Sub chbxRelacion3P2_CheckedChanged(sender As Object, e As EventArgs) Handles chbxRelacion3P2.CheckedChanged
        If chbxRelacion3P2.Checked Then
            chbxRelacion2P2.Checked = False
            chbxRelacion1P2.Checked = False
        End If
    End Sub

    Private Sub chbxRelacion1P3_CheckedChanged(sender As Object, e As EventArgs) Handles chbxRelacion1P3.CheckedChanged
        If chbxRelacion1P3.Checked Then
            chbxRelacion2P3.Checked = False
            chbxRelacion3P3.Checked = False
        End If
    End Sub

    Private Sub chbxRelacion2P3_CheckedChanged(sender As Object, e As EventArgs) Handles chbxRelacion2P3.CheckedChanged
        If chbxRelacion2P3.Checked Then
            chbxRelacion1P3.Checked = False
            chbxRelacion3P3.Checked = False
        End If
    End Sub

    Private Sub chbxRelacion3P3_CheckedChanged(sender As Object, e As EventArgs) Handles chbxRelacion3P3.CheckedChanged
        If chbxRelacion3P3.Checked Then
            chbxRelacion2P3.Checked = False
            chbxRelacion1P3.Checked = False
        End If
    End Sub

    Private Sub chbxSIP1_CheckedChanged(sender As Object, e As EventArgs) Handles chbxSIP1.CheckedChanged
        If chbxSIP1.Checked Then
            chbxNOP1.Checked = False
        End If
    End Sub

    Private Sub chbxNOP1_CheckedChanged(sender As Object, e As EventArgs) Handles chbxNOP1.CheckedChanged
        If chbxNOP1.Checked Then
            chbxSIP1.Checked = False
        End If
    End Sub

    Private Sub chbxSIP2_CheckedChanged(sender As Object, e As EventArgs) Handles chbxSIP2.CheckedChanged
        If chbxSIP2.Checked Then
            chbxNOP2.Checked = False
        End If
    End Sub

    Private Sub chbxNOP2_CheckedChanged(sender As Object, e As EventArgs) Handles chbxNOP2.CheckedChanged
        If chbxNOP2.Checked Then
            chbxSIP2.Checked = False
        End If
    End Sub

    Private Sub chbxSIP3_CheckedChanged(sender As Object, e As EventArgs) Handles chbxSIP3.CheckedChanged
        If chbxSIP3.Checked Then
            chbxNOP3.Checked = False
        End If
    End Sub

    Private Sub chbxNOP3_CheckedChanged(sender As Object, e As EventArgs) Handles chbxNOP3.CheckedChanged
        If chbxNOP3.Checked Then
            chbxSIP3.Checked = False
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        anteriorForm.Show()
        Me.Close()
    End Sub
End Class