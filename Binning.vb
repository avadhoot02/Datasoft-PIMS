Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x0200005D RID: 93
	<DesignerGenerated()>
	Public Partial Class Binning
		Inherits Form

		' Token: 0x170007F1 RID: 2033
		' (get) Token: 0x060014BF RID: 5311 RVA: 0x000BFB19 File Offset: 0x000BDD19
		' (set) Token: 0x060014C0 RID: 5312 RVA: 0x000BFB23 File Offset: 0x000BDD23
		Friend Overridable Property pnlBorder As Panel

		' Token: 0x170007F2 RID: 2034
		' (get) Token: 0x060014C1 RID: 5313 RVA: 0x000BFB2C File Offset: 0x000BDD2C
		' (set) Token: 0x060014C2 RID: 5314 RVA: 0x000BFB36 File Offset: 0x000BDD36
		Friend Overridable Property pnlMain As Panel

		' Token: 0x170007F3 RID: 2035
		' (get) Token: 0x060014C3 RID: 5315 RVA: 0x000BFB3F File Offset: 0x000BDD3F
		' (set) Token: 0x060014C4 RID: 5316 RVA: 0x000BFB4C File Offset: 0x000BDD4C
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

		' Token: 0x170007F4 RID: 2036
		' (get) Token: 0x060014C5 RID: 5317 RVA: 0x000BFB8F File Offset: 0x000BDD8F
		' (set) Token: 0x060014C6 RID: 5318 RVA: 0x000BFB99 File Offset: 0x000BDD99
		Friend Overridable Property picFormIcon As PictureBox

		' Token: 0x170007F5 RID: 2037
		' (get) Token: 0x060014C7 RID: 5319 RVA: 0x000BFBA2 File Offset: 0x000BDDA2
		' (set) Token: 0x060014C8 RID: 5320 RVA: 0x000BFBAC File Offset: 0x000BDDAC
		Friend Overridable Property lblCaption As Label

		' Token: 0x170007F6 RID: 2038
		' (get) Token: 0x060014C9 RID: 5321 RVA: 0x000BFBB5 File Offset: 0x000BDDB5
		' (set) Token: 0x060014CA RID: 5322 RVA: 0x000BFBC0 File Offset: 0x000BDDC0
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

		' Token: 0x170007F7 RID: 2039
		' (get) Token: 0x060014CB RID: 5323 RVA: 0x000BFC03 File Offset: 0x000BDE03
		' (set) Token: 0x060014CC RID: 5324 RVA: 0x000BFC0D File Offset: 0x000BDE0D
		Friend Overridable Property lblShadow1 As Label

		' Token: 0x170007F8 RID: 2040
		' (get) Token: 0x060014CD RID: 5325 RVA: 0x000BFC16 File Offset: 0x000BDE16
		' (set) Token: 0x060014CE RID: 5326 RVA: 0x000BFC20 File Offset: 0x000BDE20
		Friend Overridable Property lblShadow2 As Label

		' Token: 0x170007F9 RID: 2041
		' (get) Token: 0x060014CF RID: 5327 RVA: 0x000BFC29 File Offset: 0x000BDE29
		' (set) Token: 0x060014D0 RID: 5328 RVA: 0x000BFC34 File Offset: 0x000BDE34
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

		' Token: 0x170007FA RID: 2042
		' (get) Token: 0x060014D1 RID: 5329 RVA: 0x000BFC77 File Offset: 0x000BDE77
		' (set) Token: 0x060014D2 RID: 5330 RVA: 0x000BFC81 File Offset: 0x000BDE81
		Friend Overridable Property lblRows As Label

		' Token: 0x170007FB RID: 2043
		' (get) Token: 0x060014D3 RID: 5331 RVA: 0x000BFC8A File Offset: 0x000BDE8A
		' (set) Token: 0x060014D4 RID: 5332 RVA: 0x000BFC94 File Offset: 0x000BDE94
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

		' Token: 0x170007FC RID: 2044
		' (get) Token: 0x060014D5 RID: 5333 RVA: 0x000BFCD7 File Offset: 0x000BDED7
		' (set) Token: 0x060014D6 RID: 5334 RVA: 0x000BFCE4 File Offset: 0x000BDEE4
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

		' Token: 0x170007FD RID: 2045
		' (get) Token: 0x060014D7 RID: 5335 RVA: 0x000BFD27 File Offset: 0x000BDF27
		' (set) Token: 0x060014D8 RID: 5336 RVA: 0x000BFD34 File Offset: 0x000BDF34
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

		' Token: 0x170007FE RID: 2046
		' (get) Token: 0x060014D9 RID: 5337 RVA: 0x000BFD77 File Offset: 0x000BDF77
		' (set) Token: 0x060014DA RID: 5338 RVA: 0x000BFD81 File Offset: 0x000BDF81
		Friend Overridable Property Label1 As Label

		' Token: 0x170007FF RID: 2047
		' (get) Token: 0x060014DB RID: 5339 RVA: 0x000BFD8A File Offset: 0x000BDF8A
		' (set) Token: 0x060014DC RID: 5340 RVA: 0x000BFD94 File Offset: 0x000BDF94
		Friend Overridable Property txtBarcode As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtBarcode
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim keyEventHandler As KeyEventHandler = AddressOf Me.txtBarcode_KeyDown
				Dim textBox As TextBox = Me._txtBarcode
				If textBox IsNot Nothing Then
					RemoveHandler textBox.KeyDown, keyEventHandler
				End If
				Me._txtBarcode = value
				textBox = Me._txtBarcode
				If textBox IsNot Nothing Then
					AddHandler textBox.KeyDown, keyEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000800 RID: 2048
		' (get) Token: 0x060014DD RID: 5341 RVA: 0x000BFDD7 File Offset: 0x000BDFD7
		' (set) Token: 0x060014DE RID: 5342 RVA: 0x000BFDE1 File Offset: 0x000BDFE1
		Friend Overridable Property Label3 As Label

		' Token: 0x17000801 RID: 2049
		' (get) Token: 0x060014DF RID: 5343 RVA: 0x000BFDEA File Offset: 0x000BDFEA
		' (set) Token: 0x060014E0 RID: 5344 RVA: 0x000BFDF4 File Offset: 0x000BDFF4
		Friend Overridable Property txtLocation As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtLocation
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim keyEventHandler As KeyEventHandler = AddressOf Me.txtLocation_KeyDown
				Dim textBox As TextBox = Me._txtLocation
				If textBox IsNot Nothing Then
					RemoveHandler textBox.KeyDown, keyEventHandler
				End If
				Me._txtLocation = value
				textBox = Me._txtLocation
				If textBox IsNot Nothing Then
					AddHandler textBox.KeyDown, keyEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000802 RID: 2050
		' (get) Token: 0x060014E1 RID: 5345 RVA: 0x000BFE37 File Offset: 0x000BE037
		' (set) Token: 0x060014E2 RID: 5346 RVA: 0x000BFE44 File Offset: 0x000BE044
		Friend Overridable Property dgvDtls As DataGridView
			<CompilerGenerated()>
			Get
				Return Me._dgvDtls
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim dataGridViewCellEventHandler As DataGridViewCellEventHandler = AddressOf Me.dgvDtls_CellContentClick
				Dim dataGridView As DataGridView = Me._dgvDtls
				If dataGridView IsNot Nothing Then
					RemoveHandler dataGridView.CellContentClick, dataGridViewCellEventHandler
				End If
				Me._dgvDtls = value
				dataGridView = Me._dgvDtls
				If dataGridView IsNot Nothing Then
					AddHandler dataGridView.CellContentClick, dataGridViewCellEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000803 RID: 2051
		' (get) Token: 0x060014E3 RID: 5347 RVA: 0x000BFE87 File Offset: 0x000BE087
		' (set) Token: 0x060014E4 RID: 5348 RVA: 0x000BFE91 File Offset: 0x000BE091
		Friend Overridable Property SrNo As DataGridViewTextBoxColumn

		' Token: 0x17000804 RID: 2052
		' (get) Token: 0x060014E5 RID: 5349 RVA: 0x000BFE9A File Offset: 0x000BE09A
		' (set) Token: 0x060014E6 RID: 5350 RVA: 0x000BFEA4 File Offset: 0x000BE0A4
		Friend Overridable Property CatalogNo As DataGridViewTextBoxColumn

		' Token: 0x17000805 RID: 2053
		' (get) Token: 0x060014E7 RID: 5351 RVA: 0x000BFEAD File Offset: 0x000BE0AD
		' (set) Token: 0x060014E8 RID: 5352 RVA: 0x000BFEB7 File Offset: 0x000BE0B7
		Friend Overridable Property ProductBarcode As DataGridViewTextBoxColumn

		' Token: 0x17000806 RID: 2054
		' (get) Token: 0x060014E9 RID: 5353 RVA: 0x000BFEC0 File Offset: 0x000BE0C0
		' (set) Token: 0x060014EA RID: 5354 RVA: 0x000BFECA File Offset: 0x000BE0CA
		Friend Overridable Property OldLocation As DataGridViewTextBoxColumn

		' Token: 0x17000807 RID: 2055
		' (get) Token: 0x060014EB RID: 5355 RVA: 0x000BFED3 File Offset: 0x000BE0D3
		' (set) Token: 0x060014EC RID: 5356 RVA: 0x000BFEDD File Offset: 0x000BE0DD
		Friend Overridable Property NewLocation As DataGridViewTextBoxColumn

		' Token: 0x17000808 RID: 2056
		' (get) Token: 0x060014ED RID: 5357 RVA: 0x000BFEE6 File Offset: 0x000BE0E6
		' (set) Token: 0x060014EE RID: 5358 RVA: 0x000BFEF0 File Offset: 0x000BE0F0
		Friend Overridable Property OldLocationCode As DataGridViewTextBoxColumn

		' Token: 0x17000809 RID: 2057
		' (get) Token: 0x060014EF RID: 5359 RVA: 0x000BFEF9 File Offset: 0x000BE0F9
		' (set) Token: 0x060014F0 RID: 5360 RVA: 0x000BFF03 File Offset: 0x000BE103
		Friend Overridable Property NewLocationCode As DataGridViewTextBoxColumn

		' Token: 0x1700080A RID: 2058
		' (get) Token: 0x060014F1 RID: 5361 RVA: 0x000BFF0C File Offset: 0x000BE10C
		' (set) Token: 0x060014F2 RID: 5362 RVA: 0x000BFF16 File Offset: 0x000BE116
		Friend Overridable Property IsBinningAlert As DataGridViewTextBoxColumn

		' Token: 0x1700080B RID: 2059
		' (get) Token: 0x060014F3 RID: 5363 RVA: 0x000BFF1F File Offset: 0x000BE11F
		' (set) Token: 0x060014F4 RID: 5364 RVA: 0x000BFF29 File Offset: 0x000BE129
		Friend Overridable Property btnDelete_File As DataGridViewImageColumn

		' Token: 0x060014F5 RID: 5365
		Private Declare Sub SendMessage Lib "user32.DLL" (hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

		' Token: 0x060014F6 RID: 5366
		Private Declare Sub ReleaseCapture Lib "user32.DLL" ()

		' Token: 0x060014F7 RID: 5367 RVA: 0x000BFF32 File Offset: 0x000BE132
		Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs)
			Binning.ReleaseCapture()
			Binning.SendMessage(MyBase.Handle, 274, 61458, 0)
		End Sub

		' Token: 0x060014F8 RID: 5368 RVA: 0x000BFF54 File Offset: 0x000BE154
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
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
		End Sub

		' Token: 0x060014F9 RID: 5369 RVA: 0x000BFFF1 File Offset: 0x000BE1F1
		Private Sub form_btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x060014FA RID: 5370 RVA: 0x000BFFFC File Offset: 0x000BE1FC
		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x060014FB RID: 5371 RVA: 0x000C0031 File Offset: 0x000BE231
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Me.SetForm()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x060014FC RID: 5372 RVA: 0x000C0054 File Offset: 0x000BE254
		Private Sub SetForm()
			Me.dtDtls = New DataTable() With { .Columns = { { "SrNo", Type.[GetType]("System.String") }, { "CatalogNo", Type.[GetType]("System.String") }, { "ProductBarcode", Type.[GetType]("System.String") }, { "OldLocation", Type.[GetType]("System.String") }, { "NewLocation", Type.[GetType]("System.String") }, { "OldLocationCode", Type.[GetType]("System.String") }, { "LocationCode", Type.[GetType]("System.String") }, { "IsBinningAlert", Type.[GetType]("System.String") } } }
			Me.dgvDtls.DataSource = Me.dtDtls
			Me.txtLocation.Focus()
		End Sub

		' Token: 0x060014FD RID: 5373 RVA: 0x000C0168 File Offset: 0x000BE368
		Private Sub EnableDisable(sType As String)
			Dim flag As Boolean = Operators.CompareString(sType, "Enable", False) = 0
			If flag Then
				Me.txtLocation.[ReadOnly] = False
				Me.txtBarcode.[ReadOnly] = False
				Me.sml_btnAdd.Enabled = True
				Me.btnSave.Enabled = True
				Me.btnClear.Enabled = True
				Me.dgvDtls.Enabled = True
			Else
				Me.txtLocation.[ReadOnly] = True
				Me.txtBarcode.[ReadOnly] = True
				Me.sml_btnAdd.Enabled = False
				Me.btnSave.Enabled = False
				Me.btnClear.Enabled = False
				Me.dgvDtls.Enabled = False
			End If
		End Sub

		' Token: 0x060014FE RID: 5374 RVA: 0x000C022C File Offset: 0x000BE42C
		Private Sub btnClear_Click(sender As Object, e As EventArgs)
			Me.txtLocation.Text = ""
			Me.txtBarcode.Text = ""
			Me.lblRows.Text = "0 - Row(s)"
			Me.SetForm()
			Me.EnableDisable("Enable")
		End Sub

		' Token: 0x060014FF RID: 5375 RVA: 0x000C0280 File Offset: 0x000BE480
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06001500 RID: 5376 RVA: 0x000C028C File Offset: 0x000BE48C
		Private Function ValidateLocationCode() As Boolean
			Dim flag As Boolean = Strings.Trim(Me.txtLocation.Text).Length = 10
			If flag Then
				Dim flag2 As Boolean = (Operators.CompareString(Strings.Mid(Strings.Trim(Me.txtLocation.Text), 1, 3), "IAL", False) = 0) And Versioned.IsNumeric(Strings.Mid(Strings.Trim(Me.txtLocation.Text), 7, 4))
				If flag2 Then
					Return True
				End If
			End If
			Me.txtLocation.Focus()
			Return False
		End Function

		' Token: 0x06001501 RID: 5377 RVA: 0x000C0318 File Offset: 0x000BE518
		Private Sub txtLocation_KeyDown(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.txtLocation.Text), "", False) <> 0
			If flag Then
				Dim flag2 As Boolean = e.KeyCode = Keys.[Return]
				If flag2 Then
					Dim flag3 As Boolean = Me.ValidateLocationCode()
					If flag3 Then
						Me.txtBarcode.Focus()
					Else
						CustomMsgBox.Show("Invalid Location Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					End If
				End If
			End If
		End Sub

		' Token: 0x06001502 RID: 5378 RVA: 0x000C0388 File Offset: 0x000BE588
		Private Function ValidateProductBarcode() As Boolean
			Dim flag As Boolean = Me.dtDtls.[Select]("ProductBarcode = '" + Strings.Trim(Me.txtBarcode.Text) + "'").Length > 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Product Barcode Already In The List.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.txtBarcode.Focus()
				flag2 = False
			Else
				Dim flag3 As Boolean = (Strings.Trim(Me.txtBarcode.Text).Length = 10) Or (Strings.Trim(Me.txtBarcode.Text).Length = 9)
				If flag3 Then
					Dim flag4 As Boolean = (Operators.CompareString(Strings.Mid(Strings.Trim(Me.txtBarcode.Text), 1, 2), "IA", False) = 0) And Versioned.IsNumeric(Strings.Mid(Strings.Trim(Me.txtBarcode.Text), 6))
					If flag4 Then
						Return True
					End If
				End If
				CustomMsgBox.Show("Invalid Product Barcode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.txtBarcode.Focus()
				flag2 = False
			End If
			Return flag2
		End Function

		' Token: 0x06001503 RID: 5379 RVA: 0x000C0498 File Offset: 0x000BE698
		Private Sub txtBarcode_KeyDown(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = (Operators.CompareString(Me.txtLocation.Text, "", False) <> 0) And (Operators.CompareString(Me.txtBarcode.Text, "", False) <> 0)
			If flag Then
				Dim flag2 As Boolean = e.KeyCode = Keys.[Return]
				If flag2 Then
					Me.AddBarcode()
				End If
			End If
		End Sub

		' Token: 0x06001504 RID: 5380 RVA: 0x000C04F6 File Offset: 0x000BE6F6
		Private Sub sml_btnAdd_Click(sender As Object, e As EventArgs)
			Me.AddBarcode()
		End Sub

		' Token: 0x06001505 RID: 5381 RVA: 0x000C0500 File Offset: 0x000BE700
		Private Sub AddBarcode()
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = Me.ValidateLocationCode() And Me.ValidateProductBarcode()
				If flag Then
					Dim text As String = " SELECT P.CatalogNo, UID, ParentUID, GU.LocationCode, L.LocationName, " & vbCrLf
					text += " ISNULL(IsBinningAlert,0) IsBinningAlert " & vbCrLf
					text += " FROM GRNUID GU INNER JOIN Product P ON GU.ProductID = P.ProductID " & vbCrLf
					text += " LEFT JOIN Location L ON GU.LocationCode = L.LocationCode " & vbCrLf
					text = String.Concat(New String() { text, " WHERE (UID = '", Strings.Trim(Me.txtBarcode.Text), "' OR ParentUID = '", Strings.Trim(Me.txtBarcode.Text), "') " & vbCrLf })
					Dim data As DataTable = MainModule.GetData(text)
					Dim flag2 As Boolean = data.Rows.Count = 0
					If flag2 Then
						CustomMsgBox.Show("Invalid Product Barcode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.txtBarcode.Focus()
					Else
						text = " SELECT LocationID, LocationSrNo, LocationCode, LocationName, Description " & vbCrLf
						text += " FROM Location " & vbCrLf
						text = text + " WHERE LocationCode = '" + Strings.Trim(Me.txtLocation.Text) + "'" & vbCrLf
						Dim data2 As DataTable = MainModule.GetData(text)
						Dim flag3 As Boolean = data2.Rows.Count = 0
						If flag3 Then
							CustomMsgBox.Show("Invalid Location Barcode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.txtLocation.Focus()
						Else
							Me.dtDtls.Rows.Add(New Object(-1) {})
							Me.dtDtls.Rows(Me.dtDtls.Rows.Count - 1)("SrNo") = Me.dtDtls.Rows.Count
							Me.dtDtls.Rows(Me.dtDtls.Rows.Count - 1)("CatalogNo") = data.Rows(0)("CatalogNo").ToString()
							Me.dtDtls.Rows(Me.dtDtls.Rows.Count - 1)("OldLocation") = data.Rows(0)("LocationName").ToString()
							Me.dtDtls.Rows(Me.dtDtls.Rows.Count - 1)("OldLocationCode") = data.Rows(0)("LocationCode").ToString()
							Me.dtDtls.Rows(Me.dtDtls.Rows.Count - 1)("NewLocation") = data2.Rows(0)("LocationName").ToString()
							Me.dtDtls.Rows(Me.dtDtls.Rows.Count - 1)("LocationCode") = data2.Rows(0)("LocationCode").ToString()
							Me.dtDtls.Rows(Me.dtDtls.Rows.Count - 1)("ProductBarcode") = Strings.Trim(Me.txtBarcode.Text)
							Me.dtDtls.Rows(Me.dtDtls.Rows.Count - 1)("IsBinningAlert") = data.Rows(0)("IsBinningAlert").ToString()
							Me.txtBarcode.Text = ""
							Me.txtBarcode.Focus()
							Me.lblRows.Text = Conversions.ToString(Me.dgvDtls.Rows.Count) + " - Row(s)"
							Me.dgvDtls.DataSource = Me.dtDtls
						End If
					End If
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06001506 RID: 5382 RVA: 0x000C0940 File Offset: 0x000BEB40
		Private Sub dgvDtls_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = e.RowIndex > -1
			If flag Then
				Dim array As DataRow() = Me.dtDtls.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SrNo = '", Me.dgvDtls.Rows(e.RowIndex).Cells("SrNo").Value), "'")))
				Dim flag2 As Boolean = array.Length = 1
				If flag2 Then
					Dim text As String = Me.dgvDtls.Columns(e.ColumnIndex).Name.ToString()
					If Operators.CompareString(text, "btnDelete_File", False) = 0 Then
						Me.dtDtls.Rows.Remove(array(0))
						Me.dgvDtls.DataSource = Me.dtDtls
						Me.lblRows.Text = Conversions.ToString(Me.dgvDtls.Rows.Count) + " - Row(s)"
					End If
				End If
			End If
		End Sub

		' Token: 0x06001507 RID: 5383 RVA: 0x000C0A48 File Offset: 0x000BEC48
		Private Function ValidateForm() As Boolean
			Dim flag As Boolean = Me.dtDtls.Rows.Count = 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("No Data To Save.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.txtLocation.Focus()
				flag2 = False
			Else
				Dim text As String = ""
				Dim dataTable As DataTable = Me.dtDtls.DefaultView.ToTable(True, New String() { "LocationCode" })
				Dim num As Integer = dataTable.Rows.Count - 1
				For i As Integer = 0 To num
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("'", dataTable.Rows(i)("LocationCode")), "',")))
				Next
				Dim text2 As String = " SELECT LocationCode FROM Location WHERE LocationCode IN (" + Strings.Mid(text, 1, text.Length - 1) + ") "
				Dim data As DataTable = MainModule.GetData(text2)
				Dim num2 As Integer = Me.dtDtls.Rows.Count - 1
				For j As Integer = 0 To num2
					Dim flag3 As Boolean = data.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("LocationCode = '", Me.dtDtls.Rows(j)("LocationCode")), "'"))).Length = 0
					If flag3 Then
						CustomMsgBox.Show("Invalid Location Code.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.dgvDtls.ClearSelection()
						Me.dgvDtls.Rows(j).Cells("NewLocationCode").Selected = True
						Return False
					End If
				Next
				flag2 = True
			End If
			Return flag2
		End Function

		' Token: 0x06001508 RID: 5384 RVA: 0x000C0C00 File Offset: 0x000BEE00
		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.Save()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnSave.Enabled = True
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06001509 RID: 5385 RVA: 0x000C0C7C File Offset: 0x000BEE7C
		Private Sub Save()
			Dim flag As Boolean = CustomMsgBox.Show("Save..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
			If flag Then
				Dim flag2 As Boolean = Not Me.ValidateForm()
				If Not flag2 Then
					Dim sqlConnection As SqlConnection = New SqlConnection(GlobalVariables.gsConStr)
					sqlConnection.Open()
					Dim sqlTransaction As SqlTransaction = sqlConnection.BeginTransaction(IsolationLevel.Serializable)
					Try
						Dim flag3 As Boolean = MainModule.SetDBTableLock("LocationMapping", sqlConnection, sqlTransaction) = 0
						If flag3 Then
							Interaction.MsgBox("Server Buss, Try After Sometime.", MsgBoxStyle.Critical, "Critical")
							sqlTransaction.Rollback()
							sqlConnection.Close()
						Else
							Me.EnableDisable("Disable")
							Dim text As String = " DELETE FROM LocationMapping "
							Dim flag4 As Boolean = MainModule.ExecuteSQL(text, sqlConnection, sqlTransaction) = 1
							If flag4 Then
								Dim dataTable As DataTable = Me.dtDtls.Copy()
								dataTable.Columns.Remove("SrNo")
								dataTable.Columns.Remove("CatalogNo")
								dataTable.Columns.Remove("OldLocation")
								dataTable.Columns.Remove("NewLocation")
								dataTable.Columns.Remove("OldLocationCode")
								dataTable.Columns.Remove("IsBinningAlert")
								MainModule.BulkInsertTemp(dataTable, "LocationMapping", sqlConnection, sqlTransaction)
								text = " UPDATE GRNUID SET LocationCode = LM.LocationCode "
								text += " FROM GRNUID AS GU INNER JOIN LocationMapping LM ON "
								text += " GU.UID = LM.ProductBarcode OR GU.ParentUID = LM.ProductBarcode"
								text += " "
								Dim flag5 As Boolean = MainModule.ExecuteSQL(text, sqlConnection, sqlTransaction) = 1
								If flag5 Then
									sqlTransaction.Commit()
									sqlConnection.Close()
									Dim mappingList As String = Me.GetMappingList(dataTable)
									MainModule.TrnLog(Me.Text, "Location Mapped", mappingList, Nothing)
									Me.SendMail()
									CustomMsgBox.Show("Location Mapping Complete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
									Return
								End If
							End If
							Me.EnableDisable("Enable")
							sqlTransaction.Rollback()
							sqlConnection.Close()
						End If
					Catch ex As Exception
						Dim flag6 As Boolean = (Strings.InStr(ex.Message, "Timeout expired", CompareMethod.Binary) > 0) Or (Strings.InStr(ex.Message, "Violation of PRIMARY KEY constraint", CompareMethod.Binary) > 0)
						If flag6 Then
							CustomMsgBox.Show("Server Busy Try Again : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Else
							CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						End If
						sqlTransaction.Rollback()
						sqlConnection.Close()
						Me.EnableDisable("Enable")
					End Try
				End If
			End If
		End Sub

		' Token: 0x0600150A RID: 5386 RVA: 0x000C0F28 File Offset: 0x000BF128
		Private Function GetMappingList(dt As DataTable) As String
			Dim text As String = ""
			Dim num As Integer = dt.Rows.Count - 1
			For i As Integer = 0 To num
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dt.Rows(i)("ProductBarcode"), " => "), dt.Rows(i)("LocationCode")), vbCrLf)))
			Next
			Return text
		End Function

		' Token: 0x0600150B RID: 5387 RVA: 0x000C0FAC File Offset: 0x000BF1AC
		Private Sub SendMail()
			Dim dataView As DataView = New DataView(Me.dtDtls, "IsBinningAlert = 'True'", "", DataViewRowState.CurrentRows)
			Dim dataTable As DataTable = dataView.ToTable()
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				EmailModule.Send_Binning_MailAlert(dataTable, "")
			End If
		End Sub

		' Token: 0x040008F6 RID: 2294
		Private dtDtls As DataTable
	End Class
End Namespace
