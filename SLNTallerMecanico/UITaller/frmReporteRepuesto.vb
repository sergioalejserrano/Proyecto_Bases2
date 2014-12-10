Public Class frmReporteRepuesto

    Private Sub frmReporteRepuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetRepuesto.STOCK' Puede moverla o quitarla según sea necesario.
        Me.STOCKTableAdapter.Fill(Me.DataSetRepuesto.STOCK)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class