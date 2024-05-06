Public Class RequestUpdateGrade
    Private Sub RequestUpdateGrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Close_Btn_Click(sender As Object, e As EventArgs) Handles Close_Btn.Click
        Me.Close()
        Instructor_Main.Enabled = True
    End Sub
End Class