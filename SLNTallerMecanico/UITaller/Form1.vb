
Imports BEUTaller
Imports BLTaller
Public Class Form1
    Public cliente As New BEUCliente
    Public resultado As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        cliente.Id_Cliente = txtId_Cliente.Text
        cliente.Nombre = txtNombre.Text
        cliente.Apellido = txtApellido.Text
        cliente.Direccion = txtDireccion.Text
        cliente.Telefono = txtTelefono.Text
        cliente.email = txtEmail.Text
        resultado = New BLTaller.BLCliente().SP_CLIENTE_NUEVO(cliente)
    End Sub
End Class
