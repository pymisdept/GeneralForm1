Imports System.Web
Imports System.Web.Services
Imports System.IO
Imports System.Security.Cryptography

Public Class FileUploadHandler
    Implements System.Web.IHttpHandler

    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest

        Try

            If context.Request.QueryString("upload") IsNot Nothing Then
                Dim pathrefer As String = context.Request.UrlReferrer.ToString()
                Dim Serverpath As String = ConfigurationManager.AppSettings("TempUploadToPathgform1")
                Dim postedFile = context.Request.Files(0)
                Dim myfile As String

                If HttpContext.Current.Request.Browser.Browser.ToUpper() = "IE" Then
                    Dim files As String() = postedFile.FileName.Split(New Char() {"\"c})
                    myfile = files(files.Length - 1)
                Else
                    myfile = postedFile.FileName
                End If

                Dim fileDirectory As String = Serverpath

                If context.Request.QueryString("fileName") IsNot Nothing Then
                    myfile = context.Request.QueryString("fileName")

                    If File.Exists(fileDirectory & "\" + myfile) Then
                        File.Delete(fileDirectory & "\" + myfile)
                    End If
                End If

                Dim ext As String = Path.GetExtension(fileDirectory & "\" & myfile)
                myfile = Guid.NewGuid().ToString().Replace("-", "") & ext
                fileDirectory = Serverpath & "\" & myfile
                postedFile.SaveAs(fileDirectory)
                context.Response.AddHeader("Vary", "Accept")

                context.Response.ContentType = "text/plain"


                '  myfile & "|" & postedFile.FileName & "|" & FormatFileSize(postedFile.ContentLength)

                Dim rsv As String
                rsv = "{ ""fi"": """ & myfile & """, ""fn"": """ & postedFile.FileName & """, ""fl"": """ & FormatFileSize(postedFile.ContentLength) & """ }"

                context.Response.Write(rsv)
            End If

        Catch exp As Exception
            context.Response.Write(exp.Message)
        End Try

    End Sub

    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

    Private Function FormatFileSize(ByVal size As Integer) As String
        Dim kb As Decimal = size / 1024
        Dim mb As Decimal = kb / 1024

        If mb > 0.9 Then
            Return Math.Round(mb, 1) & "MB"
        Else
            Return Math.Round(kb, 1) & "KB"
        End If

    End Function

End Class