Namespace Datasoft_PIMS
	' Token: 0x02000056 RID: 86
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class GRNConcentration
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600104B RID: 4171 RVA: 0x00096AF8 File Offset: 0x00094CF8
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

		' Token: 0x0600104C RID: 4172 RVA: 0x00096B48 File Offset: 0x00094D48
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.pnlBorder = New Global.System.Windows.Forms.Panel()
			Me.pnlMain = New Global.System.Windows.Forms.Panel()
			Me.txtBMRNo = New Global.System.Windows.Forms.TextBox()
			Me.Label12 = New Global.System.Windows.Forms.Label()
			Me.btnSave = New Global.System.Windows.Forms.Button()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.pnlTitre = New Global.System.Windows.Forms.Panel()
			Me.txtTitre = New Global.System.Windows.Forms.TextBox()
			Me.Label11 = New Global.System.Windows.Forms.Label()
			Me.pnlCells = New Global.System.Windows.Forms.Panel()
			Me.txtCells = New Global.System.Windows.Forms.TextBox()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.pnlCon = New Global.System.Windows.Forms.Panel()
			Me.txtConcentration = New Global.System.Windows.Forms.TextBox()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.txtQCApproved = New Global.System.Windows.Forms.TextBox()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.txtProductType = New Global.System.Windows.Forms.TextBox()
			Me.txtProductID = New Global.System.Windows.Forms.TextBox()
			Me.txtBatchNo = New Global.System.Windows.Forms.TextBox()
			Me.txtProductName = New Global.System.Windows.Forms.TextBox()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.txtCatalogNo = New Global.System.Windows.Forms.TextBox()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.txtVendor = New Global.System.Windows.Forms.TextBox()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.panelTitleBar = New Global.System.Windows.Forms.Panel()
			Me.picFormIcon = New Global.System.Windows.Forms.PictureBox()
			Me.lblCaption = New Global.System.Windows.Forms.Label()
			Me.form_btnClose = New Global.System.Windows.Forms.Button()
			Me.dtpDt = New Global.System.Windows.Forms.DateTimePicker()
			Me.txtNo = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.txtID = New Global.System.Windows.Forms.TextBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.pnlShadow = New Global.System.Windows.Forms.Panel()
			Me.txtGRNItemsID = New Global.System.Windows.Forms.TextBox()
			Me.pnlBorder.SuspendLayout()
			Me.pnlMain.SuspendLayout()
			Me.Panel1.SuspendLayout()
			Me.pnlTitre.SuspendLayout()
			Me.pnlCells.SuspendLayout()
			Me.pnlCon.SuspendLayout()
			Me.panelTitleBar.SuspendLayout()
			CType(Me.picFormIcon, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.pnlBorder.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.pnlBorder.BackColor = Global.System.Drawing.Color.SteelBlue
			Me.pnlBorder.Controls.Add(Me.pnlMain)
			Me.pnlBorder.Location = New Global.System.Drawing.Point(1, 1)
			Me.pnlBorder.Name = "pnlBorder"
			Me.pnlBorder.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.pnlBorder.Size = New Global.System.Drawing.Size(616, 322)
			Me.pnlBorder.TabIndex = 4
			Me.pnlMain.BackColor = Global.System.Drawing.Color.White
			Me.pnlMain.Controls.Add(Me.txtGRNItemsID)
			Me.pnlMain.Controls.Add(Me.txtBMRNo)
			Me.pnlMain.Controls.Add(Me.Label12)
			Me.pnlMain.Controls.Add(Me.btnSave)
			Me.pnlMain.Controls.Add(Me.btnClose)
			Me.pnlMain.Controls.Add(Me.Panel1)
			Me.pnlMain.Controls.Add(Me.txtQCApproved)
			Me.pnlMain.Controls.Add(Me.Label6)
			Me.pnlMain.Controls.Add(Me.Label5)
			Me.pnlMain.Controls.Add(Me.txtProductType)
			Me.pnlMain.Controls.Add(Me.txtProductID)
			Me.pnlMain.Controls.Add(Me.txtBatchNo)
			Me.pnlMain.Controls.Add(Me.txtProductName)
			Me.pnlMain.Controls.Add(Me.Label8)
			Me.pnlMain.Controls.Add(Me.txtCatalogNo)
			Me.pnlMain.Controls.Add(Me.Label4)
			Me.pnlMain.Controls.Add(Me.Label3)
			Me.pnlMain.Controls.Add(Me.txtVendor)
			Me.pnlMain.Controls.Add(Me.Label9)
			Me.pnlMain.Controls.Add(Me.panelTitleBar)
			Me.pnlMain.Controls.Add(Me.dtpDt)
			Me.pnlMain.Controls.Add(Me.txtNo)
			Me.pnlMain.Controls.Add(Me.Label1)
			Me.pnlMain.Controls.Add(Me.txtID)
			Me.pnlMain.Controls.Add(Me.Label2)
			Me.pnlMain.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.pnlMain.Location = New Global.System.Drawing.Point(3, 3)
			Me.pnlMain.Name = "pnlMain"
			Me.pnlMain.Size = New Global.System.Drawing.Size(610, 316)
			Me.pnlMain.TabIndex = 1
			Me.txtBMRNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtBMRNo.Location = New Global.System.Drawing.Point(410, 142)
			Me.txtBMRNo.Name = "txtBMRNo"
			Me.txtBMRNo.[ReadOnly] = True
			Me.txtBMRNo.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtBMRNo.TabIndex = 1113
			Me.txtBMRNo.TabStop = False
			Me.txtBMRNo.Visible = False
			Me.Label12.AutoSize = True
			Me.Label12.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label12.Location = New Global.System.Drawing.Point(322, 145)
			Me.Label12.Name = "Label12"
			Me.Label12.Size = New Global.System.Drawing.Size(55, 15)
			Me.Label12.TabIndex = 1112
			Me.Label12.Text = "BMR No."
			Me.Label12.Visible = False
			Me.btnSave.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnSave.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnSave.Location = New Global.System.Drawing.Point(192, 283)
			Me.btnSave.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New Global.System.Drawing.Size(111, 28)
			Me.btnSave.TabIndex = 1110
			Me.btnSave.Text = "&Save"
			Me.btnSave.UseVisualStyleBackColor = True
			Me.btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnClose.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClose.Location = New Global.System.Drawing.Point(308, 283)
			Me.btnClose.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btnClose.Name = "btnClose"
			Me.btnClose.Size = New Global.System.Drawing.Size(111, 28)
			Me.btnClose.TabIndex = 1111
			Me.btnClose.Text = "C&lose"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.Panel1.Controls.Add(Me.pnlTitre)
			Me.Panel1.Controls.Add(Me.pnlCells)
			Me.Panel1.Controls.Add(Me.pnlCon)
			Me.Panel1.Location = New Global.System.Drawing.Point(8, 195)
			Me.Panel1.Name = "Panel1"
			Me.Panel1.Size = New Global.System.Drawing.Size(588, 84)
			Me.Panel1.TabIndex = 1109
			Me.pnlTitre.Controls.Add(Me.txtTitre)
			Me.pnlTitre.Controls.Add(Me.Label11)
			Me.pnlTitre.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.pnlTitre.Location = New Global.System.Drawing.Point(0, 54)
			Me.pnlTitre.Name = "pnlTitre"
			Me.pnlTitre.Size = New Global.System.Drawing.Size(588, 27)
			Me.pnlTitre.TabIndex = 2
			Me.txtTitre.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtTitre.Location = New Global.System.Drawing.Point(126, 1)
			Me.txtTitre.Name = "txtTitre"
			Me.txtTitre.Size = New Global.System.Drawing.Size(452, 21)
			Me.txtTitre.TabIndex = 0
			Me.Label11.AutoSize = True
			Me.Label11.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label11.Location = New Global.System.Drawing.Point(4, 4)
			Me.Label11.Name = "Label11"
			Me.Label11.Size = New Global.System.Drawing.Size(33, 15)
			Me.Label11.TabIndex = 1105
			Me.Label11.Text = "Titre"
			Me.pnlCells.Controls.Add(Me.txtCells)
			Me.pnlCells.Controls.Add(Me.Label10)
			Me.pnlCells.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.pnlCells.Location = New Global.System.Drawing.Point(0, 27)
			Me.pnlCells.Name = "pnlCells"
			Me.pnlCells.Size = New Global.System.Drawing.Size(588, 27)
			Me.pnlCells.TabIndex = 1
			Me.txtCells.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtCells.Location = New Global.System.Drawing.Point(126, 1)
			Me.txtCells.Name = "txtCells"
			Me.txtCells.Size = New Global.System.Drawing.Size(452, 21)
			Me.txtCells.TabIndex = 0
			Me.Label10.AutoSize = True
			Me.Label10.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label10.Location = New Global.System.Drawing.Point(4, 4)
			Me.Label10.Name = "Label10"
			Me.Label10.Size = New Global.System.Drawing.Size(92, 15)
			Me.Label10.TabIndex = 1105
			Me.Label10.Text = "Activated Cells"
			Me.pnlCon.Controls.Add(Me.txtConcentration)
			Me.pnlCon.Controls.Add(Me.Label7)
			Me.pnlCon.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.pnlCon.Location = New Global.System.Drawing.Point(0, 0)
			Me.pnlCon.Name = "pnlCon"
			Me.pnlCon.Size = New Global.System.Drawing.Size(588, 27)
			Me.pnlCon.TabIndex = 0
			Me.txtConcentration.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtConcentration.Location = New Global.System.Drawing.Point(126, 1)
			Me.txtConcentration.Name = "txtConcentration"
			Me.txtConcentration.Size = New Global.System.Drawing.Size(452, 21)
			Me.txtConcentration.TabIndex = 0
			Me.Label7.AutoSize = True
			Me.Label7.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label7.Location = New Global.System.Drawing.Point(4, 4)
			Me.Label7.Name = "Label7"
			Me.Label7.Size = New Global.System.Drawing.Size(117, 15)
			Me.Label7.TabIndex = 1105
			Me.Label7.Text = "Final Concentration"
			Me.txtQCApproved.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtQCApproved.Location = New Global.System.Drawing.Point(134, 169)
			Me.txtQCApproved.Name = "txtQCApproved"
			Me.txtQCApproved.[ReadOnly] = True
			Me.txtQCApproved.Size = New Global.System.Drawing.Size(452, 21)
			Me.txtQCApproved.TabIndex = 1105
			Me.txtQCApproved.TabStop = False
			Me.Label6.AutoSize = True
			Me.Label6.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label6.Location = New Global.System.Drawing.Point(15, 172)
			Me.Label6.Name = "Label6"
			Me.Label6.Size = New Global.System.Drawing.Size(103, 15)
			Me.Label6.TabIndex = 1104
			Me.Label6.Text = "QC Approved By"
			Me.Label5.AutoSize = True
			Me.Label5.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label5.Location = New Global.System.Drawing.Point(322, 91)
			Me.Label5.Name = "Label5"
			Me.Label5.Size = New Global.System.Drawing.Size(82, 15)
			Me.Label5.TabIndex = 1103
			Me.Label5.Text = "Product Type"
			Me.txtProductType.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtProductType.Location = New Global.System.Drawing.Point(410, 88)
			Me.txtProductType.Name = "txtProductType"
			Me.txtProductType.[ReadOnly] = True
			Me.txtProductType.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtProductType.TabIndex = 1102
			Me.txtProductType.TabStop = False
			Me.txtProductID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtProductID.Location = New Global.System.Drawing.Point(589, 115)
			Me.txtProductID.Name = "txtProductID"
			Me.txtProductID.Size = New Global.System.Drawing.Size(18, 21)
			Me.txtProductID.TabIndex = 1101
			Me.txtProductID.TabStop = False
			Me.txtProductID.Visible = False
			Me.txtBatchNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtBatchNo.Location = New Global.System.Drawing.Point(134, 142)
			Me.txtBatchNo.Name = "txtBatchNo"
			Me.txtBatchNo.[ReadOnly] = True
			Me.txtBatchNo.Size = New Global.System.Drawing.Size(452, 21)
			Me.txtBatchNo.TabIndex = 1100
			Me.txtBatchNo.TabStop = False
			Me.txtProductName.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtProductName.Location = New Global.System.Drawing.Point(134, 115)
			Me.txtProductName.Name = "txtProductName"
			Me.txtProductName.[ReadOnly] = True
			Me.txtProductName.Size = New Global.System.Drawing.Size(452, 21)
			Me.txtProductName.TabIndex = 1099
			Me.txtProductName.TabStop = False
			Me.Label8.AutoSize = True
			Me.Label8.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label8.Location = New Global.System.Drawing.Point(15, 91)
			Me.Label8.Name = "Label8"
			Me.Label8.Size = New Global.System.Drawing.Size(74, 15)
			Me.Label8.TabIndex = 1098
			Me.Label8.Text = "Catalog No."
			Me.txtCatalogNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtCatalogNo.Location = New Global.System.Drawing.Point(134, 88)
			Me.txtCatalogNo.Name = "txtCatalogNo"
			Me.txtCatalogNo.[ReadOnly] = True
			Me.txtCatalogNo.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtCatalogNo.TabIndex = 1097
			Me.txtCatalogNo.TabStop = False
			Me.Label4.AutoSize = True
			Me.Label4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label4.Location = New Global.System.Drawing.Point(15, 145)
			Me.Label4.Name = "Label4"
			Me.Label4.Size = New Global.System.Drawing.Size(88, 15)
			Me.Label4.TabIndex = 1096
			Me.Label4.Text = "Batch/ Lot No."
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.Location = New Global.System.Drawing.Point(15, 118)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(87, 15)
			Me.Label3.TabIndex = 1095
			Me.Label3.Text = "Product Name"
			Me.txtVendor.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtVendor.Location = New Global.System.Drawing.Point(134, 61)
			Me.txtVendor.Name = "txtVendor"
			Me.txtVendor.[ReadOnly] = True
			Me.txtVendor.Size = New Global.System.Drawing.Size(452, 21)
			Me.txtVendor.TabIndex = 1068
			Me.txtVendor.TabStop = False
			Me.Label9.AutoSize = True
			Me.Label9.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label9.Location = New Global.System.Drawing.Point(15, 64)
			Me.Label9.Name = "Label9"
			Me.Label9.Size = New Global.System.Drawing.Size(85, 15)
			Me.Label9.TabIndex = 1066
			Me.Label9.Text = "Vendor Name"
			Me.panelTitleBar.BackColor = Global.System.Drawing.Color.FromArgb(204, 231, 255)
			Me.panelTitleBar.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.panelTitleBar.Controls.Add(Me.picFormIcon)
			Me.panelTitleBar.Controls.Add(Me.lblCaption)
			Me.panelTitleBar.Controls.Add(Me.form_btnClose)
			Me.panelTitleBar.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.panelTitleBar.Location = New Global.System.Drawing.Point(0, 0)
			Me.panelTitleBar.Name = "panelTitleBar"
			Me.panelTitleBar.Size = New Global.System.Drawing.Size(610, 27)
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
			Me.form_btnClose.Location = New Global.System.Drawing.Point(584, 1)
			Me.form_btnClose.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.form_btnClose.Name = "form_btnClose"
			Me.form_btnClose.Size = New Global.System.Drawing.Size(24, 24)
			Me.form_btnClose.TabIndex = 719
			Me.form_btnClose.UseVisualStyleBackColor = True
			Me.dtpDt.Checked = False
			Me.dtpDt.CustomFormat = "dd   MMM   yyyy"
			Me.dtpDt.Enabled = False
			Me.dtpDt.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpDt.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpDt.Location = New Global.System.Drawing.Point(410, 34)
			Me.dtpDt.Name = "dtpDt"
			Me.dtpDt.Size = New Global.System.Drawing.Size(176, 21)
			Me.dtpDt.TabIndex = 1061
			Me.dtpDt.TabStop = False
			Me.txtNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtNo.Location = New Global.System.Drawing.Point(134, 34)
			Me.txtNo.Name = "txtNo"
			Me.txtNo.[ReadOnly] = True
			Me.txtNo.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtNo.TabIndex = 1063
			Me.txtNo.TabStop = False
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.Location = New Global.System.Drawing.Point(322, 37)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(75, 15)
			Me.Label1.TabIndex = 1062
			Me.Label1.Text = "G.R.N. Date"
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.txtID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtID.Location = New Global.System.Drawing.Point(589, 34)
			Me.txtID.Name = "txtID"
			Me.txtID.Size = New Global.System.Drawing.Size(18, 21)
			Me.txtID.TabIndex = 1055
			Me.txtID.TabStop = False
			Me.txtID.Visible = False
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.Location = New Global.System.Drawing.Point(15, 37)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(67, 15)
			Me.Label2.TabIndex = 1064
			Me.Label2.Text = "G.R.N. No."
			Me.pnlShadow.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.pnlShadow.BackColor = Global.System.Drawing.Color.DarkGray
			Me.pnlShadow.Location = New Global.System.Drawing.Point(9, 13)
			Me.pnlShadow.Name = "pnlShadow"
			Me.pnlShadow.Size = New Global.System.Drawing.Size(612, 315)
			Me.pnlShadow.TabIndex = 3
			Me.txtGRNItemsID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtGRNItemsID.Location = New Global.System.Drawing.Point(589, 61)
			Me.txtGRNItemsID.Name = "txtGRNItemsID"
			Me.txtGRNItemsID.Size = New Global.System.Drawing.Size(18, 21)
			Me.txtGRNItemsID.TabIndex = 1114
			Me.txtGRNItemsID.TabStop = False
			Me.txtGRNItemsID.Visible = False
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.GhostWhite
			MyBase.ClientSize = New Global.System.Drawing.Size(622, 328)
			MyBase.Controls.Add(Me.pnlBorder)
			MyBase.Controls.Add(Me.pnlShadow)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedToolWindow
			MyBase.Name = "GRNConcentration"
			MyBase.ShowInTaskbar = False
			Me.Text = "Update Concentration & Titre"
			Me.pnlBorder.ResumeLayout(False)
			Me.pnlMain.ResumeLayout(False)
			Me.pnlMain.PerformLayout()
			Me.Panel1.ResumeLayout(False)
			Me.pnlTitre.ResumeLayout(False)
			Me.pnlTitre.PerformLayout()
			Me.pnlCells.ResumeLayout(False)
			Me.pnlCells.PerformLayout()
			Me.pnlCon.ResumeLayout(False)
			Me.pnlCon.PerformLayout()
			Me.panelTitleBar.ResumeLayout(False)
			Me.panelTitleBar.PerformLayout()
			CType(Me.picFormIcon, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x040006DC RID: 1756
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
