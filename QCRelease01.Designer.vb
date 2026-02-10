Namespace Datasoft_PIMS
	' Token: 0x02000069 RID: 105
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class QCRelease01
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06001B60 RID: 7008 RVA: 0x000FEB14 File Offset: 0x000FCD14
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

		' Token: 0x06001B61 RID: 7009 RVA: 0x000FEB64 File Offset: 0x000FCD64
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle4 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle5 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle6 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.pnlBorder = New Global.System.Windows.Forms.Panel()
			Me.pnlMain = New Global.System.Windows.Forms.Panel()
			Me.theme_tc = New Global.System.Windows.Forms.TabControl()
			Me.tpItems = New Global.System.Windows.Forms.TabPage()
			Me.txtProductType = New Global.System.Windows.Forms.TextBox()
			Me.txtNotes = New Global.System.Windows.Forms.TextBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.txtConcentration = New Global.System.Windows.Forms.TextBox()
			Me.lbl1 = New Global.System.Windows.Forms.Label()
			Me.txtTitre = New Global.System.Windows.Forms.TextBox()
			Me.lbl2 = New Global.System.Windows.Forms.Label()
			Me.skip_lblStatus = New Global.System.Windows.Forms.Label()
			Me.txtGRNItemsID = New Global.System.Windows.Forms.TextBox()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.txtCatalogNo = New Global.System.Windows.Forms.TextBox()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.txtSpecificationNo = New Global.System.Windows.Forms.TextBox()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.cmbBatch = New Global.System.Windows.Forms.ComboBox()
			Me.txtReference = New Global.System.Windows.Forms.TextBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.cmbProduct = New Global.System.Windows.Forms.ComboBox()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.chkAll = New Global.System.Windows.Forms.CheckBox()
			Me.tab_lbl1 = New Global.System.Windows.Forms.Label()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.dgvDtls = New Global.System.Windows.Forms.DataGridView()
			Me.SrNo = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ProductID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.GRNItemsID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.BatchNo = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.PrimaryPackSize = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Specification = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.AcceptanceCriteria = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Complies = New Global.System.Windows.Forms.DataGridViewComboBoxColumn()
			Me.Label12 = New Global.System.Windows.Forms.Label()
			Me.txtPrimaryPackSize = New Global.System.Windows.Forms.TextBox()
			Me.tpRemarks = New Global.System.Windows.Forms.TabPage()
			Me.tab_lbl2 = New Global.System.Windows.Forms.Label()
			Me.lblRemarksApproval1 = New Global.System.Windows.Forms.Label()
			Me.lblRemarks1 = New Global.System.Windows.Forms.Label()
			Me.Panel4 = New Global.System.Windows.Forms.Panel()
			Me.txtRemarksApproval = New Global.System.Windows.Forms.TextBox()
			Me.txtRemarks = New Global.System.Windows.Forms.TextBox()
			Me.lblRemarks = New Global.System.Windows.Forms.Label()
			Me.lblRemarksApproval = New Global.System.Windows.Forms.Label()
			Me.tpDoc = New Global.System.Windows.Forms.TabPage()
			Me.llbSave = New Global.System.Windows.Forms.LinkLabel()
			Me.llbFile = New Global.System.Windows.Forms.LinkLabel()
			Me.tab_lbl3 = New Global.System.Windows.Forms.Label()
			Me.dgvFile = New Global.System.Windows.Forms.DataGridView()
			Me.FileID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.btnDownload_File = New Global.System.Windows.Forms.DataGridViewImageColumn()
			Me.FileName = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.btnDelete_File = New Global.System.Windows.Forms.DataGridViewImageColumn()
			Me.flpButton = New Global.System.Windows.Forms.FlowLayoutPanel()
			Me.btnSave = New Global.System.Windows.Forms.Button()
			Me.btnApprove = New Global.System.Windows.Forms.Button()
			Me.btnOnHold = New Global.System.Windows.Forms.Button()
			Me.btnReject = New Global.System.Windows.Forms.Button()
			Me.btnPrint = New Global.System.Windows.Forms.Button()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.txtVendor = New Global.System.Windows.Forms.TextBox()
			Me.txtPOType = New Global.System.Windows.Forms.TextBox()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.Label24 = New Global.System.Windows.Forms.Label()
			Me.dtpDt = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.txtNo = New Global.System.Windows.Forms.TextBox()
			Me.dtpPODt = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label28 = New Global.System.Windows.Forms.Label()
			Me.Label27 = New Global.System.Windows.Forms.Label()
			Me.txtPONo = New Global.System.Windows.Forms.TextBox()
			Me.txtPOID = New Global.System.Windows.Forms.TextBox()
			Me.txtID = New Global.System.Windows.Forms.TextBox()
			Me.panelTitleBar = New Global.System.Windows.Forms.Panel()
			Me.picFormIcon = New Global.System.Windows.Forms.PictureBox()
			Me.lblCaption = New Global.System.Windows.Forms.Label()
			Me.form_btnClose = New Global.System.Windows.Forms.Button()
			Me.lblShadow1 = New Global.System.Windows.Forms.Label()
			Me.lblShadow2 = New Global.System.Windows.Forms.Label()
			Me.txtCellCount = New Global.System.Windows.Forms.TextBox()
			Me.txtPassageNo = New Global.System.Windows.Forms.TextBox()
			Me.txtODPermL = New Global.System.Windows.Forms.TextBox()
			Me.pnlBorder.SuspendLayout()
			Me.pnlMain.SuspendLayout()
			Me.theme_tc.SuspendLayout()
			Me.tpItems.SuspendLayout()
			Me.Panel1.SuspendLayout()
			CType(Me.dgvDtls, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tpRemarks.SuspendLayout()
			Me.Panel4.SuspendLayout()
			Me.tpDoc.SuspendLayout()
			CType(Me.dgvFile, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.flpButton.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.panelTitleBar.SuspendLayout()
			CType(Me.picFormIcon, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.pnlBorder.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.pnlBorder.BackColor = Global.System.Drawing.Color.SteelBlue
			Me.pnlBorder.Controls.Add(Me.pnlMain)
			Me.pnlBorder.Location = New Global.System.Drawing.Point(0, 0)
			Me.pnlBorder.Name = "pnlBorder"
			Me.pnlBorder.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.pnlBorder.Size = New Global.System.Drawing.Size(950, 611)
			Me.pnlBorder.TabIndex = 4
			Me.pnlMain.BackColor = Global.System.Drawing.Color.White
			Me.pnlMain.Controls.Add(Me.theme_tc)
			Me.pnlMain.Controls.Add(Me.flpButton)
			Me.pnlMain.Controls.Add(Me.GroupBox1)
			Me.pnlMain.Controls.Add(Me.panelTitleBar)
			Me.pnlMain.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.pnlMain.Location = New Global.System.Drawing.Point(3, 3)
			Me.pnlMain.Name = "pnlMain"
			Me.pnlMain.Size = New Global.System.Drawing.Size(944, 605)
			Me.pnlMain.TabIndex = 1
			Me.theme_tc.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.theme_tc.Controls.Add(Me.tpItems)
			Me.theme_tc.Controls.Add(Me.tpRemarks)
			Me.theme_tc.Controls.Add(Me.tpDoc)
			Me.theme_tc.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.theme_tc.ItemSize = New Global.System.Drawing.Size(308, 25)
			Me.theme_tc.Location = New Global.System.Drawing.Point(9, 166)
			Me.theme_tc.Margin = New Global.System.Windows.Forms.Padding(0)
			Me.theme_tc.Name = "theme_tc"
			Me.theme_tc.SelectedIndex = 0
			Me.theme_tc.Size = New Global.System.Drawing.Size(928, 390)
			Me.theme_tc.SizeMode = Global.System.Windows.Forms.TabSizeMode.Fixed
			Me.theme_tc.TabIndex = 936
			Me.tpItems.BackColor = Global.System.Drawing.Color.Transparent
			Me.tpItems.Controls.Add(Me.txtProductType)
			Me.tpItems.Controls.Add(Me.txtNotes)
			Me.tpItems.Controls.Add(Me.Label3)
			Me.tpItems.Controls.Add(Me.txtConcentration)
			Me.tpItems.Controls.Add(Me.lbl1)
			Me.tpItems.Controls.Add(Me.txtTitre)
			Me.tpItems.Controls.Add(Me.lbl2)
			Me.tpItems.Controls.Add(Me.skip_lblStatus)
			Me.tpItems.Controls.Add(Me.txtGRNItemsID)
			Me.tpItems.Controls.Add(Me.Label8)
			Me.tpItems.Controls.Add(Me.txtCatalogNo)
			Me.tpItems.Controls.Add(Me.Label6)
			Me.tpItems.Controls.Add(Me.txtSpecificationNo)
			Me.tpItems.Controls.Add(Me.Label7)
			Me.tpItems.Controls.Add(Me.cmbBatch)
			Me.tpItems.Controls.Add(Me.txtReference)
			Me.tpItems.Controls.Add(Me.Label5)
			Me.tpItems.Controls.Add(Me.cmbProduct)
			Me.tpItems.Controls.Add(Me.Label10)
			Me.tpItems.Controls.Add(Me.chkAll)
			Me.tpItems.Controls.Add(Me.tab_lbl1)
			Me.tpItems.Controls.Add(Me.Panel1)
			Me.tpItems.Controls.Add(Me.Label12)
			Me.tpItems.Controls.Add(Me.txtPrimaryPackSize)
			Me.tpItems.Controls.Add(Me.txtCellCount)
			Me.tpItems.Controls.Add(Me.txtPassageNo)
			Me.tpItems.Controls.Add(Me.txtODPermL)
			Me.tpItems.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.tpItems.Location = New Global.System.Drawing.Point(4, 29)
			Me.tpItems.Name = "tpItems"
			Me.tpItems.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tpItems.Size = New Global.System.Drawing.Size(920, 357)
			Me.tpItems.TabIndex = 0
			Me.tpItems.Text = "Item Details"
			Me.tpItems.UseVisualStyleBackColor = True
			Me.txtProductType.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtProductType.Location = New Global.System.Drawing.Point(594, 18)
			Me.txtProductType.Name = "txtProductType"
			Me.txtProductType.Size = New Global.System.Drawing.Size(18, 21)
			Me.txtProductType.TabIndex = 1153
			Me.txtProductType.TabStop = False
			Me.txtProductType.Visible = False
			Me.txtNotes.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtNotes.Location = New Global.System.Drawing.Point(116, 97)
			Me.txtNotes.Multiline = True
			Me.txtNotes.Name = "txtNotes"
			Me.txtNotes.Size = New Global.System.Drawing.Size(472, 49)
			Me.txtNotes.TabIndex = 4
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.Location = New Global.System.Drawing.Point(20, 100)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(39, 15)
			Me.Label3.TabIndex = 1152
			Me.Label3.Text = "Notes"
			Me.txtConcentration.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtConcentration.Location = New Global.System.Drawing.Point(116, 71)
			Me.txtConcentration.Name = "txtConcentration"
			Me.txtConcentration.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtConcentration.TabIndex = 2
			Me.lbl1.AutoSize = True
			Me.lbl1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lbl1.Location = New Global.System.Drawing.Point(19, 74)
			Me.lbl1.Name = "lbl1"
			Me.lbl1.Size = New Global.System.Drawing.Size(87, 15)
			Me.lbl1.TabIndex = 1150
			Me.lbl1.Text = "Concentration"
			Me.txtTitre.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtTitre.Location = New Global.System.Drawing.Point(411, 71)
			Me.txtTitre.Name = "txtTitre"
			Me.txtTitre.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtTitre.TabIndex = 3
			Me.lbl2.AutoSize = True
			Me.lbl2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lbl2.Location = New Global.System.Drawing.Point(326, 74)
			Me.lbl2.Name = "lbl2"
			Me.lbl2.Size = New Global.System.Drawing.Size(33, 15)
			Me.lbl2.TabIndex = 1151
			Me.lbl2.Text = "Titre"
			Me.skip_lblStatus.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.skip_lblStatus.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.skip_lblStatus.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.skip_lblStatus.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.skip_lblStatus.ForeColor = Global.System.Drawing.Color.LawnGreen
			Me.skip_lblStatus.Location = New Global.System.Drawing.Point(705, 17)
			Me.skip_lblStatus.Name = "skip_lblStatus"
			Me.skip_lblStatus.Size = New Global.System.Drawing.Size(176, 23)
			Me.skip_lblStatus.TabIndex = 1147
			Me.skip_lblStatus.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.txtGRNItemsID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtGRNItemsID.Location = New Global.System.Drawing.Point(884, 18)
			Me.txtGRNItemsID.Name = "txtGRNItemsID"
			Me.txtGRNItemsID.Size = New Global.System.Drawing.Size(18, 21)
			Me.txtGRNItemsID.TabIndex = 1142
			Me.txtGRNItemsID.TabStop = False
			Me.txtGRNItemsID.Visible = False
			Me.Label8.AutoSize = True
			Me.Label8.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label8.Location = New Global.System.Drawing.Point(600, 48)
			Me.Label8.Name = "Label8"
			Me.Label8.Size = New Global.System.Drawing.Size(74, 15)
			Me.Label8.TabIndex = 1146
			Me.Label8.Text = "Catalog No."
			Me.txtCatalogNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtCatalogNo.Location = New Global.System.Drawing.Point(704, 45)
			Me.txtCatalogNo.Name = "txtCatalogNo"
			Me.txtCatalogNo.[ReadOnly] = True
			Me.txtCatalogNo.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtCatalogNo.TabIndex = 1145
			Me.txtCatalogNo.TabStop = False
			Me.Label6.AutoSize = True
			Me.Label6.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label6.Location = New Global.System.Drawing.Point(600, 74)
			Me.Label6.Name = "Label6"
			Me.Label6.Size = New Global.System.Drawing.Size(102, 15)
			Me.Label6.TabIndex = 1144
			Me.Label6.Text = "Specification No."
			Me.txtSpecificationNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtSpecificationNo.Location = New Global.System.Drawing.Point(704, 71)
			Me.txtSpecificationNo.Name = "txtSpecificationNo"
			Me.txtSpecificationNo.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtSpecificationNo.TabIndex = 1143
			Me.txtSpecificationNo.TabStop = False
			Me.Label7.AutoSize = True
			Me.Label7.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label7.Location = New Global.System.Drawing.Point(600, 100)
			Me.Label7.Name = "Label7"
			Me.Label7.Size = New Global.System.Drawing.Size(65, 15)
			Me.Label7.TabIndex = 1141
			Me.Label7.Text = "Reference"
			Me.cmbBatch.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbBatch.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbBatch.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbBatch.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbBatch.FormattingEnabled = True
			Me.cmbBatch.Location = New Global.System.Drawing.Point(116, 44)
			Me.cmbBatch.Name = "cmbBatch"
			Me.cmbBatch.Size = New Global.System.Drawing.Size(176, 23)
			Me.cmbBatch.TabIndex = 1
			Me.cmbBatch.TabStop = False
			Me.txtReference.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtReference.Location = New Global.System.Drawing.Point(704, 97)
			Me.txtReference.Name = "txtReference"
			Me.txtReference.[ReadOnly] = True
			Me.txtReference.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtReference.TabIndex = 1140
			Me.txtReference.TabStop = False
			Me.Label5.AutoSize = True
			Me.Label5.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label5.Location = New Global.System.Drawing.Point(19, 48)
			Me.Label5.Name = "Label5"
			Me.Label5.Size = New Global.System.Drawing.Size(88, 15)
			Me.Label5.TabIndex = 1139
			Me.Label5.Text = "Batch/ Lot No."
			Me.cmbProduct.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbProduct.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbProduct.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbProduct.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbProduct.FormattingEnabled = True
			Me.cmbProduct.Location = New Global.System.Drawing.Point(116, 17)
			Me.cmbProduct.Name = "cmbProduct"
			Me.cmbProduct.Size = New Global.System.Drawing.Size(472, 23)
			Me.cmbProduct.TabIndex = 0
			Me.cmbProduct.TabStop = False
			Me.Label10.AutoSize = True
			Me.Label10.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label10.Location = New Global.System.Drawing.Point(19, 20)
			Me.Label10.Name = "Label10"
			Me.Label10.Size = New Global.System.Drawing.Size(50, 15)
			Me.Label10.TabIndex = 1138
			Me.Label10.Text = "Product"
			Me.chkAll.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.chkAll.AutoSize = True
			Me.chkAll.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.chkAll.Location = New Global.System.Drawing.Point(813, 134)
			Me.chkAll.Name = "chkAll"
			Me.chkAll.Size = New Global.System.Drawing.Size(97, 19)
			Me.chkAll.TabIndex = 1129
			Me.chkAll.Text = "All Complies"
			Me.chkAll.UseVisualStyleBackColor = True
			Me.tab_lbl1.BackColor = Global.System.Drawing.Color.Black
			Me.tab_lbl1.ForeColor = Global.System.Drawing.Color.PaleGreen
			Me.tab_lbl1.Location = New Global.System.Drawing.Point(0, 0)
			Me.tab_lbl1.Name = "tab_lbl1"
			Me.tab_lbl1.Size = New Global.System.Drawing.Size(914, 3)
			Me.tab_lbl1.TabIndex = 1128
			Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Panel1.Controls.Add(Me.dgvDtls)
			Me.Panel1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Panel1.Location = New Global.System.Drawing.Point(6, 159)
			Me.Panel1.Name = "Panel1"
			Me.Panel1.Size = New Global.System.Drawing.Size(908, 194)
			Me.Panel1.TabIndex = 1096
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
			Me.dgvDtls.ColumnHeadersHeight = 25
			Me.dgvDtls.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.dgvDtls.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.SrNo, Me.ProductID, Me.GRNItemsID, Me.BatchNo, Me.PrimaryPackSize, Me.Specification, Me.AcceptanceCriteria, Me.Complies })
			Me.dgvDtls.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.dgvDtls.Location = New Global.System.Drawing.Point(0, 0)
			Me.dgvDtls.Name = "dgvDtls"
			Me.dgvDtls.RowHeadersWidth = 30
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dgvDtls.RowsDefaultCellStyle = dataGridViewCellStyle2
			Me.dgvDtls.Size = New Global.System.Drawing.Size(908, 194)
			Me.dgvDtls.TabIndex = 0
			Me.SrNo.DataPropertyName = "SrNo"
			Me.SrNo.HeaderText = "SrNo"
			Me.SrNo.Name = "SrNo"
			Me.SrNo.Visible = False
			Me.ProductID.DataPropertyName = "ProductID"
			Me.ProductID.HeaderText = "ProductID"
			Me.ProductID.Name = "ProductID"
			Me.ProductID.Visible = False
			Me.GRNItemsID.DataPropertyName = "GRNItemsID"
			Me.GRNItemsID.HeaderText = "GRNItemsID"
			Me.GRNItemsID.Name = "GRNItemsID"
			Me.GRNItemsID.Visible = False
			Me.BatchNo.DataPropertyName = "BatchNo"
			Me.BatchNo.HeaderText = "BatchNo"
			Me.BatchNo.Name = "BatchNo"
			Me.BatchNo.Visible = False
			Me.PrimaryPackSize.DataPropertyName = "PrimaryPackSize"
			Me.PrimaryPackSize.HeaderText = "PrimaryPackSize"
			Me.PrimaryPackSize.Name = "PrimaryPackSize"
			Me.PrimaryPackSize.Visible = False
			Me.Specification.DataPropertyName = "Specification"
			dataGridViewCellStyle3.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.Specification.DefaultCellStyle = dataGridViewCellStyle3
			Me.Specification.HeaderText = "Specification"
			Me.Specification.Name = "Specification"
			Me.Specification.[ReadOnly] = True
			Me.Specification.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
			Me.Specification.Width = 400
			Me.AcceptanceCriteria.DataPropertyName = "AcceptanceCriteria"
			Me.AcceptanceCriteria.HeaderText = "Acceptance Criteria"
			Me.AcceptanceCriteria.Name = "AcceptanceCriteria"
			Me.AcceptanceCriteria.[ReadOnly] = True
			Me.AcceptanceCriteria.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
			Me.AcceptanceCriteria.Width = 340
			Me.Complies.DataPropertyName = "Complies"
			dataGridViewCellStyle4.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.Complies.DefaultCellStyle = dataGridViewCellStyle4
			Me.Complies.DisplayStyle = Global.System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
			Me.Complies.HeaderText = "Complies"
			Me.Complies.Items.AddRange(New Object() { "Yes", "No" })
			Me.Complies.Name = "Complies"
			Me.Complies.Resizable = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.Label12.AutoSize = True
			Me.Label12.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label12.Location = New Global.System.Drawing.Point(326, 47)
			Me.Label12.Name = "Label12"
			Me.Label12.Size = New Global.System.Drawing.Size(50, 15)
			Me.Label12.TabIndex = 1155
			Me.Label12.Text = "Volume"
			Me.txtPrimaryPackSize.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPrimaryPackSize.Location = New Global.System.Drawing.Point(411, 44)
			Me.txtPrimaryPackSize.Name = "txtPrimaryPackSize"
			Me.txtPrimaryPackSize.[ReadOnly] = True
			Me.txtPrimaryPackSize.Size = New Global.System.Drawing.Size(177, 21)
			Me.txtPrimaryPackSize.TabIndex = 1154
			Me.txtPrimaryPackSize.TabStop = False
			Me.tpRemarks.Controls.Add(Me.tab_lbl2)
			Me.tpRemarks.Controls.Add(Me.lblRemarksApproval1)
			Me.tpRemarks.Controls.Add(Me.lblRemarks1)
			Me.tpRemarks.Controls.Add(Me.Panel4)
			Me.tpRemarks.Controls.Add(Me.lblRemarks)
			Me.tpRemarks.Controls.Add(Me.lblRemarksApproval)
			Me.tpRemarks.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.tpRemarks.Location = New Global.System.Drawing.Point(4, 29)
			Me.tpRemarks.Name = "tpRemarks"
			Me.tpRemarks.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tpRemarks.Size = New Global.System.Drawing.Size(920, 357)
			Me.tpRemarks.TabIndex = 7
			Me.tpRemarks.Text = "Remarks"
			Me.tpRemarks.UseVisualStyleBackColor = True
			Me.tab_lbl2.BackColor = Global.System.Drawing.Color.Black
			Me.tab_lbl2.ForeColor = Global.System.Drawing.Color.PaleGreen
			Me.tab_lbl2.Location = New Global.System.Drawing.Point(0, 0)
			Me.tab_lbl2.Name = "tab_lbl2"
			Me.tab_lbl2.Size = New Global.System.Drawing.Size(914, 3)
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
			Me.Panel4.Size = New Global.System.Drawing.Size(826, 336)
			Me.Panel4.TabIndex = 720
			Me.txtRemarksApproval.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtRemarksApproval.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtRemarksApproval.Location = New Global.System.Drawing.Point(10, 8)
			Me.txtRemarksApproval.Multiline = True
			Me.txtRemarksApproval.Name = "txtRemarksApproval"
			Me.txtRemarksApproval.[ReadOnly] = True
			Me.txtRemarksApproval.Size = New Global.System.Drawing.Size(805, 319)
			Me.txtRemarksApproval.TabIndex = 727
			Me.txtRemarks.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtRemarks.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtRemarks.Location = New Global.System.Drawing.Point(10, 8)
			Me.txtRemarks.Multiline = True
			Me.txtRemarks.Name = "txtRemarks"
			Me.txtRemarks.Size = New Global.System.Drawing.Size(805, 319)
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
			Me.tpDoc.BackColor = Global.System.Drawing.Color.Transparent
			Me.tpDoc.Controls.Add(Me.llbSave)
			Me.tpDoc.Controls.Add(Me.llbFile)
			Me.tpDoc.Controls.Add(Me.tab_lbl3)
			Me.tpDoc.Controls.Add(Me.dgvFile)
			Me.tpDoc.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.tpDoc.Location = New Global.System.Drawing.Point(4, 29)
			Me.tpDoc.Name = "tpDoc"
			Me.tpDoc.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tpDoc.Size = New Global.System.Drawing.Size(920, 357)
			Me.tpDoc.TabIndex = 2
			Me.tpDoc.Text = "Documents"
			Me.tpDoc.UseVisualStyleBackColor = True
			Me.llbSave.ActiveLinkColor = Global.System.Drawing.Color.Maroon
			Me.llbSave.AutoSize = True
			Me.llbSave.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.llbSave.LinkColor = Global.System.Drawing.Color.Maroon
			Me.llbSave.Location = New Global.System.Drawing.Point(844, 13)
			Me.llbSave.Name = "llbSave"
			Me.llbSave.Size = New Global.System.Drawing.Size(68, 15)
			Me.llbSave.TabIndex = 733
			Me.llbSave.TabStop = True
			Me.llbSave.Text = "Save File"
			Me.llbSave.Visible = False
			Me.llbFile.ActiveLinkColor = Global.System.Drawing.Color.Maroon
			Me.llbFile.AutoSize = True
			Me.llbFile.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.llbFile.LinkColor = Global.System.Drawing.Color.Maroon
			Me.llbFile.Location = New Global.System.Drawing.Point(8, 11)
			Me.llbFile.Name = "llbFile"
			Me.llbFile.Size = New Global.System.Drawing.Size(77, 15)
			Me.llbFile.TabIndex = 732
			Me.llbFile.TabStop = True
			Me.llbFile.Text = "Attach File"
			Me.tab_lbl3.BackColor = Global.System.Drawing.Color.Black
			Me.tab_lbl3.ForeColor = Global.System.Drawing.Color.PaleGreen
			Me.tab_lbl3.Location = New Global.System.Drawing.Point(0, 0)
			Me.tab_lbl3.Name = "tab_lbl3"
			Me.tab_lbl3.Size = New Global.System.Drawing.Size(914, 3)
			Me.tab_lbl3.TabIndex = 731
			Me.dgvFile.AllowUserToAddRows = False
			Me.dgvFile.AllowUserToDeleteRows = False
			Me.dgvFile.AllowUserToResizeRows = False
			Me.dgvFile.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.dgvFile.BackgroundColor = Global.System.Drawing.Color.WhiteSmoke
			dataGridViewCellStyle5.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle5.BackColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle5.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle5.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle5.SelectionBackColor = Global.System.Drawing.SystemColors.GradientInactiveCaption
			dataGridViewCellStyle5.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle5.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvFile.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5
			Me.dgvFile.ColumnHeadersHeight = 25
			Me.dgvFile.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.dgvFile.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.FileID, Me.btnDownload_File, Me.FileName, Me.btnDelete_File })
			Me.dgvFile.Location = New Global.System.Drawing.Point(4, 31)
			Me.dgvFile.Name = "dgvFile"
			Me.dgvFile.[ReadOnly] = True
			Me.dgvFile.RowHeadersVisible = False
			Me.dgvFile.RowHeadersWidth = 30
			dataGridViewCellStyle6.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dgvFile.RowsDefaultCellStyle = dataGridViewCellStyle6
			Me.dgvFile.RowTemplate.Height = 25
			Me.dgvFile.Size = New Global.System.Drawing.Size(911, 323)
			Me.dgvFile.TabIndex = 2
			Me.FileID.HeaderText = "FileID"
			Me.FileID.Name = "FileID"
			Me.FileID.[ReadOnly] = True
			Me.FileID.Visible = False
			Me.btnDownload_File.HeaderText = ""
			Me.btnDownload_File.ImageLayout = Global.System.Windows.Forms.DataGridViewImageCellLayout.Stretch
			Me.btnDownload_File.Name = "btnDownload_File"
			Me.btnDownload_File.[ReadOnly] = True
			Me.btnDownload_File.Width = 25
			Me.FileName.HeaderText = "File Name"
			Me.FileName.Name = "FileName"
			Me.FileName.[ReadOnly] = True
			Me.FileName.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
			Me.FileName.Width = 500
			Me.btnDelete_File.HeaderText = ""
			Me.btnDelete_File.ImageLayout = Global.System.Windows.Forms.DataGridViewImageCellLayout.Stretch
			Me.btnDelete_File.Name = "btnDelete_File"
			Me.btnDelete_File.[ReadOnly] = True
			Me.btnDelete_File.Visible = False
			Me.btnDelete_File.Width = 25
			Me.flpButton.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.flpButton.Controls.Add(Me.btnSave)
			Me.flpButton.Controls.Add(Me.btnApprove)
			Me.flpButton.Controls.Add(Me.btnOnHold)
			Me.flpButton.Controls.Add(Me.btnReject)
			Me.flpButton.Controls.Add(Me.btnPrint)
			Me.flpButton.Controls.Add(Me.btnClose)
			Me.flpButton.Location = New Global.System.Drawing.Point(132, 563)
			Me.flpButton.Name = "flpButton"
			Me.flpButton.Size = New Global.System.Drawing.Size(680, 35)
			Me.flpButton.TabIndex = 1127
			Me.btnSave.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnSave.Location = New Global.System.Drawing.Point(2, 0)
			Me.btnSave.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New Global.System.Drawing.Size(111, 32)
			Me.btnSave.TabIndex = 0
			Me.btnSave.Text = "&Save"
			Me.btnSave.UseVisualStyleBackColor = True
			Me.btnApprove.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnApprove.Location = New Global.System.Drawing.Point(115, 0)
			Me.btnApprove.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnApprove.Name = "btnApprove"
			Me.btnApprove.Size = New Global.System.Drawing.Size(111, 32)
			Me.btnApprove.TabIndex = 1
			Me.btnApprove.Text = "Approve"
			Me.btnApprove.UseVisualStyleBackColor = True
			Me.btnOnHold.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnOnHold.Location = New Global.System.Drawing.Point(228, 0)
			Me.btnOnHold.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnOnHold.Name = "btnOnHold"
			Me.btnOnHold.Size = New Global.System.Drawing.Size(111, 32)
			Me.btnOnHold.TabIndex = 5
			Me.btnOnHold.Text = "On-Hold"
			Me.btnOnHold.UseVisualStyleBackColor = True
			Me.btnReject.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnReject.Location = New Global.System.Drawing.Point(341, 0)
			Me.btnReject.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnReject.Name = "btnReject"
			Me.btnReject.Size = New Global.System.Drawing.Size(111, 32)
			Me.btnReject.TabIndex = 2
			Me.btnReject.Text = "Reject"
			Me.btnReject.UseVisualStyleBackColor = True
			Me.btnPrint.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnPrint.Location = New Global.System.Drawing.Point(454, 0)
			Me.btnPrint.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnPrint.Name = "btnPrint"
			Me.btnPrint.Size = New Global.System.Drawing.Size(111, 32)
			Me.btnPrint.TabIndex = 3
			Me.btnPrint.Text = "&Print"
			Me.btnPrint.UseVisualStyleBackColor = True
			Me.btnClose.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClose.Location = New Global.System.Drawing.Point(567, 0)
			Me.btnClose.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnClose.Name = "btnClose"
			Me.btnClose.Size = New Global.System.Drawing.Size(111, 32)
			Me.btnClose.TabIndex = 4
			Me.btnClose.Text = "C&lose"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.GroupBox1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.GroupBox1.Controls.Add(Me.txtVendor)
			Me.GroupBox1.Controls.Add(Me.txtPOType)
			Me.GroupBox1.Controls.Add(Me.Label9)
			Me.GroupBox1.Controls.Add(Me.Label24)
			Me.GroupBox1.Controls.Add(Me.dtpDt)
			Me.GroupBox1.Controls.Add(Me.Label1)
			Me.GroupBox1.Controls.Add(Me.Label2)
			Me.GroupBox1.Controls.Add(Me.txtNo)
			Me.GroupBox1.Controls.Add(Me.dtpPODt)
			Me.GroupBox1.Controls.Add(Me.Label28)
			Me.GroupBox1.Controls.Add(Me.Label27)
			Me.GroupBox1.Controls.Add(Me.txtPONo)
			Me.GroupBox1.Controls.Add(Me.txtPOID)
			Me.GroupBox1.Controls.Add(Me.txtID)
			Me.GroupBox1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GroupBox1.Location = New Global.System.Drawing.Point(9, 33)
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.Size = New Global.System.Drawing.Size(925, 127)
			Me.GroupBox1.TabIndex = 13
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "GRN Details"
			Me.txtVendor.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtVendor.Location = New Global.System.Drawing.Point(120, 97)
			Me.txtVendor.Name = "txtVendor"
			Me.txtVendor.[ReadOnly] = True
			Me.txtVendor.Size = New Global.System.Drawing.Size(471, 21)
			Me.txtVendor.TabIndex = 1068
			Me.txtVendor.TabStop = False
			Me.txtPOType.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPOType.Location = New Global.System.Drawing.Point(120, 72)
			Me.txtPOType.Name = "txtPOType"
			Me.txtPOType.[ReadOnly] = True
			Me.txtPOType.Size = New Global.System.Drawing.Size(471, 21)
			Me.txtPOType.TabIndex = 1067
			Me.txtPOType.TabStop = False
			Me.Label9.AutoSize = True
			Me.Label9.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label9.Location = New Global.System.Drawing.Point(28, 100)
			Me.Label9.Name = "Label9"
			Me.Label9.Size = New Global.System.Drawing.Size(48, 15)
			Me.Label9.TabIndex = 1066
			Me.Label9.Text = "Vendor"
			Me.Label24.AutoSize = True
			Me.Label24.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label24.Location = New Global.System.Drawing.Point(28, 75)
			Me.Label24.Name = "Label24"
			Me.Label24.Size = New Global.System.Drawing.Size(63, 15)
			Me.Label24.TabIndex = 1065
			Me.Label24.Text = "P.O. Type"
			Me.dtpDt.Checked = False
			Me.dtpDt.CustomFormat = "dd   MMM   yyyy"
			Me.dtpDt.Enabled = False
			Me.dtpDt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpDt.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpDt.Location = New Global.System.Drawing.Point(415, 22)
			Me.dtpDt.Name = "dtpDt"
			Me.dtpDt.Size = New Global.System.Drawing.Size(176, 21)
			Me.dtpDt.TabIndex = 1061
			Me.dtpDt.TabStop = False
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.Location = New Global.System.Drawing.Point(313, 25)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(75, 15)
			Me.Label1.TabIndex = 1062
			Me.Label1.Text = "G.R.N. Date"
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.Location = New Global.System.Drawing.Point(28, 25)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(67, 15)
			Me.Label2.TabIndex = 1064
			Me.Label2.Text = "G.R.N. No."
			Me.txtNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtNo.Location = New Global.System.Drawing.Point(120, 22)
			Me.txtNo.Name = "txtNo"
			Me.txtNo.[ReadOnly] = True
			Me.txtNo.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtNo.TabIndex = 1063
			Me.txtNo.TabStop = False
			Me.dtpPODt.Checked = False
			Me.dtpPODt.CustomFormat = "dd   MMM   yyyy"
			Me.dtpPODt.Enabled = False
			Me.dtpPODt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpPODt.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpPODt.Location = New Global.System.Drawing.Point(415, 47)
			Me.dtpPODt.Name = "dtpPODt"
			Me.dtpPODt.Size = New Global.System.Drawing.Size(176, 21)
			Me.dtpPODt.TabIndex = 1057
			Me.dtpPODt.TabStop = False
			Me.Label28.AutoSize = True
			Me.Label28.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label28.Location = New Global.System.Drawing.Point(313, 51)
			Me.Label28.Name = "Label28"
			Me.Label28.Size = New Global.System.Drawing.Size(62, 15)
			Me.Label28.TabIndex = 1058
			Me.Label28.Text = "P.O. Date"
			Me.Label28.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label27.AutoSize = True
			Me.Label27.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label27.Location = New Global.System.Drawing.Point(28, 51)
			Me.Label27.Name = "Label27"
			Me.Label27.Size = New Global.System.Drawing.Size(54, 15)
			Me.Label27.TabIndex = 1060
			Me.Label27.Text = "P.O. No."
			Me.txtPONo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPONo.Location = New Global.System.Drawing.Point(120, 47)
			Me.txtPONo.Name = "txtPONo"
			Me.txtPONo.[ReadOnly] = True
			Me.txtPONo.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtPONo.TabIndex = 1059
			Me.txtPONo.TabStop = False
			Me.txtPOID.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtPOID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPOID.Location = New Global.System.Drawing.Point(878, 21)
			Me.txtPOID.Name = "txtPOID"
			Me.txtPOID.Size = New Global.System.Drawing.Size(18, 21)
			Me.txtPOID.TabIndex = 1056
			Me.txtPOID.TabStop = False
			Me.txtPOID.Visible = False
			Me.txtID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtID.Location = New Global.System.Drawing.Point(900, 21)
			Me.txtID.Name = "txtID"
			Me.txtID.Size = New Global.System.Drawing.Size(18, 21)
			Me.txtID.TabIndex = 1055
			Me.txtID.TabStop = False
			Me.txtID.Visible = False
			Me.panelTitleBar.BackColor = Global.System.Drawing.Color.FromArgb(204, 231, 255)
			Me.panelTitleBar.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.panelTitleBar.Controls.Add(Me.picFormIcon)
			Me.panelTitleBar.Controls.Add(Me.lblCaption)
			Me.panelTitleBar.Controls.Add(Me.form_btnClose)
			Me.panelTitleBar.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.panelTitleBar.Location = New Global.System.Drawing.Point(0, 0)
			Me.panelTitleBar.Name = "panelTitleBar"
			Me.panelTitleBar.Size = New Global.System.Drawing.Size(944, 27)
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
			Me.form_btnClose.Location = New Global.System.Drawing.Point(918, 1)
			Me.form_btnClose.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.form_btnClose.Name = "form_btnClose"
			Me.form_btnClose.Size = New Global.System.Drawing.Size(24, 24)
			Me.form_btnClose.TabIndex = 719
			Me.form_btnClose.UseVisualStyleBackColor = True
			Me.lblShadow1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblShadow1.BackColor = Global.System.Drawing.Color.White
			Me.lblShadow1.Location = New Global.System.Drawing.Point(950, 0)
			Me.lblShadow1.Name = "lblShadow1"
			Me.lblShadow1.Size = New Global.System.Drawing.Size(6, 9)
			Me.lblShadow1.TabIndex = 6
			Me.lblShadow2.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
			Me.lblShadow2.BackColor = Global.System.Drawing.Color.White
			Me.lblShadow2.Location = New Global.System.Drawing.Point(0, 610)
			Me.lblShadow2.Name = "lblShadow2"
			Me.lblShadow2.Size = New Global.System.Drawing.Size(9, 7)
			Me.lblShadow2.TabIndex = 5
			Me.txtCellCount.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtCellCount.Location = New Global.System.Drawing.Point(116, 71)
			Me.txtCellCount.Name = "txtCellCount"
			Me.txtCellCount.[ReadOnly] = True
			Me.txtCellCount.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtCellCount.TabIndex = 1156
			Me.txtCellCount.TabStop = False
			Me.txtPassageNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPassageNo.Location = New Global.System.Drawing.Point(411, 71)
			Me.txtPassageNo.Name = "txtPassageNo"
			Me.txtPassageNo.[ReadOnly] = True
			Me.txtPassageNo.Size = New Global.System.Drawing.Size(171, 21)
			Me.txtPassageNo.TabIndex = 1157
			Me.txtPassageNo.TabStop = False
			Me.txtODPermL.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtODPermL.Location = New Global.System.Drawing.Point(116, 71)
			Me.txtODPermL.Name = "txtODPermL"
			Me.txtODPermL.[ReadOnly] = True
			Me.txtODPermL.Size = New Global.System.Drawing.Size(471, 21)
			Me.txtODPermL.TabIndex = 1162
			Me.txtODPermL.TabStop = False
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.DarkGray
			MyBase.ClientSize = New Global.System.Drawing.Size(955, 616)
			MyBase.Controls.Add(Me.pnlBorder)
			MyBase.Controls.Add(Me.lblShadow1)
			MyBase.Controls.Add(Me.lblShadow2)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedToolWindow
			MyBase.Name = "QCRelease01"
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "QCRelease"
			Me.pnlBorder.ResumeLayout(False)
			Me.pnlMain.ResumeLayout(False)
			Me.theme_tc.ResumeLayout(False)
			Me.tpItems.ResumeLayout(False)
			Me.tpItems.PerformLayout()
			Me.Panel1.ResumeLayout(False)
			CType(Me.dgvDtls, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.tpRemarks.ResumeLayout(False)
			Me.Panel4.ResumeLayout(False)
			Me.Panel4.PerformLayout()
			Me.tpDoc.ResumeLayout(False)
			Me.tpDoc.PerformLayout()
			CType(Me.dgvFile, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.flpButton.ResumeLayout(False)
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.panelTitleBar.ResumeLayout(False)
			Me.panelTitleBar.PerformLayout()
			CType(Me.picFormIcon, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000BDA RID: 3034
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
