Namespace Datasoft_PIMS
	' Token: 0x02000059 RID: 89
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class PRItems
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060012F4 RID: 4852 RVA: 0x000AE744 File Offset: 0x000AC944
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

		' Token: 0x060012F5 RID: 4853 RVA: 0x000AE794 File Offset: 0x000AC994
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.pnlBorder = New Global.System.Windows.Forms.Panel()
			Me.pnlMain = New Global.System.Windows.Forms.Panel()
			Me.lblPrice = New Global.System.Windows.Forms.Label()
			Me.txtUnitPrice = New Global.System.Windows.Forms.TextBox()
			Me.Label12 = New Global.System.Windows.Forms.Label()
			Me.Label13 = New Global.System.Windows.Forms.Label()
			Me.txtReqQty = New Global.System.Windows.Forms.TextBox()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.Label11 = New Global.System.Windows.Forms.Label()
			Me.txtReqQtyTer = New Global.System.Windows.Forms.TextBox()
			Me.Label20 = New Global.System.Windows.Forms.Label()
			Me.txtPrimaryUOM = New Global.System.Windows.Forms.TextBox()
			Me.txtPrimaryPackSize = New Global.System.Windows.Forms.TextBox()
			Me.Label17 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.txtTertiaryPackSize = New Global.System.Windows.Forms.TextBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.txtTertiaryUOM = New Global.System.Windows.Forms.TextBox()
			Me.Label15 = New Global.System.Windows.Forms.Label()
			Me.txtProductName = New Global.System.Windows.Forms.TextBox()
			Me.txtCatalogNo = New Global.System.Windows.Forms.TextBox()
			Me.cmbType = New Global.System.Windows.Forms.ComboBox()
			Me.Label18 = New Global.System.Windows.Forms.Label()
			Me.txtOtherCharges = New Global.System.Windows.Forms.TextBox()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.cmbTaxPer = New Global.System.Windows.Forms.ComboBox()
			Me.Label14 = New Global.System.Windows.Forms.Label()
			Me.txtFinalAmt = New Global.System.Windows.Forms.TextBox()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.txtTaxAmt = New Global.System.Windows.Forms.TextBox()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.txtNetAmt = New Global.System.Windows.Forms.TextBox()
			Me.Label35 = New Global.System.Windows.Forms.Label()
			Me.btnSave = New Global.System.Windows.Forms.Button()
			Me.btnDelete = New Global.System.Windows.Forms.Button()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.txtBasicAmt = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Label27 = New Global.System.Windows.Forms.Label()
			Me.txtHSNSAC = New Global.System.Windows.Forms.TextBox()
			Me.txtDesc = New Global.System.Windows.Forms.TextBox()
			Me.cmbProduct = New Global.System.Windows.Forms.ComboBox()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.panelTitleBar = New Global.System.Windows.Forms.Panel()
			Me.picFormIcon = New Global.System.Windows.Forms.PictureBox()
			Me.lblCaption = New Global.System.Windows.Forms.Label()
			Me.form_btnClose = New Global.System.Windows.Forms.Button()
			Me.pnlShadow = New Global.System.Windows.Forms.Panel()
			Me.txtTertiaryMeasure = New Global.System.Windows.Forms.TextBox()
			Me.txtPrimaryMeasure = New Global.System.Windows.Forms.TextBox()
			Me.pnlBorder.SuspendLayout()
			Me.pnlMain.SuspendLayout()
			Me.panelTitleBar.SuspendLayout()
			CType(Me.picFormIcon, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.pnlBorder.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.pnlBorder.BackColor = Global.System.Drawing.Color.SteelBlue
			Me.pnlBorder.Controls.Add(Me.pnlMain)
			Me.pnlBorder.Location = New Global.System.Drawing.Point(1, 1)
			Me.pnlBorder.Name = "pnlBorder"
			Me.pnlBorder.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.pnlBorder.Size = New Global.System.Drawing.Size(661, 461)
			Me.pnlBorder.TabIndex = 4
			Me.pnlMain.BackColor = Global.System.Drawing.Color.White
			Me.pnlMain.Controls.Add(Me.txtTertiaryMeasure)
			Me.pnlMain.Controls.Add(Me.txtPrimaryMeasure)
			Me.pnlMain.Controls.Add(Me.lblPrice)
			Me.pnlMain.Controls.Add(Me.txtUnitPrice)
			Me.pnlMain.Controls.Add(Me.Label12)
			Me.pnlMain.Controls.Add(Me.Label13)
			Me.pnlMain.Controls.Add(Me.txtReqQty)
			Me.pnlMain.Controls.Add(Me.Label6)
			Me.pnlMain.Controls.Add(Me.Label11)
			Me.pnlMain.Controls.Add(Me.txtReqQtyTer)
			Me.pnlMain.Controls.Add(Me.Label20)
			Me.pnlMain.Controls.Add(Me.txtPrimaryUOM)
			Me.pnlMain.Controls.Add(Me.txtPrimaryPackSize)
			Me.pnlMain.Controls.Add(Me.Label17)
			Me.pnlMain.Controls.Add(Me.Label2)
			Me.pnlMain.Controls.Add(Me.txtTertiaryPackSize)
			Me.pnlMain.Controls.Add(Me.Label3)
			Me.pnlMain.Controls.Add(Me.txtTertiaryUOM)
			Me.pnlMain.Controls.Add(Me.Label15)
			Me.pnlMain.Controls.Add(Me.txtProductName)
			Me.pnlMain.Controls.Add(Me.txtCatalogNo)
			Me.pnlMain.Controls.Add(Me.cmbType)
			Me.pnlMain.Controls.Add(Me.Label18)
			Me.pnlMain.Controls.Add(Me.txtOtherCharges)
			Me.pnlMain.Controls.Add(Me.Label10)
			Me.pnlMain.Controls.Add(Me.cmbTaxPer)
			Me.pnlMain.Controls.Add(Me.Label14)
			Me.pnlMain.Controls.Add(Me.txtFinalAmt)
			Me.pnlMain.Controls.Add(Me.Label7)
			Me.pnlMain.Controls.Add(Me.txtTaxAmt)
			Me.pnlMain.Controls.Add(Me.Label8)
			Me.pnlMain.Controls.Add(Me.txtNetAmt)
			Me.pnlMain.Controls.Add(Me.Label35)
			Me.pnlMain.Controls.Add(Me.btnSave)
			Me.pnlMain.Controls.Add(Me.btnDelete)
			Me.pnlMain.Controls.Add(Me.btnClose)
			Me.pnlMain.Controls.Add(Me.Label5)
			Me.pnlMain.Controls.Add(Me.txtBasicAmt)
			Me.pnlMain.Controls.Add(Me.Label1)
			Me.pnlMain.Controls.Add(Me.Label27)
			Me.pnlMain.Controls.Add(Me.txtHSNSAC)
			Me.pnlMain.Controls.Add(Me.txtDesc)
			Me.pnlMain.Controls.Add(Me.cmbProduct)
			Me.pnlMain.Controls.Add(Me.Label9)
			Me.pnlMain.Controls.Add(Me.panelTitleBar)
			Me.pnlMain.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.pnlMain.Location = New Global.System.Drawing.Point(3, 3)
			Me.pnlMain.Name = "pnlMain"
			Me.pnlMain.Size = New Global.System.Drawing.Size(655, 455)
			Me.pnlMain.TabIndex = 1
			Me.lblPrice.AutoSize = True
			Me.lblPrice.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblPrice.Location = New Global.System.Drawing.Point(330, 196)
			Me.lblPrice.Name = "lblPrice"
			Me.lblPrice.Size = New Global.System.Drawing.Size(61, 15)
			Me.lblPrice.TabIndex = 1231
			Me.lblPrice.Text = "Unit Price"
			Me.txtUnitPrice.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtUnitPrice.Location = New Global.System.Drawing.Point(461, 193)
			Me.txtUnitPrice.Name = "txtUnitPrice"
			Me.txtUnitPrice.[ReadOnly] = True
			Me.txtUnitPrice.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtUnitPrice.TabIndex = 4
			Me.Label12.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label12.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label12.Location = New Global.System.Drawing.Point(560, 275)
			Me.Label12.Name = "Label12"
			Me.Label12.Size = New Global.System.Drawing.Size(77, 21)
			Me.Label12.TabIndex = 1229
			Me.Label12.Text = "in Primary"
			Me.Label12.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label13.AutoSize = True
			Me.Label13.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label13.Location = New Global.System.Drawing.Point(330, 278)
			Me.Label13.Name = "Label13"
			Me.Label13.Size = New Global.System.Drawing.Size(110, 15)
			Me.Label13.TabIndex = 1228
			Me.Label13.Text = "Required Quantity"
			Me.txtReqQty.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtReqQty.Location = New Global.System.Drawing.Point(461, 275)
			Me.txtReqQty.Name = "txtReqQty"
			Me.txtReqQty.[ReadOnly] = True
			Me.txtReqQty.Size = New Global.System.Drawing.Size(95, 21)
			Me.txtReqQty.TabIndex = 1227
			Me.txtReqQty.TabStop = False
			Me.Label6.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label6.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label6.Location = New Global.System.Drawing.Point(241, 274)
			Me.Label6.Name = "Label6"
			Me.Label6.Size = New Global.System.Drawing.Size(77, 21)
			Me.Label6.TabIndex = 1226
			Me.Label6.Text = "in Tertiary"
			Me.Label6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label11.AutoSize = True
			Me.Label11.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label11.Location = New Global.System.Drawing.Point(15, 275)
			Me.Label11.Name = "Label11"
			Me.Label11.Size = New Global.System.Drawing.Size(110, 15)
			Me.Label11.TabIndex = 1225
			Me.Label11.Text = "Required Quantity" & vbCr
			Me.txtReqQtyTer.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtReqQtyTer.Location = New Global.System.Drawing.Point(142, 274)
			Me.txtReqQtyTer.Name = "txtReqQtyTer"
			Me.txtReqQtyTer.Size = New Global.System.Drawing.Size(95, 21)
			Me.txtReqQtyTer.TabIndex = 5
			Me.Label20.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label20.AutoSize = True
			Me.Label20.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label20.Location = New Global.System.Drawing.Point(15, 250)
			Me.Label20.Name = "Label20"
			Me.Label20.Size = New Global.System.Drawing.Size(82, 15)
			Me.Label20.TabIndex = 1223
			Me.Label20.Text = "Primary UOM"
			Me.txtPrimaryUOM.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.txtPrimaryUOM.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPrimaryUOM.Location = New Global.System.Drawing.Point(142, 247)
			Me.txtPrimaryUOM.Name = "txtPrimaryUOM"
			Me.txtPrimaryUOM.[ReadOnly] = True
			Me.txtPrimaryUOM.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtPrimaryUOM.TabIndex = 1222
			Me.txtPrimaryUOM.TabStop = False
			Me.txtPrimaryPackSize.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.txtPrimaryPackSize.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPrimaryPackSize.Location = New Global.System.Drawing.Point(461, 247)
			Me.txtPrimaryPackSize.Name = "txtPrimaryPackSize"
			Me.txtPrimaryPackSize.[ReadOnly] = True
			Me.txtPrimaryPackSize.Size = New Global.System.Drawing.Size(112, 21)
			Me.txtPrimaryPackSize.TabIndex = 1218
			Me.txtPrimaryPackSize.TabStop = False
			Me.Label17.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label17.AutoSize = True
			Me.Label17.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label17.Location = New Global.System.Drawing.Point(330, 250)
			Me.Label17.Name = "Label17"
			Me.Label17.Size = New Global.System.Drawing.Size(107, 15)
			Me.Label17.TabIndex = 1221
			Me.Label17.Text = "Primary PackSize"
			Me.Label2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.Location = New Global.System.Drawing.Point(330, 223)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(107, 15)
			Me.Label2.TabIndex = 1220
			Me.Label2.Text = "Tertiary PackSize"
			Me.txtTertiaryPackSize.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.txtTertiaryPackSize.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtTertiaryPackSize.Location = New Global.System.Drawing.Point(461, 220)
			Me.txtTertiaryPackSize.Name = "txtTertiaryPackSize"
			Me.txtTertiaryPackSize.[ReadOnly] = True
			Me.txtTertiaryPackSize.Size = New Global.System.Drawing.Size(112, 21)
			Me.txtTertiaryPackSize.TabIndex = 1217
			Me.txtTertiaryPackSize.TabStop = False
			Me.Label3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.Location = New Global.System.Drawing.Point(15, 223)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(82, 15)
			Me.Label3.TabIndex = 1219
			Me.Label3.Text = "Tertiary UOM"
			Me.txtTertiaryUOM.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.txtTertiaryUOM.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtTertiaryUOM.Location = New Global.System.Drawing.Point(142, 220)
			Me.txtTertiaryUOM.Name = "txtTertiaryUOM"
			Me.txtTertiaryUOM.[ReadOnly] = True
			Me.txtTertiaryUOM.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtTertiaryUOM.TabIndex = 1216
			Me.txtTertiaryUOM.TabStop = False
			Me.Label15.AutoSize = True
			Me.Label15.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label15.Location = New Global.System.Drawing.Point(15, 96)
			Me.Label15.Name = "Label15"
			Me.Label15.Size = New Global.System.Drawing.Size(87, 15)
			Me.Label15.TabIndex = 1170
			Me.Label15.Text = "Product Name"
			Me.txtProductName.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtProductName.Location = New Global.System.Drawing.Point(142, 93)
			Me.txtProductName.Name = "txtProductName"
			Me.txtProductName.[ReadOnly] = True
			Me.txtProductName.Size = New Global.System.Drawing.Size(497, 21)
			Me.txtProductName.TabIndex = 2
			Me.txtProductName.TabStop = False
			Me.txtCatalogNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtCatalogNo.Location = New Global.System.Drawing.Point(102, 36)
			Me.txtCatalogNo.Name = "txtCatalogNo"
			Me.txtCatalogNo.Size = New Global.System.Drawing.Size(35, 21)
			Me.txtCatalogNo.TabIndex = 1168
			Me.txtCatalogNo.Visible = False
			Me.cmbType.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbType.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbType.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbType.FormattingEnabled = True
			Me.cmbType.Items.AddRange(New Object() { "", "Raw Material", "Packaging Material", "Consumable", "Service", "Others" })
			Me.cmbType.Location = New Global.System.Drawing.Point(141, 35)
			Me.cmbType.Name = "cmbType"
			Me.cmbType.Size = New Global.System.Drawing.Size(497, 23)
			Me.cmbType.TabIndex = 0
			Me.Label18.AutoSize = True
			Me.Label18.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label18.Location = New Global.System.Drawing.Point(15, 39)
			Me.Label18.Name = "Label18"
			Me.Label18.Size = New Global.System.Drawing.Size(82, 15)
			Me.Label18.TabIndex = 1167
			Me.Label18.Text = "Product Type"
			Me.txtOtherCharges.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtOtherCharges.Location = New Global.System.Drawing.Point(461, 356)
			Me.txtOtherCharges.Name = "txtOtherCharges"
			Me.txtOtherCharges.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtOtherCharges.TabIndex = 7
			Me.Label10.AutoSize = True
			Me.Label10.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label10.Location = New Global.System.Drawing.Point(330, 359)
			Me.Label10.Name = "Label10"
			Me.Label10.Size = New Global.System.Drawing.Size(91, 15)
			Me.Label10.TabIndex = 1166
			Me.Label10.Text = "Other Charges"
			Me.cmbTaxPer.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbTaxPer.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbTaxPer.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbTaxPer.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbTaxPer.FormattingEnabled = True
			Me.cmbTaxPer.Items.AddRange(New Object() { "", "0 %", "5 %", "12 %", "18 %", "28 %" })
			Me.cmbTaxPer.Location = New Global.System.Drawing.Point(141, 328)
			Me.cmbTaxPer.Name = "cmbTaxPer"
			Me.cmbTaxPer.Size = New Global.System.Drawing.Size(176, 23)
			Me.cmbTaxPer.TabIndex = 6
			Me.Label14.AutoSize = True
			Me.Label14.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label14.Location = New Global.System.Drawing.Point(14, 386)
			Me.Label14.Name = "Label14"
			Me.Label14.Size = New Global.System.Drawing.Size(69, 15)
			Me.Label14.TabIndex = 1165
			Me.Label14.Text = "Final Value"
			Me.txtFinalAmt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtFinalAmt.Location = New Global.System.Drawing.Point(141, 383)
			Me.txtFinalAmt.Name = "txtFinalAmt"
			Me.txtFinalAmt.[ReadOnly] = True
			Me.txtFinalAmt.Size = New Global.System.Drawing.Size(497, 21)
			Me.txtFinalAmt.TabIndex = 1144
			Me.txtFinalAmt.TabStop = False
			Me.Label7.AutoSize = True
			Me.Label7.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label7.Location = New Global.System.Drawing.Point(330, 332)
			Me.Label7.Name = "Label7"
			Me.Label7.Size = New Global.System.Drawing.Size(76, 15)
			Me.Label7.TabIndex = 1164
			Me.Label7.Text = "Tax Amount"
			Me.txtTaxAmt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtTaxAmt.Location = New Global.System.Drawing.Point(461, 329)
			Me.txtTaxAmt.Name = "txtTaxAmt"
			Me.txtTaxAmt.[ReadOnly] = True
			Me.txtTaxAmt.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtTaxAmt.TabIndex = 1138
			Me.txtTaxAmt.TabStop = False
			Me.Label8.AutoSize = True
			Me.Label8.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label8.Location = New Global.System.Drawing.Point(14, 332)
			Me.Label8.Name = "Label8"
			Me.Label8.Size = New Global.System.Drawing.Size(28, 15)
			Me.Label8.TabIndex = 1163
			Me.Label8.Text = "Tax"
			Me.txtNetAmt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtNetAmt.Location = New Global.System.Drawing.Point(141, 356)
			Me.txtNetAmt.Name = "txtNetAmt"
			Me.txtNetAmt.[ReadOnly] = True
			Me.txtNetAmt.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtNetAmt.TabIndex = 1136
			Me.txtNetAmt.TabStop = False
			Me.Label35.AutoSize = True
			Me.Label35.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label35.Location = New Global.System.Drawing.Point(14, 359)
			Me.Label35.Name = "Label35"
			Me.Label35.Size = New Global.System.Drawing.Size(74, 15)
			Me.Label35.TabIndex = 1161
			Me.Label35.Text = "Net Amount"
			Me.btnSave.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnSave.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnSave.Location = New Global.System.Drawing.Point(205, 422)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New Global.System.Drawing.Size(80, 26)
			Me.btnSave.TabIndex = 8
			Me.btnSave.Text = "&Save"
			Me.btnSave.UseVisualStyleBackColor = True
			Me.btnDelete.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnDelete.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnDelete.Location = New Global.System.Drawing.Point(287, 422)
			Me.btnDelete.Name = "btnDelete"
			Me.btnDelete.Size = New Global.System.Drawing.Size(80, 26)
			Me.btnDelete.TabIndex = 9
			Me.btnDelete.Text = "&Delete"
			Me.btnDelete.UseVisualStyleBackColor = True
			Me.btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnClose.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClose.Location = New Global.System.Drawing.Point(369, 422)
			Me.btnClose.Name = "btnClose"
			Me.btnClose.Size = New Global.System.Drawing.Size(80, 26)
			Me.btnClose.TabIndex = 10
			Me.btnClose.Text = "C&lose"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.Label5.AutoSize = True
			Me.Label5.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label5.Location = New Global.System.Drawing.Point(14, 305)
			Me.Label5.Name = "Label5"
			Me.Label5.Size = New Global.System.Drawing.Size(73, 15)
			Me.Label5.TabIndex = 1154
			Me.Label5.Text = "Basic Value"
			Me.txtBasicAmt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtBasicAmt.Location = New Global.System.Drawing.Point(141, 302)
			Me.txtBasicAmt.Name = "txtBasicAmt"
			Me.txtBasicAmt.[ReadOnly] = True
			Me.txtBasicAmt.Size = New Global.System.Drawing.Size(497, 21)
			Me.txtBasicAmt.TabIndex = 1133
			Me.txtBasicAmt.TabStop = False
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.Location = New Global.System.Drawing.Point(15, 123)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(71, 15)
			Me.Label1.TabIndex = 1150
			Me.Label1.Text = "Description"
			Me.Label27.AutoSize = True
			Me.Label27.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label27.Location = New Global.System.Drawing.Point(15, 196)
			Me.Label27.Name = "Label27"
			Me.Label27.Size = New Global.System.Drawing.Size(99, 15)
			Me.Label27.TabIndex = 1149
			Me.Label27.Text = "HSN/ SAC Code"
			Me.txtHSNSAC.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtHSNSAC.Location = New Global.System.Drawing.Point(142, 193)
			Me.txtHSNSAC.Name = "txtHSNSAC"
			Me.txtHSNSAC.[ReadOnly] = True
			Me.txtHSNSAC.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtHSNSAC.TabIndex = 1129
			Me.txtHSNSAC.TabStop = False
			Me.txtDesc.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtDesc.Location = New Global.System.Drawing.Point(142, 120)
			Me.txtDesc.Multiline = True
			Me.txtDesc.Name = "txtDesc"
			Me.txtDesc.Size = New Global.System.Drawing.Size(497, 67)
			Me.txtDesc.TabIndex = 3
			Me.cmbProduct.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbProduct.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbProduct.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbProduct.FormattingEnabled = True
			Me.cmbProduct.Location = New Global.System.Drawing.Point(142, 64)
			Me.cmbProduct.Name = "cmbProduct"
			Me.cmbProduct.Size = New Global.System.Drawing.Size(497, 23)
			Me.cmbProduct.TabIndex = 1
			Me.Label9.AutoSize = True
			Me.Label9.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label9.Location = New Global.System.Drawing.Point(15, 67)
			Me.Label9.Name = "Label9"
			Me.Label9.Size = New Global.System.Drawing.Size(102, 15)
			Me.Label9.TabIndex = 1148
			Me.Label9.Text = "Product/ Service"
			Me.panelTitleBar.BackColor = Global.System.Drawing.Color.FromArgb(204, 231, 255)
			Me.panelTitleBar.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.panelTitleBar.Controls.Add(Me.picFormIcon)
			Me.panelTitleBar.Controls.Add(Me.lblCaption)
			Me.panelTitleBar.Controls.Add(Me.form_btnClose)
			Me.panelTitleBar.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.panelTitleBar.Location = New Global.System.Drawing.Point(0, 0)
			Me.panelTitleBar.Name = "panelTitleBar"
			Me.panelTitleBar.Size = New Global.System.Drawing.Size(655, 27)
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
			Me.form_btnClose.Location = New Global.System.Drawing.Point(629, 1)
			Me.form_btnClose.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.form_btnClose.Name = "form_btnClose"
			Me.form_btnClose.Size = New Global.System.Drawing.Size(24, 24)
			Me.form_btnClose.TabIndex = 719
			Me.form_btnClose.UseVisualStyleBackColor = True
			Me.pnlShadow.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.pnlShadow.BackColor = Global.System.Drawing.Color.DarkGray
			Me.pnlShadow.Location = New Global.System.Drawing.Point(9, 13)
			Me.pnlShadow.Name = "pnlShadow"
			Me.pnlShadow.Size = New Global.System.Drawing.Size(657, 454)
			Me.pnlShadow.TabIndex = 3
			Me.txtTertiaryMeasure.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtTertiaryMeasure.Location = New Global.System.Drawing.Point(577, 220)
			Me.txtTertiaryMeasure.Name = "txtTertiaryMeasure"
			Me.txtTertiaryMeasure.[ReadOnly] = True
			Me.txtTertiaryMeasure.Size = New Global.System.Drawing.Size(61, 21)
			Me.txtTertiaryMeasure.TabIndex = 1274
			Me.txtTertiaryMeasure.TabStop = False
			Me.txtTertiaryMeasure.Text = "Nos"
			Me.txtPrimaryMeasure.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPrimaryMeasure.Location = New Global.System.Drawing.Point(577, 247)
			Me.txtPrimaryMeasure.Name = "txtPrimaryMeasure"
			Me.txtPrimaryMeasure.[ReadOnly] = True
			Me.txtPrimaryMeasure.Size = New Global.System.Drawing.Size(61, 21)
			Me.txtPrimaryMeasure.TabIndex = 1273
			Me.txtPrimaryMeasure.TabStop = False
			MyBase.AcceptButton = Me.btnSave
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.GhostWhite
			MyBase.ClientSize = New Global.System.Drawing.Size(667, 467)
			MyBase.Controls.Add(Me.pnlBorder)
			MyBase.Controls.Add(Me.pnlShadow)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedToolWindow
			MyBase.Name = "PRItems"
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "PR Items"
			MyBase.TransparencyKey = Global.System.Drawing.Color.GhostWhite
			Me.pnlBorder.ResumeLayout(False)
			Me.pnlMain.ResumeLayout(False)
			Me.pnlMain.PerformLayout()
			Me.panelTitleBar.ResumeLayout(False)
			Me.panelTitleBar.PerformLayout()
			CType(Me.picFormIcon, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000808 RID: 2056
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
