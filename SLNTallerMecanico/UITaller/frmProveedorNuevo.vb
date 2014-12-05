Imports BLTaller
Imports BEUTaller
Public Class frmProveedorNuevo
    Private proveedor As New BEUProveedor
    Private blproveedor As New BLProveedor
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If txtNombre.Text = "" Or txtPais.Text = "" Or txtTelefono.Text = "" Then
            MessageBox.Show("Rellene los campos obligatorios antes de continuar.")
        Else
            proveedor.Id_Proveedor = txtCedulaJuridica.Text
            proveedor.Nombre = txtNombre.Text
            proveedor.Apellido = txtApellido.Text
            proveedor.Pais = txtPais.Text
            proveedor.Provincia = txtProvincia.Text
            proveedor.Telefono = txtTelefono.Text
            proveedor.Direccion = txtDireccion.Text
            If blproveedor.SP_PROVEEDOR_NUEVO(proveedor) Then
                Me.Close()
            End If
        End If
    End Sub
End Class