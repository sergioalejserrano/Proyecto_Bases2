﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteRepuesto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteRepuesto))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSetRepuesto = New UITaller.DataSetRepuesto()
        Me.STOCKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STOCKTableAdapter = New UITaller.DataSetRepuestoTableAdapters.STOCKTableAdapter()
        CType(Me.DataSetRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STOCKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ReporteRepuesto"
        ReportDataSource1.Value = Me.STOCKBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "UITaller.Report6.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(727, 452)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSetRepuesto
        '
        Me.DataSetRepuesto.DataSetName = "DataSetRepuesto"
        Me.DataSetRepuesto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'STOCKBindingSource
        '
        Me.STOCKBindingSource.DataMember = "STOCK"
        Me.STOCKBindingSource.DataSource = Me.DataSetRepuesto
        '
        'STOCKTableAdapter
        '
        Me.STOCKTableAdapter.ClearBeforeFill = True
        '
        'frmReporteRepuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 452)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReporteRepuesto"
        Me.Text = "Reporte de Repuestos"
        CType(Me.DataSetRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STOCKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents STOCKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSetRepuesto As UITaller.DataSetRepuesto
    Friend WithEvents STOCKTableAdapter As UITaller.DataSetRepuestoTableAdapters.STOCKTableAdapter
End Class
