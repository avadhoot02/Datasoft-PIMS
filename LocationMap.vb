Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports WeifenLuo.WinFormsUI.Docking

Namespace Datasoft_PIMS
	' Token: 0x0200001D RID: 29
	<DesignerGenerated()>
	Public Partial Class LocationMap
		Inherits DockContent

		' Token: 0x06000494 RID: 1172 RVA: 0x0002A874 File Offset: 0x00028A74
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			AddHandler MyBase.Shown, AddressOf Me.Me_Shown
			Me.InitializeComponent()
		End Sub

		' Token: 0x170001B9 RID: 441
		' (get) Token: 0x06000497 RID: 1175 RVA: 0x0002C762 File Offset: 0x0002A962
		' (set) Token: 0x06000498 RID: 1176 RVA: 0x0002C76C File Offset: 0x0002A96C
		Friend Overridable Property theme_tc As TabControl

		' Token: 0x170001BA RID: 442
		' (get) Token: 0x06000499 RID: 1177 RVA: 0x0002C775 File Offset: 0x0002A975
		' (set) Token: 0x0600049A RID: 1178 RVA: 0x0002C77F File Offset: 0x0002A97F
		Friend Overridable Property tpDetails As TabPage

		' Token: 0x170001BB RID: 443
		' (get) Token: 0x0600049B RID: 1179 RVA: 0x0002C788 File Offset: 0x0002A988
		' (set) Token: 0x0600049C RID: 1180 RVA: 0x0002C792 File Offset: 0x0002A992
		Friend Overridable Property tab_lblDetails As Label

		' Token: 0x170001BC RID: 444
		' (get) Token: 0x0600049D RID: 1181 RVA: 0x0002C79B File Offset: 0x0002A99B
		' (set) Token: 0x0600049E RID: 1182 RVA: 0x0002C7A5 File Offset: 0x0002A9A5
		Friend Overridable Property tpList As TabPage

		' Token: 0x170001BD RID: 445
		' (get) Token: 0x0600049F RID: 1183 RVA: 0x0002C7AE File Offset: 0x0002A9AE
		' (set) Token: 0x060004A0 RID: 1184 RVA: 0x0002C7B8 File Offset: 0x0002A9B8
		Friend Overridable Property tab_lblList As Label

		' Token: 0x170001BE RID: 446
		' (get) Token: 0x060004A1 RID: 1185 RVA: 0x0002C7C1 File Offset: 0x0002A9C1
		' (set) Token: 0x060004A2 RID: 1186 RVA: 0x0002C7CB File Offset: 0x0002A9CB
		Friend Overridable Property txtNo As TextBox

		' Token: 0x170001BF RID: 447
		' (get) Token: 0x060004A3 RID: 1187 RVA: 0x0002C7D4 File Offset: 0x0002A9D4
		' (set) Token: 0x060004A4 RID: 1188 RVA: 0x0002C7DE File Offset: 0x0002A9DE
		Friend Overridable Property Label2 As Label

		' Token: 0x170001C0 RID: 448
		' (get) Token: 0x060004A5 RID: 1189 RVA: 0x0002C7E7 File Offset: 0x0002A9E7
		' (set) Token: 0x060004A6 RID: 1190 RVA: 0x0002C7F1 File Offset: 0x0002A9F1
		Friend Overridable Property GbBasic As GroupBox

		' Token: 0x170001C1 RID: 449
		' (get) Token: 0x060004A7 RID: 1191 RVA: 0x0002C7FA File Offset: 0x0002A9FA
		' (set) Token: 0x060004A8 RID: 1192 RVA: 0x0002C804 File Offset: 0x0002AA04
		Friend Overridable Property Label3 As Label

		' Token: 0x170001C2 RID: 450
		' (get) Token: 0x060004A9 RID: 1193 RVA: 0x0002C80D File Offset: 0x0002AA0D
		' (set) Token: 0x060004AA RID: 1194 RVA: 0x0002C817 File Offset: 0x0002AA17
		Friend Overridable Property Label5 As Label

		' Token: 0x170001C3 RID: 451
		' (get) Token: 0x060004AB RID: 1195 RVA: 0x0002C820 File Offset: 0x0002AA20
		' (set) Token: 0x060004AC RID: 1196 RVA: 0x0002C82A File Offset: 0x0002AA2A
		Friend Overridable Property txtSName As TextBox

		' Token: 0x170001C4 RID: 452
		' (get) Token: 0x060004AD RID: 1197 RVA: 0x0002C833 File Offset: 0x0002AA33
		' (set) Token: 0x060004AE RID: 1198 RVA: 0x0002C83D File Offset: 0x0002AA3D
		Friend Overridable Property txtSCode As TextBox

		' Token: 0x170001C5 RID: 453
		' (get) Token: 0x060004AF RID: 1199 RVA: 0x0002C846 File Offset: 0x0002AA46
		' (set) Token: 0x060004B0 RID: 1200 RVA: 0x0002C850 File Offset: 0x0002AA50
		Friend Overridable Property chkSelect As CheckBox
			<CompilerGenerated()>
			Get
				Return Me._chkSelect
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim eventHandler As EventHandler = AddressOf Me.chkSelect_CheckedChanged
				Dim checkBox As CheckBox = Me._chkSelect
				If checkBox IsNot Nothing Then
					RemoveHandler checkBox.CheckedChanged, eventHandler
				End If
				Me._chkSelect = value
				checkBox = Me._chkSelect
				If checkBox IsNot Nothing Then
					AddHandler checkBox.CheckedChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001C6 RID: 454
		' (get) Token: 0x060004B1 RID: 1201 RVA: 0x0002C893 File Offset: 0x0002AA93
		' (set) Token: 0x060004B2 RID: 1202 RVA: 0x0002C89D File Offset: 0x0002AA9D
		Friend Overridable Property grpListButton As GroupBox

		' Token: 0x170001C7 RID: 455
		' (get) Token: 0x060004B3 RID: 1203 RVA: 0x0002C8A6 File Offset: 0x0002AAA6
		' (set) Token: 0x060004B4 RID: 1204 RVA: 0x0002C8B0 File Offset: 0x0002AAB0
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x170001C8 RID: 456
		' (get) Token: 0x060004B5 RID: 1205 RVA: 0x0002C8B9 File Offset: 0x0002AAB9
		' (set) Token: 0x060004B6 RID: 1206 RVA: 0x0002C8C4 File Offset: 0x0002AAC4
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

		' Token: 0x170001C9 RID: 457
		' (get) Token: 0x060004B7 RID: 1207 RVA: 0x0002C907 File Offset: 0x0002AB07
		' (set) Token: 0x060004B8 RID: 1208 RVA: 0x0002C914 File Offset: 0x0002AB14
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

		' Token: 0x170001CA RID: 458
		' (get) Token: 0x060004B9 RID: 1209 RVA: 0x0002C957 File Offset: 0x0002AB57
		' (set) Token: 0x060004BA RID: 1210 RVA: 0x0002C964 File Offset: 0x0002AB64
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

		' Token: 0x170001CB RID: 459
		' (get) Token: 0x060004BB RID: 1211 RVA: 0x0002C9A7 File Offset: 0x0002ABA7
		' (set) Token: 0x060004BC RID: 1212 RVA: 0x0002C9B4 File Offset: 0x0002ABB4
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

		' Token: 0x170001CC RID: 460
		' (get) Token: 0x060004BD RID: 1213 RVA: 0x0002C9F7 File Offset: 0x0002ABF7
		' (set) Token: 0x060004BE RID: 1214 RVA: 0x0002CA01 File Offset: 0x0002AC01
		Friend Overridable Property lblRows As Label

		' Token: 0x170001CD RID: 461
		' (get) Token: 0x060004BF RID: 1215 RVA: 0x0002CA0A File Offset: 0x0002AC0A
		' (set) Token: 0x060004C0 RID: 1216 RVA: 0x0002CA14 File Offset: 0x0002AC14
		Friend Overridable Property Panel1 As Panel

		' Token: 0x170001CE RID: 462
		' (get) Token: 0x060004C1 RID: 1217 RVA: 0x0002CA1D File Offset: 0x0002AC1D
		' (set) Token: 0x060004C2 RID: 1218 RVA: 0x0002CA27 File Offset: 0x0002AC27
		Friend Overridable Property dgvGen As DataGridView

		' Token: 0x170001CF RID: 463
		' (get) Token: 0x060004C3 RID: 1219 RVA: 0x0002CA30 File Offset: 0x0002AC30
		' (set) Token: 0x060004C4 RID: 1220 RVA: 0x0002CA3C File Offset: 0x0002AC3C
		Friend Overridable Property btnPrintGen As Button
			<CompilerGenerated()>
			Get
				Return Me._btnPrintGen
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnPrintGen_Click
				Dim button As Button = Me._btnPrintGen
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnPrintGen = value
				button = Me._btnPrintGen
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001D0 RID: 464
		' (get) Token: 0x060004C5 RID: 1221 RVA: 0x0002CA7F File Offset: 0x0002AC7F
		' (set) Token: 0x060004C6 RID: 1222 RVA: 0x0002CA8C File Offset: 0x0002AC8C
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

		' Token: 0x170001D1 RID: 465
		' (get) Token: 0x060004C7 RID: 1223 RVA: 0x0002CACF File Offset: 0x0002ACCF
		' (set) Token: 0x060004C8 RID: 1224 RVA: 0x0002CADC File Offset: 0x0002ACDC
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

		' Token: 0x170001D2 RID: 466
		' (get) Token: 0x060004C9 RID: 1225 RVA: 0x0002CB1F File Offset: 0x0002AD1F
		' (set) Token: 0x060004CA RID: 1226 RVA: 0x0002CB2C File Offset: 0x0002AD2C
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

		' Token: 0x170001D3 RID: 467
		' (get) Token: 0x060004CB RID: 1227 RVA: 0x0002CB6F File Offset: 0x0002AD6F
		' (set) Token: 0x060004CC RID: 1228 RVA: 0x0002CB7C File Offset: 0x0002AD7C
		Friend Overridable Property sml_btnGen As Button
			<CompilerGenerated()>
			Get
				Return Me._sml_btnGen
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.sml_btnGen_Click
				Dim button As Button = Me._sml_btnGen
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._sml_btnGen = value
				button = Me._sml_btnGen
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001D4 RID: 468
		' (get) Token: 0x060004CD RID: 1229 RVA: 0x0002CBBF File Offset: 0x0002ADBF
		' (set) Token: 0x060004CE RID: 1230 RVA: 0x0002CBC9 File Offset: 0x0002ADC9
		Friend Overridable Property lblRowsG As Label

		' Token: 0x170001D5 RID: 469
		' (get) Token: 0x060004CF RID: 1231 RVA: 0x0002CBD2 File Offset: 0x0002ADD2
		' (set) Token: 0x060004D0 RID: 1232 RVA: 0x0002CBDC File Offset: 0x0002ADDC
		Friend Overridable Property LocSrNo As DataGridViewTextBoxColumn

		' Token: 0x170001D6 RID: 470
		' (get) Token: 0x060004D1 RID: 1233 RVA: 0x0002CBE5 File Offset: 0x0002ADE5
		' (set) Token: 0x060004D2 RID: 1234 RVA: 0x0002CBEF File Offset: 0x0002ADEF
		Friend Overridable Property LocCode As DataGridViewTextBoxColumn

		' Token: 0x170001D7 RID: 471
		' (get) Token: 0x060004D3 RID: 1235 RVA: 0x0002CBF8 File Offset: 0x0002ADF8
		' (set) Token: 0x060004D4 RID: 1236 RVA: 0x0002CC02 File Offset: 0x0002AE02
		Friend Overridable Property LocName As DataGridViewTextBoxColumn

		' Token: 0x170001D8 RID: 472
		' (get) Token: 0x060004D5 RID: 1237 RVA: 0x0002CC0B File Offset: 0x0002AE0B
		' (set) Token: 0x060004D6 RID: 1238 RVA: 0x0002CC15 File Offset: 0x0002AE15
		Friend Overridable Property LocDesc As DataGridViewTextBoxColumn

		' Token: 0x170001D9 RID: 473
		' (get) Token: 0x060004D7 RID: 1239 RVA: 0x0002CC1E File Offset: 0x0002AE1E
		' (set) Token: 0x060004D8 RID: 1240 RVA: 0x0002CC28 File Offset: 0x0002AE28
		Friend Overridable Property CreatedBy As DataGridViewTextBoxColumn

		' Token: 0x170001DA RID: 474
		' (get) Token: 0x060004D9 RID: 1241 RVA: 0x0002CC31 File Offset: 0x0002AE31
		' (set) Token: 0x060004DA RID: 1242 RVA: 0x0002CC3C File Offset: 0x0002AE3C
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

		' Token: 0x170001DB RID: 475
		' (get) Token: 0x060004DB RID: 1243 RVA: 0x0002CC7F File Offset: 0x0002AE7F
		' (set) Token: 0x060004DC RID: 1244 RVA: 0x0002CC89 File Offset: 0x0002AE89
		Friend Overridable Property chk As DataGridViewCheckBoxColumn

		' Token: 0x170001DC RID: 476
		' (get) Token: 0x060004DD RID: 1245 RVA: 0x0002CC92 File Offset: 0x0002AE92
		' (set) Token: 0x060004DE RID: 1246 RVA: 0x0002CC9C File Offset: 0x0002AE9C
		Friend Overridable Property LocationID As DataGridViewTextBoxColumn

		' Token: 0x170001DD RID: 477
		' (get) Token: 0x060004DF RID: 1247 RVA: 0x0002CCA5 File Offset: 0x0002AEA5
		' (set) Token: 0x060004E0 RID: 1248 RVA: 0x0002CCAF File Offset: 0x0002AEAF
		Friend Overridable Property LocationCode As DataGridViewTextBoxColumn

		' Token: 0x170001DE RID: 478
		' (get) Token: 0x060004E1 RID: 1249 RVA: 0x0002CCB8 File Offset: 0x0002AEB8
		' (set) Token: 0x060004E2 RID: 1250 RVA: 0x0002CCC2 File Offset: 0x0002AEC2
		Friend Overridable Property LocationName As DataGridViewTextBoxColumn

		' Token: 0x170001DF RID: 479
		' (get) Token: 0x060004E3 RID: 1251 RVA: 0x0002CCCB File Offset: 0x0002AECB
		' (set) Token: 0x060004E4 RID: 1252 RVA: 0x0002CCD5 File Offset: 0x0002AED5
		Friend Overridable Property Desc As DataGridViewTextBoxColumn

		' Token: 0x170001E0 RID: 480
		' (get) Token: 0x060004E5 RID: 1253 RVA: 0x0002CCDE File Offset: 0x0002AEDE
		' (set) Token: 0x060004E6 RID: 1254 RVA: 0x0002CCE8 File Offset: 0x0002AEE8
		Friend Overridable Property CreationDt As DataGridViewTextBoxColumn

		' Token: 0x170001E1 RID: 481
		' (get) Token: 0x060004E7 RID: 1255 RVA: 0x0002CCF1 File Offset: 0x0002AEF1
		' (set) Token: 0x060004E8 RID: 1256 RVA: 0x0002CCFB File Offset: 0x0002AEFB
		Friend Overridable Property sCreatedBy As DataGridViewTextBoxColumn

		' Token: 0x170001E2 RID: 482
		' (get) Token: 0x060004E9 RID: 1257 RVA: 0x0002CD04 File Offset: 0x0002AF04
		' (set) Token: 0x060004EA RID: 1258 RVA: 0x0002CD0E File Offset: 0x0002AF0E
		Friend Overridable Property ModificationDt As DataGridViewTextBoxColumn

		' Token: 0x170001E3 RID: 483
		' (get) Token: 0x060004EB RID: 1259 RVA: 0x0002CD17 File Offset: 0x0002AF17
		' (set) Token: 0x060004EC RID: 1260 RVA: 0x0002CD21 File Offset: 0x0002AF21
		Friend Overridable Property ModifiedBy As DataGridViewTextBoxColumn

		' Token: 0x060004ED RID: 1261 RVA: 0x0002CD2C File Offset: 0x0002AF2C
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

		' Token: 0x060004EE RID: 1262 RVA: 0x0002CDC3 File Offset: 0x0002AFC3
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Designing.SetTheme(Me)
			Me.ClearForm()
			Me.ClearList()
			Me.dtUnq = MainModule.SetLookUpTable()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x060004EF RID: 1263 RVA: 0x0002CDFD File Offset: 0x0002AFFD
		Private Sub Me_Shown(sender As Object, e As EventArgs)
			Me.SetTabs()
		End Sub

		' Token: 0x060004F0 RID: 1264 RVA: 0x0002CE08 File Offset: 0x0002B008
		Private Sub SetTabs()
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = CInt(Math.Round(CDbl((Me.theme_tc.Width - 4)) / 2.0))
			Me.theme_tc.ItemSize = New Size(num, 30)
			Me.tab_lblDetails.Width = num
			Me.tab_lblList.Width = num + 3
			Me.tab_lblDetails.Location = New Point(0, 0)
			Me.tab_lblList.Location = New Point(num - 4, 0)
		End Sub

		' Token: 0x060004F1 RID: 1265 RVA: 0x0002CE90 File Offset: 0x0002B090
		Private Sub ClearForm()
			Me.sStatus = "LOAD"
			Me.txtNo.Text = ""
			Me.txtNo.Enabled = True
			Me.sml_btnGen.Enabled = True
			Me.btnSave.Enabled = True
			Me.btnPrintGen.Enabled = False
			Me.lblRowsG.Text = "0 - Rows"
			Me.dtGen = New DataTable() With { .Columns = { "LocSrNo", "LocCode", "LocName", "LocDesc", "CreatedBy" } }
			Me.dgvGen.DataSource = Me.dtGen
		End Sub

		' Token: 0x060004F2 RID: 1266 RVA: 0x0002CF74 File Offset: 0x0002B174
		Private Sub ClearList()
			Me.txtSCode.Text = ""
			Me.txtSName.Text = ""
			Me.chkSelect.Checked = False
			Me.lblRows.Text = "0 - Rows"
			Dim dataTable As DataTable = CType(Me.dgvList.DataSource, DataTable)
			Dim flag As Boolean = Not Information.IsNothing(dataTable)
			If flag Then
				dataTable.Rows.Clear()
			End If
			Me.dgvList.DataSource = dataTable
		End Sub

		' Token: 0x060004F3 RID: 1267 RVA: 0x0002CFFB File Offset: 0x0002B1FB
		Private Sub btnClear_Click(sender As Object, e As EventArgs)
			Me.ClearForm()
			Me.sStatus = "LOAD"
		End Sub

		' Token: 0x060004F4 RID: 1268 RVA: 0x0002D010 File Offset: 0x0002B210
		Private Sub btnClearList_Click(sender As Object, e As EventArgs)
			Me.ClearList()
		End Sub

		' Token: 0x060004F5 RID: 1269 RVA: 0x0002D01A File Offset: 0x0002B21A
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x060004F6 RID: 1270 RVA: 0x0002D024 File Offset: 0x0002B224
		Private Sub btnExport_Click(sender As Object, e As EventArgs)
			MainModule.ExportToExcel(Me.dgvList, Me.Text)
		End Sub

		' Token: 0x060004F7 RID: 1271 RVA: 0x0002D03C File Offset: 0x0002B23C
		Private Sub sml_btnGen_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Versioned.IsNumeric(Me.txtNo.Text)
			If flag Then
				Me.txtNo.Enabled = False
				Me.sml_btnGen.Enabled = False
				Me.lblRowsG.Text = Conversions.ToString(Conversion.Val(Me.txtNo.Text)) + " - Row(s)"
				Dim num As Integer = CInt(Math.Round(Conversion.Val(Me.txtNo.Text) - 1.0))
				For i As Integer = 0 To num
					Me.dtGen.Rows.Add(New Object(-1) {})
					Me.dtGen.Rows(i)("LocSrNo") = ""
					Me.dtGen.Rows(i)("LocCode") = ""
					Me.dtGen.Rows(i)("LocName") = ""
					Me.dtGen.Rows(i)("LocDesc") = ""
					Me.dtGen.Rows(i)("CreatedBy") = ""
				Next
				Me.dgvGen.DataSource = Me.dtGen
			End If
		End Sub

		' Token: 0x060004F8 RID: 1272 RVA: 0x0002D1AC File Offset: 0x0002B3AC
		Private Function ValidateForm() As Boolean
			Dim flag As Boolean = Me.dgvGen.Rows.Count = 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("No Location Generated.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.txtNo.Focus()
				flag2 = False
			Else
				Dim text As String = ""
				Dim num As Integer = Me.dtGen.Rows.Count - 1
				For i As Integer = 0 To num
					Me.dgvGen.Rows(i).Cells("LocName").Style.BackColor = Color.White
					Dim flag3 As Boolean = Operators.CompareString(Strings.Trim(Me.dtGen.Rows(i)("LocName").ToString()), "", False) = 0
					If flag3 Then
						CustomMsgBox.Show("Location Name Cannot Be Blank.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.dgvGen.Rows(i).Cells("LocName").Selected = True
						Return False
					End If
					Dim flag4 As Boolean = Me.dtGen.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("LocName = '", Me.dtGen.Rows(i)("LocName")), "'"))).Length > 1
					If flag4 Then
						CustomMsgBox.Show("Duplicate Location Name.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.dgvGen.Rows(i).Cells("LocName").Selected = True
						Return False
					End If
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Me.dtGen.Rows(i)("LocName")), "',")))
				Next
				Dim text2 As String = "SELECT LocationName FROM Location WHERE LocationName IN (" + Strings.Mid(text, 1, text.Length - 1) + ")"
				Dim data As DataTable = MainModule.GetData(text2)
				Dim num2 As Integer = Me.dtGen.Rows.Count - 1
				Dim flag6 As Boolean
				For j As Integer = 0 To num2
					Dim flag5 As Boolean = data.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("LocationName = '", Me.dtGen.Rows(j)("LocName")), "'"))).Length > 0
					If flag5 Then
						Me.dgvGen.Rows(j).Cells("LocName").Style.BackColor = Color.LightCoral
						flag6 = True
					Else
						Me.dgvGen.Rows(j).Cells("LocName").Style.BackColor = Color.White
					End If
				Next
				Dim flag7 As Boolean = flag6
				If flag7 Then
					CustomMsgBox.Show("Location Name Already In Database.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					flag2 = False
				Else
					flag2 = True
				End If
			End If
			Return flag2
		End Function

		' Token: 0x060004F9 RID: 1273 RVA: 0x0002D4CC File Offset: 0x0002B6CC
		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.Save()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnSave.Enabled = True
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x060004FA RID: 1274 RVA: 0x0002D548 File Offset: 0x0002B748
		Private Sub Save()
			Dim flag As Boolean = CustomMsgBox.Show("Save..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
			If flag Then
				Dim flag2 As Boolean = Not Me.ValidateForm()
				If Not flag2 Then
					Dim sqlConnection As SqlConnection = New SqlConnection(GlobalVariables.gsConStr)
					sqlConnection.Open()
					Dim sqlTransaction As SqlTransaction = sqlConnection.BeginTransaction(IsolationLevel.Serializable)
					Try
						Dim flag3 As Boolean = MainModule.SetDBTableLock("Location", sqlConnection, sqlTransaction) = 0
						If flag3 Then
							Interaction.MsgBox("Server Busy, Try After Sometime.", MsgBoxStyle.Critical, "Critical")
							sqlTransaction.Rollback()
							sqlConnection.Close()
						Else
							Me.btnSave.Enabled = False
							Dim serverDate As DateTime = MainModule.GetServerDate()
							Dim text As String = Conversions.ToString(Me.dtUnq.[Select]("sType='D' AND sVal='" + Strings.Format(serverDate, "dd") + "'")(0)("ID"))
							Dim text2 As String = Conversions.ToString(Me.dtUnq.[Select]("sType='M' AND sVal='" + Strings.Format(serverDate, "MMM") + "'")(0)("ID"))
							Dim text3 As String = Conversions.ToString(Me.dtUnq.[Select]("sType='Y' AND sVal='" + Strings.Format(serverDate, "yyyy") + "'")(0)("ID"))
							Dim text4 As String = " SELECT ISNULL (MAX(LocationSrNo),'0000') AS MaxSerialNo FROM Location "
							text4 = String.Concat(New String() { text4, " WHERE (CreationDt BETWEEN '", Strings.Format(serverDate, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(serverDate, "MM/dd/yyyy 23:59:59"), "') " })
							Dim data As DataTable = MainModule.GetData(text4, sqlConnection, sqlTransaction)
							Dim text5 As String = Conversions.ToString(data.Rows(0)("MaxSerialNo"))
							Dim text6 As String = ""
							Dim num As Integer = Me.dtGen.Rows.Count - 1
							For i As Integer = 0 To num
								' The following expression was wrapped in a unchecked-expression
								text5 = Strings.Format(Conversion.Val(text5) + 1.0, "0000")
								Dim text7 As String = String.Concat(New String() { "IAL", text, text2, text3, text5 })
								Me.dtGen.Rows(i)("LocSrNo") = text5
								Me.dtGen.Rows(i)("LocCode") = text7
								Me.dtGen.Rows(i)("CreatedBy") = GlobalVariables.gsUserID
								text6 = text6 + text7 + ", "
							Next
							Me.BulkInsert(Me.dtGen, sqlConnection, sqlTransaction)
							sqlTransaction.Commit()
							sqlConnection.Close()
							MainModule.TrnLog(Me.Text, "Location Created", "New Locations: " + Strings.Mid(text6, 1, text6.Length - 2), Nothing)
							CustomMsgBox.Show("Location Created.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							Me.btnPrintGen.Enabled = True
						End If
					Catch ex As Exception
						CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.btnSave.Enabled = True
						sqlTransaction.Rollback()
						sqlConnection.Close()
					End Try
				End If
			End If
		End Sub

		' Token: 0x060004FB RID: 1275 RVA: 0x0002D8F4 File Offset: 0x0002BAF4
		Private Sub BulkInsert(dt As DataTable, oCon As SqlConnection, oTrn As SqlTransaction)
			New SqlBulkCopy(oCon, SqlBulkCopyOptions.[Default], oTrn) With { .DestinationTableName = "Location", .BulkCopyTimeout = 60000, .BatchSize = 5000, .ColumnMappings = { { "LocSrNo", "LocationSrNo" }, { "LocCode", "LocationCode" }, { "LocName", "LocationName" }, { "LocDesc", "Description" }, { "CreatedBy", "CreatedBy" } } }.WriteToServer(dt)
		End Sub

		' Token: 0x060004FC RID: 1276 RVA: 0x0002D9A8 File Offset: 0x0002BBA8
		Private Sub btnPrintGen_Click(sender As Object, e As EventArgs)
			Try
				Me.PrintData("Generation")
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x060004FD RID: 1277 RVA: 0x0002DA04 File Offset: 0x0002BC04
		Private Sub btnPrint_Click(sender As Object, e As EventArgs)
			Try
				Me.PrintData("Reprint")
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x060004FE RID: 1278 RVA: 0x0002DA60 File Offset: 0x0002BC60
		Private Sub PrintData(sType As String)
			Dim text As String = AppDomain.CurrentDomain.BaseDirectory.ToString()
			Dim text2 As String = "lpt3"
			File.Delete(text + "Text.txt")
			File.Delete(text + "Batch.bat")
			Dim text3 As String = Me.PrintLocation(sType)
			Dim flag As Boolean = Operators.CompareString(text3, "", False) <> 0
			If flag Then
				Dim fileStream As FileStream = New FileStream(text + "Text.txt", FileMode.Create)
				Dim streamWriter As StreamWriter = New StreamWriter(fileStream)
				streamWriter.BaseStream.Seek(0L, SeekOrigin.Begin)
				streamWriter.WriteLine(text3)
				streamWriter.Close()
				fileStream.Close()
			End If
			text3 = "cd\" & vbCrLf
			text3 = text3 + Strings.Mid(text, 1, 2) + vbCrLf
			text3 = text3 + "cd " + text + vbCrLf
			text3 = text3 + "copy Text.txt " + text2 + vbCrLf
			text3 += "exit"
			Dim fileStream2 As FileStream = New FileStream(text + "Batch.bat", FileMode.Create, FileAccess.Write)
			Dim streamWriter2 As StreamWriter = New StreamWriter(fileStream2)
			streamWriter2.BaseStream.Seek(0L, SeekOrigin.[End])
			streamWriter2.WriteLine(text3)
			streamWriter2.Close()
			fileStream2.Close()
			Dim num As Integer = Interaction.Shell(text + "Batch.bat", AppWinStyle.MaximizedFocus, True, -1)
		End Sub

		' Token: 0x060004FF RID: 1279 RVA: 0x0002DBB4 File Offset: 0x0002BDB4
		Private Function PrintLocation(sType As String) As String
			Dim text As String = ""
			Dim text2 As String = ""
			Dim flag As Boolean = Operators.CompareString(sType, "Generation", False) = 0
			Dim text3 As String
			If flag Then
				Dim num As Integer = Me.dtGen.Rows.Count - 1
				For i As Integer = 0 To num
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Me.dtGen.Rows(i)("LocCode"), ", ")))
					text2 += Me.LocationPRN(Conversions.ToString(Me.dtGen.Rows(i)("LocCode")), Conversions.ToString(Me.dtGen.Rows(i)("LocName")))
				Next
				text3 = "Location Label Printed : Generation"
			Else
				Dim num2 As Integer = Me.dgvList.Rows.Count - 1
				For j As Integer = 0 To num2
					Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(Me.dgvList.Rows(j).Cells("chk").Value, 1, False)
					If flag2 Then
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Me.dgvList.Rows(j).Cells("LocationCode").Value, ", ")))
						text2 += Me.LocationPRN(Conversions.ToString(Me.dgvList.Rows(j).Cells("LocationCode").Value), Conversions.ToString(Me.dgvList.Rows(j).Cells("LocationName").Value))
					End If
				Next
				text3 = "Location Label Printed : Reprint"
			End If
			Dim flag3 As Boolean = Operators.CompareString(text, "", False) <> 0
			If flag3 Then
				MainModule.TrnLog(Me.Text, text3, " Location Codes : " + Strings.Mid(text, 1, text.Length - 2), Nothing)
			End If
			Return text2
		End Function

		' Token: 0x06000500 RID: 1280 RVA: 0x0002DDF8 File Offset: 0x0002BFF8
		Private Function LocationPRN(sLocationCode As String, sLocationName As String) As String
			Dim text As String = ""
			text += "<xpml><page quantity='0' pitch='25.0 mm'></xpml>^XA" & vbCrLf
			text += "^SZ2^JMA" & vbCrLf
			text += "^MCY^PMN" & vbCrLf
			text += "^PW588" & vbCrLf
			text += "~JSN" & vbCrLf
			text += "^JZY" & vbCrLf
			text += "^LH0,0" & vbCrLf
			text += "^CW3,E:REFSANB.TTF^fs" & vbCrLf
			text += "^LRN" & vbCrLf
			text += "^XZ" & vbCrLf
			text += "<xpml></page></xpml><xpml><page quantity='1' pitch='25.0 mm'></xpml>^XA" & vbCrLf
			text += "^FO33,31" & vbCrLf
			text = String.Concat(New String() { text, "^BY4^BCN,64,N,N^FD>:", Strings.Mid(sLocationCode, 1, 6), ">5", Strings.Mid(sLocationCode, 7, 4), "^FS" & vbCrLf })
			text += "^FT234,117" & vbCrLf
			text += "^CI0" & vbCrLf
			text = text + "^A0N,20,27^FD" + sLocationCode + "^FS" & vbCrLf
			text += "^FT34,169" & vbCrLf
			text += "^A3N,23,22^FDLocation^FS" & vbCrLf
			text += "^FT161,169" & vbCrLf
			text = text + "^A3N,23,22^FD" + sLocationName + "^FS" & vbCrLf
			text += "^FT148,171" & vbCrLf
			text += "^A3N,25,22^FD:^FS" & vbCrLf
			text += "^PQ1,0,1,Y" & vbCrLf
			text += "^XZ" & vbCrLf
			Return text + "<xpml></page></xpml><xpml><end/></xpml>" & vbCrLf
		End Function

		' Token: 0x06000501 RID: 1281 RVA: 0x0002DF7C File Offset: 0x0002C17C
		Private Sub chkSelect_CheckedChanged(sender As Object, e As EventArgs)
			Dim checked As Boolean = Me.chkSelect.Checked
			If checked Then
				Dim num As Integer = Me.dgvList.Rows.Count - 1
				For i As Integer = 0 To num
					Me.dgvList.Rows(i).Cells("chk").Value = 1
				Next
			Else
				Dim num2 As Integer = Me.dgvList.Rows.Count - 1
				For j As Integer = 0 To num2
					Me.dgvList.Rows(j).Cells("chk").Value = 0
				Next
			End If
		End Sub

		' Token: 0x06000502 RID: 1282 RVA: 0x0002E03C File Offset: 0x0002C23C
		Private Sub btnSearch_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SearchData()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06000503 RID: 1283 RVA: 0x0002E0A8 File Offset: 0x0002C2A8
		Private Sub SearchData()
			Dim text As String = ""
			Dim text2 As String = " SELECT 0 as chk, LocationID AS ID, LocationCode, LocationName, Description, " & vbCrLf
			text2 += " L.CreationDt, Created.UserName AS CreatedBy, " & vbCrLf
			text2 += " L.ModificationDt, Modified.UserName AS ModifiedBy" & vbCrLf
			text2 += " FROM Location L" & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Created ON L.CreatedBy = Created.UserID" & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Modified ON L.ModifiedBy = Modified.UserID" & vbCrLf
			text2 += " WHERE 1=1"
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.txtSCode.Text), "", False) <> 0
			If flag Then
				text2 = text2 + " And (LocationCode Like '%" + Strings.Trim(Me.txtSCode.Text) + "%') "
				text = text + "LocationCode LIKE " + Strings.Trim(Me.txtSCode.Text) + vbCrLf
			End If
			Dim flag2 As Boolean = Operators.CompareString(Strings.Trim(Me.txtSName.Text), "", False) <> 0
			If flag2 Then
				text2 = text2 + " AND (LocationName LIKE '%" + Strings.Trim(Me.txtSName.Text) + "%')"
				text = text + "LocationName LIKE " + Strings.Trim(Me.txtSName.Text) + vbCrLf
			End If
			text2 += " ORDER BY LocationName"
			Dim data As DataTable = MainModule.GetData(text2)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = data
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x06000504 RID: 1284 RVA: 0x0002E258 File Offset: 0x0002C458
		Private Sub dgvList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = (e.RowIndex > -1) And (e.ColumnIndex > -1)
			If flag Then
				Dim dataTable As DataTable = CType(Me.dgvList.DataSource, DataTable)
				Dim dataRow As DataRow = dataTable.[Select]("ID = '" + Me.dgvList.Rows(e.RowIndex).Cells("LocationID").Value.ToString() + "'")(0)
				Dim locationDtls As LocationDtls = New LocationDtls(dataRow)
				Dim flag2 As Boolean = locationDtls.ShowDialog() = DialogResult.OK
				If flag2 Then
					dataRow("LocationName") = RuntimeHelpers.GetObjectValue(locationDtls.drData("LocationName"))
					dataRow("Description") = RuntimeHelpers.GetObjectValue(locationDtls.drData("Description"))
					dataTable.AcceptChanges()
					Me.dgvList.DataSource = dataTable
				End If
			End If
		End Sub

		' Token: 0x0400020C RID: 524
		Private sStatus As String

		' Token: 0x0400020D RID: 525
		Private dtGen As DataTable

		' Token: 0x0400020E RID: 526
		Private dtUnq As DataTable
	End Class
End Namespace
