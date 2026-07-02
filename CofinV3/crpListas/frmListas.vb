Imports System.IO
Imports System.Text

Public Class frmListas

    Private tipoLista As String

    Public Sub New(persona As String)
        InitializeComponent()
        tipoLista = persona
    End Sub

    Private Sub frmListaCACPN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = ""
        If tipoLista = "CACPN" Then
            lblTitulo.Text = "Lista de Formularios de Personas Naturales"
            ConfigurarListView()
            CargarDatosDesdeCSV("csv/Plataforma/BCP_cr_act_pers_natural.csv")
        ElseIf tipoLista = "CACPJ" Then
            lblTitulo.Text = "Lista de Formularios de Personas Juridicas"
            ConfigurarListView()
            CargarDatosDesdeCSV("csv/Plataforma/BCP_cr_act_pers_juridica.csv")
        ElseIf tipoLista = "tarjeta" Then
            lblTitulo.Text = "Lista de Formularios de Tarjetas"
            ConfigurarListView()
            CargarDatosDesdeCSV("csv/Plataforma/Tarjeta.csv")
        End If
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

    Private Sub CargarDatosDesdeCSV(rutaArchivo As String)
        Try
            lstElementos.Items.Clear()

            Dim rutaCompleta As String = Path.Combine(Application.StartupPath, rutaArchivo)

            If Not File.Exists(rutaCompleta) Then
                MessageBox.Show("No se encontró el archivo: " & rutaCompleta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim lineas As String() = File.ReadAllLines(rutaCompleta, Encoding.UTF8)

            For i As Integer = 1 To lineas.Length - 1
                Dim campos As String() = lineas(i).Split(","c)

                If tipoLista = "CACPN" Then
                    Dim idNumero As String = If(campos.Length > 1, campos(1).Trim(), "")
                    Dim datosTitular As String = If(campos.Length > 0, campos(0).Trim(), "")
                    Dim nombreBanco As String = If(campos.Length > 93, campos(93).Trim(), "Sin dato")

                    If Not String.IsNullOrWhiteSpace(idNumero) OrElse Not String.IsNullOrWhiteSpace(datosTitular) Then
                        Dim item As New ListViewItem(idNumero)
                        item.SubItems.Add(datosTitular)
                        item.SubItems.Add(nombreBanco)
                        lstElementos.Items.Add(item)
                    End If
                ElseIf tipoLista = "CACPJ" Then
                    Dim razonSocial As String = If(campos.Length > 0, campos(0).Trim(), "")
                    Dim nombreComercial As String = If(campos.Length > 1, campos(1).Trim(), "")
                    Dim nombreBanco As String = If(campos.Length > 103, campos(103).Trim(), "Sin dato")

                    If Not String.IsNullOrWhiteSpace(razonSocial) OrElse Not String.IsNullOrWhiteSpace(nombreComercial) Then
                        Dim item As New ListViewItem(razonSocial)
                        item.SubItems.Add(nombreComercial)
                        item.SubItems.Add(nombreBanco)
                        lstElementos.Items.Add(item)
                    End If
                ElseIf tipoLista = "tarjeta" Then
                    Dim ciTarjeta As String = If(campos.Length > 0, campos(0).Trim(), "")
                    Dim nombreTarjeta As String = If(campos.Length > 1, campos(1).Trim(), "")
                    Dim tarjeta As String = If(campos.Length > 2, campos(2).Trim(), "")
                    Dim tipoTarjeta As String = If(campos.Length > 3, campos(3).Trim(), "")

                    If Not String.IsNullOrWhiteSpace(ciTarjeta) OrElse Not String.IsNullOrWhiteSpace(nombreTarjeta) Then
                        Dim item As New ListViewItem(ciTarjeta)
                        item.SubItems.Add(nombreTarjeta)
                        item.SubItems.Add(tarjeta)
                        item.SubItems.Add(tipoTarjeta)
                        lstElementos.Items.Add(item)
                    End If
                End If

            Next

            For Each col As ColumnHeader In lstElementos.Columns
                col.Width = -2
            Next
        Catch ex As Exception
            MessageBox.Show("Error al leer el CSV: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
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
                Try
                    Dim rutaPrincipal As String = Path.Combine(Application.StartupPath, "csv/Plataforma/BCP_cr_act_pers_natural.csv")
                    Dim rutaBase As String = Path.Combine(Application.StartupPath, "csv/Plataforma/Bases/BCP_cr_act_pers_natural_Base.csv")

                    If Not File.Exists(rutaBase) Then
                        MessageBox.Show("No se encontró el archivo base en: " & rutaBase, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    File.Copy(rutaBase, rutaPrincipal, True)

                    CargarDatosDesdeCSV("csv/Plataforma/BCP_cr_act_pers_natural.csv")

                    MessageBox.Show("La lista se ha restaurado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    MessageBox.Show("Error al restaurar la lista: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        ElseIf tipoLista = "CACPJ" Then
            Dim resultado As DialogResult = MessageBox.Show(
             "¿Estás seguro de que deseas Limpiar la lista? Se mantendran 3 informes por defecto y las demas se borraran",
             "Confirmar",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
            )

            If resultado = DialogResult.Yes Then
                Try
                    Dim rutaPrincipal As String = Path.Combine(Application.StartupPath, "csv/Plataforma/BCP_cr_act_pers_juridica.csv")
                    Dim rutaBase As String = Path.Combine(Application.StartupPath, "csv/Plataforma/Bases/BCP_cr_act_pers_juridica_Base.csv")

                    If Not File.Exists(rutaBase) Then
                        MessageBox.Show("No se encontró el archivo base en: " & rutaBase, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    File.Copy(rutaBase, rutaPrincipal, True)

                    CargarDatosDesdeCSV("csv/Plataforma/BCP_cr_act_pers_juridica.csv")

                    MessageBox.Show("La lista se ha restaurado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    MessageBox.Show("Error al restaurar la lista: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        ElseIf tipoLista = "tarjeta" Then
            Dim resultado As DialogResult = MessageBox.Show(
             "¿Estás seguro de que deseas Limpiar la lista? Se mantendran 4 informes por defecto y las demas se borraran",
             "Confirmar",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
            )

            If resultado = DialogResult.Yes Then
                Try
                    Dim rutaPrincipal As String = Path.Combine(Application.StartupPath, "csv/Plataforma/Tarjeta.csv")
                    Dim rutaBase As String = Path.Combine(Application.StartupPath, "csv/Plataforma/Bases/Tarjeta_Base.csv")

                    If Not File.Exists(rutaBase) Then
                        MessageBox.Show("No se encontró el archivo base en: " & rutaBase, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    File.Copy(rutaBase, rutaPrincipal, True)

                    CargarDatosDesdeCSV("csv/Plataforma/Tarjeta.csv")

                    MessageBox.Show("La lista se ha restaurado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    MessageBox.Show("Error al restaurar la lista: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub btnCerrar_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class