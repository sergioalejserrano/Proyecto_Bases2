Imports BEUTaller

Public Class frmVehiculoNuevo
    Private vehiculo As New BEUVehiculo
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim ventana As frmClienteBuscar = New frmClienteBuscar
        ventana.ShowDialog()
    End Sub


    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If txtVIN.Text = "" Or txtPlaca.Text = "" Or txtMarca.Text = "" Or txtModelo.Text = "" Then
            MessageBox.Show("Rellene todos los datos obligatorios antes de continuar.")
        Else
            vehiculo.VIN = txtVIN.Text
            vehiculo.Placa = txtPlaca.Text
            vehiculo.Marca = txtMarca.Text
            vehiculo.Modelo = txtModelo.Text
            vehiculo.Anno = txtAno.Text
            vehiculo.Color = txtColor.Text

        End If
    End Sub
End Class