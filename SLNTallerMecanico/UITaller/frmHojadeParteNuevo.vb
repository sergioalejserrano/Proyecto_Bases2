Imports BLTaller
Imports BEUTaller
Public Class frmHojadeParteNuevo
    Private hoja As New BEUHojaDeParte
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If txtIdEmpleado.Text = "" Or txtVIN.Text = "" Or txtRepuestos.Text = "" Then
            MessageBox.Show("Rellene todos los campos obligatorios antes de continuar.")
            If txtBoxDetalle.Text = "Observaciones:" Then
                MsgBox("No ha ingresado ninguna detalle. ¿Desea continuar?", MsgBoxStyle.YesNoCancel, MessageBoxIcon.Information)
            End If

        End If
    End Sub

    Private Sub frmHojadeParteNuevo_Load(sender As Object, e As EventArgs) Handles Me.Load
        hoja = New BLTaller.BLHojaDeParte().SP_NUM_HOJA()
        lblNumHojaResultado.Text = hoja.Id_Hoja
    End Sub
End Class