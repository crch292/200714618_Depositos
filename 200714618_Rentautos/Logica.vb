Module Logica
    Public Const phonda = 250
    Public Const pmercedes = 450
    Public Const ptoyota = 325
    Public Const pmazda = 300
    Public nits(6) As String
    Public placas(6) As String
    Public marcas(6) As String
    Public dias(6) As Integer
    Public precios(6) As Double
    Public descuentos(6) As Double
    Public recargos(6) As Double
    Public parciales(6) As Double
    Public pagostotales(6) As Double
    Public indice = 0
    Public preciohora As Double
    Public d As Double
    Public des As Double
    Public rec As Double
    Public r As Double
    Public mar As String
    Public pagototal As Double




    Public Sub llenarVectores(ByVal nit As String, ByVal placa As String, ByVal m As String, ByVal diass As Integer)
        nits(indice) = nit
        placas(indice) = placa
        marcas(indice) = m
        dias(indice) = diass
        precios(indice) = preciohora
        parciales(indice) = dias(indice) * 24 * precios(indice)
        validarDescuento()
        descuentos(indice) = des
        validarRecargo()
        recargos(indice) = rec
        pagostotales(indice) = parciales(indice) + recargos(indice) - descuentos(indice)

        validarPagos()

    End Sub

    Public Sub validarDescuento()
        If (d = 0.05 And parciales(indice) = Val(Rentautos.tefectivo.Text)) Then
            des = d * parciales(indice)

        Else
            des = 0

        End If
    End Sub

    Public Sub validarRecargo()
        If (r = 0.025 And parciales(indice) = Val(Rentautos.ttarjeta.Text)) Then
            rec = r * parciales(indice)

        Else
            rec = 0

        End If
    End Sub



    Public Sub Limpiar()
        Dim i As Integer
        For i = 0 To 5
            nits(i) = 0
            placas(i) = 0
            marcas(i) = 0
            dias(i) = 0
            precios(i) = 0
            descuentos(i) = 0
            recargos(i) = 0
            parciales(i) = 0
            pagostotales(i) = 0

        Next
        Rentautos.lplacas.Items.Clear()
        Rentautos.lmarcas.Items.Clear()
        Rentautos.ldias.Items.Clear()
        Rentautos.lpagosparciales.Items.Clear()
        Rentautos.ldescuentos.Items.Clear()
        Rentautos.lrecargos.Items.Clear()
        Rentautos.lpagototal.Items.Clear()
        Rentautos.tefectivo.Clear()
        Rentautos.ttarjeta.Clear()
        indice = 0
    End Sub

    Public Sub salir()
        If MsgBox("Desea Salir", MsgBoxStyle.OkCancel, "Salir") = MsgBoxResult.Ok Then
            Rentautos.Close()
        End If
    End Sub

    Public Sub validarPagos()
        If (Val(Rentautos.tefectivo.Text) + Val(Rentautos.ttarjeta.Text) = Val(Rentautos.tdias.Text) * 24 * preciohora) Then

            Rentautos.lplacas.Items.Add(placas(indice))
            Rentautos.lmarcas.Items.Add(marcas(indice))
            Rentautos.ldias.Items.Add(dias(indice))
            Rentautos.lpagosparciales.Items.Add(parciales(indice))
            Rentautos.ldescuentos.Items.Add(descuentos(indice))
            Rentautos.lrecargos.Items.Add(recargos(indice))
            Rentautos.lpagototal.Items.Add(pagostotales(indice))
            indice = indice + 1
        Else
            MsgBox("verifique las cantidades ya que no suman monto correcto el cual debe ser " & parciales(indice), MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

End Module
