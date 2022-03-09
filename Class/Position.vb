Public Class Position

    Private vPos As String = ""
    Private vComp As String = ""

    Public Sub New(ByVal vPos As String, ByVal vComp As String)
        Me.vPos = vPos
        Me.vComp = vComp
    End Sub

    Public Property Pos() As String
        Get
            Return vPos
        End Get
        Set(ByVal v As String)
            vPos = v
        End Set
    End Property

    Public Property Comp() As String
        Get
            Return vComp
        End Get
        Set(ByVal v As String)
            vComp = v
        End Set
    End Property

End Class
