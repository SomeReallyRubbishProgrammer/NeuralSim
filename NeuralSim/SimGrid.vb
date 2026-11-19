Imports System.ComponentModel


Public Enum SquareType
    Empty
    Food
    Organism
End Enum

Public Class SimGrid

    Dim r As New Random
    Private tooltip As ToolTip = New ToolTip
    Dim Squares(,) As PictureBox
    Dim SquareTypes(,) As SquareType
    Private _GridSize As Integer
    Private _SquareSize As Integer



    Public Property SquareSize As Integer
        Get
            Return _SquareSize
        End Get
        Set(value As Integer)
            _SquareSize = value
            LoadGrid()

        End Set
    End Property

    Public Property GridSize As Integer
        Get
            Return _GridSize
        End Get
        Set
            _GridSize = Value
            LoadGrid()
        End Set
    End Property



    Sub New(p As Panel)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Width = Math.Min(p.Width, p.Height)
        Me.Height = Math.Min(p.Width, p.Height)
        p.Controls.Add(Me)
        AddHandler Me.ParentForm.ResizeEnd, Sub() SetGridSize(p)

        SetGridSize(p)

    End Sub
    Sub SetGridSize(p As Panel)
        Me.Width = Math.Min(p.Width, p.Height)
        Me.Height = Math.Min(p.Width, p.Height)
        resize()
    End Sub

    Sub LoadGrid()

        _SquareSize = Me.Width \ (_GridSize - 1)

        Me.Controls.Clear()
        Squares = Nothing
        ReDim Squares(GridSize - 1, GridSize - 1)
        ReDim SquareTypes(GridSize - 1, GridSize - 1)



        Me.Size = New Size((GridSize - 1) * SquareSize, (GridSize - 1) * SquareSize)


        For i = 0 To GridSize - 1
            For j = 0 To GridSize - 1
                Dim TmpSquare As New PictureBox

                TmpSquare.Width = SquareSize
                TmpSquare.Height = SquareSize
                TmpSquare.Location = New Point(i * SquareSize, j * SquareSize)
                TmpSquare.BackColor = Color.PaleGreen
                TmpSquare.SizeMode = PictureBoxSizeMode.StretchImage
                Squares(i, j) = TmpSquare
                Me.Controls.Add(TmpSquare)





            Next
        Next


    End Sub
    Sub resize()

        _SquareSize = Me.Width \ (_GridSize - 1)
        Me.Size = New Size((GridSize - 1) * SquareSize, (GridSize - 1) * SquareSize)
        For i = 0 To GridSize - 1
            For j = 0 To GridSize - 1
                Squares(i, j).Location = New Point(i * SquareSize, j * SquareSize)
                Squares(i, j).Width = SquareSize
                Squares(i, j).Height = SquareSize

            Next
        Next

    End Sub

    Sub Clear()
        For Each s As SquareType In SquareTypes
            s = SquareType.Empty
        Next
        For Each p As PictureBox In Squares
            p.Image = Nothing
            p.BackColor = Color.PaleGreen
        Next
    End Sub

    Public Function SetSquare(p_x As Integer, p_y As Integer, p_type As SquareType) As Boolean
        If p_x < GridSize - 1 And p_x >= 0 And p_y < GridSize - 1 And p_y >= 0 Then

            Select Case p_type
                Case SquareType.Empty
                    SquareTypes(p_x, p_y) = SquareType.Empty
                    Squares(p_x, p_y).BackColor = Color.PaleGreen
                    SetToolTip(p_x, p_y, "")

                Case SquareType.Food
                    If SquareTypes(p_x, p_y) = SquareType.Empty Then
                        SquareTypes(p_x, p_y) = SquareType.Food
                        Squares(p_x, p_y).BackColor = Color.Red
                    Else
                        Return False
                    End If


                Case SquareType.Organism

                    SquareTypes(p_x, p_y) = SquareType.Organism
                    Squares(p_x, p_y).BackColor = Color.Green

            End Select
            Return True
        End If
        Return False


    End Function
    Public Function MoveSquare(p_x As Integer, p_y As Integer, p_Newx As Integer, p_Newy As Integer, Optional score As String = "") As Boolean


        If SetSquare(p_Newx, p_Newy, SquareType.Organism) Then
            If SetSquare(p_x, p_y, SquareType.Empty) Then

                SetToolTip(p_Newx, p_Newy, score)

                Return True
            End If
        End If

        Return False
    End Function
    Public Function GetSquareType(p_x, p_y) As SquareType
        If p_x < GridSize And p_x >= 0 And p_y < GridSize And p_y >= 0 Then
            Return SquareTypes(p_x, p_y)
        End If
        Return SquareType.Empty
    End Function
    Public Sub SetToolTip(x As Integer, y As Integer, text As String)
        tooltip.SetToolTip(Squares(x, y), text)
    End Sub
End Class
