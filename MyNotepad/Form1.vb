Imports System.Drawing.Printing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        If RichTextBox.Modified Then
            Dim a As MsgBoxResult
            a = MsgBox("Do you want to save TextPad file", MsgBoxStyle.YesNoCancel, "TextPad")
            If a = MsgBoxResult.No Then
                RichTextBox.Clear()
            ElseIf a = MsgBoxResult.Cancel Then
            ElseIf a = MsgBoxResult.Yes Then
                SaveFileDialog.ShowDialog()
                My.Computer.FileSystem.WriteAllText(SaveFileDialog.FileName, RichTextBox.Text, False)
                RichTextBox.Clear()
            End If
        Else
            RichTextBox.Clear()
        End If
    End Sub

    Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click
        If RichTextBox.Modified Then
            Dim ask As MsgBoxResult
            ask = MsgBox("Do You Want to save New Document", MsgBoxStyle.YesNoCancel, "Open Document")
            If ask = MsgBoxResult.No Then
                OpenFileDialog1.ShowDialog()
                RichTextBox.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            ElseIf ask = MsgBoxResult.Cancel Then
            ElseIf ask = MsgBoxResult.Yes Then
                My.Computer.FileSystem.WriteAllText(SaveFileDialog.FileName, RichTextBox.Text, False)
                RichTextBox.Clear()
            End If
        Else
            OpenFileDialog1.ShowDialog()
            Try
                RichTextBox.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        SaveFileDialog.ShowDialog()
        If My.Computer.FileSystem.FileExists(SaveFileDialog.FileName) Then
            Dim ask As MsgBoxResult
            ask = MsgBox("File already exists, Do you want to replace it?", MsgBoxStyle.YesNoCancel, "TextPad Alert!")
            If ask = MsgBoxResult.No Then
                SaveFileDialog.ShowDialog()
            ElseIf ask = MsgBoxResult.Yes Then
                My.Computer.FileSystem.WriteAllText(SaveFileDialog.FileName, RichTextBox.Text, False)
            End If
        Else
            Try
                My.Computer.FileSystem.WriteAllText(SaveFileDialog.FileName, RichTextBox.Text, False)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub BtnSaveAs_Click(sender As Object, e As EventArgs) Handles BtnSaveAs.Click
        SaveFileDialog.ShowDialog()
        If My.Computer.FileSystem.FileExists(SaveFileDialog.FileName) Then
            Dim ask As MsgBoxResult
            ask = MsgBox("File already exists, Do you want to replace it?", MsgBoxStyle.YesNoCancel, "MyNotepad Alert!")
            If ask = MsgBoxResult.No Then
                SaveFileDialog.ShowDialog()
            ElseIf ask = MsgBoxResult.Yes Then
                My.Computer.FileSystem.WriteAllText(SaveFileDialog.FileName, RichTextBox.Text, False)
            End If
        Else
            Try
                My.Computer.FileSystem.WriteAllText(SaveFileDialog.FileName, RichTextBox.Text, False)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub BtnUndo_Click(sender As Object, e As EventArgs) Handles BtnUndo.Click
        If RichTextBox.CanUndo Then
            RichTextBox.Undo()
        Else
        End If
    End Sub

    Private Sub BtnRedo_Click(sender As Object, e As EventArgs) Handles BtnRedo.Click
        RichTextBox.Redo()
    End Sub

    Private Sub BtnCut_Click(sender As Object, e As EventArgs) Handles BtnCut.Click
        My.Computer.Clipboard.Clear()
        If RichTextBox.SelectionLength > 0 Then
            My.Computer.Clipboard.SetText(RichTextBox.SelectedText)
        End If
        RichTextBox.SelectedText = ""
    End Sub

    Private Sub BtnCopy_Click(sender As Object, e As EventArgs) Handles BtnCopy.Click
        My.Computer.Clipboard.Clear()
        If RichTextBox.SelectionLength > 0 Then
            My.Computer.Clipboard.SetText(RichTextBox.SelectedText)
        End If
    End Sub

    Private Sub BtnPaste_Click(sender As Object, e As EventArgs) Handles BtnPaste.Click
        If My.Computer.Clipboard.ContainsText Then
            RichTextBox.Paste()
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        'Delete
    End Sub

    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles BtnFind.Click
        Dim a As String
        Dim b As String
        a = InputBox("Enter Text To Find")
        b = InStr(RichTextBox.Text, a)
        If b Then
            RichTextBox.Focus()
            RichTextBox.SelectionStart = b - 1
            RichTextBox.SelectionLength = Len(a)
        Else
            MsgBox("You have entered wrong text!")
        End If

    End Sub

    Private Sub BtnFindNext_Click(sender As Object, e As EventArgs) Handles BtnFindNext.Click
        Dim a As String
        Dim b As String
        a = InputBox("Enter Text To Find")
        b = InStr(RichTextBox.Text, a)
        If b Then
            RichTextBox.Focus()
            RichTextBox.SelectionStart = b - 1
            RichTextBox.SelectionLength = Len(a)
        Else
            MsgBox("You have entered wrong text!")
        End If

    End Sub

    Private Sub BtnFindPrevious_Click(sender As Object, e As EventArgs) Handles BtnFindPrevious.Click
        Dim a As String
        Dim b As String
        a = InputBox("Enter Text To Find")
        b = InStr(RichTextBox.Text, a)
        If b Then
            RichTextBox.Focus()
            RichTextBox.SelectionStart = b - 1
            RichTextBox.SelectionLength = Len(a)
        Else
            MsgBox("You have entered wrong text!")
        End If
    End Sub

    Private Sub BtnSelectAll_Click(sender As Object, e As EventArgs) Handles BtnSelectAll.Click
        RichTextBox.SelectAll()
    End Sub

    Private Sub BtnTimeDate_Click(sender As Object, e As EventArgs) Handles BtnTimeDate.Click
        RichTextBox.SelectedText = Date.Now.ToString("dd-MMM-yyyy hh:mm:ss")
    End Sub

    Private Sub BtnFont_Click(sender As Object, e As EventArgs) Handles BtnFont.Click
        FontDialog1.ShowDialog()
        RichTextBox.SelectionFont = FontDialog1.Font
    End Sub

    Private Sub BtnFontColor_Click(sender As Object, e As EventArgs) Handles BtnFontColor.Click
        ColorDialog1.ShowDialog()
        RichTextBox.ForeColor = ColorDialog1.Color

    End Sub

    Private Sub BtnBackgroundColor_Click(sender As Object, e As EventArgs) Handles BtnBackgroundColor.Click
        ColorDialog1.ShowDialog()
        RichTextBox.BackColor = ColorDialog1.Color
    End Sub

    Private Sub BtnLeft_Click(sender As Object, e As EventArgs) Handles BtnLeft.Click
        RichTextBox.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub BtnRight_Click(sender As Object, e As EventArgs) Handles BtnRight.Click
        RichTextBox.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub BtnCentre_Click(sender As Object, e As EventArgs) Handles BtnCentre.Click
        RichTextBox.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub BtnYes_Click(sender As Object, e As EventArgs) Handles BtnYes.Click
        RichTextBox.SelectionBullet = True
    End Sub

    Private Sub BtnNo_Click(sender As Object, e As EventArgs) Handles BtnNo.Click
        RichTextBox.SelectionBullet = False
    End Sub

    Private Sub BtnZoomIn_Click(sender As Object, e As EventArgs) Handles BtnZoomIn.Click
        RichTextBox.ZoomFactor = 2
    End Sub

    Private Sub BtnZoomOut_Click(sender As Object, e As EventArgs) Handles BtnZoomOut.Click
        RichTextBox.ZoomFactor = 1
    End Sub

    Private Sub BtnRestoreDefaultZoom_Click(sender As Object, e As EventArgs) Handles BtnRestoreDefaultZoom.Click
        RichTextBox.ZoomFactor = 0
    End Sub

    Private Sub BtnTextToSpeech_Click(sender As Object, e As EventArgs) Handles BtnTextToSpeech.Click
        Dim SAPI As Object
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak(RichTextBox.Text)
        'SAPI.speak(RichTextBox.SelectedText)
    End Sub



    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Arial", 16, FontStyle.Regular)
        e.Graphics.DrawString(RichTextBox.Text, font, Brushes.Black, 200, 200)

    End Sub

    Private Sub BtnPrintPreview_Click(sender As Object, e As EventArgs) Handles BtnPrintPreview.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub BtnPageSetup_Click(sender As Object, e As EventArgs) Handles BtnPageSetup.Click
        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.Document.DefaultPageSettings.Color = False
        PageSetupDialog1.ShowDialog()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If RichTextBox.Modified Then
            Dim a As MsgBoxResult
            a = MsgBox("Do you want to save MyNotepad file", MsgBoxStyle.YesNoCancel, "MyNotepad Documents")
            If a = MsgBoxResult.No Then
                RichTextBox.Clear()
            ElseIf a = MsgBoxResult.Cancel Then
            ElseIf a = MsgBoxResult.Yes Then
                SaveFileDialog.ShowDialog()
                My.Computer.FileSystem.WriteAllText(SaveFileDialog.FileName, RichTextBox.Text, False)
                RichTextBox.Clear()
            End If
        Else
            RichTextBox.Clear()
        End If
    End Sub

    Private Sub RichTextBox_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox.TextChanged

    End Sub

    Private Sub BtnAboutMyNotepad_Click(sender As Object, e As EventArgs) Handles BtnAboutMyNotepad.Click
        AboutMyNotepad.Show()
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox.WordWrap = BtnWordWrap.Checked
        BtnStatusBar.Enabled = BtnWordWrap.Checked
        If (BtnStatusBar.Enabled) Then
            BtnStatusBar.Checked = True
            StatusStrip1.Visible = BtnStatusBar.Checked
        End If
    End Sub

    Private Sub BtnWordWrap_Click(sender As Object, e As EventArgs) Handles BtnWordWrap.Click

    End Sub

    Private Sub BtnWordWrap_CheckedChanged(sender As Object, e As EventArgs) Handles BtnWordWrap.CheckedChanged
        RichTextBox.WordWrap = BtnWordWrap.Checked
        BtnStatusBar.Enabled = BtnWordWrap.Checked
        BtnStatusBar.Checked = True
        BtnStatusBar.Visible = BtnStatusBar.Enabled
    End Sub

    Private Sub BtnStatusBar_CheckedChanged(sender As Object, e As EventArgs) Handles BtnStatusBar.CheckedChanged
        StatusStrip1.Visible = BtnStatusBar.Checked
    End Sub

    Private Sub BtnSearchWithGoogle_Click(sender As Object, e As EventArgs) Handles BtnSearchWithGoogle.Click
        System.Diagnostics.Process.Start("http://www.google.com")
    End Sub

    Private Sub BtnSearchwithBing_Click(sender As Object, e As EventArgs) Handles BtnSearchwithBing.Click
        System.Diagnostics.Process.Start("https://www.bing.com/?scope=web&cc=IN")
    End Sub

    Private Sub btnSendFeedback_Click(sender As Object, e As EventArgs) Handles btnSendFeedback.Click
        Dim email As String = "mdtausifarif@outlook.com"
        Dim subject As String = "Feedback for MyNotepad"
        Dim body As String = "Please enter your feedback here."
        Dim mailto As String = $"mailto:{email}?subject={Uri.EscapeDataString(subject)}&body={Uri.EscapeDataString(body)}"

        Try
            System.Diagnostics.Process.Start(mailto)
        Catch ex As Exception
            MessageBox.Show("Unable to open the default email client. Please ensure that an email client is installed and configured on your system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnStatusBar_Click(sender As Object, e As EventArgs) Handles BtnStatusBar.Click

    End Sub
End Class
