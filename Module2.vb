Imports System.Data.SqlClient
Module Module2
    Public con As New SqlConnection("Data Source=marcel-pc\sqlexpress;Initial Catalog=cinema;Integrated Security=True")
    Public cmd As New Data.SqlClient.SqlCommand
End Module
