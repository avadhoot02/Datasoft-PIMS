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
	' Token: 0x02000026 RID: 38
	<DesignerGenerated()>
	Public Partial Class POReport
		Inherits DockContent

		' Token: 0x170003B5 RID: 949
		' (get) Token: 0x060009BE RID: 2494 RVA: 0x00056E05 File Offset: 0x00055005
		' (set) Token: 0x060009BF RID: 2495 RVA: 0x00056E0F File Offset: 0x0005500F
		Friend Overridable Property GbBasic As GroupBox

		' Token: 0x170003B6 RID: 950
		' (get) Token: 0x060009C0 RID: 2496 RVA: 0x00056E18 File Offset: 0x00055018
		' (set) Token: 0x060009C1 RID: 2497 RVA: 0x00056E22 File Offset: 0x00055022
		Friend Overridable Property Label2 As Label

		' Token: 0x170003B7 RID: 951
		' (get) Token: 0x060009C2 RID: 2498 RVA: 0x00056E2B File Offset: 0x0005502B
		' (set) Token: 0x060009C3 RID: 2499 RVA: 0x00056E35 File Offset: 0x00055035
		Friend Overridable Property txtPRNo As TextBox

		' Token: 0x170003B8 RID: 952
		' (get) Token: 0x060009C4 RID: 2500 RVA: 0x00056E3E File Offset: 0x0005503E
		' (set) Token: 0x060009C5 RID: 2501 RVA: 0x00056E48 File Offset: 0x00055048
		Friend Overridable Property cmbPlant As ComboBox

		' Token: 0x170003B9 RID: 953
		' (get) Token: 0x060009C6 RID: 2502 RVA: 0x00056E51 File Offset: 0x00055051
		' (set) Token: 0x060009C7 RID: 2503 RVA: 0x00056E5B File Offset: 0x0005505B
		Friend Overridable Property Label1 As Label

		' Token: 0x170003BA RID: 954
		' (get) Token: 0x060009C8 RID: 2504 RVA: 0x00056E64 File Offset: 0x00055064
		' (set) Token: 0x060009C9 RID: 2505 RVA: 0x00056E6E File Offset: 0x0005506E
		Friend Overridable Property txtNo As TextBox

		' Token: 0x170003BB RID: 955
		' (get) Token: 0x060009CA RID: 2506 RVA: 0x00056E77 File Offset: 0x00055077
		' (set) Token: 0x060009CB RID: 2507 RVA: 0x00056E81 File Offset: 0x00055081
		Friend Overridable Property dtpFrom As DateTimePicker

		' Token: 0x170003BC RID: 956
		' (get) Token: 0x060009CC RID: 2508 RVA: 0x00056E8A File Offset: 0x0005508A
		' (set) Token: 0x060009CD RID: 2509 RVA: 0x00056E94 File Offset: 0x00055094
		Friend Overridable Property dtpTo As DateTimePicker

		' Token: 0x170003BD RID: 957
		' (get) Token: 0x060009CE RID: 2510 RVA: 0x00056E9D File Offset: 0x0005509D
		' (set) Token: 0x060009CF RID: 2511 RVA: 0x00056EA7 File Offset: 0x000550A7
		Friend Overridable Property Label16 As Label

		' Token: 0x170003BE RID: 958
		' (get) Token: 0x060009D0 RID: 2512 RVA: 0x00056EB0 File Offset: 0x000550B0
		' (set) Token: 0x060009D1 RID: 2513 RVA: 0x00056EBA File Offset: 0x000550BA
		Friend Overridable Property lblDate As ComboBox

		' Token: 0x170003BF RID: 959
		' (get) Token: 0x060009D2 RID: 2514 RVA: 0x00056EC3 File Offset: 0x000550C3
		' (set) Token: 0x060009D3 RID: 2515 RVA: 0x00056ED0 File Offset: 0x000550D0
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

		' Token: 0x170003C0 RID: 960
		' (get) Token: 0x060009D4 RID: 2516 RVA: 0x00056F13 File Offset: 0x00055113
		' (set) Token: 0x060009D5 RID: 2517 RVA: 0x00056F1D File Offset: 0x0005511D
		Friend Overridable Property GbAdvanced As GroupBox

		' Token: 0x170003C1 RID: 961
		' (get) Token: 0x060009D6 RID: 2518 RVA: 0x00056F26 File Offset: 0x00055126
		' (set) Token: 0x060009D7 RID: 2519 RVA: 0x00056F30 File Offset: 0x00055130
		Friend Overridable Property cmbStatus As ComboBox

		' Token: 0x170003C2 RID: 962
		' (get) Token: 0x060009D8 RID: 2520 RVA: 0x00056F39 File Offset: 0x00055139
		' (set) Token: 0x060009D9 RID: 2521 RVA: 0x00056F43 File Offset: 0x00055143
		Friend Overridable Property Label11 As Label

		' Token: 0x170003C3 RID: 963
		' (get) Token: 0x060009DA RID: 2522 RVA: 0x00056F4C File Offset: 0x0005514C
		' (set) Token: 0x060009DB RID: 2523 RVA: 0x00056F58 File Offset: 0x00055158
		Friend Overridable Property cmbVendor As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbVendor
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbVendor_Validated
				Dim comboBox As ComboBox = Me._cmbVendor
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.Validated, eventHandler
				End If
				Me._cmbVendor = value
				comboBox = Me._cmbVendor
				If comboBox IsNot Nothing Then
					AddHandler comboBox.Validated, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170003C4 RID: 964
		' (get) Token: 0x060009DC RID: 2524 RVA: 0x00056F9B File Offset: 0x0005519B
		' (set) Token: 0x060009DD RID: 2525 RVA: 0x00056FA5 File Offset: 0x000551A5
		Friend Overridable Property Label9 As Label

		' Token: 0x170003C5 RID: 965
		' (get) Token: 0x060009DE RID: 2526 RVA: 0x00056FAE File Offset: 0x000551AE
		' (set) Token: 0x060009DF RID: 2527 RVA: 0x00056FB8 File Offset: 0x000551B8
		Friend Overridable Property cmbType As ComboBox

		' Token: 0x170003C6 RID: 966
		' (get) Token: 0x060009E0 RID: 2528 RVA: 0x00056FC1 File Offset: 0x000551C1
		' (set) Token: 0x060009E1 RID: 2529 RVA: 0x00056FCB File Offset: 0x000551CB
		Friend Overridable Property Label24 As Label

		' Token: 0x170003C7 RID: 967
		' (get) Token: 0x060009E2 RID: 2530 RVA: 0x00056FD4 File Offset: 0x000551D4
		' (set) Token: 0x060009E3 RID: 2531 RVA: 0x00056FDE File Offset: 0x000551DE
		Friend Overridable Property txtCreated As TextBox

		' Token: 0x170003C8 RID: 968
		' (get) Token: 0x060009E4 RID: 2532 RVA: 0x00056FE7 File Offset: 0x000551E7
		' (set) Token: 0x060009E5 RID: 2533 RVA: 0x00056FF1 File Offset: 0x000551F1
		Friend Overridable Property lblCreated As ComboBox

		' Token: 0x170003C9 RID: 969
		' (get) Token: 0x060009E6 RID: 2534 RVA: 0x00056FFA File Offset: 0x000551FA
		' (set) Token: 0x060009E7 RID: 2535 RVA: 0x00057004 File Offset: 0x00055204
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

		' Token: 0x170003CA RID: 970
		' (get) Token: 0x060009E8 RID: 2536 RVA: 0x00057047 File Offset: 0x00055247
		' (set) Token: 0x060009E9 RID: 2537 RVA: 0x00057051 File Offset: 0x00055251
		Friend Overridable Property grpListButton As GroupBox

		' Token: 0x170003CB RID: 971
		' (get) Token: 0x060009EA RID: 2538 RVA: 0x0005705A File Offset: 0x0005525A
		' (set) Token: 0x060009EB RID: 2539 RVA: 0x00057064 File Offset: 0x00055264
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x170003CC RID: 972
		' (get) Token: 0x060009EC RID: 2540 RVA: 0x0005706D File Offset: 0x0005526D
		' (set) Token: 0x060009ED RID: 2541 RVA: 0x00057078 File Offset: 0x00055278
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

		' Token: 0x170003CD RID: 973
		' (get) Token: 0x060009EE RID: 2542 RVA: 0x000570BB File Offset: 0x000552BB
		' (set) Token: 0x060009EF RID: 2543 RVA: 0x000570C8 File Offset: 0x000552C8
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

		' Token: 0x170003CE RID: 974
		' (get) Token: 0x060009F0 RID: 2544 RVA: 0x0005710B File Offset: 0x0005530B
		' (set) Token: 0x060009F1 RID: 2545 RVA: 0x00057118 File Offset: 0x00055318
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

		' Token: 0x170003CF RID: 975
		' (get) Token: 0x060009F2 RID: 2546 RVA: 0x0005715B File Offset: 0x0005535B
		' (set) Token: 0x060009F3 RID: 2547 RVA: 0x00057165 File Offset: 0x00055365
		Friend Overridable Property lblRows As Label

		' Token: 0x170003D0 RID: 976
		' (get) Token: 0x060009F4 RID: 2548 RVA: 0x0005716E File Offset: 0x0005536E
		' (set) Token: 0x060009F5 RID: 2549 RVA: 0x00057178 File Offset: 0x00055378
		Friend Overridable Property dgvList As DataGridView

		' Token: 0x170003D1 RID: 977
		' (get) Token: 0x060009F6 RID: 2550 RVA: 0x00057181 File Offset: 0x00055381
		' (set) Token: 0x060009F7 RID: 2551 RVA: 0x0005718C File Offset: 0x0005538C
		Friend Overridable Property cmbReportType As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbReportType
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbReportType_SelectedIndexChanged
				Dim comboBox As ComboBox = Me._cmbReportType
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.SelectedIndexChanged, eventHandler
				End If
				Me._cmbReportType = value
				comboBox = Me._cmbReportType
				If comboBox IsNot Nothing Then
					AddHandler comboBox.SelectedIndexChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170003D2 RID: 978
		' (get) Token: 0x060009F8 RID: 2552 RVA: 0x000571CF File Offset: 0x000553CF
		' (set) Token: 0x060009F9 RID: 2553 RVA: 0x000571D9 File Offset: 0x000553D9
		Friend Overridable Property Label4 As Label

		' Token: 0x170003D3 RID: 979
		' (get) Token: 0x060009FA RID: 2554 RVA: 0x000571E2 File Offset: 0x000553E2
		' (set) Token: 0x060009FB RID: 2555 RVA: 0x000571EC File Offset: 0x000553EC
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

		' Token: 0x170003D4 RID: 980
		' (get) Token: 0x060009FC RID: 2556 RVA: 0x0005722F File Offset: 0x0005542F
		' (set) Token: 0x060009FD RID: 2557 RVA: 0x00057239 File Offset: 0x00055439
		Friend Overridable Property lblSummary As Label

		' Token: 0x170003D5 RID: 981
		' (get) Token: 0x060009FE RID: 2558 RVA: 0x00057242 File Offset: 0x00055442
		' (set) Token: 0x060009FF RID: 2559 RVA: 0x0005724C File Offset: 0x0005544C
		Friend Overridable Property pnlItem As Panel

		' Token: 0x170003D6 RID: 982
		' (get) Token: 0x06000A00 RID: 2560 RVA: 0x00057255 File Offset: 0x00055455
		' (set) Token: 0x06000A01 RID: 2561 RVA: 0x0005725F File Offset: 0x0005545F
		Friend Overridable Property txtName As TextBox

		' Token: 0x170003D7 RID: 983
		' (get) Token: 0x06000A02 RID: 2562 RVA: 0x00057268 File Offset: 0x00055468
		' (set) Token: 0x06000A03 RID: 2563 RVA: 0x00057272 File Offset: 0x00055472
		Friend Overridable Property txtCatalogNo As TextBox

		' Token: 0x170003D8 RID: 984
		' (get) Token: 0x06000A04 RID: 2564 RVA: 0x0005727B File Offset: 0x0005547B
		' (set) Token: 0x06000A05 RID: 2565 RVA: 0x00057285 File Offset: 0x00055485
		Friend Overridable Property Label14 As Label

		' Token: 0x170003D9 RID: 985
		' (get) Token: 0x06000A06 RID: 2566 RVA: 0x0005728E File Offset: 0x0005548E
		' (set) Token: 0x06000A07 RID: 2567 RVA: 0x00057298 File Offset: 0x00055498
		Friend Overridable Property Label5 As Label

		' Token: 0x170003DA RID: 986
		' (get) Token: 0x06000A08 RID: 2568 RVA: 0x000572A1 File Offset: 0x000554A1
		' (set) Token: 0x06000A09 RID: 2569 RVA: 0x000572AB File Offset: 0x000554AB
		Friend Overridable Property txtCode As TextBox

		' Token: 0x170003DB RID: 987
		' (get) Token: 0x06000A0A RID: 2570 RVA: 0x000572B4 File Offset: 0x000554B4
		' (set) Token: 0x06000A0B RID: 2571 RVA: 0x000572BE File Offset: 0x000554BE
		Friend Overridable Property Label6 As Label

		' Token: 0x170003DC RID: 988
		' (get) Token: 0x06000A0C RID: 2572 RVA: 0x000572C7 File Offset: 0x000554C7
		' (set) Token: 0x06000A0D RID: 2573 RVA: 0x000572D1 File Offset: 0x000554D1
		Friend Overridable Property cmbItemStatus As ComboBox

		' Token: 0x06000A0E RID: 2574 RVA: 0x000572DC File Offset: 0x000554DC
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.POReport_FormClosing
			AddHandler MyBase.Load, AddressOf Me.POReport_Load
			Me.InitializeComponent()
			Me.pnlBasicDefaultHeight = Me.GbBasic.Height
			Me.pnlBasicSetHeight = 23
			Me.pnlAdvDefaultHeight = 23
			Me.pnlAdvSetHeight = Me.GbAdvanced.Height
			Me.Text = "PO Report"
		End Sub

		' Token: 0x06000A0F RID: 2575 RVA: 0x0005735C File Offset: 0x0005555C
		Private Sub SetSearchPanel()
			Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
			Me.GbBasic.Height = Me.pnlBasicDefaultHeight
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
		End Sub

		' Token: 0x06000A10 RID: 2576 RVA: 0x000573B0 File Offset: 0x000555B0
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

		' Token: 0x06000A11 RID: 2577 RVA: 0x00057420 File Offset: 0x00055620
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

		' Token: 0x06000A12 RID: 2578 RVA: 0x00057490 File Offset: 0x00055690
		Private Sub POReport_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x06000A13 RID: 2579 RVA: 0x000574C5 File Offset: 0x000556C5
		Private Sub POReport_Load(sender As Object, e As EventArgs)
			Me.SetSearchPanel()
			Designing.SetTheme(Me)
			Me.FillCombo()
			Me.ClearList()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x06000A14 RID: 2580 RVA: 0x000574FC File Offset: 0x000556FC
		Private Sub FillCombo()
			Dim text As String = "SELECT VendorID, VendorName FROM Vendor ORDER BY VendorName"
			Dim data As DataTable = MainModule.GetData(text)
			Me.cmbVendor.ValueMember = "VendorID"
			Me.cmbVendor.DisplayMember = "VendorName"
			Me.cmbVendor.DataSource = data
			Me.cmbVendor.SelectedIndex = -1
		End Sub

		' Token: 0x06000A15 RID: 2581 RVA: 0x00057554 File Offset: 0x00055754
		Private Sub ClearList()
			Me.lblDate.SelectedIndex = 0
			Me.lblCreated.SelectedIndex = 0
			Me.txtNo.Text = ""
			Me.txtPRNo.Text = ""
			Me.txtCreated.Text = ""
			Me.cmbType.Text = ""
			Me.cmbVendor.SelectedIndex = -1
			Me.cmbStatus.SelectedIndex = 0
			Me.dtpFrom.Value = DateAndTime.Now
			Me.dtpTo.Value = DateAndTime.Now
			Me.dtpFrom.Checked = False
			Me.dtpTo.Checked = False
			Me.cmbReportType.SelectedIndex = 0
			Me.cmbSummary.Text = "PO-wise"
			Me.cmbItemStatus.Text = ""
			Me.txtCode.Text = ""
			Me.txtCatalogNo.Text = ""
			Me.txtName.Text = ""
			Me.lblRows.Text = "0 - Rows"
			Me.dgvList.DataSource = Nothing
		End Sub

		' Token: 0x06000A16 RID: 2582 RVA: 0x00057696 File Offset: 0x00055896
		Private Sub btnClearList_Click(sender As Object, e As EventArgs)
			Me.ClearList()
		End Sub

		' Token: 0x06000A17 RID: 2583 RVA: 0x000576A0 File Offset: 0x000558A0
		Private Sub btnExport_Click(sender As Object, e As EventArgs)
			MainModule.ExportToExcel(Me.dgvList, Me.Text)
		End Sub

		' Token: 0x06000A18 RID: 2584 RVA: 0x000576B8 File Offset: 0x000558B8
		Private Sub cmbReportType_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim text As String = Me.cmbReportType.Text
			If Operators.CompareString(text, "PO General", False) <> 0 Then
				If Operators.CompareString(text, "PO Item-wise Received", False) <> 0 Then
					If Operators.CompareString(text, "PO GRN-wise Received", False) = 0 Then
						Me.cmbSummary.Text = "Item-wise"
						Me.cmbSummary.Enabled = False
						Me.lblSummary.Text = "Summary"
						Me.cmbSummary.Visible = True
						Me.cmbItemStatus.Visible = False
					End If
				Else
					Me.cmbSummary.Text = "Item-wise"
					Me.cmbSummary.Enabled = False
					Me.lblSummary.Text = "Receipt"
					Me.cmbSummary.Visible = False
					Me.cmbItemStatus.Visible = True
				End If
			Else
				Me.cmbSummary.Text = "PO-wise"
				Me.cmbSummary.Enabled = True
				Me.lblSummary.Text = "Summary"
				Me.cmbSummary.Visible = True
				Me.cmbItemStatus.Visible = False
			End If
		End Sub

		' Token: 0x06000A19 RID: 2585 RVA: 0x000577ED File Offset: 0x000559ED
		Private Sub cmbSummary_SelectedValueChanged(sender As Object, e As EventArgs)
			Me.SetSummary()
		End Sub

		' Token: 0x06000A1A RID: 2586 RVA: 0x000577F8 File Offset: 0x000559F8
		Private Sub SetSummary()
			Dim text As String = Me.cmbSummary.Text
			If Operators.CompareString(text, "PO-wise", False) <> 0 Then
				If Operators.CompareString(text, "Item-wise", False) = 0 Then
					Me.pnlItem.Visible = True
					Me.pnlAdvSetHeight = 190
					Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(Me.arrow_btnAdvanceExp_sml.Tag, "ArrowUp", False)
					If flag Then
						Me.GbAdvanced.Height = Me.pnlAdvSetHeight
					End If
				End If
			Else
				Me.pnlItem.Visible = False
				Me.pnlAdvSetHeight = 139
				Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(Me.arrow_btnAdvanceExp_sml.Tag, "ArrowUp", False)
				If flag2 Then
					Me.GbAdvanced.Height = Me.pnlAdvSetHeight
				End If
			End If
			Me.txtCode.Text = ""
			Me.txtCatalogNo.Text = ""
			Me.txtName.Text = ""
		End Sub

		' Token: 0x06000A1B RID: 2587 RVA: 0x000578FC File Offset: 0x00055AFC
		Private Sub cmbVendor_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbVendor.SelectedIndex = -1
			If flag Then
				Me.cmbVendor.Text = ""
			End If
		End Sub

		' Token: 0x06000A1C RID: 2588 RVA: 0x00057930 File Offset: 0x00055B30
		Private Sub btnSearch_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Dim text As String = Me.cmbReportType.Text
				If Operators.CompareString(text, "PO General", False) <> 0 Then
					If Operators.CompareString(text, "PO Item-wise Received", False) <> 0 Then
						If Operators.CompareString(text, "PO GRN-wise Received", False) = 0 Then
							Me.POGRNwiseReceived("")
						End If
					Else
						Me.POItemwiseReceived("")
					End If
				Else
					Me.POGeneral("")
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06000A1D RID: 2589 RVA: 0x000579FC File Offset: 0x00055BFC
		Private Sub POGeneral(sID As String)
			Dim text As String = ""
			Dim flag As Boolean = Operators.CompareString(Me.cmbSummary.Text, "PO-wise", False) = 0
			Dim text2 As String
			If flag Then
				text2 = " SELECT P.POID AS ID, P.Status, P.POType, P.PONo, P.PODt, " & vbCrLf
				Dim flag2 As Boolean = (Operators.CompareString(Me.lblDate.Text, "P.R. Date", False) = 0) Or (Operators.CompareString(Strings.Trim(Me.txtPRNo.Text), "", False) <> 0)
				If flag2 Then
					text2 += " PR.PRNo, PR.PRDt, "
				End If
				text2 += " SUM(FinalAmt) Amount, P.ValidUpto, P.DeliveryInDays, P.DeliveryDt, " & vbCrLf
				text2 += " P.Department, P.InvoiceAddress, P.BillingEmailID, P.ShipAddress, P.ShippingEmailID, P.GSTNo, P.PANNo, " & vbCrLf
				text2 += " P.VendorID, V.VendorName, P.VendorBillingAddress, P.VendorContactPerson, " & vbCrLf
				text2 += " P.VendorContactNo, P.VendorEmailID, P.VendorGSTNo, P.VendorPANNo, " & vbCrLf
				text2 += " P.ModeOfPayment, P.DispatchedThrough, P.PaymentTerms, P.IncoTerms, P.DeliveryTerms, P.Currency, " & vbCrLf
				text2 += " P.Comments, P.Remarks, P.ActionRemarks, " & vbCrLf
				text2 += " Action.UserName AS ActionBy, P.ActionDt, Printed.UserName AS PrintBy, P.PrintDt, " & vbCrLf
				text2 += " P.CreationDt, Created.UserName AS CreatedBy, P.ModificationDt, Modified.UserName AS ModifiedBy " & vbCrLf
				text2 += " FROM PO AS P " & vbCrLf
				text2 += " INNER JOIN POItems PI ON P.POID = PI.POID " & vbCrLf
				text2 += " INNER JOIN Vendor AS V ON P.VendorID = V.VendorID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Action ON P.ActionBy = Action.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Printed ON P.PrintBy = Printed.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Created ON P.CreatedBy = Created.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Modified ON P.ModifiedBy = Modified.UserID" & vbCrLf
			Else
				text2 = " SELECT P.POID AS ID, P.Status, P.POType, P.PONo, P.PODt, "
				Dim flag3 As Boolean = (Operators.CompareString(Me.lblDate.Text, "P.R. Date", False) = 0) Or (Operators.CompareString(Strings.Trim(Me.txtPRNo.Text), "", False) <> 0)
				If flag3 Then
					text2 += " PR.PRNo, PR.PRDt, "
				End If
				text2 += " Pr.ProductCode, Pr.ProductName, PI.UnitPrice, PI.FinalAmt Amount, " & vbCrLf
				text2 += " Pr.CatalogNo, Pr.ProductType, Pr.TertiaryUOM, Pr.TertiaryPackSize, PI.Quantity, Pr.Measurement," & vbCrLf
				text2 += " P.ValidUpto, P.DeliveryInDays, P.DeliveryDt, " & vbCrLf
				text2 += " P.Department, P.InvoiceAddress, P.BillingEmailID, P.ShipAddress, P.ShippingEmailID, P.GSTNo, P.PANNo, " & vbCrLf
				text2 += " P.VendorID, V.VendorName, P.VendorBillingAddress, P.VendorContactPerson, " & vbCrLf
				text2 += " P.VendorContactNo, P.VendorEmailID, P.VendorGSTNo, P.VendorPANNo,  " & vbCrLf
				text2 += " P.ModeOfPayment, P.DispatchedThrough, P.PaymentTerms, P.IncoTerms, P.DeliveryTerms, P.Currency, " & vbCrLf
				text2 += " P.Comments, P.Remarks, P.ActionRemarks, " & vbCrLf
				text2 += " Action.UserName AS ActionBy, P.ActionDt, Printed.UserName AS PrintBy, P.PrintDt, " & vbCrLf
				text2 += " P.CreationDt, Created.UserName AS CreatedBy, P.ModificationDt, Modified.UserName AS ModifiedBy " & vbCrLf
				text2 += " FROM PO AS P " & vbCrLf
				text2 += " INNER JOIN Vendor AS V ON P.VendorID = V.VendorID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Action ON P.ActionBy = Action.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Printed ON P.PrintBy = Printed.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Created ON P.CreatedBy = Created.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Modified ON P.ModifiedBy = Modified.UserID " & vbCrLf
				text2 += " INNER JOIN POItems PI ON P.POID = PI.POID " & vbCrLf
				text2 += " INNER JOIN Product Pr ON Pr.ProductID = PI.ProductID " & vbCrLf
			End If
			Dim flag4 As Boolean = (Operators.CompareString(Me.lblDate.Text, "P.R. Date", False) = 0) Or (Operators.CompareString(Strings.Trim(Me.txtPRNo.Text), "", False) <> 0)
			If flag4 Then
				text2 += " INNER JOIN POPR ON P.POID = POPR.POID " & vbCrLf
				text2 += " INNER JOIN PR ON PR.PRID = POPR.PRID " & vbCrLf
			End If
			text2 += " WHERE 1=1" & vbCrLf
			Dim flag5 As Boolean = Operators.CompareString(sID, "", False) <> 0
			If flag5 Then
				text2 = text2 + " AND P.POID = '" + sID + "'" & vbCrLf
				text = text + "POID = '" + sID + "'" & vbCrLf
			End If
			Dim flag6 As Boolean = Operators.CompareString(Strings.Trim(Me.txtNo.Text), "", False) <> 0
			If flag6 Then
				text2 = text2 + " AND (PONo LIKE '%" + Strings.Trim(Me.txtNo.Text) + "%')" & vbCrLf
				text = text + "PONo LIKE " + Strings.Trim(Me.txtNo.Text) + vbCrLf
			End If
			Dim flag7 As Boolean = Operators.CompareString(Strings.Trim(Me.txtPRNo.Text), "", False) <> 0
			If flag7 Then
				text2 = text2 + " AND (PR.PRNo LIKE '%" + Strings.Trim(Me.txtPRNo.Text) + "%')" & vbCrLf
				text = text + "PRNo LIKE " + Strings.Trim(Me.txtPRNo.Text) + vbCrLf
			End If
			Dim flag8 As Boolean = Me.cmbVendor.SelectedIndex > -1
			If flag8 Then
				text2 = text2 + " AND (P.VendorID = '" + Strings.Trim(Me.cmbVendor.SelectedValue.ToString()) + "')" & vbCrLf
				text = text + "VendorID = " + Strings.Trim(Me.cmbVendor.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag9 As Boolean = Me.cmbType.SelectedIndex > 0
			If flag9 Then
				text2 = text2 + " AND (POType = '" + Me.cmbType.Text + "')" & vbCrLf
				text = text + ("POType = " + Me.cmbType.Text) + vbCrLf
			End If
			Dim flag10 As Boolean = Me.cmbStatus.SelectedIndex > 0
			If flag10 Then
				text2 = text2 + " AND (P.Status = '" + Me.cmbStatus.Text + "')" & vbCrLf
				text = text + ("Status = " + Me.cmbStatus.Text) + vbCrLf
			End If
			Dim flag11 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCreated.Text), "", False) <> 0
			If flag11 Then
				Dim flag12 As Boolean = Me.lblCreated.SelectedIndex >= 0
				If flag12 Then
					Dim flag13 As Boolean = Me.lblCreated.SelectedIndex = 0
					Dim text3 As String
					If flag13 Then
						text3 = "Created"
					Else
						text3 = "Modified"
					End If
					text2 = String.Concat(New String() { text2, " AND ", text3, ".UserName LIKE '%", Strings.Trim(Me.txtCreated.Text), "%'" })
					text = text + (text3 + "By LIKE " + Strings.Trim(Me.txtCreated.Text)) + vbCrLf
				End If
			End If
			Dim flag14 As Boolean = Me.lblDate.SelectedIndex >= 0
			If flag14 Then
				Dim text4 As String = Me.lblDate.Text
				Dim text5 As String
				If Operators.CompareString(text4, "Creation", False) <> 0 Then
					If Operators.CompareString(text4, "Last Modification", False) <> 0 Then
						If Operators.CompareString(text4, "P.O. Date", False) <> 0 Then
							If Operators.CompareString(text4, "P.R. Date", False) <> 0 Then
								If Operators.CompareString(text4, "Delivery Date", False) <> 0 Then
									text5 = ""
								Else
									text5 = "DeliveryDt"
								End If
							Else
								text5 = "PRDt"
							End If
						Else
							text5 = "PODt"
						End If
					Else
						text5 = "ModificationDt"
					End If
				Else
					text5 = "CreationDt"
				End If
				Dim flag15 As Boolean = Operators.CompareString(text5, "", False) <> 0
				If flag15 Then
					Dim flag16 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
					If flag16 Then
						text2 = String.Concat(New String() { text2, " AND ", text5, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
						text = text + String.Concat(New String() { text5, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
					Else
						Dim checked As Boolean = Me.dtpFrom.Checked
						If checked Then
							text2 = String.Concat(New String() { text2, " AND ", text5, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59"), "'" })
							text = text + String.Concat(New String() { text5, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
						End If
						Dim checked2 As Boolean = Me.dtpTo.Checked
						If checked2 Then
							text2 = String.Concat(New String() { text2, " AND ", text5, " BETWEEN '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
							text = text + String.Concat(New String() { text5, " BETWEEN  ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
						End If
					End If
				End If
			End If
			Dim flag17 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Item-wise", False) = 0
			If flag17 Then
				Dim flag18 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCode.Text), "", False) <> 0
				If flag18 Then
					text2 = text2 + " AND (Pr.ProductCode Like '%" + Strings.Trim(Me.txtCode.Text) + "%') "
					text = text + "ProductCode LIKE " + Strings.Trim(Me.txtCode.Text) + vbCrLf
				End If
				Dim flag19 As Boolean = Operators.CompareString(Strings.Trim(Me.txtName.Text), "", False) <> 0
				If flag19 Then
					text2 = text2 + " AND (Pr.ProductName Like '%" + Strings.Trim(Me.txtName.Text) + "%') "
					text = text + "ProductName LIKE " + Strings.Trim(Me.txtName.Text) + vbCrLf
				End If
				Dim flag20 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCatalogNo.Text), "", False) <> 0
				If flag20 Then
					text2 = text2 + " AND (Pr.CatalogNo Like '%" + Strings.Trim(Me.txtCatalogNo.Text) + "%') "
					text = text + "CatalogNo LIKE " + Strings.Trim(Me.txtCatalogNo.Text) + vbCrLf
				End If
			End If
			Dim flag21 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "PO-wise", False) = 0
			If flag21 Then
				text2 += " GROUP BY P.POID, P.Status, P.POType, P.PONo, P.PODt, "
				Dim flag22 As Boolean = (Operators.CompareString(Me.lblDate.Text, "P.R. Date", False) = 0) Or (Operators.CompareString(Strings.Trim(Me.txtPRNo.Text), "", False) <> 0)
				If flag22 Then
					text2 += " PR.PRNo, PR.PRDt, "
				End If
				text2 += " P.ValidUpto, P.DeliveryInDays, P.DeliveryDt,  " & vbCrLf
				text2 += " P.Department, P.InvoiceAddress, P.BillingEmailID, P.ShipAddress, P.ShippingEmailID, P.GSTNo, P.PANNo,  " & vbCrLf
				text2 += " P.VendorID, V.VendorName, P.VendorBillingAddress, P.VendorContactPerson,  " & vbCrLf
				text2 += " P.VendorContactNo, P.VendorEmailID, P.VendorGSTNo, P.VendorPANNo,  " & vbCrLf
				text2 += " P.ModeOfPayment, P.DispatchedThrough, P.PaymentTerms, P.IncoTerms, P.DeliveryTerms, P.Currency,  " & vbCrLf
				text2 += " P.Comments, P.Remarks, P.ActionRemarks, Action.UserName, P.ActionDt, Printed.UserName, P.PrintDt,  " & vbCrLf
				text2 += " Created.EmailID, Modified.EmailID, P.CreationDt, Created.UserName, P.ModificationDt, Modified.UserName" & vbCrLf
			End If
			text2 += " ORDER BY PODt"
			Dim data As DataTable = MainModule.GetData(text2)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = Nothing
			Me.dgvList.DataSource = data
			Me.dgvList.Columns("ID").Visible = False
			Me.dgvList.Columns("VendorID").Visible = False
			Me.dgvList.Columns("Status").HeaderText = "Status"
			Me.dgvList.Columns("POType").HeaderText = "PO Type"
			Me.dgvList.Columns("PONo").HeaderText = "PO No."
			Me.dgvList.Columns("PODt").HeaderText = "PO Date"
			Me.dgvList.Columns("ValidUpto").HeaderText = "Valid Upto"
			Me.dgvList.Columns("DeliveryInDays").HeaderText = "Delivery In Days"
			Me.dgvList.Columns("DeliveryDt").HeaderText = "Delivery Date"
			Me.dgvList.Columns("InvoiceAddress").HeaderText = "Invoice Address"
			Me.dgvList.Columns("BillingEmailID").HeaderText = "Billing Email ID"
			Me.dgvList.Columns("ShipAddress").HeaderText = "Ship Address"
			Me.dgvList.Columns("ShippingEmailID").HeaderText = "Shipping Email ID"
			Me.dgvList.Columns("GSTNo").HeaderText = "GST No."
			Me.dgvList.Columns("PANNo").HeaderText = "PAN No."
			Me.dgvList.Columns("VendorName").HeaderText = "Vendor Name"
			Me.dgvList.Columns("VendorBillingAddress").HeaderText = "Vendor Billing Address"
			Me.dgvList.Columns("VendorContactPerson").HeaderText = "Vendor Contact Person"
			Me.dgvList.Columns("VendorContactNo").HeaderText = "Vendor Contact No."
			Me.dgvList.Columns("VendorEmailID").HeaderText = "Vendor Email ID"
			Me.dgvList.Columns("VendorGSTNo").HeaderText = "Vendor GST No."
			Me.dgvList.Columns("VendorPANNo").HeaderText = "Vendor PAN No."
			Me.dgvList.Columns("ModeOfPayment").HeaderText = "Mode Of Payment"
			Me.dgvList.Columns("DispatchedThrough").HeaderText = "Dispatched Through"
			Me.dgvList.Columns("PaymentTerms").HeaderText = "Payment Terms"
			Me.dgvList.Columns("IncoTerms").HeaderText = "Inco Terms"
			Me.dgvList.Columns("DeliveryTerms").HeaderText = "Delivery Terms"
			Me.dgvList.Columns("Currency").HeaderText = "Currency"
			Me.dgvList.Columns("ActionBy").HeaderText = "Action By"
			Me.dgvList.Columns("ActionDt").HeaderText = "Action Date"
			Me.dgvList.Columns("PrintBy").HeaderText = "Print By"
			Me.dgvList.Columns("PrintDt").HeaderText = "Print Date"
			Me.dgvList.Columns("CreationDt").HeaderText = "Creation Date"
			Me.dgvList.Columns("CreatedBy").HeaderText = "Created By"
			Me.dgvList.Columns("ModificationDt").HeaderText = "Modification Date"
			Me.dgvList.Columns("ModifiedBy").HeaderText = "Modified By"
			Me.dgvList.Columns("PODt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("DeliveryDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("ValidUpto").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("ActionDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("PrintDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("CreationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh: mm:ss tt"
			Me.dgvList.Columns("ModificationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			Me.dgvList.Columns("Status").Width = 132
			Me.dgvList.Columns("POType").Width = 100
			Me.dgvList.Columns("PONo").Width = 130
			Me.dgvList.Columns("PODt").Width = 120
			Me.dgvList.Columns("ValidUpto").Width = 120
			Me.dgvList.Columns("DeliveryInDays").Width = 119
			Me.dgvList.Columns("DeliveryDt").Width = 120
			Me.dgvList.Columns("InvoiceAddress").Width = 250
			Me.dgvList.Columns("BillingEmailID").Width = 200
			Me.dgvList.Columns("ShipAddress").Width = 250
			Me.dgvList.Columns("ShippingEmailID").Width = 250
			Me.dgvList.Columns("GSTNo").Width = 150
			Me.dgvList.Columns("PANNo").Width = 150
			Me.dgvList.Columns("VendorName").Width = 300
			Me.dgvList.Columns("VendorBillingAddress").Width = 300
			Me.dgvList.Columns("VendorContactPerson").Width = 200
			Me.dgvList.Columns("VendorContactNo").Width = 150
			Me.dgvList.Columns("VendorEmailID").Width = 250
			Me.dgvList.Columns("VendorGSTNo").Width = 120
			Me.dgvList.Columns("VendorPANNo").Width = 120
			Me.dgvList.Columns("ModeOfPayment").Width = 150
			Me.dgvList.Columns("DispatchedThrough").Width = 150
			Me.dgvList.Columns("PaymentTerms").Width = 300
			Me.dgvList.Columns("IncoTerms").Width = 300
			Me.dgvList.Columns("DeliveryTerms").Width = 300
			Me.dgvList.Columns("Currency").Width = 100
			Me.dgvList.Columns("ActionBy").Width = 130
			Me.dgvList.Columns("ActionDt").Width = 120
			Me.dgvList.Columns("PrintBy").Width = 130
			Me.dgvList.Columns("PrintDt").Width = 120
			Me.dgvList.Columns("CreationDt").Width = 170
			Me.dgvList.Columns("CreatedBy").Width = 140
			Me.dgvList.Columns("ModificationDt").Width = 170
			Me.dgvList.Columns("ModifiedBy").Width = 140
			Me.dgvList.Columns("Amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
			Dim flag23 As Boolean = data.Columns.Contains("PRNo")
			If flag23 Then
				Me.dgvList.Columns("PRNo").HeaderText = "PR No."
				Me.dgvList.Columns("PRDt").HeaderText = "PR Date"
				Me.dgvList.Columns("PRNo").Width = 130
				Me.dgvList.Columns("PRDt").Width = 120
				Me.dgvList.Columns("PRDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			End If
			Dim flag24 As Boolean = data.Columns.Contains("ProductCode")
			If flag24 Then
				Me.dgvList.Columns("ProductCode").HeaderText = "Product Code"
				Me.dgvList.Columns("CatalogNo").HeaderText = "Catalog No."
				Me.dgvList.Columns("ProductName").HeaderText = "Product Name"
				Me.dgvList.Columns("ProductType").HeaderText = "Product Type"
				Me.dgvList.Columns("TertiaryUOM").HeaderText = "Tertiary UOM"
				Me.dgvList.Columns("TertiaryPackSize").HeaderText = "Tertiary PackSize"
				Me.dgvList.Columns("Quantity").HeaderText = "Quantity"
				Me.dgvList.Columns("UnitPrice").HeaderText = "Unit Price"
				Me.dgvList.Columns("ProductCode").Width = 180
				Me.dgvList.Columns("CatalogNo").Width = 180
				Me.dgvList.Columns("ProductName").Width = 300
				Me.dgvList.Columns("ProductType").Width = 110
				Me.dgvList.Columns("TertiaryUOM").Width = 90
				Me.dgvList.Columns("TertiaryPackSize").Width = 72
				Me.dgvList.Columns("Quantity").Width = 60
				Me.dgvList.Columns("TertiaryPackSize").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("Quantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("UnitPrice").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
			End If
			MainModule.TrnLog(Me.Text, Me.cmbReportType.Text + " Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x06000A1E RID: 2590 RVA: 0x000592F0 File Offset: 0x000574F0
		Private Sub POItemwiseReceived(sID As String)
			Dim text As String = ""
			Dim text2 As String = " SELECT PO.POID AS ID, PO.POType, PO.PONo, PO.PODt, V.VendorName, P.CatalogNo, P.ProductName, PI.Description,  " & vbCrLf
			text2 += " PI.Quantity, ISNULL(PI.RecQty,0) RecQty, PI.Quantity - ISNULL(PI.RecQty,0) AS BalQty " & vbCrLf
			text2 += " FROM PO INNER JOIN POItems PI ON PO.POID = PI.POID " & vbCrLf
			text2 += " INNER JOIN Product P ON P.ProductID = PI.ProductID " & vbCrLf
			text2 += " INNER JOIN Vendor V ON PO.VendorID = V.VendorID " & vbCrLf
			text2 += " WHERE 1=1 AND P.IsGRNApplicable = 1 " & vbCrLf
			Dim flag As Boolean = Operators.CompareString(sID, "", False) <> 0
			If flag Then
				text2 = text2 + " AND P.POID = '" + sID + "'" & vbCrLf
				text = text + "POID = '" + sID + "'" & vbCrLf
			End If
			Dim flag2 As Boolean = Operators.CompareString(Strings.Trim(Me.txtNo.Text), "", False) <> 0
			If flag2 Then
				text2 = text2 + " AND (PONo LIKE '%" + Strings.Trim(Me.txtNo.Text) + "%')" & vbCrLf
				text = text + "PONo LIKE " + Strings.Trim(Me.txtNo.Text) + vbCrLf
			End If
			Dim flag3 As Boolean = Operators.CompareString(Strings.Trim(Me.txtPRNo.Text), "", False) <> 0
			If flag3 Then
				text2 = text2 + " AND (PRNo LIKE '%" + Strings.Trim(Me.txtPRNo.Text) + "%')" & vbCrLf
				text = text + "PRNo LIKE " + Strings.Trim(Me.txtPRNo.Text) + vbCrLf
			End If
			Dim flag4 As Boolean = Me.cmbVendor.SelectedIndex > -1
			If flag4 Then
				text2 = text2 + " AND (P.VendorID = '" + Strings.Trim(Me.cmbVendor.SelectedValue.ToString()) + "')" & vbCrLf
				text = text + "VendorID = " + Strings.Trim(Me.cmbVendor.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag5 As Boolean = Me.cmbType.SelectedIndex > 0
			If flag5 Then
				text2 = text2 + " AND (POType = '" + Me.cmbType.Text + "')" & vbCrLf
				text = text + ("POType = " + Me.cmbType.Text) + vbCrLf
			End If
			Dim flag6 As Boolean = Me.cmbStatus.SelectedIndex > 0
			If flag6 Then
				text2 = text2 + " AND (Status = '" + Me.cmbStatus.Text + "')" & vbCrLf
				text = text + ("Status = " + Me.cmbStatus.Text) + vbCrLf
			End If
			Dim flag7 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCreated.Text), "", False) <> 0
			If flag7 Then
				Dim flag8 As Boolean = Me.lblCreated.SelectedIndex >= 0
				If flag8 Then
					Dim flag9 As Boolean = Me.lblCreated.SelectedIndex = 0
					Dim text3 As String
					If flag9 Then
						text3 = "Created"
					Else
						text3 = "Modified"
					End If
					text2 = String.Concat(New String() { text2, " AND ", text3, ".UserName LIKE '%", Strings.Trim(Me.txtCreated.Text), "%'" })
					text = text + (text3 + "By LIKE " + Strings.Trim(Me.txtCreated.Text)) + vbCrLf
				End If
			End If
			Dim flag10 As Boolean = Me.lblDate.SelectedIndex >= 0
			If flag10 Then
				Dim text4 As String = Me.lblDate.Text
				Dim text5 As String
				If Operators.CompareString(text4, "Creation", False) <> 0 Then
					If Operators.CompareString(text4, "Last Modification", False) <> 0 Then
						If Operators.CompareString(text4, "P.O. Date", False) <> 0 Then
							If Operators.CompareString(text4, "P.R. Date", False) <> 0 Then
								If Operators.CompareString(text4, "Delivery Date", False) <> 0 Then
									text5 = ""
								Else
									text5 = "DeliveryDt"
								End If
							Else
								text5 = "PRDt"
							End If
						Else
							text5 = "PODt"
						End If
					Else
						text5 = "ModificationDt"
					End If
				Else
					text5 = "CreationDt"
				End If
				Dim flag11 As Boolean = Operators.CompareString(text5, "", False) <> 0
				If flag11 Then
					Dim flag12 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
					If flag12 Then
						text2 = String.Concat(New String() { text2, " AND ", text5, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
						text = text + String.Concat(New String() { text5, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
					Else
						Dim checked As Boolean = Me.dtpFrom.Checked
						If checked Then
							text2 = String.Concat(New String() { text2, " AND ", text5, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59"), "'" })
							text = text + String.Concat(New String() { text5, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
						End If
						Dim checked2 As Boolean = Me.dtpTo.Checked
						If checked2 Then
							text2 = String.Concat(New String() { text2, " AND ", text5, " BETWEEN '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
							text = text + String.Concat(New String() { text5, " BETWEEN  ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
						End If
					End If
				End If
			End If
			Dim flag13 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Item-wise", False) = 0
			If flag13 Then
				Dim flag14 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCode.Text), "", False) <> 0
				If flag14 Then
					text2 = text2 + " AND (P.ProductCode Like '%" + Strings.Trim(Me.txtCode.Text) + "%') "
					text = text + "ProductCode LIKE " + Strings.Trim(Me.txtCode.Text) + vbCrLf
				End If
				Dim flag15 As Boolean = Operators.CompareString(Strings.Trim(Me.txtName.Text), "", False) <> 0
				If flag15 Then
					text2 = text2 + " AND (P.ProductName Like '%" + Strings.Trim(Me.txtName.Text) + "%') "
					text = text + "ProductName LIKE " + Strings.Trim(Me.txtName.Text) + vbCrLf
				End If
				Dim flag16 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCatalogNo.Text), "", False) <> 0
				If flag16 Then
					text2 = text2 + " AND (P.CatalogNo Like '%" + Strings.Trim(Me.txtCatalogNo.Text) + "%') "
					text = text + "CatalogNo LIKE " + Strings.Trim(Me.txtCatalogNo.Text) + vbCrLf
				End If
			End If
			Dim text6 As String = Me.cmbItemStatus.Text
			If Operators.CompareString(text6, "Pending", False) <> 0 Then
				If Operators.CompareString(text6, "Partial", False) <> 0 Then
					If Operators.CompareString(text6, "Complete", False) = 0 Then
						text2 += " AND ISNULL(PI.RecQty,0) = PI.Quantity" & vbCrLf
					End If
				Else
					text2 += " AND (ISNULL(PI.RecQty,0) > 0 AND ISNULL(PI.RecQty,0) < PI.Quantity) " & vbCrLf
				End If
			Else
				text2 += " AND ISNULL(PI.RecQty,0) = 0" & vbCrLf
			End If
			text2 += " ORDER BY PODt"
			Dim data As DataTable = MainModule.GetData(text2)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = Nothing
			Me.dgvList.DataSource = data
			Me.dgvList.Columns("ID").Visible = False
			Me.dgvList.Columns("POType").HeaderText = "PO Type"
			Me.dgvList.Columns("PONo").HeaderText = "PO No."
			Me.dgvList.Columns("PODt").HeaderText = "PO Date"
			Me.dgvList.Columns("VendorName").HeaderText = "Vendor Name"
			Me.dgvList.Columns("CatalogNo").HeaderText = "Catalog No."
			Me.dgvList.Columns("ProductName").HeaderText = "Product Name"
			Me.dgvList.Columns("Quantity").HeaderText = "PO Qty."
			Me.dgvList.Columns("RecQty").HeaderText = "Received Qty."
			Me.dgvList.Columns("BalQty").HeaderText = "Balance Qty."
			Me.dgvList.Columns("PODt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("POType").Width = 100
			Me.dgvList.Columns("PONo").Width = 130
			Me.dgvList.Columns("PODt").Width = 100
			Me.dgvList.Columns("VendorName").Width = 300
			Me.dgvList.Columns("CatalogNo").Width = 120
			Me.dgvList.Columns("ProductName").Width = 250
			Me.dgvList.Columns("Description").Width = 300
			Me.dgvList.Columns("Quantity").Width = 90
			Me.dgvList.Columns("RecQty").Width = 100
			Me.dgvList.Columns("BalQty").Width = 90
			Me.dgvList.Columns("Quantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			Me.dgvList.Columns("RecQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			Me.dgvList.Columns("BalQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			MainModule.TrnLog(Me.Text, Me.cmbReportType.Text + " Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x06000A1F RID: 2591 RVA: 0x00059F20 File Offset: 0x00058120
		Private Sub POGRNwiseReceived(sID As String)
			Dim text As String = ""
			Dim text2 As String = " SELECT PO.POID AS ID, PO.POType, PO.PONo, PO.PODt, V.VendorName, P.ProductID, P.CatalogNo, P.ProductName,  " & vbCrLf
			text2 += " PI.Description, PI.Quantity, G.GRNNo, G.BatchNo, G.ReceivedQty " & vbCrLf
			text2 += " FROM PO INNER JOIN POItems PI ON PO.POID = PI.POID " & vbCrLf
			text2 += " INNER JOIN Product P ON P.ProductID = PI.ProductID " & vbCrLf
			text2 += " INNER JOIN Vendor V ON PO.VendorID = V.VendorID " & vbCrLf
			text2 += " LEFT OUTER JOIN  " & vbCrLf
			text2 += " (SELECT G.POID, G.GRNID, G.GRNNo, GI.ProductID, GI.BatchNo, GI.ReceivedQty * ISNULL(GI.PrimaryPackSize,1) * ISNULL(GI.TertiaryPackSize,1) ReceivedQty " & vbCrLf
			text2 += "  FROM GRN G INNER JOIN GRNItems GI ON G.GRNID = GI.GRNID " & vbCrLf
			text2 += "  WHERE G.Status NOT IN ('GRN Rejected','GRN Cancelled')) G ON PO.POID = G.POID AND PI.ProductID = G.ProductID  " & vbCrLf
			text2 += " WHERE 1=1 AND P.IsGRNApplicable = 1 " & vbCrLf
			Dim flag As Boolean = Operators.CompareString(sID, "", False) <> 0
			If flag Then
				text2 = text2 + " AND P.POID = '" + sID + "'" & vbCrLf
				text = text + "POID = '" + sID + "'" & vbCrLf
			End If
			Dim flag2 As Boolean = Operators.CompareString(Strings.Trim(Me.txtNo.Text), "", False) <> 0
			If flag2 Then
				text2 = text2 + " AND (PONo LIKE '%" + Strings.Trim(Me.txtNo.Text) + "%')" & vbCrLf
				text = text + "PONo LIKE " + Strings.Trim(Me.txtNo.Text) + vbCrLf
			End If
			Dim flag3 As Boolean = Operators.CompareString(Strings.Trim(Me.txtPRNo.Text), "", False) <> 0
			If flag3 Then
				text2 = text2 + " AND (PRNo LIKE '%" + Strings.Trim(Me.txtPRNo.Text) + "%')" & vbCrLf
				text = text + "PRNo LIKE " + Strings.Trim(Me.txtPRNo.Text) + vbCrLf
			End If
			Dim flag4 As Boolean = Me.cmbVendor.SelectedIndex > -1
			If flag4 Then
				text2 = text2 + " AND (P.VendorID = '" + Strings.Trim(Me.cmbVendor.SelectedValue.ToString()) + "')" & vbCrLf
				text = text + "VendorID = " + Strings.Trim(Me.cmbVendor.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag5 As Boolean = Me.cmbType.SelectedIndex > 0
			If flag5 Then
				text2 = text2 + " AND (POType = '" + Me.cmbType.Text + "')" & vbCrLf
				text = text + ("POType = " + Me.cmbType.Text) + vbCrLf
			End If
			Dim flag6 As Boolean = Me.cmbStatus.SelectedIndex > 0
			If flag6 Then
				text2 = text2 + " AND (Status = '" + Me.cmbStatus.Text + "')" & vbCrLf
				text = text + ("Status = " + Me.cmbStatus.Text) + vbCrLf
			End If
			Dim flag7 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCreated.Text), "", False) <> 0
			If flag7 Then
				Dim flag8 As Boolean = Me.lblCreated.SelectedIndex >= 0
				If flag8 Then
					Dim flag9 As Boolean = Me.lblCreated.SelectedIndex = 0
					Dim text3 As String
					If flag9 Then
						text3 = "Created"
					Else
						text3 = "Modified"
					End If
					text2 = String.Concat(New String() { text2, " AND ", text3, ".UserName LIKE '%", Strings.Trim(Me.txtCreated.Text), "%'" })
					text = text + (text3 + "By LIKE " + Strings.Trim(Me.txtCreated.Text)) + vbCrLf
				End If
			End If
			Dim flag10 As Boolean = Me.lblDate.SelectedIndex >= 0
			If flag10 Then
				Dim text4 As String = Me.lblDate.Text
				Dim text5 As String
				If Operators.CompareString(text4, "Creation", False) <> 0 Then
					If Operators.CompareString(text4, "Last Modification", False) <> 0 Then
						If Operators.CompareString(text4, "P.O. Date", False) <> 0 Then
							If Operators.CompareString(text4, "P.R. Date", False) <> 0 Then
								If Operators.CompareString(text4, "Delivery Date", False) <> 0 Then
									text5 = ""
								Else
									text5 = "DeliveryDt"
								End If
							Else
								text5 = "PRDt"
							End If
						Else
							text5 = "PODt"
						End If
					Else
						text5 = "ModificationDt"
					End If
				Else
					text5 = "CreationDt"
				End If
				Dim flag11 As Boolean = Operators.CompareString(text5, "", False) <> 0
				If flag11 Then
					Dim flag12 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
					If flag12 Then
						text2 = String.Concat(New String() { text2, " AND ", text5, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
						text = text + String.Concat(New String() { text5, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
					Else
						Dim checked As Boolean = Me.dtpFrom.Checked
						If checked Then
							text2 = String.Concat(New String() { text2, " AND ", text5, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59"), "'" })
							text = text + String.Concat(New String() { text5, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
						End If
						Dim checked2 As Boolean = Me.dtpTo.Checked
						If checked2 Then
							text2 = String.Concat(New String() { text2, " AND ", text5, " BETWEEN '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
							text = text + String.Concat(New String() { text5, " BETWEEN  ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
						End If
					End If
				End If
			End If
			Dim flag13 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Item-wise", False) = 0
			If flag13 Then
				Dim flag14 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCode.Text), "", False) <> 0
				If flag14 Then
					text2 = text2 + " AND (P.ProductCode Like '%" + Strings.Trim(Me.txtCode.Text) + "%') "
					text = text + "ProductCode LIKE " + Strings.Trim(Me.txtCode.Text) + vbCrLf
				End If
				Dim flag15 As Boolean = Operators.CompareString(Strings.Trim(Me.txtName.Text), "", False) <> 0
				If flag15 Then
					text2 = text2 + " AND (P.ProductName Like '%" + Strings.Trim(Me.txtName.Text) + "%') "
					text = text + "ProductName LIKE " + Strings.Trim(Me.txtName.Text) + vbCrLf
				End If
				Dim flag16 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCatalogNo.Text), "", False) <> 0
				If flag16 Then
					text2 = text2 + " AND (P.CatalogNo Like '%" + Strings.Trim(Me.txtCatalogNo.Text) + "%') "
					text = text + "CatalogNo LIKE " + Strings.Trim(Me.txtCatalogNo.Text) + vbCrLf
				End If
			End If
			text2 += " ORDER BY PO.PODt, P.ProductID "
			Dim data As DataTable = MainModule.GetData(text2)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = Nothing
			Me.dgvList.DataSource = data
			Me.dgvList.Columns("ID").Visible = False
			Me.dgvList.Columns("ProductID").Visible = False
			Me.dgvList.Columns("POType").HeaderText = "PO Type"
			Me.dgvList.Columns("PONo").HeaderText = "PO No."
			Me.dgvList.Columns("PODt").HeaderText = "PO Date"
			Me.dgvList.Columns("VendorName").HeaderText = "Vendor Name"
			Me.dgvList.Columns("CatalogNo").HeaderText = "Catalog No."
			Me.dgvList.Columns("ProductName").HeaderText = "Product Name"
			Me.dgvList.Columns("Quantity").HeaderText = "PO Qty"
			Me.dgvList.Columns("GRNNo").HeaderText = "GRN No."
			Me.dgvList.Columns("BatchNo").HeaderText = "Batch No."
			Me.dgvList.Columns("ReceivedQty").HeaderText = "Received Qty."
			Me.dgvList.Columns("PODt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("POType").Width = 100
			Me.dgvList.Columns("PONo").Width = 130
			Me.dgvList.Columns("PODt").Width = 100
			Me.dgvList.Columns("VendorName").Width = 300
			Me.dgvList.Columns("CatalogNo").Width = 120
			Me.dgvList.Columns("ProductName").Width = 250
			Me.dgvList.Columns("Description").Width = 300
			Me.dgvList.Columns("Quantity").Width = 90
			Me.dgvList.Columns("GRNNo").Width = 140
			Me.dgvList.Columns("BatchNo").Width = 120
			Me.dgvList.Columns("ReceivedQty").Width = 100
			Me.dgvList.Columns("Quantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			Me.dgvList.Columns("ReceivedQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			Me.FilterDataGrid()
			MainModule.TrnLog(Me.Text, Me.cmbReportType.Text + " Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x06000A20 RID: 2592 RVA: 0x0005AB58 File Offset: 0x00058D58
		Private Sub FilterDataGrid()
			' The following expression was wrapped in a checked-statement
			Dim j As Integer
			For i As Integer = 0 To Me.dgvList.Rows.Count - 1
				Dim text As String = Conversions.ToString(Me.dgvList.Rows(i).Cells("ID").Value)
				Dim text2 As String = Conversions.ToString(Me.dgvList.Rows(i).Cells("ProductID").Value)
				j = i + 1
				While j < Me.dgvList.Rows.Count
					Dim text3 As String = Conversions.ToString(Me.dgvList.Rows(j).Cells("ID").Value)
					Dim text4 As String = Conversions.ToString(Me.dgvList.Rows(j).Cells("ProductID").Value)
					Dim flag As Boolean = (Operators.CompareString(text, text3, False) = 0) And (Operators.CompareString(text2, text4, False) = 0)
					If Not flag Then
						Exit While
					End If
					Me.dgvList.Rows(j).Cells("ID").Value = DBNull.Value
					Me.dgvList.Rows(j).Cells("POType").Value = ""
					Me.dgvList.Rows(j).Cells("PONo").Value = ""
					Me.dgvList.Rows(j).Cells("PODt").Value = DBNull.Value
					Me.dgvList.Rows(j).Cells("VendorName").Value = ""
					Me.dgvList.Rows(j).Cells("ProductID").Value = DBNull.Value
					Me.dgvList.Rows(j).Cells("CatalogNo").Value = ""
					Me.dgvList.Rows(j).Cells("ProductName").Value = ""
					Me.dgvList.Rows(j).Cells("Quantity").Value = DBNull.Value
					j += 1
				End While
			Next
		End Sub

		' Token: 0x0400043B RID: 1083
		Private pnlBasicDefaultHeight As Integer

		' Token: 0x0400043C RID: 1084
		Private pnlBasicSetHeight As Integer

		' Token: 0x0400043D RID: 1085
		Private pnlAdvDefaultHeight As Integer

		' Token: 0x0400043E RID: 1086
		Private pnlAdvSetHeight As Integer
	End Class
End Namespace
