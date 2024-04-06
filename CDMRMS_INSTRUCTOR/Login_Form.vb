Imports MetroFramework.Controls
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class CDMRMS_Instructor_Login


    ' FORM LOAD - START
    Private Sub CDMRMS_Instructor_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatabaseConnection()
        Registration_Panel.Hide()
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


    ' PASSWORD HASHING - START
    Private Function HashPassword(password As String) As String
        ' Create a new instance of SHA256
        Using SHA256 As SHA256 = SHA256.Create()
            ' ComputeHash - returns byte array
            Dim bytes As Byte() = SHA256.ComputeHash(Encoding.UTF8.GetBytes(password))
            ' Convert byte array to string
            Dim builder As New StringBuilder()

            For i As Integer = 0 To bytes.Length - 1
                builder.Append(bytes(i).ToString("x2"))
            Next
            Return builder.ToString()

        End Using

    End Function
    ' PASSWORD HASHING - END


    ' REGISTRATION - START
    Private Sub Register_Btn_Click(sender As Object, e As EventArgs) Handles Register_Btn.Click

        ' Variable declaration for registration
        Dim firstName As String = FN_Input.Text.Trim
        Dim middleName As String = MN_Input.Text.Trim
        Dim lastName As String = LN_Input.Text.Trim
        Dim instructorID As String = InstructorID_Input.Text.Trim
        Dim institute As String
        Dim email As String = Email_Input.Text.Trim
        Dim contact As String = Contact_Input.Text.Trim
        Dim password As String = Password_Input.Text.Trim
        Dim password2 As String = Password2_Input.Text.Trim

        ' Check if all needed information are fill-out
        If String.IsNullOrEmpty(firstName) And String.IsNullOrEmpty(middleName) And String.IsNullOrEmpty(lastName) And String.IsNullOrEmpty(instructorID) And String.IsNullOrEmpty(contact) And String.IsNullOrEmpty(email) And String.IsNullOrEmpty(password) And String.IsNullOrEmpty(password2) Then
            MsgBox("Please enter all needed information", MessageBoxIcon.Warning)
        ElseIf String.IsNullOrEmpty(firstName) Or String.IsNullOrEmpty(middleName) Or String.IsNullOrEmpty(lastName) Or String.IsNullOrEmpty(instructorID) Or String.IsNullOrEmpty(contact) Or String.IsNullOrEmpty(email) Or String.IsNullOrEmpty(password) Or String.IsNullOrEmpty(password2) Then
            MsgBox("Please fill all missing information", MessageBoxIcon.Warning)
        ElseIf password <> password2 Then
            MsgBox("Password does'nt match.", MessageBoxIcon.Information)
        Else

            If ICS_RadioBtn.Checked Then
                institute = ICS_RadioBtn.Text
                If Not IsDataExists(instructorID) Then
                    InsertRegistrationData(firstName, middleName, lastName, instructorID, institute, email, contact, password)
                Else
                    MsgBox("Data already exists in the database.")
                End If

            ElseIf IOB_RadioBtn.Checked Then
                institute = IOB_RadioBtn.Text
                InsertRegistrationData(firstName, middleName, lastName, instructorID, institute, email, contact, password)

            ElseIf ITE_RadioBtn.Checked Then
                institute = ITE_RadioBtn.Text
                InsertRegistrationData(firstName, middleName, lastName, instructorID, institute, email, contact, password)

            ElseIf Not ICS_RadioBtn.Checked Or Not IOB_RadioBtn.Checked Or Not ITE_RadioBtn.Checked Then
                MsgBox("Please select your institute.", MessageBoxIcon.Warning)

            End If
        End If
    End Sub

    ' Only accept number and dash
    Private Sub InstructorID_Input_KeyPress(sender As Object, e As KeyPressEventArgs) Handles InstructorID_Input.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "-"c Then
            If Not Char.IsControl(e.KeyChar) Then
                e.Handled = True

            End If
        ElseIf e.KeyChar = "-"c AndAlso DirectCast(sender, MetroTextBox).Text.Contains("-") Then
            e.Handled = True

        End If
    End Sub

    ' Check if the data is already existing in database
    Private Function IsDataExists(instructorID As String) As Boolean

        Dim query As String = "SELECT COUNT(*) FROM `instructors` WHERE instructorID = @instructorID"
        Dim command As New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@instructorID", instructorID)

        connection.Open()
        Dim count As String = CInt(command.ExecuteScalar())
        connection.Close()

        Return count > 0

    End Function

    ' Insertion of validated Data to database
    Private Sub InsertRegistrationData(firstName As String, middleName As String, lastName As String, instructorID As String, institute As String, email As String, contact As String, password As String)

        Dim hashedPassword As String = HashPassword(password)

        ' Insert Data to database
        Dim query As String = "INSERT INTO `instructors`(`firstname`, `middlename`, `lastname`, `instructorid`, `institute`, `email`, `contact#`, `password`) VALUES (@firstname, @middlename, @lastname, @instructorid, @institute, @email, @contact, @password) "

        Try
            Using connection As New MySqlConnection(ConnectionString)
                Using command As New MySqlCommand(query, connection)

                    ' Store all user Data to Database
                    command.Parameters.AddWithValue("@firstname", firstName)
                    command.Parameters.AddWithValue("@middlename", middleName)
                    command.Parameters.AddWithValue("@lastname", lastName)
                    command.Parameters.AddWithValue("@instructorid", instructorID)
                    command.Parameters.AddWithValue("@institute", institute)
                    command.Parameters.AddWithValue("@email", email)
                    command.Parameters.AddWithValue("@contact", contact)
                    command.Parameters.AddWithValue("@password", hashedPassword)

                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    MsgBox("Register Successfully!.", MessageBoxIcon.Information)
                    Login_Panel.Show()
                    Registration_Panel.Hide()


                    ' Clear all registrtion input fields
                    FN_Input.Clear()
                    MN_Input.Clear()
                    LN_Input.Clear()
                    InstructorID_Input.Clear()
                    If ICS_RadioBtn.Checked Then
                        ICS_RadioBtn.Checked = False
                    ElseIf IOB_RadioBtn.Checked Then
                        IOB_RadioBtn.Checked = False
                    ElseIf ITE_RadioBtn.Checked Then
                        ITE_RadioBtn.Checked = False
                    End If
                    Email_Input.Clear()
                    Contact_Input.Clear()
                    Password_Input.Clear()
                    Password2_Input.Clear()

                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub Register_Link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Register_Link.LinkClicked
        Registration_Panel.Show()
        Login_Panel.Hide()
    End Sub
    ' REGISTRATION - END


    ' LOGIN - START
    Private Sub Login_Btn_Click(sender As Object, e As EventArgs) Handles Login_Btn.Click

        Dim instructorID As String = LoginInstructorID_Input.Text.Trim
        Dim email As String = LoginEmail_Input.Text.Trim
        Dim password As String = LoginPassword_Input.Text.Trim

        If String.IsNullOrEmpty(instructorID) And String.IsNullOrEmpty(email) And String.IsNullOrEmpty(password) Then
            MsgBox("login invalid.", MessageBoxIcon.Warning)
        ElseIf String.IsNullOrEmpty(instructorID) Or String.IsNullOrEmpty(email) Or String.IsNullOrEmpty(password) Then
            MsgBox("Please fill in all neded information.", MessageBoxIcon.Warning)
        Else
            Dim isValidLogin As Boolean = ValidateLogin(instructorID, email, password)

            If isValidLogin Then
                MsgBox("Login successful!.", MessageBoxIcon.Information)
                LoginInstructorID_Input.Clear()
                LoginEmail_Input.Clear()
                LoginPassword_Input.Clear()

                Instructor_Main.Show()
                Me.Hide()

            Else
                MsgBox("Login failed.", MessageBoxIcon.Error)
            End If
        End If

    End Sub

    ' Only accept number and dash
    Private Sub LoginInstructorID_Input_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LoginInstructorID_Input.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "-"c Then
            If Not Char.IsControl(e.KeyChar) Then
                e.Handled = True

            End If
        ElseIf e.KeyChar = "-"c AndAlso DirectCast(sender, MetroTextBox).Text.Contains("-") Then
            e.Handled = True

        End If
    End Sub

    ' Validate login information
    Private Function ValidateLogin(instructorID As String, email As String, password As String) As String

        Dim hashedPassword As String = HashPassword(password)
        Dim isAuthenticated As Boolean = False

        Dim query As String = "SELECT * FROM `instructors` WHERE instructorid = @instructorID AND email = @email AND password = @password"
        Using connection As New MySqlConnection(ConnectionString)
            Using command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@instructorID", instructorID)
                command.Parameters.AddWithValue("@email", email)
                command.Parameters.AddWithValue("@password", hashedPassword)

                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                isAuthenticated = count > 0
            End Using
        End Using
        Return isAuthenticated

    End Function

    Private Sub Login_Link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Login_Link.LinkClicked
        Login_Panel.Show()
        Registration_Panel.Hide()
    End Sub

    ' LOGIN - END


End Class
