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
    Me.tabToday = New System.Windows.Forms.TabPage()
    Me.tabHistory = New System.Windows.Forms.TabPage()
    Me.webBrowser = New System.Windows.Forms.WebBrowser()
    Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
    Me.tabVolunteer = New System.Windows.Forms.TabPage()
    Me.flowPanel = New System.Windows.Forms.FlowLayoutPanel()
    Me.tabControl.SuspendLayout()
    Me.tabToday.SuspendLayout()
    Me.tabHistory.SuspendLayout()
    Me.tabVolunteer.SuspendLayout()
    Me.SuspendLayout()
    '
    'btnAdd
    '
    Me.btnAdd.BackColor = System.Drawing.Color.RoyalBlue
    Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
    Me.btnAdd.ForeColor = System.Drawing.Color.White
    Me.btnAdd.Location = New System.Drawing.Point(18, 22)
    Me.btnAdd.Name = "btnAdd"
    Me.btnAdd.Size = New System.Drawing.Size(214, 160)
    Me.btnAdd.TabIndex = 0
    Me.btnAdd.Text = "ADD VISITOR"
    Me.btnAdd.UseVisualStyleBackColor = False
    '
    'tabControl
    '
    Me.tabControl.Controls.Add(Me.tabToday)
    Me.tabControl.Controls.Add(Me.tabHistory)
    Me.tabControl.Controls.Add(Me.tabVolunteer)
    Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tabControl.Location = New System.Drawing.Point(0, 0)
    Me.tabControl.Name = "tabControl"
    Me.tabControl.SelectedIndex = 0
    Me.tabControl.Size = New System.Drawing.Size(1012, 457)
    Me.tabControl.TabIndex = 2
    '
    'tabToday
    '
    Me.tabToday.Controls.Add(Me.btnAdd)
    Me.tabToday.Location = New System.Drawing.Point(4, 34)
    Me.tabToday.Name = "tabToday"
    Me.tabToday.Padding = New System.Windows.Forms.Padding(3)
    Me.tabToday.Size = New System.Drawing.Size(1004, 419)
    Me.tabToday.TabIndex = 0
    Me.tabToday.Text = "Today"
    Me.tabToday.ToolTipText = "Use this tab to add visitors."
    Me.tabToday.UseVisualStyleBackColor = True
    '
    'tabHistory
    '
    Me.tabHistory.Controls.Add(Me.webBrowser)
    Me.tabHistory.Location = New System.Drawing.Point(4, 34)
    Me.tabHistory.Name = "tabHistory"
    Me.tabHistory.Padding = New System.Windows.Forms.Padding(3)
    Me.tabHistory.Size = New System.Drawing.Size(1004, 419)
    Me.tabHistory.TabIndex = 1
    Me.tabHistory.Text = "History"
    Me.tabHistory.ToolTipText = "View the history of visitors"
    Me.tabHistory.UseVisualStyleBackColor = True
    '
    'webBrowser
    '
    Me.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill
    Me.webBrowser.Location = New System.Drawing.Point(3, 3)
    Me.webBrowser.MinimumSize = New System.Drawing.Size(20, 20)
    Me.webBrowser.Name = "webBrowser"
    Me.webBrowser.Size = New System.Drawing.Size(998, 413)
    Me.webBrowser.TabIndex = 2
    '
    'tabVolunteer
    '
    Me.tabVolunteer.Controls.Add(Me.flowPanel)
    Me.tabVolunteer.Location = New System.Drawing.Point(4, 34)
    Me.tabVolunteer.Name = "tabVolunteer"
    Me.tabVolunteer.Size = New System.Drawing.Size(1004, 419)
    Me.tabVolunteer.TabIndex = 2
    Me.tabVolunteer.Text = "Volunteers"
    Me.tabVolunteer.ToolTipText = "Check-in/check-out volunteers"
    Me.tabVolunteer.UseVisualStyleBackColor = True
    '
    'flowPanel
    '
    Me.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.flowPanel.Location = New System.Drawing.Point(0, 0)
    Me.flowPanel.Name = "flowPanel"
    Me.flowPanel.Size = New System.Drawing.Size(1004, 419)
    Me.flowPanel.TabIndex = 0
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
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.Name = "Main"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Visitor Tracker"
    Me.TopMost = True
    Me.tabControl.ResumeLayout(False)
    Me.tabToday.ResumeLayout(False)
    Me.tabHistory.ResumeLayout(False)
    Me.tabVolunteer.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnAdd As System.Windows.Forms.Button
  Friend WithEvents tabControl As System.Windows.Forms.TabControl
  Friend WithEvents tabToday As System.Windows.Forms.TabPage
  Friend WithEvents tabHistory As System.Windows.Forms.TabPage
  Friend WithEvents webBrowser As System.Windows.Forms.WebBrowser
  Friend WithEvents toolTip As System.Windows.Forms.ToolTip
  Friend WithEvents tabVolunteer As System.Windows.Forms.TabPage
  Friend WithEvents flowPanel As System.Windows.Forms.FlowLayoutPanel

End Class
