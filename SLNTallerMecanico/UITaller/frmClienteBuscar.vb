Imports BEUTaller
Imports BLTaller
Public Class frmClienteBuscar
    Public cliente As New BEUCliente
    Private Sub frmBuscarCliente_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If txtNombreResultado.Text = "" Or txtCedulaResultado.Text = "" Then
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
        cliente.Id_Cliente = Integer.MinValue
        cliente.Nombre = String.Empty
        cliente.Apellido = String.Empty
        If txtCedula.Text = "" Then
            MessageBox.Show("Ingrese la cedula o nombre completo del cliente.")
        Else
            cliente.Id_Cliente = txtCedula.Text
            cliente = New BLTaller.BLCliente().SP_SELECT_CLIENTE(cliente)
            txtNombreResultado.Text = cliente.Nombre & " " & cliente.Apellido
            txtCedulaResultado.Text = cliente.Id_Cliente
            txtCedula.Text = ""
        End If

    End Sub
End Class