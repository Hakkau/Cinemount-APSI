Public Class FormQR
    Private Sub FormQR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Your form initialization code goes here
    End Sub

    Private Sub FormQR_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Check if the user is trying to close the form
        If e.CloseReason = CloseReason.UserClosing Then
            ' Show a message box
            MessageBox.Show("Booking Tiket Telah Berhasil Silahkan Cetak Ticket", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Optionally, you can prevent the form from closing
            ' e.Cancel = True
        End If
    End Sub
End Class