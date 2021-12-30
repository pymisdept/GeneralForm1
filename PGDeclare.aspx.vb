

Partial Public Class PGDeclare
    Inherits System.Web.UI.Page

    Protected Sub goRegister(ByVal sender As Object, ByVal e As EventArgs) Handles btnAccept.Click
        Response.Write("<script language='javascript'> { window.close(); }</script>")
    End Sub


End Class