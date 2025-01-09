<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBMI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBMI))
        Me.picBMI1 = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCalculator = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConvertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFI = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstSystem = New System.Windows.Forms.ListBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.picCalc = New System.Windows.Forms.PictureBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblSystem = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblClick = New System.Windows.Forms.Label()
        Me.picBMI2 = New System.Windows.Forms.PictureBox()
        Me.btnRevert = New System.Windows.Forms.Button()
        Me.lblMeasure = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.picBMI1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picCalc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBMI2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBMI1
        '
        Me.picBMI1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBMI1.BackgroundImage = CType(resources.GetObject("picBMI1.BackgroundImage"), System.Drawing.Image)
        Me.picBMI1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBMI1.Location = New System.Drawing.Point(425, 262)
        Me.picBMI1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picBMI1.Name = "picBMI1"
        Me.picBMI1.Size = New System.Drawing.Size(114, 85)
        Me.picBMI1.TabIndex = 0
        Me.picBMI1.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.BackColor = System.Drawing.Color.DimGray
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(-1, 21)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(610, 40)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "BMI Calculator"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuView, Me.mnuTools})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(609, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 22)
        Me.mnuFile.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(101, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(101, 22)
        Me.mnuExit.Text = "&Exit"
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCalculator, Me.mnuBMI})
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(44, 22)
        Me.mnuView.Text = "&View"
        '
        'mnuCalculator
        '
        Me.mnuCalculator.Enabled = False
        Me.mnuCalculator.Name = "mnuCalculator"
        Me.mnuCalculator.Size = New System.Drawing.Size(128, 22)
        Me.mnuCalculator.Text = "&Calculator"
        '
        'mnuBMI
        '
        Me.mnuBMI.Name = "mnuBMI"
        Me.mnuBMI.Size = New System.Drawing.Size(128, 22)
        Me.mnuBMI.Text = "&BMI Chart"
        '
        'mnuTools
        '
        Me.mnuTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConvertToolStripMenuItem})
        Me.mnuTools.Name = "mnuTools"
        Me.mnuTools.Size = New System.Drawing.Size(46, 22)
        Me.mnuTools.Text = "&Tools"
        '
        'ConvertToolStripMenuItem
        '
        Me.ConvertToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFI})
        Me.ConvertToolStripMenuItem.Name = "ConvertToolStripMenuItem"
        Me.ConvertToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConvertToolStripMenuItem.Text = "&Convert"
        '
        'mnuFI
        '
        Me.mnuFI.Name = "mnuFI"
        Me.mnuFI.Size = New System.Drawing.Size(180, 22)
        Me.mnuFI.Text = "&feet to inches"
        '
        'lstSystem
        '
        Me.lstSystem.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lstSystem.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSystem.FormattingEnabled = True
        Me.lstSystem.ItemHeight = 21
        Me.lstSystem.Items.AddRange(New Object() {"Imperial (lb)", "Metric (kg)"})
        Me.lstSystem.Location = New System.Drawing.Point(296, 73)
        Me.lstSystem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstSystem.Name = "lstSystem"
        Me.lstSystem.Size = New System.Drawing.Size(106, 46)
        Me.lstSystem.TabIndex = 3
        '
        'txtWeight
        '
        Me.txtWeight.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtWeight.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(296, 198)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(106, 29)
        Me.txtWeight.TabIndex = 4
        '
        'txtHeight
        '
        Me.txtHeight.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtHeight.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(296, 143)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(106, 29)
        Me.txtHeight.TabIndex = 5
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSubmit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSubmit.Enabled = False
        Me.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnSubmit.FlatAppearance.BorderSize = 3
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.Black
        Me.btnSubmit.Location = New System.Drawing.Point(255, 247)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(102, 39)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "Calculate"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblHeight
        '
        Me.lblHeight.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHeight.AutoSize = True
        Me.lblHeight.BackColor = System.Drawing.Color.DimGray
        Me.lblHeight.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.ForeColor = System.Drawing.Color.White
        Me.lblHeight.Location = New System.Drawing.Point(206, 146)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(62, 21)
        Me.lblHeight.TabIndex = 9
        Me.lblHeight.Text = "Height:"
        '
        'picCalc
        '
        Me.picCalc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picCalc.BackColor = System.Drawing.Color.DimGray
        Me.picCalc.Location = New System.Drawing.Point(86, 64)
        Me.picCalc.Name = "picCalc"
        Me.picCalc.Size = New System.Drawing.Size(453, 283)
        Me.picCalc.TabIndex = 8
        Me.picCalc.TabStop = False
        '
        'lblWeight
        '
        Me.lblWeight.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblWeight.AutoSize = True
        Me.lblWeight.BackColor = System.Drawing.Color.DimGray
        Me.lblWeight.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.ForeColor = System.Drawing.Color.White
        Me.lblWeight.Location = New System.Drawing.Point(206, 201)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(65, 21)
        Me.lblWeight.TabIndex = 10
        Me.lblWeight.Text = "Weight:"
        '
        'lblSystem
        '
        Me.lblSystem.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSystem.AutoSize = True
        Me.lblSystem.BackColor = System.Drawing.Color.DimGray
        Me.lblSystem.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystem.ForeColor = System.Drawing.Color.White
        Me.lblSystem.Location = New System.Drawing.Point(206, 84)
        Me.lblSystem.Name = "lblSystem"
        Me.lblSystem.Size = New System.Drawing.Size(69, 21)
        Me.lblSystem.TabIndex = 11
        Me.lblSystem.Text = "System:"
        '
        'lblAnswer
        '
        Me.lblAnswer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAnswer.BackColor = System.Drawing.Color.Black
        Me.lblAnswer.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.ForeColor = System.Drawing.Color.White
        Me.lblAnswer.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblAnswer.Location = New System.Drawing.Point(246, 308)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(117, 32)
        Me.lblAnswer.TabIndex = 12
        Me.lblAnswer.Text = "BMI"
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblClick
        '
        Me.lblClick.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClick.AutoSize = True
        Me.lblClick.BackColor = System.Drawing.Color.Black
        Me.lblClick.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClick.ForeColor = System.Drawing.Color.White
        Me.lblClick.Location = New System.Drawing.Point(434, 294)
        Me.lblClick.Name = "lblClick"
        Me.lblClick.Size = New System.Drawing.Size(101, 19)
        Me.lblClick.TabIndex = 13
        Me.lblClick.Text = "click to expand"
        '
        'picBMI2
        '
        Me.picBMI2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBMI2.BackgroundImage = CType(resources.GetObject("picBMI2.BackgroundImage"), System.Drawing.Image)
        Me.picBMI2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBMI2.Location = New System.Drawing.Point(86, 64)
        Me.picBMI2.Name = "picBMI2"
        Me.picBMI2.Size = New System.Drawing.Size(379, 283)
        Me.picBMI2.TabIndex = 15
        Me.picBMI2.TabStop = False
        Me.picBMI2.Visible = False
        '
        'btnRevert
        '
        Me.btnRevert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRevert.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRevert.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnRevert.FlatAppearance.BorderSize = 3
        Me.btnRevert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRevert.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRevert.Location = New System.Drawing.Point(471, 262)
        Me.btnRevert.Name = "btnRevert"
        Me.btnRevert.Size = New System.Drawing.Size(97, 85)
        Me.btnRevert.TabIndex = 16
        Me.btnRevert.Text = "calculator"
        Me.btnRevert.UseVisualStyleBackColor = False
        Me.btnRevert.Visible = False
        '
        'lblMeasure
        '
        Me.lblMeasure.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMeasure.AutoSize = True
        Me.lblMeasure.BackColor = System.Drawing.Color.DimGray
        Me.lblMeasure.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeasure.ForeColor = System.Drawing.Color.White
        Me.lblMeasure.Location = New System.Drawing.Point(408, 146)
        Me.lblMeasure.Name = "lblMeasure"
        Me.lblMeasure.Size = New System.Drawing.Size(15, 21)
        Me.lblMeasure.TabIndex = 17
        Me.lblMeasure.Text = " "
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnClear.FlatAppearance.BorderSize = 3
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(95, 294)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(68, 53)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmBMI
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(609, 377)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblMeasure)
        Me.Controls.Add(Me.lblClick)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblSystem)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.lstSystem)
        Me.Controls.Add(Me.picBMI1)
        Me.Controls.Add(Me.picCalc)
        Me.Controls.Add(Me.picBMI2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnRevert)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(510, 376)
        Me.Name = "frmBMI"
        Me.Text = "BMI Calculator"
        CType(Me.picBMI1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picCalc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBMI2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBMI1 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuView As ToolStripMenuItem
    Friend WithEvents mnuCalculator As ToolStripMenuItem
    Friend WithEvents mnuBMI As ToolStripMenuItem
    Friend WithEvents lstSystem As ListBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblHeight As Label
    Friend WithEvents picCalc As PictureBox
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblSystem As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents lblClick As Label
    Friend WithEvents picBMI2 As PictureBox
    Friend WithEvents btnRevert As Button
    Friend WithEvents lblMeasure As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents mnuTools As ToolStripMenuItem
    Friend WithEvents ConvertToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuFI As ToolStripMenuItem
End Class
