Namespace Datasoft_PIMS
	' Token: 0x0200000D RID: 13
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Dashboard
		Inherits Global.WeifenLuo.WinFormsUI.Docking.DockContent

		' Token: 0x06000097 RID: 151 RVA: 0x00005474 File Offset: 0x00003674
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				Dim flag As Boolean = disposing AndAlso Me.components IsNot Nothing
				If flag Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x06000098 RID: 152 RVA: 0x000054C4 File Offset: 0x000036C4
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim chartArea As Global.System.Windows.Forms.DataVisualization.Charting.ChartArea = New Global.System.Windows.Forms.DataVisualization.Charting.ChartArea()
			Dim legend As Global.System.Windows.Forms.DataVisualization.Charting.Legend = New Global.System.Windows.Forms.DataVisualization.Charting.Legend()
			Dim series As Global.System.Windows.Forms.DataVisualization.Charting.Series = New Global.System.Windows.Forms.DataVisualization.Charting.Series()
			Dim title As Global.System.Windows.Forms.DataVisualization.Charting.Title = New Global.System.Windows.Forms.DataVisualization.Charting.Title()
			Dim chartArea2 As Global.System.Windows.Forms.DataVisualization.Charting.ChartArea = New Global.System.Windows.Forms.DataVisualization.Charting.ChartArea()
			Dim legend2 As Global.System.Windows.Forms.DataVisualization.Charting.Legend = New Global.System.Windows.Forms.DataVisualization.Charting.Legend()
			Dim series2 As Global.System.Windows.Forms.DataVisualization.Charting.Series = New Global.System.Windows.Forms.DataVisualization.Charting.Series()
			Dim title2 As Global.System.Windows.Forms.DataVisualization.Charting.Title = New Global.System.Windows.Forms.DataVisualization.Charting.Title()
			Dim chartArea3 As Global.System.Windows.Forms.DataVisualization.Charting.ChartArea = New Global.System.Windows.Forms.DataVisualization.Charting.ChartArea()
			Dim legend3 As Global.System.Windows.Forms.DataVisualization.Charting.Legend = New Global.System.Windows.Forms.DataVisualization.Charting.Legend()
			Dim series3 As Global.System.Windows.Forms.DataVisualization.Charting.Series = New Global.System.Windows.Forms.DataVisualization.Charting.Series()
			Dim title3 As Global.System.Windows.Forms.DataVisualization.Charting.Title = New Global.System.Windows.Forms.DataVisualization.Charting.Title()
			Dim chartArea4 As Global.System.Windows.Forms.DataVisualization.Charting.ChartArea = New Global.System.Windows.Forms.DataVisualization.Charting.ChartArea()
			Dim legend4 As Global.System.Windows.Forms.DataVisualization.Charting.Legend = New Global.System.Windows.Forms.DataVisualization.Charting.Legend()
			Dim series4 As Global.System.Windows.Forms.DataVisualization.Charting.Series = New Global.System.Windows.Forms.DataVisualization.Charting.Series()
			Dim title4 As Global.System.Windows.Forms.DataVisualization.Charting.Title = New Global.System.Windows.Forms.DataVisualization.Charting.Title()
			Me.SplitContainer1 = New Global.System.Windows.Forms.SplitContainer()
			Me.dgvView = New Global.System.Windows.Forms.DataGridView()
			Me.Description = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Count = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.FormName = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.FormMode = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.TabTextVal = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Chart0 = New Global.System.Windows.Forms.DataVisualization.Charting.Chart()
			Me.TableLayoutPanel1 = New Global.System.Windows.Forms.TableLayoutPanel()
			Me.Chart1 = New Global.System.Windows.Forms.DataVisualization.Charting.Chart()
			Me.Chart3 = New Global.System.Windows.Forms.DataVisualization.Charting.Chart()
			Me.Chart2 = New Global.System.Windows.Forms.DataVisualization.Charting.Chart()
			Me.ContextMenuStrip1 = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.RefreshToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			CType(Me.SplitContainer1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SplitContainer1.Panel1.SuspendLayout()
			Me.SplitContainer1.Panel2.SuspendLayout()
			Me.SplitContainer1.SuspendLayout()
			CType(Me.dgvView, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Chart0, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.TableLayoutPanel1.SuspendLayout()
			CType(Me.Chart1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Chart3, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Chart2, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.ContextMenuStrip1.SuspendLayout()
			MyBase.SuspendLayout()
			Me.SplitContainer1.BackColor = Global.System.Drawing.Color.LightBlue
			Me.SplitContainer1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.SplitContainer1.Location = New Global.System.Drawing.Point(0, 0)
			Me.SplitContainer1.Name = "SplitContainer1"
			Me.SplitContainer1.Orientation = Global.System.Windows.Forms.Orientation.Horizontal
			Me.SplitContainer1.Panel1.Controls.Add(Me.dgvView)
			Me.SplitContainer1.Panel1.Controls.Add(Me.Chart0)
			Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
			Me.SplitContainer1.Size = New Global.System.Drawing.Size(1047, 615)
			Me.SplitContainer1.SplitterDistance = 340
			Me.SplitContainer1.SplitterWidth = 1
			Me.SplitContainer1.TabIndex = 2
			Me.dgvView.AllowUserToAddRows = False
			Me.dgvView.AllowUserToDeleteRows = False
			Me.dgvView.AllowUserToResizeRows = False
			Me.dgvView.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.dgvView.BackgroundColor = Global.System.Drawing.Color.White
			Me.dgvView.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.FromArgb(128, 255, 128)
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.GradientInactiveCaption
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.dgvView.ColumnHeadersVisible = False
			Me.dgvView.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Description, Me.Count, Me.FormName, Me.FormMode, Me.TabTextVal })
			Me.dgvView.GridColor = Global.System.Drawing.Color.LightGray
			Me.dgvView.Location = New Global.System.Drawing.Point(6, 6)
			Me.dgvView.Name = "dgvView"
			Me.dgvView.[ReadOnly] = True
			Me.dgvView.RowHeadersVisible = False
			Me.dgvView.RowHeadersWidth = 30
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.Color.FromArgb(192, 255, 192)
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.Color.Black
			Me.dgvView.RowsDefaultCellStyle = dataGridViewCellStyle2
			Me.dgvView.RowTemplate.Height = 27
			Me.dgvView.RowTemplate.[ReadOnly] = True
			Me.dgvView.SelectionMode = Global.System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
			Me.dgvView.Size = New Global.System.Drawing.Size(551, 333)
			Me.dgvView.TabIndex = 89
			Me.Description.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
			Me.Description.HeaderText = "Description"
			Me.Description.Name = "Description"
			Me.Description.[ReadOnly] = True
			Me.Description.Resizable = Global.System.Windows.Forms.DataGridViewTriState.[True]
			dataGridViewCellStyle3.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.Count.DefaultCellStyle = dataGridViewCellStyle3
			Me.Count.HeaderText = "Count"
			Me.Count.Name = "Count"
			Me.Count.[ReadOnly] = True
			Me.Count.Width = 120
			Me.FormName.HeaderText = "FormName"
			Me.FormName.Name = "FormName"
			Me.FormName.[ReadOnly] = True
			Me.FormName.Visible = False
			Me.FormMode.HeaderText = "FormMode"
			Me.FormMode.Name = "FormMode"
			Me.FormMode.[ReadOnly] = True
			Me.FormMode.Visible = False
			Me.TabTextVal.HeaderText = "TabText"
			Me.TabTextVal.Name = "TabTextVal"
			Me.TabTextVal.[ReadOnly] = True
			Me.TabTextVal.Visible = False
			Me.Chart0.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Chart0.BackColor = Global.System.Drawing.Color.WhiteSmoke
			Me.Chart0.BackGradientStyle = Global.System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
			chartArea.AxisX.ArrowStyle = Global.System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle
			chartArea.AxisX.IsLabelAutoFit = False
			chartArea.AxisX.LabelStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			chartArea.AxisX.MajorGrid.Enabled = False
			chartArea.AxisX.MajorGrid.LineColor = Global.System.Drawing.Color.LightGray
			chartArea.AxisX.MajorGrid.LineDashStyle = Global.System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
			chartArea.AxisX.MinorGrid.LineColor = Global.System.Drawing.Color.Aqua
			chartArea.AxisY.ArrowStyle = Global.System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle
			chartArea.AxisY.IsLabelAutoFit = False
			chartArea.AxisY.LabelStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			chartArea.AxisY.MajorGrid.LineColor = Global.System.Drawing.Color.LightGray
			chartArea.Name = "ChartArea1"
			Me.Chart0.ChartAreas.Add(chartArea)
			legend.Alignment = Global.System.Drawing.StringAlignment.Far
			legend.BackColor = Global.System.Drawing.Color.WhiteSmoke
			legend.Docking = Global.System.Windows.Forms.DataVisualization.Charting.Docking.Top
			legend.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			legend.IsTextAutoFit = False
			legend.Name = "Legend1"
			legend.TitleFont = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Chart0.Legends.Add(legend)
			Me.Chart0.Location = New Global.System.Drawing.Point(564, 6)
			Me.Chart0.Name = "Chart0"
			Me.Chart0.Palette = Global.System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
			series.BackGradientStyle = Global.System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft
			series.ChartArea = "ChartArea1"
			series.Color = Global.System.Drawing.Color.Gold
			series.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			series.IsValueShownAsLabel = True
			series.Legend = "Legend1"
			series.MarkerStep = 100
			series.Name = "Quantity"
			series.YValuesPerPoint = 4
			Me.Chart0.Series.Add(series)
			Me.Chart0.Size = New Global.System.Drawing.Size(477, 339)
			Me.Chart0.TabIndex = 88
			title.BackColor = Global.System.Drawing.Color.FromArgb(22, 112, 170)
			title.BackGradientStyle = Global.System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft
			title.BackSecondaryColor = Global.System.Drawing.Color.FromArgb(0, 42, 103)
			title.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			title.ForeColor = Global.System.Drawing.Color.White
			title.Name = "Title1"
			title.ShadowColor = Global.System.Drawing.Color.DimGray
			title.ShadowOffset = 2
			title.Text = "Material  Received In  Month  Of - "
			Me.Chart0.Titles.Add(title)
			Me.TableLayoutPanel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.TableLayoutPanel1.ColumnCount = 3
			Me.TableLayoutPanel1.ColumnStyles.Add(New Global.System.Windows.Forms.ColumnStyle(Global.System.Windows.Forms.SizeType.Percent, 33.33333F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New Global.System.Windows.Forms.ColumnStyle(Global.System.Windows.Forms.SizeType.Percent, 33.33333F))
			Me.TableLayoutPanel1.ColumnStyles.Add(New Global.System.Windows.Forms.ColumnStyle(Global.System.Windows.Forms.SizeType.Percent, 33.33333F))
			Me.TableLayoutPanel1.Controls.Add(Me.Chart1, 0, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Chart3, 2, 0)
			Me.TableLayoutPanel1.Controls.Add(Me.Chart2, 1, 0)
			Me.TableLayoutPanel1.Location = New Global.System.Drawing.Point(4, 4)
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New Global.System.Windows.Forms.RowStyle(Global.System.Windows.Forms.SizeType.Percent, 100F))
			Me.TableLayoutPanel1.Size = New Global.System.Drawing.Size(1039, 274)
			Me.TableLayoutPanel1.TabIndex = 4
			Me.Chart1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Chart1.BackColor = Global.System.Drawing.Color.WhiteSmoke
			Me.Chart1.BackGradientStyle = Global.System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
			chartArea2.AxisX.ArrowStyle = Global.System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle
			chartArea2.AxisX.IsLabelAutoFit = False
			chartArea2.AxisX.LabelStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			chartArea2.AxisX.MajorGrid.Enabled = False
			chartArea2.AxisX.MajorGrid.LineColor = Global.System.Drawing.Color.LightGray
			chartArea2.AxisX.MajorGrid.LineDashStyle = Global.System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
			chartArea2.AxisX.MinorGrid.LineColor = Global.System.Drawing.Color.Aqua
			chartArea2.AxisY.ArrowStyle = Global.System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle
			chartArea2.AxisY.IsLabelAutoFit = False
			chartArea2.AxisY.LabelStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			chartArea2.AxisY.MajorGrid.LineColor = Global.System.Drawing.Color.LightGray
			chartArea2.Name = "ChartArea1"
			Me.Chart1.ChartAreas.Add(chartArea2)
			legend2.Alignment = Global.System.Drawing.StringAlignment.Far
			legend2.BackColor = Global.System.Drawing.Color.WhiteSmoke
			legend2.Docking = Global.System.Windows.Forms.DataVisualization.Charting.Docking.Top
			legend2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			legend2.IsTextAutoFit = False
			legend2.Name = "Legend1"
			Me.Chart1.Legends.Add(legend2)
			Me.Chart1.Location = New Global.System.Drawing.Point(3, 3)
			Me.Chart1.Name = "Chart1"
			Me.Chart1.Palette = Global.System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
			series2.BackGradientStyle = Global.System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft
			series2.ChartArea = "ChartArea1"
			series2.Color = Global.System.Drawing.Color.Maroon
			series2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			series2.Legend = "Legend1"
			series2.MarkerStep = 100
			series2.Name = "No. Of PO"
			Me.Chart1.Series.Add(series2)
			Me.Chart1.Size = New Global.System.Drawing.Size(340, 268)
			Me.Chart1.TabIndex = 1
			title2.BackColor = Global.System.Drawing.Color.FromArgb(22, 112, 170)
			title2.BackGradientStyle = Global.System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft
			title2.BackSecondaryColor = Global.System.Drawing.Color.FromArgb(0, 42, 103)
			title2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			title2.ForeColor = Global.System.Drawing.Color.White
			title2.Name = "Title1"
			title2.ShadowColor = Global.System.Drawing.Color.DimGray
			title2.ShadowOffset = 2
			title2.Text = "PO Created In Month Of - "
			Me.Chart1.Titles.Add(title2)
			Me.Chart3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Chart3.BackColor = Global.System.Drawing.Color.WhiteSmoke
			Me.Chart3.BackGradientStyle = Global.System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
			chartArea3.Area3DStyle.Enable3D = True
			chartArea3.Area3DStyle.Inclination = 40
			chartArea3.Area3DStyle.IsRightAngleAxes = False
			chartArea3.Area3DStyle.LightStyle = Global.System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
			chartArea3.AxisX.MajorGrid.Enabled = False
			chartArea3.AxisY.MajorGrid.LineColor = Global.System.Drawing.Color.Gainsboro
			chartArea3.Name = "ChartArea1"
			Me.Chart3.ChartAreas.Add(chartArea3)
			legend3.BackColor = Global.System.Drawing.Color.WhiteSmoke
			legend3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			legend3.IsTextAutoFit = False
			legend3.Name = "Legend1"
			Me.Chart3.Legends.Add(legend3)
			Me.Chart3.Location = New Global.System.Drawing.Point(695, 3)
			Me.Chart3.Name = "Chart3"
			Me.Chart3.Palette = Global.System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
			series3.ChartArea = "ChartArea1"
			series3.ChartType = Global.System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
			series3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			series3.IsValueShownAsLabel = True
			series3.Legend = "Legend1"
			series3.Name = "Status"
			series3.YValuesPerPoint = 2
			Me.Chart3.Series.Add(series3)
			Me.Chart3.Size = New Global.System.Drawing.Size(341, 268)
			Me.Chart3.TabIndex = 4
			title3.BackColor = Global.System.Drawing.Color.FromArgb(22, 112, 170)
			title3.BackGradientStyle = Global.System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft
			title3.BackSecondaryColor = Global.System.Drawing.Color.FromArgb(0, 42, 103)
			title3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			title3.ForeColor = Global.System.Drawing.Color.White
			title3.Name = "Title1"
			title3.ShadowColor = Global.System.Drawing.Color.DimGray
			title3.ShadowOffset = 2
			title3.Text = "Material Request In Month Of - "
			Me.Chart3.Titles.Add(title3)
			Me.Chart2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Chart2.BackColor = Global.System.Drawing.Color.WhiteSmoke
			Me.Chart2.BackGradientStyle = Global.System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
			chartArea4.AxisX.IsLabelAutoFit = False
			chartArea4.AxisX.LabelStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			chartArea4.AxisX.MajorGrid.Enabled = False
			chartArea4.AxisX.MajorGrid.LineColor = Global.System.Drawing.Color.LightGray
			chartArea4.AxisX.MajorGrid.LineDashStyle = Global.System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
			chartArea4.AxisX.MinorGrid.LineColor = Global.System.Drawing.Color.Aqua
			chartArea4.AxisY.IsLabelAutoFit = False
			chartArea4.AxisY.LabelStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			chartArea4.AxisY.MajorGrid.LineColor = Global.System.Drawing.Color.Gainsboro
			chartArea4.Name = "ChartArea1"
			Me.Chart2.ChartAreas.Add(chartArea4)
			legend4.Alignment = Global.System.Drawing.StringAlignment.Far
			legend4.BackColor = Global.System.Drawing.Color.Transparent
			legend4.Docking = Global.System.Windows.Forms.DataVisualization.Charting.Docking.Top
			legend4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			legend4.IsTextAutoFit = False
			legend4.Name = "Legend1"
			Me.Chart2.Legends.Add(legend4)
			Me.Chart2.Location = New Global.System.Drawing.Point(349, 3)
			Me.Chart2.Name = "Chart2"
			Me.Chart2.Palette = Global.System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
			series4.BackGradientStyle = Global.System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
			series4.BorderWidth = 2
			series4.ChartArea = "ChartArea1"
			series4.ChartType = Global.System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea
			series4.Color = Global.System.Drawing.Color.DarkMagenta
			series4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			series4.Legend = "Legend1"
			series4.Name = "No. Of GRN"
			Me.Chart2.Series.Add(series4)
			Me.Chart2.Size = New Global.System.Drawing.Size(340, 268)
			Me.Chart2.TabIndex = 92
			title4.BackColor = Global.System.Drawing.Color.FromArgb(22, 112, 170)
			title4.BackGradientStyle = Global.System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft
			title4.BackSecondaryColor = Global.System.Drawing.Color.FromArgb(0, 42, 103)
			title4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			title4.ForeColor = Global.System.Drawing.Color.White
			title4.Name = "Title1"
			title4.ShadowColor = Global.System.Drawing.Color.DimGray
			title4.ShadowOffset = 2
			title4.Text = "GRN Created In Month Of - "
			Me.Chart2.Titles.Add(title4)
			Me.ContextMenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.RefreshToolStripMenuItem })
			Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
			Me.ContextMenuStrip1.Size = New Global.System.Drawing.Size(125, 26)
			Me.RefreshToolStripMenuItem.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
			Me.RefreshToolStripMenuItem.Size = New Global.System.Drawing.Size(124, 22)
			Me.RefreshToolStripMenuItem.Text = "Refresh"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			MyBase.ClientSize = New Global.System.Drawing.Size(1047, 615)
			MyBase.CloseButton = False
			MyBase.CloseButtonVisible = False
			Me.ContextMenuStrip = Me.ContextMenuStrip1
			MyBase.Controls.Add(Me.SplitContainer1)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "Dashboard"
			Me.Text = "Dashboard"
			Me.SplitContainer1.Panel1.ResumeLayout(False)
			Me.SplitContainer1.Panel2.ResumeLayout(False)
			CType(Me.SplitContainer1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.SplitContainer1.ResumeLayout(False)
			CType(Me.dgvView, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Chart0, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.TableLayoutPanel1.ResumeLayout(False)
			CType(Me.Chart1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Chart3, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Chart2, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ContextMenuStrip1.ResumeLayout(False)
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000032 RID: 50
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
