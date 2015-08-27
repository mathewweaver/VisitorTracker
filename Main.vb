Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms

Imports Newtonsoft
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Main

  Protected Log As log4net.ILog = log4net.LogManager.GetLogger(GetType(Main))

  Protected Connection As SqlConnection

  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()

    ' initialize logging
    log4net.Config.XmlConfigurator.Configure()

    ' create database connection
    Me.Connection = New SqlConnection(Configuration.ConfigurationManager.ConnectionStrings("VisitorTracker").ConnectionString)

    Me.txtNumToday.Text = Me.COUNT_dt_visitor()

    Me.cbVol.DataSource = SELECT_dt_volunteer()
    Me.cbVol.ValueMember = "Id"
    Me.cbVol.DisplayMember = "Name"

  End Sub

  Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
    Try
      Cursor.Current = Cursors.WaitCursor
      Me.btnAdd.Enabled = False

      Dim cnt As Integer = Me.INSERT_dt_visitor()

      Me.txtNumToday.Text = cnt

    Catch ex As Exception
      HandleException(ex)
    Finally
      Cursor.Current = Cursors.Default
      Me.btnAdd.Enabled = True
    End Try
  End Sub

  Private Sub HandleException(ex As Exception)
    Log.Error(ex.Message, ex)
    MessageBox.Show(ex.Message)
  End Sub


#Region "Database"

  Private Function INSERT_dt_visitor() As Integer
    Dim cnt As Integer = -1

    Try

      Me.Connection.Open()

      Dim db As SqlCommand = Me.Connection.CreateCommand()
      db.CommandType = CommandType.Text
      db.CommandText = "insert dbo.dt_visitor ( dt ) values ( @dt ); select count(*) from dbo.dt_visitor where dt > dateadd(dd, 0, datediff(dd, 0,getdate())); "
      db.Parameters.Add(New SqlParameter("@dt", DateTime.Now))

      cnt = Convert.ToInt32(db.ExecuteScalar())

    Catch ex As Exception
      HandleException(ex)
    Finally
      Me.Connection.Close()
    End Try

    Return cnt
  End Function

  Private Function COUNT_dt_visitor() As Integer
    Dim cnt As Integer = -1

    Try

      Me.Connection.Open()

      Dim db As SqlCommand = Me.Connection.CreateCommand()
      db.CommandType = CommandType.Text
      db.CommandText = "select count(*) from dbo.dt_visitor where dt > dateadd(dd, 0, datediff(dd, 0,getdate())); "
      db.Parameters.Add(New SqlParameter("@dt", DateTime.Now))

      cnt = Convert.ToInt32(db.ExecuteScalar())

    Catch ex As Exception
      HandleException(ex)
    Finally
      Me.Connection.Close()
    End Try

    Return cnt
  End Function

  Private Function SELECT_dt_visitor() As JArray
    Dim values As New JArray()

    Try

      Me.Connection.Open()

      Dim db As SqlCommand = Me.Connection.CreateCommand()
      db.CommandType = CommandType.Text
      db.CommandText = "select start_dt, cnt from dbo.fn_visitor(null) order by start_dt asc "

      Dim reader As SqlDataReader = db.ExecuteReader()
      While reader.Read

        Dim dt As DateTime = Convert.ToDateTime(reader.GetValue(0))
        Dim cnt As Integer = Convert.ToInt32(reader.GetValue(1))

        Dim pair As New JArray
        pair.Add(New JValue(DateTimeHelper.ToJavascriptTimestamp(dt)))
        pair.Add(New JValue(cnt))

        values.Add(pair)

      End While
      reader.Close()

    Catch ex As Exception
      HandleException(ex)
    Finally
      Me.Connection.Close()
    End Try

    Return values
  End Function

  Private Function SELECT_dt_volunteer() As List(Of Volunteer)
    Dim values As New List(Of Volunteer)

    Try

      Me.Connection.Open()

      Dim db As SqlCommand = Me.Connection.CreateCommand()
      db.CommandType = CommandType.Text
      db.CommandText = "select vo_id, volunteer_name, email_address, remark from dbo.dt_volunteer where is_active = 1 order by volunteer_name asc "

      Dim reader As SqlDataReader = db.ExecuteReader()
      While reader.Read

        Dim vol As New Volunteer
        vol.Id = Convert.ToInt32(reader.GetValue(0))
        If Not reader.IsDBNull(1) Then vol.Name = Convert.ToString(reader.GetValue(1))
        If Not reader.IsDBNull(2) Then vol.EmailAddress = Convert.ToString(reader.GetValue(2))
        If Not reader.IsDBNull(3) Then vol.Remark = Convert.ToString(reader.GetValue(3))
        values.Add(vol)

      End While
      reader.Close()

    Catch ex As Exception
      HandleException(ex)
    Finally
      Me.Connection.Close()
    End Try

    Return values
  End Function

  Private Function INSERT_dt_volunteer_time(v As Volunteer) As Integer
    Dim id As Integer = -1

    Try

      Me.Connection.Open()

      v.StartTime = DateTime.Now

      Dim db As SqlCommand = Me.Connection.CreateCommand()
      db.CommandType = CommandType.Text
      db.CommandText = "insert dbo.dt_volunteer_time ( vo_id, start_dt, stop_dt ) values (@id, @dt, dateadd(minute,5,@dt) ); select scope_identity(); "
      db.Parameters.Add(New SqlParameter("@id", v.Id))
      db.Parameters.Add(New SqlParameter("@dt", v.StartTime))

      id = Convert.ToInt32(db.ExecuteScalar())

    Catch ex As Exception
      HandleException(ex)
    Finally
      Me.Connection.Close()
    End Try

    Return id
  End Function

  Private Sub UPDATE_dt_volunteer_time(v As Volunteer)
    Dim id As Integer = -1

    Try

      Me.Connection.Open()

      Dim db As SqlCommand = Me.Connection.CreateCommand()
      db.CommandType = CommandType.Text
      db.CommandText = "update dbo.dt_volunteer_time set stop_dt = @dt where vt_id = @id "
      db.Parameters.Add(New SqlParameter("@id", v.TimeId))
      db.Parameters.Add(New SqlParameter("@dt", DateTime.Now))
      db.ExecuteNonQuery()

      v.StartTime = DateTime.MinValue
      v.TimeId = Integer.MinValue

    Catch ex As Exception
      HandleException(ex)
    Finally
      Me.Connection.Close()
    End Try

  End Sub

  Private Function SELECT_dt_volunteer_time(v As Volunteer) As JArray
    Dim values As New JArray()

    Try

      Me.Connection.Open()

      Dim db As SqlCommand = Me.Connection.CreateCommand()
      db.CommandType = CommandType.Text
      db.CommandText = "select start_dt, hrs from dbo.fn_volunteer(@id,null) order by start_dt asc "
      db.Parameters.Add(New SqlParameter("@id", v.Id))

      Dim reader As SqlDataReader = db.ExecuteReader()
      While reader.Read

        Dim dt As DateTime = Convert.ToDateTime(reader.GetValue(0))
        Dim cnt As Single = Math.Round(Convert.ToSingle(reader.GetValue(1)), 1)

        Dim pair As New JArray
        pair.Add(New JValue(DateTimeHelper.ToJavascriptTimestamp(dt)))
        pair.Add(New JValue(cnt))

        values.Add(pair)

      End While
      reader.Close()

    Catch ex As Exception
      HandleException(ex)
    Finally
      Me.Connection.Close()
    End Try

    Return values
  End Function

