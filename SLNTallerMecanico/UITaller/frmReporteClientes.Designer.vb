<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteClientes
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.CLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DTSReporteClientes = New UITaller.DTSReporteClientes()
        Me.CLIENTETableAdapter = New UITaller.DTSReporteClientesTableAdapters.CLIENTETableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTSReporteClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CLIENTEBindingSource
        '
        Me.CLIENTEBindingSource.DataMember = "CLIENTE"
        Me.CLIENTEBindingSource.DataSource = Me.DTSReporteClientes
        '
        'DTSReporteClientes
        '
        Me.DTSReporteClientes.DataSetName = "DTSReporteClientes"
        Me.DTSReporteClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CLIENTETableAdapter
        '
        Me.CLIENTETableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.CLIENTEBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "UITaller.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1169, 506)
        Me.ReportViewer1.TabIndex = 1
        '
        'frmReporteClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 506)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reporte de Clientes"
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTSReporteClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DTSReporteClientes As UITaller.DTSReporteClientes
    Friend WithEvents CLIENTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CLIENTETableAdapter As UITaller.DTSReporteClientesTableAdapters.CLIENTETableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
