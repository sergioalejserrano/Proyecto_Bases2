Imports DAOTaller
Imports BEUTaller

Public Class BLVehiculo
    Public resultado As Boolean
    Private vehiculo As New BEUVehiculo

    Function SP_VEHICULO_NUEVO(ByVal vehiculo As BEUVehiculo) As Boolean
        Try
            resultado = New DAOTaller.DAOVehiculo().SP_VEHICULO_NUEVO(vehiculo)
        Catch ex As Exception

        End Try
        Return resultado
    End Function

    Function SP_ACTUALIZAR_VEHICULO(ByVal vehiculo As BEUVehiculo) As Boolean
        Try
            resultado = New DAOTaller.DAOVehiculo().SP_ACTUALIZAR_VEHICULO(vehiculo)
        Catch ex As Exception

        End Try
        Return resultado
    End Function

    Function SP_BORRAR_VEHICULO(ByVal VEHICULO As BEUVehiculo) As Boolean
        Try
            resultado = New DAOTaller.DAOVehiculo().SP_BORRAR_VEHICULO(VEHICULO)
        Catch ex As Exception

        End Try
        Return resultado
    End Function
    Function SP_SELECT_VEHICULO(ByVal vehiculo As BEUVehiculo) As BEUVehiculo
        Try
            vehiculo = New DAOTaller.DAOVehiculo().SP_SELECT_VEHICULO(vehiculo)
        Catch ex As Exception

        End Try
        Return vehiculo
    End Function

    Function SP_BUSCAR_VEHICULO(ByVal vehiculo As BEUVehiculo) As BEUVehiculo
        Try
            vehiculo = New DAOTaller.DAOVehiculo().SP_BUSCAR_VEHICULO(vehiculo)
        Catch ex As Exception

        End Try
        Return vehiculo

    End Function
End Class
