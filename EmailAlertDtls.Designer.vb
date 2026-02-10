Namespace Datasoft_PIMS
	' Token: 0x0200004B RID: 75
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class EmailAlertDtls
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000D5B RID: 3419 RVA: 0x00079678 File Offset: 0x00077878
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

		' Token: 0x06000D5C RID: 3420 RVA: 0x000796C8 File Offset: 0x000778C8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.pnlBorder = New Global.System.Windows.Forms.Panel()
			Me.pnlMain = New Global.System.Windows.Forms.Panel()
			Me.btnSave = New Global.System.Windows.Forms.Button()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.sml_btnAdd = New Global.System.Windows.Forms.Button()
			Me.txtEmail = New Global.System.Windows.Forms.TextBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.cmbUser = New Global.System.Windows.Forms.ComboBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.dgvEmail = New Global.System.Windows.Forms.DataGridView()
			Me.UserID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Person = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.EmailID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.btnDelete_Email = New Global.System.Windows.Forms.DataGridViewImageColumn()
			Me.skip_lblTrn = New Global.System.Windows.Forms.Label()
			Me.panelTitleBar = New Global.System.Windows.Forms.Panel()
			Me.picFormIcon = New Global.System.Windows.Forms.PictureBox()
			Me.lblCaption = New Global.System.Windows.Forms.Label()
			Me.form_btnClose = New Global.System.Windows.Forms.Button()
			Me.lblShadow1 = New Global.System.Windows.Forms.Label()
			Me.lblShadow2 = New Global.System.Windows.Forms.Label()
			Me.pnlBorder.SuspendLayout()
			Me.pnlMain.SuspendLayout()
			CType(Me.dgvEmail, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelTitleBar.SuspendLayout()
			CType(Me.picFormIcon, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.pnlBorder.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.pnlBorder.BackColor = Global.System.Drawing.Color.SteelBlue
			Me.pnlBorder.Controls.Add(Me.pnlMain)
			Me.pnlBorder.Location = New Global.System.Drawing.Point(0, 0)
			Me.pnlBorder.Name = "pnlBorder"
			Me.pnlBorder.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.pnlBorder.Size = New Global.System.Drawing.Size(705, 359)
			Me.pnlBorder.TabIndex = 4
			Me.pnlMain.BackColor = Global.System.Drawing.Color.White
			Me.pnlMain.Controls.Add(Me.btnSave)
			Me.pnlMain.Controls.Add(Me.btnClose)
			Me.pnlMain.Controls.Add(Me.sml_btnAdd)
			Me.pnlMain.Controls.Add(Me.txtEmail)
			Me.pnlMain.Controls.Add(Me.Label2)
			Me.pnlMain.Controls.Add(Me.cmbUser)
			Me.pnlMain.Controls.Add(Me.Label1)
			Me.pnlMain.Controls.Add(Me.dgvEmail)
			Me.pnlMain.Controls.Add(Me.skip_lblTrn)
			Me.pnlMain.Controls.Add(Me.panelTitleBar)
			Me.pnlMain.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.pnlMain.Location = New Global.System.Drawing.Point(3, 3)
			Me.pnlMain.Name = "pnlMain"
			Me.pnlMain.Size = New Global.System.Drawing.Size(699, 353)
			Me.pnlMain.TabIndex = 1
			Me.btnSave.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnSave.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnSave.Location = New Global.System.Drawing.Point(226, 318)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New Global.System.Drawing.Size(121, 31)
			Me.btnSave.TabIndex = 691
			Me.btnSave.Text = "&Save"
			Me.btnSave.UseVisualStyleBackColor = True
			Me.btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnClose.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClose.Location = New Global.System.Drawing.Point(351, 318)
			Me.btnClose.Name = "btnClose"
			Me.btnClose.Size = New Global.System.Drawing.Size(121, 31)
			Me.btnClose.TabIndex = 692
			Me.btnClose.Text = "C&lose"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.sml_btnAdd.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.sml_btnAdd.FlatAppearance.BorderColor = Global.System.Drawing.Color.Green
			Me.sml_btnAdd.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.FromArgb(255, 255, 192)
			Me.sml_btnAdd.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.PaleGreen
			Me.sml_btnAdd.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.sml_btnAdd.Location = New Global.System.Drawing.Point(621, 65)
			Me.sml_btnAdd.Name = "sml_btnAdd"
			Me.sml_btnAdd.Size = New Global.System.Drawing.Size(75, 23)
			Me.sml_btnAdd.TabIndex = 25
			Me.sml_btnAdd.Text = "Add"
			Me.sml_btnAdd.UseVisualStyleBackColor = True
			Me.txtEmail.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtEmail.Location = New Global.System.Drawing.Point(321, 65)
			Me.txtEmail.Multiline = True
			Me.txtEmail.Name = "txtEmail"
			Me.txtEmail.Size = New Global.System.Drawing.Size(297, 23)
			Me.txtEmail.TabIndex = 24
			Me.Label2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label2.Location = New Global.System.Drawing.Point(257, 65)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(61, 23)
			Me.Label2.TabIndex = 23
			Me.Label2.Text = "Email ID"
			Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.cmbUser.FormattingEnabled = True
			Me.cmbUser.Location = New Global.System.Drawing.Point(61, 65)
			Me.cmbUser.Name = "cmbUser"
			Me.cmbUser.Size = New Global.System.Drawing.Size(193, 23)
			Me.cmbUser.TabIndex = 22
			Me.Label1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label1.Location = New Global.System.Drawing.Point(3, 65)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(55, 23)
			Me.Label1.TabIndex = 21
			Me.Label1.Text = "Person"
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.dgvEmail.AllowUserToAddRows = False
			Me.dgvEmail.AllowUserToDeleteRows = False
			Me.dgvEmail.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.dgvEmail.BackgroundColor = Global.System.Drawing.Color.WhiteSmoke
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.AliceBlue
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvEmail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.dgvEmail.ColumnHeadersHeight = 25
			Me.dgvEmail.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.UserID, Me.Person, Me.EmailID, Me.btnDelete_Email })
			Me.dgvEmail.Location = New Global.System.Drawing.Point(3, 91)
			Me.dgvEmail.Name = "dgvEmail"
			Me.dgvEmail.[ReadOnly] = True
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.Color.AliceBlue
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.Color.PowderBlue
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvEmail.RowHeadersDefaultCellStyle = dataGridViewCellStyle2
			Me.dgvEmail.RowHeadersWidth = 25
			dataGridViewCellStyle3.SelectionBackColor = Global.System.Drawing.Color.PowderBlue
			dataGridViewCellStyle3.SelectionForeColor = Global.System.Drawing.Color.Black
			Me.dgvEmail.RowsDefaultCellStyle = dataGridViewCellStyle3
			Me.dgvEmail.RowTemplate.DefaultCellStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dgvEmail.Size = New Global.System.Drawing.Size(693, 223)
			Me.dgvEmail.TabIndex = 20
			Me.UserID.HeaderText = "UserID"
			Me.UserID.Name = "UserID"
			Me.UserID.[ReadOnly] = True
			Me.UserID.Visible = False
			Me.Person.HeaderText = "Person"
			Me.Person.Name = "Person"
			Me.Person.[ReadOnly] = True
			Me.Person.Width = 200
			Me.EmailID.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
			Me.EmailID.HeaderText = "Email ID"
			Me.EmailID.Name = "EmailID"
			Me.EmailID.[ReadOnly] = True
			Me.btnDelete_Email.HeaderText = ""
			Me.btnDelete_Email.ImageLayout = Global.System.Windows.Forms.DataGridViewImageCellLayout.Stretch
			Me.btnDelete_Email.Name = "btnDelete_Email"
			Me.btnDelete_Email.[ReadOnly] = True
			Me.btnDelete_Email.Width = 35
			Me.skip_lblTrn.BackColor = Global.System.Drawing.Color.SteelBlue
			Me.skip_lblTrn.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.skip_lblTrn.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.skip_lblTrn.ForeColor = Global.System.Drawing.Color.White
			Me.skip_lblTrn.Location = New Global.System.Drawing.Point(3, 30)
			Me.skip_lblTrn.Name = "skip_lblTrn"
			Me.skip_lblTrn.Size = New Global.System.Drawing.Size(693, 32)
			Me.skip_lblTrn.TabIndex = 19
			Me.skip_lblTrn.Text = "Transaction Name"
			Me.skip_lblTrn.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.panelTitleBar.BackColor = Global.System.Drawing.Color.FromArgb(204, 231, 255)
			Me.panelTitleBar.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.panelTitleBar.Controls.Add(Me.picFormIcon)
			Me.panelTitleBar.Controls.Add(Me.lblCaption)
			Me.panelTitleBar.Controls.Add(Me.form_btnClose)
			Me.panelTitleBar.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.panelTitleBar.Location = New Global.System.Drawing.Point(0, 0)
			Me.panelTitleBar.Name = "panelTitleBar"
			Me.panelTitleBar.Size = New Global.System.Drawing.Size(699, 27)
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
			Me.form_btnClose.Location = New Global.System.Drawing.Point(673, 1)
			Me.form_btnClose.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.form_btnClose.Name = "form_btnClose"
			Me.form_btnClose.Size = New Global.System.Drawing.Size(24, 24)
			Me.form_btnClose.TabIndex = 719
			Me.form_btnClose.UseVisualStyleBackColor = True
			Me.lblShadow1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblShadow1.BackColor = Global.System.Drawing.Color.White
			Me.lblShadow1.Location = New Global.System.Drawing.Point(705, 0)
			Me.lblShadow1.Name = "lblShadow1"
			Me.lblShadow1.Size = New Global.System.Drawing.Size(6, 9)
			Me.lblShadow1.TabIndex = 6
			Me.lblShadow2.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
			Me.lblShadow2.BackColor = Global.System.Drawing.Color.White
			Me.lblShadow2.Location = New Global.System.Drawing.Point(0, 358)
			Me.lblShadow2.Name = "lblShadow2"
			Me.lblShadow2.Size = New Global.System.Drawing.Size(9, 7)
			Me.lblShadow2.TabIndex = 5
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.DarkGray
			MyBase.ClientSize = New Global.System.Drawing.Size(710, 364)
			MyBase.Controls.Add(Me.pnlBorder)
			MyBase.Controls.Add(Me.lblShadow1)
			MyBase.Controls.Add(Me.lblShadow2)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedToolWindow
			MyBase.Name = "EmailAlertDtls"
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Email Alert Details"
			Me.pnlBorder.ResumeLayout(False)
			Me.pnlMain.ResumeLayout(False)
			Me.pnlMain.PerformLayout()
			CType(Me.dgvEmail, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelTitleBar.ResumeLayout(False)
			Me.panelTitleBar.PerformLayout()
			CType(Me.picFormIcon, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000583 RID: 1411
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
