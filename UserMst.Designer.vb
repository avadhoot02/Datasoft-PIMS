Namespace Datasoft_PIMS
	' Token: 0x02000020 RID: 32
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class UserMst
		Inherits Global.WeifenLuo.WinFormsUI.Docking.DockContent

		' Token: 0x060005BD RID: 1469 RVA: 0x000345F8 File Offset: 0x000327F8
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

		' Token: 0x060005BE RID: 1470 RVA: 0x00034648 File Offset: 0x00032848
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.FolderSelect = New Global.System.Windows.Forms.FolderBrowserDialog()
			Me.FileSelect = New Global.System.Windows.Forms.OpenFileDialog()
			Me.theme_tc = New Global.System.Windows.Forms.TabControl()
			Me.tpDetails = New Global.System.Windows.Forms.TabPage()
			Me.txtSessionID = New Global.System.Windows.Forms.TextBox()
			Me.skip_Label10 = New Global.System.Windows.Forms.Label()
			Me.btnLogoff = New Global.System.Windows.Forms.Button()
			Me.Label14 = New Global.System.Windows.Forms.Label()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Label13 = New Global.System.Windows.Forms.Label()
			Me.Label17 = New Global.System.Windows.Forms.Label()
			Me.cmbDesignation = New Global.System.Windows.Forms.ComboBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.skip_Label11 = New Global.System.Windows.Forms.Label()
			Me.txtEmailID = New Global.System.Windows.Forms.TextBox()
			Me.lblStrength = New Global.System.Windows.Forms.Label()
			Me.chkIsLocked = New Global.System.Windows.Forms.CheckBox()
			Me.txtUserName = New Global.System.Windows.Forms.TextBox()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.txtID = New Global.System.Windows.Forms.TextBox()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.skip_Label9 = New Global.System.Windows.Forms.Label()
			Me.Label10 = New Global.System.Windows.Forms.Label()
			Me.skip_Label8 = New Global.System.Windows.Forms.Label()
			Me.Label12 = New Global.System.Windows.Forms.Label()
			Me.cmbGroup = New Global.System.Windows.Forms.ComboBox()
			Me.chkIsActive = New Global.System.Windows.Forms.CheckBox()
			Me.txtLogin = New Global.System.Windows.Forms.TextBox()
			Me.txtPass = New Global.System.Windows.Forms.TextBox()
			Me.btnAdd = New Global.System.Windows.Forms.Button()
			Me.skip_Label13 = New Global.System.Windows.Forms.Label()
			Me.btnSave = New Global.System.Windows.Forms.Button()
			Me.skip_Label12 = New Global.System.Windows.Forms.Label()
			Me.btnClear = New Global.System.Windows.Forms.Button()
			Me.btnEdit = New Global.System.Windows.Forms.Button()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.tab_lblDetails = New Global.System.Windows.Forms.Label()
			Me.cmbPlant = New Global.System.Windows.Forms.ComboBox()
			Me.txtIPAddress = New Global.System.Windows.Forms.TextBox()
			Me.txtSessionState = New Global.System.Windows.Forms.TextBox()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.txtComputerName = New Global.System.Windows.Forms.TextBox()
			Me.tpList = New Global.System.Windows.Forms.TabPage()
			Me.dgvList = New Global.System.Windows.Forms.DataGridView()
			Me.grpListButton = New Global.System.Windows.Forms.GroupBox()
			Me.FlowLayoutPanel1 = New Global.System.Windows.Forms.FlowLayoutPanel()
			Me.btnSearch = New Global.System.Windows.Forms.Button()
			Me.btnClearList = New Global.System.Windows.Forms.Button()
			Me.btnExport = New Global.System.Windows.Forms.Button()
			Me.lblRows = New Global.System.Windows.Forms.Label()
			Me.GbAdvanced = New Global.System.Windows.Forms.GroupBox()
			Me.cmbIsLocked = New Global.System.Windows.Forms.ComboBox()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.txtSCreated = New Global.System.Windows.Forms.TextBox()
			Me.lblSCreated = New Global.System.Windows.Forms.ComboBox()
			Me.dtpFrom = New Global.System.Windows.Forms.DateTimePicker()
			Me.dtpTo = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label16 = New Global.System.Windows.Forms.Label()
			Me.lblSDate = New Global.System.Windows.Forms.ComboBox()
			Me.cmbSPlant = New Global.System.Windows.Forms.ComboBox()
			Me.Label15 = New Global.System.Windows.Forms.Label()
			Me.cmbSGroup = New Global.System.Windows.Forms.ComboBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.cmbStatus = New Global.System.Windows.Forms.ComboBox()
			Me.Label11 = New Global.System.Windows.Forms.Label()
			Me.arrow_btnAdvanceExp_sml = New Global.System.Windows.Forms.Button()
			Me.GbBasic = New Global.System.Windows.Forms.GroupBox()
			Me.txtSUserName = New Global.System.Windows.Forms.TextBox()
			Me.arrow_btnBasicExp_sml = New Global.System.Windows.Forms.Button()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.txtSLogin = New Global.System.Windows.Forms.TextBox()
			Me.lblSLogin = New Global.System.Windows.Forms.Label()
			Me.tab_lblList = New Global.System.Windows.Forms.Label()
			Me.cmbDepartment = New Global.System.Windows.Forms.ComboBox()
			Me.cmbManager = New Global.System.Windows.Forms.ComboBox()
			Me.cmbReporting = New Global.System.Windows.Forms.ComboBox()
			Me.Label18 = New Global.System.Windows.Forms.Label()
			Me.Label19 = New Global.System.Windows.Forms.Label()
			Me.Label20 = New Global.System.Windows.Forms.Label()
			Me.Label21 = New Global.System.Windows.Forms.Label()
			Me.Label22 = New Global.System.Windows.Forms.Label()
			Me.Label23 = New Global.System.Windows.Forms.Label()
			Me.theme_tc.SuspendLayout()
			Me.tpDetails.SuspendLayout()
			Me.Panel1.SuspendLayout()
			Me.tpList.SuspendLayout()
			CType(Me.dgvList, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.grpListButton.SuspendLayout()
			Me.FlowLayoutPanel1.SuspendLayout()
			Me.GbAdvanced.SuspendLayout()
			Me.GbBasic.SuspendLayout()
			MyBase.SuspendLayout()
			Me.FileSelect.Filter = "Text File|*.txt"
			Me.theme_tc.Controls.Add(Me.tpDetails)
			Me.theme_tc.Controls.Add(Me.tpList)
			Me.theme_tc.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.theme_tc.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.theme_tc.ItemSize = New Global.System.Drawing.Size(415, 21)
			Me.theme_tc.Location = New Global.System.Drawing.Point(0, 0)
			Me.theme_tc.Name = "theme_tc"
			Me.theme_tc.SelectedIndex = 0
			Me.theme_tc.Size = New Global.System.Drawing.Size(1005, 459)
			Me.theme_tc.SizeMode = Global.System.Windows.Forms.TabSizeMode.Fixed
			Me.theme_tc.TabIndex = 4
			Me.theme_tc.TabStop = False
			Me.tpDetails.BackColor = Global.System.Drawing.Color.White
			Me.tpDetails.Controls.Add(Me.txtSessionID)
			Me.tpDetails.Controls.Add(Me.skip_Label10)
			Me.tpDetails.Controls.Add(Me.btnLogoff)
			Me.tpDetails.Controls.Add(Me.Label14)
			Me.tpDetails.Controls.Add(Me.Panel1)
			Me.tpDetails.Controls.Add(Me.Label2)
			Me.tpDetails.Controls.Add(Me.tab_lblDetails)
			Me.tpDetails.Controls.Add(Me.cmbPlant)
			Me.tpDetails.Controls.Add(Me.txtIPAddress)
			Me.tpDetails.Controls.Add(Me.txtSessionState)
			Me.tpDetails.Controls.Add(Me.Label9)
			Me.tpDetails.Controls.Add(Me.Label1)
			Me.tpDetails.Controls.Add(Me.txtComputerName)
			Me.tpDetails.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.tpDetails.Location = New Global.System.Drawing.Point(4, 25)
			Me.tpDetails.Name = "tpDetails"
			Me.tpDetails.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tpDetails.Size = New Global.System.Drawing.Size(997, 430)
			Me.tpDetails.TabIndex = 0
			Me.tpDetails.Text = "                           Details                           "
			Me.tpDetails.UseVisualStyleBackColor = True
			Me.txtSessionID.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.txtSessionID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtSessionID.Location = New Global.System.Drawing.Point(955, 145)
			Me.txtSessionID.Name = "txtSessionID"
			Me.txtSessionID.Size = New Global.System.Drawing.Size(34, 21)
			Me.txtSessionID.TabIndex = 42
			Me.txtSessionID.TabStop = False
			Me.txtSessionID.Visible = False
			Me.skip_Label10.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.skip_Label10.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.skip_Label10.ForeColor = Global.System.Drawing.Color.Red
			Me.skip_Label10.Location = New Global.System.Drawing.Point(842, 43)
			Me.skip_Label10.Name = "skip_Label10"
			Me.skip_Label10.Size = New Global.System.Drawing.Size(12, 15)
			Me.skip_Label10.TabIndex = 47
			Me.skip_Label10.Text = "*"
			Me.skip_Label10.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.skip_Label10.Visible = False
			Me.btnLogoff.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnLogoff.Enabled = False
			Me.btnLogoff.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnLogoff.Location = New Global.System.Drawing.Point(909, 173)
			Me.btnLogoff.Name = "btnLogoff"
			Me.btnLogoff.Size = New Global.System.Drawing.Size(80, 26)
			Me.btnLogoff.TabIndex = 13
			Me.btnLogoff.Text = "Log Off"
			Me.btnLogoff.UseVisualStyleBackColor = True
			Me.btnLogoff.Visible = False
			Me.Label14.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label14.AutoSize = True
			Me.Label14.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label14.Location = New Global.System.Drawing.Point(852, 42)
			Me.Label14.Name = "Label14"
			Me.Label14.Size = New Global.System.Drawing.Size(35, 15)
			Me.Label14.TabIndex = 46
			Me.Label14.Text = "Plant"
			Me.Label14.Visible = False
			Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.Panel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Panel1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Panel1.Controls.Add(Me.Label22)
			Me.Panel1.Controls.Add(Me.Label23)
			Me.Panel1.Controls.Add(Me.Label20)
			Me.Panel1.Controls.Add(Me.Label21)
			Me.Panel1.Controls.Add(Me.Label18)
			Me.Panel1.Controls.Add(Me.Label19)
			Me.Panel1.Controls.Add(Me.cmbReporting)
			Me.Panel1.Controls.Add(Me.cmbManager)
			Me.Panel1.Controls.Add(Me.cmbDepartment)
			Me.Panel1.Controls.Add(Me.Label13)
			Me.Panel1.Controls.Add(Me.Label17)
			Me.Panel1.Controls.Add(Me.cmbDesignation)
			Me.Panel1.Controls.Add(Me.Label3)
			Me.Panel1.Controls.Add(Me.skip_Label11)
			Me.Panel1.Controls.Add(Me.txtEmailID)
			Me.Panel1.Controls.Add(Me.lblStrength)
			Me.Panel1.Controls.Add(Me.chkIsLocked)
			Me.Panel1.Controls.Add(Me.txtUserName)
			Me.Panel1.Controls.Add(Me.Label4)
			Me.Panel1.Controls.Add(Me.txtID)
			Me.Panel1.Controls.Add(Me.Label8)
			Me.Panel1.Controls.Add(Me.skip_Label9)
			Me.Panel1.Controls.Add(Me.Label10)
			Me.Panel1.Controls.Add(Me.skip_Label8)
			Me.Panel1.Controls.Add(Me.Label12)
			Me.Panel1.Controls.Add(Me.cmbGroup)
			Me.Panel1.Controls.Add(Me.chkIsActive)
			Me.Panel1.Controls.Add(Me.txtLogin)
			Me.Panel1.Controls.Add(Me.txtPass)
			Me.Panel1.Controls.Add(Me.btnAdd)
			Me.Panel1.Controls.Add(Me.skip_Label13)
			Me.Panel1.Controls.Add(Me.btnSave)
			Me.Panel1.Controls.Add(Me.skip_Label12)
			Me.Panel1.Controls.Add(Me.btnClear)
			Me.Panel1.Controls.Add(Me.btnEdit)
			Me.Panel1.Controls.Add(Me.btnClose)
			Me.Panel1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Panel1.Location = New Global.System.Drawing.Point(186, 26)
			Me.Panel1.Name = "Panel1"
			Me.Panel1.Size = New Global.System.Drawing.Size(624, 379)
			Me.Panel1.TabIndex = 0
			Me.Label13.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label13.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label13.ForeColor = Global.System.Drawing.Color.Red
			Me.Label13.Location = New Global.System.Drawing.Point(60, 143)
			Me.Label13.Name = "Label13"
			Me.Label13.Size = New Global.System.Drawing.Size(12, 15)
			Me.Label13.TabIndex = 39
			Me.Label13.Text = "*"
			Me.Label13.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label17.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label17.AutoSize = True
			Me.Label17.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label17.Location = New Global.System.Drawing.Point(70, 142)
			Me.Label17.Name = "Label17"
			Me.Label17.Size = New Global.System.Drawing.Size(74, 15)
			Me.Label17.TabIndex = 38
			Me.Label17.Text = "Designation"
			Me.cmbDesignation.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.cmbDesignation.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbDesignation.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbDesignation.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbDesignation.FormattingEnabled = True
			Me.cmbDesignation.Location = New Global.System.Drawing.Point(172, 138)
			Me.cmbDesignation.Name = "cmbDesignation"
			Me.cmbDesignation.Size = New Global.System.Drawing.Size(382, 23)
			Me.cmbDesignation.TabIndex = 4
			Me.Label3.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.Location = New Global.System.Drawing.Point(70, 116)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(56, 15)
			Me.Label3.TabIndex = 35
			Me.Label3.Text = "Email ID"
			Me.skip_Label11.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.skip_Label11.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.skip_Label11.ForeColor = Global.System.Drawing.Color.Red
			Me.skip_Label11.Location = New Global.System.Drawing.Point(60, 118)
			Me.skip_Label11.Name = "skip_Label11"
			Me.skip_Label11.Size = New Global.System.Drawing.Size(12, 15)
			Me.skip_Label11.TabIndex = 36
			Me.skip_Label11.Text = "*"
			Me.skip_Label11.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.txtEmailID.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.txtEmailID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtEmailID.Location = New Global.System.Drawing.Point(172, 113)
			Me.txtEmailID.Name = "txtEmailID"
			Me.txtEmailID.Size = New Global.System.Drawing.Size(382, 21)
			Me.txtEmailID.TabIndex = 3
			Me.lblStrength.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.lblStrength.AutoSize = True
			Me.lblStrength.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblStrength.Location = New Global.System.Drawing.Point(557, 91)
			Me.lblStrength.Name = "lblStrength"
			Me.lblStrength.Size = New Global.System.Drawing.Size(12, 15)
			Me.lblStrength.TabIndex = 33
			Me.lblStrength.Text = "."
			Me.chkIsLocked.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.chkIsLocked.AutoSize = True
			Me.chkIsLocked.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.chkIsLocked.Location = New Global.System.Drawing.Point(473, 278)
			Me.chkIsLocked.Name = "chkIsLocked"
			Me.chkIsLocked.Size = New Global.System.Drawing.Size(81, 19)
			Me.chkIsLocked.TabIndex = 10
			Me.chkIsLocked.Text = "Is Locked"
			Me.chkIsLocked.UseVisualStyleBackColor = True
			Me.txtUserName.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.txtUserName.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtUserName.Location = New Global.System.Drawing.Point(172, 41)
			Me.txtUserName.Name = "txtUserName"
			Me.txtUserName.Size = New Global.System.Drawing.Size(382, 21)
			Me.txtUserName.TabIndex = 0
			Me.Label4.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label4.AutoSize = True
			Me.Label4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label4.Location = New Global.System.Drawing.Point(70, 44)
			Me.Label4.Name = "Label4"
			Me.Label4.Size = New Global.System.Drawing.Size(70, 15)
			Me.Label4.TabIndex = 14
			Me.Label4.Text = "User Name"
			Me.Label4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.txtID.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.txtID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtID.Location = New Global.System.Drawing.Point(560, 246)
			Me.txtID.Name = "txtID"
			Me.txtID.Size = New Global.System.Drawing.Size(34, 21)
			Me.txtID.TabIndex = 15
			Me.txtID.TabStop = False
			Me.txtID.Visible = False
			Me.Label8.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label8.AutoSize = True
			Me.Label8.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label8.Location = New Global.System.Drawing.Point(70, 69)
			Me.Label8.Name = "Label8"
			Me.Label8.Size = New Global.System.Drawing.Size(55, 15)
			Me.Label8.TabIndex = 17
			Me.Label8.Text = "Login ID"
			Me.skip_Label9.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.skip_Label9.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.skip_Label9.ForeColor = Global.System.Drawing.Color.Red
			Me.skip_Label9.Location = New Global.System.Drawing.Point(60, 250)
			Me.skip_Label9.Name = "skip_Label9"
			Me.skip_Label9.Size = New Global.System.Drawing.Size(12, 15)
			Me.skip_Label9.TabIndex = 27
			Me.skip_Label9.Text = "*"
			Me.skip_Label9.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label10.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label10.AutoSize = True
			Me.Label10.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label10.Location = New Global.System.Drawing.Point(70, 92)
			Me.Label10.Name = "Label10"
			Me.Label10.Size = New Global.System.Drawing.Size(61, 15)
			Me.Label10.TabIndex = 18
			Me.Label10.Text = "Password"
			Me.skip_Label8.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.skip_Label8.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.skip_Label8.ForeColor = Global.System.Drawing.Color.Red
			Me.skip_Label8.Location = New Global.System.Drawing.Point(60, 94)
			Me.skip_Label8.Name = "skip_Label8"
			Me.skip_Label8.Size = New Global.System.Drawing.Size(12, 15)
			Me.skip_Label8.TabIndex = 26
			Me.skip_Label8.Text = "*"
			Me.skip_Label8.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label12.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label12.AutoSize = True
			Me.Label12.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label12.Location = New Global.System.Drawing.Point(70, 250)
			Me.Label12.Name = "Label12"
			Me.Label12.Size = New Global.System.Drawing.Size(72, 15)
			Me.Label12.TabIndex = 19
			Me.Label12.Text = "User Group"
			Me.cmbGroup.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.cmbGroup.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbGroup.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbGroup.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbGroup.FormattingEnabled = True
			Me.cmbGroup.Location = New Global.System.Drawing.Point(172, 246)
			Me.cmbGroup.Name = "cmbGroup"
			Me.cmbGroup.Size = New Global.System.Drawing.Size(382, 23)
			Me.cmbGroup.TabIndex = 8
			Me.chkIsActive.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.chkIsActive.AutoSize = True
			Me.chkIsActive.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.chkIsActive.Location = New Global.System.Drawing.Point(174, 278)
			Me.chkIsActive.Name = "chkIsActive"
			Me.chkIsActive.Size = New Global.System.Drawing.Size(76, 19)
			Me.chkIsActive.TabIndex = 9
			Me.chkIsActive.Text = "Is Active"
			Me.chkIsActive.UseVisualStyleBackColor = True
			Me.txtLogin.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.txtLogin.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtLogin.Location = New Global.System.Drawing.Point(172, 65)
			Me.txtLogin.Name = "txtLogin"
			Me.txtLogin.Size = New Global.System.Drawing.Size(382, 21)
			Me.txtLogin.TabIndex = 1
			Me.txtPass.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.txtPass.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPass.Location = New Global.System.Drawing.Point(172, 89)
			Me.txtPass.Name = "txtPass"
			Me.txtPass.PasswordChar = "*"c
			Me.txtPass.Size = New Global.System.Drawing.Size(382, 21)
			Me.txtPass.TabIndex = 2
			Me.btnAdd.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnAdd.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnAdd.Location = New Global.System.Drawing.Point(107, 324)
			Me.btnAdd.Name = "btnAdd"
			Me.btnAdd.Size = New Global.System.Drawing.Size(80, 26)
			Me.btnAdd.TabIndex = 11
			Me.btnAdd.Text = "&Add"
			Me.btnAdd.UseVisualStyleBackColor = True
			Me.skip_Label13.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.skip_Label13.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.skip_Label13.ForeColor = Global.System.Drawing.Color.Red
			Me.skip_Label13.Location = New Global.System.Drawing.Point(60, 70)
			Me.skip_Label13.Name = "skip_Label13"
			Me.skip_Label13.Size = New Global.System.Drawing.Size(12, 15)
			Me.skip_Label13.TabIndex = 25
			Me.skip_Label13.Text = "*"
			Me.skip_Label13.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.btnSave.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnSave.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnSave.Location = New Global.System.Drawing.Point(271, 324)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New Global.System.Drawing.Size(80, 26)
			Me.btnSave.TabIndex = 13
			Me.btnSave.Text = "&Save"
			Me.btnSave.UseVisualStyleBackColor = True
			Me.skip_Label12.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.skip_Label12.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.skip_Label12.ForeColor = Global.System.Drawing.Color.Red
			Me.skip_Label12.Location = New Global.System.Drawing.Point(60, 45)
			Me.skip_Label12.Name = "skip_Label12"
			Me.skip_Label12.Size = New Global.System.Drawing.Size(12, 15)
			Me.skip_Label12.TabIndex = 24
			Me.skip_Label12.Text = "*"
			Me.skip_Label12.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.btnClear.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnClear.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClear.Location = New Global.System.Drawing.Point(353, 324)
			Me.btnClear.Name = "btnClear"
			Me.btnClear.Size = New Global.System.Drawing.Size(80, 26)
			Me.btnClear.TabIndex = 14
			Me.btnClear.Text = "&Clear"
			Me.btnClear.UseVisualStyleBackColor = True
			Me.btnEdit.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnEdit.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnEdit.Location = New Global.System.Drawing.Point(189, 324)
			Me.btnEdit.Name = "btnEdit"
			Me.btnEdit.Size = New Global.System.Drawing.Size(80, 26)
			Me.btnEdit.TabIndex = 12
			Me.btnEdit.Text = "&Modify"
			Me.btnEdit.UseVisualStyleBackColor = True
			Me.btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnClose.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClose.Location = New Global.System.Drawing.Point(435, 324)
			Me.btnClose.Name = "btnClose"
			Me.btnClose.Size = New Global.System.Drawing.Size(80, 26)
			Me.btnClose.TabIndex = 15
			Me.btnClose.Text = "C&lose"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.Label2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.Location = New Global.System.Drawing.Point(852, 120)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(69, 15)
			Me.Label2.TabIndex = 41
			Me.Label2.Text = "IP Address"
			Me.Label2.Visible = False
			Me.tab_lblDetails.BackColor = Global.System.Drawing.Color.Black
			Me.tab_lblDetails.ForeColor = Global.System.Drawing.Color.PaleGreen
			Me.tab_lblDetails.Location = New Global.System.Drawing.Point(0, 0)
			Me.tab_lblDetails.Name = "tab_lblDetails"
			Me.tab_lblDetails.Size = New Global.System.Drawing.Size(916, 3)
			Me.tab_lblDetails.TabIndex = 32
			Me.cmbPlant.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.cmbPlant.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbPlant.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbPlant.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbPlant.FormattingEnabled = True
			Me.cmbPlant.Location = New Global.System.Drawing.Point(909, 39)
			Me.cmbPlant.Name = "cmbPlant"
			Me.cmbPlant.Size = New Global.System.Drawing.Size(80, 23)
			Me.cmbPlant.TabIndex = 4
			Me.cmbPlant.Visible = False
			Me.txtIPAddress.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.txtIPAddress.BackColor = Global.System.Drawing.Color.White
			Me.txtIPAddress.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtIPAddress.Location = New Global.System.Drawing.Point(962, 118)
			Me.txtIPAddress.Name = "txtIPAddress"
			Me.txtIPAddress.[ReadOnly] = True
			Me.txtIPAddress.Size = New Global.System.Drawing.Size(27, 21)
			Me.txtIPAddress.TabIndex = 40
			Me.txtIPAddress.TabStop = False
			Me.txtIPAddress.Visible = False
			Me.txtSessionState.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.txtSessionState.BackColor = Global.System.Drawing.Color.White
			Me.txtSessionState.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtSessionState.ForeColor = Global.System.Drawing.Color.Black
			Me.txtSessionState.Location = New Global.System.Drawing.Point(962, 68)
			Me.txtSessionState.Name = "txtSessionState"
			Me.txtSessionState.[ReadOnly] = True
			Me.txtSessionState.Size = New Global.System.Drawing.Size(27, 21)
			Me.txtSessionState.TabIndex = 36
			Me.txtSessionState.TabStop = False
			Me.txtSessionState.Visible = False
			Me.Label9.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label9.AutoSize = True
			Me.Label9.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label9.Location = New Global.System.Drawing.Point(852, 70)
			Me.Label9.Name = "Label9"
			Me.Label9.Size = New Global.System.Drawing.Size(85, 15)
			Me.Label9.TabIndex = 37
			Me.Label9.Text = "Session State"
			Me.Label9.Visible = False
			Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.Location = New Global.System.Drawing.Point(852, 95)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(101, 15)
			Me.Label1.TabIndex = 39
			Me.Label1.Text = "Computer Name"
			Me.Label1.Visible = False
			Me.txtComputerName.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.txtComputerName.BackColor = Global.System.Drawing.Color.White
			Me.txtComputerName.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtComputerName.Location = New Global.System.Drawing.Point(962, 93)
			Me.txtComputerName.Name = "txtComputerName"
			Me.txtComputerName.[ReadOnly] = True
			Me.txtComputerName.Size = New Global.System.Drawing.Size(27, 21)
			Me.txtComputerName.TabIndex = 38
			Me.txtComputerName.TabStop = False
			Me.txtComputerName.Visible = False
			Me.tpList.BackColor = Global.System.Drawing.Color.White
			Me.tpList.Controls.Add(Me.dgvList)
			Me.tpList.Controls.Add(Me.grpListButton)
			Me.tpList.Controls.Add(Me.GbAdvanced)
			Me.tpList.Controls.Add(Me.GbBasic)
			Me.tpList.Controls.Add(Me.tab_lblList)
			Me.tpList.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.tpList.Location = New Global.System.Drawing.Point(4, 25)
			Me.tpList.Name = "tpList"
			Me.tpList.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tpList.Size = New Global.System.Drawing.Size(997, 430)
			Me.tpList.TabIndex = 1
			Me.tpList.Text = "                              List                              "
			Me.tpList.UseVisualStyleBackColor = True
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
			Me.dgvList.ColumnHeadersHeight = 25
			Me.dgvList.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.dgvList.Location = New Global.System.Drawing.Point(3, 241)
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
			Me.dgvList.Size = New Global.System.Drawing.Size(991, 186)
			Me.dgvList.TabIndex = 486
			Me.grpListButton.Controls.Add(Me.FlowLayoutPanel1)
			Me.grpListButton.Controls.Add(Me.lblRows)
			Me.grpListButton.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.grpListButton.Location = New Global.System.Drawing.Point(3, 192)
			Me.grpListButton.Name = "grpListButton"
			Me.grpListButton.Size = New Global.System.Drawing.Size(991, 49)
			Me.grpListButton.TabIndex = 482
			Me.grpListButton.TabStop = False
			Me.FlowLayoutPanel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
			Me.FlowLayoutPanel1.Controls.Add(Me.btnSearch)
			Me.FlowLayoutPanel1.Controls.Add(Me.btnClearList)
			Me.FlowLayoutPanel1.Controls.Add(Me.btnExport)
			Me.FlowLayoutPanel1.Location = New Global.System.Drawing.Point(6, 11)
			Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
			Me.FlowLayoutPanel1.Size = New Global.System.Drawing.Size(720, 35)
			Me.FlowLayoutPanel1.TabIndex = 0
			Me.btnSearch.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnSearch.Location = New Global.System.Drawing.Point(0, 3)
			Me.btnSearch.Margin = New Global.System.Windows.Forms.Padding(0, 3, 2, 3)
			Me.btnSearch.Name = "btnSearch"
			Me.btnSearch.Size = New Global.System.Drawing.Size(106, 29)
			Me.btnSearch.TabIndex = 1
			Me.btnSearch.Text = "Search"
			Me.btnSearch.UseVisualStyleBackColor = True
			Me.btnClearList.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClearList.Location = New Global.System.Drawing.Point(108, 3)
			Me.btnClearList.Margin = New Global.System.Windows.Forms.Padding(0, 3, 2, 3)
			Me.btnClearList.Name = "btnClearList"
			Me.btnClearList.Size = New Global.System.Drawing.Size(106, 29)
			Me.btnClearList.TabIndex = 2
			Me.btnClearList.Text = "Clear"
			Me.btnClearList.UseVisualStyleBackColor = True
			Me.btnExport.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnExport.Location = New Global.System.Drawing.Point(216, 3)
			Me.btnExport.Margin = New Global.System.Windows.Forms.Padding(0, 3, 2, 3)
			Me.btnExport.Name = "btnExport"
			Me.btnExport.Size = New Global.System.Drawing.Size(116, 29)
			Me.btnExport.TabIndex = 3
			Me.btnExport.Text = "Export XL"
			Me.btnExport.UseVisualStyleBackColor = True
			Me.lblRows.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblRows.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblRows.Location = New Global.System.Drawing.Point(875, 21)
			Me.lblRows.Name = "lblRows"
			Me.lblRows.Size = New Global.System.Drawing.Size(108, 15)
			Me.lblRows.TabIndex = 483
			Me.lblRows.Text = "0 - Rows"
			Me.lblRows.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.GbAdvanced.Controls.Add(Me.cmbIsLocked)
			Me.GbAdvanced.Controls.Add(Me.Label6)
			Me.GbAdvanced.Controls.Add(Me.txtSCreated)
			Me.GbAdvanced.Controls.Add(Me.lblSCreated)
			Me.GbAdvanced.Controls.Add(Me.dtpFrom)
			Me.GbAdvanced.Controls.Add(Me.dtpTo)
			Me.GbAdvanced.Controls.Add(Me.Label16)
			Me.GbAdvanced.Controls.Add(Me.lblSDate)
			Me.GbAdvanced.Controls.Add(Me.cmbSPlant)
			Me.GbAdvanced.Controls.Add(Me.Label15)
			Me.GbAdvanced.Controls.Add(Me.cmbSGroup)
			Me.GbAdvanced.Controls.Add(Me.Label5)
			Me.GbAdvanced.Controls.Add(Me.cmbStatus)
			Me.GbAdvanced.Controls.Add(Me.Label11)
			Me.GbAdvanced.Controls.Add(Me.arrow_btnAdvanceExp_sml)
			Me.GbAdvanced.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.GbAdvanced.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GbAdvanced.Location = New Global.System.Drawing.Point(3, 84)
			Me.GbAdvanced.Name = "GbAdvanced"
			Me.GbAdvanced.Size = New Global.System.Drawing.Size(991, 108)
			Me.GbAdvanced.TabIndex = 477
			Me.GbAdvanced.TabStop = False
			Me.GbAdvanced.Text = "     Advanced Search "
			Me.cmbIsLocked.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbIsLocked.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbIsLocked.FormattingEnabled = True
			Me.cmbIsLocked.Items.AddRange(New Object() { "", "Yes", "No" })
			Me.cmbIsLocked.Location = New Global.System.Drawing.Point(551, 77)
			Me.cmbIsLocked.Name = "cmbIsLocked"
			Me.cmbIsLocked.Size = New Global.System.Drawing.Size(110, 23)
			Me.cmbIsLocked.TabIndex = 481
			Me.Label6.AutoSize = True
			Me.Label6.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label6.Location = New Global.System.Drawing.Point(484, 80)
			Me.Label6.Name = "Label6"
			Me.Label6.Size = New Global.System.Drawing.Size(62, 15)
			Me.Label6.TabIndex = 482
			Me.Label6.Text = "Is Locked"
			Me.txtSCreated.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtSCreated.Location = New Global.System.Drawing.Point(151, 51)
			Me.txtSCreated.Name = "txtSCreated"
			Me.txtSCreated.Size = New Global.System.Drawing.Size(710, 21)
			Me.txtSCreated.TabIndex = 480
			Me.lblSCreated.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.lblSCreated.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.lblSCreated.BackColor = Global.System.Drawing.Color.White
			Me.lblSCreated.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.lblSCreated.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.lblSCreated.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblSCreated.FormattingEnabled = True
			Me.lblSCreated.Items.AddRange(New Object() { "Created By", "Last Modified By" })
			Me.lblSCreated.Location = New Global.System.Drawing.Point(15, 51)
			Me.lblSCreated.Name = "lblSCreated"
			Me.lblSCreated.Size = New Global.System.Drawing.Size(130, 23)
			Me.lblSCreated.TabIndex = 479
			Me.dtpFrom.CustomFormat = "dd MMM yyyy  00:00"
			Me.dtpFrom.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpFrom.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpFrom.Location = New Global.System.Drawing.Point(151, 26)
			Me.dtpFrom.Name = "dtpFrom"
			Me.dtpFrom.ShowCheckBox = True
			Me.dtpFrom.Size = New Global.System.Drawing.Size(310, 21)
			Me.dtpFrom.TabIndex = 478
			Me.dtpTo.CustomFormat = "dd MMM yyyy  23:59"
			Me.dtpTo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpTo.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpTo.Location = New Global.System.Drawing.Point(551, 26)
			Me.dtpTo.Name = "dtpTo"
			Me.dtpTo.ShowCheckBox = True
			Me.dtpTo.Size = New Global.System.Drawing.Size(310, 21)
			Me.dtpTo.TabIndex = 476
			Me.Label16.AutoSize = True
			Me.Label16.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label16.Location = New Global.System.Drawing.Point(484, 28)
			Me.Label16.Name = "Label16"
			Me.Label16.Size = New Global.System.Drawing.Size(21, 15)
			Me.Label16.TabIndex = 477
			Me.Label16.Text = "To"
			Me.Label16.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.lblSDate.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.lblSDate.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.lblSDate.BackColor = Global.System.Drawing.Color.White
			Me.lblSDate.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.lblSDate.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.lblSDate.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblSDate.FormattingEnabled = True
			Me.lblSDate.Items.AddRange(New Object() { "Creation", "Last Modification" })
			Me.lblSDate.Location = New Global.System.Drawing.Point(15, 25)
			Me.lblSDate.Name = "lblSDate"
			Me.lblSDate.Size = New Global.System.Drawing.Size(130, 23)
			Me.lblSDate.TabIndex = 475
			Me.cmbSPlant.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbSPlant.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbSPlant.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbSPlant.FormattingEnabled = True
			Me.cmbSPlant.Location = New Global.System.Drawing.Point(944, 46)
			Me.cmbSPlant.Name = "cmbSPlant"
			Me.cmbSPlant.Size = New Global.System.Drawing.Size(38, 23)
			Me.cmbSPlant.TabIndex = 469
			Me.cmbSPlant.Visible = False
			Me.Label15.AutoSize = True
			Me.Label15.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label15.Location = New Global.System.Drawing.Point(903, 51)
			Me.Label15.Name = "Label15"
			Me.Label15.Size = New Global.System.Drawing.Size(35, 15)
			Me.Label15.TabIndex = 474
			Me.Label15.Text = "Plant"
			Me.Label15.Visible = False
			Me.cmbSGroup.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbSGroup.FormattingEnabled = True
			Me.cmbSGroup.Location = New Global.System.Drawing.Point(151, 76)
			Me.cmbSGroup.Name = "cmbSGroup"
			Me.cmbSGroup.Size = New Global.System.Drawing.Size(310, 23)
			Me.cmbSGroup.TabIndex = 470
			Me.Label5.AutoSize = True
			Me.Label5.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label5.Location = New Global.System.Drawing.Point(15, 80)
			Me.Label5.Name = "Label5"
			Me.Label5.Size = New Global.System.Drawing.Size(72, 15)
			Me.Label5.TabIndex = 473
			Me.Label5.Text = "User Group"
			Me.cmbStatus.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbStatus.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbStatus.FormattingEnabled = True
			Me.cmbStatus.Items.AddRange(New Object() { "", "Active", "In Active" })
			Me.cmbStatus.Location = New Global.System.Drawing.Point(751, 76)
			Me.cmbStatus.Name = "cmbStatus"
			Me.cmbStatus.Size = New Global.System.Drawing.Size(110, 23)
			Me.cmbStatus.TabIndex = 471
			Me.Label11.AutoSize = True
			Me.Label11.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label11.Location = New Global.System.Drawing.Point(697, 79)
			Me.Label11.Name = "Label11"
			Me.Label11.Size = New Global.System.Drawing.Size(43, 15)
			Me.Label11.TabIndex = 472
			Me.Label11.Text = "Status"
			Me.arrow_btnAdvanceExp_sml.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.arrow_btnAdvanceExp_sml.FlatAppearance.BorderSize = 0
			Me.arrow_btnAdvanceExp_sml.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.arrow_btnAdvanceExp_sml.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.arrow_btnAdvanceExp_sml.ForeColor = Global.System.Drawing.Color.White
			Me.arrow_btnAdvanceExp_sml.Location = New Global.System.Drawing.Point(8, 0)
			Me.arrow_btnAdvanceExp_sml.Name = "arrow_btnAdvanceExp_sml"
			Me.arrow_btnAdvanceExp_sml.Size = New Global.System.Drawing.Size(20, 20)
			Me.arrow_btnAdvanceExp_sml.TabIndex = 4
			Me.arrow_btnAdvanceExp_sml.UseVisualStyleBackColor = True
			Me.GbBasic.BackColor = Global.System.Drawing.Color.White
			Me.GbBasic.Controls.Add(Me.txtSUserName)
			Me.GbBasic.Controls.Add(Me.arrow_btnBasicExp_sml)
			Me.GbBasic.Controls.Add(Me.Label7)
			Me.GbBasic.Controls.Add(Me.txtSLogin)
			Me.GbBasic.Controls.Add(Me.lblSLogin)
			Me.GbBasic.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.GbBasic.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GbBasic.Location = New Global.System.Drawing.Point(3, 3)
			Me.GbBasic.Name = "GbBasic"
			Me.GbBasic.Size = New Global.System.Drawing.Size(991, 81)
			Me.GbBasic.TabIndex = 476
			Me.GbBasic.TabStop = False
			Me.GbBasic.Text = "     Basic Search "
			Me.txtSUserName.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtSUserName.Location = New Global.System.Drawing.Point(151, 27)
			Me.txtSUserName.Name = "txtSUserName"
			Me.txtSUserName.Size = New Global.System.Drawing.Size(310, 21)
			Me.txtSUserName.TabIndex = 46
			Me.arrow_btnBasicExp_sml.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.arrow_btnBasicExp_sml.FlatAppearance.BorderSize = 0
			Me.arrow_btnBasicExp_sml.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.arrow_btnBasicExp_sml.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.arrow_btnBasicExp_sml.Location = New Global.System.Drawing.Point(8, 0)
			Me.arrow_btnBasicExp_sml.Name = "arrow_btnBasicExp_sml"
			Me.arrow_btnBasicExp_sml.Size = New Global.System.Drawing.Size(20, 20)
			Me.arrow_btnBasicExp_sml.TabIndex = 4
			Me.arrow_btnBasicExp_sml.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.arrow_btnBasicExp_sml.UseVisualStyleBackColor = True
			Me.Label7.AutoSize = True
			Me.Label7.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label7.Location = New Global.System.Drawing.Point(15, 30)
			Me.Label7.Name = "Label7"
			Me.Label7.Size = New Global.System.Drawing.Size(70, 15)
			Me.Label7.TabIndex = 47
			Me.Label7.Text = "User Name"
			Me.Label7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.txtSLogin.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtSLogin.Location = New Global.System.Drawing.Point(151, 52)
			Me.txtSLogin.Name = "txtSLogin"
			Me.txtSLogin.Size = New Global.System.Drawing.Size(310, 21)
			Me.txtSLogin.TabIndex = 44
			Me.lblSLogin.AutoSize = True
			Me.lblSLogin.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblSLogin.Location = New Global.System.Drawing.Point(15, 55)
			Me.lblSLogin.Name = "lblSLogin"
			Me.lblSLogin.Size = New Global.System.Drawing.Size(55, 15)
			Me.lblSLogin.TabIndex = 45
			Me.lblSLogin.Text = "Login ID"
			Me.lblSLogin.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.tab_lblList.BackColor = Global.System.Drawing.Color.Black
			Me.tab_lblList.ForeColor = Global.System.Drawing.Color.PaleGreen
			Me.tab_lblList.Location = New Global.System.Drawing.Point(0, 0)
			Me.tab_lblList.Name = "tab_lblList"
			Me.tab_lblList.Size = New Global.System.Drawing.Size(916, 3)
			Me.tab_lblList.TabIndex = 7
			Me.cmbDepartment.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.cmbDepartment.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbDepartment.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbDepartment.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbDepartment.FormattingEnabled = True
			Me.cmbDepartment.Location = New Global.System.Drawing.Point(172, 165)
			Me.cmbDepartment.Name = "cmbDepartment"
			Me.cmbDepartment.Size = New Global.System.Drawing.Size(382, 23)
			Me.cmbDepartment.TabIndex = 5
			Me.cmbManager.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.cmbManager.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbManager.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbManager.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbManager.FormattingEnabled = True
			Me.cmbManager.Location = New Global.System.Drawing.Point(172, 192)
			Me.cmbManager.Name = "cmbManager"
			Me.cmbManager.Size = New Global.System.Drawing.Size(382, 23)
			Me.cmbManager.TabIndex = 6
			Me.cmbReporting.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.cmbReporting.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbReporting.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.cmbReporting.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbReporting.FormattingEnabled = True
			Me.cmbReporting.Location = New Global.System.Drawing.Point(172, 219)
			Me.cmbReporting.Name = "cmbReporting"
			Me.cmbReporting.Size = New Global.System.Drawing.Size(382, 23)
			Me.cmbReporting.TabIndex = 7
			Me.Label18.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label18.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label18.ForeColor = Global.System.Drawing.Color.Red
			Me.Label18.Location = New Global.System.Drawing.Point(60, 169)
			Me.Label18.Name = "Label18"
			Me.Label18.Size = New Global.System.Drawing.Size(12, 15)
			Me.Label18.TabIndex = 44
			Me.Label18.Text = "*"
			Me.Label18.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label19.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label19.AutoSize = True
			Me.Label19.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label19.Location = New Global.System.Drawing.Point(70, 168)
			Me.Label19.Name = "Label19"
			Me.Label19.Size = New Global.System.Drawing.Size(75, 15)
			Me.Label19.TabIndex = 43
			Me.Label19.Text = "Department"
			Me.Label20.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label20.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label20.ForeColor = Global.System.Drawing.Color.Red
			Me.Label20.Location = New Global.System.Drawing.Point(60, 196)
			Me.Label20.Name = "Label20"
			Me.Label20.Size = New Global.System.Drawing.Size(12, 15)
			Me.Label20.TabIndex = 46
			Me.Label20.Text = "*"
			Me.Label20.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label21.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label21.AutoSize = True
			Me.Label21.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label21.Location = New Global.System.Drawing.Point(70, 195)
			Me.Label21.Name = "Label21"
			Me.Label21.Size = New Global.System.Drawing.Size(56, 15)
			Me.Label21.TabIndex = 45
			Me.Label21.Text = "Manager"
			Me.Label22.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label22.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label22.ForeColor = Global.System.Drawing.Color.Red
			Me.Label22.Location = New Global.System.Drawing.Point(60, 223)
			Me.Label22.Name = "Label22"
			Me.Label22.Size = New Global.System.Drawing.Size(12, 15)
			Me.Label22.TabIndex = 48
			Me.Label22.Text = "*"
			Me.Label22.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label23.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label23.AutoSize = True
			Me.Label23.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label23.Location = New Global.System.Drawing.Point(70, 222)
			Me.Label23.Name = "Label23"
			Me.Label23.Size = New Global.System.Drawing.Size(80, 15)
			Me.Label23.TabIndex = 47
			Me.Label23.Text = "Reporting To"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			MyBase.ClientSize = New Global.System.Drawing.Size(1005, 459)
			MyBase.Controls.Add(Me.theme_tc)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.Name = "UserMst"
			Me.Text = "User"
			Me.theme_tc.ResumeLayout(False)
			Me.tpDetails.ResumeLayout(False)
			Me.tpDetails.PerformLayout()
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.tpList.ResumeLayout(False)
			CType(Me.dgvList, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.grpListButton.ResumeLayout(False)
			Me.FlowLayoutPanel1.ResumeLayout(False)
			Me.GbAdvanced.ResumeLayout(False)
			Me.GbAdvanced.PerformLayout()
			Me.GbBasic.ResumeLayout(False)
			Me.GbBasic.PerformLayout()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x0400025C RID: 604
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
