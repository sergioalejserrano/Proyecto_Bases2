
Imports BEUTaller
Imports BLTaller
Public Class frmClienteNuevo
    Public cliente As New BEUCliente
    Public resultado As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtId_Cliente.Text = "" Or txtNombre.Text = "" Or txtApellido.Text = "" Or txtTelefono.Text = "" Then
            MessageBox.Show("Rellene los campos obligatorios para continuar.")
        Else
            cliente.Id_Cliente = txtId_Cliente.Text
            cliente.Nombre = txtNombre.Text
            cliente.Apellido = txtApellido.Text
            cliente.Direccion = txtDireccion.Text
            cliente.Telefono = txtTelefono.Text
            cliente.email = txtEmail.Text
            resultado = New BLTaller.BLCliente().SP_CLIENTE_NUEVO(cliente)
            txtId_Cliente.Clear()
            txtNombre.Clear()
            txtApellido.Clear()
            txtDireccion.Clear()
            txtTelefono.Clear()
            txtEmail.Clear()
        End If
    End Sub
    Private Sub txtId_Cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtId_Cliente.KeyPress
        Dim Sep As Char
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Sep) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub btnAgregar_MouseEnter(sender As Object, e As EventArgs) Handles btnAgregar.MouseEnter
        btnAgregar.BackColor = Color.Gray
    End Sub

    Private Sub btnAgregar_MouseLeave(sender As Object, e As EventArgs) Handles btnAgregar.MouseLeave
        btnAgregar.BackColor = Color.White
    End Sub
End Class
