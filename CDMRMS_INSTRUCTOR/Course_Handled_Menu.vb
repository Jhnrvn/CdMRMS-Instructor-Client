Imports System.Diagnostics.PerformanceData
Imports MySql.Data.MySqlClient

Public Class Course_Handled_Menu


    Private Sub ICS_Click(sender As Object, e As EventArgs) Handles ICS.Click, BSIT.Click, IT1stYr.Click, IT1stYr1stSem.Click, IT_ITCOMP.Click, IT_PROG1.Click, IT_GE2.Click, IT_GEMATH.Click, IT_GE1.Click, IT_GEFIL1.Click, IT_PE1.Click, IT_NSTP1.Click, IT2ndYr.Click, IT3rdYr.Click, IT4thYr.Click, BSCPE.Click

        Dim clickItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

        ' Instute Value
        If clickItem Is ICS Then
            Institute_Value.Text = ICS.Text
        End If

        ' College Program Value
        If clickItem Is BSIT Then
            Program_Value.Text = BSIT.Text
        ElseIf clickItem Is BSCPE Then
            Program_Value.Text = BSCPE.Text
        End If

        ' Year Level Value
        If clickItem Is IT1stYr Then
            Yr_Value.Text = IT1stYr.Text
        ElseIf clickItem Is IT2ndYr Then
            Yr_Value.Text = IT2ndYr.Text
        ElseIf clickItem Is IT3rdYr Then
            Yr_Value.Text = IT3rdYr.Text
        ElseIf clickItem Is IT4thYr Then
            Yr_Value.Text = IT4thYr.Text
        End If

        ' Semester Value
        If clickItem Is IT1stYr1stSem Then
            Sem_Value.Text = IT1stYr1stSem.Text
        ElseIf clickItem Is IT1stYr2ndSem Then
            Sem_Value.Text = IT1stYr2ndSem.Text
        End If

        ' Course Value
        If clickItem Is IT_ITCOMP Then
            Course_Value.Text = IT_ITCOMP.Text
        ElseIf clickItem Is IT_PROG1 Then
            Course_Value.Text = IT_PROG1.Text
        ElseIf clickItem Is IT_GE2 Then
            Course_Value.Text = IT_GE2.Text
        ElseIf clickItem Is IT_GEMATH Then
            Course_Value.Text = IT_GEMATH.Text
        ElseIf clickItem Is IT_GE1 Then
            Course_Value.Text = IT_GE1.Text
        ElseIf clickItem Is IT_GEFIL1 Then
            Course_Value.Text = IT_GEFIL1.Text
        ElseIf clickItem Is IT_PE1 Then
            Course_Value.Text = IT_PE1.Text
        ElseIf clickItem Is IT_NSTP1 Then
            Course_Value.Text = IT_NSTP1.Text

        End If
    End Sub


    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Hide()
    End Sub



    Private Sub Ok_Click(sender As Object, e As EventArgs) Handles Ok.Click
        Dim instituteValue As String = Institute_Value.Text
        Dim programValue As String = Program_Value.Text
        Dim yearValue As String = Yr_Value.Text
        Dim semValue As String = Sem_Value.Text
        Dim courseValue As String = Course_Value.Text

        Dim mainInstance As Instructor_Main = Application.OpenForms("Instructor_Main")

        mainInstance?.SetValue(instituteValue, programValue, yearValue, semValue, courseValue)

        Me.Close()

    End Sub


End Class