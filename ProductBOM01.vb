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
	' Token: 0x02000011 RID: 17
	<DesignerGenerated()>
	Public Partial Class ProductBOM01
		Inherits DockContent

		' Token: 0x1700005E RID: 94
		' (get) Token: 0x06000138 RID: 312 RVA: 0x0001163A File Offset: 0x0000F83A
		' (set) Token: 0x06000139 RID: 313 RVA: 0x00011644 File Offset: 0x0000F844
		Friend Overridable Property theme_tc As TabControl

		' Token: 0x1700005F RID: 95
		' (get) Token: 0x0600013A RID: 314 RVA: 0x0001164D File Offset: 0x0000F84D
		' (set) Token: 0x0600013B RID: 315 RVA: 0x00011657 File Offset: 0x0000F857
		Friend Overridable Property tpDetails As TabPage

		' Token: 0x17000060 RID: 96
		' (get) Token: 0x0600013C RID: 316 RVA: 0x00011660 File Offset: 0x0000F860
		' (set) Token: 0x0600013D RID: 317 RVA: 0x0001166A File Offset: 0x0000F86A
		Friend Overridable Property txtID As TextBox

		' Token: 0x17000061 RID: 97
		' (get) Token: 0x0600013E RID: 318 RVA: 0x00011673 File Offset: 0x0000F873
		' (set) Token: 0x0600013F RID: 319 RVA: 0x0001167D File Offset: 0x0000F87D
		Friend Overridable Property tab_lblDetails As Label

		' Token: 0x17000062 RID: 98
		' (get) Token: 0x06000140 RID: 320 RVA: 0x00011686 File Offset: 0x0000F886
		' (set) Token: 0x06000141 RID: 321 RVA: 0x00011690 File Offset: 0x0000F890
		Friend Overridable Property tpList As TabPage

		' Token: 0x17000063 RID: 99
		' (get) Token: 0x06000142 RID: 322 RVA: 0x00011699 File Offset: 0x0000F899
		' (set) Token: 0x06000143 RID: 323 RVA: 0x000116A3 File Offset: 0x0000F8A3
		Friend Overridable Property tab_lblList As Label

		' Token: 0x17000064 RID: 100
		' (get) Token: 0x06000144 RID: 324 RVA: 0x000116AC File Offset: 0x0000F8AC
		' (set) Token: 0x06000145 RID: 325 RVA: 0x000116B6 File Offset: 0x0000F8B6
		Friend Overridable Property grpProduct As GroupBox

		' Token: 0x17000065 RID: 101
		' (get) Token: 0x06000146 RID: 326 RVA: 0x000116BF File Offset: 0x0000F8BF
		' (set) Token: 0x06000147 RID: 327 RVA: 0x000116C9 File Offset: 0x0000F8C9
		Friend Overridable Property lblVersion As Label

		' Token: 0x17000066 RID: 102
		' (get) Token: 0x06000148 RID: 328 RVA: 0x000116D2 File Offset: 0x0000F8D2
		' (set) Token: 0x06000149 RID: 329 RVA: 0x000116DC File Offset: 0x0000F8DC
		Friend Overridable Property Label4 As Label

		' Token: 0x17000067 RID: 103
		' (get) Token: 0x0600014A RID: 330 RVA: 0x000116E5 File Offset: 0x0000F8E5
		' (set) Token: 0x0600014B RID: 331 RVA: 0x000116EF File Offset: 0x0000F8EF
		Friend Overridable Property Label19 As Label

		' Token: 0x17000068 RID: 104
		' (get) Token: 0x0600014C RID: 332 RVA: 0x000116F8 File Offset: 0x0000F8F8
		' (set) Token: 0x0600014D RID: 333 RVA: 0x00011702 File Offset: 0x0000F902
		Friend Overridable Property txtProductName As TextBox

		' Token: 0x17000069 RID: 105
		' (get) Token: 0x0600014E RID: 334 RVA: 0x0001170B File Offset: 0x0000F90B
		' (set) Token: 0x0600014F RID: 335 RVA: 0x00011718 File Offset: 0x0000F918
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

		' Token: 0x1700006A RID: 106
		' (get) Token: 0x06000150 RID: 336 RVA: 0x0001175B File Offset: 0x0000F95B
		' (set) Token: 0x06000151 RID: 337 RVA: 0x00011765 File Offset: 0x0000F965
		Friend Overridable Property Label18 As Label

		' Token: 0x1700006B RID: 107
		' (get) Token: 0x06000152 RID: 338 RVA: 0x0001176E File Offset: 0x0000F96E
		' (set) Token: 0x06000153 RID: 339 RVA: 0x00011778 File Offset: 0x0000F978
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

		' Token: 0x1700006C RID: 108
		' (get) Token: 0x06000154 RID: 340 RVA: 0x000117BB File Offset: 0x0000F9BB
		' (set) Token: 0x06000155 RID: 341 RVA: 0x000117C5 File Offset: 0x0000F9C5
		Friend Overridable Property Label9 As Label

		' Token: 0x1700006D RID: 109
		' (get) Token: 0x06000156 RID: 342 RVA: 0x000117CE File Offset: 0x0000F9CE
		' (set) Token: 0x06000157 RID: 343 RVA: 0x000117D8 File Offset: 0x0000F9D8
		Friend Overridable Property dtpExpiryDt As DateTimePicker

		' Token: 0x1700006E RID: 110
		' (get) Token: 0x06000158 RID: 344 RVA: 0x000117E1 File Offset: 0x0000F9E1
		' (set) Token: 0x06000159 RID: 345 RVA: 0x000117EB File Offset: 0x0000F9EB
		Friend Overridable Property Label2 As Label

		' Token: 0x1700006F RID: 111
		' (get) Token: 0x0600015A RID: 346 RVA: 0x000117F4 File Offset: 0x0000F9F4
		' (set) Token: 0x0600015B RID: 347 RVA: 0x000117FE File Offset: 0x0000F9FE
		Friend Overridable Property dtpEffectiveDt As DateTimePicker

		' Token: 0x17000070 RID: 112
		' (get) Token: 0x0600015C RID: 348 RVA: 0x00011807 File Offset: 0x0000FA07
		' (set) Token: 0x0600015D RID: 349 RVA: 0x00011811 File Offset: 0x0000FA11
		Friend Overridable Property Label3 As Label

		' Token: 0x17000071 RID: 113
		' (get) Token: 0x0600015E RID: 350 RVA: 0x0001181A File Offset: 0x0000FA1A
		' (set) Token: 0x0600015F RID: 351 RVA: 0x00011824 File Offset: 0x0000FA24
		Friend Overridable Property Lable5 As Label

		' Token: 0x17000072 RID: 114
		' (get) Token: 0x06000160 RID: 352 RVA: 0x0001182D File Offset: 0x0000FA2D
		' (set) Token: 0x06000161 RID: 353 RVA: 0x00011837 File Offset: 0x0000FA37
		Friend Overridable Property txtBOMVersion As TextBox

		' Token: 0x17000073 RID: 115
		' (get) Token: 0x06000162 RID: 354 RVA: 0x00011840 File Offset: 0x0000FA40
		' (set) Token: 0x06000163 RID: 355 RVA: 0x0001184A File Offset: 0x0000FA4A
		Friend Overridable Property chkIsActive As CheckBox

		' Token: 0x17000074 RID: 116
		' (get) Token: 0x06000164 RID: 356 RVA: 0x00011853 File Offset: 0x0000FA53
		' (set) Token: 0x06000165 RID: 357 RVA: 0x0001185D File Offset: 0x0000FA5D
		Friend Overridable Property skip_Label12 As Label

		' Token: 0x17000075 RID: 117
		' (get) Token: 0x06000166 RID: 358 RVA: 0x00011866 File Offset: 0x0000FA66
		' (set) Token: 0x06000167 RID: 359 RVA: 0x00011870 File Offset: 0x0000FA70
		Friend Overridable Property GbBasic As GroupBox

		' Token: 0x17000076 RID: 118
		' (get) Token: 0x06000168 RID: 360 RVA: 0x00011879 File Offset: 0x0000FA79
		' (set) Token: 0x06000169 RID: 361 RVA: 0x00011883 File Offset: 0x0000FA83
		Friend Overridable Property txtSBOMVersion As TextBox

		' Token: 0x17000077 RID: 119
		' (get) Token: 0x0600016A RID: 362 RVA: 0x0001188C File Offset: 0x0000FA8C
		' (set) Token: 0x0600016B RID: 363 RVA: 0x00011896 File Offset: 0x0000FA96
		Friend Overridable Property Label1 As Label

		' Token: 0x17000078 RID: 120
		' (get) Token: 0x0600016C RID: 364 RVA: 0x0001189F File Offset: 0x0000FA9F
		' (set) Token: 0x0600016D RID: 365 RVA: 0x000118A9 File Offset: 0x0000FAA9
		Friend Overridable Property txtSCatalogNo As TextBox

		' Token: 0x17000079 RID: 121
		' (get) Token: 0x0600016E RID: 366 RVA: 0x000118B2 File Offset: 0x0000FAB2
		' (set) Token: 0x0600016F RID: 367 RVA: 0x000118BC File Offset: 0x0000FABC
		Friend Overridable Property Label37 As Label

		' Token: 0x1700007A RID: 122
		' (get) Token: 0x06000170 RID: 368 RVA: 0x000118C5 File Offset: 0x0000FAC5
		' (set) Token: 0x06000171 RID: 369 RVA: 0x000118CF File Offset: 0x0000FACF
		Friend Overridable Property txtSName As TextBox

		' Token: 0x1700007B RID: 123
		' (get) Token: 0x06000172 RID: 370 RVA: 0x000118D8 File Offset: 0x0000FAD8
		' (set) Token: 0x06000173 RID: 371 RVA: 0x000118E2 File Offset: 0x0000FAE2
		Friend Overridable Property Label11 As Label

		' Token: 0x1700007C RID: 124
		' (get) Token: 0x06000174 RID: 372 RVA: 0x000118EB File Offset: 0x0000FAEB
		' (set) Token: 0x06000175 RID: 373 RVA: 0x000118F5 File Offset: 0x0000FAF5
		Friend Overridable Property txtSCode As TextBox

		' Token: 0x1700007D RID: 125
		' (get) Token: 0x06000176 RID: 374 RVA: 0x000118FE File Offset: 0x0000FAFE
		' (set) Token: 0x06000177 RID: 375 RVA: 0x00011908 File Offset: 0x0000FB08
		Friend Overridable Property Label14 As Label

		' Token: 0x1700007E RID: 126
		' (get) Token: 0x06000178 RID: 376 RVA: 0x00011911 File Offset: 0x0000FB11
		' (set) Token: 0x06000179 RID: 377 RVA: 0x0001191C File Offset: 0x0000FB1C
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

		' Token: 0x1700007F RID: 127
		' (get) Token: 0x0600017A RID: 378 RVA: 0x0001195F File Offset: 0x0000FB5F
		' (set) Token: 0x0600017B RID: 379 RVA: 0x00011969 File Offset: 0x0000FB69
		Friend Overridable Property GbAdvanced As GroupBox

		' Token: 0x17000080 RID: 128
		' (get) Token: 0x0600017C RID: 380 RVA: 0x00011972 File Offset: 0x0000FB72
		' (set) Token: 0x0600017D RID: 381 RVA: 0x0001197C File Offset: 0x0000FB7C
		Friend Overridable Property Label13 As Label

		' Token: 0x17000081 RID: 129
		' (get) Token: 0x0600017E RID: 382 RVA: 0x00011985 File Offset: 0x0000FB85
		' (set) Token: 0x0600017F RID: 383 RVA: 0x0001198F File Offset: 0x0000FB8F
		Friend Overridable Property cmbSType As ComboBox

		' Token: 0x17000082 RID: 130
		' (get) Token: 0x06000180 RID: 384 RVA: 0x00011998 File Offset: 0x0000FB98
		' (set) Token: 0x06000181 RID: 385 RVA: 0x000119A2 File Offset: 0x0000FBA2
		Friend Overridable Property Label8 As Label

		' Token: 0x17000083 RID: 131
		' (get) Token: 0x06000182 RID: 386 RVA: 0x000119AB File Offset: 0x0000FBAB
		' (set) Token: 0x06000183 RID: 387 RVA: 0x000119B5 File Offset: 0x0000FBB5
		Friend Overridable Property dtpFrom As DateTimePicker

		' Token: 0x17000084 RID: 132
		' (get) Token: 0x06000184 RID: 388 RVA: 0x000119BE File Offset: 0x0000FBBE
		' (set) Token: 0x06000185 RID: 389 RVA: 0x000119C8 File Offset: 0x0000FBC8
		Friend Overridable Property dtpTo As DateTimePicker

		' Token: 0x17000085 RID: 133
		' (get) Token: 0x06000186 RID: 390 RVA: 0x000119D1 File Offset: 0x0000FBD1
		' (set) Token: 0x06000187 RID: 391 RVA: 0x000119DB File Offset: 0x0000FBDB
		Friend Overridable Property Label16 As Label

		' Token: 0x17000086 RID: 134
		' (get) Token: 0x06000188 RID: 392 RVA: 0x000119E4 File Offset: 0x0000FBE4
		' (set) Token: 0x06000189 RID: 393 RVA: 0x000119EE File Offset: 0x0000FBEE
		Friend Overridable Property lblSDate As ComboBox

		' Token: 0x17000087 RID: 135
		' (get) Token: 0x0600018A RID: 394 RVA: 0x000119F7 File Offset: 0x0000FBF7
		' (set) Token: 0x0600018B RID: 395 RVA: 0x00011A04 File Offset: 0x0000FC04
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

		' Token: 0x17000088 RID: 136
		' (get) Token: 0x0600018C RID: 396 RVA: 0x00011A47 File Offset: 0x0000FC47
		' (set) Token: 0x0600018D RID: 397 RVA: 0x00011A51 File Offset: 0x0000FC51
		Friend Overridable Property grpListButton As GroupBox

		' Token: 0x17000089 RID: 137
		' (get) Token: 0x0600018E RID: 398 RVA: 0x00011A5A File Offset: 0x0000FC5A
		' (set) Token: 0x0600018F RID: 399 RVA: 0x00011A64 File Offset: 0x0000FC64
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x1700008A RID: 138
		' (get) Token: 0x06000190 RID: 400 RVA: 0x00011A6D File Offset: 0x0000FC6D
		' (set) Token: 0x06000191 RID: 401 RVA: 0x00011A78 File Offset: 0x0000FC78
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

		' Token: 0x1700008B RID: 139
		' (get) Token: 0x06000192 RID: 402 RVA: 0x00011ABB File Offset: 0x0000FCBB
		' (set) Token: 0x06000193 RID: 403 RVA: 0x00011AC8 File Offset: 0x0000FCC8
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

		' Token: 0x1700008C RID: 140
		' (get) Token: 0x06000194 RID: 404 RVA: 0x00011B0B File Offset: 0x0000FD0B
		' (set) Token: 0x06000195 RID: 405 RVA: 0x00011B18 File Offset: 0x0000FD18
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

		' Token: 0x1700008D RID: 141
		' (get) Token: 0x06000196 RID: 406 RVA: 0x00011B5B File Offset: 0x0000FD5B
		' (set) Token: 0x06000197 RID: 407 RVA: 0x00011B65 File Offset: 0x0000FD65
		Friend Overridable Property lblRows As Label

		' Token: 0x1700008E RID: 142
		' (get) Token: 0x06000198 RID: 408 RVA: 0x00011B6E File Offset: 0x0000FD6E
		' (set) Token: 0x06000199 RID: 409 RVA: 0x00011B78 File Offset: 0x0000FD78
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

		' Token: 0x1700008F RID: 143
		' (get) Token: 0x0600019A RID: 410 RVA: 0x00011BBB File Offset: 0x0000FDBB
		' (set) Token: 0x0600019B RID: 411 RVA: 0x00011BC5 File Offset: 0x0000FDC5
		Friend Overridable Property Label12 As Label

		' Token: 0x17000090 RID: 144
		' (get) Token: 0x0600019C RID: 412 RVA: 0x00011BCE File Offset: 0x0000FDCE
		' (set) Token: 0x0600019D RID: 413 RVA: 0x00011BD8 File Offset: 0x0000FDD8
		Friend Overridable Property Label15 As Label

		' Token: 0x17000091 RID: 145
		' (get) Token: 0x0600019E RID: 414 RVA: 0x00011BE1 File Offset: 0x0000FDE1
		' (set) Token: 0x0600019F RID: 415 RVA: 0x00011BEB File Offset: 0x0000FDEB
		Friend Overridable Property txtBatchQty As TextBox

		' Token: 0x17000092 RID: 146
		' (get) Token: 0x060001A0 RID: 416 RVA: 0x00011BF4 File Offset: 0x0000FDF4
		' (set) Token: 0x060001A1 RID: 417 RVA: 0x00011BFE File Offset: 0x0000FDFE
		Friend Overridable Property flpButton As FlowLayoutPanel

		' Token: 0x17000093 RID: 147
		' (get) Token: 0x060001A2 RID: 418 RVA: 0x00011C07 File Offset: 0x0000FE07
		' (set) Token: 0x060001A3 RID: 419 RVA: 0x00011C14 File Offset: 0x0000FE14
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

		' Token: 0x17000094 RID: 148
		' (get) Token: 0x060001A4 RID: 420 RVA: 0x00011C57 File Offset: 0x0000FE57
		' (set) Token: 0x060001A5 RID: 421 RVA: 0x00011C64 File Offset: 0x0000FE64
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

		' Token: 0x17000095 RID: 149
		' (get) Token: 0x060001A6 RID: 422 RVA: 0x00011CA7 File Offset: 0x0000FEA7
		' (set) Token: 0x060001A7 RID: 423 RVA: 0x00011CB4 File Offset: 0x0000FEB4
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

		' Token: 0x17000096 RID: 150
		' (get) Token: 0x060001A8 RID: 424 RVA: 0x00011CF7 File Offset: 0x0000FEF7
		' (set) Token: 0x060001A9 RID: 425 RVA: 0x00011D04 File Offset: 0x0000FF04
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

		' Token: 0x17000097 RID: 151
		' (get) Token: 0x060001AA RID: 426 RVA: 0x00011D47 File Offset: 0x0000FF47
		' (set) Token: 0x060001AB RID: 427 RVA: 0x00011D54 File Offset: 0x0000FF54
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

		' Token: 0x17000098 RID: 152
		' (get) Token: 0x060001AC RID: 428 RVA: 0x00011D97 File Offset: 0x0000FF97
		' (set) Token: 0x060001AD RID: 429 RVA: 0x00011DA4 File Offset: 0x0000FFA4
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

		' Token: 0x17000099 RID: 153
		' (get) Token: 0x060001AE RID: 430 RVA: 0x00011DE7 File Offset: 0x0000FFE7
		' (set) Token: 0x060001AF RID: 431 RVA: 0x00011DF4 File Offset: 0x0000FFF4
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

		' Token: 0x1700009A RID: 154
		' (get) Token: 0x060001B0 RID: 432 RVA: 0x00011E37 File Offset: 0x00010037
		' (set) Token: 0x060001B1 RID: 433 RVA: 0x00011E44 File Offset: 0x00010044
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

		' Token: 0x1700009B RID: 155
		' (get) Token: 0x060001B2 RID: 434 RVA: 0x00011E87 File Offset: 0x00010087
		' (set) Token: 0x060001B3 RID: 435 RVA: 0x00011E91 File Offset: 0x00010091
		Friend Overridable Property cmbIsActive As ComboBox

		' Token: 0x1700009C RID: 156
		' (get) Token: 0x060001B4 RID: 436 RVA: 0x00011E9A File Offset: 0x0001009A
		' (set) Token: 0x060001B5 RID: 437 RVA: 0x00011EA4 File Offset: 0x000100A4
		Friend Overridable Property Label17 As Label

		' Token: 0x1700009D RID: 157
		' (get) Token: 0x060001B6 RID: 438 RVA: 0x00011EAD File Offset: 0x000100AD
		' (set) Token: 0x060001B7 RID: 439 RVA: 0x00011EB7 File Offset: 0x000100B7
		Friend Overridable Property cmbStatus As ComboBox

		' Token: 0x1700009E RID: 158
		' (get) Token: 0x060001B8 RID: 440 RVA: 0x00011EC0 File Offset: 0x000100C0
		' (set) Token: 0x060001B9 RID: 441 RVA: 0x00011ECA File Offset: 0x000100CA
		Friend Overridable Property Panel1 As Panel

		' Token: 0x1700009F RID: 159
		' (get) Token: 0x060001BA RID: 442 RVA: 0x00011ED3 File Offset: 0x000100D3
		' (set) Token: 0x060001BB RID: 443 RVA: 0x00011EDD File Offset: 0x000100DD
		Friend Overridable Property theme_tcMaterial As TabControl

		' Token: 0x170000A0 RID: 160
		' (get) Token: 0x060001BC RID: 444 RVA: 0x00011EE6 File Offset: 0x000100E6
		' (set) Token: 0x060001BD RID: 445 RVA: 0x00011EF0 File Offset: 0x000100F0
		Friend Overridable Property tpItems As TabPage

		' Token: 0x170000A1 RID: 161
		' (get) Token: 0x060001BE RID: 446 RVA: 0x00011EF9 File Offset: 0x000100F9
		' (set) Token: 0x060001BF RID: 447 RVA: 0x00011F03 File Offset: 0x00010103
		Friend Overridable Property Panel2 As Panel

		' Token: 0x170000A2 RID: 162
		' (get) Token: 0x060001C0 RID: 448 RVA: 0x00011F0C File Offset: 0x0001010C
		' (set) Token: 0x060001C1 RID: 449 RVA: 0x00011F18 File Offset: 0x00010118
		Friend Overridable Property dgvBOM As DataGridView
			<CompilerGenerated()>
			Get
				Return Me._dgvBOM
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim dataGridViewCellEventHandler As DataGridViewCellEventHandler = AddressOf Me.dgvBOM_CellContentClick
				Dim dataGridView As DataGridView = Me._dgvBOM
				If dataGridView IsNot Nothing Then
					RemoveHandler dataGridView.CellContentClick, dataGridViewCellEventHandler
				End If
				Me._dgvBOM = value
				dataGridView = Me._dgvBOM
				If dataGridView IsNot Nothing Then
					AddHandler dataGridView.CellContentClick, dataGridViewCellEventHandler
				End If
			End Set
		End Property

		' Token: 0x170000A3 RID: 163
		' (get) Token: 0x060001C2 RID: 450 RVA: 0x00011F5B File Offset: 0x0001015B
		' (set) Token: 0x060001C3 RID: 451 RVA: 0x00011F65 File Offset: 0x00010165
		Friend Overridable Property ProductBOMID As DataGridViewTextBoxColumn

		' Token: 0x170000A4 RID: 164
		' (get) Token: 0x060001C4 RID: 452 RVA: 0x00011F6E File Offset: 0x0001016E
		' (set) Token: 0x060001C5 RID: 453 RVA: 0x00011F78 File Offset: 0x00010178
		Friend Overridable Property VersionID As DataGridViewTextBoxColumn

		' Token: 0x170000A5 RID: 165
		' (get) Token: 0x060001C6 RID: 454 RVA: 0x00011F81 File Offset: 0x00010181
		' (set) Token: 0x060001C7 RID: 455 RVA: 0x00011F8B File Offset: 0x0001018B
		Friend Overridable Property MaterialID As DataGridViewTextBoxColumn

		' Token: 0x170000A6 RID: 166
		' (get) Token: 0x060001C8 RID: 456 RVA: 0x00011F94 File Offset: 0x00010194
		' (set) Token: 0x060001C9 RID: 457 RVA: 0x00011F9E File Offset: 0x0001019E
		Friend Overridable Property IssueOrder As DataGridViewTextBoxColumn

		' Token: 0x170000A7 RID: 167
		' (get) Token: 0x060001CA RID: 458 RVA: 0x00011FA7 File Offset: 0x000101A7
		' (set) Token: 0x060001CB RID: 459 RVA: 0x00011FB1 File Offset: 0x000101B1
		Friend Overridable Property MaterialType As DataGridViewTextBoxColumn

		' Token: 0x170000A8 RID: 168
		' (get) Token: 0x060001CC RID: 460 RVA: 0x00011FBA File Offset: 0x000101BA
		' (set) Token: 0x060001CD RID: 461 RVA: 0x00011FC4 File Offset: 0x000101C4
		Friend Overridable Property MaterialCode As DataGridViewTextBoxColumn

		' Token: 0x170000A9 RID: 169
		' (get) Token: 0x060001CE RID: 462 RVA: 0x00011FCD File Offset: 0x000101CD
		' (set) Token: 0x060001CF RID: 463 RVA: 0x00011FD7 File Offset: 0x000101D7
		Friend Overridable Property MaterialName As DataGridViewTextBoxColumn

		' Token: 0x170000AA RID: 170
		' (get) Token: 0x060001D0 RID: 464 RVA: 0x00011FE0 File Offset: 0x000101E0
		' (set) Token: 0x060001D1 RID: 465 RVA: 0x00011FEA File Offset: 0x000101EA
		Friend Overridable Property PrimaryUOM As DataGridViewTextBoxColumn

		' Token: 0x170000AB RID: 171
		' (get) Token: 0x060001D2 RID: 466 RVA: 0x00011FF3 File Offset: 0x000101F3
		' (set) Token: 0x060001D3 RID: 467 RVA: 0x00011FFD File Offset: 0x000101FD
		Friend Overridable Property Qty As DataGridViewTextBoxColumn

		' Token: 0x170000AC RID: 172
		' (get) Token: 0x060001D4 RID: 468 RVA: 0x00012006 File Offset: 0x00010206
		' (set) Token: 0x060001D5 RID: 469 RVA: 0x00012010 File Offset: 0x00010210
		Friend Overridable Property btnDelete_BOM As DataGridViewImageColumn

		' Token: 0x170000AD RID: 173
		' (get) Token: 0x060001D6 RID: 470 RVA: 0x00012019 File Offset: 0x00010219
		' (set) Token: 0x060001D7 RID: 471 RVA: 0x00012023 File Offset: 0x00010223
		Friend Overridable Property Label10 As Label

		' Token: 0x170000AE RID: 174
		' (get) Token: 0x060001D8 RID: 472 RVA: 0x0001202C File Offset: 0x0001022C
		' (set) Token: 0x060001D9 RID: 473 RVA: 0x00012038 File Offset: 0x00010238
		Friend Overridable Property cmbMaterialType As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbMaterialType
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbMaterialType_Validated
				Dim comboBox As ComboBox = Me._cmbMaterialType
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.Validated, eventHandler
				End If
				Me._cmbMaterialType = value
				comboBox = Me._cmbMaterialType
				If comboBox IsNot Nothing Then
					AddHandler comboBox.Validated, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170000AF RID: 175
		' (get) Token: 0x060001DA RID: 474 RVA: 0x0001207B File Offset: 0x0001027B
		' (set) Token: 0x060001DB RID: 475 RVA: 0x00012085 File Offset: 0x00010285
		Friend Overridable Property Label5 As Label

		' Token: 0x170000B0 RID: 176
		' (get) Token: 0x060001DC RID: 476 RVA: 0x0001208E File Offset: 0x0001028E
		' (set) Token: 0x060001DD RID: 477 RVA: 0x00012098 File Offset: 0x00010298
		Friend Overridable Property Label6 As Label

		' Token: 0x170000B1 RID: 177
		' (get) Token: 0x060001DE RID: 478 RVA: 0x000120A1 File Offset: 0x000102A1
		' (set) Token: 0x060001DF RID: 479 RVA: 0x000120AB File Offset: 0x000102AB
		Friend Overridable Property Label7 As Label

		' Token: 0x170000B2 RID: 178
		' (get) Token: 0x060001E0 RID: 480 RVA: 0x000120B4 File Offset: 0x000102B4
		' (set) Token: 0x060001E1 RID: 481 RVA: 0x000120BE File Offset: 0x000102BE
		Friend Overridable Property txtQty As TextBox

		' Token: 0x170000B3 RID: 179
		' (get) Token: 0x060001E2 RID: 482 RVA: 0x000120C7 File Offset: 0x000102C7
		' (set) Token: 0x060001E3 RID: 483 RVA: 0x000120D4 File Offset: 0x000102D4
		Friend Overridable Property cmbMaterial As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbMaterial
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbMaterial_Validated
				Dim comboBox As ComboBox = Me._cmbMaterial
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.Validated, eventHandler
				End If
				Me._cmbMaterial = value
				comboBox = Me._cmbMaterial
				If comboBox IsNot Nothing Then
					AddHandler comboBox.Validated, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170000B4 RID: 180
		' (get) Token: 0x060001E4 RID: 484 RVA: 0x00012117 File Offset: 0x00010317
		' (set) Token: 0x060001E5 RID: 485 RVA: 0x00012121 File Offset: 0x00010321
		Friend Overridable Property Label40 As Label

		' Token: 0x170000B5 RID: 181
		' (get) Token: 0x060001E6 RID: 486 RVA: 0x0001212A File Offset: 0x0001032A
		' (set) Token: 0x060001E7 RID: 487 RVA: 0x00012134 File Offset: 0x00010334
		Friend Overridable Property llbAddItem As LinkLabel
			<CompilerGenerated()>
			Get
				Return Me._llbAddItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim linkLabelLinkClickedEventHandler As LinkLabelLinkClickedEventHandler = AddressOf Me.llbAddItem_LinkClicked
				Dim linkLabel As LinkLabel = Me._llbAddItem
				If linkLabel IsNot Nothing Then
					RemoveHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
				Me._llbAddItem = value
				linkLabel = Me._llbAddItem
				If linkLabel IsNot Nothing Then
					AddHandler linkLabel.LinkClicked, linkLabelLinkClickedEventHandler
				End If
			End Set
		End Property

		' Token: 0x170000B6 RID: 182
		' (get) Token: 0x060001E8 RID: 488 RVA: 0x00012177 File Offset: 0x00010377
		' (set) Token: 0x060001E9 RID: 489 RVA: 0x00012181 File Offset: 0x00010381
		Friend Overridable Property tab_lbl1 As Label

		' Token: 0x170000B7 RID: 183
		' (get) Token: 0x060001EA RID: 490 RVA: 0x0001218A File Offset: 0x0001038A
		' (set) Token: 0x060001EB RID: 491 RVA: 0x00012194 File Offset: 0x00010394
		Friend Overridable Property tpRemarks As TabPage

		' Token: 0x170000B8 RID: 184
		' (get) Token: 0x060001EC RID: 492 RVA: 0x0001219D File Offset: 0x0001039D
		' (set) Token: 0x060001ED RID: 493 RVA: 0x000121A7 File Offset: 0x000103A7
		Friend Overridable Property tab_lbl2 As Label

		' Token: 0x170000B9 RID: 185
		' (get) Token: 0x060001EE RID: 494 RVA: 0x000121B0 File Offset: 0x000103B0
		' (set) Token: 0x060001EF RID: 495 RVA: 0x000121BA File Offset: 0x000103BA
		Friend Overridable Property lblRemarksApproval1 As Label

		' Token: 0x170000BA RID: 186
		' (get) Token: 0x060001F0 RID: 496 RVA: 0x000121C3 File Offset: 0x000103C3
		' (set) Token: 0x060001F1 RID: 497 RVA: 0x000121CD File Offset: 0x000103CD
		Friend Overridable Property lblRemarks1 As Label

		' Token: 0x170000BB RID: 187
		' (get) Token: 0x060001F2 RID: 498 RVA: 0x000121D6 File Offset: 0x000103D6
		' (set) Token: 0x060001F3 RID: 499 RVA: 0x000121E0 File Offset: 0x000103E0
		Friend Overridable Property Panel4 As Panel

		' Token: 0x170000BC RID: 188
		' (get) Token: 0x060001F4 RID: 500 RVA: 0x000121E9 File Offset: 0x000103E9
		' (set) Token: 0x060001F5 RID: 501 RVA: 0x000121F3 File Offset: 0x000103F3
		Friend Overridable Property txtRemarksApproval As TextBox

		' Token: 0x170000BD RID: 189
		' (get) Token: 0x060001F6 RID: 502 RVA: 0x000121FC File Offset: 0x000103FC
		' (set) Token: 0x060001F7 RID: 503 RVA: 0x00012206 File Offset: 0x00010406
		Friend Overridable Property txtRemarks As TextBox

		' Token: 0x170000BE RID: 190
		' (get) Token: 0x060001F8 RID: 504 RVA: 0x0001220F File Offset: 0x0001040F
		' (set) Token: 0x060001F9 RID: 505 RVA: 0x0001221C File Offset: 0x0001041C
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

		' Token: 0x170000BF RID: 191
		' (get) Token: 0x060001FA RID: 506 RVA: 0x0001225F File Offset: 0x0001045F
		' (set) Token: 0x060001FB RID: 507 RVA: 0x0001226C File Offset: 0x0001046C
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

		' Token: 0x170000C0 RID: 192
		' (get) Token: 0x060001FC RID: 508 RVA: 0x000122AF File Offset: 0x000104AF
		' (set) Token: 0x060001FD RID: 509 RVA: 0x000122BC File Offset: 0x000104BC
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

		' Token: 0x170000C1 RID: 193
		' (get) Token: 0x060001FE RID: 510 RVA: 0x000122FF File Offset: 0x000104FF
		' (set) Token: 0x060001FF RID: 511 RVA: 0x00012309 File Offset: 0x00010509
		Friend Overridable Property Label20 As Label

		' Token: 0x170000C2 RID: 194
		' (get) Token: 0x06000200 RID: 512 RVA: 0x00012312 File Offset: 0x00010512
		' (set) Token: 0x06000201 RID: 513 RVA: 0x0001231C File Offset: 0x0001051C
		Friend Overridable Property txtActionByEmailID As TextBox

		' Token: 0x170000C3 RID: 195
		' (get) Token: 0x06000202 RID: 514 RVA: 0x00012325 File Offset: 0x00010525
		' (set) Token: 0x06000203 RID: 515 RVA: 0x0001232F File Offset: 0x0001052F
		Friend Overridable Property txtModifiedByEmailID As TextBox

		' Token: 0x170000C4 RID: 196
		' (get) Token: 0x06000204 RID: 516 RVA: 0x00012338 File Offset: 0x00010538
		' (set) Token: 0x06000205 RID: 517 RVA: 0x00012342 File Offset: 0x00010542
		Friend Overridable Property txtCreatedByEmailID As TextBox

		' Token: 0x06000206 RID: 518 RVA: 0x0001234C File Offset: 0x0001054C
		Public Sub New(sType As String)
			AddHandler MyBase.Shown, AddressOf Me.Me_Shown
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.InitializeComponent()
			Me.pnlBasicDefaultHeight = Me.GbBasic.Height
			Me.pnlBasicSetHeight = 23
			Me.pnlAdvDefaultHeight = 23
			Me.pnlAdvSetHeight = Me.GbAdvanced.Height
			Dim flag As Boolean = Operators.CompareString(sType, "On-Hold", False) = 0
			If flag Then
				Me.bOnHold = True
			Else
				Me.bOnHold = False
			End If
			Me.sFormType = Strings.Replace(sType, "On-Hold", "Entry", 1, -1, CompareMethod.Binary)
			Me.Text = "BOM " + Me.sFormType
			MyBase.TabText = "BOM " + Me.sFormType
		End Sub

		' Token: 0x06000207 RID: 519 RVA: 0x00012440 File Offset: 0x00010640
		Private Sub SetSearchPanel()
			Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
			Me.GbBasic.Height = Me.pnlBasicDefaultHeight
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
		End Sub

		' Token: 0x06000208 RID: 520 RVA: 0x00012494 File Offset: 0x00010694
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

		' Token: 0x06000209 RID: 521 RVA: 0x00012504 File Offset: 0x00010704
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

		' Token: 0x0600020A RID: 522 RVA: 0x00012574 File Offset: 0x00010774
		Private Sub Me_Shown(sender As Object, e As EventArgs)
			Me.SetTabs()
			Me.SetForm()
		End Sub

		' Token: 0x0600020B RID: 523 RVA: 0x00012588 File Offset: 0x00010788
		Private Sub SetTabs()
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = CInt(Math.Round(CDbl((Me.theme_tc.Width - 4)) / 2.0))
			Me.theme_tc.ItemSize = New Size(num, 30)
			Me.tab_lblDetails.Width = num
			Me.tab_lblList.Width = num + 3
			Me.tab_lblDetails.Location = New Point(0, 0)
			Me.tab_lblList.Location = New Point(num - 4, 0)
			Dim num2 As Integer = CInt(Math.Round(CDbl((Me.theme_tcMaterial.Width - 4)) / 2.0))
			Me.theme_tcMaterial.ItemSize = New Size(num2, 30)
			Me.tab_lbl1.Width = num2
			Me.tab_lbl2.Width = num2 + 3
			Me.tab_lbl1.Location = New Point(0, 0)
			Me.tab_lbl2.Location = New Point(num2 - 4, 0)
		End Sub

		' Token: 0x0600020C RID: 524 RVA: 0x00012684 File Offset: 0x00010884
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

		' Token: 0x0600020D RID: 525 RVA: 0x0001271C File Offset: 0x0001091C
		Private Sub Me_Load(sender As Object, e As EventArgs)
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

		' Token: 0x0600020E RID: 526 RVA: 0x00012782 File Offset: 0x00010982
		Private Sub FillCombo()
		End Sub

		' Token: 0x0600020F RID: 527 RVA: 0x00012788 File Offset: 0x00010988
		Private Sub SetForm()
			Dim text As String = Me.sFormType
			If Operators.CompareString(text, "Entry", False) <> 0 Then
				If Operators.CompareString(text, "Approval", False) = 0 Then
					Me.btnAdd.Visible = False
					Me.btnEdit.Visible = False
					Me.btnSave.Visible = False
					Me.btnClear.Visible = False
					Me.flpButton.Width = (Me.btnApprove.Width + 2) * 8 - Me.btnApprove.Width * 4
					Me.theme_tc.SelectedTab = Me.tpList
					Me.cmbStatus.Text = "Approval Pending"
					Me.SearchData("")
				End If
			Else
				Me.btnApprove.Visible = False
				Me.btnOnHold.Visible = False
				Me.btnReject.Visible = False
				Me.flpButton.Width = (Me.btnApprove.Width + 2) * 8 - Me.btnApprove.Width * 3
				Dim flag As Boolean = Me.bOnHold
				If flag Then
					Me.theme_tc.SelectedTab = Me.tpList
					Me.cmbStatus.Text = "On-Hold"
					Me.SearchData("")
				End If
			End If
			Me.flpButton.Left = CInt(Math.Round(CDbl(MyBase.Width) / 2.0 - CDbl(Me.flpButton.Width) / 2.0))
		End Sub

		' Token: 0x06000210 RID: 528 RVA: 0x00012920 File Offset: 0x00010B20
		Private Sub SetAccess(sAccess As String)
			If Operators.CompareString(sAccess, "ENABLE", False) <> 0 Then
				If Operators.CompareString(sAccess, "DISABLE", False) = 0 Then
					Me.txtID.[ReadOnly] = True
					Me.txtBatchQty.[ReadOnly] = True
					Me.txtBOMVersion.[ReadOnly] = True
					Me.txtQty.[ReadOnly] = True
					Me.cmbType.Enabled = False
					Me.cmbProduct.Enabled = False
					Me.dtpEffectiveDt.Enabled = False
					Me.dtpExpiryDt.Enabled = False
					Me.cmbMaterialType.Enabled = False
					Me.cmbMaterial.Enabled = False
					Me.chkIsActive.Enabled = False
					Me.llbAddItem.Enabled = False
					Me.txtRemarks.[ReadOnly] = True
					Me.dgvBOM.Columns("btnDelete_BOM").Visible = False
				End If
			Else
				Me.txtID.[ReadOnly] = False
				Me.txtBatchQty.[ReadOnly] = False
				Me.txtBOMVersion.[ReadOnly] = False
				Me.txtQty.[ReadOnly] = False
				Me.cmbType.Enabled = True
				Me.cmbProduct.Enabled = True
				Me.dtpEffectiveDt.Enabled = True
				Me.dtpExpiryDt.Enabled = True
				Me.cmbMaterialType.Enabled = True
				Me.cmbMaterial.Enabled = True
				Me.chkIsActive.Enabled = True
				Me.llbAddItem.Enabled = True
				Me.txtRemarks.[ReadOnly] = False
				Me.dgvBOM.Columns("btnDelete_BOM").Visible = True
			End If
		End Sub

		' Token: 0x06000211 RID: 529 RVA: 0x00012AEC File Offset: 0x00010CEC
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
			Dim text2 As String = Me.sFormType
			If Operators.CompareString(text2, "Entry", False) <> 0 Then
				If Operators.CompareString(text2, "Approval", False) = 0 Then
					Dim text3 As String = Me.skip_lblStatus.Text
					If Operators.CompareString(text3, "Approved", False) <> 0 AndAlso Operators.CompareString(text3, "Rejected", False) <> 0 Then
						If Operators.CompareString(text3, "On-Hold", False) = 0 Then
							Me.btnOnHold.Enabled = False
						End If
					Else
						Me.btnApprove.Enabled = False
						Me.btnOnHold.Enabled = False
						Me.btnReject.Enabled = False
					End If
				End If
			Else
				Dim text4 As String = Me.skip_lblStatus.Text
				If Operators.CompareString(text4, "Rejected", False) <> 0 Then
					If Operators.CompareString(text4, "Approved", False) = 0 Then
						Me.btnEdit.Enabled = False
					End If
				Else
					Me.btnEdit.Enabled = False
				End If
			End If
		End Sub

		' Token: 0x06000212 RID: 530 RVA: 0x00012D5C File Offset: 0x00010F5C
		Private Sub ClearForm()
			Me.txtID.Text = ""
			Me.txtBOMVersion.Text = ""
			Me.txtBatchQty.Text = ""
			Me.lblVersion.Text = ""
			Me.lblVersion.Visible = False
			Me.cmbType.Text = ""
			Me.cmbProduct.DataSource = Nothing
			Me.cmbProduct.Text = ""
			Me.txtProductName.Text = ""
			Me.dtpEffectiveDt.Value = DateAndTime.Now
			Me.dtpExpiryDt.Value = DateAndTime.Now
			Me.dtpEffectiveDt.Checked = False
			Me.dtpExpiryDt.Checked = False
			Me.cmbMaterialType.Text = ""
			Me.cmbMaterial.DataSource = Nothing
			Me.cmbMaterial.Text = ""
			Me.txtQty.Text = ""
			Me.chkIsActive.Checked = True
			Me.txtRemarks.Text = ""
			Me.txtRemarksApproval.Text = ""
			Me.lblRemarks_Click(Nothing, Nothing)
			Me.txtCreatedByEmailID.Text = ""
			Me.txtModifiedByEmailID.Text = ""
			Me.txtActionByEmailID.Text = ""
			Me.skip_lblStatus.Text = ""
			Me.FillBOM("")
			Me.SetAccess("DISABLE")
		End Sub

		' Token: 0x06000213 RID: 531 RVA: 0x00012F0C File Offset: 0x0001110C
		Private Sub ClearList()
			Me.lblSDate.SelectedIndex = 0
			Me.txtSCode.Text = ""
			Me.txtSCatalogNo.Text = ""
			Me.txtSName.Text = ""
			Me.txtSBOMVersion.Text = ""
			Me.cmbSType.Text = ""
			Me.cmbStatus.SelectedIndex = 0
			Me.cmbIsActive.Text = ""
			Me.dtpFrom.Value = DateAndTime.Now
			Me.dtpTo.Value = DateAndTime.Now
			Me.dtpFrom.Checked = False
			Me.dtpTo.Checked = False
			Me.lblRows.Text = "0 - Rows"
		End Sub

		' Token: 0x06000214 RID: 532 RVA: 0x00012FE7 File Offset: 0x000111E7
		Private Sub btnClear_Click(sender As Object, e As EventArgs)
			Me.ClearForm()
			Me.sStatus = "LOAD"
			Me.SetButtonStatus()
		End Sub

		' Token: 0x06000215 RID: 533 RVA: 0x00013003 File Offset: 0x00011203
		Private Sub btnClearList_Click(sender As Object, e As EventArgs)
			Me.ClearList()
		End Sub

		' Token: 0x06000216 RID: 534 RVA: 0x0001300D File Offset: 0x0001120D
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06000217 RID: 535 RVA: 0x00013017 File Offset: 0x00011217
		Private Sub btnExport_Click(sender As Object, e As EventArgs)
			MainModule.ExportToExcel(Me.dgvList, Me.Text)
		End Sub

		' Token: 0x06000218 RID: 536 RVA: 0x0001302C File Offset: 0x0001122C
		Private Sub btnAdd_Click(sender As Object, e As EventArgs)
			Me.ClearForm()
			Me.SetAccess("ENABLE")
			Me.sStatus = "ADD"
			Me.SetButtonStatus()
			Me.chkIsActive.Checked = True
			Me.cmbType.Focus()
		End Sub

		' Token: 0x06000219 RID: 537 RVA: 0x00013078 File Offset: 0x00011278
		Private Sub btnEdit_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				Me.SetAccess("ENABLE")
				Me.sStatus = "EDIT"
				Me.SetButtonStatus()
			End If
		End Sub

		' Token: 0x0600021A RID: 538 RVA: 0x000130C4 File Offset: 0x000112C4
		Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.cmbType.Text, "", False) <> 0
			If flag Then
				Me.FillProduct()
			Else
				Me.cmbProduct.DataSource = Nothing
			End If
			Me.lblVersion.Text = ""
			Me.lblVersion.Visible = False
			Me.cmbMaterialType.Text = ""
			Me.cmbMaterial.DataSource = Nothing
			Me.txtQty.Text = ""
			Me.FillBOM("")
			Me.cmbMaterialType.Items.Clear()
			Me.cmbMaterialType.Items.Add("")
			Me.cmbMaterialType.Items.Add("Raw Material")
			Me.cmbMaterialType.Items.Add("Packaging Material")
			Me.cmbMaterialType.Items.Add("Consumable")
			Me.cmbMaterialType.Items.Add("Semi Finished")
			Me.cmbMaterialType.Items.Add("Cell Bank - Mammalian")
			Me.cmbMaterialType.Items.Add("Cell Bank - Bacterial")
			Dim text As String = Me.cmbType.Text
			If Operators.CompareString(text, "Finished Goods", False) <> 0 Then
				If Operators.CompareString(text, "Semi Finished", False) <> 0 Then
					If Operators.CompareString(text, "Cell Bank - Mammalian", False) = 0 OrElse Operators.CompareString(text, "Cell Bank - Bacterial", False) = 0 Then
						Me.cmbMaterialType.Items.Remove("Finished Goods")
						Me.cmbMaterialType.Items.Remove("Semi Finished")
						Me.cmbMaterialType.Items.Remove("Cell Bank - Mammalian")
						Me.cmbMaterialType.Items.Remove("Cell Bank - Bacterial")
					End If
				End If
			End If
		End Sub

		' Token: 0x0600021B RID: 539 RVA: 0x000132B8 File Offset: 0x000114B8
		Private Sub FillProduct()
			Dim text As String = " SELECT P.ProductID, P.ProductCode, P.ProductName, P.ProductType, COUNT(B.BOMVersion) Cnt" & vbCrLf
			text += " FROM Product As P " & vbCrLf
			text += " LEFT OUTER JOIN ProductBOM AS B ON P.ProductID = B.ProductID" & vbCrLf
			text = text + " WHERE P.Status = 'Approved' AND P.ProductType IN ('" + Me.cmbType.Text + "') AND P.IsGRNApplicable = 1" & vbCrLf
			text += " GROUP BY P.ProductID, P.ProductCode, P.ProductName, P.ProductType " & vbCrLf
			text += " ORDER BY ProductCode" & vbCrLf
			Me.dtProduct = MainModule.GetData(text)
			Me.cmbProduct.ValueMember = "ProductID"
			Me.cmbProduct.DisplayMember = "ProductName"
			Me.cmbProduct.DataSource = Me.dtProduct
			Me.cmbProduct.SelectedIndex = -1
		End Sub

		' Token: 0x0600021C RID: 540 RVA: 0x00013368 File Offset: 0x00011568
		Private Sub cmbProduct_Validated(sender As Object, e As EventArgs)
			Me.lblVersion.Text = ""
			Me.lblVersion.Visible = False
			Me.cmbMaterialType.Text = ""
			Me.cmbMaterial.DataSource = Nothing
			Me.txtQty.Text = ""
			Dim flag As Boolean = Operators.CompareString(Me.sStatus, "ADD", False) = 0
			If flag Then
				Me.FillBOM("")
			End If
			Dim flag2 As Boolean = Me.cmbProduct.SelectedIndex > -1
			If flag2 Then
				Me.FillProductDetails()
			Else
				Me.cmbProduct.Text = ""
				Me.txtProductName.Text = ""
			End If
		End Sub

		' Token: 0x0600021D RID: 541 RVA: 0x0001342C File Offset: 0x0001162C
		Private Sub FillProductDetails()
			Dim dataRow As DataRow = Me.dtProduct.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("ProductID = '", Me.cmbProduct.SelectedValue), "'")))(0)
			Me.txtProductName.Text = Conversions.ToString(dataRow("ProductName"))
			Me.lblVersion.Text = Conversions.ToString(Operators.ConcatenateObject(dataRow("Cnt"), " version(s)"))
			Me.lblVersion.Visible = True
		End Sub

		' Token: 0x0600021E RID: 542 RVA: 0x000134BC File Offset: 0x000116BC
		Private Sub cmbMaterialType_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = (Operators.CompareString(Me.cmbMaterialType.Text, "", False) <> 0) And (Me.cmbProduct.SelectedIndex > -1)
			If flag Then
				Me.FillMaterial()
			Else
				Me.cmbMaterial.Text = ""
				Me.cmbMaterial.DataSource = Nothing
			End If
		End Sub

		' Token: 0x0600021F RID: 543 RVA: 0x00013520 File Offset: 0x00011720
		Private Sub FillMaterial()
			Dim text As String = " SELECT ProductID, ProductCode, ProductName, ProductType, SpecificationNo, Reference, " & vbCrLf
			text += " CatalogNo, HSNSACCode, ExpiryType, Expiry, UnitPrice, GSTPer, StorageCondition, " & vbCrLf
			text += " TertiaryUOM, TertiaryPackSize, PrimaryUOM, PrimaryPackSize, " & vbCrLf
			text += " IsActive, IsGRNApplicable, IsQCApplicable, IsParentApplicable, IsUnitsEditable" & vbCrLf
			text += " FROM Product" & vbCrLf
			text = text + " WHERE Status = 'Approved' AND IsActive = 1 AND ProductType IN ('" + Me.cmbMaterialType.Text + "')" & vbCrLf
			text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" AND ProductID <> '", Me.cmbProduct.SelectedValue), "'"), vbCrLf)))
			text += " ORDER BY ProductName" & vbCrLf
			Me.dtMaterial = MainModule.GetData(text)
			Me.cmbMaterial.ValueMember = "ProductID"
			Me.cmbMaterial.DisplayMember = "ProductName"
			Me.cmbMaterial.DataSource = Me.dtMaterial
			Me.cmbMaterial.SelectedIndex = -1
		End Sub

		' Token: 0x06000220 RID: 544 RVA: 0x00013610 File Offset: 0x00011810
		Private Sub cmbMaterial_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbMaterial.SelectedIndex = -1
			If flag Then
				Me.cmbMaterial.Text = ""
			End If
		End Sub

		' Token: 0x06000221 RID: 545 RVA: 0x00013644 File Offset: 0x00011844
		Private Function ValidateAdd() As Boolean
			Dim flag As Boolean = Me.cmbMaterial.SelectedIndex = -1
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Select Material.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.cmbProduct.Focus()
				flag2 = False
			Else
				Dim flag3 As Boolean = Not Versioned.IsNumeric(Me.txtQty.Text) Or (Operators.CompareString(Strings.Trim(Me.txtQty.Text), "", False) = 0)
				If flag3 Then
					CustomMsgBox.Show("Qty. Should Be Numeric.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.txtQty.Focus()
					flag2 = False
				Else
					Dim flag4 As Boolean = Conversion.Val(Me.txtQty.Text) <= 0.0
					If flag4 Then
						CustomMsgBox.Show("Invalid Qty.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.txtQty.Focus()
						flag2 = False
					Else
						Dim flag5 As Boolean = Me.dtBOMDtls.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MaterialID = '", Me.cmbMaterial.SelectedValue), "'"))).Length > 0
						If flag5 Then
							CustomMsgBox.Show("Material Already In The List.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.cmbMaterial.Focus()
							flag2 = False
						Else
							flag2 = True
						End If
					End If
				End If
			End If
			Return flag2
		End Function

		' Token: 0x06000222 RID: 546 RVA: 0x00013794 File Offset: 0x00011994
		Private Sub llbAddItem_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Try
				Me.AddItem()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06000223 RID: 547 RVA: 0x000137EC File Offset: 0x000119EC
		Private Sub AddItem()
			Dim flag As Boolean = Not Me.ValidateAdd()
			If Not flag Then
				Dim dataRow As DataRow = Me.dtMaterial.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("ProductID = '", Me.cmbMaterial.SelectedValue), "'")))(0)
				Me.dtBOMDtls.Rows.Add(New Object(-1) {})
				Me.dtBOMDtls.Rows(Me.dtBOMDtls.Rows.Count - 1)("IssueOrder") = Me.dtBOMDtls.Rows.Count
				Me.dtBOMDtls.Rows(Me.dtBOMDtls.Rows.Count - 1)("MaterialID") = RuntimeHelpers.GetObjectValue(dataRow("ProductID"))
				Me.dtBOMDtls.Rows(Me.dtBOMDtls.Rows.Count - 1)("MaterialType") = RuntimeHelpers.GetObjectValue(dataRow("ProductType"))
				Me.dtBOMDtls.Rows(Me.dtBOMDtls.Rows.Count - 1)("MaterialCode") = RuntimeHelpers.GetObjectValue(dataRow("ProductCode"))
				Me.dtBOMDtls.Rows(Me.dtBOMDtls.Rows.Count - 1)("MaterialName") = RuntimeHelpers.GetObjectValue(dataRow("ProductName"))
				Me.dtBOMDtls.Rows(Me.dtBOMDtls.Rows.Count - 1)("PrimaryUOM") = RuntimeHelpers.GetObjectValue(dataRow("PrimaryUOM"))
				Me.dtBOMDtls.Rows(Me.dtBOMDtls.Rows.Count - 1)("Qty") = Conversion.Val(Me.txtQty.Text)
				Me.dgvBOM.DataSource = Me.dtBOMDtls
				Me.cmbMaterialType.Text = ""
				Me.cmbMaterial.Text = ""
				Me.cmbMaterial.DataSource = Nothing
				Me.txtQty.Text = ""
				Me.cmbMaterialType.Focus()
			End If
		End Sub

		' Token: 0x06000224 RID: 548 RVA: 0x00013A68 File Offset: 0x00011C68
		Private Sub dgvBOM_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = e.RowIndex > -1
			If flag Then
				Dim array As DataRow() = Me.dtBOMDtls.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MaterialID = '", Me.dgvBOM.Rows(e.RowIndex).Cells("MaterialID").Value), "'")))
				Dim flag2 As Boolean = array.Length = 1
				If flag2 Then
					Dim text As String = Me.dgvBOM.Columns(e.ColumnIndex).Name.ToString()
					If Operators.CompareString(text, "btnDelete_BOM", False) = 0 Then
						Me.dtBOMDtls.Rows.Remove(array(0))
						Dim num As Integer = Me.dtBOMDtls.Rows.Count - 1
						For i As Integer = 0 To num
							Me.dtBOMDtls.Rows(i)("IssueOrder") = i + 1
						Next
						Me.dtBOMDtls.AcceptChanges()
						Me.dgvBOM.DataSource = Me.dtBOMDtls
					End If
				End If
			End If
		End Sub

		' Token: 0x06000225 RID: 549 RVA: 0x00013B9C File Offset: 0x00011D9C
		Private Sub btnSearch_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SearchData("")
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06000226 RID: 550 RVA: 0x00013C10 File Offset: 0x00011E10
		Private Sub SearchData(sProductID As String)
			Dim text As String = ""
			Dim text2 As String = " SELECT B.ProductBOMID ID, P.ProductID, B.Status, P.ProductCode, P.ProductName, P.ProductType, " & vbCrLf
			text2 += " B.BatchQty, B.BOMVersion, B.EffectiveDt, B.ExpiryDt, B.IsActive, " & vbCrLf
			text2 += " B.Remarks, B.ActionRemarks, " & vbCrLf
			text2 += " Action.UserName AS ActionBy, B.ActionDt, Action.EmailID AS ActionByEmailID, " & vbCrLf
			text2 += " Created.EmailID AS CreatedByEmailID, Modified.EmailID AS ModifiedByEmailID, " & vbCrLf
			text2 += " B.CreationDt, Created.UserName AS CreatedBy, B.ModificationDt, Modified.UserName AS ModifiedBy " & vbCrLf
			text2 += " FROM Product AS P " & vbCrLf
			text2 += " INNER JOIN ProductBOM AS B ON P.ProductID = B.ProductID " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Action ON B.ActionBy = Action.UserID " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Created ON B.CreatedBy = Created.UserID " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Modified ON B.ModifiedBy = Modified.UserID " & vbCrLf
			text2 += " WHERE 1 = 1" & vbCrLf
			Dim flag As Boolean = Operators.CompareString(sProductID, "", False) <> 0
			If flag Then
				text2 = text2 + " AND (P.ProductID = '" + sProductID + "') " & vbCrLf
				text = text + "P.ProductID = " + sProductID + vbCrLf
			End If
			Dim flag2 As Boolean = Operators.CompareString(Strings.Trim(Me.txtSCode.Text), "", False) <> 0
			If flag2 Then
				text2 = text2 + " AND (ProductCode Like '%" + Strings.Trim(Me.txtSCode.Text) + "%') " & vbCrLf
				text = text + "ProductCode LIKE " + Strings.Trim(Me.txtSCode.Text) + vbCrLf
			End If
			Dim flag3 As Boolean = Operators.CompareString(Strings.Trim(Me.txtSCatalogNo.Text), "", False) <> 0
			If flag3 Then
				text2 = text2 + " AND (CatalogNo Like '%" + Strings.Trim(Me.txtSCatalogNo.Text) + "%') " & vbCrLf
				text = text + "CatalogNo LIKE " + Strings.Trim(Me.txtSCatalogNo.Text) + vbCrLf
			End If
			Dim flag4 As Boolean = Operators.CompareString(Strings.Trim(Me.txtSName.Text), "", False) <> 0
			If flag4 Then
				text2 = text2 + " AND (ProductName Like '%" + Strings.Trim(Me.txtSName.Text) + "%') " & vbCrLf
				text = text + "ProductName LIKE " + Strings.Trim(Me.txtSName.Text) + vbCrLf
			End If
			Dim flag5 As Boolean = Operators.CompareString(Strings.Trim(Me.cmbSType.Text), "", False) <> 0
			If flag5 Then
				text2 = text2 + " AND (ProductType = '" + Strings.Trim(Me.cmbSType.Text) + "')" & vbCrLf
				text = text + "ProductType = " + Strings.Trim(Me.cmbSType.Text) + vbCrLf
			End If
			Dim flag6 As Boolean = Me.cmbIsActive.SelectedIndex > 0
			If flag6 Then
				Dim flag7 As Boolean = Me.cmbIsActive.SelectedIndex = 1
				If flag7 Then
					text2 += " AND (B.IsActive = 1)"
					text += "IsActive = 1" & vbCrLf
				Else
					text2 += " AND (B.IsActive = 0)"
					text += "IsActive = 0" & vbCrLf
				End If
			End If
			Dim flag8 As Boolean = Me.cmbStatus.SelectedIndex > 0
			If flag8 Then
				text2 = text2 + " AND (B.Status = '" + Me.cmbStatus.Text + "')"
				text = text + ("Status = " + Me.cmbStatus.Text) + vbCrLf
			End If
			Dim flag9 As Boolean = Me.lblSDate.SelectedIndex >= 0
			If flag9 Then
				Dim flag10 As Boolean = Me.lblSDate.SelectedIndex = 0
				Dim text3 As String
				If flag10 Then
					text3 = "EffectiveDt"
				Else
					text3 = "ExpiryDt"
				End If
				Dim flag11 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
				If flag11 Then
					text2 = String.Concat(New String() { text2, " AND B.", text3, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
					text = text + String.Concat(New String() { text3, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
				Else
					Dim checked As Boolean = Me.dtpFrom.Checked
					If checked Then
						text2 = String.Concat(New String() { text2, " AND B.", text3, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59"), "'" })
						text = text + String.Concat(New String() { text3, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
					End If
					Dim checked2 As Boolean = Me.dtpTo.Checked
					If checked2 Then
						text2 = String.Concat(New String() { text2, " AND B.", text3, " BETWEEN '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
						text = text + String.Concat(New String() { text3, " BETWEEN  ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
					End If
				End If
			End If
			text2 += " ORDER BY ProductName"
			Dim data As DataTable = MainModule.GetData(text2)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = data
			Me.dgvList.Columns("ID").Visible = False
			Me.dgvList.Columns("ProductID").Visible = False
			Me.dgvList.Columns("CreatedByEmailID").Visible = False
			Me.dgvList.Columns("ModifiedByEmailID").Visible = False
			Me.dgvList.Columns("ActionByEmailID").Visible = False
			Me.dgvList.Columns("Remarks").Visible = False
			Me.dgvList.Columns("ActionRemarks").Visible = False
			Me.dgvList.Columns("ProductCode").HeaderText = "Product Code"
			Me.dgvList.Columns("ProductName").HeaderText = "Product Name"
			Me.dgvList.Columns("ProductType").HeaderText = "Product Type"
			Me.dgvList.Columns("BatchQty").HeaderText = "Batch Qty."
			Me.dgvList.Columns("BOMVersion").HeaderText = "BOM Version"
			Me.dgvList.Columns("EffectiveDt").HeaderText = "Effective Date"
			Me.dgvList.Columns("ExpiryDt").HeaderText = "Expiry Date"
			Me.dgvList.Columns("IsActive").HeaderText = "Is Active"
			Me.dgvList.Columns("ActionBy").HeaderText = "Action By"
			Me.dgvList.Columns("ActionDt").HeaderText = "Action Date"
			Me.dgvList.Columns("CreationDt").HeaderText = "Creation Date"
			Me.dgvList.Columns("CreatedBy").HeaderText = "Created By"
			Me.dgvList.Columns("ModificationDt").HeaderText = "Modification Date"
			Me.dgvList.Columns("ModifiedBy").HeaderText = "Modified By"
			Me.dgvList.Columns("Status").Width = 110
			Me.dgvList.Columns("ProductCode").Width = 140
			Me.dgvList.Columns("ProductName").Width = 350
			Me.dgvList.Columns("ProductType").Width = 130
			Me.dgvList.Columns("BOMVersion").Width = 140
			Me.dgvList.Columns("EffectiveDt").Width = 120
			Me.dgvList.Columns("ExpiryDt").Width = 120
			Me.dgvList.Columns("IsActive").Width = 70
			Me.dgvList.Columns("ActionDt").Width = 170
			Me.dgvList.Columns("ActionBy").Width = 140
			Me.dgvList.Columns("CreationDt").Width = 170
			Me.dgvList.Columns("CreatedBy").Width = 140
			Me.dgvList.Columns("ModificationDt").Width = 170
			Me.dgvList.Columns("ModifiedBy").Width = 140
			Me.dgvList.Columns("EffectiveDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("ExpiryDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("ActionDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh: mm:ss tt"
			Me.dgvList.Columns("CreationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			Me.dgvList.Columns("ModificationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x06000227 RID: 551 RVA: 0x000147C0 File Offset: 0x000129C0
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

		' Token: 0x06000228 RID: 552 RVA: 0x000148B8 File Offset: 0x00012AB8
		Private Sub FillData(sID As String)
			Dim dataTable As DataTable = CType(Me.dgvList.DataSource, DataTable)
			Dim flag As Boolean = (Operators.CompareString(sID, "", False) <> 0) And (dataTable.Rows.Count > 0)
			If flag Then
				Dim flag2 As Boolean = dataTable.[Select]("ID='" + sID + "'").Length > 0
				If flag2 Then
					Dim dataRow As DataRow = dataTable.[Select]("ID='" + sID + "'")(0)
					Me.txtID.Text = dataRow("ID").ToString()
					Me.txtBatchQty.Text = dataRow("BatchQty").ToString()
					Me.txtBOMVersion.Text = dataRow("BOMVersion").ToString()
					Me.cmbType.Text = dataRow("ProductType").ToString()
					Me.FillProduct()
					Me.cmbProduct.SelectedValue = dataRow("ProductID").ToString()
					Me.txtProductName.Text = dataRow("ProductName").ToString()
					Me.cmbProduct.Enabled = False
					Dim flag3 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("EffectiveDt")))
					If flag3 Then
						Me.dtpEffectiveDt.Value = Conversions.ToDate(dataRow("EffectiveDt"))
						Me.dtpEffectiveDt.Checked = True
					Else
						Me.dtpEffectiveDt.Value = DateAndTime.Now
						Me.dtpEffectiveDt.Checked = False
					End If
					Dim flag4 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow("ExpiryDt")))
					If flag4 Then
						Me.dtpExpiryDt.Value = Conversions.ToDate(dataRow("ExpiryDt"))
						Me.dtpExpiryDt.Checked = True
					Else
						Me.dtpExpiryDt.Value = DateAndTime.Now
						Me.dtpExpiryDt.Checked = False
					End If
					Dim flag5 As Boolean = Operators.ConditionalCompareObjectEqual(dataRow("IsActive"), True, False)
					If flag5 Then
						Me.chkIsActive.Checked = True
					Else
						Me.chkIsActive.Checked = False
					End If
					Me.txtRemarks.Text = dataRow("Remarks").ToString()
					Me.txtRemarksApproval.Text = dataRow("ActionRemarks").ToString()
					Me.skip_lblStatus.Text = dataRow("Status").ToString()
					Dim flag6 As Boolean = Operators.CompareString(Me.txtRemarksApproval.Text, "", False) = 0
					If flag6 Then
						Me.lblRemarksApproval.Visible = False
					Else
						Me.lblRemarksApproval.Visible = True
					End If
					Me.txtCreatedByEmailID.Text = dataRow("CreatedByEmailID").ToString()
					Me.txtModifiedByEmailID.Text = dataRow("ModifiedByEmailID").ToString()
					Me.txtActionByEmailID.Text = dataRow("ActionByEmailID").ToString()
					Me.FillBOM(Me.txtID.Text)
				End If
			End If
		End Sub

		' Token: 0x06000229 RID: 553 RVA: 0x00014C00 File Offset: 0x00012E00
		Private Sub FillBOM(sID As String)
			Dim flag As Boolean = Operators.CompareString(sID, "", False) <> 0
			Dim text As String
			If flag Then
				text = " SELECT ProductBOMID, ROW_NUMBER() OVER(PARTITION BY ProductBOMID ORDER BY ProductBOMID) VersionID," & vbCrLf
				text += " PBD.IssueOrder, PBD.MaterialID, PBD.Qty, M.ProductType MaterialType," & vbCrLf
				text += " M.ProductCode MaterialCode, M.ProductName MaterialName, M.PrimaryUOM" & vbCrLf
				text += " FROM ProductBOMDtls PBD" & vbCrLf
				text += " INNER JOIN Product M ON PBD.MaterialID = M.ProductID" & vbCrLf
				text = text + " WHERE PBD.ProductBOMID = '" + sID + "'" & vbCrLf
			Else
				text = " SELECT ProductBOMID, ROW_NUMBER() OVER(PARTITION BY ProductBOMID ORDER BY ProductBOMID) VersionID," & vbCrLf
				text += " PBD.IssueOrder, PBD.MaterialID, PBD.Qty, M.ProductType MaterialType," & vbCrLf
				text += " M.ProductCode MaterialCode, M.ProductName MaterialName, M.PrimaryUOM" & vbCrLf
				text += " FROM ProductBOMDtls PBD" & vbCrLf
				text += " INNER JOIN Product M ON PBD.MaterialID = M.ProductID" & vbCrLf
				text += " WHERE PBD.ProductBOMID = '0'" & vbCrLf
			End If
			Me.dtBOMDtls = MainModule.GetData(text)
			Me.dgvBOM.DataSource = Me.dtBOMDtls
		End Sub

		' Token: 0x0600022A RID: 554 RVA: 0x00014CD0 File Offset: 0x00012ED0
		Private Function ValidateForm() As Boolean
			Dim flag As Boolean = Me.cmbProduct.SelectedIndex = -1
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Select Product.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.cmbProduct.Focus()
				flag2 = False
			Else
				Dim flag3 As Boolean = Operators.CompareString(Strings.Trim(Me.txtBOMVersion.Text), "", False) = 0
				If flag3 Then
					CustomMsgBox.Show("Enter BOM Version.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.txtBOMVersion.Focus()
					flag2 = False
				Else
					Dim flag4 As Boolean = Operators.CompareString(Strings.Trim(Me.txtBatchQty.Text), "", False) = 0
					If flag4 Then
						CustomMsgBox.Show("Enter Batch Quantity.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.txtBatchQty.Focus()
						flag2 = False
					Else
						Dim flag5 As Boolean = Not Me.dtpEffectiveDt.Checked
						If flag5 Then
							CustomMsgBox.Show("Select Effective Date.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.dtpEffectiveDt.Focus()
							flag2 = False
						Else
							Dim flag6 As Boolean = Not Me.chkIsActive.Checked
							If flag6 Then
								Dim flag7 As Boolean = Not Me.dtpExpiryDt.Checked
								If flag7 Then
									CustomMsgBox.Show("Select Expiry Date.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
									Me.dtpExpiryDt.Focus()
									Return False
								End If
								Dim flag8 As Boolean = DateTime.Compare(Me.dtpExpiryDt.Value, DateAndTime.Now) < 0
								If flag8 Then
									CustomMsgBox.Show("Invalid Expiry Date.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
									Me.dtpExpiryDt.Focus()
									Return False
								End If
							End If
							Dim text As String = " SELECT ProductID, BOMVersion FROM ProductBOM "
							text += " WHERE Status NOT IN ('Rejected') "
							text = text + " AND BOMVersion = '" + Strings.Trim(Me.txtBOMVersion.Text) + "' "
							Dim flag9 As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
							If flag9 Then
								text = text + " AND ProductBOMID = '" + Me.txtID.Text + "' "
							End If
							Dim data As DataTable = MainModule.GetData(text)
							Dim flag10 As Boolean = data.Rows.Count > 0
							If flag10 Then
								CustomMsgBox.Show("BOM Version Already Exists.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								Me.txtBOMVersion.Focus()
								flag2 = False
							Else
								flag2 = True
							End If
						End If
					End If
				End If
			End If
			Return flag2
		End Function

		' Token: 0x0600022B RID: 555 RVA: 0x00014F38 File Offset: 0x00013138
		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.Save()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x0600022C RID: 556 RVA: 0x00014FA4 File Offset: 0x000131A4
		Private Sub Save()
			Dim flag As Boolean = CustomMsgBox.Show("Save..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
			If flag Then
				Dim flag2 As Boolean = Not Me.ValidateForm()
				If Not flag2 Then
					Dim flag3 As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
					If flag3 Then
						Me.UpdateData()
						Me.ConfigureSendMail("BOM Creation", "", Me.txtID.Text)
					Else
						Me.InsertData()
						Me.ConfigureSendMail("BOM Modification", "", Me.txtID.Text)
					End If
				End If
			End If
		End Sub

		' Token: 0x0600022D RID: 557 RVA: 0x00015044 File Offset: 0x00013244
		Private Sub InsertData()
			Dim text As String = " INSERT INTO ProductBOM (ProductID, BOMVersion, BatchQty, Remarks, EffectiveDt, ExpiryDt, IsActive, CreationDt, CreatedBy) "
			text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" VALUES('", Me.cmbProduct.SelectedValue), "', '"), Strings.Trim(Me.txtBOMVersion.Text)), "', ")))
			text = String.Concat(New String() { text, " '", Strings.Trim(Me.txtBatchQty.Text), "', '", Strings.Trim(Me.txtRemarks.Text), "'," })
			Dim checked As Boolean = Me.dtpEffectiveDt.Checked
			If checked Then
				text = text + " '" + Strings.Format(Me.dtpEffectiveDt.Value, "MM/dd/yyyy") + "',"
			Else
				text += " NULL,"
			End If
			Dim checked2 As Boolean = Me.dtpExpiryDt.Checked
			If checked2 Then
				text = text + " '" + Strings.Format(Me.dtpExpiryDt.Value, "MM/dd/yyyy") + "',"
			Else
				text += " NULL,"
			End If
			Dim checked3 As Boolean = Me.chkIsActive.Checked
			If checked3 Then
				text += " 1," & vbCrLf
			Else
				text += " 0," & vbCrLf
			End If
			text = text + " GETDATE(), '" + GlobalVariables.gsUserID + "')" & vbCrLf
			text += " SELECT SCOPE_IDENTITY() AS ID"
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Me.skip_lblStatus.Text = "Approval Pending"
				Me.txtID.Text = Conversions.ToString(data.Rows(0)("ID"))
				Me.InsertBOM()
				MainModule.TrnLog(Me.Text, "Created", "New ID: " + Me.txtID.Text, Nothing)
				CustomMsgBox.Show("Product BOM Added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Me.SetAccess("DISABLE")
				Me.sStatus = "SAVE"
				Me.SetButtonStatus()
			End If
		End Sub

		' Token: 0x0600022E RID: 558 RVA: 0x00015290 File Offset: 0x00013490
		Private Sub UpdateData()
			Dim text As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" UPDATE ProductBOM SET ProductID = '", Me.cmbProduct.SelectedValue), "', BOMVersion = '"), Strings.Trim(Me.txtBOMVersion.Text)), "', "))
			text = String.Concat(New String() { text, " BatchQty = '", Strings.Trim(Me.txtBatchQty.Text), "', Remarks = '", Strings.Trim(Me.txtRemarks.Text), "'," })
			Dim flag As Boolean = Operators.CompareString(Me.skip_lblStatus.Text, "On-Hold", False) = 0
			If flag Then
				text += " Status = 'Approval Pending',"
			End If
			Dim checked As Boolean = Me.dtpEffectiveDt.Checked
			If checked Then
				text = text + " EffectiveDt = '" + Strings.Format(Me.dtpEffectiveDt.Value, "MM/dd/yyyy") + "',"
			Else
				text += " EffectiveDt = NULL,"
			End If
			Dim checked2 As Boolean = Me.dtpExpiryDt.Checked
			If checked2 Then
				text = text + " ExpiryDt = '" + Strings.Format(Me.dtpExpiryDt.Value, "MM/dd/yyyy") + "',"
			Else
				text += " ExpiryDt = NULL,"
			End If
			text = text + " ModificationDt = GETDATE(), ModifiedBy = '" + GlobalVariables.gsUserID + "',"
			Dim checked3 As Boolean = Me.chkIsActive.Checked
			If checked3 Then
				text += " IsActive =1"
			Else
				text += " IsActive =0"
			End If
			text = text + " WHERE ProductBOMID  = '" + Me.txtID.Text + "'"
			Dim flag2 As Boolean = MainModule.ExecuteSQL(text) = 1
			If flag2 Then
				Dim flag3 As Boolean = Operators.CompareString(Me.skip_lblStatus.Text, "On-Hold", False) = 0
				If flag3 Then
					Me.skip_lblStatus.Text = "Approval Pending"
				End If
				Me.InsertBOM()
				MainModule.TrnLog(Me.Text, "Modified", "Modified ID: " + Me.txtID.Text, Nothing)
				CustomMsgBox.Show("Product BOM Modified.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Me.SetAccess("DISABLE")
				Me.sStatus = "SAVE"
				Me.SetButtonStatus()
			End If
		End Sub

		' Token: 0x0600022F RID: 559 RVA: 0x000154F8 File Offset: 0x000136F8
		Private Sub InsertBOM()
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				Dim sqlConnection As SqlConnection = New SqlConnection(GlobalVariables.gsConStr)
				sqlConnection.Open()
				Dim sqlTransaction As SqlTransaction = sqlConnection.BeginTransaction(IsolationLevel.Serializable)
				Try
					Dim text As String = " DELETE FROM ProductBOMDtls WHERE ProductBOMID = '" + Me.txtID.Text + "'"
					Dim flag2 As Boolean = MainModule.ExecuteSQL(text, sqlConnection, sqlTransaction) = 1
					If flag2 Then
						Dim dataTable As DataTable = Me.dtBOMDtls.Copy()
						Dim flag3 As Boolean = dataTable.Rows.Count > 0
						If flag3 Then
							dataTable.Columns.Remove("ProductBOMID")
							dataTable.Columns.Remove("MaterialType")
							dataTable.Columns.Remove("MaterialCode")
							dataTable.Columns.Remove("MaterialName")
							dataTable.Columns.Remove("PrimaryUOM")
							Dim dataColumn As DataColumn = New DataColumn("ProductBOMID", GetType(Integer))
							dataColumn.DefaultValue = Me.txtID.Text
							Dim dataColumn2 As DataColumn = New DataColumn("ProductID", GetType(Integer))
							dataColumn2.DefaultValue = RuntimeHelpers.GetObjectValue(Me.cmbProduct.SelectedValue)
							dataTable.Columns.Add(dataColumn)
							dataTable.Columns.Add(dataColumn2)
							MainModule.BulkInsertTemp(dataTable, "ProductBOMDtls", sqlConnection, sqlTransaction)
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

		' Token: 0x06000230 RID: 560 RVA: 0x00015700 File Offset: 0x00013900
		Private Sub lblRemarks_Click(sender As Object, e As EventArgs)
			Me.lblRemarks.BorderStyle = BorderStyle.FixedSingle
			Me.lblRemarksApproval.BorderStyle = BorderStyle.None
			Me.lblRemarks1.Visible = True
			Me.lblRemarksApproval1.Visible = False
			Me.txtRemarks.Visible = True
			Me.txtRemarksApproval.Visible = False
		End Sub

		' Token: 0x06000231 RID: 561 RVA: 0x0001575C File Offset: 0x0001395C
		Private Sub lblRemarksApproval_Click(sender As Object, e As EventArgs)
			Me.lblRemarks.BorderStyle = BorderStyle.None
			Me.lblRemarksApproval.BorderStyle = BorderStyle.FixedSingle
			Me.lblRemarks1.Visible = False
			Me.lblRemarksApproval.Visible = True
			Me.lblRemarksApproval1.Visible = True
			Me.txtRemarks.Visible = False
			Me.txtRemarksApproval.Visible = True
		End Sub

		' Token: 0x06000232 RID: 562 RVA: 0x000157C8 File Offset: 0x000139C8
		Private Sub skip_lblStatus_TextChanged(sender As Object, e As EventArgs)
			Dim text As String = Me.skip_lblStatus.Text
			If Operators.CompareString(text, "Approval Pending", False) <> 0 Then
				If Operators.CompareString(text, "Approved", False) <> 0 Then
					If Operators.CompareString(text, "On-Hold", False) <> 0 Then
						If Operators.CompareString(text, "Rejected", False) = 0 Then
							Me.skip_lblStatus.ForeColor = Color.Red
						End If
					Else
						Me.skip_lblStatus.ForeColor = Color.Blue
					End If
				Else
					Me.skip_lblStatus.ForeColor = Color.LawnGreen
				End If
			Else
				Me.skip_lblStatus.ForeColor = Color.Orange
			End If
		End Sub

		' Token: 0x06000233 RID: 563 RVA: 0x00015870 File Offset: 0x00013A70
		Private Sub btnApprove_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.Approve_Reject("Approved")
				Me.ConfigureSendMail("BOM Approval", "Approved", Me.txtID.Text)
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnApprove.Enabled = True
				Me.btnOnHold.Enabled = True
				Me.btnReject.Enabled = True
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06000234 RID: 564 RVA: 0x00015924 File Offset: 0x00013B24
		Private Sub btnReject_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.Approve_Reject("Rejected")
				Me.ConfigureSendMail("BOM Approval", "Rejected", Me.txtID.Text)
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnApprove.Enabled = True
				Me.btnReject.Enabled = True
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06000235 RID: 565 RVA: 0x000159CC File Offset: 0x00013BCC
		Private Sub Approve_Reject(sStatus As String)
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				Dim text As String = "Approve BOM..?"
				Dim text2 As String = "Approved"
				Dim flag2 As Boolean = Operators.CompareString(sStatus, "Rejected", False) = 0
				If flag2 Then
					text = "Reject BOM..?"
					text2 = "Rejected"
				End If
				Dim flag3 As Boolean = CustomMsgBox.Show("Changes Cannot Be Reverted." & vbCrLf + text, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
				If flag3 Then
					Me.btnApprove.Enabled = False
					Me.btnOnHold.Enabled = False
					Me.btnReject.Enabled = False
					Dim text3 As String = ""
					Dim flag4 As Boolean = Operators.CompareString(sStatus, "Rejected", False) = 0
					Dim text4 As String
					If flag4 Then
						text4 = "Rejection"
					Else
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
						Dim text5 As String = String.Concat(New String() { " UPDATE ProductBOM SET Status = '", sStatus, "', ActionRemarks = '", Me.txtRemarksApproval.Text, "', " & vbCrLf })
						text5 = text5 + " ActionDt = GETDATE(), ActionBy = '" + GlobalVariables.gsUserID + "'" & vbCrLf
						text5 = text5 + " WHERE ProductBOMID = '" + Me.txtID.Text + "'"
						Dim flag6 As Boolean = MainModule.ExecuteSQL(text5) = 1
						If flag6 Then
							Dim text6 As String = "ID : " + Me.txtID.Text + vbCrLf
							text6 = "Product : " + Me.cmbProduct.Text + vbCrLf
							text6 = text6 + "BOM Version No. : " + Me.txtBOMVersion.Text
							Me.skip_lblStatus.Text = sStatus
							MainModule.TrnLog(Me.Text, If(("BOM " + sStatus), ""), text6, Nothing)
							CustomMsgBox.Show("BOM " + text2 + ".", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Else
							Me.btnApprove.Enabled = True
							Me.btnOnHold.Enabled = True
							Me.btnReject.Enabled = True
						End If
					Else
						CustomMsgBox.Show("Remark For " + text4 + " Is Mandatory.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					End If
				End If
			End If
		End Sub

		' Token: 0x06000236 RID: 566 RVA: 0x00015CC8 File Offset: 0x00013EC8
		Private Sub btnOnHold_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Dim flag As Boolean = CustomMsgBox.Show("Put On Hold..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
				If flag Then
					Me.OnHold()
					Me.ConfigureSendMail("BOM Approval", "On-Hold", Me.txtID.Text)
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnApprove.Enabled = True
				Me.btnOnHold.Enabled = True
				Me.btnReject.Enabled = True
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06000237 RID: 567 RVA: 0x00015D94 File Offset: 0x00013F94
		Private Sub OnHold()
			Dim captureReasons As CaptureReasons = New CaptureReasons("On-Hold")
			Dim flag As Boolean = captureReasons.ShowDialog() = DialogResult.OK
			If flag Then
				Me.btnApprove.Enabled = False
				Me.btnOnHold.Enabled = False
				Me.btnReject.Enabled = False
				Dim text As String = "Action : On-Hold" & vbCrLf
				text = text + "Action By : " + GlobalVariables.gsUserName + vbCrLf
				text = text + "Action On : " + Strings.Format(MainModule.GetServerDate(), "dd-MMM-yyyy hh:mm:ss tt") + vbCrLf
				text = text + "Remarks : " + captureReasons.sRemarks + vbCrLf & vbCrLf
				Dim txtRemarksApproval As TextBox = Me.txtRemarksApproval
				Dim textBox As TextBox = txtRemarksApproval
				txtRemarksApproval.Text = textBox.Text + text
				Me.lblRemarksApproval.Visible = True
				Me.lblRemarksApproval_Click(Nothing, Nothing)
				Dim text2 As String = " UPDATE ProductBOM SET Status = 'On-Hold', ActionRemarks = '" + Me.txtRemarksApproval.Text + "', " & vbCrLf
				text2 = text2 + " ActionDt = GETDATE(), ActionBy = '" + GlobalVariables.gsUserID + "'" & vbCrLf
				text2 = text2 + " WHERE ProductBOMID  = '" + Me.txtID.Text + "'"
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text2) = 1
				If flag2 Then
					Dim text3 As String = "ID : " + Me.txtID.Text + vbCrLf
					text3 = "Product : " + Me.cmbProduct.Text + vbCrLf
					text3 = text3 + "BOM Version No. : " + Me.txtBOMVersion.Text
					text3 += text
					Me.skip_lblStatus.Text = "On-Hold"
					MainModule.TrnLog(Me.Text, "BOM On-Hold", text3, Nothing)
					CustomMsgBox.Show("BOM On-Hold.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Else
					Me.btnApprove.Enabled = True
					Me.btnOnHold.Enabled = True
					Me.btnReject.Enabled = True
				End If
			End If
		End Sub

		' Token: 0x06000238 RID: 568 RVA: 0x00015F90 File Offset: 0x00014190
		Private Sub ConfigureSendMail(sTrn As String, sType As String, sID As String)
			Dim flag As Boolean = Operators.CompareString(sID, "", False) <> 0
			If flag Then
				Dim flag2 As Boolean = Operators.CompareString(Me.txtCreatedByEmailID.Text, "", False) <> 0
				Dim text As String
				If flag2 Then
					text = ":" + Me.txtCreatedByEmailID.Text
				Else
					text = ":" + GlobalVariables.gsEmailID
				End If
				Dim flag3 As Boolean = Operators.CompareString(Me.txtModifiedByEmailID.Text, "", False) <> 0
				If flag3 Then
					text = ":" + Me.txtModifiedByEmailID.Text
				Else
					text = ":" + GlobalVariables.gsEmailID
				End If
				Dim flag4 As Boolean = Operators.CompareString(Me.txtActionByEmailID.Text, "", False) <> 0
				If flag4 Then
					text = ":" + Me.txtActionByEmailID.Text
				Else
					text = ":" + GlobalVariables.gsEmailID
				End If
				EmailModule.SendMail(sTrn, Me.txtID.Text, sType, text)
			End If
		End Sub

		' Token: 0x040000C6 RID: 198
		Private sFormType As String

		' Token: 0x040000C7 RID: 199
		Private sStatus As String

		' Token: 0x040000C8 RID: 200
		Private bOnHold As Boolean

		' Token: 0x040000C9 RID: 201
		Private pnlBasicDefaultHeight As Integer

		' Token: 0x040000CA RID: 202
		Private pnlBasicSetHeight As Integer

		' Token: 0x040000CB RID: 203
		Private pnlAdvDefaultHeight As Integer

		' Token: 0x040000CC RID: 204
		Private pnlAdvSetHeight As Integer

		' Token: 0x040000CD RID: 205
		Private dtProduct As DataTable

		' Token: 0x040000CE RID: 206
		Private dtMaterial As DataTable

		' Token: 0x040000CF RID: 207
		Private dtBOMDtls As DataTable
	End Class
End Namespace
