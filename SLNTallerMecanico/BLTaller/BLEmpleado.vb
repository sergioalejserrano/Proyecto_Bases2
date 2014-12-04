Imports DAOTaller
Imports BEUTaller

Public Class BLEmpleado
    Public tipo As String
    Public resultado As Boolean
    Function SP_INICIO_SESION(ByVal cliente As BEUEmpleado, ByVal usuario As String, ByVal pass As String) As String
        Try
            tipo = New DAOTaller.DAOEmpleado().SP_INICIO_SESION(cliente, usuario, pass)
        Catch ex As Exception

        End Try
        Return tipo
    End Function

    Function SP_CREAR_USUARIO(ByVal pNombre As String, ByVal pApellido As String, ByVal pusuario As String, ByVal ppass As String, ByVal ptipo As String, ByVal pestado As String) As String
        Try
            resultado = New DAOTaller.DAOEmpleado().SP_CREAR_USUARIO(pNombre, pApellido, pusuario, ppass, ptipo, pestado)
        Catch ex As Exception

        End Try
        Return resultado
    End Function
End Class
