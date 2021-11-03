Public Class Form2
    Private Sub Synoptique_Click(sender As Object, e As EventArgs) Handles Synoptique.Click
       Synomptique.Show()
        Me.Hide()
    End Sub

    Private Sub Historique_Click(sender As Object, e As EventArgs) Handles Historique.Click
        Historiques.Show()
        Me.Hide()
    End Sub

    Private Sub Courbe_Click(sender As Object, e As EventArgs) Handles Courbe.Click
        gr.Show()
        Me.Hide()
    End Sub
End Class