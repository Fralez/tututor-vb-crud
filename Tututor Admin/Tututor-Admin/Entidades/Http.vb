﻿Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json

Public Class Http
    Const baseUrl As String = "http://localhost:3000"

    Public Shared Function HttpGet(url As String) As String
        Try
            Dim Request As HttpWebRequest = HttpWebRequest.Create(url)
            Request.Proxy = Nothing

            Dim response As HttpWebResponse = Request.GetResponse()
            Dim responseStream As System.IO.Stream = response.GetResponseStream()

            Dim streamReader As New System.IO.StreamReader(responseStream)
            Dim data As String = streamReader.ReadToEnd()

            streamReader.Close()

            Return data
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function HttpPostCreateUser(email As String, password As String, identityNumber As Integer, name As String, gender As Integer, birthDate As DateTime)
        Dim Request As HttpWebRequest = HttpWebRequest.Create(baseUrl + "/users")

        Dim body As String = "{""user"": {""email"":" + email + ",""password"":" + password + ",""identity_number"":" + identityNumber + ",""name"":" + name + ",""gender"":" + gender + ",""birth_date"":" + birthDate.ToString() + "}}"

        Request.Method = "POST"
        Request.ContentType = "application/json"
        Dim postBytes = Encoding.UTF8.GetBytes(body)
        Request.ContentLength = postBytes.Length

        Dim httpPostStream As IO.Stream = Request.GetRequestStream()
        httpPostStream.Write(postBytes, 0, postBytes.Length)
        httpPostStream.Close()
        httpPostStream = Nothing

        Dim response As HttpWebResponse
        response = DirectCast(Request.GetResponse(), HttpWebResponse)

        Dim responseReader As New StreamReader(response.GetResponseStream())

        Dim finalResponse As String = responseReader.ReadToEnd()
        Return finalResponse
    End Function

End Class