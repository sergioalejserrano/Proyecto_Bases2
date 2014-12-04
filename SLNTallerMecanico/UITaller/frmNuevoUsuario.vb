Public Class frmNuevoUsuario
    Public resultado As Boolean

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtUsuario.Text = "" Or txtPass.Text = "" Then
            MsgBox("Por favor complete los campos requeridos", MsgBoxStyle.OkOnly, MessageBoxIcon.Error)
        Else
            resultado = New BLTaller.BLEmpleado().SP_CREAR_USUARIO(txtNombre.Text, txtApellido.Text, (cmbUsuario.Text + txtUsuario.Text), txtPass.Text, cmbTipo.Text, cmbEstado.Text)
        End If
    End Sub
End Class