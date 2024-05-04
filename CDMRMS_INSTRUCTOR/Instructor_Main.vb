Imports MySql.Data.MySqlClient


Public Class Instructor_Main


    ' FORM LOAD - START
    Private Sub Instructor_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dropdown_Panel.Size = Dropdown_Panel.MinimumSize

        MyProfile_Panel.Hide()
        StudentGrade_Panel.Hide()
        DisplayInfo()

        Dim id As String = "cdm-1111"
        AssignedCourse(id)
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


    ' MY PROFILE - START
    Public Property PassedValue As String
    Private Sub MyProfile_Btn_Click(sender As Object, e As EventArgs) Handles MyProfile_Btn.Click
        MyProfile_Panel.Show()
        StudentGrade_Panel.Hide()
    End Sub

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

                            InstructorsID_TB.Text = reader("instructorid").ToString()
                            FN_TB.Text = reader("firstname").ToString()
                            MN_TB.Text = reader("middlename").ToString()
                            LN_TB.Text = reader("lastname").ToString()
                            Sex_TB.Text = reader("gender").ToString()
                            CN_TB.Text = reader("contact#").ToString()
                            Birthday_TB.Text = dateOnly.ToString("MM-dd-yyyy")
                            Email_TB.Text = reader("email").ToString()


                        End If
                    End Using

                Catch ex As Exception

                End Try
            End Using
        End Using
        connection.Close()

    End Sub



    Private Sub Send_Btn_Click(sender As Object, e As EventArgs)

    End Sub
    ' MY PROFILE - END



    ' STUDENT GRADE - START
    Private Sub StudentGrade_Btn_Click(sender As Object, e As EventArgs) Handles StudentGrade_Btn.Click

        StudentGrade_Panel.Show()
        MyProfile_Panel.Hide()

    End Sub

    ' Assigned Course Table on Instructors Information  
    Private Sub AssignedCourse(id)

        ' Display Assigned Course
        Dim CourseQuery As String = "SELECT `course` FROM `assignedcourse` WHERE instructor_id = @instructorid"
        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()

            Using CourseCommand As New MySqlCommand(CourseQuery, connection)
                CourseCommand.Parameters.AddWithValue("@instructorid", id)
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


    Dim sectionValue As String
    Private Sub AssignedSectionTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles AssignedSectionTable.CellClick

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then

            Dim selectedCell As DataGridViewCell = AssignedSectionTable.Rows(e.RowIndex).Cells(e.ColumnIndex)
            sectionValue = selectedCell.Value.ToString()

        End If

    End Sub


    ' View student list button

    Dim Program As String
    Dim Course As String
    Dim Section As String

    Private Sub ViewStudentList_Click(sender As Object, e As EventArgs) Handles ViewStudentList.Click
        dataTable.Clear()
        Program = CollegeProgramSelector.Text.Trim
        Course = courseValue
        Section = sectionValue

        If String.IsNullOrEmpty(Program) And String.IsNullOrEmpty(Course) And String.IsNullOrEmpty(Section) Then

            MsgBox("error")
        ElseIf String.IsNullOrEmpty(Program) Or String.IsNullOrEmpty(Course) Or String.IsNullOrEmpty(Section) Then
            MsgBox("error too")

        ElseIf Program = "BSIT" Then
            GradeInsertionTable(Course)
            SortSection(Section)
        Else
            MsgBox("error")

        End If

    End Sub

    Private Sub GradeInsertionTable(Course)
        Try
            connection.Open()

            Dim SelectQuery As String = ""

            ' BSIT First Year 1st Semester Courses
            If Course = "ITCOMP" Then
                SelectQuery = "SELECT `Student ID`,`Student Name`,`Section`, `ITCOMP` FROM bsit"

            ElseIf Course = "PROG 1" Then
                SelectQuery = "SELECT `Student ID`,`Student Name`, `Section`, `PROG 1` FROM bsit"

            ElseIf Course = "GE 2" Then
                SelectQuery = "SELECT `Student ID`,`Student Name`, `Section`, `GE 2` FROM bsit"

            ElseIf Course = "GE MATH" Then
                SelectQuery = "SELECT `Student ID`,`Student Name`, `Section`, `GE MATH` FROM bsit"

            ElseIf Course = "GE 1" Then
                SelectQuery = "SELECT `Student ID`,`Student Name`, `Section`, `GE 1` FROM bsit"

            ElseIf Course = "GE FIL 1" Then
                SelectQuery = "SELECT `Student ID`,`Student Name`, `Section`, `GE FIL 1` FROM bsit"

            ElseIf Course = "PE 1" Then
                SelectQuery = "SELECT `Student ID`,`Student Name`, `Section`, `PE 1` FROM bsit"

            ElseIf Course = "NSTP 1" Then
                SelectQuery = "SELECT `Student ID`,`Student Name`, `Section`, `NSTP 1` FROM bsit"

            End If

            ' BSIT First Year 2nd Semester Courses
            If Course = "DISCRETE" Then
                SelectQuery = "SELECT `Student ID`,`Student Name`,`Section`, `DISCRETE` FROM bsit"

            ElseIf Course = "PROG 2" Then
                SelectQuery = "SELECT `Student ID`,`Student Name`, `Section`, `PROG 2` FROM bsit"

            ElseIf Course = "GE 3" Then
                SelectQuery = "SELECT `Student ID`,`Student Name`, `Section`, `GE 3` FROM bsit"

            ElseIf Course = "HUM" Then
                SelectQuery = "SELECT `Student ID`,`Student Name`, `Section`, `HUM` FROM bsit"

            ElseIf Course = "GE FIL 2" Then
                SelectQuery = "SELECT `Student ID`,`Student Name`, `Section`, `GE FIL 2` FROM bsit"

            ElseIf Course = "GEEL 2" Then
                SelectQuery = "SELECT `Student ID`,`Student Name`, `Section`, `GEEL 2` FROM bsit"

            ElseIf Course = "PE 2" Then
                SelectQuery = "SELECT `Student ID`,`Student Name`, `Section`, `PE 2` FROM bsit"

            ElseIf Course = "NSTP 2" Then
                SelectQuery = "SELECT `Student ID`,`Student Name`, `Section`, `NSTP 2` FROM bsit"

            End If

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


                ' Disable editing all cells under these columns
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


    Private Sub SaveData()

        Dim builder As New MySqlCommandBuilder(adapter)
        adapter.Update(dataTable)

    End Sub

    ' Submit Grade
    Private Sub SubmitGrade_Btn_Click(sender As Object, e As EventArgs) Handles SubmitGrade_Btn.Click

        Dim choice As DialogResult = MsgBox("Are you sure you want to submit?", MessageBoxButtons.OKCancel)

        If choice = DialogResult.OK Then

            SaveData()
            dataTable.Clear()
            GradeInsertionTable(Course)
            SortSection(Section)
            StudentlistTable.Enabled = False

        ElseIf choice = DialogResult.Cancel Then

            dataTable.Clear()
            GradeInsertionTable(Course)
            SortSection(Section)

        End If

    End Sub


    ' STUDENT GRADE - END



    ' LOGOUT - START
    Private Sub Logout_Btn_Click(sender As Object, e As EventArgs) Handles Logout_Btn.Click
        Dim choice As DialogResult = MsgBox("Are you sure?", MessageBoxButtons.OKCancel)

        If choice = DialogResult.OK Then
            Me.Hide()
            CDMRMS_Instructor_Login.Show()
        End If
    End Sub


    ' LOGOUT - END

End Class