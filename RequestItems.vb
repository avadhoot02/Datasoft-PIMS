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
	' Token: 0x0200006B RID: 107
	<DesignerGenerated()>
	Public Partial Class RequestItems
		Inherits Form

		' Token: 0x17000B2F RID: 2863
		' (get) Token: 0x06001CC2 RID: 7362 RVA: 0x0010ED08 File Offset: 0x0010CF08
		' (set) Token: 0x06001CC3 RID: 7363 RVA: 0x0010ED12 File Offset: 0x0010CF12
		Friend Overridable Property pnlBorder As Panel

		' Token: 0x17000B30 RID: 2864
		' (get) Token: 0x06001CC4 RID: 7364 RVA: 0x0010ED1B File Offset: 0x0010CF1B
		' (set) Token: 0x06001CC5 RID: 7365 RVA: 0x0010ED25 File Offset: 0x0010CF25
		Friend Overridable Property pnlMain As Panel

		' Token: 0x17000B31 RID: 2865
		' (get) Token: 0x06001CC6 RID: 7366 RVA: 0x0010ED2E File Offset: 0x0010CF2E
		' (set) Token: 0x06001CC7 RID: 7367 RVA: 0x0010ED38 File Offset: 0x0010CF38
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

		' Token: 0x17000B32 RID: 2866
		' (get) Token: 0x06001CC8 RID: 7368 RVA: 0x0010ED7B File Offset: 0x0010CF7B
		' (set) Token: 0x06001CC9 RID: 7369 RVA: 0x0010ED85 File Offset: 0x0010CF85
		Friend Overridable Property picFormIcon As PictureBox

		' Token: 0x17000B33 RID: 2867
		' (get) Token: 0x06001CCA RID: 7370 RVA: 0x0010ED8E File Offset: 0x0010CF8E
		' (set) Token: 0x06001CCB RID: 7371 RVA: 0x0010ED98 File Offset: 0x0010CF98
		Friend Overridable Property lblCaption As Label

		' Token: 0x17000B34 RID: 2868
		' (get) Token: 0x06001CCC RID: 7372 RVA: 0x0010EDA1 File Offset: 0x0010CFA1
		' (set) Token: 0x06001CCD RID: 7373 RVA: 0x0010EDAC File Offset: 0x0010CFAC
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

		' Token: 0x17000B35 RID: 2869
		' (get) Token: 0x06001CCE RID: 7374 RVA: 0x0010EDEF File Offset: 0x0010CFEF
		' (set) Token: 0x06001CCF RID: 7375 RVA: 0x0010EDF9 File Offset: 0x0010CFF9
		Friend Overridable Property lblShadow1 As Label

		' Token: 0x17000B36 RID: 2870
		' (get) Token: 0x06001CD0 RID: 7376 RVA: 0x0010EE02 File Offset: 0x0010D002
		' (set) Token: 0x06001CD1 RID: 7377 RVA: 0x0010EE0C File Offset: 0x0010D00C
		Friend Overridable Property lblShadow2 As Label

		' Token: 0x17000B37 RID: 2871
		' (get) Token: 0x06001CD2 RID: 7378 RVA: 0x0010EE15 File Offset: 0x0010D015
		' (set) Token: 0x06001CD3 RID: 7379 RVA: 0x0010EE1F File Offset: 0x0010D01F
		Friend Overridable Property Label1 As Label

		' Token: 0x17000B38 RID: 2872
		' (get) Token: 0x06001CD4 RID: 7380 RVA: 0x0010EE28 File Offset: 0x0010D028
		' (set) Token: 0x06001CD5 RID: 7381 RVA: 0x0010EE32 File Offset: 0x0010D032
		Friend Overridable Property txtDesc As TextBox

		' Token: 0x17000B39 RID: 2873
		' (get) Token: 0x06001CD6 RID: 7382 RVA: 0x0010EE3B File Offset: 0x0010D03B
		' (set) Token: 0x06001CD7 RID: 7383 RVA: 0x0010EE45 File Offset: 0x0010D045
		Friend Overridable Property Label12 As Label

		' Token: 0x17000B3A RID: 2874
		' (get) Token: 0x06001CD8 RID: 7384 RVA: 0x0010EE4E File Offset: 0x0010D04E
		' (set) Token: 0x06001CD9 RID: 7385 RVA: 0x0010EE58 File Offset: 0x0010D058
		Friend Overridable Property txtAvlQty As TextBox

		' Token: 0x17000B3B RID: 2875
		' (get) Token: 0x06001CDA RID: 7386 RVA: 0x0010EE61 File Offset: 0x0010D061
		' (set) Token: 0x06001CDB RID: 7387 RVA: 0x0010EE6C File Offset: 0x0010D06C
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

		' Token: 0x17000B3C RID: 2876
		' (get) Token: 0x06001CDC RID: 7388 RVA: 0x0010EEAF File Offset: 0x0010D0AF
		' (set) Token: 0x06001CDD RID: 7389 RVA: 0x0010EEBC File Offset: 0x0010D0BC
		Friend Overridable Property btnDelete As Button
			<CompilerGenerated()>
			Get
				Return Me._btnDelete
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnDelete_Click
				Dim button As Button = Me._btnDelete
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnDelete = value
				button = Me._btnDelete
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000B3D RID: 2877
		' (get) Token: 0x06001CDE RID: 7390 RVA: 0x0010EEFF File Offset: 0x0010D0FF
		' (set) Token: 0x06001CDF RID: 7391 RVA: 0x0010EF0C File Offset: 0x0010D10C
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

		' Token: 0x17000B3E RID: 2878
		' (get) Token: 0x06001CE0 RID: 7392 RVA: 0x0010EF4F File Offset: 0x0010D14F
		' (set) Token: 0x06001CE1 RID: 7393 RVA: 0x0010EF59 File Offset: 0x0010D159
		Friend Overridable Property Label2 As Label

		' Token: 0x17000B3F RID: 2879
		' (get) Token: 0x06001CE2 RID: 7394 RVA: 0x0010EF62 File Offset: 0x0010D162
		' (set) Token: 0x06001CE3 RID: 7395 RVA: 0x0010EF6C File Offset: 0x0010D16C
		Friend Overridable Property txtReqQty As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtReqQty
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim keyEventHandler As KeyEventHandler = AddressOf Me.txtReqQty_KeyDown
				Dim textBox As TextBox = Me._txtReqQty
				If textBox IsNot Nothing Then
					RemoveHandler textBox.KeyDown, keyEventHandler
				End If
				Me._txtReqQty = value
				textBox = Me._txtReqQty
				If textBox IsNot Nothing Then
					AddHandler textBox.KeyDown, keyEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000B40 RID: 2880
		' (get) Token: 0x06001CE4 RID: 7396 RVA: 0x0010EFAF File Offset: 0x0010D1AF
		' (set) Token: 0x06001CE5 RID: 7397 RVA: 0x0010EFBC File Offset: 0x0010D1BC
		Friend Overridable Property cmbType As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbType
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbType_SelectedIndexChanged
				Dim comboBox As ComboBox = Me._cmbType
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.SelectedIndexChanged, eventHandler
				End If
				Me._cmbType = value
				comboBox = Me._cmbType
				If comboBox IsNot Nothing Then
					AddHandler comboBox.SelectedIndexChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000B41 RID: 2881
		' (get) Token: 0x06001CE6 RID: 7398 RVA: 0x0010EFFF File Offset: 0x0010D1FF
		' (set) Token: 0x06001CE7 RID: 7399 RVA: 0x0010F009 File Offset: 0x0010D209
		Friend Overridable Property Label18 As Label

		' Token: 0x17000B42 RID: 2882
		' (get) Token: 0x06001CE8 RID: 7400 RVA: 0x0010F012 File Offset: 0x0010D212
		' (set) Token: 0x06001CE9 RID: 7401 RVA: 0x0010F01C File Offset: 0x0010D21C
		Friend Overridable Property cmbProduct As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbProduct
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbProduct_Validated
				Dim comboBox As ComboBox = Me._cmbProduct
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.Validated, eventHandler
				End If
				Me._cmbProduct = value
				comboBox = Me._cmbProduct
				If comboBox IsNot Nothing Then
					AddHandler comboBox.Validated, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000B43 RID: 2883
		' (get) Token: 0x06001CEA RID: 7402 RVA: 0x0010F05F File Offset: 0x0010D25F
		' (set) Token: 0x06001CEB RID: 7403 RVA: 0x0010F069 File Offset: 0x0010D269
		Friend Overridable Property Label9 As Label

		' Token: 0x17000B44 RID: 2884
		' (get) Token: 0x06001CEC RID: 7404 RVA: 0x0010F072 File Offset: 0x0010D272
		' (set) Token: 0x06001CED RID: 7405 RVA: 0x0010F07C File Offset: 0x0010D27C
		Friend Overridable Property txtCatalogNo As TextBox

		' Token: 0x17000B45 RID: 2885
		' (get) Token: 0x06001CEE RID: 7406 RVA: 0x0010F085 File Offset: 0x0010D285
		' (set) Token: 0x06001CEF RID: 7407 RVA: 0x0010F08F File Offset: 0x0010D28F
		Friend Overridable Property Label4 As Label

		' Token: 0x17000B46 RID: 2886
		' (get) Token: 0x06001CF0 RID: 7408 RVA: 0x0010F098 File Offset: 0x0010D298
		' (set) Token: 0x06001CF1 RID: 7409 RVA: 0x0010F0A2 File Offset: 0x0010D2A2
		Friend Overridable Property txtID As TextBox

		' Token: 0x17000B47 RID: 2887
		' (get) Token: 0x06001CF2 RID: 7410 RVA: 0x0010F0AB File Offset: 0x0010D2AB
		' (set) Token: 0x06001CF3 RID: 7411 RVA: 0x0010F0B5 File Offset: 0x0010D2B5
		Friend Overridable Property Label19 As Label

		' Token: 0x17000B48 RID: 2888
		' (get) Token: 0x06001CF4 RID: 7412 RVA: 0x0010F0BE File Offset: 0x0010D2BE
		' (set) Token: 0x06001CF5 RID: 7413 RVA: 0x0010F0C8 File Offset: 0x0010D2C8
		Friend Overridable Property txtProductName As TextBox

		' Token: 0x17000B49 RID: 2889
		' (get) Token: 0x06001CF6 RID: 7414 RVA: 0x0010F0D1 File Offset: 0x0010D2D1
		' (set) Token: 0x06001CF7 RID: 7415 RVA: 0x0010F0DB File Offset: 0x0010D2DB
		Friend Overridable Property Label20 As Label

		' Token: 0x17000B4A RID: 2890
		' (get) Token: 0x06001CF8 RID: 7416 RVA: 0x0010F0E4 File Offset: 0x0010D2E4
		' (set) Token: 0x06001CF9 RID: 7417 RVA: 0x0010F0EE File Offset: 0x0010D2EE
		Friend Overridable Property txtPrimaryUOM As TextBox

		' Token: 0x17000B4B RID: 2891
		' (get) Token: 0x06001CFA RID: 7418 RVA: 0x0010F0F7 File Offset: 0x0010D2F7
		' (set) Token: 0x06001CFB RID: 7419 RVA: 0x0010F101 File Offset: 0x0010D301
		Friend Overridable Property txtPrimaryPackSize As TextBox

		' Token: 0x17000B4C RID: 2892
		' (get) Token: 0x06001CFC RID: 7420 RVA: 0x0010F10A File Offset: 0x0010D30A
		' (set) Token: 0x06001CFD RID: 7421 RVA: 0x0010F114 File Offset: 0x0010D314
		Friend Overridable Property Label17 As Label

		' Token: 0x17000B4D RID: 2893
		' (get) Token: 0x06001CFE RID: 7422 RVA: 0x0010F11D File Offset: 0x0010D31D
		' (set) Token: 0x06001CFF RID: 7423 RVA: 0x0010F127 File Offset: 0x0010D327
		Friend Overridable Property Label14 As Label

		' Token: 0x17000B4E RID: 2894
		' (get) Token: 0x06001D00 RID: 7424 RVA: 0x0010F130 File Offset: 0x0010D330
		' (set) Token: 0x06001D01 RID: 7425 RVA: 0x0010F13A File Offset: 0x0010D33A
		Friend Overridable Property txtTertiaryPackSize As TextBox

		' Token: 0x17000B4F RID: 2895
		' (get) Token: 0x06001D02 RID: 7426 RVA: 0x0010F143 File Offset: 0x0010D343
		' (set) Token: 0x06001D03 RID: 7427 RVA: 0x0010F14D File Offset: 0x0010D34D
		Friend Overridable Property Label5 As Label

		' Token: 0x17000B50 RID: 2896
		' (get) Token: 0x06001D04 RID: 7428 RVA: 0x0010F156 File Offset: 0x0010D356
		' (set) Token: 0x06001D05 RID: 7429 RVA: 0x0010F160 File Offset: 0x0010D360
		Friend Overridable Property txtTertiaryUOM As TextBox

		' Token: 0x17000B51 RID: 2897
		' (get) Token: 0x06001D06 RID: 7430 RVA: 0x0010F169 File Offset: 0x0010D369
		' (set) Token: 0x06001D07 RID: 7431 RVA: 0x0010F173 File Offset: 0x0010D373
		Friend Overridable Property Label8 As Label

		' Token: 0x17000B52 RID: 2898
		' (get) Token: 0x06001D08 RID: 7432 RVA: 0x0010F17C File Offset: 0x0010D37C
		' (set) Token: 0x06001D09 RID: 7433 RVA: 0x0010F186 File Offset: 0x0010D386
		Friend Overridable Property Label7 As Label

		' Token: 0x17000B53 RID: 2899
		' (get) Token: 0x06001D0A RID: 7434 RVA: 0x0010F18F File Offset: 0x0010D38F
		' (set) Token: 0x06001D0B RID: 7435 RVA: 0x0010F199 File Offset: 0x0010D399
		Friend Overridable Property Label6 As Label

		' Token: 0x17000B54 RID: 2900
		' (get) Token: 0x06001D0C RID: 7436 RVA: 0x0010F1A2 File Offset: 0x0010D3A2
		' (set) Token: 0x06001D0D RID: 7437 RVA: 0x0010F1AC File Offset: 0x0010D3AC
		Friend Overridable Property Label3 As Label

		' Token: 0x17000B55 RID: 2901
		' (get) Token: 0x06001D0E RID: 7438 RVA: 0x0010F1B5 File Offset: 0x0010D3B5
		' (set) Token: 0x06001D0F RID: 7439 RVA: 0x0010F1C0 File Offset: 0x0010D3C0
		Friend Overridable Property txtReqQtyTer As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtReqQtyTer
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim eventHandler As EventHandler = AddressOf Me.txtReqQtyTer_TextChanged
				Dim textBox As TextBox = Me._txtReqQtyTer
				If textBox IsNot Nothing Then
					RemoveHandler textBox.TextChanged, eventHandler
				End If
				Me._txtReqQtyTer = value
				textBox = Me._txtReqQtyTer
				If textBox IsNot Nothing Then
					AddHandler textBox.TextChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000B56 RID: 2902
		' (get) Token: 0x06001D10 RID: 7440 RVA: 0x0010F203 File Offset: 0x0010D403
		' (set) Token: 0x06001D11 RID: 7441 RVA: 0x0010F20D File Offset: 0x0010D40D
		Friend Overridable Property txtPickedQty As TextBox

		' Token: 0x17000B57 RID: 2903
		' (get) Token: 0x06001D12 RID: 7442 RVA: 0x0010F216 File Offset: 0x0010D416
		' (set) Token: 0x06001D13 RID: 7443 RVA: 0x0010F220 File Offset: 0x0010D420
		Friend Overridable Property txtIssuedQty As TextBox

		' Token: 0x06001D14 RID: 7444
		Private Declare Sub SendMessage Lib "user32.DLL" (hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

		' Token: 0x06001D15 RID: 7445
		Private Declare Sub ReleaseCapture Lib "user32.DLL" ()

		' Token: 0x06001D16 RID: 7446 RVA: 0x0010F229 File Offset: 0x0010D429
		Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs)
			RequestItems.ReleaseCapture()
			RequestItems.SendMessage(MyBase.Handle, 274, 61458, 0)
		End Sub

		' Token: 0x06001D17 RID: 7447 RVA: 0x0010F24C File Offset: 0x0010D44C
		Public Sub New(iR As Integer, Status As String, dt As DataTable, MfgProductID As String, MfgProductType As String, IsBOM As Boolean)
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
			Me.iRow = iR
			Me.sStatus = Status
			Me.dtItems = dt
			Me.sMfgProductID = MfgProductID
			Me.sMfgProductType = MfgProductType
			Me.IsBOMFilled = IsBOM
		End Sub

		' Token: 0x06001D18 RID: 7448 RVA: 0x0010F303 File Offset: 0x0010D503
		Private Sub form_btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06001D19 RID: 7449 RVA: 0x0010F30D File Offset: 0x0010D50D
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Me.ClearForm()
			Me.FillData()
			Me.SetForm()
		End Sub

		' Token: 0x06001D1A RID: 7450 RVA: 0x0010F328 File Offset: 0x0010D528
		Private Sub ClearForm()
			Me.cmbProduct.Text = ""
			Me.cmbProduct.SelectedIndex = -1
			Me.txtDesc.Text = ""
			Me.txtCatalogNo.Text = ""
			Me.txtTertiaryUOM.Text = ""
			Me.txtTertiaryPackSize.Text = ""
			Me.txtPrimaryUOM.Text = ""
			Me.txtPrimaryPackSize.Text = ""
			Me.txtAvlQty.Text = ""
			Me.txtReqQty.Text = ""
			Me.txtReqQtyTer.Text = ""
		End Sub

		' Token: 0x06001D1B RID: 7451 RVA: 0x0010F3ED File Offset: 0x0010D5ED
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.DialogResult = DialogResult.Cancel
			MyBase.Close()
		End Sub

		' Token: 0x06001D1C RID: 7452 RVA: 0x0010F400 File Offset: 0x0010D600
		Private Sub FillData()
			Dim flag As Boolean = Me.iRow <> -1
			If flag Then
				Me.cmbType.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("ProductType"))
				Me.FillProduct()
				Me.cmbProduct.SelectedValue = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(Me.iRow)("ProductID"))
				Me.FillProductDetails()
				Me.txtDesc.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("Description"))
				Me.txtReqQty.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("RequiredQty"))
				Me.txtPickedQty.Text = Me.dtItems.Rows(Me.iRow)("PickedQty").ToString()
				Me.txtIssuedQty.Text = Me.dtItems.Rows(Me.iRow)("IssuedQty").ToString()
				Dim flag2 As Boolean = Me.IsBOMFilled And (Strings.InStr(GlobalVariables.gsUserGroup.ToLower(), "admin", CompareMethod.Binary) = 0)
				If flag2 Then
					Me.cmbType.Enabled = False
					Me.cmbProduct.Enabled = False
					Me.txtReqQty.Enabled = False
					Me.txtReqQtyTer.Enabled = False
					Me.btnDelete.Enabled = False
				End If
			End If
		End Sub

		' Token: 0x06001D1D RID: 7453 RVA: 0x0010F5C0 File Offset: 0x0010D7C0
		Private Sub SetForm()
			Dim flag As Boolean = Me.iRow = -1
			If flag Then
				Me.btnDelete.Enabled = False
			End If
			Dim text As String = Me.sStatus
			If Operators.CompareString(text, "New Request", False) <> 0 Then
				If Operators.CompareString(text, "Request Generated", False) <> 0 Then
					Me.cmbType.Enabled = False
					Me.cmbProduct.Enabled = False
					Dim flag2 As Boolean = Strings.InStr(GlobalVariables.gsUserGroup.ToLower(), "admin", CompareMethod.Binary) = 0
					If flag2 Then
						Me.btnSave.Enabled = False
						Me.btnDelete.Enabled = False
					End If
					Dim flag3 As Boolean = (Conversion.Val(Me.txtPickedQty.Text) > 0.0) Or (Conversion.Val(Me.txtIssuedQty.Text) > 0.0)
					If flag3 Then
						Me.btnSave.Enabled = False
						Me.btnDelete.Enabled = False
					End If
				End If
			End If
			Dim text2 As String = Me.sMfgProductType
			If Operators.CompareString(text2, "Finished Goods", False) <> 0 Then
				If Operators.CompareString(text2, "Semi Finished", False) <> 0 Then
					If Operators.CompareString(text2, "Cell Bank - Mammalian", False) = 0 OrElse Operators.CompareString(text2, "Cell Bank - Bacterial", False) = 0 Then
						Me.cmbType.Items.Clear()
						Me.cmbType.Items.Add("Raw Material")
						Me.cmbType.Items.Add("Packaging Material")
						Me.cmbType.Items.Add("Consumable")
						Me.cmbType.Items.Add("Others")
					End If
				End If
			End If
			AddHandler Me.txtReqQtyTer.KeyDown, AddressOf Me.Keydown_Numeric
		End Sub

		' Token: 0x06001D1E RID: 7454 RVA: 0x0010F79C File Offset: 0x0010D99C
		Private Sub Keydown_Numeric(sender As Object, e As KeyEventArgs)
			Dim keyCode As Keys = e.KeyCode
			Dim flag As Boolean = (keyCode >= Keys.D0 AndAlso keyCode <= Keys.D9) OrElse (keyCode >= Keys.NumPad0 AndAlso keyCode <= Keys.NumPad9) OrElse keyCode = Keys.Back
			If Not flag Then
				e.SuppressKeyPress = True
			End If
		End Sub

		' Token: 0x06001D1F RID: 7455 RVA: 0x0010F7DC File Offset: 0x0010D9DC
		Private Sub txtReqQty_KeyDown(sender As Object, e As KeyEventArgs)
			Dim keyCode As Keys = e.KeyCode
			Dim flag As Boolean = (keyCode >= Keys.D0 AndAlso keyCode <= Keys.D9) OrElse (keyCode >= Keys.NumPad0 AndAlso keyCode <= Keys.NumPad9) OrElse keyCode = Keys.Back
			If Not flag Then
				flag = keyCode = Keys.[Return]
				If flag Then
					Dim flag2 As Boolean = Conversion.Val(Me.txtReqQty.Text) > 0.0
					If flag2 Then
						Me.txtReqQtyTer.Text = Conversions.ToString(Conversion.Val(Me.txtReqQty.Text) / Conversion.Val(Me.txtTertiaryPackSize.Text))
					Else
						Me.txtReqQtyTer.Text = ""
					End If
				Else
					e.SuppressKeyPress = True
				End If
			End If
		End Sub

		' Token: 0x06001D20 RID: 7456 RVA: 0x0010F890 File Offset: 0x0010DA90
		Private Sub txtReqQtyTer_TextChanged(sender As Object, e As EventArgs)
			Me.txtReqQty.Text = ""
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.txtReqQtyTer.Text), "", False) <> 0
			If flag Then
				Dim flag2 As Boolean = Conversion.Val(Me.txtReqQtyTer.Text) > 0.0
				If flag2 Then
					Me.txtReqQty.Text = Conversions.ToString(Conversion.Val(Me.txtReqQtyTer.Text) * Conversion.Val(Me.txtTertiaryPackSize.Text))
				End If
			End If
		End Sub

		' Token: 0x06001D21 RID: 7457 RVA: 0x0010F928 File Offset: 0x0010DB28
		Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.cmbType.Text, "", False) <> 0
			If flag Then
				Me.FillProduct()
			Else
				Me.cmbProduct.DataSource = Nothing
			End If
			Me.ClearForm()
		End Sub

		' Token: 0x06001D22 RID: 7458 RVA: 0x0010F974 File Offset: 0x0010DB74
		Private Sub FillProduct()
			Dim text As String = " SELECT P.ProductID, ProductCode, ProductName, ProductType, CatalogNo, " & vbCrLf
			text += " TertiaryUOM, TertiaryPackSize, PrimaryUOM, PrimaryPackSize, AvlQty " & vbCrLf
			text += " FROM Product P LEFT OUTER JOIN " & vbCrLf
			text += "   (SELECT ProductID, " & vbCrLf
			text += "    SUM(CASE WHEN ISNULL(ExpDt,'01/01/2050') > GETDATE() AND Status = 'Available' THEN 1 ELSE 0 END) AS AvlQty" & vbCrLf
			text += "    FROM GRNUID  GROUP BY ProductID ) U ON P.ProductID = U.ProductID " & vbCrLf
			text = String.Concat(New String() { text, " WHERE Status = 'Approved' AND ProductType IN ('", Me.cmbType.Text, "') AND P.ProductID <> '", Me.sMfgProductID, "'" & vbCrLf })
			Dim flag As Boolean = Me.iRow <> -1
			If flag Then
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" AND (IsActive = 1 OR P.ProductID = '", Me.dtItems.Rows(Me.iRow)("ProductID")), "') "), vbCrLf)))
			Else
				text += " AND IsActive = 1" & vbCrLf
			End If
			text += " ORDER BY ProductName" & vbCrLf
			Me.dtProduct = MainModule.GetData(text)
			Me.cmbProduct.ValueMember = "ProductID"
			Me.cmbProduct.DisplayMember = "ProductName"
			Me.cmbProduct.DataSource = Me.dtProduct
			Me.cmbProduct.SelectedIndex = -1
		End Sub

		' Token: 0x06001D23 RID: 7459 RVA: 0x0010FAC8 File Offset: 0x0010DCC8
		Private Sub cmbProduct_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbProduct.SelectedIndex > -1
			If flag Then
				Me.FillProductDetails()
				Me.txtReqQty.Text = ""
				Me.txtReqQtyTer.Text = ""
			Else
				Me.cmbProduct.Text = ""
				Me.ClearForm()
			End If
		End Sub

		' Token: 0x06001D24 RID: 7460 RVA: 0x0010FB30 File Offset: 0x0010DD30
		Private Sub FillProductDetails()
			Dim dataRow As DataRow = Me.dtProduct.[Select]("ProductID = '" + Me.cmbProduct.SelectedValue.ToString() + "'")(0)
			Me.txtProductName.Text = dataRow("ProductName").ToString()
			Me.txtCatalogNo.Text = dataRow("CatalogNo").ToString()
			Me.txtTertiaryUOM.Text = dataRow("TertiaryUOM").ToString()
			Me.txtTertiaryPackSize.Text = dataRow("TertiaryPackSize").ToString()
			Me.txtPrimaryUOM.Text = dataRow("PrimaryUOM").ToString()
			Me.txtPrimaryPackSize.Text = dataRow("PrimaryPackSize").ToString()
			Me.txtAvlQty.Text = Conversion.Val(dataRow("AvlQty").ToString()).ToString()
		End Sub

		' Token: 0x06001D25 RID: 7461 RVA: 0x0010FC3C File Offset: 0x0010DE3C
		Private Sub btnDelete_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.IsBOMFilled And (Strings.InStr(GlobalVariables.gsUserGroup.ToLower(), "admin", CompareMethod.Binary) = 0)
				If flag Then
					CustomMsgBox.Show("Cannot Modify BOM List.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Else
					Me.DeleteItem()
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06001D26 RID: 7462 RVA: 0x0010FCD0 File Offset: 0x0010DED0
		Private Sub DeleteItem()
			Dim flag As Boolean = CustomMsgBox.Show("Delete Item..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes
			If flag Then
				Me.dtItems.Rows.RemoveAt(Me.iRow)
				Me.dtItems.AcceptChanges()
				MyBase.DialogResult = DialogResult.OK
				MyBase.Close()
			End If
		End Sub

		' Token: 0x06001D27 RID: 7463 RVA: 0x0010FD2C File Offset: 0x0010DF2C
		Private Function ValidateForm() As Boolean
			Dim flag As Boolean = Me.cmbProduct.SelectedIndex = -1
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Select Product.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.cmbProduct.Focus()
				flag2 = False
			Else
				Dim flag3 As Boolean = Not Versioned.IsNumeric(Me.txtReqQty.Text) Or (Operators.CompareString(Strings.Trim(Me.txtReqQty.Text), "", False) = 0)
				If flag3 Then
					CustomMsgBox.Show("Required Qty. Should Be Numeric.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.txtReqQty.Focus()
					flag2 = False
				Else
					Dim flag4 As Boolean = Conversion.Val(Me.txtReqQty.Text) > Conversion.Val(Me.txtAvlQty.Text)
					If flag4 Then
						Dim text As String = "Required Qty. Is Not Available In Stock." & vbCrLf
						text += "Do You Still Want To Add Item..?"
						Dim flag5 As Boolean = CustomMsgBox.Show(text, "Critical", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No
						If flag5 Then
							Me.txtReqQty.Focus()
							Return False
						End If
					End If
					Dim flag6 As Boolean = Me.dtItems.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("ProductID = '", Me.cmbProduct.SelectedValue), "' AND SrNo <> '"), Me.iRow + 1), "'"))).Length > 0
					If flag6 Then
						CustomMsgBox.Show("Product Already In The List.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.cmbProduct.Focus()
						flag2 = False
					Else
						flag2 = True
					End If
				End If
			End If
			Return flag2
		End Function

		' Token: 0x06001D28 RID: 7464 RVA: 0x0010FEB8 File Offset: 0x0010E0B8
		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			Try
				Me.Save()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06001D29 RID: 7465 RVA: 0x0010FF10 File Offset: 0x0010E110
		Private Sub Save()
			Dim flag As Boolean = Not Me.ValidateForm()
			If Not flag Then
				Dim flag2 As Boolean = Me.iRow = -1
				If flag2 Then
					Me.iRow = Me.dtItems.Rows.Count
					Me.dtItems.Rows.Add(New Object(-1) {})
				End If
				Me.dtItems.Rows(Me.iRow)("SrNo") = Me.iRow + 1
				Me.dtItems.Rows(Me.iRow)("ProductID") = Me.cmbProduct.SelectedValue.ToString()
				Me.dtItems.Rows(Me.iRow)("ProductType") = Me.cmbType.Text
				Me.dtItems.Rows(Me.iRow)("ProductName") = Me.txtProductName.Text
				Me.dtItems.Rows(Me.iRow)("Description") = Me.txtDesc.Text
				Me.dtItems.Rows(Me.iRow)("CatalogNo") = Me.txtCatalogNo.Text
				Me.dtItems.Rows(Me.iRow)("TertiaryUOM") = Me.txtTertiaryUOM.Text
				Me.dtItems.Rows(Me.iRow)("TertiaryPackSize") = Me.txtTertiaryPackSize.Text
				Me.dtItems.Rows(Me.iRow)("PrimaryUOM") = Me.txtPrimaryUOM.Text
				Me.dtItems.Rows(Me.iRow)("PrimaryPackSize") = Me.txtPrimaryPackSize.Text
				Me.dtItems.Rows(Me.iRow)("RequiredQty") = Me.txtReqQty.Text
				MyBase.DialogResult = DialogResult.OK
				MyBase.Close()
			End If
		End Sub

		' Token: 0x04000C9D RID: 3229
		Private iRow As Integer

		' Token: 0x04000C9E RID: 3230
		Private dtProduct As DataTable

		' Token: 0x04000C9F RID: 3231
		Private sStatus As String

		' Token: 0x04000CA0 RID: 3232
		Private sMfgProductID As String

		' Token: 0x04000CA1 RID: 3233
		Private sMfgProductType As String

		' Token: 0x04000CA2 RID: 3234
		Private IsBOMFilled As Boolean

		' Token: 0x04000CA3 RID: 3235
		Public dtItems As DataTable
	End Class
End Namespace
