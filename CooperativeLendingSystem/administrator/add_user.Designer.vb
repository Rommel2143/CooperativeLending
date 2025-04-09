<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_user
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_user))
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_initials = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_repass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_submit = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_account = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DimGray
        Me.Label17.Location = New System.Drawing.Point(48, 28)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 30)
        Me.Label17.TabIndex = 97
        Me.Label17.Text = "Add user"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(78, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Username"
        '
        'txt_username
        '
        Me.txt_username.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.txt_username.BorderRadius = 3
        Me.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_username.DefaultText = ""
        Me.txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_username.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_username.Location = New System.Drawing.Point(81, 193)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.PlaceholderText = ""
        Me.txt_username.SelectedText = ""
        Me.txt_username.Size = New System.Drawing.Size(265, 36)
        Me.txt_username.TabIndex = 98
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(78, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Initials"
        '
        'txt_initials
        '
        Me.txt_initials.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.txt_initials.BorderRadius = 3
        Me.txt_initials.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_initials.DefaultText = ""
        Me.txt_initials.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_initials.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_initials.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_initials.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_initials.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_initials.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_initials.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_initials.Location = New System.Drawing.Point(81, 262)
        Me.txt_initials.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txt_initials.Name = "txt_initials"
        Me.txt_initials.PlaceholderText = ""
        Me.txt_initials.SelectedText = ""
        Me.txt_initials.Size = New System.Drawing.Size(265, 36)
        Me.txt_initials.TabIndex = 100
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(78, 315)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Password"
        '
        'txt_password
        '
        Me.txt_password.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.txt_password.BorderRadius = 3
        Me.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_password.DefaultText = ""
        Me.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.Location = New System.Drawing.Point(81, 333)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.PlaceholderText = ""
        Me.txt_password.SelectedText = ""
        Me.txt_password.Size = New System.Drawing.Size(265, 36)
        Me.txt_password.TabIndex = 102
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(78, 381)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 17)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Re-enter password"
        '
        'txt_repass
        '
        Me.txt_repass.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.txt_repass.BorderRadius = 3
        Me.txt_repass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_repass.DefaultText = ""
        Me.txt_repass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_repass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_repass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_repass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_repass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_repass.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_repass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_repass.Location = New System.Drawing.Point(81, 399)
        Me.txt_repass.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txt_repass.Name = "txt_repass"
        Me.txt_repass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_repass.PlaceholderText = ""
        Me.txt_repass.SelectedText = ""
        Me.txt_repass.Size = New System.Drawing.Size(265, 36)
        Me.txt_repass.TabIndex = 104
        '
        'btn_submit
        '
        Me.btn_submit.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_submit.BorderRadius = 3
        Me.btn_submit.BorderThickness = 1
        Me.btn_submit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_submit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_submit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_submit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_submit.FillColor = System.Drawing.Color.MidnightBlue
        Me.btn_submit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_submit.ForeColor = System.Drawing.Color.White
        Me.btn_submit.Image = CType(resources.GetObject("btn_submit.Image"), System.Drawing.Image)
        Me.btn_submit.ImageSize = New System.Drawing.Size(24, 24)
        Me.btn_submit.Location = New System.Drawing.Point(81, 467)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(121, 51)
        Me.btn_submit.TabIndex = 106
        Me.btn_submit.Text = "Add user"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(78, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "Account no."
        '
        'txt_account
        '
        Me.txt_account.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.txt_account.BorderRadius = 3
        Me.txt_account.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_account.DefaultText = ""
        Me.txt_account.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_account.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_account.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_account.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_account.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_account.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_account.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_account.Location = New System.Drawing.Point(81, 104)
        Me.txt_account.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txt_account.Name = "txt_account"
        Me.txt_account.PlaceholderText = ""
        Me.txt_account.SelectedText = ""
        Me.txt_account.Size = New System.Drawing.Size(265, 36)
        Me.txt_account.TabIndex = 107
        '
        'add_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 694)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_account)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_repass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_initials)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label17)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "add_user"
        Me.Text = "v"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_initials As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_repass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_submit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_account As Guna.UI2.WinForms.Guna2TextBox
End Class
