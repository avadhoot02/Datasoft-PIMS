Namespace Datasoft_PIMS
	' Token: 0x0200001D RID: 29
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class LocationMap
		Inherits Global.WeifenLuo.WinFormsUI.Docking.DockContent

		' Token: 0x06000495 RID: 1173 RVA: 0x0002A8C4 File Offset: 0x00028AC4
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

		' Token: 0x06000496 RID: 1174 RVA: 0x0002A914 File Offset: 0x00028B14
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle4 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle5 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle6 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle7 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.theme_tc = New Global.System.Windows.Forms.TabControl()
			Me.tpDetails = New Global.System.Windows.Forms.TabPage()
			Me.lblRowsG = New Global.System.Windows.Forms.Label()
			Me.sml_btnGen = New Global.System.Windows.Forms.Button()
			Me.btnPrintGen = New Global.System.Windows.Forms.Button()
			Me.btnSave = New Global.System.Windows.Forms.Button()
			Me.btnClear = New Global.System.Windows.Forms.Button()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.dgvGen = New Global.System.Windows.Forms.DataGridView()
			Me.LocSrNo = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.LocCode = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.LocName = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.LocDesc = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.CreatedBy = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.txtNo = New Global.System.Windows.Forms.TextBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.tab_lblDetails = New Global.System.Windows.Forms.Label()
			Me.tpList = New Global.System.Windows.Forms.TabPage()
			Me.chkSelect = New Global.System.Windows.Forms.CheckBox()
			Me.grpListButton = New Global.System.Windows.Forms.GroupBox()
			Me.FlowLayoutPanel1 = New Global.System.Windows.Forms.FlowLayoutPanel()
			Me.btnSearch = New Global.System.Windows.Forms.Button()
			Me.btnClearList = New Global.System.Windows.Forms.Button()
			Me.btnExport = New Global.System.Windows.Forms.Button()
			Me.btnPrint = New Global.System.Windows.Forms.Button()
			Me.lblRows = New Global.System.Windows.Forms.Label()
			Me.GbBasic = New Global.System.Windows.Forms.GroupBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.txtSName = New Global.System.Windows.Forms.TextBox()
			Me.txtSCode = New Global.System.Windows.Forms.TextBox()
			Me.tab_lblList = New Global.System.Windows.Forms.Label()
			Me.ModifiedBy = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ModificationDt = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.sCreatedBy = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.CreationDt = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Desc = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.LocationName = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.LocationCode = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.LocationID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.chk = New Global.System.Windows.Forms.DataGridViewCheckBoxColumn()
			Me.dgvList = New Global.System.Windows.Forms.DataGridView()
			Me.theme_tc.SuspendLayout()
			Me.tpDetails.SuspendLayout()
			Me.Panel1.SuspendLayout()
			CType(Me.dgvGen, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tpList.SuspendLayout()
			Me.grpListButton.SuspendLayout()
			Me.FlowLayoutPanel1.SuspendLayout()
			Me.GbBasic.SuspendLayout()
			CType(Me.dgvList, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.theme_tc.Controls.Add(Me.tpDetails)
			Me.theme_tc.Controls.Add(Me.tpList)
			Me.theme_tc.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.theme_tc.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.theme_tc.ItemSize = New Global.System.Drawing.Size(415, 21)
			Me.theme_tc.Location = New Global.System.Drawing.Point(0, 0)
			Me.theme_tc.Name = "theme_tc"
			Me.theme_tc.SelectedIndex = 0
			Me.theme_tc.Size = New Global.System.Drawing.Size(933, 519)
			Me.theme_tc.SizeMode = Global.System.Windows.Forms.TabSizeMode.Fixed
			Me.theme_tc.TabIndex = 7
			Me.theme_tc.TabStop = False
			Me.tpDetails.BackColor = Global.System.Drawing.Color.White
			Me.tpDetails.Controls.Add(Me.lblRowsG)
			Me.tpDetails.Controls.Add(Me.sml_btnGen)
			Me.tpDetails.Controls.Add(Me.btnPrintGen)
			Me.tpDetails.Controls.Add(Me.btnSave)
			Me.tpDetails.Controls.Add(Me.btnClear)
			Me.tpDetails.Controls.Add(Me.btnClose)
			Me.tpDetails.Controls.Add(Me.Panel1)
			Me.tpDetails.Controls.Add(Me.txtNo)
			Me.tpDetails.Controls.Add(Me.Label2)
			Me.tpDetails.Controls.Add(Me.tab_lblDetails)
			Me.tpDetails.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.tpDetails.Location = New Global.System.Drawing.Point(4, 25)
			Me.tpDetails.Name = "tpDetails"
			Me.tpDetails.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tpDetails.Size = New Global.System.Drawing.Size(925, 490)
			Me.tpDetails.TabIndex = 0
			Me.tpDetails.Text = "                           Generate                           "
			Me.tpDetails.UseVisualStyleBackColor = True
			Me.lblRowsG.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblRowsG.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRowsG.Location = New Global.System.Drawing.Point(809, 19)
			Me.lblRowsG.Name = "lblRowsG"
			Me.lblRowsG.Size = New Global.System.Drawing.Size(108, 15)
			Me.lblRowsG.TabIndex = 484
			Me.lblRowsG.Text = "0 - Rows"
			Me.lblRowsG.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.sml_btnGen.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.sml_btnGen.Location = New Global.System.Drawing.Point(602, 14)
			Me.sml_btnGen.Name = "sml_btnGen"
			Me.sml_btnGen.Size = New Global.System.Drawing.Size(84, 25)
			Me.sml_btnGen.TabIndex = 112
			Me.sml_btnGen.Text = "Generate"
			Me.sml_btnGen.UseVisualStyleBackColor = True
			Me.btnPrintGen.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnPrintGen.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnPrintGen.Location = New Global.System.Drawing.Point(464, 454)
			Me.btnPrintGen.Name = "btnPrintGen"
			Me.btnPrintGen.Size = New Global.System.Drawing.Size(94, 30)
			Me.btnPrintGen.TabIndex = 111
			Me.btnPrintGen.Text = "&Print"
			Me.btnPrintGen.UseVisualStyleBackColor = True
			Me.btnSave.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnSave.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnSave.Location = New Global.System.Drawing.Point(270, 454)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New Global.System.Drawing.Size(94, 30)
			Me.btnSave.TabIndex = 108
			Me.btnSave.Text = "&Save"
			Me.btnSave.UseVisualStyleBackColor = True
			Me.btnClear.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnClear.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClear.Location = New Global.System.Drawing.Point(367, 454)
			Me.btnClear.Name = "btnClear"
			Me.btnClear.Size = New Global.System.Drawing.Size(94, 30)
			Me.btnClear.TabIndex = 109
			Me.btnClear.Text = "&Clear"
			Me.btnClear.UseVisualStyleBackColor = True
			Me.btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnClose.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClose.Location = New Global.System.Drawing.Point(561, 454)
			Me.btnClose.Name = "btnClose"
			Me.btnClose.Size = New Global.System.Drawing.Size(94, 30)
			Me.btnClose.TabIndex = 110
			Me.btnClose.Text = "C&lose"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Panel1.Controls.Add(Me.dgvGen)
			Me.Panel1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Panel1.Location = New Global.System.Drawing.Point(7, 48)
			Me.Panel1.Name = "Panel1"
			Me.Panel1.Size = New Global.System.Drawing.Size(912, 401)
			Me.Panel1.TabIndex = 107
			Me.dgvGen.AllowUserToAddRows = False
			Me.dgvGen.AllowUserToDeleteRows = False
			Me.dgvGen.BackgroundColor = Global.System.Drawing.Color.WhiteSmoke
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.AliceBlue
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvGen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.dgvGen.ColumnHeadersHeight = 25
			Me.dgvGen.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.dgvGen.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.LocSrNo, Me.LocCode, Me.LocName, Me.LocDesc, Me.CreatedBy })
			Me.dgvGen.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.dgvGen.Location = New Global.System.Drawing.Point(0, 0)
			Me.dgvGen.MultiSelect = False
			Me.dgvGen.Name = "dgvGen"
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.Color.AliceBlue
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.Color.PowderBlue
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvGen.RowHeadersDefaultCellStyle = dataGridViewCellStyle2
			Me.dgvGen.RowHeadersWidth = 25
			dataGridViewCellStyle3.SelectionBackColor = Global.System.Drawing.Color.PowderBlue
			dataGridViewCellStyle3.SelectionForeColor = Global.System.Drawing.Color.Black
			Me.dgvGen.RowsDefaultCellStyle = dataGridViewCellStyle3
			Me.dgvGen.RowTemplate.DefaultCellStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dgvGen.Size = New Global.System.Drawing.Size(912, 401)
			Me.dgvGen.TabIndex = 492
			Me.LocSrNo.DataPropertyName = "LocSrNo"
			Me.LocSrNo.HeaderText = "LocSrNo"
			Me.LocSrNo.Name = "LocSrNo"
			Me.LocSrNo.Visible = False
			Me.LocCode.DataPropertyName = "LocCode"
			Me.LocCode.HeaderText = "Store Location Code"
			Me.LocCode.Name = "LocCode"
			Me.LocCode.[ReadOnly] = True
			Me.LocCode.Resizable = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.LocCode.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
			Me.LocCode.Width = 250
			Me.LocName.DataPropertyName = "LocName"
			Me.LocName.HeaderText = "Store Location Name"
			Me.LocName.Name = "LocName"
			Me.LocName.Resizable = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.LocName.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
			Me.LocName.Width = 300
			Me.LocDesc.DataPropertyName = "LocDesc"
			Me.LocDesc.HeaderText = "Description"
			Me.LocDesc.Name = "LocDesc"
			Me.LocDesc.Resizable = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.LocDesc.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
			Me.LocDesc.Width = 300
			Me.CreatedBy.DataPropertyName = "CreatedBy"
			Me.CreatedBy.HeaderText = "CreatedBy"
			Me.CreatedBy.Name = "CreatedBy"
			Me.CreatedBy.Visible = False
			Me.txtNo.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Upper
			Me.txtNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtNo.Location = New Global.System.Drawing.Point(112, 16)
			Me.txtNo.MaxLength = 3
			Me.txtNo.Name = "txtNo"
			Me.txtNo.Size = New Global.System.Drawing.Size(486, 21)
			Me.txtNo.TabIndex = 105
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.Location = New Global.System.Drawing.Point(12, 19)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(94, 15)
			Me.Label2.TabIndex = 106
			Me.Label2.Text = "No. Of Location"
			Me.tab_lblDetails.BackColor = Global.System.Drawing.Color.Black
			Me.tab_lblDetails.ForeColor = Global.System.Drawing.Color.PaleGreen
			Me.tab_lblDetails.Location = New Global.System.Drawing.Point(0, 0)
			Me.tab_lblDetails.Name = "tab_lblDetails"
			Me.tab_lblDetails.Size = New Global.System.Drawing.Size(852, 3)
			Me.tab_lblDetails.TabIndex = 32
			Me.tpList.BackColor = Global.System.Drawing.Color.White
			Me.tpList.Controls.Add(Me.dgvList)
			Me.tpList.Controls.Add(Me.chkSelect)
			Me.tpList.Controls.Add(Me.grpListButton)
			Me.tpList.Controls.Add(Me.GbBasic)
			Me.tpList.Controls.Add(Me.tab_lblList)
			Me.tpList.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.tpList.Location = New Global.System.Drawing.Point(4, 25)
			Me.tpList.Name = "tpList"
			Me.tpList.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tpList.Size = New Global.System.Drawing.Size(925, 490)
			Me.tpList.TabIndex = 1
			Me.tpList.Text = "                             Reprint                              "
			Me.tpList.UseVisualStyleBackColor = True
			Me.chkSelect.AutoSize = True
			Me.chkSelect.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.chkSelect.Location = New Global.System.Drawing.Point(3, 134)
			Me.chkSelect.Name = "chkSelect"
			Me.chkSelect.Padding = New Global.System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.chkSelect.Size = New Global.System.Drawing.Size(919, 19)
			Me.chkSelect.TabIndex = 490
			Me.chkSelect.Text = "Select All"
			Me.chkSelect.UseVisualStyleBackColor = True
			Me.grpListButton.Controls.Add(Me.FlowLayoutPanel1)
			Me.grpListButton.Controls.Add(Me.lblRows)
			Me.grpListButton.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.grpListButton.Location = New Global.System.Drawing.Point(3, 85)
			Me.grpListButton.Name = "grpListButton"
			Me.grpListButton.Size = New Global.System.Drawing.Size(919, 49)
			Me.grpListButton.TabIndex = 489
			Me.grpListButton.TabStop = False
			Me.FlowLayoutPanel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
			Me.FlowLayoutPanel1.Controls.Add(Me.btnSearch)
			Me.FlowLayoutPanel1.Controls.Add(Me.btnClearList)
			Me.FlowLayoutPanel1.Controls.Add(Me.btnExport)
			Me.FlowLayoutPanel1.Controls.Add(Me.btnPrint)
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
			Me.btnExport.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnExport.Location = New Global.System.Drawing.Point(216, 3)
			Me.btnExport.Margin = New Global.System.Windows.Forms.Padding(0, 3, 2, 3)
			Me.btnExport.Name = "btnExport"
			Me.btnExport.Size = New Global.System.Drawing.Size(116, 29)
			Me.btnExport.TabIndex = 3
			Me.btnExport.Text = "Export XL"
			Me.btnExport.UseVisualStyleBackColor = True
			Me.btnPrint.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnPrint.Location = New Global.System.Drawing.Point(334, 3)
			Me.btnPrint.Margin = New Global.System.Windows.Forms.Padding(0, 3, 2, 3)
			Me.btnPrint.Name = "btnPrint"
			Me.btnPrint.Size = New Global.System.Drawing.Size(116, 29)
			Me.btnPrint.TabIndex = 4
			Me.btnPrint.Text = "Print"
			Me.btnPrint.UseVisualStyleBackColor = True
			Me.lblRows.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblRows.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRows.Location = New Global.System.Drawing.Point(803, 21)
			Me.lblRows.Name = "lblRows"
			Me.lblRows.Size = New Global.System.Drawing.Size(108, 15)
			Me.lblRows.TabIndex = 483
			Me.lblRows.Text = "0 - Rows"
			Me.lblRows.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.GbBasic.BackColor = Global.System.Drawing.Color.White
			Me.GbBasic.Controls.Add(Me.Label3)
			Me.GbBasic.Controls.Add(Me.Label5)
			Me.GbBasic.Controls.Add(Me.txtSName)
			Me.GbBasic.Controls.Add(Me.txtSCode)
			Me.GbBasic.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.GbBasic.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GbBasic.Location = New Global.System.Drawing.Point(3, 3)
			Me.GbBasic.Name = "GbBasic"
			Me.GbBasic.Size = New Global.System.Drawing.Size(919, 82)
			Me.GbBasic.TabIndex = 487
			Me.GbBasic.TabStop = False
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.Location = New Global.System.Drawing.Point(16, 50)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(126, 15)
			Me.Label3.TabIndex = 103
			Me.Label3.Text = "Store Location Name"
			Me.Label5.AutoSize = True
			Me.Label5.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label5.Location = New Global.System.Drawing.Point(16, 23)
			Me.Label5.Name = "Label5"
			Me.Label5.Size = New Global.System.Drawing.Size(123, 15)
			Me.Label5.TabIndex = 102
			Me.Label5.Text = "Store Location Code"
			Me.txtSName.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtSName.Location = New Global.System.Drawing.Point(151, 47)
			Me.txtSName.Name = "txtSName"
			Me.txtSName.Size = New Global.System.Drawing.Size(479, 21)
			Me.txtSName.TabIndex = 46
			Me.txtSCode.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtSCode.Location = New Global.System.Drawing.Point(151, 20)
			Me.txtSCode.Name = "txtSCode"
			Me.txtSCode.Size = New Global.System.Drawing.Size(479, 21)
			Me.txtSCode.TabIndex = 42
			Me.tab_lblList.BackColor = Global.System.Drawing.Color.Black
			Me.tab_lblList.ForeColor = Global.System.Drawing.Color.PaleGreen
			Me.tab_lblList.Location = New Global.System.Drawing.Point(0, 0)
			Me.tab_lblList.Name = "tab_lblList"
			Me.tab_lblList.Size = New Global.System.Drawing.Size(853, 3)
			Me.tab_lblList.TabIndex = 7
			Me.ModifiedBy.DataPropertyName = "ModifiedBy"
			Me.ModifiedBy.HeaderText = "Modfied By"
			Me.ModifiedBy.Name = "ModifiedBy"
			Me.ModifiedBy.Width = 140
			Me.ModificationDt.DataPropertyName = "ModificationDt"
			Me.ModificationDt.HeaderText = "Modification Date"
			Me.ModificationDt.Name = "ModificationDt"
			Me.ModificationDt.Width = 170
			Me.sCreatedBy.DataPropertyName = "CreatedBy"
			Me.sCreatedBy.HeaderText = "Created By"
			Me.sCreatedBy.Name = "sCreatedBy"
			Me.sCreatedBy.[ReadOnly] = True
			Me.sCreatedBy.Width = 140
			Me.CreationDt.DataPropertyName = "CreationDt"
			dataGridViewCellStyle4.Format = "dd-MMM-yy hh:mm:ss tt"
			Me.CreationDt.DefaultCellStyle = dataGridViewCellStyle4
			Me.CreationDt.HeaderText = "Creation Date"
			Me.CreationDt.Name = "CreationDt"
			Me.CreationDt.[ReadOnly] = True
			Me.CreationDt.Width = 170
			Me.Desc.DataPropertyName = "Description"
			Me.Desc.HeaderText = "Description"
			Me.Desc.Name = "Desc"
			Me.Desc.[ReadOnly] = True
			Me.Desc.Resizable = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.Desc.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
			Me.Desc.Width = 300
			Me.LocationName.DataPropertyName = "LocationName"
			Me.LocationName.HeaderText = "Store Location Name"
			Me.LocationName.Name = "LocationName"
			Me.LocationName.[ReadOnly] = True
			Me.LocationName.Resizable = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.LocationName.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
			Me.LocationName.Width = 300
			Me.LocationCode.DataPropertyName = "LocationCode"
			Me.LocationCode.HeaderText = "Store Location Code"
			Me.LocationCode.Name = "LocationCode"
			Me.LocationCode.[ReadOnly] = True
			Me.LocationCode.Resizable = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.LocationCode.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
			Me.LocationCode.Width = 150
			Me.LocationID.DataPropertyName = "ID"
			Me.LocationID.HeaderText = "LocationID"
			Me.LocationID.Name = "LocationID"
			Me.LocationID.Visible = False
			Me.chk.DataPropertyName = "chk"
			Me.chk.FalseValue = "0"
			Me.chk.HeaderText = ""
			Me.chk.Name = "chk"
			Me.chk.TrueValue = "1"
			Me.chk.Width = 30
			Me.dgvList.AllowUserToAddRows = False
			Me.dgvList.AllowUserToDeleteRows = False
			Me.dgvList.BackgroundColor = Global.System.Drawing.Color.WhiteSmoke
			dataGridViewCellStyle5.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle5.BackColor = Global.System.Drawing.Color.AliceBlue
			dataGridViewCellStyle5.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle5.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle5.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle5.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle5.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5
			Me.dgvList.ColumnHeadersHeight = 25
			Me.dgvList.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.chk, Me.LocationID, Me.LocationCode, Me.LocationName, Me.Desc, Me.CreationDt, Me.sCreatedBy, Me.ModificationDt, Me.ModifiedBy })
			Me.dgvList.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.dgvList.Location = New Global.System.Drawing.Point(3, 153)
			Me.dgvList.Name = "dgvList"
			dataGridViewCellStyle6.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle6.BackColor = Global.System.Drawing.Color.AliceBlue
			dataGridViewCellStyle6.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle6.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle6.SelectionBackColor = Global.System.Drawing.Color.PowderBlue
			dataGridViewCellStyle6.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle6.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6
			Me.dgvList.RowHeadersVisible = False
			Me.dgvList.RowHeadersWidth = 25
			dataGridViewCellStyle7.SelectionBackColor = Global.System.Drawing.Color.PowderBlue
			dataGridViewCellStyle7.SelectionForeColor = Global.System.Drawing.Color.Black
			Me.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle7
			Me.dgvList.RowTemplate.DefaultCellStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dgvList.Size = New Global.System.Drawing.Size(919, 334)
			Me.dgvList.TabIndex = 491
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			MyBase.ClientSize = New Global.System.Drawing.Size(933, 519)
			MyBase.Controls.Add(Me.theme_tc)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.Name = "LocationMap"
			Me.Text = "Store Location"
			Me.theme_tc.ResumeLayout(False)
			Me.tpDetails.ResumeLayout(False)
			Me.tpDetails.PerformLayout()
			Me.Panel1.ResumeLayout(False)
			CType(Me.dgvGen, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.tpList.ResumeLayout(False)
			Me.tpList.PerformLayout()
			Me.grpListButton.ResumeLayout(False)
			Me.FlowLayoutPanel1.ResumeLayout(False)
			Me.GbBasic.ResumeLayout(False)
			Me.GbBasic.PerformLayout()
			CType(Me.dgvList, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x040001E0 RID: 480
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
