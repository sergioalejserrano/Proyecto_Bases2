﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedorBuscar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedorBuscar))
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.txtCedulaResultado = New System.Windows.Forms.TextBox()
        Me.lblCedulaResultado = New System.Windows.Forms.Label()
        Me.txtNombreResultado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtIdProveedor = New System.Windows.Forms.TextBox()
        Me.lblIdProveedor = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSeleccionar.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.Location = New System.Drawing.Point(463, 144)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(98, 93)
        Me.btnSeleccionar.TabIndex = 21
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'txtCedulaResultado
        '
        Me.txtCedulaResultado.Location = New System.Drawing.Point(190, 214)
        Me.txtCedulaResultado.Name = "txtCedulaResultado"
        Me.txtCedulaResultado.ReadOnly = True
        Me.txtCedulaResultado.Size = New System.Drawing.Size(267, 20)
        Me.txtCedulaResultado.TabIndex = 20
        '
        'lblCedulaResultado
        '
        Me.lblCedulaResultado.AutoSize = True
        Me.lblCedulaResultado.BackColor = System.Drawing.Color.Transparent
        Me.lblCedulaResultado.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedulaResultado.Location = New System.Drawing.Point(26, 214)
        Me.lblCedulaResultado.Name = "lblCedulaResultado"
        Me.lblCedulaResultado.Size = New System.Drawing.Size(163, 23)
        Me.lblCedulaResultado.TabIndex = 19
        Me.lblCedulaResultado.Text = "Cédula Jurídica"
        '
        'txtNombreResultado
        '
        Me.txtNombreResultado.Location = New System.Drawing.Point(190, 155)
        Me.txtNombreResultado.Name = "txtNombreResultado"
        Me.txtNombreResultado.ReadOnly = True
        Me.txtNombreResultado.Size = New System.Drawing.Size(267, 20)
        Me.txtNombreResultado.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 23)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nombre"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Azure
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtIdProveedor)
        Me.GroupBox1.Controls.Add(Me.lblIdProveedor)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 117)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(439, 59)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(89, 31)
        Me.btnBuscar.TabIndex = 13
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtIdProveedor
        '
        Me.txtIdProveedor.Location = New System.Drawing.Point(181, 48)
        Me.txtIdProveedor.Name = "txtIdProveedor"
        Me.txtIdProveedor.Size = New System.Drawing.Size(215, 20)
        Me.txtIdProveedor.TabIndex = 12
        '
        'lblIdProveedor
        '
        Me.lblIdProveedor.AutoSize = True
        Me.lblIdProveedor.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdProveedor.Location = New System.Drawing.Point(35, 45)
        Me.lblIdProveedor.Name = "lblIdProveedor"
        Me.lblIdProveedor.Size = New System.Drawing.Size(140, 23)
        Me.lblIdProveedor.TabIndex = 11
        Me.lblIdProveedor.Text = "Id Proveedor"
        '
        'frmProveedorBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(579, 269)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.txtCedulaResultado)
        Me.Controls.Add(Me.lblCedulaResultado)
        Me.Controls.Add(Me.txtNombreResultado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProveedorBuscar"
        Me.Text = "Buscar Proveedor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents txtCedulaResultado As System.Windows.Forms.TextBox
    Friend WithEvents lblCedulaResultado As System.Windows.Forms.Label
    Friend WithEvents txtNombreResultado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtIdProveedor As System.Windows.Forms.TextBox
    Friend WithEvents lblIdProveedor As System.Windows.Forms.Label
End Class
