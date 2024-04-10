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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Dropdown_Panel = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MyProfile_Btn = New System.Windows.Forms.Button()
        Me.Menu_Btn = New System.Windows.Forms.Button()
        Me.CDM_Logo = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Dropdown_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.MyProfile_Panel = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LoginInstructorID_Label = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MetroTextBox3 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox4 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox5 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MetroTextBox6 = New MetroFramework.Controls.MetroTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MetroTextBox7 = New MetroFramework.Controls.MetroTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MetroTextBox8 = New MetroFramework.Controls.MetroTextBox()
        Me.Login_Btn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Dropdown_Panel.SuspendLayout()
        CType(Me.CDM_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MyProfile_Panel.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Dropdown_Panel)
        Me.Panel1.Controls.Add(Me.CDM_Logo)
        Me.Panel1.Location = New System.Drawing.Point(-1, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 842)
        Me.Panel1.TabIndex = 0
        '
        'Dropdown_Panel
        '
        Me.Dropdown_Panel.BackColor = System.Drawing.Color.White
        Me.Dropdown_Panel.Controls.Add(Me.Button4)
        Me.Dropdown_Panel.Controls.Add(Me.Button3)
        Me.Dropdown_Panel.Controls.Add(Me.MyProfile_Btn)
        Me.Dropdown_Panel.Controls.Add(Me.Menu_Btn)
        Me.Dropdown_Panel.Location = New System.Drawing.Point(2, 1)
        Me.Dropdown_Panel.MaximumSize = New System.Drawing.Size(216, 208)
        Me.Dropdown_Panel.MinimumSize = New System.Drawing.Size(216, 58)
        Me.Dropdown_Panel.Name = "Dropdown_Panel"
        Me.Dropdown_Panel.Size = New System.Drawing.Size(216, 208)
        Me.Dropdown_Panel.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(0, 158)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(216, 50)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Log Out"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(0, 108)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(216, 50)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Student Grade"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'MyProfile_Btn
        '
        Me.MyProfile_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.MyProfile_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MyProfile_Btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.MyProfile_Btn.FlatAppearance.BorderSize = 0
        Me.MyProfile_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
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
        Me.Menu_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Menu_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Menu_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Menu_Btn.Location = New System.Drawing.Point(0, 0)
        Me.Menu_Btn.Name = "Menu_Btn"
        Me.Menu_Btn.Size = New System.Drawing.Size(216, 58)
        Me.Menu_Btn.TabIndex = 1
        Me.Menu_Btn.Text = "MENU"
        Me.Menu_Btn.UseVisualStyleBackColor = True
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(217, 31)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1334, 60)
        Me.Panel3.TabIndex = 2
        '
        'Dropdown_Timer
        '
        Me.Dropdown_Timer.Interval = 15
        '
        'MyProfile_Panel
        '
        Me.MyProfile_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.MyProfile_Panel.Controls.Add(Me.Panel5)
        Me.MyProfile_Panel.Controls.Add(Me.Panel4)
        Me.MyProfile_Panel.Location = New System.Drawing.Point(218, 91)
        Me.MyProfile_Panel.Name = "MyProfile_Panel"
        Me.MyProfile_Panel.Size = New System.Drawing.Size(1334, 784)
        Me.MyProfile_Panel.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Login_Btn)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.MetroTextBox7)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.MetroTextBox2)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.MetroTextBox1)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.LoginInstructorID_Label)
        Me.Panel4.Controls.Add(Me.MetroTextBox5)
        Me.Panel4.Controls.Add(Me.MetroTextBox4)
        Me.Panel4.Controls.Add(Me.MetroTextBox3)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.MetroTextBox6)
        Me.Panel4.Controls.Add(Me.MetroTextBox8)
        Me.Panel4.Location = New System.Drawing.Point(4, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(902, 555)
        Me.Panel4.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Location = New System.Drawing.Point(911, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(413, 555)
        Me.Panel5.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Profile"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bernard MT Condensed", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 40)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Course/s Handled"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(31, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 200)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'LoginInstructorID_Label
        '
        Me.LoginInstructorID_Label.AutoSize = True
        Me.LoginInstructorID_Label.Cursor = System.Windows.Forms.Cursors.Default
        Me.LoginInstructorID_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginInstructorID_Label.Location = New System.Drawing.Point(272, 149)
        Me.LoginInstructorID_Label.Name = "LoginInstructorID_Label"
        Me.LoginInstructorID_Label.Size = New System.Drawing.Size(92, 20)
        Me.LoginInstructorID_Label.TabIndex = 31
        Me.LoginInstructorID_Label.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(472, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Middle Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(673, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 20)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Last Name"
        '
        'MetroTextBox3
        '
        '
        '
        '
        Me.MetroTextBox3.CustomButton.Image = Nothing
        Me.MetroTextBox3.CustomButton.Location = New System.Drawing.Point(558, 2)
        Me.MetroTextBox3.CustomButton.Name = ""
        Me.MetroTextBox3.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.MetroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox3.CustomButton.TabIndex = 1
        Me.MetroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox3.CustomButton.UseSelectable = True
        Me.MetroTextBox3.CustomButton.Visible = False
        Me.MetroTextBox3.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox3.Lines = New String(-1) {}
        Me.MetroTextBox3.Location = New System.Drawing.Point(276, 96)
        Me.MetroTextBox3.MaxLength = 8
        Me.MetroTextBox3.Name = "MetroTextBox3"
        Me.MetroTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox3.ReadOnly = True
        Me.MetroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox3.SelectedText = ""
        Me.MetroTextBox3.SelectionLength = 0
        Me.MetroTextBox3.SelectionStart = 0
        Me.MetroTextBox3.ShortcutsEnabled = True
        Me.MetroTextBox3.Size = New System.Drawing.Size(596, 40)
        Me.MetroTextBox3.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTextBox3.TabIndex = 36
        Me.MetroTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MetroTextBox3.UseSelectable = True
        Me.MetroTextBox3.WaterMarkColor = System.Drawing.Color.Silver
        Me.MetroTextBox3.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox4
        '
        '
        '
        '
        Me.MetroTextBox4.CustomButton.Image = Nothing
        Me.MetroTextBox4.CustomButton.Location = New System.Drawing.Point(157, 2)
        Me.MetroTextBox4.CustomButton.Name = ""
        Me.MetroTextBox4.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.MetroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox4.CustomButton.TabIndex = 1
        Me.MetroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox4.CustomButton.UseSelectable = True
        Me.MetroTextBox4.CustomButton.Visible = False
        Me.MetroTextBox4.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox4.Lines = New String(-1) {}
        Me.MetroTextBox4.Location = New System.Drawing.Point(276, 168)
        Me.MetroTextBox4.MaxLength = 8
        Me.MetroTextBox4.Name = "MetroTextBox4"
        Me.MetroTextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox4.ReadOnly = True
        Me.MetroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox4.SelectedText = ""
        Me.MetroTextBox4.SelectionLength = 0
        Me.MetroTextBox4.SelectionStart = 0
        Me.MetroTextBox4.ShortcutsEnabled = True
        Me.MetroTextBox4.Size = New System.Drawing.Size(195, 40)
        Me.MetroTextBox4.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTextBox4.TabIndex = 37
        Me.MetroTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MetroTextBox4.UseSelectable = True
        Me.MetroTextBox4.WaterMarkColor = System.Drawing.Color.Silver
        Me.MetroTextBox4.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox5
        '
        '
        '
        '
        Me.MetroTextBox5.CustomButton.Image = Nothing
        Me.MetroTextBox5.CustomButton.Location = New System.Drawing.Point(157, 2)
        Me.MetroTextBox5.CustomButton.Name = ""
        Me.MetroTextBox5.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.MetroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox5.CustomButton.TabIndex = 1
        Me.MetroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox5.CustomButton.UseSelectable = True
        Me.MetroTextBox5.CustomButton.Visible = False
        Me.MetroTextBox5.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox5.Lines = New String(-1) {}
        Me.MetroTextBox5.Location = New System.Drawing.Point(476, 168)
        Me.MetroTextBox5.MaxLength = 8
        Me.MetroTextBox5.Name = "MetroTextBox5"
        Me.MetroTextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox5.ReadOnly = True
        Me.MetroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox5.SelectedText = ""
        Me.MetroTextBox5.SelectionLength = 0
        Me.MetroTextBox5.SelectionStart = 0
        Me.MetroTextBox5.ShortcutsEnabled = True
        Me.MetroTextBox5.Size = New System.Drawing.Size(195, 40)
        Me.MetroTextBox5.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTextBox5.TabIndex = 38
        Me.MetroTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MetroTextBox5.UseSelectable = True
        Me.MetroTextBox5.WaterMarkColor = System.Drawing.Color.Silver
        Me.MetroTextBox5.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(157, 2)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(677, 168)
        Me.MetroTextBox1.MaxLength = 8
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ReadOnly = True
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShortcutsEnabled = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(195, 40)
        Me.MetroTextBox1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTextBox1.TabIndex = 40
        Me.MetroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.Silver
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(272, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 20)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Instructor ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(272, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 20)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Sex"
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = Nothing
        Me.MetroTextBox2.CustomButton.Location = New System.Drawing.Point(157, 2)
        Me.MetroTextBox2.CustomButton.Name = ""
        Me.MetroTextBox2.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.MetroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox2.CustomButton.TabIndex = 1
        Me.MetroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox2.CustomButton.UseSelectable = True
        Me.MetroTextBox2.CustomButton.Visible = False
        Me.MetroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox2.Lines = New String(-1) {}
        Me.MetroTextBox2.Location = New System.Drawing.Point(276, 241)
        Me.MetroTextBox2.MaxLength = 8
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ReadOnly = True
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.ShortcutsEnabled = True
        Me.MetroTextBox2.Size = New System.Drawing.Size(195, 40)
        Me.MetroTextBox2.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTextBox2.TabIndex = 43
        Me.MetroTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.Silver
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(272, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 20)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Email Address"
        '
        'MetroTextBox6
        '
        '
        '
        '
        Me.MetroTextBox6.CustomButton.Image = Nothing
        Me.MetroTextBox6.CustomButton.Location = New System.Drawing.Point(156, 2)
        Me.MetroTextBox6.CustomButton.Name = ""
        Me.MetroTextBox6.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.MetroTextBox6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox6.CustomButton.TabIndex = 1
        Me.MetroTextBox6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox6.CustomButton.UseSelectable = True
        Me.MetroTextBox6.CustomButton.Visible = False
        Me.MetroTextBox6.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox6.Lines = New String(-1) {}
        Me.MetroTextBox6.Location = New System.Drawing.Point(477, 241)
        Me.MetroTextBox6.MaxLength = 8
        Me.MetroTextBox6.Name = "MetroTextBox6"
        Me.MetroTextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox6.ReadOnly = True
        Me.MetroTextBox6.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox6.SelectedText = ""
        Me.MetroTextBox6.SelectionLength = 0
        Me.MetroTextBox6.SelectionStart = 0
        Me.MetroTextBox6.ShortcutsEnabled = True
        Me.MetroTextBox6.Size = New System.Drawing.Size(194, 40)
        Me.MetroTextBox6.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTextBox6.TabIndex = 45
        Me.MetroTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MetroTextBox6.UseSelectable = True
        Me.MetroTextBox6.WaterMarkColor = System.Drawing.Color.Silver
        Me.MetroTextBox6.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(473, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 20)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Contact Number"
        '
        'MetroTextBox7
        '
        '
        '
        '
        Me.MetroTextBox7.CustomButton.Image = Nothing
        Me.MetroTextBox7.CustomButton.Location = New System.Drawing.Point(157, 2)
        Me.MetroTextBox7.CustomButton.Name = ""
        Me.MetroTextBox7.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.MetroTextBox7.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox7.CustomButton.TabIndex = 1
        Me.MetroTextBox7.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox7.CustomButton.UseSelectable = True
        Me.MetroTextBox7.CustomButton.Visible = False
        Me.MetroTextBox7.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox7.Lines = New String(-1) {}
        Me.MetroTextBox7.Location = New System.Drawing.Point(677, 241)
        Me.MetroTextBox7.MaxLength = 8
        Me.MetroTextBox7.Name = "MetroTextBox7"
        Me.MetroTextBox7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox7.ReadOnly = True
        Me.MetroTextBox7.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox7.SelectedText = ""
        Me.MetroTextBox7.SelectionLength = 0
        Me.MetroTextBox7.SelectionStart = 0
        Me.MetroTextBox7.ShortcutsEnabled = True
        Me.MetroTextBox7.Size = New System.Drawing.Size(195, 40)
        Me.MetroTextBox7.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTextBox7.TabIndex = 47
        Me.MetroTextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MetroTextBox7.UseSelectable = True
        Me.MetroTextBox7.WaterMarkColor = System.Drawing.Color.Silver
        Me.MetroTextBox7.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(673, 222)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 20)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Birthday"
        '
        'MetroTextBox8
        '
        '
        '
        '
        Me.MetroTextBox8.CustomButton.Image = Nothing
        Me.MetroTextBox8.CustomButton.Location = New System.Drawing.Point(558, 2)
        Me.MetroTextBox8.CustomButton.Name = ""
        Me.MetroTextBox8.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.MetroTextBox8.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox8.CustomButton.TabIndex = 1
        Me.MetroTextBox8.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox8.CustomButton.UseSelectable = True
        Me.MetroTextBox8.CustomButton.Visible = False
        Me.MetroTextBox8.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.MetroTextBox8.Lines = New String(-1) {}
        Me.MetroTextBox8.Location = New System.Drawing.Point(276, 314)
        Me.MetroTextBox8.MaxLength = 8
        Me.MetroTextBox8.Name = "MetroTextBox8"
        Me.MetroTextBox8.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox8.ReadOnly = True
        Me.MetroTextBox8.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox8.SelectedText = ""
        Me.MetroTextBox8.SelectionLength = 0
        Me.MetroTextBox8.SelectionStart = 0
        Me.MetroTextBox8.ShortcutsEnabled = True
        Me.MetroTextBox8.Size = New System.Drawing.Size(596, 40)
        Me.MetroTextBox8.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTextBox8.TabIndex = 50
        Me.MetroTextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MetroTextBox8.UseSelectable = True
        Me.MetroTextBox8.WaterMarkColor = System.Drawing.Color.Silver
        Me.MetroTextBox8.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Login_Btn
        '
        Me.Login_Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Login_Btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Login_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Login_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Login_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Login_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Login_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_Btn.ForeColor = System.Drawing.Color.Black
        Me.Login_Btn.Location = New System.Drawing.Point(725, 485)
        Me.Login_Btn.Name = "Login_Btn"
        Me.Login_Btn.Size = New System.Drawing.Size(147, 40)
        Me.Login_Btn.TabIndex = 51
        Me.Login_Btn.Text = "Save Changes"
        Me.Login_Btn.UseVisualStyleBackColor = False
        '
        'Instructor_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1550, 870)
        Me.Controls.Add(Me.MyProfile_Panel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1550, 870)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1550, 870)
        Me.Name = "Instructor_Main"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.None
        Me.Style = MetroFramework.MetroColorStyle.White
        Me.Panel1.ResumeLayout(False)
        Me.Dropdown_Panel.ResumeLayout(False)
        CType(Me.CDM_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MyProfile_Panel.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Dropdown_Panel As Panel
    Friend WithEvents Menu_Btn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Dropdown_Timer As Timer
    Friend WithEvents CDM_Logo As PictureBox
    Friend WithEvents MyProfile_Btn As Button
    Friend WithEvents MyProfile_Panel As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LoginInstructorID_Label As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MetroTextBox4 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox5 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents MetroTextBox7 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents MetroTextBox6 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents MetroTextBox8 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Login_Btn As Button
End Class
