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
	' Token: 0x02000055 RID: 85
	<DesignerGenerated()>
	Public Partial Class AddPR01
		Inherits Form

		' Token: 0x170005EA RID: 1514
		' (get) Token: 0x06000FC3 RID: 4035 RVA: 0x000943B1 File Offset: 0x000925B1
		' (set) Token: 0x06000FC4 RID: 4036 RVA: 0x000943BB File Offset: 0x000925BB
		Friend Overridable Property pnlBorder As Panel

		' Token: 0x170005EB RID: 1515
		' (get) Token: 0x06000FC5 RID: 4037 RVA: 0x000943C4 File Offset: 0x000925C4
		' (set) Token: 0x06000FC6 RID: 4038 RVA: 0x000943CE File Offset: 0x000925CE
		Friend Overridable Property pnlMain As Panel

		' Token: 0x170005EC RID: 1516
		' (get) Token: 0x06000FC7 RID: 4039 RVA: 0x000943D7 File Offset: 0x000925D7
		' (set) Token: 0x06000FC8 RID: 4040 RVA: 0x000943E4 File Offset: 0x000925E4
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

		' Token: 0x170005ED RID: 1517
		' (get) Token: 0x06000FC9 RID: 4041 RVA: 0x00094427 File Offset: 0x00092627
		' (set) Token: 0x06000FCA RID: 4042 RVA: 0x00094431 File Offset: 0x00092631
		Friend Overridable Property picFormIcon As PictureBox

		' Token: 0x170005EE RID: 1518
		' (get) Token: 0x06000FCB RID: 4043 RVA: 0x0009443A File Offset: 0x0009263A
		' (set) Token: 0x06000FCC RID: 4044 RVA: 0x00094444 File Offset: 0x00092644
		Friend Overridable Property lblCaption As Label

		' Token: 0x170005EF RID: 1519
		' (get) Token: 0x06000FCD RID: 4045 RVA: 0x0009444D File Offset: 0x0009264D
		' (set) Token: 0x06000FCE RID: 4046 RVA: 0x00094458 File Offset: 0x00092658
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

		' Token: 0x170005F0 RID: 1520
		' (get) Token: 0x06000FCF RID: 4047 RVA: 0x0009449B File Offset: 0x0009269B
		' (set) Token: 0x06000FD0 RID: 4048 RVA: 0x000944A5 File Offset: 0x000926A5
		Friend Overridable Property pnlShadow As Panel

		' Token: 0x170005F1 RID: 1521
		' (get) Token: 0x06000FD1 RID: 4049 RVA: 0x000944AE File Offset: 0x000926AE
		' (set) Token: 0x06000FD2 RID: 4050 RVA: 0x000944B8 File Offset: 0x000926B8
		Friend Overridable Property GbBasic As GroupBox

		' Token: 0x170005F2 RID: 1522
		' (get) Token: 0x06000FD3 RID: 4051 RVA: 0x000944C1 File Offset: 0x000926C1
		' (set) Token: 0x06000FD4 RID: 4052 RVA: 0x000944CB File Offset: 0x000926CB
		Friend Overridable Property cmbPlant As ComboBox

		' Token: 0x170005F3 RID: 1523
		' (get) Token: 0x06000FD5 RID: 4053 RVA: 0x000944D4 File Offset: 0x000926D4
		' (set) Token: 0x06000FD6 RID: 4054 RVA: 0x000944DE File Offset: 0x000926DE
		Friend Overridable Property Label1 As Label

		' Token: 0x170005F4 RID: 1524
		' (get) Token: 0x06000FD7 RID: 4055 RVA: 0x000944E7 File Offset: 0x000926E7
		' (set) Token: 0x06000FD8 RID: 4056 RVA: 0x000944F1 File Offset: 0x000926F1
		Friend Overridable Property txtNo As TextBox

		' Token: 0x170005F5 RID: 1525
		' (get) Token: 0x06000FD9 RID: 4057 RVA: 0x000944FA File Offset: 0x000926FA
		' (set) Token: 0x06000FDA RID: 4058 RVA: 0x00094504 File Offset: 0x00092704
		Friend Overridable Property cmbStatus As ComboBox

		' Token: 0x170005F6 RID: 1526
		' (get) Token: 0x06000FDB RID: 4059 RVA: 0x0009450D File Offset: 0x0009270D
		' (set) Token: 0x06000FDC RID: 4060 RVA: 0x00094517 File Offset: 0x00092717
		Friend Overridable Property dtpFrom As DateTimePicker

		' Token: 0x170005F7 RID: 1527
		' (get) Token: 0x06000FDD RID: 4061 RVA: 0x00094520 File Offset: 0x00092720
		' (set) Token: 0x06000FDE RID: 4062 RVA: 0x0009452A File Offset: 0x0009272A
		Friend Overridable Property Label11 As Label

		' Token: 0x170005F8 RID: 1528
		' (get) Token: 0x06000FDF RID: 4063 RVA: 0x00094533 File Offset: 0x00092733
		' (set) Token: 0x06000FE0 RID: 4064 RVA: 0x0009453D File Offset: 0x0009273D
		Friend Overridable Property dtpTo As DateTimePicker

		' Token: 0x170005F9 RID: 1529
		' (get) Token: 0x06000FE1 RID: 4065 RVA: 0x00094546 File Offset: 0x00092746
		' (set) Token: 0x06000FE2 RID: 4066 RVA: 0x00094550 File Offset: 0x00092750
		Friend Overridable Property Label16 As Label

		' Token: 0x170005FA RID: 1530
		' (get) Token: 0x06000FE3 RID: 4067 RVA: 0x00094559 File Offset: 0x00092759
		' (set) Token: 0x06000FE4 RID: 4068 RVA: 0x00094563 File Offset: 0x00092763
		Friend Overridable Property lblDate As ComboBox

		' Token: 0x170005FB RID: 1531
		' (get) Token: 0x06000FE5 RID: 4069 RVA: 0x0009456C File Offset: 0x0009276C
		' (set) Token: 0x06000FE6 RID: 4070 RVA: 0x00094578 File Offset: 0x00092778
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

		' Token: 0x170005FC RID: 1532
		' (get) Token: 0x06000FE7 RID: 4071 RVA: 0x000945BB File Offset: 0x000927BB
		' (set) Token: 0x06000FE8 RID: 4072 RVA: 0x000945C5 File Offset: 0x000927C5
		Friend Overridable Property GbAdvanced As GroupBox

		' Token: 0x170005FD RID: 1533
		' (get) Token: 0x06000FE9 RID: 4073 RVA: 0x000945CE File Offset: 0x000927CE
		' (set) Token: 0x06000FEA RID: 4074 RVA: 0x000945D8 File Offset: 0x000927D8
		Friend Overridable Property pnlItem As Panel

		' Token: 0x170005FE RID: 1534
		' (get) Token: 0x06000FEB RID: 4075 RVA: 0x000945E1 File Offset: 0x000927E1
		' (set) Token: 0x06000FEC RID: 4076 RVA: 0x000945EB File Offset: 0x000927EB
		Friend Overridable Property txtName As TextBox

		' Token: 0x170005FF RID: 1535
		' (get) Token: 0x06000FED RID: 4077 RVA: 0x000945F4 File Offset: 0x000927F4
		' (set) Token: 0x06000FEE RID: 4078 RVA: 0x000945FE File Offset: 0x000927FE
		Friend Overridable Property txtCatalogNo As TextBox

		' Token: 0x17000600 RID: 1536
		' (get) Token: 0x06000FEF RID: 4079 RVA: 0x00094607 File Offset: 0x00092807
		' (set) Token: 0x06000FF0 RID: 4080 RVA: 0x00094611 File Offset: 0x00092811
		Friend Overridable Property Label14 As Label

		' Token: 0x17000601 RID: 1537
		' (get) Token: 0x06000FF1 RID: 4081 RVA: 0x0009461A File Offset: 0x0009281A
		' (set) Token: 0x06000FF2 RID: 4082 RVA: 0x00094624 File Offset: 0x00092824
		Friend Overridable Property Label5 As Label

		' Token: 0x17000602 RID: 1538
		' (get) Token: 0x06000FF3 RID: 4083 RVA: 0x0009462D File Offset: 0x0009282D
		' (set) Token: 0x06000FF4 RID: 4084 RVA: 0x00094637 File Offset: 0x00092837
		Friend Overridable Property txtCode As TextBox

		' Token: 0x17000603 RID: 1539
		' (get) Token: 0x06000FF5 RID: 4085 RVA: 0x00094640 File Offset: 0x00092840
		' (set) Token: 0x06000FF6 RID: 4086 RVA: 0x0009464A File Offset: 0x0009284A
		Friend Overridable Property Label6 As Label

		' Token: 0x17000604 RID: 1540
		' (get) Token: 0x06000FF7 RID: 4087 RVA: 0x00094653 File Offset: 0x00092853
		' (set) Token: 0x06000FF8 RID: 4088 RVA: 0x00094660 File Offset: 0x00092860
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

		' Token: 0x17000605 RID: 1541
		' (get) Token: 0x06000FF9 RID: 4089 RVA: 0x000946A3 File Offset: 0x000928A3
		' (set) Token: 0x06000FFA RID: 4090 RVA: 0x000946AD File Offset: 0x000928AD
		Friend Overridable Property Label13 As Label

		' Token: 0x17000606 RID: 1542
		' (get) Token: 0x06000FFB RID: 4091 RVA: 0x000946B6 File Offset: 0x000928B6
		' (set) Token: 0x06000FFC RID: 4092 RVA: 0x000946C0 File Offset: 0x000928C0
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

		' Token: 0x17000607 RID: 1543
		' (get) Token: 0x06000FFD RID: 4093 RVA: 0x00094703 File Offset: 0x00092903
		' (set) Token: 0x06000FFE RID: 4094 RVA: 0x0009470D File Offset: 0x0009290D
		Friend Overridable Property Label9 As Label

		' Token: 0x17000608 RID: 1544
		' (get) Token: 0x06000FFF RID: 4095 RVA: 0x00094716 File Offset: 0x00092916
		' (set) Token: 0x06001000 RID: 4096 RVA: 0x00094720 File Offset: 0x00092920
		Friend Overridable Property txtCreated As TextBox

		' Token: 0x17000609 RID: 1545
		' (get) Token: 0x06001001 RID: 4097 RVA: 0x00094729 File Offset: 0x00092929
		' (set) Token: 0x06001002 RID: 4098 RVA: 0x00094733 File Offset: 0x00092933
		Friend Overridable Property lblCreated As ComboBox

		' Token: 0x1700060A RID: 1546
		' (get) Token: 0x06001003 RID: 4099 RVA: 0x0009473C File Offset: 0x0009293C
		' (set) Token: 0x06001004 RID: 4100 RVA: 0x00094748 File Offset: 0x00092948
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

		' Token: 0x1700060B RID: 1547
		' (get) Token: 0x06001005 RID: 4101 RVA: 0x0009478B File Offset: 0x0009298B
		' (set) Token: 0x06001006 RID: 4102 RVA: 0x00094795 File Offset: 0x00092995
		Friend Overridable Property grpListButton As GroupBox

		' Token: 0x1700060C RID: 1548
		' (get) Token: 0x06001007 RID: 4103 RVA: 0x0009479E File Offset: 0x0009299E
		' (set) Token: 0x06001008 RID: 4104 RVA: 0x000947A8 File Offset: 0x000929A8
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x1700060D RID: 1549
		' (get) Token: 0x06001009 RID: 4105 RVA: 0x000947B1 File Offset: 0x000929B1
		' (set) Token: 0x0600100A RID: 4106 RVA: 0x000947BC File Offset: 0x000929BC
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

		' Token: 0x1700060E RID: 1550
		' (get) Token: 0x0600100B RID: 4107 RVA: 0x000947FF File Offset: 0x000929FF
		' (set) Token: 0x0600100C RID: 4108 RVA: 0x0009480C File Offset: 0x00092A0C
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

		' Token: 0x1700060F RID: 1551
		' (get) Token: 0x0600100D RID: 4109 RVA: 0x0009484F File Offset: 0x00092A4F
		' (set) Token: 0x0600100E RID: 4110 RVA: 0x0009485C File Offset: 0x00092A5C
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

		' Token: 0x17000610 RID: 1552
		' (get) Token: 0x0600100F RID: 4111 RVA: 0x0009489F File Offset: 0x00092A9F
		' (set) Token: 0x06001010 RID: 4112 RVA: 0x000948A9 File Offset: 0x00092AA9
		Friend Overridable Property lblRows As Label

		' Token: 0x17000611 RID: 1553
		' (get) Token: 0x06001011 RID: 4113 RVA: 0x000948B2 File Offset: 0x00092AB2
		' (set) Token: 0x06001012 RID: 4114 RVA: 0x000948BC File Offset: 0x00092ABC
		Friend Overridable Property dgvListDtls As DataGridView

		' Token: 0x17000612 RID: 1554
		' (get) Token: 0x06001013 RID: 4115 RVA: 0x000948C5 File Offset: 0x00092AC5
		' (set) Token: 0x06001014 RID: 4116 RVA: 0x000948D0 File Offset: 0x00092AD0
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

		' Token: 0x17000613 RID: 1555
		' (get) Token: 0x06001015 RID: 4117 RVA: 0x00094913 File Offset: 0x00092B13
		' (set) Token: 0x06001016 RID: 4118 RVA: 0x0009491D File Offset: 0x00092B1D
		Friend Overridable Property chk As DataGridViewCheckBoxColumn

		' Token: 0x17000614 RID: 1556
		' (get) Token: 0x06001017 RID: 4119 RVA: 0x00094926 File Offset: 0x00092B26
		' (set) Token: 0x06001018 RID: 4120 RVA: 0x00094930 File Offset: 0x00092B30
		Friend Overridable Property lblUnregistered As Label

		' Token: 0x17000615 RID: 1557
		' (get) Token: 0x06001019 RID: 4121 RVA: 0x00094939 File Offset: 0x00092B39
		' (set) Token: 0x0600101A RID: 4122 RVA: 0x00094943 File Offset: 0x00092B43
		Friend Overridable Property Label7 As Label

		' Token: 0x17000616 RID: 1558
		' (get) Token: 0x0600101B RID: 4123 RVA: 0x0009494C File Offset: 0x00092B4C
		' (set) Token: 0x0600101C RID: 4124 RVA: 0x00094956 File Offset: 0x00092B56
		Friend Overridable Property SplitContainer1 As SplitContainer

		' Token: 0x17000617 RID: 1559
		' (get) Token: 0x0600101D RID: 4125 RVA: 0x0009495F File Offset: 0x00092B5F
		' (set) Token: 0x0600101E RID: 4126 RVA: 0x00094969 File Offset: 0x00092B69
		Friend Overridable Property theme_tc As TabControl

		' Token: 0x17000618 RID: 1560
		' (get) Token: 0x0600101F RID: 4127 RVA: 0x00094972 File Offset: 0x00092B72
		' (set) Token: 0x06001020 RID: 4128 RVA: 0x0009497C File Offset: 0x00092B7C
		Friend Overridable Property tpItems As TabPage

		' Token: 0x17000619 RID: 1561
		' (get) Token: 0x06001021 RID: 4129 RVA: 0x00094985 File Offset: 0x00092B85
		' (set) Token: 0x06001022 RID: 4130 RVA: 0x0009498F File Offset: 0x00092B8F
		Friend Overridable Property tab_lbl3 As Label

		' Token: 0x1700061A RID: 1562
		' (get) Token: 0x06001023 RID: 4131 RVA: 0x00094998 File Offset: 0x00092B98
		' (set) Token: 0x06001024 RID: 4132 RVA: 0x000949A2 File Offset: 0x00092BA2
		Friend Overridable Property tpDoc As TabPage

		' Token: 0x1700061B RID: 1563
		' (get) Token: 0x06001025 RID: 4133 RVA: 0x000949AB File Offset: 0x00092BAB
		' (set) Token: 0x06001026 RID: 4134 RVA: 0x000949B5 File Offset: 0x00092BB5
		Friend Overridable Property tab_lbl5 As Label

		' Token: 0x1700061C RID: 1564
		' (get) Token: 0x06001027 RID: 4135 RVA: 0x000949BE File Offset: 0x00092BBE
		' (set) Token: 0x06001028 RID: 4136 RVA: 0x000949C8 File Offset: 0x00092BC8
		Friend Overridable Property dgvFile As DataGridView
			<CompilerGenerated()>
			Get
				Return Me._dgvFile
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim dataGridViewCellEventHandler As DataGridViewCellEventHandler = AddressOf Me.dgvFile_CellContentClick
				Dim dataGridView As DataGridView = Me._dgvFile
				If dataGridView IsNot Nothing Then
					RemoveHandler dataGridView.CellContentClick, dataGridViewCellEventHandler
				End If
				Me._dgvFile = value
				dataGridView = Me._dgvFile
				If dataGridView IsNot Nothing Then
					AddHandler dataGridView.CellContentClick, dataGridViewCellEventHandler
				End If
			End Set
		End Property

		' Token: 0x1700061D RID: 1565
		' (get) Token: 0x06001029 RID: 4137 RVA: 0x00094A0B File Offset: 0x00092C0B
		' (set) Token: 0x0600102A RID: 4138 RVA: 0x00094A15 File Offset: 0x00092C15
		Friend Overridable Property FileID As DataGridViewTextBoxColumn

		' Token: 0x1700061E RID: 1566
		' (get) Token: 0x0600102B RID: 4139 RVA: 0x00094A1E File Offset: 0x00092C1E
		' (set) Token: 0x0600102C RID: 4140 RVA: 0x00094A28 File Offset: 0x00092C28
		Friend Overridable Property btnDownload_File As DataGridViewImageColumn

		' Token: 0x1700061F RID: 1567
		' (get) Token: 0x0600102D RID: 4141 RVA: 0x00094A31 File Offset: 0x00092C31
		' (set) Token: 0x0600102E RID: 4142 RVA: 0x00094A3B File Offset: 0x00092C3B
		Friend Overridable Property FileName As DataGridViewTextBoxColumn

		' Token: 0x17000620 RID: 1568
		' (get) Token: 0x0600102F RID: 4143 RVA: 0x00094A44 File Offset: 0x00092C44
		' (set) Token: 0x06001030 RID: 4144 RVA: 0x00094A4E File Offset: 0x00092C4E
		Friend Overridable Property btnDelete_File As DataGridViewImageColumn

		' Token: 0x06001031 RID: 4145
		Private Declare Sub SendMessage Lib "user32.DLL" (hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

		' Token: 0x06001032 RID: 4146
		Private Declare Sub ReleaseCapture Lib "user32.DLL" ()

		' Token: 0x06001033 RID: 4147 RVA: 0x00094A57 File Offset: 0x00092C57
		Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs)
			AddPR01.ReleaseCapture()
			AddPR01.SendMessage(MyBase.Handle, 274, 61458, 0)
		End Sub

		' Token: 0x06001034 RID: 4148 RVA: 0x00094A78 File Offset: 0x00092C78
		Public Sub New(VendorID As String, Dept As String)
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			AddHandler MyBase.Shown, AddressOf Me.AddPR01_Shown
			Me.InitializeComponent()
			Designing.SetTheme(Me)
			Me.picFormIcon.Image = ResourceModule.imgFormIconPic
			MyBase.FormBorderStyle = FormBorderStyle.None
			Me.BackColor = Color.GhostWhite
			MyBase.TransparencyKey = Color.GhostWhite
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.lblCaption.Text = Me.Text
			Me.form_btnClose.DialogResult = DialogResult.Cancel
			Me.pnlBasicDefaultHeight = Me.GbBasic.Height
			Me.pnlBasicSetHeight = 24
			Me.pnlAdvDefaultHeight = 24
			Me.pnlAdvSetHeight = Me.GbAdvanced.Height
			Me.sVendorID = VendorID
			Me.sDept = Dept
		End Sub

		' Token: 0x06001035 RID: 4149 RVA: 0x00094B61 File Offset: 0x00092D61
		Private Sub form_btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06001036 RID: 4150 RVA: 0x00094B6C File Offset: 0x00092D6C
		Private Sub SetSearchPanel()
			Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
			Me.GbBasic.Height = Me.pnlBasicDefaultHeight
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
		End Sub

		' Token: 0x06001037 RID: 4151 RVA: 0x00094BC0 File Offset: 0x00092DC0
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

		' Token: 0x06001038 RID: 4152 RVA: 0x00094C30 File Offset: 0x00092E30
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

		' Token: 0x06001039 RID: 4153 RVA: 0x00094CA0 File Offset: 0x00092EA0
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Me.SetSearchPanel()
			Designing.SetTheme(Me)
			Me.FillCombo()
			Me.ClearList()
			Me.SetForm()
		End Sub

		' Token: 0x0600103A RID: 4154 RVA: 0x00094CC6 File Offset: 0x00092EC6
		Private Sub AddPR01_Shown(sender As Object, e As EventArgs)
			Me.SetTabs()
		End Sub

		' Token: 0x0600103B RID: 4155 RVA: 0x00094CD0 File Offset: 0x00092ED0
		Private Sub SetTabs()
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = CInt(Math.Round(CDbl((Me.theme_tc.Width - 5)) / 2.0))
			Me.theme_tc.ItemSize = New Size(num, 30)
			Me.tab_lbl3.Width = num
			Me.tab_lbl5.Width = num + 3
			Me.tab_lbl3.Location = New Point(0, 0)
			Me.tab_lbl5.Location = New Point(num - 4, 0)
		End Sub

		' Token: 0x0600103C RID: 4156 RVA: 0x00094D58 File Offset: 0x00092F58
		Private Sub FillCombo()
			Dim text As String = "SELECT VendorID, VendorName FROM Vendor ORDER BY VendorName"
			Dim data As DataTable = MainModule.GetData(text)
			Me.cmbVendor.ValueMember = "VendorID"
			Me.cmbVendor.DisplayMember = "VendorName"
			Me.cmbVendor.DataSource = data
			Me.cmbVendor.SelectedValue = Me.sVendorID
			Me.cmbVendor.Enabled = False
		End Sub

		' Token: 0x0600103D RID: 4157 RVA: 0x00094DC1 File Offset: 0x00092FC1
		Private Sub SetForm()
			Me.cmbStatus.Text = "Cost Approved"
			Me.cmbSummary.Text = "PR-wise"
			Me.cmbStatus.Enabled = False
			Me.cmbSummary.Enabled = False
		End Sub

		' Token: 0x0600103E RID: 4158 RVA: 0x00094E00 File Offset: 0x00093000
		Private Sub ClearList()
			Me.lblDate.SelectedIndex = 0
			Me.lblCreated.SelectedIndex = 0
			Me.txtNo.Text = ""
			Me.txtCreated.Text = ""
			Me.cmbVendor.SelectedValue = Me.sVendorID
			Me.cmbStatus.Text = "Cost Approved"
			Me.dtpFrom.Value = DateAndTime.Now
			Me.dtpTo.Value = DateAndTime.Now
			Me.dtpFrom.Checked = False
			Me.dtpTo.Checked = False
			Me.lblRows.Text = "0 - Rows"
			Me.cmbSummary.Text = "PR-wise"
			Me.txtCode.Text = ""
			Me.txtCatalogNo.Text = ""
			Me.txtName.Text = ""
			Me.SetSummary()
			Me.dgvList.DataSource = Nothing
			Me.FillItems(Conversions.ToString(0))
			Me.dtFile = FileAttachments.CreateFileTable()
			FileAttachments.SetFileDatagridview(Me.dtFile, Me.dgvFile)
		End Sub

		' Token: 0x0600103F RID: 4159 RVA: 0x00094F3C File Offset: 0x0009313C
		Private Sub btnClearList_Click(sender As Object, e As EventArgs)
			Me.ClearList()
		End Sub

		' Token: 0x06001040 RID: 4160 RVA: 0x00094F46 File Offset: 0x00093146
		Private Sub cmbSummary_SelectedValueChanged(sender As Object, e As EventArgs)
			Me.SetSummary()
		End Sub

		' Token: 0x06001041 RID: 4161 RVA: 0x00094F50 File Offset: 0x00093150
		Private Sub SetSummary()
			Dim text As String = Me.cmbSummary.Text
			If Operators.CompareString(text, "PR-wise", False) <> 0 Then
				If Operators.CompareString(text, "Item-wise", False) = 0 Then
					Me.pnlItem.Visible = True
					Me.pnlAdvSetHeight = 142
					Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(Me.arrow_btnAdvanceExp_sml.Tag, "ArrowUp", False)
					If flag Then
						Me.GbAdvanced.Height = Me.pnlAdvSetHeight
					End If
				End If
			Else
				Me.pnlItem.Visible = True
				Me.pnlAdvSetHeight = 142
				Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(Me.arrow_btnAdvanceExp_sml.Tag, "ArrowUp", False)
				If flag2 Then
					Me.GbAdvanced.Height = Me.pnlAdvSetHeight
				End If
			End If
			Me.txtCode.Text = ""
			Me.txtCatalogNo.Text = ""
			Me.txtName.Text = ""
		End Sub

		' Token: 0x06001042 RID: 4162 RVA: 0x00095054 File Offset: 0x00093254
		Private Sub cmbVendor_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbVendor.SelectedIndex = -1
			If flag Then
				Me.cmbVendor.Text = ""
			End If
		End Sub

		' Token: 0x06001043 RID: 4163 RVA: 0x00095088 File Offset: 0x00093288
		Private Sub dgvFile_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = e.RowIndex > -1
			If flag Then
				Dim array As DataRow() = Me.dtFile.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("FileID = '", Me.dgvFile.Rows(e.RowIndex).Cells("FileID").Value), "'")))
				Dim flag2 As Boolean = array.Length = 1
				If flag2 Then
					Dim text As String = Me.dgvFile.Columns(e.ColumnIndex).Name.ToString()
					If Operators.CompareString(text, "btnDelete_File", False) <> 0 Then
						If Operators.CompareString(text, "btnDownload_File", False) = 0 Then
							FileAttachments.DownloadFile(array(0))
						End If
					Else
						Me.dtFile.Rows.Remove(array(0))
						FileAttachments.SetFileDatagridview(Me.dtFile, Me.dgvFile)
					End If
				End If
			End If
		End Sub

		' Token: 0x06001044 RID: 4164 RVA: 0x0009517C File Offset: 0x0009337C
		Private Sub btnSearch_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SearchData("")
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06001045 RID: 4165 RVA: 0x000951F0 File Offset: 0x000933F0
		Private Sub SearchData(sID As String)
			Dim text As String = ""
			Dim text2 As String = " SELECT DISTINCT P.PRID AS ID, P.PRNo, P.PRDt, P.RequestedBy RequestedByID, " & vbCrLf
			text2 += " Req.UserName AS RequestedBy, Req.EmailID ReqEmailID, P.Department, P.RequiredByDt, " & vbCrLf
			text2 += " P.VendorID, V.VendorName, P.Status, P.ApprovalLevel, P.Remarks, P.ActionRemarks, " & vbCrLf
			text2 += " Action.UserName AS ActionBy, P.ActionDt, " & vbCrLf
			text2 += " Created.EmailID AS CreatedByEmailID, Modified.EmailID AS ModifiedByEmailID, " & vbCrLf
			text2 += " P.CreationDt, Created.UserName AS CreatedBy, P.ModificationDt, Modified.UserName AS ModifiedBy " & vbCrLf
			text2 += " FROM PR AS P " & vbCrLf
			text2 += " INNER JOIN PRItems PI ON P.PRID = PI.PRID " & vbCrLf
			text2 += " LEFT OUTER JOIN Product Pr ON Pr.ProductID = PI.ProductID " & vbCrLf
			text2 += " LEFT OUTER JOIN Vendor AS V ON P.VendorID = V.VendorID " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Action ON P.ActionBy = Action.UserID " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Req ON P.RequestedBy = Req.UserID " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Created ON P.CreatedBy = Created.UserID " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Modified ON P.ModifiedBy = Modified.UserID " & vbCrLf
			text2 += " WHERE 1=1 AND P.Status = 'Cost Approved'" & vbCrLf
			text2 = text2 + " AND P.Department = '" + Me.sDept + "'"
			Dim flag As Boolean = Operators.CompareString(sID, "", False) <> 0
			If flag Then
				text2 = text2 + " And P.PRID = '" + sID + "'" & vbCrLf
				text = text + "PRID = '" + sID + "'" & vbCrLf
			End If
			Dim flag2 As Boolean = Operators.CompareString(Strings.Trim(Me.txtNo.Text), "", False) <> 0
			If flag2 Then
				text2 = text2 + " AND (PRNo LIKE '%" + Strings.Trim(Me.txtNo.Text) + "%')" & vbCrLf
				text = text + "PRNo LIKE " + Strings.Trim(Me.txtNo.Text) + vbCrLf
			End If
			Dim flag3 As Boolean = Me.cmbVendor.SelectedIndex > -1
			If flag3 Then
				text2 = text2 + " AND (P.VendorID = '" + Strings.Trim(Me.cmbVendor.SelectedValue.ToString()) + "' OR P.VendorID IS NULL)" & vbCrLf
				text = text + "VendorID = " + Strings.Trim(Me.cmbVendor.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag4 As Boolean = Me.cmbStatus.SelectedIndex > 0
			If flag4 Then
				text2 = text2 + " AND (P.Status = '" + Me.cmbStatus.Text + "')" & vbCrLf
				text = text + ("P.Status = " + Me.cmbStatus.Text) + vbCrLf
			End If
			Dim flag5 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCreated.Text), "", False) <> 0
			If flag5 Then
				Dim flag6 As Boolean = Me.lblCreated.SelectedIndex >= 0
				If flag6 Then
					Dim text3 As String = Me.lblCreated.Text
					Dim text4 As String
					If Operators.CompareString(text3, "Requested By", False) <> 0 Then
						If Operators.CompareString(text3, "Created By", False) <> 0 Then
							If Operators.CompareString(text3, "Last Modified By", False) = 0 Then
								text4 = "Modified"
							End If
						Else
							text4 = "Created"
						End If
					Else
						text4 = "Req"
					End If
					text2 = String.Concat(New String() { text2, " AND ", text4, ".UserName LIKE '%", Strings.Trim(Me.txtCreated.Text), "%'" })
					text = text + (text4 + "By LIKE " + Strings.Trim(Me.txtCreated.Text)) + vbCrLf
				End If
			End If
			Dim flag7 As Boolean = Me.lblDate.SelectedIndex >= 0
			If flag7 Then
				Dim text5 As String = Me.lblDate.Text
				Dim text6 As String
				If Operators.CompareString(text5, "Creation", False) <> 0 Then
					If Operators.CompareString(text5, "Last Modification", False) <> 0 Then
						If Operators.CompareString(text5, "P.R. Date", False) <> 0 Then
							If Operators.CompareString(text5, "Required By Date", False) <> 0 Then
								text6 = ""
							Else
								text6 = "RequiredByDt"
							End If
						Else
							text6 = "PRDt"
						End If
					Else
						text6 = "ModificationDt"
					End If
				Else
					text6 = "CreationDt"
				End If
				Dim flag8 As Boolean = Operators.CompareString(text6, "", False) <> 0
				If flag8 Then
					Dim flag9 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
					If flag9 Then
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
			Dim flag10 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Item-wise", False) = 0
			If flag10 Then
				Dim flag11 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCode.Text), "", False) <> 0
				If flag11 Then
					text2 = text2 + " AND (PI.ProductCode Like '%" + Strings.Trim(Me.txtCode.Text) + "%') "
					text = text + "ProductCode LIKE " + Strings.Trim(Me.txtCode.Text) + vbCrLf
				End If
				Dim flag12 As Boolean = Operators.CompareString(Strings.Trim(Me.txtName.Text), "", False) <> 0
				If flag12 Then
					text2 = text2 + " AND (PI.ProductName Like '%" + Strings.Trim(Me.txtName.Text) + "%') "
					text = text + "ProductName LIKE " + Strings.Trim(Me.txtName.Text) + vbCrLf
				End If
				Dim flag13 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCatalogNo.Text), "", False) <> 0
				If flag13 Then
					text2 = text2 + " AND (PI.ProductCode Like '%" + Strings.Trim(Me.txtCatalogNo.Text) + "%') "
					text = text + "ProductCode LIKE " + Strings.Trim(Me.txtCatalogNo.Text) + vbCrLf
				End If
			End If
			text2 += " ORDER BY PRDt" & vbCrLf
			Dim data As DataTable = MainModule.GetData(text2)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = data
			Me.dgvList.Columns("ID").Visible = False
			Me.dgvList.Columns("VendorID").Visible = False
			Me.dgvList.Columns("RequestedByID").Visible = False
			Me.dgvList.Columns("ReqEmailID").Visible = False
			Me.dgvList.Columns("CreatedByEmailID").Visible = False
			Me.dgvList.Columns("ModifiedByEmailID").Visible = False
			Me.dgvList.Columns("Remarks").Visible = False
			Me.dgvList.Columns("ActionRemarks").Visible = False
			Me.dgvList.Columns("PRNo").HeaderText = "PR No."
			Me.dgvList.Columns("PRDt").HeaderText = "PR Date"
			Me.dgvList.Columns("RequestedBy").HeaderText = "Requested By"
			Me.dgvList.Columns("RequiredByDt").HeaderText = "Required By Date"
			Me.dgvList.Columns("VendorName").HeaderText = "Vendor Name"
			Me.dgvList.Columns("ActionBy").HeaderText = "Action By"
			Me.dgvList.Columns("ActionDt").HeaderText = "Action Date"
			Me.dgvList.Columns("Status").HeaderText = "Status"
			Me.dgvList.Columns("CreationDt").HeaderText = "Creation Date"
			Me.dgvList.Columns("CreatedBy").HeaderText = "Created By"
			Me.dgvList.Columns("ModificationDt").HeaderText = "Modification Date"
			Me.dgvList.Columns("ModifiedBy").HeaderText = "Modified By"
			Me.dgvList.Columns("PRDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("RequiredByDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("ActionDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("CreationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			Me.dgvList.Columns("ModificationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			Me.dgvList.Columns("PRNo").Width = 130
			Me.dgvList.Columns("PRDt").Width = 120
			Me.dgvList.Columns("RequestedBy").Width = 130
			Me.dgvList.Columns("RequiredByDt").Width = 135
			Me.dgvList.Columns("VendorName").Width = 300
			Me.dgvList.Columns("ActionBy").Width = 130
			Me.dgvList.Columns("ActionDt").Width = 120
			Me.dgvList.Columns("Status").Width = 132
			Me.dgvList.Columns("CreationDt").Width = 170
			Me.dgvList.Columns("CreatedBy").Width = 140
			Me.dgvList.Columns("ModificationDt").Width = 170
			Me.dgvList.Columns("ModifiedBy").Width = 140
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x06001046 RID: 4166 RVA: 0x00095F1C File Offset: 0x0009411C
		Private Sub dgvList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = (e.RowIndex > -1) And (e.ColumnIndex > -1)
			If flag Then
				Dim text As String = Conversions.ToString(Me.dgvList.Rows(e.RowIndex).Cells("ID").Value)
				Me.FillItems(text)
			End If
		End Sub

		' Token: 0x06001047 RID: 4167 RVA: 0x00095F7C File Offset: 0x0009417C
		Private Sub FillItems(sPRID As String)
			Dim text As String = " SELECT 'False' chk, PIs.PRID, PR.PRNo, PR.PRDt, Req.UserName AS RequestedBy, " & vbCrLf
			text += " Req.EmailID RequestedByEmailID, V.VendorName, " & vbCrLf
			text += " PIs.ProductID, PIs.ProductType, PIs.ProductCode, P.CatalogNo, " & vbCrLf
			text += " PIs.ProductName, PIs.Description, P.HSNSACCode, PIs.UnitPrice, " & vbCrLf
			text += " CONVERT(INT, P.TertiaryPackSize) * CONVERT(INT, P.PrimaryPackSize) * PIs.Quantity Quantity, P.Measurement, "
			text += " P.TertiaryUOM, PIs.TertiaryPackSize, P.PrimaryUOM, PIs.PrimaryPackSize, " & vbCrLf
			text += " PIs.BasicValue, PIs.NetAmt, PIs.TaxPer, PIs.TaxAmt, " & vbCrLf
			text += " PIs.OtherCharges, PIs.FinalAmt " & vbCrLf
			text += " FROM PRItems AS PIs " & vbCrLf
			text += " INNER JOIN PR ON PR.PRID = PIs.PRID " & vbCrLf
			text += " LEFT JOIN Product AS P ON PIs.ProductID = P.ProductID" & vbCrLf
			text += " LEFT OUTER JOIN [User] AS Req ON PR.RequestedBy = Req.UserID" & vbCrLf
			text += " LEFT OUTER JOIN Vendor AS V ON PR.VendorID = V.VendorID" & vbCrLf
			text = text + " WHERE PIs.PRID = '" + sPRID + "' AND PIs.Status = 'Pending'"
			Me.dtItems = MainModule.GetData(text)
			Me.dgvListDtls.DataSource = Me.dtItems
			Me.dgvListDtls.Columns("PRID").Visible = False
			Me.dgvListDtls.Columns("PRNo").Visible = False
			Me.dgvListDtls.Columns("PRDt").Visible = False
			Me.dgvListDtls.Columns("PRDt").Visible = False
			Me.dgvListDtls.Columns("PRDt").Visible = False
			Me.dgvListDtls.Columns("ProductID").Visible = False
			Me.dgvListDtls.Columns("RequestedBy").Visible = False
			Me.dgvListDtls.Columns("RequestedByEmailID").Visible = False
			Me.dgvListDtls.Columns("VendorName").Visible = False
			Me.dgvListDtls.Columns("ProductType").HeaderText = "Product Type"
			Me.dgvListDtls.Columns("ProductCode").HeaderText = "Product Code"
			Me.dgvListDtls.Columns("ProductName").HeaderText = "Product Name"
			Me.dgvListDtls.Columns("ProductType").HeaderText = "Product Type"
			Me.dgvListDtls.Columns("TertiaryUOM").HeaderText = "Tertiary UOM"
			Me.dgvListDtls.Columns("TertiaryPackSize").HeaderText = "Tertiary PackSize"
			Me.dgvListDtls.Columns("PrimaryUOM").HeaderText = "Primary UOM"
			Me.dgvListDtls.Columns("PrimaryPackSize").HeaderText = "Primary PackSize"
			Me.dgvListDtls.Columns("BasicValue").HeaderText = "Basic Value"
			Me.dgvListDtls.Columns("NetAmt").HeaderText = "Net Amt"
			Me.dgvListDtls.Columns("TaxPer").HeaderText = "Tax %"
			Me.dgvListDtls.Columns("TaxAmt").HeaderText = "Tax Amt"
			Me.dgvListDtls.Columns("OtherCharges").HeaderText = "Other Charges"
			Me.dgvListDtls.Columns("FinalAmt").HeaderText = "Final Amt"
			Me.dgvListDtls.Columns("ProductType").Width = 30
			Me.dgvListDtls.Columns("ProductCode").Width = 180
			Me.dgvListDtls.Columns("ProductName").Width = 300
			Me.dgvListDtls.Columns("Description").Width = 300
			Me.dgvListDtls.Columns("ProductType").Width = 110
			Me.dgvListDtls.Columns("TertiaryUOM").Width = 90
			Me.dgvListDtls.Columns("TertiaryPackSize").Width = 72
			Me.dgvListDtls.Columns("Quantity").Width = 60
			Me.dgvListDtls.Columns("BasicValue").Width = 75
			Me.dgvListDtls.Columns("NetAmt").Width = 75
			Me.dgvListDtls.Columns("TaxPer").Width = 60
			Me.dgvListDtls.Columns("TaxAmt").Width = 75
			Me.dgvListDtls.Columns("OtherCharges").Width = 75
			Me.dgvListDtls.Columns("FinalAmt").Width = 75
			Me.dgvListDtls.Columns("Description").DefaultCellStyle.WrapMode = DataGridViewTriState.[True]
			Me.dgvListDtls.Columns("TertiaryPackSize").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			Me.dgvListDtls.Columns("PrimaryPackSize").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			Me.dgvListDtls.Columns("Quantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			Me.dgvListDtls.Columns("BasicValue").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			Me.dgvListDtls.Columns("NetAmt").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			Me.dgvListDtls.Columns("TaxPer").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			Me.dgvListDtls.Columns("TaxAmt").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			Me.dgvListDtls.Columns("OtherCharges").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			Me.dgvListDtls.Columns("FinalAmt").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			Me.dgvListDtls.Columns("ProductType").[ReadOnly] = True
			Me.dgvListDtls.Columns("ProductCode").[ReadOnly] = True
			Me.dgvListDtls.Columns("ProductName").[ReadOnly] = True
			Me.dgvListDtls.Columns("ProductType").[ReadOnly] = True
			Me.dgvListDtls.Columns("TertiaryUOM").[ReadOnly] = True
			Me.dgvListDtls.Columns("TertiaryPackSize").[ReadOnly] = True
			Me.dgvListDtls.Columns("PrimaryUOM").[ReadOnly] = True
			Me.dgvListDtls.Columns("PrimaryPackSize").[ReadOnly] = True
			Me.dgvListDtls.Columns("Quantity").[ReadOnly] = True
			Me.dgvListDtls.Columns("BasicValue").[ReadOnly] = True
			Me.dgvListDtls.Columns("NetAmt").[ReadOnly] = True
			Me.dgvListDtls.Columns("TaxPer").[ReadOnly] = True
			Me.dgvListDtls.Columns("TaxAmt").[ReadOnly] = True
			Me.dgvListDtls.Columns("OtherCharges").[ReadOnly] = True
			Me.dgvListDtls.Columns("FinalAmt").[ReadOnly] = True
			Dim num As Integer = Me.dgvListDtls.Rows.Count - 1
			For i As Integer = 0 To num
				Dim flag As Boolean = Operators.CompareString(Me.dgvListDtls.Rows(i).Cells("ProductID").Value.ToString(), "0", False) = 0
				If flag Then
					Me.dgvListDtls.Rows(i).DefaultCellStyle.ForeColor = Me.lblUnregistered.BackColor
				Else
					Me.dgvListDtls.Rows(i).DefaultCellStyle.ForeColor = Color.Black
				End If
			Next
			Me.dtFile = FileAttachments.FillFileAttachments("PR Generation", sPRID)
			FileAttachments.SetFileDatagridview(Me.dtFile, Me.dgvFile)
		End Sub

		' Token: 0x06001048 RID: 4168 RVA: 0x00096874 File Offset: 0x00094A74
		Private Sub btnAdd_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.AddPRItems()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06001049 RID: 4169 RVA: 0x000968E0 File Offset: 0x00094AE0
		Private Function ValidateAdd() As Boolean
			Dim flag As Boolean = Me.dtItems.[Select]("chk = 'True'").Length = 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Select A PR Product.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				flag2 = False
			Else
				Dim flag3 As Boolean = Me.dtItems.[Select]("ProductID = 0 AND chk = 'True'").Length > 0
				If flag3 Then
					CustomMsgBox.Show("Unregistered Product Cannot Be Selected.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					flag2 = False
				Else
					Dim num As Integer = Me.dtItems.Rows.Count - 1
					For i As Integer = 0 To num
						Dim flag4 As Boolean = Me.dtPR.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("PRID = '", Me.dtItems.Rows(i)("PRID")), "' AND ProductID = '"), Me.dtItems.Rows(i)("ProductID")), "'"))).Length > 0
						If flag4 Then
							Dim dataTable As DataTable = CType(Me.dgvList.DataSource, DataTable)
							Dim dataRow As DataRow = dataTable.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("ID = '", Me.dtItems.Rows(i)("PRID")), "'")))(0)
							Dim text As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("The Selected Product : ", Me.dtItems.Rows(i)("ProductName")), ", "), vbCrLf))
							text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject("Already In The List For PR : ", dataRow("PRNo"))))
							CustomMsgBox.Show(text, "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Return False
						End If
					Next
					flag2 = True
				End If
			End If
			Return flag2
		End Function

		' Token: 0x0600104A RID: 4170 RVA: 0x00096ACC File Offset: 0x00094CCC
		Private Sub AddPRItems()
			Dim flag As Boolean = Not Me.ValidateAdd()
			If Not flag Then
				MyBase.DialogResult = DialogResult.OK
				MyBase.Close()
			End If
		End Sub

		' Token: 0x040006D3 RID: 1747
		Public dtPR As DataTable

		' Token: 0x040006D4 RID: 1748
		Public dtItems As DataTable

		' Token: 0x040006D5 RID: 1749
		Public dtFile As DataTable

		' Token: 0x040006D6 RID: 1750
		Private sVendorID As String

		' Token: 0x040006D7 RID: 1751
		Private sDept As String

		' Token: 0x040006D8 RID: 1752
		Private pnlBasicDefaultHeight As Integer

		' Token: 0x040006D9 RID: 1753
		Private pnlBasicSetHeight As Integer

		' Token: 0x040006DA RID: 1754
		Private pnlAdvDefaultHeight As Integer

		' Token: 0x040006DB RID: 1755
		Private pnlAdvSetHeight As Integer
	End Class
End Namespace
