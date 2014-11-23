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
        Me.ConectarseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesconectarseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehículoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HojaDeParteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepuestoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EmpleadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehículoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HojaDeParteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProveedorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepuestosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.EmpleadoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehículoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HojaDeParteToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProveedorToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepuestosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.NuevoToolStripMenuItem, Me.ViewMenu, Me.ToolsMenu, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConectarseToolStripMenuItem, Me.DesconectarseToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(60, 20)
        Me.FileMenu.Text = "&Archivo"
        '
        'ConectarseToolStripMenuItem
        '
        Me.ConectarseToolStripMenuItem.Name = "ConectarseToolStripMenuItem"
        Me.ConectarseToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ConectarseToolStripMenuItem.Text = "Conectarse"
        '
        'DesconectarseToolStripMenuItem
        '
        Me.DesconectarseToolStripMenuItem.Name = "DesconectarseToolStripMenuItem"
        Me.DesconectarseToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.DesconectarseToolStripMenuItem.Text = "Desconectarse"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ExitToolStripMenuItem.Text = "&Salir"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.VehículoToolStripMenuItem, Me.HojaDeParteToolStripMenuItem, Me.EmpleadoToolStripMenuItem, Me.ToolStripSeparator1, Me.ProveedorToolStripMenuItem, Me.RepuestoToolStripMenuItem, Me.ToolStripSeparator2, Me.EmpleadoToolStripMenuItem1})
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'VehículoToolStripMenuItem
        '
        Me.VehículoToolStripMenuItem.Name = "VehículoToolStripMenuItem"
        Me.VehículoToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.VehículoToolStripMenuItem.Text = "Vehículo"
        '
        'HojaDeParteToolStripMenuItem
        '
        Me.HojaDeParteToolStripMenuItem.Name = "HojaDeParteToolStripMenuItem"
        Me.HojaDeParteToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.HojaDeParteToolStripMenuItem.Text = "Hoja de Parte"
        '
        'EmpleadoToolStripMenuItem
        '
        Me.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem"
        Me.EmpleadoToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.EmpleadoToolStripMenuItem.Text = "Factura"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(142, 6)
        '
        'ProveedorToolStripMenuItem
        '
        Me.ProveedorToolStripMenuItem.Name = "ProveedorToolStripMenuItem"
        Me.ProveedorToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.ProveedorToolStripMenuItem.Text = "Proveedor"
        '
        'RepuestoToolStripMenuItem
        '
        Me.RepuestoToolStripMenuItem.Name = "RepuestoToolStripMenuItem"
        Me.RepuestoToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.RepuestoToolStripMenuItem.Text = "Repuesto"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(142, 6)
        '
        'EmpleadoToolStripMenuItem1
        '
        Me.EmpleadoToolStripMenuItem1.Name = "EmpleadoToolStripMenuItem1"
        Me.EmpleadoToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.EmpleadoToolStripMenuItem1.Text = "Empleado"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem1, Me.VehículoToolStripMenuItem1, Me.HojaDeParteToolStripMenuItem1, Me.FacturaToolStripMenuItem, Me.ToolStripSeparator3, Me.ProveedorToolStripMenuItem1, Me.RepuestosToolStripMenuItem, Me.ToolStripSeparator4, Me.EmpleadoToolStripMenuItem2})
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(101, 20)
        Me.ViewMenu.Text = "&Mantenimiento"
        '
        'ClienteToolStripMenuItem1
        '
        Me.ClienteToolStripMenuItem1.Name = "ClienteToolStripMenuItem1"
        Me.ClienteToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.ClienteToolStripMenuItem1.Text = "Cliente"
        '
        'VehículoToolStripMenuItem1
        '
        Me.VehículoToolStripMenuItem1.Name = "VehículoToolStripMenuItem1"
        Me.VehículoToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.VehículoToolStripMenuItem1.Text = "Vehículo"
        '
        'HojaDeParteToolStripMenuItem1
        '
        Me.HojaDeParteToolStripMenuItem1.Name = "HojaDeParteToolStripMenuItem1"
        Me.HojaDeParteToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.HojaDeParteToolStripMenuItem1.Text = "Hoja de Parte"
        '
        'FacturaToolStripMenuItem
        '
        Me.FacturaToolStripMenuItem.Name = "FacturaToolStripMenuItem"
        Me.FacturaToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.FacturaToolStripMenuItem.Text = "Factura"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(142, 6)
        '
        'ProveedorToolStripMenuItem1
        '
        Me.ProveedorToolStripMenuItem1.Name = "ProveedorToolStripMenuItem1"
        Me.ProveedorToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.ProveedorToolStripMenuItem1.Text = "Proveedor"
        '
        'RepuestosToolStripMenuItem
        '
        Me.RepuestosToolStripMenuItem.Name = "RepuestosToolStripMenuItem"
        Me.RepuestosToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.RepuestosToolStripMenuItem.Text = "Repuestos"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(142, 6)
        '
        'EmpleadoToolStripMenuItem2
        '
        Me.EmpleadoToolStripMenuItem2.Name = "EmpleadoToolStripMenuItem2"
        Me.EmpleadoToolStripMenuItem2.Size = New System.Drawing.Size(145, 22)
        Me.EmpleadoToolStripMenuItem2.Text = "Empleado"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem2, Me.VehículoToolStripMenuItem2, Me.HojaDeParteToolStripMenuItem2, Me.FacturaToolStripMenuItem1, Me.ToolStripSeparator5, Me.ProveedorToolStripMenuItem2, Me.RepuestosToolStripMenuItem1, Me.ToolStripSeparator6, Me.EmpleadosToolStripMenuItem})
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(65, 20)
        Me.ToolsMenu.Text = "&Reportes"
        '
        'ClienteToolStripMenuItem2
        '
        Me.ClienteToolStripMenuItem2.Name = "ClienteToolStripMenuItem2"
        Me.ClienteToolStripMenuItem2.Size = New System.Drawing.Size(145, 22)
        Me.ClienteToolStripMenuItem2.Text = "Cliente"
        '
        'VehículoToolStripMenuItem2
        '
        Me.VehículoToolStripMenuItem2.Name = "VehículoToolStripMenuItem2"
        Me.VehículoToolStripMenuItem2.Size = New System.Drawing.Size(145, 22)
        Me.VehículoToolStripMenuItem2.Text = "Vehículo"
        '
        'HojaDeParteToolStripMenuItem2
        '
        Me.HojaDeParteToolStripMenuItem2.Name = "HojaDeParteToolStripMenuItem2"
        Me.HojaDeParteToolStripMenuItem2.Size = New System.Drawing.Size(145, 22)
        Me.HojaDeParteToolStripMenuItem2.Text = "Hoja de Parte"
        '
        'FacturaToolStripMenuItem1
        '
        Me.FacturaToolStripMenuItem1.Name = "FacturaToolStripMenuItem1"
        Me.FacturaToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.FacturaToolStripMenuItem1.Text = "Factura"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(142, 6)
        '
        'ProveedorToolStripMenuItem2
        '
        Me.ProveedorToolStripMenuItem2.Name = "ProveedorToolStripMenuItem2"
        Me.ProveedorToolStripMenuItem2.Size = New System.Drawing.Size(145, 22)
        Me.ProveedorToolStripMenuItem2.Text = "Proveedor"
        '
        'RepuestosToolStripMenuItem1
        '
        Me.RepuestosToolStripMenuItem1.Name = "RepuestosToolStripMenuItem1"
        Me.RepuestosToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.RepuestosToolStripMenuItem1.Text = "Repuestos"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(142, 6)
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(53, 20)
        Me.HelpMenu.Text = "Ay&uda"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contenido"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.IndexToolStripMenuItem.Text = "&Índice"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Image = CType(resources.GetObject("SearchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SearchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SearchToolStripMenuItem.Text = "&Buscar"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(173, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
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
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmMDITaller"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Taller Mecánico"
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
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehículoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HojaDeParteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepuestoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehículoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HojaDeParteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepuestosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehículoToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HojaDeParteToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedorToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepuestosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConectarseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesconectarseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator

End Class
