Public Class SystemUser
    Public Property id() As String
        Get
            Return m_id
        End Get
        Set(value As String)
            m_id = Value
        End Set
    End Property
    Private m_id As String

    Public Property first_name() As String
        Get
            Return m_first_name
        End Get
        Set(value As String)
            m_first_name = Value
        End Set
    End Property
    Private m_first_name As String

    Public Property last_name() As String
        Get
            Return m_last_name
        End Get
        Set(value As String)
            m_last_name = value
        End Set
    End Property
    Private m_last_name As String

    Public Property link() As String
        Get
            Return m_link
        End Get
        Set(value As String)
            m_link = value
        End Set
    End Property
    Private m_link As String

    Public Property username() As String
        Get
            Return m_username
        End Get
        Set(value As String)
            m_username = value
        End Set
    End Property
    Private m_username As String

    Public Property gender() As String
        Get
            Return m_gender
        End Get
        Set(value As String)
            m_gender = value
        End Set
    End Property
    Private m_gender As String

    Public Property locale() As String
        Get
            Return m_locale
        End Get
        Set(value As String)
            m_locale = value
        End Set
    End Property
    Private m_locale As String
End Class
