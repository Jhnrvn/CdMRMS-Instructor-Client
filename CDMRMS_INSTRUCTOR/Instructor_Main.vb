Imports MySql.Data.MySqlClient


Public Class Instructor_Main


    ' FORM LOAD - START
    Private Sub Instructor_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dropdown_Panel.Size = Dropdown_Panel.MinimumSize

        MyProfile_Panel.Hide()
        StudentGrade_Panel.Hide()
        DisplayInfo()

        AssignedCourse(PassedValue)

        LockInStatusCheck()

        AutoRefresher_Timer.Interval = 5000
        AutoRefresher_Timer.Start()

        InstructorsID_TB.Height = 100
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


    ' DROP-DOWN ANIMATION - START
    Dim MenuCollapsed As Boolean = True
    Private Sub Dropdown_Timer_Tick(sender As Object, e As EventArgs) Handles Dropdown_Timer.Tick
        If MenuCollapsed Then

            Menu_Btn.Image = Image.FromFile("D:\Development Projects\Visual Basic\CDM Registrar Management System\CDMRMS_INSTRUCTOR\Assets\Main\Arrow Down.png")
            Dropdown_Panel.Height += 10
            If Dropdown_Panel.Size = Dropdown_Panel.MaximumSize Then

                Dropdown_Timer.Stop()
                MenuCollapsed = False
            End If

        Else

            MyProfile_Panel.Hide()
            StudentGrade_Panel.Hide()
            Menu_Btn.Image = Image.FromFile("D:\Development Projects\Visual Basic\CDM Registrar Management System\CDMRMS_INSTRUCTOR\Assets\Main\Arrow Right.png")
            Dropdown_Panel.Height -= 10
            If Dropdown_Panel.Size = Dropdown_Panel.MinimumSize Then

                Dropdown_Timer.Stop()
                MenuCollapsed = True
            End If

        End If
    End Sub

    Private Sub Menu_Btn_Click(sender As Object, e As EventArgs) Handles Menu_Btn.Click
        Dropdown_Timer.Start()

    End Sub
    ' DROP-DOWN ANIMATION - END



    ' MY ACCOUNT - START
    Public Property PassedValue As String
    Private Sub MyProfile_Btn_Click(sender As Object, e As EventArgs) Handles MyProfile_Btn.Click
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
                                ProfilePic_PicBox.Image = Image.FromFile("D:\Development Projects\Visual Basic\CDM Registrar Management System\CDMRMS_INSTRUCTOR\Assets\Main\Male.png")

                            ElseIf Sex_TB.Text = "Female" Then

                                ProfilePic_PicBox.Image = Image.FromFile("D:\Development Projects\Visual Basic\CDM Registrar Management System\CDMRMS_INSTRUCTOR\Assets\Main\Female.png")
                            End If

                        End If
                    End Using

                Catch ex As Exception

                End Try
            End Using
        End Using
        connection.Close()

    End Sub

    Private Sub Save_Btn_Click(sender As Object, e As EventArgs) Handles Save_Btn.Click

    End Sub
    ' MY ACCOUNT - END



    ' STUDENT GRADE - START
    Private Sub StudentGrade_Btn_Click(sender As Object, e As EventArgs) Handles StudentGrade_Btn.Click

        StudentGrade_Panel.Show()
        MyProfile_Panel.Hide()

    End Sub

    ' Assigned Course Table on Instructors Information  
    Private Sub AssignedCourse(PassedValue)

        ' Display Assigned Course
        Dim CourseQuery As String = "SELECT `course` FROM `assignedcourse` WHERE instructor_id = @instructorid"
        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()

            Using CourseCommand As New MySqlCommand(CourseQuery, connection)
                CourseCommand.Parameters.AddWithValue("@instructorid", PassedValue)
                Dim dataTable As New DataTable()
                dataTable.Load(CourseCommand.ExecuteReader())

                AssignedCourseTable.DataSource = dataTable
                AssignedCourseTable.Columns("course").Width = 201

            End Using

        End Using

    End Sub

    ' Will show the section handled by the instructor when you click the course from the course table on the Instructor Information
    Dim courseValue As String
    Private Sub AssignedCourseTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles AssignedCourseTable.CellClick
        If e.RowIndex >= 0 Then

            Dim selectedRow As DataGridViewRow = AssignedCourseTable.Rows(e.RowIndex)
            courseValue = selectedRow.Cells("course").Value.ToString()

            Dim sectionQuery As String = "SELECT * FROM assignedcourse WHERE course = @course"
            Dim sectionAdapter As New MySqlDataAdapter(sectionQuery, connection)
            sectionAdapter.SelectCommand.Parameters.AddWithValue("@course", courseValue)
            Dim dataTable As New DataTable()
            AssignedSectionTable.RowTemplate.Height = 82
            sectionAdapter.Fill(dataTable)

            AssignedSectionTable.DataSource = dataTable
            AssignedSectionTable.Columns("id").Visible = False
            AssignedSectionTable.Columns("instructor_id").Visible = False
            AssignedSectionTable.Columns("Instructor").Visible = False
            AssignedSectionTable.Columns("course").Visible = False

        End If
    End Sub


    ' Assigned the value of selected cell in Assigned Section Table in Instructor Panel
    Dim sectionValue As String
    Private Sub AssignedSectionTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles AssignedSectionTable.CellClick

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then

            Dim selectedCell As DataGridViewCell = AssignedSectionTable.Rows(e.RowIndex).Cells(e.ColumnIndex)
            sectionValue = selectedCell.Value.ToString()

        End If

    End Sub


    ' Variable declaration for Grade Insertion
    Dim Program As String
    Dim Course As String
    Dim Section As String

    ' View student list button
    Private Sub ViewStudentList_Click(sender As Object, e As EventArgs) Handles ViewStudentList.Click

        dataTable.Clear()
        Program = CollegeProgramSelector.Text.Trim
        Course = courseValue
        Section = sectionValue

        If String.IsNullOrEmpty(Program) And String.IsNullOrEmpty(Course) And String.IsNullOrEmpty(Section) Then

            MsgBox("No Input.", MessageBoxIcon.Error)
        ElseIf String.IsNullOrEmpty(Program) Or String.IsNullOrEmpty(Course) Or String.IsNullOrEmpty(Section) Then
            MsgBox("Please, Select Necessary Information.", MessageBoxIcon.Warning)

        ElseIf Program = "BSIT" Then
            BSITGradeInsertionTable(Course)
            SortSection(Section)

        ElseIf Program = "BSCPE" Then

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
                StudentlistTable.Columns("Section").Width = 150


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
    Private Sub SortSection(Section)

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

        Dim choice As DialogResult = MsgBox("Are you sure you want to submit?", MessageBoxButtons.OKCancel)

        If choice = DialogResult.OK Then

            SaveData()
            dataTable.Clear()
            BSITGradeInsertionTable(Course)
            SortSection(Section)

        ElseIf choice = DialogResult.Cancel Then

            dataTable.Clear()
            BSITGradeInsertionTable(Course)
            SortSection(Section)

        End If

    End Sub

    ' Lock-in Button
    Private Sub LockIn_Btn_Click(sender As Object, e As EventArgs) Handles LockIn_Btn.Click
        Dim InstructorID As String = InstructorsID_TB.Text
        Dim status As Boolean = False
        StudentlistTable.Enabled = status

        Dim query As String = " UPDATE instructors SET Status = @status WHERE instructorid = @instructorid "

        Try
            connection.Open()

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@status", status)
                command.Parameters.AddWithValue("@instructorid", InstructorID)
                command.ExecuteNonQuery()

                MsgBox("Grade is already Lock-in.")
                LockIn_Btn.Enabled = False
                SaveGrade_Btn.Enabled = False
                LockInStatusCheck()
            End Using

        Catch ex As Exception

            MsgBox("error" & ex.Message)

        Finally
            connection.Close()

        End Try

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

                        ChangeGradeReq_Btn.Enabled = False

                        Lock_Img.Image = Image.FromFile("D:\Development Projects\Visual Basic\CDM Registrar Management System\CDMRMS_INSTRUCTOR\Assets\Main\Unlocked Icon.png")
                        LockStatus_Label.Text = "THE TABLE IS" & vbCrLf & " UNLOCKED"
                        LockInstruction_Label.Text = "You are now able to" & vbCrLf & "insert grades into the " & vbCrLf & "table."


                        StudentlistTable.RowsDefaultCellStyle.SelectionBackColor = Color.Yellow
                    Else

                        StudentlistTable.Enabled = False
                        LockIn_Btn.Enabled = False
                        SaveGrade_Btn.Enabled = False

                        ChangeGradeReq_Btn.Enabled = True

                        Lock_Img.Image = Image.FromFile("D:\Development Projects\Visual Basic\CDM Registrar Management System\CDMRMS_INSTRUCTOR\Assets\Main\Locked Icon.png")
                        LockStatus_Label.Text = "THE TABLE IS" & vbCrLf & " LOCKED"
                        LockInstruction_Label.Text = "Send a request to the " & vbCrLf & " admin in order to be " & vbCrLf & " able to insert grades."


                        StudentlistTable.RowsDefaultCellStyle.SelectionBackColor = Color.White

                    End If
                End If
            End Using

        Catch ex As Exception

        Finally
            connection.Close()

        End Try

    End Sub


    ' Reload Every 10 seconds to check if the admin already approved the request
    Private Sub AutoRefresher_Timer_Tick(sender As Object, e As EventArgs) Handles AutoRefresher_Timer.Tick
        LockInStatusCheck()
        AssignedCourse(PassedValue)
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

        Dim choice As DialogResult = MsgBox("Are you sure?", MessageBoxButtons.OKCancel)

        If choice = DialogResult.OK Then

            Me.Close()
            CDMRMS_Instructor_Login.Show()

        End If
    End Sub




    ' LOGOUT - END

End Class