
Public Class Volunteer

  Private _Id As Integer
  Public Property Id() As Integer
    Get
      Return Me._Id
    End Get
    Set(value As Integer)
      Me._Id = value
    End Set
  End Property

  Private _Name As String
  Public Property Name() As String
    Get
      Return Me._Name
    End Get
    Set(value As String)
      Me._Name = value
    End Set
  End Property

  Private _EmailAddress As String
  Public Property EmailAddress() As String
    Get
      Return Me._EmailAddress
    End Get
    Set(value As String)
      Me._EmailAddress = value
    End Set
  End Property

  Private _Remark As String
  Public Property Remark() As String
    Get
      Return Me._Remark
    End Get
    Set(value As String)
      Me._Remark = value
    End Set
  End Property

  Private _StartTime As DateTime
  Public Property StartTime() As DateTime
    Get
      Return Me._StartTime
    End Get
    Set(value As DateTime)
      Me._StartTime = value
    End Set
  End Property

  Private _TimeId As Integer
  Public Property TimeId() As Integer
    Get
      Return Me._TimeId
    End Get
    Set(value As Integer)
      Me._TimeId = value
    End Set
  End Property

End Class
