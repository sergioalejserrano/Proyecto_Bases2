Public Class frmReporteFactura

    Private Sub frmReporteFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetFactura.FACTURA' Puede moverla o quitarla según sea necesario.
        Me.FACTURATableAdapter.Fill(Me.DataSetFactura.FACTURA)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class