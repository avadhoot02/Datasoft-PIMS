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
	' Token: 0x02000017 RID: 23
	<DesignerGenerated()>
	Public Partial Class QurantineReport
		Inherits DockContent

		' Token: 0x17000156 RID: 342
		' (get) Token: 0x0600039E RID: 926 RVA: 0x000241DF File Offset: 0x000223DF
		' (set) Token: 0x0600039F RID: 927 RVA: 0x000241E9 File Offset: 0x000223E9
		Friend Overridable Property GbBasic As GroupBox

		' Token: 0x17000157 RID: 343
		' (get) Token: 0x060003A0 RID: 928 RVA: 0x000241F2 File Offset: 0x000223F2
		' (set) Token: 0x060003A1 RID: 929 RVA: 0x000241FC File Offset: 0x000223FC
		Friend Overridable Property cmbPlant As ComboBox

		' Token: 0x17000158 RID: 344
		' (get) Token: 0x060003A2 RID: 930 RVA: 0x00024205 File Offset: 0x00022405
		' (set) Token: 0x060003A3 RID: 931 RVA: 0x0002420F File Offset: 0x0002240F
		Friend Overridable Property Label3 As Label

		' Token: 0x17000159 RID: 345
		' (get) Token: 0x060003A4 RID: 932 RVA: 0x00024218 File Offset: 0x00022418
		' (set) Token: 0x060003A5 RID: 933 RVA: 0x00024222 File Offset: 0x00022422
		Friend Overridable Property txtNo As TextBox

		' Token: 0x1700015A RID: 346
		' (get) Token: 0x060003A6 RID: 934 RVA: 0x0002422B File Offset: 0x0002242B
		' (set) Token: 0x060003A7 RID: 935 RVA: 0x00024235 File Offset: 0x00022435
		Friend Overridable Property dtpFrom As DateTimePicker

		' Token: 0x1700015B RID: 347
		' (get) Token: 0x060003A8 RID: 936 RVA: 0x0002423E File Offset: 0x0002243E
		' (set) Token: 0x060003A9 RID: 937 RVA: 0x00024248 File Offset: 0x00022448
		Friend Overridable Property dtpTo As DateTimePicker

		' Token: 0x1700015C RID: 348
		' (get) Token: 0x060003AA RID: 938 RVA: 0x00024251 File Offset: 0x00022451
		' (set) Token: 0x060003AB RID: 939 RVA: 0x0002425B File Offset: 0x0002245B
		Friend Overridable Property Label16 As Label

		' Token: 0x1700015D RID: 349
		' (get) Token: 0x060003AC RID: 940 RVA: 0x00024264 File Offset: 0x00022464
		' (set) Token: 0x060003AD RID: 941 RVA: 0x0002426E File Offset: 0x0002246E
		Friend Overridable Property lblDate As ComboBox

		' Token: 0x1700015E RID: 350
		' (get) Token: 0x060003AE RID: 942 RVA: 0x00024277 File Offset: 0x00022477
		' (set) Token: 0x060003AF RID: 943 RVA: 0x00024284 File Offset: 0x00022484
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

		' Token: 0x1700015F RID: 351
		' (get) Token: 0x060003B0 RID: 944 RVA: 0x000242C7 File Offset: 0x000224C7
		' (set) Token: 0x060003B1 RID: 945 RVA: 0x000242D1 File Offset: 0x000224D1
		Friend Overridable Property cmbStatus As ComboBox

		' Token: 0x17000160 RID: 352
		' (get) Token: 0x060003B2 RID: 946 RVA: 0x000242DA File Offset: 0x000224DA
		' (set) Token: 0x060003B3 RID: 947 RVA: 0x000242E4 File Offset: 0x000224E4
		Friend Overridable Property Label11 As Label

		' Token: 0x17000161 RID: 353
		' (get) Token: 0x060003B4 RID: 948 RVA: 0x000242ED File Offset: 0x000224ED
		' (set) Token: 0x060003B5 RID: 949 RVA: 0x000242F7 File Offset: 0x000224F7
		Friend Overridable Property GbAdvanced As GroupBox

		' Token: 0x17000162 RID: 354
		' (get) Token: 0x060003B6 RID: 950 RVA: 0x00024300 File Offset: 0x00022500
		' (set) Token: 0x060003B7 RID: 951 RVA: 0x0002430A File Offset: 0x0002250A
		Friend Overridable Property cmbSummary As ComboBox

		' Token: 0x17000163 RID: 355
		' (get) Token: 0x060003B8 RID: 952 RVA: 0x00024313 File Offset: 0x00022513
		' (set) Token: 0x060003B9 RID: 953 RVA: 0x0002431D File Offset: 0x0002251D
		Friend Overridable Property txtName As TextBox

		' Token: 0x17000164 RID: 356
		' (get) Token: 0x060003BA RID: 954 RVA: 0x00024326 File Offset: 0x00022526
		' (set) Token: 0x060003BB RID: 955 RVA: 0x00024330 File Offset: 0x00022530
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

		' Token: 0x17000165 RID: 357
		' (get) Token: 0x060003BC RID: 956 RVA: 0x00024373 File Offset: 0x00022573
		' (set) Token: 0x060003BD RID: 957 RVA: 0x0002437D File Offset: 0x0002257D
		Friend Overridable Property Label13 As Label

		' Token: 0x17000166 RID: 358
		' (get) Token: 0x060003BE RID: 958 RVA: 0x00024386 File Offset: 0x00022586
		' (set) Token: 0x060003BF RID: 959 RVA: 0x00024390 File Offset: 0x00022590
		Friend Overridable Property Label9 As Label

		' Token: 0x17000167 RID: 359
		' (get) Token: 0x060003C0 RID: 960 RVA: 0x00024399 File Offset: 0x00022599
		' (set) Token: 0x060003C1 RID: 961 RVA: 0x000243A3 File Offset: 0x000225A3
		Friend Overridable Property Label14 As Label

		' Token: 0x17000168 RID: 360
		' (get) Token: 0x060003C2 RID: 962 RVA: 0x000243AC File Offset: 0x000225AC
		' (set) Token: 0x060003C3 RID: 963 RVA: 0x000243B6 File Offset: 0x000225B6
		Friend Overridable Property txtCreated As TextBox

		' Token: 0x17000169 RID: 361
		' (get) Token: 0x060003C4 RID: 964 RVA: 0x000243BF File Offset: 0x000225BF
		' (set) Token: 0x060003C5 RID: 965 RVA: 0x000243C9 File Offset: 0x000225C9
		Friend Overridable Property txtCode As TextBox

		' Token: 0x1700016A RID: 362
		' (get) Token: 0x060003C6 RID: 966 RVA: 0x000243D2 File Offset: 0x000225D2
		' (set) Token: 0x060003C7 RID: 967 RVA: 0x000243DC File Offset: 0x000225DC
		Friend Overridable Property Label7 As Label

		' Token: 0x1700016B RID: 363
		' (get) Token: 0x060003C8 RID: 968 RVA: 0x000243E5 File Offset: 0x000225E5
		' (set) Token: 0x060003C9 RID: 969 RVA: 0x000243EF File Offset: 0x000225EF
		Friend Overridable Property lblCreated As ComboBox

		' Token: 0x1700016C RID: 364
		' (get) Token: 0x060003CA RID: 970 RVA: 0x000243F8 File Offset: 0x000225F8
		' (set) Token: 0x060003CB RID: 971 RVA: 0x00024404 File Offset: 0x00022604
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

		' Token: 0x1700016D RID: 365
		' (get) Token: 0x060003CC RID: 972 RVA: 0x00024447 File Offset: 0x00022647
		' (set) Token: 0x060003CD RID: 973 RVA: 0x00024451 File Offset: 0x00022651
		Friend Overridable Property grpListButton As GroupBox

		' Token: 0x1700016E RID: 366
		' (get) Token: 0x060003CE RID: 974 RVA: 0x0002445A File Offset: 0x0002265A
		' (set) Token: 0x060003CF RID: 975 RVA: 0x00024464 File Offset: 0x00022664
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x1700016F RID: 367
		' (get) Token: 0x060003D0 RID: 976 RVA: 0x0002446D File Offset: 0x0002266D
		' (set) Token: 0x060003D1 RID: 977 RVA: 0x00024478 File Offset: 0x00022678
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

		' Token: 0x17000170 RID: 368
		' (get) Token: 0x060003D2 RID: 978 RVA: 0x000244BB File Offset: 0x000226BB
		' (set) Token: 0x060003D3 RID: 979 RVA: 0x000244C8 File Offset: 0x000226C8
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

		' Token: 0x17000171 RID: 369
		' (get) Token: 0x060003D4 RID: 980 RVA: 0x0002450B File Offset: 0x0002270B
		' (set) Token: 0x060003D5 RID: 981 RVA: 0x00024518 File Offset: 0x00022718
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

		' Token: 0x17000172 RID: 370
		' (get) Token: 0x060003D6 RID: 982 RVA: 0x0002455B File Offset: 0x0002275B
		' (set) Token: 0x060003D7 RID: 983 RVA: 0x00024565 File Offset: 0x00022765
		Friend Overridable Property lblRows As Label

		' Token: 0x17000173 RID: 371
		' (get) Token: 0x060003D8 RID: 984 RVA: 0x0002456E File Offset: 0x0002276E
		' (set) Token: 0x060003D9 RID: 985 RVA: 0x00024578 File Offset: 0x00022778
		Friend Overridable Property dgvList As DataGridView

		' Token: 0x060003DA RID: 986 RVA: 0x00024584 File Offset: 0x00022784
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.InitializeComponent()
			Me.pnlBasicDefaultHeight = Me.GbBasic.Height
			Me.pnlBasicSetHeight = 23
			Me.pnlAdvDefaultHeight = 23
			Me.pnlAdvSetHeight = Me.GbAdvanced.Height
		End Sub

		' Token: 0x060003DB RID: 987 RVA: 0x000245F8 File Offset: 0x000227F8
		Private Sub SetSearchPanel()
			Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
			Me.GbBasic.Height = Me.pnlBasicDefaultHeight
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
		End Sub

		' Token: 0x060003DC RID: 988 RVA: 0x0002464C File Offset: 0x0002284C
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

		' Token: 0x060003DD RID: 989 RVA: 0x000246BC File Offset: 0x000228BC
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

		' Token: 0x060003DE RID: 990 RVA: 0x0002472C File Offset: 0x0002292C
		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x060003DF RID: 991 RVA: 0x00024761 File Offset: 0x00022961
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Me.SetSearchPanel()
			Designing.SetTheme(Me)
			Me.FillCombo()
			Me.ClearList()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x060003E0 RID: 992 RVA: 0x00024798 File Offset: 0x00022998
		Private Sub FillCombo()
			Dim text As String = "SELECT VendorID, VendorName FROM Vendor ORDER BY VendorName"
			Dim data As DataTable = MainModule.GetData(text)
			Me.cmbVendor.ValueMember = "VendorID"
			Me.cmbVendor.DisplayMember = "VendorName"
			Me.cmbVendor.DataSource = data
			Me.cmbVendor.SelectedIndex = -1
		End Sub

		' Token: 0x060003E1 RID: 993 RVA: 0x000247F0 File Offset: 0x000229F0
		Private Sub ClearList()
			Me.lblDate.SelectedIndex = 0
			Me.lblCreated.SelectedIndex = 0
			Me.txtNo.Text = ""
			Me.txtCreated.Text = ""
			Me.cmbVendor.Text = ""
			Me.cmbStatus.SelectedIndex = 0
			Me.cmbSummary.Text = "GRN-wise"
			Me.dtpFrom.Value = DateAndTime.Now
			Me.dtpTo.Value = DateAndTime.Now
			Me.dtpFrom.Checked = False
			Me.dtpTo.Checked = False
			Me.lblRows.Text = "0 - Rows"
			Me.dgvList.DataSource = Nothing
		End Sub

		' Token: 0x060003E2 RID: 994 RVA: 0x000248C3 File Offset: 0x00022AC3
		Private Sub btnClearList_Click(sender As Object, e As EventArgs)
			Me.ClearList()
		End Sub

		' Token: 0x060003E3 RID: 995 RVA: 0x000248CD File Offset: 0x00022ACD
		Private Sub btnExport_Click(sender As Object, e As EventArgs)
			MainModule.ExportToExcel(Me.dgvList, Me.Text)
		End Sub

		' Token: 0x060003E4 RID: 996 RVA: 0x000248E4 File Offset: 0x00022AE4
		Private Sub cmbVendor_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbVendor.SelectedIndex = -1
			If flag Then
				Me.cmbVendor.Text = ""
			End If
		End Sub

		' Token: 0x060003E5 RID: 997 RVA: 0x00024918 File Offset: 0x00022B18
		Private Sub btnSearch_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SearchData("")
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x060003E6 RID: 998 RVA: 0x0002498C File Offset: 0x00022B8C
		Private Sub SearchData(sID As String)
			Dim text As String = ""
			Dim text2 As String = Me.cmbSummary.Text
			Dim text3 As String
			If Operators.CompareString(text2, "GRN-wise", False) <> 0 Then
				If Operators.CompareString(text2, "Batch-wise", False) <> 0 Then
					If Operators.CompareString(text2, "Product-wise", False) = 0 Then
						text3 = " SELECT P.ProductType, P.ProductCode, P.ProductName, P.PrimaryUOM, " & vbCrLf
						text3 += " SUM(GU.Price) Value" & vbCrLf
						text3 += " FROM GRN AS G " & vbCrLf
						text3 += " INNER JOIN GRNItems AS GI ON G.GRNID = GI.GRNID " & vbCrLf
						text3 += " INNER JOIN GRNUID AS GU ON GI.GRNItemsID = GU.GRNItemsID " & vbCrLf
						text3 += " INNER JOIN Product AS P ON GI.ProductID = P.ProductID " & vbCrLf
						text3 += " INNER JOIN Vendor AS V ON G.VendorID = V.VendorID" & vbCrLf
					End If
				Else
					text3 = " SELECT P.ProductType, P.ProductCode, P.ProductName, P.PrimaryUOM, " & vbCrLf
					text3 += " GI.BatchNo, GI.MfgDt, GI.ExpDt, SUM(GU.Price) Value, GI.FinalConcentration, GI.Titre" & vbCrLf
					text3 += " FROM GRN AS G " & vbCrLf
					text3 += " INNER JOIN GRNItems AS GI ON G.GRNID = GI.GRNID " & vbCrLf
					text3 += " INNER JOIN GRNUID AS GU ON GI.GRNItemsID = GU.GRNItemsID " & vbCrLf
					text3 += " INNER JOIN Product AS P ON GI.ProductID = P.ProductID " & vbCrLf
					text3 += " INNER JOIN Vendor AS V ON G.VendorID = V.VendorID" & vbCrLf
				End If
			Else
				text3 = " SELECT G.GRNID, G.GRNType, G.GRNNo, G.GRNDt, G.VendorID, V.VendorName, " & vbCrLf
				text3 += " P.ProductType, P.ProductCode, P.ProductName, P.PrimaryUOM," & vbCrLf
				text3 += " GI.BatchNo, GI.MfgDt, GI.ExpDt, SUM(GU.Price) Value, GI.FinalConcentration, GI.Titre" & vbCrLf
				text3 += " FROM GRN AS G " & vbCrLf
				text3 += " INNER JOIN GRNItems AS GI ON G.GRNID = GI.GRNID " & vbCrLf
				text3 += " INNER JOIN GRNUID AS GU ON GI.GRNItemsID = GU.GRNItemsID " & vbCrLf
				text3 += " INNER JOIN Product AS P ON GI.ProductID = P.ProductID " & vbCrLf
				text3 += " INNER JOIN Vendor AS V ON G.VendorID = V.VendorID" & vbCrLf
			End If
			text3 += " WHERE 1=1 " & vbCrLf
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.txtNo.Text), "", False) <> 0
			If flag Then
				text3 = text3 + " And (GRNNo Like '%" + Strings.Trim(Me.txtNo.Text) + "%') " & vbCrLf
				text = text + "GRNNo LIKE " + Strings.Trim(Me.txtNo.Text) + vbCrLf
			End If
			Dim flag2 As Boolean = Me.cmbVendor.SelectedIndex > -1
			If flag2 Then
				text3 = text3 + " AND (G.VendorID = '" + Strings.Trim(Me.cmbVendor.SelectedValue.ToString()) + "')" & vbCrLf
				text = text + "VendorID = " + Strings.Trim(Me.cmbVendor.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag3 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCode.Text), "", False) <> 0
			If flag3 Then
				text3 = text3 + " AND (P.ProductCode Like '%" + Strings.Trim(Me.txtCode.Text) + "%') "
				text = text + "ProductCode LIKE " + Strings.Trim(Me.txtCode.Text) + vbCrLf
			End If
			Dim flag4 As Boolean = Operators.CompareString(Strings.Trim(Me.txtName.Text), "", False) <> 0
			If flag4 Then
				text3 = text3 + " AND (P.ProductName Like '%" + Strings.Trim(Me.txtName.Text) + "%') "
				text = text + "ProductName LIKE " + Strings.Trim(Me.txtName.Text) + vbCrLf
			End If
			Dim text4 As String = Me.cmbStatus.Text
			If Operators.CompareString(text4, "Both", False) <> 0 Then
				If Operators.CompareString(text4, "QC Entry Pending", False) <> 0 Then
					If Operators.CompareString(text4, "QC Release Pending", False) = 0 Then
						text3 += " AND GI.Status IN ('QC Saved')" & vbCrLf
					End If
				Else
					text3 += " AND GI.Status IN ('In QC Release')" & vbCrLf
				End If
			Else
				text3 += " AND GI.Status IN ('In QC Release', 'QC Saved')" & vbCrLf
			End If
			Dim flag5 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCreated.Text), "", False) <> 0
			If flag5 Then
				Dim flag6 As Boolean = Me.lblCreated.SelectedIndex >= 0
				If flag6 Then
					Dim flag7 As Boolean = Me.lblCreated.SelectedIndex = 0
					Dim text5 As String
					If flag7 Then
						text5 = "Created"
					Else
						text5 = "Modified"
					End If
					text3 = String.Concat(New String() { text3, " AND ", text5, ".UserName LIKE '%", Strings.Trim(Me.txtCreated.Text), "%'" })
					text = text + (text5 + "By LIKE " + Strings.Trim(Me.txtCreated.Text)) + vbCrLf
				End If
			End If
			Dim flag8 As Boolean = Me.lblDate.SelectedIndex >= 0
			If flag8 Then
				Dim text6 As String = Me.lblDate.Text
				Dim text7 As String
				If Operators.CompareString(text6, "Creation", False) <> 0 Then
					If Operators.CompareString(text6, "Last Modification", False) <> 0 Then
						If Operators.CompareString(text6, "G.R.N Date", False) <> 0 Then
							If Operators.CompareString(text6, "P.O. Date", False) <> 0 Then
								If Operators.CompareString(text6, "Invoice Date", False) <> 0 Then
									If Operators.CompareString(text6, "Challan  Date", False) <> 0 Then
										text7 = ""
									Else
										text7 = "ChallanDt"
									End If
								Else
									text7 = "InvoiceDt"
								End If
							Else
								text7 = "PODt"
							End If
						Else
							text7 = "GRNDt"
						End If
					Else
						text7 = "ModificationDt"
					End If
				Else
					text7 = "CreationDt"
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
			Dim text8 As String = Me.cmbSummary.Text
			If Operators.CompareString(text8, "GRN-wise", False) <> 0 Then
				If Operators.CompareString(text8, "Batch-wise", False) <> 0 Then
					If Operators.CompareString(text8, "Product-wise", False) = 0 Then
						text3 += " GROUP BY P.ProductType, P.ProductCode, P.ProductName, P.PrimaryUOM" & vbCrLf
						text3 += " ORDER BY P.ProductCode" & vbCrLf
					End If
				Else
					text3 += " GROUP BY P.ProductType, P.ProductCode, P.ProductName, P.PrimaryUOM, " & vbCrLf
					text3 += " GI.BatchNo, GI.MfgDt, GI.ExpDt, GI.FinalConcentration, GI.Titre" & vbCrLf
					text3 += " ORDER BY P.ProductCode" & vbCrLf
				End If
			Else
				text3 += " GROUP BY G.GRNID, G.GRNType, G.GRNNo, G.GRNDt, G.VendorID, V.VendorName, " & vbCrLf
				text3 += " P.ProductType, P.ProductCode, P.ProductName, P.PrimaryUOM, " & vbCrLf
				text3 += " GI.BatchNo, GI.MfgDt, GI.ExpDt, GI.FinalConcentration, GI.Titre" & vbCrLf
				text3 += " ORDER BY G.GRNDt, P.ProductCode" & vbCrLf
			End If
			Dim data As DataTable = MainModule.GetData(text3)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = Nothing
			Me.dgvList.DataSource = data
			Dim flag11 As Boolean = Me.dgvList.Columns.Contains("GRNID")
			If flag11 Then
				Me.dgvList.Columns("GRNID").Visible = False
				Me.dgvList.Columns("VendorID").Visible = False
				Me.dgvList.Columns("GRNType").HeaderText = "GRN Type"
				Me.dgvList.Columns("GRNNo").HeaderText = "GRN No."
				Me.dgvList.Columns("GRNDt").HeaderText = "GRN Date"
				Me.dgvList.Columns("VendorName").HeaderText = "Vendor Name"
				Me.dgvList.Columns("GRNDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
				Me.dgvList.Columns("GRNType").Width = 90
				Me.dgvList.Columns("GRNNo").Width = 140
				Me.dgvList.Columns("GRNDt").Width = 120
				Me.dgvList.Columns("VendorName").Width = 315
			End If
			Dim flag12 As Boolean = data.Columns.Contains("ProductCode")
			If flag12 Then
				Me.dgvList.Columns("ProductCode").HeaderText = "Item Code"
				Me.dgvList.Columns("ProductName").HeaderText = "Item Name"
				Me.dgvList.Columns("ProductType").HeaderText = "Item Type"
				Me.dgvList.Columns("BatchNo").HeaderText = "Batch No."
				Me.dgvList.Columns("MfgDt").HeaderText = "Mfg. Date"
				Me.dgvList.Columns("ExpDt").HeaderText = "Expiry Date"
				Me.dgvList.Columns("PrimaryUOM").HeaderText = "Primary UOM"
				Me.dgvList.Columns("FinalConcentration").HeaderText = "Concentration"
				Me.dgvList.Columns("ProductCode").Width = 180
				Me.dgvList.Columns("ProductName").Width = 400
				Me.dgvList.Columns("ProductType").Width = 110
				Me.dgvList.Columns("BatchNo").Width = 100
				Me.dgvList.Columns("MfgDt").Width = 120
				Me.dgvList.Columns("ExpDt").Width = 120
				Me.dgvList.Columns("PrimaryUOM").Width = 90
				Me.dgvList.Columns("Value").Width = 90
				Me.dgvList.Columns("FinalConcentration").Width = 90
				Me.dgvList.Columns("Titre").Width = 90
				Me.dgvList.Columns("MfgDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
				Me.dgvList.Columns("ExpDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
				Me.dgvList.Columns("Value").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("FinalConcentration").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("Titre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x0400019A RID: 410
		Private pnlBasicDefaultHeight As Integer

		' Token: 0x0400019B RID: 411
		Private pnlBasicSetHeight As Integer

		' Token: 0x0400019C RID: 412
		Private pnlAdvDefaultHeight As Integer

		' Token: 0x0400019D RID: 413
		Private pnlAdvSetHeight As Integer
	End Class
End Namespace
