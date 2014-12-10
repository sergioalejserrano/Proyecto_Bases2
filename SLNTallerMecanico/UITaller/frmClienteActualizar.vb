
Imports BEUTaller
Imports BLTaller
Public Class frmClienteActualizar
    Public cliente As New BEUCliente
    Public resultado As Boolean
    Private Sub btnActulizar_Click(sender As Object, e As EventArgs) Handles btnActulizar.Click
        If txtNombre.Text = "" Or txtId_Cliente.Text = "" Or txtApellido.Text = "" Or txtTelefono.Text = "" Then
            MessageBox.Show("Rellene los campso obligatorios antes de continuar")
        Else
            cliente.Id_Cliente = txtId_Cliente.Text
            cliente.Nombre = txtNombre.Text
            cliente.Apellido = txtApellido.Text
            cliente.Direccion = txtDireccion.Text
            cliente.Telefono = txtTelefono.Text
            cliente.email = txtEmail.Text
            resultado = New BLTaller.BLCliente().SP_ACTUALIZAR_CLIENTE(cliente)
        End If
    End Sub

    Private Sub txtId_Cliente_Leave(sender As Object, e As EventArgs) Handles txtId_Cliente.Leave
        cliente.Nombre = String.Empty
        cliente.Apellido = String.Empty
        cliente.Direccion = String.Empty
        cliente.Telefono = String.Empty
        cliente.email = String.Empty
        cliente.Id_Cliente = txtId_Cliente.Text
        cliente = New BLTaller.BLCliente().SP_SELECT_CLIENTE(cliente)
        txtNombre.Text = cliente.Nombre
        txtApellido.Text = cliente.Apellido
        txtDireccion.Text = cliente.Telefono
        txtTelefono.Text = cliente.Telefono
        txtEmail.Text = cliente.email
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtNombre.Text = "" Or txtId_Cliente.Text = "" Or txtApellido.Text = "" Or txtTelefono.Text = "" Then
            MessageBox.Show("Ingrese un id valido para continuar.")
        Else
            cliente.Id_Cliente = txtId_Cliente.Text
            resultado = New BLTaller.BLCliente().SP_BORRAR_CLIENTE(cliente)
        End If
    End Sub

    Private Sub txtId_Cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtId_Cliente.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
End Class
