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
	' Token: 0x02000058 RID: 88
	<DesignerGenerated()>
	Public Partial Class PRGeneration
		Inherits DockContent

		' Token: 0x170006F0 RID: 1776
		' (get) Token: 0x06001239 RID: 4665 RVA: 0x000AACDE File Offset: 0x000A8EDE
		' (set) Token: 0x0600123A RID: 4666 RVA: 0x000AACE8 File Offset: 0x000A8EE8
		Friend Overridable Property grpPO As GroupBox

		' Token: 0x170006F1 RID: 1777
		' (get) Token: 0x0600123B RID: 4667 RVA: 0x000AACF1 File Offset: 0x000A8EF1
		' (set) Token: 0x0600123C RID: 4668 RVA: 0x000AACFB File Offset: 0x000A8EFB
		Friend Overridable Property Label1 As Label

		' Token: 0x170006F2 RID: 1778
		' (get) Token: 0x0600123D RID: 4669 RVA: 0x000AAD04 File Offset: 0x000A8F04
		' (set) Token: 0x0600123E RID: 4670 RVA: 0x000AAD10 File Offset: 0x000A8F10
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

		' Token: 0x170006F3 RID: 1779
		' (get) Token: 0x0600123F RID: 4671 RVA: 0x000AAD53 File Offset: 0x000A8F53
		' (set) Token: 0x06001240 RID: 4672 RVA: 0x000AAD5D File Offset: 0x000A8F5D
		Friend Overridable Property skip_lblStatus As Label

		' Token: 0x170006F4 RID: 1780
		' (get) Token: 0x06001241 RID: 4673 RVA: 0x000AAD66 File Offset: 0x000A8F66
		' (set) Token: 0x06001242 RID: 4674 RVA: 0x000AAD70 File Offset: 0x000A8F70
		Friend Overridable Property skip_lblPO As Label

		' Token: 0x170006F5 RID: 1781
		' (get) Token: 0x06001243 RID: 4675 RVA: 0x000AAD79 File Offset: 0x000A8F79
		' (set) Token: 0x06001244 RID: 4676 RVA: 0x000AAD84 File Offset: 0x000A8F84
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

		' Token: 0x170006F6 RID: 1782
		' (get) Token: 0x06001245 RID: 4677 RVA: 0x000AADC7 File Offset: 0x000A8FC7
		' (set) Token: 0x06001246 RID: 4678 RVA: 0x000AADD1 File Offset: 0x000A8FD1
		Friend Overridable Property Label3 As Label

		' Token: 0x170006F7 RID: 1783
		' (get) Token: 0x06001247 RID: 4679 RVA: 0x000AADDA File Offset: 0x000A8FDA
		' (set) Token: 0x06001248 RID: 4680 RVA: 0x000AADE4 File Offset: 0x000A8FE4
		Friend Overridable Property cmbDept As ComboBox

		' Token: 0x170006F8 RID: 1784
		' (get) Token: 0x06001249 RID: 4681 RVA: 0x000AADED File Offset: 0x000A8FED
		' (set) Token: 0x0600124A RID: 4682 RVA: 0x000AADF7 File Offset: 0x000A8FF7
		Friend Overridable Property dtpDt As DateTimePicker

		' Token: 0x170006F9 RID: 1785
		' (get) Token: 0x0600124B RID: 4683 RVA: 0x000AAE00 File Offset: 0x000A9000
		' (set) Token: 0x0600124C RID: 4684 RVA: 0x000AAE0A File Offset: 0x000A900A
		Friend Overridable Property Label28 As Label

		' Token: 0x170006FA RID: 1786
		' (get) Token: 0x0600124D RID: 4685 RVA: 0x000AAE13 File Offset: 0x000A9013
		' (set) Token: 0x0600124E RID: 4686 RVA: 0x000AAE1D File Offset: 0x000A901D
		Friend Overridable Property Label27 As Label

		' Token: 0x170006FB RID: 1787
		' (get) Token: 0x0600124F RID: 4687 RVA: 0x000AAE26 File Offset: 0x000A9026
		' (set) Token: 0x06001250 RID: 4688 RVA: 0x000AAE30 File Offset: 0x000A9030
		Friend Overridable Property Label5 As Label

		' Token: 0x170006FC RID: 1788
		' (get) Token: 0x06001251 RID: 4689 RVA: 0x000AAE39 File Offset: 0x000A9039
		' (set) Token: 0x06001252 RID: 4690 RVA: 0x000AAE43 File Offset: 0x000A9043
		Friend Overridable Property txtNo As TextBox

		' Token: 0x170006FD RID: 1789
		' (get) Token: 0x06001253 RID: 4691 RVA: 0x000AAE4C File Offset: 0x000A904C
		' (set) Token: 0x06001254 RID: 4692 RVA: 0x000AAE56 File Offset: 0x000A9056
		Friend Overridable Property dtpRequiredBy As DateTimePicker

		' Token: 0x170006FE RID: 1790
		' (get) Token: 0x06001255 RID: 4693 RVA: 0x000AAE5F File Offset: 0x000A905F
		' (set) Token: 0x06001256 RID: 4694 RVA: 0x000AAE6C File Offset: 0x000A906C
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

		' Token: 0x170006FF RID: 1791
		' (get) Token: 0x06001257 RID: 4695 RVA: 0x000AAEAF File Offset: 0x000A90AF
		' (set) Token: 0x06001258 RID: 4696 RVA: 0x000AAEB9 File Offset: 0x000A90B9
		Friend Overridable Property Label9 As Label

		' Token: 0x17000700 RID: 1792
		' (get) Token: 0x06001259 RID: 4697 RVA: 0x000AAEC2 File Offset: 0x000A90C2
		' (set) Token: 0x0600125A RID: 4698 RVA: 0x000AAECC File Offset: 0x000A90CC
		Friend Overridable Property grpItems As GroupBox

		' Token: 0x17000701 RID: 1793
		' (get) Token: 0x0600125B RID: 4699 RVA: 0x000AAED5 File Offset: 0x000A90D5
		' (set) Token: 0x0600125C RID: 4700 RVA: 0x000AAEDF File Offset: 0x000A90DF
		Friend Overridable Property flpButton As FlowLayoutPanel

		' Token: 0x17000702 RID: 1794
		' (get) Token: 0x0600125D RID: 4701 RVA: 0x000AAEE8 File Offset: 0x000A90E8
		' (set) Token: 0x0600125E RID: 4702 RVA: 0x000AAEF4 File Offset: 0x000A90F4
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

		' Token: 0x17000703 RID: 1795
		' (get) Token: 0x0600125F RID: 4703 RVA: 0x000AAF37 File Offset: 0x000A9137
		' (set) Token: 0x06001260 RID: 4704 RVA: 0x000AAF44 File Offset: 0x000A9144
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

		' Token: 0x17000704 RID: 1796
		' (get) Token: 0x06001261 RID: 4705 RVA: 0x000AAF87 File Offset: 0x000A9187
		' (set) Token: 0x06001262 RID: 4706 RVA: 0x000AAF94 File Offset: 0x000A9194
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

		' Token: 0x17000705 RID: 1797
		' (get) Token: 0x06001263 RID: 4707 RVA: 0x000AAFD7 File Offset: 0x000A91D7
		' (set) Token: 0x06001264 RID: 4708 RVA: 0x000AAFE4 File Offset: 0x000A91E4
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

		' Token: 0x17000706 RID: 1798
		' (get) Token: 0x06001265 RID: 4709 RVA: 0x000AB027 File Offset: 0x000A9227
		' (set) Token: 0x06001266 RID: 4710 RVA: 0x000AB034 File Offset: 0x000A9234
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

		' Token: 0x17000707 RID: 1799
		' (get) Token: 0x06001267 RID: 4711 RVA: 0x000AB077 File Offset: 0x000A9277
		' (set) Token: 0x06001268 RID: 4712 RVA: 0x000AB084 File Offset: 0x000A9284
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

		' Token: 0x17000708 RID: 1800
		' (get) Token: 0x06001269 RID: 4713 RVA: 0x000AB0C7 File Offset: 0x000A92C7
		' (set) Token: 0x0600126A RID: 4714 RVA: 0x000AB0D4 File Offset: 0x000A92D4
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

		' Token: 0x17000709 RID: 1801
		' (get) Token: 0x0600126B RID: 4715 RVA: 0x000AB117 File Offset: 0x000A9317
		' (set) Token: 0x0600126C RID: 4716 RVA: 0x000AB121 File Offset: 0x000A9321
		Friend Overridable Property txtTotal As TextBox

		' Token: 0x1700070A RID: 1802
		' (get) Token: 0x0600126D RID: 4717 RVA: 0x000AB12A File Offset: 0x000A932A
		' (set) Token: 0x0600126E RID: 4718 RVA: 0x000AB134 File Offset: 0x000A9334
		Friend Overridable Property Label38 As Label

		' Token: 0x1700070B RID: 1803
		' (get) Token: 0x0600126F RID: 4719 RVA: 0x000AB13D File Offset: 0x000A933D
		' (set) Token: 0x06001270 RID: 4720 RVA: 0x000AB147 File Offset: 0x000A9347
		Friend Overridable Property Panel3 As Panel

		' Token: 0x1700070C RID: 1804
		' (get) Token: 0x06001271 RID: 4721 RVA: 0x000AB150 File Offset: 0x000A9350
		' (set) Token: 0x06001272 RID: 4722 RVA: 0x000AB15A File Offset: 0x000A935A
		Friend Overridable Property theme_tc As TabControl

		' Token: 0x1700070D RID: 1805
		' (get) Token: 0x06001273 RID: 4723 RVA: 0x000AB163 File Offset: 0x000A9363
		' (set) Token: 0x06001274 RID: 4724 RVA: 0x000AB16D File Offset: 0x000A936D
		Friend Overridable Property tpItems As TabPage

		' Token: 0x1700070E RID: 1806
		' (get) Token: 0x06001275 RID: 4725 RVA: 0x000AB176 File Offset: 0x000A9376
		' (set) Token: 0x06001276 RID: 4726 RVA: 0x000AB180 File Offset: 0x000A9380
		Friend Overridable Property tab_lbl3 As Label

		' Token: 0x1700070F RID: 1807
		' (get) Token: 0x06001277 RID: 4727 RVA: 0x000AB189 File Offset: 0x000A9389
		' (set) Token: 0x06001278 RID: 4728 RVA: 0x000AB194 File Offset: 0x000A9394
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

		' Token: 0x17000710 RID: 1808
		' (get) Token: 0x06001279 RID: 4729 RVA: 0x000AB1D7 File Offset: 0x000A93D7
		' (set) Token: 0x0600127A RID: 4730 RVA: 0x000AB1E4 File Offset: 0x000A93E4
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

		' Token: 0x17000711 RID: 1809
		' (get) Token: 0x0600127B RID: 4731 RVA: 0x000AB227 File Offset: 0x000A9427
		' (set) Token: 0x0600127C RID: 4732 RVA: 0x000AB231 File Offset: 0x000A9431
		Friend Overridable Property tpDoc As TabPage

		' Token: 0x17000712 RID: 1810
		' (get) Token: 0x0600127D RID: 4733 RVA: 0x000AB23A File Offset: 0x000A943A
		' (set) Token: 0x0600127E RID: 4734 RVA: 0x000AB244 File Offset: 0x000A9444
		Friend Overridable Property tab_lbl5 As Label

		' Token: 0x17000713 RID: 1811
		' (get) Token: 0x0600127F RID: 4735 RVA: 0x000AB24D File Offset: 0x000A944D
		' (set) Token: 0x06001280 RID: 4736 RVA: 0x000AB258 File Offset: 0x000A9458
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

		' Token: 0x17000714 RID: 1812
		' (get) Token: 0x06001281 RID: 4737 RVA: 0x000AB29B File Offset: 0x000A949B
		' (set) Token: 0x06001282 RID: 4738 RVA: 0x000AB2A8 File Offset: 0x000A94A8
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

		' Token: 0x17000715 RID: 1813
		' (get) Token: 0x06001283 RID: 4739 RVA: 0x000AB2EB File Offset: 0x000A94EB
		' (set) Token: 0x06001284 RID: 4740 RVA: 0x000AB2F5 File Offset: 0x000A94F5
		Friend Overridable Property FileID As DataGridViewTextBoxColumn

		' Token: 0x17000716 RID: 1814
		' (get) Token: 0x06001285 RID: 4741 RVA: 0x000AB2FE File Offset: 0x000A94FE
		' (set) Token: 0x06001286 RID: 4742 RVA: 0x000AB308 File Offset: 0x000A9508
		Friend Overridable Property btnDownload_File As DataGridViewImageColumn

		' Token: 0x17000717 RID: 1815
		' (get) Token: 0x06001287 RID: 4743 RVA: 0x000AB311 File Offset: 0x000A9511
		' (set) Token: 0x06001288 RID: 4744 RVA: 0x000AB31B File Offset: 0x000A951B
		Friend Overridable Property FileName As DataGridViewTextBoxColumn

		' Token: 0x17000718 RID: 1816
		' (get) Token: 0x06001289 RID: 4745 RVA: 0x000AB324 File Offset: 0x000A9524
		' (set) Token: 0x0600128A RID: 4746 RVA: 0x000AB32E File Offset: 0x000A952E
		Friend Overridable Property btnDelete_File As DataGridViewImageColumn

		' Token: 0x17000719 RID: 1817
		' (get) Token: 0x0600128B RID: 4747 RVA: 0x000AB337 File Offset: 0x000A9537
		' (set) Token: 0x0600128C RID: 4748 RVA: 0x000AB341 File Offset: 0x000A9541
		Friend Overridable Property tpRemarks As TabPage

		' Token: 0x1700071A RID: 1818
		' (get) Token: 0x0600128D RID: 4749 RVA: 0x000AB34A File Offset: 0x000A954A
		' (set) Token: 0x0600128E RID: 4750 RVA: 0x000AB354 File Offset: 0x000A9554
		Friend Overridable Property tab_lbl6 As Label

		' Token: 0x1700071B RID: 1819
		' (get) Token: 0x0600128F RID: 4751 RVA: 0x000AB35D File Offset: 0x000A955D
		' (set) Token: 0x06001290 RID: 4752 RVA: 0x000AB367 File Offset: 0x000A9567
		Friend Overridable Property lblRemarksApproval1 As Label

		' Token: 0x1700071C RID: 1820
		' (get) Token: 0x06001291 RID: 4753 RVA: 0x000AB370 File Offset: 0x000A9570
		' (set) Token: 0x06001292 RID: 4754 RVA: 0x000AB37A File Offset: 0x000A957A
		Friend Overridable Property lblRemarks1 As Label

		' Token: 0x1700071D RID: 1821
		' (get) Token: 0x06001293 RID: 4755 RVA: 0x000AB383 File Offset: 0x000A9583
		' (set) Token: 0x06001294 RID: 4756 RVA: 0x000AB38D File Offset: 0x000A958D
		Friend Overridable Property Panel4 As Panel

		' Token: 0x1700071E RID: 1822
		' (get) Token: 0x06001295 RID: 4757 RVA: 0x000AB396 File Offset: 0x000A9596
		' (set) Token: 0x06001296 RID: 4758 RVA: 0x000AB3A0 File Offset: 0x000A95A0
		Friend Overridable Property txtRemarksApproval As TextBox

		' Token: 0x1700071F RID: 1823
		' (get) Token: 0x06001297 RID: 4759 RVA: 0x000AB3A9 File Offset: 0x000A95A9
		' (set) Token: 0x06001298 RID: 4760 RVA: 0x000AB3B3 File Offset: 0x000A95B3
		Friend Overridable Property txtRemarks As TextBox

		' Token: 0x17000720 RID: 1824
		' (get) Token: 0x06001299 RID: 4761 RVA: 0x000AB3BC File Offset: 0x000A95BC
		' (set) Token: 0x0600129A RID: 4762 RVA: 0x000AB3C8 File Offset: 0x000A95C8
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

		' Token: 0x17000721 RID: 1825
		' (get) Token: 0x0600129B RID: 4763 RVA: 0x000AB40B File Offset: 0x000A960B
		' (set) Token: 0x0600129C RID: 4764 RVA: 0x000AB418 File Offset: 0x000A9618
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

		' Token: 0x17000722 RID: 1826
		' (get) Token: 0x0600129D RID: 4765 RVA: 0x000AB45B File Offset: 0x000A965B
		' (set) Token: 0x0600129E RID: 4766 RVA: 0x000AB465 File Offset: 0x000A9665
		Friend Overridable Property skip_Label12 As Label

		' Token: 0x17000723 RID: 1827
		' (get) Token: 0x0600129F RID: 4767 RVA: 0x000AB46E File Offset: 0x000A966E
		' (set) Token: 0x060012A0 RID: 4768 RVA: 0x000AB478 File Offset: 0x000A9678
		Friend Overridable Property Label2 As Label

		' Token: 0x17000724 RID: 1828
		' (get) Token: 0x060012A1 RID: 4769 RVA: 0x000AB481 File Offset: 0x000A9681
		' (set) Token: 0x060012A2 RID: 4770 RVA: 0x000AB48B File Offset: 0x000A968B
		Friend Overridable Property cmbManager As ComboBox

		' Token: 0x17000725 RID: 1829
		' (get) Token: 0x060012A3 RID: 4771 RVA: 0x000AB494 File Offset: 0x000A9694
		' (set) Token: 0x060012A4 RID: 4772 RVA: 0x000AB49E File Offset: 0x000A969E
		Friend Overridable Property SrNo As DataGridViewTextBoxColumn

		' Token: 0x17000726 RID: 1830
		' (get) Token: 0x060012A5 RID: 4773 RVA: 0x000AB4A7 File Offset: 0x000A96A7
		' (set) Token: 0x060012A6 RID: 4774 RVA: 0x000AB4B1 File Offset: 0x000A96B1
		Friend Overridable Property ProductID As DataGridViewTextBoxColumn

		' Token: 0x17000727 RID: 1831
		' (get) Token: 0x060012A7 RID: 4775 RVA: 0x000AB4BA File Offset: 0x000A96BA
		' (set) Token: 0x060012A8 RID: 4776 RVA: 0x000AB4C4 File Offset: 0x000A96C4
		Friend Overridable Property ProductType As DataGridViewTextBoxColumn

		' Token: 0x17000728 RID: 1832
		' (get) Token: 0x060012A9 RID: 4777 RVA: 0x000AB4CD File Offset: 0x000A96CD
		' (set) Token: 0x060012AA RID: 4778 RVA: 0x000AB4D7 File Offset: 0x000A96D7
		Friend Overridable Property ProductCode As DataGridViewTextBoxColumn

		' Token: 0x17000729 RID: 1833
		' (get) Token: 0x060012AB RID: 4779 RVA: 0x000AB4E0 File Offset: 0x000A96E0
		' (set) Token: 0x060012AC RID: 4780 RVA: 0x000AB4EA File Offset: 0x000A96EA
		Friend Overridable Property ProductName As DataGridViewTextBoxColumn

		' Token: 0x1700072A RID: 1834
		' (get) Token: 0x060012AD RID: 4781 RVA: 0x000AB4F3 File Offset: 0x000A96F3
		' (set) Token: 0x060012AE RID: 4782 RVA: 0x000AB4FD File Offset: 0x000A96FD
		Friend Overridable Property Description As DataGridViewTextBoxColumn

		' Token: 0x1700072B RID: 1835
		' (get) Token: 0x060012AF RID: 4783 RVA: 0x000AB506 File Offset: 0x000A9706
		' (set) Token: 0x060012B0 RID: 4784 RVA: 0x000AB510 File Offset: 0x000A9710
		Friend Overridable Property HSNSACCode As DataGridViewTextBoxColumn

		' Token: 0x1700072C RID: 1836
		' (get) Token: 0x060012B1 RID: 4785 RVA: 0x000AB519 File Offset: 0x000A9719
		' (set) Token: 0x060012B2 RID: 4786 RVA: 0x000AB523 File Offset: 0x000A9723
		Friend Overridable Property TertiaryUOM As DataGridViewTextBoxColumn

		' Token: 0x1700072D RID: 1837
		' (get) Token: 0x060012B3 RID: 4787 RVA: 0x000AB52C File Offset: 0x000A972C
		' (set) Token: 0x060012B4 RID: 4788 RVA: 0x000AB536 File Offset: 0x000A9736
		Friend Overridable Property TertiaryPackSize As DataGridViewTextBoxColumn

		' Token: 0x1700072E RID: 1838
		' (get) Token: 0x060012B5 RID: 4789 RVA: 0x000AB53F File Offset: 0x000A973F
		' (set) Token: 0x060012B6 RID: 4790 RVA: 0x000AB549 File Offset: 0x000A9749
		Friend Overridable Property PrimaryUOM As DataGridViewTextBoxColumn

		' Token: 0x1700072F RID: 1839
		' (get) Token: 0x060012B7 RID: 4791 RVA: 0x000AB552 File Offset: 0x000A9752
		' (set) Token: 0x060012B8 RID: 4792 RVA: 0x000AB55C File Offset: 0x000A975C
		Friend Overridable Property PrimaryPackSize As DataGridViewTextBoxColumn

		' Token: 0x17000730 RID: 1840
		' (get) Token: 0x060012B9 RID: 4793 RVA: 0x000AB565 File Offset: 0x000A9765
		' (set) Token: 0x060012BA RID: 4794 RVA: 0x000AB56F File Offset: 0x000A976F
		Friend Overridable Property UnitPrice As DataGridViewTextBoxColumn

		' Token: 0x17000731 RID: 1841
		' (get) Token: 0x060012BB RID: 4795 RVA: 0x000AB578 File Offset: 0x000A9778
		' (set) Token: 0x060012BC RID: 4796 RVA: 0x000AB582 File Offset: 0x000A9782
		Friend Overridable Property Quantity As DataGridViewTextBoxColumn

		' Token: 0x17000732 RID: 1842
		' (get) Token: 0x060012BD RID: 4797 RVA: 0x000AB58B File Offset: 0x000A978B
		' (set) Token: 0x060012BE RID: 4798 RVA: 0x000AB595 File Offset: 0x000A9795
		Friend Overridable Property BasicValue As DataGridViewTextBoxColumn

		' Token: 0x17000733 RID: 1843
		' (get) Token: 0x060012BF RID: 4799 RVA: 0x000AB59E File Offset: 0x000A979E
		' (set) Token: 0x060012C0 RID: 4800 RVA: 0x000AB5A8 File Offset: 0x000A97A8
		Friend Overridable Property TaxPer As DataGridViewTextBoxColumn

		' Token: 0x17000734 RID: 1844
		' (get) Token: 0x060012C1 RID: 4801 RVA: 0x000AB5B1 File Offset: 0x000A97B1
		' (set) Token: 0x060012C2 RID: 4802 RVA: 0x000AB5BB File Offset: 0x000A97BB
		Friend Overridable Property TaxAmt As DataGridViewTextBoxColumn

		' Token: 0x17000735 RID: 1845
		' (get) Token: 0x060012C3 RID: 4803 RVA: 0x000AB5C4 File Offset: 0x000A97C4
		' (set) Token: 0x060012C4 RID: 4804 RVA: 0x000AB5CE File Offset: 0x000A97CE
		Friend Overridable Property NetAmt As DataGridViewTextBoxColumn

		' Token: 0x17000736 RID: 1846
		' (get) Token: 0x060012C5 RID: 4805 RVA: 0x000AB5D7 File Offset: 0x000A97D7
		' (set) Token: 0x060012C6 RID: 4806 RVA: 0x000AB5E1 File Offset: 0x000A97E1
		Friend Overridable Property OtherCharges As DataGridViewTextBoxColumn

		' Token: 0x17000737 RID: 1847
		' (get) Token: 0x060012C7 RID: 4807 RVA: 0x000AB5EA File Offset: 0x000A97EA
		' (set) Token: 0x060012C8 RID: 4808 RVA: 0x000AB5F4 File Offset: 0x000A97F4
		Friend Overridable Property FinalAmt As DataGridViewTextBoxColumn

		' Token: 0x060012C9 RID: 4809 RVA: 0x000AB600 File Offset: 0x000A9800
		Public Sub New(sForm As String, dr As DataRow)
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			AddHandler MyBase.Shown, AddressOf Me.Me_Shown
			Me.InitializeComponent()
			Me.sFormType = sForm
			Me.drData = dr
		End Sub

		' Token: 0x060012CA RID: 4810 RVA: 0x000AB664 File Offset: 0x000A9864
		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x060012CB RID: 4811 RVA: 0x000AB699 File Offset: 0x000A9899
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Designing.SetTheme(Me)
			Me.ClearForm()
			Me.FillCombo()
			Me.FillData()
			Me.SetForm()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x060012CC RID: 4812 RVA: 0x000AB6D6 File Offset: 0x000A98D6
		Private Sub Me_Shown(sender As Object, e As EventArgs)
			Me.SetTabs()
		End Sub

		' Token: 0x060012CD RID: 4813 RVA: 0x000AB6E0 File Offset: 0x000A98E0
		Private Sub SetTabs()
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = CInt(Math.Round(CDbl((Me.theme_tc.Width - 5)) / 3.0))
			Me.theme_tc.ItemSize = New Size(num, 30)
			Me.tab_lbl3.Width = num
			Me.tab_lbl5.Width = num + 3
			Me.tab_lbl6.Width = num + 3
			Me.tab_lbl3.Location = New Point(0, 0)
			Me.tab_lbl5.Location = New Point(num - 4, 0)
			Me.tab_lbl6.Location = New Point(num * 2 - 4, 0)
			Me.flpButton.Left = CInt(Math.Round(CDbl(MyBase.Width) / 2.0 - CDbl(Me.flpButton.Width) / 2.0))
		End Sub

		' Token: 0x060012CE RID: 4814 RVA: 0x000AB7C8 File Offset: 0x000A99C8
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
			Me.cmbDept.Enabled = False
			text = " SELECT UserID, UserName, LoginID, EmailID, Designation, Department, ManagerID, ReportingToID "
			text += " FROM [User] WHERE (IsActive = 1) ORDER BY UserName"
			Me.dtUser = MainModule.GetData(text)
			Me.cmbRequestedBy.ValueMember = "UserID"
			Me.cmbRequestedBy.DisplayMember = "LoginID"
			Me.cmbRequestedBy.DataSource = Me.dtUser
			Me.cmbRequestedBy.SelectedValue = GlobalVariables.gsUserID
			Me.FillManager()
		End Sub

		' Token: 0x060012CF RID: 4815 RVA: 0x000AB8E0 File Offset: 0x000A9AE0
		Private Sub FillManager()
			Dim text As String = " SELECT UserID, UserName, LoginID, EmailID, Designation, Department, ManagerID, ReportingToID "
			text += " FROM [User] WHERE (IsActive = 1) "
			text += " ORDER BY UserName"
			Me.dtManager = MainModule.GetData(text)
			Me.cmbManager.ValueMember = "UserID"
			Me.cmbManager.DisplayMember = "UserName"
			Me.cmbManager.DataSource = Me.dtManager
			Me.cmbManager.SelectedIndex = -1
			Dim flag As Boolean = Operators.CompareString(GlobalVariables.gsUserGroup, "Super Admin", False) <> 0
			If flag Then
				Me.cmbManager.Enabled = False
			End If
			Dim flag2 As Boolean = Me.cmbRequestedBy.SelectedIndex > -1
			If flag2 Then
				Dim dataRow As DataRow = Me.dtUser.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UserID = '", Me.cmbRequestedBy.SelectedValue), "'")))(0)
				Dim flag3 As Boolean = Operators.CompareString(dataRow("Department").ToString(), "", False) <> 0
				If flag3 Then
					Me.cmbDept.Text = dataRow("Department").ToString()
				End If
				Dim flag4 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("ReportingToID")))
				If flag4 Then
					Me.cmbManager.SelectedValue = RuntimeHelpers.GetObjectValue(dataRow("ReportingToID"))
				End If
			End If
		End Sub

		' Token: 0x060012D0 RID: 4816 RVA: 0x000ABA48 File Offset: 0x000A9C48
		Private Sub FillData()
			Try
				Dim flag As Boolean = Not Information.IsNothing(Me.drData)
				If flag Then
					Me.txtID.Text = Conversions.ToString(Me.drData("ID"))
					Me.txtNo.Text = Conversions.ToString(Me.drData("PRNo"))
					Me.dtpDt.Value = Conversions.ToDate(Me.drData("PRDt"))
					Dim flag2 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.drData("RequiredByDt")))
					If flag2 Then
						Me.dtpRequiredBy.Value = Conversions.ToDate(Me.drData("RequiredByDt"))
						Me.dtpRequiredBy.Checked = True
					Else
						Me.dtpRequiredBy.Value = DateAndTime.Now
						Me.dtpRequiredBy.Checked = False
					End If
					Me.cmbRequestedBy.SelectedValue = RuntimeHelpers.GetObjectValue(Me.drData("RequestedByID"))
					Me.FillManager()
					Dim flag3 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.drData("VendorID")))
					If flag3 Then
						Me.cmbVendor.SelectedValue = RuntimeHelpers.GetObjectValue(Me.drData("VendorID"))
					Else
						Me.cmbVendor.SelectedIndex = -1
					End If
					Me.txtRemarks.Text = Me.drData("Remarks").ToString()
					Me.txtRemarksApproval.Text = Me.drData("ActionRemarks").ToString()
					Dim flag4 As Boolean = Operators.CompareString(Me.txtRemarksApproval.Text, "", False) = 0
					If flag4 Then
						Me.lblRemarksApproval.Visible = False
					Else
						Me.lblRemarksApproval.Visible = True
					End If
					Dim text As String = "Select Status FROM PR WHERE PRID = '" + Me.txtID.Text + "'"
					Dim data As DataTable = MainModule.GetData(text)
					Me.skip_lblStatus.Text = Conversions.ToString(data.Rows(0)("Status"))
					Dim text2 As String = Me.skip_lblStatus.Text
					If Operators.CompareString(text2, "Rejected", False) <> 0 AndAlso Operators.CompareString(text2, "Cancelled", False) <> 0 Then
						Me.skip_lblStatus.ForeColor = Color.White
					Else
						Me.skip_lblStatus.ForeColor = Color.Red
					End If
					Me.FillItems()
					Me.dtFile = FileAttachments.FillFileAttachments(Me.Text, Me.txtID.Text)
					FileAttachments.SetFileDatagridview(Me.dtFile, Me.dgvFile)
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x060012D1 RID: 4817 RVA: 0x000ABD64 File Offset: 0x000A9F64
		Private Sub FillItems()
			Dim text As String = " SELECT ROW_NUMBER() OVER(ORDER BY PRItemsID) AS SrNo, PIs.ProductID, PIs.ProductType, " & vbCrLf
			text += " PIs.ProductName, PIs.ProductCode, PIs.Description, P.HSNSACCode, PIs.UnitPrice, PIs.Quantity, " & vbCrLf
			text += " P.TertiaryUOM, PIs.TertiaryPackSize, P.PrimaryUOM, PIs.PrimaryPackSize, " & vbCrLf
			text += " PIs.BasicValue, PIs.NetAmt, PIs.TaxPer, PIs.TaxAmt, " & vbCrLf
			text += " PIs.OtherCharges, PIs.FinalAmt" & vbCrLf
			text += " FROM PRItems AS PIs " & vbCrLf
			text += " LEFT JOIN Product AS P ON PIs.ProductID = P.ProductID" & vbCrLf
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				text = text + " WHERE PRID = '" + Me.txtID.Text + "'"
			Else
				text += " WHERE PRID = '0'"
			End If
			Me.dtItems = MainModule.GetData(text)
			Me.dgvDtls.DataSource = Me.dtItems
			Me.CalculateTotalAmt()
		End Sub

		' Token: 0x060012D2 RID: 4818 RVA: 0x000ABE30 File Offset: 0x000AA030
		Private Sub CalculateTotalAmt()
			Dim flag As Boolean = Me.dtItems.Rows.Count > 0
			If flag Then
				Me.txtTotal.Text = Strings.Format(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtItems.Compute("SUM(FinalAmt)", ""))), "#0.00")
			Else
				Me.txtTotal.Text = ""
			End If
		End Sub

		' Token: 0x060012D3 RID: 4819 RVA: 0x000ABEA8 File Offset: 0x000AA0A8
		Private Sub SetForm()
			Dim text As String = Me.sFormType
			If Operators.CompareString(text, "PR Add", False) <> 0 Then
				If Operators.CompareString(text, "PR Modify", False) <> 0 Then
					If Operators.CompareString(text, "PR Approval", False) <> 0 Then
						If Operators.CompareString(text, "PR Cost Approval", False) = 0 Then
							Me.Text = "PR Cost Approval"
							MyBase.TabText = "PR Cost Approval"
							Me.txtRemarks.[ReadOnly] = True
							Me.btnSave.Visible = False
							Me.btnClear.Visible = False
							Me.btnCancel.Visible = False
							Me.flpButton.Width = (Me.btnApprove.Width + 6) * 7 - Me.btnApprove.Width * 3
						End If
					Else
						Me.Text = "PR Approval"
						MyBase.TabText = "PR Approval"
						Me.txtRemarks.[ReadOnly] = True
						Me.btnSave.Visible = False
						Me.btnClear.Visible = False
						Me.btnCancel.Visible = False
						Me.flpButton.Width = (Me.btnApprove.Width + 6) * 7 - Me.btnApprove.Width * 3
					End If
				Else
					Me.Text = "PR Generation"
					MyBase.TabText = "PR Generation"
					Me.btnApprove.Visible = False
					Me.btnOnHold.Visible = False
					Me.btnReject.Visible = False
					Me.flpButton.Width = (Me.btnApprove.Width + 6) * 7 - Me.btnApprove.Width * 3
				End If
			Else
				Me.Text = "PR Generation"
				MyBase.TabText = "PR Generation"
				Dim flag As Boolean = (Operators.CompareString(GlobalVariables.gsUserGroup, "Super Admin", False) = 0) Or (Operators.CompareString(GlobalVariables.gsUserGroup, "Admin", False) = 0)
				If flag Then
					Me.dtpDt.Enabled = True
				Else
					Me.dtpDt.Enabled = False
				End If
				Me.btnApprove.Visible = False
				Me.btnOnHold.Visible = False
				Me.btnReject.Visible = False
				Me.btnCancel.Visible = False
				Me.flpButton.Width = (Me.btnApprove.Width + 6) * 7 - Me.btnApprove.Width * 4
			End If
			Dim text2 As String = Me.skip_lblStatus.Text
			Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(text2)
			If num <= 2512310814UI Then
				If num <= 325525889UI Then
					If num <> 322933498UI Then
						If num <> 325525889UI Then
							GoTo IL_06A0
						End If
						If Operators.CompareString(text2, "New P.R.", False) <> 0 Then
							GoTo IL_06A0
						End If
						GoTo IL_06A0
					Else
						If Operators.CompareString(text2, "In Cost Approval", False) <> 0 Then
							GoTo IL_06A0
						End If
						Dim text3 As String = Me.sFormType
						If Operators.CompareString(text3, "PR Modify", False) <> 0 Then
							If Operators.CompareString(text3, "PR Approval", False) <> 0 Then
								If Operators.CompareString(text3, "PR Cost Approval", False) <> 0 Then
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
						GoTo IL_06A0
					End If
				ElseIf num <> 1072715097UI Then
					If num <> 1728938442UI Then
						If num <> 2512310814UI Then
							GoTo IL_06A0
						End If
						If Operators.CompareString(text2, "On-Hold", False) <> 0 Then
							GoTo IL_06A0
						End If
					Else
						If Operators.CompareString(text2, "Cost Rejected", False) <> 0 Then
							GoTo IL_06A0
						End If
						GoTo IL_0635
					End If
				Else
					If Operators.CompareString(text2, "In Approval", False) <> 0 Then
						GoTo IL_06A0
					End If
					Dim text4 As String = Me.sFormType
					If Operators.CompareString(text4, "PR Modify", False) <> 0 Then
						If Operators.CompareString(text4, "PR Approval", False) <> 0 Then
							If Operators.CompareString(text4, "PR Cost Approval", False) = 0 Then
								Me.btnApprove.Enabled = False
								Me.btnOnHold.Enabled = False
								Me.btnReject.Enabled = False
							End If
						End If
					End If
					GoTo IL_06A0
				End If
			ElseIf num <= 3042809495UI Then
				If num <> 2787838396UI Then
					If num <> 3042809495UI Then
						GoTo IL_06A0
					End If
					If Operators.CompareString(text2, "PO Complete", False) <> 0 Then
						GoTo IL_06A0
					End If
					GoTo IL_0635
				Else
					If Operators.CompareString(text2, "Cancelled", False) <> 0 Then
						GoTo IL_06A0
					End If
					GoTo IL_0635
				End If
			ElseIf num <> 3456553687UI Then
				If num <> 3908468553UI Then
					If num <> 4031823975UI Then
						GoTo IL_06A0
					End If
					If Operators.CompareString(text2, "Rejected", False) <> 0 Then
						GoTo IL_06A0
					End If
					GoTo IL_0635
				ElseIf Operators.CompareString(text2, "Cost On-Hold", False) <> 0 Then
					GoTo IL_06A0
				End If
			Else
				If Operators.CompareString(text2, "Cost Approved", False) <> 0 Then
					GoTo IL_06A0
				End If
				Me.llbAdd.Enabled = False
				Me.llbFile.Enabled = False
				Me.btnSave.Enabled = False
				Me.btnClear.Enabled = False
				Me.btnCancel.Enabled = False
				Me.btnApprove.Enabled = False
				Me.btnOnHold.Enabled = False
				Me.btnReject.Enabled = False
				Dim flag2 As Boolean = (Operators.CompareString(GlobalVariables.gsUserGroup, "Super Admin", False) = 0) Or (Operators.CompareString(GlobalVariables.gsUserGroup, "Admin", False) = 0)
				If flag2 Then
					Me.btnCancel.Enabled = True
				End If
				GoTo IL_06A0
			End If
			Dim text5 As String = Me.sFormType
			If Operators.CompareString(text5, "PR Modify", False) <> 0 Then
				If Operators.CompareString(text5, "PR Approval", False) = 0 OrElse Operators.CompareString(text5, "PR Cost Approval", False) = 0 Then
					Me.btnApprove.Enabled = False
					Me.btnOnHold.Enabled = False
					Me.btnReject.Enabled = False
				End If
			End If
			GoTo IL_06A0
			IL_0635:
			Me.llbAdd.Enabled = False
			Me.llbFile.Enabled = False
			Me.btnSave.Enabled = False
			Me.btnClear.Enabled = False
			Me.btnCancel.Enabled = False
			Me.btnApprove.Enabled = False
			Me.btnOnHold.Enabled = False
			Me.btnReject.Enabled = False
			IL_06A0:
			Me.flpButton.Left = CInt(Math.Round(CDbl(MyBase.Width) / 2.0 - CDbl(Me.flpButton.Width) / 2.0))
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

		' Token: 0x060012D4 RID: 4820 RVA: 0x000AC62C File Offset: 0x000AA82C
		Private Sub txtID_TextChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) = 0
			If flag Then
				Me.btnCancel.Enabled = False
			Else
				Me.btnCancel.Enabled = True
			End If
		End Sub

		' Token: 0x060012D5 RID: 4821 RVA: 0x000AC678 File Offset: 0x000AA878
		Private Sub ClearForm()
			Me.txtID.Text = ""
			Me.txtNo.Text = ""
			Me.dtpDt.Value = DateAndTime.Now
			Me.cmbRequestedBy.SelectedIndex = -1
			Me.cmbDept.Text = ""
			Me.cmbManager.SelectedIndex = -1
			Me.cmbVendor.SelectedIndex = -1
			Me.FillItems()
			Me.txtRemarks.Text = ""
			Me.txtRemarksApproval.Text = ""
			Me.lblRemarks_Click(Nothing, Nothing)
			Me.dtFile = FileAttachments.CreateFileTable()
			FileAttachments.SetFileDatagridview(Me.dtFile, Me.dgvFile)
			Me.skip_lblStatus.Text = "New P.R."
			Me.btnSave.Enabled = True
		End Sub

		' Token: 0x060012D6 RID: 4822 RVA: 0x000AC75E File Offset: 0x000AA95E
		Private Sub btnClear_Click(sender As Object, e As EventArgs)
			Me.ClearForm()
		End Sub

		' Token: 0x060012D7 RID: 4823 RVA: 0x000AC768 File Offset: 0x000AA968
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x060012D8 RID: 4824 RVA: 0x000AC774 File Offset: 0x000AA974
		Private Sub cmbVendor_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbVendor.SelectedIndex = -1
			If flag Then
				Me.cmbVendor.Text = ""
			End If
		End Sub

		' Token: 0x060012D9 RID: 4825 RVA: 0x000AC7A8 File Offset: 0x000AA9A8
		Private Sub cmbRequestedBy_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbRequestedBy.SelectedIndex = -1
			If flag Then
				Me.cmbRequestedBy.Text = ""
			Else
				Dim dataRow As DataRow = Me.dtUser.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UserID = '", Me.cmbRequestedBy.SelectedValue), "'")))(0)
				Dim flag2 As Boolean = Operators.CompareString(dataRow("Department").ToString(), "", False) <> 0
				If flag2 Then
					Me.cmbDept.Text = dataRow("Department").ToString()
					Me.cmbDept.Enabled = False
				End If
				Me.FillManager()
			End If
		End Sub

		' Token: 0x060012DA RID: 4826 RVA: 0x000AC867 File Offset: 0x000AAA67
		Private Sub lblFile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Me.dtFile = FileAttachments.AttachmentFile(Conversions.ToString(-1), Me.dtFile)
			FileAttachments.SetFileDatagridview(Me.dtFile, Me.dgvFile)
		End Sub

		' Token: 0x060012DB RID: 4827 RVA: 0x000AC894 File Offset: 0x000AAA94
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

		' Token: 0x060012DC RID: 4828 RVA: 0x000AC988 File Offset: 0x000AAB88
		Private Sub llbAdd_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Dim pritems As PRItems = New PRItems(-1, Me.sFormType, Me.skip_lblStatus.Text, Me.dtItems)
			Dim flag As Boolean = pritems.ShowDialog() = DialogResult.OK
			If flag Then
				Me.dtItems = pritems.dtItems
				Me.dgvDtls.DataSource = Me.dtItems
				Me.CalculateTotalAmt()
			End If
		End Sub

		' Token: 0x060012DD RID: 4829 RVA: 0x000AC9E8 File Offset: 0x000AABE8
		Private Sub dgvDtls_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = (e.RowIndex > -1) And (e.ColumnIndex > -1)
			If flag Then
				Dim pritems As PRItems = New PRItems(e.RowIndex, Me.sFormType, Me.skip_lblStatus.Text, Me.dtItems)
				Dim flag2 As Boolean = pritems.ShowDialog() = DialogResult.OK
				If flag2 Then
					Me.dtItems = pritems.dtItems
					Me.dgvDtls.DataSource = Me.dtItems
					Me.CalculateTotalAmt()
					Me.ReorderSrNo()
				End If
			End If
		End Sub

		' Token: 0x060012DE RID: 4830 RVA: 0x000ACA70 File Offset: 0x000AAC70
		Private Sub ReorderSrNo()
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = Me.dtItems.Rows.Count - 1
			For i As Integer = 0 To num
				Me.dtItems.Rows(i)("SrNo") = i + 1
			Next
		End Sub

		' Token: 0x060012DF RID: 4831 RVA: 0x000ACAC4 File Offset: 0x000AACC4
		Private Function ValidateForm() As Boolean
			Dim flag As Boolean = Me.cmbRequestedBy.SelectedIndex = -1
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Select Requested By.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.cmbRequestedBy.Focus()
				flag2 = False
			Else
				Dim flag3 As Boolean = Me.cmbManager.SelectedIndex = -1
				If flag3 Then
					CustomMsgBox.Show("Select Manager.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.cmbManager.Focus()
					flag2 = False
				Else
					Dim flag4 As Boolean = Me.dtItems.Rows.Count = 0
					If flag4 Then
						CustomMsgBox.Show("No Product Added.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.llbAdd.Focus()
						flag2 = False
					Else
						flag2 = True
					End If
				End If
			End If
			Return flag2
		End Function

		' Token: 0x060012E0 RID: 4832 RVA: 0x000ACB80 File Offset: 0x000AAD80
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

		' Token: 0x060012E1 RID: 4833 RVA: 0x000ACBFC File Offset: 0x000AADFC
		Private Sub Save()
			Dim flag As Boolean = CustomMsgBox.Show("Save..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
			If flag Then
				Dim flag2 As Boolean = Not Me.ValidateForm()
				If Not flag2 Then
					Me.btnSave.Enabled = False
					Dim flag3 As Boolean = Operators.CompareString(Me.txtID.Text, "", False) = 0
					If flag3 Then
						Me.InsertData()
						Me.ConfigureSendMail("PR Creation", Me.txtID.Text, "Created")
					Else
						Me.UpdateData()
						Me.ConfigureSendMail("PR Modification", Me.txtID.Text, "Modified")
					End If
				End If
			End If
		End Sub

		' Token: 0x060012E2 RID: 4834 RVA: 0x000ACCAC File Offset: 0x000AAEAC
		Private Sub InsertData()
			Dim text As String = "EXEC usp_GetPRNo '" + Strings.Format(Me.dtpDt.Value, "MM/dd/yyyy") + "'"
			Dim dataTable As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				Dim text2 As String = Conversions.ToString(dataTable.Rows(0)("TrnNo"))
				Dim text3 As String = Conversions.ToString(Conversion.Val(Strings.Mid(text2, 12)))
				Dim text4 As String = "In Approval"
				Me.skip_lblStatus.Text = text4
				text = " INSERT INTO PR (SeqNo, PRNo, PRDt, RequestedBy, Department, ActionBy, " & vbCrLf
				text += " RequiredByDt, VendorID, Status, Remarks, CreationDt, CreatedBy) " & vbCrLf
				text = String.Concat(New String() { text, " VALUES('", text3, "', '", text2, "', '", Strings.Format(Me.dtpDt.Value, "MM/dd/yyyy"), "', " & vbCrLf })
				text = String.Concat(New String() { text, " '", Me.cmbRequestedBy.SelectedValue.ToString(), "', '", Me.cmbDept.Text, "', " & vbCrLf })
				Dim flag2 As Boolean = Me.cmbManager.SelectedIndex > -1
				If flag2 Then
					text = text + " '" + Me.cmbManager.SelectedValue.ToString() + "', " & vbCrLf
				Else
					text += " NULL, " & vbCrLf
				End If
				Dim checked As Boolean = Me.dtpRequiredBy.Checked
				If checked Then
					text = text + " '" + Strings.Format(Me.dtpRequiredBy.Value, "MM/dd/yyyy") + "', " & vbCrLf
				Else
					text += " NULL, " & vbCrLf
				End If
				Dim flag3 As Boolean = Me.cmbVendor.SelectedIndex > -1
				If flag3 Then
					text = text + " '" + Me.cmbVendor.SelectedValue.ToString() + "', " & vbCrLf
				Else
					text += " NULL, " & vbCrLf
				End If
				text = String.Concat(New String() { text, " '", text4, "', '", Strings.Trim(Me.txtRemarks.Text), "', GETDATE(), '", GlobalVariables.gsUserID, "')" & vbCrLf })
				text += " SELECT SCOPE_IDENTITY() AS ID"
				dataTable = MainModule.GetData(text)
				Dim flag4 As Boolean = dataTable.Rows.Count > 0
				If flag4 Then
					Me.txtID.Text = Conversions.ToString(dataTable.Rows(0)("ID"))
					Me.txtNo.Text = text2
					Me.InsertItems(Me.txtID.Text)
					FileAttachments.InsertFiles(Me.Text, Me.txtID.Text, Me.dtFile)
					Me.SetApprovalLevel()
					Dim text5 As String = "New ID : " + Me.txtID.Text + vbCrLf
					text5 = text5 + "PR No. : " + Me.txtNo.Text
					MainModule.TrnLog(Me.Text, "PR Generated", text5, Nothing)
					CustomMsgBox.Show("PR Generated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				End If
			End If
		End Sub

		' Token: 0x060012E3 RID: 4835 RVA: 0x000AD014 File Offset: 0x000AB214
		Private Sub UpdateData()
			Dim text As String = "In Approval"
			Me.skip_lblStatus.Text = text
			Dim text2 As String = String.Concat(New String() { " UPDATE PR SET RequestedBy = '", Me.cmbRequestedBy.SelectedValue.ToString(), "', Department = '", Me.cmbDept.Text, "', " & vbCrLf })
			Dim flag As Boolean = Me.cmbManager.SelectedIndex > -1
			If flag Then
				text2 = text2 + " ActionBy = '" + Me.cmbManager.SelectedValue.ToString() + "', " & vbCrLf
			Else
				text2 += " ActionBy = NULL, " & vbCrLf
			End If
			Dim checked As Boolean = Me.dtpRequiredBy.Checked
			If checked Then
				text2 = text2 + " RequiredByDt = '" + Strings.Format(Me.dtpRequiredBy.Value, "MM/dd/yyyy") + "', " & vbCrLf
			Else
				text2 += " RequiredByDt = NULL, " & vbCrLf
			End If
			Dim flag2 As Boolean = Me.cmbVendor.SelectedIndex > -1
			If flag2 Then
				text2 = text2 + " VendorID = '" + Me.cmbVendor.SelectedValue.ToString() + "', " & vbCrLf
			Else
				text2 += " VendorID = NULL, " & vbCrLf
			End If
			text2 = String.Concat(New String() { text2, " Remarks = '", Strings.Trim(Me.txtRemarks.Text), "', Status = '", text, "', " & vbCrLf })
			text2 = text2 + " ModificationDt = GETDATE(), ModifiedBy = '" + GlobalVariables.gsUserID + "'" & vbCrLf
			text2 = text2 + " WHERE PRID  = '" + Me.txtID.Text + "'"
			Dim flag3 As Boolean = MainModule.ExecuteSQL(text2) = 1
			If flag3 Then
				Me.InsertItems(Me.txtID.Text)
				FileAttachments.InsertFiles(Me.Text, Me.txtID.Text, Me.dtFile)
				Me.SetApprovalLevel()
				Dim text3 As String = "ID : " + Me.txtID.Text + vbCrLf
				text3 = text3 + "PR No. : " + Me.txtNo.Text
				MainModule.TrnLog(Me.Text, "PR Modified", text3, Nothing)
				CustomMsgBox.Show("PR Modified.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End If
		End Sub

		' Token: 0x060012E4 RID: 4836 RVA: 0x000AD268 File Offset: 0x000AB468
		Private Sub InsertItems(sID As String)
			Dim flag As Boolean = (Operators.CompareString(sID, "", False) <> 0) And (Me.dtItems.Rows.Count > 0)
			If flag Then
				Dim sqlConnection As SqlConnection = New SqlConnection(GlobalVariables.gsConStr)
				sqlConnection.Open()
				Dim sqlTransaction As SqlTransaction = sqlConnection.BeginTransaction(IsolationLevel.Serializable)
				Try
					Dim text As String = "DELETE FROM PRItems WHERE PRID = '" + sID + "'"
					Dim flag2 As Boolean = MainModule.ExecuteSQL(text, sqlConnection, sqlTransaction) = 1
					If flag2 Then
						Dim dataTable As DataTable = Me.dtItems.Copy()
						dataTable.Columns.Remove("SrNo")
						dataTable.Columns.Remove("HSNSACCode")
						dataTable.Columns.Remove("TertiaryUOM")
						dataTable.Columns.Remove("PrimaryUOM")
						Dim dataColumn As DataColumn = New DataColumn("PRID", GetType(Integer))
						dataColumn.DefaultValue = sID
						dataTable.Columns.Add(dataColumn)
						MainModule.BulkInsertTemp(dataTable, "PRItems", sqlConnection, sqlTransaction)
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

		' Token: 0x060012E5 RID: 4837 RVA: 0x000AD3EC File Offset: 0x000AB5EC
		Private Sub SetApprovalLevel()
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				Dim text As String = If(("EXEC usp_UpdatePRApprovalLevel " + Me.txtID.Text), "")
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text) = 1
				If flag2 Then
				End If
			End If
		End Sub

		' Token: 0x060012E6 RID: 4838 RVA: 0x000AD448 File Offset: 0x000AB648
		Private Sub btnApprove_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Dim text As String = Me.sFormType
				If Operators.CompareString(text, "PR Approval", False) <> 0 Then
					If Operators.CompareString(text, "PR Cost Approval", False) = 0 Then
						Me.Cost_Approve_Reject("Approved")
						Me.ConfigureSendMail("PR Cost Approval", Me.txtID.Text, "Cost Approved")
						Me.UnRegisteredProductMail()
					End If
				Else
					Me.Approve_Reject("Approved")
					Me.ConfigureSendMail("PR Approval", Me.txtID.Text, "Approved")
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

		' Token: 0x060012E7 RID: 4839 RVA: 0x000AD568 File Offset: 0x000AB768
		Private Sub btnReject_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Dim text As String = Me.sFormType
				If Operators.CompareString(text, "PR Approval", False) <> 0 Then
					If Operators.CompareString(text, "PR Cost Approval", False) = 0 Then
						Me.Cost_Approve_Reject("Rejected")
						Me.ConfigureSendMail("PR Cost Approval", Me.txtID.Text, "Cost Rejected")
					End If
				Else
					Me.Approve_Reject("Rejected")
					Me.ConfigureSendMail("PR Approval", Me.txtID.Text, "Rejected")
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnApprove.Enabled = True
				Me.btnReject.Enabled = True
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x060012E8 RID: 4840 RVA: 0x000AD664 File Offset: 0x000AB864
		Private Sub Approve_Reject(sStatus As String)
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				Dim text As String = "Approve PR..?"
				Dim text2 As String = "Approved"
				Dim flag2 As Boolean = Operators.CompareString(sStatus, "Rejected", False) = 0
				If flag2 Then
					text = "Reject PR..?"
					text2 = "Rejected"
				End If
				Dim flag3 As Boolean = CustomMsgBox.Show("Changes Cannot Be Reverted." & vbCrLf + text, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
				If flag3 Then
					Me.btnApprove.Enabled = False
					Me.btnOnHold.Enabled = False
					Me.btnReject.Enabled = False
					Me.btnCancel.Enabled = False
					Dim text3 As String = ""
					Dim flag4 As Boolean = Operators.CompareString(sStatus, "Rejected", False) = 0
					Dim text4 As String
					If flag4 Then
						text4 = "Rejection"
					Else
						sStatus = "In Cost Approval"
						text4 = "Approval"
					End If
					Dim captureReasons As CaptureReasons = New CaptureReasons(text4)
					Dim flag5 As Boolean = captureReasons.ShowDialog() = DialogResult.OK
					If flag5 Then
						text3 = text3 + "Action : " + sStatus + vbCrLf
						text3 = text3 + "Action By : " + GlobalVariables.gsUserName + vbCrLf
						text3 = text3 + "Action On : " + Strings.Format(MainModule.GetServerDate(), "dd-MMM-yyyy hh:mm:ss tt") + vbCrLf
						text3 = text3 + "Remarks : " + captureReasons.sRemarks + vbCrLf & vbCrLf
						Dim txtRemarksApproval As TextBox = Me.txtRemarksApproval
						Dim textBox As TextBox = txtRemarksApproval
						txtRemarksApproval.Text = textBox.Text + text3
						Me.lblRemarksApproval_Click(Nothing, Nothing)
						Dim text5 As String = String.Concat(New String() { " UPDATE PR SET Status = '", sStatus, "', ActionRemarks = '", Me.txtRemarksApproval.Text, "', " & vbCrLf })
						text5 = text5 + " ActionDt = GETDATE(), ActionBy = '" + GlobalVariables.gsUserID + "'" & vbCrLf
						text5 = text5 + " WHERE PRID = '" + Me.txtID.Text + "'"
						Dim flag6 As Boolean = MainModule.ExecuteSQL(text5) = 1
						If flag6 Then
							Dim text6 As String = "ID : " + Me.txtID.Text + vbCrLf
							text6 = text6 + "PR No. : " + Me.txtNo.Text
							Me.skip_lblStatus.Text = sStatus
							MainModule.TrnLog(Me.Text, If(("PR " + sStatus), ""), text6, Nothing)
							Me.Cost_Approve_Reject_Temp(sStatus)
							CustomMsgBox.Show("PR " + text2 + ".", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Else
							Me.btnApprove.Enabled = True
							Me.btnOnHold.Enabled = True
							Me.btnReject.Enabled = True
							Me.btnCancel.Enabled = True
						End If
					Else
						CustomMsgBox.Show("Remark For " + text4 + " Is Mandatory.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					End If
				End If
			End If
		End Sub

		' Token: 0x060012E9 RID: 4841 RVA: 0x000AD96C File Offset: 0x000ABB6C
		Private Sub Cost_Approve_Reject_Temp(sStatus As String)
			Dim flag As Boolean = Operators.CompareString(sStatus, "In Cost Approval", False) = 0
			If flag Then
				Dim text As String = " UPDATE PR SET Status = 'Cost Approved', " & vbCrLf
				text = text + " CostActionDt = GETDATE(), CostActionBy = '" + GlobalVariables.gsUserID + "'" & vbCrLf
				text = text + " WHERE PRID = '" + Me.txtID.Text + "'"
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text) = 1
				If flag2 Then
					Dim text2 As String = "ID : " + Me.txtID.Text + vbCrLf
					text2 = text2 + "PR No. : " + Me.txtNo.Text
					text2 += "Cost Approval Bypassed"
					Me.skip_lblStatus.Text = sStatus
					MainModule.TrnLog(Me.Text, If(("PR Cost " + sStatus), ""), text2, Nothing)
				End If
			End If
		End Sub

		' Token: 0x060012EA RID: 4842 RVA: 0x000ADA50 File Offset: 0x000ABC50
		Private Sub Cost_Approve_Reject(sStatus As String)
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				Dim text As String = "Approve PR..?"
				Dim flag2 As Boolean = Operators.CompareString(sStatus, "Rejected", False) = 0
				If flag2 Then
					text = "Reject PR..?"
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
						Dim text4 As String = String.Concat(New String() { " UPDATE PR SET Status = 'Cost ", sStatus, "', ActionRemarks = '", Me.txtRemarksApproval.Text, "', " & vbCrLf })
						text4 = text4 + " CostActionDt = GETDATE(), CostActionBy = '" + GlobalVariables.gsUserID + "'" & vbCrLf
						text4 = text4 + " WHERE PRID = '" + Me.txtID.Text + "'"
						Dim flag6 As Boolean = MainModule.ExecuteSQL(text4) = 1
						If flag6 Then
							Dim text5 As String = "ID : " + Me.txtID.Text + vbCrLf
							text5 = text5 + "PR No. : " + Me.txtNo.Text
							text5 += text2
							Me.skip_lblStatus.Text = sStatus
							MainModule.TrnLog(Me.Text, If(("PR Cost " + sStatus), ""), text5, Nothing)
							CustomMsgBox.Show("PR Cost " + sStatus + ".", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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

		' Token: 0x060012EB RID: 4843 RVA: 0x000ADD44 File Offset: 0x000ABF44
		Private Sub btnOnHold_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Dim flag As Boolean = CustomMsgBox.Show("Put On Hold..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
				If flag Then
					Dim text As String = Me.sFormType
					If Operators.CompareString(text, "PR Approval", False) <> 0 Then
						If Operators.CompareString(text, "PR Cost Approval", False) = 0 Then
							Me.Cost_OnHold()
							Me.ConfigureSendMail("PR Cost Approval", Me.txtID.Text, "Cost On-Hold")
						End If
					Else
						Me.OnHold()
						Me.ConfigureSendMail("PR Approval", Me.txtID.Text, "On-Hold")
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

		' Token: 0x060012EC RID: 4844 RVA: 0x000ADE6C File Offset: 0x000AC06C
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
				Dim text2 As String = " UPDATE PR SET Status = 'On-Hold', ActionRemarks = '" + Me.txtRemarksApproval.Text + "', " & vbCrLf
				text2 = text2 + " ActionDt = GETDATE(), ActionBy = '" + GlobalVariables.gsUserID + "'" & vbCrLf
				text2 = text2 + " WHERE PRID  = '" + Me.txtID.Text + "'"
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text2) = 1
				If flag2 Then
					Dim text3 As String = "ID : " + Me.txtID.Text + vbCrLf
					text3 = text3 + "PR No. : " + Me.txtNo.Text
					text3 += text
					Me.skip_lblStatus.Text = "On-Hold"
					MainModule.TrnLog(Me.Text, "PR On-Hold", text3, Nothing)
					CustomMsgBox.Show("PR On-Hold.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Else
					Me.btnApprove.Enabled = True
					Me.btnOnHold.Enabled = True
					Me.btnReject.Enabled = True
					Me.btnCancel.Enabled = True
				End If
			End If
		End Sub

		' Token: 0x060012ED RID: 4845 RVA: 0x000AE064 File Offset: 0x000AC264
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
				Dim text2 As String = " UPDATE PR SET Status = 'Cost On-Hold', ActionRemarks = '" + Me.txtRemarksApproval.Text + "', " & vbCrLf
				text2 = text2 + " CostActionDt = GETDATE(), CostActionBy = '" + GlobalVariables.gsUserID + "'" & vbCrLf
				text2 = text2 + " WHERE PRID  = '" + Me.txtID.Text + "'"
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text2) = 1
				If flag2 Then
					Dim text3 As String = "ID : " + Me.txtID.Text + vbCrLf
					text3 = text3 + "PR No. : " + Me.txtNo.Text
					text3 += text
					Me.skip_lblStatus.Text = "Cost On-Hold"
					MainModule.TrnLog(Me.Text, "PR Cost On-Hold", text3, Nothing)
					CustomMsgBox.Show("PR Cost On-Hold.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Else
					Me.btnApprove.Enabled = True
					Me.btnOnHold.Enabled = True
					Me.btnReject.Enabled = True
					Me.btnCancel.Enabled = True
				End If
			End If
		End Sub

		' Token: 0x060012EE RID: 4846 RVA: 0x000AE25C File Offset: 0x000AC45C
		Private Sub btnCancel_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.Cancelletion()
				EmailModule.SendMail("PR Cancellation", Me.txtID.Text, Me.sEmailTo, "")
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnCancel.Enabled = True
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x060012EF RID: 4847 RVA: 0x000AE2F8 File Offset: 0x000AC4F8
		Private Sub Cancelletion()
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				Dim flag2 As Boolean = CustomMsgBox.Show("Changes Cannot Be Reverted." & vbCrLf & "Cancel PR..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
				If flag2 Then
					Dim captureReasons As CaptureReasons = New CaptureReasons("Cancellation")
					Dim flag3 As Boolean = captureReasons.ShowDialog() = DialogResult.OK
					If flag3 Then
						Dim sRemarks As String = captureReasons.sRemarks
						Dim text As String = String.Concat(New String() { " UPDATE PR SET Status = 'Cancelled', CancelledBy = '", GlobalVariables.gsUserID, "', CancelledDt = GETDATE(), CancelledRemarks = '", sRemarks, "'" })
						text = text + " WHERE PRID = '" + Me.txtID.Text + "'"
						Dim flag4 As Boolean = MainModule.ExecuteSQL(text) = 1
						If flag4 Then
							Me.skip_lblStatus.Text = "Cancelled"
							Me.btnSave.Enabled = False
							Me.btnClear.Enabled = False
							Me.btnCancel.Enabled = False
							Me.btnApprove.Enabled = False
							Me.btnReject.Enabled = False
							Dim text2 As String = "ID : " + Me.txtID.Text + vbCrLf
							text2 = text2 + "PR No. : " + Me.txtNo.Text
							MainModule.TrnLog(Me.Text, "PR Cancelled", text2, Nothing)
							CustomMsgBox.Show("PR Cancelled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						End If
					Else
						CustomMsgBox.Show("Remark For Cancellation Is Mandatory.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					End If
				End If
			End If
		End Sub

		' Token: 0x060012F0 RID: 4848 RVA: 0x000AE49C File Offset: 0x000AC69C
		Private Sub lblRemarks_Click(sender As Object, e As EventArgs)
			Me.lblRemarks.BorderStyle = BorderStyle.FixedSingle
			Me.lblRemarksApproval.BorderStyle = BorderStyle.None
			Me.lblRemarks1.Visible = True
			Me.lblRemarksApproval1.Visible = False
			Me.txtRemarks.Visible = True
			Me.txtRemarksApproval.Visible = False
		End Sub

		' Token: 0x060012F1 RID: 4849 RVA: 0x000AE4F8 File Offset: 0x000AC6F8
		Private Sub lblRemarksApproval_Click(sender As Object, e As EventArgs)
			Me.lblRemarks.BorderStyle = BorderStyle.None
			Me.lblRemarksApproval.BorderStyle = BorderStyle.FixedSingle
			Me.lblRemarks1.Visible = False
			Me.lblRemarksApproval.Visible = True
			Me.lblRemarksApproval1.Visible = True
			Me.txtRemarks.Visible = False
			Me.txtRemarksApproval.Visible = True
		End Sub

		' Token: 0x060012F2 RID: 4850 RVA: 0x000AE564 File Offset: 0x000AC764
		Private Sub ConfigureSendMail(sType As String, sID As String, sTrn As String)
			Dim flag As Boolean = Me.cmbRequestedBy.SelectedIndex > -1
			If flag Then
				Dim array As DataRow() = Me.dtUser.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UserID = '", Me.cmbRequestedBy.SelectedValue), "'")))
				Dim array2 As DataRow() = Me.dtManager.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UserID = '", Me.cmbManager.SelectedValue), "'")))
				Dim ptr As __ByRef(Of String) = Me.sEmailTo
				Me.sEmailTo = ptr + ":" + array(0)("EmailID").ToString()
				ptr = Me.sEmailTo
				Me.sEmailTo = ptr + ":" + array2(0)("EmailID").ToString()
				EmailModule.SendMail(sType, sID, sTrn, Me.sEmailTo)
			End If
		End Sub

		' Token: 0x060012F3 RID: 4851 RVA: 0x000AE648 File Offset: 0x000AC848
		Private Sub UnRegisteredProductMail()
			Dim text As String = " SELECT P.Status, P.PRNo [PR. No.], FORMAT(P.PRDt,'dd-MMM-yyyy') [PR. Date], Req.UserName AS [Requested By], " & vbCrLf
			text += " P.Department, FORMAT(P.RequiredByDt,'dd-MMM-yyyy') [Required By Date], " & vbCrLf
			text += " PI.ProductType, PI.ProductCode, PI.ProductName " & vbCrLf
			text += " FROM PR AS P " & vbCrLf
			text += " LEFT OUTER JOIN [User] AS Action ON P.ActionBy = Action.UserID  " & vbCrLf
			text += " LEFT OUTER JOIN [User] AS CostAction ON P.ActionBy = CostAction.UserID " & vbCrLf
			text += " LEFT OUTER JOIN [User] AS Req ON P.RequestedBy = Req.UserID " & vbCrLf
			text += " INNER JOIN PRItems PI ON P.PRID = PI.PRID " & vbCrLf
			text += " LEFT OUTER JOIN Product Pr ON Pr.ProductID = PI.ProductID  " & vbCrLf
			text = text + " WHERE PI.ProductID = 0 AND P.Status = 'Cost Approved' AND P.PRID = '" + Me.txtID.Text + "'" & vbCrLf
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim text2 As String = Conversions.ToString(Me.dtUser.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UserID = '", Me.cmbRequestedBy.SelectedValue), "'")))(0)("EmailID"))
				EmailModule.Send_Unregistered_PR_Product_MailAlert(data, text2)
			End If
		End Sub

		' Token: 0x04000801 RID: 2049
		Private sFormType As String

		' Token: 0x04000802 RID: 2050
		Private sEmailTo As String

		' Token: 0x04000803 RID: 2051
		Private drData As DataRow

		' Token: 0x04000804 RID: 2052
		Private dtItems As DataTable

		' Token: 0x04000805 RID: 2053
		Private dtFile As DataTable

		' Token: 0x04000806 RID: 2054
		Private dtUser As DataTable

		' Token: 0x04000807 RID: 2055
		Private dtManager As DataTable
	End Class
End Namespace
