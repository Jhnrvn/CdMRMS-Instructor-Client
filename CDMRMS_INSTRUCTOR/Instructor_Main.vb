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
    Private Sub ViewStudentList_Click(sender As Object, e As EventArgs) Handles ViewStudentList.Click

        Dim Program As String = CollegeProgramSelector.Text
        Dim Course As String = courseValue
        Dim Section As String = sectionValue

        If String.IsNullOrEmpty(Program) And String.IsNullOrEmpty(Course) And String.IsNullOrEmpty(Section) Then

            MsgBox("error")
        ElseIf String.IsNullOrEmpty(Program) Or String.IsNullOrEmpty(Course) Or String.IsNullOrEmpty(Section) Then
            MsgBox("error too")
        Else
            If Program = "BSIT" Then

                Try
                    connection.Open()

                    Dim SelectQuery As String = ""

                    If Course = "ITCOMP" Then
                        SelectQuery = "SELECT `Student ID`,`Student Name`, `Program`, `ITCOMP` FROM bsit"

                    ElseIf Course = "PROG 1" Then
                        SelectQuery = "SELECT `Student ID`,`Student Name`, `Program`, `PROG 1` FROM bsit"

                    ElseIf Course = "GE 2" Then
                        SelectQuery = "SELECT `Student ID`,`Student Name`, `Program`, `GE 2` FROM bsit"

                    ElseIf Course = "GE MATH" Then
                        SelectQuery = "SELECT `Student ID`,`Student Name`, `Program`, `GE MATH` FROM bsit"

                    ElseIf Course = "GE 1" Then
                        SelectQuery = "SELECT `Student ID`,`Student Name`, `Program`, `GE 1` FROM bsit"

                    ElseIf Course = "GE FIL 1" Then
                        SelectQuery = "SELECT `Student ID`,`Student Name`, `Program`, `GE FIL 1` FROM bsit"

                    ElseIf Course = "PE 1" Then
                        SelectQuery = "SELECT `Student ID`,`Student Name`, `Program`, `PE 1` FROM bsit"

                    ElseIf Course = "NSTP 1" Then
                        SelectQuery = "SELECT `Student ID`,`Student Name`, `Program`, `NSTP 1` FROM bsit"

                    End If


                    Dim command As New MySqlCommand(selectQuery, connection)


                    Dim datatable As New DataTable()
                    Using adapter As New MySqlDataAdapter(command)

                        adapter.Fill(datatable)
                        StudentlistTable.DataSource = datatable
                        StudentlistTable.Columns("Student Name").Width = 200

                    End Using


                Catch ex As Exception
                    MessageBox.Show("Error fetching data: " & ex.Message)
                Finally
                    connection.Close()
                End Try


            End If
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