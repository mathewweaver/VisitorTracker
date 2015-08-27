<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VolunteerButton
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
    Me.lblName = New System.Windows.Forms.Label()
    Me.lblStart = New System.Windows.Forms.Label()
    Me.lblHrs = New System.Windows.Forms.Label()
    Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
    Me.vTimer = New System.Windows.Forms.Timer(Me.components)
    Me.SuspendLayout()
    '
    'lblName
    '
    Me.lblName.ForeColor = System.Drawing.Color.White
    Me.lblName.Location = New System.Drawing.Point(-2, 0)
    Me.lblName.Name = "lblName"
    Me.lblName.Size = New System.Drawing.Size(312, 77)
    Me.lblName.TabIndex = 0
    Me.lblName.Text = "Name"
    Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'lblStart
    '
    Me.lblStart.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblStart.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblStart.ForeColor = System.Drawing.Color.White
    Me.lblStart.Location = New System.Drawing.Point(3, 41)
    Me.lblStart.Name = "lblStart"
    Me.lblStart.Size = New System.Drawing.Size(82, 28)
    Me.lblStart.TabIndex = 1
    Me.lblStart.Text = "Start"
    Me.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblHrs
    '
    Me.lblHrs.Cursor = System.Windows.Forms.Cursors.Default
    Me.lblHrs.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblHrs.ForeColor = System.Drawing.Color.White
    Me.lblHrs.Location = New System.Drawing.Point(219, 41)
    Me.lblHrs.Name = "lblHrs"
    Me.lblHrs.Size = New System.Drawing.Size(82, 28)
    Me.lblHrs.TabIndex = 2
    Me.lblHrs.Text = "Hours"
    Me.lblHrs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'vTimer
    '
    Me.vTimer.Interval = 5000
    '
    'VolunteerButton
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
    Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.Controls.Add(Me.lblHrs)
    Me.Controls.Add(Me.lblStart)
    Me.Controls.Add(Me.lblName)
    Me.Cursor = System.Windows.Forms.Cursors.Hand
    Me.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(6)
    Me.Name = "VolunteerButton"
    Me.Size = New System.Drawing.Size(308, 77)
    Me.toolTip.SetToolTip(Me, "Click to stop logging hours for this volunteer")
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents lblName As System.Windows.Forms.Label
  Friend WithEvents lblStart As System.Windows.Forms.Label
  Friend WithEvents lblHrs As System.Windows.Forms.Label
  Friend WithEvents toolTip As System.Windows.Forms.ToolTip
  Friend WithEvents vTimer As System.Windows.Forms.Timer

End Class
