Imports System.IO

Public Class frmBuscarFormulario

    Dim rutaCACPN As String = Application.StartupPath & "\csv\Plataforma\BCP_cr_act_pers_natural.csv"
    Dim rutaCACPJ As String = Application.StartupPath & "\csv\Plataforma\BCP_cr_act_pers_juridica.csv"

    Dim nroID As String
    Dim verificador As Boolean = False
    Dim campo As String

    Private Sub frmBuscarFormulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxTipoCuenta.Items.Add("Formulario de persona natural")
        cbxTipoCuenta.Items.Add("Formulario de persona juridica")

        lblResultadoBusqueda.Text = ""

        If Not File.Exists(rutaCACPN) Then
            MessageBox.Show($"Archivo no encontrado en la ruta: {rutaCACPN}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Not File.Exists(rutaCACPJ) Then
            MessageBox.Show($"Archivo no encontrado en la ruta: {rutaCACPJ}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        CargarRegistrosDesdeCSVCACPN(rutaCACPN)
        CargarRegistrosDesdeCSVCACPJ(rutaCACPJ)
    End Sub

    ' === BOTÓN BUSCAR ===
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim idBuscado As String = txtBusqueda.Text.Trim

        If cbxTipoCuenta.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un tipo de formulario antes de buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        lblResultadoBusqueda.Text = ""
        verificador = False
        nroID = ""
        campo = ""

        If cbxTipoCuenta.SelectedItem.ToString() = "Formulario de persona natural" Then
            Dim encontradoCACPN = BuscarRegistroPorIDCACPN(idBuscado)
            If encontradoCACPN IsNot Nothing Then
                verificador = True
                campo = "CACPN"
                nroID = encontradoCACPN.ID_nro
                lblResultadoBusqueda.Text = $"Titular: {encontradoCACPN.datos_titular}" & Environment.NewLine &
                                            $"Correo: {encontradoCACPN.correo}" & Environment.NewLine &
                                            $"Teléfono: {encontradoCACPN.telefono_celular}"
            Else
                MessageBox.Show("No se encontró el ID en el formulario de persona natural.")
            End If

        ElseIf cbxTipoCuenta.SelectedItem.ToString() = "Formulario de persona juridica" Then
            Dim encontradoCACPJ = BuscarRegistroPorIDCACPJ(idBuscado)
            If encontradoCACPJ IsNot Nothing Then
                verificador = True
                campo = "CACPJ"
                nroID = encontradoCACPJ.id_razonsocial
                lblResultadoBusqueda.Text = $"Titular: {encontradoCACPJ.id_razonsocial}" & Environment.NewLine &
                                            $"Referencia: {encontradoCACPJ.id_referenciacomercial}" & Environment.NewLine &
                                            $"Teléfono: {encontradoCACPJ.id_telefonoempresa}"
            Else
                MessageBox.Show("No se encontró el ID en el formulario de persona jurídica.")
            End If
        End If
    End Sub

    Private Sub btnActualizarDatos_Click(sender As Object, e As EventArgs) Handles btnActualizarDatos.Click
        If Not verificador Then
            MessageBox.Show("Debe realizar una búsqueda válida antes de actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If cbxTipoCuenta.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un tipo de formulario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If campo = "CACPN" Then
            CACPN.RegistroActualCACPN = BuscarRegistroPorIDCACPN(nroID)
            Dim frm1 As New frmCACPN1()
            frm1.IDcarga = nroID
            frm1.Show()
            Me.Close()

        ElseIf campo = "CACPJ" Then
            CACPJ.RegistroActualCACPJ = BuscarRegistroPorIDCACPJ(nroID)
            Dim frm1 As New frmCACPJ1()
            frm1.nuevo = False
            frm1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnAlmacenados_Click(sender As Object, e As EventArgs) Handles btnAlmacenados.Click
        If cbxTipoCuenta.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un tipo de formulario antes de ver la lista.", "Aviso", MessageBoxButtons.OK)
            Exit Sub
        End If

        If cbxTipoCuenta.SelectedItem = "Formulario de persona natural" Then
            Dim listasFrm As New frmListas("CACPN")
            listasFrm.Show()
        ElseIf cbxTipoCuenta.SelectedItem = "Formulario de persona juridica" Then
            Dim listasFrm As New frmListas("CACPJ")
            listasFrm.Show()
        End If


    End Sub

End Class
