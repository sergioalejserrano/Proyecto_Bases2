Imports BEUTaller
Imports BLTaller

Public Class frmVehiculoBuscar
    Public vehiculo As New BEUVehiculo
    Private cliente As New BEUCliente
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        vehiculo.VIN = String.Empty
        vehiculo.Placa = String.Empty
        vehiculo.Marca = String.Empty
        vehiculo.Modelo = String.Empty
        vehiculo.Anno = String.Empty
        vehiculo.Color = String.Empty
        vehiculo.Id_Cliente = Integer.MinValue
        If txtPlaca.Text = "" Then
            MessageBox.Show("Ingrese la placa del vehiculo para realizar una busqueda.")
        Else
            vehiculo.Placa = txtPlaca.Text
            vehiculo = New BLTaller.BLVehiculo().SP_BUSCAR_VEHICULO(vehiculo)
            cliente.Id_Cliente = vehiculo.Id_Cliente
            cliente = New BLTaller.BLCliente().SP_SELECT_CLIENTE(cliente)
            txtClienteResultado.Text = cliente.Nombre & " " & cliente.Apellido
            txtVINResultado.Text = vehiculo.VIN
            txtPlaca.Text = ""
        End If
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If txtClienteResultado.Text = "" Or txtVINResultado.Text = "" Then
            MessageBox.Show("Realice una búsqueda antes de continuar.")
        Else
            vehiculo.VIN = txtVINResultado.Text
            Me.Close()
        End If
    End Sub
End Class