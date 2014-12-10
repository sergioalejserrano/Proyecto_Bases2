Imports BEUTaller
Imports Oracle.DataAccess.Client
Imports System.Configuration

Public Class DAOStock
    Private resultado As Boolean
    Private vloComando As OracleCommand
    Private usuario As String = DAOEmpleado.usuario
    Private pass As String = DAOEmpleado.pass
    Private conectar As New DAOConexion

#Region "Agregar Repuesto"
    Function SP_STOCK_NUEVO(ByVal repuesto As BEUStock) As Boolean
        Try
            conectar.GetConexion(usuario, pass)
        Catch ex As Exception
            MsgBox("No se pudo conectar al servidor de bd...", MsgBoxStyle.Critical)
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        Try
            Dim sql As String = "SP_STOCK_NUEVO"

            Dim cmd As New OracleCommand(sql, conectar.vloconnection)
            cmd.CommandType = CommandType.StoredProcedure

            Dim parametro As New OracleParameter("NOMBRE", OracleDbType.Varchar2)
            parametro.Value = repuesto.Nombre
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("CANTIDAD", OracleDbType.Int32)
            parametro.Value = repuesto.Cantidad
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("PRECIO", OracleDbType.Int32)
            parametro.Value = repuesto.Precio
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("ID_PROVEEDOR", OracleDbType.Int32)
            parametro.Value = repuesto.Id_Proveedor
            cmd.Parameters.Add(parametro)

            Dim resgistrosActualizados As Integer

            Try
                resgistrosActualizados = cmd.ExecuteNonQuery()
                MsgBox("Repuesto agregado correctamente.", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("No se pudo agregar el repuesto", MsgBoxStyle.Critical)
                Throw New Exception("Repuesto no se agrego")

            End Try
            If resgistrosActualizados = 0 Then
                resultado = True
            End If
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        conectar.CloseConexion()
        Return resultado
    End Function
#End Region

#Region "Sumar y Restar"
    Function SP_RESTAR_STOCK(ByVal repuesto As BEUStock, ByVal cantidad As Integer) As Boolean
        Try
            conectar.GetConexion(usuario, pass)
        Catch ex As Exception
            MsgBox("No se pudo conectar al servidor de bd...", MsgBoxStyle.Critical)
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        Try
            Dim sql As String = "SP_RESTAR_STOCK"

            Dim cmd As New OracleCommand(sql, conectar.vloconnection)
            cmd.CommandType = CommandType.StoredProcedure

            Dim parametro As New OracleParameter("P_ID_CLIENTE", OracleDbType.Int32)
            parametro.Value = repuesto.Id_Repuesto
            cmd.Parameters.Add(parametro)

            parametro = New OracleParameter("P_CANTIDAD", OracleDbType.Int32)
            parametro.Value = cantidad
            cmd.Parameters.Add(parametro)

            Dim resgistrosActualizados As Integer

            Try
                resgistrosActualizados = cmd.ExecuteNonQuery()
                'MsgBox("Repuesto agregado correctamente.", MsgBoxStyle.Information)
            Catch ex As Exception
                ' MsgBox("No se pudo agregar el repuesto", MsgBoxStyle.Critical)
                Throw New Exception("Repuesto no se resto")

            End Try
            If resgistrosActualizados = 0 Then
                resultado = True
            End If
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        conectar.CloseConexion()
            Return resultado
    End Function
#End Region

#Region "Select Stock"
    Function SP_SELECT_STOCK(ByVal repuesto As BEUStock) As BEUStock
        Try
            conectar.GetConexion(usuario, pass)
        Catch ex As Exception
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        vloComando = New OracleCommand("SP_SELECT_STOCK", conectar.vloconnection)
        vloComando.CommandType = CommandType.StoredProcedure

        Dim parametro As New OracleParameter("P_ID_REPUESTO", OracleDbType.Int32)
        parametro.Value = repuesto.Id_Repuesto
        parametro.Direction = ParameterDirection.Input
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("P_NOMBRE", OracleDbType.Varchar2)
        parametro.Value = repuesto.Nombre
        parametro.Direction = ParameterDirection.Output
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("P_CANTIDAD", OracleDbType.Int32)
        parametro.Value = Nothing
        parametro.Direction = ParameterDirection.Output
        'parametro.Value = Nothing
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("P_PRECIO", OracleDbType.Int32)
        parametro.Value = Nothing
        parametro.Direction = ParameterDirection.Output
        'parametro.Value = Nothing
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        parametro = New OracleParameter("P_ID_PROVEEDOR", OracleDbType.Int32)
        parametro.Value = Nothing
        parametro.Direction = ParameterDirection.Output
        'parametro.Value = Nothing
        parametro.Size = 200
        vloComando.Parameters.Add(parametro)

        vloComando.ExecuteNonQuery()
        repuesto.Id_Repuesto = Convert.ToInt32(vloComando.Parameters("P_ID_REPUESTO").Value.ToString())
        repuesto.Nombre = vloComando.Parameters("P_NOMBRE").Value.ToString
        repuesto.Cantidad = Convert.ToInt32(vloComando.Parameters("P_CANTIDAD").Value.ToString())
        repuesto.Precio = Convert.ToInt32(vloComando.Parameters("P_PRECIO").Value.ToString())
        repuesto.Id_Proveedor = Convert.ToInt32(vloComando.Parameters("P_ID_PROVEEDOR").Value.ToString())
        Return repuesto
    End Function
#End Region

#Region "Borrar Repuesto"
    Function SP_BORRAR_STOCK(ByVal repuesto As BEUStock) As Boolean
        Try
            conectar.GetConexion(usuario, pass)
        Catch ex As Exception
            MsgBox("No se pudo conectar al servidor de bd...", MsgBoxStyle.Critical)
            Throw New Exception("No se pudo conectar al servidor de bd...")
        End Try
        Try
            Dim sql As String = "SP_BORRAR_STOCK"

            Dim cmd As New OracleCommand(sql, conectar.vloconnection)
            cmd.CommandType = CommandType.StoredProcedure

            Dim parametro As New OracleParameter("AID_REPUESTO", OracleDbType.Int32)
            parametro.Value = repuesto.Id_Repuesto
            cmd.Parameters.Add(parametro)

            Dim resgistrosActualizados As Integer

            Try
                resgistrosActualizados = cmd.ExecuteNonQuery()
                MsgBox("Repuesto agregado correctamente.", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("No se pudo agregar el repuesto", MsgBoxStyle.Critical)
                Throw New Exception("Repuesto no se agrego")

            End Try
            If resgistrosActualizados = 0 Then
                resultado = True
            End If
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        conectar.CloseConexion()
        Return resultado
    End Function
#End Region
End Class
