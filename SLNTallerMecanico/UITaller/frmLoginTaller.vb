Imports BEUTaller
Imports BLTaller
Public Class frmLoginTaller

    Public Shared userlogon As String
    Public cliente As New BEUEmpleado
    Public Shared usuario As String
    Public Shared pass As String
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim validapass As New BLEmpleado

        Dim LISTEMP As String
        If txtUsuario.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Por favor complete los campos requeridos", MsgBoxStyle.OkOnly, MessageBoxIcon.Error)
        Else

            cliente.USERNAME = txtUsuario.Text.ToUpper
            cliente.Contrasena = txtPassword.Text

            LISTEMP = New BLTaller.BLEmpleado().SP_INICIO_SESION(cliente, cliente.USERNAME, cliente.Contrasena)

            If LISTEMP = "Administrativo" Then
                userlogon = txtUsuario.Text
                frmMDITaller.tsmConectarse.Enabled = False
                frmMDITaller.tsmNuevo.Enabled = True
                frmMDITaller.tsmMantenimiento.Enabled = True
                frmMDITaller.tsmReportes.Enabled = True
                frmMDITaller.tsmDesconectarse.Visible = True
                frmMDITaller.tsmConectarse.Visible = False
                Me.Close()
            ElseIf LISTEMP = "Mecanico" Then
                userlogon = txtUsuario.Text
                frmMDITaller.tsmConectarse.Enabled = False
                'frmMDITaller.tsmNuevo.Enabled = True
                'frmMDITaller.tsmMantenimiento.Enabled = True
                frmMDITaller.tsmReportes.Enabled = True
                frmMDITaller.tsmDesconectarse.Visible = True
                frmMDITaller.tsmConectarse.Visible = False
                Me.Close()
            ElseIf LISTEMP = "Secretario" Then
                userlogon = txtUsuario.Text
                frmMDITaller.tsmConectarse.Enabled = False
                frmMDITaller.tsmNuevo.Enabled = True
                frmMDITaller.tsmMantenimiento.Enabled = True
                'frmMDITaller.tsmReportes.Enabled = True
                frmMDITaller.tsmDesconectarse.Visible = True
                frmMDITaller.tsmConectarse.Visible = False
                Me.Close()
            ElseIf LISTEMP = "Contador" Then
                userlogon = txtUsuario.Text
                frmMDITaller.tsmConectarse.Enabled = False
                'frmMDITaller.tsmNuevo.Enabled = True
                'frmMDITaller.tsmMantenimiento.Enabled = True
                'frmMDITaller.tsmReportes.Enabled = True
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

    'Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
    '    Dim Sep As Char
    '    If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Sep) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    'End Sub
End Class
