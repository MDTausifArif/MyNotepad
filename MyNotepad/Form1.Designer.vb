<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.BtnFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnPageSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnPrintPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnSearchwithBing = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnFindNext = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnFindPrevious = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnGoTo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnTimeDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnFormat = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnWordWrap = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnFont = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnFontColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnBackgroundColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnAlignment = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnLeft = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnRight = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnCentre = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnBullets = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnYes = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnNo = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnView = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnZoom = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnZoomIn = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnZoomOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnRestoreDefaultZoom = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnStatusBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnTextToSpeech = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnSearchWithGoogle = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSendFeedback = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnAboutMyNotepad = New System.Windows.Forms.ToolStripMenuItem()
        Me.RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Menu.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnFile, Me.BtnEdit, Me.BtnFormat, Me.BtnView, Me.BtnHelp})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(840, 24)
        Me.Menu.TabIndex = 0
        Me.Menu.Text = "Menu"
        '
        'BtnFile
        '
        Me.BtnFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNew, Me.BtnOpen, Me.BtnSave, Me.BtnSaveAs, Me.ToolStripSeparator1, Me.BtnPageSetup, Me.BtnPrintPreview, Me.BtnPrint, Me.ToolStripSeparator6, Me.BtnExit})
        Me.BtnFile.Name = "BtnFile"
        Me.BtnFile.Size = New System.Drawing.Size(37, 20)
        Me.BtnFile.Text = "&File"
        '
        'BtnNew
        '
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.BtnNew.Size = New System.Drawing.Size(186, 22)
        Me.BtnNew.Text = "&New"
        '
        'BtnOpen
        '
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.BtnOpen.Size = New System.Drawing.Size(186, 22)
        Me.BtnOpen.Text = "&Open"
        '
        'BtnSave
        '
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.BtnSave.Size = New System.Drawing.Size(186, 22)
        Me.BtnSave.Text = "&Save"
        '
        'BtnSaveAs
        '
        Me.BtnSaveAs.Name = "BtnSaveAs"
        Me.BtnSaveAs.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.BtnSaveAs.Size = New System.Drawing.Size(186, 22)
        Me.BtnSaveAs.Text = "Save &As"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(183, 6)
        '
        'BtnPageSetup
        '
        Me.BtnPageSetup.Name = "BtnPageSetup"
        Me.BtnPageSetup.Size = New System.Drawing.Size(186, 22)
        Me.BtnPageSetup.Text = "Page Set&up"
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(186, 22)
        Me.BtnPrintPreview.Text = "Print Pre&view"
        '
        'BtnPrint
        '
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.BtnPrint.Size = New System.Drawing.Size(186, 22)
        Me.BtnPrint.Text = "&Print..."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(183, 6)
        '
        'BtnExit
        '
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(186, 22)
        Me.BtnExit.Text = "E&xit"
        '
        'BtnEdit
        '
        Me.BtnEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnRedo, Me.BtnUndo, Me.ToolStripSeparator3, Me.BtnCut, Me.BtnCopy, Me.BtnPaste, Me.BtnDelete, Me.ToolStripSeparator4, Me.BtnSearchwithBing, Me.BtnFind, Me.BtnFindNext, Me.BtnFindPrevious, Me.BtnGoTo, Me.ToolStripSeparator5, Me.BtnSelectAll, Me.BtnTimeDate})
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(39, 20)
        Me.BtnEdit.Text = "&Edit"
        '
        'BtnRedo
        '
        Me.BtnRedo.Name = "BtnRedo"
        Me.BtnRedo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.BtnRedo.Size = New System.Drawing.Size(211, 22)
        Me.BtnRedo.Text = "R&edo"
        '
        'BtnUndo
        '
        Me.BtnUndo.Name = "BtnUndo"
        Me.BtnUndo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.BtnUndo.Size = New System.Drawing.Size(211, 22)
        Me.BtnUndo.Text = "&Undo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(208, 6)
        '
        'BtnCut
        '
        Me.BtnCut.Name = "BtnCut"
        Me.BtnCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.BtnCut.Size = New System.Drawing.Size(211, 22)
        Me.BtnCut.Text = "Cu&t"
        '
        'BtnCopy
        '
        Me.BtnCopy.Name = "BtnCopy"
        Me.BtnCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.BtnCopy.Size = New System.Drawing.Size(211, 22)
        Me.BtnCopy.Text = "&Copy"
        '
        'BtnPaste
        '
        Me.BtnPaste.Name = "BtnPaste"
        Me.BtnPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.BtnPaste.Size = New System.Drawing.Size(211, 22)
        Me.BtnPaste.Text = "&Paste"
        '
        'BtnDelete
        '
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.BtnDelete.Size = New System.Drawing.Size(211, 22)
        Me.BtnDelete.Text = "&Delete"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(208, 6)
        '
        'BtnSearchwithBing
        '
        Me.BtnSearchwithBing.Name = "BtnSearchwithBing"
        Me.BtnSearchwithBing.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.BtnSearchwithBing.Size = New System.Drawing.Size(211, 22)
        Me.BtnSearchwithBing.Text = "&Search with Bing..."
        '
        'BtnFind
        '
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.BtnFind.Size = New System.Drawing.Size(211, 22)
        Me.BtnFind.Text = "&Find..."
        '
        'BtnFindNext
        '
        Me.BtnFindNext.Name = "BtnFindNext"
        Me.BtnFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.BtnFindNext.Size = New System.Drawing.Size(211, 22)
        Me.BtnFindNext.Text = "Find &Next"
        '
        'BtnFindPrevious
        '
        Me.BtnFindPrevious.Name = "BtnFindPrevious"
        Me.BtnFindPrevious.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F3), System.Windows.Forms.Keys)
        Me.BtnFindPrevious.Size = New System.Drawing.Size(211, 22)
        Me.BtnFindPrevious.Text = "Find Pre&vious"
        '
        'BtnGoTo
        '
        Me.BtnGoTo.Name = "BtnGoTo"
        Me.BtnGoTo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.BtnGoTo.Size = New System.Drawing.Size(211, 22)
        Me.BtnGoTo.Text = "&Go To..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(208, 6)
        '
        'BtnSelectAll
        '
        Me.BtnSelectAll.Name = "BtnSelectAll"
        Me.BtnSelectAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.BtnSelectAll.Size = New System.Drawing.Size(211, 22)
        Me.BtnSelectAll.Text = "Select &All"
        '
        'BtnTimeDate
        '
        Me.BtnTimeDate.Name = "BtnTimeDate"
        Me.BtnTimeDate.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.BtnTimeDate.Size = New System.Drawing.Size(211, 22)
        Me.BtnTimeDate.Text = "Time/&Date"
        '
        'BtnFormat
        '
        Me.BtnFormat.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnWordWrap, Me.BtnFont, Me.BtnFontColor, Me.BtnBackgroundColor, Me.BtnAlignment, Me.BtnBullets})
        Me.BtnFormat.Name = "BtnFormat"
        Me.BtnFormat.Size = New System.Drawing.Size(57, 20)
        Me.BtnFormat.Text = "F&ormat"
        '
        'BtnWordWrap
        '
        Me.BtnWordWrap.Checked = True
        Me.BtnWordWrap.CheckOnClick = True
        Me.BtnWordWrap.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BtnWordWrap.Name = "BtnWordWrap"
        Me.BtnWordWrap.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.BtnWordWrap.Size = New System.Drawing.Size(207, 22)
        Me.BtnWordWrap.Text = "&Word Wrap"
        '
        'BtnFont
        '
        Me.BtnFont.Name = "BtnFont"
        Me.BtnFont.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.BtnFont.Size = New System.Drawing.Size(207, 22)
        Me.BtnFont.Text = "&Font..."
        '
        'BtnFontColor
        '
        Me.BtnFontColor.Name = "BtnFontColor"
        Me.BtnFontColor.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.BtnFontColor.Size = New System.Drawing.Size(207, 22)
        Me.BtnFontColor.Text = "Font &Color"
        '
        'BtnBackgroundColor
        '
        Me.BtnBackgroundColor.Name = "BtnBackgroundColor"
        Me.BtnBackgroundColor.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BtnBackgroundColor.Size = New System.Drawing.Size(207, 22)
        Me.BtnBackgroundColor.Text = "&Background Color"
        '
        'BtnAlignment
        '
        Me.BtnAlignment.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnLeft, Me.BtnRight, Me.BtnCentre})
        Me.BtnAlignment.Name = "BtnAlignment"
        Me.BtnAlignment.Size = New System.Drawing.Size(207, 22)
        Me.BtnAlignment.Text = "&Alignment"
        '
        'BtnLeft
        '
        Me.BtnLeft.Name = "BtnLeft"
        Me.BtnLeft.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.BtnLeft.Size = New System.Drawing.Size(151, 22)
        Me.BtnLeft.Text = "&Left"
        '
        'BtnRight
        '
        Me.BtnRight.Name = "BtnRight"
        Me.BtnRight.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.BtnRight.Size = New System.Drawing.Size(151, 22)
        Me.BtnRight.Text = "&Right"
        '
        'BtnCentre
        '
        Me.BtnCentre.Name = "BtnCentre"
        Me.BtnCentre.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.BtnCentre.Size = New System.Drawing.Size(151, 22)
        Me.BtnCentre.Text = "&Centre"
        '
        'BtnBullets
        '
        Me.BtnBullets.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnYes, Me.BtnNo})
        Me.BtnBullets.Name = "BtnBullets"
        Me.BtnBullets.Size = New System.Drawing.Size(207, 22)
        Me.BtnBullets.Text = "B&ullets"
        '
        'BtnYes
        '
        Me.BtnYes.Name = "BtnYes"
        Me.BtnYes.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BtnYes.Size = New System.Drawing.Size(155, 22)
        Me.BtnYes.Text = "&Yes"
        '
        'BtnNo
        '
        Me.BtnNo.Name = "BtnNo"
        Me.BtnNo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.BtnNo.Size = New System.Drawing.Size(155, 22)
        Me.BtnNo.Text = "&No"
        '
        'BtnView
        '
        Me.BtnView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnZoom, Me.BtnStatusBar, Me.BtnTextToSpeech, Me.BtnSearchWithGoogle})
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(44, 20)
        Me.BtnView.Text = "&View"
        '
        'BtnZoom
        '
        Me.BtnZoom.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnZoomIn, Me.BtnZoomOut, Me.BtnRestoreDefaultZoom})
        Me.BtnZoom.Name = "BtnZoom"
        Me.BtnZoom.Size = New System.Drawing.Size(191, 22)
        Me.BtnZoom.Text = "&Zoom"
        '
        'BtnZoomIn
        '
        Me.BtnZoomIn.Name = "BtnZoomIn"
        Me.BtnZoomIn.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
        Me.BtnZoomIn.Size = New System.Drawing.Size(229, 22)
        Me.BtnZoomIn.Text = "Zoom &In"
        '
        'BtnZoomOut
        '
        Me.BtnZoomOut.Name = "BtnZoomOut"
        Me.BtnZoomOut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
        Me.BtnZoomOut.Size = New System.Drawing.Size(229, 22)
        Me.BtnZoomOut.Text = "Zoom &Out"
        '
        'BtnRestoreDefaultZoom
        '
        Me.BtnRestoreDefaultZoom.Name = "BtnRestoreDefaultZoom"
        Me.BtnRestoreDefaultZoom.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D0), System.Windows.Forms.Keys)
        Me.BtnRestoreDefaultZoom.Size = New System.Drawing.Size(229, 22)
        Me.BtnRestoreDefaultZoom.Text = "&Restore Default Zoom"
        '
        'BtnStatusBar
        '
        Me.BtnStatusBar.Checked = True
        Me.BtnStatusBar.CheckOnClick = True
        Me.BtnStatusBar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BtnStatusBar.Name = "BtnStatusBar"
        Me.BtnStatusBar.Size = New System.Drawing.Size(191, 22)
        Me.BtnStatusBar.Text = "&Status Bar"
        '
        'BtnTextToSpeech
        '
        Me.BtnTextToSpeech.Name = "BtnTextToSpeech"
        Me.BtnTextToSpeech.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.BtnTextToSpeech.Size = New System.Drawing.Size(191, 22)
        Me.BtnTextToSpeech.Text = "&Text To Speech"
        '
        'BtnSearchWithGoogle
        '
        Me.BtnSearchWithGoogle.Name = "BtnSearchWithGoogle"
        Me.BtnSearchWithGoogle.Size = New System.Drawing.Size(191, 22)
        Me.BtnSearchWithGoogle.Text = "Search with &Google"
        '
        'BtnHelp
        '
        Me.BtnHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSendFeedback, Me.ToolStripSeparator7, Me.BtnAboutMyNotepad})
        Me.BtnHelp.Name = "BtnHelp"
        Me.BtnHelp.Size = New System.Drawing.Size(44, 20)
        Me.BtnHelp.Text = "&Help"
        '
        'btnSendFeedback
        '
        Me.btnSendFeedback.Name = "btnSendFeedback"
        Me.btnSendFeedback.Size = New System.Drawing.Size(238, 22)
        Me.btnSendFeedback.Text = "Send Feedback"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(235, 6)
        '
        'BtnAboutMyNotepad
        '
        Me.BtnAboutMyNotepad.Name = "BtnAboutMyNotepad"
        Me.BtnAboutMyNotepad.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.BtnAboutMyNotepad.Size = New System.Drawing.Size(238, 22)
        Me.BtnAboutMyNotepad.Text = "&About MyNotepad"
        '
        'RichTextBox
        '
        Me.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox.Location = New System.Drawing.Point(0, 24)
        Me.RichTextBox.Name = "RichTextBox"
        Me.RichTextBox.Size = New System.Drawing.Size(840, 409)
        Me.RichTextBox.TabIndex = 1
        Me.RichTextBox.Text = ""
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.DefaultExt = "txt"
        Me.SaveFileDialog.Filter = "Text files*.txt|"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PageSetupDialog1
        '
        Me.PageSetupDialog1.Document = Me.PrintDocument1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 411)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(840, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(59, 17)
        Me.ToolStripStatusLabel1.Text = "Ln 1,Col 1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "txt"
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Text files*.txt|"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 433)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.RichTextBox)
        Me.Controls.Add(Me.Menu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "MyNotepad"
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Menu As MenuStrip
    Friend WithEvents BtnFile As ToolStripMenuItem
    Friend WithEvents BtnEdit As ToolStripMenuItem
    Friend WithEvents BtnFormat As ToolStripMenuItem
    Friend WithEvents BtnView As ToolStripMenuItem
    Friend WithEvents BtnNew As ToolStripMenuItem
    Friend WithEvents BtnOpen As ToolStripMenuItem
    Friend WithEvents BtnSave As ToolStripMenuItem
    Friend WithEvents BtnUndo As ToolStripMenuItem
    Friend WithEvents BtnCut As ToolStripMenuItem
    Friend WithEvents BtnCopy As ToolStripMenuItem
    Friend WithEvents BtnPaste As ToolStripMenuItem
    Friend WithEvents BtnSaveAs As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BtnPageSetup As ToolStripMenuItem
    Friend WithEvents BtnPrintPreview As ToolStripMenuItem
    Friend WithEvents BtnPrint As ToolStripMenuItem
    Friend WithEvents BtnExit As ToolStripMenuItem
    Friend WithEvents BtnDelete As ToolStripMenuItem
    Friend WithEvents BtnSearchwithBing As ToolStripMenuItem
    Friend WithEvents BtnFind As ToolStripMenuItem
    Friend WithEvents BtnFindNext As ToolStripMenuItem
    Friend WithEvents BtnFindPrevious As ToolStripMenuItem
    Friend WithEvents BtnGoTo As ToolStripMenuItem
    Friend WithEvents BtnSelectAll As ToolStripMenuItem
    Friend WithEvents BtnTimeDate As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents BtnWordWrap As ToolStripMenuItem
    Friend WithEvents BtnFont As ToolStripMenuItem
    Friend WithEvents BtnZoom As ToolStripMenuItem
    Friend WithEvents BtnZoomIn As ToolStripMenuItem
    Friend WithEvents BtnZoomOut As ToolStripMenuItem
    Friend WithEvents BtnRestoreDefaultZoom As ToolStripMenuItem
    Friend WithEvents BtnStatusBar As ToolStripMenuItem
    Friend WithEvents BtnHelp As ToolStripMenuItem
    Friend WithEvents BtnAboutMyNotepad As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents BtnFontColor As ToolStripMenuItem
    Friend WithEvents BtnBackgroundColor As ToolStripMenuItem
    Friend WithEvents BtnAlignment As ToolStripMenuItem
    Friend WithEvents BtnLeft As ToolStripMenuItem
    Friend WithEvents BtnRight As ToolStripMenuItem
    Friend WithEvents BtnCentre As ToolStripMenuItem
    Friend WithEvents BtnBullets As ToolStripMenuItem
    Friend WithEvents BtnYes As ToolStripMenuItem
    Friend WithEvents BtnNo As ToolStripMenuItem
    Friend WithEvents BtnTextToSpeech As ToolStripMenuItem
    Friend WithEvents BtnSearchWithGoogle As ToolStripMenuItem
    Friend WithEvents RichTextBox As RichTextBox
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents BtnRedo As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents btnSendFeedback As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
End Class
