Imports MySql.Data.MySqlClient


Public Class Form1
#Region “Declares”

    Dim myconection As New DTconnection
    Dim objdatapter As MySqlDataAdapter
    Dim dtable As New DataTable

    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        objdatapter = New MySqlDataAdapter(" SELECT password,`usename` FROM `admin` WHERE   `password`='" & pwd.Text & "' AND `usename`='" & names.Text & "'  ", myconection.open())
        objdatapter.Fill(dtable)

        If dtable.Rows.Count = Nothing Then
            MsgBox("ereuur entrez le bon mot de pass ou le nom de l'utilisateur")
        Else
            MsgBox("bienvenu")

            Form2.Show()
            Me.Hide()

        End If
        myconection.close()

    End Sub

    Private Sub pwd_TextChanged(sender As Object, e As EventArgs) Handles pwd.TextChanged

    End Sub
#End Region
End Class
