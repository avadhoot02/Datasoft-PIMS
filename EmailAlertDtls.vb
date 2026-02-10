Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x0200004B RID: 75
	<DesignerGenerated()>
	Public Partial Class EmailAlertDtls
		Inherits Form

		' Token: 0x17000504 RID: 1284
		' (get) Token: 0x06000D5D RID: 3421 RVA: 0x0007A659 File Offset: 0x00078859
		' (set) Token: 0x06000D5E RID: 3422 RVA: 0x0007A663 File Offset: 0x00078863
		Friend Overridable Property pnlBorder As Panel

		' Token: 0x17000505 RID: 1285
		' (get) Token: 0x06000D5F RID: 3423 RVA: 0x0007A66C File Offset: 0x0007886C
		' (set) Token: 0x06000D60 RID: 3424 RVA: 0x0007A676 File Offset: 0x00078876
		Friend Overridable Property pnlMain As Panel

		' Token: 0x17000506 RID: 1286
		' (get) Token: 0x06000D61 RID: 3425 RVA: 0x0007A67F File Offset: 0x0007887F
		' (set) Token: 0x06000D62 RID: 3426 RVA: 0x0007A68C File Offset: 0x0007888C
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

		' Token: 0x17000507 RID: 1287
		' (get) Token: 0x06000D63 RID: 3427 RVA: 0x0007A6CF File Offset: 0x000788CF
		' (set) Token: 0x06000D64 RID: 3428 RVA: 0x0007A6D9 File Offset: 0x000788D9
		Friend Overridable Property txtEmail As TextBox

		' Token: 0x17000508 RID: 1288
		' (get) Token: 0x06000D65 RID: 3429 RVA: 0x0007A6E2 File Offset: 0x000788E2
		' (set) Token: 0x06000D66 RID: 3430 RVA: 0x0007A6EC File Offset: 0x000788EC
		Friend Overridable Property Label2 As Label

		' Token: 0x17000509 RID: 1289
		' (get) Token: 0x06000D67 RID: 3431 RVA: 0x0007A6F5 File Offset: 0x000788F5
		' (set) Token: 0x06000D68 RID: 3432 RVA: 0x0007A700 File Offset: 0x00078900
		Friend Overridable Property cmbUser As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbUser
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbUser_SelectedIndexChanged
				Dim eventHandler2 As EventHandler = AddressOf Me.cmbUser_TextChanged
				Dim comboBox As ComboBox = Me._cmbUser
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.SelectedIndexChanged, eventHandler
					RemoveHandler comboBox.TextChanged, eventHandler2
				End If
				Me._cmbUser = value
				comboBox = Me._cmbUser
				If comboBox IsNot Nothing Then
					AddHandler comboBox.SelectedIndexChanged, eventHandler
					AddHandler comboBox.TextChanged, eventHandler2
				End If
			End Set
		End Property

		' Token: 0x1700050A RID: 1290
		' (get) Token: 0x06000D69 RID: 3433 RVA: 0x0007A75E File Offset: 0x0007895E
		' (set) Token: 0x06000D6A RID: 3434 RVA: 0x0007A768 File Offset: 0x00078968
		Friend Overridable Property Label1 As Label

		' Token: 0x1700050B RID: 1291
		' (get) Token: 0x06000D6B RID: 3435 RVA: 0x0007A771 File Offset: 0x00078971
		' (set) Token: 0x06000D6C RID: 3436 RVA: 0x0007A77C File Offset: 0x0007897C
		Friend Overridable Property dgvEmail As DataGridView
			<CompilerGenerated()>
			Get
				Return Me._dgvEmail
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim dataGridViewCellEventHandler As DataGridViewCellEventHandler = AddressOf Me.dgvEmail_CellContentClick
				Dim dataGridView As DataGridView = Me._dgvEmail
				If dataGridView IsNot Nothing Then
					RemoveHandler dataGridView.CellContentClick, dataGridViewCellEventHandler
				End If
				Me._dgvEmail = value
				dataGridView = Me._dgvEmail
				If dataGridView IsNot Nothing Then
					AddHandler dataGridView.CellContentClick, dataGridViewCellEventHandler
				End If
			End Set
		End Property

		' Token: 0x1700050C RID: 1292
		' (get) Token: 0x06000D6D RID: 3437 RVA: 0x0007A7BF File Offset: 0x000789BF
		' (set) Token: 0x06000D6E RID: 3438 RVA: 0x0007A7C9 File Offset: 0x000789C9
		Friend Overridable Property skip_lblTrn As Label

		' Token: 0x1700050D RID: 1293
		' (get) Token: 0x06000D6F RID: 3439 RVA: 0x0007A7D2 File Offset: 0x000789D2
		' (set) Token: 0x06000D70 RID: 3440 RVA: 0x0007A7DC File Offset: 0x000789DC
		Friend Overridable Property panelTitleBar As Panel
			<CompilerGenerated()>
			Get
				Return Me._panelTitleBar
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.panelTitleBar_MouseDown
				Dim panel As Panel = Me._panelTitleBar
				If panel IsNot Nothing Then
					RemoveHandler panel.MouseDown, mouseEventHandler
				End If
				Me._panelTitleBar = value
				panel = Me._panelTitleBar
				If panel IsNot Nothing Then
					AddHandler panel.MouseDown, mouseEventHandler
				End If
			End Set
		End Property

		' Token: 0x1700050E RID: 1294
		' (get) Token: 0x06000D71 RID: 3441 RVA: 0x0007A81F File Offset: 0x00078A1F
		' (set) Token: 0x06000D72 RID: 3442 RVA: 0x0007A829 File Offset: 0x00078A29
		Friend Overridable Property picFormIcon As PictureBox

		' Token: 0x1700050F RID: 1295
		' (get) Token: 0x06000D73 RID: 3443 RVA: 0x0007A832 File Offset: 0x00078A32
		' (set) Token: 0x06000D74 RID: 3444 RVA: 0x0007A83C File Offset: 0x00078A3C
		Friend Overridable Property lblCaption As Label

		' Token: 0x17000510 RID: 1296
		' (get) Token: 0x06000D75 RID: 3445 RVA: 0x0007A845 File Offset: 0x00078A45
		' (set) Token: 0x06000D76 RID: 3446 RVA: 0x0007A84F File Offset: 0x00078A4F
		Friend Overridable Property form_btnClose As Button

		' Token: 0x17000511 RID: 1297
		' (get) Token: 0x06000D77 RID: 3447 RVA: 0x0007A858 File Offset: 0x00078A58
		' (set) Token: 0x06000D78 RID: 3448 RVA: 0x0007A862 File Offset: 0x00078A62
		Friend Overridable Property lblShadow1 As Label

		' Token: 0x17000512 RID: 1298
		' (get) Token: 0x06000D79 RID: 3449 RVA: 0x0007A86B File Offset: 0x00078A6B
		' (set) Token: 0x06000D7A RID: 3450 RVA: 0x0007A875 File Offset: 0x00078A75
		Friend Overridable Property lblShadow2 As Label

		' Token: 0x17000513 RID: 1299
		' (get) Token: 0x06000D7B RID: 3451 RVA: 0x0007A87E File Offset: 0x00078A7E
		' (set) Token: 0x06000D7C RID: 3452 RVA: 0x0007A888 File Offset: 0x00078A88
		Friend Overridable Property UserID As DataGridViewTextBoxColumn

		' Token: 0x17000514 RID: 1300
		' (get) Token: 0x06000D7D RID: 3453 RVA: 0x0007A891 File Offset: 0x00078A91
		' (set) Token: 0x06000D7E RID: 3454 RVA: 0x0007A89B File Offset: 0x00078A9B
		Friend Overridable Property Person As DataGridViewTextBoxColumn

		' Token: 0x17000515 RID: 1301
		' (get) Token: 0x06000D7F RID: 3455 RVA: 0x0007A8A4 File Offset: 0x00078AA4
		' (set) Token: 0x06000D80 RID: 3456 RVA: 0x0007A8AE File Offset: 0x00078AAE
		Friend Overridable Property EmailID As DataGridViewTextBoxColumn

		' Token: 0x17000516 RID: 1302
		' (get) Token: 0x06000D81 RID: 3457 RVA: 0x0007A8B7 File Offset: 0x00078AB7
		' (set) Token: 0x06000D82 RID: 3458 RVA: 0x0007A8C1 File Offset: 0x00078AC1
		Friend Overridable Property btnDelete_Email As DataGridViewImageColumn

		' Token: 0x17000517 RID: 1303
		' (get) Token: 0x06000D83 RID: 3459 RVA: 0x0007A8CA File Offset: 0x00078ACA
		' (set) Token: 0x06000D84 RID: 3460 RVA: 0x0007A8D4 File Offset: 0x00078AD4
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

		' Token: 0x17000518 RID: 1304
		' (get) Token: 0x06000D85 RID: 3461 RVA: 0x0007A917 File Offset: 0x00078B17
		' (set) Token: 0x06000D86 RID: 3462 RVA: 0x0007A924 File Offset: 0x00078B24
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

		' Token: 0x06000D87 RID: 3463
		Private Declare Sub SendMessage Lib "user32.DLL" (hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

		' Token: 0x06000D88 RID: 3464
		Private Declare Sub ReleaseCapture Lib "user32.DLL" ()

		' Token: 0x06000D89 RID: 3465 RVA: 0x0007A967 File Offset: 0x00078B67
		Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs)
			EmailAlertDtls.ReleaseCapture()
			EmailAlertDtls.SendMessage(MyBase.Handle, 274, 61458, 0)
		End Sub

		' Token: 0x06000D8A RID: 3466 RVA: 0x0007A988 File Offset: 0x00078B88
		Public Sub New(dr As DataGridViewRow)
			AddHandler MyBase.FormClosing, AddressOf Me.EmailAlertDtls_FormClosing
			AddHandler MyBase.Load, AddressOf Me.EmailAlertDtls_Load
			Me.dtUser = New DataTable()
			Me.InitializeComponent()
			Designing.SetTheme(Me)
			Me.picFormIcon.Image = ResourceModule.imgFormIconPic
			MyBase.FormBorderStyle = FormBorderStyle.None
			Me.BackColor = Color.DarkGray
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.lblCaption.Text = Me.Text
			Me.form_btnClose.DialogResult = DialogResult.Cancel
			Me.btnDelete_Email.Image = ResourceModule.imgdgvDelete
			Me.drData = dr
		End Sub

		' Token: 0x06000D8B RID: 3467 RVA: 0x0007AA48 File Offset: 0x00078C48
		Private Sub EmailAlertDtls_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", Me.skip_lblTrn.Text, Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x06000D8C RID: 3468 RVA: 0x0007AA83 File Offset: 0x00078C83
		Private Sub EmailAlertDtls_Load(sender As Object, e As EventArgs)
			Me.FillCombo()
			Me.FillData()
			MainModule.TrnLog(Me.Text, "Opened", Me.skip_lblTrn.Text, Nothing)
		End Sub

		' Token: 0x06000D8D RID: 3469 RVA: 0x0007AAB4 File Offset: 0x00078CB4
		Private Sub FillCombo()
			Dim text As String = "SELECT UserID, UserName, EmailID FROM [User] WHERE (IsActive = 1) ORDER BY UserName"
			Me.dtUser = MainModule.GetData(text)
			Me.cmbUser.ValueMember = "UserID"
			Me.cmbUser.DisplayMember = "UserName"
			Me.cmbUser.DataSource = Me.dtUser
			Me.cmbUser.SelectedIndex = -1
		End Sub

		' Token: 0x06000D8E RID: 3470 RVA: 0x0007AB18 File Offset: 0x00078D18
		Private Sub FillData()
			Dim flag As Boolean = Not Information.IsNothing(Me.drData)
			If flag Then
				Me.skip_lblTrn.Text = Conversions.ToString(Operators.ConcatenateObject("Transaction : ", Me.drData.Cells("Transactions").Value))
				Dim text As String = " SELECT EmailSettingsID, UserID, Person, EmailID "
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" FROM EmailSettingsDtls WHERE EmailSettingsID = '", Me.drData.Cells("EmailSettingsID").Value), "' ")))
				Dim data As DataTable = MainModule.GetData(text)
				Me.dgvEmail.Rows.Clear()
				Dim num As Integer = data.Rows.Count - 1
				For i As Integer = 0 To num
					Me.dgvEmail.Rows.Add()
					Me.dgvEmail.Rows(i).Cells("UserID").Value = data.Rows(i)("UserID").ToString()
					Me.dgvEmail.Rows(i).Cells("Person").Value = data.Rows(i)("Person").ToString()
					Me.dgvEmail.Rows(i).Cells("EmailID").Value = data.Rows(i)("EmailID").ToString()
				Next
			End If
		End Sub

		' Token: 0x06000D8F RID: 3471 RVA: 0x0007ACC8 File Offset: 0x00078EC8
		Private Sub cmbUser_SelectedIndexChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000D90 RID: 3472 RVA: 0x0007ACCC File Offset: 0x00078ECC
		Private Sub cmbUser_TextChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.cmbUser.Text, "", False) <> 0
			If flag Then
				Dim array As DataRow() = Me.dtUser.[Select]("UserName = '" + Me.cmbUser.Text + "'")
				Dim flag2 As Boolean = array.Length > 0
				If flag2 Then
					Me.txtEmail.Text = array(0)("EmailID").ToString()
				Else
					Me.txtEmail.Text = ""
				End If
			Else
				Me.txtEmail.Text = ""
			End If
		End Sub

		' Token: 0x06000D91 RID: 3473 RVA: 0x0007AD71 File Offset: 0x00078F71
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06000D92 RID: 3474 RVA: 0x0007AD7C File Offset: 0x00078F7C
		Private Function ValidateAdd() As Boolean
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.cmbUser.Text), "", False) = 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Select/ Enter User or Person Name.!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Me.cmbUser.Focus()
				flag2 = False
			Else
				Dim flag3 As Boolean = Operators.CompareString(Strings.Trim(Me.txtEmail.Text), "", False) = 0
				If flag3 Then
					CustomMsgBox.Show("Enter Email Address.!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
					Me.txtEmail.Focus()
					flag2 = False
				Else
					Dim num As Integer = Me.dgvEmail.Rows.Count - 1
					For i As Integer = 0 To num
						Dim flag4 As Boolean = Operators.ConditionalCompareObjectEqual(Strings.Trim(Me.cmbUser.Text), Me.dgvEmail.Rows(i).Cells("Person").Value, False)
						If flag4 Then
							CustomMsgBox.Show("Person Already In The List.!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
							Me.cmbUser.Focus()
							Return False
						End If
						Dim flag5 As Boolean = Operators.ConditionalCompareObjectEqual(Strings.Trim(Me.txtEmail.Text), Me.dgvEmail.Rows(i).Cells("EmailID").Value, False)
						If flag5 Then
							CustomMsgBox.Show("Email ID Already In The List.!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
							Me.txtEmail.Focus()
							Return False
						End If
					Next
					flag2 = True
				End If
			End If
			Return flag2
		End Function

		' Token: 0x06000D93 RID: 3475 RVA: 0x0007AF18 File Offset: 0x00079118
		Private Sub sml_btnAdd_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = Not Me.ValidateAdd()
				If Not flag Then
					Me.dgvEmail.Rows.Add()
					Dim flag2 As Boolean = Me.cmbUser.SelectedIndex > -1
					If flag2 Then
						Me.dgvEmail.Rows(Me.dgvEmail.Rows.Count - 1).Cells("UserID").Value = RuntimeHelpers.GetObjectValue(Me.cmbUser.SelectedValue)
					Else
						Me.dgvEmail.Rows(Me.dgvEmail.Rows.Count - 1).Cells("UserID").Value = ""
					End If
					Me.dgvEmail.Rows(Me.dgvEmail.Rows.Count - 1).Cells("Person").Value = Me.cmbUser.Text
					Me.dgvEmail.Rows(Me.dgvEmail.Rows.Count - 1).Cells("EmailID").Value = Me.txtEmail.Text
					Me.cmbUser.Text = ""
					Me.txtEmail.Text = ""
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06000D94 RID: 3476 RVA: 0x0007B0D8 File Offset: 0x000792D8
		Private Sub dgvEmail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = e.RowIndex > -1
			If flag Then
				Dim text As String = Me.dgvEmail.Columns(e.ColumnIndex).Name.ToString()
				If Operators.CompareString(text, "btnDelete_Email", False) = 0 Then
					Me.dgvEmail.Rows.RemoveAt(e.RowIndex)
				End If
			End If
		End Sub

		' Token: 0x06000D95 RID: 3477 RVA: 0x0007B144 File Offset: 0x00079344
		Private Function ValidateForm() As Boolean
			Dim flag As Boolean = Me.dgvEmail.Rows.Count = 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("No Data To Save.!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Me.cmbUser.Focus()
				flag2 = False
			Else
				flag2 = True
			End If
			Return flag2
		End Function

		' Token: 0x06000D96 RID: 3478 RVA: 0x0007B194 File Offset: 0x00079394
		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			Try
				Me.SaveData()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06000D97 RID: 3479 RVA: 0x0007B1EC File Offset: 0x000793EC
		Private Sub SaveData()
			Dim flag As Boolean = CustomMsgBox.Show("Save..", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
			If flag Then
				Dim flag2 As Boolean = Not Me.ValidateForm()
				If Not flag2 Then
					Dim text As String = " DELETE FROM EmailSettingsDtls "
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" WHERE EmailSettingsID = '", Me.drData.Cells("EmailSettingsID").Value), "' ")))
					Dim flag3 As Boolean = MainModule.ExecuteSQL(text) = 1
					If flag3 Then
						text = ""
						Dim text2 As String = Me.skip_lblTrn.Text + vbCrLf & "Address List : "
						Dim num As Integer = Me.dgvEmail.Rows.Count - 1
						For i As Integer = 0 To num
							text += " INSERT INTO EmailSettingsDtls (EmailSettingsID, UserID, Person, EmailID)"
							text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" VALUES ('", Me.drData.Cells("EmailSettingsID").Value), "',")))
							Dim flag4 As Boolean = Operators.CompareString(Me.dgvEmail.Rows(i).Cells("UserID").Value.ToString(), "", False) <> 0
							If flag4 Then
								text = text + " '" + Me.dgvEmail.Rows(i).Cells("UserID").Value.ToString() + "', "
							Else
								text += " NULL, "
							End If
							text = text + " '" + Me.dgvEmail.Rows(i).Cells("Person").Value.ToString() + "',"
							text = text + " '" + Me.dgvEmail.Rows(i).Cells("EmailID").Value.ToString() + "')"
							text2 = Me.dgvEmail.Rows(i).Cells("EmailID").Value.ToString() + ", "
						Next
						Dim flag5 As Boolean = Operators.CompareString(text, "", False) <> 0
						If flag5 Then
							Dim flag6 As Boolean = MainModule.ExecuteSQL(text) = 1
							If flag6 Then
								MainModule.TrnLog(Me.Text, "Email List Updated", Strings.Mid(text2, 1, text2.Length - 2), Nothing)
								CustomMsgBox.Show("Email Settings Saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
								MyBase.Close()
							End If
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x04000599 RID: 1433
		Private drData As DataGridViewRow

		' Token: 0x0400059A RID: 1434
		Private dtUser As DataTable
	End Class
End Namespace
