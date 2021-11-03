Imports MySql.Data.MySqlClient
Public Class Historiques
    Dim myconection As New DTconnection
    Dim objdatapter As MySqlDataAdapter
    Dim Command As MySqlCommand
    Dim Reader As MySqlDataReader
    Dim tab_debit As New DataTable
    Dim tab_niv As New DataTable
    Dim tab_Freq1 As New DataTable
    Dim tab_Freq2 As New DataTable
    Dim tab_Freq3 As New DataTable

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub loadData_Click(sender As Object, e As EventArgs) Handles loadData.Click
        objdatapter = New MySqlDataAdapter("  SELECT * FROM `niveau_bache` ", myconection.open())
        objdatapter.Fill(tab_niv)
        DataGridView1.DataSource = tab_niv

        objdatapter = New MySqlDataAdapter("  SELECT * FROM `debit_bache` ", myconection.open)
        objdatapter.Fill(tab_debit)
        DataGridView2.DataSource = tab_debit

        objdatapter = New MySqlDataAdapter("  SELECT * FROM `freq_p1`  ", myconection.open)
        objdatapter.Fill(tab_Freq1)
        DataGridView3.DataSource = tab_Freq1

        objdatapter = New MySqlDataAdapter("  SELECT * FROM `freq_p2`  ", myconection.open)
        objdatapter.Fill(tab_Freq2)
        DataGridView4.DataSource = tab_Freq2

        objdatapter = New MySqlDataAdapter("  SELECT * FROM `freq_p3` ", myconection.open)
        objdatapter.Fill(tab_Freq3)
        DataGridView5.DataSource = tab_Freq3

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DataGridView5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class