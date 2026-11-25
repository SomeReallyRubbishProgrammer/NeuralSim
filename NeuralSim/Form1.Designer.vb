<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        ToolTip1 = New ToolTip(components)
        lbl_MaxFood = New Label()
        nup_MaxFood = New NumericUpDown()
        nup_MaxFoodTime = New NumericUpDown()
        lbl_MaxFoodTime = New Label()
        lbl_MinFoodTime = New Label()
        nup_MinFoodTime = New NumericUpDown()
        lbl_HiddenLayerCount = New Label()
        NumericUpDown2 = New NumericUpDown()
        lbl_HiddenLayerNodes = New Label()
        NumericUpDown1 = New NumericUpDown()
        gpb_NeuralNetwork = New GroupBox()
        UpdateTimer = New Timer(components)
        tsp_SimulationControls = New ToolStrip()
        tsb_PausePlay = New ToolStripButton()
        tsb_Skip = New ToolStripButton()
        tsp_Reset = New ToolStripButton()
        tsb_SimulationSpeed = New ToolStripButton()
        ToolStripSeparator4 = New ToolStripSeparator()
        lbl_TicksThisSecond = New ToolStripLabel()
        lbl_TicksThisGeneration = New ToolStripLabel()
        msp_Sumulation = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        btn_Menustrip_Pause = New ToolStripMenuItem()
        btn_Menustrip_Reset = New ToolStripMenuItem()
        toolStripSeparator2 = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem1 = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        tbp_Simulation = New TabPage()
        TableLayoutPanel1 = New TableLayoutPanel()
        gpb_Simulation = New GroupBox()
        lbl_HighestScore = New Label()
        lbl_Highscore = New Label()
        Panel1 = New Panel()
        tbp_SimulationSettings = New TabPage()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        gpb_Food = New GroupBox()
        lbl_FoodSpawnRate = New Label()
        nup_FoodSpawnRate = New NumericUpDown()
        gpb_Generation = New GroupBox()
        num_TicksPerGeneration = New NumericUpDown()
        lbl_TicksPerGeneration = New Label()
        gpb_Organisms = New GroupBox()
        nup_Organisms = New NumericUpDown()
        lbl_OrganismCount = New Label()
        gpb_SimulationGrid = New GroupBox()
        nup_SimGridSize = New NumericUpDown()
        lbl_SimGridSize = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        tsc_Simulation = New ToolStripContainer()
        PrefrencesToolStripMenuItem = New ToolStripMenuItem()
        DarkModeToolStripMenuItem = New ToolStripMenuItem()
        CType(nup_MaxFood, ComponentModel.ISupportInitialize).BeginInit()
        CType(nup_MaxFoodTime, ComponentModel.ISupportInitialize).BeginInit()
        CType(nup_MinFoodTime, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        gpb_NeuralNetwork.SuspendLayout()
        tsp_SimulationControls.SuspendLayout()
        msp_Sumulation.SuspendLayout()
        TabControl1.SuspendLayout()
        tbp_Simulation.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        gpb_Simulation.SuspendLayout()
        tbp_SimulationSettings.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        gpb_Food.SuspendLayout()
        CType(nup_FoodSpawnRate, ComponentModel.ISupportInitialize).BeginInit()
        gpb_Generation.SuspendLayout()
        CType(num_TicksPerGeneration, ComponentModel.ISupportInitialize).BeginInit()
        gpb_Organisms.SuspendLayout()
        CType(nup_Organisms, ComponentModel.ISupportInitialize).BeginInit()
        gpb_SimulationGrid.SuspendLayout()
        CType(nup_SimGridSize, ComponentModel.ISupportInitialize).BeginInit()
        tsc_Simulation.BottomToolStripPanel.SuspendLayout()
        tsc_Simulation.ContentPanel.SuspendLayout()
        tsc_Simulation.SuspendLayout()
        SuspendLayout()
        ' 
        ' lbl_MaxFood
        ' 
        lbl_MaxFood.AutoSize = True
        lbl_MaxFood.Location = New Point(6, 19)
        lbl_MaxFood.Name = "lbl_MaxFood"
        lbl_MaxFood.Size = New Size(59, 15)
        lbl_MaxFood.TabIndex = 0
        lbl_MaxFood.Text = "Max Food"
        ToolTip1.SetToolTip(lbl_MaxFood, "Maximum number of food cells on the grid at any point in time")
        ' 
        ' nup_MaxFood
        ' 
        nup_MaxFood.Location = New Point(156, 17)
        nup_MaxFood.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nup_MaxFood.Name = "nup_MaxFood"
        nup_MaxFood.Size = New Size(120, 23)
        nup_MaxFood.TabIndex = 3
        ToolTip1.SetToolTip(nup_MaxFood, "Maximum number of food cells on the grid at any point in time")
        nup_MaxFood.Value = New Decimal(New Integer() {10, 0, 0, 0})
        ' 
        ' nup_MaxFoodTime
        ' 
        nup_MaxFoodTime.Location = New Point(156, 104)
        nup_MaxFoodTime.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        nup_MaxFoodTime.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nup_MaxFoodTime.Name = "nup_MaxFoodTime"
        nup_MaxFoodTime.Size = New Size(120, 23)
        nup_MaxFoodTime.TabIndex = 7
        ToolTip1.SetToolTip(nup_MaxFoodTime, "Maximum amount of time food can remain on the grid for measured in ticks")
        nup_MaxFoodTime.Value = New Decimal(New Integer() {200, 0, 0, 0})
        ' 
        ' lbl_MaxFoodTime
        ' 
        lbl_MaxFoodTime.AutoSize = True
        lbl_MaxFoodTime.Location = New Point(6, 106)
        lbl_MaxFoodTime.Name = "lbl_MaxFoodTime"
        lbl_MaxFoodTime.Size = New Size(89, 15)
        lbl_MaxFoodTime.TabIndex = 6
        lbl_MaxFoodTime.Text = "Max Food Time"
        ToolTip1.SetToolTip(lbl_MaxFoodTime, "Maximum amount of time food can remain on the grid for measured in ticks")
        ' 
        ' lbl_MinFoodTime
        ' 
        lbl_MinFoodTime.AutoSize = True
        lbl_MinFoodTime.Location = New Point(6, 77)
        lbl_MinFoodTime.Name = "lbl_MinFoodTime"
        lbl_MinFoodTime.Size = New Size(88, 15)
        lbl_MinFoodTime.TabIndex = 2
        lbl_MinFoodTime.Text = "Min Food Time"
        ToolTip1.SetToolTip(lbl_MinFoodTime, "Minimum amount of time food can remain on the grid for measured in ticks")
        ' 
        ' nup_MinFoodTime
        ' 
        nup_MinFoodTime.Location = New Point(156, 75)
        nup_MinFoodTime.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        nup_MinFoodTime.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nup_MinFoodTime.Name = "nup_MinFoodTime"
        nup_MinFoodTime.Size = New Size(120, 23)
        nup_MinFoodTime.TabIndex = 5
        ToolTip1.SetToolTip(nup_MinFoodTime, "Minimum amount of time food can remain on the grid for measured in ticks")
        nup_MinFoodTime.Value = New Decimal(New Integer() {100, 0, 0, 0})
        ' 
        ' lbl_HiddenLayerCount
        ' 
        lbl_HiddenLayerCount.AutoSize = True
        lbl_HiddenLayerCount.Location = New Point(6, 48)
        lbl_HiddenLayerCount.Name = "lbl_HiddenLayerCount"
        lbl_HiddenLayerCount.Size = New Size(82, 15)
        lbl_HiddenLayerCount.TabIndex = 13
        lbl_HiddenLayerCount.Text = "Hidden Layers"
        ToolTip1.SetToolTip(lbl_HiddenLayerCount, "Number of hidden layers in all neural networks")
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.Location = New Point(156, 46)
        NumericUpDown2.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(120, 23)
        NumericUpDown2.TabIndex = 14
        ToolTip1.SetToolTip(NumericUpDown2, "Number of hidden layers in all neural networks")
        NumericUpDown2.Value = New Decimal(New Integer() {5, 0, 0, 0})
        ' 
        ' lbl_HiddenLayerNodes
        ' 
        lbl_HiddenLayerNodes.AutoSize = True
        lbl_HiddenLayerNodes.Location = New Point(6, 19)
        lbl_HiddenLayerNodes.Name = "lbl_HiddenLayerNodes"
        lbl_HiddenLayerNodes.Size = New Size(114, 15)
        lbl_HiddenLayerNodes.TabIndex = 11
        lbl_HiddenLayerNodes.Text = "Hidden Layer Nodes"
        ToolTip1.SetToolTip(lbl_HiddenLayerNodes, "Number of nodes in all hidden layers")
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(156, 17)
        NumericUpDown1.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(120, 23)
        NumericUpDown1.TabIndex = 12
        ToolTip1.SetToolTip(NumericUpDown1, "Number of nodes in all hidden layers")
        NumericUpDown1.Value = New Decimal(New Integer() {10, 0, 0, 0})
        ' 
        ' gpb_NeuralNetwork
        ' 
        gpb_NeuralNetwork.AutoSize = True
        gpb_NeuralNetwork.AutoSizeMode = AutoSizeMode.GrowAndShrink
        gpb_NeuralNetwork.Controls.Add(lbl_HiddenLayerCount)
        gpb_NeuralNetwork.Controls.Add(NumericUpDown2)
        gpb_NeuralNetwork.Controls.Add(lbl_HiddenLayerNodes)
        gpb_NeuralNetwork.Controls.Add(NumericUpDown1)
        gpb_NeuralNetwork.Location = New Point(3, 3)
        gpb_NeuralNetwork.Name = "gpb_NeuralNetwork"
        gpb_NeuralNetwork.Size = New Size(282, 91)
        gpb_NeuralNetwork.TabIndex = 10
        gpb_NeuralNetwork.TabStop = False
        gpb_NeuralNetwork.Text = "Neural Networks"
        ' 
        ' tsp_SimulationControls
        ' 
        tsp_SimulationControls.Dock = DockStyle.None
        tsp_SimulationControls.Items.AddRange(New ToolStripItem() {tsb_PausePlay, tsb_Skip, tsp_Reset, tsb_SimulationSpeed, ToolStripSeparator4, lbl_TicksThisSecond, lbl_TicksThisGeneration})
        tsp_SimulationControls.Location = New Point(0, 0)
        tsp_SimulationControls.Name = "tsp_SimulationControls"
        tsp_SimulationControls.Size = New Size(664, 26)
        tsp_SimulationControls.Stretch = True
        tsp_SimulationControls.TabIndex = 1
        tsp_SimulationControls.Text = "ToolStrip1"
        ' 
        ' tsb_PausePlay
        ' 
        tsb_PausePlay.AutoSize = False
        tsb_PausePlay.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsb_PausePlay.Image = My.Resources.Resources.Play
        tsb_PausePlay.ImageTransparentColor = Color.Magenta
        tsb_PausePlay.Name = "tsb_PausePlay"
        tsb_PausePlay.Size = New Size(23, 23)
        tsb_PausePlay.Text = "Pause Simulation"
        ' 
        ' tsb_Skip
        ' 
        tsb_Skip.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsb_Skip.Image = My.Resources.Resources.Skip1
        tsb_Skip.ImageTransparentColor = Color.Magenta
        tsb_Skip.Name = "tsb_Skip"
        tsb_Skip.Size = New Size(23, 23)
        tsb_Skip.Text = "ToolStripButton1"
        tsb_Skip.ToolTipText = "Jump 1 tick in the simulation"
        ' 
        ' tsp_Reset
        ' 
        tsp_Reset.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsp_Reset.Image = My.Resources.Resources.Reset
        tsp_Reset.ImageTransparentColor = Color.Magenta
        tsp_Reset.Name = "tsp_Reset"
        tsp_Reset.Size = New Size(23, 23)
        tsp_Reset.Text = "Reset Simulation"
        ' 
        ' tsb_SimulationSpeed
        ' 
        tsb_SimulationSpeed.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsb_SimulationSpeed.Image = My.Resources.Resources._1x
        tsb_SimulationSpeed.ImageTransparentColor = Color.Magenta
        tsb_SimulationSpeed.Name = "tsb_SimulationSpeed"
        tsb_SimulationSpeed.Size = New Size(23, 23)
        tsb_SimulationSpeed.Text = "ToolStripButton3"
        tsb_SimulationSpeed.ToolTipText = "Target simulation speed"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(6, 26)
        ' 
        ' lbl_TicksThisSecond
        ' 
        lbl_TicksThisSecond.Name = "lbl_TicksThisSecond"
        lbl_TicksThisSecond.Size = New Size(55, 23)
        lbl_TicksThisSecond.Text = "Ticks/s: -"
        lbl_TicksThisSecond.ToolTipText = "Current number of ticks per second"
        ' 
        ' lbl_TicksThisGeneration
        ' 
        lbl_TicksThisGeneration.Name = "lbl_TicksThisGeneration"
        lbl_TicksThisGeneration.Size = New Size(47, 23)
        lbl_TicksThisGeneration.Text = "Tick -/-"
        lbl_TicksThisGeneration.ToolTipText = "Current tick"
        ' 
        ' msp_Sumulation
        ' 
        msp_Sumulation.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, PrefrencesToolStripMenuItem, HelpToolStripMenuItem})
        msp_Sumulation.Location = New Point(0, 0)
        msp_Sumulation.Name = "msp_Sumulation"
        msp_Sumulation.Size = New Size(664, 24)
        msp_Sumulation.TabIndex = 2
        msp_Sumulation.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {btn_Menustrip_Pause, btn_Menustrip_Reset, toolStripSeparator2, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(76, 20)
        FileToolStripMenuItem.Text = "Simulation"
        ' 
        ' btn_Menustrip_Pause
        ' 
        btn_Menustrip_Pause.Image = CType(resources.GetObject("btn_Menustrip_Pause.Image"), Image)
        btn_Menustrip_Pause.ImageTransparentColor = Color.Magenta
        btn_Menustrip_Pause.Name = "btn_Menustrip_Pause"
        btn_Menustrip_Pause.ShortcutKeys = Keys.Control Or Keys.K
        btn_Menustrip_Pause.Size = New Size(146, 22)
        btn_Menustrip_Pause.Text = "&Pause"
        ' 
        ' btn_Menustrip_Reset
        ' 
        btn_Menustrip_Reset.Image = CType(resources.GetObject("btn_Menustrip_Reset.Image"), Image)
        btn_Menustrip_Reset.ImageTransparentColor = Color.Magenta
        btn_Menustrip_Reset.Name = "btn_Menustrip_Reset"
        btn_Menustrip_Reset.ShortcutKeys = Keys.Control Or Keys.R
        btn_Menustrip_Reset.Size = New Size(146, 22)
        btn_Menustrip_Reset.Tag = ""
        btn_Menustrip_Reset.Text = "&Reset"
        ' 
        ' toolStripSeparator2
        ' 
        toolStripSeparator2.Name = "toolStripSeparator2"
        toolStripSeparator2.Size = New Size(143, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(146, 22)
        ExitToolStripMenuItem.Text = "E&xit"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem, HelpToolStripMenuItem1})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(180, 22)
        AboutToolStripMenuItem.Text = "&About..."
        ' 
        ' HelpToolStripMenuItem1
        ' 
        HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        HelpToolStripMenuItem1.Size = New Size(180, 22)
        HelpToolStripMenuItem1.Text = "Help"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tbp_Simulation)
        TabControl1.Controls.Add(tbp_SimulationSettings)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(664, 413)
        TabControl1.TabIndex = 3
        ' 
        ' tbp_Simulation
        ' 
        tbp_Simulation.Controls.Add(TableLayoutPanel1)
        tbp_Simulation.Location = New Point(4, 24)
        tbp_Simulation.Name = "tbp_Simulation"
        tbp_Simulation.Padding = New Padding(3)
        tbp_Simulation.Size = New Size(656, 385)
        tbp_Simulation.TabIndex = 0
        tbp_Simulation.Text = "Simulation"
        tbp_Simulation.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 200F))
        TableLayoutPanel1.Controls.Add(gpb_Simulation, 1, 0)
        TableLayoutPanel1.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(3, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(650, 379)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' gpb_Simulation
        ' 
        gpb_Simulation.Controls.Add(lbl_HighestScore)
        gpb_Simulation.Controls.Add(lbl_Highscore)
        gpb_Simulation.Dock = DockStyle.Fill
        gpb_Simulation.Location = New Point(453, 3)
        gpb_Simulation.Name = "gpb_Simulation"
        gpb_Simulation.Size = New Size(194, 373)
        gpb_Simulation.TabIndex = 1
        gpb_Simulation.TabStop = False
        gpb_Simulation.Text = "Simulation"
        ' 
        ' lbl_HighestScore
        ' 
        lbl_HighestScore.AutoSize = True
        lbl_HighestScore.Location = New Point(6, 19)
        lbl_HighestScore.Name = "lbl_HighestScore"
        lbl_HighestScore.Size = New Size(80, 15)
        lbl_HighestScore.TabIndex = 1
        lbl_HighestScore.Text = "Highest Score"
        ' 
        ' lbl_Highscore
        ' 
        lbl_Highscore.Location = New Point(147, 19)
        lbl_Highscore.Name = "lbl_Highscore"
        lbl_Highscore.Size = New Size(41, 15)
        lbl_Highscore.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(444, 373)
        Panel1.TabIndex = 1
        ' 
        ' tbp_SimulationSettings
        ' 
        tbp_SimulationSettings.Controls.Add(FlowLayoutPanel2)
        tbp_SimulationSettings.Controls.Add(FlowLayoutPanel1)
        tbp_SimulationSettings.Location = New Point(4, 24)
        tbp_SimulationSettings.Name = "tbp_SimulationSettings"
        tbp_SimulationSettings.Padding = New Padding(3)
        tbp_SimulationSettings.Size = New Size(656, 385)
        tbp_SimulationSettings.TabIndex = 1
        tbp_SimulationSettings.Text = "Simulation Settings"
        tbp_SimulationSettings.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel2.Controls.Add(gpb_NeuralNetwork)
        FlowLayoutPanel2.Controls.Add(gpb_Food)
        FlowLayoutPanel2.Controls.Add(gpb_Generation)
        FlowLayoutPanel2.Controls.Add(gpb_Organisms)
        FlowLayoutPanel2.Controls.Add(gpb_SimulationGrid)
        FlowLayoutPanel2.Dock = DockStyle.Fill
        FlowLayoutPanel2.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel2.Location = New Point(3, 3)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(650, 379)
        FlowLayoutPanel2.TabIndex = 12
        ' 
        ' gpb_Food
        ' 
        gpb_Food.AutoSize = True
        gpb_Food.AutoSizeMode = AutoSizeMode.GrowAndShrink
        gpb_Food.Controls.Add(lbl_MaxFood)
        gpb_Food.Controls.Add(nup_MaxFoodTime)
        gpb_Food.Controls.Add(lbl_FoodSpawnRate)
        gpb_Food.Controls.Add(lbl_MaxFoodTime)
        gpb_Food.Controls.Add(lbl_MinFoodTime)
        gpb_Food.Controls.Add(nup_MinFoodTime)
        gpb_Food.Controls.Add(nup_MaxFood)
        gpb_Food.Controls.Add(nup_FoodSpawnRate)
        gpb_Food.Location = New Point(3, 100)
        gpb_Food.Name = "gpb_Food"
        gpb_Food.Size = New Size(282, 149)
        gpb_Food.TabIndex = 8
        gpb_Food.TabStop = False
        gpb_Food.Text = "Food"
        ' 
        ' lbl_FoodSpawnRate
        ' 
        lbl_FoodSpawnRate.AutoSize = True
        lbl_FoodSpawnRate.Location = New Point(6, 48)
        lbl_FoodSpawnRate.Name = "lbl_FoodSpawnRate"
        lbl_FoodSpawnRate.Size = New Size(98, 15)
        lbl_FoodSpawnRate.TabIndex = 1
        lbl_FoodSpawnRate.Text = "Food Spawn Rate"
        ' 
        ' nup_FoodSpawnRate
        ' 
        nup_FoodSpawnRate.Location = New Point(156, 46)
        nup_FoodSpawnRate.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nup_FoodSpawnRate.Name = "nup_FoodSpawnRate"
        nup_FoodSpawnRate.Size = New Size(120, 23)
        nup_FoodSpawnRate.TabIndex = 4
        nup_FoodSpawnRate.Value = New Decimal(New Integer() {50, 0, 0, 0})
        ' 
        ' gpb_Generation
        ' 
        gpb_Generation.AutoSize = True
        gpb_Generation.AutoSizeMode = AutoSizeMode.GrowAndShrink
        gpb_Generation.Controls.Add(num_TicksPerGeneration)
        gpb_Generation.Controls.Add(lbl_TicksPerGeneration)
        gpb_Generation.Location = New Point(3, 255)
        gpb_Generation.Name = "gpb_Generation"
        gpb_Generation.Size = New Size(282, 62)
        gpb_Generation.TabIndex = 9
        gpb_Generation.TabStop = False
        gpb_Generation.Text = "Genaration"
        ' 
        ' num_TicksPerGeneration
        ' 
        num_TicksPerGeneration.Location = New Point(156, 17)
        num_TicksPerGeneration.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        num_TicksPerGeneration.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        num_TicksPerGeneration.Name = "num_TicksPerGeneration"
        num_TicksPerGeneration.Size = New Size(120, 23)
        num_TicksPerGeneration.TabIndex = 8
        num_TicksPerGeneration.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        ' 
        ' lbl_TicksPerGeneration
        ' 
        lbl_TicksPerGeneration.AutoSize = True
        lbl_TicksPerGeneration.Location = New Point(6, 19)
        lbl_TicksPerGeneration.Name = "lbl_TicksPerGeneration"
        lbl_TicksPerGeneration.Size = New Size(115, 15)
        lbl_TicksPerGeneration.TabIndex = 10
        lbl_TicksPerGeneration.Text = "Ticks Per Generation"
        ' 
        ' gpb_Organisms
        ' 
        gpb_Organisms.AutoSize = True
        gpb_Organisms.AutoSizeMode = AutoSizeMode.GrowAndShrink
        gpb_Organisms.Controls.Add(nup_Organisms)
        gpb_Organisms.Controls.Add(lbl_OrganismCount)
        gpb_Organisms.Location = New Point(291, 3)
        gpb_Organisms.Name = "gpb_Organisms"
        gpb_Organisms.Size = New Size(282, 62)
        gpb_Organisms.TabIndex = 11
        gpb_Organisms.TabStop = False
        gpb_Organisms.Text = "Organisms"
        ' 
        ' nup_Organisms
        ' 
        nup_Organisms.Location = New Point(156, 17)
        nup_Organisms.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        nup_Organisms.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        nup_Organisms.Name = "nup_Organisms"
        nup_Organisms.Size = New Size(120, 23)
        nup_Organisms.TabIndex = 8
        nup_Organisms.Value = New Decimal(New Integer() {100, 0, 0, 0})
        ' 
        ' lbl_OrganismCount
        ' 
        lbl_OrganismCount.AutoSize = True
        lbl_OrganismCount.Location = New Point(6, 19)
        lbl_OrganismCount.Name = "lbl_OrganismCount"
        lbl_OrganismCount.Size = New Size(95, 15)
        lbl_OrganismCount.TabIndex = 10
        lbl_OrganismCount.Text = "Organism Count"
        ' 
        ' gpb_SimulationGrid
        ' 
        gpb_SimulationGrid.AutoSize = True
        gpb_SimulationGrid.AutoSizeMode = AutoSizeMode.GrowAndShrink
        gpb_SimulationGrid.Controls.Add(nup_SimGridSize)
        gpb_SimulationGrid.Controls.Add(lbl_SimGridSize)
        gpb_SimulationGrid.Location = New Point(291, 71)
        gpb_SimulationGrid.Name = "gpb_SimulationGrid"
        gpb_SimulationGrid.Size = New Size(282, 62)
        gpb_SimulationGrid.TabIndex = 12
        gpb_SimulationGrid.TabStop = False
        gpb_SimulationGrid.Text = "Simulation Grid"
        ' 
        ' nup_SimGridSize
        ' 
        nup_SimGridSize.Location = New Point(156, 17)
        nup_SimGridSize.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        nup_SimGridSize.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        nup_SimGridSize.Name = "nup_SimGridSize"
        nup_SimGridSize.Size = New Size(120, 23)
        nup_SimGridSize.TabIndex = 8
        nup_SimGridSize.Value = New Decimal(New Integer() {25, 0, 0, 0})
        ' 
        ' lbl_SimGridSize
        ' 
        lbl_SimGridSize.AutoSize = True
        lbl_SimGridSize.Location = New Point(6, 19)
        lbl_SimGridSize.Name = "lbl_SimGridSize"
        lbl_SimGridSize.Size = New Size(27, 15)
        lbl_SimGridSize.TabIndex = 10
        lbl_SimGridSize.Text = "Size"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoSize = True
        FlowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        FlowLayoutPanel1.Location = New Point(293, 123)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(0, 0)
        FlowLayoutPanel1.TabIndex = 11
        ' 
        ' tsc_Simulation
        ' 
        ' 
        ' tsc_Simulation.BottomToolStripPanel
        ' 
        tsc_Simulation.BottomToolStripPanel.Controls.Add(tsp_SimulationControls)
        ' 
        ' tsc_Simulation.ContentPanel
        ' 
        tsc_Simulation.ContentPanel.Controls.Add(TabControl1)
        tsc_Simulation.ContentPanel.Size = New Size(664, 413)
        tsc_Simulation.Dock = DockStyle.Fill
        tsc_Simulation.LeftToolStripPanelVisible = False
        tsc_Simulation.Location = New Point(0, 24)
        tsc_Simulation.Name = "tsc_Simulation"
        tsc_Simulation.RightToolStripPanelVisible = False
        tsc_Simulation.Size = New Size(664, 464)
        tsc_Simulation.TabIndex = 0
        tsc_Simulation.Text = "ToolStripContainer1"
        ' 
        ' PrefrencesToolStripMenuItem
        ' 
        PrefrencesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DarkModeToolStripMenuItem})
        PrefrencesToolStripMenuItem.Name = "PrefrencesToolStripMenuItem"
        PrefrencesToolStripMenuItem.Size = New Size(74, 20)
        PrefrencesToolStripMenuItem.Text = "Prefrences"
        ' 
        ' DarkModeToolStripMenuItem
        ' 
        DarkModeToolStripMenuItem.Name = "DarkModeToolStripMenuItem"
        DarkModeToolStripMenuItem.Size = New Size(180, 22)
        DarkModeToolStripMenuItem.Text = "Dark Mode"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnablePreventFocusChange
        ClientSize = New Size(664, 488)
        Controls.Add(tsc_Simulation)
        Controls.Add(msp_Sumulation)
        MainMenuStrip = msp_Sumulation
        Name = "Form1"
        Text = "Neural Sim"
        TransparencyKey = Color.MintCream
        CType(nup_MaxFood, ComponentModel.ISupportInitialize).EndInit()
        CType(nup_MaxFoodTime, ComponentModel.ISupportInitialize).EndInit()
        CType(nup_MinFoodTime, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        gpb_NeuralNetwork.ResumeLayout(False)
        gpb_NeuralNetwork.PerformLayout()
        tsp_SimulationControls.ResumeLayout(False)
        tsp_SimulationControls.PerformLayout()
        msp_Sumulation.ResumeLayout(False)
        msp_Sumulation.PerformLayout()
        TabControl1.ResumeLayout(False)
        tbp_Simulation.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        gpb_Simulation.ResumeLayout(False)
        gpb_Simulation.PerformLayout()
        tbp_SimulationSettings.ResumeLayout(False)
        tbp_SimulationSettings.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        gpb_Food.ResumeLayout(False)
        gpb_Food.PerformLayout()
        CType(nup_FoodSpawnRate, ComponentModel.ISupportInitialize).EndInit()
        gpb_Generation.ResumeLayout(False)
        gpb_Generation.PerformLayout()
        CType(num_TicksPerGeneration, ComponentModel.ISupportInitialize).EndInit()
        gpb_Organisms.ResumeLayout(False)
        gpb_Organisms.PerformLayout()
        CType(nup_Organisms, ComponentModel.ISupportInitialize).EndInit()
        gpb_SimulationGrid.ResumeLayout(False)
        gpb_SimulationGrid.PerformLayout()
        CType(nup_SimGridSize, ComponentModel.ISupportInitialize).EndInit()
        tsc_Simulation.BottomToolStripPanel.ResumeLayout(False)
        tsc_Simulation.BottomToolStripPanel.PerformLayout()
        tsc_Simulation.ContentPanel.ResumeLayout(False)
        tsc_Simulation.ResumeLayout(False)
        tsc_Simulation.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Public WithEvents ToolTip1 As ToolTip
    Friend WithEvents UpdateTimer As Timer
    Friend WithEvents tsp_SimulationControls As ToolStrip
    Friend WithEvents msp_Sumulation As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_Menustrip_Pause As ToolStripMenuItem
    Friend WithEvents btn_Menustrip_Reset As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbp_Simulation As TabPage
    Friend WithEvents tbp_SimulationSettings As TabPage
    Friend WithEvents tsb_PausePlay As ToolStripButton
    Friend WithEvents tsp_Reset As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tsb_SimulationSpeed As ToolStripButton
    Friend WithEvents lbl_TicksThisSecond As ToolStripLabel
    Friend WithEvents lbl_TicksThisGeneration As ToolStripLabel
    Friend WithEvents lbl_MinFoodTime As Label
    Friend WithEvents lbl_FoodSpawnRate As Label
    Friend WithEvents lbl_MaxFood As Label
    Friend WithEvents nup_MinFoodTime As NumericUpDown
    Friend WithEvents nup_FoodSpawnRate As NumericUpDown
    Friend WithEvents nup_MaxFood As NumericUpDown
    Friend WithEvents nup_MaxFoodTime As NumericUpDown
    Friend WithEvents lbl_MaxFoodTime As Label
    Friend WithEvents gpb_Food As GroupBox
    Friend WithEvents gpb_Generation As GroupBox
    Friend WithEvents num_TicksPerGeneration As NumericUpDown
    Friend WithEvents lbl_TicksPerGeneration As Label
    Friend WithEvents gpb_NeuralNetwork As GroupBox
    Friend WithEvents lbl_HiddenLayerCount As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents lbl_HiddenLayerNodes As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents gpb_Simulation As GroupBox
    Friend WithEvents lbl_Highscore As Label
    Friend WithEvents gpb_Organisms As GroupBox
    Friend WithEvents nup_Organisms As NumericUpDown
    Friend WithEvents lbl_OrganismCount As Label
    Friend WithEvents gpb_SimulationGrid As GroupBox
    Friend WithEvents nup_SimGridSize As NumericUpDown
    Friend WithEvents lbl_SimGridSize As Label
    Friend WithEvents lbl_HighestScore As Label
    Friend WithEvents tsb_Skip As ToolStripButton
    Friend WithEvents tsc_Simulation As ToolStripContainer
    Friend WithEvents PrefrencesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DarkModeToolStripMenuItem As ToolStripMenuItem

End Class
