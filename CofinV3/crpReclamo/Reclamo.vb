Module Reclamo
    Public Class Reclamo
        Public nombreRazonSocial As String
        Public tipoReclamante As String
        Public ciNIT As String
        Public repreApoderado As String
        Public testimonio As String
        Public direccionCalle As String
        Public direccionZona As String
        Public telefonoDomicilio As String
        Public telefonoCelular As String
        Public correo As String
        Public fechaDia As String
        Public fechaMes As String
        Public fechaAnio As String
        Public descripcion As String
        Public monto As String
        Public origenDepartamento As String
        Public origenCiudad As String
        Public numReclamo As String
        Public medioReclamo As String
        Public medioEntrega As String
    End Class

    Public registroActualReclamo As New Reclamo()

    Public Sub nuevoRegistroReclamo()
        registroActualReclamo = New Reclamo()
    End Sub
End Module
