Imports MySql.Data.MySqlClient
Public Class Synomptique
    Dim myconection As New DTconnection
    Dim objdatapter As MySqlDataAdapter
    Dim dtable_nivbach As New DataTable
    Dim dtable_defP1 As New DataTable
    Dim dtable_defP2 As New DataTable
    Dim dtable_defP3 As New DataTable
    Dim dtable_mP1 As New DataTable
    Dim dtable_mP2 As New DataTable
    Dim dtable_mP3 As New DataTable
    Dim Command As MySqlCommand
    Dim Reader As MySqlDataReader
    Dim Readerm2 As MySqlDataReader
    Dim Readerm3 As MySqlDataReader
    Dim Readera1 As MySqlDataReader
    Dim Readera2 As MySqlDataReader
    Dim Readera3 As MySqlDataReader
    Dim Readermanu1 As MySqlDataReader
    Dim Readermanu2 As MySqlDataReader
    Dim Readermanu3 As MySqlDataReader
    Dim Readerauto1 As MySqlDataReader
    Dim Readerauto2 As MySqlDataReader
    Dim Readerauto3 As MySqlDataReader
    Dim regDate As Date = Date.Now()

    Dim strDate As String = regDate.ToString("yyyy\/dd\/MM")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Timer1.Start()
        objdatapter = New MySqlDataAdapter(" SELECT `valeur_NB` FROM `niveau_bache` ORDER BY id_nv DESC LIMIT 1 ", myconection.open())
        objdatapter.Fill(dtable_nivbach)

        ProgressBar1.Value = (dtable_nivbach(0)(0) * 100) / 5
        PictureBox2.Height = 200 - ProgressBar1.Value * 2



        objdatapter = New MySqlDataAdapter(" SELECT `valeur_def2` FROM `def_p2` ORDER BY id_def2 DESC LIMIT 1 ", myconection.open())
        objdatapter.Fill(dtable_defP2)

        If dtable_defP2(0)(0) = True Then
            P2.BackColor = Color.Red
        End If
        myconection.close()
        objdatapter = New MySqlDataAdapter(" SELECT `valeur_def1` FROM `def_p1` ORDER BY id_def1 DESC LIMIT 1 ", myconection.open())
        objdatapter.Fill(dtable_defP1)


        If dtable_defP1(0)(0) = True Then
            P1.BackColor = Color.Red
        End If
        myconection.close()
        objdatapter = New MySqlDataAdapter(" SELECT `valeur_def3` FROM `def_p3` ORDER BY id_def3 DESC LIMIT 1 ", myconection.open())
        objdatapter.Fill(dtable_defP3)

        If dtable_defP3(0)(0) = True Then
            P3.BackColor = Color.Red
        End If
        myconection.close()
        objdatapter = New MySqlDataAdapter(" SELECT `valeur_M_A_p1` FROM `m_a_p1` ORDER BY Id_M_A_p1 DESC LIMIT 1 ", myconection.open())
        objdatapter.Fill(dtable_mP1)

        If dtable_mP1(0)(0) = True Then
            P1.BackColor = Color.Green

        End If
        myconection.close()
        objdatapter = New MySqlDataAdapter(" SELECT `valeur_M_A_p2` FROM `m_a_p2` ORDER BY Id_M_A_p2 DESC LIMIT 1 ", myconection.open())
        objdatapter.Fill(dtable_mP2)

        If dtable_mP2(0)(0) = True Then
            P2.BackColor = Color.Green

        End If
        myconection.close()
        objdatapter = New MySqlDataAdapter(" SELECT `valeur_M_A_p3` FROM `m_a_p3` ORDER BY Id_M_A_p3 DESC LIMIT 1 ", myconection.open())
        objdatapter.Fill(dtable_mP3)

        If dtable_mP3(0)(0) = True Then
            P3.BackColor = Color.Green

        End If
        myconection.close()

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Synomptique_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        regDate = Format(Now(), "yyyy-MM-dd")
        Command = New MySqlCommand(" INSERT INTO `test2`.`auto_manu_p2` (`id_auto_p2`, `valeur_auto_p2`, `t_auto_p2`) VALUES (NULL, '1', ' " & DateTimePicker1.Text & "'); ", myconection.open())
        Readerm2 = Command.ExecuteReader
        myconection.close()

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        regDate = Format(Now(), "yyyy-MM-dd")
        Command = New MySqlCommand(" INSERT INTO `test2`.`auto_manu_p2` (`id_auto_p2`, `valeur_auto_p2`, `t_auto_p2`) VALUES (NULL, '0', ' " & DateTimePicker1.Text & "'); ", myconection.open())
        Readera2 = Command.ExecuteReader
        myconection.close()
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        regDate = Format(Now(), "yyyy-MM-dd")
        Command = New MySqlCommand(" INSERT INTO `test2`.`auto_manu_p3` (`id_auto_p3`, `valeur_auto_p3`, `t_auto_p3`) VALUES (NULL, '1', ' " & DateTimePicker1.Text & "'); ", myconection.open())
        Readerm3 = Command.ExecuteReader
        myconection.close()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        regDate = Format(Now(), "yyyy-MM-dd")
        Command = New MySqlCommand(" INSERT INTO `test2`.`auto_manu_p3` (`id_auto_p3`, `valeur_auto_p3`, `t_auto_p3`) VALUES (NULL, '0', ' " & DateTimePicker1.Text & "'); ", myconection.open())
        Readera3 = Command.ExecuteReader
        myconection.close()
    End Sub

    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs) Handles GroupBox6.Enter

    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        regDate = Format(Now(), "yyyy-MM-dd")
        Command = New MySqlCommand(" INSERT INTO `test2`.`m_a_p2` (`Id_M_A_p2`, `valeur_M_A_p2` , `t_M_A_p2`) VALUES (NULL, '1', ' " & DateTimePicker1.Text & "'); ", myconection.open())
        Readermanu2 = Command.ExecuteReader
        myconection.close()
    End Sub

    Private Sub GroupBox7_Enter(sender As Object, e As EventArgs) Handles GroupBox7.Enter

    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        regDate = Format(Now(), "yyyy-MM-dd")
        Command = New MySqlCommand(" INSERT INTO `test2`.`m_a_p1` (`Id_M_A_p1`, `valeur_M_A_p1` , `t_M_A_p1`) VALUES (NULL, '1', ' " & DateTimePicker1.Text & "'); ", myconection.open())
        Reader = Command.ExecuteReader
        myconection.close()

    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        regDate = Format(Now(), "yyyy-MM-dd")
        Command = New MySqlCommand(" INSERT INTO `test2`.`m_a_p1` (`Id_M_A_p1`, `valeur_M_A_p1` , `t_M_A_p1`) VALUES (NULL, '0', ' " & DateTimePicker1.Text & "'); ", myconection.open())
        Readera1 = Command.ExecuteReader
        myconection.close()
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        regDate = Format(Now(), "yyyy-MM-dd")
        Command = New MySqlCommand(" INSERT INTO `test2`.`m_a_p2` (`Id_M_A_p2`, `valeur_M_A_p2` , `t_M_A_p2`) VALUES (NULL, '0', ' " & DateTimePicker1.Text & "'); ", myconection.open())
        Readerauto2 = Command.ExecuteReader
        myconection.close()
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        regDate = Format(Now(), "yyyy-MM-dd")
        Command = New MySqlCommand(" INSERT INTO `test2`.`m_a_p3` (`Id_M_A_p3`, `valeur_M_A_p3` , `t_M_A_p3`) VALUES (NULL, '1', ' " & DateTimePicker1.Text & "'); ", myconection.open())
        Readerauto3 = Command.ExecuteReader
        myconection.close()
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        regDate = Format(Now(), "yyyy-MM-dd")
        Command = New MySqlCommand(" INSERT INTO `test2`.`m_a_p3` (`Id_M_A_p3`, `valeur_M_A_p3` , `t_M_A_p3`) VALUES (NULL, '0', ' " & DateTimePicker1.Text & "'); ", myconection.open())
        Readermanu3 = Command.ExecuteReader
        myconection.close()
    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        regDate = Format(Now(), "yyyy-MM-dd")
        Command = New MySqlCommand(" INSERT INTO `test2`.`auto_manu_p1` (`id_auto_p1`, `valeur_auto_p1`, `t_auto_p1`) VALUES (NULL, '1', ' " & DateTimePicker1.Text & "'); ", myconection.open())
        Readerauto1 = Command.ExecuteReader
        myconection.close()
    End Sub

    Private Sub RadioButton14_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged
        regDate = Format(Now(), "yyyy-MM-dd")
        Command = New MySqlCommand(" INSERT INTO `test2`.`auto_manu_p1` (`id_auto_p1`, `valeur_auto_p1`, `t_auto_p1`) VALUES (NULL, '0', ' " & DateTimePicker1.Text & "'); ", myconection.open())
        Readermanu1 = Command.ExecuteReader
        myconection.close()
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged

    End Sub





    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class