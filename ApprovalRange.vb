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
	' Token: 0x0200001C RID: 28
	<DesignerGenerated()>
	Public Partial Class ApprovalRange
		Inherits DockContent

		' Token: 0x06000444 RID: 1092 RVA: 0x00028408 File Offset: 0x00026608
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.dtUser = New DataTable()
			Me.dtLevels = New DataTable()
			Me.dtLevelsID = New DataTable()
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700019B RID: 411
		' (get) Token: 0x06000447 RID: 1095 RVA: 0x000299BB File Offset: 0x00027BBB
		' (set) Token: 0x06000448 RID: 1096 RVA: 0x000299C5 File Offset: 0x00027BC5
		Friend Overridable Property GroupBox2 As GroupBox

		' Token: 0x1700019C RID: 412
		' (get) Token: 0x06000449 RID: 1097 RVA: 0x000299CE File Offset: 0x00027BCE
		' (set) Token: 0x0600044A RID: 1098 RVA: 0x000299D8 File Offset: 0x00027BD8
		Friend Overridable Property Panel2 As Panel

		' Token: 0x1700019D RID: 413
		' (get) Token: 0x0600044B RID: 1099 RVA: 0x000299E1 File Offset: 0x00027BE1
		' (set) Token: 0x0600044C RID: 1100 RVA: 0x000299EC File Offset: 0x00027BEC
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

		' Token: 0x1700019E RID: 414
		' (get) Token: 0x0600044D RID: 1101 RVA: 0x00029A2F File Offset: 0x00027C2F
		' (set) Token: 0x0600044E RID: 1102 RVA: 0x00029A39 File Offset: 0x00027C39
		Friend Overridable Property GroupBox3 As GroupBox

		' Token: 0x1700019F RID: 415
		' (get) Token: 0x0600044F RID: 1103 RVA: 0x00029A42 File Offset: 0x00027C42
		' (set) Token: 0x06000450 RID: 1104 RVA: 0x00029A4C File Offset: 0x00027C4C
		Friend Overridable Property txtLevel As TextBox

		' Token: 0x170001A0 RID: 416
		' (get) Token: 0x06000451 RID: 1105 RVA: 0x00029A55 File Offset: 0x00027C55
		' (set) Token: 0x06000452 RID: 1106 RVA: 0x00029A5F File Offset: 0x00027C5F
		Friend Overridable Property Label1 As Label

		' Token: 0x170001A1 RID: 417
		' (get) Token: 0x06000453 RID: 1107 RVA: 0x00029A68 File Offset: 0x00027C68
		' (set) Token: 0x06000454 RID: 1108 RVA: 0x00029A72 File Offset: 0x00027C72
		Friend Overridable Property lblRows As Label

		' Token: 0x170001A2 RID: 418
		' (get) Token: 0x06000455 RID: 1109 RVA: 0x00029A7B File Offset: 0x00027C7B
		' (set) Token: 0x06000456 RID: 1110 RVA: 0x00029A85 File Offset: 0x00027C85
		Friend Overridable Property Panel1 As Panel

		' Token: 0x170001A3 RID: 419
		' (get) Token: 0x06000457 RID: 1111 RVA: 0x00029A8E File Offset: 0x00027C8E
		' (set) Token: 0x06000458 RID: 1112 RVA: 0x00029A98 File Offset: 0x00027C98
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

		' Token: 0x170001A4 RID: 420
		' (get) Token: 0x06000459 RID: 1113 RVA: 0x00029ADB File Offset: 0x00027CDB
		' (set) Token: 0x0600045A RID: 1114 RVA: 0x00029AE8 File Offset: 0x00027CE8
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

		' Token: 0x170001A5 RID: 421
		' (get) Token: 0x0600045B RID: 1115 RVA: 0x00029B2B File Offset: 0x00027D2B
		' (set) Token: 0x0600045C RID: 1116 RVA: 0x00029B35 File Offset: 0x00027D35
		Friend Overridable Property Label3 As Label

		' Token: 0x170001A6 RID: 422
		' (get) Token: 0x0600045D RID: 1117 RVA: 0x00029B3E File Offset: 0x00027D3E
		' (set) Token: 0x0600045E RID: 1118 RVA: 0x00029B48 File Offset: 0x00027D48
		Friend Overridable Property Label2 As Label

		' Token: 0x170001A7 RID: 423
		' (get) Token: 0x0600045F RID: 1119 RVA: 0x00029B51 File Offset: 0x00027D51
		' (set) Token: 0x06000460 RID: 1120 RVA: 0x00029B5B File Offset: 0x00027D5B
		Friend Overridable Property txtEmail As TextBox

		' Token: 0x170001A8 RID: 424
		' (get) Token: 0x06000461 RID: 1121 RVA: 0x00029B64 File Offset: 0x00027D64
		' (set) Token: 0x06000462 RID: 1122 RVA: 0x00029B70 File Offset: 0x00027D70
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

		' Token: 0x170001A9 RID: 425
		' (get) Token: 0x06000463 RID: 1123 RVA: 0x00029BB3 File Offset: 0x00027DB3
		' (set) Token: 0x06000464 RID: 1124 RVA: 0x00029BC0 File Offset: 0x00027DC0
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

		' Token: 0x170001AA RID: 426
		' (get) Token: 0x06000465 RID: 1125 RVA: 0x00029C03 File Offset: 0x00027E03
		' (set) Token: 0x06000466 RID: 1126 RVA: 0x00029C10 File Offset: 0x00027E10
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

		' Token: 0x170001AB RID: 427
		' (get) Token: 0x06000467 RID: 1127 RVA: 0x00029C53 File Offset: 0x00027E53
		' (set) Token: 0x06000468 RID: 1128 RVA: 0x00029C60 File Offset: 0x00027E60
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

		' Token: 0x170001AC RID: 428
		' (get) Token: 0x06000469 RID: 1129 RVA: 0x00029CA3 File Offset: 0x00027EA3
		' (set) Token: 0x0600046A RID: 1130 RVA: 0x00029CAD File Offset: 0x00027EAD
		Friend Overridable Property PRApprovalID As DataGridViewTextBoxColumn

		' Token: 0x170001AD RID: 429
		' (get) Token: 0x0600046B RID: 1131 RVA: 0x00029CB6 File Offset: 0x00027EB6
		' (set) Token: 0x0600046C RID: 1132 RVA: 0x00029CC0 File Offset: 0x00027EC0
		Friend Overridable Property ApprovalLevel As DataGridViewTextBoxColumn

		' Token: 0x170001AE RID: 430
		' (get) Token: 0x0600046D RID: 1133 RVA: 0x00029CC9 File Offset: 0x00027EC9
		' (set) Token: 0x0600046E RID: 1134 RVA: 0x00029CD3 File Offset: 0x00027ED3
		Friend Overridable Property Sym1 As DataGridViewTextBoxColumn

		' Token: 0x170001AF RID: 431
		' (get) Token: 0x0600046F RID: 1135 RVA: 0x00029CDC File Offset: 0x00027EDC
		' (set) Token: 0x06000470 RID: 1136 RVA: 0x00029CE6 File Offset: 0x00027EE6
		Friend Overridable Property FromAmt As DataGridViewTextBoxColumn

		' Token: 0x170001B0 RID: 432
		' (get) Token: 0x06000471 RID: 1137 RVA: 0x00029CEF File Offset: 0x00027EEF
		' (set) Token: 0x06000472 RID: 1138 RVA: 0x00029CF9 File Offset: 0x00027EF9
		Friend Overridable Property Sym2 As DataGridViewTextBoxColumn

		' Token: 0x170001B1 RID: 433
		' (get) Token: 0x06000473 RID: 1139 RVA: 0x00029D02 File Offset: 0x00027F02
		' (set) Token: 0x06000474 RID: 1140 RVA: 0x00029D0C File Offset: 0x00027F0C
		Friend Overridable Property ToAmt As DataGridViewTextBoxColumn

		' Token: 0x170001B2 RID: 434
		' (get) Token: 0x06000475 RID: 1141 RVA: 0x00029D15 File Offset: 0x00027F15
		' (set) Token: 0x06000476 RID: 1142 RVA: 0x00029D1F File Offset: 0x00027F1F
		Friend Overridable Property imgFill As DataGridViewImageColumn

		' Token: 0x170001B3 RID: 435
		' (get) Token: 0x06000477 RID: 1143 RVA: 0x00029D28 File Offset: 0x00027F28
		' (set) Token: 0x06000478 RID: 1144 RVA: 0x00029D32 File Offset: 0x00027F32
		Friend Overridable Property txtPRApprovalID As TextBox

		' Token: 0x170001B4 RID: 436
		' (get) Token: 0x06000479 RID: 1145 RVA: 0x00029D3B File Offset: 0x00027F3B
		' (set) Token: 0x0600047A RID: 1146 RVA: 0x00029D45 File Offset: 0x00027F45
		Friend Overridable Property btnDelete_ID As DataGridViewImageColumn

		' Token: 0x170001B5 RID: 437
		' (get) Token: 0x0600047B RID: 1147 RVA: 0x00029D4E File Offset: 0x00027F4E
		' (set) Token: 0x0600047C RID: 1148 RVA: 0x00029D58 File Offset: 0x00027F58
		Friend Overridable Property lstPRApprovalID As DataGridViewTextBoxColumn

		' Token: 0x170001B6 RID: 438
		' (get) Token: 0x0600047D RID: 1149 RVA: 0x00029D61 File Offset: 0x00027F61
		' (set) Token: 0x0600047E RID: 1150 RVA: 0x00029D6B File Offset: 0x00027F6B
		Friend Overridable Property ApproverID As DataGridViewTextBoxColumn

		' Token: 0x170001B7 RID: 439
		' (get) Token: 0x0600047F RID: 1151 RVA: 0x00029D74 File Offset: 0x00027F74
		' (set) Token: 0x06000480 RID: 1152 RVA: 0x00029D7E File Offset: 0x00027F7E
		Friend Overridable Property UserName As DataGridViewTextBoxColumn

		' Token: 0x170001B8 RID: 440
		' (get) Token: 0x06000481 RID: 1153 RVA: 0x00029D87 File Offset: 0x00027F87
		' (set) Token: 0x06000482 RID: 1154 RVA: 0x00029D91 File Offset: 0x00027F91
		Friend Overridable Property EmailID As DataGridViewTextBoxColumn

		' Token: 0x06000483 RID: 1155 RVA: 0x00029D9A File Offset: 0x00027F9A
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Designing.SetTheme(Me)
			Me.FillCombo()
			Me.SetLevel()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x06000484 RID: 1156 RVA: 0x00029DCC File Offset: 0x00027FCC
		Private Sub FillCombo()
			Dim text As String = "SELECT UserID, UserName, LoginID, EmailID FROM [User] WHERE (IsActive = 1) ORDER BY UserName"
			Me.dtUser = MainModule.GetData(text)
			Me.cmbUser.ValueMember = "UserID"
			Me.cmbUser.DisplayMember = "LoginID"
			Me.cmbUser.DataSource = Me.dtUser
			Me.cmbUser.SelectedIndex = -1
		End Sub

		' Token: 0x06000485 RID: 1157 RVA: 0x00029E30 File Offset: 0x00028030
		Private Sub SetLevel()
			Dim text As String = " SELECT PRApprovalID, ApprovalLevel, '>' Sym1, FromAmt, '<=' Sym2,ToAmt" & vbCrLf
			text += " FROM PRApproval" & vbCrLf
			Me.dtLevels = MainModule.GetData(text)
			text = " SELECT PRApprovalID, ApproverID, A.UserName, A.EmailID" & vbCrLf
			text += " FROM PRApprovalDtls PD " & vbCrLf
			text += " INNER JOIN [User] A ON PD.ApproverID = A.UserID" & vbCrLf
			Me.dtLevelsID = MainModule.GetData(text)
			Dim dataColumn As DataColumn = New DataColumn("imgFill", GetType(Byte()))
			dataColumn.DefaultValue = MainModule.ImageToBytes(ResourceModule.imgBlank)
			Me.dtLevels.Columns.Add(dataColumn)
			Me.dtLevels.Rows(Me.dtLevels.Rows.Count - 1)("Sym2") = ""
			Me.dgvLevel.DataSource = Me.dtLevels
		End Sub

		' Token: 0x06000486 RID: 1158 RVA: 0x00029F04 File Offset: 0x00028104
		Private Sub ClearForm()
			Me.txtPRApprovalID.Text = ""
			Me.txtLevel.Text = ""
			Me.cmbUser.SelectedIndex = -1
			Me.txtEmail.Text = ""
			Me.FillLevelList("0")
			Me.SetGridFill(-1)
		End Sub

		' Token: 0x06000487 RID: 1159 RVA: 0x00029F66 File Offset: 0x00028166
		Private Sub btnClear_Click(sender As Object, e As EventArgs)
			Me.ClearForm()
		End Sub

		' Token: 0x06000488 RID: 1160 RVA: 0x00029F70 File Offset: 0x00028170
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06000489 RID: 1161 RVA: 0x00029F7C File Offset: 0x0002817C
		Private Sub dgvLevel_CellClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = e.RowIndex > -1
			If flag Then
				Dim name As String = Me.dgvLevel.Columns(e.ColumnIndex).Name
				If Operators.CompareString(name, "imgFill", False) = 0 Then
					Me.SetGridFill(e.RowIndex)
					Me.txtLevel.Text = Conversions.ToString(Me.dgvLevel.Rows(e.RowIndex).Cells("ApprovalLevel").Value)
					Me.txtPRApprovalID.Text = Conversions.ToString(Me.dgvLevel.Rows(e.RowIndex).Cells("PRApprovalID").Value)
					Me.FillLevelList(Conversions.ToString(Me.dgvLevel.Rows(e.RowIndex).Cells("PRApprovalID").Value))
				End If
			End If
		End Sub

		' Token: 0x0600048A RID: 1162 RVA: 0x0002A08C File Offset: 0x0002828C
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

		' Token: 0x0600048B RID: 1163 RVA: 0x0002A124 File Offset: 0x00028324
		Private Sub FillLevelList(sPRApprovalID As String)
			Dim dataView As DataView = New DataView(Me.dtLevelsID, "PRApprovalID = '" + sPRApprovalID + "'", "UserName", DataViewRowState.CurrentRows)
			Dim dataTable As DataTable = dataView.ToTable()
			Me.lblRows.Text = Conversions.ToString(dataTable.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = dataTable
		End Sub

		' Token: 0x0600048C RID: 1164 RVA: 0x0002A190 File Offset: 0x00028390
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

		' Token: 0x0600048D RID: 1165 RVA: 0x0002A220 File Offset: 0x00028420
		Private Function ValidateAdd() As Boolean
			Dim flag As Boolean = Operators.CompareString(Me.txtPRApprovalID.Text, "", False) = 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Select Approval Level.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.txtPRApprovalID.Focus()
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
						Dim flag5 As Boolean = Me.dtLevelsID.[Select](String.Concat(New String() { "PRApprovalID = '", Me.txtPRApprovalID.Text, "' AND ApproverID = '", Me.cmbUser.SelectedValue.ToString(), "'" })).Length > 0
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

		' Token: 0x0600048E RID: 1166 RVA: 0x0002A374 File Offset: 0x00028574
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

		' Token: 0x0600048F RID: 1167 RVA: 0x0002A3DC File Offset: 0x000285DC
		Private Sub AddApprover()
			Me.dtLevelsID.Rows.Add(New Object(-1) {})
			Me.dtLevelsID.Rows(Me.dtLevelsID.Rows.Count - 1)("PRApprovalID") = Me.txtPRApprovalID.Text
			Me.dtLevelsID.Rows(Me.dtLevelsID.Rows.Count - 1)("ApproverID") = RuntimeHelpers.GetObjectValue(Me.cmbUser.SelectedValue)
			Me.dtLevelsID.Rows(Me.dtLevelsID.Rows.Count - 1)("UserName") = Me.cmbUser.Text
			Me.dtLevelsID.Rows(Me.dtLevelsID.Rows.Count - 1)("EmailID") = Me.txtEmail.Text
			Me.FillLevelList(Me.txtPRApprovalID.Text)
			Me.cmbUser.SelectedIndex = -1
			Me.txtEmail.Text = ""
		End Sub

		' Token: 0x06000490 RID: 1168 RVA: 0x0002A518 File Offset: 0x00028718
		Private Sub dgvList_CellClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = e.RowIndex > -1
			If flag Then
				Dim text As String = Me.dgvList.Columns(e.ColumnIndex).Name.ToString()
				If Operators.CompareString(text, "btnDelete_ID", False) = 0 Then
					Dim text2 As String = Conversions.ToString(Me.dgvList.Rows(e.RowIndex).Cells("lstPRApprovalID").Value)
					Dim text3 As String = Conversions.ToString(Me.dgvList.Rows(e.RowIndex).Cells("ApproverID").Value)
					Dim dataRow As DataRow = Me.dtLevelsID.[Select](String.Concat(New String() { "PRApprovalID = '", text2, "' AND ApproverID = '", text3, "'" }))(0)
					Me.dtLevelsID.Rows.Remove(dataRow)
					Me.dtLevelsID.AcceptChanges()
					Me.FillLevelList(text2)
				End If
			End If
		End Sub

		' Token: 0x06000491 RID: 1169 RVA: 0x0002A632 File Offset: 0x00028832
		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			Me.SaveData()
		End Sub

		' Token: 0x06000492 RID: 1170 RVA: 0x0002A63C File Offset: 0x0002883C
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
					Dim dataView As DataView = New DataView(Me.dtLevelsID, Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("PRApprovalID = '", Me.dtLevels.Rows(i)("PRApprovalID")), "'")), "", DataViewRowState.CurrentRows)
					Dim enumerableRowCollection As EnumerableRowCollection(Of DataRow) = dataView.ToTable().AsEnumerable()
					Dim func As Func(Of DataRow, String)
					If ApprovalRange._Closure$__.$I142-0 IsNot Nothing Then
						func = ApprovalRange._Closure$__.$I142-0
					Else
						Dim func2 As Func(Of DataRow, String) = Function(x As DataRow) x.Field("EmailID")
						func = func2
						ApprovalRange._Closure$__.$I142-0 = func2
					End If
					Dim array As String() = enumerableRowCollection.[Select](func).ToArray()
					Dim text2 As String = String.Join(", ", array)
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Me.dtLevels.Rows(i)("ApprovalLevel"), ": "), text2), vbCrLf)))
				Next
				MainModule.TrnLog(Me.Text, "PR Approver List Updated", text, Nothing)
				CustomMsgBox.Show("Saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Catch ex As Exception
				sqlTransaction.Rollback()
				sqlConnection.Close()
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06000493 RID: 1171 RVA: 0x0002A808 File Offset: 0x00028A08
		Private Function InsertID(oCon As SqlConnection, oTrn As SqlTransaction) As Boolean
			Dim text As String = "DELETE FROM PRApprovalDtls"
			Dim flag As Boolean = MainModule.ExecuteSQL(text, oCon, oTrn) = 1
			Dim flag2 As Boolean
			If flag Then
				Dim dataTable As DataTable = Me.dtLevelsID.Copy()
				dataTable.Columns.Remove("UserName")
				dataTable.Columns.Remove("EmailID")
				MainModule.BulkInsertTemp(dataTable, "PRApprovalDtls", oCon, oTrn)
				flag2 = True
			Else
				flag2 = False
			End If
			Return flag2
		End Function

		' Token: 0x040001DD RID: 477
		Private dtUser As DataTable

		' Token: 0x040001DE RID: 478
		Private dtLevels As DataTable

		' Token: 0x040001DF RID: 479
		Private dtLevelsID As DataTable
	End Class
End Namespace
