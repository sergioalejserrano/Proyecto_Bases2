Imports BLTaller
Imports BEUTaller
Public Class frmProveedorNuevo
    Private proveedor As New BEUProveedor
    Private blproveedor As New BLProveedor
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If txtNombre.Text = "" Or txtPais.Text = "" Or txtTelefono.Text = "" Or txtCedulaJuridica.Text = "" Then
            MessageBox.Show("Rellene los campos obligatorios antes de continuar.")
        Else
            proveedor.Id_Proveedor = txtCedulaJuridica.Text
            proveedor.Nombre = txtNombre.Text
            proveedor.Apellido = txtApellido.Text
            proveedor.Pais = txtPais.Text
            proveedor.Provincia = txtProvincia.Text
            proveedor.Telefono = txtTelefono.Text
            proveedor.Direccion = txtDireccion.Text
            If Me.Text = "Actualizar Proveedor" Then
                If blproveedor.SP_ACTUALIZAR_PROVEEDOR(proveedor) Then
                    Me.Close()
                End If
            Else
                If blproveedor.SP_PROVEEDOR_NUEVO(proveedor) Then
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub txtCedulaJuridica_Leave(sender As Object, e As EventArgs) Handles txtCedulaJuridica.Leave
        proveedor.Nombre = String.Empty
        proveedor.Apellido = String.Empty
        proveedor.Direccion = String.Empty
        proveedor.Pais = String.Empty
        proveedor.Provincia = String.Empty
        proveedor.Telefono = String.Empty
        proveedor.Id_Proveedor = txtCedulaJuridica.Text
        proveedor = New BLTaller.BLProveedor().SP_SELECT_PROVEEDOR(proveedor)
        txtNombre.Text = proveedor.Nombre
        txtApellido.Text = proveedor.Apellido
        txtPais.Text = proveedor.Pais
        txtProvincia.Text = proveedor.Provincia
        txtTelefono.Text = proveedor.Telefono
        txtDireccion.Text = proveedor.Direccion
        If (txtNombre.Text <> "" And Me.Text = "Nuevo Proveedor") Or (txtNombre.Text = "" And Me.Text = "Actualizar Proveedor") Then
            txtNombre.Enabled = False
            txtApellido.Enabled = False
            txtPais.Enabled = False
            txtProvincia.Enabled = False
            txtTelefono.Enabled = False
            btnRegistrar.Enabled = False
        Else
            txtNombre.Enabled = True
            txtApellido.Enabled = True
            txtPais.Enabled = True
            txtProvincia.Enabled = True
            txtTelefono.Enabled = True
            btnRegistrar.Enabled = True
        End If
    End Sub

    Private Sub frmProveedorNuevo_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Me.Text = "Actualizar Proveedor" Then
            txtNombre.Enabled = False
            txtApellido.Enabled = False
            txtPais.Enabled = False
            txtProvincia.Enabled = False
            txtTelefono.Enabled = False
            btnRegistrar.Enabled = False
        Else
            txtNombre.Enabled = True
            txtApellido.Enabled = True
            txtPais.Enabled = True
            txtProvincia.Enabled = True
            txtTelefono.Enabled = True
            btnRegistrar.Enabled = True
        End If
    End Sub
End Class