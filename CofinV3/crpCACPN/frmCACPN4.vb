Public Class frmCACPN4

    Private anteriorForm As Form

    Public nuevo = True

    Public Sub New(anterior As Form)
        InitializeComponent()
        anteriorForm = anterior
    End Sub

    Private Sub frmCACPN4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not nuevo Then
            rellenarcampos()
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click

        formCACPN5 = New frmCACPN5(Me)
        If Not nuevo Then
            formCACPN5.nuevo = False
        End If
        formCACPN5.show()
        Me.Hide()
    End Sub

    Private Sub RellenarCampos()
        Dim reg = CACPN.RegistroActualCACPN
        If reg IsNot Nothing Then
            With reg
                txtBanco1.Text = .banco1
                txtTipoCuenta1.Text = .tipo_cuenta1
                txtBanco2.Text = .banco2
                txtTipoCuenta2.Text = .tipo_cuenta2
                txtBanco3.Text = .banco3
                txtTipoCuenta3.Text = .tipo_cuenta3

                txtNomReferente1.Text = .nombre_referente1
                txtRefDireccion1.Text = .direccion1
                txtTelfReferente1.Text = .telefono1

                txtNomReferente2.Text = .nombre_referente2
                txtRefDireccion2.Text = .direccion2
                txtTelfReferente2.Text = .telefono2

                txtNomReferente3.Text = .nombre_referente3
                txtRefDireccion3.Text = .direccion3
                txtTelfReferente3.Text = .telefono3

                txtNomEmpresa1.Text = .nombre_empresa1
                txtNomEmpresa2.Text = .nombre_empresa2
                txtNomEmpresa3.Text = .nombre_empresa3

                txtDirEmpresa1.Text = .direccion_empresa1
                txtDirEmpresa2.Text = .direccion_empresa2
                txtDirEmpresa3.Text = .direccion_empresa3

                txtTelfEmpresa1.Text = .telefono_empresa1
                txtTelfEmpresa2.Text = .telefono_empresa2
                txtTelfEmpresa3.Text = .telefono_empresa3
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
        If String.IsNullOrWhiteSpace(txtBanco1.Text) Then
            MessageBox.Show("El campo de al menos un banco es obligatorio.", "Campo Requerido", MessageBoxButtons.OK)
            txtBanco1.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtTipoCuenta1.Text) Then
            MessageBox.Show("El campo de tipo de cuenta de al menos un banco es obligatorio.", "Campo Requerido", MessageBoxButtons.OK)
            txtTipoCuenta1.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtNomReferente1.Text) Then
            MessageBox.Show("El campo de nombre de al menos un referente es obligatorio.", "Campo Requerido", MessageBoxButtons.OK)
            txtNomReferente1.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtRefDireccion1.Text) Then
            MessageBox.Show("El campo de direccion de al menos un referente es obligatorio.", "Campo Requerido", MessageBoxButtons.OK)
            txtTipoCuenta1.Focus()
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtTelfReferente1.Text) Then
            MessageBox.Show("El campo de telefono de al menos un referente es obligatorio.", "Campo Requerido", MessageBoxButtons.OK)
            txtTelfReferente1.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub RegistrarDatos()
        With CACPN.RegistroActualCACPN
            .banco1 = txtBanco1.Text
            .tipo_cuenta1 = txtTipoCuenta1.Text
            .banco2 = txtBanco2.Text
            .tipo_cuenta2 = txtTipoCuenta2.Text
            .banco3 = txtBanco3.Text
            .tipo_cuenta3 = txtTipoCuenta3.Text

            .nombre_referente1 = txtNomReferente1.Text
            .direccion1 = txtRefDireccion1.Text
            .telefono1 = txtTelfReferente1.Text

            .nombre_referente2 = txtNomReferente2.Text
            .direccion2 = txtRefDireccion2.Text
            .telefono2 = txtTelfReferente2.Text

            .nombre_referente3 = txtNomReferente3.Text
            .direccion3 = txtRefDireccion3.Text
            .telefono3 = txtTelfReferente3.Text

            .nombre_empresa1 = txtNomEmpresa1.Text
            .nombre_empresa2 = txtNomEmpresa2.Text
            .nombre_empresa3 = txtNomEmpresa3.Text

            .direccion_empresa1 = txtDirEmpresa1.Text
            .direccion_empresa2 = txtDirEmpresa2.Text
            .direccion_empresa3 = txtDirEmpresa3.Text

            .telefono_empresa1 = txtTelfEmpresa1.Text
            .telefono_empresa2 = txtTelfEmpresa2.Text
            .telefono_empresa3 = txtTelfEmpresa3.Text
        End With
    End Sub
End Class