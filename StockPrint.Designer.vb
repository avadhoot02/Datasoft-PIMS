Namespace Datasoft_PIMS
	' Token: 0x02000028 RID: 40
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class StockPrint
		Inherits Global.WeifenLuo.WinFormsUI.Docking.DockContent

		' Token: 0x06000A80 RID: 2688 RVA: 0x00060754 File Offset: 0x0005E954
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

		' Token: 0x06000A81 RID: 2689 RVA: 0x000607A4 File Offset: 0x0005E9A4
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.GbBasic = New Global.System.Windows.Forms.GroupBox()
			Me.cmbDepartment = New Global.System.Windows.Forms.ComboBox()
			Me.lblDepartment = New Global.System.Windows.Forms.Label()
			Me.cmbItemGroup = New Global.System.Windows.Forms.ComboBox()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.dtpTo = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label16 = New Global.System.Windows.Forms.Label()
			Me.dtpFrom = New Global.System.Windows.Forms.DateTimePicker()
			Me.arrow_btnBasicExp_sml = New Global.System.Windows.Forms.Button()
			Me.grpListButton = New Global.System.Windows.Forms.GroupBox()
			Me.FlowLayoutPanel1 = New Global.System.Windows.Forms.FlowLayoutPanel()
			Me.btnSearch = New Global.System.Windows.Forms.Button()
			Me.btnClearList = New Global.System.Windows.Forms.Button()
			Me.lblRows = New Global.System.Windows.Forms.Label()
			Me.CrystalReportViewer1 = New Global.CrystalDecisions.Windows.Forms.CrystalReportViewer()
			Me.GbBasic.SuspendLayout()
			Me.grpListButton.SuspendLayout()
			Me.FlowLayoutPanel1.SuspendLayout()
			MyBase.SuspendLayout()
			Me.GbBasic.BackColor = Global.System.Drawing.Color.White
			Me.GbBasic.Controls.Add(Me.cmbDepartment)
			Me.GbBasic.Controls.Add(Me.lblDepartment)
			Me.GbBasic.Controls.Add(Me.cmbItemGroup)
			Me.GbBasic.Controls.Add(Me.Label9)
			Me.GbBasic.Controls.Add(Me.Label1)
			Me.GbBasic.Controls.Add(Me.dtpTo)
			Me.GbBasic.Controls.Add(Me.Label16)
			Me.GbBasic.Controls.Add(Me.dtpFrom)
			Me.GbBasic.Controls.Add(Me.arrow_btnBasicExp_sml)
			Me.GbBasic.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.GbBasic.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GbBasic.Location = New Global.System.Drawing.Point(0, 0)
			Me.GbBasic.Name = "GbBasic"
			Me.GbBasic.Size = New Global.System.Drawing.Size(933, 111)
			Me.GbBasic.TabIndex = 479
			Me.GbBasic.TabStop = False
			Me.GbBasic.Text = "     Basic Search "
			Me.cmbDepartment.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbDepartment.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbDepartment.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbDepartment.FormattingEnabled = True
			Me.cmbDepartment.Items.AddRange(New Object() { "", "Kgs.", "Ltrs.", "Nos." })
			Me.cmbDepartment.Location = New Global.System.Drawing.Point(117, 78)
			Me.cmbDepartment.Name = "cmbDepartment"
			Me.cmbDepartment.Size = New Global.System.Drawing.Size(440, 23)
			Me.cmbDepartment.TabIndex = 1058
			Me.lblDepartment.AutoSize = True
			Me.lblDepartment.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblDepartment.Location = New Global.System.Drawing.Point(28, 82)
			Me.lblDepartment.Name = "lblDepartment"
			Me.lblDepartment.Size = New Global.System.Drawing.Size(75, 15)
			Me.lblDepartment.TabIndex = 1059
			Me.lblDepartment.Text = "Department"
			Me.cmbItemGroup.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbItemGroup.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbItemGroup.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbItemGroup.FormattingEnabled = True
			Me.cmbItemGroup.Items.AddRange(New Object() { "", "Kgs.", "Ltrs.", "Nos." })
			Me.cmbItemGroup.Location = New Global.System.Drawing.Point(117, 51)
			Me.cmbItemGroup.Name = "cmbItemGroup"
			Me.cmbItemGroup.Size = New Global.System.Drawing.Size(440, 23)
			Me.cmbItemGroup.TabIndex = 1056
			Me.Label9.AutoSize = True
			Me.Label9.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label9.Location = New Global.System.Drawing.Point(28, 55)
			Me.Label9.Name = "Label9"
			Me.Label9.Size = New Global.System.Drawing.Size(73, 15)
			Me.Label9.TabIndex = 1057
			Me.Label9.Text = "Item Group"
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.Location = New Global.System.Drawing.Point(28, 28)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(67, 15)
			Me.Label1.TabIndex = 1055
			Me.Label1.Text = "Date From"
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.dtpTo.Checked = False
			Me.dtpTo.CustomFormat = "dd MMM yyyy"
			Me.dtpTo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpTo.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpTo.Location = New Global.System.Drawing.Point(385, 26)
			Me.dtpTo.Name = "dtpTo"
			Me.dtpTo.ShowCheckBox = True
			Me.dtpTo.Size = New Global.System.Drawing.Size(172, 21)
			Me.dtpTo.TabIndex = 1053
			Me.Label16.AutoSize = True
			Me.Label16.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label16.Location = New Global.System.Drawing.Point(307, 28)
			Me.Label16.Name = "Label16"
			Me.Label16.Size = New Global.System.Drawing.Size(52, 15)
			Me.Label16.TabIndex = 1054
			Me.Label16.Text = "Date To"
			Me.Label16.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.dtpFrom.Checked = False
			Me.dtpFrom.CustomFormat = "dd MMM yyyy"
			Me.dtpFrom.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpFrom.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpFrom.Location = New Global.System.Drawing.Point(117, 26)
			Me.dtpFrom.Name = "dtpFrom"
			Me.dtpFrom.ShowCheckBox = True
			Me.dtpFrom.Size = New Global.System.Drawing.Size(172, 21)
			Me.dtpFrom.TabIndex = 1052
			Me.arrow_btnBasicExp_sml.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.arrow_btnBasicExp_sml.FlatAppearance.BorderSize = 0
			Me.arrow_btnBasicExp_sml.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.arrow_btnBasicExp_sml.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.arrow_btnBasicExp_sml.Location = New Global.System.Drawing.Point(8, 0)
			Me.arrow_btnBasicExp_sml.Name = "arrow_btnBasicExp_sml"
			Me.arrow_btnBasicExp_sml.Size = New Global.System.Drawing.Size(20, 20)
			Me.arrow_btnBasicExp_sml.TabIndex = 4
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			Me.arrow_btnBasicExp_sml.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.arrow_btnBasicExp_sml.UseVisualStyleBackColor = True
			Me.grpListButton.Controls.Add(Me.FlowLayoutPanel1)
			Me.grpListButton.Controls.Add(Me.lblRows)
			Me.grpListButton.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.grpListButton.Location = New Global.System.Drawing.Point(0, 111)
			Me.grpListButton.Name = "grpListButton"
			Me.grpListButton.Size = New Global.System.Drawing.Size(933, 49)
			Me.grpListButton.TabIndex = 481
			Me.grpListButton.TabStop = False
			Me.FlowLayoutPanel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
			Me.FlowLayoutPanel1.Controls.Add(Me.btnSearch)
			Me.FlowLayoutPanel1.Controls.Add(Me.btnClearList)
			Me.FlowLayoutPanel1.Location = New Global.System.Drawing.Point(6, 11)
			Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
			Me.FlowLayoutPanel1.Size = New Global.System.Drawing.Size(720, 35)
			Me.FlowLayoutPanel1.TabIndex = 0
			Me.btnSearch.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnSearch.Location = New Global.System.Drawing.Point(0, 3)
			Me.btnSearch.Margin = New Global.System.Windows.Forms.Padding(0, 3, 2, 3)
			Me.btnSearch.Name = "btnSearch"
			Me.btnSearch.Size = New Global.System.Drawing.Size(106, 29)
			Me.btnSearch.TabIndex = 1
			Me.btnSearch.Text = "Search"
			Me.btnSearch.UseVisualStyleBackColor = True
			Me.btnClearList.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClearList.Location = New Global.System.Drawing.Point(108, 3)
			Me.btnClearList.Margin = New Global.System.Windows.Forms.Padding(0, 3, 2, 3)
			Me.btnClearList.Name = "btnClearList"
			Me.btnClearList.Size = New Global.System.Drawing.Size(106, 29)
			Me.btnClearList.TabIndex = 2
			Me.btnClearList.Text = "Clear"
			Me.btnClearList.UseVisualStyleBackColor = True
			Me.lblRows.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblRows.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRows.Location = New Global.System.Drawing.Point(817, 21)
			Me.lblRows.Name = "lblRows"
			Me.lblRows.Size = New Global.System.Drawing.Size(108, 15)
			Me.lblRows.TabIndex = 483
			Me.lblRows.Text = "0 - Rows"
			Me.lblRows.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.lblRows.Visible = False
			Me.CrystalReportViewer1.ActiveViewIndex = -1
			Me.CrystalReportViewer1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.CrystalReportViewer1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.CrystalReportViewer1.DisplayStatusBar = False
			Me.CrystalReportViewer1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.CrystalReportViewer1.Location = New Global.System.Drawing.Point(0, 160)
			Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
			Me.CrystalReportViewer1.ShowCloseButton = False
			Me.CrystalReportViewer1.ShowCopyButton = False
			Me.CrystalReportViewer1.ShowGotoPageButton = False
			Me.CrystalReportViewer1.ShowGroupTreeButton = False
			Me.CrystalReportViewer1.ShowLogo = False
			Me.CrystalReportViewer1.ShowParameterPanelButton = False
			Me.CrystalReportViewer1.ShowTextSearchButton = False
			Me.CrystalReportViewer1.Size = New Global.System.Drawing.Size(933, 359)
			Me.CrystalReportViewer1.TabIndex = 482
			Me.CrystalReportViewer1.ToolPanelView = Global.CrystalDecisions.Windows.Forms.ToolPanelViewType.None
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			MyBase.ClientSize = New Global.System.Drawing.Size(933, 519)
			MyBase.Controls.Add(Me.CrystalReportViewer1)
			MyBase.Controls.Add(Me.grpListButton)
			MyBase.Controls.Add(Me.GbBasic)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.Name = "StockPrint"
			Me.Text = "StockPrint"
			Me.GbBasic.ResumeLayout(False)
			Me.GbBasic.PerformLayout()
			Me.grpListButton.ResumeLayout(False)
			Me.FlowLayoutPanel1.ResumeLayout(False)
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000469 RID: 1129
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
