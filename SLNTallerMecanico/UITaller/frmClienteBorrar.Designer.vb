<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClienteBorrar
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
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.lblCédula = New System.Windows.Forms.Label()
        Me.txtID_CLIENTE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(164, 104)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(92, 31)
        Me.btnBorrar.TabIndex = 0
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'lblCédula
        '
        Me.lblCédula.AutoSize = True
        Me.lblCédula.Location = New System.Drawing.Point(42, 58)
        Me.lblCédula.Name = "lblCédula"
        Me.lblCédula.Size = New System.Drawing.Size(46, 13)
        Me.lblCédula.TabIndex = 1
        Me.lblCédula.Text = "Cédula: "
        '
        'txtID_CLIENTE
        '
        Me.txtID_CLIENTE.Location = New System.Drawing.Point(139, 55)
        Me.txtID_CLIENTE.Name = "txtID_CLIENTE"
        Me.txtID_CLIENTE.Size = New System.Drawing.Size(100, 20)
        Me.txtID_CLIENTE.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(146, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "* Campos Obligatorios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(245, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "*"
        '
        'frmClienteBorrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 191)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtID_CLIENTE)
        Me.Controls.Add(Me.lblCédula)
        Me.Controls.Add(Me.btnBorrar)
        Me.Name = "frmClienteBorrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Borrar Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents lblCédula As System.Windows.Forms.Label
    Friend WithEvents txtID_CLIENTE As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
