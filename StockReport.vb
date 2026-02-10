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
	' Token: 0x02000029 RID: 41
	<DesignerGenerated()>
	Public Partial Class StockReport
		Inherits DockContent

		' Token: 0x17000412 RID: 1042
		' (get) Token: 0x06000AB1 RID: 2737 RVA: 0x00064237 File Offset: 0x00062437
		' (set) Token: 0x06000AB2 RID: 2738 RVA: 0x00064241 File Offset: 0x00062441
		Friend Overridable Property GbBasic As GroupBox

		' Token: 0x17000413 RID: 1043
		' (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0006424A File Offset: 0x0006244A
		' (set) Token: 0x06000AB4 RID: 2740 RVA: 0x00064254 File Offset: 0x00062454
		Friend Overridable Property txtName As TextBox

		' Token: 0x17000414 RID: 1044
		' (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0006425D File Offset: 0x0006245D
		' (set) Token: 0x06000AB6 RID: 2742 RVA: 0x00064267 File Offset: 0x00062467
		Friend Overridable Property Label11 As Label

		' Token: 0x17000415 RID: 1045
		' (get) Token: 0x06000AB7 RID: 2743 RVA: 0x00064270 File Offset: 0x00062470
		' (set) Token: 0x06000AB8 RID: 2744 RVA: 0x0006427A File Offset: 0x0006247A
		Friend Overridable Property txtCode As TextBox

		' Token: 0x17000416 RID: 1046
		' (get) Token: 0x06000AB9 RID: 2745 RVA: 0x00064283 File Offset: 0x00062483
		' (set) Token: 0x06000ABA RID: 2746 RVA: 0x0006428D File Offset: 0x0006248D
		Friend Overridable Property Label14 As Label

		' Token: 0x17000417 RID: 1047
		' (get) Token: 0x06000ABB RID: 2747 RVA: 0x00064296 File Offset: 0x00062496
		' (set) Token: 0x06000ABC RID: 2748 RVA: 0x000642A0 File Offset: 0x000624A0
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

		' Token: 0x17000418 RID: 1048
		' (get) Token: 0x06000ABD RID: 2749 RVA: 0x000642E3 File Offset: 0x000624E3
		' (set) Token: 0x06000ABE RID: 2750 RVA: 0x000642ED File Offset: 0x000624ED
		Friend Overridable Property GbAdvanced As GroupBox

		' Token: 0x17000419 RID: 1049
		' (get) Token: 0x06000ABF RID: 2751 RVA: 0x000642F6 File Offset: 0x000624F6
		' (set) Token: 0x06000AC0 RID: 2752 RVA: 0x00064300 File Offset: 0x00062500
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

		' Token: 0x1700041A RID: 1050
		' (get) Token: 0x06000AC1 RID: 2753 RVA: 0x00064343 File Offset: 0x00062543
		' (set) Token: 0x06000AC2 RID: 2754 RVA: 0x0006434D File Offset: 0x0006254D
		Friend Overridable Property grpListButton As GroupBox

		' Token: 0x1700041B RID: 1051
		' (get) Token: 0x06000AC3 RID: 2755 RVA: 0x00064356 File Offset: 0x00062556
		' (set) Token: 0x06000AC4 RID: 2756 RVA: 0x00064360 File Offset: 0x00062560
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x1700041C RID: 1052
		' (get) Token: 0x06000AC5 RID: 2757 RVA: 0x00064369 File Offset: 0x00062569
		' (set) Token: 0x06000AC6 RID: 2758 RVA: 0x00064374 File Offset: 0x00062574
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

		' Token: 0x1700041D RID: 1053
		' (get) Token: 0x06000AC7 RID: 2759 RVA: 0x000643B7 File Offset: 0x000625B7
		' (set) Token: 0x06000AC8 RID: 2760 RVA: 0x000643C4 File Offset: 0x000625C4
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

		' Token: 0x1700041E RID: 1054
		' (get) Token: 0x06000AC9 RID: 2761 RVA: 0x00064407 File Offset: 0x00062607
		' (set) Token: 0x06000ACA RID: 2762 RVA: 0x00064414 File Offset: 0x00062614
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

		' Token: 0x1700041F RID: 1055
		' (get) Token: 0x06000ACB RID: 2763 RVA: 0x00064457 File Offset: 0x00062657
		' (set) Token: 0x06000ACC RID: 2764 RVA: 0x00064461 File Offset: 0x00062661
		Friend Overridable Property lblRows As Label

		' Token: 0x17000420 RID: 1056
		' (get) Token: 0x06000ACD RID: 2765 RVA: 0x0006446A File Offset: 0x0006266A
		' (set) Token: 0x06000ACE RID: 2766 RVA: 0x00064474 File Offset: 0x00062674
		Friend Overridable Property dgvList As DataGridView

		' Token: 0x17000421 RID: 1057
		' (get) Token: 0x06000ACF RID: 2767 RVA: 0x0006447D File Offset: 0x0006267D
		' (set) Token: 0x06000AD0 RID: 2768 RVA: 0x00064487 File Offset: 0x00062687
		Friend Overridable Property txtCatalogNo As TextBox

		' Token: 0x17000422 RID: 1058
		' (get) Token: 0x06000AD1 RID: 2769 RVA: 0x00064490 File Offset: 0x00062690
		' (set) Token: 0x06000AD2 RID: 2770 RVA: 0x0006449A File Offset: 0x0006269A
		Friend Overridable Property Label2 As Label

		' Token: 0x17000423 RID: 1059
		' (get) Token: 0x06000AD3 RID: 2771 RVA: 0x000644A3 File Offset: 0x000626A3
		' (set) Token: 0x06000AD4 RID: 2772 RVA: 0x000644AD File Offset: 0x000626AD
		Friend Overridable Property dtpFrom As DateTimePicker

		' Token: 0x17000424 RID: 1060
		' (get) Token: 0x06000AD5 RID: 2773 RVA: 0x000644B6 File Offset: 0x000626B6
		' (set) Token: 0x06000AD6 RID: 2774 RVA: 0x000644C0 File Offset: 0x000626C0
		Friend Overridable Property dtpTo As DateTimePicker

		' Token: 0x17000425 RID: 1061
		' (get) Token: 0x06000AD7 RID: 2775 RVA: 0x000644C9 File Offset: 0x000626C9
		' (set) Token: 0x06000AD8 RID: 2776 RVA: 0x000644D3 File Offset: 0x000626D3
		Friend Overridable Property lblTo As Label

		' Token: 0x17000426 RID: 1062
		' (get) Token: 0x06000AD9 RID: 2777 RVA: 0x000644DC File Offset: 0x000626DC
		' (set) Token: 0x06000ADA RID: 2778 RVA: 0x000644E6 File Offset: 0x000626E6
		Friend Overridable Property Panel1 As Panel

		' Token: 0x17000427 RID: 1063
		' (get) Token: 0x06000ADB RID: 2779 RVA: 0x000644EF File Offset: 0x000626EF
		' (set) Token: 0x06000ADC RID: 2780 RVA: 0x000644F9 File Offset: 0x000626F9
		Friend Overridable Property pnlLocation As Panel

		' Token: 0x17000428 RID: 1064
		' (get) Token: 0x06000ADD RID: 2781 RVA: 0x00064502 File Offset: 0x00062702
		' (set) Token: 0x06000ADE RID: 2782 RVA: 0x0006450C File Offset: 0x0006270C
		Friend Overridable Property txtLocation As TextBox

		' Token: 0x17000429 RID: 1065
		' (get) Token: 0x06000ADF RID: 2783 RVA: 0x00064515 File Offset: 0x00062715
		' (set) Token: 0x06000AE0 RID: 2784 RVA: 0x0006451F File Offset: 0x0006271F
		Friend Overridable Property lblLocation As Label

		' Token: 0x1700042A RID: 1066
		' (get) Token: 0x06000AE1 RID: 2785 RVA: 0x00064528 File Offset: 0x00062728
		' (set) Token: 0x06000AE2 RID: 2786 RVA: 0x00064532 File Offset: 0x00062732
		Friend Overridable Property pnlStatus As Panel

		' Token: 0x1700042B RID: 1067
		' (get) Token: 0x06000AE3 RID: 2787 RVA: 0x0006453B File Offset: 0x0006273B
		' (set) Token: 0x06000AE4 RID: 2788 RVA: 0x00064545 File Offset: 0x00062745
		Friend Overridable Property lblStatus As Label

		' Token: 0x1700042C RID: 1068
		' (get) Token: 0x06000AE5 RID: 2789 RVA: 0x0006454E File Offset: 0x0006274E
		' (set) Token: 0x06000AE6 RID: 2790 RVA: 0x00064558 File Offset: 0x00062758
		Friend Overridable Property cmbStatus As ComboBox

		' Token: 0x1700042D RID: 1069
		' (get) Token: 0x06000AE7 RID: 2791 RVA: 0x00064561 File Offset: 0x00062761
		' (set) Token: 0x06000AE8 RID: 2792 RVA: 0x0006456B File Offset: 0x0006276B
		Friend Overridable Property pnlGRN As Panel

		' Token: 0x1700042E RID: 1070
		' (get) Token: 0x06000AE9 RID: 2793 RVA: 0x00064574 File Offset: 0x00062774
		' (set) Token: 0x06000AEA RID: 2794 RVA: 0x0006457E File Offset: 0x0006277E
		Friend Overridable Property lblGRNNo As Label

		' Token: 0x1700042F RID: 1071
		' (get) Token: 0x06000AEB RID: 2795 RVA: 0x00064587 File Offset: 0x00062787
		' (set) Token: 0x06000AEC RID: 2796 RVA: 0x00064591 File Offset: 0x00062791
		Friend Overridable Property txtGRNNo As TextBox

		' Token: 0x17000430 RID: 1072
		' (get) Token: 0x06000AED RID: 2797 RVA: 0x0006459A File Offset: 0x0006279A
		' (set) Token: 0x06000AEE RID: 2798 RVA: 0x000645A4 File Offset: 0x000627A4
		Friend Overridable Property lblDate As ComboBox

		' Token: 0x17000431 RID: 1073
		' (get) Token: 0x06000AEF RID: 2799 RVA: 0x000645AD File Offset: 0x000627AD
		' (set) Token: 0x06000AF0 RID: 2800 RVA: 0x000645B8 File Offset: 0x000627B8
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

		' Token: 0x17000432 RID: 1074
		' (get) Token: 0x06000AF1 RID: 2801 RVA: 0x000645FB File Offset: 0x000627FB
		' (set) Token: 0x06000AF2 RID: 2802 RVA: 0x00064608 File Offset: 0x00062808
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

		' Token: 0x17000433 RID: 1075
		' (get) Token: 0x06000AF3 RID: 2803 RVA: 0x0006464B File Offset: 0x0006284B
		' (set) Token: 0x06000AF4 RID: 2804 RVA: 0x00064655 File Offset: 0x00062855
		Friend Overridable Property Label9 As Label

		' Token: 0x17000434 RID: 1076
		' (get) Token: 0x06000AF5 RID: 2805 RVA: 0x0006465E File Offset: 0x0006285E
		' (set) Token: 0x06000AF6 RID: 2806 RVA: 0x00064668 File Offset: 0x00062868
		Friend Overridable Property Label1 As Label

		' Token: 0x17000435 RID: 1077
		' (get) Token: 0x06000AF7 RID: 2807 RVA: 0x00064671 File Offset: 0x00062871
		' (set) Token: 0x06000AF8 RID: 2808 RVA: 0x0006467B File Offset: 0x0006287B
		Friend Overridable Property cmbType As ComboBox

		' Token: 0x17000436 RID: 1078
		' (get) Token: 0x06000AF9 RID: 2809 RVA: 0x00064684 File Offset: 0x00062884
		' (set) Token: 0x06000AFA RID: 2810 RVA: 0x0006468E File Offset: 0x0006288E
		Friend Overridable Property Label13 As Label

		' Token: 0x17000437 RID: 1079
		' (get) Token: 0x06000AFB RID: 2811 RVA: 0x00064697 File Offset: 0x00062897
		' (set) Token: 0x06000AFC RID: 2812 RVA: 0x000646A1 File Offset: 0x000628A1
		Friend Overridable Property Label7 As Label

		' Token: 0x17000438 RID: 1080
		' (get) Token: 0x06000AFD RID: 2813 RVA: 0x000646AA File Offset: 0x000628AA
		' (set) Token: 0x06000AFE RID: 2814 RVA: 0x000646B4 File Offset: 0x000628B4
		Friend Overridable Property txtBatchNo As TextBox

		' Token: 0x17000439 RID: 1081
		' (get) Token: 0x06000AFF RID: 2815 RVA: 0x000646BD File Offset: 0x000628BD
		' (set) Token: 0x06000B00 RID: 2816 RVA: 0x000646C7 File Offset: 0x000628C7
		Friend Overridable Property pnlUID As Panel

		' Token: 0x1700043A RID: 1082
		' (get) Token: 0x06000B01 RID: 2817 RVA: 0x000646D0 File Offset: 0x000628D0
		' (set) Token: 0x06000B02 RID: 2818 RVA: 0x000646DA File Offset: 0x000628DA
		Friend Overridable Property txtUID As TextBox

		' Token: 0x1700043B RID: 1083
		' (get) Token: 0x06000B03 RID: 2819 RVA: 0x000646E3 File Offset: 0x000628E3
		' (set) Token: 0x06000B04 RID: 2820 RVA: 0x000646ED File Offset: 0x000628ED
		Friend Overridable Property Label4 As Label

		' Token: 0x06000B05 RID: 2821 RVA: 0x000646F8 File Offset: 0x000628F8
		Public Sub New(sForm As String)
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.InitializeComponent()
			Designing.SetTheme(Me)
			Me.pnlBasicDefaultHeight = Me.GbBasic.Height
			Me.pnlBasicSetHeight = 23
			Me.pnlAdvDefaultHeight = 23
			Me.pnlAdvSetHeight = Me.GbAdvanced.Height
		End Sub

		' Token: 0x06000B06 RID: 2822 RVA: 0x00064774 File Offset: 0x00062974
		Private Sub SetSearchPanel()
			Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
			Me.GbBasic.Height = Me.pnlBasicDefaultHeight
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
		End Sub

		' Token: 0x06000B07 RID: 2823 RVA: 0x000647C8 File Offset: 0x000629C8
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

		' Token: 0x06000B08 RID: 2824 RVA: 0x00064838 File Offset: 0x00062A38
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

		' Token: 0x06000B09 RID: 2825 RVA: 0x000648A8 File Offset: 0x00062AA8
		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x06000B0A RID: 2826 RVA: 0x000648DD File Offset: 0x00062ADD
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Me.SetSearchPanel()
			Me.FillCombo()
			Me.ClearList()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x06000B0B RID: 2827 RVA: 0x0006490C File Offset: 0x00062B0C
		Private Sub FillCombo()
			Dim text As String = "SELECT VendorID, VendorName FROM Vendor ORDER BY VendorName"
			Dim data As DataTable = MainModule.GetData(text)
			Me.cmbVendor.ValueMember = "VendorID"
			Me.cmbVendor.DisplayMember = "VendorName"
			Me.cmbVendor.DataSource = data
			Me.cmbVendor.SelectedIndex = -1
		End Sub

		' Token: 0x06000B0C RID: 2828 RVA: 0x00064964 File Offset: 0x00062B64
		Private Sub ClearList()
			Me.txtCode.Text = ""
			Me.txtCatalogNo.Text = ""
			Me.txtName.Text = ""
			Me.cmbVendor.SelectedIndex = -1
			Me.txtBatchNo.Text = ""
			Me.cmbType.Text = ""
			Me.cmbStatus.Text = ""
			Me.cmbSummary.Text = "Product-wise"
			Me.lblDate.Text = "Expiry Date"
			Me.dtpFrom.Value = DateAndTime.Now
			Me.dtpFrom.Checked = False
			Me.dtpTo.Value = DateAndTime.Now
			Me.dtpTo.Checked = False
			Me.lblRows.Text = "0 - Rows"
			Me.dgvList.DataSource = Nothing
		End Sub

		' Token: 0x06000B0D RID: 2829 RVA: 0x00064A61 File Offset: 0x00062C61
		Private Sub btnClearList_Click(sender As Object, e As EventArgs)
			Me.ClearList()
		End Sub

		' Token: 0x06000B0E RID: 2830 RVA: 0x00064A6B File Offset: 0x00062C6B
		Private Sub btnExport_Click(sender As Object, e As EventArgs)
			MainModule.ExportToExcel(Me.dgvList, Me.Text)
		End Sub

		' Token: 0x06000B0F RID: 2831 RVA: 0x00064A80 File Offset: 0x00062C80
		Private Sub cmbVendor_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbVendor.SelectedIndex = -1
			If flag Then
				Me.cmbVendor.Text = ""
			End If
		End Sub

		' Token: 0x06000B10 RID: 2832 RVA: 0x00064AB4 File Offset: 0x00062CB4
		Private Sub cmbSummary_SelectedValueChanged(sender As Object, e As EventArgs)
			Me.txtLocation.Text = ""
			Me.txtGRNNo.Text = ""
			Me.cmbStatus.Text = ""
			Me.dtpFrom.Value = DateAndTime.Now
			Me.dtpFrom.Checked = False
			Me.dtpTo.Value = DateAndTime.Now
			Me.dtpTo.Checked = False
			Dim text As String = Me.cmbSummary.Text
			If Operators.CompareString(text, "Detailed", False) <> 0 Then
				If Operators.CompareString(text, "Product-wise", False) <> 0 Then
					If Operators.CompareString(text, "Batch-wise", False) <> 0 Then
						If Operators.CompareString(text, "Location-wise", False) <> 0 Then
							If Operators.CompareString(text, "GRN-wise", False) = 0 Then
								Me.GbAdvanced.Height = 111
								Me.lblDate.Items.Add("GRN Date")
								Me.lblDate.Visible = True
								Me.lblTo.Visible = True
								Me.dtpFrom.Visible = True
								Me.dtpTo.Visible = True
								Me.pnlStatus.Visible = False
								Me.pnlLocation.Visible = False
								Me.pnlGRN.Visible = True
								Me.pnlUID.Visible = False
								Me.Panel1.Height = 81
							End If
						Else
							Me.GbAdvanced.Height = 81
							Me.lblDate.Items.Remove("GRN Date")
							Me.lblDate.Visible = False
							Me.lblTo.Visible = False
							Me.dtpFrom.Visible = False
							Me.dtpTo.Visible = False
							Me.pnlStatus.Visible = False
							Me.pnlLocation.Visible = True
							Me.pnlGRN.Visible = False
							Me.pnlUID.Visible = False
							Me.Panel1.Height = 55
						End If
					Else
						Me.GbAdvanced.Height = 111
						Me.lblDate.Items.Remove("GRN Date")
						Me.lblDate.Visible = True
						Me.lblTo.Visible = True
						Me.dtpFrom.Visible = True
						Me.dtpTo.Visible = True
						Me.pnlStatus.Visible = False
						Me.pnlLocation.Visible = False
						Me.pnlGRN.Visible = False
						Me.pnlUID.Visible = False
						Me.Panel1.Height = 81
					End If
				Else
					Me.GbAdvanced.Height = 81
					Me.lblDate.Items.Remove("GRN Date")
					Me.lblDate.Text = "Expiry Date"
					Me.lblDate.Visible = False
					Me.lblTo.Visible = False
					Me.dtpFrom.Visible = False
					Me.dtpTo.Visible = False
					Me.pnlStatus.Visible = False
					Me.pnlLocation.Visible = False
					Me.pnlGRN.Visible = False
					Me.pnlUID.Visible = False
					Me.Panel1.Height = 55
				End If
			Else
				Me.GbAdvanced.Height = 111
				Me.lblDate.Items.Remove("GRN Date")
				Me.lblDate.Visible = True
				Me.lblTo.Visible = True
				Me.dtpFrom.Visible = True
				Me.dtpTo.Visible = True
				Me.pnlStatus.Visible = True
				Me.pnlLocation.Visible = True
				Me.pnlGRN.Visible = True
				Me.pnlUID.Visible = True
				Me.Panel1.Height = 81
			End If
		End Sub

		' Token: 0x06000B11 RID: 2833 RVA: 0x00064EC4 File Offset: 0x000630C4
		Private Sub btnSearch_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SearchData("")
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06000B12 RID: 2834 RVA: 0x00064F38 File Offset: 0x00063138
		Private Sub SearchData(sID As String)
			Dim text As String = ""
			Dim text2 As String = Me.cmbSummary.Text
			Dim text3 As String
			If Operators.CompareString(text2, "Detailed", False) <> 0 Then
				If Operators.CompareString(text2, "Product-wise", False) <> 0 Then
					If Operators.CompareString(text2, "Batch-wise", False) <> 0 Then
						If Operators.CompareString(text2, "Location-wise", False) <> 0 Then
							If Operators.CompareString(text2, "GRN-wise", False) <> 0 Then
								Return
							End If
							text3 = " SELECT G.GRNNo, G.GRNDt, VendorName, P.ProductID, ProductCode, ProductName, ProductType,  " & vbCrLf
							text3 += " P.CatalogNo, GI.BatchNo, GI.MfgDt, GI.ExpDt, P.PrimaryUOM, GI.PrimaryPackSize, P.Measurement " & vbCrLf
							text3 += " , SUM(CASE WHEN ISNULL(GU.ExpDt,'01/01/2050') > GETDATE() AND GU.Status = 'Available' THEN 1 ELSE 0 END) AS AvlQty" & vbCrLf
							text3 += " , SUM(CASE WHEN ISNULL(GU.ExpDt,'01/01/2050') > GETDATE() AND GU.Status = 'Created' THEN 1 ELSE 0 END) AS QuaQty" & vbCrLf
							text3 += " , SUM(CASE WHEN ISNULL(GU.ExpDt,'01/01/2050') <= GETDATE() THEN 1 ELSE 0 END) AS ExpQty" & vbCrLf
							text3 += " FROM GRN G  " & vbCrLf
							text3 += " INNER JOIN GRNItems GI ON G.GRNID = GI.GRNID " & vbCrLf
							text3 += " INNER JOIN GRNUID GU ON GI.GRNItemsID = GU.GRNItemsID  " & vbCrLf
							text3 += " INNER JOIN Product P ON GU.ProductID = P.ProductID  " & vbCrLf
							text3 += " INNER JOIN Vendor V ON G.VendorID = V.VendorID  " & vbCrLf
							text3 += " WHERE 1=1 "
						Else
							text3 = " SELECT P.ProductID, ProductCode, ProductName, ProductType, P.CatalogNo, GU.BatchNo, " & vbCrLf
							text3 += " GU.MfgDt, GU.ExpDt, GU.LocationCode, LocationName, P.PrimaryUOM, GI.PrimaryPackSize, P.Measurement " & vbCrLf
							text3 += " , SUM(CASE WHEN ISNULL(GU.ExpDt,'01/01/2050') > GETDATE() AND GU.Status = 'Available' THEN 1 ELSE 0 END) AS AvlQty" & vbCrLf
							text3 += " , SUM(CASE WHEN ISNULL(GU.ExpDt,'01/01/2050') > GETDATE() AND GU.Status = 'Created' THEN 1 ELSE 0 END) AS QuaQty" & vbCrLf
							text3 += " , SUM(CASE WHEN ISNULL(GU.ExpDt,'01/01/2050') <= GETDATE() THEN 1 ELSE 0 END) AS ExpQty" & vbCrLf
							text3 += " FROM GRN G " & vbCrLf
							text3 += " INNER JOIN GRNItems GI ON G.GRNID = GI.GRNID" & vbCrLf
							text3 += " INNER JOIN GRNUID GU ON GI.GRNItemsID = GU.GRNItemsID " & vbCrLf
							text3 += " INNER JOIN Product P ON GU.ProductID = P.ProductID " & vbCrLf
							text3 += " LEFT OUTER JOIN Location L ON GU.LocationCode = L.LocationCode" & vbCrLf
							text3 += " WHERE 1=1 "
						End If
					Else
						text3 = " SELECT P.ProductID, ProductCode, ProductName, ProductType, P.CatalogNo, GU.BatchNo, GU.MfgDt, GU.ExpDt, " & vbCrLf
						text3 += " P.PrimaryUOM, GI.PrimaryPackSize, P.Measurement, GI.FinalConcentration, GI.Titre, GI.CellCount, GI.ODPermL " & vbCrLf
						text3 += " , SUM(CASE WHEN ISNULL(GU.ExpDt,'01/01/2050') > GETDATE() AND GU.Status = 'Available' THEN 1 ELSE 0 END) AS AvlQty" & vbCrLf
						text3 += " , SUM(CASE WHEN ISNULL(GU.ExpDt,'01/01/2050') > GETDATE() AND GU.Status = 'Created' THEN 1 ELSE 0 END) AS QuaQty" & vbCrLf
						text3 += " , SUM(CASE WHEN ISNULL(GU.ExpDt,'01/01/2050') <= GETDATE() THEN 1 ELSE 0 END) AS ExpQty" & vbCrLf
						text3 += " FROM GRN G " & vbCrLf
						text3 += " INNER JOIN GRNItems GI ON G.GRNID = GI.GRNID" & vbCrLf
						text3 += " INNER JOIN GRNUID GU ON GI.GRNItemsID = GU.GRNItemsID " & vbCrLf
						text3 += " INNER JOIN Product P ON GU.ProductID = P.ProductID " & vbCrLf
						text3 += " WHERE 1=1 "
					End If
				Else
					text3 = " SELECT P.ProductID, ProductCode, ProductName, ProductType, P.CatalogNo, " & vbCrLf
					text3 += " P.PrimaryUOM, GI.PrimaryPackSize, P.Measurement, GI.FinalConcentration, GI.Titre, GI.CellCount, GI.ODPermL, P.ROL " & vbCrLf
					text3 += " , SUM(CASE WHEN ISNULL(GU.ExpDt,'01/01/2050') > GETDATE() AND GU.Status = 'Available' THEN 1 ELSE 0 END) AS AvlQty" & vbCrLf
					text3 += " , SUM(CASE WHEN ISNULL(GU.ExpDt,'01/01/2050') > GETDATE() AND GU.Status = 'Created' THEN 1 ELSE 0 END) AS QuaQty" & vbCrLf
					text3 += " , SUM(CASE WHEN ISNULL(GU.ExpDt,'01/01/2050') <= GETDATE() THEN 1 ELSE 0 END) AS ExpQty" & vbCrLf
					text3 += " FROM GRN G " & vbCrLf
					text3 += " INNER JOIN GRNItems GI ON G.GRNID = GI.GRNID" & vbCrLf
					text3 += " INNER JOIN GRNUID GU ON GI.GRNItemsID = GU.GRNItemsID " & vbCrLf
					text3 += " INNER JOIN Product P ON GU.ProductID = P.ProductID " & vbCrLf
					text3 += " WHERE 1=1 "
				End If
			Else
				text3 = " SELECT G.GRNNo, G.GRNDt, P.ProductID, ProductCode, ProductName, ProductType, P.CatalogNo, " & vbCrLf
				text3 += " VendorName, UID, ParentUID, GU.LocationCode, LocationName, " & vbCrLf
				text3 += " GU.Description, GU.BatchNo, GU.MfgDt, GU.ExpDt, P.PrimaryUOM, GI.PrimaryPackSize, P.Measurement, " & vbCrLf
				text3 += " GI.FinalConcentration, GI.Titre, GI.CellCount, GI.ODPermL, GU.Status " & vbCrLf
				text3 += " FROM GRN G " & vbCrLf
				text3 += " INNER JOIN GRNItems GI ON G.GRNID = GI.GRNID" & vbCrLf
				text3 += " INNER JOIN GRNUID GU ON GI.GRNItemsID = GU.GRNItemsID " & vbCrLf
				text3 += " INNER JOIN Product P ON GU.ProductID = P.ProductID " & vbCrLf
				text3 += " INNER JOIN Vendor V ON G.VendorID = V.VendorID " & vbCrLf
				text3 += " LEFT OUTER JOIN Location L ON GU.LocationCode = L.LocationCode " & vbCrLf
				text3 += " WHERE 1=1 "
			End If
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.txtCode.Text), "", False) <> 0
			If flag Then
				text3 = text3 + " AND (ProductCode Like '%" + Strings.Trim(Me.txtCode.Text) + "%') "
				text = text + "ProductCode LIKE " + Strings.Trim(Me.txtCode.Text) + vbCrLf
			End If
			Dim flag2 As Boolean = Operators.CompareString(Strings.Trim(Me.txtName.Text), "", False) <> 0
			If flag2 Then
				text3 = text3 + " AND (ProductName Like '%" + Strings.Trim(Me.txtName.Text) + "%') "
				text = text + "ProductName LIKE " + Strings.Trim(Me.txtName.Text) + vbCrLf
			End If
			Dim flag3 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCatalogNo.Text), "", False) <> 0
			If flag3 Then
				text3 = text3 + " AND (P.CatalogNo Like '%" + Strings.Trim(Me.txtCatalogNo.Text) + "%') "
				text = text + "CatalogNo LIKE " + Strings.Trim(Me.txtCatalogNo.Text) + vbCrLf
			End If
			Dim flag4 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Detailed", False) = 0
			If flag4 Then
				Dim flag5 As Boolean = Me.cmbVendor.SelectedIndex > -1
				If flag5 Then
					text3 = text3 + " AND (G.VendorID = '" + Strings.Trim(Me.cmbVendor.SelectedValue.ToString()) + "')" & vbCrLf
					text = text + "VendorID = " + Strings.Trim(Me.cmbVendor.SelectedValue.ToString()) + vbCrLf
				End If
			End If
			Dim flag6 As Boolean = Operators.CompareString(Strings.Trim(Me.txtBatchNo.Text), "", False) <> 0
			If flag6 Then
				text3 = text3 + " AND (GU.BatchNo LIKE '%" + Strings.Trim(Me.txtBatchNo.Text) + "%')" & vbCrLf
				text = text + "BatchNo LIKE " + Strings.Trim(Me.txtBatchNo.Text) + vbCrLf
			End If
			Dim flag7 As Boolean = Operators.CompareString(Strings.Trim(Me.cmbType.Text), "", False) <> 0
			If flag7 Then
				text3 = text3 + " AND (ProductType LIKE '%" + Strings.Trim(Me.cmbType.Text) + "%')"
				text = text + "ProductType LIKE " + Strings.Trim(Me.cmbType.Text) + vbCrLf
			End If
			Dim flag8 As Boolean = Operators.CompareString(Strings.Trim(Me.txtLocation.Text), "", False) <> 0
			If flag8 Then
				text3 = String.Concat(New String() { text3, " AND (L.LocationCode LIKE '%", Strings.Trim(Me.txtLocation.Text), "%' OR L.LocationName LIKE '%", Strings.Trim(Me.txtLocation.Text), "%')" & vbCrLf })
				text = text + "Location LIKE " + Strings.Trim(Me.txtLocation.Text) + vbCrLf
			End If
			Dim flag9 As Boolean = Operators.CompareString(Strings.Trim(Me.txtGRNNo.Text), "", False) <> 0
			If flag9 Then
				text3 = text3 + " AND (G.GRNNo LIKE '%" + Strings.Trim(Me.txtGRNNo.Text) + "%')" & vbCrLf
				text = text + "GRN No. LIKE " + Strings.Trim(Me.txtGRNNo.Text) + vbCrLf
			End If
			Dim flag10 As Boolean = Conversions.ToBoolean(Strings.Trim(Conversions.ToString(Operators.CompareString(Me.txtUID.Text, "", False) <> 0)))
			If flag10 Then
				text3 = String.Concat(New String() { text3, " AND (GU.UID LIKE '%", Strings.Trim(Me.txtUID.Text), "%' OR GU.ParentUID LIKE '%", Strings.Trim(Me.txtUID.Text), "%')" & vbCrLf })
				text = text + "UID LIKE " + Strings.Trim(Me.txtGRNNo.Text) + vbCrLf
			End If
			Dim text4 As String = Me.cmbStatus.Text
			If Operators.CompareString(text4, "In QC Release", False) <> 0 Then
				If Operators.CompareString(text4, "Available", False) <> 0 Then
					If Operators.CompareString(text4, "Disposed", False) <> 0 Then
						If Operators.CompareString(text4, "Expired", False) <> 0 Then
							If Operators.CompareString(text4, "Picked", False) <> 0 Then
								If Operators.CompareString(text4, "Issued", False) <> 0 Then
									text3 += " And (GU.Status In ('Created', 'Available'))" & vbCrLf
								Else
									text3 += " AND (GU.Status = 'Issued')" & vbCrLf
									text += "Status = Issued" & vbCrLf
								End If
							Else
								text3 += " AND (GU.Status = 'Picked')" & vbCrLf
								text += "Status = Picked" & vbCrLf
							End If
						Else
							text3 += " AND (ISNULL(GU.ExpDt,'01/01/2050') <= GETDATE())" & vbCrLf
							text = text + " AND (ISNULL(GU.ExpDt,01/Jan/2050) <= " + Strings.Format(DateAndTime.Now, "dd/MMM/yyyy") + ")" & vbCrLf
						End If
					Else
						text3 += " AND (GU.Status = 'Disposed')" & vbCrLf
						text += "Status = Disposed" & vbCrLf
					End If
				Else
					text3 += " AND (GU.Status = 'Available')" & vbCrLf
					text += "Status = Available" & vbCrLf
				End If
			Else
				text3 += " AND (GU.Status = 'Created')" & vbCrLf
				text += "Status = Created" & vbCrLf
			End If
			Dim flag11 As Boolean = Me.lblDate.SelectedIndex >= 0
			If flag11 Then
				Dim text5 As String = Me.lblDate.Text
				Dim text6 As String
				If Operators.CompareString(text5, "Mfg. Date", False) <> 0 Then
					If Operators.CompareString(text5, "Expiry Date", False) <> 0 Then
						If Operators.CompareString(text5, "GRN Date", False) <> 0 Then
							text6 = ""
						Else
							text6 = "G.GRNDt"
						End If
					Else
						text6 = "GU.ExpDt"
					End If
				Else
					text6 = "GU.MfgDt"
				End If
				Dim flag12 As Boolean = Operators.CompareString(text6, "", False) <> 0
				If flag12 Then
					Dim flag13 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
					If flag13 Then
						text3 = String.Concat(New String() { text3, " AND ", text6, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
						text = text + String.Concat(New String() { text6, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
					Else
						Dim checked As Boolean = Me.dtpFrom.Checked
						If checked Then
							text3 = String.Concat(New String() { text3, " AND ", text6, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59"), "'" })
							text = text + String.Concat(New String() { text6, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
						End If
						Dim checked2 As Boolean = Me.dtpTo.Checked
						If checked2 Then
							text3 = String.Concat(New String() { text3, " AND ", text6, " BETWEEN '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
							text = text + String.Concat(New String() { text6, " BETWEEN  ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
						End If
					End If
				End If
			End If
			Dim text7 As String = Me.cmbSummary.Text
			If Operators.CompareString(text7, "Detailed", False) <> 0 Then
				If Operators.CompareString(text7, "Product-wise", False) <> 0 Then
					If Operators.CompareString(text7, "Batch-wise", False) <> 0 Then
						If Operators.CompareString(text7, "Location-wise", False) <> 0 Then
							If Operators.CompareString(text7, "GRN-wise", False) <> 0 Then
								Return
							End If
							text3 += " GROUP BY G.GRNNo, G.GRNDt, VendorName, P.ProductID, ProductCode, ProductName, ProductType,  " & vbCrLf
							text3 += " P.CatalogNo, GI.BatchNo, GI.MfgDt, GI.ExpDt, P.PrimaryUOM, GI.PrimaryPackSize, P.Measurement " & vbCrLf
						Else
							text3 += " GROUP By P.ProductID, ProductCode, ProductName, ProductType, P.CatalogNo, GU.BatchNo, " & vbCrLf
							text3 += " GU.MfgDt, GU.ExpDt, GU.LocationCode, LocationName, P.PrimaryUOM, GI.PrimaryPackSize, P.Measurement " & vbCrLf
						End If
					Else
						text3 += " GROUP By P.ProductID, ProductCode, ProductName, ProductType, P.CatalogNo, GU.BatchNo, GU.MfgDt, GU.ExpDt, " & vbCrLf
						text3 += " P.PrimaryUOM, GI.PrimaryPackSize, P.Measurement, GI.FinalConcentration, GI.Titre, GI.CellCount, GI.ODPermL " & vbCrLf
					End If
				Else
					text3 += " GROUP BY P.ProductID, ProductCode, ProductName, ProductType, P.CatalogNo, " & vbCrLf
					text3 += " P.PrimaryUOM, GI.PrimaryPackSize, P.Measurement, GI.FinalConcentration, GI.Titre, GI.CellCount, GI.ODPermL, P.ROL" & vbCrLf
				End If
			End If
			text3 += " ORDER BY ProductType, ProductCode, ProductName " & vbCrLf
			Dim data As DataTable = MainModule.GetData(text3)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = Nothing
			Me.dgvList.DataSource = data
			Me.dgvList.Columns("ProductID").Visible = False
			Me.dgvList.Columns("ProductCode").HeaderText = "Product Code"
			Me.dgvList.Columns("ProductName").HeaderText = "Product Name"
			Me.dgvList.Columns("ProductType").HeaderText = "Product Type"
			Me.dgvList.Columns("CatalogNo").HeaderText = "Catalog No."
			Dim flag14 As Boolean = Me.dgvList.Columns.Contains("GRNNo")
			If flag14 Then
				Me.dgvList.Columns("GRNNo").HeaderText = "GRN No."
				Me.dgvList.Columns("GRNNo").Width = 150
				Me.dgvList.Columns("GRNDt").HeaderText = "GRN Date"
				Me.dgvList.Columns("GRNDt").Width = 120
				Me.dgvList.Columns("GRNDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			End If
			Me.dgvList.Columns("ProductCode").Width = 150
			Me.dgvList.Columns("ProductName").Width = 350
			Me.dgvList.Columns("ProductType").Width = 130
			Me.dgvList.Columns("CatalogNo").Width = 140
			Dim flag15 As Boolean = Me.dgvList.Columns.Contains("VendorName")
			If flag15 Then
				Me.dgvList.Columns("VendorName").HeaderText = "Vendor Name"
				Me.dgvList.Columns("VendorName").Width = 315
			End If
			Dim flag16 As Boolean = Me.dgvList.Columns.Contains("Description")
			If flag16 Then
				Me.dgvList.Columns("Description").Width = 250
			End If
			Dim flag17 As Boolean = Me.dgvList.Columns.Contains("MfgDt")
			If flag17 Then
				Me.dgvList.Columns("MfgDt").HeaderText = "Mfg. Date"
				Me.dgvList.Columns("MfgDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
				Me.dgvList.Columns("MfgDt").Width = 120
			End If
			Dim flag18 As Boolean = Me.dgvList.Columns.Contains("ExpDt")
			If flag18 Then
				Me.dgvList.Columns("ExpDt").HeaderText = "Expiry Date"
				Me.dgvList.Columns("ExpDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
				Me.dgvList.Columns("ExpDt").Width = 120
			End If
			Dim flag19 As Boolean = Me.dgvList.Columns.Contains("UID")
			If flag19 Then
				Me.dgvList.Columns("ParentUID").HeaderText = "Parent UID"
				Me.dgvList.Columns("UID").Width = 120
				Me.dgvList.Columns("ParentUID").Width = 120
			End If
			Dim flag20 As Boolean = Me.dgvList.Columns.Contains("LocationCode")
			If flag20 Then
				Me.dgvList.Columns("LocationCode").HeaderText = "Location Code"
				Me.dgvList.Columns("LocationName").HeaderText = "Location Name"
				Me.dgvList.Columns("LocationCode").Width = 115
				Me.dgvList.Columns("LocationName").Width = 150
			End If
			Dim flag21 As Boolean = Me.dgvList.Columns.Contains("Quantity")
			If flag21 Then
				Me.dgvList.Columns("Quantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
			Dim flag22 As Boolean = Me.dgvList.Columns.Contains("AvlQty")
			If flag22 Then
				Me.dgvList.Columns("AvlQty").HeaderText = "Available Qty."
				Me.dgvList.Columns("AvlQty").Width = 75
				Me.dgvList.Columns("AvlQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
			Dim flag23 As Boolean = Me.dgvList.Columns.Contains("QuaQty")
			If flag23 Then
				Me.dgvList.Columns("QuaQty").HeaderText = "Qurantine Qty."
				Me.dgvList.Columns("QuaQty").Width = 75
				Me.dgvList.Columns("QuaQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
			Dim flag24 As Boolean = Me.dgvList.Columns.Contains("ExpQty")
			If flag24 Then
				Me.dgvList.Columns("ExpQty").HeaderText = "Expired Qty."
				Me.dgvList.Columns("ExpQty").Width = 75
				Me.dgvList.Columns("ExpQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
			Dim flag25 As Boolean = Me.dgvList.Columns.Contains("PrimaryUOM")
			If flag25 Then
				Me.dgvList.Columns("PrimaryUOM").HeaderText = "Primary UOM"
				Me.dgvList.Columns("PrimaryUOM").Width = 90
			End If
			Dim flag26 As Boolean = Me.dgvList.Columns.Contains("PrimaryPackSize")
			If flag26 Then
				Me.dgvList.Columns("PrimaryPackSize").HeaderText = "Primary Pack Size"
				Me.dgvList.Columns("PrimaryPackSize").Width = 90
				Me.dgvList.Columns("PrimaryPackSize").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
			Dim flag27 As Boolean = Me.dgvList.Columns.Contains("FinalConcentration")
			If flag27 Then
				Me.dgvList.Columns("FinalConcentration").HeaderText = "Concentration"
				Me.dgvList.Columns("FinalConcentration").Width = 90
				Me.dgvList.Columns("Titre").Width = 90
				Me.dgvList.Columns("FinalConcentration").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("Titre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
			Dim flag28 As Boolean = Me.dgvList.Columns.Contains("CellCount")
			If flag28 Then
				Me.dgvList.Columns("CellCount").HeaderText = "Cell Count"
				Me.dgvList.Columns("CellCount").Width = 90
			End If
			Dim flag29 As Boolean = Me.dgvList.Columns.Contains("ODPermL")
			If flag29 Then
				Me.dgvList.Columns("ODPermL").HeaderText = "OD/ mL"
				Me.dgvList.Columns("ODPermL").Width = 90
			End If
			Dim flag30 As Boolean = Me.dgvList.Columns.Contains("ROL")
			If flag30 Then
				Me.dgvList.Columns("ROL").Width = 70
				Me.dgvList.Columns("ROL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x06000B13 RID: 2835 RVA: 0x00066548 File Offset: 0x00064748
		Private Sub SearchData1(sID As String)
			Dim text As String = ""
			Dim text2 As String = Me.cmbSummary.Text
			Dim text3 As String
			If Operators.CompareString(text2, "Detailed", False) <> 0 Then
				If Operators.CompareString(text2, "Product-wise", False) <> 0 Then
					If Operators.CompareString(text2, "Batch-wise", False) <> 0 Then
						If Operators.CompareString(text2, "Location-wise", False) <> 0 Then
							If Operators.CompareString(text2, "GRN-wise", False) <> 0 Then
								Return
							End If
							text3 = " SELECT G.GRNNo, VendorName, P.ProductID, ProductCode, ProductName, ProductType,  " & vbCrLf
							text3 += " P.CatalogNo, BatchNo, MfgDt, ExpDt, PrimaryUOM " & vbCrLf
							text3 += " , SUM(CASE WHEN ISNULL(GU.ExpDt,'01/01/2050') > GETDATE() AND GU.Status = 'Available' THEN 1 ELSE 0 END) AS AvlQty" & vbCrLf
							text3 += " , SUM(CASE WHEN ISNULL(GU.ExpDt,'01/01/2050') > GETDATE() AND GU.Status = 'Created' THEN 1 ELSE 0 END) AS QuaQty" & vbCrLf
							text3 += " , SUM(CASE WHEN ISNULL(GU.ExpDt,'01/01/2050') <= GETDATE() THEN 1 ELSE 0 END) AS ExpQty" & vbCrLf
							text3 += " FROM GRN G  " & vbCrLf
							text3 += " INNER JOIN GRNUID GU ON G.GRNID = GU.GRNID  " & vbCrLf
							text3 += " INNER JOIN Product P ON GU.ProductID = P.ProductID  " & vbCrLf
							text3 += " INNER JOIN Vendor V ON G.VendorID = V.VendorID  " & vbCrLf
							text3 += " WHERE 1=1 "
						Else
							text3 = " SELECT P.ProductID, ProductCode, ProductName, ProductType, P.CatalogNo, BatchNo, ExpDt, GU.LocationCode, LocationName, P.PrimaryUOM " & vbCrLf
							text3 += " , SUM(CASE WHEN ISNULL(GU.ExpDt,'01/01/2050') > GETDATE() AND GU.Status = 'Available' THEN 1 ELSE 0 END) AS AvlQty" & vbCrLf
							text3 += " , SUM(CASE WHEN ISNULL(GU.ExpDt,'01/01/2050') > GETDATE() AND GU.Status = 'Created' THEN 1 ELSE 0 END) AS QuaQty" & vbCrLf
							text3 += " , SUM(CASE WHEN ISNULL(GU.ExpDt,'01/01/2050') <= GETDATE() THEN 1 ELSE 0 END) AS ExpQty" & vbCrLf
							text3 += " FROM GRN G " & vbCrLf
							text3 += " INNER JOIN GRNUID GU ON G.GRNID = GU.GRNID " & vbCrLf
							text3 += " INNER JOIN Product P ON GU.ProductID = P.ProductID " & vbCrLf
							text3 += " LEFT OUTER JOIN Location L ON GU.LocationCode = L.LocationCode" & vbCrLf
							text3 += " WHERE 1=1 "
						End If
					Else
						text3 = " SELECT P.ProductID, ProductCode, ProductName, ProductType, P.CatalogNo, BatchNo, ExpDt, P.PrimaryUOM " & vbCrLf
						text3 += " , SUM(CASE WHEN ISNULL(GU.ExpDt,'01/01/2050') > GETDATE() AND GU.Status = 'Available' THEN 1 ELSE 0 END) AS AvlQty" & vbCrLf
						text3 += " , SUM(CASE WHEN ISNULL(GU.ExpDt,'01/01/2050') > GETDATE() AND GU.Status = 'Created' THEN 1 ELSE 0 END) AS QuaQty" & vbCrLf
						text3 += " , SUM(CASE WHEN ISNULL(GU.ExpDt,'01/01/2050') <= GETDATE() THEN 1 ELSE 0 END) AS ExpQty" & vbCrLf
						text3 += " FROM GRN G " & vbCrLf
						text3 += " INNER JOIN GRNUID GU ON G.GRNID = GU.GRNID " & vbCrLf
						text3 += " INNER JOIN Product P ON GU.ProductID = P.ProductID " & vbCrLf
						text3 += " WHERE 1=1 "
					End If
				Else
					text3 = " SELECT P.ProductID, ProductCode, ProductName, ProductType, P.CatalogNo, P.PrimaryUOM " & vbCrLf
					text3 += " , SUM(CASE WHEN ISNULL(GU.ExpDt,'01/01/2050') > GETDATE() AND GU.Status = 'Available' THEN 1 ELSE 0 END) AS AvlQty" & vbCrLf
					text3 += " , SUM(CASE WHEN ISNULL(GU.ExpDt,'01/01/2050') > GETDATE() AND GU.Status = 'Created' THEN 1 ELSE 0 END) AS QuaQty" & vbCrLf
					text3 += " , SUM(CASE WHEN ISNULL(GU.ExpDt,'01/01/2050') <= GETDATE() THEN 1 ELSE 0 END) AS ExpQty" & vbCrLf
					text3 += " FROM GRN G " & vbCrLf
					text3 += " INNER JOIN GRNUID GU ON G.GRNID = GU.GRNID " & vbCrLf
					text3 += " INNER JOIN Product P ON GU.ProductID = P.ProductID " & vbCrLf
					text3 += " WHERE 1=1 "
				End If
			Else
				text3 = " SELECT G.GRNNo, P.ProductID, ProductCode, ProductName, ProductType, P.CatalogNo, " & vbCrLf
				text3 += " VendorName, PrimaryUOM, UID, ParentUID, GU.LocationCode, LocationName, " & vbCrLf
				text3 += " GU.Description, BatchNo, MfgDt, ExpDt, GU.Status " & vbCrLf
				text3 += " FROM GRN G " & vbCrLf
				text3 += " INNER JOIN GRNUID GU ON G.GRNID = GU.GRNID " & vbCrLf
				text3 += " INNER JOIN Product P ON GU.ProductID = P.ProductID " & vbCrLf
				text3 += " INNER JOIN Vendor V ON G.VendorID = V.VendorID " & vbCrLf
				text3 += " LEFT OUTER JOIN Location L ON GU.LocationCode = L.LocationCode" & vbCrLf
				text3 += " WHERE 1=1 "
			End If
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.txtCode.Text), "", False) <> 0
			If flag Then
				text3 = text3 + " AND (ProductCode Like '%" + Strings.Trim(Me.txtCode.Text) + "%') "
				text = text + "ProductCode LIKE " + Strings.Trim(Me.txtCode.Text) + vbCrLf
			End If
			Dim flag2 As Boolean = Operators.CompareString(Strings.Trim(Me.txtName.Text), "", False) <> 0
			If flag2 Then
				text3 = text3 + " AND (ProductName Like '%" + Strings.Trim(Me.txtName.Text) + "%') "
				text = text + "ProductName LIKE " + Strings.Trim(Me.txtName.Text) + vbCrLf
			End If
			Dim flag3 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCatalogNo.Text), "", False) <> 0
			If flag3 Then
				text3 = text3 + " AND (P.CatalogNo Like '%" + Strings.Trim(Me.txtCatalogNo.Text) + "%') "
				text = text + "CatalogNo LIKE " + Strings.Trim(Me.txtCatalogNo.Text) + vbCrLf
			End If
			Dim flag4 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Detailed", False) = 0
			If flag4 Then
				Dim flag5 As Boolean = Me.cmbVendor.SelectedIndex > -1
				If flag5 Then
					text3 = text3 + " AND (G.VendorID = '" + Strings.Trim(Me.cmbVendor.SelectedValue.ToString()) + "')" & vbCrLf
					text = text + "VendorID = " + Strings.Trim(Me.cmbVendor.SelectedValue.ToString()) + vbCrLf
				End If
			End If
			Dim flag6 As Boolean = Operators.CompareString(Strings.Trim(Me.txtBatchNo.Text), "", False) <> 0
			If flag6 Then
				text3 = text3 + " AND (GU.BatchNo LIKE '%" + Strings.Trim(Me.txtBatchNo.Text) + "%')" & vbCrLf
				text = text + "BatchNo LIKE " + Strings.Trim(Me.txtBatchNo.Text) + vbCrLf
			End If
			Dim flag7 As Boolean = Operators.CompareString(Strings.Trim(Me.cmbType.Text), "", False) <> 0
			If flag7 Then
				text3 = text3 + " AND (ProductType LIKE '%" + Strings.Trim(Me.cmbType.Text) + "%')"
				text = text + "ProductType LIKE " + Strings.Trim(Me.cmbType.Text) + vbCrLf
			End If
			Dim text4 As String = Me.cmbStatus.Text
			If Operators.CompareString(text4, "In QC Release", False) <> 0 Then
				If Operators.CompareString(text4, "Available", False) <> 0 Then
					If Operators.CompareString(text4, "Disposed", False) <> 0 Then
						If Operators.CompareString(text4, "Expired", False) <> 0 Then
							If Operators.CompareString(text4, "Issued", False) <> 0 Then
								text3 += " And (GU.Status In ('Created', 'Available'))" & vbCrLf
							Else
								text3 += " AND (GU.Status = 'Issued')" & vbCrLf
								text += "Status = Issued" & vbCrLf
							End If
						Else
							text3 += " AND (ISNULL(GU.ExpDt,'01/01/2050') <= GETDATE())" & vbCrLf
							text = text + " AND (ISNULL(GU.ExpDt,01/Jan/2050) <= " + Strings.Format(DateAndTime.Now, "dd/MMM/yyyy") + ")" & vbCrLf
						End If
					Else
						text3 += " AND (GU.Status = 'Disposed')" & vbCrLf
						text += "Status = Disposed" & vbCrLf
					End If
				Else
					text3 += " AND (GU.Status = 'Available')" & vbCrLf
					text += "Status = Available" & vbCrLf
				End If
			Else
				text3 += " AND (GU.Status = 'Created')" & vbCrLf
				text += "Status = Created" & vbCrLf
			End If
			Dim text5 As String = Me.cmbSummary.Text
			If Operators.CompareString(text5, "Detailed", False) <> 0 Then
				If Operators.CompareString(text5, "Product-wise", False) <> 0 Then
					If Operators.CompareString(text5, "Batch-wise", False) <> 0 Then
						If Operators.CompareString(text5, "Location-wise", False) <> 0 Then
							If Operators.CompareString(text5, "GRN-wise", False) <> 0 Then
								Return
							End If
							text3 += " GROUP BY G.GRNNo, VendorName, P.ProductID, ProductCode, ProductName, ProductType,  " & vbCrLf
							text3 += " P.CatalogNo, BatchNo, MfgDt, ExpDt, PrimaryUOM " & vbCrLf
						Else
							text3 += " GROUP By P.ProductID, ProductCode, ProductName, ProductType, P.CatalogNo, BatchNo, ExpDt, GU.LocationCode, LocationName, P.PrimaryUOM " & vbCrLf
						End If
					Else
						text3 += " GROUP By P.ProductID, ProductCode, ProductName, ProductType, P.CatalogNo, BatchNo, ExpDt, P.PrimaryUOM " & vbCrLf
					End If
				Else
					text3 += " GROUP BY P.ProductID, ProductCode, ProductName, ProductType, P.CatalogNo, P.PrimaryUOM" & vbCrLf
				End If
			End If
			Dim flag8 As Boolean = (Me.lblDate.SelectedIndex >= 0) And (Operators.CompareString(Me.cmbSummary.Text, "Detailed", False) = 0)
			If flag8 Then
				Dim text6 As String = Me.lblDate.Text
				Dim text7 As String
				If Operators.CompareString(text6, "Mfg. Date", False) <> 0 Then
					If Operators.CompareString(text6, "Expiry Date", False) <> 0 Then
						text7 = ""
					Else
						text7 = "GU.ExpDt"
					End If
				Else
					text7 = "GU.MfgDt"
				End If
				Dim flag9 As Boolean = Operators.CompareString(text7, "", False) <> 0
				If flag9 Then
					Dim flag10 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
					If flag10 Then
						text3 = String.Concat(New String() { text3, " AND ", text7, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
						text = text + String.Concat(New String() { text7, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
					Else
						Dim checked As Boolean = Me.dtpFrom.Checked
						If checked Then
							text3 = String.Concat(New String() { text3, " AND ", text7, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59"), "'" })
							text = text + String.Concat(New String() { text7, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
						End If
						Dim checked2 As Boolean = Me.dtpTo.Checked
						If checked2 Then
							text3 = String.Concat(New String() { text3, " AND ", text7, " BETWEEN '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
							text = text + String.Concat(New String() { text7, " BETWEEN  ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
						End If
					End If
				End If
			End If
			text3 += " ORDER BY ProductType, ProductCode, ProductName " & vbCrLf
			Dim data As DataTable = MainModule.GetData(text3)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = Nothing
			Me.dgvList.DataSource = data
			Me.dgvList.Columns("ProductID").Visible = False
			Me.dgvList.Columns("ProductCode").HeaderText = "Product Code"
			Me.dgvList.Columns("ProductName").HeaderText = "Product Name"
			Me.dgvList.Columns("ProductType").HeaderText = "Product Type"
			Me.dgvList.Columns("CatalogNo").HeaderText = "Catalog No."
			Dim flag11 As Boolean = Me.dgvList.Columns.Contains("GRNNo")
			If flag11 Then
				Me.dgvList.Columns("GRNNo").HeaderText = "GRN No."
				Me.dgvList.Columns("GRNNo").Width = 150
			End If
			Me.dgvList.Columns("ProductCode").Width = 150
			Me.dgvList.Columns("ProductName").Width = 350
			Me.dgvList.Columns("ProductType").Width = 130
			Me.dgvList.Columns("CatalogNo").Width = 140
			Dim flag12 As Boolean = Me.dgvList.Columns.Contains("VendorName")
			If flag12 Then
				Me.dgvList.Columns("VendorName").HeaderText = "Vendor Name"
				Me.dgvList.Columns("VendorName").Width = 315
			End If
			Dim flag13 As Boolean = Me.dgvList.Columns.Contains("Description")
			If flag13 Then
				Me.dgvList.Columns("Description").Width = 250
			End If
			Dim flag14 As Boolean = Me.dgvList.Columns.Contains("MfgDt")
			If flag14 Then
				Me.dgvList.Columns("MfgDt").HeaderText = "Mfg. Date"
				Me.dgvList.Columns("MfgDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
				Me.dgvList.Columns("MfgDt").Width = 120
			End If
			Dim flag15 As Boolean = Me.dgvList.Columns.Contains("ExpDt")
			If flag15 Then
				Me.dgvList.Columns("ExpDt").HeaderText = "Expiry Date"
				Me.dgvList.Columns("ExpDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
				Me.dgvList.Columns("ExpDt").Width = 120
			End If
			Dim flag16 As Boolean = Me.dgvList.Columns.Contains("PrimaryUOM")
			If flag16 Then
				Me.dgvList.Columns("PrimaryUOM").HeaderText = "Primary UOM"
			End If
			Dim flag17 As Boolean = Me.dgvList.Columns.Contains("UID")
			If flag17 Then
				Me.dgvList.Columns("ParentUID").HeaderText = "Parent UID"
				Me.dgvList.Columns("UID").Width = 120
				Me.dgvList.Columns("ParentUID").Width = 120
			End If
			Dim flag18 As Boolean = Me.dgvList.Columns.Contains("LocationCode")
			If flag18 Then
				Me.dgvList.Columns("LocationCode").HeaderText = "Location Code"
				Me.dgvList.Columns("LocationName").HeaderText = "Location Name"
				Me.dgvList.Columns("LocationCode").Width = 120
				Me.dgvList.Columns("LocationName").Width = 120
			End If
			Dim flag19 As Boolean = Me.dgvList.Columns.Contains("Quantity")
			If flag19 Then
				Me.dgvList.Columns("Quantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
			Dim flag20 As Boolean = Me.dgvList.Columns.Contains("PackSize")
			If flag20 Then
				Me.dgvList.Columns("PackSize").HeaderText = "Pack Size"
				Me.dgvList.Columns("PackSize").Width = 80
				Me.dgvList.Columns("PackSize").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
			Dim flag21 As Boolean = Me.dgvList.Columns.Contains("Units")
			If flag21 Then
				Me.dgvList.Columns("Units").HeaderText = "Units/ Conc."
				Me.dgvList.Columns("Units").Width = 90
				Me.dgvList.Columns("Units").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
			Dim flag22 As Boolean = Me.dgvList.Columns.Contains("AvlQty")
			If flag22 Then
				Me.dgvList.Columns("AvlQty").HeaderText = "Available Qty."
				Me.dgvList.Columns("AvlQty").Width = 75
				Me.dgvList.Columns("AvlQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
			Dim flag23 As Boolean = Me.dgvList.Columns.Contains("QuaQty")
			If flag23 Then
				Me.dgvList.Columns("QuaQty").HeaderText = "Qurantine Qty."
				Me.dgvList.Columns("QuaQty").Width = 75
				Me.dgvList.Columns("QuaQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
			Dim flag24 As Boolean = Me.dgvList.Columns.Contains("ExpQty")
			If flag24 Then
				Me.dgvList.Columns("ExpQty").HeaderText = "Expired Qty."
				Me.dgvList.Columns("ExpQty").Width = 75
				Me.dgvList.Columns("ExpQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x040004A8 RID: 1192
		Private pnlBasicDefaultHeight As Integer

		' Token: 0x040004A9 RID: 1193
		Private pnlBasicSetHeight As Integer

		' Token: 0x040004AA RID: 1194
		Private pnlAdvDefaultHeight As Integer

		' Token: 0x040004AB RID: 1195
		Private pnlAdvSetHeight As Integer
	End Class
End Namespace
