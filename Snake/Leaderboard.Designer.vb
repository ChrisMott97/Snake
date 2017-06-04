<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leaderboard
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
        Me.lblLeaderboard = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lvLeaderboard = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'lblLeaderboard
        '
        Me.lblLeaderboard.AutoSize = True
        Me.lblLeaderboard.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeaderboard.Location = New System.Drawing.Point(123, 41)
        Me.lblLeaderboard.Name = "lblLeaderboard"
        Me.lblLeaderboard.Size = New System.Drawing.Size(203, 36)
        Me.lblLeaderboard.TabIndex = 3
        Me.lblLeaderboard.Text = "Leaderboard"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(182, 397)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(117, 25)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lvLeaderboard
        '
        Me.lvLeaderboard.Location = New System.Drawing.Point(25, 82)
        Me.lvLeaderboard.Name = "lvLeaderboard"
        Me.lvLeaderboard.Size = New System.Drawing.Size(431, 309)
        Me.lvLeaderboard.TabIndex = 6
        Me.lvLeaderboard.UseCompatibleStateImageBehavior = False
        Me.lvLeaderboard.View = System.Windows.Forms.View.Details
        '
        'Leaderboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 440)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lvLeaderboard)
        Me.Controls.Add(Me.lblLeaderboard)
        Me.Name = "Leaderboard"
        Me.Text = "Leaderboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLeaderboard As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lvLeaderboard As ListView
End Class
