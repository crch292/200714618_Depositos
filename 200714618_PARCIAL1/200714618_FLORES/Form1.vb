Public Class Form1

    Public Sub verificarTamaño()
        If rpequeño.Checked = True Then
            tamaño = 1
        End If
        If rmediano.Checked = True Then
            tamaño = 2
        End If
        If rgrande.Checked = True Then
            tamaño = 3
        End If
    End Sub

    Public Sub asignarManoObra()
        Select Case tamaño
            Case 1
                preciomano = mpequeño
            Case 2
                preciomano = mmediano
            Case 3
                preciomano = mgrande
        End Select
    End Sub

    Public Sub calcularPrecioCosto()


        preciocosto = preciomano + ((Val(trosas.Text) * prosas) + (Val(tgerberas.Text) * pgerberas) + (Val(tazucenas.Text) * pazucenas) + (Val(texoticas.Text) * pexotica))

    End Sub


    Public Sub calcularDescuento()
        descuento = 0
        If chgerberas.Checked = True And chazucenas.Checked = True And tamaño = 2 Then
            descuento = 0.02
        End If
        If chrosas.Checked = True And chgerberas.Checked = True And chazucenas.Checked = True And chexotica.Checked = True And tamaño = 3 Then
            descuento = 0.1
        End If
        totall = preciocosto - (preciocosto * descuento)
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        verificarTamaño()
        asignarManoObra()
        calcularPrecioCosto()
        calcularDescuento()
        tdescuento.Text = Format(preciocosto * descuento, "Q0.00")
        subtotal.Text = Format(preciocosto, "Q0.00")
        total.Text = Format(totall, "Q0.00")

    End Sub

    Private Sub chrosas_CheckedChanged(sender As Object, e As EventArgs) Handles chrosas.CheckedChanged
        If chrosas.Checked = True Then
            trosas.Visible = True
        Else
            trosas.Visible = False
            trosas.Text = 0
        End If
    End Sub

    Private Sub chgerberas_CheckedChanged(sender As Object, e As EventArgs) Handles chgerberas.CheckedChanged
        If chgerberas.Checked = True Then
            tgerberas.Visible = True
        Else
            tgerberas.Visible = False
            tgerberas.Text = 0
        End If
    End Sub

    Private Sub chazucenas_CheckedChanged(sender As Object, e As EventArgs) Handles chazucenas.CheckedChanged
        If chazucenas.Checked = True Then
            tazucenas.Visible = True
        Else
            tazucenas.Visible = False
            tazucenas.Text = 0
        End If
    End Sub

    Private Sub chexotica_CheckedChanged(sender As Object, e As EventArgs) Handles chexotica.CheckedChanged
        If chexotica.Checked = True Then
            texoticas.Visible = True
        Else
            texoticas.Visible = False
            texoticas.Text = 0
        End If
    End Sub


End Class
