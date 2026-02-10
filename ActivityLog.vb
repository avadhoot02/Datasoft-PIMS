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
	' Token: 0x02000024 RID: 36
	<DesignerGenerated()>
	Public Partial Class ActivityLog
		Inherits DockContent

		' Token: 0x17000377 RID: 887
		' (get) Token: 0x0600091F RID: 2335 RVA: 0x0004FD98 File Offset: 0x0004DF98
		' (set) Token: 0x06000920 RID: 2336 RVA: 0x0004FDA2 File Offset: 0x0004DFA2
		Friend Overridable Property GbBasic As GroupBox

		' Token: 0x17000378 RID: 888
		' (get) Token: 0x06000921 RID: 2337 RVA: 0x0004FDAB File Offset: 0x0004DFAB
		' (set) Token: 0x06000922 RID: 2338 RVA: 0x0004FDB5 File Offset: 0x0004DFB5
		Friend Overridable Property Label2 As Label

		' Token: 0x17000379 RID: 889
		' (get) Token: 0x06000923 RID: 2339 RVA: 0x0004FDBE File Offset: 0x0004DFBE
		' (set) Token: 0x06000924 RID: 2340 RVA: 0x0004FDC8 File Offset: 0x0004DFC8
		Friend Overridable Property Label1 As Label

		' Token: 0x1700037A RID: 890
		' (get) Token: 0x06000925 RID: 2341 RVA: 0x0004FDD1 File Offset: 0x0004DFD1
		' (set) Token: 0x06000926 RID: 2342 RVA: 0x0004FDDC File Offset: 0x0004DFDC
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

		' Token: 0x1700037B RID: 891
		' (get) Token: 0x06000927 RID: 2343 RVA: 0x0004FE1F File Offset: 0x0004E01F
		' (set) Token: 0x06000928 RID: 2344 RVA: 0x0004FE29 File Offset: 0x0004E029
		Friend Overridable Property dtpTo As DateTimePicker

		' Token: 0x1700037C RID: 892
		' (get) Token: 0x06000929 RID: 2345 RVA: 0x0004FE32 File Offset: 0x0004E032
		' (set) Token: 0x0600092A RID: 2346 RVA: 0x0004FE3C File Offset: 0x0004E03C
		Friend Overridable Property Label16 As Label

		' Token: 0x1700037D RID: 893
		' (get) Token: 0x0600092B RID: 2347 RVA: 0x0004FE45 File Offset: 0x0004E045
		' (set) Token: 0x0600092C RID: 2348 RVA: 0x0004FE4F File Offset: 0x0004E04F
		Friend Overridable Property dtpFrom As DateTimePicker

		' Token: 0x1700037E RID: 894
		' (get) Token: 0x0600092D RID: 2349 RVA: 0x0004FE58 File Offset: 0x0004E058
		' (set) Token: 0x0600092E RID: 2350 RVA: 0x0004FE62 File Offset: 0x0004E062
		Friend Overridable Property txtTrnBy As TextBox

		' Token: 0x1700037F RID: 895
		' (get) Token: 0x0600092F RID: 2351 RVA: 0x0004FE6B File Offset: 0x0004E06B
		' (set) Token: 0x06000930 RID: 2352 RVA: 0x0004FE75 File Offset: 0x0004E075
		Friend Overridable Property GbAdvanced As GroupBox

		' Token: 0x17000380 RID: 896
		' (get) Token: 0x06000931 RID: 2353 RVA: 0x0004FE7E File Offset: 0x0004E07E
		' (set) Token: 0x06000932 RID: 2354 RVA: 0x0004FE88 File Offset: 0x0004E088
		Friend Overridable Property cmbTrnType As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbTrnType
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbTrnType_Validated
				Dim comboBox As ComboBox = Me._cmbTrnType
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.Validated, eventHandler
				End If
				Me._cmbTrnType = value
				comboBox = Me._cmbTrnType
				If comboBox IsNot Nothing Then
					AddHandler comboBox.Validated, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000381 RID: 897
		' (get) Token: 0x06000933 RID: 2355 RVA: 0x0004FECB File Offset: 0x0004E0CB
		' (set) Token: 0x06000934 RID: 2356 RVA: 0x0004FED5 File Offset: 0x0004E0D5
		Friend Overridable Property Label3 As Label

		' Token: 0x17000382 RID: 898
		' (get) Token: 0x06000935 RID: 2357 RVA: 0x0004FEDE File Offset: 0x0004E0DE
		' (set) Token: 0x06000936 RID: 2358 RVA: 0x0004FEE8 File Offset: 0x0004E0E8
		Friend Overridable Property Label4 As Label

		' Token: 0x17000383 RID: 899
		' (get) Token: 0x06000937 RID: 2359 RVA: 0x0004FEF1 File Offset: 0x0004E0F1
		' (set) Token: 0x06000938 RID: 2360 RVA: 0x0004FEFC File Offset: 0x0004E0FC
		Friend Overridable Property cmbTrnOn As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbTrnOn
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbTrnOn_Validated
				Dim eventHandler2 As EventHandler = AddressOf Me.cmbTrnOn_TextChanged
				Dim comboBox As ComboBox = Me._cmbTrnOn
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.Validated, eventHandler
					RemoveHandler comboBox.TextChanged, eventHandler2
				End If
				Me._cmbTrnOn = value
				comboBox = Me._cmbTrnOn
				If comboBox IsNot Nothing Then
					AddHandler comboBox.Validated, eventHandler
					AddHandler comboBox.TextChanged, eventHandler2
				End If
			End Set
		End Property

		' Token: 0x17000384 RID: 900
		' (get) Token: 0x06000939 RID: 2361 RVA: 0x0004FF5A File Offset: 0x0004E15A
		' (set) Token: 0x0600093A RID: 2362 RVA: 0x0004FF64 File Offset: 0x0004E164
		Friend Overridable Property cmbVerify As ComboBox

		' Token: 0x17000385 RID: 901
		' (get) Token: 0x0600093B RID: 2363 RVA: 0x0004FF6D File Offset: 0x0004E16D
		' (set) Token: 0x0600093C RID: 2364 RVA: 0x0004FF77 File Offset: 0x0004E177
		Friend Overridable Property Label6 As Label

		' Token: 0x17000386 RID: 902
		' (get) Token: 0x0600093D RID: 2365 RVA: 0x0004FF80 File Offset: 0x0004E180
		' (set) Token: 0x0600093E RID: 2366 RVA: 0x0004FF8C File Offset: 0x0004E18C
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

		' Token: 0x17000387 RID: 903
		' (get) Token: 0x0600093F RID: 2367 RVA: 0x0004FFCF File Offset: 0x0004E1CF
		' (set) Token: 0x06000940 RID: 2368 RVA: 0x0004FFD9 File Offset: 0x0004E1D9
		Friend Overridable Property grpListButton As GroupBox

		' Token: 0x17000388 RID: 904
		' (get) Token: 0x06000941 RID: 2369 RVA: 0x0004FFE2 File Offset: 0x0004E1E2
		' (set) Token: 0x06000942 RID: 2370 RVA: 0x0004FFEC File Offset: 0x0004E1EC
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x17000389 RID: 905
		' (get) Token: 0x06000943 RID: 2371 RVA: 0x0004FFF5 File Offset: 0x0004E1F5
		' (set) Token: 0x06000944 RID: 2372 RVA: 0x00050000 File Offset: 0x0004E200
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

		' Token: 0x1700038A RID: 906
		' (get) Token: 0x06000945 RID: 2373 RVA: 0x00050043 File Offset: 0x0004E243
		' (set) Token: 0x06000946 RID: 2374 RVA: 0x00050050 File Offset: 0x0004E250
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

		' Token: 0x1700038B RID: 907
		' (get) Token: 0x06000947 RID: 2375 RVA: 0x00050093 File Offset: 0x0004E293
		' (set) Token: 0x06000948 RID: 2376 RVA: 0x000500A0 File Offset: 0x0004E2A0
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

		' Token: 0x1700038C RID: 908
		' (get) Token: 0x06000949 RID: 2377 RVA: 0x000500E3 File Offset: 0x0004E2E3
		' (set) Token: 0x0600094A RID: 2378 RVA: 0x000500ED File Offset: 0x0004E2ED
		Friend Overridable Property lblRows As Label

		' Token: 0x1700038D RID: 909
		' (get) Token: 0x0600094B RID: 2379 RVA: 0x000500F6 File Offset: 0x0004E2F6
		' (set) Token: 0x0600094C RID: 2380 RVA: 0x00050100 File Offset: 0x0004E300
		Friend Overridable Property dgvList As DataGridView

		' Token: 0x0600094D RID: 2381 RVA: 0x0005010C File Offset: 0x0004E30C
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.ActivityLog_FormClosing
			AddHandler MyBase.Load, AddressOf Me.ActivityLog_Load
			Me.InitializeComponent()
			Designing.SetTheme(Me)
			Me.Text = "Activity Log Report"
			MyBase.TabText = "Activity Log Report"
			Me.pnlBasicDefaultHeight = Me.GbBasic.Height
			Me.pnlBasicSetHeight = 23
			Me.pnlAdvDefaultHeight = 23
			Me.pnlAdvSetHeight = Me.GbAdvanced.Height
		End Sub

		' Token: 0x0600094E RID: 2382 RVA: 0x000501A0 File Offset: 0x0004E3A0
		Private Sub SetSearchPanel()
			Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
			Me.GbBasic.Height = Me.pnlBasicDefaultHeight
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
		End Sub

		' Token: 0x0600094F RID: 2383 RVA: 0x000501F4 File Offset: 0x0004E3F4
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

		' Token: 0x06000950 RID: 2384 RVA: 0x00050264 File Offset: 0x0004E464
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

		' Token: 0x06000951 RID: 2385 RVA: 0x000502D4 File Offset: 0x0004E4D4
		Private Sub ActivityLog_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x06000952 RID: 2386 RVA: 0x00050309 File Offset: 0x0004E509
		Private Sub ActivityLog_Load(sender As Object, e As EventArgs)
			Me.SetSearchPanel()
			Me.FillCombo()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x06000953 RID: 2387 RVA: 0x00050334 File Offset: 0x0004E534
		Private Sub FillCombo()
			Dim text As String = "SELECT DISTINCT TrnOn FROM TrnLog ORDER BY TrnOn"
			Dim data As DataTable = MainModule.GetData(text)
			Me.cmbTrnOn.ValueMember = "TrnOn"
			Me.cmbTrnOn.DisplayMember = "TrnOn"
			Me.cmbTrnOn.DataSource = data
			Me.cmbTrnOn.SelectedIndex = -1
		End Sub

		' Token: 0x06000954 RID: 2388 RVA: 0x0005038C File Offset: 0x0004E58C
		Private Sub FillTrnType()
			Dim text As String = "SELECT DISTINCT TrnType FROM TrnLog WHERE TrnOn = '" + Me.cmbTrnOn.Text + "' ORDER BY TrnType"
			Dim data As DataTable = MainModule.GetData(text)
			Me.cmbTrnType.ValueMember = "TrnType"
			Me.cmbTrnType.DisplayMember = "TrnType"
			Me.cmbTrnType.DataSource = data
			Me.cmbTrnType.SelectedIndex = -1
		End Sub

		' Token: 0x06000955 RID: 2389 RVA: 0x000503F8 File Offset: 0x0004E5F8
		Private Sub cmbTrnOn_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbTrnOn.SelectedIndex > -1
			If flag Then
				Me.FillTrnType()
			Else
				Me.cmbTrnOn.Text = ""
				Me.cmbTrnType.DataSource = Nothing
			End If
		End Sub

		' Token: 0x06000956 RID: 2390 RVA: 0x00050444 File Offset: 0x0004E644
		Private Sub cmbTrnType_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbTrnType.SelectedIndex = -1
			If flag Then
				Me.cmbTrnType.Text = ""
			End If
		End Sub

		' Token: 0x06000957 RID: 2391 RVA: 0x00050477 File Offset: 0x0004E677
		Private Sub cmbTrnOn_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000958 RID: 2392 RVA: 0x0005047C File Offset: 0x0004E67C
		Private Sub ClearList()
			Me.txtTrnBy.Text = ""
			Me.cmbTrnOn.SelectedIndex = 0
			Me.cmbTrnType.SelectedIndex = 0
			Me.cmbVerify.SelectedIndex = 0
			Me.dtpFrom.Value = DateAndTime.Now
			Me.dtpTo.Value = DateAndTime.Now
			Me.dtpFrom.Checked = False
			Me.dtpTo.Checked = False
			Me.lblRows.Text = "0 - Rows"
			Me.dgvList.DataSource = Nothing
		End Sub

		' Token: 0x06000959 RID: 2393 RVA: 0x0005051C File Offset: 0x0004E71C
		Private Sub btnClearList_Click(sender As Object, e As EventArgs)
			Me.ClearList()
		End Sub

		' Token: 0x0600095A RID: 2394 RVA: 0x00050526 File Offset: 0x0004E726
		Private Sub btnExport_Click(sender As Object, e As EventArgs)
			MainModule.ExportToExcel(Me.dgvList, Me.Text)
		End Sub

		' Token: 0x0600095B RID: 2395 RVA: 0x0005053C File Offset: 0x0004E73C
		Private Sub btnSearch_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SearchData("")
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x0600095C RID: 2396 RVA: 0x000505B0 File Offset: 0x0004E7B0
		Private Sub SearchData(sID As String)
			Dim text As String = ""
			Dim text2 As String = " SELECT T.TrnID, T.TrnDate, T.TrnOn, T.TrnType, T.CompanyID, T.PlantID, " & vbCrLf
			text2 += " T.TrnBy, TrnBy.UserName, T.DataCheckSum, T.TrnDtls, T.LogDtls " & vbCrLf
			text2 += " FROM TrnLog AS T " & vbCrLf
			text2 += " INNER JOIN Plant AS P ON T.PlantID = P.PlantID " & vbCrLf
			text2 += " INNER JOIN [User] AS TrnBy ON T.TrnBy = TrnBy.UserID " & vbCrLf
			text2 += " WHERE 1=1" & vbCrLf
			Dim flag As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
			If flag Then
				text2 = String.Concat(New String() { text2, " AND T.TrnDate BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
				text = text + ("TrnDate BETWEEN  " + Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00") + " AND " + Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59")) + vbCrLf
			Else
				Dim checked As Boolean = Me.dtpFrom.Checked
				If checked Then
					text2 = String.Concat(New String() { text2, " AND T.TrnDate BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59"), "'" })
					text = text + ("TrnDate BETWEEN  " + Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00") + " AND " + Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59")) + vbCrLf
				End If
				Dim checked2 As Boolean = Me.dtpTo.Checked
				If checked2 Then
					text2 = String.Concat(New String() { text2, " AND T.TrnDate BETWEEN '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
					text = text + ("TrnDate BETWEEN  " + Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00") + " AND " + Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59")) + vbCrLf
				End If
			End If
			Dim flag2 As Boolean = Operators.CompareString(Me.cmbTrnOn.Text, "", False) <> 0
			If flag2 Then
				text2 = text2 + " AND T.TrnOn = '" + Me.cmbTrnOn.Text + "'"
				text = text + "TrnOn = " + Me.cmbTrnOn.Text + "," & vbTab
			End If
			Dim flag3 As Boolean = Operators.CompareString(Me.cmbTrnType.Text, "", False) <> 0
			If flag3 Then
				text2 = text2 + " AND T.TrnType = '" + Me.cmbTrnType.Text + "'"
				text = text + "TrnType = " + Me.cmbTrnType.Text + "," & vbTab
			End If
			Dim flag4 As Boolean = Operators.CompareString(Strings.Trim(Me.txtTrnBy.Text), "", False) <> 0
			If flag4 Then
				text2 = text2 + " AND T.LoginID LIKE '%" + Strings.Trim(Me.txtTrnBy.Text) + "%'"
				text = text + "LoginID LIKE = " + Me.txtTrnBy.Text.ToString() + "," & vbTab
			End If
			text2 += " ORDER BY T.TrnDate"
			Dim data As DataTable = MainModule.GetData(text2)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Row(s)"
			Me.dgvList.DataSource = data
			Me.dgvList.Columns("TrnID").Visible = False
			Me.dgvList.Columns("CompanyID").Visible = False
			Me.dgvList.Columns("PlantID").Visible = False
			Me.dgvList.Columns("TrnBy").Visible = False
			Me.dgvList.Columns("DataCheckSum").Visible = False
			Me.dgvList.Columns("TrnDate").DefaultCellStyle.Format = "dd MMM yyyy hh:mm:ss tt"
			Me.dgvList.Columns("TrnDate").HeaderText = "Action Date"
			Me.dgvList.Columns("TrnOn").HeaderText = "Action On"
			Me.dgvList.Columns("TrnType").HeaderText = "Action Type"
			Me.dgvList.Columns("UserName").HeaderText = "Action By"
			Me.dgvList.Columns("TrnDtls").HeaderText = "Details"
			Me.dgvList.Columns("LogDtls").HeaderText = "Log Details"
			Me.dgvList.Columns("TrnDate").Width = 170
			Me.dgvList.Columns("TrnOn").Width = 150
			Me.dgvList.Columns("TrnType").Width = 170
			Me.dgvList.Columns("UserName").Width = 250
			Me.dgvList.Columns("TrnDtls").Width = 250
			Me.dgvList.Columns("LogDtls").Width = 250
			Dim flag5 As Boolean = Operators.CompareString(Me.cmbVerify.Text, "Yes", False) = 0
			If flag5 Then
				Dim num As Integer = Me.dgvList.Rows.Count - 1
				For i As Integer = 0 To num
					Dim flag6 As Boolean = True
					Try
						Dim oDB As Object = GlobalVariables.oDB
						Dim type As Type = Nothing
						Dim text3 As String = "Decrypt"
						Dim array As Object() = New Object(1) {}
						Dim num2 As Integer = 0
						Dim dataRow As DataRow = data.Rows(i)
						Dim dataRow2 As DataRow = dataRow
						array(num2) = dataRow("DataCheckSum")
						array(1) = GlobalVariables.gsPwd
						Dim array2 As Object() = array
						Dim array3 As String() = Nothing
						Dim array4 As Type() = Nothing
						Dim array5 As Boolean() = New Boolean() { True, True }
						Dim array6 As Boolean() = array5
						Dim obj As Object = NewLateBinding.LateGet(oDB, type, text3, array, array3, array4, array5)
						If array6(0) Then
							dataRow2("DataCheckSum") = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2(0)))
						End If
						If array6(1) Then
							GlobalVariables.gsPwd = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(1)), GetType(String)))
						End If
						Dim text4 As String = Conversions.ToString(obj)
						Dim array7 As String() = Strings.Split(text4, vbTab, -1, CompareMethod.Binary)
						Dim flag7 As Boolean = array7.Length = 6
						If flag7 Then
							Dim flag8 As Boolean = Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareString(Strings.Format(RuntimeHelpers.GetObjectValue(Me.dgvList.Rows(i).Cells("TrnDate").Value), "MM-dd-yyyy HH:mm:ss"), Strings.Format(Conversions.ToDate(array7(0)), "MM-dd-yyyy HH:mm:ss"), False) = 0, Operators.CompareObjectEqual(Me.dgvList.Rows(i).Cells("TrnOn").Value, array7(1), False)), Operators.CompareObjectEqual(Me.dgvList.Rows(i).Cells("TrnType").Value, array7(2), False)), Operators.CompareObjectEqual(Me.dgvList.Rows(i).Cells("CompanyID").Value, array7(3), False)), Operators.CompareObjectEqual(Me.dgvList.Rows(i).Cells("PlantID").Value, array7(4), False)), Operators.CompareObjectEqual(Me.dgvList.Rows(i).Cells("TrnBy").Value, array7(5), False)))
							If Not flag8 Then
								flag6 = False
							End If
						Else
							flag6 = False
						End If
					Catch ex As Exception
						flag6 = False
					End Try
					Dim flag9 As Boolean = Not flag6
					If flag9 Then
						Me.dgvList.Rows(i).DefaultCellStyle.BackColor = Color.Maroon
						Me.dgvList.Rows(i).DefaultCellStyle.ForeColor = Color.White
					Else
						Me.dgvList.Rows(i).DefaultCellStyle.BackColor = Color.White
						Me.dgvList.Rows(i).DefaultCellStyle.ForeColor = Color.Black
					End If
				Next
			End If
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x040003E2 RID: 994
		Private pnlBasicDefaultHeight As Integer

		' Token: 0x040003E3 RID: 995
		Private pnlBasicSetHeight As Integer

		' Token: 0x040003E4 RID: 996
		Private pnlAdvDefaultHeight As Integer

		' Token: 0x040003E5 RID: 997
		Private pnlAdvSetHeight As Integer
	End Class
End Namespace
