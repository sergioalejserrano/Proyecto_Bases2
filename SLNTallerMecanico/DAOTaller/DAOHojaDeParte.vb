Imports BEUTaller
Imports System.Configuration
Imports Oracle.DataAccess.Client

Public Class DAOHojaDeParte

    Private vloConnection As OracleConnection
    Private vloComando As OracleCommand
    Private hoja As New BEUHojaDeParte 
    Public Function SP_NUM_HOJA() As BEUHojaDeParte
        vloConnection = New OracleConnection(ConfigurationManager.ConnectionStrings("OracleConnectionString").ConnectionString) ' Se crea la conexion a la bd
        Try
            vloConnection.Open()
        Catch ex As Exception
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        vloComando = New OracleCommand("SP_NUM_HOJA", vloConnection)
        vloComando.CommandType = CommandType.StoredProcedure

        Dim parametro As New OracleParameter("P_NUM_HOJA", OracleDbType.Int32)
        parametro.Value = Nothing
        parametro.Direction = ParameterDirection.Output
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        vloComando.ExecuteNonQuery()
        hoja.Id_Hoja = Convert.ToInt32(vloComando.Parameters("P_NUM_HOJA").Value.ToString())
        Return hoja

    End Function
End Class
