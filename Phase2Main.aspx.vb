Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Security

Partial Public Class Phase2Main
    Inherits System.Web.UI.Page

    Private cnStr As String = ConfigurationManager.ConnectionStrings("cnCareer").ConnectionString
    Private cn As SqlConnection = New SqlConnection(cnStr)

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Session.Remove("P1AREF")
            Session.Remove("P1APOS")
        End If
    End Sub

    Protected Sub SubmitForm()
        Session.Remove("P1AREF")
        'Session.Remove("P1APOS")
        'Dim position As String
        Dim refcode As String
        'position = Request.QueryString("Position")
        refcode = Request.QueryString("RefCode")

        If refcode <> "" Then
            Try
                Dim cm As SqlCommand
                Dim dr As SqlDataReader

                cn.Open()
                cm = New SqlCommand()
                cm.Connection = cn

                cm.CommandText = "sp_NewLogin "
                cm.CommandType = CommandType.StoredProcedure
                cm.Parameters.Add("@RefNum", SqlDbType.NVarChar).Value = refcode
                'cm.Parameters.Add("@Pwd", SqlDbType.NVarChar).Value = txtPwd.Text

                dr = cm.ExecuteReader
                If dr.Read() Then
                    If dr("rStatus") = "S" Then
                        'Session("P1APOS") = position
                        Session("P1AREF") = refcode
                        Response.Redirect("Apply2.aspx")
                    ElseIf dr("rStatus") = "L" Then
                        MessageBox("此帳號暫時鎖定，請稍後再試\nYour account is currently locked, please try again later.")
                    ElseIf dr("rStatus") = "P2" Then
                        MessageBox("我們已經收到你的申請 We have received your application.")
                    ElseIf dr("rStatus") = "F" Then
                        MessageBox("資料不正確 Your input data is not valid")
                    ElseIf dr("rStatus") = "F1" Then
                        MessageBox("資料不正確，請在五分鐘後再試\nYour input data is not valid, please try again in 5 minutes ")
                    ElseIf dr("rStatus") = "F2" Then
                        MessageBox("資料不正確，請在十五分鐘後再試\nYour input data is not valid, please try again in 15 minutes ")
                    ElseIf dr("rStatus") = "F3" Then
                        MessageBox("資料不正確，請稍後再試 / 與我們聯絡\nYour input data is not valid, please try again later / contact us ")
                    End If
                Else
                    MessageBox("資料不正確 Your input data is not valid")
                End If

                dr.Close()
                cm = Nothing

            Catch ex As Exception
                'Console.Write(ex.Message)
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