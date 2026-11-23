Imports System.Linq.Expressions
Imports System.Net.Sockets
Imports System.Threading
'this is test text for github

Public Class Form1
    Public r As New Random
    Public simgrid As SimGrid
    Dim sim As Simulation
    Dim t As New System.Windows.Forms.Timer()
    Dim tpsTimer As New System.Windows.Forms.Timer()
    Dim paused As Boolean = True
    Dim speed As Integer = 0



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Debug.Write("test") ' ?????

        simgrid = New SimGrid(Panel1)
        simgrid.SquareSize = 48
        simgrid.GridSize = 20
        ResetSimulation()
        tpsTimer.Interval = 500
        t.Interval = 1

        AddHandler tpsTimer.Tick, Sub(s, eventargs) UpdateTPS()
        AddHandler t.Tick, Sub(s, eventargs) sim.updateSimulation()
        AddHandler nup_MaxFood.ValueChanged, Sub() UpdateSettings()
        AddHandler nup_FoodSpawnRate.ValueChanged, Sub() UpdateSettings()
        AddHandler nup_MaxFoodTime.ValueChanged, Sub() UpdateSettings()
        AddHandler nup_MaxFoodTime.ValueChanged, Sub() UpdateSettings()
        AddHandler btn_Menustrip_Reset.Click, Sub() ResetSimulation()
        AddHandler tsp_Reset.Click, Sub() ResetSimulation()
        AddHandler ExitToolStripMenuItem.Click, Sub() End
        AddHandler btn_Menustrip_Pause.Click, Sub() pause()
        AddHandler tsb_PausePlay.Click, Sub() pause()


        tpsTimer.Start()


    End Sub
    Sub UpdateTPS()

        lbl_TicksThisSecond.Text = $"Ticks/s: {sim.TicksThisSecond * 2}"
        sim.TicksThisSecond = 0
    End Sub
    Sub setspeed(p_speed As Integer)
        Select Case speed
            Case 0
                t.Interval = 250
            Case 1
                t.Interval = 75
            Case 2
                t.Interval = 1
        End Select
    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles tsb_SimulationSpeed.Click
        If speed < 2 Then speed += 1 Else speed = 0
        setspeed(speed)
        Select Case speed


            Case 0
                tsb_SimulationSpeed.Image = My.Resources._1x
            Case 1
                tsb_SimulationSpeed.Image = My.Resources._2x
            Case 2
                tsb_SimulationSpeed.Image = My.Resources._3x

        End Select


    End Sub
    Sub pause()
        Select Case paused
            Case True
                tsb_Skip.Visible = False
                t.Start()

            Case False
                tsb_Skip.Visible = True
                t.Stop()
        End Select
        paused = Not paused
    End Sub
    Sub ResetSimulation()
        simgrid.Clear()
        simgrid.GridSize = nup_SimGridSize.Value
        sim = New Simulation(simgrid, nup_Organisms.Value)
        sim.SetParameters(nup_MaxFood.Value, nup_MinFoodTime.Value, nup_MaxFoodTime.Value, nup_FoodSpawnRate.Value, num_TicksPerGeneration.Value)
    End Sub
    Sub UpdateSettings()
        sim.SetParameters(nup_MaxFood.Value, nup_MinFoodTime.Value, nup_MaxFoodTime.Value, nup_FoodSpawnRate.Value, num_TicksPerGeneration.Value)
    End Sub



    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles nup_MinFoodTime.ValueChanged
        nup_MaxFoodTime.Minimum = nup_MinFoodTime.Value
    End Sub

    Private Sub nup_MaxFoodTime_ValueChanged(sender As Object, e As EventArgs) Handles nup_MaxFoodTime.ValueChanged
        nup_MinFoodTime.Maximum = nup_MaxFoodTime.Value
    End Sub

    Private Sub lbl_Highscore_Click(sender As Object, e As EventArgs) Handles lbl_Highscore.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        Try
            Dim psi As New ProcessStartInfo()
            psi.FileName = "https://github.com/SomeReallyRubbishProgrammer/NeuralSim-"
            psi.UseShellExecute = True


            Process.Start(psi)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles tsb_Skip.Click
        sim.updateSimulation()
    End Sub

    Private Sub tsb_PausePlay_Click(sender As Object, e As EventArgs) Handles tsb_PausePlay.Click

    End Sub
End Class
