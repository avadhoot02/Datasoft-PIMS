Namespace Datasoft_PIMS
	' Token: 0x0200006B RID: 107
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class RequestItems
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06001CC0 RID: 7360 RVA: 0x0010CEAC File Offset: 0x0010B0AC
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

		' Token: 0x06001CC1 RID: 7361 RVA: 0x0010CEFC File Offset: 0x0010B0FC
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.pnlBorder = New Global.System.Windows.Forms.Panel()
			Me.pnlMain = New Global.System.Windows.Forms.Panel()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.txtReqQtyTer = New Global.System.Windows.Forms.TextBox()
			Me.Label20 = New Global.System.Windows.Forms.Label()
			Me.txtPrimaryUOM = New Global.System.Windows.Forms.TextBox()
			Me.txtPrimaryPackSize = New Global.System.Windows.Forms.TextBox()
			Me.Label17 = New Global.System.Windows.Forms.Label()
			Me.Label14 = New Global.System.Windows.Forms.Label()
			Me.txtTertiaryPackSize = New Global.System.Windows.Forms.TextBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.txtTertiaryUOM = New Global.System.Windows.Forms.TextBox()
			Me.Label19 = New Global.System.Windows.Forms.Label()
			Me.txtProductName = New Global.System.Windows.Forms.TextBox()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.txtID = New Global.System.Windows.Forms.TextBox()
			Me.txtCatalogNo = New Global.System.Windows.Forms.TextBox()
			Me.cmbType = New Global.System.Windows.Forms.ComboBox()
			Me.Label18 = New Global.System.Windows.Forms.Label()
			Me.cmbProduct = New Global.System.Windows.Forms.ComboBox()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.txtReqQty = New Global.System.Windows.Forms.TextBox()
			Me.btnSave = New Global.System.Windows.Forms.Button()
			Me.btnDelete = New Global.System.Windows.Forms.Button()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.Label12 = New Global.System.Windows.Forms.Label()
			Me.txtAvlQty = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.txtDesc = New Global.System.Windows.Forms.TextBox()
			Me.panelTitleBar = New Global.System.Windows.Forms.Panel()
			Me.picFormIcon = New Global.System.Windows.Forms.PictureBox()
			Me.lblCaption = New Global.System.Windows.Forms.Label()
			Me.form_btnClose = New Global.System.Windows.Forms.Button()
			Me.lblShadow1 = New Global.System.Windows.Forms.Label()
			Me.lblShadow2 = New Global.System.Windows.Forms.Label()
			Me.txtIssuedQty = New Global.System.Windows.Forms.TextBox()
			Me.txtPickedQty = New Global.System.Windows.Forms.TextBox()
			Me.pnlBorder.SuspendLayout()
			Me.pnlMain.SuspendLayout()
			Me.panelTitleBar.SuspendLayout()
			CType(Me.picFormIcon, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.pnlBorder.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.pnlBorder.BackColor = Global.System.Drawing.Color.SteelBlue
			Me.pnlBorder.Controls.Add(Me.pnlMain)
			Me.pnlBorder.Location = New Global.System.Drawing.Point(0, 0)
			Me.pnlBorder.Name = "pnlBorder"
			Me.pnlBorder.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.pnlBorder.Size = New Global.System.Drawing.Size(627, 374)
			Me.pnlBorder.TabIndex = 4
			Me.pnlMain.BackColor = Global.System.Drawing.Color.White
			Me.pnlMain.Controls.Add(Me.txtPickedQty)
			Me.pnlMain.Controls.Add(Me.txtIssuedQty)
			Me.pnlMain.Controls.Add(Me.Label8)
			Me.pnlMain.Controls.Add(Me.Label7)
			Me.pnlMain.Controls.Add(Me.Label6)
			Me.pnlMain.Controls.Add(Me.Label3)
			Me.pnlMain.Controls.Add(Me.txtReqQtyTer)
			Me.pnlMain.Controls.Add(Me.Label20)
			Me.pnlMain.Controls.Add(Me.txtPrimaryUOM)
			Me.pnlMain.Controls.Add(Me.txtPrimaryPackSize)
			Me.pnlMain.Controls.Add(Me.Label17)
			Me.pnlMain.Controls.Add(Me.Label14)
			Me.pnlMain.Controls.Add(Me.txtTertiaryPackSize)
			Me.pnlMain.Controls.Add(Me.Label5)
			Me.pnlMain.Controls.Add(Me.txtTertiaryUOM)
			Me.pnlMain.Controls.Add(Me.Label19)
			Me.pnlMain.Controls.Add(Me.txtProductName)
			Me.pnlMain.Controls.Add(Me.Label4)
			Me.pnlMain.Controls.Add(Me.txtID)
			Me.pnlMain.Controls.Add(Me.txtCatalogNo)
			Me.pnlMain.Controls.Add(Me.cmbType)
			Me.pnlMain.Controls.Add(Me.Label18)
			Me.pnlMain.Controls.Add(Me.cmbProduct)
			Me.pnlMain.Controls.Add(Me.Label9)
			Me.pnlMain.Controls.Add(Me.Label2)
			Me.pnlMain.Controls.Add(Me.txtReqQty)
			Me.pnlMain.Controls.Add(Me.btnSave)
			Me.pnlMain.Controls.Add(Me.btnDelete)
			Me.pnlMain.Controls.Add(Me.btnClose)
			Me.pnlMain.Controls.Add(Me.Label12)
			Me.pnlMain.Controls.Add(Me.txtAvlQty)
			Me.pnlMain.Controls.Add(Me.Label1)
			Me.pnlMain.Controls.Add(Me.txtDesc)
			Me.pnlMain.Controls.Add(Me.panelTitleBar)
			Me.pnlMain.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.pnlMain.Location = New Global.System.Drawing.Point(3, 3)
			Me.pnlMain.Name = "pnlMain"
			Me.pnlMain.Size = New Global.System.Drawing.Size(621, 368)
			Me.pnlMain.TabIndex = 1
			Me.Label8.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label8.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label8.Location = New Global.System.Drawing.Point(525, 283)
			Me.Label8.Name = "Label8"
			Me.Label8.Size = New Global.System.Drawing.Size(77, 21)
			Me.Label8.TabIndex = 1220
			Me.Label8.Text = "in Tertiary"
			Me.Label8.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label7.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label7.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label7.Location = New Global.System.Drawing.Point(220, 281)
			Me.Label7.Name = "Label7"
			Me.Label7.Size = New Global.System.Drawing.Size(77, 21)
			Me.Label7.TabIndex = 1219
			Me.Label7.Text = "in Primary"
			Me.Label7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label6.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label6.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label6.Location = New Global.System.Drawing.Point(525, 200)
			Me.Label6.Name = "Label6"
			Me.Label6.Size = New Global.System.Drawing.Size(77, 21)
			Me.Label6.TabIndex = 1218
			Me.Label6.Text = "in Primary"
			Me.Label6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.Location = New Global.System.Drawing.Point(311, 284)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(110, 15)
			Me.Label3.TabIndex = 1217
			Me.Label3.Text = "Required Quantity" & vbCr
			Me.txtReqQtyTer.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtReqQtyTer.Location = New Global.System.Drawing.Point(426, 283)
			Me.txtReqQtyTer.Name = "txtReqQtyTer"
			Me.txtReqQtyTer.Size = New Global.System.Drawing.Size(95, 21)
			Me.txtReqQtyTer.TabIndex = 4
			Me.Label20.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label20.AutoSize = True
			Me.Label20.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label20.Location = New Global.System.Drawing.Point(8, 175)
			Me.Label20.Name = "Label20"
			Me.Label20.Size = New Global.System.Drawing.Size(82, 15)
			Me.Label20.TabIndex = 1215
			Me.Label20.Text = "Primary UOM"
			Me.txtPrimaryUOM.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.txtPrimaryUOM.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPrimaryUOM.Location = New Global.System.Drawing.Point(121, 172)
			Me.txtPrimaryUOM.Name = "txtPrimaryUOM"
			Me.txtPrimaryUOM.[ReadOnly] = True
			Me.txtPrimaryUOM.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtPrimaryUOM.TabIndex = 1214
			Me.txtPrimaryUOM.TabStop = False
			Me.txtPrimaryPackSize.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.txtPrimaryPackSize.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPrimaryPackSize.Location = New Global.System.Drawing.Point(426, 172)
			Me.txtPrimaryPackSize.Name = "txtPrimaryPackSize"
			Me.txtPrimaryPackSize.[ReadOnly] = True
			Me.txtPrimaryPackSize.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtPrimaryPackSize.TabIndex = 1210
			Me.txtPrimaryPackSize.TabStop = False
			Me.Label17.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label17.AutoSize = True
			Me.Label17.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label17.Location = New Global.System.Drawing.Point(311, 175)
			Me.Label17.Name = "Label17"
			Me.Label17.Size = New Global.System.Drawing.Size(107, 15)
			Me.Label17.TabIndex = 1213
			Me.Label17.Text = "Primary PackSize"
			Me.Label14.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label14.AutoSize = True
			Me.Label14.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label14.Location = New Global.System.Drawing.Point(311, 148)
			Me.Label14.Name = "Label14"
			Me.Label14.Size = New Global.System.Drawing.Size(107, 15)
			Me.Label14.TabIndex = 1212
			Me.Label14.Text = "Tertiary PackSize"
			Me.txtTertiaryPackSize.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.txtTertiaryPackSize.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtTertiaryPackSize.Location = New Global.System.Drawing.Point(426, 145)
			Me.txtTertiaryPackSize.Name = "txtTertiaryPackSize"
			Me.txtTertiaryPackSize.[ReadOnly] = True
			Me.txtTertiaryPackSize.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtTertiaryPackSize.TabIndex = 1209
			Me.txtTertiaryPackSize.TabStop = False
			Me.Label5.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label5.AutoSize = True
			Me.Label5.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label5.Location = New Global.System.Drawing.Point(8, 148)
			Me.Label5.Name = "Label5"
			Me.Label5.Size = New Global.System.Drawing.Size(82, 15)
			Me.Label5.TabIndex = 1211
			Me.Label5.Text = "Tertiary UOM"
			Me.txtTertiaryUOM.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.txtTertiaryUOM.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtTertiaryUOM.Location = New Global.System.Drawing.Point(121, 145)
			Me.txtTertiaryUOM.Name = "txtTertiaryUOM"
			Me.txtTertiaryUOM.[ReadOnly] = True
			Me.txtTertiaryUOM.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtTertiaryUOM.TabIndex = 1208
			Me.txtTertiaryUOM.TabStop = False
			Me.Label19.AutoSize = True
			Me.Label19.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label19.Location = New Global.System.Drawing.Point(8, 94)
			Me.Label19.Name = "Label19"
			Me.Label19.Size = New Global.System.Drawing.Size(87, 15)
			Me.Label19.TabIndex = 1129
			Me.Label19.Text = "Product Name"
			Me.txtProductName.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtProductName.Location = New Global.System.Drawing.Point(120, 91)
			Me.txtProductName.Name = "txtProductName"
			Me.txtProductName.[ReadOnly] = True
			Me.txtProductName.Size = New Global.System.Drawing.Size(482, 21)
			Me.txtProductName.TabIndex = 1128
			Me.txtProductName.TabStop = False
			Me.Label4.AutoSize = True
			Me.Label4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label4.Location = New Global.System.Drawing.Point(8, 121)
			Me.Label4.Name = "Label4"
			Me.Label4.Size = New Global.System.Drawing.Size(74, 15)
			Me.Label4.TabIndex = 1125
			Me.Label4.Text = "Catalog No."
			Me.txtID.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtID.Location = New Global.System.Drawing.Point(579, 338)
			Me.txtID.Name = "txtID"
			Me.txtID.Size = New Global.System.Drawing.Size(20, 21)
			Me.txtID.TabIndex = 1124
			Me.txtID.TabStop = False
			Me.txtID.Visible = False
			Me.txtCatalogNo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.txtCatalogNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtCatalogNo.Location = New Global.System.Drawing.Point(121, 118)
			Me.txtCatalogNo.Name = "txtCatalogNo"
			Me.txtCatalogNo.[ReadOnly] = True
			Me.txtCatalogNo.Size = New Global.System.Drawing.Size(481, 21)
			Me.txtCatalogNo.TabIndex = 2
			Me.txtCatalogNo.TabStop = False
			Me.cmbType.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.cmbType.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbType.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbType.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbType.FormattingEnabled = True
			Me.cmbType.Items.AddRange(New Object() { "", "Raw Material", "Packaging Material", "Consumable", "Semi Finished", "Cell Bank - Mammalian", "Cell Bank - Bacterial", "Others" })
			Me.cmbType.Location = New Global.System.Drawing.Point(121, 33)
			Me.cmbType.Name = "cmbType"
			Me.cmbType.Size = New Global.System.Drawing.Size(481, 23)
			Me.cmbType.TabIndex = 0
			Me.Label18.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label18.AutoSize = True
			Me.Label18.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label18.Location = New Global.System.Drawing.Point(8, 37)
			Me.Label18.Name = "Label18"
			Me.Label18.Size = New Global.System.Drawing.Size(82, 15)
			Me.Label18.TabIndex = 1122
			Me.Label18.Text = "Product Type"
			Me.cmbProduct.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbProduct.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbProduct.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbProduct.FormattingEnabled = True
			Me.cmbProduct.Location = New Global.System.Drawing.Point(121, 62)
			Me.cmbProduct.Name = "cmbProduct"
			Me.cmbProduct.Size = New Global.System.Drawing.Size(481, 23)
			Me.cmbProduct.TabIndex = 1
			Me.Label9.AutoSize = True
			Me.Label9.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label9.Location = New Global.System.Drawing.Point(8, 66)
			Me.Label9.Name = "Label9"
			Me.Label9.Size = New Global.System.Drawing.Size(50, 15)
			Me.Label9.TabIndex = 1121
			Me.Label9.Text = "Product"
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.Location = New Global.System.Drawing.Point(8, 284)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(110, 15)
			Me.Label2.TabIndex = 1103
			Me.Label2.Text = "Required Quantity"
			Me.txtReqQty.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtReqQty.Location = New Global.System.Drawing.Point(121, 281)
			Me.txtReqQty.Name = "txtReqQty"
			Me.txtReqQty.Size = New Global.System.Drawing.Size(95, 21)
			Me.txtReqQty.TabIndex = 3
			Me.btnSave.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnSave.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnSave.Location = New Global.System.Drawing.Point(176, 332)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New Global.System.Drawing.Size(88, 30)
			Me.btnSave.TabIndex = 5
			Me.btnSave.Text = "&Save"
			Me.btnSave.UseVisualStyleBackColor = True
			Me.btnDelete.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnDelete.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnDelete.Location = New Global.System.Drawing.Point(266, 332)
			Me.btnDelete.Name = "btnDelete"
			Me.btnDelete.Size = New Global.System.Drawing.Size(88, 30)
			Me.btnDelete.TabIndex = 6
			Me.btnDelete.Text = "&Delete"
			Me.btnDelete.UseVisualStyleBackColor = True
			Me.btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnClose.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClose.Location = New Global.System.Drawing.Point(356, 332)
			Me.btnClose.Name = "btnClose"
			Me.btnClose.Size = New Global.System.Drawing.Size(88, 30)
			Me.btnClose.TabIndex = 7
			Me.btnClose.Text = "C&lose"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.Label12.AutoSize = True
			Me.Label12.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label12.Location = New Global.System.Drawing.Point(8, 203)
			Me.Label12.Name = "Label12"
			Me.Label12.Size = New Global.System.Drawing.Size(111, 15)
			Me.Label12.TabIndex = 1098
			Me.Label12.Text = "Available Quantity"
			Me.txtAvlQty.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtAvlQty.Location = New Global.System.Drawing.Point(121, 200)
			Me.txtAvlQty.Name = "txtAvlQty"
			Me.txtAvlQty.[ReadOnly] = True
			Me.txtAvlQty.Size = New Global.System.Drawing.Size(400, 21)
			Me.txtAvlQty.TabIndex = 4
			Me.txtAvlQty.TabStop = False
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.Location = New Global.System.Drawing.Point(8, 244)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(71, 15)
			Me.Label1.TabIndex = 1084
			Me.Label1.Text = "Description"
			Me.txtDesc.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtDesc.Location = New Global.System.Drawing.Point(121, 227)
			Me.txtDesc.Multiline = True
			Me.txtDesc.Name = "txtDesc"
			Me.txtDesc.Size = New Global.System.Drawing.Size(481, 48)
			Me.txtDesc.TabIndex = 2
			Me.panelTitleBar.BackColor = Global.System.Drawing.Color.FromArgb(204, 231, 255)
			Me.panelTitleBar.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.panelTitleBar.Controls.Add(Me.picFormIcon)
			Me.panelTitleBar.Controls.Add(Me.lblCaption)
			Me.panelTitleBar.Controls.Add(Me.form_btnClose)
			Me.panelTitleBar.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.panelTitleBar.Location = New Global.System.Drawing.Point(0, 0)
			Me.panelTitleBar.Name = "panelTitleBar"
			Me.panelTitleBar.Size = New Global.System.Drawing.Size(621, 27)
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
			Me.form_btnClose.Location = New Global.System.Drawing.Point(595, 1)
			Me.form_btnClose.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.form_btnClose.Name = "form_btnClose"
			Me.form_btnClose.Size = New Global.System.Drawing.Size(24, 24)
			Me.form_btnClose.TabIndex = 719
			Me.form_btnClose.UseVisualStyleBackColor = True
			Me.lblShadow1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblShadow1.BackColor = Global.System.Drawing.Color.White
			Me.lblShadow1.Location = New Global.System.Drawing.Point(627, 0)
			Me.lblShadow1.Name = "lblShadow1"
			Me.lblShadow1.Size = New Global.System.Drawing.Size(6, 9)
			Me.lblShadow1.TabIndex = 6
			Me.lblShadow2.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
			Me.lblShadow2.BackColor = Global.System.Drawing.Color.White
			Me.lblShadow2.Location = New Global.System.Drawing.Point(0, 373)
			Me.lblShadow2.Name = "lblShadow2"
			Me.lblShadow2.Size = New Global.System.Drawing.Size(9, 7)
			Me.lblShadow2.TabIndex = 5
			Me.txtIssuedQty.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtIssuedQty.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtIssuedQty.Location = New Global.System.Drawing.Point(559, 338)
			Me.txtIssuedQty.Name = "txtIssuedQty"
			Me.txtIssuedQty.Size = New Global.System.Drawing.Size(20, 21)
			Me.txtIssuedQty.TabIndex = 1221
			Me.txtIssuedQty.TabStop = False
			Me.txtIssuedQty.Visible = False
			Me.txtPickedQty.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtPickedQty.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPickedQty.Location = New Global.System.Drawing.Point(539, 338)
			Me.txtPickedQty.Name = "txtPickedQty"
			Me.txtPickedQty.Size = New Global.System.Drawing.Size(20, 21)
			Me.txtPickedQty.TabIndex = 1222
			Me.txtPickedQty.TabStop = False
			Me.txtPickedQty.Visible = False
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.DarkGray
			MyBase.ClientSize = New Global.System.Drawing.Size(632, 379)
			MyBase.Controls.Add(Me.pnlBorder)
			MyBase.Controls.Add(Me.lblShadow1)
			MyBase.Controls.Add(Me.lblShadow2)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedToolWindow
			MyBase.Name = "RequestItems"
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Request Items"
			Me.pnlBorder.ResumeLayout(False)
			Me.pnlMain.ResumeLayout(False)
			Me.pnlMain.PerformLayout()
			Me.panelTitleBar.ResumeLayout(False)
			Me.panelTitleBar.PerformLayout()
			CType(Me.picFormIcon, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000C73 RID: 3187
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
