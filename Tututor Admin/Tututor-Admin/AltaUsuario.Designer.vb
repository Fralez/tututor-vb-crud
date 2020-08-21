<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AltaU = New System.Windows.Forms.Label()
        Me.EmailU = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.InputNameAltaUser = New System.Windows.Forms.TextBox()
        Me.InputEmailAltaUser = New System.Windows.Forms.TextBox()
        Me.InputPasswordAltaUser = New System.Windows.Forms.TextBox()
        Me.MonthCalendarBirthDateAltaUser = New System.Windows.Forms.MonthCalendar()
        Me.GenderSelectedAltaUser = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'AltaU
        '
        Me.AltaU.AutoSize = True
        Me.AltaU.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AltaU.Location = New System.Drawing.Point(29, 9)
        Me.AltaU.Name = "AltaU"
        Me.AltaU.Size = New System.Drawing.Size(149, 40)
        Me.AltaU.TabIndex = 0
        Me.AltaU.Text = "Alta User"
        '
        'EmailU
        '
        Me.EmailU.AutoSize = True
        Me.EmailU.Location = New System.Drawing.Point(12, 146)
        Me.EmailU.Name = "EmailU"
        Me.EmailU.Size = New System.Drawing.Size(35, 13)
        Me.EmailU.TabIndex = 1
        Me.EmailU.Text = "Email:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(401, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(401, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Gender:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Birthday Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Name:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(219, 393)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(378, 27)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'InputNameAltaUser
        '
        Me.InputNameAltaUser.Location = New System.Drawing.Point(56, 81)
        Me.InputNameAltaUser.Name = "InputNameAltaUser"
        Me.InputNameAltaUser.Size = New System.Drawing.Size(285, 20)
        Me.InputNameAltaUser.TabIndex = 7
        '
        'InputEmailAltaUser
        '
        Me.InputEmailAltaUser.Location = New System.Drawing.Point(56, 143)
        Me.InputEmailAltaUser.Name = "InputEmailAltaUser"
        Me.InputEmailAltaUser.Size = New System.Drawing.Size(285, 20)
        Me.InputEmailAltaUser.TabIndex = 8
        '
        'InputPasswordAltaUser
        '
        Me.InputPasswordAltaUser.Location = New System.Drawing.Point(463, 143)
        Me.InputPasswordAltaUser.Name = "InputPasswordAltaUser"
        Me.InputPasswordAltaUser.Size = New System.Drawing.Size(287, 20)
        Me.InputPasswordAltaUser.TabIndex = 9
        '
        'MonthCalendarBirthDateAltaUser
        '
        Me.MonthCalendarBirthDateAltaUser.Location = New System.Drawing.Point(93, 196)
        Me.MonthCalendarBirthDateAltaUser.Name = "MonthCalendarBirthDateAltaUser"
        Me.MonthCalendarBirthDateAltaUser.TabIndex = 10
        '
        'GenderSelectedAltaUser
        '
        Me.GenderSelectedAltaUser.FormattingEnabled = True
        Me.GenderSelectedAltaUser.Items.AddRange(New Object() {"Female", "Male", "Other"})
        Me.GenderSelectedAltaUser.Location = New System.Drawing.Point(463, 81)
        Me.GenderSelectedAltaUser.Name = "GenderSelectedAltaUser"
        Me.GenderSelectedAltaUser.Size = New System.Drawing.Size(150, 43)
        Me.GenderSelectedAltaUser.TabIndex = 11
        '
        'AltaUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GenderSelectedAltaUser)
        Me.Controls.Add(Me.MonthCalendarBirthDateAltaUser)
        Me.Controls.Add(Me.InputPasswordAltaUser)
        Me.Controls.Add(Me.InputEmailAltaUser)
        Me.Controls.Add(Me.InputNameAltaUser)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EmailU)
        Me.Controls.Add(Me.AltaU)
        Me.Name = "AltaUsuario"
        Me.Text = "AltaUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AltaU As Label
    Friend WithEvents EmailU As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents InputNameAltaUser As TextBox
    Friend WithEvents InputEmailAltaUser As TextBox
    Friend WithEvents InputPasswordAltaUser As TextBox
    Friend WithEvents MonthCalendarBirthDateAltaUser As MonthCalendar
    Friend WithEvents GenderSelectedAltaUser As ListBox
End Class
