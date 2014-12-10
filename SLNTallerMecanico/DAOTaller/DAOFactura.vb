Imports BEUTaller
Imports Oracle.DataAccess.Client
Imports System.Configuration
Public Class DAOFactura
    Private vloConnection As OracleConnection
    Private vloComando As OracleCommand
    Private factura As New BEUFactura
    Private resultado As Boolean

#Region "Numero de Factura"
    Public Function SP_NUM_FACTURA() As BEUFactura
        vloConnection = New OracleConnection(ConfigurationManager.ConnectionStrings("OracleConnectionString").ConnectionString) ' Se crea la conexion a la bd
        Try
            vloConnection.Open()
        Catch ex As Exception
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        vloComando = New OracleCommand("SP_NUM_FACTURA", vloConnection)
        vloComando.CommandType = CommandType.StoredProcedure

        Dim parametro As New OracleParameter("P_NUM_FACTURA", OracleDbType.Int32)
        parametro.Value = Nothing
        parametro.Direction = ParameterDirection.Output
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        vloComando.ExecuteNonQuery()
        factura.Id_Factura = Convert.ToInt32(vloComando.Parameters("P_NUM_FACTURA").Value.ToString())
        Return factura

    End Function
#End Region

#Region "Crear Facturar"

    Function SP_FACTURA_NUEVO(ByVal factura As BEUFactura) As Boolean
        vloConnection = New OracleConnection(ConfigurationManager.ConnectionStrings("OracleConnectionString").ConnectionString) ' Se crea la conexion a la bd
        Try
            vloConnection.Open() 'Se abre la conexión
        Catch ex As Exception
            MsgBox("No se pudo conectar al servidor de bd...", MsgBoxStyle.Critical)
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        Try
            Dim sql As String = "SP_FACTURA_NUEVO" 'Nombre del procedimiento almacenado para agregar un nuevo cliente

            Dim cmd As New OracleCommand(sql, vloConnection) 'Se crea la variable "cmd" que va contener el nombre del proceso almacenado y los datos
            ' de la conexión a oracle
            cmd.CommandType = CommandType.StoredProcedure ' Se le indica que se le va pasar un proceso almacenado
            Dim parametro As New OracleParameter("IDFACTURA", OracleDbType.Int32) ' Se declara la variable "parametro" que contiene el nombre y el tipo
            ' del atributo de la tabla en este caso la de Proveedor.
            parametro.Value = factura.Id_Factura    ' Le asiganamos el valor de la variable
            cmd.Parameters.Add(parametro) 'Agregamos el valor a la variable parametro

            parametro = New OracleParameter("FECHA", OracleDbType.Date)
            parametro.Value = factura.Fecha
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("ID_CLIENTE", OracleDbType.Int32)
            parametro.Value = factura.Id_Cliente
            cmd.Parameters.Add(parametro)

            Dim resgistrosActualizados As Integer 'Se crea la variable "resgistrosActualizados"

            Try
                resgistrosActualizados = cmd.ExecuteNonQuery() 'Se solicita el # de filas afectadas.
                'MsgBox("Factura agregada correctamente.", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("No se pudo agregar la factura", MsgBoxStyle.Critical)
                Throw New Exception("Factura no se agrego")

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
