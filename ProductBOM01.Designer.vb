Namespace Datasoft_PIMS
	' Token: 0x02000011 RID: 17
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class ProductBOM01
		Inherits Global.WeifenLuo.WinFormsUI.Docking.DockContent

		' Token: 0x06000136 RID: 310 RVA: 0x0000CA74 File Offset: 0x0000AC74
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

		' Token: 0x06000137 RID: 311 RVA: 0x0000CAC4 File Offset: 0x0000ACC4
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle4 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle5 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle6 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.theme_tc = New Global.System.Windows.Forms.TabControl()
			Me.tpDetails = New Global.System.Windows.Forms.TabPage()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.theme_tcMaterial = New Global.System.Windows.Forms.TabControl()
			Me.tpItems = New Global.System.Windows.Forms.TabPage()
			Me.Panel2 = New Global.System.Windows.Forms.Panel()
			Me.dgvBOM = New Global.System.Windows.Forms.DataGridView()
			Me.ProductBOMID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.VersionID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.MaterialID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.IssueOrder = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.MaterialType = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.MaterialCode = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.MaterialName = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.PrimaryUOM = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Qty = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.btnDelete_BOM = New Global.System.Windows.Forms.DataGridViewImageColumn()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.cmbMaterialType = New Global.System.Windows.Forms.ComboBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.txtQty = New Global.System.Windows.Forms.TextBox()
			Me.cmbMaterial = New Global.System.Windows.Forms.ComboBox()
			Me.Label40 = New Global.System.Windows.Forms.Label()
			Me.llbAddItem = New Global.System.Windows.Forms.LinkLabel()
			Me.tab_lbl1 = New Global.System.Windows.Forms.Label()
			Me.tpRemarks = New Global.System.Windows.Forms.TabPage()
			Me.tab_lbl2 = New Global.System.Windows.Forms.Label()
			Me.lblRemarksApproval1 = New Global.System.Windows.Forms.Label()
			Me.lblRemarks1 = New Global.System.Windows.Forms.Label()
			Me.Panel4 = New Global.System.Windows.Forms.Panel()
			Me.txtRemarksApproval = New Global.System.Windows.Forms.TextBox()
			Me.txtRemarks = New Global.System.Windows.Forms.TextBox()
			Me.lblRemarks = New Global.System.Windows.Forms.Label()
			Me.lblRemarksApproval = New Global.System.Windows.Forms.Label()
			Me.flpButton = New Global.System.Windows.Forms.FlowLayoutPanel()
			Me.btnAdd = New Global.System.Windows.Forms.Button()
			Me.btnApprove = New Global.System.Windows.Forms.Button()
			Me.btnOnHold = New Global.System.Windows.Forms.Button()
			Me.btnReject = New Global.System.Windows.Forms.Button()
			Me.btnEdit = New Global.System.Windows.Forms.Button()
			Me.btnSave = New Global.System.Windows.Forms.Button()
			Me.btnClear = New Global.System.Windows.Forms.Button()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.grpProduct = New Global.System.Windows.Forms.GroupBox()
			Me.Label20 = New Global.System.Windows.Forms.Label()
			Me.skip_lblStatus = New Global.System.Windows.Forms.Label()
			Me.Label12 = New Global.System.Windows.Forms.Label()
			Me.Label15 = New Global.System.Windows.Forms.Label()
			Me.txtBatchQty = New Global.System.Windows.Forms.TextBox()
			Me.lblVersion = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.Label19 = New Global.System.Windows.Forms.Label()
			Me.txtProductName = New Global.System.Windows.Forms.TextBox()
			Me.cmbType = New Global.System.Windows.Forms.ComboBox()
			Me.Label18 = New Global.System.Windows.Forms.Label()
			Me.cmbProduct = New Global.System.Windows.Forms.ComboBox()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.dtpExpiryDt = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.dtpEffectiveDt = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Lable5 = New Global.System.Windows.Forms.Label()
			Me.txtBOMVersion = New Global.System.Windows.Forms.TextBox()
			Me.chkIsActive = New Global.System.Windows.Forms.CheckBox()
			Me.skip_Label12 = New Global.System.Windows.Forms.Label()
			Me.txtID = New Global.System.Windows.Forms.TextBox()
			Me.tab_lblDetails = New Global.System.Windows.Forms.Label()
			Me.tpList = New Global.System.Windows.Forms.TabPage()
			Me.dgvList = New Global.System.Windows.Forms.DataGridView()
			Me.grpListButton = New Global.System.Windows.Forms.GroupBox()
			Me.FlowLayoutPanel1 = New Global.System.Windows.Forms.FlowLayoutPanel()
			Me.btnSearch = New Global.System.Windows.Forms.Button()
			Me.btnClearList = New Global.System.Windows.Forms.Button()
			Me.btnExport = New Global.System.Windows.Forms.Button()
			Me.lblRows = New Global.System.Windows.Forms.Label()
			Me.GbAdvanced = New Global.System.Windows.Forms.GroupBox()
			Me.cmbStatus = New Global.System.Windows.Forms.ComboBox()
			Me.cmbIsActive = New Global.System.Windows.Forms.ComboBox()
			Me.Label17 = New Global.System.Windows.Forms.Label()
			Me.Label13 = New Global.System.Windows.Forms.Label()
			Me.cmbSType = New Global.System.Windows.Forms.ComboBox()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.dtpFrom = New Global.System.Windows.Forms.DateTimePicker()
			Me.dtpTo = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label16 = New Global.System.Windows.Forms.Label()
			Me.lblSDate = New Global.System.Windows.Forms.ComboBox()
			Me.arrow_btnAdvanceExp_sml = New Global.System.Windows.Forms.Button()
			Me.GbBasic = New Global.System.Windows.Forms.GroupBox()
			Me.txtSBOMVersion = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.txtSCatalogNo = New Global.System.Windows.Forms.TextBox()
			Me.Label37 = New Global.System.Windows.Forms.Label()
			Me.txtSName = New Global.System.Windows.Forms.TextBox()
			Me.Label11 = New Global.System.Windows.Forms.Label()
			Me.txtSCode = New Global.System.Windows.Forms.TextBox()
			Me.Label14 = New Global.System.Windows.Forms.Label()
			Me.arrow_btnBasicExp_sml = New Global.System.Windows.Forms.Button()
			Me.tab_lblList = New Global.System.Windows.Forms.Label()
			Me.txtCreatedByEmailID = New Global.System.Windows.Forms.TextBox()
			Me.txtModifiedByEmailID = New Global.System.Windows.Forms.TextBox()
			Me.txtActionByEmailID = New Global.System.Windows.Forms.TextBox()
			Me.theme_tc.SuspendLayout()
			Me.tpDetails.SuspendLayout()
			Me.Panel1.SuspendLayout()
			Me.theme_tcMaterial.SuspendLayout()
			Me.tpItems.SuspendLayout()
			Me.Panel2.SuspendLayout()
			CType(Me.dgvBOM, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tpRemarks.SuspendLayout()
			Me.Panel4.SuspendLayout()
			Me.flpButton.SuspendLayout()
			Me.grpProduct.SuspendLayout()
			Me.tpList.SuspendLayout()
			CType(Me.dgvList, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.grpListButton.SuspendLayout()
			Me.FlowLayoutPanel1.SuspendLayout()
			Me.GbAdvanced.SuspendLayout()
			Me.GbBasic.SuspendLayout()
			MyBase.SuspendLayout()
			Me.theme_tc.Controls.Add(Me.tpDetails)
			Me.theme_tc.Controls.Add(Me.tpList)
			Me.theme_tc.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.theme_tc.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.theme_tc.ItemSize = New Global.System.Drawing.Size(415, 21)
			Me.theme_tc.Location = New Global.System.Drawing.Point(0, 0)
			Me.theme_tc.Name = "theme_tc"
			Me.theme_tc.SelectedIndex = 0
			Me.theme_tc.Size = New Global.System.Drawing.Size(917, 563)
			Me.theme_tc.SizeMode = Global.System.Windows.Forms.TabSizeMode.Fixed
			Me.theme_tc.TabIndex = 10
			Me.theme_tc.TabStop = False
			Me.tpDetails.BackColor = Global.System.Drawing.Color.White
			Me.tpDetails.Controls.Add(Me.Panel1)
			Me.tpDetails.Controls.Add(Me.flpButton)
			Me.tpDetails.Controls.Add(Me.grpProduct)
			Me.tpDetails.Controls.Add(Me.tab_lblDetails)
			Me.tpDetails.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.tpDetails.Location = New Global.System.Drawing.Point(4, 25)
			Me.tpDetails.Name = "tpDetails"
			Me.tpDetails.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tpDetails.Size = New Global.System.Drawing.Size(909, 534)
			Me.tpDetails.TabIndex = 0
			Me.tpDetails.Text = "                           Details                           "
			Me.tpDetails.UseVisualStyleBackColor = True
			Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Panel1.Controls.Add(Me.theme_tcMaterial)
			Me.Panel1.Location = New Global.System.Drawing.Point(3, 202)
			Me.Panel1.Name = "Panel1"
			Me.Panel1.Size = New Global.System.Drawing.Size(900, 287)
			Me.Panel1.TabIndex = 1233
			Me.theme_tcMaterial.Controls.Add(Me.tpItems)
			Me.theme_tcMaterial.Controls.Add(Me.tpRemarks)
			Me.theme_tcMaterial.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.theme_tcMaterial.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.theme_tcMaterial.ItemSize = New Global.System.Drawing.Size(200, 30)
			Me.theme_tcMaterial.Location = New Global.System.Drawing.Point(0, 0)
			Me.theme_tcMaterial.Name = "theme_tcMaterial"
			Me.theme_tcMaterial.SelectedIndex = 0
			Me.theme_tcMaterial.Size = New Global.System.Drawing.Size(900, 287)
			Me.theme_tcMaterial.SizeMode = Global.System.Windows.Forms.TabSizeMode.Fixed
			Me.theme_tcMaterial.TabIndex = 1039
			Me.tpItems.BackColor = Global.System.Drawing.Color.White
			Me.tpItems.Controls.Add(Me.Panel2)
			Me.tpItems.Controls.Add(Me.Label10)
			Me.tpItems.Controls.Add(Me.cmbMaterialType)
			Me.tpItems.Controls.Add(Me.Label5)
			Me.tpItems.Controls.Add(Me.Label6)
			Me.tpItems.Controls.Add(Me.Label7)
			Me.tpItems.Controls.Add(Me.txtQty)
			Me.tpItems.Controls.Add(Me.cmbMaterial)
			Me.tpItems.Controls.Add(Me.Label40)
			Me.tpItems.Controls.Add(Me.llbAddItem)
			Me.tpItems.Controls.Add(Me.tab_lbl1)
			Me.tpItems.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.tpItems.Location = New Global.System.Drawing.Point(4, 34)
			Me.tpItems.Name = "tpItems"
			Me.tpItems.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tpItems.Size = New Global.System.Drawing.Size(892, 249)
			Me.tpItems.TabIndex = 0
			Me.tpItems.Text = "Material Details"
			Me.Panel2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Panel2.Controls.Add(Me.dgvBOM)
			Me.Panel2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Panel2.Location = New Global.System.Drawing.Point(6, 99)
			Me.Panel2.Name = "Panel2"
			Me.Panel2.Size = New Global.System.Drawing.Size(880, 146)
			Me.Panel2.TabIndex = 1239
			Me.dgvBOM.AllowUserToAddRows = False
			Me.dgvBOM.AllowUserToDeleteRows = False
			Me.dgvBOM.AllowUserToResizeRows = False
			Me.dgvBOM.BackgroundColor = Global.System.Drawing.Color.WhiteSmoke
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.GradientInactiveCaption
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvBOM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.dgvBOM.ColumnHeadersHeight = 25
			Me.dgvBOM.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.dgvBOM.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.ProductBOMID, Me.VersionID, Me.MaterialID, Me.IssueOrder, Me.MaterialType, Me.MaterialCode, Me.MaterialName, Me.PrimaryUOM, Me.Qty, Me.btnDelete_BOM })
			Me.dgvBOM.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.dgvBOM.Location = New Global.System.Drawing.Point(0, 0)
			Me.dgvBOM.Name = "dgvBOM"
			Me.dgvBOM.[ReadOnly] = True
			Me.dgvBOM.RowHeadersWidth = 30
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dgvBOM.RowsDefaultCellStyle = dataGridViewCellStyle2
			Me.dgvBOM.RowTemplate.Height = 25
			Me.dgvBOM.Size = New Global.System.Drawing.Size(880, 146)
			Me.dgvBOM.TabIndex = 1141
			Me.ProductBOMID.DataPropertyName = "ProductBOMID"
			Me.ProductBOMID.HeaderText = "ProductBOMID"
			Me.ProductBOMID.Name = "ProductBOMID"
			Me.ProductBOMID.[ReadOnly] = True
			Me.ProductBOMID.Visible = False
			Me.VersionID.DataPropertyName = "VersionID"
			Me.VersionID.HeaderText = "VersionID"
			Me.VersionID.Name = "VersionID"
			Me.VersionID.[ReadOnly] = True
			Me.VersionID.Visible = False
			Me.MaterialID.DataPropertyName = "MaterialID"
			Me.MaterialID.HeaderText = "MaterialID"
			Me.MaterialID.Name = "MaterialID"
			Me.MaterialID.[ReadOnly] = True
			Me.MaterialID.Visible = False
			Me.IssueOrder.DataPropertyName = "IssueOrder"
			Me.IssueOrder.HeaderText = "IssueOrder"
			Me.IssueOrder.Name = "IssueOrder"
			Me.IssueOrder.[ReadOnly] = True
			Me.IssueOrder.Visible = False
			Me.MaterialType.DataPropertyName = "MaterialType"
			Me.MaterialType.HeaderText = "Material Type"
			Me.MaterialType.Name = "MaterialType"
			Me.MaterialType.[ReadOnly] = True
			Me.MaterialType.Width = 120
			Me.MaterialCode.DataPropertyName = "MaterialCode"
			Me.MaterialCode.HeaderText = "Material Code"
			Me.MaterialCode.Name = "MaterialCode"
			Me.MaterialCode.[ReadOnly] = True
			Me.MaterialCode.Resizable = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.MaterialCode.Width = 150
			Me.MaterialName.DataPropertyName = "MaterialName"
			Me.MaterialName.HeaderText = "Material Name"
			Me.MaterialName.Name = "MaterialName"
			Me.MaterialName.[ReadOnly] = True
			Me.MaterialName.Width = 300
			Me.PrimaryUOM.DataPropertyName = "PrimaryUOM"
			Me.PrimaryUOM.HeaderText = "Primary UOM"
			Me.PrimaryUOM.Name = "PrimaryUOM"
			Me.PrimaryUOM.[ReadOnly] = True
			Me.Qty.DataPropertyName = "Qty"
			dataGridViewCellStyle3.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.Qty.DefaultCellStyle = dataGridViewCellStyle3
			Me.Qty.HeaderText = "Primary Qty."
			Me.Qty.Name = "Qty"
			Me.Qty.[ReadOnly] = True
			Me.Qty.Width = 90
			Me.btnDelete_BOM.HeaderText = ""
			Me.btnDelete_BOM.ImageLayout = Global.System.Windows.Forms.DataGridViewImageCellLayout.Stretch
			Me.btnDelete_BOM.Name = "btnDelete_BOM"
			Me.btnDelete_BOM.[ReadOnly] = True
			Me.btnDelete_BOM.Width = 25
			Me.Label10.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label10.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label10.Location = New Global.System.Drawing.Point(662, 14)
			Me.Label10.Name = "Label10"
			Me.Label10.Size = New Global.System.Drawing.Size(224, 48)
			Me.Label10.TabIndex = 1238
			Me.Label10.Text = "NOTE : Qty. Required is Primary units of material required for each primary unit of manufactured product"
			Me.cmbMaterialType.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbMaterialType.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbMaterialType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbMaterialType.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbMaterialType.FormattingEnabled = True
			Me.cmbMaterialType.Items.AddRange(New Object() { "", "Raw Material", "Packaging Material", "Consumable", "Semi Finished", "Cell Bank - Mammalian", "Cell Bank - Bacterial", "Others" })
			Me.cmbMaterialType.Location = New Global.System.Drawing.Point(114, 11)
			Me.cmbMaterialType.Name = "cmbMaterialType"
			Me.cmbMaterialType.Size = New Global.System.Drawing.Size(365, 23)
			Me.cmbMaterialType.TabIndex = 1230
			Me.Label5.AutoSize = True
			Me.Label5.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label5.Location = New Global.System.Drawing.Point(10, 14)
			Me.Label5.Name = "Label5"
			Me.Label5.Size = New Global.System.Drawing.Size(84, 15)
			Me.Label5.TabIndex = 1237
			Me.Label5.Text = "Material Type"
			Me.Label6.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label6.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label6.Location = New Global.System.Drawing.Point(254, 67)
			Me.Label6.Name = "Label6"
			Me.Label6.Size = New Global.System.Drawing.Size(77, 21)
			Me.Label6.TabIndex = 1236
			Me.Label6.Text = "in Primary"
			Me.Label6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label7.AutoSize = True
			Me.Label7.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label7.Location = New Global.System.Drawing.Point(10, 70)
			Me.Label7.Name = "Label7"
			Me.Label7.Size = New Global.System.Drawing.Size(90, 15)
			Me.Label7.TabIndex = 1235
			Me.Label7.Text = "Qty. Required "
			Me.txtQty.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtQty.Location = New Global.System.Drawing.Point(114, 67)
			Me.txtQty.Name = "txtQty"
			Me.txtQty.Size = New Global.System.Drawing.Size(131, 21)
			Me.txtQty.TabIndex = 1232
			Me.cmbMaterial.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbMaterial.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbMaterial.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbMaterial.FormattingEnabled = True
			Me.cmbMaterial.Location = New Global.System.Drawing.Point(114, 39)
			Me.cmbMaterial.Name = "cmbMaterial"
			Me.cmbMaterial.Size = New Global.System.Drawing.Size(365, 23)
			Me.cmbMaterial.TabIndex = 1231
			Me.Label40.AutoSize = True
			Me.Label40.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label40.Location = New Global.System.Drawing.Point(10, 43)
			Me.Label40.Name = "Label40"
			Me.Label40.Size = New Global.System.Drawing.Size(52, 15)
			Me.Label40.TabIndex = 1234
			Me.Label40.Text = "Material"
			Me.llbAddItem.ActiveLinkColor = Global.System.Drawing.Color.Maroon
			Me.llbAddItem.AutoSize = True
			Me.llbAddItem.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.llbAddItem.LinkColor = Global.System.Drawing.Color.Maroon
			Me.llbAddItem.Location = New Global.System.Drawing.Point(388, 70)
			Me.llbAddItem.Name = "llbAddItem"
			Me.llbAddItem.Size = New Global.System.Drawing.Size(90, 15)
			Me.llbAddItem.TabIndex = 1233
			Me.llbAddItem.TabStop = True
			Me.llbAddItem.Text = "Add Material"
			Me.tab_lbl1.BackColor = Global.System.Drawing.Color.Black
			Me.tab_lbl1.ForeColor = Global.System.Drawing.Color.PaleGreen
			Me.tab_lbl1.Location = New Global.System.Drawing.Point(-2, 0)
			Me.tab_lbl1.Name = "tab_lbl1"
			Me.tab_lbl1.Size = New Global.System.Drawing.Size(898, 3)
			Me.tab_lbl1.TabIndex = 6
			Me.tpRemarks.Controls.Add(Me.tab_lbl2)
			Me.tpRemarks.Controls.Add(Me.lblRemarksApproval1)
			Me.tpRemarks.Controls.Add(Me.lblRemarks1)
			Me.tpRemarks.Controls.Add(Me.Panel4)
			Me.tpRemarks.Controls.Add(Me.lblRemarks)
			Me.tpRemarks.Controls.Add(Me.lblRemarksApproval)
			Me.tpRemarks.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.tpRemarks.Location = New Global.System.Drawing.Point(4, 34)
			Me.tpRemarks.Name = "tpRemarks"
			Me.tpRemarks.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tpRemarks.Size = New Global.System.Drawing.Size(892, 249)
			Me.tpRemarks.TabIndex = 7
			Me.tpRemarks.Text = "Remarks"
			Me.tpRemarks.UseVisualStyleBackColor = True
			Me.tab_lbl2.BackColor = Global.System.Drawing.Color.Black
			Me.tab_lbl2.ForeColor = Global.System.Drawing.Color.PaleGreen
			Me.tab_lbl2.Location = New Global.System.Drawing.Point(0, 0)
			Me.tab_lbl2.Name = "tab_lbl2"
			Me.tab_lbl2.Size = New Global.System.Drawing.Size(895, 3)
			Me.tab_lbl2.TabIndex = 730
			Me.lblRemarksApproval1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRemarksApproval1.Location = New Global.System.Drawing.Point(75, 48)
			Me.lblRemarksApproval1.Name = "lblRemarksApproval1"
			Me.lblRemarksApproval1.Size = New Global.System.Drawing.Size(17, 29)
			Me.lblRemarksApproval1.TabIndex = 729
			Me.lblRemarksApproval1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.lblRemarksApproval1.Visible = False
			Me.lblRemarks1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRemarks1.Location = New Global.System.Drawing.Point(74, 16)
			Me.lblRemarks1.Name = "lblRemarks1"
			Me.lblRemarks1.Size = New Global.System.Drawing.Size(17, 29)
			Me.lblRemarks1.TabIndex = 725
			Me.lblRemarks1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Panel4.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Panel4.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Panel4.Controls.Add(Me.txtRemarksApproval)
			Me.Panel4.Controls.Add(Me.txtRemarks)
			Me.Panel4.Location = New Global.System.Drawing.Point(87, 15)
			Me.Panel4.Name = "Panel4"
			Me.Panel4.Size = New Global.System.Drawing.Size(799, 230)
			Me.Panel4.TabIndex = 720
			Me.txtRemarksApproval.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtRemarksApproval.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtRemarksApproval.Location = New Global.System.Drawing.Point(10, 8)
			Me.txtRemarksApproval.Multiline = True
			Me.txtRemarksApproval.Name = "txtRemarksApproval"
			Me.txtRemarksApproval.[ReadOnly] = True
			Me.txtRemarksApproval.Size = New Global.System.Drawing.Size(778, 213)
			Me.txtRemarksApproval.TabIndex = 727
			Me.txtRemarks.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtRemarks.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtRemarks.Location = New Global.System.Drawing.Point(10, 8)
			Me.txtRemarks.Multiline = True
			Me.txtRemarks.Name = "txtRemarks"
			Me.txtRemarks.Size = New Global.System.Drawing.Size(778, 213)
			Me.txtRemarks.TabIndex = 724
			Me.lblRemarks.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.lblRemarks.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRemarks.Location = New Global.System.Drawing.Point(6, 15)
			Me.lblRemarks.Name = "lblRemarks"
			Me.lblRemarks.Size = New Global.System.Drawing.Size(81, 31)
			Me.lblRemarks.TabIndex = 720
			Me.lblRemarks.Text = "Remarks"
			Me.lblRemarks.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.lblRemarksApproval.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRemarksApproval.Location = New Global.System.Drawing.Point(6, 47)
			Me.lblRemarksApproval.Name = "lblRemarksApproval"
			Me.lblRemarksApproval.Size = New Global.System.Drawing.Size(81, 31)
			Me.lblRemarksApproval.TabIndex = 728
			Me.lblRemarksApproval.Text = "Action"
			Me.lblRemarksApproval.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.lblRemarksApproval.Visible = False
			Me.flpButton.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.flpButton.Controls.Add(Me.btnAdd)
			Me.flpButton.Controls.Add(Me.btnApprove)
			Me.flpButton.Controls.Add(Me.btnOnHold)
			Me.flpButton.Controls.Add(Me.btnReject)
			Me.flpButton.Controls.Add(Me.btnEdit)
			Me.flpButton.Controls.Add(Me.btnSave)
			Me.flpButton.Controls.Add(Me.btnClear)
			Me.flpButton.Controls.Add(Me.btnClose)
			Me.flpButton.Location = New Global.System.Drawing.Point(40, 493)
			Me.flpButton.Name = "flpButton"
			Me.flpButton.Padding = New Global.System.Windows.Forms.Padding(0, 2, 0, 0)
			Me.flpButton.Size = New Global.System.Drawing.Size(829, 33)
			Me.flpButton.TabIndex = 1232
			Me.btnAdd.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnAdd.Location = New Global.System.Drawing.Point(0, 2)
			Me.btnAdd.Margin = New Global.System.Windows.Forms.Padding(0)
			Me.btnAdd.Name = "btnAdd"
			Me.btnAdd.Size = New Global.System.Drawing.Size(102, 29)
			Me.btnAdd.TabIndex = 3
			Me.btnAdd.Text = "&Add"
			Me.btnAdd.UseVisualStyleBackColor = True
			Me.btnApprove.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnApprove.Location = New Global.System.Drawing.Point(102, 2)
			Me.btnApprove.Margin = New Global.System.Windows.Forms.Padding(0)
			Me.btnApprove.Name = "btnApprove"
			Me.btnApprove.Size = New Global.System.Drawing.Size(102, 29)
			Me.btnApprove.TabIndex = 0
			Me.btnApprove.Text = "Approve"
			Me.btnApprove.UseVisualStyleBackColor = True
			Me.btnOnHold.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnOnHold.Location = New Global.System.Drawing.Point(206, 2)
			Me.btnOnHold.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnOnHold.Name = "btnOnHold"
			Me.btnOnHold.Size = New Global.System.Drawing.Size(102, 29)
			Me.btnOnHold.TabIndex = 2
			Me.btnOnHold.Text = "On Hold"
			Me.btnOnHold.UseVisualStyleBackColor = True
			Me.btnReject.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnReject.Location = New Global.System.Drawing.Point(310, 2)
			Me.btnReject.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnReject.Name = "btnReject"
			Me.btnReject.Size = New Global.System.Drawing.Size(102, 29)
			Me.btnReject.TabIndex = 1
			Me.btnReject.Text = "Reject"
			Me.btnReject.UseVisualStyleBackColor = True
			Me.btnEdit.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnEdit.Location = New Global.System.Drawing.Point(414, 2)
			Me.btnEdit.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnEdit.Name = "btnEdit"
			Me.btnEdit.Size = New Global.System.Drawing.Size(102, 29)
			Me.btnEdit.TabIndex = 4
			Me.btnEdit.Text = "&Modify"
			Me.btnEdit.UseVisualStyleBackColor = True
			Me.btnSave.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnSave.Location = New Global.System.Drawing.Point(518, 2)
			Me.btnSave.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New Global.System.Drawing.Size(102, 29)
			Me.btnSave.TabIndex = 5
			Me.btnSave.Text = "&Save"
			Me.btnSave.UseVisualStyleBackColor = True
			Me.btnClear.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClear.Location = New Global.System.Drawing.Point(622, 2)
			Me.btnClear.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnClear.Name = "btnClear"
			Me.btnClear.Size = New Global.System.Drawing.Size(102, 29)
			Me.btnClear.TabIndex = 6
			Me.btnClear.Text = "&Clear"
			Me.btnClear.UseVisualStyleBackColor = True
			Me.btnClose.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClose.Location = New Global.System.Drawing.Point(726, 2)
			Me.btnClose.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnClose.Name = "btnClose"
			Me.btnClose.Size = New Global.System.Drawing.Size(102, 29)
			Me.btnClose.TabIndex = 7
			Me.btnClose.Text = "C&lose"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.grpProduct.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.grpProduct.Controls.Add(Me.txtActionByEmailID)
			Me.grpProduct.Controls.Add(Me.txtModifiedByEmailID)
			Me.grpProduct.Controls.Add(Me.txtCreatedByEmailID)
			Me.grpProduct.Controls.Add(Me.Label20)
			Me.grpProduct.Controls.Add(Me.skip_lblStatus)
			Me.grpProduct.Controls.Add(Me.Label12)
			Me.grpProduct.Controls.Add(Me.txtID)
			Me.grpProduct.Controls.Add(Me.Label15)
			Me.grpProduct.Controls.Add(Me.txtBatchQty)
			Me.grpProduct.Controls.Add(Me.lblVersion)
			Me.grpProduct.Controls.Add(Me.Label4)
			Me.grpProduct.Controls.Add(Me.Label19)
			Me.grpProduct.Controls.Add(Me.txtProductName)
			Me.grpProduct.Controls.Add(Me.cmbType)
			Me.grpProduct.Controls.Add(Me.Label18)
			Me.grpProduct.Controls.Add(Me.cmbProduct)
			Me.grpProduct.Controls.Add(Me.Label9)
			Me.grpProduct.Controls.Add(Me.dtpExpiryDt)
			Me.grpProduct.Controls.Add(Me.Label2)
			Me.grpProduct.Controls.Add(Me.dtpEffectiveDt)
			Me.grpProduct.Controls.Add(Me.Label3)
			Me.grpProduct.Controls.Add(Me.Lable5)
			Me.grpProduct.Controls.Add(Me.txtBOMVersion)
			Me.grpProduct.Controls.Add(Me.chkIsActive)
			Me.grpProduct.Controls.Add(Me.skip_Label12)
			Me.grpProduct.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.grpProduct.Location = New Global.System.Drawing.Point(5, 9)
			Me.grpProduct.Name = "grpProduct"
			Me.grpProduct.Size = New Global.System.Drawing.Size(898, 188)
			Me.grpProduct.TabIndex = 0
			Me.grpProduct.TabStop = False
			Me.grpProduct.Text = "Product Details"
			Me.Label20.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label20.ForeColor = Global.System.Drawing.Color.Red
			Me.Label20.Location = New Global.System.Drawing.Point(25, 137)
			Me.Label20.Name = "Label20"
			Me.Label20.Size = New Global.System.Drawing.Size(12, 15)
			Me.Label20.TabIndex = 1235
			Me.Label20.Text = "*"
			Me.Label20.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.skip_lblStatus.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.skip_lblStatus.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.skip_lblStatus.ForeColor = Global.System.Drawing.Color.LawnGreen
			Me.skip_lblStatus.Location = New Global.System.Drawing.Point(717, 23)
			Me.skip_lblStatus.Name = "skip_lblStatus"
			Me.skip_lblStatus.Size = New Global.System.Drawing.Size(171, 27)
			Me.skip_lblStatus.TabIndex = 1234
			Me.skip_lblStatus.Text = "Approval Pending"
			Me.skip_lblStatus.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.Label12.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label12.ForeColor = Global.System.Drawing.Color.Red
			Me.Label12.Location = New Global.System.Drawing.Point(278, 111)
			Me.Label12.Name = "Label12"
			Me.Label12.Size = New Global.System.Drawing.Size(12, 15)
			Me.Label12.TabIndex = 1233
			Me.Label12.Text = "*"
			Me.Label12.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label15.AutoSize = True
			Me.Label15.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label15.Location = New Global.System.Drawing.Point(288, 111)
			Me.Label15.Name = "Label15"
			Me.Label15.Size = New Global.System.Drawing.Size(67, 15)
			Me.Label15.TabIndex = 1232
			Me.Label15.Text = "Batch Qty."
			Me.txtBatchQty.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtBatchQty.Location = New Global.System.Drawing.Point(367, 108)
			Me.txtBatchQty.Name = "txtBatchQty"
			Me.txtBatchQty.Size = New Global.System.Drawing.Size(137, 21)
			Me.txtBatchQty.TabIndex = 4
			Me.lblVersion.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblVersion.ForeColor = Global.System.Drawing.Color.Red
			Me.lblVersion.Location = New Global.System.Drawing.Point(510, 85)
			Me.lblVersion.Name = "lblVersion"
			Me.lblVersion.Size = New Global.System.Drawing.Size(98, 15)
			Me.lblVersion.TabIndex = 1230
			Me.lblVersion.Text = "*"
			Me.lblVersion.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.lblVersion.Visible = False
			Me.Label4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label4.ForeColor = Global.System.Drawing.Color.Red
			Me.Label4.Location = New Global.System.Drawing.Point(25, 111)
			Me.Label4.Name = "Label4"
			Me.Label4.Size = New Global.System.Drawing.Size(12, 15)
			Me.Label4.TabIndex = 1229
			Me.Label4.Text = "*"
			Me.Label4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label19.AutoSize = True
			Me.Label19.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label19.Location = New Global.System.Drawing.Point(35, 85)
			Me.Label19.Name = "Label19"
			Me.Label19.Size = New Global.System.Drawing.Size(87, 15)
			Me.Label19.TabIndex = 1228
			Me.Label19.Text = "Product Name"
			Me.txtProductName.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtProductName.Location = New Global.System.Drawing.Point(139, 82)
			Me.txtProductName.Name = "txtProductName"
			Me.txtProductName.[ReadOnly] = True
			Me.txtProductName.Size = New Global.System.Drawing.Size(365, 21)
			Me.txtProductName.TabIndex = 2
			Me.txtProductName.TabStop = False
			Me.cmbType.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbType.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbType.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbType.FormattingEnabled = True
			Me.cmbType.Items.AddRange(New Object() { "", "Finished Goods", "Semi Finished", "Cell Bank - Mammalian", "Cell Bank - Bacterial" })
			Me.cmbType.Location = New Global.System.Drawing.Point(139, 26)
			Me.cmbType.Name = "cmbType"
			Me.cmbType.Size = New Global.System.Drawing.Size(365, 23)
			Me.cmbType.TabIndex = 0
			Me.Label18.AutoSize = True
			Me.Label18.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label18.Location = New Global.System.Drawing.Point(35, 30)
			Me.Label18.Name = "Label18"
			Me.Label18.Size = New Global.System.Drawing.Size(82, 15)
			Me.Label18.TabIndex = 1226
			Me.Label18.Text = "Product Type"
			Me.cmbProduct.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbProduct.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbProduct.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbProduct.FormattingEnabled = True
			Me.cmbProduct.Location = New Global.System.Drawing.Point(139, 54)
			Me.cmbProduct.Name = "cmbProduct"
			Me.cmbProduct.Size = New Global.System.Drawing.Size(365, 23)
			Me.cmbProduct.TabIndex = 1
			Me.Label9.AutoSize = True
			Me.Label9.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label9.Location = New Global.System.Drawing.Point(35, 57)
			Me.Label9.Name = "Label9"
			Me.Label9.Size = New Global.System.Drawing.Size(50, 15)
			Me.Label9.TabIndex = 1225
			Me.Label9.Text = "Product"
			Me.dtpExpiryDt.Checked = False
			Me.dtpExpiryDt.CustomFormat = "dd   MMM   yyyy"
			Me.dtpExpiryDt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpExpiryDt.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpExpiryDt.Location = New Global.System.Drawing.Point(367, 134)
			Me.dtpExpiryDt.Name = "dtpExpiryDt"
			Me.dtpExpiryDt.ShowCheckBox = True
			Me.dtpExpiryDt.Size = New Global.System.Drawing.Size(137, 21)
			Me.dtpExpiryDt.TabIndex = 6
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.Location = New Global.System.Drawing.Point(288, 137)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(74, 15)
			Me.Label2.TabIndex = 1222
			Me.Label2.Text = "Expiry Date"
			Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.dtpEffectiveDt.Checked = False
			Me.dtpEffectiveDt.CustomFormat = "dd   MMM   yyyy"
			Me.dtpEffectiveDt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpEffectiveDt.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpEffectiveDt.Location = New Global.System.Drawing.Point(139, 134)
			Me.dtpEffectiveDt.Name = "dtpEffectiveDt"
			Me.dtpEffectiveDt.ShowCheckBox = True
			Me.dtpEffectiveDt.Size = New Global.System.Drawing.Size(137, 21)
			Me.dtpEffectiveDt.TabIndex = 5
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.Location = New Global.System.Drawing.Point(35, 137)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(87, 15)
			Me.Label3.TabIndex = 1221
			Me.Label3.Text = "Effective Date"
			Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Lable5.AutoSize = True
			Me.Lable5.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Lable5.Location = New Global.System.Drawing.Point(35, 111)
			Me.Lable5.Name = "Lable5"
			Me.Lable5.Size = New Global.System.Drawing.Size(80, 15)
			Me.Lable5.TabIndex = 1220
			Me.Lable5.Text = "BOM Version"
			Me.txtBOMVersion.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtBOMVersion.Location = New Global.System.Drawing.Point(139, 108)
			Me.txtBOMVersion.Name = "txtBOMVersion"
			Me.txtBOMVersion.Size = New Global.System.Drawing.Size(137, 21)
			Me.txtBOMVersion.TabIndex = 3
			Me.chkIsActive.AutoSize = True
			Me.chkIsActive.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.chkIsActive.Location = New Global.System.Drawing.Point(143, 161)
			Me.chkIsActive.Name = "chkIsActive"
			Me.chkIsActive.Size = New Global.System.Drawing.Size(76, 19)
			Me.chkIsActive.TabIndex = 7
			Me.chkIsActive.Text = "Is Active"
			Me.chkIsActive.UseVisualStyleBackColor = True
			Me.skip_Label12.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.skip_Label12.ForeColor = Global.System.Drawing.Color.Red
			Me.skip_Label12.Location = New Global.System.Drawing.Point(25, 57)
			Me.skip_Label12.Name = "skip_Label12"
			Me.skip_Label12.Size = New Global.System.Drawing.Size(12, 15)
			Me.skip_Label12.TabIndex = 1216
			Me.skip_Label12.Text = "*"
			Me.skip_Label12.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.txtID.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtID.Location = New Global.System.Drawing.Point(820, 161)
			Me.txtID.Name = "txtID"
			Me.txtID.Size = New Global.System.Drawing.Size(10, 21)
			Me.txtID.TabIndex = 1176
			Me.txtID.TabStop = False
			Me.txtID.Visible = False
			Me.tab_lblDetails.BackColor = Global.System.Drawing.Color.Black
			Me.tab_lblDetails.ForeColor = Global.System.Drawing.Color.PaleGreen
			Me.tab_lblDetails.Location = New Global.System.Drawing.Point(0, 0)
			Me.tab_lblDetails.Name = "tab_lblDetails"
			Me.tab_lblDetails.Size = New Global.System.Drawing.Size(852, 3)
			Me.tab_lblDetails.TabIndex = 32
			Me.tpList.BackColor = Global.System.Drawing.Color.White
			Me.tpList.Controls.Add(Me.dgvList)
			Me.tpList.Controls.Add(Me.grpListButton)
			Me.tpList.Controls.Add(Me.GbAdvanced)
			Me.tpList.Controls.Add(Me.GbBasic)
			Me.tpList.Controls.Add(Me.tab_lblList)
			Me.tpList.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.tpList.Location = New Global.System.Drawing.Point(4, 25)
			Me.tpList.Name = "tpList"
			Me.tpList.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tpList.Size = New Global.System.Drawing.Size(909, 534)
			Me.tpList.TabIndex = 1
			Me.tpList.Text = "                              List                              "
			Me.tpList.UseVisualStyleBackColor = True
			Me.dgvList.AllowUserToAddRows = False
			Me.dgvList.AllowUserToDeleteRows = False
			Me.dgvList.BackgroundColor = Global.System.Drawing.Color.WhiteSmoke
			dataGridViewCellStyle4.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle4.BackColor = Global.System.Drawing.Color.AliceBlue
			dataGridViewCellStyle4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle4.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle4.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle4.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle4.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4
			Me.dgvList.ColumnHeadersHeight = 35
			Me.dgvList.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.dgvList.Location = New Global.System.Drawing.Point(3, 254)
			Me.dgvList.Name = "dgvList"
			Me.dgvList.[ReadOnly] = True
			dataGridViewCellStyle5.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle5.BackColor = Global.System.Drawing.Color.AliceBlue
			dataGridViewCellStyle5.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle5.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle5.SelectionBackColor = Global.System.Drawing.Color.PowderBlue
			dataGridViewCellStyle5.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle5.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5
			Me.dgvList.RowHeadersWidth = 25
			dataGridViewCellStyle6.SelectionBackColor = Global.System.Drawing.Color.PowderBlue
			dataGridViewCellStyle6.SelectionForeColor = Global.System.Drawing.Color.Black
			Me.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle6
			Me.dgvList.RowTemplate.DefaultCellStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dgvList.Size = New Global.System.Drawing.Size(903, 277)
			Me.dgvList.TabIndex = 488
			Me.grpListButton.Controls.Add(Me.FlowLayoutPanel1)
			Me.grpListButton.Controls.Add(Me.lblRows)
			Me.grpListButton.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.grpListButton.Location = New Global.System.Drawing.Point(3, 205)
			Me.grpListButton.Name = "grpListButton"
			Me.grpListButton.Size = New Global.System.Drawing.Size(903, 49)
			Me.grpListButton.TabIndex = 484
			Me.grpListButton.TabStop = False
			Me.FlowLayoutPanel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
			Me.FlowLayoutPanel1.Controls.Add(Me.btnSearch)
			Me.FlowLayoutPanel1.Controls.Add(Me.btnClearList)
			Me.FlowLayoutPanel1.Controls.Add(Me.btnExport)
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
			Me.lblRows.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblRows.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRows.Location = New Global.System.Drawing.Point(787, 21)
			Me.lblRows.Name = "lblRows"
			Me.lblRows.Size = New Global.System.Drawing.Size(108, 15)
			Me.lblRows.TabIndex = 483
			Me.lblRows.Text = "0 - Rows"
			Me.lblRows.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.GbAdvanced.Controls.Add(Me.cmbStatus)
			Me.GbAdvanced.Controls.Add(Me.cmbIsActive)
			Me.GbAdvanced.Controls.Add(Me.Label17)
			Me.GbAdvanced.Controls.Add(Me.Label13)
			Me.GbAdvanced.Controls.Add(Me.cmbSType)
			Me.GbAdvanced.Controls.Add(Me.Label8)
			Me.GbAdvanced.Controls.Add(Me.dtpFrom)
			Me.GbAdvanced.Controls.Add(Me.dtpTo)
			Me.GbAdvanced.Controls.Add(Me.Label16)
			Me.GbAdvanced.Controls.Add(Me.lblSDate)
			Me.GbAdvanced.Controls.Add(Me.arrow_btnAdvanceExp_sml)
			Me.GbAdvanced.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.GbAdvanced.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GbAdvanced.Location = New Global.System.Drawing.Point(3, 118)
			Me.GbAdvanced.Name = "GbAdvanced"
			Me.GbAdvanced.Size = New Global.System.Drawing.Size(903, 87)
			Me.GbAdvanced.TabIndex = 481
			Me.GbAdvanced.TabStop = False
			Me.GbAdvanced.Text = "     Advanced Search "
			Me.cmbStatus.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbStatus.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbStatus.FormattingEnabled = True
			Me.cmbStatus.Items.AddRange(New Object() { "", "Approval Pending", "Approved", "On-Hold", "Rejected" })
			Me.cmbStatus.Location = New Global.System.Drawing.Point(441, 56)
			Me.cmbStatus.Name = "cmbStatus"
			Me.cmbStatus.Size = New Global.System.Drawing.Size(198, 23)
			Me.cmbStatus.TabIndex = 3
			Me.cmbIsActive.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbIsActive.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbIsActive.FormattingEnabled = True
			Me.cmbIsActive.Items.AddRange(New Object() { "", "Yes", "No" })
			Me.cmbIsActive.Location = New Global.System.Drawing.Point(720, 56)
			Me.cmbIsActive.Name = "cmbIsActive"
			Me.cmbIsActive.Size = New Global.System.Drawing.Size(175, 23)
			Me.cmbIsActive.TabIndex = 4
			Me.cmbIsActive.Visible = False
			Me.Label17.AutoSize = True
			Me.Label17.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label17.Location = New Global.System.Drawing.Point(657, 59)
			Me.Label17.Name = "Label17"
			Me.Label17.Size = New Global.System.Drawing.Size(57, 15)
			Me.Label17.TabIndex = 755
			Me.Label17.Text = "Is Active"
			Me.Label17.Visible = False
			Me.Label13.AutoSize = True
			Me.Label13.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label13.Location = New Global.System.Drawing.Point(363, 59)
			Me.Label13.Name = "Label13"
			Me.Label13.Size = New Global.System.Drawing.Size(43, 15)
			Me.Label13.TabIndex = 753
			Me.Label13.Text = "Status"
			Me.cmbSType.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbSType.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbSType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbSType.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbSType.FormattingEnabled = True
			Me.cmbSType.Items.AddRange(New Object() { "", "Finished Goods", "Semi Finished", "Cell Bank - Mammalian", "Cell Bank - Bacterial" })
			Me.cmbSType.Location = New Global.System.Drawing.Point(151, 56)
			Me.cmbSType.Name = "cmbSType"
			Me.cmbSType.Size = New Global.System.Drawing.Size(198, 23)
			Me.cmbSType.TabIndex = 2
			Me.Label8.AutoSize = True
			Me.Label8.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label8.Location = New Global.System.Drawing.Point(16, 59)
			Me.Label8.Name = "Label8"
			Me.Label8.Size = New Global.System.Drawing.Size(82, 15)
			Me.Label8.TabIndex = 748
			Me.Label8.Text = "Product Type"
			Me.dtpFrom.Checked = False
			Me.dtpFrom.CustomFormat = "dd MMM yyyy  00:00"
			Me.dtpFrom.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpFrom.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpFrom.Location = New Global.System.Drawing.Point(151, 29)
			Me.dtpFrom.Name = "dtpFrom"
			Me.dtpFrom.ShowCheckBox = True
			Me.dtpFrom.Size = New Global.System.Drawing.Size(198, 21)
			Me.dtpFrom.TabIndex = 0
			Me.dtpTo.Checked = False
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
			Me.lblSDate.Items.AddRange(New Object() { "Effective Date", "Expiry Date" })
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
			Me.GbBasic.BackColor = Global.System.Drawing.Color.White
			Me.GbBasic.Controls.Add(Me.txtSBOMVersion)
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
			Me.GbBasic.Location = New Global.System.Drawing.Point(3, 3)
			Me.GbBasic.Name = "GbBasic"
			Me.GbBasic.Size = New Global.System.Drawing.Size(903, 115)
			Me.GbBasic.TabIndex = 480
			Me.GbBasic.TabStop = False
			Me.GbBasic.Text = "     Basic Search "
			Me.txtSBOMVersion.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtSBOMVersion.Location = New Global.System.Drawing.Point(151, 81)
			Me.txtSBOMVersion.Name = "txtSBOMVersion"
			Me.txtSBOMVersion.Size = New Global.System.Drawing.Size(488, 21)
			Me.txtSBOMVersion.TabIndex = 3
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
			Me.tab_lblList.BackColor = Global.System.Drawing.Color.Black
			Me.tab_lblList.ForeColor = Global.System.Drawing.Color.PaleGreen
			Me.tab_lblList.Location = New Global.System.Drawing.Point(0, 0)
			Me.tab_lblList.Name = "tab_lblList"
			Me.tab_lblList.Size = New Global.System.Drawing.Size(853, 3)
			Me.tab_lblList.TabIndex = 7
			Me.txtCreatedByEmailID.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtCreatedByEmailID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtCreatedByEmailID.Location = New Global.System.Drawing.Point(832, 161)
			Me.txtCreatedByEmailID.Name = "txtCreatedByEmailID"
			Me.txtCreatedByEmailID.Size = New Global.System.Drawing.Size(10, 21)
			Me.txtCreatedByEmailID.TabIndex = 1236
			Me.txtCreatedByEmailID.TabStop = False
			Me.txtCreatedByEmailID.Visible = False
			Me.txtModifiedByEmailID.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtModifiedByEmailID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtModifiedByEmailID.Location = New Global.System.Drawing.Point(844, 161)
			Me.txtModifiedByEmailID.Name = "txtModifiedByEmailID"
			Me.txtModifiedByEmailID.Size = New Global.System.Drawing.Size(10, 21)
			Me.txtModifiedByEmailID.TabIndex = 1237
			Me.txtModifiedByEmailID.TabStop = False
			Me.txtModifiedByEmailID.Visible = False
			Me.txtActionByEmailID.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtActionByEmailID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtActionByEmailID.Location = New Global.System.Drawing.Point(857, 161)
			Me.txtActionByEmailID.Name = "txtActionByEmailID"
			Me.txtActionByEmailID.Size = New Global.System.Drawing.Size(10, 21)
			Me.txtActionByEmailID.TabIndex = 1238
			Me.txtActionByEmailID.TabStop = False
			Me.txtActionByEmailID.Visible = False
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			MyBase.ClientSize = New Global.System.Drawing.Size(917, 563)
			MyBase.Controls.Add(Me.theme_tc)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.Name = "ProductBOM01"
			Me.Text = "Product BOM"
			Me.theme_tc.ResumeLayout(False)
			Me.tpDetails.ResumeLayout(False)
			Me.Panel1.ResumeLayout(False)
			Me.theme_tcMaterial.ResumeLayout(False)
			Me.tpItems.ResumeLayout(False)
			Me.tpItems.PerformLayout()
			Me.Panel2.ResumeLayout(False)
			CType(Me.dgvBOM, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.tpRemarks.ResumeLayout(False)
			Me.Panel4.ResumeLayout(False)
			Me.Panel4.PerformLayout()
			Me.flpButton.ResumeLayout(False)
			Me.grpProduct.ResumeLayout(False)
			Me.grpProduct.PerformLayout()
			Me.tpList.ResumeLayout(False)
			CType(Me.dgvList, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.grpListButton.ResumeLayout(False)
			Me.FlowLayoutPanel1.ResumeLayout(False)
			Me.GbAdvanced.ResumeLayout(False)
			Me.GbAdvanced.PerformLayout()
			Me.GbBasic.ResumeLayout(False)
			Me.GbBasic.PerformLayout()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x0400005E RID: 94
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
