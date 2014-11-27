
Imports BEUTaller
Imports BLTaller
Public Class frmClienteBorrar
    Public cliente As New BEUCliente
    Public resultado As Boolean
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If txtID_CLIENTE.Text = "" Then
            MessageBox.Show("Rellene los campos obligatorios antes de continuar.")
        Else
            cliente.Id_Cliente = txtID_CLIENTE.Text
            resultado = New BLTaller.BLCliente().SP_BORRAR_CLIENTE(cliente)
        End If
    End Sub
End Class
