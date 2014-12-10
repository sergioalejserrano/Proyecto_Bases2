Imports BEUTaller
Imports System.Configuration
Imports Oracle.DataAccess.Client

Public Class DAOProveedor
    Public resultado As Boolean = False
    ' Private vloConnection As OracleConnection
    Private vloComando As OracleCommand
    Private usuario As String = DAOEmpleado.usuario
    Private pass As String = DAOEmpleado.pass
    Private conectar As New DAOConexion

#Region "Select Proveedor"
    Public Function SP_SELECT_PROVEEDOR(ByVal proveedor As BEUProveedor) As BEUProveedor
        'vloConnection = New OracleConnection(ConfigurationManager.ConnectionStrings("OracleConnectionString").ConnectionString) ' Se crea la conexion a la bd
        Try
            conectar.GetConexion(usuario, pass)
        Catch ex As Exception
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        vloComando = New OracleCommand("SP_SELECT_PROVEEDOR", conectar.vloconnection)
        vloComando.CommandType = CommandType.StoredProcedure

        Dim parametro As New OracleParameter("P_ID_PROVEEDOR", OracleDbType.Int32)
        parametro.Value = proveedor.Id_Proveedor
        parametro.Direction = ParameterDirection.Input
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("P_NOMBRE", OracleDbType.Varchar2)
        parametro.Value = proveedor.Nombre
        parametro.Direction = ParameterDirection.Output
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("P_APELLIDO", OracleDbType.Varchar2)
        parametro.Value = proveedor.Apellido
        parametro.Direction = ParameterDirection.Output
        'parametro.Value = Nothing
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("P_PAIS", OracleDbType.Varchar2)
        parametro.Value = proveedor.Pais
        parametro.Direction = ParameterDirection.Output
        'parametro.Value = Nothing
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("P_PROVINCIA", OracleDbType.Varchar2)
        parametro.Value = proveedor.Provincia
        parametro.Direction = ParameterDirection.Output
        'parametro.Value = Nothing
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("P_TELEFONO", OracleDbType.Varchar2)
        parametro.Value = proveedor.Telefono
        parametro.Direction = ParameterDirection.Output
        'parametro.Value = Nothing
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("P_DIRECCION", OracleDbType.Varchar2)
        parametro.Value = proveedor.Direccion
        parametro.Direction = ParameterDirection.Output
        'parametro.Value = Nothing
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        vloComando.ExecuteNonQuery()
        proveedor.Id_Proveedor = Convert.ToInt32(vloComando.Parameters("P_ID_PROVEEDOR").Value.ToString())
        proveedor.Nombre = vloComando.Parameters("P_NOMBRE").Value.ToString
        proveedor.Apellido = vloComando.Parameters("P_APELLIDO").Value.ToString
        proveedor.Pais = vloComando.Parameters("P_PAIS").Value.ToString
        proveedor.Provincia = vloComando.Parameters("P_PROVINCIA").Value.ToString
        proveedor.Telefono = vloComando.Parameters("P_TELEFONO").Value.ToString
        proveedor.Direccion = vloComando.Parameters("P_DIRECCION").Value.ToString
        Return proveedor
    End Function
#End Region

#Region "Agregar Proveedor"
    Function SP_PROVEEDOR_NUEVO(ByVal proveedor As BEUProveedor) As Boolean
        Try
            conectar.GetConexion(usuario, pass) 'Se abre la conexión
        Catch ex As Exception
            MsgBox("No se pudo conectar al servidor de bd...", MsgBoxStyle.Critical)
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        Try
            Dim sql As String = "SP_PROVEEDOR_NUEVO" 'Nombre del procedimiento almacenado para agregar un nuevo cliente

            Dim cmd As New OracleCommand(sql, conectar.vloconnection) 'Se crea la variable "cmd" que va contener el nombre del proceso almacenado y los datos
            ' de la conexión a oracle
            cmd.CommandType = CommandType.StoredProcedure ' Se le indica que se le va pasar un proceso almacenado
            Dim parametro As New OracleParameter("ID_PROVEEDOR", OracleDbType.Int32) ' Se declara la variable "parametro" que contiene el nombre y el tipo
            ' del atributo de la tabla en este caso la de Proveedor.
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
                Throw New Exception("Proveedor no se agrego")

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

