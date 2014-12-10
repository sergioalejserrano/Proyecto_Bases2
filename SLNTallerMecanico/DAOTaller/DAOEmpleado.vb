Imports BEUTaller
Imports System.Configuration
Imports Oracle.DataAccess.Client
Public Class DAOEmpleado
    Public resultado As Boolean = False
    Private vloConnection As OracleConnection
    Private vloComando As OracleCommand
    Public Shared usuario As String
    Public Shared pass As String
    Private conectar As New DAOConexion


#Region "Validar Contraseña"
    Public Function SP_INICIO_SESION(ByVal empleado As BEUEmpleado, ByVal pusuario As String, ByVal ppass As String) As String
        Dim tipo As String = String.Empty
        ' vloConnection = New OracleConnection(ConfigurationManager.ConnectionStrings("OracleConnectionString").ConnectionString) ' Se crea la conexion a la bd
        Try
            If conectar.GetConexion(pusuario, ppass) Then
                vloComando = New OracleCommand("TALLER.SP_INICIO_SESION", conectar.vloconnection)
                vloComando.CommandType = CommandType.StoredProcedure

                Dim parametro As New OracleParameter("AUSERNAME", OracleDbType.Varchar2)
                parametro.Value = empleado.USERNAME
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

                vloComando.ExecuteNonQuery()
                tipo = vloComando.Parameters("ATIPO").Value.ToString
                usuario = pusuario
                pass = ppass

            End If
        Catch ex As Exception
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        Return tipo
    End Function
#End Region

#Region "Crear Usuarios"
    Public Function SP_CREAR_USUARIO(ByVal pNombre As String, ByVal pApellido As String, ByVal pusuario As String, ByVal ppass As String, ByVal ptipo As String, ByVal pestado As String) As String
        Try
            conectar.GetConexion(usuario, pass)
        Catch ex As Exception
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        Try
            vloComando = New OracleCommand("TALLER.SP_CREAR_USUARIO", conectar.vloconnection)
            vloComando.CommandType = CommandType.StoredProcedure

            Dim parametro As New OracleParameter("usuario", OracleDbType.Varchar2)
            parametro.Value = pusuario
            parametro.Direction = ParameterDirection.Input
            vloComando.Parameters.Add(parametro)

            parametro = New OracleParameter("pass", OracleDbType.Varchar2)
            parametro.Value = ppass
            parametro.Direction = ParameterDirection.Input
            vloComando.Parameters.Add(parametro)

            'parametro = New OracleParameter("ATIPO", OracleDbType.Varchar2)
            'parametro.Value = ptipo
            'parametro.Direction = ParameterDirection.Input
            'vloComando.Parameters.Add(parametro)

            'parametro = New OracleParameter("aestado", OracleDbType.Varchar2)
            'parametro.Value = pestado
            'parametro.Direction = ParameterDirection.Input
            'vloComando.Parameters.Add(parametro)

            Dim resgistrosActualizados As Integer 'Se crea la variable "resgistrosActualizados"

            Try

                resgistrosActualizados = vloComando.ExecuteNonQuery() 'Se solicita el # de filas afectadas.
                MsgBox("Usuario agregado correctamente.", MsgBoxStyle.Information)
                SP_NUEVO_USUARIO(pNombre, pApellido, pusuario, ppass, ptipo, pestado)
            Catch ex As Exception
                MsgBox("No se pudo agregar el usuario", MsgBoxStyle.Critical)
                Throw New Exception("Usuario no se agrego")

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
        ' vloConnection.Close()
        Return resultado
    End Function
#End Region

