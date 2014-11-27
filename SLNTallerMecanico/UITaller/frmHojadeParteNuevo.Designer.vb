<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHojadeParteNuevo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtVIN = New System.Windows.Forms.TextBox()
        Me.lblVIN = New System.Windows.Forms.Label()
        Me.lblNumHoja = New System.Windows.Forms.Label()
        Me.lblNumHojaResultado = New System.Windows.Forms.Label()
        Me.lblEntrada = New System.Windows.Forms.Label()
        Me.dateEntrada = New System.Windows.Forms.DateTimePicker()
        Me.dateSalida = New System.Windows.Forms.DateTimePicker()
        Me.lblSalida = New System.Windows.Forms.Label()
        Me.txtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.lblIdEmpleado = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.txtRepuestos = New System.Windows.Forms.TextBox()
        Me.lblRepuestos = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.numCantidad = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDetalle = New System.Windows.Forms.Label()
        Me.txtBoxDetalle = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.numCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtVIN
        '
        Me.txtVIN.Location = New System.Drawing.Point(430, 35)
        Me.txtVIN.Name = "txtVIN"
        Me.txtVIN.Size = New System.Drawing.Size(197, 20)
        Me.txtVIN.TabIndex = 24
        '
        'lblVIN
        '
        Me.lblVIN.AutoSize = True
        Me.lblVIN.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVIN.Location = New System.Drawing.Point(337, 35)
        Me.lblVIN.Name = "lblVIN"
        Me.lblVIN.Size = New System.Drawing.Size(50, 23)
        Me.lblVIN.TabIndex = 23
        Me.lblVIN.Text = "VIN"
        '
        'lblNumHoja
        '
        Me.lblNumHoja.AutoSize = True
        Me.lblNumHoja.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumHoja.Location = New System.Drawing.Point(25, 35)
        Me.lblNumHoja.Name = "lblNumHoja"
        Me.lblNumHoja.Size = New System.Drawing.Size(164, 23)
        Me.lblNumHoja.TabIndex = 21
        Me.lblNumHoja.Text = "# Hoja de Parte"
        '
        'lblNumHojaResultado
        '
        Me.lblNumHojaResultado.AutoSize = True
        Me.lblNumHojaResultado.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumHojaResultado.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblNumHojaResultado.Location = New System.Drawing.Point(195, 35)
        Me.lblNumHojaResultado.Name = "lblNumHojaResultado"
        Me.lblNumHojaResultado.Size = New System.Drawing.Size(62, 23)
        Me.lblNumHojaResultado.TabIndex = 25
        Me.lblNumHojaResultado.Text = "0000"
        '
        'lblEntrada
        '
        Me.lblEntrada.AutoSize = True
        Me.lblEntrada.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntrada.Location = New System.Drawing.Point(25, 91)
        Me.lblEntrada.Name = "lblEntrada"
        Me.lblEntrada.Size = New System.Drawing.Size(87, 23)
        Me.lblEntrada.TabIndex = 26
        Me.lblEntrada.Text = "Entrada"
        '
        'dateEntrada
        '
        Me.dateEntrada.Location = New System.Drawing.Point(118, 93)
        Me.dateEntrada.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dateEntrada.Name = "dateEntrada"
        Me.dateEntrada.Size = New System.Drawing.Size(200, 20)
        Me.dateEntrada.TabIndex = 28
        Me.dateEntrada.Value = New Date(2014, 11, 26, 10, 32, 39, 0)
        '
        'dateSalida
        '
        Me.dateSalida.Location = New System.Drawing.Point(430, 92)
        Me.dateSalida.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dateSalida.Name = "dateSalida"
        Me.dateSalida.Size = New System.Drawing.Size(200, 20)
        Me.dateSalida.TabIndex = 30
        Me.dateSalida.Value = New Date(2014, 11, 26, 10, 32, 39, 0)
        '
        'lblSalida
        '
        Me.lblSalida.AutoSize = True
        Me.lblSalida.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalida.Location = New System.Drawing.Point(337, 90)
        Me.lblSalida.Name = "lblSalida"
        Me.lblSalida.Size = New System.Drawing.Size(68, 23)
        Me.lblSalida.TabIndex = 29
        Me.lblSalida.Text = "Salida"
        '
        'txtIdEmpleado
        '
        Me.txtIdEmpleado.Location = New System.Drawing.Point(167, 168)
        Me.txtIdEmpleado.Name = "txtIdEmpleado"
        Me.txtIdEmpleado.Size = New System.Drawing.Size(197, 20)
        Me.txtIdEmpleado.TabIndex = 32
        '
        'lblIdEmpleado
        '
        Me.lblIdEmpleado.AutoSize = True
        Me.lblIdEmpleado.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdEmpleado.Location = New System.Drawing.Point(25, 168)
        Me.lblIdEmpleado.Name = "lblIdEmpleado"
        Me.lblIdEmpleado.Size = New System.Drawing.Size(136, 23)
        Me.lblIdEmpleado.TabIndex = 31
        Me.lblIdEmpleado.Text = "Id Empleado"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(638, 79)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(110, 98)
        Me.btnRegistrar.TabIndex = 33
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'txtRepuestos
        '
        Me.txtRepuestos.Location = New System.Drawing.Point(167, 246)
        Me.txtRepuestos.Name = "txtRepuestos"
        Me.txtRepuestos.Size = New System.Drawing.Size(297, 20)
        Me.txtRepuestos.TabIndex = 35
        '
        'lblRepuestos
        '
        Me.lblRepuestos.AutoSize = True
        Me.lblRepuestos.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepuestos.Location = New System.Drawing.Point(25, 246)
        Me.lblRepuestos.Name = "lblRepuestos"
        Me.lblRepuestos.Size = New System.Drawing.Size(114, 23)
        Me.lblRepuestos.TabIndex = 34
        Me.lblRepuestos.Text = "Repuestos"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(484, 243)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 36
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'numCantidad
        '
        Me.numCantidad.Location = New System.Drawing.Point(565, 244)
        Me.numCantidad.Name = "numCantidad"
        Me.numCantidad.Size = New System.Drawing.Size(37, 20)
        Me.numCantidad.TabIndex = 37
        Me.numCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnRegistrar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(756, 201)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        '
        'lblDetalle
        '
        Me.lblDetalle.AutoSize = True
        Me.lblDetalle.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetalle.Location = New System.Drawing.Point(25, 303)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(80, 23)
        Me.lblDetalle.TabIndex = 39
        Me.lblDetalle.Text = "Detalle"
        '
        'txtBoxDetalle
        '
        Me.txtBoxDetalle.Location = New System.Drawing.Point(167, 308)
        Me.txtBoxDetalle.Name = "txtBoxDetalle"
        Me.txtBoxDetalle.Size = New System.Drawing.Size(542, 96)
        Me.txtBoxDetalle.TabIndex = 41
        Me.txtBoxDetalle.Text = "Observaciones:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 406)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "* Campos Obligatorios"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(373, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(358, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(621, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(467, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(308, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(621, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "*"
        '
        'frmHojadeParteNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 428)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBoxDetalle)
        Me.Controls.Add(Me.lblDetalle)
        Me.Controls.Add(Me.numCantidad)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtRepuestos)
        Me.Controls.Add(Me.lblRepuestos)
        Me.Controls.Add(Me.txtIdEmpleado)
        Me.Controls.Add(Me.lblIdEmpleado)
        Me.Controls.Add(Me.dateSalida)
        Me.Controls.Add(Me.lblSalida)
        Me.Controls.Add(Me.dateEntrada)
        Me.Controls.Add(Me.lblEntrada)
        Me.Controls.Add(Me.lblNumHojaResultado)
        Me.Controls.Add(Me.txtVIN)
        Me.Controls.Add(Me.lblVIN)
        Me.Controls.Add(Me.lblNumHoja)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmHojadeParteNuevo"
        Me.Text = "Nueva Hoja de Parte"
        CType(Me.numCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtVIN As System.Windows.Forms.TextBox
    Friend WithEvents lblVIN As System.Windows.Forms.Label
    Friend WithEvents lblNumHoja As System.Windows.Forms.Label
    Friend WithEvents lblNumHojaResultado As System.Windows.Forms.Label
    Friend WithEvents lblEntrada As System.Windows.Forms.Label
    Friend WithEvents dateEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateSalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSalida As System.Windows.Forms.Label
    Friend WithEvents txtIdEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents lblIdEmpleado As System.Windows.Forms.Label
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents txtRepuestos As System.Windows.Forms.TextBox
    Friend WithEvents lblRepuestos As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents numCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDetalle As System.Windows.Forms.Label
    Friend WithEvents txtBoxDetalle As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
