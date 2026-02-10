Namespace Datasoft_PIMS
	' Token: 0x02000012 RID: 18
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class ProductBOMList
		Inherits Global.WeifenLuo.WinFormsUI.Docking.DockContent

		' Token: 0x06000239 RID: 569 RVA: 0x000160A4 File Offset: 0x000142A4
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

		' Token: 0x0600023A RID: 570 RVA: 0x000160F4 File Offset: 0x000142F4
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.GbBasic = New Global.System.Windows.Forms.GroupBox()
			Me.txtBOMVersion = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.txtSCatalogNo = New Global.System.Windows.Forms.TextBox()
			Me.Label37 = New Global.System.Windows.Forms.Label()
			Me.txtSName = New Global.System.Windows.Forms.TextBox()
			Me.Label11 = New Global.System.Windows.Forms.Label()
			Me.txtSCode = New Global.System.Windows.Forms.TextBox()
			Me.Label14 = New Global.System.Windows.Forms.Label()
			Me.arrow_btnBasicExp_sml = New Global.System.Windows.Forms.Button()
			Me.GbAdvanced = New Global.System.Windows.Forms.GroupBox()
			Me.txtSCreated = New Global.System.Windows.Forms.TextBox()
			Me.lblSCreated = New Global.System.Windows.Forms.ComboBox()
			Me.dtpFrom = New Global.System.Windows.Forms.DateTimePicker()
			Me.dtpTo = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label16 = New Global.System.Windows.Forms.Label()
			Me.lblSDate = New Global.System.Windows.Forms.ComboBox()
			Me.arrow_btnAdvanceExp_sml = New Global.System.Windows.Forms.Button()
			Me.grpListButton = New Global.System.Windows.Forms.GroupBox()
			Me.FlowLayoutPanel1 = New Global.System.Windows.Forms.FlowLayoutPanel()
			Me.btnSearch = New Global.System.Windows.Forms.Button()
			Me.btnClearList = New Global.System.Windows.Forms.Button()
			Me.btnExport = New Global.System.Windows.Forms.Button()
			Me.lblRows = New Global.System.Windows.Forms.Label()
			Me.dgvList = New Global.System.Windows.Forms.DataGridView()
			Me.btnAdd = New Global.System.Windows.Forms.Button()
			Me.GbBasic.SuspendLayout()
			Me.GbAdvanced.SuspendLayout()
			Me.grpListButton.SuspendLayout()
			Me.FlowLayoutPanel1.SuspendLayout()
			CType(Me.dgvList, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.GbBasic.BackColor = Global.System.Drawing.Color.White
			Me.GbBasic.Controls.Add(Me.txtBOMVersion)
			Me.GbBasic.Controls.Add(Me.Label1)
			Me.GbBasic.Controls.Add(Me.txtSCatalogNo)
			Me.GbBasic.Controls.Add(Me.Label37)
			Me.GbBasic.Controls.Add(Me.txtSName)
			Me.GbBasic.Controls.Add(Me.Label11)
			Me.GbBasic.Controls.Add(Me.txtSCode)
			Me.GbBasic.Controls.Add(Me.Label14)
			Me.GbBasic.Controls.Add(Me.arrow_btnBasicExp_sml)
			Me.GbBasic.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.GbBasic.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GbBasic.Location = New Global.System.Drawing.Point(0, 0)
			Me.GbBasic.Name = "GbBasic"
			Me.GbBasic.Size = New Global.System.Drawing.Size(933, 115)
			Me.GbBasic.TabIndex = 477
			Me.GbBasic.TabStop = False
			Me.GbBasic.Text = "     Basic Search "
			Me.txtBOMVersion.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtBOMVersion.Location = New Global.System.Drawing.Point(151, 81)
			Me.txtBOMVersion.Name = "txtBOMVersion"
			Me.txtBOMVersion.Size = New Global.System.Drawing.Size(488, 21)
			Me.txtBOMVersion.TabIndex = 3
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.Location = New Global.System.Drawing.Point(16, 84)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(80, 15)
			Me.Label1.TabIndex = 751
			Me.Label1.Text = "BOM Version"
			Me.txtSCatalogNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtSCatalogNo.Location = New Global.System.Drawing.Point(441, 27)
			Me.txtSCatalogNo.Name = "txtSCatalogNo"
			Me.txtSCatalogNo.Size = New Global.System.Drawing.Size(198, 21)
			Me.txtSCatalogNo.TabIndex = 1
			Me.Label37.AutoSize = True
			Me.Label37.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label37.Location = New Global.System.Drawing.Point(363, 30)
			Me.Label37.Name = "Label37"
			Me.Label37.Size = New Global.System.Drawing.Size(74, 15)
			Me.Label37.TabIndex = 749
			Me.Label37.Text = "Catalog No."
			Me.txtSName.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtSName.Location = New Global.System.Drawing.Point(151, 54)
			Me.txtSName.Name = "txtSName"
			Me.txtSName.Size = New Global.System.Drawing.Size(488, 21)
			Me.txtSName.TabIndex = 2
			Me.Label11.AutoSize = True
			Me.Label11.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label11.Location = New Global.System.Drawing.Point(16, 57)
			Me.Label11.Name = "Label11"
			Me.Label11.Size = New Global.System.Drawing.Size(87, 15)
			Me.Label11.TabIndex = 745
			Me.Label11.Text = "Product Name"
			Me.txtSCode.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtSCode.Location = New Global.System.Drawing.Point(151, 27)
			Me.txtSCode.Name = "txtSCode"
			Me.txtSCode.Size = New Global.System.Drawing.Size(198, 21)
			Me.txtSCode.TabIndex = 0
			Me.Label14.AutoSize = True
			Me.Label14.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label14.Location = New Global.System.Drawing.Point(16, 30)
			Me.Label14.Name = "Label14"
			Me.Label14.Size = New Global.System.Drawing.Size(84, 15)
			Me.Label14.TabIndex = 744
			Me.Label14.Text = "Product Code"
			Me.arrow_btnBasicExp_sml.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.arrow_btnBasicExp_sml.FlatAppearance.BorderSize = 0
			Me.arrow_btnBasicExp_sml.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.arrow_btnBasicExp_sml.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.arrow_btnBasicExp_sml.Location = New Global.System.Drawing.Point(8, -1)
			Me.arrow_btnBasicExp_sml.Name = "arrow_btnBasicExp_sml"
			Me.arrow_btnBasicExp_sml.Size = New Global.System.Drawing.Size(20, 20)
			Me.arrow_btnBasicExp_sml.TabIndex = 4
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			Me.arrow_btnBasicExp_sml.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.arrow_btnBasicExp_sml.UseVisualStyleBackColor = True
			Me.GbAdvanced.Controls.Add(Me.txtSCreated)
			Me.GbAdvanced.Controls.Add(Me.lblSCreated)
			Me.GbAdvanced.Controls.Add(Me.dtpFrom)
			Me.GbAdvanced.Controls.Add(Me.dtpTo)
			Me.GbAdvanced.Controls.Add(Me.Label16)
			Me.GbAdvanced.Controls.Add(Me.lblSDate)
			Me.GbAdvanced.Controls.Add(Me.arrow_btnAdvanceExp_sml)
			Me.GbAdvanced.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.GbAdvanced.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GbAdvanced.Location = New Global.System.Drawing.Point(0, 115)
			Me.GbAdvanced.Name = "GbAdvanced"
			Me.GbAdvanced.Size = New Global.System.Drawing.Size(933, 84)
			Me.GbAdvanced.TabIndex = 478
			Me.GbAdvanced.TabStop = False
			Me.GbAdvanced.Text = "     Advanced Search "
			Me.txtSCreated.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtSCreated.Location = New Global.System.Drawing.Point(151, 55)
			Me.txtSCreated.Name = "txtSCreated"
			Me.txtSCreated.Size = New Global.System.Drawing.Size(488, 21)
			Me.txtSCreated.TabIndex = 2
			Me.lblSCreated.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.lblSCreated.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.lblSCreated.BackColor = Global.System.Drawing.Color.White
			Me.lblSCreated.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.lblSCreated.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.lblSCreated.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblSCreated.FormattingEnabled = True
			Me.lblSCreated.Items.AddRange(New Object() { "Created By", "Last Modified By" })
			Me.lblSCreated.Location = New Global.System.Drawing.Point(15, 54)
			Me.lblSCreated.Name = "lblSCreated"
			Me.lblSCreated.Size = New Global.System.Drawing.Size(130, 23)
			Me.lblSCreated.TabIndex = 481
			Me.dtpFrom.CustomFormat = "dd MMM yyyy  00:00"
			Me.dtpFrom.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpFrom.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpFrom.Location = New Global.System.Drawing.Point(151, 29)
			Me.dtpFrom.Name = "dtpFrom"
			Me.dtpFrom.ShowCheckBox = True
			Me.dtpFrom.Size = New Global.System.Drawing.Size(198, 21)
			Me.dtpFrom.TabIndex = 0
			Me.dtpTo.CustomFormat = "dd MMM yyyy  23:59"
			Me.dtpTo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpTo.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpTo.Location = New Global.System.Drawing.Point(441, 29)
			Me.dtpTo.Name = "dtpTo"
			Me.dtpTo.ShowCheckBox = True
			Me.dtpTo.Size = New Global.System.Drawing.Size(198, 21)
			Me.dtpTo.TabIndex = 1
			Me.Label16.AutoSize = True
			Me.Label16.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label16.Location = New Global.System.Drawing.Point(363, 31)
			Me.Label16.Name = "Label16"
			Me.Label16.Size = New Global.System.Drawing.Size(21, 15)
			Me.Label16.TabIndex = 477
			Me.Label16.Text = "To"
			Me.Label16.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.lblSDate.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.lblSDate.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.lblSDate.BackColor = Global.System.Drawing.Color.White
			Me.lblSDate.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.lblSDate.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.lblSDate.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblSDate.FormattingEnabled = True
			Me.lblSDate.Items.AddRange(New Object() { "Creation", "Last Modification", "Effective Date", "Expiry Date" })
			Me.lblSDate.Location = New Global.System.Drawing.Point(15, 28)
			Me.lblSDate.Name = "lblSDate"
			Me.lblSDate.Size = New Global.System.Drawing.Size(130, 23)
			Me.lblSDate.TabIndex = 475
			Me.arrow_btnAdvanceExp_sml.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.arrow_btnAdvanceExp_sml.FlatAppearance.BorderSize = 0
			Me.arrow_btnAdvanceExp_sml.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.arrow_btnAdvanceExp_sml.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.arrow_btnAdvanceExp_sml.ForeColor = Global.System.Drawing.Color.White
			Me.arrow_btnAdvanceExp_sml.Location = New Global.System.Drawing.Point(8, -1)
			Me.arrow_btnAdvanceExp_sml.Name = "arrow_btnAdvanceExp_sml"
			Me.arrow_btnAdvanceExp_sml.Size = New Global.System.Drawing.Size(20, 20)
			Me.arrow_btnAdvanceExp_sml.TabIndex = 4
			Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
			Me.arrow_btnAdvanceExp_sml.UseVisualStyleBackColor = True
			Me.grpListButton.Controls.Add(Me.FlowLayoutPanel1)
			Me.grpListButton.Controls.Add(Me.lblRows)
			Me.grpListButton.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.grpListButton.Location = New Global.System.Drawing.Point(0, 199)
			Me.grpListButton.Name = "grpListButton"
			Me.grpListButton.Size = New Global.System.Drawing.Size(933, 49)
			Me.grpListButton.TabIndex = 481
			Me.grpListButton.TabStop = False
			Me.FlowLayoutPanel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
			Me.FlowLayoutPanel1.Controls.Add(Me.btnAdd)
			Me.FlowLayoutPanel1.Controls.Add(Me.btnSearch)
			Me.FlowLayoutPanel1.Controls.Add(Me.btnClearList)
			Me.FlowLayoutPanel1.Controls.Add(Me.btnExport)
			Me.FlowLayoutPanel1.Location = New Global.System.Drawing.Point(6, 11)
			Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
			Me.FlowLayoutPanel1.Size = New Global.System.Drawing.Size(720, 35)
			Me.FlowLayoutPanel1.TabIndex = 0
			Me.btnSearch.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnSearch.Location = New Global.System.Drawing.Point(108, 3)
			Me.btnSearch.Margin = New Global.System.Windows.Forms.Padding(0, 3, 2, 3)
			Me.btnSearch.Name = "btnSearch"
			Me.btnSearch.Size = New Global.System.Drawing.Size(106, 29)
			Me.btnSearch.TabIndex = 1
			Me.btnSearch.Text = "Search"
			Me.btnSearch.UseVisualStyleBackColor = True
			Me.btnClearList.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClearList.Location = New Global.System.Drawing.Point(216, 3)
			Me.btnClearList.Margin = New Global.System.Windows.Forms.Padding(0, 3, 2, 3)
			Me.btnClearList.Name = "btnClearList"
			Me.btnClearList.Size = New Global.System.Drawing.Size(106, 29)
			Me.btnClearList.TabIndex = 2
			Me.btnClearList.Text = "Clear"
			Me.btnClearList.UseVisualStyleBackColor = True
			Me.btnExport.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnExport.Location = New Global.System.Drawing.Point(324, 3)
			Me.btnExport.Margin = New Global.System.Windows.Forms.Padding(0, 3, 2, 3)
			Me.btnExport.Name = "btnExport"
			Me.btnExport.Size = New Global.System.Drawing.Size(116, 29)
			Me.btnExport.TabIndex = 3
			Me.btnExport.Text = "Export XL"
			Me.btnExport.UseVisualStyleBackColor = True
			Me.lblRows.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblRows.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRows.Location = New Global.System.Drawing.Point(817, 21)
			Me.lblRows.Name = "lblRows"
			Me.lblRows.Size = New Global.System.Drawing.Size(108, 15)
			Me.lblRows.TabIndex = 483
			Me.lblRows.Text = "0 - Rows"
			Me.lblRows.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.dgvList.AllowUserToAddRows = False
			Me.dgvList.AllowUserToDeleteRows = False
			Me.dgvList.BackgroundColor = Global.System.Drawing.Color.WhiteSmoke
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.AliceBlue
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.dgvList.ColumnHeadersHeight = 45
			Me.dgvList.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.dgvList.Location = New Global.System.Drawing.Point(0, 248)
			Me.dgvList.Name = "dgvList"
			Me.dgvList.[ReadOnly] = True
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.Color.AliceBlue
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.Color.PowderBlue
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2
			Me.dgvList.RowHeadersWidth = 25
			dataGridViewCellStyle3.SelectionBackColor = Global.System.Drawing.Color.PowderBlue
			dataGridViewCellStyle3.SelectionForeColor = Global.System.Drawing.Color.Black
			Me.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle3
			Me.dgvList.RowTemplate.DefaultCellStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dgvList.Size = New Global.System.Drawing.Size(933, 271)
			Me.dgvList.TabIndex = 485
			Me.btnAdd.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnAdd.Location = New Global.System.Drawing.Point(0, 3)
			Me.btnAdd.Margin = New Global.System.Windows.Forms.Padding(0, 3, 2, 3)
			Me.btnAdd.Name = "btnAdd"
			Me.btnAdd.Size = New Global.System.Drawing.Size(106, 29)
			Me.btnAdd.TabIndex = 0
			Me.btnAdd.Text = "Add Version"
			Me.btnAdd.UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			MyBase.ClientSize = New Global.System.Drawing.Size(933, 519)
			MyBase.Controls.Add(Me.dgvList)
			MyBase.Controls.Add(Me.grpListButton)
			MyBase.Controls.Add(Me.GbAdvanced)
			MyBase.Controls.Add(Me.GbBasic)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.Name = "ProductBOMList"
			Me.Text = "ProductBOMList"
			Me.GbBasic.ResumeLayout(False)
			Me.GbBasic.PerformLayout()
			Me.GbAdvanced.ResumeLayout(False)
			Me.GbAdvanced.PerformLayout()
			Me.grpListButton.ResumeLayout(False)
			Me.FlowLayoutPanel1.ResumeLayout(False)
			CType(Me.dgvList, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x040000D0 RID: 208
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
