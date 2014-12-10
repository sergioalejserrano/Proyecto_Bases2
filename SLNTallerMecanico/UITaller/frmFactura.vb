Imports BLTaller
Imports BEUTaller
Imports Oracle.DataAccess.Client
Public Class frmFactura
    Public factura As New BEUFactura
    Dim ventana As frmClienteBuscar = New frmClienteBuscar
    Private blfactura As New BLFactura
    Private dt As DataTable

    Private Sub frmFactura_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Me.Text = "Actualizar Factura" Then
            habilitarCampos()
        Else
            factura = New BLTaller.BLFactura().SP_NUM_FACTURA()
            txtNumero.Text = factura.Id_Factura
            Dim today As DateTime = DateTime.Today
            txtFecha.Text = today.ToString("d")
            factura.Fecha = today
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

    Private Sub txtNumero_TextChanged(sender As Object, e As EventArgs) Handles txtNumero.TextChanged
        If Me.Text = "Actualizar Factura" Then
            factura.Id_Factura = txtNumero.Text
            Try
                dt = New BLTaller.BLDetalleFactura().SP_SELECT_DETALLE(factura)
            Catch ex As Exception

            End Try
            With Me.DataGridView1
                .Rows.Clear()
                .DataSource = dt
            End With
        End If
    End Sub
End Class