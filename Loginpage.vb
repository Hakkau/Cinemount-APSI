Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data
Imports System.Data.SqlClient

Public Class Loginpage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim konek As SqlConnection = New SqlConnection("Data Source=marcel-pc\sqlexpress;Initial Catalog=cinema;Integrated Security=True")
        Dim komen As SqlCommand = New SqlCommand("SELECT * FROM account WHERE username='" + TextBox1.Text + "' AND password='" + TextBox2.Text + "'", konek)
        Dim adapt As SqlDataAdapter = New SqlDataAdapter(komen)
        Dim tabeldata As DataTable = New DataTable()
        adapt.Fill(tabeldata)


        If (tabeldata.Rows.Count > 0) Then
            MessageBox.Show("Login Berhasil", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim login As New FormUser
            login.Show()
            Me.Hide()
        Else
            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' Your PictureBox1_Click code here
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
