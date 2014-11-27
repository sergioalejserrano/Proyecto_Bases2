Imports BEUTaller
Imports System.Configuration
Imports Oracle.DataAccess.Client
'Imports System.Data.OracleClient
Public Class DAOEmpleado
    Public resultado As Boolean = False
    Private vloConnection As OracleConnection
    Private vloComando As OracleCommand

#Region "Validar Contraseña"
    Public Function SP_INICIO_SESION(ByVal empleado As BEUEmpleado) As String
        vloConnection = New OracleConnection(ConfigurationManager.ConnectionStrings("OracleConnectionString").ConnectionString) ' Se crea la conexion a la bd
        Try
            vloConnection.Open()
        Catch ex As Exception
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        vloComando = New OracleCommand("SP_INICIO_SESION", vloConnection)
        vloComando.CommandType = CommandType.StoredProcedure

        Dim parametro As New OracleParameter("AID_EMPLEADO", OracleDbType.Int32)
        parametro.Value = empleado.Id_Empleado
        parametro.Direction = ParameterDirection.Input
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("ACONTRASENA", OracleDbType.Varchar2)
        parametro.Value = empleado.Contrasena.ToString
        parametro.Direction = ParameterDirection.Input
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("ATIPO", OracleDbType.Varchar2)
        parametro.Direction = ParameterDirection.Output
        'parametro.Value = Nothing
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        Dim tipo As String = String.Empty
        vloComando.ExecuteNonQuery()
        tipo = vloComando.Parameters("ATIPO").Value.ToString
        Return tipo
    End Function
#End Region
End Class
