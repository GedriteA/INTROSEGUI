﻿Public Class wdwNotices
    Dim choice As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Me.Hide()
        wdwGenAbsNotice.Show()
    End Sub

    Private Sub RadAbsence_CheckedChanged(sender As Object, e As EventArgs) Handles RadAbsence.CheckedChanged
        choice = 1
    End Sub

    Private Sub RadTardiness_CheckedChanged(sender As Object, e As EventArgs) Handles RadTardiness.CheckedChanged
        choice = 2
    End Sub

    Private Sub RadService_CheckedChanged(sender As Object, e As EventArgs) Handles RadService.CheckedChanged
        choice = 3
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        wdwMainMenu.Show()

    End Sub

    Private Sub wdwNotices_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class