Imports DAOTaller
Imports BEUTaller

Public Class BLFactura
    Private factura As New BEUFactura
    Private resultado As Boolean

    Function SP_NUM_FACTURA() As BEUFactura
        Try
            factura = New DAOTaller.DAOFactura().SP_NUM_FACTURA()
        Catch ex As Exception

        End Try
        Return factura
    End Function

    Function SP_FACTURA_NUEVO(ByVal factura As BEUFactura) As Boolean
        Try
            resultado = New DAOTaller.DAOFactura().SP_FACTURA_NUEVO(factura)
        Catch ex As Exception

        End Try
        Return resultado
    End Function
End Class
