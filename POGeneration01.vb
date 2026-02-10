Imports System
Imports System.Collections.Generic
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
	' Token: 0x02000057 RID: 87
	<DesignerGenerated()>
	Public Partial Class POGeneration01
		Inherits DockContent

		' Token: 0x17000649 RID: 1609
		' (get) Token: 0x060010AC RID: 4268 RVA: 0x0009FB4D File Offset: 0x0009DD4D
		' (set) Token: 0x060010AD RID: 4269 RVA: 0x0009FB57 File Offset: 0x0009DD57
		Friend Overridable Property tpAddress As TabPage

		' Token: 0x1700064A RID: 1610
		' (get) Token: 0x060010AE RID: 4270 RVA: 0x0009FB60 File Offset: 0x0009DD60
		' (set) Token: 0x060010AF RID: 4271 RVA: 0x0009FB6A File Offset: 0x0009DD6A
		Friend Overridable Property txtShipEmailID As TextBox

		' Token: 0x1700064B RID: 1611
		' (get) Token: 0x060010B0 RID: 4272 RVA: 0x0009FB73 File Offset: 0x0009DD73
		' (set) Token: 0x060010B1 RID: 4273 RVA: 0x0009FB7D File Offset: 0x0009DD7D
		Friend Overridable Property Label2 As Label

		' Token: 0x1700064C RID: 1612
		' (get) Token: 0x060010B2 RID: 4274 RVA: 0x0009FB86 File Offset: 0x0009DD86
		' (set) Token: 0x060010B3 RID: 4275 RVA: 0x0009FB90 File Offset: 0x0009DD90
		Friend Overridable Property txtPANNo As TextBox

		' Token: 0x1700064D RID: 1613
		' (get) Token: 0x060010B4 RID: 4276 RVA: 0x0009FB99 File Offset: 0x0009DD99
		' (set) Token: 0x060010B5 RID: 4277 RVA: 0x0009FBA3 File Offset: 0x0009DDA3
		Friend Overridable Property Label14 As Label

		' Token: 0x1700064E RID: 1614
		' (get) Token: 0x060010B6 RID: 4278 RVA: 0x0009FBAC File Offset: 0x0009DDAC
		' (set) Token: 0x060010B7 RID: 4279 RVA: 0x0009FBB6 File Offset: 0x0009DDB6
		Friend Overridable Property txtGSTNo As TextBox

		' Token: 0x1700064F RID: 1615
		' (get) Token: 0x060010B8 RID: 4280 RVA: 0x0009FBBF File Offset: 0x0009DDBF
		' (set) Token: 0x060010B9 RID: 4281 RVA: 0x0009FBC9 File Offset: 0x0009DDC9
		Friend Overridable Property Label15 As Label

		' Token: 0x17000650 RID: 1616
		' (get) Token: 0x060010BA RID: 4282 RVA: 0x0009FBD2 File Offset: 0x0009DDD2
		' (set) Token: 0x060010BB RID: 4283 RVA: 0x0009FBDC File Offset: 0x0009DDDC
		Friend Overridable Property txtBillEmailID As TextBox

		' Token: 0x17000651 RID: 1617
		' (get) Token: 0x060010BC RID: 4284 RVA: 0x0009FBE5 File Offset: 0x0009DDE5
		' (set) Token: 0x060010BD RID: 4285 RVA: 0x0009FBEF File Offset: 0x0009DDEF
		Friend Overridable Property Label16 As Label

		' Token: 0x17000652 RID: 1618
		' (get) Token: 0x060010BE RID: 4286 RVA: 0x0009FBF8 File Offset: 0x0009DDF8
		' (set) Token: 0x060010BF RID: 4287 RVA: 0x0009FC04 File Offset: 0x0009DE04
		Friend Overridable Property llbInvoiceTo As LinkLabel
			<CompilerGenerated()>
			Get
				Return Me._llbInvoiceTo
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim linkLabelLinkClickedEventHandler As LinkLabelLinkClickedEventHandler = AddressOf Me.llbInvoiceTo_LinkClicked
				Dim linkLabel As LinkLabel = Me._llbInvoiceTo
				If linkLabel IsNot Nothing Then
					RemoveHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
				Me._llbInvoiceTo = value
				linkLabel = Me._llbInvoiceTo
				If linkLabel IsNot Nothing Then
					AddHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000653 RID: 1619
		' (get) Token: 0x060010C0 RID: 4288 RVA: 0x0009FC47 File Offset: 0x0009DE47
		' (set) Token: 0x060010C1 RID: 4289 RVA: 0x0009FC54 File Offset: 0x0009DE54
		Friend Overridable Property llbShipTo As LinkLabel
			<CompilerGenerated()>
			Get
				Return Me._llbShipTo
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim linkLabelLinkClickedEventHandler As LinkLabelLinkClickedEventHandler = AddressOf Me.llbShipTo_LinkClicked
				Dim linkLabel As LinkLabel = Me._llbShipTo
				If linkLabel IsNot Nothing Then
					RemoveHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
				Me._llbShipTo = value
				linkLabel = Me._llbShipTo
				If linkLabel IsNot Nothing Then
					AddHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000654 RID: 1620
		' (get) Token: 0x060010C2 RID: 4290 RVA: 0x0009FC97 File Offset: 0x0009DE97
		' (set) Token: 0x060010C3 RID: 4291 RVA: 0x0009FCA1 File Offset: 0x0009DEA1
		Friend Overridable Property txtShipTo As TextBox

		' Token: 0x17000655 RID: 1621
		' (get) Token: 0x060010C4 RID: 4292 RVA: 0x0009FCAA File Offset: 0x0009DEAA
		' (set) Token: 0x060010C5 RID: 4293 RVA: 0x0009FCB4 File Offset: 0x0009DEB4
		Friend Overridable Property txtInvoiceTo As TextBox

		' Token: 0x17000656 RID: 1622
		' (get) Token: 0x060010C6 RID: 4294 RVA: 0x0009FCBD File Offset: 0x0009DEBD
		' (set) Token: 0x060010C7 RID: 4295 RVA: 0x0009FCC7 File Offset: 0x0009DEC7
		Friend Overridable Property tab_lbl1 As Label

		' Token: 0x17000657 RID: 1623
		' (get) Token: 0x060010C8 RID: 4296 RVA: 0x0009FCD0 File Offset: 0x0009DED0
		' (set) Token: 0x060010C9 RID: 4297 RVA: 0x0009FCDA File Offset: 0x0009DEDA
		Friend Overridable Property txtVendorPAN As TextBox

		' Token: 0x17000658 RID: 1624
		' (get) Token: 0x060010CA RID: 4298 RVA: 0x0009FCE3 File Offset: 0x0009DEE3
		' (set) Token: 0x060010CB RID: 4299 RVA: 0x0009FCED File Offset: 0x0009DEED
		Friend Overridable Property Label1 As Label

		' Token: 0x17000659 RID: 1625
		' (get) Token: 0x060010CC RID: 4300 RVA: 0x0009FCF6 File Offset: 0x0009DEF6
		' (set) Token: 0x060010CD RID: 4301 RVA: 0x0009FD00 File Offset: 0x0009DF00
		Friend Overridable Property txtVendorGST As TextBox

		' Token: 0x1700065A RID: 1626
		' (get) Token: 0x060010CE RID: 4302 RVA: 0x0009FD09 File Offset: 0x0009DF09
		' (set) Token: 0x060010CF RID: 4303 RVA: 0x0009FD13 File Offset: 0x0009DF13
		Friend Overridable Property Label6 As Label

		' Token: 0x1700065B RID: 1627
		' (get) Token: 0x060010D0 RID: 4304 RVA: 0x0009FD1C File Offset: 0x0009DF1C
		' (set) Token: 0x060010D1 RID: 4305 RVA: 0x0009FD26 File Offset: 0x0009DF26
		Friend Overridable Property txtVendorEmail As TextBox

		' Token: 0x1700065C RID: 1628
		' (get) Token: 0x060010D2 RID: 4306 RVA: 0x0009FD2F File Offset: 0x0009DF2F
		' (set) Token: 0x060010D3 RID: 4307 RVA: 0x0009FD39 File Offset: 0x0009DF39
		Friend Overridable Property Label7 As Label

		' Token: 0x1700065D RID: 1629
		' (get) Token: 0x060010D4 RID: 4308 RVA: 0x0009FD42 File Offset: 0x0009DF42
		' (set) Token: 0x060010D5 RID: 4309 RVA: 0x0009FD4C File Offset: 0x0009DF4C
		Friend Overridable Property txtVendorContactNo As TextBox

		' Token: 0x1700065E RID: 1630
		' (get) Token: 0x060010D6 RID: 4310 RVA: 0x0009FD55 File Offset: 0x0009DF55
		' (set) Token: 0x060010D7 RID: 4311 RVA: 0x0009FD5F File Offset: 0x0009DF5F
		Friend Overridable Property Label8 As Label

		' Token: 0x1700065F RID: 1631
		' (get) Token: 0x060010D8 RID: 4312 RVA: 0x0009FD68 File Offset: 0x0009DF68
		' (set) Token: 0x060010D9 RID: 4313 RVA: 0x0009FD72 File Offset: 0x0009DF72
		Friend Overridable Property txtVendorContact As TextBox

		' Token: 0x17000660 RID: 1632
		' (get) Token: 0x060010DA RID: 4314 RVA: 0x0009FD7B File Offset: 0x0009DF7B
		' (set) Token: 0x060010DB RID: 4315 RVA: 0x0009FD85 File Offset: 0x0009DF85
		Friend Overridable Property Label10 As Label

		' Token: 0x17000661 RID: 1633
		' (get) Token: 0x060010DC RID: 4316 RVA: 0x0009FD8E File Offset: 0x0009DF8E
		' (set) Token: 0x060010DD RID: 4317 RVA: 0x0009FD98 File Offset: 0x0009DF98
		Friend Overridable Property txtVendorBillTo As TextBox

		' Token: 0x17000662 RID: 1634
		' (get) Token: 0x060010DE RID: 4318 RVA: 0x0009FDA1 File Offset: 0x0009DFA1
		' (set) Token: 0x060010DF RID: 4319 RVA: 0x0009FDAC File Offset: 0x0009DFAC
		Friend Overridable Property llbVendorBillTo As LinkLabel
			<CompilerGenerated()>
			Get
				Return Me._llbVendorBillTo
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim linkLabelLinkClickedEventHandler As LinkLabelLinkClickedEventHandler = AddressOf Me.llbVendorBillTo_LinkClicked
				Dim linkLabel As LinkLabel = Me._llbVendorBillTo
				If linkLabel IsNot Nothing Then
					RemoveHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
				Me._llbVendorBillTo = value
				linkLabel = Me._llbVendorBillTo
				If linkLabel IsNot Nothing Then
					AddHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000663 RID: 1635
		' (get) Token: 0x060010E0 RID: 4320 RVA: 0x0009FDEF File Offset: 0x0009DFEF
		' (set) Token: 0x060010E1 RID: 4321 RVA: 0x0009FDFC File Offset: 0x0009DFFC
		Friend Overridable Property cmbVendor As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbVendor
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbVendor_Validated
				Dim eventHandler2 As EventHandler = AddressOf Me.cmbVendor_SelectedIndexChanged
				Dim comboBox As ComboBox = Me._cmbVendor
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.Validated, eventHandler
					RemoveHandler comboBox.SelectedIndexChanged, eventHandler2
				End If
				Me._cmbVendor = value
				comboBox = Me._cmbVendor
				If comboBox IsNot Nothing Then
					AddHandler comboBox.Validated, eventHandler
					AddHandler comboBox.SelectedIndexChanged, eventHandler2
				End If
			End Set
		End Property

		' Token: 0x17000664 RID: 1636
		' (get) Token: 0x060010E2 RID: 4322 RVA: 0x0009FE5A File Offset: 0x0009E05A
		' (set) Token: 0x060010E3 RID: 4323 RVA: 0x0009FE64 File Offset: 0x0009E064
		Friend Overridable Property Label9 As Label

		' Token: 0x17000665 RID: 1637
		' (get) Token: 0x060010E4 RID: 4324 RVA: 0x0009FE6D File Offset: 0x0009E06D
		' (set) Token: 0x060010E5 RID: 4325 RVA: 0x0009FE77 File Offset: 0x0009E077
		Friend Overridable Property tpVendor As TabPage

		' Token: 0x17000666 RID: 1638
		' (get) Token: 0x060010E6 RID: 4326 RVA: 0x0009FE80 File Offset: 0x0009E080
		' (set) Token: 0x060010E7 RID: 4327 RVA: 0x0009FE8A File Offset: 0x0009E08A
		Friend Overridable Property tab_lbl2 As Label

		' Token: 0x17000667 RID: 1639
		' (get) Token: 0x060010E8 RID: 4328 RVA: 0x0009FE93 File Offset: 0x0009E093
		' (set) Token: 0x060010E9 RID: 4329 RVA: 0x0009FE9D File Offset: 0x0009E09D
		Friend Overridable Property flpButton As FlowLayoutPanel

		' Token: 0x17000668 RID: 1640
		' (get) Token: 0x060010EA RID: 4330 RVA: 0x0009FEA6 File Offset: 0x0009E0A6
		' (set) Token: 0x060010EB RID: 4331 RVA: 0x0009FEB0 File Offset: 0x0009E0B0
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

		' Token: 0x17000669 RID: 1641
		' (get) Token: 0x060010EC RID: 4332 RVA: 0x0009FEF3 File Offset: 0x0009E0F3
		' (set) Token: 0x060010ED RID: 4333 RVA: 0x0009FF00 File Offset: 0x0009E100
		Friend Overridable Property btnApprove As Button
			<CompilerGenerated()>
			Get
				Return Me._btnApprove
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnApprove_Click
				Dim button As Button = Me._btnApprove
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnApprove = value
				button = Me._btnApprove
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700066A RID: 1642
		' (get) Token: 0x060010EE RID: 4334 RVA: 0x0009FF43 File Offset: 0x0009E143
		' (set) Token: 0x060010EF RID: 4335 RVA: 0x0009FF50 File Offset: 0x0009E150
		Friend Overridable Property btnOnHold As Button
			<CompilerGenerated()>
			Get
				Return Me._btnOnHold
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnOnHold_Click
				Dim button As Button = Me._btnOnHold
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnOnHold = value
				button = Me._btnOnHold
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700066B RID: 1643
		' (get) Token: 0x060010F0 RID: 4336 RVA: 0x0009FF93 File Offset: 0x0009E193
		' (set) Token: 0x060010F1 RID: 4337 RVA: 0x0009FFA0 File Offset: 0x0009E1A0
		Friend Overridable Property btnReject As Button
			<CompilerGenerated()>
			Get
				Return Me._btnReject
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnReject_Click
				Dim button As Button = Me._btnReject
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnReject = value
				button = Me._btnReject
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700066C RID: 1644
		' (get) Token: 0x060010F2 RID: 4338 RVA: 0x0009FFE3 File Offset: 0x0009E1E3
		' (set) Token: 0x060010F3 RID: 4339 RVA: 0x0009FFF0 File Offset: 0x0009E1F0
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

		' Token: 0x1700066D RID: 1645
		' (get) Token: 0x060010F4 RID: 4340 RVA: 0x000A0033 File Offset: 0x0009E233
		' (set) Token: 0x060010F5 RID: 4341 RVA: 0x000A0040 File Offset: 0x0009E240
		Friend Overridable Property btnAmend As Button
			<CompilerGenerated()>
			Get
				Return Me._btnAmend
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnAmend_Click
				Dim button As Button = Me._btnAmend
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnAmend = value
				button = Me._btnAmend
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700066E RID: 1646
		' (get) Token: 0x060010F6 RID: 4342 RVA: 0x000A0083 File Offset: 0x0009E283
		' (set) Token: 0x060010F7 RID: 4343 RVA: 0x000A0090 File Offset: 0x0009E290
		Friend Overridable Property btnCancel As Button
			<CompilerGenerated()>
			Get
				Return Me._btnCancel
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnCancel_Click
				Dim button As Button = Me._btnCancel
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnCancel = value
				button = Me._btnCancel
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700066F RID: 1647
		' (get) Token: 0x060010F8 RID: 4344 RVA: 0x000A00D3 File Offset: 0x0009E2D3
		' (set) Token: 0x060010F9 RID: 4345 RVA: 0x000A00E0 File Offset: 0x0009E2E0
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

		' Token: 0x17000670 RID: 1648
		' (get) Token: 0x060010FA RID: 4346 RVA: 0x000A0123 File Offset: 0x0009E323
		' (set) Token: 0x060010FB RID: 4347 RVA: 0x000A0130 File Offset: 0x0009E330
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

		' Token: 0x17000671 RID: 1649
		' (get) Token: 0x060010FC RID: 4348 RVA: 0x000A0173 File Offset: 0x0009E373
		' (set) Token: 0x060010FD RID: 4349 RVA: 0x000A017D File Offset: 0x0009E37D
		Friend Overridable Property theme_tc As TabControl

		' Token: 0x17000672 RID: 1650
		' (get) Token: 0x060010FE RID: 4350 RVA: 0x000A0186 File Offset: 0x0009E386
		' (set) Token: 0x060010FF RID: 4351 RVA: 0x000A0190 File Offset: 0x0009E390
		Friend Overridable Property tpItems As TabPage

		' Token: 0x17000673 RID: 1651
		' (get) Token: 0x06001100 RID: 4352 RVA: 0x000A0199 File Offset: 0x0009E399
		' (set) Token: 0x06001101 RID: 4353 RVA: 0x000A01A3 File Offset: 0x0009E3A3
		Friend Overridable Property tab_lbl3 As Label

		' Token: 0x17000674 RID: 1652
		' (get) Token: 0x06001102 RID: 4354 RVA: 0x000A01AC File Offset: 0x0009E3AC
		' (set) Token: 0x06001103 RID: 4355 RVA: 0x000A01B8 File Offset: 0x0009E3B8
		Friend Overridable Property dgvDtls As DataGridView
			<CompilerGenerated()>
			Get
				Return Me._dgvDtls
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim dataGridViewCellEventHandler As DataGridViewCellEventHandler = AddressOf Me.dgvDtls_CellDoubleClick
				Dim dataGridView As DataGridView = Me._dgvDtls
				If dataGridView IsNot Nothing Then
					RemoveHandler dataGridView.CellDoubleClick, dataGridViewCellEventHandler
				End If
				Me._dgvDtls = value
				dataGridView = Me._dgvDtls
				If dataGridView IsNot Nothing Then
					AddHandler dataGridView.CellDoubleClick, dataGridViewCellEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000675 RID: 1653
		' (get) Token: 0x06001104 RID: 4356 RVA: 0x000A01FB File Offset: 0x0009E3FB
		' (set) Token: 0x06001105 RID: 4357 RVA: 0x000A0208 File Offset: 0x0009E408
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

		' Token: 0x17000676 RID: 1654
		' (get) Token: 0x06001106 RID: 4358 RVA: 0x000A024B File Offset: 0x0009E44B
		' (set) Token: 0x06001107 RID: 4359 RVA: 0x000A0255 File Offset: 0x0009E455
		Friend Overridable Property tpTerms As TabPage

		' Token: 0x17000677 RID: 1655
		' (get) Token: 0x06001108 RID: 4360 RVA: 0x000A025E File Offset: 0x0009E45E
		' (set) Token: 0x06001109 RID: 4361 RVA: 0x000A0268 File Offset: 0x0009E468
		Friend Overridable Property Label18 As Label

		' Token: 0x17000678 RID: 1656
		' (get) Token: 0x0600110A RID: 4362 RVA: 0x000A0271 File Offset: 0x0009E471
		' (set) Token: 0x0600110B RID: 4363 RVA: 0x000A027B File Offset: 0x0009E47B
		Friend Overridable Property txtDeliveryTerms As TextBox

		' Token: 0x17000679 RID: 1657
		' (get) Token: 0x0600110C RID: 4364 RVA: 0x000A0284 File Offset: 0x0009E484
		' (set) Token: 0x0600110D RID: 4365 RVA: 0x000A028E File Offset: 0x0009E48E
		Friend Overridable Property Label19 As Label

		' Token: 0x1700067A RID: 1658
		' (get) Token: 0x0600110E RID: 4366 RVA: 0x000A0297 File Offset: 0x0009E497
		' (set) Token: 0x0600110F RID: 4367 RVA: 0x000A02A1 File Offset: 0x0009E4A1
		Friend Overridable Property txtIncoTerms As TextBox

		' Token: 0x1700067B RID: 1659
		' (get) Token: 0x06001110 RID: 4368 RVA: 0x000A02AA File Offset: 0x0009E4AA
		' (set) Token: 0x06001111 RID: 4369 RVA: 0x000A02B4 File Offset: 0x0009E4B4
		Friend Overridable Property Label20 As Label

		' Token: 0x1700067C RID: 1660
		' (get) Token: 0x06001112 RID: 4370 RVA: 0x000A02BD File Offset: 0x0009E4BD
		' (set) Token: 0x06001113 RID: 4371 RVA: 0x000A02C7 File Offset: 0x0009E4C7
		Friend Overridable Property cmbCurrency As ComboBox

		' Token: 0x1700067D RID: 1661
		' (get) Token: 0x06001114 RID: 4372 RVA: 0x000A02D0 File Offset: 0x0009E4D0
		' (set) Token: 0x06001115 RID: 4373 RVA: 0x000A02DA File Offset: 0x0009E4DA
		Friend Overridable Property Label21 As Label

		' Token: 0x1700067E RID: 1662
		' (get) Token: 0x06001116 RID: 4374 RVA: 0x000A02E3 File Offset: 0x0009E4E3
		' (set) Token: 0x06001117 RID: 4375 RVA: 0x000A02ED File Offset: 0x0009E4ED
		Friend Overridable Property txtPaymentTerms As TextBox

		' Token: 0x1700067F RID: 1663
		' (get) Token: 0x06001118 RID: 4376 RVA: 0x000A02F6 File Offset: 0x0009E4F6
		' (set) Token: 0x06001119 RID: 4377 RVA: 0x000A0300 File Offset: 0x0009E500
		Friend Overridable Property txtDispatchThrough As TextBox

		' Token: 0x17000680 RID: 1664
		' (get) Token: 0x0600111A RID: 4378 RVA: 0x000A0309 File Offset: 0x0009E509
		' (set) Token: 0x0600111B RID: 4379 RVA: 0x000A0313 File Offset: 0x0009E513
		Friend Overridable Property Label22 As Label

		' Token: 0x17000681 RID: 1665
		' (get) Token: 0x0600111C RID: 4380 RVA: 0x000A031C File Offset: 0x0009E51C
		' (set) Token: 0x0600111D RID: 4381 RVA: 0x000A0326 File Offset: 0x0009E526
		Friend Overridable Property cmbModeOfPayment As ComboBox

		' Token: 0x17000682 RID: 1666
		' (get) Token: 0x0600111E RID: 4382 RVA: 0x000A032F File Offset: 0x0009E52F
		' (set) Token: 0x0600111F RID: 4383 RVA: 0x000A0339 File Offset: 0x0009E539
		Friend Overridable Property Label29 As Label

		' Token: 0x17000683 RID: 1667
		' (get) Token: 0x06001120 RID: 4384 RVA: 0x000A0342 File Offset: 0x0009E542
		' (set) Token: 0x06001121 RID: 4385 RVA: 0x000A034C File Offset: 0x0009E54C
		Friend Overridable Property tab_lbl4 As Label

		' Token: 0x17000684 RID: 1668
		' (get) Token: 0x06001122 RID: 4386 RVA: 0x000A0355 File Offset: 0x0009E555
		' (set) Token: 0x06001123 RID: 4387 RVA: 0x000A035F File Offset: 0x0009E55F
		Friend Overridable Property tpDoc As TabPage

		' Token: 0x17000685 RID: 1669
		' (get) Token: 0x06001124 RID: 4388 RVA: 0x000A0368 File Offset: 0x0009E568
		' (set) Token: 0x06001125 RID: 4389 RVA: 0x000A0372 File Offset: 0x0009E572
		Friend Overridable Property tab_lbl5 As Label

		' Token: 0x17000686 RID: 1670
		' (get) Token: 0x06001126 RID: 4390 RVA: 0x000A037B File Offset: 0x0009E57B
		' (set) Token: 0x06001127 RID: 4391 RVA: 0x000A0388 File Offset: 0x0009E588
		Friend Overridable Property llbFile As LinkLabel
			<CompilerGenerated()>
			Get
				Return Me._llbFile
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim linkLabelLinkClickedEventHandler As LinkLabelLinkClickedEventHandler = AddressOf Me.lblFile_LinkClicked
				Dim linkLabel As LinkLabel = Me._llbFile
				If linkLabel IsNot Nothing Then
					RemoveHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
				Me._llbFile = value
				linkLabel = Me._llbFile
				If linkLabel IsNot Nothing Then
					AddHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000687 RID: 1671
		' (get) Token: 0x06001128 RID: 4392 RVA: 0x000A03CB File Offset: 0x0009E5CB
		' (set) Token: 0x06001129 RID: 4393 RVA: 0x000A03D8 File Offset: 0x0009E5D8
		Friend Overridable Property dgvFile As DataGridView
			<CompilerGenerated()>
			Get
				Return Me._dgvFile
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim dataGridViewCellEventHandler As DataGridViewCellEventHandler = AddressOf Me.dgvFile_CellContentClick
				Dim dataGridView As DataGridView = Me._dgvFile
				If dataGridView IsNot Nothing Then
					RemoveHandler dataGridView.CellContentClick, dataGridViewCellEventHandler
				End If
				Me._dgvFile = value
				dataGridView = Me._dgvFile
				If dataGridView IsNot Nothing Then
					AddHandler dataGridView.CellContentClick, dataGridViewCellEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000688 RID: 1672
		' (get) Token: 0x0600112A RID: 4394 RVA: 0x000A041B File Offset: 0x0009E61B
		' (set) Token: 0x0600112B RID: 4395 RVA: 0x000A0425 File Offset: 0x0009E625
		Friend Overridable Property FileID As DataGridViewTextBoxColumn

		' Token: 0x17000689 RID: 1673
		' (get) Token: 0x0600112C RID: 4396 RVA: 0x000A042E File Offset: 0x0009E62E
		' (set) Token: 0x0600112D RID: 4397 RVA: 0x000A0438 File Offset: 0x0009E638
		Friend Overridable Property btnDownload_File As DataGridViewImageColumn

		' Token: 0x1700068A RID: 1674
		' (get) Token: 0x0600112E RID: 4398 RVA: 0x000A0441 File Offset: 0x0009E641
		' (set) Token: 0x0600112F RID: 4399 RVA: 0x000A044B File Offset: 0x0009E64B
		Friend Overridable Property FileName As DataGridViewTextBoxColumn

		' Token: 0x1700068B RID: 1675
		' (get) Token: 0x06001130 RID: 4400 RVA: 0x000A0454 File Offset: 0x0009E654
		' (set) Token: 0x06001131 RID: 4401 RVA: 0x000A045E File Offset: 0x0009E65E
		Friend Overridable Property btnDelete_File As DataGridViewImageColumn

		' Token: 0x1700068C RID: 1676
		' (get) Token: 0x06001132 RID: 4402 RVA: 0x000A0467 File Offset: 0x0009E667
		' (set) Token: 0x06001133 RID: 4403 RVA: 0x000A0471 File Offset: 0x0009E671
		Friend Overridable Property tpRemarks As TabPage

		' Token: 0x1700068D RID: 1677
		' (get) Token: 0x06001134 RID: 4404 RVA: 0x000A047A File Offset: 0x0009E67A
		' (set) Token: 0x06001135 RID: 4405 RVA: 0x000A0484 File Offset: 0x0009E684
		Friend Overridable Property tab_lbl6 As Label

		' Token: 0x1700068E RID: 1678
		' (get) Token: 0x06001136 RID: 4406 RVA: 0x000A048D File Offset: 0x0009E68D
		' (set) Token: 0x06001137 RID: 4407 RVA: 0x000A0497 File Offset: 0x0009E697
		Friend Overridable Property lblRemarksApproval1 As Label

		' Token: 0x1700068F RID: 1679
		' (get) Token: 0x06001138 RID: 4408 RVA: 0x000A04A0 File Offset: 0x0009E6A0
		' (set) Token: 0x06001139 RID: 4409 RVA: 0x000A04AA File Offset: 0x0009E6AA
		Friend Overridable Property lblRemarks1 As Label

		' Token: 0x17000690 RID: 1680
		' (get) Token: 0x0600113A RID: 4410 RVA: 0x000A04B3 File Offset: 0x0009E6B3
		' (set) Token: 0x0600113B RID: 4411 RVA: 0x000A04BD File Offset: 0x0009E6BD
		Friend Overridable Property Panel4 As Panel

		' Token: 0x17000691 RID: 1681
		' (get) Token: 0x0600113C RID: 4412 RVA: 0x000A04C6 File Offset: 0x0009E6C6
		' (set) Token: 0x0600113D RID: 4413 RVA: 0x000A04D0 File Offset: 0x0009E6D0
		Friend Overridable Property txtRemarksApproval As TextBox

		' Token: 0x17000692 RID: 1682
		' (get) Token: 0x0600113E RID: 4414 RVA: 0x000A04D9 File Offset: 0x0009E6D9
		' (set) Token: 0x0600113F RID: 4415 RVA: 0x000A04E3 File Offset: 0x0009E6E3
		Friend Overridable Property txtRemarks As TextBox

		' Token: 0x17000693 RID: 1683
		' (get) Token: 0x06001140 RID: 4416 RVA: 0x000A04EC File Offset: 0x0009E6EC
		' (set) Token: 0x06001141 RID: 4417 RVA: 0x000A04F8 File Offset: 0x0009E6F8
		Friend Overridable Property lblRemarks As Label
			<CompilerGenerated()>
			Get
				Return Me._lblRemarks
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim eventHandler As EventHandler = AddressOf Me.lblRemarks_Click
				Dim label As Label = Me._lblRemarks
				If label IsNot Nothing Then
					RemoveHandler label.Click, eventHandler
				End If
				Me._lblRemarks = value
				label = Me._lblRemarks
				If label IsNot Nothing Then
					AddHandler label.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000694 RID: 1684
		' (get) Token: 0x06001142 RID: 4418 RVA: 0x000A053B File Offset: 0x0009E73B
		' (set) Token: 0x06001143 RID: 4419 RVA: 0x000A0548 File Offset: 0x0009E748
		Friend Overridable Property lblRemarksApproval As Label
			<CompilerGenerated()>
			Get
				Return Me._lblRemarksApproval
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim eventHandler As EventHandler = AddressOf Me.lblRemarksApproval_Click
				Dim label As Label = Me._lblRemarksApproval
				If label IsNot Nothing Then
					RemoveHandler label.Click, eventHandler
				End If
				Me._lblRemarksApproval = value
				label = Me._lblRemarksApproval
				If label IsNot Nothing Then
					AddHandler label.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000695 RID: 1685
		' (get) Token: 0x06001144 RID: 4420 RVA: 0x000A058B File Offset: 0x0009E78B
		' (set) Token: 0x06001145 RID: 4421 RVA: 0x000A0595 File Offset: 0x0009E795
		Friend Overridable Property grpItems As GroupBox

		' Token: 0x17000696 RID: 1686
		' (get) Token: 0x06001146 RID: 4422 RVA: 0x000A059E File Offset: 0x0009E79E
		' (set) Token: 0x06001147 RID: 4423 RVA: 0x000A05A8 File Offset: 0x0009E7A8
		Friend Overridable Property Panel3 As Panel

		' Token: 0x17000697 RID: 1687
		' (get) Token: 0x06001148 RID: 4424 RVA: 0x000A05B1 File Offset: 0x0009E7B1
		' (set) Token: 0x06001149 RID: 4425 RVA: 0x000A05BB File Offset: 0x0009E7BB
		Friend Overridable Property txtTotal As TextBox

		' Token: 0x17000698 RID: 1688
		' (get) Token: 0x0600114A RID: 4426 RVA: 0x000A05C4 File Offset: 0x0009E7C4
		' (set) Token: 0x0600114B RID: 4427 RVA: 0x000A05CE File Offset: 0x0009E7CE
		Friend Overridable Property Label38 As Label

		' Token: 0x17000699 RID: 1689
		' (get) Token: 0x0600114C RID: 4428 RVA: 0x000A05D7 File Offset: 0x0009E7D7
		' (set) Token: 0x0600114D RID: 4429 RVA: 0x000A05E1 File Offset: 0x0009E7E1
		Friend Overridable Property grpPO As GroupBox

		' Token: 0x1700069A RID: 1690
		' (get) Token: 0x0600114E RID: 4430 RVA: 0x000A05EA File Offset: 0x0009E7EA
		' (set) Token: 0x0600114F RID: 4431 RVA: 0x000A05F4 File Offset: 0x0009E7F4
		Friend Overridable Property skip_lblStatus As Label

		' Token: 0x1700069B RID: 1691
		' (get) Token: 0x06001150 RID: 4432 RVA: 0x000A05FD File Offset: 0x0009E7FD
		' (set) Token: 0x06001151 RID: 4433 RVA: 0x000A0607 File Offset: 0x0009E807
		Friend Overridable Property skip_lblPO As Label

		' Token: 0x1700069C RID: 1692
		' (get) Token: 0x06001152 RID: 4434 RVA: 0x000A0610 File Offset: 0x0009E810
		' (set) Token: 0x06001153 RID: 4435 RVA: 0x000A061A File Offset: 0x0009E81A
		Friend Overridable Property Label11 As Label

		' Token: 0x1700069D RID: 1693
		' (get) Token: 0x06001154 RID: 4436 RVA: 0x000A0623 File Offset: 0x0009E823
		' (set) Token: 0x06001155 RID: 4437 RVA: 0x000A0630 File Offset: 0x0009E830
		Friend Overridable Property txtID As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtID
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim eventHandler As EventHandler = AddressOf Me.txtID_TextChanged
				Dim textBox As TextBox = Me._txtID
				If textBox IsNot Nothing Then
					RemoveHandler textBox.TextChanged, eventHandler
				End If
				Me._txtID = value
				textBox = Me._txtID
				If textBox IsNot Nothing Then
					AddHandler textBox.TextChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700069E RID: 1694
		' (get) Token: 0x06001156 RID: 4438 RVA: 0x000A0673 File Offset: 0x0009E873
		' (set) Token: 0x06001157 RID: 4439 RVA: 0x000A0680 File Offset: 0x0009E880
		Friend Overridable Property txtDelivery As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtDelivery
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim eventHandler As EventHandler = AddressOf Me.txtDelivery_TextChanged
				Dim textBox As TextBox = Me._txtDelivery
				If textBox IsNot Nothing Then
					RemoveHandler textBox.TextChanged, eventHandler
				End If
				Me._txtDelivery = value
				textBox = Me._txtDelivery
				If textBox IsNot Nothing Then
					AddHandler textBox.TextChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700069F RID: 1695
		' (get) Token: 0x06001158 RID: 4440 RVA: 0x000A06C3 File Offset: 0x0009E8C3
		' (set) Token: 0x06001159 RID: 4441 RVA: 0x000A06CD File Offset: 0x0009E8CD
		Friend Overridable Property Label3 As Label

		' Token: 0x170006A0 RID: 1696
		' (get) Token: 0x0600115A RID: 4442 RVA: 0x000A06D6 File Offset: 0x0009E8D6
		' (set) Token: 0x0600115B RID: 4443 RVA: 0x000A06E0 File Offset: 0x0009E8E0
		Friend Overridable Property cmbPOType As ComboBox

		' Token: 0x170006A1 RID: 1697
		' (get) Token: 0x0600115C RID: 4444 RVA: 0x000A06E9 File Offset: 0x0009E8E9
		' (set) Token: 0x0600115D RID: 4445 RVA: 0x000A06F3 File Offset: 0x0009E8F3
		Friend Overridable Property cmbDept As ComboBox

		' Token: 0x170006A2 RID: 1698
		' (get) Token: 0x0600115E RID: 4446 RVA: 0x000A06FC File Offset: 0x0009E8FC
		' (set) Token: 0x0600115F RID: 4447 RVA: 0x000A0706 File Offset: 0x0009E906
		Friend Overridable Property dtpDt As DateTimePicker

		' Token: 0x170006A3 RID: 1699
		' (get) Token: 0x06001160 RID: 4448 RVA: 0x000A070F File Offset: 0x0009E90F
		' (set) Token: 0x06001161 RID: 4449 RVA: 0x000A0719 File Offset: 0x0009E919
		Friend Overridable Property Label4 As Label

		' Token: 0x170006A4 RID: 1700
		' (get) Token: 0x06001162 RID: 4450 RVA: 0x000A0722 File Offset: 0x0009E922
		' (set) Token: 0x06001163 RID: 4451 RVA: 0x000A072C File Offset: 0x0009E92C
		Friend Overridable Property Label28 As Label

		' Token: 0x170006A5 RID: 1701
		' (get) Token: 0x06001164 RID: 4452 RVA: 0x000A0735 File Offset: 0x0009E935
		' (set) Token: 0x06001165 RID: 4453 RVA: 0x000A073F File Offset: 0x0009E93F
		Friend Overridable Property dtpDelDt As DateTimePicker

		' Token: 0x170006A6 RID: 1702
		' (get) Token: 0x06001166 RID: 4454 RVA: 0x000A0748 File Offset: 0x0009E948
		' (set) Token: 0x06001167 RID: 4455 RVA: 0x000A0752 File Offset: 0x0009E952
		Friend Overridable Property Label27 As Label

		' Token: 0x170006A7 RID: 1703
		' (get) Token: 0x06001168 RID: 4456 RVA: 0x000A075B File Offset: 0x0009E95B
		' (set) Token: 0x06001169 RID: 4457 RVA: 0x000A0765 File Offset: 0x0009E965
		Friend Overridable Property Label5 As Label

		' Token: 0x170006A8 RID: 1704
		' (get) Token: 0x0600116A RID: 4458 RVA: 0x000A076E File Offset: 0x0009E96E
		' (set) Token: 0x0600116B RID: 4459 RVA: 0x000A0778 File Offset: 0x0009E978
		Friend Overridable Property txtNo As TextBox

		' Token: 0x170006A9 RID: 1705
		' (get) Token: 0x0600116C RID: 4460 RVA: 0x000A0781 File Offset: 0x0009E981
		' (set) Token: 0x0600116D RID: 4461 RVA: 0x000A078B File Offset: 0x0009E98B
		Friend Overridable Property dtpValidity As DateTimePicker

		' Token: 0x170006AA RID: 1706
		' (get) Token: 0x0600116E RID: 4462 RVA: 0x000A0794 File Offset: 0x0009E994
		' (set) Token: 0x0600116F RID: 4463 RVA: 0x000A079E File Offset: 0x0009E99E
		Friend Overridable Property dtpPRDt As DateTimePicker

		' Token: 0x170006AB RID: 1707
		' (get) Token: 0x06001170 RID: 4464 RVA: 0x000A07A7 File Offset: 0x0009E9A7
		' (set) Token: 0x06001171 RID: 4465 RVA: 0x000A07B1 File Offset: 0x0009E9B1
		Friend Overridable Property Label24 As Label

		' Token: 0x170006AC RID: 1708
		' (get) Token: 0x06001172 RID: 4466 RVA: 0x000A07BA File Offset: 0x0009E9BA
		' (set) Token: 0x06001173 RID: 4467 RVA: 0x000A07C4 File Offset: 0x0009E9C4
		Friend Overridable Property Label26 As Label

		' Token: 0x170006AD RID: 1709
		' (get) Token: 0x06001174 RID: 4468 RVA: 0x000A07CD File Offset: 0x0009E9CD
		' (set) Token: 0x06001175 RID: 4469 RVA: 0x000A07D7 File Offset: 0x0009E9D7
		Friend Overridable Property Label25 As Label

		' Token: 0x170006AE RID: 1710
		' (get) Token: 0x06001176 RID: 4470 RVA: 0x000A07E0 File Offset: 0x0009E9E0
		' (set) Token: 0x06001177 RID: 4471 RVA: 0x000A07EA File Offset: 0x0009E9EA
		Friend Overridable Property txtPRNo As TextBox

		' Token: 0x170006AF RID: 1711
		' (get) Token: 0x06001178 RID: 4472 RVA: 0x000A07F3 File Offset: 0x0009E9F3
		' (set) Token: 0x06001179 RID: 4473 RVA: 0x000A07FD File Offset: 0x0009E9FD
		Friend Overridable Property tpPR As TabPage

		' Token: 0x170006B0 RID: 1712
		' (get) Token: 0x0600117A RID: 4474 RVA: 0x000A0806 File Offset: 0x0009EA06
		' (set) Token: 0x0600117B RID: 4475 RVA: 0x000A0810 File Offset: 0x0009EA10
		Friend Overridable Property llbAddPR As LinkLabel
			<CompilerGenerated()>
			Get
				Return Me._llbAddPR
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim linkLabelLinkClickedEventHandler As LinkLabelLinkClickedEventHandler = AddressOf Me.llbAddPR_LinkClicked
				Dim linkLabel As LinkLabel = Me._llbAddPR
				If linkLabel IsNot Nothing Then
					RemoveHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
				Me._llbAddPR = value
				linkLabel = Me._llbAddPR
				If linkLabel IsNot Nothing Then
					AddHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
			End Set
		End Property

		' Token: 0x170006B1 RID: 1713
		' (get) Token: 0x0600117C RID: 4476 RVA: 0x000A0853 File Offset: 0x0009EA53
		' (set) Token: 0x0600117D RID: 4477 RVA: 0x000A085D File Offset: 0x0009EA5D
		Friend Overridable Property tab_lbl7 As Label

		' Token: 0x170006B2 RID: 1714
		' (get) Token: 0x0600117E RID: 4478 RVA: 0x000A0866 File Offset: 0x0009EA66
		' (set) Token: 0x0600117F RID: 4479 RVA: 0x000A0870 File Offset: 0x0009EA70
		Friend Overridable Property Label12 As Label

		' Token: 0x170006B3 RID: 1715
		' (get) Token: 0x06001180 RID: 4480 RVA: 0x000A0879 File Offset: 0x0009EA79
		' (set) Token: 0x06001181 RID: 4481 RVA: 0x000A0883 File Offset: 0x0009EA83
		Friend Overridable Property cmbReportingTo As ComboBox

		' Token: 0x170006B4 RID: 1716
		' (get) Token: 0x06001182 RID: 4482 RVA: 0x000A088C File Offset: 0x0009EA8C
		' (set) Token: 0x06001183 RID: 4483 RVA: 0x000A0896 File Offset: 0x0009EA96
		Friend Overridable Property pnlPR As Panel

		' Token: 0x170006B5 RID: 1717
		' (get) Token: 0x06001184 RID: 4484 RVA: 0x000A089F File Offset: 0x0009EA9F
		' (set) Token: 0x06001185 RID: 4485 RVA: 0x000A08AC File Offset: 0x0009EAAC
		Friend Overridable Property dgvPR As DataGridView
			<CompilerGenerated()>
			Get
				Return Me._dgvPR
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim dataGridViewCellEventHandler As DataGridViewCellEventHandler = AddressOf Me.dgvPR_CellClick
				Dim dataGridView As DataGridView = Me._dgvPR
				If dataGridView IsNot Nothing Then
					RemoveHandler dataGridView.CellClick, dataGridViewCellEventHandler
				End If
				Me._dgvPR = value
				dataGridView = Me._dgvPR
				If dataGridView IsNot Nothing Then
					AddHandler dataGridView.CellClick, dataGridViewCellEventHandler
				End If
			End Set
		End Property

		' Token: 0x170006B6 RID: 1718
		' (get) Token: 0x06001186 RID: 4486 RVA: 0x000A08EF File Offset: 0x0009EAEF
		' (set) Token: 0x06001187 RID: 4487 RVA: 0x000A08F9 File Offset: 0x0009EAF9
		Friend Overridable Property Label13 As Label

		' Token: 0x170006B7 RID: 1719
		' (get) Token: 0x06001188 RID: 4488 RVA: 0x000A0902 File Offset: 0x0009EB02
		' (set) Token: 0x06001189 RID: 4489 RVA: 0x000A090C File Offset: 0x0009EB0C
		Friend Overridable Property txtComments As TextBox

		' Token: 0x170006B8 RID: 1720
		' (get) Token: 0x0600118A RID: 4490 RVA: 0x000A0915 File Offset: 0x0009EB15
		' (set) Token: 0x0600118B RID: 4491 RVA: 0x000A091F File Offset: 0x0009EB1F
		Friend Overridable Property SrNo As DataGridViewTextBoxColumn

		' Token: 0x170006B9 RID: 1721
		' (get) Token: 0x0600118C RID: 4492 RVA: 0x000A0928 File Offset: 0x0009EB28
		' (set) Token: 0x0600118D RID: 4493 RVA: 0x000A0932 File Offset: 0x0009EB32
		Friend Overridable Property ProductID As DataGridViewTextBoxColumn

		' Token: 0x170006BA RID: 1722
		' (get) Token: 0x0600118E RID: 4494 RVA: 0x000A093B File Offset: 0x0009EB3B
		' (set) Token: 0x0600118F RID: 4495 RVA: 0x000A0945 File Offset: 0x0009EB45
		Friend Overridable Property ProductType As DataGridViewTextBoxColumn

		' Token: 0x170006BB RID: 1723
		' (get) Token: 0x06001190 RID: 4496 RVA: 0x000A094E File Offset: 0x0009EB4E
		' (set) Token: 0x06001191 RID: 4497 RVA: 0x000A0958 File Offset: 0x0009EB58
		Friend Overridable Property ProductName As DataGridViewTextBoxColumn

		' Token: 0x170006BC RID: 1724
		' (get) Token: 0x06001192 RID: 4498 RVA: 0x000A0961 File Offset: 0x0009EB61
		' (set) Token: 0x06001193 RID: 4499 RVA: 0x000A096B File Offset: 0x0009EB6B
		Friend Overridable Property CatalogNo As DataGridViewTextBoxColumn

		' Token: 0x170006BD RID: 1725
		' (get) Token: 0x06001194 RID: 4500 RVA: 0x000A0974 File Offset: 0x0009EB74
		' (set) Token: 0x06001195 RID: 4501 RVA: 0x000A097E File Offset: 0x0009EB7E
		Friend Overridable Property Description As DataGridViewTextBoxColumn

		' Token: 0x170006BE RID: 1726
		' (get) Token: 0x06001196 RID: 4502 RVA: 0x000A0987 File Offset: 0x0009EB87
		' (set) Token: 0x06001197 RID: 4503 RVA: 0x000A0991 File Offset: 0x0009EB91
		Friend Overridable Property HSNSACCode As DataGridViewTextBoxColumn

		' Token: 0x170006BF RID: 1727
		' (get) Token: 0x06001198 RID: 4504 RVA: 0x000A099A File Offset: 0x0009EB9A
		' (set) Token: 0x06001199 RID: 4505 RVA: 0x000A09A4 File Offset: 0x0009EBA4
		Friend Overridable Property TertiaryUOM As DataGridViewTextBoxColumn

		' Token: 0x170006C0 RID: 1728
		' (get) Token: 0x0600119A RID: 4506 RVA: 0x000A09AD File Offset: 0x0009EBAD
		' (set) Token: 0x0600119B RID: 4507 RVA: 0x000A09B7 File Offset: 0x0009EBB7
		Friend Overridable Property TertiaryPackSize As DataGridViewTextBoxColumn

		' Token: 0x170006C1 RID: 1729
		' (get) Token: 0x0600119C RID: 4508 RVA: 0x000A09C0 File Offset: 0x0009EBC0
		' (set) Token: 0x0600119D RID: 4509 RVA: 0x000A09CA File Offset: 0x0009EBCA
		Friend Overridable Property PrimaryUOM As DataGridViewTextBoxColumn

		' Token: 0x170006C2 RID: 1730
		' (get) Token: 0x0600119E RID: 4510 RVA: 0x000A09D3 File Offset: 0x0009EBD3
		' (set) Token: 0x0600119F RID: 4511 RVA: 0x000A09DD File Offset: 0x0009EBDD
		Friend Overridable Property PrimaryPackSize As DataGridViewTextBoxColumn

		' Token: 0x170006C3 RID: 1731
		' (get) Token: 0x060011A0 RID: 4512 RVA: 0x000A09E6 File Offset: 0x0009EBE6
		' (set) Token: 0x060011A1 RID: 4513 RVA: 0x000A09F0 File Offset: 0x0009EBF0
		Friend Overridable Property Quantity As DataGridViewTextBoxColumn

		' Token: 0x170006C4 RID: 1732
		' (get) Token: 0x060011A2 RID: 4514 RVA: 0x000A09F9 File Offset: 0x0009EBF9
		' (set) Token: 0x060011A3 RID: 4515 RVA: 0x000A0A03 File Offset: 0x0009EC03
		Friend Overridable Property Measurement As DataGridViewTextBoxColumn

		' Token: 0x170006C5 RID: 1733
		' (get) Token: 0x060011A4 RID: 4516 RVA: 0x000A0A0C File Offset: 0x0009EC0C
		' (set) Token: 0x060011A5 RID: 4517 RVA: 0x000A0A16 File Offset: 0x0009EC16
		Friend Overridable Property UnitPrice As DataGridViewTextBoxColumn

		' Token: 0x170006C6 RID: 1734
		' (get) Token: 0x060011A6 RID: 4518 RVA: 0x000A0A1F File Offset: 0x0009EC1F
		' (set) Token: 0x060011A7 RID: 4519 RVA: 0x000A0A29 File Offset: 0x0009EC29
		Friend Overridable Property BasicValue As DataGridViewTextBoxColumn

		' Token: 0x170006C7 RID: 1735
		' (get) Token: 0x060011A8 RID: 4520 RVA: 0x000A0A32 File Offset: 0x0009EC32
		' (set) Token: 0x060011A9 RID: 4521 RVA: 0x000A0A3C File Offset: 0x0009EC3C
		Friend Overridable Property DiscountPer As DataGridViewTextBoxColumn

		' Token: 0x170006C8 RID: 1736
		' (get) Token: 0x060011AA RID: 4522 RVA: 0x000A0A45 File Offset: 0x0009EC45
		' (set) Token: 0x060011AB RID: 4523 RVA: 0x000A0A4F File Offset: 0x0009EC4F
		Friend Overridable Property DiscountAmt As DataGridViewTextBoxColumn

		' Token: 0x170006C9 RID: 1737
		' (get) Token: 0x060011AC RID: 4524 RVA: 0x000A0A58 File Offset: 0x0009EC58
		' (set) Token: 0x060011AD RID: 4525 RVA: 0x000A0A62 File Offset: 0x0009EC62
		Friend Overridable Property NetAmt As DataGridViewTextBoxColumn

		' Token: 0x170006CA RID: 1738
		' (get) Token: 0x060011AE RID: 4526 RVA: 0x000A0A6B File Offset: 0x0009EC6B
		' (set) Token: 0x060011AF RID: 4527 RVA: 0x000A0A75 File Offset: 0x0009EC75
		Friend Overridable Property TaxPer As DataGridViewTextBoxColumn

		' Token: 0x170006CB RID: 1739
		' (get) Token: 0x060011B0 RID: 4528 RVA: 0x000A0A7E File Offset: 0x0009EC7E
		' (set) Token: 0x060011B1 RID: 4529 RVA: 0x000A0A88 File Offset: 0x0009EC88
		Friend Overridable Property TaxAmt As DataGridViewTextBoxColumn

		' Token: 0x170006CC RID: 1740
		' (get) Token: 0x060011B2 RID: 4530 RVA: 0x000A0A91 File Offset: 0x0009EC91
		' (set) Token: 0x060011B3 RID: 4531 RVA: 0x000A0A9B File Offset: 0x0009EC9B
		Friend Overridable Property Transportation As DataGridViewTextBoxColumn

		' Token: 0x170006CD RID: 1741
		' (get) Token: 0x060011B4 RID: 4532 RVA: 0x000A0AA4 File Offset: 0x0009ECA4
		' (set) Token: 0x060011B5 RID: 4533 RVA: 0x000A0AAE File Offset: 0x0009ECAE
		Friend Overridable Property Freight As DataGridViewTextBoxColumn

		' Token: 0x170006CE RID: 1742
		' (get) Token: 0x060011B6 RID: 4534 RVA: 0x000A0AB7 File Offset: 0x0009ECB7
		' (set) Token: 0x060011B7 RID: 4535 RVA: 0x000A0AC1 File Offset: 0x0009ECC1
		Friend Overridable Property LoadingUnloading As DataGridViewTextBoxColumn

		' Token: 0x170006CF RID: 1743
		' (get) Token: 0x060011B8 RID: 4536 RVA: 0x000A0ACA File Offset: 0x0009ECCA
		' (set) Token: 0x060011B9 RID: 4537 RVA: 0x000A0AD4 File Offset: 0x0009ECD4
		Friend Overridable Property Packing As DataGridViewTextBoxColumn

		' Token: 0x170006D0 RID: 1744
		' (get) Token: 0x060011BA RID: 4538 RVA: 0x000A0ADD File Offset: 0x0009ECDD
		' (set) Token: 0x060011BB RID: 4539 RVA: 0x000A0AE7 File Offset: 0x0009ECE7
		Friend Overridable Property OtherCharges As DataGridViewTextBoxColumn

		' Token: 0x170006D1 RID: 1745
		' (get) Token: 0x060011BC RID: 4540 RVA: 0x000A0AF0 File Offset: 0x0009ECF0
		' (set) Token: 0x060011BD RID: 4541 RVA: 0x000A0AFA File Offset: 0x0009ECFA
		Friend Overridable Property FinalAmt As DataGridViewTextBoxColumn

		' Token: 0x170006D2 RID: 1746
		' (get) Token: 0x060011BE RID: 4542 RVA: 0x000A0B03 File Offset: 0x0009ED03
		' (set) Token: 0x060011BF RID: 4543 RVA: 0x000A0B0D File Offset: 0x0009ED0D
		Friend Overridable Property btnDelete_Item As DataGridViewImageColumn

		' Token: 0x170006D3 RID: 1747
		' (get) Token: 0x060011C0 RID: 4544 RVA: 0x000A0B16 File Offset: 0x0009ED16
		' (set) Token: 0x060011C1 RID: 4545 RVA: 0x000A0B20 File Offset: 0x0009ED20
		Friend Overridable Property PRNo As DataGridViewTextBoxColumn

		' Token: 0x170006D4 RID: 1748
		' (get) Token: 0x060011C2 RID: 4546 RVA: 0x000A0B29 File Offset: 0x0009ED29
		' (set) Token: 0x060011C3 RID: 4547 RVA: 0x000A0B33 File Offset: 0x0009ED33
		Friend Overridable Property PRDt As DataGridViewTextBoxColumn

		' Token: 0x170006D5 RID: 1749
		' (get) Token: 0x060011C4 RID: 4548 RVA: 0x000A0B3C File Offset: 0x0009ED3C
		' (set) Token: 0x060011C5 RID: 4549 RVA: 0x000A0B46 File Offset: 0x0009ED46
		Friend Overridable Property RequestedBy As DataGridViewTextBoxColumn

		' Token: 0x170006D6 RID: 1750
		' (get) Token: 0x060011C6 RID: 4550 RVA: 0x000A0B4F File Offset: 0x0009ED4F
		' (set) Token: 0x060011C7 RID: 4551 RVA: 0x000A0B59 File Offset: 0x0009ED59
		Friend Overridable Property VendorName As DataGridViewTextBoxColumn

		' Token: 0x170006D7 RID: 1751
		' (get) Token: 0x060011C8 RID: 4552 RVA: 0x000A0B62 File Offset: 0x0009ED62
		' (set) Token: 0x060011C9 RID: 4553 RVA: 0x000A0B6C File Offset: 0x0009ED6C
		Friend Overridable Property prProductType As DataGridViewTextBoxColumn

		' Token: 0x170006D8 RID: 1752
		' (get) Token: 0x060011CA RID: 4554 RVA: 0x000A0B75 File Offset: 0x0009ED75
		' (set) Token: 0x060011CB RID: 4555 RVA: 0x000A0B7F File Offset: 0x0009ED7F
		Friend Overridable Property prProductCode As DataGridViewTextBoxColumn

		' Token: 0x170006D9 RID: 1753
		' (get) Token: 0x060011CC RID: 4556 RVA: 0x000A0B88 File Offset: 0x0009ED88
		' (set) Token: 0x060011CD RID: 4557 RVA: 0x000A0B92 File Offset: 0x0009ED92
		Friend Overridable Property prCatalogNo As DataGridViewTextBoxColumn

		' Token: 0x170006DA RID: 1754
		' (get) Token: 0x060011CE RID: 4558 RVA: 0x000A0B9B File Offset: 0x0009ED9B
		' (set) Token: 0x060011CF RID: 4559 RVA: 0x000A0BA5 File Offset: 0x0009EDA5
		Friend Overridable Property prProductName As DataGridViewTextBoxColumn

		' Token: 0x170006DB RID: 1755
		' (get) Token: 0x060011D0 RID: 4560 RVA: 0x000A0BAE File Offset: 0x0009EDAE
		' (set) Token: 0x060011D1 RID: 4561 RVA: 0x000A0BB8 File Offset: 0x0009EDB8
		Friend Overridable Property prDescription As DataGridViewTextBoxColumn

		' Token: 0x170006DC RID: 1756
		' (get) Token: 0x060011D2 RID: 4562 RVA: 0x000A0BC1 File Offset: 0x0009EDC1
		' (set) Token: 0x060011D3 RID: 4563 RVA: 0x000A0BCB File Offset: 0x0009EDCB
		Friend Overridable Property prHSNSACCode As DataGridViewTextBoxColumn

		' Token: 0x170006DD RID: 1757
		' (get) Token: 0x060011D4 RID: 4564 RVA: 0x000A0BD4 File Offset: 0x0009EDD4
		' (set) Token: 0x060011D5 RID: 4565 RVA: 0x000A0BDE File Offset: 0x0009EDDE
		Friend Overridable Property prQty As DataGridViewTextBoxColumn

		' Token: 0x170006DE RID: 1758
		' (get) Token: 0x060011D6 RID: 4566 RVA: 0x000A0BE7 File Offset: 0x0009EDE7
		' (set) Token: 0x060011D7 RID: 4567 RVA: 0x000A0BF1 File Offset: 0x0009EDF1
		Friend Overridable Property prTertiaryUOM As DataGridViewTextBoxColumn

		' Token: 0x170006DF RID: 1759
		' (get) Token: 0x060011D8 RID: 4568 RVA: 0x000A0BFA File Offset: 0x0009EDFA
		' (set) Token: 0x060011D9 RID: 4569 RVA: 0x000A0C04 File Offset: 0x0009EE04
		Friend Overridable Property prTertiaryPackSize As DataGridViewTextBoxColumn

		' Token: 0x170006E0 RID: 1760
		' (get) Token: 0x060011DA RID: 4570 RVA: 0x000A0C0D File Offset: 0x0009EE0D
		' (set) Token: 0x060011DB RID: 4571 RVA: 0x000A0C17 File Offset: 0x0009EE17
		Friend Overridable Property prPrimaryUOM As DataGridViewTextBoxColumn

		' Token: 0x170006E1 RID: 1761
		' (get) Token: 0x060011DC RID: 4572 RVA: 0x000A0C20 File Offset: 0x0009EE20
		' (set) Token: 0x060011DD RID: 4573 RVA: 0x000A0C2A File Offset: 0x0009EE2A
		Friend Overridable Property prPrimaryPackSize As DataGridViewTextBoxColumn

		' Token: 0x170006E2 RID: 1762
		' (get) Token: 0x060011DE RID: 4574 RVA: 0x000A0C33 File Offset: 0x0009EE33
		' (set) Token: 0x060011DF RID: 4575 RVA: 0x000A0C3D File Offset: 0x0009EE3D
		Friend Overridable Property prUnitPrice As DataGridViewTextBoxColumn

		' Token: 0x170006E3 RID: 1763
		' (get) Token: 0x060011E0 RID: 4576 RVA: 0x000A0C46 File Offset: 0x0009EE46
		' (set) Token: 0x060011E1 RID: 4577 RVA: 0x000A0C50 File Offset: 0x0009EE50
		Friend Overridable Property prBasicValue As DataGridViewTextBoxColumn

		' Token: 0x170006E4 RID: 1764
		' (get) Token: 0x060011E2 RID: 4578 RVA: 0x000A0C59 File Offset: 0x0009EE59
		' (set) Token: 0x060011E3 RID: 4579 RVA: 0x000A0C63 File Offset: 0x0009EE63
		Friend Overridable Property prNetAmt As DataGridViewTextBoxColumn

		' Token: 0x170006E5 RID: 1765
		' (get) Token: 0x060011E4 RID: 4580 RVA: 0x000A0C6C File Offset: 0x0009EE6C
		' (set) Token: 0x060011E5 RID: 4581 RVA: 0x000A0C76 File Offset: 0x0009EE76
		Friend Overridable Property prTaxPer As DataGridViewTextBoxColumn

		' Token: 0x170006E6 RID: 1766
		' (get) Token: 0x060011E6 RID: 4582 RVA: 0x000A0C7F File Offset: 0x0009EE7F
		' (set) Token: 0x060011E7 RID: 4583 RVA: 0x000A0C89 File Offset: 0x0009EE89
		Friend Overridable Property prTaxAmt As DataGridViewTextBoxColumn

		' Token: 0x170006E7 RID: 1767
		' (get) Token: 0x060011E8 RID: 4584 RVA: 0x000A0C92 File Offset: 0x0009EE92
		' (set) Token: 0x060011E9 RID: 4585 RVA: 0x000A0C9C File Offset: 0x0009EE9C
		Friend Overridable Property prOtherCharges As DataGridViewTextBoxColumn

		' Token: 0x170006E8 RID: 1768
		' (get) Token: 0x060011EA RID: 4586 RVA: 0x000A0CA5 File Offset: 0x0009EEA5
		' (set) Token: 0x060011EB RID: 4587 RVA: 0x000A0CAF File Offset: 0x0009EEAF
		Friend Overridable Property prFinalAmt As DataGridViewTextBoxColumn

		' Token: 0x170006E9 RID: 1769
		' (get) Token: 0x060011EC RID: 4588 RVA: 0x000A0CB8 File Offset: 0x0009EEB8
		' (set) Token: 0x060011ED RID: 4589 RVA: 0x000A0CC2 File Offset: 0x0009EEC2
		Friend Overridable Property PRID As DataGridViewTextBoxColumn

		' Token: 0x170006EA RID: 1770
		' (get) Token: 0x060011EE RID: 4590 RVA: 0x000A0CCB File Offset: 0x0009EECB
		' (set) Token: 0x060011EF RID: 4591 RVA: 0x000A0CD5 File Offset: 0x0009EED5
		Friend Overridable Property prProductID As DataGridViewTextBoxColumn

		' Token: 0x170006EB RID: 1771
		' (get) Token: 0x060011F0 RID: 4592 RVA: 0x000A0CDE File Offset: 0x0009EEDE
		' (set) Token: 0x060011F1 RID: 4593 RVA: 0x000A0CE8 File Offset: 0x0009EEE8
		Friend Overridable Property RequestedByEmailID As DataGridViewTextBoxColumn

		' Token: 0x170006EC RID: 1772
		' (get) Token: 0x060011F2 RID: 4594 RVA: 0x000A0CF1 File Offset: 0x0009EEF1
		' (set) Token: 0x060011F3 RID: 4595 RVA: 0x000A0CFB File Offset: 0x0009EEFB
		Friend Overridable Property Label17 As Label

		' Token: 0x170006ED RID: 1773
		' (get) Token: 0x060011F4 RID: 4596 RVA: 0x000A0D04 File Offset: 0x0009EF04
		' (set) Token: 0x060011F5 RID: 4597 RVA: 0x000A0D0E File Offset: 0x0009EF0E
		Friend Overridable Property Label23 As Label

		' Token: 0x170006EE RID: 1774
		' (get) Token: 0x060011F6 RID: 4598 RVA: 0x000A0D17 File Offset: 0x0009EF17
		' (set) Token: 0x060011F7 RID: 4599 RVA: 0x000A0D21 File Offset: 0x0009EF21
		Friend Overridable Property Label31 As Label

		' Token: 0x170006EF RID: 1775
		' (get) Token: 0x060011F8 RID: 4600 RVA: 0x000A0D2A File Offset: 0x0009EF2A
		' (set) Token: 0x060011F9 RID: 4601 RVA: 0x000A0D34 File Offset: 0x0009EF34
		Friend Overridable Property Label30 As Label

		' Token: 0x060011FA RID: 4602 RVA: 0x000A0D40 File Offset: 0x0009EF40
		Public Sub New(sForm As String, dr As DataRow)
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			AddHandler MyBase.Shown, AddressOf Me.Me_Shown
			Me.InitializeComponent()
			Me.sFormType = sForm
			Me.drData = dr
		End Sub

		' Token: 0x060011FB RID: 4603 RVA: 0x000A0DA4 File Offset: 0x0009EFA4
		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x060011FC RID: 4604 RVA: 0x000A0DD9 File Offset: 0x0009EFD9
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Designing.SetTheme(Me)
			Me.ClearForm()
			Me.FillCombo()
			Me.FillData()
			Me.SetForm()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x060011FD RID: 4605 RVA: 0x000A0E16 File Offset: 0x0009F016
		Private Sub Me_Shown(sender As Object, e As EventArgs)
			Me.SetTabs()
		End Sub

		' Token: 0x060011FE RID: 4606 RVA: 0x000A0E20 File Offset: 0x0009F020
		Private Sub SetTabs()
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = CInt(Math.Round(CDbl((Me.theme_tc.Width - 5)) / 7.0))
			Me.theme_tc.ItemSize = New Size(num, 30)
			Me.tab_lbl1.Width = num
			Me.tab_lbl2.Width = num + 3
			Me.tab_lbl7.Width = num + 3
			Me.tab_lbl3.Width = num + 3
			Me.tab_lbl4.Width = num + 3
			Me.tab_lbl5.Width = num + 3
			Me.tab_lbl6.Width = num + 3
			Me.tab_lbl1.Location = New Point(0, 0)
			Me.tab_lbl2.Location = New Point(num - 4, 0)
			Me.tab_lbl7.Location = New Point(num * 2 - 4, 0)
			Me.tab_lbl3.Location = New Point(num * 3 - 4, 0)
			Me.tab_lbl4.Location = New Point(num * 4 - 4, 0)
			Me.tab_lbl5.Location = New Point(num * 5 - 4, 0)
			Me.tab_lbl6.Location = New Point(num * 6 - 4, 0)
			Me.flpButton.Left = CInt(Math.Round(CDbl(MyBase.Width) / 2.0 - CDbl(Me.flpButton.Width) / 2.0))
		End Sub

		' Token: 0x060011FF RID: 4607 RVA: 0x000A0FA0 File Offset: 0x0009F1A0
		Private Sub FillCombo()
			Dim text As String = "SELECT VendorID, VendorName FROM Vendor ORDER BY VendorName"
			Dim data As DataTable = MainModule.GetData(text)
			Me.cmbVendor.ValueMember = "VendorID"
			Me.cmbVendor.DisplayMember = "VendorName"
			Me.cmbVendor.DataSource = data
			Me.cmbVendor.SelectedIndex = -1
			text = "SELECT DISTINCT Department FROM [User] ORDER BY Department"
			Dim data2 As DataTable = MainModule.GetData(text)
			Me.cmbDept.ValueMember = "Department"
			Me.cmbDept.DisplayMember = "Department"
			Me.cmbDept.DataSource = data2
			Me.cmbDept.SelectedIndex = -1
			text = "SELECT DISTINCT ModeOfPayment FROM PO ORDER BY ModeOfPayment"
			Dim data3 As DataTable = MainModule.GetData(text)
			Me.cmbModeOfPayment.ValueMember = "ModeOfPayment"
			Me.cmbModeOfPayment.DisplayMember = "ModeOfPayment"
			Me.cmbModeOfPayment.DataSource = data3
			Me.cmbModeOfPayment.SelectedIndex = -1
			text = " SELECT DISTINCT U.UserID, U.UserName, U.LoginID, U.EmailID, "
			text += " U.Designation, U.Department, U.ManagerID, U.ReportingToID "
			text += " FROM [User] U INNER JOIN [User] R ON U.UserID = R.ReportingToID "
			text += " WHERE (U.IsActive = 1)"
			Me.dtReportingTo = MainModule.GetData(text)
			Me.cmbReportingTo.ValueMember = "UserID"
			Me.cmbReportingTo.DisplayMember = "UserName"
			Me.cmbReportingTo.DataSource = Me.dtReportingTo
			Me.cmbReportingTo.SelectedValue = GlobalVariables.gsReportingToID
		End Sub

		' Token: 0x06001200 RID: 4608 RVA: 0x000A1104 File Offset: 0x0009F304
		Private Sub FillData()
			Try
				Dim flag As Boolean = Not Information.IsNothing(Me.drData)
				If flag Then
					Me.txtID.Text = Conversions.ToString(Me.drData("ID"))
					Me.cmbPOType.Text = Conversions.ToString(Me.drData("POType"))
					Me.txtNo.Text = Conversions.ToString(Me.drData("PONo"))
					Me.dtpDt.Value = Conversions.ToDate(Me.drData("PODt"))
					Dim flag2 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.drData("ValidUpto")))
					If flag2 Then
						Me.dtpValidity.Value = Conversions.ToDate(Me.drData("ValidUpto"))
						Me.dtpValidity.Checked = True
					Else
						Me.dtpValidity.Value = DateAndTime.Now
						Me.dtpValidity.Checked = False
					End If
					Me.txtDelivery.Text = Me.drData("DeliveryInDays").ToString()
					Dim flag3 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.drData("DeliveryDt")))
					If flag3 Then
						Me.dtpDelDt.Value = Conversions.ToDate(Me.drData("DeliveryDt"))
						Me.dtpDelDt.Checked = True
					Else
						Me.dtpDelDt.Value = DateAndTime.Now
						Me.dtpDelDt.Checked = False
					End If
					Me.cmbDept.Text = Conversions.ToString(Me.drData("Department"))
					Dim flag4 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.drData("ActionByID")))
					If flag4 Then
						Me.cmbReportingTo.SelectedValue = RuntimeHelpers.GetObjectValue(Me.drData("ActionByID"))
					Else
						Dim flag5 As Boolean = Me.dtReportingTo.Rows.Count = 0
						If flag5 Then
							Me.cmbReportingTo.SelectedIndex = -1
						End If
					End If
					Me.txtInvoiceTo.Text = Conversions.ToString(Me.drData("InvoiceAddress"))
					Me.txtBillEmailID.Text = Conversions.ToString(Me.drData("BillingEmailID"))
					Me.txtShipTo.Text = Conversions.ToString(Me.drData("ShipAddress"))
					Me.txtShipEmailID.Text = Conversions.ToString(Me.drData("ShippingEmailID"))
					Me.txtGSTNo.Text = Conversions.ToString(Me.drData("GSTNo"))
					Me.txtPANNo.Text = Conversions.ToString(Me.drData("PANNo"))
					Me.cmbVendor.SelectedValue = RuntimeHelpers.GetObjectValue(Me.drData("VendorID"))
					Me.txtVendorBillTo.Text = Conversions.ToString(Me.drData("VendorBillingAddress"))
					Me.txtVendorContact.Text = Conversions.ToString(Me.drData("VendorContactPerson"))
					Me.txtVendorContactNo.Text = Conversions.ToString(Me.drData("VendorContactNo"))
					Me.txtVendorEmail.Text = Conversions.ToString(Me.drData("VendorEmailID"))
					Me.txtVendorGST.Text = Conversions.ToString(Me.drData("VendorGSTNo"))
					Me.txtVendorPAN.Text = Conversions.ToString(Me.drData("VendorPANNo"))
					Me.cmbModeOfPayment.Text = Conversions.ToString(Me.drData("ModeOfPayment"))
					Me.txtDispatchThrough.Text = Conversions.ToString(Me.drData("DispatchedThrough"))
					Me.txtPaymentTerms.Text = Conversions.ToString(Me.drData("PaymentTerms"))
					Me.txtIncoTerms.Text = Conversions.ToString(Me.drData("IncoTerms"))
					Me.txtDeliveryTerms.Text = Conversions.ToString(Me.drData("DeliveryTerms"))
					Me.cmbCurrency.Text = Conversions.ToString(Me.drData("Currency"))
					Me.txtComments.Text = Me.drData("Comments").ToString()
					Me.txtRemarks.Text = Me.drData("Remarks").ToString()
					Me.txtRemarksApproval.Text = Me.drData("ActionRemarks").ToString()
					Dim flag6 As Boolean = Operators.CompareString(Me.txtRemarksApproval.Text, "", False) = 0
					If flag6 Then
						Me.lblRemarksApproval.Visible = False
					Else
						Me.lblRemarksApproval.Visible = True
					End If
					Dim text As String = "Select Status FROM PO WHERE POID = '" + Me.txtID.Text + "'"
					Dim data As DataTable = MainModule.GetData(text)
					Me.skip_lblStatus.Text = Conversions.ToString(data.Rows(0)("Status"))
					Dim text2 As String = Me.skip_lblStatus.Text
					If Operators.CompareString(text2, "Rejected", False) <> 0 AndAlso Operators.CompareString(text2, "Cancelled", False) <> 0 Then
						Me.skip_lblStatus.ForeColor = Color.White
					Else
						Me.skip_lblStatus.ForeColor = Color.Red
					End If
					Me.FillPOItems()
					Me.FillPRItems()
					Me.dtFile = FileAttachments.FillFileAttachments("PO", Me.txtID.Text)
					FileAttachments.SetFileDatagridview(Me.dtFile, Me.dgvFile)
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06001201 RID: 4609 RVA: 0x000A1784 File Offset: 0x0009F984
		Private Sub FillPOItems()
			Dim text As String = " SELECT ROW_NUMBER() OVER(ORDER BY POItemsID) AS SrNo, PIs.ProductID, P.ProductType, " & vbCrLf
			text += " P.ProductName, P.CatalogNo, PIs.Description, P.HSNSACCode, PIs.UnitPrice, PIs.Quantity, " & vbCrLf
			text += " P.TertiaryUOM, P.TertiaryPackSize, P.PrimaryUOM, P.PrimaryPackSize, P.Measurement, " & vbCrLf
			text += " PIs.BasicValue, PIs.DiscountPer, PIs.DiscountAmt, PIs.NetAmt, PIs.TaxPer, PIs.TaxAmt, " & vbCrLf
			text += " PIs.Transportation, PIs.Freight, PIs.LoadingUnloading, PIs.Packing, PIs.OtherCharges, PIs.FinalAmt" & vbCrLf
			text += " FROM POItems AS PIs " & vbCrLf
			text += " INNER JOIN Product AS P ON PIs.ProductID = P.ProductID" & vbCrLf
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				text = text + " WHERE POID = '" + Me.txtID.Text + "'"
			Else
				text += " WHERE POID = '0'"
			End If
			Me.dtItems = MainModule.GetData(text)
			Me.dgvDtls.DataSource = Me.dtItems
			Me.CalculateTotalAmt()
		End Sub

		' Token: 0x06001202 RID: 4610 RVA: 0x000A1850 File Offset: 0x0009FA50
		Private Sub FillPRItems()
			Dim text As String = " SELECT P.PRID, P.PRNo, P.PRDt, Req.UserName AS RequestedBy, Req.EmailID RequestedByEmailID, V.VendorName," & vbCrLf
			text += " PI.ProductID, Pr.ProductType, Pr.ProductCode, Pr.ProductName, Pr.CatalogNo, PI.Description, PI.Quantity " & vbCrLf
			text += " , Pr.HSNSACCode, Pr.TertiaryUOM, PI.TertiaryPackSize, Pr.PrimaryUOM, PI.PrimaryPackSize," & vbCrLf
			text += " PI.UnitPrice, PI.BasicValue, PI.NetAmt, PI.TaxPer, PI.TaxAmt, PI.OtherCharges, PI.FinalAmt" & vbCrLf
			text += " FROM PR AS P" & vbCrLf
			text += " INNER JOIN PRItems PI ON P.PRID = PI.PRID" & vbCrLf
			text += " INNER JOIN Product Pr ON Pr.ProductID = PI.ProductID" & vbCrLf
			text += " INNER JOIN POPR ON P.PRID = POPR.PRID AND POPR.ProductID = PI.ProductID AND POPR.Description = PI.Description" & vbCrLf
			text += " LEFT OUTER JOIN [User] AS Req ON P.RequestedBy = Req.UserID" & vbCrLf
			text += " LEFT OUTER JOIN Vendor AS V ON P.VendorID = V.VendorID" & vbCrLf
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				text = text + " WHERE POPR.POID = '" + Me.txtID.Text + "'"
			Else
				text += " WHERE POPR.POID = '0'"
			End If
			Me.dtPR = MainModule.GetData(text)
			Me.dgvPR.DataSource = Me.dtPR
		End Sub

		' Token: 0x06001203 RID: 4611 RVA: 0x000A1938 File Offset: 0x0009FB38
		Private Sub SetPRItems(sPRID As String)
		End Sub

		' Token: 0x06001204 RID: 4612 RVA: 0x000A193C File Offset: 0x0009FB3C
		Private Sub CalculateTotalAmt()
			Dim flag As Boolean = Me.dtItems.Rows.Count > 0
			If flag Then
				Me.txtTotal.Text = Strings.Format(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtItems.Compute("SUM(FinalAmt)", ""))), "#0.00")
			Else
				Me.txtTotal.Text = ""
			End If
		End Sub

		' Token: 0x06001205 RID: 4613 RVA: 0x000A19B4 File Offset: 0x0009FBB4
		Private Sub SetForm()
			Dim text As String = Me.sFormType
			If Operators.CompareString(text, "PO Add", False) <> 0 Then
				If Operators.CompareString(text, "PO Modify", False) <> 0 Then
					If Operators.CompareString(text, "PO Approval", False) <> 0 Then
						If Operators.CompareString(text, "PO Cost Approval", False) <> 0 Then
							If Operators.CompareString(text, "PO Printing", False) <> 0 Then
								If Operators.CompareString(text, "PO Amendment", False) = 0 Then
									Me.Text = "PO Amendment"
									MyBase.TabText = "PO Amendment"
									Me.llbAdd.Enabled = False
									Me.llbAddPR.Enabled = False
									Me.llbFile.Enabled = False
									Me.llbInvoiceTo.Enabled = False
									Me.llbShipTo.Enabled = False
									Me.llbVendorBillTo.Enabled = False
									Me.btnSave.Visible = False
									Me.btnClear.Visible = False
									Me.btnApprove.Visible = False
									Me.btnOnHold.Visible = False
									Me.btnReject.Visible = False
									Me.btnPrint.Visible = False
									Me.btnCancel.Visible = False
									Me.dgvPR.Columns("btnDelete_Item").Visible = False
									Me.flpButton.Width = (Me.btnApprove.Width + 6) * 9 - Me.btnApprove.Width * 7
								End If
							Else
								Me.Text = "PO Printing"
								MyBase.TabText = "PO Printing"
								Me.txtRemarks.[ReadOnly] = True
								Me.llbAdd.Enabled = False
								Me.llbAddPR.Enabled = False
								Me.llbFile.Enabled = False
								Me.llbInvoiceTo.Enabled = False
								Me.llbShipTo.Enabled = False
								Me.llbVendorBillTo.Enabled = False
								Me.btnSave.Visible = False
								Me.btnClear.Visible = False
								Me.btnApprove.Visible = False
								Me.btnOnHold.Visible = False
								Me.btnReject.Visible = False
								Me.btnAmend.Visible = False
								Me.btnCancel.Visible = False
								Me.dgvPR.Columns("btnDelete_Item").Visible = False
								Me.flpButton.Width = (Me.btnApprove.Width + 6) * 9 - Me.btnApprove.Width * 7
							End If
						Else
							Me.Text = "PO Cost Approval"
							MyBase.TabText = "PO Cost Approval"
							Me.txtRemarks.[ReadOnly] = True
							Me.llbAdd.Enabled = False
							Me.llbAddPR.Enabled = False
							Me.llbFile.Enabled = False
							Me.llbInvoiceTo.Enabled = False
							Me.llbShipTo.Enabled = False
							Me.llbVendorBillTo.Enabled = False
							Me.btnSave.Visible = False
							Me.btnClear.Visible = False
							Me.btnPrint.Visible = False
							Me.btnAmend.Visible = False
							Me.dgvPR.Columns("btnDelete_Item").Visible = False
							Me.flpButton.Width = (Me.btnApprove.Width + 6) * 9 - Me.btnApprove.Width * 4
						End If
					Else
						Me.Text = "PO Approval"
						MyBase.TabText = "PO Approval"
						Me.txtRemarks.[ReadOnly] = True
						Me.llbAdd.Enabled = False
						Me.llbAddPR.Enabled = False
						Me.llbFile.Enabled = False
						Me.llbInvoiceTo.Enabled = False
						Me.llbShipTo.Enabled = False
						Me.llbVendorBillTo.Enabled = False
						Me.btnSave.Visible = False
						Me.btnClear.Visible = False
						Me.btnPrint.Visible = False
						Me.btnAmend.Visible = False
						Me.dgvPR.Columns("btnDelete_Item").Visible = False
						Me.flpButton.Width = (Me.btnApprove.Width + 6) * 9 - Me.btnApprove.Width * 4
					End If
				Else
					Me.Text = "PO Modification"
					MyBase.TabText = "PO Modification"
					Me.cmbPOType.Enabled = False
					Me.btnApprove.Visible = False
					Me.btnOnHold.Visible = False
					Me.btnReject.Visible = False
					Me.btnPrint.Visible = False
					Me.btnAmend.Visible = False
					Me.flpButton.Width = (Me.btnApprove.Width + 6) * 9 - Me.btnApprove.Width * 5
				End If
			Else
				Me.Text = "PO Generation"
				MyBase.TabText = "PO Generation"
				Dim flag As Boolean = Strings.InStr(GlobalVariables.gsUserGroup.ToLower(), "admin", CompareMethod.Binary) > 0
				If flag Then
					Me.dtpDt.Enabled = True
				Else
					Me.dtpDt.Enabled = False
				End If
				Me.btnApprove.Visible = False
				Me.btnOnHold.Visible = False
				Me.btnReject.Visible = False
				Me.btnPrint.Visible = False
				Me.btnAmend.Visible = False
				Me.btnCancel.Visible = False
				Me.flpButton.Width = (Me.btnApprove.Width + 6) * 9 - Me.btnApprove.Width * 6
			End If
			Dim text2 As String = Me.skip_lblStatus.Text
			Dim flag2 As Boolean = Operators.CompareString(text2, "In Approval", False) = 0
			If flag2 Then
				Dim text3 As String = Me.sFormType
				If Operators.CompareString(text3, "PO Modify", False) <> 0 Then
					If Operators.CompareString(text3, "PO Approval", False) <> 0 Then
						If Operators.CompareString(text3, "PO Cost Approval", False) = 0 Then
							Me.btnApprove.Enabled = False
							Me.btnOnHold.Enabled = False
							Me.btnReject.Enabled = False
						End If
					End If
				End If
			Else
				flag2 = Operators.CompareString(text2, "On-Hold", False) = 0 OrElse Operators.CompareString(text2, "Cost On-Hold", False) = 0
				If flag2 Then
					Dim text4 As String = Me.sFormType
					If Operators.CompareString(text4, "PO Modify", False) <> 0 Then
						If Operators.CompareString(text4, "PO Approval", False) = 0 OrElse Operators.CompareString(text4, "PO Cost Approval", False) = 0 Then
							Me.btnApprove.Enabled = False
							Me.btnOnHold.Enabled = False
							Me.btnReject.Enabled = False
						End If
					End If
				Else
					flag2 = Operators.CompareString(text2, "In Cost Approval", False) = 0
					If flag2 Then
						Dim text5 As String = Me.sFormType
						If Operators.CompareString(text5, "PO Modify", False) <> 0 Then
							If Operators.CompareString(text5, "PO Approval", False) <> 0 Then
								If Operators.CompareString(text5, "PO Cost Approval", False) <> 0 Then
								End If
							Else
								Me.btnApprove.Enabled = False
								Me.btnOnHold.Enabled = False
								Me.btnReject.Enabled = False
							End If
						Else
							Me.llbAdd.Enabled = False
							Me.llbFile.Enabled = False
							Me.btnSave.Enabled = False
							Me.btnClear.Enabled = False
							Me.btnCancel.Enabled = False
						End If
					Else
						flag2 = Operators.CompareString(text2, "Cost Approved", False) = 0 OrElse Operators.CompareString(text2, "Printed", False) = 0
						If flag2 Then
							Me.llbAdd.Enabled = False
							Me.llbAddPR.Enabled = False
							Me.llbFile.Enabled = False
							Me.llbInvoiceTo.Enabled = False
							Me.llbShipTo.Enabled = False
							Me.llbVendorBillTo.Enabled = False
							Me.btnSave.Enabled = False
							Me.btnClear.Enabled = False
							Me.btnApprove.Enabled = False
							Me.btnOnHold.Enabled = False
							Me.btnReject.Enabled = False
							Me.dgvPR.Columns("btnDelete_Item").Visible = False
						Else
							flag2 = Operators.CompareString(text2, "Rejected", False) = 0 OrElse Operators.CompareString(text2, "Cost Rejected", False) = 0 OrElse Operators.CompareString(text2, "Cancelled", False) = 0 OrElse Operators.CompareString(text2, "Amended", False) = 0 OrElse Operators.CompareString(text2, Conversions.ToString(Not Me.llbAdd.Enabled), False) = 0
							If flag2 Then
								Me.llbAddPR.Enabled = False
								Me.llbFile.Enabled = False
								Me.llbInvoiceTo.Enabled = False
								Me.llbShipTo.Enabled = False
								Me.llbVendorBillTo.Enabled = False
								Me.btnSave.Enabled = False
								Me.btnClear.Enabled = False
								Me.btnApprove.Enabled = False
								Me.btnOnHold.Enabled = False
								Me.btnReject.Enabled = False
								Me.btnPrint.Enabled = False
								Me.btnCancel.Enabled = False
								Me.btnAmend.Enabled = False
								Me.dgvPR.Columns("btnDelete_Item").Visible = False
							Else
								flag2 = Operators.CompareString(text2, "GRN Complete", False) = 0
								If flag2 Then
									Me.btnSave.Enabled = False
									Me.btnClear.Enabled = False
									Me.btnApprove.Enabled = False
									Me.btnOnHold.Enabled = False
									Me.btnReject.Enabled = False
									Me.btnPrint.Enabled = False
									Me.btnCancel.Enabled = False
									Me.btnAmend.Enabled = False
									Me.dgvPR.Columns("btnDelete_Item").Visible = False
								End If
							End If
						End If
					End If
				End If
			End If
			Me.sEmailTo = GlobalVariables.gsEmailID
			Dim flag3 As Boolean = Not Information.IsNothing(Me.drData)
			If flag3 Then
				Dim flag4 As Boolean = (Operators.CompareString(Me.drData("CreatedByEmailID").ToString(), "", False) <> 0) And (Operators.CompareString(Me.drData("CreatedByEmailID").ToString(), GlobalVariables.gsEmailID, False) <> 0)
				If flag4 Then
					Dim ptr As __ByRef(Of String) = Me.sEmailTo
					Me.sEmailTo = ptr + ":" + Me.drData("CreatedByEmailID").ToString()
				End If
			End If
		End Sub

		' Token: 0x06001206 RID: 4614 RVA: 0x000A24C0 File Offset: 0x000A06C0
		Private Sub txtID_TextChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) = 0
			If flag Then
				Me.btnCancel.Enabled = False
			Else
				Me.btnCancel.Enabled = True
			End If
		End Sub

		' Token: 0x06001207 RID: 4615 RVA: 0x000A250C File Offset: 0x000A070C
		Private Sub ClearForm()
			Me.txtID.Text = ""
			Me.cmbPOType.Text = ""
			Me.txtNo.Text = ""
			Me.dtpDt.Value = DateAndTime.Now
			Me.txtPRNo.Text = ""
			Me.dtpPRDt.Value = DateAndTime.Now
			Me.dtpPRDt.Checked = False
			Me.dtpValidity.Value = DateAndTime.Now
			Me.dtpValidity.Checked = False
			Me.txtDelivery.Text = ""
			Me.dtpDelDt.Value = DateAndTime.Now
			Me.dtpDelDt.Checked = False
			Me.cmbDept.Text = ""
			Me.txtInvoiceTo.Text = ""
			Me.txtBillEmailID.Text = ""
			Me.txtShipTo.Text = ""
			Me.txtShipEmailID.Text = ""
			Me.txtGSTNo.Text = ""
			Me.txtPANNo.Text = ""
			Me.cmbVendor.Enabled = True
			Me.cmbVendor.SelectedIndex = -1
			Me.txtVendorBillTo.Text = ""
			Me.txtVendorContact.Text = ""
			Me.txtVendorContactNo.Text = ""
			Me.txtVendorEmail.Text = ""
			Me.txtVendorGST.Text = ""
			Me.txtVendorPAN.Text = ""
			Me.cmbModeOfPayment.Text = ""
			Me.txtDispatchThrough.Text = ""
			Me.txtPaymentTerms.Text = ""
			Me.txtIncoTerms.Text = ""
			Me.txtDeliveryTerms.Text = ""
			Me.cmbCurrency.Text = ""
			Me.FillPOItems()
			Me.txtRemarks.Text = ""
			Me.txtRemarksApproval.Text = ""
			Me.lblRemarks_Click(Nothing, Nothing)
			Me.dtFile = FileAttachments.CreateFileTable()
			FileAttachments.SetFileDatagridview(Me.dtFile, Me.dgvFile)
			Me.skip_lblStatus.Text = "New P.O."
			Me.btnSave.Enabled = True
			Me.FillPRItems()
			Me.SetGridFill(-1)
		End Sub

		' Token: 0x06001208 RID: 4616 RVA: 0x000A27B3 File Offset: 0x000A09B3
		Private Sub btnClear_Click(sender As Object, e As EventArgs)
			Me.ClearForm()
		End Sub

		' Token: 0x06001209 RID: 4617 RVA: 0x000A27BD File Offset: 0x000A09BD
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x0600120A RID: 4618 RVA: 0x000A27C8 File Offset: 0x000A09C8
		Private Sub cmbVendor_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbVendor.SelectedIndex = -1
			If flag Then
				Me.cmbVendor.Text = ""
			End If
		End Sub

		' Token: 0x0600120B RID: 4619 RVA: 0x000A27FC File Offset: 0x000A09FC
		Private Sub cmbVendor_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbVendor.SelectedIndex <> -1
			If flag Then
				Me.txtVendorBillTo.Text = ""
				Me.txtVendorContact.Text = ""
				Me.txtVendorContactNo.Text = ""
				Me.txtVendorEmail.Text = ""
				Me.txtVendorGST.Text = ""
				Me.txtVendorPAN.Text = ""
			End If
		End Sub

		' Token: 0x0600120C RID: 4620 RVA: 0x000A2888 File Offset: 0x000A0A88
		Private Sub txtDelivery_TextChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.txtDelivery.Text), "", False) <> 0
			If flag Then
				Dim flag2 As Boolean = Versioned.IsNumeric(Strings.Trim(Me.txtDelivery.Text))
				If flag2 Then
					Me.dtpDelDt.Value = DateAndTime.DateAdd(DateInterval.Day, Conversion.Val(Me.txtDelivery.Text), Me.dtpDt.Value)
					Me.dtpDelDt.Checked = True
				Else
					Me.dtpDelDt.Value = DateAndTime.Now
					Me.dtpDelDt.Checked = False
				End If
			Else
				Me.dtpDelDt.Value = DateAndTime.Now
				Me.dtpDelDt.Checked = False
			End If
		End Sub

		' Token: 0x0600120D RID: 4621 RVA: 0x000A2951 File Offset: 0x000A0B51
		Private Sub lblFile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Me.dtFile = FileAttachments.AttachmentFile(Conversions.ToString(-1), Me.dtFile)
			FileAttachments.SetFileDatagridview(Me.dtFile, Me.dgvFile)
		End Sub

		' Token: 0x0600120E RID: 4622 RVA: 0x000A2980 File Offset: 0x000A0B80
		Private Sub dgvFile_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = e.RowIndex > -1
			If flag Then
				Dim array As DataRow() = Me.dtFile.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("FileID = '", Me.dgvFile.Rows(e.RowIndex).Cells("FileID").Value), "'")))
				Dim flag2 As Boolean = array.Length = 1
				If flag2 Then
					Dim text As String = Me.dgvFile.Columns(e.ColumnIndex).Name.ToString()
					If Operators.CompareString(text, "btnDelete_File", False) <> 0 Then
						If Operators.CompareString(text, "btnDownload_File", False) = 0 Then
							FileAttachments.DownloadFile(array(0))
						End If
					Else
						Me.dtFile.Rows.Remove(array(0))
						FileAttachments.SetFileDatagridview(Me.dtFile, Me.dgvFile)
					End If
				End If
			End If
		End Sub

		' Token: 0x0600120F RID: 4623 RVA: 0x000A2A74 File Offset: 0x000A0C74
		Private Sub llbAdd_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Dim flag As Boolean = Me.dtPR.Rows.Count > 0
			If flag Then
				CustomMsgBox.Show("Cannot Add New Items For PR.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Else
				Dim poitems As POItems = New POItems(-1, Me.sFormType, Me.skip_lblStatus.Text, Me.dtItems, Me.dtPR)
				Dim flag2 As Boolean = poitems.ShowDialog() = DialogResult.OK
				If flag2 Then
					Me.dtItems = poitems.dtItems
					Me.dgvDtls.DataSource = Me.dtItems
					Me.CalculateTotalAmt()
				End If
			End If
		End Sub

		' Token: 0x06001210 RID: 4624 RVA: 0x000A2B08 File Offset: 0x000A0D08
		Private Sub dgvDtls_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = (e.RowIndex > -1) And (e.ColumnIndex > -1)
			If flag Then
				Dim poitems As POItems = New POItems(e.RowIndex, Me.sFormType, Me.skip_lblStatus.Text, Me.dtItems, Me.dtPR)
				Dim flag2 As Boolean = poitems.ShowDialog() = DialogResult.OK
				If flag2 Then
					Me.dtItems = poitems.dtItems
					Me.dgvDtls.DataSource = Me.dtItems
					Me.CalculateTotalAmt()
					Me.ReorderSrNo()
				End If
			End If
		End Sub

		' Token: 0x06001211 RID: 4625 RVA: 0x000A2B94 File Offset: 0x000A0D94
		Private Sub ReorderSrNo()
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = Me.dtItems.Rows.Count - 1
			For i As Integer = 0 To num
				Me.dtItems.Rows(i)("SrNo") = i + 1
			Next
		End Sub

		' Token: 0x06001212 RID: 4626 RVA: 0x000A2BE8 File Offset: 0x000A0DE8
		Private Sub llbInvoiceTo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Dim addressSelect As AddressSelect = New AddressSelect("ImmunoACT", " WHERE AddressType = 'Billing'")
			Dim flag As Boolean = addressSelect.ShowDialog() = DialogResult.OK
			If flag Then
				Me.txtInvoiceTo.Text = Conversions.ToString(addressSelect.dr("Address"))
				Me.txtBillEmailID.Text = Conversions.ToString(addressSelect.dr("EmailAddress"))
				Me.txtGSTNo.Text = Conversions.ToString(addressSelect.dr("GSTINNo"))
				Me.txtPANNo.Text = Conversions.ToString(addressSelect.dr("PANNo"))
			End If
		End Sub

		' Token: 0x06001213 RID: 4627 RVA: 0x000A2C9C File Offset: 0x000A0E9C
		Private Sub llbShipTo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Dim addressSelect As AddressSelect = New AddressSelect("ImmunoACT", " WHERE AddressType = 'Shipping'")
			Dim flag As Boolean = addressSelect.ShowDialog() = DialogResult.OK
			If flag Then
				Me.txtShipTo.Text = Conversions.ToString(addressSelect.dr("Address"))
				Me.txtShipEmailID.Text = Conversions.ToString(addressSelect.dr("EmailAddress"))
			End If
		End Sub

		' Token: 0x06001214 RID: 4628 RVA: 0x000A2D0C File Offset: 0x000A0F0C
		Private Sub llbVendorBillTo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Dim flag As Boolean = Me.cmbVendor.SelectedIndex > -1
			If flag Then
				Dim addressSelect As AddressSelect = New AddressSelect("Vendor", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(" WHERE VendorID = '", Me.cmbVendor.SelectedValue), "'")))
				Dim flag2 As Boolean = addressSelect.ShowDialog() = DialogResult.OK
				If flag2 Then
					Me.txtVendorBillTo.Text = Conversions.ToString(addressSelect.dr("Address"))
					Me.txtVendorContact.Text = Conversions.ToString(addressSelect.dr("ContactName"))
					Me.txtVendorContactNo.Text = Conversions.ToString(addressSelect.dr("CellNo"))
					Me.txtVendorEmail.Text = Conversions.ToString(addressSelect.dr("EmailAddress"))
					Me.txtVendorGST.Text = Conversions.ToString(addressSelect.dr("GSTINNo"))
					Me.txtVendorPAN.Text = Conversions.ToString(addressSelect.dr("PANNo"))
				End If
			End If
		End Sub

		' Token: 0x06001215 RID: 4629 RVA: 0x000A2E38 File Offset: 0x000A1038
		Private Function ValidateForm() As Boolean
			Dim flag As Boolean = Operators.CompareString(Me.cmbPOType.Text, "", False) = 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Select PO Type.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.cmbPOType.Focus()
				flag2 = False
			Else
				Dim flag3 As Boolean = Operators.CompareString(Strings.Trim(Me.txtDelivery.Text), "", False) = 0
				If flag3 Then
					CustomMsgBox.Show("Enter Days Of Delivery.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.txtDelivery.Focus()
					flag2 = False
				Else
					Dim flag4 As Boolean = Not Versioned.IsNumeric(Me.txtDelivery.Text)
					If flag4 Then
						CustomMsgBox.Show("Invalid Days Of Delivery.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.txtDelivery.Focus()
						flag2 = False
					Else
						Dim flag5 As Boolean = Me.cmbDept.SelectedIndex = -1
						If flag5 Then
							CustomMsgBox.Show("Select Department.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.cmbDept.Focus()
							flag2 = False
						Else
							Dim flag6 As Boolean = Me.cmbVendor.SelectedIndex = -1
							If flag6 Then
								CustomMsgBox.Show("Select Vendor.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								Me.theme_tc.SelectedTab = Me.tpVendor
								Me.cmbVendor.Focus()
								flag2 = False
							Else
								Dim flag7 As Boolean = Operators.CompareString(Strings.Trim(Me.txtPaymentTerms.Text), "", False) = 0
								If flag7 Then
									CustomMsgBox.Show("Missing Payment Terms.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
									Me.theme_tc.SelectedTab = Me.tpTerms
									Me.txtPaymentTerms.Focus()
									flag2 = False
								Else
									Dim flag8 As Boolean = Me.dtItems.Rows.Count = 0
									If flag8 Then
										CustomMsgBox.Show("No Product Added.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
										Me.llbAdd.Focus()
										flag2 = False
									Else
										Dim flag9 As Boolean = Me.dtPR.Rows.Count > 0
										If flag9 Then
											Dim num As Integer = Me.dtItems.Rows.Count - 1
											For i As Integer = 0 To num
												Dim text As String = ""
												text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("ProductID = '", Me.dtItems.Rows(i)("ProductID")), "' ")))
												Dim obj As Object = Me.dtItems.Rows(i)("ProductType")
												Dim flag10 As Boolean = Operators.ConditionalCompareObjectEqual(obj, "Service", False)
												If flag10 Then
													text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" AND Description = '", Me.dtItems.Rows(i)("Description")), "' ")))
												End If
												Dim num2 As Integer = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.dtPR.Compute("SUM(Quantity)", text)))
												Dim flag11 As Boolean = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(i)("Quantity"))) < CDbl(num2)
												If flag11 Then
													Dim text2 As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Quantity For Product : '", Me.dtItems.Rows(i)("ProductName")), "' Cannot Be Less Than Requried PR Quantity."))
													CustomMsgBox.Show(text2, "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
													Me.theme_tc.SelectedTab = Me.tpItems
													Me.dgvDtls.Rows(i).Cells("Quantity").Selected = True
													Return False
												End If
											Next
										End If
										flag2 = True
									End If
								End If
							End If
						End If
					End If
				End If
			End If
			Return flag2
		End Function

		' Token: 0x06001216 RID: 4630 RVA: 0x000A3214 File Offset: 0x000A1414
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

		' Token: 0x06001217 RID: 4631 RVA: 0x000A3290 File Offset: 0x000A1490
		Private Sub Save()
			Dim flag As Boolean = CustomMsgBox.Show("Save..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
			If flag Then
				Dim flag2 As Boolean = Not Me.ValidateForm()
				If Not flag2 Then
					Me.btnSave.Enabled = False
					Dim flag3 As Boolean = Operators.CompareString(Me.txtID.Text, "", False) = 0
					If flag3 Then
						Me.InsertData()
						EmailModule.SendMail("PO Creation", Me.txtID.Text, "Created", Me.sEmailTo)
					Else
						Me.UpdateData()
						EmailModule.SendMail("PO Modification", Me.txtID.Text, "Modified", Me.sEmailTo)
					End If
				End If
			End If
		End Sub

		' Token: 0x06001218 RID: 4632 RVA: 0x000A3350 File Offset: 0x000A1550
		Private Sub InsertData01()
			Dim text As String = String.Concat(New String() { "EXEC usp_GetPONo '", Me.cmbPOType.Text, "', '", Strings.Format(Me.dtpDt.Value, "MM/dd/yyyy"), "'" })
			Dim dataTable As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				Dim text2 As String = Conversions.ToString(dataTable.Rows(0)("TrnNo"))
				Dim text3 As String = Conversions.ToString(Conversion.Val(Strings.Mid(text2, 11)))
				Dim text4 As String = "In Approval"
				Me.skip_lblStatus.Text = text4
				Dim list As List(Of SqlParameter) = New List(Of SqlParameter)()
				list.Add(New SqlParameter("@POType", Me.cmbPOType.Text))
				list.Add(New SqlParameter("@SeqNo", text3))
				list.Add(New SqlParameter("@PONo", text2))
				list.Add(New SqlParameter("@PODt", Strings.Format(Me.dtpDt.Value, "MM/dd/yyyy")))
				list.Add(New SqlParameter("@PRNo", Strings.Trim(Me.txtPRNo.Text)))
				list.Add(New SqlParameter("@Department", Me.cmbDept.Text))
				Dim flag2 As Boolean = Me.cmbReportingTo.SelectedIndex > -1
				If flag2 Then
					list.Add(New SqlParameter("@ActionBy", Me.cmbReportingTo.SelectedValue.ToString()))
				Else
					list.Add(New SqlParameter("@ActionBy", DBNull.Value))
				End If
				Dim checked As Boolean = Me.dtpPRDt.Checked
				If checked Then
					list.Add(New SqlParameter("@PRDt", Strings.Format(Me.dtpPRDt.Value, "MM/dd/yyyy")))
				Else
					list.Add(New SqlParameter("@PRDt", DBNull.Value))
				End If
				Dim checked2 As Boolean = Me.dtpValidity.Checked
				If checked2 Then
					list.Add(New SqlParameter("@ValidUpto", Strings.Format(Me.dtpValidity.Value, "MM/dd/yyyy")))
				Else
					list.Add(New SqlParameter("@ValidUpto", DBNull.Value))
				End If
				Dim checked3 As Boolean = Me.dtpDelDt.Checked
				If checked3 Then
					text = String.Concat(New String() { text, " '", Conversions.ToString(Conversion.Val(Me.txtDelivery.Text)), "', '", Strings.Format(Me.dtpDt.Value, "MM/dd/yyyy"), "', " & vbCrLf })
					list.Add(New SqlParameter("@DeliveryInDays", Conversion.Val(Me.txtDelivery.Text)))
					list.Add(New SqlParameter("@DeliveryDt", Strings.Format(Me.dtpDelDt.Value, "MM/dd/yyyy")))
				Else
					text += " NULL, NULL, "
					list.Add(New SqlParameter("@DeliveryInDays", DBNull.Value))
					list.Add(New SqlParameter("@DeliveryDt", DBNull.Value))
				End If
				list.Add(New SqlParameter("@InvoiceAddress", Strings.Trim(Me.txtInvoiceTo.Text)))
				list.Add(New SqlParameter("@BillingEmailID", Strings.Trim(Me.txtBillEmailID.Text)))
				list.Add(New SqlParameter("@ShipAddress", Strings.Trim(Me.txtShipTo.Text)))
				list.Add(New SqlParameter("@ShippingEmailID", Strings.Trim(Me.txtShipEmailID.Text)))
				list.Add(New SqlParameter("@GSTNo", Strings.Trim(Me.txtGSTNo.Text)))
				list.Add(New SqlParameter("@PANNo", Strings.Trim(Me.txtPANNo.Text)))
				list.Add(New SqlParameter("@VendorID", RuntimeHelpers.GetObjectValue(Me.cmbVendor.SelectedValue)))
				list.Add(New SqlParameter("@VendorBillingAddress", Strings.Trim(Me.txtVendorBillTo.Text)))
				list.Add(New SqlParameter("@VendorContactPerson", Strings.Trim(Me.txtVendorContact.Text)))
				list.Add(New SqlParameter("@VendorContactNo", Strings.Trim(Me.txtVendorContactNo.Text)))
				list.Add(New SqlParameter("@VendorEmailID", Strings.Trim(Me.txtVendorEmail.Text)))
				list.Add(New SqlParameter("@VendorGSTNo", Strings.Trim(Me.txtVendorGST.Text)))
				list.Add(New SqlParameter("@VendorPANNo", Strings.Trim(Me.txtVendorPAN.Text)))
				list.Add(New SqlParameter("@ModeOfPayment", Strings.Trim(Me.cmbModeOfPayment.Text)))
				list.Add(New SqlParameter("@DispatchedThrough", Strings.Trim(Me.txtDispatchThrough.Text)))
				list.Add(New SqlParameter("@PaymentTerms", Strings.Trim(Me.txtPaymentTerms.Text)))
				list.Add(New SqlParameter("@IncoTerms", Strings.Trim(Me.txtIncoTerms.Text)))
				list.Add(New SqlParameter("@DeliveryTerms", Strings.Trim(Me.txtDeliveryTerms.Text)))
				list.Add(New SqlParameter("@Currency", Me.cmbCurrency.Text))
				list.Add(New SqlParameter("@Status", text4))
				list.Add(New SqlParameter("@Comments", Strings.Trim(Me.txtComments.Text)))
				list.Add(New SqlParameter("@Remarks", Strings.Trim(Me.txtRemarks.Text)))
				list.Add(New SqlParameter("@CreatedBy", GlobalVariables.gsUserID))
				text = " INSERT INTO PO (POType, SeqNo, PONo, PODt, PRNo, Department, ActionBy, PRDt, ValidUpto, DeliveryInDays," & vbCrLf
				text += " DeliveryDt, InvoiceAddress, BillingEmailID, ShipAddress, ShippingEmailID, GSTNo, PANNo," & vbCrLf
				text += " VendorID, VendorBillingAddress, VendorContactPerson, VendorContactNo, VendorEmailID, VendorGSTNo, VendorPANNo," & vbCrLf
				text += " ModeOfPayment, DispatchedThrough, PaymentTerms, IncoTerms, DeliveryTerms, Currency, Status, Comments, Remarks, CreatedBy)" & vbCrLf
				text += " VALUES(@POType, @SeqNo, @PONo, @PODt, @PRNo, @Department, @ActionBy, @PRDt, @ValidUpto, @DeliveryInDays," & vbCrLf
				text += " @DeliveryDt, @InvoiceAddress, @BillingEmailID, @ShipAddress, @ShippingEmailID, @GSTNo, @PANNo," & vbCrLf
				text += " @VendorID, @VendorBillingAddress, @VendorContactPerson, @VendorContactNo, @VendorEmailID, @VendorGSTNo, @VendorPANNo," & vbCrLf
				text += " @ModeOfPayment, @DispatchedThrough, @PaymentTerms, @IncoTerms, @DeliveryTerms, @Currency, @Status, @Comments, @Remarks, @CreatedBy)" & vbCrLf
				text += " SELECT SCOPE_IDENTITY() AS ID"
				dataTable = MainModule.GetData(text, list)
				Dim flag3 As Boolean = dataTable.Rows.Count > 0
				If flag3 Then
					Me.txtID.Text = Conversions.ToString(dataTable.Rows(0)("ID"))
					Me.txtNo.Text = text2
					Me.InsertItems(Me.txtID.Text)
					Me.InsertPR(Me.txtID.Text)
					FileAttachments.InsertFiles("PO", Me.txtID.Text, Me.dtFile)
					Me.SetApprovalLevel()
					Dim text5 As String = "New ID : " + Me.txtID.Text + vbCrLf
					text5 = text5 + "PO No. : " + Me.txtNo.Text
					MainModule.TrnLog(Me.Text, "PO Generated", text5, Nothing)
					CustomMsgBox.Show("PO Generated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				End If
			End If
		End Sub

		' Token: 0x06001219 RID: 4633 RVA: 0x000A3B1C File Offset: 0x000A1D1C
		Private Sub InsertData()
			Dim text As String = String.Concat(New String() { "EXEC usp_GetPONo '", Me.cmbPOType.Text, "', '", Strings.Format(Me.dtpDt.Value, "MM/dd/yyyy"), "'" })
			Dim dataTable As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				Dim text2 As String = Conversions.ToString(dataTable.Rows(0)("TrnNo"))
				Dim text3 As String = Conversions.ToString(Conversion.Val(Strings.Mid(text2, 11)))
				Dim text4 As String = "In Approval"
				Me.skip_lblStatus.Text = text4
				text = " INSERT INTO PO (POType, SeqNo, PONo, PODt, PRNo, Department, ActionBy, PRDt, ValidUpto, DeliveryInDays, " & vbCrLf
				text += " DeliveryDt, InvoiceAddress, BillingEmailID, ShipAddress, ShippingEmailID, GSTNo, PANNo, " & vbCrLf
				text += " VendorID, VendorBillingAddress, VendorContactPerson, VendorContactNo, VendorEmailID, VendorGSTNo, VendorPANNo, " & vbCrLf
				text += " ModeOfPayment, DispatchedThrough, PaymentTerms, IncoTerms, DeliveryTerms, Currency, Status, Comments, Remarks, CreationDt, CreatedBy)" & vbCrLf
				text = String.Concat(New String() { text, " VALUES ('", Me.cmbPOType.Text, "', '", text3, "', '", text2, "', '", Strings.Format(Me.dtpDt.Value, "MM/dd/yyyy"), "', " & vbCrLf })
				text = String.Concat(New String() { text, " '", Strings.Trim(Me.txtPRNo.Text), "', '", Me.cmbDept.Text, "', " & vbCrLf })
				Dim flag2 As Boolean = Me.cmbReportingTo.SelectedIndex > -1
				If flag2 Then
					text = text + " '" + Me.cmbReportingTo.SelectedValue.ToString() + "', " & vbCrLf
				Else
					text += " NULL, " & vbCrLf
				End If
				Dim checked As Boolean = Me.dtpPRDt.Checked
				If checked Then
					text = text + " '" + Strings.Format(Me.dtpPRDt.Value, "MM/dd/yyyy") + "', " & vbCrLf
				Else
					text += " NULL, "
				End If
				Dim checked2 As Boolean = Me.dtpValidity.Checked
				If checked2 Then
					text = text + " '" + Strings.Format(Me.dtpValidity.Value, "MM/dd/yyyy") + "', " & vbCrLf
				Else
					text += " NULL, "
				End If
				Dim checked3 As Boolean = Me.dtpDelDt.Checked
				If checked3 Then
					text = String.Concat(New String() { text, " '", Conversions.ToString(Conversion.Val(Me.txtDelivery.Text)), "', '", Strings.Format(Me.dtpDt.Value, "MM/dd/yyyy"), "', " & vbCrLf })
				Else
					text += " NULL, NULL, "
				End If
				text = String.Concat(New String() { text, " '", MainModule.FilterSQL(Me.txtInvoiceTo.Text), "', '", Strings.Trim(Me.txtBillEmailID.Text), "', '", MainModule.FilterSQL(Me.txtShipTo.Text), "', " & vbCrLf })
				text = String.Concat(New String() { text, " '", Strings.Trim(Me.txtShipEmailID.Text), "', '", Strings.Trim(Me.txtGSTNo.Text), "', '", Strings.Trim(Me.txtPANNo.Text), "', " & vbCrLf })
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" '", Me.cmbVendor.SelectedValue), "', '"), MainModule.FilterSQL(Me.txtVendorBillTo.Text)), "', '"), MainModule.FilterSQL(Me.txtVendorContact.Text)), "', "), vbCrLf)))
				text = String.Concat(New String() { text, " '", Strings.Trim(Me.txtVendorContactNo.Text), "', '", Strings.Trim(Me.txtVendorEmail.Text), "', '", Strings.Trim(Me.txtVendorGST.Text), "', " & vbCrLf })
				text = String.Concat(New String() { text, " '", Strings.Trim(Me.txtVendorPAN.Text), "', '", Strings.Trim(Me.cmbModeOfPayment.Text), "', '", MainModule.FilterSQL(Me.txtDispatchThrough.Text), "', " & vbCrLf })
				text = String.Concat(New String() { text, " '", MainModule.FilterSQL(Me.txtPaymentTerms.Text), "', '", MainModule.FilterSQL(Me.txtIncoTerms.Text), "', " & vbCrLf })
				text = String.Concat(New String() { text, " '", MainModule.FilterSQL(Me.txtDeliveryTerms.Text), "', '", Me.cmbCurrency.Text, "', " & vbCrLf })
				text = String.Concat(New String() { text, " '", text4, "', '", MainModule.FilterSQL(Me.txtComments.Text), "', '", MainModule.FilterSQL(Me.txtRemarks.Text), "', GETDATE(), '", GlobalVariables.gsUserID, "')" & vbCrLf })
				text += " SELECT SCOPE_IDENTITY() AS ID"
				dataTable = MainModule.GetData(text)
				Dim flag3 As Boolean = dataTable.Rows.Count > 0
				If flag3 Then
					Me.txtID.Text = Conversions.ToString(dataTable.Rows(0)("ID"))
					Me.txtNo.Text = text2
					Me.InsertItems(Me.txtID.Text)
					Me.InsertPR(Me.txtID.Text)
					FileAttachments.InsertFiles("PO", Me.txtID.Text, Me.dtFile)
					Me.SetApprovalLevel()
					Dim text5 As String = "New ID : " + Me.txtID.Text + vbCrLf
					text5 = text5 + "PO No. : " + Me.txtNo.Text
					MainModule.TrnLog(Me.Text, "PO Generated", text5, Nothing)
					CustomMsgBox.Show("PO Generated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				End If
			End If
		End Sub

		' Token: 0x0600121A RID: 4634 RVA: 0x000A423C File Offset: 0x000A243C
		Private Sub UpdateData()
			Dim text As String = "In Approval"
			Me.skip_lblStatus.Text = text
			Dim text2 As String = String.Concat(New String() { " UPDATE PO SET PRNo = '", Strings.Trim(Me.txtPRNo.Text), "', Department = '", Me.cmbDept.Text, "', " & vbCrLf })
			Dim checked As Boolean = Me.dtpPRDt.Checked
			If checked Then
				text2 = text2 + " PRDt = '" + Strings.Format(Me.dtpPRDt.Value, "MM/dd/yyyy") + "', " & vbCrLf
			Else
				text2 += " PRDt = NULL, "
			End If
			Dim checked2 As Boolean = Me.dtpValidity.Checked
			If checked2 Then
				text2 = text2 + " ValidUpto = '" + Strings.Format(Me.dtpValidity.Value, "MM/dd/yyyy") + "', " & vbCrLf
			Else
				text2 += " ValidUpto = NULL, "
			End If
			Dim checked3 As Boolean = Me.dtpDelDt.Checked
			If checked3 Then
				text2 = String.Concat(New String() { text2, " DeliveryInDays = '", Conversions.ToString(Conversion.Val(Me.txtDelivery.Text)), "', DeliveryDt = '", Strings.Format(Me.dtpDelDt.Value, "MM/dd/yyyy"), "', " & vbCrLf })
			Else
				text2 += " DeliveryInDays = NULL, DeliveryDt = NULL, "
			End If
			text2 = String.Concat(New String() { text2, " InvoiceAddress = '", MainModule.FilterSQL(Me.txtInvoiceTo.Text), "', BillingEmailID = '", Strings.Trim(Me.txtBillEmailID.Text), "', " & vbCrLf })
			text2 = String.Concat(New String() { text2, " ShipAddress = '", MainModule.FilterSQL(Me.txtShipTo.Text), "', ShippingEmailID = '", Strings.Trim(Me.txtShipEmailID.Text), "', " & vbCrLf })
			text2 = String.Concat(New String() { text2, " GSTNo = '", Strings.Trim(Me.txtGSTNo.Text), "', PANNo = '", Strings.Trim(Me.txtPANNo.Text), "', " & vbCrLf })
			text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" VendorID = '", Me.cmbVendor.SelectedValue), "', VendorBillingAddress = '"), MainModule.FilterSQL(Me.txtVendorBillTo.Text)), "', "), vbCrLf)))
			text2 = String.Concat(New String() { text2, " VendorContactPerson = '", MainModule.FilterSQL(Me.txtVendorContact.Text), "', VendorContactNo = '", Strings.Trim(Me.txtVendorContactNo.Text), "', " & vbCrLf })
			text2 = String.Concat(New String() { text2, " VendorEmailID = '", Strings.Trim(Me.txtVendorEmail.Text), "', VendorGSTNo = '", Strings.Trim(Me.txtVendorGST.Text), "', " & vbCrLf })
			text2 = String.Concat(New String() { text2, " VendorPANNo = '", Strings.Trim(Me.txtVendorPAN.Text), "', ModeOfPayment = '", Strings.Trim(Me.cmbModeOfPayment.Text), "', " & vbCrLf })
			text2 = String.Concat(New String() { text2, " DispatchedThrough = '", MainModule.FilterSQL(Me.txtDispatchThrough.Text), "', PaymentTerms = '", MainModule.FilterSQL(Me.txtPaymentTerms.Text), "', " & vbCrLf })
			text2 = String.Concat(New String() { text2, " IncoTerms = '", MainModule.FilterSQL(Me.txtIncoTerms.Text), "', DeliveryTerms = '", MainModule.FilterSQL(Me.txtDeliveryTerms.Text), "', Currency = '", Strings.Trim(Me.cmbCurrency.Text), "', " & vbCrLf })
			text2 = String.Concat(New String() { text2, " Comments = '", Strings.Trim(Me.txtComments.Text), "', Remarks = '", Strings.Trim(Me.txtRemarks.Text), "', Status = '", text, "', " & vbCrLf })
			text2 = text2 + " ModificationDt = GETDATE(), ModifiedBy = '" + GlobalVariables.gsUserID + "'" & vbCrLf
			text2 = text2 + " WHERE POID  = '" + Me.txtID.Text + "'"
			Dim flag As Boolean = MainModule.ExecuteSQL(text2) = 1
			If flag Then
				Me.InsertItems(Me.txtID.Text)
				Me.InsertPR(Me.txtID.Text)
				FileAttachments.InsertFiles("PO", Me.txtID.Text, Me.dtFile)
				Me.SetApprovalLevel()
				Dim text3 As String = "ID : " + Me.txtID.Text + vbCrLf
				text3 = text3 + "PO No. : " + Me.txtNo.Text
				MainModule.TrnLog(Me.Text, "PO Modified", text3, Nothing)
				CustomMsgBox.Show("PO Modified.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End If
		End Sub

		' Token: 0x0600121B RID: 4635 RVA: 0x000A47DC File Offset: 0x000A29DC
		Private Sub InsertItems(sID As String)
			Dim flag As Boolean = (Operators.CompareString(sID, "", False) <> 0) And (Me.dtItems.Rows.Count > 0)
			If flag Then
				Dim sqlConnection As SqlConnection = New SqlConnection(GlobalVariables.gsConStr)
				sqlConnection.Open()
				Dim sqlTransaction As SqlTransaction = sqlConnection.BeginTransaction(IsolationLevel.Serializable)
				Try
					Dim text As String = "DELETE FROM POItems WHERE POID = '" + sID + "'"
					Dim flag2 As Boolean = MainModule.ExecuteSQL(text, sqlConnection, sqlTransaction) = 1
					If flag2 Then
						Dim dataTable As DataTable = Me.dtItems.Copy()
						dataTable.Columns.Remove("SrNo")
						dataTable.Columns.Remove("ProductType")
						dataTable.Columns.Remove("ProductName")
						dataTable.Columns.Remove("CatalogNo")
						dataTable.Columns.Remove("HSNSACCode")
						dataTable.Columns.Remove("TertiaryUOM")
						dataTable.Columns.Remove("TertiaryPackSize")
						dataTable.Columns.Remove("PrimaryUOM")
						dataTable.Columns.Remove("PrimaryPackSize")
						dataTable.Columns.Remove("Measurement")
						Dim dataColumn As DataColumn = New DataColumn("POID", GetType(Integer))
						dataColumn.DefaultValue = sID
						dataTable.Columns.Add(dataColumn)
						MainModule.BulkInsertTemp(dataTable, "POItems", sqlConnection, sqlTransaction)
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

		' Token: 0x0600121C RID: 4636 RVA: 0x000A49D8 File Offset: 0x000A2BD8
		Private Sub InsertPR(sID As String)
			Dim flag As Boolean = Operators.CompareString(sID, "", False) <> 0
			If flag Then
				Dim sqlConnection As SqlConnection = New SqlConnection(GlobalVariables.gsConStr)
				sqlConnection.Open()
				Dim sqlTransaction As SqlTransaction = sqlConnection.BeginTransaction(IsolationLevel.Serializable)
				Try
					Dim text As String = " UPDATE PRItems SET Status = 'Pending' " & vbCrLf
					text += " FROM PRItems PR INNER JOIN POPR " & vbCrLf
					text += " ON PR.PRID = POPR.PRID " & vbCrLf
					text += " AND PR.ProductID = POPR.ProductID " & vbCrLf
					text += " AND PR.Description = POPR.Description " & vbCrLf
					text = text + " WHERE POPR.POID = '" + sID + "' " & vbCrLf
					text = text + " DELETE FROM POPR WHERE POID = '" + sID + "'"
					Dim flag2 As Boolean = MainModule.ExecuteSQL(text, sqlConnection, sqlTransaction) = 1
					If flag2 Then
						Dim dataTable As DataTable = Me.dtPR.DefaultView.ToTable(True, New String() { "PRID", "ProductID", "Description" })
						Dim dataColumn As DataColumn = New DataColumn("POID", GetType(Integer))
						dataColumn.DefaultValue = sID
						dataTable.Columns.Add(dataColumn)
						MainModule.BulkInsertTemp(dataTable, "POPR", sqlConnection, sqlTransaction)
						Me.UpdatePRItemStatus(Me.dtPR, sqlConnection, sqlTransaction)
						sqlTransaction.Commit()
						sqlConnection.Close()
						Me.UpdatePRStatus()
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

		' Token: 0x0600121D RID: 4637 RVA: 0x000A4B8C File Offset: 0x000A2D8C
		Private Sub SetApprovalLevel()
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				Dim text As String = If(("EXEC usp_UpdatePOApprovalLevel " + Me.txtID.Text), "")
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text) = 1
				If flag2 Then
				End If
			End If
		End Sub

		' Token: 0x0600121E RID: 4638 RVA: 0x000A4BE8 File Offset: 0x000A2DE8
		Private Sub UpdatePRItemStatus(dt As DataTable, oCon As SqlConnection, oTrn As SqlTransaction)
			Dim text As String = ""
			Dim num As Integer = dt.Rows.Count - 1
			For i As Integer = 0 To num
				text += " UPDATE PRItems SET Status = 'PO Generated' "
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" WHERE PRID = '", dt.Rows(i)("PRID")), "' ")))
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" AND ProductID = '", dt.Rows(i)("ProductID")), " '"), vbCrLf)))
				Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(dt.Rows(i)("ProductType"), "Service", False)
				If flag Then
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" AND Description = '", dt.Rows(i)("Description")), " '"), vbCrLf)))
				End If
			Next
			Dim flag2 As Boolean = Operators.CompareString(text, "", False) <> 0
			If flag2 Then
				MainModule.ExecuteSQL(text, oCon, oTrn)
			End If
		End Sub

		' Token: 0x0600121F RID: 4639 RVA: 0x000A4D28 File Offset: 0x000A2F28
		Private Sub UpdatePRStatus()
			Dim text As String = ""
			Dim dataTable As DataTable = Me.dtPR.DefaultView.ToTable(True, New String() { "PRID" })
			Dim num As Integer = dataTable.Rows.Count - 1
			For i As Integer = 0 To num
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("EXEC usp_Set_PR_Status '", dataTable.Rows(i)("PRID")), "' "), vbCrLf)))
			Next
			Dim flag As Boolean = Operators.CompareString(text, "", False) <> 0
			If flag Then
				MainModule.ExecuteSQL(text)
			End If
		End Sub

		' Token: 0x06001220 RID: 4640 RVA: 0x000A4DD4 File Offset: 0x000A2FD4
		Private Sub btnApprove_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Dim text As String = Me.sFormType
				If Operators.CompareString(text, "PO Approval", False) <> 0 Then
					If Operators.CompareString(text, "PO Cost Approval", False) = 0 Then
						Me.Cost_Approve_Reject("Approved")
						Me.ConfigureSendMail("PO Cost Approval", Me.txtID.Text, "Cost Approved")
					End If
				Else
					Me.Approve_Reject("Approved")
					Me.ConfigureSendMail("PO Approval", Me.txtID.Text, "Approved")
				End If
				EmailModule.Send_PR_Status_PO_MailAlert(Me.txtID.Text, "PO", "")
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnApprove.Enabled = True
				Me.btnOnHold.Enabled = True
				Me.btnReject.Enabled = True
				Me.btnCancel.Enabled = True
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06001221 RID: 4641 RVA: 0x000A4F08 File Offset: 0x000A3108
		Private Sub btnReject_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Dim text As String = Me.sFormType
				If Operators.CompareString(text, "PO Approval", False) <> 0 Then
					If Operators.CompareString(text, "PO Cost Approval", False) = 0 Then
						Me.Cost_Approve_Reject("Rejected")
						Me.ConfigureSendMail("PO Cost Approval", Me.txtID.Text, "Cost Rejected")
					End If
				Else
					Me.Approve_Reject("Rejected")
					Me.ConfigureSendMail("PO Approval", Me.txtID.Text, "Rejected")
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnApprove.Enabled = True
				Me.btnReject.Enabled = True
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06001222 RID: 4642 RVA: 0x000A5004 File Offset: 0x000A3204
		Private Sub Approve_Reject(sStatus As String)
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				Dim text As String = "Approve PO..?"
				Dim flag2 As Boolean = Operators.CompareString(sStatus, "Rejected", False) = 0
				If flag2 Then
					text = "Reject PO..?"
				End If
				Dim flag3 As Boolean = CustomMsgBox.Show("Changes Cannot Be Reverted." & vbCrLf + text, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
				If flag3 Then
					Me.btnApprove.Enabled = False
					Me.btnOnHold.Enabled = False
					Me.btnReject.Enabled = False
					Me.btnCancel.Enabled = False
					Dim text2 As String = ""
					Dim flag4 As Boolean = Operators.CompareString(sStatus, "Rejected", False) = 0
					Dim text3 As String
					If flag4 Then
						text3 = "Rejection"
					Else
						sStatus = "In Cost Approval"
						text3 = "Approval"
					End If
					Dim captureReasons As CaptureReasons = New CaptureReasons(text3)
					Dim flag5 As Boolean = captureReasons.ShowDialog() = DialogResult.OK
					If flag5 Then
						text2 = text2 + "Action : " + sStatus + vbCrLf
						text2 = text2 + "Action By : " + GlobalVariables.gsUserName + vbCrLf
						text2 = text2 + "Action On : " + Strings.Format(MainModule.GetServerDate(), "dd-MMM-yyyy hh:mm:ss tt") + vbCrLf
						text2 = text2 + "Remarks : " + captureReasons.sRemarks + vbCrLf & vbCrLf
						Dim txtRemarksApproval As TextBox = Me.txtRemarksApproval
						Dim textBox As TextBox = txtRemarksApproval
						txtRemarksApproval.Text = textBox.Text + text2
						Me.lblRemarksApproval_Click(Nothing, Nothing)
						Dim text4 As String = String.Concat(New String() { " UPDATE PO SET Status = '", sStatus, "', ActionRemarks = '", Me.txtRemarksApproval.Text, "', " & vbCrLf })
						text4 = text4 + " ActionDt = GETDATE(), ActionBy = '" + GlobalVariables.gsUserID + "'" & vbCrLf
						text4 = text4 + " WHERE POID = '" + Me.txtID.Text + "'"
						Dim flag6 As Boolean = MainModule.ExecuteSQL(text4) = 1
						If flag6 Then
							Dim text5 As String = "ID : " + Me.txtID.Text + vbCrLf
							text5 = text5 + "PO No. : " + Me.txtNo.Text
							Me.skip_lblStatus.Text = sStatus
							MainModule.TrnLog(Me.Text, If(("PO " + sStatus), ""), text5, Nothing)
							CustomMsgBox.Show("PO " + sStatus + ".", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Else
							Me.btnApprove.Enabled = True
							Me.btnOnHold.Enabled = True
							Me.btnReject.Enabled = True
							Me.btnCancel.Enabled = True
						End If
					Else
						CustomMsgBox.Show("Remark For " + text3 + " Is Mandatory.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					End If
				End If
			End If
		End Sub

		' Token: 0x06001223 RID: 4643 RVA: 0x000A52F8 File Offset: 0x000A34F8
		Private Sub Cost_Approve_Reject(sStatus As String)
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				Dim text As String = "Approve PO..?"
				Dim flag2 As Boolean = Operators.CompareString(sStatus, "Rejected", False) = 0
				If flag2 Then
					text = "Reject PO..?"
				End If
				Dim flag3 As Boolean = CustomMsgBox.Show("Changes Cannot Be Reverted." & vbCrLf + text, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
				If flag3 Then
					Me.btnApprove.Enabled = False
					Me.btnOnHold.Enabled = False
					Me.btnReject.Enabled = False
					Me.btnCancel.Enabled = False
					Dim text2 As String = ""
					Dim flag4 As Boolean = Operators.CompareString(sStatus, "Rejected", False) = 0
					Dim text3 As String
					If flag4 Then
						text3 = "Rejection"
					Else
						text3 = "Approval"
					End If
					Dim captureReasons As CaptureReasons = New CaptureReasons(text3)
					Dim flag5 As Boolean = captureReasons.ShowDialog() = DialogResult.OK
					If flag5 Then
						text2 = text2 + "Action : Cost " + sStatus + vbCrLf
						text2 = text2 + "Action By : " + GlobalVariables.gsUserName + vbCrLf
						text2 = text2 + "Action On : " + Strings.Format(MainModule.GetServerDate(), "dd-MMM-yyyy hh:mm:ss tt") + vbCrLf
						text2 = text2 + "Remarks : " + captureReasons.sRemarks
						Dim txtRemarksApproval As TextBox = Me.txtRemarksApproval
						Dim textBox As TextBox = txtRemarksApproval
						txtRemarksApproval.Text = textBox.Text + text2
						Me.lblRemarksApproval_Click(Nothing, Nothing)
						Dim text4 As String = String.Concat(New String() { " UPDATE PO SET Status = 'Cost ", sStatus, "', ActionRemarks = '", Me.txtRemarksApproval.Text, "', " & vbCrLf })
						text4 = text4 + " CostActionDt = GETDATE(), CostActionBy = '" + GlobalVariables.gsUserID + "'" & vbCrLf
						text4 = text4 + " WHERE POID = '" + Me.txtID.Text + "'"
						Dim flag6 As Boolean = MainModule.ExecuteSQL(text4) = 1
						If flag6 Then
							Dim text5 As String = "ID : " + Me.txtID.Text + vbCrLf
							text5 = text5 + "PO No. : " + Me.txtNo.Text
							text5 += text2
							Me.skip_lblStatus.Text = sStatus
							MainModule.TrnLog(Me.Text, If(("PO Cost " + sStatus), ""), text5, Nothing)
							CustomMsgBox.Show("PO Cost " + sStatus + ".", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Else
							Me.btnApprove.Enabled = True
							Me.btnOnHold.Enabled = True
							Me.btnReject.Enabled = True
							Me.btnCancel.Enabled = True
						End If
					Else
						CustomMsgBox.Show("Remark For Cost " + text3 + " Is Mandatory.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					End If
				End If
			End If
		End Sub

		' Token: 0x06001224 RID: 4644 RVA: 0x000A55EC File Offset: 0x000A37EC
		Private Sub btnOnHold_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Dim flag As Boolean = CustomMsgBox.Show("Put On Hold..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
				If flag Then
					Dim text As String = Me.sFormType
					If Operators.CompareString(text, "PO Approval", False) <> 0 Then
						If Operators.CompareString(text, "PO Cost Approval", False) = 0 Then
							Me.Cost_OnHold()
							Me.ConfigureSendMail("PO Cost Approval", Me.txtID.Text, "Cost On-Hold")
						End If
					Else
						Me.OnHold()
						Me.ConfigureSendMail("PO Approval", Me.txtID.Text, "On-Hold")
					End If
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnApprove.Enabled = True
				Me.btnOnHold.Enabled = True
				Me.btnReject.Enabled = True
				Me.btnCancel.Enabled = True
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06001225 RID: 4645 RVA: 0x000A5714 File Offset: 0x000A3914
		Private Sub OnHold()
			Dim captureReasons As CaptureReasons = New CaptureReasons("On-Hold")
			Dim flag As Boolean = captureReasons.ShowDialog() = DialogResult.OK
			If flag Then
				Me.btnApprove.Enabled = False
				Me.btnOnHold.Enabled = False
				Me.btnReject.Enabled = False
				Me.btnCancel.Enabled = False
				Dim text As String = "Action : On-Hold" & vbCrLf
				text = text + "Action By : " + GlobalVariables.gsUserName + vbCrLf
				text = text + "Action On : " + Strings.Format(MainModule.GetServerDate(), "dd-MMM-yyyy hh:mm:ss tt") + vbCrLf
				text = text + "Remarks : " + captureReasons.sRemarks + vbCrLf & vbCrLf
				Dim txtRemarksApproval As TextBox = Me.txtRemarksApproval
				Dim textBox As TextBox = txtRemarksApproval
				txtRemarksApproval.Text = textBox.Text + text
				Me.lblRemarksApproval.Visible = True
				Me.lblRemarksApproval_Click(Nothing, Nothing)
				Dim text2 As String = " UPDATE PO SET Status = 'On-Hold', ActionRemarks = '" + Me.txtRemarksApproval.Text + "', " & vbCrLf
				text2 = text2 + " ActionDt = GETDATE(), ActionBy = '" + GlobalVariables.gsUserID + "'" & vbCrLf
				text2 = text2 + " WHERE POID  = '" + Me.txtID.Text + "'"
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text2) = 1
				If flag2 Then
					Dim text3 As String = "ID : " + Me.txtID.Text + vbCrLf
					text3 = text3 + "PO No. : " + Me.txtNo.Text
					Me.skip_lblStatus.Text = "On-Hold"
					MainModule.TrnLog(Me.Text, "PO On-Hold", text3, Nothing)
					CustomMsgBox.Show("PO On-Hold.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Else
					Me.btnApprove.Enabled = True
					Me.btnOnHold.Enabled = True
					Me.btnReject.Enabled = True
					Me.btnCancel.Enabled = True
				End If
			End If
		End Sub

		' Token: 0x06001226 RID: 4646 RVA: 0x000A5900 File Offset: 0x000A3B00
		Private Sub Cost_OnHold()
			Dim captureReasons As CaptureReasons = New CaptureReasons("On-Hold")
			Dim flag As Boolean = captureReasons.ShowDialog() = DialogResult.OK
			If flag Then
				Me.btnApprove.Enabled = False
				Me.btnOnHold.Enabled = False
				Me.btnReject.Enabled = False
				Me.btnCancel.Enabled = False
				Dim text As String = "Action : Cost On-Hold" & vbCrLf
				text = text + "Action By : " + GlobalVariables.gsUserName + vbCrLf
				text = text + "Action On : " + Strings.Format(MainModule.GetServerDate(), "dd-MMM-yyyy hh:mm:ss tt") + vbCrLf
				text = text + "Remarks : " + captureReasons.sRemarks + vbCrLf & vbCrLf
				Dim txtRemarksApproval As TextBox = Me.txtRemarksApproval
				Dim textBox As TextBox = txtRemarksApproval
				txtRemarksApproval.Text = textBox.Text + text
				Me.lblRemarksApproval.Visible = True
				Me.lblRemarksApproval_Click(Nothing, Nothing)
				Dim text2 As String = " UPDATE PO SET Status = 'Cost On-Hold', ActionRemarks = '" + Me.txtRemarksApproval.Text + "', " & vbCrLf
				text2 = text2 + " CostActionDt = GETDATE(), CostActionBy = '" + GlobalVariables.gsUserID + "'" & vbCrLf
				text2 = text2 + " WHERE POID  = '" + Me.txtID.Text + "'"
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text2) = 1
				If flag2 Then
					Dim text3 As String = "ID : " + Me.txtID.Text + vbCrLf
					text3 = text3 + "PO No. : " + Me.txtNo.Text
					text3 += text
					Me.skip_lblStatus.Text = "Cost On-Hold"
					MainModule.TrnLog(Me.Text, "PO Cost On-Hold", text3, Nothing)
					CustomMsgBox.Show("PO Cost On-Hold.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Else
					Me.btnApprove.Enabled = True
					Me.btnOnHold.Enabled = True
					Me.btnReject.Enabled = True
					Me.btnCancel.Enabled = True
				End If
			End If
		End Sub

		' Token: 0x06001227 RID: 4647 RVA: 0x000A5AF8 File Offset: 0x000A3CF8
		Private Sub btnCancel_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.Cancelletion()
				EmailModule.SendMail("PO Cancellation", Me.txtID.Text, Me.sEmailTo, "")
				EmailModule.Send_PR_Status_PO_MailAlert(Me.txtID.Text, "PO", "")
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnCancel.Enabled = True
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06001228 RID: 4648 RVA: 0x000A5BB0 File Offset: 0x000A3DB0
		Private Sub Cancelletion()
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				Dim flag2 As Boolean = CustomMsgBox.Show("Changes Cannot Be Reverted." & vbCrLf & "Cancel PO..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
				If flag2 Then
					Dim captureReasons As CaptureReasons = New CaptureReasons("Cancellation")
					Dim flag3 As Boolean = captureReasons.ShowDialog() = DialogResult.OK
					If flag3 Then
						Dim sRemarks As String = captureReasons.sRemarks
						Dim text As String = String.Concat(New String() { " UPDATE PO SET Status = 'Cancelled', CancelledBy = '", GlobalVariables.gsUserID, "', CancelledDt = GETDATE(), CancelledRemarks = '", sRemarks, "'" })
						text = text + " WHERE POID = '" + Me.txtID.Text + "'"
						Dim flag4 As Boolean = MainModule.ExecuteSQL(text) = 1
						If flag4 Then
							Me.skip_lblStatus.Text = "Cancelled"
							Me.btnSave.Enabled = False
							Me.btnClear.Enabled = False
							Me.btnCancel.Enabled = False
							Me.btnApprove.Enabled = False
							Me.btnReject.Enabled = False
							Dim text2 As String = "ID : " + Me.txtID.Text + vbCrLf
							text2 = text2 + "PO No. : " + Me.txtNo.Text
							MainModule.TrnLog(Me.Text, "PO Cancelled", text2, Nothing)
							CustomMsgBox.Show("PO Cancelled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						End If
					Else
						CustomMsgBox.Show("Remark For Cancellation Is Mandatory.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					End If
				End If
			End If
		End Sub

		' Token: 0x06001229 RID: 4649 RVA: 0x000A5D54 File Offset: 0x000A3F54
		Private Sub btnAmend_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.AmendPO()
				EmailModule.SendMail("PO Amendment", Me.txtID.Text, Me.sEmailTo, "")
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnAmend.Enabled = True
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x0600122A RID: 4650 RVA: 0x000A5DF0 File Offset: 0x000A3FF0
		Private Sub AmendPO()
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				Dim flag2 As Boolean = CustomMsgBox.Show("Changes Cannot Be Reverted." & vbCrLf & "Amend PO..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
				If flag2 Then
					Dim captureReasons As CaptureReasons = New CaptureReasons("Amendment")
					Dim flag3 As Boolean = captureReasons.ShowDialog() = DialogResult.OK
					If flag3 Then
						Dim sRemarks As String = captureReasons.sRemarks
						Dim flag4 As Boolean = Me.txtNo.Text.Length > 16
						Dim text As String
						If flag4 Then
							text = Strings.Mid(Me.txtNo.Text, 1, 16) + "/" + Strings.Format(Conversion.Val(Strings.Mid(Me.txtNo.Text, 18)) + 1.0, "#00")
						Else
							text = Me.txtNo.Text + "/01"
						End If
						Dim text2 As String = " UPDATE PO SET Status = 'Amended', AmendedBy = '" + GlobalVariables.gsUserID + "', AmendedDt = GETDATE(), "
						text2 = text2 + " AmendedRemarks = '" + sRemarks + "' "
						text2 = text2 + " WHERE POID = '" + Me.txtID.Text + "' " & vbCrLf
						text2 += " INSERT INTO PO (POType, PONo, PODt, PRNo, PRDt, ValidUpto, DeliveryInDays, DeliveryDt, " & vbCrLf
						text2 += " ActionBy, Department, InvoiceAddress, BillingEmailID, ShipAddress, ShippingEmailID, GSTNo, PANNo, " & vbCrLf
						text2 += " VendorID, VendorBillingAddress, VendorContactPerson, VendorContactNo, VendorEmailID, VendorGSTNo, VendorPANNo, " & vbCrLf
						text2 += " ModeOfPayment, DispatchedThrough, PaymentTerms, IncoTerms, DeliveryTerms, Currency, " & vbCrLf
						text2 += " Comments, Remarks, BasePONo, Status, CreatedBy) " & vbCrLf
						text2 = text2 + " SELECT POType, '" + text + "' AS PONo, GETDATE() AS PODt, PRNo, PRDt, ValidUpto, DeliveryInDays, DeliveryDt, " & vbCrLf
						text2 = text2 + " " + GlobalVariables.gsReportingToID + " AS ActionBy, Department, InvoiceAddress, BillingEmailID, ShipAddress, ShippingEmailID, GSTNo, PANNo, " & vbCrLf
						text2 += " VendorID, VendorBillingAddress, VendorContactPerson, VendorContactNo, VendorEmailID, VendorGSTNo, VendorPANNo,  " & vbCrLf
						text2 += " ModeOfPayment, DispatchedThrough, PaymentTerms, IncoTerms, DeliveryTerms, Currency, Comments, Remarks," & vbCrLf
						text2 = String.Concat(New String() { text2, " '", Me.txtNo.Text, "' AS BasePONo, 'In Approval' AS Status, '", GlobalVariables.gsUserID, "' AS CreatedBy " & vbCrLf })
						text2 += " FROM  PO " & vbCrLf
						text2 = text2 + " WHERE POID = '" + Me.txtID.Text + "' " & vbCrLf
						text2 += " SELECT SCOPE_IDENTITY() AS ID " & vbCrLf
						Dim dataTable As DataTable = MainModule.GetData(text2)
						Dim flag5 As Boolean = dataTable.Rows.Count > 0
						If flag5 Then
							Me.btnAmend.Enabled = False
							Dim text3 As String = Conversions.ToString(dataTable.Rows(0)("ID"))
							Dim text4 As String = "ID : " + text3 + vbCrLf
							text4 = text4 + "PO No. : " + text
							Me.InsertItems(text3)
							Me.InsertPR(Me.txtID.Text)
							FileAttachments.InsertFiles("PO", text3, Me.dtFile)
							MainModule.TrnLog(Me.Text, "PO Generated", "New ID: " + text3, Nothing)
							text4 = "ID : " + Me.txtID.Text + vbCrLf
							text4 = text4 + "PO No. : " + Me.txtNo.Text
							MainModule.TrnLog(Me.Text, "PO Amended", "ID: " + Me.txtID.Text, Nothing)
							CustomMsgBox.Show("PO Amended.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							text2 = " SELECT POID AS ID, POType, PONo, PODt, PRNo, PRDt, ValidUpto, DeliveryInDays, DeliveryDt, " & vbCrLf
							text2 += " P.Department, InvoiceAddress, BillingEmailID, ShipAddress, ShippingEmailID, GSTNo, PANNo, " & vbCrLf
							text2 += " VendorID, VendorBillingAddress, VendorContactPerson, " & vbCrLf
							text2 += " VendorContactNo, VendorEmailID, VendorGSTNo, VendorPANNo, " & vbCrLf
							text2 += " ModeOfPayment, DispatchedThrough, PaymentTerms, IncoTerms, DeliveryTerms, Currency, " & vbCrLf
							text2 += " Comments, Remarks, ActionRemarks, ActionBy ActionByID, Status, " & vbCrLf
							text2 += " Created.EmailID AS CreatedByEmailID, Modified.EmailID AS ModifiedByEmailID, " & vbCrLf
							text2 += " P.CreationDt, Created.UserName AS CreatedBy, P.ModificationDt, Modified.UserName AS ModifiedBy " & vbCrLf
							text2 += " FROM PO P " & vbCrLf
							text2 += " LEFT OUTER JOIN [User] AS Created ON P.CreatedBy = Created.UserID  " & vbCrLf
							text2 += " LEFT OUTER JOIN [User] AS Modified ON P.ModifiedBy = Modified.UserID " & vbCrLf
							text2 = text2 + " WHERE P.POID = '" + text3 + "' " & vbCrLf
							dataTable = MainModule.GetData(text2)
							Dim flag6 As Boolean = dataTable.Rows.Count > 0
							If flag6 Then
								Dim pogeneration As POGeneration01 = New POGeneration01("PO Modify", dataTable.Rows(0))
								pogeneration.Show(MyBase.DockPanel)
								pogeneration.Focus()
							End If
						End If
					Else
						CustomMsgBox.Show("Remark For Amendment Is Mandatory.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					End If
				End If
			End If
		End Sub

		' Token: 0x0600122B RID: 4651 RVA: 0x000A6244 File Offset: 0x000A4444
		Private Sub btnPrint_Click(sender As Object, e As EventArgs)
			Try
				Me.PrintReport()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x0600122C RID: 4652 RVA: 0x000A629C File Offset: 0x000A449C
		Private Sub PrintReport()
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				Dim text As String = " UPDATE PO SET Status = 'Printed', PrintBy = '" + GlobalVariables.gsUserID + "', PrintDt = GETDATE() "
				text = text + " WHERE POID = '" + Me.txtID.Text + "' AND Status = 'Cost Approved'"
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text) = 1
				If flag2 Then
					Me.skip_lblStatus.Text = "Printed"
					text = " SELECT PO.POID, POType, PONo, PODt, PRNo, PRDt, ValidUpto, DeliveryDt, PO.Department, " & vbCrLf
					text += " InvoiceAddress, BillingEmailID, ShipAddress, ShippingEmailID, GSTNo, PANNo, " & vbCrLf
					text += " VendorName, VendorBillingAddress, VendorContactPerson, VendorContactNo, VendorEmailID, VendorGSTNo, VendorPANNo, " & vbCrLf
					text += " BankType, BankName, BankAddress, AccountNo, IFSCCode, IBANNo, BankRoutingNo, BankSortCode, SWIFTCode, " & vbCrLf
					text += " ModeOfPayment, DispatchedThrough, PaymentTerms, IncoTerms, DeliveryTerms, PO.Currency, PO.Comments, " & vbCrLf
					text += " CASE WHEN PO.ModifiedBy IS NOT NULL THEN M.UserName ELSE C.UserName END AS CreatedBy, " & vbCrLf
					text += " CASE WHEN PO.ModificationDt IS NOT NULL THEN PO.ModificationDt ELSE PO.CreationDt END AS CreationDt, " & vbCrLf
					text = text + " A.UserName AS ApprovedBy, '" + GlobalVariables.gsUserName + "' AS PrintedBy, " & vbCrLf
					text += " ROW_NUMBER() OVER(ORDER BY POItemsID) AS SrNo, ProductName, Description, CatalogNo, HSNSACCode, TertiaryUOM UOM, " & vbCrLf
					text += " Quantity, POI.UnitPrice, BasicValue, DiscountPer, DiscountAmt, NetAmt, TaxPer, TaxAmt, " & vbCrLf
					text += " Transportation, Freight, LoadingUnloading, Packing, OtherCharges, FinalAmt " & vbCrLf
					text += " FROM PO " & vbCrLf
					text += " INNER JOIN Vendor V ON PO.VendorID = V.VendorID " & vbCrLf
					text += " INNER JOIN [User] C ON PO.CreatedBy = C.UserID " & vbCrLf
					text += " LEFT OUTER JOIN [User] M ON Po.ModifiedBy = M.UserID " & vbCrLf
					text += " INNER JOIN [User] A ON PO.ActionBy = A.UserID " & vbCrLf
					text += " INNER JOIN POItems POI ON PO.POID = POI.POID " & vbCrLf
					text += " INNER JOIN Product Prod ON POI.ProductID = Prod.ProductID " & vbCrLf
					text = text + " WHERE PO.POID = '" + Me.txtID.Text + "' " & vbCrLf
					Dim data As DataTable = MainModule.GetData(text)
					Dim flag3 As Boolean = data.Rows.Count > 0
					If flag3 Then
						Dim reportCrystal As ReportCrystal = New ReportCrystal("PO", data)
						reportCrystal.Show(MyBase.DockPanel)
					End If
					Dim text2 As String = "ID : " + Me.txtID.Text + vbCrLf
					text2 = text2 + "PO No. : " + Me.txtNo.Text
					MainModule.TrnLog(Me.Text, "PO Printing", text2, Nothing)
					EmailModule.SendMail("PO Printing", Me.txtID.Text, Me.sEmailTo, "")
				End If
			End If
		End Sub

		' Token: 0x0600122D RID: 4653 RVA: 0x000A64BC File Offset: 0x000A46BC
		Private Sub lblRemarks_Click(sender As Object, e As EventArgs)
			Me.lblRemarks.BorderStyle = BorderStyle.FixedSingle
			Me.lblRemarksApproval.BorderStyle = BorderStyle.None
			Me.lblRemarks1.Visible = True
			Me.lblRemarksApproval1.Visible = False
			Me.txtRemarks.Visible = True
			Me.txtRemarksApproval.Visible = False
		End Sub

		' Token: 0x0600122E RID: 4654 RVA: 0x000A6518 File Offset: 0x000A4718
		Private Sub lblRemarksApproval_Click(sender As Object, e As EventArgs)
			Me.lblRemarks.BorderStyle = BorderStyle.None
			Me.lblRemarksApproval.BorderStyle = BorderStyle.FixedSingle
			Me.lblRemarks1.Visible = False
			Me.lblRemarksApproval.Visible = True
			Me.lblRemarksApproval1.Visible = True
			Me.txtRemarks.Visible = False
			Me.txtRemarksApproval.Visible = True
		End Sub

		' Token: 0x0600122F RID: 4655 RVA: 0x000A6584 File Offset: 0x000A4784
		Private Function Validate_Add_PR() As Boolean
			Dim flag As Boolean = Operators.CompareString(Me.cmbDept.Text, "", False) = 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Select Department to Add a PR.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.cmbDept.Focus()
				flag2 = False
			Else
				Dim flag3 As Boolean = Me.cmbVendor.SelectedIndex = -1
				If flag3 Then
					CustomMsgBox.Show("Select Vendor to Add a PR.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.theme_tc.SelectedTab = Me.tpVendor
					Me.cmbVendor.Focus()
					flag2 = False
				Else
					flag2 = True
				End If
			End If
			Return flag2
		End Function

		' Token: 0x06001230 RID: 4656 RVA: 0x000A6620 File Offset: 0x000A4820
		Private Sub llbAddPR_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Try
				Dim flag As Boolean = Not Me.Validate_Add_PR()
				If Not flag Then
					Me.AddPR()
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06001231 RID: 4657 RVA: 0x000A6688 File Offset: 0x000A4888
		Private Sub AddPR()
			Dim flag As Boolean = (Me.dtPR.Rows.Count = 0) And (Me.dtItems.Rows.Count > 0)
			If flag Then
				Me.dtItems.Rows.Clear()
			End If
			Dim addPR As AddPR01 = New AddPR01(Me.cmbVendor.SelectedValue.ToString(), Me.cmbDept.Text)
			addPR.dtPR = Me.dtPR
			Dim flag2 As Boolean = addPR.ShowDialog() = DialogResult.OK
			If flag2 Then
				Me.dtPRItems = addPR.dtItems
				Dim num As Integer = Me.dtPRItems.Rows.Count - 1
				For i As Integer = 0 To num
					Dim flag3 As Boolean = Operators.CompareString(Me.dtPRItems.Rows(i)("chk").ToString(), "True", False) = 0
					If flag3 Then
						Me.dtPR.Rows.Add(New Object(-1) {})
						Me.dtPR.Rows(Me.dtPR.Rows.Count - 1)("PRID") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("PRID"))
						Me.dtPR.Rows(Me.dtPR.Rows.Count - 1)("PRNo") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("PRNo"))
						Me.dtPR.Rows(Me.dtPR.Rows.Count - 1)("PRDt") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("PRDt"))
						Me.dtPR.Rows(Me.dtPR.Rows.Count - 1)("RequestedBy") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("RequestedBy"))
						Me.dtPR.Rows(Me.dtPR.Rows.Count - 1)("RequestedByEmailID") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("RequestedByEmailID"))
						Me.dtPR.Rows(Me.dtPR.Rows.Count - 1)("VendorName") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("VendorName"))
						Me.dtPR.Rows(Me.dtPR.Rows.Count - 1)("ProductID") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("ProductID"))
						Me.dtPR.Rows(Me.dtPR.Rows.Count - 1)("ProductType") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("ProductType"))
						Me.dtPR.Rows(Me.dtPR.Rows.Count - 1)("ProductCode") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("ProductCode"))
						Me.dtPR.Rows(Me.dtPR.Rows.Count - 1)("ProductName") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("ProductName"))
						Me.dtPR.Rows(Me.dtPR.Rows.Count - 1)("CatalogNo") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("CatalogNo"))
						Me.dtPR.Rows(Me.dtPR.Rows.Count - 1)("Description") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("Description"))
						Me.dtPR.Rows(Me.dtPR.Rows.Count - 1)("Quantity") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("Quantity"))
						Dim text As String = ""
						text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" ProductID = '", Me.dtPRItems.Rows(i)("ProductID")), "' ")))
						Dim text2 As String = Me.dtPRItems.Rows(i)("ProductType").ToString()
						If Operators.CompareString(text2, "Service", False) = 0 Then
							text = text + " AND Description = '" + Me.dtPRItems.Rows(i)("Description").ToString() + "' "
						End If
						Dim flag4 As Boolean = Me.dtItems.[Select](text).Length > 0
						If flag4 Then
							Dim dataRow As DataRow = Me.dtItems.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("ProductID = '", Me.dtPRItems.Rows(i)("ProductID")), "'")))(0)
							Dim num2 As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("Transportation")))
							Dim num3 As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("Freight")))
							Dim num4 As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("LoadingUnloading")))
							Dim num5 As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("Packing")))
							Dim num6 As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("OtherCharges")))
							Dim num7 As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("UnitPrice")))

								Dim num8 As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("Quantity"))) + Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("Quantity")))
								Dim num9 As Double = num7 * num8
								Dim num10 As Double = num9
								Dim flag5 As Boolean = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("DiscountPer"))) > 0.0
								Dim num12 As Double
								If flag5 Then
									Dim num11 As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("DiscountPer")))
									num12 = num9 * num11 / 100.0
									num10 = num9 - num12
								Else
									num12 = 0.0
								End If
								Dim flag6 As Boolean = Operators.ConditionalCompareObjectNotEqual(dataRow("TaxPer"), "", False)
								Dim num13 As Double
								If flag6 Then
									num13 = num10 * Conversion.Val(Strings.Replace(Conversions.ToString(dataRow("TaxPer")), " %", "", 1, -1, CompareMethod.Binary)) / 100.0
								Else
									num13 = 0.0
								End If
								Dim num14 As Double = num10 + num13 + num2 + num3 + num4 + num5 + num6
								dataRow("Quantity") = Strings.Format(num8, "#00")
								dataRow("BasicValue") = Strings.Format(num9, "#00.00")
								dataRow("DiscountAmt") = Strings.Format(num12, "#0.00")
								dataRow("NetAmt") = Strings.Format(num10, "#0.00")
								dataRow("TaxAmt") = Strings.Format(num13, "#0.00")
								dataRow("Transportation") = Strings.Format(num2, "#0.00")
								dataRow("Freight") = Strings.Format(num3, "#0.00")
								dataRow("LoadingUnloading") = Strings.Format(num4, "#0.00")
								dataRow("Packing") = Strings.Format(num5, "#0.00")
								dataRow("OtherCharges") = Strings.Format(num6, "#0.00")
								dataRow("FinalAmt") = Strings.Format(num14, "#0.00")

						Else
							Dim dataRow As DataRow = Me.dtItems.NewRow()
							dataRow("SrNo") = Me.dtItems.Rows.Count + 1
							dataRow("ProductID") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("ProductID"))
							dataRow("ProductType") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("ProductType"))
							dataRow("ProductName") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("ProductName"))
							dataRow("CatalogNo") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("CatalogNo"))
							dataRow("Description") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("Description"))
							dataRow("HSNSACCode") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("HSNSACCode"))
							dataRow("UnitPrice") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("UnitPrice"))
							dataRow("Quantity") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("Quantity"))
							dataRow("TertiaryUOM") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("TertiaryUOM"))
							dataRow("TertiaryPackSize") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("TertiaryPackSize"))
							dataRow("PrimaryUOM") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("PrimaryUOM"))
							dataRow("PrimaryPackSize") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("PrimaryPackSize"))
							dataRow("Measurement") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("Measurement"))
							dataRow("BasicValue") = Strings.Format(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("BasicValue"))), "#0.00")
							dataRow("DiscountPer") = "0"
							dataRow("DiscountAmt") = "0.00"
							dataRow("NetAmt") = Strings.Format(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("NetAmt"))), "#0.00")
							dataRow("TaxPer") = RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("TaxPer"))
							dataRow("TaxAmt") = Strings.Format(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("TaxAmt"))), "#0.00")
							dataRow("Transportation") = "0"
							dataRow("Freight") = "0"
							dataRow("LoadingUnloading") = "0"
							dataRow("Packing") = "0"
							dataRow("OtherCharges") = Strings.Format(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("OtherCharges"))), "#0.00")
							dataRow("FinalAmt") = Strings.Format(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtPRItems.Rows(i)("FinalAmt"))), "#0.00")
							Me.dtItems.Rows.Add(dataRow)
						End If
						Me.dtItems.AcceptChanges()
					End If
				Next
				Me.dgvPR.DataSource = Me.dtPR
				Me.dgvDtls.DataSource = Me.dtItems
				Me.CalculateTotalAmt()
			End If
		End Sub

		' Token: 0x06001232 RID: 4658 RVA: 0x000A746D File Offset: 0x000A566D
		Private Sub AddPR01()
		End Sub

		' Token: 0x06001233 RID: 4659 RVA: 0x000A7470 File Offset: 0x000A5670
		Private Sub AddPR1()
		End Sub

		' Token: 0x06001234 RID: 4660 RVA: 0x000A7474 File Offset: 0x000A5674
		Private Sub dgvPR_CellClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = e.RowIndex > -1
			If flag Then
				Dim name As String = Me.dgvPR.Columns(e.ColumnIndex).Name
				If Operators.CompareString(name, "imgFill", False) <> 0 Then
					If Operators.CompareString(name, "btnDelete_Item", False) = 0 Then
						Dim text As String = "Delete PR Item..?"
						Dim flag2 As Boolean = CustomMsgBox.Show(text, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes
						If flag2 Then
							Dim text2 As String = Conversions.ToString(Me.dgvPR.Rows(e.RowIndex).Cells("PRID").Value)
							Dim text3 As String = Conversions.ToString(Me.dgvPR.Rows(e.RowIndex).Cells("prProductID").Value)
							Dim text4 As String = Conversions.ToString(Me.dgvPR.Rows(e.RowIndex).Cells("prDescription").Value)
							Dim text5 As String = ""
							text5 = String.Concat(New String() { text5, "PRID = '", text2, "' AND ProductID = '", text3, "'" })
							Dim flag3 As Boolean = Operators.ConditionalCompareObjectEqual(Me.dgvPR.Rows(e.RowIndex).Cells("prProductType").Value, "Service", False)
							If flag3 Then
								text5 = text5 + " AND Description = '" + text4 + "'"
							End If
							Dim array As DataRow() = Me.dtPR.[Select](text5)
							Dim num As Integer = array.Length - 1
							For i As Integer = 0 To num
								Dim text6 As String = ""
								text6 = text6 + "ProductID = '" + array(i)("ProductID").ToString() + "'"
								Dim flag4 As Boolean = Operators.ConditionalCompareObjectEqual(Me.dgvPR.Rows(e.RowIndex).Cells("prProductType").Value, "Service", False)
								If flag4 Then
									text6 = text6 + " AND Description = '" + array(i)("Description").ToString() + "'"
								End If
								Dim dataRow As DataRow = Me.dtItems.[Select](text6)(0)
								Dim flag5 As Boolean = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("Quantity"))) - Conversion.Val(RuntimeHelpers.GetObjectValue(array(i)("Quantity"))) = 0.0
								If flag5 Then
									Me.dtItems.Rows.Remove(dataRow)
									Dim num2 As Integer = Me.dtItems.Rows.Count - 1
									For j As Integer = 0 To num2
										Me.dtItems.Rows(0)("SrNo") = j + 1
									Next
								Else
									Dim num3 As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("Transportation")))
									Dim num4 As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("Freight")))
									Dim num5 As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("LoadingUnloading")))
									Dim num6 As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("Packing")))
									Dim num7 As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("OtherCharges")))
									Dim num8 As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("UnitPrice")))

										Dim num9 As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("Quantity"))) - Conversion.Val(RuntimeHelpers.GetObjectValue(array(i)("Quantity")))
										Dim num10 As Double = num8 * num9
										Dim num11 As Double = num10
										Dim flag6 As Boolean = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("DiscountPer"))) > 0.0
										Dim num13 As Double
										If flag6 Then
											Dim num12 As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("DiscountPer")))
											num13 = num10 * num12 / 100.0
											num11 = num10 - num13
										Else
											num13 = 0.0
										End If
										Dim flag7 As Boolean = Operators.ConditionalCompareObjectNotEqual(dataRow("TaxPer"), "", False)
										Dim num14 As Double
										If flag7 Then
											num14 = num11 * Conversion.Val(Strings.Replace(Conversions.ToString(dataRow("TaxPer")), " %", "", 1, -1, CompareMethod.Binary)) / 100.0
										Else
											num14 = 0.0
										End If
										Dim num15 As Double = num11 + num14 + num3 + num4 + num5 + num6 + num7
										dataRow("Quantity") = Strings.Format(num9, "#00")
										dataRow("BasicValue") = Strings.Format(num10, "#00.00")
										dataRow("DiscountAmt") = Strings.Format(num13, "#0.00")
										dataRow("NetAmt") = Strings.Format(num11, "#0.00")
										dataRow("TaxAmt") = Strings.Format(num14, "#0.00")
										dataRow("Transportation") = Strings.Format(num3, "#0.00")
										dataRow("Freight") = Strings.Format(num4, "#0.00")
										dataRow("LoadingUnloading") = Strings.Format(num5, "#0.00")
										dataRow("Packing") = Strings.Format(num6, "#0.00")
										dataRow("OtherCharges") = Strings.Format(num7, "#0.00")
										dataRow("FinalAmt") = Strings.Format(num15, "#0.00")

								End If
								Me.dtPR.Rows.Remove(array(i))
							Next
							Me.dtItems.AcceptChanges()
							Me.dtPR.AcceptChanges()
							Me.dgvDtls.DataSource = Me.dtItems
							Me.dgvPR.DataSource = Me.dtPR
							Me.CalculateTotalAmt()
						End If
					End If
				Else
					Me.SetGridFill(e.RowIndex)
					Me.SetPRItems(Conversions.ToString(Me.dgvPR.Rows(e.RowIndex).Cells("PRID").Value))
				End If
			End If
		End Sub

		' Token: 0x06001235 RID: 4661 RVA: 0x000A7B34 File Offset: 0x000A5D34
		Private Sub SetGridFill(iRow As Integer)
			Dim dataTable As DataTable = CType(Me.dgvPR.DataSource, DataTable)
			Dim num As Integer = dataTable.Rows.Count - 1
			For i As Integer = 0 To num
				Dim flag As Boolean = i = iRow
				If flag Then
					dataTable.Rows(i)("imgFill") = MainModule.ImageToBytes(ResourceModule.imgRightArrow)
				Else
					dataTable.Rows(i)("imgFill") = MainModule.ImageToBytes(ResourceModule.imgBlank)
				End If
			Next
			Me.dgvPR.DataSource = dataTable
		End Sub

		' Token: 0x06001236 RID: 4662 RVA: 0x000A7BCC File Offset: 0x000A5DCC
		Private Sub ConfigureSendMail(sType As String, sID As String, sTrn As String)
			Dim flag As Boolean = Me.cmbReportingTo.SelectedIndex > -1
			If flag Then
				Dim array As DataRow() = Me.dtReportingTo.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UserID = '", Me.cmbReportingTo.SelectedValue), "'")))
				Dim ptr As __ByRef(Of String) = Me.sEmailTo
				Me.sEmailTo = ptr + ":" + array(0)("EmailID").ToString()
				EmailModule.SendMail(sType, sID, sTrn, Me.sEmailTo)
			End If
		End Sub

		' Token: 0x040007B0 RID: 1968
		Private sFormType As String

		' Token: 0x040007B1 RID: 1969
		Private sEmailTo As String

		' Token: 0x040007B2 RID: 1970
		Private drData As DataRow

		' Token: 0x040007B3 RID: 1971
		Private dtItems As DataTable

		' Token: 0x040007B4 RID: 1972
		Private dtFile As DataTable

		' Token: 0x040007B5 RID: 1973
		Private dtPR As DataTable

		' Token: 0x040007B6 RID: 1974
		Private dtPRItems As DataTable

		' Token: 0x040007B7 RID: 1975
		Private dtReportingTo As DataTable
	End Class
End Namespace
