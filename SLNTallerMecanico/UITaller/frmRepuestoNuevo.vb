Imports BEUTaller
Imports BLTaller
Public Class frmRepuestoNuevo
    Dim ventana As frmProveedorBuscar = New frmProveedorBuscar
    Public repuesto As New BEUStock
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        ventana.ShowDialog()
        txtProveedor.Text = ventana.proveedor.Nombre & " " & ventana.proveedor.Apellido
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If txtNombre.Text = "" Or txtCantidad.Text = "" Or txtPrecio.Text = "" Or txtProveedor.Text = "" Then
            MessageBox.Show("Rellene todos los campos obligatorios antes de continuar.")
        Else
            repuesto.Nombre = txtNombre.Text
            repuesto.Precio = txtPrecio.Text
            repuesto.Cantidad = txtCantidad.Text
        End If
    End Sub
End Class