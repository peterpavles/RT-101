﻿Imports Microsoft.Win32
Public Class Rgv
    Public Path As String
    Public sock As Integer
    Public Yy As String = "|SPX|"


    Public Function Typ(ByVal t As String) As Integer
        Dim num As Integer
        Dim str As String = t.ToLower
        If (str = RegistryValueKind.Binary.ToString.ToLower) Then
            Return 3
        End If
        If (str = RegistryValueKind.DWord.ToString.ToLower) Then
            Return 4
        End If
        If (str = RegistryValueKind.ExpandString.ToString.ToLower) Then
            Return 2
        End If
        If (str = RegistryValueKind.MultiString.ToString.ToLower) Then
            Return 7
        End If
        If (str = RegistryValueKind.QWord.ToString.ToLower) Then
            Return 11
        End If
        If (str = RegistryValueKind.String.ToString.ToLower) Then
            Return 1
        End If
        Return num
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.S.Send(sock, "RG" & Yy & "!" & Yy & Path & Yy & TextBox1.Text & Yy & TextBox2.Text & Yy & Typ(Me.ComboBox1.Text))
        Me.Close()
    End Sub
End Class