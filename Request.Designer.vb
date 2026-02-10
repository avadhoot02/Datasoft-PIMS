Namespace Datasoft_PIMS
	' Token: 0x0200006A RID: 106
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Request
		Inherits Global.WeifenLuo.WinFormsUI.Docking.DockContent

		' Token: 0x06001C37 RID: 7223 RVA: 0x001082F0 File Offset: 0x001064F0
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

		' Token: 0x06001C38 RID: 7224 RVA: 0x00108340 File Offset: 0x00106540
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
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.dtpExpDt = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.dtpMfgDt = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.txtBatchNo = New Global.System.Windows.Forms.TextBox()
			Me.cmbProduct = New Global.System.Windows.Forms.ComboBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.cmbRequestedBy = New Global.System.Windows.Forms.ComboBox()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.dtpDt = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.txtNo = New Global.System.Windows.Forms.TextBox()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.llbClearBOM = New Global.System.Windows.Forms.LinkLabel()
			Me.Label11 = New Global.System.Windows.Forms.Label()
			Me.llbFill = New Global.System.Windows.Forms.LinkLabel()
			Me.cmbBOM = New Global.System.Windows.Forms.ComboBox()
			Me.txtBatchQty = New Global.System.Windows.Forms.TextBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.cmbDept = New Global.System.Windows.Forms.ComboBox()
			Me.skip_lblStatus = New Global.System.Windows.Forms.Label()
			Me.cmbType = New Global.System.Windows.Forms.ComboBox()
			Me.Label18 = New Global.System.Windows.Forms.Label()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.Label12 = New Global.System.Windows.Forms.Label()
			Me.lblUnavailable = New Global.System.Windows.Forms.Label()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.dgvDtls = New Global.System.Windows.Forms.DataGridView()
			Me.llbAdd = New Global.System.Windows.Forms.LinkLabel()
			Me.btnSave = New Global.System.Windows.Forms.Button()
			Me.btnClear = New Global.System.Windows.Forms.Button()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.btnCancel = New Global.System.Windows.Forms.Button()
			Me.txtID = New Global.System.Windows.Forms.TextBox()
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
			Me.PickedQty = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.IssuedQty = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.GroupBox1.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			Me.Panel1.SuspendLayout()
			CType(Me.dgvDtls, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.Label7.AutoSize = True
			Me.Label7.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label7.Location = New Global.System.Drawing.Point(341, 185)
			Me.Label7.Name = "Label7"
			Me.Label7.Size = New Global.System.Drawing.Size(74, 15)
			Me.Label7.TabIndex = 1112
			Me.Label7.Text = "Expiry Date"
			Me.Label7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.dtpExpDt.Checked = False
			Me.dtpExpDt.CustomFormat = "dd   MMM   yyyy"
			Me.dtpExpDt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpExpDt.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpExpDt.Location = New Global.System.Drawing.Point(447, 182)
			Me.dtpExpDt.Name = "dtpExpDt"
			Me.dtpExpDt.ShowCheckBox = True
			Me.dtpExpDt.Size = New Global.System.Drawing.Size(176, 21)
			Me.dtpExpDt.TabIndex = 8
			Me.Label8.AutoSize = True
			Me.Label8.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label8.Location = New Global.System.Drawing.Point(32, 185)
			Me.Label8.Name = "Label8"
			Me.Label8.Size = New Global.System.Drawing.Size(118, 15)
			Me.Label8.TabIndex = 1110
			Me.Label8.Text = "Manufacturing Date"
			Me.Label8.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.dtpMfgDt.Checked = False
			Me.dtpMfgDt.CustomFormat = "dd   MMM   yyyy"
			Me.dtpMfgDt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpMfgDt.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpMfgDt.Location = New Global.System.Drawing.Point(152, 182)
			Me.dtpMfgDt.Name = "dtpMfgDt"
			Me.dtpMfgDt.ShowCheckBox = True
			Me.dtpMfgDt.Size = New Global.System.Drawing.Size(176, 21)
			Me.dtpMfgDt.TabIndex = 7
			Me.Label6.AutoSize = True
			Me.Label6.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label6.Location = New Global.System.Drawing.Point(32, 160)
			Me.Label6.Name = "Label6"
			Me.Label6.Size = New Global.System.Drawing.Size(88, 15)
			Me.Label6.TabIndex = 1108
			Me.Label6.Text = "Batch/ Lot No."
			Me.txtBatchNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtBatchNo.Location = New Global.System.Drawing.Point(152, 157)
			Me.txtBatchNo.Name = "txtBatchNo"
			Me.txtBatchNo.Size = New Global.System.Drawing.Size(471, 21)
			Me.txtBatchNo.TabIndex = 6
			Me.cmbProduct.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbProduct.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbProduct.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbProduct.FormattingEnabled = True
			Me.cmbProduct.Location = New Global.System.Drawing.Point(152, 130)
			Me.cmbProduct.Name = "cmbProduct"
			Me.cmbProduct.Size = New Global.System.Drawing.Size(471, 23)
			Me.cmbProduct.TabIndex = 5
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.Location = New Global.System.Drawing.Point(32, 134)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(78, 15)
			Me.Label3.TabIndex = 1105
			Me.Label3.Text = "Mfg. Product"
			Me.cmbRequestedBy.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbRequestedBy.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbRequestedBy.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbRequestedBy.FormattingEnabled = True
			Me.cmbRequestedBy.Location = New Global.System.Drawing.Point(152, 76)
			Me.cmbRequestedBy.Name = "cmbRequestedBy"
			Me.cmbRequestedBy.Size = New Global.System.Drawing.Size(471, 23)
			Me.cmbRequestedBy.TabIndex = 3
			Me.Label9.AutoSize = True
			Me.Label9.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label9.Location = New Global.System.Drawing.Point(32, 80)
			Me.Label9.Name = "Label9"
			Me.Label9.Size = New Global.System.Drawing.Size(86, 15)
			Me.Label9.TabIndex = 1103
			Me.Label9.Text = "Requested By"
			Me.dtpDt.Checked = False
			Me.dtpDt.CustomFormat = "dd   MMM   yyyy"
			Me.dtpDt.Enabled = False
			Me.dtpDt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpDt.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpDt.Location = New Global.System.Drawing.Point(447, 24)
			Me.dtpDt.Name = "dtpDt"
			Me.dtpDt.Size = New Global.System.Drawing.Size(176, 21)
			Me.dtpDt.TabIndex = 1
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.Location = New Global.System.Drawing.Point(341, 27)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(84, 15)
			Me.Label1.TabIndex = 1100
			Me.Label1.Text = "Request Date"
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.Location = New Global.System.Drawing.Point(32, 27)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(76, 15)
			Me.Label2.TabIndex = 1102
			Me.Label2.Text = "Request No."
			Me.txtNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtNo.Location = New Global.System.Drawing.Point(152, 24)
			Me.txtNo.Name = "txtNo"
			Me.txtNo.[ReadOnly] = True
			Me.txtNo.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtNo.TabIndex = 0
			Me.GroupBox1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.GroupBox1.Controls.Add(Me.llbClearBOM)
			Me.GroupBox1.Controls.Add(Me.Label11)
			Me.GroupBox1.Controls.Add(Me.llbFill)
			Me.GroupBox1.Controls.Add(Me.cmbBOM)
			Me.GroupBox1.Controls.Add(Me.txtBatchQty)
			Me.GroupBox1.Controls.Add(Me.Label5)
			Me.GroupBox1.Controls.Add(Me.Label4)
			Me.GroupBox1.Controls.Add(Me.cmbDept)
			Me.GroupBox1.Controls.Add(Me.skip_lblStatus)
			Me.GroupBox1.Controls.Add(Me.cmbType)
			Me.GroupBox1.Controls.Add(Me.Label18)
			Me.GroupBox1.Controls.Add(Me.txtNo)
			Me.GroupBox1.Controls.Add(Me.Label7)
			Me.GroupBox1.Controls.Add(Me.Label2)
			Me.GroupBox1.Controls.Add(Me.dtpExpDt)
			Me.GroupBox1.Controls.Add(Me.Label1)
			Me.GroupBox1.Controls.Add(Me.Label8)
			Me.GroupBox1.Controls.Add(Me.dtpDt)
			Me.GroupBox1.Controls.Add(Me.dtpMfgDt)
			Me.GroupBox1.Controls.Add(Me.Label9)
			Me.GroupBox1.Controls.Add(Me.Label6)
			Me.GroupBox1.Controls.Add(Me.cmbRequestedBy)
			Me.GroupBox1.Controls.Add(Me.txtBatchNo)
			Me.GroupBox1.Controls.Add(Me.Label3)
			Me.GroupBox1.Controls.Add(Me.cmbProduct)
			Me.GroupBox1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GroupBox1.Location = New Global.System.Drawing.Point(6, 6)
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.Size = New Global.System.Drawing.Size(961, 240)
			Me.GroupBox1.TabIndex = 0
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Request Details"
			Me.llbClearBOM.ActiveLinkColor = Global.System.Drawing.Color.Maroon
			Me.llbClearBOM.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.llbClearBOM.AutoSize = True
			Me.llbClearBOM.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.llbClearBOM.LinkColor = Global.System.Drawing.Color.Maroon
			Me.llbClearBOM.Location = New Global.System.Drawing.Point(875, 212)
			Me.llbClearBOM.Name = "llbClearBOM"
			Me.llbClearBOM.Size = New Global.System.Drawing.Size(77, 15)
			Me.llbClearBOM.TabIndex = 11
			Me.llbClearBOM.TabStop = True
			Me.llbClearBOM.Text = "Clear BOM"
			Me.Label11.AutoSize = True
			Me.Label11.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label11.Location = New Global.System.Drawing.Point(32, 211)
			Me.Label11.Name = "Label11"
			Me.Label11.Size = New Global.System.Drawing.Size(80, 15)
			Me.Label11.TabIndex = 1221
			Me.Label11.Text = "BOM Version"
			Me.llbFill.ActiveLinkColor = Global.System.Drawing.Color.Maroon
			Me.llbFill.AutoSize = True
			Me.llbFill.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.llbFill.LinkColor = Global.System.Drawing.Color.Maroon
			Me.llbFill.Location = New Global.System.Drawing.Point(629, 212)
			Me.llbFill.Name = "llbFill"
			Me.llbFill.Size = New Global.System.Drawing.Size(60, 15)
			Me.llbFill.TabIndex = 10
			Me.llbFill.TabStop = True
			Me.llbFill.Text = "Fill BOM"
			Me.cmbBOM.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbBOM.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbBOM.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbBOM.FormattingEnabled = True
			Me.cmbBOM.Location = New Global.System.Drawing.Point(152, 208)
			Me.cmbBOM.Name = "cmbBOM"
			Me.cmbBOM.Size = New Global.System.Drawing.Size(176, 23)
			Me.cmbBOM.TabIndex = 9
			Me.txtBatchQty.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtBatchQty.Location = New Global.System.Drawing.Point(447, 208)
			Me.txtBatchQty.Name = "txtBatchQty"
			Me.txtBatchQty.[ReadOnly] = True
			Me.txtBatchQty.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtBatchQty.TabIndex = 7
			Me.txtBatchQty.TabStop = False
			Me.Label5.AutoSize = True
			Me.Label5.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label5.Location = New Global.System.Drawing.Point(344, 211)
			Me.Label5.Name = "Label5"
			Me.Label5.Size = New Global.System.Drawing.Size(67, 15)
			Me.Label5.TabIndex = 1124
			Me.Label5.Text = "Batch Qty."
			Me.Label4.AutoSize = True
			Me.Label4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label4.Location = New Global.System.Drawing.Point(32, 53)
			Me.Label4.Name = "Label4"
			Me.Label4.Size = New Global.System.Drawing.Size(75, 15)
			Me.Label4.TabIndex = 1123
			Me.Label4.Text = "Department"
			Me.cmbDept.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbDept.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbDept.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbDept.FormattingEnabled = True
			Me.cmbDept.Location = New Global.System.Drawing.Point(152, 49)
			Me.cmbDept.Name = "cmbDept"
			Me.cmbDept.Size = New Global.System.Drawing.Size(471, 23)
			Me.cmbDept.TabIndex = 2
			Me.skip_lblStatus.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.skip_lblStatus.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.skip_lblStatus.ForeColor = Global.System.Drawing.Color.LawnGreen
			Me.skip_lblStatus.Location = New Global.System.Drawing.Point(753, -2)
			Me.skip_lblStatus.Name = "skip_lblStatus"
			Me.skip_lblStatus.Size = New Global.System.Drawing.Size(199, 22)
			Me.skip_lblStatus.TabIndex = 1121
			Me.skip_lblStatus.Text = "New Request"
			Me.skip_lblStatus.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.cmbType.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbType.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbType.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbType.FormattingEnabled = True
			Me.cmbType.Items.AddRange(New Object() { "", "Finished Goods", "Semi Finished", "Cell Bank - Mammalian", "Cell Bank - Bacterial", "Others" })
			Me.cmbType.Location = New Global.System.Drawing.Point(152, 103)
			Me.cmbType.Name = "cmbType"
			Me.cmbType.Size = New Global.System.Drawing.Size(471, 23)
			Me.cmbType.TabIndex = 4
			Me.Label18.AutoSize = True
			Me.Label18.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label18.Location = New Global.System.Drawing.Point(32, 107)
			Me.Label18.Name = "Label18"
			Me.Label18.Size = New Global.System.Drawing.Size(82, 15)
			Me.Label18.TabIndex = 1120
			Me.Label18.Text = "Product Type"
			Me.GroupBox2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.GroupBox2.Controls.Add(Me.Label12)
			Me.GroupBox2.Controls.Add(Me.lblUnavailable)
			Me.GroupBox2.Controls.Add(Me.Panel1)
			Me.GroupBox2.Controls.Add(Me.llbAdd)
			Me.GroupBox2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GroupBox2.Location = New Global.System.Drawing.Point(6, 252)
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.Size = New Global.System.Drawing.Size(961, 234)
			Me.GroupBox2.TabIndex = 1
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "Item Details"
			Me.Label12.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Label12.AutoSize = True
			Me.Label12.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label12.Location = New Global.System.Drawing.Point(789, 22)
			Me.Label12.Name = "Label12"
			Me.Label12.Size = New Global.System.Drawing.Size(164, 15)
			Me.Label12.TabIndex = 1103
			Me.Label12.Text = "Required Stock Unavailable"
			Me.lblUnavailable.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblUnavailable.BackColor = Global.System.Drawing.Color.Maroon
			Me.lblUnavailable.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblUnavailable.Location = New Global.System.Drawing.Point(760, 22)
			Me.lblUnavailable.Name = "lblUnavailable"
			Me.lblUnavailable.Size = New Global.System.Drawing.Size(27, 15)
			Me.lblUnavailable.TabIndex = 1102
			Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Panel1.Controls.Add(Me.dgvDtls)
			Me.Panel1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Panel1.Location = New Global.System.Drawing.Point(3, 48)
			Me.Panel1.Name = "Panel1"
			Me.Panel1.Size = New Global.System.Drawing.Size(956, 181)
			Me.Panel1.TabIndex = 1101
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
			Me.dgvDtls.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.ProductID, Me.SrNo, Me.ProductType, Me.CatalogNo, Me.ProductName, Me.Description, Me.TertiaryUOM, Me.TertiaryPackSize, Me.PrimaryUOM, Me.PrimaryPackSize, Me.ReqQty, Me.PickedQty, Me.IssuedQty })
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
			Me.dgvDtls.Size = New Global.System.Drawing.Size(956, 181)
			Me.dgvDtls.TabIndex = 1101
			Me.llbAdd.ActiveLinkColor = Global.System.Drawing.Color.Maroon
			Me.llbAdd.AutoSize = True
			Me.llbAdd.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.llbAdd.LinkColor = Global.System.Drawing.Color.Maroon
			Me.llbAdd.Location = New Global.System.Drawing.Point(10, 28)
			Me.llbAdd.Name = "llbAdd"
			Me.llbAdd.Size = New Global.System.Drawing.Size(68, 15)
			Me.llbAdd.TabIndex = 1
			Me.llbAdd.TabStop = True
			Me.llbAdd.Text = "Add Item"
			Me.btnSave.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnSave.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnSave.Location = New Global.System.Drawing.Point(221, 493)
			Me.btnSave.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New Global.System.Drawing.Size(129, 32)
			Me.btnSave.TabIndex = 0
			Me.btnSave.Text = "&Save"
			Me.btnSave.UseVisualStyleBackColor = True
			Me.btnClear.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnClear.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClear.Location = New Global.System.Drawing.Point(353, 493)
			Me.btnClear.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnClear.Name = "btnClear"
			Me.btnClear.Size = New Global.System.Drawing.Size(129, 32)
			Me.btnClear.TabIndex = 1
			Me.btnClear.Text = "&Clear"
			Me.btnClear.UseVisualStyleBackColor = True
			Me.btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnClose.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClose.Location = New Global.System.Drawing.Point(622, 493)
			Me.btnClose.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnClose.Name = "btnClose"
			Me.btnClose.Size = New Global.System.Drawing.Size(129, 32)
			Me.btnClose.TabIndex = 3
			Me.btnClose.Text = "C&lose"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.btnCancel.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnCancel.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnCancel.Location = New Global.System.Drawing.Point(485, 493)
			Me.btnCancel.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New Global.System.Drawing.Size(134, 32)
			Me.btnCancel.TabIndex = 2
			Me.btnCancel.Text = "Cancel Request"
			Me.btnCancel.UseVisualStyleBackColor = True
			Me.txtID.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtID.Location = New Global.System.Drawing.Point(933, 504)
			Me.txtID.Name = "txtID"
			Me.txtID.Size = New Global.System.Drawing.Size(34, 21)
			Me.txtID.TabIndex = 1115
			Me.txtID.TabStop = False
			Me.txtID.Visible = False
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
			Me.ReqQty.Width = 90
			Me.PickedQty.DataPropertyName = "PickedQty"
			dataGridViewCellStyle10.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.PickedQty.DefaultCellStyle = dataGridViewCellStyle10
			Me.PickedQty.HeaderText = "Picked Qty. Primary"
			Me.PickedQty.Name = "PickedQty"
			Me.PickedQty.[ReadOnly] = True
			Me.PickedQty.Width = 90
			Me.IssuedQty.DataPropertyName = "IssuedQty"
			dataGridViewCellStyle11.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.IssuedQty.DefaultCellStyle = dataGridViewCellStyle11
			Me.IssuedQty.HeaderText = "Issued Qty. Primary"
			Me.IssuedQty.Name = "IssuedQty"
			Me.IssuedQty.[ReadOnly] = True
			Me.IssuedQty.Width = 90
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.None
			Me.BackColor = Global.System.Drawing.Color.White
			MyBase.ClientSize = New Global.System.Drawing.Size(973, 534)
			MyBase.Controls.Add(Me.txtID)
			MyBase.Controls.Add(Me.btnCancel)
			MyBase.Controls.Add(Me.btnSave)
			MyBase.Controls.Add(Me.btnClear)
			MyBase.Controls.Add(Me.btnClose)
			MyBase.Controls.Add(Me.GroupBox2)
			MyBase.Controls.Add(Me.GroupBox1)
			Me.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.Name = "Request"
			Me.Text = "Request"
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox2.PerformLayout()
			Me.Panel1.ResumeLayout(False)
			CType(Me.dgvDtls, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000C3A RID: 3130
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