#Region "Actualizar Proveedor"
    Function SP_ACTUALIZAR_PROVEEDOR(ByVal proveedor As BEUProveedor) As Boolean
        Try
            conectar.GetConexion(usuario, pass)
        Catch ex As Exception
            MsgBox("No se pudo conectar al servidor de bd...", MsgBoxStyle.Critical)
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        Try
            Dim sql As String = "SP_ACTUALIZAR_PROVEEDOR" 'Nombre del procedimiento almacenado para agregar un nuevo cliente

            Dim cmd As New OracleCommand(sql, conectar.vloconnection) 'Se crea la variable "cmd" que va contener el nombre del proceso almacenado y los datos
            ' de la conexión a oracle
            cmd.CommandType = CommandType.StoredProcedure ' Se le indica que se le va pasar un proceso almacenado
            Dim parametro As New OracleParameter("AID_PROVEEDOR", OracleDbType.Int32) ' Se declara la variable "parametro" que contiene el nombre y el tipo
            ' del atributo de la tabla en este caso la de Proveedor.
            parametro.Value = proveedor.Id_Proveedor   ' Le asiganamos el valor de la variable
            cmd.Parameters.Add(parametro) 'Agregamos el valor a la variable parametro

            parametro = New OracleParameter("ANOMBRE", OracleDbType.Varchar2)
            parametro.Value = proveedor.Nombre
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("AAPELLIDO", OracleDbType.Varchar2)
            parametro.Value = proveedor.Apellido
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("APAIS", OracleDbType.Varchar2)
            parametro.Value = proveedor.Pais
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("APROVINCIA", OracleDbType.Varchar2)
            parametro.Value = proveedor.Provincia
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("ATELEFONO", OracleDbType.Varchar2)
            parametro.Value = proveedor.Telefono
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("ADIRECCION", OracleDbType.Varchar2)
            parametro.Value = proveedor.Direccion
            cmd.Parameters.Add(parametro)

            Dim resgistrosActualizados As Integer 'Se crea la variable "resgistrosActualizados"

            Try
                resgistrosActualizados = cmd.ExecuteNonQuery() 'Se solicita el # de filas afectadas.
                MsgBox("Proveedor actualizado correctamente.", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("No se pudo actualizar el proveedor", MsgBoxStyle.Critical)
                Throw New Exception("Proveedor no se actualizo")

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

#Region "Borrar Proveedor"
    Function SP_BORRAR_PROVEEDOR(ByVal proveedor As BEUProveedor) As Boolean
        Try
            conectar.GetConexion(usuario, pass)
        Catch ex As Exception
            MsgBox("No se pudo conectar al servidor de bd...", MsgBoxStyle.Critical)
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        Try
            Dim sql As String = "SP_PROVEEDOR_NUEVO" 'Nombre del procedimiento almacenado para agregar un nuevo cliente

            Dim cmd As New OracleCommand(sql, conectar.vloconnection) 'Se crea la variable "cmd" que va contener el nombre del proceso almacenado y los datos
            ' de la conexión a oracle
            cmd.CommandType = CommandType.StoredProcedure ' Se le indica que se le va pasar un proceso almacenado
            Dim parametro As New OracleParameter("ID_PROVEEDOR", OracleDbType.Int32) ' Se declara la variable "parametro" que contiene el nombre y el tipo
            ' del atributo de la tabla en este caso la de Proveedor.
            parametro.Value = proveedor.Id_Proveedor   ' Le asiganamos el valor de la variable
            cmd.Parameters.Add(parametro) 'Agregamos el valor a la variable parametro
            Dim resgistrosActualizados As Integer 'Se crea la variable "resgistrosActualizados"

            Try
                resgistrosActualizados = cmd.ExecuteNonQuery() 'Se solicita el # de filas afectadas.
                MsgBox("Proveedor borrado correctamente.", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("No se pudo borrar el proveedor", MsgBoxStyle.Critical)
                Throw New Exception("Proveedor no se borro")

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
