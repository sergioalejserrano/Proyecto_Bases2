Public Class frmProveedorBuscar

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If txtNombreResultado.Text = "" And txtCedulaResultado.Text = "" Then
            MessageBox.Show("Realice una búsqueda para continuar.")
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtNombre.Text = "" And txtIdProveedor.Text = "" Then
            MessageBox.Show("Ingrese el nombre o el id del proveedor para la realizar la búsqueda.")
        End If
    End Sub
End Class