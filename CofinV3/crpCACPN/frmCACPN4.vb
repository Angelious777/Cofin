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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CACPN.RegistroActualCACPN.banco1 = txtBanco1.Text
        CACPN.RegistroActualCACPN.tipo_cuenta1 = txtTipoCuenta1.Text
        CACPN.RegistroActualCACPN.banco2 = txtBanco2.Text
        CACPN.RegistroActualCACPN.tipo_cuenta2 = txtTipoCuenta2.Text
        CACPN.RegistroActualCACPN.banco3 = txtBanco3.Text
        CACPN.RegistroActualCACPN.tipo_cuenta3 = txtTipoCuenta3.Text

        CACPN.RegistroActualCACPN.nombre_referente1 = txtNomReferente1.Text
        CACPN.RegistroActualCACPN.direccion1 = txtRefDireccion1.Text
        CACPN.RegistroActualCACPN.telefono1 = txtTelfReferente1.Text

        CACPN.RegistroActualCACPN.nombre_referente2 = txtNomReferente2.Text
        CACPN.RegistroActualCACPN.direccion2 = txtRefDireccion2.Text
        CACPN.RegistroActualCACPN.telefono2 = txtTelfReferente2.Text

        CACPN.RegistroActualCACPN.nombre_referente3 = txtNomReferente3.Text
        CACPN.RegistroActualCACPN.direccion3 = txtRefDireccion3.Text
        CACPN.RegistroActualCACPN.telefono3 = txtTelfReferente3.Text

        CACPN.RegistroActualCACPN.nombre_empresa1 = txtNomEmpresa1.Text
        CACPN.RegistroActualCACPN.nombre_empresa2 = txtNomEmpresa2.Text
        CACPN.RegistroActualCACPN.nombre_empresa3 = txtNomEmpresa3.Text

        CACPN.RegistroActualCACPN.direccion_empresa1 = txtDirEmpresa1.Text
        CACPN.RegistroActualCACPN.direccion_empresa2 = txtDirEmpresa2.Text
        CACPN.RegistroActualCACPN.direccion_empresa3 = txtDirEmpresa3.Text

        CACPN.RegistroActualCACPN.telefono_empresa1 = txtTelfEmpresa1.Text
        CACPN.RegistroActualCACPN.telefono_empresa2 = txtTelfEmpresa2.Text
        CACPN.RegistroActualCACPN.telefono_empresa3 = txtTelfEmpresa3.Text

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
End Class