Imports System.Security.Cryptography.X509Certificates

Public Class Form3
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim tiket As New KursiSJ
        tiket.Show()
        Me.Close()

        Dim fm1 As New Form1
        Form1.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim back As New Form1
        Me.Show()
        Me.Close()
    End Sub
End Class