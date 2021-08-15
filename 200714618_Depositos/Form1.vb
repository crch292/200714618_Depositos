Public Class Form1
    Private Sub ingresar_Click(sender As Object, e As EventArgs) Handles ingresar.Click

        If IsNumeric(saldoanterior.Text) Then
            gruposaldo.Visible = False

            ingresaSaldoAnterior(Val(saldoanterior.Text))
            tipocuenta.Visible = True
        Else

            MsgBox("no esta ingresando valor correcto", MessageBoxButtons.OK, "error")

        End If

    End Sub

    Private Sub rMonetaria_CheckedChanged(sender As Object, e As EventArgs) Handles rMonetaria.CheckedChanged
        depositos.Visible = True

    End Sub

    Private Sub rmpremier_CheckedChanged(sender As Object, e As EventArgs) Handles rmpremier.CheckedChanged
        depositos.Visible = True
    End Sub

    Private Sub rahorros_CheckedChanged(sender As Object, e As EventArgs) Handles rahorros.CheckedChanged
        depositos.Visible = True
    End Sub

    Private Sub chequepropio_CheckedChanged(sender As Object, e As EventArgs) Handles chequepropio.CheckedChanged
        If chequepropio.Checked Then
            tcpropio.Visible = True
        Else
            tcpropio.Visible = False
        End If
        If tcpropio.Visible = True Then
            depositar.Visible = True
        Else
            depositar.Visible = False
        End If
    End Sub

    Private Sub chequeotros_CheckedChanged(sender As Object, e As EventArgs) Handles chequeotros.CheckedChanged
        If chequeotros.Checked Then
            tcotros.Visible = True
        Else
            tcotros.Visible = False
        End If
        If tcotros.Visible = True Then
            depositar.Visible = True
        Else
            depositar.Visible = False
        End If
    End Sub

    Private Sub efectivo_CheckedChanged(sender As Object, e As EventArgs) Handles efectivo.CheckedChanged
        If efectivo.Checked Then
            tefectivo.Visible = True
        Else
            tefectivo.Visible = False
        End If
        If tefectivo.Visible = True Then
            depositar.Visible = True
        Else
            depositar.Visible = False
        End If
    End Sub

    Private Sub depositar_Click(sender As Object, e As EventArgs) Handles depositar.Click
        montodepositar = Val(tcpropio.Text) + Val(tcotros.Text) + Val(tefectivo.Text)


        If rahorros.Checked Then
            tipocuentainteres = 1
            saldoaplicar = santerior + montodepositar
        End If
        If rmpremier.Checked Then
            tipocuentainteres = 2
            saldoaplicar = santerior
        End If
        interes.Text = formato(calculoInteres(tipocuentainteres, saldoaplicar))
        salidas.Visible = True
        totaldeposito.Text = formato(montodepositar)
        nuevosaldo.Text = formato(montodepositar + santerior + interes.Text)
    End Sub

    Private Sub limpiar()
        gruposaldo.Visible = True
        saldoanterior.Clear()
        tipocuenta.Visible = False
        rahorros.Checked = False
        rmpremier.Checked = False
        rMonetaria.Checked = False
        salidas.Visible = False
        depositos.Visible = False
        chequepropio.Checked = False
        chequeotros.Checked = False
        efectivo.Checked = False
        tcpropio.Clear()
        tcotros.Clear()
        tefectivo.Clear()
        interes.Clear()
        totaldeposito.Clear()
        nuevosaldo.Clear()
        saldoanterior.Focus()
    End Sub

    Private Sub limpiarbutton_Click(sender As Object, e As EventArgs) Handles limpiarbutton.Click
        limpiar()

    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        If (MsgBox("Desea Salir", MsgBoxStyle.OkCancel, "Salir")) = MsgBoxResult.Ok Then
            End
        Else
            limpiar()
        End If

    End Sub
End Class
