Imports BEUTaller
Imports BLTaller

Public Class frmEmpleadoBuscar
    Public empleado As New BEUEmpleado

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        empleado.ID_EMPLEADO = String.Empty
        empleado.Nombre = String.Empty
        empleado.Apellido = String.Empty
        If txtCedula.Text = "" Then
            MessageBox.Show("Ingrese la cedula del empleado para realizar una busqueda.")
        Else
            empleado.ID_EMPLEADO = txtCedula.Text
            empleado = New BLTaller.BLEmpleado().SP_SELECT_EMPLEADO(empleado)
            txtNombreResultado.Text = empleado.Nombre & " " & empleado.Apellido
            txtTipoResultado.Text = empleado.Tipo
            txtCedula.Text = ""
        End If
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        If txtNombreResultado.Text = "" Or txtTipoResultado.Text = "" Then
            MessageBox.Show("Realice una búsqueda antes de continuar.")
        Else
            empleado.Tipo = txtTipoResultado.Text
            Dim lsnombre As New List(Of String)
            Dim nombre As String
            For Each nombre In txtNombreResultado.Text.Split(" ")
                lsnombre.Add(nombre)
            Next
            empleado.Nombre = lsnombre.Item(0)
            empleado.Apellido = lsnombre.Item(1)
            Me.Close()
        End If
    End Sub
End Class