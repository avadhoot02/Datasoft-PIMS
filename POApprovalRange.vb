Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports WeifenLuo.WinFormsUI.Docking

Namespace Datasoft_PIMS
	' Token: 0x0200004D RID: 77
	<DesignerGenerated()>
	Public Partial Class POApprovalRange
		Inherits DockContent

		' Token: 0x06000DC1 RID: 3521 RVA: 0x0007C328 File Offset: 0x0007A528
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.dtUser = New DataTable()
			Me.dtLevels = New DataTable()
			Me.dtLevelsID = New DataTable()
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700052A RID: 1322
		' (get) Token: 0x06000DC4 RID: 3524 RVA: 0x0007D8DB File Offset: 0x0007BADB
		' (set) Token: 0x06000DC5 RID: 3525 RVA: 0x0007D8E8 File Offset: 0x0007BAE8
		Friend Overridable Property btnSave As Button
			<CompilerGenerated()>
			Get
				Return Me._btnSave
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnSave_Click
				Dim button As Button = Me._btnSave
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnSave = value
				button = Me._btnSave
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700052B RID: 1323
		' (get) Token: 0x06000DC6 RID: 3526 RVA: 0x0007D92B File Offset: 0x0007BB2B
		' (set) Token: 0x06000DC7 RID: 3527 RVA: 0x0007D938 File Offset: 0x0007BB38
		Friend Overridable Property btnClose As Button
			<CompilerGenerated()>
			Get
				Return Me._btnClose
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnClose_Click
				Dim button As Button = Me._btnClose
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnClose = value
				button = Me._btnClose
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700052C RID: 1324
		' (get) Token: 0x06000DC8 RID: 3528 RVA: 0x0007D97B File Offset: 0x0007BB7B
		' (set) Token: 0x06000DC9 RID: 3529 RVA: 0x0007D988 File Offset: 0x0007BB88
		Friend Overridable Property dgvList As DataGridView
			<CompilerGenerated()>
			Get
				Return Me._dgvList
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim dataGridViewCellEventHandler As DataGridViewCellEventHandler = AddressOf Me.dgvList_CellClick
				Dim dataGridView As DataGridView = Me._dgvList
				If dataGridView IsNot Nothing Then
					RemoveHandler dataGridView.CellClick, dataGridViewCellEventHandler
				End If
				Me._dgvList = value
				dataGridView = Me._dgvList
				If dataGridView IsNot Nothing Then
					AddHandler dataGridView.CellClick, dataGridViewCellEventHandler
				End If
			End Set
		End Property

		' Token: 0x1700052D RID: 1325
		' (get) Token: 0x06000DCA RID: 3530 RVA: 0x0007D9CB File Offset: 0x0007BBCB
		' (set) Token: 0x06000DCB RID: 3531 RVA: 0x0007D9D8 File Offset: 0x0007BBD8
		Friend Overridable Property btnClear As Button
			<CompilerGenerated()>
			Get
				Return Me._btnClear
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnClear_Click
				Dim button As Button = Me._btnClear
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnClear = value
				button = Me._btnClear
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700052E RID: 1326
		' (get) Token: 0x06000DCC RID: 3532 RVA: 0x0007DA1B File Offset: 0x0007BC1B
		' (set) Token: 0x06000DCD RID: 3533 RVA: 0x0007DA25 File Offset: 0x0007BC25
		Friend Overridable Property txtPOApprovalID As TextBox

		' Token: 0x1700052F RID: 1327
		' (get) Token: 0x06000DCE RID: 3534 RVA: 0x0007DA2E File Offset: 0x0007BC2E
		' (set) Token: 0x06000DCF RID: 3535 RVA: 0x0007DA38 File Offset: 0x0007BC38
		Friend Overridable Property sml_btnAdd As Button
			<CompilerGenerated()>
			Get
				Return Me._sml_btnAdd
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.sml_btnAdd_Click
				Dim button As Button = Me._sml_btnAdd
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._sml_btnAdd = value
				button = Me._sml_btnAdd
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000530 RID: 1328
		' (get) Token: 0x06000DD0 RID: 3536 RVA: 0x0007DA7B File Offset: 0x0007BC7B
		' (set) Token: 0x06000DD1 RID: 3537 RVA: 0x0007DA85 File Offset: 0x0007BC85
		Friend Overridable Property Label3 As Label

		' Token: 0x17000531 RID: 1329
		' (get) Token: 0x06000DD2 RID: 3538 RVA: 0x0007DA8E File Offset: 0x0007BC8E
		' (set) Token: 0x06000DD3 RID: 3539 RVA: 0x0007DA98 File Offset: 0x0007BC98
		Friend Overridable Property Label2 As Label

		' Token: 0x17000532 RID: 1330
		' (get) Token: 0x06000DD4 RID: 3540 RVA: 0x0007DAA1 File Offset: 0x0007BCA1
		' (set) Token: 0x06000DD5 RID: 3541 RVA: 0x0007DAAB File Offset: 0x0007BCAB
		Friend Overridable Property GroupBox2 As GroupBox

		' Token: 0x17000533 RID: 1331
		' (get) Token: 0x06000DD6 RID: 3542 RVA: 0x0007DAB4 File Offset: 0x0007BCB4
		' (set) Token: 0x06000DD7 RID: 3543 RVA: 0x0007DABE File Offset: 0x0007BCBE
		Friend Overridable Property Panel2 As Panel

		' Token: 0x17000534 RID: 1332
		' (get) Token: 0x06000DD8 RID: 3544 RVA: 0x0007DAC7 File Offset: 0x0007BCC7
		' (set) Token: 0x06000DD9 RID: 3545 RVA: 0x0007DAD4 File Offset: 0x0007BCD4
		Friend Overridable Property dgvLevel As DataGridView
			<CompilerGenerated()>
			Get
				Return Me._dgvLevel
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim dataGridViewCellEventHandler As DataGridViewCellEventHandler = AddressOf Me.dgvLevel_CellClick
				Dim dataGridView As DataGridView = Me._dgvLevel
				If dataGridView IsNot Nothing Then
					RemoveHandler dataGridView.CellClick, dataGridViewCellEventHandler
				End If
				Me._dgvLevel = value
				dataGridView = Me._dgvLevel
				If dataGridView IsNot Nothing Then
					AddHandler dataGridView.CellClick, dataGridViewCellEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000535 RID: 1333
		' (get) Token: 0x06000DDA RID: 3546 RVA: 0x0007DB17 File Offset: 0x0007BD17
		' (set) Token: 0x06000DDB RID: 3547 RVA: 0x0007DB21 File Offset: 0x0007BD21
		Friend Overridable Property GroupBox3 As GroupBox

		' Token: 0x17000536 RID: 1334
		' (get) Token: 0x06000DDC RID: 3548 RVA: 0x0007DB2A File Offset: 0x0007BD2A
		' (set) Token: 0x06000DDD RID: 3549 RVA: 0x0007DB34 File Offset: 0x0007BD34
		Friend Overridable Property txtEmail As TextBox

		' Token: 0x17000537 RID: 1335
		' (get) Token: 0x06000DDE RID: 3550 RVA: 0x0007DB3D File Offset: 0x0007BD3D
		' (set) Token: 0x06000DDF RID: 3551 RVA: 0x0007DB48 File Offset: 0x0007BD48
		Friend Overridable Property cmbUser As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbUser
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbUser_Validated
				Dim comboBox As ComboBox = Me._cmbUser
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.Validated, eventHandler
				End If
				Me._cmbUser = value
				comboBox = Me._cmbUser
				If comboBox IsNot Nothing Then
					AddHandler comboBox.Validated, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000538 RID: 1336
		' (get) Token: 0x06000DE0 RID: 3552 RVA: 0x0007DB8B File Offset: 0x0007BD8B
		' (set) Token: 0x06000DE1 RID: 3553 RVA: 0x0007DB95 File Offset: 0x0007BD95
		Friend Overridable Property txtLevel As TextBox

		' Token: 0x17000539 RID: 1337
		' (get) Token: 0x06000DE2 RID: 3554 RVA: 0x0007DB9E File Offset: 0x0007BD9E
		' (set) Token: 0x06000DE3 RID: 3555 RVA: 0x0007DBA8 File Offset: 0x0007BDA8
		Friend Overridable Property Label1 As Label

		' Token: 0x1700053A RID: 1338
		' (get) Token: 0x06000DE4 RID: 3556 RVA: 0x0007DBB1 File Offset: 0x0007BDB1
		' (set) Token: 0x06000DE5 RID: 3557 RVA: 0x0007DBBB File Offset: 0x0007BDBB
		Friend Overridable Property lblRows As Label

		' Token: 0x1700053B RID: 1339
		' (get) Token: 0x06000DE6 RID: 3558 RVA: 0x0007DBC4 File Offset: 0x0007BDC4
		' (set) Token: 0x06000DE7 RID: 3559 RVA: 0x0007DBCE File Offset: 0x0007BDCE
		Friend Overridable Property Panel1 As Panel

		' Token: 0x1700053C RID: 1340
		' (get) Token: 0x06000DE8 RID: 3560 RVA: 0x0007DBD7 File Offset: 0x0007BDD7
		' (set) Token: 0x06000DE9 RID: 3561 RVA: 0x0007DBE1 File Offset: 0x0007BDE1
		Friend Overridable Property POApprovalID As DataGridViewTextBoxColumn

		' Token: 0x1700053D RID: 1341
		' (get) Token: 0x06000DEA RID: 3562 RVA: 0x0007DBEA File Offset: 0x0007BDEA
		' (set) Token: 0x06000DEB RID: 3563 RVA: 0x0007DBF4 File Offset: 0x0007BDF4
		Friend Overridable Property ApprovalLevel As DataGridViewTextBoxColumn

		' Token: 0x1700053E RID: 1342
		' (get) Token: 0x06000DEC RID: 3564 RVA: 0x0007DBFD File Offset: 0x0007BDFD
		' (set) Token: 0x06000DED RID: 3565 RVA: 0x0007DC07 File Offset: 0x0007BE07
		Friend Overridable Property Sym1 As DataGridViewTextBoxColumn

		' Token: 0x1700053F RID: 1343
		' (get) Token: 0x06000DEE RID: 3566 RVA: 0x0007DC10 File Offset: 0x0007BE10
		' (set) Token: 0x06000DEF RID: 3567 RVA: 0x0007DC1A File Offset: 0x0007BE1A
		Friend Overridable Property FromAmt As DataGridViewTextBoxColumn

		' Token: 0x17000540 RID: 1344
		' (get) Token: 0x06000DF0 RID: 3568 RVA: 0x0007DC23 File Offset: 0x0007BE23
		' (set) Token: 0x06000DF1 RID: 3569 RVA: 0x0007DC2D File Offset: 0x0007BE2D
		Friend Overridable Property Sym2 As DataGridViewTextBoxColumn

		' Token: 0x17000541 RID: 1345
		' (get) Token: 0x06000DF2 RID: 3570 RVA: 0x0007DC36 File Offset: 0x0007BE36
		' (set) Token: 0x06000DF3 RID: 3571 RVA: 0x0007DC40 File Offset: 0x0007BE40
		Friend Overridable Property ToAmt As DataGridViewTextBoxColumn

		' Token: 0x17000542 RID: 1346
		' (get) Token: 0x06000DF4 RID: 3572 RVA: 0x0007DC49 File Offset: 0x0007BE49
		' (set) Token: 0x06000DF5 RID: 3573 RVA: 0x0007DC53 File Offset: 0x0007BE53
		Friend Overridable Property imgFill As DataGridViewImageColumn

		' Token: 0x17000543 RID: 1347
		' (get) Token: 0x06000DF6 RID: 3574 RVA: 0x0007DC5C File Offset: 0x0007BE5C
		' (set) Token: 0x06000DF7 RID: 3575 RVA: 0x0007DC66 File Offset: 0x0007BE66
		Friend Overridable Property btnDelete_ID As DataGridViewImageColumn

		' Token: 0x17000544 RID: 1348
		' (get) Token: 0x06000DF8 RID: 3576 RVA: 0x0007DC6F File Offset: 0x0007BE6F
		' (set) Token: 0x06000DF9 RID: 3577 RVA: 0x0007DC79 File Offset: 0x0007BE79
		Friend Overridable Property lstPOApprovalID As DataGridViewTextBoxColumn

		' Token: 0x17000545 RID: 1349
		' (get) Token: 0x06000DFA RID: 3578 RVA: 0x0007DC82 File Offset: 0x0007BE82
		' (set) Token: 0x06000DFB RID: 3579 RVA: 0x0007DC8C File Offset: 0x0007BE8C
		Friend Overridable Property ApproverID As DataGridViewTextBoxColumn

		' Token: 0x17000546 RID: 1350
		' (get) Token: 0x06000DFC RID: 3580 RVA: 0x0007DC95 File Offset: 0x0007BE95
		' (set) Token: 0x06000DFD RID: 3581 RVA: 0x0007DC9F File Offset: 0x0007BE9F
		Friend Overridable Property UserName As DataGridViewTextBoxColumn

		' Token: 0x17000547 RID: 1351
		' (get) Token: 0x06000DFE RID: 3582 RVA: 0x0007DCA8 File Offset: 0x0007BEA8
		' (set) Token: 0x06000DFF RID: 3583 RVA: 0x0007DCB2 File Offset: 0x0007BEB2
		Friend Overridable Property EmailID As DataGridViewTextBoxColumn

		' Token: 0x06000E00 RID: 3584 RVA: 0x0007DCBB File Offset: 0x0007BEBB
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Designing.SetTheme(Me)
			Me.FillCombo()
			Me.SetLevel()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x06000E01 RID: 3585 RVA: 0x0007DCEC File Offset: 0x0007BEEC
		Private Sub FillCombo()
			Dim text As String = "SELECT UserID, UserName, LoginID, EmailID FROM [User] WHERE (IsActive = 1) ORDER BY UserName"
			Me.dtUser = MainModule.GetData(text)
			Me.cmbUser.ValueMember = "UserID"
			Me.cmbUser.DisplayMember = "LoginID"
			Me.cmbUser.DataSource = Me.dtUser
			Me.cmbUser.SelectedIndex = -1
		End Sub

		' Token: 0x06000E02 RID: 3586 RVA: 0x0007DD50 File Offset: 0x0007BF50
		Private Sub SetLevel()
			Dim text As String = " SELECT POApprovalID, ApprovalLevel, '>' Sym1, FromAmt, '<=' Sym2,ToAmt" & vbCrLf
			text += " FROM POApproval" & vbCrLf
			Me.dtLevels = MainModule.GetData(text)
			text = " SELECT POApprovalID, ApproverID, A.UserName, A.EmailID" & vbCrLf
			text += " FROM POApprovalDtls PD " & vbCrLf
			text += " INNER JOIN [User] A ON PD.ApproverID = A.UserID" & vbCrLf
			Me.dtLevelsID = MainModule.GetData(text)
			Dim dataColumn As DataColumn = New DataColumn("imgFill", GetType(Byte()))
			dataColumn.DefaultValue = MainModule.ImageToBytes(ResourceModule.imgBlank)
			Me.dtLevels.Columns.Add(dataColumn)
			Me.dtLevels.Rows(Me.dtLevels.Rows.Count - 1)("Sym2") = ""
			Me.dgvLevel.DataSource = Me.dtLevels
		End Sub

		' Token: 0x06000E03 RID: 3587 RVA: 0x0007DE24 File Offset: 0x0007C024
		Private Sub ClearForm()
			Me.txtPOApprovalID.Text = ""
			Me.txtLevel.Text = ""
			Me.cmbUser.SelectedIndex = -1
			Me.txtEmail.Text = ""
			Me.FillLevelList("0")
			Me.SetGridFill(-1)
		End Sub

		' Token: 0x06000E04 RID: 3588 RVA: 0x0007DE86 File Offset: 0x0007C086
		Private Sub btnClear_Click(sender As Object, e As EventArgs)
			Me.ClearForm()
		End Sub

		' Token: 0x06000E05 RID: 3589 RVA: 0x0007DE90 File Offset: 0x0007C090
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06000E06 RID: 3590 RVA: 0x0007DE9C File Offset: 0x0007C09C
		Private Sub dgvLevel_CellClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = e.RowIndex > -1
			If flag Then
				Dim name As String = Me.dgvLevel.Columns(e.ColumnIndex).Name
				If Operators.CompareString(name, "imgFill", False) = 0 Then
					Me.SetGridFill(e.RowIndex)
					Me.txtLevel.Text = Conversions.ToString(Me.dgvLevel.Rows(e.RowIndex).Cells("ApprovalLevel").Value)
					Me.txtPOApprovalID.Text = Conversions.ToString(Me.dgvLevel.Rows(e.RowIndex).Cells("POApprovalID").Value)
					Me.FillLevelList(Conversions.ToString(Me.dgvLevel.Rows(e.RowIndex).Cells("POApprovalID").Value))
				End If
			End If
		End Sub

		' Token: 0x06000E07 RID: 3591 RVA: 0x0007DFAC File Offset: 0x0007C1AC
		Private Sub SetGridFill(iRow As Integer)
			Dim dataTable As DataTable = CType(Me.dgvLevel.DataSource, DataTable)
			Dim num As Integer = dataTable.Rows.Count - 1
			For i As Integer = 0 To num
				Dim flag As Boolean = i = iRow
				If flag Then
					dataTable.Rows(i)("imgFill") = MainModule.ImageToBytes(ResourceModule.imgRightArrow)
				Else
					dataTable.Rows(i)("imgFill") = MainModule.ImageToBytes(ResourceModule.imgBlank)
				End If
			Next
			Me.dgvLevel.DataSource = dataTable
		End Sub

		' Token: 0x06000E08 RID: 3592 RVA: 0x0007E044 File Offset: 0x0007C244
		Private Sub FillLevelList(sPOApprovalID As String)
			Dim dataView As DataView = New DataView(Me.dtLevelsID, "POApprovalID = '" + sPOApprovalID + "'", "UserName", DataViewRowState.CurrentRows)
			Dim dataTable As DataTable = dataView.ToTable()
			Me.lblRows.Text = Conversions.ToString(dataTable.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = dataTable
		End Sub

		' Token: 0x06000E09 RID: 3593 RVA: 0x0007E0B0 File Offset: 0x0007C2B0
		Private Sub cmbUser_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbUser.SelectedIndex > -1
			If flag Then
				Dim dataRow As DataRow = Me.dtUser.[Select]("UserID = '" + Me.cmbUser.SelectedValue.ToString() + "'")(0)
				Me.txtEmail.Text = dataRow("EmailID").ToString()
			Else
				Me.cmbUser.Text = ""
				Me.txtEmail.Text = ""
			End If
		End Sub

		' Token: 0x06000E0A RID: 3594 RVA: 0x0007E140 File Offset: 0x0007C340
		Private Function ValidateAdd() As Boolean
			Dim flag As Boolean = Operators.CompareString(Me.txtPOApprovalID.Text, "", False) = 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Select Approval Level.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.txtPOApprovalID.Focus()
				flag2 = False
			Else
				Dim flag3 As Boolean = Me.cmbUser.SelectedIndex = -1
				If flag3 Then
					CustomMsgBox.Show("Select Approver.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.cmbUser.Focus()
					flag2 = False
				Else
					Dim flag4 As Boolean = Operators.CompareString(Me.txtEmail.Text, "", False) = 0
					If flag4 Then
						CustomMsgBox.Show("No Email ID For Approver.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.txtEmail.Focus()
						flag2 = False
					Else
						Dim flag5 As Boolean = Me.dtLevelsID.[Select](String.Concat(New String() { "POApprovalID = '", Me.txtPOApprovalID.Text, "' AND ApproverID = '", Me.cmbUser.SelectedValue.ToString(), "'" })).Length > 0
						If flag5 Then
							CustomMsgBox.Show("Approver Already In The List.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.cmbUser.Focus()
							flag2 = False
						Else
							flag2 = True
						End If
					End If
				End If
			End If
			Return flag2
		End Function

		' Token: 0x06000E0B RID: 3595 RVA: 0x0007E294 File Offset: 0x0007C494
		Private Sub sml_btnAdd_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Not Me.ValidateAdd()
				If Not flag Then
					Me.AddApprover()
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06000E0C RID: 3596 RVA: 0x0007E2FC File Offset: 0x0007C4FC
		Private Sub AddApprover()
			Me.dtLevelsID.Rows.Add(New Object(-1) {})
			Me.dtLevelsID.Rows(Me.dtLevelsID.Rows.Count - 1)("POApprovalID") = Me.txtPOApprovalID.Text
			Me.dtLevelsID.Rows(Me.dtLevelsID.Rows.Count - 1)("ApproverID") = RuntimeHelpers.GetObjectValue(Me.cmbUser.SelectedValue)
			Me.dtLevelsID.Rows(Me.dtLevelsID.Rows.Count - 1)("UserName") = Me.cmbUser.Text
			Me.dtLevelsID.Rows(Me.dtLevelsID.Rows.Count - 1)("EmailID") = Me.txtEmail.Text
			Me.FillLevelList(Me.txtPOApprovalID.Text)
			Me.cmbUser.SelectedIndex = -1
			Me.txtEmail.Text = ""
		End Sub

		' Token: 0x06000E0D RID: 3597 RVA: 0x0007E438 File Offset: 0x0007C638
		Private Sub dgvList_CellClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = e.RowIndex > -1
			If flag Then
				Dim text As String = Me.dgvList.Columns(e.ColumnIndex).Name.ToString()
				If Operators.CompareString(text, "btnDelete_ID", False) = 0 Then
					Dim text2 As String = Conversions.ToString(Me.dgvList.Rows(e.RowIndex).Cells("lstPOApprovalID").Value)
					Dim text3 As String = Conversions.ToString(Me.dgvList.Rows(e.RowIndex).Cells("ApproverID").Value)
					Dim dataRow As DataRow = Me.dtLevelsID.[Select](String.Concat(New String() { "POApprovalID = '", text2, "' AND ApproverID = '", text3, "'" }))(0)
					Me.dtLevelsID.Rows.Remove(dataRow)
					Me.dtLevelsID.AcceptChanges()
					Me.FillLevelList(text2)
				End If
			End If
		End Sub

		' Token: 0x06000E0E RID: 3598 RVA: 0x0007E552 File Offset: 0x0007C752
		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			Me.SaveData()
		End Sub

		' Token: 0x06000E0F RID: 3599 RVA: 0x0007E55C File Offset: 0x0007C75C
		Private Sub SaveData()
			Dim sqlConnection As SqlConnection = New SqlConnection(GlobalVariables.gsConStr)
			sqlConnection.Open()
			Dim sqlTransaction As SqlTransaction = sqlConnection.BeginTransaction(IsolationLevel.Serializable)
			Try
				Me.InsertID(sqlConnection, sqlTransaction)
				sqlTransaction.Commit()
				sqlConnection.Close()
				Dim text As String = ""
				Dim num As Integer = Me.dtLevels.Rows.Count - 1
				For i As Integer = 0 To num
					Dim dataView As DataView = New DataView(Me.dtLevelsID, Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("POApprovalID = '", Me.dtLevels.Rows(i)("POApprovalID")), "'")), "", DataViewRowState.CurrentRows)
					Dim enumerableRowCollection As EnumerableRowCollection(Of DataRow) = dataView.ToTable().AsEnumerable()
					Dim func As Func(Of DataRow, String)
					If POApprovalRange._Closure$__.$I142-0 IsNot Nothing Then
						func = POApprovalRange._Closure$__.$I142-0
					Else
						Dim func2 As Func(Of DataRow, String) = Function(x As DataRow) x.Field("EmailID")
						func = func2
						POApprovalRange._Closure$__.$I142-0 = func2
					End If
					Dim array As String() = enumerableRowCollection.[Select](func).ToArray()
					Dim text2 As String = String.Join(", ", array)
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Me.dtLevels.Rows(i)("ApprovalLevel"), ": "), text2), vbCrLf)))
				Next
				MainModule.TrnLog(Me.Text, "PO Approver List Updated", text, Nothing)
				CustomMsgBox.Show("Saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Catch ex As Exception
				sqlTransaction.Rollback()
				sqlConnection.Close()
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06000E10 RID: 3600 RVA: 0x0007E728 File Offset: 0x0007C928
		Private Function InsertID(oCon As SqlConnection, oTrn As SqlTransaction) As Boolean
			Dim text As String = "DELETE FROM POApprovalDtls"
			Dim flag As Boolean = MainModule.ExecuteSQL(text, oCon, oTrn) = 1
			Dim flag2 As Boolean
			If flag Then
				Dim dataTable As DataTable = Me.dtLevelsID.Copy()
				dataTable.Columns.Remove("UserName")
				dataTable.Columns.Remove("EmailID")
				MainModule.BulkInsertTemp(dataTable, "POApprovalDtls", oCon, oTrn)
				flag2 = True
			Else
				flag2 = False
			End If
			Return flag2
		End Function

		' Token: 0x040005CC RID: 1484
		Private dtUser As DataTable

		' Token: 0x040005CD RID: 1485
		Private dtLevels As DataTable

		' Token: 0x040005CE RID: 1486
		Private dtLevelsID As DataTable
	End Class
End Namespace
