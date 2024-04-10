Public Class Instructor_Main


    Private Sub Instructor_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dropdown_Panel.Size = Dropdown_Panel.MinimumSize

        MyProfile_Panel.Hide()
    End Sub

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

    Private Sub MyProfile_Btn_Click(sender As Object, e As EventArgs) Handles MyProfile_Btn.Click
        MyProfile_Panel.Show()
    End Sub
End Class