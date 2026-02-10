Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Datasoft_PIMS.My
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x02000069 RID: 105
	<DesignerGenerated()>
	Public Partial Class QCRelease01
		Inherits Form

		' Token: 0x17000AA7 RID: 2727
		' (get) Token: 0x06001B62 RID: 7010 RVA: 0x001027D0 File Offset: 0x001009D0
		' (set) Token: 0x06001B63 RID: 7011 RVA: 0x001027DA File Offset: 0x001009DA
		Friend Overridable Property pnlBorder As Panel

		' Token: 0x17000AA8 RID: 2728
		' (get) Token: 0x06001B64 RID: 7012 RVA: 0x001027E3 File Offset: 0x001009E3
		' (set) Token: 0x06001B65 RID: 7013 RVA: 0x001027ED File Offset: 0x001009ED
		Friend Overridable Property pnlMain As Panel

		' Token: 0x17000AA9 RID: 2729
		' (get) Token: 0x06001B66 RID: 7014 RVA: 0x001027F6 File Offset: 0x001009F6
		' (set) Token: 0x06001B67 RID: 7015 RVA: 0x00102800 File Offset: 0x00100A00
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

		' Token: 0x17000AAA RID: 2730
		' (get) Token: 0x06001B68 RID: 7016 RVA: 0x00102843 File Offset: 0x00100A43
		' (set) Token: 0x06001B69 RID: 7017 RVA: 0x0010284D File Offset: 0x00100A4D
		Friend Overridable Property picFormIcon As PictureBox

		' Token: 0x17000AAB RID: 2731
		' (get) Token: 0x06001B6A RID: 7018 RVA: 0x00102856 File Offset: 0x00100A56
		' (set) Token: 0x06001B6B RID: 7019 RVA: 0x00102860 File Offset: 0x00100A60
		Friend Overridable Property lblCaption As Label

		' Token: 0x17000AAC RID: 2732
		' (get) Token: 0x06001B6C RID: 7020 RVA: 0x00102869 File Offset: 0x00100A69
		' (set) Token: 0x06001B6D RID: 7021 RVA: 0x00102874 File Offset: 0x00100A74
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

		' Token: 0x17000AAD RID: 2733
		' (get) Token: 0x06001B6E RID: 7022 RVA: 0x001028B7 File Offset: 0x00100AB7
		' (set) Token: 0x06001B6F RID: 7023 RVA: 0x001028C1 File Offset: 0x00100AC1
		Friend Overridable Property lblShadow1 As Label

		' Token: 0x17000AAE RID: 2734
		' (get) Token: 0x06001B70 RID: 7024 RVA: 0x001028CA File Offset: 0x00100ACA
		' (set) Token: 0x06001B71 RID: 7025 RVA: 0x001028D4 File Offset: 0x00100AD4
		Friend Overridable Property lblShadow2 As Label

		' Token: 0x17000AAF RID: 2735
		' (get) Token: 0x06001B72 RID: 7026 RVA: 0x001028DD File Offset: 0x00100ADD
		' (set) Token: 0x06001B73 RID: 7027 RVA: 0x001028E7 File Offset: 0x00100AE7
		Friend Overridable Property GroupBox1 As GroupBox

		' Token: 0x17000AB0 RID: 2736
		' (get) Token: 0x06001B74 RID: 7028 RVA: 0x001028F0 File Offset: 0x00100AF0
		' (set) Token: 0x06001B75 RID: 7029 RVA: 0x001028FA File Offset: 0x00100AFA
		Friend Overridable Property txtVendor As TextBox

		' Token: 0x17000AB1 RID: 2737
		' (get) Token: 0x06001B76 RID: 7030 RVA: 0x00102903 File Offset: 0x00100B03
		' (set) Token: 0x06001B77 RID: 7031 RVA: 0x0010290D File Offset: 0x00100B0D
		Friend Overridable Property txtPOType As TextBox

		' Token: 0x17000AB2 RID: 2738
		' (get) Token: 0x06001B78 RID: 7032 RVA: 0x00102916 File Offset: 0x00100B16
		' (set) Token: 0x06001B79 RID: 7033 RVA: 0x00102920 File Offset: 0x00100B20
		Friend Overridable Property Label9 As Label

		' Token: 0x17000AB3 RID: 2739
		' (get) Token: 0x06001B7A RID: 7034 RVA: 0x00102929 File Offset: 0x00100B29
		' (set) Token: 0x06001B7B RID: 7035 RVA: 0x00102933 File Offset: 0x00100B33
		Friend Overridable Property Label24 As Label

		' Token: 0x17000AB4 RID: 2740
		' (get) Token: 0x06001B7C RID: 7036 RVA: 0x0010293C File Offset: 0x00100B3C
		' (set) Token: 0x06001B7D RID: 7037 RVA: 0x00102946 File Offset: 0x00100B46
		Friend Overridable Property dtpDt As DateTimePicker

		' Token: 0x17000AB5 RID: 2741
		' (get) Token: 0x06001B7E RID: 7038 RVA: 0x0010294F File Offset: 0x00100B4F
		' (set) Token: 0x06001B7F RID: 7039 RVA: 0x00102959 File Offset: 0x00100B59
		Friend Overridable Property Label1 As Label

		' Token: 0x17000AB6 RID: 2742
		' (get) Token: 0x06001B80 RID: 7040 RVA: 0x00102962 File Offset: 0x00100B62
		' (set) Token: 0x06001B81 RID: 7041 RVA: 0x0010296C File Offset: 0x00100B6C
		Friend Overridable Property Label2 As Label

		' Token: 0x17000AB7 RID: 2743
		' (get) Token: 0x06001B82 RID: 7042 RVA: 0x00102975 File Offset: 0x00100B75
		' (set) Token: 0x06001B83 RID: 7043 RVA: 0x0010297F File Offset: 0x00100B7F
		Friend Overridable Property txtNo As TextBox

		' Token: 0x17000AB8 RID: 2744
		' (get) Token: 0x06001B84 RID: 7044 RVA: 0x00102988 File Offset: 0x00100B88
		' (set) Token: 0x06001B85 RID: 7045 RVA: 0x00102992 File Offset: 0x00100B92
		Friend Overridable Property dtpPODt As DateTimePicker

		' Token: 0x17000AB9 RID: 2745
		' (get) Token: 0x06001B86 RID: 7046 RVA: 0x0010299B File Offset: 0x00100B9B
		' (set) Token: 0x06001B87 RID: 7047 RVA: 0x001029A5 File Offset: 0x00100BA5
		Friend Overridable Property Label28 As Label

		' Token: 0x17000ABA RID: 2746
		' (get) Token: 0x06001B88 RID: 7048 RVA: 0x001029AE File Offset: 0x00100BAE
		' (set) Token: 0x06001B89 RID: 7049 RVA: 0x001029B8 File Offset: 0x00100BB8
		Friend Overridable Property Label27 As Label

		' Token: 0x17000ABB RID: 2747
		' (get) Token: 0x06001B8A RID: 7050 RVA: 0x001029C1 File Offset: 0x00100BC1
		' (set) Token: 0x06001B8B RID: 7051 RVA: 0x001029CB File Offset: 0x00100BCB
		Friend Overridable Property txtPONo As TextBox

		' Token: 0x17000ABC RID: 2748
		' (get) Token: 0x06001B8C RID: 7052 RVA: 0x001029D4 File Offset: 0x00100BD4
		' (set) Token: 0x06001B8D RID: 7053 RVA: 0x001029DE File Offset: 0x00100BDE
		Friend Overridable Property txtPOID As TextBox

		' Token: 0x17000ABD RID: 2749
		' (get) Token: 0x06001B8E RID: 7054 RVA: 0x001029E7 File Offset: 0x00100BE7
		' (set) Token: 0x06001B8F RID: 7055 RVA: 0x001029F1 File Offset: 0x00100BF1
		Friend Overridable Property txtID As TextBox

		' Token: 0x17000ABE RID: 2750
		' (get) Token: 0x06001B90 RID: 7056 RVA: 0x001029FA File Offset: 0x00100BFA
		' (set) Token: 0x06001B91 RID: 7057 RVA: 0x00102A04 File Offset: 0x00100C04
		Friend Overridable Property theme_tc As TabControl

		' Token: 0x17000ABF RID: 2751
		' (get) Token: 0x06001B92 RID: 7058 RVA: 0x00102A0D File Offset: 0x00100C0D
		' (set) Token: 0x06001B93 RID: 7059 RVA: 0x00102A17 File Offset: 0x00100C17
		Friend Overridable Property tpItems As TabPage

		' Token: 0x17000AC0 RID: 2752
		' (get) Token: 0x06001B94 RID: 7060 RVA: 0x00102A20 File Offset: 0x00100C20
		' (set) Token: 0x06001B95 RID: 7061 RVA: 0x00102A2A File Offset: 0x00100C2A
		Friend Overridable Property flpButton As FlowLayoutPanel

		' Token: 0x17000AC1 RID: 2753
		' (get) Token: 0x06001B96 RID: 7062 RVA: 0x00102A33 File Offset: 0x00100C33
		' (set) Token: 0x06001B97 RID: 7063 RVA: 0x00102A40 File Offset: 0x00100C40
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

		' Token: 0x17000AC2 RID: 2754
		' (get) Token: 0x06001B98 RID: 7064 RVA: 0x00102A83 File Offset: 0x00100C83
		' (set) Token: 0x06001B99 RID: 7065 RVA: 0x00102A90 File Offset: 0x00100C90
		Friend Overridable Property btnApprove As Button
			<CompilerGenerated()>
			Get
				Return Me._btnApprove
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnApprove_Click
				Dim button As Button = Me._btnApprove
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnApprove = value
				button = Me._btnApprove
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000AC3 RID: 2755
		' (get) Token: 0x06001B9A RID: 7066 RVA: 0x00102AD3 File Offset: 0x00100CD3
		' (set) Token: 0x06001B9B RID: 7067 RVA: 0x00102AE0 File Offset: 0x00100CE0
		Friend Overridable Property btnReject As Button
			<CompilerGenerated()>
			Get
				Return Me._btnReject
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnReject_Click
				Dim button As Button = Me._btnReject
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnReject = value
				button = Me._btnReject
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000AC4 RID: 2756
		' (get) Token: 0x06001B9C RID: 7068 RVA: 0x00102B23 File Offset: 0x00100D23
		' (set) Token: 0x06001B9D RID: 7069 RVA: 0x00102B30 File Offset: 0x00100D30
		Friend Overridable Property btnPrint As Button
			<CompilerGenerated()>
			Get
				Return Me._btnPrint
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnPrint_Click
				Dim button As Button = Me._btnPrint
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnPrint = value
				button = Me._btnPrint
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000AC5 RID: 2757
		' (get) Token: 0x06001B9E RID: 7070 RVA: 0x00102B73 File Offset: 0x00100D73
		' (set) Token: 0x06001B9F RID: 7071 RVA: 0x00102B80 File Offset: 0x00100D80
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

		' Token: 0x17000AC6 RID: 2758
		' (get) Token: 0x06001BA0 RID: 7072 RVA: 0x00102BC3 File Offset: 0x00100DC3
		' (set) Token: 0x06001BA1 RID: 7073 RVA: 0x00102BCD File Offset: 0x00100DCD
		Friend Overridable Property Panel1 As Panel

		' Token: 0x17000AC7 RID: 2759
		' (get) Token: 0x06001BA2 RID: 7074 RVA: 0x00102BD6 File Offset: 0x00100DD6
		' (set) Token: 0x06001BA3 RID: 7075 RVA: 0x00102BE0 File Offset: 0x00100DE0
		Friend Overridable Property dgvDtls As DataGridView
			<CompilerGenerated()>
			Get
				Return Me._dgvDtls
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim dataGridViewCellEventHandler As DataGridViewCellEventHandler = AddressOf Me.dgvDtls_CellValueChanged
				Dim dataGridView As DataGridView = Me._dgvDtls
				If dataGridView IsNot Nothing Then
					RemoveHandler dataGridView.CellValueChanged, dataGridViewCellEventHandler
				End If
				Me._dgvDtls = value
				dataGridView = Me._dgvDtls
				If dataGridView IsNot Nothing Then
					AddHandler dataGridView.CellValueChanged, dataGridViewCellEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000AC8 RID: 2760
		' (get) Token: 0x06001BA4 RID: 7076 RVA: 0x00102C23 File Offset: 0x00100E23
		' (set) Token: 0x06001BA5 RID: 7077 RVA: 0x00102C2D File Offset: 0x00100E2D
		Friend Overridable Property tpDoc As TabPage

		' Token: 0x17000AC9 RID: 2761
		' (get) Token: 0x06001BA6 RID: 7078 RVA: 0x00102C36 File Offset: 0x00100E36
		' (set) Token: 0x06001BA7 RID: 7079 RVA: 0x00102C40 File Offset: 0x00100E40
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

		' Token: 0x17000ACA RID: 2762
		' (get) Token: 0x06001BA8 RID: 7080 RVA: 0x00102C83 File Offset: 0x00100E83
		' (set) Token: 0x06001BA9 RID: 7081 RVA: 0x00102C8D File Offset: 0x00100E8D
		Friend Overridable Property FileID As DataGridViewTextBoxColumn

		' Token: 0x17000ACB RID: 2763
		' (get) Token: 0x06001BAA RID: 7082 RVA: 0x00102C96 File Offset: 0x00100E96
		' (set) Token: 0x06001BAB RID: 7083 RVA: 0x00102CA0 File Offset: 0x00100EA0
		Friend Overridable Property btnDownload_File As DataGridViewImageColumn

		' Token: 0x17000ACC RID: 2764
		' (get) Token: 0x06001BAC RID: 7084 RVA: 0x00102CA9 File Offset: 0x00100EA9
		' (set) Token: 0x06001BAD RID: 7085 RVA: 0x00102CB3 File Offset: 0x00100EB3
		Friend Overridable Property FileName As DataGridViewTextBoxColumn

		' Token: 0x17000ACD RID: 2765
		' (get) Token: 0x06001BAE RID: 7086 RVA: 0x00102CBC File Offset: 0x00100EBC
		' (set) Token: 0x06001BAF RID: 7087 RVA: 0x00102CC6 File Offset: 0x00100EC6
		Friend Overridable Property btnDelete_File As DataGridViewImageColumn

		' Token: 0x17000ACE RID: 2766
		' (get) Token: 0x06001BB0 RID: 7088 RVA: 0x00102CCF File Offset: 0x00100ECF
		' (set) Token: 0x06001BB1 RID: 7089 RVA: 0x00102CDC File Offset: 0x00100EDC
		Friend Overridable Property btnOnHold As Button
			<CompilerGenerated()>
			Get
				Return Me._btnOnHold
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnOnHold_Click
				Dim button As Button = Me._btnOnHold
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnOnHold = value
				button = Me._btnOnHold
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000ACF RID: 2767
		' (get) Token: 0x06001BB2 RID: 7090 RVA: 0x00102D1F File Offset: 0x00100F1F
		' (set) Token: 0x06001BB3 RID: 7091 RVA: 0x00102D29 File Offset: 0x00100F29
		Friend Overridable Property tab_lbl1 As Label

		' Token: 0x17000AD0 RID: 2768
		' (get) Token: 0x06001BB4 RID: 7092 RVA: 0x00102D32 File Offset: 0x00100F32
		' (set) Token: 0x06001BB5 RID: 7093 RVA: 0x00102D3C File Offset: 0x00100F3C
		Friend Overridable Property tab_lbl3 As Label

		' Token: 0x17000AD1 RID: 2769
		' (get) Token: 0x06001BB6 RID: 7094 RVA: 0x00102D45 File Offset: 0x00100F45
		' (set) Token: 0x06001BB7 RID: 7095 RVA: 0x00102D4F File Offset: 0x00100F4F
		Friend Overridable Property tpRemarks As TabPage

		' Token: 0x17000AD2 RID: 2770
		' (get) Token: 0x06001BB8 RID: 7096 RVA: 0x00102D58 File Offset: 0x00100F58
		' (set) Token: 0x06001BB9 RID: 7097 RVA: 0x00102D62 File Offset: 0x00100F62
		Friend Overridable Property tab_lbl2 As Label

		' Token: 0x17000AD3 RID: 2771
		' (get) Token: 0x06001BBA RID: 7098 RVA: 0x00102D6B File Offset: 0x00100F6B
		' (set) Token: 0x06001BBB RID: 7099 RVA: 0x00102D75 File Offset: 0x00100F75
		Friend Overridable Property lblRemarksApproval1 As Label

		' Token: 0x17000AD4 RID: 2772
		' (get) Token: 0x06001BBC RID: 7100 RVA: 0x00102D7E File Offset: 0x00100F7E
		' (set) Token: 0x06001BBD RID: 7101 RVA: 0x00102D88 File Offset: 0x00100F88
		Friend Overridable Property lblRemarks1 As Label

		' Token: 0x17000AD5 RID: 2773
		' (get) Token: 0x06001BBE RID: 7102 RVA: 0x00102D91 File Offset: 0x00100F91
		' (set) Token: 0x06001BBF RID: 7103 RVA: 0x00102D9B File Offset: 0x00100F9B
		Friend Overridable Property Panel4 As Panel

		' Token: 0x17000AD6 RID: 2774
		' (get) Token: 0x06001BC0 RID: 7104 RVA: 0x00102DA4 File Offset: 0x00100FA4
		' (set) Token: 0x06001BC1 RID: 7105 RVA: 0x00102DAE File Offset: 0x00100FAE
		Friend Overridable Property txtRemarksApproval As TextBox

		' Token: 0x17000AD7 RID: 2775
		' (get) Token: 0x06001BC2 RID: 7106 RVA: 0x00102DB7 File Offset: 0x00100FB7
		' (set) Token: 0x06001BC3 RID: 7107 RVA: 0x00102DC1 File Offset: 0x00100FC1
		Friend Overridable Property txtRemarks As TextBox

		' Token: 0x17000AD8 RID: 2776
		' (get) Token: 0x06001BC4 RID: 7108 RVA: 0x00102DCA File Offset: 0x00100FCA
		' (set) Token: 0x06001BC5 RID: 7109 RVA: 0x00102DD4 File Offset: 0x00100FD4
		Friend Overridable Property lblRemarks As Label
			<CompilerGenerated()>
			Get
				Return Me._lblRemarks
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim eventHandler As EventHandler = AddressOf Me.lblRemarks_Click
				Dim label As Label = Me._lblRemarks
				If label IsNot Nothing Then
					RemoveHandler label.Click, eventHandler
				End If
				Me._lblRemarks = value
				label = Me._lblRemarks
				If label IsNot Nothing Then
					AddHandler label.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000AD9 RID: 2777
		' (get) Token: 0x06001BC6 RID: 7110 RVA: 0x00102E17 File Offset: 0x00101017
		' (set) Token: 0x06001BC7 RID: 7111 RVA: 0x00102E24 File Offset: 0x00101024
		Friend Overridable Property lblRemarksApproval As Label
			<CompilerGenerated()>
			Get
				Return Me._lblRemarksApproval
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim eventHandler As EventHandler = AddressOf Me.lblRemarksApproval_Click
				Dim label As Label = Me._lblRemarksApproval
				If label IsNot Nothing Then
					RemoveHandler label.Click, eventHandler
				End If
				Me._lblRemarksApproval = value
				label = Me._lblRemarksApproval
				If label IsNot Nothing Then
					AddHandler label.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000ADA RID: 2778
		' (get) Token: 0x06001BC8 RID: 7112 RVA: 0x00102E67 File Offset: 0x00101067
		' (set) Token: 0x06001BC9 RID: 7113 RVA: 0x00102E74 File Offset: 0x00101074
		Friend Overridable Property chkAll As CheckBox
			<CompilerGenerated()>
			Get
				Return Me._chkAll
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim eventHandler As EventHandler = AddressOf Me.chkAll_CheckedChanged
				Dim checkBox As CheckBox = Me._chkAll
				If checkBox IsNot Nothing Then
					RemoveHandler checkBox.CheckedChanged, eventHandler
				End If
				Me._chkAll = value
				checkBox = Me._chkAll
				If checkBox IsNot Nothing Then
					AddHandler checkBox.CheckedChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000ADB RID: 2779
		' (get) Token: 0x06001BCA RID: 7114 RVA: 0x00102EB7 File Offset: 0x001010B7
		' (set) Token: 0x06001BCB RID: 7115 RVA: 0x00102EC1 File Offset: 0x001010C1
		Friend Overridable Property txtNotes As TextBox

		' Token: 0x17000ADC RID: 2780
		' (get) Token: 0x06001BCC RID: 7116 RVA: 0x00102ECA File Offset: 0x001010CA
		' (set) Token: 0x06001BCD RID: 7117 RVA: 0x00102ED4 File Offset: 0x001010D4
		Friend Overridable Property Label3 As Label

		' Token: 0x17000ADD RID: 2781
		' (get) Token: 0x06001BCE RID: 7118 RVA: 0x00102EDD File Offset: 0x001010DD
		' (set) Token: 0x06001BCF RID: 7119 RVA: 0x00102EE7 File Offset: 0x001010E7
		Friend Overridable Property txtConcentration As TextBox

		' Token: 0x17000ADE RID: 2782
		' (get) Token: 0x06001BD0 RID: 7120 RVA: 0x00102EF0 File Offset: 0x001010F0
		' (set) Token: 0x06001BD1 RID: 7121 RVA: 0x00102EFA File Offset: 0x001010FA
		Friend Overridable Property lbl1 As Label

		' Token: 0x17000ADF RID: 2783
		' (get) Token: 0x06001BD2 RID: 7122 RVA: 0x00102F03 File Offset: 0x00101103
		' (set) Token: 0x06001BD3 RID: 7123 RVA: 0x00102F0D File Offset: 0x0010110D
		Friend Overridable Property txtTitre As TextBox

		' Token: 0x17000AE0 RID: 2784
		' (get) Token: 0x06001BD4 RID: 7124 RVA: 0x00102F16 File Offset: 0x00101116
		' (set) Token: 0x06001BD5 RID: 7125 RVA: 0x00102F20 File Offset: 0x00101120
		Friend Overridable Property lbl2 As Label

		' Token: 0x17000AE1 RID: 2785
		' (get) Token: 0x06001BD6 RID: 7126 RVA: 0x00102F29 File Offset: 0x00101129
		' (set) Token: 0x06001BD7 RID: 7127 RVA: 0x00102F34 File Offset: 0x00101134
		Friend Overridable Property skip_lblStatus As Label
			<CompilerGenerated()>
			Get
				Return Me._skip_lblStatus
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim eventHandler As EventHandler = AddressOf Me.skip_lblStatus_TextChanged
				Dim label As Label = Me._skip_lblStatus
				If label IsNot Nothing Then
					RemoveHandler label.TextChanged, eventHandler
				End If
				Me._skip_lblStatus = value
				label = Me._skip_lblStatus
				If label IsNot Nothing Then
					AddHandler label.TextChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000AE2 RID: 2786
		' (get) Token: 0x06001BD8 RID: 7128 RVA: 0x00102F77 File Offset: 0x00101177
		' (set) Token: 0x06001BD9 RID: 7129 RVA: 0x00102F81 File Offset: 0x00101181
		Friend Overridable Property txtGRNItemsID As TextBox

		' Token: 0x17000AE3 RID: 2787
		' (get) Token: 0x06001BDA RID: 7130 RVA: 0x00102F8A File Offset: 0x0010118A
		' (set) Token: 0x06001BDB RID: 7131 RVA: 0x00102F94 File Offset: 0x00101194
		Friend Overridable Property Label8 As Label

		' Token: 0x17000AE4 RID: 2788
		' (get) Token: 0x06001BDC RID: 7132 RVA: 0x00102F9D File Offset: 0x0010119D
		' (set) Token: 0x06001BDD RID: 7133 RVA: 0x00102FA7 File Offset: 0x001011A7
		Friend Overridable Property txtCatalogNo As TextBox

		' Token: 0x17000AE5 RID: 2789
		' (get) Token: 0x06001BDE RID: 7134 RVA: 0x00102FB0 File Offset: 0x001011B0
		' (set) Token: 0x06001BDF RID: 7135 RVA: 0x00102FBA File Offset: 0x001011BA
		Friend Overridable Property Label6 As Label

		' Token: 0x17000AE6 RID: 2790
		' (get) Token: 0x06001BE0 RID: 7136 RVA: 0x00102FC3 File Offset: 0x001011C3
		' (set) Token: 0x06001BE1 RID: 7137 RVA: 0x00102FCD File Offset: 0x001011CD
		Friend Overridable Property txtSpecificationNo As TextBox

		' Token: 0x17000AE7 RID: 2791
		' (get) Token: 0x06001BE2 RID: 7138 RVA: 0x00102FD6 File Offset: 0x001011D6
		' (set) Token: 0x06001BE3 RID: 7139 RVA: 0x00102FE0 File Offset: 0x001011E0
		Friend Overridable Property Label7 As Label

		' Token: 0x17000AE8 RID: 2792
		' (get) Token: 0x06001BE4 RID: 7140 RVA: 0x00102FE9 File Offset: 0x001011E9
		' (set) Token: 0x06001BE5 RID: 7141 RVA: 0x00102FF4 File Offset: 0x001011F4
		Friend Overridable Property cmbBatch As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbBatch
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbBatch_Validated
				Dim comboBox As ComboBox = Me._cmbBatch
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.Validated, eventHandler
				End If
				Me._cmbBatch = value
				comboBox = Me._cmbBatch
				If comboBox IsNot Nothing Then
					AddHandler comboBox.Validated, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000AE9 RID: 2793
		' (get) Token: 0x06001BE6 RID: 7142 RVA: 0x00103037 File Offset: 0x00101237
		' (set) Token: 0x06001BE7 RID: 7143 RVA: 0x00103041 File Offset: 0x00101241
		Friend Overridable Property txtReference As TextBox

		' Token: 0x17000AEA RID: 2794
		' (get) Token: 0x06001BE8 RID: 7144 RVA: 0x0010304A File Offset: 0x0010124A
		' (set) Token: 0x06001BE9 RID: 7145 RVA: 0x00103054 File Offset: 0x00101254
		Friend Overridable Property Label5 As Label

		' Token: 0x17000AEB RID: 2795
		' (get) Token: 0x06001BEA RID: 7146 RVA: 0x0010305D File Offset: 0x0010125D
		' (set) Token: 0x06001BEB RID: 7147 RVA: 0x00103068 File Offset: 0x00101268
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

		' Token: 0x17000AEC RID: 2796
		' (get) Token: 0x06001BEC RID: 7148 RVA: 0x001030AB File Offset: 0x001012AB
		' (set) Token: 0x06001BED RID: 7149 RVA: 0x001030B5 File Offset: 0x001012B5
		Friend Overridable Property Label10 As Label

		' Token: 0x17000AED RID: 2797
		' (get) Token: 0x06001BEE RID: 7150 RVA: 0x001030BE File Offset: 0x001012BE
		' (set) Token: 0x06001BEF RID: 7151 RVA: 0x001030C8 File Offset: 0x001012C8
		Friend Overridable Property txtProductType As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtProductType
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim eventHandler As EventHandler = AddressOf Me.txtProductType_TextChanged
				Dim textBox As TextBox = Me._txtProductType
				If textBox IsNot Nothing Then
					RemoveHandler textBox.TextChanged, eventHandler
				End If
				Me._txtProductType = value
				textBox = Me._txtProductType
				If textBox IsNot Nothing Then
					AddHandler textBox.TextChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000AEE RID: 2798
		' (get) Token: 0x06001BF0 RID: 7152 RVA: 0x0010310B File Offset: 0x0010130B
		' (set) Token: 0x06001BF1 RID: 7153 RVA: 0x00103118 File Offset: 0x00101318
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

		' Token: 0x17000AEF RID: 2799
		' (get) Token: 0x06001BF2 RID: 7154 RVA: 0x0010315B File Offset: 0x0010135B
		' (set) Token: 0x06001BF3 RID: 7155 RVA: 0x00103168 File Offset: 0x00101368
		Friend Overridable Property llbSave As LinkLabel
			<CompilerGenerated()>
			Get
				Return Me._llbSave
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim linkLabelLinkClickedEventHandler As LinkLabelLinkClickedEventHandler = AddressOf Me.llbSave_LinkClicked
				Dim linkLabel As LinkLabel = Me._llbSave
				If linkLabel IsNot Nothing Then
					RemoveHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
				Me._llbSave = value
				linkLabel = Me._llbSave
				If linkLabel IsNot Nothing Then
					AddHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000AF0 RID: 2800
		' (get) Token: 0x06001BF4 RID: 7156 RVA: 0x001031AB File Offset: 0x001013AB
		' (set) Token: 0x06001BF5 RID: 7157 RVA: 0x001031B5 File Offset: 0x001013B5
		Friend Overridable Property Label12 As Label

		' Token: 0x17000AF1 RID: 2801
		' (get) Token: 0x06001BF6 RID: 7158 RVA: 0x001031BE File Offset: 0x001013BE
		' (set) Token: 0x06001BF7 RID: 7159 RVA: 0x001031C8 File Offset: 0x001013C8
		Friend Overridable Property txtPrimaryPackSize As TextBox

		' Token: 0x17000AF2 RID: 2802
		' (get) Token: 0x06001BF8 RID: 7160 RVA: 0x001031D1 File Offset: 0x001013D1
		' (set) Token: 0x06001BF9 RID: 7161 RVA: 0x001031DB File Offset: 0x001013DB
		Friend Overridable Property SrNo As DataGridViewTextBoxColumn

		' Token: 0x17000AF3 RID: 2803
		' (get) Token: 0x06001BFA RID: 7162 RVA: 0x001031E4 File Offset: 0x001013E4
		' (set) Token: 0x06001BFB RID: 7163 RVA: 0x001031EE File Offset: 0x001013EE
		Friend Overridable Property ProductID As DataGridViewTextBoxColumn

		' Token: 0x17000AF4 RID: 2804
		' (get) Token: 0x06001BFC RID: 7164 RVA: 0x001031F7 File Offset: 0x001013F7
		' (set) Token: 0x06001BFD RID: 7165 RVA: 0x00103201 File Offset: 0x00101401
		Friend Overridable Property GRNItemsID As DataGridViewTextBoxColumn

		' Token: 0x17000AF5 RID: 2805
		' (get) Token: 0x06001BFE RID: 7166 RVA: 0x0010320A File Offset: 0x0010140A
		' (set) Token: 0x06001BFF RID: 7167 RVA: 0x00103214 File Offset: 0x00101414
		Friend Overridable Property BatchNo As DataGridViewTextBoxColumn

		' Token: 0x17000AF6 RID: 2806
		' (get) Token: 0x06001C00 RID: 7168 RVA: 0x0010321D File Offset: 0x0010141D
		' (set) Token: 0x06001C01 RID: 7169 RVA: 0x00103227 File Offset: 0x00101427
		Friend Overridable Property PrimaryPackSize As DataGridViewTextBoxColumn

		' Token: 0x17000AF7 RID: 2807
		' (get) Token: 0x06001C02 RID: 7170 RVA: 0x00103230 File Offset: 0x00101430
		' (set) Token: 0x06001C03 RID: 7171 RVA: 0x0010323A File Offset: 0x0010143A
		Friend Overridable Property Specification As DataGridViewTextBoxColumn

		' Token: 0x17000AF8 RID: 2808
		' (get) Token: 0x06001C04 RID: 7172 RVA: 0x00103243 File Offset: 0x00101443
		' (set) Token: 0x06001C05 RID: 7173 RVA: 0x0010324D File Offset: 0x0010144D
		Friend Overridable Property AcceptanceCriteria As DataGridViewTextBoxColumn

		' Token: 0x17000AF9 RID: 2809
		' (get) Token: 0x06001C06 RID: 7174 RVA: 0x00103256 File Offset: 0x00101456
		' (set) Token: 0x06001C07 RID: 7175 RVA: 0x00103260 File Offset: 0x00101460
		Friend Overridable Property Complies As DataGridViewComboBoxColumn

		' Token: 0x17000AFA RID: 2810
		' (get) Token: 0x06001C08 RID: 7176 RVA: 0x00103269 File Offset: 0x00101469
		' (set) Token: 0x06001C09 RID: 7177 RVA: 0x00103273 File Offset: 0x00101473
		Friend Overridable Property txtCellCount As TextBox

		' Token: 0x17000AFB RID: 2811
		' (get) Token: 0x06001C0A RID: 7178 RVA: 0x0010327C File Offset: 0x0010147C
		' (set) Token: 0x06001C0B RID: 7179 RVA: 0x00103286 File Offset: 0x00101486
		Friend Overridable Property txtPassageNo As TextBox

		' Token: 0x17000AFC RID: 2812
		' (get) Token: 0x06001C0C RID: 7180 RVA: 0x0010328F File Offset: 0x0010148F
		' (set) Token: 0x06001C0D RID: 7181 RVA: 0x00103299 File Offset: 0x00101499
		Friend Overridable Property txtODPermL As TextBox

		' Token: 0x06001C0E RID: 7182
		Private Declare Sub SendMessage Lib "user32.DLL" (hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

		' Token: 0x06001C0F RID: 7183
		Private Declare Sub ReleaseCapture Lib "user32.DLL" ()

		' Token: 0x06001C10 RID: 7184 RVA: 0x001032A2 File Offset: 0x001014A2
		Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs)
			QCRelease01.ReleaseCapture()
			QCRelease01.SendMessage(MyBase.Handle, 274, 61458, 0)
		End Sub

		' Token: 0x06001C11 RID: 7185 RVA: 0x001032C4 File Offset: 0x001014C4
		Public Sub New(FormType As String, dr As DataRow)
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			AddHandler MyBase.Shown, AddressOf Me.Me_Shown
			Me.InitializeComponent()
			Designing.SetTheme(Me)
			Me.Text = FormType
			Me.picFormIcon.Image = ResourceModule.imgFormIconPic
			MyBase.FormBorderStyle = FormBorderStyle.None
			Me.BackColor = Color.DarkGray
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.lblCaption.Text = Me.Text
			Me.form_btnClose.DialogResult = DialogResult.Cancel
			Me.sFormType = FormType
			Me.drData = dr
		End Sub

		' Token: 0x06001C12 RID: 7186 RVA: 0x0010338A File Offset: 0x0010158A
		Private Sub form_btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06001C13 RID: 7187 RVA: 0x00103394 File Offset: 0x00101594
		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x06001C14 RID: 7188 RVA: 0x001033C9 File Offset: 0x001015C9
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Me.FillData()
			Me.SetForm()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x06001C15 RID: 7189 RVA: 0x001033F1 File Offset: 0x001015F1
		Private Sub Me_Shown(sender As Object, e As EventArgs)
			Me.SetTabs()
		End Sub

		' Token: 0x06001C16 RID: 7190 RVA: 0x001033FC File Offset: 0x001015FC
		Private Sub SetTabs()
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = CInt(Math.Round(CDbl((Me.theme_tc.Width - 5)) / 3.0))
			Me.theme_tc.ItemSize = New Size(num, 30)
			Me.tab_lbl1.Width = num
			Me.tab_lbl2.Width = num + 3
			Me.tab_lbl3.Width = num + 3
			Me.tab_lbl1.Location = New Point(0, 0)
			Me.tab_lbl2.Location = New Point(num - 4, 0)
			Me.tab_lbl3.Location = New Point(num * 2 - 4, 0)
			Me.flpButton.Left = CInt(Math.Round(CDbl(MyBase.Width) / 2.0 - CDbl(Me.flpButton.Width) / 2.0))
		End Sub

		' Token: 0x06001C17 RID: 7191 RVA: 0x001034E4 File Offset: 0x001016E4
		Private Sub SetForm()
			Dim text As String = Me.sFormType
			If Operators.CompareString(text, "GRN QC Entry", False) <> 0 Then
				If Operators.CompareString(text, "GRN QC Release", False) <> 0 Then
					If Operators.CompareString(text, "GRN QA Release", False) = 0 Then
						Me.txtSpecificationNo.[ReadOnly] = True
						Me.llbSave.Visible = True
						Me.chkAll.Visible = False
						Me.btnSave.Visible = False
						Me.flpButton.Width = (Me.btnApprove.Width + 2) * 6 - Me.btnApprove.Width * 1
					End If
				Else
					Me.txtSpecificationNo.[ReadOnly] = True
					Me.llbFile.Enabled = False
					Me.chkAll.Visible = False
					Me.btnSave.Visible = False
					Me.flpButton.Width = (Me.btnApprove.Width + 2) * 6 - Me.btnApprove.Width * 1
				End If
			Else
				Me.btnApprove.Visible = False
				Me.btnOnHold.Visible = False
				Me.btnReject.Visible = False
				Me.btnPrint.Visible = False
				Me.flpButton.Width = (Me.btnApprove.Width + 2) * 6 - Me.btnApprove.Width * 4
			End If
			Me.flpButton.Left = CInt(Math.Round(CDbl(MyBase.Width) / 2.0 - CDbl(Me.flpButton.Width) / 2.0 - 18.0))
		End Sub

		' Token: 0x06001C18 RID: 7192 RVA: 0x00103694 File Offset: 0x00101894
		Private Sub FillData()
			Try
				Me.sEmailTo = GlobalVariables.gsEmailID
				Dim flag As Boolean = Not Information.IsNothing(Me.drData)
				If flag Then
					Me.btnSave.Enabled = False
					Me.btnApprove.Enabled = False
					Me.btnOnHold.Enabled = False
					Me.btnReject.Enabled = False
					Me.btnPrint.Enabled = False
					Me.txtID.Text = Conversions.ToString(Me.drData("GRNID"))
					Me.txtGRNItemsID.Text = Conversions.ToString(Me.drData("GRNItemsID"))
					Me.txtPOID.Text = Me.drData("POID").ToString()
					Me.txtNo.Text = Conversions.ToString(Me.drData("GRNNo"))
					Me.dtpDt.Value = Conversions.ToDate(Me.drData("GRNDt"))
					Me.txtVendor.Text = Conversions.ToString(Me.drData("VendorName"))
					Me.txtPOType.Text = Me.drData("POType").ToString()
					Me.txtPONo.Text = Me.drData("PONo").ToString()
					Dim flag2 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.drData("PODt")))
					If flag2 Then
						Me.dtpPODt.Value = Conversions.ToDate(Me.drData("PODt"))
						Me.dtpPODt.Checked = True
					Else
						Me.dtpPODt.Value = DateAndTime.Now
						Me.dtpPODt.Checked = False
					End If
					Me.FillGRNItems()
					Me.FillItemSpecification()
					Dim flag3 As Boolean = Me.drData.Table.Columns.Contains("ProductCode")
					If flag3 Then
						Me.txtPrimaryPackSize.Text = Conversions.ToString(Me.drData("PrimaryPackSize"))
						Me.cmbProduct.SelectedValue = RuntimeHelpers.GetObjectValue(Me.drData("ProductID"))
						Me.cmbProduct_Validated(Nothing, Nothing)
						Me.cmbBatch.SelectedValue = RuntimeHelpers.GetObjectValue(Me.drData("BatchNo"))
						Me.cmbBatch_Validated(Nothing, Nothing)
						Me.cmbProduct.Enabled = False
						Me.cmbBatch.Enabled = False
					End If
					Dim flag4 As Boolean = Operators.CompareString(Me.skip_lblStatus.Text, "In QC Release", False) = 0
					If flag4 Then
						Me.dtFile = FileAttachments.FillFileAttachments("GRN", Me.txtID.Text)
					End If
					Dim flag5 As Boolean = Not Information.IsNothing(Me.dtFile)
					If flag5 Then
						Dim dataTable As DataTable = FileAttachments.FillFileAttachments("QC Entry", Me.txtGRNItemsID.Text)
						Me.dtFile.Merge(dataTable)
					Else
						Me.dtFile = FileAttachments.FillFileAttachments("QC Entry", Me.txtGRNItemsID.Text)
					End If
					FileAttachments.SetFileDatagridview(Me.dtFile, Me.dgvFile)
					Me.dtFile_Old = Me.dtFile.Copy()
					Dim flag6 As Boolean = (Operators.CompareString(Me.drData("CreatedByEmailID").ToString(), "", False) <> 0) And (Operators.CompareString(Me.drData("CreatedByEmailID").ToString(), GlobalVariables.gsEmailID, False) <> 0)
					If flag6 Then
						Dim ptr As __ByRef(Of String) = Me.sEmailTo
						Me.sEmailTo = ptr + ":" + Me.drData("CreatedByEmailID").ToString()
					End If
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06001C19 RID: 7193 RVA: 0x00103AC0 File Offset: 0x00101CC0
		Private Sub FillGRNItems()
			Dim text As String = " SELECT GI.ProductID, P.ProductType, GI.SpecificationNo, P.Reference, P.CatalogNo, " & vbCrLf
			text += " P.ProductName, P.ProductCode, GI.Description, P.HSNSACCode, GI.BMRNo, GI.BatchNo, GI.MfgDt, GI.ExpDt, " & vbCrLf
			text += " P.TertiaryUOM, GI.TertiaryPackSize, P.PrimaryUOM, GI.PrimaryPackSize, " & vbCrLf
			text += " GI.ReceivedQty, GI.UnitPrice, GI.GSTPer, GI.BasicValue, GI.LandingCost, GI.TotalCost, " & vbCrLf
			text += " GI.IsQCApplicable, GI.IsParentApplicable, GI.IsUnitsEditable, GI.Status, GI.Remarks, GI.QCActionRemarks, " & vbCrLf
			text += " GI.FinalConcentration, GI.Titre, GI.Notes, GI.CellCount, GI.PassageNo, GI.ODPermL "
			text += " FROM GRNItems AS GI " & vbCrLf
			text += " INNER JOIN Product AS P ON GI.ProductID = P.ProductID" & vbCrLf
			text = text + " WHERE GRNID = '" + Me.txtID.Text + "' AND P.IsQCApplicable = 1" & vbCrLf
			text += " ORDER BY ProductName, BatchNo "
			Me.dtItems = MainModule.GetData(text)
			Dim dataTable As DataTable = Me.dtItems.DefaultView.ToTable(True, New String() { "ProductID", "ProductName" })
			dataTable.Rows.InsertAt(dataTable.NewRow(), 0)
			Me.cmbProduct.ValueMember = "ProductID"
			Me.cmbProduct.DisplayMember = "ProductName"
			Me.cmbProduct.DataSource = dataTable
			Me.cmbProduct.SelectedIndex = 0
		End Sub

		' Token: 0x06001C1A RID: 7194 RVA: 0x00103BD4 File Offset: 0x00101DD4
		Private Sub FillItemSpecification()
			Dim dataTable As DataTable = New DataTable()
			Dim text As String = " SELECT PD.ProductID, GI.GRNItemsID, GI.BatchNo, GI.PrimaryPackSize, Specification, AcceptanceCriteria, '' AS Complies " & vbCrLf
			text += " FROM ProductDtls AS PD  " & vbCrLf
			text += " INNER JOIN GRNItems GI ON PD.ProductID = GI.ProductID " & vbCrLf
			text = text + " WHERE GI.GRNID = '" + Me.txtID.Text + "'"
			Dim data As DataTable = MainModule.GetData(text)
			text = " SELECT GI.ProductID, GI.GRNItemsID, GI.BatchNo, GI.PrimaryPackSize, GIQ.Specification, GIQ.AcceptanceCriteria, GIQ.Complies " & vbCrLf
			text += " FROM GRNItems AS GI INNER JOIN " & vbCrLf
			text += " GRNItemsQC AS GIQ ON GI.GRNItemsID = GIQ.GRNItemsID " & vbCrLf
			text = text + " WHERE GI.GRNID = '" + Me.txtID.Text + "' " & vbCrLf
			Dim data2 As DataTable = MainModule.GetData(text)
			dataTable.Columns.Add("SrNo", Type.[GetType]("System.Int32"))
			dataTable.Columns.Add("ProductID", Type.[GetType]("System.Int32"))
			dataTable.Columns.Add("GRNItemsID", Type.[GetType]("System.Int32"))
			dataTable.Columns.Add("BatchNo", Type.[GetType]("System.String"))
			dataTable.Columns.Add("PrimaryPackSize", Type.[GetType]("System.String"))
			dataTable.Columns.Add("Specification", Type.[GetType]("System.String"))
			dataTable.Columns.Add("AcceptanceCriteria", Type.[GetType]("System.String"))
			dataTable.Columns.Add("Complies", Type.[GetType]("System.String"))
			Me.dtSpec = dataTable
			Me.dtSpecTemp = Me.dtSpec.Clone()
			Dim num As Integer = Me.dtItems.Rows.Count - 1
			For i As Integer = 0 To num
				Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" ProductID = '", Me.dtItems.Rows(i)("ProductID")), "' AND BatchNo = '"), Me.dtItems.Rows(i)("BatchNo")), "'"))
				text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" AND PrimaryPackSize = '", Me.dtItems.Rows(i)("PrimaryPackSize")), "'")))
				Dim array As DataRow() = data2.[Select](text2)
				Dim flag As Boolean = array.Length > 0
				If flag Then
					Dim num2 As Integer = array.Length - 1
					For j As Integer = 0 To num2
						Me.dtSpec.Rows.Add(New Object(-1) {})
						Me.dtSpec.Rows(Me.dtSpec.Rows.Count - 1)("SrNo") = Me.dtSpec.Rows.Count
						Me.dtSpec.Rows(Me.dtSpec.Rows.Count - 1)("ProductID") = RuntimeHelpers.GetObjectValue(array(j)("ProductID"))
						Me.dtSpec.Rows(Me.dtSpec.Rows.Count - 1)("GRNItemsID") = RuntimeHelpers.GetObjectValue(array(j)("GRNItemsID"))
						Me.dtSpec.Rows(Me.dtSpec.Rows.Count - 1)("BatchNo") = RuntimeHelpers.GetObjectValue(array(j)("BatchNo"))
						Me.dtSpec.Rows(Me.dtSpec.Rows.Count - 1)("PrimaryPackSize") = RuntimeHelpers.GetObjectValue(array(j)("PrimaryPackSize"))
						Me.dtSpec.Rows(Me.dtSpec.Rows.Count - 1)("Specification") = RuntimeHelpers.GetObjectValue(array(j)("Specification"))
						Me.dtSpec.Rows(Me.dtSpec.Rows.Count - 1)("AcceptanceCriteria") = RuntimeHelpers.GetObjectValue(array(j)("AcceptanceCriteria"))
						Me.dtSpec.Rows(Me.dtSpec.Rows.Count - 1)("Complies") = RuntimeHelpers.GetObjectValue(array(j)("Complies"))
					Next
				Else
					Dim flag2 As Boolean = Operators.ConditionalCompareObjectNotEqual(Me.drData("Item_Status"), "Batch Released", False)
					If flag2 Then
						Dim array2 As DataRow() = data.[Select](text2)
						Dim num3 As Integer = array2.Length - 1
						For k As Integer = 0 To num3
							Me.dtSpec.Rows.Add(New Object(-1) {})
							Me.dtSpec.Rows(Me.dtSpec.Rows.Count - 1)("SrNo") = Me.dtSpec.Rows.Count
							Me.dtSpec.Rows(Me.dtSpec.Rows.Count - 1)("ProductID") = RuntimeHelpers.GetObjectValue(array2(k)("ProductID"))
							Me.dtSpec.Rows(Me.dtSpec.Rows.Count - 1)("GRNItemsID") = RuntimeHelpers.GetObjectValue(array2(k)("GRNItemsID"))
							Me.dtSpec.Rows(Me.dtSpec.Rows.Count - 1)("BatchNo") = RuntimeHelpers.GetObjectValue(array2(k)("BatchNo"))
							Me.dtSpec.Rows(Me.dtSpec.Rows.Count - 1)("PrimaryPackSize") = RuntimeHelpers.GetObjectValue(array2(k)("PrimaryPackSize"))
							Me.dtSpec.Rows(Me.dtSpec.Rows.Count - 1)("Specification") = RuntimeHelpers.GetObjectValue(array2(k)("Specification"))
							Me.dtSpec.Rows(Me.dtSpec.Rows.Count - 1)("AcceptanceCriteria") = RuntimeHelpers.GetObjectValue(array2(k)("AcceptanceCriteria"))
							Me.dtSpec.Rows(Me.dtSpec.Rows.Count - 1)("Complies") = RuntimeHelpers.GetObjectValue(array2(k)("Complies"))
						Next
					End If
				End If
			Next
		End Sub

		' Token: 0x06001C1B RID: 7195 RVA: 0x001042F8 File Offset: 0x001024F8
		Private Sub skip_lblStatus_TextChanged(sender As Object, e As EventArgs)
			Dim text As String = Me.skip_lblStatus.Text
			Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(text)
			If num <= 1651035093UI Then
				If num <= 1155551934UI Then
					If num <> 850678000UI Then
						If num <> 1155551934UI Then
							GoTo IL_06A3
						End If
						If Operators.CompareString(text, "QA On-Hold", False) <> 0 Then
							GoTo IL_06A3
						End If
					ElseIf Operators.CompareString(text, "QC On-Hold", False) <> 0 Then
						GoTo IL_06A3
					End If
				ElseIf num <> 1586596451UI Then
					If num <> 1651035093UI Then
						GoTo IL_06A3
					End If
					If Operators.CompareString(text, "QC Rejected", False) <> 0 Then
						GoTo IL_06A3
					End If
					GoTo IL_05E6
				ElseIf Operators.CompareString(text, "In QC Release", False) <> 0 Then
					GoTo IL_06A3
				End If
				Me.btnSave.Enabled = True
				Me.btnApprove.Enabled = False
				Me.btnOnHold.Enabled = False
				Me.btnReject.Enabled = False
				Me.btnPrint.Enabled = False
				Dim flag As Boolean = Operators.CompareString(Me.sFormType, "GRN QC Entry", False) = 0
				If flag Then
					Me.txtRemarks.[ReadOnly] = False
					Dim text2 As String = Me.txtProductType.Text
					If Operators.CompareString(text2, "Semi Finished", False) <> 0 AndAlso Operators.CompareString(text2, "Cell Bank - Mammalian", False) <> 0 AndAlso Operators.CompareString(text2, "Cell Bank - Bacterial", False) <> 0 Then
						Me.txtConcentration.[ReadOnly] = True
						Me.txtTitre.[ReadOnly] = True
						Me.txtNotes.[ReadOnly] = True
					Else
						Me.txtConcentration.[ReadOnly] = False
						Me.txtTitre.[ReadOnly] = False
						Me.txtNotes.[ReadOnly] = False
					End If
				Else
					Me.txtRemarks.[ReadOnly] = True
					Me.txtConcentration.[ReadOnly] = True
					Me.txtTitre.[ReadOnly] = True
					Me.txtNotes.[ReadOnly] = True
				End If
				Dim flag2 As Boolean = Operators.CompareString(Me.sFormType, "GRN QC Entry", False) = 0
				If flag2 Then
					Me.dgvFile.Columns("btnDelete_File").Visible = True
				Else
					Me.dgvDtls.Columns("Complies").[ReadOnly] = True
					Me.dgvFile.Columns("btnDelete_File").Visible = False
				End If
				Return
			End If
			If num <= 2321015623UI Then
				If num <> 2166136261UI Then
					If num <> 2321015623UI Then
						GoTo IL_06A3
					End If
					If Operators.CompareString(text, "QA Rejected", False) <> 0 Then
						GoTo IL_06A3
					End If
				ElseIf Operators.CompareString(text, "", False) <> 0 Then
					GoTo IL_06A3
				End If
			ElseIf num <> 2975576722UI Then
				If num <> 3131873682UI Then
					If num <> 3507303272UI Then
						GoTo IL_06A3
					End If
					If Operators.CompareString(text, "QC Approved", False) <> 0 Then
						GoTo IL_06A3
					End If
					Me.chkAll.Enabled = False
					Me.txtRemarks.[ReadOnly] = True
					Me.txtConcentration.[ReadOnly] = True
					Me.txtTitre.[ReadOnly] = True
					Me.txtNotes.[ReadOnly] = True
					Me.btnSave.Enabled = False
					Me.btnApprove.Enabled = True
					Me.btnOnHold.Enabled = True
					Me.btnReject.Enabled = True
					Me.btnPrint.Enabled = False
					Me.dgvDtls.Columns("Complies").[ReadOnly] = True
					Dim flag3 As Boolean = Operators.CompareString(Me.sFormType, "GRN QA Release", False) = 0
					If flag3 Then
						Me.dgvFile.Columns("btnDelete_File").Visible = True
					Else
						Me.dgvFile.Columns("btnDelete_File").Visible = False
					End If
					Return
				Else
					If Operators.CompareString(text, "Batch Released", False) <> 0 Then
						GoTo IL_06A3
					End If
					Me.chkAll.Enabled = False
					Me.txtRemarks.[ReadOnly] = True
					Me.txtConcentration.[ReadOnly] = True
					Me.txtTitre.[ReadOnly] = True
					Me.txtNotes.[ReadOnly] = True
					Me.btnSave.Enabled = False
					Me.btnApprove.Enabled = False
					Me.btnOnHold.Enabled = False
					Me.btnReject.Enabled = False
					Me.btnPrint.Enabled = True
					Me.dgvDtls.Columns("Complies").[ReadOnly] = True
					Me.dgvFile.Columns("btnDelete_File").Visible = False
					Return
				End If
			Else
				If Operators.CompareString(text, "QC Saved", False) <> 0 Then
					GoTo IL_06A3
				End If
				Dim flag4 As Boolean = Operators.CompareString(Me.sFormType, "GRN QC Release", False) = 0
				If flag4 Then
					Me.txtRemarks.[ReadOnly] = True
					Me.txtConcentration.[ReadOnly] = True
					Me.txtTitre.[ReadOnly] = True
					Me.txtNotes.[ReadOnly] = True
					Me.btnSave.Enabled = False
				Else
					Me.btnSave.Enabled = True
				End If
				Me.btnApprove.Enabled = True
				Me.btnOnHold.Enabled = True
				Me.btnReject.Enabled = True
				Me.btnPrint.Enabled = False
				Dim flag5 As Boolean = Operators.CompareString(Me.sFormType, "GRN QC Entry", False) = 0
				If flag5 Then
					Me.dgvFile.Columns("btnDelete_File").Visible = True
				Else
					Me.dgvDtls.Columns("Complies").[ReadOnly] = True
					Me.dgvFile.Columns("btnDelete_File").Visible = False
				End If
				Return
			End If
			IL_05E6:
			Me.chkAll.Enabled = False
			Me.txtRemarks.[ReadOnly] = True
			Me.txtConcentration.[ReadOnly] = True
			Me.txtTitre.[ReadOnly] = True
			Me.txtNotes.[ReadOnly] = True
			Me.btnSave.Enabled = False
			Me.btnApprove.Enabled = False
			Me.btnOnHold.Enabled = False
			Me.btnReject.Enabled = False
			Me.btnPrint.Enabled = False
			Me.dgvDtls.Columns("Complies").[ReadOnly] = True
			Me.dgvFile.Columns("btnDelete_File").Visible = False
			Return
			IL_06A3:
			Me.chkAll.Enabled = False
			Me.btnPrint.Enabled = False
			Me.dgvDtls.Columns("Complies").[ReadOnly] = True
			Me.dgvFile.Columns("btnDelete_File").Visible = False
		End Sub

		' Token: 0x06001C1C RID: 7196 RVA: 0x001049FE File Offset: 0x00102BFE
		Private Sub lblFile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Me.dtFile = FileAttachments.AttachmentFile(Conversions.ToString(-1), Me.dtFile)
			FileAttachments.SetFileDatagridview(Me.dtFile, Me.dgvFile)
		End Sub

		' Token: 0x06001C1D RID: 7197 RVA: 0x00104A2C File Offset: 0x00102C2C
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
						Dim flag3 As Boolean = Operators.CompareString(Me.sFormType, "GRN QA Release", False) = 0
						If flag3 Then
							Dim flag4 As Boolean = Me.dtFile_Old.[Select]("FileID = '" + array(0)("FileID").ToString() + "'").Length = 0
							If flag4 Then
								Me.dtFile.Rows.Remove(array(0))
								FileAttachments.SetFileDatagridview(Me.dtFile, Me.dgvFile)
							End If
						Else
							Me.dtFile.Rows.Remove(array(0))
							FileAttachments.SetFileDatagridview(Me.dtFile, Me.dgvFile)
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x06001C1E RID: 7198 RVA: 0x00104BA4 File Offset: 0x00102DA4
		Private Sub llbSave_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Try
				Dim flag As Boolean = Me.dtFile.Rows.Count > Me.dtFile_Old.Rows.Count
				If flag Then
					FileAttachments.InsertFiles("QC Entry", Me.txtGRNItemsID.Text, Me.dtFile)
					Me.bCOA_Save = True
					CustomMsgBox.Show("Files Saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Else
					CustomMsgBox.Show("No File For COA Attached.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06001C1F RID: 7199 RVA: 0x00104C68 File Offset: 0x00102E68
		Private Sub cmbProduct_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbProduct.SelectedIndex > 0
			If flag Then
				Dim dataView As DataView = New DataView(Me.dtItems, Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("ProductID = '", Me.cmbProduct.SelectedValue), "'")), "ProductName", DataViewRowState.CurrentRows)
				Dim dataTable As DataTable = dataView.ToTable()
				dataTable.Rows.InsertAt(dataTable.NewRow(), 0)
				Me.cmbBatch.ValueMember = "BatchNo"
				Me.cmbBatch.DisplayMember = "BatchNo"
				Me.cmbBatch.DataSource = dataTable
				Me.cmbBatch.SelectedIndex = 0
			Else
				Me.cmbProduct.Text = ""
				Me.cmbBatch.Text = ""
				Me.cmbBatch.DataSource = Nothing
			End If
			Me.skip_lblStatus.Text = ""
			Me.txtRemarks.Text = ""
			Me.txtConcentration.Text = ""
			Me.txtTitre.Text = ""
			Me.txtNotes.Text = ""
			Me.txtRemarksApproval.Text = ""
			Me.txtProductType.Text = ""
			Me.txtSpecificationNo.Text = ""
			Me.txtReference.Text = ""
			Me.txtCatalogNo.Text = ""
			Me.dgvDtls.DataSource = Me.dtSpecTemp
		End Sub

		' Token: 0x06001C20 RID: 7200 RVA: 0x00104E08 File Offset: 0x00103008
		Private Sub cmbBatch_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = (Me.cmbBatch.SelectedIndex > 0) And (Me.cmbProduct.SelectedIndex > 0)
			If flag Then
				Dim text As String = ""
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("ProductID = '", Me.cmbProduct.SelectedValue), "' AND BatchNo = '"), Me.cmbBatch.Text), "'")))
				text = text + " AND PrimaryPackSize = '" + Me.txtPrimaryPackSize.Text + "' "
				Dim array As DataRow() = Me.dtItems.[Select](text)
				Dim flag2 As Boolean = array.Length > 0
				If flag2 Then
					Me.txtProductType.Text = array(0)("ProductType").ToString()
					Me.txtSpecificationNo.Text = array(0)("SpecificationNo").ToString()
					Me.txtReference.Text = array(0)("Reference").ToString()
					Me.txtCatalogNo.Text = array(0)("CatalogNo").ToString()
					Me.txtRemarks.Text = array(0)("Remarks").ToString()
					Me.txtRemarksApproval.Text = array(0)("QCActionRemarks").ToString()
					Me.txtConcentration.Text = array(0)("FinalConcentration").ToString()
					Me.txtTitre.Text = array(0)("Titre").ToString()
					Me.txtNotes.Text = array(0)("Notes").ToString()
					Me.txtCellCount.Text = array(0)("CellCount").ToString()
					Me.txtPassageNo.Text = array(0)("PassageNo").ToString()
					Me.txtODPermL.Text = array(0)("ODPermL").ToString()
					Me.skip_lblStatus.Text = Conversions.ToString(array(0)("Status"))
				Else
					Me.skip_lblStatus.Text = ""
					Me.txtRemarks.Text = ""
					Me.txtConcentration.Text = ""
					Me.txtTitre.Text = ""
					Me.txtNotes.Text = ""
					Me.txtRemarksApproval.Text = ""
					Me.txtProductType.Text = ""
					Me.txtSpecificationNo.Text = ""
					Me.txtReference.Text = ""
					Me.txtCatalogNo.Text = ""
				End If
				Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("ProductID = '", Me.cmbProduct.SelectedValue), "' AND BatchNo = '"), Me.cmbBatch.Text), "'"))
				text2 = text2 + " AND PrimaryPackSize = '" + Me.txtPrimaryPackSize.Text + "'"
				Dim dataView As DataView = New DataView(Me.dtSpec, text2, "ProductID", DataViewRowState.CurrentRows)
				Dim dataTable As DataTable = dataView.ToTable()
				Me.dgvDtls.DataSource = dataTable
			Else
				Me.cmbBatch.Text = ""
				Me.txtRemarks.Text = ""
				Me.txtConcentration.Text = ""
				Me.txtTitre.Text = ""
				Me.txtNotes.Text = ""
				Me.txtRemarksApproval.Text = ""
				Me.txtProductType.Text = ""
				Me.txtSpecificationNo.Text = ""
				Me.txtReference.Text = ""
				Me.txtCatalogNo.Text = ""
				Me.dgvDtls.DataSource = Me.dtSpecTemp
			End If
			Dim text3 As String = Me.txtProductType.Text
			If Operators.CompareString(text3, "Semi Finished", False) <> 0 Then
				If Operators.CompareString(text3, "Cell Bank - Mammalian", False) <> 0 Then
					If Operators.CompareString(text3, "Cell Bank - Bacterial", False) <> 0 Then
						Me.txtConcentration.[ReadOnly] = True
						Me.txtTitre.[ReadOnly] = True
						Me.txtNotes.[ReadOnly] = True
						Me.lbl1.Text = "Concentration"
						Me.lbl2.Text = "Titre"
						Me.txtConcentration.Visible = True
						Me.txtTitre.Visible = True
						Me.txtCellCount.Visible = False
						Me.txtPassageNo.Visible = False
						Me.txtODPermL.Visible = False
					Else
						Me.lbl1.Text = "OD/ mL"
						Me.lbl2.Text = ""
						Me.txtConcentration.Visible = False
						Me.txtTitre.Visible = False
						Me.txtCellCount.Visible = False
						Me.txtPassageNo.Visible = False
						Me.txtODPermL.Visible = True
					End If
				Else
					Me.lbl1.Text = "Cell Count"
					Me.lbl2.Text = "Passage No."
					Me.txtConcentration.Visible = False
					Me.txtTitre.Visible = False
					Me.txtCellCount.Visible = True
					Me.txtPassageNo.Visible = True
					Me.txtODPermL.Visible = False
				End If
			Else
				Dim flag3 As Boolean = Operators.CompareString(Me.sFormType, "GRN QC Entry", False) = 0
				If flag3 Then
					Dim text4 As String = Me.skip_lblStatus.Text
					If Operators.CompareString(text4, "In QC Release", False) = 0 OrElse Operators.CompareString(text4, "QC On-Hold", False) = 0 Then
						Me.txtConcentration.[ReadOnly] = False
						Me.txtTitre.[ReadOnly] = False
						Me.txtNotes.[ReadOnly] = False
					End If
				End If
				Me.lbl1.Text = "Concentration"
				Me.lbl2.Text = "Titre"
				Me.txtConcentration.Visible = True
				Me.txtTitre.Visible = True
				Me.txtCellCount.Visible = False
				Me.txtPassageNo.Visible = False
				Me.txtODPermL.Visible = False
			End If
			Dim flag4 As Boolean = Operators.CompareString(Me.txtRemarksApproval.Text, "", False) = 0
			If flag4 Then
				Me.lblRemarksApproval.Visible = False
			Else
				Me.lblRemarksApproval.Visible = True
			End If
			Me.lblRemarks_Click(Nothing, Nothing)
		End Sub

		' Token: 0x06001C21 RID: 7201 RVA: 0x0010550C File Offset: 0x0010370C
		Private Sub txtProductType_TextChanged(sender As Object, e As EventArgs)
			Dim text As String = Me.txtProductType.Text
			Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(text)
			If num <= 2424042855UI Then
				If num <= 1381572122UI Then
					If num <> 478348301UI Then
						If num <> 1381572122UI Then
							Return
						End If
						If Operators.CompareString(text, "Raw Material", False) <> 0 Then
							Return
						End If
					Else
						If Operators.CompareString(text, "Cell Bank - Mammalian", False) <> 0 Then
							Return
						End If
						GoTo IL_0209
					End If
				ElseIf num <> 1773852434UI Then
					If num <> 2166136261UI Then
						If num <> 2424042855UI Then
							Return
						End If
						If Operators.CompareString(text, "Semi Finished", False) <> 0 Then
							Return
						End If
						GoTo IL_0209
					ElseIf Operators.CompareString(text, "", False) <> 0 Then
						Return
					End If
				ElseIf Operators.CompareString(text, "Others", False) <> 0 Then
					Return
				End If
			ElseIf num <= 2982502317UI Then
				If num <> 2480381874UI Then
					If num <> 2982502317UI Then
						Return
					End If
					If Operators.CompareString(text, "Finished Goods", False) <> 0 Then
						Return
					End If
					GoTo IL_0209
				ElseIf Operators.CompareString(text, "Consumable", False) <> 0 Then
					Return
				End If
			ElseIf num <> 3057895172UI Then
				If num <> 3661748803UI Then
					If num <> 3955665341UI Then
						Return
					End If
					If Operators.CompareString(text, "Packaging Material", False) <> 0 Then
						Return
					End If
				Else
					If Operators.CompareString(text, "Cell Bank - Bacterial", False) <> 0 Then
						Return
					End If
					GoTo IL_0209
				End If
			ElseIf Operators.CompareString(text, "Service", False) <> 0 Then
				Return
			End If
			Me.cmbBatch.Width = 471
			Me.chkAll.Visible = True
			Me.dgvDtls.Columns("Specification").HeaderText = "Specification"
			Me.dgvDtls.Columns("AcceptanceCriteria").HeaderText = "Acceptance Criteria"
			Me.dgvDtls.Columns("Complies").HeaderText = "Complies"
			Return
			IL_0209:
			Me.cmbBatch.Width = 176
			Me.chkAll.Visible = False
			Me.dgvDtls.Columns("Specification").HeaderText = "Test"
			Me.dgvDtls.Columns("AcceptanceCriteria").HeaderText = "Specification"
			Me.dgvDtls.Columns("Complies").HeaderText = "Result"
			Dim dataGridViewTextBoxColumn As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
			dataGridViewTextBoxColumn.Name = "Complies"
			dataGridViewTextBoxColumn.DataPropertyName = "Complies"
			dataGridViewTextBoxColumn.HeaderText = "Result"
			dataGridViewTextBoxColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.[True]
			dataGridViewTextBoxColumn.Width = 150
			Me.dgvDtls.Columns.Remove("Complies")
			Me.dgvDtls.Columns.Add(dataGridViewTextBoxColumn)
		End Sub

		' Token: 0x06001C22 RID: 7202 RVA: 0x00105810 File Offset: 0x00103A10
		Private Sub chkAll_CheckedChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = (Me.cmbBatch.SelectedIndex > 0) And (Me.cmbProduct.SelectedIndex > 0)
			If flag Then
				Dim text As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("ProductID = '", Me.cmbProduct.SelectedValue), "' AND BatchNo = '"), Me.cmbBatch.Text), "'"))
				Dim array As DataRow() = Me.dtSpec.[Select](text)
				Dim num As Integer = array.Length - 1
				For i As Integer = 0 To num
					Dim checked As Boolean = Me.chkAll.Checked
					If checked Then
						array(i)("Complies") = "Yes"
					Else
						array(i)("Complies") = ""
					End If
				Next
				Me.dtSpec.AcceptChanges()
				Dim dataView As DataView = New DataView(Me.dtSpec, text, "ProductID", DataViewRowState.CurrentRows)
				Dim dataTable As DataTable = dataView.ToTable()
				Me.dgvDtls.DataSource = dataTable
			End If
		End Sub

		' Token: 0x06001C23 RID: 7203 RVA: 0x0010591C File Offset: 0x00103B1C
		Private Sub dgvDtls_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = e.RowIndex > -1
			If flag Then
				Dim dataTable As DataTable = CType(Me.dgvDtls.DataSource, DataTable)
				Dim array As DataRow() = Me.dtSpec.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SrNo = '", Me.dgvDtls.Rows(e.RowIndex).Cells("SrNo").Value), "'")))
				Dim flag2 As Boolean = array.Length > 0
				If flag2 Then
					array(0)("Complies") = RuntimeHelpers.GetObjectValue(Me.dgvDtls.Rows(e.RowIndex).Cells("Complies").Value)
					Me.dtSpec.AcceptChanges()
				End If
			End If
		End Sub

		' Token: 0x06001C24 RID: 7204 RVA: 0x001059F5 File Offset: 0x00103BF5
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06001C25 RID: 7205 RVA: 0x00105A00 File Offset: 0x00103C00
		Private Function ValidateForm() As Boolean
			Dim flag As Boolean = Operators.CompareString(Me.cmbProduct.Text, "", False) = 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Select Product.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.cmbProduct.Focus()
				flag2 = False
			Else
				Dim flag3 As Boolean = Operators.CompareString(Me.cmbBatch.Text, "", False) = 0
				If flag3 Then
					CustomMsgBox.Show("Select Batch/ Lot.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.cmbBatch.Focus()
					flag2 = False
				Else
					Dim text As String = Me.txtProductType.Text
					If Operators.CompareString(text, "Semi Finished", False) <> 0 Then
						If Operators.CompareString(text, "Cell Bank - Mammalian", False) <> 0 AndAlso Operators.CompareString(text, "Cell Bank - Bacterial", False) <> 0 Then
						End If
					Else
						Dim flag4 As Boolean = Operators.CompareString(Strings.Trim(Me.txtConcentration.Text), "", False) = 0
						If flag4 Then
							CustomMsgBox.Show("Enter Concentration.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.txtConcentration.Focus()
							Return False
						End If
						Dim flag5 As Boolean = Operators.CompareString(Strings.Trim(Me.txtTitre.Text), "", False) = 0
						If flag5 Then
							CustomMsgBox.Show("Enter Titre.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.txtTitre.Focus()
							Return False
						End If
					End If
					Dim flag6 As Boolean = Operators.CompareString(Me.txtRemarks.Text, "", False) = 0
					If flag6 Then
						CustomMsgBox.Show("Enter Remarks.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.theme_tc.SelectedTab = Me.tpRemarks
						Me.lblRemarks_Click(Nothing, Nothing)
						Me.txtRemarks.Focus()
						flag2 = False
					Else
						Dim flag7 As Boolean = Me.dgvDtls.Rows.Count = 0
						If flag7 Then
							CustomMsgBox.Show("No Specifications Added For The Product.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.theme_tc.SelectedTab = Me.tpItems
							Me.dgvDtls.Focus()
							flag2 = False
						Else
							Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("ProductID = '", Me.cmbProduct.SelectedValue), "' AND BatchNo = '"), Me.cmbBatch.Text), "' "))
							text2 = text2 + " AND PrimaryPackSize = '" + Me.txtPrimaryPackSize.Text + "' "
							text2 += " AND Complies = ''"
							Dim text3 As String = Me.txtProductType.Text
							Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(text3)
							If num <= 2424042855UI Then
								If num <= 1381572122UI Then
									If num <> 478348301UI Then
										If num <> 1381572122UI Then
											GoTo IL_03C7
										End If
										If Operators.CompareString(text3, "Raw Material", False) <> 0 Then
											GoTo IL_03C7
										End If
									Else
										If Operators.CompareString(text3, "Cell Bank - Mammalian", False) <> 0 Then
											GoTo IL_03C7
										End If
										GoTo IL_03BE
									End If
								ElseIf num <> 1773852434UI Then
									If num <> 2424042855UI Then
										GoTo IL_03C7
									End If
									If Operators.CompareString(text3, "Semi Finished", False) <> 0 Then
										GoTo IL_03C7
									End If
									GoTo IL_03BE
								ElseIf Operators.CompareString(text3, "Others", False) <> 0 Then
									GoTo IL_03C7
								End If
							ElseIf num <= 3057895172UI Then
								If num <> 2480381874UI Then
									If num <> 3057895172UI Then
										GoTo IL_03C7
									End If
									If Operators.CompareString(text3, "Service", False) <> 0 Then
										GoTo IL_03C7
									End If
								ElseIf Operators.CompareString(text3, "Consumable", False) <> 0 Then
									GoTo IL_03C7
								End If
							ElseIf num <> 3661748803UI Then
								If num <> 3955665341UI Then
									GoTo IL_03C7
								End If
								If Operators.CompareString(text3, "Packaging Material", False) <> 0 Then
									GoTo IL_03C7
								End If
							Else
								If Operators.CompareString(text3, "Cell Bank - Bacterial", False) <> 0 Then
									GoTo IL_03C7
								End If
								GoTo IL_03BE
							End If
							Dim text4 As String = "Complies Status Not Marked For All Specifications."
							GoTo IL_03DF
							IL_03BE:
							text4 = "Result Not Entered For All Tests."
							GoTo IL_03DF
							IL_03C7:
							CustomMsgBox.Show("Invalid Product Type.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Return False
							IL_03DF:
							Dim flag8 As Boolean = Me.dtSpec.[Select](text2).Length > 0
							If flag8 Then
								CustomMsgBox.Show(text4, "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								Me.theme_tc.SelectedTab = Me.tpItems
								Me.dgvDtls.Focus()
								flag2 = False
							Else
								flag2 = True
							End If
						End If
					End If
				End If
			End If
			Return flag2
		End Function

		' Token: 0x06001C26 RID: 7206 RVA: 0x00105E3C File Offset: 0x0010403C
		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.Save()
				Me.SetMailValues("Entry")
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnApprove.Enabled = True
				Me.btnReject.Enabled = True
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06001C27 RID: 7207 RVA: 0x00105ED0 File Offset: 0x001040D0
		Private Sub Save()
			Dim flag As Boolean = CustomMsgBox.Show("Save QC Details.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
			If flag Then
				Dim flag2 As Boolean = Not Me.ValidateForm()
				If Not flag2 Then
					Dim text As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("ProductID = '", Me.cmbProduct.SelectedValue), "' AND BatchNo = '"), Me.cmbBatch.Text), "'"))
					text = text + " AND PrimaryPackSize = '" + Me.txtPrimaryPackSize.Text + "'"
					Dim dataRow As DataRow = Me.dtItems.[Select](text)(0)
					Me.skip_lblStatus.Text = "QC Saved"
					dataRow("Status") = "QC Saved"
					Me.dtItems.AcceptChanges()
					Dim text2 As String = " UPDATE GRNItems SET SpecificationNo = '" + Strings.Trim(Me.txtSpecificationNo.Text) + "', " & vbCrLf
					text2 = text2 + " QCEntryBy = '" + GlobalVariables.gsUserID + "', QCEntryDt = GETDATE(), " & vbCrLf
					text2 = String.Concat(New String() { text2, " Status = 'QC Saved', Remarks = '", Me.txtRemarks.Text, "', Titre = '", Strings.Trim(Me.txtTitre.Text), "', " & vbCrLf })
					text2 = String.Concat(New String() { text2, " FinalConcentration = '", Strings.Trim(Me.txtConcentration.Text), "', Notes = '", Strings.Trim(Me.txtNotes.Text), "' " & vbCrLf })
					text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" WHERE GRNID = '" + Me.txtID.Text + "' AND ProductID = '", Me.cmbProduct.SelectedValue), "' "), vbCrLf)))
					text2 = String.Concat(New String() { text2, " AND BatchNo = '", Me.cmbBatch.Text, "' AND PrimaryPackSize = '", Me.txtPrimaryPackSize.Text, "' " & vbCrLf })
					text2 += " DELETE FROM GRNItemsQC "
					text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" WHERE GRNID = '" + Me.txtID.Text + "' AND ProductID = '", Me.cmbProduct.SelectedValue), "' "), vbCrLf)))
					text2 = String.Concat(New String() { text2, " AND BatchNo = '", Me.cmbBatch.Text, "' AND PrimaryPackSize = '", Me.txtPrimaryPackSize.Text, "' " & vbCrLf })
					text2 = text2 + " EXEC usp_Set_GRN_Status '" + Me.txtID.Text + "' "
					Dim flag3 As Boolean = MainModule.ExecuteSQL(text2) = 1
					If flag3 Then
						Dim dataView As DataView = New DataView(Me.dtSpec, text, "ProductID", DataViewRowState.CurrentRows)
						Dim dataTable As DataTable = dataView.ToTable()
						Me.InsertQCSpec(dataTable)
						FileAttachments.InsertFiles("QC Entry", Me.txtGRNItemsID.Text, Me.dtFile)
						Me.btnApprove.Enabled = False
						Me.btnReject.Enabled = False
						Dim text3 As String = "ID : " + Me.txtID.Text + vbCrLf
						text3 = text3 + "GRN No. : " + Me.txtNo.Text + vbCrLf
						text3 = text3 + "Catalog No. : " + Me.txtCatalogNo.Text + vbCrLf
						text3 = text3 + "Batch No. : " + Me.cmbBatch.Text + vbCrLf
						text3 += "PrimaryPackSize : " + Me.txtPrimaryPackSize.Text
						MainModule.TrnLog(Me.Text, "QC Saved", text3, Nothing)
						CustomMsgBox.Show("QC Saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						MyBase.Close()
					End If
				End If
			End If
		End Sub

		' Token: 0x06001C28 RID: 7208 RVA: 0x001062EC File Offset: 0x001044EC
		Private Function InsertQCSpec(dtQCSepc As DataTable) As Boolean
			Dim flag As Boolean = (Operators.CompareString(Me.txtID.Text, "", False) <> 0) And (dtQCSepc.Rows.Count > 0)
			If flag Then
				Dim sqlConnection As SqlConnection = New SqlConnection(GlobalVariables.gsConStr)
				sqlConnection.Open()
				Dim sqlTransaction As SqlTransaction = sqlConnection.BeginTransaction(IsolationLevel.Serializable)
				Try
					Dim dataTable As DataTable = dtQCSepc.Copy()
					dataTable.Columns.Remove("SrNo")
					Dim dataColumn As DataColumn = New DataColumn("GRNID", GetType(Integer))
					dataColumn.DefaultValue = Me.txtID.Text
					dataTable.Columns.Add(dataColumn)
					MainModule.BulkInsertTemp(dataTable, "GRNItemsQC", sqlConnection, sqlTransaction)
					sqlTransaction.Commit()
					sqlConnection.Close()
					Return True
				Catch ex As Exception
					Dim flag2 As Boolean = (Strings.InStr(ex.Message, "Timeout expired", CompareMethod.Binary) > 0) Or (Strings.InStr(ex.Message, "Violation of PRIMARY KEY constraint", CompareMethod.Binary) > 0)
					If flag2 Then
						CustomMsgBox.Show("Server Busy Try Again : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Else
						CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					End If
					sqlTransaction.Rollback()
					sqlConnection.Close()
				End Try
			End If
			Return False
		End Function

		' Token: 0x06001C29 RID: 7209 RVA: 0x00106468 File Offset: 0x00104668
		Private Sub btnApprove_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Dim text As String = Me.sFormType
				If Operators.CompareString(text, "GRN QC Release", False) <> 0 Then
					If Operators.CompareString(text, "GRN QA Release", False) = 0 Then
						Me.Approve_Reject_QA("Approved")
						Me.SetMailValues("QA Approved")
					End If
				Else
					Me.Approve_Reject_QC("Approved")
					Me.SetMailValues("QC Approved")
				End If
				Dim flag As Boolean = Operators.CompareString(Me.skip_lblStatus.Text, "Batch Release", False) = 0
				If flag Then
					EmailModule.Send_PR_Status_MailAlert(Me.txtPOID.Text, Me.txtID.Text, Conversions.ToString(Me.cmbProduct.SelectedValue), Conversions.ToString(Me.cmbBatch.SelectedValue), "Batch Release", "")
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnApprove.Enabled = True
				Me.btnOnHold.Enabled = True
				Me.btnReject.Enabled = True
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06001C2A RID: 7210 RVA: 0x001065B8 File Offset: 0x001047B8
		Private Sub btnReject_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Dim text As String = Me.sFormType
				If Operators.CompareString(text, "GRN QC Release", False) <> 0 Then
					If Operators.CompareString(text, "GRN QA Release", False) = 0 Then
						Me.Approve_Reject_QA("Rejected")
						Me.SetMailValues("QA Rejected")
					End If
				Else
					Me.Approve_Reject_QC("Rejected")
					Me.SetMailValues("QC Rejected")
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnApprove.Enabled = True
				Me.btnReject.Enabled = True
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06001C2B RID: 7211 RVA: 0x00106694 File Offset: 0x00104894
		Private Sub Approve_Reject_QC(sStatus As String)
			Dim text As String = "These Changes Cannot be Undone." & vbCrLf
			Dim flag As Boolean = Operators.CompareString(sStatus, "Rejected", False) = 0
			Dim text2 As String
			Dim text3 As String
			If flag Then
				text += "Reject QC For Selected Product and Batch..?"
				text2 = "QC Rejected"
				text3 = "Disposed"
			Else
				text += "Approve QC For Selected Product and Batch..?"
				Dim text4 As String = Me.txtProductType.Text
				Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(text4)
				If num <= 2424042855UI Then
					If num <= 1381572122UI Then
						If num <> 478348301UI Then
							If num <> 1381572122UI Then
								GoTo IL_01DD
							End If
							If Operators.CompareString(text4, "Raw Material", False) <> 0 Then
								GoTo IL_01DD
							End If
						Else
							If Operators.CompareString(text4, "Cell Bank - Mammalian", False) <> 0 Then
								GoTo IL_01DD
							End If
							GoTo IL_01CE
						End If
					ElseIf num <> 1773852434UI Then
						If num <> 2166136261UI Then
							If num <> 2424042855UI Then
								GoTo IL_01DD
							End If
							If Operators.CompareString(text4, "Semi Finished", False) <> 0 Then
								GoTo IL_01DD
							End If
							GoTo IL_01CE
						ElseIf Operators.CompareString(text4, "", False) <> 0 Then
							GoTo IL_01DD
						End If
					ElseIf Operators.CompareString(text4, "Others", False) <> 0 Then
						GoTo IL_01DD
					End If
				ElseIf num <= 2982502317UI Then
					If num <> 2480381874UI Then
						If num <> 2982502317UI Then
							GoTo IL_01DD
						End If
						If Operators.CompareString(text4, "Finished Goods", False) <> 0 Then
							GoTo IL_01DD
						End If
						GoTo IL_01CE
					ElseIf Operators.CompareString(text4, "Consumable", False) <> 0 Then
						GoTo IL_01DD
					End If
				ElseIf num <> 3057895172UI Then
					If num <> 3661748803UI Then
						If num <> 3955665341UI Then
							GoTo IL_01DD
						End If
						If Operators.CompareString(text4, "Packaging Material", False) <> 0 Then
							GoTo IL_01DD
						End If
					Else
						If Operators.CompareString(text4, "Cell Bank - Bacterial", False) <> 0 Then
							GoTo IL_01DD
						End If
						GoTo IL_01CE
					End If
				ElseIf Operators.CompareString(text4, "Service", False) <> 0 Then
					GoTo IL_01DD
				End If
				text2 = "Batch Released"
				text3 = "Available"
				GoTo IL_01F6
				IL_01CE:
				text2 = "QC Approved"
				text3 = "Created"
				GoTo IL_01F6
				IL_01DD:
				CustomMsgBox.Show("Invalid Product Type.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Return
				IL_01F6:
			End If
			Dim flag2 As Boolean = CustomMsgBox.Show(text, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
			If flag2 Then
				Dim text5 As String = ""
				Dim flag3 As Boolean = Operators.CompareString(sStatus, "Rejected", False) = 0
				Dim text6 As String
				If flag3 Then
					text6 = "Rejection"
				Else
					text6 = "Approval"
				End If
				Dim captureReasons As CaptureReasons = New CaptureReasons(text6)
				Dim flag4 As Boolean = captureReasons.ShowDialog() = DialogResult.OK
				If flag4 Then
					text5 = text5 + "QC Action : " + sStatus + vbCrLf
					text5 = text5 + "QC Action By : " + GlobalVariables.gsUserName + vbCrLf
					text5 = text5 + "QC Action On : " + Strings.Format(MainModule.GetServerDate(), "dd-MMM-yyyy hh:mm:ss tt") + vbCrLf
					text5 = text5 + "QC Remarks : " + captureReasons.sRemarks + vbCrLf & vbCrLf
					Dim txtRemarksApproval As TextBox = Me.txtRemarksApproval
					Dim textBox As TextBox = txtRemarksApproval
					txtRemarksApproval.Text = textBox.Text + text5
					Me.lblRemarksApproval_Click(Nothing, Nothing)
					Dim text7 As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("ProductID = '", Me.cmbProduct.SelectedValue), "' AND BatchNo = '"), Me.cmbBatch.Text), "'"))
					text7 = text7 + " AND PrimaryPackSize = '" + Me.txtPrimaryPackSize.Text + "'"
					Dim dataRow As DataRow = Me.dtItems.[Select](text7)(0)
					Me.skip_lblStatus.Text = text2
					dataRow("Status") = text2
					Me.dtItems.AcceptChanges()
					Dim text8 As String = " UPDATE GRNItems SET QCActionBy = '" + GlobalVariables.gsUserID + "', QCActionDt = GETDATE(), " & vbCrLf
					text8 = String.Concat(New String() { text8, " Status = '", text2, "', QCActionRemarks = '", Me.txtRemarksApproval.Text, "' " & vbCrLf })
					text8 = Conversions.ToString(Operators.AddObject(text8, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" WHERE GRNID = '" + Me.txtID.Text + "' AND  ProductID = '", Me.cmbProduct.SelectedValue), "' "), vbCrLf)))
					text8 = String.Concat(New String() { text8, " AND BatchNo = '", Me.cmbBatch.Text, "' AND PrimaryPackSize = '", Me.txtPrimaryPackSize.Text, "' " & vbCrLf })
					text8 = String.Concat(New String() { text8, " UPDATE GRNUID SET Status = '", text3, "', ActionBy = '", GlobalVariables.gsUserID, "', ActionDt = GETDATE() " & vbCrLf })
					text8 = Conversions.ToString(Operators.AddObject(text8, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" WHERE GRNID = '" + Me.txtID.Text + "' AND  ProductID = '", Me.cmbProduct.SelectedValue), "' "), vbCrLf)))
					text8 = String.Concat(New String() { text8, " AND BatchNo = '", Me.cmbBatch.Text, "' AND PrimaryPackSize = '", Me.txtPrimaryPackSize.Text, "' " & vbCrLf })
					text8 = text8 + " EXEC usp_Set_GRN_Status '" + Me.txtID.Text + "' "
					Dim flag5 As Boolean = MainModule.ExecuteSQL(text8) = 1
					If flag5 Then
						Me.btnApprove.Enabled = False
						Me.btnOnHold.Enabled = False
						Me.btnReject.Enabled = False
						Dim flag6 As Boolean = Operators.CompareString(Me.skip_lblStatus.Text, "Batch Released", False) = 0
						If flag6 Then
							Me.btnPrint.Enabled = True
						End If
						Me.UpdateWeightedAverageRate()
						Dim text9 As String = "ID : " + Me.txtID.Text + vbCrLf
						text9 = text9 + "GRN No. : " + Me.txtNo.Text + vbCrLf
						text9 = text9 + "Catalog No. : " + Me.txtCatalogNo.Text + vbCrLf
						text9 = text9 + "Batch No. : " + Me.cmbBatch.Text + vbCrLf
						text9 += "PrimaryPackSize : " + Me.txtPrimaryPackSize.Text
						MainModule.TrnLog(Me.Text, "QC " + sStatus, text9, Nothing)
						CustomMsgBox.Show("QC " + sStatus + ".", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					End If
				Else
					CustomMsgBox.Show("Remark For " + text6 + " Is Mandatory.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				End If
			End If
		End Sub

		' Token: 0x06001C2C RID: 7212 RVA: 0x00106D58 File Offset: 0x00104F58
		Private Sub Approve_Reject_QA(sStatus As String)
			Dim flag As Boolean = Not Me.bCOA_Save And (Operators.CompareString(sStatus, "Approved", False) = 0)
			If flag Then
				CustomMsgBox.Show("COA File Might Be Missing.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.theme_tc.SelectedTab = Me.tpDoc
			Else
				Dim text As String = "These Changes Cannot be Undone." & vbCrLf
				Dim flag2 As Boolean = Operators.CompareString(sStatus, "Rejected", False) = 0
				Dim text2 As String
				Dim text3 As String
				If flag2 Then
					text += "Reject QA For Selected Product and Batch..?"
					text2 = "QA Rejected"
					text3 = "Disposed"
				Else
					text += "Approve QA For Selected Product and Batch..?"
					text2 = "Batch Released"
					text3 = "Available"
				End If
				Dim flag3 As Boolean = CustomMsgBox.Show(text, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
				If flag3 Then
					Dim text4 As String = ""
					Dim flag4 As Boolean = Operators.CompareString(sStatus, "Rejected", False) = 0
					Dim text5 As String
					If flag4 Then
						text5 = "Rejection"
					Else
						text5 = "Approval"
					End If
					Dim captureReasons As CaptureReasons = New CaptureReasons(text5)
					Dim flag5 As Boolean = captureReasons.ShowDialog() = DialogResult.OK
					If flag5 Then
						text4 = text4 + "QA Action : " + sStatus + vbCrLf
						text4 = text4 + "QA Action By : " + GlobalVariables.gsUserName + vbCrLf
						text4 = text4 + "QA Action On : " + Strings.Format(MainModule.GetServerDate(), "dd-MMM-yyyy hh:mm:ss tt") + vbCrLf
						text4 = text4 + "QA Remarks : " + captureReasons.sRemarks
						Dim txtRemarksApproval As TextBox = Me.txtRemarksApproval
						Dim textBox As TextBox = txtRemarksApproval
						txtRemarksApproval.Text = textBox.Text + text4
						Me.lblRemarksApproval_Click(Nothing, Nothing)
						Dim text6 As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("ProductID = '", Me.cmbProduct.SelectedValue), "' AND BatchNo = '"), Me.cmbBatch.Text), "'"))
						text6 = text6 + " AND PrimaryPackSize = '" + Me.txtPrimaryPackSize.Text + "'"
						Dim dataRow As DataRow = Me.dtItems.[Select](text6)(0)
						Me.skip_lblStatus.Text = text2
						dataRow("Status") = text2
						Me.dtItems.AcceptChanges()
						Dim text7 As String = " UPDATE GRNItems SET QAActionBy = '" + GlobalVariables.gsUserID + "', QAActionDt = GETDATE(), " & vbCrLf
						text7 = String.Concat(New String() { text7, " Status = '", text2, "', QAActionRemarks = '", Me.txtRemarksApproval.Text, "' " & vbCrLf })
						text7 = Conversions.ToString(Operators.AddObject(text7, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" WHERE GRNID = '" + Me.txtID.Text + "' AND  ProductID = '", Me.cmbProduct.SelectedValue), "' "), vbCrLf)))
						text7 = String.Concat(New String() { text7, " AND BatchNo = '", Me.cmbBatch.Text, "' AND PrimaryPackSize = '", Me.txtPrimaryPackSize.Text, "' " & vbCrLf })
						text7 = String.Concat(New String() { text7, " UPDATE GRNUID SET Status = '", text3, "', ActionBy = '", GlobalVariables.gsUserID, "', ActionDt = GETDATE() " & vbCrLf })
						text7 = Conversions.ToString(Operators.AddObject(text7, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" WHERE GRNID = '" + Me.txtID.Text + "' AND  ProductID = '", Me.cmbProduct.SelectedValue), "' "), vbCrLf)))
						text7 = String.Concat(New String() { text7, " AND BatchNo = '", Me.cmbBatch.Text, "' AND PrimaryPackSize = '", Me.txtPrimaryPackSize.Text, "' " & vbCrLf })
						text7 = text7 + " EXEC usp_Set_GRN_Status '" + Me.txtID.Text + "' "
						Dim flag6 As Boolean = MainModule.ExecuteSQL(text7) = 1
						If flag6 Then
							Me.btnApprove.Enabled = False
							Me.btnOnHold.Enabled = False
							Me.btnReject.Enabled = False
							Dim flag7 As Boolean = Operators.CompareString(Me.skip_lblStatus.Text, "Batch Released", False) = 0
							If flag7 Then
								Me.btnPrint.Enabled = True
							End If
							Me.UpdateWeightedAverageRate()
							Dim text8 As String = "ID : " + Me.txtID.Text + vbCrLf
							text8 = text8 + "GRN No. : " + Me.txtNo.Text + vbCrLf
							text8 = text8 + "Catalog No. : " + Me.txtCatalogNo.Text + vbCrLf
							text8 = text8 + "Batch No. : " + Me.cmbBatch.Text + vbCrLf
							text8 += "PrimaryPackSize : " + Me.txtPrimaryPackSize.Text
							MainModule.TrnLog(Me.Text, "QA " + sStatus, text8, Nothing)
							CustomMsgBox.Show("QA " + sStatus + ".", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						End If
					Else
						CustomMsgBox.Show("Remark For " + text5 + " Is Mandatory.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					End If
				End If
			End If
		End Sub

		' Token: 0x06001C2D RID: 7213 RVA: 0x001072B8 File Offset: 0x001054B8
		Private Sub UpdateWeightedAverageRate()
			Dim text As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("EXEC usp_Update_WeightedAverage_Rate '", Me.cmbProduct.SelectedValue), "'"))
			Dim flag As Boolean = MainModule.ExecuteSQL(text) = 1
			If flag Then
			End If
		End Sub

		' Token: 0x06001C2E RID: 7214 RVA: 0x001072FC File Offset: 0x001054FC
		Private Sub btnOnHold_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Dim flag As Boolean = CustomMsgBox.Show("Put On Hold..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
				If flag Then
					Dim text As String = Me.sFormType
					If Operators.CompareString(text, "GRN QC Release", False) <> 0 Then
						If Operators.CompareString(text, "GRN QA Release", False) = 0 Then
							Me.OnHold_QA()
							Me.SetMailValues("QA On-Hold")
						End If
					Else
						Me.OnHold_QC()
						Me.SetMailValues("QC On-Hold")
					End If
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnApprove.Enabled = True
				Me.btnOnHold.Enabled = True
				Me.btnReject.Enabled = True
				Me.btnPrint.Enabled = True
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06001C2F RID: 7215 RVA: 0x00107404 File Offset: 0x00105604
		Private Sub OnHold_QC()
			Dim captureReasons As CaptureReasons = New CaptureReasons("On-Hold")
			Dim flag As Boolean = captureReasons.ShowDialog() = DialogResult.OK
			If flag Then
				Me.btnApprove.Enabled = False
				Me.btnOnHold.Enabled = False
				Me.btnReject.Enabled = False
				Me.btnPrint.Enabled = False
				Dim text As String = "Action : QC On-Hold" & vbCrLf
				text = text + "Action By : " + GlobalVariables.gsUserName + vbCrLf
				text = text + "Action On : " + Strings.Format(MainModule.GetServerDate(), "dd-MMM-yyyy hh:mm:ss tt") + vbCrLf
				text = text + "Remarks : " + captureReasons.sRemarks + vbCrLf & vbCrLf
				Dim txtRemarksApproval As TextBox = Me.txtRemarksApproval
				Dim textBox As TextBox = txtRemarksApproval
				txtRemarksApproval.Text = textBox.Text + text
				Me.lblRemarksApproval.Visible = True
				Me.lblRemarksApproval_Click(Nothing, Nothing)
				Dim text2 As String = " UPDATE GRNItems SET Status = 'QC On-Hold', QCActionRemarks = '" + Me.txtRemarksApproval.Text + "', " & vbCrLf
				text2 = text2 + " QCActionDt = GETDATE(), QCActionBy = '" + GlobalVariables.gsUserID + "'" & vbCrLf
				text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" WHERE GRNID = '" + Me.txtID.Text + "' AND ProductID = '", Me.cmbProduct.SelectedValue), "' "), vbCrLf)))
				text2 = String.Concat(New String() { text2, " AND BatchNo = '", Me.cmbBatch.Text, "' AND PrimaryPackSize = '", Me.txtPrimaryPackSize.Text, "' " & vbCrLf })
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text2) = 1
				If flag2 Then
					Dim text3 As String = "ID : " + Me.txtID.Text + vbCrLf
					text3 = text3 + "GRN No. : " + Me.txtNo.Text + vbCrLf
					text3 = text3 + "Catalog No. : " + Me.txtCatalogNo.Text + vbCrLf
					text3 = text3 + "Batch No. : " + Me.cmbBatch.Text + vbCrLf
					text3 += "PrimaryPackSize : " + Me.txtPrimaryPackSize.Text
					Me.skip_lblStatus.Text = "QC On-Hold"
					MainModule.TrnLog(Me.Text, "QC On-Hold", text3, Nothing)
					CustomMsgBox.Show("QC On-Hold.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					MyBase.Close()
				Else
					Me.btnApprove.Enabled = True
					Me.btnOnHold.Enabled = True
					Me.btnReject.Enabled = True
					Me.btnPrint.Enabled = True
				End If
			End If
		End Sub

		' Token: 0x06001C30 RID: 7216 RVA: 0x001076CC File Offset: 0x001058CC
		Private Sub OnHold_QA()
			Dim captureReasons As CaptureReasons = New CaptureReasons("On-Hold")
			Dim flag As Boolean = captureReasons.ShowDialog() = DialogResult.OK
			If flag Then
				Me.btnApprove.Enabled = False
				Me.btnOnHold.Enabled = False
				Me.btnReject.Enabled = False
				Me.btnPrint.Enabled = False
				Dim text As String = "Action : QA On-Hold" & vbCrLf
				text = text + "Action By : " + GlobalVariables.gsUserName + vbCrLf
				text = text + "Action On : " + Strings.Format(MainModule.GetServerDate(), "dd-MMM-yyyy hh:mm:ss tt") + vbCrLf
				text = text + "Remarks : " + captureReasons.sRemarks + vbCrLf & vbCrLf
				Dim txtRemarksApproval As TextBox = Me.txtRemarksApproval
				Dim textBox As TextBox = txtRemarksApproval
				txtRemarksApproval.Text = textBox.Text + text
				Me.lblRemarksApproval.Visible = True
				Me.lblRemarksApproval_Click(Nothing, Nothing)
				Dim text2 As String = " UPDATE GRNItems SET Status = 'QA On-Hold', QAActionRemarks = '" + Me.txtRemarksApproval.Text + "', " & vbCrLf
				text2 = text2 + " QAActionDt = GETDATE(), QAActionBy = '" + GlobalVariables.gsUserID + "'" & vbCrLf
				text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" WHERE GRNID = '" + Me.txtID.Text + "' AND ProductID = '", Me.cmbProduct.SelectedValue), "' "), vbCrLf)))
				text2 = String.Concat(New String() { text2, " AND BatchNo = '", Me.cmbBatch.Text, "' AND PrimaryPackSize = '", Me.txtPrimaryPackSize.Text, "' " & vbCrLf })
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text2) = 1
				If flag2 Then
					Dim text3 As String = "ID : " + Me.txtID.Text + vbCrLf
					text3 = text3 + "GRN No. : " + Me.txtNo.Text + vbCrLf
					text3 = text3 + "Catalog No. : " + Me.txtCatalogNo.Text + vbCrLf
					text3 = text3 + "Batch No. : " + Me.cmbBatch.Text + vbCrLf
					text3 += "PrimaryPackSize : " + Me.txtPrimaryPackSize.Text
					Me.skip_lblStatus.Text = "QA On-Hold"
					MainModule.TrnLog(Me.Text, "QA On-Hold", text3, Nothing)
					CustomMsgBox.Show("QA On-Hold.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					MyBase.Close()
				Else
					Me.btnApprove.Enabled = True
					Me.btnOnHold.Enabled = True
					Me.btnReject.Enabled = True
					Me.btnPrint.Enabled = True
				End If
			End If
		End Sub

		' Token: 0x06001C31 RID: 7217 RVA: 0x00107994 File Offset: 0x00105B94
		Private Sub btnPrint_Click(sender As Object, e As EventArgs)
			Try
				Dim text As String = Me.txtProductType.Text
				Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(text)
				If num <= 2424042855UI Then
					If num <= 1381572122UI Then
						If num <> 478348301UI Then
							If num <> 1381572122UI Then
								GoTo IL_0173
							End If
							If Operators.CompareString(text, "Raw Material", False) <> 0 Then
								GoTo IL_0173
							End If
						Else
							If Operators.CompareString(text, "Cell Bank - Mammalian", False) <> 0 Then
								GoTo IL_0173
							End If
							GoTo IL_0169
						End If
					ElseIf num <> 1773852434UI Then
						If num <> 2166136261UI Then
							If num <> 2424042855UI Then
								GoTo IL_0173
							End If
							If Operators.CompareString(text, "Semi Finished", False) <> 0 Then
								GoTo IL_0173
							End If
							GoTo IL_0169
						ElseIf Operators.CompareString(text, "", False) <> 0 Then
							GoTo IL_0173
						End If
					ElseIf Operators.CompareString(text, "Others", False) <> 0 Then
						GoTo IL_0173
					End If
				ElseIf num <= 2982502317UI Then
					If num <> 2480381874UI Then
						If num <> 2982502317UI Then
							GoTo IL_0173
						End If
						If Operators.CompareString(text, "Finished Goods", False) <> 0 Then
							GoTo IL_0173
						End If
						GoTo IL_0169
					ElseIf Operators.CompareString(text, "Consumable", False) <> 0 Then
						GoTo IL_0173
					End If
				ElseIf num <> 3057895172UI Then
					If num <> 3661748803UI Then
						If num <> 3955665341UI Then
							GoTo IL_0173
						End If
						If Operators.CompareString(text, "Packaging Material", False) <> 0 Then
							GoTo IL_0173
						End If
					Else
						If Operators.CompareString(text, "Cell Bank - Bacterial", False) <> 0 Then
							GoTo IL_0173
						End If
						GoTo IL_0169
					End If
				ElseIf Operators.CompareString(text, "Service", False) <> 0 Then
					GoTo IL_0173
				End If
				Me.PrintReport()
				GoTo IL_0173
				IL_0169:
				Me.PrintReport_COA()
				IL_0173:
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06001C32 RID: 7218 RVA: 0x00107B64 File Offset: 0x00105D64
		Private Sub PrintReport()
			Dim text As String = " SELECT '' AS RMNo, 'F/SOP/QC/006/NN-XX' AS FormatNo, 'SOP/QC/006' AS ReferenceSOPNo, NULL AS EffectiveDt, NULL AS ValidUpto, " & vbCrLf
			text += " P.ProductName AS MaterialName, GI.SpecificationNo, P.Reference, V.VendorName, P.CatalogNo, GIQC.BatchNo, " & vbCrLf
			text += " ROW_NUMBER() OVER(ORDER BY GIQC.GRNItemsQCID) AS  SrNo, GIQC.Specification, GIQC.AcceptanceCriteria, GIQC.Complies, GI.Remarks, " & vbCrLf
			text += " Entry.UserName AS QCEntryBy, Entry.Designation AS QCEntryDesignation, GI.QCEntryDt, " & vbCrLf
			text += " Action.UserName AS QCActionBy, Action.Designation AS QCActionDesignation, GI.QCActionDt" & vbCrLf
			text += " FROM GRN AS G " & vbCrLf
			text += " INNER JOIN GRNItems AS GI ON G.GRNID = GI.GRNID " & vbCrLf
			text += " INNER JOIN GRNItemsQC AS GIQC ON GI.GRNItemsID = GIQC.GRNItemsID " & vbCrLf
			text += " INNER JOIN Product AS P ON GI.ProductID = P.ProductID " & vbCrLf
			text += " INNER JOIN Vendor AS V ON G.VendorID = V.VendorID " & vbCrLf
			text += " LEFT OUTER JOIN [User] AS Entry ON GI.QCEntryBy = Entry.UserID " & vbCrLf
			text += " LEFT OUTER JOIN [User] AS Action ON GI.QCActionBy = Action.UserID" & vbCrLf
			text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" WHERE G.GRNID = '" + Me.txtID.Text + "' AND GIQC.ProductID = '", Me.cmbProduct.SelectedValue), "' AND GIQC.BatchNo = '"), Me.cmbBatch.Text), "'"), vbCrLf)))
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim reportCrystal As ReportCrystal = New ReportCrystal("QC", data)
				reportCrystal.Show(MyProject.Forms.MDIMain.DockPanel)
				MyBase.Close()
			End If
		End Sub

		' Token: 0x06001C33 RID: 7219 RVA: 0x00107CA4 File Offset: 0x00105EA4
		Private Sub PrintReport_COA()
			Dim text As String = " SELECT P.ProductName, GI.SpecificationNo, P.StorageCondition, GI.BMRNo, GI.BatchNo, GI.MfgDt, GI.ExpDt ExpiryDt, " & vbCrLf
			text += " ROW_NUMBER() OVER(ORDER BY GIQC.GRNItemsQCID) AS  SrNo, GIQC.Specification Test, " & vbCrLf
			text += " GIQC.AcceptanceCriteria Specification, GIQC.Complies Result, GI.QAActionRemarks Remarks, " & vbCrLf
			text += " Entry.UserName AS QCEntryBy, Entry.Designation AS QCEntryDesignation, GI.QCEntryDt, " & vbCrLf
			text += " Action.UserName AS QCCheckBy, Action.Designation AS QCActionDesignation, GI.QCActionDt Date_Of_QC_Release, " & vbCrLf
			text += " QAAction.UserName AS QACheckBy, QAAction.Designation AS QAActionDesignation, GI.QAActionDt Date_Of_QA_Release " & vbCrLf
			text += " FROM GRN AS G " & vbCrLf
			text += " INNER JOIN GRNItems AS GI ON G.GRNID = GI.GRNID " & vbCrLf
			text += " INNER JOIN GRNItemsQC AS GIQC ON GI.GRNItemsID = GIQC.GRNItemsID " & vbCrLf
			text += " INNER JOIN Product AS P ON GI.ProductID = P.ProductID " & vbCrLf
			text += " LEFT OUTER JOIN [User] AS Entry ON GI.QCEntryBy = Entry.UserID " & vbCrLf
			text += " LEFT OUTER JOIN [User] AS Action ON GI.QCActionBy = Action.UserID " & vbCrLf
			text += " LEFT OUTER JOIN [User] AS QAAction ON GI.QAActionBy = QAAction.UserID " & vbCrLf
			text = text + " WHERE G.GRNID = '" + Me.txtID.Text + "' " & vbCrLf
			text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" AND GIQC.ProductID = '", Me.cmbProduct.SelectedValue), "' AND GIQC.BatchNo = '"), Me.cmbBatch.Text), "'"), vbCrLf)))
			text = text + " AND GIQC.PrimaryPackSize = '" + Me.txtPrimaryPackSize.Text + "'"
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim flag2 As Boolean = Operators.CompareString(data.Rows(0)("Remarks").ToString(), "", False) <> 0
				If flag2 Then
					Dim array As String() = Strings.Split(data.Rows(0)("Remarks").ToString(), vbCrLf, -1, CompareMethod.Binary)
					Dim text2 As String = array(array.Length - 1)
					Dim num As Integer = data.Rows.Count - 1
					For i As Integer = 0 To num
						data.Rows(0)("Remarks") = Strings.Replace(Strings.Replace(text2, "QA Remarks : ", "", 1, -1, CompareMethod.Binary), "Remarks : ", "", 1, -1, CompareMethod.Binary)
					Next
				End If
				Dim reportCrystal As ReportCrystal = New ReportCrystal("COA", data)
				reportCrystal.Show(MyProject.Forms.MDIMain.DockPanel)
				MyBase.Close()
			End If
		End Sub

		' Token: 0x06001C34 RID: 7220 RVA: 0x00107EE4 File Offset: 0x001060E4
		Private Sub SetMailValues(sType As String)
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				Dim text As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("ProductID = '", Me.cmbProduct.SelectedValue), "' AND BatchNo = '"), Me.cmbBatch.Text), "'"))
				text = text + " AND PrimaryPackSize = '" + Me.txtPrimaryPackSize.Text + "'"
				Dim dataRow As DataRow = Me.dtItems.[Select](text)(0)
				Dim text2 As String = " SELECT GI.GRNItemsID, GI.Status " & vbCrLf
				text2 += " FROM GRN AS G INNER JOIN GRNItems AS GI ON G.GRNID = GI.GRNID " & vbCrLf
				text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" WHERE G.GRNID = '" + Me.txtID.Text + "' AND GI.ProductID = '", Me.cmbProduct.SelectedValue), "' "), vbCrLf)))
				text2 = String.Concat(New String() { text2, " AND GI.BatchNo = '", Me.cmbBatch.Text, "' AND GI.PrimaryPackSize = '", Me.txtPrimaryPackSize.Text, "'" & vbCrLf })
				Dim data As DataTable = MainModule.GetData(text2)
				Dim flag2 As Boolean = data.Rows.Count > 0
				If flag2 Then
					Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(sType)
					If num <= 1155551934UI Then
						If num <> 837204346UI Then
							If num <> 850678000UI Then
								If num <> 1155551934UI Then
									GoTo IL_0331
								End If
								If Operators.CompareString(sType, "QA On-Hold", False) <> 0 Then
									GoTo IL_0331
								End If
								GoTo IL_02E8
							ElseIf Operators.CompareString(sType, "QC On-Hold", False) <> 0 Then
								GoTo IL_0331
							End If
						Else
							If Operators.CompareString(sType, "QA Approved", False) <> 0 Then
								GoTo IL_0331
							End If
							GoTo IL_02E8
						End If
					ElseIf num <= 2321015623UI Then
						If num <> 1651035093UI Then
							If num <> 2321015623UI Then
								GoTo IL_0331
							End If
							If Operators.CompareString(sType, "QA Rejected", False) <> 0 Then
								GoTo IL_0331
							End If
							GoTo IL_02E8
						ElseIf Operators.CompareString(sType, "QC Rejected", False) <> 0 Then
							GoTo IL_0331
						End If
					ElseIf num <> 2629823795UI Then
						If num <> 3507303272UI Then
							GoTo IL_0331
						End If
						If Operators.CompareString(sType, "QC Approved", False) <> 0 Then
							GoTo IL_0331
						End If
					Else
						If Operators.CompareString(sType, "Entry", False) <> 0 Then
							GoTo IL_0331
						End If
						EmailModule.SendMail("QC Entry", Conversions.ToString(data.Rows(0)("GRNItemsID")), "", "")
						GoTo IL_0331
					End If
					EmailModule.SendMail("QC Release", Conversions.ToString(data.Rows(0)("GRNItemsID")), Conversions.ToString(data.Rows(0)("Status")), "")
					GoTo IL_0331
					IL_02E8:
					EmailModule.SendMail("QA Release", Conversions.ToString(data.Rows(0)("GRNItemsID")), Conversions.ToString(data.Rows(0)("Status")), "")
					IL_0331:
				End If
			End If
		End Sub

		' Token: 0x06001C35 RID: 7221 RVA: 0x00108228 File Offset: 0x00106428
		Private Sub lblRemarks_Click(sender As Object, e As EventArgs)
			Me.lblRemarks.BorderStyle = BorderStyle.FixedSingle
			Me.lblRemarksApproval.BorderStyle = BorderStyle.None
			Me.lblRemarks1.Visible = True
			Me.lblRemarksApproval1.Visible = False
			Me.txtRemarks.Visible = True
			Me.txtRemarksApproval.Visible = False
		End Sub

		' Token: 0x06001C36 RID: 7222 RVA: 0x00108284 File Offset: 0x00106484
		Private Sub lblRemarksApproval_Click(sender As Object, e As EventArgs)
			Me.lblRemarks.BorderStyle = BorderStyle.None
			Me.lblRemarksApproval.BorderStyle = BorderStyle.FixedSingle
			Me.lblRemarks1.Visible = False
			Me.lblRemarksApproval.Visible = True
			Me.lblRemarksApproval1.Visible = True
			Me.txtRemarks.Visible = False
			Me.txtRemarksApproval.Visible = True
		End Sub

		' Token: 0x04000C31 RID: 3121
		Private sFormType As String

		' Token: 0x04000C32 RID: 3122
		Private sEmailTo As String

		' Token: 0x04000C33 RID: 3123
		Private drData As DataRow

		' Token: 0x04000C34 RID: 3124
		Private dtItems As DataTable

		' Token: 0x04000C35 RID: 3125
		Private dtSpec As DataTable

		' Token: 0x04000C36 RID: 3126
		Private dtSpecTemp As DataTable

		' Token: 0x04000C37 RID: 3127
		Private dtFile As DataTable

		' Token: 0x04000C38 RID: 3128
		Private dtFile_Old As DataTable

		' Token: 0x04000C39 RID: 3129
		Private bCOA_Save As Boolean
	End Class
End Namespace
