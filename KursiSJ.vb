Public Class KursiSJ
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
                cmd.Parameters.AddWithValue("@film", Label55.Text)
                cmd.Parameters.AddWithValue("@studio", Label56.Text)
                cmd.Parameters.AddWithValue("@showtime", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@day", ComboBox5.Text)
                cmd.Parameters.AddWithValue("@date", DateTimePicker1.Value)
                cmd.Parameters.AddWithValue("@kursi", ComboBox2.Text + ComboBox3.Text)
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
            cmd.Parameters.AddWithValue("@film", Label55.Text)
            cmd.Parameters.AddWithValue("@studio", Label56.Text)
            cmd.Parameters.AddWithValue("@showtime", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@day", ComboBox5.Text)
            cmd.Parameters.AddWithValue("@date", DateTimePicker1.Value)
            cmd.Parameters.AddWithValue("@kursi", ComboBox2.Text + ComboBox3.Text)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim lol1 As New Payment
        movie = Label55.Text
        studio = Label56.Text
        showtime = ComboBox1.Text
        tanggal = DateTimePicker1.Text
        day = ComboBox5.Text
        seat1 = ComboBox2.Text
        seat2 = ComboBox3.Text
        lol1.Show()
        Me.Hide()
    End Sub
End Class