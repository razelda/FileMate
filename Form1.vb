Imports System.IO

Public Class FileMate

    Dim OldName As String
    Dim OldName1 As String
    Dim OldName2 As String
    Dim NewName As String
    Dim NewName1 As String
    Dim NewName2 As String
    Dim Formating As String
    Dim OldDir As String
    Dim OldDir1 As String
    Dim NewDir As String
    Dim NewDir1 As String
    Dim SRemove As String = "Season "
    Dim ERemove As String = " Episode "

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.AllowDrop = True
    End Sub
    Private Sub Form1_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Form1_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            OldName = System.IO.Path.GetFileName(path)
            OldDir = System.IO.Path.GetDirectoryName(path)
            NewName = OldName.Replace(SRemove, "")
            NewName = NewName.Replace(ERemove, "x")
            TB_DirPath.Text = OldDir
            TB_NewPath.Text = OldDir
            LB_OldNames.Items.Add(OldName)
            LB_Preview.Items.Add(NewName)

            'MsgBox(path)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_run.Click
        For Each Item In LB_OldNames.Items
            OldName1 = Item
            NewName1 = OldName1.Replace(SRemove, "")
            NewName1 = NewName1.Replace(ERemove, "x")
            OldDir1 = TB_DirPath.Text
            NewDir1 = TB_NewPath.Text
            OldName2 = OldDir1 + "\" + OldName1
            NewName2 = NewDir1 + "\" + NewName1
            Rename(OldName2, NewName2)
        Next


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TB_DirPath.Text = ""
        TB_NewPath.Text = ""
        LB_OldNames.Items.Clear()
        LB_Preview.Items.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class
