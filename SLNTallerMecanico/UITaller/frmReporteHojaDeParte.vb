Public Class frmReporteHojaDeParte

    Private Sub frmReporteHojaDeParte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetHojadeParte.HOJADEPARTE' Puede moverla o quitarla según sea necesario.
        Me.HOJADEPARTETableAdapter.Fill(Me.DataSetHojadeParte.HOJADEPARTE)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class