
Imports BEUTaller
Imports BLTaller
Public Class frmLoginTaller

    Public Shared userlogon As String
    Public cliente As New BEUEmpleado

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim validapass As New BLEmpleado
        cliente.Id_Empleado = txtUsuario.Text
        cliente.Contrasena = txtPassword.Text
        Dim LISTEMP As String

        If txtUsuario.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Por complete los campos requeridos", MsgBoxStyle.OkOnly, MessageBoxIcon.Error)
        Else
            LISTEMP = New BLTaller.BLEmpleado().SP_INICIO_SESION(cliente)

            If LISTEMP = "Administrador" Then
                userlogon = txtUsuario.Text
                frmMDITaller.tsmConectarse.Enabled = False
                frmMDITaller.tsmNuevo.Enabled = True
                frmMDITaller.tsmMantenimiento.Enabled = True
                frmMDITaller.tsmReportes.Enabled = True
                frmMDITaller.tsmDesconectarse.Visible = True
                frmMDITaller.tsmConectarse.Visible = False
                Me.Close()
            Else
                MessageBox.Show("Verifique usuario o su contraseña es incorrecta.")
            End If

        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
