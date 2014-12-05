Imports DAOTaller
Imports BEUTaller

Public Class BLVehiculo
    Public resultado As Boolean

    Function SP_VEHICULO_NUEVO(ByVal vehiculo As BEUVehiculo) As Boolean
        Try
            resultado = New DAOTaller.DAOVehiculo().SP_VEHICULO_NUEVO(vehiculo)
        Catch ex As Exception

        End Try
        Return resultado
    End Function

End Class
