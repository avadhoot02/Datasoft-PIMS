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
	' Token: 0x02000068 RID: 104
	<DesignerGenerated()>
	Public Partial Class GRNListItem
		Inherits DockContent

		' Token: 0x17000A7A RID: 2682
		' (get) Token: 0x06001AF5 RID: 6901 RVA: 0x000FBA21 File Offset: 0x000F9C21
		' (set) Token: 0x06001AF6 RID: 6902 RVA: 0x000FBA2B File Offset: 0x000F9C2B
		Friend Overridable Property GbBasic As GroupBox

		' Token: 0x17000A7B RID: 2683
		' (get) Token: 0x06001AF7 RID: 6903 RVA: 0x000FBA34 File Offset: 0x000F9C34
		' (set) Token: 0x06001AF8 RID: 6904 RVA: 0x000FBA3E File Offset: 0x000F9C3E
		Friend Overridable Property Label2 As Label

		' Token: 0x17000A7C RID: 2684
		' (get) Token: 0x06001AF9 RID: 6905 RVA: 0x000FBA47 File Offset: 0x000F9C47
		' (set) Token: 0x06001AFA RID: 6906 RVA: 0x000FBA51 File Offset: 0x000F9C51
		Friend Overridable Property txtPONo As TextBox

		' Token: 0x17000A7D RID: 2685
		' (get) Token: 0x06001AFB RID: 6907 RVA: 0x000FBA5A File Offset: 0x000F9C5A
		' (set) Token: 0x06001AFC RID: 6908 RVA: 0x000FBA64 File Offset: 0x000F9C64
		Friend Overridable Property cmbPlant As ComboBox

		' Token: 0x17000A7E RID: 2686
		' (get) Token: 0x06001AFD RID: 6909 RVA: 0x000FBA6D File Offset: 0x000F9C6D
		' (set) Token: 0x06001AFE RID: 6910 RVA: 0x000FBA77 File Offset: 0x000F9C77
		Friend Overridable Property Label1 As Label

		' Token: 0x17000A7F RID: 2687
		' (get) Token: 0x06001AFF RID: 6911 RVA: 0x000FBA80 File Offset: 0x000F9C80
		' (set) Token: 0x06001B00 RID: 6912 RVA: 0x000FBA8A File Offset: 0x000F9C8A
		Friend Overridable Property txtNo As TextBox

		' Token: 0x17000A80 RID: 2688
		' (get) Token: 0x06001B01 RID: 6913 RVA: 0x000FBA93 File Offset: 0x000F9C93
		' (set) Token: 0x06001B02 RID: 6914 RVA: 0x000FBA9D File Offset: 0x000F9C9D
		Friend Overridable Property dtpFrom As DateTimePicker

		' Token: 0x17000A81 RID: 2689
		' (get) Token: 0x06001B03 RID: 6915 RVA: 0x000FBAA6 File Offset: 0x000F9CA6
		' (set) Token: 0x06001B04 RID: 6916 RVA: 0x000FBAB0 File Offset: 0x000F9CB0
		Friend Overridable Property dtpTo As DateTimePicker

		' Token: 0x17000A82 RID: 2690
		' (get) Token: 0x06001B05 RID: 6917 RVA: 0x000FBAB9 File Offset: 0x000F9CB9
		' (set) Token: 0x06001B06 RID: 6918 RVA: 0x000FBAC3 File Offset: 0x000F9CC3
		Friend Overridable Property Label16 As Label

		' Token: 0x17000A83 RID: 2691
		' (get) Token: 0x06001B07 RID: 6919 RVA: 0x000FBACC File Offset: 0x000F9CCC
		' (set) Token: 0x06001B08 RID: 6920 RVA: 0x000FBAD6 File Offset: 0x000F9CD6
		Friend Overridable Property lblDate As ComboBox

		' Token: 0x17000A84 RID: 2692
		' (get) Token: 0x06001B09 RID: 6921 RVA: 0x000FBADF File Offset: 0x000F9CDF
		' (set) Token: 0x06001B0A RID: 6922 RVA: 0x000FBAEC File Offset: 0x000F9CEC
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

		' Token: 0x17000A85 RID: 2693
		' (get) Token: 0x06001B0B RID: 6923 RVA: 0x000FBB2F File Offset: 0x000F9D2F
		' (set) Token: 0x06001B0C RID: 6924 RVA: 0x000FBB39 File Offset: 0x000F9D39
		Friend Overridable Property GbAdvanced As GroupBox

		' Token: 0x17000A86 RID: 2694
		' (get) Token: 0x06001B0D RID: 6925 RVA: 0x000FBB42 File Offset: 0x000F9D42
		' (set) Token: 0x06001B0E RID: 6926 RVA: 0x000FBB4C File Offset: 0x000F9D4C
		Friend Overridable Property txtBatchNo As TextBox

		' Token: 0x17000A87 RID: 2695
		' (get) Token: 0x06001B0F RID: 6927 RVA: 0x000FBB55 File Offset: 0x000F9D55
		' (set) Token: 0x06001B10 RID: 6928 RVA: 0x000FBB5F File Offset: 0x000F9D5F
		Friend Overridable Property lblBatchNo As Label

		' Token: 0x17000A88 RID: 2696
		' (get) Token: 0x06001B11 RID: 6929 RVA: 0x000FBB68 File Offset: 0x000F9D68
		' (set) Token: 0x06001B12 RID: 6930 RVA: 0x000FBB72 File Offset: 0x000F9D72
		Friend Overridable Property cmbItemStatus As ComboBox

		' Token: 0x17000A89 RID: 2697
		' (get) Token: 0x06001B13 RID: 6931 RVA: 0x000FBB7B File Offset: 0x000F9D7B
		' (set) Token: 0x06001B14 RID: 6932 RVA: 0x000FBB85 File Offset: 0x000F9D85
		Friend Overridable Property lblItemStatus As Label

		' Token: 0x17000A8A RID: 2698
		' (get) Token: 0x06001B15 RID: 6933 RVA: 0x000FBB8E File Offset: 0x000F9D8E
		' (set) Token: 0x06001B16 RID: 6934 RVA: 0x000FBB98 File Offset: 0x000F9D98
		Friend Overridable Property pnlItem As Panel

		' Token: 0x17000A8B RID: 2699
		' (get) Token: 0x06001B17 RID: 6935 RVA: 0x000FBBA1 File Offset: 0x000F9DA1
		' (set) Token: 0x06001B18 RID: 6936 RVA: 0x000FBBAB File Offset: 0x000F9DAB
		Friend Overridable Property txtName As TextBox

		' Token: 0x17000A8C RID: 2700
		' (get) Token: 0x06001B19 RID: 6937 RVA: 0x000FBBB4 File Offset: 0x000F9DB4
		' (set) Token: 0x06001B1A RID: 6938 RVA: 0x000FBBBE File Offset: 0x000F9DBE
		Friend Overridable Property txtCatalogNo As TextBox

		' Token: 0x17000A8D RID: 2701
		' (get) Token: 0x06001B1B RID: 6939 RVA: 0x000FBBC7 File Offset: 0x000F9DC7
		' (set) Token: 0x06001B1C RID: 6940 RVA: 0x000FBBD1 File Offset: 0x000F9DD1
		Friend Overridable Property Label14 As Label

		' Token: 0x17000A8E RID: 2702
		' (get) Token: 0x06001B1D RID: 6941 RVA: 0x000FBBDA File Offset: 0x000F9DDA
		' (set) Token: 0x06001B1E RID: 6942 RVA: 0x000FBBE4 File Offset: 0x000F9DE4
		Friend Overridable Property Label5 As Label

		' Token: 0x17000A8F RID: 2703
		' (get) Token: 0x06001B1F RID: 6943 RVA: 0x000FBBED File Offset: 0x000F9DED
		' (set) Token: 0x06001B20 RID: 6944 RVA: 0x000FBBF7 File Offset: 0x000F9DF7
		Friend Overridable Property txtCode As TextBox

		' Token: 0x17000A90 RID: 2704
		' (get) Token: 0x06001B21 RID: 6945 RVA: 0x000FBC00 File Offset: 0x000F9E00
		' (set) Token: 0x06001B22 RID: 6946 RVA: 0x000FBC0A File Offset: 0x000F9E0A
		Friend Overridable Property Label6 As Label

		' Token: 0x17000A91 RID: 2705
		' (get) Token: 0x06001B23 RID: 6947 RVA: 0x000FBC13 File Offset: 0x000F9E13
		' (set) Token: 0x06001B24 RID: 6948 RVA: 0x000FBC20 File Offset: 0x000F9E20
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

		' Token: 0x17000A92 RID: 2706
		' (get) Token: 0x06001B25 RID: 6949 RVA: 0x000FBC63 File Offset: 0x000F9E63
		' (set) Token: 0x06001B26 RID: 6950 RVA: 0x000FBC6D File Offset: 0x000F9E6D
		Friend Overridable Property Label13 As Label

		' Token: 0x17000A93 RID: 2707
		' (get) Token: 0x06001B27 RID: 6951 RVA: 0x000FBC76 File Offset: 0x000F9E76
		' (set) Token: 0x06001B28 RID: 6952 RVA: 0x000FBC80 File Offset: 0x000F9E80
		Friend Overridable Property cmbStatus As ComboBox

		' Token: 0x17000A94 RID: 2708
		' (get) Token: 0x06001B29 RID: 6953 RVA: 0x000FBC89 File Offset: 0x000F9E89
		' (set) Token: 0x06001B2A RID: 6954 RVA: 0x000FBC93 File Offset: 0x000F9E93
		Friend Overridable Property Label11 As Label

		' Token: 0x17000A95 RID: 2709
		' (get) Token: 0x06001B2B RID: 6955 RVA: 0x000FBC9C File Offset: 0x000F9E9C
		' (set) Token: 0x06001B2C RID: 6956 RVA: 0x000FBCA6 File Offset: 0x000F9EA6
		Friend Overridable Property Label3 As Label

		' Token: 0x17000A96 RID: 2710
		' (get) Token: 0x06001B2D RID: 6957 RVA: 0x000FBCAF File Offset: 0x000F9EAF
		' (set) Token: 0x06001B2E RID: 6958 RVA: 0x000FBCBC File Offset: 0x000F9EBC
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

		' Token: 0x17000A97 RID: 2711
		' (get) Token: 0x06001B2F RID: 6959 RVA: 0x000FBCFF File Offset: 0x000F9EFF
		' (set) Token: 0x06001B30 RID: 6960 RVA: 0x000FBD09 File Offset: 0x000F9F09
		Friend Overridable Property txtChallanNo As TextBox

		' Token: 0x17000A98 RID: 2712
		' (get) Token: 0x06001B31 RID: 6961 RVA: 0x000FBD12 File Offset: 0x000F9F12
		' (set) Token: 0x06001B32 RID: 6962 RVA: 0x000FBD1C File Offset: 0x000F9F1C
		Friend Overridable Property Label9 As Label

		' Token: 0x17000A99 RID: 2713
		' (get) Token: 0x06001B33 RID: 6963 RVA: 0x000FBD25 File Offset: 0x000F9F25
		' (set) Token: 0x06001B34 RID: 6964 RVA: 0x000FBD2F File Offset: 0x000F9F2F
		Friend Overridable Property Label4 As Label

		' Token: 0x17000A9A RID: 2714
		' (get) Token: 0x06001B35 RID: 6965 RVA: 0x000FBD38 File Offset: 0x000F9F38
		' (set) Token: 0x06001B36 RID: 6966 RVA: 0x000FBD42 File Offset: 0x000F9F42
		Friend Overridable Property txtCreated As TextBox

		' Token: 0x17000A9B RID: 2715
		' (get) Token: 0x06001B37 RID: 6967 RVA: 0x000FBD4B File Offset: 0x000F9F4B
		' (set) Token: 0x06001B38 RID: 6968 RVA: 0x000FBD55 File Offset: 0x000F9F55
		Friend Overridable Property txtInvoiceNo As TextBox

		' Token: 0x17000A9C RID: 2716
		' (get) Token: 0x06001B39 RID: 6969 RVA: 0x000FBD5E File Offset: 0x000F9F5E
		' (set) Token: 0x06001B3A RID: 6970 RVA: 0x000FBD68 File Offset: 0x000F9F68
		Friend Overridable Property lblCreated As ComboBox

		' Token: 0x17000A9D RID: 2717
		' (get) Token: 0x06001B3B RID: 6971 RVA: 0x000FBD71 File Offset: 0x000F9F71
		' (set) Token: 0x06001B3C RID: 6972 RVA: 0x000FBD7C File Offset: 0x000F9F7C
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

		' Token: 0x17000A9E RID: 2718
		' (get) Token: 0x06001B3D RID: 6973 RVA: 0x000FBDBF File Offset: 0x000F9FBF
		' (set) Token: 0x06001B3E RID: 6974 RVA: 0x000FBDC9 File Offset: 0x000F9FC9
		Friend Overridable Property grpListButton As GroupBox

		' Token: 0x17000A9F RID: 2719
		' (get) Token: 0x06001B3F RID: 6975 RVA: 0x000FBDD2 File Offset: 0x000F9FD2
		' (set) Token: 0x06001B40 RID: 6976 RVA: 0x000FBDDC File Offset: 0x000F9FDC
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x17000AA0 RID: 2720
		' (get) Token: 0x06001B41 RID: 6977 RVA: 0x000FBDE5 File Offset: 0x000F9FE5
		' (set) Token: 0x06001B42 RID: 6978 RVA: 0x000FBDF0 File Offset: 0x000F9FF0
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

		' Token: 0x17000AA1 RID: 2721
		' (get) Token: 0x06001B43 RID: 6979 RVA: 0x000FBE33 File Offset: 0x000FA033
		' (set) Token: 0x06001B44 RID: 6980 RVA: 0x000FBE40 File Offset: 0x000FA040
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

		' Token: 0x17000AA2 RID: 2722
		' (get) Token: 0x06001B45 RID: 6981 RVA: 0x000FBE83 File Offset: 0x000FA083
		' (set) Token: 0x06001B46 RID: 6982 RVA: 0x000FBE90 File Offset: 0x000FA090
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

		' Token: 0x17000AA3 RID: 2723
		' (get) Token: 0x06001B47 RID: 6983 RVA: 0x000FBED3 File Offset: 0x000FA0D3
		' (set) Token: 0x06001B48 RID: 6984 RVA: 0x000FBEDD File Offset: 0x000FA0DD
		Friend Overridable Property lblRows As Label

		' Token: 0x17000AA4 RID: 2724
		' (get) Token: 0x06001B49 RID: 6985 RVA: 0x000FBEE6 File Offset: 0x000FA0E6
		' (set) Token: 0x06001B4A RID: 6986 RVA: 0x000FBEF0 File Offset: 0x000FA0F0
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

		' Token: 0x17000AA5 RID: 2725
		' (get) Token: 0x06001B4B RID: 6987 RVA: 0x000FBF33 File Offset: 0x000FA133
		' (set) Token: 0x06001B4C RID: 6988 RVA: 0x000FBF3D File Offset: 0x000FA13D
		Friend Overridable Property cmbGRNType As ComboBox

		' Token: 0x17000AA6 RID: 2726
		' (get) Token: 0x06001B4D RID: 6989 RVA: 0x000FBF46 File Offset: 0x000FA146
		' (set) Token: 0x06001B4E RID: 6990 RVA: 0x000FBF50 File Offset: 0x000FA150
		Friend Overridable Property Label7 As Label

		' Token: 0x06001B4F RID: 6991 RVA: 0x000FBF5C File Offset: 0x000FA15C
		Public Sub New(sForm As String)
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.InitializeComponent()
			Me.pnlBasicDefaultHeight = Me.GbBasic.Height
			Me.pnlBasicSetHeight = 23
			Me.pnlAdvDefaultHeight = 23
			Me.pnlAdvSetHeight = Me.GbAdvanced.Height
			Me.sFormType = sForm
			Me.Text = Me.sFormType + " List"
			MyBase.TabText = Strings.Replace(Me.sFormType + " List", "&", "&&", 1, -1, CompareMethod.Binary)
		End Sub

		' Token: 0x06001B50 RID: 6992 RVA: 0x000FC018 File Offset: 0x000FA218
		Private Sub SetSearchPanel()
			Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
			Me.GbBasic.Height = Me.pnlBasicDefaultHeight
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
			Me.skip_btnAdvanceExp_sml_Click(Nothing, Nothing)
		End Sub

		' Token: 0x06001B51 RID: 6993 RVA: 0x000FC078 File Offset: 0x000FA278
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

		' Token: 0x06001B52 RID: 6994 RVA: 0x000FC0E8 File Offset: 0x000FA2E8
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

		' Token: 0x06001B53 RID: 6995 RVA: 0x000FC158 File Offset: 0x000FA358
		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x06001B54 RID: 6996 RVA: 0x000FC18D File Offset: 0x000FA38D
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Me.SetSearchPanel()
			Designing.SetTheme(Me)
			Me.FillCombo()
			Me.ClearList()
			Me.SetForm()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x06001B55 RID: 6997 RVA: 0x000FC1CC File Offset: 0x000FA3CC
		Private Sub FillCombo()
			Dim text As String = "SELECT VendorID, VendorName FROM Vendor ORDER BY VendorName"
			Dim data As DataTable = MainModule.GetData(text)
			Me.cmbVendor.ValueMember = "VendorID"
			Me.cmbVendor.DisplayMember = "VendorName"
			Me.cmbVendor.DataSource = data
			Me.cmbVendor.SelectedIndex = -1
		End Sub

		' Token: 0x06001B56 RID: 6998 RVA: 0x000FC224 File Offset: 0x000FA424
		Private Sub SetForm()
			Dim text As String = Me.sFormType
			Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(text)
			If num <= 1541909723UI Then
				If num <= 1409100530UI Then
					If num <> 521908805UI Then
						If num = 1409100530UI Then
							If Operators.CompareString(text, "GRN QC Entry", False) = 0 Then
								Me.cmbStatus.Items.Remove("Cancelled")
								Me.cmbStatus.Items.Remove("GRN In Approval")
								Dim flag As Boolean = Operators.CompareString(MyBase.TabText, "QC Entry List", False) = 0
								If flag Then
									Me.cmbItemStatus.Text = "In QC Release"
								Else
									Dim flag2 As Boolean = Operators.CompareString(MyBase.TabText, "QC On-Hold List", False) = 0
									If flag2 Then
										Me.cmbItemStatus.Text = "QC On-Hold"
									Else
										Dim flag3 As Boolean = Operators.CompareString(MyBase.TabText, "QA On-Hold List", False) = 0
										If flag3 Then
											Me.cmbItemStatus.Text = "QA On-Hold"
										End If
									End If
								End If
								Me.cmbSummary.Text = "Item-wise"
								Me.cmbSummary.Enabled = False
								Me.SearchData("")
							End If
						End If
					ElseIf Operators.CompareString(text, "GRN QA Release", False) = 0 Then
						Me.cmbGRNType.Text = "BMR"
						Me.cmbGRNType.Enabled = False
						Me.cmbStatus.Items.Remove("Cancelled")
						Me.cmbStatus.Items.Remove("GRN In Approval")
						Me.cmbItemStatus.Items.Remove("In QC Release")
						Me.cmbItemStatus.Items.Remove("QC Saved")
						Me.cmbItemStatus.Items.Remove("QC On-Hold")
						Me.cmbItemStatus.Items.Remove("QC Rejected")
						Me.cmbItemStatus.Text = "QC Approved"
						Me.cmbStatus.Text = ""
						Me.cmbSummary.Text = "Item-wise"
						Me.cmbSummary.Enabled = False
						Me.SearchData("")
					End If
				ElseIf num <> 1521117455UI Then
					If num = 1541909723UI Then
						If Operators.CompareString(text, "GRN QC Release", False) = 0 Then
							Me.cmbStatus.Items.Remove("Cancelled")
							Me.cmbStatus.Items.Remove("GRN In Approval")
							Me.cmbStatus.Text = ""
							Me.cmbItemStatus.Text = "QC Saved"
							Me.cmbSummary.Text = "Item-wise"
							Me.cmbSummary.Enabled = False
							Me.SearchData("")
						End If
					End If
				ElseIf Operators.CompareString(text, "GRN PO Receipt", False) <> 0 Then
				End If
			ElseIf num <= 2668735510UI Then
				If num <> 1991191371UI Then
					If num = 2668735510UI Then
						If Operators.CompareString(text, "GRN", False) <> 0 Then
						End If
					End If
				ElseIf Operators.CompareString(text, "GRN Printing", False) = 0 Then
					Me.cmbStatus.Items.Remove("Cancelled")
					Me.cmbStatus.Items.Remove("GRN In Approval")
					Me.cmbSummary.Items.Remove("GRN-wise")
					Me.cmbStatus.Text = "GRN Approved"
					Me.SearchData("")
				End If
			ElseIf num <> 2833639041UI Then
				If num = 2924031041UI Then
					If Operators.CompareString(text, "GRN Approval", False) <> 0 Then
					End If
				End If
			ElseIf Operators.CompareString(text, "GRN Cancellation", False) <> 0 Then
			End If
		End Sub

		' Token: 0x06001B57 RID: 6999 RVA: 0x000FC634 File Offset: 0x000FA834
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
			Me.dtpFrom.Value = DateAndTime.Now
			Me.dtpTo.Value = DateAndTime.Now
			Me.dtpFrom.Checked = False
			Me.dtpTo.Checked = False
			Me.lblRows.Text = "0 - Rows"
			Me.cmbSummary.Text = "Item-wise"
			Me.txtBatchNo.Text = ""
			Me.txtCode.Text = ""
			Me.txtCatalogNo.Text = ""
			Me.txtName.Text = ""
			Dim text As String = Me.sFormType
			If Operators.CompareString(text, "GRN QC Entry", False) <> 0 Then
				If Operators.CompareString(text, "GRN QC Release", False) = 0 Then
					Me.cmbItemStatus.Text = "QC Saved"
				End If
			Else
				Me.cmbItemStatus.Text = "In QC Release"
			End If
			Me.dgvList.DataSource = Nothing
		End Sub

		' Token: 0x06001B58 RID: 7000 RVA: 0x000FC7CD File Offset: 0x000FA9CD
		Private Sub btnClearList_Click(sender As Object, e As EventArgs)
			Me.ClearList()
		End Sub

		' Token: 0x06001B59 RID: 7001 RVA: 0x000FC7D7 File Offset: 0x000FA9D7
		Private Sub btnExport_Click(sender As Object, e As EventArgs)
			MainModule.ExportToExcel(Me.dgvList, Me.Text)
		End Sub

		' Token: 0x06001B5A RID: 7002 RVA: 0x000FC7EC File Offset: 0x000FA9EC
		Private Sub cmbSummary_SelectedValueChanged(sender As Object, e As EventArgs)
			Me.SetSummary()
		End Sub

		' Token: 0x06001B5B RID: 7003 RVA: 0x000FC7F8 File Offset: 0x000FA9F8
		Private Sub SetSummary()
			Dim text As String = Me.cmbSummary.Text
			If Operators.CompareString(text, "GRN-wise", False) <> 0 Then
				If Operators.CompareString(text, "Item-wise", False) = 0 Then
					Me.pnlItem.Visible = True
					Me.pnlAdvSetHeight = 220
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

		' Token: 0x06001B5C RID: 7004 RVA: 0x000FC8FC File Offset: 0x000FAAFC
		Private Sub cmbVendor_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbVendor.SelectedIndex = -1
			If flag Then
				Me.cmbVendor.Text = ""
			End If
		End Sub

		' Token: 0x06001B5D RID: 7005 RVA: 0x000FC930 File Offset: 0x000FAB30
		Private Sub btnSearch_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SearchData("")
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06001B5E RID: 7006 RVA: 0x000FC9A4 File Offset: 0x000FABA4
		Private Sub SearchData(sID As String)
			Dim text As String = ""
			Dim flag As Boolean = Operators.CompareString(Me.cmbSummary.Text, "GRN-wise", False) = 0
			Dim text2 As String
			If flag Then
				text2 = " SELECT DISTINCT G.Status GRN_Status, G.GRNID, G.GRNType, G.GRNNo, G.GRNDt, G.VendorID, V.VendorName, G.POID, G.POType,  " & vbCrLf
				text2 += " G.PONo, G.PODt, G.InvoiceNo, G.InvoiceDt, G.ChallanNo, G.ChallanDt,  " & vbCrLf
				text2 += " Action.UserName AS ActionBy, G.ActionDt,  " & vbCrLf
				text2 += " Created.EmailID AS CreatedByEmailID, Modified.EmailID AS ModifiedByEmailID,  " & vbCrLf
				text2 += " G.CreationDt, Created.UserName AS CreatedBy, G.ModificationDt, Modified.UserName AS ModifiedBy " & vbCrLf
				text2 += " FROM GRN AS G  " & vbCrLf
				text2 += " INNER JOIN Vendor AS V ON G.VendorID = V.VendorID  " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Action ON G.ActionBy = Action.UserID  " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Created ON G.CreatedBy = Created.UserID  " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Modified ON G.ModifiedBy = Modified.UserID " & vbCrLf
				text2 += " INNER JOIN GRNItems AS GI ON G.GRNID = GI.GRNID  " & vbCrLf
			Else
				text2 = " SELECT DISTINCT G.Status GRN_Status, GI.Status AS Item_Status, G.GRNID, GI.GRNItemsID, G.GRNType, G.GRNNo, G.GRNDt, P.ProductName,  " & vbCrLf
				text2 += " G.VendorID, V.VendorName, G.POID, G.POType, G.PONo, G.PODt, G.InvoiceNo, G.InvoiceDt, G.ChallanNo, G.ChallanDt,  " & vbCrLf
				text2 += " Action.UserName AS ActionBy, G.ActionDt,  " & vbCrLf
				text2 += " P.ProductID, P.ProductCode, P.CatalogNo, P.ProductType, GI.BatchNo, GI.MfgDt, GI.ExpDt,  " & vbCrLf
				text2 += " P.TertiaryUOM, P.PrimaryUOM, GI.TertiaryPackSize, GI.PrimaryPackSize, GI.ReceivedQty, P.Measurement, " & vbCrLf
				text2 += " P.StorageCondition, GI.CellCount, GI.PassageNo, GI.ODPermL, " & vbCrLf
				text2 += " QCE.UserName QCEntryBy, GI.QCEntryDt, QCA.UserName QCActionBy, GI.QCActionDt, " & vbCrLf
				text2 += " Created.EmailID AS CreatedByEmailID, Modified.EmailID AS ModifiedByEmailID,  " & vbCrLf
				text2 += " G.CreationDt, Created.UserName AS CreatedBy, G.ModificationDt, Modified.UserName AS ModifiedBy " & vbCrLf
				text2 += " FROM GRN AS G  " & vbCrLf
				text2 += " INNER JOIN Vendor AS V ON G.VendorID = V.VendorID  " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Action ON G.ActionBy = Action.UserID  " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Created ON G.CreatedBy = Created.UserID  " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Modified ON G.ModifiedBy = Modified.UserID " & vbCrLf
				text2 += " INNER JOIN GRNItems AS GI ON G.GRNID = GI.GRNID  " & vbCrLf
				text2 += " INNER JOIN Product P ON GI.ProductID = P.ProductID  " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS QCE ON GI.QCEntryBy = QCE.UserID  " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS QCA ON GI.QCActionBy = QCA.UserID  " & vbCrLf
			End If
			text2 += " WHERE 1=1" & vbCrLf
			Dim text3 As String = Me.sFormType
			Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(text3)
			If num <= 1541909723UI Then
				If num <> 521908805UI Then
					If num <> 1409100530UI Then
						If num = 1541909723UI Then
							If Operators.CompareString(text3, "GRN QC Release", False) = 0 Then
								text2 += " AND G.Status IN ('Under Release', 'Release Complete')" & vbCrLf
								text2 += " AND GI.IsQCApplicable <> 0 " & vbCrLf
							End If
						End If
					ElseIf Operators.CompareString(text3, "GRN QC Entry", False) = 0 Then
						text2 += " AND G.Status IN ('GRN Approved', 'Under Release', 'Release Complete')" & vbCrLf
						text2 += " AND GI.IsQCApplicable <> 0 " & vbCrLf
					End If
				ElseIf Operators.CompareString(text3, "GRN QA Release", False) = 0 Then
					text2 += " AND G.Status IN ('Under Release', 'Release Complete')" & vbCrLf
					text2 += " AND GI.Status IN ('QC Approved', 'Batch Released', 'QA Rejected')" & vbCrLf
					text2 += " AND GI.IsQCApplicable <> 0 " & vbCrLf
				End If
			ElseIf num <= 2668735510UI Then
				If num <> 1991191371UI Then
					If num = 2668735510UI Then
						If Operators.CompareString(text3, "GRN", False) <> 0 Then
						End If
					End If
				ElseIf Operators.CompareString(text3, "GRN Printing", False) = 0 Then
					text2 += " AND (G.Status IN ('GRN Approved', 'Under Release', 'Release Complete'))" & vbCrLf
				End If
			ElseIf num <> 2924031041UI Then
				If num = 4265872968UI Then
					If Operators.CompareString(text3, "Concentration & Titre", False) = 0 Then
						text2 += " AND G.GRNType = 'BMR' " & vbCrLf
						text2 += " AND P.ProductType IN ('Cell Bank - Mammalian', 'Cell Bank - Bacterial')" & vbCrLf
					End If
				End If
			ElseIf Operators.CompareString(text3, "GRN Approval", False) <> 0 Then
			End If
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
			Dim flag5 As Boolean = Operators.CompareString(Me.cmbGRNType.Text, "", False) <> 0
			If flag5 Then
				text2 = text2 + " And (GRNType = '" + Me.cmbGRNType.Text + "') " & vbCrLf
				text = text + "GRNType = " + Me.cmbGRNType.Text + vbCrLf
			End If
			Dim flag6 As Boolean = Operators.CompareString(Strings.Trim(Me.txtInvoiceNo.Text), "", False) <> 0
			If flag6 Then
				text2 = text2 + " And (InvoiceNo Like '%" + Strings.Trim(Me.txtInvoiceNo.Text) + "%') " & vbCrLf
				text = text + "InvoiceNo LIKE " + Strings.Trim(Me.txtInvoiceNo.Text) + vbCrLf
			End If
			Dim flag7 As Boolean = Operators.CompareString(Strings.Trim(Me.txtChallanNo.Text), "", False) <> 0
			If flag7 Then
				text2 = text2 + " AND (ChallanNo LIKE '%" + Strings.Trim(Me.txtChallanNo.Text) + "%')" & vbCrLf
				text = text + "ChallanNo LIKE " + Strings.Trim(Me.txtChallanNo.Text) + vbCrLf
			End If
			Dim flag8 As Boolean = Me.cmbVendor.SelectedIndex > -1
			If flag8 Then
				text2 = text2 + " AND (G.VendorID = '" + Strings.Trim(Me.cmbVendor.SelectedValue.ToString()) + "')" & vbCrLf
				text = text + "VendorID = " + Strings.Trim(Me.cmbVendor.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag9 As Boolean = Me.cmbStatus.SelectedIndex > 0
			If flag9 Then
				text2 = text2 + " AND (G.Status = '" + Me.cmbStatus.Text + "')" & vbCrLf
				text = text + ("Status = " + Me.cmbStatus.Text) + vbCrLf
			End If
			Dim flag10 As Boolean = Operators.CompareString(Me.cmbItemStatus.Text, "", False) <> 0
			If flag10 Then
				text2 = text2 + " AND (GI.Status = '" + Me.cmbItemStatus.Text + "') " & vbCrLf
				text = text + ("Item Status = " + Me.cmbItemStatus.Text) + vbCrLf
			End If
			Dim flag11 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCreated.Text), "", False) <> 0
			If flag11 Then
				Dim flag12 As Boolean = Me.lblCreated.SelectedIndex >= 0
				If flag12 Then
					Dim flag13 As Boolean = Me.lblCreated.SelectedIndex = 0
					Dim text4 As String
					If flag13 Then
						text4 = "Created"
					Else
						text4 = "Modified"
					End If
					text2 = String.Concat(New String() { text2, " AND ", text4, ".UserName LIKE '%", Strings.Trim(Me.txtCreated.Text), "%'" })
					text = text + (text4 + "By LIKE " + Strings.Trim(Me.txtCreated.Text)) + vbCrLf
				End If
			End If
			Dim flag14 As Boolean = Me.lblDate.SelectedIndex >= 0
			If flag14 Then
				Dim text5 As String = Me.lblDate.Text
				Dim text6 As String
				If Operators.CompareString(text5, "Creation", False) <> 0 Then
					If Operators.CompareString(text5, "Last Modification", False) <> 0 Then
						If Operators.CompareString(text5, "G.R.N Date", False) <> 0 Then
							If Operators.CompareString(text5, "P.O. Date", False) <> 0 Then
								If Operators.CompareString(text5, "Invoice Date", False) <> 0 Then
									If Operators.CompareString(text5, "Challan  Date", False) <> 0 Then
										text6 = ""
									Else
										text6 = "G.ChallanDt"
									End If
								Else
									text6 = "G.InvoiceDt"
								End If
							Else
								text6 = "G.PODt"
							End If
						Else
							text6 = "G.GRNDt"
						End If
					Else
						text6 = "G.ModificationDt"
					End If
				Else
					text6 = "G.CreationDt"
				End If
				Dim flag15 As Boolean = Operators.CompareString(text6, "", False) <> 0
				If flag15 Then
					Dim flag16 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
					If flag16 Then
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
			Dim flag17 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Item-wise", False) = 0
			If flag17 Then
				Dim flag18 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCode.Text), "", False) <> 0
				If flag18 Then
					text2 = text2 + " AND (P.ProductCode Like '%" + Strings.Trim(Me.txtCode.Text) + "%') "
					text = text + "ProductCode LIKE " + Strings.Trim(Me.txtCode.Text) + vbCrLf
				End If
				Dim flag19 As Boolean = Operators.CompareString(Strings.Trim(Me.txtName.Text), "", False) <> 0
				If flag19 Then
					text2 = text2 + " AND (P.ProductName Like '%" + Strings.Trim(Me.txtName.Text) + "%') "
					text = text + "ProductName LIKE " + Strings.Trim(Me.txtName.Text) + vbCrLf
				End If
				Dim flag20 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCatalogNo.Text), "", False) <> 0
				If flag20 Then
					text2 = text2 + " AND (P.CatalogNo Like '%" + Strings.Trim(Me.txtCatalogNo.Text) + "%') "
					text = text + "CatalogNo LIKE " + Strings.Trim(Me.txtCatalogNo.Text) + vbCrLf
				End If
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
			Me.dgvList.Columns("StorageCondition").Visible = False
			Me.dgvList.Columns("CellCount").Visible = False
			Me.dgvList.Columns("PassageNo").Visible = False
			Me.dgvList.Columns("ODPermL").Visible = False
			Me.dgvList.Columns("GRN_Status").HeaderText = "GRN Status"
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
			Me.dgvList.Columns("ActionBy").HeaderText = "GRN Action By"
			Me.dgvList.Columns("ActionDt").HeaderText = "GRN Action Date"
			Me.dgvList.Columns("CreatedBy").HeaderText = "Created By"
			Me.dgvList.Columns("ModificationDt").HeaderText = "Modification Date"
			Me.dgvList.Columns("ModifiedBy").HeaderText = "Modified By"
			Me.dgvList.Columns("GRNDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("PODt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("InvoiceDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("ChallanDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("ActionDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
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
			Me.dgvList.Columns("GRN_Status").Width = 132
			Me.dgvList.Columns("CreationDt").Width = 170
			Me.dgvList.Columns("CreatedBy").Width = 140
			Me.dgvList.Columns("ModificationDt").Width = 170
			Me.dgvList.Columns("ModifiedBy").Width = 140
			Dim flag21 As Boolean = data.Columns.Contains("ProductCode")
			If flag21 Then
				Me.dgvList.Columns("ProductID").Visible = False
				Me.dgvList.Columns("GRNItemsID").Visible = False
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
				Me.dgvList.Columns("QCEntryBy").HeaderText = "QC Entry By"
				Me.dgvList.Columns("QCEntryDt").HeaderText = "QC Entry Date"
				Me.dgvList.Columns("QCActionBy").HeaderText = "QC Action By"
				Me.dgvList.Columns("QCActionDt").HeaderText = "QC Action Date"
				Me.dgvList.Columns("ProductCode").Width = 180
				Me.dgvList.Columns("CatalogNo").Width = 180
				Me.dgvList.Columns("ProductName").Width = 300
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
				Me.dgvList.Columns("QCEntryBy").Width = 140
				Me.dgvList.Columns("QCActionBy").Width = 140
				Me.dgvList.Columns("QCEntryDt").Width = 170
				Me.dgvList.Columns("QCActionDt").Width = 170
				Me.dgvList.Columns("MfgDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
				Me.dgvList.Columns("ExpDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
				Me.dgvList.Columns("QCEntryDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
				Me.dgvList.Columns("QCActionDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
				Me.dgvList.Columns("TertiaryPackSize").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("PrimaryPackSize").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("ReceivedQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x06001B5F RID: 7007 RVA: 0x000FE274 File Offset: 0x000FC474
		Private Sub dgvList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = (e.RowIndex > -1) And (e.ColumnIndex > -1)
			If flag Then
				Dim text As String = Me.sFormType
				Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(text)
				If num <= 1541909723UI Then
					If num <= 1409100530UI Then
						If num <> 521908805UI Then
							If num = 1409100530UI Then
								If Operators.CompareString(text, "GRN QC Entry", False) = 0 Then
									Dim dataTable As DataTable = CType(Me.dgvList.DataSource, DataTable)
									Dim flag2 As Boolean = dataTable.Columns.Contains("ProductID")
									Dim text2 As String
									If flag2 Then
										text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("GRNID = '", Me.dgvList.Rows(e.RowIndex).Cells("GRNID").Value), "' "))
										text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" AND ProductID = '", Me.dgvList.Rows(e.RowIndex).Cells("ProductID").Value), "'")))
										text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" AND BatchNo = '", Me.dgvList.Rows(e.RowIndex).Cells("BatchNo").Value), "'")))
										text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" AND PrimaryPackSize = '", Me.dgvList.Rows(e.RowIndex).Cells("PrimaryPackSize").Value), "'")))
									Else
										text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("GRNID = '", Me.dgvList.Rows(e.RowIndex).Cells("GRNID").Value), "'"))
									End If
									Dim dataRow As DataRow = dataTable.[Select](text2)(0)
									Dim qcrelease As QCRelease01 = New QCRelease01(Me.sFormType, dataRow)
									qcrelease.ShowDialog()
								End If
							End If
						ElseIf Operators.CompareString(text, "GRN QA Release", False) = 0 Then
							Dim dataTable2 As DataTable = CType(Me.dgvList.DataSource, DataTable)
							Dim flag3 As Boolean = dataTable2.Columns.Contains("ProductID")
							Dim text3 As String
							If flag3 Then
								text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("GRNID = '", Me.dgvList.Rows(e.RowIndex).Cells("GRNID").Value), "' "))
								text3 = Conversions.ToString(Operators.AddObject(text3, Operators.ConcatenateObject(Operators.ConcatenateObject(" AND ProductID = '", Me.dgvList.Rows(e.RowIndex).Cells("ProductID").Value), "'")))
								text3 = Conversions.ToString(Operators.AddObject(text3, Operators.ConcatenateObject(Operators.ConcatenateObject(" AND BatchNo = '", Me.dgvList.Rows(e.RowIndex).Cells("BatchNo").Value), "'")))
								text3 = Conversions.ToString(Operators.AddObject(text3, Operators.ConcatenateObject(Operators.ConcatenateObject(" AND PrimaryPackSize = '", Me.dgvList.Rows(e.RowIndex).Cells("PrimaryPackSize").Value), "'")))
							Else
								text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("GRNID = '", Me.dgvList.Rows(e.RowIndex).Cells("GRNID").Value), "'"))
							End If
							Dim dataRow2 As DataRow = dataTable2.[Select](text3)(0)
							Dim qcrelease2 As QCRelease01 = New QCRelease01(Me.sFormType, dataRow2)
							qcrelease2.ShowDialog()
						End If
					ElseIf num <> 1521117455UI Then
						If num = 1541909723UI Then
							If Operators.CompareString(text, "GRN QC Release", False) = 0 Then
								Dim dataTable3 As DataTable = CType(Me.dgvList.DataSource, DataTable)
								Dim flag4 As Boolean = dataTable3.Columns.Contains("ProductID")
								Dim text4 As String
								If flag4 Then
									text4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("GRNID = '", Me.dgvList.Rows(e.RowIndex).Cells("GRNID").Value), "' "))
									text4 = Conversions.ToString(Operators.AddObject(text4, Operators.ConcatenateObject(Operators.ConcatenateObject(" AND ProductID = '", Me.dgvList.Rows(e.RowIndex).Cells("ProductID").Value), "'")))
									text4 = Conversions.ToString(Operators.AddObject(text4, Operators.ConcatenateObject(Operators.ConcatenateObject(" AND BatchNo = '", Me.dgvList.Rows(e.RowIndex).Cells("BatchNo").Value), "'")))
									text4 = Conversions.ToString(Operators.AddObject(text4, Operators.ConcatenateObject(Operators.ConcatenateObject(" AND PrimaryPackSize = '", Me.dgvList.Rows(e.RowIndex).Cells("PrimaryPackSize").Value), "'")))
								Else
									text4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("GRNID = '", Me.dgvList.Rows(e.RowIndex).Cells("GRNID").Value), "'"))
								End If
								Dim dataRow3 As DataRow = dataTable3.[Select](text4)(0)
								Dim qcrelease3 As QCRelease01 = New QCRelease01(Me.sFormType, dataRow3)
								qcrelease3.ShowDialog()
							End If
						End If
					ElseIf Operators.CompareString(text, "GRN PO Receipt", False) <> 0 Then
					End If
				ElseIf num <= 2668735510UI Then
					If num <> 1991191371UI Then
						If num = 2668735510UI Then
							If Operators.CompareString(text, "GRN", False) <> 0 Then
							End If
						End If
					ElseIf Operators.CompareString(text, "GRN Printing", False) = 0 Then
						Dim dataTable4 As DataTable = CType(Me.dgvList.DataSource, DataTable)
						Dim flag5 As Boolean = dataTable4.Columns.Contains("ProductID")
						Dim text5 As String
						If flag5 Then
							text5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("GRNID = '", Me.dgvList.Rows(e.RowIndex).Cells("GRNID").Value), "' "))
							text5 = Conversions.ToString(Operators.AddObject(text5, Operators.ConcatenateObject(Operators.ConcatenateObject(" AND ProductID = '", Me.dgvList.Rows(e.RowIndex).Cells("ProductID").Value), "'")))
							text5 = Conversions.ToString(Operators.AddObject(text5, Operators.ConcatenateObject(Operators.ConcatenateObject(" AND BatchNo = '", Me.dgvList.Rows(e.RowIndex).Cells("BatchNo").Value), "'")))
							text5 = Conversions.ToString(Operators.AddObject(text5, Operators.ConcatenateObject(Operators.ConcatenateObject(" AND PrimaryPackSize = '", Me.dgvList.Rows(e.RowIndex).Cells("PrimaryPackSize").Value), "'")))
						Else
							text5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("GRNID = '", Me.dgvList.Rows(e.RowIndex).Cells("GRNID").Value), "'"))
						End If
						Dim dataRow4 As DataRow = dataTable4.[Select](text5)(0)
						Dim uidprinting As UIDPrinting = New UIDPrinting(dataRow4)
						uidprinting.Show(MyBase.DockPanel)
					End If
				ElseIf num <> 2924031041UI Then
					If num = 4265872968UI Then
						If Operators.CompareString(text, "Concentration & Titre", False) <> 0 Then
						End If
					End If
				ElseIf Operators.CompareString(text, "GRN Approval", False) <> 0 Then
				End If
				Me.SearchData("")
			End If
		End Sub

		' Token: 0x04000BD5 RID: 3029
		Private sFormType As String

		' Token: 0x04000BD6 RID: 3030
		Private pnlBasicDefaultHeight As Integer

		' Token: 0x04000BD7 RID: 3031
		Private pnlBasicSetHeight As Integer

		' Token: 0x04000BD8 RID: 3032
		Private pnlAdvDefaultHeight As Integer

		' Token: 0x04000BD9 RID: 3033
		Private pnlAdvSetHeight As Integer
	End Class
End Namespace
