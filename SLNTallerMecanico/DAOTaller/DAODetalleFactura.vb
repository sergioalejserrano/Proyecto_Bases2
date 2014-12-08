Imports BEUTaller
Imports Oracle.DataAccess.Client
Imports System.Configuration
Public Class DAODetalleFactura
    Private resultado As Boolean
    Private vloConnection As OracleConnection
    Private vloComando As OracleCommand


#Region "Crear Detalle"
    Function SP_DETALLE_FACTURA_NUEVO(ByVal detalle As BEUDetalleFactura) As Boolean
        vloConnection = New OracleConnection(ConfigurationManager.ConnectionStrings("OracleConnectionString").ConnectionString) ' Se crea la conexion a la bd
        Try
            vloConnection.Open() 'Se abre la conexión
        Catch ex As Exception
            MsgBox("No se pudo conectar al servidor de bd...", MsgBoxStyle.Critical)
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        Try
            Dim sql As String = "SP_DETALLE_FACTURA_NUEVO" 'Nombre del procedimiento almacenado para agregar un nuevo cliente

            Dim cmd As New OracleCommand(sql, vloConnection) 'Se crea la variable "cmd" que va contener el nombre del proceso almacenado y los datos
            ' de la conexión a oracle
            cmd.CommandType = CommandType.StoredProcedure ' Se le indica que se le va pasar un proceso almacenado
            Dim parametro As New OracleParameter("ID_DETALLE_FACTURA", OracleDbType.Int32) ' Se declara la variable "parametro" que contiene el nombre y el tipo
            ' del atributo de la tabla en este caso la de Proveedor.
            parametro.Value = detalle.Id_Detalle_Factura   ' Le asiganamos el valor de la variable
            cmd.Parameters.Add(parametro) 'Agregamos el valor a la variable parametro

            parametro = New OracleParameter("ID_FACTURA", OracleDbType.Int32)
            parametro.Value = detalle.Id_Factura
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("ID_REPUESTO", OracleDbType.Int32)
            parametro.Value = detalle.Id_Repuesto
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("PRECIO", OracleDbType.Int32)
            parametro.Value = detalle.Precio
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("CANTIDAD", OracleDbType.Int32)
            parametro.Value = detalle.Cantidad
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("MANODEOBRA", OracleDbType.Int32)
            parametro.Value = detalle.ManodeObra
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("ID_HOJA", OracleDbType.Int32)
            parametro.Value = detalle.Id_Hoja
            cmd.Parameters.Add(parametro)

            Dim resgistrosActualizados As Integer 'Se crea la variable "resgistrosActualizados"

            Try
                resgistrosActualizados = cmd.ExecuteNonQuery() 'Se solicita el # de filas afectadas.
                'MsgBox("Detalle agregado correctamente.", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("No se pudo agregar el detalle", MsgBoxStyle.Critical)
                Throw New Exception("El detalle no se agrego")

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
