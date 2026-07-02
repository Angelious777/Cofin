Module Tarjeta
    Public Class Tarjeta
        Public ci As String
        Public nombre As String
        Public tarjeta As String
        Public tipo As String
    End Class

    Public registroActualTarjeta As New Tarjeta()

    Public Sub nuevoRegistroTarjeta()
        registroActualTarjeta = New Tarjeta()
    End Sub
End Module
