Module Logica
    Public nombres(11) As String
    Public nits(11) As Integer
    Public Saldosanteriores(11) As Double
    Public Consumos(11) As Double
    Public Tiposservicio(11) As String
    Public TiposTarifa(11) As String
    Public pagosiniciales(11) As Double
    Public totalespagar(11) As Double
    Public descuentos(11) As Double
    Public recargos(11) As Double
    Public indice = 0

    Public Sub IngresarDatos(n As String, ni As Integer, sa As Double, con As Double, ts As String, tt As String)
        nombres(indice) = n
        nits(indice) = ni
        Saldosanteriores(indice) = sa
        Consumos(indice) = con
        Tiposservicio(indice) = ts
        TiposTarifa(indice) = tt
        pagosiniciales(indice) = calcularPagoinicial()
        descuentos(indice) = calcularDescuento()
        recargos(indice) = calcularmora()
        totalespagar(indice) = calcularpagototal()
        indice = indice + 1
    End Sub

    Public Sub ingresarListas()

        resultados.listiposervico.Items.Add(Tiposservicio(indice - 1))
        resultados.listipotarifa.Items.Add(TiposTarifa(indice - 1))
        resultados.lissaldoanterior.Items.Add(Saldosanteriores(indice - 1))
        resultados.lispagoinicial.Items.Add(pagosiniciales(indice - 1))
        resultados.lisdescuento.Items.Add(descuentos(indice - 1))
        resultados.lismora.Items.Add(recargos(indice - 1))
        resultados.lispagototal.Items.Add(totalespagar(indice - 1))


    End Sub

    Public Function calcularPagoinicial() As Double
        Dim precio As Double
        If (Consumos(indice) > 0 And Consumos(indice) < 101) Then
            Select Case Tiposservicio(indice)
                Case "Residencial"
                    precio = 0.99
                Case "Industrial"
                    precio = 1.99
            End Select
        End If

        If (Consumos(indice) > 100 And Consumos(indice) < 301) Then
            Select Case Tiposservicio(indice)
                Case "Residencial"
                    precio = 1.2
                Case "Industrial"
                    precio = 2.2
            End Select
        End If

        If (Consumos(indice) > 300) Then
            Select Case Tiposservicio(indice)
                Case "Residencial"
                    precio = 3.0
                Case "Industrial"
                    precio = 4.0
            End Select
        End If

        Return Consumos(indice) * precio

    End Function

    Public Function calcularDescuento() As Double
        Dim desc As Double
        Select Case TiposTarifa(indice)
            Case "Social"
                desc = pagosiniciales(indice) * 0.2
            Case "No Social"
                desc = pagosiniciales(indice) * 0.1
        End Select
        Return desc
    End Function

    Public Function calcularmora() As Double
        Dim mor As Double
        If (Saldosanteriores(indice) > 0) Then
            mor = Saldosanteriores(indice) * 0.02
        Else
            mor = 0
        End If
        Return mor

    End Function

    Public Function calcularpagototal() As Double
        Dim pag As Double
        pag = Saldosanteriores(indice) + recargos(indice) + pagosiniciales(indice) - descuentos(indice)
        Return pag
    End Function

    Public Sub limpiar()
        Form1.tnombre.Clear()
        Form1.tnit.Clear()
        Form1.tsaldoanterior.Clear()
        Form1.tconsumo.Clear()
        Form1.chservicio.Refresh()
        Form1.chtarifa.Refresh()
        Form1.tnombre.Focus()
    End Sub



End Module
