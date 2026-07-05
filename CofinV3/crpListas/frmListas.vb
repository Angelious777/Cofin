Imports System.IO
Imports System.Text
Imports iTextSharp.text.pdf.fonts

Public Class frmListas

    Private tipoLista As String

    Public Sub New(tipo As String)
        InitializeComponent()
        tipoLista = tipo
    End Sub

    Private Sub frmListaCACPN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = ""
        If tipoLista = "CACPN" Then
            lblTitulo.Text = "Lista de Formularios de Personas Naturales"
        ElseIf tipoLista = "CACPJ" Then
            lblTitulo.Text = "Lista de Formularios de Personas Juridicas"
        ElseIf tipoLista = "tarjeta" Then
            lblTitulo.Text = "Lista de Formularios de Tarjetas"
        End If
        Debug.WriteLine("CargarDatos() called in frmListaCACPN_Load - tipo: " & tipoLista)
        ConfigurarListView()
        CargarDatos()
    End Sub

    Private Sub ConfigurarListView()
        lstElementos.View = View.Details
        lstElementos.FullRowSelect = True
        lstElementos.GridLines = True

        lstElementos.Columns.Clear()

        If tipoLista = "CACPN" Then
            lstElementos.Columns.Add("ID del Cliente", 120)
            lstElementos.Columns.Add("Titular", 200)
            lstElementos.Columns.Add("Banco", 100)
        ElseIf tipoLista = "CACPJ" Then
            lstElementos.Columns.Add("ID cuenta", 120)
            lstElementos.Columns.Add("Razon Social", 200)
            lstElementos.Columns.Add("Banco", 100)
        ElseIf tipoLista = "tarjeta" Then
            lstElementos.Columns.Add("CI", 120)
            lstElementos.Columns.Add("Nombre", 200)
            lstElementos.Columns.Add("Nro de Tarjeta", 100)
            lstElementos.Columns.Add("Tipo de Tarjeta", 100)
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        If tipoLista = "CACPN" Then
            Dim resultado As DialogResult = MessageBox.Show(
             "¿Estás seguro de que deseas Limpiar la lista? Se mantendran 3 informes por defecto y las demas se borraran",
             "Confirmar",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
            )

            If resultado = DialogResult.Yes Then
                RestaurarDatosBaseCACPN()
            End If

        ElseIf tipoLista = "CACPJ" Then
            Dim resultado As DialogResult = MessageBox.Show(
             "¿Estás seguro de que deseas Limpiar la lista? Se mantendran 3 informes por defecto y las demas se borraran",
             "Confirmar",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
            )
            If resultado = DialogResult.Yes Then
                RestaurarDatosBaseCACPJ()
            End If

        ElseIf tipoLista = "tarjeta" Then
            Dim resultado As DialogResult = MessageBox.Show(
             "¿Estás seguro de que deseas Limpiar la lista? Se mantendran 4 informes por defecto y las demas se borraran",
             "Confirmar",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
            )

            If resultado = DialogResult.Yes Then
                RestaurarDatosBaseTarjeta()
            End If
        End If
    End Sub

    Private Sub CargarDatos()
        lstElementos.Items.Clear()

        If tipoLista = "CACPN" Then
            Dim listaCACPN As List(Of RegistroCACPN) = CargarDatosCACPN()

            For Each linea In listaCACPN
                Dim id As String = linea.ID_nro
                Dim titular As String = linea.datos_titular
                Dim nombreBanco As String = linea.nombre_banco
                If Not String.IsNullOrWhiteSpace(id) OrElse Not String.IsNullOrWhiteSpace(titular) Then
                    Dim item As New ListViewItem(id)
                    item.SubItems.Add(titular)
                    item.SubItems.Add(nombreBanco)
                    lstElementos.Items.Add(item)

                End If

            Next

        ElseIf tipoLista = "CACPJ" Then
            Dim listaCACPJ As List(Of registroCACPJ) = CargarDatosCACPJ()

            For Each linea In listaCACPJ
                Dim razonSocial As String = linea.id_razonsocial
                Dim nombreComercial As String = linea.id_nombrecomercial
                Dim nombreBanco As String = linea.nombre_banco

                If Not String.IsNullOrWhiteSpace(razonSocial) OrElse Not String.IsNullOrWhiteSpace(nombreComercial) Then
                    Dim item As New ListViewItem(razonSocial)
                    item.SubItems.Add(nombreComercial)
                    item.SubItems.Add(nombreBanco)
                    lstElementos.Items.Add(item)
                End If
            Next
        ElseIf tipoLista = "tarjeta" Then
            Dim listaTarjeta As List(Of registroTarjeta) = CargarDatosTarjeta()

            For Each linea In listaTarjeta
                Dim ci As String = linea.ci
                Dim nombre As String = linea.nombre
                Dim tarjeta As String = linea.tarjeta
                Dim tipo As String = linea.tipo

                If Not String.IsNullOrWhiteSpace(ci) OrElse Not String.IsNullOrWhiteSpace(nombre) Then
                    Dim item As New ListViewItem(ci)
                    item.SubItems.Add(nombre)
                    item.SubItems.Add(tarjeta)
                    item.SubItems.Add(tipo)
                    lstElementos.Items.Add(item)
                End If
            Next

        End If

        For Each col As ColumnHeader In lstElementos.Columns
            col.Width = -2
        Next
    End Sub

    Private Sub btnCerrar_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class