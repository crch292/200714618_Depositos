Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        IngresarDatos(tnombre.Text, tnit.Text, tsaldoanterior.Text, tconsumo.Text, chservicio.SelectedItem, chtarifa.SelectedItem)
        ingresarListas()
        Me.Hide()
        resultados.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        limpiar()
        tnombre.Enabled = True
        tnit.Enabled = True
        tsaldoanterior.Enabled = True
        tconsumo.Enabled = True
        chservicio.Enabled = True
        chtarifa.Enabled = True
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Desea Salir", MsgBoxStyle.OkCancel, "Salir") = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub
End Class
