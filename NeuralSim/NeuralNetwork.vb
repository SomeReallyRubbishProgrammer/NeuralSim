Public Class NeuralNetwork
    Dim r As New Random

    Dim inputLayer As InputLayer
    Dim outputLayer As OutputLayer
    Dim HiddenLayers As New List(Of Layer)
    Dim Output As New NetworkOutput

    Public Structure NetworkOutput
        Public up As Decimal
        Public down As Decimal
        Public left As Decimal
        Public right As Decimal
        Sub New(Optional p_Values() As Decimal = Nothing)
            If p_Values IsNot Nothing Then
                up = p_Values(0)
                down = p_Values(1)
                left = p_Values(2)
                right = p_Values(3)
            End If
        End Sub
        Function LargestDirection() As Organism.Direction
            Dim largestindex As Integer = 0
            Dim items() = {up, down, left, right}
            For i = 1 To items.Length - 1
                If items(i) > items(i - 1) Then largestindex = i
            Next
            Select Case largestindex
                Case 0
                    Return Organism.Direction.Up
                Case 1
                    Return Organism.Direction.Down
                Case 2
                    Return Organism.Direction.Left
                Case 3
                    Return Organism.Direction.Right
            End Select
            Return Nothing
        End Function
    End Structure


    Sub New(p_layers As Integer, p_NodesPerLayer As Integer)
        Randomize()
        inputLayer = New InputLayer(True)
        outputLayer = New OutputLayer(4, p_NodesPerLayer, True)
        For i = 1 To p_layers
            HiddenLayers.Add(New Layer(5, 5, True))
        Next

    End Sub

    Function CalculateOutput(p_angle As Decimal) As NetworkOutput
        Dim inputlayeroutput As Decimal = inputLayer.CalculateOutput(p_angle)
        Dim LastLayerOutputs(4) As Decimal
        Dim OutputLayerOutputs(4) As Decimal
        For i = 0 To HiddenLayers.First.GetNeuronCount - 1
            LastLayerOutputs(i) = inputlayeroutput
        Next



        For Each l As Layer In HiddenLayers
            LastLayerOutputs = l.CalculateOutputs(LastLayerOutputs)
        Next



        Output = outputLayer.CalculateOutput(LastLayerOutputs)
        Return Output

    End Function




    Function calculateDirection(p_angle As Decimal) As Organism.Direction
        Return CalculateOutput(p_angle).LargestDirection
    End Function

    Function LayerCount() As Integer
        Return HiddenLayers.Count
    End Function
    Function GetHiddenLayers() As List(Of Layer)

        Return HiddenLayers
    End Function
    Function GetInputLayer() As InputLayer
        Return inputLayer
    End Function
    Function GetOutputLayer() As OutputLayer
        Return outputLayer
    End Function
    Sub Mutate(MutationValue As Decimal)
        For Each l As Layer In HiddenLayers
            l.Mutate(MutationValue)
        Next

    End Sub



End Class
