<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
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
        Me.Tabs = New System.Windows.Forms.TabControl()
        Me.tabSize = New System.Windows.Forms.TabPage()
        Me.lblGameHeight = New System.Windows.Forms.Label()
        Me.udGameHeight = New System.Windows.Forms.NumericUpDown()
        Me.lblGameWidth = New System.Windows.Forms.Label()
        Me.udGameWidth = New System.Windows.Forms.NumericUpDown()
        Me.tabColours = New System.Windows.Forms.TabPage()
        Me.lblFoodColour = New System.Windows.Forms.Label()
        Me.btnFoodColour = New System.Windows.Forms.Button()
        Me.lblSnakeColour = New System.Windows.Forms.Label()
        Me.btnSnakeColour = New System.Windows.Forms.Button()
        Me.lblBoardColour = New System.Windows.Forms.Label()
        Me.btnBoardColour = New System.Windows.Forms.Button()
        Me.tabOther = New System.Windows.Forms.TabPage()
        Me.lblAppleAmount = New System.Windows.Forms.Label()
        Me.udAppleAmount = New System.Windows.Forms.NumericUpDown()
        Me.cbLengthIncrease = New System.Windows.Forms.CheckBox()
        Me.cbSpeedIncrease = New System.Windows.Forms.CheckBox()
        Me.cbDeathWalls = New System.Windows.Forms.CheckBox()
        Me.tbStartSpeed = New System.Windows.Forms.TrackBar()
        Me.lblStartSpeed = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.selectColour = New System.Windows.Forms.ColorDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLeaderboard = New System.Windows.Forms.Button()
        Me.Tabs.SuspendLayout()
        Me.tabSize.SuspendLayout()
        CType(Me.udGameHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udGameWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabColours.SuspendLayout()
        Me.tabOther.SuspendLayout()
        CType(Me.udAppleAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbStartSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tabs
        '
        Me.Tabs.Controls.Add(Me.tabSize)
        Me.Tabs.Controls.Add(Me.tabColours)
        Me.Tabs.Controls.Add(Me.tabOther)
        Me.Tabs.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tabs.Location = New System.Drawing.Point(12, 41)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(276, 239)
        Me.Tabs.TabIndex = 0
        '
        'tabSize
        '
        Me.tabSize.Controls.Add(Me.lblGameHeight)
        Me.tabSize.Controls.Add(Me.udGameHeight)
        Me.tabSize.Controls.Add(Me.lblGameWidth)
        Me.tabSize.Controls.Add(Me.udGameWidth)
        Me.tabSize.Location = New System.Drawing.Point(4, 27)
        Me.tabSize.Name = "tabSize"
        Me.tabSize.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSize.Size = New System.Drawing.Size(268, 208)
        Me.tabSize.TabIndex = 0
        Me.tabSize.Text = "Sizes"
        Me.tabSize.UseVisualStyleBackColor = True
        '
        'lblGameHeight
        '
        Me.lblGameHeight.AutoSize = True
        Me.lblGameHeight.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameHeight.Location = New System.Drawing.Point(5, 100)
        Me.lblGameHeight.Name = "lblGameHeight"
        Me.lblGameHeight.Size = New System.Drawing.Size(174, 30)
        Me.lblGameHeight.TabIndex = 3
        Me.lblGameHeight.Text = "Game Height"
        '
        'udGameHeight
        '
        Me.udGameHeight.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udGameHeight.Location = New System.Drawing.Point(185, 100)
        Me.udGameHeight.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.udGameHeight.Minimum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.udGameHeight.Name = "udGameHeight"
        Me.udGameHeight.Size = New System.Drawing.Size(53, 37)
        Me.udGameHeight.TabIndex = 2
        Me.udGameHeight.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'lblGameWidth
        '
        Me.lblGameWidth.AutoSize = True
        Me.lblGameWidth.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameWidth.Location = New System.Drawing.Point(14, 59)
        Me.lblGameWidth.Name = "lblGameWidth"
        Me.lblGameWidth.Size = New System.Drawing.Size(165, 30)
        Me.lblGameWidth.TabIndex = 1
        Me.lblGameWidth.Text = "Game Width"
        '
        'udGameWidth
        '
        Me.udGameWidth.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udGameWidth.Location = New System.Drawing.Point(185, 59)
        Me.udGameWidth.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.udGameWidth.Minimum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.udGameWidth.Name = "udGameWidth"
        Me.udGameWidth.Size = New System.Drawing.Size(53, 37)
        Me.udGameWidth.TabIndex = 0
        Me.udGameWidth.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'tabColours
        '
        Me.tabColours.Controls.Add(Me.lblFoodColour)
        Me.tabColours.Controls.Add(Me.btnFoodColour)
        Me.tabColours.Controls.Add(Me.lblSnakeColour)
        Me.tabColours.Controls.Add(Me.btnSnakeColour)
        Me.tabColours.Controls.Add(Me.lblBoardColour)
        Me.tabColours.Controls.Add(Me.btnBoardColour)
        Me.tabColours.Location = New System.Drawing.Point(4, 27)
        Me.tabColours.Name = "tabColours"
        Me.tabColours.Padding = New System.Windows.Forms.Padding(3)
        Me.tabColours.Size = New System.Drawing.Size(268, 208)
        Me.tabColours.TabIndex = 1
        Me.tabColours.Text = "Colours"
        Me.tabColours.UseVisualStyleBackColor = True
        '
        'lblFoodColour
        '
        Me.lblFoodColour.AutoSize = True
        Me.lblFoodColour.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoodColour.Location = New System.Drawing.Point(23, 116)
        Me.lblFoodColour.Name = "lblFoodColour"
        Me.lblFoodColour.Size = New System.Drawing.Size(160, 30)
        Me.lblFoodColour.TabIndex = 6
        Me.lblFoodColour.Text = "Food Colour"
        '
        'btnFoodColour
        '
        Me.btnFoodColour.BackColor = System.Drawing.Color.DarkRed
        Me.btnFoodColour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFoodColour.Location = New System.Drawing.Point(184, 116)
        Me.btnFoodColour.Name = "btnFoodColour"
        Me.btnFoodColour.Size = New System.Drawing.Size(34, 32)
        Me.btnFoodColour.TabIndex = 5
        Me.btnFoodColour.UseVisualStyleBackColor = False
        '
        'lblSnakeColour
        '
        Me.lblSnakeColour.AutoSize = True
        Me.lblSnakeColour.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSnakeColour.Location = New System.Drawing.Point(12, 78)
        Me.lblSnakeColour.Name = "lblSnakeColour"
        Me.lblSnakeColour.Size = New System.Drawing.Size(171, 30)
        Me.lblSnakeColour.TabIndex = 4
        Me.lblSnakeColour.Text = "Snake Colour"
        '
        'btnSnakeColour
        '
        Me.btnSnakeColour.BackColor = System.Drawing.Color.White
        Me.btnSnakeColour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSnakeColour.Location = New System.Drawing.Point(184, 76)
        Me.btnSnakeColour.Name = "btnSnakeColour"
        Me.btnSnakeColour.Size = New System.Drawing.Size(34, 32)
        Me.btnSnakeColour.TabIndex = 3
        Me.btnSnakeColour.UseVisualStyleBackColor = False
        '
        'lblBoardColour
        '
        Me.lblBoardColour.AutoSize = True
        Me.lblBoardColour.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBoardColour.Location = New System.Drawing.Point(14, 36)
        Me.lblBoardColour.Name = "lblBoardColour"
        Me.lblBoardColour.Size = New System.Drawing.Size(169, 30)
        Me.lblBoardColour.TabIndex = 2
        Me.lblBoardColour.Text = "Board Colour"
        '
        'btnBoardColour
        '
        Me.btnBoardColour.BackColor = System.Drawing.Color.Black
        Me.btnBoardColour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBoardColour.Location = New System.Drawing.Point(184, 36)
        Me.btnBoardColour.Name = "btnBoardColour"
        Me.btnBoardColour.Size = New System.Drawing.Size(34, 32)
        Me.btnBoardColour.TabIndex = 0
        Me.btnBoardColour.UseVisualStyleBackColor = False
        '
        'tabOther
        '
        Me.tabOther.Controls.Add(Me.lblAppleAmount)
        Me.tabOther.Controls.Add(Me.udAppleAmount)
        Me.tabOther.Controls.Add(Me.cbLengthIncrease)
        Me.tabOther.Controls.Add(Me.cbSpeedIncrease)
        Me.tabOther.Controls.Add(Me.cbDeathWalls)
        Me.tabOther.Controls.Add(Me.tbStartSpeed)
        Me.tabOther.Controls.Add(Me.lblStartSpeed)
        Me.tabOther.Location = New System.Drawing.Point(4, 27)
        Me.tabOther.Name = "tabOther"
        Me.tabOther.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOther.Size = New System.Drawing.Size(268, 208)
        Me.tabOther.TabIndex = 2
        Me.tabOther.Text = "Other"
        Me.tabOther.UseVisualStyleBackColor = True
        '
        'lblAppleAmount
        '
        Me.lblAppleAmount.AutoSize = True
        Me.lblAppleAmount.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppleAmount.Location = New System.Drawing.Point(12, 168)
        Me.lblAppleAmount.Name = "lblAppleAmount"
        Me.lblAppleAmount.Size = New System.Drawing.Size(146, 22)
        Me.lblAppleAmount.TabIndex = 4
        Me.lblAppleAmount.Text = "Apple Amount"
        '
        'udAppleAmount
        '
        Me.udAppleAmount.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.udAppleAmount.Location = New System.Drawing.Point(164, 165)
        Me.udAppleAmount.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.udAppleAmount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.udAppleAmount.Name = "udAppleAmount"
        Me.udAppleAmount.Size = New System.Drawing.Size(53, 31)
        Me.udAppleAmount.TabIndex = 3
        Me.udAppleAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.udAppleAmount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cbLengthIncrease
        '
        Me.cbLengthIncrease.AutoSize = True
        Me.cbLengthIncrease.Checked = True
        Me.cbLengthIncrease.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbLengthIncrease.Location = New System.Drawing.Point(29, 137)
        Me.cbLengthIncrease.Name = "cbLengthIncrease"
        Me.cbLengthIncrease.Size = New System.Drawing.Size(221, 24)
        Me.cbLengthIncrease.TabIndex = 8
        Me.cbLengthIncrease.Text = "Length increase with Food"
        Me.cbLengthIncrease.UseVisualStyleBackColor = True
        '
        'cbSpeedIncrease
        '
        Me.cbSpeedIncrease.AutoSize = True
        Me.cbSpeedIncrease.Checked = True
        Me.cbSpeedIncrease.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSpeedIncrease.Location = New System.Drawing.Point(31, 109)
        Me.cbSpeedIncrease.Name = "cbSpeedIncrease"
        Me.cbSpeedIncrease.Size = New System.Drawing.Size(218, 24)
        Me.cbSpeedIncrease.TabIndex = 7
        Me.cbSpeedIncrease.Text = "Speed increase with Food"
        Me.cbSpeedIncrease.UseVisualStyleBackColor = True
        '
        'cbDeathWalls
        '
        Me.cbDeathWalls.AutoSize = True
        Me.cbDeathWalls.Checked = True
        Me.cbDeathWalls.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbDeathWalls.Location = New System.Drawing.Point(76, 81)
        Me.cbDeathWalls.Name = "cbDeathWalls"
        Me.cbDeathWalls.Size = New System.Drawing.Size(114, 24)
        Me.cbDeathWalls.TabIndex = 6
        Me.cbDeathWalls.Text = "Death Walls"
        Me.cbDeathWalls.UseVisualStyleBackColor = True
        '
        'tbStartSpeed
        '
        Me.tbStartSpeed.LargeChange = 2
        Me.tbStartSpeed.Location = New System.Drawing.Point(76, 30)
        Me.tbStartSpeed.Minimum = 1
        Me.tbStartSpeed.Name = "tbStartSpeed"
        Me.tbStartSpeed.Size = New System.Drawing.Size(104, 45)
        Me.tbStartSpeed.TabIndex = 4
        Me.tbStartSpeed.Value = 5
        '
        'lblStartSpeed
        '
        Me.lblStartSpeed.AutoSize = True
        Me.lblStartSpeed.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartSpeed.Location = New System.Drawing.Point(85, 7)
        Me.lblStartSpeed.Name = "lblStartSpeed"
        Me.lblStartSpeed.Size = New System.Drawing.Size(102, 21)
        Me.lblStartSpeed.TabIndex = 3
        Me.lblStartSpeed.Text = "Start Speed"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(272, 36)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Play"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'selectColour
        '
        Me.selectColour.AnyColor = True
        Me.selectColour.FullOpen = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 36)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Snake"
        '
        'btnLeaderboard
        '
        Me.btnLeaderboard.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeaderboard.Location = New System.Drawing.Point(12, 292)
        Me.btnLeaderboard.Name = "btnLeaderboard"
        Me.btnLeaderboard.Size = New System.Drawing.Size(272, 36)
        Me.btnLeaderboard.TabIndex = 3
        Me.btnLeaderboard.Text = "Leaderboard"
        Me.btnLeaderboard.UseVisualStyleBackColor = True
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 382)
        Me.Controls.Add(Me.btnLeaderboard)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Tabs)
        Me.Name = "Start"
        Me.Text = "Start"
        Me.Tabs.ResumeLayout(False)
        Me.tabSize.ResumeLayout(False)
        Me.tabSize.PerformLayout()
        CType(Me.udGameHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udGameWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabColours.ResumeLayout(False)
        Me.tabColours.PerformLayout()
        Me.tabOther.ResumeLayout(False)
        Me.tabOther.PerformLayout()
        CType(Me.udAppleAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbStartSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tabs As TabControl
    Friend WithEvents tabSize As TabPage
    Friend WithEvents udGameWidth As NumericUpDown
    Friend WithEvents tabColours As TabPage
    Friend WithEvents lblGameHeight As Label
    Friend WithEvents udGameHeight As NumericUpDown
    Friend WithEvents lblGameWidth As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnBoardColour As Button
    Friend WithEvents selectColour As ColorDialog
    Friend WithEvents lblFoodColour As Label
    Friend WithEvents btnFoodColour As Button
    Friend WithEvents lblSnakeColour As Label
    Friend WithEvents btnSnakeColour As Button
    Friend WithEvents lblBoardColour As Label
    Friend WithEvents tabOther As TabPage
    Friend WithEvents lblStartSpeed As Label
    Friend WithEvents tbStartSpeed As TrackBar
    Friend WithEvents cbLengthIncrease As CheckBox
    Friend WithEvents cbSpeedIncrease As CheckBox
    Friend WithEvents cbDeathWalls As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAppleAmount As Label
    Friend WithEvents udAppleAmount As NumericUpDown
    Friend WithEvents btnLeaderboard As Button
End Class
