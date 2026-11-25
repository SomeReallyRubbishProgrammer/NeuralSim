Public Class Neuron
    Dim bias As Decimal
    Dim weights() As Decimal


    Sub New(p_NumberOfInputs As Integer, p_RandomWeights As Boolean)
        ReDim weights(p_NumberOfInputs)
        If p_RandomWeights Then

            For i = 0 To weights.Length - 1
                weights(i) = Rnd()
            Next
            bias = Rnd()
        End If
    End Sub
    Function CalculateOutput(p_inputs() As Decimal) As Decimal
        'If inputs.Length = weights.Length Then
        Dim WeightedInput As Decimal
        For i = 0 To p_inputs.Length - 1
            p_inputs(i) *= (weights(i))
        Next
        WeightedInput = Math.Min(1, p_inputs.Sum * bias)




        Return ActivationGunction2(WeightedInput)
        'End If
    End Function

    Sub SetWeights(p_weights As Decimal())
        If p_weights.Length = weights.Length Then
            weights = p_weights
        End If
    End Sub

    Function ActivationFunction(p_input As Decimal) As Decimal
        Return (-(p_input - 1) ^ 2 + 1)
    End Function
    Function ActivationGunction2(p_input As Decimal) As Decimal
        Return Math.Sin(p_input)
    End Function
    Sub Mutate(MutationValue As Decimal)
        bias += Form1.r.Next(-Math.Min(MutationValue, 1 - bias), Math.Min(MutationValue, 1 - bias))
    End Sub
    Function combine(p_neuron As Neuron) As Neuron
        Dim n As New Neuron(weights.Length, False)
        Dim tmpWeights() As Decimal
        For i = 0 To weights.Length - 1
            tmpWeights(i) = (weights(i) + p_neuron.weights(i)) / 2
        Next
        n.bias = (bias + p_neuron.bias) / 2
        n.SetWeights(weights)
        Return n
    End Function
End Class
