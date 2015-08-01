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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
    Me.btnAdd = New System.Windows.Forms.Button()
    Me.webBrowser = New System.Windows.Forms.WebBrowser()
    Me.SuspendLayout()
    '
    'btnAdd
    '
    Me.btnAdd.BackColor = System.Drawing.Color.RoyalBlue
    Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
    Me.btnAdd.ForeColor = System.Drawing.Color.White
    Me.btnAdd.Location = New System.Drawing.Point(12, 12)
    Me.btnAdd.Name = "btnAdd"
    Me.btnAdd.Size = New System.Drawing.Size(214, 160)
    Me.btnAdd.TabIndex = 0
    Me.btnAdd.Text = "ADD VISITOR"
    Me.btnAdd.UseVisualStyleBackColor = False
    '
    'webBrowser
    '
    Me.webBrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.webBrowser.Location = New System.Drawing.Point(232, 0)
    Me.webBrowser.MinimumSize = New System.Drawing.Size(20, 20)
    Me.webBrowser.Name = "webBrowser"
    Me.webBrowser.Size = New System.Drawing.Size(778, 454)
    Me.webBrowser.TabIndex = 1
    '
    'Main
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.ClientSize = New System.Drawing.Size(1012, 457)
    Me.Controls.Add(Me.webBrowser)
    Me.Controls.Add(Me.btnAdd)
    Me.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ForeColor = System.Drawing.Color.Gray
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
    Me.Name = "Main"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Visitor Tracker"
    Me.TopMost = True
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnAdd As System.Windows.Forms.Button
  Friend WithEvents webBrowser As System.Windows.Forms.WebBrowser

End Class
