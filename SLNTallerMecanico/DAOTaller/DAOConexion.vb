Imports Oracle.DataAccess.Client
Public Class DAOConexion
    Private vloconnection As OracleConnection

#Region " Conexion a la base de Datos "
    Public Sub GetConexion()
        Dim vSTRConn As String = ""

        vSTRConn &= "Data Source=XE;"
        vSTRConn &= "User ID=taller;"
        vSTRConn &= "Password=12345;"

        Try
            vloconnection = New OracleConnection(vSTRConn)
            vloconnection.Open()
        Catch Exc As Exception
            Throw New Exception(Exc.Message, Exc)
        End Try
    End Sub

    Public Sub CloseConexion()
        If Not (vloconnection Is Nothing) Then
            vloconnection.Close()
        End If
    End Sub


#End Region
End Class
