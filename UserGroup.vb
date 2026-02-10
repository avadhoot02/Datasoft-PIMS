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
	' Token: 0x0200001F RID: 31
	<DesignerGenerated()>
	Public Partial Class UserGroup
		Inherits DockContent

		' Token: 0x170001F7 RID: 503
		' (get) Token: 0x0600053A RID: 1338 RVA: 0x00031E34 File Offset: 0x00030034
		' (set) Token: 0x0600053B RID: 1339 RVA: 0x00031E3E File Offset: 0x0003003E
		Friend Overridable Property theme_tc As TabControl

		' Token: 0x170001F8 RID: 504
		' (get) Token: 0x0600053C RID: 1340 RVA: 0x00031E47 File Offset: 0x00030047
		' (set) Token: 0x0600053D RID: 1341 RVA: 0x00031E51 File Offset: 0x00030051
		Friend Overridable Property tpDetails As TabPage

		' Token: 0x170001F9 RID: 505
		' (get) Token: 0x0600053E RID: 1342 RVA: 0x00031E5A File Offset: 0x0003005A
		' (set) Token: 0x0600053F RID: 1343 RVA: 0x00031E64 File Offset: 0x00030064
		Friend Overridable Property Panel1 As Panel

		' Token: 0x170001FA RID: 506
		' (get) Token: 0x06000540 RID: 1344 RVA: 0x00031E6D File Offset: 0x0003006D
		' (set) Token: 0x06000541 RID: 1345 RVA: 0x00031E77 File Offset: 0x00030077
		Friend Overridable Property GroupBox1 As GroupBox

		' Token: 0x170001FB RID: 507
		' (get) Token: 0x06000542 RID: 1346 RVA: 0x00031E80 File Offset: 0x00030080
		' (set) Token: 0x06000543 RID: 1347 RVA: 0x00031E8A File Offset: 0x0003008A
		Friend Overridable Property PnlMasters As Panel

		' Token: 0x170001FC RID: 508
		' (get) Token: 0x06000544 RID: 1348 RVA: 0x00031E93 File Offset: 0x00030093
		' (set) Token: 0x06000545 RID: 1349 RVA: 0x00031EA0 File Offset: 0x000300A0
		Friend Overridable Property chkMaster As CheckBox
			<CompilerGenerated()>
			Get
				Return Me._chkMaster
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim eventHandler As EventHandler = AddressOf Me.chkMaster_CheckedChanged
				Dim checkBox As CheckBox = Me._chkMaster
				If checkBox IsNot Nothing Then
					RemoveHandler checkBox.CheckedChanged, eventHandler
				End If
				Me._chkMaster = value
				checkBox = Me._chkMaster
				If checkBox IsNot Nothing Then
					AddHandler checkBox.CheckedChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170001FD RID: 509
		' (get) Token: 0x06000546 RID: 1350 RVA: 0x00031EE3 File Offset: 0x000300E3
		' (set) Token: 0x06000547 RID: 1351 RVA: 0x00031EED File Offset: 0x000300ED
		Friend Overridable Property skip_dgv1 As DataGridView

		' Token: 0x170001FE RID: 510
		' (get) Token: 0x06000548 RID: 1352 RVA: 0x00031EF6 File Offset: 0x000300F6
		' (set) Token: 0x06000549 RID: 1353 RVA: 0x00031F00 File Offset: 0x00030100
		Friend Overridable Property GroupBox2 As GroupBox

		' Token: 0x170001FF RID: 511
		' (get) Token: 0x0600054A RID: 1354 RVA: 0x00031F09 File Offset: 0x00030109
		' (set) Token: 0x0600054B RID: 1355 RVA: 0x00031F13 File Offset: 0x00030113
		Friend Overridable Property PnlAccessCtrl As Panel

		' Token: 0x17000200 RID: 512
		' (get) Token: 0x0600054C RID: 1356 RVA: 0x00031F1C File Offset: 0x0003011C
		' (set) Token: 0x0600054D RID: 1357 RVA: 0x00031F28 File Offset: 0x00030128
		Friend Overridable Property chkAccessCtrl As CheckBox
			<CompilerGenerated()>
			Get
				Return Me._chkAccessCtrl
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim eventHandler As EventHandler = AddressOf Me.chkAccessCtrl_CheckedChanged
				Dim checkBox As CheckBox = Me._chkAccessCtrl
				If checkBox IsNot Nothing Then
					RemoveHandler checkBox.CheckedChanged, eventHandler
				End If
				Me._chkAccessCtrl = value
				checkBox = Me._chkAccessCtrl
				If checkBox IsNot Nothing Then
					AddHandler checkBox.CheckedChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000201 RID: 513
		' (get) Token: 0x0600054E RID: 1358 RVA: 0x00031F6B File Offset: 0x0003016B
		' (set) Token: 0x0600054F RID: 1359 RVA: 0x00031F75 File Offset: 0x00030175
		Friend Overridable Property skip_dgv2 As DataGridView

		' Token: 0x17000202 RID: 514
		' (get) Token: 0x06000550 RID: 1360 RVA: 0x00031F7E File Offset: 0x0003017E
		' (set) Token: 0x06000551 RID: 1361 RVA: 0x00031F88 File Offset: 0x00030188
		Friend Overridable Property chk1 As DataGridViewCheckBoxColumn

		' Token: 0x17000203 RID: 515
		' (get) Token: 0x06000552 RID: 1362 RVA: 0x00031F91 File Offset: 0x00030191
		' (set) Token: 0x06000553 RID: 1363 RVA: 0x00031F9B File Offset: 0x0003019B
		Friend Overridable Property FormName1 As DataGridViewTextBoxColumn

		' Token: 0x17000204 RID: 516
		' (get) Token: 0x06000554 RID: 1364 RVA: 0x00031FA4 File Offset: 0x000301A4
		' (set) Token: 0x06000555 RID: 1365 RVA: 0x00031FAE File Offset: 0x000301AE
		Friend Overridable Property txtUserGroup As TextBox

		' Token: 0x17000205 RID: 517
		' (get) Token: 0x06000556 RID: 1366 RVA: 0x00031FB7 File Offset: 0x000301B7
		' (set) Token: 0x06000557 RID: 1367 RVA: 0x00031FC1 File Offset: 0x000301C1
		Friend Overridable Property Label1 As Label

		' Token: 0x17000206 RID: 518
		' (get) Token: 0x06000558 RID: 1368 RVA: 0x00031FCA File Offset: 0x000301CA
		' (set) Token: 0x06000559 RID: 1369 RVA: 0x00031FD4 File Offset: 0x000301D4
		Friend Overridable Property txtID As TextBox

		' Token: 0x17000207 RID: 519
		' (get) Token: 0x0600055A RID: 1370 RVA: 0x00031FDD File Offset: 0x000301DD
		' (set) Token: 0x0600055B RID: 1371 RVA: 0x00031FE7 File Offset: 0x000301E7
		Friend Overridable Property chkIsActive As CheckBox

		' Token: 0x17000208 RID: 520
		' (get) Token: 0x0600055C RID: 1372 RVA: 0x00031FF0 File Offset: 0x000301F0
		' (set) Token: 0x0600055D RID: 1373 RVA: 0x00031FFC File Offset: 0x000301FC
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

		' Token: 0x17000209 RID: 521
		' (get) Token: 0x0600055E RID: 1374 RVA: 0x0003203F File Offset: 0x0003023F
		' (set) Token: 0x0600055F RID: 1375 RVA: 0x0003204C File Offset: 0x0003024C
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

		' Token: 0x1700020A RID: 522
		' (get) Token: 0x06000560 RID: 1376 RVA: 0x0003208F File Offset: 0x0003028F
		' (set) Token: 0x06000561 RID: 1377 RVA: 0x00032099 File Offset: 0x00030299
		Friend Overridable Property skip_Label12 As Label

		' Token: 0x1700020B RID: 523
		' (get) Token: 0x06000562 RID: 1378 RVA: 0x000320A2 File Offset: 0x000302A2
		' (set) Token: 0x06000563 RID: 1379 RVA: 0x000320AC File Offset: 0x000302AC
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

		' Token: 0x1700020C RID: 524
		' (get) Token: 0x06000564 RID: 1380 RVA: 0x000320EF File Offset: 0x000302EF
		' (set) Token: 0x06000565 RID: 1381 RVA: 0x000320FC File Offset: 0x000302FC
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

		' Token: 0x1700020D RID: 525
		' (get) Token: 0x06000566 RID: 1382 RVA: 0x0003213F File Offset: 0x0003033F
		' (set) Token: 0x06000567 RID: 1383 RVA: 0x0003214C File Offset: 0x0003034C
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

		' Token: 0x1700020E RID: 526
		' (get) Token: 0x06000568 RID: 1384 RVA: 0x0003218F File Offset: 0x0003038F
		' (set) Token: 0x06000569 RID: 1385 RVA: 0x00032199 File Offset: 0x00030399
		Friend Overridable Property tab_lblDetails As Label

		' Token: 0x1700020F RID: 527
		' (get) Token: 0x0600056A RID: 1386 RVA: 0x000321A2 File Offset: 0x000303A2
		' (set) Token: 0x0600056B RID: 1387 RVA: 0x000321AC File Offset: 0x000303AC
		Friend Overridable Property tpList As TabPage

		' Token: 0x17000210 RID: 528
		' (get) Token: 0x0600056C RID: 1388 RVA: 0x000321B5 File Offset: 0x000303B5
		' (set) Token: 0x0600056D RID: 1389 RVA: 0x000321BF File Offset: 0x000303BF
		Friend Overridable Property tab_lblList As Label

		' Token: 0x17000211 RID: 529
		' (get) Token: 0x0600056E RID: 1390 RVA: 0x000321C8 File Offset: 0x000303C8
		' (set) Token: 0x0600056F RID: 1391 RVA: 0x000321D2 File Offset: 0x000303D2
		Friend Overridable Property FolderSelect As FolderBrowserDialog

		' Token: 0x17000212 RID: 530
		' (get) Token: 0x06000570 RID: 1392 RVA: 0x000321DB File Offset: 0x000303DB
		' (set) Token: 0x06000571 RID: 1393 RVA: 0x000321E5 File Offset: 0x000303E5
		Friend Overridable Property chk As DataGridViewCheckBoxColumn

		' Token: 0x17000213 RID: 531
		' (get) Token: 0x06000572 RID: 1394 RVA: 0x000321EE File Offset: 0x000303EE
		' (set) Token: 0x06000573 RID: 1395 RVA: 0x000321F8 File Offset: 0x000303F8
		Friend Overridable Property FormName As DataGridViewTextBoxColumn

		' Token: 0x17000214 RID: 532
		' (get) Token: 0x06000574 RID: 1396 RVA: 0x00032201 File Offset: 0x00030401
		' (set) Token: 0x06000575 RID: 1397 RVA: 0x0003220B File Offset: 0x0003040B
		Friend Overridable Property GbAdvanced As GroupBox

		' Token: 0x17000215 RID: 533
		' (get) Token: 0x06000576 RID: 1398 RVA: 0x00032214 File Offset: 0x00030414
		' (set) Token: 0x06000577 RID: 1399 RVA: 0x0003221E File Offset: 0x0003041E
		Friend Overridable Property txtSCreated As TextBox

		' Token: 0x17000216 RID: 534
		' (get) Token: 0x06000578 RID: 1400 RVA: 0x00032227 File Offset: 0x00030427
		' (set) Token: 0x06000579 RID: 1401 RVA: 0x00032231 File Offset: 0x00030431
		Friend Overridable Property lblSCreated As ComboBox

		' Token: 0x17000217 RID: 535
		' (get) Token: 0x0600057A RID: 1402 RVA: 0x0003223A File Offset: 0x0003043A
		' (set) Token: 0x0600057B RID: 1403 RVA: 0x00032244 File Offset: 0x00030444
		Friend Overridable Property dtpFrom As DateTimePicker

		' Token: 0x17000218 RID: 536
		' (get) Token: 0x0600057C RID: 1404 RVA: 0x0003224D File Offset: 0x0003044D
		' (set) Token: 0x0600057D RID: 1405 RVA: 0x00032257 File Offset: 0x00030457
		Friend Overridable Property dtpTo As DateTimePicker

		' Token: 0x17000219 RID: 537
		' (get) Token: 0x0600057E RID: 1406 RVA: 0x00032260 File Offset: 0x00030460
		' (set) Token: 0x0600057F RID: 1407 RVA: 0x0003226A File Offset: 0x0003046A
		Friend Overridable Property Label16 As Label

		' Token: 0x1700021A RID: 538
		' (get) Token: 0x06000580 RID: 1408 RVA: 0x00032273 File Offset: 0x00030473
		' (set) Token: 0x06000581 RID: 1409 RVA: 0x0003227D File Offset: 0x0003047D
		Friend Overridable Property lblSDate As ComboBox

		' Token: 0x1700021B RID: 539
		' (get) Token: 0x06000582 RID: 1410 RVA: 0x00032286 File Offset: 0x00030486
		' (set) Token: 0x06000583 RID: 1411 RVA: 0x00032290 File Offset: 0x00030490
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

		' Token: 0x1700021C RID: 540
		' (get) Token: 0x06000584 RID: 1412 RVA: 0x000322D3 File Offset: 0x000304D3
		' (set) Token: 0x06000585 RID: 1413 RVA: 0x000322DD File Offset: 0x000304DD
		Friend Overridable Property GbBasic As GroupBox

		' Token: 0x1700021D RID: 541
		' (get) Token: 0x06000586 RID: 1414 RVA: 0x000322E6 File Offset: 0x000304E6
		' (set) Token: 0x06000587 RID: 1415 RVA: 0x000322F0 File Offset: 0x000304F0
		Friend Overridable Property txtSUserGroup As TextBox

		' Token: 0x1700021E RID: 542
		' (get) Token: 0x06000588 RID: 1416 RVA: 0x000322F9 File Offset: 0x000304F9
		' (set) Token: 0x06000589 RID: 1417 RVA: 0x00032303 File Offset: 0x00030503
		Friend Overridable Property Label7 As Label

		' Token: 0x1700021F RID: 543
		' (get) Token: 0x0600058A RID: 1418 RVA: 0x0003230C File Offset: 0x0003050C
		' (set) Token: 0x0600058B RID: 1419 RVA: 0x00032316 File Offset: 0x00030516
		Friend Overridable Property cmbStatus As ComboBox

		' Token: 0x17000220 RID: 544
		' (get) Token: 0x0600058C RID: 1420 RVA: 0x0003231F File Offset: 0x0003051F
		' (set) Token: 0x0600058D RID: 1421 RVA: 0x00032329 File Offset: 0x00030529
		Friend Overridable Property Label11 As Label

		' Token: 0x17000221 RID: 545
		' (get) Token: 0x0600058E RID: 1422 RVA: 0x00032332 File Offset: 0x00030532
		' (set) Token: 0x0600058F RID: 1423 RVA: 0x0003233C File Offset: 0x0003053C
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

		' Token: 0x17000222 RID: 546
		' (get) Token: 0x06000590 RID: 1424 RVA: 0x0003237F File Offset: 0x0003057F
		' (set) Token: 0x06000591 RID: 1425 RVA: 0x00032389 File Offset: 0x00030589
		Friend Overridable Property grpListButton As GroupBox

		' Token: 0x17000223 RID: 547
		' (get) Token: 0x06000592 RID: 1426 RVA: 0x00032392 File Offset: 0x00030592
		' (set) Token: 0x06000593 RID: 1427 RVA: 0x0003239C File Offset: 0x0003059C
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x17000224 RID: 548
		' (get) Token: 0x06000594 RID: 1428 RVA: 0x000323A5 File Offset: 0x000305A5
		' (set) Token: 0x06000595 RID: 1429 RVA: 0x000323B0 File Offset: 0x000305B0
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

		' Token: 0x17000225 RID: 549
		' (get) Token: 0x06000596 RID: 1430 RVA: 0x000323F3 File Offset: 0x000305F3
		' (set) Token: 0x06000597 RID: 1431 RVA: 0x00032400 File Offset: 0x00030600
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

		' Token: 0x17000226 RID: 550
		' (get) Token: 0x06000598 RID: 1432 RVA: 0x00032443 File Offset: 0x00030643
		' (set) Token: 0x06000599 RID: 1433 RVA: 0x00032450 File Offset: 0x00030650
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

		' Token: 0x17000227 RID: 551
		' (get) Token: 0x0600059A RID: 1434 RVA: 0x00032493 File Offset: 0x00030693
		' (set) Token: 0x0600059B RID: 1435 RVA: 0x0003249D File Offset: 0x0003069D
		Friend Overridable Property lblRows As Label

		' Token: 0x17000228 RID: 552
		' (get) Token: 0x0600059C RID: 1436 RVA: 0x000324A6 File Offset: 0x000306A6
		' (set) Token: 0x0600059D RID: 1437 RVA: 0x000324B0 File Offset: 0x000306B0
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

		' Token: 0x0600059E RID: 1438 RVA: 0x000324F4 File Offset: 0x000306F4
		Public Sub New()
			AddHandler MyBase.Shown, AddressOf Me.Me_Shown
			AddHandler MyBase.FormClosing, AddressOf Me.UserGroup_FormClosing
			AddHandler MyBase.Load, AddressOf Me.UserGroup_Load
			Me.InitializeComponent()
			Me.pnlBasicDefaultHeight = Me.GbBasic.Height
			Me.pnlBasicSetHeight = 23
			Me.pnlAdvDefaultHeight = 23
			Me.pnlAdvSetHeight = Me.GbAdvanced.Height
		End Sub

		' Token: 0x0600059F RID: 1439 RVA: 0x0003257C File Offset: 0x0003077C
		Private Sub SetSearchPanel()
			Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
			Me.GbBasic.Height = Me.pnlBasicDefaultHeight
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
		End Sub

		' Token: 0x060005A0 RID: 1440 RVA: 0x000325D0 File Offset: 0x000307D0
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

		' Token: 0x060005A1 RID: 1441 RVA: 0x00032640 File Offset: 0x00030840
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

		' Token: 0x060005A2 RID: 1442 RVA: 0x000326B0 File Offset: 0x000308B0
		Private Sub Me_Shown(sender As Object, e As EventArgs)
			Me.SetTabs()
		End Sub

		' Token: 0x060005A3 RID: 1443 RVA: 0x000326BC File Offset: 0x000308BC
		Private Sub SetTabs()
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = CInt(Math.Round(CDbl((Me.theme_tc.Width - 4)) / 2.0))
			Me.theme_tc.ItemSize = New Size(num, 30)
			Me.tab_lblDetails.Width = num
			Me.tab_lblList.Width = num + 3
			Me.tab_lblDetails.Location = New Point(0, 0)
			Me.tab_lblList.Location = New Point(num - 4, 0)
		End Sub

		' Token: 0x060005A4 RID: 1444 RVA: 0x00032744 File Offset: 0x00030944
		Private Sub UserGroup_FormClosing(sender As Object, e As FormClosingEventArgs)
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

		' Token: 0x060005A5 RID: 1445 RVA: 0x000327DC File Offset: 0x000309DC
		Private Sub UserGroup_Load(sender As Object, e As EventArgs)
			Me.SetSearchPanel()
			Designing.SetTheme(Me)
			Me.ClearForm()
			Me.ClearList()
			Me.SetAccess("DISABLE")
			Me.sStatus = "LOAD"
			Me.SetButtonStatus()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x060005A6 RID: 1446 RVA: 0x0003283C File Offset: 0x00030A3C
		Private Sub FillGrid()
			Dim dataTable As DataTable = New DataTable()
			Dim text As String = " SELECT FormName.FormName, FormName.SortOrder, FormName.FormType"
			text += " FROM FormName INNER JOIN UserGroupDtls ON FormName.FormName = UserGroupDtls.FormName "
			text += " INNER JOIN UserGroup ON UserGroupDtls.UserGroupID = UserGroup.UserGroupID"
			text += " WHERE UserGroup.UserGroupID = " + GlobalVariables.gsUserGroupID
			text += " ORDER BY FormName.SortOrder"
			dataTable = MainModule.GetData(text)
			Me.skip_dgv1.Rows.Clear()
			Me.skip_dgv2.Rows.Clear()
			Dim num As Integer = dataTable.Rows.Count - 1
			For i As Integer = 0 To num
				Dim obj As Object = dataTable.Rows(i)("FormType")
				Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(obj, "Settings", False)
				If flag Then
					Me.skip_dgv1.Rows.Add()
					Me.skip_dgv1.Rows(Me.skip_dgv1.RowCount - 1).Cells("Chk").Value = False
					Me.skip_dgv1.Rows(Me.skip_dgv1.RowCount - 1).Cells("FormName").Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(i)("FormName"))
				Else
					flag = Operators.ConditionalCompareObjectEqual(obj, "Access", False)
					If flag Then
						Me.skip_dgv2.Rows.Add()
						Me.skip_dgv2.Rows(Me.skip_dgv2.RowCount - 1).Cells("chk1").Value = False
						Me.skip_dgv2.Rows(Me.skip_dgv2.RowCount - 1).Cells("FormName1").Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(i)("FormName"))
					Else
						Me.skip_dgv1.Rows.Add()
						Me.skip_dgv1.Rows(Me.skip_dgv1.RowCount - 1).Cells("Chk").Value = False
						Me.skip_dgv1.Rows(Me.skip_dgv1.RowCount - 1).Cells("FormName").Value = RuntimeHelpers.GetObjectValue(dataTable.Rows(i)("FormName"))
					End If
				End If
			Next
		End Sub

		' Token: 0x060005A7 RID: 1447 RVA: 0x00032AEC File Offset: 0x00030CEC
		Private Sub ClearForm()
			Me.txtID.Text = ""
			Me.txtUserGroup.Text = ""
			Me.chkIsActive.Checked = False
			Me.FillGrid()
			Me.chkMaster.Checked = False
			Me.chkAccessCtrl.Checked = False
			Me.SetAccess("DISABLE")
		End Sub

		' Token: 0x060005A8 RID: 1448 RVA: 0x00032B58 File Offset: 0x00030D58
		Private Sub ClearList()
			Me.txtSUserGroup.Text = ""
			Me.txtSCreated.Text = ""
			Me.cmbStatus.SelectedIndex = 0
			Me.lblSDate.SelectedIndex = 0
			Me.lblSCreated.SelectedIndex = 0
			Me.dtpFrom.Value = DateAndTime.Now
			Me.dtpTo.Value = DateAndTime.Now
			Me.dtpFrom.Checked = False
			Me.dtpTo.Checked = False
			Me.lblRows.Text = "0 - Rows"
			Me.dgvList.DataSource = Nothing
		End Sub

		' Token: 0x060005A9 RID: 1449 RVA: 0x00032C09 File Offset: 0x00030E09
		Private Sub btnClear_Click(sender As Object, e As EventArgs)
			Me.ClearForm()
			Me.sStatus = "LOAD"
			Me.SetButtonStatus()
		End Sub

		' Token: 0x060005AA RID: 1450 RVA: 0x00032C25 File Offset: 0x00030E25
		Private Sub btnClearList_Click(sender As Object, e As EventArgs)
			Me.ClearList()
		End Sub

		' Token: 0x060005AB RID: 1451 RVA: 0x00032C2F File Offset: 0x00030E2F
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x060005AC RID: 1452 RVA: 0x00032C39 File Offset: 0x00030E39
		Private Sub btnExport_Click(sender As Object, e As EventArgs)
			MainModule.ExportToExcel(Me.dgvList, Me.Text)
		End Sub

		' Token: 0x060005AD RID: 1453 RVA: 0x00032C50 File Offset: 0x00030E50
		Private Sub SetAccess(sAccess As String)
			If Operators.CompareString(sAccess, "ENABLE", False) <> 0 Then
				If Operators.CompareString(sAccess, "DISABLE", False) = 0 Then
					Me.txtID.[ReadOnly] = True
					Me.txtUserGroup.[ReadOnly] = True
					Me.chkIsActive.Enabled = False
					Me.chkMaster.Enabled = False
					Me.chkAccessCtrl.Enabled = False
					Me.skip_dgv1.[ReadOnly] = True
				End If
			Else
				Me.txtID.[ReadOnly] = False
				Me.txtUserGroup.[ReadOnly] = False
				Me.PnlMasters.Enabled = True
				Me.PnlAccessCtrl.Enabled = True
				Me.chkIsActive.Enabled = True
				Me.chkMaster.Enabled = True
				Me.chkAccessCtrl.Enabled = True
				Me.skip_dgv1.[ReadOnly] = False
			End If
		End Sub

		' Token: 0x060005AE RID: 1454 RVA: 0x00032D40 File Offset: 0x00030F40
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
						End If
					Else
						Me.btnAdd.Enabled = False
						Me.btnEdit.Enabled = True
						Me.btnSave.Enabled = False
						Me.btnClear.Enabled = True
						Me.btnClose.Enabled = True
					End If
				Else
					Me.btnAdd.Enabled = True
					Me.btnEdit.Enabled = False
					Me.btnSave.Enabled = False
					Me.btnClear.Enabled = False
					Me.btnClose.Enabled = True
				End If
			Else
				Me.btnAdd.Enabled = False
				Me.btnEdit.Enabled = False
				Me.btnSave.Enabled = True
				Me.btnClear.Enabled = True
				Me.btnClose.Enabled = False
			End If
		End Sub

		' Token: 0x060005AF RID: 1455 RVA: 0x00032EC0 File Offset: 0x000310C0
		Private Sub btnAdd_Click(sender As Object, e As EventArgs)
			Me.ClearForm()
			Me.SetAccess("ENABLE")
			Me.sStatus = "ADD"
			Me.SetButtonStatus()
			Me.chkIsActive.Checked = True
			Me.txtUserGroup.Focus()
		End Sub

		' Token: 0x060005B0 RID: 1456 RVA: 0x00032F0C File Offset: 0x0003110C
		Private Sub btnEdit_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				Me.SetAccess("ENABLE")
				Me.sStatus = "EDIT"
				Me.SetButtonStatus()
			End If
		End Sub

		' Token: 0x060005B1 RID: 1457 RVA: 0x00032F58 File Offset: 0x00031158
		Private Sub btnSearch_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SearchData()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x060005B2 RID: 1458 RVA: 0x00032FC4 File Offset: 0x000311C4
		Private Sub SearchData()
			Dim text As String = ""
			Dim text2 As String = " SELECT  UserGroup.UserGroupID AS ID, UserGroup, UserGroup.IsActive, UserGroup.CreationDt, "
			text2 += " Created.UserName AS CreatedBy, UserGroup.ModificationDt, Modified.UserName AS ModifiedBy"
			text2 += " FROM UserGroup LEFT OUTER JOIN [User] AS Created ON UserGroup.CreatedBy = Created.UserID "
			text2 += " LEFT OUTER JOIN [User] AS Modified ON UserGroup.ModifiedBy = Modified.UserID"
			text2 += " WHERE 1=1"
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.txtSUserGroup.Text), "", False) <> 0
			If flag Then
				text2 = text2 + " AND (UserGroup.UserGroup  LIKE '" + Strings.Trim(Me.txtSUserGroup.Text) + "%') "
				text = text + "UserGroup  LIKE " + Strings.Trim(Me.txtSUserGroup.Text)
			End If
			Dim flag2 As Boolean = Me.cmbStatus.SelectedIndex > 0
			If flag2 Then
				Dim flag3 As Boolean = Me.cmbStatus.SelectedIndex = 1
				If flag3 Then
					text2 += " AND (UserGroup.IsActive = 1)"
					text += "IsActive = 1" & vbCrLf
				Else
					text2 += " AND (UserGroup.IsActive = 0)"
					text += "IsActive = 0" & vbCrLf
				End If
			End If
			Dim flag4 As Boolean = Operators.CompareString(Strings.Trim(Me.txtSCreated.Text), "", False) <> 0
			If flag4 Then
				Dim flag5 As Boolean = Me.lblSCreated.SelectedIndex >= 0
				If flag5 Then
					Dim flag6 As Boolean = Me.lblSCreated.SelectedIndex = 0
					Dim text3 As String
					If flag6 Then
						text3 = "Created"
					Else
						text3 = "Modified"
					End If
					text2 = String.Concat(New String() { text2, " AND ", text3, ".UserName LIKE '%", Strings.Trim(Me.txtSCreated.Text), "%'" })
					text = text + (text3 + "By LIKE " + Strings.Trim(Me.txtSCreated.Text)) + vbCrLf
				End If
			End If
			Dim flag7 As Boolean = Me.lblSDate.SelectedIndex >= 0
			If flag7 Then
				Dim flag8 As Boolean = Me.lblSDate.SelectedIndex = 0
				Dim text4 As String
				If flag8 Then
					text4 = "CreationDt"
				Else
					text4 = "ModificationDt"
				End If
				Dim flag9 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
				If flag9 Then
					text2 = String.Concat(New String() { text2, " AND [UserGroup].", text4, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
					text = text + String.Concat(New String() { text4, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
				Else
					Dim checked As Boolean = Me.dtpFrom.Checked
					If checked Then
						text2 = String.Concat(New String() { text2, " AND [UserGroup].", text4, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59"), "'" })
						text = text + String.Concat(New String() { text4, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
					End If
					Dim checked2 As Boolean = Me.dtpTo.Checked
					If checked2 Then
						text2 = String.Concat(New String() { text2, " AND [UserGroup].", text4, " BETWEEN '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
						text = text + String.Concat(New String() { text4, " BETWEEN  ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
					End If
				End If
			End If
			text2 += " ORDER BY UserGroup.UserGroup"
			Dim data As DataTable = MainModule.GetData(text2)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = data
			Me.dgvList.Columns("ID").Visible = False
			Me.dgvList.Columns("UserGroup").Width = 235
			Me.dgvList.Columns("CreationDt").Width = 170
			Me.dgvList.Columns("CreatedBy").Width = 150
			Me.dgvList.Columns("ModificationDt").Width = 170
			Me.dgvList.Columns("ModifiedBy").Width = 150
			Me.dgvList.Columns("CreationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			Me.dgvList.Columns("ModificationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			Me.dgvList.Columns("UserGroup").HeaderText = "User Group"
			Me.dgvList.Columns("IsActive").HeaderText = "Is Active"
			Me.dgvList.Columns("CreationDt").HeaderText = "Creation Date"
			Me.dgvList.Columns("CreatedBy").HeaderText = "Created By"
			Me.dgvList.Columns("ModificationDt").HeaderText = "Modification Date"
			Me.dgvList.Columns("ModifiedBy").HeaderText = "Modified By"
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x060005B3 RID: 1459 RVA: 0x000336FC File Offset: 0x000318FC
		Private Sub dgvList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = (Operators.CompareString(Me.sStatus, "ADD", False) <> 0) And (Operators.CompareString(Me.sStatus, "EDIT", False) <> 0)
			If flag Then
				Dim flag2 As Boolean = e.RowIndex > -1
				If flag2 Then
					Me.FillData(Me.dgvList.Rows(e.RowIndex).Cells("ID").Value.ToString())
					Me.theme_tc.SelectedTab = Me.tpDetails
					Me.sStatus = "VIEW"
					Me.SetButtonStatus()
					Me.SetAccess("DISABLE")
					MainModule.TrnLog(Me.Text, "Entry Selected", "Selected ID: " + Me.dgvList.Rows(e.RowIndex).Cells("ID").Value.ToString(), Nothing)
				End If
			End If
		End Sub

		' Token: 0x060005B4 RID: 1460 RVA: 0x00033800 File Offset: 0x00031A00
		Private Sub FillData(sID As String)
			Dim dataTable As DataTable = CType(Me.dgvList.DataSource, DataTable)
			Dim flag As Boolean = (Operators.CompareString(sID, "", False) <> 0) And (dataTable.Rows.Count > 0)
			If flag Then
				Dim flag2 As Boolean = dataTable.[Select]("ID='" + sID + "'").Length > 0
				If flag2 Then
					Dim dataRow As DataRow = dataTable.[Select]("ID='" + sID + "'")(0)
					Me.txtID.Text = dataRow("ID").ToString()
					Me.txtUserGroup.Text = dataRow("UserGroup").ToString()
					Dim flag3 As Boolean = Operators.ConditionalCompareObjectEqual(dataRow("IsActive"), True, False)
					If flag3 Then
						Me.chkIsActive.Checked = True
					Else
						Me.chkIsActive.Checked = False
					End If
					Dim text As String = " SELECT FormName FROM  UserGroupDtls "
					text = text + " WHERE (UserGroupID = '" + Me.txtID.Text + "') ORDER BY FormName"
					Dim data As DataTable = MainModule.GetData(text)
					Dim num As Integer = Me.skip_dgv1.RowCount - 1
					For i As Integer = 0 To num
						Dim flag4 As Boolean = data.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("FormName='", Me.skip_dgv1.Rows(i).Cells("FormName").Value), "'"))).Length > 0
						If flag4 Then
							Me.skip_dgv1.Rows(i).Cells("Chk").Value = True
						Else
							Me.skip_dgv1.Rows(i).Cells("Chk").Value = False
						End If
					Next
					Dim num2 As Integer = Me.skip_dgv2.RowCount - 1
					For j As Integer = 0 To num2
						Dim flag5 As Boolean = data.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("FormName='", Me.skip_dgv2.Rows(j).Cells("FormName1").Value), "'"))).Length > 0
						If flag5 Then
							Me.skip_dgv2.Rows(j).Cells("Chk1").Value = True
						End If
					Next
				End If
			End If
		End Sub

		' Token: 0x060005B5 RID: 1461 RVA: 0x00033AA0 File Offset: 0x00031CA0
		Private Function ValidateForm() As Boolean
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.txtUserGroup.Text), "", False) = 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Enter UserGroup Name.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.txtUserGroup.Focus()
				flag2 = False
			Else
				Dim text As String = " SELECT UserGroupID, UserGroup FROM UserGroup"
				text = text + " WHERE (UserGroup = '" + Strings.Trim(Me.txtUserGroup.Text) + "') "
				Dim flag3 As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
				If flag3 Then
					text = text + " AND UserGroupID<>'" + Me.txtID.Text + "'"
				End If
				Dim data As DataTable = MainModule.GetData(text)
				Dim flag4 As Boolean = data.Rows.Count > 0
				If flag4 Then
					Dim flag5 As Boolean = data.[Select]("UserGroup='" + Strings.Trim(Me.txtUserGroup.Text) + "'").Length > 0
					If flag5 Then
						CustomMsgBox.Show("UserGroup Already Exists.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.txtUserGroup.Focus()
						Return False
					End If
				End If
				Dim flag6 As Boolean = False
				Dim num As Integer = Me.skip_dgv1.RowCount - 1
				For i As Integer = 0 To num
					Dim flag7 As Boolean = Operators.ConditionalCompareObjectEqual(Me.skip_dgv1.Rows(i).Cells("chk").Value, True, False)
					If flag7 Then
						flag6 = True
						Exit For
					End If
				Next
				Dim num2 As Integer = Me.skip_dgv2.RowCount - 1
				For j As Integer = 0 To num2
					Dim flag8 As Boolean = Operators.ConditionalCompareObjectEqual(Me.skip_dgv2.Rows(j).Cells("chk1").Value, True, False)
					If flag8 Then
						flag6 = True
						Exit For
					End If
				Next
				Dim flag9 As Boolean = Not flag6
				If flag9 Then
					CustomMsgBox.Show("Select Form(s)..!", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					flag2 = False
				Else
					flag2 = True
				End If
			End If
			Return flag2
		End Function

		' Token: 0x060005B6 RID: 1462 RVA: 0x00033CB4 File Offset: 0x00031EB4
		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.Save()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x060005B7 RID: 1463 RVA: 0x00033D20 File Offset: 0x00031F20
		Private Sub Save()
			Dim flag As Boolean = CustomMsgBox.Show("Save..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
			If flag Then
				Dim flag2 As Boolean = Not Me.ValidateForm()
				If Not flag2 Then
					Dim flag3 As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
					If flag3 Then
						Me.UpdateData()
					Else
						Me.InsertData()
					End If
				End If
			End If
		End Sub

		' Token: 0x060005B8 RID: 1464 RVA: 0x00033D88 File Offset: 0x00031F88
		Private Sub InsertData()
			Dim text As String = ""
			Dim text2 As String = " INSERT INTO UserGroup(UserGroup, CreationDt, CreatedBy, IsActive) "
			text2 = text2 + " VALUES ('" + Strings.Trim(Me.txtUserGroup.Text) + "', "
			text2 = text2 + " GETDATE(),'" + GlobalVariables.gsUserID + "',"
			Dim checked As Boolean = Me.chkIsActive.Checked
			If checked Then
				text2 += " 1)"
			Else
				text2 += " 0)"
			End If
			text2 += " SELECT SCOPE_IDENTITY() AS ID"
			Dim data As DataTable = MainModule.GetData(text2)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Me.txtID.Text = Conversions.ToString(data.Rows(0)("ID"))
				Me.InsertForms(Me.txtID.Text)
				Dim num As Integer = Me.skip_dgv1.Rows.Count - 1
				For i As Integer = 0 To num
					Dim flag2 As Boolean = Operators.CompareString(Me.skip_dgv1.Rows(i).Cells("chk").Value.ToString(), "True", False) = 0
					If flag2 Then
						text = text + Me.skip_dgv1.Rows(i).Cells("FormName").Value.ToString() + ", "
					End If
				Next
				Dim num2 As Integer = Me.skip_dgv2.Rows.Count - 1
				For j As Integer = 0 To num2
					Dim flag3 As Boolean = Operators.CompareString(Me.skip_dgv2.Rows(j).Cells("chk1").Value.ToString(), "True", False) = 0
					If flag3 Then
						text = text + Me.skip_dgv2.Rows(j).Cells("FormName1").Value.ToString() + ", "
					End If
				Next
				text = Strings.Mid(text, 1, text.Length - 2)
				MainModule.TrnLog(Me.Text, "Created", "New ID: " + Me.txtID.Text + ", Selected Forms: " + text, Nothing)
				CustomMsgBox.Show("User Group Added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Me.SetAccess("DISABLE")
				Me.sStatus = "SAVE"
				Me.SetButtonStatus()
			End If
		End Sub

		' Token: 0x060005B9 RID: 1465 RVA: 0x00034018 File Offset: 0x00032218
		Private Sub UpdateData()
			Dim text As String = ""
			Dim text2 As String = " UPDATE UserGroup SET UserGroup ='" + Strings.Trim(Me.txtUserGroup.Text) + "', "
			text2 = text2 + " ModificationDt=GETDATE(), ModifiedBy='" + GlobalVariables.gsUserID + "',"
			Dim checked As Boolean = Me.chkIsActive.Checked
			If checked Then
				text2 += " IsActive =1"
			Else
				text2 += " IsActive =0"
			End If
			text2 = text2 + " WHERE UserGroupID  = '" + Me.txtID.Text + "'"
			Dim flag As Boolean = MainModule.ExecuteSQL(text2) = 1
			If flag Then
				Me.InsertForms(Me.txtID.Text)
				Dim num As Integer = Me.skip_dgv1.Rows.Count - 1
				For i As Integer = 0 To num
					Dim flag2 As Boolean = Operators.CompareString(Me.skip_dgv1.Rows(i).Cells("chk").Value.ToString(), "True", False) = 0
					If flag2 Then
						text = text + Me.skip_dgv1.Rows(i).Cells("FormName").Value.ToString() + ", "
					End If
				Next
				Dim num2 As Integer = Me.skip_dgv2.Rows.Count - 1
				For j As Integer = 0 To num2
					Dim flag3 As Boolean = Operators.CompareString(Me.skip_dgv2.Rows(j).Cells("chk1").Value.ToString(), "True", False) = 0
					If flag3 Then
						text = text + Me.skip_dgv2.Rows(j).Cells("FormName1").Value.ToString() + ", "
					End If
				Next
				text = Strings.Mid(text, 1, text.Length - 2)
				MainModule.TrnLog("User Group", "Modified", "Modified User Group ID: " + Me.txtID.Text + ", Selected forms: " + text, Nothing)
				CustomMsgBox.Show("User Group Modified.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Me.SetAccess("DISABLE")
				Me.sStatus = "SAVE"
				Me.SetButtonStatus()
			End If
		End Sub

		' Token: 0x060005BA RID: 1466 RVA: 0x0003427C File Offset: 0x0003247C
		Private Sub InsertForms(sID As String)
			Dim text As String = "DELETE FROM UserGroupDtls WHERE (UserGroupID = '" + sID + "')"
			Dim flag As Boolean = MainModule.ExecuteSQL(text) = 1
			If flag Then
				text = ""
				Dim num As Integer = Me.skip_dgv1.RowCount - 1
				For i As Integer = 0 To num
					Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(Me.skip_dgv1.Rows(i).Cells("chk").Value, True, False)
					If flag2 Then
						text += " INSERT INTO UserGroupDtls (UserGroupID, FormName)"
						text = String.Concat(New String() { text, " VALUES ('", sID, "','", Me.skip_dgv1.Rows(i).Cells("FormName").Value.ToString(), "')" })
					End If
				Next
				Dim num2 As Integer = Me.skip_dgv2.RowCount - 1
				For j As Integer = 0 To num2
					Dim flag3 As Boolean = Operators.ConditionalCompareObjectEqual(Me.skip_dgv2.Rows(j).Cells("chk1").Value, True, False)
					If flag3 Then
						text += " INSERT INTO UserGroupDtls (UserGroupID, FormName)"
						text = String.Concat(New String() { text, " VALUES ('", sID, "','", Me.skip_dgv2.Rows(j).Cells("FormName1").Value.ToString(), "')" })
					End If
				Next
				MainModule.ExecuteSQL(text)
			End If
		End Sub

		' Token: 0x060005BB RID: 1467 RVA: 0x00034440 File Offset: 0x00032640
		Private Sub chkMaster_CheckedChanged(sender As Object, e As EventArgs)
			Dim checked As Boolean = Me.chkMaster.Checked
			If checked Then
				Dim num As Integer = Me.skip_dgv1.Rows.Count - 1
				For i As Integer = 0 To num
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.skip_dgv1.Rows(i).Cells("FormName").Value)
					Me.skip_dgv1.Rows(i).Cells("chk").Value = True
				Next
			Else
				Dim num2 As Integer = Me.skip_dgv1.Rows.Count - 1
				For j As Integer = 0 To num2
					Me.skip_dgv1.Rows(j).Cells("chk").Value = False
				Next
			End If
			Me.skip_dgv1.RefreshEdit()
		End Sub

		' Token: 0x060005BC RID: 1468 RVA: 0x00034538 File Offset: 0x00032738
		Private Sub chkAccessCtrl_CheckedChanged(sender As Object, e As EventArgs)
			Dim checked As Boolean = Me.chkAccessCtrl.Checked
			If checked Then
				Dim num As Integer = Me.skip_dgv2.Rows.Count - 1
				For i As Integer = 0 To num
					Me.skip_dgv2.Rows(i).Cells("chk1").Value = True
				Next
			Else
				Dim num2 As Integer = Me.skip_dgv2.Rows.Count - 1
				For j As Integer = 0 To num2
					Me.skip_dgv2.Rows(j).Cells("chk1").Value = False
				Next
			End If
		End Sub

		' Token: 0x04000257 RID: 599
		Private sStatus As String

		' Token: 0x04000258 RID: 600
		Private pnlBasicDefaultHeight As Integer

		' Token: 0x04000259 RID: 601
		Private pnlBasicSetHeight As Integer

		' Token: 0x0400025A RID: 602
		Private pnlAdvDefaultHeight As Integer

		' Token: 0x0400025B RID: 603
		Private pnlAdvSetHeight As Integer
	End Class
End Namespace
