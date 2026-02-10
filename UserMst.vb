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
	' Token: 0x02000020 RID: 32
	<DesignerGenerated()>
	Public Partial Class UserMst
		Inherits DockContent

		' Token: 0x17000229 RID: 553
		' (get) Token: 0x060005BF RID: 1471 RVA: 0x0003862F File Offset: 0x0003682F
		' (set) Token: 0x060005C0 RID: 1472 RVA: 0x00038639 File Offset: 0x00036839
		Friend Overridable Property FolderSelect As FolderBrowserDialog

		' Token: 0x1700022A RID: 554
		' (get) Token: 0x060005C1 RID: 1473 RVA: 0x00038642 File Offset: 0x00036842
		' (set) Token: 0x060005C2 RID: 1474 RVA: 0x0003864C File Offset: 0x0003684C
		Friend Overridable Property FileSelect As OpenFileDialog

		' Token: 0x1700022B RID: 555
		' (get) Token: 0x060005C3 RID: 1475 RVA: 0x00038655 File Offset: 0x00036855
		' (set) Token: 0x060005C4 RID: 1476 RVA: 0x0003865F File Offset: 0x0003685F
		Friend Overridable Property theme_tc As TabControl

		' Token: 0x1700022C RID: 556
		' (get) Token: 0x060005C5 RID: 1477 RVA: 0x00038668 File Offset: 0x00036868
		' (set) Token: 0x060005C6 RID: 1478 RVA: 0x00038672 File Offset: 0x00036872
		Friend Overridable Property tpDetails As TabPage

		' Token: 0x1700022D RID: 557
		' (get) Token: 0x060005C7 RID: 1479 RVA: 0x0003867B File Offset: 0x0003687B
		' (set) Token: 0x060005C8 RID: 1480 RVA: 0x00038685 File Offset: 0x00036885
		Friend Overridable Property tab_lblDetails As Label

		' Token: 0x1700022E RID: 558
		' (get) Token: 0x060005C9 RID: 1481 RVA: 0x0003868E File Offset: 0x0003688E
		' (set) Token: 0x060005CA RID: 1482 RVA: 0x00038698 File Offset: 0x00036898
		Friend Overridable Property tpList As TabPage

		' Token: 0x1700022F RID: 559
		' (get) Token: 0x060005CB RID: 1483 RVA: 0x000386A1 File Offset: 0x000368A1
		' (set) Token: 0x060005CC RID: 1484 RVA: 0x000386AB File Offset: 0x000368AB
		Friend Overridable Property tab_lblList As Label

		' Token: 0x17000230 RID: 560
		' (get) Token: 0x060005CD RID: 1485 RVA: 0x000386B4 File Offset: 0x000368B4
		' (set) Token: 0x060005CE RID: 1486 RVA: 0x000386BE File Offset: 0x000368BE
		Friend Overridable Property Panel1 As Panel

		' Token: 0x17000231 RID: 561
		' (get) Token: 0x060005CF RID: 1487 RVA: 0x000386C7 File Offset: 0x000368C7
		' (set) Token: 0x060005D0 RID: 1488 RVA: 0x000386D1 File Offset: 0x000368D1
		Friend Overridable Property Label3 As Label

		' Token: 0x17000232 RID: 562
		' (get) Token: 0x060005D1 RID: 1489 RVA: 0x000386DA File Offset: 0x000368DA
		' (set) Token: 0x060005D2 RID: 1490 RVA: 0x000386E4 File Offset: 0x000368E4
		Friend Overridable Property skip_Label11 As Label

		' Token: 0x17000233 RID: 563
		' (get) Token: 0x060005D3 RID: 1491 RVA: 0x000386ED File Offset: 0x000368ED
		' (set) Token: 0x060005D4 RID: 1492 RVA: 0x000386F7 File Offset: 0x000368F7
		Friend Overridable Property Label2 As Label

		' Token: 0x17000234 RID: 564
		' (get) Token: 0x060005D5 RID: 1493 RVA: 0x00038700 File Offset: 0x00036900
		' (set) Token: 0x060005D6 RID: 1494 RVA: 0x0003870C File Offset: 0x0003690C
		Friend Overridable Property btnLogoff As Button
			<CompilerGenerated()>
			Get
				Return Me._btnLogoff
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnLogoff_Click
				Dim button As Button = Me._btnLogoff
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnLogoff = value
				button = Me._btnLogoff
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000235 RID: 565
		' (get) Token: 0x060005D7 RID: 1495 RVA: 0x0003874F File Offset: 0x0003694F
		' (set) Token: 0x060005D8 RID: 1496 RVA: 0x00038759 File Offset: 0x00036959
		Friend Overridable Property txtIPAddress As TextBox

		' Token: 0x17000236 RID: 566
		' (get) Token: 0x060005D9 RID: 1497 RVA: 0x00038762 File Offset: 0x00036962
		' (set) Token: 0x060005DA RID: 1498 RVA: 0x0003876C File Offset: 0x0003696C
		Friend Overridable Property txtEmailID As TextBox

		' Token: 0x17000237 RID: 567
		' (get) Token: 0x060005DB RID: 1499 RVA: 0x00038775 File Offset: 0x00036975
		' (set) Token: 0x060005DC RID: 1500 RVA: 0x0003877F File Offset: 0x0003697F
		Friend Overridable Property Label1 As Label

		' Token: 0x17000238 RID: 568
		' (get) Token: 0x060005DD RID: 1501 RVA: 0x00038788 File Offset: 0x00036988
		' (set) Token: 0x060005DE RID: 1502 RVA: 0x00038792 File Offset: 0x00036992
		Friend Overridable Property lblStrength As Label

		' Token: 0x17000239 RID: 569
		' (get) Token: 0x060005DF RID: 1503 RVA: 0x0003879B File Offset: 0x0003699B
		' (set) Token: 0x060005E0 RID: 1504 RVA: 0x000387A5 File Offset: 0x000369A5
		Friend Overridable Property txtComputerName As TextBox

		' Token: 0x1700023A RID: 570
		' (get) Token: 0x060005E1 RID: 1505 RVA: 0x000387AE File Offset: 0x000369AE
		' (set) Token: 0x060005E2 RID: 1506 RVA: 0x000387B8 File Offset: 0x000369B8
		Friend Overridable Property chkIsLocked As CheckBox

		' Token: 0x1700023B RID: 571
		' (get) Token: 0x060005E3 RID: 1507 RVA: 0x000387C1 File Offset: 0x000369C1
		' (set) Token: 0x060005E4 RID: 1508 RVA: 0x000387CB File Offset: 0x000369CB
		Friend Overridable Property Label9 As Label

		' Token: 0x1700023C RID: 572
		' (get) Token: 0x060005E5 RID: 1509 RVA: 0x000387D4 File Offset: 0x000369D4
		' (set) Token: 0x060005E6 RID: 1510 RVA: 0x000387DE File Offset: 0x000369DE
		Friend Overridable Property txtUserName As TextBox

		' Token: 0x1700023D RID: 573
		' (get) Token: 0x060005E7 RID: 1511 RVA: 0x000387E7 File Offset: 0x000369E7
		' (set) Token: 0x060005E8 RID: 1512 RVA: 0x000387F1 File Offset: 0x000369F1
		Friend Overridable Property txtSessionState As TextBox

		' Token: 0x1700023E RID: 574
		' (get) Token: 0x060005E9 RID: 1513 RVA: 0x000387FA File Offset: 0x000369FA
		' (set) Token: 0x060005EA RID: 1514 RVA: 0x00038804 File Offset: 0x00036A04
		Friend Overridable Property Label4 As Label

		' Token: 0x1700023F RID: 575
		' (get) Token: 0x060005EB RID: 1515 RVA: 0x0003880D File Offset: 0x00036A0D
		' (set) Token: 0x060005EC RID: 1516 RVA: 0x00038818 File Offset: 0x00036A18
		Friend Overridable Property cmbPlant As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbPlant
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbPlant_Validated
				Dim comboBox As ComboBox = Me._cmbPlant
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.Validated, eventHandler
				End If
				Me._cmbPlant = value
				comboBox = Me._cmbPlant
				If comboBox IsNot Nothing Then
					AddHandler comboBox.Validated, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000240 RID: 576
		' (get) Token: 0x060005ED RID: 1517 RVA: 0x0003885B File Offset: 0x00036A5B
		' (set) Token: 0x060005EE RID: 1518 RVA: 0x00038865 File Offset: 0x00036A65
		Friend Overridable Property txtID As TextBox

		' Token: 0x17000241 RID: 577
		' (get) Token: 0x060005EF RID: 1519 RVA: 0x0003886E File Offset: 0x00036A6E
		' (set) Token: 0x060005F0 RID: 1520 RVA: 0x00038878 File Offset: 0x00036A78
		Friend Overridable Property Label8 As Label

		' Token: 0x17000242 RID: 578
		' (get) Token: 0x060005F1 RID: 1521 RVA: 0x00038881 File Offset: 0x00036A81
		' (set) Token: 0x060005F2 RID: 1522 RVA: 0x0003888B File Offset: 0x00036A8B
		Friend Overridable Property skip_Label9 As Label

		' Token: 0x17000243 RID: 579
		' (get) Token: 0x060005F3 RID: 1523 RVA: 0x00038894 File Offset: 0x00036A94
		' (set) Token: 0x060005F4 RID: 1524 RVA: 0x0003889E File Offset: 0x00036A9E
		Friend Overridable Property Label10 As Label

		' Token: 0x17000244 RID: 580
		' (get) Token: 0x060005F5 RID: 1525 RVA: 0x000388A7 File Offset: 0x00036AA7
		' (set) Token: 0x060005F6 RID: 1526 RVA: 0x000388B1 File Offset: 0x00036AB1
		Friend Overridable Property skip_Label8 As Label

		' Token: 0x17000245 RID: 581
		' (get) Token: 0x060005F7 RID: 1527 RVA: 0x000388BA File Offset: 0x00036ABA
		' (set) Token: 0x060005F8 RID: 1528 RVA: 0x000388C4 File Offset: 0x00036AC4
		Friend Overridable Property Label12 As Label

		' Token: 0x17000246 RID: 582
		' (get) Token: 0x060005F9 RID: 1529 RVA: 0x000388CD File Offset: 0x00036ACD
		' (set) Token: 0x060005FA RID: 1530 RVA: 0x000388D8 File Offset: 0x00036AD8
		Friend Overridable Property cmbGroup As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbGroup
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbGroup_Validated
				Dim comboBox As ComboBox = Me._cmbGroup
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.Validated, eventHandler
				End If
				Me._cmbGroup = value
				comboBox = Me._cmbGroup
				If comboBox IsNot Nothing Then
					AddHandler comboBox.Validated, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000247 RID: 583
		' (get) Token: 0x060005FB RID: 1531 RVA: 0x0003891B File Offset: 0x00036B1B
		' (set) Token: 0x060005FC RID: 1532 RVA: 0x00038925 File Offset: 0x00036B25
		Friend Overridable Property chkIsActive As CheckBox

		' Token: 0x17000248 RID: 584
		' (get) Token: 0x060005FD RID: 1533 RVA: 0x0003892E File Offset: 0x00036B2E
		' (set) Token: 0x060005FE RID: 1534 RVA: 0x00038938 File Offset: 0x00036B38
		Friend Overridable Property txtLogin As TextBox

		' Token: 0x17000249 RID: 585
		' (get) Token: 0x060005FF RID: 1535 RVA: 0x00038941 File Offset: 0x00036B41
		' (set) Token: 0x06000600 RID: 1536 RVA: 0x0003894C File Offset: 0x00036B4C
		Friend Overridable Property txtPass As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtPass
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim keyEventHandler As KeyEventHandler = AddressOf Me.txtPass_KeyDown
				Dim keyEventHandler2 As KeyEventHandler = AddressOf Me.txtPass_KeyUp
				Dim textBox As TextBox = Me._txtPass
				If textBox IsNot Nothing Then
					RemoveHandler textBox.KeyDown, keyEventHandler
					RemoveHandler textBox.KeyUp, keyEventHandler2
				End If
				Me._txtPass = value
				textBox = Me._txtPass
				If textBox IsNot Nothing Then
					AddHandler textBox.KeyDown, keyEventHandler
					AddHandler textBox.KeyUp, keyEventHandler2
				End If
			End Set
		End Property

		' Token: 0x1700024A RID: 586
		' (get) Token: 0x06000601 RID: 1537 RVA: 0x000389AA File Offset: 0x00036BAA
		' (set) Token: 0x06000602 RID: 1538 RVA: 0x000389B4 File Offset: 0x00036BB4
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

		' Token: 0x1700024B RID: 587
		' (get) Token: 0x06000603 RID: 1539 RVA: 0x000389F7 File Offset: 0x00036BF7
		' (set) Token: 0x06000604 RID: 1540 RVA: 0x00038A01 File Offset: 0x00036C01
		Friend Overridable Property skip_Label13 As Label

		' Token: 0x1700024C RID: 588
		' (get) Token: 0x06000605 RID: 1541 RVA: 0x00038A0A File Offset: 0x00036C0A
		' (set) Token: 0x06000606 RID: 1542 RVA: 0x00038A14 File Offset: 0x00036C14
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

		' Token: 0x1700024D RID: 589
		' (get) Token: 0x06000607 RID: 1543 RVA: 0x00038A57 File Offset: 0x00036C57
		' (set) Token: 0x06000608 RID: 1544 RVA: 0x00038A61 File Offset: 0x00036C61
		Friend Overridable Property skip_Label12 As Label

		' Token: 0x1700024E RID: 590
		' (get) Token: 0x06000609 RID: 1545 RVA: 0x00038A6A File Offset: 0x00036C6A
		' (set) Token: 0x0600060A RID: 1546 RVA: 0x00038A74 File Offset: 0x00036C74
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

		' Token: 0x1700024F RID: 591
		' (get) Token: 0x0600060B RID: 1547 RVA: 0x00038AB7 File Offset: 0x00036CB7
		' (set) Token: 0x0600060C RID: 1548 RVA: 0x00038AC4 File Offset: 0x00036CC4
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

		' Token: 0x17000250 RID: 592
		' (get) Token: 0x0600060D RID: 1549 RVA: 0x00038B07 File Offset: 0x00036D07
		' (set) Token: 0x0600060E RID: 1550 RVA: 0x00038B14 File Offset: 0x00036D14
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

		' Token: 0x17000251 RID: 593
		' (get) Token: 0x0600060F RID: 1551 RVA: 0x00038B57 File Offset: 0x00036D57
		' (set) Token: 0x06000610 RID: 1552 RVA: 0x00038B61 File Offset: 0x00036D61
		Friend Overridable Property txtSessionID As TextBox

		' Token: 0x17000252 RID: 594
		' (get) Token: 0x06000611 RID: 1553 RVA: 0x00038B6A File Offset: 0x00036D6A
		' (set) Token: 0x06000612 RID: 1554 RVA: 0x00038B74 File Offset: 0x00036D74
		Friend Overridable Property skip_Label10 As Label

		' Token: 0x17000253 RID: 595
		' (get) Token: 0x06000613 RID: 1555 RVA: 0x00038B7D File Offset: 0x00036D7D
		' (set) Token: 0x06000614 RID: 1556 RVA: 0x00038B87 File Offset: 0x00036D87
		Friend Overridable Property Label14 As Label

		' Token: 0x17000254 RID: 596
		' (get) Token: 0x06000615 RID: 1557 RVA: 0x00038B90 File Offset: 0x00036D90
		' (set) Token: 0x06000616 RID: 1558 RVA: 0x00038B9A File Offset: 0x00036D9A
		Friend Overridable Property GbAdvanced As GroupBox

		' Token: 0x17000255 RID: 597
		' (get) Token: 0x06000617 RID: 1559 RVA: 0x00038BA3 File Offset: 0x00036DA3
		' (set) Token: 0x06000618 RID: 1560 RVA: 0x00038BAD File Offset: 0x00036DAD
		Friend Overridable Property cmbIsLocked As ComboBox

		' Token: 0x17000256 RID: 598
		' (get) Token: 0x06000619 RID: 1561 RVA: 0x00038BB6 File Offset: 0x00036DB6
		' (set) Token: 0x0600061A RID: 1562 RVA: 0x00038BC0 File Offset: 0x00036DC0
		Friend Overridable Property Label6 As Label

		' Token: 0x17000257 RID: 599
		' (get) Token: 0x0600061B RID: 1563 RVA: 0x00038BC9 File Offset: 0x00036DC9
		' (set) Token: 0x0600061C RID: 1564 RVA: 0x00038BD3 File Offset: 0x00036DD3
		Friend Overridable Property txtSCreated As TextBox

		' Token: 0x17000258 RID: 600
		' (get) Token: 0x0600061D RID: 1565 RVA: 0x00038BDC File Offset: 0x00036DDC
		' (set) Token: 0x0600061E RID: 1566 RVA: 0x00038BE6 File Offset: 0x00036DE6
		Friend Overridable Property lblSCreated As ComboBox

		' Token: 0x17000259 RID: 601
		' (get) Token: 0x0600061F RID: 1567 RVA: 0x00038BEF File Offset: 0x00036DEF
		' (set) Token: 0x06000620 RID: 1568 RVA: 0x00038BF9 File Offset: 0x00036DF9
		Friend Overridable Property dtpFrom As DateTimePicker

		' Token: 0x1700025A RID: 602
		' (get) Token: 0x06000621 RID: 1569 RVA: 0x00038C02 File Offset: 0x00036E02
		' (set) Token: 0x06000622 RID: 1570 RVA: 0x00038C0C File Offset: 0x00036E0C
		Friend Overridable Property dtpTo As DateTimePicker

		' Token: 0x1700025B RID: 603
		' (get) Token: 0x06000623 RID: 1571 RVA: 0x00038C15 File Offset: 0x00036E15
		' (set) Token: 0x06000624 RID: 1572 RVA: 0x00038C1F File Offset: 0x00036E1F
		Friend Overridable Property Label16 As Label

		' Token: 0x1700025C RID: 604
		' (get) Token: 0x06000625 RID: 1573 RVA: 0x00038C28 File Offset: 0x00036E28
		' (set) Token: 0x06000626 RID: 1574 RVA: 0x00038C32 File Offset: 0x00036E32
		Friend Overridable Property lblSDate As ComboBox

		' Token: 0x1700025D RID: 605
		' (get) Token: 0x06000627 RID: 1575 RVA: 0x00038C3B File Offset: 0x00036E3B
		' (set) Token: 0x06000628 RID: 1576 RVA: 0x00038C45 File Offset: 0x00036E45
		Friend Overridable Property cmbSPlant As ComboBox

		' Token: 0x1700025E RID: 606
		' (get) Token: 0x06000629 RID: 1577 RVA: 0x00038C4E File Offset: 0x00036E4E
		' (set) Token: 0x0600062A RID: 1578 RVA: 0x00038C58 File Offset: 0x00036E58
		Friend Overridable Property Label15 As Label

		' Token: 0x1700025F RID: 607
		' (get) Token: 0x0600062B RID: 1579 RVA: 0x00038C61 File Offset: 0x00036E61
		' (set) Token: 0x0600062C RID: 1580 RVA: 0x00038C6B File Offset: 0x00036E6B
		Friend Overridable Property cmbSGroup As ComboBox

		' Token: 0x17000260 RID: 608
		' (get) Token: 0x0600062D RID: 1581 RVA: 0x00038C74 File Offset: 0x00036E74
		' (set) Token: 0x0600062E RID: 1582 RVA: 0x00038C7E File Offset: 0x00036E7E
		Friend Overridable Property Label5 As Label

		' Token: 0x17000261 RID: 609
		' (get) Token: 0x0600062F RID: 1583 RVA: 0x00038C87 File Offset: 0x00036E87
		' (set) Token: 0x06000630 RID: 1584 RVA: 0x00038C91 File Offset: 0x00036E91
		Friend Overridable Property cmbStatus As ComboBox

		' Token: 0x17000262 RID: 610
		' (get) Token: 0x06000631 RID: 1585 RVA: 0x00038C9A File Offset: 0x00036E9A
		' (set) Token: 0x06000632 RID: 1586 RVA: 0x00038CA4 File Offset: 0x00036EA4
		Friend Overridable Property Label11 As Label

		' Token: 0x17000263 RID: 611
		' (get) Token: 0x06000633 RID: 1587 RVA: 0x00038CAD File Offset: 0x00036EAD
		' (set) Token: 0x06000634 RID: 1588 RVA: 0x00038CB8 File Offset: 0x00036EB8
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

		' Token: 0x17000264 RID: 612
		' (get) Token: 0x06000635 RID: 1589 RVA: 0x00038CFB File Offset: 0x00036EFB
		' (set) Token: 0x06000636 RID: 1590 RVA: 0x00038D05 File Offset: 0x00036F05
		Friend Overridable Property GbBasic As GroupBox

		' Token: 0x17000265 RID: 613
		' (get) Token: 0x06000637 RID: 1591 RVA: 0x00038D0E File Offset: 0x00036F0E
		' (set) Token: 0x06000638 RID: 1592 RVA: 0x00038D18 File Offset: 0x00036F18
		Friend Overridable Property txtSUserName As TextBox

		' Token: 0x17000266 RID: 614
		' (get) Token: 0x06000639 RID: 1593 RVA: 0x00038D21 File Offset: 0x00036F21
		' (set) Token: 0x0600063A RID: 1594 RVA: 0x00038D2C File Offset: 0x00036F2C
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

		' Token: 0x17000267 RID: 615
		' (get) Token: 0x0600063B RID: 1595 RVA: 0x00038D6F File Offset: 0x00036F6F
		' (set) Token: 0x0600063C RID: 1596 RVA: 0x00038D79 File Offset: 0x00036F79
		Friend Overridable Property Label7 As Label

		' Token: 0x17000268 RID: 616
		' (get) Token: 0x0600063D RID: 1597 RVA: 0x00038D82 File Offset: 0x00036F82
		' (set) Token: 0x0600063E RID: 1598 RVA: 0x00038D8C File Offset: 0x00036F8C
		Friend Overridable Property txtSLogin As TextBox

		' Token: 0x17000269 RID: 617
		' (get) Token: 0x0600063F RID: 1599 RVA: 0x00038D95 File Offset: 0x00036F95
		' (set) Token: 0x06000640 RID: 1600 RVA: 0x00038D9F File Offset: 0x00036F9F
		Friend Overridable Property lblSLogin As Label

		' Token: 0x1700026A RID: 618
		' (get) Token: 0x06000641 RID: 1601 RVA: 0x00038DA8 File Offset: 0x00036FA8
		' (set) Token: 0x06000642 RID: 1602 RVA: 0x00038DB2 File Offset: 0x00036FB2
		Friend Overridable Property grpListButton As GroupBox

		' Token: 0x1700026B RID: 619
		' (get) Token: 0x06000643 RID: 1603 RVA: 0x00038DBB File Offset: 0x00036FBB
		' (set) Token: 0x06000644 RID: 1604 RVA: 0x00038DC5 File Offset: 0x00036FC5
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x1700026C RID: 620
		' (get) Token: 0x06000645 RID: 1605 RVA: 0x00038DCE File Offset: 0x00036FCE
		' (set) Token: 0x06000646 RID: 1606 RVA: 0x00038DD8 File Offset: 0x00036FD8
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

		' Token: 0x1700026D RID: 621
		' (get) Token: 0x06000647 RID: 1607 RVA: 0x00038E1B File Offset: 0x0003701B
		' (set) Token: 0x06000648 RID: 1608 RVA: 0x00038E28 File Offset: 0x00037028
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

		' Token: 0x1700026E RID: 622
		' (get) Token: 0x06000649 RID: 1609 RVA: 0x00038E6B File Offset: 0x0003706B
		' (set) Token: 0x0600064A RID: 1610 RVA: 0x00038E78 File Offset: 0x00037078
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

		' Token: 0x1700026F RID: 623
		' (get) Token: 0x0600064B RID: 1611 RVA: 0x00038EBB File Offset: 0x000370BB
		' (set) Token: 0x0600064C RID: 1612 RVA: 0x00038EC5 File Offset: 0x000370C5
		Friend Overridable Property lblRows As Label

		' Token: 0x17000270 RID: 624
		' (get) Token: 0x0600064D RID: 1613 RVA: 0x00038ECE File Offset: 0x000370CE
		' (set) Token: 0x0600064E RID: 1614 RVA: 0x00038ED8 File Offset: 0x000370D8
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

		' Token: 0x17000271 RID: 625
		' (get) Token: 0x0600064F RID: 1615 RVA: 0x00038F1B File Offset: 0x0003711B
		' (set) Token: 0x06000650 RID: 1616 RVA: 0x00038F25 File Offset: 0x00037125
		Friend Overridable Property Label13 As Label

		' Token: 0x17000272 RID: 626
		' (get) Token: 0x06000651 RID: 1617 RVA: 0x00038F2E File Offset: 0x0003712E
		' (set) Token: 0x06000652 RID: 1618 RVA: 0x00038F38 File Offset: 0x00037138
		Friend Overridable Property Label17 As Label

		' Token: 0x17000273 RID: 627
		' (get) Token: 0x06000653 RID: 1619 RVA: 0x00038F41 File Offset: 0x00037141
		' (set) Token: 0x06000654 RID: 1620 RVA: 0x00038F4B File Offset: 0x0003714B
		Friend Overridable Property cmbDesignation As ComboBox

		' Token: 0x17000274 RID: 628
		' (get) Token: 0x06000655 RID: 1621 RVA: 0x00038F54 File Offset: 0x00037154
		' (set) Token: 0x06000656 RID: 1622 RVA: 0x00038F60 File Offset: 0x00037160
		Friend Overridable Property cmbReporting As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbReporting
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbReporting_Validated
				Dim comboBox As ComboBox = Me._cmbReporting
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.Validated, eventHandler
				End If
				Me._cmbReporting = value
				comboBox = Me._cmbReporting
				If comboBox IsNot Nothing Then
					AddHandler comboBox.Validated, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000275 RID: 629
		' (get) Token: 0x06000657 RID: 1623 RVA: 0x00038FA3 File Offset: 0x000371A3
		' (set) Token: 0x06000658 RID: 1624 RVA: 0x00038FB0 File Offset: 0x000371B0
		Friend Overridable Property cmbManager As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbManager
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbManager_Validated
				Dim comboBox As ComboBox = Me._cmbManager
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.Validated, eventHandler
				End If
				Me._cmbManager = value
				comboBox = Me._cmbManager
				If comboBox IsNot Nothing Then
					AddHandler comboBox.Validated, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000276 RID: 630
		' (get) Token: 0x06000659 RID: 1625 RVA: 0x00038FF3 File Offset: 0x000371F3
		' (set) Token: 0x0600065A RID: 1626 RVA: 0x00038FFD File Offset: 0x000371FD
		Friend Overridable Property cmbDepartment As ComboBox

		' Token: 0x17000277 RID: 631
		' (get) Token: 0x0600065B RID: 1627 RVA: 0x00039006 File Offset: 0x00037206
		' (set) Token: 0x0600065C RID: 1628 RVA: 0x00039010 File Offset: 0x00037210
		Friend Overridable Property Label22 As Label

		' Token: 0x17000278 RID: 632
		' (get) Token: 0x0600065D RID: 1629 RVA: 0x00039019 File Offset: 0x00037219
		' (set) Token: 0x0600065E RID: 1630 RVA: 0x00039023 File Offset: 0x00037223
		Friend Overridable Property Label23 As Label

		' Token: 0x17000279 RID: 633
		' (get) Token: 0x0600065F RID: 1631 RVA: 0x0003902C File Offset: 0x0003722C
		' (set) Token: 0x06000660 RID: 1632 RVA: 0x00039036 File Offset: 0x00037236
		Friend Overridable Property Label20 As Label

		' Token: 0x1700027A RID: 634
		' (get) Token: 0x06000661 RID: 1633 RVA: 0x0003903F File Offset: 0x0003723F
		' (set) Token: 0x06000662 RID: 1634 RVA: 0x00039049 File Offset: 0x00037249
		Friend Overridable Property Label21 As Label

		' Token: 0x1700027B RID: 635
		' (get) Token: 0x06000663 RID: 1635 RVA: 0x00039052 File Offset: 0x00037252
		' (set) Token: 0x06000664 RID: 1636 RVA: 0x0003905C File Offset: 0x0003725C
		Friend Overridable Property Label18 As Label

		' Token: 0x1700027C RID: 636
		' (get) Token: 0x06000665 RID: 1637 RVA: 0x00039065 File Offset: 0x00037265
		' (set) Token: 0x06000666 RID: 1638 RVA: 0x0003906F File Offset: 0x0003726F
		Friend Overridable Property Label19 As Label

		' Token: 0x06000667 RID: 1639 RVA: 0x00039078 File Offset: 0x00037278
		Public Sub New()
			AddHandler MyBase.Shown, AddressOf Me.Me_Shown
			AddHandler MyBase.FormClosing, AddressOf Me.UserMstr_FormClosing
			AddHandler MyBase.Load, AddressOf Me.UserMstr_Load
			Me.bIsPwdValid = False
			Me.InitializeComponent()
			Me.pnlBasicDefaultHeight = Me.GbBasic.Height
			Me.pnlBasicSetHeight = 23
			Me.pnlAdvDefaultHeight = 23
			Me.pnlAdvSetHeight = Me.GbAdvanced.Height
		End Sub

		' Token: 0x06000668 RID: 1640 RVA: 0x00039108 File Offset: 0x00037308
		Private Sub SetSearchPanel()
			Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
			Me.GbBasic.Height = Me.pnlBasicDefaultHeight
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
		End Sub

		' Token: 0x06000669 RID: 1641 RVA: 0x0003915C File Offset: 0x0003735C
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

		' Token: 0x0600066A RID: 1642 RVA: 0x000391CC File Offset: 0x000373CC
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

		' Token: 0x0600066B RID: 1643 RVA: 0x0003923C File Offset: 0x0003743C
		Private Sub Me_Shown(sender As Object, e As EventArgs)
			Me.SetTabs()
		End Sub

		' Token: 0x0600066C RID: 1644 RVA: 0x00039248 File Offset: 0x00037448
		Private Sub SetTabs()
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = CInt(Math.Round(CDbl((Me.theme_tc.Width - 4)) / 2.0))
			Me.theme_tc.ItemSize = New Size(num, 30)
			Me.tab_lblDetails.Width = num
			Me.tab_lblList.Width = num + 3
			Me.tab_lblDetails.Location = New Point(0, 0)
			Me.tab_lblList.Location = New Point(num - 4, 0)
		End Sub

		' Token: 0x0600066D RID: 1645 RVA: 0x000392D0 File Offset: 0x000374D0
		Private Sub UserMstr_FormClosing(sender As Object, e As FormClosingEventArgs)
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

		' Token: 0x0600066E RID: 1646 RVA: 0x00039368 File Offset: 0x00037568
		Private Sub UserMstr_Load(sender As Object, e As EventArgs)
			Me.SetSearchPanel()
			Designing.SetTheme(Me)
			Me.ClearForm()
			Me.ClearList()
			Me.FillCombo()
			Me.SetAccess("DISABLE")
			Me.sStatus = "LOAD"
			Me.SetButtonStatus()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x0600066F RID: 1647 RVA: 0x000393D0 File Offset: 0x000375D0
		Private Sub FillCombo()
			Dim text As String = " SELECT UserGroupID, UserGroup FROM UserGroup"
			text += " WHERE (IsActive = 1)"
			Dim flag As Boolean = Operators.CompareString(GlobalVariables.gsUserGroup, "Super Admin", False) <> 0
			If flag Then
				text += " AND UserGroup <> 'Super Admin'"
			End If
			text += " ORDER BY UserGroup"
			Dim data As DataTable = MainModule.GetData(text)
			Dim data2 As DataTable = MainModule.GetData(text)
			Me.cmbGroup.ValueMember = "UserGroupID"
			Me.cmbGroup.DisplayMember = "UserGroup"
			Me.cmbGroup.DataSource = data
			Me.cmbGroup.SelectedIndex = -1
			Me.cmbSGroup.ValueMember = "UserGroupID"
			Me.cmbSGroup.DisplayMember = "UserGroup"
			Me.cmbSGroup.DataSource = data2
			Me.cmbSGroup.SelectedIndex = -1
			text = "SELECT PlantID, Plant FROM Plant ORDER BY Plant"
			Dim data3 As DataTable = MainModule.GetData(text)
			Dim data4 As DataTable = MainModule.GetData(text)
			Me.cmbPlant.ValueMember = "PlantID"
			Me.cmbPlant.DisplayMember = "Plant"
			Me.cmbPlant.DataSource = data3
			Me.cmbPlant.SelectedValue = GlobalVariables.gsPlantID
			Me.cmbSPlant.ValueMember = "PlantID"
			Me.cmbSPlant.DisplayMember = "Plant"
			Me.cmbSPlant.DataSource = data3
			Me.cmbSPlant.SelectedValue = GlobalVariables.gsPlantID
			text = "SELECT DISTINCT Designation FROM [User] ORDER BY Designation"
			Dim data5 As DataTable = MainModule.GetData(text)
			Me.cmbDesignation.ValueMember = "Designation"
			Me.cmbDesignation.DisplayMember = "Designation"
			Me.cmbDesignation.DataSource = data5
			Me.cmbDesignation.Text = ""
			text = "SELECT DISTINCT Department FROM [User] ORDER BY Department"
			Dim data6 As DataTable = MainModule.GetData(text)
			Me.cmbDepartment.ValueMember = "Department"
			Me.cmbDepartment.DisplayMember = "Department"
			Me.cmbDepartment.DataSource = data6
			Me.cmbDepartment.Text = ""
			Me.FillManager()
		End Sub

		' Token: 0x06000670 RID: 1648 RVA: 0x000395E4 File Offset: 0x000377E4
		Private Sub FillManager()
			Dim text As String = " SELECT UserID, UserName FROM [User] WHERE 1=1 "
			text += " ORDER BY UserName"
			Dim data As DataTable = MainModule.GetData(text)
			Me.cmbManager.ValueMember = "UserID"
			Me.cmbManager.DisplayMember = "UserName"
			Me.cmbManager.DataSource = data
			Me.cmbManager.SelectedIndex = -1
			text = " SELECT UserID, UserName FROM [User] WHERE 1=1 "
			text += " ORDER BY UserName"
			Dim data2 As DataTable = MainModule.GetData(text)
			Me.cmbReporting.ValueMember = "UserID"
			Me.cmbReporting.DisplayMember = "UserName"
			Me.cmbReporting.DataSource = data2
			Me.cmbReporting.SelectedIndex = -1
		End Sub

		' Token: 0x06000671 RID: 1649 RVA: 0x0003969C File Offset: 0x0003789C
		Private Sub SetForm()
			Dim flag As Boolean = Operators.CompareString(GlobalVariables.gsUserGroup, "Admin", False) = 0
			If flag Then
				Me.chkIsLocked.Visible = True
			Else
				Me.chkIsLocked.Visible = False
			End If
		End Sub

		' Token: 0x06000672 RID: 1650 RVA: 0x000396E0 File Offset: 0x000378E0
		Private Sub SetAccess(sAccess As String)
			If Operators.CompareString(sAccess, "ENABLE", False) <> 0 Then
				If Operators.CompareString(sAccess, "DISABLE", False) = 0 Then
					Me.txtID.[ReadOnly] = True
					Me.txtUserName.[ReadOnly] = True
					Me.txtLogin.[ReadOnly] = True
					Me.txtPass.[ReadOnly] = True
					Me.cmbDesignation.Enabled = False
					Me.cmbDepartment.Enabled = False
					Me.cmbManager.Enabled = False
					Me.cmbReporting.Enabled = False
					Me.txtEmailID.[ReadOnly] = True
					Me.cmbPlant.Enabled = False
					Me.cmbGroup.Enabled = False
					Me.chkIsActive.Enabled = False
					Me.chkIsLocked.Enabled = False
				End If
			Else
				Me.txtID.[ReadOnly] = False
				Me.txtUserName.[ReadOnly] = False
				Me.txtLogin.[ReadOnly] = False
				Me.txtPass.[ReadOnly] = False
				Me.cmbDesignation.Enabled = True
				Me.cmbDepartment.Enabled = True
				Me.cmbManager.Enabled = True
				Me.cmbReporting.Enabled = True
				Me.txtEmailID.[ReadOnly] = False
				Dim flag As Boolean = Operators.CompareString(GlobalVariables.gsUserGroup, "Super Admin", False) = 0
				If flag Then
					Me.cmbPlant.Enabled = True
				End If
				Me.cmbGroup.Enabled = True
				Me.chkIsActive.Enabled = True
				Dim flag2 As Boolean = (Operators.CompareString(GlobalVariables.gsUserGroup, "Super Admin", False) = 0) Or (Operators.CompareString(GlobalVariables.gsUserGroup, "Admin", False) = 0)
				If flag2 Then
					Me.chkIsLocked.Enabled = True
				End If
			End If
		End Sub

		' Token: 0x06000673 RID: 1651 RVA: 0x000398B8 File Offset: 0x00037AB8
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

		' Token: 0x06000674 RID: 1652 RVA: 0x00039A38 File Offset: 0x00037C38
		Private Sub ClearForm()
			Me.txtID.Text = ""
			Me.txtUserName.Text = ""
			Me.txtLogin.Text = ""
			Me.txtPass.Text = ""
			Me.cmbDesignation.Text = ""
			Me.cmbDepartment.Text = ""
			Me.cmbManager.SelectedIndex = -1
			Me.cmbReporting.SelectedIndex = -1
			Me.txtEmailID.Text = ""
			Me.lblStrength.Text = "."
			Me.cmbPlant.SelectedValue = GlobalVariables.gsPlantID
			Me.cmbGroup.SelectedIndex = -1
			Me.chkIsActive.Checked = False
			Me.chkIsLocked.Checked = False
			Me.txtSessionState.Text = ""
			Me.txtSessionState.BackColor = Color.White
			Me.txtSessionState.ForeColor = Color.Black
			Me.btnLogoff.Enabled = False
			Me.FillManager()
			Me.SetAccess("DISABLE")
		End Sub

		' Token: 0x06000675 RID: 1653 RVA: 0x00039B74 File Offset: 0x00037D74
		Private Sub ClearList()
			Me.lblSDate.SelectedIndex = 0
			Me.lblSCreated.SelectedIndex = 0
			Me.txtSUserName.Text = ""
			Me.txtSCreated.Text = ""
			Me.txtSLogin.Text = ""
			Me.cmbSGroup.SelectedIndex = -1
			Me.cmbSGroup.Text = ""
			Me.cmbStatus.SelectedIndex = 0
			Me.cmbIsLocked.SelectedIndex = 0
			Me.cmbPlant.SelectedIndex = -1
			Me.dtpFrom.Value = DateAndTime.Now
			Me.dtpTo.Value = DateAndTime.Now
			Me.dtpFrom.Checked = False
			Me.dtpTo.Checked = False
			Me.lblRows.Text = "0 - Rows"
			Me.dgvList.DataSource = Nothing
		End Sub

		' Token: 0x06000676 RID: 1654 RVA: 0x00039C6E File Offset: 0x00037E6E
		Private Sub btnClear_Click(sender As Object, e As EventArgs)
			Me.ClearForm()
			Me.sStatus = "LOAD"
			Me.SetButtonStatus()
		End Sub

		' Token: 0x06000677 RID: 1655 RVA: 0x00039C8A File Offset: 0x00037E8A
		Private Sub btnClearList_Click(sender As Object, e As EventArgs)
			Me.ClearList()
		End Sub

		' Token: 0x06000678 RID: 1656 RVA: 0x00039C94 File Offset: 0x00037E94
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06000679 RID: 1657 RVA: 0x00039C9E File Offset: 0x00037E9E
		Private Sub btnExport_Click(sender As Object, e As EventArgs)
			MainModule.ExportToExcel(Me.dgvList, Me.Text)
		End Sub

		' Token: 0x0600067A RID: 1658 RVA: 0x00039CB4 File Offset: 0x00037EB4
		Private Sub btnAdd_Click(sender As Object, e As EventArgs)
			Me.ClearForm()
			Me.SetAccess("ENABLE")
			Me.sStatus = "ADD"
			Me.SetButtonStatus()
			Me.chkIsActive.Checked = True
			Me.txtUserName.Focus()
		End Sub

		' Token: 0x0600067B RID: 1659 RVA: 0x00039D00 File Offset: 0x00037F00
		Private Sub btnEdit_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				Me.SetAccess("ENABLE")
				Me.sStatus = "EDIT"
				Me.SetButtonStatus()
			End If
		End Sub

		' Token: 0x0600067C RID: 1660 RVA: 0x00039D4C File Offset: 0x00037F4C
		Private Sub cmbGroup_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbGroup.SelectedIndex = -1
			If flag Then
				Me.cmbGroup.Text = ""
			End If
		End Sub

		' Token: 0x0600067D RID: 1661 RVA: 0x00039D80 File Offset: 0x00037F80
		Private Sub cmbSGroup_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbSGroup.SelectedIndex = -1
			If flag Then
				Me.cmbSGroup.Text = ""
			End If
		End Sub

		' Token: 0x0600067E RID: 1662 RVA: 0x00039DB4 File Offset: 0x00037FB4
		Private Sub cmbPlant_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbPlant.SelectedIndex = -1
			If flag Then
				Me.cmbPlant.Text = ""
			End If
		End Sub

		' Token: 0x0600067F RID: 1663 RVA: 0x00039DE8 File Offset: 0x00037FE8
		Private Sub cmbSPlant_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbSPlant.SelectedIndex = -1
			If flag Then
				Me.cmbSPlant.Text = ""
			End If
		End Sub

		' Token: 0x06000680 RID: 1664 RVA: 0x00039E1C File Offset: 0x0003801C
		Private Sub cmbManager_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbManager.SelectedIndex = -1
			If flag Then
				Me.cmbManager.Text = ""
			End If
		End Sub

		' Token: 0x06000681 RID: 1665 RVA: 0x00039E50 File Offset: 0x00038050
		Private Sub cmbReporting_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbReporting.SelectedIndex = -1
			If flag Then
				Me.cmbReporting.Text = ""
			End If
		End Sub

		' Token: 0x06000682 RID: 1666 RVA: 0x00039E84 File Offset: 0x00038084
		Private Sub btnSearch_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SearchData()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06000683 RID: 1667 RVA: 0x00039EF0 File Offset: 0x000380F0
		Private Sub SearchData()
			Dim text As String = ""
			Dim text2 As String = " SELECT U.UserID AS ID, U.UserName, U.LoginID, U.Password, P.Plant, P.PlantID, "
			text2 += " U.Designation, U.Department, U.ManagerID, U.ReportingToID, M.UserName Manager, R.UserName ReportingTo, "
			text2 += " U.EmailID, U.UserGroupID, UG.UserGroup, U.IsActive, U.IsLocked, "
			text2 += " U.SessionState, U.SessionID, U.SessionComputerName, U.SessionIPAddress, "
			text2 += " U.CreationDt, Created.UserName AS CreatedBy, U.ModificationDt, Modified.UserName AS ModifiedBy "
			text2 += " FROM [User] AS U "
			text2 += " INNER JOIN UserGroup AS UG ON U.UserGroupID = UG.UserGroupID "
			text2 += " INNER JOIN Plant AS P ON U.PlantID = P.PlantID "
			text2 += " LEFT JOIN [User] M ON U.ManagerID = M.UserID " & vbCrLf
			text2 += " LEFT JOIN [User] R ON U.ReportingToID = R.UserID " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Modified ON U.ModifiedBy = Modified.UserID "
			text2 += " LEFT OUTER JOIN [User] AS Created ON U.CreatedBy = Created.UserID"
			text2 += " WHERE 1=1"
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.txtSUserName.Text), "", False) <> 0
			If flag Then
				text2 = text2 + " And (U.UserName Like '%" + Strings.Trim(Me.txtSUserName.Text) + "%') "
				text = text + "UserName LIKE " + Strings.Trim(Me.txtSUserName.Text) + vbCrLf
			End If
			Dim flag2 As Boolean = Operators.CompareString(Strings.Trim(Me.txtSLogin.Text), "", False) <> 0
			If flag2 Then
				text2 = text2 + " AND (U.LoginID LIKE '%" + Strings.Trim(Me.txtSLogin.Text) + "%')"
				text = text + "LoginID LIKE " + Strings.Trim(Me.txtSLogin.Text) + vbCrLf
			End If
			Dim flag3 As Boolean = Me.cmbSPlant.SelectedIndex > -1
			If flag3 Then
				text2 = text2 + " AND (P.PlantID = '" + Strings.Trim(Me.cmbSPlant.SelectedValue.ToString()) + "')"
				text = text + "PlantID = " + Strings.Trim(Me.cmbSPlant.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag4 As Boolean = Me.cmbSGroup.SelectedIndex > -1
			If flag4 Then
				text2 = text2 + " AND (U.UserGroupID = '" + Strings.Trim(Me.cmbSGroup.SelectedValue.ToString()) + "')"
				text = text + "UserGroupID = " + Strings.Trim(Me.cmbSGroup.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag5 As Boolean = Me.cmbStatus.SelectedIndex > 0
			If flag5 Then
				Dim flag6 As Boolean = Me.cmbStatus.SelectedIndex = 1
				If flag6 Then
					text2 += " AND (U.IsActive = 1)"
					text += "IsActive = 1" & vbCrLf
				Else
					text2 += " AND (U.IsActive = 0)"
					text += "IsActive = 0" & vbCrLf
				End If
			End If
			Dim flag7 As Boolean = Me.cmbIsLocked.SelectedIndex > 0
			If flag7 Then
				Dim flag8 As Boolean = Me.cmbIsLocked.SelectedIndex = 1
				If flag8 Then
					text2 += " AND (U.IsLocked = 1)"
					text += "IsLocked = 1" & vbCrLf
				Else
					text2 += " AND  (U.IsLocked = 0)"
					text += "IsLocked = 0" & vbCrLf
				End If
			End If
			Dim flag9 As Boolean = Operators.CompareString(Strings.Trim(Me.txtSCreated.Text), "", False) <> 0
			If flag9 Then
				Dim flag10 As Boolean = Me.lblSCreated.SelectedIndex >= 0
				If flag10 Then
					Dim flag11 As Boolean = Me.lblSCreated.SelectedIndex = 0
					Dim text3 As String
					If flag11 Then
						text3 = "Created"
					Else
						text3 = "Modified"
					End If
					text2 = String.Concat(New String() { text2, " AND ", text3, ".UserName LIKE '%", Strings.Trim(Me.txtSCreated.Text), "%'" })
					text = text + (text3 + "By LIKE " + Strings.Trim(Me.txtSCreated.Text)) + vbCrLf
				End If
			End If
			Dim flag12 As Boolean = Me.lblSDate.SelectedIndex >= 0
			If flag12 Then
				Dim flag13 As Boolean = Me.lblSDate.SelectedIndex = 0
				Dim text4 As String
				If flag13 Then
					text4 = "CreationDt"
				Else
					text4 = "ModificationDt"
				End If
				Dim flag14 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
				If flag14 Then
					text2 = String.Concat(New String() { text2, " AND U.", text4, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
					text = text + String.Concat(New String() { text4, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
				Else
					Dim checked As Boolean = Me.dtpFrom.Checked
					If checked Then
						text2 = String.Concat(New String() { text2, " AND U.", text4, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59"), "'" })
						text = text + String.Concat(New String() { text4, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
					End If
					Dim checked2 As Boolean = Me.dtpTo.Checked
					If checked2 Then
						text2 = String.Concat(New String() { text2, " AND U.", text4, " BETWEEN '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
						text = text + String.Concat(New String() { text4, " BETWEEN  ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
					End If
				End If
			End If
			text2 += " ORDER BY U.UserName"
			Dim data As DataTable = MainModule.GetData(text2)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = data
			Me.dgvList.Columns("ID").Visible = False
			Me.dgvList.Columns("SessionID").Visible = False
			Me.dgvList.Columns("PlantID").Visible = False
			Me.dgvList.Columns("Password").Visible = False
			Me.dgvList.Columns("UserGroupID").Visible = False
			Me.dgvList.Columns("Plant").Visible = False
			Me.dgvList.Columns("SessionState").Visible = False
			Me.dgvList.Columns("SessionID").Visible = False
			Me.dgvList.Columns("SessionComputerName").Visible = False
			Me.dgvList.Columns("SessionIPAddress").Visible = False
			Me.dgvList.Columns("ManagerID").Visible = False
			Me.dgvList.Columns("ReportingToID").Visible = False
			Me.dgvList.Columns("UserName").Width = 223
			Me.dgvList.Columns("LoginID").Width = 213
			Me.dgvList.Columns("UserGroup").Width = 249
			Me.dgvList.Columns("Designation").Width = 235
			Me.dgvList.Columns("Department").Width = 235
			Me.dgvList.Columns("Manager").Width = 235
			Me.dgvList.Columns("ReportingTo").Width = 235
			Me.dgvList.Columns("EmailID").Width = 235
			Me.dgvList.Columns("CreationDt").Width = 170
			Me.dgvList.Columns("CreatedBy").Width = 150
			Me.dgvList.Columns("ModificationDt").Width = 170
			Me.dgvList.Columns("ModifiedBy").Width = 150
			Me.dgvList.Columns("CreationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			Me.dgvList.Columns("ModificationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			Me.dgvList.Columns("UserName").HeaderText = "User Name"
			Me.dgvList.Columns("LoginID").HeaderText = "Login ID"
			Me.dgvList.Columns("Password").HeaderText = "Password"
			Me.dgvList.Columns("ReportingTo").HeaderText = "Reporting To"
			Me.dgvList.Columns("UserGroup").HeaderText = "User Group"
			Me.dgvList.Columns("EmailID").HeaderText = "Email ID"
			Me.dgvList.Columns("IsActive").HeaderText = "Is Active"
			Me.dgvList.Columns("IsLocked").HeaderText = "Is Locked"
			Me.dgvList.Columns("CreationDt").HeaderText = "Creation Date"
			Me.dgvList.Columns("CreatedBy").HeaderText = "Created By"
			Me.dgvList.Columns("ModificationDt").HeaderText = "Modification Date"
			Me.dgvList.Columns("ModifiedBy").HeaderText = "Modified By"
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x06000684 RID: 1668 RVA: 0x0003AAEC File Offset: 0x00038CEC
		Private Sub dgvList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = (Operators.CompareString(Me.sStatus, "ADD", False) <> 0) And (Operators.CompareString(Me.sStatus, "EDIT", False) <> 0)
			If flag Then
				Dim flag2 As Boolean = e.RowIndex > -1
				If flag2 Then
					Me.FillData(Me.dgvList.Rows(e.RowIndex).Cells("ID").Value.ToString())
					Me.theme_tc.SelectedTab = Me.tpDetails
					Me.sStatus = "VIEW"
					Me.SetButtonStatus()
					MainModule.TrnLog(Me.Text, "Entry Selected", "Selected ID: " + Me.dgvList.Rows(e.RowIndex).Cells("ID").Value.ToString(), Nothing)
				End If
			End If
		End Sub

		' Token: 0x06000685 RID: 1669 RVA: 0x0003ABE4 File Offset: 0x00038DE4
		Private Sub FillData(sID As String)
			Dim dataTable As DataTable = CType(Me.dgvList.DataSource, DataTable)
			Dim flag As Boolean = (Operators.CompareString(sID, "", False) <> 0) And (dataTable.Rows.Count > 0)
			If flag Then
				Dim flag2 As Boolean = dataTable.[Select]("ID='" + sID + "'").Length > 0
				If flag2 Then
					Dim dataRow As DataRow = dataTable.[Select]("ID='" + sID + "'")(0)
					Me.txtID.Text = dataRow("ID").ToString()
					Me.FillManager()
					Me.txtUserName.Text = dataRow("UserName").ToString()
					Me.txtLogin.Text = dataRow("LoginID").ToString()
					Me.txtPass.Text = MainModule.Decrypt(dataRow("Password").ToString(), GlobalVariables.gsPwd)
					Me.cmbDesignation.Text = dataRow("Designation").ToString()
					Me.cmbDepartment.Text = dataRow("Department").ToString()
					Dim flag3 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("ManagerID")))
					If flag3 Then
						Me.cmbManager.SelectedValue = RuntimeHelpers.GetObjectValue(dataRow("ManagerID"))
					Else
						Me.cmbManager.SelectedIndex = -1
					End If
					Dim flag4 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("ReportingToID")))
					If flag4 Then
						Me.cmbReporting.SelectedValue = RuntimeHelpers.GetObjectValue(dataRow("ReportingToID"))
					Else
						Me.cmbReporting.SelectedIndex = -1
					End If
					Me.txtEmailID.Text = dataRow("EmailID").ToString()
					Me.cmbPlant.SelectedValue = dataRow("PlantID").ToString()
					Me.cmbGroup.SelectedValue = dataRow("UserGroupID").ToString()
					Dim flag5 As Boolean = Operators.ConditionalCompareObjectEqual(dataRow("IsActive"), True, False)
					If flag5 Then
						Me.chkIsActive.Checked = True
					Else
						Me.chkIsActive.Checked = False
					End If
					Dim flag6 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("IsLocked")))
					If flag6 Then
						Dim flag7 As Boolean = Operators.ConditionalCompareObjectEqual(dataRow("IsLocked"), True, False)
						If flag7 Then
							Me.chkIsLocked.Checked = True
						Else
							Me.chkIsLocked.Checked = False
						End If
					End If
					Me.txtSessionID.Text = dataRow("SessionID").ToString()
					Me.txtComputerName.Text = dataRow("SessionComputerName").ToString()
					Me.txtIPAddress.Text = dataRow("SessionIPAddress").ToString()
					Me.txtSessionState.Text = "In-Active"
					Me.txtSessionState.BackColor = Color.White
					Me.txtSessionState.ForeColor = Color.Black
					Me.btnLogoff.Enabled = False
					Dim flag8 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("SessionState")))
					If flag8 Then
						Dim flag9 As Boolean = Operators.ConditionalCompareObjectEqual(dataRow("SessionState"), True, False)
						If flag9 Then
							Me.txtSessionState.Text = "Active"
							Me.txtSessionState.BackColor = Color.ForestGreen
							Me.txtSessionState.ForeColor = Color.White
							Me.btnLogoff.Enabled = True
						End If
					End If
					Me.CheckStrength()
				End If
			End If
		End Sub

		' Token: 0x06000686 RID: 1670 RVA: 0x0003AFC0 File Offset: 0x000391C0
		Private Function ValidateForm() As Boolean
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.txtUserName.Text), "", False) = 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Enter User Name.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.txtUserName.Focus()
				flag2 = False
			Else
				Dim flag3 As Boolean = Operators.CompareString(Strings.Trim(Me.txtLogin.Text), "", False) = 0
				If flag3 Then
					CustomMsgBox.Show("Enter Login ID.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.txtLogin.Focus()
					flag2 = False
				Else
					Dim flag4 As Boolean = Operators.CompareString(Strings.Trim(Me.txtPass.Text), "", False) = 0
					If flag4 Then
						CustomMsgBox.Show("Enter Password.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.txtPass.Focus()
						flag2 = False
					Else
						Dim flag5 As Boolean = Operators.CompareString(Strings.Trim(Me.cmbDesignation.Text), "", False) = 0
						If flag5 Then
							CustomMsgBox.Show("Select/ Enter Designation.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.cmbDesignation.Focus()
							flag2 = False
						Else
							Dim flag6 As Boolean = Operators.CompareString(Strings.Trim(Me.cmbDepartment.Text), "", False) = 0
							If flag6 Then
								CustomMsgBox.Show("Select/ Enter Department.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								Me.cmbDepartment.Focus()
								flag2 = False
							Else
								Dim flag7 As Boolean = Me.cmbManager.SelectedIndex = -1
								If flag7 Then
									CustomMsgBox.Show("Select Manager.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
									Me.cmbManager.Focus()
									flag2 = False
								Else
									Dim flag8 As Boolean = Me.cmbReporting.SelectedIndex = -1
									If flag8 Then
										CustomMsgBox.Show("Select Reporting To.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
										Me.cmbReporting.Focus()
										flag2 = False
									Else
										Dim flag9 As Boolean = Operators.CompareString(Strings.Trim(Me.txtEmailID.Text), "", False) = 0
										If flag9 Then
											CustomMsgBox.Show("Enter EmailID.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
											Me.txtEmailID.Focus()
											flag2 = False
										Else
											Dim flag10 As Boolean = Not MainModule.IsValidEmailFormat(Me.txtEmailID.Text)
											If flag10 Then
												CustomMsgBox.Show("Invalid Email ID.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
												Me.txtEmailID.Focus()
												flag2 = False
											Else
												Dim flag11 As Boolean = (Operators.CompareString(Strings.Trim(Me.txtPass.Text), "", False) = 0) Or Not Me.bIsPwdValid
												If flag11 Then
													Dim text As String = ""
													text += "Enter Valid Password" & vbCrLf
													text = text + "Password length must be more than " + Conversions.ToString(FeaturesVariables.gsPassword_Length) + vbCrLf
													text += "Password must have combination of letters, numbers and/or special characters"
													CustomMsgBox.Show(text, "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
													Me.txtPass.Focus()
													flag2 = False
												Else
													Dim flag12 As Boolean = Me.cmbPlant.SelectedIndex = -1
													If flag12 Then
														CustomMsgBox.Show("Select Client/ Plant.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
														Me.cmbPlant.Focus()
														flag2 = False
													Else
														Dim flag13 As Boolean = Me.cmbGroup.SelectedIndex = -1
														If flag13 Then
															CustomMsgBox.Show("Select User Group.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
															Me.cmbGroup.Focus()
															flag2 = False
														Else
															Dim text2 As String = " SELECT UserID, LoginID FROM [User]"
															text2 = text2 + " WHERE (LoginID = '" + Strings.Trim(Me.txtLogin.Text) + "') "
															Dim flag14 As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
															If flag14 Then
																text2 = text2 + " AND UserID<>'" + Me.txtID.Text + "'"
															End If
															Dim data As DataTable = MainModule.GetData(text2)
															Dim flag15 As Boolean = data.Rows.Count > 0
															If flag15 Then
																Dim flag16 As Boolean = data.[Select]("LoginID='" + Strings.Trim(Me.txtLogin.Text) + "'").Length > 0
																If flag16 Then
																	CustomMsgBox.Show("LoginID Already Exists.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
																	Me.txtLogin.Focus()
																	Return False
																End If
															End If
															flag2 = True
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			End If
			Return flag2
		End Function

		' Token: 0x06000687 RID: 1671 RVA: 0x0003B428 File Offset: 0x00039628
		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.Save()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06000688 RID: 1672 RVA: 0x0003B494 File Offset: 0x00039694
		Private Sub Save()
			Dim flag As Boolean = CustomMsgBox.Show("Save..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
			If flag Then
				Dim flag2 As Boolean = Not Me.ValidateForm()
				If Not flag2 Then
					Dim flag3 As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
					If flag3 Then
						Me.UpdateData()
						EmailModule.SendMail("User Database", Me.txtID.Text, "Modified", "")
					Else
						Me.InsertData()
						EmailModule.SendMail("User Database", Me.txtID.Text, "Created", "")
						EmailModule.SendMail("New User", Me.txtID.Text, "", "")
					End If
				End If
			End If
		End Sub

		' Token: 0x06000689 RID: 1673 RVA: 0x0003B564 File Offset: 0x00039764
		Private Sub InsertData()
			Dim text As String = " INSERT INTO [User](UserName, LoginID, Password, EmailID, PlantID, UserGroupID," & vbCrLf
			text += " Designation, Department, ManagerID, ReportingToID, LastReset, CreationDt, CreatedBy, IsActive, IsLocked) " & vbCrLf
			text = String.Concat(New String() { text, " VALUES ('", Strings.Trim(Me.txtUserName.Text), "', '", Strings.Trim(Me.txtLogin.Text), "', " & vbCrLf })
			text = String.Concat(New String() { text, " '", MainModule.Encrypt(Strings.Trim(Me.txtPass.Text), GlobalVariables.gsPwd), "',  '", Strings.Trim(Me.txtEmailID.Text), "', " & vbCrLf })
			text = String.Concat(New String() { text, " '", Me.cmbPlant.SelectedValue.ToString(), "', '", Me.cmbGroup.SelectedValue.ToString(), "', " & vbCrLf })
			text = String.Concat(New String() { text, " '", Strings.Trim(Me.cmbDesignation.Text), "', '", Strings.Trim(Me.cmbDepartment.Text), "', " & vbCrLf })
			Dim flag As Boolean = Me.cmbManager.SelectedIndex > -1
			If flag Then
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" '", Me.cmbManager.SelectedValue), "', "), vbCrLf)))
			Else
				text += " NULL, " & vbCrLf
			End If
			Dim flag2 As Boolean = Me.cmbReporting.SelectedIndex > -1
			If flag2 Then
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" '", Me.cmbReporting.SelectedValue), "', "), vbCrLf)))
			Else
				text += " NULL, " & vbCrLf
			End If
			text = text + " '" + Strings.Format(Conversions.ToDate("01-Jan-1900"), "MM/dd/yyyy") + "', " & vbCrLf
			text = text + " GETDATE(), '" + GlobalVariables.gsUserID + "'," & vbCrLf
			Dim checked As Boolean = Me.chkIsActive.Checked
			If checked Then
				text += " 1"
			Else
				text += " 0"
			End If
			Dim checked2 As Boolean = Me.chkIsLocked.Checked
			If checked2 Then
				text += " , 1)" & vbCrLf
			Else
				text += " , 0)" & vbCrLf
			End If
			text += " SELECT SCOPE_IDENTITY() AS ID"
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag3 As Boolean = data.Rows.Count > 0
			If flag3 Then
				Me.txtID.Text = Conversions.ToString(data.Rows(0)("ID"))
				MainModule.TrnLog(Me.Text, "Created", "New ID: " + Me.txtID.Text, Nothing)
				CustomMsgBox.Show("User Added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Me.SetAccess("DISABLE")
				Me.sStatus = "SAVE"
				Me.SetButtonStatus()
			End If
		End Sub

		' Token: 0x0600068A RID: 1674 RVA: 0x0003B8C0 File Offset: 0x00039AC0
		Private Sub UpdateData()
			Dim text As String = String.Concat(New String() { " UPDATE [User] SET UserName ='", Strings.Trim(Me.txtUserName.Text), "', LoginID ='", Strings.Trim(Me.txtLogin.Text), "', " & vbCrLf })
			text = String.Concat(New String() { text, " Password ='", MainModule.Encrypt(Strings.Trim(Me.txtPass.Text), GlobalVariables.gsPwd), "', EmailID ='", Strings.Trim(Me.txtEmailID.Text), "', " & vbCrLf })
			text = String.Concat(New String() { text, " PlantID ='", Me.cmbPlant.SelectedValue.ToString(), "', UserGroupID ='", Me.cmbGroup.SelectedValue.ToString(), "', " & vbCrLf })
			text = text + " Designation = '" + Strings.Trim(Me.cmbDesignation.Text) + "', "
			text = text + " Department = '" + Strings.Trim(Me.cmbDepartment.Text) + "', " & vbCrLf
			Dim flag As Boolean = Me.cmbManager.SelectedIndex > -1
			If flag Then
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" ManagerID = '", Me.cmbManager.SelectedValue), "', "), vbCrLf)))
			Else
				text += " ManagerID = NULL, " & vbCrLf
			End If
			Dim flag2 As Boolean = Me.cmbReporting.SelectedIndex > -1
			If flag2 Then
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" ReportingToID = '", Me.cmbReporting.SelectedValue), "', "), vbCrLf)))
			Else
				text += " ReportingToID = NULL, " & vbCrLf
			End If
			text = text + " ModificationDt =GETDATE(), ModifiedBy ='" + GlobalVariables.gsUserID + "'," & vbCrLf
			Dim checked As Boolean = Me.chkIsActive.Checked
			If checked Then
				text += " IsActive =1"
			Else
				text += " IsActive =0"
			End If
			Dim checked2 As Boolean = Me.chkIsLocked.Checked
			If checked2 Then
				text += " , IsLocked =1"
			Else
				text += " , IsLocked =0, Attempts =0 "
			End If
			text = text + " WHERE UserID  = '" + Me.txtID.Text + "'"
			Dim flag3 As Boolean = MainModule.ExecuteSQL(text) = 1
			If flag3 Then
				MainModule.TrnLog(Me.Text, "Modified", "Modified ID: " + Me.txtID.Text, Nothing)
				CustomMsgBox.Show("User Modified.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Me.SetAccess("DISABLE")
				Me.sStatus = "SAVE"
				Me.SetButtonStatus()
			End If
		End Sub

		' Token: 0x0600068B RID: 1675 RVA: 0x0003BBA8 File Offset: 0x00039DA8
		Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = e.KeyCode = Keys.Space
			If flag Then
				e.SuppressKeyPress = True
			End If
		End Sub

		' Token: 0x0600068C RID: 1676 RVA: 0x0003BBCE File Offset: 0x00039DCE
		Private Sub txtPass_KeyUp(sender As Object, e As KeyEventArgs)
			Me.CheckStrength()
		End Sub

		' Token: 0x0600068D RID: 1677 RVA: 0x0003BBD8 File Offset: 0x00039DD8
		Private Sub CheckStrength()
			Dim text As String = Me.txtPass.Text.Trim()
			Dim flag As Boolean = False
			Dim flag2 As Boolean = False
			Dim flag3 As Boolean = False
			Dim flag4 As Boolean = text.Length > 0
			If flag4 Then
				Dim flag5 As Boolean = text.Length < Convert.ToInt32(FeaturesVariables.gsPassword_Length)
				If flag5 Then
					Me.bIsPwdValid = False
					Me.lblStrength.Text = "Invalid"
					Me.lblStrength.ForeColor = Color.Red
				Else
					Dim num As Integer = text.Length - 1
					For i As Integer = 0 To num
						Dim c As Char = Convert.ToChar(text.Substring(i, 1))
						Dim flag6 As Boolean = Char.IsNumber(c)
						If flag6 Then
							flag = True
						Else
							Dim flag7 As Boolean = Char.IsLetter(c)
							If flag7 Then
								flag2 = True
							Else
								Dim flag8 As Boolean = Char.IsSymbol(c) OrElse Char.IsPunctuation(c)
								If flag8 Then
									flag3 = True
								End If
							End If
						End If
					Next
					Dim flag9 As Boolean = Not flag And Not flag2 And Not flag3
					If flag9 Then
						Me.bIsPwdValid = False
						Me.lblStrength.Text = ""
						Me.lblStrength.ForeColor = Color.Black
					Else
						Dim flag10 As Boolean = (Not flag And Not flag2) AndAlso flag3
						If flag10 Then
							Me.bIsPwdValid = False
							Me.lblStrength.Text = "Weak"
							Me.lblStrength.ForeColor = Color.Orange
						Else
							Dim flag11 As Boolean = (Not flag AndAlso flag2) And Not flag3
							If flag11 Then
								Me.bIsPwdValid = False
								Me.lblStrength.Text = "Weak"
								Me.lblStrength.ForeColor = Color.Orange
							Else
								Dim flag12 As Boolean = Not flag AndAlso flag2 AndAlso flag3
								If flag12 Then
									Me.bIsPwdValid = True
									Me.lblStrength.Text = "Good"
									Me.lblStrength.ForeColor = Color.LightGreen
								Else
									Dim flag13 As Boolean = flag And Not flag2 And Not flag3
									If flag13 Then
										Me.bIsPwdValid = False
										Me.lblStrength.Text = "Weak"
										Me.lblStrength.ForeColor = Color.Orange
									Else
										Dim flag14 As Boolean = (flag And Not flag2) AndAlso flag3
										If flag14 Then
											Me.bIsPwdValid = True
											Me.lblStrength.Text = "Good"
											Me.lblStrength.ForeColor = Color.LightGreen
										Else
											Dim flag15 As Boolean = (flag AndAlso flag2) And Not flag3
											If flag15 Then
												Me.bIsPwdValid = True
												Me.lblStrength.Text = "Good"
												Me.lblStrength.ForeColor = Color.LightGreen
											Else
												Dim flag16 As Boolean = flag AndAlso flag2 AndAlso flag3
												If flag16 Then
													Me.bIsPwdValid = True
													Me.lblStrength.Text = "Strong"
													Me.lblStrength.ForeColor = Color.DarkGreen
												End If
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			Else
				Me.bIsPwdValid = False
				Me.lblStrength.Text = ""
				Me.lblStrength.ForeColor = Color.Black
			End If
		End Sub

		' Token: 0x0600068E RID: 1678 RVA: 0x0003BEDC File Offset: 0x0003A0DC
		Private Sub btnLogoff_Click(sender As Object, e As EventArgs)
			Try
				Me.LogOffSession()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x0600068F RID: 1679 RVA: 0x0003BF34 File Offset: 0x0003A134
		Private Sub LogOffSession()
			Dim text As String = "This will logoff the user session." & vbCrLf
			text += "Any work in progress will be lost and cannot be recovered."
			text += "Are you sure you want to proceed..?"
			Dim flag As Boolean = CustomMsgBox.Show(text, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes
			If flag Then
				Dim text2 As String = " UPDATE [User] SET SessionState=0, SessionID='', SessionComputerName='', SessionIPAddress=''"
				text2 = text2 + " WHERE UserID = '" + Me.txtID.Text + "'"
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text2) = 1
				If flag2 Then
					Me.txtComputerName.Text = ""
					Me.txtIPAddress.Text = ""
					Me.txtSessionID.Text = ""
					Me.txtSessionState.Text = "In-Active"
					Me.txtSessionState.BackColor = Color.White
					Me.txtSessionState.ForeColor = Color.Black
					Me.btnLogoff.Enabled = False
				End If
			End If
		End Sub

		' Token: 0x040002B1 RID: 689
		Private sStatus As String

		' Token: 0x040002B2 RID: 690
		Private bIsPwdValid As Boolean

		' Token: 0x040002B3 RID: 691
		Private pnlBasicDefaultHeight As Integer

		' Token: 0x040002B4 RID: 692
		Private pnlBasicSetHeight As Integer

		' Token: 0x040002B5 RID: 693
		Private pnlAdvDefaultHeight As Integer

		' Token: 0x040002B6 RID: 694
		Private pnlAdvSetHeight As Integer
	End Class
End Namespace
