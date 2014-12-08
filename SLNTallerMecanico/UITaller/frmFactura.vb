Imports BLTaller
Imports BEUTaller

Public Class frmFactura
    Public factura As New BEUFactura
    Dim ventana As frmClienteBuscar = New frmClienteBuscar
    Private blfactura As New BLFactura

    Private Sub frmFactura_Load(sender As Object, e As EventArgs) Handles Me.Load
        factura = New BLTaller.BLFactura().SP_NUM_FACTURA()
        txtNumero.Text = factura.Id_Factura
        Dim today As DateTime = DateTime.Today
        txtFecha.Text = today.ToString("d")
        factura.Fecha = today
        Dim total As Integer
        For Renglones As Integer = 0 To DataGridView1.RowCount - 1
            'MsgBox(Me.DataGridView1.Item(1, Renglones).Value)
            total += Me.DataGridView1.Item(4, Renglones).Value
        Next
        txtTotal.Text = total
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        ventana.ShowDialog()
        txtCliente.Text = ventana.cliente.Nombre & " " & ventana.cliente.Apellido
        factura.Id_Cliente = ventana.cliente.Id_Cliente
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If blfactura.SP_FACTURA_NUEVO(factura) Then

        'End If
    End Sub
End Class