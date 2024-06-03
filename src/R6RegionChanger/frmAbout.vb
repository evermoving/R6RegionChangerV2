Option Strict On
Public Class frmAbout

#Region "frmLoad"

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCopyright.Text = String.Format("Copyright © Passlick Development {0}. All rights reserved.", My.Computer.Clock.LocalTime.Year)
    End Sub

#End Region

#Region "Links"

    Private Sub pbPD_Click(sender As Object, e As EventArgs)
        Process.Start("https://passlickdev.com")
    End Sub

    Private Sub llblUpdates_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start("https://pdev.me/r6tool")
    End Sub

    Private Sub frmAbout_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        Process.Start("https://passlickdev.com/support")
    End Sub

    Private Sub lblVersion_Click(sender As Object, e As EventArgs)

    End Sub

#End Region

End Class