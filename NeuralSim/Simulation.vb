Imports System.Drawing.Design
Imports System.Numerics
Imports System.Reflection.Metadata.Ecma335
Imports System.Runtime.Serialization


Public Class Simulation
    Dim MinFoodTime As Integer = 0
    Dim MaxFoodTime As Integer = 0
    Dim MaxFood As Integer = 0
    Private FoodSpawnRate As Decimal = 0
    Public TicksPerGeneration As Integer = 100
    Private FoodTypes As Boolean = False




    Private generation As Integer = 0
    Public food As New Dictionary(Of Point, Integer)
    Public FoodCount As Integer = 0
    Public TicksThisSecond As Integer = 0
    Public grid As SimGrid
    Dim organisms As New List(Of Organism)
    Dim r As New Random
    Private _TotalTicks As Integer = 0

    Public Property TotalTicks As Integer
        Get
            Return _TotalTicks
        End Get
        Set
            If Value < TicksPerGeneration Then
                _TotalTicks = Value
            Else
                _TotalTicks = 0
                NewGeneration()
            End If
        End Set
    End Property

    Sub SetParameters(p_MaxFood As Integer, p_MinFoodTime As Integer, p_MaxFoodTime As Integer, p_FoodSpawnRate As Integer, p_TicksPerGeneration As Integer)
        MaxFood = p_MaxFood
        MinFoodTime = p_MinFoodTime
        MaxFoodTime = p_MaxFoodTime
        FoodSpawnRate = p_FoodSpawnRate / 100
        TicksPerGeneration = p_TicksPerGeneration

    End Sub
    Sub New(p_grid As SimGrid, p_OrganismCount As Decimal)
        grid = p_grid
        For i = 0 To p_OrganismCount - 1
            organisms.Add(New Organism(Me))

        Next



    End Sub
    Sub NewGeneration()
        generation += 1




        MutateOrganisms()

    End Sub

    Sub updateSimulation()



        updatefood()
        Threading.ThreadPool.SetMaxThreads(100, 100)
        Threading.ThreadPool.SetMinThreads(2, 2)

        Dim Tasks(organisms.Count - 1) As Task
        Try
            For i = 0 To organisms.Count - 1
                Tasks(i) = (Task.Run(AddressOf organisms(i).Update))
            Next
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

        Task.WaitAll(Tasks)

        'For Each o As Organism In organisms
        '    o.Update()
        'Next




        Form1.lbl_TicksThisGeneration.Text = $"Generation {generation} Tick {TotalTicks}/{TicksPerGeneration}"
        Form1.lbl_Highscore.Text = GetHighest.score

        TicksThisSecond += 1

        TotalTicks += 1

    End Sub

    Public Sub removeFood(x As Integer, y As Integer)
        If grid.GetSquareType(x, y) = SquareType.Food Then
            grid.SetSquare(x, y, SquareType.Empty)
            food.Remove(New Point(x, y))
        End If
    End Sub
    Private Sub updatefood()
        For Each f In food
            If TotalTicks >= f.Value Or TotalTicks = 0 Then
                removeFood(f.Key.X, f.Key.Y)
            End If
        Next


        Dim CurrentFood As KeyValuePair(Of Point, Integer)
        Dim CurrentPoint As Point

        If food.Count <= MaxFood Then
            CurrentPoint.X = r.Next(0, grid.GridSize - 1)
            CurrentPoint.Y = r.Next(0, grid.GridSize - 1)
            CurrentFood = New KeyValuePair(Of Point, Integer)(CurrentPoint, r.Next(MinFoodTime, MaxFoodTime) + TotalTicks)
            If grid.SetSquare(CurrentPoint.X, CurrentPoint.Y, SquareType.Food) And Not food.ContainsKey(CurrentFood.Key) Then food.Add(CurrentFood.Key, CurrentFood.Value)
        End If





    End Sub
    Private Function GetHighest(p_organisms As List(Of Organism)) As Organism
        Dim highest As Organism = p_organisms(0)
        For Each o As Organism In p_organisms
            If o.score > highest.score Then highest = o
        Next
        Return highest
    End Function
    Function BreedOrganisms(p_organism1 As Organism, p_organism2 As Organism) As Organism
        Dim Organism As New Organism(Me)
        p_organism1.GetNeuralNetwork()


    End Function
    Sub MutateOrganisms()
        For Each o As Organism In organisms
            o.mutaute(0.3)
        Next
    End Sub

    Private Function CombineNeuralNetworks(p_Network1 As NeuralNetwork, p_Network2 As NeuralNetwork) As NeuralNetwork
        Dim tmpNetwork As New NeuralNetwork(p_Network1.LayerCount, 5)
        Dim layers As New List(Of Layer)
        If p_Network1.LayerCount = p_Network2.LayerCount Then
            For i = 0 To p_Network1.LayerCount - 1
                layers.Add(CombineLayer(p_Network1.GetHiddenLayers(i), p_Network2.GetHiddenLayers(i)))
            Next
        End If
        tmpNetwork.SetHiddenLayers(layers)
        Return tmpNetwork
    End Function
    Private Function CombineLayer(p_layer1 As Layer, p_layer2 As Layer) As Layer
        Dim tmpLayer As New Layer(p_layer1.GetNeuronCount, p_layer1.GetNeuronCount, False)
        Dim neurons As New List(Of Neuron)
        Dim layer1neurons As List(Of Neuron) = p_layer1.GetNeurons
        Dim layer2neurons As List(Of Neuron) = p_layer2.GetNeurons
        For i = 0 To layer1neurons.Count - 1
            neurons.Add(layer1neurons(i).combine(layer2neurons(i)))
        Next
        tmpLayer.SetNeurons(neurons)
        Return tmpLayer
    End Function
    Public Function GetNearestFoodAngle(p_x, p_y) As Decimal
        Dim FoodFound As Boolean = False
        Dim CurrentRing As Integer = 0
        Dim FoodPoints As New List(Of Point)
        Dim Closest As Point
        Dim ClosestDistance As Decimal = 1000

        Do Until FoodFound = True
            CurrentRing += 1
            If CurrentRing >= grid.GridSize Then
                Return Rnd()
            End If
            For Each p As Point In GetRingCoordinates(New Point(p_x, p_y), CurrentRing, grid)
                If grid.GetSquareType(p.X, p.Y) = SquareType.Food Then
                    FoodPoints.Add(p)
                    FoodFound = True
                End If
            Next
        Loop
        For Each p As Point In FoodPoints
            If (GetDistance(New Point(p_x, p_y), p) < ClosestDistance) Then
                ClosestDistance = GetDistance(New Point(p_x, p_y), p)
                Closest = p
            End If
        Next
        Return GetAngle(New Point(p_x, p_y), Closest)


    End Function

    Private Function GetRingCoordinates(p_Center As Point, p_Distance As Integer, p_grid As SimGrid) As List(Of Point)
        Dim Coordinates As New List(Of Point)
        For i = -p_Distance To p_Distance
            For j = -p_Distance To p_Distance
                If Math.Abs(i) = p_Distance Or Math.Abs(j) = p_Distance Then
                    If p_Center.X + i >= 0 And p_Center.Y + j >= 0 And p_Center.X + i < p_grid.GridSize And p_Center.Y + j < p_grid.GridSize Then
                        Coordinates.Add(New Point(p_Center.X + i, p_Center.Y + j))
                    End If

                End If
            Next
        Next
        Return Coordinates
    End Function
    Function GetAngle(organism As Point, food As Point) As Decimal


        Dim x As Integer = organism.X - food.X
        Dim y As Integer = organism.Y - food.Y
        Dim DotProduct As Integer = y
        Dim FoodMagnitude As Decimal = Math.Sqrt(y ^ 2 + x ^ 2)
        Dim Angle As Decimal = Math.Acos(DotProduct / FoodMagnitude)
        If food.X < organism.X Then
            Angle = Math.Tau - Angle
        End If
        Return Angle



    End Function

    Function GetHighestOrganisms(count As Integer) As List(Of Organism)
        Dim tmporganisms As List(Of Organism) = organisms
        Dim tmpHighorganisms As New List(Of Organism)
        Do Until tmpHighorganisms.Count >= count Or tmporganisms.Count = 0
            Dim currenthighest = GetHighest(tmporganisms)
            tmpHighorganisms.Add(currenthighest)
            tmporganisms.Remove(currenthighest)
        Loop
        Return tmpHighorganisms



    End Function








    Private Function GetDistance(p_1 As Point, p_2 As Point) As Decimal
        Return Math.Sqrt((p_1.X - p_2.X) ^ 2 + (p_1.Y - p_2.Y) ^ 2)
    End Function


End Class
