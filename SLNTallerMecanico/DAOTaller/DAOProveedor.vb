Imports BEUTaller
Imports System.Configuration
Imports Oracle.DataAccess.Client

Public Class DAOProveedor
    Public resultado As Boolean = False
    Private vloConnection As OracleConnection
    Private vloComando As OracleCommand

#Region "Buscar Proveedor"
    Public Function SP_BUSCAR_PROVEEDOR(ByVal proveedor As BEUProveedor) As BEUProveedor
        vloConnection = New OracleConnection(ConfigurationManager.ConnectionStrings("OracleConnectionString").ConnectionString) ' Se crea la conexion a la bd
        Try
            vloConnection.Open()
        Catch ex As Exception
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        vloComando = New OracleCommand("SP_BUSCAR_PROVEEDOR", vloConnection)
        vloComando.CommandType = CommandType.StoredProcedure

        Dim parametro As New OracleParameter("P_ID_PROVEEDOR", OracleDbType.Int32)
        parametro.Value = proveedor.Id_Proveedor
        parametro.Direction = ParameterDirection.InputOutput
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("P_NOMBRE", OracleDbType.Varchar2)
        parametro.Value = proveedor.Nombre
        parametro.Direction = ParameterDirection.InputOutput
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("P_APELLIDO", OracleDbType.Varchar2)
        parametro.Value = proveedor.Apellido
        parametro.Direction = ParameterDirection.InputOutput
        'parametro.Value = Nothing
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        vloComando.ExecuteNonQuery()
        proveedor.Id_Proveedor = Convert.ToInt32(vloComando.Parameters("P_ID_PROVEEDOR").Value.ToString())
        'cliente.Id_Cliente = vloComando.Parameters("P_ID_CLIENTE").Value
        proveedor.Nombre = vloComando.Parameters("P_NOMBRE").Value.ToString
        proveedor.Apellido = vloComando.Parameters("P_APELLIDO").Value.ToString
        Return proveedor
    End Function
#End Region

#Region "Agregar Proveedor"
    Function SP_PROVEEDOR_NUEVO(ByVal proveedor As BEUProveedor) As Boolean
        vloConnection = New OracleConnection(ConfigurationManager.ConnectionStrings("OracleConnectionString").ConnectionString) ' Se crea la conexion a la bd
        Try
            vloConnection.Open() 'Se abre la conexión
        Catch ex As Exception
            MsgBox("No se pudo conectar al servidor de bd...", MsgBoxStyle.Critical)
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        Try
            Dim sql As String = "SP_PROVEEDOR_NUEVO" 'Nombre del procedimiento almacenado para agregar un nuevo cliente

            Dim cmd As New OracleCommand(sql, vloConnection) 'Se crea la variable "cmd" que va contener el nombre del proceso almacenado y los datos
            ' de la conexión a oracle
            cmd.CommandType = CommandType.StoredProcedure ' Se le indica que se le va pasar un proceso almacenado
            Dim parametro As New OracleParameter("ID_PROVEEDOR", OracleDbType.Int32) ' Se declara la variable "parametro" que contiene el nombre y el tipo
            ' del atributo de la tabla en este caso la de Cliente.
            parametro.Value = proveedor.Id_Proveedor   ' Le asiganamos el valor de la variable
            cmd.Parameters.Add(parametro) 'Agregamos el valor a la variable parametro

            parametro = New OracleParameter("NOMBRE", OracleDbType.Varchar2)
            parametro.Value = proveedor.Nombre
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("APELLIDO", OracleDbType.Varchar2)
            parametro.Value = proveedor.Apellido
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("PAIS", OracleDbType.Varchar2)
            parametro.Value = proveedor.Pais
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("PROVINCIA", OracleDbType.Varchar2)
            parametro.Value = proveedor.Provincia
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("TELEFONO", OracleDbType.Varchar2)
            parametro.Value = proveedor.Telefono
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("DIRECCION", OracleDbType.Varchar2)
            parametro.Value = proveedor.Direccion
            cmd.Parameters.Add(parametro)

            Dim resgistrosActualizados As Integer 'Se crea la variable "resgistrosActualizados"

            Try
                resgistrosActualizados = cmd.ExecuteNonQuery() 'Se solicita el # de filas afectadas.
                MsgBox("Proveedor agregado correctamente.", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("No se pudo agregar el proveedor", MsgBoxStyle.Critical)
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
