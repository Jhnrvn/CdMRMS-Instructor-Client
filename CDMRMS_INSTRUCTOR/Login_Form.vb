Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class CDMRMS_Instructor_Login

    Private Sub CDMRMS_Instructor_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatabaseConnection()
    End Sub

    ' DATABASE CONNECTION
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

    ' PASSWORD HASHING 
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

    ' REGISTRATION 
    Private Sub Register_Btn_Click(sender As Object, e As EventArgs) Handles Register_Btn.Click

        ' Variable declaration for registration
        Dim firstName As String = FN_Input.Text.Trim
        Dim middleName As String = MN_Input.Text.Trim
        Dim lastName As String = LN_Input.Text.Trim
        Dim instructorID As String = InstructorID_Input.Text.Trim
        Dim institute As String = ""
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
            ElseIf IOB_RadioBtn.Checked Then
                institute = IOB_RadioBtn.Text
            ElseIf ITE_RadioBtn.Checked Then
                institute = ITE_RadioBtn.Text
            ElseIf Not ICS_RadioBtn.Checked Or Not IOB_RadioBtn.Checked Or Not ITE_RadioBtn.Checked Then
                MsgBox("Please select your institute.", MessageBoxIcon.Warning)
            Else
                InsertRegistrationData(firstName, middleName, lastName, instructorID, institute, email, contact, password)

            End If

        End If
    End Sub

    ' Insertion of validated Data to database
    Private Sub InsertRegistrationData(firstName As String, middleName As String, lastName As String, instructorID As String, institute As String, email As String, contact As String, password As String)

        Dim hashedPassword As String = HashPassword(password)

        ' Insert Data to database
        Dim regInsert As String = "INSERT INTO `instructors`(`firstname`, `middlename`, `lastname`, `instructorid`, `institute`, `email`, `contact#`, `password`) VALUES (@firstname, @middlename, @lastname, @instructorid, @institute, @email, @contact#, @password)"

        Try
            Using connection As New MySqlConnection(ConnectionString)
                Using regInsertCommand As New MySqlCommand(regInsert, connection)

                    ' Store all user Data to Database
                    regInsertCommand.Parameters.AddWithValue("@firstname", firstName)
                    regInsertCommand.Parameters.AddWithValue("@middlename", middleName)
                    regInsertCommand.Parameters.AddWithValue("@lastname", lastName)
                    regInsertCommand.Parameters.AddWithValue("@instructorid", instructorID)
                    regInsertCommand.Parameters.AddWithValue("@institute", institute)
                    regInsertCommand.Parameters.AddWithValue("@email", email)
                    regInsertCommand.Parameters.AddWithValue("@contact#", contact)
                    regInsertCommand.Parameters.AddWithValue("@password", hashedPassword)

                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(regInsertCommand.ExecuteScalar())
                    MsgBox("Register Successfully!.", MessageBoxIcon.Information)

                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub

End Class
