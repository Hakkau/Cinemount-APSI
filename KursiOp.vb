Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.Devices

Public Class KursiOp

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim lol1 As New Payment
        movie = Label79.Text
        studio = Label65.Text
        showtime = ComboBox9.Text
        tanggal = DateTimePicker2.Text
        day = ComboBox6.Text
        seat1 = ComboBox8.Text
        seat2 = ComboBox7.Text
        lol1.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If ComboBox4.Text = "QR" Then
                Dim qr1 As New FormQR
                AddHandler qr1.FormClosed, AddressOf QRFormClosed
                qr1.Show()
            Else
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO payment (film, studio, showtime, day, date, kursi, payment_method) VALUES (@film, @studio, @showtime, @day, @date, @kursi, @payment_method)"
                cmd.Connection = con

                ' Add parameters
                cmd.Parameters.AddWithValue("@film", Label79.Text)
                cmd.Parameters.AddWithValue("@studio", Label65.Text)
                cmd.Parameters.AddWithValue("@showtime", ComboBox9.Text)
                cmd.Parameters.AddWithValue("@day", ComboBox6.Text)
                cmd.Parameters.AddWithValue("@date", DateTimePicker2.Value)
                cmd.Parameters.AddWithValue("@kursi", ComboBox8.Text + ComboBox7.Text)
                cmd.Parameters.AddWithValue("@payment_method", ComboBox4.Text)

                MessageBox.Show("Booking Tiket Telah Berhasil Silahkan Cetak Ticket", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If

                cmd.ExecuteNonQuery()
                con.Close()
            End If
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub QRFormClosed(sender As Object, e As FormClosedEventArgs)
        Try
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO payment (film, studio, showtime, day, date, kursi, payment_method) VALUES (@film, @studio, @showtime, @day, @date, @kursi, @payment_method)"
            cmd.Connection = con

            ' Add parameters
            cmd.Parameters.AddWithValue("@film", Label79.Text)
            cmd.Parameters.AddWithValue("@studio", Label65.Text)
            cmd.Parameters.AddWithValue("@showtime", ComboBox9.Text)
            cmd.Parameters.AddWithValue("@day", ComboBox6.Text)
            cmd.Parameters.AddWithValue("@date", DateTimePicker2.Value)
            cmd.Parameters.AddWithValue("@kursi", ComboBox8.Text + ComboBox7.Text)
            cmd.Parameters.AddWithValue("@payment_method", ComboBox4.Text)

            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class