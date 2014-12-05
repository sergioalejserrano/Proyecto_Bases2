Imports BEUTaller
Imports System.Configuration
Imports Oracle.DataAccess.Client

Public Class DAOVehiculo
    Private vehiculo As New BEUVehiculo
    Private resultado As Boolean = False
    Private vloConnection As OracleConnection
    Private vloComando As OracleCommand
#Region "Agregar Vehiculo"
    Function SP_VEHICULO_NUEVO(ByVal vehiculo As BEUVehiculo) As Boolean
        vloConnection = New OracleConnection(ConfigurationManager.ConnectionStrings("OracleConnectionString").ConnectionString) ' Se crea la conexion a la bd
        Try
            vloConnection.Open() 'Se abre la conexión
        Catch ex As Exception
            MsgBox("No se pudo conectar al servidor de bd...", MsgBoxStyle.Critical)
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        Try
            Dim sql As String = "SP_VEHICULO_NUEVO" 'Nombre del procedimiento almacenado para agregar un nuevo cliente

            Dim cmd As New OracleCommand(sql, vloConnection) 'Se crea la variable "cmd" que va contener el nombre del proceso almacenado y los datos
            ' de la conexión a oracle
            cmd.CommandType = CommandType.StoredProcedure ' Se le indica que se le va pasar un proceso almacenado
            Dim parametro As New OracleParameter("P_VIN", OracleDbType.Char) ' Se declara la variable "parametro" que contiene el nombre y el tipo
            ' del atributo de la tabla en este caso la de Cliente.
            parametro.Value = vehiculo.VIN  ' Le asiganamos el valor de la variable
            cmd.Parameters.Add(parametro) 'Agregamos el valor a la variable parametro

            parametro = New OracleParameter("P_PLACA", OracleDbType.Char)
            parametro.Value = vehiculo.Placa
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("P_MARCA", OracleDbType.Varchar2)
            parametro.Value = vehiculo.Marca
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("P_MODELO", OracleDbType.Varchar2)
            parametro.Value = vehiculo.Modelo
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("P_ANNO", OracleDbType.Char)
            parametro.Value = vehiculo.Anno
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("P_COLOR", OracleDbType.Varchar2)
            parametro.Value = vehiculo.Color
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("P_ID_CLIENTE", OracleDbType.Int32)
            parametro.Value = vehiculo.Id_Cliente
            cmd.Parameters.Add(parametro)

            Dim resgistrosActualizados As Integer 'Se crea la variable "resgistrosActualizados"

            Try
                resgistrosActualizados = cmd.ExecuteNonQuery() 'Se solicita el # de filas afectadas.
                MsgBox("Vehiculo agregado correctamente.", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("No se pudo agregar el vehiculo", MsgBoxStyle.Critical)
                Throw New Exception("Vehiculo no se agrego")

            End Try
            If resgistrosActualizados = 0 Then
                resultado = True
            End If
            '   End If
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        vloConnection.Close()
        Return resultado
    End Function
#End Region

End Class
