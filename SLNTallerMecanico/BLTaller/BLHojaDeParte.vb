Imports DAOTaller
Imports BEUTaller

Public Class BLHojaDeParte
    Private hoja As New BEUHojaDeParte
    Function SP_NUM_HOJA() As BEUHojaDeParte
        Try
            hoja = New DAOTaller.DAOHojaDeParte().SP_NUM_HOJA()
        Catch ex As Exception

        End Try
        Return hoja
    End Function
End Class
