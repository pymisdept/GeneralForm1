Imports System.Data.SqlClient

Partial Public Class Main
    Inherits System.Web.UI.Page
    Private cnStr As String = ConfigurationManager.ConnectionStrings("cnCareergform1").ConnectionString
    Private cn As SqlConnection = New SqlConnection(cnStr)
    Protected Sub goRegister(ByVal sender As Object, ByVal e As EventArgs) Handles btnAccept.Click
        Dim T_Key As String
        'Dim T2_Key As String
        'Dim T3_Key As String

        T_Key = Request.QueryString("Key")
        'T2_Key = Request.QueryString("Position")
        'T3_Key = Request.QueryString("RefCode")

        'If T_Key Is Nothing Then
        '    Response.Redirect("Apply.aspx")
        'Else
        '    Response.Redirect("Apply.aspx?Key=" & Replace(T_Key, " ", "+") & "&Position=" & Replace(T2_Key, " ", "+") & "&RefCode=" & Replace(T3_Key, " ", "+"))
        'End If
        Session.Remove("P1AREF")
        Session("P1AREF") = "accept"
        Response.Redirect("GraduateForm1.aspx")
        'If T2_Key <> "" Then
        '    Try
        '        'Dim cm As SqlCommand
        '        'Dim dr As SqlDataReader

        '        'cn.Open()
        '        'cm = New SqlCommand()
        '        'cm.Connection = cn

        '        'cm.CommandText = "sp_doLogin "
        '        'cm.CommandType = CommandType.StoredProcedure
        '        'cm.Parameters.Add("@RefNum", SqlDbType.NVarChar).Value = txtRef.Text
        '        'cm.Parameters.Add("@Pwd", SqlDbType.NVarChar).Value = txtPwd.Text

        '        'dr = cm.ExecuteReader
        '        'If dr.Read() Then
        '        'If dr("rStatus") = "S" Then
        '        '& "&Position=" & Replace(T2_Key, " ", "+") & "&RefCode=" & Replace(T3_Key, " ", "+")
        '        Session("P1AREF") = T3_Key
        '        Response.Redirect("GraduateForm1.aspx?Key=" & Replace(T_Key, " ", "+"))

        '        'End If
        '        'Else
        '        '    MessageBox("資料不正確 Your input data is not valid")
        '        'End If

        '        'dr.Close()
        '        'cm = Nothing

        '    Catch ex As Exception
        '    Finally
        '        cn.Close()
        '    End Try
        'End If
    End Sub
    Private Sub MessageBox(ByVal strMsg As String)
        Dim lbl As New Label
        lbl.Text = "<script language='javascript'>" & Environment.NewLine _
                   & "window.alert(" & "'" & strMsg & "'" & ")</script>"
        Page.Controls.Add(lbl)
    End Sub
End Class