Imports BEUTaller
Imports DAOTaller

Public Class BLStock
    Private resultado As Boolean

    Function SP_STOCK_NUEVO(ByVal repuesto As BEUStock) As Boolean
        Try
            resultado = New DAOTaller.DAOStock().SP_STOCK_NUEVO(repuesto)
        Catch ex As Exception

        End Try
        Return resultado
    End Function

    Function SP_BORRAR_STOCK(ByVal repuesto As BEUStock) As Boolean
        Try
            resultado = New DAOTaller.DAOStock().SP_BORRAR_STOCK(repuesto)
        Catch ex As Exception

        End Try
        Return resultado
    End Function

    Function SP_RESTAR_STOCK(ByVal repuesto As BEUStock, ByVal cantidad As Integer) As Boolean
        Try
            resultado = New DAOTaller.DAOStock().SP_RESTAR_STOCK(repuesto, cantidad)
        Catch ex As Exception

        End Try
        Return resultado
    End Function

    Function SP_SELECT_STOCK(ByVal repuesto As BEUStock) As BEUStock
        Try
            repuesto = New DAOTaller.DAOStock().SP_SELECT_STOCK(repuesto)
        Catch ex As Exception

        End Try
        Return repuesto
    End Function
End Class
