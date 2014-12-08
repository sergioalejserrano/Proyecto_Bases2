Imports DAOTaller
Imports BEUTaller

Public Class BLHojaDeParte
    Private hoja As New BEUHojaDeParte
    Private resultado As Boolean
    Function SP_NUM_HOJA() As BEUHojaDeParte
        Try
            hoja = New DAOTaller.DAOHojaDeParte().SP_NUM_HOJA()
        Catch ex As Exception

        End Try
        Return hoja
    End Function

    Function SP_HOJADEPARTE_NUEVO(ByVal hoja As BEUHojaDeParte) As Boolean
        Try
            resultado = New DAOTaller.DAOHojaDeParte().SP_HOJADEPARTE_NUEVO(hoja)
        Catch ex As Exception

        End Try
        Return resultado
    End Function
End Class
