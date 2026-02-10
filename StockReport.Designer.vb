Namespace Datasoft_PIMS
	' Token: 0x02000029 RID: 41
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class StockReport
		Inherits Global.WeifenLuo.WinFormsUI.Docking.DockContent

		' Token: 0x06000AAF RID: 2735 RVA: 0x000621E4 File Offset: 0x000603E4
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

		' Token: 0x06000AB0 RID: 2736 RVA: 0x00062234 File Offset: 0x00060434
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.GbBasic = New Global.System.Windows.Forms.GroupBox()
			Me.txtCatalogNo = New Global.System.Windows.Forms.TextBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.txtName = New Global.System.Windows.Forms.TextBox()
			Me.Label11 = New Global.System.Windows.Forms.Label()
			Me.txtCode = New Global.System.Windows.Forms.TextBox()
			Me.Label14 = New Global.System.Windows.Forms.Label()
			Me.arrow_btnBasicExp_sml = New Global.System.Windows.Forms.Button()
			Me.GbAdvanced = New Global.System.Windows.Forms.GroupBox()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.pnlUID = New Global.System.Windows.Forms.Panel()
			Me.txtUID = New Global.System.Windows.Forms.TextBox()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.pnlLocation = New Global.System.Windows.Forms.Panel()
			Me.txtLocation = New Global.System.Windows.Forms.TextBox()
			Me.lblLocation = New Global.System.Windows.Forms.Label()
			Me.pnlStatus = New Global.System.Windows.Forms.Panel()
			Me.lblStatus = New Global.System.Windows.Forms.Label()
			Me.cmbStatus = New Global.System.Windows.Forms.ComboBox()
			Me.pnlGRN = New Global.System.Windows.Forms.Panel()
			Me.lblGRNNo = New Global.System.Windows.Forms.Label()
			Me.txtGRNNo = New Global.System.Windows.Forms.TextBox()
			Me.dtpFrom = New Global.System.Windows.Forms.DateTimePicker()
			Me.dtpTo = New Global.System.Windows.Forms.DateTimePicker()
			Me.lblTo = New Global.System.Windows.Forms.Label()
			Me.lblDate = New Global.System.Windows.Forms.ComboBox()
			Me.cmbSummary = New Global.System.Windows.Forms.ComboBox()
			Me.cmbVendor = New Global.System.Windows.Forms.ComboBox()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.cmbType = New Global.System.Windows.Forms.ComboBox()
			Me.Label13 = New Global.System.Windows.Forms.Label()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.txtBatchNo = New Global.System.Windows.Forms.TextBox()
			Me.arrow_btnAdvanceExp_sml = New Global.System.Windows.Forms.Button()
			Me.grpListButton = New Global.System.Windows.Forms.GroupBox()
			Me.FlowLayoutPanel1 = New Global.System.Windows.Forms.FlowLayoutPanel()
			Me.btnSearch = New Global.System.Windows.Forms.Button()
			Me.btnClearList = New Global.System.Windows.Forms.Button()
			Me.btnExport = New Global.System.Windows.Forms.Button()
			Me.lblRows = New Global.System.Windows.Forms.Label()
			Me.dgvList = New Global.System.Windows.Forms.DataGridView()
			Me.GbBasic.SuspendLayout()
			Me.GbAdvanced.SuspendLayout()
			Me.Panel1.SuspendLayout()
			Me.pnlUID.SuspendLayout()
			Me.pnlLocation.SuspendLayout()
			Me.pnlStatus.SuspendLayout()
			Me.pnlGRN.SuspendLayout()
			Me.grpListButton.SuspendLayout()
			Me.FlowLayoutPanel1.SuspendLayout()
			CType(Me.dgvList, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.GbBasic.BackColor = Global.System.Drawing.Color.White
			Me.GbBasic.Controls.Add(Me.txtCatalogNo)
			Me.GbBasic.Controls.Add(Me.Label2)
			Me.GbBasic.Controls.Add(Me.txtName)
			Me.GbBasic.Controls.Add(Me.Label11)
			Me.GbBasic.Controls.Add(Me.txtCode)
			Me.GbBasic.Controls.Add(Me.Label14)
			Me.GbBasic.Controls.Add(Me.arrow_btnBasicExp_sml)
			Me.GbBasic.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.GbBasic.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GbBasic.Location = New Global.System.Drawing.Point(0, 0)
			Me.GbBasic.Name = "GbBasic"
			Me.GbBasic.Size = New Global.System.Drawing.Size(987, 86)
			Me.GbBasic.TabIndex = 477
			Me.GbBasic.TabStop = False
			Me.GbBasic.Text = "     Basic Search "
			Me.txtCatalogNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtCatalogNo.Location = New Global.System.Drawing.Point(438, 28)
			Me.txtCatalogNo.Name = "txtCatalogNo"
			Me.txtCatalogNo.Size = New Global.System.Drawing.Size(198, 21)
			Me.txtCatalogNo.TabIndex = 1
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.Location = New Global.System.Drawing.Point(351, 31)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(74, 15)
			Me.Label2.TabIndex = 749
			Me.Label2.Text = "Catalog No."
			Me.txtName.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtName.Location = New Global.System.Drawing.Point(139, 54)
			Me.txtName.Name = "txtName"
			Me.txtName.Size = New Global.System.Drawing.Size(497, 21)
			Me.txtName.TabIndex = 2
			Me.Label11.AutoSize = True
			Me.Label11.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label11.Location = New Global.System.Drawing.Point(33, 57)
			Me.Label11.Name = "Label11"
			Me.Label11.Size = New Global.System.Drawing.Size(87, 15)
			Me.Label11.TabIndex = 745
			Me.Label11.Text = "Product Name"
			Me.txtCode.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtCode.Location = New Global.System.Drawing.Point(139, 28)
			Me.txtCode.Name = "txtCode"
			Me.txtCode.Size = New Global.System.Drawing.Size(198, 21)
			Me.txtCode.TabIndex = 0
			Me.Label14.AutoSize = True
			Me.Label14.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label14.Location = New Global.System.Drawing.Point(33, 31)
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
			Me.GbAdvanced.Controls.Add(Me.Panel1)
			Me.GbAdvanced.Controls.Add(Me.dtpFrom)
			Me.GbAdvanced.Controls.Add(Me.dtpTo)
			Me.GbAdvanced.Controls.Add(Me.lblTo)
			Me.GbAdvanced.Controls.Add(Me.lblDate)
			Me.GbAdvanced.Controls.Add(Me.cmbSummary)
			Me.GbAdvanced.Controls.Add(Me.cmbVendor)
			Me.GbAdvanced.Controls.Add(Me.Label9)
			Me.GbAdvanced.Controls.Add(Me.Label1)
			Me.GbAdvanced.Controls.Add(Me.cmbType)
			Me.GbAdvanced.Controls.Add(Me.Label13)
			Me.GbAdvanced.Controls.Add(Me.Label7)
			Me.GbAdvanced.Controls.Add(Me.txtBatchNo)
			Me.GbAdvanced.Controls.Add(Me.arrow_btnAdvanceExp_sml)
			Me.GbAdvanced.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.GbAdvanced.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GbAdvanced.Location = New Global.System.Drawing.Point(0, 86)
			Me.GbAdvanced.Name = "GbAdvanced"
			Me.GbAdvanced.Size = New Global.System.Drawing.Size(987, 110)
			Me.GbAdvanced.TabIndex = 478
			Me.GbAdvanced.TabStop = False
			Me.GbAdvanced.Text = "     Advanced Search "
			Me.Panel1.AutoScroll = True
			Me.Panel1.Controls.Add(Me.pnlUID)
			Me.Panel1.Controls.Add(Me.pnlLocation)
			Me.Panel1.Controls.Add(Me.pnlStatus)
			Me.Panel1.Controls.Add(Me.pnlGRN)
			Me.Panel1.Location = New Global.System.Drawing.Point(642, 19)
			Me.Panel1.Name = "Panel1"
			Me.Panel1.Size = New Global.System.Drawing.Size(303, 55)
			Me.Panel1.TabIndex = 1082
			Me.pnlUID.Controls.Add(Me.txtUID)
			Me.pnlUID.Controls.Add(Me.Label4)
			Me.pnlUID.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.pnlUID.Location = New Global.System.Drawing.Point(0, 81)
			Me.pnlUID.Name = "pnlUID"
			Me.pnlUID.Size = New Global.System.Drawing.Size(286, 27)
			Me.pnlUID.TabIndex = 1084
			Me.txtUID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtUID.Location = New Global.System.Drawing.Point(77, 3)
			Me.txtUID.Name = "txtUID"
			Me.txtUID.Size = New Global.System.Drawing.Size(199, 21)
			Me.txtUID.TabIndex = 1078
			Me.Label4.AutoSize = True
			Me.Label4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label4.Location = New Global.System.Drawing.Point(3, 6)
			Me.Label4.Name = "Label4"
			Me.Label4.Size = New Global.System.Drawing.Size(29, 15)
			Me.Label4.TabIndex = 1079
			Me.Label4.Text = "UID"
			Me.pnlLocation.Controls.Add(Me.txtLocation)
			Me.pnlLocation.Controls.Add(Me.lblLocation)
			Me.pnlLocation.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.pnlLocation.Location = New Global.System.Drawing.Point(0, 54)
			Me.pnlLocation.Name = "pnlLocation"
			Me.pnlLocation.Size = New Global.System.Drawing.Size(286, 27)
			Me.pnlLocation.TabIndex = 1082
			Me.txtLocation.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtLocation.Location = New Global.System.Drawing.Point(77, 3)
			Me.txtLocation.Name = "txtLocation"
			Me.txtLocation.Size = New Global.System.Drawing.Size(199, 21)
			Me.txtLocation.TabIndex = 1078
			Me.lblLocation.AutoSize = True
			Me.lblLocation.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblLocation.Location = New Global.System.Drawing.Point(3, 6)
			Me.lblLocation.Name = "lblLocation"
			Me.lblLocation.Size = New Global.System.Drawing.Size(54, 15)
			Me.lblLocation.TabIndex = 1079
			Me.lblLocation.Text = "Location"
			Me.pnlStatus.Controls.Add(Me.lblStatus)
			Me.pnlStatus.Controls.Add(Me.cmbStatus)
			Me.pnlStatus.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.pnlStatus.Location = New Global.System.Drawing.Point(0, 27)
			Me.pnlStatus.Name = "pnlStatus"
			Me.pnlStatus.Size = New Global.System.Drawing.Size(286, 27)
			Me.pnlStatus.TabIndex = 481
			Me.lblStatus.AutoSize = True
			Me.lblStatus.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblStatus.Location = New Global.System.Drawing.Point(2, 6)
			Me.lblStatus.Name = "lblStatus"
			Me.lblStatus.Size = New Global.System.Drawing.Size(43, 15)
			Me.lblStatus.TabIndex = 1073
			Me.lblStatus.Text = "Status"
			Me.cmbStatus.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbStatus.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbStatus.FormattingEnabled = True
			Me.cmbStatus.Items.AddRange(New Object() { "", "In QC Release", "Available", "Disposed", "Expired", "Picked", "Issued" })
			Me.cmbStatus.Location = New Global.System.Drawing.Point(77, 2)
			Me.cmbStatus.Name = "cmbStatus"
			Me.cmbStatus.Size = New Global.System.Drawing.Size(198, 23)
			Me.cmbStatus.TabIndex = 3
			Me.pnlGRN.Controls.Add(Me.lblGRNNo)
			Me.pnlGRN.Controls.Add(Me.txtGRNNo)
			Me.pnlGRN.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.pnlGRN.Location = New Global.System.Drawing.Point(0, 0)
			Me.pnlGRN.Name = "pnlGRN"
			Me.pnlGRN.Size = New Global.System.Drawing.Size(286, 27)
			Me.pnlGRN.TabIndex = 1074
			Me.lblGRNNo.AutoSize = True
			Me.lblGRNNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblGRNNo.Location = New Global.System.Drawing.Point(3, 6)
			Me.lblGRNNo.Name = "lblGRNNo"
			Me.lblGRNNo.Size = New Global.System.Drawing.Size(55, 15)
			Me.lblGRNNo.TabIndex = 1081
			Me.lblGRNNo.Text = "GRN No."
			Me.txtGRNNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtGRNNo.Location = New Global.System.Drawing.Point(77, 3)
			Me.txtGRNNo.Name = "txtGRNNo"
			Me.txtGRNNo.Size = New Global.System.Drawing.Size(199, 21)
			Me.txtGRNNo.TabIndex = 1080
			Me.dtpFrom.Checked = False
			Me.dtpFrom.CustomFormat = "dd MMM yyyy  00:00"
			Me.dtpFrom.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpFrom.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpFrom.Location = New Global.System.Drawing.Point(138, 76)
			Me.dtpFrom.Name = "dtpFrom"
			Me.dtpFrom.ShowCheckBox = True
			Me.dtpFrom.Size = New Global.System.Drawing.Size(198, 21)
			Me.dtpFrom.TabIndex = 1087
			Me.dtpTo.Checked = False
			Me.dtpTo.CustomFormat = "dd MMM yyyy  23:59"
			Me.dtpTo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpTo.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpTo.Location = New Global.System.Drawing.Point(438, 76)
			Me.dtpTo.Name = "dtpTo"
			Me.dtpTo.ShowCheckBox = True
			Me.dtpTo.Size = New Global.System.Drawing.Size(198, 21)
			Me.dtpTo.TabIndex = 1088
			Me.lblTo.AutoSize = True
			Me.lblTo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblTo.Location = New Global.System.Drawing.Point(350, 80)
			Me.lblTo.Name = "lblTo"
			Me.lblTo.Size = New Global.System.Drawing.Size(21, 15)
			Me.lblTo.TabIndex = 1090
			Me.lblTo.Text = "To"
			Me.lblTo.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.lblDate.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.lblDate.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.lblDate.BackColor = Global.System.Drawing.Color.White
			Me.lblDate.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.lblDate.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.lblDate.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblDate.ForeColor = Global.System.Drawing.Color.DarkGreen
			Me.lblDate.FormattingEnabled = True
			Me.lblDate.Items.AddRange(New Object() { "Mfg. Date", "Expiry Date", "GRN Date" })
			Me.lblDate.Location = New Global.System.Drawing.Point(32, 75)
			Me.lblDate.Name = "lblDate"
			Me.lblDate.Size = New Global.System.Drawing.Size(100, 23)
			Me.lblDate.TabIndex = 1089
			Me.cmbSummary.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbSummary.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbSummary.FormattingEnabled = True
			Me.cmbSummary.Items.AddRange(New Object() { "Detailed", "Product-wise", "Batch-wise", "Location-wise", "GRN-wise" })
			Me.cmbSummary.Location = New Global.System.Drawing.Point(438, 49)
			Me.cmbSummary.Name = "cmbSummary"
			Me.cmbSummary.Size = New Global.System.Drawing.Size(198, 23)
			Me.cmbSummary.TabIndex = 1086
			Me.cmbVendor.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbVendor.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbVendor.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbVendor.FormattingEnabled = True
			Me.cmbVendor.Location = New Global.System.Drawing.Point(138, 21)
			Me.cmbVendor.Name = "cmbVendor"
			Me.cmbVendor.Size = New Global.System.Drawing.Size(199, 23)
			Me.cmbVendor.TabIndex = 1078
			Me.Label9.AutoSize = True
			Me.Label9.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label9.Location = New Global.System.Drawing.Point(32, 25)
			Me.Label9.Name = "Label9"
			Me.Label9.Size = New Global.System.Drawing.Size(48, 15)
			Me.Label9.TabIndex = 1085
			Me.Label9.Text = "Vendor"
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.Location = New Global.System.Drawing.Point(32, 53)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(62, 15)
			Me.Label1.TabIndex = 1084
			Me.Label1.Text = "Batch No."
			Me.cmbType.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbType.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbType.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbType.FormattingEnabled = True
			Me.cmbType.Items.AddRange(New Object() { "", "Raw Material", "Packaging Material", "Consumable", "Finished Goods", "Semi Finished", "Cell Bank - Mammalian", "Cell Bank - Bacterial", "Service", "Others" })
			Me.cmbType.Location = New Global.System.Drawing.Point(438, 21)
			Me.cmbType.Name = "cmbType"
			Me.cmbType.Size = New Global.System.Drawing.Size(198, 23)
			Me.cmbType.TabIndex = 1080
			Me.Label13.AutoSize = True
			Me.Label13.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label13.Location = New Global.System.Drawing.Point(350, 53)
			Me.Label13.Name = "Label13"
			Me.Label13.Size = New Global.System.Drawing.Size(63, 15)
			Me.Label13.TabIndex = 1081
			Me.Label13.Text = "Summary"
			Me.Label7.AutoSize = True
			Me.Label7.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label7.Location = New Global.System.Drawing.Point(350, 25)
			Me.Label7.Name = "Label7"
			Me.Label7.Size = New Global.System.Drawing.Size(82, 15)
			Me.Label7.TabIndex = 1083
			Me.Label7.Text = "Product Type"
			Me.txtBatchNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtBatchNo.Location = New Global.System.Drawing.Point(138, 50)
			Me.txtBatchNo.Name = "txtBatchNo"
			Me.txtBatchNo.Size = New Global.System.Drawing.Size(199, 21)
			Me.txtBatchNo.TabIndex = 1079
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
			Me.grpListButton.Location = New Global.System.Drawing.Point(0, 196)
			Me.grpListButton.Name = "grpListButton"
			Me.grpListButton.Size = New Global.System.Drawing.Size(987, 49)
			Me.grpListButton.TabIndex = 481
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
			Me.btnSearch.TabIndex = 0
			Me.btnSearch.Text = "Search"
			Me.btnSearch.UseVisualStyleBackColor = True
			Me.btnClearList.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClearList.Location = New Global.System.Drawing.Point(108, 3)
			Me.btnClearList.Margin = New Global.System.Windows.Forms.Padding(0, 3, 2, 3)
			Me.btnClearList.Name = "btnClearList"
			Me.btnClearList.Size = New Global.System.Drawing.Size(106, 29)
			Me.btnClearList.TabIndex = 1
			Me.btnClearList.Text = "Clear"
			Me.btnClearList.UseVisualStyleBackColor = True
			Me.btnExport.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnExport.Location = New Global.System.Drawing.Point(216, 3)
			Me.btnExport.Margin = New Global.System.Windows.Forms.Padding(0, 3, 2, 3)
			Me.btnExport.Name = "btnExport"
			Me.btnExport.Size = New Global.System.Drawing.Size(116, 29)
			Me.btnExport.TabIndex = 2
			Me.btnExport.Text = "Export XL"
			Me.btnExport.UseVisualStyleBackColor = True
			Me.lblRows.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblRows.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRows.Location = New Global.System.Drawing.Point(871, 21)
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
			Me.dgvList.ColumnHeadersHeight = 37
			Me.dgvList.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.dgvList.Location = New Global.System.Drawing.Point(0, 245)
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
			Me.dgvList.Size = New Global.System.Drawing.Size(987, 274)
			Me.dgvList.TabIndex = 485
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			MyBase.ClientSize = New Global.System.Drawing.Size(987, 519)
			MyBase.Controls.Add(Me.dgvList)
			MyBase.Controls.Add(Me.grpListButton)
			MyBase.Controls.Add(Me.GbAdvanced)
			MyBase.Controls.Add(Me.GbBasic)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.Name = "StockReport"
			Me.Text = "Stock Report"
			Me.GbBasic.ResumeLayout(False)
			Me.GbBasic.PerformLayout()
			Me.GbAdvanced.ResumeLayout(False)
			Me.GbAdvanced.PerformLayout()
			Me.Panel1.ResumeLayout(False)
			Me.pnlUID.ResumeLayout(False)
			Me.pnlUID.PerformLayout()
			Me.pnlLocation.ResumeLayout(False)
			Me.pnlLocation.PerformLayout()
			Me.pnlStatus.ResumeLayout(False)
			Me.pnlStatus.PerformLayout()
			Me.pnlGRN.ResumeLayout(False)
			Me.pnlGRN.PerformLayout()
			Me.grpListButton.ResumeLayout(False)
			Me.FlowLayoutPanel1.ResumeLayout(False)
			CType(Me.dgvList, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x0400047D RID: 1149
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
