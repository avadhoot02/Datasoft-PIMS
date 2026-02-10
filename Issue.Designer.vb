Namespace Datasoft_PIMS
	' Token: 0x02000063 RID: 99
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Issue
		Inherits Global.WeifenLuo.WinFormsUI.Docking.DockContent

		' Token: 0x060017E9 RID: 6121 RVA: 0x000DB840 File Offset: 0x000D9A40
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

		' Token: 0x060017EA RID: 6122 RVA: 0x000DB890 File Offset: 0x000D9A90
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
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.Label13 = New Global.System.Windows.Forms.Label()
			Me.dtpApprovalDt = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label12 = New Global.System.Windows.Forms.Label()
			Me.dtpPickingDt = New Global.System.Windows.Forms.DateTimePicker()
			Me.txtApprovedByID = New Global.System.Windows.Forms.TextBox()
			Me.skip_lblStatus = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.txtApprovedBy = New Global.System.Windows.Forms.TextBox()
			Me.Label11 = New Global.System.Windows.Forms.Label()
			Me.txtPickingByID = New Global.System.Windows.Forms.TextBox()
			Me.txtPickingBy = New Global.System.Windows.Forms.TextBox()
			Me.txtRequestedByID = New Global.System.Windows.Forms.TextBox()
			Me.txtRequestedBy = New Global.System.Windows.Forms.TextBox()
			Me.txtProductID = New Global.System.Windows.Forms.TextBox()
			Me.txtProduct = New Global.System.Windows.Forms.TextBox()
			Me.txtRequestID = New Global.System.Windows.Forms.TextBox()
			Me.txtID = New Global.System.Windows.Forms.TextBox()
			Me.txtNo = New Global.System.Windows.Forms.TextBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.dtpDt = New Global.System.Windows.Forms.DateTimePicker()
			Me.txtRequestNo = New Global.System.Windows.Forms.TextBox()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.dtpExpDt = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.dtpRequestDt = New Global.System.Windows.Forms.DateTimePicker()
			Me.dtpMfgDt = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.txtBatchNo = New Global.System.Windows.Forms.TextBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.lblRows = New Global.System.Windows.Forms.Label()
			Me.Panel2 = New Global.System.Windows.Forms.Panel()
			Me.dgvUID = New Global.System.Windows.Forms.DataGridView()
			Me.uUID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.uCatalogNo = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.uProductName = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.uDescription = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.uBatchNo = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.uMfgDt = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.uExpDt = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.uProductID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.dgvDtls = New Global.System.Windows.Forms.DataGridView()
			Me.ProductID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.SrNo = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ProductType = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.CatalogNo = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ProductName = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Description = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.PrimaryUOM = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ReqQty = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.PickedQty = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.btnSave = New Global.System.Windows.Forms.Button()
			Me.btnPrint = New Global.System.Windows.Forms.Button()
			Me.GroupBox1.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			Me.Panel2.SuspendLayout()
			CType(Me.dgvUID, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel1.SuspendLayout()
			CType(Me.dgvDtls, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.GroupBox1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.GroupBox1.Controls.Add(Me.Label13)
			Me.GroupBox1.Controls.Add(Me.dtpApprovalDt)
			Me.GroupBox1.Controls.Add(Me.Label12)
			Me.GroupBox1.Controls.Add(Me.dtpPickingDt)
			Me.GroupBox1.Controls.Add(Me.txtApprovedByID)
			Me.GroupBox1.Controls.Add(Me.skip_lblStatus)
			Me.GroupBox1.Controls.Add(Me.Label4)
			Me.GroupBox1.Controls.Add(Me.txtApprovedBy)
			Me.GroupBox1.Controls.Add(Me.Label11)
			Me.GroupBox1.Controls.Add(Me.txtPickingByID)
			Me.GroupBox1.Controls.Add(Me.txtPickingBy)
			Me.GroupBox1.Controls.Add(Me.txtRequestedByID)
			Me.GroupBox1.Controls.Add(Me.txtRequestedBy)
			Me.GroupBox1.Controls.Add(Me.txtProductID)
			Me.GroupBox1.Controls.Add(Me.txtProduct)
			Me.GroupBox1.Controls.Add(Me.txtRequestID)
			Me.GroupBox1.Controls.Add(Me.txtID)
			Me.GroupBox1.Controls.Add(Me.txtNo)
			Me.GroupBox1.Controls.Add(Me.Label5)
			Me.GroupBox1.Controls.Add(Me.Label10)
			Me.GroupBox1.Controls.Add(Me.dtpDt)
			Me.GroupBox1.Controls.Add(Me.txtRequestNo)
			Me.GroupBox1.Controls.Add(Me.Label7)
			Me.GroupBox1.Controls.Add(Me.Label2)
			Me.GroupBox1.Controls.Add(Me.dtpExpDt)
			Me.GroupBox1.Controls.Add(Me.Label1)
			Me.GroupBox1.Controls.Add(Me.Label8)
			Me.GroupBox1.Controls.Add(Me.dtpRequestDt)
			Me.GroupBox1.Controls.Add(Me.dtpMfgDt)
			Me.GroupBox1.Controls.Add(Me.Label9)
			Me.GroupBox1.Controls.Add(Me.Label6)
			Me.GroupBox1.Controls.Add(Me.txtBatchNo)
			Me.GroupBox1.Controls.Add(Me.Label3)
			Me.GroupBox1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GroupBox1.Location = New Global.System.Drawing.Point(6, 5)
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.Size = New Global.System.Drawing.Size(989, 193)
			Me.GroupBox1.TabIndex = 1125
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Request Details"
			Me.Label13.AutoSize = True
			Me.Label13.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label13.Location = New Global.System.Drawing.Point(557, 116)
			Me.Label13.Name = "Label13"
			Me.Label13.Size = New Global.System.Drawing.Size(89, 15)
			Me.Label13.TabIndex = 1151
			Me.Label13.Text = "Approval Date"
			Me.Label13.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.dtpApprovalDt.Checked = False
			Me.dtpApprovalDt.CustomFormat = "dd   MMM   yyyy"
			Me.dtpApprovalDt.Enabled = False
			Me.dtpApprovalDt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpApprovalDt.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpApprovalDt.Location = New Global.System.Drawing.Point(680, 113)
			Me.dtpApprovalDt.Name = "dtpApprovalDt"
			Me.dtpApprovalDt.Size = New Global.System.Drawing.Size(136, 21)
			Me.dtpApprovalDt.TabIndex = 1150
			Me.Label12.AutoSize = True
			Me.Label12.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label12.Location = New Global.System.Drawing.Point(557, 92)
			Me.Label12.Name = "Label12"
			Me.Label12.Size = New Global.System.Drawing.Size(78, 15)
			Me.Label12.TabIndex = 1149
			Me.Label12.Text = "Picking Date"
			Me.Label12.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.dtpPickingDt.Checked = False
			Me.dtpPickingDt.CustomFormat = "dd   MMM   yyyy"
			Me.dtpPickingDt.Enabled = False
			Me.dtpPickingDt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpPickingDt.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpPickingDt.Location = New Global.System.Drawing.Point(680, 89)
			Me.dtpPickingDt.Name = "dtpPickingDt"
			Me.dtpPickingDt.Size = New Global.System.Drawing.Size(136, 21)
			Me.dtpPickingDt.TabIndex = 1148
			Me.txtApprovedByID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtApprovedByID.Location = New Global.System.Drawing.Point(941, 43)
			Me.txtApprovedByID.Name = "txtApprovedByID"
			Me.txtApprovedByID.Size = New Global.System.Drawing.Size(14, 21)
			Me.txtApprovedByID.TabIndex = 1147
			Me.txtApprovedByID.TabStop = False
			Me.txtApprovedByID.Visible = False
			Me.skip_lblStatus.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.skip_lblStatus.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.skip_lblStatus.ForeColor = Global.System.Drawing.Color.LawnGreen
			Me.skip_lblStatus.Location = New Global.System.Drawing.Point(334, 10)
			Me.skip_lblStatus.Name = "skip_lblStatus"
			Me.skip_lblStatus.Size = New Global.System.Drawing.Size(320, 22)
			Me.skip_lblStatus.TabIndex = 1146
			Me.skip_lblStatus.Text = "New Issue"
			Me.skip_lblStatus.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Label4.AutoSize = True
			Me.Label4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label4.Location = New Global.System.Drawing.Point(32, 116)
			Me.Label4.Name = "Label4"
			Me.Label4.Size = New Global.System.Drawing.Size(102, 15)
			Me.Label4.TabIndex = 1145
			Me.Label4.Text = "QA Approved By"
			Me.txtApprovedBy.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtApprovedBy.Location = New Global.System.Drawing.Point(136, 113)
			Me.txtApprovedBy.Name = "txtApprovedBy"
			Me.txtApprovedBy.[ReadOnly] = True
			Me.txtApprovedBy.Size = New Global.System.Drawing.Size(411, 21)
			Me.txtApprovedBy.TabIndex = 1144
			Me.Label11.AutoSize = True
			Me.Label11.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label11.Location = New Global.System.Drawing.Point(32, 92)
			Me.Label11.Name = "Label11"
			Me.Label11.Size = New Global.System.Drawing.Size(66, 15)
			Me.Label11.TabIndex = 1143
			Me.Label11.Text = "Picking By"
			Me.txtPickingByID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPickingByID.Location = New Global.System.Drawing.Point(925, 43)
			Me.txtPickingByID.Name = "txtPickingByID"
			Me.txtPickingByID.Size = New Global.System.Drawing.Size(14, 21)
			Me.txtPickingByID.TabIndex = 1142
			Me.txtPickingByID.TabStop = False
			Me.txtPickingByID.Visible = False
			Me.txtPickingBy.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPickingBy.Location = New Global.System.Drawing.Point(136, 89)
			Me.txtPickingBy.Name = "txtPickingBy"
			Me.txtPickingBy.[ReadOnly] = True
			Me.txtPickingBy.Size = New Global.System.Drawing.Size(411, 21)
			Me.txtPickingBy.TabIndex = 1141
			Me.txtRequestedByID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtRequestedByID.Location = New Global.System.Drawing.Point(909, 43)
			Me.txtRequestedByID.Name = "txtRequestedByID"
			Me.txtRequestedByID.Size = New Global.System.Drawing.Size(14, 21)
			Me.txtRequestedByID.TabIndex = 1140
			Me.txtRequestedByID.TabStop = False
			Me.txtRequestedByID.Visible = False
			Me.txtRequestedBy.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtRequestedBy.Location = New Global.System.Drawing.Point(136, 65)
			Me.txtRequestedBy.Name = "txtRequestedBy"
			Me.txtRequestedBy.[ReadOnly] = True
			Me.txtRequestedBy.Size = New Global.System.Drawing.Size(411, 21)
			Me.txtRequestedBy.TabIndex = 1139
			Me.txtProductID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtProductID.Location = New Global.System.Drawing.Point(957, 43)
			Me.txtProductID.Name = "txtProductID"
			Me.txtProductID.Size = New Global.System.Drawing.Size(14, 21)
			Me.txtProductID.TabIndex = 1138
			Me.txtProductID.TabStop = False
			Me.txtProductID.Visible = False
			Me.txtProduct.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtProduct.Location = New Global.System.Drawing.Point(136, 137)
			Me.txtProduct.Name = "txtProduct"
			Me.txtProduct.[ReadOnly] = True
			Me.txtProduct.Size = New Global.System.Drawing.Size(411, 21)
			Me.txtProduct.TabIndex = 1137
			Me.txtRequestID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtRequestID.Location = New Global.System.Drawing.Point(893, 43)
			Me.txtRequestID.Name = "txtRequestID"
			Me.txtRequestID.Size = New Global.System.Drawing.Size(14, 21)
			Me.txtRequestID.TabIndex = 1131
			Me.txtRequestID.TabStop = False
			Me.txtRequestID.Visible = False
			Me.txtID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtID.Location = New Global.System.Drawing.Point(877, 43)
			Me.txtID.Name = "txtID"
			Me.txtID.Size = New Global.System.Drawing.Size(14, 21)
			Me.txtID.TabIndex = 1130
			Me.txtID.TabStop = False
			Me.txtID.Visible = False
			Me.txtNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtNo.Location = New Global.System.Drawing.Point(136, 41)
			Me.txtNo.Name = "txtNo"
			Me.txtNo.[ReadOnly] = True
			Me.txtNo.Size = New Global.System.Drawing.Size(143, 21)
			Me.txtNo.TabIndex = 1117
			Me.Label5.AutoSize = True
			Me.Label5.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label5.Location = New Global.System.Drawing.Point(32, 44)
			Me.Label5.Name = "Label5"
			Me.Label5.Size = New Global.System.Drawing.Size(61, 15)
			Me.Label5.TabIndex = 1118
			Me.Label5.Text = "Issue No."
			Me.Label10.AutoSize = True
			Me.Label10.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label10.Location = New Global.System.Drawing.Point(557, 44)
			Me.Label10.Name = "Label10"
			Me.Label10.Size = New Global.System.Drawing.Size(69, 15)
			Me.Label10.TabIndex = 1116
			Me.Label10.Text = "Issue Date"
			Me.Label10.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.dtpDt.Checked = False
			Me.dtpDt.CustomFormat = "dd   MMM   yyyy"
			Me.dtpDt.Enabled = False
			Me.dtpDt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpDt.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpDt.Location = New Global.System.Drawing.Point(680, 41)
			Me.dtpDt.Name = "dtpDt"
			Me.dtpDt.Size = New Global.System.Drawing.Size(136, 21)
			Me.dtpDt.TabIndex = 1115
			Me.txtRequestNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtRequestNo.Location = New Global.System.Drawing.Point(404, 41)
			Me.txtRequestNo.Name = "txtRequestNo"
			Me.txtRequestNo.[ReadOnly] = True
			Me.txtRequestNo.Size = New Global.System.Drawing.Size(143, 21)
			Me.txtRequestNo.TabIndex = 1101
			Me.Label7.AutoSize = True
			Me.Label7.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label7.Location = New Global.System.Drawing.Point(557, 164)
			Me.Label7.Name = "Label7"
			Me.Label7.Size = New Global.System.Drawing.Size(74, 15)
			Me.Label7.TabIndex = 1112
			Me.Label7.Text = "Expiry Date"
			Me.Label7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.Location = New Global.System.Drawing.Point(313, 44)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(76, 15)
			Me.Label2.TabIndex = 1102
			Me.Label2.Text = "Request No."
			Me.dtpExpDt.CustomFormat = "dd   MMM   yyyy"
			Me.dtpExpDt.Enabled = False
			Me.dtpExpDt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpExpDt.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpExpDt.Location = New Global.System.Drawing.Point(680, 161)
			Me.dtpExpDt.Name = "dtpExpDt"
			Me.dtpExpDt.Size = New Global.System.Drawing.Size(136, 21)
			Me.dtpExpDt.TabIndex = 1111
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.Location = New Global.System.Drawing.Point(557, 68)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(84, 15)
			Me.Label1.TabIndex = 1100
			Me.Label1.Text = "Request Date"
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label8.AutoSize = True
			Me.Label8.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label8.Location = New Global.System.Drawing.Point(557, 140)
			Me.Label8.Name = "Label8"
			Me.Label8.Size = New Global.System.Drawing.Size(118, 15)
			Me.Label8.TabIndex = 1110
			Me.Label8.Text = "Manufacturing Date"
			Me.Label8.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.dtpRequestDt.Checked = False
			Me.dtpRequestDt.CustomFormat = "dd   MMM   yyyy"
			Me.dtpRequestDt.Enabled = False
			Me.dtpRequestDt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpRequestDt.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpRequestDt.Location = New Global.System.Drawing.Point(680, 65)
			Me.dtpRequestDt.Name = "dtpRequestDt"
			Me.dtpRequestDt.Size = New Global.System.Drawing.Size(136, 21)
			Me.dtpRequestDt.TabIndex = 1099
			Me.dtpMfgDt.CustomFormat = "dd   MMM   yyyy"
			Me.dtpMfgDt.Enabled = False
			Me.dtpMfgDt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpMfgDt.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpMfgDt.Location = New Global.System.Drawing.Point(680, 137)
			Me.dtpMfgDt.Name = "dtpMfgDt"
			Me.dtpMfgDt.Size = New Global.System.Drawing.Size(136, 21)
			Me.dtpMfgDt.TabIndex = 1109
			Me.Label9.AutoSize = True
			Me.Label9.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label9.Location = New Global.System.Drawing.Point(32, 68)
			Me.Label9.Name = "Label9"
			Me.Label9.Size = New Global.System.Drawing.Size(86, 15)
			Me.Label9.TabIndex = 1103
			Me.Label9.Text = "Requested By"
			Me.Label6.AutoSize = True
			Me.Label6.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label6.Location = New Global.System.Drawing.Point(32, 164)
			Me.Label6.Name = "Label6"
			Me.Label6.Size = New Global.System.Drawing.Size(88, 15)
			Me.Label6.TabIndex = 1108
			Me.Label6.Text = "Batch/ Lot No."
			Me.txtBatchNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtBatchNo.Location = New Global.System.Drawing.Point(136, 161)
			Me.txtBatchNo.Name = "txtBatchNo"
			Me.txtBatchNo.[ReadOnly] = True
			Me.txtBatchNo.Size = New Global.System.Drawing.Size(411, 21)
			Me.txtBatchNo.TabIndex = 1107
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.Location = New Global.System.Drawing.Point(32, 140)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(50, 15)
			Me.Label3.TabIndex = 1105
			Me.Label3.Text = "Product"
			Me.btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnClose.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClose.Location = New Global.System.Drawing.Point(560, 454)
			Me.btnClose.Name = "btnClose"
			Me.btnClose.Size = New Global.System.Drawing.Size(109, 33)
			Me.btnClose.TabIndex = 1129
			Me.btnClose.Text = "C&lose"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.GroupBox2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.GroupBox2.Controls.Add(Me.lblRows)
			Me.GroupBox2.Controls.Add(Me.Panel2)
			Me.GroupBox2.Controls.Add(Me.Panel1)
			Me.GroupBox2.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GroupBox2.Location = New Global.System.Drawing.Point(6, 204)
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.Size = New Global.System.Drawing.Size(989, 243)
			Me.GroupBox2.TabIndex = 1126
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "Item Details"
			Me.lblRows.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblRows.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRows.Location = New Global.System.Drawing.Point(907, 0)
			Me.lblRows.Name = "lblRows"
			Me.lblRows.Size = New Global.System.Drawing.Size(76, 15)
			Me.lblRows.TabIndex = 1132
			Me.lblRows.Text = "0 - Rows"
			Me.lblRows.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.Panel2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Panel2.Controls.Add(Me.dgvUID)
			Me.Panel2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Panel2.Location = New Global.System.Drawing.Point(592, 20)
			Me.Panel2.Name = "Panel2"
			Me.Panel2.Size = New Global.System.Drawing.Size(392, 217)
			Me.Panel2.TabIndex = 1102
			Me.dgvUID.AllowUserToAddRows = False
			Me.dgvUID.AllowUserToDeleteRows = False
			Me.dgvUID.AllowUserToResizeRows = False
			Me.dgvUID.BackgroundColor = Global.System.Drawing.Color.WhiteSmoke
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.GradientInactiveCaption
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvUID.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.dgvUID.ColumnHeadersHeight = 37
			Me.dgvUID.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.dgvUID.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.uUID, Me.uCatalogNo, Me.uProductName, Me.uDescription, Me.uBatchNo, Me.uMfgDt, Me.uExpDt, Me.uProductID })
			Me.dgvUID.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.dgvUID.Location = New Global.System.Drawing.Point(0, 0)
			Me.dgvUID.Name = "dgvUID"
			Me.dgvUID.[ReadOnly] = True
			Me.dgvUID.RowHeadersWidth = 30
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dgvUID.RowsDefaultCellStyle = dataGridViewCellStyle2
			Me.dgvUID.Size = New Global.System.Drawing.Size(392, 217)
			Me.dgvUID.TabIndex = 1129
			Me.uUID.DataPropertyName = "UID"
			Me.uUID.HeaderText = "UID"
			Me.uUID.Name = "uUID"
			Me.uUID.[ReadOnly] = True
			Me.uUID.Width = 125
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
			dataGridViewCellStyle3.Format = "dd - MMM - yyyy"
			Me.uMfgDt.DefaultCellStyle = dataGridViewCellStyle3
			Me.uMfgDt.HeaderText = "Mfg. Date"
			Me.uMfgDt.Name = "uMfgDt"
			Me.uMfgDt.[ReadOnly] = True
			Me.uExpDt.DataPropertyName = "ExpDt"
			dataGridViewCellStyle4.Format = "dd - MMM - yyyy"
			Me.uExpDt.DefaultCellStyle = dataGridViewCellStyle4
			Me.uExpDt.HeaderText = "Exp. Date"
			Me.uExpDt.Name = "uExpDt"
			Me.uExpDt.[ReadOnly] = True
			Me.uProductID.DataPropertyName = "ProductID"
			Me.uProductID.HeaderText = "ProductID"
			Me.uProductID.Name = "uProductID"
			Me.uProductID.[ReadOnly] = True
			Me.uProductID.Visible = False
			Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Panel1.Controls.Add(Me.dgvDtls)
			Me.Panel1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Panel1.Location = New Global.System.Drawing.Point(5, 21)
			Me.Panel1.Name = "Panel1"
			Me.Panel1.Size = New Global.System.Drawing.Size(584, 217)
			Me.Panel1.TabIndex = 1101
			Me.dgvDtls.AllowUserToAddRows = False
			Me.dgvDtls.AllowUserToDeleteRows = False
			Me.dgvDtls.AllowUserToResizeRows = False
			Me.dgvDtls.AutoSizeRowsMode = Global.System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
			Me.dgvDtls.BackgroundColor = Global.System.Drawing.Color.WhiteSmoke
			dataGridViewCellStyle5.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle5.BackColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle5.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle5.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle5.SelectionBackColor = Global.System.Drawing.SystemColors.GradientInactiveCaption
			dataGridViewCellStyle5.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle5.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvDtls.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5
			Me.dgvDtls.ColumnHeadersHeight = 37
			Me.dgvDtls.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.dgvDtls.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.ProductID, Me.SrNo, Me.ProductType, Me.CatalogNo, Me.ProductName, Me.Description, Me.PrimaryUOM, Me.ReqQty, Me.PickedQty })
			dataGridViewCellStyle6.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle6.BackColor = Global.System.Drawing.SystemColors.Window
			dataGridViewCellStyle6.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle6.ForeColor = Global.System.Drawing.SystemColors.ControlText
			dataGridViewCellStyle6.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle6.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle6.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[False]
			Me.dgvDtls.DefaultCellStyle = dataGridViewCellStyle6
			Me.dgvDtls.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.dgvDtls.Location = New Global.System.Drawing.Point(0, 0)
			Me.dgvDtls.Name = "dgvDtls"
			Me.dgvDtls.[ReadOnly] = True
			dataGridViewCellStyle7.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle7.BackColor = Global.System.Drawing.SystemColors.Control
			dataGridViewCellStyle7.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle7.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle7.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle7.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle7.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvDtls.RowHeadersDefaultCellStyle = dataGridViewCellStyle7
			Me.dgvDtls.RowHeadersWidth = 30
			dataGridViewCellStyle8.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dgvDtls.RowsDefaultCellStyle = dataGridViewCellStyle8
			Me.dgvDtls.Size = New Global.System.Drawing.Size(584, 217)
			Me.dgvDtls.TabIndex = 1102
			Me.ProductID.DataPropertyName = "ProductID"
			Me.ProductID.HeaderText = "ProductID"
			Me.ProductID.Name = "ProductID"
			Me.ProductID.[ReadOnly] = True
			Me.ProductID.Visible = False
			Me.SrNo.DataPropertyName = "SrNo"
			dataGridViewCellStyle9.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.SrNo.DefaultCellStyle = dataGridViewCellStyle9
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
			dataGridViewCellStyle10.Padding = New Global.System.Windows.Forms.Padding(0, 2, 0, 2)
			dataGridViewCellStyle10.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.Description.DefaultCellStyle = dataGridViewCellStyle10
			Me.Description.HeaderText = "Description"
			Me.Description.Name = "Description"
			Me.Description.[ReadOnly] = True
			Me.Description.Width = 300
			Me.PrimaryUOM.DataPropertyName = "PrimaryUOM"
			Me.PrimaryUOM.HeaderText = "Primary UOM"
			Me.PrimaryUOM.Name = "PrimaryUOM"
			Me.PrimaryUOM.[ReadOnly] = True
			Me.PrimaryUOM.Width = 60
			Me.ReqQty.DataPropertyName = "RequiredQty"
			dataGridViewCellStyle11.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.ReqQty.DefaultCellStyle = dataGridViewCellStyle11
			Me.ReqQty.HeaderText = "Required Qty. Primary"
			Me.ReqQty.Name = "ReqQty"
			Me.ReqQty.[ReadOnly] = True
			Me.ReqQty.Width = 110
			Me.PickedQty.DataPropertyName = "PickedQty"
			dataGridViewCellStyle12.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.PickedQty.DefaultCellStyle = dataGridViewCellStyle12
			Me.PickedQty.HeaderText = "Picked Qty. Primary"
			Me.PickedQty.Name = "PickedQty"
			Me.PickedQty.[ReadOnly] = True
			Me.btnSave.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnSave.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnSave.Location = New Global.System.Drawing.Point(332, 454)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New Global.System.Drawing.Size(109, 33)
			Me.btnSave.TabIndex = 1128
			Me.btnSave.Text = "Save"
			Me.btnSave.UseVisualStyleBackColor = True
			Me.btnPrint.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnPrint.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnPrint.Location = New Global.System.Drawing.Point(446, 454)
			Me.btnPrint.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnPrint.Name = "btnPrint"
			Me.btnPrint.Size = New Global.System.Drawing.Size(109, 33)
			Me.btnPrint.TabIndex = 1130
			Me.btnPrint.Text = "&Print"
			Me.btnPrint.UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			MyBase.ClientSize = New Global.System.Drawing.Size(1001, 492)
			MyBase.Controls.Add(Me.btnPrint)
			MyBase.Controls.Add(Me.GroupBox1)
			MyBase.Controls.Add(Me.btnClose)
			MyBase.Controls.Add(Me.GroupBox2)
			MyBase.Controls.Add(Me.btnSave)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.Name = "Issue"
			Me.Text = "Issue"
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.GroupBox2.ResumeLayout(False)
			Me.Panel2.ResumeLayout(False)
			CType(Me.dgvUID, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel1.ResumeLayout(False)
			CType(Me.dgvDtls, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000A45 RID: 2629
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
