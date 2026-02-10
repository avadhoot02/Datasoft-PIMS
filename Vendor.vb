Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports WeifenLuo.WinFormsUI.Docking

Namespace Datasoft_PIMS
	' Token: 0x02000021 RID: 33
	<DesignerGenerated()>
	Public Partial Class Vendor
		Inherits DockContent

		' Token: 0x1700027D RID: 637
		' (get) Token: 0x06000692 RID: 1682 RVA: 0x00040775 File Offset: 0x0003E975
		' (set) Token: 0x06000693 RID: 1683 RVA: 0x0004077F File Offset: 0x0003E97F
		Friend Overridable Property theme_tc As TabControl

		' Token: 0x1700027E RID: 638
		' (get) Token: 0x06000694 RID: 1684 RVA: 0x00040788 File Offset: 0x0003E988
		' (set) Token: 0x06000695 RID: 1685 RVA: 0x00040792 File Offset: 0x0003E992
		Friend Overridable Property tpDetails As TabPage

		' Token: 0x1700027F RID: 639
		' (get) Token: 0x06000696 RID: 1686 RVA: 0x0004079B File Offset: 0x0003E99B
		' (set) Token: 0x06000697 RID: 1687 RVA: 0x000407A5 File Offset: 0x0003E9A5
		Friend Overridable Property Panel1 As Panel

		' Token: 0x17000280 RID: 640
		' (get) Token: 0x06000698 RID: 1688 RVA: 0x000407AE File Offset: 0x0003E9AE
		' (set) Token: 0x06000699 RID: 1689 RVA: 0x000407B8 File Offset: 0x0003E9B8
		Friend Overridable Property tcDtls As TabControl

		' Token: 0x17000281 RID: 641
		' (get) Token: 0x0600069A RID: 1690 RVA: 0x000407C1 File Offset: 0x0003E9C1
		' (set) Token: 0x0600069B RID: 1691 RVA: 0x000407CB File Offset: 0x0003E9CB
		Friend Overridable Property tpContacts As TabPage

		' Token: 0x17000282 RID: 642
		' (get) Token: 0x0600069C RID: 1692 RVA: 0x000407D4 File Offset: 0x0003E9D4
		' (set) Token: 0x0600069D RID: 1693 RVA: 0x000407E0 File Offset: 0x0003E9E0
		Friend Overridable Property dgvDtls As DataGridView
			<CompilerGenerated()>
			Get
				Return Me._dgvDtls
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim dataGridViewCellEventHandler As DataGridViewCellEventHandler = AddressOf Me.dgvDtls_CellDoubleClick
				Dim dataGridView As DataGridView = Me._dgvDtls
				If dataGridView IsNot Nothing Then
					RemoveHandler dataGridView.CellDoubleClick, dataGridViewCellEventHandler
				End If
				Me._dgvDtls = value
				dataGridView = Me._dgvDtls
				If dataGridView IsNot Nothing Then
					AddHandler dataGridView.CellDoubleClick, dataGridViewCellEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000283 RID: 643
		' (get) Token: 0x0600069E RID: 1694 RVA: 0x00040823 File Offset: 0x0003EA23
		' (set) Token: 0x0600069F RID: 1695 RVA: 0x00040830 File Offset: 0x0003EA30
		Friend Overridable Property llbAdd As LinkLabel
			<CompilerGenerated()>
			Get
				Return Me._llbAdd
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim linkLabelLinkClickedEventHandler As LinkLabelLinkClickedEventHandler = AddressOf Me.llbAdd_LinkClicked
				Dim linkLabel As LinkLabel = Me._llbAdd
				If linkLabel IsNot Nothing Then
					RemoveHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
				Me._llbAdd = value
				linkLabel = Me._llbAdd
				If linkLabel IsNot Nothing Then
					AddHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000284 RID: 644
		' (get) Token: 0x060006A0 RID: 1696 RVA: 0x00040873 File Offset: 0x0003EA73
		' (set) Token: 0x060006A1 RID: 1697 RVA: 0x0004087D File Offset: 0x0003EA7D
		Friend Overridable Property tpDoc As TabPage

		' Token: 0x17000285 RID: 645
		' (get) Token: 0x060006A2 RID: 1698 RVA: 0x00040886 File Offset: 0x0003EA86
		' (set) Token: 0x060006A3 RID: 1699 RVA: 0x00040890 File Offset: 0x0003EA90
		Friend Overridable Property llbFile As LinkLabel
			<CompilerGenerated()>
			Get
				Return Me._llbFile
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim linkLabelLinkClickedEventHandler As LinkLabelLinkClickedEventHandler = AddressOf Me.lblFile_LinkClicked
				Dim linkLabel As LinkLabel = Me._llbFile
				If linkLabel IsNot Nothing Then
					RemoveHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
				Me._llbFile = value
				linkLabel = Me._llbFile
				If linkLabel IsNot Nothing Then
					AddHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000286 RID: 646
		' (get) Token: 0x060006A4 RID: 1700 RVA: 0x000408D3 File Offset: 0x0003EAD3
		' (set) Token: 0x060006A5 RID: 1701 RVA: 0x000408E0 File Offset: 0x0003EAE0
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

		' Token: 0x17000287 RID: 647
		' (get) Token: 0x060006A6 RID: 1702 RVA: 0x00040923 File Offset: 0x0003EB23
		' (set) Token: 0x060006A7 RID: 1703 RVA: 0x0004092D File Offset: 0x0003EB2D
		Friend Overridable Property chkIsActive As CheckBox

		' Token: 0x17000288 RID: 648
		' (get) Token: 0x060006A8 RID: 1704 RVA: 0x00040936 File Offset: 0x0003EB36
		' (set) Token: 0x060006A9 RID: 1705 RVA: 0x00040940 File Offset: 0x0003EB40
		Friend Overridable Property txtID As TextBox

		' Token: 0x17000289 RID: 649
		' (get) Token: 0x060006AA RID: 1706 RVA: 0x00040949 File Offset: 0x0003EB49
		' (set) Token: 0x060006AB RID: 1707 RVA: 0x00040954 File Offset: 0x0003EB54
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

		' Token: 0x1700028A RID: 650
		' (get) Token: 0x060006AC RID: 1708 RVA: 0x00040997 File Offset: 0x0003EB97
		' (set) Token: 0x060006AD RID: 1709 RVA: 0x000409A4 File Offset: 0x0003EBA4
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

		' Token: 0x1700028B RID: 651
		' (get) Token: 0x060006AE RID: 1710 RVA: 0x000409E7 File Offset: 0x0003EBE7
		' (set) Token: 0x060006AF RID: 1711 RVA: 0x000409F4 File Offset: 0x0003EBF4
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

		' Token: 0x1700028C RID: 652
		' (get) Token: 0x060006B0 RID: 1712 RVA: 0x00040A37 File Offset: 0x0003EC37
		' (set) Token: 0x060006B1 RID: 1713 RVA: 0x00040A44 File Offset: 0x0003EC44
		Friend Overridable Property btnEdit As Button
			<CompilerGenerated()>
			Get
				Return Me._btnEdit
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnEdit_Click
				Dim button As Button = Me._btnEdit
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnEdit = value
				button = Me._btnEdit
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700028D RID: 653
		' (get) Token: 0x060006B2 RID: 1714 RVA: 0x00040A87 File Offset: 0x0003EC87
		' (set) Token: 0x060006B3 RID: 1715 RVA: 0x00040A94 File Offset: 0x0003EC94
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

		' Token: 0x1700028E RID: 654
		' (get) Token: 0x060006B4 RID: 1716 RVA: 0x00040AD7 File Offset: 0x0003ECD7
		' (set) Token: 0x060006B5 RID: 1717 RVA: 0x00040AE1 File Offset: 0x0003ECE1
		Friend Overridable Property tab_lblDetails As Label

		' Token: 0x1700028F RID: 655
		' (get) Token: 0x060006B6 RID: 1718 RVA: 0x00040AEA File Offset: 0x0003ECEA
		' (set) Token: 0x060006B7 RID: 1719 RVA: 0x00040AF4 File Offset: 0x0003ECF4
		Friend Overridable Property tpList As TabPage

		' Token: 0x17000290 RID: 656
		' (get) Token: 0x060006B8 RID: 1720 RVA: 0x00040AFD File Offset: 0x0003ECFD
		' (set) Token: 0x060006B9 RID: 1721 RVA: 0x00040B07 File Offset: 0x0003ED07
		Friend Overridable Property Panel2 As Panel

		' Token: 0x17000291 RID: 657
		' (get) Token: 0x060006BA RID: 1722 RVA: 0x00040B10 File Offset: 0x0003ED10
		' (set) Token: 0x060006BB RID: 1723 RVA: 0x00040B1C File Offset: 0x0003ED1C
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

		' Token: 0x17000292 RID: 658
		' (get) Token: 0x060006BC RID: 1724 RVA: 0x00040B5F File Offset: 0x0003ED5F
		' (set) Token: 0x060006BD RID: 1725 RVA: 0x00040B69 File Offset: 0x0003ED69
		Friend Overridable Property grpListButton As GroupBox

		' Token: 0x17000293 RID: 659
		' (get) Token: 0x060006BE RID: 1726 RVA: 0x00040B72 File Offset: 0x0003ED72
		' (set) Token: 0x060006BF RID: 1727 RVA: 0x00040B7C File Offset: 0x0003ED7C
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x17000294 RID: 660
		' (get) Token: 0x060006C0 RID: 1728 RVA: 0x00040B85 File Offset: 0x0003ED85
		' (set) Token: 0x060006C1 RID: 1729 RVA: 0x00040B90 File Offset: 0x0003ED90
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

		' Token: 0x17000295 RID: 661
		' (get) Token: 0x060006C2 RID: 1730 RVA: 0x00040BD3 File Offset: 0x0003EDD3
		' (set) Token: 0x060006C3 RID: 1731 RVA: 0x00040BE0 File Offset: 0x0003EDE0
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

		' Token: 0x17000296 RID: 662
		' (get) Token: 0x060006C4 RID: 1732 RVA: 0x00040C23 File Offset: 0x0003EE23
		' (set) Token: 0x060006C5 RID: 1733 RVA: 0x00040C30 File Offset: 0x0003EE30
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

		' Token: 0x17000297 RID: 663
		' (get) Token: 0x060006C6 RID: 1734 RVA: 0x00040C73 File Offset: 0x0003EE73
		' (set) Token: 0x060006C7 RID: 1735 RVA: 0x00040C7D File Offset: 0x0003EE7D
		Friend Overridable Property lblRows As Label

		' Token: 0x17000298 RID: 664
		' (get) Token: 0x060006C8 RID: 1736 RVA: 0x00040C86 File Offset: 0x0003EE86
		' (set) Token: 0x060006C9 RID: 1737 RVA: 0x00040C90 File Offset: 0x0003EE90
		Friend Overridable Property GbAdvanced As GroupBox

		' Token: 0x17000299 RID: 665
		' (get) Token: 0x060006CA RID: 1738 RVA: 0x00040C99 File Offset: 0x0003EE99
		' (set) Token: 0x060006CB RID: 1739 RVA: 0x00040CA3 File Offset: 0x0003EEA3
		Friend Overridable Property cmbSCurrency As ComboBox

		' Token: 0x1700029A RID: 666
		' (get) Token: 0x060006CC RID: 1740 RVA: 0x00040CAC File Offset: 0x0003EEAC
		' (set) Token: 0x060006CD RID: 1741 RVA: 0x00040CB6 File Offset: 0x0003EEB6
		Friend Overridable Property Label5 As Label

		' Token: 0x1700029B RID: 667
		' (get) Token: 0x060006CE RID: 1742 RVA: 0x00040CBF File Offset: 0x0003EEBF
		' (set) Token: 0x060006CF RID: 1743 RVA: 0x00040CC9 File Offset: 0x0003EEC9
		Friend Overridable Property txtSCreated As TextBox

		' Token: 0x1700029C RID: 668
		' (get) Token: 0x060006D0 RID: 1744 RVA: 0x00040CD2 File Offset: 0x0003EED2
		' (set) Token: 0x060006D1 RID: 1745 RVA: 0x00040CDC File Offset: 0x0003EEDC
		Friend Overridable Property lblSCreated As ComboBox

		' Token: 0x1700029D RID: 669
		' (get) Token: 0x060006D2 RID: 1746 RVA: 0x00040CE5 File Offset: 0x0003EEE5
		' (set) Token: 0x060006D3 RID: 1747 RVA: 0x00040CEF File Offset: 0x0003EEEF
		Friend Overridable Property dtpFrom As DateTimePicker

		' Token: 0x1700029E RID: 670
		' (get) Token: 0x060006D4 RID: 1748 RVA: 0x00040CF8 File Offset: 0x0003EEF8
		' (set) Token: 0x060006D5 RID: 1749 RVA: 0x00040D02 File Offset: 0x0003EF02
		Friend Overridable Property dtpTo As DateTimePicker

		' Token: 0x1700029F RID: 671
		' (get) Token: 0x060006D6 RID: 1750 RVA: 0x00040D0B File Offset: 0x0003EF0B
		' (set) Token: 0x060006D7 RID: 1751 RVA: 0x00040D15 File Offset: 0x0003EF15
		Friend Overridable Property Label16 As Label

		' Token: 0x170002A0 RID: 672
		' (get) Token: 0x060006D8 RID: 1752 RVA: 0x00040D1E File Offset: 0x0003EF1E
		' (set) Token: 0x060006D9 RID: 1753 RVA: 0x00040D28 File Offset: 0x0003EF28
		Friend Overridable Property lblSDate As ComboBox

		' Token: 0x170002A1 RID: 673
		' (get) Token: 0x060006DA RID: 1754 RVA: 0x00040D31 File Offset: 0x0003EF31
		' (set) Token: 0x060006DB RID: 1755 RVA: 0x00040D3B File Offset: 0x0003EF3B
		Friend Overridable Property cmbSPlant As ComboBox

		' Token: 0x170002A2 RID: 674
		' (get) Token: 0x060006DC RID: 1756 RVA: 0x00040D44 File Offset: 0x0003EF44
		' (set) Token: 0x060006DD RID: 1757 RVA: 0x00040D4E File Offset: 0x0003EF4E
		Friend Overridable Property cmbStatus As ComboBox

		' Token: 0x170002A3 RID: 675
		' (get) Token: 0x060006DE RID: 1758 RVA: 0x00040D57 File Offset: 0x0003EF57
		' (set) Token: 0x060006DF RID: 1759 RVA: 0x00040D61 File Offset: 0x0003EF61
		Friend Overridable Property Label11 As Label

		' Token: 0x170002A4 RID: 676
		' (get) Token: 0x060006E0 RID: 1760 RVA: 0x00040D6A File Offset: 0x0003EF6A
		' (set) Token: 0x060006E1 RID: 1761 RVA: 0x00040D74 File Offset: 0x0003EF74
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

		' Token: 0x170002A5 RID: 677
		' (get) Token: 0x060006E2 RID: 1762 RVA: 0x00040DB7 File Offset: 0x0003EFB7
		' (set) Token: 0x060006E3 RID: 1763 RVA: 0x00040DC1 File Offset: 0x0003EFC1
		Friend Overridable Property GbBasic As GroupBox

		' Token: 0x170002A6 RID: 678
		' (get) Token: 0x060006E4 RID: 1764 RVA: 0x00040DCA File Offset: 0x0003EFCA
		' (set) Token: 0x060006E5 RID: 1765 RVA: 0x00040DD4 File Offset: 0x0003EFD4
		Friend Overridable Property txtSName As TextBox

		' Token: 0x170002A7 RID: 679
		' (get) Token: 0x060006E6 RID: 1766 RVA: 0x00040DDD File Offset: 0x0003EFDD
		' (set) Token: 0x060006E7 RID: 1767 RVA: 0x00040DE7 File Offset: 0x0003EFE7
		Friend Overridable Property txtSLOB As TextBox

		' Token: 0x170002A8 RID: 680
		' (get) Token: 0x060006E8 RID: 1768 RVA: 0x00040DF0 File Offset: 0x0003EFF0
		' (set) Token: 0x060006E9 RID: 1769 RVA: 0x00040DFA File Offset: 0x0003EFFA
		Friend Overridable Property Label7 As Label

		' Token: 0x170002A9 RID: 681
		' (get) Token: 0x060006EA RID: 1770 RVA: 0x00040E03 File Offset: 0x0003F003
		' (set) Token: 0x060006EB RID: 1771 RVA: 0x00040E0D File Offset: 0x0003F00D
		Friend Overridable Property Label10 As Label

		' Token: 0x170002AA RID: 682
		' (get) Token: 0x060006EC RID: 1772 RVA: 0x00040E16 File Offset: 0x0003F016
		' (set) Token: 0x060006ED RID: 1773 RVA: 0x00040E20 File Offset: 0x0003F020
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

		' Token: 0x170002AB RID: 683
		' (get) Token: 0x060006EE RID: 1774 RVA: 0x00040E63 File Offset: 0x0003F063
		' (set) Token: 0x060006EF RID: 1775 RVA: 0x00040E6D File Offset: 0x0003F06D
		Friend Overridable Property tab_lblList As Label

		' Token: 0x170002AC RID: 684
		' (get) Token: 0x060006F0 RID: 1776 RVA: 0x00040E76 File Offset: 0x0003F076
		' (set) Token: 0x060006F1 RID: 1777 RVA: 0x00040E80 File Offset: 0x0003F080
		Friend Overridable Property AddressType As DataGridViewTextBoxColumn

		' Token: 0x170002AD RID: 685
		' (get) Token: 0x060006F2 RID: 1778 RVA: 0x00040E89 File Offset: 0x0003F089
		' (set) Token: 0x060006F3 RID: 1779 RVA: 0x00040E93 File Offset: 0x0003F093
		Friend Overridable Property Address As DataGridViewTextBoxColumn

		' Token: 0x170002AE RID: 686
		' (get) Token: 0x060006F4 RID: 1780 RVA: 0x00040E9C File Offset: 0x0003F09C
		' (set) Token: 0x060006F5 RID: 1781 RVA: 0x00040EA6 File Offset: 0x0003F0A6
		Friend Overridable Property City As DataGridViewTextBoxColumn

		' Token: 0x170002AF RID: 687
		' (get) Token: 0x060006F6 RID: 1782 RVA: 0x00040EAF File Offset: 0x0003F0AF
		' (set) Token: 0x060006F7 RID: 1783 RVA: 0x00040EB9 File Offset: 0x0003F0B9
		Friend Overridable Property PinCode As DataGridViewTextBoxColumn

		' Token: 0x170002B0 RID: 688
		' (get) Token: 0x060006F8 RID: 1784 RVA: 0x00040EC2 File Offset: 0x0003F0C2
		' (set) Token: 0x060006F9 RID: 1785 RVA: 0x00040ECC File Offset: 0x0003F0CC
		Friend Overridable Property State As DataGridViewTextBoxColumn

		' Token: 0x170002B1 RID: 689
		' (get) Token: 0x060006FA RID: 1786 RVA: 0x00040ED5 File Offset: 0x0003F0D5
		' (set) Token: 0x060006FB RID: 1787 RVA: 0x00040EDF File Offset: 0x0003F0DF
		Friend Overridable Property PANNo As DataGridViewTextBoxColumn

		' Token: 0x170002B2 RID: 690
		' (get) Token: 0x060006FC RID: 1788 RVA: 0x00040EE8 File Offset: 0x0003F0E8
		' (set) Token: 0x060006FD RID: 1789 RVA: 0x00040EF2 File Offset: 0x0003F0F2
		Friend Overridable Property ContactName As DataGridViewTextBoxColumn

		' Token: 0x170002B3 RID: 691
		' (get) Token: 0x060006FE RID: 1790 RVA: 0x00040EFB File Offset: 0x0003F0FB
		' (set) Token: 0x060006FF RID: 1791 RVA: 0x00040F05 File Offset: 0x0003F105
		Friend Overridable Property LandlineNo As DataGridViewTextBoxColumn

		' Token: 0x170002B4 RID: 692
		' (get) Token: 0x06000700 RID: 1792 RVA: 0x00040F0E File Offset: 0x0003F10E
		' (set) Token: 0x06000701 RID: 1793 RVA: 0x00040F18 File Offset: 0x0003F118
		Friend Overridable Property CellNo As DataGridViewTextBoxColumn

		' Token: 0x170002B5 RID: 693
		' (get) Token: 0x06000702 RID: 1794 RVA: 0x00040F21 File Offset: 0x0003F121
		' (set) Token: 0x06000703 RID: 1795 RVA: 0x00040F2B File Offset: 0x0003F12B
		Friend Overridable Property EmailAddress As DataGridViewTextBoxColumn

		' Token: 0x170002B6 RID: 694
		' (get) Token: 0x06000704 RID: 1796 RVA: 0x00040F34 File Offset: 0x0003F134
		' (set) Token: 0x06000705 RID: 1797 RVA: 0x00040F3E File Offset: 0x0003F13E
		Friend Overridable Property GSTINRegistration As DataGridViewTextBoxColumn

		' Token: 0x170002B7 RID: 695
		' (get) Token: 0x06000706 RID: 1798 RVA: 0x00040F47 File Offset: 0x0003F147
		' (set) Token: 0x06000707 RID: 1799 RVA: 0x00040F51 File Offset: 0x0003F151
		Friend Overridable Property GSTType As DataGridViewTextBoxColumn

		' Token: 0x170002B8 RID: 696
		' (get) Token: 0x06000708 RID: 1800 RVA: 0x00040F5A File Offset: 0x0003F15A
		' (set) Token: 0x06000709 RID: 1801 RVA: 0x00040F64 File Offset: 0x0003F164
		Friend Overridable Property GSTINNo As DataGridViewTextBoxColumn

		' Token: 0x170002B9 RID: 697
		' (get) Token: 0x0600070A RID: 1802 RVA: 0x00040F6D File Offset: 0x0003F16D
		' (set) Token: 0x0600070B RID: 1803 RVA: 0x00040F77 File Offset: 0x0003F177
		Friend Overridable Property TINNo As DataGridViewTextBoxColumn

		' Token: 0x170002BA RID: 698
		' (get) Token: 0x0600070C RID: 1804 RVA: 0x00040F80 File Offset: 0x0003F180
		' (set) Token: 0x0600070D RID: 1805 RVA: 0x00040F8A File Offset: 0x0003F18A
		Friend Overridable Property VendorDtlsID As DataGridViewTextBoxColumn

		' Token: 0x170002BB RID: 699
		' (get) Token: 0x0600070E RID: 1806 RVA: 0x00040F93 File Offset: 0x0003F193
		' (set) Token: 0x0600070F RID: 1807 RVA: 0x00040F9D File Offset: 0x0003F19D
		Friend Overridable Property VendorID As DataGridViewTextBoxColumn

		' Token: 0x170002BC RID: 700
		' (get) Token: 0x06000710 RID: 1808 RVA: 0x00040FA6 File Offset: 0x0003F1A6
		' (set) Token: 0x06000711 RID: 1809 RVA: 0x00040FB0 File Offset: 0x0003F1B0
		Friend Overridable Property Label2 As Label

		' Token: 0x170002BD RID: 701
		' (get) Token: 0x06000712 RID: 1810 RVA: 0x00040FB9 File Offset: 0x0003F1B9
		' (set) Token: 0x06000713 RID: 1811 RVA: 0x00040FC3 File Offset: 0x0003F1C3
		Friend Overridable Property Label4 As Label

		' Token: 0x170002BE RID: 702
		' (get) Token: 0x06000714 RID: 1812 RVA: 0x00040FCC File Offset: 0x0003F1CC
		' (set) Token: 0x06000715 RID: 1813 RVA: 0x00040FD6 File Offset: 0x0003F1D6
		Friend Overridable Property txtName As TextBox

		' Token: 0x170002BF RID: 703
		' (get) Token: 0x06000716 RID: 1814 RVA: 0x00040FDF File Offset: 0x0003F1DF
		' (set) Token: 0x06000717 RID: 1815 RVA: 0x00040FE9 File Offset: 0x0003F1E9
		Friend Overridable Property Label1 As Label

		' Token: 0x170002C0 RID: 704
		' (get) Token: 0x06000718 RID: 1816 RVA: 0x00040FF2 File Offset: 0x0003F1F2
		' (set) Token: 0x06000719 RID: 1817 RVA: 0x00040FFC File Offset: 0x0003F1FC
		Friend Overridable Property cmbLineOfBusiness As ComboBox

		' Token: 0x170002C1 RID: 705
		' (get) Token: 0x0600071A RID: 1818 RVA: 0x00041005 File Offset: 0x0003F205
		' (set) Token: 0x0600071B RID: 1819 RVA: 0x0004100F File Offset: 0x0003F20F
		Friend Overridable Property cmbMSMERegistration As ComboBox

		' Token: 0x170002C2 RID: 706
		' (get) Token: 0x0600071C RID: 1820 RVA: 0x00041018 File Offset: 0x0003F218
		' (set) Token: 0x0600071D RID: 1821 RVA: 0x00041022 File Offset: 0x0003F222
		Friend Overridable Property Label44 As Label

		' Token: 0x170002C3 RID: 707
		' (get) Token: 0x0600071E RID: 1822 RVA: 0x0004102B File Offset: 0x0003F22B
		' (set) Token: 0x0600071F RID: 1823 RVA: 0x00041035 File Offset: 0x0003F235
		Friend Overridable Property Label47 As Label

		' Token: 0x170002C4 RID: 708
		' (get) Token: 0x06000720 RID: 1824 RVA: 0x0004103E File Offset: 0x0003F23E
		' (set) Token: 0x06000721 RID: 1825 RVA: 0x00041048 File Offset: 0x0003F248
		Friend Overridable Property txtWebAddress As TextBox

		' Token: 0x170002C5 RID: 709
		' (get) Token: 0x06000722 RID: 1826 RVA: 0x00041051 File Offset: 0x0003F251
		' (set) Token: 0x06000723 RID: 1827 RVA: 0x0004105B File Offset: 0x0003F25B
		Friend Overridable Property Label22 As Label

		' Token: 0x170002C6 RID: 710
		' (get) Token: 0x06000724 RID: 1828 RVA: 0x00041064 File Offset: 0x0003F264
		' (set) Token: 0x06000725 RID: 1829 RVA: 0x0004106E File Offset: 0x0003F26E
		Friend Overridable Property Label41 As Label

		' Token: 0x170002C7 RID: 711
		' (get) Token: 0x06000726 RID: 1830 RVA: 0x00041077 File Offset: 0x0003F277
		' (set) Token: 0x06000727 RID: 1831 RVA: 0x00041081 File Offset: 0x0003F281
		Friend Overridable Property cmbBankType As ComboBox

		' Token: 0x170002C8 RID: 712
		' (get) Token: 0x06000728 RID: 1832 RVA: 0x0004108A File Offset: 0x0003F28A
		' (set) Token: 0x06000729 RID: 1833 RVA: 0x00041094 File Offset: 0x0003F294
		Friend Overridable Property txtSWIFTCode As TextBox

		' Token: 0x170002C9 RID: 713
		' (get) Token: 0x0600072A RID: 1834 RVA: 0x0004109D File Offset: 0x0003F29D
		' (set) Token: 0x0600072B RID: 1835 RVA: 0x000410A7 File Offset: 0x0003F2A7
		Friend Overridable Property cmbCurrency As ComboBox

		' Token: 0x170002CA RID: 714
		' (get) Token: 0x0600072C RID: 1836 RVA: 0x000410B0 File Offset: 0x0003F2B0
		' (set) Token: 0x0600072D RID: 1837 RVA: 0x000410BA File Offset: 0x0003F2BA
		Friend Overridable Property txtBankSortCode As TextBox

		' Token: 0x170002CB RID: 715
		' (get) Token: 0x0600072E RID: 1838 RVA: 0x000410C3 File Offset: 0x0003F2C3
		' (set) Token: 0x0600072F RID: 1839 RVA: 0x000410CD File Offset: 0x0003F2CD
		Friend Overridable Property txtBankRoutingNo As TextBox

		' Token: 0x170002CC RID: 716
		' (get) Token: 0x06000730 RID: 1840 RVA: 0x000410D6 File Offset: 0x0003F2D6
		' (set) Token: 0x06000731 RID: 1841 RVA: 0x000410E0 File Offset: 0x0003F2E0
		Friend Overridable Property txtIBANNo As TextBox

		' Token: 0x170002CD RID: 717
		' (get) Token: 0x06000732 RID: 1842 RVA: 0x000410E9 File Offset: 0x0003F2E9
		' (set) Token: 0x06000733 RID: 1843 RVA: 0x000410F3 File Offset: 0x0003F2F3
		Friend Overridable Property Label23 As Label

		' Token: 0x170002CE RID: 718
		' (get) Token: 0x06000734 RID: 1844 RVA: 0x000410FC File Offset: 0x0003F2FC
		' (set) Token: 0x06000735 RID: 1845 RVA: 0x00041106 File Offset: 0x0003F306
		Friend Overridable Property Label24 As Label

		' Token: 0x170002CF RID: 719
		' (get) Token: 0x06000736 RID: 1846 RVA: 0x0004110F File Offset: 0x0003F30F
		' (set) Token: 0x06000737 RID: 1847 RVA: 0x00041119 File Offset: 0x0003F319
		Friend Overridable Property Label25 As Label

		' Token: 0x170002D0 RID: 720
		' (get) Token: 0x06000738 RID: 1848 RVA: 0x00041122 File Offset: 0x0003F322
		' (set) Token: 0x06000739 RID: 1849 RVA: 0x0004112C File Offset: 0x0003F32C
		Friend Overridable Property Label26 As Label

		' Token: 0x170002D1 RID: 721
		' (get) Token: 0x0600073A RID: 1850 RVA: 0x00041135 File Offset: 0x0003F335
		' (set) Token: 0x0600073B RID: 1851 RVA: 0x0004113F File Offset: 0x0003F33F
		Friend Overridable Property Label27 As Label

		' Token: 0x170002D2 RID: 722
		' (get) Token: 0x0600073C RID: 1852 RVA: 0x00041148 File Offset: 0x0003F348
		' (set) Token: 0x0600073D RID: 1853 RVA: 0x00041152 File Offset: 0x0003F352
		Friend Overridable Property txtIFSCCode As TextBox

		' Token: 0x170002D3 RID: 723
		' (get) Token: 0x0600073E RID: 1854 RVA: 0x0004115B File Offset: 0x0003F35B
		' (set) Token: 0x0600073F RID: 1855 RVA: 0x00041165 File Offset: 0x0003F365
		Friend Overridable Property Label28 As Label

		' Token: 0x170002D4 RID: 724
		' (get) Token: 0x06000740 RID: 1856 RVA: 0x0004116E File Offset: 0x0003F36E
		' (set) Token: 0x06000741 RID: 1857 RVA: 0x00041178 File Offset: 0x0003F378
		Friend Overridable Property txtAccountNo As TextBox

		' Token: 0x170002D5 RID: 725
		' (get) Token: 0x06000742 RID: 1858 RVA: 0x00041181 File Offset: 0x0003F381
		' (set) Token: 0x06000743 RID: 1859 RVA: 0x0004118B File Offset: 0x0003F38B
		Friend Overridable Property txtBankAddress As TextBox

		' Token: 0x170002D6 RID: 726
		' (get) Token: 0x06000744 RID: 1860 RVA: 0x00041194 File Offset: 0x0003F394
		' (set) Token: 0x06000745 RID: 1861 RVA: 0x0004119E File Offset: 0x0003F39E
		Friend Overridable Property Label29 As Label

		' Token: 0x170002D7 RID: 727
		' (get) Token: 0x06000746 RID: 1862 RVA: 0x000411A7 File Offset: 0x0003F3A7
		' (set) Token: 0x06000747 RID: 1863 RVA: 0x000411B1 File Offset: 0x0003F3B1
		Friend Overridable Property Label30 As Label

		' Token: 0x170002D8 RID: 728
		' (get) Token: 0x06000748 RID: 1864 RVA: 0x000411BA File Offset: 0x0003F3BA
		' (set) Token: 0x06000749 RID: 1865 RVA: 0x000411C4 File Offset: 0x0003F3C4
		Friend Overridable Property txtBankName As TextBox

		' Token: 0x170002D9 RID: 729
		' (get) Token: 0x0600074A RID: 1866 RVA: 0x000411CD File Offset: 0x0003F3CD
		' (set) Token: 0x0600074B RID: 1867 RVA: 0x000411D7 File Offset: 0x0003F3D7
		Friend Overridable Property txtCode As TextBox

		' Token: 0x170002DA RID: 730
		' (get) Token: 0x0600074C RID: 1868 RVA: 0x000411E0 File Offset: 0x0003F3E0
		' (set) Token: 0x0600074D RID: 1869 RVA: 0x000411EA File Offset: 0x0003F3EA
		Friend Overridable Property Label55 As Label

		' Token: 0x170002DB RID: 731
		' (get) Token: 0x0600074E RID: 1870 RVA: 0x000411F3 File Offset: 0x0003F3F3
		' (set) Token: 0x0600074F RID: 1871 RVA: 0x000411FD File Offset: 0x0003F3FD
		Friend Overridable Property Label3 As Label

		' Token: 0x170002DC RID: 732
		' (get) Token: 0x06000750 RID: 1872 RVA: 0x00041206 File Offset: 0x0003F406
		' (set) Token: 0x06000751 RID: 1873 RVA: 0x00041210 File Offset: 0x0003F410
		Friend Overridable Property FileID As DataGridViewTextBoxColumn

		' Token: 0x170002DD RID: 733
		' (get) Token: 0x06000752 RID: 1874 RVA: 0x00041219 File Offset: 0x0003F419
		' (set) Token: 0x06000753 RID: 1875 RVA: 0x00041223 File Offset: 0x0003F423
		Friend Overridable Property btnDownload_File As DataGridViewImageColumn

		' Token: 0x170002DE RID: 734
		' (get) Token: 0x06000754 RID: 1876 RVA: 0x0004122C File Offset: 0x0003F42C
		' (set) Token: 0x06000755 RID: 1877 RVA: 0x00041236 File Offset: 0x0003F436
		Friend Overridable Property FileName As DataGridViewTextBoxColumn

		' Token: 0x170002DF RID: 735
		' (get) Token: 0x06000756 RID: 1878 RVA: 0x0004123F File Offset: 0x0003F43F
		' (set) Token: 0x06000757 RID: 1879 RVA: 0x00041249 File Offset: 0x0003F449
		Friend Overridable Property btnDelete_File As DataGridViewImageColumn

		' Token: 0x06000758 RID: 1880 RVA: 0x00041254 File Offset: 0x0003F454
		Public Sub New()
			AddHandler MyBase.Shown, AddressOf Me.Me_Shown
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.InitializeComponent()
			Me.pnlBasicDefaultHeight = Me.GbBasic.Height
			Me.pnlBasicSetHeight = 23
			Me.pnlAdvDefaultHeight = 23
			Me.pnlAdvSetHeight = Me.GbAdvanced.Height
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
		End Sub

		' Token: 0x06000759 RID: 1881 RVA: 0x000412FD File Offset: 0x0003F4FD
		Private Sub SetSearchPanel()
			Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
			Me.GbBasic.Height = Me.pnlBasicDefaultHeight
		End Sub

		' Token: 0x0600075A RID: 1882 RVA: 0x00041324 File Offset: 0x0003F524
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

		' Token: 0x0600075B RID: 1883 RVA: 0x00041394 File Offset: 0x0003F594
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

		' Token: 0x0600075C RID: 1884 RVA: 0x00041404 File Offset: 0x0003F604
		Private Sub Me_Shown(sender As Object, e As EventArgs)
			Me.SetTabs()
		End Sub

		' Token: 0x0600075D RID: 1885 RVA: 0x00041410 File Offset: 0x0003F610
		Private Sub SetTabs()
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = CInt(Math.Round(CDbl((Me.theme_tc.Width - 4)) / 2.0))
			Me.theme_tc.ItemSize = New Size(num, 30)
			Me.tab_lblDetails.Width = num
			Me.tab_lblList.Width = num + 3
			Me.tab_lblDetails.Location = New Point(0, 0)
			Me.tab_lblList.Location = New Point(num - 4, 0)
		End Sub

		' Token: 0x0600075E RID: 1886 RVA: 0x00041498 File Offset: 0x0003F698
		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = (Operators.CompareString(Me.sStatus, "LOAD", False) = 0) Or (Operators.CompareString(Me.sStatus, "VIEW", False) = 0) Or (Operators.CompareString(Me.sStatus, "SAVE", False) = 0)
			If flag Then
				Dim flag2 As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
				If Not flag2 Then
					e.Cancel = True
				End If
			Else
				CustomMsgBox.Show("Data Not Save..!", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				e.Cancel = True
			End If
		End Sub

		' Token: 0x0600075F RID: 1887 RVA: 0x00041530 File Offset: 0x0003F730
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Designing.SetTheme(Me)
			Me.SetSearchPanel()
			Me.ClearForm()
			Me.ClearList()
			Me.FillCombo()
			Me.SetAccess("DISABLE")
			Me.sStatus = "LOAD"
			Me.SetButtonStatus()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x06000760 RID: 1888 RVA: 0x00041598 File Offset: 0x0003F798
		Private Sub FillCombo()
			Dim text As String = "SELECT DISTINCT LineOfBusiness FROM Vendor ORDER BY LineOfBusiness"
			Dim data As DataTable = MainModule.GetData(text)
			Me.cmbLineOfBusiness.ValueMember = "LineOfBusiness"
			Me.cmbLineOfBusiness.DisplayMember = "LineOfBusiness"
			Me.cmbLineOfBusiness.DataSource = data
			Me.cmbLineOfBusiness.Text = ""
		End Sub

		' Token: 0x06000761 RID: 1889 RVA: 0x000415F4 File Offset: 0x0003F7F4
		Private Sub SetAccess(sAccess As String)
			If Operators.CompareString(sAccess, "ENABLE", False) <> 0 Then
				If Operators.CompareString(sAccess, "DISABLE", False) = 0 Then
					Me.txtID.[ReadOnly] = True
					Me.txtCode.[ReadOnly] = True
					Me.txtName.[ReadOnly] = True
					Me.cmbMSMERegistration.Enabled = False
					Me.txtWebAddress.[ReadOnly] = True
					Me.cmbLineOfBusiness.Enabled = False
					Me.cmbCurrency.Enabled = False
					Me.cmbBankType.Enabled = False
					Me.txtBankName.[ReadOnly] = True
					Me.txtBankAddress.[ReadOnly] = True
					Me.txtAccountNo.[ReadOnly] = True
					Me.txtIFSCCode.[ReadOnly] = True
					Me.txtIBANNo.[ReadOnly] = True
					Me.txtBankRoutingNo.[ReadOnly] = True
					Me.txtBankSortCode.[ReadOnly] = True
					Me.txtSWIFTCode.[ReadOnly] = True
					Me.chkIsActive.Enabled = False
				End If
			Else
				Me.txtID.[ReadOnly] = False
				Me.txtCode.[ReadOnly] = False
				Me.txtName.[ReadOnly] = False
				Me.cmbMSMERegistration.Enabled = True
				Me.txtWebAddress.[ReadOnly] = False
				Me.cmbLineOfBusiness.Enabled = True
				Me.cmbCurrency.Enabled = True
				Me.cmbBankType.Enabled = True
				Me.txtBankName.[ReadOnly] = False
				Me.txtBankAddress.[ReadOnly] = False
				Me.txtAccountNo.[ReadOnly] = False
				Me.txtIFSCCode.[ReadOnly] = False
				Me.txtIBANNo.[ReadOnly] = False
				Me.txtBankRoutingNo.[ReadOnly] = False
				Me.txtBankSortCode.[ReadOnly] = False
				Me.txtSWIFTCode.[ReadOnly] = False
				Me.chkIsActive.Enabled = True
			End If
		End Sub

		' Token: 0x06000762 RID: 1890 RVA: 0x000417F0 File Offset: 0x0003F9F0
		Private Sub SetButtonStatus()
			Dim text As String = Me.sStatus
			If Operators.CompareString(text, "ADD", False) <> 0 AndAlso Operators.CompareString(text, "EDIT", False) <> 0 Then
				If Operators.CompareString(text, "LOAD", False) <> 0 Then
					If Operators.CompareString(text, "VIEW", False) <> 0 Then
						If Operators.CompareString(text, "SAVE", False) = 0 Then
							Me.btnAdd.Enabled = True
							Me.btnEdit.Enabled = True
							Me.btnSave.Enabled = False
							Me.btnClear.Enabled = True
							Me.btnClose.Enabled = True
							Me.llbAdd.Enabled = False
							Me.llbFile.Enabled = False
						End If
					Else
						Me.btnAdd.Enabled = False
						Me.btnEdit.Enabled = True
						Me.btnSave.Enabled = False
						Me.btnClear.Enabled = True
						Me.btnClose.Enabled = True
						Me.llbAdd.Enabled = False
						Me.llbFile.Enabled = False
					End If
				Else
					Me.btnAdd.Enabled = True
					Me.btnEdit.Enabled = False
					Me.btnSave.Enabled = False
					Me.btnClear.Enabled = False
					Me.btnClose.Enabled = True
					Me.llbAdd.Enabled = False
					Me.llbFile.Enabled = False
				End If
			Else
				Me.btnAdd.Enabled = False
				Me.btnEdit.Enabled = False
				Me.btnSave.Enabled = True
				Me.btnClear.Enabled = True
				Me.btnClose.Enabled = False
				Me.llbAdd.Enabled = True
				Me.llbFile.Enabled = True
			End If
		End Sub

		' Token: 0x06000763 RID: 1891 RVA: 0x000419DC File Offset: 0x0003FBDC
		Private Sub ClearForm()
			Me.txtID.Text = ""
			Me.txtCode.Text = ""
			Me.txtName.Text = ""
			Me.cmbMSMERegistration.Text = ""
			Me.txtWebAddress.Text = ""
			Me.cmbLineOfBusiness.Text = ""
			Me.cmbCurrency.Text = ""
			Me.cmbBankType.Text = ""
			Me.txtBankName.Text = ""
			Me.txtBankAddress.Text = ""
			Me.txtAccountNo.Text = ""
			Me.txtIFSCCode.Text = ""
			Me.txtIBANNo.Text = ""
			Me.txtBankRoutingNo.Text = ""
			Me.txtBankSortCode.Text = ""
			Me.txtSWIFTCode.Text = ""
			Me.chkIsActive.Checked = False
			Me.FillAddress()
			Me.dtFile = FileAttachments.CreateFileTable()
			FileAttachments.SetFileDatagridview(Me.dtFile, Me.dgvFile)
			Me.SetAccess("DISABLE")
		End Sub

		' Token: 0x06000764 RID: 1892 RVA: 0x00041B38 File Offset: 0x0003FD38
		Private Sub ClearList()
			Me.lblSDate.SelectedIndex = 0
			Me.lblSCreated.SelectedIndex = 0
			Me.txtSName.Text = ""
			Me.txtSCreated.Text = ""
			Me.txtSLOB.Text = ""
			Me.cmbSCurrency.Text = ""
			Me.cmbStatus.SelectedIndex = 0
			Me.dtpFrom.Value = DateAndTime.Now
			Me.dtpTo.Value = DateAndTime.Now
			Me.dtpFrom.Checked = False
			Me.dtpTo.Checked = False
			Me.lblRows.Text = "0 - Rows"
			Me.dgvList.DataSource = Nothing
		End Sub

		' Token: 0x06000765 RID: 1893 RVA: 0x00041C0B File Offset: 0x0003FE0B
		Private Sub btnClear_Click(sender As Object, e As EventArgs)
			Me.ClearForm()
			Me.sStatus = "LOAD"
			Me.SetButtonStatus()
		End Sub

		' Token: 0x06000766 RID: 1894 RVA: 0x00041C27 File Offset: 0x0003FE27
		Private Sub btnClearList_Click(sender As Object, e As EventArgs)
			Me.ClearList()
		End Sub

		' Token: 0x06000767 RID: 1895 RVA: 0x00041C31 File Offset: 0x0003FE31
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06000768 RID: 1896 RVA: 0x00041C3B File Offset: 0x0003FE3B
		Private Sub btnExport_Click(sender As Object, e As EventArgs)
			MainModule.ExportToExcel(Me.dgvList, Me.Text)
		End Sub

		' Token: 0x06000769 RID: 1897 RVA: 0x00041C50 File Offset: 0x0003FE50
		Private Sub btnAdd_Click(sender As Object, e As EventArgs)
			Me.ClearForm()
			Me.SetAccess("ENABLE")
			Me.sStatus = "ADD"
			Me.SetButtonStatus()
			Me.chkIsActive.Checked = True
			Me.txtCode.Focus()
		End Sub

		' Token: 0x0600076A RID: 1898 RVA: 0x00041C9C File Offset: 0x0003FE9C
		Private Sub btnEdit_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				Me.SetAccess("ENABLE")
				Me.sStatus = "EDIT"
				Me.SetButtonStatus()
			End If
		End Sub

		' Token: 0x0600076B RID: 1899 RVA: 0x00041CE8 File Offset: 0x0003FEE8
		Private Sub btnSearch_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SearchData()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x0600076C RID: 1900 RVA: 0x00041D54 File Offset: 0x0003FF54
		Private Sub SearchData()
			Dim text As String = ""
			Dim text2 As String = " SELECT V.VendorID AS ID, V.VendorCode, V.VendorName, V.MSMERegistration, V.WebAddress, " & vbCrLf
			text2 += " V.LineOfBusiness, V.Currency, V.BankType, V.BankName, V.BankAddress, V.AccountNo, " & vbCrLf
			text2 += " V.IFSCCode, V.IBANNo, V.BankRoutingNo, V.BankSortCode, V.SWIFTCode, " & vbCrLf
			text2 += " V.IsActive, V.CreationDt, Created.UserName AS CreatedBy, V.ModificationDt, Modified.UserName AS ModifiedBy" & vbCrLf
			text2 += " FROM Vendor AS V " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Created ON V.CreatedBy = Created.UserID " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Modified ON V.ModifiedBy = Modified.UserID" & vbCrLf
			text2 += " WHERE 1=1" & vbCrLf
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.txtSName.Text), "", False) <> 0
			If flag Then
				text2 = text2 + " And (VendorName Like '%" + Strings.Trim(Me.txtSName.Text) + "%') " & vbCrLf
				text = text + "VendorName LIKE " + Strings.Trim(Me.txtSName.Text) + vbCrLf
			End If
			Dim flag2 As Boolean = Operators.CompareString(Strings.Trim(Me.txtSLOB.Text), "", False) <> 0
			If flag2 Then
				text2 = text2 + " AND (LineOfBusiness LIKE '%" + Strings.Trim(Me.txtSLOB.Text) + "%')" & vbCrLf
				text = text + "LineOfBusiness LIKE " + Strings.Trim(Me.txtSLOB.Text) + vbCrLf
			End If
			Dim flag3 As Boolean = Operators.CompareString(Me.cmbCurrency.Text, "", False) <> 0
			If flag3 Then
				text2 = text2 + " AND (Currency LIKE '%" + Strings.Trim(Me.cmbCurrency.Text) + "%')" & vbCrLf
				text = text + "Currency LIKE " + Strings.Trim(Me.cmbCurrency.Text) + vbCrLf
			End If
			Dim flag4 As Boolean = Me.cmbStatus.SelectedIndex > 0
			If flag4 Then
				Dim flag5 As Boolean = Me.cmbStatus.SelectedIndex = 1
				If flag5 Then
					text2 += " AND (V.IsActive = 1)"
					text += "IsActive = 1" & vbCrLf
				Else
					text2 += " AND (V.IsActive = 0)"
					text += "IsActive = 0" & vbCrLf
				End If
			End If
			Dim flag6 As Boolean = Operators.CompareString(Strings.Trim(Me.txtSCreated.Text), "", False) <> 0
			If flag6 Then
				Dim flag7 As Boolean = Me.lblSCreated.SelectedIndex >= 0
				If flag7 Then
					Dim flag8 As Boolean = Me.lblSCreated.SelectedIndex = 0
					Dim text3 As String
					If flag8 Then
						text3 = "Created"
					Else
						text3 = "Modified"
					End If
					text2 = String.Concat(New String() { text2, " AND ", text3, ".UserName LIKE '%", Strings.Trim(Me.txtSCreated.Text), "%'" })
					text = text + (text3 + "By LIKE " + Strings.Trim(Me.txtSCreated.Text)) + vbCrLf
				End If
			End If
			Dim flag9 As Boolean = Me.lblSDate.SelectedIndex >= 0
			If flag9 Then
				Dim flag10 As Boolean = Me.lblSDate.SelectedIndex = 0
				Dim text4 As String
				If flag10 Then
					text4 = "CreationDt"
				Else
					text4 = "ModificationDt"
				End If
				Dim flag11 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
				If flag11 Then
					text2 = String.Concat(New String() { text2, " AND V.", text4, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
					text = text + String.Concat(New String() { text4, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
				Else
					Dim checked As Boolean = Me.dtpFrom.Checked
					If checked Then
						text2 = String.Concat(New String() { text2, " AND V.", text4, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59"), "'" })
						text = text + String.Concat(New String() { text4, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
					End If
					Dim checked2 As Boolean = Me.dtpTo.Checked
					If checked2 Then
						text2 = String.Concat(New String() { text2, " AND V.", text4, " BETWEEN '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
						text = text + String.Concat(New String() { text4, " BETWEEN  ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
					End If
				End If
			End If
			text2 += " ORDER BY VendorName"
			Dim data As DataTable = MainModule.GetData(text2)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = data
			Me.dgvList.Columns("ID").Visible = False
			Me.dgvList.Columns("VendorCode").Width = 220
			Me.dgvList.Columns("VendorName").Width = 250
			Me.dgvList.Columns("MSMERegistration").Width = 150
			Me.dgvList.Columns("WebAddress").Width = 250
			Me.dgvList.Columns("LineOfBusiness").Width = 140
			Me.dgvList.Columns("Currency").Width = 140
			Me.dgvList.Columns("BankType").Width = 140
			Me.dgvList.Columns("BankName").Width = 250
			Me.dgvList.Columns("BankAddress").Width = 250
			Me.dgvList.Columns("AccountNo").Width = 140
			Me.dgvList.Columns("IFSCCode").Width = 140
			Me.dgvList.Columns("IBANNo").Width = 140
			Me.dgvList.Columns("BankRoutingNo").Width = 140
			Me.dgvList.Columns("BankSortCode").Width = 140
			Me.dgvList.Columns("SWIFTCode").Width = 140
			Me.dgvList.Columns("IsActive").Width = 100
			Me.dgvList.Columns("CreationDt").Width = 170
			Me.dgvList.Columns("CreatedBy").Width = 150
			Me.dgvList.Columns("ModificationDt").Width = 170
			Me.dgvList.Columns("ModifiedBy").Width = 150
			Me.dgvList.Columns("VendorCode").HeaderText = "Vendor Code"
			Me.dgvList.Columns("VendorName").HeaderText = "Vendor Name"
			Me.dgvList.Columns("MSMERegistration").HeaderText = "MSME Registration"
			Me.dgvList.Columns("WebAddress").HeaderText = "Web Address"
			Me.dgvList.Columns("LineOfBusiness").HeaderText = "Line Of Business"
			Me.dgvList.Columns("Currency").HeaderText = "Currency"
			Me.dgvList.Columns("BankType").HeaderText = "Bank Type"
			Me.dgvList.Columns("BankName").HeaderText = "Bank Name"
			Me.dgvList.Columns("BankAddress").HeaderText = "Bank Address"
			Me.dgvList.Columns("AccountNo").HeaderText = "Account No."
			Me.dgvList.Columns("IFSCCode").HeaderText = "IFSC Code"
			Me.dgvList.Columns("IBANNo").HeaderText = "IBAN No."
			Me.dgvList.Columns("BankRoutingNo").HeaderText = "Bank Routing No."
			Me.dgvList.Columns("BankSortCode").HeaderText = "Bank Sort Code"
			Me.dgvList.Columns("SWIFTCode").HeaderText = "SWIFT Code"
			Me.dgvList.Columns("IsActive").HeaderText = "Is Active"
			Me.dgvList.Columns("CreationDt").HeaderText = "Creation Date"
			Me.dgvList.Columns("CreatedBy").HeaderText = "Created By"
			Me.dgvList.Columns("ModificationDt").HeaderText = "Modification Date"
			Me.dgvList.Columns("ModifiedBy").HeaderText = "Modified By"
			Me.dgvList.Columns("CreationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			Me.dgvList.Columns("ModificationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x0600076D RID: 1901 RVA: 0x00042920 File Offset: 0x00040B20
		Private Sub dgvList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = (Operators.CompareString(Me.sStatus, "ADD", False) <> 0) And (Operators.CompareString(Me.sStatus, "EDIT", False) <> 0)
			If flag Then
				Dim flag2 As Boolean = e.RowIndex > -1
				If flag2 Then
					Me.FillData(Me.dgvList.Rows(e.RowIndex).Cells("ID").Value.ToString())
					Me.theme_tc.SelectedTab = Me.tpDetails
					Me.sStatus = "VIEW"
					Me.SetButtonStatus()
					MainModule.TrnLog(Me.Text, "Entry Selected", "Selected ID: " + Me.dgvList.Rows(e.RowIndex).Cells("ID").Value.ToString(), Nothing)
				End If
			End If
		End Sub

		' Token: 0x0600076E RID: 1902 RVA: 0x00042A18 File Offset: 0x00040C18
		Private Sub FillData(sID As String)
			Dim dataTable As DataTable = CType(Me.dgvList.DataSource, DataTable)
			Dim flag As Boolean = (Operators.CompareString(sID, "", False) <> 0) And (dataTable.Rows.Count > 0)
			If flag Then
				Dim flag2 As Boolean = dataTable.[Select]("ID='" + sID + "'").Length > 0
				If flag2 Then
					Dim dataRow As DataRow = dataTable.[Select]("ID='" + sID + "'")(0)
					Me.txtID.Text = dataRow("ID").ToString()
					Me.txtCode.Text = dataRow("VendorCode").ToString()
					Me.txtName.Text = dataRow("VendorName").ToString()
					Me.cmbMSMERegistration.Text = dataRow("MSMERegistration").ToString()
					Me.txtWebAddress.Text = dataRow("WebAddress").ToString()
					Me.cmbLineOfBusiness.Text = dataRow("LineOfBusiness").ToString()
					Me.cmbCurrency.Text = dataRow("Currency").ToString()
					Me.cmbBankType.Text = dataRow("BankType").ToString()
					Me.txtBankName.Text = dataRow("BankName").ToString()
					Me.txtBankAddress.Text = dataRow("BankAddress").ToString()
					Me.txtAccountNo.Text = dataRow("AccountNo").ToString()
					Me.txtIFSCCode.Text = dataRow("IFSCCode").ToString()
					Me.txtIBANNo.Text = dataRow("IBANNo").ToString()
					Me.txtBankRoutingNo.Text = dataRow("BankRoutingNo").ToString()
					Me.txtBankSortCode.Text = dataRow("BankSortCode").ToString()
					Me.txtSWIFTCode.Text = dataRow("SWIFTCode").ToString()
					Dim flag3 As Boolean = Operators.ConditionalCompareObjectEqual(dataRow("IsActive"), True, False)
					If flag3 Then
						Me.chkIsActive.Checked = True
					Else
						Me.chkIsActive.Checked = False
					End If
					Me.FillAddress()
					Me.dtFile = FileAttachments.FillFileAttachments(Me.Text, Me.txtID.Text)
					FileAttachments.SetFileDatagridview(Me.dtFile, Me.dgvFile)
				End If
			End If
		End Sub

		' Token: 0x0600076F RID: 1903 RVA: 0x00042CCC File Offset: 0x00040ECC
		Private Sub FillAddress()
			Dim text As String = " SELECT VendorDtlsID, VendorID, AddressType, Address, City, Pincode, State, PANNo, "
			text += " ContactName, LandlineNo, CellNo, EmailAddress, GSTINRegistration, GSTType, GSTINNo, TINNo"
			text += " FROM VendorDtls"
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				text = text + " WHERE VendorID = '" + Me.txtID.Text + "'"
			Else
				text += " WHERE VendorID = '0'"
			End If
			Me.dtDtls = MainModule.GetData(text)
			Me.dgvDtls.DataSource = Me.dtDtls
		End Sub

		' Token: 0x06000770 RID: 1904 RVA: 0x00042D60 File Offset: 0x00040F60
		Private Sub llbAdd_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Dim vendorAddress As VendorAddress = New VendorAddress(-1, Me.dtDtls)
			Dim flag As Boolean = vendorAddress.ShowDialog() = DialogResult.OK
			If flag Then
				Me.dtDtls = vendorAddress.dtAddress
				Me.dgvDtls.DataSource = Me.dtDtls
			End If
		End Sub

		' Token: 0x06000771 RID: 1905 RVA: 0x00042DA8 File Offset: 0x00040FA8
		Private Sub dgvDtls_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = (e.RowIndex > -1) And (e.ColumnIndex > -1)
			If flag Then
				Dim vendorAddress As VendorAddress = New VendorAddress(e.RowIndex, Me.dtDtls)
				Dim flag2 As Boolean = vendorAddress.ShowDialog() = DialogResult.OK
				If flag2 Then
					Me.dtDtls = vendorAddress.dtAddress
					Me.dgvDtls.DataSource = Me.dtDtls
				End If
			End If
		End Sub

		' Token: 0x06000772 RID: 1906 RVA: 0x00042E0E File Offset: 0x0004100E
		Private Sub lblFile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Me.dtFile = FileAttachments.AttachmentFile(Conversions.ToString(-1), Me.dtFile)
			FileAttachments.SetFileDatagridview(Me.dtFile, Me.dgvFile)
		End Sub

		' Token: 0x06000773 RID: 1907 RVA: 0x00042E3C File Offset: 0x0004103C
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

		' Token: 0x06000774 RID: 1908 RVA: 0x00042F30 File Offset: 0x00041130
		Private Function ValidateForm() As Boolean
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.txtCode.Text), "", False) = 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Enter Vendor Code.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.txtCode.Focus()
				flag2 = False
			Else
				Dim flag3 As Boolean = Operators.CompareString(Strings.Trim(Me.txtName.Text), "", False) = 0
				If flag3 Then
					CustomMsgBox.Show("Enter Vendor Name.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.txtName.Focus()
					flag2 = False
				Else
					Dim text As String = " SELECT VendorID, VendorCode, VendorName FROM Vendor"
					text = String.Concat(New String() { text, " WHERE ((VendorCode = '", Strings.Trim(Me.txtCode.Text), "') OR (VendorName = '", Strings.Trim(Me.txtName.Text), "')) " })
					Dim flag4 As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
					If flag4 Then
						text = text + " AND VendorID <> '" + Me.txtID.Text + "'"
					End If
					Dim data As DataTable = MainModule.GetData(text)
					Dim flag5 As Boolean = data.Rows.Count > 0
					If flag5 Then
						Dim flag6 As Boolean = data.[Select]("VendorCode='" + Strings.Trim(Me.txtCode.Text) + "'").Length > 0
						If flag6 Then
							CustomMsgBox.Show("Vendor Code Already Exists.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.txtCode.Focus()
							Return False
						End If
						Dim flag7 As Boolean = data.[Select]("VendorName='" + Strings.Trim(Me.txtName.Text) + "'").Length > 0
						If flag7 Then
							CustomMsgBox.Show("Vendor Name Already Exists.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.txtName.Focus()
							Return False
						End If
					End If
					flag2 = True
				End If
			End If
			Return flag2
		End Function

		' Token: 0x06000775 RID: 1909 RVA: 0x00043130 File Offset: 0x00041330
		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.Save()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06000776 RID: 1910 RVA: 0x0004319C File Offset: 0x0004139C
		Private Sub Save()
			Dim flag As Boolean = CustomMsgBox.Show("Save..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
			If flag Then
				Dim flag2 As Boolean = Not Me.ValidateForm()
				If Not flag2 Then
					Dim flag3 As Boolean = Operators.CompareString(Me.txtID.Text, "", False) = 0
					If flag3 Then
						Me.InsertData()
						EmailModule.SendMail("Vendor Database", Me.txtID.Text, "Created", "")
					Else
						Me.UpdateData()
						EmailModule.SendMail("Vendor Database", Me.txtID.Text, "Modified", "")
					End If
				End If
			End If
		End Sub

		' Token: 0x06000777 RID: 1911 RVA: 0x00043248 File Offset: 0x00041448
		Private Sub InsertData()
			Dim text As String = " INSERT INTO Vendor (VendorCode, VendorName, MSMERegistration, WebAddress, LineOfBusiness, Currency, " & vbCrLf
			text += " BankType, BankName, BankAddress, AccountNo, IFSCCode, IBANNo, BankRoutingNo, BankSortCode,  " & vbCrLf
			text += " SWIFTCode,  CreationDt, CreatedBy, IsActive)" & vbCrLf
			text = String.Concat(New String() { text, " VALUES ('", Strings.Trim(Me.txtCode.Text), "','", Strings.Trim(Me.txtName.Text), "','", Me.cmbMSMERegistration.Text, "'," & vbCrLf })
			text = String.Concat(New String() { text, " '", Strings.Trim(Me.txtWebAddress.Text), "','", Strings.Trim(Me.cmbLineOfBusiness.Text), "','", Me.cmbCurrency.Text, "'," & vbCrLf })
			text = String.Concat(New String() { text, " '", Me.cmbBankType.Text, "','", Strings.Trim(Me.txtBankName.Text), "','", Strings.Trim(Me.txtBankAddress.Text), "'," & vbCrLf })
			text = String.Concat(New String() { text, " '", Strings.Trim(Me.txtAccountNo.Text), "','", Strings.Trim(Me.txtIFSCCode.Text), "','", Strings.Trim(Me.txtIBANNo.Text), "'," & vbCrLf })
			text = String.Concat(New String() { text, " '", Strings.Trim(Me.txtBankRoutingNo.Text), "','", Strings.Trim(Me.txtBankSortCode.Text), "','", Strings.Trim(Me.txtSWIFTCode.Text), "'," & vbCrLf })
			text = text + " GETDATE(), '" + GlobalVariables.gsUserID + "',"
			Dim checked As Boolean = Me.chkIsActive.Checked
			If checked Then
				text += " 1)" & vbCrLf
			Else
				text += " 0)" & vbCrLf
			End If
			text += " SELECT SCOPE_IDENTITY() AS ID"
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Me.txtID.Text = Conversions.ToString(data.Rows(0)("ID"))
				Me.InsertAddress()
				FileAttachments.InsertFiles("Vendor", Me.txtID.Text, Me.dtFile)
				MainModule.TrnLog(Me.Text, "Created", "New ID: " + Me.txtID.Text, Nothing)
				CustomMsgBox.Show("Vendor Added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Me.SetAccess("DISABLE")
				Me.sStatus = "SAVE"
				Me.SetButtonStatus()
			End If
		End Sub

		' Token: 0x06000778 RID: 1912 RVA: 0x00043580 File Offset: 0x00041780
		Private Sub UpdateData()
			Dim text As String = String.Concat(New String() { " UPDATE Vendor SET VendorCode = '", Strings.Trim(Me.txtCode.Text), "', VendorName = '", Strings.Trim(Me.txtName.Text), "'," })
			text = String.Concat(New String() { text, " MSMERegistration = '", Me.cmbMSMERegistration.Text, "', WebAddress = '", Strings.Trim(Me.txtWebAddress.Text), "', " })
			text = String.Concat(New String() { text, " LineOfBusiness = '", Strings.Trim(Me.cmbLineOfBusiness.Text), "', Currency = '", Me.cmbCurrency.Text, "', " })
			text = String.Concat(New String() { text, " BankType = '", Me.cmbBankType.Text, "', BankName = '", Strings.Trim(Me.txtBankName.Text), "', " })
			text = String.Concat(New String() { text, " BankAddress = '", Strings.Trim(Me.txtBankAddress.Text), "', AccountNo = '", Strings.Trim(Me.txtAccountNo.Text), "', " })
			text = String.Concat(New String() { text, " IFSCCode = '", Strings.Trim(Me.txtIFSCCode.Text), "', IBANNo = '", Strings.Trim(Me.txtIBANNo.Text), "', " })
			text = text + " BankRoutingNo = '" + Strings.Trim(Me.txtBankRoutingNo.Text) + "', "
			text = String.Concat(New String() { text, " BankSortCode = '", Strings.Trim(Me.txtBankSortCode.Text), "', SWIFTCode = '", Strings.Trim(Me.txtSWIFTCode.Text), "', " })
			text = text + " ModificationDt = GETDATE(), ModifiedBy = '" + GlobalVariables.gsUserID + "',"
			Dim checked As Boolean = Me.chkIsActive.Checked
			If checked Then
				text += " IsActive = 1"
			Else
				text += " IsActive = 0"
			End If
			text = text + " WHERE VendorID  = '" + Me.txtID.Text + "'"
			Dim flag As Boolean = MainModule.ExecuteSQL(text) = 1
			If flag Then
				Me.InsertAddress()
				FileAttachments.InsertFiles("Vendor", Me.txtID.Text, Me.dtFile)
				MainModule.TrnLog(Me.Text, "Modified", "Modified ID: " + Me.txtID.Text, Nothing)
				CustomMsgBox.Show("Vendor Modified.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Me.SetAccess("DISABLE")
				Me.sStatus = "SAVE"
				Me.SetButtonStatus()
			End If
		End Sub

		' Token: 0x06000779 RID: 1913 RVA: 0x000438A8 File Offset: 0x00041AA8
		Private Sub InsertAddress()
			Dim flag As Boolean = (Operators.CompareString(Me.txtID.Text, "", False) <> 0) And (Me.dtDtls.Rows.Count > 0)
			If flag Then
				Dim sqlConnection As SqlConnection = New SqlConnection(GlobalVariables.gsConStr)
				sqlConnection.Open()
				Dim sqlTransaction As SqlTransaction = sqlConnection.BeginTransaction(IsolationLevel.Serializable)
				Try
					Dim text As String = "DELETE FROM VendorDtls WHERE VendorID = '" + Me.txtID.Text + "'"
					Dim flag2 As Boolean = MainModule.ExecuteSQL(text, sqlConnection, sqlTransaction) = 1
					If flag2 Then
						Dim dataTable As DataTable = Me.dtDtls.Copy()
						dataTable.Columns.Remove("VendorDtlsID")
						dataTable.Columns.Remove("VendorID")
						Dim dataColumn As DataColumn = New DataColumn("VendorID", GetType(Integer))
						dataColumn.DefaultValue = Me.txtID.Text
						dataTable.Columns.Add(dataColumn)
						MainModule.BulkInsertTemp(dataTable, "VendorDtls", sqlConnection, sqlTransaction)
						sqlTransaction.Commit()
						sqlConnection.Close()
					Else
						sqlTransaction.Rollback()
						sqlConnection.Close()
					End If
				Catch ex As Exception
					sqlTransaction.Rollback()
					sqlConnection.Close()
					CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				End Try
			End If
		End Sub

		' Token: 0x0400031B RID: 795
		Private sStatus As String

		' Token: 0x0400031C RID: 796
		Private dtDtls As DataTable

		' Token: 0x0400031D RID: 797
		Private dtFile As DataTable

		' Token: 0x0400031E RID: 798
		Private pnlBasicDefaultHeight As Integer

		' Token: 0x0400031F RID: 799
		Private pnlBasicSetHeight As Integer

		' Token: 0x04000320 RID: 800
		Private pnlAdvDefaultHeight As Integer

		' Token: 0x04000321 RID: 801
		Private pnlAdvSetHeight As Integer
	End Class
End Namespace
