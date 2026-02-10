Namespace Datasoft_PIMS
	' Token: 0x02000022 RID: 34
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class VendorAddress
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600077A RID: 1914 RVA: 0x00043A24 File Offset: 0x00041C24
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

		' Token: 0x0600077B RID: 1915 RVA: 0x00043A74 File Offset: 0x00041C74
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.pnlBorder = New Global.System.Windows.Forms.Panel()
			Me.pnlMain = New Global.System.Windows.Forms.Panel()
			Me.cmbState = New Global.System.Windows.Forms.ComboBox()
			Me.cmbCity = New Global.System.Windows.Forms.ComboBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.txtDtlsID = New Global.System.Windows.Forms.TextBox()
			Me.txtID = New Global.System.Windows.Forms.TextBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.txtTINNo = New Global.System.Windows.Forms.TextBox()
			Me.btnSave = New Global.System.Windows.Forms.Button()
			Me.btnDelete = New Global.System.Windows.Forms.Button()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.txtGSTINNo = New Global.System.Windows.Forms.TextBox()
			Me.cmbGSTType = New Global.System.Windows.Forms.ComboBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.cmbGSTINRegistration = New Global.System.Windows.Forms.ComboBox()
			Me.Label43 = New Global.System.Windows.Forms.Label()
			Me.txtCellNo = New Global.System.Windows.Forms.TextBox()
			Me.Label48 = New Global.System.Windows.Forms.Label()
			Me.txtEmailAddress = New Global.System.Windows.Forms.TextBox()
			Me.txtLandlineNo = New Global.System.Windows.Forms.TextBox()
			Me.Label49 = New Global.System.Windows.Forms.Label()
			Me.Label50 = New Global.System.Windows.Forms.Label()
			Me.Label46 = New Global.System.Windows.Forms.Label()
			Me.txtContactName = New Global.System.Windows.Forms.TextBox()
			Me.txtPincode = New Global.System.Windows.Forms.TextBox()
			Me.txtPANNo = New Global.System.Windows.Forms.TextBox()
			Me.Label31 = New Global.System.Windows.Forms.Label()
			Me.Label51 = New Global.System.Windows.Forms.Label()
			Me.Label52 = New Global.System.Windows.Forms.Label()
			Me.Label53 = New Global.System.Windows.Forms.Label()
			Me.txtAddress = New Global.System.Windows.Forms.TextBox()
			Me.Label54 = New Global.System.Windows.Forms.Label()
			Me.cmbAddressType = New Global.System.Windows.Forms.ComboBox()
			Me.Label42 = New Global.System.Windows.Forms.Label()
			Me.panelTitleBar = New Global.System.Windows.Forms.Panel()
			Me.picFormIcon = New Global.System.Windows.Forms.PictureBox()
			Me.lblCaption = New Global.System.Windows.Forms.Label()
			Me.form_btnClose = New Global.System.Windows.Forms.Button()
			Me.lblShadow1 = New Global.System.Windows.Forms.Label()
			Me.lblShadow2 = New Global.System.Windows.Forms.Label()
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
			Me.pnlBorder.Size = New Global.System.Drawing.Size(596, 419)
			Me.pnlBorder.TabIndex = 4
			Me.pnlMain.BackColor = Global.System.Drawing.Color.White
			Me.pnlMain.Controls.Add(Me.cmbState)
			Me.pnlMain.Controls.Add(Me.cmbCity)
			Me.pnlMain.Controls.Add(Me.Label5)
			Me.pnlMain.Controls.Add(Me.Label4)
			Me.pnlMain.Controls.Add(Me.txtDtlsID)
			Me.pnlMain.Controls.Add(Me.txtID)
			Me.pnlMain.Controls.Add(Me.Label3)
			Me.pnlMain.Controls.Add(Me.txtTINNo)
			Me.pnlMain.Controls.Add(Me.btnSave)
			Me.pnlMain.Controls.Add(Me.btnDelete)
			Me.pnlMain.Controls.Add(Me.btnClose)
			Me.pnlMain.Controls.Add(Me.Label1)
			Me.pnlMain.Controls.Add(Me.txtGSTINNo)
			Me.pnlMain.Controls.Add(Me.cmbGSTType)
			Me.pnlMain.Controls.Add(Me.Label2)
			Me.pnlMain.Controls.Add(Me.cmbGSTINRegistration)
			Me.pnlMain.Controls.Add(Me.Label43)
			Me.pnlMain.Controls.Add(Me.txtCellNo)
			Me.pnlMain.Controls.Add(Me.Label48)
			Me.pnlMain.Controls.Add(Me.txtEmailAddress)
			Me.pnlMain.Controls.Add(Me.txtLandlineNo)
			Me.pnlMain.Controls.Add(Me.Label49)
			Me.pnlMain.Controls.Add(Me.Label50)
			Me.pnlMain.Controls.Add(Me.Label46)
			Me.pnlMain.Controls.Add(Me.txtContactName)
			Me.pnlMain.Controls.Add(Me.txtPincode)
			Me.pnlMain.Controls.Add(Me.txtPANNo)
			Me.pnlMain.Controls.Add(Me.Label31)
			Me.pnlMain.Controls.Add(Me.Label51)
			Me.pnlMain.Controls.Add(Me.Label52)
			Me.pnlMain.Controls.Add(Me.Label53)
			Me.pnlMain.Controls.Add(Me.txtAddress)
			Me.pnlMain.Controls.Add(Me.Label54)
			Me.pnlMain.Controls.Add(Me.cmbAddressType)
			Me.pnlMain.Controls.Add(Me.Label42)
			Me.pnlMain.Controls.Add(Me.panelTitleBar)
			Me.pnlMain.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.pnlMain.Location = New Global.System.Drawing.Point(3, 3)
			Me.pnlMain.Name = "pnlMain"
			Me.pnlMain.Size = New Global.System.Drawing.Size(590, 413)
			Me.pnlMain.TabIndex = 1
			Me.cmbState.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.cmbState.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbState.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbState.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbState.FormattingEnabled = True
			Me.cmbState.Items.AddRange(New Object() { "" })
			Me.cmbState.Location = New Global.System.Drawing.Point(144, 151)
			Me.cmbState.Name = "cmbState"
			Me.cmbState.Size = New Global.System.Drawing.Size(424, 23)
			Me.cmbState.TabIndex = 4
			Me.cmbCity.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.cmbCity.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbCity.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbCity.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbCity.FormattingEnabled = True
			Me.cmbCity.Items.AddRange(New Object() { "" })
			Me.cmbCity.Location = New Global.System.Drawing.Point(144, 126)
			Me.cmbCity.Name = "cmbCity"
			Me.cmbCity.Size = New Global.System.Drawing.Size(153, 23)
			Me.cmbCity.TabIndex = 2
			Me.Label5.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label5.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label5.ForeColor = Global.System.Drawing.Color.Red
			Me.Label5.Location = New Global.System.Drawing.Point(12, 85)
			Me.Label5.Name = "Label5"
			Me.Label5.Size = New Global.System.Drawing.Size(11, 15)
			Me.Label5.TabIndex = 938
			Me.Label5.Text = "*"
			Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label4.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label4.ForeColor = Global.System.Drawing.Color.Red
			Me.Label4.Location = New Global.System.Drawing.Point(12, 39)
			Me.Label4.Name = "Label4"
			Me.Label4.Size = New Global.System.Drawing.Size(11, 15)
			Me.Label4.TabIndex = 937
			Me.Label4.Text = "*"
			Me.Label4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.txtDtlsID.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtDtlsID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtDtlsID.Location = New Global.System.Drawing.Point(494, 381)
			Me.txtDtlsID.Name = "txtDtlsID"
			Me.txtDtlsID.Size = New Global.System.Drawing.Size(34, 21)
			Me.txtDtlsID.TabIndex = 17
			Me.txtDtlsID.TabStop = False
			Me.txtDtlsID.Visible = False
			Me.txtID.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.txtID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtID.Location = New Global.System.Drawing.Point(534, 381)
			Me.txtID.Name = "txtID"
			Me.txtID.Size = New Global.System.Drawing.Size(34, 21)
			Me.txtID.TabIndex = 18
			Me.txtID.TabStop = False
			Me.txtID.Visible = False
			Me.Label3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.Location = New Global.System.Drawing.Point(22, 349)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(119, 21)
			Me.Label3.TabIndex = 875
			Me.Label3.Text = "TIN No."
			Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.txtTINNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtTINNo.Location = New Global.System.Drawing.Point(144, 349)
			Me.txtTINNo.Name = "txtTINNo"
			Me.txtTINNo.Size = New Global.System.Drawing.Size(424, 21)
			Me.txtTINNo.TabIndex = 13
			Me.btnSave.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnSave.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnSave.Location = New Global.System.Drawing.Point(173, 378)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New Global.System.Drawing.Size(80, 26)
			Me.btnSave.TabIndex = 14
			Me.btnSave.Text = "&Save"
			Me.btnSave.UseVisualStyleBackColor = True
			Me.btnDelete.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnDelete.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnDelete.Location = New Global.System.Drawing.Point(255, 378)
			Me.btnDelete.Name = "btnDelete"
			Me.btnDelete.Size = New Global.System.Drawing.Size(80, 26)
			Me.btnDelete.TabIndex = 15
			Me.btnDelete.Text = "&Delete"
			Me.btnDelete.UseVisualStyleBackColor = True
			Me.btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnClose.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClose.Location = New Global.System.Drawing.Point(337, 378)
			Me.btnClose.Name = "btnClose"
			Me.btnClose.Size = New Global.System.Drawing.Size(80, 26)
			Me.btnClose.TabIndex = 16
			Me.btnClose.Text = "C&lose"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.Label1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.Location = New Global.System.Drawing.Point(22, 325)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(119, 21)
			Me.Label1.TabIndex = 870
			Me.Label1.Text = "GSTIN No."
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.txtGSTINNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtGSTINNo.Location = New Global.System.Drawing.Point(144, 325)
			Me.txtGSTINNo.Name = "txtGSTINNo"
			Me.txtGSTINNo.Size = New Global.System.Drawing.Size(424, 21)
			Me.txtGSTINNo.TabIndex = 12
			Me.cmbGSTType.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbGSTType.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbGSTType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbGSTType.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbGSTType.FormattingEnabled = True
			Me.cmbGSTType.Items.AddRange(New Object() { "", "Regular", "Composition levy", "Casual Taxable person", "Government or PSU", "Non resident" })
			Me.cmbGSTType.Location = New Global.System.Drawing.Point(144, 299)
			Me.cmbGSTType.Name = "cmbGSTType"
			Me.cmbGSTType.Size = New Global.System.Drawing.Size(424, 23)
			Me.cmbGSTType.TabIndex = 11
			Me.Label2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.Location = New Global.System.Drawing.Point(22, 299)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(119, 23)
			Me.Label2.TabIndex = 865
			Me.Label2.Text = "GST Type"
			Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.cmbGSTINRegistration.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbGSTINRegistration.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbGSTINRegistration.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbGSTINRegistration.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbGSTINRegistration.FormattingEnabled = True
			Me.cmbGSTINRegistration.Items.AddRange(New Object() { "", "Yes", "No" })
			Me.cmbGSTINRegistration.Location = New Global.System.Drawing.Point(144, 273)
			Me.cmbGSTINRegistration.Name = "cmbGSTINRegistration"
			Me.cmbGSTINRegistration.Size = New Global.System.Drawing.Size(424, 23)
			Me.cmbGSTINRegistration.TabIndex = 10
			Me.Label43.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label43.Location = New Global.System.Drawing.Point(22, 273)
			Me.Label43.Name = "Label43"
			Me.Label43.Size = New Global.System.Drawing.Size(119, 23)
			Me.Label43.TabIndex = 863
			Me.Label43.Text = "GSTIN Registration"
			Me.Label43.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.txtCellNo.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Upper
			Me.txtCellNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtCellNo.Location = New Global.System.Drawing.Point(415, 225)
			Me.txtCellNo.Name = "txtCellNo"
			Me.txtCellNo.Size = New Global.System.Drawing.Size(153, 21)
			Me.txtCellNo.TabIndex = 8
			Me.Label48.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label48.Location = New Global.System.Drawing.Point(22, 249)
			Me.Label48.Name = "Label48"
			Me.Label48.Size = New Global.System.Drawing.Size(119, 21)
			Me.Label48.TabIndex = 861
			Me.Label48.Text = "Email Address"
			Me.Label48.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.txtEmailAddress.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtEmailAddress.Location = New Global.System.Drawing.Point(144, 249)
			Me.txtEmailAddress.Name = "txtEmailAddress"
			Me.txtEmailAddress.Size = New Global.System.Drawing.Size(424, 21)
			Me.txtEmailAddress.TabIndex = 9
			Me.txtLandlineNo.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Upper
			Me.txtLandlineNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtLandlineNo.Location = New Global.System.Drawing.Point(144, 225)
			Me.txtLandlineNo.Name = "txtLandlineNo"
			Me.txtLandlineNo.Size = New Global.System.Drawing.Size(153, 21)
			Me.txtLandlineNo.TabIndex = 7
			Me.Label49.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label49.Location = New Global.System.Drawing.Point(22, 225)
			Me.Label49.Name = "Label49"
			Me.Label49.Size = New Global.System.Drawing.Size(119, 21)
			Me.Label49.TabIndex = 858
			Me.Label49.Text = "Landline No."
			Me.Label49.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label50.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label50.Location = New Global.System.Drawing.Point(303, 225)
			Me.Label50.Name = "Label50"
			Me.Label50.Size = New Global.System.Drawing.Size(109, 21)
			Me.Label50.TabIndex = 857
			Me.Label50.Text = "Cell No."
			Me.Label50.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label46.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label46.Location = New Global.System.Drawing.Point(22, 201)
			Me.Label46.Name = "Label46"
			Me.Label46.Size = New Global.System.Drawing.Size(119, 21)
			Me.Label46.TabIndex = 856
			Me.Label46.Text = "Contact Name"
			Me.Label46.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.txtContactName.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtContactName.Location = New Global.System.Drawing.Point(144, 201)
			Me.txtContactName.Name = "txtContactName"
			Me.txtContactName.Size = New Global.System.Drawing.Size(424, 21)
			Me.txtContactName.TabIndex = 6
			Me.txtPincode.CharacterCasing = Global.System.Windows.Forms.CharacterCasing.Upper
			Me.txtPincode.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPincode.Location = New Global.System.Drawing.Point(415, 127)
			Me.txtPincode.Name = "txtPincode"
			Me.txtPincode.Size = New Global.System.Drawing.Size(153, 21)
			Me.txtPincode.TabIndex = 3
			Me.txtPANNo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPANNo.Location = New Global.System.Drawing.Point(144, 177)
			Me.txtPANNo.Name = "txtPANNo"
			Me.txtPANNo.Size = New Global.System.Drawing.Size(424, 21)
			Me.txtPANNo.TabIndex = 5
			Me.Label31.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label31.Location = New Global.System.Drawing.Point(22, 177)
			Me.Label31.Name = "Label31"
			Me.Label31.Size = New Global.System.Drawing.Size(119, 21)
			Me.Label31.TabIndex = 854
			Me.Label31.Text = "PAN No."
			Me.Label31.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label51.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label51.Location = New Global.System.Drawing.Point(22, 152)
			Me.Label51.Name = "Label51"
			Me.Label51.Size = New Global.System.Drawing.Size(119, 21)
			Me.Label51.TabIndex = 851
			Me.Label51.Text = "State"
			Me.Label51.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label52.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label52.Location = New Global.System.Drawing.Point(22, 127)
			Me.Label52.Name = "Label52"
			Me.Label52.Size = New Global.System.Drawing.Size(119, 21)
			Me.Label52.TabIndex = 848
			Me.Label52.Text = "City"
			Me.Label52.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label53.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label53.Location = New Global.System.Drawing.Point(303, 127)
			Me.Label53.Name = "Label53"
			Me.Label53.Size = New Global.System.Drawing.Size(109, 21)
			Me.Label53.TabIndex = 847
			Me.Label53.Text = "Pin Code"
			Me.Label53.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.txtAddress.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtAddress.Location = New Global.System.Drawing.Point(144, 61)
			Me.txtAddress.Multiline = True
			Me.txtAddress.Name = "txtAddress"
			Me.txtAddress.Size = New Global.System.Drawing.Size(424, 63)
			Me.txtAddress.TabIndex = 1
			Me.Label54.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label54.Location = New Global.System.Drawing.Point(22, 61)
			Me.Label54.Name = "Label54"
			Me.Label54.Size = New Global.System.Drawing.Size(119, 63)
			Me.Label54.TabIndex = 846
			Me.Label54.Text = "Address"
			Me.Label54.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.cmbAddressType.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbAddressType.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbAddressType.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbAddressType.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbAddressType.FormattingEnabled = True
			Me.cmbAddressType.Items.AddRange(New Object() { "", "Permanent", "Ship/ Bill" })
			Me.cmbAddressType.Location = New Global.System.Drawing.Point(144, 35)
			Me.cmbAddressType.Name = "cmbAddressType"
			Me.cmbAddressType.Size = New Global.System.Drawing.Size(424, 23)
			Me.cmbAddressType.TabIndex = 0
			Me.Label42.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label42.Location = New Global.System.Drawing.Point(22, 35)
			Me.Label42.Name = "Label42"
			Me.Label42.Size = New Global.System.Drawing.Size(119, 23)
			Me.Label42.TabIndex = 792
			Me.Label42.Text = "Address Type"
			Me.Label42.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.panelTitleBar.BackColor = Global.System.Drawing.Color.FromArgb(204, 231, 255)
			Me.panelTitleBar.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.panelTitleBar.Controls.Add(Me.picFormIcon)
			Me.panelTitleBar.Controls.Add(Me.lblCaption)
			Me.panelTitleBar.Controls.Add(Me.form_btnClose)
			Me.panelTitleBar.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.panelTitleBar.Location = New Global.System.Drawing.Point(0, 0)
			Me.panelTitleBar.Name = "panelTitleBar"
			Me.panelTitleBar.Size = New Global.System.Drawing.Size(590, 27)
			Me.panelTitleBar.TabIndex = 100
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
			Me.form_btnClose.Location = New Global.System.Drawing.Point(564, 1)
			Me.form_btnClose.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.form_btnClose.Name = "form_btnClose"
			Me.form_btnClose.Size = New Global.System.Drawing.Size(24, 24)
			Me.form_btnClose.TabIndex = 601
			Me.form_btnClose.TabStop = False
			Me.form_btnClose.UseVisualStyleBackColor = True
			Me.lblShadow1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblShadow1.BackColor = Global.System.Drawing.Color.White
			Me.lblShadow1.Location = New Global.System.Drawing.Point(596, 0)
			Me.lblShadow1.Name = "lblShadow1"
			Me.lblShadow1.Size = New Global.System.Drawing.Size(6, 9)
			Me.lblShadow1.TabIndex = 600
			Me.lblShadow2.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
			Me.lblShadow2.BackColor = Global.System.Drawing.Color.White
			Me.lblShadow2.Location = New Global.System.Drawing.Point(0, 418)
			Me.lblShadow2.Name = "lblShadow2"
			Me.lblShadow2.Size = New Global.System.Drawing.Size(9, 7)
			Me.lblShadow2.TabIndex = 5
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.DarkGray
			MyBase.ClientSize = New Global.System.Drawing.Size(601, 424)
			MyBase.Controls.Add(Me.pnlBorder)
			MyBase.Controls.Add(Me.lblShadow1)
			MyBase.Controls.Add(Me.lblShadow2)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedToolWindow
			MyBase.Name = "VendorAddress"
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Vendor Address"
			Me.pnlBorder.ResumeLayout(False)
			Me.pnlMain.ResumeLayout(False)
			Me.pnlMain.PerformLayout()
			Me.panelTitleBar.ResumeLayout(False)
			Me.panelTitleBar.PerformLayout()
			CType(Me.picFormIcon, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000322 RID: 802
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
