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
	' Token: 0x02000062 RID: 98
	<DesignerGenerated()>
	Public Partial Class GRNList
		Inherits DockContent

		' Token: 0x1700090F RID: 2319
		' (get) Token: 0x0600177C RID: 6012 RVA: 0x000D7A1B File Offset: 0x000D5C1B
		' (set) Token: 0x0600177D RID: 6013 RVA: 0x000D7A25 File Offset: 0x000D5C25
		Friend Overridable Property GbBasic As GroupBox

		' Token: 0x17000910 RID: 2320
		' (get) Token: 0x0600177E RID: 6014 RVA: 0x000D7A2E File Offset: 0x000D5C2E
		' (set) Token: 0x0600177F RID: 6015 RVA: 0x000D7A38 File Offset: 0x000D5C38
		Friend Overridable Property Label2 As Label

		' Token: 0x17000911 RID: 2321
		' (get) Token: 0x06001780 RID: 6016 RVA: 0x000D7A41 File Offset: 0x000D5C41
		' (set) Token: 0x06001781 RID: 6017 RVA: 0x000D7A4B File Offset: 0x000D5C4B
		Friend Overridable Property txtPONo As TextBox

		' Token: 0x17000912 RID: 2322
		' (get) Token: 0x06001782 RID: 6018 RVA: 0x000D7A54 File Offset: 0x000D5C54
		' (set) Token: 0x06001783 RID: 6019 RVA: 0x000D7A5E File Offset: 0x000D5C5E
		Friend Overridable Property cmbPlant As ComboBox

		' Token: 0x17000913 RID: 2323
		' (get) Token: 0x06001784 RID: 6020 RVA: 0x000D7A67 File Offset: 0x000D5C67
		' (set) Token: 0x06001785 RID: 6021 RVA: 0x000D7A71 File Offset: 0x000D5C71
		Friend Overridable Property Label1 As Label

		' Token: 0x17000914 RID: 2324
		' (get) Token: 0x06001786 RID: 6022 RVA: 0x000D7A7A File Offset: 0x000D5C7A
		' (set) Token: 0x06001787 RID: 6023 RVA: 0x000D7A84 File Offset: 0x000D5C84
		Friend Overridable Property txtNo As TextBox

		' Token: 0x17000915 RID: 2325
		' (get) Token: 0x06001788 RID: 6024 RVA: 0x000D7A8D File Offset: 0x000D5C8D
		' (set) Token: 0x06001789 RID: 6025 RVA: 0x000D7A97 File Offset: 0x000D5C97
		Friend Overridable Property dtpFrom As DateTimePicker

		' Token: 0x17000916 RID: 2326
		' (get) Token: 0x0600178A RID: 6026 RVA: 0x000D7AA0 File Offset: 0x000D5CA0
		' (set) Token: 0x0600178B RID: 6027 RVA: 0x000D7AAA File Offset: 0x000D5CAA
		Friend Overridable Property dtpTo As DateTimePicker

		' Token: 0x17000917 RID: 2327
		' (get) Token: 0x0600178C RID: 6028 RVA: 0x000D7AB3 File Offset: 0x000D5CB3
		' (set) Token: 0x0600178D RID: 6029 RVA: 0x000D7ABD File Offset: 0x000D5CBD
		Friend Overridable Property Label16 As Label

		' Token: 0x17000918 RID: 2328
		' (get) Token: 0x0600178E RID: 6030 RVA: 0x000D7AC6 File Offset: 0x000D5CC6
		' (set) Token: 0x0600178F RID: 6031 RVA: 0x000D7AD0 File Offset: 0x000D5CD0
		Friend Overridable Property lblDate As ComboBox

		' Token: 0x17000919 RID: 2329
		' (get) Token: 0x06001790 RID: 6032 RVA: 0x000D7AD9 File Offset: 0x000D5CD9
		' (set) Token: 0x06001791 RID: 6033 RVA: 0x000D7AE4 File Offset: 0x000D5CE4
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

		' Token: 0x1700091A RID: 2330
		' (get) Token: 0x06001792 RID: 6034 RVA: 0x000D7B27 File Offset: 0x000D5D27
		' (set) Token: 0x06001793 RID: 6035 RVA: 0x000D7B31 File Offset: 0x000D5D31
		Friend Overridable Property GbAdvanced As GroupBox

		' Token: 0x1700091B RID: 2331
		' (get) Token: 0x06001794 RID: 6036 RVA: 0x000D7B3A File Offset: 0x000D5D3A
		' (set) Token: 0x06001795 RID: 6037 RVA: 0x000D7B44 File Offset: 0x000D5D44
		Friend Overridable Property pnlItem As Panel

		' Token: 0x1700091C RID: 2332
		' (get) Token: 0x06001796 RID: 6038 RVA: 0x000D7B4D File Offset: 0x000D5D4D
		' (set) Token: 0x06001797 RID: 6039 RVA: 0x000D7B57 File Offset: 0x000D5D57
		Friend Overridable Property txtName As TextBox

		' Token: 0x1700091D RID: 2333
		' (get) Token: 0x06001798 RID: 6040 RVA: 0x000D7B60 File Offset: 0x000D5D60
		' (set) Token: 0x06001799 RID: 6041 RVA: 0x000D7B6A File Offset: 0x000D5D6A
		Friend Overridable Property txtCatalogNo As TextBox

		' Token: 0x1700091E RID: 2334
		' (get) Token: 0x0600179A RID: 6042 RVA: 0x000D7B73 File Offset: 0x000D5D73
		' (set) Token: 0x0600179B RID: 6043 RVA: 0x000D7B7D File Offset: 0x000D5D7D
		Friend Overridable Property Label14 As Label

		' Token: 0x1700091F RID: 2335
		' (get) Token: 0x0600179C RID: 6044 RVA: 0x000D7B86 File Offset: 0x000D5D86
		' (set) Token: 0x0600179D RID: 6045 RVA: 0x000D7B90 File Offset: 0x000D5D90
		Friend Overridable Property Label5 As Label

		' Token: 0x17000920 RID: 2336
		' (get) Token: 0x0600179E RID: 6046 RVA: 0x000D7B99 File Offset: 0x000D5D99
		' (set) Token: 0x0600179F RID: 6047 RVA: 0x000D7BA3 File Offset: 0x000D5DA3
		Friend Overridable Property txtCode As TextBox

		' Token: 0x17000921 RID: 2337
		' (get) Token: 0x060017A0 RID: 6048 RVA: 0x000D7BAC File Offset: 0x000D5DAC
		' (set) Token: 0x060017A1 RID: 6049 RVA: 0x000D7BB6 File Offset: 0x000D5DB6
		Friend Overridable Property Label6 As Label

		' Token: 0x17000922 RID: 2338
		' (get) Token: 0x060017A2 RID: 6050 RVA: 0x000D7BBF File Offset: 0x000D5DBF
		' (set) Token: 0x060017A3 RID: 6051 RVA: 0x000D7BCC File Offset: 0x000D5DCC
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

		' Token: 0x17000923 RID: 2339
		' (get) Token: 0x060017A4 RID: 6052 RVA: 0x000D7C0F File Offset: 0x000D5E0F
		' (set) Token: 0x060017A5 RID: 6053 RVA: 0x000D7C19 File Offset: 0x000D5E19
		Friend Overridable Property Label13 As Label

		' Token: 0x17000924 RID: 2340
		' (get) Token: 0x060017A6 RID: 6054 RVA: 0x000D7C22 File Offset: 0x000D5E22
		' (set) Token: 0x060017A7 RID: 6055 RVA: 0x000D7C2C File Offset: 0x000D5E2C
		Friend Overridable Property cmbStatus As ComboBox

		' Token: 0x17000925 RID: 2341
		' (get) Token: 0x060017A8 RID: 6056 RVA: 0x000D7C35 File Offset: 0x000D5E35
		' (set) Token: 0x060017A9 RID: 6057 RVA: 0x000D7C3F File Offset: 0x000D5E3F
		Friend Overridable Property Label11 As Label

		' Token: 0x17000926 RID: 2342
		' (get) Token: 0x060017AA RID: 6058 RVA: 0x000D7C48 File Offset: 0x000D5E48
		' (set) Token: 0x060017AB RID: 6059 RVA: 0x000D7C52 File Offset: 0x000D5E52
		Friend Overridable Property Label3 As Label

		' Token: 0x17000927 RID: 2343
		' (get) Token: 0x060017AC RID: 6060 RVA: 0x000D7C5B File Offset: 0x000D5E5B
		' (set) Token: 0x060017AD RID: 6061 RVA: 0x000D7C68 File Offset: 0x000D5E68
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

		' Token: 0x17000928 RID: 2344
		' (get) Token: 0x060017AE RID: 6062 RVA: 0x000D7CAB File Offset: 0x000D5EAB
		' (set) Token: 0x060017AF RID: 6063 RVA: 0x000D7CB5 File Offset: 0x000D5EB5
		Friend Overridable Property txtChallanNo As TextBox

		' Token: 0x17000929 RID: 2345
		' (get) Token: 0x060017B0 RID: 6064 RVA: 0x000D7CBE File Offset: 0x000D5EBE
		' (set) Token: 0x060017B1 RID: 6065 RVA: 0x000D7CC8 File Offset: 0x000D5EC8
		Friend Overridable Property Label9 As Label

		' Token: 0x1700092A RID: 2346
		' (get) Token: 0x060017B2 RID: 6066 RVA: 0x000D7CD1 File Offset: 0x000D5ED1
		' (set) Token: 0x060017B3 RID: 6067 RVA: 0x000D7CDB File Offset: 0x000D5EDB
		Friend Overridable Property Label4 As Label

		' Token: 0x1700092B RID: 2347
		' (get) Token: 0x060017B4 RID: 6068 RVA: 0x000D7CE4 File Offset: 0x000D5EE4
		' (set) Token: 0x060017B5 RID: 6069 RVA: 0x000D7CEE File Offset: 0x000D5EEE
		Friend Overridable Property txtCreated As TextBox

		' Token: 0x1700092C RID: 2348
		' (get) Token: 0x060017B6 RID: 6070 RVA: 0x000D7CF7 File Offset: 0x000D5EF7
		' (set) Token: 0x060017B7 RID: 6071 RVA: 0x000D7D01 File Offset: 0x000D5F01
		Friend Overridable Property txtInvoiceNo As TextBox

		' Token: 0x1700092D RID: 2349
		' (get) Token: 0x060017B8 RID: 6072 RVA: 0x000D7D0A File Offset: 0x000D5F0A
		' (set) Token: 0x060017B9 RID: 6073 RVA: 0x000D7D14 File Offset: 0x000D5F14
		Friend Overridable Property lblCreated As ComboBox

		' Token: 0x1700092E RID: 2350
		' (get) Token: 0x060017BA RID: 6074 RVA: 0x000D7D1D File Offset: 0x000D5F1D
		' (set) Token: 0x060017BB RID: 6075 RVA: 0x000D7D28 File Offset: 0x000D5F28
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

		' Token: 0x1700092F RID: 2351
		' (get) Token: 0x060017BC RID: 6076 RVA: 0x000D7D6B File Offset: 0x000D5F6B
		' (set) Token: 0x060017BD RID: 6077 RVA: 0x000D7D75 File Offset: 0x000D5F75
		Friend Overridable Property grpListButton As GroupBox

		' Token: 0x17000930 RID: 2352
		' (get) Token: 0x060017BE RID: 6078 RVA: 0x000D7D7E File Offset: 0x000D5F7E
		' (set) Token: 0x060017BF RID: 6079 RVA: 0x000D7D88 File Offset: 0x000D5F88
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x17000931 RID: 2353
		' (get) Token: 0x060017C0 RID: 6080 RVA: 0x000D7D91 File Offset: 0x000D5F91
		' (set) Token: 0x060017C1 RID: 6081 RVA: 0x000D7D9C File Offset: 0x000D5F9C
		Friend Overridable Property btnWithoutPO As Button
			<CompilerGenerated()>
			Get
				Return Me._btnWithoutPO
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnWithoutPO_Click
				Dim button As Button = Me._btnWithoutPO
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnWithoutPO = value
				button = Me._btnWithoutPO
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000932 RID: 2354
		' (get) Token: 0x060017C2 RID: 6082 RVA: 0x000D7DDF File Offset: 0x000D5FDF
		' (set) Token: 0x060017C3 RID: 6083 RVA: 0x000D7DEC File Offset: 0x000D5FEC
		Friend Overridable Property btnWithPO As Button
			<CompilerGenerated()>
			Get
				Return Me._btnWithPO
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnWithPO_Click
				Dim button As Button = Me._btnWithPO
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnWithPO = value
				button = Me._btnWithPO
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000933 RID: 2355
		' (get) Token: 0x060017C4 RID: 6084 RVA: 0x000D7E2F File Offset: 0x000D602F
		' (set) Token: 0x060017C5 RID: 6085 RVA: 0x000D7E3C File Offset: 0x000D603C
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

		' Token: 0x17000934 RID: 2356
		' (get) Token: 0x060017C6 RID: 6086 RVA: 0x000D7E7F File Offset: 0x000D607F
		' (set) Token: 0x060017C7 RID: 6087 RVA: 0x000D7E8C File Offset: 0x000D608C
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

		' Token: 0x17000935 RID: 2357
		' (get) Token: 0x060017C8 RID: 6088 RVA: 0x000D7ECF File Offset: 0x000D60CF
		' (set) Token: 0x060017C9 RID: 6089 RVA: 0x000D7EDC File Offset: 0x000D60DC
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

		' Token: 0x17000936 RID: 2358
		' (get) Token: 0x060017CA RID: 6090 RVA: 0x000D7F1F File Offset: 0x000D611F
		' (set) Token: 0x060017CB RID: 6091 RVA: 0x000D7F29 File Offset: 0x000D6129
		Friend Overridable Property lblRows As Label

		' Token: 0x17000937 RID: 2359
		' (get) Token: 0x060017CC RID: 6092 RVA: 0x000D7F32 File Offset: 0x000D6132
		' (set) Token: 0x060017CD RID: 6093 RVA: 0x000D7F3C File Offset: 0x000D613C
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

		' Token: 0x17000938 RID: 2360
		' (get) Token: 0x060017CE RID: 6094 RVA: 0x000D7F7F File Offset: 0x000D617F
		' (set) Token: 0x060017CF RID: 6095 RVA: 0x000D7F8C File Offset: 0x000D618C
		Friend Overridable Property btnGRNBMR As Button
			<CompilerGenerated()>
			Get
				Return Me._btnGRNBMR
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnGRNBMR_Click
				Dim button As Button = Me._btnGRNBMR
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnGRNBMR = value
				button = Me._btnGRNBMR
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000939 RID: 2361
		' (get) Token: 0x060017D0 RID: 6096 RVA: 0x000D7FCF File Offset: 0x000D61CF
		' (set) Token: 0x060017D1 RID: 6097 RVA: 0x000D7FD9 File Offset: 0x000D61D9
		Friend Overridable Property cmbGRNType As ComboBox

		' Token: 0x1700093A RID: 2362
		' (get) Token: 0x060017D2 RID: 6098 RVA: 0x000D7FE2 File Offset: 0x000D61E2
		' (set) Token: 0x060017D3 RID: 6099 RVA: 0x000D7FEC File Offset: 0x000D61EC
		Friend Overridable Property Label7 As Label

		' Token: 0x060017D4 RID: 6100 RVA: 0x000D7FF8 File Offset: 0x000D61F8
		Public Sub New(sForm As String, GRNType As String)
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.InitializeComponent()
			Me.pnlBasicDefaultHeight = Me.GbBasic.Height
			Me.pnlBasicSetHeight = 23
			Me.pnlAdvDefaultHeight = 23
			Me.pnlAdvSetHeight = Me.GbAdvanced.Height
			Me.sFormType = sForm
			Me.sGRNType = GRNType
			Me.Text = Me.sFormType + " List"
			MyBase.TabText = Me.sFormType + " List"
		End Sub

		' Token: 0x060017D5 RID: 6101 RVA: 0x000D80A8 File Offset: 0x000D62A8
		Private Sub SetSearchPanel()
			Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
			Me.GbBasic.Height = Me.pnlBasicDefaultHeight
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
		End Sub

		' Token: 0x060017D6 RID: 6102 RVA: 0x000D80FC File Offset: 0x000D62FC
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

		' Token: 0x060017D7 RID: 6103 RVA: 0x000D816C File Offset: 0x000D636C
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

		' Token: 0x060017D8 RID: 6104 RVA: 0x000D81DC File Offset: 0x000D63DC
		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x060017D9 RID: 6105 RVA: 0x000D8211 File Offset: 0x000D6411
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Me.SetSearchPanel()
			Designing.SetTheme(Me)
			Me.FillCombo()
			Me.ClearList()
			Me.SetForm()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x060017DA RID: 6106 RVA: 0x000D8250 File Offset: 0x000D6450
		Private Sub FillCombo()
			Dim text As String = "SELECT VendorID, VendorName FROM Vendor ORDER BY VendorName"
			Dim data As DataTable = MainModule.GetData(text)
			Me.cmbVendor.ValueMember = "VendorID"
			Me.cmbVendor.DisplayMember = "VendorName"
			Me.cmbVendor.DataSource = data
			Me.cmbVendor.SelectedIndex = -1
		End Sub

		' Token: 0x060017DB RID: 6107 RVA: 0x000D82A8 File Offset: 0x000D64A8
		Private Sub SetForm()
			Me.cmbGRNType.Text = Me.sGRNType
			Dim text As String = Me.sFormType
			Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(text)
			If num <= 1991191371UI Then
				If num <= 1521117455UI Then
					If num <> 1409100530UI Then
						If num = 1521117455UI Then
							If Operators.CompareString(text, "GRN PO Receipt", False) = 0 Then
								Me.lblDate.Text = "P.O. Date"
								Me.btnWithPO.Visible = True
								Me.SearchPO("")
							End If
						End If
					ElseIf Operators.CompareString(text, "GRN QC Entry", False) = 0 Then
						Me.cmbStatus.Items.Remove("Cancelled")
						Me.cmbStatus.Items.Remove("GRN In Approval")
						Me.cmbStatus.Text = "GRN Approved"
						Me.SearchData("")
					End If
				ElseIf num <> 1541909723UI Then
					If num = 1991191371UI Then
						If Operators.CompareString(text, "GRN Printing", False) = 0 Then
							Me.cmbStatus.Items.Remove("Cancelled")
							Me.cmbStatus.Items.Remove("GRN In Approval")
							Me.cmbStatus.Text = "GRN Approved"
							Me.SearchData("")
						End If
					End If
				ElseIf Operators.CompareString(text, "GRN QC Release", False) = 0 Then
					Me.cmbStatus.Items.Remove("Cancelled")
					Me.cmbStatus.Items.Remove("GRN In Approval")
					Me.cmbStatus.Items.Remove("GRN Approved")
					Me.cmbStatus.Text = "QC Saved"
					Me.SearchData("")
				End If
			ElseIf num <= 2730242907UI Then
				If num <> 2668735510UI Then
					If num = 2730242907UI Then
						If Operators.CompareString(text, "GRN On-Hold", False) = 0 Then
							MyBase.TabText = "GRN On-Hold List"
							Me.cmbStatus.Text = "GRN On-Hold"
							Me.SearchData("")
						End If
					End If
				ElseIf Operators.CompareString(text, "GRN", False) <> 0 Then
				End If
			ElseIf num <> 2833639041UI Then
				If num = 2924031041UI Then
					If Operators.CompareString(text, "GRN Approval", False) = 0 Then
						Me.cmbStatus.Items.Remove("Cancelled")
						Me.cmbStatus.Text = "GRN In Approval"
						Me.SearchData("")
					End If
				End If
			ElseIf Operators.CompareString(text, "GRN Cancellation", False) = 0 Then
				Me.cmbStatus.Items.Remove("QC Saved")
				Me.cmbStatus.Items.Remove("QC Complete")
			End If
		End Sub

		' Token: 0x060017DC RID: 6108 RVA: 0x000D85D8 File Offset: 0x000D67D8
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
			Me.cmbSummary.Text = "Transaction-wise"
			Me.txtCode.Text = ""
			Me.txtCatalogNo.Text = ""
			Me.txtName.Text = ""
			Me.dgvList.DataSource = Nothing
		End Sub

		' Token: 0x060017DD RID: 6109 RVA: 0x000D8711 File Offset: 0x000D6911
		Private Sub btnClearList_Click(sender As Object, e As EventArgs)
			Me.ClearList()
		End Sub

		' Token: 0x060017DE RID: 6110 RVA: 0x000D871B File Offset: 0x000D691B
		Private Sub btnExport_Click(sender As Object, e As EventArgs)
			MainModule.ExportToExcel(Me.dgvList, Me.Text)
		End Sub

		' Token: 0x060017DF RID: 6111 RVA: 0x000D8730 File Offset: 0x000D6930
		Private Sub cmbSummary_SelectedValueChanged(sender As Object, e As EventArgs)
			Me.SetSummary()
		End Sub

		' Token: 0x060017E0 RID: 6112 RVA: 0x000D873C File Offset: 0x000D693C
		Private Sub SetSummary()
			Dim text As String = Me.cmbSummary.Text
			If Operators.CompareString(text, "Transaction-wise", False) <> 0 Then
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

		' Token: 0x060017E1 RID: 6113 RVA: 0x000D8840 File Offset: 0x000D6A40
		Private Sub cmbVendor_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbVendor.SelectedIndex = -1
			If flag Then
				Me.cmbVendor.Text = ""
			End If
		End Sub

		' Token: 0x060017E2 RID: 6114 RVA: 0x000D8874 File Offset: 0x000D6A74
		Private Sub btnWithoutPO_Click(sender As Object, e As EventArgs)
			Dim grn As GRN = New GRN("GRN Entry", "Receipt", Nothing)
			grn.Show(MyBase.DockPanel)
		End Sub

		' Token: 0x060017E3 RID: 6115 RVA: 0x000D88A0 File Offset: 0x000D6AA0
		Private Sub btnGRNBMR_Click(sender As Object, e As EventArgs)
			Dim grn As GRN = New GRN("GRN Entry", "BMR", Nothing)
			grn.Show(MyBase.DockPanel)
		End Sub

		' Token: 0x060017E4 RID: 6116 RVA: 0x000D88CC File Offset: 0x000D6ACC
		Private Sub btnWithPO_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SearchPO("")
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x060017E5 RID: 6117 RVA: 0x000D8940 File Offset: 0x000D6B40
		Private Sub SearchPO(sID As String)
			Dim text As String = ""
			Dim flag As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Transaction-wise", False) = 0
			Dim text2 As String
			If flag Then
				text2 = " SELECT P.POID, P.Status POStatus, P.POType, P.PONo, P.PODt, P.ValidUpto, P.DeliveryInDays, P.DeliveryDt, " & vbCrLf
				text2 += " P.Department, P.InvoiceAddress, P.BillingEmailID, P.ShipAddress, P.ShippingEmailID, P.GSTNo, P.PANNo, " & vbCrLf
				text2 += " P.VendorID, V.VendorName, P.VendorBillingAddress, P.VendorContactPerson, " & vbCrLf
				text2 += " P.VendorContactNo, P.VendorEmailID, P.VendorGSTNo, P.VendorPANNo, " & vbCrLf
				text2 += " P.ModeOfPayment, P.DispatchedThrough, P.PaymentTerms, P.IncoTerms, P.DeliveryTerms, P.Currency, " & vbCrLf
				text2 += " Action.UserName AS ActionBy, P.ActionDt, P.PrintBy, P.PrintDt, " & vbCrLf
				text2 += " '' AS CreatedByEmailID, '' AS ModifiedByEmailID, " & vbCrLf
				text2 += " P.CreationDt, Created.UserName AS CreatedBy, P.ModificationDt, Modified.UserName AS ModifiedBy " & vbCrLf
				text2 += " FROM PO AS P " & vbCrLf
				text2 += " INNER JOIN Vendor AS V ON P.VendorID = V.VendorID " & vbCrLf
				text2 += " INNER JOIN( SELECT DISTINCT POID FROM POItems POI " & vbCrLf
				text2 += "             INNER JOIN Product Prod ON POI.ProductID = Prod.ProductID " & vbCrLf
				text2 += "             WHERE Prod.IsGRNApplicable = 1) GRNApp ON P.POID = GRNApp.POID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Action ON P.ActionBy = Action.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Created ON P.CreatedBy = Created.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Modified ON P.ModifiedBy = Modified.UserID " & vbCrLf
			Else
				text2 = " SELECT P.POID, P.Status POStatus, P.POType, P.PONo, P.PODt, Pr.ProductName, " & vbCrLf
				text2 += " P.ValidUpto, P.DeliveryInDays, P.DeliveryDt, Pr.ProductType, Pr.ProductCode, Pr.CatalogNo, PI.Quantity, " & vbCrLf
				text2 += " P.Department, P.InvoiceAddress, P.BillingEmailID, P.ShipAddress, P.ShippingEmailID, P.GSTNo, P.PANNo, " & vbCrLf
				text2 += " P.VendorID, V.VendorName, P.VendorBillingAddress, P.VendorContactPerson, " & vbCrLf
				text2 += " P.VendorContactNo, P.VendorEmailID, P.VendorGSTNo, P.VendorPANNo,  " & vbCrLf
				text2 += " P.ModeOfPayment, P.DispatchedThrough, P.PaymentTerms, P.IncoTerms, P.DeliveryTerms, P.Currency, " & vbCrLf
				text2 += " Action.UserName AS ActionBy, P.ActionDt, P.PrintBy, P.PrintDt, " & vbCrLf
				text2 += " '' AS CreatedByEmailID, '' AS ModifiedByEmailID, " & vbCrLf
				text2 += " P.CreationDt, Created.UserName AS CreatedBy, P.ModificationDt, Modified.UserName AS ModifiedBy " & vbCrLf
				text2 += " FROM PO AS P " & vbCrLf
				text2 += " INNER JOIN Vendor AS V ON P.VendorID = V.VendorID " & vbCrLf
				text2 += " INNER JOIN( SELECT DISTINCT POID FROM POItems POI " & vbCrLf
				text2 += "              INNER JOIN Product Prod ON POI.ProductID = Prod.ProductID " & vbCrLf
				text2 += "              WHERE Prod.IsGRNApplicable = 1) GRNApp ON P.POID = GRNApp.POID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Action ON P.ActionBy = Action.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Created ON P.CreatedBy = Created.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Modified ON P.ModifiedBy = Modified.UserID " & vbCrLf
				text2 += " INNER JOIN POItems AS PI ON P.POID = PI.POID " & vbCrLf
				text2 += " INNER JOIN Product Pr ON PI.ProductID = Pr.ProductID " & vbCrLf
			End If
			text2 += " WHERE 1=1" & vbCrLf
			text2 += " AND P.Status = 'Printed' AND P.POType = 'Item'"
			Dim flag2 As Boolean = Operators.CompareString(Strings.Trim(Me.txtPONo.Text), "", False) <> 0
			If flag2 Then
				text2 = text2 + " AND (PONo LIKE '%" + Strings.Trim(Me.txtPONo.Text) + "%')" & vbCrLf
				text = text + "PONo LIKE " + Strings.Trim(Me.txtPONo.Text) + vbCrLf
			End If
			Dim flag3 As Boolean = Me.cmbVendor.SelectedIndex > -1
			If flag3 Then
				text2 = text2 + " AND (P.VendorID = '" + Strings.Trim(Me.cmbVendor.SelectedValue.ToString()) + "')" & vbCrLf
				text = text + "VendorID = " + Strings.Trim(Me.cmbVendor.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag4 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCreated.Text), "", False) <> 0
			If flag4 Then
				Dim flag5 As Boolean = Me.lblCreated.SelectedIndex >= 0
				If flag5 Then
					Dim flag6 As Boolean = Me.lblCreated.SelectedIndex = 0
					Dim text3 As String
					If flag6 Then
						text3 = "Created"
					Else
						text3 = "Modified"
					End If
					text2 = String.Concat(New String() { text2, " AND ", text3, ".UserName LIKE '%", Strings.Trim(Me.txtCreated.Text), "%'" })
					text = text + (text3 + "By LIKE " + Strings.Trim(Me.txtCreated.Text)) + vbCrLf
				End If
			End If
			Dim flag7 As Boolean = Me.lblDate.SelectedIndex >= 0
			If flag7 Then
				Dim text4 As String = Me.lblDate.Text
				Dim text5 As String
				If Operators.CompareString(text4, "Creation", False) <> 0 Then
					If Operators.CompareString(text4, "Last Modification", False) <> 0 Then
						If Operators.CompareString(text4, "P.O. Date", False) <> 0 Then
							If Operators.CompareString(text4, "P.R. Date", False) <> 0 Then
								If Operators.CompareString(text4, "Delivery Date", False) <> 0 Then
									text5 = ""
								Else
									text5 = "G.DeliveryDt"
								End If
							Else
								text5 = "G.PRDt"
							End If
						Else
							text5 = "P.PODt"
						End If
					Else
						text5 = "P.ModificationDt"
					End If
				Else
					text5 = "P.CreationDt"
				End If
				Dim flag8 As Boolean = Operators.CompareString(text5, "", False) <> 0
				If flag8 Then
					Dim flag9 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
					If flag9 Then
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
			Dim flag10 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Item-wise", False) = 0
			If flag10 Then
				Dim flag11 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCode.Text), "", False) <> 0
				If flag11 Then
					text2 = text2 + " AND (Pr.ProductCode Like '%" + Strings.Trim(Me.txtCode.Text) + "%') "
					text = text + "ProductCode LIKE " + Strings.Trim(Me.txtCode.Text) + vbCrLf
				End If
				Dim flag12 As Boolean = Operators.CompareString(Strings.Trim(Me.txtName.Text), "", False) <> 0
				If flag12 Then
					text2 = text2 + " AND (Pr.ProductName Like '%" + Strings.Trim(Me.txtName.Text) + "%') "
					text = text + "ProductName LIKE " + Strings.Trim(Me.txtName.Text) + vbCrLf
				End If
				Dim flag13 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCatalogNo.Text), "", False) <> 0
				If flag13 Then
					text2 = text2 + " AND (Pr.CatalogNo Like '%" + Strings.Trim(Me.txtCatalogNo.Text) + "%') "
					text = text + "CatalogNo LIKE " + Strings.Trim(Me.txtCatalogNo.Text) + vbCrLf
				End If
			End If
			text2 += " ORDER BY PONo"
			Dim data As DataTable = MainModule.GetData(text2)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = Nothing
			Me.dgvList.DataSource = data
			Me.dgvList.Columns("POID").Visible = False
			Me.dgvList.Columns("VendorID").Visible = False
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
			Me.dgvList.Columns("POStatus").HeaderText = "PO Status"
			Me.dgvList.Columns("CreationDt").HeaderText = "Creation Date"
			Me.dgvList.Columns("CreatedBy").HeaderText = "Created By"
			Me.dgvList.Columns("ModificationDt").HeaderText = "Modification Date"
			Me.dgvList.Columns("ModifiedBy").HeaderText = "Modified By"
			Me.dgvList.Columns("PODt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("DeliveryDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("ValidUpto").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("ActionDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("PrintDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("CreationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			Me.dgvList.Columns("ModificationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
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
			Me.dgvList.Columns("POStatus").Width = 132
			Me.dgvList.Columns("CreationDt").Width = 170
			Me.dgvList.Columns("CreatedBy").Width = 140
			Me.dgvList.Columns("ModificationDt").Width = 170
			Me.dgvList.Columns("ModifiedBy").Width = 140
			Dim flag14 As Boolean = data.Columns.Contains("ProductCode")
			If flag14 Then
				Me.dgvList.Columns("ProductCode").HeaderText = "Product Code"
				Me.dgvList.Columns("CatalogNo").HeaderText = "Catalog No."
				Me.dgvList.Columns("ProductName").HeaderText = "Product Name"
				Me.dgvList.Columns("ProductType").HeaderText = "Product Type"
				Me.dgvList.Columns("Quantity").HeaderText = "PO Quantity"
				Me.dgvList.Columns("ProductCode").Width = 180
				Me.dgvList.Columns("CatalogNo").Width = 180
				Me.dgvList.Columns("ProductName").Width = 300
				Me.dgvList.Columns("ProductType").Width = 110
				Me.dgvList.Columns("Quantity").Width = 60
				Me.dgvList.Columns("Quantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
			MainModule.TrnLog(Me.Text, "Searched PO", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x060017E6 RID: 6118 RVA: 0x000D9D64 File Offset: 0x000D7F64
		Private Sub btnSearch_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SearchData("")
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x060017E7 RID: 6119 RVA: 0x000D9DD8 File Offset: 0x000D7FD8
		Private Sub SearchData(sID As String)
			Dim text As String = ""
			Dim flag As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Transaction-wise", False) = 0
			Dim text2 As String
			If flag Then
				text2 = " SELECT DISTINCT G.GRNID, G.Status GRNStatus, G.GRNType, G.GRNNo, G.GRNDt, G.VendorID, V.VendorName, " & vbCrLf
				text2 += " G.POID, G.POType, G.PONo, G.PODt, G.InvoiceNo, G.InvoiceDt, G.ChallanNo, G.ChallanDt, " & vbCrLf
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
				text2 = " SELECT DISTINCT G.GRNID, G.Status GRNStatus, GI.Status AS Item_Status, G.GRNType, G.GRNNo, G.GRNDt, P.ProductName, G.VendorID, V.VendorName, " & vbCrLf
				text2 += " G.POID, G.POType, G.PONo, G.PODt, G.InvoiceNo, G.InvoiceDt, G.ChallanNo, G.ChallanDt, " & vbCrLf
				text2 += " G.Remarks, G.ActionRemarks, " & vbCrLf
				text2 += " Action.UserName AS ActionBy, G.ActionDt, P.ProductCode, P.CatalogNo, P.ProductType, GI.BatchNo, GI.MfgDt, GI.ExpDt, " & vbCrLf
				text2 += " P.TertiaryUOM, P.PrimaryUOM, GI.TertiaryPackSize, GI.PrimaryPackSize, GI.ReceivedQty, " & vbCrLf
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
			Dim text3 As String = Me.sFormType
			If Operators.CompareString(text3, "GRN", False) <> 0 Then
				If Operators.CompareString(text3, "GRN Approval", False) <> 0 Then
					If Operators.CompareString(text3, "GRN Printing", False) <> 0 Then
						If Operators.CompareString(text3, "GRN QC Entry", False) <> 0 Then
							If Operators.CompareString(text3, "GRN QC Release", False) = 0 Then
								text2 += " AND G.Status IN ('Under Release', 'Release Complete')" & vbCrLf
								text2 += " AND GI.IsQCApplicable <> 0 " & vbCrLf
							End If
						Else
							text2 += " AND G.Status IN ('GRN Approved', 'Under Release', 'Release Complete')" & vbCrLf
							text2 += " AND GI.IsQCApplicable <> 0 " & vbCrLf
						End If
					Else
						text2 += " AND (G.Status IN ('GRN Approved', 'Under Release', 'Release Complete'))" & vbCrLf
					End If
				End If
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
			Dim flag10 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCreated.Text), "", False) <> 0
			If flag10 Then
				Dim flag11 As Boolean = Me.lblCreated.SelectedIndex >= 0
				If flag11 Then
					Dim flag12 As Boolean = Me.lblCreated.SelectedIndex = 0
					Dim text4 As String
					If flag12 Then
						text4 = "Created"
					Else
						text4 = "Modified"
					End If
					text2 = String.Concat(New String() { text2, " AND ", text4, ".UserName LIKE '%", Strings.Trim(Me.txtCreated.Text), "%'" })
					text = text + (text4 + "By LIKE " + Strings.Trim(Me.txtCreated.Text)) + vbCrLf
				End If
			End If
			Dim flag13 As Boolean = Me.lblDate.SelectedIndex >= 0
			If flag13 Then
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
				Dim flag14 As Boolean = Operators.CompareString(text6, "", False) <> 0
				If flag14 Then
					Dim flag15 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
					If flag15 Then
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
			Dim flag16 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Item-wise", False) = 0
			If flag16 Then
				Dim flag17 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCode.Text), "", False) <> 0
				If flag17 Then
					text2 = text2 + " AND (P.ProductCode Like '%" + Strings.Trim(Me.txtCode.Text) + "%') "
					text = text + "ProductCode LIKE " + Strings.Trim(Me.txtCode.Text) + vbCrLf
				End If
				Dim flag18 As Boolean = Operators.CompareString(Strings.Trim(Me.txtName.Text), "", False) <> 0
				If flag18 Then
					text2 = text2 + " AND (P.ProductName Like '%" + Strings.Trim(Me.txtName.Text) + "%') "
					text = text + "ProductName LIKE " + Strings.Trim(Me.txtName.Text) + vbCrLf
				End If
				Dim flag19 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCatalogNo.Text), "", False) <> 0
				If flag19 Then
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
			Me.dgvList.Columns("ActionBy").HeaderText = "Action By"
			Me.dgvList.Columns("ActionDt").HeaderText = "Action Date"
			Me.dgvList.Columns("CreationDt").HeaderText = "Creation Date"
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
				Me.dgvList.Columns("MfgDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
				Me.dgvList.Columns("ExpDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
				Me.dgvList.Columns("TertiaryPackSize").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("PrimaryPackSize").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("ReceivedQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x060017E8 RID: 6120 RVA: 0x000DB36C File Offset: 0x000D956C
		Private Sub dgvList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = (e.RowIndex > -1) And (e.ColumnIndex > -1)
			If flag Then
				Dim text As String = Me.sFormType
				Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(text)
				If num <= 1541909723UI Then
					If num <> 1409100530UI Then
						If num <> 1521117455UI Then
							If num = 1541909723UI Then
								If Operators.CompareString(text, "GRN QC Release", False) = 0 Then
									Dim dataTable As DataTable = CType(Me.dgvList.DataSource, DataTable)
									Dim dataRow As DataRow = dataTable.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("GRNID = '", Me.dgvList.Rows(e.RowIndex).Cells("GRNID").Value), "'")))(0)
									Dim qcrelease As QCRelease01 = New QCRelease01(Me.sFormType, dataRow)
									qcrelease.ShowDialog()
								End If
							End If
						ElseIf Operators.CompareString(text, "GRN PO Receipt", False) = 0 Then
							Dim dataTable2 As DataTable = CType(Me.dgvList.DataSource, DataTable)
							Dim flag2 As Boolean = dataTable2.Columns.Contains("POID")
							If flag2 Then
								dataTable2.TableName = "PO"
								Dim dataRow2 As DataRow = dataTable2.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("POID = '", Me.dgvList.Rows(e.RowIndex).Cells("POID").Value), "'")))(0)
								Dim grn As GRN = New GRN("GRN Entry - Against PO", "Receipt", dataRow2)
								grn.Show(MyBase.DockPanel)
							End If
						End If
					ElseIf Operators.CompareString(text, "GRN QC Entry", False) = 0 Then
						Dim dataTable3 As DataTable = CType(Me.dgvList.DataSource, DataTable)
						Dim dataRow3 As DataRow = dataTable3.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("GRNID = '", Me.dgvList.Rows(e.RowIndex).Cells("GRNID").Value), "'")))(0)
						Dim qcrelease2 As QCRelease01 = New QCRelease01(Me.sFormType, dataRow3)
						qcrelease2.ShowDialog()
					End If
				Else
					If num <= 2668735510UI Then
						If num <> 1991191371UI Then
							If num <> 2668735510UI Then
								GoTo IL_04B5
							End If
							If Operators.CompareString(text, "GRN", False) <> 0 Then
								GoTo IL_04B5
							End If
						Else
							If Operators.CompareString(text, "GRN Printing", False) <> 0 Then
								GoTo IL_04B5
							End If
							GoTo IL_04B5
						End If
					ElseIf num <> 2730242907UI Then
						If num <> 2924031041UI Then
							GoTo IL_04B5
						End If
						If Operators.CompareString(text, "GRN Approval", False) <> 0 Then
							GoTo IL_04B5
						End If
						Dim dataTable4 As DataTable = CType(Me.dgvList.DataSource, DataTable)
						Dim dataRow4 As DataRow = dataTable4.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("GRNID = '", Me.dgvList.Rows(e.RowIndex).Cells("GRNID").Value), "'")))(0)
						Dim grn2 As GRN = New GRN("GRN Approval", Conversions.ToString(dataRow4("GRNType")), dataRow4)
						grn2.Show(MyBase.DockPanel)
						GoTo IL_04B5
					ElseIf Operators.CompareString(text, "GRN On-Hold", False) <> 0 Then
						GoTo IL_04B5
					End If
					Dim dataTable5 As DataTable = CType(Me.dgvList.DataSource, DataTable)
					Dim flag3 As Boolean = dataTable5.Columns.Contains("GRNID")
					If flag3 Then
						dataTable5.TableName = "GRN"
						Dim dataRow5 As DataRow = dataTable5.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("GRNID = '", Me.dgvList.Rows(e.RowIndex).Cells("GRNID").Value), "'")))(0)
						Dim grn3 As GRN = New GRN("GRN Modify", Conversions.ToString(dataRow5("GRNType")), dataRow5)
						grn3.Show(MyBase.DockPanel)
					Else
						Dim flag4 As Boolean = dataTable5.Columns.Contains("POID")
						If Not flag4 Then
							Return
						End If
						dataTable5.TableName = "PO"
						Dim dataRow5 As DataRow = dataTable5.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("POID = '", Me.dgvList.Rows(e.RowIndex).Cells("POID").Value), "'")))(0)
						Dim grn4 As GRN = New GRN("GRN Entry - Against PO", "Receipt", dataRow5)
						grn4.Show(MyBase.DockPanel)
					End If
				End If
				IL_04B5:
				Me.SearchData("")
			End If
		End Sub

		' Token: 0x04000A3F RID: 2623
		Private sFormType As String

		' Token: 0x04000A40 RID: 2624
		Private sGRNType As String

		' Token: 0x04000A41 RID: 2625
		Private pnlBasicDefaultHeight As Integer

		' Token: 0x04000A42 RID: 2626
		Private pnlBasicSetHeight As Integer

		' Token: 0x04000A43 RID: 2627
		Private pnlAdvDefaultHeight As Integer

		' Token: 0x04000A44 RID: 2628
		Private pnlAdvSetHeight As Integer
	End Class
End Namespace
