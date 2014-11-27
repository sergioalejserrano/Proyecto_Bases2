Public Class frmProveedorNuevo

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If txtNombre.Text = "" Or txtPais.Text = "" Or txtTelefono.Text = "" Then
            MessageBox.Show("Rellene los campos obligatorios antes de continuar.")
        End If
    End Sub
End Class