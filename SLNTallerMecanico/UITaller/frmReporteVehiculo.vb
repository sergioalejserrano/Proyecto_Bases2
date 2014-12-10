Public Class frmReporteVehiculo

    Private Sub frmReporteVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet2.VEHICULO' Puede moverla o quitarla según sea necesario.
        Me.VEHICULOTableAdapter.Fill(Me.DataSet2.VEHICULO)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class