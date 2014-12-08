Public Class frmReporteEmpleado

    Private Sub frmReporteEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ReporteEmpleados.EMPLEADO' Puede moverla o quitarla según sea necesario.
        Me.EMPLEADOTableAdapter.Fill(Me.ReporteEmpleados.EMPLEADO)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class