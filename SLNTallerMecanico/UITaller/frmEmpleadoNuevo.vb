Public Class frmEmpleadoNuevo

    Private Sub frmEmpleadoNuevo_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If txtNombre.Text = "" Or txtApellido.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Rellene todos los campos obligatorios antes de continuar.")
        End If
    End Sub
End Class