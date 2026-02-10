Namespace Datasoft_PIMS
	' Token: 0x0200004A RID: 74
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class EmailAlert
		Inherits Global.WeifenLuo.WinFormsUI.Docking.DockContent

		' Token: 0x06000D3E RID: 3390 RVA: 0x00078544 File Offset: 0x00076744
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

		' Token: 0x06000D3F RID: 3391 RVA: 0x00078594 File Offset: 0x00076794
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.btnSave = New Global.System.Windows.Forms.Button()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.skip_dgvAutoMailing = New Global.System.Windows.Forms.DataGridView()
			Me.Setting = New Global.System.Windows.Forms.DataGridViewImageColumn()
			Me.EmailSettingsID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Transactions = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.AutoMailing = New Global.System.Windows.Forms.DataGridViewImageColumn()
			Me.AutoMailingVal = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			CType(Me.skip_dgvAutoMailing, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.btnSave.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnSave.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 12F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnSave.Location = New Global.System.Drawing.Point(70, 505)
			Me.btnSave.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New Global.System.Drawing.Size(73, 32)
			Me.btnSave.TabIndex = 15
			Me.btnSave.Text = "&Save"
			Me.btnSave.UseVisualStyleBackColor = True
			Me.btnSave.Visible = False
			Me.btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnClose.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 12F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClose.Location = New Global.System.Drawing.Point(287, 505)
			Me.btnClose.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnClose.Name = "btnClose"
			Me.btnClose.Size = New Global.System.Drawing.Size(210, 32)
			Me.btnClose.TabIndex = 16
			Me.btnClose.Text = "C&lose"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.skip_dgvAutoMailing.AllowUserToAddRows = False
			Me.skip_dgvAutoMailing.AllowUserToDeleteRows = False
			Me.skip_dgvAutoMailing.AllowUserToResizeColumns = False
			Me.skip_dgvAutoMailing.AllowUserToResizeRows = False
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.Azure
			Me.skip_dgvAutoMailing.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle
			Me.skip_dgvAutoMailing.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.skip_dgvAutoMailing.BackgroundColor = Global.System.Drawing.Color.White
			Me.skip_dgvAutoMailing.CellBorderStyle = Global.System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
			dataGridViewCellStyle2.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle2.BackColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle2.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.SystemColors.GradientInactiveCaption
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle2.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.skip_dgvAutoMailing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2
			Me.skip_dgvAutoMailing.ColumnHeadersHeight = 50
			Me.skip_dgvAutoMailing.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.skip_dgvAutoMailing.ColumnHeadersVisible = False
			Me.skip_dgvAutoMailing.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.Setting, Me.EmailSettingsID, Me.Transactions, Me.AutoMailing, Me.AutoMailingVal })
			Me.skip_dgvAutoMailing.Location = New Global.System.Drawing.Point(8, 6)
			Me.skip_dgvAutoMailing.MultiSelect = False
			Me.skip_dgvAutoMailing.Name = "skip_dgvAutoMailing"
			Me.skip_dgvAutoMailing.[ReadOnly] = True
			Me.skip_dgvAutoMailing.RowHeadersVisible = False
			dataGridViewCellStyle3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.skip_dgvAutoMailing.RowsDefaultCellStyle = dataGridViewCellStyle3
			Me.skip_dgvAutoMailing.RowTemplate.DefaultCellStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 12F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.skip_dgvAutoMailing.RowTemplate.Height = 50
			Me.skip_dgvAutoMailing.RowTemplate.Resizable = Global.System.Windows.Forms.DataGridViewTriState.[False]
			Me.skip_dgvAutoMailing.Size = New Global.System.Drawing.Size(769, 493)
			Me.skip_dgvAutoMailing.TabIndex = 17
			Me.Setting.HeaderText = "Setting"
			Me.Setting.ImageLayout = Global.System.Windows.Forms.DataGridViewImageCellLayout.Stretch
			Me.Setting.Name = "Setting"
			Me.Setting.[ReadOnly] = True
			Me.Setting.Width = 50
			Me.EmailSettingsID.HeaderText = "EmailSettingsID"
			Me.EmailSettingsID.Name = "EmailSettingsID"
			Me.EmailSettingsID.[ReadOnly] = True
			Me.EmailSettingsID.Visible = False
			Me.Transactions.AutoSizeMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
			Me.Transactions.HeaderText = "Transactions"
			Me.Transactions.Name = "Transactions"
			Me.Transactions.[ReadOnly] = True
			Me.AutoMailing.HeaderText = "AutoMailing"
			Me.AutoMailing.Name = "AutoMailing"
			Me.AutoMailing.[ReadOnly] = True
			Me.AutoMailing.Width = 120
			Me.AutoMailingVal.HeaderText = "AutoMailingVal"
			Me.AutoMailingVal.Name = "AutoMailingVal"
			Me.AutoMailingVal.[ReadOnly] = True
			Me.AutoMailingVal.Visible = False
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			MyBase.ClientSize = New Global.System.Drawing.Size(784, 541)
			MyBase.Controls.Add(Me.skip_dgvAutoMailing)
			MyBase.Controls.Add(Me.btnSave)
			MyBase.Controls.Add(Me.btnClose)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.Name = "EmailAlert"
			Me.Text = "Email Alerts Setting"
			CType(Me.skip_dgvAutoMailing, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x0400057A RID: 1402
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
