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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHojadeParteNuevo))
        Me.txtVIN = New System.Windows.Forms.TextBox()
        Me.lblVIN = New System.Windows.Forms.Label()
        Me.lblNumHoja = New System.Windows.Forms.Label()
        Me.lblNumHojaResultado = New System.Windows.Forms.Label()
        Me.lblEntrada = New System.Windows.Forms.Label()
        Me.dateEntrada = New System.Windows.Forms.DateTimePicker()
        Me.txtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.lblIdEmpleado = New System.Windows.Forms.Label()
        Me.lblRepuestos = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblDetalle = New System.Windows.Forms.Label()
        Me.txtBoxDetalle = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Consecutivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.BEUStockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BEUStockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtVIN
        '
        Me.txtVIN.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtVIN.Enabled = False
        Me.txtVIN.Location = New System.Drawing.Point(284, 71)
        Me.txtVIN.Name = "txtVIN"
        Me.txtVIN.Size = New System.Drawing.Size(197, 20)
        Me.txtVIN.TabIndex = 24
        '
        'lblVIN
        '
        Me.lblVIN.AutoSize = True
        Me.lblVIN.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVIN.Location = New System.Drawing.Point(329, 21)
        Me.lblVIN.Name = "lblVIN"
        Me.lblVIN.Size = New System.Drawing.Size(50, 23)
        Me.lblVIN.TabIndex = 23
        Me.lblVIN.Text = "VIN"
        '
        'lblNumHoja
        '
        Me.lblNumHoja.AutoSize = True
        Me.lblNumHoja.BackColor = System.Drawing.Color.Transparent
        Me.lblNumHoja.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumHoja.Location = New System.Drawing.Point(11, 18)
        Me.lblNumHoja.Name = "lblNumHoja"
        Me.lblNumHoja.Size = New System.Drawing.Size(77, 23)
        Me.lblNumHoja.TabIndex = 21
        Me.lblNumHoja.Text = "Hoja #"
        '
        'lblNumHojaResultado
        '
        Me.lblNumHojaResultado.AutoSize = True
        Me.lblNumHojaResultado.BackColor = System.Drawing.Color.Transparent
        Me.lblNumHojaResultado.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumHojaResultado.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblNumHojaResultado.Location = New System.Drawing.Point(94, 18)
        Me.lblNumHojaResultado.Name = "lblNumHojaResultado"
        Me.lblNumHojaResultado.Size = New System.Drawing.Size(62, 23)
        Me.lblNumHojaResultado.TabIndex = 25
        Me.lblNumHojaResultado.Text = "0000"
        '
        'lblEntrada
        '
        Me.lblEntrada.AutoSize = True
        Me.lblEntrada.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntrada.Location = New System.Drawing.Point(588, 21)
        Me.lblEntrada.Name = "lblEntrada"
        Me.lblEntrada.Size = New System.Drawing.Size(87, 23)
        Me.lblEntrada.TabIndex = 26
        Me.lblEntrada.Text = "Entrada"
        '
        'dateEntrada
        '
        Me.dateEntrada.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateEntrada.Location = New System.Drawing.Point(524, 71)
        Me.dateEntrada.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.dateEntrada.Name = "dateEntrada"
        Me.dateEntrada.Size = New System.Drawing.Size(200, 22)
        Me.dateEntrada.TabIndex = 28
        Me.dateEntrada.Value = New Date(2014, 11, 26, 10, 32, 39, 0)
        '
        'txtIdEmpleado
        '
        Me.txtIdEmpleado.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtIdEmpleado.Enabled = False
        Me.txtIdEmpleado.Location = New System.Drawing.Point(28, 71)
        Me.txtIdEmpleado.Name = "txtIdEmpleado"
        Me.txtIdEmpleado.Size = New System.Drawing.Size(197, 20)
        Me.txtIdEmpleado.TabIndex = 32
        '
        'lblIdEmpleado
        '
        Me.lblIdEmpleado.AutoSize = True
        Me.lblIdEmpleado.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdEmpleado.Location = New System.Drawing.Point(47, 29)
        Me.lblIdEmpleado.Name = "lblIdEmpleado"
        Me.lblIdEmpleado.Size = New System.Drawing.Size(98, 23)
        Me.lblIdEmpleado.TabIndex = 31
        Me.lblIdEmpleado.Text = "Operario"
        '
        'lblRepuestos
        '
        Me.lblRepuestos.AutoSize = True
        Me.lblRepuestos.BackColor = System.Drawing.Color.Transparent
        Me.lblRepuestos.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepuestos.Location = New System.Drawing.Point(25, 196)
        Me.lblRepuestos.Name = "lblRepuestos"
        Me.lblRepuestos.Size = New System.Drawing.Size(112, 23)
        Me.lblRepuestos.TabIndex = 34
        Me.lblRepuestos.Text = "Materiales"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Lavender
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.lblIdEmpleado)
        Me.GroupBox1.Controls.Add(Me.txtIdEmpleado)
        Me.GroupBox1.Controls.Add(Me.lblVIN)
        Me.GroupBox1.Controls.Add(Me.txtVIN)
        Me.GroupBox1.Controls.Add(Me.lblEntrada)
        Me.GroupBox1.Controls.Add(Me.dateEntrada)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(778, 118)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(487, 71)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(31, 19)
        Me.Button3.TabIndex = 34
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button2.Location = New System.Drawing.Point(231, 71)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(31, 19)
        Me.Button2.TabIndex = 33
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblDetalle
        '
        Me.lblDetalle.AutoSize = True
        Me.lblDetalle.BackColor = System.Drawing.Color.Transparent
        Me.lblDetalle.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetalle.Location = New System.Drawing.Point(25, 471)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(156, 23)
        Me.lblDetalle.TabIndex = 39
        Me.lblDetalle.Text = "Observaciones"
        '
        'txtBoxDetalle
        '
        Me.txtBoxDetalle.Location = New System.Drawing.Point(57, 514)
        Me.txtBoxDetalle.Name = "txtBoxDetalle"
        Me.txtBoxDetalle.Size = New System.Drawing.Size(542, 96)
        Me.txtBoxDetalle.TabIndex = 41
        Me.txtBoxDetalle.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(12, 686)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "* Campos Obligatorios"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Consecutivo, Me.Id, Me.Nombre, Me.Cantidad})
        Me.DataGridView1.Location = New System.Drawing.Point(57, 234)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(443, 234)
        Me.DataGridView1.TabIndex = 47
        '
        'Consecutivo
        '
        Me.Consecutivo.HeaderText = "Detalle"
        Me.Consecutivo.Name = "Consecutivo"
        Me.Consecutivo.ReadOnly = True
        '
        'Id
        '
        Me.Id.HeaderText = "ID"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(588, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 52)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Agregar Articulo"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackgroundImage = CType(resources.GetObject("btnRegistrar.BackgroundImage"), System.Drawing.Image)
        Me.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(313, 640)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(162, 54)
        Me.btnRegistrar.TabIndex = 33
        Me.btnRegistrar.Text = "Facturar"
        Me.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'BEUStockBindingSource
        '
        Me.BEUStockBindingSource.DataSource = GetType(BEUTaller.BEUStock)
        '
        'frmHojadeParteNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(832, 706)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblNumHoja)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBoxDetalle)
        Me.Controls.Add(Me.lblDetalle)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.lblRepuestos)
        Me.Controls.Add(Me.lblNumHojaResultado)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "frmHojadeParteNuevo"
        Me.Text = "Nueva Hoja de Parte"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BEUStockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtVIN As System.Windows.Forms.TextBox
    Friend WithEvents lblVIN As System.Windows.Forms.Label
    Friend WithEvents lblNumHoja As System.Windows.Forms.Label
    Friend WithEvents lblNumHojaResultado As System.Windows.Forms.Label
    Friend WithEvents lblEntrada As System.Windows.Forms.Label
    Friend WithEvents dateEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtIdEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents lblIdEmpleado As System.Windows.Forms.Label
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents lblRepuestos As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDetalle As System.Windows.Forms.Label
    Friend WithEvents txtBoxDetalle As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BEUStockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Consecutivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
