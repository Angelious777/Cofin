Public Class frmCACPJ3

    Public nuevo As Boolean = True
    Private anteriorForm As Form

    Public Sub New(anterior As Form)
        InitializeComponent()
        anteriorForm = anterior
    End Sub

    Private Sub frmCACPJ3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not nuevo Then
            RellenarCampos()
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If ValidarCampos() Then
            RegistrarDatos()
            Dim frmcacj4 As New frmCACPJ4(Me)
            If Not nuevo Then
                frmcacj4.nuevo = False
            End If
            frmcacj4.Show()
            Me.Hide()
        Else
            MessageBox.Show("campos faltantes")
        End If

        'Dim frmcacj4 As New frmCACPJ4(Me)
        'frmcacj4.Show()
    End Sub

    Private Function ValidarCampos()
        Return True
    End Function

    Private Sub RegistrarDatos()
        ' --- Grupo Persona 1 ---
        If Not String.IsNullOrWhiteSpace(CACPJ.RegistroActualCACPJ.nombre_razon_persona1) Then
            CACPJ.RegistroActualCACPJ.fecha_ingreso_persona1 = txtFechaIngresoP1.Text
            CACPJ.RegistroActualCACPJ.ingreso_mensual_persona1 = txtIngresoMensualP1.Text
            CACPJ.RegistroActualCACPJ.estado_civil_persona1 = txtEstadoCivilP1.Text
            CACPJ.RegistroActualCACPJ.referencias_personales_persona1 = txtReferenciaP1.Text
            If chbxResidente1P1.Checked Then
                CACPJ.RegistroActualCACPJ.residente_bolivia_persona1 = "si"
            ElseIf chbxResidente2P1.Checked Then
                CACPJ.RegistroActualCACPJ.residente_bolivia_persona1 = "no"
            End If
            CACPJ.RegistroActualCACPJ.pais_residencia_persona1 = txtPaisResidenciaP1.Text
            If chbxEEUU1P1.Checked Then
                CACPJ.RegistroActualCACPJ.nacio_eeuu_persona1 = "si"
            ElseIf chbxEEUU2P1.Checked Then
                CACPJ.RegistroActualCACPJ.nacio_eeuu_persona1 = "no"
            End If
        End If

        ' --- Grupo Persona 2 ---
        If Not String.IsNullOrWhiteSpace(CACPJ.RegistroActualCACPJ.nombre_razon_persona2) Then
            CACPJ.RegistroActualCACPJ.fecha_ingreso_persona2 = txtFechaIngresoP2.Text
            CACPJ.RegistroActualCACPJ.ingreso_mensual_persona2 = txtIngresoMensualP2.Text
            CACPJ.RegistroActualCACPJ.estado_civil_persona2 = txtEstadoCivilP2.Text
            CACPJ.RegistroActualCACPJ.referencias_personales_persona2 = txtReferenciaP2.Text
            If chbxResidente1P2.Checked Then
                CACPJ.RegistroActualCACPJ.residente_bolivia_persona2 = "si"
            ElseIf chbxResidente2P2.Checked Then
                CACPJ.RegistroActualCACPJ.residente_bolivia_persona2 = "no"
            End If
            CACPJ.RegistroActualCACPJ.pais_residencia_persona2 = txtPaisResidenciaP2.Text
            If chbxEEUU1P2.Checked Then
                CACPJ.RegistroActualCACPJ.nacio_eeuu_persona2 = "si"
            ElseIf chbxEEUU2P2.Checked Then
                CACPJ.RegistroActualCACPJ.nacio_eeuu_persona2 = "no"
            End If
        End If

        ' --- Grupo Persona 3 ---
        If Not String.IsNullOrWhiteSpace(CACPJ.RegistroActualCACPJ.nombre_razon_persona3) Then
            CACPJ.RegistroActualCACPJ.fecha_ingreso_persona3 = txtFechaIngresoP3.Text
            CACPJ.RegistroActualCACPJ.ingreso_mensual_persona3 = txtIngresoMensualP3.Text
            CACPJ.RegistroActualCACPJ.estado_civil_persona3 = txtEstadoCivilP3.Text
            CACPJ.RegistroActualCACPJ.referencias_personales_persona3 = txtReferenciaP3.Text
            If chbxResidente1P3.Checked Then
                CACPJ.RegistroActualCACPJ.residente_bolivia_persona3 = "si"
            ElseIf chbxResidente2P3.Checked Then
                CACPJ.RegistroActualCACPJ.residente_bolivia_persona3 = "no"
            End If
            CACPJ.RegistroActualCACPJ.pais_residencia_persona3 = txtPaisResidenciaP3.Text
            If chbxEEUU1P3.Checked Then
                CACPJ.RegistroActualCACPJ.nacio_eeuu_persona3 = "si"
            ElseIf chbxEEUU2P3.Checked Then
                CACPJ.RegistroActualCACPJ.nacio_eeuu_persona3 = "no"
            End If
        End If
    End Sub

    Private Sub RellenarCampos()
        Dim reg = CACPJ.RegistroActualCACPJ
        If reg IsNot Nothing Then
            With reg
                ' --- Persona 1 ---
                txtFechaIngresoP1.Text = .fecha_ingreso_persona1
                txtIngresoMensualP1.Text = .ingreso_mensual_persona1
                txtEstadoCivilP1.Text = .estado_civil_persona1
                txtReferenciaP1.Text = .referencias_personales_persona1
                chbxResidente1P1.Checked = (.residente_bolivia_persona1 = "si")
                chbxResidente2P1.Checked = (.residente_bolivia_persona1 = "no")
                txtPaisResidenciaP1.Text = .pais_residencia_persona1
                chbxEEUU1P1.Checked = (.nacio_eeuu_persona1 = "si")
                chbxEEUU2P1.Checked = (.nacio_eeuu_persona1 = "no")

                ' --- Persona 2 ---
                txtFechaIngresoP2.Text = .fecha_ingreso_persona2
                txtIngresoMensualP2.Text = .ingreso_mensual_persona2
                txtEstadoCivilP2.Text = .estado_civil_persona2
                txtReferenciaP2.Text = .referencias_personales_persona2
                chbxResidente1P2.Checked = (.residente_bolivia_persona2 = "si")
                chbxResidente2P2.Checked = (.residente_bolivia_persona2 = "no")
                txtPaisResidenciaP2.Text = .pais_residencia_persona2
                chbxEEUU1P2.Checked = (.nacio_eeuu_persona2 = "si")
                chbxEEUU2P2.Checked = (.nacio_eeuu_persona2 = "no")

                ' --- Persona 3 ---
                txtFechaIngresoP3.Text = .fecha_ingreso_persona3
                txtIngresoMensualP3.Text = .ingreso_mensual_persona3
                txtEstadoCivilP3.Text = .estado_civil_persona3
                txtReferenciaP3.Text = .referencias_personales_persona3
                chbxResidente1P3.Checked = (.residente_bolivia_persona3 = "si")
                chbxResidente2P3.Checked = (.residente_bolivia_persona3 = "no")
                txtPaisResidenciaP3.Text = .pais_residencia_persona3
                chbxEEUU1P3.Checked = (.nacio_eeuu_persona3 = "si")
                chbxEEUU2P3.Checked = (.nacio_eeuu_persona3 = "no")
            End With
        Else
            MessageBox.Show("No se encontró ningún registro para rellenar los campos.")
        End If
    End Sub


    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        anteriorForm.Show()
        Me.Close()
    End Sub

    Private Sub chbxResidente1P1_CheckedChanged(sender As Object, e As EventArgs) Handles chbxResidente1P1.CheckedChanged
        If chbxResidente1P1.Checked Then
            chbxResidente2P1.Checked = False
        End If
    End Sub

    Private Sub chbxResidente2P1_CheckedChanged(sender As Object, e As EventArgs) Handles chbxResidente2P1.CheckedChanged
        If chbxResidente2P1.Checked Then
            chbxResidente1P1.Checked = False
        End If
    End Sub

    Private Sub chbxResidente1P2_CheckedChanged(sender As Object, e As EventArgs) Handles chbxResidente1P2.CheckedChanged
        If chbxResidente1P2.Checked Then
            chbxResidente2P2.Checked = False
        End If
    End Sub

    Private Sub chbxResidente2P2_CheckedChanged(sender As Object, e As EventArgs) Handles chbxResidente2P2.CheckedChanged
        If chbxResidente2P2.Checked Then
            chbxResidente1P2.Checked = False
        End If
    End Sub

    Private Sub chbxResidente1P3_CheckedChanged(sender As Object, e As EventArgs) Handles chbxResidente1P3.CheckedChanged
        If chbxResidente1P3.Checked Then
            chbxResidente2P3.Checked = False
        End If
    End Sub

    Private Sub chbxResidente2P3_CheckedChanged(sender As Object, e As EventArgs) Handles chbxResidente2P3.CheckedChanged
        If chbxResidente2P3.Checked Then
            chbxResidente1P3.Checked = False
        End If
    End Sub

    Private Sub chbxEEUU1P1_CheckedChanged(sender As Object, e As EventArgs) Handles chbxEEUU1P1.CheckedChanged
        If chbxEEUU1P1.Checked Then
            chbxEEUU2P1.Checked = False
        End If
    End Sub

    Private Sub chbxEEUU2P1_CheckedChanged(sender As Object, e As EventArgs) Handles chbxEEUU2P1.CheckedChanged
        If chbxEEUU2P1.Checked Then
            chbxEEUU1P1.Checked = False
        End If
    End Sub

    Private Sub chbxEEUU1P2_CheckedChanged(sender As Object, e As EventArgs) Handles chbxEEUU1P2.CheckedChanged
        If chbxEEUU1P2.Checked Then
            chbxEEUU2P2.Checked = False
        End If
    End Sub

    Private Sub chbxEEUU2P2_CheckedChanged(sender As Object, e As EventArgs) Handles chbxEEUU2P2.CheckedChanged
        If chbxEEUU2P2.Checked Then
            chbxEEUU1P2.Checked = False
        End If
    End Sub

    Private Sub chbxEEUU1P3_CheckedChanged(sender As Object, e As EventArgs) Handles chbxEEUU1P3.CheckedChanged
        If chbxEEUU1P3.Checked Then
            chbxEEUU2P3.Checked = False
        End If
    End Sub

    Private Sub chbxEEUU2P3_CheckedChanged(sender As Object, e As EventArgs) Handles chbxEEUU2P3.CheckedChanged
        If chbxEEUU2P3.Checked Then
            chbxEEUU1P3.Checked = False
        End If
    End Sub


End Class