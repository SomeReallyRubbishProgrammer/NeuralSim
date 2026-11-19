Public Class OutputLayer
    Private neurons As New List(Of Neuron)

    Sub New(p_OutputCount As Integer, p_PreviousLayerNeuronCount As Integer, RandomWeights As Boolean)
        p_OutputCount = 4 'temporarliy set to 4, one for each direction
        For i = 1 To p_OutputCount
            neurons.Add(New Neuron(p_PreviousLayerNeuronCount, RandomWeights))
        Next
    End Sub

    Function CalculateOutput(p_Inputs As Decimal()) As NeuralNetwork.NetworkOutput
        Dim outputs(neurons.Count) As Decimal
        For i = 0 To neurons.Count - 1
            outputs(i) = neurons(i).CalculateOutput(p_Inputs)
        Next
        Return New NeuralNetwork.NetworkOutput(outputs)
    End Function

    Function GetNeuronCount()
        Return neurons.Count
    End Function
End Class
