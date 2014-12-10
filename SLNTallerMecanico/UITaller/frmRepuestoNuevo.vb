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

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecio.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

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