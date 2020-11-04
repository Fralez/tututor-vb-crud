<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaUsuario
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
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.InputNameAltaUser = New System.Windows.Forms.TextBox()
        Me.InputEmailAltaUser = New System.Windows.Forms.TextBox()
        Me.InputPasswordAltaUser = New System.Windows.Forms.TextBox()
        Me.MonthCalendarBirthDateAltaUser = New System.Windows.Forms.MonthCalendar()
        Me.GenderSelectedAltaUser = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.InputIdentifyNumberUser = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AltaU
        '
        Me.AltaU.AutoSize = True
        Me.AltaU.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AltaU.Location = New System.Drawing.Point(12, 20)
        Me.AltaU.Name = "AltaU"
        Me.AltaU.Size = New System.Drawing.Size(278, 36)
        Me.AltaU.TabIndex = 0
        Me.AltaU.Text = "Administar Usuario"
        '
        'EmailU
        '
        Me.EmailU.AutoSize = True
        Me.EmailU.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailU.Location = New System.Drawing.Point(12, 146)
        Me.EmailU.Name = "EmailU"
        Me.EmailU.Size = New System.Drawing.Size(39, 16)
        Me.EmailU.TabIndex = 1
        Me.EmailU.Text = "Email:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(401, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(401, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Gender:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Birthday Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Name:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(404, 191)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(209, 27)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'InputNameAltaUser
        '
        Me.InputNameAltaUser.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputNameAltaUser.Location = New System.Drawing.Point(56, 107)
        Me.InputNameAltaUser.Name = "InputNameAltaUser"
        Me.InputNameAltaUser.Size = New System.Drawing.Size(285, 21)
        Me.InputNameAltaUser.TabIndex = 7
        '
        'InputEmailAltaUser
        '
        Me.InputEmailAltaUser.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputEmailAltaUser.Location = New System.Drawing.Point(56, 143)
        Me.InputEmailAltaUser.Name = "InputEmailAltaUser"
        Me.InputEmailAltaUser.Size = New System.Drawing.Size(285, 21)
        Me.InputEmailAltaUser.TabIndex = 8
        '
        'InputPasswordAltaUser
        '
        Me.InputPasswordAltaUser.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputPasswordAltaUser.Location = New System.Drawing.Point(463, 147)
        Me.InputPasswordAltaUser.Name = "InputPasswordAltaUser"
        Me.InputPasswordAltaUser.Size = New System.Drawing.Size(150, 21)
        Me.InputPasswordAltaUser.TabIndex = 9
        Me.InputPasswordAltaUser.Text = "**************"
        '
        'MonthCalendarBirthDateAltaUser
        '
        Me.MonthCalendarBirthDateAltaUser.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendarBirthDateAltaUser.Location = New System.Drawing.Point(93, 176)
        Me.MonthCalendarBirthDateAltaUser.Name = "MonthCalendarBirthDateAltaUser"
        Me.MonthCalendarBirthDateAltaUser.TabIndex = 10
        '
        'GenderSelectedAltaUser
        '
        Me.GenderSelectedAltaUser.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderSelectedAltaUser.FormattingEnabled = True
        Me.GenderSelectedAltaUser.ItemHeight = 16
        Me.GenderSelectedAltaUser.Items.AddRange(New Object() {"Others", "Male", "Female"})
        Me.GenderSelectedAltaUser.Location = New System.Drawing.Point(463, 81)
        Me.GenderSelectedAltaUser.Name = "GenderSelectedAltaUser"
        Me.GenderSelectedAltaUser.Size = New System.Drawing.Size(150, 52)
        Me.GenderSelectedAltaUser.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(567, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 12
        '
        'InputIdentifyNumberUser
        '
        Me.InputIdentifyNumberUser.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputIdentifyNumberUser.Location = New System.Drawing.Point(56, 78)
        Me.InputIdentifyNumberUser.Name = "InputIdentifyNumberUser"
        Me.InputIdentifyNumberUser.Size = New System.Drawing.Size(186, 21)
        Me.InputIdentifyNumberUser.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "CI:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(248, 78)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(95, 23)
        Me.btnBuscar.TabIndex = 15
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(404, 224)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(208, 29)
        Me.btnModificar.TabIndex = 16
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.Location = New System.Drawing.Point(404, 260)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnlimpiar.Size = New System.Drawing.Size(208, 31)
        Me.btnlimpiar.TabIndex = 17
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'AltaUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 350)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.InputIdentifyNumberUser)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GenderSelectedAltaUser)
        Me.Controls.Add(Me.MonthCalendarBirthDateAltaUser)
        Me.Controls.Add(Me.InputPasswordAltaUser)
        Me.Controls.Add(Me.InputEmailAltaUser)
        Me.Controls.Add(Me.InputNameAltaUser)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EmailU)
        Me.Controls.Add(Me.AltaU)
        Me.Name = "AltaUsuario"
        Me.Text = "Administar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AltaU As Label
    Friend WithEvents EmailU As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents InputNameAltaUser As TextBox
    Friend WithEvents InputEmailAltaUser As TextBox
    Friend WithEvents InputPasswordAltaUser As TextBox
    Friend WithEvents MonthCalendarBirthDateAltaUser As MonthCalendar
    Friend WithEvents GenderSelectedAltaUser As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents InputIdentifyNumberUser As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnlimpiar As Button
End Class
