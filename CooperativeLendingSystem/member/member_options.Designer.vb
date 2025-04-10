<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class member_options
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(member_options))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.lbl_fullname = New System.Windows.Forms.Label()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbl_accountno = New System.Windows.Forms.Label()
        Me.Guna2TileButton4 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2TileButton3 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2TileButton2 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2TileButton1 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.pic_user = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.pic_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 10
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'lbl_fullname
        '
        Me.lbl_fullname.AutoSize = True
        Me.lbl_fullname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fullname.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fullname.ForeColor = System.Drawing.Color.White
        Me.lbl_fullname.Location = New System.Drawing.Point(155, 57)
        Me.lbl_fullname.Name = "lbl_fullname"
        Me.lbl_fullname.Size = New System.Drawing.Size(149, 30)
        Me.lbl_fullname.TabIndex = 89
        Me.lbl_fullname.Text = "Member name"
        Me.lbl_fullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.BorderColor = System.Drawing.Color.Silver
        Me.Guna2ControlBox1.BorderRadius = 5
        Me.Guna2ControlBox1.BorderThickness = 1
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(628, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 85
        Me.Guna2ControlBox1.UseTransparentBackground = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.pic_user)
        Me.Guna2Panel1.Controls.Add(Me.lbl_accountno)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Controls.Add(Me.lbl_fullname)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.FillColor = System.Drawing.Color.ForestGreen
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(685, 153)
        Me.Guna2Panel1.TabIndex = 92
        '
        'lbl_accountno
        '
        Me.lbl_accountno.AutoSize = True
        Me.lbl_accountno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_accountno.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_accountno.ForeColor = System.Drawing.Color.White
        Me.lbl_accountno.Location = New System.Drawing.Point(155, 87)
        Me.lbl_accountno.Name = "lbl_accountno"
        Me.lbl_accountno.Size = New System.Drawing.Size(106, 25)
        Me.lbl_accountno.TabIndex = 91
        Me.lbl_accountno.Text = "account no"
        Me.lbl_accountno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2TileButton4
        '
        Me.Guna2TileButton4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TileButton4.BorderColor = System.Drawing.Color.LightGray
        Me.Guna2TileButton4.BorderRadius = 5
        Me.Guna2TileButton4.BorderThickness = 1
        Me.Guna2TileButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2TileButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2TileButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2TileButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2TileButton4.FillColor = System.Drawing.Color.White
        Me.Guna2TileButton4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TileButton4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Guna2TileButton4.Image = CType(resources.GetObject("Guna2TileButton4.Image"), System.Drawing.Image)
        Me.Guna2TileButton4.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2TileButton4.Location = New System.Drawing.Point(506, 208)
        Me.Guna2TileButton4.Name = "Guna2TileButton4"
        Me.Guna2TileButton4.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.Guna2TileButton4.ShadowDecoration.Enabled = True
        Me.Guna2TileButton4.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2, 2, 4, 4)
        Me.Guna2TileButton4.Size = New System.Drawing.Size(106, 112)
        Me.Guna2TileButton4.TabIndex = 93
        Me.Guna2TileButton4.Text = "Apply Loan"
        '
        'Guna2TileButton3
        '
        Me.Guna2TileButton3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TileButton3.BorderColor = System.Drawing.Color.LightGray
        Me.Guna2TileButton3.BorderRadius = 5
        Me.Guna2TileButton3.BorderThickness = 1
        Me.Guna2TileButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2TileButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2TileButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2TileButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2TileButton3.FillColor = System.Drawing.Color.White
        Me.Guna2TileButton3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TileButton3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Guna2TileButton3.Image = CType(resources.GetObject("Guna2TileButton3.Image"), System.Drawing.Image)
        Me.Guna2TileButton3.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2TileButton3.Location = New System.Drawing.Point(361, 208)
        Me.Guna2TileButton3.Name = "Guna2TileButton3"
        Me.Guna2TileButton3.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.Guna2TileButton3.ShadowDecoration.Enabled = True
        Me.Guna2TileButton3.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2, 2, 4, 4)
        Me.Guna2TileButton3.Size = New System.Drawing.Size(106, 112)
        Me.Guna2TileButton3.TabIndex = 88
        Me.Guna2TileButton3.Text = "Share Capital"
        '
        'Guna2TileButton2
        '
        Me.Guna2TileButton2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TileButton2.BorderColor = System.Drawing.Color.LightGray
        Me.Guna2TileButton2.BorderRadius = 5
        Me.Guna2TileButton2.BorderThickness = 1
        Me.Guna2TileButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2TileButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2TileButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2TileButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2TileButton2.FillColor = System.Drawing.Color.White
        Me.Guna2TileButton2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TileButton2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Guna2TileButton2.Image = CType(resources.GetObject("Guna2TileButton2.Image"), System.Drawing.Image)
        Me.Guna2TileButton2.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2TileButton2.Location = New System.Drawing.Point(214, 208)
        Me.Guna2TileButton2.Name = "Guna2TileButton2"
        Me.Guna2TileButton2.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.Guna2TileButton2.ShadowDecoration.Enabled = True
        Me.Guna2TileButton2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2, 2, 4, 4)
        Me.Guna2TileButton2.Size = New System.Drawing.Size(106, 112)
        Me.Guna2TileButton2.TabIndex = 87
        Me.Guna2TileButton2.Text = "Savings"
        '
        'Guna2TileButton1
        '
        Me.Guna2TileButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TileButton1.BorderColor = System.Drawing.Color.LightGray
        Me.Guna2TileButton1.BorderRadius = 5
        Me.Guna2TileButton1.BorderThickness = 1
        Me.Guna2TileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2TileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2TileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2TileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2TileButton1.FillColor = System.Drawing.Color.White
        Me.Guna2TileButton1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TileButton1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Guna2TileButton1.Image = CType(resources.GetObject("Guna2TileButton1.Image"), System.Drawing.Image)
        Me.Guna2TileButton1.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2TileButton1.Location = New System.Drawing.Point(67, 208)
        Me.Guna2TileButton1.Name = "Guna2TileButton1"
        Me.Guna2TileButton1.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.Guna2TileButton1.ShadowDecoration.Enabled = True
        Me.Guna2TileButton1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(2, 2, 4, 4)
        Me.Guna2TileButton1.Size = New System.Drawing.Size(106, 112)
        Me.Guna2TileButton1.TabIndex = 86
        Me.Guna2TileButton1.Text = "Info"
        '
        'pic_user
        '
        Me.pic_user.BackColor = System.Drawing.Color.Transparent
        Me.pic_user.ImageRotate = 0!
        Me.pic_user.Location = New System.Drawing.Point(50, 49)
        Me.pic_user.Name = "pic_user"
        Me.pic_user.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pic_user.Size = New System.Drawing.Size(90, 90)
        Me.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_user.TabIndex = 92
        Me.pic_user.TabStop = False
        Me.pic_user.UseTransparentBackground = True
        '
        'member_options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(685, 374)
        Me.Controls.Add(Me.Guna2TileButton4)
        Me.Controls.Add(Me.Guna2TileButton3)
        Me.Controls.Add(Me.Guna2TileButton2)
        Me.Controls.Add(Me.Guna2TileButton1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "member_options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "member_options"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.pic_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents lbl_fullname As Label
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2TileButton3 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2TileButton2 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2TileButton1 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbl_accountno As Label
    Friend WithEvents pic_user As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2TileButton4 As Guna.UI2.WinForms.Guna2TileButton
End Class
