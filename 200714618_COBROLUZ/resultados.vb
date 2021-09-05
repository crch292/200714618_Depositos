Public Class resultados
    Private Sub listipotarifa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listipotarifa.SelectedIndexChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
        Form1.tnombre.Enabled = False
        Form1.tnit.Enabled =False
        Form1.tsaldoanterior.Enabled = False
        Form1.tconsumo.Enabled = False
        Form1.chservicio.Enabled = False
        Form1.chtarifa.Enabled = False
    End Sub
End Class