Imports System.Data.SqlClient

Partial Public Class GenMain
    Inherits System.Web.UI.Page
    Private cnStr As String = ConfigurationManager.ConnectionStrings("cnCareergform1").ConnectionString
    Private cn As SqlConnection = New SqlConnection(cnStr)
    Protected Sub goRegister(ByVal sender As Object, ByVal e As EventArgs) Handles btnAccept.Click
        Dim T_Key As String
        Dim T2_Key As String
        Dim T3_Key As String
        Dim T4_Key As String
        T_Key = Request.QueryString("Key")
        T2_Key = Request.QueryString("Position")
        T3_Key = Request.QueryString("RefCode")
        T4_Key = Request.QueryString("ID")

        'If T_Key Is Nothing Then
        '    Response.Redirect("Apply.aspx")
        'Else
        '    Response.Redirect("Apply.aspx?Key=" & Replace(T_Key, " ", "+") & "&Position=" & Replace(T2_Key, " ", "+") & "&RefCode=" & Replace(T3_Key, " ", "+"))
        'End If
        Session.Remove("P1AREF")

        If T2_Key <> "" And T3_Key <> "" Then
            Try
                Dim cm As SqlCommand
                Dim dr As SqlDataReader

                cn.Open()
                cm = New SqlCommand()
                cm.Connection = cn

                cm.CommandText = "sp_checkActive"
                cm.CommandType = CommandType.StoredProcedure
                cm.Parameters.Add("@Key", SqlDbType.NVarChar).Value = T_Key
                cm.Parameters.Add("@ID", SqlDbType.Int).Value = T4_Key

                dr = cm.ExecuteReader
                If dr.Read() Then
                    Session("P1AREF") = T3_Key
                    Response.Redirect("GenApply.aspx?Key=" & Replace(T_Key, " ", "+") & "&Position=" & Replace(T2_Key, " ", "+") & "&RefCode=" & Replace(T3_Key, " ", "+") & "&ID=" & Replace(T4_Key, " ", "+"))
                Else
                    MessageBox("The website was expired! 網頁已過期！")
                End If
                'If dr("rStatus") = "S" Then


                'End If
                'Else
                '    MessageBox("資料不正確 Your input data is not valid")
                'End If

                'dr.Close()
                'cm = Nothing

            Catch ex As Exception
            Finally
                cn.Close()
            End Try
        End If
    End Sub
    Private Sub MessageBox(ByVal strMsg As String)
        Dim lbl As New Label
        lbl.Text = "<script language='javascript'>" & Environment.NewLine _
                   & "window.alert(" & "'" & strMsg & "'" & ")</script>"
        Page.Controls.Add(lbl)
    End Sub
End Class