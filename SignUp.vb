Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SignUp
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "Insert Into account Values ('" & TextBox1.Text & "', '" & TextBox2.Text & "')"

            cmd.Connection = con
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Pendaftaran Berhasil", MsgBoxStyle.Information, "add")
            TextBox1.Clear()
            TextBox2.Clear()

            Dim signup As New Loginpage
            signup.Show()
            Me.Hide()
        Catch ex As Exception

            con.Close()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Logintest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class