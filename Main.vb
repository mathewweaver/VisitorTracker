Imports System
Imports System.Data
Imports System.Data.SqlClient
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

  End Sub

  Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
    Try
      Cursor.Current = Cursors.WaitCursor
      Me.btnAdd.Enabled = False

      Me.INSERT_dt_visitor()

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

  Private Sub tabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabControl.SelectedIndexChanged
    Try
      Cursor.Current = Cursors.WaitCursor
      Me.tabControl.Enabled = False

      Select Case Me.tabControl.SelectedTab.Name

        Case "tabHistory"
          ' show Visitor history
          Dim json = SELECT_dt_visitor().ToString()
          Dim htm As String = My.Resources.ChartTest
          Me.webBrowser.DocumentText = htm.Replace("%data%", json)

      End Select
    Catch ex As Exception
      HandleException(ex)
    Finally
      Cursor.Current = Cursors.Default
      Me.tabControl.Enabled = True
    End Try
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

#End Region





End Class
