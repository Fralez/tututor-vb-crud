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
End Class