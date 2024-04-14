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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Instructor_Main))
        Me.GreenSide_Panel = New System.Windows.Forms.Panel()
        Me.Dropdown_Panel = New System.Windows.Forms.Panel()
        Me.Logout_Btn = New System.Windows.Forms.Button()
        Me.StudentGrade_Btn = New System.Windows.Forms.Button()
        Me.MyProfile_Btn = New System.Windows.Forms.Button()
        Me.Menu_Btn = New System.Windows.Forms.Button()
        Me.CMDRMS_PicBox = New System.Windows.Forms.PictureBox()
        Me.CDM_Logo = New System.Windows.Forms.PictureBox()
        Me.GreenUpper_Panel = New System.Windows.Forms.Panel()
        Me.Dropdown_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.MyProfile_Panel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CourseReq_Panel = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Institute = New System.Windows.Forms.Label()
        Me.Course_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Sem_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Year_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Program_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Institute_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Send_Btn = New System.Windows.Forms.Button()
        Me.Choose_Btn = New System.Windows.Forms.Button()
        Me.CourseReq_Label = New System.Windows.Forms.Label()
        Me.Profile_Panel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LN_Label = New System.Windows.Forms.Label()
        Me.Save_Btn = New System.Windows.Forms.Button()
        Me.Birthday_Label = New System.Windows.Forms.Label()
        Me.Birthday_TB = New MetroFramework.Controls.MetroTextBox()
        Me.CN_Label = New System.Windows.Forms.Label()
        Me.Email_ = New System.Windows.Forms.Label()
        Me.Sex_Label = New System.Windows.Forms.Label()
        Me.Sex_TB = New MetroFramework.Controls.MetroTextBox()
        Me.InstructorID_Label = New System.Windows.Forms.Label()
        Me.LN_TB = New MetroFramework.Controls.MetroTextBox()
        Me.MN_Label = New System.Windows.Forms.Label()
        Me.FN_Label = New System.Windows.Forms.Label()
        Me.MN_TB = New MetroFramework.Controls.MetroTextBox()
        Me.FN_TB = New MetroFramework.Controls.MetroTextBox()
        Me.InstructorsID_TB = New MetroFramework.Controls.MetroTextBox()
        Me.ProfilePic_PicBox = New System.Windows.Forms.PictureBox()
        Me.Profile_Label = New System.Windows.Forms.Label()
        Me.CN_TB = New MetroFramework.Controls.MetroTextBox()
        Me.Email_TB = New MetroFramework.Controls.MetroTextBox()
        Me.Welcome_BG = New System.Windows.Forms.PictureBox()
        Me.GreenSide_Panel.SuspendLayout()
        Me.Dropdown_Panel.SuspendLayout()
        CType(Me.CMDRMS_PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CDM_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MyProfile_Panel.SuspendLayout()
        Me.CourseReq_Panel.SuspendLayout()
        Me.Profile_Panel.SuspendLayout()
        CType(Me.ProfilePic_PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Welcome_BG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GreenSide_Panel
        '
        Me.GreenSide_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.GreenSide_Panel.Controls.Add(Me.Dropdown_Panel)
        Me.GreenSide_Panel.Controls.Add(Me.CMDRMS_PicBox)
        Me.GreenSide_Panel.Controls.Add(Me.CDM_Logo)
        Me.GreenSide_Panel.Location = New System.Drawing.Point(-1, 31)
        Me.GreenSide_Panel.Name = "GreenSide_Panel"
        Me.GreenSide_Panel.Size = New System.Drawing.Size(220, 842)
        Me.GreenSide_Panel.TabIndex = 0
        '
        'Dropdown_Panel
        '
        Me.Dropdown_Panel.BackColor = System.Drawing.Color.White
        Me.Dropdown_Panel.Controls.Add(Me.Logout_Btn)
        Me.Dropdown_Panel.Controls.Add(Me.StudentGrade_Btn)
        Me.Dropdown_Panel.Controls.Add(Me.MyProfile_Btn)
        Me.Dropdown_Panel.Controls.Add(Me.Menu_Btn)
        Me.Dropdown_Panel.Location = New System.Drawing.Point(2, 1)
        Me.Dropdown_Panel.MaximumSize = New System.Drawing.Size(216, 208)
        Me.Dropdown_Panel.MinimumSize = New System.Drawing.Size(216, 58)
        Me.Dropdown_Panel.Name = "Dropdown_Panel"
        Me.Dropdown_Panel.Size = New System.Drawing.Size(216, 208)
        Me.Dropdown_Panel.TabIndex = 1
        '
        'Logout_Btn
        '
        Me.Logout_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Logout_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Logout_Btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.Logout_Btn.FlatAppearance.BorderSize = 0
        Me.Logout_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Logout_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout_Btn.Location = New System.Drawing.Point(0, 158)
        Me.Logout_Btn.Name = "Logout_Btn"
        Me.Logout_Btn.Size = New System.Drawing.Size(216, 50)
        Me.Logout_Btn.TabIndex = 4
        Me.Logout_Btn.Text = "Log Out"
        Me.Logout_Btn.UseVisualStyleBackColor = False
        '
        'StudentGrade_Btn
        '
        Me.StudentGrade_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.StudentGrade_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StudentGrade_Btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.StudentGrade_Btn.FlatAppearance.BorderSize = 0
        Me.StudentGrade_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StudentGrade_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentGrade_Btn.Location = New System.Drawing.Point(0, 108)
        Me.StudentGrade_Btn.Name = "StudentGrade_Btn"
        Me.StudentGrade_Btn.Size = New System.Drawing.Size(216, 50)
        Me.StudentGrade_Btn.TabIndex = 3
        Me.StudentGrade_Btn.Text = "Student Grade"
        Me.StudentGrade_Btn.UseVisualStyleBackColor = False
        '
        'MyProfile_Btn
        '
        Me.MyProfile_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.MyProfile_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MyProfile_Btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.MyProfile_Btn.FlatAppearance.BorderSize = 0
        Me.MyProfile_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyProfile_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyProfile_Btn.Location = New System.Drawing.Point(0, 58)
        Me.MyProfile_Btn.Name = "MyProfile_Btn"
        Me.MyProfile_Btn.Size = New System.Drawing.Size(216, 50)
        Me.MyProfile_Btn.TabIndex = 2
        Me.MyProfile_Btn.Text = "My Account"
        Me.MyProfile_Btn.UseVisualStyleBackColor = False
        '
        'Menu_Btn
        '
        Me.Menu_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Menu_Btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.Menu_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Menu_Btn.FlatAppearance.BorderSize = 0
        Me.Menu_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Menu_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Menu_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Menu_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_Btn.Location = New System.Drawing.Point(0, 0)
        Me.Menu_Btn.Name = "Menu_Btn"
        Me.Menu_Btn.Size = New System.Drawing.Size(216, 58)
        Me.Menu_Btn.TabIndex = 1
        Me.Menu_Btn.Text = "MENU"
        Me.Menu_Btn.UseVisualStyleBackColor = True
        '
        'CMDRMS_PicBox
        '
        Me.CMDRMS_PicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CMDRMS_PicBox.Image = CType(resources.GetObject("CMDRMS_PicBox.Image"), System.Drawing.Image)
        Me.CMDRMS_PicBox.Location = New System.Drawing.Point(23, 686)
        Me.CMDRMS_PicBox.Name = "CMDRMS_PicBox"
        Me.CMDRMS_PicBox.Size = New System.Drawing.Size(164, 125)
        Me.CMDRMS_PicBox.TabIndex = 52
        Me.CMDRMS_PicBox.TabStop = False
        '
        'CDM_Logo
        '
        Me.CDM_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CDM_Logo.Image = CType(resources.GetObject("CDM_Logo.Image"), System.Drawing.Image)
        Me.CDM_Logo.Location = New System.Drawing.Point(16, 198)
        Me.CDM_Logo.Name = "CDM_Logo"
        Me.CDM_Logo.Size = New System.Drawing.Size(175, 500)
        Me.CDM_Logo.TabIndex = 3
        Me.CDM_Logo.TabStop = False
        '
        'GreenUpper_Panel
        '
        Me.GreenUpper_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.GreenUpper_Panel.Location = New System.Drawing.Point(217, 31)
        Me.GreenUpper_Panel.Name = "GreenUpper_Panel"
        Me.GreenUpper_Panel.Size = New System.Drawing.Size(1334, 60)
        Me.GreenUpper_Panel.TabIndex = 2
        '
        'Dropdown_Timer
        '
        Me.Dropdown_Timer.Interval = 15
        '
        'MyProfile_Panel
        '
        Me.MyProfile_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.MyProfile_Panel.Controls.Add(Me.Panel1)
        Me.MyProfile_Panel.Controls.Add(Me.CourseReq_Panel)
        Me.MyProfile_Panel.Controls.Add(Me.Profile_Panel)
        Me.MyProfile_Panel.Location = New System.Drawing.Point(218, 91)
        Me.MyProfile_Panel.Name = "MyProfile_Panel"
        Me.MyProfile_Panel.Size = New System.Drawing.Size(1334, 784)
        Me.MyProfile_Panel.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(4, 518)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1322, 233)
        Me.Panel1.TabIndex = 2
        '
        'CourseReq_Panel
        '
        Me.CourseReq_Panel.BackColor = System.Drawing.Color.White
        Me.CourseReq_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CourseReq_Panel.Controls.Add(Me.Label4)
        Me.CourseReq_Panel.Controls.Add(Me.Label3)
        Me.CourseReq_Panel.Controls.Add(Me.Label2)
        Me.CourseReq_Panel.Controls.Add(Me.Label1)
        Me.CourseReq_Panel.Controls.Add(Me.Institute)
        Me.CourseReq_Panel.Controls.Add(Me.Course_Tbox)
        Me.CourseReq_Panel.Controls.Add(Me.Sem_Tbox)
        Me.CourseReq_Panel.Controls.Add(Me.Year_Tbox)
        Me.CourseReq_Panel.Controls.Add(Me.Program_Tbox)
        Me.CourseReq_Panel.Controls.Add(Me.Institute_Tbox)
        Me.CourseReq_Panel.Controls.Add(Me.Send_Btn)
        Me.CourseReq_Panel.Controls.Add(Me.Choose_Btn)
        Me.CourseReq_Panel.Controls.Add(Me.CourseReq_Label)
        Me.CourseReq_Panel.Location = New System.Drawing.Point(912, 5)
        Me.CourseReq_Panel.Name = "CourseReq_Panel"
        Me.CourseReq_Panel.Size = New System.Drawing.Size(414, 509)
        Me.CourseReq_Panel.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 355)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Course"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Semester"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Year Level"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 20)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "College Program"
        '
        'Institute
        '
        Me.Institute.AutoSize = True
        Me.Institute.Cursor = System.Windows.Forms.Cursors.Default
        Me.Institute.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Institute.Location = New System.Drawing.Point(20, 64)
        Me.Institute.Name = "Institute"
        Me.Institute.Size = New System.Drawing.Size(68, 20)
        Me.Institute.TabIndex = 52
        Me.Institute.Text = "Institute"
        '
        'Course_Tbox
        '
        '
        '
        '
        Me.Course_Tbox.CustomButton.Image = Nothing
        Me.Course_Tbox.CustomButton.Location = New System.Drawing.Point(323, 2)
        Me.Course_Tbox.CustomButton.Name = ""
        Me.Course_Tbox.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.Course_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Course_Tbox.CustomButton.TabIndex = 1
        Me.Course_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Course_Tbox.CustomButton.UseSelectable = True
        Me.Course_Tbox.CustomButton.Visible = False
        Me.Course_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Course_Tbox.Lines = New String(-1) {}
        Me.Course_Tbox.Location = New System.Drawing.Point(24, 374)
        Me.Course_Tbox.MaxLength = 50
        Me.Course_Tbox.Name = "Course_Tbox"
        Me.Course_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Course_Tbox.ReadOnly = True
        Me.Course_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Course_Tbox.SelectedText = ""
        Me.Course_Tbox.SelectionLength = 0
        Me.Course_Tbox.SelectionStart = 0
        Me.Course_Tbox.ShortcutsEnabled = True
        Me.Course_Tbox.Size = New System.Drawing.Size(361, 40)
        Me.Course_Tbox.Style = MetroFramework.MetroColorStyle.Green
        Me.Course_Tbox.TabIndex = 57
        Me.Course_Tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Course_Tbox.UseSelectable = True
        Me.Course_Tbox.WaterMarkColor = System.Drawing.Color.Silver
        Me.Course_Tbox.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Sem_Tbox
        '
        '
        '
        '
        Me.Sem_Tbox.CustomButton.Image = Nothing
        Me.Sem_Tbox.CustomButton.Location = New System.Drawing.Point(323, 2)
        Me.Sem_Tbox.CustomButton.Name = ""
        Me.Sem_Tbox.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.Sem_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Sem_Tbox.CustomButton.TabIndex = 1
        Me.Sem_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Sem_Tbox.CustomButton.UseSelectable = True
        Me.Sem_Tbox.CustomButton.Visible = False
        Me.Sem_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Sem_Tbox.Lines = New String(-1) {}
        Me.Sem_Tbox.Location = New System.Drawing.Point(24, 301)
        Me.Sem_Tbox.MaxLength = 50
        Me.Sem_Tbox.Name = "Sem_Tbox"
        Me.Sem_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Sem_Tbox.ReadOnly = True
        Me.Sem_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Sem_Tbox.SelectedText = ""
        Me.Sem_Tbox.SelectionLength = 0
        Me.Sem_Tbox.SelectionStart = 0
        Me.Sem_Tbox.ShortcutsEnabled = True
        Me.Sem_Tbox.Size = New System.Drawing.Size(361, 40)
        Me.Sem_Tbox.Style = MetroFramework.MetroColorStyle.Green
        Me.Sem_Tbox.TabIndex = 56
        Me.Sem_Tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Sem_Tbox.UseSelectable = True
        Me.Sem_Tbox.WaterMarkColor = System.Drawing.Color.Silver
        Me.Sem_Tbox.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Year_Tbox
        '
        '
        '
        '
        Me.Year_Tbox.CustomButton.Image = Nothing
        Me.Year_Tbox.CustomButton.Location = New System.Drawing.Point(323, 2)
        Me.Year_Tbox.CustomButton.Name = ""
        Me.Year_Tbox.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.Year_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Year_Tbox.CustomButton.TabIndex = 1
        Me.Year_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Year_Tbox.CustomButton.UseSelectable = True
        Me.Year_Tbox.CustomButton.Visible = False
        Me.Year_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Year_Tbox.Lines = New String(-1) {}
        Me.Year_Tbox.Location = New System.Drawing.Point(24, 228)
        Me.Year_Tbox.MaxLength = 50
        Me.Year_Tbox.Name = "Year_Tbox"
        Me.Year_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Year_Tbox.ReadOnly = True
        Me.Year_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Year_Tbox.SelectedText = ""
        Me.Year_Tbox.SelectionLength = 0
        Me.Year_Tbox.SelectionStart = 0
        Me.Year_Tbox.ShortcutsEnabled = True
        Me.Year_Tbox.Size = New System.Drawing.Size(361, 40)
        Me.Year_Tbox.Style = MetroFramework.MetroColorStyle.Green
        Me.Year_Tbox.TabIndex = 55
        Me.Year_Tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Year_Tbox.UseSelectable = True
        Me.Year_Tbox.WaterMarkColor = System.Drawing.Color.Silver
        Me.Year_Tbox.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Program_Tbox
        '
        '
        '
        '
        Me.Program_Tbox.CustomButton.Image = Nothing
        Me.Program_Tbox.CustomButton.Location = New System.Drawing.Point(323, 2)
        Me.Program_Tbox.CustomButton.Name = ""
        Me.Program_Tbox.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.Program_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Program_Tbox.CustomButton.TabIndex = 1
        Me.Program_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Program_Tbox.CustomButton.UseSelectable = True
        Me.Program_Tbox.CustomButton.Visible = False
        Me.Program_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Program_Tbox.Lines = New String(-1) {}
        Me.Program_Tbox.Location = New System.Drawing.Point(24, 155)
        Me.Program_Tbox.MaxLength = 50
        Me.Program_Tbox.Name = "Program_Tbox"
        Me.Program_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Program_Tbox.ReadOnly = True
        Me.Program_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Program_Tbox.SelectedText = ""
        Me.Program_Tbox.SelectionLength = 0
        Me.Program_Tbox.SelectionStart = 0
        Me.Program_Tbox.ShortcutsEnabled = True
        Me.Program_Tbox.Size = New System.Drawing.Size(361, 40)
        Me.Program_Tbox.Style = MetroFramework.MetroColorStyle.Green
        Me.Program_Tbox.TabIndex = 54
        Me.Program_Tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Program_Tbox.UseSelectable = True
        Me.Program_Tbox.WaterMarkColor = System.Drawing.Color.Silver
        Me.Program_Tbox.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Institute_Tbox
        '
        '
        '
        '
        Me.Institute_Tbox.CustomButton.Image = Nothing
        Me.Institute_Tbox.CustomButton.Location = New System.Drawing.Point(323, 2)
        Me.Institute_Tbox.CustomButton.Name = ""
        Me.Institute_Tbox.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.Institute_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Institute_Tbox.CustomButton.TabIndex = 1
        Me.Institute_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Institute_Tbox.CustomButton.UseSelectable = True
        Me.Institute_Tbox.CustomButton.Visible = False
        Me.Institute_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Institute_Tbox.Lines = New String(-1) {}
        Me.Institute_Tbox.Location = New System.Drawing.Point(24, 83)
        Me.Institute_Tbox.MaxLength = 50
        Me.Institute_Tbox.Name = "Institute_Tbox"
        Me.Institute_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Institute_Tbox.ReadOnly = True
        Me.Institute_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Institute_Tbox.SelectedText = ""
        Me.Institute_Tbox.SelectionLength = 0
        Me.Institute_Tbox.SelectionStart = 0
        Me.Institute_Tbox.ShortcutsEnabled = True
        Me.Institute_Tbox.Size = New System.Drawing.Size(361, 40)
        Me.Institute_Tbox.Style = MetroFramework.MetroColorStyle.Green
        Me.Institute_Tbox.TabIndex = 52
        Me.Institute_Tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Institute_Tbox.UseSelectable = True
        Me.Institute_Tbox.WaterMarkColor = System.Drawing.Color.Silver
        Me.Institute_Tbox.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Send_Btn
        '
        Me.Send_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Send_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Send_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Send_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Send_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Send_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Send_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Send_Btn.ForeColor = System.Drawing.Color.Black
        Me.Send_Btn.Location = New System.Drawing.Point(295, 435)
        Me.Send_Btn.Name = "Send_Btn"
        Me.Send_Btn.Size = New System.Drawing.Size(90, 40)
        Me.Send_Btn.TabIndex = 53
        Me.Send_Btn.Text = "Send"
        Me.Send_Btn.UseVisualStyleBackColor = False
        '
        'Choose_Btn
        '
        Me.Choose_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Choose_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Choose_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Choose_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Choose_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Choose_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Choose_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Choose_Btn.ForeColor = System.Drawing.Color.Black
        Me.Choose_Btn.Location = New System.Drawing.Point(199, 435)
        Me.Choose_Btn.Name = "Choose_Btn"
        Me.Choose_Btn.Size = New System.Drawing.Size(90, 40)
        Me.Choose_Btn.TabIndex = 52
        Me.Choose_Btn.Text = "Choose"
        Me.Choose_Btn.UseVisualStyleBackColor = False
        '
        'CourseReq_Label
        '
        Me.CourseReq_Label.AutoSize = True
        Me.CourseReq_Label.Font = New System.Drawing.Font("Bernard MT Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CourseReq_Label.Location = New System.Drawing.Point(13, 9)
        Me.CourseReq_Label.Name = "CourseReq_Label"
        Me.CourseReq_Label.Size = New System.Drawing.Size(312, 40)
        Me.CourseReq_Label.TabIndex = 1
        Me.CourseReq_Label.Text = "Course Handle Request"
        '
        'Profile_Panel
        '
        Me.Profile_Panel.BackColor = System.Drawing.SystemColors.Window
        Me.Profile_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Profile_Panel.Controls.Add(Me.Button1)
        Me.Profile_Panel.Controls.Add(Me.LN_Label)
        Me.Profile_Panel.Controls.Add(Me.Save_Btn)
        Me.Profile_Panel.Controls.Add(Me.Birthday_Label)
        Me.Profile_Panel.Controls.Add(Me.Birthday_TB)
        Me.Profile_Panel.Controls.Add(Me.CN_Label)
        Me.Profile_Panel.Controls.Add(Me.Email_)
        Me.Profile_Panel.Controls.Add(Me.Sex_Label)
        Me.Profile_Panel.Controls.Add(Me.Sex_TB)
        Me.Profile_Panel.Controls.Add(Me.InstructorID_Label)
        Me.Profile_Panel.Controls.Add(Me.LN_TB)
        Me.Profile_Panel.Controls.Add(Me.MN_Label)
        Me.Profile_Panel.Controls.Add(Me.FN_Label)
        Me.Profile_Panel.Controls.Add(Me.MN_TB)
        Me.Profile_Panel.Controls.Add(Me.FN_TB)
        Me.Profile_Panel.Controls.Add(Me.InstructorsID_TB)
        Me.Profile_Panel.Controls.Add(Me.ProfilePic_PicBox)
        Me.Profile_Panel.Controls.Add(Me.Profile_Label)
        Me.Profile_Panel.Controls.Add(Me.CN_TB)
        Me.Profile_Panel.Controls.Add(Me.Email_TB)
        Me.Profile_Panel.Location = New System.Drawing.Point(4, 5)
        Me.Profile_Panel.Name = "Profile_Panel"
        Me.Profile_Panel.Size = New System.Drawing.Size(902, 509)
        Me.Profile_Panel.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(580, 435)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 40)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Request"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LN_Label
        '
        Me.LN_Label.AutoSize = True
        Me.LN_Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.LN_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LN_Label.Location = New System.Drawing.Point(673, 136)
        Me.LN_Label.Name = "LN_Label"
        Me.LN_Label.Size = New System.Drawing.Size(91, 20)
        Me.LN_Label.TabIndex = 35
        Me.LN_Label.Text = "Last Name"
        '
        'Save_Btn
        '
        Me.Save_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Save_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Save_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Save_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Save_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Save_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save_Btn.ForeColor = System.Drawing.Color.Black
        Me.Save_Btn.Location = New System.Drawing.Point(729, 435)
        Me.Save_Btn.Name = "Save_Btn"
        Me.Save_Btn.Size = New System.Drawing.Size(143, 40)
        Me.Save_Btn.TabIndex = 51
        Me.Save_Btn.Text = "Save Changes"
        Me.Save_Btn.UseVisualStyleBackColor = False
        '
        'Birthday_Label
        '
        Me.Birthday_Label.AutoSize = True
        Me.Birthday_Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.Birthday_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Birthday_Label.Location = New System.Drawing.Point(673, 209)
        Me.Birthday_Label.Name = "Birthday_Label"
        Me.Birthday_Label.Size = New System.Drawing.Size(71, 20)
        Me.Birthday_Label.TabIndex = 49
        Me.Birthday_Label.Text = "Birthday"
        '
        'Birthday_TB
        '
        '
        '
        '
        Me.Birthday_TB.CustomButton.Image = Nothing
        Me.Birthday_TB.CustomButton.Location = New System.Drawing.Point(157, 2)
        Me.Birthday_TB.CustomButton.Name = ""
        Me.Birthday_TB.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.Birthday_TB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Birthday_TB.CustomButton.TabIndex = 1
        Me.Birthday_TB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Birthday_TB.CustomButton.UseSelectable = True
        Me.Birthday_TB.CustomButton.Visible = False
        Me.Birthday_TB.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Birthday_TB.Lines = New String(-1) {}
        Me.Birthday_TB.Location = New System.Drawing.Point(677, 228)
        Me.Birthday_TB.MaxLength = 8
        Me.Birthday_TB.Name = "Birthday_TB"
        Me.Birthday_TB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Birthday_TB.ReadOnly = True
        Me.Birthday_TB.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Birthday_TB.SelectedText = ""
        Me.Birthday_TB.SelectionLength = 0
        Me.Birthday_TB.SelectionStart = 0
        Me.Birthday_TB.ShortcutsEnabled = True
        Me.Birthday_TB.Size = New System.Drawing.Size(195, 40)
        Me.Birthday_TB.Style = MetroFramework.MetroColorStyle.Green
        Me.Birthday_TB.TabIndex = 47
        Me.Birthday_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Birthday_TB.UseSelectable = True
        Me.Birthday_TB.WaterMarkColor = System.Drawing.Color.Silver
        Me.Birthday_TB.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'CN_Label
        '
        Me.CN_Label.AutoSize = True
        Me.CN_Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.CN_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CN_Label.Location = New System.Drawing.Point(473, 209)
        Me.CN_Label.Name = "CN_Label"
        Me.CN_Label.Size = New System.Drawing.Size(131, 20)
        Me.CN_Label.TabIndex = 46
        Me.CN_Label.Text = "Contact Number"
        '
        'Email_
        '
        Me.Email_.AutoSize = True
        Me.Email_.Cursor = System.Windows.Forms.Cursors.Default
        Me.Email_.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_.Location = New System.Drawing.Point(272, 282)
        Me.Email_.Name = "Email_"
        Me.Email_.Size = New System.Drawing.Size(118, 20)
        Me.Email_.TabIndex = 44
        Me.Email_.Text = "Email Address"
        '
        'Sex_Label
        '
        Me.Sex_Label.AutoSize = True
        Me.Sex_Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.Sex_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sex_Label.Location = New System.Drawing.Point(272, 209)
        Me.Sex_Label.Name = "Sex_Label"
        Me.Sex_Label.Size = New System.Drawing.Size(37, 20)
        Me.Sex_Label.TabIndex = 42
        Me.Sex_Label.Text = "Sex"
        '
        'Sex_TB
        '
        '
        '
        '
        Me.Sex_TB.CustomButton.Image = Nothing
        Me.Sex_TB.CustomButton.Location = New System.Drawing.Point(157, 2)
        Me.Sex_TB.CustomButton.Name = ""
        Me.Sex_TB.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.Sex_TB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Sex_TB.CustomButton.TabIndex = 1
        Me.Sex_TB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Sex_TB.CustomButton.UseSelectable = True
        Me.Sex_TB.CustomButton.Visible = False
        Me.Sex_TB.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Sex_TB.Lines = New String(-1) {}
        Me.Sex_TB.Location = New System.Drawing.Point(276, 228)
        Me.Sex_TB.MaxLength = 8
        Me.Sex_TB.Name = "Sex_TB"
        Me.Sex_TB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Sex_TB.ReadOnly = True
        Me.Sex_TB.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Sex_TB.SelectedText = ""
        Me.Sex_TB.SelectionLength = 0
        Me.Sex_TB.SelectionStart = 0
        Me.Sex_TB.ShortcutsEnabled = True
        Me.Sex_TB.Size = New System.Drawing.Size(195, 40)
        Me.Sex_TB.Style = MetroFramework.MetroColorStyle.Green
        Me.Sex_TB.TabIndex = 43
        Me.Sex_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Sex_TB.UseSelectable = True
        Me.Sex_TB.WaterMarkColor = System.Drawing.Color.Silver
        Me.Sex_TB.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'InstructorID_Label
        '
        Me.InstructorID_Label.AutoSize = True
        Me.InstructorID_Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.InstructorID_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructorID_Label.Location = New System.Drawing.Point(272, 64)
        Me.InstructorID_Label.Name = "InstructorID_Label"
        Me.InstructorID_Label.Size = New System.Drawing.Size(102, 20)
        Me.InstructorID_Label.TabIndex = 41
        Me.InstructorID_Label.Text = "Instructor ID"
        '
        'LN_TB
        '
        '
        '
        '
        Me.LN_TB.CustomButton.Image = Nothing
        Me.LN_TB.CustomButton.Location = New System.Drawing.Point(157, 2)
        Me.LN_TB.CustomButton.Name = ""
        Me.LN_TB.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.LN_TB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.LN_TB.CustomButton.TabIndex = 1
        Me.LN_TB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.LN_TB.CustomButton.UseSelectable = True
        Me.LN_TB.CustomButton.Visible = False
        Me.LN_TB.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.LN_TB.Lines = New String(-1) {}
        Me.LN_TB.Location = New System.Drawing.Point(677, 155)
        Me.LN_TB.MaxLength = 8
        Me.LN_TB.Name = "LN_TB"
        Me.LN_TB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LN_TB.ReadOnly = True
        Me.LN_TB.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.LN_TB.SelectedText = ""
        Me.LN_TB.SelectionLength = 0
        Me.LN_TB.SelectionStart = 0
        Me.LN_TB.ShortcutsEnabled = True
        Me.LN_TB.Size = New System.Drawing.Size(195, 40)
        Me.LN_TB.Style = MetroFramework.MetroColorStyle.Green
        Me.LN_TB.TabIndex = 40
        Me.LN_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.LN_TB.UseSelectable = True
        Me.LN_TB.WaterMarkColor = System.Drawing.Color.Silver
        Me.LN_TB.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MN_Label
        '
        Me.MN_Label.AutoSize = True
        Me.MN_Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.MN_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MN_Label.Location = New System.Drawing.Point(472, 136)
        Me.MN_Label.Name = "MN_Label"
        Me.MN_Label.Size = New System.Drawing.Size(107, 20)
        Me.MN_Label.TabIndex = 33
        Me.MN_Label.Text = "Middle Name"
        '
        'FN_Label
        '
        Me.FN_Label.AutoSize = True
        Me.FN_Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.FN_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FN_Label.Location = New System.Drawing.Point(272, 136)
        Me.FN_Label.Name = "FN_Label"
        Me.FN_Label.Size = New System.Drawing.Size(92, 20)
        Me.FN_Label.TabIndex = 31
        Me.FN_Label.Text = "First Name"
        '
        'MN_TB
        '
        '
        '
        '
        Me.MN_TB.CustomButton.Image = Nothing
        Me.MN_TB.CustomButton.Location = New System.Drawing.Point(157, 2)
        Me.MN_TB.CustomButton.Name = ""
        Me.MN_TB.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.MN_TB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MN_TB.CustomButton.TabIndex = 1
        Me.MN_TB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MN_TB.CustomButton.UseSelectable = True
        Me.MN_TB.CustomButton.Visible = False
        Me.MN_TB.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MN_TB.Lines = New String(-1) {}
        Me.MN_TB.Location = New System.Drawing.Point(476, 155)
        Me.MN_TB.MaxLength = 8
        Me.MN_TB.Name = "MN_TB"
        Me.MN_TB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MN_TB.ReadOnly = True
        Me.MN_TB.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MN_TB.SelectedText = ""
        Me.MN_TB.SelectionLength = 0
        Me.MN_TB.SelectionStart = 0
        Me.MN_TB.ShortcutsEnabled = True
        Me.MN_TB.Size = New System.Drawing.Size(195, 40)
        Me.MN_TB.Style = MetroFramework.MetroColorStyle.Green
        Me.MN_TB.TabIndex = 38
        Me.MN_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MN_TB.UseSelectable = True
        Me.MN_TB.WaterMarkColor = System.Drawing.Color.Silver
        Me.MN_TB.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'FN_TB
        '
        '
        '
        '
        Me.FN_TB.CustomButton.Image = Nothing
        Me.FN_TB.CustomButton.Location = New System.Drawing.Point(157, 2)
        Me.FN_TB.CustomButton.Name = ""
        Me.FN_TB.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.FN_TB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.FN_TB.CustomButton.TabIndex = 1
        Me.FN_TB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.FN_TB.CustomButton.UseSelectable = True
        Me.FN_TB.CustomButton.Visible = False
        Me.FN_TB.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.FN_TB.Lines = New String(-1) {}
        Me.FN_TB.Location = New System.Drawing.Point(276, 155)
        Me.FN_TB.MaxLength = 8
        Me.FN_TB.Name = "FN_TB"
        Me.FN_TB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FN_TB.ReadOnly = True
        Me.FN_TB.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.FN_TB.SelectedText = ""
        Me.FN_TB.SelectionLength = 0
        Me.FN_TB.SelectionStart = 0
        Me.FN_TB.ShortcutsEnabled = True
        Me.FN_TB.Size = New System.Drawing.Size(195, 40)
        Me.FN_TB.Style = MetroFramework.MetroColorStyle.Green
        Me.FN_TB.TabIndex = 37
        Me.FN_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FN_TB.UseSelectable = True
        Me.FN_TB.WaterMarkColor = System.Drawing.Color.Silver
        Me.FN_TB.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'InstructorsID_TB
        '
        '
        '
        '
        Me.InstructorsID_TB.CustomButton.Image = Nothing
        Me.InstructorsID_TB.CustomButton.Location = New System.Drawing.Point(558, 2)
        Me.InstructorsID_TB.CustomButton.Name = ""
        Me.InstructorsID_TB.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.InstructorsID_TB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.InstructorsID_TB.CustomButton.TabIndex = 1
        Me.InstructorsID_TB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.InstructorsID_TB.CustomButton.UseSelectable = True
        Me.InstructorsID_TB.CustomButton.Visible = False
        Me.InstructorsID_TB.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.InstructorsID_TB.Lines = New String(-1) {}
        Me.InstructorsID_TB.Location = New System.Drawing.Point(276, 83)
        Me.InstructorsID_TB.MaxLength = 8
        Me.InstructorsID_TB.Name = "InstructorsID_TB"
        Me.InstructorsID_TB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.InstructorsID_TB.ReadOnly = True
        Me.InstructorsID_TB.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.InstructorsID_TB.SelectedText = ""
        Me.InstructorsID_TB.SelectionLength = 0
        Me.InstructorsID_TB.SelectionStart = 0
        Me.InstructorsID_TB.ShortcutsEnabled = True
        Me.InstructorsID_TB.Size = New System.Drawing.Size(596, 40)
        Me.InstructorsID_TB.Style = MetroFramework.MetroColorStyle.Green
        Me.InstructorsID_TB.TabIndex = 36
        Me.InstructorsID_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InstructorsID_TB.UseSelectable = True
        Me.InstructorsID_TB.WaterMarkColor = System.Drawing.Color.Silver
        Me.InstructorsID_TB.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ProfilePic_PicBox
        '
        Me.ProfilePic_PicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ProfilePic_PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProfilePic_PicBox.Image = CType(resources.GetObject("ProfilePic_PicBox.Image"), System.Drawing.Image)
        Me.ProfilePic_PicBox.Location = New System.Drawing.Point(31, 69)
        Me.ProfilePic_PicBox.Name = "ProfilePic_PicBox"
        Me.ProfilePic_PicBox.Size = New System.Drawing.Size(212, 200)
        Me.ProfilePic_PicBox.TabIndex = 1
        Me.ProfilePic_PicBox.TabStop = False
        '
        'Profile_Label
        '
        Me.Profile_Label.AutoSize = True
        Me.Profile_Label.Font = New System.Drawing.Font("Bernard MT Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Profile_Label.Location = New System.Drawing.Point(9, 9)
        Me.Profile_Label.Name = "Profile_Label"
        Me.Profile_Label.Size = New System.Drawing.Size(102, 40)
        Me.Profile_Label.TabIndex = 0
        Me.Profile_Label.Text = "Profile"
        '
        'CN_TB
        '
        '
        '
        '
        Me.CN_TB.CustomButton.Image = Nothing
        Me.CN_TB.CustomButton.Location = New System.Drawing.Point(156, 2)
        Me.CN_TB.CustomButton.Name = ""
        Me.CN_TB.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.CN_TB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.CN_TB.CustomButton.TabIndex = 1
        Me.CN_TB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.CN_TB.CustomButton.UseSelectable = True
        Me.CN_TB.CustomButton.Visible = False
        Me.CN_TB.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.CN_TB.Lines = New String(-1) {}
        Me.CN_TB.Location = New System.Drawing.Point(477, 228)
        Me.CN_TB.MaxLength = 8
        Me.CN_TB.Name = "CN_TB"
        Me.CN_TB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CN_TB.ReadOnly = True
        Me.CN_TB.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.CN_TB.SelectedText = ""
        Me.CN_TB.SelectionLength = 0
        Me.CN_TB.SelectionStart = 0
        Me.CN_TB.ShortcutsEnabled = True
        Me.CN_TB.Size = New System.Drawing.Size(194, 40)
        Me.CN_TB.Style = MetroFramework.MetroColorStyle.Green
        Me.CN_TB.TabIndex = 45
        Me.CN_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CN_TB.UseSelectable = True
        Me.CN_TB.WaterMarkColor = System.Drawing.Color.Silver
        Me.CN_TB.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Email_TB
        '
        '
        '
        '
        Me.Email_TB.CustomButton.Image = Nothing
        Me.Email_TB.CustomButton.Location = New System.Drawing.Point(558, 2)
        Me.Email_TB.CustomButton.Name = ""
        Me.Email_TB.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.Email_TB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Email_TB.CustomButton.TabIndex = 1
        Me.Email_TB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Email_TB.CustomButton.UseSelectable = True
        Me.Email_TB.CustomButton.Visible = False
        Me.Email_TB.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Email_TB.Lines = New String(-1) {}
        Me.Email_TB.Location = New System.Drawing.Point(276, 301)
        Me.Email_TB.MaxLength = 8
        Me.Email_TB.Name = "Email_TB"
        Me.Email_TB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Email_TB.ReadOnly = True
        Me.Email_TB.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Email_TB.SelectedText = ""
        Me.Email_TB.SelectionLength = 0
        Me.Email_TB.SelectionStart = 0
        Me.Email_TB.ShortcutsEnabled = True
        Me.Email_TB.Size = New System.Drawing.Size(596, 40)
        Me.Email_TB.Style = MetroFramework.MetroColorStyle.Green
        Me.Email_TB.TabIndex = 50
        Me.Email_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Email_TB.UseSelectable = True
        Me.Email_TB.WaterMarkColor = System.Drawing.Color.Silver
        Me.Email_TB.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Welcome_BG
        '
        Me.Welcome_BG.Image = CType(resources.GetObject("Welcome_BG.Image"), System.Drawing.Image)
        Me.Welcome_BG.Location = New System.Drawing.Point(272, 118)
        Me.Welcome_BG.Name = "Welcome_BG"
        Me.Welcome_BG.Size = New System.Drawing.Size(1208, 599)
        Me.Welcome_BG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Welcome_BG.TabIndex = 4
        Me.Welcome_BG.TabStop = False
        '
        'Instructor_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1550, 870)
        Me.Controls.Add(Me.MyProfile_Panel)
        Me.Controls.Add(Me.GreenSide_Panel)
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
        Me.GreenSide_Panel.ResumeLayout(False)
        Me.Dropdown_Panel.ResumeLayout(False)
        CType(Me.CMDRMS_PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CDM_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MyProfile_Panel.ResumeLayout(False)
        Me.CourseReq_Panel.ResumeLayout(False)
        Me.CourseReq_Panel.PerformLayout()
        Me.Profile_Panel.ResumeLayout(False)
        Me.Profile_Panel.PerformLayout()
        CType(Me.ProfilePic_PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Welcome_BG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GreenSide_Panel As Panel
    Friend WithEvents Dropdown_Panel As Panel
    Friend WithEvents Menu_Btn As Button
    Friend WithEvents GreenUpper_Panel As Panel
    Friend WithEvents StudentGrade_Btn As Button
    Friend WithEvents Logout_Btn As Button
    Friend WithEvents Dropdown_Timer As Timer
    Friend WithEvents CDM_Logo As PictureBox
    Friend WithEvents MyProfile_Btn As Button
    Friend WithEvents MyProfile_Panel As Panel
    Friend WithEvents Profile_Panel As Panel
    Friend WithEvents CourseReq_Panel As Panel
    Friend WithEvents Profile_Label As Label
    Friend WithEvents CourseReq_Label As Label
    Friend WithEvents ProfilePic_PicBox As PictureBox
    Friend WithEvents MN_Label As Label
    Friend WithEvents FN_Label As Label
    Friend WithEvents LN_Label As Label
    Friend WithEvents FN_TB As MetroFramework.Controls.MetroTextBox
    Friend WithEvents InstructorsID_TB As MetroFramework.Controls.MetroTextBox
    Friend WithEvents LN_TB As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MN_TB As MetroFramework.Controls.MetroTextBox
    Friend WithEvents CN_Label As Label
    Friend WithEvents Birthday_TB As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Email_ As Label
    Friend WithEvents CN_TB As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Sex_Label As Label
    Friend WithEvents Sex_TB As MetroFramework.Controls.MetroTextBox
    Friend WithEvents InstructorID_Label As Label
    Friend WithEvents Birthday_Label As Label
    Friend WithEvents Email_TB As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Save_Btn As Button
    Friend WithEvents CMDRMS_PicBox As PictureBox
    Friend WithEvents Welcome_BG As PictureBox
    Friend WithEvents Choose_Btn As Button
    Friend WithEvents Send_Btn As Button
    Friend WithEvents Course_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Sem_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Year_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Program_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Institute_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Institute As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
End Class
