Public Class AltaUsuario

    Private Sub AltaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub InputPasswordAltaUser_TextChanged(sender As Object, e As EventArgs) Handles InputPasswordAltaUser.TextChanged
        InputPasswordAltaUser.PasswordChar = "*"
        InputPasswordAltaUser.MaxLength = 14
    End Sub
End Class