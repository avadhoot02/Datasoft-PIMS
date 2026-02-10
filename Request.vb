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
	' Token: 0x0200006A RID: 106
	<DesignerGenerated()>
	Public Partial Class Request
		Inherits DockContent

		' Token: 0x17000AFD RID: 2813
		' (get) Token: 0x06001C39 RID: 7225 RVA: 0x0010A75C File Offset: 0x0010895C
		' (set) Token: 0x06001C3A RID: 7226 RVA: 0x0010A766 File Offset: 0x00108966
		Friend Overridable Property Label7 As Label

		' Token: 0x17000AFE RID: 2814
		' (get) Token: 0x06001C3B RID: 7227 RVA: 0x0010A76F File Offset: 0x0010896F
		' (set) Token: 0x06001C3C RID: 7228 RVA: 0x0010A779 File Offset: 0x00108979
		Friend Overridable Property dtpExpDt As DateTimePicker

		' Token: 0x17000AFF RID: 2815
		' (get) Token: 0x06001C3D RID: 7229 RVA: 0x0010A782 File Offset: 0x00108982
		' (set) Token: 0x06001C3E RID: 7230 RVA: 0x0010A78C File Offset: 0x0010898C
		Friend Overridable Property Label8 As Label

		' Token: 0x17000B00 RID: 2816
		' (get) Token: 0x06001C3F RID: 7231 RVA: 0x0010A795 File Offset: 0x00108995
		' (set) Token: 0x06001C40 RID: 7232 RVA: 0x0010A7A0 File Offset: 0x001089A0
		Friend Overridable Property dtpMfgDt As DateTimePicker
			<CompilerGenerated()>
			Get
				Return Me._dtpMfgDt
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DateTimePicker)
				Dim eventHandler As EventHandler = AddressOf Me.dtpMfgDt_ValueChanged
				Dim dateTimePicker As DateTimePicker = Me._dtpMfgDt
				If dateTimePicker IsNot Nothing Then
					RemoveHandler dateTimePicker.ValueChanged, eventHandler
				End If
				Me._dtpMfgDt = value
				dateTimePicker = Me._dtpMfgDt
				If dateTimePicker IsNot Nothing Then
					AddHandler dateTimePicker.ValueChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000B01 RID: 2817
		' (get) Token: 0x06001C41 RID: 7233 RVA: 0x0010A7E3 File Offset: 0x001089E3
		' (set) Token: 0x06001C42 RID: 7234 RVA: 0x0010A7ED File Offset: 0x001089ED
		Friend Overridable Property Label6 As Label

		' Token: 0x17000B02 RID: 2818
		' (get) Token: 0x06001C43 RID: 7235 RVA: 0x0010A7F6 File Offset: 0x001089F6
		' (set) Token: 0x06001C44 RID: 7236 RVA: 0x0010A800 File Offset: 0x00108A00
		Friend Overridable Property txtBatchNo As TextBox

		' Token: 0x17000B03 RID: 2819
		' (get) Token: 0x06001C45 RID: 7237 RVA: 0x0010A809 File Offset: 0x00108A09
		' (set) Token: 0x06001C46 RID: 7238 RVA: 0x0010A814 File Offset: 0x00108A14
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

		' Token: 0x17000B04 RID: 2820
		' (get) Token: 0x06001C47 RID: 7239 RVA: 0x0010A857 File Offset: 0x00108A57
		' (set) Token: 0x06001C48 RID: 7240 RVA: 0x0010A861 File Offset: 0x00108A61
		Friend Overridable Property Label3 As Label

		' Token: 0x17000B05 RID: 2821
		' (get) Token: 0x06001C49 RID: 7241 RVA: 0x0010A86A File Offset: 0x00108A6A
		' (set) Token: 0x06001C4A RID: 7242 RVA: 0x0010A874 File Offset: 0x00108A74
		Friend Overridable Property cmbRequestedBy As ComboBox

		' Token: 0x17000B06 RID: 2822
		' (get) Token: 0x06001C4B RID: 7243 RVA: 0x0010A87D File Offset: 0x00108A7D
		' (set) Token: 0x06001C4C RID: 7244 RVA: 0x0010A887 File Offset: 0x00108A87
		Friend Overridable Property Label9 As Label

		' Token: 0x17000B07 RID: 2823
		' (get) Token: 0x06001C4D RID: 7245 RVA: 0x0010A890 File Offset: 0x00108A90
		' (set) Token: 0x06001C4E RID: 7246 RVA: 0x0010A89A File Offset: 0x00108A9A
		Friend Overridable Property dtpDt As DateTimePicker

		' Token: 0x17000B08 RID: 2824
		' (get) Token: 0x06001C4F RID: 7247 RVA: 0x0010A8A3 File Offset: 0x00108AA3
		' (set) Token: 0x06001C50 RID: 7248 RVA: 0x0010A8AD File Offset: 0x00108AAD
		Friend Overridable Property Label1 As Label

		' Token: 0x17000B09 RID: 2825
		' (get) Token: 0x06001C51 RID: 7249 RVA: 0x0010A8B6 File Offset: 0x00108AB6
		' (set) Token: 0x06001C52 RID: 7250 RVA: 0x0010A8C0 File Offset: 0x00108AC0
		Friend Overridable Property Label2 As Label

		' Token: 0x17000B0A RID: 2826
		' (get) Token: 0x06001C53 RID: 7251 RVA: 0x0010A8C9 File Offset: 0x00108AC9
		' (set) Token: 0x06001C54 RID: 7252 RVA: 0x0010A8D3 File Offset: 0x00108AD3
		Friend Overridable Property txtNo As TextBox

		' Token: 0x17000B0B RID: 2827
		' (get) Token: 0x06001C55 RID: 7253 RVA: 0x0010A8DC File Offset: 0x00108ADC
		' (set) Token: 0x06001C56 RID: 7254 RVA: 0x0010A8E6 File Offset: 0x00108AE6
		Friend Overridable Property GroupBox1 As GroupBox

		' Token: 0x17000B0C RID: 2828
		' (get) Token: 0x06001C57 RID: 7255 RVA: 0x0010A8EF File Offset: 0x00108AEF
		' (set) Token: 0x06001C58 RID: 7256 RVA: 0x0010A8F9 File Offset: 0x00108AF9
		Friend Overridable Property GroupBox2 As GroupBox

		' Token: 0x17000B0D RID: 2829
		' (get) Token: 0x06001C59 RID: 7257 RVA: 0x0010A902 File Offset: 0x00108B02
		' (set) Token: 0x06001C5A RID: 7258 RVA: 0x0010A90C File Offset: 0x00108B0C
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

		' Token: 0x17000B0E RID: 2830
		' (get) Token: 0x06001C5B RID: 7259 RVA: 0x0010A94F File Offset: 0x00108B4F
		' (set) Token: 0x06001C5C RID: 7260 RVA: 0x0010A959 File Offset: 0x00108B59
		Friend Overridable Property Panel1 As Panel

		' Token: 0x17000B0F RID: 2831
		' (get) Token: 0x06001C5D RID: 7261 RVA: 0x0010A962 File Offset: 0x00108B62
		' (set) Token: 0x06001C5E RID: 7262 RVA: 0x0010A96C File Offset: 0x00108B6C
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

		' Token: 0x17000B10 RID: 2832
		' (get) Token: 0x06001C5F RID: 7263 RVA: 0x0010A9AF File Offset: 0x00108BAF
		' (set) Token: 0x06001C60 RID: 7264 RVA: 0x0010A9BC File Offset: 0x00108BBC
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

		' Token: 0x17000B11 RID: 2833
		' (get) Token: 0x06001C61 RID: 7265 RVA: 0x0010A9FF File Offset: 0x00108BFF
		' (set) Token: 0x06001C62 RID: 7266 RVA: 0x0010AA0C File Offset: 0x00108C0C
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

		' Token: 0x17000B12 RID: 2834
		' (get) Token: 0x06001C63 RID: 7267 RVA: 0x0010AA4F File Offset: 0x00108C4F
		' (set) Token: 0x06001C64 RID: 7268 RVA: 0x0010AA5C File Offset: 0x00108C5C
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

		' Token: 0x17000B13 RID: 2835
		' (get) Token: 0x06001C65 RID: 7269 RVA: 0x0010AA9F File Offset: 0x00108C9F
		' (set) Token: 0x06001C66 RID: 7270 RVA: 0x0010AAAC File Offset: 0x00108CAC
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

		' Token: 0x17000B14 RID: 2836
		' (get) Token: 0x06001C67 RID: 7271 RVA: 0x0010AAEF File Offset: 0x00108CEF
		' (set) Token: 0x06001C68 RID: 7272 RVA: 0x0010AAF9 File Offset: 0x00108CF9
		Friend Overridable Property Label18 As Label

		' Token: 0x17000B15 RID: 2837
		' (get) Token: 0x06001C69 RID: 7273 RVA: 0x0010AB02 File Offset: 0x00108D02
		' (set) Token: 0x06001C6A RID: 7274 RVA: 0x0010AB0C File Offset: 0x00108D0C
		Friend Overridable Property cmbType As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbType
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbType_SelectedIndexChanged
				Dim comboBox As ComboBox = Me._cmbType
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.SelectedIndexChanged, eventHandler
				End If
				Me._cmbType = value
				comboBox = Me._cmbType
				If comboBox IsNot Nothing Then
					AddHandler comboBox.SelectedIndexChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000B16 RID: 2838
		' (get) Token: 0x06001C6B RID: 7275 RVA: 0x0010AB4F File Offset: 0x00108D4F
		' (set) Token: 0x06001C6C RID: 7276 RVA: 0x0010AB59 File Offset: 0x00108D59
		Friend Overridable Property txtID As TextBox

		' Token: 0x17000B17 RID: 2839
		' (get) Token: 0x06001C6D RID: 7277 RVA: 0x0010AB62 File Offset: 0x00108D62
		' (set) Token: 0x06001C6E RID: 7278 RVA: 0x0010AB6C File Offset: 0x00108D6C
		Friend Overridable Property skip_lblStatus As Label

		' Token: 0x17000B18 RID: 2840
		' (get) Token: 0x06001C6F RID: 7279 RVA: 0x0010AB75 File Offset: 0x00108D75
		' (set) Token: 0x06001C70 RID: 7280 RVA: 0x0010AB7F File Offset: 0x00108D7F
		Friend Overridable Property Label4 As Label

		' Token: 0x17000B19 RID: 2841
		' (get) Token: 0x06001C71 RID: 7281 RVA: 0x0010AB88 File Offset: 0x00108D88
		' (set) Token: 0x06001C72 RID: 7282 RVA: 0x0010AB94 File Offset: 0x00108D94
		Friend Overridable Property cmbDept As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbDept
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbDept_Validated
				Dim comboBox As ComboBox = Me._cmbDept
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.Validated, eventHandler
				End If
				Me._cmbDept = value
				comboBox = Me._cmbDept
				If comboBox IsNot Nothing Then
					AddHandler comboBox.Validated, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000B1A RID: 2842
		' (get) Token: 0x06001C73 RID: 7283 RVA: 0x0010ABD7 File Offset: 0x00108DD7
		' (set) Token: 0x06001C74 RID: 7284 RVA: 0x0010ABE1 File Offset: 0x00108DE1
		Friend Overridable Property txtBatchQty As TextBox

		' Token: 0x17000B1B RID: 2843
		' (get) Token: 0x06001C75 RID: 7285 RVA: 0x0010ABEA File Offset: 0x00108DEA
		' (set) Token: 0x06001C76 RID: 7286 RVA: 0x0010ABF4 File Offset: 0x00108DF4
		Friend Overridable Property Label5 As Label

		' Token: 0x17000B1C RID: 2844
		' (get) Token: 0x06001C77 RID: 7287 RVA: 0x0010ABFD File Offset: 0x00108DFD
		' (set) Token: 0x06001C78 RID: 7288 RVA: 0x0010AC08 File Offset: 0x00108E08
		Friend Overridable Property llbFill As LinkLabel
			<CompilerGenerated()>
			Get
				Return Me._llbFill
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim linkLabelLinkClickedEventHandler As LinkLabelLinkClickedEventHandler = AddressOf Me.llbFill_LinkClicked
				Dim linkLabel As LinkLabel = Me._llbFill
				If linkLabel IsNot Nothing Then
					RemoveHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
				Me._llbFill = value
				linkLabel = Me._llbFill
				If linkLabel IsNot Nothing Then
					AddHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000B1D RID: 2845
		' (get) Token: 0x06001C79 RID: 7289 RVA: 0x0010AC4B File Offset: 0x00108E4B
		' (set) Token: 0x06001C7A RID: 7290 RVA: 0x0010AC55 File Offset: 0x00108E55
		Friend Overridable Property Label11 As Label

		' Token: 0x17000B1E RID: 2846
		' (get) Token: 0x06001C7B RID: 7291 RVA: 0x0010AC5E File Offset: 0x00108E5E
		' (set) Token: 0x06001C7C RID: 7292 RVA: 0x0010AC68 File Offset: 0x00108E68
		Friend Overridable Property cmbBOM As ComboBox

		' Token: 0x17000B1F RID: 2847
		' (get) Token: 0x06001C7D RID: 7293 RVA: 0x0010AC71 File Offset: 0x00108E71
		' (set) Token: 0x06001C7E RID: 7294 RVA: 0x0010AC7C File Offset: 0x00108E7C
		Friend Overridable Property llbClearBOM As LinkLabel
			<CompilerGenerated()>
			Get
				Return Me._llbClearBOM
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim linkLabelLinkClickedEventHandler As LinkLabelLinkClickedEventHandler = AddressOf Me.llbClearBOM_LinkClicked
				Dim linkLabel As LinkLabel = Me._llbClearBOM
				If linkLabel IsNot Nothing Then
					RemoveHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
				Me._llbClearBOM = value
				linkLabel = Me._llbClearBOM
				If linkLabel IsNot Nothing Then
					AddHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000B20 RID: 2848
		' (get) Token: 0x06001C7F RID: 7295 RVA: 0x0010ACBF File Offset: 0x00108EBF
		' (set) Token: 0x06001C80 RID: 7296 RVA: 0x0010ACC9 File Offset: 0x00108EC9
		Friend Overridable Property Label12 As Label

		' Token: 0x17000B21 RID: 2849
		' (get) Token: 0x06001C81 RID: 7297 RVA: 0x0010ACD2 File Offset: 0x00108ED2
		' (set) Token: 0x06001C82 RID: 7298 RVA: 0x0010ACDC File Offset: 0x00108EDC
		Friend Overridable Property lblUnavailable As Label

		' Token: 0x17000B22 RID: 2850
		' (get) Token: 0x06001C83 RID: 7299 RVA: 0x0010ACE5 File Offset: 0x00108EE5
		' (set) Token: 0x06001C84 RID: 7300 RVA: 0x0010ACEF File Offset: 0x00108EEF
		Friend Overridable Property ProductID As DataGridViewTextBoxColumn

		' Token: 0x17000B23 RID: 2851
		' (get) Token: 0x06001C85 RID: 7301 RVA: 0x0010ACF8 File Offset: 0x00108EF8
		' (set) Token: 0x06001C86 RID: 7302 RVA: 0x0010AD02 File Offset: 0x00108F02
		Friend Overridable Property SrNo As DataGridViewTextBoxColumn

		' Token: 0x17000B24 RID: 2852
		' (get) Token: 0x06001C87 RID: 7303 RVA: 0x0010AD0B File Offset: 0x00108F0B
		' (set) Token: 0x06001C88 RID: 7304 RVA: 0x0010AD15 File Offset: 0x00108F15
		Friend Overridable Property ProductType As DataGridViewTextBoxColumn

		' Token: 0x17000B25 RID: 2853
		' (get) Token: 0x06001C89 RID: 7305 RVA: 0x0010AD1E File Offset: 0x00108F1E
		' (set) Token: 0x06001C8A RID: 7306 RVA: 0x0010AD28 File Offset: 0x00108F28
		Friend Overridable Property CatalogNo As DataGridViewTextBoxColumn

		' Token: 0x17000B26 RID: 2854
		' (get) Token: 0x06001C8B RID: 7307 RVA: 0x0010AD31 File Offset: 0x00108F31
		' (set) Token: 0x06001C8C RID: 7308 RVA: 0x0010AD3B File Offset: 0x00108F3B
		Friend Overridable Property ProductName As DataGridViewTextBoxColumn

		' Token: 0x17000B27 RID: 2855
		' (get) Token: 0x06001C8D RID: 7309 RVA: 0x0010AD44 File Offset: 0x00108F44
		' (set) Token: 0x06001C8E RID: 7310 RVA: 0x0010AD4E File Offset: 0x00108F4E
		Friend Overridable Property Description As DataGridViewTextBoxColumn

		' Token: 0x17000B28 RID: 2856
		' (get) Token: 0x06001C8F RID: 7311 RVA: 0x0010AD57 File Offset: 0x00108F57
		' (set) Token: 0x06001C90 RID: 7312 RVA: 0x0010AD61 File Offset: 0x00108F61
		Friend Overridable Property TertiaryUOM As DataGridViewTextBoxColumn

		' Token: 0x17000B29 RID: 2857
		' (get) Token: 0x06001C91 RID: 7313 RVA: 0x0010AD6A File Offset: 0x00108F6A
		' (set) Token: 0x06001C92 RID: 7314 RVA: 0x0010AD74 File Offset: 0x00108F74
		Friend Overridable Property TertiaryPackSize As DataGridViewTextBoxColumn

		' Token: 0x17000B2A RID: 2858
		' (get) Token: 0x06001C93 RID: 7315 RVA: 0x0010AD7D File Offset: 0x00108F7D
		' (set) Token: 0x06001C94 RID: 7316 RVA: 0x0010AD87 File Offset: 0x00108F87
		Friend Overridable Property PrimaryUOM As DataGridViewTextBoxColumn

		' Token: 0x17000B2B RID: 2859
		' (get) Token: 0x06001C95 RID: 7317 RVA: 0x0010AD90 File Offset: 0x00108F90
		' (set) Token: 0x06001C96 RID: 7318 RVA: 0x0010AD9A File Offset: 0x00108F9A
		Friend Overridable Property PrimaryPackSize As DataGridViewTextBoxColumn

		' Token: 0x17000B2C RID: 2860
		' (get) Token: 0x06001C97 RID: 7319 RVA: 0x0010ADA3 File Offset: 0x00108FA3
		' (set) Token: 0x06001C98 RID: 7320 RVA: 0x0010ADAD File Offset: 0x00108FAD
		Friend Overridable Property ReqQty As DataGridViewTextBoxColumn

		' Token: 0x17000B2D RID: 2861
		' (get) Token: 0x06001C99 RID: 7321 RVA: 0x0010ADB6 File Offset: 0x00108FB6
		' (set) Token: 0x06001C9A RID: 7322 RVA: 0x0010ADC0 File Offset: 0x00108FC0
		Friend Overridable Property PickedQty As DataGridViewTextBoxColumn

		' Token: 0x17000B2E RID: 2862
		' (get) Token: 0x06001C9B RID: 7323 RVA: 0x0010ADC9 File Offset: 0x00108FC9
		' (set) Token: 0x06001C9C RID: 7324 RVA: 0x0010ADD3 File Offset: 0x00108FD3
		Friend Overridable Property IssuedQty As DataGridViewTextBoxColumn

		' Token: 0x06001C9D RID: 7325 RVA: 0x0010ADDC File Offset: 0x00108FDC
		Public Sub New(sForm As String, dr As DataRow)
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.InitializeComponent()
			Me.sFormType = sForm
			Me.drData = dr
		End Sub

		' Token: 0x06001C9E RID: 7326 RVA: 0x0010AE2C File Offset: 0x0010902C
		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x06001C9F RID: 7327 RVA: 0x0010AE61 File Offset: 0x00109061
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Designing.SetTheme(Me)
			Me.ClearForm()
			Me.FillCombo()
			Me.FillData()
			Me.SetForm()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x06001CA0 RID: 7328 RVA: 0x0010AEA0 File Offset: 0x001090A0
		Private Sub FillCombo()
			Dim text As String = "SELECT DISTINCT Department FROM [User] ORDER BY Department"
			Dim data As DataTable = MainModule.GetData(text)
			Me.cmbDept.ValueMember = "Department"
			Me.cmbDept.DisplayMember = "Department"
			Me.cmbDept.DataSource = data
			Me.cmbDept.Text = GlobalVariables.gsDepartment
			Me.FillUsers()
		End Sub

		' Token: 0x06001CA1 RID: 7329 RVA: 0x0010AF04 File Offset: 0x00109104
		Private Sub FillData()
			Try
				Dim flag As Boolean = Not Information.IsNothing(Me.drData)
				If flag Then
					Me.txtID.Text = Conversions.ToString(Me.drData("ID"))
					Me.txtNo.Text = Conversions.ToString(Me.drData("RequestNo"))
					Me.dtpDt.Value = Conversions.ToDate(Me.drData("RequestDt"))
					Me.cmbDept.Text = Conversions.ToString(Me.drData("Department"))
					Me.cmbRequestedBy.SelectedValue = RuntimeHelpers.GetObjectValue(Me.drData("UserID"))
					Me.cmbType.Text = Conversions.ToString(Me.drData("ProductType"))
					Me.FillProduct()
					Me.cmbProduct.SelectedValue = RuntimeHelpers.GetObjectValue(Me.drData("ProductID"))
					Me.txtBatchNo.Text = Conversions.ToString(Me.drData("BatchNo"))
					Dim flag2 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.drData("MfgDt")))
					If flag2 Then
						Me.dtpMfgDt.Checked = True
						Me.dtpMfgDt.Value = Conversions.ToDate(Me.drData("MfgDt"))
					End If
					Dim flag3 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.drData("ExpDt")))
					If flag3 Then
						Me.dtpExpDt.Checked = True
						Me.dtpExpDt.Value = Conversions.ToDate(Me.drData("MfgDt"))
					End If
					Me.cmbBOM.Text = Me.drData("BOMVersion").ToString()
					Dim flag4 As Boolean = Operators.CompareString(Me.cmbBOM.Text, "", False) <> 0
					If flag4 Then
						Dim flag5 As Boolean = Strings.InStr(GlobalVariables.gsUserGroup.ToLower(), "admin", CompareMethod.Binary) = 0
						If flag5 Then
							Me.IsBOMFilled = True
						Else
							Me.IsBOMFilled = False
						End If
						Me.txtBatchQty.Text = Me.drData("BatchQty").ToString()
					End If
					Me.skip_lblStatus.Text = Conversions.ToString(Me.drData("Status"))
					Me.FillItems()
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06001CA2 RID: 7330 RVA: 0x0010B1E4 File Offset: 0x001093E4
		Private Sub FillItems()
			Dim text As String = " SELECT ROW_NUMBER() OVER(ORDER BY RequestDtlsID) AS SrNo, RD.ProductID, " & vbCrLf
			text += " P.ProductType, CatalogNo, P.ProductName, Description, " & vbCrLf
			text += " P.TertiaryUOM, P.TertiaryPackSize, P.PrimaryUOM, P.PrimaryPackSize, " & vbCrLf
			text += " RequiredQty, PickedQty, IssuedQty " & vbCrLf
			text += " FROM RequestDtls RD INNER JOIN Product P On RD.ProductID = P.ProductID  " & vbCrLf
			text += " LEFT OUTER JOIN " & vbCrLf
			text += " ( SELECT I.RequestID, ID.ProductID, " & vbCrLf
			text += "   CASE WHEN I.Status IN ('Picked', 'QA Approved') THEN COUNT(UID) ELSE 0 END PickedQty, " & vbCrLf
			text += "   CASE WHEN I.Status = 'Issued' THEN COUNT(UID) ELSE 0 END IssuedQty   " & vbCrLf
			text += "   FROM Issue I INNER JOIN IssueDtls ID ON I.IssueID = ID.IssueID " & vbCrLf
			text += "   WHERE I.Status NOT IN ('QA Rejected', 'Cancelled') " & vbCrLf
			text += "   GROUP BY I.RequestID, ID.ProductID, I.Status) " & vbCrLf
			text += " AS I ON I.RequestID = RD.RequestID AND I.ProductID = RD.ProductID " & vbCrLf
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				text = text + " WHERE RD.RequestID = '" + Me.txtID.Text + "'"
			Else
				text += " WHERE RD.RequestID = '0'"
			End If
			Me.dtItems = MainModule.GetData(text)
			Me.dgvDtls.DataSource = Me.dtItems
		End Sub

		' Token: 0x06001CA3 RID: 7331 RVA: 0x0010B2F0 File Offset: 0x001094F0
		Private Sub SetForm()
			Dim text As String = Me.skip_lblStatus.Text
			If Operators.CompareString(text, "New Request", False) <> 0 Then
				If Operators.CompareString(text, "Request Generated", False) <> 0 Then
					If Operators.CompareString(text, "In Picking", False) <> 0 Then
						If Operators.CompareString(text, "Issue Complete", False) = 0 OrElse Operators.CompareString(text, "Cancelled", False) = 0 Then
							Me.llbAdd.Enabled = False
							Me.llbFill.Enabled = False
							Me.llbClearBOM.Enabled = False
							Me.btnSave.Enabled = False
							Me.btnClear.Enabled = False
							Me.btnCancel.Enabled = False
							Me.cmbDept.Enabled = False
							Me.cmbRequestedBy.Enabled = False
							Me.cmbType.Enabled = False
							Me.cmbProduct.Enabled = False
							Me.cmbBOM.Enabled = False
							Me.dtpMfgDt.Enabled = False
							Me.dtpExpDt.Enabled = False
							Me.txtBatchNo.[ReadOnly] = True
						End If
					Else
						Me.llbAdd.Enabled = False
						Me.llbFill.Enabled = False
						Me.llbClearBOM.Enabled = False
						Me.btnClear.Enabled = False
						Me.btnCancel.Enabled = False
						Me.cmbDept.Enabled = False
						Me.cmbRequestedBy.Enabled = False
						Me.cmbType.Enabled = False
						Me.cmbProduct.Enabled = False
						Me.cmbBOM.Enabled = False
						Me.dtpMfgDt.Enabled = False
						Me.dtpExpDt.Enabled = False
						Me.txtBatchNo.[ReadOnly] = True
						Dim flag As Boolean = Strings.InStr(GlobalVariables.gsUserGroup.ToLower(), "admin", CompareMethod.Binary) = 0
						If flag Then
							Me.btnSave.Enabled = False
						End If
					End If
				End If
			Else
				Me.dgvDtls.Columns("PickedQty").Visible = False
				Me.dgvDtls.Columns("IssuedQty").Visible = False
				Me.btnCancel.Enabled = False
			End If
			Me.sEmailTo = GlobalVariables.gsEmailID
			Dim flag2 As Boolean = Not Information.IsNothing(Me.drData)
			If flag2 Then
				Dim flag3 As Boolean = (Operators.CompareString(Me.drData("CreatedByEmailID").ToString(), "", False) <> 0) And (Operators.CompareString(Me.drData("CreatedByEmailID").ToString(), GlobalVariables.gsEmailID, False) <> 0)
				If flag3 Then
					Dim ptr As __ByRef(Of String) = Me.sEmailTo
					Me.sEmailTo = ptr + ":" + Me.drData("CreatedByEmailID").ToString()
				End If
			End If
		End Sub

		' Token: 0x06001CA4 RID: 7332 RVA: 0x0010B5DC File Offset: 0x001097DC
		Private Sub cmbDept_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.cmbDept.Text, "", False) <> 0
			If flag Then
				Me.FillUsers()
			Else
				Me.cmbRequestedBy.DataSource = Nothing
			End If
		End Sub

		' Token: 0x06001CA5 RID: 7333 RVA: 0x0010B620 File Offset: 0x00109820
		Private Sub FillUsers()
			Dim text As String = "SELECT UserID, LoginID FROM [User] WHERE IsActive = 1 AND Department = '" + Me.cmbDept.Text + "' ORDER BY LoginID"
			Dim data As DataTable = MainModule.GetData(text)
			Me.cmbRequestedBy.ValueMember = "UserID"
			Me.cmbRequestedBy.DisplayMember = "LoginID"
			Me.cmbRequestedBy.DataSource = data
			Me.cmbRequestedBy.SelectedValue = GlobalVariables.gsUserID
		End Sub

		' Token: 0x06001CA6 RID: 7334 RVA: 0x0010B690 File Offset: 0x00109890
		Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.cmbType.Text, "", False) <> 0
			If flag Then
				Me.FillProduct()
			Else
				Me.cmbProduct.DataSource = Nothing
			End If
			Me.cmbProduct.SelectedIndex = -1
			Me.cmbProduct.Text = ""
		End Sub

		' Token: 0x06001CA7 RID: 7335 RVA: 0x0010B6F4 File Offset: 0x001098F4
		Private Sub FillProduct()
			Dim text As String = " SELECT ProductID, ProductCode, ProductName, ProductType, SpecificationNo, Reference, " & vbCrLf
			text += " TertiaryUOM, TertiaryPackSize, PrimaryUOM, PrimaryPackSize " & vbCrLf
			text += " CatalogNo, HSNSACCode, Expiry, UnitPrice, GSTPer, StorageCondition, " & vbCrLf
			text += " IsActive, IsGRNApplicable, IsQCApplicable, IsParentApplicable, IsUnitsEditable" & vbCrLf
			text += " FROM Product" & vbCrLf
			text = text + " WHERE ProductType IN ('" + Me.cmbType.Text + "') " & vbCrLf
			Dim flag As Boolean = Not Information.IsNothing(Me.drData)
			If flag Then
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" AND (IsActive = 1 OR ProductID = '", Me.drData("ProductID")), "') "), vbCrLf)))
			Else
				text += " AND IsActive = 1" & vbCrLf
			End If
			text += " ORDER BY ProductName" & vbCrLf
			Me.dtProduct = MainModule.GetData(text)
			Me.cmbProduct.ValueMember = "ProductID"
			Me.cmbProduct.DisplayMember = "ProductName"
			Me.cmbProduct.DataSource = Me.dtProduct
			Me.cmbProduct.SelectedIndex = -1
		End Sub

		' Token: 0x06001CA8 RID: 7336 RVA: 0x0010B80C File Offset: 0x00109A0C
		Private Sub cmbProduct_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbProduct.SelectedIndex > -1
			If flag Then
				Me.FillBOMCombo()
			Else
				Me.cmbBOM.DataSource = Nothing
			End If
		End Sub

		' Token: 0x06001CA9 RID: 7337 RVA: 0x0010B848 File Offset: 0x00109A48
		Private Sub FillBOMCombo()
			Dim text As String = " SELECT ROW_NUMBER() OVER(ORDER BY ProductBOMID) VersionID, ProductBOMID, "
			text += " ProductID, BOMVersion, BatchQty, EffectiveDt, ExpiryDt, IsActive " & vbCrLf
			text += " FROM ProductBOM " & vbCrLf
			text += " WHERE IsActive = 1 AND GETDATE() < ISNULL(ExpiryDt,'01/01/2060') " & vbCrLf
			text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" AND ProductID = '", Me.cmbProduct.SelectedValue), "'")))
			text += " AND Status = 'Approved'"
			Dim data As DataTable = MainModule.GetData(text)
			Me.cmbBOM.ValueMember = "ProductBOMID"
			Me.cmbBOM.DisplayMember = "BOMVersion"
			Me.cmbBOM.DataSource = data
			Me.cmbBOM.SelectedIndex = -1
		End Sub

		' Token: 0x06001CAA RID: 7338 RVA: 0x0010B8FA File Offset: 0x00109AFA
		Private Sub llbClearBOM_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Me.ClearBOM()
		End Sub

		' Token: 0x06001CAB RID: 7339 RVA: 0x0010B904 File Offset: 0x00109B04
		Private Sub ClearBOM()
			Me.FillBOMData("")
			Me.IsBOMFilled = False
			Me.cmbBOM.SelectedIndex = -1
			Me.cmbType.Enabled = True
			Me.cmbProduct.Enabled = True
			Me.cmbBOM.Enabled = True
			Me.cmbType.Focus()
		End Sub

		' Token: 0x06001CAC RID: 7340 RVA: 0x0010B968 File Offset: 0x00109B68
		Private Function ValidateFill() As Boolean
			Dim flag As Boolean = Me.cmbProduct.SelectedIndex = -1
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Select Manufacturing Product.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.cmbProduct.Focus()
				flag2 = False
			Else
				Dim flag3 As Boolean = Me.cmbBOM.SelectedIndex = -1
				If flag3 Then
					CustomMsgBox.Show("Select Manufacturing Product BOM Version.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.cmbBOM.Focus()
					flag2 = False
				Else
					flag2 = True
				End If
			End If
			Return flag2
		End Function

		' Token: 0x06001CAD RID: 7341 RVA: 0x0010B9E8 File Offset: 0x00109BE8
		Private Sub llbFill_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.FillBOM()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06001CAE RID: 7342 RVA: 0x0010BA54 File Offset: 0x00109C54
		Private Sub FillBOM()
			Dim flag As Boolean = Not Me.ValidateFill()
			If Not flag Then
				Me.FillBOMData(Conversions.ToString(Me.cmbBOM.SelectedValue))
				Dim flag2 As Boolean = Strings.InStr(GlobalVariables.gsUserGroup.ToLower(), "admin", CompareMethod.Binary) = 0
				If flag2 Then
					Me.IsBOMFilled = True
				End If
				Me.cmbType.Enabled = False
				Me.cmbProduct.Enabled = False
				Me.txtBatchQty.[ReadOnly] = True
				Me.cmbBOM.Enabled = False
			End If
		End Sub

		' Token: 0x06001CAF RID: 7343 RVA: 0x0010BAE4 File Offset: 0x00109CE4
		Private Sub FillBOMData(sBOMID As String)
			Dim flag As Boolean = (Operators.CompareString(sBOMID, "", False) <> 0) And (Operators.CompareString(Me.txtID.Text, "", False) = 0)
			Dim text As String
			If flag Then
				Dim dataTable As DataTable = CType(Me.cmbBOM.DataSource, DataTable)
				Me.txtBatchQty.Text = dataTable.[Select]("ProductBOMID = '" + sBOMID + "'")(0)("BatchQty").ToString()
				text = " SELECT IssueOrder SrNo, PB.MaterialID ProductID, " & vbCrLf
				text += " M.ProductType, M.CatalogNo, M.ProductName, '' Description, " & vbCrLf
				text += " M.TertiaryUOM, M.TertiaryPackSize, M.PrimaryUOM, M.PrimaryPackSize, " & vbCrLf
				text += " Qty RequiredQty, NULL PickedQty, NULL IssuedQty " & vbCrLf
				text += " FROM ProductBOMDtls PB" & vbCrLf
				text += " INNER JOIN Product AS M ON PB.MaterialID = M.ProductID" & vbCrLf
				text = text + " WHERE PB.ProductBOMID = '" + sBOMID + "'" & vbCrLf
			Else
				Me.txtBatchQty.Text = ""
				text = " SELECT IssueOrder SrNo, PB.MaterialID ProductID, " & vbCrLf
				text += " M.ProductType, M.CatalogNo, M.ProductName, '' Description, " & vbCrLf
				text += " M.TertiaryUOM, M.TertiaryPackSize, M.PrimaryUOM, M.PrimaryPackSize, " & vbCrLf
				text += " Qty RequiredQty, NULL PickedQty, NULL IssuedQty " & vbCrLf
				text += " FROM ProductBOMDtls PB" & vbCrLf
				text += " INNER JOIN Product AS M ON PB.MaterialID = M.ProductID" & vbCrLf
				text += " WHERE PB.ProductBOMID = '0'" & vbCrLf
			End If
			Me.dtItems = MainModule.GetData(text)
			Me.dgvDtls.DataSource = Me.dtItems
		End Sub

		' Token: 0x06001CB0 RID: 7344 RVA: 0x0010BC3C File Offset: 0x00109E3C
		Private Sub ClearForm()
			Me.txtID.Text = ""
			Me.txtNo.Text = ""
			Me.dtpDt.Value = DateAndTime.Now
			Me.cmbDept.Text = GlobalVariables.gsDepartment
			Me.FillUsers()
			Me.cmbRequestedBy.SelectedValue = GlobalVariables.gsUserID
			Me.cmbType.Text = ""
			Me.cmbProduct.SelectedIndex = -1
			Me.txtBatchNo.Text = ""
			Me.dtpMfgDt.Value = DateAndTime.Now
			Me.dtpMfgDt.Checked = False
			Me.dtpExpDt.Value = DateAndTime.Now
			Me.dtpExpDt.Checked = False
			Me.ClearBOM()
			Me.FillItems()
		End Sub

		' Token: 0x06001CB1 RID: 7345 RVA: 0x0010BD1F File Offset: 0x00109F1F
		Private Sub btnClear_Click(sender As Object, e As EventArgs)
			Me.ClearForm()
		End Sub

		' Token: 0x06001CB2 RID: 7346 RVA: 0x0010BD29 File Offset: 0x00109F29
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06001CB3 RID: 7347 RVA: 0x0010BD34 File Offset: 0x00109F34
		Private Sub dtpMfgDt_ValueChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.dtpMfgDt.Checked And (Me.cmbProduct.SelectedIndex > -1)
			If flag Then
				Dim array As DataRow() = Me.dtProduct.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("ProductID = '", Me.cmbProduct.SelectedValue), "'")))
				Dim flag2 As Boolean = array.Length > 0
				If flag2 Then
					Me.dtpExpDt.Value = DateAndTime.DateAdd(DateInterval.Day, -1.0, DateAndTime.DateAdd(DateInterval.Month, Conversion.Val(array(0)("Expiry").ToString()), Me.dtpMfgDt.Value))
					Return
				End If
			End If
			Me.dtpExpDt.Value = DateAndTime.Now
			Me.dtpExpDt.Checked = False
		End Sub

		' Token: 0x06001CB4 RID: 7348 RVA: 0x0010BE04 File Offset: 0x0010A004
		Private Sub llbAdd_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Dim flag As Boolean = Me.cmbProduct.SelectedIndex > -1
			If flag Then
				Dim flag2 As Boolean = Not Me.IsBOMFilled
				If flag2 Then
					Dim requestItems As RequestItems = New RequestItems(-1, Me.skip_lblStatus.Text, Me.dtItems, Conversions.ToString(Me.cmbProduct.SelectedValue), Me.cmbType.Text, Me.IsBOMFilled)
					requestItems.ShowDialog()
				Else
					CustomMsgBox.Show("Cannot Modify BOM List.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				End If
			Else
				CustomMsgBox.Show("Select Manufacturing Product.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.cmbProduct.Focus()
			End If
		End Sub

		' Token: 0x06001CB5 RID: 7349 RVA: 0x0010BEB0 File Offset: 0x0010A0B0
		Private Sub dgvDtls_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = (e.RowIndex > -1) And (e.ColumnIndex > -1)
			If flag Then
				Dim flag2 As Boolean = Me.cmbProduct.SelectedIndex > -1
				If flag2 Then
					Dim requestItems As RequestItems = New RequestItems(e.RowIndex, Me.skip_lblStatus.Text, Me.dtItems, Conversions.ToString(Me.cmbProduct.SelectedValue), Me.cmbType.Text, Me.IsBOMFilled)
					Dim flag3 As Boolean = requestItems.ShowDialog() = DialogResult.OK
					If flag3 Then
						Me.dtItems = requestItems.dtItems
						Me.dgvDtls.DataSource = Me.dtItems
						Me.ReorderSrNo()
					End If
				Else
					CustomMsgBox.Show("Select Manufacturing Product.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.cmbProduct.Focus()
				End If
			End If
		End Sub

		' Token: 0x06001CB6 RID: 7350 RVA: 0x0010BF84 File Offset: 0x0010A184
		Private Sub ReorderSrNo()
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = Me.dtItems.Rows.Count - 1
			For i As Integer = 0 To num
				Me.dtItems.Rows(i)("SrNo") = i + 1
			Next
		End Sub

		' Token: 0x06001CB7 RID: 7351 RVA: 0x0010BFD8 File Offset: 0x0010A1D8
		Private Function ValidateForm() As Boolean
			Dim flag As Boolean = Operators.CompareString(Me.cmbDept.Text, "", False) = 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Select/ Enter Department.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.cmbDept.Focus()
				flag2 = False
			Else
				Dim flag3 As Boolean = Me.cmbRequestedBy.SelectedIndex = -1
				If flag3 Then
					CustomMsgBox.Show("Select Vendor.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.cmbRequestedBy.Focus()
					flag2 = False
				Else
					Dim flag4 As Boolean = Me.cmbProduct.SelectedIndex = -1
					If flag4 Then
						CustomMsgBox.Show("Select Manufacturing Product.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.cmbProduct.Focus()
						flag2 = False
					Else
						Dim flag5 As Boolean = Me.dtItems.Rows.Count = 0
						If flag5 Then
							CustomMsgBox.Show("No Items Requested.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.llbAdd.Focus()
							flag2 = False
						Else
							Dim num As Integer = Me.dtItems.Rows.Count - 1
							For i As Integer = 0 To num
								Dim flag6 As Boolean = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(i)("RequiredQty"))) = 0.0
								If flag6 Then
									CustomMsgBox.Show("No Required Quantity Entered.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
									Me.dgvDtls.Rows(i).Cells("ReqQty").Selected = True
									Return False
								End If
							Next
							Dim flag7 As Boolean = Not Me.CheckStock()
							flag2 = Not flag7
						End If
					End If
				End If
			End If
			Return flag2
		End Function

		' Token: 0x06001CB8 RID: 7352 RVA: 0x0010C194 File Offset: 0x0010A394
		Private Function CheckStock() As Boolean
			Dim text As String = ""
			Dim num As Integer = Me.dtItems.Rows.Count - 1
			For i As Integer = 0 To num
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Me.dtItems.Rows(i)("ProductID")), "',")))
			Next
			Dim text2 As String = " SELECT P.ProductID, ProductCode, ProductName, ProductType, CatalogNo, " & vbCrLf
			text2 += " TertiaryUOM, TertiaryPackSize, PrimaryUOM, PrimaryPackSize, ISNULL(AvlQty,0) AvlQty " & vbCrLf
			text2 += " FROM Product P LEFT OUTER JOIN " & vbCrLf
			text2 += "   (SELECT ProductID, " & vbCrLf
			text2 += "    SUM(CASE WHEN ISNULL(ExpDt,'01/01/2050') > GETDATE() AND Status = 'Available' THEN 1 ELSE 0 END) AS AvlQty" & vbCrLf
			text2 += "    FROM GRNUID GROUP BY ProductID ) U ON P.ProductID = U.ProductID " & vbCrLf
			text2 = text2 + " WHERE P.ProductID IN (" + Strings.Mid(text, 1, text.Length - 1) + ")" & vbCrLf
			Dim data As DataTable = MainModule.GetData(text2)
			Dim flag As Boolean = True
			Dim num2 As Integer = Me.dgvDtls.Rows.Count - 1
			For j As Integer = 0 To num2
				Dim dataRow As DataRow = data.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("ProductID = '", Me.dgvDtls.Rows(j).Cells("ProductID").Value), "'")))(0)
				Dim flag2 As Boolean = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("AvlQty"))) < Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvDtls.Rows(j).Cells("ReqQty").Value))
				If flag2 Then
					flag = False
					Me.dgvDtls.Rows(j).DefaultCellStyle.ForeColor = Me.lblUnavailable.BackColor
				Else
					Me.dgvDtls.Rows(j).DefaultCellStyle.ForeColor = Color.Black
				End If
			Next
			Dim flag3 As Boolean = Not flag
			If flag3 Then
				Dim text3 As String = "Required Qty. Is Not Available For Some Items." & vbCrLf
				text3 += "Do You Still Want To Generate Request..?"
				Dim flag4 As Boolean = CustomMsgBox.Show(text3, "Critical", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No
				If flag4 Then
					Return False
				End If
			End If
			Return True
		End Function

		' Token: 0x06001CB9 RID: 7353 RVA: 0x0010C3D0 File Offset: 0x0010A5D0
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

		' Token: 0x06001CBA RID: 7354 RVA: 0x0010C44C File Offset: 0x0010A64C
		Private Sub Save()
			Dim flag As Boolean = CustomMsgBox.Show("Save..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
			If flag Then
				Dim flag2 As Boolean = Not Me.ValidateForm()
				If Not flag2 Then
					Me.btnSave.Enabled = False
					Dim flag3 As Boolean = Operators.CompareString(Me.txtID.Text, "", False) = 0
					If flag3 Then
						Me.InsertData()
						EmailModule.SendMail("Material Request", Me.txtID.Text, "Created", Me.sEmailTo)
					Else
						Me.UpdateData()
						EmailModule.SendMail("Material Request", Me.txtID.Text, "Modified", Me.sEmailTo)
					End If
				End If
			End If
		End Sub

		' Token: 0x06001CBB RID: 7355 RVA: 0x0010C50C File Offset: 0x0010A70C
		Private Sub InsertData()
			Dim text As String = "EXEC usp_GetRequestNo"
			Dim dataTable As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				Dim text2 As String = Conversions.ToString(dataTable.Rows(0)("TrnNo"))
				Dim text3 As String = "Request Generated"
				Me.skip_lblStatus.Text = text3
				text = " INSERT INTO Request (RequestNo, RequestDt, Department, RequestedBy, ProductID, " & vbCrLf
				text += " BatchNo, BatchQty, BOMVersion, MfgDt, ExpDt, Status, CreationDt, CreatedBy) " & vbCrLf
				text = String.Concat(New String() { text, " VALUES ('", text2, "', '", Strings.Format(Me.dtpDt.Value, "MM/dd/yyyy"), "', " & vbCrLf })
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" '" + Me.cmbDept.Text + "', '", Me.cmbRequestedBy.SelectedValue), "', "), vbCrLf)))
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" '", Me.cmbProduct.SelectedValue), "', '"), Strings.Trim(Me.txtBatchNo.Text)), "', "), vbCrLf)))
				text = String.Concat(New String() { text, " '", Conversions.ToString(Conversion.Val(Me.txtBatchQty.Text)), "', '", Me.cmbBOM.Text, "'," & vbCrLf })
				Dim checked As Boolean = Me.dtpMfgDt.Checked
				If checked Then
					text = text + " '" + Strings.Format(Me.dtpMfgDt.Value, "MM/dd/yyyy") + "', " & vbCrLf
				Else
					text += " NULL, " & vbCrLf
				End If
				Dim checked2 As Boolean = Me.dtpExpDt.Checked
				If checked2 Then
					text = text + " '" + Strings.Format(Me.dtpExpDt.Value, "MM/dd/yyyy") + "', " & vbCrLf
				Else
					text += " NULL, " & vbCrLf
				End If
				text = String.Concat(New String() { text, " '", text3, "', GETDATE(), '", GlobalVariables.gsUserID, "')" & vbCrLf })
				text += " SELECT SCOPE_IDENTITY() AS ID"
				dataTable = MainModule.GetData(text)
				Dim flag2 As Boolean = dataTable.Rows.Count > 0
				If flag2 Then
					Me.txtID.Text = Conversions.ToString(dataTable.Rows(0)("ID"))
					Me.txtNo.Text = text2
					Me.InsertItems()
					Dim text4 As String = "ID : " + Me.txtID.Text + vbCrLf
					text4 = text4 + "Trn No. : " + Me.txtNo.Text
					MainModule.TrnLog(Me.Text, "Request Generated", text4, Nothing)
					CustomMsgBox.Show("Request Generated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				End If
			End If
		End Sub

		' Token: 0x06001CBC RID: 7356 RVA: 0x0010C848 File Offset: 0x0010AA48
		Private Sub UpdateData()
			Dim text As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" UPDATE Request SET Department = '" + Me.cmbDept.Text + "', RequestedBy = '", Me.cmbRequestedBy.SelectedValue), "', "), vbCrLf))
			text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" ProductID = '", Me.cmbProduct.SelectedValue), "', BatchNo = '"), Strings.Trim(Me.txtBatchNo.Text)), "', "), vbCrLf)))
			text = String.Concat(New String() { text, " BOMVersion = '", Me.cmbBOM.Text, "', BatchQty = '", Conversions.ToString(Conversion.Val(Me.txtBatchQty.Text)), "', " & vbCrLf })
			Dim checked As Boolean = Me.dtpMfgDt.Checked
			If checked Then
				text = text + " MfgDt = '" + Strings.Format(Me.dtpMfgDt.Value, "MM/dd/yyyy") + "', " & vbCrLf
			Else
				text += " MfgDt = NULL, " & vbCrLf
			End If
			Dim checked2 As Boolean = Me.dtpExpDt.Checked
			If checked2 Then
				text = text + " ExpDt = '" + Strings.Format(Me.dtpExpDt.Value, "MM/dd/yyyy") + "', " & vbCrLf
			Else
				text += " ExpDt = NULL, " & vbCrLf
			End If
			text = text + " ModificationDt = GETDATE(), ModifiedBy = '" + GlobalVariables.gsUserID + "'" & vbCrLf
			text = text + " WHERE RequestID  = '" + Me.txtID.Text + "'"
			Dim flag As Boolean = MainModule.ExecuteSQL(text) = 1
			If flag Then
				Me.InsertItems()
				Dim text2 As String = "ID : " + Me.txtID.Text + vbCrLf
				text2 = text2 + "Trn No. : " + Me.txtNo.Text
				MainModule.TrnLog(Me.Text, "Request Modified", text2, Nothing)
				CustomMsgBox.Show("Request Modified.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End If
		End Sub

		' Token: 0x06001CBD RID: 7357 RVA: 0x0010CA78 File Offset: 0x0010AC78
		Private Sub InsertItems()
			Dim flag As Boolean = (Operators.CompareString(Me.txtID.Text, "", False) <> 0) And (Me.dtItems.Rows.Count > 0)
			If flag Then
				Dim sqlConnection As SqlConnection = New SqlConnection(GlobalVariables.gsConStr)
				sqlConnection.Open()
				Dim sqlTransaction As SqlTransaction = sqlConnection.BeginTransaction(IsolationLevel.Serializable)
				Try
					Dim text As String = "DELETE FROM RequestDtls WHERE RequestID = '" + Me.txtID.Text + "'"
					Dim flag2 As Boolean = MainModule.ExecuteSQL(text, sqlConnection, sqlTransaction) = 1
					If flag2 Then
						Dim dataTable As DataTable = Me.dtItems.Copy()
						dataTable.Columns.Remove("SrNo")
						dataTable.Columns.Remove("ProductType")
						dataTable.Columns.Remove("ProductName")
						dataTable.Columns.Remove("CatalogNo")
						dataTable.Columns.Remove("TertiaryUOM")
						dataTable.Columns.Remove("TertiaryPackSize")
						dataTable.Columns.Remove("PrimaryUOM")
						dataTable.Columns.Remove("PrimaryPackSize")
						dataTable.Columns.Remove("PickedQty")
						dataTable.Columns.Remove("IssuedQty")
						Dim dataColumn As DataColumn = New DataColumn("RequestID", GetType(Integer))
						dataColumn.DefaultValue = Me.txtID.Text
						dataTable.Columns.Add(dataColumn)
						MainModule.BulkInsertTemp(dataTable, "RequestDtls", sqlConnection, sqlTransaction)
						sqlTransaction.Commit()
						sqlConnection.Close()
						Return
					End If
				Catch ex As Exception
					CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				End Try
				sqlTransaction.Rollback()
				sqlConnection.Close()
			End If
		End Sub

		' Token: 0x06001CBE RID: 7358 RVA: 0x0010CC80 File Offset: 0x0010AE80
		Private Sub btnCancel_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.Cancelletion()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnCancel.Enabled = True
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06001CBF RID: 7359 RVA: 0x0010CCFC File Offset: 0x0010AEFC
		Private Sub Cancelletion()
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				Dim flag2 As Boolean = CustomMsgBox.Show("Changes Cannot Be Reverted." & vbCrLf & "Cancel Request..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
				If flag2 Then
					Dim captureReasons As CaptureReasons = New CaptureReasons("Cancellation")
					Dim flag3 As Boolean = captureReasons.ShowDialog() = DialogResult.OK
					If flag3 Then
						Dim sRemarks As String = captureReasons.sRemarks
						Dim text As String = String.Concat(New String() { " UPDATE Request SET Status = 'Cancelled', CancelledBy = '", GlobalVariables.gsUserID, "', CancelledDt = GETDATE(), CancelledRemarks = '", sRemarks, "'" })
						text = text + " WHERE RequestID = '" + Me.txtID.Text + "'"
						Dim flag4 As Boolean = MainModule.ExecuteSQL(text) = 1
						If flag4 Then
							Me.skip_lblStatus.Text = "Cancelled"
							Me.llbAdd.Enabled = False
							Me.llbFill.Enabled = False
							Me.llbClearBOM.Enabled = False
							Me.btnSave.Enabled = False
							Me.btnClear.Enabled = False
							Me.btnCancel.Enabled = False
							Dim text2 As String = "ID : " + Me.txtID.Text + vbCrLf
							text2 = text2 + "Trn No. : " + Me.txtNo.Text
							MainModule.TrnLog(Me.Text, "Request Cancelled", text2, Nothing)
							CustomMsgBox.Show("Request Cancelled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						End If
					Else
						CustomMsgBox.Show("Remark For Cancellation Is Mandatory.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					End If
				End If
			End If
		End Sub

		' Token: 0x04000C6D RID: 3181
		Private sFormType As String

		' Token: 0x04000C6E RID: 3182
		Private sEmailTo As String

		' Token: 0x04000C6F RID: 3183
		Private drData As DataRow

		' Token: 0x04000C70 RID: 3184
		Private dtItems As DataTable

		' Token: 0x04000C71 RID: 3185
		Private dtProduct As DataTable

		' Token: 0x04000C72 RID: 3186
		Private IsBOMFilled As Boolean
	End Class
End Namespace
