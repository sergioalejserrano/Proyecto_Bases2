<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMDITaller
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMDITaller))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmConectarse = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmDesconectarse = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmClienteN = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmVehiculoN = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmHojaDeParteN = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmProveedorN = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmRepuestoN = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmEmpleadoN = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmMantenimiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmClienteM = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmVehiculoM = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmHojaDeParteM = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmFacturaM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmProveedorM = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmRepuestosM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmEmpleadoM = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmReportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmClienteR = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmVehiculoR = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmHojaDeParteR = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmFacturaR = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmProveedorR = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmRepuestosR = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmEmpleadoR = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.White
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.tsmNuevo, Me.tsmMantenimiento, Me.tsmReportes, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 25)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmConectarse, Me.tsmDesconectarse, Me.ExitToolStripMenuItem})
        Me.FileMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(65, 21)
        Me.FileMenu.Text = "Usuario"
        '
        'tsmConectarse
        '
        Me.tsmConectarse.BackColor = System.Drawing.Color.White
        Me.tsmConectarse.Name = "tsmConectarse"
        Me.tsmConectarse.Size = New System.Drawing.Size(161, 22)
        Me.tsmConectarse.Text = "Conectarse"
        '
        'tsmDesconectarse
        '
        Me.tsmDesconectarse.BackColor = System.Drawing.Color.White
        Me.tsmDesconectarse.Name = "tsmDesconectarse"
        Me.tsmDesconectarse.Size = New System.Drawing.Size(161, 22)
        Me.tsmDesconectarse.Text = "Desconectarse"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ExitToolStripMenuItem.Text = "&Salir"
        '
        'tsmNuevo
        '
        Me.tsmNuevo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmClienteN, Me.tsmVehiculoN, Me.tsmHojaDeParteN, Me.ToolStripSeparator1, Me.tsmProveedorN, Me.tsmRepuestoN, Me.ToolStripSeparator2, Me.tsmEmpleadoN})
        Me.tsmNuevo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmNuevo.Name = "tsmNuevo"
        Me.tsmNuevo.Size = New System.Drawing.Size(58, 21)
        Me.tsmNuevo.Text = "Nuevo"
        '
        'tsmClienteN
        '
        Me.tsmClienteN.BackColor = System.Drawing.Color.White
        Me.tsmClienteN.Name = "tsmClienteN"
        Me.tsmClienteN.Size = New System.Drawing.Size(156, 22)
        Me.tsmClienteN.Text = "Cliente"
        '
        'tsmVehiculoN
        '
        Me.tsmVehiculoN.BackColor = System.Drawing.Color.White
        Me.tsmVehiculoN.Name = "tsmVehiculoN"
        Me.tsmVehiculoN.Size = New System.Drawing.Size(156, 22)
        Me.tsmVehiculoN.Text = "Vehículo"
        '
        'tsmHojaDeParteN
        '
        Me.tsmHojaDeParteN.BackColor = System.Drawing.Color.White
        Me.tsmHojaDeParteN.Name = "tsmHojaDeParteN"
        Me.tsmHojaDeParteN.Size = New System.Drawing.Size(156, 22)
        Me.tsmHojaDeParteN.Text = "Hoja de Parte"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.BackColor = System.Drawing.Color.White
        Me.ToolStripSeparator1.ForeColor = System.Drawing.Color.White
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(153, 6)
        '
        'tsmProveedorN
        '
        Me.tsmProveedorN.BackColor = System.Drawing.Color.White
        Me.tsmProveedorN.Name = "tsmProveedorN"
        Me.tsmProveedorN.Size = New System.Drawing.Size(156, 22)
        Me.tsmProveedorN.Text = "Proveedor"
        '
        'tsmRepuestoN
        '
        Me.tsmRepuestoN.BackColor = System.Drawing.Color.White
        Me.tsmRepuestoN.Name = "tsmRepuestoN"
        Me.tsmRepuestoN.Size = New System.Drawing.Size(156, 22)
        Me.tsmRepuestoN.Text = "Repuesto"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.BackColor = System.Drawing.Color.White
        Me.ToolStripSeparator2.ForeColor = System.Drawing.Color.White
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(153, 6)
        '
        'tsmEmpleadoN
        '
        Me.tsmEmpleadoN.BackColor = System.Drawing.Color.White
        Me.tsmEmpleadoN.Name = "tsmEmpleadoN"
        Me.tsmEmpleadoN.Size = New System.Drawing.Size(156, 22)
        Me.tsmEmpleadoN.Text = "Empleado"
        '
        'tsmMantenimiento
        '
        Me.tsmMantenimiento.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmClienteM, Me.tsmVehiculoM, Me.tsmHojaDeParteM, Me.tsmFacturaM, Me.ToolStripSeparator3, Me.tsmProveedorM, Me.tsmRepuestosM, Me.ToolStripSeparator4, Me.tsmEmpleadoM})
        Me.tsmMantenimiento.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmMantenimiento.Name = "tsmMantenimiento"
        Me.tsmMantenimiento.Size = New System.Drawing.Size(107, 21)
        Me.tsmMantenimiento.Text = "&Mantenimiento"
        '
        'tsmClienteM
        '
        Me.tsmClienteM.BackColor = System.Drawing.Color.White
        Me.tsmClienteM.Name = "tsmClienteM"
        Me.tsmClienteM.Size = New System.Drawing.Size(156, 22)
        Me.tsmClienteM.Text = "Cliente"
        '
        'tsmVehiculoM
        '
        Me.tsmVehiculoM.BackColor = System.Drawing.Color.White
        Me.tsmVehiculoM.Name = "tsmVehiculoM"
        Me.tsmVehiculoM.Size = New System.Drawing.Size(156, 22)
        Me.tsmVehiculoM.Text = "Vehículo"
        '
        'tsmHojaDeParteM
        '
        Me.tsmHojaDeParteM.BackColor = System.Drawing.Color.White
        Me.tsmHojaDeParteM.Name = "tsmHojaDeParteM"
        Me.tsmHojaDeParteM.Size = New System.Drawing.Size(156, 22)
        Me.tsmHojaDeParteM.Text = "Hoja de Parte"
        '
        'tsmFacturaM
        '
        Me.tsmFacturaM.BackColor = System.Drawing.Color.White
        Me.tsmFacturaM.Name = "tsmFacturaM"
        Me.tsmFacturaM.Size = New System.Drawing.Size(156, 22)
        Me.tsmFacturaM.Text = "Factura"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(153, 6)
        '
        'tsmProveedorM
        '
        Me.tsmProveedorM.BackColor = System.Drawing.Color.White
        Me.tsmProveedorM.Name = "tsmProveedorM"
        Me.tsmProveedorM.Size = New System.Drawing.Size(156, 22)
        Me.tsmProveedorM.Text = "Proveedor"
        '
        'tsmRepuestosM
        '
        Me.tsmRepuestosM.BackColor = System.Drawing.Color.White
        Me.tsmRepuestosM.Name = "tsmRepuestosM"
        Me.tsmRepuestosM.Size = New System.Drawing.Size(156, 22)
        Me.tsmRepuestosM.Text = "Repuestos"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(153, 6)
        '
        'tsmEmpleadoM
        '
        Me.tsmEmpleadoM.BackColor = System.Drawing.Color.White
        Me.tsmEmpleadoM.Name = "tsmEmpleadoM"
        Me.tsmEmpleadoM.Size = New System.Drawing.Size(156, 22)
        Me.tsmEmpleadoM.Text = "Empleado"
        '
        'tsmReportes
        '
        Me.tsmReportes.BackColor = System.Drawing.Color.White
        Me.tsmReportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmClienteR, Me.tsmVehiculoR, Me.tsmHojaDeParteR, Me.tsmFacturaR, Me.ToolStripSeparator5, Me.tsmProveedorR, Me.tsmRepuestosR, Me.ToolStripSeparator6, Me.tsmEmpleadoR})
        Me.tsmReportes.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmReportes.Name = "tsmReportes"
        Me.tsmReportes.Size = New System.Drawing.Size(73, 21)
        Me.tsmReportes.Text = "&Reportes"
        '
        'tsmClienteR
        '
        Me.tsmClienteR.BackColor = System.Drawing.Color.White
        Me.tsmClienteR.Name = "tsmClienteR"
        Me.tsmClienteR.Size = New System.Drawing.Size(156, 22)
        Me.tsmClienteR.Text = "Cliente"
        '
        'tsmVehiculoR
        '
        Me.tsmVehiculoR.BackColor = System.Drawing.Color.White
        Me.tsmVehiculoR.Name = "tsmVehiculoR"
        Me.tsmVehiculoR.Size = New System.Drawing.Size(156, 22)
        Me.tsmVehiculoR.Text = "Vehículo"
        '
        'tsmHojaDeParteR
        '
        Me.tsmHojaDeParteR.BackColor = System.Drawing.Color.White
        Me.tsmHojaDeParteR.Name = "tsmHojaDeParteR"
        Me.tsmHojaDeParteR.Size = New System.Drawing.Size(156, 22)
        Me.tsmHojaDeParteR.Text = "Hoja de Parte"
        '
        'tsmFacturaR
        '
        Me.tsmFacturaR.BackColor = System.Drawing.Color.White
        Me.tsmFacturaR.Name = "tsmFacturaR"
        Me.tsmFacturaR.Size = New System.Drawing.Size(156, 22)
        Me.tsmFacturaR.Text = "Factura"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(153, 6)
        '
        'tsmProveedorR
        '
        Me.tsmProveedorR.BackColor = System.Drawing.Color.White
        Me.tsmProveedorR.Name = "tsmProveedorR"
        Me.tsmProveedorR.Size = New System.Drawing.Size(156, 22)
        Me.tsmProveedorR.Text = "Proveedor"
        '
        'tsmRepuestosR
        '
        Me.tsmRepuestosR.BackColor = System.Drawing.Color.White
        Me.tsmRepuestosR.Name = "tsmRepuestosR"
        Me.tsmRepuestosR.Size = New System.Drawing.Size(156, 22)
        Me.tsmRepuestosR.Text = "Repuestos"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(153, 6)
        '
        'tsmEmpleadoR
        '
        Me.tsmEmpleadoR.BackColor = System.Drawing.Color.White
        Me.tsmEmpleadoR.Name = "tsmEmpleadoR"
        Me.tsmEmpleadoR.Size = New System.Drawing.Size(156, 22)
        Me.tsmEmpleadoR.Text = "Empleados"
        '
        'HelpMenu
        '
        Me.HelpMenu.BackColor = System.Drawing.Color.White
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.HelpMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(56, 21)
        Me.HelpMenu.Text = "Ay&uda"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contenido"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.IndexToolStripMenuItem.Text = "&Índice"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.SearchToolStripMenuItem.Image = CType(resources.GetObject("SearchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SearchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SearchToolStripMenuItem.Text = "&Buscar"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(183, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.AboutToolStripMenuItem.Text = "&Acerca de..."
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'frmMDITaller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.UITaller.My.Resources.Resources.Mechanic_interface
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmMDITaller"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Taller Mecánico"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmMantenimiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmReportes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmClienteN As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmVehiculoN As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmHojaDeParteN As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmProveedorN As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmRepuestoN As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmEmpleadoN As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmClienteM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmVehiculoM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmHojaDeParteM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmFacturaM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmProveedorM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmRepuestosM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmEmpleadoM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmClienteR As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmVehiculoR As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmHojaDeParteR As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmFacturaR As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmProveedorR As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmRepuestosR As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmEmpleadoR As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmConectarse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDesconectarse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator

End Class
