Imports BEUTaller
Imports System.Configuration
Imports Oracle.DataAccess.Client


Public Class DAOCliente
    Public resultado As Boolean = False
    ' Private vloConnection As OracleConnection
    Private vloComando As OracleCommand
    Private GetConnection As New DAOConexion
    Private usuario As String = DAOEmpleado.usuario
    Private pass As String = DAOEmpleado.pass

#Region "Agregar Cliente"
    Function SP_CLIENTE_NUEVO(ByVal cliente As BEUCliente) As Boolean
        Try
            GetConnection.GetConexion(usuario, pass)
        Catch ex As Exception
            MsgBox("No se pudo conectar al servidor de bd...", MsgBoxStyle.Critical)
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        Try
            Dim sql As String = "TALLER.SP_CLIENTE_NUEVO" 'Nombre del procedimiento almacenado para agregar un nuevo cliente
 
            Dim cmd As New OracleCommand(sql, GetConnection.vloconnection) 'Se crea la variable "cmd" que va contener el nombre del proceso almacenado y los datos
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
        GetConnection.CloseConexion()
        Return resultado
    End Function
#End Region

#Region "Borrar Cliente"
    Function SP_BORRAR_CLIENTE(ByVal cliente As BEUCliente) As Boolean
        Try
            GetConnection.GetConexion(usuario, pass)

        Catch ex As Exception
            MsgBox("No se pudo conectar al servidor de bd...", MsgBoxStyle.Critical)
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        Try
            Dim sql As String = "TALLER.SP_BORRAR_CLIENTE" 'Nombre del procedimiento almacenado para agregar un nuevo cliente

            Dim cmd As New OracleCommand(sql, GetConnection.vloconnection) 'Se crea la variable "cmd" que va contener el nombre del proceso almacenado y los datos
            ' de la conexión a oracle
            cmd.CommandType = CommandType.StoredProcedure ' Se le indica que se le va pasar un proceso almacenado
            Dim parametro As New OracleParameter("ID_CLIENTEB", OracleDbType.Int32) ' Se declara la variable "parametro" que contiene el nombre y el tipo
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
        GetConnection.CloseConexion()
        Return resultado
    End Function
#End Region

#Region "Actualizar Cliente"
    Function SP_ACTUALIZAR_CLIENTE(ByVal cliente As BEUCliente) As Boolean
        Try
            GetConnection.GetConexion(usuario, pass) 'Se abre la conexión

        Catch ex As Exception
            MsgBox("No se pudo conectar al servidor de bd...", MsgBoxStyle.Critical)
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        Try
            Dim sql As String = "TALLER.SP_ACTUALIZAR_CLIENTE" 'Nombre del procedimiento almacenado para agregar un nuevo cliente

            Dim cmd As New OracleCommand(sql, GetConnection.vloconnection) 'Se crea la variable "cmd" que va contener el nombre del proceso almacenado y los datos
            ' de la conexión a oracle
            cmd.CommandType = CommandType.StoredProcedure ' Se le indica que se le va pasar un proceso almacenado
            Dim parametro As New OracleParameter("AID_CLIENTE", OracleDbType.Int32) ' Se declara la variable "parametro" que contiene el nombre y el tipo
            ' del atributo de la tabla en este caso la de Cliente.
            parametro.Value = cliente.Id_Cliente ' Le asiganamos el valor de la variable
            cmd.Parameters.Add(parametro) 'Agregamos el valor a la variable parametro

            parametro = New OracleParameter("ANOMBRE", OracleDbType.Varchar2)
            parametro.Value = cliente.Nombre
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("AAPELLIDO", OracleDbType.Varchar2)
            parametro.Value = cliente.Apellido
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("ADIRECCION", OracleDbType.Varchar2)
            parametro.Value = cliente.Direccion
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("ATELEFONO", OracleDbType.Varchar2)
            parametro.Value = cliente.Telefono
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("AEMAIL", OracleDbType.Varchar2)
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
        GetConnection.CloseConexion()
        Return resultado
    End Function
#End Region

#Region "Seleccionar Cliente"
    Function SP_Select_Cliente(ByVal cliente As BEUCliente) As BEUCliente
        'vloConnection = New OracleConnection(ConfigurationManager.ConnectionStrings("OracleConnectionString").ConnectionString) ' Se crea la conexion a la bd
        Try
            GetConnection.GetConexion(usuario, pass)
        Catch ex As Exception
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try

        vloComando = New OracleCommand("TALLER.SP_SELECT_CLIENTE", GetConnection.vloconnection)
        vloComando.CommandType = CommandType.StoredProcedure

        Dim parametro As New OracleParameter("P_ID_CLIENTE", OracleDbType.Int32)
        parametro.Value = cliente.Id_Cliente
        parametro.Direction = ParameterDirection.Input
        'parametro.Value = Nothing
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("P_NOMBRE", OracleDbType.Varchar2)
        parametro.Value = cliente.Nombre
        parametro.Direction = ParameterDirection.Output
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("P_APELLIDO", OracleDbType.Varchar2)
        parametro.Value = cliente.Apellido
        parametro.Direction = ParameterDirection.Output
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("P_DIRECCION", OracleDbType.Varchar2)
        parametro.Value = cliente.Direccion
        parametro.Direction = ParameterDirection.Output
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("P_TELEFONO", OracleDbType.Varchar2)
        parametro.Value = cliente.Telefono
        parametro.Direction = ParameterDirection.Output
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("P_EMAIL", OracleDbType.Varchar2)
        parametro.Value = cliente.email
        parametro.Direction = ParameterDirection.Output
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        vloComando.ExecuteNonQuery()
        cliente.Id_Cliente = Convert.ToInt32(vloComando.Parameters("P_ID_CLIENTE").Value.ToString())
        cliente.Nombre = vloComando.Parameters("P_NOMBRE").Value.ToString
        cliente.Apellido = vloComando.Parameters("P_APELLIDO").Value.ToString
        cliente.Direccion = vloComando.Parameters("P_DIRECCION").Value.ToString
        cliente.Telefono = vloComando.Parameters("P_TELEFONO").Value.ToString
        cliente.email = vloComando.Parameters("P_EMAIL").Value.ToString
        GetConnection.CloseConexion()
        Return cliente
    End Function
#End Region
   
End Class
