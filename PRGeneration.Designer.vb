Namespace Datasoft_PIMS
	' Token: 0x02000058 RID: 88
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class PRGeneration
		Inherits Global.WeifenLuo.WinFormsUI.Docking.DockContent

		' Token: 0x06001237 RID: 4663 RVA: 0x000A7C54 File Offset: 0x000A5E54
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

		' Token: 0x06001238 RID: 4664 RVA: 0x000A7CA4 File Offset: 0x000A5EA4
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
			Me.grpPO = New Global.System.Windows.Forms.GroupBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.cmbManager = New Global.System.Windows.Forms.ComboBox()
			Me.skip_Label12 = New Global.System.Windows.Forms.Label()
			Me.cmbVendor = New Global.System.Windows.Forms.ComboBox()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.cmbRequestedBy = New Global.System.Windows.Forms.ComboBox()
			Me.skip_lblStatus = New Global.System.Windows.Forms.Label()
			Me.skip_lblPO = New Global.System.Windows.Forms.Label()
			Me.txtID = New Global.System.Windows.Forms.TextBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.cmbDept = New Global.System.Windows.Forms.ComboBox()
			Me.dtpDt = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label28 = New Global.System.Windows.Forms.Label()
			Me.Label27 = New Global.System.Windows.Forms.Label()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.txtNo = New Global.System.Windows.Forms.TextBox()
			Me.dtpRequiredBy = New Global.System.Windows.Forms.DateTimePicker()
			Me.grpItems = New Global.System.Windows.Forms.GroupBox()
			Me.flpButton = New Global.System.Windows.Forms.FlowLayoutPanel()
			Me.btnSave = New Global.System.Windows.Forms.Button()
			Me.btnApprove = New Global.System.Windows.Forms.Button()
			Me.btnOnHold = New Global.System.Windows.Forms.Button()
			Me.btnReject = New Global.System.Windows.Forms.Button()
			Me.btnClear = New Global.System.Windows.Forms.Button()
			Me.btnCancel = New Global.System.Windows.Forms.Button()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.txtTotal = New Global.System.Windows.Forms.TextBox()
			Me.Label38 = New Global.System.Windows.Forms.Label()
			Me.Panel3 = New Global.System.Windows.Forms.Panel()
			Me.theme_tc = New Global.System.Windows.Forms.TabControl()
			Me.tpItems = New Global.System.Windows.Forms.TabPage()
			Me.tab_lbl3 = New Global.System.Windows.Forms.Label()
			Me.dgvDtls = New Global.System.Windows.Forms.DataGridView()
			Me.SrNo = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ProductID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ProductType = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ProductCode = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ProductName = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Description = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.HSNSACCode = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.TertiaryUOM = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.TertiaryPackSize = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.PrimaryUOM = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.PrimaryPackSize = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.UnitPrice = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Quantity = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.BasicValue = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.TaxPer = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.TaxAmt = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.NetAmt = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.OtherCharges = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.FinalAmt = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.llbAdd = New Global.System.Windows.Forms.LinkLabel()
			Me.tpDoc = New Global.System.Windows.Forms.TabPage()
			Me.tab_lbl5 = New Global.System.Windows.Forms.Label()
			Me.llbFile = New Global.System.Windows.Forms.LinkLabel()
			Me.dgvFile = New Global.System.Windows.Forms.DataGridView()
			Me.FileID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.btnDownload_File = New Global.System.Windows.Forms.DataGridViewImageColumn()
			Me.FileName = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.btnDelete_File = New Global.System.Windows.Forms.DataGridViewImageColumn()
			Me.tpRemarks = New Global.System.Windows.Forms.TabPage()
			Me.tab_lbl6 = New Global.System.Windows.Forms.Label()
			Me.lblRemarksApproval1 = New Global.System.Windows.Forms.Label()
			Me.lblRemarks1 = New Global.System.Windows.Forms.Label()
			Me.Panel4 = New Global.System.Windows.Forms.Panel()
			Me.txtRemarksApproval = New Global.System.Windows.Forms.TextBox()
			Me.txtRemarks = New Global.System.Windows.Forms.TextBox()
			Me.lblRemarks = New Global.System.Windows.Forms.Label()
			Me.lblRemarksApproval = New Global.System.Windows.Forms.Label()
			Me.grpPO.SuspendLayout()
			Me.grpItems.SuspendLayout()
			Me.flpButton.SuspendLayout()
			Me.Panel3.SuspendLayout()
			Me.theme_tc.SuspendLayout()
			Me.tpItems.SuspendLayout()
			CType(Me.dgvDtls, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tpDoc.SuspendLayout()
			CType(Me.dgvFile, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tpRemarks.SuspendLayout()
			Me.Panel4.SuspendLayout()
			MyBase.SuspendLayout()
			Me.grpPO.Controls.Add(Me.Label2)
			Me.grpPO.Controls.Add(Me.cmbManager)
			Me.grpPO.Controls.Add(Me.skip_Label12)
			Me.grpPO.Controls.Add(Me.cmbVendor)
			Me.grpPO.Controls.Add(Me.Label9)
			Me.grpPO.Controls.Add(Me.Label1)
			Me.grpPO.Controls.Add(Me.cmbRequestedBy)
			Me.grpPO.Controls.Add(Me.skip_lblStatus)
			Me.grpPO.Controls.Add(Me.skip_lblPO)
			Me.grpPO.Controls.Add(Me.txtID)
			Me.grpPO.Controls.Add(Me.Label3)
			Me.grpPO.Controls.Add(Me.cmbDept)
			Me.grpPO.Controls.Add(Me.dtpDt)
			Me.grpPO.Controls.Add(Me.Label28)
			Me.grpPO.Controls.Add(Me.Label27)
			Me.grpPO.Controls.Add(Me.Label5)
			Me.grpPO.Controls.Add(Me.txtNo)
			Me.grpPO.Controls.Add(Me.dtpRequiredBy)
			Me.grpPO.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.grpPO.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.grpPO.Location = New Global.System.Drawing.Point(0, 0)
			Me.grpPO.Name = "grpPO"
			Me.grpPO.Size = New Global.System.Drawing.Size(1097, 181)
			Me.grpPO.TabIndex = 0
			Me.grpPO.TabStop = False
			Me.grpPO.Text = "P.O. Details"
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.Location = New Global.System.Drawing.Point(16, 122)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(80, 15)
			Me.Label2.TabIndex = 1110
			Me.Label2.Text = "Reporting To"
			Me.cmbManager.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbManager.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbManager.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbManager.FormattingEnabled = True
			Me.cmbManager.Location = New Global.System.Drawing.Point(107, 119)
			Me.cmbManager.Name = "cmbManager"
			Me.cmbManager.Size = New Global.System.Drawing.Size(478, 23)
			Me.cmbManager.TabIndex = 1109
			Me.cmbManager.TabStop = False
			Me.skip_Label12.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.skip_Label12.ForeColor = Global.System.Drawing.Color.Red
			Me.skip_Label12.Location = New Global.System.Drawing.Point(3, 64)
			Me.skip_Label12.Name = "skip_Label12"
			Me.skip_Label12.Size = New Global.System.Drawing.Size(12, 15)
			Me.skip_Label12.TabIndex = 25
			Me.skip_Label12.Text = "*"
			Me.skip_Label12.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.cmbVendor.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbVendor.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbVendor.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbVendor.FormattingEnabled = True
			Me.cmbVendor.Items.AddRange(New Object() { "", "Vendor 1", "Vendor 2", "Vendor 3" })
			Me.cmbVendor.Location = New Global.System.Drawing.Point(107, 148)
			Me.cmbVendor.Name = "cmbVendor"
			Me.cmbVendor.Size = New Global.System.Drawing.Size(478, 23)
			Me.cmbVendor.TabIndex = 5
			Me.Label9.AutoSize = True
			Me.Label9.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label9.Location = New Global.System.Drawing.Point(16, 151)
			Me.Label9.Name = "Label9"
			Me.Label9.Size = New Global.System.Drawing.Size(48, 15)
			Me.Label9.TabIndex = 1108
			Me.Label9.Text = "Vendor"
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.Location = New Global.System.Drawing.Point(16, 64)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(86, 15)
			Me.Label1.TabIndex = 1106
			Me.Label1.Text = "Requested By"
			Me.cmbRequestedBy.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbRequestedBy.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbRequestedBy.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbRequestedBy.FormattingEnabled = True
			Me.cmbRequestedBy.Location = New Global.System.Drawing.Point(107, 61)
			Me.cmbRequestedBy.Name = "cmbRequestedBy"
			Me.cmbRequestedBy.Size = New Global.System.Drawing.Size(218, 23)
			Me.cmbRequestedBy.TabIndex = 2
			Me.skip_lblStatus.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.skip_lblStatus.BackColor = Global.System.Drawing.Color.FromArgb(13, 57, 89)
			Me.skip_lblStatus.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.skip_lblStatus.ForeColor = Global.System.Drawing.Color.White
			Me.skip_lblStatus.Location = New Global.System.Drawing.Point(775, 1)
			Me.skip_lblStatus.Name = "skip_lblStatus"
			Me.skip_lblStatus.Size = New Global.System.Drawing.Size(320, 24)
			Me.skip_lblStatus.TabIndex = 1080
			Me.skip_lblStatus.Text = "New P.R."
			Me.skip_lblStatus.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.skip_lblPO.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.skip_lblPO.BackColor = Global.System.Drawing.Color.FromArgb(13, 57, 89)
			Me.skip_lblPO.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.skip_lblPO.ForeColor = Global.System.Drawing.Color.White
			Me.skip_lblPO.Location = New Global.System.Drawing.Point(1, 1)
			Me.skip_lblPO.Name = "skip_lblPO"
			Me.skip_lblPO.Size = New Global.System.Drawing.Size(1094, 24)
			Me.skip_lblPO.TabIndex = 1104
			Me.skip_lblPO.Text = " P.R. Details"
			Me.skip_lblPO.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.txtID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtID.Location = New Global.System.Drawing.Point(624, 34)
			Me.txtID.Name = "txtID"
			Me.txtID.Size = New Global.System.Drawing.Size(34, 21)
			Me.txtID.TabIndex = 1099
			Me.txtID.TabStop = False
			Me.txtID.Visible = False
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.Location = New Global.System.Drawing.Point(16, 93)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(75, 15)
			Me.Label3.TabIndex = 1097
			Me.Label3.Text = "Department"
			Me.cmbDept.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbDept.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbDept.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbDept.FormattingEnabled = True
			Me.cmbDept.Location = New Global.System.Drawing.Point(107, 90)
			Me.cmbDept.Name = "cmbDept"
			Me.cmbDept.Size = New Global.System.Drawing.Size(478, 23)
			Me.cmbDept.TabIndex = 4
			Me.dtpDt.CustomFormat = "dd   MMM   yyyy"
			Me.dtpDt.Enabled = False
			Me.dtpDt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpDt.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpDt.Location = New Global.System.Drawing.Point(433, 34)
			Me.dtpDt.Name = "dtpDt"
			Me.dtpDt.Size = New Global.System.Drawing.Size(152, 21)
			Me.dtpDt.TabIndex = 1
			Me.Label28.AutoSize = True
			Me.Label28.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label28.Location = New Global.System.Drawing.Point(331, 37)
			Me.Label28.Name = "Label28"
			Me.Label28.Size = New Global.System.Drawing.Size(61, 15)
			Me.Label28.TabIndex = 1088
			Me.Label28.Text = "P.R. Date"
			Me.Label28.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label27.AutoSize = True
			Me.Label27.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label27.Location = New Global.System.Drawing.Point(16, 37)
			Me.Label27.Name = "Label27"
			Me.Label27.Size = New Global.System.Drawing.Size(53, 15)
			Me.Label27.TabIndex = 1089
			Me.Label27.Text = "P.R. No."
			Me.Label5.AutoSize = True
			Me.Label5.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label5.Location = New Global.System.Drawing.Point(331, 64)
			Me.Label5.Name = "Label5"
			Me.Label5.Size = New Global.System.Drawing.Size(77, 15)
			Me.Label5.TabIndex = 1093
			Me.Label5.Text = "Required By"
			Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.txtNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtNo.Location = New Global.System.Drawing.Point(107, 34)
			Me.txtNo.Name = "txtNo"
			Me.txtNo.[ReadOnly] = True
			Me.txtNo.Size = New Global.System.Drawing.Size(218, 21)
			Me.txtNo.TabIndex = 0
			Me.dtpRequiredBy.Checked = False
			Me.dtpRequiredBy.CustomFormat = "dd   MMM   yyyy"
			Me.dtpRequiredBy.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpRequiredBy.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpRequiredBy.Location = New Global.System.Drawing.Point(433, 62)
			Me.dtpRequiredBy.Name = "dtpRequiredBy"
			Me.dtpRequiredBy.ShowCheckBox = True
			Me.dtpRequiredBy.Size = New Global.System.Drawing.Size(152, 21)
			Me.dtpRequiredBy.TabIndex = 3
			Me.grpItems.Controls.Add(Me.flpButton)
			Me.grpItems.Controls.Add(Me.txtTotal)
			Me.grpItems.Controls.Add(Me.Label38)
			Me.grpItems.Controls.Add(Me.Panel3)
			Me.grpItems.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.grpItems.Location = New Global.System.Drawing.Point(0, 181)
			Me.grpItems.Name = "grpItems"
			Me.grpItems.Size = New Global.System.Drawing.Size(1097, 390)
			Me.grpItems.TabIndex = 1
			Me.grpItems.TabStop = False
			Me.flpButton.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.flpButton.Controls.Add(Me.btnSave)
			Me.flpButton.Controls.Add(Me.btnApprove)
			Me.flpButton.Controls.Add(Me.btnOnHold)
			Me.flpButton.Controls.Add(Me.btnReject)
			Me.flpButton.Controls.Add(Me.btnClear)
			Me.flpButton.Controls.Add(Me.btnCancel)
			Me.flpButton.Controls.Add(Me.btnClose)
			Me.flpButton.Location = New Global.System.Drawing.Point(145, 338)
			Me.flpButton.Name = "flpButton"
			Me.flpButton.Size = New Global.System.Drawing.Size(806, 39)
			Me.flpButton.TabIndex = 1108
			Me.btnSave.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnSave.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnSave.Location = New Global.System.Drawing.Point(3, 3)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New Global.System.Drawing.Size(109, 33)
			Me.btnSave.TabIndex = 1085
			Me.btnSave.Text = "Save"
			Me.btnSave.UseVisualStyleBackColor = True
			Me.btnApprove.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnApprove.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnApprove.Location = New Global.System.Drawing.Point(118, 3)
			Me.btnApprove.Name = "btnApprove"
			Me.btnApprove.Size = New Global.System.Drawing.Size(109, 33)
			Me.btnApprove.TabIndex = 1086
			Me.btnApprove.Text = "Approve"
			Me.btnApprove.UseVisualStyleBackColor = True
			Me.btnOnHold.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnOnHold.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnOnHold.Location = New Global.System.Drawing.Point(233, 3)
			Me.btnOnHold.Name = "btnOnHold"
			Me.btnOnHold.Size = New Global.System.Drawing.Size(109, 33)
			Me.btnOnHold.TabIndex = 1094
			Me.btnOnHold.Text = "On-Hold"
			Me.btnOnHold.UseVisualStyleBackColor = True
			Me.btnReject.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnReject.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnReject.Location = New Global.System.Drawing.Point(348, 3)
			Me.btnReject.Name = "btnReject"
			Me.btnReject.Size = New Global.System.Drawing.Size(109, 33)
			Me.btnReject.TabIndex = 1087
			Me.btnReject.Text = "Reject"
			Me.btnReject.UseVisualStyleBackColor = True
			Me.btnClear.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnClear.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClear.Location = New Global.System.Drawing.Point(463, 3)
			Me.btnClear.Name = "btnClear"
			Me.btnClear.Size = New Global.System.Drawing.Size(109, 33)
			Me.btnClear.TabIndex = 1093
			Me.btnClear.Text = "Clear"
			Me.btnClear.UseVisualStyleBackColor = True
			Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnCancel.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnCancel.Location = New Global.System.Drawing.Point(578, 3)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New Global.System.Drawing.Size(109, 33)
			Me.btnCancel.TabIndex = 1088
			Me.btnCancel.Text = "Cancel PR"
			Me.btnCancel.UseVisualStyleBackColor = True
			Me.btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnClose.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClose.Location = New Global.System.Drawing.Point(693, 3)
			Me.btnClose.Name = "btnClose"
			Me.btnClose.Size = New Global.System.Drawing.Size(109, 33)
			Me.btnClose.TabIndex = 1089
			Me.btnClose.Text = "C&lose"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.txtTotal.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtTotal.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Upper
			Me.txtTotal.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtTotal.Location = New Global.System.Drawing.Point(834, 292)
			Me.txtTotal.Name = "txtTotal"
			Me.txtTotal.[ReadOnly] = True
			Me.txtTotal.Size = New Global.System.Drawing.Size(255, 21)
			Me.txtTotal.TabIndex = 1107
			Me.Label38.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label38.AutoSize = True
			Me.Label38.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label38.Location = New Global.System.Drawing.Point(706, 295)
			Me.Label38.Name = "Label38"
			Me.Label38.Size = New Global.System.Drawing.Size(113, 15)
			Me.Label38.TabIndex = 1106
			Me.Label38.Text = "Total Final Amount"
			Me.Panel3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Panel3.Controls.Add(Me.theme_tc)
			Me.Panel3.Location = New Global.System.Drawing.Point(6, 13)
			Me.Panel3.Name = "Panel3"
			Me.Panel3.Size = New Global.System.Drawing.Size(1083, 272)
			Me.Panel3.TabIndex = 1104
			Me.theme_tc.Controls.Add(Me.tpItems)
			Me.theme_tc.Controls.Add(Me.tpDoc)
			Me.theme_tc.Controls.Add(Me.tpRemarks)
			Me.theme_tc.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.theme_tc.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.theme_tc.ItemSize = New Global.System.Drawing.Size(180, 25)
			Me.theme_tc.Location = New Global.System.Drawing.Point(0, 0)
			Me.theme_tc.Name = "theme_tc"
			Me.theme_tc.SelectedIndex = 0
			Me.theme_tc.Size = New Global.System.Drawing.Size(1083, 272)
			Me.theme_tc.SizeMode = Global.System.Windows.Forms.TabSizeMode.Fixed
			Me.theme_tc.TabIndex = 0
			Me.tpItems.BackColor = Global.System.Drawing.Color.Transparent
			Me.tpItems.Controls.Add(Me.tab_lbl3)
			Me.tpItems.Controls.Add(Me.dgvDtls)
			Me.tpItems.Controls.Add(Me.llbAdd)
			Me.tpItems.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.tpItems.Location = New Global.System.Drawing.Point(4, 29)
			Me.tpItems.Name = "tpItems"
			Me.tpItems.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tpItems.Size = New Global.System.Drawing.Size(1075, 239)
			Me.tpItems.TabIndex = 0
			Me.tpItems.Text = "Item Details"
			Me.tpItems.UseVisualStyleBackColor = True
			Me.tab_lbl3.BackColor = Global.System.Drawing.Color.Black
			Me.tab_lbl3.ForeColor = Global.System.Drawing.Color.PaleGreen
			Me.tab_lbl3.Location = New Global.System.Drawing.Point(0, 0)
			Me.tab_lbl3.Name = "tab_lbl3"
			Me.tab_lbl3.Size = New Global.System.Drawing.Size(1076, 3)
			Me.tab_lbl3.TabIndex = 2
			Me.dgvDtls.AllowUserToAddRows = False
			Me.dgvDtls.AllowUserToDeleteRows = False
			Me.dgvDtls.AllowUserToResizeRows = False
			Me.dgvDtls.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
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
			Me.dgvDtls.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.SrNo, Me.ProductID, Me.ProductType, Me.ProductCode, Me.ProductName, Me.Description, Me.HSNSACCode, Me.TertiaryUOM, Me.TertiaryPackSize, Me.PrimaryUOM, Me.PrimaryPackSize, Me.UnitPrice, Me.Quantity, Me.BasicValue, Me.TaxPer, Me.TaxAmt, Me.NetAmt, Me.OtherCharges, Me.FinalAmt })
			Me.dgvDtls.Location = New Global.System.Drawing.Point(4, 33)
			Me.dgvDtls.Name = "dgvDtls"
			Me.dgvDtls.[ReadOnly] = True
			Me.dgvDtls.RowHeadersWidth = 30
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dgvDtls.RowsDefaultCellStyle = dataGridViewCellStyle2
			Me.dgvDtls.Size = New Global.System.Drawing.Size(1068, 203)
			Me.dgvDtls.TabIndex = 0
			Me.SrNo.DataPropertyName = "SrNo"
			dataGridViewCellStyle3.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.SrNo.DefaultCellStyle = dataGridViewCellStyle3
			Me.SrNo.HeaderText = "Sr. No."
			Me.SrNo.Name = "SrNo"
			Me.SrNo.[ReadOnly] = True
			Me.SrNo.Width = 45
			Me.ProductID.DataPropertyName = "ProductID"
			Me.ProductID.HeaderText = "ProductID"
			Me.ProductID.Name = "ProductID"
			Me.ProductID.[ReadOnly] = True
			Me.ProductID.Visible = False
			Me.ProductType.DataPropertyName = "ProductType"
			Me.ProductType.HeaderText = "Product Type"
			Me.ProductType.Name = "ProductType"
			Me.ProductType.[ReadOnly] = True
			Me.ProductType.Width = 120
			Me.ProductCode.DataPropertyName = "ProductCode"
			Me.ProductCode.HeaderText = "Product Code"
			Me.ProductCode.Name = "ProductCode"
			Me.ProductCode.[ReadOnly] = True
			Me.ProductCode.Width = 130
			Me.ProductName.DataPropertyName = "ProductName"
			Me.ProductName.HeaderText = "Product/ Service"
			Me.ProductName.Name = "ProductName"
			Me.ProductName.[ReadOnly] = True
			Me.ProductName.Width = 250
			Me.Description.DataPropertyName = "Description"
			dataGridViewCellStyle4.Padding = New Global.System.Windows.Forms.Padding(0, 2, 0, 2)
			dataGridViewCellStyle4.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.Description.DefaultCellStyle = dataGridViewCellStyle4
			Me.Description.HeaderText = "Description"
			Me.Description.Name = "Description"
			Me.Description.[ReadOnly] = True
			Me.Description.Width = 300
			Me.HSNSACCode.DataPropertyName = "HSNSACCode"
			Me.HSNSACCode.HeaderText = "HSN/ SAC Code"
			Me.HSNSACCode.Name = "HSNSACCode"
			Me.HSNSACCode.[ReadOnly] = True
			Me.HSNSACCode.Width = 120
			Me.TertiaryUOM.DataPropertyName = "TertiaryUOM"
			Me.TertiaryUOM.HeaderText = "Tertiary UOM"
			Me.TertiaryUOM.Name = "TertiaryUOM"
			Me.TertiaryUOM.[ReadOnly] = True
			Me.TertiaryUOM.Width = 60
			Me.TertiaryPackSize.DataPropertyName = "TertiaryPackSize"
			Me.TertiaryPackSize.HeaderText = "Tertiary PackSize"
			Me.TertiaryPackSize.Name = "TertiaryPackSize"
			Me.TertiaryPackSize.[ReadOnly] = True
			Me.TertiaryPackSize.Visible = False
			Me.PrimaryUOM.DataPropertyName = "PrimaryUOM"
			Me.PrimaryUOM.HeaderText = "Primary UOM"
			Me.PrimaryUOM.Name = "PrimaryUOM"
			Me.PrimaryUOM.[ReadOnly] = True
			Me.PrimaryUOM.Visible = False
			Me.PrimaryPackSize.DataPropertyName = "PrimaryPackSize"
			Me.PrimaryPackSize.HeaderText = "Primary PackSize"
			Me.PrimaryPackSize.Name = "PrimaryPackSize"
			Me.PrimaryPackSize.[ReadOnly] = True
			Me.PrimaryPackSize.Visible = False
			Me.UnitPrice.DataPropertyName = "UnitPrice"
			dataGridViewCellStyle5.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.UnitPrice.DefaultCellStyle = dataGridViewCellStyle5
			Me.UnitPrice.HeaderText = "Tertiary Unit Price"
			Me.UnitPrice.Name = "UnitPrice"
			Me.UnitPrice.[ReadOnly] = True
			Me.UnitPrice.Width = 70
			Me.Quantity.DataPropertyName = "Quantity"
			dataGridViewCellStyle6.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.Quantity.DefaultCellStyle = dataGridViewCellStyle6
			Me.Quantity.HeaderText = "Tertiary Quantity"
			Me.Quantity.Name = "Quantity"
			Me.Quantity.[ReadOnly] = True
			Me.Quantity.Width = 60
			Me.BasicValue.DataPropertyName = "BasicValue"
			dataGridViewCellStyle7.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.BasicValue.DefaultCellStyle = dataGridViewCellStyle7
			Me.BasicValue.HeaderText = "Basic Value"
			Me.BasicValue.Name = "BasicValue"
			Me.BasicValue.[ReadOnly] = True
			Me.TaxPer.DataPropertyName = "TaxPer"
			dataGridViewCellStyle8.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.TaxPer.DefaultCellStyle = dataGridViewCellStyle8
			Me.TaxPer.HeaderText = "Tax %"
			Me.TaxPer.Name = "TaxPer"
			Me.TaxPer.[ReadOnly] = True
			Me.TaxAmt.DataPropertyName = "TaxAmt"
			dataGridViewCellStyle9.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.TaxAmt.DefaultCellStyle = dataGridViewCellStyle9
			Me.TaxAmt.HeaderText = "Tax Amount"
			Me.TaxAmt.Name = "TaxAmt"
			Me.TaxAmt.[ReadOnly] = True
			Me.NetAmt.DataPropertyName = "NetAmt"
			dataGridViewCellStyle10.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.NetAmt.DefaultCellStyle = dataGridViewCellStyle10
			Me.NetAmt.HeaderText = "Net Amount"
			Me.NetAmt.Name = "NetAmt"
			Me.NetAmt.[ReadOnly] = True
			Me.OtherCharges.DataPropertyName = "OtherCharges"
			dataGridViewCellStyle11.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.OtherCharges.DefaultCellStyle = dataGridViewCellStyle11
			Me.OtherCharges.HeaderText = "Other Charges"
			Me.OtherCharges.Name = "OtherCharges"
			Me.OtherCharges.[ReadOnly] = True
			Me.FinalAmt.DataPropertyName = "FinalAmt"
			dataGridViewCellStyle12.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.FinalAmt.DefaultCellStyle = dataGridViewCellStyle12
			Me.FinalAmt.HeaderText = "Final Amount"
			Me.FinalAmt.Name = "FinalAmt"
			Me.FinalAmt.[ReadOnly] = True
			Me.llbAdd.ActiveLinkColor = Global.System.Drawing.Color.Maroon
			Me.llbAdd.AutoSize = True
			Me.llbAdd.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.llbAdd.LinkColor = Global.System.Drawing.Color.Maroon
			Me.llbAdd.Location = New Global.System.Drawing.Point(6, 17)
			Me.llbAdd.Name = "llbAdd"
			Me.llbAdd.Size = New Global.System.Drawing.Size(68, 15)
			Me.llbAdd.TabIndex = 1
			Me.llbAdd.TabStop = True
			Me.llbAdd.Text = "Add Item"
			Me.tpDoc.BackColor = Global.System.Drawing.Color.Transparent
			Me.tpDoc.Controls.Add(Me.tab_lbl5)
			Me.tpDoc.Controls.Add(Me.llbFile)
			Me.tpDoc.Controls.Add(Me.dgvFile)
			Me.tpDoc.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.tpDoc.Location = New Global.System.Drawing.Point(4, 29)
			Me.tpDoc.Name = "tpDoc"
			Me.tpDoc.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tpDoc.Size = New Global.System.Drawing.Size(1075, 239)
			Me.tpDoc.TabIndex = 2
			Me.tpDoc.Text = "Documents"
			Me.tpDoc.UseVisualStyleBackColor = True
			Me.tab_lbl5.BackColor = Global.System.Drawing.Color.Black
			Me.tab_lbl5.ForeColor = Global.System.Drawing.Color.PaleGreen
			Me.tab_lbl5.Location = New Global.System.Drawing.Point(0, 0)
			Me.tab_lbl5.Name = "tab_lbl5"
			Me.tab_lbl5.Size = New Global.System.Drawing.Size(1076, 3)
			Me.tab_lbl5.TabIndex = 34
			Me.llbFile.ActiveLinkColor = Global.System.Drawing.Color.Maroon
			Me.llbFile.AutoSize = True
			Me.llbFile.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.llbFile.LinkColor = Global.System.Drawing.Color.Maroon
			Me.llbFile.Location = New Global.System.Drawing.Point(6, 17)
			Me.llbFile.Name = "llbFile"
			Me.llbFile.Size = New Global.System.Drawing.Size(77, 15)
			Me.llbFile.TabIndex = 3
			Me.llbFile.TabStop = True
			Me.llbFile.Text = "Attach File"
			Me.dgvFile.AllowUserToAddRows = False
			Me.dgvFile.AllowUserToDeleteRows = False
			Me.dgvFile.AllowUserToResizeRows = False
			Me.dgvFile.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.dgvFile.BackgroundColor = Global.System.Drawing.Color.WhiteSmoke
			dataGridViewCellStyle13.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle13.BackColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle13.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle13.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle13.SelectionBackColor = Global.System.Drawing.SystemColors.GradientInactiveCaption
			dataGridViewCellStyle13.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle13.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvFile.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13
			Me.dgvFile.ColumnHeadersHeight = 25
			Me.dgvFile.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.dgvFile.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.FileID, Me.btnDownload_File, Me.FileName, Me.btnDelete_File })
			Me.dgvFile.Location = New Global.System.Drawing.Point(4, 33)
			Me.dgvFile.Name = "dgvFile"
			Me.dgvFile.[ReadOnly] = True
			Me.dgvFile.RowHeadersVisible = False
			Me.dgvFile.RowHeadersWidth = 30
			dataGridViewCellStyle14.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dgvFile.RowsDefaultCellStyle = dataGridViewCellStyle14
			Me.dgvFile.RowTemplate.Height = 25
			Me.dgvFile.Size = New Global.System.Drawing.Size(1067, 202)
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
			Me.FileName.Width = 500
			Me.btnDelete_File.HeaderText = ""
			Me.btnDelete_File.ImageLayout = Global.System.Windows.Forms.DataGridViewImageCellLayout.Stretch
			Me.btnDelete_File.Name = "btnDelete_File"
			Me.btnDelete_File.[ReadOnly] = True
			Me.btnDelete_File.Width = 25
			Me.tpRemarks.Controls.Add(Me.tab_lbl6)
			Me.tpRemarks.Controls.Add(Me.lblRemarksApproval1)
			Me.tpRemarks.Controls.Add(Me.lblRemarks1)
			Me.tpRemarks.Controls.Add(Me.Panel4)
			Me.tpRemarks.Controls.Add(Me.lblRemarks)
			Me.tpRemarks.Controls.Add(Me.lblRemarksApproval)
			Me.tpRemarks.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.tpRemarks.Location = New Global.System.Drawing.Point(4, 29)
			Me.tpRemarks.Name = "tpRemarks"
			Me.tpRemarks.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tpRemarks.Size = New Global.System.Drawing.Size(1075, 239)
			Me.tpRemarks.TabIndex = 6
			Me.tpRemarks.Text = "Remarks"
			Me.tpRemarks.UseVisualStyleBackColor = True
			Me.tab_lbl6.BackColor = Global.System.Drawing.Color.Black
			Me.tab_lbl6.ForeColor = Global.System.Drawing.Color.PaleGreen
			Me.tab_lbl6.Location = New Global.System.Drawing.Point(0, 0)
			Me.tab_lbl6.Name = "tab_lbl6"
			Me.tab_lbl6.Size = New Global.System.Drawing.Size(1076, 3)
			Me.tab_lbl6.TabIndex = 730
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
			Me.Panel4.Size = New Global.System.Drawing.Size(985, 218)
			Me.Panel4.TabIndex = 720
			Me.txtRemarksApproval.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtRemarksApproval.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtRemarksApproval.Location = New Global.System.Drawing.Point(10, 8)
			Me.txtRemarksApproval.Multiline = True
			Me.txtRemarksApproval.Name = "txtRemarksApproval"
			Me.txtRemarksApproval.[ReadOnly] = True
			Me.txtRemarksApproval.Size = New Global.System.Drawing.Size(964, 201)
			Me.txtRemarksApproval.TabIndex = 727
			Me.txtRemarks.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtRemarks.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtRemarks.Location = New Global.System.Drawing.Point(10, 8)
			Me.txtRemarks.Multiline = True
			Me.txtRemarks.Name = "txtRemarks"
			Me.txtRemarks.Size = New Global.System.Drawing.Size(964, 201)
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
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			MyBase.ClientSize = New Global.System.Drawing.Size(1097, 571)
			MyBase.Controls.Add(Me.grpItems)
			MyBase.Controls.Add(Me.grpPO)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.Name = "PRGeneration"
			Me.Text = "PR Generation"
			Me.grpPO.ResumeLayout(False)
			Me.grpPO.PerformLayout()
			Me.grpItems.ResumeLayout(False)
			Me.grpItems.PerformLayout()
			Me.flpButton.ResumeLayout(False)
			Me.Panel3.ResumeLayout(False)
			Me.theme_tc.ResumeLayout(False)
			Me.tpItems.ResumeLayout(False)
			Me.tpItems.PerformLayout()
			CType(Me.dgvDtls, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.tpDoc.ResumeLayout(False)
			Me.tpDoc.PerformLayout()
			CType(Me.dgvFile, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.tpRemarks.ResumeLayout(False)
			Me.Panel4.ResumeLayout(False)
			Me.Panel4.PerformLayout()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x040007B8 RID: 1976
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
