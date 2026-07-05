Imports System.IO

Module Tarjeta

    Private rutaArchivo As String = "csv/Plataforma/Tarjeta.csv"
    Private rutaBase As String = "csv/Plataforma/Bases/Tarjeta_Base.csv"

    Public Class registroTarjeta
        Public ci As String
        Public nombre As String
        Public tarjeta As String
        Public tipo As String
    End Class

    Public listaTarjetas As New List(Of registroTarjeta)

    Public registroActualTarjeta As New registroTarjeta()

    Public Sub nuevoRegistroTarjeta()
        registroActualTarjeta = New registroTarjeta()
    End Sub

    Public Sub CargarRegitrosDesdeCSVTarjeta()
        listaTarjetas.Clear()

        If Not File.Exists(rutaArchivo) Then Exit Sub

        Dim lineas = File.ReadAllLines(rutaArchivo)

        For Each linea In lineas
            Dim valores = linea.Split(","c).Select(Function(v) v.Trim("'"c)).ToArray()
            Dim campos = GetType(Tarjeta).GetFields()

            If valores.Length >= campos.Length Then
                Dim r As New registroTarjeta()
                For i = 0 To campos.Length - 1
                    campos(i).SetValue(r, valores(i))
                Next
                listaTarjetas.Add(r)
            End If
        Next
    End Sub

    Public Function buscarRegistroPorCITarjeta(ci As String) As registroTarjeta
        Return listaTarjetas.FirstOrDefault(Function(r) r.ci.Trim() = ci.Trim())
    End Function

    Public Function CargarDatosTarjeta() As List(Of registroTarjeta)
        CargarRegitrosDesdeCSVTarjeta()
        Return listaTarjetas
    End Function

    Public Sub RestaurarDatosBaseTarjeta()
        If Not File.Exists(rutaBase) Then
            MessageBox.Show("Archivo base no encontrado: " & rutaBase, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        File.Copy(rutaBase, rutaArchivo, True)
        CargarDatosTarjeta()

        MessageBox.Show("La lista se ha restaurado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Console.WriteLine("Datos restaurados de Tarjeta")
    End Sub
End Module
