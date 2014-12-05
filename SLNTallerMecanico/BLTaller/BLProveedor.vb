Imports DAOTaller
Imports BEUTaller
Public Class BLProveedor
    Private resultado As Boolean
    Function SP_BUSCAR_PROVEEDOR(ByVal proveedor As BEUProveedor) As BEUProveedor
        Try
            proveedor = New DAOTaller.DAOProveedor().SP_BUSCAR_PROVEEDOR(proveedor)
        Catch ex As Exception

        End Try
        Return proveedor
    End Function

    Function SP_PROVEEDOR_NUEVO(ByVal proveedor As BEUProveedor) As Boolean
        Try
            resultado = New DAOTaller.DAOProveedor().SP_PROVEEDOR_NUEVO(proveedor)
        Catch ex As Exception

        End Try
        Return resultado
    End Function
End Class
