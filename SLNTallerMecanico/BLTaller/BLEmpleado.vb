Imports DAOTaller
Imports BEUTaller

Public Class BLEmpleado
    Public tipo As String
    Function SP_INICIO_SESION(ByVal cliente As BEUEmpleado) As String
        Try
            tipo = New DAOTaller.DAOEmpleado().SP_INICIO_SESION(cliente)
        Catch ex As Exception

        End Try
        Return tipo
    End Function
End Class
