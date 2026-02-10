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
	' Token: 0x02000027 RID: 39
	<DesignerGenerated()>
	Public Partial Class RequestReport
		Inherits DockContent

		' Token: 0x170003DD RID: 989
		' (get) Token: 0x06000A23 RID: 2595 RVA: 0x0005CBB7 File Offset: 0x0005ADB7
		' (set) Token: 0x06000A24 RID: 2596 RVA: 0x0005CBC1 File Offset: 0x0005ADC1
		Friend Overridable Property GbBasic As GroupBox

		' Token: 0x170003DE RID: 990
		' (get) Token: 0x06000A25 RID: 2597 RVA: 0x0005CBCA File Offset: 0x0005ADCA
		' (set) Token: 0x06000A26 RID: 2598 RVA: 0x0005CBD4 File Offset: 0x0005ADD4
		Friend Overridable Property Label2 As Label

		' Token: 0x170003DF RID: 991
		' (get) Token: 0x06000A27 RID: 2599 RVA: 0x0005CBDD File Offset: 0x0005ADDD
		' (set) Token: 0x06000A28 RID: 2600 RVA: 0x0005CBE7 File Offset: 0x0005ADE7
		Friend Overridable Property txtBatchNo As TextBox

		' Token: 0x170003E0 RID: 992
		' (get) Token: 0x06000A29 RID: 2601 RVA: 0x0005CBF0 File Offset: 0x0005ADF0
		' (set) Token: 0x06000A2A RID: 2602 RVA: 0x0005CBFA File Offset: 0x0005ADFA
		Friend Overridable Property cmbPlant As ComboBox

		' Token: 0x170003E1 RID: 993
		' (get) Token: 0x06000A2B RID: 2603 RVA: 0x0005CC03 File Offset: 0x0005AE03
		' (set) Token: 0x06000A2C RID: 2604 RVA: 0x0005CC0D File Offset: 0x0005AE0D
		Friend Overridable Property Label1 As Label

		' Token: 0x170003E2 RID: 994
		' (get) Token: 0x06000A2D RID: 2605 RVA: 0x0005CC16 File Offset: 0x0005AE16
		' (set) Token: 0x06000A2E RID: 2606 RVA: 0x0005CC20 File Offset: 0x0005AE20
		Friend Overridable Property txtNo As TextBox

		' Token: 0x170003E3 RID: 995
		' (get) Token: 0x06000A2F RID: 2607 RVA: 0x0005CC29 File Offset: 0x0005AE29
		' (set) Token: 0x06000A30 RID: 2608 RVA: 0x0005CC33 File Offset: 0x0005AE33
		Friend Overridable Property dtpFrom As DateTimePicker

		' Token: 0x170003E4 RID: 996
		' (get) Token: 0x06000A31 RID: 2609 RVA: 0x0005CC3C File Offset: 0x0005AE3C
		' (set) Token: 0x06000A32 RID: 2610 RVA: 0x0005CC46 File Offset: 0x0005AE46
		Friend Overridable Property dtpTo As DateTimePicker

		' Token: 0x170003E5 RID: 997
		' (get) Token: 0x06000A33 RID: 2611 RVA: 0x0005CC4F File Offset: 0x0005AE4F
		' (set) Token: 0x06000A34 RID: 2612 RVA: 0x0005CC59 File Offset: 0x0005AE59
		Friend Overridable Property Label16 As Label

		' Token: 0x170003E6 RID: 998
		' (get) Token: 0x06000A35 RID: 2613 RVA: 0x0005CC62 File Offset: 0x0005AE62
		' (set) Token: 0x06000A36 RID: 2614 RVA: 0x0005CC6C File Offset: 0x0005AE6C
		Friend Overridable Property lblDate As ComboBox

		' Token: 0x170003E7 RID: 999
		' (get) Token: 0x06000A37 RID: 2615 RVA: 0x0005CC75 File Offset: 0x0005AE75
		' (set) Token: 0x06000A38 RID: 2616 RVA: 0x0005CC80 File Offset: 0x0005AE80
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

		' Token: 0x170003E8 RID: 1000
		' (get) Token: 0x06000A39 RID: 2617 RVA: 0x0005CCC3 File Offset: 0x0005AEC3
		' (set) Token: 0x06000A3A RID: 2618 RVA: 0x0005CCCD File Offset: 0x0005AECD
		Friend Overridable Property GbAdvanced As GroupBox

		' Token: 0x170003E9 RID: 1001
		' (get) Token: 0x06000A3B RID: 2619 RVA: 0x0005CCD6 File Offset: 0x0005AED6
		' (set) Token: 0x06000A3C RID: 2620 RVA: 0x0005CCE0 File Offset: 0x0005AEE0
		Friend Overridable Property cmbStatus As ComboBox

		' Token: 0x170003EA RID: 1002
		' (get) Token: 0x06000A3D RID: 2621 RVA: 0x0005CCE9 File Offset: 0x0005AEE9
		' (set) Token: 0x06000A3E RID: 2622 RVA: 0x0005CCF3 File Offset: 0x0005AEF3
		Friend Overridable Property Label11 As Label

		' Token: 0x170003EB RID: 1003
		' (get) Token: 0x06000A3F RID: 2623 RVA: 0x0005CCFC File Offset: 0x0005AEFC
		' (set) Token: 0x06000A40 RID: 2624 RVA: 0x0005CD06 File Offset: 0x0005AF06
		Friend Overridable Property Label9 As Label

		' Token: 0x170003EC RID: 1004
		' (get) Token: 0x06000A41 RID: 2625 RVA: 0x0005CD0F File Offset: 0x0005AF0F
		' (set) Token: 0x06000A42 RID: 2626 RVA: 0x0005CD1C File Offset: 0x0005AF1C
		Friend Overridable Property cmbRequestedBy As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbRequestedBy
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbRequestedBy_Validated
				Dim comboBox As ComboBox = Me._cmbRequestedBy
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.Validated, eventHandler
				End If
				Me._cmbRequestedBy = value
				comboBox = Me._cmbRequestedBy
				If comboBox IsNot Nothing Then
					AddHandler comboBox.Validated, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170003ED RID: 1005
		' (get) Token: 0x06000A43 RID: 2627 RVA: 0x0005CD5F File Offset: 0x0005AF5F
		' (set) Token: 0x06000A44 RID: 2628 RVA: 0x0005CD69 File Offset: 0x0005AF69
		Friend Overridable Property Label3 As Label

		' Token: 0x170003EE RID: 1006
		' (get) Token: 0x06000A45 RID: 2629 RVA: 0x0005CD72 File Offset: 0x0005AF72
		' (set) Token: 0x06000A46 RID: 2630 RVA: 0x0005CD7C File Offset: 0x0005AF7C
		Friend Overridable Property cmbProduct As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbProduct
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbProduct_Validated
				Dim comboBox As ComboBox = Me._cmbProduct
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.Validated, eventHandler
				End If
				Me._cmbProduct = value
				comboBox = Me._cmbProduct
				If comboBox IsNot Nothing Then
					AddHandler comboBox.Validated, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170003EF RID: 1007
		' (get) Token: 0x06000A47 RID: 2631 RVA: 0x0005CDBF File Offset: 0x0005AFBF
		' (set) Token: 0x06000A48 RID: 2632 RVA: 0x0005CDC9 File Offset: 0x0005AFC9
		Friend Overridable Property txtCreated As TextBox

		' Token: 0x170003F0 RID: 1008
		' (get) Token: 0x06000A49 RID: 2633 RVA: 0x0005CDD2 File Offset: 0x0005AFD2
		' (set) Token: 0x06000A4A RID: 2634 RVA: 0x0005CDDC File Offset: 0x0005AFDC
		Friend Overridable Property lblCreated As ComboBox

		' Token: 0x170003F1 RID: 1009
		' (get) Token: 0x06000A4B RID: 2635 RVA: 0x0005CDE5 File Offset: 0x0005AFE5
		' (set) Token: 0x06000A4C RID: 2636 RVA: 0x0005CDF0 File Offset: 0x0005AFF0
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

		' Token: 0x170003F2 RID: 1010
		' (get) Token: 0x06000A4D RID: 2637 RVA: 0x0005CE33 File Offset: 0x0005B033
		' (set) Token: 0x06000A4E RID: 2638 RVA: 0x0005CE3D File Offset: 0x0005B03D
		Friend Overridable Property grpListButton As GroupBox

		' Token: 0x170003F3 RID: 1011
		' (get) Token: 0x06000A4F RID: 2639 RVA: 0x0005CE46 File Offset: 0x0005B046
		' (set) Token: 0x06000A50 RID: 2640 RVA: 0x0005CE50 File Offset: 0x0005B050
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x170003F4 RID: 1012
		' (get) Token: 0x06000A51 RID: 2641 RVA: 0x0005CE59 File Offset: 0x0005B059
		' (set) Token: 0x06000A52 RID: 2642 RVA: 0x0005CE64 File Offset: 0x0005B064
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

		' Token: 0x170003F5 RID: 1013
		' (get) Token: 0x06000A53 RID: 2643 RVA: 0x0005CEA7 File Offset: 0x0005B0A7
		' (set) Token: 0x06000A54 RID: 2644 RVA: 0x0005CEB4 File Offset: 0x0005B0B4
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

		' Token: 0x170003F6 RID: 1014
		' (get) Token: 0x06000A55 RID: 2645 RVA: 0x0005CEF7 File Offset: 0x0005B0F7
		' (set) Token: 0x06000A56 RID: 2646 RVA: 0x0005CF04 File Offset: 0x0005B104
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

		' Token: 0x170003F7 RID: 1015
		' (get) Token: 0x06000A57 RID: 2647 RVA: 0x0005CF47 File Offset: 0x0005B147
		' (set) Token: 0x06000A58 RID: 2648 RVA: 0x0005CF51 File Offset: 0x0005B151
		Friend Overridable Property lblRows As Label

		' Token: 0x170003F8 RID: 1016
		' (get) Token: 0x06000A59 RID: 2649 RVA: 0x0005CF5A File Offset: 0x0005B15A
		' (set) Token: 0x06000A5A RID: 2650 RVA: 0x0005CF64 File Offset: 0x0005B164
		Friend Overridable Property dgvList As DataGridView

		' Token: 0x170003F9 RID: 1017
		' (get) Token: 0x06000A5B RID: 2651 RVA: 0x0005CF6D File Offset: 0x0005B16D
		' (set) Token: 0x06000A5C RID: 2652 RVA: 0x0005CF77 File Offset: 0x0005B177
		Friend Overridable Property pnlItem As Panel

		' Token: 0x170003FA RID: 1018
		' (get) Token: 0x06000A5D RID: 2653 RVA: 0x0005CF80 File Offset: 0x0005B180
		' (set) Token: 0x06000A5E RID: 2654 RVA: 0x0005CF8A File Offset: 0x0005B18A
		Friend Overridable Property txtName As TextBox

		' Token: 0x170003FB RID: 1019
		' (get) Token: 0x06000A5F RID: 2655 RVA: 0x0005CF93 File Offset: 0x0005B193
		' (set) Token: 0x06000A60 RID: 2656 RVA: 0x0005CF9D File Offset: 0x0005B19D
		Friend Overridable Property txtCatalogNo As TextBox

		' Token: 0x170003FC RID: 1020
		' (get) Token: 0x06000A61 RID: 2657 RVA: 0x0005CFA6 File Offset: 0x0005B1A6
		' (set) Token: 0x06000A62 RID: 2658 RVA: 0x0005CFB0 File Offset: 0x0005B1B0
		Friend Overridable Property Label14 As Label

		' Token: 0x170003FD RID: 1021
		' (get) Token: 0x06000A63 RID: 2659 RVA: 0x0005CFB9 File Offset: 0x0005B1B9
		' (set) Token: 0x06000A64 RID: 2660 RVA: 0x0005CFC3 File Offset: 0x0005B1C3
		Friend Overridable Property Label5 As Label

		' Token: 0x170003FE RID: 1022
		' (get) Token: 0x06000A65 RID: 2661 RVA: 0x0005CFCC File Offset: 0x0005B1CC
		' (set) Token: 0x06000A66 RID: 2662 RVA: 0x0005CFD6 File Offset: 0x0005B1D6
		Friend Overridable Property txtCode As TextBox

		' Token: 0x170003FF RID: 1023
		' (get) Token: 0x06000A67 RID: 2663 RVA: 0x0005CFDF File Offset: 0x0005B1DF
		' (set) Token: 0x06000A68 RID: 2664 RVA: 0x0005CFE9 File Offset: 0x0005B1E9
		Friend Overridable Property Label6 As Label

		' Token: 0x17000400 RID: 1024
		' (get) Token: 0x06000A69 RID: 2665 RVA: 0x0005CFF2 File Offset: 0x0005B1F2
		' (set) Token: 0x06000A6A RID: 2666 RVA: 0x0005CFFC File Offset: 0x0005B1FC
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

		' Token: 0x17000401 RID: 1025
		' (get) Token: 0x06000A6B RID: 2667 RVA: 0x0005D03F File Offset: 0x0005B23F
		' (set) Token: 0x06000A6C RID: 2668 RVA: 0x0005D049 File Offset: 0x0005B249
		Friend Overridable Property Label13 As Label

		' Token: 0x06000A6D RID: 2669 RVA: 0x0005D054 File Offset: 0x0005B254
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.InitializeComponent()
			Me.pnlBasicDefaultHeight = Me.GbBasic.Height
			Me.pnlBasicSetHeight = 23
			Me.pnlAdvDefaultHeight = 23
			Me.pnlAdvSetHeight = Me.GbAdvanced.Height
		End Sub

		' Token: 0x06000A6E RID: 2670 RVA: 0x0005D0C8 File Offset: 0x0005B2C8
		Private Sub SetSearchPanel()
			Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
			Me.GbBasic.Height = Me.pnlBasicDefaultHeight
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
		End Sub

		' Token: 0x06000A6F RID: 2671 RVA: 0x0005D11C File Offset: 0x0005B31C
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

		' Token: 0x06000A70 RID: 2672 RVA: 0x0005D18C File Offset: 0x0005B38C
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

		' Token: 0x06000A71 RID: 2673 RVA: 0x0005D1FC File Offset: 0x0005B3FC
		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x06000A72 RID: 2674 RVA: 0x0005D231 File Offset: 0x0005B431
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Me.SetSearchPanel()
			Designing.SetTheme(Me)
			Me.FillCombo()
			Me.ClearList()
			Me.SetForm()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x06000A73 RID: 2675 RVA: 0x0005D270 File Offset: 0x0005B470
		Private Sub FillCombo()
			Dim text As String = "SELECT UserID, LoginID FROM [User] WHERE IsActive = 1 ORDER BY LoginID"
			Dim data As DataTable = MainModule.GetData(text)
			Me.cmbRequestedBy.ValueMember = "UserID"
			Me.cmbRequestedBy.DisplayMember = "LoginID"
			Me.cmbRequestedBy.DataSource = data
			Me.cmbRequestedBy.SelectedValue = GlobalVariables.gsUserID
			text = " SELECT ProductID, ProductName FROM Product "
			text += " WHERE IsActive = 1 AND ProductType IN ('Semi Finished Goods', 'Finished Goods') "
			text += " ORDER BY ProductName "
			Dim data2 As DataTable = MainModule.GetData(text)
			Me.cmbProduct.ValueMember = "ProductID"
			Me.cmbProduct.DisplayMember = "ProductName"
			Me.cmbProduct.DataSource = data2
			Me.cmbProduct.SelectedIndex = -1
		End Sub

		' Token: 0x06000A74 RID: 2676 RVA: 0x0005D32C File Offset: 0x0005B52C
		Private Sub SetForm()
		End Sub

		' Token: 0x06000A75 RID: 2677 RVA: 0x0005D330 File Offset: 0x0005B530
		Private Sub ClearList()
			Me.lblDate.SelectedIndex = 0
			Me.lblCreated.SelectedIndex = 0
			Me.txtNo.Text = ""
			Me.txtBatchNo.Text = ""
			Me.txtCreated.Text = ""
			Me.cmbRequestedBy.SelectedValue = GlobalVariables.gsUserID
			Me.cmbProduct.SelectedIndex = -1
			Me.cmbStatus.SelectedIndex = 0
			Me.dtpFrom.Value = DateAndTime.Now
			Me.dtpTo.Value = DateAndTime.Now
			Me.dtpFrom.Checked = False
			Me.dtpTo.Checked = False
			Me.lblRows.Text = "0 - Rows"
			Me.cmbSummary.Text = "Request-wise"
			Me.txtCode.Text = ""
			Me.txtCatalogNo.Text = ""
			Me.txtName.Text = ""
			Me.dgvList.DataSource = Nothing
		End Sub

		' Token: 0x06000A76 RID: 2678 RVA: 0x0005D454 File Offset: 0x0005B654
		Private Sub btnClearList_Click(sender As Object, e As EventArgs)
			Me.ClearList()
		End Sub

		' Token: 0x06000A77 RID: 2679 RVA: 0x0005D45E File Offset: 0x0005B65E
		Private Sub btnExport_Click(sender As Object, e As EventArgs)
			MainModule.ExportToExcel(Me.dgvList, Me.Text)
		End Sub

		' Token: 0x06000A78 RID: 2680 RVA: 0x0005D473 File Offset: 0x0005B673
		Private Sub cmbSummary_SelectedValueChanged(sender As Object, e As EventArgs)
			Me.SetSummary()
		End Sub

		' Token: 0x06000A79 RID: 2681 RVA: 0x0005D480 File Offset: 0x0005B680
		Private Sub SetSummary()
			Dim text As String = Me.cmbSummary.Text
			If Operators.CompareString(text, "Request-wise", False) <> 0 Then
				If Operators.CompareString(text, "Item-wise", False) = 0 Then
					Me.pnlItem.Visible = True
					Me.pnlAdvSetHeight = 187
					Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(Me.arrow_btnAdvanceExp_sml.Tag, "ArrowUp", False)
					If flag Then
						Me.GbAdvanced.Height = Me.pnlAdvSetHeight
					End If
				End If
			Else
				Me.pnlItem.Visible = False
				Me.pnlAdvSetHeight = 135
				Dim flag2 As Boolean = Operators.ConditionalCompareObjectEqual(Me.arrow_btnAdvanceExp_sml.Tag, "ArrowUp", False)
				If flag2 Then
					Me.GbAdvanced.Height = Me.pnlAdvSetHeight
				End If
			End If
			Me.txtCode.Text = ""
			Me.txtCatalogNo.Text = ""
			Me.txtName.Text = ""
		End Sub

		' Token: 0x06000A7A RID: 2682 RVA: 0x0005D584 File Offset: 0x0005B784
		Private Sub cmbRequestedBy_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbRequestedBy.SelectedIndex = -1
			If flag Then
				Me.cmbRequestedBy.Text = ""
			End If
		End Sub

		' Token: 0x06000A7B RID: 2683 RVA: 0x0005D5B8 File Offset: 0x0005B7B8
		Private Sub cmbProduct_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbProduct.SelectedIndex = -1
			If flag Then
				Me.cmbProduct.Text = ""
			End If
		End Sub

		' Token: 0x06000A7C RID: 2684 RVA: 0x0005D5EC File Offset: 0x0005B7EC
		Private Sub btnSearch_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Dim text As String = Me.cmbSummary.Text
				If Operators.CompareString(text, "Request-wise", False) <> 0 AndAlso Operators.CompareString(text, "Item-wise", False) <> 0 Then
					If Operators.CompareString(text, "Item-wise Issue", False) <> 0 Then
						If Operators.CompareString(text, "Batch-wise Issue", False) = 0 Then
							Me.Batch_wiseIssue()
						End If
					Else
						Me.Item_wiseIssue()
					End If
				Else
					Me.SearchData("")
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06000A7D RID: 2685 RVA: 0x0005D6BC File Offset: 0x0005B8BC
		Private Sub SearchData(sID As String)
			Dim text As String = ""
			Dim text2 As String = " SELECT R.RequestID AS ID, R.Status, RequestNo, RequestDt, RequestedBy, U.UserID,U.LoginID, U.UserName,  " & vbCrLf
			text2 += " R.ProductID, P.ProductType, P.ProductCode, P.ProductName, BatchNo, MfgDt, ExpDt, BatchQty, BOMVersion, " & vbCrLf
			Dim flag As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Item-wise", False) = 0
			If flag Then
				text2 += " M.ProductCode MaterialCode, M.CatalogNo MaterialCatalogNo, M.ProductName MaterialName, M.ProductType MaterialType, " & vbCrLf
				text2 += " M.PrimaryUOM, M.PrimaryPackSize, RD.RequiredQty, " & vbCrLf
			End If
			text2 += " Created.EmailID AS CreatedByEmailID, Modified.EmailID AS ModifiedByEmailID, " & vbCrLf
			text2 += " R.CreationDt, Created.UserName AS CreatedBy, R.ModificationDt, Modified.UserName AS ModifiedBy " & vbCrLf
			text2 += " FROM Request R " & vbCrLf
			text2 += " INNER JOIN [User] U ON R.RequestedBy = U.UserID " & vbCrLf
			text2 += " INNER JOIN Product P ON R.ProductID = P.ProductID " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Created ON R.CreatedBy = Created.UserID " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Modified ON R.ModifiedBy = Modified.UserID " & vbCrLf
			Dim flag2 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Item-wise", False) = 0
			If flag2 Then
				text2 += " INNER JOIN RequestDtls RD ON R.RequestID = RD.RequestID " & vbCrLf
				text2 += " INNER JOIN Product M ON RD.ProductID = M.ProductID " & vbCrLf
			End If
			Dim flag3 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Request-wise", False) = 0
			If flag3 Then
			End If
			text2 += " WHERE 1=1" & vbCrLf
			Dim flag4 As Boolean = Operators.CompareString(sID, "", False) <> 0
			If flag4 Then
				text2 = text2 + " AND R.RequestID = '" + sID + "'" & vbCrLf
				text = text + "RequestID = '" + sID + "'" & vbCrLf
			End If
			Dim flag5 As Boolean = Operators.CompareString(Strings.Trim(Me.txtNo.Text), "", False) <> 0
			If flag5 Then
				text2 = text2 + " And (RequestNo Like '%" + Strings.Trim(Me.txtNo.Text) + "%') " & vbCrLf
				text = text + "RequestNo LIKE " + Strings.Trim(Me.txtNo.Text) + vbCrLf
			End If
			Dim flag6 As Boolean = Operators.CompareString(Strings.Trim(Me.txtBatchNo.Text), "", False) <> 0
			If flag6 Then
				text2 = text2 + " AND (BatchNo LIKE '%" + Strings.Trim(Me.txtBatchNo.Text) + "%')" & vbCrLf
				text = text + "BatchNo LIKE " + Strings.Trim(Me.txtBatchNo.Text) + vbCrLf
			End If
			Dim flag7 As Boolean = Me.cmbRequestedBy.SelectedIndex > -1
			If flag7 Then
				text2 = text2 + " AND (R.RequestedBy = '" + Strings.Trim(Me.cmbRequestedBy.SelectedValue.ToString()) + "')" & vbCrLf
				text = text + "Requested By = " + Strings.Trim(Me.cmbRequestedBy.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag8 As Boolean = Me.cmbProduct.SelectedIndex > -1
			If flag8 Then
				text2 = text2 + " AND (R.ProductID = '" + Strings.Trim(Me.cmbProduct.SelectedValue.ToString()) + "')" & vbCrLf
				text = text + "ProductID = " + Strings.Trim(Me.cmbProduct.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag9 As Boolean = Me.cmbStatus.SelectedIndex > 0
			If flag9 Then
				text2 = text2 + " AND (R.Status = '" + Me.cmbStatus.Text + "')" & vbCrLf
				text = text + ("Status = " + Me.cmbStatus.Text) + vbCrLf
			End If
			Dim flag10 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCreated.Text), "", False) <> 0
			If flag10 Then
				Dim flag11 As Boolean = Me.lblCreated.SelectedIndex >= 0
				If flag11 Then
					Dim flag12 As Boolean = Me.lblCreated.SelectedIndex = 0
					Dim text3 As String
					If flag12 Then
						text3 = "Created"
					Else
						text3 = "Modified"
					End If
					text2 = String.Concat(New String() { text2, " AND ", text3, ".UserName LIKE '%", Strings.Trim(Me.txtCreated.Text), "%'" })
					text = text + (text3 + "By LIKE " + Strings.Trim(Me.txtCreated.Text)) + vbCrLf
				End If
			End If
			Dim flag13 As Boolean = Me.lblDate.SelectedIndex >= 0
			If flag13 Then
				Dim text4 As String = Me.lblDate.Text
				Dim text5 As String
				If Operators.CompareString(text4, "Creation", False) <> 0 Then
					If Operators.CompareString(text4, "Last Modification", False) <> 0 Then
						If Operators.CompareString(text4, "Request Date", False) <> 0 Then
							If Operators.CompareString(text4, "Mfg. Date", False) <> 0 Then
								If Operators.CompareString(text4, "Expiry Date", False) <> 0 Then
									text5 = ""
								Else
									text5 = "ExpDt"
								End If
							Else
								text5 = "MfgDt"
							End If
						Else
							text5 = "RequestDt"
						End If
					Else
						text5 = "ModificationDt"
					End If
				Else
					text5 = "CreationDt"
				End If
				Dim flag14 As Boolean = Operators.CompareString(text5, "", False) <> 0
				If flag14 Then
					Dim flag15 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
					If flag15 Then
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
			Dim flag16 As Boolean = Operators.CompareString(Me.cmbSummary.Text, "Item-wise", False) = 0
			If flag16 Then
				Dim flag17 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCode.Text), "", False) <> 0
				If flag17 Then
					text2 = text2 + " AND (M.ProductCode Like '%" + Strings.Trim(Me.txtCode.Text) + "%') "
					text = text + "MaterialCode LIKE " + Strings.Trim(Me.txtCode.Text) + vbCrLf
				End If
				Dim flag18 As Boolean = Operators.CompareString(Strings.Trim(Me.txtName.Text), "", False) <> 0
				If flag18 Then
					text2 = text2 + " AND (M.ProductName Like '%" + Strings.Trim(Me.txtName.Text) + "%') "
					text = text + "MaterialName LIKE " + Strings.Trim(Me.txtName.Text) + vbCrLf
				End If
				Dim flag19 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCatalogNo.Text), "", False) <> 0
				If flag19 Then
					text2 = text2 + " AND (M.CatalogNo Like '%" + Strings.Trim(Me.txtCatalogNo.Text) + "%') "
					text = text + "CatalogNo LIKE " + Strings.Trim(Me.txtCatalogNo.Text) + vbCrLf
				End If
			End If
			text2 += " ORDER BY RequestDt"
			Dim data As DataTable = MainModule.GetData(text2)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = Nothing
			Me.dgvList.DataSource = data
			Me.dgvList.Columns("ID").Visible = False
			Me.dgvList.Columns("RequestedBy").Visible = False
			Me.dgvList.Columns("ProductID").Visible = False
			Me.dgvList.Columns("LoginID").Visible = False
			Me.dgvList.Columns("UserID").Visible = False
			Me.dgvList.Columns("CreatedByEmailID").Visible = False
			Me.dgvList.Columns("ModifiedByEmailID").Visible = False
			Me.dgvList.Columns("RequestNo").HeaderText = "Request No."
			Me.dgvList.Columns("RequestDt").HeaderText = "Request Date"
			Me.dgvList.Columns("LoginID").HeaderText = "LoginID"
			Me.dgvList.Columns("UserName").HeaderText = "Requested By"
			Me.dgvList.Columns("ProductCode").HeaderText = "Product Code"
			Me.dgvList.Columns("ProductType").HeaderText = "Product Type"
			Me.dgvList.Columns("ProductName").HeaderText = "Product Name"
			Me.dgvList.Columns("BatchNo").HeaderText = "Batch No."
			Me.dgvList.Columns("MfgDt").HeaderText = "Mfg. Date"
			Me.dgvList.Columns("ExpDt").HeaderText = "Expiry Date"
			Me.dgvList.Columns("CreationDt").HeaderText = "Creation Date"
			Me.dgvList.Columns("CreatedBy").HeaderText = "Created By"
			Me.dgvList.Columns("ModificationDt").HeaderText = "Modification Date"
			Me.dgvList.Columns("ModifiedBy").HeaderText = "Modified By"
			Me.dgvList.Columns("BatchQty").HeaderText = "Batch Qty."
			Me.dgvList.Columns("BOMVersion").HeaderText = "BOM Version"
			Me.dgvList.Columns("RequestDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("MfgDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("ExpDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("CreationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			Me.dgvList.Columns("ModificationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			Me.dgvList.Columns("RequestNo").Width = 130
			Me.dgvList.Columns("RequestDt").Width = 120
			Me.dgvList.Columns("UserName").Width = 225
			Me.dgvList.Columns("ProductCode").Width = 170
			Me.dgvList.Columns("ProductType").Width = 150
			Me.dgvList.Columns("ProductName").Width = 350
			Me.dgvList.Columns("BatchNo").Width = 130
			Me.dgvList.Columns("MfgDt").Width = 120
			Me.dgvList.Columns("ExpDt").Width = 120
			Me.dgvList.Columns("Status").Width = 132
			Me.dgvList.Columns("CreationDt").Width = 170
			Me.dgvList.Columns("CreatedBy").Width = 140
			Me.dgvList.Columns("ModificationDt").Width = 170
			Me.dgvList.Columns("ModifiedBy").Width = 140
			Me.dgvList.Columns("BatchQty").Width = 80
			Me.dgvList.Columns("BOMVersion").Width = 130
			Me.dgvList.Columns("BatchQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			Dim flag20 As Boolean = data.Columns.Contains("MaterialCode")
			If flag20 Then
				Me.dgvList.Columns("MaterialCode").HeaderText = "Material Code"
				Me.dgvList.Columns("MaterialCatalogNo").HeaderText = "Material Catalog No."
				Me.dgvList.Columns("MaterialName").HeaderText = "Material Name"
				Me.dgvList.Columns("MaterialType").HeaderText = "Material Type"
				Me.dgvList.Columns("PrimaryUOM").HeaderText = "Primary UOM"
				Me.dgvList.Columns("PrimaryPackSize").HeaderText = "Primary PackSize"
				Me.dgvList.Columns("RequiredQty").HeaderText = "Required Qty."
				Me.dgvList.Columns("MaterialCode").Width = 180
				Me.dgvList.Columns("MaterialCatalogNo").Width = 180
				Me.dgvList.Columns("MaterialName").Width = 300
				Me.dgvList.Columns("MaterialType").Width = 110
				Me.dgvList.Columns("PrimaryUOM").Width = 90
				Me.dgvList.Columns("PrimaryPackSize").Width = 72
				Me.dgvList.Columns("RequiredQty").Width = 60
				Me.dgvList.Columns("PrimaryPackSize").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("RequiredQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x06000A7E RID: 2686 RVA: 0x0005E7F8 File Offset: 0x0005C9F8
		Private Sub Item_wiseIssue()
			Dim text As String = ""
			Dim text2 As String = " SELECT R.RequestID AS ID, R.Status, RequestNo, RequestDt, RequestedBy, U.UserName, " & vbCrLf
			text2 += " R.ProductID, P.ProductType, P.ProductCode, P.ProductName, BatchNo, MfgDt, ExpDt, BatchQty, BOMVersion, " & vbCrLf
			text2 += " M.ProductCode MaterialCode, M.CatalogNo MaterialCatalogNo, M.ProductName MaterialName, M.ProductType MaterialType, " & vbCrLf
			text2 += " M.PrimaryPackSize, M.PrimaryUOM, RD.RequiredQty, ISNULL(Pk.IssuedQty, 0) IssuedQty, ISNULL(Pk.PickedQty, 0) PickedQty " & vbCrLf
			text2 += " FROM Request R " & vbCrLf
			text2 += " INNER JOIN [User] U ON R.RequestedBy = U.UserID " & vbCrLf
			text2 += " INNER JOIN Product P ON R.ProductID = P.ProductID " & vbCrLf
			text2 += " INNER JOIN RequestDtls RD ON R.RequestID = RD.RequestID " & vbCrLf
			text2 += " INNER JOIN Product M ON RD.ProductID = M.ProductID " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Created ON R.CreatedBy = Created.UserID " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Modified ON R.ModifiedBy = Modified.UserID " & vbCrLf
			text2 += " LEFT OUTER JOIN " & vbCrLf
			text2 += "    (SELECT I.RequestID, ID.ProductID," & vbCrLf
			text2 += "     SUM(CASE WHEN I.Status IN ('Issued', 'QA Approved') THEN 1 ELSE 0 END) IssuedQty, " & vbCrLf
			text2 += "     SUM(CASE WHEN I.Status IN ('Picked', 'QA On-Hold') THEN 1 ELSE 0 END) PickedQty " & vbCrLf
			text2 += "     FROM Issue I INNER JOIN IssueDtls ID ON I.IssueID = ID.IssueID " & vbCrLf
			text2 += "     GROUP BY I.RequestID, ID.ProductID) " & vbCrLf
			text2 += " AS Pk ON Pk.RequestID = RD.RequestID AND Pk.ProductID = RD.ProductID " & vbCrLf
			text2 += " WHERE 1=1" & vbCrLf
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.txtNo.Text), "", False) <> 0
			If flag Then
				text2 = text2 + " And (RequestNo Like '%" + Strings.Trim(Me.txtNo.Text) + "%') " & vbCrLf
				text = text + "RequestNo LIKE " + Strings.Trim(Me.txtNo.Text) + vbCrLf
			End If
			Dim flag2 As Boolean = Operators.CompareString(Strings.Trim(Me.txtBatchNo.Text), "", False) <> 0
			If flag2 Then
				text2 = text2 + " AND (BatchNo LIKE '%" + Strings.Trim(Me.txtBatchNo.Text) + "%')" & vbCrLf
				text = text + "BatchNo LIKE " + Strings.Trim(Me.txtBatchNo.Text) + vbCrLf
			End If
			Dim flag3 As Boolean = Me.cmbRequestedBy.SelectedIndex > -1
			If flag3 Then
				text2 = text2 + " AND (R.RequestedBy = '" + Strings.Trim(Me.cmbRequestedBy.SelectedValue.ToString()) + "')" & vbCrLf
				text = text + "Requested By = " + Strings.Trim(Me.cmbRequestedBy.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag4 As Boolean = Me.cmbProduct.SelectedIndex > -1
			If flag4 Then
				text2 = text2 + " AND (R.ProductID = '" + Strings.Trim(Me.cmbProduct.SelectedValue.ToString()) + "')" & vbCrLf
				text = text + "ProductID = " + Strings.Trim(Me.cmbProduct.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag5 As Boolean = Me.cmbStatus.SelectedIndex > 0
			If flag5 Then
				text2 = text2 + " AND (R.Status = '" + Me.cmbStatus.Text + "')" & vbCrLf
				text = text + ("Status = " + Me.cmbStatus.Text) + vbCrLf
			End If
			Dim flag6 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCreated.Text), "", False) <> 0
			If flag6 Then
				Dim flag7 As Boolean = Me.lblCreated.SelectedIndex >= 0
				If flag7 Then
					Dim flag8 As Boolean = Me.lblCreated.SelectedIndex = 0
					Dim text3 As String
					If flag8 Then
						text3 = "Created"
					Else
						text3 = "Modified"
					End If
					text2 = String.Concat(New String() { text2, " AND ", text3, ".UserName LIKE '%", Strings.Trim(Me.txtCreated.Text), "%'" })
					text = text + (text3 + "By LIKE " + Strings.Trim(Me.txtCreated.Text)) + vbCrLf
				End If
			End If
			Dim flag9 As Boolean = Me.lblDate.SelectedIndex >= 0
			If flag9 Then
				Dim text4 As String = Me.lblDate.Text
				Dim text5 As String
				If Operators.CompareString(text4, "Creation", False) <> 0 Then
					If Operators.CompareString(text4, "Last Modification", False) <> 0 Then
						If Operators.CompareString(text4, "Request Date", False) <> 0 Then
							If Operators.CompareString(text4, "Mfg. Date", False) <> 0 Then
								If Operators.CompareString(text4, "Expiry Date", False) <> 0 Then
									text5 = ""
								Else
									text5 = "ExpDt"
								End If
							Else
								text5 = "MfgDt"
							End If
						Else
							text5 = "RequestDt"
						End If
					Else
						text5 = "ModificationDt"
					End If
				Else
					text5 = "CreationDt"
				End If
				Dim flag10 As Boolean = Operators.CompareString(text5, "", False) <> 0
				If flag10 Then
					Dim flag11 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
					If flag11 Then
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
			Dim flag12 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCode.Text), "", False) <> 0
			If flag12 Then
				text2 = text2 + " AND (M.ProductCode Like '%" + Strings.Trim(Me.txtCode.Text) + "%') "
				text = text + "MaterialCode LIKE " + Strings.Trim(Me.txtCode.Text) + vbCrLf
			End If
			Dim flag13 As Boolean = Operators.CompareString(Strings.Trim(Me.txtName.Text), "", False) <> 0
			If flag13 Then
				text2 = text2 + " AND (M.ProductName Like '%" + Strings.Trim(Me.txtName.Text) + "%') "
				text = text + "MaterialName LIKE " + Strings.Trim(Me.txtName.Text) + vbCrLf
			End If
			Dim flag14 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCatalogNo.Text), "", False) <> 0
			If flag14 Then
				text2 = text2 + " AND (M.CatalogNo Like '%" + Strings.Trim(Me.txtCatalogNo.Text) + "%') "
				text = text + "CatalogNo LIKE " + Strings.Trim(Me.txtCatalogNo.Text) + vbCrLf
			End If
			text2 += " ORDER BY RequestDt"
			Dim data As DataTable = MainModule.GetData(text2)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = Nothing
			Me.dgvList.DataSource = data
			Me.dgvList.Columns("ID").Visible = False
			Me.dgvList.Columns("RequestedBy").Visible = False
			Me.dgvList.Columns("ProductID").Visible = False
			Me.dgvList.Columns("RequestNo").HeaderText = "Request No."
			Me.dgvList.Columns("RequestDt").HeaderText = "Request Date"
			Me.dgvList.Columns("UserName").HeaderText = "Requested By"
			Me.dgvList.Columns("ProductCode").HeaderText = "Product Code"
			Me.dgvList.Columns("ProductType").HeaderText = "Product Type"
			Me.dgvList.Columns("ProductName").HeaderText = "Product Name"
			Me.dgvList.Columns("BatchNo").HeaderText = "Batch No."
			Me.dgvList.Columns("MfgDt").HeaderText = "Mfg. Date"
			Me.dgvList.Columns("ExpDt").HeaderText = "Expiry Date"
			Me.dgvList.Columns("BatchQty").HeaderText = "Batch Qty."
			Me.dgvList.Columns("BOMVersion").HeaderText = "BOM Version"
			Me.dgvList.Columns("RequestDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("MfgDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("ExpDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("RequestNo").Width = 130
			Me.dgvList.Columns("RequestDt").Width = 120
			Me.dgvList.Columns("UserName").Width = 225
			Me.dgvList.Columns("ProductCode").Width = 170
			Me.dgvList.Columns("ProductType").Width = 150
			Me.dgvList.Columns("ProductName").Width = 350
			Me.dgvList.Columns("BatchNo").Width = 130
			Me.dgvList.Columns("MfgDt").Width = 120
			Me.dgvList.Columns("ExpDt").Width = 120
			Me.dgvList.Columns("Status").Width = 132
			Me.dgvList.Columns("BatchQty").Width = 80
			Me.dgvList.Columns("BOMVersion").Width = 130
			Me.dgvList.Columns("BatchQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			Dim flag15 As Boolean = data.Columns.Contains("MaterialCode")
			If flag15 Then
				Me.dgvList.Columns("MaterialCode").HeaderText = "Material Code"
				Me.dgvList.Columns("MaterialCatalogNo").HeaderText = "Material Catalog No."
				Me.dgvList.Columns("MaterialName").HeaderText = "Material Name"
				Me.dgvList.Columns("MaterialType").HeaderText = "Material Type"
				Me.dgvList.Columns("PrimaryUOM").HeaderText = "Primary UOM"
				Me.dgvList.Columns("PrimaryPackSize").HeaderText = "Primary PackSize"
				Me.dgvList.Columns("RequiredQty").HeaderText = "Required Qty."
				Me.dgvList.Columns("IssuedQty").HeaderText = "Issued Qty."
				Me.dgvList.Columns("PickedQty").HeaderText = "Picked Qty."
				Me.dgvList.Columns("MaterialCode").Width = 180
				Me.dgvList.Columns("MaterialCatalogNo").Width = 180
				Me.dgvList.Columns("MaterialName").Width = 300
				Me.dgvList.Columns("MaterialType").Width = 110
				Me.dgvList.Columns("PrimaryUOM").Width = 90
				Me.dgvList.Columns("PrimaryPackSize").Width = 72
				Me.dgvList.Columns("RequiredQty").Width = 60
				Me.dgvList.Columns("IssuedQty").Width = 60
				Me.dgvList.Columns("PickedQty").Width = 60
				Me.dgvList.Columns("PrimaryPackSize").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("RequiredQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("IssuedQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("PickedQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x06000A7F RID: 2687 RVA: 0x0005F790 File Offset: 0x0005D990
		Private Sub Batch_wiseIssue()
			Dim text As String = ""
			Dim text2 As String = " SELECT R.RequestID AS ID, R.Status, RequestNo, RequestDt, RequestedBy, U.UserName, " & vbCrLf
			text2 += " R.ProductID, P.ProductType, P.ProductCode, P.ProductName, R.BatchNo, MfgDt, ExpDt, BatchQty, BOMVersion, " & vbCrLf
			text2 += " M.ProductCode MaterialCode, M.CatalogNo MaterialCatalogNo, M.ProductName MaterialName, M.ProductType MaterialType, " & vbCrLf
			text2 += " M.PrimaryPackSize, M.PrimaryUOM, RD.RequiredQty, Pk.BatchNo MaterialBatchNo, ISNULL(Pk.IssuedQty, 0) IssuedQty, ISNULL(Pk.PickedQty, 0) PickedQty " & vbCrLf
			text2 += " FROM Request R " & vbCrLf
			text2 += " INNER JOIN [User] U ON R.RequestedBy = U.UserID " & vbCrLf
			text2 += " INNER JOIN Product P ON R.ProductID = P.ProductID " & vbCrLf
			text2 += " INNER JOIN RequestDtls RD ON R.RequestID = RD.RequestID " & vbCrLf
			text2 += " INNER JOIN Product M ON RD.ProductID = M.ProductID " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Created ON R.CreatedBy = Created.UserID " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Modified ON R.ModifiedBy = Modified.UserID " & vbCrLf
			text2 += " LEFT OUTER JOIN " & vbCrLf
			text2 += "    (SELECT I.RequestID, ID.ProductID, GU.BatchNo, " & vbCrLf
			text2 += "     SUM(CASE WHEN I.Status IN ('Issued', 'QA Approved') THEN 1 ELSE 0 END) IssuedQty, " & vbCrLf
			text2 += "     SUM(CASE WHEN I.Status IN ('Picked', 'QA On-Hold') THEN 1 ELSE 0 END) PickedQty " & vbCrLf
			text2 += "     FROM Issue I INNER JOIN IssueDtls ID ON I.IssueID = ID.IssueID " & vbCrLf
			text2 += "     INNER JOIN GRNUID GU ON ID.UID = GU.UID " & vbCrLf
			text2 += "     GROUP BY I.RequestID, ID.ProductID, GU.BatchNo) " & vbCrLf
			text2 += " AS Pk ON Pk.RequestID = RD.RequestID AND Pk.ProductID = RD.ProductID " & vbCrLf
			text2 += " WHERE 1=1" & vbCrLf
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.txtNo.Text), "", False) <> 0
			If flag Then
				text2 = text2 + " And (RequestNo Like '%" + Strings.Trim(Me.txtNo.Text) + "%') " & vbCrLf
				text = text + "RequestNo LIKE " + Strings.Trim(Me.txtNo.Text) + vbCrLf
			End If
			Dim flag2 As Boolean = Operators.CompareString(Strings.Trim(Me.txtBatchNo.Text), "", False) <> 0
			If flag2 Then
				text2 = text2 + " AND (BatchNo LIKE '%" + Strings.Trim(Me.txtBatchNo.Text) + "%')" & vbCrLf
				text = text + "BatchNo LIKE " + Strings.Trim(Me.txtBatchNo.Text) + vbCrLf
			End If
			Dim flag3 As Boolean = Me.cmbRequestedBy.SelectedIndex > -1
			If flag3 Then
				text2 = text2 + " AND (R.RequestedBy = '" + Strings.Trim(Me.cmbRequestedBy.SelectedValue.ToString()) + "')" & vbCrLf
				text = text + "Requested By = " + Strings.Trim(Me.cmbRequestedBy.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag4 As Boolean = Me.cmbProduct.SelectedIndex > -1
			If flag4 Then
				text2 = text2 + " AND (R.ProductID = '" + Strings.Trim(Me.cmbProduct.SelectedValue.ToString()) + "')" & vbCrLf
				text = text + "ProductID = " + Strings.Trim(Me.cmbProduct.SelectedValue.ToString()) + vbCrLf
			End If
			Dim flag5 As Boolean = Me.cmbStatus.SelectedIndex > 0
			If flag5 Then
				text2 = text2 + " AND (R.Status = '" + Me.cmbStatus.Text + "')" & vbCrLf
				text = text + ("Status = " + Me.cmbStatus.Text) + vbCrLf
			End If
			Dim flag6 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCreated.Text), "", False) <> 0
			If flag6 Then
				Dim flag7 As Boolean = Me.lblCreated.SelectedIndex >= 0
				If flag7 Then
					Dim flag8 As Boolean = Me.lblCreated.SelectedIndex = 0
					Dim text3 As String
					If flag8 Then
						text3 = "Created"
					Else
						text3 = "Modified"
					End If
					text2 = String.Concat(New String() { text2, " AND ", text3, ".UserName LIKE '%", Strings.Trim(Me.txtCreated.Text), "%'" })
					text = text + (text3 + "By LIKE " + Strings.Trim(Me.txtCreated.Text)) + vbCrLf
				End If
			End If
			Dim flag9 As Boolean = Me.lblDate.SelectedIndex >= 0
			If flag9 Then
				Dim text4 As String = Me.lblDate.Text
				Dim text5 As String
				If Operators.CompareString(text4, "Creation", False) <> 0 Then
					If Operators.CompareString(text4, "Last Modification", False) <> 0 Then
						If Operators.CompareString(text4, "Request Date", False) <> 0 Then
							If Operators.CompareString(text4, "Mfg. Date", False) <> 0 Then
								If Operators.CompareString(text4, "Expiry Date", False) <> 0 Then
									text5 = ""
								Else
									text5 = "ExpDt"
								End If
							Else
								text5 = "MfgDt"
							End If
						Else
							text5 = "RequestDt"
						End If
					Else
						text5 = "ModificationDt"
					End If
				Else
					text5 = "CreationDt"
				End If
				Dim flag10 As Boolean = Operators.CompareString(text5, "", False) <> 0
				If flag10 Then
					Dim flag11 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
					If flag11 Then
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
			Dim flag12 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCode.Text), "", False) <> 0
			If flag12 Then
				text2 = text2 + " AND (M.ProductCode Like '%" + Strings.Trim(Me.txtCode.Text) + "%') "
				text = text + "MaterialCode LIKE " + Strings.Trim(Me.txtCode.Text) + vbCrLf
			End If
			Dim flag13 As Boolean = Operators.CompareString(Strings.Trim(Me.txtName.Text), "", False) <> 0
			If flag13 Then
				text2 = text2 + " AND (M.ProductName Like '%" + Strings.Trim(Me.txtName.Text) + "%') "
				text = text + "MaterialName LIKE " + Strings.Trim(Me.txtName.Text) + vbCrLf
			End If
			Dim flag14 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCatalogNo.Text), "", False) <> 0
			If flag14 Then
				text2 = text2 + " AND (M.CatalogNo Like '%" + Strings.Trim(Me.txtCatalogNo.Text) + "%') "
				text = text + "CatalogNo LIKE " + Strings.Trim(Me.txtCatalogNo.Text) + vbCrLf
			End If
			text2 += " ORDER BY RequestDt"
			Dim data As DataTable = MainModule.GetData(text2)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = Nothing
			Me.dgvList.DataSource = data
			Me.dgvList.Columns("ID").Visible = False
			Me.dgvList.Columns("RequestedBy").Visible = False
			Me.dgvList.Columns("ProductID").Visible = False
			Me.dgvList.Columns("RequestNo").HeaderText = "Request No."
			Me.dgvList.Columns("RequestDt").HeaderText = "Request Date"
			Me.dgvList.Columns("UserName").HeaderText = "Requested By"
			Me.dgvList.Columns("ProductCode").HeaderText = "Product Code"
			Me.dgvList.Columns("ProductType").HeaderText = "Product Type"
			Me.dgvList.Columns("ProductName").HeaderText = "Product Name"
			Me.dgvList.Columns("BatchNo").HeaderText = "Batch No."
			Me.dgvList.Columns("MfgDt").HeaderText = "Mfg. Date"
			Me.dgvList.Columns("ExpDt").HeaderText = "Expiry Date"
			Me.dgvList.Columns("BatchQty").HeaderText = "Batch Qty."
			Me.dgvList.Columns("BOMVersion").HeaderText = "BOM Version"
			Me.dgvList.Columns("RequestDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("MfgDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("ExpDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("RequestNo").Width = 130
			Me.dgvList.Columns("RequestDt").Width = 120
			Me.dgvList.Columns("UserName").Width = 225
			Me.dgvList.Columns("ProductCode").Width = 170
			Me.dgvList.Columns("ProductType").Width = 150
			Me.dgvList.Columns("ProductName").Width = 350
			Me.dgvList.Columns("BatchNo").Width = 130
			Me.dgvList.Columns("MfgDt").Width = 120
			Me.dgvList.Columns("ExpDt").Width = 120
			Me.dgvList.Columns("Status").Width = 132
			Me.dgvList.Columns("BatchQty").Width = 80
			Me.dgvList.Columns("BOMVersion").Width = 130
			Me.dgvList.Columns("BatchQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			Dim flag15 As Boolean = data.Columns.Contains("MaterialCode")
			If flag15 Then
				Me.dgvList.Columns("MaterialCode").HeaderText = "Material Code"
				Me.dgvList.Columns("MaterialCatalogNo").HeaderText = "Material Catalog No."
				Me.dgvList.Columns("MaterialName").HeaderText = "Material Name"
				Me.dgvList.Columns("MaterialType").HeaderText = "Material Type"
				Me.dgvList.Columns("PrimaryUOM").HeaderText = "Primary UOM"
				Me.dgvList.Columns("PrimaryPackSize").HeaderText = "Primary PackSize"
				Me.dgvList.Columns("RequiredQty").HeaderText = "Required Qty."
				Me.dgvList.Columns("MaterialBatchNo").HeaderText = "Material Batch No."
				Me.dgvList.Columns("IssuedQty").HeaderText = "Issued Qty."
				Me.dgvList.Columns("PickedQty").HeaderText = "Picked Qty."
				Me.dgvList.Columns("MaterialCode").Width = 180
				Me.dgvList.Columns("MaterialCatalogNo").Width = 180
				Me.dgvList.Columns("MaterialName").Width = 300
				Me.dgvList.Columns("MaterialType").Width = 110
				Me.dgvList.Columns("PrimaryUOM").Width = 90
				Me.dgvList.Columns("PrimaryPackSize").Width = 72
				Me.dgvList.Columns("RequiredQty").Width = 60
				Me.dgvList.Columns("IssuedQty").Width = 60
				Me.dgvList.Columns("PickedQty").Width = 60
				Me.dgvList.Columns("PrimaryPackSize").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("RequiredQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("IssuedQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("PickedQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x04000465 RID: 1125
		Private pnlBasicDefaultHeight As Integer

		' Token: 0x04000466 RID: 1126
		Private pnlBasicSetHeight As Integer

		' Token: 0x04000467 RID: 1127
		Private pnlAdvDefaultHeight As Integer

		' Token: 0x04000468 RID: 1128
		Private pnlAdvSetHeight As Integer
	End Class
End Namespace
