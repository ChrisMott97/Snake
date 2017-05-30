<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Snake
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
        Me.components = New System.ComponentModel.Container()
        Me.Update = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnPlayPause = New System.Windows.Forms.PictureBox()
        CType(Me.btnPlayPause, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Update
        '
        Me.Update.Enabled = True
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(224, 9)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(19, 21)
        Me.lblScore.TabIndex = 0
        Me.lblScore.Text = "0"
        '
        'btnPlayPause
        '
        Me.btnPlayPause.BackgroundImage = Global.Snake.My.Resources.Resources.pause
        Me.btnPlayPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPlayPause.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlayPause.Location = New System.Drawing.Point(12, 9)
        Me.btnPlayPause.Name = "btnPlayPause"
        Me.btnPlayPause.Size = New System.Drawing.Size(36, 36)
        Me.btnPlayPause.TabIndex = 1
        Me.btnPlayPause.TabStop = False
        '
        'Snake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(475, 415)
        Me.Controls.Add(Me.btnPlayPause)
        Me.Controls.Add(Me.lblScore)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "Snake"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.TransparencyKey = System.Drawing.Color.Wheat
        CType(Me.btnPlayPause, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Update As Timer
    Friend WithEvents lblScore As Label
    Friend WithEvents btnPlayPause As PictureBox
End Class
