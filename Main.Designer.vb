<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
    Me.btnAdd = New System.Windows.Forms.Button()
    Me.tabControl = New System.Windows.Forms.TabControl()
    Me.tabVisitor = New System.Windows.Forms.TabPage()
    Me.btnVisitorHistory = New System.Windows.Forms.Button()
    Me.lblNumToday = New System.Windows.Forms.Label()
    Me.txtNumToday = New System.Windows.Forms.TextBox()
    Me.tabVolunteer = New System.Windows.Forms.TabPage()
    Me.btnVolunteerHistory = New System.Windows.Forms.Button()
    Me.flowPanel = New System.Windows.Forms.FlowLayoutPanel()
    Me.btnStart = New System.Windows.Forms.Button()
    Me.cbVol = New System.Windows.Forms.ComboBox()
    Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
    Me.tabControl.SuspendLayout()
    Me.tabVisitor.SuspendLayout()
    Me.tabVolunteer.SuspendLayout()
    Me.SuspendLayout()
    '
    'btnAdd
    '
    Me.btnAdd.BackColor = System.Drawing.Color.RoyalBlue
    Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
    Me.btnAdd.ForeColor = System.Drawing.Color.White
    Me.btnAdd.Location = New System.Drawing.Point(494, 6)
    Me.btnAdd.Name = "btnAdd"
    Me.btnAdd.Size = New System.Drawing.Size(504, 407)
    Me.btnAdd.TabIndex = 0
    Me.btnAdd.Text = "ADD &VISITOR"
    Me.toolTip.SetToolTip(Me.btnAdd, "Click this button (or press ALT+V on the keyboard) to add a visitor")
    Me.btnAdd.UseVisualStyleBackColor = False
    '
    'tabControl
    '
    Me.tabControl.Controls.Add(Me.tabVisitor)
    Me.tabControl.Controls.Add(Me.tabVolunteer)
    Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tabControl.Location = New System.Drawing.Point(0, 0)
    Me.tabControl.Name = "tabControl"
    Me.tabControl.SelectedIndex = 0
    Me.tabControl.Size = New System.Drawing.Size(1012, 457)
    Me.tabControl.TabIndex = 2
    '
    'tabVisitor
    '
    Me.tabVisitor.Controls.Add(Me.btnVisitorHistory)
    Me.tabVisitor.Controls.Add(Me.lblNumToday)
    Me.tabVisitor.Controls.Add(Me.txtNumToday)
    Me.tabVisitor.Controls.Add(Me.btnAdd)
    Me.tabVisitor.Location = New System.Drawing.Point(4, 34)
    Me.tabVisitor.Name = "tabVisitor"
    Me.tabVisitor.Padding = New System.Windows.Forms.Padding(3)
    Me.tabVisitor.Size = New System.Drawing.Size(1004, 419)
    Me.tabVisitor.TabIndex = 0
    Me.tabVisitor.Text = "Visitors"
    Me.tabVisitor.ToolTipText = "Use this tab to add visitors."
    Me.tabVisitor.UseVisualStyleBackColor = True
    '
    'btnVisitorHistory
    '
    Me.btnVisitorHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.btnVisitorHistory.Cursor = System.Windows.Forms.Cursors.Hand
    Me.btnVisitorHistory.ForeColor = System.Drawing.Color.White
    Me.btnVisitorHistory.Location = New System.Drawing.Point(163, 346)
    Me.btnVisitorHistory.Name = "btnVisitorHistory"
    Me.btnVisitorHistory.Size = New System.Drawing.Size(152, 44)
    Me.btnVisitorHistory.TabIndex = 6
    Me.btnVisitorHistory.Text = "History"
    Me.toolTip.SetToolTip(Me.btnVisitorHistory, "Click here to view historical visitor data")
    Me.btnVisitorHistory.UseVisualStyleBackColor = False
    '
    'lblNumToday
    '
    Me.lblNumToday.AutoSize = True
    Me.lblNumToday.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNumToday.ForeColor = System.Drawing.Color.Black
    Me.lblNumToday.Location = New System.Drawing.Point(38, 102)
    Me.lblNumToday.Name = "lblNumToday"
    Me.lblNumToday.Size = New System.Drawing.Size(256, 25)
    Me.lblNumToday.TabIndex = 2
    Me.lblNumToday.Text = "Number of Visitors Today:"
    Me.lblNumToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'txtNumToday
    '
    Me.txtNumToday.Font = New System.Drawing.Font("Tahoma", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNumToday.Location = New System.Drawing.Point(43, 140)
    Me.txtNumToday.Name = "txtNumToday"
    Me.txtNumToday.ReadOnly = True
    Me.txtNumToday.Size = New System.Drawing.Size(391, 123)
    Me.txtNumToday.TabIndex = 1
    Me.txtNumToday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'tabVolunteer
    '
    Me.tabVolunteer.Controls.Add(Me.btnVolunteerHistory)
    Me.tabVolunteer.Controls.Add(Me.flowPanel)
    Me.tabVolunteer.Controls.Add(Me.btnStart)
    Me.tabVolunteer.Controls.Add(Me.cbVol)
    Me.tabVolunteer.Location = New System.Drawing.Point(4, 34)
    Me.tabVolunteer.Name = "tabVolunteer"
    Me.tabVolunteer.Size = New System.Drawing.Size(1004, 419)
    Me.tabVolunteer.TabIndex = 2
    Me.tabVolunteer.Text = "Volunteers"
    Me.tabVolunteer.ToolTipText = "Check-in/check-out volunteers"
    Me.tabVolunteer.UseVisualStyleBackColor = True
    '
    'btnVolunteerHistory
    '
    Me.btnVolunteerHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
    Me.btnVolunteerHistory.Cursor = System.Windows.Forms.Cursors.Hand
    Me.btnVolunteerHistory.Enabled = False
    Me.btnVolunteerHistory.ForeColor = System.Drawing.Color.White
    Me.btnVolunteerHistory.Location = New System.Drawing.Point(541, 14)
    Me.btnVolunteerHistory.Name = "btnVolunteerHistory"
    Me.btnVolunteerHistory.Size = New System.Drawing.Size(152, 44)
    Me.btnVolunteerHistory.TabIndex = 5
    Me.btnVolunteerHistory.Text = "History"
    Me.toolTip.SetToolTip(Me.btnVolunteerHistory, "Click this button to view the history for the selected volunteer.")
    Me.btnVolunteerHistory.UseVisualStyleBackColor = False
    '
    'flowPanel
    '
    Me.flowPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.flowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.flowPanel.Location = New System.Drawing.Point(8, 65)
    Me.flowPanel.Name = "flowPanel"
    Me.flowPanel.Size = New System.Drawing.Size(988, 346)
    Me.flowPanel.TabIndex = 4
    '
    'btnStart
    '
    Me.btnStart.BackColor = System.Drawing.Color.Green
    Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
    Me.btnStart.Enabled = False
    Me.btnStart.ForeColor = System.Drawing.Color.White
    Me.btnStart.Location = New System.Drawing.Point(371, 14)
    Me.btnStart.Name = "btnStart"
    Me.btnStart.Size = New System.Drawing.Size(152, 44)
    Me.btnStart.TabIndex = 3
    Me.btnStart.Text = "Start"
    Me.toolTip.SetToolTip(Me.btnStart, "Click this button to start counting hours for the selected volunteer.")
    Me.btnStart.UseVisualStyleBackColor = False
    '
    'cbVol
    '
    Me.cbVol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbVol.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cbVol.FormattingEnabled = True
    Me.cbVol.Location = New System.Drawing.Point(8, 12)
    Me.cbVol.Name = "cbVol"
    Me.cbVol.Size = New System.Drawing.Size(342, 47)
    Me.cbVol.Sorted = True
    Me.cbVol.TabIndex = 2
    Me.toolTip.SetToolTip(Me.cbVol, "Select the volunteer who is working today, then click the Start button to start c" & _
        "ounting hours.")
    '
    'Main
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.ClientSize = New System.Drawing.Size(1012, 457)
    Me.Controls.Add(Me.tabControl)
    Me.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ForeColor = System.Drawing.Color.Gray
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Margin = New System.Windows.Forms.Padding(5)
    Me.MaximizeBox = False
    Me.Name = "Main"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Visitor Tracker"
    Me.TopMost = True
    Me.tabControl.ResumeLayout(False)
    Me.tabVisitor.ResumeLayout(False)
    Me.tabVisitor.PerformLayout()
    Me.tabVolunteer.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnAdd As System.Windows.Forms.Button
  Friend WithEvents tabControl As System.Windows.Forms.TabControl
  Friend WithEvents tabVisitor As System.Windows.Forms.TabPage
  Friend WithEvents toolTip As System.Windows.Forms.ToolTip
  Friend WithEvents tabVolunteer As System.Windows.Forms.TabPage
  Friend WithEvents lblNumToday As System.Windows.Forms.Label
  Friend WithEvents txtNumToday As System.Windows.Forms.TextBox
  Friend WithEvents cbVol As System.Windows.Forms.ComboBox
  Friend WithEvents btnStart As System.Windows.Forms.Button
  Friend WithEvents flowPanel As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents btnVisitorHistory As System.Windows.Forms.Button
  Friend WithEvents btnVolunteerHistory As System.Windows.Forms.Button

End Class