#Region "Agregar Usuario"
    Public Function SP_NUEVO_USUARIO(ByVal pNombre As String, ByVal pApellido As String, ByVal pusuario As String, ByVal ppass As String, ByVal ptipo As String, ByVal pestado As Char)
        Try
            conectar.GetConexion(usuario, pass)
        Catch ex As Exception
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        Try
            vloComando = New OracleCommand("TALLER.SP_NUEVO_USUARIO", conectar.vloconnection)
            vloComando.CommandType = CommandType.StoredProcedure

            Dim parametro As New OracleParameter("usuario", OracleDbType.Varchar2)
            parametro.Value = pusuario
            parametro.Direction = ParameterDirection.Input
            vloComando.Parameters.Add(parametro)

            parametro = New OracleParameter("pass", OracleDbType.Varchar2)
            parametro.Value = ppass
            parametro.Direction = ParameterDirection.Input
            vloComando.Parameters.Add(parametro)

            parametro = New OracleParameter("ATIPO", OracleDbType.Varchar2)
            parametro.Value = ptipo
            parametro.Direction = ParameterDirection.Input
            vloComando.Parameters.Add(parametro)

            parametro = New OracleParameter("aestado", OracleDbType.Varchar2)
            parametro.Value = pestado
            parametro.Direction = ParameterDirection.Input
            vloComando.Parameters.Add(parametro)

            Dim resgistrosActualizados As Integer 'Se crea la variable "resgistrosActualizados"

            Try

                resgistrosActualizados = vloComando.ExecuteNonQuery() 'Se solicita el # de filas afectadas.
                MsgBox("Usuario agregado correctamente.", MsgBoxStyle.Information)
                SP_EMPLEADO_NUEVO(pNombre, pApellido, pusuario, ptipo)
            Catch ex As Exception
                MsgBox("No se pudo agregar el usuario", MsgBoxStyle.Critical)
                Throw New Exception("Usuario no se agrego")

            End Try
            If resgistrosActualizados = 0 Then
                resultado = True
            End If
            '   End If
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Return resultado
    End Function
#End Region

#Region "Agregar Empleado"
    Public Function SP_EMPLEADO_NUEVO(ByVal pNombre As String, ByVal pApellido As String, ByVal pusuario As String, ByVal ptipo As String)
        Try
            conectar.GetConexion(usuario, pass)
        Catch ex As Exception
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        Try
            vloComando = New OracleCommand("TALLER.SP_EMPLEADO_NUEVO", conectar.vloconnection)
            vloComando.CommandType = CommandType.StoredProcedure

            Dim parametro As New OracleParameter("ID_EMPLEADO", OracleDbType.Varchar2)
            parametro.Value = pusuario
            parametro.Direction = ParameterDirection.Input
            vloComando.Parameters.Add(parametro)

            parametro = New OracleParameter("NOMBRE", OracleDbType.Varchar2)
            parametro.Value = pNombre
            parametro.Direction = ParameterDirection.Input
            vloComando.Parameters.Add(parametro)

            parametro = New OracleParameter("APELLIDO", OracleDbType.Varchar2)
            parametro.Value = pApellido
            parametro.Direction = ParameterDirection.Input
            vloComando.Parameters.Add(parametro)

            parametro = New OracleParameter("ATIPO", OracleDbType.Varchar2)
            parametro.Value = ptipo
            parametro.Direction = ParameterDirection.Input
            vloComando.Parameters.Add(parametro)

            Dim resgistrosActualizados As Integer 'Se crea la variable "resgistrosActualizados"

            Try
                resgistrosActualizados = vloComando.ExecuteNonQuery() 'Se solicita el # de filas afectadas.
                MsgBox("Empleado agregado correctamente.", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("No se pudo agregar el empleado", MsgBoxStyle.Critical)
                Throw New Exception("Empleado no se agrego")

            End Try
            If resgistrosActualizados = 0 Then
                resultado = True
            End If
            '   End If
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Return resultado
    End Function
#End Region


#Region "Select Empleado"
    Function SP_SELECT_EMPLEADO(ByVal empleado As BEUEmpleado) As BEUEmpleado
        Try
            conectar.GetConexion(usuario, pass)
        Catch ex As Exception
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        vloComando = New OracleCommand("TALLER.SP_SELECT_EMPLEADO", conectar.vloconnection)
        vloComando.CommandType = CommandType.StoredProcedure

        Dim parametro As New OracleParameter("P_ID_EMPLEADO", OracleDbType.Varchar2)
        parametro.Value = empleado.ID_EMPLEADO
        parametro.Direction = ParameterDirection.Input
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("P_NOMBRE", OracleDbType.Varchar2)
        parametro.Value = empleado.Nombre
        parametro.Direction = ParameterDirection.Output
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("P_APELLIDO", OracleDbType.Varchar2)
        parametro.Value = empleado.Apellido
        parametro.Direction = ParameterDirection.Output
        'parametro.Value = Nothing
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("P_TIPO", OracleDbType.Varchar2)
        parametro.Value = empleado.Tipo
        parametro.Direction = ParameterDirection.Output
        'parametro.Value = Nothing
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        vloComando.ExecuteNonQuery()

        empleado.ID_EMPLEADO = vloComando.Parameters("P_ID_EMPLEADO").Value.ToString
        empleado.Nombre = vloComando.Parameters("P_NOMBRE").Value.ToString
        empleado.Apellido = vloComando.Parameters("P_APELLIDO").Value.ToString
        empleado.Tipo = vloComando.Parameters("P_TIPO").Value.ToString

        Return empleado
    End Function
#End Region

End Class
