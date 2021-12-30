Public Class LanguageData

    Private vLang As String = ""
    Private vSpeaking_V As String = ""
    Private vReading_V As String = ""
    Private vWriting_V As String = ""

    Private vSpeaking_T As String = ""
    Private vReading_T As String = ""
    Private vWriting_T As String = ""

    Public Property Lang() As String
        Get
            Return vLang
        End Get
        Set(ByVal v As String)
            vLang = v
        End Set
    End Property

    Public Property Speaking_V() As String
        Get
            Return vSpeaking_V
        End Get
        Set(ByVal v As String)
            vSpeaking_V = v
        End Set
    End Property

    Public Property Reading_V() As String
        Get
            Return vReading_V
        End Get
        Set(ByVal v As String)
            vReading_V = v
        End Set
    End Property

    Public Property Writing_V() As String
        Get
            Return vWriting_V
        End Get
        Set(ByVal v As String)
            vWriting_V = v
        End Set
    End Property

    Public Property Speaking_T() As String
        Get
            Return vSpeaking_T
        End Get
        Set(ByVal v As String)
            vSpeaking_T = v
        End Set
    End Property

    Public Property Reading_T() As String
        Get
            Return vReading_T
        End Get
        Set(ByVal v As String)
            vReading_T = v
        End Set
    End Property

    Public Property Writing_T() As String
        Get
            Return vWriting_T
        End Get
        Set(ByVal v As String)
            vWriting_T = v
        End Set
    End Property

End Class
