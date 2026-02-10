Namespace Datasoft_PIMS
	' Token: 0x0200005B RID: 91
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class UIDPrinting
		Inherits Global.WeifenLuo.WinFormsUI.Docking.DockContent

		' Token: 0x060013CB RID: 5067 RVA: 0x000B664C File Offset: 0x000B484C
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

		' Token: 0x060013CC RID: 5068 RVA: 0x000B669C File Offset: 0x000B489C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle4 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle5 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.Label12 = New Global.System.Windows.Forms.Label()
			Me.Label16 = New Global.System.Windows.Forms.Label()
			Me.GroupBox5 = New Global.System.Windows.Forms.GroupBox()
			Me.btnPrintParent = New Global.System.Windows.Forms.Button()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.btnPrintUID = New Global.System.Windows.Forms.Button()
			Me.GroupBox4 = New Global.System.Windows.Forms.GroupBox()
			Me.lblRowsT = New Global.System.Windows.Forms.Label()
			Me.Panel3 = New Global.System.Windows.Forms.Panel()
			Me.dgvT = New Global.System.Windows.Forms.DataGridView()
			Me.tChk = New Global.System.Windows.Forms.DataGridViewCheckBoxColumn()
			Me.tParentUID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.tCatalogNo = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.imgFill = New Global.System.Windows.Forms.DataGridViewImageColumn()
			Me.chkAllT = New Global.System.Windows.Forms.CheckBox()
			Me.txtStorage = New Global.System.Windows.Forms.TextBox()
			Me.txtProductID = New Global.System.Windows.Forms.TextBox()
			Me.GroupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.lblRows = New Global.System.Windows.Forms.Label()
			Me.Panel2 = New Global.System.Windows.Forms.Panel()
			Me.dgv1 = New Global.System.Windows.Forms.DataGridView()
			Me.chk = New Global.System.Windows.Forms.DataGridViewCheckBoxColumn()
			Me.UID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ParentUID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Product = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.CatalogNo = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Description = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.BatchNo = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Price = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.IsParentApplicable = New Global.System.Windows.Forms.DataGridViewCheckBoxColumn()
			Me.IsUnitsEditable = New Global.System.Windows.Forms.DataGridViewCheckBoxColumn()
			Me.Status = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ProductID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.chkAll = New Global.System.Windows.Forms.CheckBox()
			Me.chkDsiplayParentwise = New Global.System.Windows.Forms.CheckBox()
			Me.txtID = New Global.System.Windows.Forms.TextBox()
			Me.txtPONo = New Global.System.Windows.Forms.TextBox()
			Me.txtProductType = New Global.System.Windows.Forms.TextBox()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.lblDisposed = New Global.System.Windows.Forms.Label()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.lblIssued = New Global.System.Windows.Forms.Label()
			Me.txtPOID = New Global.System.Windows.Forms.TextBox()
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
			Me.txtExpDt = New Global.System.Windows.Forms.TextBox()
			Me.txtProductCode = New Global.System.Windows.Forms.TextBox()
			Me.Label18 = New Global.System.Windows.Forms.Label()
			Me.Label14 = New Global.System.Windows.Forms.Label()
			Me.Label11 = New Global.System.Windows.Forms.Label()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.txtMeasurement = New Global.System.Windows.Forms.TextBox()
			Me.txtODPermL = New Global.System.Windows.Forms.TextBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.txtPassageNo = New Global.System.Windows.Forms.TextBox()
			Me.txtBatchNo = New Global.System.Windows.Forms.TextBox()
			Me.txtPrimaryPackSize = New Global.System.Windows.Forms.TextBox()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.txtCellCount = New Global.System.Windows.Forms.TextBox()
			Me.txtCatalogNo = New Global.System.Windows.Forms.TextBox()
			Me.txtMfgDt = New Global.System.Windows.Forms.TextBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label17 = New Global.System.Windows.Forms.Label()
			Me.txtProductName = New Global.System.Windows.Forms.TextBox()
			Me.Label15 = New Global.System.Windows.Forms.Label()
			Me.Label13 = New Global.System.Windows.Forms.Label()
			Me.cmbCopies = New Global.System.Windows.Forms.ComboBox()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.Label19 = New Global.System.Windows.Forms.Label()
			Me.cmbPrinter = New Global.System.Windows.Forms.ComboBox()
			Me.GroupBox5.SuspendLayout()
			Me.GroupBox4.SuspendLayout()
			Me.Panel3.SuspendLayout()
			CType(Me.dgvT, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox3.SuspendLayout()
			Me.Panel2.SuspendLayout()
			CType(Me.dgv1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox1.SuspendLayout()
			Me.Panel1.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			MyBase.SuspendLayout()
			Me.Label12.AutoSize = True
			Me.Label12.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label12.Location = New Global.System.Drawing.Point(9, 114)
			Me.Label12.Name = "Label12"
			Me.Label12.Size = New Global.System.Drawing.Size(62, 15)
			Me.Label12.TabIndex = 1074
			Me.Label12.Text = "Mfg. Date"
			Me.Label16.AutoSize = True
			Me.Label16.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label16.Location = New Global.System.Drawing.Point(9, 168)
			Me.Label16.Name = "Label16"
			Me.Label16.Size = New Global.System.Drawing.Size(67, 15)
			Me.Label16.TabIndex = 1078
			Me.Label16.Text = "Cell Count"
			Me.GroupBox5.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.GroupBox5.Controls.Add(Me.btnPrintParent)
			Me.GroupBox5.Controls.Add(Me.btnClose)
			Me.GroupBox5.Controls.Add(Me.btnPrintUID)
			Me.GroupBox5.Location = New Global.System.Drawing.Point(4, 470)
			Me.GroupBox5.Name = "GroupBox5"
			Me.GroupBox5.Size = New Global.System.Drawing.Size(1026, 55)
			Me.GroupBox5.TabIndex = 22
			Me.GroupBox5.TabStop = False
			Me.btnPrintParent.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnPrintParent.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnPrintParent.Location = New Global.System.Drawing.Point(443, 15)
			Me.btnPrintParent.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnPrintParent.Name = "btnPrintParent"
			Me.btnPrintParent.Size = New Global.System.Drawing.Size(141, 32)
			Me.btnPrintParent.TabIndex = 1053
			Me.btnPrintParent.Text = "&Print Parent UID"
			Me.btnPrintParent.UseVisualStyleBackColor = True
			Me.btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnClose.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClose.Location = New Global.System.Drawing.Point(587, 15)
			Me.btnClose.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnClose.Name = "btnClose"
			Me.btnClose.Size = New Global.System.Drawing.Size(129, 32)
			Me.btnClose.TabIndex = 1052
			Me.btnClose.Text = "C&lose"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.btnPrintUID.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnPrintUID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnPrintUID.Location = New Global.System.Drawing.Point(311, 15)
			Me.btnPrintUID.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnPrintUID.Name = "btnPrintUID"
			Me.btnPrintUID.Size = New Global.System.Drawing.Size(129, 32)
			Me.btnPrintUID.TabIndex = 1051
			Me.btnPrintUID.Text = "&Print UID"
			Me.btnPrintUID.UseVisualStyleBackColor = True
			Me.GroupBox4.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
			Me.GroupBox4.Controls.Add(Me.lblRowsT)
			Me.GroupBox4.Controls.Add(Me.Panel3)
			Me.GroupBox4.Controls.Add(Me.chkAllT)
			Me.GroupBox4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GroupBox4.Location = New Global.System.Drawing.Point(4, 287)
			Me.GroupBox4.Name = "GroupBox4"
			Me.GroupBox4.Size = New Global.System.Drawing.Size(379, 179)
			Me.GroupBox4.TabIndex = 20
			Me.GroupBox4.TabStop = False
			Me.GroupBox4.Text = "Tertiary UID Details"
			Me.lblRowsT.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblRowsT.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRowsT.Location = New Global.System.Drawing.Point(285, 0)
			Me.lblRowsT.Name = "lblRowsT"
			Me.lblRowsT.Size = New Global.System.Drawing.Size(87, 15)
			Me.lblRowsT.TabIndex = 1057
			Me.lblRowsT.Text = "0 - Rows"
			Me.lblRowsT.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.Panel3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Panel3.Controls.Add(Me.dgvT)
			Me.Panel3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Panel3.Location = New Global.System.Drawing.Point(2, 49)
			Me.Panel3.Name = "Panel3"
			Me.Panel3.Size = New Global.System.Drawing.Size(373, 124)
			Me.Panel3.TabIndex = 1054
			Me.dgvT.AllowUserToAddRows = False
			Me.dgvT.AllowUserToDeleteRows = False
			Me.dgvT.AllowUserToResizeRows = False
			Me.dgvT.BackgroundColor = Global.System.Drawing.Color.WhiteSmoke
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.GradientInactiveCaption
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.dgvT.ColumnHeadersHeight = 25
			Me.dgvT.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.dgvT.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.tChk, Me.tParentUID, Me.tCatalogNo, Me.imgFill })
			Me.dgvT.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.dgvT.Location = New Global.System.Drawing.Point(0, 0)
			Me.dgvT.MultiSelect = False
			Me.dgvT.Name = "dgvT"
			Me.dgvT.RowHeadersVisible = False
			Me.dgvT.RowHeadersWidth = 30
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dgvT.RowsDefaultCellStyle = dataGridViewCellStyle2
			Me.dgvT.RowTemplate.Height = 30
			Me.dgvT.Size = New Global.System.Drawing.Size(373, 124)
			Me.dgvT.TabIndex = 1046
			Me.tChk.DataPropertyName = "Chk"
			Me.tChk.FalseValue = "0"
			Me.tChk.HeaderText = ""
			Me.tChk.Name = "tChk"
			Me.tChk.TrueValue = "1"
			Me.tChk.Width = 30
			Me.tParentUID.DataPropertyName = "ParentUID"
			Me.tParentUID.HeaderText = "Parent UID"
			Me.tParentUID.Name = "tParentUID"
			Me.tParentUID.[ReadOnly] = True
			Me.tParentUID.Width = 140
			Me.tCatalogNo.DataPropertyName = "CatalogNo"
			Me.tCatalogNo.HeaderText = "Catalog No."
			Me.tCatalogNo.Name = "tCatalogNo"
			Me.tCatalogNo.[ReadOnly] = True
			Me.tCatalogNo.Width = 140
			Me.imgFill.DataPropertyName = "imgFill"
			Me.imgFill.HeaderText = ""
			Me.imgFill.ImageLayout = Global.System.Windows.Forms.DataGridViewImageCellLayout.Stretch
			Me.imgFill.Name = "imgFill"
			Me.imgFill.Width = 30
			Me.chkAllT.AutoSize = True
			Me.chkAllT.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.chkAllT.Location = New Global.System.Drawing.Point(12, 24)
			Me.chkAllT.Name = "chkAllT"
			Me.chkAllT.Size = New Global.System.Drawing.Size(79, 19)
			Me.chkAllT.TabIndex = 1051
			Me.chkAllT.Text = "Select All"
			Me.chkAllT.UseVisualStyleBackColor = True
			Me.txtStorage.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtStorage.Location = New Global.System.Drawing.Point(439, 84)
			Me.txtStorage.Name = "txtStorage"
			Me.txtStorage.[ReadOnly] = True
			Me.txtStorage.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtStorage.TabIndex = 1084
			Me.txtStorage.TabStop = False
			Me.txtProductID.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtProductID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtProductID.Location = New Global.System.Drawing.Point(906, 79)
			Me.txtProductID.Name = "txtProductID"
			Me.txtProductID.Size = New Global.System.Drawing.Size(34, 21)
			Me.txtProductID.TabIndex = 1063
			Me.txtProductID.TabStop = False
			Me.txtProductID.Visible = False
			Me.GroupBox3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.GroupBox3.Controls.Add(Me.lblRows)
			Me.GroupBox3.Controls.Add(Me.Panel2)
			Me.GroupBox3.Controls.Add(Me.chkAll)
			Me.GroupBox3.Controls.Add(Me.chkDsiplayParentwise)
			Me.GroupBox3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GroupBox3.Location = New Global.System.Drawing.Point(389, 287)
			Me.GroupBox3.Name = "GroupBox3"
			Me.GroupBox3.Size = New Global.System.Drawing.Size(641, 179)
			Me.GroupBox3.TabIndex = 21
			Me.GroupBox3.TabStop = False
			Me.GroupBox3.Text = "Primary UID Details"
			Me.lblRows.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblRows.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRows.Location = New Global.System.Drawing.Point(547, 0)
			Me.lblRows.Name = "lblRows"
			Me.lblRows.Size = New Global.System.Drawing.Size(87, 15)
			Me.lblRows.TabIndex = 1056
			Me.lblRows.Text = "0 - Rows"
			Me.lblRows.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.Panel2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Panel2.Controls.Add(Me.dgv1)
			Me.Panel2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Panel2.Location = New Global.System.Drawing.Point(4, 49)
			Me.Panel2.Name = "Panel2"
			Me.Panel2.Size = New Global.System.Drawing.Size(634, 124)
			Me.Panel2.TabIndex = 1053
			Me.dgv1.AllowUserToAddRows = False
			Me.dgv1.AllowUserToDeleteRows = False
			Me.dgv1.AllowUserToResizeRows = False
			Me.dgv1.BackgroundColor = Global.System.Drawing.Color.WhiteSmoke
			dataGridViewCellStyle3.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle3.BackColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle3.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle3.SelectionBackColor = Global.System.Drawing.SystemColors.GradientInactiveCaption
			dataGridViewCellStyle3.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle3.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3
			Me.dgv1.ColumnHeadersHeight = 25
			Me.dgv1.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.dgv1.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.chk, Me.UID, Me.ParentUID, Me.Product, Me.CatalogNo, Me.Description, Me.BatchNo, Me.Price, Me.IsParentApplicable, Me.IsUnitsEditable, Me.Status, Me.ProductID })
			Me.dgv1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.dgv1.Location = New Global.System.Drawing.Point(0, 0)
			Me.dgv1.Name = "dgv1"
			Me.dgv1.RowHeadersVisible = False
			Me.dgv1.RowHeadersWidth = 30
			dataGridViewCellStyle4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dgv1.RowsDefaultCellStyle = dataGridViewCellStyle4
			Me.dgv1.Size = New Global.System.Drawing.Size(634, 124)
			Me.dgv1.TabIndex = 1046
			Me.chk.DataPropertyName = "Chk"
			Me.chk.FalseValue = "0"
			Me.chk.HeaderText = ""
			Me.chk.Name = "chk"
			Me.chk.TrueValue = "1"
			Me.chk.Width = 30
			Me.UID.DataPropertyName = "UID"
			Me.UID.HeaderText = "UID"
			Me.UID.Name = "UID"
			Me.UID.[ReadOnly] = True
			Me.UID.Width = 150
			Me.ParentUID.DataPropertyName = "ParentUID"
			Me.ParentUID.HeaderText = "Parent UID"
			Me.ParentUID.Name = "ParentUID"
			Me.ParentUID.[ReadOnly] = True
			Me.ParentUID.Width = 150
			Me.Product.DataPropertyName = "ProductName"
			Me.Product.HeaderText = "Product Name"
			Me.Product.Name = "Product"
			Me.Product.[ReadOnly] = True
			Me.Product.Width = 250
			Me.CatalogNo.DataPropertyName = "CatalogNo"
			Me.CatalogNo.HeaderText = "Catalog No."
			Me.CatalogNo.Name = "CatalogNo"
			Me.CatalogNo.[ReadOnly] = True
			Me.CatalogNo.Width = 140
			Me.Description.DataPropertyName = "Description"
			dataGridViewCellStyle5.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.Description.DefaultCellStyle = dataGridViewCellStyle5
			Me.Description.HeaderText = "Description"
			Me.Description.Name = "Description"
			Me.Description.[ReadOnly] = True
			Me.Description.Visible = False
			Me.Description.Width = 300
			Me.BatchNo.DataPropertyName = "BatchNo"
			Me.BatchNo.HeaderText = "Batch/ Lot No."
			Me.BatchNo.Name = "BatchNo"
			Me.BatchNo.[ReadOnly] = True
			Me.Price.DataPropertyName = "Price"
			Me.Price.HeaderText = "Price"
			Me.Price.Name = "Price"
			Me.Price.[ReadOnly] = True
			Me.IsParentApplicable.DataPropertyName = "IsParentApplicable"
			Me.IsParentApplicable.FalseValue = "0"
			Me.IsParentApplicable.HeaderText = "IsParentApplicable"
			Me.IsParentApplicable.Name = "IsParentApplicable"
			Me.IsParentApplicable.[ReadOnly] = True
			Me.IsParentApplicable.TrueValue = "1"
			Me.IsParentApplicable.Visible = False
			Me.IsUnitsEditable.DataPropertyName = "IsUnitsEditable"
			Me.IsUnitsEditable.FalseValue = "0"
			Me.IsUnitsEditable.HeaderText = "IsUnitsEditable"
			Me.IsUnitsEditable.Name = "IsUnitsEditable"
			Me.IsUnitsEditable.[ReadOnly] = True
			Me.IsUnitsEditable.TrueValue = "1"
			Me.IsUnitsEditable.Visible = False
			Me.Status.DataPropertyName = "Status"
			Me.Status.HeaderText = "Status"
			Me.Status.Name = "Status"
			Me.Status.[ReadOnly] = True
			Me.ProductID.DataPropertyName = "ProductID"
			Me.ProductID.HeaderText = "ProductID"
			Me.ProductID.Name = "ProductID"
			Me.ProductID.[ReadOnly] = True
			Me.ProductID.Visible = False
			Me.chkAll.AutoSize = True
			Me.chkAll.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.chkAll.Location = New Global.System.Drawing.Point(14, 24)
			Me.chkAll.Name = "chkAll"
			Me.chkAll.Size = New Global.System.Drawing.Size(79, 19)
			Me.chkAll.TabIndex = 1052
			Me.chkAll.Text = "Select All"
			Me.chkAll.UseVisualStyleBackColor = True
			Me.chkDsiplayParentwise.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.chkDsiplayParentwise.AutoSize = True
			Me.chkDsiplayParentwise.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.chkDsiplayParentwise.Location = New Global.System.Drawing.Point(495, 24)
			Me.chkDsiplayParentwise.Name = "chkDsiplayParentwise"
			Me.chkDsiplayParentwise.Size = New Global.System.Drawing.Size(139, 19)
			Me.chkDsiplayParentwise.TabIndex = 1
			Me.chkDsiplayParentwise.Text = "Display Parent-wise"
			Me.chkDsiplayParentwise.UseVisualStyleBackColor = True
			Me.txtID.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtID.Location = New Global.System.Drawing.Point(986, 79)
			Me.txtID.Name = "txtID"
			Me.txtID.Size = New Global.System.Drawing.Size(34, 21)
			Me.txtID.TabIndex = 1054
			Me.txtID.TabStop = False
			Me.txtID.Visible = False
			Me.txtPONo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPONo.Location = New Global.System.Drawing.Point(120, 52)
			Me.txtPONo.Name = "txtPONo"
			Me.txtPONo.[ReadOnly] = True
			Me.txtPONo.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtPONo.TabIndex = 1045
			Me.txtPONo.TabStop = False
			Me.txtProductType.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtProductType.Location = New Global.System.Drawing.Point(102, 3)
			Me.txtProductType.Name = "txtProductType"
			Me.txtProductType.[ReadOnly] = True
			Me.txtProductType.Size = New Global.System.Drawing.Size(513, 21)
			Me.txtProductType.TabIndex = 1070
			Me.txtProductType.TabStop = False
			Me.GroupBox1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.GroupBox1.Controls.Add(Me.Label7)
			Me.GroupBox1.Controls.Add(Me.lblDisposed)
			Me.GroupBox1.Controls.Add(Me.txtProductID)
			Me.GroupBox1.Controls.Add(Me.Label6)
			Me.GroupBox1.Controls.Add(Me.lblIssued)
			Me.GroupBox1.Controls.Add(Me.txtPOID)
			Me.GroupBox1.Controls.Add(Me.txtID)
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
			Me.GroupBox1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GroupBox1.Location = New Global.System.Drawing.Point(4, 3)
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.Size = New Global.System.Drawing.Size(1026, 137)
			Me.GroupBox1.TabIndex = 18
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "GRN Details"
			Me.Label7.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label7.AutoSize = True
			Me.Label7.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label7.Location = New Global.System.Drawing.Point(935, 41)
			Me.Label7.Name = "Label7"
			Me.Label7.Size = New Global.System.Drawing.Size(85, 15)
			Me.Label7.TabIndex = 1069
			Me.Label7.Text = "Disposed UID"
			Me.lblDisposed.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblDisposed.BackColor = Global.System.Drawing.Color.Maroon
			Me.lblDisposed.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblDisposed.Location = New Global.System.Drawing.Point(903, 41)
			Me.lblDisposed.Name = "lblDisposed"
			Me.lblDisposed.Size = New Global.System.Drawing.Size(27, 15)
			Me.lblDisposed.TabIndex = 1068
			Me.Label6.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label6.AutoSize = True
			Me.Label6.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label6.Location = New Global.System.Drawing.Point(935, 23)
			Me.Label6.Name = "Label6"
			Me.Label6.Size = New Global.System.Drawing.Size(71, 15)
			Me.Label6.TabIndex = 1062
			Me.Label6.Text = "Issued UID"
			Me.lblIssued.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblIssued.BackColor = Global.System.Drawing.Color.DarkGreen
			Me.lblIssued.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblIssued.Location = New Global.System.Drawing.Point(903, 23)
			Me.lblIssued.Name = "lblIssued"
			Me.lblIssued.Size = New Global.System.Drawing.Size(27, 15)
			Me.lblIssued.TabIndex = 1061
			Me.txtPOID.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtPOID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPOID.Location = New Global.System.Drawing.Point(946, 79)
			Me.txtPOID.Name = "txtPOID"
			Me.txtPOID.Size = New Global.System.Drawing.Size(34, 21)
			Me.txtPOID.TabIndex = 1055
			Me.txtPOID.TabStop = False
			Me.txtPOID.Visible = False
			Me.txtVendor.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtVendor.Location = New Global.System.Drawing.Point(120, 104)
			Me.txtVendor.Name = "txtVendor"
			Me.txtVendor.[ReadOnly] = True
			Me.txtVendor.Size = New Global.System.Drawing.Size(508, 21)
			Me.txtVendor.TabIndex = 1056
			Me.txtVendor.TabStop = False
			Me.txtPOType.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPOType.Location = New Global.System.Drawing.Point(120, 78)
			Me.txtPOType.Name = "txtPOType"
			Me.txtPOType.[ReadOnly] = True
			Me.txtPOType.Size = New Global.System.Drawing.Size(508, 21)
			Me.txtPOType.TabIndex = 1055
			Me.txtPOType.TabStop = False
			Me.Label9.AutoSize = True
			Me.Label9.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label9.Location = New Global.System.Drawing.Point(27, 107)
			Me.Label9.Name = "Label9"
			Me.Label9.Size = New Global.System.Drawing.Size(48, 15)
			Me.Label9.TabIndex = 1053
			Me.Label9.Text = "Vendor"
			Me.Label24.AutoSize = True
			Me.Label24.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label24.Location = New Global.System.Drawing.Point(27, 81)
			Me.Label24.Name = "Label24"
			Me.Label24.Size = New Global.System.Drawing.Size(63, 15)
			Me.Label24.TabIndex = 1052
			Me.Label24.Text = "P.O. Type"
			Me.dtpDt.Checked = False
			Me.dtpDt.CustomFormat = "dd   MMM   yyyy"
			Me.dtpDt.Enabled = False
			Me.dtpDt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpDt.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpDt.Location = New Global.System.Drawing.Point(452, 26)
			Me.dtpDt.Name = "dtpDt"
			Me.dtpDt.Size = New Global.System.Drawing.Size(176, 21)
			Me.dtpDt.TabIndex = 1047
			Me.dtpDt.TabStop = False
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.Location = New Global.System.Drawing.Point(313, 29)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(75, 15)
			Me.Label1.TabIndex = 1048
			Me.Label1.Text = "G.R.N. Date"
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.Location = New Global.System.Drawing.Point(27, 29)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(67, 15)
			Me.Label2.TabIndex = 1050
			Me.Label2.Text = "G.R.N. No."
			Me.txtNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtNo.Location = New Global.System.Drawing.Point(120, 26)
			Me.txtNo.Name = "txtNo"
			Me.txtNo.[ReadOnly] = True
			Me.txtNo.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtNo.TabIndex = 1049
			Me.txtNo.TabStop = False
			Me.dtpPODt.Checked = False
			Me.dtpPODt.CustomFormat = "dd   MMM   yyyy"
			Me.dtpPODt.Enabled = False
			Me.dtpPODt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpPODt.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpPODt.Location = New Global.System.Drawing.Point(452, 52)
			Me.dtpPODt.Name = "dtpPODt"
			Me.dtpPODt.Size = New Global.System.Drawing.Size(176, 21)
			Me.dtpPODt.TabIndex = 1043
			Me.dtpPODt.TabStop = False
			Me.Label28.AutoSize = True
			Me.Label28.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label28.Location = New Global.System.Drawing.Point(313, 56)
			Me.Label28.Name = "Label28"
			Me.Label28.Size = New Global.System.Drawing.Size(62, 15)
			Me.Label28.TabIndex = 1044
			Me.Label28.Text = "P.O. Date"
			Me.Label28.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label27.AutoSize = True
			Me.Label27.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label27.Location = New Global.System.Drawing.Point(27, 56)
			Me.Label27.Name = "Label27"
			Me.Label27.Size = New Global.System.Drawing.Size(54, 15)
			Me.Label27.TabIndex = 1046
			Me.Label27.Text = "P.O. No."
			Me.txtExpDt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtExpDt.Location = New Global.System.Drawing.Point(102, 138)
			Me.txtExpDt.Name = "txtExpDt"
			Me.txtExpDt.[ReadOnly] = True
			Me.txtExpDt.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtExpDt.TabIndex = 1082
			Me.txtExpDt.TabStop = False
			Me.txtProductCode.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtProductCode.Location = New Global.System.Drawing.Point(102, 57)
			Me.txtProductCode.Name = "txtProductCode"
			Me.txtProductCode.[ReadOnly] = True
			Me.txtProductCode.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtProductCode.TabIndex = 1064
			Me.txtProductCode.TabStop = False
			Me.Label18.AutoSize = True
			Me.Label18.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label18.Location = New Global.System.Drawing.Point(291, 168)
			Me.Label18.Name = "Label18"
			Me.Label18.Size = New Global.System.Drawing.Size(51, 15)
			Me.Label18.TabIndex = 1080
			Me.Label18.Text = "OD/ mL"
			Me.Label14.AutoSize = True
			Me.Label14.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label14.Location = New Global.System.Drawing.Point(291, 87)
			Me.Label14.Name = "Label14"
			Me.Label14.Size = New Global.System.Drawing.Size(110, 15)
			Me.Label14.TabIndex = 1076
			Me.Label14.Text = "Storage Condition"
			Me.Label11.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label11.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label11.Location = New Global.System.Drawing.Point(935, 104)
			Me.Label11.Name = "Label11"
			Me.Label11.Size = New Global.System.Drawing.Size(46, 22)
			Me.Label11.TabIndex = 1074
			Me.Label11.Text = "Copies"
			Me.Label11.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label10.AutoSize = True
			Me.Label10.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label10.Location = New Global.System.Drawing.Point(290, 60)
			Me.Label10.Name = "Label10"
			Me.Label10.Size = New Global.System.Drawing.Size(74, 15)
			Me.Label10.TabIndex = 1073
			Me.Label10.Text = "Catalog No."
			Me.Label4.AutoSize = True
			Me.Label4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label4.Location = New Global.System.Drawing.Point(9, 87)
			Me.Label4.Name = "Label4"
			Me.Label4.Size = New Global.System.Drawing.Size(88, 15)
			Me.Label4.TabIndex = 1060
			Me.Label4.Text = "Batch/ Lot No."
			Me.Panel1.AutoScroll = True
			Me.Panel1.Controls.Add(Me.txtMeasurement)
			Me.Panel1.Controls.Add(Me.txtProductType)
			Me.Panel1.Controls.Add(Me.txtODPermL)
			Me.Panel1.Controls.Add(Me.Label5)
			Me.Panel1.Controls.Add(Me.txtPassageNo)
			Me.Panel1.Controls.Add(Me.txtBatchNo)
			Me.Panel1.Controls.Add(Me.txtPrimaryPackSize)
			Me.Panel1.Controls.Add(Me.Label8)
			Me.Panel1.Controls.Add(Me.txtStorage)
			Me.Panel1.Controls.Add(Me.txtProductCode)
			Me.Panel1.Controls.Add(Me.txtCellCount)
			Me.Panel1.Controls.Add(Me.Label4)
			Me.Panel1.Controls.Add(Me.txtExpDt)
			Me.Panel1.Controls.Add(Me.txtCatalogNo)
			Me.Panel1.Controls.Add(Me.txtMfgDt)
			Me.Panel1.Controls.Add(Me.Label3)
			Me.Panel1.Controls.Add(Me.Label18)
			Me.Panel1.Controls.Add(Me.Label10)
			Me.Panel1.Controls.Add(Me.Label17)
			Me.Panel1.Controls.Add(Me.txtProductName)
			Me.Panel1.Controls.Add(Me.Label16)
			Me.Panel1.Controls.Add(Me.Label12)
			Me.Panel1.Controls.Add(Me.Label15)
			Me.Panel1.Controls.Add(Me.Label13)
			Me.Panel1.Controls.Add(Me.Label14)
			Me.Panel1.Location = New Global.System.Drawing.Point(18, 20)
			Me.Panel1.Name = "Panel1"
			Me.Panel1.Size = New Global.System.Drawing.Size(654, 105)
			Me.Panel1.TabIndex = 1088
			Me.txtMeasurement.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtMeasurement.Location = New Global.System.Drawing.Point(558, 111)
			Me.txtMeasurement.Name = "txtMeasurement"
			Me.txtMeasurement.[ReadOnly] = True
			Me.txtMeasurement.Size = New Global.System.Drawing.Size(57, 21)
			Me.txtMeasurement.TabIndex = 1088
			Me.txtMeasurement.TabStop = False
			Me.txtODPermL.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtODPermL.Location = New Global.System.Drawing.Point(439, 165)
			Me.txtODPermL.Name = "txtODPermL"
			Me.txtODPermL.[ReadOnly] = True
			Me.txtODPermL.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtODPermL.TabIndex = 1087
			Me.txtODPermL.TabStop = False
			Me.Label5.AutoSize = True
			Me.Label5.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label5.Location = New Global.System.Drawing.Point(9, 60)
			Me.Label5.Name = "Label5"
			Me.Label5.Size = New Global.System.Drawing.Size(84, 15)
			Me.Label5.TabIndex = 1067
			Me.Label5.Text = "Product Code"
			Me.txtPassageNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPassageNo.Location = New Global.System.Drawing.Point(439, 138)
			Me.txtPassageNo.Name = "txtPassageNo"
			Me.txtPassageNo.[ReadOnly] = True
			Me.txtPassageNo.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtPassageNo.TabIndex = 1086
			Me.txtPassageNo.TabStop = False
			Me.txtBatchNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtBatchNo.Location = New Global.System.Drawing.Point(102, 84)
			Me.txtBatchNo.Name = "txtBatchNo"
			Me.txtBatchNo.[ReadOnly] = True
			Me.txtBatchNo.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtBatchNo.TabIndex = 1065
			Me.txtBatchNo.TabStop = False
			Me.txtPrimaryPackSize.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPrimaryPackSize.Location = New Global.System.Drawing.Point(439, 111)
			Me.txtPrimaryPackSize.Name = "txtPrimaryPackSize"
			Me.txtPrimaryPackSize.[ReadOnly] = True
			Me.txtPrimaryPackSize.Size = New Global.System.Drawing.Size(115, 21)
			Me.txtPrimaryPackSize.TabIndex = 1085
			Me.txtPrimaryPackSize.TabStop = False
			Me.Label8.AutoSize = True
			Me.Label8.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label8.Location = New Global.System.Drawing.Point(9, 6)
			Me.Label8.Name = "Label8"
			Me.Label8.Size = New Global.System.Drawing.Size(82, 15)
			Me.Label8.TabIndex = 1071
			Me.Label8.Text = "Product Type"
			Me.txtCellCount.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtCellCount.Location = New Global.System.Drawing.Point(102, 165)
			Me.txtCellCount.Name = "txtCellCount"
			Me.txtCellCount.[ReadOnly] = True
			Me.txtCellCount.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtCellCount.TabIndex = 1083
			Me.txtCellCount.TabStop = False
			Me.txtCatalogNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtCatalogNo.Location = New Global.System.Drawing.Point(439, 57)
			Me.txtCatalogNo.Name = "txtCatalogNo"
			Me.txtCatalogNo.[ReadOnly] = True
			Me.txtCatalogNo.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtCatalogNo.TabIndex = 1072
			Me.txtCatalogNo.TabStop = False
			Me.txtMfgDt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtMfgDt.Location = New Global.System.Drawing.Point(102, 111)
			Me.txtMfgDt.Name = "txtMfgDt"
			Me.txtMfgDt.[ReadOnly] = True
			Me.txtMfgDt.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtMfgDt.TabIndex = 1081
			Me.txtMfgDt.TabStop = False
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.Location = New Global.System.Drawing.Point(9, 32)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(87, 15)
			Me.Label3.TabIndex = 1059
			Me.Label3.Text = "Product Name"
			Me.Label17.AutoSize = True
			Me.Label17.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label17.Location = New Global.System.Drawing.Point(291, 141)
			Me.Label17.Name = "Label17"
			Me.Label17.Size = New Global.System.Drawing.Size(77, 15)
			Me.Label17.TabIndex = 1079
			Me.Label17.Text = "Passage No."
			Me.txtProductName.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtProductName.Location = New Global.System.Drawing.Point(102, 30)
			Me.txtProductName.Name = "txtProductName"
			Me.txtProductName.[ReadOnly] = True
			Me.txtProductName.Size = New Global.System.Drawing.Size(513, 21)
			Me.txtProductName.TabIndex = 1066
			Me.txtProductName.TabStop = False
			Me.Label15.AutoSize = True
			Me.Label15.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label15.Location = New Global.System.Drawing.Point(291, 114)
			Me.Label15.Name = "Label15"
			Me.Label15.Size = New Global.System.Drawing.Size(142, 15)
			Me.Label15.TabIndex = 1077
			Me.Label15.Text = "Primary Pack Size/ Vol."
			Me.Label13.AutoSize = True
			Me.Label13.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label13.Location = New Global.System.Drawing.Point(9, 141)
			Me.Label13.Name = "Label13"
			Me.Label13.Size = New Global.System.Drawing.Size(74, 15)
			Me.Label13.TabIndex = 1075
			Me.Label13.Text = "Expiry Date"
			Me.cmbCopies.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbCopies.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbCopies.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbCopies.FormattingEnabled = True
			Me.cmbCopies.Items.AddRange(New Object() { "1", "2" })
			Me.cmbCopies.Location = New Global.System.Drawing.Point(983, 104)
			Me.cmbCopies.Name = "cmbCopies"
			Me.cmbCopies.Size = New Global.System.Drawing.Size(36, 23)
			Me.cmbCopies.TabIndex = 1075
			Me.GroupBox2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.GroupBox2.Controls.Add(Me.Label19)
			Me.GroupBox2.Controls.Add(Me.cmbPrinter)
			Me.GroupBox2.Controls.Add(Me.Label11)
			Me.GroupBox2.Controls.Add(Me.Panel1)
			Me.GroupBox2.Controls.Add(Me.cmbCopies)
			Me.GroupBox2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GroupBox2.Location = New Global.System.Drawing.Point(4, 147)
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.Size = New Global.System.Drawing.Size(1026, 133)
			Me.GroupBox2.TabIndex = 19
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "Product Details"
			Me.Label19.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label19.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label19.Location = New Global.System.Drawing.Point(729, 104)
			Me.Label19.Name = "Label19"
			Me.Label19.Size = New Global.System.Drawing.Size(46, 22)
			Me.Label19.TabIndex = 1089
			Me.Label19.Text = "Printer"
			Me.Label19.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label19.Visible = False
			Me.cmbPrinter.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbPrinter.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbPrinter.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbPrinter.FormattingEnabled = True
			Me.cmbPrinter.Location = New Global.System.Drawing.Point(777, 105)
			Me.cmbPrinter.Name = "cmbPrinter"
			Me.cmbPrinter.Size = New Global.System.Drawing.Size(153, 23)
			Me.cmbPrinter.TabIndex = 1090
			Me.cmbPrinter.Visible = False
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			MyBase.ClientSize = New Global.System.Drawing.Size(1035, 529)
			MyBase.Controls.Add(Me.GroupBox5)
			MyBase.Controls.Add(Me.GroupBox4)
			MyBase.Controls.Add(Me.GroupBox3)
			MyBase.Controls.Add(Me.GroupBox1)
			MyBase.Controls.Add(Me.GroupBox2)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.Name = "UIDPrinting"
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "UID Printing"
			Me.GroupBox5.ResumeLayout(False)
			Me.GroupBox4.ResumeLayout(False)
			Me.GroupBox4.PerformLayout()
			Me.Panel3.ResumeLayout(False)
			CType(Me.dgvT, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox3.ResumeLayout(False)
			Me.GroupBox3.PerformLayout()
			Me.Panel2.ResumeLayout(False)
			CType(Me.dgv1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.GroupBox2.ResumeLayout(False)
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000868 RID: 2152
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
