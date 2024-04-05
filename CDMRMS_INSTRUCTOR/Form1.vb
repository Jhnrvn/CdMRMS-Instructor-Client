Public Class CDMRMS_Instructor_Login
    Private Sub CDMRMS_Instructor_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' DATABASE CONNECTION


    ' REGISTRATION 
    Private Sub Register_Btn_Click(sender As Object, e As EventArgs) Handles Register_Btn.Click

        ' Variable declaration for registration
        Dim firstName As String = FN_Input.Text.Trim
        Dim middleName As String = MN_Input.Text.Trim
        Dim lastName As String = LN_Input.Text.Trim
        Dim instructorID As String = InstructorID_Input.Text.Trim
        Dim institute As String = ""
        Dim contact As String = Contact_Input.Text.Trim
        Dim password As String = Password_Input.Text.Trim
        Dim password2 As String = Password2_Input.Text.Trim

        ' Check if all needed information are fill-out
        If String.IsNullOrEmpty(firstName) And String.IsNullOrEmpty(middleName) And String.IsNullOrEmpty(lastName) And String.IsNullOrEmpty(instructorID) And String.IsNullOrEmpty(contact) And String.IsNullOrEmpty(password) And String.IsNullOrEmpty(password2) Then
            MsgBox("Please enter all needed information", MessageBoxIcon.Warning)
        ElseIf String.IsNullOrEmpty(firstName) Or String.IsNullOrEmpty(middleName) Or String.IsNullOrEmpty(lastName) Or String.IsNullOrEmpty(instructorID) Or String.IsNullOrEmpty(contact) Or String.IsNullOrEmpty(password) Or String.IsNullOrEmpty(password2) Then
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
            Else
                MsgBox("Please select your institute.", MessageBoxIcon.Warning)
            End If

        End If
    End Sub
End Class
