Imports System.Windows

Public Class Organism
    Public Enum Direction
        Up
        Down
        Left
        Right
    End Enum

    Private _score As Integer
    Public Property score As Integer
        Set(value As Integer)
            _score = value

        End Set
        Get
            Return _score
        End Get
    End Property


    Public x As Integer
    Public y As Integer
    Dim r As New Random

    Private simulation As Simulation

    Private NeuralNetwork As New NeuralNetwork(2, 5)

    Sub New(Sim As Simulation)
        If Sim Is Nothing Then
            Throw New ArgumentNullException(NameOf(Sim))
        End If

        If Sim.grid Is Nothing Then
            Throw New InvalidOperationException("Simulation.grid must be initialized.")
        End If

        simulation = Sim
        x = r.Next(0, Sim.grid.GridSize - 1)
        y = r.Next(0, Sim.grid.GridSize - 1)
        Sim.grid.SetSquare(x, y, SquareType.Organism)
    End Sub

    Public Sub Update() 'update organism
        Try
            Dim FoodAngle As Decimal = simulation.GetNearestFoodAngle(x, y)

            Select Case NeuralNetwork.calculateDirection(FoodAngle)
                Case Direction.Up
                    If simulation.grid.GetSquareType(x, y + 1) = SquareType.Food Then
                        score += 1
                        simulation.FoodCount -= 1
                        simulation.removeFood(x, y + 1)
                    End If
                    If simulation.grid.MoveSquare(x, y, x, y + 1) Then
                        y += 1
                    End If
                Case Direction.Down
                    If simulation.grid.GetSquareType(x, y - 1) = SquareType.Food Then
                        score += 1
                        simulation.FoodCount -= 1
                        simulation.removeFood(x, y - 1)
                    End If
                    If simulation.grid.MoveSquare(x, y, x, y - 1) Then
                        y -= 1
                    End If
                Case Direction.Left
                    If simulation.grid.GetSquareType(x - 1, y) = SquareType.Food Then
                        score += 1
                        simulation.FoodCount -= 1
                        simulation.removeFood(x - 1, y)
                    End If
                    If simulation.grid.MoveSquare(x, y, x - 1, y) Then
                        x -= 1
                    End If
                Case Direction.Right
                    If simulation.grid.GetSquareType(x + 1, y) = SquareType.Food Then
                        score += 1
                        simulation.FoodCount -= 1
                        simulation.removeFood(x + 1, y)

                    End If
                    If simulation.grid.MoveSquare(x, y, x + 1, y) Then
                        x += 1
                    End If
            End Select
        Catch ex As Exception
            Debug.WriteLine(ex.ToString())
        End Try

    End Sub
    Public Sub SetNeuralNetwork(p_Network As NeuralNetwork)
        NeuralNetwork = p_Network
    End Sub
    Public Function GetNeuralNetwork() As NeuralNetwork
        Return NeuralNetwork
    End Function

    Sub mutaute(MutationValue As Decimal)
        NeuralNetwork.Mutate(MutationValue)
    End Sub



End Class