#End Region


  Private Sub cbVol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVol.SelectedIndexChanged
    Me.btnStart.Enabled = Not Me.cbVol.SelectedItem Is Nothing
    Me.btnVolunteerHistory.Enabled = Not Me.cbVol.SelectedItem Is Nothing
  End Sub

  Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
    Try
      Dim vol As Volunteer = CType(Me.cbVol.SelectedItem, Volunteer)

      vol.TimeId = INSERT_dt_volunteer_time(vol)

      Dim vb As New VolunteerButton(vol)
      AddHandler vb.StopVolunteer, AddressOf Me.Stop_Volunteer
      Me.flowPanel.Controls.Add(vb)

    Catch ex As Exception
      HandleException(ex)
    End Try
  End Sub

  Private Sub Stop_Volunteer(sender As Object, e As EventArgs)
    Try

      Dim vol As Volunteer = CType(e, VolunteerButtonEventArgs).Volunteer

      Me.UPDATE_dt_volunteer_time(vol)

      Me.flowPanel.Controls.Remove(sender)

    Catch ex As Exception
      HandleException(ex)
    Finally
      Me.Connection.Close()
    End Try

  End Sub

  Private Sub btnVolunteerHistory_Click(sender As Object, e As EventArgs) Handles btnVolunteerHistory.Click
    Try
      Cursor.Current = Cursors.WaitCursor

      Dim vol As Volunteer = CType(Me.cbVol.SelectedItem, Volunteer)

      ' show Volunteer history
      Dim json As String = SELECT_dt_volunteer_time(vol).ToString()
      Dim fi = System.IO.File.OpenText(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.CodeBase.Substring(8)) & "\VolunteerHistory.htm")
      Dim htm As String = fi.ReadToEnd()
      fi.Close()
      htm = htm.Replace("%data%", json).Replace("%volunteer%", vol.Name)
      Dim tmp As String = Path.ChangeExtension(Path.GetTempFileName, ".htm")
      File.WriteAllText(tmp, htm)
      System.Diagnostics.Process.Start(tmp)

    Catch ex As Exception
      HandleException(ex)
    Finally
      Cursor.Current = Cursors.Default
    End Try
  End Sub

  Private Sub btnVisitorHistory_Click(sender As Object, e As EventArgs) Handles btnVisitorHistory.Click
    Try
      Cursor.Current = Cursors.WaitCursor

      ' show Visitor history
      Dim json As String = SELECT_dt_visitor().ToString()
      Dim fi = System.IO.File.OpenText(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.CodeBase.Substring(8)) & "\VisitorHistory.htm")
      Dim htm As String = fi.ReadToEnd()
      fi.Close()
      htm = htm.Replace("%data%", json)
      Dim tmp As String = Path.ChangeExtension(Path.GetTempFileName, ".htm")
      File.WriteAllText(tmp, htm)
      System.Diagnostics.Process.Start(tmp)

    Catch ex As Exception
      HandleException(ex)
    Finally
      Cursor.Current = Cursors.Default
    End Try
  End Sub
End Class
