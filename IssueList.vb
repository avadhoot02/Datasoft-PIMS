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
	' Token: 0x02000064 RID: 100
	<DesignerGenerated()>
	Public Partial Class IssueList
		Inherits DockContent

		' Token: 0x17000977 RID: 2423
		' (get) Token: 0x06001874 RID: 6260 RVA: 0x000E181C File Offset: 0x000DFA1C
		' (set) Token: 0x06001875 RID: 6261 RVA: 0x000E1826 File Offset: 0x000DFA26
		Friend Overridable Property GbBasic As GroupBox

		' Token: 0x17000978 RID: 2424
		' (get) Token: 0x06001876 RID: 6262 RVA: 0x000E182F File Offset: 0x000DFA2F
		' (set) Token: 0x06001877 RID: 6263 RVA: 0x000E1839 File Offset: 0x000DFA39
		Friend Overridable Property Label2 As Label

		' Token: 0x17000979 RID: 2425
		' (get) Token: 0x06001878 RID: 6264 RVA: 0x000E1842 File Offset: 0x000DFA42
		' (set) Token: 0x06001879 RID: 6265 RVA: 0x000E184C File Offset: 0x000DFA4C
		Friend Overridable Property txtBatchNo As TextBox

		' Token: 0x1700097A RID: 2426
		' (get) Token: 0x0600187A RID: 6266 RVA: 0x000E1855 File Offset: 0x000DFA55
		' (set) Token: 0x0600187B RID: 6267 RVA: 0x000E185F File Offset: 0x000DFA5F
		Friend Overridable Property cmbPlant As ComboBox

		' Token: 0x1700097B RID: 2427
		' (get) Token: 0x0600187C RID: 6268 RVA: 0x000E1868 File Offset: 0x000DFA68
		' (set) Token: 0x0600187D RID: 6269 RVA: 0x000E1872 File Offset: 0x000DFA72
		Friend Overridable Property Label1 As Label

		' Token: 0x1700097C RID: 2428
		' (get) Token: 0x0600187E RID: 6270 RVA: 0x000E187B File Offset: 0x000DFA7B
		' (set) Token: 0x0600187F RID: 6271 RVA: 0x000E1885 File Offset: 0x000DFA85
		Friend Overridable Property txtNo As TextBox

		' Token: 0x1700097D RID: 2429
		' (get) Token: 0x06001880 RID: 6272 RVA: 0x000E188E File Offset: 0x000DFA8E
		' (set) Token: 0x06001881 RID: 6273 RVA: 0x000E1898 File Offset: 0x000DFA98
		Friend Overridable Property dtpFrom As DateTimePicker

		' Token: 0x1700097E RID: 2430
		' (get) Token: 0x06001882 RID: 6274 RVA: 0x000E18A1 File Offset: 0x000DFAA1
		' (set) Token: 0x06001883 RID: 6275 RVA: 0x000E18AB File Offset: 0x000DFAAB
		Friend Overridable Property dtpTo As DateTimePicker

		' Token: 0x1700097F RID: 2431
		' (get) Token: 0x06001884 RID: 6276 RVA: 0x000E18B4 File Offset: 0x000DFAB4
		' (set) Token: 0x06001885 RID: 6277 RVA: 0x000E18BE File Offset: 0x000DFABE
		Friend Overridable Property Label16 As Label

		' Token: 0x17000980 RID: 2432
		' (get) Token: 0x06001886 RID: 6278 RVA: 0x000E18C7 File Offset: 0x000DFAC7
		' (set) Token: 0x06001887 RID: 6279 RVA: 0x000E18D1 File Offset: 0x000DFAD1
		Friend Overridable Property lblDate As ComboBox

		' Token: 0x17000981 RID: 2433
		' (get) Token: 0x06001888 RID: 6280 RVA: 0x000E18DA File Offset: 0x000DFADA
		' (set) Token: 0x06001889 RID: 6281 RVA: 0x000E18E4 File Offset: 0x000DFAE4
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

		' Token: 0x17000982 RID: 2434
		' (get) Token: 0x0600188A RID: 6282 RVA: 0x000E1927 File Offset: 0x000DFB27
		' (set) Token: 0x0600188B RID: 6283 RVA: 0x000E1931 File Offset: 0x000DFB31
		Friend Overridable Property GbAdvanced As GroupBox

		' Token: 0x17000983 RID: 2435
		' (get) Token: 0x0600188C RID: 6284 RVA: 0x000E193A File Offset: 0x000DFB3A
		' (set) Token: 0x0600188D RID: 6285 RVA: 0x000E1944 File Offset: 0x000DFB44
		Friend Overridable Property cmbStatus As ComboBox

		' Token: 0x17000984 RID: 2436
		' (get) Token: 0x0600188E RID: 6286 RVA: 0x000E194D File Offset: 0x000DFB4D
		' (set) Token: 0x0600188F RID: 6287 RVA: 0x000E1957 File Offset: 0x000DFB57
		Friend Overridable Property Label11 As Label

		' Token: 0x17000985 RID: 2437
		' (get) Token: 0x06001890 RID: 6288 RVA: 0x000E1960 File Offset: 0x000DFB60
		' (set) Token: 0x06001891 RID: 6289 RVA: 0x000E196A File Offset: 0x000DFB6A
		Friend Overridable Property Label9 As Label

		' Token: 0x17000986 RID: 2438
		' (get) Token: 0x06001892 RID: 6290 RVA: 0x000E1973 File Offset: 0x000DFB73
		' (set) Token: 0x06001893 RID: 6291 RVA: 0x000E1980 File Offset: 0x000DFB80
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

		' Token: 0x17000987 RID: 2439
		' (get) Token: 0x06001894 RID: 6292 RVA: 0x000E19C3 File Offset: 0x000DFBC3
		' (set) Token: 0x06001895 RID: 6293 RVA: 0x000E19CD File Offset: 0x000DFBCD
		Friend Overridable Property Label3 As Label

		' Token: 0x17000988 RID: 2440
		' (get) Token: 0x06001896 RID: 6294 RVA: 0x000E19D6 File Offset: 0x000DFBD6
		' (set) Token: 0x06001897 RID: 6295 RVA: 0x000E19E0 File Offset: 0x000DFBE0
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

		' Token: 0x17000989 RID: 2441
		' (get) Token: 0x06001898 RID: 6296 RVA: 0x000E1A23 File Offset: 0x000DFC23
		' (set) Token: 0x06001899 RID: 6297 RVA: 0x000E1A2D File Offset: 0x000DFC2D
		Friend Overridable Property txtCreated As TextBox

		' Token: 0x1700098A RID: 2442
		' (get) Token: 0x0600189A RID: 6298 RVA: 0x000E1A36 File Offset: 0x000DFC36
		' (set) Token: 0x0600189B RID: 6299 RVA: 0x000E1A40 File Offset: 0x000DFC40
		Friend Overridable Property lblCreated As ComboBox

		' Token: 0x1700098B RID: 2443
		' (get) Token: 0x0600189C RID: 6300 RVA: 0x000E1A49 File Offset: 0x000DFC49
		' (set) Token: 0x0600189D RID: 6301 RVA: 0x000E1A54 File Offset: 0x000DFC54
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

		' Token: 0x1700098C RID: 2444
		' (get) Token: 0x0600189E RID: 6302 RVA: 0x000E1A97 File Offset: 0x000DFC97
		' (set) Token: 0x0600189F RID: 6303 RVA: 0x000E1AA1 File Offset: 0x000DFCA1
		Friend Overridable Property grpListButton As GroupBox

		' Token: 0x1700098D RID: 2445
		' (get) Token: 0x060018A0 RID: 6304 RVA: 0x000E1AAA File Offset: 0x000DFCAA
		' (set) Token: 0x060018A1 RID: 6305 RVA: 0x000E1AB4 File Offset: 0x000DFCB4
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x1700098E RID: 2446
		' (get) Token: 0x060018A2 RID: 6306 RVA: 0x000E1ABD File Offset: 0x000DFCBD
		' (set) Token: 0x060018A3 RID: 6307 RVA: 0x000E1AC8 File Offset: 0x000DFCC8
		Friend Overridable Property btnSearchRequest As Button
			<CompilerGenerated()>
			Get
				Return Me._btnSearchRequest
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnSearchRequest_Click
				Dim button As Button = Me._btnSearchRequest
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnSearchRequest = value
				button = Me._btnSearchRequest
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700098F RID: 2447
		' (get) Token: 0x060018A4 RID: 6308 RVA: 0x000E1B0B File Offset: 0x000DFD0B
		' (set) Token: 0x060018A5 RID: 6309 RVA: 0x000E1B18 File Offset: 0x000DFD18
		Friend Overridable Property btnSearchPicking As Button
			<CompilerGenerated()>
			Get
				Return Me._btnSearchPicking
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnSearchPicking_Click
				Dim button As Button = Me._btnSearchPicking
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnSearchPicking = value
				button = Me._btnSearchPicking
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000990 RID: 2448
		' (get) Token: 0x060018A6 RID: 6310 RVA: 0x000E1B5B File Offset: 0x000DFD5B
		' (set) Token: 0x060018A7 RID: 6311 RVA: 0x000E1B68 File Offset: 0x000DFD68
		Friend Overridable Property btnSearchIssue As Button
			<CompilerGenerated()>
			Get
				Return Me._btnSearchIssue
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnSearchIssue_Click
				Dim button As Button = Me._btnSearchIssue
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnSearchIssue = value
				button = Me._btnSearchIssue
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000991 RID: 2449
		' (get) Token: 0x060018A8 RID: 6312 RVA: 0x000E1BAB File Offset: 0x000DFDAB
		' (set) Token: 0x060018A9 RID: 6313 RVA: 0x000E1BB8 File Offset: 0x000DFDB8
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

		' Token: 0x17000992 RID: 2450
		' (get) Token: 0x060018AA RID: 6314 RVA: 0x000E1BFB File Offset: 0x000DFDFB
		' (set) Token: 0x060018AB RID: 6315 RVA: 0x000E1C08 File Offset: 0x000DFE08
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

		' Token: 0x17000993 RID: 2451
		' (get) Token: 0x060018AC RID: 6316 RVA: 0x000E1C4B File Offset: 0x000DFE4B
		' (set) Token: 0x060018AD RID: 6317 RVA: 0x000E1C55 File Offset: 0x000DFE55
		Friend Overridable Property lblRows As Label

		' Token: 0x17000994 RID: 2452
		' (get) Token: 0x060018AE RID: 6318 RVA: 0x000E1C5E File Offset: 0x000DFE5E
		' (set) Token: 0x060018AF RID: 6319 RVA: 0x000E1C68 File Offset: 0x000DFE68
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

		' Token: 0x17000995 RID: 2453
		' (get) Token: 0x060018B0 RID: 6320 RVA: 0x000E1CAB File Offset: 0x000DFEAB
		' (set) Token: 0x060018B1 RID: 6321 RVA: 0x000E1CB5 File Offset: 0x000DFEB5
		Friend Overridable Property cmbRequestStatus As ComboBox

		' Token: 0x17000996 RID: 2454
		' (get) Token: 0x060018B2 RID: 6322 RVA: 0x000E1CBE File Offset: 0x000DFEBE
		' (set) Token: 0x060018B3 RID: 6323 RVA: 0x000E1CC8 File Offset: 0x000DFEC8
		Friend Overridable Property Label4 As Label

		' Token: 0x17000997 RID: 2455
		' (get) Token: 0x060018B4 RID: 6324 RVA: 0x000E1CD1 File Offset: 0x000DFED1
		' (set) Token: 0x060018B5 RID: 6325 RVA: 0x000E1CDC File Offset: 0x000DFEDC
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

		' Token: 0x17000998 RID: 2456
		' (get) Token: 0x060018B6 RID: 6326 RVA: 0x000E1D1F File Offset: 0x000DFF1F
		' (set) Token: 0x060018B7 RID: 6327 RVA: 0x000E1D29 File Offset: 0x000DFF29
		Friend Overridable Property Label18 As Label

		' Token: 0x17000999 RID: 2457
		' (get) Token: 0x060018B8 RID: 6328 RVA: 0x000E1D32 File Offset: 0x000DFF32
		' (set) Token: 0x060018B9 RID: 6329 RVA: 0x000E1D3C File Offset: 0x000DFF3C
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

		' Token: 0x1700099A RID: 2458
		' (get) Token: 0x060018BA RID: 6330 RVA: 0x000E1D7F File Offset: 0x000DFF7F
		' (set) Token: 0x060018BB RID: 6331 RVA: 0x000E1D89 File Offset: 0x000DFF89
		Friend Overridable Property Label13 As Label

		' Token: 0x1700099B RID: 2459
		' (get) Token: 0x060018BC RID: 6332 RVA: 0x000E1D92 File Offset: 0x000DFF92
		' (set) Token: 0x060018BD RID: 6333 RVA: 0x000E1D9C File Offset: 0x000DFF9C
		Friend Overridable Property pnlItem As Panel

		' Token: 0x1700099C RID: 2460
		' (get) Token: 0x060018BE RID: 6334 RVA: 0x000E1DA5 File Offset: 0x000DFFA5
		' (set) Token: 0x060018BF RID: 6335 RVA: 0x000E1DAF File Offset: 0x000DFFAF
		Friend Overridable Property cmbMaterialType As ComboBox

		' Token: 0x1700099D RID: 2461
		' (get) Token: 0x060018C0 RID: 6336 RVA: 0x000E1DB8 File Offset: 0x000DFFB8
		' (set) Token: 0x060018C1 RID: 6337 RVA: 0x000E1DC2 File Offset: 0x000DFFC2
		Friend Overridable Property Label5 As Label

		' Token: 0x1700099E RID: 2462
		' (get) Token: 0x060018C2 RID: 6338 RVA: 0x000E1DCB File Offset: 0x000DFFCB
		' (set) Token: 0x060018C3 RID: 6339 RVA: 0x000E1DD5 File Offset: 0x000DFFD5
		Friend Overridable Property txtName As TextBox

		' Token: 0x1700099F RID: 2463
		' (get) Token: 0x060018C4 RID: 6340 RVA: 0x000E1DDE File Offset: 0x000DFFDE
		' (set) Token: 0x060018C5 RID: 6341 RVA: 0x000E1DE8 File Offset: 0x000DFFE8
		Friend Overridable Property Label14 As Label

		' Token: 0x170009A0 RID: 2464
		' (get) Token: 0x060018C6 RID: 6342 RVA: 0x000E1DF1 File Offset: 0x000DFFF1
		' (set) Token: 0x060018C7 RID: 6343 RVA: 0x000E1DFB File Offset: 0x000DFFFB
		Friend Overridable Property txtCode As TextBox

		' Token: 0x170009A1 RID: 2465
		' (get) Token: 0x060018C8 RID: 6344 RVA: 0x000E1E04 File Offset: 0x000E0004
		' (set) Token: 0x060018C9 RID: 6345 RVA: 0x000E1E0E File Offset: 0x000E000E
		Friend Overridable Property Label6 As Label

		' Token: 0x060018CA RID: 6346 RVA: 0x000E1E18 File Offset: 0x000E0018
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

		' Token: 0x060018CB RID: 6347 RVA: 0x000E1E94 File Offset: 0x000E0094
		Private Sub SetSearchPanel()
			Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
			Me.GbBasic.Height = Me.pnlBasicDefaultHeight
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
		End Sub

		' Token: 0x060018CC RID: 6348 RVA: 0x000E1EE8 File Offset: 0x000E00E8
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

		' Token: 0x060018CD RID: 6349 RVA: 0x000E1F58 File Offset: 0x000E0158
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

		' Token: 0x060018CE RID: 6350 RVA: 0x000E1FC8 File Offset: 0x000E01C8
		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x060018CF RID: 6351 RVA: 0x000E1FFD File Offset: 0x000E01FD
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Me.SetSearchPanel()
			Designing.SetTheme(Me)
			Me.FillCombo()
			Me.ClearList()
			Me.SetForm()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x060018D0 RID: 6352 RVA: 0x000E203C File Offset: 0x000E023C
		Private Sub FillCombo()
			Dim text As String = "SELECT UserID, LoginID FROM [User] WHERE IsActive = 1 ORDER BY LoginID"
			Dim data As DataTable = MainModule.GetData(text)
			Me.cmbRequestedBy.ValueMember = "UserID"
			Me.cmbRequestedBy.DisplayMember = "LoginID"
			Me.cmbRequestedBy.DataSource = data
			Me.cmbRequestedBy.SelectedValue = -1
			Me.FillProduct()
		End Sub

		' Token: 0x060018D1 RID: 6353 RVA: 0x000E20A0 File Offset: 0x000E02A0
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

		' Token: 0x060018D2 RID: 6354 RVA: 0x000E215C File Offset: 0x000E035C
		Private Sub SetForm()
			Dim text As String = Me.sFormType
			If Operators.CompareString(text, "Picking", False) <> 0 Then
				If Operators.CompareString(text, "QA Approval", False) <> 0 Then
					If Operators.CompareString(text, "Issue", False) = 0 Then
						MyBase.TabText = "Material Issue List"
						Me.cmbStatus.Items.Remove("Picked")
						Me.cmbStatus.Items.Remove("QA Rejected")
						Me.cmbStatus.Items.Remove("Cancelled")
						Me.btnSearchRequest.Visible = False
						Me.SearchPicking("")
					End If
				Else
					MyBase.TabText = "QA Verification List"
					Me.lblDate.Items.Remove("Issue Date")
					Me.cmbStatus.Items.Remove("Cancelled")
					Me.cmbStatus.Text = "Picked"
					Me.btnSearchRequest.Visible = False
					Me.btnSearchIssue.Visible = False
					Me.SearchPicking("")
				End If
			Else
				Me.lblDate.Items.Remove("Issue Date")
				Me.btnSearchIssue.Visible = False
				Dim flag As Boolean = Operators.CompareString(MyBase.TabText, "QA On-Hold List", False) = 0
				If flag Then
					Me.cmbStatus.Text = "QA On-Hold"
					Me.SearchPicking("")
				Else
					MyBase.TabText = "Picking List"
					Me.SearchRequest("")
				End If
			End If
		End Sub

		' Token: 0x060018D3 RID: 6355 RVA: 0x000E2300 File Offset: 0x000E0500
		Private Sub ClearList()
			Me.lblDate.SelectedIndex = 0
			Me.lblCreated.SelectedIndex = 0
			Me.txtNo.Text = ""
			Me.txtBatchNo.Text = ""
			Me.txtCreated.Text = ""
			Me.cmbRequestedBy.SelectedIndex = -1
			Me.cmbProduct.SelectedIndex = -1
			Me.cmbRequestStatus.SelectedIndex = 0
			Me.cmbStatus.SelectedIndex = 0
			Me.dtpFrom.Value = DateAndTime.Now
			Me.dtpTo.Value = DateAndTime.Now
			Me.dtpFrom.Checked = False
			Me.dtpTo.Checked = False
			Me.cmbSummary.Text = "Transaction-wise"
			Me.cmbMaterialType.Text = ""
			Me.txtCode.Text = ""
			Me.txtName.Text = ""
			Me.lblRows.Text = "0 - Rows"
			Me.dgvList.DataSource = Nothing
		End Sub

		' Token: 0x060018D4 RID: 6356 RVA: 0x000E242D File Offset: 0x000E062D
		Private Sub btnClearList_Click(sender As Object, e As EventArgs)
			Me.ClearList()
		End Sub

		' Token: 0x060018D5 RID: 6357 RVA: 0x000E2437 File Offset: 0x000E0637
		Private Sub btnExport_Click(sender As Object, e As EventArgs)
			MainModule.ExportToExcel(Me.dgvList, Me.Text)
		End Sub

		' Token: 0x060018D6 RID: 6358 RVA: 0x000E244C File Offset: 0x000E064C
		Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs)
			Me.FillProduct()
		End Sub

		' Token: 0x060018D7 RID: 6359 RVA: 0x000E2458 File Offset: 0x000E0658
		Private Sub cmbRequestedBy_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbRequestedBy.SelectedIndex = -1
			If flag Then
				Me.cmbRequestedBy.Text = ""
			End If
		End Sub

		' Token: 0x060018D8 RID: 6360 RVA: 0x000E248C File Offset: 0x000E068C
		Private Sub cmbProduct_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbProduct.SelectedIndex = -1
			If flag Then
				Me.cmbProduct.Text = ""
			End If
		End Sub

		' Token: 0x060018D9 RID: 6361 RVA: 0x000E24BF File Offset: 0x000E06BF
		Private Sub cmbSummary_SelectedValueChanged(sender As Object, e As EventArgs)
			Me.SetSummary()
		End Sub

		' Token: 0x060018DA RID: 6362 RVA: 0x000E24CC File Offset: 0x000E06CC
		Private Sub SetSummary()
			Dim text As String = Me.cmbSummary.Text
			If Operators.CompareString(text, "Transaction-wise", False) <> 0 Then
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

		' Token: 0x060018DB RID: 6363 RVA: 0x000E25D0 File Offset: 0x000E07D0
		Private Sub dgvList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = (e.RowIndex > -1) And (e.ColumnIndex > -1)
			If flag Then
				Dim dataTable As DataTable = CType(Me.dgvList.DataSource, DataTable)
				Dim dataRow As DataRow = dataTable.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Id = '", Me.dgvList.Rows(e.RowIndex).Cells("ID").Value), "'")))(0)
				Dim text As String = Me.sFormType
				If Operators.CompareString(text, "Picking", False) <> 0 Then
					If Operators.CompareString(text, "QA Approval", False) <> 0 Then
						If Operators.CompareString(text, "Issue", False) = 0 Then
							Dim issue As Issue = New Issue(Me.sFormType, dataRow)
							issue.Show(MyBase.DockPanel)
							Me.ClearList()
						End If
					Else
						Dim picking As Picking = New Picking(Me.sFormType, dataRow)
						Dim flag2 As Boolean = picking.ShowDialog() = DialogResult.OK
						If flag2 Then
							Me.SearchPicking(picking.sID)
						Else
							Me.SearchPicking("")
						End If
					End If
				Else
					Dim picking2 As Picking = New Picking(Me.sFormType, dataRow)
					Dim flag3 As Boolean = picking2.ShowDialog() = DialogResult.OK
					If flag3 Then
						Me.SearchPicking(picking2.sID)
					Else
						Me.SearchPicking("")
					End If
				End If
			End If
		End Sub

		' Token: 0x060018DC RID: 6364 RVA: 0x000E2738 File Offset: 0x000E0938
		Private Sub btnSearchRequest_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SearchRequest("")
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x060018DD RID: 6365 RVA: 0x000E27AC File Offset: 0x000E09AC
		Private Sub SearchRequest(sID As String)
			Dim text As String = ""
			Dim text2 As String = " SELECT R.RequestID AS ID, R.Status, RequestNo, RequestDt, R.Department, RequestedBy, U.UserID,U.LoginID, U.UserName [Requested By],  " & vbCrLf
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
			text2 += " WHERE 1=1 AND R.Status IN ('Request Generated', 'In Picking')" & vbCrLf
			Dim text3 As String = Me.sFormType
			If Operators.CompareString(text3, "", False) <> 0 Then
			End If
			Dim flag3 As Boolean = Operators.CompareString(sID, "", False) <> 0
			If flag3 Then
				text2 = text2 + " AND R.RequestID = '" + sID + "'" & vbCrLf
				text = text + "RequestID = '" + sID + "'" & vbCrLf
			End If
			Dim flag4 As Boolean = Operators.CompareString(Strings.Trim(Me.txtNo.Text), "", False) <> 0
			If flag4 Then
				text2 = text2 + " And (RequestNo Like '%" + Strings.Trim(Me.txtNo.Text) + "%') " & vbCrLf
				text = text + "RequestNo LIKE " + Strings.Trim(Me.txtNo.Text) + vbCrLf
			End If
			Dim flag5 As Boolean = Operators.CompareString(Strings.Trim(Me.txtBatchNo.Text), "", False) <> 0
			If flag5 Then
				text2 = text2 + " AND (BatchNo LIKE '%" + Strings.Trim(Me.txtBatchNo.Text) + "%')" & vbCrLf
				text = text + "BatchNo LIKE " + Strings.Trim(Me.txtBatchNo.Text) + vbCrLf
			End If
			Dim flag6 As Boolean = Me.cmbRequestedBy.SelectedIndex > -1
			If flag6 Then
				text2 = text2 + " AND (R.RequestedBy = '" + Strings.Trim(Me.cmbRequestedBy.SelectedValue.ToString()) + "')" & vbCrLf
				text = text + "Requested By = " + Strings.Trim(Me.cmbRequestedBy.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag7 As Boolean = Me.cmbProduct.SelectedIndex > -1
			If flag7 Then
				text2 = text2 + " AND (R.ProductID = '" + Strings.Trim(Me.cmbProduct.SelectedValue.ToString()) + "')" & vbCrLf
				text = text + "ProductID = " + Strings.Trim(Me.cmbProduct.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag8 As Boolean = Me.cmbRequestStatus.SelectedIndex > 0
			If flag8 Then
				text2 = text2 + " AND (R.Status = '" + Me.cmbRequestStatus.Text + "')" & vbCrLf
				text = text + ("Status = " + Me.cmbRequestStatus.Text) + vbCrLf
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
									text6 = "R.ExpDt"
								End If
							Else
								text6 = "R.MfgDt"
							End If
						Else
							text6 = "R.RequestDt"
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
			Me.dgvList.Columns("Requested By").Width = 225
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

		' Token: 0x060018DE RID: 6366 RVA: 0x000E38E0 File Offset: 0x000E1AE0
		Private Sub SearchRequest01(sID As String)
			Dim text As String = ""
			Dim text2 As String = " SELECT RequestID AS ID, R.Status, RequestNo, RequestDt, RequestedBy, U.UserID,U.LoginID, U.UserName [Requested By],  " & vbCrLf
			text2 += " R.ProductID, P.CatalogNo, P.ProductType, P.ProductName, BatchNo, MfgDt, ExpDt, " & vbCrLf
			text2 += " Created.EmailID AS CreatedByEmailID, Modified.EmailID AS ModifiedByEmailID, " & vbCrLf
			text2 += " R.CreationDt, Created.UserName AS CreatedBy, R.ModificationDt, Modified.UserName AS ModifiedBy " & vbCrLf
			text2 += " FROM Request R " & vbCrLf
			text2 += " INNER JOIN [User] U ON R.RequestedBy = U.UserID " & vbCrLf
			text2 += " INNER JOIN Product P ON R.ProductID = P.ProductID " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Created ON R.CreatedBy = Created.UserID " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Modified ON R.ModifiedBy = Modified.UserID " & vbCrLf
			text2 += " WHERE 1=1 AND R.Status IN ('Request Generated', 'In Picking')" & vbCrLf
			Dim text3 As String = Me.sFormType
			If Operators.CompareString(text3, "", False) <> 0 Then
			End If
			Dim flag As Boolean = Operators.CompareString(sID, "", False) <> 0
			If flag Then
				text2 = text2 + " AND RequestID = '" + sID + "'" & vbCrLf
				text = text + "RequestID = '" + sID + "'" & vbCrLf
			End If
			Dim flag2 As Boolean = Operators.CompareString(Strings.Trim(Me.txtNo.Text), "", False) <> 0
			If flag2 Then
				text2 = text2 + " And (RequestNo Like '%" + Strings.Trim(Me.txtNo.Text) + "%') " & vbCrLf
				text = text + "RequestNo LIKE " + Strings.Trim(Me.txtNo.Text) + vbCrLf
			End If
			Dim flag3 As Boolean = Operators.CompareString(Strings.Trim(Me.txtBatchNo.Text), "", False) <> 0
			If flag3 Then
				text2 = text2 + " AND (BatchNo LIKE '%" + Strings.Trim(Me.txtBatchNo.Text) + "%')" & vbCrLf
				text = text + "BatchNo LIKE " + Strings.Trim(Me.txtBatchNo.Text) + vbCrLf
			End If
			Dim flag4 As Boolean = Me.cmbRequestedBy.SelectedIndex > -1
			If flag4 Then
				text2 = text2 + " AND (U.UserID = '" + Strings.Trim(Me.cmbRequestedBy.SelectedValue.ToString()) + "')" & vbCrLf
				text = text + "UserID = " + Strings.Trim(Me.cmbRequestedBy.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag5 As Boolean = Me.cmbProduct.SelectedIndex > -1
			If flag5 Then
				text2 = text2 + " AND (R.ProductID = '" + Strings.Trim(Me.cmbProduct.SelectedValue.ToString()) + "')" & vbCrLf
				text = text + "ProductID = " + Strings.Trim(Me.cmbProduct.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag6 As Boolean = Me.cmbRequestStatus.SelectedIndex > 0
			If flag6 Then
				text2 = text2 + " AND (R.Status = '" + Me.cmbRequestStatus.Text + "')" & vbCrLf
				text = text + ("Status = " + Me.cmbRequestStatus.Text) + vbCrLf
			End If
			Dim flag7 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCreated.Text), "", False) <> 0
			If flag7 Then
				Dim flag8 As Boolean = Me.lblCreated.SelectedIndex >= 0
				If flag8 Then
					Dim flag9 As Boolean = Me.lblCreated.SelectedIndex = 0
					Dim text4 As String
					If flag9 Then
						text4 = "Created"
					Else
						text4 = "Modified"
					End If
					text2 = String.Concat(New String() { text2, " AND ", text4, ".UserName LIKE '%", Strings.Trim(Me.txtCreated.Text), "%'" })
					text = text + (text4 + "By LIKE " + Strings.Trim(Me.txtCreated.Text)) + vbCrLf
				End If
			End If
			Dim flag10 As Boolean = Me.lblDate.SelectedIndex >= 0
			If flag10 Then
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
						text6 = "ModificationDt"
					End If
				Else
					text6 = "CreationDt"
				End If
				Dim flag11 As Boolean = Operators.CompareString(text6, "", False) <> 0
				If flag11 Then
					Dim flag12 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
					If flag12 Then
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
			Me.dgvList.Columns("LoginID").HeaderText = "Login ID"
			Me.dgvList.Columns("CatalogNo").HeaderText = "Catalog No."
			Me.dgvList.Columns("ProductType").HeaderText = "Product Type"
			Me.dgvList.Columns("ProductName").HeaderText = "Product Name"
			Me.dgvList.Columns("BatchNo").HeaderText = "Batch No."
			Me.dgvList.Columns("MfgDt").HeaderText = "Mfg. Date"
			Me.dgvList.Columns("ExpDt").HeaderText = "Expiry Date"
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
			Me.dgvList.Columns("Requested By").Width = 225
			Me.dgvList.Columns("CatalogNo").Width = 170
			Me.dgvList.Columns("ProductType").Width = 150
			Me.dgvList.Columns("ProductName").Width = 350
			Me.dgvList.Columns("BatchNo").Width = 130
			Me.dgvList.Columns("MfgDt").Width = 120
			Me.dgvList.Columns("ExpDt").Width = 120
			Me.dgvList.Columns("Status").Width = 132
			Me.dgvList.Columns("CreationDt").Width = 170
			Me.dgvList.Columns("CreatedBy").Width = 140
			Me.dgvList.Columns("ModificationDt").Width = 170
			Me.dgvList.Columns("ModifiedBy").Width = 140
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x060018DF RID: 6367 RVA: 0x000E4574 File Offset: 0x000E2774
		Private Sub btnSearchPicking_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SearchPicking("")
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x060018E0 RID: 6368 RVA: 0x000E45E8 File Offset: 0x000E27E8
		Private Sub SearchPicking(sID As String)
			Dim text As String = ""
			Dim flag As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Transaction-wise", False) = 0
			Dim text2 As String
			If flag Then
				text2 = " SELECT IssueID AS ID, I.RequestID, I.Status, IssueNo AS PickingNo, PickingDt, R.RequestNo, R.RequestDt, " & vbCrLf
				text2 += " R.ProductID, P.CatalogNo, P.ProductType, P.ProductName, BatchNo, MfgDt, ExpDt, R.BOMVersion, R.BatchQty, " & vbCrLf
				text2 += " R.RequestedBy, Req.UserName AS [Requested By], PickingBy, Picking.UserName AS [Picking By],  " & vbCrLf
				text2 += " ActionBy, Action.UserName AS [Action By], ActionDt, IssuedBy, Issued.UserName AS [Issued By], IssuedDt,  " & vbCrLf
				text2 += " I.Remarks, I.ActionRemarks, " & vbCrLf
				text2 += " Created.EmailID AS CreatedByEmailID, Modified.EmailID AS ModifiedByEmailID, " & vbCrLf
				text2 += " I.CreationDt, Created.UserName AS CreatedBy, I.ModificationDt, Modified.UserName AS ModifiedBy " & vbCrLf
				text2 += " FROM Issue I " & vbCrLf
				text2 += " INNER JOIN Request R ON I.RequestID = R.RequestID " & vbCrLf
				text2 += " INNER JOIN Product P ON R.ProductID = P.ProductID " & vbCrLf
				text2 += " INNER JOIN [User] Req ON R.RequestedBy = Req.UserID " & vbCrLf
				text2 += " INNER JOIN [User] Picking ON I.PickingBy = Picking.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] Action ON I.ActionBy = Action.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] Issued ON I.IssuedBy = Issued.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Created ON I.CreatedBy = Created.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Modified ON I.ModifiedBy = Modified.UserID " & vbCrLf
			Else
				text2 = " SELECT I.IssueID AS ID, I.RequestID, I.Status, IssueNo AS PickingNo, PickingDt, R.RequestNo, R.RequestDt, " & vbCrLf
				text2 += " R.ProductID, P.CatalogNo, P.ProductType, P.ProductName, R.BatchNo, MfgDt, ExpDt, R.BOMVersion, R.BatchQty, " & vbCrLf
				text2 += " M.ProductID MaterialID, M.ProductType MaterialType, M.ProductCode MaterialCode, " & vbCrLf
				text2 += " M.CatalogNo MaterialCatalogNo, M.ProductName MaterialName, " & vbCrLf
				text2 += " M.PrimaryUOM, M.PrimaryPackSize, RD.RequiredQty, ID.PickedQty," & vbCrLf
				text2 += " R.RequestedBy, Req.UserName AS [Requested By], PickingBy, Picking.UserName AS [Picking By],  " & vbCrLf
				text2 += " ActionBy, Action.UserName AS [Action By], ActionDt, IssuedBy, Issued.UserName AS [Issued By], IssuedDt, " & vbCrLf
				text2 += " I.Remarks, I.ActionRemarks, " & vbCrLf
				text2 += " Created.EmailID AS CreatedByEmailID, Modified.EmailID AS ModifiedByEmailID, " & vbCrLf
				text2 += " I.CreationDt, Created.UserName AS CreatedBy, I.ModificationDt, Modified.UserName AS ModifiedBy " & vbCrLf
				text2 += " FROM Issue I " & vbCrLf
				text2 += " INNER JOIN Request R ON I.RequestID = R.RequestID " & vbCrLf
				text2 += " INNER JOIN Product P ON R.ProductID = P.ProductID " & vbCrLf
				text2 += " INNER JOIN [User] Req ON R.RequestedBy = Req.UserID " & vbCrLf
				text2 += " INNER JOIN [User] Picking ON I.PickingBy = Picking.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] Action ON I.ActionBy = Action.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] Issued ON I.IssuedBy = Issued.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Created ON I.CreatedBy = Created.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Modified ON I.ModifiedBy = Modified.UserID " & vbCrLf
				text2 += " INNER JOIN RequestDtls AS RD ON R.RequestID = RD.RequestID " & vbCrLf
				text2 += " INNER JOIN Product AS M ON RD.ProductID = M.ProductID" & vbCrLf
				text2 += " INNER JOIN (SELECT IssueID, ProductID, COUNT(UID) AS PickedQty FROM IssueDtls GROUP BY IssueID, ProductID) ID " & vbCrLf
				text2 += " ON I.IssueID = ID.IssueID AND M.ProductID = ID.ProductID" & vbCrLf
			End If
			text2 += " WHERE 1=1" & vbCrLf
			Dim text3 As String = Me.sFormType
			If Operators.CompareString(text3, "Picking", False) <> 0 Then
				If Operators.CompareString(text3, "QA Approval", False) <> 0 Then
					If Operators.CompareString(text3, "Issue", False) = 0 Then
						text2 += " AND I.Status IN ('QA Approved')"
					End If
				Else
					text2 += " AND I.Status NOT IN ('Cancelled')"
				End If
			End If
			Dim flag2 As Boolean = Operators.CompareString(sID, "", False) <> 0
			If flag2 Then
				text2 = text2 + " AND IssueID = '" + sID + "'" & vbCrLf
				text = text + ("IssueID = " + sID) + vbCrLf
			End If
			Dim flag3 As Boolean = Operators.CompareString(Strings.Trim(Me.txtNo.Text), "", False) <> 0
			If flag3 Then
				text2 = String.Concat(New String() { text2, " And (RequestNo Like '%", Strings.Trim(Me.txtNo.Text), "%' OR IssueNo Like '%", Strings.Trim(Me.txtNo.Text), "%')" & vbCrLf })
				text = text + "TransactionNo LIKE " + Strings.Trim(Me.txtNo.Text) + vbCrLf
			End If
			Dim flag4 As Boolean = Operators.CompareString(Strings.Trim(Me.txtBatchNo.Text), "", False) <> 0
			If flag4 Then
				text2 = text2 + " AND (BatchNo LIKE '%" + Strings.Trim(Me.txtBatchNo.Text) + "%')" & vbCrLf
				text = text + "BatchNo LIKE " + Strings.Trim(Me.txtBatchNo.Text) + vbCrLf
			End If
			Dim flag5 As Boolean = Me.cmbRequestedBy.SelectedIndex > -1
			If flag5 Then
				text2 = text2 + " AND (R.RequestedBy = '" + Strings.Trim(Me.cmbRequestedBy.SelectedValue.ToString()) + "')" & vbCrLf
				text = text + "Requested By = " + Strings.Trim(Me.cmbRequestedBy.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag6 As Boolean = Me.cmbProduct.SelectedIndex > -1
			If flag6 Then
				text2 = text2 + " AND (R.ProductID = '" + Strings.Trim(Me.cmbProduct.SelectedValue.ToString()) + "')" & vbCrLf
				text = text + "ProductID = " + Strings.Trim(Me.cmbProduct.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag7 As Boolean = Me.cmbStatus.SelectedIndex > 0
			If flag7 Then
				text2 = text2 + " AND (I.Status = '" + Me.cmbStatus.Text + "')" & vbCrLf
				text = text + ("Status = " + Me.cmbStatus.Text) + vbCrLf
			End If
			Dim flag8 As Boolean = Operators.CompareString(Me.cmbType.Text, "", False) <> 0
			If flag8 Then
				text2 = text2 + " AND P.ProductType = '" + Me.cmbType.Text + "'" & vbCrLf
			End If
			Dim flag9 As Boolean = (Operators.CompareString(Me.cmbSummary.Text, "Item-wise", False) = 0) And (Operators.CompareString(Me.cmbMaterialType.Text, "", False) <> 0)
			If flag9 Then
				text2 = text2 + " AND M.ProductType = '" + Me.cmbMaterialType.Text + "'" & vbCrLf
			End If
			Dim flag10 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCreated.Text), "", False) <> 0
			If flag10 Then
				Dim flag11 As Boolean = Me.lblCreated.SelectedIndex >= 0
				If flag11 Then
					Dim text4 As String = Me.lblCreated.Text
					Dim text5 As String
					If Operators.CompareString(text4, "Created By", False) <> 0 Then
						If Operators.CompareString(text4, "Last Modified By", False) <> 0 Then
							If Operators.CompareString(text4, "Picking By", False) <> 0 Then
								If Operators.CompareString(text4, "Action By", False) <> 0 Then
									If Operators.CompareString(text4, "Issued By", False) <> 0 Then
										text5 = ""
									Else
										text5 = "Issued"
									End If
								Else
									text5 = "Action"
								End If
							Else
								text5 = "Picking"
							End If
						Else
							text5 = "Modified"
						End If
					Else
						text5 = "Created"
					End If
					Dim flag12 As Boolean = Operators.CompareString(text5, "", False) <> 0
					If flag12 Then
						text2 = String.Concat(New String() { text2, " AND ", text5, ".UserName LIKE '%", Strings.Trim(Me.txtCreated.Text), "%'" })
						text = text + (text5 + "By LIKE " + Strings.Trim(Me.txtCreated.Text)) + vbCrLf
					End If
				End If
			End If
			Dim flag13 As Boolean = Me.lblDate.SelectedIndex >= 0
			If flag13 Then
				Dim text6 As String = Me.lblDate.Text
				Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(text6)
				Dim text7 As String
				If num <= 2191931204UI Then
					If num <= 909288388UI Then
						If num <> 9905901UI Then
							If num = 909288388UI Then
								If Operators.CompareString(text6, "Picking Date", False) = 0 Then
									text7 = "PickingDt"
									GoTo IL_0844
								End If
							End If
						ElseIf Operators.CompareString(text6, "Mfg. Date", False) = 0 Then
							text7 = "R.MfgDt"
							GoTo IL_0844
						End If
					ElseIf num <> 1193474114UI Then
						If num = 2191931204UI Then
							If Operators.CompareString(text6, "Creation", False) = 0 Then
								text7 = "I.CreationDt"
								GoTo IL_0844
							End If
						End If
					ElseIf Operators.CompareString(text6, "Request Date", False) = 0 Then
						text7 = "R.RequestDt"
						GoTo IL_0844
					End If
				ElseIf num <= 3251571134UI Then
					If num <> 2676830049UI Then
						If num = 3251571134UI Then
							If Operators.CompareString(text6, "Expiry Date", False) = 0 Then
								text7 = "R.ExpDt"
								GoTo IL_0844
							End If
						End If
					ElseIf Operators.CompareString(text6, "Action Date", False) = 0 Then
						text7 = "ActionDt"
						GoTo IL_0844
					End If
				ElseIf num <> 3338871895UI Then
					If num = 4202926516UI Then
						If Operators.CompareString(text6, "Issue Date", False) = 0 Then
							text7 = "IssuedDt"
							GoTo IL_0844
						End If
					End If
				ElseIf Operators.CompareString(text6, "Last Modification", False) = 0 Then
					text7 = "I.ModificationDt"
					GoTo IL_0844
				End If
				text7 = ""
				IL_0844:
				Dim flag14 As Boolean = Operators.CompareString(text7, "", False) <> 0
				If flag14 Then
					Dim flag15 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
					If flag15 Then
						text2 = String.Concat(New String() { text2, " AND ", text7, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
						text = text + String.Concat(New String() { text7, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
					Else
						Dim checked As Boolean = Me.dtpFrom.Checked
						If checked Then
							text2 = String.Concat(New String() { text2, " AND ", text7, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59"), "'" })
							text = text + String.Concat(New String() { text7, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
						End If
						Dim checked2 As Boolean = Me.dtpTo.Checked
						If checked2 Then
							text2 = String.Concat(New String() { text2, " AND ", text7, " BETWEEN '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
							text = text + String.Concat(New String() { text7, " BETWEEN  ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
						End If
					End If
				End If
			End If
			Dim flag16 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Item-wise", False) = 0
			If flag16 Then
				Dim flag17 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCode.Text), "", False) <> 0
				If flag17 Then
					text2 = text2 + " AND (M.ProductCode Like '%" + Strings.Trim(Me.txtCode.Text) + "%') "
					text = text + "MaterialCode LIKE " + Strings.Trim(Me.txtCode.Text) + vbCrLf
				End If
				Dim flag18 As Boolean = Operators.CompareString(Strings.Trim(Me.txtName.Text), "", False) <> 0
				If flag18 Then
					text2 = text2 + " AND (M.ProductName Like '%" + Strings.Trim(Me.txtName.Text) + "%') "
					text = text + "MaterialName LIKE " + Strings.Trim(Me.txtName.Text) + vbCrLf
				End If
			End If
			text2 += " ORDER BY RequestDt, PickingDt"
			Dim data As DataTable = MainModule.GetData(text2)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = Nothing
			Me.dgvList.DataSource = data
			Me.dgvList.Columns("ID").Visible = False
			Me.dgvList.Columns("RequestID").Visible = False
			Me.dgvList.Columns("RequestedBy").Visible = False
			Me.dgvList.Columns("ProductID").Visible = False
			Me.dgvList.Columns("PickingBy").Visible = False
			Me.dgvList.Columns("ActionBy").Visible = False
			Me.dgvList.Columns("IssuedBy").Visible = False
			Me.dgvList.Columns("CatalogNo").Visible = False
			Me.dgvList.Columns("CreatedByEmailID").Visible = False
			Me.dgvList.Columns("ModifiedByEmailID").Visible = False
			Me.dgvList.Columns("Remarks").Visible = False
			Me.dgvList.Columns("ActionRemarks").Visible = False
			Me.dgvList.Columns("RequestNo").HeaderText = "Request No."
			Me.dgvList.Columns("RequestDt").HeaderText = "Request Date"
			Me.dgvList.Columns("PickingNo").HeaderText = "Picking No."
			Me.dgvList.Columns("PickingDt").HeaderText = "Picking Date"
			Me.dgvList.Columns("ActionDt").HeaderText = "Action Date"
			Me.dgvList.Columns("IssuedDt").HeaderText = "Issued Date"
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
			Me.dgvList.Columns("PickingDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("ActionDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("IssuedDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("MfgDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("ExpDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("CreationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			Me.dgvList.Columns("ModificationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			Me.dgvList.Columns("RequestNo").Width = 130
			Me.dgvList.Columns("RequestDt").Width = 120
			Me.dgvList.Columns("PickingDt").Width = 120
			Me.dgvList.Columns("ActionDt").Width = 120
			Me.dgvList.Columns("IssuedDt").Width = 120
			Me.dgvList.Columns("Requested By").Width = 225
			Me.dgvList.Columns("Picking By").Width = 225
			Me.dgvList.Columns("Action By").Width = 225
			Me.dgvList.Columns("Issued By").Width = 225
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
			Dim flag19 As Boolean = data.Columns.Contains("MaterialCode")
			If flag19 Then
				Me.dgvList.Columns("MaterialID").Visible = False
				Me.dgvList.Columns("MaterialCode").HeaderText = "Material Code"
				Me.dgvList.Columns("MaterialCatalogNo").HeaderText = "Material Catalog No."
				Me.dgvList.Columns("MaterialName").HeaderText = "Material Name"
				Me.dgvList.Columns("MaterialType").HeaderText = "Material Type"
				Me.dgvList.Columns("PrimaryUOM").HeaderText = "Primary UOM"
				Me.dgvList.Columns("PrimaryPackSize").HeaderText = "Primary PackSize"
				Me.dgvList.Columns("RequiredQty").HeaderText = "Required Qty."
				Me.dgvList.Columns("PickedQty").HeaderText = "Picked Qty."
				Me.dgvList.Columns("MaterialCode").Width = 180
				Me.dgvList.Columns("MaterialCatalogNo").Width = 180
				Me.dgvList.Columns("MaterialName").Width = 300
				Me.dgvList.Columns("MaterialType").Width = 110
				Me.dgvList.Columns("PrimaryUOM").Width = 90
				Me.dgvList.Columns("PrimaryPackSize").Width = 72
				Me.dgvList.Columns("RequiredQty").Width = 60
				Me.dgvList.Columns("PickedQty").Width = 60
				Me.dgvList.Columns("RequiredQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("PickedQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x060018E1 RID: 6369 RVA: 0x000E5C5C File Offset: 0x000E3E5C
		Private Sub btnSearchIssue_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SearchIssue("")
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x060018E2 RID: 6370 RVA: 0x000E5CD0 File Offset: 0x000E3ED0
		Private Sub SearchIssue(sID As String)
			Dim text As String = ""
			Dim flag As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Transaction-wise", False) = 0
			Dim text2 As String
			If flag Then
				text2 = " SELECT IssueID AS ID, I.RequestID, I.Status, IssueNo AS IssueNo, IssuedDt, R.RequestNo, R.RequestDt, PickingDt,  " & vbCrLf
				text2 += " R.ProductID, P.CatalogNo, P.ProductType, P.ProductName, BatchNo, MfgDt, ExpDt, R.BOMVersion, R.BatchQty, " & vbCrLf
				text2 += " R.RequestedBy, Req.UserName AS [Requested By], PickingBy, Picking.UserName AS [Picking By],  " & vbCrLf
				text2 += " ActionBy, Action.UserName AS [Action By], ActionDt, IssuedBy, Issued.UserName AS [Issued By],  " & vbCrLf
				text2 += " Created.EmailID AS CreatedByEmailID, Modified.EmailID AS ModifiedByEmailID, " & vbCrLf
				text2 += " I.CreationDt, Created.UserName AS CreatedBy, I.ModificationDt, Modified.UserName AS ModifiedBy " & vbCrLf
				text2 += " FROM Issue I " & vbCrLf
				text2 += " INNER JOIN Request R ON I.RequestID = R.RequestID " & vbCrLf
				text2 += " INNER JOIN Product P ON R.ProductID = P.ProductID " & vbCrLf
				text2 += " INNER JOIN [User] Req ON R.RequestedBy = Req.UserID " & vbCrLf
				text2 += " INNER JOIN [User] Picking ON I.PickingBy = Picking.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] Action ON I.ActionBy = Action.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] Issued ON I.IssuedBy = Issued.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Created ON I.CreatedBy = Created.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Modified ON I.ModifiedBy = Modified.UserID " & vbCrLf
			Else
				text2 = " SELECT I.IssueID AS ID, I.RequestID, I.Status, IssueNo AS IssueNo, IssuedDt, R.RequestNo, R.RequestDt, PickingDt,  " & vbCrLf
				text2 += " R.ProductID, P.CatalogNo, P.ProductType, P.ProductName, R.BatchNo, MfgDt, ExpDt, R.BOMVersion, R.BatchQty, " & vbCrLf
				text2 += " M.ProductID MaterialID, M.ProductType MaterialType, M.ProductCode MaterialCode, " & vbCrLf
				text2 += " M.CatalogNo MaterialCatalogNo, M.ProductName MaterialName, " & vbCrLf
				text2 += " M.PrimaryUOM, M.PrimaryPackSize, RD.RequiredQty, ID.IssuedQty," & vbCrLf
				text2 += " R.RequestedBy, Req.UserName AS [Requested By], PickingBy, Picking.UserName AS [Picking By],  " & vbCrLf
				text2 += " ActionBy, Action.UserName AS [Action By], ActionDt, IssuedBy, Issued.UserName AS [Issued By],  " & vbCrLf
				text2 += " Created.EmailID AS CreatedByEmailID, Modified.EmailID AS ModifiedByEmailID, " & vbCrLf
				text2 += " I.CreationDt, Created.UserName AS CreatedBy, I.ModificationDt, Modified.UserName AS ModifiedBy " & vbCrLf
				text2 += " FROM Issue I " & vbCrLf
				text2 += " INNER JOIN Request R ON I.RequestID = R.RequestID " & vbCrLf
				text2 += " INNER JOIN Product P ON R.ProductID = P.ProductID " & vbCrLf
				text2 += " INNER JOIN [User] Req ON R.RequestedBy = Req.UserID " & vbCrLf
				text2 += " INNER JOIN [User] Picking ON I.PickingBy = Picking.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] Action ON I.ActionBy = Action.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] Issued ON I.IssuedBy = Issued.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Created ON I.CreatedBy = Created.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Modified ON I.ModifiedBy = Modified.UserID " & vbCrLf
				text2 += " INNER JOIN RequestDtls AS RD ON R.RequestID = RD.RequestID " & vbCrLf
				text2 += " INNER JOIN Product AS M ON RD.ProductID = M.ProductID " & vbCrLf
				text2 += " INNER JOIN (SELECT IssueID, ProductID, COUNT(UID) AS IssuedQty FROM IssueDtls GROUP BY IssueID, ProductID) ID " & vbCrLf
				text2 += " ON I.IssueID = ID.IssueID AND M.ProductID = ID.ProductID" & vbCrLf
			End If
			text2 += " WHERE 1=1" & vbCrLf
			Dim text3 As String = Me.sFormType
			If Operators.CompareString(text3, "Picking", False) <> 0 Then
				If Operators.CompareString(text3, "QA Approval", False) <> 0 Then
					If Operators.CompareString(text3, "Issue", False) = 0 Then
						text2 += " AND I.Status IN ('Issued')"
					End If
				Else
					text2 += " AND I.Status NOT IN ('Cancelled')"
				End If
			End If
			Dim flag2 As Boolean = Operators.CompareString(sID, "", False) <> 0
			If flag2 Then
				text2 = text2 + " AND IssueID = '" + sID + "'" & vbCrLf
				text = text + "IssueID = '" + sID + "'" & vbCrLf
			End If
			Dim flag3 As Boolean = Operators.CompareString(Strings.Trim(Me.txtNo.Text), "", False) <> 0
			If flag3 Then
				text2 = String.Concat(New String() { text2, " And (RequestNo Like '%", Strings.Trim(Me.txtNo.Text), "%' OR IssueNo Like '%", Strings.Trim(Me.txtNo.Text), "%')" & vbCrLf })
				text = text + "TransactionNo LIKE " + Strings.Trim(Me.txtNo.Text) + vbCrLf
			End If
			Dim flag4 As Boolean = Operators.CompareString(Strings.Trim(Me.txtBatchNo.Text), "", False) <> 0
			If flag4 Then
				text2 = text2 + " AND (BatchNo LIKE '%" + Strings.Trim(Me.txtBatchNo.Text) + "%')" & vbCrLf
				text = text + "BatchNo LIKE " + Strings.Trim(Me.txtBatchNo.Text) + vbCrLf
			End If
			Dim flag5 As Boolean = Me.cmbRequestedBy.SelectedIndex > -1
			If flag5 Then
				text2 = text2 + " AND (R.RequestedBy = '" + Strings.Trim(Me.cmbRequestedBy.SelectedValue.ToString()) + "')" & vbCrLf
				text = text + "Requested By = " + Strings.Trim(Me.cmbRequestedBy.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag6 As Boolean = Me.cmbProduct.SelectedIndex > -1
			If flag6 Then
				text2 = text2 + " AND (R.ProductID = '" + Strings.Trim(Me.cmbProduct.SelectedValue.ToString()) + "')" & vbCrLf
				text = text + "ProductID = " + Strings.Trim(Me.cmbProduct.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag7 As Boolean = Me.cmbStatus.SelectedIndex > 0
			If flag7 Then
				text2 = text2 + " AND (I.Status = '" + Me.cmbStatus.Text + "')" & vbCrLf
				text = text + ("Status = " + Me.cmbStatus.Text) + vbCrLf
			End If
			Dim flag8 As Boolean = Operators.CompareString(Me.cmbType.Text, "", False) <> 0
			If flag8 Then
				text2 = text2 + " AND P.ProductType = '" + Me.cmbType.Text + "'" & vbCrLf
			End If
			Dim flag9 As Boolean = (Operators.CompareString(Me.cmbSummary.Text, "Item-wise", False) = 0) And (Operators.CompareString(Me.cmbMaterialType.Text, "", False) <> 0)
			If flag9 Then
				text2 = text2 + " AND M.ProductType = '" + Me.cmbMaterialType.Text + "'" & vbCrLf
			End If
			Dim flag10 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCreated.Text), "", False) <> 0
			If flag10 Then
				Dim flag11 As Boolean = Me.lblCreated.SelectedIndex >= 0
				If flag11 Then
					Dim text4 As String = Me.lblCreated.Text
					Dim text5 As String
					If Operators.CompareString(text4, "Created By", False) <> 0 Then
						If Operators.CompareString(text4, "Last Modified By", False) <> 0 Then
							If Operators.CompareString(text4, "Picking By", False) <> 0 Then
								If Operators.CompareString(text4, "Action By", False) <> 0 Then
									If Operators.CompareString(text4, "Issued By", False) <> 0 Then
										text5 = ""
									Else
										text5 = "Issued"
									End If
								Else
									text5 = "Action"
								End If
							Else
								text5 = "Picking"
							End If
						Else
							text5 = "Modified"
						End If
					Else
						text5 = "Created"
					End If
					Dim flag12 As Boolean = Operators.CompareString(text5, "", False) <> 0
					If flag12 Then
						text2 = String.Concat(New String() { text2, " AND ", text5, ".UserName LIKE '%", Strings.Trim(Me.txtCreated.Text), "%'" })
						text = text + (text5 + "By LIKE " + Strings.Trim(Me.txtCreated.Text)) + vbCrLf
					End If
				End If
			End If
			Dim flag13 As Boolean = Me.lblDate.SelectedIndex >= 0
			If flag13 Then
				Dim text6 As String = Me.lblDate.Text
				Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(text6)
				Dim text7 As String
				If num <= 2191931204UI Then
					If num <= 909288388UI Then
						If num <> 9905901UI Then
							If num = 909288388UI Then
								If Operators.CompareString(text6, "Picking Date", False) = 0 Then
									text7 = "PickingDt"
									GoTo IL_0827
								End If
							End If
						ElseIf Operators.CompareString(text6, "Mfg. Date", False) = 0 Then
							text7 = "MfgDt"
							GoTo IL_0827
						End If
					ElseIf num <> 1193474114UI Then
						If num = 2191931204UI Then
							If Operators.CompareString(text6, "Creation", False) = 0 Then
								text7 = "CreationDt"
								GoTo IL_0827
							End If
						End If
					ElseIf Operators.CompareString(text6, "Request Date", False) = 0 Then
						text7 = "RequestDt"
						GoTo IL_0827
					End If
				ElseIf num <= 3251571134UI Then
					If num <> 2676830049UI Then
						If num = 3251571134UI Then
							If Operators.CompareString(text6, "Expiry Date", False) = 0 Then
								text7 = "ExpDt"
								GoTo IL_0827
							End If
						End If
					ElseIf Operators.CompareString(text6, "Action Date", False) = 0 Then
						text7 = "ActionDt"
						GoTo IL_0827
					End If
				ElseIf num <> 3338871895UI Then
					If num = 4202926516UI Then
						If Operators.CompareString(text6, "Issue Date", False) = 0 Then
							text7 = "IssuedDt"
							GoTo IL_0827
						End If
					End If
				ElseIf Operators.CompareString(text6, "Last Modification", False) = 0 Then
					text7 = "ModificationDt"
					GoTo IL_0827
				End If
				text7 = ""
				IL_0827:
				Dim flag14 As Boolean = Operators.CompareString(text7, "", False) <> 0
				If flag14 Then
					Dim flag15 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
					If flag15 Then
						text2 = String.Concat(New String() { text2, " AND ", text7, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
						text = text + String.Concat(New String() { text7, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
					Else
						Dim checked As Boolean = Me.dtpFrom.Checked
						If checked Then
							text2 = String.Concat(New String() { text2, " AND ", text7, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59"), "'" })
							text = text + String.Concat(New String() { text7, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
						End If
						Dim checked2 As Boolean = Me.dtpTo.Checked
						If checked2 Then
							text2 = String.Concat(New String() { text2, " AND ", text7, " BETWEEN '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
							text = text + String.Concat(New String() { text7, " BETWEEN  ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
						End If
					End If
				End If
			End If
			Dim flag16 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Item-wise", False) = 0
			If flag16 Then
				Dim flag17 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCode.Text), "", False) <> 0
				If flag17 Then
					text2 = text2 + " AND (M.ProductCode Like '%" + Strings.Trim(Me.txtCode.Text) + "%') "
					text = text + "MaterialCode LIKE " + Strings.Trim(Me.txtCode.Text) + vbCrLf
				End If
				Dim flag18 As Boolean = Operators.CompareString(Strings.Trim(Me.txtName.Text), "", False) <> 0
				If flag18 Then
					text2 = text2 + " AND (M.ProductName Like '%" + Strings.Trim(Me.txtName.Text) + "%') "
					text = text + "MaterialName LIKE " + Strings.Trim(Me.txtName.Text) + vbCrLf
				End If
			End If
			text2 += " ORDER BY RequestDt, IssuedDt"
			Dim data As DataTable = MainModule.GetData(text2)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = Nothing
			Me.dgvList.DataSource = data
			Me.dgvList.Columns("ID").Visible = False
			Me.dgvList.Columns("RequestID").Visible = False
			Me.dgvList.Columns("RequestedBy").Visible = False
			Me.dgvList.Columns("ProductID").Visible = False
			Me.dgvList.Columns("PickingBy").Visible = False
			Me.dgvList.Columns("ActionBy").Visible = False
			Me.dgvList.Columns("IssuedBy").Visible = False
			Me.dgvList.Columns("CatalogNo").Visible = False
			Me.dgvList.Columns("CreatedByEmailID").Visible = False
			Me.dgvList.Columns("ModifiedByEmailID").Visible = False
			Me.dgvList.Columns("RequestNo").HeaderText = "Request No."
			Me.dgvList.Columns("RequestDt").HeaderText = "Request Date"
			Me.dgvList.Columns("IssueNo").HeaderText = "Issue No."
			Me.dgvList.Columns("PickingDt").HeaderText = "Picking Date"
			Me.dgvList.Columns("ActionDt").HeaderText = "Action Date"
			Me.dgvList.Columns("IssuedDt").HeaderText = "Issued Date"
			Me.dgvList.Columns("CatalogNo").HeaderText = "Catalog No."
			Me.dgvList.Columns("ProductType").HeaderText = "Product Type"
			Me.dgvList.Columns("ProductName").HeaderText = "Product Name"
			Me.dgvList.Columns("BatchNo").HeaderText = "Batch No."
			Me.dgvList.Columns("MfgDt").HeaderText = "Mfg. Date"
			Me.dgvList.Columns("ExpDt").HeaderText = "Expiry Date"
			Me.dgvList.Columns("BOMVersion").HeaderText = "BOM Version No."
			Me.dgvList.Columns("CreationDt").HeaderText = "Creation Date"
			Me.dgvList.Columns("CreatedBy").HeaderText = "Created By"
			Me.dgvList.Columns("ModificationDt").HeaderText = "Modification Date"
			Me.dgvList.Columns("ModifiedBy").HeaderText = "Modified By"
			Me.dgvList.Columns("RequestDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("PickingDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("ActionDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("IssuedDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("MfgDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("ExpDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("CreationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			Me.dgvList.Columns("ModificationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			Me.dgvList.Columns("RequestNo").Width = 130
			Me.dgvList.Columns("RequestDt").Width = 120
			Me.dgvList.Columns("PickingDt").Width = 120
			Me.dgvList.Columns("ActionDt").Width = 120
			Me.dgvList.Columns("IssuedDt").Width = 120
			Me.dgvList.Columns("Requested By").Width = 225
			Me.dgvList.Columns("Picking By").Width = 225
			Me.dgvList.Columns("Action By").Width = 225
			Me.dgvList.Columns("Issued By").Width = 225
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
			Dim flag19 As Boolean = data.Columns.Contains("MaterialCode")
			If flag19 Then
				Me.dgvList.Columns("MaterialID").Visible = False
				Me.dgvList.Columns("MaterialCode").HeaderText = "Material Code"
				Me.dgvList.Columns("MaterialCatalogNo").HeaderText = "Material Catalog No."
				Me.dgvList.Columns("MaterialName").HeaderText = "Material Name"
				Me.dgvList.Columns("MaterialType").HeaderText = "Material Type"
				Me.dgvList.Columns("PrimaryUOM").HeaderText = "Primary UOM"
				Me.dgvList.Columns("PrimaryPackSize").HeaderText = "Primary PackSize"
				Me.dgvList.Columns("RequiredQty").HeaderText = "Required Qty."
				Me.dgvList.Columns("IssuedQty").HeaderText = "Issued Qty."
				Me.dgvList.Columns("MaterialCode").Width = 180
				Me.dgvList.Columns("MaterialCatalogNo").Width = 180
				Me.dgvList.Columns("MaterialName").Width = 300
				Me.dgvList.Columns("MaterialType").Width = 110
				Me.dgvList.Columns("PrimaryUOM").Width = 90
				Me.dgvList.Columns("PrimaryPackSize").Width = 72
				Me.dgvList.Columns("RequiredQty").Width = 60
				Me.dgvList.Columns("IssuedQty").Width = 60
				Me.dgvList.Columns("RequiredQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("IssuedQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x04000AB5 RID: 2741
		Private sFormType As String

		' Token: 0x04000AB6 RID: 2742
		Private pnlBasicDefaultHeight As Integer

		' Token: 0x04000AB7 RID: 2743
		Private pnlBasicSetHeight As Integer

		' Token: 0x04000AB8 RID: 2744
		Private pnlAdvDefaultHeight As Integer

		' Token: 0x04000AB9 RID: 2745
		Private pnlAdvSetHeight As Integer
	End Class
End Namespace
