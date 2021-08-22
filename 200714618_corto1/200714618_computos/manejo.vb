Module manejo
    Public vnorte As Double
    Public vsur As Double
    Public voriente As Double
    Public voccidente As Double
    Public ventas As Double
    Public base As Double
    Public bono As Double
    Public comision As Double
    Public total As Double
    Public nombre As String

    Public Sub asignarviaticos()
        vnorte = 150
        vsur = 200
        voriente = 175
        voccidente = 225
        base = 3800
        bono = 0.03
        comision = 0.05
    End Sub

    Public Function calcularadicional(ByVal region As Double, ByVal tas As Double, ByVal vent As Double) As Double
        total = (vent * tas) + region
        Return total
    End Function






End Module
