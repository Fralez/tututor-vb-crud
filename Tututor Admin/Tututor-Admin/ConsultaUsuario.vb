Imports Newtonsoft.Json

Public Class ConsultaUsuario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim http As Http = New Http()
        Http.HttpPostCreateUser(InputEmailAltaUser.Text, InputPasswordAltaUser.Text, InputIdentifyNumberUser.Text, InputNameAltaUser.Text, GenderSelectedAltaUser.SelectedIndex, MonthCalendarBirthDateAltaUser.SelectionRange.Start.ToShortDateString())
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim http As Http = New Http()
        Dim response As String = Http.HttpShowUserByIdentityNumber(InputIdentifyNumberUser.Text)
        Dim obj = JsonConvert.DeserializeObject(Of Container)(response)

        InputEmailAltaUser.Text = obj.User.email
        InputNameAltaUser.Text = obj.User.name
        InputPasswordAltaUser.Text = obj.User.password_digest

        If obj.User.gender = "male" Then
            GenderSelectedAltaUser.SelectedIndex = 1
        ElseIf obj.User.gender = "female" Then
            GenderSelectedAltaUser.SelectedIndex = 2
        Else
            GenderSelectedAltaUser.SelectedIndex = 0
        End If

        Dim birthDate As Date = Date.Parse(obj.User.birth_date)
        MonthCalendarBirthDateAltaUser.SetSelectionRange(birthDate, birthDate)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        GenderSelectedAltaUser.ClearSelected()
        InputPasswordAltaUser.Clear()
        InputNameAltaUser.Clear()
        InputEmailAltaUser.Clear()
        InputIdentifyNumberUser.Clear()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim http As Http = New Http()
        Http.HttpPutUpdateUser(InputEmailAltaUser.Text, InputPasswordAltaUser.Text, InputIdentifyNumberUser.Text, InputNameAltaUser.Text, GenderSelectedAltaUser.SelectedIndex, MonthCalendarBirthDateAltaUser.SelectionRange.Start.ToShortDateString())
    End Sub
End Class

Public Class Container
    Public User As USER_JSON_result
End Class

Public Class USER_JSON_result
    Public identity_number As String
    Public email As String
    Public name As String
    Public birth_date As String
    Public gender As String
    Public password_digest As String
End Class