Public Class InputLayer
    Dim Weight As Decimal
    Dim bias As Decimal

    Sub New(p_RandomWeights As Boolean)
        If p_RandomWeights = True Then RandomiseWeights()

    End Sub
    Function CalculateOutput(p_Angle As Decimal) As Decimal
        Dim output = ActivationFunction(p_Angle)
        Return output
    End Function
    Private Sub RandomiseWeights()
        Randomize()
        Weight = Rnd()
        bias = Rnd()
    End Sub
    Function ActivationFunction(p_input As Decimal) As Decimal
        Return (-(p_input - 1) ^ 2 + 1)
    End Function

End Class
