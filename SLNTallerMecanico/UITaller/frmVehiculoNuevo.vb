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
        If txtVIN.Text = "" Or txtPlaca.Text = "" Or txtMarca.Text = "" Or txtModelo.Text = "" Or txtCliente.Text = " " Then
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
            If Me.Text = "Nuevo Vehiculo" Then
                If blvehiculo.SP_VEHICULO_NUEVO(vehiculo) Then
                    'MessageBox.Show("Vehiculo ingresado.")
                    'txtCliente.Text = ""
                    txtColor.Text = ""
                    txtMarca.Text = ""
                    txtModelo.Text = ""
                    txtPlaca.Text = ""
                    txtVIN.Text = ""
                    txtAno.Text = ""
                End If
            Else
                If blvehiculo.SP_ACTUALIZAR_VEHICULO(vehiculo) Then

                End If
            End If
        End If
    End Sub

    Private Sub txtVIN_Leave(sender As Object, e As EventArgs) Handles txtVIN.Leave
        vehiculo.Placa = String.Empty
        vehiculo.Marca = String.Empty
        vehiculo.Modelo = String.Empty
        vehiculo.Anno = String.Empty
        vehiculo.Color = String.Empty
        vehiculo.Id_Cliente = Integer.MinValue
        vehiculo.VIN = txtVIN.Text
        vehiculo = New BLTaller.BLVehiculo().SP_SELECT_VEHICULO(vehiculo)
        txtPlaca.Text = vehiculo.Placa
        txtMarca.Text = vehiculo.Marca
        txtModelo.Text = vehiculo.Modelo
        txtAno.Text = vehiculo.Anno
        txtColor.Text = vehiculo.Color
        If txtAno.Text = "null" Then
            txtAno.Text = ""
        End If
        If txtColor.Text = "null" Then
            txtColor.Text = ""
        End If
        Dim cliente As New BEUCliente
        cliente.Id_Cliente = vehiculo.Id_Cliente
        cliente = New BLTaller.BLCliente().SP_SELECT_CLIENTE(cliente)
        txtCliente.Text = cliente.Nombre & " " & cliente.Apellido
        If (txtPlaca.Text <> "" And Me.Text = "Nuevo Vehiculo") Or (txtPlaca.Text = "" And Me.Text = "Actualizar Vehiculo") Then
            txtPlaca.Enabled = False
            txtMarca.Enabled = False
            txtModelo.Enabled = False
            txtAno.Enabled = False
            txtColor.Enabled = False
            btnBuscar.Enabled = False
            btnRegistrar.Enabled = False
        Else
            txtPlaca.Enabled = True
            txtMarca.Enabled = True
            txtModelo.Enabled = True
            txtAno.Enabled = True
            txtColor.Enabled = True
            btnBuscar.Enabled = True
            btnRegistrar.Enabled = True
        End If
    End Sub

    Private Sub frmVehiculoNuevo_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Me.Text = "Nuevo Vehiculo" Then
            txtPlaca.Enabled = True
            txtMarca.Enabled = True
            txtModelo.Enabled = True
            txtAno.Enabled = True
            txtColor.Enabled = True
            btnBuscar.Enabled = True
            btnRegistrar.Enabled = True
        Else
            txtPlaca.Enabled = False
            txtMarca.Enabled = False
            txtModelo.Enabled = False
            txtAno.Enabled = False
            txtColor.Enabled = False
            btnBuscar.Enabled = False
            btnRegistrar.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtVIN.Text = "" Or txtPlaca.Text = "" Then
            MsgBox("Ingrese un VIN valido.")
        Else
            Dim res As Boolean
            vehiculo.VIN = txtVIN.Text
            res = New BLTaller.BLVehiculo().SP_BORRAR_VEHICULO(vehiculo)
        End If
    End Sub
End Class