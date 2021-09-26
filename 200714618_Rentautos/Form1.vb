Public Class Rentautos


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chefectivo.CheckedChanged
        If (chefectivo.Checked) Then
            tefectivo.Visible = True
            d = 0.05
        Else
            tefectivo.Visible = False
            tefectivo.Clear()
            d = 0
        End If

    End Sub

    Private Sub chtarjeta_CheckedChanged(sender As Object, e As EventArgs) Handles chtarjeta.CheckedChanged
        If (chtarjeta.Checked) Then
            ttarjeta.Visible = True
            r = 0.025
        Else
            ttarjeta.Visible = False
            ttarjeta.Clear()
            r = 0
        End If
    End Sub

    Private Sub ProcesoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcesoToolStripMenuItem.Click
        If (IsNumeric(tdias.Text)) Then
            Select Case cmarca.SelectedIndex
                Case 0
                    preciohora = phonda
                    mar = "HONDA"
                Case 1
                    preciohora = pmercedes
                    mar = "MERCEDEZ BENZ"
                Case 2
                    preciohora = ptoyota
                    mar = "TOYOTA"
                Case 3
                    preciohora = pmazda
                    mar = "MAZDA"
            End Select

            llenarVectores(ttnit.Text, tplaca.Text, mar, tdias.Text)

        Else
                MsgBox("Ingrese valor numerico en casilla dias", MsgBoxStyle.OkOnly, "Error")
        End If


    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        salir()
    End Sub

    Private Sub LimpiarListasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarListasToolStripMenuItem.Click
        Limpiar()

    End Sub


End Class
