Imports System.IO

Public Class frmCACPJ1

    Public nuevo As Boolean = True

    Private Sub frmCACPJ1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If nuevo Then
            ' CARGAR IMAGEN DEL BANCO SELECCIONAO
            Dim nombreBanco As String = CACPJ.RegistroActualCACPJ.nombre_banco
            Dim rutaImagen As String = String.Empty

            If nombreBanco = "BCP" Then
                rutaImagen = Path.Combine(Application.StartupPath, "img\iconos", "bcp_logo2.png")
            End If
            If nombreBanco = "BISA" Then
                rutaImagen = Path.Combine(Application.StartupPath, "img\iconos", "banco_bisa.png")
            End If
            If nombreBanco = "ECONOMICO" Then
                rutaImagen = Path.Combine(Application.StartupPath, "img\iconos", "banco_economico.png")
            End If


            If Not String.IsNullOrEmpty(rutaImagen) AndAlso IO.File.Exists(rutaImagen) Then
                pctbxImagenBanco.Image = Image.FromFile(rutaImagen)
            Else
                MessageBox.Show("No se encontró el logo del banco: " & nombreBanco)
            End If
        Else
            RellenarCampos()
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        If ValidarCampos() Then
            RegistrarDatos()

            Dim frmcacpj2 As New frmCACPJ2(Me)
            If Not nuevo Then
                frmcacpj2.nuevo = False
            End If
            frmcacpj2.Show()
            Me.Hide()

            'Dim frmcacj2 As New frmCACPJ2(Me)
            'frmcacj2.Show()
        Else
            MessageBox.Show("Campos Faltantes")
        End If
    End Sub

    Private Function ValidarCampos() As Boolean

        Dim valido As Boolean = True

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

        ' comprobar si los campos importantes estan llenos y retorar true/false
        If chbxSucursal1.Checked Then
            Return Not String.IsNullOrWhiteSpace(txtNombreSucursal.Text) AndAlso Not String.IsNullOrWhiteSpace(txtDireccionSucursal.Text)
        End If

        If chbxSucursal2.Checked Then
            Return True
        End If

        Return valido
    End Function

    Private Function validarP1() As Boolean
        'If String.IsNullOrWhiteSpace(txtTelefonoP1.Text) Then Return False
        'If String.IsNullOrWhiteSpace(txtDomicilioP1.Text) Then Return False
        'If String.IsNullOrWhiteSpace(txtProfesionP1.Text) Then Return False

        Return True
    End Function

    Private Function validarP2() As Boolean
        'If String.IsNullOrWhiteSpace(CACPJ.RegistroActualCACPJ.telefono_persona2) Then Return False
        'If String.IsNullOrWhiteSpace(CACPJ.RegistroActualCACPJ.domicilio_persona2) Then Return False
        '' agrega más campos obligatorios del grupo 2 aquí...
        Return True
    End Function

    Private Function validarP3() As Boolean
        'If String.IsNullOrWhiteSpace(CACPJ.RegistroActualCACPJ.telefono_persona3) Then Return False
        'If String.IsNullOrWhiteSpace(CACPJ.RegistroActualCACPJ.domicilio_persona3) Then Return False
        '' agrega más campos obligatorios del grupo 3 aquí...
        Return True
    End Function

    Private Sub RegistrarDatos()
        ' agarrrar todos los txt y almacenarlos en las variables del modulo 
        CACPJ.RegistroActualCACPJ.id_razonsocial = txtRazonSocial.Text
        CACPJ.RegistroActualCACPJ.id_nombrecomercial = txtNombreComercial.Text
        CACPJ.RegistroActualCACPJ.id_telefonoempresa = txtTelefonoEmpresa.Text
        CACPJ.RegistroActualCACPJ.id_referenciacomercial = txtReferenciaComercial.Text
        If chbxSucursal1.Checked Then
            CACPJ.RegistroActualCACPJ.tiene_sucursal = "SI"
        End If
        If chbxSucursal2.Checked Then
            CACPJ.RegistroActualCACPJ.tiene_sucursal = "NO"
        End If
        CACPJ.RegistroActualCACPJ.id_nombresucursal = txtNombreSucursal.Text
        CACPJ.RegistroActualCACPJ.id_direccionsucursal = txtDireccionSucursal.Text

        CACPJ.RegistroActualCACPJ.nombre_razon_persona1 = txtNombreRazonP1.Text
        CACPJ.RegistroActualCACPJ.nombre_razon_persona2 = txtNombreRazonP2.Text
        CACPJ.RegistroActualCACPJ.nombre_razon_persona3 = txtNombreRazonP3.Text

        CACPJ.RegistroActualCACPJ.fecnac_constitucion_persona1 = txtFecnacP1.Text
        CACPJ.RegistroActualCACPJ.fecnac_constitucion_persona2 = txtFecnacP2.Text
        CACPJ.RegistroActualCACPJ.fecnac_constitucion_persona3 = txtFecnacP3.Text

        CACPJ.RegistroActualCACPJ.lugar_nacimiento_persona1 = txtLugarNacP1.Text
        CACPJ.RegistroActualCACPJ.lugar_nacimiento_persona2 = txtLugarNacP2.Text
        CACPJ.RegistroActualCACPJ.lugar_nacimiento_persona3 = txtLugarNacP3.Text

        CACPJ.RegistroActualCACPJ.documento_identidad_persona1 = txtDocIdentP1.Text
        CACPJ.RegistroActualCACPJ.documento_identidad_persona2 = txtDocIdentP2.Text
        CACPJ.RegistroActualCACPJ.documento_identidad_persona3 = txtDocIdentP3.Text

        CACPJ.RegistroActualCACPJ.lugar_emision_persona1 = txtLugEmisionP1.Text
        CACPJ.RegistroActualCACPJ.lugar_emision_persona2 = txtLugEmisionP2.Text
        CACPJ.RegistroActualCACPJ.lugar_emision_persona3 = txtLugEmisionP3.Text

        CACPJ.RegistroActualCACPJ.numero_matricula_persona1 = txtNumMatrP1.Text
        CACPJ.RegistroActualCACPJ.numero_matricula_persona2 = txtNumMatrP2.Text
        CACPJ.RegistroActualCACPJ.numero_matricula_persona3 = txtNumMatrP3.Text

        CACPJ.RegistroActualCACPJ.nacionalidad_persona1 = txtNacP1.Text
        CACPJ.RegistroActualCACPJ.nacionalidad_persona2 = txtNacP2.Text
        CACPJ.RegistroActualCACPJ.nacionalidad_persona3 = txtNacP3.Text

        CACPJ.RegistroActualCACPJ.segunda_nacionalidad_persona1 = txtSegNacP1.Text
        CACPJ.RegistroActualCACPJ.segunda_nacionalidad_persona2 = txtSegNacP2.Text
        CACPJ.RegistroActualCACPJ.segunda_nacionalidad_persona3 = txtSegNacP3.Text
    End Sub

    Private Sub chbxSucursal1_CheckedChanged(sender As Object, e As EventArgs) Handles chbxSucursal1.CheckedChanged
        If chbxSucursal1.Checked Then chbxSucursal2.Checked = False
    End Sub

    Private Sub chbxSucursal2_CheckedChanged(sender As Object, e As EventArgs) Handles chbxSucursal2.CheckedChanged
        If chbxSucursal2.Checked Then chbxSucursal1.Checked = False
    End Sub

    Private Sub RellenarCampos()
        Dim reg = CACPJ.RegistroActualCACPJ
        If reg IsNot Nothing Then
            With reg
                ' --- Datos de la empresa ---
                txtRazonSocial.Text = .id_razonsocial
                txtNombreComercial.Text = .id_nombrecomercial
                txtTelefonoEmpresa.Text = .id_telefonoempresa
                txtReferenciaComercial.Text = .id_referenciacomercial

                ' --- Sucursal ---
                chbxSucursal1.Checked = (.tiene_sucursal = "SI")
                chbxSucursal2.Checked = (.tiene_sucursal = "NO")
                txtNombreSucursal.Text = .id_nombresucursal
                txtDireccionSucursal.Text = .id_direccionsucursal

                ' --- Persona 1 ---
                txtNombreRazonP1.Text = .nombre_razon_persona1
                txtFecnacP1.Text = .fecnac_constitucion_persona1
                txtLugarNacP1.Text = .lugar_nacimiento_persona1
                txtDocIdentP1.Text = .documento_identidad_persona1
                txtLugEmisionP1.Text = .lugar_emision_persona1
                txtNumMatrP1.Text = .numero_matricula_persona1
                txtNacP1.Text = .nacionalidad_persona1
                txtSegNacP1.Text = .segunda_nacionalidad_persona1

                ' --- Persona 2 ---
                txtNombreRazonP2.Text = .nombre_razon_persona2
                txtFecnacP2.Text = .fecnac_constitucion_persona2
                txtLugarNacP2.Text = .lugar_nacimiento_persona2
                txtDocIdentP2.Text = .documento_identidad_persona2
                txtLugEmisionP2.Text = .lugar_emision_persona2
                txtNumMatrP2.Text = .numero_matricula_persona2
                txtNacP2.Text = .nacionalidad_persona2
                txtSegNacP2.Text = .segunda_nacionalidad_persona2

                ' --- Persona 3 ---
                txtNombreRazonP3.Text = .nombre_razon_persona3
                txtFecnacP3.Text = .fecnac_constitucion_persona3
                txtLugarNacP3.Text = .lugar_nacimiento_persona3
                txtDocIdentP3.Text = .documento_identidad_persona3
                txtLugEmisionP3.Text = .lugar_emision_persona3
                txtNumMatrP3.Text = .numero_matricula_persona3
                txtNacP3.Text = .nacionalidad_persona3
                txtSegNacP3.Text = .segunda_nacionalidad_persona3

                ' --- Logo del banco (opcional, igual que en Load) ---
                Dim nombreBanco As String = .nombre_banco
                Dim rutaImagen As String = String.Empty

                If nombreBanco = "BCP" Then
                    rutaImagen = Path.Combine(Application.StartupPath, "img\iconos", "bcp_logo2.png")
                ElseIf nombreBanco = "BISA" Then
                    rutaImagen = Path.Combine(Application.StartupPath, "img\iconos", "banco_bisa.png")
                ElseIf nombreBanco = "ECONOMICO" Then
                    rutaImagen = Path.Combine(Application.StartupPath, "img\iconos", "banco_economico.png")
                End If

                If Not String.IsNullOrEmpty(rutaImagen) AndAlso File.Exists(rutaImagen) Then
                    pctbxImagenBanco.Image = Image.FromFile(rutaImagen)
                End If
            End With
        Else
            MessageBox.Show("No se encontró ningún registro para rellenar los campos.")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim resultado As DialogResult = MessageBox.Show(
             "¿Estás seguro de que deseas cerrar este formulario?",
             "Confirmar salida",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
            )

        If resultado = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class