Imports BLTaller
Imports BEUTaller
Public Class frmHojadeParteNuevo
    Private hoja As New BEUHojaDeParte
    Private blhoja As New BLHojaDeParte
    Private repuesto As New BEUStock
    Private bldetalle As New BLDetalleFactura
    Public detalles(0) As BEUDetalleFactura
    Private tamano As Integer = 1
    Private vehiculo As New BEUVehiculo
    Private blfactura As New BLFactura
    Dim frmbuscaremp As New frmEmpleadoBuscar
    Dim frmbuscarvin As New frmVehiculoBuscar


    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If txtIdEmpleado.Text = "" Or txtVIN.Text = "" Or IsDataGridViewEmpty(DataGridView1) Then
            MessageBox.Show("Rellene todos los campos obligatorios antes de continuar.")
        Else
            hoja.HorayFechaEntrada = dateEntrada.Value
            Dim today As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            hoja.HorayFechaSalida = today
            hoja.ManodeObra = Nothing
            hoja.Detalle = txtBoxDetalle.Text
            hoja.VIN = txtVIN.Text
            hoja.Id_Empleado = frmbuscaremp.empleado.ID_EMPLEADO
            Dim ventana As frmFactura = New frmFactura
            ventana.Text = "Nueva Factura"
            vehiculo.VIN = txtVIN.Text
            vehiculo = New BLTaller.BLVehiculo().SP_SELECT_VEHICULO(vehiculo)
            Dim CLIENTE As New BEUCliente
            CLIENTE.Id_Cliente = vehiculo.Id_Cliente
            CLIENTE = New BLTaller.BLCliente().SP_SELECT_CLIENTE(CLIENTE)
            If vehiculo.Placa Is Nothing Then
                MsgBox("EL VIN no corresponde a ninguno de los vehiculos en el sistema.")
                Exit Sub
            Else
                If blhoja.SP_HOJADEPARTE_NUEVO(hoja) Then
                        For Each det In detalles
                            If Not det Is Nothing Then
                                det.Id_Factura = ventana.factura.Id_Factura
                                agregarDetalle(det)
                                Dim rep As New BEUStock
                                rep.Id_Repuesto = det.Id_Repuesto
                                rep = New BLTaller.BLStock().SP_SELECT_STOCK(rep)
                                Dim row As String() = New String() {rep.Nombre, det.Cantidad, det.Precio, 0, (det.Cantidad * det.Precio)}
                                ventana.DataGridView1.Rows.Add(row)
                            End If
                        Next
                    ventana.Show()
                    ventana.factura.Id_Cliente = vehiculo.Id_Cliente
                    ventana.txtCliente.Text = CLIENTE.Nombre & " " & CLIENTE.Apellido
                    ventana.txtEmpleado.Text = frmbuscaremp.empleado.Nombre & " " & frmbuscaremp.empleado.Apellido
                    If blfactura.SP_FACTURA_NUEVO(ventana.factura) Then
                        Me.Close()
                    End If
                End If
            End If
        End If
    End Sub

    Sub agregarDetalle(ByVal detalle As BEUDetalleFactura)
        If bldetalle.SP_DETALLE_FACTURA(detalle) Then

        End If
    End Sub
    Private Sub frmHojadeParteNuevo_Load(sender As Object, e As EventArgs) Handles Me.Load
        hoja = New BLTaller.BLHojaDeParte().SP_NUM_HOJA()
        lblNumHojaResultado.Text = hoja.Id_Hoja
        dateEntrada.Format = DateTimePickerFormat.Custom
        dateEntrada.CustomFormat = "yyyy-MM-dd HH:mm:ss"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ventana As frmRepuestoBuscar = New frmRepuestoBuscar
        Dim existe As Boolean = False

        ventana.ShowDialog()
        repuesto = ventana.repuesto

        If IsDataGridViewEmpty(DataGridView1) Then
            Dim row As String() = New String() {1, repuesto.Id_Repuesto, repuesto.Nombre, 1}
            DataGridView1.Rows.Add(row)
            Dim prueba As New BEUDetalleFactura()
            prueba.Id_Repuesto = repuesto.Id_Repuesto
            prueba.Precio = repuesto.Precio
            prueba.Cantidad = Me.DataGridView1.Item(3, 0).Value
            prueba.ManodeObra = Nothing
            prueba.Id_Factura = Nothing
            prueba.Id_Detalle_Factura = hoja.Id_Hoja.ToString() & Me.DataGridView1.Item(0, 0).Value
            prueba.Id_Hoja = hoja.Id_Hoja
            detalles(0) = prueba
        Else
            For Renglones As Integer = 0 To DataGridView1.RowCount - 1
                'MsgBox(Me.DataGridView1.Item(1, Renglones).Value)
                If repuesto.Id_Repuesto = Me.DataGridView1.Item(1, Renglones).Value Then
                    MsgBox("El articulo y esta en la lista de articulos seleccionados.")
                    existe = True
                    Exit Sub
                End If
            Next
            If existe = False Then
                Dim row As String() = New String() {Me.DataGridView1.RowCount + 1, repuesto.Id_Repuesto, repuesto.Nombre, 1}
                DataGridView1.Rows.Add(row)
                tamano = tamano + 1
                ReDim Preserve detalles(tamano)
                    Dim prueba As New BEUDetalleFactura()
                    prueba.Id_Repuesto = repuesto.Id_Repuesto
                    prueba.Precio = repuesto.Precio
                    prueba.Cantidad = 1
                    prueba.ManodeObra = Nothing
                    prueba.Id_Factura = Nothing
                    prueba.Id_Detalle_Factura = hoja.Id_Hoja.ToString() & Me.DataGridView1.Item(0, Me.DataGridView1.RowCount - 1).Value
                    prueba.Id_Hoja = hoja.Id_Hoja
                detalles(tamano) = prueba
            End If

        End If

        
    End Sub

    Public Function IsDataGridViewEmpty(ByRef dataGridView As DataGridView) As Boolean
        Dim isEmpty As Boolean
        isEmpty = True
        For Each row As DataGridViewRow In dataGridView.Rows
            For Each cell As DataGridViewCell In row.Cells
                If Not String.IsNullOrEmpty(cell.Value) Then
                    ' Check if the string only consists of spaces
                    If Not String.IsNullOrEmpty(Trim(cell.Value.ToString())) Then
                        isEmpty = False
                        Exit For
                    End If
                End If
            Next
        Next
        Return isEmpty
    End Function

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        For Each det In detalles
            If det Is Nothing Then
            Else
                If det.Id_Repuesto = Me.DataGridView1.Item(1, e.RowIndex).Value Then
                    det.Cantidad = Me.DataGridView1.Item(e.ColumnIndex, e.RowIndex).Value
                End If
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmbuscaremp.ShowDialog()
        txtIdEmpleado.Text = frmbuscaremp.empleado.Nombre & " " & frmbuscaremp.empleado.Apellido
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmbuscarvin.ShowDialog()
        txtVIN.Text = frmbuscarvin.vehiculo.VIN
    End Sub

End Class