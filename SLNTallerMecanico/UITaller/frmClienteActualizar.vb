
Imports BEUTaller
Imports BLTaller
Public Class frmClienteActualizar
    Public cliente As New BEUCliente
    Public resultado As Boolean
    Private Sub btnActulizar_Click(sender As Object, e As EventArgs) Handles btnActulizar.Click
        cliente.Id_Cliente = txtId_Cliente.Text
        cliente.Nombre = txtNombre.Text
        cliente.Apellido = txtApellido.Text
        cliente.Direccion = txtDireccion.Text
        cliente.Telefono = txtTelefono.Text
        cliente.email = txtEmail.Text
        resultado = New BLTaller.BLCliente().SP_ACTUALIZAR_CLIENTE(cliente)
    End Sub
End Class
