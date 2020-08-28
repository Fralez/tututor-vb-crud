Public Class AltaUsuario

    Private Sub AltaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub InputPasswordAltaUser_TextChanged(sender As Object, e As EventArgs) Handles InputPasswordAltaUser.TextChanged
        InputPasswordAltaUser.PasswordChar = "*"
        InputPasswordAltaUser.MaxLength = 20
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim http As Http = New Http()
        Http.HttpPostCreateUser(InputEmailAltaUser.Text, InputPasswordAltaUser.Text, InputIdentifyNumberUser.Text, InputNameAltaUser.Text, GenderSelectedAltaUser.SelectedIndex, MonthCalendarBirthDateAltaUser.SelectionRange.Start.ToShortDateString())
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class