Public Class Form1
    Private Sub chlino_CheckedChanged(sender As Object, e As EventArgs) Handles chlino.CheckedChanged
        If chlino.Checked = True Then
            tlino.Visible = True
            p1.Visible = True
        Else
            tlino.Visible = False
            p1.Visible = False
        End If
    End Sub

    Private Sub chalgodon_CheckedChanged(sender As Object, e As EventArgs) Handles chalgodon.CheckedChanged
        If chalgodon.Checked = True Then
            talgodon.Visible = True
            p2.Visible = True
        Else
            talgodon.Visible = False
            p2.Visible = False
        End If
    End Sub

    Private Sub chseda_CheckedChanged(sender As Object, e As EventArgs) Handles chseda.CheckedChanged
        If chseda.Checked = True Then
            tseda.Visible = True
            p3.Visible = True
        Else
            tseda.Visible = False
            p3.Visible = False
        End If
    End Sub

    Private Sub chhilo_CheckedChanged(sender As Object, e As EventArgs) Handles chhilo.CheckedChanged
        If chhilo.Checked = True Then
            thilo.Visible = True
            p4.Visible = True
        Else
            thilo.Visible = False
            p4.Visible = False
        End If
    End Sub

    Private Sub inicializarVariables()
        If chlino.Checked = True Then
            ylino = tlino.Text
        Else
            ylino = 0
        End If
        If chalgodon.Checked = True Then
            yalgodon = talgodon.Text
        Else
            yalgodon = 0
        End If
        If chseda.Checked = True Then
            yseda = tseda.Text
        Else
            yseda = 0
        End If
        If chhilo.Checked = True Then
            yhilo = thilo.Text
        Else
            yhilo = 0
        End If
        ytotal = ylino + yalgodon + yseda + yhilo
    End Sub

    Public Sub verificarYardas(ByVal total As Double, ByVal total1 As Double)
        If total <> total1 Then
            MsgBox("se excede o faltan yardas para cama seleccionada debe utilizar " & total1 & " yardas", MsgBoxStyle.OkOnly, "error")
        Else
            ytotalverificado = ytotal
        End If
    End Sub

    Public Sub asignarTamaño()
        If rimperial.Checked Then
            tamaño = 1
        End If
        If rmatrimonial.Checked Then
            tamaño = 2
        End If
        If rqueen.Checked Then
            tamaño = 3
        End If
        If rking.Checked Then
            tamaño = 4
        End If
    End Sub

    Public Sub verificarYardascomparar()
        Select Case tamaño
            Case 1
                yardascomparar = maximperial
            Case 2
                yardascomparar = maxmatrimonial
            Case 3
                yardascomparar = maxqueen
            Case 4
                yardascomparar = maxking
        End Select
    End Sub

    Public Sub asignarPrecioMano()
        Select Case tamaño
            Case 1
                preciomano = mimperial
            Case 2
                preciomano = mmatrimonial
            Case 3
                preciomano = mqueen
            Case 4
                preciomano = mking
        End Select
    End Sub

    Public Sub calcularCostoPrecio()

        preciocosto = preciomano + ((Val(tlino.Text) * plino) + (Val(talgodon.Text) * palgodon) + (Val(tseda.Text) * pseda) + (Val(thilo.Text) * philo))

    End Sub

    Public Sub calcularPrecioVenta()
        precioventa = preciocosto + (preciocosto * 0.65)
    End Sub

    Public Sub calcularPrecioyardas()
        p1.Text = Format((Val(tlino.Text) * plino), "Q0.00")
        p2.Text = Format((Val(talgodon.Text) * palgodon), "Q0.00")
        p3.Text = Format((Val(tseda.Text) * pseda), "Q0.00")
        p4.Text = Format((Val(thilo.Text) * philo), "Q0.00")
    End Sub

    Public Sub opcional()
        chlino.Enabled = False
        chalgodon.Enabled = False
        chseda.Enabled = False
        chhilo.Enabled = False
        rimperial.Enabled = False
        rmatrimonial.Enabled = False
        rqueen.Enabled = False
        rking.Enabled = False
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        asignarTamaño()
        verificarYardascomparar()
        inicializarVariables()
        verificarYardas(ytotal, yardascomparar)
        asignarPrecioMano()
        calcularCostoPrecio()
        calcularPrecioVenta()
        tcosto.Text = Format(preciocosto, "Q0.00")
        tventa.Text = Format(precioventa, "Q0.00")
        calcularPrecioyardas()


    End Sub

    Public Sub Limpiar()
        rimperial.Checked = False
        rmatrimonial.Checked = False
        rqueen.Checked = False
        rking.Checked = False
        chlino.Checked = False
        chalgodon.Checked = False
        chseda.Checked = False
        chhilo.Checked = False
        tlino.Clear()
        talgodon.Clear()
        tseda.Clear()
        thilo.Clear()
        p1.Clear()
        p2.Clear()
        p3.Clear()
        p4.Clear()
        tcosto.Clear()
        tventa.Clear()
    End Sub



    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        Limpiar()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Desea Salir ", MsgBoxStyle.OkCancel, "Salir") = MsgBoxResult.Ok Then
            End
        End If

    End Sub


End Class
