Namespace Datasoft_PIMS
	' Token: 0x02000062 RID: 98
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class GRNList
		Inherits Global.WeifenLuo.WinFormsUI.Docking.DockContent

		' Token: 0x0600177A RID: 6010 RVA: 0x000D5738 File Offset: 0x000D3938
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

		' Token: 0x0600177B RID: 6011 RVA: 0x000D5788 File Offset: 0x000D3988
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.GbBasic = New Global.System.Windows.Forms.GroupBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.txtPONo = New Global.System.Windows.Forms.TextBox()
			Me.cmbPlant = New Global.System.Windows.Forms.ComboBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.txtNo = New Global.System.Windows.Forms.TextBox()
			Me.dtpFrom = New Global.System.Windows.Forms.DateTimePicker()
			Me.dtpTo = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label16 = New Global.System.Windows.Forms.Label()
			Me.lblDate = New Global.System.Windows.Forms.ComboBox()
			Me.arrow_btnBasicExp_sml = New Global.System.Windows.Forms.Button()
			Me.GbAdvanced = New Global.System.Windows.Forms.GroupBox()
			Me.cmbGRNType = New Global.System.Windows.Forms.ComboBox()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.pnlItem = New Global.System.Windows.Forms.Panel()
			Me.txtName = New Global.System.Windows.Forms.TextBox()
			Me.txtCatalogNo = New Global.System.Windows.Forms.TextBox()
			Me.Label14 = New Global.System.Windows.Forms.Label()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.txtCode = New Global.System.Windows.Forms.TextBox()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.cmbSummary = New Global.System.Windows.Forms.ComboBox()
			Me.Label13 = New Global.System.Windows.Forms.Label()
			Me.cmbStatus = New Global.System.Windows.Forms.ComboBox()
			Me.Label11 = New Global.System.Windows.Forms.Label()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.cmbVendor = New Global.System.Windows.Forms.ComboBox()
			Me.txtChallanNo = New Global.System.Windows.Forms.TextBox()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.txtCreated = New Global.System.Windows.Forms.TextBox()
			Me.txtInvoiceNo = New Global.System.Windows.Forms.TextBox()
			Me.lblCreated = New Global.System.Windows.Forms.ComboBox()
			Me.arrow_btnAdvanceExp_sml = New Global.System.Windows.Forms.Button()
			Me.grpListButton = New Global.System.Windows.Forms.GroupBox()
			Me.FlowLayoutPanel1 = New Global.System.Windows.Forms.FlowLayoutPanel()
			Me.btnWithoutPO = New Global.System.Windows.Forms.Button()
			Me.btnWithPO = New Global.System.Windows.Forms.Button()
			Me.btnGRNBMR = New Global.System.Windows.Forms.Button()
			Me.btnSearch = New Global.System.Windows.Forms.Button()
			Me.btnClearList = New Global.System.Windows.Forms.Button()
			Me.btnExport = New Global.System.Windows.Forms.Button()
			Me.lblRows = New Global.System.Windows.Forms.Label()
			Me.dgvList = New Global.System.Windows.Forms.DataGridView()
			Me.GbBasic.SuspendLayout()
			Me.GbAdvanced.SuspendLayout()
			Me.pnlItem.SuspendLayout()
			Me.grpListButton.SuspendLayout()
			Me.FlowLayoutPanel1.SuspendLayout()
			CType(Me.dgvList, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.GbBasic.BackColor = Global.System.Drawing.Color.White
			Me.GbBasic.Controls.Add(Me.Label2)
			Me.GbBasic.Controls.Add(Me.txtPONo)
			Me.GbBasic.Controls.Add(Me.cmbPlant)
			Me.GbBasic.Controls.Add(Me.Label1)
			Me.GbBasic.Controls.Add(Me.txtNo)
			Me.GbBasic.Controls.Add(Me.dtpFrom)
			Me.GbBasic.Controls.Add(Me.dtpTo)
			Me.GbBasic.Controls.Add(Me.Label16)
			Me.GbBasic.Controls.Add(Me.lblDate)
			Me.GbBasic.Controls.Add(Me.arrow_btnBasicExp_sml)
			Me.GbBasic.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.GbBasic.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GbBasic.Location = New Global.System.Drawing.Point(0, 0)
			Me.GbBasic.Name = "GbBasic"
			Me.GbBasic.Size = New Global.System.Drawing.Size(1000, 81)
			Me.GbBasic.TabIndex = 5
			Me.GbBasic.TabStop = False
			Me.GbBasic.Text = "     Basic Search "
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.Location = New Global.System.Drawing.Point(395, 52)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(54, 15)
			Me.Label2.TabIndex = 509
			Me.Label2.Text = "P.O. No."
			Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.txtPONo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPONo.Location = New Global.System.Drawing.Point(480, 50)
			Me.txtPONo.Name = "txtPONo"
			Me.txtPONo.Size = New Global.System.Drawing.Size(189, 21)
			Me.txtPONo.TabIndex = 3
			Me.cmbPlant.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbPlant.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbPlant.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbPlant.FormattingEnabled = True
			Me.cmbPlant.Location = New Global.System.Drawing.Point(953, 18)
			Me.cmbPlant.Name = "cmbPlant"
			Me.cmbPlant.Size = New Global.System.Drawing.Size(41, 23)
			Me.cmbPlant.TabIndex = 507
			Me.cmbPlant.Visible = False
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.Location = New Global.System.Drawing.Point(34, 52)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(67, 15)
			Me.Label1.TabIndex = 506
			Me.Label1.Text = "G.R.N. No."
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.txtNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtNo.Location = New Global.System.Drawing.Point(180, 50)
			Me.txtNo.Name = "txtNo"
			Me.txtNo.Size = New Global.System.Drawing.Size(189, 21)
			Me.txtNo.TabIndex = 2
			Me.dtpFrom.Checked = False
			Me.dtpFrom.CustomFormat = "dd MMM yyyy  00:00"
			Me.dtpFrom.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpFrom.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpFrom.Location = New Global.System.Drawing.Point(180, 24)
			Me.dtpFrom.Name = "dtpFrom"
			Me.dtpFrom.ShowCheckBox = True
			Me.dtpFrom.Size = New Global.System.Drawing.Size(189, 21)
			Me.dtpFrom.TabIndex = 0
			Me.dtpTo.Checked = False
			Me.dtpTo.CustomFormat = "dd MMM yyyy  23:59"
			Me.dtpTo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpTo.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpTo.Location = New Global.System.Drawing.Point(480, 24)
			Me.dtpTo.Name = "dtpTo"
			Me.dtpTo.ShowCheckBox = True
			Me.dtpTo.Size = New Global.System.Drawing.Size(189, 21)
			Me.dtpTo.TabIndex = 1
			Me.Label16.AutoSize = True
			Me.Label16.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label16.Location = New Global.System.Drawing.Point(395, 28)
			Me.Label16.Name = "Label16"
			Me.Label16.Size = New Global.System.Drawing.Size(21, 15)
			Me.Label16.TabIndex = 499
			Me.Label16.Text = "To"
			Me.Label16.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.lblDate.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.lblDate.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.lblDate.BackColor = Global.System.Drawing.Color.White
			Me.lblDate.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.lblDate.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.lblDate.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblDate.ForeColor = Global.System.Drawing.Color.DarkGreen
			Me.lblDate.FormattingEnabled = True
			Me.lblDate.Items.AddRange(New Object() { "G.R.N Date", "P.O. Date", "Invoice Date", "Challan Date", "Creation", "Last Modification" })
			Me.lblDate.Location = New Global.System.Drawing.Point(34, 23)
			Me.lblDate.Name = "lblDate"
			Me.lblDate.Size = New Global.System.Drawing.Size(143, 23)
			Me.lblDate.TabIndex = 497
			Me.arrow_btnBasicExp_sml.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.arrow_btnBasicExp_sml.FlatAppearance.BorderSize = 0
			Me.arrow_btnBasicExp_sml.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.Transparent
			Me.arrow_btnBasicExp_sml.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.Transparent
			Me.arrow_btnBasicExp_sml.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.arrow_btnBasicExp_sml.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.arrow_btnBasicExp_sml.Location = New Global.System.Drawing.Point(8, 0)
			Me.arrow_btnBasicExp_sml.Name = "arrow_btnBasicExp_sml"
			Me.arrow_btnBasicExp_sml.Size = New Global.System.Drawing.Size(20, 20)
			Me.arrow_btnBasicExp_sml.TabIndex = 4
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			Me.arrow_btnBasicExp_sml.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.arrow_btnBasicExp_sml.UseVisualStyleBackColor = True
			Me.GbAdvanced.Controls.Add(Me.cmbGRNType)
			Me.GbAdvanced.Controls.Add(Me.Label7)
			Me.GbAdvanced.Controls.Add(Me.pnlItem)
			Me.GbAdvanced.Controls.Add(Me.cmbSummary)
			Me.GbAdvanced.Controls.Add(Me.Label13)
			Me.GbAdvanced.Controls.Add(Me.cmbStatus)
			Me.GbAdvanced.Controls.Add(Me.Label11)
			Me.GbAdvanced.Controls.Add(Me.Label3)
			Me.GbAdvanced.Controls.Add(Me.cmbVendor)
			Me.GbAdvanced.Controls.Add(Me.txtChallanNo)
			Me.GbAdvanced.Controls.Add(Me.Label9)
			Me.GbAdvanced.Controls.Add(Me.Label4)
			Me.GbAdvanced.Controls.Add(Me.txtCreated)
			Me.GbAdvanced.Controls.Add(Me.txtInvoiceNo)
			Me.GbAdvanced.Controls.Add(Me.lblCreated)
			Me.GbAdvanced.Controls.Add(Me.arrow_btnAdvanceExp_sml)
			Me.GbAdvanced.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.GbAdvanced.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GbAdvanced.Location = New Global.System.Drawing.Point(0, 81)
			Me.GbAdvanced.Name = "GbAdvanced"
			Me.GbAdvanced.Size = New Global.System.Drawing.Size(1000, 190)
			Me.GbAdvanced.TabIndex = 6
			Me.GbAdvanced.TabStop = False
			Me.GbAdvanced.Text = "     Advanced Search "
			Me.cmbGRNType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbGRNType.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbGRNType.FormattingEnabled = True
			Me.cmbGRNType.Items.AddRange(New Object() { "", "Receipt", "BMR", "Return" })
			Me.cmbGRNType.Location = New Global.System.Drawing.Point(180, 27)
			Me.cmbGRNType.Name = "cmbGRNType"
			Me.cmbGRNType.Size = New Global.System.Drawing.Size(189, 23)
			Me.cmbGRNType.TabIndex = 1074
			Me.Label7.AutoSize = True
			Me.Label7.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label7.Location = New Global.System.Drawing.Point(34, 30)
			Me.Label7.Name = "Label7"
			Me.Label7.Size = New Global.System.Drawing.Size(64, 15)
			Me.Label7.TabIndex = 1075
			Me.Label7.Text = "GRN Type"
			Me.pnlItem.Controls.Add(Me.txtName)
			Me.pnlItem.Controls.Add(Me.txtCatalogNo)
			Me.pnlItem.Controls.Add(Me.Label14)
			Me.pnlItem.Controls.Add(Me.Label5)
			Me.pnlItem.Controls.Add(Me.txtCode)
			Me.pnlItem.Controls.Add(Me.Label6)
			Me.pnlItem.Location = New Global.System.Drawing.Point(27, 133)
			Me.pnlItem.Name = "pnlItem"
			Me.pnlItem.Size = New Global.System.Drawing.Size(655, 54)
			Me.pnlItem.TabIndex = 6
			Me.txtName.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtName.Location = New Global.System.Drawing.Point(153, 29)
			Me.txtName.Name = "txtName"
			Me.txtName.Size = New Global.System.Drawing.Size(489, 21)
			Me.txtName.TabIndex = 2
			Me.txtCatalogNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtCatalogNo.Location = New Global.System.Drawing.Point(453, 3)
			Me.txtCatalogNo.Name = "txtCatalogNo"
			Me.txtCatalogNo.Size = New Global.System.Drawing.Size(189, 21)
			Me.txtCatalogNo.TabIndex = 1
			Me.Label14.AutoSize = True
			Me.Label14.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label14.Location = New Global.System.Drawing.Point(7, 6)
			Me.Label14.Name = "Label14"
			Me.Label14.Size = New Global.System.Drawing.Size(84, 15)
			Me.Label14.TabIndex = 1078
			Me.Label14.Text = "Product Code"
			Me.Label5.AutoSize = True
			Me.Label5.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label5.Location = New Global.System.Drawing.Point(368, 6)
			Me.Label5.Name = "Label5"
			Me.Label5.Size = New Global.System.Drawing.Size(74, 15)
			Me.Label5.TabIndex = 1080
			Me.Label5.Text = "Catalog No."
			Me.txtCode.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtCode.Location = New Global.System.Drawing.Point(153, 3)
			Me.txtCode.Name = "txtCode"
			Me.txtCode.Size = New Global.System.Drawing.Size(189, 21)
			Me.txtCode.TabIndex = 0
			Me.Label6.AutoSize = True
			Me.Label6.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label6.Location = New Global.System.Drawing.Point(7, 32)
			Me.Label6.Name = "Label6"
			Me.Label6.Size = New Global.System.Drawing.Size(87, 15)
			Me.Label6.TabIndex = 1079
			Me.Label6.Text = "Product Name"
			Me.cmbSummary.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbSummary.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbSummary.FormattingEnabled = True
			Me.cmbSummary.Items.AddRange(New Object() { "Transaction-wise", "Item-wise" })
			Me.cmbSummary.Location = New Global.System.Drawing.Point(480, 108)
			Me.cmbSummary.Name = "cmbSummary"
			Me.cmbSummary.Size = New Global.System.Drawing.Size(189, 23)
			Me.cmbSummary.TabIndex = 5
			Me.Label13.AutoSize = True
			Me.Label13.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label13.Location = New Global.System.Drawing.Point(395, 111)
			Me.Label13.Name = "Label13"
			Me.Label13.Size = New Global.System.Drawing.Size(63, 15)
			Me.Label13.TabIndex = 1073
			Me.Label13.Text = "Summary"
			Me.cmbStatus.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbStatus.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbStatus.FormattingEnabled = True
			Me.cmbStatus.Items.AddRange(New Object() { "", "GRN In Approval", "GRN Approved", "GRN On-Hold", "GRN Rejected", "Under Release", "Release Complete", "GRN Cancelled" })
			Me.cmbStatus.Location = New Global.System.Drawing.Point(180, 108)
			Me.cmbStatus.Name = "cmbStatus"
			Me.cmbStatus.Size = New Global.System.Drawing.Size(189, 23)
			Me.cmbStatus.TabIndex = 4
			Me.Label11.AutoSize = True
			Me.Label11.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label11.Location = New Global.System.Drawing.Point(34, 111)
			Me.Label11.Name = "Label11"
			Me.Label11.Size = New Global.System.Drawing.Size(43, 15)
			Me.Label11.TabIndex = 1033
			Me.Label11.Text = "Status"
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.Location = New Global.System.Drawing.Point(395, 30)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(73, 15)
			Me.Label3.TabIndex = 513
			Me.Label3.Text = "Challan No."
			Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.cmbVendor.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbVendor.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbVendor.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbVendor.FormattingEnabled = True
			Me.cmbVendor.Location = New Global.System.Drawing.Point(180, 54)
			Me.cmbVendor.Name = "cmbVendor"
			Me.cmbVendor.Size = New Global.System.Drawing.Size(489, 23)
			Me.cmbVendor.TabIndex = 2
			Me.txtChallanNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtChallanNo.Location = New Global.System.Drawing.Point(480, 28)
			Me.txtChallanNo.Name = "txtChallanNo"
			Me.txtChallanNo.Size = New Global.System.Drawing.Size(189, 21)
			Me.txtChallanNo.TabIndex = 1
			Me.Label9.AutoSize = True
			Me.Label9.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label9.Location = New Global.System.Drawing.Point(34, 57)
			Me.Label9.Name = "Label9"
			Me.Label9.Size = New Global.System.Drawing.Size(48, 15)
			Me.Label9.TabIndex = 1029
			Me.Label9.Text = "Vendor"
			Me.Label4.AutoSize = True
			Me.Label4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label4.Location = New Global.System.Drawing.Point(675, 31)
			Me.Label4.Name = "Label4"
			Me.Label4.Size = New Global.System.Drawing.Size(72, 15)
			Me.Label4.TabIndex = 511
			Me.Label4.Text = "Invoice No."
			Me.Label4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label4.Visible = False
			Me.txtCreated.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtCreated.Location = New Global.System.Drawing.Point(180, 82)
			Me.txtCreated.Name = "txtCreated"
			Me.txtCreated.Size = New Global.System.Drawing.Size(489, 21)
			Me.txtCreated.TabIndex = 3
			Me.txtInvoiceNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtInvoiceNo.Location = New Global.System.Drawing.Point(763, 28)
			Me.txtInvoiceNo.Name = "txtInvoiceNo"
			Me.txtInvoiceNo.Size = New Global.System.Drawing.Size(65, 21)
			Me.txtInvoiceNo.TabIndex = 0
			Me.txtInvoiceNo.Visible = False
			Me.lblCreated.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.lblCreated.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.lblCreated.BackColor = Global.System.Drawing.Color.White
			Me.lblCreated.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.lblCreated.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.lblCreated.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblCreated.FormattingEnabled = True
			Me.lblCreated.Items.AddRange(New Object() { "Created By", "Last Modified By" })
			Me.lblCreated.Location = New Global.System.Drawing.Point(33, 81)
			Me.lblCreated.Name = "lblCreated"
			Me.lblCreated.Size = New Global.System.Drawing.Size(144, 23)
			Me.lblCreated.TabIndex = 510
			Me.arrow_btnAdvanceExp_sml.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.arrow_btnAdvanceExp_sml.FlatAppearance.BorderSize = 0
			Me.arrow_btnAdvanceExp_sml.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.Transparent
			Me.arrow_btnAdvanceExp_sml.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.Transparent
			Me.arrow_btnAdvanceExp_sml.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.arrow_btnAdvanceExp_sml.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.arrow_btnAdvanceExp_sml.ForeColor = Global.System.Drawing.Color.White
			Me.arrow_btnAdvanceExp_sml.Location = New Global.System.Drawing.Point(8, 0)
			Me.arrow_btnAdvanceExp_sml.Name = "arrow_btnAdvanceExp_sml"
			Me.arrow_btnAdvanceExp_sml.Size = New Global.System.Drawing.Size(20, 20)
			Me.arrow_btnAdvanceExp_sml.TabIndex = 4
			Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
			Me.arrow_btnAdvanceExp_sml.UseVisualStyleBackColor = True
			Me.grpListButton.Controls.Add(Me.FlowLayoutPanel1)
			Me.grpListButton.Controls.Add(Me.lblRows)
			Me.grpListButton.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.grpListButton.Location = New Global.System.Drawing.Point(0, 271)
			Me.grpListButton.Name = "grpListButton"
			Me.grpListButton.Size = New Global.System.Drawing.Size(1000, 49)
			Me.grpListButton.TabIndex = 10
			Me.grpListButton.TabStop = False
			Me.FlowLayoutPanel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
			Me.FlowLayoutPanel1.Controls.Add(Me.btnWithoutPO)
			Me.FlowLayoutPanel1.Controls.Add(Me.btnWithPO)
			Me.FlowLayoutPanel1.Controls.Add(Me.btnGRNBMR)
			Me.FlowLayoutPanel1.Controls.Add(Me.btnSearch)
			Me.FlowLayoutPanel1.Controls.Add(Me.btnClearList)
			Me.FlowLayoutPanel1.Controls.Add(Me.btnExport)
			Me.FlowLayoutPanel1.Location = New Global.System.Drawing.Point(6, 11)
			Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
			Me.FlowLayoutPanel1.Size = New Global.System.Drawing.Size(840, 35)
			Me.FlowLayoutPanel1.TabIndex = 0
			Me.btnWithoutPO.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnWithoutPO.Location = New Global.System.Drawing.Point(0, 3)
			Me.btnWithoutPO.Margin = New Global.System.Windows.Forms.Padding(0, 3, 2, 3)
			Me.btnWithoutPO.Name = "btnWithoutPO"
			Me.btnWithoutPO.Size = New Global.System.Drawing.Size(150, 29)
			Me.btnWithoutPO.TabIndex = 5
			Me.btnWithoutPO.Text = "GRN Without P.O."
			Me.btnWithoutPO.UseVisualStyleBackColor = True
			Me.btnWithoutPO.Visible = False
			Me.btnWithPO.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnWithPO.Location = New Global.System.Drawing.Point(152, 3)
			Me.btnWithPO.Margin = New Global.System.Windows.Forms.Padding(0, 3, 2, 3)
			Me.btnWithPO.Name = "btnWithPO"
			Me.btnWithPO.Size = New Global.System.Drawing.Size(144, 29)
			Me.btnWithPO.TabIndex = 4
			Me.btnWithPO.Text = "Search P.O."
			Me.btnWithPO.UseVisualStyleBackColor = True
			Me.btnWithPO.Visible = False
			Me.btnGRNBMR.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnGRNBMR.Location = New Global.System.Drawing.Point(298, 3)
			Me.btnGRNBMR.Margin = New Global.System.Windows.Forms.Padding(0, 3, 2, 3)
			Me.btnGRNBMR.Name = "btnGRNBMR"
			Me.btnGRNBMR.Size = New Global.System.Drawing.Size(150, 29)
			Me.btnGRNBMR.TabIndex = 6
			Me.btnGRNBMR.Text = "GRN Against BMR"
			Me.btnGRNBMR.UseVisualStyleBackColor = True
			Me.btnGRNBMR.Visible = False
			Me.btnSearch.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnSearch.Location = New Global.System.Drawing.Point(450, 3)
			Me.btnSearch.Margin = New Global.System.Windows.Forms.Padding(0, 3, 2, 3)
			Me.btnSearch.Name = "btnSearch"
			Me.btnSearch.Size = New Global.System.Drawing.Size(106, 29)
			Me.btnSearch.TabIndex = 1
			Me.btnSearch.Text = "Search"
			Me.btnSearch.UseVisualStyleBackColor = True
			Me.btnClearList.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClearList.Location = New Global.System.Drawing.Point(558, 3)
			Me.btnClearList.Margin = New Global.System.Windows.Forms.Padding(0, 3, 2, 3)
			Me.btnClearList.Name = "btnClearList"
			Me.btnClearList.Size = New Global.System.Drawing.Size(106, 29)
			Me.btnClearList.TabIndex = 2
			Me.btnClearList.Text = "Clear"
			Me.btnClearList.UseVisualStyleBackColor = True
			Me.btnExport.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnExport.Location = New Global.System.Drawing.Point(666, 3)
			Me.btnExport.Margin = New Global.System.Windows.Forms.Padding(0, 3, 2, 3)
			Me.btnExport.Name = "btnExport"
			Me.btnExport.Size = New Global.System.Drawing.Size(116, 29)
			Me.btnExport.TabIndex = 3
			Me.btnExport.Text = "Export XL"
			Me.btnExport.UseVisualStyleBackColor = True
			Me.lblRows.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblRows.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRows.Location = New Global.System.Drawing.Point(866, 21)
			Me.lblRows.Name = "lblRows"
			Me.lblRows.Size = New Global.System.Drawing.Size(126, 15)
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
			Me.dgvList.ColumnHeadersHeight = 35
			Me.dgvList.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.dgvList.Location = New Global.System.Drawing.Point(0, 320)
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
			Me.dgvList.Size = New Global.System.Drawing.Size(1000, 201)
			Me.dgvList.TabIndex = 11
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			MyBase.ClientSize = New Global.System.Drawing.Size(1000, 521)
			MyBase.Controls.Add(Me.dgvList)
			MyBase.Controls.Add(Me.grpListButton)
			MyBase.Controls.Add(Me.GbAdvanced)
			MyBase.Controls.Add(Me.GbBasic)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.Name = "GRNList"
			Me.Text = "GRN List"
			Me.GbBasic.ResumeLayout(False)
			Me.GbBasic.PerformLayout()
			Me.GbAdvanced.ResumeLayout(False)
			Me.GbAdvanced.PerformLayout()
			Me.pnlItem.ResumeLayout(False)
			Me.pnlItem.PerformLayout()
			Me.grpListButton.ResumeLayout(False)
			Me.FlowLayoutPanel1.ResumeLayout(False)
			CType(Me.dgvList, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000A12 RID: 2578
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
