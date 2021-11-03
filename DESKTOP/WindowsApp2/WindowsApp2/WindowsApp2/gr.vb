Public Class gr
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Graphs.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub gr_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class