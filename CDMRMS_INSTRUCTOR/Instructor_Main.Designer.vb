<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Instructor_Main
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Instructor_Main))
        Me.StudentGrade_Btn = New System.Windows.Forms.Button()
        Me.MyProfile_Btn = New System.Windows.Forms.Button()
        Me.GreenUpper_Panel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Logout_Btn = New System.Windows.Forms.Button()
        Me.Dropdown_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.MyProfile_Panel = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Birthday_Label = New System.Windows.Forms.Label()
        Me.CN_Label = New System.Windows.Forms.Label()
        Me.Email_ = New System.Windows.Forms.Label()
        Me.Sex_Label = New System.Windows.Forms.Label()
        Me.MN_Label = New System.Windows.Forms.Label()
        Me.FN_Label = New System.Windows.Forms.Label()
        Me.LN_Label = New System.Windows.Forms.Label()
        Me.InstructorID_Label = New System.Windows.Forms.Label()
        Me.InstructorsID_TB = New System.Windows.Forms.TextBox()
        Me.Email_TB = New System.Windows.Forms.TextBox()
        Me.FN_TB = New System.Windows.Forms.TextBox()
        Me.MN_TB = New System.Windows.Forms.TextBox()
        Me.LN_TB = New System.Windows.Forms.TextBox()
        Me.Birthday_TB = New System.Windows.Forms.TextBox()
        Me.CN_TB = New System.Windows.Forms.TextBox()
        Me.Sex_TB = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Profile_Panel = New System.Windows.Forms.Panel()
        Me.ProfilePic_PicBox = New System.Windows.Forms.PictureBox()
        Me.Profile_Label = New System.Windows.Forms.Label()
        Me.Save_Btn = New System.Windows.Forms.Button()
        Me.StudentGrade_Panel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ChangeGradeReq_Btn = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LoginInstructorID_Label = New System.Windows.Forms.Label()
        Me.SectionSelector = New MetroFramework.Controls.MetroComboBox()
        Me.CourseSelector = New MetroFramework.Controls.MetroComboBox()
        Me.Refresh_Btn = New System.Windows.Forms.Button()
        Me.SaveGrade_Btn = New System.Windows.Forms.Button()
        Me.LockIn_Btn = New System.Windows.Forms.Button()
        Me.CollegeProgramSelector = New MetroFramework.Controls.MetroComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.StudentlistTable = New System.Windows.Forms.DataGridView()
        Me.StudentGrade_Label = New System.Windows.Forms.Label()
        Me.AutoRefresher_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Welcome_BG = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GreenUpper_Panel.SuspendLayout()
        Me.MyProfile_Panel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Profile_Panel.SuspendLayout()
        CType(Me.ProfilePic_PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StudentGrade_Panel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.StudentlistTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Welcome_BG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentGrade_Btn
        '
        Me.StudentGrade_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.StudentGrade_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StudentGrade_Btn.FlatAppearance.BorderSize = 0
        Me.StudentGrade_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StudentGrade_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentGrade_Btn.ForeColor = System.Drawing.Color.White
        Me.StudentGrade_Btn.Location = New System.Drawing.Point(1252, 0)
        Me.StudentGrade_Btn.Name = "StudentGrade_Btn"
        Me.StudentGrade_Btn.Size = New System.Drawing.Size(150, 60)
        Me.StudentGrade_Btn.TabIndex = 3
        Me.StudentGrade_Btn.Text = "Grade"
        Me.StudentGrade_Btn.UseVisualStyleBackColor = False
        '
        'MyProfile_Btn
        '
        Me.MyProfile_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.MyProfile_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MyProfile_Btn.FlatAppearance.BorderSize = 0
        Me.MyProfile_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyProfile_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyProfile_Btn.ForeColor = System.Drawing.Color.White
        Me.MyProfile_Btn.Location = New System.Drawing.Point(1101, 0)
        Me.MyProfile_Btn.Name = "MyProfile_Btn"
        Me.MyProfile_Btn.Size = New System.Drawing.Size(150, 60)
        Me.MyProfile_Btn.TabIndex = 2
        Me.MyProfile_Btn.Text = "Account"
        Me.MyProfile_Btn.UseVisualStyleBackColor = False
        '
        'GreenUpper_Panel
        '
        Me.GreenUpper_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.GreenUpper_Panel.Controls.Add(Me.Label3)
        Me.GreenUpper_Panel.Controls.Add(Me.Logout_Btn)
        Me.GreenUpper_Panel.Controls.Add(Me.MyProfile_Btn)
        Me.GreenUpper_Panel.Controls.Add(Me.StudentGrade_Btn)
        Me.GreenUpper_Panel.Location = New System.Drawing.Point(-2, 31)
        Me.GreenUpper_Panel.Name = "GreenUpper_Panel"
        Me.GreenUpper_Panel.Size = New System.Drawing.Size(1553, 60)
        Me.GreenUpper_Panel.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(38, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(249, 57)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "CdMRMS"
        '
        'Logout_Btn
        '
        Me.Logout_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Logout_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Logout_Btn.FlatAppearance.BorderSize = 0
        Me.Logout_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Logout_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout_Btn.ForeColor = System.Drawing.Color.White
        Me.Logout_Btn.Image = Global.CDMRMS_INSTRUCTOR.My.Resources.Resources.Logout_Icon
        Me.Logout_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Logout_Btn.Location = New System.Drawing.Point(1403, 0)
        Me.Logout_Btn.Name = "Logout_Btn"
        Me.Logout_Btn.Padding = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.Logout_Btn.Size = New System.Drawing.Size(150, 60)
        Me.Logout_Btn.TabIndex = 4
        Me.Logout_Btn.Text = "Log Out"
        Me.Logout_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Logout_Btn.UseVisualStyleBackColor = False
        '
        'Dropdown_Timer
        '
        Me.Dropdown_Timer.Interval = 15
        '
        'MyProfile_Panel
        '
        Me.MyProfile_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.MyProfile_Panel.Controls.Add(Me.Panel3)
        Me.MyProfile_Panel.Controls.Add(Me.Panel1)
        Me.MyProfile_Panel.Controls.Add(Me.Profile_Panel)
        Me.MyProfile_Panel.Location = New System.Drawing.Point(218, 91)
        Me.MyProfile_Panel.Name = "MyProfile_Panel"
        Me.MyProfile_Panel.Size = New System.Drawing.Size(1334, 784)
        Me.MyProfile_Panel.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Location = New System.Drawing.Point(442, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(884, 770)
        Me.Panel3.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bernard MT Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 40)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Account Details"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Birthday_Label)
        Me.Panel7.Controls.Add(Me.CN_Label)
        Me.Panel7.Controls.Add(Me.Email_)
        Me.Panel7.Controls.Add(Me.Sex_Label)
        Me.Panel7.Controls.Add(Me.MN_Label)
        Me.Panel7.Controls.Add(Me.FN_Label)
        Me.Panel7.Controls.Add(Me.LN_Label)
        Me.Panel7.Controls.Add(Me.InstructorID_Label)
        Me.Panel7.Controls.Add(Me.InstructorsID_TB)
        Me.Panel7.Controls.Add(Me.Email_TB)
        Me.Panel7.Controls.Add(Me.FN_TB)
        Me.Panel7.Controls.Add(Me.MN_TB)
        Me.Panel7.Controls.Add(Me.LN_TB)
        Me.Panel7.Controls.Add(Me.Birthday_TB)
        Me.Panel7.Controls.Add(Me.CN_TB)
        Me.Panel7.Controls.Add(Me.Sex_TB)
        Me.Panel7.Location = New System.Drawing.Point(63, 87)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(761, 399)
        Me.Panel7.TabIndex = 3
        '
        'Birthday_Label
        '
        Me.Birthday_Label.AutoSize = True
        Me.Birthday_Label.BackColor = System.Drawing.Color.Transparent
        Me.Birthday_Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.Birthday_Label.Font = New System.Drawing.Font("Bernard MT Condensed", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Birthday_Label.Location = New System.Drawing.Point(381, 323)
        Me.Birthday_Label.Name = "Birthday_Label"
        Me.Birthday_Label.Size = New System.Drawing.Size(64, 20)
        Me.Birthday_Label.TabIndex = 85
        Me.Birthday_Label.Text = "Birthday"
        '
        'CN_Label
        '
        Me.CN_Label.AutoSize = True
        Me.CN_Label.BackColor = System.Drawing.Color.Transparent
        Me.CN_Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.CN_Label.Font = New System.Drawing.Font("Bernard MT Condensed", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CN_Label.Location = New System.Drawing.Point(18, 323)
        Me.CN_Label.Name = "CN_Label"
        Me.CN_Label.Size = New System.Drawing.Size(111, 20)
        Me.CN_Label.TabIndex = 82
        Me.CN_Label.Text = "Contact Number"
        '
        'Email_
        '
        Me.Email_.AutoSize = True
        Me.Email_.BackColor = System.Drawing.Color.Transparent
        Me.Email_.Cursor = System.Windows.Forms.Cursors.Default
        Me.Email_.Font = New System.Drawing.Font("Bernard MT Condensed", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_.Location = New System.Drawing.Point(17, 244)
        Me.Email_.Name = "Email_"
        Me.Email_.Size = New System.Drawing.Size(98, 20)
        Me.Email_.TabIndex = 78
        Me.Email_.Text = "Email Address"
        '
        'Sex_Label
        '
        Me.Sex_Label.AutoSize = True
        Me.Sex_Label.BackColor = System.Drawing.Color.Transparent
        Me.Sex_Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.Sex_Label.Font = New System.Drawing.Font("Bernard MT Condensed", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sex_Label.Location = New System.Drawing.Point(381, 166)
        Me.Sex_Label.Name = "Sex_Label"
        Me.Sex_Label.Size = New System.Drawing.Size(30, 20)
        Me.Sex_Label.TabIndex = 75
        Me.Sex_Label.Text = "Sex"
        '
        'MN_Label
        '
        Me.MN_Label.AutoSize = True
        Me.MN_Label.BackColor = System.Drawing.Color.Transparent
        Me.MN_Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.MN_Label.Font = New System.Drawing.Font("Bernard MT Condensed", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MN_Label.Location = New System.Drawing.Point(18, 166)
        Me.MN_Label.Name = "MN_Label"
        Me.MN_Label.Size = New System.Drawing.Size(91, 20)
        Me.MN_Label.TabIndex = 71
        Me.MN_Label.Text = "Middle Name"
        '
        'FN_Label
        '
        Me.FN_Label.AutoSize = True
        Me.FN_Label.BackColor = System.Drawing.Color.Transparent
        Me.FN_Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.FN_Label.Font = New System.Drawing.Font("Bernard MT Condensed", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FN_Label.Location = New System.Drawing.Point(18, 89)
        Me.FN_Label.Name = "FN_Label"
        Me.FN_Label.Size = New System.Drawing.Size(77, 20)
        Me.FN_Label.TabIndex = 70
        Me.FN_Label.Text = "First Name"
        '
        'LN_Label
        '
        Me.LN_Label.AutoSize = True
        Me.LN_Label.BackColor = System.Drawing.Color.Transparent
        Me.LN_Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.LN_Label.Font = New System.Drawing.Font("Bernard MT Condensed", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LN_Label.Location = New System.Drawing.Point(381, 89)
        Me.LN_Label.Name = "LN_Label"
        Me.LN_Label.Size = New System.Drawing.Size(75, 20)
        Me.LN_Label.TabIndex = 72
        Me.LN_Label.Text = "Last Name"
        '
        'InstructorID_Label
        '
        Me.InstructorID_Label.AutoSize = True
        Me.InstructorID_Label.BackColor = System.Drawing.Color.Transparent
        Me.InstructorID_Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.InstructorID_Label.Font = New System.Drawing.Font("Bernard MT Condensed", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructorID_Label.Location = New System.Drawing.Point(18, 10)
        Me.InstructorID_Label.Name = "InstructorID_Label"
        Me.InstructorID_Label.Size = New System.Drawing.Size(91, 20)
        Me.InstructorID_Label.TabIndex = 73
        Me.InstructorID_Label.Text = "Instructor ID"
        '
        'InstructorsID_TB
        '
        Me.InstructorsID_TB.BackColor = System.Drawing.Color.White
        Me.InstructorsID_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InstructorsID_TB.Enabled = False
        Me.InstructorsID_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructorsID_TB.ForeColor = System.Drawing.Color.Black
        Me.InstructorsID_TB.Location = New System.Drawing.Point(21, 29)
        Me.InstructorsID_TB.Name = "InstructorsID_TB"
        Me.InstructorsID_TB.ReadOnly = True
        Me.InstructorsID_TB.Size = New System.Drawing.Size(722, 38)
        Me.InstructorsID_TB.TabIndex = 74
        Me.InstructorsID_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Email_TB
        '
        Me.Email_TB.BackColor = System.Drawing.Color.White
        Me.Email_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Email_TB.Enabled = False
        Me.Email_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_TB.ForeColor = System.Drawing.Color.Black
        Me.Email_TB.Location = New System.Drawing.Point(21, 263)
        Me.Email_TB.Name = "Email_TB"
        Me.Email_TB.ReadOnly = True
        Me.Email_TB.Size = New System.Drawing.Size(721, 38)
        Me.Email_TB.TabIndex = 84
        Me.Email_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FN_TB
        '
        Me.FN_TB.BackColor = System.Drawing.Color.White
        Me.FN_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FN_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FN_TB.ForeColor = System.Drawing.Color.Black
        Me.FN_TB.Location = New System.Drawing.Point(22, 108)
        Me.FN_TB.Name = "FN_TB"
        Me.FN_TB.Size = New System.Drawing.Size(358, 38)
        Me.FN_TB.TabIndex = 76
        Me.FN_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MN_TB
        '
        Me.MN_TB.BackColor = System.Drawing.Color.White
        Me.MN_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MN_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MN_TB.ForeColor = System.Drawing.Color.Black
        Me.MN_TB.Location = New System.Drawing.Point(22, 185)
        Me.MN_TB.Name = "MN_TB"
        Me.MN_TB.Size = New System.Drawing.Size(358, 38)
        Me.MN_TB.TabIndex = 77
        Me.MN_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LN_TB
        '
        Me.LN_TB.BackColor = System.Drawing.Color.White
        Me.LN_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LN_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LN_TB.ForeColor = System.Drawing.Color.Black
        Me.LN_TB.Location = New System.Drawing.Point(385, 108)
        Me.LN_TB.Name = "LN_TB"
        Me.LN_TB.Size = New System.Drawing.Size(358, 38)
        Me.LN_TB.TabIndex = 79
        Me.LN_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Birthday_TB
        '
        Me.Birthday_TB.BackColor = System.Drawing.Color.White
        Me.Birthday_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Birthday_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Birthday_TB.ForeColor = System.Drawing.Color.Black
        Me.Birthday_TB.Location = New System.Drawing.Point(385, 342)
        Me.Birthday_TB.Name = "Birthday_TB"
        Me.Birthday_TB.Size = New System.Drawing.Size(358, 38)
        Me.Birthday_TB.TabIndex = 83
        Me.Birthday_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CN_TB
        '
        Me.CN_TB.BackColor = System.Drawing.Color.White
        Me.CN_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CN_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CN_TB.ForeColor = System.Drawing.Color.Black
        Me.CN_TB.Location = New System.Drawing.Point(21, 342)
        Me.CN_TB.Name = "CN_TB"
        Me.CN_TB.Size = New System.Drawing.Size(358, 38)
        Me.CN_TB.TabIndex = 81
        Me.CN_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Sex_TB
        '
        Me.Sex_TB.BackColor = System.Drawing.Color.White
        Me.Sex_TB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Sex_TB.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sex_TB.ForeColor = System.Drawing.Color.Black
        Me.Sex_TB.Location = New System.Drawing.Point(385, 185)
        Me.Sex_TB.Name = "Sex_TB"
        Me.Sex_TB.Size = New System.Drawing.Size(358, 38)
        Me.Sex_TB.TabIndex = 80
        Me.Sex_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(4, 702)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(432, 73)
        Me.Panel1.TabIndex = 2
        '
        'Profile_Panel
        '
        Me.Profile_Panel.BackColor = System.Drawing.SystemColors.Window
        Me.Profile_Panel.Controls.Add(Me.ProfilePic_PicBox)
        Me.Profile_Panel.Controls.Add(Me.Profile_Label)
        Me.Profile_Panel.Controls.Add(Me.Save_Btn)
        Me.Profile_Panel.Location = New System.Drawing.Point(4, 5)
        Me.Profile_Panel.Name = "Profile_Panel"
        Me.Profile_Panel.Size = New System.Drawing.Size(432, 691)
        Me.Profile_Panel.TabIndex = 0
        '
        'ProfilePic_PicBox
        '
        Me.ProfilePic_PicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ProfilePic_PicBox.Location = New System.Drawing.Point(61, 87)
        Me.ProfilePic_PicBox.Name = "ProfilePic_PicBox"
        Me.ProfilePic_PicBox.Size = New System.Drawing.Size(304, 269)
        Me.ProfilePic_PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ProfilePic_PicBox.TabIndex = 1
        Me.ProfilePic_PicBox.TabStop = False
        '
        'Profile_Label
        '
        Me.Profile_Label.AutoSize = True
        Me.Profile_Label.Font = New System.Drawing.Font("Bernard MT Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Profile_Label.Location = New System.Drawing.Point(36, 9)
        Me.Profile_Label.Name = "Profile_Label"
        Me.Profile_Label.Size = New System.Drawing.Size(102, 40)
        Me.Profile_Label.TabIndex = 0
        Me.Profile_Label.Text = "Profile"
        '
        'Save_Btn
        '
        Me.Save_Btn.BackColor = System.Drawing.Color.Yellow
        Me.Save_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Save_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Save_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Save_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Save_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save_Btn.ForeColor = System.Drawing.Color.Black
        Me.Save_Btn.Location = New System.Drawing.Point(117, 408)
        Me.Save_Btn.Name = "Save_Btn"
        Me.Save_Btn.Size = New System.Drawing.Size(190, 40)
        Me.Save_Btn.TabIndex = 69
        Me.Save_Btn.Text = "Save"
        Me.Save_Btn.UseVisualStyleBackColor = False
        '
        'StudentGrade_Panel
        '
        Me.StudentGrade_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.StudentGrade_Panel.Controls.Add(Me.Panel2)
        Me.StudentGrade_Panel.Controls.Add(Me.Panel4)
        Me.StudentGrade_Panel.Controls.Add(Me.Panel5)
        Me.StudentGrade_Panel.Location = New System.Drawing.Point(-1, 91)
        Me.StudentGrade_Panel.Name = "StudentGrade_Panel"
        Me.StudentGrade_Panel.Size = New System.Drawing.Size(1553, 784)
        Me.StudentGrade_Panel.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Panel9)
        Me.Panel2.Controls.Add(Me.ChangeGradeReq_Btn)
        Me.Panel2.Location = New System.Drawing.Point(1001, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(545, 312)
        Me.Panel2.TabIndex = 86
        '
        'ChangeGradeReq_Btn
        '
        Me.ChangeGradeReq_Btn.BackColor = System.Drawing.Color.Yellow
        Me.ChangeGradeReq_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChangeGradeReq_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.ChangeGradeReq_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ChangeGradeReq_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ChangeGradeReq_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChangeGradeReq_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeGradeReq_Btn.ForeColor = System.Drawing.Color.Black
        Me.ChangeGradeReq_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChangeGradeReq_Btn.Location = New System.Drawing.Point(356, 214)
        Me.ChangeGradeReq_Btn.Name = "ChangeGradeReq_Btn"
        Me.ChangeGradeReq_Btn.Size = New System.Drawing.Size(137, 43)
        Me.ChangeGradeReq_Btn.TabIndex = 61
        Me.ChangeGradeReq_Btn.Text = "Request"
        Me.ChangeGradeReq_Btn.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Panel8)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.LoginInstructorID_Label)
        Me.Panel4.Controls.Add(Me.SectionSelector)
        Me.Panel4.Controls.Add(Me.CourseSelector)
        Me.Panel4.Controls.Add(Me.Refresh_Btn)
        Me.Panel4.Controls.Add(Me.SaveGrade_Btn)
        Me.Panel4.Controls.Add(Me.LockIn_Btn)
        Me.Panel4.Controls.Add(Me.CollegeProgramSelector)
        Me.Panel4.Location = New System.Drawing.Point(1001, 321)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(545, 454)
        Me.Panel4.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(50, 67)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(443, 126)
        Me.Panel8.TabIndex = 86
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 20)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Sections"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Courses"
        '
        'LoginInstructorID_Label
        '
        Me.LoginInstructorID_Label.AutoSize = True
        Me.LoginInstructorID_Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.LoginInstructorID_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginInstructorID_Label.Location = New System.Drawing.Point(46, 208)
        Me.LoginInstructorID_Label.Name = "LoginInstructorID_Label"
        Me.LoginInstructorID_Label.Size = New System.Drawing.Size(134, 20)
        Me.LoginInstructorID_Label.TabIndex = 83
        Me.LoginInstructorID_Label.Text = "College Program"
        '
        'SectionSelector
        '
        Me.SectionSelector.BackColor = System.Drawing.Color.White
        Me.SectionSelector.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SectionSelector.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.SectionSelector.FontWeight = MetroFramework.MetroComboBoxWeight.Bold
        Me.SectionSelector.ForeColor = System.Drawing.Color.Black
        Me.SectionSelector.FormattingEnabled = True
        Me.SectionSelector.ItemHeight = 29
        Me.SectionSelector.Location = New System.Drawing.Point(50, 363)
        Me.SectionSelector.Name = "SectionSelector"
        Me.SectionSelector.Size = New System.Drawing.Size(279, 35)
        Me.SectionSelector.TabIndex = 82
        Me.SectionSelector.UseCustomForeColor = True
        Me.SectionSelector.UseSelectable = True
        '
        'CourseSelector
        '
        Me.CourseSelector.BackColor = System.Drawing.Color.White
        Me.CourseSelector.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CourseSelector.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.CourseSelector.FontWeight = MetroFramework.MetroComboBoxWeight.Bold
        Me.CourseSelector.ForeColor = System.Drawing.Color.Black
        Me.CourseSelector.FormattingEnabled = True
        Me.CourseSelector.ItemHeight = 29
        Me.CourseSelector.Location = New System.Drawing.Point(50, 294)
        Me.CourseSelector.Name = "CourseSelector"
        Me.CourseSelector.Size = New System.Drawing.Size(279, 35)
        Me.CourseSelector.TabIndex = 81
        Me.CourseSelector.UseCustomForeColor = True
        Me.CourseSelector.UseSelectable = True
        '
        'Refresh_Btn
        '
        Me.Refresh_Btn.BackColor = System.Drawing.Color.Yellow
        Me.Refresh_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Refresh_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Refresh_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Refresh_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Refresh_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Refresh_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Refresh_Btn.ForeColor = System.Drawing.Color.Black
        Me.Refresh_Btn.Location = New System.Drawing.Point(356, 294)
        Me.Refresh_Btn.Name = "Refresh_Btn"
        Me.Refresh_Btn.Size = New System.Drawing.Size(137, 43)
        Me.Refresh_Btn.TabIndex = 75
        Me.Refresh_Btn.Text = "Refresh"
        Me.Refresh_Btn.UseVisualStyleBackColor = False
        '
        'SaveGrade_Btn
        '
        Me.SaveGrade_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.SaveGrade_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveGrade_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.SaveGrade_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.SaveGrade_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SaveGrade_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveGrade_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveGrade_Btn.ForeColor = System.Drawing.Color.Black
        Me.SaveGrade_Btn.Location = New System.Drawing.Point(356, 363)
        Me.SaveGrade_Btn.Name = "SaveGrade_Btn"
        Me.SaveGrade_Btn.Size = New System.Drawing.Size(137, 43)
        Me.SaveGrade_Btn.TabIndex = 80
        Me.SaveGrade_Btn.Text = "Save"
        Me.SaveGrade_Btn.UseVisualStyleBackColor = False
        '
        'LockIn_Btn
        '
        Me.LockIn_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.LockIn_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LockIn_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.LockIn_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LockIn_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.LockIn_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LockIn_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LockIn_Btn.ForeColor = System.Drawing.Color.White
        Me.LockIn_Btn.Location = New System.Drawing.Point(356, 227)
        Me.LockIn_Btn.Name = "LockIn_Btn"
        Me.LockIn_Btn.Size = New System.Drawing.Size(137, 43)
        Me.LockIn_Btn.TabIndex = 64
        Me.LockIn_Btn.Text = "Lock In"
        Me.LockIn_Btn.UseVisualStyleBackColor = False
        '
        'CollegeProgramSelector
        '
        Me.CollegeProgramSelector.BackColor = System.Drawing.Color.White
        Me.CollegeProgramSelector.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CollegeProgramSelector.FontSize = MetroFramework.MetroComboBoxSize.Tall
        Me.CollegeProgramSelector.FontWeight = MetroFramework.MetroComboBoxWeight.Bold
        Me.CollegeProgramSelector.ForeColor = System.Drawing.Color.Black
        Me.CollegeProgramSelector.FormattingEnabled = True
        Me.CollegeProgramSelector.ItemHeight = 29
        Me.CollegeProgramSelector.Location = New System.Drawing.Point(50, 227)
        Me.CollegeProgramSelector.Name = "CollegeProgramSelector"
        Me.CollegeProgramSelector.Size = New System.Drawing.Size(279, 35)
        Me.CollegeProgramSelector.TabIndex = 66
        Me.CollegeProgramSelector.UseCustomForeColor = True
        Me.CollegeProgramSelector.UseSelectable = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Window
        Me.Panel5.Controls.Add(Me.StudentlistTable)
        Me.Panel5.Controls.Add(Me.StudentGrade_Label)
        Me.Panel5.Location = New System.Drawing.Point(5, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(992, 770)
        Me.Panel5.TabIndex = 0
        '
        'StudentlistTable
        '
        Me.StudentlistTable.AllowUserToAddRows = False
        Me.StudentlistTable.AllowUserToResizeColumns = False
        Me.StudentlistTable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.StudentlistTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.StudentlistTable.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.StudentlistTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StudentlistTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(16, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(16, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.StudentlistTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.StudentlistTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentlistTable.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(248, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentlistTable.DefaultCellStyle = DataGridViewCellStyle3
        Me.StudentlistTable.EnableHeadersVisualStyles = False
        Me.StudentlistTable.GridColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.StudentlistTable.Location = New System.Drawing.Point(44, 58)
        Me.StudentlistTable.MultiSelect = False
        Me.StudentlistTable.Name = "StudentlistTable"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentlistTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.StudentlistTable.RowHeadersVisible = False
        Me.StudentlistTable.RowHeadersWidth = 51
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentlistTable.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.StudentlistTable.RowTemplate.Height = 24
        Me.StudentlistTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.StudentlistTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.StudentlistTable.Size = New System.Drawing.Size(899, 667)
        Me.StudentlistTable.TabIndex = 65
        '
        'StudentGrade_Label
        '
        Me.StudentGrade_Label.AutoSize = True
        Me.StudentGrade_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentGrade_Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.StudentGrade_Label.Location = New System.Drawing.Point(333, 13)
        Me.StudentGrade_Label.Name = "StudentGrade_Label"
        Me.StudentGrade_Label.Size = New System.Drawing.Size(285, 38)
        Me.StudentGrade_Label.TabIndex = 0
        Me.StudentGrade_Label.Text = "STUDENTS LIST"
        '
        'AutoRefresher_Timer
        '
        '
        'Welcome_BG
        '
        Me.Welcome_BG.Image = Global.CDMRMS_INSTRUCTOR.My.Resources.Resources.Welcome_Background_New
        Me.Welcome_BG.Location = New System.Drawing.Point(161, 137)
        Me.Welcome_BG.Name = "Welcome_BG"
        Me.Welcome_BG.Size = New System.Drawing.Size(1225, 742)
        Me.Welcome_BG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Welcome_BG.TabIndex = 4
        Me.Welcome_BG.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(-1, 31)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(31, 60)
        Me.Panel6.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(142, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 29)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Students List Controls"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(50, 58)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(443, 126)
        Me.Panel9.TabIndex = 87
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(150, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(248, 29)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Request Permission"
        '
        'Instructor_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1550, 870)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.StudentGrade_Panel)
        Me.Controls.Add(Me.MyProfile_Panel)
        Me.Controls.Add(Me.GreenUpper_Panel)
        Me.Controls.Add(Me.Welcome_BG)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1550, 870)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1550, 870)
        Me.Name = "Instructor_Main"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.Style = MetroFramework.MetroColorStyle.White
        Me.GreenUpper_Panel.ResumeLayout(False)
        Me.GreenUpper_Panel.PerformLayout()
        Me.MyProfile_Panel.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Profile_Panel.ResumeLayout(False)
        Me.Profile_Panel.PerformLayout()
        CType(Me.ProfilePic_PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudentGrade_Panel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.StudentlistTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Welcome_BG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GreenUpper_Panel As Panel
    Friend WithEvents StudentGrade_Btn As Button
    Friend WithEvents Logout_Btn As Button
    Friend WithEvents Dropdown_Timer As Timer
    Friend WithEvents MyProfile_Btn As Button
    Friend WithEvents MyProfile_Panel As Panel
    Friend WithEvents Profile_Panel As Panel
    Friend WithEvents Profile_Label As Label
    Friend WithEvents ProfilePic_PicBox As PictureBox
    Friend WithEvents Welcome_BG As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents StudentGrade_Panel As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents StudentGrade_Label As Label
    Friend WithEvents ChangeGradeReq_Btn As Button
    Friend WithEvents LockIn_Btn As Button
    Friend WithEvents StudentlistTable As DataGridView
    Friend WithEvents CollegeProgramSelector As MetroFramework.Controls.MetroComboBox
    Friend WithEvents AutoRefresher_Timer As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Save_Btn As Button
    Friend WithEvents InstructorsID_TB As TextBox
    Friend WithEvents Email_TB As TextBox
    Friend WithEvents FN_Label As Label
    Friend WithEvents FN_TB As TextBox
    Friend WithEvents MN_TB As TextBox
    Friend WithEvents LN_Label As Label
    Friend WithEvents MN_Label As Label
    Friend WithEvents LN_TB As TextBox
    Friend WithEvents Birthday_Label As Label
    Friend WithEvents Birthday_TB As TextBox
    Friend WithEvents CN_TB As TextBox
    Friend WithEvents CN_Label As Label
    Friend WithEvents Sex_TB As TextBox
    Friend WithEvents Sex_Label As Label
    Friend WithEvents Email_ As Label
    Friend WithEvents InstructorID_Label As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents SaveGrade_Btn As Button
    Friend WithEvents Refresh_Btn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents CourseSelector As MetroFramework.Controls.MetroComboBox
    Friend WithEvents SectionSelector As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents LoginInstructorID_Label As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label6 As Label
End Class
