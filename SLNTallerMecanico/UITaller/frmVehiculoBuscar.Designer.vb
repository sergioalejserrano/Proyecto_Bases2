<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVehiculoBuscar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVehiculoBuscar))
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.txtClienteResultado = New System.Windows.Forms.TextBox()
        Me.lblClienteResultado = New System.Windows.Forms.Label()
        Me.txtVINResultado = New System.Windows.Forms.TextBox()
        Me.lblVin = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSeleccionar.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.Location = New System.Drawing.Point(429, 195)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(98, 93)
        Me.btnSeleccionar.TabIndex = 21
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'txtClienteResultado
        '
        Me.txtClienteResultado.Location = New System.Drawing.Point(135, 268)
        Me.txtClienteResultado.Name = "txtClienteResultado"
        Me.txtClienteResultado.ReadOnly = True
        Me.txtClienteResultado.Size = New System.Drawing.Size(267, 20)
        Me.txtClienteResultado.TabIndex = 20
        '
        'lblClienteResultado
        '
        Me.lblClienteResultado.AutoSize = True
        Me.lblClienteResultado.BackColor = System.Drawing.Color.Transparent
        Me.lblClienteResultado.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClienteResultado.Location = New System.Drawing.Point(44, 263)
        Me.lblClienteResultado.Name = "lblClienteResultado"
        Me.lblClienteResultado.Size = New System.Drawing.Size(79, 23)
        Me.lblClienteResultado.TabIndex = 19
        Me.lblClienteResultado.Text = "Cliente"
        '
        'txtVINResultado
        '
        Me.txtVINResultado.Location = New System.Drawing.Point(135, 195)
        Me.txtVINResultado.Name = "txtVINResultado"
        Me.txtVINResultado.ReadOnly = True
        Me.txtVINResultado.Size = New System.Drawing.Size(267, 20)
        Me.txtVINResultado.TabIndex = 18
        '
        'lblVin
        '
        Me.lblVin.AutoSize = True
        Me.lblVin.BackColor = System.Drawing.Color.Transparent
        Me.lblVin.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVin.Location = New System.Drawing.Point(44, 190)
        Me.lblVin.Name = "lblVin"
        Me.lblVin.Size = New System.Drawing.Size(50, 23)
        Me.lblVin.TabIndex = 17
        Me.lblVin.Text = "VIN"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Azure
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtPlaca)
        Me.GroupBox1.Controls.Add(Me.lblCedula)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 120)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(377, 60)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(89, 31)
        Me.btnBuscar.TabIndex = 13
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(138, 46)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(199, 20)
        Me.txtPlaca.TabIndex = 12
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(47, 41)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(61, 23)
        Me.lblCedula.TabIndex = 11
        Me.lblCedula.Text = "Placa"
        '
        'frmVehiculoBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(552, 343)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.txtClienteResultado)
        Me.Controls.Add(Me.lblClienteResultado)
        Me.Controls.Add(Me.txtVINResultado)
        Me.Controls.Add(Me.lblVin)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVehiculoBuscar"
        Me.Text = "Buscar Vehiculo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents txtClienteResultado As System.Windows.Forms.TextBox
    Friend WithEvents lblClienteResultado As System.Windows.Forms.Label
    Friend WithEvents txtVINResultado As System.Windows.Forms.TextBox
    Friend WithEvents lblVin As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtPlaca As System.Windows.Forms.TextBox
    Friend WithEvents lblCedula As System.Windows.Forms.Label
End Class
