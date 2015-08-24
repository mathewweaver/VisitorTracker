Imports System
Imports System.Data
Imports System.Data.SqlClient

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
      Me.webBrowser.DocumentText = My.Resources.ChartTest

      Me.Connection.Open()
      Me.Connection.Close()

    Catch ex As Exception
      HandleException(ex)
    End Try
  End Sub

  Private Sub HandleException(ex As Exception)
    Log.Error(ex.Message, ex)
    MessageBox.Show(ex.Message)
  End Sub
End Class
