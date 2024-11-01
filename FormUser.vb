Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormUser
    Private Sub Label_MouseHover(sender As Object, e As EventArgs) Handles Label5.MouseHover, Label6.MouseHover, Label7.MouseHover
        Dim hover = DirectCast(sender, Label)
        hover.BackColor = Color.White
    End Sub

    Private Sub Label_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave, Label6.MouseLeave, Label7.MouseLeave
        Dim leave = DirectCast(sender, Label)
        leave.BackColor = Color.DarkGoldenrod
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim film1 As New Form2
        film1.Show()
        'Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim film2 As New Form3
        film2.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim film3 As New Form4
        film3.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim film4 As New Form5
        film4.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim signup As New SignUp
        signup.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim login As New Loginpage
        login.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim nex As New Soon
        nex.Show()
    End Sub
End Class