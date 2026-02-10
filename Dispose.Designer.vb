Namespace Datasoft_PIMS
	' Token: 0x0200005F RID: 95
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Dispose
		Inherits Global.WeifenLuo.WinFormsUI.Docking.DockContent

		' Token: 0x0600152D RID: 5421 RVA: 0x000C1D08 File Offset: 0x000BFF08
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

		' Token: 0x0600152E RID: 5422 RVA: 0x000C1D58 File Offset: 0x000BFF58
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.dgvUID = New Global.System.Windows.Forms.DataGridView()
			Me.sml_btnAdd = New Global.System.Windows.Forms.Button()
			Me.lblRows = New Global.System.Windows.Forms.Label()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.txtBarcode = New Global.System.Windows.Forms.TextBox()
			Me.txtRemarks = New Global.System.Windows.Forms.TextBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.btnDispose = New Global.System.Windows.Forms.Button()
			Me.btnClear = New Global.System.Windows.Forms.Button()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.btnDelete_Item = New Global.System.Windows.Forms.DataGridViewImageColumn()
			Me.UID = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.LocationCode = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.CatalogNo = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ProductName = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Description = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.GRNNo = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.BatchNo = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ExpDt = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Status = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			CType(Me.dgvUID, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.dgvUID.AllowUserToAddRows = False
			Me.dgvUID.AllowUserToDeleteRows = False
			Me.dgvUID.AllowUserToResizeRows = False
			Me.dgvUID.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.dgvUID.BackgroundColor = Global.System.Drawing.Color.WhiteSmoke
			dataGridViewCellStyle.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle.BackColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.SystemColors.GradientInactiveCaption
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.Color.Black
			dataGridViewCellStyle.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvUID.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle
			Me.dgvUID.ColumnHeadersHeight = 25
			Me.dgvUID.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
			Me.dgvUID.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.btnDelete_Item, Me.UID, Me.LocationCode, Me.CatalogNo, Me.ProductName, Me.Description, Me.GRNNo, Me.BatchNo, Me.ExpDt, Me.Status })
			Me.dgvUID.Location = New Global.System.Drawing.Point(4, 34)
			Me.dgvUID.Name = "dgvUID"
			Me.dgvUID.[ReadOnly] = True
			Me.dgvUID.RowHeadersWidth = 30
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dgvUID.RowsDefaultCellStyle = dataGridViewCellStyle2
			Me.dgvUID.RowTemplate.Height = 25
			Me.dgvUID.Size = New Global.System.Drawing.Size(925, 388)
			Me.dgvUID.TabIndex = 1149
			Me.sml_btnAdd.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.sml_btnAdd.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.sml_btnAdd.Location = New Global.System.Drawing.Point(459, 6)
			Me.sml_btnAdd.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.sml_btnAdd.Name = "sml_btnAdd"
			Me.sml_btnAdd.Size = New Global.System.Drawing.Size(101, 23)
			Me.sml_btnAdd.TabIndex = 1148
			Me.sml_btnAdd.Text = "Add"
			Me.sml_btnAdd.UseVisualStyleBackColor = True
			Me.lblRows.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblRows.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRows.Location = New Global.System.Drawing.Point(796, 12)
			Me.lblRows.Name = "lblRows"
			Me.lblRows.Size = New Global.System.Drawing.Size(133, 15)
			Me.lblRows.TabIndex = 1147
			Me.lblRows.Text = "0 - Rows"
			Me.lblRows.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.Location = New Global.System.Drawing.Point(12, 10)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(101, 15)
			Me.Label1.TabIndex = 1146
			Me.Label1.Text = "Product Barcode"
			Me.txtBarcode.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtBarcode.Location = New Global.System.Drawing.Point(119, 7)
			Me.txtBarcode.MaxLength = 10
			Me.txtBarcode.Name = "txtBarcode"
			Me.txtBarcode.Size = New Global.System.Drawing.Size(337, 21)
			Me.txtBarcode.TabIndex = 0
			Me.txtRemarks.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtRemarks.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtRemarks.Location = New Global.System.Drawing.Point(119, 428)
			Me.txtRemarks.MaxLength = 10
			Me.txtRemarks.Multiline = True
			Me.txtRemarks.Name = "txtRemarks"
			Me.txtRemarks.Size = New Global.System.Drawing.Size(810, 46)
			Me.txtRemarks.TabIndex = 1
			Me.Label2.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.Location = New Global.System.Drawing.Point(12, 431)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(107, 15)
			Me.Label2.TabIndex = 1151
			Me.Label2.Text = "Dispose Remarks"
			Me.btnDispose.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnDispose.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnDispose.Location = New Global.System.Drawing.Point(295, 487)
			Me.btnDispose.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnDispose.Name = "btnDispose"
			Me.btnDispose.Size = New Global.System.Drawing.Size(113, 26)
			Me.btnDispose.TabIndex = 1152
			Me.btnDispose.Text = "&Dispose"
			Me.btnDispose.UseVisualStyleBackColor = True
			Me.btnClear.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnClear.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClear.Location = New Global.System.Drawing.Point(410, 487)
			Me.btnClear.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnClear.Name = "btnClear"
			Me.btnClear.Size = New Global.System.Drawing.Size(113, 26)
			Me.btnClear.TabIndex = 1153
			Me.btnClear.Text = "&Clear"
			Me.btnClear.UseVisualStyleBackColor = True
			Me.btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnClose.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClose.Location = New Global.System.Drawing.Point(525, 487)
			Me.btnClose.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnClose.Name = "btnClose"
			Me.btnClose.Size = New Global.System.Drawing.Size(113, 26)
			Me.btnClose.TabIndex = 1154
			Me.btnClose.Text = "C&lose"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.btnDelete_Item.HeaderText = ""
			Me.btnDelete_Item.ImageLayout = Global.System.Windows.Forms.DataGridViewImageCellLayout.Stretch
			Me.btnDelete_Item.Name = "btnDelete_Item"
			Me.btnDelete_Item.[ReadOnly] = True
			Me.btnDelete_Item.Width = 25
			Me.UID.DataPropertyName = "UID"
			Me.UID.HeaderText = "UID"
			Me.UID.Name = "UID"
			Me.UID.[ReadOnly] = True
			Me.UID.Width = 150
			Me.LocationCode.DataPropertyName = "LocationCode"
			Me.LocationCode.HeaderText = "Location Code"
			Me.LocationCode.Name = "LocationCode"
			Me.LocationCode.[ReadOnly] = True
			Me.LocationCode.SortMode = Global.System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
			Me.LocationCode.Width = 150
			Me.CatalogNo.DataPropertyName = "CatalogNo"
			Me.CatalogNo.HeaderText = "Catalog No."
			Me.CatalogNo.Name = "CatalogNo"
			Me.CatalogNo.[ReadOnly] = True
			Me.CatalogNo.Width = 120
			Me.ProductName.DataPropertyName = "ProductName"
			Me.ProductName.HeaderText = "Product Name"
			Me.ProductName.Name = "ProductName"
			Me.ProductName.[ReadOnly] = True
			Me.ProductName.Width = 250
			Me.Description.DataPropertyName = "Description"
			Me.Description.HeaderText = "Description"
			Me.Description.Name = "Description"
			Me.Description.[ReadOnly] = True
			Me.Description.Width = 250
			Me.GRNNo.DataPropertyName = "GRNNo"
			Me.GRNNo.HeaderText = "GRN No."
			Me.GRNNo.Name = "GRNNo"
			Me.GRNNo.[ReadOnly] = True
			Me.GRNNo.Width = 120
			Me.BatchNo.DataPropertyName = "BatchNo"
			Me.BatchNo.HeaderText = "Batch No."
			Me.BatchNo.Name = "BatchNo"
			Me.BatchNo.[ReadOnly] = True
			Me.BatchNo.Width = 250
			Me.ExpDt.DataPropertyName = "ExpDt"
			dataGridViewCellStyle3.Format = "dd-MMM-yyyy"
			Me.ExpDt.DefaultCellStyle = dataGridViewCellStyle3
			Me.ExpDt.HeaderText = "Expiry Date"
			Me.ExpDt.Name = "ExpDt"
			Me.ExpDt.[ReadOnly] = True
			Me.Status.DataPropertyName = "Status"
			Me.Status.HeaderText = "Status"
			Me.Status.Name = "Status"
			Me.Status.[ReadOnly] = True
			Me.Status.Visible = False
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			MyBase.ClientSize = New Global.System.Drawing.Size(933, 519)
			MyBase.Controls.Add(Me.btnDispose)
			MyBase.Controls.Add(Me.btnClear)
			MyBase.Controls.Add(Me.btnClose)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.txtRemarks)
			MyBase.Controls.Add(Me.dgvUID)
			MyBase.Controls.Add(Me.sml_btnAdd)
			MyBase.Controls.Add(Me.lblRows)
			MyBase.Controls.Add(Me.Label1)
			MyBase.Controls.Add(Me.txtBarcode)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.Name = "Dispose"
			Me.Text = "Dispose"
			CType(Me.dgvUID, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000905 RID: 2309
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
