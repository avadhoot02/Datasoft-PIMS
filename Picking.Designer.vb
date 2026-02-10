Namespace Datasoft_PIMS
	' Token: 0x02000065 RID: 101
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Picking
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060018E3 RID: 6371 RVA: 0x000E72D0 File Offset: 0x000E54D0
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

		' Token: 0x060018E4 RID: 6372 RVA: 0x000E7320 File Offset: 0x000E5520
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle4 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle5 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle6 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle7 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle8 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle9 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle10 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle11 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle12 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle13 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle14 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle15 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle16 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle17 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle18 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle19 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle20 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle21 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle22 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.pnlBorder = New Global.System.Windows.Forms.Panel()
			Me.pnlMain = New Global.System.Windows.Forms.Panel()
			Me.theme_tc = New Global.System.Windows.Forms.TabControl()
			Me.tpDetails = New Global.System.Windows.Forms.TabPage()
			Me.txtBOMVersion = New Global.System.Windows.Forms.TextBox()
			Me.skip_lblStatus = New Global.System.Windows.Forms.Label()
			Me.Label11 = New Global.System.Windows.Forms.Label()
			Me.txtPickingByID = New Global.System.Windows.Forms.TextBox()
			Me.txtPickingBy = New Global.System.Windows.Forms.TextBox()
			Me.txtProductID = New Global.System.Windows.Forms.TextBox()
			Me.txtRequestedByID = New Global.System.Windows.Forms.TextBox()
			Me.txtRequestNo = New Global.System.Windows.Forms.TextBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.dtpRequestDt = New Global.System.Windows.Forms.DateTimePicker()
			Me.txtRequestID = New Global.System.Windows.Forms.TextBox()
			Me.txtID = New Global.System.Windows.Forms.TextBox()
			Me.txtProduct = New Global.System.Windows.Forms.TextBox()
			Me.txtRequestedBy = New Global.System.Windows.Forms.TextBox()
			Me.txtNo = New Global.System.Windows.Forms.TextBox()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.dtpMfgDt = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.dtpDt = New Global.System.Windows.Forms.DateTimePicker()
			Me.dtpExpDt = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.txtBatchNo = New Global.System.Windows.Forms.TextBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.tab_lbl1 = New Global.System.Windows.Forms.Label()
			Me.tpItem = New Global.System.Windows.Forms.TabPage()
			Me.tab_lbl2 = New Global.System.Windows.Forms.Label()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.dgvDtls = New Global.System.Windows.Forms.DataGridView()
			Me.ProductID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.SrNo = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ProductType = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.CatalogNo = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ProductName = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Description = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.TertiaryUOM = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.TertiaryPackSize = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.PrimaryUOM = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.PrimaryPackSize = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ReqQty = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.IssuedQty = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.PickedQty = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.tpPicklist = New Global.System.Windows.Forms.TabPage()
			Me.cmbProduct = New Global.System.Windows.Forms.ComboBox()
			Me.Label12 = New Global.System.Windows.Forms.Label()
			Me.lblRowsList = New Global.System.Windows.Forms.Label()
			Me.dgvPicklist = New Global.System.Windows.Forms.DataGridView()
			Me.tab_lbl3 = New Global.System.Windows.Forms.Label()
			Me.tpBarcodes = New Global.System.Windows.Forms.TabPage()
			Me.flpButton = New Global.System.Windows.Forms.FlowLayoutPanel()
			Me.btnSave = New Global.System.Windows.Forms.Button()
			Me.btnApprove = New Global.System.Windows.Forms.Button()
			Me.btnOnHold = New Global.System.Windows.Forms.Button()
			Me.btnReject = New Global.System.Windows.Forms.Button()
			Me.btnClear = New Global.System.Windows.Forms.Button()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.btnCancel = New Global.System.Windows.Forms.Button()
			Me.sml_btnAdd = New Global.System.Windows.Forms.Button()
			Me.lblRows = New Global.System.Windows.Forms.Label()
			Me.dgvUID = New Global.System.Windows.Forms.DataGridView()
			Me.btnDelete_Item = New Global.System.Windows.Forms.DataGridViewImageColumn()
			Me.uUID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.uParentUID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.uCatalogNo = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.uProductName = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.uDescription = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.uBatchNo = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.uMfgDt = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.uExpDt = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.uReceiptDt = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.uProductID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.uExpiryType = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.txtBarcode = New Global.System.Windows.Forms.TextBox()
			Me.tab_lbl4 = New Global.System.Windows.Forms.Label()
			Me.tpRemarks = New Global.System.Windows.Forms.TabPage()
			Me.tab_lbl5 = New Global.System.Windows.Forms.Label()
			Me.lblRemarksApproval1 = New Global.System.Windows.Forms.Label()
			Me.lblRemarks1 = New Global.System.Windows.Forms.Label()
			Me.Panel4 = New Global.System.Windows.Forms.Panel()
			Me.txtRemarksApproval = New Global.System.Windows.Forms.TextBox()
			Me.txtRemarks = New Global.System.Windows.Forms.TextBox()
			Me.lblRemarks = New Global.System.Windows.Forms.Label()
			Me.lblRemarksApproval = New Global.System.Windows.Forms.Label()
			Me.panelTitleBar = New Global.System.Windows.Forms.Panel()
			Me.picFormIcon = New Global.System.Windows.Forms.PictureBox()
			Me.lblCaption = New Global.System.Windows.Forms.Label()
			Me.form_btnClose = New Global.System.Windows.Forms.Button()
			Me.lblShadow1 = New Global.System.Windows.Forms.Label()
			Me.lblShadow2 = New Global.System.Windows.Forms.Label()
			Me.pUOM = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.pPrimaryPackSize = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.FinalConcentration = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Titre = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.CellCount = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ODPermL = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.pUID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.pParentUID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.pLocation = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.pLocationName = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.pCatalogNo = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.pProductName = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.pDescription = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.pBatchNo = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.pMfgDt = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.pExpDt = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.pReceiptDt = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.pExpiryType = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.pProductID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.pnlBorder.SuspendLayout()
			Me.pnlMain.SuspendLayout()
			Me.theme_tc.SuspendLayout()
			Me.tpDetails.SuspendLayout()
			Me.tpItem.SuspendLayout()
			Me.Panel1.SuspendLayout()
			CType(Me.dgvDtls, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tpPicklist.SuspendLayout()
			CType(Me.dgvPicklist, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tpBarcodes.SuspendLayout()
			Me.flpButton.SuspendLayout()
			CType(Me.dgvUID, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tpRemarks.SuspendLayout()
			Me.Panel4.SuspendLayout()
			Me.panelTitleBar.SuspendLayout()
			CType(Me.picFormIcon, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.pnlBorder.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.pnlBorder.BackColor = Global.System.Drawing.Color.SteelBlue
			Me.pnlBorder.Controls.Add(Me.pnlMain)
			Me.pnlBorder.Location = New Global.System.Drawing.Point(0, 0)
			Me.pnlBorder.Name = "pnlBorder"
			Me.pnlBorder.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.pnlBorder.Size = New Global.System.Drawing.Size(884, 540)
			Me.pnlBorder.TabIndex = 4
			Me.pnlMain.BackColor = Global.System.Drawing.Color.White
			Me.pnlMain.Controls.Add(Me.theme_tc)
			Me.pnlMain.Controls.Add(Me.panelTitleBar)
			Me.pnlMain.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.pnlMain.Location = New Global.System.Drawing.Point(3, 3)
			Me.pnlMain.Name = "pnlMain"
			Me.pnlMain.Size = New Global.System.Drawing.Size(878, 534)
			Me.pnlMain.TabIndex = 1
			Me.theme_tc.Controls.Add(Me.tpDetails)
			Me.theme_tc.Controls.Add(Me.tpItem)
			Me.theme_tc.Controls.Add(Me.tpPicklist)
			Me.theme_tc.Controls.Add(Me.tpBarcodes)
			Me.theme_tc.Controls.Add(Me.tpRemarks)
			Me.theme_tc.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.theme_tc.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.theme_tc.ItemSize = New Global.System.Drawing.Size(143, 30)
			Me.theme_tc.Location = New Global.System.Drawing.Point(0, 27)
			Me.theme_tc.Name = "theme_tc"
			Me.theme_tc.SelectedIndex = 0
			Me.theme_tc.Size = New Global.System.Drawing.Size(878, 507)
			Me.theme_tc.SizeMode = Global.System.Windows.Forms.TabSizeMode.Fixed
			Me.theme_tc.TabIndex = 1041
			Me.tpDetails.Controls.Add(Me.txtBOMVersion)
			Me.tpDetails.Controls.Add(Me.skip_lblStatus)
			Me.tpDetails.Controls.Add(Me.Label11)
			Me.tpDetails.Controls.Add(Me.txtPickingByID)
			Me.tpDetails.Controls.Add(Me.txtPickingBy)
			Me.tpDetails.Controls.Add(Me.txtProductID)
			Me.tpDetails.Controls.Add(Me.txtRequestedByID)
			Me.tpDetails.Controls.Add(Me.txtRequestNo)
			Me.tpDetails.Controls.Add(Me.Label5)
			Me.tpDetails.Controls.Add(Me.Label10)
			Me.tpDetails.Controls.Add(Me.dtpRequestDt)
			Me.tpDetails.Controls.Add(Me.txtRequestID)
			Me.tpDetails.Controls.Add(Me.txtID)
			Me.tpDetails.Controls.Add(Me.txtProduct)
			Me.tpDetails.Controls.Add(Me.txtRequestedBy)
			Me.tpDetails.Controls.Add(Me.txtNo)
			Me.tpDetails.Controls.Add(Me.Label7)
			Me.tpDetails.Controls.Add(Me.Label2)
			Me.tpDetails.Controls.Add(Me.dtpMfgDt)
			Me.tpDetails.Controls.Add(Me.Label1)
			Me.tpDetails.Controls.Add(Me.Label8)
			Me.tpDetails.Controls.Add(Me.dtpDt)
			Me.tpDetails.Controls.Add(Me.dtpExpDt)
			Me.tpDetails.Controls.Add(Me.Label9)
			Me.tpDetails.Controls.Add(Me.Label6)
			Me.tpDetails.Controls.Add(Me.txtBatchNo)
			Me.tpDetails.Controls.Add(Me.Label3)
			Me.tpDetails.Controls.Add(Me.tab_lbl1)
			Me.tpDetails.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.tpDetails.Location = New Global.System.Drawing.Point(4, 34)
			Me.tpDetails.Name = "tpDetails"
			Me.tpDetails.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tpDetails.Size = New Global.System.Drawing.Size(870, 469)
			Me.tpDetails.TabIndex = 0
			Me.tpDetails.Text = "Details"
			Me.tpDetails.UseVisualStyleBackColor = True
			Me.txtBOMVersion.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtBOMVersion.Location = New Global.System.Drawing.Point(103, 211)
			Me.txtBOMVersion.Name = "txtBOMVersion"
			Me.txtBOMVersion.Size = New Global.System.Drawing.Size(14, 21)
			Me.txtBOMVersion.TabIndex = 1141
			Me.txtBOMVersion.TabStop = False
			Me.txtBOMVersion.Visible = False
			Me.skip_lblStatus.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.skip_lblStatus.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.skip_lblStatus.ForeColor = Global.System.Drawing.Color.LawnGreen
			Me.skip_lblStatus.Location = New Global.System.Drawing.Point(275, 8)
			Me.skip_lblStatus.Name = "skip_lblStatus"
			Me.skip_lblStatus.Size = New Global.System.Drawing.Size(320, 22)
			Me.skip_lblStatus.TabIndex = 1140
			Me.skip_lblStatus.Text = "New Picking"
			Me.skip_lblStatus.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label11.AutoSize = True
			Me.Label11.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label11.Location = New Global.System.Drawing.Point(16, 424)
			Me.Label11.Name = "Label11"
			Me.Label11.Size = New Global.System.Drawing.Size(66, 15)
			Me.Label11.TabIndex = 1139
			Me.Label11.Text = "Picking By"
			Me.txtPickingByID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPickingByID.Location = New Global.System.Drawing.Point(120, 421)
			Me.txtPickingByID.Name = "txtPickingByID"
			Me.txtPickingByID.Size = New Global.System.Drawing.Size(14, 21)
			Me.txtPickingByID.TabIndex = 1138
			Me.txtPickingByID.TabStop = False
			Me.txtPickingByID.Visible = False
			Me.txtPickingBy.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtPickingBy.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPickingBy.Location = New Global.System.Drawing.Point(136, 421)
			Me.txtPickingBy.Name = "txtPickingBy"
			Me.txtPickingBy.[ReadOnly] = True
			Me.txtPickingBy.Size = New Global.System.Drawing.Size(710, 21)
			Me.txtPickingBy.TabIndex = 1137
			Me.txtProductID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtProductID.Location = New Global.System.Drawing.Point(120, 211)
			Me.txtProductID.Name = "txtProductID"
			Me.txtProductID.Size = New Global.System.Drawing.Size(14, 21)
			Me.txtProductID.TabIndex = 1136
			Me.txtProductID.TabStop = False
			Me.txtProductID.Visible = False
			Me.txtRequestedByID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtRequestedByID.Location = New Global.System.Drawing.Point(120, 379)
			Me.txtRequestedByID.Name = "txtRequestedByID"
			Me.txtRequestedByID.Size = New Global.System.Drawing.Size(14, 21)
			Me.txtRequestedByID.TabIndex = 1135
			Me.txtRequestedByID.TabStop = False
			Me.txtRequestedByID.Visible = False
			Me.txtRequestNo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtRequestNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtRequestNo.Location = New Global.System.Drawing.Point(136, 127)
			Me.txtRequestNo.Name = "txtRequestNo"
			Me.txtRequestNo.[ReadOnly] = True
			Me.txtRequestNo.Size = New Global.System.Drawing.Size(710, 21)
			Me.txtRequestNo.TabIndex = 1133
			Me.Label5.AutoSize = True
			Me.Label5.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label5.Location = New Global.System.Drawing.Point(16, 130)
			Me.Label5.Name = "Label5"
			Me.Label5.Size = New Global.System.Drawing.Size(76, 15)
			Me.Label5.TabIndex = 1134
			Me.Label5.Text = "Request No."
			Me.Label10.AutoSize = True
			Me.Label10.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label10.Location = New Global.System.Drawing.Point(16, 172)
			Me.Label10.Name = "Label10"
			Me.Label10.Size = New Global.System.Drawing.Size(84, 15)
			Me.Label10.TabIndex = 1132
			Me.Label10.Text = "Request Date"
			Me.Label10.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.dtpRequestDt.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.dtpRequestDt.Checked = False
			Me.dtpRequestDt.CustomFormat = "dd   MMM   yyyy"
			Me.dtpRequestDt.Enabled = False
			Me.dtpRequestDt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpRequestDt.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpRequestDt.Location = New Global.System.Drawing.Point(136, 169)
			Me.dtpRequestDt.Name = "dtpRequestDt"
			Me.dtpRequestDt.Size = New Global.System.Drawing.Size(710, 21)
			Me.dtpRequestDt.TabIndex = 1131
			Me.txtRequestID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtRequestID.Location = New Global.System.Drawing.Point(120, 127)
			Me.txtRequestID.Name = "txtRequestID"
			Me.txtRequestID.Size = New Global.System.Drawing.Size(14, 21)
			Me.txtRequestID.TabIndex = 1130
			Me.txtRequestID.TabStop = False
			Me.txtRequestID.Visible = False
			Me.txtID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtID.Location = New Global.System.Drawing.Point(120, 43)
			Me.txtID.Name = "txtID"
			Me.txtID.Size = New Global.System.Drawing.Size(14, 21)
			Me.txtID.TabIndex = 1129
			Me.txtID.TabStop = False
			Me.txtID.Visible = False
			Me.txtProduct.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtProduct.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtProduct.Location = New Global.System.Drawing.Point(136, 211)
			Me.txtProduct.Name = "txtProduct"
			Me.txtProduct.[ReadOnly] = True
			Me.txtProduct.Size = New Global.System.Drawing.Size(710, 21)
			Me.txtProduct.TabIndex = 1128
			Me.txtRequestedBy.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtRequestedBy.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtRequestedBy.Location = New Global.System.Drawing.Point(136, 379)
			Me.txtRequestedBy.Name = "txtRequestedBy"
			Me.txtRequestedBy.[ReadOnly] = True
			Me.txtRequestedBy.Size = New Global.System.Drawing.Size(710, 21)
			Me.txtRequestedBy.TabIndex = 1127
			Me.txtNo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtNo.Location = New Global.System.Drawing.Point(136, 43)
			Me.txtNo.Name = "txtNo"
			Me.txtNo.[ReadOnly] = True
			Me.txtNo.Size = New Global.System.Drawing.Size(710, 21)
			Me.txtNo.TabIndex = 1115
			Me.Label7.AutoSize = True
			Me.Label7.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label7.Location = New Global.System.Drawing.Point(16, 340)
			Me.Label7.Name = "Label7"
			Me.Label7.Size = New Global.System.Drawing.Size(74, 15)
			Me.Label7.TabIndex = 1126
			Me.Label7.Text = "Expiry Date"
			Me.Label7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.Location = New Global.System.Drawing.Point(16, 46)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(70, 15)
			Me.Label2.TabIndex = 1116
			Me.Label2.Text = "Picking No."
			Me.dtpMfgDt.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.dtpMfgDt.CustomFormat = "dd   MMM   yyyy"
			Me.dtpMfgDt.Enabled = False
			Me.dtpMfgDt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpMfgDt.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpMfgDt.Location = New Global.System.Drawing.Point(136, 295)
			Me.dtpMfgDt.Name = "dtpMfgDt"
			Me.dtpMfgDt.Size = New Global.System.Drawing.Size(710, 21)
			Me.dtpMfgDt.TabIndex = 1125
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.Location = New Global.System.Drawing.Point(16, 88)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(78, 15)
			Me.Label1.TabIndex = 1114
			Me.Label1.Text = "Picking Date"
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label8.AutoSize = True
			Me.Label8.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label8.Location = New Global.System.Drawing.Point(16, 298)
			Me.Label8.Name = "Label8"
			Me.Label8.Size = New Global.System.Drawing.Size(118, 15)
			Me.Label8.TabIndex = 1124
			Me.Label8.Text = "Manufacturing Date"
			Me.Label8.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.dtpDt.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.dtpDt.Checked = False
			Me.dtpDt.CustomFormat = "dd   MMM   yyyy"
			Me.dtpDt.Enabled = False
			Me.dtpDt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpDt.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpDt.Location = New Global.System.Drawing.Point(136, 85)
			Me.dtpDt.Name = "dtpDt"
			Me.dtpDt.Size = New Global.System.Drawing.Size(710, 21)
			Me.dtpDt.TabIndex = 1113
			Me.dtpExpDt.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.dtpExpDt.CustomFormat = "dd   MMM   yyyy"
			Me.dtpExpDt.Enabled = False
			Me.dtpExpDt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpExpDt.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpExpDt.Location = New Global.System.Drawing.Point(136, 337)
			Me.dtpExpDt.Name = "dtpExpDt"
			Me.dtpExpDt.Size = New Global.System.Drawing.Size(710, 21)
			Me.dtpExpDt.TabIndex = 1123
			Me.Label9.AutoSize = True
			Me.Label9.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label9.Location = New Global.System.Drawing.Point(16, 382)
			Me.Label9.Name = "Label9"
			Me.Label9.Size = New Global.System.Drawing.Size(86, 15)
			Me.Label9.TabIndex = 1117
			Me.Label9.Text = "Requested By"
			Me.Label6.AutoSize = True
			Me.Label6.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label6.Location = New Global.System.Drawing.Point(16, 256)
			Me.Label6.Name = "Label6"
			Me.Label6.Size = New Global.System.Drawing.Size(88, 15)
			Me.Label6.TabIndex = 1122
			Me.Label6.Text = "Batch/ Lot No."
			Me.txtBatchNo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtBatchNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtBatchNo.Location = New Global.System.Drawing.Point(136, 253)
			Me.txtBatchNo.Name = "txtBatchNo"
			Me.txtBatchNo.[ReadOnly] = True
			Me.txtBatchNo.Size = New Global.System.Drawing.Size(710, 21)
			Me.txtBatchNo.TabIndex = 1121
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.Location = New Global.System.Drawing.Point(16, 214)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(50, 15)
			Me.Label3.TabIndex = 1119
			Me.Label3.Text = "Product"
			Me.tab_lbl1.BackColor = Global.System.Drawing.Color.Black
			Me.tab_lbl1.ForeColor = Global.System.Drawing.Color.PaleGreen
			Me.tab_lbl1.Location = New Global.System.Drawing.Point(-2, 0)
			Me.tab_lbl1.Name = "tab_lbl1"
			Me.tab_lbl1.Size = New Global.System.Drawing.Size(864, 3)
			Me.tab_lbl1.TabIndex = 6
			Me.tpItem.Controls.Add(Me.tab_lbl2)
			Me.tpItem.Controls.Add(Me.Panel1)
			Me.tpItem.Location = New Global.System.Drawing.Point(4, 34)
			Me.tpItem.Name = "tpItem"
			Me.tpItem.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tpItem.Size = New Global.System.Drawing.Size(870, 469)
			Me.tpItem.TabIndex = 3
			Me.tpItem.Text = "Item Details"
			Me.tpItem.UseVisualStyleBackColor = True
			Me.tab_lbl2.BackColor = Global.System.Drawing.Color.Black
			Me.tab_lbl2.ForeColor = Global.System.Drawing.Color.PaleGreen
			Me.tab_lbl2.Location = New Global.System.Drawing.Point(0, 0)
			Me.tab_lbl2.Name = "tab_lbl2"
			Me.tab_lbl2.Size = New Global.System.Drawing.Size(864, 3)
			Me.tab_lbl2.TabIndex = 1103
			Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Panel1.Controls.Add(Me.dgvDtls)
			Me.Panel1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Panel1.Location = New Global.System.Drawing.Point(5, 6)
			Me.Panel1.Name = "Panel1"
			Me.Panel1.Size = New Global.System.Drawing.Size(861, 460)
			Me.Panel1.TabIndex = 1102
			Me.dgvDtls.AllowUserToAddRows = False
			Me.dgvDtls.AllowUserToDeleteRows = False
			Me.dgvDtls.AllowUserToResizeRows = False
			Me.dgvDtls.AutoSizeRowsMode = Global.System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
			Me.dgvDtls.BackgroundColor = Global.System.Drawing.Color.WhiteSmoke
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.GradientInactiveCaption
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvDtls.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.dgvDtls.ColumnHeadersHeight = 37
			Me.dgvDtls.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.dgvDtls.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.ProductID, Me.SrNo, Me.ProductType, Me.CatalogNo, Me.ProductName, Me.Description, Me.TertiaryUOM, Me.TertiaryPackSize, Me.PrimaryUOM, Me.PrimaryPackSize, Me.ReqQty, Me.IssuedQty, Me.PickedQty })
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.SystemColors.Window
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.SystemColors.ControlText
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[False]
			Me.dgvDtls.DefaultCellStyle = dataGridViewCellStyle2
			Me.dgvDtls.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.dgvDtls.Location = New Global.System.Drawing.Point(0, 0)
			Me.dgvDtls.Name = "dgvDtls"
			Me.dgvDtls.[ReadOnly] = True
			dataGridViewCellStyle3.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle3.BackColor = Global.System.Drawing.SystemColors.Control
			dataGridViewCellStyle3.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle3.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle3.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle3.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle3.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvDtls.RowHeadersDefaultCellStyle = dataGridViewCellStyle3
			Me.dgvDtls.RowHeadersWidth = 30
			dataGridViewCellStyle4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dgvDtls.RowsDefaultCellStyle = dataGridViewCellStyle4
			Me.dgvDtls.Size = New Global.System.Drawing.Size(861, 460)
			Me.dgvDtls.TabIndex = 1101
			Me.ProductID.DataPropertyName = "ProductID"
			Me.ProductID.HeaderText = "ProductID"
			Me.ProductID.Name = "ProductID"
			Me.ProductID.[ReadOnly] = True
			Me.ProductID.Visible = False
			Me.SrNo.DataPropertyName = "SrNo"
			dataGridViewCellStyle5.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.SrNo.DefaultCellStyle = dataGridViewCellStyle5
			Me.SrNo.HeaderText = "Sr. No."
			Me.SrNo.Name = "SrNo"
			Me.SrNo.[ReadOnly] = True
			Me.SrNo.Width = 55
			Me.ProductType.DataPropertyName = "ProductType"
			Me.ProductType.HeaderText = "Product Type"
			Me.ProductType.Name = "ProductType"
			Me.ProductType.[ReadOnly] = True
			Me.ProductType.Width = 120
			Me.CatalogNo.DataPropertyName = "CatalogNo"
			Me.CatalogNo.HeaderText = "CatalogNo"
			Me.CatalogNo.Name = "CatalogNo"
			Me.CatalogNo.[ReadOnly] = True
			Me.CatalogNo.Width = 120
			Me.ProductName.DataPropertyName = "ProductName"
			Me.ProductName.HeaderText = "Product"
			Me.ProductName.Name = "ProductName"
			Me.ProductName.[ReadOnly] = True
			Me.ProductName.Width = 250
			Me.Description.DataPropertyName = "Description"
			dataGridViewCellStyle6.Padding = New Global.System.Windows.Forms.Padding(0, 2, 0, 2)
			dataGridViewCellStyle6.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.Description.DefaultCellStyle = dataGridViewCellStyle6
			Me.Description.HeaderText = "Description"
			Me.Description.Name = "Description"
			Me.Description.[ReadOnly] = True
			Me.Description.Width = 300
			Me.TertiaryUOM.DataPropertyName = "TertiaryUOM"
			Me.TertiaryUOM.HeaderText = "Tertiary UOM"
			Me.TertiaryUOM.Name = "TertiaryUOM"
			Me.TertiaryUOM.[ReadOnly] = True
			Me.TertiaryUOM.Width = 60
			Me.TertiaryPackSize.DataPropertyName = "TertiaryPackSize"
			dataGridViewCellStyle7.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.TertiaryPackSize.DefaultCellStyle = dataGridViewCellStyle7
			Me.TertiaryPackSize.HeaderText = "Tertiary PackSize"
			Me.TertiaryPackSize.Name = "TertiaryPackSize"
			Me.TertiaryPackSize.[ReadOnly] = True
			Me.TertiaryPackSize.Width = 70
			Me.PrimaryUOM.DataPropertyName = "PrimaryUOM"
			Me.PrimaryUOM.HeaderText = "Primary UOM"
			Me.PrimaryUOM.Name = "PrimaryUOM"
			Me.PrimaryUOM.[ReadOnly] = True
			Me.PrimaryUOM.Width = 60
			Me.PrimaryPackSize.DataPropertyName = "PrimaryPackSize"
			dataGridViewCellStyle8.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.PrimaryPackSize.DefaultCellStyle = dataGridViewCellStyle8
			Me.PrimaryPackSize.HeaderText = "Primary PackSize"
			Me.PrimaryPackSize.Name = "PrimaryPackSize"
			Me.PrimaryPackSize.[ReadOnly] = True
			Me.PrimaryPackSize.Width = 70
			Me.ReqQty.DataPropertyName = "RequiredQty"
			dataGridViewCellStyle9.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.ReqQty.DefaultCellStyle = dataGridViewCellStyle9
			Me.ReqQty.HeaderText = "Required Qty. Primary"
			Me.ReqQty.Name = "ReqQty"
			Me.ReqQty.[ReadOnly] = True
			Me.ReqQty.Width = 110
			Me.IssuedQty.DataPropertyName = "IssuedQty"
			dataGridViewCellStyle10.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.IssuedQty.DefaultCellStyle = dataGridViewCellStyle10
			Me.IssuedQty.HeaderText = "Issued Qty. Primary"
			Me.IssuedQty.Name = "IssuedQty"
			Me.IssuedQty.[ReadOnly] = True
			Me.IssuedQty.Width = 110
			Me.PickedQty.DataPropertyName = "PickedQty"
			dataGridViewCellStyle11.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.PickedQty.DefaultCellStyle = dataGridViewCellStyle11
			Me.PickedQty.HeaderText = "Picked Qty. Primary"
			Me.PickedQty.Name = "PickedQty"
			Me.PickedQty.[ReadOnly] = True
			Me.tpPicklist.Controls.Add(Me.cmbProduct)
			Me.tpPicklist.Controls.Add(Me.Label12)
			Me.tpPicklist.Controls.Add(Me.lblRowsList)
			Me.tpPicklist.Controls.Add(Me.dgvPicklist)
			Me.tpPicklist.Controls.Add(Me.tab_lbl3)
			Me.tpPicklist.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.tpPicklist.Location = New Global.System.Drawing.Point(4, 34)
			Me.tpPicklist.Name = "tpPicklist"
			Me.tpPicklist.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tpPicklist.Size = New Global.System.Drawing.Size(870, 469)
			Me.tpPicklist.TabIndex = 1
			Me.tpPicklist.Text = "Pick List"
			Me.tpPicklist.UseVisualStyleBackColor = True
			Me.cmbProduct.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.cmbProduct.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbProduct.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbProduct.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbProduct.FormattingEnabled = True
			Me.cmbProduct.Location = New Global.System.Drawing.Point(78, 11)
			Me.cmbProduct.Name = "cmbProduct"
			Me.cmbProduct.Size = New Global.System.Drawing.Size(503, 23)
			Me.cmbProduct.TabIndex = 1193
			Me.Label12.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label12.AutoSize = True
			Me.Label12.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label12.Location = New Global.System.Drawing.Point(9, 14)
			Me.Label12.Name = "Label12"
			Me.Label12.Size = New Global.System.Drawing.Size(50, 15)
			Me.Label12.TabIndex = 1194
			Me.Label12.Text = "Product"
			Me.lblRowsList.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblRowsList.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRowsList.Location = New Global.System.Drawing.Point(676, 14)
			Me.lblRowsList.Name = "lblRowsList"
			Me.lblRowsList.Size = New Global.System.Drawing.Size(188, 15)
			Me.lblRowsList.TabIndex = 1132
			Me.lblRowsList.Text = "0 - Rows"
			Me.lblRowsList.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.dgvPicklist.AllowUserToAddRows = False
			Me.dgvPicklist.AllowUserToDeleteRows = False
			Me.dgvPicklist.AllowUserToResizeRows = False
			Me.dgvPicklist.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.dgvPicklist.BackgroundColor = Global.System.Drawing.Color.WhiteSmoke
			dataGridViewCellStyle12.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle12.BackColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle12.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle12.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle12.SelectionBackColor = Global.System.Drawing.SystemColors.GradientInactiveCaption
			dataGridViewCellStyle12.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle12.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvPicklist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12
			Me.dgvPicklist.ColumnHeadersHeight = 37
			Me.dgvPicklist.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.dgvPicklist.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.pUOM, Me.pPrimaryPackSize, Me.FinalConcentration, Me.Titre, Me.CellCount, Me.ODPermL, Me.pUID, Me.pParentUID, Me.pLocation, Me.pLocationName, Me.pCatalogNo, Me.pProductName, Me.pDescription, Me.pBatchNo, Me.pMfgDt, Me.pExpDt, Me.pReceiptDt, Me.pExpiryType, Me.pProductID })
			Me.dgvPicklist.Location = New Global.System.Drawing.Point(3, 41)
			Me.dgvPicklist.Name = "dgvPicklist"
			Me.dgvPicklist.[ReadOnly] = True
			Me.dgvPicklist.RowHeadersWidth = 30
			dataGridViewCellStyle13.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dgvPicklist.RowsDefaultCellStyle = dataGridViewCellStyle13
			Me.dgvPicklist.Size = New Global.System.Drawing.Size(863, 425)
			Me.dgvPicklist.TabIndex = 1041
			Me.tab_lbl3.BackColor = Global.System.Drawing.Color.Black
			Me.tab_lbl3.ForeColor = Global.System.Drawing.Color.PaleGreen
			Me.tab_lbl3.Location = New Global.System.Drawing.Point(3, 0)
			Me.tab_lbl3.Name = "tab_lbl3"
			Me.tab_lbl3.Size = New Global.System.Drawing.Size(864, 3)
			Me.tab_lbl3.TabIndex = 8
			Me.tpBarcodes.Controls.Add(Me.flpButton)
			Me.tpBarcodes.Controls.Add(Me.sml_btnAdd)
			Me.tpBarcodes.Controls.Add(Me.lblRows)
			Me.tpBarcodes.Controls.Add(Me.dgvUID)
			Me.tpBarcodes.Controls.Add(Me.Label4)
			Me.tpBarcodes.Controls.Add(Me.txtBarcode)
			Me.tpBarcodes.Controls.Add(Me.tab_lbl4)
			Me.tpBarcodes.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.tpBarcodes.Location = New Global.System.Drawing.Point(4, 34)
			Me.tpBarcodes.Name = "tpBarcodes"
			Me.tpBarcodes.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tpBarcodes.Size = New Global.System.Drawing.Size(870, 469)
			Me.tpBarcodes.TabIndex = 2
			Me.tpBarcodes.Text = "Picking"
			Me.tpBarcodes.UseVisualStyleBackColor = True
			Me.flpButton.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.flpButton.Controls.Add(Me.btnSave)
			Me.flpButton.Controls.Add(Me.btnApprove)
			Me.flpButton.Controls.Add(Me.btnOnHold)
			Me.flpButton.Controls.Add(Me.btnReject)
			Me.flpButton.Controls.Add(Me.btnClear)
			Me.flpButton.Controls.Add(Me.btnClose)
			Me.flpButton.Controls.Add(Me.btnCancel)
			Me.flpButton.Location = New Global.System.Drawing.Point(40, 439)
			Me.flpButton.Name = "flpButton"
			Me.flpButton.Size = New Global.System.Drawing.Size(791, 27)
			Me.flpButton.TabIndex = 1135
			Me.btnSave.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnSave.Location = New Global.System.Drawing.Point(2, 0)
			Me.btnSave.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New Global.System.Drawing.Size(111, 26)
			Me.btnSave.TabIndex = 0
			Me.btnSave.Text = "&Save"
			Me.btnSave.UseVisualStyleBackColor = True
			Me.btnApprove.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnApprove.Location = New Global.System.Drawing.Point(115, 0)
			Me.btnApprove.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnApprove.Name = "btnApprove"
			Me.btnApprove.Size = New Global.System.Drawing.Size(111, 26)
			Me.btnApprove.TabIndex = 1
			Me.btnApprove.Text = "Approve"
			Me.btnApprove.UseVisualStyleBackColor = True
			Me.btnOnHold.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnOnHold.Location = New Global.System.Drawing.Point(228, 0)
			Me.btnOnHold.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnOnHold.Name = "btnOnHold"
			Me.btnOnHold.Size = New Global.System.Drawing.Size(111, 26)
			Me.btnOnHold.TabIndex = 6
			Me.btnOnHold.Text = "On-Hold"
			Me.btnOnHold.UseVisualStyleBackColor = True
			Me.btnReject.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnReject.Location = New Global.System.Drawing.Point(341, 0)
			Me.btnReject.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnReject.Name = "btnReject"
			Me.btnReject.Size = New Global.System.Drawing.Size(111, 26)
			Me.btnReject.TabIndex = 2
			Me.btnReject.Text = "Reject"
			Me.btnReject.UseVisualStyleBackColor = True
			Me.btnClear.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClear.Location = New Global.System.Drawing.Point(454, 0)
			Me.btnClear.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnClear.Name = "btnClear"
			Me.btnClear.Size = New Global.System.Drawing.Size(111, 26)
			Me.btnClear.TabIndex = 3
			Me.btnClear.Text = "&Clear"
			Me.btnClear.UseVisualStyleBackColor = True
			Me.btnClose.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClose.Location = New Global.System.Drawing.Point(567, 0)
			Me.btnClose.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnClose.Name = "btnClose"
			Me.btnClose.Size = New Global.System.Drawing.Size(111, 26)
			Me.btnClose.TabIndex = 4
			Me.btnClose.Text = "C&lose"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.btnCancel.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnCancel.Location = New Global.System.Drawing.Point(680, 0)
			Me.btnCancel.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New Global.System.Drawing.Size(111, 26)
			Me.btnCancel.TabIndex = 5
			Me.btnCancel.Text = "Ca&ncel"
			Me.btnCancel.UseVisualStyleBackColor = True
			Me.sml_btnAdd.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.sml_btnAdd.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.sml_btnAdd.Location = New Global.System.Drawing.Point(680, 12)
			Me.sml_btnAdd.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.sml_btnAdd.Name = "sml_btnAdd"
			Me.sml_btnAdd.Size = New Global.System.Drawing.Size(84, 23)
			Me.sml_btnAdd.TabIndex = 1132
			Me.sml_btnAdd.Text = "Add"
			Me.sml_btnAdd.UseVisualStyleBackColor = True
			Me.lblRows.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblRows.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRows.Location = New Global.System.Drawing.Point(767, 16)
			Me.lblRows.Name = "lblRows"
			Me.lblRows.Size = New Global.System.Drawing.Size(93, 15)
			Me.lblRows.TabIndex = 1131
			Me.lblRows.Text = "0 - Rows"
			Me.lblRows.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.dgvUID.AllowUserToAddRows = False
			Me.dgvUID.AllowUserToDeleteRows = False
			Me.dgvUID.AllowUserToResizeRows = False
			Me.dgvUID.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.dgvUID.BackgroundColor = Global.System.Drawing.Color.WhiteSmoke
			dataGridViewCellStyle14.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle14.BackColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle14.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle14.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle14.SelectionBackColor = Global.System.Drawing.SystemColors.GradientInactiveCaption
			dataGridViewCellStyle14.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle14.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvUID.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14
			Me.dgvUID.ColumnHeadersHeight = 25
			Me.dgvUID.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.dgvUID.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.btnDelete_Item, Me.uUID, Me.uParentUID, Me.uCatalogNo, Me.uProductName, Me.uDescription, Me.uBatchNo, Me.uMfgDt, Me.uExpDt, Me.uReceiptDt, Me.uProductID, Me.uExpiryType })
			Me.dgvUID.Location = New Global.System.Drawing.Point(4, 40)
			Me.dgvUID.Name = "dgvUID"
			Me.dgvUID.[ReadOnly] = True
			Me.dgvUID.RowHeadersVisible = False
			Me.dgvUID.RowHeadersWidth = 30
			dataGridViewCellStyle15.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dgvUID.RowsDefaultCellStyle = dataGridViewCellStyle15
			Me.dgvUID.Size = New Global.System.Drawing.Size(862, 393)
			Me.dgvUID.TabIndex = 1127
			Me.btnDelete_Item.HeaderText = ""
			Me.btnDelete_Item.ImageLayout = Global.System.Windows.Forms.DataGridViewImageCellLayout.Stretch
			Me.btnDelete_Item.Name = "btnDelete_Item"
			Me.btnDelete_Item.[ReadOnly] = True
			Me.btnDelete_Item.Width = 26
			Me.uUID.DataPropertyName = "UID"
			Me.uUID.HeaderText = "UID"
			Me.uUID.Name = "uUID"
			Me.uUID.[ReadOnly] = True
			Me.uUID.Width = 125
			Me.uParentUID.DataPropertyName = "ParentUID"
			Me.uParentUID.HeaderText = "Parent UID"
			Me.uParentUID.Name = "uParentUID"
			Me.uParentUID.[ReadOnly] = True
			Me.uParentUID.Width = 110
			Me.uCatalogNo.DataPropertyName = "CatalogNo"
			Me.uCatalogNo.HeaderText = "Catalog No."
			Me.uCatalogNo.Name = "uCatalogNo"
			Me.uCatalogNo.[ReadOnly] = True
			Me.uCatalogNo.Width = 130
			Me.uProductName.DataPropertyName = "ProductName"
			Me.uProductName.HeaderText = "Product"
			Me.uProductName.Name = "uProductName"
			Me.uProductName.[ReadOnly] = True
			Me.uProductName.Width = 250
			Me.uDescription.DataPropertyName = "Description"
			Me.uDescription.HeaderText = "Description"
			Me.uDescription.Name = "uDescription"
			Me.uDescription.[ReadOnly] = True
			Me.uDescription.Visible = False
			Me.uDescription.Width = 250
			Me.uBatchNo.DataPropertyName = "BatchNo"
			Me.uBatchNo.HeaderText = "Batch No."
			Me.uBatchNo.Name = "uBatchNo"
			Me.uBatchNo.[ReadOnly] = True
			Me.uMfgDt.DataPropertyName = "MfgDt"
			dataGridViewCellStyle16.Format = "dd - MMM - yyyy"
			Me.uMfgDt.DefaultCellStyle = dataGridViewCellStyle16
			Me.uMfgDt.HeaderText = "Mfg. Date"
			Me.uMfgDt.Name = "uMfgDt"
			Me.uMfgDt.[ReadOnly] = True
			Me.uExpDt.DataPropertyName = "ExpDt"
			dataGridViewCellStyle17.Format = "dd - MMM - yyyy"
			Me.uExpDt.DefaultCellStyle = dataGridViewCellStyle17
			Me.uExpDt.HeaderText = "Exp. Date"
			Me.uExpDt.Name = "uExpDt"
			Me.uExpDt.[ReadOnly] = True
			Me.uReceiptDt.DataPropertyName = "ReceiptDt"
			dataGridViewCellStyle18.Format = "dd - MMM - yyyy"
			Me.uReceiptDt.DefaultCellStyle = dataGridViewCellStyle18
			Me.uReceiptDt.HeaderText = "Receipt Date"
			Me.uReceiptDt.Name = "uReceiptDt"
			Me.uReceiptDt.[ReadOnly] = True
			Me.uProductID.DataPropertyName = "ProductID"
			Me.uProductID.HeaderText = "ProductID"
			Me.uProductID.Name = "uProductID"
			Me.uProductID.[ReadOnly] = True
			Me.uProductID.Visible = False
			Me.uExpiryType.DataPropertyName = "ExpiryType"
			Me.uExpiryType.HeaderText = "ExpiryType"
			Me.uExpiryType.Name = "uExpiryType"
			Me.uExpiryType.[ReadOnly] = True
			Me.uExpiryType.Visible = False
			Me.Label4.AutoSize = True
			Me.Label4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label4.Location = New Global.System.Drawing.Point(11, 16)
			Me.Label4.Name = "Label4"
			Me.Label4.Size = New Global.System.Drawing.Size(101, 15)
			Me.Label4.TabIndex = 1126
			Me.Label4.Text = "Product Barcode"
			Me.txtBarcode.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtBarcode.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Upper
			Me.txtBarcode.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtBarcode.Location = New Global.System.Drawing.Point(118, 13)
			Me.txtBarcode.Name = "txtBarcode"
			Me.txtBarcode.Size = New Global.System.Drawing.Size(560, 21)
			Me.txtBarcode.TabIndex = 1125
			Me.tab_lbl4.BackColor = Global.System.Drawing.Color.Black
			Me.tab_lbl4.ForeColor = Global.System.Drawing.Color.PaleGreen
			Me.tab_lbl4.Location = New Global.System.Drawing.Point(0, 0)
			Me.tab_lbl4.Name = "tab_lbl4"
			Me.tab_lbl4.Size = New Global.System.Drawing.Size(864, 3)
			Me.tab_lbl4.TabIndex = 9
			Me.tpRemarks.Controls.Add(Me.tab_lbl5)
			Me.tpRemarks.Controls.Add(Me.lblRemarksApproval1)
			Me.tpRemarks.Controls.Add(Me.lblRemarks1)
			Me.tpRemarks.Controls.Add(Me.Panel4)
			Me.tpRemarks.Controls.Add(Me.lblRemarks)
			Me.tpRemarks.Controls.Add(Me.lblRemarksApproval)
			Me.tpRemarks.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.tpRemarks.Location = New Global.System.Drawing.Point(4, 34)
			Me.tpRemarks.Name = "tpRemarks"
			Me.tpRemarks.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tpRemarks.Size = New Global.System.Drawing.Size(870, 469)
			Me.tpRemarks.TabIndex = 7
			Me.tpRemarks.Text = "Remarks"
			Me.tpRemarks.UseVisualStyleBackColor = True
			Me.tab_lbl5.BackColor = Global.System.Drawing.Color.Black
			Me.tab_lbl5.ForeColor = Global.System.Drawing.Color.PaleGreen
			Me.tab_lbl5.Location = New Global.System.Drawing.Point(0, 0)
			Me.tab_lbl5.Name = "tab_lbl5"
			Me.tab_lbl5.Size = New Global.System.Drawing.Size(864, 3)
			Me.tab_lbl5.TabIndex = 730
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
			Me.Panel4.Size = New Global.System.Drawing.Size(777, 450)
			Me.Panel4.TabIndex = 720
			Me.txtRemarksApproval.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtRemarksApproval.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtRemarksApproval.Location = New Global.System.Drawing.Point(10, 8)
			Me.txtRemarksApproval.Multiline = True
			Me.txtRemarksApproval.Name = "txtRemarksApproval"
			Me.txtRemarksApproval.[ReadOnly] = True
			Me.txtRemarksApproval.Size = New Global.System.Drawing.Size(756, 433)
			Me.txtRemarksApproval.TabIndex = 727
			Me.txtRemarks.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtRemarks.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtRemarks.Location = New Global.System.Drawing.Point(10, 8)
			Me.txtRemarks.Multiline = True
			Me.txtRemarks.Name = "txtRemarks"
			Me.txtRemarks.Size = New Global.System.Drawing.Size(756, 433)
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
			Me.panelTitleBar.BackColor = Global.System.Drawing.Color.FromArgb(204, 231, 255)
			Me.panelTitleBar.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.panelTitleBar.Controls.Add(Me.picFormIcon)
			Me.panelTitleBar.Controls.Add(Me.lblCaption)
			Me.panelTitleBar.Controls.Add(Me.form_btnClose)
			Me.panelTitleBar.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.panelTitleBar.Location = New Global.System.Drawing.Point(0, 0)
			Me.panelTitleBar.Name = "panelTitleBar"
			Me.panelTitleBar.Size = New Global.System.Drawing.Size(878, 27)
			Me.panelTitleBar.TabIndex = 10
			Me.picFormIcon.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.picFormIcon.Dock = Global.System.Windows.Forms.DockStyle.Left
			Me.picFormIcon.Location = New Global.System.Drawing.Point(0, 0)
			Me.picFormIcon.Name = "picFormIcon"
			Me.picFormIcon.Padding = New Global.System.Windows.Forms.Padding(2)
			Me.picFormIcon.Size = New Global.System.Drawing.Size(27, 27)
			Me.picFormIcon.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.picFormIcon.TabIndex = 721
			Me.picFormIcon.TabStop = False
			Me.lblCaption.AutoSize = True
			Me.lblCaption.Location = New Global.System.Drawing.Point(31, 6)
			Me.lblCaption.MaximumSize = New Global.System.Drawing.Size(500, 0)
			Me.lblCaption.Name = "lblCaption"
			Me.lblCaption.Size = New Global.System.Drawing.Size(51, 15)
			Me.lblCaption.TabIndex = 720
			Me.lblCaption.Text = "Caption"
			Me.lblCaption.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.form_btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.form_btnClose.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.form_btnClose.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(204, 231, 255)
			Me.form_btnClose.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.Transparent
			Me.form_btnClose.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.Transparent
			Me.form_btnClose.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.form_btnClose.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.form_btnClose.Location = New Global.System.Drawing.Point(852, 1)
			Me.form_btnClose.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.form_btnClose.Name = "form_btnClose"
			Me.form_btnClose.Size = New Global.System.Drawing.Size(24, 24)
			Me.form_btnClose.TabIndex = 719
			Me.form_btnClose.UseVisualStyleBackColor = True
			Me.lblShadow1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblShadow1.BackColor = Global.System.Drawing.Color.White
			Me.lblShadow1.Location = New Global.System.Drawing.Point(884, 0)
			Me.lblShadow1.Name = "lblShadow1"
			Me.lblShadow1.Size = New Global.System.Drawing.Size(6, 9)
			Me.lblShadow1.TabIndex = 6
			Me.lblShadow2.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
			Me.lblShadow2.BackColor = Global.System.Drawing.Color.White
			Me.lblShadow2.Location = New Global.System.Drawing.Point(0, 539)
			Me.lblShadow2.Name = "lblShadow2"
			Me.lblShadow2.Size = New Global.System.Drawing.Size(9, 7)
			Me.lblShadow2.TabIndex = 5
			Me.pUOM.DataPropertyName = "PrimaryUOM"
			Me.pUOM.HeaderText = "Primary UOM"
			Me.pUOM.Name = "pUOM"
			Me.pUOM.[ReadOnly] = True
			Me.pPrimaryPackSize.DataPropertyName = "PrimaryPackSize"
			Me.pPrimaryPackSize.HeaderText = "Primary PackSize"
			Me.pPrimaryPackSize.Name = "pPrimaryPackSize"
			Me.pPrimaryPackSize.[ReadOnly] = True
			Me.FinalConcentration.DataPropertyName = "FinalConcentration"
			Me.FinalConcentration.HeaderText = "Concentration"
			Me.FinalConcentration.Name = "FinalConcentration"
			Me.FinalConcentration.[ReadOnly] = True
			Me.FinalConcentration.Visible = False
			Me.FinalConcentration.Width = 92
			Me.Titre.DataPropertyName = "Titre"
			Me.Titre.HeaderText = "Titre"
			Me.Titre.Name = "Titre"
			Me.Titre.[ReadOnly] = True
			Me.Titre.Visible = False
			Me.Titre.Width = 60
			Me.CellCount.DataPropertyName = "CellCount"
			Me.CellCount.HeaderText = "Cell Count"
			Me.CellCount.Name = "CellCount"
			Me.CellCount.[ReadOnly] = True
			Me.CellCount.Visible = False
			Me.ODPermL.DataPropertyName = "ODPermL"
			Me.ODPermL.HeaderText = "OD/ mL"
			Me.ODPermL.Name = "ODPermL"
			Me.ODPermL.[ReadOnly] = True
			Me.ODPermL.Visible = False
			Me.pUID.DataPropertyName = "UID"
			Me.pUID.HeaderText = "UID"
			Me.pUID.Name = "pUID"
			Me.pUID.[ReadOnly] = True
			Me.pUID.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
			Me.pUID.Width = 125
			Me.pParentUID.DataPropertyName = "ParentUID"
			Me.pParentUID.HeaderText = "Parent UID"
			Me.pParentUID.Name = "pParentUID"
			Me.pParentUID.[ReadOnly] = True
			Me.pParentUID.Width = 110
			Me.pLocation.DataPropertyName = "LocationCode"
			Me.pLocation.HeaderText = "Location"
			Me.pLocation.Name = "pLocation"
			Me.pLocation.[ReadOnly] = True
			Me.pLocation.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
			Me.pLocation.Width = 125
			Me.pLocationName.DataPropertyName = "LocationName"
			Me.pLocationName.HeaderText = "Location Name"
			Me.pLocationName.Name = "pLocationName"
			Me.pLocationName.[ReadOnly] = True
			Me.pLocationName.Width = 130
			Me.pCatalogNo.DataPropertyName = "CatalogNo"
			Me.pCatalogNo.HeaderText = "Catalog No."
			Me.pCatalogNo.Name = "pCatalogNo"
			Me.pCatalogNo.[ReadOnly] = True
			Me.pCatalogNo.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
			Me.pCatalogNo.Width = 120
			Me.pProductName.DataPropertyName = "ProductName"
			Me.pProductName.HeaderText = "Product"
			Me.pProductName.Name = "pProductName"
			Me.pProductName.[ReadOnly] = True
			Me.pProductName.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
			Me.pProductName.Width = 250
			Me.pDescription.DataPropertyName = "Description"
			dataGridViewCellStyle19.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.pDescription.DefaultCellStyle = dataGridViewCellStyle19
			Me.pDescription.HeaderText = "Description"
			Me.pDescription.Name = "pDescription"
			Me.pDescription.[ReadOnly] = True
			Me.pDescription.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
			Me.pDescription.Visible = False
			Me.pDescription.Width = 300
			Me.pBatchNo.DataPropertyName = "BatchNo"
			Me.pBatchNo.HeaderText = "Batch/ Lot No."
			Me.pBatchNo.Name = "pBatchNo"
			Me.pBatchNo.[ReadOnly] = True
			Me.pBatchNo.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
			Me.pMfgDt.DataPropertyName = "MfgDt"
			dataGridViewCellStyle20.Format = "dd - MMM - yyyy"
			Me.pMfgDt.DefaultCellStyle = dataGridViewCellStyle20
			Me.pMfgDt.HeaderText = "Mfg Date"
			Me.pMfgDt.Name = "pMfgDt"
			Me.pMfgDt.[ReadOnly] = True
			Me.pMfgDt.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
			Me.pExpDt.DataPropertyName = "ExpDt"
			dataGridViewCellStyle21.Format = "dd - MMM - yyyy"
			Me.pExpDt.DefaultCellStyle = dataGridViewCellStyle21
			Me.pExpDt.HeaderText = "Expiry Date"
			Me.pExpDt.Name = "pExpDt"
			Me.pExpDt.[ReadOnly] = True
			Me.pExpDt.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
			Me.pReceiptDt.DataPropertyName = "ReceiptDt"
			dataGridViewCellStyle22.Format = "dd - MMM - yyyy"
			Me.pReceiptDt.DefaultCellStyle = dataGridViewCellStyle22
			Me.pReceiptDt.HeaderText = "Receipt Date"
			Me.pReceiptDt.Name = "pReceiptDt"
			Me.pReceiptDt.[ReadOnly] = True
			Me.pExpiryType.DataPropertyName = "ExpiryType"
			Me.pExpiryType.HeaderText = "ExpiryType"
			Me.pExpiryType.Name = "pExpiryType"
			Me.pExpiryType.[ReadOnly] = True
			Me.pExpiryType.Visible = False
			Me.pProductID.DataPropertyName = "ProductID"
			Me.pProductID.HeaderText = "ProductID"
			Me.pProductID.Name = "pProductID"
			Me.pProductID.[ReadOnly] = True
			Me.pProductID.Visible = False
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.None
			Me.BackColor = Global.System.Drawing.Color.DarkGray
			MyBase.ClientSize = New Global.System.Drawing.Size(889, 545)
			MyBase.Controls.Add(Me.pnlBorder)
			MyBase.Controls.Add(Me.lblShadow1)
			MyBase.Controls.Add(Me.lblShadow2)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedToolWindow
			MyBase.Name = "Picking"
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Picking"
			Me.pnlBorder.ResumeLayout(False)
			Me.pnlMain.ResumeLayout(False)
			Me.theme_tc.ResumeLayout(False)
			Me.tpDetails.ResumeLayout(False)
			Me.tpDetails.PerformLayout()
			Me.tpItem.ResumeLayout(False)
			Me.Panel1.ResumeLayout(False)
			CType(Me.dgvDtls, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.tpPicklist.ResumeLayout(False)
			Me.tpPicklist.PerformLayout()
			CType(Me.dgvPicklist, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.tpBarcodes.ResumeLayout(False)
			Me.tpBarcodes.PerformLayout()
			Me.flpButton.ResumeLayout(False)
			CType(Me.dgvUID, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.tpRemarks.ResumeLayout(False)
			Me.Panel4.ResumeLayout(False)
			Me.Panel4.PerformLayout()
			Me.panelTitleBar.ResumeLayout(False)
			Me.panelTitleBar.PerformLayout()
			CType(Me.picFormIcon, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000ABA RID: 2746
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
