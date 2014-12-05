Imports BEUTaller
Imports BLTaller

Public Class frmVehiculoNuevo
    Private vehiculo As New BEUVehiculo
    Dim ventana As frmClienteBuscar = New frmClienteBuscar
    Private blvehiculo As New BLVehiculo
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ventana.ShowDialog()
        txtCliente.Text = ventana.cliente.Nombre & " " & ventana.cliente.Apellido
    End Sub


    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If txtVIN.Text = "" Or txtPlaca.Text = "" Or txtMarca.Text = "" Or txtModelo.Text = "" Or txtCliente.Text = "" Then
            MessageBox.Show("Rellene todos los datos obligatorios antes de continuar.")
        ElseIf txtVIN.TextLength < 17 Then
            MessageBox.Show("Verifique que el VIN posea todos los caracteres.")
        Else
            vehiculo.VIN = txtVIN.Text
            vehiculo.Placa = txtPlaca.Text
            vehiculo.Marca = txtMarca.Text
            vehiculo.Modelo = txtModelo.Text
            vehiculo.Anno = txtAno.Text
            vehiculo.Color = txtColor.Text
            vehiculo.Id_Cliente = ventana.cliente.Id_Cliente
            If blvehiculo.SP_VEHICULO_NUEVO(vehiculo) Then
                'MessageBox.Show("Vehiculo ingresado.")
                txtCliente.Text = ""
                txtColor.Text = ""
                txtMarca.Text = ""
                txtModelo.Text = ""
                txtPlaca.Text = ""
                txtVIN.Text = ""
                txtAno.Text = ""
            Else
                'MessageBox.Show("El vehiculo no pudo ingresarse, intente nuevamente.")
            End If
        End If
    End Sub

End Class