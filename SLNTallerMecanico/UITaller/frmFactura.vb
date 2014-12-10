Imports BLTaller
Imports BEUTaller
Imports Oracle.DataAccess.Client
Public Class frmFactura
    Public factura As New BEUFactura
    Dim ventana As frmClienteBuscar = New frmClienteBuscar
    Private blfactura As New BLFactura
    Private reader As OracleDataReader

    Private Sub frmFactura_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Me.Text = "Actualizar Factura" Then
            factura.Id_Factura = txtNumero.Text
            Try
                reader = New BLTaller.BLDetalleFactura().SP_SELECT_DETALLE(factura)
            Catch ex As Exception

            End Try
            With Me.DataGridView1
                .Rows.Clear()
                Dim ColumnCount As Integer = reader.FieldCount
                'add columns to the grid
                For i As Integer = 0 To ColumnCount - 1
                    .Columns.Add(reader.GetName(i), reader.GetName(i))
                Next
                .AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.ColumnHeader
                'loop through every row
                While reader.Read
                    'get all row values into an array
                    Dim objCells(ColumnCount - 1) As Object
                    reader.GetValues(objCells)
                    'add array as a row to grid
                    .Rows.Add(objCells)
                End While
            End With
        Else
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
        End If
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs)
        ventana.ShowDialog()
        txtCliente.Text = ventana.cliente.Nombre & " " & ventana.cliente.Apellido
        factura.Id_Cliente = ventana.cliente.Id_Cliente
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If blfactura.SP_FACTURA_NUEVO(factura) Then

        'End If
    End Sub

    Private Sub habilitarCampos()
        txtNumero.Enabled = True

    End Sub
End Class