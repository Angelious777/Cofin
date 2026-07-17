
Imports System.IO

Public Class frmCACPN1

    Private checkedSeleccionado = False

    Public nuevo As Boolean = True

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click

        Dim existeRegistro As Boolean = CACPN.VerificarNuevoRegistroCACPN(txtNro.Text)

        If existeRegistro Then
            MessageBox.Show("El registro ya existe.

Puedes actualizar el formulario del usuario o puedes cambiar el nro de identificacion",
            "Registro Duplicado",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)

            Exit Sub
        End If

        If ValidarCampos() Then
            RegistrarDatos()

            Dim frmcacp2 As New frmCACPN2(Me)
            If Not nuevo Then
                frmcacp2.nuevo = False
            End If

            frmcacp2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub chbxEEUU1_CheckedChanged(sender As Object, e As EventArgs) Handles chbxEEUU1.CheckedChanged
        If chbxEEUU1.Checked Then
            chbxEEUU2.Checked = False
            checkedSeleccionado = True
        ElseIf Not chbxEEUU2.Checked Then
            checkedSeleccionado = False
        End If
    End Sub

    Private Sub chbxEEUU2_CheckedChanged(sender As Object, e As EventArgs) Handles chbxEEUU2.CheckedChanged
        If chbxEEUU2.Checked Then
            chbxEEUU1.Checked = False
            checkedSeleccionado = True
        ElseIf Not chbxEEUU1.Checked Then
            checkedSeleccionado = False
        End If
    End Sub

    Private Sub frmCACPN1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not nuevo Then
            Rellenarcampos()
        End If

        ' CARGAR IMAGEN DEL BANCO SELECCIONADO
        Dim nombreBanco As String = CACPN.RegistroActualCACPN.nombre_banco
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

        CargarDatosCACPN()
    End Sub

    Private Sub Rellenarcampos()
        Dim reg = CACPN.RegistroActualCACPN
        If reg IsNot Nothing Then
            With reg
                txtNombreTitular.Text = .datos_titular
                txtNro.Text = .ID_nro
                txtExtension.Text = .ID_ext
                txtTipo.Text = .ID_tipo
                txtSexo.Text = .ID_sexo
                txtFecnac.Text = .ID_fecnac
                txtNacionalidad.Text = .ID_nacionalidad
                txt2daNacionalidad.Text = .ID_2da_nacionalidad
                txtResidente.Text = .ID_residente
                txtPaisResidencia.Text = .ID_pais_residencia
                txtPaisNacimiento.Text = .ID_pais_nacimiento

                chbxEEUU1.Checked = (.ID_EEUU = "Si")
                chbxEEUU2.Checked = (.ID_EEUU = "No")

                txtCalleAv.Text = .calle_av
                txtCalleAv2.Text = .calle_av2
                txtNumDomicilio.Text = .numero_domicilio
                txtDepartamento.Text = .departamento
                txtProvincia.Text = .provincia
                txtDistrito.Text = .distrito
                txtTelFijo.Text = .telefono_fijo
                txtTelCel.Text = .telefono_celular
                txtCorreo.Text = .correo
            End With
        End If

        checkedSeleccionado = chbxEEUU1.Checked Or chbxEEUU2.Checked
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

    Private Function ValidarCampos() As Boolean

        If String.IsNullOrWhiteSpace(txtNombreTitular.Text) Then
            MessageBox.Show("El nombre de titular es obligatorio.", "Campo Requerido", MessageBoxButtons.OK)
            txtNombreTitular.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtNro.Text) Then
            MessageBox.Show("El Nro de Identidad es obligatorio", "Campo Requerido", MessageBoxButtons.OK)
            txtNro.Focus()
            Return False
        End If
        If Not checkedSeleccionado Then
            MessageBox.Show("Seleccione la casilla de residencia de EEUU.", "Campo Requerido", MessageBoxButtons.OK)
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtCalleAv.Text) Then
            MessageBox.Show("La Direccion de Calle o Avenida es obligatorio.", "Campo Requerido", MessageBoxButtons.OK)
            txtCalleAv.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtNumDomicilio.Text) Then
            MessageBox.Show("El número de domicilio es obligatorio.", "Campo Requerido", MessageBoxButtons.OK)
            txtNumDomicilio.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtCorreo.Text) Then
            MessageBox.Show("El correo electrónico es obligatorio.", "Campo Requerido", MessageBoxButtons.OK)
            txtCorreo.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub RegistrarDatos()
        With CACPN.RegistroActualCACPN
            .datos_titular = txtNombreTitular.Text
            .ID_nro = txtNro.Text
            .ID_ext = txtExtension.Text
            .ID_tipo = txtTipo.Text
            .ID_sexo = txtSexo.Text
            .ID_fecnac = txtFecnac.Text
            .ID_nacionalidad = txtNacionalidad.Text
            .ID_2da_nacionalidad = txt2daNacionalidad.Text
            .ID_residente = txtResidente.Text
            .ID_pais_residencia = txtPaisResidencia.Text
            .ID_pais_nacimiento = txtPaisNacimiento.Text

            If chbxEEUU1.Checked Then
                .ID_EEUU = "Si"
            End If
            If chbxEEUU2.Checked Then
                .ID_EEUU = "No"
            End If

            .calle_av = txtCalleAv.Text
            .numero_domicilio = txtNumDomicilio.Text
            .calle_av2 = txtCalleAv2.Text
            .departamento = txtDepartamento.Text
            .provincia = txtProvincia.Text
            .distrito = txtDistrito.Text
            .telefono_fijo = txtTelFijo.Text
            .telefono_celular = txtTelCel.Text
            .correo = txtCorreo.Text
        End With
    End Sub
End Class