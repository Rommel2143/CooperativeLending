<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class savings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(savings))
        Me.tab1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.datagrid1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_accountname = New System.Windows.Forms.Label()
        Me.lbl_balance = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.cmb_deptrans = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_amountdeposit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_withtrans = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btn_withdraw = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_amountwithdraw = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_passwithdraw = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tab1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab1
        '
        Me.tab1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.tab1.Controls.Add(Me.TabPage1)
        Me.tab1.Controls.Add(Me.TabPage3)
        Me.tab1.Controls.Add(Me.TabPage2)
        Me.tab1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab1.ItemSize = New System.Drawing.Size(180, 40)
        Me.tab1.Location = New System.Drawing.Point(0, 0)
        Me.tab1.Name = "tab1"
        Me.tab1.SelectedIndex = 0
        Me.tab1.Size = New System.Drawing.Size(1052, 668)
        Me.tab1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.tab1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.tab1.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.tab1.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.tab1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.tab1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.tab1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.tab1.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.tab1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.tab1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.tab1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.tab1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.tab1.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.tab1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.tab1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tab1.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.tab1.TabIndex = 0
        Me.tab1.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.datagrid1)
        Me.TabPage1.Controls.Add(Me.Guna2Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(184, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(864, 660)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Savings Account"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'datagrid1
        '
        Me.datagrid1.AllowUserToAddRows = False
        Me.datagrid1.AllowUserToDeleteRows = False
        Me.datagrid1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datagrid1.ColumnHeadersHeight = 36
        Me.datagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid1.DefaultCellStyle = DataGridViewCellStyle3
        Me.datagrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.Location = New System.Drawing.Point(3, 169)
        Me.datagrid1.Name = "datagrid1"
        Me.datagrid1.ReadOnly = True
        Me.datagrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datagrid1.RowHeadersVisible = False
        Me.datagrid1.RowTemplate.Height = 42
        Me.datagrid1.Size = New System.Drawing.Size(858, 488)
        Me.datagrid1.TabIndex = 2
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Purple
        Me.datagrid1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagrid1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid1.ThemeStyle.HeaderStyle.Height = 36
        Me.datagrid1.ThemeStyle.ReadOnly = True
        Me.datagrid1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagrid1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid1.ThemeStyle.RowsStyle.Height = 42
        Me.datagrid1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button3)
        Me.Guna2Panel1.Controls.Add(Me.lbl_accountname)
        Me.Guna2Panel1.Controls.Add(Me.lbl_balance)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(858, 166)
        Me.Guna2Panel1.TabIndex = 3
        '
        'Guna2Button3
        '
        Me.Guna2Button3.BorderRadius = 3
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Image = CType(resources.GetObject("Guna2Button3.Image"), System.Drawing.Image)
        Me.Guna2Button3.Location = New System.Drawing.Point(16, 120)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(119, 40)
        Me.Guna2Button3.TabIndex = 5
        Me.Guna2Button3.Text = "Export to excel"
        '
        'lbl_accountname
        '
        Me.lbl_accountname.AutoSize = True
        Me.lbl_accountname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_accountname.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_accountname.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_accountname.Location = New System.Drawing.Point(28, 26)
        Me.lbl_accountname.Name = "lbl_accountname"
        Me.lbl_accountname.Size = New System.Drawing.Size(107, 20)
        Me.lbl_accountname.TabIndex = 1
        Me.lbl_accountname.Text = "Account name"
        '
        'lbl_balance
        '
        Me.lbl_balance.AutoSize = True
        Me.lbl_balance.BackColor = System.Drawing.Color.Transparent
        Me.lbl_balance.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_balance.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_balance.Location = New System.Drawing.Point(28, 51)
        Me.lbl_balance.Name = "lbl_balance"
        Me.lbl_balance.Size = New System.Drawing.Size(78, 25)
        Me.lbl_balance.TabIndex = 0
        Me.lbl_balance.Text = "000000"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.cmb_deptrans)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Guna2Button1)
        Me.TabPage3.Controls.Add(Me.txt_amountdeposit)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.txt_password)
        Me.TabPage3.Location = New System.Drawing.Point(184, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(864, 660)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Deposit"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'cmb_deptrans
        '
        Me.cmb_deptrans.BackColor = System.Drawing.Color.Transparent
        Me.cmb_deptrans.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_deptrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_deptrans.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_deptrans.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_deptrans.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_deptrans.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_deptrans.ItemHeight = 30
        Me.cmb_deptrans.Items.AddRange(New Object() {"Cash", "Check", "Initial", "Credit", "Interest"})
        Me.cmb_deptrans.Location = New System.Drawing.Point(46, 168)
        Me.cmb_deptrans.Name = "cmb_deptrans"
        Me.cmb_deptrans.Size = New System.Drawing.Size(157, 36)
        Me.cmb_deptrans.StartIndex = 0
        Me.cmb_deptrans.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(46, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 20)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Transaction"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(210, 211)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(106, 40)
        Me.Guna2Button1.TabIndex = 3
        Me.Guna2Button1.Text = "Deposit"
        '
        'txt_amountdeposit
        '
        Me.txt_amountdeposit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_amountdeposit.DefaultText = ""
        Me.txt_amountdeposit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_amountdeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_amountdeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_amountdeposit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_amountdeposit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_amountdeposit.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amountdeposit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_amountdeposit.Location = New System.Drawing.Point(46, 71)
        Me.txt_amountdeposit.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txt_amountdeposit.Name = "txt_amountdeposit"
        Me.txt_amountdeposit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_amountdeposit.PlaceholderText = ""
        Me.txt_amountdeposit.SelectedText = ""
        Me.txt_amountdeposit.Size = New System.Drawing.Size(270, 38)
        Me.txt_amountdeposit.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(41, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Deposit Funds"
        '
        'txt_password
        '
        Me.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_password.DefaultText = ""
        Me.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.IconLeft = CType(resources.GetObject("txt_password.IconLeft"), System.Drawing.Image)
        Me.txt_password.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.txt_password.Location = New System.Drawing.Point(46, 211)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_password.PlaceholderText = "Password..."
        Me.txt_password.SelectedText = ""
        Me.txt_password.Size = New System.Drawing.Size(157, 40)
        Me.txt_password.TabIndex = 53
        Me.txt_password.UseSystemPasswordChar = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.cmb_withtrans)
        Me.TabPage2.Controls.Add(Me.btn_withdraw)
        Me.TabPage2.Controls.Add(Me.txt_amountwithdraw)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txt_passwithdraw)
        Me.TabPage2.Location = New System.Drawing.Point(184, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(864, 660)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Withdraw"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(42, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Transaction"
        '
        'cmb_withtrans
        '
        Me.cmb_withtrans.BackColor = System.Drawing.Color.Transparent
        Me.cmb_withtrans.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_withtrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_withtrans.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_withtrans.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_withtrans.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_withtrans.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_withtrans.ItemHeight = 30
        Me.cmb_withtrans.Items.AddRange(New Object() {"Cash", "Check", "Debit"})
        Me.cmb_withtrans.Location = New System.Drawing.Point(46, 171)
        Me.cmb_withtrans.Name = "cmb_withtrans"
        Me.cmb_withtrans.Size = New System.Drawing.Size(146, 36)
        Me.cmb_withtrans.StartIndex = 0
        Me.cmb_withtrans.TabIndex = 56
        '
        'btn_withdraw
        '
        Me.btn_withdraw.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_withdraw.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_withdraw.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_withdraw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_withdraw.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_withdraw.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_withdraw.ForeColor = System.Drawing.Color.White
        Me.btn_withdraw.Location = New System.Drawing.Point(210, 213)
        Me.btn_withdraw.Name = "btn_withdraw"
        Me.btn_withdraw.Size = New System.Drawing.Size(106, 40)
        Me.btn_withdraw.TabIndex = 6
        Me.btn_withdraw.Text = "Withdraw"
        '
        'txt_amountwithdraw
        '
        Me.txt_amountwithdraw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_amountwithdraw.DefaultText = ""
        Me.txt_amountwithdraw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_amountwithdraw.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_amountwithdraw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_amountwithdraw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_amountwithdraw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_amountwithdraw.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amountwithdraw.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_amountwithdraw.Location = New System.Drawing.Point(46, 71)
        Me.txt_amountwithdraw.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txt_amountwithdraw.Name = "txt_amountwithdraw"
        Me.txt_amountwithdraw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_amountwithdraw.PlaceholderText = ""
        Me.txt_amountwithdraw.SelectedText = ""
        Me.txt_amountwithdraw.Size = New System.Drawing.Size(270, 38)
        Me.txt_amountwithdraw.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(41, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Withdraw Funds"
        '
        'txt_passwithdraw
        '
        Me.txt_passwithdraw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_passwithdraw.DefaultText = ""
        Me.txt_passwithdraw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_passwithdraw.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_passwithdraw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_passwithdraw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_passwithdraw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_passwithdraw.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txt_passwithdraw.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_passwithdraw.IconLeft = CType(resources.GetObject("txt_passwithdraw.IconLeft"), System.Drawing.Image)
        Me.txt_passwithdraw.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.txt_passwithdraw.Location = New System.Drawing.Point(46, 213)
        Me.txt_passwithdraw.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_passwithdraw.Name = "txt_passwithdraw"
        Me.txt_passwithdraw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_passwithdraw.PlaceholderText = "Password..."
        Me.txt_passwithdraw.SelectedText = ""
        Me.txt_passwithdraw.Size = New System.Drawing.Size(157, 40)
        Me.txt_passwithdraw.TabIndex = 54
        Me.txt_passwithdraw.UseSystemPasswordChar = True
        '
        'savings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 668)
        Me.Controls.Add(Me.tab1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "savings"
        Me.Text = "savings"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tab1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lbl_accountname As Label
    Friend WithEvents lbl_balance As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents datagrid1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_amountdeposit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_withdraw As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_amountwithdraw As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_passwithdraw As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cmb_deptrans As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_withtrans As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
End Class
