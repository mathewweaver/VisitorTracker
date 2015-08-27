Public Class VolunteerButton

  Private _Volunteer As Volunteer

  Event StopVolunteer(sender As Object, e As VolunteerButtonEventArgs )

  Public Sub New(vol As Volunteer)
    InitializeComponent()

    Me._Volunteer = vol

    Me.lblName.Text = Me._Volunteer.Name
    Me.toolTip.SetToolTip(Me.lblName, String.Format("Click to stop logging hours for {0}", Me.lblName.Text))

    Me.lblStart.Text = Me._Volunteer.StartTime.ToShortTimeString()
    Me.toolTip.SetToolTip(Me.lblStart, String.Format("Time that {0} started today", Me.lblName.Text))

    Me.lblHrs.Text = "0.0 hrs"

    Me.vTimer.Enabled = True
  End Sub

  Private Sub lblName_Click(sender As Object, e As EventArgs) Handles lblName.Click
    Me.vTimer.Enabled = False
    Dim ev As New VolunteerButtonEventArgs(Me._Volunteer)
    RaiseEvent StopVolunteer(Me, ev)
  End Sub

  Private Sub vTimer_Tick(sender As Object, e As EventArgs) Handles vTimer.Tick
    Dim span As TimeSpan = DateTime.Now.Subtract(Me._Volunteer.StartTime)
    Me.lblHrs.Text = String.Format("{0:#0.0} hrs", span.TotalHours)
    Me.toolTip.SetToolTip(Me.lblHrs, String.Format("{0:#0.0} minutes", span.TotalMinutes))
  End Sub
End Class

Public Class VolunteerButtonEventArgs
  Inherits EventArgs
  Public Sub New(v As Volunteer)
    Me.Volunteer = v
  End Sub
  Public Volunteer As Volunteer
End Class