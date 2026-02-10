Namespace Datasoft_PIMS
	' Token: 0x0200001F RID: 31
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class UserGroup
		Inherits Global.WeifenLuo.WinFormsUI.Docking.DockContent

		' Token: 0x06000538 RID: 1336 RVA: 0x0002F7B4 File Offset: 0x0002D9B4
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

		' Token: 0x06000539 RID: 1337 RVA: 0x0002F804 File Offset: 0x0002DA04
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim dataGridViewCellStyle As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle2 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle3 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle4 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Dim dataGridViewCellStyle5 As Global.System.Windows.Forms.DataGridViewCellStyle = New Global.System.Windows.Forms.DataGridViewCellStyle()
			Me.theme_tc = New Global.System.Windows.Forms.TabControl()
			Me.tpDetails = New Global.System.Windows.Forms.TabPage()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.PnlMasters = New Global.System.Windows.Forms.Panel()
			Me.chkMaster = New Global.System.Windows.Forms.CheckBox()
			Me.skip_dgv1 = New Global.System.Windows.Forms.DataGridView()
			Me.chk = New Global.System.Windows.Forms.DataGridViewCheckBoxColumn()
			Me.FormName = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.PnlAccessCtrl = New Global.System.Windows.Forms.Panel()
			Me.chkAccessCtrl = New Global.System.Windows.Forms.CheckBox()
			Me.skip_dgv2 = New Global.System.Windows.Forms.DataGridView()
			Me.chk1 = New Global.System.Windows.Forms.DataGridViewCheckBoxColumn()
			Me.FormName1 = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.txtUserGroup = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.txtID = New Global.System.Windows.Forms.TextBox()
			Me.chkIsActive = New Global.System.Windows.Forms.CheckBox()
			Me.btnAdd = New Global.System.Windows.Forms.Button()
			Me.btnSave = New Global.System.Windows.Forms.Button()
			Me.skip_Label12 = New Global.System.Windows.Forms.Label()
			Me.btnClear = New Global.System.Windows.Forms.Button()
			Me.btnEdit = New Global.System.Windows.Forms.Button()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.tab_lblDetails = New Global.System.Windows.Forms.Label()
			Me.tpList = New Global.System.Windows.Forms.TabPage()
			Me.tab_lblList = New Global.System.Windows.Forms.Label()
			Me.FolderSelect = New Global.System.Windows.Forms.FolderBrowserDialog()
			Me.GbBasic = New Global.System.Windows.Forms.GroupBox()
			Me.txtSUserGroup = New Global.System.Windows.Forms.TextBox()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.cmbStatus = New Global.System.Windows.Forms.ComboBox()
			Me.Label11 = New Global.System.Windows.Forms.Label()
			Me.arrow_btnBasicExp_sml = New Global.System.Windows.Forms.Button()
			Me.GbAdvanced = New Global.System.Windows.Forms.GroupBox()
			Me.txtSCreated = New Global.System.Windows.Forms.TextBox()
			Me.lblSCreated = New Global.System.Windows.Forms.ComboBox()
			Me.dtpFrom = New Global.System.Windows.Forms.DateTimePicker()
			Me.dtpTo = New Global.System.Windows.Forms.DateTimePicker()
			Me.Label16 = New Global.System.Windows.Forms.Label()
			Me.lblSDate = New Global.System.Windows.Forms.ComboBox()
			Me.arrow_btnAdvanceExp_sml = New Global.System.Windows.Forms.Button()
			Me.grpListButton = New Global.System.Windows.Forms.GroupBox()
			Me.FlowLayoutPanel1 = New Global.System.Windows.Forms.FlowLayoutPanel()
			Me.btnSearch = New Global.System.Windows.Forms.Button()
			Me.btnClearList = New Global.System.Windows.Forms.Button()
			Me.btnExport = New Global.System.Windows.Forms.Button()
			Me.lblRows = New Global.System.Windows.Forms.Label()
			Me.dgvList = New Global.System.Windows.Forms.DataGridView()
			Me.theme_tc.SuspendLayout()
			Me.tpDetails.SuspendLayout()
			Me.Panel1.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.PnlMasters.SuspendLayout()
			CType(Me.skip_dgv1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox2.SuspendLayout()
			Me.PnlAccessCtrl.SuspendLayout()
			CType(Me.skip_dgv2, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tpList.SuspendLayout()
			Me.GbBasic.SuspendLayout()
			Me.GbAdvanced.SuspendLayout()
			Me.grpListButton.SuspendLayout()
			Me.FlowLayoutPanel1.SuspendLayout()
			CType(Me.dgvList, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.theme_tc.Controls.Add(Me.tpDetails)
			Me.theme_tc.Controls.Add(Me.tpList)
			Me.theme_tc.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.theme_tc.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.theme_tc.ItemSize = New Global.System.Drawing.Size(415, 21)
			Me.theme_tc.Location = New Global.System.Drawing.Point(0, 0)
			Me.theme_tc.Name = "theme_tc"
			Me.theme_tc.SelectedIndex = 0
			Me.theme_tc.Size = New Global.System.Drawing.Size(858, 438)
			Me.theme_tc.SizeMode = Global.System.Windows.Forms.TabSizeMode.Fixed
			Me.theme_tc.TabIndex = 5
			Me.theme_tc.TabStop = False
			Me.tpDetails.BackColor = Global.System.Drawing.Color.White
			Me.tpDetails.Controls.Add(Me.Panel1)
			Me.tpDetails.Controls.Add(Me.tab_lblDetails)
			Me.tpDetails.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.tpDetails.Location = New Global.System.Drawing.Point(4, 25)
			Me.tpDetails.Name = "tpDetails"
			Me.tpDetails.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.tpDetails.Size = New Global.System.Drawing.Size(850, 409)
			Me.tpDetails.TabIndex = 0
			Me.tpDetails.Text = "                           Details                           "
			Me.tpDetails.UseVisualStyleBackColor = True
			Me.Panel1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.Panel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Panel1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Panel1.Controls.Add(Me.GroupBox1)
			Me.Panel1.Controls.Add(Me.GroupBox2)
			Me.Panel1.Controls.Add(Me.txtUserGroup)
			Me.Panel1.Controls.Add(Me.Label1)
			Me.Panel1.Controls.Add(Me.txtID)
			Me.Panel1.Controls.Add(Me.chkIsActive)
			Me.Panel1.Controls.Add(Me.btnAdd)
			Me.Panel1.Controls.Add(Me.btnSave)
			Me.Panel1.Controls.Add(Me.skip_Label12)
			Me.Panel1.Controls.Add(Me.btnClear)
			Me.Panel1.Controls.Add(Me.btnEdit)
			Me.Panel1.Controls.Add(Me.btnClose)
			Me.Panel1.Location = New Global.System.Drawing.Point(73, 33)
			Me.Panel1.Name = "Panel1"
			Me.Panel1.Size = New Global.System.Drawing.Size(705, 342)
			Me.Panel1.TabIndex = 33
			Me.GroupBox1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.GroupBox1.Controls.Add(Me.PnlMasters)
			Me.GroupBox1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GroupBox1.Location = New Global.System.Drawing.Point(39, 86)
			Me.GroupBox1.Name = "GroupBox1"
			Me.GroupBox1.Size = New Global.System.Drawing.Size(624, 209)
			Me.GroupBox1.TabIndex = 28
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Access Control && Authority"
			Me.PnlMasters.Controls.Add(Me.chkMaster)
			Me.PnlMasters.Controls.Add(Me.skip_dgv1)
			Me.PnlMasters.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.PnlMasters.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.PnlMasters.Location = New Global.System.Drawing.Point(3, 18)
			Me.PnlMasters.Name = "PnlMasters"
			Me.PnlMasters.Size = New Global.System.Drawing.Size(618, 188)
			Me.PnlMasters.TabIndex = 0
			Me.chkMaster.AutoSize = True
			Me.chkMaster.Location = New Global.System.Drawing.Point(10, 4)
			Me.chkMaster.Name = "chkMaster"
			Me.chkMaster.Size = New Global.System.Drawing.Size(79, 19)
			Me.chkMaster.TabIndex = 0
			Me.chkMaster.Text = "Select All"
			Me.chkMaster.UseVisualStyleBackColor = True
			Me.skip_dgv1.AllowUserToAddRows = False
			Me.skip_dgv1.AllowUserToDeleteRows = False
			Me.skip_dgv1.AllowUserToResizeColumns = False
			Me.skip_dgv1.AllowUserToResizeRows = False
			Me.skip_dgv1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.skip_dgv1.BackgroundColor = Global.System.Drawing.Color.White
			Me.skip_dgv1.CellBorderStyle = Global.System.Windows.Forms.DataGridViewCellBorderStyle.None
			Me.skip_dgv1.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.skip_dgv1.ColumnHeadersVisible = False
			Me.skip_dgv1.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.chk, Me.FormName })
			Me.skip_dgv1.Location = New Global.System.Drawing.Point(3, 29)
			Me.skip_dgv1.Name = "skip_dgv1"
			Me.skip_dgv1.RowHeadersVisible = False
			dataGridViewCellStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle.SelectionBackColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle.SelectionForeColor = Global.System.Drawing.Color.Black
			Me.skip_dgv1.RowsDefaultCellStyle = dataGridViewCellStyle
			Me.skip_dgv1.Size = New Global.System.Drawing.Size(612, 156)
			Me.skip_dgv1.TabIndex = 0
			Me.chk.HeaderText = "chk"
			Me.chk.Name = "chk"
			Me.chk.Width = 30
			Me.FormName.HeaderText = "FormName"
			Me.FormName.Name = "FormName"
			Me.FormName.[ReadOnly] = True
			Me.FormName.Width = 400
			Me.GroupBox2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.GroupBox2.Controls.Add(Me.PnlAccessCtrl)
			Me.GroupBox2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GroupBox2.Location = New Global.System.Drawing.Point(354, 86)
			Me.GroupBox2.Name = "GroupBox2"
			Me.GroupBox2.Size = New Global.System.Drawing.Size(309, 201)
			Me.GroupBox2.TabIndex = 29
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "Access Control"
			Me.GroupBox2.Visible = False
			Me.PnlAccessCtrl.Controls.Add(Me.chkAccessCtrl)
			Me.PnlAccessCtrl.Controls.Add(Me.skip_dgv2)
			Me.PnlAccessCtrl.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.PnlAccessCtrl.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.PnlAccessCtrl.Location = New Global.System.Drawing.Point(3, 18)
			Me.PnlAccessCtrl.Name = "PnlAccessCtrl"
			Me.PnlAccessCtrl.Size = New Global.System.Drawing.Size(303, 180)
			Me.PnlAccessCtrl.TabIndex = 0
			Me.chkAccessCtrl.AutoSize = True
			Me.chkAccessCtrl.Location = New Global.System.Drawing.Point(10, 4)
			Me.chkAccessCtrl.Name = "chkAccessCtrl"
			Me.chkAccessCtrl.Size = New Global.System.Drawing.Size(79, 19)
			Me.chkAccessCtrl.TabIndex = 0
			Me.chkAccessCtrl.Text = "Select All"
			Me.chkAccessCtrl.UseVisualStyleBackColor = True
			Me.skip_dgv2.AllowUserToAddRows = False
			Me.skip_dgv2.AllowUserToDeleteRows = False
			Me.skip_dgv2.AllowUserToResizeColumns = False
			Me.skip_dgv2.AllowUserToResizeRows = False
			Me.skip_dgv2.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.skip_dgv2.BackgroundColor = Global.System.Drawing.Color.White
			Me.skip_dgv2.CellBorderStyle = Global.System.Windows.Forms.DataGridViewCellBorderStyle.None
			Me.skip_dgv2.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.skip_dgv2.ColumnHeadersVisible = False
			Me.skip_dgv2.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.chk1, Me.FormName1 })
			Me.skip_dgv2.Location = New Global.System.Drawing.Point(3, 29)
			Me.skip_dgv2.Name = "skip_dgv2"
			Me.skip_dgv2.RowHeadersVisible = False
			dataGridViewCellStyle2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle2.SelectionBackColor = Global.System.Drawing.Color.White
			dataGridViewCellStyle2.SelectionForeColor = Global.System.Drawing.Color.Black
			Me.skip_dgv2.RowsDefaultCellStyle = dataGridViewCellStyle2
			Me.skip_dgv2.Size = New Global.System.Drawing.Size(297, 148)
			Me.skip_dgv2.TabIndex = 0
			Me.chk1.HeaderText = "chk"
			Me.chk1.Name = "chk1"
			Me.chk1.Width = 30
			Me.FormName1.HeaderText = "FormName"
			Me.FormName1.Name = "FormName1"
			Me.FormName1.[ReadOnly] = True
			Me.FormName1.Width = 200
			Me.txtUserGroup.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.txtUserGroup.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtUserGroup.Location = New Global.System.Drawing.Point(214, 24)
			Me.txtUserGroup.Name = "txtUserGroup"
			Me.txtUserGroup.Size = New Global.System.Drawing.Size(364, 21)
			Me.txtUserGroup.TabIndex = 0
			Me.Label1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.Location = New Global.System.Drawing.Point(123, 27)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(72, 15)
			Me.Label1.TabIndex = 14
			Me.Label1.Text = "User Group"
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.txtID.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.txtID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtID.Location = New Global.System.Drawing.Point(548, 51)
			Me.txtID.Name = "txtID"
			Me.txtID.Size = New Global.System.Drawing.Size(30, 21)
			Me.txtID.TabIndex = 15
			Me.txtID.TabStop = False
			Me.txtID.Visible = False
			Me.chkIsActive.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.chkIsActive.AutoSize = True
			Me.chkIsActive.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.chkIsActive.Location = New Global.System.Drawing.Point(214, 51)
			Me.chkIsActive.Name = "chkIsActive"
			Me.chkIsActive.Size = New Global.System.Drawing.Size(76, 19)
			Me.chkIsActive.TabIndex = 6
			Me.chkIsActive.Text = "Is Active"
			Me.chkIsActive.UseVisualStyleBackColor = True
			Me.btnAdd.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnAdd.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnAdd.Location = New Global.System.Drawing.Point(128, 302)
			Me.btnAdd.Name = "btnAdd"
			Me.btnAdd.Size = New Global.System.Drawing.Size(88, 27)
			Me.btnAdd.TabIndex = 21
			Me.btnAdd.Text = "&Add"
			Me.btnAdd.UseVisualStyleBackColor = True
			Me.btnSave.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnSave.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnSave.Location = New Global.System.Drawing.Point(307, 302)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New Global.System.Drawing.Size(88, 27)
			Me.btnSave.TabIndex = 23
			Me.btnSave.Text = "&Save"
			Me.btnSave.UseVisualStyleBackColor = True
			Me.skip_Label12.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.skip_Label12.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.skip_Label12.ForeColor = Global.System.Drawing.Color.Red
			Me.skip_Label12.Location = New Global.System.Drawing.Point(112, 28)
			Me.skip_Label12.Name = "skip_Label12"
			Me.skip_Label12.Size = New Global.System.Drawing.Size(10, 13)
			Me.skip_Label12.TabIndex = 24
			Me.skip_Label12.Text = "*"
			Me.skip_Label12.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.btnClear.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnClear.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClear.Location = New Global.System.Drawing.Point(397, 302)
			Me.btnClear.Name = "btnClear"
			Me.btnClear.Size = New Global.System.Drawing.Size(88, 27)
			Me.btnClear.TabIndex = 24
			Me.btnClear.Text = "&Clear"
			Me.btnClear.UseVisualStyleBackColor = True
			Me.btnEdit.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnEdit.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnEdit.Location = New Global.System.Drawing.Point(217, 302)
			Me.btnEdit.Name = "btnEdit"
			Me.btnEdit.Size = New Global.System.Drawing.Size(88, 27)
			Me.btnEdit.TabIndex = 22
			Me.btnEdit.Text = "&Modify"
			Me.btnEdit.UseVisualStyleBackColor = True
			Me.btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnClose.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClose.Location = New Global.System.Drawing.Point(487, 302)
			Me.btnClose.Name = "btnClose"
			Me.btnClose.Size = New Global.System.Drawing.Size(88, 27)
			Me.btnClose.TabIndex = 25
			Me.btnClose.Text = "C&lose"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.tab_lblDetails.BackColor = Global.System.Drawing.Color.Black
			Me.tab_lblDetails.ForeColor = Global.System.Drawing.Color.PaleGreen
			Me.tab_lblDetails.Location = New Global.System.Drawing.Point(0, 0)
			Me.tab_lblDetails.Name = "tab_lblDetails"
			Me.tab_lblDetails.Size = New Global.System.Drawing.Size(852, 3)
			Me.tab_lblDetails.TabIndex = 32
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
			Me.tpList.Size = New Global.System.Drawing.Size(850, 409)
			Me.tpList.TabIndex = 1
			Me.tpList.Text = "                              List                              "
			Me.tpList.UseVisualStyleBackColor = True
			Me.tab_lblList.BackColor = Global.System.Drawing.Color.Black
			Me.tab_lblList.ForeColor = Global.System.Drawing.Color.PaleGreen
			Me.tab_lblList.Location = New Global.System.Drawing.Point(0, 0)
			Me.tab_lblList.Name = "tab_lblList"
			Me.tab_lblList.Size = New Global.System.Drawing.Size(853, 3)
			Me.tab_lblList.TabIndex = 7
			Me.GbBasic.BackColor = Global.System.Drawing.Color.White
			Me.GbBasic.Controls.Add(Me.txtSUserGroup)
			Me.GbBasic.Controls.Add(Me.Label7)
			Me.GbBasic.Controls.Add(Me.cmbStatus)
			Me.GbBasic.Controls.Add(Me.Label11)
			Me.GbBasic.Controls.Add(Me.arrow_btnBasicExp_sml)
			Me.GbBasic.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.GbBasic.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GbBasic.Location = New Global.System.Drawing.Point(3, 3)
			Me.GbBasic.Name = "GbBasic"
			Me.GbBasic.Size = New Global.System.Drawing.Size(844, 90)
			Me.GbBasic.TabIndex = 476
			Me.GbBasic.TabStop = False
			Me.GbBasic.Text = "     Basic Search "
			Me.txtSUserGroup.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtSUserGroup.Location = New Global.System.Drawing.Point(151, 27)
			Me.txtSUserGroup.Name = "txtSUserGroup"
			Me.txtSUserGroup.Size = New Global.System.Drawing.Size(479, 21)
			Me.txtSUserGroup.TabIndex = 42
			Me.Label7.AutoSize = True
			Me.Label7.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label7.Location = New Global.System.Drawing.Point(12, 30)
			Me.Label7.Name = "Label7"
			Me.Label7.Size = New Global.System.Drawing.Size(72, 15)
			Me.Label7.TabIndex = 45
			Me.Label7.Text = "User Group"
			Me.Label7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.cmbStatus.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbStatus.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.cmbStatus.FormattingEnabled = True
			Me.cmbStatus.Items.AddRange(New Object() { "", "Active", "In Active" })
			Me.cmbStatus.Location = New Global.System.Drawing.Point(151, 53)
			Me.cmbStatus.Name = "cmbStatus"
			Me.cmbStatus.Size = New Global.System.Drawing.Size(479, 23)
			Me.cmbStatus.TabIndex = 43
			Me.Label11.AutoSize = True
			Me.Label11.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label11.Location = New Global.System.Drawing.Point(12, 56)
			Me.Label11.Name = "Label11"
			Me.Label11.Size = New Global.System.Drawing.Size(43, 15)
			Me.Label11.TabIndex = 44
			Me.Label11.Text = "Status"
			Me.arrow_btnBasicExp_sml.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.arrow_btnBasicExp_sml.FlatAppearance.BorderSize = 0
			Me.arrow_btnBasicExp_sml.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.arrow_btnBasicExp_sml.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.arrow_btnBasicExp_sml.Location = New Global.System.Drawing.Point(8, -1)
			Me.arrow_btnBasicExp_sml.Name = "arrow_btnBasicExp_sml"
			Me.arrow_btnBasicExp_sml.Size = New Global.System.Drawing.Size(20, 20)
			Me.arrow_btnBasicExp_sml.TabIndex = 4
			Me.arrow_btnBasicExp_sml.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.arrow_btnBasicExp_sml.UseVisualStyleBackColor = True
			Me.GbAdvanced.Controls.Add(Me.txtSCreated)
			Me.GbAdvanced.Controls.Add(Me.lblSCreated)
			Me.GbAdvanced.Controls.Add(Me.dtpFrom)
			Me.GbAdvanced.Controls.Add(Me.dtpTo)
			Me.GbAdvanced.Controls.Add(Me.Label16)
			Me.GbAdvanced.Controls.Add(Me.lblSDate)
			Me.GbAdvanced.Controls.Add(Me.arrow_btnAdvanceExp_sml)
			Me.GbAdvanced.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.GbAdvanced.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GbAdvanced.Location = New Global.System.Drawing.Point(3, 93)
			Me.GbAdvanced.Name = "GbAdvanced"
			Me.GbAdvanced.Size = New Global.System.Drawing.Size(844, 91)
			Me.GbAdvanced.TabIndex = 477
			Me.GbAdvanced.TabStop = False
			Me.GbAdvanced.Text = "     Advanced Search "
			Me.txtSCreated.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtSCreated.Location = New Global.System.Drawing.Point(151, 55)
			Me.txtSCreated.Name = "txtSCreated"
			Me.txtSCreated.Size = New Global.System.Drawing.Size(479, 21)
			Me.txtSCreated.TabIndex = 482
			Me.lblSCreated.AutoCompleteMode = Global.System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.lblSCreated.AutoCompleteSource = Global.System.Windows.Forms.AutoCompleteSource.ListItems
			Me.lblSCreated.BackColor = Global.System.Drawing.Color.White
			Me.lblSCreated.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.lblSCreated.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.lblSCreated.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblSCreated.FormattingEnabled = True
			Me.lblSCreated.Items.AddRange(New Object() { "Created By", "Last Modified By" })
			Me.lblSCreated.Location = New Global.System.Drawing.Point(15, 54)
			Me.lblSCreated.Name = "lblSCreated"
			Me.lblSCreated.Size = New Global.System.Drawing.Size(130, 23)
			Me.lblSCreated.TabIndex = 481
			Me.dtpFrom.CustomFormat = "dd MMM yyyy  00:00"
			Me.dtpFrom.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpFrom.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpFrom.Location = New Global.System.Drawing.Point(151, 29)
			Me.dtpFrom.Name = "dtpFrom"
			Me.dtpFrom.ShowCheckBox = True
			Me.dtpFrom.Size = New Global.System.Drawing.Size(222, 21)
			Me.dtpFrom.TabIndex = 478
			Me.dtpTo.CustomFormat = "dd MMM yyyy  23:59"
			Me.dtpTo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dtpTo.Format = Global.System.Windows.Forms.DateTimePickerFormat.Custom
			Me.dtpTo.Location = New Global.System.Drawing.Point(408, 29)
			Me.dtpTo.Name = "dtpTo"
			Me.dtpTo.ShowCheckBox = True
			Me.dtpTo.Size = New Global.System.Drawing.Size(222, 21)
			Me.dtpTo.TabIndex = 476
			Me.Label16.AutoSize = True
			Me.Label16.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label16.Location = New Global.System.Drawing.Point(376, 31)
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
			Me.lblSDate.Location = New Global.System.Drawing.Point(15, 28)
			Me.lblSDate.Name = "lblSDate"
			Me.lblSDate.Size = New Global.System.Drawing.Size(130, 23)
			Me.lblSDate.TabIndex = 475
			Me.arrow_btnAdvanceExp_sml.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.arrow_btnAdvanceExp_sml.FlatAppearance.BorderSize = 0
			Me.arrow_btnAdvanceExp_sml.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.arrow_btnAdvanceExp_sml.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.arrow_btnAdvanceExp_sml.ForeColor = Global.System.Drawing.Color.White
			Me.arrow_btnAdvanceExp_sml.Location = New Global.System.Drawing.Point(8, -1)
			Me.arrow_btnAdvanceExp_sml.Name = "arrow_btnAdvanceExp_sml"
			Me.arrow_btnAdvanceExp_sml.Size = New Global.System.Drawing.Size(20, 20)
			Me.arrow_btnAdvanceExp_sml.TabIndex = 4
			Me.arrow_btnAdvanceExp_sml.UseVisualStyleBackColor = True
			Me.grpListButton.Controls.Add(Me.FlowLayoutPanel1)
			Me.grpListButton.Controls.Add(Me.lblRows)
			Me.grpListButton.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.grpListButton.Location = New Global.System.Drawing.Point(3, 184)
			Me.grpListButton.Name = "grpListButton"
			Me.grpListButton.Size = New Global.System.Drawing.Size(844, 49)
			Me.grpListButton.TabIndex = 481
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
			Me.lblRows.Location = New Global.System.Drawing.Point(728, 21)
			Me.lblRows.Name = "lblRows"
			Me.lblRows.Size = New Global.System.Drawing.Size(108, 15)
			Me.lblRows.TabIndex = 483
			Me.lblRows.Text = "0 - Rows"
			Me.lblRows.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.dgvList.AllowUserToAddRows = False
			Me.dgvList.AllowUserToDeleteRows = False
			Me.dgvList.BackgroundColor = Global.System.Drawing.Color.WhiteSmoke
			dataGridViewCellStyle3.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle3.BackColor = Global.System.Drawing.Color.AliceBlue
			dataGridViewCellStyle3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle3.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle3.SelectionBackColor = Global.System.Drawing.SystemColors.Highlight
			dataGridViewCellStyle3.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle3.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3
			Me.dgvList.ColumnHeadersHeight = 25
			Me.dgvList.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.dgvList.Location = New Global.System.Drawing.Point(3, 233)
			Me.dgvList.Name = "dgvList"
			Me.dgvList.[ReadOnly] = True
			dataGridViewCellStyle4.Alignment = Global.System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
			dataGridViewCellStyle4.BackColor = Global.System.Drawing.Color.AliceBlue
			dataGridViewCellStyle4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			dataGridViewCellStyle4.ForeColor = Global.System.Drawing.SystemColors.WindowText
			dataGridViewCellStyle4.SelectionBackColor = Global.System.Drawing.Color.PowderBlue
			dataGridViewCellStyle4.SelectionForeColor = Global.System.Drawing.SystemColors.HighlightText
			dataGridViewCellStyle4.WrapMode = Global.System.Windows.Forms.DataGridViewTriState.[True]
			Me.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
			Me.dgvList.RowHeadersWidth = 25
			dataGridViewCellStyle5.SelectionBackColor = Global.System.Drawing.Color.PowderBlue
			dataGridViewCellStyle5.SelectionForeColor = Global.System.Drawing.Color.Black
			Me.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle5
			Me.dgvList.RowTemplate.DefaultCellStyle.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dgvList.Size = New Global.System.Drawing.Size(844, 173)
			Me.dgvList.TabIndex = 485
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.None
			Me.BackColor = Global.System.Drawing.Color.White
			MyBase.ClientSize = New Global.System.Drawing.Size(858, 438)
			MyBase.Controls.Add(Me.theme_tc)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 7.8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.Name = "UserGroup"
			Me.Text = "User Group"
			Me.theme_tc.ResumeLayout(False)
			Me.tpDetails.ResumeLayout(False)
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.GroupBox1.ResumeLayout(False)
			Me.PnlMasters.ResumeLayout(False)
			Me.PnlMasters.PerformLayout()
			CType(Me.skip_dgv1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox2.ResumeLayout(False)
			Me.PnlAccessCtrl.ResumeLayout(False)
			Me.PnlAccessCtrl.PerformLayout()
			CType(Me.skip_dgv2, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.tpList.ResumeLayout(False)
			Me.GbBasic.ResumeLayout(False)
			Me.GbBasic.PerformLayout()
			Me.GbAdvanced.ResumeLayout(False)
			Me.GbAdvanced.PerformLayout()
			Me.grpListButton.ResumeLayout(False)
			Me.FlowLayoutPanel1.ResumeLayout(False)
			CType(Me.dgvList, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000224 RID: 548
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
