Namespace Datasoft_PIMS
	' Token: 0x02000054 RID: 84
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class UploadStock
		Inherits Global.WeifenLuo.WinFormsUI.Docking.DockContent

		' Token: 0x06000F95 RID: 3989 RVA: 0x0008DA94 File Offset: 0x0008BC94
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

		' Token: 0x06000F96 RID: 3990 RVA: 0x0008DAE4 File Offset: 0x0008BCE4
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle4 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle5 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle6 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.btnStock = New Global.System.Windows.Forms.Button()
			Me.theme_tc = New Global.System.Windows.Forms.TabControl()
			Me.tpDetails = New Global.System.Windows.Forms.TabPage()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.dgvList = New Global.System.Windows.Forms.DataGridView()
			Me.lblRowsG = New Global.System.Windows.Forms.Label()
			Me.tab_lbl1 = New Global.System.Windows.Forms.Label()
			Me.tpList = New Global.System.Windows.Forms.TabPage()
			Me.btnExport = New Global.System.Windows.Forms.Button()
			Me.btnSetStock = New Global.System.Windows.Forms.Button()
			Me.btnProcess = New Global.System.Windows.Forms.Button()
			Me.Panel2 = New Global.System.Windows.Forms.Panel()
			Me.dgvGRN = New Global.System.Windows.Forms.DataGridView()
			Me.lblRows = New Global.System.Windows.Forms.Label()
			Me.tab_lbl2 = New Global.System.Windows.Forms.Label()
			Me.theme_tc.SuspendLayout()
			Me.tpDetails.SuspendLayout()
			Me.Panel1.SuspendLayout()
			CType(Me.dgvList, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tpList.SuspendLayout()
			Me.Panel2.SuspendLayout()
			CType(Me.dgvGRN, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.btnStock.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnStock.Location = New Global.System.Drawing.Point(6, 12)
			Me.btnStock.Name = "btnStock"
			Me.btnStock.Size = New Global.System.Drawing.Size(158, 32)
			Me.btnStock.TabIndex = 0
			Me.btnStock.Text = "Get Uploaded Stock"
			Me.btnStock.UseVisualStyleBackColor = True
			Me.theme_tc.Controls.Add(Me.tpDetails)
			Me.theme_tc.Controls.Add(Me.tpList)
			Me.theme_tc.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.theme_tc.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.theme_tc.ItemSize = New Global.System.Drawing.Size(415, 21)
			Me.theme_tc.Location = New Global.System.Drawing.Point(0, 0)
			Me.theme_tc.Name = "theme_tc"
			Me.theme_tc.SelectedIndex = 0
			Me.theme_tc.Size = New Global.System.Drawing.Size(933, 519)
			Me.theme_tc.SizeMode = Global.System.Windows.Forms.TabSizeMode.Fixed
			Me.theme_tc.TabIndex = 13
			Me.theme_tc.TabStop = False
			Me.tpDetails.BackColor = Global.System.Drawing.Color.White
			Me.tpDetails.Controls.Add(Me.Panel1)
			Me.tpDetails.Controls.Add(Me.lblRowsG)
			Me.tpDetails.Controls.Add(Me.tab_lbl1)
			Me.tpDetails.Controls.Add(Me.btnStock)
			Me.tpDetails.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.tpDetails.Location = New Global.System.Drawing.Point(4, 25)
			Me.tpDetails.Name = "tpDetails"
			Me.tpDetails.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tpDetails.Size = New Global.System.Drawing.Size(925, 490)
			Me.tpDetails.TabIndex = 0
			Me.tpDetails.Text = "Stock"
			Me.tpDetails.UseVisualStyleBackColor = True
			Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Panel1.Controls.Add(Me.dgvList)
			Me.Panel1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Panel1.Location = New Global.System.Drawing.Point(2, 50)
			Me.Panel1.Name = "Panel1"
			Me.Panel1.Size = New Global.System.Drawing.Size(920, 437)
			Me.Panel1.TabIndex = 485
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
			Me.dgvList.Location = New Global.System.Drawing.Point(0, 0)
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
			Me.dgvList.Size = New Global.System.Drawing.Size(920, 437)
			Me.dgvList.TabIndex = 12
			Me.lblRowsG.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblRowsG.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblRowsG.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRowsG.Location = New Global.System.Drawing.Point(809, 29)
			Me.lblRowsG.Name = "lblRowsG"
			Me.lblRowsG.Size = New Global.System.Drawing.Size(108, 15)
			Me.lblRowsG.TabIndex = 484
			Me.lblRowsG.Text = "0 - Rows"
			Me.lblRowsG.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.tab_lbl1.BackColor = Global.System.Drawing.Color.Black
			Me.tab_lbl1.ForeColor = Global.System.Drawing.Color.PaleGreen
			Me.tab_lbl1.Location = New Global.System.Drawing.Point(0, 0)
			Me.tab_lbl1.Name = "tab_lbl1"
			Me.tab_lbl1.Size = New Global.System.Drawing.Size(852, 3)
			Me.tab_lbl1.TabIndex = 32
			Me.tpList.BackColor = Global.System.Drawing.Color.White
			Me.tpList.Controls.Add(Me.btnExport)
			Me.tpList.Controls.Add(Me.btnSetStock)
			Me.tpList.Controls.Add(Me.btnProcess)
			Me.tpList.Controls.Add(Me.Panel2)
			Me.tpList.Controls.Add(Me.lblRows)
			Me.tpList.Controls.Add(Me.tab_lbl2)
			Me.tpList.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.tpList.Location = New Global.System.Drawing.Point(4, 25)
			Me.tpList.Name = "tpList"
			Me.tpList.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tpList.Size = New Global.System.Drawing.Size(925, 490)
			Me.tpList.TabIndex = 1
			Me.tpList.Text = "GRN"
			Me.tpList.UseVisualStyleBackColor = True
			Me.btnExport.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnExport.Location = New Global.System.Drawing.Point(167, 14)
			Me.btnExport.Margin = New Global.System.Windows.Forms.Padding(0, 3, 2, 3)
			Me.btnExport.Name = "btnExport"
			Me.btnExport.Size = New Global.System.Drawing.Size(116, 29)
			Me.btnExport.TabIndex = 490
			Me.btnExport.Text = "Export XL"
			Me.btnExport.UseVisualStyleBackColor = True
			Me.btnSetStock.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnSetStock.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnSetStock.Location = New Global.System.Drawing.Point(383, 454)
			Me.btnSetStock.Name = "btnSetStock"
			Me.btnSetStock.Size = New Global.System.Drawing.Size(158, 32)
			Me.btnSetStock.TabIndex = 489
			Me.btnSetStock.Text = "Set Opening Stock"
			Me.btnSetStock.UseVisualStyleBackColor = True
			Me.btnProcess.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnProcess.Location = New Global.System.Drawing.Point(6, 12)
			Me.btnProcess.Name = "btnProcess"
			Me.btnProcess.Size = New Global.System.Drawing.Size(158, 32)
			Me.btnProcess.TabIndex = 488
			Me.btnProcess.Text = "Process Stock"
			Me.btnProcess.UseVisualStyleBackColor = True
			Me.Panel2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.Panel2.Controls.Add(Me.dgvGRN)
			Me.Panel2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Panel2.Location = New Global.System.Drawing.Point(2, 50)
			Me.Panel2.Name = "Panel2"
			Me.Panel2.Size = New Global.System.Drawing.Size(920, 400)
			Me.Panel2.TabIndex = 487
			Me.dgvGRN.AllowUserToAddRows = False
			Me.dgvGRN.AllowUserToDeleteRows = False
			Me.dgvGRN.BackgroundColor = Global.System.Drawing.Color.WhiteSmoke
			dataGridViewCellStyle4.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle4.BackColor = Global.System.Drawing.Color.AliceBlue
			dataGridViewCellStyle4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle4.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle4.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle4.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle4.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvGRN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4
			Me.dgvGRN.ColumnHeadersHeight = 35
			Me.dgvGRN.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.dgvGRN.Location = New Global.System.Drawing.Point(0, 0)
			Me.dgvGRN.Name = "dgvGRN"
			Me.dgvGRN.[ReadOnly] = True
			dataGridViewCellStyle5.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle5.BackColor = Global.System.Drawing.Color.AliceBlue
			dataGridViewCellStyle5.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle5.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle5.SelectionBackColor = Global.System.Drawing.Color.PowderBlue
			dataGridViewCellStyle5.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle5.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvGRN.RowHeadersDefaultCellStyle = dataGridViewCellStyle5
			Me.dgvGRN.RowHeadersWidth = 25
			dataGridViewCellStyle6.SelectionBackColor = Global.System.Drawing.Color.PowderBlue
			dataGridViewCellStyle6.SelectionForeColor = Global.System.Drawing.Color.Black
			Me.dgvGRN.RowsDefaultCellStyle = dataGridViewCellStyle6
			Me.dgvGRN.RowTemplate.DefaultCellStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dgvGRN.Size = New Global.System.Drawing.Size(920, 400)
			Me.dgvGRN.TabIndex = 12
			Me.lblRows.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblRows.BackColor = Global.System.Drawing.Color.Transparent
			Me.lblRows.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRows.Location = New Global.System.Drawing.Point(809, 29)
			Me.lblRows.Name = "lblRows"
			Me.lblRows.Size = New Global.System.Drawing.Size(108, 15)
			Me.lblRows.TabIndex = 486
			Me.lblRows.Text = "0 - Rows"
			Me.lblRows.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.tab_lbl2.BackColor = Global.System.Drawing.Color.Black
			Me.tab_lbl2.ForeColor = Global.System.Drawing.Color.PaleGreen
			Me.tab_lbl2.Location = New Global.System.Drawing.Point(0, 0)
			Me.tab_lbl2.Name = "tab_lbl2"
			Me.tab_lbl2.Size = New Global.System.Drawing.Size(853, 3)
			Me.tab_lbl2.TabIndex = 7
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			MyBase.ClientSize = New Global.System.Drawing.Size(933, 519)
			MyBase.Controls.Add(Me.theme_tc)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.Name = "UploadStock"
			Me.Text = "Upload Stock"
			Me.theme_tc.ResumeLayout(False)
			Me.tpDetails.ResumeLayout(False)
			Me.Panel1.ResumeLayout(False)
			CType(Me.dgvList, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.tpList.ResumeLayout(False)
			Me.Panel2.ResumeLayout(False)
			CType(Me.dgvGRN, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000679 RID: 1657
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
