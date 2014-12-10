Public Class frmReporteProveedor

    Private Sub frmReporteProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet3.PROVEEDOR' Puede moverla o quitarla según sea necesario.
        Me.PROVEEDORTableAdapter.Fill(Me.DataSet3.PROVEEDOR)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class