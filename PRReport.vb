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
	' Token: 0x02000016 RID: 22
	<DesignerGenerated()>
	Public Partial Class PRReport
		Inherits DockContent

		' Token: 0x17000135 RID: 309
		' (get) Token: 0x0600034A RID: 842 RVA: 0x000209BC File Offset: 0x0001EBBC
		' (set) Token: 0x0600034B RID: 843 RVA: 0x000209C6 File Offset: 0x0001EBC6
		Friend Overridable Property GbBasic As GroupBox

		' Token: 0x17000136 RID: 310
		' (get) Token: 0x0600034C RID: 844 RVA: 0x000209CF File Offset: 0x0001EBCF
		' (set) Token: 0x0600034D RID: 845 RVA: 0x000209D9 File Offset: 0x0001EBD9
		Friend Overridable Property cmbPlant As ComboBox

		' Token: 0x17000137 RID: 311
		' (get) Token: 0x0600034E RID: 846 RVA: 0x000209E2 File Offset: 0x0001EBE2
		' (set) Token: 0x0600034F RID: 847 RVA: 0x000209EC File Offset: 0x0001EBEC
		Friend Overridable Property Label1 As Label

		' Token: 0x17000138 RID: 312
		' (get) Token: 0x06000350 RID: 848 RVA: 0x000209F5 File Offset: 0x0001EBF5
		' (set) Token: 0x06000351 RID: 849 RVA: 0x000209FF File Offset: 0x0001EBFF
		Friend Overridable Property txtNo As TextBox

		' Token: 0x17000139 RID: 313
		' (get) Token: 0x06000352 RID: 850 RVA: 0x00020A08 File Offset: 0x0001EC08
		' (set) Token: 0x06000353 RID: 851 RVA: 0x00020A12 File Offset: 0x0001EC12
		Friend Overridable Property cmbStatus As ComboBox

		' Token: 0x1700013A RID: 314
		' (get) Token: 0x06000354 RID: 852 RVA: 0x00020A1B File Offset: 0x0001EC1B
		' (set) Token: 0x06000355 RID: 853 RVA: 0x00020A25 File Offset: 0x0001EC25
		Friend Overridable Property dtpFrom As DateTimePicker

		' Token: 0x1700013B RID: 315
		' (get) Token: 0x06000356 RID: 854 RVA: 0x00020A2E File Offset: 0x0001EC2E
		' (set) Token: 0x06000357 RID: 855 RVA: 0x00020A38 File Offset: 0x0001EC38
		Friend Overridable Property Label11 As Label

		' Token: 0x1700013C RID: 316
		' (get) Token: 0x06000358 RID: 856 RVA: 0x00020A41 File Offset: 0x0001EC41
		' (set) Token: 0x06000359 RID: 857 RVA: 0x00020A4B File Offset: 0x0001EC4B
		Friend Overridable Property dtpTo As DateTimePicker

		' Token: 0x1700013D RID: 317
		' (get) Token: 0x0600035A RID: 858 RVA: 0x00020A54 File Offset: 0x0001EC54
		' (set) Token: 0x0600035B RID: 859 RVA: 0x00020A5E File Offset: 0x0001EC5E
		Friend Overridable Property Label16 As Label

		' Token: 0x1700013E RID: 318
		' (get) Token: 0x0600035C RID: 860 RVA: 0x00020A67 File Offset: 0x0001EC67
		' (set) Token: 0x0600035D RID: 861 RVA: 0x00020A71 File Offset: 0x0001EC71
		Friend Overridable Property lblDate As ComboBox

		' Token: 0x1700013F RID: 319
		' (get) Token: 0x0600035E RID: 862 RVA: 0x00020A7A File Offset: 0x0001EC7A
		' (set) Token: 0x0600035F RID: 863 RVA: 0x00020A84 File Offset: 0x0001EC84
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

		' Token: 0x17000140 RID: 320
		' (get) Token: 0x06000360 RID: 864 RVA: 0x00020AC7 File Offset: 0x0001ECC7
		' (set) Token: 0x06000361 RID: 865 RVA: 0x00020AD1 File Offset: 0x0001ECD1
		Friend Overridable Property GbAdvanced As GroupBox

		' Token: 0x17000141 RID: 321
		' (get) Token: 0x06000362 RID: 866 RVA: 0x00020ADA File Offset: 0x0001ECDA
		' (set) Token: 0x06000363 RID: 867 RVA: 0x00020AE4 File Offset: 0x0001ECE4
		Friend Overridable Property pnlItem As Panel

		' Token: 0x17000142 RID: 322
		' (get) Token: 0x06000364 RID: 868 RVA: 0x00020AED File Offset: 0x0001ECED
		' (set) Token: 0x06000365 RID: 869 RVA: 0x00020AF7 File Offset: 0x0001ECF7
		Friend Overridable Property txtName As TextBox

		' Token: 0x17000143 RID: 323
		' (get) Token: 0x06000366 RID: 870 RVA: 0x00020B00 File Offset: 0x0001ED00
		' (set) Token: 0x06000367 RID: 871 RVA: 0x00020B0A File Offset: 0x0001ED0A
		Friend Overridable Property txtCatalogNo As TextBox

		' Token: 0x17000144 RID: 324
		' (get) Token: 0x06000368 RID: 872 RVA: 0x00020B13 File Offset: 0x0001ED13
		' (set) Token: 0x06000369 RID: 873 RVA: 0x00020B1D File Offset: 0x0001ED1D
		Friend Overridable Property Label14 As Label

		' Token: 0x17000145 RID: 325
		' (get) Token: 0x0600036A RID: 874 RVA: 0x00020B26 File Offset: 0x0001ED26
		' (set) Token: 0x0600036B RID: 875 RVA: 0x00020B30 File Offset: 0x0001ED30
		Friend Overridable Property Label5 As Label

		' Token: 0x17000146 RID: 326
		' (get) Token: 0x0600036C RID: 876 RVA: 0x00020B39 File Offset: 0x0001ED39
		' (set) Token: 0x0600036D RID: 877 RVA: 0x00020B43 File Offset: 0x0001ED43
		Friend Overridable Property txtCode As TextBox

		' Token: 0x17000147 RID: 327
		' (get) Token: 0x0600036E RID: 878 RVA: 0x00020B4C File Offset: 0x0001ED4C
		' (set) Token: 0x0600036F RID: 879 RVA: 0x00020B56 File Offset: 0x0001ED56
		Friend Overridable Property Label6 As Label

		' Token: 0x17000148 RID: 328
		' (get) Token: 0x06000370 RID: 880 RVA: 0x00020B5F File Offset: 0x0001ED5F
		' (set) Token: 0x06000371 RID: 881 RVA: 0x00020B6C File Offset: 0x0001ED6C
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

		' Token: 0x17000149 RID: 329
		' (get) Token: 0x06000372 RID: 882 RVA: 0x00020BAF File Offset: 0x0001EDAF
		' (set) Token: 0x06000373 RID: 883 RVA: 0x00020BB9 File Offset: 0x0001EDB9
		Friend Overridable Property Label13 As Label

		' Token: 0x1700014A RID: 330
		' (get) Token: 0x06000374 RID: 884 RVA: 0x00020BC2 File Offset: 0x0001EDC2
		' (set) Token: 0x06000375 RID: 885 RVA: 0x00020BCC File Offset: 0x0001EDCC
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

		' Token: 0x1700014B RID: 331
		' (get) Token: 0x06000376 RID: 886 RVA: 0x00020C0F File Offset: 0x0001EE0F
		' (set) Token: 0x06000377 RID: 887 RVA: 0x00020C19 File Offset: 0x0001EE19
		Friend Overridable Property Label9 As Label

		' Token: 0x1700014C RID: 332
		' (get) Token: 0x06000378 RID: 888 RVA: 0x00020C22 File Offset: 0x0001EE22
		' (set) Token: 0x06000379 RID: 889 RVA: 0x00020C2C File Offset: 0x0001EE2C
		Friend Overridable Property txtCreated As TextBox

		' Token: 0x1700014D RID: 333
		' (get) Token: 0x0600037A RID: 890 RVA: 0x00020C35 File Offset: 0x0001EE35
		' (set) Token: 0x0600037B RID: 891 RVA: 0x00020C3F File Offset: 0x0001EE3F
		Friend Overridable Property lblCreated As ComboBox

		' Token: 0x1700014E RID: 334
		' (get) Token: 0x0600037C RID: 892 RVA: 0x00020C48 File Offset: 0x0001EE48
		' (set) Token: 0x0600037D RID: 893 RVA: 0x00020C54 File Offset: 0x0001EE54
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

		' Token: 0x1700014F RID: 335
		' (get) Token: 0x0600037E RID: 894 RVA: 0x00020C97 File Offset: 0x0001EE97
		' (set) Token: 0x0600037F RID: 895 RVA: 0x00020CA1 File Offset: 0x0001EEA1
		Friend Overridable Property grpListButton As GroupBox

		' Token: 0x17000150 RID: 336
		' (get) Token: 0x06000380 RID: 896 RVA: 0x00020CAA File Offset: 0x0001EEAA
		' (set) Token: 0x06000381 RID: 897 RVA: 0x00020CB4 File Offset: 0x0001EEB4
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x17000151 RID: 337
		' (get) Token: 0x06000382 RID: 898 RVA: 0x00020CBD File Offset: 0x0001EEBD
		' (set) Token: 0x06000383 RID: 899 RVA: 0x00020CC8 File Offset: 0x0001EEC8
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

		' Token: 0x17000152 RID: 338
		' (get) Token: 0x06000384 RID: 900 RVA: 0x00020D0B File Offset: 0x0001EF0B
		' (set) Token: 0x06000385 RID: 901 RVA: 0x00020D18 File Offset: 0x0001EF18
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

		' Token: 0x17000153 RID: 339
		' (get) Token: 0x06000386 RID: 902 RVA: 0x00020D5B File Offset: 0x0001EF5B
		' (set) Token: 0x06000387 RID: 903 RVA: 0x00020D68 File Offset: 0x0001EF68
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

		' Token: 0x17000154 RID: 340
		' (get) Token: 0x06000388 RID: 904 RVA: 0x00020DAB File Offset: 0x0001EFAB
		' (set) Token: 0x06000389 RID: 905 RVA: 0x00020DB5 File Offset: 0x0001EFB5
		Friend Overridable Property lblRows As Label

		' Token: 0x17000155 RID: 341
		' (get) Token: 0x0600038A RID: 906 RVA: 0x00020DBE File Offset: 0x0001EFBE
		' (set) Token: 0x0600038B RID: 907 RVA: 0x00020DC8 File Offset: 0x0001EFC8
		Friend Overridable Property dgvList As DataGridView

		' Token: 0x0600038C RID: 908 RVA: 0x00020DD4 File Offset: 0x0001EFD4
		Public Sub New(sForm As String)
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.InitializeComponent()
			Me.pnlBasicDefaultHeight = Me.GbBasic.Height
			Me.pnlBasicSetHeight = 24
			Me.pnlAdvDefaultHeight = 24
			Me.pnlAdvSetHeight = Me.GbAdvanced.Height
			Me.sFormType = sForm
		End Sub

		' Token: 0x0600038D RID: 909 RVA: 0x00020E50 File Offset: 0x0001F050
		Private Sub SetSearchPanel()
			Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
			Me.GbBasic.Height = Me.pnlBasicDefaultHeight
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
		End Sub

		' Token: 0x0600038E RID: 910 RVA: 0x00020EA4 File Offset: 0x0001F0A4
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

		' Token: 0x0600038F RID: 911 RVA: 0x00020F14 File Offset: 0x0001F114
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

		' Token: 0x06000390 RID: 912 RVA: 0x00020F84 File Offset: 0x0001F184
		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x06000391 RID: 913 RVA: 0x00020FB9 File Offset: 0x0001F1B9
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Me.SetSearchPanel()
			Designing.SetTheme(Me)
			Me.FillCombo()
			Me.ClearList()
			Me.SetForm()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x06000392 RID: 914 RVA: 0x00020FF8 File Offset: 0x0001F1F8
		Private Sub FillCombo()
			Dim text As String = "SELECT VendorID, VendorName FROM Vendor ORDER BY VendorName"
			Dim data As DataTable = MainModule.GetData(text)
			Me.cmbVendor.ValueMember = "VendorID"
			Me.cmbVendor.DisplayMember = "VendorName"
			Me.cmbVendor.DataSource = data
			Me.cmbVendor.SelectedIndex = -1
		End Sub

		' Token: 0x06000393 RID: 915 RVA: 0x00021050 File Offset: 0x0001F250
		Private Sub SetForm()
			Dim text As String = Me.sFormType
			If Operators.CompareString(text, "PO Pending", False) = 0 Then
				Me.cmbStatus.Text = "Cost Approved"
				Me.SearchData()
			End If
		End Sub

		' Token: 0x06000394 RID: 916 RVA: 0x00021094 File Offset: 0x0001F294
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
		End Sub

		' Token: 0x06000395 RID: 917 RVA: 0x00021196 File Offset: 0x0001F396
		Private Sub btnClearList_Click(sender As Object, e As EventArgs)
			Me.ClearList()
		End Sub

		' Token: 0x06000396 RID: 918 RVA: 0x000211A0 File Offset: 0x0001F3A0
		Private Sub btnExport_Click(sender As Object, e As EventArgs)
			MainModule.ExportToExcel(Me.dgvList, Me.Text)
		End Sub

		' Token: 0x06000397 RID: 919 RVA: 0x000211B5 File Offset: 0x0001F3B5
		Private Sub cmbSummary_SelectedValueChanged(sender As Object, e As EventArgs)
			Me.SetSummary()
		End Sub

		' Token: 0x06000398 RID: 920 RVA: 0x000211C0 File Offset: 0x0001F3C0
		Private Sub SetSummary()
			Dim text As String = Me.cmbSummary.Text
			If Operators.CompareString(text, "PR-wise", False) <> 0 Then
				If Operators.CompareString(text, "Item-wise", False) <> 0 Then
					If Operators.CompareString(text, "PO Pending", False) <> 0 Then
						If Operators.CompareString(text, "PO Raised", False) <> 0 Then
							If Operators.CompareString(text, "Item-wise GRN Pending", False) = 0 Then
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
					Else
						Me.pnlItem.Visible = False
						Me.pnlAdvSetHeight = 86
						Dim flag3 As Boolean = Operators.ConditionalCompareObjectEqual(Me.arrow_btnAdvanceExp_sml.Tag, "ArrowUp", False)
						If flag3 Then
							Me.GbAdvanced.Height = Me.pnlAdvSetHeight
						End If
					End If
				Else
					Me.pnlItem.Visible = True
					Me.pnlAdvSetHeight = 142
					Dim flag4 As Boolean = Operators.ConditionalCompareObjectEqual(Me.arrow_btnAdvanceExp_sml.Tag, "ArrowUp", False)
					If flag4 Then
						Me.GbAdvanced.Height = Me.pnlAdvSetHeight
					End If
				End If
			Else
				Me.pnlItem.Visible = False
				Me.pnlAdvSetHeight = 86
				Dim flag5 As Boolean = Operators.ConditionalCompareObjectEqual(Me.arrow_btnAdvanceExp_sml.Tag, "ArrowUp", False)
				If flag5 Then
					Me.GbAdvanced.Height = Me.pnlAdvSetHeight
				End If
			End If
			Me.txtCode.Text = ""
			Me.txtCatalogNo.Text = ""
			Me.txtName.Text = ""
		End Sub

		' Token: 0x06000399 RID: 921 RVA: 0x000213D8 File Offset: 0x0001F5D8
		Private Sub cmbVendor_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbVendor.SelectedIndex = -1
			If flag Then
				Me.cmbVendor.Text = ""
			End If
		End Sub

		' Token: 0x0600039A RID: 922 RVA: 0x0002140C File Offset: 0x0001F60C
		Private Sub btnSearch_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SearchData()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x0600039B RID: 923 RVA: 0x00021478 File Offset: 0x0001F678
		Private Sub SearchData()
			Dim text As String = ""
			Dim text2 As String = Me.cmbSummary.Text
			Dim text3 As String
			If Operators.CompareString(text2, "PR-wise", False) <> 0 AndAlso Operators.CompareString(text2, "PO Pending", False) <> 0 AndAlso Operators.CompareString(text2, "PO Raised", False) <> 0 AndAlso Operators.CompareString(text2, "PO Complete", False) <> 0 Then
				If Operators.CompareString(text2, "Item-wise", False) <> 0 Then
					If Operators.CompareString(text2, "Item-wise GRN Pending", False) = 0 Then
						text3 = " SELECT P.PRID AS ID, P.PRNo, P.PRDt,  Req.UserName AS RequestedBy, P.Department, " & vbCrLf
						text3 += " PI.ProductType, PI.ProductCode, Pr.CatalogNo, PI.ProductName, PI.Description, Pr.TertiaryUOM, PI.TertiaryPackSize, " & vbCrLf
						text3 += " PI.Quantity, SUM(ISNULL(GI.ReceivedQty,0)) ReceivedQty, PI.Quantity - SUM(ISNULL(GI.ReceivedQty,0)) BalanceQty " & vbCrLf
						text3 += " FROM PR AS P " & vbCrLf
						text3 += " LEFT OUTER JOIN Vendor AS V ON P.VendorID = V.VendorID " & vbCrLf
						text3 += " LEFT OUTER JOIN [User] AS Action ON P.ActionBy = Action.UserID " & vbCrLf
						text3 += " LEFT OUTER JOIN [User] AS Req ON P.RequestedBy = Req.UserID " & vbCrLf
						text3 += " LEFT OUTER JOIN [User] AS Can ON P.CancelledBy = Can.UserID " & vbCrLf
						text3 += " LEFT OUTER JOIN [User] AS Created ON P.CreatedBy = Created.UserID " & vbCrLf
						text3 += " LEFT OUTER JOIN [User] AS Modified ON P.ModifiedBy = Modified.UserID " & vbCrLf
						text3 += " INNER JOIN PRItems PI ON P.PRID = PI.PRID " & vbCrLf
						text3 += " LEFT OUTER JOIN Product Pr ON Pr.ProductID = PI.ProductID " & vbCrLf
						text3 += " LEFT OUTER JOIN POPR ON P.PRID = POPR.PRID " & vbCrLf
						text3 += " LEFT OUTER JOIN GRN G ON POPR.POID = G.POID " & vbCrLf
						text3 += " LEFT JOIN GRNItems GI ON G.GRNID = GI.GRNID AND GI.ProductID = PI.ProductID " & vbCrLf
					End If
				Else
					text3 = " SELECT P.PRID AS ID, P.Status, P.ApprovalLevel, P.PRNo, P.PRDt, P.RequestedBy RequestedByID,  " & vbCrLf
					text3 += " Req.UserName AS RequestedBy, Req.EmailID ReqEmailID, P.Department, P.RequiredByDt, PI.ProductName, PI.Description,  " & vbCrLf
					text3 += " P.VendorID, V.VendorName, P.Remarks, P.ActionRemarks,  " & vbCrLf
					text3 += " PI.ProductType, PI.ProductCode, Pr.CatalogNo, Pr.TertiaryUOM, PI.TertiaryPackSize, PI.Quantity,  " & vbCrLf
					text3 += " Action.UserName AS ActionBy, P.ActionDt,  " & vbCrLf
					text3 += " Can.UserName CancelledBy, P.CancelledDt, P.CancelledRemarks, " & vbCrLf
					text3 += " Created.EmailID AS CreatedByEmailID, Modified.EmailID AS ModifiedByEmailID,  " & vbCrLf
					text3 += " P.CreationDt, Created.UserName AS CreatedBy, P.ModificationDt, Modified.UserName AS ModifiedBy " & vbCrLf
					text3 += " FROM PR AS P  " & vbCrLf
					text3 += " LEFT OUTER JOIN Vendor AS V ON P.VendorID = V.VendorID  " & vbCrLf
					text3 += " LEFT OUTER JOIN [User] AS Action ON P.ActionBy = Action.UserID  " & vbCrLf
					text3 += " LEFT OUTER JOIN [User] AS Req ON P.RequestedBy = Req.UserID  " & vbCrLf
					text3 += " LEFT OUTER JOIN [User] AS Can ON P.CancelledBy = Can.UserID " & vbCrLf
					text3 += " LEFT OUTER JOIN [User] AS Created ON P.CreatedBy = Created.UserID  " & vbCrLf
					text3 += " LEFT OUTER JOIN [User] AS Modified ON P.ModifiedBy = Modified.UserID " & vbCrLf
					text3 += " INNER JOIN PRItems PI ON P.PRID = PI.PRID  " & vbCrLf
					text3 += " LEFT OUTER JOIN Product Pr ON Pr.ProductID = PI.ProductID  " & vbCrLf
				End If
			Else
				text3 = " SELECT P.PRID AS ID, P.Status, P.ApprovalLevel, P.PRNo, P.PRDt, P.RequestedBy RequestedByID,  " & vbCrLf
				text3 += " Req.UserName AS RequestedBy, Req.EmailID ReqEmailID, P.Department, P.RequiredByDt,  " & vbCrLf
				text3 += " P.VendorID, V.VendorName, P.Remarks, P.ActionRemarks,  " & vbCrLf
				text3 += " Action.UserName AS ActionBy, P.ActionDt,  " & vbCrLf
				text3 += " Can.UserName CancelledBy, P.CancelledDt, P.CancelledRemarks, " & vbCrLf
				text3 += " Created.EmailID AS CreatedByEmailID, Modified.EmailID AS ModifiedByEmailID,  " & vbCrLf
				text3 += " P.CreationDt, Created.UserName AS CreatedBy, P.ModificationDt, Modified.UserName AS ModifiedBy " & vbCrLf
				text3 += " FROM PR AS P  " & vbCrLf
				text3 += " LEFT OUTER JOIN Vendor AS V ON P.VendorID = V.VendorID  " & vbCrLf
				text3 += " LEFT OUTER JOIN [User] AS Action ON P.ActionBy = Action.UserID  " & vbCrLf
				text3 += " LEFT OUTER JOIN [User] AS Req ON P.RequestedBy = Req.UserID  " & vbCrLf
				text3 += " LEFT OUTER JOIN [User] AS Can ON P.CancelledBy = Can.UserID " & vbCrLf
				text3 += " LEFT OUTER JOIN [User] AS Created ON P.CreatedBy = Created.UserID  " & vbCrLf
				text3 += " LEFT OUTER JOIN [User] AS Modified ON P.ModifiedBy = Modified.UserID " & vbCrLf
			End If
			text3 += " WHERE 1=1" & vbCrLf
			Dim flag As Boolean = Strings.InStr(GlobalVariables.gsUserGroup.ToLower(), "admin", CompareMethod.Binary) = 0
			If flag Then
				text3 = text3 + " AND P.Department = '" + GlobalVariables.gsDepartment + "' " & vbCrLf
			End If
			Dim text4 As String = Me.cmbSummary.Text
			If Operators.CompareString(text4, "PR-wise", False) <> 0 Then
				If Operators.CompareString(text4, "Item-wise", False) <> 0 Then
					If Operators.CompareString(text4, "PO Pending", False) <> 0 Then
						If Operators.CompareString(text4, "PO Raised", False) <> 0 Then
							If Operators.CompareString(text4, "PO Complete", False) = 0 Then
								text3 += " AND P.Status = 'PO Complete'" & vbCrLf
							End If
						Else
							text3 += " AND P.PRID IN (SELECT PRID FROM POPR)" & vbCrLf
						End If
					Else
						text3 += " AND P.Status <> 'PO Complete'" & vbCrLf
					End If
				End If
			End If
			Dim flag2 As Boolean = Operators.CompareString(Strings.Trim(Me.txtNo.Text), "", False) <> 0
			If flag2 Then
				text3 = text3 + " AND (PRNo LIKE '%" + Strings.Trim(Me.txtNo.Text) + "%')" & vbCrLf
				text = text + "PRNo LIKE " + Strings.Trim(Me.txtNo.Text) + vbCrLf
			End If
			Dim flag3 As Boolean = Me.cmbVendor.SelectedIndex > -1
			If flag3 Then
				text3 = text3 + " AND (P.VendorID = '" + Strings.Trim(Me.cmbVendor.SelectedValue.ToString()) + "')" & vbCrLf
				text = text + "VendorID = " + Strings.Trim(Me.cmbVendor.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag4 As Boolean = Me.cmbStatus.SelectedIndex > 0
			If flag4 Then
				text3 = text3 + " AND (P.Status = '" + Me.cmbStatus.Text + "')" & vbCrLf
				text = text + ("P.Status = " + Me.cmbStatus.Text) + vbCrLf
			End If
			Dim flag5 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCreated.Text), "", False) <> 0
			If flag5 Then
				Dim flag6 As Boolean = Me.lblCreated.SelectedIndex >= 0
				If flag6 Then
					Dim text5 As String = Me.lblCreated.Text
					Dim text6 As String
					If Operators.CompareString(text5, "Requested By", False) <> 0 Then
						If Operators.CompareString(text5, "Created By", False) <> 0 Then
							If Operators.CompareString(text5, "Last Modified By", False) = 0 Then
								text6 = "Modified"
							End If
						Else
							text6 = "Created"
						End If
					Else
						text6 = "Req"
					End If
					text3 = String.Concat(New String() { text3, " AND ", text6, ".UserName LIKE '%", Strings.Trim(Me.txtCreated.Text), "%'" })
					text = text + (text6 + "By LIKE " + Strings.Trim(Me.txtCreated.Text)) + vbCrLf
				End If
			End If
			Dim flag7 As Boolean = Me.lblDate.SelectedIndex >= 0
			If flag7 Then
				Dim text7 As String = Me.lblDate.Text
				Dim text8 As String
				If Operators.CompareString(text7, "Creation", False) <> 0 Then
					If Operators.CompareString(text7, "Last Modification", False) <> 0 Then
						If Operators.CompareString(text7, "P.R. Date", False) <> 0 Then
							If Operators.CompareString(text7, "Required By Date", False) <> 0 Then
								text8 = ""
							Else
								text8 = "RequiredByDt"
							End If
						Else
							text8 = "PRDt"
						End If
					Else
						text8 = "ModificationDt"
					End If
				Else
					text8 = "CreationDt"
				End If
				Dim flag8 As Boolean = Operators.CompareString(text8, "", False) <> 0
				If flag8 Then
					Dim flag9 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
					If flag9 Then
						text3 = String.Concat(New String() { text3, " AND ", text8, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
						text = text + String.Concat(New String() { text8, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
					Else
						Dim checked As Boolean = Me.dtpFrom.Checked
						If checked Then
							text3 = String.Concat(New String() { text3, " AND ", text8, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59"), "'" })
							text = text + String.Concat(New String() { text8, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
						End If
						Dim checked2 As Boolean = Me.dtpTo.Checked
						If checked2 Then
							text3 = String.Concat(New String() { text3, " AND ", text8, " BETWEEN '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
							text = text + String.Concat(New String() { text8, " BETWEEN  ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
						End If
					End If
				End If
			End If
			Dim flag10 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Item-wise", False) = 0
			If flag10 Then
				Dim flag11 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCode.Text), "", False) <> 0
				If flag11 Then
					text3 = text3 + " AND (Pr.ProductCode Like '%" + Strings.Trim(Me.txtCode.Text) + "%') "
					text = text + "ProductCode LIKE " + Strings.Trim(Me.txtCode.Text) + vbCrLf
				End If
				Dim flag12 As Boolean = Operators.CompareString(Strings.Trim(Me.txtName.Text), "", False) <> 0
				If flag12 Then
					text3 = text3 + " AND (Pr.ProductName Like '%" + Strings.Trim(Me.txtName.Text) + "%') "
					text = text + "ProductName LIKE " + Strings.Trim(Me.txtName.Text) + vbCrLf
				End If
				Dim flag13 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCatalogNo.Text), "", False) <> 0
				If flag13 Then
					text3 = text3 + " AND (Pr.CatalogNo Like '%" + Strings.Trim(Me.txtCatalogNo.Text) + "%') "
					text = text + "CatalogNo LIKE " + Strings.Trim(Me.txtCatalogNo.Text) + vbCrLf
				End If
			End If
			Dim text9 As String = Me.cmbSummary.Text
			If Operators.CompareString(text9, "Item-wise GRN Pending", False) = 0 Then
				text3 += " GROUP BY P.PRID, P.PRNo, P.PRDt,  Req.UserName, P.Department, PI.ProductName, PI.Description, " & vbCrLf
				text3 += " PI.ProductCode, Pr.CatalogNo, PI.ProductType, Pr.TertiaryUOM, PI.TertiaryPackSize, PI.Quantity " & vbCrLf
				text3 += " HAVING PI.Quantity - SUM(ISNULL(GI.ReceivedQty,0)) > 0 " & vbCrLf
			End If
			text3 += " ORDER BY PRDt" & vbCrLf
			Dim data As DataTable = MainModule.GetData(text3)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = Nothing
			Me.dgvList.DataSource = data
			Me.dgvList.Columns("ID").Visible = False
			Dim flag14 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Item-wise GRN Pending", False) <> 0
			If flag14 Then
				Me.dgvList.Columns("VendorID").Visible = False
				Me.dgvList.Columns("RequestedByID").Visible = False
				Me.dgvList.Columns("ReqEmailID").Visible = False
				Me.dgvList.Columns("CreatedByEmailID").Visible = False
				Me.dgvList.Columns("ModifiedByEmailID").Visible = False
				Me.dgvList.Columns("Remarks").Visible = False
				Me.dgvList.Columns("ActionRemarks").Visible = False
				Me.dgvList.Columns("CancelledRemarks").Visible = False
			End If
			Me.dgvList.Columns("PRNo").HeaderText = "PR No."
			Me.dgvList.Columns("PRDt").HeaderText = "PR Date"
			Me.dgvList.Columns("RequestedBy").HeaderText = "Requested By"
			Dim flag15 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Item-wise GRN Pending", False) <> 0
			If flag15 Then
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
			End If
			Me.dgvList.Columns("PRDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Dim flag16 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Item-wise GRN Pending", False) <> 0
			If flag16 Then
				Me.dgvList.Columns("RequiredByDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
				Me.dgvList.Columns("ActionDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
				Me.dgvList.Columns("CancelledDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
				Me.dgvList.Columns("CreationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
				Me.dgvList.Columns("ModificationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			End If
			Me.dgvList.Columns("PRNo").Width = 130
			Me.dgvList.Columns("PRDt").Width = 120
			Me.dgvList.Columns("RequestedBy").Width = 130
			Dim flag17 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Item-wise GRN Pending", False) <> 0
			If flag17 Then
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
			End If
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
				Dim flag19 As Boolean = data.Columns.Contains("ReceivedQty")
				If flag19 Then
					Me.dgvList.Columns("ReceivedQty").HeaderText = "Received Qty."
					Me.dgvList.Columns("BalanceQty").HeaderText = "Balance Qty."
					Me.dgvList.Columns("ReceivedQty").Width = 65
					Me.dgvList.Columns("BalanceQty").Width = 60
					Me.dgvList.Columns("ReceivedQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
					Me.dgvList.Columns("BalanceQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				End If
			End If
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x04000176 RID: 374
		Private sFormType As String

		' Token: 0x04000177 RID: 375
		Private pnlBasicDefaultHeight As Integer

		' Token: 0x04000178 RID: 376
		Private pnlBasicSetHeight As Integer

		' Token: 0x04000179 RID: 377
		Private pnlAdvDefaultHeight As Integer

		' Token: 0x0400017A RID: 378
		Private pnlAdvSetHeight As Integer
	End Class
End Namespace
