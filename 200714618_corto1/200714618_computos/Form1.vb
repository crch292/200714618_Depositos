Public Class Form1
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rsur.CheckedChanged

    End Sub

    Public Sub limpiarcontrol()
        tnombre.Clear()
        tventas.Clear()
        tadicional.Clear()
        tsueldo.Clear()
        tnombre.Focus()
        rbono.Checked = False
        rcomision.Checked = False
        rnorte.Checked = False
    End Sub

    Private Sub calcular_Click(sender As Object, e As EventArgs) Handles calcular.Click
        asignarviaticos()
        nombre = tnombre.Text
        Dim cargo1 As Double
        Dim cargo2 As Double
        ventas = Val(tventas.Text)
        If rnorte.Checked Then
            cargo1 = vnorte
        End If
        If rsur.Checked Then
            cargo1 = vsur
        End If
        If roccidente.Checked Then
            cargo1 = voccidente
        End If
        If roriente.Checked Then
            cargo1 = voriente
        End If

        If rbono.Checked Then
            cargo2 = bono
        End If
        If rcomision.Checked Then
            cargo1 = comision
        End If
        tadicional.Text = calcularadicional(cargo1, cargo2, ventas)
        tsueldo.Text = base + calcularadicional(cargo1, cargo2, ventas)


    End Sub

    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        limpiarcontrol()

    End Sub
End Class
