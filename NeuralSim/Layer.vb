Public Class Layer
    Private neurons As New List(Of Neuron)

    Sub New(p_NeuronCount As Integer, p_PreviousLayerNeuronCount As Integer, p_RandomWeights As Boolean)


        For i = 1 To p_NeuronCount
            neurons.Add(New Neuron(p_PreviousLayerNeuronCount, p_RandomWeights))
        Next
    End Sub

    Function CalculateOutputs(p_Inputs As Decimal()) As Decimal()
        Dim outputs(neurons.Count - 1) As Decimal
        For i = 0 To neurons.Count - 1
            outputs(i) = neurons(i).CalculateOutput(p_Inputs)
        Next
        Return outputs
    End Function

    Function GetNeuronCount()
        Return neurons.Count
    End Function
    Sub Mutate(MutationValue As Decimal)
        For Each n As Neuron In neurons
            n.mutate(MutationValue)
        Next
    End Sub
End Class
