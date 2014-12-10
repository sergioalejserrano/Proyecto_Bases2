<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepuestoBuscar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepuestoBuscar))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDREPUESTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDADDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Agregar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.STOCKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetStock = New UITaller.DataSetStock()
        Me.STOCKTableAdapter = New UITaller.DataSetStockTableAdapters.STOCKTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STOCKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDREPUESTODataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.CANTIDADDataGridViewTextBoxColumn, Me.PRECIODataGridViewTextBoxColumn, Me.Agregar})
        Me.DataGridView1.DataSource = Me.STOCKBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(544, 367)
        Me.DataGridView1.TabIndex = 0
        '
        'IDREPUESTODataGridViewTextBoxColumn
        '
        Me.IDREPUESTODataGridViewTextBoxColumn.DataPropertyName = "ID_REPUESTO"
        Me.IDREPUESTODataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDREPUESTODataGridViewTextBoxColumn.Name = "IDREPUESTODataGridViewTextBoxColumn"
        Me.IDREPUESTODataGridViewTextBoxColumn.ReadOnly = True
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CANTIDADDataGridViewTextBoxColumn
        '
        Me.CANTIDADDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD"
        Me.CANTIDADDataGridViewTextBoxColumn.HeaderText = "CANTIDAD"
        Me.CANTIDADDataGridViewTextBoxColumn.Name = "CANTIDADDataGridViewTextBoxColumn"
        Me.CANTIDADDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRECIODataGridViewTextBoxColumn
        '
        Me.PRECIODataGridViewTextBoxColumn.DataPropertyName = "PRECIO"
        Me.PRECIODataGridViewTextBoxColumn.HeaderText = "PRECIO"
        Me.PRECIODataGridViewTextBoxColumn.Name = "PRECIODataGridViewTextBoxColumn"
        Me.PRECIODataGridViewTextBoxColumn.ReadOnly = True
        '
        'Agregar
        '
        Me.Agregar.HeaderText = "AGREGAR"
        Me.Agregar.Name = "Agregar"
        Me.Agregar.ReadOnly = True
        Me.Agregar.Text = "Agregar"
        Me.Agregar.ToolTipText = "Agregar"
        '
        'STOCKBindingSource
        '
        Me.STOCKBindingSource.DataMember = "STOCK"
        Me.STOCKBindingSource.DataSource = Me.DataSetStock
        '
        'DataSetStock
        '
        Me.DataSetStock.DataSetName = "DataSetStock"
        Me.DataSetStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'STOCKTableAdapter
        '
        Me.STOCKTableAdapter.ClearBeforeFill = True
        '
        'frmRepuestoBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 367)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRepuestoBuscar"
        Me.Text = "Agregar Articulo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STOCKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataSetStock As UITaller.DataSetStock
    Friend WithEvents STOCKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents STOCKTableAdapter As UITaller.DataSetStockTableAdapters.STOCKTableAdapter
    Friend WithEvents IDREPUESTODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CANTIDADDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Agregar As System.Windows.Forms.DataGridViewButtonColumn
End Class
