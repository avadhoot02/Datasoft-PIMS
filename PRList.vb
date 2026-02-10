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
	' Token: 0x0200005A RID: 90
	<DesignerGenerated()>
	Public Partial Class PRList
		Inherits DockContent

		' Token: 0x1700076B RID: 1899
		' (get) Token: 0x06001378 RID: 4984 RVA: 0x000B475C File Offset: 0x000B295C
		' (set) Token: 0x06001379 RID: 4985 RVA: 0x000B4766 File Offset: 0x000B2966
		Friend Overridable Property GbBasic As GroupBox

		' Token: 0x1700076C RID: 1900
		' (get) Token: 0x0600137A RID: 4986 RVA: 0x000B476F File Offset: 0x000B296F
		' (set) Token: 0x0600137B RID: 4987 RVA: 0x000B4779 File Offset: 0x000B2979
		Friend Overridable Property cmbPlant As ComboBox

		' Token: 0x1700076D RID: 1901
		' (get) Token: 0x0600137C RID: 4988 RVA: 0x000B4782 File Offset: 0x000B2982
		' (set) Token: 0x0600137D RID: 4989 RVA: 0x000B478C File Offset: 0x000B298C
		Friend Overridable Property Label1 As Label

		' Token: 0x1700076E RID: 1902
		' (get) Token: 0x0600137E RID: 4990 RVA: 0x000B4795 File Offset: 0x000B2995
		' (set) Token: 0x0600137F RID: 4991 RVA: 0x000B479F File Offset: 0x000B299F
		Friend Overridable Property txtNo As TextBox

		' Token: 0x1700076F RID: 1903
		' (get) Token: 0x06001380 RID: 4992 RVA: 0x000B47A8 File Offset: 0x000B29A8
		' (set) Token: 0x06001381 RID: 4993 RVA: 0x000B47B2 File Offset: 0x000B29B2
		Friend Overridable Property dtpFrom As DateTimePicker

		' Token: 0x17000770 RID: 1904
		' (get) Token: 0x06001382 RID: 4994 RVA: 0x000B47BB File Offset: 0x000B29BB
		' (set) Token: 0x06001383 RID: 4995 RVA: 0x000B47C5 File Offset: 0x000B29C5
		Friend Overridable Property dtpTo As DateTimePicker

		' Token: 0x17000771 RID: 1905
		' (get) Token: 0x06001384 RID: 4996 RVA: 0x000B47CE File Offset: 0x000B29CE
		' (set) Token: 0x06001385 RID: 4997 RVA: 0x000B47D8 File Offset: 0x000B29D8
		Friend Overridable Property Label16 As Label

		' Token: 0x17000772 RID: 1906
		' (get) Token: 0x06001386 RID: 4998 RVA: 0x000B47E1 File Offset: 0x000B29E1
		' (set) Token: 0x06001387 RID: 4999 RVA: 0x000B47EB File Offset: 0x000B29EB
		Friend Overridable Property lblDate As ComboBox

		' Token: 0x17000773 RID: 1907
		' (get) Token: 0x06001388 RID: 5000 RVA: 0x000B47F4 File Offset: 0x000B29F4
		' (set) Token: 0x06001389 RID: 5001 RVA: 0x000B4800 File Offset: 0x000B2A00
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

		' Token: 0x17000774 RID: 1908
		' (get) Token: 0x0600138A RID: 5002 RVA: 0x000B4843 File Offset: 0x000B2A43
		' (set) Token: 0x0600138B RID: 5003 RVA: 0x000B484D File Offset: 0x000B2A4D
		Friend Overridable Property cmbStatus As ComboBox

		' Token: 0x17000775 RID: 1909
		' (get) Token: 0x0600138C RID: 5004 RVA: 0x000B4856 File Offset: 0x000B2A56
		' (set) Token: 0x0600138D RID: 5005 RVA: 0x000B4860 File Offset: 0x000B2A60
		Friend Overridable Property Label11 As Label

		' Token: 0x17000776 RID: 1910
		' (get) Token: 0x0600138E RID: 5006 RVA: 0x000B4869 File Offset: 0x000B2A69
		' (set) Token: 0x0600138F RID: 5007 RVA: 0x000B4873 File Offset: 0x000B2A73
		Friend Overridable Property GbAdvanced As GroupBox

		' Token: 0x17000777 RID: 1911
		' (get) Token: 0x06001390 RID: 5008 RVA: 0x000B487C File Offset: 0x000B2A7C
		' (set) Token: 0x06001391 RID: 5009 RVA: 0x000B4886 File Offset: 0x000B2A86
		Friend Overridable Property pnlItem As Panel

		' Token: 0x17000778 RID: 1912
		' (get) Token: 0x06001392 RID: 5010 RVA: 0x000B488F File Offset: 0x000B2A8F
		' (set) Token: 0x06001393 RID: 5011 RVA: 0x000B4899 File Offset: 0x000B2A99
		Friend Overridable Property txtName As TextBox

		' Token: 0x17000779 RID: 1913
		' (get) Token: 0x06001394 RID: 5012 RVA: 0x000B48A2 File Offset: 0x000B2AA2
		' (set) Token: 0x06001395 RID: 5013 RVA: 0x000B48AC File Offset: 0x000B2AAC
		Friend Overridable Property txtCatalogNo As TextBox

		' Token: 0x1700077A RID: 1914
		' (get) Token: 0x06001396 RID: 5014 RVA: 0x000B48B5 File Offset: 0x000B2AB5
		' (set) Token: 0x06001397 RID: 5015 RVA: 0x000B48BF File Offset: 0x000B2ABF
		Friend Overridable Property Label14 As Label

		' Token: 0x1700077B RID: 1915
		' (get) Token: 0x06001398 RID: 5016 RVA: 0x000B48C8 File Offset: 0x000B2AC8
		' (set) Token: 0x06001399 RID: 5017 RVA: 0x000B48D2 File Offset: 0x000B2AD2
		Friend Overridable Property Label5 As Label

		' Token: 0x1700077C RID: 1916
		' (get) Token: 0x0600139A RID: 5018 RVA: 0x000B48DB File Offset: 0x000B2ADB
		' (set) Token: 0x0600139B RID: 5019 RVA: 0x000B48E5 File Offset: 0x000B2AE5
		Friend Overridable Property txtCode As TextBox

		' Token: 0x1700077D RID: 1917
		' (get) Token: 0x0600139C RID: 5020 RVA: 0x000B48EE File Offset: 0x000B2AEE
		' (set) Token: 0x0600139D RID: 5021 RVA: 0x000B48F8 File Offset: 0x000B2AF8
		Friend Overridable Property Label6 As Label

		' Token: 0x1700077E RID: 1918
		' (get) Token: 0x0600139E RID: 5022 RVA: 0x000B4901 File Offset: 0x000B2B01
		' (set) Token: 0x0600139F RID: 5023 RVA: 0x000B490C File Offset: 0x000B2B0C
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

		' Token: 0x1700077F RID: 1919
		' (get) Token: 0x060013A0 RID: 5024 RVA: 0x000B494F File Offset: 0x000B2B4F
		' (set) Token: 0x060013A1 RID: 5025 RVA: 0x000B4959 File Offset: 0x000B2B59
		Friend Overridable Property Label13 As Label

		' Token: 0x17000780 RID: 1920
		' (get) Token: 0x060013A2 RID: 5026 RVA: 0x000B4962 File Offset: 0x000B2B62
		' (set) Token: 0x060013A3 RID: 5027 RVA: 0x000B496C File Offset: 0x000B2B6C
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

		' Token: 0x17000781 RID: 1921
		' (get) Token: 0x060013A4 RID: 5028 RVA: 0x000B49AF File Offset: 0x000B2BAF
		' (set) Token: 0x060013A5 RID: 5029 RVA: 0x000B49B9 File Offset: 0x000B2BB9
		Friend Overridable Property Label9 As Label

		' Token: 0x17000782 RID: 1922
		' (get) Token: 0x060013A6 RID: 5030 RVA: 0x000B49C2 File Offset: 0x000B2BC2
		' (set) Token: 0x060013A7 RID: 5031 RVA: 0x000B49CC File Offset: 0x000B2BCC
		Friend Overridable Property txtCreated As TextBox

		' Token: 0x17000783 RID: 1923
		' (get) Token: 0x060013A8 RID: 5032 RVA: 0x000B49D5 File Offset: 0x000B2BD5
		' (set) Token: 0x060013A9 RID: 5033 RVA: 0x000B49DF File Offset: 0x000B2BDF
		Friend Overridable Property lblCreated As ComboBox

		' Token: 0x17000784 RID: 1924
		' (get) Token: 0x060013AA RID: 5034 RVA: 0x000B49E8 File Offset: 0x000B2BE8
		' (set) Token: 0x060013AB RID: 5035 RVA: 0x000B49F4 File Offset: 0x000B2BF4
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

		' Token: 0x17000785 RID: 1925
		' (get) Token: 0x060013AC RID: 5036 RVA: 0x000B4A37 File Offset: 0x000B2C37
		' (set) Token: 0x060013AD RID: 5037 RVA: 0x000B4A41 File Offset: 0x000B2C41
		Friend Overridable Property grpListButton As GroupBox

		' Token: 0x17000786 RID: 1926
		' (get) Token: 0x060013AE RID: 5038 RVA: 0x000B4A4A File Offset: 0x000B2C4A
		' (set) Token: 0x060013AF RID: 5039 RVA: 0x000B4A54 File Offset: 0x000B2C54
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x17000787 RID: 1927
		' (get) Token: 0x060013B0 RID: 5040 RVA: 0x000B4A5D File Offset: 0x000B2C5D
		' (set) Token: 0x060013B1 RID: 5041 RVA: 0x000B4A68 File Offset: 0x000B2C68
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

		' Token: 0x17000788 RID: 1928
		' (get) Token: 0x060013B2 RID: 5042 RVA: 0x000B4AAB File Offset: 0x000B2CAB
		' (set) Token: 0x060013B3 RID: 5043 RVA: 0x000B4AB8 File Offset: 0x000B2CB8
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

		' Token: 0x17000789 RID: 1929
		' (get) Token: 0x060013B4 RID: 5044 RVA: 0x000B4AFB File Offset: 0x000B2CFB
		' (set) Token: 0x060013B5 RID: 5045 RVA: 0x000B4B08 File Offset: 0x000B2D08
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

		' Token: 0x1700078A RID: 1930
		' (get) Token: 0x060013B6 RID: 5046 RVA: 0x000B4B4B File Offset: 0x000B2D4B
		' (set) Token: 0x060013B7 RID: 5047 RVA: 0x000B4B55 File Offset: 0x000B2D55
		Friend Overridable Property lblRows As Label

		' Token: 0x1700078B RID: 1931
		' (get) Token: 0x060013B8 RID: 5048 RVA: 0x000B4B5E File Offset: 0x000B2D5E
		' (set) Token: 0x060013B9 RID: 5049 RVA: 0x000B4B68 File Offset: 0x000B2D68
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

		' Token: 0x060013BA RID: 5050 RVA: 0x000B4BAC File Offset: 0x000B2DAC
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

		' Token: 0x060013BB RID: 5051 RVA: 0x000B4C40 File Offset: 0x000B2E40
		Private Sub SetSearchPanel()
			Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
			Me.GbBasic.Height = Me.pnlBasicDefaultHeight
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
		End Sub

		' Token: 0x060013BC RID: 5052 RVA: 0x000B4C94 File Offset: 0x000B2E94
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

		' Token: 0x060013BD RID: 5053 RVA: 0x000B4D04 File Offset: 0x000B2F04
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

		' Token: 0x060013BE RID: 5054 RVA: 0x000B4D74 File Offset: 0x000B2F74
		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x060013BF RID: 5055 RVA: 0x000B4DA9 File Offset: 0x000B2FA9
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Me.SetSearchPanel()
			Designing.SetTheme(Me)
			Me.FillCombo()
			Me.ClearList()
			Me.SetForm()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x060013C0 RID: 5056 RVA: 0x000B4DE8 File Offset: 0x000B2FE8
		Private Sub FillCombo()
			Dim text As String = "SELECT VendorID, VendorName FROM Vendor ORDER BY VendorName"
			Dim data As DataTable = MainModule.GetData(text)
			Me.cmbVendor.ValueMember = "VendorID"
			Me.cmbVendor.DisplayMember = "VendorName"
			Me.cmbVendor.DataSource = data
			Me.cmbVendor.SelectedIndex = -1
		End Sub

		' Token: 0x060013C1 RID: 5057 RVA: 0x000B4E40 File Offset: 0x000B3040
		Private Sub SetForm()
			Dim text As String = Me.sFormType
			If Operators.CompareString(text, "PR", False) <> 0 Then
				If Operators.CompareString(text, "PR On-Hold", False) <> 0 Then
					If Operators.CompareString(text, "PR Approval", False) <> 0 Then
						If Operators.CompareString(text, "PR Cost On-Hold", False) <> 0 Then
							If Operators.CompareString(text, "PR Cost Approval", False) = 0 Then
								MyBase.TabText = "PR Cost Approval List"
								Me.cmbStatus.Text = "In Cost Approval"
								Me.SearchData("")
							End If
						Else
							MyBase.TabText = "PR Cost On-Hold List"
							Me.cmbStatus.Text = "Cost On-Hold"
							Me.SearchData("")
						End If
					Else
						MyBase.TabText = "PR Approval List"
						Me.cmbStatus.Text = "In Approval"
						Me.SearchData("")
					End If
				Else
					MyBase.TabText = "PR On-Hold List"
					Me.cmbStatus.Text = "On-Hold"
					Me.SearchData("")
				End If
			Else
				MyBase.TabText = "PR Modification List"
			End If
		End Sub

		' Token: 0x060013C2 RID: 5058 RVA: 0x000B4F70 File Offset: 0x000B3170
		Private Sub ClearList()
			Me.lblDate.SelectedIndex = 0
			Me.lblCreated.SelectedIndex = 0
			Me.txtNo.Text = ""
			Me.txtCreated.Text = ""
			Me.cmbVendor.SelectedIndex = -1
			Me.cmbStatus.SelectedIndex = 0
			Me.dtpFrom.Value = DateAndTime.Now
			Me.dtpTo.Value = DateAndTime.Now
			Me.dtpFrom.Checked = False
			Me.dtpTo.Checked = False
			Me.lblRows.Text = "0 - Rows"
			Me.cmbSummary.Text = "PR-wise"
			Me.txtCode.Text = ""
			Me.txtCatalogNo.Text = ""
			Me.txtName.Text = ""
			Me.dgvList.DataSource = Nothing
			Dim text As String = Me.sFormType
			If Operators.CompareString(text, "PR", False) <> 0 Then
				If Operators.CompareString(text, "PR Approval", False) = 0 Then
					Me.cmbStatus.Text = "In Approval"
				End If
			End If
		End Sub

		' Token: 0x060013C3 RID: 5059 RVA: 0x000B50B0 File Offset: 0x000B32B0
		Private Sub btnClearList_Click(sender As Object, e As EventArgs)
			Me.ClearList()
		End Sub

		' Token: 0x060013C4 RID: 5060 RVA: 0x000B50BA File Offset: 0x000B32BA
		Private Sub btnExport_Click(sender As Object, e As EventArgs)
			MainModule.ExportToExcel(Me.dgvList, Me.Text)
		End Sub

		' Token: 0x060013C5 RID: 5061 RVA: 0x000B50CF File Offset: 0x000B32CF
		Private Sub cmbSummary_SelectedValueChanged(sender As Object, e As EventArgs)
			Me.SetSummary()
		End Sub

		' Token: 0x060013C6 RID: 5062 RVA: 0x000B50DC File Offset: 0x000B32DC
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
				Me.pnlItem.Visible = False
				Me.pnlAdvSetHeight = 86
				Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(Me.arrow_btnAdvanceExp_sml.Tag, "ArrowUp", False)
				If flag2 Then
					Me.GbAdvanced.Height = Me.pnlAdvSetHeight
				End If
			End If
			Me.txtCode.Text = ""
			Me.txtCatalogNo.Text = ""
			Me.txtName.Text = ""
		End Sub

		' Token: 0x060013C7 RID: 5063 RVA: 0x000B51DC File Offset: 0x000B33DC
		Private Sub cmbVendor_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbVendor.SelectedIndex = -1
			If flag Then
				Me.cmbVendor.Text = ""
			End If
		End Sub

		' Token: 0x060013C8 RID: 5064 RVA: 0x000B5210 File Offset: 0x000B3410
		Private Sub btnSearch_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SearchData("")
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x060013C9 RID: 5065 RVA: 0x000B5284 File Offset: 0x000B3484
		Private Sub SearchData(sID As String)
			Dim text As String = ""
			Dim flag As Boolean = Operators.CompareString(Me.cmbSummary.Text, "PR-wise", False) = 0
			Dim text2 As String
			If flag Then
				text2 = " SELECT P.PRID AS ID, P.Status, P.ApprovalLevel, P.PRNo, P.PRDt, P.RequestedBy RequestedByID,  " & vbCrLf
				text2 += " Req.UserName AS RequestedBy, Req.EmailID ReqEmailID, P.Department, P.RequiredByDt,  " & vbCrLf
				text2 += " P.VendorID, V.VendorName, P.Remarks, P.ActionRemarks,  " & vbCrLf
				text2 += " P.ActionBy ActionByID, Action.UserName AS ActionBy, P.ActionDt,  " & vbCrLf
				text2 += " Can.UserName CancelledBy, P.CancelledDt, P.CancelledRemarks, " & vbCrLf
				text2 += " Created.EmailID AS CreatedByEmailID, Modified.EmailID AS ModifiedByEmailID,  " & vbCrLf
				text2 += " P.CreationDt, Created.UserName AS CreatedBy, P.ModificationDt, Modified.UserName AS ModifiedBy " & vbCrLf
				text2 += " FROM PR AS P  " & vbCrLf
				text2 += " LEFT OUTER JOIN Vendor AS V ON P.VendorID = V.VendorID  " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Action ON P.ActionBy = Action.UserID  " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Req ON P.RequestedBy = Req.UserID  " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Can ON P.CancelledBy = Can.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Created ON P.CreatedBy = Created.UserID  " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Modified ON P.ModifiedBy = Modified.UserID " & vbCrLf
			Else
				text2 = " SELECT P.PRID AS ID, P.Status, P.ApprovalLevel, P.PRNo, P.PRDt, P.RequestedBy RequestedByID,  " & vbCrLf
				text2 += " Req.UserName AS RequestedBy, Req.EmailID ReqEmailID, P.Department, P.RequiredByDt, PI.ProductName,  " & vbCrLf
				text2 += " P.VendorID, V.VendorName, P.Remarks, P.ActionRemarks,  " & vbCrLf
				text2 += " PI.ProductType, PI.ProductCode, Pr.CatalogNo, PI.Description, Pr.TertiaryUOM, PI.TertiaryPackSize, PI.Quantity,  " & vbCrLf
				text2 += " P.ActionBy ActionByID, Action.UserName AS ActionBy, P.ActionDt,  " & vbCrLf
				text2 += " Can.UserName CancelledBy, P.CancelledDt, P.CancelledRemarks, " & vbCrLf
				text2 += " Created.EmailID AS CreatedByEmailID, Modified.EmailID AS ModifiedByEmailID,  " & vbCrLf
				text2 += " P.CreationDt, Created.UserName AS CreatedBy, P.ModificationDt, Modified.UserName AS ModifiedBy " & vbCrLf
				text2 += " FROM PR AS P  " & vbCrLf
				text2 += " LEFT OUTER JOIN Vendor AS V ON P.VendorID = V.VendorID  " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Action ON P.ActionBy = Action.UserID  " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Req ON P.RequestedBy = Req.UserID  " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Can ON P.CancelledBy = Can.UserID " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Created ON P.CreatedBy = Created.UserID  " & vbCrLf
				text2 += " LEFT OUTER JOIN [User] AS Modified ON P.ModifiedBy = Modified.UserID " & vbCrLf
				text2 += " INNER JOIN PRItems PI ON P.PRID = PI.PRID  " & vbCrLf
				text2 += " LEFT OUTER JOIN Product Pr ON Pr.ProductID = PI.ProductID  " & vbCrLf
			End If
			text2 += " WHERE 1=1" & vbCrLf
			Dim flag2 As Boolean = Strings.InStr(GlobalVariables.gsUserGroup.ToLower(), "admin", CompareMethod.Binary) = 0
			If flag2 Then
				text2 = text2 + " AND P.Department = '" + GlobalVariables.gsDepartment + "' " & vbCrLf
			End If
			Dim text3 As String = Me.sFormType
			If Operators.CompareString(text3, "PR", False) <> 0 AndAlso Operators.CompareString(text3, "PR On-Hold", False) <> 0 Then
				If Operators.CompareString(text3, "PR Approval", False) <> 0 Then
					If Operators.CompareString(text3, "PR Cost Approval", False) = 0 Then
						Dim flag3 As Boolean = Operators.CompareString(GlobalVariables.gsUserGroup, "Super Admin", False) <> 0
						If flag3 Then
							text2 += " AND ApprovalLevel IN (SELECT ApprovalLevel FROM PRApproval PRA "
							text2 += "       INNER JOIN PRApprovalDtls PRAD ON PRA.PRApprovalID = PRAD.PRApprovalID "
							text2 = text2 + "       WHERE PRAD.ApproverID = '" + GlobalVariables.gsUserID + "')"
						End If
					End If
				Else
					Dim flag4 As Boolean = Operators.CompareString(GlobalVariables.gsUserGroup, "Super Admin", False) <> 0
					If flag4 Then
						text2 = text2 + " AND P.ActionBy = '" + GlobalVariables.gsUserID + "'" & vbCrLf
					End If
				End If
			End If
			Dim flag5 As Boolean = Operators.CompareString(sID, "", False) <> 0
			If flag5 Then
				text2 = text2 + " And P.PRID = '" + sID + "'" & vbCrLf
				text = text + "PRID = '" + sID + "'" & vbCrLf
			End If
			Dim flag6 As Boolean = Operators.CompareString(Strings.Trim(Me.txtNo.Text), "", False) <> 0
			If flag6 Then
				text2 = text2 + " AND (PRNo LIKE '%" + Strings.Trim(Me.txtNo.Text) + "%')" & vbCrLf
				text = text + "PRNo LIKE " + Strings.Trim(Me.txtNo.Text) + vbCrLf
			End If
			Dim flag7 As Boolean = Me.cmbVendor.SelectedIndex > -1
			If flag7 Then
				text2 = text2 + " AND (P.VendorID = '" + Strings.Trim(Me.cmbVendor.SelectedValue.ToString()) + "')" & vbCrLf
				text = text + "VendorID = " + Strings.Trim(Me.cmbVendor.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag8 As Boolean = Me.cmbStatus.SelectedIndex > 0
			If flag8 Then
				text2 = text2 + " AND (P.Status = '" + Me.cmbStatus.Text + "')" & vbCrLf
				text = text + ("P.Status = " + Me.cmbStatus.Text) + vbCrLf
			End If
			Dim flag9 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCreated.Text), "", False) <> 0
			If flag9 Then
				Dim flag10 As Boolean = Me.lblCreated.SelectedIndex >= 0
				If flag10 Then
					Dim text4 As String = Me.lblCreated.Text
					Dim text5 As String
					If Operators.CompareString(text4, "Requested By", False) <> 0 Then
						If Operators.CompareString(text4, "Created By", False) <> 0 Then
							If Operators.CompareString(text4, "Last Modified By", False) = 0 Then
								text5 = "Modified"
							End If
						Else
							text5 = "Created"
						End If
					Else
						text5 = "Req"
					End If
					text2 = String.Concat(New String() { text2, " AND ", text5, ".UserName LIKE '%", Strings.Trim(Me.txtCreated.Text), "%'" })
					text = text + (text5 + "By LIKE " + Strings.Trim(Me.txtCreated.Text)) + vbCrLf
				End If
			End If
			Dim flag11 As Boolean = Me.lblDate.SelectedIndex >= 0
			If flag11 Then
				Dim text6 As String = Me.lblDate.Text
				Dim text7 As String
				If Operators.CompareString(text6, "Creation", False) <> 0 Then
					If Operators.CompareString(text6, "Last Modification", False) <> 0 Then
						If Operators.CompareString(text6, "P.R. Date", False) <> 0 Then
							If Operators.CompareString(text6, "Required By Date", False) <> 0 Then
								text7 = ""
							Else
								text7 = "P.RequiredByDt"
							End If
						Else
							text7 = "P.PRDt"
						End If
					Else
						text7 = "P.ModificationDt"
					End If
				Else
					text7 = "P.CreationDt"
				End If
				Dim flag12 As Boolean = Operators.CompareString(text7, "", False) <> 0
				If flag12 Then
					Dim flag13 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
					If flag13 Then
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
			Dim flag14 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Item-wise", False) = 0
			If flag14 Then
				Dim flag15 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCode.Text), "", False) <> 0
				If flag15 Then
					text2 = text2 + " AND (Pr.ProductCode Like '%" + Strings.Trim(Me.txtCode.Text) + "%') "
					text = text + "ProductCode LIKE " + Strings.Trim(Me.txtCode.Text) + vbCrLf
				End If
				Dim flag16 As Boolean = Operators.CompareString(Strings.Trim(Me.txtName.Text), "", False) <> 0
				If flag16 Then
					text2 = text2 + " AND (Pr.ProductName Like '%" + Strings.Trim(Me.txtName.Text) + "%') "
					text = text + "ProductName LIKE " + Strings.Trim(Me.txtName.Text) + vbCrLf
				End If
				Dim flag17 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCatalogNo.Text), "", False) <> 0
				If flag17 Then
					text2 = text2 + " AND (Pr.CatalogNo Like '%" + Strings.Trim(Me.txtCatalogNo.Text) + "%') "
					text = text + "CatalogNo LIKE " + Strings.Trim(Me.txtCatalogNo.Text) + vbCrLf
				End If
			End If
			text2 += " ORDER BY PRDt" & vbCrLf
			Dim data As DataTable = MainModule.GetData(text2)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = Nothing
			Me.dgvList.DataSource = data
			Me.dgvList.Columns("ID").Visible = False
			Me.dgvList.Columns("VendorID").Visible = False
			Me.dgvList.Columns("RequestedByID").Visible = False
			Me.dgvList.Columns("ReqEmailID").Visible = False
			Me.dgvList.Columns("CreatedByEmailID").Visible = False
			Me.dgvList.Columns("ModifiedByEmailID").Visible = False
			Me.dgvList.Columns("Remarks").Visible = False
			Me.dgvList.Columns("ActionByID").Visible = False
			Me.dgvList.Columns("ActionRemarks").Visible = False
			Me.dgvList.Columns("CancelledRemarks").Visible = False
			Me.dgvList.Columns("ApprovalLevel").HeaderText = "Approval Level"
			Me.dgvList.Columns("PRNo").HeaderText = "PR No."
			Me.dgvList.Columns("PRDt").HeaderText = "PR Date"
			Me.dgvList.Columns("RequestedBy").HeaderText = "Requested By"
			Me.dgvList.Columns("RequiredByDt").HeaderText = "Required By Date"
			Me.dgvList.Columns("VendorName").HeaderText = "Vendor Name"
			Me.dgvList.Columns("ActionBy").HeaderText = "Action By"
			Me.dgvList.Columns("ActionDt").HeaderText = "Action Date"
			Me.dgvList.Columns("CancelledBy").HeaderText = "Cancelled By"
			Me.dgvList.Columns("CancelledDt").HeaderText = "Cancelled Date"
			Me.dgvList.Columns("Status").HeaderText = "Status"
			Me.dgvList.Columns("CreationDt").HeaderText = "Creation Date"
			Me.dgvList.Columns("CreatedBy").HeaderText = "Created By"
			Me.dgvList.Columns("ModificationDt").HeaderText = "Modification Date"
			Me.dgvList.Columns("ModifiedBy").HeaderText = "Modified By"
			Me.dgvList.Columns("PRDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("RequiredByDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("ActionDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("CancelledDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("CreationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh: mm:ss tt"
			Me.dgvList.Columns("ModificationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			Me.dgvList.Columns("PRNo").Width = 130
			Me.dgvList.Columns("PRDt").Width = 120
			Me.dgvList.Columns("RequestedBy").Width = 130
			Me.dgvList.Columns("RequiredByDt").Width = 135
			Me.dgvList.Columns("VendorName").Width = 300
			Me.dgvList.Columns("ActionBy").Width = 130
			Me.dgvList.Columns("ActionDt").Width = 120
			Me.dgvList.Columns("CancelledBy").Width = 130
			Me.dgvList.Columns("CancelledDt").Width = 120
			Me.dgvList.Columns("Status").Width = 132
			Me.dgvList.Columns("CreationDt").Width = 170
			Me.dgvList.Columns("CreatedBy").Width = 140
			Me.dgvList.Columns("ModificationDt").Width = 170
			Me.dgvList.Columns("ModifiedBy").Width = 140
			Dim flag18 As Boolean = data.Columns.Contains("ProductCode")
			If flag18 Then
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

		' Token: 0x060013CA RID: 5066 RVA: 0x000B64C8 File Offset: 0x000B46C8
		Private Sub dgvList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = (e.RowIndex > -1) And (e.ColumnIndex > -1)
			If flag Then
				Dim dataTable As DataTable = CType(Me.dgvList.DataSource, DataTable)
				dataTable.TableName = "PR"
				Dim dataRow As DataRow = dataTable.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("ID = '", Me.dgvList.Rows(e.RowIndex).Cells("ID").Value), "'")))(0)
				Dim text As String = Me.sFormType
				If Operators.CompareString(text, "PR", False) <> 0 Then
					If Operators.CompareString(text, "PR On-Hold", False) <> 0 Then
						If Operators.CompareString(text, "PR Approval", False) <> 0 Then
							If Operators.CompareString(text, "PR Cost Approval", False) = 0 Then
								Dim prgeneration As PRGeneration = New PRGeneration(Me.sFormType, dataRow)
								prgeneration.Show(MyBase.DockPanel)
								Me.SearchData("")
							End If
						Else
							Dim prgeneration2 As PRGeneration = New PRGeneration(Me.sFormType, dataRow)
							prgeneration2.Show(MyBase.DockPanel)
							Me.SearchData("")
						End If
					Else
						Dim prgeneration3 As PRGeneration = New PRGeneration("PR Modify", dataRow)
						prgeneration3.Show(MyBase.DockPanel)
						Me.SearchData("")
					End If
				Else
					Dim prgeneration4 As PRGeneration = New PRGeneration("PR Modify", dataRow)
					prgeneration4.Show(MyBase.DockPanel)
					Me.ClearList()
				End If
			End If
		End Sub

		' Token: 0x04000863 RID: 2147
		Private sFormType As String

		' Token: 0x04000864 RID: 2148
		Private pnlBasicDefaultHeight As Integer

		' Token: 0x04000865 RID: 2149
		Private pnlBasicSetHeight As Integer

		' Token: 0x04000866 RID: 2150
		Private pnlAdvDefaultHeight As Integer

		' Token: 0x04000867 RID: 2151
		Private pnlAdvSetHeight As Integer
	End Class
End Namespace
