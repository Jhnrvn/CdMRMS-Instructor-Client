Imports MySql.Data.MySqlClient

Public Class Course_Handled_Menu



    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Hide()
        Instructor_Main.Enabled = True
        Instructor_Main.Show()

    End Sub
End Class