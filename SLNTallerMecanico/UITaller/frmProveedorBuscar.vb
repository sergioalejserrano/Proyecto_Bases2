Imports BEUTaller
Imports BLTaller

Public Class frmProveedorBuscar
    Public proveedor As New BEUProveedor
    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If txtNombreResultado.Text = "" And txtCedulaResultado.Text = "" Then
            MessageBox.Show("Realice una búsqueda para continuar.")
        Else
            proveedor.Id_Proveedor = txtCedulaResultado.Text
            Dim lsnombre As New List(Of String)
            Dim nombre As String
            For Each nombre In txtNombreResultado.Text.Split(" ")
                lsnombre.Add(nombre)
            Next
            proveedor.Nombre = lsnombre.Item(0)
            proveedor.Apellido = lsnombre.Item(1)
            Me.Close()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        proveedor.Id_Proveedor = Integer.MinValue
        proveedor.Nombre = String.Empty
        proveedor.Apellido = ""
        If txtNombre.Text = "" And txtIdProveedor.Text = "" Then
            MessageBox.Show("Ingrese el nombre o el id del proveedor para la realizar la búsqueda.")
        ElseIf txtIdProveedor.Text = "" Then
            Dim lsnombre As New List(Of String)
            Dim nombre As String
            For Each nombre In txtNombre.Text.Split(" ")
                lsnombre.Add(nombre)
            Next
            proveedor.Nombre = lsnombre.Item(0)
            proveedor.Apellido = lsnombre.Item(1)
            proveedor = New BLTaller.BLProveedor().SP_BUSCAR_PROVEEDOR(proveedor)
            txtNombreResultado.Text = proveedor.Nombre & " " & proveedor.Apellido
            txtCedulaResultado.Text = proveedor.Id_Proveedor
            txtNombre.Text = ""
        Else
            proveedor.Id_Proveedor = txtIdProveedor.Text
            proveedor = New BLTaller.BLProveedor().SP_BUSCAR_PROVEEDOR(proveedor)
            txtNombreResultado.Text = proveedor.Nombre & " " & proveedor.Apellido
            txtCedulaResultado.Text = proveedor.Id_Proveedor
            txtIdProveedor.Text = ""

        End If
    End Sub
End Class