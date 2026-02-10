Namespace Datasoft_PIMS
	' Token: 0x0200004D RID: 77
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class POApprovalRange
		Inherits Global.WeifenLuo.WinFormsUI.Docking.DockContent

		' Token: 0x06000DC2 RID: 3522 RVA: 0x0007C378 File Offset: 0x0007A578
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

		' Token: 0x06000DC3 RID: 3523 RVA: 0x0007C3C8 File Offset: 0x0007A5C8
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
			Me.btnSave = New Global.System.Windows.Forms.Button()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.dgvList = New Global.System.Windows.Forms.DataGridView()
			Me.btnDelete_ID = New Global.System.Windows.Forms.DataGridViewImageColumn()
			Me.lstPOApprovalID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ApproverID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.UserName = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.EmailID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.btnClear = New Global.System.Windows.Forms.Button()
			Me.txtPOApprovalID = New Global.System.Windows.Forms.TextBox()
			Me.sml_btnAdd = New Global.System.Windows.Forms.Button()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.Panel2 = New Global.System.Windows.Forms.Panel()
			Me.dgvLevel = New Global.System.Windows.Forms.DataGridView()
			Me.POApprovalID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ApprovalLevel = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Sym1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.FromAmt = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Sym2 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ToAmt = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.imgFill = New Global.System.Windows.Forms.DataGridViewImageColumn()
			Me.GroupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.txtEmail = New Global.System.Windows.Forms.TextBox()
			Me.cmbUser = New Global.System.Windows.Forms.ComboBox()
			Me.txtLevel = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.lblRows = New Global.System.Windows.Forms.Label()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			CType(Me.dgvList, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox2.SuspendLayout()
			Me.Panel2.SuspendLayout()
			CType(Me.dgvLevel, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox3.SuspendLayout()
			Me.Panel1.SuspendLayout()
			MyBase.SuspendLayout()
			Me.btnSave.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnSave.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnSave.Location = New Global.System.Drawing.Point(357, 479)
			Me.btnSave.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New Global.System.Drawing.Size(113, 30)
			Me.btnSave.TabIndex = 1147
			Me.btnSave.Text = "&Save"
			Me.btnSave.UseVisualStyleBackColor = True
			Me.btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnClose.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClose.Location = New Global.System.Drawing.Point(587, 479)
			Me.btnClose.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnClose.Name = "btnClose"
			Me.btnClose.Size = New Global.System.Drawing.Size(113, 30)
			Me.btnClose.TabIndex = 1149
			Me.btnClose.Text = "C&lose"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.dgvList.AllowUserToAddRows = False
			Me.dgvList.AllowUserToDeleteRows = False
			Me.dgvList.AllowUserToResizeRows = False
			Me.dgvList.BackgroundColor = Global.System.Drawing.Color.WhiteSmoke
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.GradientInactiveCaption
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.dgvList.ColumnHeadersHeight = 25
			Me.dgvList.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.dgvList.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.btnDelete_ID, Me.lstPOApprovalID, Me.ApproverID, Me.UserName, Me.EmailID })
			Me.dgvList.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.dgvList.Location = New Global.System.Drawing.Point(0, 0)
			Me.dgvList.Name = "dgvList"
			Me.dgvList.RowHeadersVisible = False
			Me.dgvList.RowHeadersWidth = 30
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle2
			Me.dgvList.Size = New Global.System.Drawing.Size(541, 352)
			Me.dgvList.TabIndex = 1045
			Me.btnDelete_ID.HeaderText = ""
			Me.btnDelete_ID.ImageLayout = Global.System.Windows.Forms.DataGridViewImageCellLayout.Stretch
			Me.btnDelete_ID.Name = "btnDelete_ID"
			Me.btnDelete_ID.Width = 25
			Me.lstPOApprovalID.DataPropertyName = "POApprovalID"
			Me.lstPOApprovalID.HeaderText = "POApprovalID"
			Me.lstPOApprovalID.Name = "lstPOApprovalID"
			Me.lstPOApprovalID.Visible = False
			Me.ApproverID.DataPropertyName = "ApproverID"
			Me.ApproverID.HeaderText = "ApproverID"
			Me.ApproverID.Name = "ApproverID"
			Me.ApproverID.Visible = False
			Me.UserName.DataPropertyName = "UserName"
			Me.UserName.HeaderText = "User Name"
			Me.UserName.Name = "UserName"
			Me.UserName.Width = 250
			Me.EmailID.DataPropertyName = "EmailID"
			Me.EmailID.HeaderText = "Email ID"
			Me.EmailID.Name = "EmailID"
			Me.EmailID.Width = 300
			Me.btnClear.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnClear.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClear.Location = New Global.System.Drawing.Point(472, 479)
			Me.btnClear.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnClear.Name = "btnClear"
			Me.btnClear.Size = New Global.System.Drawing.Size(113, 30)
			Me.btnClear.TabIndex = 1148
			Me.btnClear.Text = "&Clear"
			Me.btnClear.UseVisualStyleBackColor = True
			Me.txtPOApprovalID.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtPOApprovalID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPOApprovalID.Location = New Global.System.Drawing.Point(441, 22)
			Me.txtPOApprovalID.Name = "txtPOApprovalID"
			Me.txtPOApprovalID.[ReadOnly] = True
			Me.txtPOApprovalID.Size = New Global.System.Drawing.Size(100, 21)
			Me.txtPOApprovalID.TabIndex = 1145
			Me.txtPOApprovalID.Visible = False
			Me.sml_btnAdd.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.sml_btnAdd.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.sml_btnAdd.Location = New Global.System.Drawing.Point(440, 75)
			Me.sml_btnAdd.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.sml_btnAdd.Name = "sml_btnAdd"
			Me.sml_btnAdd.Size = New Global.System.Drawing.Size(101, 24)
			Me.sml_btnAdd.TabIndex = 1144
			Me.sml_btnAdd.Text = "Add"
			Me.sml_btnAdd.UseVisualStyleBackColor = True
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.Location = New Global.System.Drawing.Point(6, 80)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(56, 15)
			Me.Label3.TabIndex = 1065
			Me.Label3.Text = "Email ID"
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.Location = New Global.System.Drawing.Point(6, 51)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(55, 15)
			Me.Label2.TabIndex = 1064
			Me.Label2.Text = "Login ID"
			Me.GroupBox2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
			Me.GroupBox2.Controls.Add(Me.Panel2)
			Me.GroupBox2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GroupBox2.Location = New Global.System.Drawing.Point(7, 10)
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.Size = New Global.System.Drawing.Size(486, 465)
			Me.GroupBox2.TabIndex = 1145
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "Approval Levels"
			Me.Panel2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Panel2.Controls.Add(Me.dgvLevel)
			Me.Panel2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Panel2.Location = New Global.System.Drawing.Point(2, 20)
			Me.Panel2.Name = "Panel2"
			Me.Panel2.Size = New Global.System.Drawing.Size(480, 439)
			Me.Panel2.TabIndex = 1054
			Me.dgvLevel.AllowUserToAddRows = False
			Me.dgvLevel.AllowUserToDeleteRows = False
			Me.dgvLevel.AllowUserToResizeRows = False
			Me.dgvLevel.BackgroundColor = Global.System.Drawing.Color.WhiteSmoke
			dataGridViewCellStyle3.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle3.BackColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle3.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle3.SelectionBackColor = Global.System.Drawing.SystemColors.GradientInactiveCaption
			dataGridViewCellStyle3.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle3.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvLevel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3
			Me.dgvLevel.ColumnHeadersHeight = 25
			Me.dgvLevel.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.dgvLevel.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.POApprovalID, Me.ApprovalLevel, Me.Sym1, Me.FromAmt, Me.Sym2, Me.ToAmt, Me.imgFill })
			Me.dgvLevel.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.dgvLevel.Location = New Global.System.Drawing.Point(0, 0)
			Me.dgvLevel.MultiSelect = False
			Me.dgvLevel.Name = "dgvLevel"
			Me.dgvLevel.[ReadOnly] = True
			Me.dgvLevel.RowHeadersVisible = False
			Me.dgvLevel.RowHeadersWidth = 30
			dataGridViewCellStyle4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dgvLevel.RowsDefaultCellStyle = dataGridViewCellStyle4
			Me.dgvLevel.RowTemplate.Height = 30
			Me.dgvLevel.Size = New Global.System.Drawing.Size(480, 439)
			Me.dgvLevel.TabIndex = 1045
			Me.POApprovalID.DataPropertyName = "POApprovalID"
			Me.POApprovalID.HeaderText = "POApprovalID"
			Me.POApprovalID.Name = "POApprovalID"
			Me.POApprovalID.[ReadOnly] = True
			Me.POApprovalID.Visible = False
			Me.ApprovalLevel.DataPropertyName = "ApprovalLevel"
			Me.ApprovalLevel.HeaderText = "Approval Level"
			Me.ApprovalLevel.Name = "ApprovalLevel"
			Me.ApprovalLevel.[ReadOnly] = True
			Me.ApprovalLevel.Width = 140
			Me.Sym1.DataPropertyName = "Sym1"
			dataGridViewCellStyle5.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.Sym1.DefaultCellStyle = dataGridViewCellStyle5
			Me.Sym1.HeaderText = ""
			Me.Sym1.Name = "Sym1"
			Me.Sym1.[ReadOnly] = True
			Me.Sym1.Width = 25
			Me.FromAmt.DataPropertyName = "FromAmt"
			dataGridViewCellStyle6.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.FromAmt.DefaultCellStyle = dataGridViewCellStyle6
			Me.FromAmt.HeaderText = ""
			Me.FromAmt.Name = "FromAmt"
			Me.FromAmt.[ReadOnly] = True
			Me.FromAmt.Width = 80
			Me.Sym2.DataPropertyName = "Sym2"
			dataGridViewCellStyle7.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.Sym2.DefaultCellStyle = dataGridViewCellStyle7
			Me.Sym2.HeaderText = ""
			Me.Sym2.Name = "Sym2"
			Me.Sym2.[ReadOnly] = True
			Me.Sym2.Width = 27
			Me.ToAmt.DataPropertyName = "ToAmt"
			dataGridViewCellStyle8.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
			Me.ToAmt.DefaultCellStyle = dataGridViewCellStyle8
			Me.ToAmt.HeaderText = ""
			Me.ToAmt.Name = "ToAmt"
			Me.ToAmt.[ReadOnly] = True
			Me.ToAmt.Width = 80
			Me.imgFill.DataPropertyName = "imgFill"
			Me.imgFill.HeaderText = ""
			Me.imgFill.ImageLayout = Global.System.Windows.Forms.DataGridViewImageCellLayout.Stretch
			Me.imgFill.Name = "imgFill"
			Me.imgFill.[ReadOnly] = True
			Me.imgFill.Width = 30
			Me.GroupBox3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.GroupBox3.Controls.Add(Me.txtPOApprovalID)
			Me.GroupBox3.Controls.Add(Me.sml_btnAdd)
			Me.GroupBox3.Controls.Add(Me.Label3)
			Me.GroupBox3.Controls.Add(Me.Label2)
			Me.GroupBox3.Controls.Add(Me.txtEmail)
			Me.GroupBox3.Controls.Add(Me.cmbUser)
			Me.GroupBox3.Controls.Add(Me.txtLevel)
			Me.GroupBox3.Controls.Add(Me.Label1)
			Me.GroupBox3.Controls.Add(Me.lblRows)
			Me.GroupBox3.Controls.Add(Me.Panel1)
			Me.GroupBox3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GroupBox3.Location = New Global.System.Drawing.Point(499, 10)
			Me.GroupBox3.Name = "GroupBox3"
			Me.GroupBox3.Size = New Global.System.Drawing.Size(548, 463)
			Me.GroupBox3.TabIndex = 1146
			Me.GroupBox3.TabStop = False
			Me.GroupBox3.Text = "Approval IDs"
			Me.txtEmail.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtEmail.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtEmail.Location = New Global.System.Drawing.Point(102, 76)
			Me.txtEmail.Multiline = True
			Me.txtEmail.Name = "txtEmail"
			Me.txtEmail.[ReadOnly] = True
			Me.txtEmail.Size = New Global.System.Drawing.Size(333, 23)
			Me.txtEmail.TabIndex = 1062
			Me.cmbUser.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.cmbUser.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbUser.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbUser.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbUser.FormattingEnabled = True
			Me.cmbUser.Location = New Global.System.Drawing.Point(102, 48)
			Me.cmbUser.Name = "cmbUser"
			Me.cmbUser.Size = New Global.System.Drawing.Size(333, 23)
			Me.cmbUser.TabIndex = 1060
			Me.txtLevel.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtLevel.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtLevel.Location = New Global.System.Drawing.Point(102, 22)
			Me.txtLevel.Name = "txtLevel"
			Me.txtLevel.[ReadOnly] = True
			Me.txtLevel.Size = New Global.System.Drawing.Size(333, 21)
			Me.txtLevel.TabIndex = 1058
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.Location = New Global.System.Drawing.Point(6, 25)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(90, 15)
			Me.Label1.TabIndex = 1057
			Me.Label1.Text = "Selected Level"
			Me.lblRows.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblRows.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRows.Location = New Global.System.Drawing.Point(454, 0)
			Me.lblRows.Name = "lblRows"
			Me.lblRows.Size = New Global.System.Drawing.Size(87, 15)
			Me.lblRows.TabIndex = 1056
			Me.lblRows.Text = "0 - Rows"
			Me.lblRows.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Panel1.Controls.Add(Me.dgvList)
			Me.Panel1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Panel1.Location = New Global.System.Drawing.Point(4, 105)
			Me.Panel1.Name = "Panel1"
			Me.Panel1.Size = New Global.System.Drawing.Size(541, 352)
			Me.Panel1.TabIndex = 1053
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			MyBase.ClientSize = New Global.System.Drawing.Size(1055, 519)
			MyBase.Controls.Add(Me.btnSave)
			MyBase.Controls.Add(Me.btnClose)
			MyBase.Controls.Add(Me.btnClear)
			MyBase.Controls.Add(Me.GroupBox2)
			MyBase.Controls.Add(Me.GroupBox3)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.Name = "POApprovalRange"
			Me.Text = "PO Approval Range"
			CType(Me.dgvList, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox2.ResumeLayout(False)
			Me.Panel2.ResumeLayout(False)
			CType(Me.dgvLevel, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox3.ResumeLayout(False)
			Me.GroupBox3.PerformLayout()
			Me.Panel1.ResumeLayout(False)
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x040005AD RID: 1453
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
