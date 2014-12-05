Imports BEUTaller
Imports BLTaller
Public Class frmClienteBuscar
    Public cliente As New BEUCliente
    Private Sub frmBuscarCliente_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If txtNombreResultado.Text = "" And txtCedulaResultado.Text = "" Then
            MessageBox.Show("Realice una búsqueda antes de continuar.")
        Else
            cliente.Id_Cliente = txtCedulaResultado.Text
            Dim lsnombre As New List(Of String)
            Dim nombre As String
            For Each nombre In txtNombreResultado.Text.Split(" ")
                lsnombre.Add(nombre)
            Next
            cliente.Nombre = lsnombre.Item(0)
            cliente.Apellido = lsnombre.Item(1)
            Me.Close()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'txtNombreResultado.Text = ""
        'txtCedulaResultado.Text = ""
        cliente.Id_Cliente = Integer.MinValue
        cliente.Nombre = String.Empty
        cliente.Apellido = String.Empty
        If txtCedula.Text = "" And txtNombre.Text = "" Then
            MessageBox.Show("Ingrese o la cedula o nombre completo del cliente.")
        ElseIf txtCedula.Text = "" Then
            Dim lsnombre As New List(Of String)
            Dim nombre As String
            For Each nombre In txtNombre.Text.Split(" ")
                lsnombre.Add(nombre)
            Next
            cliente.Nombre = lsnombre.Item(0)
            cliente.Apellido = lsnombre.Item(1)
            cliente = New BLTaller.BLCliente().SP_BUSCAR_CLIENTE(cliente)
            txtNombreResultado.Text = cliente.Nombre & " " & cliente.Apellido
            txtCedulaResultado.Text = cliente.Id_Cliente
            txtNombre.Text = ""
        Else
            cliente.Id_Cliente = txtCedula.Text
            cliente = New BLTaller.BLCliente().SP_BUSCAR_CLIENTE(cliente)
            txtNombreResultado.Text = cliente.Nombre & " " & cliente.Apellido
            txtCedulaResultado.Text = cliente.Id_Cliente
            txtCedula.Text = ""
        End If

    End Sub
End Class