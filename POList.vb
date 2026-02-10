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
	' Token: 0x02000067 RID: 103
	<DesignerGenerated()>
	Public Partial Class POList
		Inherits DockContent

		' Token: 0x17000A55 RID: 2645
		' (get) Token: 0x06001A98 RID: 6808 RVA: 0x000F6E55 File Offset: 0x000F5055
		' (set) Token: 0x06001A99 RID: 6809 RVA: 0x000F6E5F File Offset: 0x000F505F
		Friend Overridable Property GbBasic As GroupBox

		' Token: 0x17000A56 RID: 2646
		' (get) Token: 0x06001A9A RID: 6810 RVA: 0x000F6E68 File Offset: 0x000F5068
		' (set) Token: 0x06001A9B RID: 6811 RVA: 0x000F6E72 File Offset: 0x000F5072
		Friend Overridable Property Label2 As Label

		' Token: 0x17000A57 RID: 2647
		' (get) Token: 0x06001A9C RID: 6812 RVA: 0x000F6E7B File Offset: 0x000F507B
		' (set) Token: 0x06001A9D RID: 6813 RVA: 0x000F6E85 File Offset: 0x000F5085
		Friend Overridable Property txtPRNo As TextBox

		' Token: 0x17000A58 RID: 2648
		' (get) Token: 0x06001A9E RID: 6814 RVA: 0x000F6E8E File Offset: 0x000F508E
		' (set) Token: 0x06001A9F RID: 6815 RVA: 0x000F6E98 File Offset: 0x000F5098
		Friend Overridable Property cmbPlant As ComboBox

		' Token: 0x17000A59 RID: 2649
		' (get) Token: 0x06001AA0 RID: 6816 RVA: 0x000F6EA1 File Offset: 0x000F50A1
		' (set) Token: 0x06001AA1 RID: 6817 RVA: 0x000F6EAB File Offset: 0x000F50AB
		Friend Overridable Property Label1 As Label

		' Token: 0x17000A5A RID: 2650
		' (get) Token: 0x06001AA2 RID: 6818 RVA: 0x000F6EB4 File Offset: 0x000F50B4
		' (set) Token: 0x06001AA3 RID: 6819 RVA: 0x000F6EBE File Offset: 0x000F50BE
		Friend Overridable Property txtNo As TextBox

		' Token: 0x17000A5B RID: 2651
		' (get) Token: 0x06001AA4 RID: 6820 RVA: 0x000F6EC7 File Offset: 0x000F50C7
		' (set) Token: 0x06001AA5 RID: 6821 RVA: 0x000F6ED1 File Offset: 0x000F50D1
		Friend Overridable Property dtpFrom As DateTimePicker

		' Token: 0x17000A5C RID: 2652
		' (get) Token: 0x06001AA6 RID: 6822 RVA: 0x000F6EDA File Offset: 0x000F50DA
		' (set) Token: 0x06001AA7 RID: 6823 RVA: 0x000F6EE4 File Offset: 0x000F50E4
		Friend Overridable Property dtpTo As DateTimePicker

		' Token: 0x17000A5D RID: 2653
		' (get) Token: 0x06001AA8 RID: 6824 RVA: 0x000F6EED File Offset: 0x000F50ED
		' (set) Token: 0x06001AA9 RID: 6825 RVA: 0x000F6EF7 File Offset: 0x000F50F7
		Friend Overridable Property Label16 As Label

		' Token: 0x17000A5E RID: 2654
		' (get) Token: 0x06001AAA RID: 6826 RVA: 0x000F6F00 File Offset: 0x000F5100
		' (set) Token: 0x06001AAB RID: 6827 RVA: 0x000F6F0A File Offset: 0x000F510A
		Friend Overridable Property lblDate As ComboBox

		' Token: 0x17000A5F RID: 2655
		' (get) Token: 0x06001AAC RID: 6828 RVA: 0x000F6F13 File Offset: 0x000F5113
		' (set) Token: 0x06001AAD RID: 6829 RVA: 0x000F6F20 File Offset: 0x000F5120
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

		' Token: 0x17000A60 RID: 2656
		' (get) Token: 0x06001AAE RID: 6830 RVA: 0x000F6F63 File Offset: 0x000F5163
		' (set) Token: 0x06001AAF RID: 6831 RVA: 0x000F6F6D File Offset: 0x000F516D
		Friend Overridable Property GbAdvanced As GroupBox

		' Token: 0x17000A61 RID: 2657
		' (get) Token: 0x06001AB0 RID: 6832 RVA: 0x000F6F76 File Offset: 0x000F5176
		' (set) Token: 0x06001AB1 RID: 6833 RVA: 0x000F6F80 File Offset: 0x000F5180
		Friend Overridable Property pnlItem As Panel

		' Token: 0x17000A62 RID: 2658
		' (get) Token: 0x06001AB2 RID: 6834 RVA: 0x000F6F89 File Offset: 0x000F5189
		' (set) Token: 0x06001AB3 RID: 6835 RVA: 0x000F6F93 File Offset: 0x000F5193
		Friend Overridable Property txtName As TextBox

		' Token: 0x17000A63 RID: 2659
		' (get) Token: 0x06001AB4 RID: 6836 RVA: 0x000F6F9C File Offset: 0x000F519C
		' (set) Token: 0x06001AB5 RID: 6837 RVA: 0x000F6FA6 File Offset: 0x000F51A6
		Friend Overridable Property txtCatalogNo As TextBox

		' Token: 0x17000A64 RID: 2660
		' (get) Token: 0x06001AB6 RID: 6838 RVA: 0x000F6FAF File Offset: 0x000F51AF
		' (set) Token: 0x06001AB7 RID: 6839 RVA: 0x000F6FB9 File Offset: 0x000F51B9
		Friend Overridable Property Label14 As Label

		' Token: 0x17000A65 RID: 2661
		' (get) Token: 0x06001AB8 RID: 6840 RVA: 0x000F6FC2 File Offset: 0x000F51C2
		' (set) Token: 0x06001AB9 RID: 6841 RVA: 0x000F6FCC File Offset: 0x000F51CC
		Friend Overridable Property Label5 As Label

		' Token: 0x17000A66 RID: 2662
		' (get) Token: 0x06001ABA RID: 6842 RVA: 0x000F6FD5 File Offset: 0x000F51D5
		' (set) Token: 0x06001ABB RID: 6843 RVA: 0x000F6FDF File Offset: 0x000F51DF
		Friend Overridable Property txtCode As TextBox

		' Token: 0x17000A67 RID: 2663
		' (get) Token: 0x06001ABC RID: 6844 RVA: 0x000F6FE8 File Offset: 0x000F51E8
		' (set) Token: 0x06001ABD RID: 6845 RVA: 0x000F6FF2 File Offset: 0x000F51F2
		Friend Overridable Property Label6 As Label

		' Token: 0x17000A68 RID: 2664
		' (get) Token: 0x06001ABE RID: 6846 RVA: 0x000F6FFB File Offset: 0x000F51FB
		' (set) Token: 0x06001ABF RID: 6847 RVA: 0x000F7008 File Offset: 0x000F5208
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

		' Token: 0x17000A69 RID: 2665
		' (get) Token: 0x06001AC0 RID: 6848 RVA: 0x000F704B File Offset: 0x000F524B
		' (set) Token: 0x06001AC1 RID: 6849 RVA: 0x000F7055 File Offset: 0x000F5255
		Friend Overridable Property Label13 As Label

		' Token: 0x17000A6A RID: 2666
		' (get) Token: 0x06001AC2 RID: 6850 RVA: 0x000F705E File Offset: 0x000F525E
		' (set) Token: 0x06001AC3 RID: 6851 RVA: 0x000F7068 File Offset: 0x000F5268
		Friend Overridable Property cmbStatus As ComboBox

		' Token: 0x17000A6B RID: 2667
		' (get) Token: 0x06001AC4 RID: 6852 RVA: 0x000F7071 File Offset: 0x000F5271
		' (set) Token: 0x06001AC5 RID: 6853 RVA: 0x000F707B File Offset: 0x000F527B
		Friend Overridable Property Label11 As Label

		' Token: 0x17000A6C RID: 2668
		' (get) Token: 0x06001AC6 RID: 6854 RVA: 0x000F7084 File Offset: 0x000F5284
		' (set) Token: 0x06001AC7 RID: 6855 RVA: 0x000F7090 File Offset: 0x000F5290
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

		' Token: 0x17000A6D RID: 2669
		' (get) Token: 0x06001AC8 RID: 6856 RVA: 0x000F70D3 File Offset: 0x000F52D3
		' (set) Token: 0x06001AC9 RID: 6857 RVA: 0x000F70DD File Offset: 0x000F52DD
		Friend Overridable Property Label9 As Label

		' Token: 0x17000A6E RID: 2670
		' (get) Token: 0x06001ACA RID: 6858 RVA: 0x000F70E6 File Offset: 0x000F52E6
		' (set) Token: 0x06001ACB RID: 6859 RVA: 0x000F70F0 File Offset: 0x000F52F0
		Friend Overridable Property cmbType As ComboBox

		' Token: 0x17000A6F RID: 2671
		' (get) Token: 0x06001ACC RID: 6860 RVA: 0x000F70F9 File Offset: 0x000F52F9
		' (set) Token: 0x06001ACD RID: 6861 RVA: 0x000F7103 File Offset: 0x000F5303
		Friend Overridable Property Label24 As Label

		' Token: 0x17000A70 RID: 2672
		' (get) Token: 0x06001ACE RID: 6862 RVA: 0x000F710C File Offset: 0x000F530C
		' (set) Token: 0x06001ACF RID: 6863 RVA: 0x000F7116 File Offset: 0x000F5316
		Friend Overridable Property txtCreated As TextBox

		' Token: 0x17000A71 RID: 2673
		' (get) Token: 0x06001AD0 RID: 6864 RVA: 0x000F711F File Offset: 0x000F531F
		' (set) Token: 0x06001AD1 RID: 6865 RVA: 0x000F7129 File Offset: 0x000F5329
		Friend Overridable Property lblCreated As ComboBox

		' Token: 0x17000A72 RID: 2674
		' (get) Token: 0x06001AD2 RID: 6866 RVA: 0x000F7132 File Offset: 0x000F5332
		' (set) Token: 0x06001AD3 RID: 6867 RVA: 0x000F713C File Offset: 0x000F533C
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

		' Token: 0x17000A73 RID: 2675
		' (get) Token: 0x06001AD4 RID: 6868 RVA: 0x000F717F File Offset: 0x000F537F
		' (set) Token: 0x06001AD5 RID: 6869 RVA: 0x000F7189 File Offset: 0x000F5389
		Friend Overridable Property grpListButton As GroupBox

		' Token: 0x17000A74 RID: 2676
		' (get) Token: 0x06001AD6 RID: 6870 RVA: 0x000F7192 File Offset: 0x000F5392
		' (set) Token: 0x06001AD7 RID: 6871 RVA: 0x000F719C File Offset: 0x000F539C
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x17000A75 RID: 2677
		' (get) Token: 0x06001AD8 RID: 6872 RVA: 0x000F71A5 File Offset: 0x000F53A5
		' (set) Token: 0x06001AD9 RID: 6873 RVA: 0x000F71B0 File Offset: 0x000F53B0
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

		' Token: 0x17000A76 RID: 2678
		' (get) Token: 0x06001ADA RID: 6874 RVA: 0x000F71F3 File Offset: 0x000F53F3
		' (set) Token: 0x06001ADB RID: 6875 RVA: 0x000F7200 File Offset: 0x000F5400
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

		' Token: 0x17000A77 RID: 2679
		' (get) Token: 0x06001ADC RID: 6876 RVA: 0x000F7243 File Offset: 0x000F5443
		' (set) Token: 0x06001ADD RID: 6877 RVA: 0x000F7250 File Offset: 0x000F5450
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

		' Token: 0x17000A78 RID: 2680
		' (get) Token: 0x06001ADE RID: 6878 RVA: 0x000F7293 File Offset: 0x000F5493
		' (set) Token: 0x06001ADF RID: 6879 RVA: 0x000F729D File Offset: 0x000F549D
		Friend Overridable Property lblRows As Label

		' Token: 0x17000A79 RID: 2681
		' (get) Token: 0x06001AE0 RID: 6880 RVA: 0x000F72A6 File Offset: 0x000F54A6
		' (set) Token: 0x06001AE1 RID: 6881 RVA: 0x000F72B0 File Offset: 0x000F54B0
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

		' Token: 0x06001AE2 RID: 6882 RVA: 0x000F72F4 File Offset: 0x000F54F4
		Public Sub New(sForm As String)
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.InitializeComponent()
			Me.pnlBasicDefaultHeight = Me.GbBasic.Height
			Me.pnlBasicSetHeight = 24
			Me.pnlAdvDefaultHeight = 24
			Me.pnlAdvSetHeight = Me.GbAdvanced.Height
			Me.sFormType = sForm
			MyBase.TabText = Me.sFormType + " List"
		End Sub

		' Token: 0x06001AE3 RID: 6883 RVA: 0x000F7388 File Offset: 0x000F5588
		Private Sub SetSearchPanel()
			Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
			Me.GbBasic.Height = Me.pnlBasicDefaultHeight
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
		End Sub

		' Token: 0x06001AE4 RID: 6884 RVA: 0x000F73DC File Offset: 0x000F55DC
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

		' Token: 0x06001AE5 RID: 6885 RVA: 0x000F744C File Offset: 0x000F564C
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

		' Token: 0x06001AE6 RID: 6886 RVA: 0x000F74BC File Offset: 0x000F56BC
		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x06001AE7 RID: 6887 RVA: 0x000F74F1 File Offset: 0x000F56F1
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Me.SetSearchPanel()
			Designing.SetTheme(Me)
			Me.FillCombo()
			Me.ClearList()
			Me.SetForm()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x06001AE8 RID: 6888 RVA: 0x000F7530 File Offset: 0x000F5730
		Private Sub FillCombo()
			Dim text As String = "SELECT VendorID, VendorName FROM Vendor ORDER BY VendorName"
			Dim data As DataTable = MainModule.GetData(text)
			Me.cmbVendor.ValueMember = "VendorID"
			Me.cmbVendor.DisplayMember = "VendorName"
			Me.cmbVendor.DataSource = data
			Me.cmbVendor.SelectedIndex = -1
		End Sub

		' Token: 0x06001AE9 RID: 6889 RVA: 0x000F7588 File Offset: 0x000F5788
		Private Sub SetForm()
			Dim text As String = Me.sFormType
			Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(text)
			If num <= 1089851736UI Then
				If num <> 570421568UI Then
					If num <> 1029369297UI Then
						If num = 1089851736UI Then
							If Operators.CompareString(text, "PO Cost On-Hold", False) = 0 Then
								MyBase.TabText = "PO Cost On-Hold List"
								Me.cmbStatus.Text = "Cost On-Hold"
								Me.SearchData("")
							End If
						End If
					ElseIf Operators.CompareString(text, "PO Printing", False) = 0 Then
						Me.cmbStatus.Text = "Cost Approved"
						Me.SearchData("")
					End If
				ElseIf Operators.CompareString(text, "PO", False) = 0 Then
					MyBase.TabText = "PO Modification List"
				End If
			ElseIf num <= 1996363025UI Then
				If num <> 1222334419UI Then
					If num = 1996363025UI Then
						If Operators.CompareString(text, "PO On-Hold", False) = 0 Then
							MyBase.TabText = "PO On-Hold List"
							Me.cmbStatus.Text = "On-Hold"
							Me.SearchData("")
						End If
					End If
				ElseIf Operators.CompareString(text, "PO Approval", False) = 0 Then
					Me.cmbStatus.Text = "In Approval"
					Me.SearchData("")
				End If
			ElseIf num <> 2444516107UI Then
				If num = 4000046188UI Then
					If Operators.CompareString(text, "PO Cost Approval", False) = 0 Then
						MyBase.TabText = "PO Cost Approval List"
						Me.cmbStatus.Text = "In Cost Approval"
						Me.SearchData("")
					End If
				End If
			ElseIf Operators.CompareString(text, "PO Amendment", False) <> 0 Then
			End If
		End Sub

		' Token: 0x06001AEA RID: 6890 RVA: 0x000F7784 File Offset: 0x000F5984
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
			Me.lblRows.Text = "0 - Rows"
			Me.cmbSummary.Text = "PO-wise"
			Me.txtCode.Text = ""
			Me.txtCatalogNo.Text = ""
			Me.txtName.Text = ""
			Me.dgvList.DataSource = Nothing
			Dim text As String = Me.sFormType
			If Operators.CompareString(text, "PO", False) <> 0 Then
				If Operators.CompareString(text, "PO Approval", False) <> 0 Then
					If Operators.CompareString(text, "PO Printing", False) <> 0 Then
						If Operators.CompareString(text, "PO Amendment", False) <> 0 Then
						End If
					Else
						Me.cmbStatus.Text = "Approved"
					End If
				Else
					Me.cmbStatus.Text = "In Approval"
				End If
			End If
		End Sub

		' Token: 0x06001AEB RID: 6891 RVA: 0x000F7919 File Offset: 0x000F5B19
		Private Sub btnClearList_Click(sender As Object, e As EventArgs)
			Me.ClearList()
		End Sub

		' Token: 0x06001AEC RID: 6892 RVA: 0x000F7923 File Offset: 0x000F5B23
		Private Sub btnExport_Click(sender As Object, e As EventArgs)
			MainModule.ExportToExcel(Me.dgvList, Me.Text)
		End Sub

		' Token: 0x06001AED RID: 6893 RVA: 0x000F7938 File Offset: 0x000F5B38
		Private Sub cmbSummary_SelectedValueChanged(sender As Object, e As EventArgs)
			Me.SetSummary()
		End Sub

		' Token: 0x06001AEE RID: 6894 RVA: 0x000F7944 File Offset: 0x000F5B44
		Private Sub SetSummary()
			Dim text As String = Me.cmbSummary.Text
			If Operators.CompareString(text, "PO-wise", False) <> 0 Then
				If Operators.CompareString(text, "Item-wise", False) = 0 Then
					Me.pnlItem.Visible = True
					Me.pnlAdvSetHeight = 166
					Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(Me.arrow_btnAdvanceExp_sml.Tag, "ArrowUp", False)
					If flag Then
						Me.GbAdvanced.Height = Me.pnlAdvSetHeight
					End If
				End If
			Else
				Me.pnlItem.Visible = False
				Me.pnlAdvSetHeight = 115
				Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(Me.arrow_btnAdvanceExp_sml.Tag, "ArrowUp", False)
				If flag2 Then
					Me.GbAdvanced.Height = Me.pnlAdvSetHeight
				End If
			End If
			Me.txtCode.Text = ""
			Me.txtCatalogNo.Text = ""
			Me.txtName.Text = ""
		End Sub

		' Token: 0x06001AEF RID: 6895 RVA: 0x000F7A44 File Offset: 0x000F5C44
		Private Sub cmbVendor_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbVendor.SelectedIndex = -1
			If flag Then
				Me.cmbVendor.Text = ""
			End If
		End Sub

		' Token: 0x06001AF0 RID: 6896 RVA: 0x000F7A78 File Offset: 0x000F5C78
		Private Sub btnSearch_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SearchData("")
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06001AF1 RID: 6897 RVA: 0x000F7AEC File Offset: 0x000F5CEC
		Private Sub SearchData(sID As String)
			Dim text As String = ""
			Dim flag As Boolean = Operators.CompareString(Me.cmbSummary.Text, "PO-wise", False) = 0
			Dim text2 As String
			If flag Then
				text2 = " SELECT P.POID AS ID, P.Status, P.ApprovalLevel, P.POType, P.PONo, P.PODt, "
				Dim flag2 As Boolean = (Operators.CompareString(Me.lblDate.Text, "P.R. Date", False) = 0) Or (Operators.CompareString(Strings.Trim(Me.txtPRNo.Text), "", False) <> 0)
				If flag2 Then
					text2 += " PR.PRNo, PR.PRDt, "
				End If
				text2 += " SUM(FinalAmt) Amount, P.ValidUpto, P.DeliveryInDays, P.DeliveryDt,  " & vbCrLf
				text2 += " P.Department, P.InvoiceAddress, P.BillingEmailID, P.ShipAddress, P.ShippingEmailID, P.GSTNo, P.PANNo,  " & vbCrLf
				text2 += " P.VendorID, V.VendorName, P.VendorBillingAddress, P.VendorContactPerson,  " & vbCrLf
				text2 += " P.VendorContactNo, P.VendorEmailID, P.VendorGSTNo, P.VendorPANNo,  " & vbCrLf
				text2 += " P.ModeOfPayment, P.DispatchedThrough, P.PaymentTerms, P.IncoTerms, P.DeliveryTerms, P.Currency,  " & vbCrLf
				text2 += " P.Comments, P.Remarks, P.ActionRemarks,  " & vbCrLf
				text2 += " P.ActionBy ActionByID, Action.UserName AS ActionBy, P.ActionDt, Printed.UserName AS PrintBy, P.PrintDt,  " & vbCrLf
				text2 += " Created.EmailID AS CreatedByEmailID, Modified.EmailID AS ModifiedByEmailID,  " & vbCrLf
				text2 += " P.CreationDt, Created.UserName AS CreatedBy, P.ModificationDt, Modified.UserName AS ModifiedBy " & vbCrLf
				text2 += " FROM PO AS P  " & vbCrLf
				text2 += " INNER JOIN POItems PI ON P.POID = PI.POID " & vbCrLf
				text2 += " INNER JOIN Vendor AS V ON P.VendorID = V.VendorID  " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Action ON P.ActionBy = Action.UserID  " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Printed ON P.PrintBy = Printed.UserID  " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Created ON P.CreatedBy = Created.UserID  " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Modified ON P.ModifiedBy = Modified.UserID " & vbCrLf
			Else
				text2 = " SELECT P.POID AS ID, P.Status, P.ApprovalLevel, P.POType, P.PONo, P.PODt, " & vbCrLf
				Dim flag3 As Boolean = (Operators.CompareString(Me.lblDate.Text, "P.R. Date", False) = 0) Or (Operators.CompareString(Strings.Trim(Me.txtPRNo.Text), "", False) <> 0)
				If flag3 Then
					text2 += " PR.PRNo, PR.PRDt, "
				End If
				text2 += " Pr.ProductCode, Pr.ProductName, PI.Description, PI.UnitPrice, PI.FinalAmt Amount, " & vbCrLf
				text2 += " Pr.CatalogNo, Pr.ProductType, Pr.TertiaryUOM, Pr.TertiaryPackSize, PI.Quantity, Pr.Measurement," & vbCrLf
				text2 += " P.ValidUpto, P.DeliveryInDays, P.DeliveryDt,  " & vbCrLf
				text2 += " P.Department, P.InvoiceAddress, P.BillingEmailID, P.ShipAddress, P.ShippingEmailID, P.GSTNo, P.PANNo,  " & vbCrLf
				text2 += " P.VendorID, V.VendorName, P.VendorBillingAddress, P.VendorContactPerson,  " & vbCrLf
				text2 += " P.VendorContactNo, P.VendorEmailID, P.VendorGSTNo, P.VendorPANNo,  " & vbCrLf
				text2 += " P.ModeOfPayment, P.DispatchedThrough, P.PaymentTerms, P.IncoTerms, P.DeliveryTerms, P.Currency,  " & vbCrLf
				text2 += " P.Comments, P.Remarks, P.ActionRemarks,  " & vbCrLf
				text2 += " P.ActionBy ActionByID, Action.UserName AS ActionBy, P.ActionDt, Printed.UserName AS PrintBy, P.PrintDt,  " & vbCrLf
				text2 += " Created.EmailID AS CreatedByEmailID, Modified.EmailID AS ModifiedByEmailID,  " & vbCrLf
				text2 += " P.CreationDt, Created.UserName AS CreatedBy, P.ModificationDt, Modified.UserName AS ModifiedBy " & vbCrLf
				text2 += " FROM PO AS P  " & vbCrLf
				text2 += " INNER JOIN Vendor AS V ON P.VendorID = V.VendorID  " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Action ON P.ActionBy = Action.UserID  " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Printed ON P.PrintBy = Printed.UserID  " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Created ON P.CreatedBy = Created.UserID  " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Modified ON P.ModifiedBy = Modified.UserID " & vbCrLf
				text2 += " INNER JOIN POItems PI ON P.POID = PI.POID  " & vbCrLf
				text2 += " INNER JOIN Product Pr ON Pr.ProductID = PI.ProductID  " & vbCrLf
			End If
			Dim flag4 As Boolean = (Operators.CompareString(Me.lblDate.Text, "P.R. Date", False) = 0) Or (Operators.CompareString(Strings.Trim(Me.txtPRNo.Text), "", False) <> 0)
			If flag4 Then
				text2 += " INNER JOIN POPR ON P.POID = POPR.POID " & vbCrLf
				text2 += " INNER JOIN PR ON POPR.PRID = PR.PRID " & vbCrLf
			End If
			text2 += " WHERE 1=1" & vbCrLf
			Dim text3 As String = Me.sFormType
			If Operators.CompareString(text3, "PO", False) <> 0 AndAlso Operators.CompareString(text3, "PO On-Hold", False) <> 0 Then
				If Operators.CompareString(text3, "PO Approval", False) <> 0 Then
					If Operators.CompareString(text3, "PO Cost Approval", False) <> 0 Then
						If Operators.CompareString(text3, "PO Printing", False) <> 0 Then
							If Operators.CompareString(text3, "PO Amendment", False) = 0 Then
								text2 += " AND (P.Status IN ('Cost Approved', 'Printed'))" & vbCrLf
							End If
						Else
							text2 += " AND (P.Status IN ('Cost Approved', 'Printed'))" & vbCrLf
						End If
					Else
						Dim flag5 As Boolean = Operators.CompareString(GlobalVariables.gsUserGroup, "Super Admin", False) <> 0
						If flag5 Then
							text2 += " AND ApprovalLevel IN (SELECT ApprovalLevel FROM POApproval POA "
							text2 += "       INNER JOIN POApprovalDtls POAD ON POA.POApprovalID = POAD.POApprovalID "
							text2 = text2 + "       WHERE POAD.ApproverID = '" + GlobalVariables.gsUserID + "')"
						End If
					End If
				Else
					text2 += " AND (P.Status NOT IN ('Amended'))" & vbCrLf
					Dim flag6 As Boolean = Operators.CompareString(GlobalVariables.gsUserGroup, "Super Admin", False) <> 0
					If flag6 Then
						text2 = text2 + " AND P.ActionBy = '" + GlobalVariables.gsUserID + "'" & vbCrLf
					End If
				End If
			End If
			Dim flag7 As Boolean = Operators.CompareString(sID, "", False) <> 0
			If flag7 Then
				text2 = text2 + " AND P.POID = '" + sID + "'" & vbCrLf
				text = text + "POID = '" + sID + "'" & vbCrLf
			End If
			Dim flag8 As Boolean = Operators.CompareString(Strings.Trim(Me.txtNo.Text), "", False) <> 0
			If flag8 Then
				text2 = text2 + " AND (PONo LIKE '%" + Strings.Trim(Me.txtNo.Text) + "%')" & vbCrLf
				text = text + "PONo LIKE " + Strings.Trim(Me.txtNo.Text) + vbCrLf
			End If
			Dim flag9 As Boolean = Operators.CompareString(Strings.Trim(Me.txtPRNo.Text), "", False) <> 0
			If flag9 Then
				text2 = text2 + " AND (PR.PRNo LIKE '%" + Strings.Trim(Me.txtPRNo.Text) + "%')" & vbCrLf
				text = text + "PRNo LIKE " + Strings.Trim(Me.txtPRNo.Text) + vbCrLf
			End If
			Dim flag10 As Boolean = Me.cmbVendor.SelectedIndex > -1
			If flag10 Then
				text2 = text2 + " AND (P.VendorID = '" + Strings.Trim(Me.cmbVendor.SelectedValue.ToString()) + "')" & vbCrLf
				text = text + "VendorID = " + Strings.Trim(Me.cmbVendor.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag11 As Boolean = Me.cmbType.SelectedIndex > 0
			If flag11 Then
				text2 = text2 + " AND (POType = '" + Me.cmbType.Text + "')" & vbCrLf
				text = text + ("POType = " + Me.cmbType.Text) + vbCrLf
			End If
			Dim flag12 As Boolean = Me.cmbStatus.SelectedIndex > 0
			If flag12 Then
				text2 = text2 + " AND (P.Status = '" + Me.cmbStatus.Text + "')" & vbCrLf
				text = text + ("P.Status = " + Me.cmbStatus.Text) + vbCrLf
			End If
			Dim flag13 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCreated.Text), "", False) <> 0
			If flag13 Then
				Dim flag14 As Boolean = Me.lblCreated.SelectedIndex >= 0
				If flag14 Then
					Dim flag15 As Boolean = Me.lblCreated.SelectedIndex = 0
					Dim text4 As String
					If flag15 Then
						text4 = "Created"
					Else
						text4 = "Modified"
					End If
					text2 = String.Concat(New String() { text2, " AND ", text4, ".UserName LIKE '%", Strings.Trim(Me.txtCreated.Text), "%'" })
					text = text + (text4 + "By LIKE " + Strings.Trim(Me.txtCreated.Text)) + vbCrLf
				End If
			End If
			Dim flag16 As Boolean = Me.lblDate.SelectedIndex >= 0
			If flag16 Then
				Dim text5 As String = Me.lblDate.Text
				Dim text6 As String
				If Operators.CompareString(text5, "Creation", False) <> 0 Then
					If Operators.CompareString(text5, "Last Modification", False) <> 0 Then
						If Operators.CompareString(text5, "P.O. Date", False) <> 0 Then
							If Operators.CompareString(text5, "P.R. Date", False) <> 0 Then
								If Operators.CompareString(text5, "Delivery Date", False) <> 0 Then
									text6 = ""
								Else
									text6 = "P.DeliveryDt"
								End If
							Else
								text6 = "PR.PRDt"
							End If
						Else
							text6 = "P.PODt"
						End If
					Else
						text6 = "P.ModificationDt"
					End If
				Else
					text6 = "P.CreationDt"
				End If
				Dim flag17 As Boolean = Operators.CompareString(text6, "", False) <> 0
				If flag17 Then
					Dim flag18 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
					If flag18 Then
						text2 = String.Concat(New String() { text2, " AND ", text6, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" & vbCrLf })
						text = text + String.Concat(New String() { text6, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
					Else
						Dim checked As Boolean = Me.dtpFrom.Checked
						If checked Then
							text2 = String.Concat(New String() { text2, " AND ", text6, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59"), "'" & vbCrLf })
							text = text + String.Concat(New String() { text6, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
						End If
						Dim checked2 As Boolean = Me.dtpTo.Checked
						If checked2 Then
							text2 = String.Concat(New String() { text2, " AND ", text6, " BETWEEN '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" & vbCrLf })
							text = text + String.Concat(New String() { text6, " BETWEEN  ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
						End If
					End If
				End If
			End If
			Dim flag19 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Item-wise", False) = 0
			If flag19 Then
				Dim flag20 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCode.Text), "", False) <> 0
				If flag20 Then
					text2 = text2 + " AND (Pr.ProductCode Like '%" + Strings.Trim(Me.txtCode.Text) + "%') "
					text = text + "ProductCode LIKE " + Strings.Trim(Me.txtCode.Text) + vbCrLf
				End If
				Dim flag21 As Boolean = Operators.CompareString(Strings.Trim(Me.txtName.Text), "", False) <> 0
				If flag21 Then
					text2 = text2 + " AND (Pr.ProductName Like '%" + Strings.Trim(Me.txtName.Text) + "%') "
					text = text + "ProductName LIKE " + Strings.Trim(Me.txtName.Text) + vbCrLf
				End If
				Dim flag22 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCatalogNo.Text), "", False) <> 0
				If flag22 Then
					text2 = text2 + " AND (Pr.CatalogNo Like '%" + Strings.Trim(Me.txtCatalogNo.Text) + "%') "
					text = text + "CatalogNo LIKE " + Strings.Trim(Me.txtCatalogNo.Text) + vbCrLf
				End If
			End If
			Dim flag23 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "PO-wise", False) = 0
			If flag23 Then
				text2 += " GROUP BY P.POID, P.Status, P.ApprovalLevel, P.POType, P.PONo, P.PODt, "
				Dim flag24 As Boolean = (Operators.CompareString(Me.lblDate.Text, "P.R. Date", False) = 0) Or (Operators.CompareString(Strings.Trim(Me.txtPRNo.Text), "", False) <> 0)
				If flag24 Then
					text2 += " PR.PRNo, PR.PRDt, "
				End If
				text2 += " P.ValidUpto, P.DeliveryInDays, P.DeliveryDt,  " & vbCrLf
				text2 += " P.Department, P.InvoiceAddress, P.BillingEmailID, P.ShipAddress, P.ShippingEmailID, P.GSTNo, P.PANNo,  " & vbCrLf
				text2 += " P.VendorID, V.VendorName, P.VendorBillingAddress, P.VendorContactPerson,  " & vbCrLf
				text2 += " P.VendorContactNo, P.VendorEmailID, P.VendorGSTNo, P.VendorPANNo,  " & vbCrLf
				text2 += " P.ModeOfPayment, P.DispatchedThrough, P.PaymentTerms, P.IncoTerms, P.DeliveryTerms, P.Currency,  " & vbCrLf
				text2 += " P.Comments, P.Remarks, P.ActionRemarks, P.ActionBy, Action.UserName, P.ActionDt, Printed.UserName, P.PrintDt,  " & vbCrLf
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
			Me.dgvList.Columns("CreatedByEmailID").Visible = False
			Me.dgvList.Columns("ModifiedByEmailID").Visible = False
			Me.dgvList.Columns("Comments").Visible = False
			Me.dgvList.Columns("Remarks").Visible = False
			Me.dgvList.Columns("ActionRemarks").Visible = False
			Me.dgvList.Columns("ActionByID").Visible = False
			Me.dgvList.Columns("ApprovalLevel").HeaderText = "Approval Level"
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
			Me.dgvList.Columns("Status").HeaderText = "Status"
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
			Me.dgvList.Columns("Status").Width = 132
			Me.dgvList.Columns("CreationDt").Width = 170
			Me.dgvList.Columns("CreatedBy").Width = 140
			Me.dgvList.Columns("ModificationDt").Width = 170
			Me.dgvList.Columns("ModifiedBy").Width = 140
			Dim flag25 As Boolean = data.Columns.Contains("PRNo")
			If flag25 Then
				Me.dgvList.Columns("PRNo").HeaderText = "PR No."
				Me.dgvList.Columns("PRDt").HeaderText = "PR Date"
				Me.dgvList.Columns("PRNo").Width = 130
				Me.dgvList.Columns("PRDt").Width = 120
				Me.dgvList.Columns("PRDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			End If
			Dim flag26 As Boolean = data.Columns.Contains("ProductCode")
			If flag26 Then
				Me.dgvList.Columns("ProductCode").HeaderText = "Product Code"
				Me.dgvList.Columns("CatalogNo").HeaderText = "Catalog No."
				Me.dgvList.Columns("ProductName").HeaderText = "Product Name"
				Me.dgvList.Columns("ProductType").HeaderText = "Product Type"
				Me.dgvList.Columns("TertiaryUOM").HeaderText = "Tertiary UOM"
				Me.dgvList.Columns("TertiaryPackSize").HeaderText = "Tertiary PackSize"
				Me.dgvList.Columns("Quantity").HeaderText = "Tertiary Qty."
				Me.dgvList.Columns("ProductCode").Width = 180
				Me.dgvList.Columns("CatalogNo").Width = 180
				Me.dgvList.Columns("ProductName").Width = 300
				Me.dgvList.Columns("Description").Width = 300
				Me.dgvList.Columns("ProductType").Width = 110
				Me.dgvList.Columns("TertiaryUOM").Width = 90
				Me.dgvList.Columns("TertiaryPackSize").Width = 72
				Me.dgvList.Columns("Quantity").Width = 60
				Me.dgvList.Columns("TertiaryPackSize").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("Quantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x06001AF2 RID: 6898 RVA: 0x000F9588 File Offset: 0x000F7788
		Private Sub dgvList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = (e.RowIndex > -1) And (e.ColumnIndex > -1)
			If flag Then
				Dim dataTable As DataTable = CType(Me.dgvList.DataSource, DataTable)
				dataTable.TableName = "PO"
				Dim dataRow As DataRow = dataTable.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("ID = '", Me.dgvList.Rows(e.RowIndex).Cells("ID").Value), "'")))(0)
				Dim text As String = Me.sFormType
				If Operators.CompareString(text, "PO", False) <> 0 AndAlso Operators.CompareString(text, "PO On-Hold", False) <> 0 Then
					If Operators.CompareString(text, "PO Approval", False) = 0 OrElse Operators.CompareString(text, "PO Cost Approval", False) = 0 OrElse Operators.CompareString(text, "PO Printing", False) = 0 OrElse Operators.CompareString(text, "PO Amendment", False) = 0 Then
						Dim pogeneration As POGeneration01 = New POGeneration01(Me.sFormType, dataRow)
						pogeneration.Show(MyBase.DockPanel)
						Me.ClearList()
					End If
				Else
					Dim pogeneration2 As POGeneration01 = New POGeneration01("PO Modify", dataRow)
					pogeneration2.Show(MyBase.DockPanel)
					Me.ClearList()
				End If
			End If
		End Sub

		' Token: 0x04000BA2 RID: 2978
		Private sFormType As String

		' Token: 0x04000BA3 RID: 2979
		Private pnlBasicDefaultHeight As Integer

		' Token: 0x04000BA4 RID: 2980
		Private pnlBasicSetHeight As Integer

		' Token: 0x04000BA5 RID: 2981
		Private pnlAdvDefaultHeight As Integer

		' Token: 0x04000BA6 RID: 2982
		Private pnlAdvSetHeight As Integer
	End Class
End Namespace
