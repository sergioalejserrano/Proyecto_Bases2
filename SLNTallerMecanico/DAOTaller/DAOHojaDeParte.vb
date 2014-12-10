Imports BEUTaller
Imports System.Configuration
Imports Oracle.DataAccess.Client

Public Class DAOHojaDeParte
    Private resultado As Boolean
    '  Private vloConnection As OracleConnection
    Private vloComando As OracleCommand
    Private hoja As New BEUHojaDeParte
    Private usuario As String = DAOEmpleado.usuario
    Private pass As String = DAOEmpleado.pass
    Private conectar As New DAOConexion

#Region "Numero de Hoja"
    Public Function SP_NUM_HOJA() As BEUHojaDeParte
        '  vloConnection = New OracleConnection(ConfigurationManager.ConnectionStrings("OracleConnectionString").ConnectionString) ' Se crea la conexion a la bd
        Try
            conectar.GetConexion(usuario, pass)
        Catch ex As Exception
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        vloComando = New OracleCommand("SP_NUM_HOJA", conectar.vloconnection)
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
#End Region

#Region "Crear Hoja"
    Function SP_HOJADEPARTE_NUEVO(ByVal hoja As BEUHojaDeParte) As Boolean
        ' vloConnection = New OracleConnection(ConfigurationManager.ConnectionStrings("OracleConnectionString").ConnectionString) ' Se crea la conexion a la bd
        Try
            conectar.GetConexion(usuario, pass) 'Se abre la conexión
        Catch ex As Exception
            MsgBox("No se pudo conectar al servidor de bd...", MsgBoxStyle.Critical)
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        Try
            Dim sql As String = "SP_HOJADEPARTE_NUEVO" 'Nombre del procedimiento almacenado para agregar un nuevo cliente

            Dim cmd As New OracleCommand(sql, conectar.vloconnection) 'Se crea la variable "cmd" que va contener el nombre del proceso almacenado y los datos
            ' de la conexión a oracle
            cmd.CommandType = CommandType.StoredProcedure ' Se le indica que se le va pasar un proceso almacenado
            Dim parametro As New OracleParameter("ID_HOJA", OracleDbType.Int32) ' Se declara la variable "parametro" que contiene el nombre y el tipo
            ' del atributo de la tabla en este caso la de Proveedor.
            parametro.Value = hoja.Id_Hoja    ' Le asiganamos el valor de la variable
            cmd.Parameters.Add(parametro) 'Agregamos el valor a la variable parametro

            parametro = New OracleParameter("HORAYFECHAENTRADA", OracleDbType.TimeStamp)
            parametro.Value = hoja.HorayFechaEntrada
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("HORAYFECHASALIDA", OracleDbType.TimeStamp)
            parametro.Value = hoja.HorayFechaSalida
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("MANODEOBRA", OracleDbType.Int32)
            parametro.Value = hoja.ManodeObra
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("DETALLE", OracleDbType.Varchar2)
            parametro.Value = hoja.Detalle
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("VIN", OracleDbType.Char)
            parametro.Value = hoja.VIN
            parametro.Size = 17
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("ID_EMPLEADO", OracleDbType.Varchar2)
            parametro.Value = hoja.Id_Empleado

            cmd.Parameters.Add(parametro)

            Dim resgistrosActualizados As Integer 'Se crea la variable "resgistrosActualizados"

            Try
                resgistrosActualizados = cmd.ExecuteNonQuery() 'Se solicita el # de filas afectadas.
                MsgBox("Hoja agregada correctamente.", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("No se pudo agregar la hoja", MsgBoxStyle.Critical)
                Throw New Exception("Hoja no se agrego")

            End Try
            If resgistrosActualizados = 0 Then
                resultado = True
            End If
            '   End If
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        conectar.CloseConexion()
        Return resultado
    End Function
#End Region
End Class
