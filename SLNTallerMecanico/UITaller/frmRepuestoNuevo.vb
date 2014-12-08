Imports BEUTaller
Imports BLTaller
Public Class frmRepuestoNuevo
    Dim ventana As frmProveedorBuscar = New frmProveedorBuscar
    Public repuesto As New BEUStock
    Private blstock As New BLStock
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
            repuesto.Id_Proveedor = ventana.proveedor.Id_Proveedor
            If blstock.SP_STOCK_NUEVO(repuesto) Then
                txtNombre.Text = ""
                txtPrecio.Text = ""
                txtCantidad.Text = ""
                txtProveedor.Text = ""
            End If
        End If
    End Sub
End Class