﻿Public Class DropNotify
    Dim x, y As Integer
    Dim loopevent As Integer = 6

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not y <= Screen.PrimaryScreen.WorkingArea.Height - Me.Height Then
            y -= 5
            Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width - 5, y)
        Else
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If loopevent <= 0 Then
        Else
            Button1.Text = "Dismiss (" & (loopevent - 1).ToString & ")"
        End If

        If loopevent = 0 Then
            loopevent = 0
            Timer1.Stop()
            Timer3.Enabled = True
            Timer3.Start()
        Else
            loopevent -= 1
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If y <= Screen.PrimaryScreen.WorkingArea.Height + Me.Height Then
            y += 5
            Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width - 5, y)
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Stop()
        Timer3.Enabled = True
        Timer3.Start()
    End Sub

    Private Sub DropNotify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.MaximumSize = New Size(300, 0)
        x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
        y = Screen.PrimaryScreen.WorkingArea.Height
        'Me.Location = New Point(x, y)
        Me.TopMost = True
        'Timer1.Start()
    End Sub
End Class