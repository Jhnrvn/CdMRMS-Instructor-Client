<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CDMRMS_Instructor_Login
    Inherits MetroFramework.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CDMRMS_Instructor_Login))
        Me.Login_Panel = New System.Windows.Forms.Panel()
        Me.User_Logo = New System.Windows.Forms.PictureBox()
        Me.LoginPassword_Label = New System.Windows.Forms.Label()
        Me.LoginEmail_Label = New System.Windows.Forms.Label()
        Me.LoginInstructorID_Label = New System.Windows.Forms.Label()
        Me.LoginPassword_Input = New MetroFramework.Controls.MetroTextBox()
        Me.LoginEmail_Input = New MetroFramework.Controls.MetroTextBox()
        Me.LoginInstructorID_Input = New MetroFramework.Controls.MetroTextBox()
        Me.Register_Link = New System.Windows.Forms.LinkLabel()
        Me.Login_Label = New System.Windows.Forms.Label()
        Me.Login_Btn = New System.Windows.Forms.Button()
        Me.Tooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BG_Picture = New System.Windows.Forms.PictureBox()
        Me.FN_Input = New MetroFramework.Controls.MetroTextBox()
        Me.MN_Input = New MetroFramework.Controls.MetroTextBox()
        Me.LN_Input = New MetroFramework.Controls.MetroTextBox()
        Me.FN_Label = New System.Windows.Forms.Label()
        Me.MN_Label = New System.Windows.Forms.Label()
        Me.LN_Label = New System.Windows.Forms.Label()
        Me.InstructorID_Input = New MetroFramework.Controls.MetroTextBox()
        Me.InstructorID_Label = New System.Windows.Forms.Label()
        Me.Sex_Panel = New System.Windows.Forms.Panel()
        Me.Male_RadioBtn = New MetroFramework.Controls.MetroRadioButton()
        Me.Female_RadioBtn = New MetroFramework.Controls.MetroRadioButton()
        Me.Sex_Label = New System.Windows.Forms.Label()
        Me.Email_Input = New MetroFramework.Controls.MetroTextBox()
        Me.Email_Label = New System.Windows.Forms.Label()
        Me.Contact_Input = New MetroFramework.Controls.MetroTextBox()
        Me.Contact_Label = New System.Windows.Forms.Label()
        Me.Password_Input = New MetroFramework.Controls.MetroTextBox()
        Me.Password_Label = New System.Windows.Forms.Label()
        Me.Password2_Input = New MetroFramework.Controls.MetroTextBox()
        Me.Password2_Label = New System.Windows.Forms.Label()
        Me.Register_Btn = New System.Windows.Forms.Button()
        Me.Registration_Label = New System.Windows.Forms.Label()
        Me.Login_Link = New System.Windows.Forms.LinkLabel()
        Me.RegToolTip_Label3 = New System.Windows.Forms.Label()
        Me.RegToolTip_Label2 = New System.Windows.Forms.Label()
        Me.RegToolTip_Label1 = New System.Windows.Forms.Label()
        Me.Birthdate_Picker = New System.Windows.Forms.DateTimePicker()
        Me.Birthday_Label = New System.Windows.Forms.Label()
        Me.RegToolTip_Label4 = New System.Windows.Forms.Label()
        Me.Registration_Panel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Login_Panel.SuspendLayout()
        CType(Me.User_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BG_Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Sex_Panel.SuspendLayout()
        Me.Registration_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Login_Panel
        '
        Me.Login_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Login_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Login_Panel.Controls.Add(Me.User_Logo)
        Me.Login_Panel.Controls.Add(Me.LoginPassword_Label)
        Me.Login_Panel.Controls.Add(Me.LoginEmail_Label)
        Me.Login_Panel.Controls.Add(Me.LoginInstructorID_Label)
        Me.Login_Panel.Controls.Add(Me.LoginPassword_Input)
        Me.Login_Panel.Controls.Add(Me.LoginEmail_Input)
        Me.Login_Panel.Controls.Add(Me.LoginInstructorID_Input)
        Me.Login_Panel.Controls.Add(Me.Register_Link)
        Me.Login_Panel.Controls.Add(Me.Login_Label)
        Me.Login_Panel.Controls.Add(Me.Login_Btn)
        Me.Login_Panel.Location = New System.Drawing.Point(-3, 31)
        Me.Login_Panel.Name = "Login_Panel"
        Me.Login_Panel.Size = New System.Drawing.Size(546, 850)
        Me.Login_Panel.TabIndex = 26
        '
        'User_Logo
        '
        Me.User_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.User_Logo.Image = CType(resources.GetObject("User_Logo.Image"), System.Drawing.Image)
        Me.User_Logo.Location = New System.Drawing.Point(100, 148)
        Me.User_Logo.Name = "User_Logo"
        Me.User_Logo.Size = New System.Drawing.Size(334, 242)
        Me.User_Logo.TabIndex = 32
        Me.User_Logo.TabStop = False
        Me.User_Logo.WaitOnLoad = True
        '
        'LoginPassword_Label
        '
        Me.LoginPassword_Label.AutoSize = True
        Me.LoginPassword_Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.LoginPassword_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginPassword_Label.Location = New System.Drawing.Point(52, 544)
        Me.LoginPassword_Label.Name = "LoginPassword_Label"
        Me.LoginPassword_Label.Size = New System.Drawing.Size(83, 20)
        Me.LoginPassword_Label.TabIndex = 31
        Me.LoginPassword_Label.Text = "Password"
        '
        'LoginEmail_Label
        '
        Me.LoginEmail_Label.AutoSize = True
        Me.LoginEmail_Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.LoginEmail_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginEmail_Label.Location = New System.Drawing.Point(52, 473)
        Me.LoginEmail_Label.Name = "LoginEmail_Label"
        Me.LoginEmail_Label.Size = New System.Drawing.Size(51, 20)
        Me.LoginEmail_Label.TabIndex = 30
        Me.LoginEmail_Label.Text = "Email"
        '
        'LoginInstructorID_Label
        '
        Me.LoginInstructorID_Label.AutoSize = True
        Me.LoginInstructorID_Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.LoginInstructorID_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginInstructorID_Label.Location = New System.Drawing.Point(52, 404)
        Me.LoginInstructorID_Label.Name = "LoginInstructorID_Label"
        Me.LoginInstructorID_Label.Size = New System.Drawing.Size(145, 20)
        Me.LoginInstructorID_Label.TabIndex = 29
        Me.LoginInstructorID_Label.Text = "Instructor's ID No."
        '
        'LoginPassword_Input
        '
        '
        '
        '
        Me.LoginPassword_Input.CustomButton.Image = Nothing
        Me.LoginPassword_Input.CustomButton.Location = New System.Drawing.Point(389, 2)
        Me.LoginPassword_Input.CustomButton.Name = ""
        Me.LoginPassword_Input.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.LoginPassword_Input.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.LoginPassword_Input.CustomButton.TabIndex = 1
        Me.LoginPassword_Input.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.LoginPassword_Input.CustomButton.UseSelectable = True
        Me.LoginPassword_Input.CustomButton.Visible = False
        Me.LoginPassword_Input.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.LoginPassword_Input.Lines = New String(-1) {}
        Me.LoginPassword_Input.Location = New System.Drawing.Point(56, 563)
        Me.LoginPassword_Input.MaxLength = 50
        Me.LoginPassword_Input.Name = "LoginPassword_Input"
        Me.LoginPassword_Input.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.LoginPassword_Input.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.LoginPassword_Input.SelectedText = ""
        Me.LoginPassword_Input.SelectionLength = 0
        Me.LoginPassword_Input.SelectionStart = 0
        Me.LoginPassword_Input.ShortcutsEnabled = True
        Me.LoginPassword_Input.Size = New System.Drawing.Size(427, 40)
        Me.LoginPassword_Input.Style = MetroFramework.MetroColorStyle.Yellow
        Me.LoginPassword_Input.TabIndex = 28
        Me.LoginPassword_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.LoginPassword_Input.UseSelectable = True
        Me.LoginPassword_Input.WaterMarkColor = System.Drawing.Color.Silver
        Me.LoginPassword_Input.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LoginEmail_Input
        '
        '
        '
        '
        Me.LoginEmail_Input.CustomButton.Image = Nothing
        Me.LoginEmail_Input.CustomButton.Location = New System.Drawing.Point(389, 2)
        Me.LoginEmail_Input.CustomButton.Name = ""
        Me.LoginEmail_Input.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.LoginEmail_Input.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.LoginEmail_Input.CustomButton.TabIndex = 1
        Me.LoginEmail_Input.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.LoginEmail_Input.CustomButton.UseSelectable = True
        Me.LoginEmail_Input.CustomButton.Visible = False
        Me.LoginEmail_Input.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.LoginEmail_Input.Lines = New String(-1) {}
        Me.LoginEmail_Input.Location = New System.Drawing.Point(56, 492)
        Me.LoginEmail_Input.MaxLength = 50
        Me.LoginEmail_Input.Name = "LoginEmail_Input"
        Me.LoginEmail_Input.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LoginEmail_Input.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.LoginEmail_Input.SelectedText = ""
        Me.LoginEmail_Input.SelectionLength = 0
        Me.LoginEmail_Input.SelectionStart = 0
        Me.LoginEmail_Input.ShortcutsEnabled = True
        Me.LoginEmail_Input.Size = New System.Drawing.Size(427, 40)
        Me.LoginEmail_Input.Style = MetroFramework.MetroColorStyle.Yellow
        Me.LoginEmail_Input.TabIndex = 27
        Me.LoginEmail_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.LoginEmail_Input.UseSelectable = True
        Me.LoginEmail_Input.WaterMarkColor = System.Drawing.Color.Silver
        Me.LoginEmail_Input.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LoginInstructorID_Input
        '
        '
        '
        '
        Me.LoginInstructorID_Input.CustomButton.Image = Nothing
        Me.LoginInstructorID_Input.CustomButton.Location = New System.Drawing.Point(389, 2)
        Me.LoginInstructorID_Input.CustomButton.Name = ""
        Me.LoginInstructorID_Input.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.LoginInstructorID_Input.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.LoginInstructorID_Input.CustomButton.TabIndex = 1
        Me.LoginInstructorID_Input.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.LoginInstructorID_Input.CustomButton.UseSelectable = True
        Me.LoginInstructorID_Input.CustomButton.Visible = False
        Me.LoginInstructorID_Input.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.LoginInstructorID_Input.Lines = New String(-1) {}
        Me.LoginInstructorID_Input.Location = New System.Drawing.Point(56, 423)
        Me.LoginInstructorID_Input.MaxLength = 8
        Me.LoginInstructorID_Input.Name = "LoginInstructorID_Input"
        Me.LoginInstructorID_Input.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LoginInstructorID_Input.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.LoginInstructorID_Input.SelectedText = ""
        Me.LoginInstructorID_Input.SelectionLength = 0
        Me.LoginInstructorID_Input.SelectionStart = 0
        Me.LoginInstructorID_Input.ShortcutsEnabled = True
        Me.LoginInstructorID_Input.Size = New System.Drawing.Size(427, 40)
        Me.LoginInstructorID_Input.Style = MetroFramework.MetroColorStyle.Yellow
        Me.LoginInstructorID_Input.TabIndex = 26
        Me.LoginInstructorID_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.LoginInstructorID_Input.UseSelectable = True
        Me.LoginInstructorID_Input.WaterMarkColor = System.Drawing.Color.Silver
        Me.LoginInstructorID_Input.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Register_Link
        '
        Me.Register_Link.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Register_Link.AutoSize = True
        Me.Register_Link.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register_Link.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.Register_Link.LinkColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Register_Link.Location = New System.Drawing.Point(52, 739)
        Me.Register_Link.Name = "Register_Link"
        Me.Register_Link.Size = New System.Drawing.Size(97, 20)
        Me.Register_Link.TabIndex = 25
        Me.Register_Link.TabStop = True
        Me.Register_Link.Text = "Register >"
        Me.Register_Link.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Register_Link.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(33, Byte), Integer))
        '
        'Login_Label
        '
        Me.Login_Label.AutoSize = True
        Me.Login_Label.Font = New System.Drawing.Font("Bernard MT Condensed", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Login_Label.Location = New System.Drawing.Point(181, 28)
        Me.Login_Label.Name = "Login_Label"
        Me.Login_Label.Size = New System.Drawing.Size(176, 81)
        Me.Login_Label.TabIndex = 23
        Me.Login_Label.Text = "Login"
        Me.Login_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Login_Btn
        '
        Me.Login_Btn.BackColor = System.Drawing.Color.Yellow
        Me.Login_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Login_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Login_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Login_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Login_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Login_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_Btn.ForeColor = System.Drawing.Color.Black
        Me.Login_Btn.Location = New System.Drawing.Point(383, 656)
        Me.Login_Btn.Name = "Login_Btn"
        Me.Login_Btn.Size = New System.Drawing.Size(100, 40)
        Me.Login_Btn.TabIndex = 22
        Me.Login_Btn.Text = "Login"
        Me.Login_Btn.UseVisualStyleBackColor = False
        '
        'Tooltip
        '
        Me.Tooltip.AutomaticDelay = 100
        Me.Tooltip.AutoPopDelay = 20000
        Me.Tooltip.InitialDelay = 10
        Me.Tooltip.IsBalloon = True
        Me.Tooltip.ReshowDelay = 20
        Me.Tooltip.ShowAlways = True
        '
        'BG_Picture
        '
        Me.BG_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BG_Picture.Image = CType(resources.GetObject("BG_Picture.Image"), System.Drawing.Image)
        Me.BG_Picture.Location = New System.Drawing.Point(540, 31)
        Me.BG_Picture.Name = "BG_Picture"
        Me.BG_Picture.Size = New System.Drawing.Size(1010, 850)
        Me.BG_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.BG_Picture.TabIndex = 0
        Me.BG_Picture.TabStop = False
        '
        'FN_Input
        '
        '
        '
        '
        Me.FN_Input.CustomButton.Image = Nothing
        Me.FN_Input.CustomButton.Location = New System.Drawing.Point(100, 2)
        Me.FN_Input.CustomButton.Name = ""
        Me.FN_Input.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.FN_Input.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.FN_Input.CustomButton.TabIndex = 1
        Me.FN_Input.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.FN_Input.CustomButton.UseSelectable = True
        Me.FN_Input.CustomButton.Visible = False
        Me.FN_Input.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.FN_Input.Lines = New String(-1) {}
        Me.FN_Input.Location = New System.Drawing.Point(55, 152)
        Me.FN_Input.MaxLength = 30
        Me.FN_Input.Name = "FN_Input"
        Me.FN_Input.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FN_Input.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.FN_Input.SelectedText = ""
        Me.FN_Input.SelectionLength = 0
        Me.FN_Input.SelectionStart = 0
        Me.FN_Input.ShortcutsEnabled = True
        Me.FN_Input.Size = New System.Drawing.Size(138, 40)
        Me.FN_Input.Style = MetroFramework.MetroColorStyle.Yellow
        Me.FN_Input.TabIndex = 0
        Me.FN_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FN_Input.UseSelectable = True
        Me.FN_Input.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FN_Input.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MN_Input
        '
        '
        '
        '
        Me.MN_Input.CustomButton.Image = Nothing
        Me.MN_Input.CustomButton.Location = New System.Drawing.Point(100, 2)
        Me.MN_Input.CustomButton.Name = ""
        Me.MN_Input.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.MN_Input.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MN_Input.CustomButton.TabIndex = 1
        Me.MN_Input.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MN_Input.CustomButton.UseSelectable = True
        Me.MN_Input.CustomButton.Visible = False
        Me.MN_Input.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MN_Input.Lines = New String(-1) {}
        Me.MN_Input.Location = New System.Drawing.Point(343, 152)
        Me.MN_Input.MaxLength = 30
        Me.MN_Input.Name = "MN_Input"
        Me.MN_Input.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MN_Input.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MN_Input.SelectedText = ""
        Me.MN_Input.SelectionLength = 0
        Me.MN_Input.SelectionStart = 0
        Me.MN_Input.ShortcutsEnabled = True
        Me.MN_Input.Size = New System.Drawing.Size(138, 40)
        Me.MN_Input.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MN_Input.TabIndex = 3
        Me.MN_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MN_Input.UseSelectable = True
        Me.MN_Input.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MN_Input.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'LN_Input
        '
        '
        '
        '
        Me.LN_Input.CustomButton.Image = Nothing
        Me.LN_Input.CustomButton.Location = New System.Drawing.Point(100, 2)
        Me.LN_Input.CustomButton.Name = ""
        Me.LN_Input.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.LN_Input.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.LN_Input.CustomButton.TabIndex = 1
        Me.LN_Input.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.LN_Input.CustomButton.UseSelectable = True
        Me.LN_Input.CustomButton.Visible = False
        Me.LN_Input.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.LN_Input.Lines = New String(-1) {}
        Me.LN_Input.Location = New System.Drawing.Point(199, 152)
        Me.LN_Input.MaxLength = 30
        Me.LN_Input.Name = "LN_Input"
        Me.LN_Input.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LN_Input.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.LN_Input.SelectedText = ""
        Me.LN_Input.SelectionLength = 0
        Me.LN_Input.SelectionStart = 0
        Me.LN_Input.ShortcutsEnabled = True
        Me.LN_Input.Size = New System.Drawing.Size(138, 40)
        Me.LN_Input.Style = MetroFramework.MetroColorStyle.Yellow
        Me.LN_Input.TabIndex = 2
        Me.LN_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.LN_Input.UseSelectable = True
        Me.LN_Input.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.LN_Input.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'FN_Label
        '
        Me.FN_Label.AutoSize = True
        Me.FN_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FN_Label.Location = New System.Drawing.Point(51, 133)
        Me.FN_Label.Name = "FN_Label"
        Me.FN_Label.Size = New System.Drawing.Size(92, 20)
        Me.FN_Label.TabIndex = 4
        Me.FN_Label.Text = "First Name"
        '
        'MN_Label
        '
        Me.MN_Label.AutoSize = True
        Me.MN_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MN_Label.Location = New System.Drawing.Point(339, 133)
        Me.MN_Label.Name = "MN_Label"
        Me.MN_Label.Size = New System.Drawing.Size(107, 20)
        Me.MN_Label.TabIndex = 5
        Me.MN_Label.Text = "Middle Name"
        '
        'LN_Label
        '
        Me.LN_Label.AutoSize = True
        Me.LN_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LN_Label.Location = New System.Drawing.Point(195, 133)
        Me.LN_Label.Name = "LN_Label"
        Me.LN_Label.Size = New System.Drawing.Size(91, 20)
        Me.LN_Label.TabIndex = 6
        Me.LN_Label.Text = "Last Name"
        '
        'InstructorID_Input
        '
        '
        '
        '
        Me.InstructorID_Input.CustomButton.Image = Nothing
        Me.InstructorID_Input.CustomButton.Location = New System.Drawing.Point(388, 2)
        Me.InstructorID_Input.CustomButton.Name = ""
        Me.InstructorID_Input.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.InstructorID_Input.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.InstructorID_Input.CustomButton.TabIndex = 1
        Me.InstructorID_Input.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.InstructorID_Input.CustomButton.UseSelectable = True
        Me.InstructorID_Input.CustomButton.Visible = False
        Me.InstructorID_Input.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.InstructorID_Input.Lines = New String(-1) {}
        Me.InstructorID_Input.Location = New System.Drawing.Point(55, 219)
        Me.InstructorID_Input.MaxLength = 8
        Me.InstructorID_Input.Name = "InstructorID_Input"
        Me.InstructorID_Input.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.InstructorID_Input.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.InstructorID_Input.SelectedText = ""
        Me.InstructorID_Input.SelectionLength = 0
        Me.InstructorID_Input.SelectionStart = 0
        Me.InstructorID_Input.ShortcutsEnabled = True
        Me.InstructorID_Input.Size = New System.Drawing.Size(426, 40)
        Me.InstructorID_Input.Style = MetroFramework.MetroColorStyle.Yellow
        Me.InstructorID_Input.TabIndex = 7
        Me.InstructorID_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InstructorID_Input.UseSelectable = True
        Me.InstructorID_Input.WaterMarkColor = System.Drawing.Color.Silver
        Me.InstructorID_Input.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'InstructorID_Label
        '
        Me.InstructorID_Label.AutoSize = True
        Me.InstructorID_Label.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.InstructorID_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructorID_Label.Location = New System.Drawing.Point(51, 200)
        Me.InstructorID_Label.Name = "InstructorID_Label"
        Me.InstructorID_Label.Size = New System.Drawing.Size(145, 20)
        Me.InstructorID_Label.TabIndex = 8
        Me.InstructorID_Label.Text = "Instructor's ID No."
        '
        'Sex_Panel
        '
        Me.Sex_Panel.BackColor = System.Drawing.Color.White
        Me.Sex_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Sex_Panel.Controls.Add(Me.Male_RadioBtn)
        Me.Sex_Panel.Controls.Add(Me.Female_RadioBtn)
        Me.Sex_Panel.Location = New System.Drawing.Point(55, 286)
        Me.Sex_Panel.Name = "Sex_Panel"
        Me.Sex_Panel.Size = New System.Drawing.Size(426, 40)
        Me.Sex_Panel.TabIndex = 13
        '
        'Male_RadioBtn
        '
        Me.Male_RadioBtn.AutoSize = True
        Me.Male_RadioBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Male_RadioBtn.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.Male_RadioBtn.Location = New System.Drawing.Point(85, 8)
        Me.Male_RadioBtn.Name = "Male_RadioBtn"
        Me.Male_RadioBtn.Size = New System.Drawing.Size(58, 20)
        Me.Male_RadioBtn.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Male_RadioBtn.TabIndex = 10
        Me.Male_RadioBtn.Text = "Male"
        Me.Male_RadioBtn.UseSelectable = True
        '
        'Female_RadioBtn
        '
        Me.Female_RadioBtn.AutoSize = True
        Me.Female_RadioBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Female_RadioBtn.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.Female_RadioBtn.Location = New System.Drawing.Point(250, 8)
        Me.Female_RadioBtn.Name = "Female_RadioBtn"
        Me.Female_RadioBtn.Size = New System.Drawing.Size(73, 20)
        Me.Female_RadioBtn.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Female_RadioBtn.TabIndex = 11
        Me.Female_RadioBtn.Text = "Female"
        Me.Female_RadioBtn.UseSelectable = True
        '
        'Sex_Label
        '
        Me.Sex_Label.AutoSize = True
        Me.Sex_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sex_Label.Location = New System.Drawing.Point(51, 267)
        Me.Sex_Label.Name = "Sex_Label"
        Me.Sex_Label.Size = New System.Drawing.Size(37, 20)
        Me.Sex_Label.TabIndex = 9
        Me.Sex_Label.Text = "Sex"
        '
        'Email_Input
        '
        '
        '
        '
        Me.Email_Input.CustomButton.Image = Nothing
        Me.Email_Input.CustomButton.Location = New System.Drawing.Point(388, 2)
        Me.Email_Input.CustomButton.Name = ""
        Me.Email_Input.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.Email_Input.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Email_Input.CustomButton.TabIndex = 1
        Me.Email_Input.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Email_Input.CustomButton.UseSelectable = True
        Me.Email_Input.CustomButton.Visible = False
        Me.Email_Input.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Email_Input.Lines = New String(-1) {}
        Me.Email_Input.Location = New System.Drawing.Point(55, 355)
        Me.Email_Input.MaxLength = 50
        Me.Email_Input.Name = "Email_Input"
        Me.Email_Input.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Email_Input.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Email_Input.SelectedText = ""
        Me.Email_Input.SelectionLength = 0
        Me.Email_Input.SelectionStart = 0
        Me.Email_Input.ShortcutsEnabled = True
        Me.Email_Input.Size = New System.Drawing.Size(426, 40)
        Me.Email_Input.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Email_Input.TabIndex = 14
        Me.Email_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Email_Input.UseSelectable = True
        Me.Email_Input.WaterMarkColor = System.Drawing.Color.Silver
        Me.Email_Input.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Email_Label
        '
        Me.Email_Label.AutoSize = True
        Me.Email_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_Label.Location = New System.Drawing.Point(51, 336)
        Me.Email_Label.Name = "Email_Label"
        Me.Email_Label.Size = New System.Drawing.Size(118, 20)
        Me.Email_Label.TabIndex = 15
        Me.Email_Label.Text = "Email Address"
        '
        'Contact_Input
        '
        '
        '
        '
        Me.Contact_Input.CustomButton.Image = Nothing
        Me.Contact_Input.CustomButton.Location = New System.Drawing.Point(172, 2)
        Me.Contact_Input.CustomButton.Name = ""
        Me.Contact_Input.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.Contact_Input.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Contact_Input.CustomButton.TabIndex = 1
        Me.Contact_Input.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Contact_Input.CustomButton.UseSelectable = True
        Me.Contact_Input.CustomButton.Visible = False
        Me.Contact_Input.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Contact_Input.Lines = New String(-1) {}
        Me.Contact_Input.Location = New System.Drawing.Point(55, 423)
        Me.Contact_Input.MaxLength = 11
        Me.Contact_Input.Name = "Contact_Input"
        Me.Contact_Input.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Contact_Input.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Contact_Input.SelectedText = ""
        Me.Contact_Input.SelectionLength = 0
        Me.Contact_Input.SelectionStart = 0
        Me.Contact_Input.ShortcutsEnabled = True
        Me.Contact_Input.Size = New System.Drawing.Size(210, 40)
        Me.Contact_Input.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Contact_Input.TabIndex = 16
        Me.Contact_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Contact_Input.UseSelectable = True
        Me.Contact_Input.WaterMarkColor = System.Drawing.Color.Silver
        Me.Contact_Input.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Contact_Label
        '
        Me.Contact_Label.AutoSize = True
        Me.Contact_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contact_Label.Location = New System.Drawing.Point(51, 404)
        Me.Contact_Label.Name = "Contact_Label"
        Me.Contact_Label.Size = New System.Drawing.Size(131, 20)
        Me.Contact_Label.TabIndex = 17
        Me.Contact_Label.Text = "Contact Number"
        '
        'Password_Input
        '
        '
        '
        '
        Me.Password_Input.CustomButton.Image = Nothing
        Me.Password_Input.CustomButton.Location = New System.Drawing.Point(388, 2)
        Me.Password_Input.CustomButton.Name = ""
        Me.Password_Input.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.Password_Input.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Password_Input.CustomButton.TabIndex = 1
        Me.Password_Input.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Password_Input.CustomButton.UseSelectable = True
        Me.Password_Input.CustomButton.Visible = False
        Me.Password_Input.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Password_Input.Lines = New String(-1) {}
        Me.Password_Input.Location = New System.Drawing.Point(55, 492)
        Me.Password_Input.MaxLength = 30
        Me.Password_Input.Name = "Password_Input"
        Me.Password_Input.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Password_Input.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Password_Input.SelectedText = ""
        Me.Password_Input.SelectionLength = 0
        Me.Password_Input.SelectionStart = 0
        Me.Password_Input.ShortcutsEnabled = True
        Me.Password_Input.Size = New System.Drawing.Size(426, 40)
        Me.Password_Input.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Password_Input.TabIndex = 18
        Me.Password_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Password_Input.UseSelectable = True
        Me.Password_Input.UseSystemPasswordChar = True
        Me.Password_Input.WaterMarkColor = System.Drawing.Color.Silver
        Me.Password_Input.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Password_Label
        '
        Me.Password_Label.AutoSize = True
        Me.Password_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_Label.Location = New System.Drawing.Point(51, 473)
        Me.Password_Label.Name = "Password_Label"
        Me.Password_Label.Size = New System.Drawing.Size(83, 20)
        Me.Password_Label.TabIndex = 19
        Me.Password_Label.Text = "Password"
        '
        'Password2_Input
        '
        '
        '
        '
        Me.Password2_Input.CustomButton.Image = Nothing
        Me.Password2_Input.CustomButton.Location = New System.Drawing.Point(388, 2)
        Me.Password2_Input.CustomButton.Name = ""
        Me.Password2_Input.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.Password2_Input.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Password2_Input.CustomButton.TabIndex = 1
        Me.Password2_Input.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Password2_Input.CustomButton.UseSelectable = True
        Me.Password2_Input.CustomButton.Visible = False
        Me.Password2_Input.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Password2_Input.Lines = New String(-1) {}
        Me.Password2_Input.Location = New System.Drawing.Point(55, 562)
        Me.Password2_Input.MaxLength = 30
        Me.Password2_Input.Name = "Password2_Input"
        Me.Password2_Input.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Password2_Input.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Password2_Input.SelectedText = ""
        Me.Password2_Input.SelectionLength = 0
        Me.Password2_Input.SelectionStart = 0
        Me.Password2_Input.ShortcutsEnabled = True
        Me.Password2_Input.Size = New System.Drawing.Size(426, 40)
        Me.Password2_Input.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Password2_Input.TabIndex = 20
        Me.Password2_Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Password2_Input.UseSelectable = True
        Me.Password2_Input.UseSystemPasswordChar = True
        Me.Password2_Input.WaterMarkColor = System.Drawing.Color.Silver
        Me.Password2_Input.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Password2_Label
        '
        Me.Password2_Label.AutoSize = True
        Me.Password2_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password2_Label.Location = New System.Drawing.Point(51, 543)
        Me.Password2_Label.Name = "Password2_Label"
        Me.Password2_Label.Size = New System.Drawing.Size(153, 20)
        Me.Password2_Label.TabIndex = 21
        Me.Password2_Label.Text = "Re-enter Password"
        '
        'Register_Btn
        '
        Me.Register_Btn.BackColor = System.Drawing.Color.Yellow
        Me.Register_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Register_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Register_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Register_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Register_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Register_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register_Btn.ForeColor = System.Drawing.Color.Black
        Me.Register_Btn.Location = New System.Drawing.Point(381, 656)
        Me.Register_Btn.Name = "Register_Btn"
        Me.Register_Btn.Size = New System.Drawing.Size(100, 40)
        Me.Register_Btn.TabIndex = 22
        Me.Register_Btn.Text = "Register"
        Me.Register_Btn.UseVisualStyleBackColor = False
        '
        'Registration_Label
        '
        Me.Registration_Label.AutoSize = True
        Me.Registration_Label.Font = New System.Drawing.Font("Bernard MT Condensed", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Registration_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Registration_Label.Location = New System.Drawing.Point(87, 28)
        Me.Registration_Label.Name = "Registration_Label"
        Me.Registration_Label.Size = New System.Drawing.Size(346, 81)
        Me.Registration_Label.TabIndex = 23
        Me.Registration_Label.Text = "Registration"
        Me.Registration_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Login_Link
        '
        Me.Login_Link.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Login_Link.AutoSize = True
        Me.Login_Link.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_Link.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.Login_Link.LinkColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Login_Link.Location = New System.Drawing.Point(52, 739)
        Me.Login_Link.Name = "Login_Link"
        Me.Login_Link.Size = New System.Drawing.Size(72, 20)
        Me.Login_Link.TabIndex = 25
        Me.Login_Link.TabStop = True
        Me.Login_Link.Text = "Login >"
        Me.Login_Link.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Login_Link.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(33, Byte), Integer))
        '
        'RegToolTip_Label3
        '
        Me.RegToolTip_Label3.AutoSize = True
        Me.RegToolTip_Label3.BackColor = System.Drawing.Color.Transparent
        Me.RegToolTip_Label3.Cursor = System.Windows.Forms.Cursors.Help
        Me.RegToolTip_Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RegToolTip_Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegToolTip_Label3.ForeColor = System.Drawing.Color.Red
        Me.RegToolTip_Label3.Location = New System.Drawing.Point(240, 403)
        Me.RegToolTip_Label3.Name = "RegToolTip_Label3"
        Me.RegToolTip_Label3.Size = New System.Drawing.Size(19, 20)
        Me.RegToolTip_Label3.TabIndex = 27
        Me.RegToolTip_Label3.Text = "?"
        '
        'RegToolTip_Label2
        '
        Me.RegToolTip_Label2.AutoSize = True
        Me.RegToolTip_Label2.BackColor = System.Drawing.Color.Transparent
        Me.RegToolTip_Label2.Cursor = System.Windows.Forms.Cursors.Help
        Me.RegToolTip_Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RegToolTip_Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegToolTip_Label2.ForeColor = System.Drawing.Color.Red
        Me.RegToolTip_Label2.Location = New System.Drawing.Point(456, 334)
        Me.RegToolTip_Label2.Name = "RegToolTip_Label2"
        Me.RegToolTip_Label2.Size = New System.Drawing.Size(19, 20)
        Me.RegToolTip_Label2.TabIndex = 28
        Me.RegToolTip_Label2.Text = "?"
        '
        'RegToolTip_Label1
        '
        Me.RegToolTip_Label1.AutoSize = True
        Me.RegToolTip_Label1.BackColor = System.Drawing.Color.Transparent
        Me.RegToolTip_Label1.Cursor = System.Windows.Forms.Cursors.Help
        Me.RegToolTip_Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RegToolTip_Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegToolTip_Label1.ForeColor = System.Drawing.Color.Red
        Me.RegToolTip_Label1.Location = New System.Drawing.Point(456, 198)
        Me.RegToolTip_Label1.Name = "RegToolTip_Label1"
        Me.RegToolTip_Label1.Size = New System.Drawing.Size(19, 20)
        Me.RegToolTip_Label1.TabIndex = 29
        Me.RegToolTip_Label1.Text = "?"
        '
        'Birthdate_Picker
        '
        Me.Birthdate_Picker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Birthdate_Picker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Birthdate_Picker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.Birthdate_Picker.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Birthdate_Picker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Birthdate_Picker.Location = New System.Drawing.Point(271, 423)
        Me.Birthdate_Picker.MaximumSize = New System.Drawing.Size(210, 40)
        Me.Birthdate_Picker.Name = "Birthdate_Picker"
        Me.Birthdate_Picker.Size = New System.Drawing.Size(210, 38)
        Me.Birthdate_Picker.TabIndex = 30
        '
        'Birthday_Label
        '
        Me.Birthday_Label.AutoSize = True
        Me.Birthday_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Birthday_Label.Location = New System.Drawing.Point(267, 404)
        Me.Birthday_Label.Name = "Birthday_Label"
        Me.Birthday_Label.Size = New System.Drawing.Size(71, 20)
        Me.Birthday_Label.TabIndex = 31
        Me.Birthday_Label.Text = "Birthday"
        '
        'RegToolTip_Label4
        '
        Me.RegToolTip_Label4.AutoSize = True
        Me.RegToolTip_Label4.BackColor = System.Drawing.Color.Transparent
        Me.RegToolTip_Label4.Cursor = System.Windows.Forms.Cursors.Help
        Me.RegToolTip_Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RegToolTip_Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegToolTip_Label4.ForeColor = System.Drawing.Color.Red
        Me.RegToolTip_Label4.Location = New System.Drawing.Point(456, 132)
        Me.RegToolTip_Label4.Name = "RegToolTip_Label4"
        Me.RegToolTip_Label4.Size = New System.Drawing.Size(19, 20)
        Me.RegToolTip_Label4.TabIndex = 32
        Me.RegToolTip_Label4.Text = "?"
        '
        'Registration_Panel
        '
        Me.Registration_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Registration_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Registration_Panel.Controls.Add(Me.RegToolTip_Label4)
        Me.Registration_Panel.Controls.Add(Me.Birthday_Label)
        Me.Registration_Panel.Controls.Add(Me.Birthdate_Picker)
        Me.Registration_Panel.Controls.Add(Me.RegToolTip_Label1)
        Me.Registration_Panel.Controls.Add(Me.RegToolTip_Label2)
        Me.Registration_Panel.Controls.Add(Me.RegToolTip_Label3)
        Me.Registration_Panel.Controls.Add(Me.Login_Link)
        Me.Registration_Panel.Controls.Add(Me.Registration_Label)
        Me.Registration_Panel.Controls.Add(Me.Register_Btn)
        Me.Registration_Panel.Controls.Add(Me.Password2_Label)
        Me.Registration_Panel.Controls.Add(Me.Password2_Input)
        Me.Registration_Panel.Controls.Add(Me.Password_Label)
        Me.Registration_Panel.Controls.Add(Me.Password_Input)
        Me.Registration_Panel.Controls.Add(Me.Contact_Label)
        Me.Registration_Panel.Controls.Add(Me.Contact_Input)
        Me.Registration_Panel.Controls.Add(Me.Email_Label)
        Me.Registration_Panel.Controls.Add(Me.Email_Input)
        Me.Registration_Panel.Controls.Add(Me.Sex_Label)
        Me.Registration_Panel.Controls.Add(Me.Sex_Panel)
        Me.Registration_Panel.Controls.Add(Me.InstructorID_Label)
        Me.Registration_Panel.Controls.Add(Me.InstructorID_Input)
        Me.Registration_Panel.Controls.Add(Me.LN_Label)
        Me.Registration_Panel.Controls.Add(Me.MN_Label)
        Me.Registration_Panel.Controls.Add(Me.FN_Label)
        Me.Registration_Panel.Controls.Add(Me.LN_Input)
        Me.Registration_Panel.Controls.Add(Me.MN_Input)
        Me.Registration_Panel.Controls.Add(Me.FN_Input)
        Me.Registration_Panel.Location = New System.Drawing.Point(-1, 31)
        Me.Registration_Panel.Name = "Registration_Panel"
        Me.Registration_Panel.Size = New System.Drawing.Size(546, 850)
        Me.Registration_Panel.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-3, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1557, 16)
        Me.Panel1.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(721, 830)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(588, 20)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Copyright © 2024, CDM  Registrar Management System, All Rights Reserved."
        '
        'CDMRMS_Instructor_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1550, 870)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BG_Picture)
        Me.Controls.Add(Me.Login_Panel)
        Me.Controls.Add(Me.Registration_Panel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(1550, 870)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1550, 870)
        Me.MinimizeBox = False
        Me.Name = "CDMRMS_Instructor_Login"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.Style = MetroFramework.MetroColorStyle.White
        Me.Login_Panel.ResumeLayout(False)
        Me.Login_Panel.PerformLayout()
        CType(Me.User_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BG_Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Sex_Panel.ResumeLayout(False)
        Me.Sex_Panel.PerformLayout()
        Me.Registration_Panel.ResumeLayout(False)
        Me.Registration_Panel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Login_Panel As Panel
    Friend WithEvents LoginPassword_Input As MetroFramework.Controls.MetroTextBox
    Friend WithEvents LoginEmail_Input As MetroFramework.Controls.MetroTextBox
    Friend WithEvents LoginInstructorID_Input As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Register_Link As LinkLabel
    Friend WithEvents Login_Label As Label
    Friend WithEvents Login_Btn As Button
    Friend WithEvents LoginPassword_Label As Label
    Friend WithEvents LoginEmail_Label As Label
    Friend WithEvents User_Logo As PictureBox
    Friend WithEvents Tooltip As ToolTip
    Friend WithEvents LoginInstructorID_Label As Label
    Friend WithEvents BG_Picture As PictureBox
    Friend WithEvents FN_Input As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MN_Input As MetroFramework.Controls.MetroTextBox
    Friend WithEvents LN_Input As MetroFramework.Controls.MetroTextBox
    Friend WithEvents FN_Label As Label
    Friend WithEvents MN_Label As Label
    Friend WithEvents LN_Label As Label
    Friend WithEvents InstructorID_Input As MetroFramework.Controls.MetroTextBox
    Friend WithEvents InstructorID_Label As Label
    Friend WithEvents Sex_Panel As Panel
    Friend WithEvents Male_RadioBtn As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents Female_RadioBtn As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents Sex_Label As Label
    Friend WithEvents Email_Input As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Email_Label As Label
    Friend WithEvents Contact_Input As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Contact_Label As Label
    Friend WithEvents Password_Input As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Password_Label As Label
    Friend WithEvents Password2_Input As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Password2_Label As Label
    Friend WithEvents Register_Btn As Button
    Friend WithEvents Registration_Label As Label
    Friend WithEvents Login_Link As LinkLabel
    Friend WithEvents RegToolTip_Label3 As Label
    Friend WithEvents RegToolTip_Label2 As Label
    Friend WithEvents RegToolTip_Label1 As Label
    Friend WithEvents Birthdate_Picker As DateTimePicker
    Friend WithEvents Birthday_Label As Label
    Friend WithEvents RegToolTip_Label4 As Label
    Friend WithEvents Registration_Panel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
