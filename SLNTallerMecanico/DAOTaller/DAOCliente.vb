Imports BEUTaller
Imports System.Configuration
Imports Oracle.DataAccess.Client


Public Class DAOCliente
    Public resultado As Boolean = False
    Private vloConnection As OracleConnection
    Private vloComando As OracleCommand
    Private GetConnection As DAOConexion



#Region "Agregar Cliente"
    Function SP_CLIENTE_NUEVO(ByVal cliente As BEUCliente) As Boolean
        'vloConnection = New OracleConnection(ConfigurationManager.ConnectionStrings("OracleConnectionString").ConnectionString) ' Se crea la conexion a la bd
        Try
            ' vloConnection.Open() 'Se abre la conexión
            GetConexion(DAOEmpleado.usuario, DAOEmpleado.pass)
        Catch ex As Exception
            MsgBox("No se pudo conectar al servidor de bd...", MsgBoxStyle.Critical)
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        Try
            Dim sql As String = "SP_CLIENTE_NUEVO" 'Nombre del procedimiento almacenado para agregar un nuevo cliente
 
            Dim cmd As New OracleCommand(sql, vloConnection) 'Se crea la variable "cmd" que va contener el nombre del proceso almacenado y los datos
            ' de la conexión a oracle
            cmd.CommandType = CommandType.StoredProcedure ' Se le indica que se le va pasar un proceso almacenado
            Dim parametro As New OracleParameter("ID_CLIENTE", OracleDbType.Int32) ' Se declara la variable "parametro" que contiene el nombre y el tipo
            ' del atributo de la tabla en este caso la de Cliente.
            parametro.Value = cliente.Id_Cliente ' Le asiganamos el valor de la variable
            cmd.Parameters.Add(parametro) 'Agregamos el valor a la variable parametro

            parametro = New OracleParameter("NOMBRE", OracleDbType.Varchar2)
            parametro.Value = cliente.Nombre
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("APELLIDO", OracleDbType.Varchar2)
            parametro.Value = cliente.Apellido
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("DIRECCION", OracleDbType.Varchar2)
            parametro.Value = cliente.Direccion
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("TELEFONO", OracleDbType.Varchar2)
            parametro.Value = cliente.Telefono
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("EMAIL", OracleDbType.Varchar2)
            parametro.Value = cliente.email
            cmd.Parameters.Add(parametro)

            Dim resgistrosActualizados As Integer 'Se crea la variable "resgistrosActualizados"

            Try
                resgistrosActualizados = cmd.ExecuteNonQuery() 'Se solicita el # de filas afectadas.
                MsgBox("Cliente agregado correctamente.", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("No se pudo agregar el cliente", MsgBoxStyle.Critical)
                Throw New Exception("Cliente no se agrego")

            End Try
            If resgistrosActualizados = 0 Then
                resultado = True
            End If
            '   End If
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        CloseConexion()
        ' vloConnection.Close()
        Return resultado
    End Function
#End Region

#Region "Borrar Cliente"
    Function SP_BORRAR_CLIENTE(ByVal cliente As BEUCliente) As Boolean
        vloConnection = New OracleConnection(ConfigurationManager.ConnectionStrings("OracleConnectionString").ConnectionString) ' Se crea la conexion a la bd
        Try
            vloConnection.Open() 'Se abre la conexión

        Catch ex As Exception
            MsgBox("No se pudo conectar al servidor de bd...", MsgBoxStyle.Critical)
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        Try
            Dim sql As String = "SP_BORRAR_CLIENTE" 'Nombre del procedimiento almacenado para agregar un nuevo cliente

            Dim cmd As New OracleCommand(sql, vloConnection) 'Se crea la variable "cmd" que va contener el nombre del proceso almacenado y los datos
            ' de la conexión a oracle
            cmd.CommandType = CommandType.StoredProcedure ' Se le indica que se le va pasar un proceso almacenado
            Dim parametro As New OracleParameter("ID_CLIENTE", OracleDbType.Int32) ' Se declara la variable "parametro" que contiene el nombre y el tipo
            ' del atributo de la tabla en este caso la de Cliente.
            parametro.Value = cliente.Id_Cliente ' Le asiganamos el valor de la variable
            cmd.Parameters.Add(parametro) 'Agregamos el valor a la variable parametro

            Dim resgistrosActualizados As Integer 'Se crea la variable "resgistrosActualizados"

            Try
                resgistrosActualizados = cmd.ExecuteNonQuery() 'Se solicita el # de filas afectadas.
                MsgBox("Cliente borrado correctamente.", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("No se pudo borrar el cliente", MsgBoxStyle.Critical)
                Throw New Exception("No se pudo borrar el cliente")

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

#Region "Actualizar Cliente"
    Function SP_ACTUALIZAR_CLIENTE(ByVal cliente As BEUCliente) As Boolean
        vloConnection = New OracleConnection(ConfigurationManager.ConnectionStrings("OracleConnectionString").ConnectionString) ' Se crea la conexion a la bd
        Try
            vloConnection.Open() 'Se abre la conexión

        Catch ex As Exception
            MsgBox("No se pudo conectar al servidor de bd...", MsgBoxStyle.Critical)
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        Try
            Dim sql As String = "SP_ACTUALIZAR_CLIENTE" 'Nombre del procedimiento almacenado para agregar un nuevo cliente

            Dim cmd As New OracleCommand(sql, vloConnection) 'Se crea la variable "cmd" que va contener el nombre del proceso almacenado y los datos
            ' de la conexión a oracle
            cmd.CommandType = CommandType.StoredProcedure ' Se le indica que se le va pasar un proceso almacenado
            Dim parametro As New OracleParameter("ID_CLIENTE", OracleDbType.Int32) ' Se declara la variable "parametro" que contiene el nombre y el tipo
            ' del atributo de la tabla en este caso la de Cliente.
            parametro.Value = cliente.Id_Cliente ' Le asiganamos el valor de la variable
            cmd.Parameters.Add(parametro) 'Agregamos el valor a la variable parametro

            parametro = New OracleParameter("NOMBRE", OracleDbType.Varchar2)
            parametro.Value = cliente.Nombre
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("APELLIDO", OracleDbType.Varchar2)
            parametro.Value = cliente.Apellido
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("DIRECCION", OracleDbType.Varchar2)
            parametro.Value = cliente.Direccion
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("TELEFONO", OracleDbType.Varchar2)
            parametro.Value = cliente.Telefono
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("EMAIL", OracleDbType.Varchar2)
            parametro.Value = cliente.email
            cmd.Parameters.Add(parametro)

            Dim resgistrosActualizados As Integer 'Se crea la variable "resgistrosActualizados"

            Try
                resgistrosActualizados = cmd.ExecuteNonQuery() 'Se solicita el # de filas afectadas.
                MsgBox("Cliente actualizado correctamente.", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("No se pudo actualizar el cliente", MsgBoxStyle.Critical)
                Throw New Exception("Cliente no se actualizó")

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

#Region "Buscar Cliente"
    Public Function SP_BUSCAR_CLIENTE(ByVal cliente As BEUCliente) As BEUCliente
        vloConnection = New OracleConnection(ConfigurationManager.ConnectionStrings("OracleConnectionString").ConnectionString) ' Se crea la conexion a la bd
        Try
            vloConnection.Open()
        Catch ex As Exception
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        vloComando = New OracleCommand("SP_BUSCAR_CLIENTE", vloConnection)
        vloComando.CommandType = CommandType.StoredProcedure

        Dim parametro As New OracleParameter("P_ID_CLIENTE", OracleDbType.Int32)
        parametro.Value = cliente.Id_Cliente
        parametro.Direction = ParameterDirection.InputOutput
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("P_NOMBRE", OracleDbType.Varchar2)
        parametro.Value = cliente.Nombre
        parametro.Direction = ParameterDirection.InputOutput
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("P_APELLIDO", OracleDbType.Varchar2)
        parametro.Value = cliente.Apellido
        parametro.Direction = ParameterDirection.InputOutput
        'parametro.Value = Nothing
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        vloComando.ExecuteNonQuery()
        cliente.Id_Cliente = vloComando.Parameters("P_ID_CLIENTE").Value
        cliente.Nombre = vloComando.Parameters("P_NOMBRE").Value.ToString
        cliente.Apellido = vloComando.Parameters("P_APELLIDO").Value.ToString
        Return cliente
    End Function
#End Region

    Public Sub GetConexion(ByVal usuario, ByVal pass)
        Dim vSTRConn As String = ""

        vSTRConn &= "Data Source=XE;"
        vSTRConn &= "User ID= " + usuario + " ;"
        vSTRConn &= "Password= " + pass + " ;"

        Try
            vloConnection = New OracleConnection(vSTRConn)
            vloConnection.Open()
        Catch Exc As Exception
            Throw New Exception(Exc.Message, Exc)
        End Try
    End Sub

    Public Sub CloseConexion()
        If Not (vloconnection Is Nothing) Then
            vloconnection.Close()
        End If
    End Sub

End Class
