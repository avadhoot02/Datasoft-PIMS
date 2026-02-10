Namespace Datasoft_PIMS
	' Token: 0x02000050 RID: 80
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class DashboardTest
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000E3E RID: 3646 RVA: 0x00080480 File Offset: 0x0007E680
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

		' Token: 0x06000E3F RID: 3647 RVA: 0x000804D0 File Offset: 0x0007E6D0
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
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
			Me.btnGen = New Global.System.Windows.Forms.Button()
			Me.TableLayoutPanel1 = New Global.System.Windows.Forms.TableLayoutPanel()
			Me.ChartPO = New Global.System.Windows.Forms.DataVisualization.Charting.Chart()
			Me.ChartPOStatus = New Global.System.Windows.Forms.DataVisualization.Charting.Chart()
			Me.Chart2 = New Global.System.Windows.Forms.DataVisualization.Charting.Chart()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Chart1 = New Global.System.Windows.Forms.DataVisualization.Charting.Chart()
			Me.TableLayoutPanel1.SuspendLayout()
			CType(Me.ChartPO, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ChartPOStatus, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.Chart2, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel1.SuspendLayout()
			CType(Me.Chart1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.btnGen.Location = New Global.System.Drawing.Point(12, 12)
			Me.btnGen.Name = "btnGen"
			Me.btnGen.Size = New Global.System.Drawing.Size(75, 23)
			Me.btnGen.TabIndex = 3
			Me.btnGen.Text = "Generate"
			Me.btnGen.UseVisualStyleBackColor = True
			Me.TableLayoutPanel1.ColumnCount = 1
			Me.TableLayoutPanel1.ColumnStyles.Add(New Global.System.Windows.Forms.ColumnStyle(Global.System.Windows.Forms.SizeType.Percent, 33.33333F))
			Me.TableLayoutPanel1.Controls.Add(Me.Chart2, 0, 0)
			Me.TableLayoutPanel1.Location = New Global.System.Drawing.Point(7, 41)
			Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
			Me.TableLayoutPanel1.RowCount = 1
			Me.TableLayoutPanel1.RowStyles.Add(New Global.System.Windows.Forms.RowStyle(Global.System.Windows.Forms.SizeType.Percent, 100F))
			Me.TableLayoutPanel1.RowStyles.Add(New Global.System.Windows.Forms.RowStyle(Global.System.Windows.Forms.SizeType.Absolute, 20F))
			Me.TableLayoutPanel1.Size = New Global.System.Drawing.Size(390, 274)
			Me.TableLayoutPanel1.TabIndex = 5
			Me.ChartPO.BackColor = Global.System.Drawing.Color.WhiteSmoke
			Me.ChartPO.BackGradientStyle = Global.System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
			chartArea.Area3DStyle.Inclination = 60
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
			Me.ChartPO.ChartAreas.Add(chartArea)
			legend.Alignment = Global.System.Drawing.StringAlignment.Far
			legend.BackColor = Global.System.Drawing.Color.WhiteSmoke
			legend.Docking = Global.System.Windows.Forms.DataVisualization.Charting.Docking.Top
			legend.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			legend.IsTextAutoFit = False
			legend.Name = "Legend1"
			Me.ChartPO.Legends.Add(legend)
			Me.ChartPO.Location = New Global.System.Drawing.Point(5, 3)
			Me.ChartPO.Name = "ChartPO"
			Me.ChartPO.Palette = Global.System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
			series.BackGradientStyle = Global.System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft
			series.ChartArea = "ChartArea1"
			series.Color = Global.System.Drawing.Color.Maroon
			series.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			series.IsValueShownAsLabel = True
			series.Legend = "Legend1"
			series.MarkerStep = 100
			series.Name = "No. Of PO"
			Me.ChartPO.Series.Add(series)
			Me.ChartPO.Size = New Global.System.Drawing.Size(351, 268)
			Me.ChartPO.TabIndex = 1
			title.BackColor = Global.System.Drawing.Color.FromArgb(22, 112, 170)
			title.BackGradientStyle = Global.System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft
			title.BackSecondaryColor = Global.System.Drawing.Color.FromArgb(0, 42, 103)
			title.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			title.ForeColor = Global.System.Drawing.Color.White
			title.Name = "Title1"
			title.ShadowColor = Global.System.Drawing.Color.DimGray
			title.ShadowOffset = 2
			title.Text = "PO Created In Month Of - "
			Me.ChartPO.Titles.Add(title)
			Me.ChartPOStatus.BackColor = Global.System.Drawing.Color.WhiteSmoke
			Me.ChartPOStatus.BackGradientStyle = Global.System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
			chartArea2.Area3DStyle.Enable3D = True
			chartArea2.Area3DStyle.Inclination = 40
			chartArea2.Area3DStyle.IsRightAngleAxes = False
			chartArea2.Area3DStyle.LightStyle = Global.System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
			chartArea2.AxisX.MajorGrid.Enabled = False
			chartArea2.AxisY.MajorGrid.LineColor = Global.System.Drawing.Color.Gainsboro
			chartArea2.Name = "ChartArea1"
			Me.ChartPOStatus.ChartAreas.Add(chartArea2)
			legend2.BackColor = Global.System.Drawing.Color.WhiteSmoke
			legend2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			legend2.IsTextAutoFit = False
			legend2.Name = "Legend1"
			Me.ChartPOStatus.Legends.Add(legend2)
			Me.ChartPOStatus.Location = New Global.System.Drawing.Point(361, 3)
			Me.ChartPOStatus.Margin = New Global.System.Windows.Forms.Padding(30)
			Me.ChartPOStatus.Name = "ChartPOStatus"
			Me.ChartPOStatus.Palette = Global.System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
			series2.ChartArea = "ChartArea1"
			series2.ChartType = Global.System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
			series2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			series2.IsValueShownAsLabel = True
			series2.Legend = "Legend1"
			series2.Name = "Status"
			series2.YValuesPerPoint = 2
			Me.ChartPOStatus.Series.Add(series2)
			Me.ChartPOStatus.Size = New Global.System.Drawing.Size(351, 268)
			Me.ChartPOStatus.TabIndex = 4
			title2.BackColor = Global.System.Drawing.Color.FromArgb(22, 112, 170)
			title2.BackGradientStyle = Global.System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft
			title2.BackSecondaryColor = Global.System.Drawing.Color.FromArgb(0, 42, 103)
			title2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			title2.ForeColor = Global.System.Drawing.Color.White
			title2.Name = "Title1"
			title2.ShadowColor = Global.System.Drawing.Color.DimGray
			title2.ShadowOffset = 2
			title2.Text = "PO Status"
			Me.ChartPOStatus.Titles.Add(title2)
			Me.Chart2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Chart2.BackColor = Global.System.Drawing.Color.WhiteSmoke
			Me.Chart2.BackGradientStyle = Global.System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
			chartArea3.AxisX.IsLabelAutoFit = False
			chartArea3.AxisX.LabelStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			chartArea3.AxisX.MajorGrid.Enabled = False
			chartArea3.AxisX.MajorGrid.LineColor = Global.System.Drawing.Color.LightGray
			chartArea3.AxisX.MajorGrid.LineDashStyle = Global.System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
			chartArea3.AxisX.MinorGrid.LineColor = Global.System.Drawing.Color.Aqua
			chartArea3.AxisY.IsLabelAutoFit = False
			chartArea3.AxisY.LabelStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			chartArea3.AxisY.MajorGrid.LineColor = Global.System.Drawing.Color.Gainsboro
			chartArea3.Name = "ChartArea1"
			Me.Chart2.ChartAreas.Add(chartArea3)
			legend3.Alignment = Global.System.Drawing.StringAlignment.Far
			legend3.BackColor = Global.System.Drawing.Color.Transparent
			legend3.Docking = Global.System.Windows.Forms.DataVisualization.Charting.Docking.Top
			legend3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			legend3.IsTextAutoFit = False
			legend3.Name = "Legend1"
			Me.Chart2.Legends.Add(legend3)
			Me.Chart2.Location = New Global.System.Drawing.Point(3, 3)
			Me.Chart2.Name = "Chart2"
			Me.Chart2.Palette = Global.System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
			series3.BackGradientStyle = Global.System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
			series3.BorderWidth = 2
			series3.ChartArea = "ChartArea1"
			series3.ChartType = Global.System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea
			series3.Color = Global.System.Drawing.Color.DarkMagenta
			series3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			series3.IsValueShownAsLabel = True
			series3.Legend = "Legend1"
			series3.Name = "No. Of GRN"
			Me.Chart2.Series.Add(series3)
			Me.Chart2.Size = New Global.System.Drawing.Size(384, 268)
			Me.Chart2.TabIndex = 92
			title3.BackColor = Global.System.Drawing.Color.FromArgb(22, 112, 170)
			title3.BackGradientStyle = Global.System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft
			title3.BackSecondaryColor = Global.System.Drawing.Color.FromArgb(0, 42, 103)
			title3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			title3.ForeColor = Global.System.Drawing.Color.White
			title3.Name = "Title1"
			title3.ShadowColor = Global.System.Drawing.Color.DimGray
			title3.ShadowOffset = 2
			title3.Text = "GRN Created In Month Of - "
			Me.Chart2.Titles.Add(title3)
			Me.Chart2.Visible = False
			Me.Panel1.AutoScroll = True
			Me.Panel1.Controls.Add(Me.ChartPOStatus)
			Me.Panel1.Controls.Add(Me.ChartPO)
			Me.Panel1.Location = New Global.System.Drawing.Point(7, 342)
			Me.Panel1.Name = "Panel1"
			Me.Panel1.Size = New Global.System.Drawing.Size(1069, 274)
			Me.Panel1.TabIndex = 6
			Me.Chart1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Chart1.BackColor = Global.System.Drawing.Color.WhiteSmoke
			Me.Chart1.BackGradientStyle = Global.System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
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
			Me.Chart1.ChartAreas.Add(chartArea4)
			legend4.Alignment = Global.System.Drawing.StringAlignment.Far
			legend4.BackColor = Global.System.Drawing.Color.Transparent
			legend4.Docking = Global.System.Windows.Forms.DataVisualization.Charting.Docking.Top
			legend4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			legend4.IsTextAutoFit = False
			legend4.Name = "Legend1"
			Me.Chart1.Legends.Add(legend4)
			Me.Chart1.Location = New Global.System.Drawing.Point(467, 47)
			Me.Chart1.Name = "Chart1"
			Me.Chart1.Palette = Global.System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
			series4.BackGradientStyle = Global.System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
			series4.BorderWidth = 2
			series4.ChartArea = "ChartArea1"
			series4.ChartType = Global.System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
			series4.Color = Global.System.Drawing.Color.DarkMagenta
			series4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			series4.IsValueShownAsLabel = True
			series4.Legend = "Legend1"
			series4.Name = "No. Of GRN"
			Me.Chart1.Series.Add(series4)
			Me.Chart1.Size = New Global.System.Drawing.Size(384, 268)
			Me.Chart1.TabIndex = 93
			title4.BackColor = Global.System.Drawing.Color.FromArgb(22, 112, 170)
			title4.BackGradientStyle = Global.System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft
			title4.BackSecondaryColor = Global.System.Drawing.Color.FromArgb(0, 42, 103)
			title4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			title4.ForeColor = Global.System.Drawing.Color.White
			title4.Name = "Title1"
			title4.ShadowColor = Global.System.Drawing.Color.DimGray
			title4.ShadowOffset = 2
			title4.Text = "GRN Created In Month Of - "
			Me.Chart1.Titles.Add(title4)
			Me.Chart1.Visible = False
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			MyBase.ClientSize = New Global.System.Drawing.Size(1088, 629)
			MyBase.Controls.Add(Me.Chart1)
			MyBase.Controls.Add(Me.Panel1)
			MyBase.Controls.Add(Me.TableLayoutPanel1)
			MyBase.Controls.Add(Me.btnGen)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.Name = "DashboardTest"
			Me.Text = "DashboardTest"
			Me.TableLayoutPanel1.ResumeLayout(False)
			CType(Me.ChartPO, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ChartPOStatus, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.Chart2, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel1.ResumeLayout(False)
			CType(Me.Chart1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x040005DE RID: 1502
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
