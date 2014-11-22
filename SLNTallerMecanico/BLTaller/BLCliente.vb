Imports System.Data
Imports DAOTaller
Imports BEUTaller

Public Class BLCliente
    Public resultado As Boolean

    Function SP_CLIENTE_NUEVO(ByVal cliente As BEUCliente) As Boolean
        Try
            resultado = New DAOTaller.DAOCliente().SP_CLIENTE_NUEVO(cliente)
        Catch ex As Exception

        End Try
        Return resultado
    End Function
End Class
