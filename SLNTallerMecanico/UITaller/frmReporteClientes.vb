Public Class frmReporteClientes

    Private Sub frmReporteClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DTSReporteClientes.CLIENTE' Puede moverla o quitarla según sea necesario.
        Me.CLIENTETableAdapter.Fill(Me.DTSReporteClientes.CLIENTE)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class