Imports Oracle.DataAccess.Client
Public Class DAOConexion
    Public vloconnection As OracleConnection
    Private res As Boolean
#Region " Conexion a la base de Datos "
    Public Function GetConexion(ByVal usuario As String, ByVal pass As String) As Boolean
        Dim vSTRConn As String = ""
        vSTRConn = "Data Source="
        vSTRConn &= "(DESCRIPTION ="
        vSTRConn &= "(ADDRESS_LIST ="
        vSTRConn &= "(ADDRESS = (PROTOCOL = TCP)(HOST=192.168.6.30)(PORT = 1521))"
        vSTRConn &= ")"
        vSTRConn &= "(CONNECT_DATA ="
        vSTRConn &= "(SERVICE_NAME= XE)"
        vSTRConn &= ")"
        vSTRConn &= ");"
        vSTRConn &= "User ID= " + usuario + " ;"
        vSTRConn &= "Password= " + pass + " ;"


        Try
            vloconnection = New OracleConnection(vSTRConn)
            vloconnection.Open()
            res = True
        Catch Exc As Exception
            res = False
            Throw New Exception(Exc.Message, Exc)
        End Try
        Return res
    End Function

    Public Sub CloseConexion()
        If Not (vloconnection Is Nothing) Then
            vloconnection.Close()
        End If
    End Sub


#End Region
End Class
