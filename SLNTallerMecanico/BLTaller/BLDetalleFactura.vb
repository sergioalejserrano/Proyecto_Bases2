Imports DAOTaller
Imports BEUTaller
Imports Oracle.DataAccess.Client

Public Class BLDetalleFactura
    Private resultado As Boolean
    Private dt As DataTable
    Function SP_DETALLE_FACTURA(ByVal detalle As BEUDetalleFactura) As Boolean
        Try
            resultado = New DAOTaller.DAODetalleFactura().SP_DETALLE_FACTURA_NUEVO(detalle)
        Catch ex As Exception

        End Try
        Return resultado
    End Function

    Function SP_ACTUALIZAR_DETALLE(ByVal detalle As BEUDetalleFactura) As Boolean
        Try
            resultado = New DAOTaller.DAODetalleFactura().SP_ACTUALIZAR_DETALLE(detalle)
        Catch ex As Exception

        End Try
        Return resultado
    End Function

    Function SP_BORRAR_DETALLE(ByVal detalle As BEUDetalleFactura) As Boolean
        Try
            resultado = New DAOTaller.DAODetalleFactura().SP_BORRAR_DETALLE(detalle)
        Catch ex As Exception

        End Try
        Return resultado
    End Function

    Function SP_SELECT_DETALLE(ByVal factura As BEUFactura) As DataTable
        Try
            dt = New DAOTaller.DAODetalleFactura().SP_SELECT_DETALLE(factura)
        Catch ex As Exception

        End Try
        Return dt
    End Function
End Class
