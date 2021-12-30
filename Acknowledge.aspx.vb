Partial Public Class Acknowledge
    Inherits System.Web.UI.Page
    Private curRefNum As String

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        curRefNum = Session("REFNO")
        refNo.Text = curRefNum
        refNo2.Text = curRefNum
    End Sub
    'Protected Sub goRegister(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
    '    Response.Write("<script language='javascript'> { window.close(); }</script>")
    'End Sub

End Class