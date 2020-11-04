Public Class ConsultaUsuario

    Private Sub AltaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InputEmailAltaUser.Enabled = False
        InputNameAltaUser.Enabled = False
        InputPasswordAltaUser.Enabled = False
        GenderSelectedAltaUser.Enabled = False
        MonthCalendarBirthDateAltaUser.Enabled = False
        btnGuardar.Enabled = False
        btnlimpiar.Enabled = False
        btnModificar.Enabled = False
    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub InputPasswordAltaUser_TextChanged(sender As Object, e As EventArgs) Handles InputPasswordAltaUser.TextChanged
        InputPasswordAltaUser.PasswordChar = "*"
        InputPasswordAltaUser.MaxLength = 20
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim http As Http = New Http()
        Http.HttpPostCreateUser(InputEmailAltaUser.Text, InputPasswordAltaUser.Text, InputIdentifyNumberUser.Text, InputNameAltaUser.Text, GenderSelectedAltaUser.SelectedIndex, MonthCalendarBirthDateAltaUser.SelectionRange.Start.ToShortDateString())
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        GenderSelectedAltaUser.ClearSelected()
        InputPasswordAltaUser.Clear()
        InputNameAltaUser.Clear()
        InputEmailAltaUser.Clear()
        InputIdentifyNumberUser.Clear()
    End Sub
End Class