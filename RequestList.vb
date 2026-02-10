Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports WeifenLuo.WinFormsUI.Docking

Namespace Datasoft_PIMS
	' Token: 0x0200006C RID: 108
	<DesignerGenerated()>
	Public Partial Class RequestList
		Inherits DockContent

		' Token: 0x17000B58 RID: 2904
		' (get) Token: 0x06001D2C RID: 7468 RVA: 0x0011220A File Offset: 0x0011040A
		' (set) Token: 0x06001D2D RID: 7469 RVA: 0x00112214 File Offset: 0x00110414
		Friend Overridable Property GbBasic As GroupBox

		' Token: 0x17000B59 RID: 2905
		' (get) Token: 0x06001D2E RID: 7470 RVA: 0x0011221D File Offset: 0x0011041D
		' (set) Token: 0x06001D2F RID: 7471 RVA: 0x00112227 File Offset: 0x00110427
		Friend Overridable Property Label2 As Label

		' Token: 0x17000B5A RID: 2906
		' (get) Token: 0x06001D30 RID: 7472 RVA: 0x00112230 File Offset: 0x00110430
		' (set) Token: 0x06001D31 RID: 7473 RVA: 0x0011223A File Offset: 0x0011043A
		Friend Overridable Property txtBatchNo As TextBox

		' Token: 0x17000B5B RID: 2907
		' (get) Token: 0x06001D32 RID: 7474 RVA: 0x00112243 File Offset: 0x00110443
		' (set) Token: 0x06001D33 RID: 7475 RVA: 0x0011224D File Offset: 0x0011044D
		Friend Overridable Property cmbPlant As ComboBox

		' Token: 0x17000B5C RID: 2908
		' (get) Token: 0x06001D34 RID: 7476 RVA: 0x00112256 File Offset: 0x00110456
		' (set) Token: 0x06001D35 RID: 7477 RVA: 0x00112260 File Offset: 0x00110460
		Friend Overridable Property Label1 As Label

		' Token: 0x17000B5D RID: 2909
		' (get) Token: 0x06001D36 RID: 7478 RVA: 0x00112269 File Offset: 0x00110469
		' (set) Token: 0x06001D37 RID: 7479 RVA: 0x00112273 File Offset: 0x00110473
		Friend Overridable Property txtNo As TextBox

		' Token: 0x17000B5E RID: 2910
		' (get) Token: 0x06001D38 RID: 7480 RVA: 0x0011227C File Offset: 0x0011047C
		' (set) Token: 0x06001D39 RID: 7481 RVA: 0x00112286 File Offset: 0x00110486
		Friend Overridable Property dtpFrom As DateTimePicker

		' Token: 0x17000B5F RID: 2911
		' (get) Token: 0x06001D3A RID: 7482 RVA: 0x0011228F File Offset: 0x0011048F
		' (set) Token: 0x06001D3B RID: 7483 RVA: 0x00112299 File Offset: 0x00110499
		Friend Overridable Property dtpTo As DateTimePicker

		' Token: 0x17000B60 RID: 2912
		' (get) Token: 0x06001D3C RID: 7484 RVA: 0x001122A2 File Offset: 0x001104A2
		' (set) Token: 0x06001D3D RID: 7485 RVA: 0x001122AC File Offset: 0x001104AC
		Friend Overridable Property Label16 As Label

		' Token: 0x17000B61 RID: 2913
		' (get) Token: 0x06001D3E RID: 7486 RVA: 0x001122B5 File Offset: 0x001104B5
		' (set) Token: 0x06001D3F RID: 7487 RVA: 0x001122BF File Offset: 0x001104BF
		Friend Overridable Property lblDate As ComboBox

		' Token: 0x17000B62 RID: 2914
		' (get) Token: 0x06001D40 RID: 7488 RVA: 0x001122C8 File Offset: 0x001104C8
		' (set) Token: 0x06001D41 RID: 7489 RVA: 0x001122D4 File Offset: 0x001104D4
		Friend Overridable Property arrow_btnBasicExp_sml As Button
			<CompilerGenerated()>
			Get
				Return Me._arrow_btnBasicExp_sml
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.skip_btnBasicExp_sml_Click
				Dim button As Button = Me._arrow_btnBasicExp_sml
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._arrow_btnBasicExp_sml = value
				button = Me._arrow_btnBasicExp_sml
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000B63 RID: 2915
		' (get) Token: 0x06001D42 RID: 7490 RVA: 0x00112317 File Offset: 0x00110517
		' (set) Token: 0x06001D43 RID: 7491 RVA: 0x00112321 File Offset: 0x00110521
		Friend Overridable Property GbAdvanced As GroupBox

		' Token: 0x17000B64 RID: 2916
		' (get) Token: 0x06001D44 RID: 7492 RVA: 0x0011232A File Offset: 0x0011052A
		' (set) Token: 0x06001D45 RID: 7493 RVA: 0x00112334 File Offset: 0x00110534
		Friend Overridable Property txtCreated As TextBox

		' Token: 0x17000B65 RID: 2917
		' (get) Token: 0x06001D46 RID: 7494 RVA: 0x0011233D File Offset: 0x0011053D
		' (set) Token: 0x06001D47 RID: 7495 RVA: 0x00112347 File Offset: 0x00110547
		Friend Overridable Property lblCreated As ComboBox

		' Token: 0x17000B66 RID: 2918
		' (get) Token: 0x06001D48 RID: 7496 RVA: 0x00112350 File Offset: 0x00110550
		' (set) Token: 0x06001D49 RID: 7497 RVA: 0x0011235C File Offset: 0x0011055C
		Friend Overridable Property arrow_btnAdvanceExp_sml As Button
			<CompilerGenerated()>
			Get
				Return Me._arrow_btnAdvanceExp_sml
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.skip_btnAdvanceExp_sml_Click
				Dim button As Button = Me._arrow_btnAdvanceExp_sml
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._arrow_btnAdvanceExp_sml = value
				button = Me._arrow_btnAdvanceExp_sml
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000B67 RID: 2919
		' (get) Token: 0x06001D4A RID: 7498 RVA: 0x0011239F File Offset: 0x0011059F
		' (set) Token: 0x06001D4B RID: 7499 RVA: 0x001123A9 File Offset: 0x001105A9
		Friend Overridable Property Label9 As Label

		' Token: 0x17000B68 RID: 2920
		' (get) Token: 0x06001D4C RID: 7500 RVA: 0x001123B2 File Offset: 0x001105B2
		' (set) Token: 0x06001D4D RID: 7501 RVA: 0x001123BC File Offset: 0x001105BC
		Friend Overridable Property cmbRequestedBy As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbRequestedBy
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbRequestedBy_Validated
				Dim comboBox As ComboBox = Me._cmbRequestedBy
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.Validated, eventHandler
				End If
				Me._cmbRequestedBy = value
				comboBox = Me._cmbRequestedBy
				If comboBox IsNot Nothing Then
					AddHandler comboBox.Validated, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000B69 RID: 2921
		' (get) Token: 0x06001D4E RID: 7502 RVA: 0x001123FF File Offset: 0x001105FF
		' (set) Token: 0x06001D4F RID: 7503 RVA: 0x00112409 File Offset: 0x00110609
		Friend Overridable Property Label3 As Label

		' Token: 0x17000B6A RID: 2922
		' (get) Token: 0x06001D50 RID: 7504 RVA: 0x00112412 File Offset: 0x00110612
		' (set) Token: 0x06001D51 RID: 7505 RVA: 0x0011241C File Offset: 0x0011061C
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

		' Token: 0x17000B6B RID: 2923
		' (get) Token: 0x06001D52 RID: 7506 RVA: 0x0011245F File Offset: 0x0011065F
		' (set) Token: 0x06001D53 RID: 7507 RVA: 0x00112469 File Offset: 0x00110669
		Friend Overridable Property grpListButton As GroupBox

		' Token: 0x17000B6C RID: 2924
		' (get) Token: 0x06001D54 RID: 7508 RVA: 0x00112472 File Offset: 0x00110672
		' (set) Token: 0x06001D55 RID: 7509 RVA: 0x0011247C File Offset: 0x0011067C
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x17000B6D RID: 2925
		' (get) Token: 0x06001D56 RID: 7510 RVA: 0x00112485 File Offset: 0x00110685
		' (set) Token: 0x06001D57 RID: 7511 RVA: 0x00112490 File Offset: 0x00110690
		Friend Overridable Property btnAdd As Button
			<CompilerGenerated()>
			Get
				Return Me._btnAdd
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnAdd_Click
				Dim button As Button = Me._btnAdd
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnAdd = value
				button = Me._btnAdd
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000B6E RID: 2926
		' (get) Token: 0x06001D58 RID: 7512 RVA: 0x001124D3 File Offset: 0x001106D3
		' (set) Token: 0x06001D59 RID: 7513 RVA: 0x001124E0 File Offset: 0x001106E0
		Friend Overridable Property btnSearch As Button
			<CompilerGenerated()>
			Get
				Return Me._btnSearch
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnSearch_Click
				Dim button As Button = Me._btnSearch
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnSearch = value
				button = Me._btnSearch
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000B6F RID: 2927
		' (get) Token: 0x06001D5A RID: 7514 RVA: 0x00112523 File Offset: 0x00110723
		' (set) Token: 0x06001D5B RID: 7515 RVA: 0x00112530 File Offset: 0x00110730
		Friend Overridable Property btnClearList As Button
			<CompilerGenerated()>
			Get
				Return Me._btnClearList
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnClearList_Click
				Dim button As Button = Me._btnClearList
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnClearList = value
				button = Me._btnClearList
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000B70 RID: 2928
		' (get) Token: 0x06001D5C RID: 7516 RVA: 0x00112573 File Offset: 0x00110773
		' (set) Token: 0x06001D5D RID: 7517 RVA: 0x00112580 File Offset: 0x00110780
		Friend Overridable Property btnExport As Button
			<CompilerGenerated()>
			Get
				Return Me._btnExport
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnExport_Click
				Dim button As Button = Me._btnExport
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnExport = value
				button = Me._btnExport
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000B71 RID: 2929
		' (get) Token: 0x06001D5E RID: 7518 RVA: 0x001125C3 File Offset: 0x001107C3
		' (set) Token: 0x06001D5F RID: 7519 RVA: 0x001125CD File Offset: 0x001107CD
		Friend Overridable Property lblRows As Label

		' Token: 0x17000B72 RID: 2930
		' (get) Token: 0x06001D60 RID: 7520 RVA: 0x001125D6 File Offset: 0x001107D6
		' (set) Token: 0x06001D61 RID: 7521 RVA: 0x001125E0 File Offset: 0x001107E0
		Friend Overridable Property dgvList As DataGridView
			<CompilerGenerated()>
			Get
				Return Me._dgvList
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim dataGridViewCellEventHandler As DataGridViewCellEventHandler = AddressOf Me.dgvList_CellDoubleClick
				Dim dataGridView As DataGridView = Me._dgvList
				If dataGridView IsNot Nothing Then
					RemoveHandler dataGridView.CellDoubleClick, dataGridViewCellEventHandler
				End If
				Me._dgvList = value
				dataGridView = Me._dgvList
				If dataGridView IsNot Nothing Then
					AddHandler dataGridView.CellDoubleClick, dataGridViewCellEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000B73 RID: 2931
		' (get) Token: 0x06001D62 RID: 7522 RVA: 0x00112623 File Offset: 0x00110823
		' (set) Token: 0x06001D63 RID: 7523 RVA: 0x0011262D File Offset: 0x0011082D
		Friend Overridable Property cmbStatus As ComboBox

		' Token: 0x17000B74 RID: 2932
		' (get) Token: 0x06001D64 RID: 7524 RVA: 0x00112636 File Offset: 0x00110836
		' (set) Token: 0x06001D65 RID: 7525 RVA: 0x00112640 File Offset: 0x00110840
		Friend Overridable Property Label11 As Label

		' Token: 0x17000B75 RID: 2933
		' (get) Token: 0x06001D66 RID: 7526 RVA: 0x00112649 File Offset: 0x00110849
		' (set) Token: 0x06001D67 RID: 7527 RVA: 0x00112654 File Offset: 0x00110854
		Friend Overridable Property cmbSummary As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbSummary
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbSummary_SelectedValueChanged
				Dim comboBox As ComboBox = Me._cmbSummary
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.SelectedValueChanged, eventHandler
				End If
				Me._cmbSummary = value
				comboBox = Me._cmbSummary
				If comboBox IsNot Nothing Then
					AddHandler comboBox.SelectedValueChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000B76 RID: 2934
		' (get) Token: 0x06001D68 RID: 7528 RVA: 0x00112697 File Offset: 0x00110897
		' (set) Token: 0x06001D69 RID: 7529 RVA: 0x001126A1 File Offset: 0x001108A1
		Friend Overridable Property Label13 As Label

		' Token: 0x17000B77 RID: 2935
		' (get) Token: 0x06001D6A RID: 7530 RVA: 0x001126AA File Offset: 0x001108AA
		' (set) Token: 0x06001D6B RID: 7531 RVA: 0x001126B4 File Offset: 0x001108B4
		Friend Overridable Property pnlItem As Panel

		' Token: 0x17000B78 RID: 2936
		' (get) Token: 0x06001D6C RID: 7532 RVA: 0x001126BD File Offset: 0x001108BD
		' (set) Token: 0x06001D6D RID: 7533 RVA: 0x001126C7 File Offset: 0x001108C7
		Friend Overridable Property txtName As TextBox

		' Token: 0x17000B79 RID: 2937
		' (get) Token: 0x06001D6E RID: 7534 RVA: 0x001126D0 File Offset: 0x001108D0
		' (set) Token: 0x06001D6F RID: 7535 RVA: 0x001126DA File Offset: 0x001108DA
		Friend Overridable Property Label14 As Label

		' Token: 0x17000B7A RID: 2938
		' (get) Token: 0x06001D70 RID: 7536 RVA: 0x001126E3 File Offset: 0x001108E3
		' (set) Token: 0x06001D71 RID: 7537 RVA: 0x001126ED File Offset: 0x001108ED
		Friend Overridable Property txtCode As TextBox

		' Token: 0x17000B7B RID: 2939
		' (get) Token: 0x06001D72 RID: 7538 RVA: 0x001126F6 File Offset: 0x001108F6
		' (set) Token: 0x06001D73 RID: 7539 RVA: 0x00112700 File Offset: 0x00110900
		Friend Overridable Property Label6 As Label

		' Token: 0x17000B7C RID: 2940
		' (get) Token: 0x06001D74 RID: 7540 RVA: 0x00112709 File Offset: 0x00110909
		' (set) Token: 0x06001D75 RID: 7541 RVA: 0x00112714 File Offset: 0x00110914
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

		' Token: 0x17000B7D RID: 2941
		' (get) Token: 0x06001D76 RID: 7542 RVA: 0x00112757 File Offset: 0x00110957
		' (set) Token: 0x06001D77 RID: 7543 RVA: 0x00112761 File Offset: 0x00110961
		Friend Overridable Property Label18 As Label

		' Token: 0x17000B7E RID: 2942
		' (get) Token: 0x06001D78 RID: 7544 RVA: 0x0011276A File Offset: 0x0011096A
		' (set) Token: 0x06001D79 RID: 7545 RVA: 0x00112774 File Offset: 0x00110974
		Friend Overridable Property cmbMaterialType As ComboBox

		' Token: 0x17000B7F RID: 2943
		' (get) Token: 0x06001D7A RID: 7546 RVA: 0x0011277D File Offset: 0x0011097D
		' (set) Token: 0x06001D7B RID: 7547 RVA: 0x00112787 File Offset: 0x00110987
		Friend Overridable Property Label4 As Label

		' Token: 0x06001D7C RID: 7548 RVA: 0x00112790 File Offset: 0x00110990
		Public Sub New(sForm As String)
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.InitializeComponent()
			Me.pnlBasicDefaultHeight = Me.GbBasic.Height
			Me.pnlBasicSetHeight = 23
			Me.pnlAdvDefaultHeight = 23
			Me.pnlAdvSetHeight = Me.GbAdvanced.Height
			Me.sFormType = sForm
		End Sub

		' Token: 0x06001D7D RID: 7549 RVA: 0x0011280C File Offset: 0x00110A0C
		Private Sub SetSearchPanel()
			Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
			Me.GbBasic.Height = Me.pnlBasicDefaultHeight
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
		End Sub

		' Token: 0x06001D7E RID: 7550 RVA: 0x00112860 File Offset: 0x00110A60
		Private Sub skip_btnBasicExp_sml_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.GbBasic.Height = Me.pnlBasicDefaultHeight
			If flag Then
				Me.GbBasic.Height = Me.pnlBasicSetHeight
				Me.arrow_btnBasicExp_sml.Tag = "ArrowDown"
			Else
				Me.GbBasic.Height = Me.pnlBasicDefaultHeight
				Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			End If
		End Sub

		' Token: 0x06001D7F RID: 7551 RVA: 0x001128D0 File Offset: 0x00110AD0
		Private Sub skip_btnAdvanceExp_sml_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
			If flag Then
				Me.GbAdvanced.Height = Me.pnlAdvSetHeight
				Me.arrow_btnAdvanceExp_sml.Tag = "ArrowUp"
			Else
				Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
				Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
			End If
		End Sub

		' Token: 0x06001D80 RID: 7552 RVA: 0x00112940 File Offset: 0x00110B40
		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x06001D81 RID: 7553 RVA: 0x00112975 File Offset: 0x00110B75
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Me.SetSearchPanel()
			Designing.SetTheme(Me)
			Me.FillCombo()
			Me.ClearList()
			Me.SetForm()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x06001D82 RID: 7554 RVA: 0x001129B4 File Offset: 0x00110BB4
		Private Sub FillCombo()
			Dim text As String = "SELECT UserID, LoginID FROM [User] WHERE IsActive = 1 ORDER BY LoginID"
			Dim data As DataTable = MainModule.GetData(text)
			Me.cmbRequestedBy.ValueMember = "UserID"
			Me.cmbRequestedBy.DisplayMember = "LoginID"
			Me.cmbRequestedBy.DataSource = data
			Me.cmbRequestedBy.SelectedValue = GlobalVariables.gsUserID
			Me.FillProduct()
		End Sub

		' Token: 0x06001D83 RID: 7555 RVA: 0x00112A18 File Offset: 0x00110C18
		Private Sub FillProduct()
			Dim text As String = " SELECT ProductID, ProductName FROM Product "
			text += " WHERE IsActive = 1 "
			Dim flag As Boolean = Operators.CompareString(Me.cmbType.Text, "", False) <> 0
			If flag Then
				text = text + " AND ProductType IN ('" + Me.cmbType.Text + "') "
			Else
				text += " AND ProductType IN ('Semi Finished', 'Finished Goods','Cell Bank - Mammalian', 'Cell Bank - Bacterial') "
			End If
			text += " ORDER BY ProductName "
			Dim data As DataTable = MainModule.GetData(text)
			Me.cmbProduct.ValueMember = "ProductID"
			Me.cmbProduct.DisplayMember = "ProductName"
			Me.cmbProduct.DataSource = data
			Me.cmbProduct.SelectedIndex = -1
		End Sub

		' Token: 0x06001D84 RID: 7556 RVA: 0x00112AD4 File Offset: 0x00110CD4
		Private Sub SetForm()
			Dim text As String = Me.sFormType
			If Operators.CompareString(text, "Request", False) <> 0 Then
				If Operators.CompareString(text, "Picking", False) <> 0 Then
					If Operators.CompareString(text, "QA Approval", False) <> 0 Then
						If Operators.CompareString(text, "Issue", False) <> 0 Then
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x06001D85 RID: 7557 RVA: 0x00112B34 File Offset: 0x00110D34
		Private Sub ClearList()
			Me.lblDate.SelectedIndex = 0
			Me.lblCreated.SelectedIndex = 0
			Me.txtNo.Text = ""
			Me.txtBatchNo.Text = ""
			Me.txtCreated.Text = ""
			Me.cmbRequestedBy.SelectedValue = GlobalVariables.gsUserID
			Me.cmbType.Text = ""
			Me.cmbProduct.SelectedIndex = -1
			Me.cmbStatus.SelectedIndex = 0
			Me.dtpFrom.Value = DateAndTime.Now
			Me.dtpTo.Value = DateAndTime.Now
			Me.dtpFrom.Checked = False
			Me.dtpTo.Checked = False
			Me.cmbSummary.Text = "Request-wise"
			Me.cmbMaterialType.Text = ""
			Me.txtCode.Text = ""
			Me.txtName.Text = ""
			Me.lblRows.Text = "0 - Rows"
			Me.dgvList.DataSource = Nothing
		End Sub

		' Token: 0x06001D86 RID: 7558 RVA: 0x00112C69 File Offset: 0x00110E69
		Private Sub btnClearList_Click(sender As Object, e As EventArgs)
			Me.ClearList()
		End Sub

		' Token: 0x06001D87 RID: 7559 RVA: 0x00112C73 File Offset: 0x00110E73
		Private Sub btnExport_Click(sender As Object, e As EventArgs)
			MainModule.ExportToExcel(Me.dgvList, Me.Text)
		End Sub

		' Token: 0x06001D88 RID: 7560 RVA: 0x00112C88 File Offset: 0x00110E88
		Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs)
			Me.FillProduct()
		End Sub

		' Token: 0x06001D89 RID: 7561 RVA: 0x00112C94 File Offset: 0x00110E94
		Private Sub cmbRequestedBy_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbRequestedBy.SelectedIndex = -1
			If flag Then
				Me.cmbRequestedBy.Text = ""
			End If
		End Sub

		' Token: 0x06001D8A RID: 7562 RVA: 0x00112CC8 File Offset: 0x00110EC8
		Private Sub cmbProduct_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbProduct.SelectedIndex = -1
			If flag Then
				Me.cmbProduct.Text = ""
			End If
		End Sub

		' Token: 0x06001D8B RID: 7563 RVA: 0x00112CFB File Offset: 0x00110EFB
		Private Sub cmbSummary_SelectedValueChanged(sender As Object, e As EventArgs)
			Me.SetSummary()
		End Sub

		' Token: 0x06001D8C RID: 7564 RVA: 0x00112D08 File Offset: 0x00110F08
		Private Sub SetSummary()
			Dim text As String = Me.cmbSummary.Text
			If Operators.CompareString(text, "Request-wise", False) <> 0 Then
				If Operators.CompareString(text, "Item-wise", False) = 0 Then
					Me.pnlItem.Visible = True
					Me.pnlAdvSetHeight = 187
					Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(Me.arrow_btnAdvanceExp_sml.Tag, "ArrowUp", False)
					If flag Then
						Me.GbAdvanced.Height = Me.pnlAdvSetHeight
					End If
				End If
			Else
				Me.pnlItem.Visible = False
				Me.pnlAdvSetHeight = 135
				Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(Me.arrow_btnAdvanceExp_sml.Tag, "ArrowUp", False)
				If flag2 Then
					Me.GbAdvanced.Height = Me.pnlAdvSetHeight
				End If
			End If
			Me.cmbMaterialType.Text = ""
			Me.txtCode.Text = ""
			Me.txtName.Text = ""
		End Sub

		' Token: 0x06001D8D RID: 7565 RVA: 0x00112E0C File Offset: 0x0011100C
		Private Sub btnAdd_Click(sender As Object, e As EventArgs)
			Dim request As Request = New Request("", Nothing)
			request.Show(MyBase.DockPanel)
		End Sub

		' Token: 0x06001D8E RID: 7566 RVA: 0x00112E34 File Offset: 0x00111034
		Private Sub dgvList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = (e.RowIndex > -1) And (e.ColumnIndex > -1)
			If flag Then
				Dim text As String = Me.sFormType
				If Operators.CompareString(text, "Request", False) <> 0 Then
					If Operators.CompareString(text, "Approval", False) <> 0 Then
						If Operators.CompareString(text, "Issue", False) <> 0 Then
						End If
					End If
				Else
					Dim dataTable As DataTable = CType(Me.dgvList.DataSource, DataTable)
					Dim dataRow As DataRow = dataTable.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("ID = '", Me.dgvList.Rows(e.RowIndex).Cells("ID").Value), "'")))(0)
					Dim request As Request = New Request("", dataRow)
					request.Show(MyBase.DockPanel)
				End If
				Me.ClearList()
			End If
		End Sub

		' Token: 0x06001D8F RID: 7567 RVA: 0x00112F24 File Offset: 0x00111124
		Private Sub btnSearch_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SearchData("")
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06001D90 RID: 7568 RVA: 0x00112F98 File Offset: 0x00111198
		Private Sub SearchData(sID As String)
			Dim text As String = ""
			Dim text2 As String = " SELECT R.RequestID AS ID, R.Status, RequestNo, RequestDt, R.Department, RequestedBy, U.UserID,U.LoginID, U.UserName,  " & vbCrLf
			text2 += " R.ProductID, P.CatalogNo, P.ProductType, P.ProductName, BatchNo, MfgDt, ExpDt, R.BOMVersion, R.BatchQty, " & vbCrLf
			Dim flag As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Item-wise", False) = 0
			If flag Then
				text2 += " M.ProductCode MaterialCode, M.CatalogNo MaterialCatalogNo, M.ProductName MaterialName, M.ProductType MaterialType, " & vbCrLf
				text2 += " M.PrimaryUOM, M.PrimaryPackSize, RD.RequiredQty, " & vbCrLf
			End If
			text2 += " Created.EmailID AS CreatedByEmailID, Modified.EmailID AS ModifiedByEmailID, " & vbCrLf
			text2 += " R.CreationDt, Created.UserName AS CreatedBy, R.ModificationDt, Modified.UserName AS ModifiedBy " & vbCrLf
			text2 += " FROM Request R " & vbCrLf
			text2 += " INNER JOIN [User] U ON R.RequestedBy = U.UserID " & vbCrLf
			text2 += " INNER JOIN Product P ON R.ProductID = P.ProductID " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Created ON R.CreatedBy = Created.UserID " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Modified ON R.ModifiedBy = Modified.UserID " & vbCrLf
			Dim flag2 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Item-wise", False) = 0
			If flag2 Then
				text2 += " INNER JOIN RequestDtls RD ON R.RequestID = RD.RequestID " & vbCrLf
				text2 += " INNER JOIN Product M ON RD.ProductID = M.ProductID " & vbCrLf
			End If
			Dim flag3 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Request-wise", False) = 0
			If flag3 Then
			End If
			text2 += " WHERE 1=1" & vbCrLf
			Dim text3 As String = Me.sFormType
			If Operators.CompareString(text3, "", False) <> 0 Then
			End If
			Dim flag4 As Boolean = Operators.CompareString(sID, "", False) <> 0
			If flag4 Then
				text2 = text2 + " AND R.RequestID = '" + sID + "'" & vbCrLf
				text = text + "RequestID = '" + sID + "'" & vbCrLf
			End If
			Dim flag5 As Boolean = Operators.CompareString(Strings.Trim(Me.txtNo.Text), "", False) <> 0
			If flag5 Then
				text2 = text2 + " And (RequestNo Like '%" + Strings.Trim(Me.txtNo.Text) + "%') " & vbCrLf
				text = text + "RequestNo LIKE " + Strings.Trim(Me.txtNo.Text) + vbCrLf
			End If
			Dim flag6 As Boolean = Operators.CompareString(Strings.Trim(Me.txtBatchNo.Text), "", False) <> 0
			If flag6 Then
				text2 = text2 + " AND (BatchNo LIKE '%" + Strings.Trim(Me.txtBatchNo.Text) + "%')" & vbCrLf
				text = text + "BatchNo LIKE " + Strings.Trim(Me.txtBatchNo.Text) + vbCrLf
			End If
			Dim flag7 As Boolean = Me.cmbRequestedBy.SelectedIndex > -1
			If flag7 Then
				text2 = text2 + " AND (R.RequestedBy = '" + Strings.Trim(Me.cmbRequestedBy.SelectedValue.ToString()) + "')" & vbCrLf
				text = text + "Requested By = " + Strings.Trim(Me.cmbRequestedBy.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag8 As Boolean = Me.cmbProduct.SelectedIndex > -1
			If flag8 Then
				text2 = text2 + " AND (R.ProductID = '" + Strings.Trim(Me.cmbProduct.SelectedValue.ToString()) + "')" & vbCrLf
				text = text + "ProductID = " + Strings.Trim(Me.cmbProduct.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag9 As Boolean = Me.cmbStatus.SelectedIndex > 0
			If flag9 Then
				text2 = text2 + " AND (R.Status = '" + Me.cmbStatus.Text + "')" & vbCrLf
				text = text + ("Status = " + Me.cmbStatus.Text) + vbCrLf
			End If
			Dim flag10 As Boolean = Operators.CompareString(Me.cmbType.Text, "", False) <> 0
			If flag10 Then
				text2 = text2 + " AND P.ProductType = '" + Me.cmbType.Text + "'" & vbCrLf
			End If
			Dim flag11 As Boolean = (Operators.CompareString(Me.cmbSummary.Text, "Item-wise", False) = 0) And (Operators.CompareString(Me.cmbMaterialType.Text, "", False) <> 0)
			If flag11 Then
				text2 = text2 + " AND M.ProductType = '" + Me.cmbMaterialType.Text + "'" & vbCrLf
			End If
			Dim flag12 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCreated.Text), "", False) <> 0
			If flag12 Then
				Dim flag13 As Boolean = Me.lblCreated.SelectedIndex >= 0
				If flag13 Then
					Dim flag14 As Boolean = Me.lblCreated.SelectedIndex = 0
					Dim text4 As String
					If flag14 Then
						text4 = "Created"
					Else
						text4 = "Modified"
					End If
					text2 = String.Concat(New String() { text2, " AND ", text4, ".UserName LIKE '%", Strings.Trim(Me.txtCreated.Text), "%'" })
					text = text + (text4 + "By LIKE " + Strings.Trim(Me.txtCreated.Text)) + vbCrLf
				End If
			End If
			Dim flag15 As Boolean = Me.lblDate.SelectedIndex >= 0
			If flag15 Then
				Dim text5 As String = Me.lblDate.Text
				Dim text6 As String
				If Operators.CompareString(text5, "Creation", False) <> 0 Then
					If Operators.CompareString(text5, "Last Modification", False) <> 0 Then
						If Operators.CompareString(text5, "Request Date", False) <> 0 Then
							If Operators.CompareString(text5, "Mfg. Date", False) <> 0 Then
								If Operators.CompareString(text5, "Expiry Date", False) <> 0 Then
									text6 = ""
								Else
									text6 = "ExpDt"
								End If
							Else
								text6 = "MfgDt"
							End If
						Else
							text6 = "RequestDt"
						End If
					Else
						text6 = "R.ModificationDt"
					End If
				Else
					text6 = "R.CreationDt"
				End If
				Dim flag16 As Boolean = Operators.CompareString(text6, "", False) <> 0
				If flag16 Then
					Dim flag17 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
					If flag17 Then
						text2 = String.Concat(New String() { text2, " AND ", text6, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
						text = text + String.Concat(New String() { text6, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
					Else
						Dim checked As Boolean = Me.dtpFrom.Checked
						If checked Then
							text2 = String.Concat(New String() { text2, " AND ", text6, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59"), "'" })
							text = text + String.Concat(New String() { text6, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
						End If
						Dim checked2 As Boolean = Me.dtpTo.Checked
						If checked2 Then
							text2 = String.Concat(New String() { text2, " AND ", text6, " BETWEEN '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
							text = text + String.Concat(New String() { text6, " BETWEEN  ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
						End If
					End If
				End If
			End If
			Dim flag18 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Item-wise", False) = 0
			If flag18 Then
				Dim flag19 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCode.Text), "", False) <> 0
				If flag19 Then
					text2 = text2 + " AND (M.ProductCode Like '%" + Strings.Trim(Me.txtCode.Text) + "%') "
					text = text + "MaterialCode LIKE " + Strings.Trim(Me.txtCode.Text) + vbCrLf
				End If
				Dim flag20 As Boolean = Operators.CompareString(Strings.Trim(Me.txtName.Text), "", False) <> 0
				If flag20 Then
					text2 = text2 + " AND (M.ProductName Like '%" + Strings.Trim(Me.txtName.Text) + "%') "
					text = text + "MaterialName LIKE " + Strings.Trim(Me.txtName.Text) + vbCrLf
				End If
			End If
			text2 += " ORDER BY RequestDt"
			Dim data As DataTable = MainModule.GetData(text2)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = Nothing
			Me.dgvList.DataSource = data
			Me.dgvList.Columns("ID").Visible = False
			Me.dgvList.Columns("RequestedBy").Visible = False
			Me.dgvList.Columns("ProductID").Visible = False
			Me.dgvList.Columns("LoginID").Visible = False
			Me.dgvList.Columns("UserID").Visible = False
			Me.dgvList.Columns("CreatedByEmailID").Visible = False
			Me.dgvList.Columns("ModifiedByEmailID").Visible = False
			Me.dgvList.Columns("RequestNo").HeaderText = "Request No."
			Me.dgvList.Columns("RequestDt").HeaderText = "Request Date"
			Me.dgvList.Columns("LoginID").HeaderText = "LoginID"
			Me.dgvList.Columns("UserName").HeaderText = "Requested By"
			Me.dgvList.Columns("CatalogNo").HeaderText = "Catalog No."
			Me.dgvList.Columns("ProductType").HeaderText = "Product Type"
			Me.dgvList.Columns("ProductName").HeaderText = "Product Name"
			Me.dgvList.Columns("BatchNo").HeaderText = "Batch No."
			Me.dgvList.Columns("MfgDt").HeaderText = "Mfg. Date"
			Me.dgvList.Columns("ExpDt").HeaderText = "Expiry Date"
			Me.dgvList.Columns("BOMVersion").HeaderText = "BOM Version No."
			Me.dgvList.Columns("BatchQty").HeaderText = "Batch Qty."
			Me.dgvList.Columns("CreationDt").HeaderText = "Creation Date"
			Me.dgvList.Columns("CreatedBy").HeaderText = "Created By"
			Me.dgvList.Columns("ModificationDt").HeaderText = "Modification Date"
			Me.dgvList.Columns("ModifiedBy").HeaderText = "Modified By"
			Me.dgvList.Columns("RequestDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("MfgDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("ExpDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("CreationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			Me.dgvList.Columns("ModificationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			Me.dgvList.Columns("RequestNo").Width = 130
			Me.dgvList.Columns("RequestDt").Width = 120
			Me.dgvList.Columns("Department").Width = 150
			Me.dgvList.Columns("UserName").Width = 225
			Me.dgvList.Columns("CatalogNo").Width = 170
			Me.dgvList.Columns("ProductType").Width = 150
			Me.dgvList.Columns("ProductName").Width = 350
			Me.dgvList.Columns("BatchNo").Width = 130
			Me.dgvList.Columns("MfgDt").Width = 120
			Me.dgvList.Columns("ExpDt").Width = 120
			Me.dgvList.Columns("BOMVersion").Width = 140
			Me.dgvList.Columns("Status").Width = 132
			Me.dgvList.Columns("CreationDt").Width = 170
			Me.dgvList.Columns("CreatedBy").Width = 140
			Me.dgvList.Columns("ModificationDt").Width = 170
			Me.dgvList.Columns("ModifiedBy").Width = 140
			Dim flag21 As Boolean = data.Columns.Contains("MaterialCode")
			If flag21 Then
				Me.dgvList.Columns("MaterialCode").HeaderText = "Material Code"
				Me.dgvList.Columns("MaterialCatalogNo").HeaderText = "Material Catalog No."
				Me.dgvList.Columns("MaterialName").HeaderText = "Material Name"
				Me.dgvList.Columns("MaterialType").HeaderText = "Material Type"
				Me.dgvList.Columns("PrimaryUOM").HeaderText = "Primary UOM"
				Me.dgvList.Columns("PrimaryPackSize").HeaderText = "Primary PackSize"
				Me.dgvList.Columns("RequiredQty").HeaderText = "Required Qty."
				Me.dgvList.Columns("MaterialCode").Width = 180
				Me.dgvList.Columns("MaterialCatalogNo").Width = 180
				Me.dgvList.Columns("MaterialName").Width = 300
				Me.dgvList.Columns("MaterialType").Width = 110
				Me.dgvList.Columns("PrimaryUOM").Width = 90
				Me.dgvList.Columns("PrimaryPackSize").Width = 72
				Me.dgvList.Columns("RequiredQty").Width = 60
				Me.dgvList.Columns("RequiredQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x04000CCD RID: 3277
		Private sFormType As String

		' Token: 0x04000CCE RID: 3278
		Private pnlBasicDefaultHeight As Integer

		' Token: 0x04000CCF RID: 3279
		Private pnlBasicSetHeight As Integer

		' Token: 0x04000CD0 RID: 3280
		Private pnlAdvDefaultHeight As Integer

		' Token: 0x04000CD1 RID: 3281
		Private pnlAdvSetHeight As Integer
	End Class
End Namespace
