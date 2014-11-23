Imports System.Data.SqlClient
Imports System.Data
Imports BEUTaller
Imports System.Configuration
Imports Oracle.DataAccess.Client


Public Class DAOCliente
    Public resultado As Boolean = False
    'Public conex As SqlConnection
    Public conex As DAOConexion
    Private vloConnection As OracleConnection
    Private vloComando As OracleCommand
#Region "Agregar Cliente"
    Function SP_CLIENTE_NUEVO(ByVal cliente As BEUCliente) As Boolean
        vloConnection = New OracleConnection(ConfigurationManager.ConnectionStrings("OracleConnectionString").ConnectionString) ' se crea la conexion a la bd
        Try
            vloConnection.Open()

        Catch ex As Exception
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        Try
            Dim sql As String = "SP_CLIENTE_NUEVO"
            'If conex.AbrirConexion() Then
            ' Dim cmd As New SqlCommand(sql, conex.conex)
            Dim cmd As New OracleCommand(sql, vloConnection)
            cmd.CommandType = CommandType.StoredProcedure
            Dim parametro As New OracleParameter("ID_CLIENTE", OracleDbType.Int32)
            parametro.Value = cliente.Id_Cliente
            cmd.Parameters.Add(parametro)

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
            Dim resgistrosActualizados As Integer
            Try
                resgistrosActualizados = cmd.ExecuteNonQuery()
                MsgBox("Usuario agregado correctamente.")
            Catch ex As Exception
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
        vloConnection.Close()
        Return resultado
    End Function
#End Region
End Class
