Imports MySql.Data.MySqlClient
Public Class Instructor_Main




    ' FORM LOAD - START
    Private Sub Instructor_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dropdown_Panel.Size = Dropdown_Panel.MinimumSize

        MyProfile_Panel.Hide()
        DisplayInfo()
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

            Dropdown_Panel.Height += 10
            If Dropdown_Panel.Size = Dropdown_Panel.MaximumSize Then

                Dropdown_Timer.Stop()
                MenuCollapsed = False
            End If

        Else

            MyProfile_Panel.Hide()

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
                            Sex_TB.Text = reader("sex").ToString()
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

    Public Sub SetValue(institute As String, program As String, year As String, semester As String, course As String)
        Institute_Tbox.Text = institute
        Program_Tbox.Text = program
        Year_Tbox.Text = year
        Sem_Tbox.Text = semester
        Course_Tbox.Text = course
    End Sub

    Private Sub Send_Btn_Click(sender As Object, e As EventArgs) Handles Send_Btn.Click

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Choose_Btn.Click
        Course_Handled_Menu.Show()
    End Sub
    ' MY PROFILE - END

    ' STUDENT GRADE - START
    Private Sub StudentGrade_Btn_Click(sender As Object, e As EventArgs) Handles StudentGrade_Btn.Click
        MyProfile_Panel.Hide()
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