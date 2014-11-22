Imports System.Data.SqlClient
Imports System.Data
Imports BEUTaller

Public Class DAOCliente
    Public resultado As Boolean = False
    'Public conex As SqlConnection
    Public conex As DAOConexion

#Region "Agregar Cliente"
    Function SP_CLIENTE_NUEVO(ByVal cliente As BEUCliente) As Boolean
        Try
            Dim sql As String = "SP_CLIENTE_NUEVO "
            If conex.AbrirConexion() Then
                Dim cmd As New SqlCommand(sql, conex.conex)
                cmd.CommandType = CommandType.StoredProcedure
                Dim parametro As New SqlParameter("ID_CLIENTE", SqlDbType.Int)
                parametro.Value = cliente.Id_Cliente
                cmd.Parameters.Add(parametro)

                parametro = New SqlParameter("NOMBRE", SqlDbType.NVarChar)
                parametro.Value = cliente.Nombre
                cmd.Parameters.Add(parametro)

                parametro = New SqlParameter("APELLIDO", SqlDbType.NVarChar)
                parametro.Value = cliente.Apellido
                cmd.Parameters.Add(parametro)

                parametro = New SqlParameter("DIRECCION", SqlDbType.NVarChar)
                parametro.Value = cliente.Direccion
                cmd.Parameters.Add(parametro)

                parametro = New SqlParameter("TELEFONO", SqlDbType.NVarChar)
                parametro.Value = cliente.Telefono
                cmd.Parameters.Add(parametro)

                parametro = New SqlParameter("EMAIL", SqlDbType.NVarChar)
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
            End If
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        conex.CerrarConexion()
        Return resultado
    End Function
#End Region
End Class
