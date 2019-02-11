<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileMate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LB_OldNames = New System.Windows.Forms.ListBox()
        Me.LB_Preview = New System.Windows.Forms.ListBox()
        Me.btn_run = New System.Windows.Forms.Button()
        Me.TB_DirPath = New System.Windows.Forms.TextBox()
        Me.TB_NewPath = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LB_OldNames
        '
        Me.LB_OldNames.FormattingEnabled = True
        Me.LB_OldNames.Location = New System.Drawing.Point(22, 52)
        Me.LB_OldNames.Name = "LB_OldNames"
        Me.LB_OldNames.Size = New System.Drawing.Size(245, 511)
        Me.LB_OldNames.TabIndex = 0
        '
        'LB_Preview
        '
        Me.LB_Preview.FormattingEnabled = True
        Me.LB_Preview.Location = New System.Drawing.Point(354, 52)
        Me.LB_Preview.Name = "LB_Preview"
        Me.LB_Preview.Size = New System.Drawing.Size(244, 511)
        Me.LB_Preview.TabIndex = 1
        '
        'btn_run
        '
        Me.btn_run.Location = New System.Drawing.Point(273, 114)
        Me.btn_run.Name = "btn_run"
        Me.btn_run.Size = New System.Drawing.Size(75, 23)
        Me.btn_run.TabIndex = 2
        Me.btn_run.Text = "Run"
        Me.btn_run.UseVisualStyleBackColor = True
        '
        'TB_DirPath
        '
        Me.TB_DirPath.Location = New System.Drawing.Point(22, 23)
        Me.TB_DirPath.Name = "TB_DirPath"
        Me.TB_DirPath.Size = New System.Drawing.Size(245, 20)
        Me.TB_DirPath.TabIndex = 3
        '
        'TB_NewPath
        '
        Me.TB_NewPath.Location = New System.Drawing.Point(354, 23)
        Me.TB_NewPath.Name = "TB_NewPath"
        Me.TB_NewPath.Size = New System.Drawing.Size(244, 20)
        Me.TB_NewPath.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(273, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(273, 172)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FileMate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 589)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TB_NewPath)
        Me.Controls.Add(Me.TB_DirPath)
        Me.Controls.Add(Me.btn_run)
        Me.Controls.Add(Me.LB_Preview)
        Me.Controls.Add(Me.LB_OldNames)
        Me.Name = "FileMate"
        Me.Text = "FileMate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LB_OldNames As ListBox
    Friend WithEvents LB_Preview As ListBox
    Friend WithEvents btn_run As Button
    Friend WithEvents TB_DirPath As TextBox
    Friend WithEvents TB_NewPath As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
