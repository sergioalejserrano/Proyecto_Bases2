<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClienteBorrar
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
        Me.SuspendLayout()
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(164, 192)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 0
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'lblCédula
        '
        Me.lblCédula.AutoSize = True
        Me.lblCédula.Location = New System.Drawing.Point(13, 55)
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
        'MantenimientoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtID_CLIENTE)
        Me.Controls.Add(Me.lblCédula)
        Me.Controls.Add(Me.btnBorrar)
        Me.Name = "MantenimientoCliente"
        Me.Text = "MantenimientoCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents lblCédula As System.Windows.Forms.Label
    Friend WithEvents txtID_CLIENTE As System.Windows.Forms.TextBox
End Class
