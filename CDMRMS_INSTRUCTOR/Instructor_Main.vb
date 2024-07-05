Imports MySql.Data.MySqlClient


Public Class Instructor_Main


    ' FORM LOAD - START
    Private Sub Instructor_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Menu_Panel.Size = Menu_Panel.MinimumSize

        MyProfile_Panel.Hide()
        StudentGrade_Panel.Hide()

        RememberMeValue()
        DisplayInfo()
        LockInStatusCheck()
        CollegeProgram(PassedValue)
        DropdownUserInfo(userinfo)

        AutoRefresher_Timer.Interval = 3000
        AutoRefresher_Timer.Start()

        InstructorsID_TB.Height = 100
        Me.Icon = My.Resources.CdMRMS

        CDMRMS_Instructor_Login.Hide()

    End Sub

    Private Sub RememberMeValue()
        If My.Settings.StaySignedIn Then
            PassedValue = My.Settings.InstructorID
        End If
    End Sub
    ' FORM LOAD - END



    ' DATABASE CONNECTION - START
    Private Shared ConnectionString As String = "server=localhost; port=3306; database=cdmregistrarmanagementsystem; uid=root; password=;"
    Private Shared connection As New MySqlConnection(ConnectionString)
    Dim adapter As New MySqlDataAdapter()
    Dim dataTable As New DataTable()

    Private Sub DatabaseConnection()

        Try
            connection.Open()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MessageBoxIcon.Error)
        Finally
            connection.Close()

        End Try

    End Sub

    Public Shared Function GetConnection() As MySqlConnection

        Return connection

    End Function
    ' DATABASE CONNECTION - END

    ' Menu Dropdown Animation
    Dim MenuCollapsed As Boolean = True
    Private Sub Dropdown_Timer_Tick(sender As Object, e As EventArgs) Handles Dropdown_Timer.Tick
        If MenuCollapsed Then

            ' Change image of Menu button to Arrow Down
            Menu_Panel.Height += 15
            If Menu_Panel.Size = Menu_Panel.MaximumSize Then

                Dropdown_Timer.Stop()
                MenuCollapsed = False

            End If
        Else

            Menu_Panel.Height -= 15
            If Menu_Panel.Size = Menu_Panel.MinimumSize Then

                Dropdown_Timer.Stop()
                MenuCollapsed = True


            End If
        End If
    End Sub

    Private Sub Menu_Btn_Click(sender As Object, e As EventArgs) Handles Menu_Btn.Click
        Dropdown_Timer.Start()

    End Sub

    Dim userinfo As String
    Public Sub DropdownUserInfo(userinfo)
        DropdownUser_Info.Text = userinfo
    End Sub


    Private Sub Home_link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Home_link.LinkClicked
        MyProfile_Panel.Hide()
        StudentGrade_Panel.Hide()
    End Sub


    ' MY ACCOUNT - START
    Public Property PassedValue As String
    Private Sub Account_link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Account_link.LinkClicked
        MyProfile_Panel.Show()
        StudentGrade_Panel.Hide()
    End Sub


    ' Display Necessary Information of selected instructor
    Private Sub DisplayInfo()

        Dim query As String = "SELECT * FROM `instructors` WHERE instructorid = @instructorid"
        Using connection As New MySqlConnection(ConnectionString)
            Using command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@instructorid", PassedValue)

                Try

                    connection.Open()

                    Using reader As MySqlDataReader = command.ExecuteReader

                        If reader.Read Then

                            Dim dateOnly As Date = Convert.ToDateTime(reader("birthday"))

                            ' Instructor Information 
                            InstructorsID_TB.Text = reader("instructorid").ToString()
                            FN_TB.Text = reader("firstname").ToString()
                            MN_TB.Text = reader("middlename").ToString()
                            LN_TB.Text = reader("lastname").ToString()
                            Sex_TB.Text = reader("gender").ToString()
                            CN_TB.Text = reader("contact#").ToString()
                            Birthday_TB.Text = dateOnly.ToString("MM-dd-yyyy")
                            Email_TB.Text = reader("email").ToString()

                            If Sex_TB.Text = "Male" Then
                                ProfilePic_PicBox.Image = My.Resources.Male_Instructor

                            ElseIf Sex_TB.Text = "Female" Then

                                ProfilePic_PicBox.Image = My.Resources.Female_Instructor
                            End If
                            userinfo = FN_TB.Text & " " & LN_TB.Text
                            DropdownUserInfo(userinfo)
                        End If
                    End Using

                Catch ex As Exception

                End Try
            End Using
        End Using
        connection.Close()

    End Sub

    Private Sub Save_Btn_Click(sender As Object, e As EventArgs) Handles Save_Btn.Click
        UpdateDetails(PassedValue)
        DisplayInfo()
    End Sub
    Private Sub UpdateDetails(PassedValue)

        Dim firstname As String = FN_TB.Text.Trim
        Dim lastname As String = LN_TB.Text.Trim
        Dim middlename As String = MN_TB.Text.Trim
        Dim sex As String = Sex_TB.Text.Trim
        Dim number As String = CN_TB.Text.Trim
        Dim instructorid As String = PassedValue

        Dim updatequery As String = "UPDATE `instructors` SET `firstname` = @firstname, `middlename` = @middlename, `lastname` = @lastname, `gender` = @sex, `contact#` = @number WHERE instructorid = @instructorid"
        Try
            connection.Open()
            Dim command As New MySqlCommand(updatequery, connection)
            command.Parameters.AddWithValue("@instructorid", instructorid)
            command.Parameters.AddWithValue("@firstname", firstname)
            command.Parameters.AddWithValue("@lastname", lastname)
            command.Parameters.AddWithValue("@middlename", middlename)
            command.Parameters.AddWithValue("@sex", sex)
            command.Parameters.AddWithValue("@number", number)

            command.ExecuteNonQuery()
            MsgBox("success")


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    ' MY ACCOUNT - END



    ' STUDENT GRADE - START

    Private Sub Grade_Link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Grade_Link.LinkClicked
        StudentGrade_Panel.Show()
        MyProfile_Panel.Hide()
    End Sub


    Private Sub CollegeProgram(PassedValue)
        Dim instructorId As String = PassedValue
        Dim query As String = "SELECT DISTINCT program FROM assignedcourse WHERE instructor_id = @instructorId"
        Dim command As New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@instructorId", instructorId)
        Try
            connection.Open()
            CollegeProgramSelector.Items.Clear()
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                CollegeProgramSelector.Items.Add(reader.GetString("program"))

            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CollegeProgramSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CollegeProgramSelector.SelectedIndexChanged
        AssignedCourse(PassedValue)

    End Sub

    ' Assigned Course Table on Instructors Information  
    Private Sub AssignedCourse(PassedValue)
        Dim program As String = CollegeProgramSelector.Text.Trim
        ' Display Assigned Course
        Dim CourseQuery As String = "SELECT `course` FROM `assignedcourse` WHERE instructor_id = @instructorid AND program = @program"
        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()

            Using CourseCommand As New MySqlCommand(CourseQuery, connection)
                CourseCommand.Parameters.AddWithValue("@instructorid", PassedValue)
                CourseCommand.Parameters.AddWithValue("@program", program)
                Using reader As MySqlDataReader = CourseCommand.ExecuteReader()
                    CourseSelector.Items.Clear()
                    ' AssignedCourseTable.DataSource = dataTable
                    'AssignedCourseTable.Columns("course").Width = 201
                    While reader.Read()
                        CourseSelector.Items.Add(reader("course").ToString())
                    End While


                End Using
            End Using
        End Using
    End Sub

    Dim courseValue
    Private Sub CourseSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CourseSelector.SelectedIndexChanged
        courseValue = CourseSelector.Text.Trim
        Dim instructorid As String = PassedValue
        Dim sectionQuery As String = "SELECT * FROM assignedcourse WHERE course = @course AND instructor_id = @instructorid"

        Dim sectionAdapter As New MySqlDataAdapter(sectionQuery, connection)

        Try
            connection.Open()
            SectionSelector.Items.Clear()
            Using CourseCommand As New MySqlCommand(sectionQuery, connection)
                CourseCommand.Parameters.AddWithValue("@course", courseValue)
                CourseCommand.Parameters.AddWithValue("@instructorid", instructorid)
                Using reader As MySqlDataReader = CourseCommand.ExecuteReader()

                    If reader.Read() Then
                        For i As Integer = 5 To reader.FieldCount - 1
                            Dim cellvalue As String = reader(i).ToString()
                            If Not String.IsNullOrWhiteSpace(cellvalue) Then
                                SectionSelector.Items.Add(cellvalue)
                            End If
                        Next
                    End If

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        connection.Close()

    End Sub

    ' Variable declaration for Grade Insertion
    Dim Program As String
    Dim Course As String
    Dim Section As String

    ' View Student list
    Private Sub SectionSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SectionSelector.SelectedIndexChanged
        dataTable.Clear()
        Program = CollegeProgramSelector.Text.Trim
        Course = CourseSelector.Text.Trim
        Section = SectionSelector.Text.Trim

        If String.IsNullOrEmpty(Program) And String.IsNullOrEmpty(Course) And String.IsNullOrEmpty(Section) Then

            MsgBox("No Input.", MessageBoxIcon.Error)
        ElseIf String.IsNullOrEmpty(Program) Or String.IsNullOrEmpty(Course) Or String.IsNullOrEmpty(Section) Then
            MsgBox("Please, Select Necessary Information.", MessageBoxIcon.Warning)

        ElseIf Program = "BSIT" Then
            BSITGradeInsertionTable(Course)
            SortSection_BSIT(Section)

        ElseIf Program = "BSCPE" Then
            BSCPEGradeInsertionTable(Course)
            SortSection_BSCPE(Section)
        End If
    End Sub


    ' Queries to show courses that only handled by instructor 
    Private Sub BSITGradeInsertionTable(Course)
        Try
            connection.Open()

            Dim SelectQuery As String = $"SELECT `Student ID`,`Student Name`,`Section`, `{Course}` FROM bsit"


            Dim command As New MySqlCommand(SelectQuery, connection)

            Dim datatable As New DataTable()
            Using adapter As New MySqlDataAdapter(command)

                adapter.Fill(datatable)
                StudentlistTable.ColumnHeadersHeight = 200

                StudentlistTable.RowTemplate.Height = 30
                StudentlistTable.DataSource = datatable
                StudentlistTable.Columns("Student ID").Width = 150
                StudentlistTable.Columns("Student Name").Width = 271
                StudentlistTable.Columns("Section").Width = 152

                ' Disable editing to all cells under these columns
                StudentlistTable.Columns("Student ID").ReadOnly = True
                StudentlistTable.Columns("Student Name").ReadOnly = True
                StudentlistTable.Columns("Section").ReadOnly = True

            End Using

        Catch ex As Exception
            MessageBox.Show("Error fetching data : " & ex.Message)

        Finally
            connection.Close()

        End Try
    End Sub

    Private Sub BSCPEGradeInsertionTable(Course)
        Try
            connection.Open()

            Dim SelectQuery As String = $"SELECT `Student ID`,`Student Name`,`Section`, `{Course}` FROM bscpe"
            Dim command As New MySqlCommand(SelectQuery, connection)

            Dim datatable As New DataTable()
            Using adapter As New MySqlDataAdapter(command)

                adapter.Fill(datatable)
                StudentlistTable.ColumnHeadersHeight = 200

                StudentlistTable.RowTemplate.Height = 30
                StudentlistTable.DataSource = datatable
                StudentlistTable.Columns("Student ID").Width = 150
                StudentlistTable.Columns("Student Name").Width = 271
                StudentlistTable.Columns("Section").Width = 152


                ' Disable editing to all cells under these columns
                StudentlistTable.Columns("Student ID").ReadOnly = True
                StudentlistTable.Columns("Student Name").ReadOnly = True
                StudentlistTable.Columns("Section").ReadOnly = True

            End Using

        Catch ex As Exception
            MessageBox.Show("Error fetching data: " & ex.Message)

        Finally
            connection.Close()

        End Try
    End Sub

    ' Sort Student list according to sections
    Private Sub SortSection_BSIT(Section)

        Dim searchTerm As String = Section
        If searchTerm <> "" Then
            Try
                connection.Open()

                Dim query As String = "SELECT * FROM bsit WHERE Section LIKE @searchTerm "
                Dim command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")


                adapter = New MySqlDataAdapter(command)
                adapter.Fill(dataTable)
                StudentlistTable.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show("Error searching data: " & ex.Message)
            Finally
                connection.Close()

            End Try
        End If
    End Sub

    Private Sub SortSection_BSCPE(Section)

        Dim searchTerm As String = Section
        If searchTerm <> "" Then
            Try
                connection.Open()

                Dim query As String = "SELECT * FROM bscpe WHERE Section LIKE @searchTerm "
                Dim command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@searchTerm", "%" & searchTerm & "%")


                adapter = New MySqlDataAdapter(command)
                adapter.Fill(dataTable)
                StudentlistTable.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show("Error searching data: " & ex.Message)
            Finally
                connection.Close()

            End Try
        End If
    End Sub



    ' Suppress TAB and Arrow keys
    Private Sub StudentListTable_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles StudentlistTable.KeyDown

        ' Intercept Tab key
        If e.KeyCode = Keys.Tab Then
            e.Handled = True
            Return
        End If

        ' Intercept arrow keys
        If e.KeyCode = Keys.Up OrElse e.KeyCode = Keys.Down OrElse e.KeyCode = Keys.Left OrElse e.KeyCode = Keys.Right Then
            e.Handled = True
            Return
        End If

        ' This prevents the Table from handling the key
        If e.KeyCode = Keys.Home OrElse e.KeyCode = Keys.End OrElse e.KeyCode = Keys.PageUp OrElse e.KeyCode = Keys.PageDown Then

            e.Handled = True

        End If
    End Sub


    ' Save the changes mmade by the instructor (Inserting Grade to Table)
    Private Sub SaveData()

        Dim builder As New MySqlCommandBuilder(adapter)
        adapter.Update(dataTable)

    End Sub


    ' Save Grade Button
    Private Sub SaveGrade_Btn_Click(sender As Object, e As EventArgs) Handles SaveGrade_Btn.Click
        Dim collegeProgram As String = CollegeProgramSelector.Text.Trim
        Dim choice As DialogResult = MsgBox("Are you sure you want to submit?", MessageBoxButtons.OKCancel)

        If choice = DialogResult.OK Then

            If collegeProgram = "BSIT" Then

                SaveData()
                dataTable.Clear()
                BSITGradeInsertionTable(Course)
                SortSection_BSIT(Section)

            ElseIf collegeProgram = "BSCPE" Then

                SaveData()
                dataTable.Clear()
                BSCPEGradeInsertionTable(Course)
                SortSection_BSCPE(Section)

            End If

            MessageBox.Show("Grades are successfully inserted.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf choice = DialogResult.Cancel Then

            dataTable.Clear()
            BSITGradeInsertionTable(Course)
            SortSection_BSIT(Section)
            SortSection_BSCPE(Section)

        End If

    End Sub

    ' Lock-in Button
    Private Sub LockIn_Btn_Click(sender As Object, e As EventArgs) Handles LockIn_Btn.Click
        Dim InstructorID As String = InstructorsID_TB.Text
        Dim status As Boolean = False
        StudentlistTable.Enabled = status

        Dim query As String = " UPDATE instructors SET Status = @status WHERE instructorid = @instructorid "


        Dim choice As DialogResult = MessageBox.Show("Are you sure you want to lock in the grades? Once locked, you will not be able to change the grades.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        If choice = DialogResult.OK Then
            Try
                connection.Open()

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@status", status)
                    command.Parameters.AddWithValue("@instructorid", InstructorID)
                    command.ExecuteNonQuery()

                    MessageBox.Show("Grades have been locked and can no longer be changed.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LockIn_Btn.Enabled = False
                    SaveGrade_Btn.Enabled = False
                    LockInStatusCheck()
                End Using

            Catch ex As Exception

                MsgBox("error" & ex.Message)

            Finally
                connection.Close()

            End Try

        ElseIf choice = DialogResult.Cancel Then


        End If


        LockInStatusCheck()
    End Sub


    ' Check Status if the Instructor already Lock-in Grade
    Private Sub LockInStatusCheck()
        Dim query As String = "SELECT Status FROM instructors WHERE instructorid = @instructorid"
        Dim userid As String = InstructorsID_TB.Text
        Try
            connection.Open()

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@instructorid", userid)
                Dim result As Object = command.ExecuteScalar()

                If result IsNot DBNull.Value Then
                    Dim status As Boolean = Convert.ToBoolean(result)
                    If status Then

                        StudentlistTable.Enabled = True
                        LockIn_Btn.Enabled = True
                        SaveGrade_Btn.Enabled = True

                        ChangeGradeReq_Btn.Visible = False

                        ' description for lock and unlock function
                        Table_Status.Text = "    Dear Instructors, please input the grades of" & vbCrLf & "the students. This will allow us to evaluate their" & vbCrLf & "performance accurately.Ensure all fields are" & vbCrLf & "filled out correctly before submission."

                        StudentlistTable.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(221, 232, 248)
                    Else

                        StudentlistTable.Enabled = False
                        LockIn_Btn.Enabled = False
                        SaveGrade_Btn.Enabled = False

                        ChangeGradeReq_Btn.Visible = True

                        ' description for lock and unlock function
                        Table_Status.Text = "    Dear Instructors, please send a request to" & vbCrLf & "the administration to obtain permission for" & vbCrLf & "inputting grades."

                        StudentlistTable.RowsDefaultCellStyle.SelectionBackColor = Color.White

                    End If
                End If
            End Using

        Catch ex As Exception

        Finally
            connection.Close()

        End Try

    End Sub


    ' Reload Every 3 seconds to check if the admin already approved the request
    Private Sub AutoRefresher_Timer_Tick(sender As Object, e As EventArgs) Handles AutoRefresher_Timer.Tick
        LockInStatusCheck()
    End Sub


    ' Changing Grade Request Button
    Private Sub ChangeGradeReq_Btn_Click(sender As Object, e As EventArgs) Handles ChangeGradeReq_Btn.Click

        Dim firstName As String = FN_TB.Text
        Dim lastName As String = LN_TB.Text
        Dim instructorID As String = InstructorsID_TB.Text

        Dim choice As DialogResult = MsgBox("INSTRUCTOR NAME: " + lastName & ", " & firstName & vbCrLf & vbCrLf & "INSTRUCTOR ID: " & instructorID & vbCrLf & vbCrLf & vbCrLf & vbCrLf & "SEND REQUEST?", MessageBoxButtons.YesNo)

        Dim fullname As String = lastName + ", " + firstName

        If choice = DialogResult.Yes Then

            If Not IsDataExists(instructorID) Then

                Dim query As String = "INSERT INTO `request`( `Instructor ID`, `Instructor Name` ) VALUES ( @instructorid, @instructorName )"

                Try

                    Using connection As New MySqlConnection(ConnectionString)
                        Using command As New MySqlCommand(query, connection)

                            connection.Open()
                            command.Parameters.AddWithValue("@instructorid", instructorID)
                            command.Parameters.AddWithValue("@instructorName", fullname)

                            command.ExecuteNonQuery()

                            MsgBox("REQUEST SENT", MessageBoxIcon.Information)
                        End Using
                    End Using
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    connection.Close()
                End Try
            Else
                MsgBox(" " & vbCrLf & "You already sent a request." & vbCrLf & vbCrLf & vbCrLf & " ", MessageBoxIcon.Warning)
            End If


        End If

    End Sub

    Private Function IsDataExists(instructorID As String) As Boolean

        Dim query As String = "SELECT COUNT(*) FROM `request` WHERE `instructor ID` = @instructorID"
        Dim command As New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@instructorID", instructorID)

        connection.Open()
        Dim count As String = CInt(command.ExecuteScalar())
        connection.Close()

        Return count > 0

    End Function

    ' STUDENT GRADE - END


    ' LOGOUT - START
    Private Sub Logout_Btn_Click(sender As Object, e As EventArgs) Handles Logout_Btn.Click

        Dim choice As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If choice = DialogResult.OK Then

            Me.Close()
            CDMRMS_Instructor_Login.Show()

            My.Settings.StaySignedIn = False
            My.Settings.InstructorID = ""

        End If
    End Sub

    Private Sub Refresh_Btn_Click(sender As Object, e As EventArgs) Handles Refresh_Btn.Click

        CollegeProgram(PassedValue)
        AssignedCourse(PassedValue)
        CourseSelector.Items.Clear()
        SectionSelector.Items.Clear()
        dataTable.Clear()

    End Sub


    Private Sub Home_link_MouseHover(sender As Object, e As EventArgs) Handles Home_link.MouseHover
        Home_link.LinkColor = Color.FromArgb(255, 201, 48)
    End Sub
    Private Sub Account_link_MouseHover(sender As Object, e As EventArgs) Handles Account_link.MouseHover
        Account_link.LinkColor = Color.FromArgb(255, 201, 48)
    End Sub
    Private Sub Grade_link_MouseHover(sender As Object, e As EventArgs) Handles Grade_Link.MouseHover

        Grade_Link.LinkColor = Color.FromArgb(255, 201, 48)
    End Sub

    Private Sub Home_link_MouseLeave(sender As Object, e As EventArgs) Handles Home_link.MouseLeave, Account_link.MouseLeave, Grade_Link.MouseLeave
        Home_link.LinkColor = Color.White
        Account_link.LinkColor = Color.White
        Grade_Link.LinkColor = Color.White

    End Sub


    ' LOGOUT - END

End Class