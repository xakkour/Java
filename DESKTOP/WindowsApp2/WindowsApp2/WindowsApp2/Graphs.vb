Imports MySql.Data.MySqlClient

Public Class Graphs
    Dim myconection As New DTconnection
    Dim objdatapter As MySqlDataAdapter
    Dim Command As MySqlCommand
    Dim Reader As MySqlDataReader
    Dim tab_plot1 As New DataTable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Command = New MySqlCommand(" SELECT * FROM `niveau_bache` ", myconection.open())
        Reader = Command.ExecuteReader

        While Reader.Read
            Chart1.Series("Niveau_VS_temps").Points.AddXY(Reader.GetString("temp_NB"), Reader.GetInt32("valeur_NB"))
        End While

        myconection.close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        gr.Show()
        Me.Close()
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub
End Class