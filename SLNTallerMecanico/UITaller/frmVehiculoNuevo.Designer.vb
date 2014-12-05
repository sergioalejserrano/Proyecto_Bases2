<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVehiculoNuevo
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
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.txtVIN = New System.Windows.Forms.TextBox()
        Me.lblVIN = New System.Windows.Forms.Label()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.lblPlaca = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblAno = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(141, 122)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(133, 20)
        Me.txtModelo.TabIndex = 8
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.Location = New System.Drawing.Point(11, 119)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(85, 23)
        Me.lblModelo.TabIndex = 7
        Me.lblModelo.Text = "Modelo"
        '
        'txtVIN
        '
        Me.txtVIN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtVIN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtVIN.Location = New System.Drawing.Point(142, 23)
        Me.txtVIN.Name = "txtVIN"
        Me.txtVIN.ShortcutsEnabled = False
        Me.txtVIN.Size = New System.Drawing.Size(133, 20)
        Me.txtVIN.TabIndex = 10
        '
        'lblVIN
        '
        Me.lblVIN.AutoSize = True
        Me.lblVIN.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVIN.Location = New System.Drawing.Point(12, 20)
        Me.lblVIN.Name = "lblVIN"
        Me.lblVIN.Size = New System.Drawing.Size(50, 23)
        Me.lblVIN.TabIndex = 9
        Me.lblVIN.Text = "VIN"
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(141, 57)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(133, 20)
        Me.txtPlaca.TabIndex = 12
        '
        'lblPlaca
        '
        Me.lblPlaca.AutoSize = True
        Me.lblPlaca.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaca.Location = New System.Drawing.Point(11, 54)
        Me.lblPlaca.Name = "lblPlaca"
        Me.lblPlaca.Size = New System.Drawing.Size(61, 23)
        Me.lblPlaca.TabIndex = 11
        Me.lblPlaca.Text = "Placa"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(142, 90)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(133, 20)
        Me.txtMarca.TabIndex = 14
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.Location = New System.Drawing.Point(12, 87)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(71, 23)
        Me.lblMarca.TabIndex = 13
        Me.lblMarca.Text = "Marca"
        '
        'lblAno
        '
        Me.lblAno.AutoSize = True
        Me.lblAno.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAno.Location = New System.Drawing.Point(12, 154)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(52, 23)
        Me.lblAno.TabIndex = 15
        Me.lblAno.Text = "Año"
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(142, 195)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(133, 20)
        Me.txtColor.TabIndex = 18
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.Location = New System.Drawing.Point(12, 192)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(65, 23)
        Me.lblColor.TabIndex = 17
        Me.lblColor.Text = "Color"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(12, 226)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(79, 23)
        Me.lblCliente.TabIndex = 19
        Me.lblCliente.Text = "Cliente"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(178, 273)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(96, 36)
        Me.btnRegistrar.TabIndex = 20
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(141, 228)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtCliente.TabIndex = 21
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(234, 226)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 22
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(281, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(280, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(281, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(280, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(231, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "* Campos Obligatorios"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(315, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "*"
        '
        'txtAno
        '
        Me.txtAno.Location = New System.Drawing.Point(142, 159)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(133, 20)
        Me.txtAno.TabIndex = 29
        '
        'frmVehiculoNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 335)
        Me.Controls.Add(Me.txtAno)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblAno)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.lblMarca)
        Me.Controls.Add(Me.txtPlaca)
        Me.Controls.Add(Me.lblPlaca)
        Me.Controls.Add(Me.txtVIN)
        Me.Controls.Add(Me.lblVIN)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.lblModelo)
        Me.Name = "frmVehiculoNuevo"
        Me.Text = "Nuevo Vehiculo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents lblModelo As System.Windows.Forms.Label
    Friend WithEvents txtVIN As System.Windows.Forms.TextBox
    Friend WithEvents lblVIN As System.Windows.Forms.Label
    Friend WithEvents txtPlaca As System.Windows.Forms.TextBox
    Friend WithEvents lblPlaca As System.Windows.Forms.Label
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents lblAno As System.Windows.Forms.Label
    Friend WithEvents txtColor As System.Windows.Forms.TextBox
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAno As System.Windows.Forms.TextBox
End Class
