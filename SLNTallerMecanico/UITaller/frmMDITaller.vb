Imports System.Windows.Forms

Public Class frmMDITaller

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmClienteN.Click
        Dim ventana As frmClienteNuevo = New frmClienteNuevo
        ventana.ShowDialog()
    End Sub

    Private Sub ClienteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles tsmClienteM.Click
        Dim ventana2 As frmClienteActualizar = New frmClienteActualizar
        ventana2.ShowDialog()
        Dim ventana As frmClienteBorrar = New frmClienteBorrar
        ventana.ShowDialog()

    End Sub

    Private Sub ClienteToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles tsmClienteR.Click
        Dim ventana As frmReporteClientes = New frmReporteClientes
        ventana.ShowDialog()
    End Sub

    Private Sub ConectarseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmConectarse.Click
        Dim ventana As frmLoginTaller = New frmLoginTaller
        ventana.ShowDialog()
    End Sub

    Private Sub frmMDITaller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tsmNuevo.Enabled = False
        tsmMantenimiento.Enabled = False
        tsmReportes.Enabled = False
        tsmDesconectarse.Visible = False
    End Sub

    Private Sub tsmVehiculoN_Click(sender As Object, e As EventArgs) Handles tsmVehiculoN.Click
        Dim ventana As frmVehiculoNuevo = New frmVehiculoNuevo
        ventana.ShowDialog()
    End Sub

    Private Sub tsmEmpleadoN_Click(sender As Object, e As EventArgs) Handles tsmEmpleadoN.Click
        Dim ventana1 As frmNuevoUsuario = New frmNuevoUsuario
        ventana1.ShowDialog()
    End Sub

    Private Sub tsmHojaDeParteN_Click(sender As Object, e As EventArgs) Handles tsmHojaDeParteN.Click
        Dim ventana As frmHojadeParteNuevo = New frmHojadeParteNuevo
        ventana.ShowDialog()
    End Sub

    Private Sub tsmFacturaN_Click(sender As Object, e As EventArgs) Handles tsmFacturaN.Click

    End Sub

    Private Sub tsmProveedorN_Click(sender As Object, e As EventArgs) Handles tsmProveedorN.Click
        Dim ventana As frmProveedorNuevo = New frmProveedorNuevo
        ventana.ShowDialog()
    End Sub

    Private Sub tsmRepuestoN_Click(sender As Object, e As EventArgs) Handles tsmRepuestoN.Click
        Dim ventana As frmRepuestoNuevo = New frmRepuestoNuevo
        ventana.ShowDialog()
    End Sub
End Class
