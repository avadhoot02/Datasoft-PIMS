Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports WeifenLuo.WinFormsUI.Docking

Namespace Datasoft_PIMS
	' Token: 0x02000052 RID: 82
	<DesignerGenerated()>
	Public Partial Class Product01
		Inherits DockContent

		' Token: 0x1700055A RID: 1370
		' (get) Token: 0x06000E5E RID: 3678 RVA: 0x00087AEB File Offset: 0x00085CEB
		' (set) Token: 0x06000E5F RID: 3679 RVA: 0x00087AF8 File Offset: 0x00085CF8
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

		' Token: 0x1700055B RID: 1371
		' (get) Token: 0x06000E60 RID: 3680 RVA: 0x00087B3B File Offset: 0x00085D3B
		' (set) Token: 0x06000E61 RID: 3681 RVA: 0x00087B45 File Offset: 0x00085D45
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x1700055C RID: 1372
		' (get) Token: 0x06000E62 RID: 3682 RVA: 0x00087B4E File Offset: 0x00085D4E
		' (set) Token: 0x06000E63 RID: 3683 RVA: 0x00087B58 File Offset: 0x00085D58
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

		' Token: 0x1700055D RID: 1373
		' (get) Token: 0x06000E64 RID: 3684 RVA: 0x00087B9B File Offset: 0x00085D9B
		' (set) Token: 0x06000E65 RID: 3685 RVA: 0x00087BA8 File Offset: 0x00085DA8
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

		' Token: 0x1700055E RID: 1374
		' (get) Token: 0x06000E66 RID: 3686 RVA: 0x00087BEB File Offset: 0x00085DEB
		' (set) Token: 0x06000E67 RID: 3687 RVA: 0x00087BF5 File Offset: 0x00085DF5
		Friend Overridable Property Label39 As Label

		' Token: 0x1700055F RID: 1375
		' (get) Token: 0x06000E68 RID: 3688 RVA: 0x00087BFE File Offset: 0x00085DFE
		' (set) Token: 0x06000E69 RID: 3689 RVA: 0x00087C08 File Offset: 0x00085E08
		Friend Overridable Property Label24 As Label

		' Token: 0x17000560 RID: 1376
		' (get) Token: 0x06000E6A RID: 3690 RVA: 0x00087C11 File Offset: 0x00085E11
		' (set) Token: 0x06000E6B RID: 3691 RVA: 0x00087C1B File Offset: 0x00085E1B
		Friend Overridable Property Label6 As Label

		' Token: 0x17000561 RID: 1377
		' (get) Token: 0x06000E6C RID: 3692 RVA: 0x00087C24 File Offset: 0x00085E24
		' (set) Token: 0x06000E6D RID: 3693 RVA: 0x00087C2E File Offset: 0x00085E2E
		Friend Overridable Property chkBinning As CheckBox

		' Token: 0x17000562 RID: 1378
		' (get) Token: 0x06000E6E RID: 3694 RVA: 0x00087C37 File Offset: 0x00085E37
		' (set) Token: 0x06000E6F RID: 3695 RVA: 0x00087C41 File Offset: 0x00085E41
		Friend Overridable Property txtCode As TextBox

		' Token: 0x17000563 RID: 1379
		' (get) Token: 0x06000E70 RID: 3696 RVA: 0x00087C4A File Offset: 0x00085E4A
		' (set) Token: 0x06000E71 RID: 3697 RVA: 0x00087C54 File Offset: 0x00085E54
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

		' Token: 0x17000564 RID: 1380
		' (get) Token: 0x06000E72 RID: 3698 RVA: 0x00087C97 File Offset: 0x00085E97
		' (set) Token: 0x06000E73 RID: 3699 RVA: 0x00087CA1 File Offset: 0x00085EA1
		Friend Overridable Property Label29 As Label

		' Token: 0x17000565 RID: 1381
		' (get) Token: 0x06000E74 RID: 3700 RVA: 0x00087CAA File Offset: 0x00085EAA
		' (set) Token: 0x06000E75 RID: 3701 RVA: 0x00087CB4 File Offset: 0x00085EB4
		Friend Overridable Property Label31 As Label

		' Token: 0x17000566 RID: 1382
		' (get) Token: 0x06000E76 RID: 3702 RVA: 0x00087CBD File Offset: 0x00085EBD
		' (set) Token: 0x06000E77 RID: 3703 RVA: 0x00087CC7 File Offset: 0x00085EC7
		Friend Overridable Property tab_lblDetails As Label

		' Token: 0x17000567 RID: 1383
		' (get) Token: 0x06000E78 RID: 3704 RVA: 0x00087CD0 File Offset: 0x00085ED0
		' (set) Token: 0x06000E79 RID: 3705 RVA: 0x00087CDC File Offset: 0x00085EDC
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

		' Token: 0x17000568 RID: 1384
		' (get) Token: 0x06000E7A RID: 3706 RVA: 0x00087D1F File Offset: 0x00085F1F
		' (set) Token: 0x06000E7B RID: 3707 RVA: 0x00087D29 File Offset: 0x00085F29
		Friend Overridable Property grpListButton As GroupBox

		' Token: 0x17000569 RID: 1385
		' (get) Token: 0x06000E7C RID: 3708 RVA: 0x00087D32 File Offset: 0x00085F32
		' (set) Token: 0x06000E7D RID: 3709 RVA: 0x00087D3C File Offset: 0x00085F3C
		Friend Overridable Property lblRows As Label

		' Token: 0x1700056A RID: 1386
		' (get) Token: 0x06000E7E RID: 3710 RVA: 0x00087D45 File Offset: 0x00085F45
		' (set) Token: 0x06000E7F RID: 3711 RVA: 0x00087D4F File Offset: 0x00085F4F
		Friend Overridable Property tpList As TabPage

		' Token: 0x1700056B RID: 1387
		' (get) Token: 0x06000E80 RID: 3712 RVA: 0x00087D58 File Offset: 0x00085F58
		' (set) Token: 0x06000E81 RID: 3713 RVA: 0x00087D62 File Offset: 0x00085F62
		Friend Overridable Property GbAdvanced As GroupBox

		' Token: 0x1700056C RID: 1388
		' (get) Token: 0x06000E82 RID: 3714 RVA: 0x00087D6B File Offset: 0x00085F6B
		' (set) Token: 0x06000E83 RID: 3715 RVA: 0x00087D75 File Offset: 0x00085F75
		Friend Overridable Property cmbSType As ComboBox

		' Token: 0x1700056D RID: 1389
		' (get) Token: 0x06000E84 RID: 3716 RVA: 0x00087D7E File Offset: 0x00085F7E
		' (set) Token: 0x06000E85 RID: 3717 RVA: 0x00087D88 File Offset: 0x00085F88
		Friend Overridable Property cmbStatus As ComboBox

		' Token: 0x1700056E RID: 1390
		' (get) Token: 0x06000E86 RID: 3718 RVA: 0x00087D91 File Offset: 0x00085F91
		' (set) Token: 0x06000E87 RID: 3719 RVA: 0x00087D9B File Offset: 0x00085F9B
		Friend Overridable Property Label13 As Label

		' Token: 0x1700056F RID: 1391
		' (get) Token: 0x06000E88 RID: 3720 RVA: 0x00087DA4 File Offset: 0x00085FA4
		' (set) Token: 0x06000E89 RID: 3721 RVA: 0x00087DAE File Offset: 0x00085FAE
		Friend Overridable Property Label7 As Label

		' Token: 0x17000570 RID: 1392
		' (get) Token: 0x06000E8A RID: 3722 RVA: 0x00087DB7 File Offset: 0x00085FB7
		' (set) Token: 0x06000E8B RID: 3723 RVA: 0x00087DC1 File Offset: 0x00085FC1
		Friend Overridable Property txtSCreated As TextBox

		' Token: 0x17000571 RID: 1393
		' (get) Token: 0x06000E8C RID: 3724 RVA: 0x00087DCA File Offset: 0x00085FCA
		' (set) Token: 0x06000E8D RID: 3725 RVA: 0x00087DD4 File Offset: 0x00085FD4
		Friend Overridable Property lblSCreated As ComboBox

		' Token: 0x17000572 RID: 1394
		' (get) Token: 0x06000E8E RID: 3726 RVA: 0x00087DDD File Offset: 0x00085FDD
		' (set) Token: 0x06000E8F RID: 3727 RVA: 0x00087DE7 File Offset: 0x00085FE7
		Friend Overridable Property dtpFrom As DateTimePicker

		' Token: 0x17000573 RID: 1395
		' (get) Token: 0x06000E90 RID: 3728 RVA: 0x00087DF0 File Offset: 0x00085FF0
		' (set) Token: 0x06000E91 RID: 3729 RVA: 0x00087DFA File Offset: 0x00085FFA
		Friend Overridable Property dtpTo As DateTimePicker

		' Token: 0x17000574 RID: 1396
		' (get) Token: 0x06000E92 RID: 3730 RVA: 0x00087E03 File Offset: 0x00086003
		' (set) Token: 0x06000E93 RID: 3731 RVA: 0x00087E0D File Offset: 0x0008600D
		Friend Overridable Property Label16 As Label

		' Token: 0x17000575 RID: 1397
		' (get) Token: 0x06000E94 RID: 3732 RVA: 0x00087E16 File Offset: 0x00086016
		' (set) Token: 0x06000E95 RID: 3733 RVA: 0x00087E20 File Offset: 0x00086020
		Friend Overridable Property lblSDate As ComboBox

		' Token: 0x17000576 RID: 1398
		' (get) Token: 0x06000E96 RID: 3734 RVA: 0x00087E29 File Offset: 0x00086029
		' (set) Token: 0x06000E97 RID: 3735 RVA: 0x00087E34 File Offset: 0x00086034
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

		' Token: 0x17000577 RID: 1399
		' (get) Token: 0x06000E98 RID: 3736 RVA: 0x00087E77 File Offset: 0x00086077
		' (set) Token: 0x06000E99 RID: 3737 RVA: 0x00087E81 File Offset: 0x00086081
		Friend Overridable Property GbBasic As GroupBox

		' Token: 0x17000578 RID: 1400
		' (get) Token: 0x06000E9A RID: 3738 RVA: 0x00087E8A File Offset: 0x0008608A
		' (set) Token: 0x06000E9B RID: 3739 RVA: 0x00087E94 File Offset: 0x00086094
		Friend Overridable Property txtSCatalogNo As TextBox

		' Token: 0x17000579 RID: 1401
		' (get) Token: 0x06000E9C RID: 3740 RVA: 0x00087E9D File Offset: 0x0008609D
		' (set) Token: 0x06000E9D RID: 3741 RVA: 0x00087EA7 File Offset: 0x000860A7
		Friend Overridable Property Label37 As Label

		' Token: 0x1700057A RID: 1402
		' (get) Token: 0x06000E9E RID: 3742 RVA: 0x00087EB0 File Offset: 0x000860B0
		' (set) Token: 0x06000E9F RID: 3743 RVA: 0x00087EBA File Offset: 0x000860BA
		Friend Overridable Property txtSName As TextBox

		' Token: 0x1700057B RID: 1403
		' (get) Token: 0x06000EA0 RID: 3744 RVA: 0x00087EC3 File Offset: 0x000860C3
		' (set) Token: 0x06000EA1 RID: 3745 RVA: 0x00087ECD File Offset: 0x000860CD
		Friend Overridable Property Label11 As Label

		' Token: 0x1700057C RID: 1404
		' (get) Token: 0x06000EA2 RID: 3746 RVA: 0x00087ED6 File Offset: 0x000860D6
		' (set) Token: 0x06000EA3 RID: 3747 RVA: 0x00087EE0 File Offset: 0x000860E0
		Friend Overridable Property txtSCode As TextBox

		' Token: 0x1700057D RID: 1405
		' (get) Token: 0x06000EA4 RID: 3748 RVA: 0x00087EE9 File Offset: 0x000860E9
		' (set) Token: 0x06000EA5 RID: 3749 RVA: 0x00087EF3 File Offset: 0x000860F3
		Friend Overridable Property Label14 As Label

		' Token: 0x1700057E RID: 1406
		' (get) Token: 0x06000EA6 RID: 3750 RVA: 0x00087EFC File Offset: 0x000860FC
		' (set) Token: 0x06000EA7 RID: 3751 RVA: 0x00087F08 File Offset: 0x00086108
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

		' Token: 0x1700057F RID: 1407
		' (get) Token: 0x06000EA8 RID: 3752 RVA: 0x00087F4B File Offset: 0x0008614B
		' (set) Token: 0x06000EA9 RID: 3753 RVA: 0x00087F55 File Offset: 0x00086155
		Friend Overridable Property tab_lblList As Label

		' Token: 0x17000580 RID: 1408
		' (get) Token: 0x06000EAA RID: 3754 RVA: 0x00087F5E File Offset: 0x0008615E
		' (set) Token: 0x06000EAB RID: 3755 RVA: 0x00087F68 File Offset: 0x00086168
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

		' Token: 0x17000581 RID: 1409
		' (get) Token: 0x06000EAC RID: 3756 RVA: 0x00087FAB File Offset: 0x000861AB
		' (set) Token: 0x06000EAD RID: 3757 RVA: 0x00087FB8 File Offset: 0x000861B8
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

		' Token: 0x17000582 RID: 1410
		' (get) Token: 0x06000EAE RID: 3758 RVA: 0x00087FFB File Offset: 0x000861FB
		' (set) Token: 0x06000EAF RID: 3759 RVA: 0x00088008 File Offset: 0x00086208
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

		' Token: 0x17000583 RID: 1411
		' (get) Token: 0x06000EB0 RID: 3760 RVA: 0x0008804B File Offset: 0x0008624B
		' (set) Token: 0x06000EB1 RID: 3761 RVA: 0x00088058 File Offset: 0x00086258
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

		' Token: 0x17000584 RID: 1412
		' (get) Token: 0x06000EB2 RID: 3762 RVA: 0x0008809B File Offset: 0x0008629B
		' (set) Token: 0x06000EB3 RID: 3763 RVA: 0x000880A5 File Offset: 0x000862A5
		Friend Overridable Property Label28 As Label

		' Token: 0x17000585 RID: 1413
		' (get) Token: 0x06000EB4 RID: 3764 RVA: 0x000880AE File Offset: 0x000862AE
		' (set) Token: 0x06000EB5 RID: 3765 RVA: 0x000880B8 File Offset: 0x000862B8
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

		' Token: 0x17000586 RID: 1414
		' (get) Token: 0x06000EB6 RID: 3766 RVA: 0x000880FB File Offset: 0x000862FB
		' (set) Token: 0x06000EB7 RID: 3767 RVA: 0x00088105 File Offset: 0x00086305
		Friend Overridable Property txtDefLoc As TextBox

		' Token: 0x17000587 RID: 1415
		' (get) Token: 0x06000EB8 RID: 3768 RVA: 0x0008810E File Offset: 0x0008630E
		' (set) Token: 0x06000EB9 RID: 3769 RVA: 0x00088118 File Offset: 0x00086318
		Friend Overridable Property Label22 As Label

		' Token: 0x17000588 RID: 1416
		' (get) Token: 0x06000EBA RID: 3770 RVA: 0x00088121 File Offset: 0x00086321
		' (set) Token: 0x06000EBB RID: 3771 RVA: 0x0008812B File Offset: 0x0008632B
		Friend Overridable Property Label30 As Label

		' Token: 0x17000589 RID: 1417
		' (get) Token: 0x06000EBC RID: 3772 RVA: 0x00088134 File Offset: 0x00086334
		' (set) Token: 0x06000EBD RID: 3773 RVA: 0x0008813E File Offset: 0x0008633E
		Friend Overridable Property Label20 As Label

		' Token: 0x1700058A RID: 1418
		' (get) Token: 0x06000EBE RID: 3774 RVA: 0x00088147 File Offset: 0x00086347
		' (set) Token: 0x06000EBF RID: 3775 RVA: 0x00088151 File Offset: 0x00086351
		Friend Overridable Property txtMOQ As TextBox

		' Token: 0x1700058B RID: 1419
		' (get) Token: 0x06000EC0 RID: 3776 RVA: 0x0008815A File Offset: 0x0008635A
		' (set) Token: 0x06000EC1 RID: 3777 RVA: 0x00088164 File Offset: 0x00086364
		Friend Overridable Property Label38 As Label

		' Token: 0x1700058C RID: 1420
		' (get) Token: 0x06000EC2 RID: 3778 RVA: 0x0008816D File Offset: 0x0008636D
		' (set) Token: 0x06000EC3 RID: 3779 RVA: 0x00088177 File Offset: 0x00086377
		Friend Overridable Property Label1 As Label

		' Token: 0x1700058D RID: 1421
		' (get) Token: 0x06000EC4 RID: 3780 RVA: 0x00088180 File Offset: 0x00086380
		' (set) Token: 0x06000EC5 RID: 3781 RVA: 0x0008818A File Offset: 0x0008638A
		Friend Overridable Property Label8 As Label

		' Token: 0x1700058E RID: 1422
		' (get) Token: 0x06000EC6 RID: 3782 RVA: 0x00088193 File Offset: 0x00086393
		' (set) Token: 0x06000EC7 RID: 3783 RVA: 0x0008819D File Offset: 0x0008639D
		Friend Overridable Property txtLeadTime As TextBox

		' Token: 0x1700058F RID: 1423
		' (get) Token: 0x06000EC8 RID: 3784 RVA: 0x000881A6 File Offset: 0x000863A6
		' (set) Token: 0x06000EC9 RID: 3785 RVA: 0x000881B0 File Offset: 0x000863B0
		Friend Overridable Property chkIsActive As CheckBox

		' Token: 0x17000590 RID: 1424
		' (get) Token: 0x06000ECA RID: 3786 RVA: 0x000881B9 File Offset: 0x000863B9
		' (set) Token: 0x06000ECB RID: 3787 RVA: 0x000881C3 File Offset: 0x000863C3
		Friend Overridable Property Label2 As Label

		' Token: 0x17000591 RID: 1425
		' (get) Token: 0x06000ECC RID: 3788 RVA: 0x000881CC File Offset: 0x000863CC
		' (set) Token: 0x06000ECD RID: 3789 RVA: 0x000881D6 File Offset: 0x000863D6
		Friend Overridable Property chkQC As CheckBox

		' Token: 0x17000592 RID: 1426
		' (get) Token: 0x06000ECE RID: 3790 RVA: 0x000881DF File Offset: 0x000863DF
		' (set) Token: 0x06000ECF RID: 3791 RVA: 0x000881E9 File Offset: 0x000863E9
		Friend Overridable Property txtROQ As TextBox

		' Token: 0x17000593 RID: 1427
		' (get) Token: 0x06000ED0 RID: 3792 RVA: 0x000881F2 File Offset: 0x000863F2
		' (set) Token: 0x06000ED1 RID: 3793 RVA: 0x000881FC File Offset: 0x000863FC
		Friend Overridable Property txtName As TextBox

		' Token: 0x17000594 RID: 1428
		' (get) Token: 0x06000ED2 RID: 3794 RVA: 0x00088205 File Offset: 0x00086405
		' (set) Token: 0x06000ED3 RID: 3795 RVA: 0x0008820F File Offset: 0x0008640F
		Friend Overridable Property Label3 As Label

		' Token: 0x17000595 RID: 1429
		' (get) Token: 0x06000ED4 RID: 3796 RVA: 0x00088218 File Offset: 0x00086418
		' (set) Token: 0x06000ED5 RID: 3797 RVA: 0x00088222 File Offset: 0x00086422
		Friend Overridable Property txtExp As TextBox

		' Token: 0x17000596 RID: 1430
		' (get) Token: 0x06000ED6 RID: 3798 RVA: 0x0008822B File Offset: 0x0008642B
		' (set) Token: 0x06000ED7 RID: 3799 RVA: 0x00088235 File Offset: 0x00086435
		Friend Overridable Property txtROL As TextBox

		' Token: 0x17000597 RID: 1431
		' (get) Token: 0x06000ED8 RID: 3800 RVA: 0x0008823E File Offset: 0x0008643E
		' (set) Token: 0x06000ED9 RID: 3801 RVA: 0x00088248 File Offset: 0x00086448
		Friend Overridable Property txtPrice As TextBox

		' Token: 0x17000598 RID: 1432
		' (get) Token: 0x06000EDA RID: 3802 RVA: 0x00088251 File Offset: 0x00086451
		' (set) Token: 0x06000EDB RID: 3803 RVA: 0x0008825B File Offset: 0x0008645B
		Friend Overridable Property Label4 As Label

		' Token: 0x17000599 RID: 1433
		' (get) Token: 0x06000EDC RID: 3804 RVA: 0x00088264 File Offset: 0x00086464
		' (set) Token: 0x06000EDD RID: 3805 RVA: 0x00088270 File Offset: 0x00086470
		Friend Overridable Property cmbType As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbType
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbType_Enter
				Dim cancelEventHandler As CancelEventHandler = AddressOf Me.cmbType_Validating
				Dim eventHandler2 As EventHandler = AddressOf Me.cmbType_SelectedIndexChanged
				Dim comboBox As ComboBox = Me._cmbType
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.Enter, eventHandler
					RemoveHandler comboBox.Validating, cancelEventHandler
					RemoveHandler comboBox.SelectedIndexChanged, eventHandler2
				End If
				Me._cmbType = value
				comboBox = Me._cmbType
				If comboBox IsNot Nothing Then
					AddHandler comboBox.Enter, eventHandler
					AddHandler comboBox.Validating, cancelEventHandler
					AddHandler comboBox.SelectedIndexChanged, eventHandler2
				End If
			End Set
		End Property

		' Token: 0x1700059A RID: 1434
		' (get) Token: 0x06000EDE RID: 3806 RVA: 0x000882E9 File Offset: 0x000864E9
		' (set) Token: 0x06000EDF RID: 3807 RVA: 0x000882F3 File Offset: 0x000864F3
		Friend Overridable Property Label5 As Label

		' Token: 0x1700059B RID: 1435
		' (get) Token: 0x06000EE0 RID: 3808 RVA: 0x000882FC File Offset: 0x000864FC
		' (set) Token: 0x06000EE1 RID: 3809 RVA: 0x00088306 File Offset: 0x00086506
		Friend Overridable Property cmbTUOM As ComboBox

		' Token: 0x1700059C RID: 1436
		' (get) Token: 0x06000EE2 RID: 3810 RVA: 0x0008830F File Offset: 0x0008650F
		' (set) Token: 0x06000EE3 RID: 3811 RVA: 0x0008831C File Offset: 0x0008651C
		Friend Overridable Property cmbExpType As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbExpType
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbExpType_SelectedIndexChanged
				Dim comboBox As ComboBox = Me._cmbExpType
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.SelectedIndexChanged, eventHandler
				End If
				Me._cmbExpType = value
				comboBox = Me._cmbExpType
				If comboBox IsNot Nothing Then
					AddHandler comboBox.SelectedIndexChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700059D RID: 1437
		' (get) Token: 0x06000EE4 RID: 3812 RVA: 0x0008835F File Offset: 0x0008655F
		' (set) Token: 0x06000EE5 RID: 3813 RVA: 0x00088369 File Offset: 0x00086569
		Friend Overridable Property chkParent As CheckBox

		' Token: 0x1700059E RID: 1438
		' (get) Token: 0x06000EE6 RID: 3814 RVA: 0x00088372 File Offset: 0x00086572
		' (set) Token: 0x06000EE7 RID: 3815 RVA: 0x0008837C File Offset: 0x0008657C
		Friend Overridable Property lblPrimaryUOM As Label

		' Token: 0x1700059F RID: 1439
		' (get) Token: 0x06000EE8 RID: 3816 RVA: 0x00088385 File Offset: 0x00086585
		' (set) Token: 0x06000EE9 RID: 3817 RVA: 0x0008838F File Offset: 0x0008658F
		Friend Overridable Property lblTertiaryUOM As Label

		' Token: 0x170005A0 RID: 1440
		' (get) Token: 0x06000EEA RID: 3818 RVA: 0x00088398 File Offset: 0x00086598
		' (set) Token: 0x06000EEB RID: 3819 RVA: 0x000883A2 File Offset: 0x000865A2
		Friend Overridable Property Label10 As Label

		' Token: 0x170005A1 RID: 1441
		' (get) Token: 0x06000EEC RID: 3820 RVA: 0x000883AB File Offset: 0x000865AB
		' (set) Token: 0x06000EED RID: 3821 RVA: 0x000883B5 File Offset: 0x000865B5
		Friend Overridable Property txtHSNSAC As TextBox

		' Token: 0x170005A2 RID: 1442
		' (get) Token: 0x06000EEE RID: 3822 RVA: 0x000883BE File Offset: 0x000865BE
		' (set) Token: 0x06000EEF RID: 3823 RVA: 0x000883C8 File Offset: 0x000865C8
		Friend Overridable Property Label25 As Label

		' Token: 0x170005A3 RID: 1443
		' (get) Token: 0x06000EF0 RID: 3824 RVA: 0x000883D1 File Offset: 0x000865D1
		' (set) Token: 0x06000EF1 RID: 3825 RVA: 0x000883DB File Offset: 0x000865DB
		Friend Overridable Property Panel1 As Panel

		' Token: 0x170005A4 RID: 1444
		' (get) Token: 0x06000EF2 RID: 3826 RVA: 0x000883E4 File Offset: 0x000865E4
		' (set) Token: 0x06000EF3 RID: 3827 RVA: 0x000883EE File Offset: 0x000865EE
		Friend Overridable Property cmbPUOM As ComboBox

		' Token: 0x170005A5 RID: 1445
		' (get) Token: 0x06000EF4 RID: 3828 RVA: 0x000883F7 File Offset: 0x000865F7
		' (set) Token: 0x06000EF5 RID: 3829 RVA: 0x00088401 File Offset: 0x00086601
		Friend Overridable Property Label15 As Label

		' Token: 0x170005A6 RID: 1446
		' (get) Token: 0x06000EF6 RID: 3830 RVA: 0x0008840A File Offset: 0x0008660A
		' (set) Token: 0x06000EF7 RID: 3831 RVA: 0x00088414 File Offset: 0x00086614
		Friend Overridable Property Label17 As Label

		' Token: 0x170005A7 RID: 1447
		' (get) Token: 0x06000EF8 RID: 3832 RVA: 0x0008841D File Offset: 0x0008661D
		' (set) Token: 0x06000EF9 RID: 3833 RVA: 0x00088428 File Offset: 0x00086628
		Friend Overridable Property chkGRN As CheckBox
			<CompilerGenerated()>
			Get
				Return Me._chkGRN
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim eventHandler As EventHandler = AddressOf Me.chkGRN_CheckedChanged
				Dim checkBox As CheckBox = Me._chkGRN
				If checkBox IsNot Nothing Then
					RemoveHandler checkBox.CheckedChanged, eventHandler
				End If
				Me._chkGRN = value
				checkBox = Me._chkGRN
				If checkBox IsNot Nothing Then
					AddHandler checkBox.CheckedChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170005A8 RID: 1448
		' (get) Token: 0x06000EFA RID: 3834 RVA: 0x0008846B File Offset: 0x0008666B
		' (set) Token: 0x06000EFB RID: 3835 RVA: 0x00088475 File Offset: 0x00086675
		Friend Overridable Property lblPrimaryPacksize As Label

		' Token: 0x170005A9 RID: 1449
		' (get) Token: 0x06000EFC RID: 3836 RVA: 0x0008847E File Offset: 0x0008667E
		' (set) Token: 0x06000EFD RID: 3837 RVA: 0x00088488 File Offset: 0x00086688
		Friend Overridable Property Label18 As Label

		' Token: 0x170005AA RID: 1450
		' (get) Token: 0x06000EFE RID: 3838 RVA: 0x00088491 File Offset: 0x00086691
		' (set) Token: 0x06000EFF RID: 3839 RVA: 0x0008849B File Offset: 0x0008669B
		Friend Overridable Property lblTertiaryPacksize As Label

		' Token: 0x170005AB RID: 1451
		' (get) Token: 0x06000F00 RID: 3840 RVA: 0x000884A4 File Offset: 0x000866A4
		' (set) Token: 0x06000F01 RID: 3841 RVA: 0x000884AE File Offset: 0x000866AE
		Friend Overridable Property txtTPacksize As TextBox

		' Token: 0x170005AC RID: 1452
		' (get) Token: 0x06000F02 RID: 3842 RVA: 0x000884B7 File Offset: 0x000866B7
		' (set) Token: 0x06000F03 RID: 3843 RVA: 0x000884C1 File Offset: 0x000866C1
		Friend Overridable Property Lable5 As Label

		' Token: 0x170005AD RID: 1453
		' (get) Token: 0x06000F04 RID: 3844 RVA: 0x000884CA File Offset: 0x000866CA
		' (set) Token: 0x06000F05 RID: 3845 RVA: 0x000884D4 File Offset: 0x000866D4
		Friend Overridable Property lbl_Exp_V As Label

		' Token: 0x170005AE RID: 1454
		' (get) Token: 0x06000F06 RID: 3846 RVA: 0x000884DD File Offset: 0x000866DD
		' (set) Token: 0x06000F07 RID: 3847 RVA: 0x000884E7 File Offset: 0x000866E7
		Friend Overridable Property Label19 As Label

		' Token: 0x170005AF RID: 1455
		' (get) Token: 0x06000F08 RID: 3848 RVA: 0x000884F0 File Offset: 0x000866F0
		' (set) Token: 0x06000F09 RID: 3849 RVA: 0x000884FA File Offset: 0x000866FA
		Friend Overridable Property Label23 As Label

		' Token: 0x170005B0 RID: 1456
		' (get) Token: 0x06000F0A RID: 3850 RVA: 0x00088503 File Offset: 0x00086703
		' (set) Token: 0x06000F0B RID: 3851 RVA: 0x0008850D File Offset: 0x0008670D
		Friend Overridable Property txtReference As TextBox

		' Token: 0x170005B1 RID: 1457
		' (get) Token: 0x06000F0C RID: 3852 RVA: 0x00088516 File Offset: 0x00086716
		' (set) Token: 0x06000F0D RID: 3853 RVA: 0x00088520 File Offset: 0x00086720
		Friend Overridable Property lbl_ItemGroup_V As Label

		' Token: 0x170005B2 RID: 1458
		' (get) Token: 0x06000F0E RID: 3854 RVA: 0x00088529 File Offset: 0x00086729
		' (set) Token: 0x06000F0F RID: 3855 RVA: 0x00088533 File Offset: 0x00086733
		Friend Overridable Property txtSpecificationNo As TextBox

		' Token: 0x170005B3 RID: 1459
		' (get) Token: 0x06000F10 RID: 3856 RVA: 0x0008853C File Offset: 0x0008673C
		' (set) Token: 0x06000F11 RID: 3857 RVA: 0x00088546 File Offset: 0x00086746
		Friend Overridable Property cmbGroup As ComboBox

		' Token: 0x170005B4 RID: 1460
		' (get) Token: 0x06000F12 RID: 3858 RVA: 0x0008854F File Offset: 0x0008674F
		' (set) Token: 0x06000F13 RID: 3859 RVA: 0x00088559 File Offset: 0x00086759
		Friend Overridable Property Label21 As Label

		' Token: 0x170005B5 RID: 1461
		' (get) Token: 0x06000F14 RID: 3860 RVA: 0x00088562 File Offset: 0x00086762
		' (set) Token: 0x06000F15 RID: 3861 RVA: 0x0008856C File Offset: 0x0008676C
		Friend Overridable Property Label32 As Label

		' Token: 0x170005B6 RID: 1462
		' (get) Token: 0x06000F16 RID: 3862 RVA: 0x00088575 File Offset: 0x00086775
		' (set) Token: 0x06000F17 RID: 3863 RVA: 0x0008857F File Offset: 0x0008677F
		Friend Overridable Property txtCatalogNo As TextBox

		' Token: 0x170005B7 RID: 1463
		' (get) Token: 0x06000F18 RID: 3864 RVA: 0x00088588 File Offset: 0x00086788
		' (set) Token: 0x06000F19 RID: 3865 RVA: 0x00088592 File Offset: 0x00086792
		Friend Overridable Property Label33 As Label

		' Token: 0x170005B8 RID: 1464
		' (get) Token: 0x06000F1A RID: 3866 RVA: 0x0008859B File Offset: 0x0008679B
		' (set) Token: 0x06000F1B RID: 3867 RVA: 0x000885A5 File Offset: 0x000867A5
		Friend Overridable Property Label34 As Label

		' Token: 0x170005B9 RID: 1465
		' (get) Token: 0x06000F1C RID: 3868 RVA: 0x000885AE File Offset: 0x000867AE
		' (set) Token: 0x06000F1D RID: 3869 RVA: 0x000885B8 File Offset: 0x000867B8
		Friend Overridable Property Label35 As Label

		' Token: 0x170005BA RID: 1466
		' (get) Token: 0x06000F1E RID: 3870 RVA: 0x000885C1 File Offset: 0x000867C1
		' (set) Token: 0x06000F1F RID: 3871 RVA: 0x000885CB File Offset: 0x000867CB
		Friend Overridable Property txtStorageCondition As TextBox

		' Token: 0x170005BB RID: 1467
		' (get) Token: 0x06000F20 RID: 3872 RVA: 0x000885D4 File Offset: 0x000867D4
		' (set) Token: 0x06000F21 RID: 3873 RVA: 0x000885DE File Offset: 0x000867DE
		Friend Overridable Property cmbGST As ComboBox

		' Token: 0x170005BC RID: 1468
		' (get) Token: 0x06000F22 RID: 3874 RVA: 0x000885E7 File Offset: 0x000867E7
		' (set) Token: 0x06000F23 RID: 3875 RVA: 0x000885F1 File Offset: 0x000867F1
		Friend Overridable Property Label36 As Label

		' Token: 0x170005BD RID: 1469
		' (get) Token: 0x06000F24 RID: 3876 RVA: 0x000885FA File Offset: 0x000867FA
		' (set) Token: 0x06000F25 RID: 3877 RVA: 0x00088604 File Offset: 0x00086804
		Friend Overridable Property txtPPacksize As TextBox

		' Token: 0x170005BE RID: 1470
		' (get) Token: 0x06000F26 RID: 3878 RVA: 0x0008860D File Offset: 0x0008680D
		' (set) Token: 0x06000F27 RID: 3879 RVA: 0x00088617 File Offset: 0x00086817
		Friend Overridable Property tpBOM As TabPage

		' Token: 0x170005BF RID: 1471
		' (get) Token: 0x06000F28 RID: 3880 RVA: 0x00088620 File Offset: 0x00086820
		' (set) Token: 0x06000F29 RID: 3881 RVA: 0x0008862C File Offset: 0x0008682C
		Friend Overridable Property llbAddBOM As LinkLabel
			<CompilerGenerated()>
			Get
				Return Me._llbAddBOM
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim linkLabelLinkClickedEventHandler As LinkLabelLinkClickedEventHandler = AddressOf Me.llbAddBOM_LinkClicked
				Dim linkLabel As LinkLabel = Me._llbAddBOM
				If linkLabel IsNot Nothing Then
					RemoveHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
				Me._llbAddBOM = value
				linkLabel = Me._llbAddBOM
				If linkLabel IsNot Nothing Then
					AddHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
			End Set
		End Property

		' Token: 0x170005C0 RID: 1472
		' (get) Token: 0x06000F2A RID: 3882 RVA: 0x0008866F File Offset: 0x0008686F
		' (set) Token: 0x06000F2B RID: 3883 RVA: 0x0008867C File Offset: 0x0008687C
		Friend Overridable Property dgvBOM As DataGridView
			<CompilerGenerated()>
			Get
				Return Me._dgvBOM
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim dataGridViewCellEventHandler As DataGridViewCellEventHandler = AddressOf Me.dgvBOM_CellDoubleClick
				Dim dataGridView As DataGridView = Me._dgvBOM
				If dataGridView IsNot Nothing Then
					RemoveHandler dataGridView.CellDoubleClick, dataGridViewCellEventHandler
				End If
				Me._dgvBOM = value
				dataGridView = Me._dgvBOM
				If dataGridView IsNot Nothing Then
					AddHandler dataGridView.CellDoubleClick, dataGridViewCellEventHandler
				End If
			End Set
		End Property

		' Token: 0x170005C1 RID: 1473
		' (get) Token: 0x06000F2C RID: 3884 RVA: 0x000886BF File Offset: 0x000868BF
		' (set) Token: 0x06000F2D RID: 3885 RVA: 0x000886C9 File Offset: 0x000868C9
		Friend Overridable Property btnDelete_Row As DataGridViewImageColumn

		' Token: 0x170005C2 RID: 1474
		' (get) Token: 0x06000F2E RID: 3886 RVA: 0x000886D2 File Offset: 0x000868D2
		' (set) Token: 0x06000F2F RID: 3887 RVA: 0x000886DC File Offset: 0x000868DC
		Friend Overridable Property AcceptanceCriteria As DataGridViewTextBoxColumn

		' Token: 0x170005C3 RID: 1475
		' (get) Token: 0x06000F30 RID: 3888 RVA: 0x000886E5 File Offset: 0x000868E5
		' (set) Token: 0x06000F31 RID: 3889 RVA: 0x000886EF File Offset: 0x000868EF
		Friend Overridable Property Specification As DataGridViewTextBoxColumn

		' Token: 0x170005C4 RID: 1476
		' (get) Token: 0x06000F32 RID: 3890 RVA: 0x000886F8 File Offset: 0x000868F8
		' (set) Token: 0x06000F33 RID: 3891 RVA: 0x00088702 File Offset: 0x00086902
		Friend Overridable Property ProductDtlsID As DataGridViewTextBoxColumn

		' Token: 0x170005C5 RID: 1477
		' (get) Token: 0x06000F34 RID: 3892 RVA: 0x0008870B File Offset: 0x0008690B
		' (set) Token: 0x06000F35 RID: 3893 RVA: 0x00088718 File Offset: 0x00086918
		Friend Overridable Property dgvDtls As DataGridView
			<CompilerGenerated()>
			Get
				Return Me._dgvDtls
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim dataGridViewCellEventHandler As DataGridViewCellEventHandler = AddressOf Me.dgvDtls_CellContentClick
				Dim dataGridView As DataGridView = Me._dgvDtls
				If dataGridView IsNot Nothing Then
					RemoveHandler dataGridView.CellContentClick, dataGridViewCellEventHandler
				End If
				Me._dgvDtls = value
				dataGridView = Me._dgvDtls
				If dataGridView IsNot Nothing Then
					AddHandler dataGridView.CellContentClick, dataGridViewCellEventHandler
				End If
			End Set
		End Property

		' Token: 0x170005C6 RID: 1478
		' (get) Token: 0x06000F36 RID: 3894 RVA: 0x0008875B File Offset: 0x0008695B
		' (set) Token: 0x06000F37 RID: 3895 RVA: 0x00088765 File Offset: 0x00086965
		Friend Overridable Property tpQC As TabPage

		' Token: 0x170005C7 RID: 1479
		' (get) Token: 0x06000F38 RID: 3896 RVA: 0x0008876E File Offset: 0x0008696E
		' (set) Token: 0x06000F39 RID: 3897 RVA: 0x00088778 File Offset: 0x00086978
		Friend Overridable Property llbAdd As LinkLabel
			<CompilerGenerated()>
			Get
				Return Me._llbAdd
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim linkLabelLinkClickedEventHandler As LinkLabelLinkClickedEventHandler = AddressOf Me.llbAdd_LinkClicked
				Dim linkLabel As LinkLabel = Me._llbAdd
				If linkLabel IsNot Nothing Then
					RemoveHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
				Me._llbAdd = value
				linkLabel = Me._llbAdd
				If linkLabel IsNot Nothing Then
					AddHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
			End Set
		End Property

		' Token: 0x170005C8 RID: 1480
		' (get) Token: 0x06000F3A RID: 3898 RVA: 0x000887BB File Offset: 0x000869BB
		' (set) Token: 0x06000F3B RID: 3899 RVA: 0x000887C5 File Offset: 0x000869C5
		Friend Overridable Property txtID As TextBox

		' Token: 0x170005C9 RID: 1481
		' (get) Token: 0x06000F3C RID: 3900 RVA: 0x000887CE File Offset: 0x000869CE
		' (set) Token: 0x06000F3D RID: 3901 RVA: 0x000887D8 File Offset: 0x000869D8
		Friend Overridable Property tcDtls As TabControl

		' Token: 0x170005CA RID: 1482
		' (get) Token: 0x06000F3E RID: 3902 RVA: 0x000887E1 File Offset: 0x000869E1
		' (set) Token: 0x06000F3F RID: 3903 RVA: 0x000887EB File Offset: 0x000869EB
		Friend Overridable Property tpDetails As TabPage

		' Token: 0x170005CB RID: 1483
		' (get) Token: 0x06000F40 RID: 3904 RVA: 0x000887F4 File Offset: 0x000869F4
		' (set) Token: 0x06000F41 RID: 3905 RVA: 0x000887FE File Offset: 0x000869FE
		Friend Overridable Property theme_tc As TabControl

		' Token: 0x170005CC RID: 1484
		' (get) Token: 0x06000F42 RID: 3906 RVA: 0x00088807 File Offset: 0x00086A07
		' (set) Token: 0x06000F43 RID: 3907 RVA: 0x00088811 File Offset: 0x00086A11
		Friend Overridable Property VersionID As DataGridViewTextBoxColumn

		' Token: 0x170005CD RID: 1485
		' (get) Token: 0x06000F44 RID: 3908 RVA: 0x0008881A File Offset: 0x00086A1A
		' (set) Token: 0x06000F45 RID: 3909 RVA: 0x00088824 File Offset: 0x00086A24
		Friend Overridable Property BOMVersion As DataGridViewTextBoxColumn

		' Token: 0x170005CE RID: 1486
		' (get) Token: 0x06000F46 RID: 3910 RVA: 0x0008882D File Offset: 0x00086A2D
		' (set) Token: 0x06000F47 RID: 3911 RVA: 0x00088837 File Offset: 0x00086A37
		Friend Overridable Property EffectiveDt As DataGridViewTextBoxColumn

		' Token: 0x170005CF RID: 1487
		' (get) Token: 0x06000F48 RID: 3912 RVA: 0x00088840 File Offset: 0x00086A40
		' (set) Token: 0x06000F49 RID: 3913 RVA: 0x0008884A File Offset: 0x00086A4A
		Friend Overridable Property ExpiryDt As DataGridViewTextBoxColumn

		' Token: 0x170005D0 RID: 1488
		' (get) Token: 0x06000F4A RID: 3914 RVA: 0x00088853 File Offset: 0x00086A53
		' (set) Token: 0x06000F4B RID: 3915 RVA: 0x0008885D File Offset: 0x00086A5D
		Friend Overridable Property IsActive As DataGridViewTextBoxColumn

		' Token: 0x170005D1 RID: 1489
		' (get) Token: 0x06000F4C RID: 3916 RVA: 0x00088866 File Offset: 0x00086A66
		' (set) Token: 0x06000F4D RID: 3917 RVA: 0x00088870 File Offset: 0x00086A70
		Friend Overridable Property txtTertiaryMeasure As TextBox

		' Token: 0x170005D2 RID: 1490
		' (get) Token: 0x06000F4E RID: 3918 RVA: 0x00088879 File Offset: 0x00086A79
		' (set) Token: 0x06000F4F RID: 3919 RVA: 0x00088883 File Offset: 0x00086A83
		Friend Overridable Property cmbPrimaryMeasure As ComboBox

		' Token: 0x06000F50 RID: 3920 RVA: 0x0008888C File Offset: 0x00086A8C
		Public Sub New(FormType As String)
			AddHandler MyBase.Shown, AddressOf Me.Me_Shown
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.sProductType_Old = ""
			Me.InitializeComponent()
			Me.pnlBasicDefaultHeight = Me.GbBasic.Height
			Me.pnlBasicSetHeight = 23
			Me.pnlAdvDefaultHeight = 23
			Me.pnlAdvSetHeight = Me.GbAdvanced.Height
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
			Me.sFormType = FormType
		End Sub

		' Token: 0x06000F51 RID: 3921 RVA: 0x00088947 File Offset: 0x00086B47
		Private Sub SetSearchPanel()
			Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
			Me.GbBasic.Height = Me.pnlBasicDefaultHeight
		End Sub

		' Token: 0x06000F52 RID: 3922 RVA: 0x00088970 File Offset: 0x00086B70
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

		' Token: 0x06000F53 RID: 3923 RVA: 0x000889E0 File Offset: 0x00086BE0
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

		' Token: 0x06000F54 RID: 3924 RVA: 0x00088A50 File Offset: 0x00086C50
		Private Sub Me_Shown(sender As Object, e As EventArgs)
			Me.SetTabs()
		End Sub

		' Token: 0x06000F55 RID: 3925 RVA: 0x00088A5C File Offset: 0x00086C5C
		Private Sub SetTabs()
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = CInt(Math.Round(CDbl((Me.theme_tc.Width - 4)) / 2.0))
			Me.theme_tc.ItemSize = New Size(num, 30)
			Me.tab_lblDetails.Width = num
			Me.tab_lblList.Width = num + 3
			Me.tab_lblDetails.Location = New Point(0, 0)
			Me.tab_lblList.Location = New Point(num - 4, 0)
			Dim num2 As Integer = CInt(Math.Round(CDbl((Me.tcDtls.Width - 4)) / 2.0))
			Me.tcDtls.ItemSize = New Size(num2, 30)
		End Sub

		' Token: 0x06000F56 RID: 3926 RVA: 0x00088B14 File Offset: 0x00086D14
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

		' Token: 0x06000F57 RID: 3927 RVA: 0x00088BAC File Offset: 0x00086DAC
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Designing.SetTheme(Me)
			Me.SetSearchPanel()
			Me.ClearForm()
			Me.ClearList()
			Me.FillCombo()
			Me.SetAccess("DISABLE")
			Me.sStatus = "LOAD"
			Me.SetButtonStatus()
			Me.SetForm()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x06000F58 RID: 3928 RVA: 0x00088C1C File Offset: 0x00086E1C
		Private Sub FillCombo()
			Dim text As String = "SELECT DISTINCT TertiaryUOM FROM Product ORDER BY TertiaryUOM"
			Dim data As DataTable = MainModule.GetData(text)
			Me.cmbTUOM.ValueMember = "TertiaryUOM"
			Me.cmbTUOM.DisplayMember = "TertiaryUOM"
			Me.cmbTUOM.DataSource = data
			Me.cmbTUOM.Text = ""
			text = "SELECT DISTINCT PrimaryUOM FROM Product ORDER BY PrimaryUOM"
			Dim data2 As DataTable = MainModule.GetData(text)
			Me.cmbPUOM.ValueMember = "PrimaryUOM"
			Me.cmbPUOM.DisplayMember = "PrimaryUOM"
			Me.cmbPUOM.DataSource = data2
			Me.cmbPUOM.Text = ""
			text = "SELECT DISTINCT ItemGroup FROM Product ORDER BY ItemGroup"
			Dim data3 As DataTable = MainModule.GetData(text)
			Me.cmbGroup.ValueMember = "ItemGroup"
			Me.cmbGroup.DisplayMember = "ItemGroup"
			Me.cmbGroup.DataSource = data3
			Me.cmbGroup.Text = ""
			text = "SELECT VendorID, VendorName FROM Vendor ORDER BY VendorName"
			Dim data4 As DataTable = MainModule.GetData(text)
			Me.cmbVendor.ValueMember = "VendorID"
			Me.cmbVendor.DisplayMember = "VendorName"
			Me.cmbVendor.DataSource = data4
			Me.cmbVendor.SelectedIndex = -1
			Dim flag As Boolean = Operators.CompareString(Me.sFormType, "Approval", False) = 0
			If flag Then
				Me.cmbStatus.Text = "Approval Pending"
				Me.theme_tc.SelectedTab = Me.tpList
				Me.btnSearch_Click(Nothing, Nothing)
			End If
		End Sub

		' Token: 0x06000F59 RID: 3929 RVA: 0x00088DA4 File Offset: 0x00086FA4
		Private Sub SetForm()
			Me.tcDtls.TabPages.Remove(Me.tpBOM)
			AddHandler Me.txtTPacksize.KeyDown, AddressOf Me.Keydown_Numeric
			AddHandler Me.txtPPacksize.KeyDown, AddressOf Me.Keydown_Numeric
			AddHandler Me.txtExp.KeyDown, AddressOf Me.Keydown_Numeric
			AddHandler Me.txtLeadTime.KeyDown, AddressOf Me.Keydown_Numeric
		End Sub

		' Token: 0x06000F5A RID: 3930 RVA: 0x00088E2C File Offset: 0x0008702C
		Private Sub Keydown_Numeric(sender As Object, e As KeyEventArgs)
			Dim keyCode As Keys = e.KeyCode
			Dim flag As Boolean = (keyCode >= Keys.D0 AndAlso keyCode <= Keys.D9) OrElse (keyCode >= Keys.NumPad0 AndAlso keyCode <= Keys.NumPad9) OrElse keyCode = Keys.Back OrElse keyCode = Keys.Left OrElse keyCode = Keys.Right
			If Not flag Then
				e.SuppressKeyPress = True
			End If
		End Sub

		' Token: 0x06000F5B RID: 3931 RVA: 0x00088E78 File Offset: 0x00087078
		Private Sub SetAccess(sAccess As String)
			If Operators.CompareString(sAccess, "ENABLE", False) <> 0 Then
				If Operators.CompareString(sAccess, "DISABLE", False) = 0 Then
					Me.txtID.[ReadOnly] = True
					Me.txtCode.[ReadOnly] = True
					Me.txtName.[ReadOnly] = True
					Me.cmbGroup.Enabled = False
					Me.cmbType.Enabled = False
					Me.txtSpecificationNo.[ReadOnly] = True
					Me.txtReference.[ReadOnly] = True
					Me.txtCatalogNo.[ReadOnly] = True
					Me.txtHSNSAC.[ReadOnly] = True
					Me.cmbTUOM.Enabled = False
					Me.cmbPUOM.Enabled = False
					Me.txtTPacksize.[ReadOnly] = True
					Me.txtPPacksize.[ReadOnly] = True
					Me.cmbPrimaryMeasure.Enabled = False
					Me.cmbExpType.Enabled = False
					Me.txtExp.[ReadOnly] = True
					Me.txtPrice.[ReadOnly] = True
					Me.cmbGST.Enabled = False
					Me.txtStorageCondition.[ReadOnly] = True
					Me.txtROL.[ReadOnly] = True
					Me.txtROQ.[ReadOnly] = True
					Me.cmbVendor.Enabled = False
					Me.txtLeadTime.[ReadOnly] = True
					Me.txtMOQ.[ReadOnly] = True
					Me.txtDefLoc.[ReadOnly] = True
					Me.chkIsActive.Enabled = False
					Me.chkParent.Enabled = False
					Me.chkBinning.Enabled = False
					Me.chkGRN.Enabled = False
					Me.chkQC.Enabled = False
					Me.dgvDtls.Columns("btnDelete_Row").Visible = False
					Me.dgvDtls.Columns("Specification").[ReadOnly] = True
					Me.dgvDtls.Columns("AcceptanceCriteria").[ReadOnly] = True
				End If
			Else
				Dim flag As Boolean = Conversions.ToBoolean(GlobalVariables.gsProductDetails)
				If flag Then
					Me.txtID.[ReadOnly] = False
					Me.txtCode.[ReadOnly] = False
					Me.txtName.[ReadOnly] = False
					Me.cmbGroup.Enabled = True
					Me.cmbType.Enabled = True
					Me.txtSpecificationNo.[ReadOnly] = False
					Me.txtReference.[ReadOnly] = False
					Me.txtCatalogNo.[ReadOnly] = False
					Me.txtHSNSAC.[ReadOnly] = False
					Me.cmbTUOM.Enabled = True
					Me.cmbPUOM.Enabled = True
					Me.txtTPacksize.[ReadOnly] = False
					Me.txtPPacksize.[ReadOnly] = False
					Me.cmbPrimaryMeasure.Enabled = True
					Me.cmbExpType.Enabled = True
					Me.txtExp.[ReadOnly] = False
					Me.txtPrice.[ReadOnly] = False
					Me.cmbGST.Enabled = True
					Me.txtStorageCondition.[ReadOnly] = False
					Me.txtROL.[ReadOnly] = False
					Me.txtROQ.[ReadOnly] = False
					Me.cmbVendor.Enabled = True
					Me.txtLeadTime.[ReadOnly] = False
					Me.txtMOQ.[ReadOnly] = False
					Me.txtDefLoc.[ReadOnly] = False
					Me.chkIsActive.Enabled = True
					Me.chkParent.Enabled = True
					Me.chkBinning.Enabled = True
					Me.chkGRN.Enabled = True
					Me.chkQC.Enabled = True
				End If
				Dim flag2 As Boolean = Conversions.ToBoolean(GlobalVariables.gsProductQC)
				If flag2 Then
					Me.dgvDtls.Columns("btnDelete_Row").Visible = True
					Me.dgvDtls.Columns("Specification").[ReadOnly] = False
					Me.dgvDtls.Columns("AcceptanceCriteria").[ReadOnly] = False
				End If
			End If
		End Sub

		' Token: 0x06000F5C RID: 3932 RVA: 0x00089290 File Offset: 0x00087490
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
							Me.llbAdd.Enabled = False
							Me.llbAddBOM.Enabled = False
						End If
					Else
						Me.btnAdd.Enabled = False
						Me.btnEdit.Enabled = True
						Me.btnSave.Enabled = False
						Me.btnClear.Enabled = True
						Me.btnClose.Enabled = True
						Me.llbAdd.Enabled = False
						Me.llbAddBOM.Enabled = False
					End If
				Else
					Me.btnAdd.Enabled = True
					Me.btnEdit.Enabled = False
					Me.btnSave.Enabled = False
					Me.btnClear.Enabled = False
					Me.btnClose.Enabled = True
					Me.llbAdd.Enabled = False
					Me.llbAddBOM.Enabled = False
				End If
			Else
				Me.btnAdd.Enabled = False
				Me.btnEdit.Enabled = False
				Me.btnSave.Enabled = True
				Me.btnClear.Enabled = True
				Me.btnClose.Enabled = False
				Me.llbAdd.Enabled = Conversions.ToBoolean(GlobalVariables.gsProductQC)
				Dim text2 As String = Me.cmbType.Text
				Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(text2)
				If num <= 2424042855UI Then
					If num <> 1381572122UI Then
						If num <> 2166136261UI Then
							If num <> 2424042855UI Then
								GoTo IL_01C7
							End If
							If Operators.CompareString(text2, "Semi Finished", False) <> 0 Then
								GoTo IL_01C7
							End If
							GoTo IL_01AE
						ElseIf Operators.CompareString(text2, "", False) <> 0 Then
							GoTo IL_01C7
						End If
					ElseIf Operators.CompareString(text2, "Raw Material", False) <> 0 Then
						GoTo IL_01C7
					End If
				ElseIf num <= 2941093757UI Then
					If num <> 2480381874UI Then
						If num <> 2941093757UI Then
							GoTo IL_01C7
						End If
						If Operators.CompareString(text2, "Cell Bank", False) <> 0 Then
							GoTo IL_01C7
						End If
						GoTo IL_01AE
					ElseIf Operators.CompareString(text2, "Consumable", False) <> 0 Then
						GoTo IL_01C7
					End If
				ElseIf num <> 2982502317UI Then
					If num <> 3955665341UI Then
						GoTo IL_01C7
					End If
					If Operators.CompareString(text2, "Packaging Material", False) <> 0 Then
						GoTo IL_01C7
					End If
				Else
					If Operators.CompareString(text2, "Finished Goods", False) <> 0 Then
						GoTo IL_01C7
					End If
					GoTo IL_01AE
				End If
				Me.llbAddBOM.Enabled = False
				GoTo IL_01C7
				IL_01AE:
				Me.llbAddBOM.Enabled = Conversions.ToBoolean(GlobalVariables.gsProductBOM)
				IL_01C7:
			End If
			Dim flag As Boolean = Not Conversions.ToBoolean(GlobalVariables.gsProductQC)
			If flag Then
				Me.dgvDtls.Columns("btnDelete_Row").Visible = False
			End If
			Dim flag2 As Boolean = Not Conversions.ToBoolean(GlobalVariables.gsProductBOM)
			If flag2 Then
			End If
		End Sub

		' Token: 0x06000F5D RID: 3933 RVA: 0x000895CC File Offset: 0x000877CC
		Private Sub ClearForm()
			Me.txtID.Text = ""
			Me.txtHSNSAC.Text = ""
			Me.cmbType.Text = ""
			Me.cmbGroup.Text = ""
			Me.txtCode.Text = ""
			Me.txtName.Text = ""
			Me.txtSpecificationNo.Text = ""
			Me.txtReference.Text = ""
			Me.txtCatalogNo.Text = ""
			Me.cmbTUOM.Text = ""
			Me.cmbPUOM.Text = ""
			Me.txtTPacksize.Text = ""
			Me.txtPPacksize.Text = ""
			Me.cmbPrimaryMeasure.Text = ""
			Me.cmbExpType.Text = ""
			Me.txtExp.Text = ""
			Me.txtPrice.Text = ""
			Me.cmbGST.Text = ""
			Me.txtStorageCondition.Text = ""
			Me.txtROL.Text = ""
			Me.txtROQ.Text = ""
			Me.cmbVendor.SelectedIndex = -1
			Me.txtLeadTime.Text = ""
			Me.txtMOQ.Text = ""
			Me.txtDefLoc.Text = ""
			Me.chkIsActive.Checked = False
			Me.chkParent.Checked = False
			Me.chkBinning.Checked = False
			Me.chkGRN.Checked = False
			Me.chkQC.Checked = False
			Me.sProductType_Old = ""
			Me.FillCombo()
			Me.FillDetails()
			Me.SetAccess("DISABLE")
		End Sub

		' Token: 0x06000F5E RID: 3934 RVA: 0x000897E8 File Offset: 0x000879E8
		Private Sub ClearList()
			Me.lblSDate.SelectedIndex = 0
			Me.lblSCreated.SelectedIndex = 0
			Me.txtSCode.Text = ""
			Me.txtSCatalogNo.Text = ""
			Me.txtSName.Text = ""
			Me.txtSCreated.Text = ""
			Me.cmbSType.Text = ""
			Me.cmbStatus.SelectedIndex = 0
			Me.dtpFrom.Value = DateAndTime.Now
			Me.dtpTo.Value = DateAndTime.Now
			Me.dtpFrom.Checked = False
			Me.dtpTo.Checked = False
			Me.lblRows.Text = "0 - Rows"
			Me.dgvList.DataSource = Nothing
		End Sub

		' Token: 0x06000F5F RID: 3935 RVA: 0x000898CC File Offset: 0x00087ACC
		Private Sub btnClear_Click(sender As Object, e As EventArgs)
			Me.ClearForm()
			Me.sStatus = "LOAD"
			Me.SetButtonStatus()
		End Sub

		' Token: 0x06000F60 RID: 3936 RVA: 0x000898E8 File Offset: 0x00087AE8
		Private Sub btnClearList_Click(sender As Object, e As EventArgs)
			Me.ClearList()
		End Sub

		' Token: 0x06000F61 RID: 3937 RVA: 0x000898F2 File Offset: 0x00087AF2
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06000F62 RID: 3938 RVA: 0x000898FC File Offset: 0x00087AFC
		Private Sub btnExport_Click(sender As Object, e As EventArgs)
			MainModule.ExportToExcel(Me.dgvList, Me.Text)
		End Sub

		' Token: 0x06000F63 RID: 3939 RVA: 0x00089914 File Offset: 0x00087B14
		Private Sub btnAdd_Click(sender As Object, e As EventArgs)
			Me.ClearForm()
			Me.SetAccess("ENABLE")
			Me.sStatus = "ADD"
			Me.SetButtonStatus()
			Me.chkIsActive.Checked = True
			Me.chkGRN.Checked = True
			Me.chkQC.Checked = True
			Me.chkParent.Checked = True
			Me.txtCode.Focus()
		End Sub

		' Token: 0x06000F64 RID: 3940 RVA: 0x00089988 File Offset: 0x00087B88
		Private Sub btnEdit_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				Me.SetAccess("ENABLE")
				Me.sStatus = "EDIT"
				Me.SetButtonStatus()
			End If
		End Sub

		' Token: 0x06000F65 RID: 3941 RVA: 0x000899D3 File Offset: 0x00087BD3
		Private Sub cmbType_Enter(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000F66 RID: 3942 RVA: 0x000899D6 File Offset: 0x00087BD6
		Private Sub cmbType_Validating(sender As Object, e As CancelEventArgs)
		End Sub

		' Token: 0x06000F67 RID: 3943 RVA: 0x000899DC File Offset: 0x00087BDC
		Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs)
			Me.chkGRN.Checked = True
			Me.chkParent.Checked = True
			Me.chkQC.Checked = True
			Me.chkGRN.Enabled = True
			Me.chkParent.Enabled = True
			Me.chkQC.Enabled = True
			Me.chkBinning.Enabled = True
			Dim text As String = Me.cmbType.Text
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
						GoTo IL_0226
					End If
				ElseIf num <> 1773852434UI Then
					If num <> 2166136261UI Then
						If num <> 2424042855UI Then
							Return
						End If
						If Operators.CompareString(text, "Semi Finished", False) <> 0 Then
							Return
						End If
						GoTo IL_0226
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
					GoTo IL_0226
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
					GoTo IL_0226
				End If
			Else
				If Operators.CompareString(text, "Service", False) <> 0 Then
					Return
				End If
				Me.dgvDtls.Columns("Specification").HeaderText = "Specification"
				Me.dgvDtls.Columns("AcceptanceCriteria").HeaderText = "Acceptance Criteria"
				Me.chkGRN.Checked = False
				Me.chkParent.Checked = False
				Me.chkQC.Checked = False
				Me.chkBinning.Checked = False
				Me.chkGRN.Enabled = False
				Me.chkParent.Enabled = False
				Me.chkQC.Enabled = False
				Me.chkBinning.Enabled = False
				Return
			End If
			Me.dgvDtls.Columns("Specification").HeaderText = "Specification"
			Me.dgvDtls.Columns("AcceptanceCriteria").HeaderText = "Acceptance Criteria"
			Return
			IL_0226:
			Me.dgvDtls.Columns("Specification").HeaderText = "Test"
			Me.dgvDtls.Columns("AcceptanceCriteria").HeaderText = "Specification"
		End Sub

		' Token: 0x06000F68 RID: 3944 RVA: 0x00089D04 File Offset: 0x00087F04
		Private Sub cmbVendor_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbVendor.SelectedIndex = -1
			If flag Then
				Me.cmbVendor.Text = ""
			End If
		End Sub

		' Token: 0x06000F69 RID: 3945 RVA: 0x00089D38 File Offset: 0x00087F38
		Private Sub cmbExpType_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.cmbExpType.Text, "NA", False) = 0
			If flag Then
				Me.lbl_Exp_V.Visible = False
				Me.txtExp.Text = ""
				Me.txtExp.[ReadOnly] = True
			Else
				Me.lbl_Exp_V.Visible = True
				Me.txtExp.[ReadOnly] = False
			End If
		End Sub

		' Token: 0x06000F6A RID: 3946 RVA: 0x00089DB0 File Offset: 0x00087FB0
		Private Sub chkGRN_CheckedChanged(sender As Object, e As EventArgs)
			Me.lbl_ItemGroup_V.Visible = Me.chkGRN.Checked
			Dim flag As Boolean = Not Me.chkGRN.Checked
			If flag Then
				Me.lblTertiaryUOM.Visible = False
				Me.lblPrimaryUOM.Visible = False
				Me.lblTertiaryPacksize.Visible = False
				Me.lblPrimaryPacksize.Visible = False
				Me.chkQC.Checked = False
				Me.chkParent.Checked = False
				Me.chkBinning.Checked = False
				Me.chkQC.Enabled = False
				Me.chkParent.Enabled = False
				Me.chkBinning.Enabled = False
			Else
				Me.lblTertiaryUOM.Visible = True
				Me.lblPrimaryUOM.Visible = True
				Me.lblTertiaryPacksize.Visible = True
				Me.lblPrimaryPacksize.Visible = True
				Dim enabled As Boolean = Me.btnSave.Enabled
				If enabled Then
					Me.chkQC.Enabled = True
					Me.chkParent.Enabled = True
					Me.chkBinning.Enabled = True
				End If
			End If
		End Sub

		' Token: 0x06000F6B RID: 3947 RVA: 0x00089EE0 File Offset: 0x000880E0
		Private Sub btnSearch_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SearchData()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06000F6C RID: 3948 RVA: 0x00089F4C File Offset: 0x0008814C
		Private Sub SearchData()
			Dim text As String = ""
			Dim text2 As String = " SELECT P.ProductID AS ID, P.Status, P.ProductCode, P.ProductName, P.ProductType, P.ItemGroup, P.SpecificationNo, " & vbCrLf
			text2 += " P.Reference, P.CatalogNo, P.HSNSACCode, P.TertiaryUOM, P.TertiaryPackSize, P.PrimaryUOM, P.PrimaryPackSize, " & vbCrLf
			text2 += " P.Measurement, P.ExpiryType, P.Expiry, P.UnitPrice, P.GSTPer, P.ROL, P.ROQ, P.LeadTime, P.VendorMOQ, " & vbCrLf
			text2 += " P.PreferredVendorID, V.VendorName, P.DefaultStorageLocation, P.StorageCondition, " & vbCrLf
			text2 += " P.IsGRNApplicable, P.IsQCApplicable, P.IsParentApplicable, P.IsBinningAlert, P.IsActive, " & vbCrLf
			text2 += " P.CreationDt, Created.UserName AS CreatedBy, P.ModificationDt, Modified.UserName AS ModifiedBy " & vbCrLf
			text2 += " FROM Product AS P " & vbCrLf
			text2 += " LEFT OUTER JOIN Vendor AS V ON P.PreferredVendorID = V.VendorID " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Created ON P.CreatedBy = Created.UserID " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Modified ON P.ModifiedBy = Modified.UserID" & vbCrLf
			text2 += " WHERE 1 = 1" & vbCrLf
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.txtSCode.Text), "", False) <> 0
			If flag Then
				text2 = text2 + " And (ProductCode Like '%" + Strings.Trim(Me.txtSCode.Text) + "%') "
				text = text + "ProductCode LIKE " + Strings.Trim(Me.txtSCode.Text) + vbCrLf
			End If
			Dim flag2 As Boolean = Operators.CompareString(Strings.Trim(Me.txtSCatalogNo.Text), "", False) <> 0
			If flag2 Then
				text2 = text2 + " And (CatalogNo Like '%" + Strings.Trim(Me.txtSCatalogNo.Text) + "%') "
				text = text + "CatalogNo LIKE " + Strings.Trim(Me.txtSCatalogNo.Text) + vbCrLf
			End If
			Dim flag3 As Boolean = Operators.CompareString(Strings.Trim(Me.txtSName.Text), "", False) <> 0
			If flag3 Then
				text2 = text2 + " And (ProductName Like '%" + Strings.Trim(Me.txtSName.Text) + "%') "
				text = text + "ProductName LIKE " + Strings.Trim(Me.txtSName.Text) + vbCrLf
			End If
			Dim flag4 As Boolean = Operators.CompareString(Strings.Trim(Me.cmbSType.Text), "", False) <> 0
			If flag4 Then
				text2 = text2 + " AND (ProductType = '" + Strings.Trim(Me.cmbSType.Text) + "')"
				text = text + "ProductType = " + Strings.Trim(Me.cmbSType.Text) + vbCrLf
			End If
			Dim flag5 As Boolean = Me.cmbStatus.SelectedIndex > 0
			If flag5 Then
				text2 = text2 + " AND (P.Status = '" + Me.cmbStatus.Text + "')"
				text = text + ("P.Status = " + Me.cmbStatus.Text) + vbCrLf
			End If
			Dim flag6 As Boolean = Operators.CompareString(Strings.Trim(Me.txtSCreated.Text), "", False) <> 0
			If flag6 Then
				Dim flag7 As Boolean = Me.lblSCreated.SelectedIndex >= 0
				If flag7 Then
					Dim flag8 As Boolean = Me.lblSCreated.SelectedIndex = 0
					Dim text3 As String
					If flag8 Then
						text3 = "Created"
					Else
						text3 = "Modified"
					End If
					text2 = String.Concat(New String() { text2, " AND ", text3, ".UserName LIKE '%", Strings.Trim(Me.txtSCreated.Text), "%'" })
					text = text + (text3 + "By LIKE " + Strings.Trim(Me.txtSCreated.Text)) + vbCrLf
				End If
			End If
			Dim flag9 As Boolean = Me.lblSDate.SelectedIndex >= 0
			If flag9 Then
				Dim flag10 As Boolean = Me.lblSDate.SelectedIndex = 0
				Dim text4 As String
				If flag10 Then
					text4 = "CreationDt"
				Else
					text4 = "ModificationDt"
				End If
				Dim flag11 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
				If flag11 Then
					text2 = String.Concat(New String() { text2, " AND P.", text4, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
					text = text + String.Concat(New String() { text4, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
				Else
					Dim checked As Boolean = Me.dtpFrom.Checked
					If checked Then
						text2 = String.Concat(New String() { text2, " AND P.", text4, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59"), "'" })
						text = text + String.Concat(New String() { text4, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
					End If
					Dim checked2 As Boolean = Me.dtpTo.Checked
					If checked2 Then
						text2 = String.Concat(New String() { text2, " AND P.", text4, " BETWEEN '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
						text = text + String.Concat(New String() { text4, " BETWEEN  ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
					End If
				End If
			End If
			text2 += " ORDER BY ProductName"
			Dim data As DataTable = MainModule.GetData(text2)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = data
			Me.dgvList.Columns("ID").Visible = False
			Me.dgvList.Columns("PreferredVendorID").Visible = False
			Me.dgvList.Columns("Status").HeaderText = "Status"
			Me.dgvList.Columns("ProductCode").HeaderText = "Product Code"
			Me.dgvList.Columns("ProductName").HeaderText = "Product Name"
			Me.dgvList.Columns("ProductType").HeaderText = "Product Type"
			Me.dgvList.Columns("ItemGroup").HeaderText = "Item Group"
			Me.dgvList.Columns("SpecificationNo").HeaderText = "Specification No."
			Me.dgvList.Columns("Reference").HeaderText = "Reference"
			Me.dgvList.Columns("CatalogNo").HeaderText = "Catalog No."
			Me.dgvList.Columns("HSNSACCode").HeaderText = "HSN/SAC Code"
			Me.dgvList.Columns("TertiaryUOM").HeaderText = "Tertiary UOM"
			Me.dgvList.Columns("TertiaryPackSize").HeaderText = "Tertiary PackSize"
			Me.dgvList.Columns("PrimaryUOM").HeaderText = "Primary UOM"
			Me.dgvList.Columns("PrimaryPackSize").HeaderText = "Primary PackSize"
			Me.dgvList.Columns("ExpiryType").HeaderText = "Expiry Type"
			Me.dgvList.Columns("Expiry").HeaderText = "Expected Shelf Life"
			Me.dgvList.Columns("UnitPrice").HeaderText = "Unit Price"
			Me.dgvList.Columns("GSTPer").HeaderText = "GST %"
			Me.dgvList.Columns("ROL").HeaderText = "Re-Order Level"
			Me.dgvList.Columns("ROQ").HeaderText = "Re-Order Quantity"
			Me.dgvList.Columns("LeadTime").HeaderText = "Lead Time (Days)"
			Me.dgvList.Columns("VendorMOQ").HeaderText = "Vendor MOQ"
			Me.dgvList.Columns("VendorName").HeaderText = "Vendor Name"
			Me.dgvList.Columns("DefaultStorageLocation").HeaderText = "Default Storage Location"
			Me.dgvList.Columns("StorageCondition").HeaderText = "Storage Condition"
			Me.dgvList.Columns("IsActive").HeaderText = "Is Active"
			Me.dgvList.Columns("IsGRNApplicable").HeaderText = "GRN Applicable"
			Me.dgvList.Columns("IsQCApplicable").HeaderText = "QC Applicable"
			Me.dgvList.Columns("IsParentApplicable").HeaderText = "Parent Pack Applicable"
			Me.dgvList.Columns("IsBinningAlert").HeaderText = "Binning Alert"
			Me.dgvList.Columns("CreationDt").HeaderText = "Creation Date"
			Me.dgvList.Columns("CreatedBy").HeaderText = "Created By"
			Me.dgvList.Columns("ModificationDt").HeaderText = "Modification Date"
			Me.dgvList.Columns("ModifiedBy").HeaderText = "Modified By"
			Me.dgvList.Columns("Status").Width = 120
			Me.dgvList.Columns("ProductCode").Width = 140
			Me.dgvList.Columns("ProductName").Width = 350
			Me.dgvList.Columns("ProductType").Width = 130
			Me.dgvList.Columns("ItemGroup").Width = 130
			Me.dgvList.Columns("SpecificationNo").Width = 140
			Me.dgvList.Columns("Reference").Width = 140
			Me.dgvList.Columns("CatalogNo").Width = 140
			Me.dgvList.Columns("HSNSACCode").Width = 140
			Me.dgvList.Columns("TertiaryUOM").Width = 125
			Me.dgvList.Columns("TertiaryPackSize").Width = 100
			Me.dgvList.Columns("PrimaryUOM").Width = 125
			Me.dgvList.Columns("PrimaryPackSize").Width = 100
			Me.dgvList.Columns("ExpiryType").Width = 100
			Me.dgvList.Columns("Expiry").Width = 115
			Me.dgvList.Columns("UnitPrice").Width = 75
			Me.dgvList.Columns("GSTPer").Width = 75
			Me.dgvList.Columns("ROL").Width = 70
			Me.dgvList.Columns("ROQ").Width = 70
			Me.dgvList.Columns("LeadTime").Width = 75
			Me.dgvList.Columns("VendorMOQ").Width = 70
			Me.dgvList.Columns("VendorName").Width = 300
			Me.dgvList.Columns("DefaultStorageLocation").Width = 270
			Me.dgvList.Columns("StorageCondition").Width = 275
			Me.dgvList.Columns("IsGRNApplicable").Width = 70
			Me.dgvList.Columns("IsQCApplicable").Width = 70
			Me.dgvList.Columns("IsParentApplicable").Width = 85
			Me.dgvList.Columns("IsBinningAlert").Width = 70
			Me.dgvList.Columns("IsActive").Width = 70
			Me.dgvList.Columns("CreationDt").Width = 170
			Me.dgvList.Columns("CreatedBy").Width = 150
			Me.dgvList.Columns("ModificationDt").Width = 170
			Me.dgvList.Columns("ModifiedBy").Width = 150
			Me.dgvList.Columns("CreationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			Me.dgvList.Columns("ModificationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x06000F6D RID: 3949 RVA: 0x0008AEC4 File Offset: 0x000890C4
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

		' Token: 0x06000F6E RID: 3950 RVA: 0x0008AFBC File Offset: 0x000891BC
		Private Sub FillData(sID As String)
			Dim dataTable As DataTable = CType(Me.dgvList.DataSource, DataTable)
			Dim flag As Boolean = (Operators.CompareString(sID, "", False) <> 0) And (dataTable.Rows.Count > 0)
			If flag Then
				Dim flag2 As Boolean = dataTable.[Select]("ID='" + sID + "'").Length > 0
				If flag2 Then
					Dim dataRow As DataRow = dataTable.[Select]("ID='" + sID + "'")(0)
					Me.txtID.Text = dataRow("ID").ToString()
					Me.txtCode.Text = dataRow("ProductCode").ToString()
					Me.txtName.Text = dataRow("ProductName").ToString()
					Me.cmbType.Text = dataRow("ProductType").ToString()
					Me.cmbGroup.Text = dataRow("ItemGroup").ToString()
					Me.txtSpecificationNo.Text = dataRow("SpecificationNo").ToString()
					Me.txtReference.Text = dataRow("Reference").ToString()
					Me.txtCatalogNo.Text = dataRow("CatalogNo").ToString()
					Me.txtHSNSAC.Text = dataRow("HSNSACCode").ToString()
					Me.cmbTUOM.Text = dataRow("TertiaryUOM").ToString()
					Me.cmbPUOM.Text = dataRow("PrimaryUOM").ToString()
					Me.txtTPacksize.Text = dataRow("TertiaryPackSize").ToString()
					Me.txtPPacksize.Text = dataRow("PrimaryPackSize").ToString()
					Me.cmbPrimaryMeasure.Text = dataRow("Measurement").ToString()
					Me.cmbExpType.Text = dataRow("ExpiryType").ToString()
					Me.txtExp.Text = dataRow("Expiry").ToString()
					Me.txtPrice.Text = dataRow("UnitPrice").ToString()
					Me.cmbGST.Text = dataRow("GSTPer").ToString()
					Me.txtStorageCondition.Text = dataRow("StorageCondition").ToString()
					Me.txtROL.Text = dataRow("ROL").ToString()
					Me.txtROQ.Text = dataRow("ROQ").ToString()
					Dim flag3 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("PreferredVendorID")))
					If flag3 Then
						Me.cmbVendor.SelectedValue = dataRow("PreferredVendorID").ToString()
					Else
						Me.cmbVendor.SelectedIndex = -1
					End If
					Me.txtLeadTime.Text = dataRow("LeadTime").ToString()
					Me.txtMOQ.Text = dataRow("VendorMOQ").ToString()
					Me.txtDefLoc.Text = dataRow("DefaultStorageLocation").ToString()
					Me.chkIsActive.Checked = Conversions.ToBoolean(dataRow("IsActive"))
					Me.chkGRN.Checked = Conversions.ToBoolean(dataRow("IsGRNApplicable"))
					Me.chkQC.Checked = Conversions.ToBoolean(dataRow("IsQCApplicable"))
					Me.chkParent.Checked = Conversions.ToBoolean(dataRow("IsParentApplicable"))
					Me.chkBinning.Checked = Conversions.ToBoolean(dataRow("IsBinningAlert"))
					Me.FillDetails()
				End If
			End If
		End Sub

		' Token: 0x06000F6F RID: 3951 RVA: 0x0008B3C0 File Offset: 0x000895C0
		Private Sub FillDetails()
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			Dim text As String
			If flag Then
				text = " Select ProductDtlsID, Specification, AcceptanceCriteria" & vbCrLf
				text += " FROM ProductDtls" & vbCrLf
				text = text + " WHERE ProductID = '" + Me.txtID.Text + "'" & vbCrLf
			Else
				text = " SELECT ProductDtlsID, Specification, AcceptanceCriteria" & vbCrLf
				text += " FROM ProductDtls" & vbCrLf
				text += " WHERE ProductID = '0'" & vbCrLf
			End If
			Me.dtDtls = MainModule.GetData(text)
			Me.dgvDtls.DataSource = Me.dtDtls
		End Sub

		' Token: 0x06000F70 RID: 3952 RVA: 0x0008B45C File Offset: 0x0008965C
		Private Sub FillBOM()
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			Dim text As String
			Dim text2 As String
			If flag Then
				text = " SELECT VersionID, BOMVersion, EffectiveDt, ExpiryDt, IsActive" & vbCrLf
				text += " FROM ProductBOM" & vbCrLf
				text = text + " WHERE ProductID = '" + Me.txtID.Text + "'" & vbCrLf
				text2 = " SELECT '' ProductBOMID, PBD.VersionID," & vbCrLf
				text2 += " PBD.IssueOrder, PBD.MaterialID, PBD.Qty, M.ProductType MaterialType," & vbCrLf
				text2 += " M.ProductCode MaterialCode, M.ProductName MaterialName, M.PrimaryUOM" & vbCrLf
				text2 += " FROM ProductBOMDtls PBD" & vbCrLf
				text2 += " INNER JOIN Product M ON PBD.MaterialID = M.ProductID" & vbCrLf
				text2 = text2 + " WHERE PBD.ProductID = '" + Me.txtID.Text + "'" & vbCrLf
			Else
				text = " SELECT VersionID, BOMVersion, EffectiveDt, ExpiryDt, IsActive" & vbCrLf
				text += " FROM ProductBOM" & vbCrLf
				text += " WHERE ProductID = '0'" & vbCrLf
				text2 = " SELECT '' ProductBOMID, PBD.VersionID," & vbCrLf
				text2 += " PBD.IssueOrder, PBD.MaterialID, PBD.Qty, M.ProductType MaterialType," & vbCrLf
				text2 += " M.ProductCode MaterialCode, M.ProductName MaterialName, M.PrimaryUOM" & vbCrLf
				text2 += " FROM ProductBOMDtls PBD" & vbCrLf
				text2 += " INNER JOIN Product M ON PBD.MaterialID = M.ProductID" & vbCrLf
				text2 += " WHERE PBD.ProductID = '0'" & vbCrLf
			End If
			Me.dtBOM = MainModule.GetData(text)
			Me.dtBOMDtls = MainModule.GetData(text2)
			Me.dgvBOM.DataSource = Me.dtBOM
		End Sub

		' Token: 0x06000F71 RID: 3953 RVA: 0x0008B59C File Offset: 0x0008979C
		Private Sub llbAdd_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Me.dtDtls.Rows.Add(New Object(-1) {})
			Me.dtDtls.Rows(Me.dtDtls.Rows.Count - 1)("ProductDtlsID") = Me.dtDtls.Rows.Count
		End Sub

		' Token: 0x06000F72 RID: 3954 RVA: 0x0008B604 File Offset: 0x00089804
		Private Sub dgvDtls_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = e.RowIndex > -1
			If flag Then
				Dim array As DataRow() = Me.dtDtls.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("ProductDtlsID = '", Me.dgvDtls.Rows(e.RowIndex).Cells("ProductDtlsID").Value), "'")))
				Dim flag2 As Boolean = array.Length = 1
				If flag2 Then
					Dim text As String = Me.dgvDtls.Columns(e.ColumnIndex).Name.ToString()
					If Operators.CompareString(text, "btnDelete_Row", False) = 0 Then
						Me.dtDtls.Rows.Remove(array(0))
					End If
				End If
			End If
		End Sub

		' Token: 0x06000F73 RID: 3955 RVA: 0x0008B6C9 File Offset: 0x000898C9
		Private Sub llbAddBOM_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
		End Sub

		' Token: 0x06000F74 RID: 3956 RVA: 0x0008B6CC File Offset: 0x000898CC
		Private Sub dgvBOM_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
		End Sub

		' Token: 0x06000F75 RID: 3957 RVA: 0x0008B6D0 File Offset: 0x000898D0
		Private Function ValidateForm() As Boolean
			Dim flag As Boolean = Operators.CompareString(Me.cmbType.Text, "", False) = 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Select Product Type.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.txtCode.Focus()
				flag2 = False
			Else
				Dim flag3 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCode.Text), "", False) = 0
				If flag3 Then
					CustomMsgBox.Show("Enter Product Code.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.txtCode.Focus()
					flag2 = False
				Else
					Dim flag4 As Boolean = Operators.CompareString(Strings.Trim(Me.txtName.Text), "", False) = 0
					If flag4 Then
						CustomMsgBox.Show("Enter Product Name.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.txtName.Focus()
						flag2 = False
					Else
						Dim checked As Boolean = Me.chkGRN.Checked
						If checked Then
							Dim flag5 As Boolean = Operators.CompareString(Strings.Trim(Me.cmbGroup.Text), "", False) = 0
							If flag5 Then
								CustomMsgBox.Show("Enter/ Select Item Group.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								Me.cmbGroup.Focus()
								Return False
							End If
						End If
						Dim flag6 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCatalogNo.Text), "", False) = 0
						If flag6 Then
							CustomMsgBox.Show("Enter Catalog No.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.txtCatalogNo.Focus()
							flag2 = False
						Else
							Dim flag7 As Boolean = Operators.CompareString(Me.cmbExpType.Text, "", False) = 0
							If flag7 Then
								CustomMsgBox.Show("Select Expiry Type.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								Me.cmbExpType.Focus()
								flag2 = False
							Else
								Dim flag8 As Boolean = Operators.CompareString(Me.cmbExpType.Text, "NA", False) <> 0
								If flag8 Then
									Dim flag9 As Boolean = Not Versioned.IsNumeric(Me.txtExp.Text) Or (Operators.CompareString(Strings.Trim(Me.txtExp.Text), "", False) = 0)
									If flag9 Then
										CustomMsgBox.Show("Expected Shelf Life Should Be Numeric.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
										Me.txtExp.Focus()
										Return False
									End If
									Dim flag10 As Boolean = Conversion.Val(Me.txtExp.Text) < 1.0
									If flag10 Then
										CustomMsgBox.Show("Invalid Expected Shelf Life.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
										Me.txtExp.Focus()
										Return False
									End If
								End If
								Dim flag11 As Boolean = Not Versioned.IsNumeric(Me.txtPrice.Text) Or (Operators.CompareString(Strings.Trim(Me.txtPrice.Text), "", False) = 0)
								If flag11 Then
									CustomMsgBox.Show("Unit Price Should Be Numeric.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
									Me.txtPrice.Focus()
									flag2 = False
								Else
									Dim checked2 As Boolean = Me.chkGRN.Checked
									If checked2 Then
										Dim flag12 As Boolean = Operators.CompareString(Me.cmbTUOM.Text, "", False) = 0
										If flag12 Then
											CustomMsgBox.Show("Enter/ Select Tertiary UOM.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
											Me.cmbTUOM.Focus()
											Return False
										End If
										Dim flag13 As Boolean = Operators.CompareString(Me.cmbPUOM.Text, "", False) = 0
										If flag13 Then
											CustomMsgBox.Show("Enter/ Select Primary UOM.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
											Me.cmbPUOM.Focus()
											Return False
										End If
										Dim flag14 As Boolean = Not Versioned.IsNumeric(Me.txtTPacksize.Text) Or (Operators.CompareString(Strings.Trim(Me.txtTPacksize.Text), "", False) = 0)
										If flag14 Then
											CustomMsgBox.Show("Tertiary Pack Size Should Be Numeric.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
											Me.txtTPacksize.Focus()
											Return False
										End If
										Dim flag15 As Boolean = Conversion.Val(Me.txtTPacksize.Text) < 1.0
										If flag15 Then
											CustomMsgBox.Show("Invalid Tertiary Pack Size.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
											Me.txtTPacksize.Focus()
											Return False
										End If
										Dim flag16 As Boolean = Not Versioned.IsNumeric(Me.txtPPacksize.Text) Or (Operators.CompareString(Strings.Trim(Me.txtPPacksize.Text), "", False) = 0)
										If flag16 Then
											CustomMsgBox.Show("Primary Pack Size Should Be Numeric.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
											Me.txtPPacksize.Focus()
											Return False
										End If
										Dim flag17 As Boolean = Conversion.Val(Me.txtPPacksize.Text) < 1.0
										If flag17 Then
											CustomMsgBox.Show("Invalid Primary Pack Size.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
											Me.txtTPacksize.Focus()
											Return False
										End If
									Else
										Me.cmbTUOM.Text = "NA"
										Me.cmbPUOM.Text = "NA"
										Me.txtTPacksize.Text = Conversions.ToString(1)
										Me.txtPPacksize.Text = Conversions.ToString(1)
									End If
									Dim flag18 As Boolean = Operators.CompareString(Me.txtROL.Text, "", False) <> 0
									If flag18 Then
										Dim flag19 As Boolean = Not Versioned.IsNumeric(Me.txtROL.Text)
										If flag19 Then
											CustomMsgBox.Show("ROL Should Be Numeric.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
											Me.txtROL.Focus()
											Return False
										End If
									End If
									Dim flag20 As Boolean = Operators.CompareString(Me.txtROQ.Text, "", False) <> 0
									If flag20 Then
										Dim flag21 As Boolean = Not Versioned.IsNumeric(Me.txtROQ.Text)
										If flag21 Then
											CustomMsgBox.Show("ROQ Should Be Numeric.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
											Me.txtROQ.Focus()
											Return False
										End If
									End If
									Dim flag22 As Boolean = Operators.CompareString(Me.txtLeadTime.Text, "", False) <> 0
									If flag22 Then
										Dim flag23 As Boolean = Not Versioned.IsNumeric(Me.txtLeadTime.Text)
										If flag23 Then
											CustomMsgBox.Show("Lead Time Should Be Numeric.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
											Me.txtLeadTime.Focus()
											Return False
										End If
									End If
									Dim flag24 As Boolean = Operators.CompareString(Me.txtMOQ.Text, "", False) <> 0
									If flag24 Then
										Dim flag25 As Boolean = Not Versioned.IsNumeric(Me.txtMOQ.Text)
										If flag25 Then
											CustomMsgBox.Show("Vendor MOQ Should Be Numeric.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
											Me.txtMOQ.Focus()
											Return False
										End If
									End If
									Dim num As Integer = Me.dtDtls.Rows.Count - 1
									For i As Integer = 0 To num
										Dim flag26 As Boolean = (Operators.CompareString(Me.dtDtls.Rows(i)("Specification").ToString(), "", False) = 0) Or (Operators.CompareString(Me.dtDtls.Rows(i)("AcceptanceCriteria").ToString(), "", False) = 0)
										If flag26 Then
											CustomMsgBox.Show("Specification or Acceptance Criteria Cannot Be Blank.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
											Me.dgvDtls.Rows(i).Selected = True
											Return False
										End If
										Dim flag27 As Boolean = Me.dtDtls.[Select]("Specification = '" + Me.dtDtls.Rows(i)("Specification").ToString() + "'").Length > 1
										If flag27 Then
											CustomMsgBox.Show("Specification Repeated In The List.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
											Me.dgvDtls.Rows(i).Selected = True
											Return False
										End If
									Next
									Dim text As String = " SELECT ProductID, ProductCode, ProductName, CatalogNo FROM Product"
									text = text + " WHERE ((ProductCode = '" + Strings.Trim(Me.txtCode.Text) + "') "
									text = text + " OR (ProductName = '" + Strings.Trim(Me.txtName.Text) + "') "
									text = text + " OR (CatalogNo = '" + Strings.Trim(Me.txtCatalogNo.Text) + "')) "
									Dim flag28 As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
									If flag28 Then
										text = text + " AND ProductID <> '" + Me.txtID.Text + "'"
									End If
									Dim data As DataTable = MainModule.GetData(text)
									Dim flag29 As Boolean = data.Rows.Count > 0
									If flag29 Then
										Dim flag30 As Boolean = data.[Select]("ProductCode='" + Strings.Trim(Me.txtCode.Text) + "'").Length > 0
										If flag30 Then
											CustomMsgBox.Show("Product Code Already Exists.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
											Me.txtCode.Focus()
											Return False
										End If
										Dim flag31 As Boolean = data.[Select]("ProductName='" + Strings.Trim(Me.txtName.Text) + "'").Length > 0
										If flag31 Then
											CustomMsgBox.Show("Product Name Already Exists.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
											Me.txtName.Focus()
											Return False
										End If
										Dim flag32 As Boolean = data.[Select]("CatalogNo='" + Strings.Trim(Me.txtCatalogNo.Text) + "'").Length > 0
										If flag32 Then
											CustomMsgBox.Show("Catalog No. Already Exists.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
											Me.txtName.Focus()
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
			Return flag2
		End Function

		' Token: 0x06000F76 RID: 3958 RVA: 0x0008C09C File Offset: 0x0008A29C
		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.Save()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06000F77 RID: 3959 RVA: 0x0008C108 File Offset: 0x0008A308
		Private Sub Save()
			Dim flag As Boolean = CustomMsgBox.Show("Save..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
			If flag Then
				Dim flag2 As Boolean = Not Me.ValidateForm()
				If Not flag2 Then
					Dim flag3 As Boolean = Operators.CompareString(Me.txtID.Text, "", False) = 0
					If flag3 Then
						Me.InsertData()
					Else
						Me.UpdateData()
					End If
				End If
			End If
		End Sub

		' Token: 0x06000F78 RID: 3960 RVA: 0x0008C170 File Offset: 0x0008A370
		Private Sub InsertData()
			Dim text As String = " INSERT INTO Product (ProductCode, ProductName, ProductType, ItemGroup, SpecificationNo, Reference, " & vbCrLf
			text += " CatalogNo, HSNSACCode, TertiaryUOM, TertiaryPackSize, PrimaryUOM, PrimaryPackSize, " & vbCrLf
			text += " Measurement, ExpiryType, Expiry, UnitPrice, GSTPer, StorageCondition, " & vbCrLf
			text += " IsActive, IsGRNApplicable, IsQCApplicable, IsParentApplicable, IsBinningAlert, " & vbCrLf
			text += " ROL, ROQ, LeadTime, VendorMOQ, DefaultStorageLocation, PreferredVendorID, Status," & vbCrLf
			text += " CreationDt, CreatedBy) " & vbCrLf
			text = String.Concat(New String() { text, " VALUES ('", Strings.Trim(Me.txtCode.Text), "', '", Strings.Trim(Me.txtName.Text), "', '", Me.cmbType.Text, "', '", Me.cmbGroup.Text, "', " & vbCrLf })
			text = String.Concat(New String() { text, " '", Strings.Trim(Me.txtSpecificationNo.Text), "', '", Strings.Trim(Me.txtReference.Text), "', '", Strings.Trim(Me.txtCatalogNo.Text), "', " & vbCrLf })
			text = String.Concat(New String() { text, " '", Strings.Trim(Me.txtHSNSAC.Text), "', '", Strings.Trim(Me.cmbTUOM.Text), "', '", Conversions.ToString(Conversion.Val(Me.txtTPacksize.Text)), "', " & vbCrLf })
			text = String.Concat(New String() { text, " '", Strings.Trim(Me.cmbPUOM.Text), "', '", Conversions.ToString(Conversion.Val(Me.txtPPacksize.Text)), "', '", Me.cmbPrimaryMeasure.Text, "', '", Me.cmbExpType.Text, "', " & vbCrLf })
			text = String.Concat(New String() { text, " '", Conversions.ToString(Conversion.Val(Me.txtExp.Text)), "', '", Conversions.ToString(Conversion.Val(Me.txtPrice.Text)), "', '", Me.cmbGST.Text, "', '", Strings.Trim(Me.txtStorageCondition.Text), "', " & vbCrLf })
			text = String.Concat(New String() { text, " '", Conversions.ToString(CInt(Convert.ToInt16(Me.chkIsActive.Checked))), "', '", Conversions.ToString(CInt(Convert.ToInt16(Me.chkGRN.Checked))), "', " & vbCrLf })
			text = String.Concat(New String() { text, " '", Conversions.ToString(CInt(Convert.ToInt16(Me.chkQC.Checked))), "', '", Conversions.ToString(CInt(Convert.ToInt16(Me.chkParent.Checked))), "', " & vbCrLf })
			text = text + " '" + Conversions.ToString(CInt(Convert.ToInt16(Me.chkBinning.Checked))) + "', " & vbCrLf
			text = String.Concat(New String() { text, " '", Conversions.ToString(Conversion.Val(Me.txtROL.Text)), "', '", Conversions.ToString(Conversion.Val(Me.txtROQ.Text)), "', '", Conversions.ToString(Conversion.Val(Me.txtLeadTime.Text)), "', " })
			text = String.Concat(New String() { text, " '", Conversions.ToString(Conversion.Val(Me.txtMOQ.Text)), "', '", Me.txtDefLoc.Text, "'," })
			Dim flag As Boolean = Me.cmbVendor.SelectedIndex > -1
			If flag Then
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" '", Me.cmbVendor.SelectedValue), "', ")))
			Else
				text += " NULL, "
			End If
			text += " 'Approved', "
			text = text + " GETDATE(), '" + GlobalVariables.gsUserID + "')" & vbCrLf
			text += " SELECT SCOPE_IDENTITY() AS ID"
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag2 As Boolean = data.Rows.Count > 0
			If flag2 Then
				Me.txtID.Text = Conversions.ToString(data.Rows(0)("ID"))
				EmailModule.SendMail("Product Database", Me.txtID.Text, "Created", "")
				Me.InsertDtls()
				Me.UpdatePRProducts()
				MainModule.TrnLog(Me.Text, "Created", "New ID: " + Me.txtID.Text, Nothing)
				CustomMsgBox.Show("Product Added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Me.SetAccess("DISABLE")
				Me.sStatus = "SAVE"
				Me.SetButtonStatus()
			End If
		End Sub

		' Token: 0x06000F79 RID: 3961 RVA: 0x0008C704 File Offset: 0x0008A904
		Private Sub UpdateData()
			Dim text As String = String.Concat(New String() { " UPDATE Product SET ProductCode = '", Strings.Trim(Me.txtCode.Text), "', ProductName = '", Strings.Trim(Me.txtName.Text), "', " & vbCrLf })
			text = String.Concat(New String() { text, " ProductType = '", Me.cmbType.Text, "', ItemGroup = '", Me.cmbGroup.Text, "', " & vbCrLf })
			text = text + " SpecificationNo = '" + Strings.Trim(Me.txtSpecificationNo.Text) + "', " & vbCrLf
			text = String.Concat(New String() { text, " Reference = '", Strings.Trim(Me.txtReference.Text), "', CatalogNo = '", Strings.Trim(Me.txtCatalogNo.Text), "', " & vbCrLf })
			text = String.Concat(New String() { text, " HSNSACCode = '", Strings.Trim(Me.txtHSNSAC.Text), "', GSTPer = '", Me.cmbGST.Text, "', " })
			text = String.Concat(New String() { text, " TertiaryUOM = '", Strings.Trim(Me.cmbTUOM.Text), "', TertiaryPackSize = '", Conversions.ToString(Conversion.Val(Me.txtTPacksize.Text)), "', " & vbCrLf })
			text = String.Concat(New String() { text, " PrimaryUOM = '", Strings.Trim(Me.cmbPUOM.Text), "', PrimaryPackSize = '", Conversions.ToString(Conversion.Val(Me.txtPPacksize.Text)), "', " & vbCrLf })
			text = text + " Measurement = '" + Me.cmbPrimaryMeasure.Text + "', " & vbCrLf
			text = String.Concat(New String() { text, " ExpiryType = '", Me.cmbExpType.Text, "', Expiry = '", Conversions.ToString(Conversion.Val(Me.txtExp.Text)), "', UnitPrice = '", Conversions.ToString(Conversion.Val(Me.txtPrice.Text)), "', " & vbCrLf })
			text = text + " StorageCondition = '" + Strings.Trim(Me.txtStorageCondition.Text) + "', " & vbCrLf
			text = text + " IsActive = '" + Conversions.ToString(CInt(Convert.ToInt16(Me.chkIsActive.Checked))) + "', " & vbCrLf
			text = text + " IsGRNApplicable = '" + Conversions.ToString(CInt(Convert.ToInt16(Me.chkGRN.Checked))) + "', " & vbCrLf
			text = text + " IsQCApplicable = '" + Conversions.ToString(CInt(Convert.ToInt16(Me.chkQC.Checked))) + "', " & vbCrLf
			text = text + " IsParentApplicable = '" + Conversions.ToString(CInt(Convert.ToInt16(Me.chkParent.Checked))) + "', " & vbCrLf
			text = text + " IsBinningAlert = '" + Conversions.ToString(CInt(Convert.ToInt16(Me.chkBinning.Checked))) + "', " & vbCrLf
			text = String.Concat(New String() { text, " ROL = '", Conversions.ToString(Conversion.Val(Me.txtROL.Text)), "', ROQ = '", Conversions.ToString(Conversion.Val(Me.txtROQ.Text)), "', LeadTime = '", Conversions.ToString(Conversion.Val(Me.txtLeadTime.Text)), "', " & vbCrLf })
			text = String.Concat(New String() { text, " VendorMOQ = '", Conversions.ToString(Conversion.Val(Me.txtMOQ.Text)), "', DefaultStorageLocation = '", Me.txtDefLoc.Text, "', " & vbCrLf })
			Dim flag As Boolean = Me.cmbVendor.SelectedIndex > -1
			If flag Then
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" PreferredVendorID = '", Me.cmbVendor.SelectedValue), "', ")))
			Else
				text += " PreferredVendorID = NULL, "
			End If
			text += " Status = 'Approved', "
			text = text + " ModificationDt = GETDATE(), ModifiedBy = '" + GlobalVariables.gsUserID + "' " & vbCrLf
			text = text + " WHERE ProductID  = '" + Me.txtID.Text + "'" & vbCrLf
			Dim flag2 As Boolean = MainModule.ExecuteSQL(text) = 1
			If flag2 Then
				Dim flag3 As Boolean = Conversions.ToBoolean(GlobalVariables.gsProductDetails)
				If flag3 Then
					EmailModule.SendMail("Product Database", Me.txtID.Text, "Modified", "")
				End If
				Me.InsertDtls()
				Me.UpdatePRProducts()
				MainModule.TrnLog(Me.Text, "Modified", "Modified ID: " + Me.txtID.Text, Nothing)
				CustomMsgBox.Show("Product Modified.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Me.SetAccess("DISABLE")
				Me.sStatus = "SAVE"
				Me.SetButtonStatus()
			End If
		End Sub

		' Token: 0x06000F7A RID: 3962 RVA: 0x0008CC64 File Offset: 0x0008AE64
		Private Sub InsertDtls()
			Dim flag As Boolean = (Operators.CompareString(Me.txtID.Text, "", False) <> 0) And Conversions.ToBoolean(GlobalVariables.gsProductQC)
			If flag Then
				Dim sqlConnection As SqlConnection = New SqlConnection(GlobalVariables.gsConStr)
				sqlConnection.Open()
				Dim sqlTransaction As SqlTransaction = sqlConnection.BeginTransaction(IsolationLevel.Serializable)
				Try
					Dim text As String = " DELETE FROM ProductDtls WHERE ProductID = '" + Me.txtID.Text + "'"
					Dim flag2 As Boolean = MainModule.ExecuteSQL(text, sqlConnection, sqlTransaction) = 1
					If flag2 Then
						Dim dataTable As DataTable = Me.dtDtls.Copy()
						Dim flag3 As Boolean = dataTable.Rows.Count > 0
						If flag3 Then
							dataTable.Columns.Remove("ProductDtlsID")
							Dim dataColumn As DataColumn = New DataColumn("ProductID", GetType(Integer))
							dataColumn.DefaultValue = Me.txtID.Text
							dataTable.Columns.Add(dataColumn)
							MainModule.BulkInsertTemp(dataTable, "ProductDtls", sqlConnection, sqlTransaction)
							sqlTransaction.Commit()
							sqlConnection.Close()
						Else
							sqlTransaction.Commit()
							sqlConnection.Close()
						End If
					Else
						sqlTransaction.Rollback()
						sqlConnection.Close()
					End If
				Catch ex As Exception
					sqlTransaction.Rollback()
					sqlConnection.Close()
					CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				End Try
			End If
		End Sub

		' Token: 0x06000F7B RID: 3963 RVA: 0x0008CDEC File Offset: 0x0008AFEC
		Private Sub InsertBOM()
			Dim flag As Boolean = (Operators.CompareString(Me.txtID.Text, "", False) <> 0) And Conversions.ToBoolean(GlobalVariables.gsProductBOM)
			If flag Then
				Dim sqlConnection As SqlConnection = New SqlConnection(GlobalVariables.gsConStr)
				sqlConnection.Open()
				Dim sqlTransaction As SqlTransaction = sqlConnection.BeginTransaction(IsolationLevel.Serializable)
				Try
					Dim text As String = " DELETE FROM ProductBOM WHERE ProductID = '" + Me.txtID.Text + "'" & vbCrLf
					text = text + " DELETE FROM ProductBOMDtls WHERE ProductID = '" + Me.txtID.Text + "'"
					Dim flag2 As Boolean = MainModule.ExecuteSQL(text, sqlConnection, sqlTransaction) = 1
					If flag2 Then
						Dim dataTable As DataTable = Me.dtBOM.Copy()
						Dim flag3 As Boolean = dataTable.Rows.Count > 0
						If flag3 Then
							Dim dataColumn As DataColumn = New DataColumn("ProductID", GetType(Integer))
							dataColumn.DefaultValue = Me.txtID.Text
							dataTable.Columns.Add(dataColumn)
							MainModule.BulkInsertTemp(dataTable, "ProductBOM", sqlConnection, sqlTransaction)
						End If
						Dim dataTable2 As DataTable = Me.dtBOMDtls.Copy()
						Dim flag4 As Boolean = dataTable2.Rows.Count > 0
						If flag4 Then
							text = "SELECT ProductBOMID, VersionID FROM ProductBOM WHERE ProductID = '" + Me.txtID.Text + "'"
							Dim data As DataTable = MainModule.GetData(text, sqlConnection, sqlTransaction)
							Dim num As Integer = dataTable2.Rows.Count - 1
							For i As Integer = 0 To num
								Dim dataRow As DataRow = data.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("VersionID = '", dataTable2.Rows(i)("VersionID")), "'")))(0)
								dataTable2.Rows(i)("ProductBOMID") = RuntimeHelpers.GetObjectValue(dataRow("ProductBOMID"))
							Next
							dataTable2.Columns.Remove("MaterialType")
							dataTable2.Columns.Remove("MaterialCode")
							dataTable2.Columns.Remove("MaterialName")
							dataTable2.Columns.Remove("PrimaryUOM")
							Dim dataColumn2 As DataColumn = New DataColumn("ProductID", GetType(Integer))
							dataColumn2.DefaultValue = Me.txtID.Text
							dataTable2.Columns.Add(dataColumn2)
							MainModule.BulkInsertTemp(dataTable2, "ProductBOMDtls", sqlConnection, sqlTransaction)
						End If
						sqlTransaction.Commit()
						sqlConnection.Close()
					Else
						sqlTransaction.Rollback()
						sqlConnection.Close()
					End If
				Catch ex As Exception
					sqlTransaction.Rollback()
					sqlConnection.Close()
					CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				End Try
			End If
		End Sub

		' Token: 0x06000F7C RID: 3964 RVA: 0x0008D0E4 File Offset: 0x0008B2E4
		Private Sub UpdatePRProducts()
			Dim text As String = " SELECT P.Status, P.PRNo [PR. No.], FORMAT(P.PRDt,'dd-MMM-yyyy') [PR. Date], Req.UserName AS [Requested By], " & vbCrLf
			text += " P.Department, FORMAT(P.RequiredByDt,'dd-MMM-yyyy') [Required By Date]," & vbCrLf
			text += " PI.ProductType, PI.ProductCode, PI.ProductName, Req.EmailID" & vbCrLf
			text += " FROM PR AS P " & vbCrLf
			text += " LEFT OUTER JOIN [User] AS Req ON P.RequestedBy = Req.UserID  " & vbCrLf
			text += " INNER JOIN PRItems PI ON P.PRID = PI.PRID  " & vbCrLf
			text += " LEFT OUTER JOIN Product Pr ON Pr.ProductID = PI.ProductID  " & vbCrLf
			text = text + " WHERE 1=1 AND PI.ProductID = 0 AND PI.ProductCode = '" + Strings.Trim(Me.txtCode.Text) + "'" & vbCrLf
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				text = "EXEC usp_Update_PR_Products '" + Me.txtID.Text + "' " & vbCrLf
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text) = 1
				If flag2 Then
				End If
				Dim text2 As String = ""
				Dim num As Integer = data.Rows.Count - 1
				For i As Integer = 0 To num
					Dim flag3 As Boolean = Operators.CompareString(text2, "", False) = 0
					If flag3 Then
						text2 = data.Rows(i)("EmailID").ToString()
					Else
						text2 = ":" + data.Rows(i)("EmailID").ToString()
					End If
				Next
				data.Columns.Remove("EmailID")
				EmailModule.Send_Unregistered_PR_Product_MailAlert(data, text2)
			End If
		End Sub

		' Token: 0x04000665 RID: 1637
		Private sFormType As String

		' Token: 0x04000666 RID: 1638
		Private sStatus As String

		' Token: 0x04000667 RID: 1639
		Private dtDtls As DataTable

		' Token: 0x04000668 RID: 1640
		Private dtBOM As DataTable

		' Token: 0x04000669 RID: 1641
		Private dtBOMDtls As DataTable

		' Token: 0x0400066A RID: 1642
		Private dtMat As DataTable

		' Token: 0x0400066B RID: 1643
		Private pnlBasicDefaultHeight As Integer

		' Token: 0x0400066C RID: 1644
		Private pnlBasicSetHeight As Integer

		' Token: 0x0400066D RID: 1645
		Private pnlAdvDefaultHeight As Integer

		' Token: 0x0400066E RID: 1646
		Private pnlAdvSetHeight As Integer

		' Token: 0x0400066F RID: 1647
		Private sProductType_Old As String
	End Class
End Namespace
