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

#Region "Actualizar Vehiculo"
    Function SP_ACTUALIZAR_VEHICULO(ByVal vehiculo As BEUVehiculo) As Boolean
        vloConnection = New OracleConnection(ConfigurationManager.ConnectionStrings("OracleConnectionString").ConnectionString) ' Se crea la conexion a la bd
        Try
            vloConnection.Open() 'Se abre la conexión
        Catch ex As Exception
            MsgBox("No se pudo conectar al servidor de bd...", MsgBoxStyle.Critical)
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        Try
            Dim sql As String = "SP_ACTUALIZAR_VEHICULO" 'Nombre del procedimiento almacenado para agregar un nuevo cliente

            Dim cmd As New OracleCommand(sql, vloConnection) 'Se crea la variable "cmd" que va contener el nombre del proceso almacenado y los datos
            ' de la conexión a oracle
            cmd.CommandType = CommandType.StoredProcedure ' Se le indica que se le va pasar un proceso almacenado
            Dim parametro As New OracleParameter("AVIN", OracleDbType.Char) ' Se declara la variable "parametro" que contiene el nombre y el tipo
            ' del atributo de la tabla en este caso la de Cliente.
            parametro.Value = vehiculo.VIN  ' Le asiganamos el valor de la variable
            cmd.Parameters.Add(parametro) 'Agregamos el valor a la variable parametro

            parametro = New OracleParameter("APLACA", OracleDbType.Char)
            parametro.Value = vehiculo.Placa
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("AMARCA", OracleDbType.Varchar2)
            parametro.Value = vehiculo.Marca
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("AMODELO", OracleDbType.Varchar2)
            parametro.Value = vehiculo.Modelo
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("AANNO", OracleDbType.Char)
            parametro.Value = vehiculo.Anno
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("ACOLOR", OracleDbType.Varchar2)
            parametro.Value = vehiculo.Color
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("AID_CLIENTE", OracleDbType.Int32)
            parametro.Value = vehiculo.Id_Cliente
            cmd.Parameters.Add(parametro)

            Dim resgistrosActualizados As Integer 'Se crea la variable "resgistrosActualizados"

            Try
                resgistrosActualizados = cmd.ExecuteNonQuery() 'Se solicita el # de filas afectadas.
                MsgBox("Vehiculo actualizado correctamente.", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("No se pudo actualizar el vehiculo", MsgBoxStyle.Critical)
                Throw New Exception("Vehiculo no se actualizo")

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

#Region "Select Vehiculo"
    Function SP_SELECT_VEHICULO(ByVal vehiculo As BEUVehiculo) As BEUVehiculo
        vloConnection = New OracleConnection(ConfigurationManager.ConnectionStrings("OracleConnectionString").ConnectionString) ' Se crea la conexion a la bd
        Try
            vloConnection.Open()
        Catch ex As Exception
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        vloComando = New OracleCommand("SP_SELECT_VEHICULO", vloConnection)
        vloComando.CommandType = CommandType.StoredProcedure

        Dim parametro As New OracleParameter("AVIN", OracleDbType.Char)
        parametro.Value = vehiculo.VIN
        parametro.Direction = ParameterDirection.Input
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("APLACA", OracleDbType.Varchar2)
        parametro.Value = Nothing
        parametro.Direction = ParameterDirection.Output
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("AMARCA", OracleDbType.Varchar2)
        parametro.Value = Nothing
        parametro.Direction = ParameterDirection.Output
        'parametro.Value = Nothing
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("AMODELO", OracleDbType.Varchar2)
        parametro.Value = Nothing
        parametro.Direction = ParameterDirection.Output
        'parametro.Value = Nothing
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("AANNO", OracleDbType.Varchar2)
        'parametro.Value = proveedor.Provincia
        parametro.Direction = ParameterDirection.Output
        parametro.Value = Nothing
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("ACOLOR", OracleDbType.Varchar2)
        'parametro.Value = proveedor.Telefono
        parametro.Direction = ParameterDirection.Output
        parametro.Value = Nothing
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("AID_CLIENTE", OracleDbType.Int32)
        'parametro.Value = proveedor.Direccion
        parametro.Direction = ParameterDirection.Output
        parametro.Value = Nothing
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        vloComando.ExecuteNonQuery()
        vehiculo.VIN = vloComando.Parameters("AVIN").Value.ToString
        vehiculo.Placa = vloComando.Parameters("APLACA").Value.ToString
        vehiculo.Marca = vloComando.Parameters("AMARCA").Value.ToString
        vehiculo.Modelo = vloComando.Parameters("AMODELO").Value.ToString
        vehiculo.Anno = vloComando.Parameters("AANNO").Value.ToString
        vehiculo.Color = vloComando.Parameters("ACOLOR").Value.ToString
        vehiculo.Id_Cliente = Convert.ToInt32(vloComando.Parameters("AID_CLIENTE").Value.ToString())
        Return vehiculo
    End Function
#End Region
End Class
