Imports BEUTaller
Public Class frmRepuestoBuscar
    Public repuesto As New BEUStock
    Private Sub frmRepuestoBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetStock.STOCK' Puede moverla o quitarla según sea necesario.
        Me.STOCKTableAdapter.Fill(Me.DataSetStock.STOCK)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        repuesto.Nombre = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
        repuesto.Id_Repuesto = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
        repuesto.Precio = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
        repuesto.Cantidad = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
           e.RowIndex >= 0 Then

            ' MessageBox.Show("Se selecciono el " & CType(repuesto.Nombre, String))
            Me.Close()

        End If
    End Sub
End Class