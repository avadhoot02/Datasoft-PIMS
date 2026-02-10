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
	' Token: 0x02000060 RID: 96
	<DesignerGenerated()>
	Public Partial Class GRN
		Inherits DockContent

		' Token: 0x1700082B RID: 2091
		' (get) Token: 0x06001566 RID: 5478 RVA: 0x000C8BF0 File Offset: 0x000C6DF0
		' (set) Token: 0x06001567 RID: 5479 RVA: 0x000C8BFA File Offset: 0x000C6DFA
		Friend Overridable Property bReceivedQty As DataGridViewTextBoxColumn

		' Token: 0x1700082C RID: 2092
		' (get) Token: 0x06001568 RID: 5480 RVA: 0x000C8C03 File Offset: 0x000C6E03
		' (set) Token: 0x06001569 RID: 5481 RVA: 0x000C8C0D File Offset: 0x000C6E0D
		Friend Overridable Property bMfgDt As DataGridViewTextBoxColumn

		' Token: 0x1700082D RID: 2093
		' (get) Token: 0x0600156A RID: 5482 RVA: 0x000C8C16 File Offset: 0x000C6E16
		' (set) Token: 0x0600156B RID: 5483 RVA: 0x000C8C20 File Offset: 0x000C6E20
		Friend Overridable Property bExpiryDt As DataGridViewTextBoxColumn

		' Token: 0x1700082E RID: 2094
		' (get) Token: 0x0600156C RID: 5484 RVA: 0x000C8C29 File Offset: 0x000C6E29
		' (set) Token: 0x0600156D RID: 5485 RVA: 0x000C8C33 File Offset: 0x000C6E33
		Friend Overridable Property bBatchNo As DataGridViewTextBoxColumn

		' Token: 0x1700082F RID: 2095
		' (get) Token: 0x0600156E RID: 5486 RVA: 0x000C8C3C File Offset: 0x000C6E3C
		' (set) Token: 0x0600156F RID: 5487 RVA: 0x000C8C46 File Offset: 0x000C6E46
		Friend Overridable Property bHSNSACCode As DataGridViewTextBoxColumn

		' Token: 0x17000830 RID: 2096
		' (get) Token: 0x06001570 RID: 5488 RVA: 0x000C8C4F File Offset: 0x000C6E4F
		' (set) Token: 0x06001571 RID: 5489 RVA: 0x000C8C59 File Offset: 0x000C6E59
		Friend Overridable Property bDescription As DataGridViewTextBoxColumn

		' Token: 0x17000831 RID: 2097
		' (get) Token: 0x06001572 RID: 5490 RVA: 0x000C8C62 File Offset: 0x000C6E62
		' (set) Token: 0x06001573 RID: 5491 RVA: 0x000C8C6C File Offset: 0x000C6E6C
		Friend Overridable Property bProduct As DataGridViewTextBoxColumn

		' Token: 0x17000832 RID: 2098
		' (get) Token: 0x06001574 RID: 5492 RVA: 0x000C8C75 File Offset: 0x000C6E75
		' (set) Token: 0x06001575 RID: 5493 RVA: 0x000C8C7F File Offset: 0x000C6E7F
		Friend Overridable Property bUID As DataGridViewTextBoxColumn

		' Token: 0x17000833 RID: 2099
		' (get) Token: 0x06001576 RID: 5494 RVA: 0x000C8C88 File Offset: 0x000C6E88
		' (set) Token: 0x06001577 RID: 5495 RVA: 0x000C8C92 File Offset: 0x000C6E92
		Friend Overridable Property dgvBarcode As DataGridView

		' Token: 0x17000834 RID: 2100
		' (get) Token: 0x06001578 RID: 5496 RVA: 0x000C8C9B File Offset: 0x000C6E9B
		' (set) Token: 0x06001579 RID: 5497 RVA: 0x000C8CA5 File Offset: 0x000C6EA5
		Friend Overridable Property bPOQty As DataGridViewTextBoxColumn

		' Token: 0x17000835 RID: 2101
		' (get) Token: 0x0600157A RID: 5498 RVA: 0x000C8CAE File Offset: 0x000C6EAE
		' (set) Token: 0x0600157B RID: 5499 RVA: 0x000C8CB8 File Offset: 0x000C6EB8
		Friend Overridable Property bLandingCost As DataGridViewTextBoxColumn

		' Token: 0x17000836 RID: 2102
		' (get) Token: 0x0600157C RID: 5500 RVA: 0x000C8CC1 File Offset: 0x000C6EC1
		' (set) Token: 0x0600157D RID: 5501 RVA: 0x000C8CCB File Offset: 0x000C6ECB
		Friend Overridable Property bUOM As DataGridViewTextBoxColumn

		' Token: 0x17000837 RID: 2103
		' (get) Token: 0x0600157E RID: 5502 RVA: 0x000C8CD4 File Offset: 0x000C6ED4
		' (set) Token: 0x0600157F RID: 5503 RVA: 0x000C8CDE File Offset: 0x000C6EDE
		Friend Overridable Property bUnitRate As DataGridViewTextBoxColumn

		' Token: 0x17000838 RID: 2104
		' (get) Token: 0x06001580 RID: 5504 RVA: 0x000C8CE7 File Offset: 0x000C6EE7
		' (set) Token: 0x06001581 RID: 5505 RVA: 0x000C8CF1 File Offset: 0x000C6EF1
		Friend Overridable Property bBasicValue As DataGridViewTextBoxColumn

		' Token: 0x17000839 RID: 2105
		' (get) Token: 0x06001582 RID: 5506 RVA: 0x000C8CFA File Offset: 0x000C6EFA
		' (set) Token: 0x06001583 RID: 5507 RVA: 0x000C8D04 File Offset: 0x000C6F04
		Friend Overridable Property tpBarcodes As TabPage

		' Token: 0x1700083A RID: 2106
		' (get) Token: 0x06001584 RID: 5508 RVA: 0x000C8D0D File Offset: 0x000C6F0D
		' (set) Token: 0x06001585 RID: 5509 RVA: 0x000C8D17 File Offset: 0x000C6F17
		Friend Overridable Property tab_lbl4 As Label

		' Token: 0x1700083B RID: 2107
		' (get) Token: 0x06001586 RID: 5510 RVA: 0x000C8D20 File Offset: 0x000C6F20
		' (set) Token: 0x06001587 RID: 5511 RVA: 0x000C8D2C File Offset: 0x000C6F2C
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

		' Token: 0x1700083C RID: 2108
		' (get) Token: 0x06001588 RID: 5512 RVA: 0x000C8D6F File Offset: 0x000C6F6F
		' (set) Token: 0x06001589 RID: 5513 RVA: 0x000C8D79 File Offset: 0x000C6F79
		Friend Overridable Property tab_lbl2 As Label

		' Token: 0x1700083D RID: 2109
		' (get) Token: 0x0600158A RID: 5514 RVA: 0x000C8D82 File Offset: 0x000C6F82
		' (set) Token: 0x0600158B RID: 5515 RVA: 0x000C8D8C File Offset: 0x000C6F8C
		Friend Overridable Property txtPOID As TextBox

		' Token: 0x1700083E RID: 2110
		' (get) Token: 0x0600158C RID: 5516 RVA: 0x000C8D95 File Offset: 0x000C6F95
		' (set) Token: 0x0600158D RID: 5517 RVA: 0x000C8D9F File Offset: 0x000C6F9F
		Friend Overridable Property txtID As TextBox

		' Token: 0x1700083F RID: 2111
		' (get) Token: 0x0600158E RID: 5518 RVA: 0x000C8DA8 File Offset: 0x000C6FA8
		' (set) Token: 0x0600158F RID: 5519 RVA: 0x000C8DB2 File Offset: 0x000C6FB2
		Friend Overridable Property dtpChallanDt As DateTimePicker

		' Token: 0x17000840 RID: 2112
		' (get) Token: 0x06001590 RID: 5520 RVA: 0x000C8DBB File Offset: 0x000C6FBB
		' (set) Token: 0x06001591 RID: 5521 RVA: 0x000C8DC5 File Offset: 0x000C6FC5
		Friend Overridable Property txtPONo As TextBox

		' Token: 0x17000841 RID: 2113
		' (get) Token: 0x06001592 RID: 5522 RVA: 0x000C8DCE File Offset: 0x000C6FCE
		' (set) Token: 0x06001593 RID: 5523 RVA: 0x000C8DD8 File Offset: 0x000C6FD8
		Friend Overridable Property Label5 As Label

		' Token: 0x17000842 RID: 2114
		' (get) Token: 0x06001594 RID: 5524 RVA: 0x000C8DE1 File Offset: 0x000C6FE1
		' (set) Token: 0x06001595 RID: 5525 RVA: 0x000C8DEB File Offset: 0x000C6FEB
		Friend Overridable Property Label27 As Label

		' Token: 0x17000843 RID: 2115
		' (get) Token: 0x06001596 RID: 5526 RVA: 0x000C8DF4 File Offset: 0x000C6FF4
		' (set) Token: 0x06001597 RID: 5527 RVA: 0x000C8DFE File Offset: 0x000C6FFE
		Friend Overridable Property Label6 As Label

		' Token: 0x17000844 RID: 2116
		' (get) Token: 0x06001598 RID: 5528 RVA: 0x000C8E07 File Offset: 0x000C7007
		' (set) Token: 0x06001599 RID: 5529 RVA: 0x000C8E11 File Offset: 0x000C7011
		Friend Overridable Property Label28 As Label

		' Token: 0x17000845 RID: 2117
		' (get) Token: 0x0600159A RID: 5530 RVA: 0x000C8E1A File Offset: 0x000C701A
		' (set) Token: 0x0600159B RID: 5531 RVA: 0x000C8E24 File Offset: 0x000C7024
		Friend Overridable Property txtChallanNo As TextBox

		' Token: 0x17000846 RID: 2118
		' (get) Token: 0x0600159C RID: 5532 RVA: 0x000C8E2D File Offset: 0x000C702D
		' (set) Token: 0x0600159D RID: 5533 RVA: 0x000C8E37 File Offset: 0x000C7037
		Friend Overridable Property dtpPODt As DateTimePicker

		' Token: 0x17000847 RID: 2119
		' (get) Token: 0x0600159E RID: 5534 RVA: 0x000C8E40 File Offset: 0x000C7040
		' (set) Token: 0x0600159F RID: 5535 RVA: 0x000C8E4A File Offset: 0x000C704A
		Friend Overridable Property dtpInvoiceDt As DateTimePicker

		' Token: 0x17000848 RID: 2120
		' (get) Token: 0x060015A0 RID: 5536 RVA: 0x000C8E53 File Offset: 0x000C7053
		' (set) Token: 0x060015A1 RID: 5537 RVA: 0x000C8E5D File Offset: 0x000C705D
		Friend Overridable Property Label3 As Label

		' Token: 0x17000849 RID: 2121
		' (get) Token: 0x060015A2 RID: 5538 RVA: 0x000C8E66 File Offset: 0x000C7066
		' (set) Token: 0x060015A3 RID: 5539 RVA: 0x000C8E70 File Offset: 0x000C7070
		Friend Overridable Property Label4 As Label

		' Token: 0x1700084A RID: 2122
		' (get) Token: 0x060015A4 RID: 5540 RVA: 0x000C8E79 File Offset: 0x000C7079
		' (set) Token: 0x060015A5 RID: 5541 RVA: 0x000C8E83 File Offset: 0x000C7083
		Friend Overridable Property txtInvoiceNo As TextBox

		' Token: 0x1700084B RID: 2123
		' (get) Token: 0x060015A6 RID: 5542 RVA: 0x000C8E8C File Offset: 0x000C708C
		' (set) Token: 0x060015A7 RID: 5543 RVA: 0x000C8E96 File Offset: 0x000C7096
		Friend Overridable Property pnlPODetails As Panel

		' Token: 0x1700084C RID: 2124
		' (get) Token: 0x060015A8 RID: 5544 RVA: 0x000C8E9F File Offset: 0x000C709F
		' (set) Token: 0x060015A9 RID: 5545 RVA: 0x000C8EA9 File Offset: 0x000C70A9
		Friend Overridable Property cmbPOType As ComboBox

		' Token: 0x1700084D RID: 2125
		' (get) Token: 0x060015AA RID: 5546 RVA: 0x000C8EB2 File Offset: 0x000C70B2
		' (set) Token: 0x060015AB RID: 5547 RVA: 0x000C8EBC File Offset: 0x000C70BC
		Friend Overridable Property Label24 As Label

		' Token: 0x1700084E RID: 2126
		' (get) Token: 0x060015AC RID: 5548 RVA: 0x000C8EC5 File Offset: 0x000C70C5
		' (set) Token: 0x060015AD RID: 5549 RVA: 0x000C8ECF File Offset: 0x000C70CF
		Friend Overridable Property tpPOItems As TabPage

		' Token: 0x1700084F RID: 2127
		' (get) Token: 0x060015AE RID: 5550 RVA: 0x000C8ED8 File Offset: 0x000C70D8
		' (set) Token: 0x060015AF RID: 5551 RVA: 0x000C8EE2 File Offset: 0x000C70E2
		Friend Overridable Property tab_lbl1 As Label

		' Token: 0x17000850 RID: 2128
		' (get) Token: 0x060015B0 RID: 5552 RVA: 0x000C8EEB File Offset: 0x000C70EB
		' (set) Token: 0x060015B1 RID: 5553 RVA: 0x000C8EF5 File Offset: 0x000C70F5
		Friend Overridable Property theme_tcRequest As TabControl

		' Token: 0x17000851 RID: 2129
		' (get) Token: 0x060015B2 RID: 5554 RVA: 0x000C8EFE File Offset: 0x000C70FE
		' (set) Token: 0x060015B3 RID: 5555 RVA: 0x000C8F08 File Offset: 0x000C7108
		Friend Overridable Property tpGRNItems As TabPage

		' Token: 0x17000852 RID: 2130
		' (get) Token: 0x060015B4 RID: 5556 RVA: 0x000C8F11 File Offset: 0x000C7111
		' (set) Token: 0x060015B5 RID: 5557 RVA: 0x000C8F1C File Offset: 0x000C711C
		Friend Overridable Property dgvDtls As DataGridView
			<CompilerGenerated()>
			Get
				Return Me._dgvDtls
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim dataGridViewCellEventHandler As DataGridViewCellEventHandler = AddressOf Me.dgvDtls_CellDoubleClick
				Dim dataGridViewCellEventHandler2 As DataGridViewCellEventHandler = AddressOf Me.dgvDtls_CellContentClick
				Dim dataGridView As DataGridView = Me._dgvDtls
				If dataGridView IsNot Nothing Then
					RemoveHandler dataGridView.CellDoubleClick, dataGridViewCellEventHandler
					RemoveHandler dataGridView.CellContentClick, dataGridViewCellEventHandler2
				End If
				Me._dgvDtls = value
				dataGridView = Me._dgvDtls
				If dataGridView IsNot Nothing Then
					AddHandler dataGridView.CellDoubleClick, dataGridViewCellEventHandler
					AddHandler dataGridView.CellContentClick, dataGridViewCellEventHandler2
				End If
			End Set
		End Property

		' Token: 0x17000853 RID: 2131
		' (get) Token: 0x060015B6 RID: 5558 RVA: 0x000C8F7A File Offset: 0x000C717A
		' (set) Token: 0x060015B7 RID: 5559 RVA: 0x000C8F84 File Offset: 0x000C7184
		Friend Overridable Property Panel1 As Panel

		' Token: 0x17000854 RID: 2132
		' (get) Token: 0x060015B8 RID: 5560 RVA: 0x000C8F8D File Offset: 0x000C718D
		' (set) Token: 0x060015B9 RID: 5561 RVA: 0x000C8F98 File Offset: 0x000C7198
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

		' Token: 0x17000855 RID: 2133
		' (get) Token: 0x060015BA RID: 5562 RVA: 0x000C8FDB File Offset: 0x000C71DB
		' (set) Token: 0x060015BB RID: 5563 RVA: 0x000C8FE8 File Offset: 0x000C71E8
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

		' Token: 0x17000856 RID: 2134
		' (get) Token: 0x060015BC RID: 5564 RVA: 0x000C902B File Offset: 0x000C722B
		' (set) Token: 0x060015BD RID: 5565 RVA: 0x000C9038 File Offset: 0x000C7238
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

		' Token: 0x17000857 RID: 2135
		' (get) Token: 0x060015BE RID: 5566 RVA: 0x000C907B File Offset: 0x000C727B
		' (set) Token: 0x060015BF RID: 5567 RVA: 0x000C9085 File Offset: 0x000C7285
		Friend Overridable Property grpItem As GroupBox

		' Token: 0x17000858 RID: 2136
		' (get) Token: 0x060015C0 RID: 5568 RVA: 0x000C908E File Offset: 0x000C728E
		' (set) Token: 0x060015C1 RID: 5569 RVA: 0x000C9098 File Offset: 0x000C7298
		Friend Overridable Property grpGRN As GroupBox

		' Token: 0x17000859 RID: 2137
		' (get) Token: 0x060015C2 RID: 5570 RVA: 0x000C90A1 File Offset: 0x000C72A1
		' (set) Token: 0x060015C3 RID: 5571 RVA: 0x000C90AB File Offset: 0x000C72AB
		Friend Overridable Property dtpDt As DateTimePicker

		' Token: 0x1700085A RID: 2138
		' (get) Token: 0x060015C4 RID: 5572 RVA: 0x000C90B4 File Offset: 0x000C72B4
		' (set) Token: 0x060015C5 RID: 5573 RVA: 0x000C90BE File Offset: 0x000C72BE
		Friend Overridable Property txtNo As TextBox

		' Token: 0x1700085B RID: 2139
		' (get) Token: 0x060015C6 RID: 5574 RVA: 0x000C90C7 File Offset: 0x000C72C7
		' (set) Token: 0x060015C7 RID: 5575 RVA: 0x000C90D1 File Offset: 0x000C72D1
		Friend Overridable Property Label2 As Label

		' Token: 0x1700085C RID: 2140
		' (get) Token: 0x060015C8 RID: 5576 RVA: 0x000C90DA File Offset: 0x000C72DA
		' (set) Token: 0x060015C9 RID: 5577 RVA: 0x000C90E4 File Offset: 0x000C72E4
		Friend Overridable Property Label1 As Label

		' Token: 0x1700085D RID: 2141
		' (get) Token: 0x060015CA RID: 5578 RVA: 0x000C90ED File Offset: 0x000C72ED
		' (set) Token: 0x060015CB RID: 5579 RVA: 0x000C90F8 File Offset: 0x000C72F8
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

		' Token: 0x1700085E RID: 2142
		' (get) Token: 0x060015CC RID: 5580 RVA: 0x000C913B File Offset: 0x000C733B
		' (set) Token: 0x060015CD RID: 5581 RVA: 0x000C9145 File Offset: 0x000C7345
		Friend Overridable Property Label9 As Label

		' Token: 0x1700085F RID: 2143
		' (get) Token: 0x060015CE RID: 5582 RVA: 0x000C914E File Offset: 0x000C734E
		' (set) Token: 0x060015CF RID: 5583 RVA: 0x000C9158 File Offset: 0x000C7358
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

		' Token: 0x17000860 RID: 2144
		' (get) Token: 0x060015D0 RID: 5584 RVA: 0x000C919B File Offset: 0x000C739B
		' (set) Token: 0x060015D1 RID: 5585 RVA: 0x000C91A8 File Offset: 0x000C73A8
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

		' Token: 0x17000861 RID: 2145
		' (get) Token: 0x060015D2 RID: 5586 RVA: 0x000C91EB File Offset: 0x000C73EB
		' (set) Token: 0x060015D3 RID: 5587 RVA: 0x000C91F5 File Offset: 0x000C73F5
		Friend Overridable Property flpButton As FlowLayoutPanel

		' Token: 0x17000862 RID: 2146
		' (get) Token: 0x060015D4 RID: 5588 RVA: 0x000C91FE File Offset: 0x000C73FE
		' (set) Token: 0x060015D5 RID: 5589 RVA: 0x000C9208 File Offset: 0x000C7408
		Friend Overridable Property skip_lblStatus As Label
			<CompilerGenerated()>
			Get
				Return Me._skip_lblStatus
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Dim eventHandler As EventHandler = AddressOf Me.skip_lblStatus_TextChanged
				Dim label As Label = Me._skip_lblStatus
				If label IsNot Nothing Then
					RemoveHandler label.TextChanged, eventHandler
				End If
				Me._skip_lblStatus = value
				label = Me._skip_lblStatus
				If label IsNot Nothing Then
					AddHandler label.TextChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000863 RID: 2147
		' (get) Token: 0x060015D6 RID: 5590 RVA: 0x000C924B File Offset: 0x000C744B
		' (set) Token: 0x060015D7 RID: 5591 RVA: 0x000C9255 File Offset: 0x000C7455
		Friend Overridable Property tpDoc As TabPage

		' Token: 0x17000864 RID: 2148
		' (get) Token: 0x060015D8 RID: 5592 RVA: 0x000C925E File Offset: 0x000C745E
		' (set) Token: 0x060015D9 RID: 5593 RVA: 0x000C9268 File Offset: 0x000C7468
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

		' Token: 0x17000865 RID: 2149
		' (get) Token: 0x060015DA RID: 5594 RVA: 0x000C92AB File Offset: 0x000C74AB
		' (set) Token: 0x060015DB RID: 5595 RVA: 0x000C92B8 File Offset: 0x000C74B8
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

		' Token: 0x17000866 RID: 2150
		' (get) Token: 0x060015DC RID: 5596 RVA: 0x000C92FB File Offset: 0x000C74FB
		' (set) Token: 0x060015DD RID: 5597 RVA: 0x000C9305 File Offset: 0x000C7505
		Friend Overridable Property FileID As DataGridViewTextBoxColumn

		' Token: 0x17000867 RID: 2151
		' (get) Token: 0x060015DE RID: 5598 RVA: 0x000C930E File Offset: 0x000C750E
		' (set) Token: 0x060015DF RID: 5599 RVA: 0x000C9318 File Offset: 0x000C7518
		Friend Overridable Property btnDownload_File As DataGridViewImageColumn

		' Token: 0x17000868 RID: 2152
		' (get) Token: 0x060015E0 RID: 5600 RVA: 0x000C9321 File Offset: 0x000C7521
		' (set) Token: 0x060015E1 RID: 5601 RVA: 0x000C932B File Offset: 0x000C752B
		Friend Overridable Property FileName As DataGridViewTextBoxColumn

		' Token: 0x17000869 RID: 2153
		' (get) Token: 0x060015E2 RID: 5602 RVA: 0x000C9334 File Offset: 0x000C7534
		' (set) Token: 0x060015E3 RID: 5603 RVA: 0x000C933E File Offset: 0x000C753E
		Friend Overridable Property btnDelete_File As DataGridViewImageColumn

		' Token: 0x1700086A RID: 2154
		' (get) Token: 0x060015E4 RID: 5604 RVA: 0x000C9347 File Offset: 0x000C7547
		' (set) Token: 0x060015E5 RID: 5605 RVA: 0x000C9351 File Offset: 0x000C7551
		Friend Overridable Property Label7 As Label

		' Token: 0x1700086B RID: 2155
		' (get) Token: 0x060015E6 RID: 5606 RVA: 0x000C935A File Offset: 0x000C755A
		' (set) Token: 0x060015E7 RID: 5607 RVA: 0x000C9364 File Offset: 0x000C7564
		Friend Overridable Property tab_lbl3 As Label

		' Token: 0x1700086C RID: 2156
		' (get) Token: 0x060015E8 RID: 5608 RVA: 0x000C936D File Offset: 0x000C756D
		' (set) Token: 0x060015E9 RID: 5609 RVA: 0x000C9377 File Offset: 0x000C7577
		Friend Overridable Property dgvPO As DataGridView

		' Token: 0x1700086D RID: 2157
		' (get) Token: 0x060015EA RID: 5610 RVA: 0x000C9380 File Offset: 0x000C7580
		' (set) Token: 0x060015EB RID: 5611 RVA: 0x000C938C File Offset: 0x000C758C
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

		' Token: 0x1700086E RID: 2158
		' (get) Token: 0x060015EC RID: 5612 RVA: 0x000C93CF File Offset: 0x000C75CF
		' (set) Token: 0x060015ED RID: 5613 RVA: 0x000C93DC File Offset: 0x000C75DC
		Friend Overridable Property llbSaveFile As LinkLabel
			<CompilerGenerated()>
			Get
				Return Me._llbSaveFile
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim linkLabelLinkClickedEventHandler As LinkLabelLinkClickedEventHandler = AddressOf Me.llbSaveFile_LinkClicked
				Dim linkLabel As LinkLabel = Me._llbSaveFile
				If linkLabel IsNot Nothing Then
					RemoveHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
				Me._llbSaveFile = value
				linkLabel = Me._llbSaveFile
				If linkLabel IsNot Nothing Then
					AddHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
			End Set
		End Property

		' Token: 0x1700086F RID: 2159
		' (get) Token: 0x060015EE RID: 5614 RVA: 0x000C941F File Offset: 0x000C761F
		' (set) Token: 0x060015EF RID: 5615 RVA: 0x000C942C File Offset: 0x000C762C
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

		' Token: 0x17000870 RID: 2160
		' (get) Token: 0x060015F0 RID: 5616 RVA: 0x000C946F File Offset: 0x000C766F
		' (set) Token: 0x060015F1 RID: 5617 RVA: 0x000C9479 File Offset: 0x000C7679
		Friend Overridable Property tpRemarks As TabPage

		' Token: 0x17000871 RID: 2161
		' (get) Token: 0x060015F2 RID: 5618 RVA: 0x000C9482 File Offset: 0x000C7682
		' (set) Token: 0x060015F3 RID: 5619 RVA: 0x000C948C File Offset: 0x000C768C
		Friend Overridable Property tab_lbl5 As Label

		' Token: 0x17000872 RID: 2162
		' (get) Token: 0x060015F4 RID: 5620 RVA: 0x000C9495 File Offset: 0x000C7695
		' (set) Token: 0x060015F5 RID: 5621 RVA: 0x000C949F File Offset: 0x000C769F
		Friend Overridable Property lblRemarksApproval1 As Label

		' Token: 0x17000873 RID: 2163
		' (get) Token: 0x060015F6 RID: 5622 RVA: 0x000C94A8 File Offset: 0x000C76A8
		' (set) Token: 0x060015F7 RID: 5623 RVA: 0x000C94B2 File Offset: 0x000C76B2
		Friend Overridable Property lblRemarks1 As Label

		' Token: 0x17000874 RID: 2164
		' (get) Token: 0x060015F8 RID: 5624 RVA: 0x000C94BB File Offset: 0x000C76BB
		' (set) Token: 0x060015F9 RID: 5625 RVA: 0x000C94C5 File Offset: 0x000C76C5
		Friend Overridable Property Panel4 As Panel

		' Token: 0x17000875 RID: 2165
		' (get) Token: 0x060015FA RID: 5626 RVA: 0x000C94CE File Offset: 0x000C76CE
		' (set) Token: 0x060015FB RID: 5627 RVA: 0x000C94D8 File Offset: 0x000C76D8
		Friend Overridable Property txtRemarksApproval As TextBox

		' Token: 0x17000876 RID: 2166
		' (get) Token: 0x060015FC RID: 5628 RVA: 0x000C94E1 File Offset: 0x000C76E1
		' (set) Token: 0x060015FD RID: 5629 RVA: 0x000C94EB File Offset: 0x000C76EB
		Friend Overridable Property txtRemarks As TextBox

		' Token: 0x17000877 RID: 2167
		' (get) Token: 0x060015FE RID: 5630 RVA: 0x000C94F4 File Offset: 0x000C76F4
		' (set) Token: 0x060015FF RID: 5631 RVA: 0x000C9500 File Offset: 0x000C7700
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

		' Token: 0x17000878 RID: 2168
		' (get) Token: 0x06001600 RID: 5632 RVA: 0x000C9543 File Offset: 0x000C7743
		' (set) Token: 0x06001601 RID: 5633 RVA: 0x000C9550 File Offset: 0x000C7750
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

		' Token: 0x17000879 RID: 2169
		' (get) Token: 0x06001602 RID: 5634 RVA: 0x000C9593 File Offset: 0x000C7793
		' (set) Token: 0x06001603 RID: 5635 RVA: 0x000C959D File Offset: 0x000C779D
		Friend Overridable Property Label10 As Label

		' Token: 0x1700087A RID: 2170
		' (get) Token: 0x06001604 RID: 5636 RVA: 0x000C95A6 File Offset: 0x000C77A6
		' (set) Token: 0x06001605 RID: 5637 RVA: 0x000C95B0 File Offset: 0x000C77B0
		Friend Overridable Property skip_lblType As Label

		' Token: 0x1700087B RID: 2171
		' (get) Token: 0x06001606 RID: 5638 RVA: 0x000C95B9 File Offset: 0x000C77B9
		' (set) Token: 0x06001607 RID: 5639 RVA: 0x000C95C3 File Offset: 0x000C77C3
		Friend Overridable Property Label8 As Label

		' Token: 0x1700087C RID: 2172
		' (get) Token: 0x06001608 RID: 5640 RVA: 0x000C95CC File Offset: 0x000C77CC
		' (set) Token: 0x06001609 RID: 5641 RVA: 0x000C95D6 File Offset: 0x000C77D6
		Friend Overridable Property SrNo As DataGridViewTextBoxColumn

		' Token: 0x1700087D RID: 2173
		' (get) Token: 0x0600160A RID: 5642 RVA: 0x000C95DF File Offset: 0x000C77DF
		' (set) Token: 0x0600160B RID: 5643 RVA: 0x000C95E9 File Offset: 0x000C77E9
		Friend Overridable Property ProductID As DataGridViewTextBoxColumn

		' Token: 0x1700087E RID: 2174
		' (get) Token: 0x0600160C RID: 5644 RVA: 0x000C95F2 File Offset: 0x000C77F2
		' (set) Token: 0x0600160D RID: 5645 RVA: 0x000C95FC File Offset: 0x000C77FC
		Friend Overridable Property ProductType As DataGridViewTextBoxColumn

		' Token: 0x1700087F RID: 2175
		' (get) Token: 0x0600160E RID: 5646 RVA: 0x000C9605 File Offset: 0x000C7805
		' (set) Token: 0x0600160F RID: 5647 RVA: 0x000C960F File Offset: 0x000C780F
		Friend Overridable Property ProductName As DataGridViewTextBoxColumn

		' Token: 0x17000880 RID: 2176
		' (get) Token: 0x06001610 RID: 5648 RVA: 0x000C9618 File Offset: 0x000C7818
		' (set) Token: 0x06001611 RID: 5649 RVA: 0x000C9622 File Offset: 0x000C7822
		Friend Overridable Property CatalogNo As DataGridViewTextBoxColumn

		' Token: 0x17000881 RID: 2177
		' (get) Token: 0x06001612 RID: 5650 RVA: 0x000C962B File Offset: 0x000C782B
		' (set) Token: 0x06001613 RID: 5651 RVA: 0x000C9635 File Offset: 0x000C7835
		Friend Overridable Property Description As DataGridViewTextBoxColumn

		' Token: 0x17000882 RID: 2178
		' (get) Token: 0x06001614 RID: 5652 RVA: 0x000C963E File Offset: 0x000C783E
		' (set) Token: 0x06001615 RID: 5653 RVA: 0x000C9648 File Offset: 0x000C7848
		Friend Overridable Property HSNSACCode As DataGridViewTextBoxColumn

		' Token: 0x17000883 RID: 2179
		' (get) Token: 0x06001616 RID: 5654 RVA: 0x000C9651 File Offset: 0x000C7851
		' (set) Token: 0x06001617 RID: 5655 RVA: 0x000C965B File Offset: 0x000C785B
		Friend Overridable Property SpecificationNo As DataGridViewTextBoxColumn

		' Token: 0x17000884 RID: 2180
		' (get) Token: 0x06001618 RID: 5656 RVA: 0x000C9664 File Offset: 0x000C7864
		' (set) Token: 0x06001619 RID: 5657 RVA: 0x000C966E File Offset: 0x000C786E
		Friend Overridable Property TertiaryUOM As DataGridViewTextBoxColumn

		' Token: 0x17000885 RID: 2181
		' (get) Token: 0x0600161A RID: 5658 RVA: 0x000C9677 File Offset: 0x000C7877
		' (set) Token: 0x0600161B RID: 5659 RVA: 0x000C9681 File Offset: 0x000C7881
		Friend Overridable Property TertiaryPackSize As DataGridViewTextBoxColumn

		' Token: 0x17000886 RID: 2182
		' (get) Token: 0x0600161C RID: 5660 RVA: 0x000C968A File Offset: 0x000C788A
		' (set) Token: 0x0600161D RID: 5661 RVA: 0x000C9694 File Offset: 0x000C7894
		Friend Overridable Property PrimaryUOM As DataGridViewTextBoxColumn

		' Token: 0x17000887 RID: 2183
		' (get) Token: 0x0600161E RID: 5662 RVA: 0x000C969D File Offset: 0x000C789D
		' (set) Token: 0x0600161F RID: 5663 RVA: 0x000C96A7 File Offset: 0x000C78A7
		Friend Overridable Property PrimaryPackSize As DataGridViewTextBoxColumn

		' Token: 0x17000888 RID: 2184
		' (get) Token: 0x06001620 RID: 5664 RVA: 0x000C96B0 File Offset: 0x000C78B0
		' (set) Token: 0x06001621 RID: 5665 RVA: 0x000C96BA File Offset: 0x000C78BA
		Friend Overridable Property Quantity As DataGridViewTextBoxColumn

		' Token: 0x17000889 RID: 2185
		' (get) Token: 0x06001622 RID: 5666 RVA: 0x000C96C3 File Offset: 0x000C78C3
		' (set) Token: 0x06001623 RID: 5667 RVA: 0x000C96CD File Offset: 0x000C78CD
		Friend Overridable Property RecQty As DataGridViewTextBoxColumn

		' Token: 0x1700088A RID: 2186
		' (get) Token: 0x06001624 RID: 5668 RVA: 0x000C96D6 File Offset: 0x000C78D6
		' (set) Token: 0x06001625 RID: 5669 RVA: 0x000C96E0 File Offset: 0x000C78E0
		Friend Overridable Property UnitPrice As DataGridViewTextBoxColumn

		' Token: 0x1700088B RID: 2187
		' (get) Token: 0x06001626 RID: 5670 RVA: 0x000C96E9 File Offset: 0x000C78E9
		' (set) Token: 0x06001627 RID: 5671 RVA: 0x000C96F3 File Offset: 0x000C78F3
		Friend Overridable Property BasicValue As DataGridViewTextBoxColumn

		' Token: 0x1700088C RID: 2188
		' (get) Token: 0x06001628 RID: 5672 RVA: 0x000C96FC File Offset: 0x000C78FC
		' (set) Token: 0x06001629 RID: 5673 RVA: 0x000C9706 File Offset: 0x000C7906
		Friend Overridable Property DiscountPer As DataGridViewTextBoxColumn

		' Token: 0x1700088D RID: 2189
		' (get) Token: 0x0600162A RID: 5674 RVA: 0x000C970F File Offset: 0x000C790F
		' (set) Token: 0x0600162B RID: 5675 RVA: 0x000C9719 File Offset: 0x000C7919
		Friend Overridable Property DiscountAmt As DataGridViewTextBoxColumn

		' Token: 0x1700088E RID: 2190
		' (get) Token: 0x0600162C RID: 5676 RVA: 0x000C9722 File Offset: 0x000C7922
		' (set) Token: 0x0600162D RID: 5677 RVA: 0x000C972C File Offset: 0x000C792C
		Friend Overridable Property NetAmt As DataGridViewTextBoxColumn

		' Token: 0x1700088F RID: 2191
		' (get) Token: 0x0600162E RID: 5678 RVA: 0x000C9735 File Offset: 0x000C7935
		' (set) Token: 0x0600162F RID: 5679 RVA: 0x000C973F File Offset: 0x000C793F
		Friend Overridable Property TaxPer As DataGridViewTextBoxColumn

		' Token: 0x17000890 RID: 2192
		' (get) Token: 0x06001630 RID: 5680 RVA: 0x000C9748 File Offset: 0x000C7948
		' (set) Token: 0x06001631 RID: 5681 RVA: 0x000C9752 File Offset: 0x000C7952
		Friend Overridable Property TaxAmt As DataGridViewTextBoxColumn

		' Token: 0x17000891 RID: 2193
		' (get) Token: 0x06001632 RID: 5682 RVA: 0x000C975B File Offset: 0x000C795B
		' (set) Token: 0x06001633 RID: 5683 RVA: 0x000C9765 File Offset: 0x000C7965
		Friend Overridable Property Transportation As DataGridViewTextBoxColumn

		' Token: 0x17000892 RID: 2194
		' (get) Token: 0x06001634 RID: 5684 RVA: 0x000C976E File Offset: 0x000C796E
		' (set) Token: 0x06001635 RID: 5685 RVA: 0x000C9778 File Offset: 0x000C7978
		Friend Overridable Property Freight As DataGridViewTextBoxColumn

		' Token: 0x17000893 RID: 2195
		' (get) Token: 0x06001636 RID: 5686 RVA: 0x000C9781 File Offset: 0x000C7981
		' (set) Token: 0x06001637 RID: 5687 RVA: 0x000C978B File Offset: 0x000C798B
		Friend Overridable Property LoadingUnloading As DataGridViewTextBoxColumn

		' Token: 0x17000894 RID: 2196
		' (get) Token: 0x06001638 RID: 5688 RVA: 0x000C9794 File Offset: 0x000C7994
		' (set) Token: 0x06001639 RID: 5689 RVA: 0x000C979E File Offset: 0x000C799E
		Friend Overridable Property Packing As DataGridViewTextBoxColumn

		' Token: 0x17000895 RID: 2197
		' (get) Token: 0x0600163A RID: 5690 RVA: 0x000C97A7 File Offset: 0x000C79A7
		' (set) Token: 0x0600163B RID: 5691 RVA: 0x000C97B1 File Offset: 0x000C79B1
		Friend Overridable Property OtherCharges As DataGridViewTextBoxColumn

		' Token: 0x17000896 RID: 2198
		' (get) Token: 0x0600163C RID: 5692 RVA: 0x000C97BA File Offset: 0x000C79BA
		' (set) Token: 0x0600163D RID: 5693 RVA: 0x000C97C4 File Offset: 0x000C79C4
		Friend Overridable Property FinalAmt As DataGridViewTextBoxColumn

		' Token: 0x17000897 RID: 2199
		' (get) Token: 0x0600163E RID: 5694 RVA: 0x000C97CD File Offset: 0x000C79CD
		' (set) Token: 0x0600163F RID: 5695 RVA: 0x000C97D7 File Offset: 0x000C79D7
		Friend Overridable Property gProductID As DataGridViewTextBoxColumn

		' Token: 0x17000898 RID: 2200
		' (get) Token: 0x06001640 RID: 5696 RVA: 0x000C97E0 File Offset: 0x000C79E0
		' (set) Token: 0x06001641 RID: 5697 RVA: 0x000C97EA File Offset: 0x000C79EA
		Friend Overridable Property GRNItemsID As DataGridViewTextBoxColumn

		' Token: 0x17000899 RID: 2201
		' (get) Token: 0x06001642 RID: 5698 RVA: 0x000C97F3 File Offset: 0x000C79F3
		' (set) Token: 0x06001643 RID: 5699 RVA: 0x000C97FD File Offset: 0x000C79FD
		Friend Overridable Property btnDelete_Item As DataGridViewImageColumn

		' Token: 0x1700089A RID: 2202
		' (get) Token: 0x06001644 RID: 5700 RVA: 0x000C9806 File Offset: 0x000C7A06
		' (set) Token: 0x06001645 RID: 5701 RVA: 0x000C9810 File Offset: 0x000C7A10
		Friend Overridable Property gSrNo As DataGridViewTextBoxColumn

		' Token: 0x1700089B RID: 2203
		' (get) Token: 0x06001646 RID: 5702 RVA: 0x000C9819 File Offset: 0x000C7A19
		' (set) Token: 0x06001647 RID: 5703 RVA: 0x000C9823 File Offset: 0x000C7A23
		Friend Overridable Property gProductType As DataGridViewTextBoxColumn

		' Token: 0x1700089C RID: 2204
		' (get) Token: 0x06001648 RID: 5704 RVA: 0x000C982C File Offset: 0x000C7A2C
		' (set) Token: 0x06001649 RID: 5705 RVA: 0x000C9836 File Offset: 0x000C7A36
		Friend Overridable Property gProductName As DataGridViewTextBoxColumn

		' Token: 0x1700089D RID: 2205
		' (get) Token: 0x0600164A RID: 5706 RVA: 0x000C983F File Offset: 0x000C7A3F
		' (set) Token: 0x0600164B RID: 5707 RVA: 0x000C9849 File Offset: 0x000C7A49
		Friend Overridable Property gCatalogNo As DataGridViewTextBoxColumn

		' Token: 0x1700089E RID: 2206
		' (get) Token: 0x0600164C RID: 5708 RVA: 0x000C9852 File Offset: 0x000C7A52
		' (set) Token: 0x0600164D RID: 5709 RVA: 0x000C985C File Offset: 0x000C7A5C
		Friend Overridable Property gDescription As DataGridViewTextBoxColumn

		' Token: 0x1700089F RID: 2207
		' (get) Token: 0x0600164E RID: 5710 RVA: 0x000C9865 File Offset: 0x000C7A65
		' (set) Token: 0x0600164F RID: 5711 RVA: 0x000C986F File Offset: 0x000C7A6F
		Friend Overridable Property gHSNSACCode As DataGridViewTextBoxColumn

		' Token: 0x170008A0 RID: 2208
		' (get) Token: 0x06001650 RID: 5712 RVA: 0x000C9878 File Offset: 0x000C7A78
		' (set) Token: 0x06001651 RID: 5713 RVA: 0x000C9882 File Offset: 0x000C7A82
		Friend Overridable Property gSpecificationNo As DataGridViewTextBoxColumn

		' Token: 0x170008A1 RID: 2209
		' (get) Token: 0x06001652 RID: 5714 RVA: 0x000C988B File Offset: 0x000C7A8B
		' (set) Token: 0x06001653 RID: 5715 RVA: 0x000C9895 File Offset: 0x000C7A95
		Friend Overridable Property BMRNo As DataGridViewTextBoxColumn

		' Token: 0x170008A2 RID: 2210
		' (get) Token: 0x06001654 RID: 5716 RVA: 0x000C989E File Offset: 0x000C7A9E
		' (set) Token: 0x06001655 RID: 5717 RVA: 0x000C98A8 File Offset: 0x000C7AA8
		Friend Overridable Property gBatchNo As DataGridViewTextBoxColumn

		' Token: 0x170008A3 RID: 2211
		' (get) Token: 0x06001656 RID: 5718 RVA: 0x000C98B1 File Offset: 0x000C7AB1
		' (set) Token: 0x06001657 RID: 5719 RVA: 0x000C98BB File Offset: 0x000C7ABB
		Friend Overridable Property gMfgDt As DataGridViewTextBoxColumn

		' Token: 0x170008A4 RID: 2212
		' (get) Token: 0x06001658 RID: 5720 RVA: 0x000C98C4 File Offset: 0x000C7AC4
		' (set) Token: 0x06001659 RID: 5721 RVA: 0x000C98CE File Offset: 0x000C7ACE
		Friend Overridable Property gExpDt As DataGridViewTextBoxColumn

		' Token: 0x170008A5 RID: 2213
		' (get) Token: 0x0600165A RID: 5722 RVA: 0x000C98D7 File Offset: 0x000C7AD7
		' (set) Token: 0x0600165B RID: 5723 RVA: 0x000C98E1 File Offset: 0x000C7AE1
		Friend Overridable Property gTertiaryUOM As DataGridViewTextBoxColumn

		' Token: 0x170008A6 RID: 2214
		' (get) Token: 0x0600165C RID: 5724 RVA: 0x000C98EA File Offset: 0x000C7AEA
		' (set) Token: 0x0600165D RID: 5725 RVA: 0x000C98F4 File Offset: 0x000C7AF4
		Friend Overridable Property gTertiaryPackSize As DataGridViewTextBoxColumn

		' Token: 0x170008A7 RID: 2215
		' (get) Token: 0x0600165E RID: 5726 RVA: 0x000C98FD File Offset: 0x000C7AFD
		' (set) Token: 0x0600165F RID: 5727 RVA: 0x000C9907 File Offset: 0x000C7B07
		Friend Overridable Property gPrimaryUOM As DataGridViewTextBoxColumn

		' Token: 0x170008A8 RID: 2216
		' (get) Token: 0x06001660 RID: 5728 RVA: 0x000C9910 File Offset: 0x000C7B10
		' (set) Token: 0x06001661 RID: 5729 RVA: 0x000C991A File Offset: 0x000C7B1A
		Friend Overridable Property gPrimaryPackSize As DataGridViewTextBoxColumn

		' Token: 0x170008A9 RID: 2217
		' (get) Token: 0x06001662 RID: 5730 RVA: 0x000C9923 File Offset: 0x000C7B23
		' (set) Token: 0x06001663 RID: 5731 RVA: 0x000C992D File Offset: 0x000C7B2D
		Friend Overridable Property gReceivedQty As DataGridViewTextBoxColumn

		' Token: 0x170008AA RID: 2218
		' (get) Token: 0x06001664 RID: 5732 RVA: 0x000C9936 File Offset: 0x000C7B36
		' (set) Token: 0x06001665 RID: 5733 RVA: 0x000C9940 File Offset: 0x000C7B40
		Friend Overridable Property NoOfBarcode As DataGridViewTextBoxColumn

		' Token: 0x170008AB RID: 2219
		' (get) Token: 0x06001666 RID: 5734 RVA: 0x000C9949 File Offset: 0x000C7B49
		' (set) Token: 0x06001667 RID: 5735 RVA: 0x000C9953 File Offset: 0x000C7B53
		Friend Overridable Property gUnitPrice As DataGridViewTextBoxColumn

		' Token: 0x170008AC RID: 2220
		' (get) Token: 0x06001668 RID: 5736 RVA: 0x000C995C File Offset: 0x000C7B5C
		' (set) Token: 0x06001669 RID: 5737 RVA: 0x000C9966 File Offset: 0x000C7B66
		Friend Overridable Property gGSTPer As DataGridViewTextBoxColumn

		' Token: 0x170008AD RID: 2221
		' (get) Token: 0x0600166A RID: 5738 RVA: 0x000C996F File Offset: 0x000C7B6F
		' (set) Token: 0x0600166B RID: 5739 RVA: 0x000C9979 File Offset: 0x000C7B79
		Friend Overridable Property gBasicValue As DataGridViewTextBoxColumn

		' Token: 0x170008AE RID: 2222
		' (get) Token: 0x0600166C RID: 5740 RVA: 0x000C9982 File Offset: 0x000C7B82
		' (set) Token: 0x0600166D RID: 5741 RVA: 0x000C998C File Offset: 0x000C7B8C
		Friend Overridable Property gLandingCost As DataGridViewTextBoxColumn

		' Token: 0x170008AF RID: 2223
		' (get) Token: 0x0600166E RID: 5742 RVA: 0x000C9995 File Offset: 0x000C7B95
		' (set) Token: 0x0600166F RID: 5743 RVA: 0x000C999F File Offset: 0x000C7B9F
		Friend Overridable Property gTotalCost As DataGridViewTextBoxColumn

		' Token: 0x170008B0 RID: 2224
		' (get) Token: 0x06001670 RID: 5744 RVA: 0x000C99A8 File Offset: 0x000C7BA8
		' (set) Token: 0x06001671 RID: 5745 RVA: 0x000C99B2 File Offset: 0x000C7BB2
		Friend Overridable Property gIsQCApplicable As DataGridViewCheckBoxColumn

		' Token: 0x170008B1 RID: 2225
		' (get) Token: 0x06001672 RID: 5746 RVA: 0x000C99BB File Offset: 0x000C7BBB
		' (set) Token: 0x06001673 RID: 5747 RVA: 0x000C99C5 File Offset: 0x000C7BC5
		Friend Overridable Property gIsParentApplicable As DataGridViewCheckBoxColumn

		' Token: 0x170008B2 RID: 2226
		' (get) Token: 0x06001674 RID: 5748 RVA: 0x000C99CE File Offset: 0x000C7BCE
		' (set) Token: 0x06001675 RID: 5749 RVA: 0x000C99D8 File Offset: 0x000C7BD8
		Friend Overridable Property gIsUnitsEditable As DataGridViewCheckBoxColumn

		' Token: 0x170008B3 RID: 2227
		' (get) Token: 0x06001676 RID: 5750 RVA: 0x000C99E1 File Offset: 0x000C7BE1
		' (set) Token: 0x06001677 RID: 5751 RVA: 0x000C99EB File Offset: 0x000C7BEB
		Friend Overridable Property Status As DataGridViewTextBoxColumn

		' Token: 0x170008B4 RID: 2228
		' (get) Token: 0x06001678 RID: 5752 RVA: 0x000C99F4 File Offset: 0x000C7BF4
		' (set) Token: 0x06001679 RID: 5753 RVA: 0x000C99FE File Offset: 0x000C7BFE
		Friend Overridable Property ExpiryType As DataGridViewTextBoxColumn

		' Token: 0x170008B5 RID: 2229
		' (get) Token: 0x0600167A RID: 5754 RVA: 0x000C9A07 File Offset: 0x000C7C07
		' (set) Token: 0x0600167B RID: 5755 RVA: 0x000C9A11 File Offset: 0x000C7C11
		Friend Overridable Property Expiry As DataGridViewTextBoxColumn

		' Token: 0x170008B6 RID: 2230
		' (get) Token: 0x0600167C RID: 5756 RVA: 0x000C9A1A File Offset: 0x000C7C1A
		' (set) Token: 0x0600167D RID: 5757 RVA: 0x000C9A24 File Offset: 0x000C7C24
		Friend Overridable Property CellCount As DataGridViewTextBoxColumn

		' Token: 0x170008B7 RID: 2231
		' (get) Token: 0x0600167E RID: 5758 RVA: 0x000C9A2D File Offset: 0x000C7C2D
		' (set) Token: 0x0600167F RID: 5759 RVA: 0x000C9A37 File Offset: 0x000C7C37
		Friend Overridable Property PassageNo As DataGridViewTextBoxColumn

		' Token: 0x170008B8 RID: 2232
		' (get) Token: 0x06001680 RID: 5760 RVA: 0x000C9A40 File Offset: 0x000C7C40
		' (set) Token: 0x06001681 RID: 5761 RVA: 0x000C9A4A File Offset: 0x000C7C4A
		Friend Overridable Property ODPermL As DataGridViewTextBoxColumn

		' Token: 0x06001682 RID: 5762 RVA: 0x000C9A54 File Offset: 0x000C7C54
		Public Sub New(sForm As String, GRNType As String, dr As DataRow)
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.Load, AddressOf Me.GRN_Load
			AddHandler MyBase.Shown, AddressOf Me.Me_Shown
			Me.InitializeComponent()
			Me.sFormType = sForm
			Me.sGRNType = GRNType
			Me.drData = dr
			Me.Text = Me.sFormType
			MyBase.TabText = Me.sFormType
			Dim text As String = Me.sFormType
			If Operators.CompareString(text, "GRN Entry", False) <> 0 Then
				If Operators.CompareString(text, "GRN Entry - Against PO", False) <> 0 Then
					If Operators.CompareString(text, "GRN Modify", False) <> 0 Then
						If Operators.CompareString(text, "GRN Approval", False) = 0 Then
							Me.Text = "GRN Approval"
							MyBase.TabText = "GRN Approval"
						End If
					Else
						Me.Text = "GRN Modification"
						MyBase.TabText = "GRN Modification"
					End If
				Else
					Me.Text = "GRN Creation"
					MyBase.TabText = "GRN Creation"
				End If
			Else
				Me.Text = "GRN Creation"
				MyBase.TabText = "GRN Creation"
			End If
		End Sub

		' Token: 0x06001683 RID: 5763 RVA: 0x000C9B88 File Offset: 0x000C7D88
		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x06001684 RID: 5764 RVA: 0x000C9BBD File Offset: 0x000C7DBD
		Private Sub GRN_Load(sender As Object, e As EventArgs)
			Designing.SetTheme(Me)
			Me.ClearForm()
			Me.FillCombo()
			Me.FillData()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x06001685 RID: 5765 RVA: 0x000C9BF3 File Offset: 0x000C7DF3
		Private Sub Me_Shown(sender As Object, e As EventArgs)
			Me.SetForm()
		End Sub

		' Token: 0x06001686 RID: 5766 RVA: 0x000C9C00 File Offset: 0x000C7E00
		Private Sub SetForm1()
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = CInt(Math.Round(CDbl((Me.theme_tcRequest.Width - 4)) / 3.0))
			Me.theme_tcRequest.TabPages.Remove(Me.tpBarcodes)
			Dim text As String = Me.sFormType
			If Operators.CompareString(text, "GRN Without PO - Add", False) <> 0 AndAlso Operators.CompareString(text, "GRN Without PO - Modify", False) <> 0 Then
				If Operators.CompareString(text, "GRN With PO - Add", False) <> 0 AndAlso Operators.CompareString(text, "GRN With PO - Modify", False) <> 0 Then
					If Operators.CompareString(text, "GRN Approval", False) = 0 Then
						num = CInt(Math.Round(CDbl((Me.theme_tcRequest.Width - 4)) / 2.0))
						Me.btnSave.Visible = False
						Me.btnClear.Visible = False
					End If
				Else
					num = CInt(Math.Round(CDbl((Me.theme_tcRequest.Width - 4)) / 2.0))
					Me.btnApprove.Visible = False
					Me.btnReject.Visible = False
				End If
			Else
				num = CInt(Math.Round(CDbl((Me.theme_tcRequest.Width - 4)) / 2.0))
				Me.theme_tcRequest.TabPages.Remove(Me.tpPOItems)
				Me.btnApprove.Visible = False
				Me.btnReject.Visible = False
			End If
			Me.theme_tcRequest.ItemSize = New Size(num, 30)
			Dim count As Integer = Me.theme_tcRequest.TabPages.Count
			If count <> 2 Then
				If count <> 3 Then
				End If
			Else
				Me.tab_lbl2.Width = num
				Me.tab_lbl3.Width = num + 4
				Me.tab_lbl2.Location = New Point(0, 0)
				Me.tab_lbl3.Location = New Point(num - 4, 0)
			End If
			Me.flpButton.Width = (Me.btnApprove.Width + 2) * 5 - Me.btnApprove.Width * 2
			Me.flpButton.Left = CInt(Math.Round(CDbl(MyBase.Width) / 2.0 - CDbl(Me.flpButton.Width) / 2.0))
		End Sub

		' Token: 0x06001687 RID: 5767 RVA: 0x000C9E50 File Offset: 0x000C8050
		Private Sub SetForm()
			Me.skip_lblType.Text = Me.sGRNType
			Me.theme_tcRequest.TabPages.Remove(Me.tpBarcodes)
			Dim flag As Boolean = Operators.CompareString(Me.txtPOID.Text, "", False) = 0
			Dim num As Integer
			If flag Then
				Me.theme_tcRequest.TabPages.Remove(Me.tpPOItems)
				num = CInt(Math.Round(CDbl((Me.theme_tcRequest.Width - 4)) / 3.0))
			Else
				num = CInt(Math.Round(CDbl((Me.theme_tcRequest.Width - 5)) / 4.0))
			End If
			Dim text As String = Me.sGRNType
			If Operators.CompareString(text, "Receipt", False) <> 0 Then
				If Operators.CompareString(text, "Return", False) <> 0 Then
					If Operators.CompareString(text, "BMR", False) = 0 Then
						Me.pnlPODetails.Visible = False
						Me.dgvDtls.Columns("BMRNo").Visible = True
						Me.grpGRN.Height = 117
					End If
				Else
					Me.pnlPODetails.Visible = False
					Me.dgvDtls.Columns("BMRNo").Visible = False
					Me.grpGRN.Height = 117
				End If
			Else
				Me.pnlPODetails.Visible = True
				Me.dgvDtls.Columns("BMRNo").Visible = False
			End If
			Dim text2 As String = Me.sFormType
			If Operators.CompareString(text2, "GRN Add", False) <> 0 AndAlso Operators.CompareString(text2, "GRN Modify", False) <> 0 AndAlso Operators.CompareString(text2, "GRN Entry", False) <> 0 AndAlso Operators.CompareString(text2, "GRN Entry - Against PO", False) <> 0 Then
				If Operators.CompareString(text2, "GRN Approval", False) <> 0 Then
					If Operators.CompareString(text2, "GRN Cancellation", False) = 0 Then
						Me.txtRemarks.[ReadOnly] = True
						Me.btnSave.Visible = False
						Me.btnClear.Visible = False
						Me.btnApprove.Visible = False
						Me.btnOnHold.Visible = False
						Me.btnReject.Visible = False
						Me.dgvFile.Columns("btnDelete_File").Visible = False
						Me.flpButton.Width = (Me.btnApprove.Width + 2) * 6 - Me.btnApprove.Width * 4
					End If
				Else
					Me.cmbVendor.Enabled = False
					Me.cmbPOType.Enabled = False
					Me.dtpPODt.Enabled = False
					Me.dtpInvoiceDt.Enabled = False
					Me.dtpChallanDt.Enabled = False
					Me.txtPONo.[ReadOnly] = True
					Me.txtInvoiceNo.[ReadOnly] = True
					Me.txtChallanNo.[ReadOnly] = True
					Me.txtRemarks.[ReadOnly] = True
					Me.llbAdd.Enabled = False
					Me.llbFile.Enabled = False
					Me.btnSave.Visible = False
					Me.btnClear.Visible = False
					Me.btnCancel.Visible = False
					Dim flag2 As Boolean = Operators.CompareString(Me.skip_lblStatus.Text, "GRN In Approval", False) <> 0
					If flag2 Then
						Me.btnApprove.Enabled = False
						Me.btnOnHold.Enabled = False
						Me.btnReject.Enabled = False
					End If
					Me.dgvFile.Columns("btnDelete_File").Visible = False
					Me.flpButton.Width = (Me.btnApprove.Width + 2) * 7 - Me.btnApprove.Width * 3
				End If
			Else
				Me.btnApprove.Visible = False
				Me.btnOnHold.Visible = False
				Me.btnReject.Visible = False
				Dim text3 As String = Me.skip_lblStatus.Text
				If Operators.CompareString(text3, "New GRN", False) <> 0 Then
					If Operators.CompareString(text3, "GRN On-Hold", False) <> 0 AndAlso Operators.CompareString(text3, "GRN In Approval", False) <> 0 Then
						If Operators.CompareString(text3, "GRN Approved", False) <> 0 AndAlso Operators.CompareString(text3, "QC Saved", False) <> 0 AndAlso Operators.CompareString(text3, "QC Complete", False) <> 0 Then
							Me.llbAdd.Enabled = False
							Me.llbFile.Enabled = False
							Me.btnSave.Enabled = False
							Me.btnClear.Enabled = False
							Me.llbFile.Enabled = False
							Me.llbSaveFile.Visible = False
							Me.dgvFile.Columns("btnDelete_File").Visible = False
						Else
							Me.llbAdd.Enabled = False
							Me.llbFile.Enabled = False
							Me.btnSave.Enabled = False
							Me.btnClear.Enabled = False
							Dim gsGRNAttachmentAfterApproval As Boolean = GlobalVariables.gsGRNAttachmentAfterApproval
							If gsGRNAttachmentAfterApproval Then
								Me.llbFile.Enabled = True
								Me.llbSaveFile.Visible = True
								Me.dgvFile.Columns("btnDelete_File").Visible = True
							Else
								Me.llbFile.Enabled = False
								Me.llbSaveFile.Visible = False
								Me.dgvFile.Columns("btnDelete_File").Visible = False
							End If
						End If
					End If
				Else
					Me.btnCancel.Visible = False
				End If
				Dim flag3 As Boolean = Not Me.btnCancel.Visible
				If flag3 Then
					Me.flpButton.Width = (Me.btnApprove.Width + 2) * 7 - Me.btnApprove.Width * 4
				Else
					Me.flpButton.Width = (Me.btnApprove.Width + 2) * 7 - Me.btnApprove.Width * 3
				End If
			End If
			Me.theme_tcRequest.ItemSize = New Size(num, 30)
			Select Case Me.theme_tcRequest.TabPages.Count
				Case 2
					Me.tab_lbl2.Width = num
					Me.tab_lbl3.Width = num + 4
					Me.tab_lbl2.Location = New Point(0, 0)
					Me.tab_lbl3.Location = New Point(num - 4, 0)
				Case 3
					Me.tab_lbl2.Width = num
					Me.tab_lbl3.Width = num + 4
					Me.tab_lbl5.Width = num + 4
					Me.tab_lbl2.Location = New Point(0, 0)
					Me.tab_lbl3.Location = New Point(num - 4, 0)
					Me.tab_lbl5.Location = New Point(num * 2 - 4, 0)
				Case 4
					Me.tab_lbl1.Width = num
					Me.tab_lbl2.Width = num + 4
					Me.tab_lbl3.Width = num + 4
					Me.tab_lbl5.Width = num + 4
					Me.tab_lbl1.Location = New Point(0, 0)
					Me.tab_lbl2.Location = New Point(num - 4, 0)
					Me.tab_lbl3.Location = New Point(num * 2 - 4, 0)
					Me.tab_lbl5.Location = New Point(num * 3 - 4, 0)
			End Select
			Me.sEmailTo = GlobalVariables.gsEmailID
			Dim flag4 As Boolean = Not Information.IsNothing(Me.drData)
			If flag4 Then
				Dim flag5 As Boolean = (Operators.CompareString(Me.drData("CreatedByEmailID").ToString(), "", False) <> 0) And (Operators.CompareString(Me.drData("CreatedByEmailID").ToString(), GlobalVariables.gsEmailID, False) <> 0)
				If flag5 Then
					Dim ptr As __ByRef(Of String) = Me.sEmailTo
					Me.sEmailTo = ptr + ":" + Me.drData("CreatedByEmailID").ToString()
				End If
			End If
			Me.flpButton.Left = CInt(Math.Round(CDbl(MyBase.Width) / 2.0 - CDbl(Me.flpButton.Width) / 2.0))
		End Sub

		' Token: 0x06001688 RID: 5768 RVA: 0x000CA6C4 File Offset: 0x000C88C4
		Private Sub FillCombo()
			Dim text As String = "SELECT VendorID, VendorName FROM Vendor ORDER BY VendorName"
			Dim data As DataTable = MainModule.GetData(text)
			Me.cmbVendor.ValueMember = "VendorID"
			Me.cmbVendor.DisplayMember = "VendorName"
			Me.cmbVendor.DataSource = data
			Dim text2 As String = Me.sGRNType
			If Operators.CompareString(text2, "BMR", False) <> 0 AndAlso Operators.CompareString(text2, "Return", False) <> 0 Then
				Me.cmbVendor.SelectedIndex = -1
			Else
				Me.cmbVendor.SelectedValue = 97
				Me.cmbVendor.Enabled = False
			End If
		End Sub

		' Token: 0x06001689 RID: 5769 RVA: 0x000CA768 File Offset: 0x000C8968
		Private Sub FillData()
			Try
				Dim flag As Boolean = Not Information.IsNothing(Me.drData)
				If flag Then
					Dim flag2 As Boolean = Me.drData.Table.Columns.Contains("GRNID")
					If flag2 Then
						Me.txtID.Text = Conversions.ToString(Me.drData("GRNID"))
						Me.txtPOID.Text = Me.drData("POID").ToString()
						Me.txtNo.Text = Conversions.ToString(Me.drData("GRNNo"))
						Me.dtpDt.Value = Conversions.ToDate(Me.drData("GRNDt"))
						Me.cmbVendor.SelectedValue = RuntimeHelpers.GetObjectValue(Me.drData("VendorID"))
						Me.cmbPOType.Text = Me.drData("POType").ToString()
						Me.txtPONo.Text = Me.drData("PONo").ToString()
						Me.txtInvoiceNo.Text = Me.drData("InvoiceNo").ToString()
						Me.txtChallanNo.Text = Me.drData("ChallanNo").ToString()
						Dim flag3 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.drData("PODt")))
						If flag3 Then
							Me.dtpPODt.Value = Conversions.ToDate(Me.drData("PODt"))
							Me.dtpPODt.Checked = True
						Else
							Me.dtpPODt.Value = DateAndTime.Now
							Me.dtpPODt.Checked = False
						End If
						Dim flag4 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.drData("InvoiceDt")))
						If flag4 Then
							Me.dtpInvoiceDt.Value = Conversions.ToDate(Me.drData("InvoiceDt"))
							Me.dtpInvoiceDt.Checked = True
						Else
							Me.dtpInvoiceDt.Value = DateAndTime.Now
							Me.dtpInvoiceDt.Checked = False
						End If
						Dim flag5 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.drData("ChallanDt")))
						If flag5 Then
							Me.dtpChallanDt.Value = Conversions.ToDate(Me.drData("ChallanDt"))
							Me.dtpChallanDt.Checked = True
						Else
							Me.dtpChallanDt.Value = DateAndTime.Now
							Me.dtpChallanDt.Checked = False
						End If
						Me.txtRemarks.Text = Me.drData("Remarks").ToString()
						Me.txtRemarksApproval.Text = Me.drData("ActionRemarks").ToString()
						Dim text As String = "SELECT Status FROM GRN WHERE GRNID = '" + Me.txtID.Text + "'"
						Dim data As DataTable = MainModule.GetData(text)
						Me.skip_lblStatus.Text = Conversions.ToString(data.Rows(0)("Status"))
					Else
						Me.txtPOID.Text = Conversions.ToString(Me.drData("POID"))
						Me.cmbPOType.Text = Conversions.ToString(Me.drData("POType"))
						Me.txtPONo.Text = Conversions.ToString(Me.drData("PONo"))
						Me.dtpPODt.Value = Conversions.ToDate(Me.drData("PODt"))
						Me.cmbVendor.SelectedValue = RuntimeHelpers.GetObjectValue(Me.drData("VendorID"))
					End If
					Me.FillGRNItems()
					Me.FillPOItems()
					Me.FillGRNBarcodes()
					Dim flag6 As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
					If flag6 Then
						Me.dtFile = FileAttachments.FillFileAttachments("GRN", Me.txtID.Text)
						FileAttachments.SetFileDatagridview(Me.dtFile, Me.dgvFile)
					End If
					Dim flag7 As Boolean = Operators.CompareString(Me.txtRemarksApproval.Text, "", False) = 0
					If flag7 Then
						Me.lblRemarksApproval.Visible = False
					Else
						Me.lblRemarksApproval.Visible = True
					End If
					Dim flag8 As Boolean = Operators.CompareString(Me.txtPOID.Text, "", False) <> 0
					If flag8 Then
						Me.cmbVendor.Enabled = False
						Me.cmbPOType.Enabled = False
						Me.txtPONo.[ReadOnly] = True
						Me.dtpPODt.Enabled = False
					End If
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x0600168A RID: 5770 RVA: 0x000CACB0 File Offset: 0x000C8EB0
		Private Sub FillGRNItems()
			Dim text As String = " SELECT ROW_NUMBER() OVER(ORDER BY GRNItemsID) AS SrNo, GI.GRNItemsID, GI.ProductID, P.ProductType, " & vbCrLf
			text += " P.ProductName, P.CatalogNo, GI.Description, P.HSNSACCode, GI.SpecificationNo, GI.BMRNo, GI.BatchNo, GI.MfgDt, GI.ExpDt, " & vbCrLf
			text += " P.TertiaryUOM, GI.TertiaryPackSize, P.PrimaryUOM, GI.PrimaryPackSize, " & vbCrLf
			text += " GI.ReceivedQty, GI.NoOfBarcode, GI.UnitPrice, GI.GSTPer, GI.BasicValue, GI.LandingCost, GI.TotalCost, " & vbCrLf
			text += " GI.IsQCApplicable, GI.IsParentApplicable, GI.IsUnitsEditable, GI.Status, GI.ExpiryType, GI.Expiry, " & vbCrLf
			text += " GI.CellCount, GI. PassageNo, GI.ODPermL" & vbCrLf
			text += " FROM GRNItems AS GI " & vbCrLf
			text += " INNER JOIN Product AS P ON GI.ProductID = P.ProductID" & vbCrLf
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				text = text + " WHERE GRNID = '" + Me.txtID.Text + "'"
			Else
				text += " WHERE GRNID = '0'"
			End If
			Me.dtItems = MainModule.GetData(text)
			Me.dgvDtls.DataSource = Me.dtItems
		End Sub

		' Token: 0x0600168B RID: 5771 RVA: 0x000CAD80 File Offset: 0x000C8F80
		Private Sub FillPOItems()
			Dim flag As Boolean = Operators.CompareString(Me.txtPOID.Text, "", False) <> 0
			If flag Then
				Dim text As String = " SELECT ROW_NUMBER() OVER(ORDER BY POItemsID) AS SrNo, PIs.ProductID, P.ProductType, " & vbCrLf
				text += " P.ProductName, P.CatalogNo, PIs.Description, P.HSNSACCode, " & vbCrLf
				text += " P.TertiaryUOM, P.TertiaryPackSize, P.PrimaryUOM, P.PrimaryPackSize, " & vbCrLf
				text += " PIs.UnitPrice, PIs.Quantity, ISNULL(PIs.RecQty,0) AS RecQty, " & vbCrLf
				text += " PIs.BasicValue, PIs.DiscountPer, PIs.DiscountAmt, PIs.NetAmt, PIs.TaxPer, PIs.TaxAmt, " & vbCrLf
				text += " PIs.Transportation, PIs.Freight, PIs.LoadingUnloading, PIs.Packing, PIs.OtherCharges, PIs.FinalAmt" & vbCrLf
				text += " FROM POItems AS PIs " & vbCrLf
				text += " INNER JOIN Product AS P ON PIs.ProductID = P.ProductID" & vbCrLf
				text = text + " WHERE POID = '" + Me.txtPOID.Text + "' AND P.IsGRNApplicable = 1 "
				Me.dtPOItems = MainModule.GetData(text)
				Me.dgvPO.DataSource = Me.dtPOItems
			End If
		End Sub

		' Token: 0x0600168C RID: 5772 RVA: 0x000CAE44 File Offset: 0x000C9044
		Private Sub FillGRNBarcodes()
			Dim text As String = " SELECT GU.GRNItemsID, GU.ProductID, GU.UID, GU.ParentUID, P.ProductName, GU.CatalogNo, GU.Description, " & vbCrLf
			text += " GU.BatchNo, GU.PrimaryPackSize, GU.Price, GU.AvgPrice, GU.ExpiryType, GU.Expiry, GU.IsUnitsEditable, GU.IsParentApplicable, GU.Status" & vbCrLf
			text += " FROM GRNUID AS GU" & vbCrLf
			text += " INNER JOIN Product AS P ON GU.ProductID = P.ProductID" & vbCrLf
			Dim flag As Boolean = Operators.CompareString(Me.skip_lblStatus.Text, "GRN In Approval", False) = 0
			If flag Then
				text += " WHERE GRNID = '0'"
			Else
				Dim flag2 As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
				If flag2 Then
					text = text + " WHERE GRNID = '" + Me.txtID.Text + "'"
				Else
					text += " WHERE GRNID = '0'"
				End If
			End If
			Me.dtBarcodes = MainModule.GetData(text)
		End Sub

		' Token: 0x0600168D RID: 5773 RVA: 0x000CAF00 File Offset: 0x000C9100
		Private Sub ClearForm()
			Dim text As String = Me.sGRNType
			If Operators.CompareString(text, "BMR", False) <> 0 AndAlso Operators.CompareString(text, "Return", False) <> 0 Then
				Me.cmbVendor.SelectedIndex = -1
			Else
				Me.cmbVendor.SelectedValue = 97
				Me.cmbVendor.Enabled = False
			End If
			Dim flag As Boolean = Operators.CompareString(Me.txtPOID.Text, "", False) = 0
			If flag Then
				Me.cmbPOType.Text = ""
				Me.txtPONo.Text = ""
				Me.dtpPODt.Value = DateAndTime.Now
				Me.dtpPODt.Checked = False
			End If
			Me.txtInvoiceNo.Text = ""
			Me.dtpInvoiceDt.Value = DateAndTime.Now
			Me.dtpInvoiceDt.Checked = False
			Me.txtChallanNo.Text = ""
			Me.dtpChallanDt.Value = DateAndTime.Now
			Me.dtpChallanDt.Checked = False
			Me.txtRemarks.Text = ""
			Me.txtRemarksApproval.Text = ""
			Me.lblRemarks_Click(Nothing, Nothing)
			Me.FillGRNItems()
			Me.FillGRNBarcodes()
			Me.dtFile = FileAttachments.CreateFileTable()
			FileAttachments.SetFileDatagridview(Me.dtFile, Me.dgvFile)
		End Sub

		' Token: 0x0600168E RID: 5774 RVA: 0x000CB07B File Offset: 0x000C927B
		Private Sub btnClear_Click(sender As Object, e As EventArgs)
			Me.ClearForm()
		End Sub

		' Token: 0x0600168F RID: 5775 RVA: 0x000CB085 File Offset: 0x000C9285
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06001690 RID: 5776 RVA: 0x000CB090 File Offset: 0x000C9290
		Private Sub skip_lblStatus_TextChanged(sender As Object, e As EventArgs)
			Dim text As String = Me.skip_lblStatus.Text
			If Operators.CompareString(text, "GRN Rejected", False) <> 0 AndAlso Operators.CompareString(text, "GRN Cancelled", False) <> 0 Then
				Me.skip_lblStatus.ForeColor = Color.LawnGreen
			Else
				Me.skip_lblStatus.ForeColor = Color.Red
			End If
		End Sub

		' Token: 0x06001691 RID: 5777 RVA: 0x000CB0F4 File Offset: 0x000C92F4
		Private Sub cmbVendor_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbVendor.SelectedIndex = -1
			If flag Then
				Me.cmbVendor.Text = ""
			End If
		End Sub

		' Token: 0x06001692 RID: 5778 RVA: 0x000CB127 File Offset: 0x000C9327
		Private Sub lblFile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Me.dtFile = FileAttachments.AttachmentFile(Conversions.ToString(-1), Me.dtFile)
			FileAttachments.SetFileDatagridview(Me.dtFile, Me.dgvFile)
		End Sub

		' Token: 0x06001693 RID: 5779 RVA: 0x000CB154 File Offset: 0x000C9354
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

		' Token: 0x06001694 RID: 5780 RVA: 0x000CB248 File Offset: 0x000C9448
		Private Sub llbAdd_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Dim grnitems As GRNItems = New GRNItems(-1, Me.sFormType, Me.sGRNType, Conversions.ToString(Conversion.Val(Me.txtID.Text)), Me.txtPOID.Text, Me.dtItems, Me.skip_lblStatus.Text)
			Dim flag As Boolean = grnitems.ShowDialog() = DialogResult.OK
			If flag Then
				Me.dtItems = grnitems.dtItems
				Me.dgvDtls.DataSource = Me.dtItems
			End If
		End Sub

		' Token: 0x06001695 RID: 5781 RVA: 0x000CB2C8 File Offset: 0x000C94C8
		Private Sub dgvDtls_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = (e.RowIndex > -1) And (e.ColumnIndex > -1)
			If flag Then
				Dim grnitems As GRNItems = New GRNItems(e.RowIndex, Me.sFormType, Me.sGRNType, Conversions.ToString(Conversion.Val(Me.txtID.Text)), Me.txtPOID.Text, Me.dtItems, Me.skip_lblStatus.Text)
				Dim flag2 As Boolean = grnitems.ShowDialog() = DialogResult.OK
				If flag2 Then
					Me.dtItems = grnitems.dtItems
					Me.dgvDtls.DataSource = Me.dtItems
					Me.ReorderSrNo()
				End If
			End If
		End Sub

		' Token: 0x06001696 RID: 5782 RVA: 0x000CB36C File Offset: 0x000C956C
		Private Sub dgvDtls_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = e.RowIndex > -1
			If flag Then
				Dim array As DataRow() = Me.dtItems.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SrNo = '", Me.dgvDtls.Rows(e.RowIndex).Cells("gSrNo").Value), "'")))
				Dim flag2 As Boolean = array.Length = 1
				If flag2 Then
					Dim text As String = Me.dgvDtls.Columns(e.ColumnIndex).Name.ToString()
					If Operators.CompareString(text, "btnDelete_Item", False) = 0 Then
						Me.dtItems.Rows.Remove(array(0))
						Me.dtItems.AcceptChanges()
						Me.ReorderSrNo()
					End If
				End If
			End If
		End Sub

		' Token: 0x06001697 RID: 5783 RVA: 0x000CB444 File Offset: 0x000C9644
		Private Sub ReorderSrNo()
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = Me.dtItems.Rows.Count - 1
			For i As Integer = 0 To num
				Me.dtItems.Rows(i)("SrNo") = i + 1
			Next
		End Sub

		' Token: 0x06001698 RID: 5784 RVA: 0x000CB498 File Offset: 0x000C9698
		Private Function ValidateForm() As Boolean
			Dim flag As Boolean = Me.cmbVendor.SelectedIndex = -1
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Select Vendor.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.cmbVendor.Focus()
				flag2 = False
			Else
				Dim flag3 As Boolean = Me.dtItems.Rows.Count = 0
				If flag3 Then
					CustomMsgBox.Show("No Product Added.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.llbAdd.Focus()
					flag2 = False
				Else
					flag2 = True
				End If
			End If
			Return flag2
		End Function

		' Token: 0x06001699 RID: 5785 RVA: 0x000CB51C File Offset: 0x000C971C
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

		' Token: 0x0600169A RID: 5786 RVA: 0x000CB598 File Offset: 0x000C9798
		Private Sub Save()
			Dim flag As Boolean = CustomMsgBox.Show("Save..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
			If flag Then
				Dim flag2 As Boolean = Not Me.ValidateForm()
				If Not flag2 Then
					Me.btnSave.Enabled = False
					Dim flag3 As Boolean = Operators.CompareString(Me.txtID.Text, "", False) = 0
					If flag3 Then
						Me.InsertData()
						EmailModule.SendMail("GRN Entry", Me.txtID.Text, "Created", Me.sEmailTo)
					Else
						Me.UpdateData()
						EmailModule.SendMail("GRN Modification", Me.txtID.Text, "Modified", Me.sEmailTo)
					End If
				End If
			End If
		End Sub

		' Token: 0x0600169B RID: 5787 RVA: 0x000CB658 File Offset: 0x000C9858
		Private Sub InsertData()
			Dim text As String = "EXEC usp_GetGRNNo"
			Dim dataTable As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				Dim text2 As String = Conversions.ToString(dataTable.Rows(0)("TrnNo"))
				Dim text3 As String = "GRN In Approval"
				Me.skip_lblStatus.Text = text3
				text = " INSERT INTO GRN (GRNType, GRNNo, GRNDt, VendorID, POID, POType, PONo, InvoiceNo, ChallanNo, " & vbCrLf
				text += " PODt, InvoiceDt, ChallanDt, Status, Remarks, CreationDt, CreatedBy)" & vbCrLf
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(String.Concat(New String() { " VALUES('", Me.sGRNType, "', '", text2, "', '", Strings.Format(Me.dtpDt.Value, "MM/dd/yyyy"), "', '" }), Me.cmbVendor.SelectedValue), "', ")))
				Dim flag2 As Boolean = Operators.CompareString(Me.txtPOID.Text, "", False) <> 0
				If flag2 Then
					text = text + " '" + Me.txtPOID.Text + "', "
				Else
					text += " NULL, "
				End If
				text = String.Concat(New String() { text, " '", Me.cmbPOType.Text, "', '", Strings.Trim(Me.txtPONo.Text), "', '", Strings.Trim(Me.txtInvoiceNo.Text), "', '", Strings.Trim(Me.txtChallanNo.Text), "', " })
				Dim checked As Boolean = Me.dtpPODt.Checked
				If checked Then
					text = text + " '" + Strings.Format(Me.dtpPODt.Value, "MM/dd/yyyy") + "', "
				Else
					text += " NULL, "
				End If
				Dim checked2 As Boolean = Me.dtpInvoiceDt.Checked
				If checked2 Then
					text = text + " '" + Strings.Format(Me.dtpInvoiceDt.Value, "MM/dd/yyyy") + "', "
				Else
					text += " NULL, "
				End If
				Dim checked3 As Boolean = Me.dtpChallanDt.Checked
				If checked3 Then
					text = text + " '" + Strings.Format(Me.dtpChallanDt.Value, "MM/dd/yyyy") + "', "
				Else
					text += " NULL, "
				End If
				text = String.Concat(New String() { text, " '", text3, "', '", Strings.Trim(Me.txtRemarks.Text), "', GETDATE(), '", GlobalVariables.gsUserID, "')" & vbCrLf })
				text += " SELECT SCOPE_IDENTITY() AS ID"
				dataTable = MainModule.GetData(text)
				Dim flag3 As Boolean = dataTable.Rows.Count > 0
				If flag3 Then
					Me.txtID.Text = Conversions.ToString(dataTable.Rows(0)("ID"))
					Me.txtNo.Text = text2
					Me.InsertItems()
					Me.Update_PO_ReceivedQty()
					FileAttachments.InsertFiles("GRN", Me.txtID.Text, Me.dtFile)
					Dim text4 As String = "ID : " + Me.txtID.Text + vbCrLf
					text4 = text4 + "Trn No. : " + Me.txtNo.Text
					MainModule.TrnLog(Me.Text, "GRN Generated", text4, Nothing)
					CustomMsgBox.Show("GRN Generated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				End If
			End If
		End Sub

		' Token: 0x0600169C RID: 5788 RVA: 0x000CBA34 File Offset: 0x000C9C34
		Private Sub UpdateData()
			Dim text As String = "GRN In Approval"
			Me.skip_lblStatus.Text = text
			Dim text2 As String = String.Concat(New String() { " UPDATE GRN SET POType = '", Me.cmbPOType.Text, "', PONo = '", Strings.Trim(Me.txtPONo.Text), "', " & vbCrLf })
			text2 = String.Concat(New String() { text2, " InvoiceNo = '", Strings.Trim(Me.txtInvoiceNo.Text), "', ChallanNo = '", Strings.Trim(Me.txtChallanNo.Text), "', " & vbCrLf })
			text2 = Conversions.ToString(Operators.AddObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" VendorID = '", Me.cmbVendor.SelectedValue), "', "), vbCrLf)))
			Dim checked As Boolean = Me.dtpPODt.Checked
			If checked Then
				text2 = text2 + " PODt = '" + Strings.Format(Me.dtpPODt.Value, "MM/dd/yyyy") + "', "
			Else
				text2 += " PODt = NULL, "
			End If
			Dim checked2 As Boolean = Me.dtpInvoiceDt.Checked
			If checked2 Then
				text2 = text2 + " InvoiceDt = '" + Strings.Format(Me.dtpInvoiceDt.Value, "MM/dd/yyyy") + "', "
			Else
				text2 += " InvoiceDt = NULL, "
			End If
			Dim checked3 As Boolean = Me.dtpChallanDt.Checked
			If checked3 Then
				text2 = text2 + " ChallanDt = '" + Strings.Format(Me.dtpChallanDt.Value, "MM/dd/yyyy") + "', "
			Else
				text2 += " ChallanDt = NULL, "
			End If
			text2 = String.Concat(New String() { text2, " Remarks = '", Strings.Trim(Me.txtRemarks.Text), "', Status = '", text, "', " & vbCrLf })
			text2 = text2 + " ModificationDt = GETDATE(), ModifiedBy = '" + GlobalVariables.gsUserID + "'" & vbCrLf
			text2 = text2 + " WHERE GRNID  = '" + Me.txtID.Text + "'"
			Dim flag As Boolean = MainModule.ExecuteSQL(text2) = 1
			If flag Then
				Me.InsertItems()
				Me.Update_PO_ReceivedQty()
				FileAttachments.InsertFiles("GRN", Me.txtID.Text, Me.dtFile)
				Dim text3 As String = "ID : " + Me.txtID.Text + vbCrLf
				text3 = text3 + "Trn No. : " + Me.txtNo.Text
				MainModule.TrnLog(Me.Text, "GRN Modified", text3, Nothing)
				CustomMsgBox.Show("GRN Modified.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End If
		End Sub

		' Token: 0x0600169D RID: 5789 RVA: 0x000CBD0C File Offset: 0x000C9F0C
		Private Sub InsertItems()
			Dim flag As Boolean = (Operators.CompareString(Me.txtID.Text, "", False) <> 0) And (Me.dtItems.Rows.Count > 0)
			If flag Then
				Dim sqlConnection As SqlConnection = New SqlConnection(GlobalVariables.gsConStr)
				sqlConnection.Open()
				Dim sqlTransaction As SqlTransaction = sqlConnection.BeginTransaction(IsolationLevel.Serializable)
				Try
					Dim text As String = "DELETE FROM GRNItems WHERE GRNID = '" + Me.txtID.Text + "'"
					Dim flag2 As Boolean = MainModule.ExecuteSQL(text, sqlConnection, sqlTransaction) = 1
					If flag2 Then
						text = ""
						Dim num As Integer = Me.dtItems.Rows.Count - 1
						For i As Integer = 0 To num
							text += " INSERT INTO GRNItems (GRNID, ProductID, Description, SpecificationNo, BMRNo, BatchNo, MfgDt, ExpDt, " & vbCrLf
							text += " ReceivedQty, NoOfBarcode, TertiaryPackSize, PrimaryPackSize, UnitPrice, GSTPer, BasicValue, LandingCost, TotalCost, " & vbCrLf
							text += " CellCount, PassageNo, ODPermL, "
							text += " POID, Remarks, ExpiryType, Expiry, Status, IsQCApplicable, IsParentApplicable, IsUnitsEditable)" & vbCrLf
							text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" VALUES ('" + Me.txtID.Text + "', '", Me.dtItems.Rows(i)("ProductID")), "', '"), Me.dtItems.Rows(i)("Description")), "', ")))
							text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" '", Me.dtItems.Rows(i)("SpecificationNo")), "', ")))
							text = String.Concat(New String() { text, " '", Me.dtItems.Rows(i)("BMRNo").ToString(), "', '", Me.dtItems.Rows(i)("BatchNo").ToString(), "', " })
							Dim flag3 As Boolean = Operators.CompareString(Me.dtItems.Rows(i)("MfgDt").ToString(), "", False) <> 0
							If flag3 Then
								text = text + " '" + Strings.Format(RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(i)("MfgDt")), "MM/dd/yyyy") + "', "
							Else
								text += " NULL , "
							End If
							Dim flag4 As Boolean = Operators.CompareString(Me.dtItems.Rows(i)("ExpDt").ToString(), "", False) <> 0
							If flag4 Then
								text = text + " '" + Strings.Format(RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(i)("ExpDt")), "MM/dd/yyyy") + "', "
							Else
								text += " NULL , "
							End If
							text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" '", Me.dtItems.Rows(i)("ReceivedQty")), "', '"), Me.dtItems.Rows(i)("NoOfBarcode")), "',")))
							text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" '", Me.dtItems.Rows(i)("TertiaryPackSize")), "', '"), Me.dtItems.Rows(i)("PrimaryPackSize")), "', ")))
							text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" '", Me.dtItems.Rows(i)("UnitPrice")), "', '"), Me.dtItems.Rows(i)("GSTPer")), "', ")))
							text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" '", Me.dtItems.Rows(i)("BasicValue")), "', '"), Me.dtItems.Rows(i)("LandingCost")), "', ")))
							text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" '", Me.dtItems.Rows(i)("TotalCost")), "', ")))
							text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" '", Me.dtItems.Rows(i)("CellCount")), "', '"), Me.dtItems.Rows(i)("PassageNo")), "', ")))
							text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" '", Me.dtItems.Rows(i)("ODPermL")), "', ")))
							Dim flag5 As Boolean = Operators.CompareString(Me.txtPOID.Text, "", False) <> 0
							If flag5 Then
								text = text + " '" + Me.txtPOID.Text + "', "
							Else
								text += " NULL, "
							End If
							text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" '', '", Me.dtItems.Rows(i)("ExpiryType")), "', '"), Me.dtItems.Rows(i)("Expiry")), "', ")))
							Dim flag6 As Boolean = Operators.CompareString(Me.sGRNType, "Return", False) <> 0
							If flag6 Then
								Dim flag7 As Boolean = Convert.ToInt16(RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(i)("IsQCApplicable"))) = 1S
								If flag7 Then
									text += " 'In QC Release', "
								Else
									text += " 'QC Approved', "
								End If
								text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" '", Me.dtItems.Rows(i)("IsQCApplicable")), "', ")))
							Else
								text += " 'QC Approved', 'False', "
							End If
							text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" '", Me.dtItems.Rows(i)("IsParentApplicable")), "', '"), Me.dtItems.Rows(i)("IsUnitsEditable")), "')"), vbCrLf), vbCrLf)))
						Next
						Dim flag8 As Boolean = MainModule.ExecuteSQL(text, sqlConnection, sqlTransaction) = 1
						If flag8 Then
							sqlTransaction.Commit()
							sqlConnection.Close()
						Else
							sqlTransaction.Rollback()
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

		' Token: 0x0600169E RID: 5790 RVA: 0x000CC52C File Offset: 0x000CA72C
		Private Sub Update_PO_ReceivedQty()
			Dim flag As Boolean = Operators.CompareString(Me.txtPOID.Text, "", False) <> 0
			If flag Then
				Dim text As String = "EXEC usp_Set_PO_Status '" + Me.txtPOID.Text + "'"
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text) = 1
				If flag2 Then
				End If
			End If
		End Sub

		' Token: 0x0600169F RID: 5791 RVA: 0x000CC584 File Offset: 0x000CA784
		Private Sub btnApprove_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Dim flag As Boolean = CustomMsgBox.Show("Approve..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
				If flag Then
					Me.Approve_N_GenerateBarcodes()
					EmailModule.SendMail("GRN Approval", Me.txtID.Text, "Approved", Me.sEmailTo)
					EmailModule.Send_PR_Status_MailAlert(Me.txtPOID.Text, Me.txtID.Text, "", "", "GRN", "")
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnApprove.Enabled = True
				Me.btnReject.Enabled = True
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x060016A0 RID: 5792 RVA: 0x000CC678 File Offset: 0x000CA878
		Private Sub Approve_N_GenerateBarcodes()
			Dim flag As Boolean = Me.dtBarcodes.Rows.Count = 0
			If flag Then
				Dim text As String = ""
				Dim text2 As String = "GRN Approved"
				Dim text3 As String = "Approval"
				Dim captureReasons As CaptureReasons = New CaptureReasons(text3)
				Dim flag2 As Boolean = captureReasons.ShowDialog() = DialogResult.OK
				If flag2 Then
					text = text + "Action : " + text2 + vbCrLf
					text = text + "Action By : " + GlobalVariables.gsUserName + vbCrLf
					text = text + "Action On : " + Strings.Format(MainModule.GetServerDate(), "dd-MMM-yyyy hh:mm:ss tt") + vbCrLf
					text = text + "Remarks : " + captureReasons.sRemarks
					Dim txtRemarksApproval As TextBox = Me.txtRemarksApproval
					Dim textBox As TextBox = txtRemarksApproval
					txtRemarksApproval.Text = textBox.Text + text
					Me.lblRemarksApproval_Click(Nothing, Nothing)
					Dim sqlConnection As SqlConnection = New SqlConnection(GlobalVariables.gsConStr)
					sqlConnection.Open()
					Dim sqlTransaction As SqlTransaction = sqlConnection.BeginTransaction(IsolationLevel.Serializable)
					Try
						Dim flag3 As Boolean = MainModule.SetDBTableLock("GRNUID", sqlConnection, sqlTransaction) = 0
						If flag3 Then
							Interaction.MsgBox("Server Buss, Try After Sometime.", MsgBoxStyle.Critical, "Critical")
							sqlTransaction.Rollback()
							sqlConnection.Close()
						Else
							Dim dataTable As DataTable = MainModule.SetLookUpTable()
							Me.btnApprove.Enabled = False
							Me.btnOnHold.Enabled = False
							Me.btnReject.Enabled = False
							Dim serverDate As DateTime = MainModule.GetServerDate()
							Dim text4 As String = Conversions.ToString(dataTable.[Select]("sType='D' AND sVal='" + Strings.Format(serverDate, "dd") + "'")(0)("ID"))
							Dim text5 As String = Conversions.ToString(dataTable.[Select]("sType='M' AND sVal='" + Strings.Format(serverDate, "MMM") + "'")(0)("ID"))
							Dim text6 As String = Conversions.ToString(dataTable.[Select]("sType='Y' AND sVal='" + Strings.Format(serverDate, "yyyy") + "'")(0)("ID"))
							Dim text7 As String = " SELECT ISNULL(MAX(UID),'IADMY00000') AS MaxUID, ISNULL(MAX(ParentUID),'IADMY0000') AS MaxParentUID FROM GRNUID "
							text7 = String.Concat(New String() { text7, " WHERE (CreationDt BETWEEN '", Strings.Format(serverDate, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(serverDate, "MM/dd/yyyy 23:59:59"), "') " })
							Dim data As DataTable = MainModule.GetData(text7, sqlConnection, sqlTransaction)
							Dim text8 As String = Conversions.ToString(data.Rows(0)("MaxUID"))
							Dim text9 As String = Conversions.ToString(data.Rows(0)("MaxParentUID"))
							Dim num As Integer = Conversions.ToInteger(Strings.Mid(text8, 6, 5))
							Dim num2 As Integer = Conversions.ToInteger(Strings.Mid(text8, 6, 4))
							Me.dtBarcodes.Rows.Clear()
							Dim num3 As Integer = Me.dtItems.Rows.Count - 1
							For i As Integer = 0 To num3
								' The following expression was wrapped in a unchecked-expression
								Dim num4 As Integer = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(i)("ReceivedQty"))) - 1.0))
								For j As Integer = 0 To num4
									Dim flag4 As Boolean = Convert.ToInt16(RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(i)("IsParentApplicable"))) = 1S
									Dim text10 As String
									If flag4 Then
										num2 += 1
										text10 = String.Concat(New String() { "IA", text4, text5, text6, Strings.Format(num2, "0000") })
									End If
									Dim num5 As Integer = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(i)("TertiaryPackSize"))) - 1.0))
									For k As Integer = 0 To num5
										Dim flag5 As Boolean = CDbl(Me.dtBarcodes.Rows.Count) = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(i)("NoOfBarcode")))
										If flag5 Then
											Exit For
										End If
										num += 1
										Dim text11 As String = String.Concat(New String() { "IA", text4, text5, text6, Strings.Format(num, "00000") })
										Me.dtBarcodes.Rows.Add(New Object(-1) {})
										Me.dtBarcodes.Rows(Me.dtBarcodes.Rows.Count - 1)("GRNItemsID") = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(i)("GRNItemsID"))
										Me.dtBarcodes.Rows(Me.dtBarcodes.Rows.Count - 1)("ProductID") = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(i)("ProductID"))
										Me.dtBarcodes.Rows(Me.dtBarcodes.Rows.Count - 1)("ProductName") = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(i)("ProductName"))
										Me.dtBarcodes.Rows(Me.dtBarcodes.Rows.Count - 1)("UID") = text11
										Dim flag6 As Boolean = Convert.ToInt16(RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(i)("IsParentApplicable"))) = 1S
										If flag6 Then
											Me.dtBarcodes.Rows(Me.dtBarcodes.Rows.Count - 1)("ParentUID") = text10
										Else
											Me.dtBarcodes.Rows(Me.dtBarcodes.Rows.Count - 1)("ParentUID") = ""
										End If
										Me.dtBarcodes.Rows(Me.dtBarcodes.Rows.Count - 1)("CatalogNo") = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(i)("CatalogNo"))
										Me.dtBarcodes.Rows(Me.dtBarcodes.Rows.Count - 1)("Description") = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(i)("Description"))
										Me.dtBarcodes.Rows(Me.dtBarcodes.Rows.Count - 1)("BatchNo") = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(i)("BatchNo"))
										Me.dtBarcodes.Rows(Me.dtBarcodes.Rows.Count - 1)("PrimaryPackSize") = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(i)("PrimaryPackSize"))
										Dim num6 As Double = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(i)("TotalCost"))) / Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(i)("NoOfBarcode")))
										Me.dtBarcodes.Rows(Me.dtBarcodes.Rows.Count - 1)("Price") = Strings.Format(num6, "#0.00")
										Me.dtBarcodes.Rows(Me.dtBarcodes.Rows.Count - 1)("AvgPrice") = Strings.Format(num6, "#0.00")
										Me.dtBarcodes.Rows(Me.dtBarcodes.Rows.Count - 1)("IsParentApplicable") = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(i)("IsParentApplicable"))
										Me.dtBarcodes.Rows(Me.dtBarcodes.Rows.Count - 1)("IsUnitsEditable") = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(i)("IsUnitsEditable"))
										Dim flag7 As Boolean = Convert.ToInt16(RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(i)("IsQCApplicable"))) = 1S
										If flag7 Then
											Me.dtBarcodes.Rows(Me.dtBarcodes.Rows.Count - 1)("Status") = "Created"
										Else
											Me.dtBarcodes.Rows(Me.dtBarcodes.Rows.Count - 1)("Status") = "Available"
										End If
									Next
								Next
							Next
							Dim flag8 As Boolean = Me.InsertBarcodes(sqlConnection, sqlTransaction)
							If flag8 Then
								Me.skip_lblStatus.Text = text2
								text7 = " INSERT INTO GRNUID (GRNItemsID, GRNID, ProductID, UID, ParentUID, LocationCode, CatalogNo,  " & vbCrLf
								text7 += " Description, BatchNo, PrimaryPackSize, MfgDt, ExpDt, Price, AvgPrice, ExpiryType, Expiry, IsParentApplicable,  " & vbCrLf
								text7 += " IsUnitsEditable, Status, CreationDt, CreatedBy) " & vbCrLf
								text7 += " SELECT G.GRNItemsID, G.GRNID, G.ProductID, UID, ParentUID, LocationCode, G.CatalogNo,  " & vbCrLf
								text7 += " G.Description, G.BatchNo, G.PrimaryPackSize, GI.MfgDt, GI.ExpDt, Price, AvgPrice, GI.ExpiryType, GI.Expiry, G.IsParentApplicable,  " & vbCrLf
								text7 += " G.IsUnitsEditable, G.Status, CreationDt, CreatedBy " & vbCrLf
								text7 += " FROM GRNUIDTemp G INNER JOIN GRNItems GI ON G.GRNItemsID = GI.GRNItemsID  " & vbCrLf
								text7 = text7 + " WHERE G.GRNID = '" + Me.txtID.Text + "'" & vbCrLf
								text7 = String.Concat(New String() { text7, " UPDATE GRN SET Status = '", text2, "', ActionRemarks = '", Me.txtRemarksApproval.Text, "', " & vbCrLf })
								text7 = text7 + " ActionDt = GETDATE(), ActionBy = '" + GlobalVariables.gsUserID + "'" & vbCrLf
								text7 = text7 + " WHERE GRNID = '" + Me.txtID.Text + "'"
								text7 = text7 + " DELETE FROM GRNUIDTemp WHERE GRNID = '" + Me.txtID.Text + "'"
								Dim flag9 As Boolean = MainModule.ExecuteSQL(text7, sqlConnection, sqlTransaction) = 1
								If flag9 Then
									sqlTransaction.Commit()
									sqlConnection.Close()
									Me.UpdateWeightedAverageRate()
									Dim text12 As String = "ID : " + Me.txtID.Text + vbCrLf
									text12 = text12 + "Trn No. : " + Me.txtNo.Text
									MainModule.TrnLog(Me.Text, "GRN Approved", text12, Nothing)
									CustomMsgBox.Show("GRN Approved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
								End If
							Else
								sqlTransaction.Rollback()
								sqlConnection.Close()
								Me.btnApprove.Enabled = True
							End If
						End If
					Catch ex As Exception
						Dim flag10 As Boolean = (Strings.InStr(ex.Message, "Timeout expired", CompareMethod.Binary) > 0) Or (Strings.InStr(ex.Message, "Violation of PRIMARY KEY constraint", CompareMethod.Binary) > 0)
						If flag10 Then
							CustomMsgBox.Show("Server Busy Try Again : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Else
							CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						End If
						sqlTransaction.Rollback()
						sqlConnection.Close()
						Me.btnApprove.Enabled = True
						Me.btnOnHold.Enabled = True
						Me.btnReject.Enabled = True
					End Try
				Else
					CustomMsgBox.Show("Remark For " + text3 + " Is Mandatory.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				End If
			End If
		End Sub

		' Token: 0x060016A1 RID: 5793 RVA: 0x000CD2E8 File Offset: 0x000CB4E8
		Private Function InsertBarcodes(oCon As SqlConnection, oTrn As SqlTransaction) As Boolean
			Dim flag As Boolean = (Operators.CompareString(Me.txtID.Text, "", False) <> 0) And (Me.dtBarcodes.Rows.Count > 0)
			Dim flag3 As Boolean
			If flag Then
				Dim text As String = "DELETE FROM GRNUID WHERE GRNID = '" + Me.txtID.Text + "'"
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text, oCon, oTrn) = 1
				If flag2 Then
					Dim dataTable As DataTable = Me.dtBarcodes.Copy()
					dataTable.Columns.Remove("ProductName")
					Dim dataColumn As DataColumn = New DataColumn("GRNID", GetType(Integer))
					dataColumn.DefaultValue = Me.txtID.Text
					dataTable.Columns.Add(dataColumn)
					MainModule.BulkInsertTemp(dataTable, "GRNUIDTemp", oCon, oTrn)
					flag3 = True
				Else
					flag3 = False
				End If
			Else
				flag3 = False
			End If
			Return flag3
		End Function

		' Token: 0x060016A2 RID: 5794 RVA: 0x000CD3CC File Offset: 0x000CB5CC
		Private Sub UpdateWeightedAverageRate()
			Dim text As String = ""
			Dim num As Integer = Me.dtItems.Rows.Count - 1
			For i As Integer = 0 To num
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("EXEC usp_Update_WeightedAverage_Rate '", Me.dtItems.Rows(i)("ProductID")), "'"), vbCrLf)))
			Next
			Dim flag As Boolean = Operators.CompareString(text, "", False) <> 0
			If flag Then
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text) = 1
				If flag2 Then
				End If
			End If
		End Sub

		' Token: 0x060016A3 RID: 5795 RVA: 0x000CD46C File Offset: 0x000CB66C
		Private Sub btnOnHold_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Dim flag As Boolean = CustomMsgBox.Show("Put On Hold..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
				If flag Then
					Me.OnHold()
					EmailModule.SendMail("GRN Approval", Me.txtID.Text, "On-Hold", Me.sEmailTo)
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

		' Token: 0x060016A4 RID: 5796 RVA: 0x000CD548 File Offset: 0x000CB748
		Private Sub OnHold()
			Dim captureReasons As CaptureReasons = New CaptureReasons("On-Hold")
			Dim flag As Boolean = captureReasons.ShowDialog() = DialogResult.OK
			If flag Then
				Me.btnApprove.Enabled = False
				Me.btnOnHold.Enabled = False
				Me.btnReject.Enabled = False
				Me.btnCancel.Enabled = False
				Dim text As String = "Action : GRN On-Hold" & vbCrLf
				text = text + "Action By : " + GlobalVariables.gsUserName + vbCrLf
				text = text + "Action On : " + Strings.Format(MainModule.GetServerDate(), "dd-MMM-yyyy hh:mm:ss tt") + vbCrLf
				text = text + "Remarks : " + captureReasons.sRemarks + vbCrLf & vbCrLf
				Dim txtRemarksApproval As TextBox = Me.txtRemarksApproval
				Dim textBox As TextBox = txtRemarksApproval
				txtRemarksApproval.Text = textBox.Text + text
				Me.lblRemarksApproval.Visible = True
				Me.lblRemarksApproval_Click(Nothing, Nothing)
				Dim text2 As String = " UPDATE GRN SET Status = 'GRN On-Hold', ActionRemarks = '" + Me.txtRemarksApproval.Text + "', " & vbCrLf
				text2 = text2 + " ActionDt = GETDATE(), ActionBy = '" + GlobalVariables.gsUserID + "'" & vbCrLf
				text2 = text2 + " WHERE GRNID  = '" + Me.txtID.Text + "'"
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text2) = 1
				If flag2 Then
					Dim text3 As String = "ID : " + Me.txtID.Text + vbCrLf
					text3 = text3 + "GRN No. : " + Me.txtNo.Text
					Me.skip_lblStatus.Text = "On-Hold"
					MainModule.TrnLog(Me.Text, "GRN On-Hold", text3, Nothing)
					CustomMsgBox.Show("GRN On-Hold.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Else
					Me.btnApprove.Enabled = True
					Me.btnOnHold.Enabled = True
					Me.btnReject.Enabled = True
					Me.btnCancel.Enabled = True
				End If
			End If
		End Sub

		' Token: 0x060016A5 RID: 5797 RVA: 0x000CD734 File Offset: 0x000CB934
		Private Sub btnReject_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Dim flag As Boolean = CustomMsgBox.Show("Reject..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
				If flag Then
					Me.RejectGRN()
					Me.Update_PO_ReceivedQty()
					EmailModule.SendMail("GRN Approval", Me.txtID.Text, "Rejected", Me.sEmailTo)
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnApprove.Enabled = True
				Me.btnOnHold.Enabled = True
				Me.btnReject.Enabled = True
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x060016A6 RID: 5798 RVA: 0x000CD80C File Offset: 0x000CBA0C
		Private Sub RejectGRN()
			Me.btnApprove.Enabled = False
			Me.btnOnHold.Enabled = False
			Me.btnReject.Enabled = False
			Dim text As String = ""
			Dim text2 As String = "GRN Rejected"
			Dim text3 As String = "Rejection"
			Dim captureReasons As CaptureReasons = New CaptureReasons(text3)
			Dim flag As Boolean = captureReasons.ShowDialog() = DialogResult.OK
			If flag Then
				text = text + "Action : " + text2 + vbCrLf
				text = text + "Action By : " + GlobalVariables.gsUserName + vbCrLf
				text = text + "Action On : " + Strings.Format(MainModule.GetServerDate(), "dd-MMM-yyyy hh:mm:ss tt") + vbCrLf
				text = text + "Remarks : " + captureReasons.sRemarks
				Dim txtRemarksApproval As TextBox = Me.txtRemarksApproval
				Dim textBox As TextBox = txtRemarksApproval
				txtRemarksApproval.Text = textBox.Text + text
				Me.lblRemarksApproval_Click(Nothing, Nothing)
				Dim text4 As String = String.Concat(New String() { " UPDATE GRN SET Status = '", text2, "', ActionBy = '", GlobalVariables.gsUserID, "', ActionDt = GETDATE() " })
				text4 = text4 + " WHERE GRNID = '" + Me.txtID.Text + "'"
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text4) = 1
				If flag2 Then
					Me.skip_lblStatus.Text = text2
					Me.Update_PO_ReceivedQty()
					Dim text5 As String = "ID : " + Me.txtID.Text + vbCrLf
					text5 = text5 + "Trn No. : " + Me.txtNo.Text
					MainModule.TrnLog(Me.Text, "GRN Rejected", text5, Nothing)
					CustomMsgBox.Show("GRN Rejected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				End If
			Else
				CustomMsgBox.Show("Remark For " + text3 + " Is Mandatory.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End If
		End Sub

		' Token: 0x060016A7 RID: 5799 RVA: 0x000CD9E8 File Offset: 0x000CBBE8
		Private Sub btnCancel_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.btnCancel.Enabled = False
				Dim text As String = "Critical Operation, Cannot Be Reverted." & vbCrLf
				text += "Cancel GRN..?"
				Dim flag As Boolean = CustomMsgBox.Show(text, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = DialogResult.Yes
				If flag Then
					Me.CancelGRN()
					EmailModule.SendMail("GRN Cancelled", Me.txtID.Text, "Cancelled", Me.sEmailTo)
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnCancel.Enabled = True
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x060016A8 RID: 5800 RVA: 0x000CDAB8 File Offset: 0x000CBCB8
		Private Sub CancelGRN()
			Dim flag As Boolean = Not Me.ValidateCancelGRN()
			If Not flag Then
				Dim text As String = ""
				Dim captureReasons As CaptureReasons = New CaptureReasons("Cancellation")
				Dim flag2 As Boolean = captureReasons.ShowDialog() = DialogResult.OK
				If flag2 Then
					text = "Remarks : " + captureReasons.sRemarks
				End If
				Dim flag3 As Boolean = Operators.CompareString(text, "", False) = 0
				If Not flag3 Then
					Dim text2 As String = " UPDATE GRN SET Status = 'GRN Cancelled', CancelledBy = '" + GlobalVariables.gsUserID + "', CancelledDt = GETDATE(), " & vbCrLf
					text2 = text2 + " CancelledRemarks = '" + text + "'"
					text2 = text2 + " WHERE GRNID = '" + Me.txtID.Text + "'" & vbCrLf & vbCrLf
					text2 = text2 + " UPDATE GRNItems SET Status = 'Cancelled', ActionBy = '" + GlobalVariables.gsUserID + "', ActionDt = GETDATE()" & vbCrLf
					text2 = text2 + " WHERE GRNID = '" + Me.txtID.Text + "'" & vbCrLf & vbCrLf
					text2 = text2 + " UPDATE GRNUID SET Status = 'Disposed', ActionBy = '" + GlobalVariables.gsUserID + "', ActionDt = GETDATE(), Remarks = 'GRN Cancelled'" & vbCrLf
					text2 = text2 + " WHERE GRNID = '" + Me.txtID.Text + "'" & vbCrLf & vbCrLf
					Dim flag4 As Boolean = MainModule.ExecuteSQL(text2) = 1
					If flag4 Then
						Me.skip_lblStatus.Text = "GRN Cancelled"
						Me.Update_PO_ReceivedQty()
						Dim text3 As String = "ID : " + Me.txtID.Text + vbCrLf
						text3 = text3 + "Trn No. : " + Me.txtNo.Text
						MainModule.TrnLog(Me.Text, "GRN Cancelled", text3, Nothing)
						CustomMsgBox.Show("GRN Cancelled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					End If
				End If
			End If
		End Sub

		' Token: 0x060016A9 RID: 5801 RVA: 0x000CDC54 File Offset: 0x000CBE54
		Private Function ValidateCancelGRN() As Boolean
			Dim flag As Boolean = Me.dtBarcodes.[Select]("Status IN ('Picked','Issued')").Length > 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("GRN Cannot Be Cancelled, UID In-Picking Or Issued.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				flag2 = False
			Else
				flag2 = True
			End If
			Return flag2
		End Function

		' Token: 0x060016AA RID: 5802 RVA: 0x000CDC98 File Offset: 0x000CBE98
		Private Sub Set_GRN_Status()
			Dim text As String = " EXEC usp_Set_GRN_Status '" + Me.txtID.Text + "' "
			Dim flag As Boolean = MainModule.ExecuteSQL(text) = 1
			If flag Then
			End If
		End Sub

		' Token: 0x060016AB RID: 5803 RVA: 0x000CDCD0 File Offset: 0x000CBED0
		Private Sub llbSaveFile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Dim flag As Boolean = CustomMsgBox.Show("Save Files..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
			If flag Then
				FileAttachments.InsertFiles("GRN", Me.txtID.Text, Me.dtFile)
			End If
		End Sub

		' Token: 0x060016AC RID: 5804 RVA: 0x000CDD18 File Offset: 0x000CBF18
		Private Sub lblRemarks_Click(sender As Object, e As EventArgs)
			Me.lblRemarks.BorderStyle = BorderStyle.FixedSingle
			Me.lblRemarksApproval.BorderStyle = BorderStyle.None
			Me.lblRemarks1.Visible = True
			Me.lblRemarksApproval1.Visible = False
			Me.txtRemarks.Visible = True
			Me.txtRemarksApproval.Visible = False
		End Sub

		' Token: 0x060016AD RID: 5805 RVA: 0x000CDD74 File Offset: 0x000CBF74
		Private Sub lblRemarksApproval_Click(sender As Object, e As EventArgs)
			Me.lblRemarks.BorderStyle = BorderStyle.None
			Me.lblRemarksApproval.BorderStyle = BorderStyle.FixedSingle
			Me.lblRemarks1.Visible = False
			Me.lblRemarksApproval.Visible = True
			Me.lblRemarksApproval1.Visible = True
			Me.txtRemarks.Visible = False
			Me.txtRemarksApproval.Visible = True
		End Sub

		' Token: 0x040009AA RID: 2474
		Private sFormType As String

		' Token: 0x040009AB RID: 2475
		Private sGRNType As String

		' Token: 0x040009AC RID: 2476
		Private sEmailTo As String

		' Token: 0x040009AD RID: 2477
		Private drData As DataRow

		' Token: 0x040009AE RID: 2478
		Private dtItems As DataTable

		' Token: 0x040009AF RID: 2479
		Private dtPOItems As DataTable

		' Token: 0x040009B0 RID: 2480
		Private dtBarcodes As DataTable

		' Token: 0x040009B1 RID: 2481
		Private dtFile As DataTable
	End Class
End Namespace
