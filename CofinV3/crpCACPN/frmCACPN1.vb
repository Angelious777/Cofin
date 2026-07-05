
Imports System.IO

Public Class frmCACPN1

    Private checkedSeleccionado = False
    Public IDcarga As String

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click

        Dim existeRegistro As Boolean = CACPN.VerificarNuevoRegistroCACPN(txtNro.Text)

        If existeRegistro Then
            CargarDatosCACPN()
            MessageBox.Show("El registro ya existe.
                            Puedes actualizar el formulario del usuario o puedes cambiar el nro de identificacion",
                            "Registro Duplicado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub
        Else
            MessageBox.Show("Todo normal")
        End If

        If CamposNecesariosValidos() Then
            RegistrarDatos()

            Dim frmcacp2 As New frmCACPN2(Me)
            If Not String.IsNullOrEmpty(IDcarga) Then
                frmcacp2.nuevo = False
            End If

            frmcacp2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Campos Faltantes",
                            "Validación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
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
        If Not String.IsNullOrEmpty(IDcarga) Then
            Rellenarcampos(IDcarga)
        End If

        ' CARGAR IMAGEN DEL BANCO SELECCIONAO
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
    End Sub

    Private Sub Rellenarcampos(id As String)
        Dim reg = BuscarRegistroPorIDCACPN(id)
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

    Private Function CamposNecesariosValidos() As Boolean
        ' cantidad de campos necesarios para permitir ir al siguiente
        If checkedSeleccionado Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub RegistrarDatos()
        CACPN.RegistroActualCACPN.datos_titular = txtNombreTitular.Text
        CACPN.RegistroActualCACPN.ID_nro = txtNro.Text
        CACPN.RegistroActualCACPN.ID_ext = txtExtension.Text
        CACPN.RegistroActualCACPN.ID_tipo = txtTipo.Text
        CACPN.RegistroActualCACPN.ID_sexo = txtSexo.Text
        CACPN.RegistroActualCACPN.ID_fecnac = txtFecnac.Text
        CACPN.RegistroActualCACPN.ID_nacionalidad = txtNacionalidad.Text
        CACPN.RegistroActualCACPN.ID_2da_nacionalidad = txt2daNacionalidad.Text
        CACPN.RegistroActualCACPN.ID_residente = txtResidente.Text
        CACPN.RegistroActualCACPN.ID_pais_residencia = txtPaisResidencia.Text
        CACPN.RegistroActualCACPN.ID_pais_nacimiento = txtPaisNacimiento.Text
        If chbxEEUU1.Checked Then
            CACPN.RegistroActualCACPN.ID_EEUU = "Si"
        End If
        If chbxEEUU2.Checked Then
            CACPN.RegistroActualCACPN.ID_EEUU = "No"
        End If
        CACPN.RegistroActualCACPN.calle_av = txtCalleAv.Text
        CACPN.RegistroActualCACPN.numero_domicilio = txtNumDomicilio.Text
        CACPN.RegistroActualCACPN.calle_av2 = txtCalleAv2.Text
        CACPN.RegistroActualCACPN.departamento = txtDepartamento.Text
        CACPN.RegistroActualCACPN.provincia = txtProvincia.Text
        CACPN.RegistroActualCACPN.distrito = txtDistrito.Text
        CACPN.RegistroActualCACPN.telefono_fijo = txtTelFijo.Text
        CACPN.RegistroActualCACPN.telefono_celular = txtTelCel.Text
        CACPN.RegistroActualCACPN.correo = txtCorreo.Text
    End Sub
End Class