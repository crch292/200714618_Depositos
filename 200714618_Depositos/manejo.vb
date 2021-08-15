Module manejo
    Public santerior As Double
    Public tipocuentainteres As Integer
    Public montointeres As Double
    Public saldoaplicar As Double
    Public montodepositar As Double

    Public Sub ingresaSaldoAnterior(ByVal saldo As Double)
        santerior = saldo
    End Sub

    Public Function calculoInteres(ByVal a As Integer, ByVal monto As Double) As Double
        If a = 1 And monto > 0 Then
            Select Case monto
                Case Is < 1001
                    montointeres = monto * 0.015
                Case 1000 To 5001
                    montointeres = monto * 0.025
                Case 5000 To 15001
                    montointeres = monto * 0.075
                Case Is > 15000
                    montointeres = monto * 0.1
            End Select
        End If
        If a = 2 And monto > 0 Then
            Select Case monto
                Case Is < 10001
                    montointeres = monto * 0.025
                Case 10000 To 15001
                    montointeres = monto * 0.03
                Case Is > 15000
                    montointeres = monto * 0.045
            End Select
        End If

        Return montointeres
    End Function

    Public Function formato(ByVal numero As Double) As String
        Dim cadena As String
        cadena = Format(numero, "Q0.00")
        Return cadena
    End Function


End Module
