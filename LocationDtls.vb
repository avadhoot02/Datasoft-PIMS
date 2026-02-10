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
	' Token: 0x0200001E RID: 30
	<DesignerGenerated()>
	Public Partial Class LocationDtls
		Inherits Form

		' Token: 0x170001E4 RID: 484
		' (get) Token: 0x06000507 RID: 1287 RVA: 0x0002F185 File Offset: 0x0002D385
		' (set) Token: 0x06000508 RID: 1288 RVA: 0x0002F18F File Offset: 0x0002D38F
		Friend Overridable Property pnlBorder As Panel

		' Token: 0x170001E5 RID: 485
		' (get) Token: 0x06000509 RID: 1289 RVA: 0x0002F198 File Offset: 0x0002D398
		' (set) Token: 0x0600050A RID: 1290 RVA: 0x0002F1A2 File Offset: 0x0002D3A2
		Friend Overridable Property pnlMain As Panel

		' Token: 0x170001E6 RID: 486
		' (get) Token: 0x0600050B RID: 1291 RVA: 0x0002F1AB File Offset: 0x0002D3AB
		' (set) Token: 0x0600050C RID: 1292 RVA: 0x0002F1B8 File Offset: 0x0002D3B8
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

		' Token: 0x170001E7 RID: 487
		' (get) Token: 0x0600050D RID: 1293 RVA: 0x0002F1FB File Offset: 0x0002D3FB
		' (set) Token: 0x0600050E RID: 1294 RVA: 0x0002F205 File Offset: 0x0002D405
		Friend Overridable Property picFormIcon As PictureBox

		' Token: 0x170001E8 RID: 488
		' (get) Token: 0x0600050F RID: 1295 RVA: 0x0002F20E File Offset: 0x0002D40E
		' (set) Token: 0x06000510 RID: 1296 RVA: 0x0002F218 File Offset: 0x0002D418
		Friend Overridable Property lblCaption As Label

		' Token: 0x170001E9 RID: 489
		' (get) Token: 0x06000511 RID: 1297 RVA: 0x0002F221 File Offset: 0x0002D421
		' (set) Token: 0x06000512 RID: 1298 RVA: 0x0002F22C File Offset: 0x0002D42C
		Friend Overridable Property form_btnClose As Button
			<CompilerGenerated()>
			Get
				Return Me._form_btnClose
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.form_btnClose_Click
				Dim button As Button = Me._form_btnClose
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._form_btnClose = value
				button = Me._form_btnClose
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001EA RID: 490
		' (get) Token: 0x06000513 RID: 1299 RVA: 0x0002F26F File Offset: 0x0002D46F
		' (set) Token: 0x06000514 RID: 1300 RVA: 0x0002F279 File Offset: 0x0002D479
		Friend Overridable Property lblShadow1 As Label

		' Token: 0x170001EB RID: 491
		' (get) Token: 0x06000515 RID: 1301 RVA: 0x0002F282 File Offset: 0x0002D482
		' (set) Token: 0x06000516 RID: 1302 RVA: 0x0002F28C File Offset: 0x0002D48C
		Friend Overridable Property lblShadow2 As Label

		' Token: 0x170001EC RID: 492
		' (get) Token: 0x06000517 RID: 1303 RVA: 0x0002F295 File Offset: 0x0002D495
		' (set) Token: 0x06000518 RID: 1304 RVA: 0x0002F29F File Offset: 0x0002D49F
		Friend Overridable Property txtID As TextBox

		' Token: 0x170001ED RID: 493
		' (get) Token: 0x06000519 RID: 1305 RVA: 0x0002F2A8 File Offset: 0x0002D4A8
		' (set) Token: 0x0600051A RID: 1306 RVA: 0x0002F2B4 File Offset: 0x0002D4B4
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

		' Token: 0x170001EE RID: 494
		' (get) Token: 0x0600051B RID: 1307 RVA: 0x0002F2F7 File Offset: 0x0002D4F7
		' (set) Token: 0x0600051C RID: 1308 RVA: 0x0002F304 File Offset: 0x0002D504
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

		' Token: 0x170001EF RID: 495
		' (get) Token: 0x0600051D RID: 1309 RVA: 0x0002F347 File Offset: 0x0002D547
		' (set) Token: 0x0600051E RID: 1310 RVA: 0x0002F351 File Offset: 0x0002D551
		Friend Overridable Property txtDesc As TextBox

		' Token: 0x170001F0 RID: 496
		' (get) Token: 0x0600051F RID: 1311 RVA: 0x0002F35A File Offset: 0x0002D55A
		' (set) Token: 0x06000520 RID: 1312 RVA: 0x0002F364 File Offset: 0x0002D564
		Friend Overridable Property Label19 As Label

		' Token: 0x170001F1 RID: 497
		' (get) Token: 0x06000521 RID: 1313 RVA: 0x0002F36D File Offset: 0x0002D56D
		' (set) Token: 0x06000522 RID: 1314 RVA: 0x0002F377 File Offset: 0x0002D577
		Friend Overridable Property txtCode As TextBox

		' Token: 0x170001F2 RID: 498
		' (get) Token: 0x06000523 RID: 1315 RVA: 0x0002F380 File Offset: 0x0002D580
		' (set) Token: 0x06000524 RID: 1316 RVA: 0x0002F38A File Offset: 0x0002D58A
		Friend Overridable Property Label18 As Label

		' Token: 0x170001F3 RID: 499
		' (get) Token: 0x06000525 RID: 1317 RVA: 0x0002F393 File Offset: 0x0002D593
		' (set) Token: 0x06000526 RID: 1318 RVA: 0x0002F39D File Offset: 0x0002D59D
		Friend Overridable Property txtName As TextBox

		' Token: 0x170001F4 RID: 500
		' (get) Token: 0x06000527 RID: 1319 RVA: 0x0002F3A6 File Offset: 0x0002D5A6
		' (set) Token: 0x06000528 RID: 1320 RVA: 0x0002F3B0 File Offset: 0x0002D5B0
		Friend Overridable Property Label9 As Label

		' Token: 0x170001F5 RID: 501
		' (get) Token: 0x06000529 RID: 1321 RVA: 0x0002F3B9 File Offset: 0x0002D5B9
		' (set) Token: 0x0600052A RID: 1322 RVA: 0x0002F3C3 File Offset: 0x0002D5C3
		Friend Overridable Property Label1 As Label

		' Token: 0x170001F6 RID: 502
		' (get) Token: 0x0600052B RID: 1323 RVA: 0x0002F3CC File Offset: 0x0002D5CC
		' (set) Token: 0x0600052C RID: 1324 RVA: 0x0002F3D6 File Offset: 0x0002D5D6
		Friend Overridable Property Label17 As Label

		' Token: 0x0600052D RID: 1325
		Private Declare Sub SendMessage Lib "user32.DLL" (hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

		' Token: 0x0600052E RID: 1326
		Private Declare Sub ReleaseCapture Lib "user32.DLL" ()

		' Token: 0x0600052F RID: 1327 RVA: 0x0002F3DF File Offset: 0x0002D5DF
		Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs)
			LocationDtls.ReleaseCapture()
			LocationDtls.SendMessage(MyBase.Handle, 274, 61458, 0)
		End Sub

		' Token: 0x06000530 RID: 1328 RVA: 0x0002F400 File Offset: 0x0002D600
		Public Sub New(dr As DataRow)
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.InitializeComponent()
			Designing.SetTheme(Me)
			Me.picFormIcon.Image = ResourceModule.imgFormIconPic
			MyBase.FormBorderStyle = FormBorderStyle.None
			Me.BackColor = Color.DarkGray
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.lblCaption.Text = Me.Text
			Me.form_btnClose.DialogResult = DialogResult.Cancel
			Me.drData = dr
		End Sub

		' Token: 0x06000531 RID: 1329 RVA: 0x0002F491 File Offset: 0x0002D691
		Private Sub form_btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06000532 RID: 1330 RVA: 0x0002F49B File Offset: 0x0002D69B
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06000533 RID: 1331 RVA: 0x0002F4A5 File Offset: 0x0002D6A5
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Me.Filldata()
		End Sub

		' Token: 0x06000534 RID: 1332 RVA: 0x0002F4B0 File Offset: 0x0002D6B0
		Private Sub Filldata()
			Dim flag As Boolean = Not Information.IsNothing(Me.drData)
			If flag Then
				Me.txtID.Text = Conversions.ToString(Me.drData("ID"))
				Me.txtCode.Text = Conversions.ToString(Me.drData("LocationCode"))
				Me.txtName.Text = Conversions.ToString(Me.drData("LocationName"))
				Me.txtDesc.Text = Conversions.ToString(Me.drData("Description"))
			End If
		End Sub

		' Token: 0x06000535 RID: 1333 RVA: 0x0002F55C File Offset: 0x0002D75C
		Private Function ValidateForm() As Boolean
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.txtName.Text), "", False) = 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Enter Location Name.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.txtName.Focus()
				flag2 = False
			Else
				Dim text As String = " SELECT LocationName FROM Location "
				text = String.Concat(New String() { text, " WHERE LocationName IN ('", Me.txtName.Text, "') AND LocationID <> '", Me.txtID.Text, "'" })
				Dim data As DataTable = MainModule.GetData(text)
				Dim flag3 As Boolean = data.Rows.Count > 0
				If flag3 Then
					CustomMsgBox.Show("Location Name Already In Database.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					flag2 = False
				Else
					flag2 = True
				End If
			End If
			Return flag2
		End Function

		' Token: 0x06000536 RID: 1334 RVA: 0x0002F638 File Offset: 0x0002D838
		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Dim flag As Boolean = Not Me.ValidateForm()
				If flag Then
					Return
				End If
				Me.SaveData()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06000537 RID: 1335 RVA: 0x0002F6B4 File Offset: 0x0002D8B4
		Private Sub SaveData()
			Dim text As String = String.Concat(New String() { " UPDATE Location SET LocationName = '", Strings.Trim(Me.txtName.Text), "', Description = '", Strings.Trim(Me.txtDesc.Text), "', " })
			text = text + " ModificationDt = GETDATE(), ModifiedBy = '" + GlobalVariables.gsUserID + "' "
			text = text + " WHERE LocationID = '" + Me.txtID.Text + "'"
			Dim flag As Boolean = MainModule.ExecuteSQL(text) = 1
			If flag Then
				Me.drData("LocationName") = Strings.Trim(Me.txtName.Text)
				Me.drData("Description") = Strings.Trim(Me.txtDesc.Text)
				CustomMsgBox.Show("Location Modified.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				MyBase.DialogResult = DialogResult.OK
				MyBase.Close()
			End If
		End Sub

		' Token: 0x04000223 RID: 547
		Public drData As DataRow
	End Class
End Namespace
