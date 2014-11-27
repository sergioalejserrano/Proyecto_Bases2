Public Class frmRepuestoNuevo

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim ventana As frmProveedorBuscar = New frmProveedorBuscar
        ventana.ShowDialog()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If txtNombre.Text = "" Or txtCantidad.Text = "" Or txtPrecio.Text = "" Or txtProveedor.Text = "" Then
            MessageBox.Show("Rellene todos los campos obligatorios antes de continuar.")
        End If
    End Sub
End Class