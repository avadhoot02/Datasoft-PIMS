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
	' Token: 0x02000025 RID: 37
	<DesignerGenerated()>
	Public Partial Class GRNReport
		Inherits DockContent

		' Token: 0x1700038E RID: 910
		' (get) Token: 0x0600095F RID: 2399 RVA: 0x00052EA8 File Offset: 0x000510A8
		' (set) Token: 0x06000960 RID: 2400 RVA: 0x00052EB2 File Offset: 0x000510B2
		Friend Overridable Property GbBasic As GroupBox

		' Token: 0x1700038F RID: 911
		' (get) Token: 0x06000961 RID: 2401 RVA: 0x00052EBB File Offset: 0x000510BB
		' (set) Token: 0x06000962 RID: 2402 RVA: 0x00052EC5 File Offset: 0x000510C5
		Friend Overridable Property Label2 As Label

		' Token: 0x17000390 RID: 912
		' (get) Token: 0x06000963 RID: 2403 RVA: 0x00052ECE File Offset: 0x000510CE
		' (set) Token: 0x06000964 RID: 2404 RVA: 0x00052ED8 File Offset: 0x000510D8
		Friend Overridable Property txtPONo As TextBox

		' Token: 0x17000391 RID: 913
		' (get) Token: 0x06000965 RID: 2405 RVA: 0x00052EE1 File Offset: 0x000510E1
		' (set) Token: 0x06000966 RID: 2406 RVA: 0x00052EEB File Offset: 0x000510EB
		Friend Overridable Property cmbPlant As ComboBox

		' Token: 0x17000392 RID: 914
		' (get) Token: 0x06000967 RID: 2407 RVA: 0x00052EF4 File Offset: 0x000510F4
		' (set) Token: 0x06000968 RID: 2408 RVA: 0x00052EFE File Offset: 0x000510FE
		Friend Overridable Property Label1 As Label

		' Token: 0x17000393 RID: 915
		' (get) Token: 0x06000969 RID: 2409 RVA: 0x00052F07 File Offset: 0x00051107
		' (set) Token: 0x0600096A RID: 2410 RVA: 0x00052F11 File Offset: 0x00051111
		Friend Overridable Property txtNo As TextBox

		' Token: 0x17000394 RID: 916
		' (get) Token: 0x0600096B RID: 2411 RVA: 0x00052F1A File Offset: 0x0005111A
		' (set) Token: 0x0600096C RID: 2412 RVA: 0x00052F24 File Offset: 0x00051124
		Friend Overridable Property dtpFrom As DateTimePicker

		' Token: 0x17000395 RID: 917
		' (get) Token: 0x0600096D RID: 2413 RVA: 0x00052F2D File Offset: 0x0005112D
		' (set) Token: 0x0600096E RID: 2414 RVA: 0x00052F37 File Offset: 0x00051137
		Friend Overridable Property dtpTo As DateTimePicker

		' Token: 0x17000396 RID: 918
		' (get) Token: 0x0600096F RID: 2415 RVA: 0x00052F40 File Offset: 0x00051140
		' (set) Token: 0x06000970 RID: 2416 RVA: 0x00052F4A File Offset: 0x0005114A
		Friend Overridable Property Label16 As Label

		' Token: 0x17000397 RID: 919
		' (get) Token: 0x06000971 RID: 2417 RVA: 0x00052F53 File Offset: 0x00051153
		' (set) Token: 0x06000972 RID: 2418 RVA: 0x00052F5D File Offset: 0x0005115D
		Friend Overridable Property lblDate As ComboBox

		' Token: 0x17000398 RID: 920
		' (get) Token: 0x06000973 RID: 2419 RVA: 0x00052F66 File Offset: 0x00051166
		' (set) Token: 0x06000974 RID: 2420 RVA: 0x00052F70 File Offset: 0x00051170
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

		' Token: 0x17000399 RID: 921
		' (get) Token: 0x06000975 RID: 2421 RVA: 0x00052FB3 File Offset: 0x000511B3
		' (set) Token: 0x06000976 RID: 2422 RVA: 0x00052FBD File Offset: 0x000511BD
		Friend Overridable Property GbAdvanced As GroupBox

		' Token: 0x1700039A RID: 922
		' (get) Token: 0x06000977 RID: 2423 RVA: 0x00052FC6 File Offset: 0x000511C6
		' (set) Token: 0x06000978 RID: 2424 RVA: 0x00052FD0 File Offset: 0x000511D0
		Friend Overridable Property cmbStatus As ComboBox

		' Token: 0x1700039B RID: 923
		' (get) Token: 0x06000979 RID: 2425 RVA: 0x00052FD9 File Offset: 0x000511D9
		' (set) Token: 0x0600097A RID: 2426 RVA: 0x00052FE3 File Offset: 0x000511E3
		Friend Overridable Property Label11 As Label

		' Token: 0x1700039C RID: 924
		' (get) Token: 0x0600097B RID: 2427 RVA: 0x00052FEC File Offset: 0x000511EC
		' (set) Token: 0x0600097C RID: 2428 RVA: 0x00052FF6 File Offset: 0x000511F6
		Friend Overridable Property Label3 As Label

		' Token: 0x1700039D RID: 925
		' (get) Token: 0x0600097D RID: 2429 RVA: 0x00052FFF File Offset: 0x000511FF
		' (set) Token: 0x0600097E RID: 2430 RVA: 0x0005300C File Offset: 0x0005120C
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

		' Token: 0x1700039E RID: 926
		' (get) Token: 0x0600097F RID: 2431 RVA: 0x0005304F File Offset: 0x0005124F
		' (set) Token: 0x06000980 RID: 2432 RVA: 0x00053059 File Offset: 0x00051259
		Friend Overridable Property txtChallanNo As TextBox

		' Token: 0x1700039F RID: 927
		' (get) Token: 0x06000981 RID: 2433 RVA: 0x00053062 File Offset: 0x00051262
		' (set) Token: 0x06000982 RID: 2434 RVA: 0x0005306C File Offset: 0x0005126C
		Friend Overridable Property Label9 As Label

		' Token: 0x170003A0 RID: 928
		' (get) Token: 0x06000983 RID: 2435 RVA: 0x00053075 File Offset: 0x00051275
		' (set) Token: 0x06000984 RID: 2436 RVA: 0x0005307F File Offset: 0x0005127F
		Friend Overridable Property Label4 As Label

		' Token: 0x170003A1 RID: 929
		' (get) Token: 0x06000985 RID: 2437 RVA: 0x00053088 File Offset: 0x00051288
		' (set) Token: 0x06000986 RID: 2438 RVA: 0x00053092 File Offset: 0x00051292
		Friend Overridable Property txtCreated As TextBox

		' Token: 0x170003A2 RID: 930
		' (get) Token: 0x06000987 RID: 2439 RVA: 0x0005309B File Offset: 0x0005129B
		' (set) Token: 0x06000988 RID: 2440 RVA: 0x000530A5 File Offset: 0x000512A5
		Friend Overridable Property txtInvoiceNo As TextBox

		' Token: 0x170003A3 RID: 931
		' (get) Token: 0x06000989 RID: 2441 RVA: 0x000530AE File Offset: 0x000512AE
		' (set) Token: 0x0600098A RID: 2442 RVA: 0x000530B8 File Offset: 0x000512B8
		Friend Overridable Property lblCreated As ComboBox

		' Token: 0x170003A4 RID: 932
		' (get) Token: 0x0600098B RID: 2443 RVA: 0x000530C1 File Offset: 0x000512C1
		' (set) Token: 0x0600098C RID: 2444 RVA: 0x000530CC File Offset: 0x000512CC
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

		' Token: 0x170003A5 RID: 933
		' (get) Token: 0x0600098D RID: 2445 RVA: 0x0005310F File Offset: 0x0005130F
		' (set) Token: 0x0600098E RID: 2446 RVA: 0x00053119 File Offset: 0x00051319
		Friend Overridable Property grpListButton As GroupBox

		' Token: 0x170003A6 RID: 934
		' (get) Token: 0x0600098F RID: 2447 RVA: 0x00053122 File Offset: 0x00051322
		' (set) Token: 0x06000990 RID: 2448 RVA: 0x0005312C File Offset: 0x0005132C
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x170003A7 RID: 935
		' (get) Token: 0x06000991 RID: 2449 RVA: 0x00053135 File Offset: 0x00051335
		' (set) Token: 0x06000992 RID: 2450 RVA: 0x00053140 File Offset: 0x00051340
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

		' Token: 0x170003A8 RID: 936
		' (get) Token: 0x06000993 RID: 2451 RVA: 0x00053183 File Offset: 0x00051383
		' (set) Token: 0x06000994 RID: 2452 RVA: 0x00053190 File Offset: 0x00051390
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

		' Token: 0x170003A9 RID: 937
		' (get) Token: 0x06000995 RID: 2453 RVA: 0x000531D3 File Offset: 0x000513D3
		' (set) Token: 0x06000996 RID: 2454 RVA: 0x000531E0 File Offset: 0x000513E0
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

		' Token: 0x170003AA RID: 938
		' (get) Token: 0x06000997 RID: 2455 RVA: 0x00053223 File Offset: 0x00051423
		' (set) Token: 0x06000998 RID: 2456 RVA: 0x0005322D File Offset: 0x0005142D
		Friend Overridable Property lblRows As Label

		' Token: 0x170003AB RID: 939
		' (get) Token: 0x06000999 RID: 2457 RVA: 0x00053236 File Offset: 0x00051436
		' (set) Token: 0x0600099A RID: 2458 RVA: 0x00053240 File Offset: 0x00051440
		Friend Overridable Property dgvList As DataGridView

		' Token: 0x170003AC RID: 940
		' (get) Token: 0x0600099B RID: 2459 RVA: 0x00053249 File Offset: 0x00051449
		' (set) Token: 0x0600099C RID: 2460 RVA: 0x00053253 File Offset: 0x00051453
		Friend Overridable Property pnlItem As Panel

		' Token: 0x170003AD RID: 941
		' (get) Token: 0x0600099D RID: 2461 RVA: 0x0005325C File Offset: 0x0005145C
		' (set) Token: 0x0600099E RID: 2462 RVA: 0x00053266 File Offset: 0x00051466
		Friend Overridable Property txtName As TextBox

		' Token: 0x170003AE RID: 942
		' (get) Token: 0x0600099F RID: 2463 RVA: 0x0005326F File Offset: 0x0005146F
		' (set) Token: 0x060009A0 RID: 2464 RVA: 0x00053279 File Offset: 0x00051479
		Friend Overridable Property txtCatalogNo As TextBox

		' Token: 0x170003AF RID: 943
		' (get) Token: 0x060009A1 RID: 2465 RVA: 0x00053282 File Offset: 0x00051482
		' (set) Token: 0x060009A2 RID: 2466 RVA: 0x0005328C File Offset: 0x0005148C
		Friend Overridable Property Label14 As Label

		' Token: 0x170003B0 RID: 944
		' (get) Token: 0x060009A3 RID: 2467 RVA: 0x00053295 File Offset: 0x00051495
		' (set) Token: 0x060009A4 RID: 2468 RVA: 0x0005329F File Offset: 0x0005149F
		Friend Overridable Property Label6 As Label

		' Token: 0x170003B1 RID: 945
		' (get) Token: 0x060009A5 RID: 2469 RVA: 0x000532A8 File Offset: 0x000514A8
		' (set) Token: 0x060009A6 RID: 2470 RVA: 0x000532B2 File Offset: 0x000514B2
		Friend Overridable Property txtCode As TextBox

		' Token: 0x170003B2 RID: 946
		' (get) Token: 0x060009A7 RID: 2471 RVA: 0x000532BB File Offset: 0x000514BB
		' (set) Token: 0x060009A8 RID: 2472 RVA: 0x000532C5 File Offset: 0x000514C5
		Friend Overridable Property Label7 As Label

		' Token: 0x170003B3 RID: 947
		' (get) Token: 0x060009A9 RID: 2473 RVA: 0x000532CE File Offset: 0x000514CE
		' (set) Token: 0x060009AA RID: 2474 RVA: 0x000532D8 File Offset: 0x000514D8
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

		' Token: 0x170003B4 RID: 948
		' (get) Token: 0x060009AB RID: 2475 RVA: 0x0005331B File Offset: 0x0005151B
		' (set) Token: 0x060009AC RID: 2476 RVA: 0x00053325 File Offset: 0x00051525
		Friend Overridable Property Label13 As Label

		' Token: 0x060009AD RID: 2477 RVA: 0x00053330 File Offset: 0x00051530
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.InitializeComponent()
			Me.pnlBasicDefaultHeight = Me.GbBasic.Height
			Me.pnlBasicSetHeight = 23
			Me.pnlAdvDefaultHeight = 23
			Me.pnlAdvSetHeight = Me.GbAdvanced.Height
			Me.Text = "GRN Report"
		End Sub

		' Token: 0x060009AE RID: 2478 RVA: 0x000533B0 File Offset: 0x000515B0
		Private Sub SetSearchPanel()
			Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
			Me.GbBasic.Height = Me.pnlBasicDefaultHeight
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
		End Sub

		' Token: 0x060009AF RID: 2479 RVA: 0x00053404 File Offset: 0x00051604
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

		' Token: 0x060009B0 RID: 2480 RVA: 0x00053474 File Offset: 0x00051674
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

		' Token: 0x060009B1 RID: 2481 RVA: 0x000534E4 File Offset: 0x000516E4
		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x060009B2 RID: 2482 RVA: 0x00053519 File Offset: 0x00051719
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Me.SetSearchPanel()
			Designing.SetTheme(Me)
			Me.FillCombo()
			Me.ClearList()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x060009B3 RID: 2483 RVA: 0x00053550 File Offset: 0x00051750
		Private Sub FillCombo()
			Dim text As String = "SELECT VendorID, VendorName FROM Vendor ORDER BY VendorName"
			Dim data As DataTable = MainModule.GetData(text)
			Me.cmbVendor.ValueMember = "VendorID"
			Me.cmbVendor.DisplayMember = "VendorName"
			Me.cmbVendor.DataSource = data
			Me.cmbVendor.SelectedIndex = -1
		End Sub

		' Token: 0x060009B4 RID: 2484 RVA: 0x000535A8 File Offset: 0x000517A8
		Private Sub ClearList()
			Me.lblDate.SelectedIndex = 0
			Me.lblCreated.SelectedIndex = 0
			Me.txtNo.Text = ""
			Me.txtPONo.Text = ""
			Me.txtInvoiceNo.Text = ""
			Me.txtChallanNo.Text = ""
			Me.txtCreated.Text = ""
			Me.cmbVendor.Text = ""
			Me.cmbStatus.SelectedIndex = 0
			Me.cmbSummary.Text = "GRN-wise"
			Me.dtpFrom.Value = DateAndTime.Now
			Me.dtpTo.Value = DateAndTime.Now
			Me.dtpFrom.Checked = False
			Me.dtpTo.Checked = False
			Me.lblRows.Text = "0 - Rows"
			Me.dgvList.DataSource = Nothing
		End Sub

		' Token: 0x060009B5 RID: 2485 RVA: 0x000536AE File Offset: 0x000518AE
		Private Sub btnClearList_Click(sender As Object, e As EventArgs)
			Me.ClearList()
		End Sub

		' Token: 0x060009B6 RID: 2486 RVA: 0x000536B8 File Offset: 0x000518B8
		Private Sub btnExport_Click(sender As Object, e As EventArgs)
			MainModule.ExportToExcel(Me.dgvList, Me.Text)
		End Sub

		' Token: 0x060009B7 RID: 2487 RVA: 0x000536CD File Offset: 0x000518CD
		Private Sub cmbSummary_SelectedValueChanged(sender As Object, e As EventArgs)
			Me.SetSummary()
		End Sub

		' Token: 0x060009B8 RID: 2488 RVA: 0x000536D8 File Offset: 0x000518D8
		Private Sub SetSummary()
			Dim text As String = Me.cmbSummary.Text
			If Operators.CompareString(text, "GRN-wise", False) <> 0 Then
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
				Me.pnlAdvSetHeight = 137
				Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(Me.arrow_btnAdvanceExp_sml.Tag, "ArrowUp", False)
				If flag2 Then
					Me.GbAdvanced.Height = Me.pnlAdvSetHeight
				End If
			End If
			Me.txtCode.Text = ""
			Me.txtCatalogNo.Text = ""
			Me.txtName.Text = ""
		End Sub

		' Token: 0x060009B9 RID: 2489 RVA: 0x000537DC File Offset: 0x000519DC
		Private Sub cmbVendor_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbVendor.SelectedIndex = -1
			If flag Then
				Me.cmbVendor.Text = ""
			End If
		End Sub

		' Token: 0x060009BA RID: 2490 RVA: 0x00053810 File Offset: 0x00051A10
		Private Sub btnSearch_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SearchData("")
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x060009BB RID: 2491 RVA: 0x00053884 File Offset: 0x00051A84
		Private Sub SearchData(sID As String)
			Dim text As String = ""
			Dim flag As Boolean = Operators.CompareString(Me.cmbSummary.Text, "GRN-wise", False) = 0
			Dim text2 As String
			If flag Then
				text2 = " SELECT DISTINCT G.GRNID, G.Status GRNStatus, G.GRNType, G.GRNNo, G.GRNDt, G.VendorID, V.VendorName, " & vbCrLf
				text2 += " SUM(GI.TotalCost) TotalCost, G.POID, G.POType, G.PONo, G.PODt, G.InvoiceNo, G.InvoiceDt, G.ChallanNo, G.ChallanDt, " & vbCrLf
				text2 += " G.Remarks, G.ActionRemarks, " & vbCrLf
				text2 += " Action.UserName AS ActionBy, G.ActionDt, " & vbCrLf
				text2 += " Created.EmailID AS CreatedByEmailID, Modified.EmailID AS ModifiedByEmailID, " & vbCrLf
				text2 += " G.CreationDt, Created.UserName AS CreatedBy, G.ModificationDt, Modified.UserName AS ModifiedBy " & vbCrLf
				text2 += " FROM GRN AS G " & vbCrLf
				text2 += " INNER JOIN Vendor AS V ON G.VendorID = V.VendorID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Action ON G.ActionBy = Action.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Created ON G.CreatedBy = Created.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Modified ON G.ModifiedBy = Modified.UserID " & vbCrLf
				text2 += " INNER JOIN GRNItems AS GI ON G.GRNID = GI.GRNID " & vbCrLf
			Else
				text2 = " SELECT DISTINCT G.GRNID, G.Status GRNStatus, GI.Status AS Item_Status, G.GRNType, G.GRNNo, G.GRNDt, G.VendorID, V.VendorName, " & vbCrLf
				text2 += " GI.TotalCost, P.ProductCode, P.CatalogNo, P.ProductName, P.ProductType, GI.BatchNo, GI.MfgDt, GI.ExpDt, " & vbCrLf
				text2 += " P.TertiaryUOM, P.PrimaryUOM, GI.TertiaryPackSize, GI.PrimaryPackSize, GI.ReceivedQty, " & vbCrLf
				text2 += " G.POID, G.POType, G.PONo, G.PODt, G.InvoiceNo, G.InvoiceDt, G.ChallanNo, G.ChallanDt, " & vbCrLf
				text2 += " G.Remarks, G.ActionRemarks, " & vbCrLf
				text2 += " Action.UserName AS ActionBy, G.ActionDt,  " & vbCrLf
				text2 += " Created.EmailID AS CreatedByEmailID, Modified.EmailID AS ModifiedByEmailID, " & vbCrLf
				text2 += " G.CreationDt, Created.UserName AS CreatedBy, G.ModificationDt, Modified.UserName AS ModifiedBy " & vbCrLf
				text2 += " FROM GRN AS G " & vbCrLf
				text2 += " INNER JOIN Vendor AS V ON G.VendorID = V.VendorID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Action ON G.ActionBy = Action.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Created ON G.CreatedBy = Created.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Modified ON G.ModifiedBy = Modified.UserID " & vbCrLf
				text2 += " INNER JOIN GRNItems AS GI ON G.GRNID = GI.GRNID " & vbCrLf
				text2 += " INNER JOIN Product P ON GI.ProductID = P.ProductID " & vbCrLf
			End If
			text2 += " WHERE 1=1" & vbCrLf
			Dim flag2 As Boolean = Operators.CompareString(sID, "", False) <> 0
			If flag2 Then
				text2 = text2 + " AND G.GRNID = '" + sID + "'" & vbCrLf
				text = text + "GRNID = '" + sID + "'" & vbCrLf
			End If
			Dim flag3 As Boolean = Operators.CompareString(Strings.Trim(Me.txtNo.Text), "", False) <> 0
			If flag3 Then
				text2 = text2 + " And (GRNNo Like '%" + Strings.Trim(Me.txtNo.Text) + "%') " & vbCrLf
				text = text + "GRNNo LIKE " + Strings.Trim(Me.txtNo.Text) + vbCrLf
			End If
			Dim flag4 As Boolean = Operators.CompareString(Strings.Trim(Me.txtPONo.Text), "", False) <> 0
			If flag4 Then
				text2 = text2 + " AND (PONo LIKE '%" + Strings.Trim(Me.txtPONo.Text) + "%')" & vbCrLf
				text = text + "PONo LIKE " + Strings.Trim(Me.txtPONo.Text) + vbCrLf
			End If
			Dim flag5 As Boolean = Operators.CompareString(Strings.Trim(Me.txtInvoiceNo.Text), "", False) <> 0
			If flag5 Then
				text2 = text2 + " And (InvoiceNo Like '%" + Strings.Trim(Me.txtInvoiceNo.Text) + "%') " & vbCrLf
				text = text + "InvoiceNo LIKE " + Strings.Trim(Me.txtInvoiceNo.Text) + vbCrLf
			End If
			Dim flag6 As Boolean = Operators.CompareString(Strings.Trim(Me.txtChallanNo.Text), "", False) <> 0
			If flag6 Then
				text2 = text2 + " AND (ChallanNo LIKE '%" + Strings.Trim(Me.txtChallanNo.Text) + "%')" & vbCrLf
				text = text + "ChallanNo LIKE " + Strings.Trim(Me.txtChallanNo.Text) + vbCrLf
			End If
			Dim flag7 As Boolean = Me.cmbVendor.SelectedIndex > -1
			If flag7 Then
				text2 = text2 + " AND (G.VendorID = '" + Strings.Trim(Me.cmbVendor.SelectedValue.ToString()) + "')" & vbCrLf
				text = text + "VendorID = " + Strings.Trim(Me.cmbVendor.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag8 As Boolean = Me.cmbStatus.SelectedIndex > 0
			If flag8 Then
				text2 = text2 + " AND (G.Status = '" + Me.cmbStatus.Text + "')" & vbCrLf
				text = text + ("Status = " + Me.cmbStatus.Text) + vbCrLf
			End If
			Dim flag9 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCreated.Text), "", False) <> 0
			If flag9 Then
				Dim flag10 As Boolean = Me.lblCreated.SelectedIndex >= 0
				If flag10 Then
					Dim flag11 As Boolean = Me.lblCreated.SelectedIndex = 0
					Dim text3 As String
					If flag11 Then
						text3 = "Created"
					Else
						text3 = "Modified"
					End If
					text2 = String.Concat(New String() { text2, " AND ", text3, ".UserName LIKE '%", Strings.Trim(Me.txtCreated.Text), "%'" })
					text = text + (text3 + "By LIKE " + Strings.Trim(Me.txtCreated.Text)) + vbCrLf
				End If
			End If
			Dim flag12 As Boolean = Me.lblDate.SelectedIndex >= 0
			If flag12 Then
				Dim text4 As String = Me.lblDate.Text
				Dim text5 As String
				If Operators.CompareString(text4, "Creation", False) <> 0 Then
					If Operators.CompareString(text4, "Last Modification", False) <> 0 Then
						If Operators.CompareString(text4, "G.R.N Date", False) <> 0 Then
							If Operators.CompareString(text4, "P.O. Date", False) <> 0 Then
								If Operators.CompareString(text4, "Invoice Date", False) <> 0 Then
									If Operators.CompareString(text4, "Challan  Date", False) <> 0 Then
										text5 = ""
									Else
										text5 = "ChallanDt"
									End If
								Else
									text5 = "InvoiceDt"
								End If
							Else
								text5 = "PODt"
							End If
						Else
							text5 = "GRNDt"
						End If
					Else
						text5 = "ModificationDt"
					End If
				Else
					text5 = "CreationDt"
				End If
				Dim flag13 As Boolean = Operators.CompareString(text5, "", False) <> 0
				If flag13 Then
					Dim flag14 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
					If flag14 Then
						text2 = String.Concat(New String() { text2, " AND ", text5, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" & vbCrLf })
						text = text + String.Concat(New String() { text5, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
					Else
						Dim checked As Boolean = Me.dtpFrom.Checked
						If checked Then
							text2 = String.Concat(New String() { text2, " AND ", text5, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59"), "'" & vbCrLf })
							text = text + String.Concat(New String() { text5, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
						End If
						Dim checked2 As Boolean = Me.dtpTo.Checked
						If checked2 Then
							text2 = String.Concat(New String() { text2, " AND ", text5, " BETWEEN '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" & vbCrLf })
							text = text + String.Concat(New String() { text5, " BETWEEN  ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
						End If
					End If
				End If
			End If
			Dim flag15 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Item-wise", False) = 0
			If flag15 Then
				Dim flag16 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCode.Text), "", False) <> 0
				If flag16 Then
					text2 = text2 + " AND (P.ProductCode Like '%" + Strings.Trim(Me.txtCode.Text) + "%') " & vbCrLf
					text = text + "ProductCode LIKE " + Strings.Trim(Me.txtCode.Text) + vbCrLf
				End If
				Dim flag17 As Boolean = Operators.CompareString(Strings.Trim(Me.txtName.Text), "", False) <> 0
				If flag17 Then
					text2 = text2 + " AND (P.ProductName Like '%" + Strings.Trim(Me.txtName.Text) + "%') " & vbCrLf
					text = text + "ProductName LIKE " + Strings.Trim(Me.txtName.Text) + vbCrLf
				End If
				Dim flag18 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCatalogNo.Text), "", False) <> 0
				If flag18 Then
					text2 = text2 + " AND (P.CatalogNo Like '%" + Strings.Trim(Me.txtCatalogNo.Text) + "%') " & vbCrLf
					text = text + "CatalogNo LIKE " + Strings.Trim(Me.txtCatalogNo.Text) + vbCrLf
				End If
			End If
			Dim flag19 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "GRN-wise", False) = 0
			If flag19 Then
				text2 += " GROUP BY G.GRNID, G.Status, G.GRNType, G.GRNNo, G.GRNDt, G.VendorID, V.VendorName," & vbCrLf
				text2 += " G.POID, G.POType, G.PONo, G.PODt, G.InvoiceNo, G.InvoiceDt, G.ChallanNo, G.ChallanDt, " & vbCrLf
				text2 += " G.Remarks, G.ActionRemarks, Action.UserName, G.ActionDt, Created.EmailID, Modified.EmailID, " & vbCrLf
				text2 += " G.CreationDt, Created.UserName, G.ModificationDt, Modified.UserName " & vbCrLf
			End If
			text2 += " ORDER BY GRNNo"
			Dim data As DataTable = MainModule.GetData(text2)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = Nothing
			Me.dgvList.DataSource = data
			Me.dgvList.Columns("GRNID").Visible = False
			Me.dgvList.Columns("VendorID").Visible = False
			Me.dgvList.Columns("POID").Visible = False
			Me.dgvList.Columns("CreatedByEmailID").Visible = False
			Me.dgvList.Columns("ModifiedByEmailID").Visible = False
			Me.dgvList.Columns("Remarks").Visible = False
			Me.dgvList.Columns("ActionRemarks").Visible = False
			Me.dgvList.Columns("GRNStatus").HeaderText = "GRN Status"
			Me.dgvList.Columns("GRNType").HeaderText = "GRN Type"
			Me.dgvList.Columns("GRNNo").HeaderText = "GRN No."
			Me.dgvList.Columns("GRNDt").HeaderText = "GRN Date"
			Me.dgvList.Columns("VendorName").HeaderText = "Vendor Name"
			Me.dgvList.Columns("POType").HeaderText = "PO Type"
			Me.dgvList.Columns("PONo").HeaderText = "PO No."
			Me.dgvList.Columns("PODt").HeaderText = "PO Date"
			Me.dgvList.Columns("InvoiceNo").HeaderText = "Invoice No."
			Me.dgvList.Columns("InvoiceDt").HeaderText = "Invoice Date"
			Me.dgvList.Columns("ChallanNo").HeaderText = "Challan No."
			Me.dgvList.Columns("ChallanDt").HeaderText = "Challan Date"
			Me.dgvList.Columns("CreationDt").HeaderText = "Creation Date"
			Me.dgvList.Columns("ActionBy").HeaderText = "Action By"
			Me.dgvList.Columns("ActionDt").HeaderText = "Action Date"
			Me.dgvList.Columns("CreatedBy").HeaderText = "Created By"
			Me.dgvList.Columns("ModificationDt").HeaderText = "Modification Date"
			Me.dgvList.Columns("ModifiedBy").HeaderText = "Modified By"
			Me.dgvList.Columns("GRNDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("PODt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("InvoiceDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("ChallanDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("ActionDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh: mm:ss tt"
			Me.dgvList.Columns("CreationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			Me.dgvList.Columns("ModificationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			Me.dgvList.Columns("GRNType").Width = 90
			Me.dgvList.Columns("GRNNo").Width = 140
			Me.dgvList.Columns("GRNDt").Width = 120
			Me.dgvList.Columns("VendorName").Width = 315
			Me.dgvList.Columns("POType").Width = 100
			Me.dgvList.Columns("PONo").Width = 130
			Me.dgvList.Columns("PODt").Width = 120
			Me.dgvList.Columns("InvoiceNo").Width = 130
			Me.dgvList.Columns("InvoiceDt").Width = 120
			Me.dgvList.Columns("ChallanNo").Width = 130
			Me.dgvList.Columns("ChallanDt").Width = 120
			Me.dgvList.Columns("ActionDt").Width = 170
			Me.dgvList.Columns("ActionBy").Width = 140
			Me.dgvList.Columns("GRNStatus").Width = 132
			Me.dgvList.Columns("CreationDt").Width = 170
			Me.dgvList.Columns("CreatedBy").Width = 140
			Me.dgvList.Columns("ModificationDt").Width = 170
			Me.dgvList.Columns("ModifiedBy").Width = 140
			Dim flag20 As Boolean = data.Columns.Contains("ProductCode")
			If flag20 Then
				Me.dgvList.Columns("ProductCode").HeaderText = "Product Code"
				Me.dgvList.Columns("CatalogNo").HeaderText = "Catalog No."
				Me.dgvList.Columns("ProductName").HeaderText = "Product Name"
				Me.dgvList.Columns("ProductType").HeaderText = "Product Type"
				Me.dgvList.Columns("BatchNo").HeaderText = "Batch No."
				Me.dgvList.Columns("MfgDt").HeaderText = "Mfg. Date"
				Me.dgvList.Columns("ExpDt").HeaderText = "Expiry Date"
				Me.dgvList.Columns("TertiaryUOM").HeaderText = "Tertiary UOM"
				Me.dgvList.Columns("PrimaryUOM").HeaderText = "Primary UOM"
				Me.dgvList.Columns("TertiaryPackSize").HeaderText = "Tertiary PackSize"
				Me.dgvList.Columns("PrimaryPackSize").HeaderText = "Primary PackSize"
				Me.dgvList.Columns("ReceivedQty").HeaderText = "Tertiary Qty."
				Me.dgvList.Columns("Item_Status").HeaderText = "Item Status"
				Me.dgvList.Columns("ProductCode").Width = 180
				Me.dgvList.Columns("CatalogNo").Width = 180
				Me.dgvList.Columns("ProductName").Width = 400
				Me.dgvList.Columns("ProductType").Width = 110
				Me.dgvList.Columns("BatchNo").Width = 100
				Me.dgvList.Columns("MfgDt").Width = 120
				Me.dgvList.Columns("ExpDt").Width = 120
				Me.dgvList.Columns("TertiaryUOM").Width = 90
				Me.dgvList.Columns("PrimaryUOM").Width = 90
				Me.dgvList.Columns("TertiaryPackSize").Width = 72
				Me.dgvList.Columns("PrimaryPackSize").Width = 72
				Me.dgvList.Columns("ReceivedQty").Width = 60
				Me.dgvList.Columns("Item_Status").Width = 110
				Me.dgvList.Columns("MfgDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
				Me.dgvList.Columns("ExpDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
				Me.dgvList.Columns("TertiaryPackSize").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("PrimaryPackSize").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("ReceivedQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x0400040E RID: 1038
		Private pnlBasicDefaultHeight As Integer

		' Token: 0x0400040F RID: 1039
		Private pnlBasicSetHeight As Integer

		' Token: 0x04000410 RID: 1040
		Private pnlAdvDefaultHeight As Integer

		' Token: 0x04000411 RID: 1041
		Private pnlAdvSetHeight As Integer
	End Class
End Namespace
