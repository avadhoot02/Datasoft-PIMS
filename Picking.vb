Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x02000065 RID: 101
	<DesignerGenerated()>
	Public Partial Class Picking
		Inherits Form

		' Token: 0x170009A2 RID: 2466
		' (get) Token: 0x060018E5 RID: 6373 RVA: 0x000EBE48 File Offset: 0x000EA048
		' (set) Token: 0x060018E6 RID: 6374 RVA: 0x000EBE52 File Offset: 0x000EA052
		Friend Overridable Property pnlBorder As Panel

		' Token: 0x170009A3 RID: 2467
		' (get) Token: 0x060018E7 RID: 6375 RVA: 0x000EBE5B File Offset: 0x000EA05B
		' (set) Token: 0x060018E8 RID: 6376 RVA: 0x000EBE65 File Offset: 0x000EA065
		Friend Overridable Property pnlMain As Panel

		' Token: 0x170009A4 RID: 2468
		' (get) Token: 0x060018E9 RID: 6377 RVA: 0x000EBE6E File Offset: 0x000EA06E
		' (set) Token: 0x060018EA RID: 6378 RVA: 0x000EBE78 File Offset: 0x000EA078
		Friend Overridable Property panelTitleBar As Panel
			<CompilerGenerated()>
			Get
				Return Me._panelTitleBar
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.panelTitleBar_MouseDown
				Dim panel As Panel = Me._panelTitleBar
				If panel IsNot Nothing Then
					RemoveHandler panel.MouseDown, mouseEventHandler
				End If
				Me._panelTitleBar = value
				panel = Me._panelTitleBar
				If panel IsNot Nothing Then
					AddHandler panel.MouseDown, mouseEventHandler
				End If
			End Set
		End Property

		' Token: 0x170009A5 RID: 2469
		' (get) Token: 0x060018EB RID: 6379 RVA: 0x000EBEBB File Offset: 0x000EA0BB
		' (set) Token: 0x060018EC RID: 6380 RVA: 0x000EBEC5 File Offset: 0x000EA0C5
		Friend Overridable Property picFormIcon As PictureBox

		' Token: 0x170009A6 RID: 2470
		' (get) Token: 0x060018ED RID: 6381 RVA: 0x000EBECE File Offset: 0x000EA0CE
		' (set) Token: 0x060018EE RID: 6382 RVA: 0x000EBED8 File Offset: 0x000EA0D8
		Friend Overridable Property lblCaption As Label

		' Token: 0x170009A7 RID: 2471
		' (get) Token: 0x060018EF RID: 6383 RVA: 0x000EBEE1 File Offset: 0x000EA0E1
		' (set) Token: 0x060018F0 RID: 6384 RVA: 0x000EBEEC File Offset: 0x000EA0EC
		Friend Overridable Property form_btnClose As Button
			<CompilerGenerated()>
			Get
				Return Me._form_btnClose
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.form_btnClose_Click
				Dim button As Button = Me._form_btnClose
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._form_btnClose = value
				button = Me._form_btnClose
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170009A8 RID: 2472
		' (get) Token: 0x060018F1 RID: 6385 RVA: 0x000EBF2F File Offset: 0x000EA12F
		' (set) Token: 0x060018F2 RID: 6386 RVA: 0x000EBF39 File Offset: 0x000EA139
		Friend Overridable Property lblShadow1 As Label

		' Token: 0x170009A9 RID: 2473
		' (get) Token: 0x060018F3 RID: 6387 RVA: 0x000EBF42 File Offset: 0x000EA142
		' (set) Token: 0x060018F4 RID: 6388 RVA: 0x000EBF4C File Offset: 0x000EA14C
		Friend Overridable Property lblShadow2 As Label

		' Token: 0x170009AA RID: 2474
		' (get) Token: 0x060018F5 RID: 6389 RVA: 0x000EBF55 File Offset: 0x000EA155
		' (set) Token: 0x060018F6 RID: 6390 RVA: 0x000EBF5F File Offset: 0x000EA15F
		Friend Overridable Property theme_tc As TabControl

		' Token: 0x170009AB RID: 2475
		' (get) Token: 0x060018F7 RID: 6391 RVA: 0x000EBF68 File Offset: 0x000EA168
		' (set) Token: 0x060018F8 RID: 6392 RVA: 0x000EBF72 File Offset: 0x000EA172
		Friend Overridable Property tpDetails As TabPage

		' Token: 0x170009AC RID: 2476
		' (get) Token: 0x060018F9 RID: 6393 RVA: 0x000EBF7B File Offset: 0x000EA17B
		' (set) Token: 0x060018FA RID: 6394 RVA: 0x000EBF85 File Offset: 0x000EA185
		Friend Overridable Property Label11 As Label

		' Token: 0x170009AD RID: 2477
		' (get) Token: 0x060018FB RID: 6395 RVA: 0x000EBF8E File Offset: 0x000EA18E
		' (set) Token: 0x060018FC RID: 6396 RVA: 0x000EBF98 File Offset: 0x000EA198
		Friend Overridable Property txtPickingByID As TextBox

		' Token: 0x170009AE RID: 2478
		' (get) Token: 0x060018FD RID: 6397 RVA: 0x000EBFA1 File Offset: 0x000EA1A1
		' (set) Token: 0x060018FE RID: 6398 RVA: 0x000EBFAB File Offset: 0x000EA1AB
		Friend Overridable Property txtPickingBy As TextBox

		' Token: 0x170009AF RID: 2479
		' (get) Token: 0x060018FF RID: 6399 RVA: 0x000EBFB4 File Offset: 0x000EA1B4
		' (set) Token: 0x06001900 RID: 6400 RVA: 0x000EBFBE File Offset: 0x000EA1BE
		Friend Overridable Property txtProductID As TextBox

		' Token: 0x170009B0 RID: 2480
		' (get) Token: 0x06001901 RID: 6401 RVA: 0x000EBFC7 File Offset: 0x000EA1C7
		' (set) Token: 0x06001902 RID: 6402 RVA: 0x000EBFD1 File Offset: 0x000EA1D1
		Friend Overridable Property txtRequestedByID As TextBox

		' Token: 0x170009B1 RID: 2481
		' (get) Token: 0x06001903 RID: 6403 RVA: 0x000EBFDA File Offset: 0x000EA1DA
		' (set) Token: 0x06001904 RID: 6404 RVA: 0x000EBFE4 File Offset: 0x000EA1E4
		Friend Overridable Property txtRequestNo As TextBox

		' Token: 0x170009B2 RID: 2482
		' (get) Token: 0x06001905 RID: 6405 RVA: 0x000EBFED File Offset: 0x000EA1ED
		' (set) Token: 0x06001906 RID: 6406 RVA: 0x000EBFF7 File Offset: 0x000EA1F7
		Friend Overridable Property Label5 As Label

		' Token: 0x170009B3 RID: 2483
		' (get) Token: 0x06001907 RID: 6407 RVA: 0x000EC000 File Offset: 0x000EA200
		' (set) Token: 0x06001908 RID: 6408 RVA: 0x000EC00A File Offset: 0x000EA20A
		Friend Overridable Property Label10 As Label

		' Token: 0x170009B4 RID: 2484
		' (get) Token: 0x06001909 RID: 6409 RVA: 0x000EC013 File Offset: 0x000EA213
		' (set) Token: 0x0600190A RID: 6410 RVA: 0x000EC01D File Offset: 0x000EA21D
		Friend Overridable Property dtpRequestDt As DateTimePicker

		' Token: 0x170009B5 RID: 2485
		' (get) Token: 0x0600190B RID: 6411 RVA: 0x000EC026 File Offset: 0x000EA226
		' (set) Token: 0x0600190C RID: 6412 RVA: 0x000EC030 File Offset: 0x000EA230
		Friend Overridable Property txtRequestID As TextBox

		' Token: 0x170009B6 RID: 2486
		' (get) Token: 0x0600190D RID: 6413 RVA: 0x000EC039 File Offset: 0x000EA239
		' (set) Token: 0x0600190E RID: 6414 RVA: 0x000EC043 File Offset: 0x000EA243
		Friend Overridable Property txtID As TextBox

		' Token: 0x170009B7 RID: 2487
		' (get) Token: 0x0600190F RID: 6415 RVA: 0x000EC04C File Offset: 0x000EA24C
		' (set) Token: 0x06001910 RID: 6416 RVA: 0x000EC056 File Offset: 0x000EA256
		Friend Overridable Property txtProduct As TextBox

		' Token: 0x170009B8 RID: 2488
		' (get) Token: 0x06001911 RID: 6417 RVA: 0x000EC05F File Offset: 0x000EA25F
		' (set) Token: 0x06001912 RID: 6418 RVA: 0x000EC069 File Offset: 0x000EA269
		Friend Overridable Property txtRequestedBy As TextBox

		' Token: 0x170009B9 RID: 2489
		' (get) Token: 0x06001913 RID: 6419 RVA: 0x000EC072 File Offset: 0x000EA272
		' (set) Token: 0x06001914 RID: 6420 RVA: 0x000EC07C File Offset: 0x000EA27C
		Friend Overridable Property txtNo As TextBox

		' Token: 0x170009BA RID: 2490
		' (get) Token: 0x06001915 RID: 6421 RVA: 0x000EC085 File Offset: 0x000EA285
		' (set) Token: 0x06001916 RID: 6422 RVA: 0x000EC08F File Offset: 0x000EA28F
		Friend Overridable Property Label7 As Label

		' Token: 0x170009BB RID: 2491
		' (get) Token: 0x06001917 RID: 6423 RVA: 0x000EC098 File Offset: 0x000EA298
		' (set) Token: 0x06001918 RID: 6424 RVA: 0x000EC0A2 File Offset: 0x000EA2A2
		Friend Overridable Property Label2 As Label

		' Token: 0x170009BC RID: 2492
		' (get) Token: 0x06001919 RID: 6425 RVA: 0x000EC0AB File Offset: 0x000EA2AB
		' (set) Token: 0x0600191A RID: 6426 RVA: 0x000EC0B5 File Offset: 0x000EA2B5
		Friend Overridable Property dtpMfgDt As DateTimePicker

		' Token: 0x170009BD RID: 2493
		' (get) Token: 0x0600191B RID: 6427 RVA: 0x000EC0BE File Offset: 0x000EA2BE
		' (set) Token: 0x0600191C RID: 6428 RVA: 0x000EC0C8 File Offset: 0x000EA2C8
		Friend Overridable Property Label1 As Label

		' Token: 0x170009BE RID: 2494
		' (get) Token: 0x0600191D RID: 6429 RVA: 0x000EC0D1 File Offset: 0x000EA2D1
		' (set) Token: 0x0600191E RID: 6430 RVA: 0x000EC0DB File Offset: 0x000EA2DB
		Friend Overridable Property Label8 As Label

		' Token: 0x170009BF RID: 2495
		' (get) Token: 0x0600191F RID: 6431 RVA: 0x000EC0E4 File Offset: 0x000EA2E4
		' (set) Token: 0x06001920 RID: 6432 RVA: 0x000EC0EE File Offset: 0x000EA2EE
		Friend Overridable Property dtpDt As DateTimePicker

		' Token: 0x170009C0 RID: 2496
		' (get) Token: 0x06001921 RID: 6433 RVA: 0x000EC0F7 File Offset: 0x000EA2F7
		' (set) Token: 0x06001922 RID: 6434 RVA: 0x000EC101 File Offset: 0x000EA301
		Friend Overridable Property dtpExpDt As DateTimePicker

		' Token: 0x170009C1 RID: 2497
		' (get) Token: 0x06001923 RID: 6435 RVA: 0x000EC10A File Offset: 0x000EA30A
		' (set) Token: 0x06001924 RID: 6436 RVA: 0x000EC114 File Offset: 0x000EA314
		Friend Overridable Property Label9 As Label

		' Token: 0x170009C2 RID: 2498
		' (get) Token: 0x06001925 RID: 6437 RVA: 0x000EC11D File Offset: 0x000EA31D
		' (set) Token: 0x06001926 RID: 6438 RVA: 0x000EC127 File Offset: 0x000EA327
		Friend Overridable Property Label6 As Label

		' Token: 0x170009C3 RID: 2499
		' (get) Token: 0x06001927 RID: 6439 RVA: 0x000EC130 File Offset: 0x000EA330
		' (set) Token: 0x06001928 RID: 6440 RVA: 0x000EC13A File Offset: 0x000EA33A
		Friend Overridable Property txtBatchNo As TextBox

		' Token: 0x170009C4 RID: 2500
		' (get) Token: 0x06001929 RID: 6441 RVA: 0x000EC143 File Offset: 0x000EA343
		' (set) Token: 0x0600192A RID: 6442 RVA: 0x000EC14D File Offset: 0x000EA34D
		Friend Overridable Property Label3 As Label

		' Token: 0x170009C5 RID: 2501
		' (get) Token: 0x0600192B RID: 6443 RVA: 0x000EC156 File Offset: 0x000EA356
		' (set) Token: 0x0600192C RID: 6444 RVA: 0x000EC160 File Offset: 0x000EA360
		Friend Overridable Property tab_lbl1 As Label

		' Token: 0x170009C6 RID: 2502
		' (get) Token: 0x0600192D RID: 6445 RVA: 0x000EC169 File Offset: 0x000EA369
		' (set) Token: 0x0600192E RID: 6446 RVA: 0x000EC173 File Offset: 0x000EA373
		Friend Overridable Property tpItem As TabPage

		' Token: 0x170009C7 RID: 2503
		' (get) Token: 0x0600192F RID: 6447 RVA: 0x000EC17C File Offset: 0x000EA37C
		' (set) Token: 0x06001930 RID: 6448 RVA: 0x000EC186 File Offset: 0x000EA386
		Friend Overridable Property Panel1 As Panel

		' Token: 0x170009C8 RID: 2504
		' (get) Token: 0x06001931 RID: 6449 RVA: 0x000EC18F File Offset: 0x000EA38F
		' (set) Token: 0x06001932 RID: 6450 RVA: 0x000EC199 File Offset: 0x000EA399
		Friend Overridable Property dgvDtls As DataGridView

		' Token: 0x170009C9 RID: 2505
		' (get) Token: 0x06001933 RID: 6451 RVA: 0x000EC1A2 File Offset: 0x000EA3A2
		' (set) Token: 0x06001934 RID: 6452 RVA: 0x000EC1AC File Offset: 0x000EA3AC
		Friend Overridable Property tpPicklist As TabPage

		' Token: 0x170009CA RID: 2506
		' (get) Token: 0x06001935 RID: 6453 RVA: 0x000EC1B5 File Offset: 0x000EA3B5
		' (set) Token: 0x06001936 RID: 6454 RVA: 0x000EC1BF File Offset: 0x000EA3BF
		Friend Overridable Property dgvPicklist As DataGridView

		' Token: 0x170009CB RID: 2507
		' (get) Token: 0x06001937 RID: 6455 RVA: 0x000EC1C8 File Offset: 0x000EA3C8
		' (set) Token: 0x06001938 RID: 6456 RVA: 0x000EC1D2 File Offset: 0x000EA3D2
		Friend Overridable Property tab_lbl3 As Label

		' Token: 0x170009CC RID: 2508
		' (get) Token: 0x06001939 RID: 6457 RVA: 0x000EC1DB File Offset: 0x000EA3DB
		' (set) Token: 0x0600193A RID: 6458 RVA: 0x000EC1E5 File Offset: 0x000EA3E5
		Friend Overridable Property tpBarcodes As TabPage

		' Token: 0x170009CD RID: 2509
		' (get) Token: 0x0600193B RID: 6459 RVA: 0x000EC1EE File Offset: 0x000EA3EE
		' (set) Token: 0x0600193C RID: 6460 RVA: 0x000EC1F8 File Offset: 0x000EA3F8
		Friend Overridable Property sml_btnAdd As Button
			<CompilerGenerated()>
			Get
				Return Me._sml_btnAdd
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.sml_btnAdd_Click
				Dim button As Button = Me._sml_btnAdd
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._sml_btnAdd = value
				button = Me._sml_btnAdd
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170009CE RID: 2510
		' (get) Token: 0x0600193D RID: 6461 RVA: 0x000EC23B File Offset: 0x000EA43B
		' (set) Token: 0x0600193E RID: 6462 RVA: 0x000EC245 File Offset: 0x000EA445
		Friend Overridable Property lblRows As Label

		' Token: 0x170009CF RID: 2511
		' (get) Token: 0x0600193F RID: 6463 RVA: 0x000EC24E File Offset: 0x000EA44E
		' (set) Token: 0x06001940 RID: 6464 RVA: 0x000EC258 File Offset: 0x000EA458
		Friend Overridable Property dgvUID As DataGridView
			<CompilerGenerated()>
			Get
				Return Me._dgvUID
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim dataGridViewCellEventHandler As DataGridViewCellEventHandler = AddressOf Me.dgvUID_CellContentClick
				Dim dataGridView As DataGridView = Me._dgvUID
				If dataGridView IsNot Nothing Then
					RemoveHandler dataGridView.CellContentClick, dataGridViewCellEventHandler
				End If
				Me._dgvUID = value
				dataGridView = Me._dgvUID
				If dataGridView IsNot Nothing Then
					AddHandler dataGridView.CellContentClick, dataGridViewCellEventHandler
				End If
			End Set
		End Property

		' Token: 0x170009D0 RID: 2512
		' (get) Token: 0x06001941 RID: 6465 RVA: 0x000EC29B File Offset: 0x000EA49B
		' (set) Token: 0x06001942 RID: 6466 RVA: 0x000EC2A5 File Offset: 0x000EA4A5
		Friend Overridable Property Label4 As Label

		' Token: 0x170009D1 RID: 2513
		' (get) Token: 0x06001943 RID: 6467 RVA: 0x000EC2AE File Offset: 0x000EA4AE
		' (set) Token: 0x06001944 RID: 6468 RVA: 0x000EC2B8 File Offset: 0x000EA4B8
		Friend Overridable Property txtBarcode As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtBarcode
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim keyEventHandler As KeyEventHandler = AddressOf Me.txtBarcode_KeyDown
				Dim textBox As TextBox = Me._txtBarcode
				If textBox IsNot Nothing Then
					RemoveHandler textBox.KeyDown, keyEventHandler
				End If
				Me._txtBarcode = value
				textBox = Me._txtBarcode
				If textBox IsNot Nothing Then
					AddHandler textBox.KeyDown, keyEventHandler
				End If
			End Set
		End Property

		' Token: 0x170009D2 RID: 2514
		' (get) Token: 0x06001945 RID: 6469 RVA: 0x000EC2FB File Offset: 0x000EA4FB
		' (set) Token: 0x06001946 RID: 6470 RVA: 0x000EC305 File Offset: 0x000EA505
		Friend Overridable Property tab_lbl4 As Label

		' Token: 0x170009D3 RID: 2515
		' (get) Token: 0x06001947 RID: 6471 RVA: 0x000EC30E File Offset: 0x000EA50E
		' (set) Token: 0x06001948 RID: 6472 RVA: 0x000EC318 File Offset: 0x000EA518
		Friend Overridable Property flpButton As FlowLayoutPanel

		' Token: 0x170009D4 RID: 2516
		' (get) Token: 0x06001949 RID: 6473 RVA: 0x000EC321 File Offset: 0x000EA521
		' (set) Token: 0x0600194A RID: 6474 RVA: 0x000EC32C File Offset: 0x000EA52C
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

		' Token: 0x170009D5 RID: 2517
		' (get) Token: 0x0600194B RID: 6475 RVA: 0x000EC36F File Offset: 0x000EA56F
		' (set) Token: 0x0600194C RID: 6476 RVA: 0x000EC37C File Offset: 0x000EA57C
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

		' Token: 0x170009D6 RID: 2518
		' (get) Token: 0x0600194D RID: 6477 RVA: 0x000EC3BF File Offset: 0x000EA5BF
		' (set) Token: 0x0600194E RID: 6478 RVA: 0x000EC3CC File Offset: 0x000EA5CC
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

		' Token: 0x170009D7 RID: 2519
		' (get) Token: 0x0600194F RID: 6479 RVA: 0x000EC40F File Offset: 0x000EA60F
		' (set) Token: 0x06001950 RID: 6480 RVA: 0x000EC41C File Offset: 0x000EA61C
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

		' Token: 0x170009D8 RID: 2520
		' (get) Token: 0x06001951 RID: 6481 RVA: 0x000EC45F File Offset: 0x000EA65F
		' (set) Token: 0x06001952 RID: 6482 RVA: 0x000EC46C File Offset: 0x000EA66C
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

		' Token: 0x170009D9 RID: 2521
		' (get) Token: 0x06001953 RID: 6483 RVA: 0x000EC4AF File Offset: 0x000EA6AF
		' (set) Token: 0x06001954 RID: 6484 RVA: 0x000EC4B9 File Offset: 0x000EA6B9
		Friend Overridable Property skip_lblStatus As Label

		' Token: 0x170009DA RID: 2522
		' (get) Token: 0x06001955 RID: 6485 RVA: 0x000EC4C2 File Offset: 0x000EA6C2
		' (set) Token: 0x06001956 RID: 6486 RVA: 0x000EC4CC File Offset: 0x000EA6CC
		Friend Overridable Property tab_lbl2 As Label

		' Token: 0x170009DB RID: 2523
		' (get) Token: 0x06001957 RID: 6487 RVA: 0x000EC4D5 File Offset: 0x000EA6D5
		' (set) Token: 0x06001958 RID: 6488 RVA: 0x000EC4E0 File Offset: 0x000EA6E0
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

		' Token: 0x170009DC RID: 2524
		' (get) Token: 0x06001959 RID: 6489 RVA: 0x000EC523 File Offset: 0x000EA723
		' (set) Token: 0x0600195A RID: 6490 RVA: 0x000EC52D File Offset: 0x000EA72D
		Friend Overridable Property ProductID As DataGridViewTextBoxColumn

		' Token: 0x170009DD RID: 2525
		' (get) Token: 0x0600195B RID: 6491 RVA: 0x000EC536 File Offset: 0x000EA736
		' (set) Token: 0x0600195C RID: 6492 RVA: 0x000EC540 File Offset: 0x000EA740
		Friend Overridable Property SrNo As DataGridViewTextBoxColumn

		' Token: 0x170009DE RID: 2526
		' (get) Token: 0x0600195D RID: 6493 RVA: 0x000EC549 File Offset: 0x000EA749
		' (set) Token: 0x0600195E RID: 6494 RVA: 0x000EC553 File Offset: 0x000EA753
		Friend Overridable Property ProductType As DataGridViewTextBoxColumn

		' Token: 0x170009DF RID: 2527
		' (get) Token: 0x0600195F RID: 6495 RVA: 0x000EC55C File Offset: 0x000EA75C
		' (set) Token: 0x06001960 RID: 6496 RVA: 0x000EC566 File Offset: 0x000EA766
		Friend Overridable Property CatalogNo As DataGridViewTextBoxColumn

		' Token: 0x170009E0 RID: 2528
		' (get) Token: 0x06001961 RID: 6497 RVA: 0x000EC56F File Offset: 0x000EA76F
		' (set) Token: 0x06001962 RID: 6498 RVA: 0x000EC579 File Offset: 0x000EA779
		Friend Overridable Property ProductName As DataGridViewTextBoxColumn

		' Token: 0x170009E1 RID: 2529
		' (get) Token: 0x06001963 RID: 6499 RVA: 0x000EC582 File Offset: 0x000EA782
		' (set) Token: 0x06001964 RID: 6500 RVA: 0x000EC58C File Offset: 0x000EA78C
		Friend Overridable Property Description As DataGridViewTextBoxColumn

		' Token: 0x170009E2 RID: 2530
		' (get) Token: 0x06001965 RID: 6501 RVA: 0x000EC595 File Offset: 0x000EA795
		' (set) Token: 0x06001966 RID: 6502 RVA: 0x000EC59F File Offset: 0x000EA79F
		Friend Overridable Property TertiaryUOM As DataGridViewTextBoxColumn

		' Token: 0x170009E3 RID: 2531
		' (get) Token: 0x06001967 RID: 6503 RVA: 0x000EC5A8 File Offset: 0x000EA7A8
		' (set) Token: 0x06001968 RID: 6504 RVA: 0x000EC5B2 File Offset: 0x000EA7B2
		Friend Overridable Property TertiaryPackSize As DataGridViewTextBoxColumn

		' Token: 0x170009E4 RID: 2532
		' (get) Token: 0x06001969 RID: 6505 RVA: 0x000EC5BB File Offset: 0x000EA7BB
		' (set) Token: 0x0600196A RID: 6506 RVA: 0x000EC5C5 File Offset: 0x000EA7C5
		Friend Overridable Property PrimaryUOM As DataGridViewTextBoxColumn

		' Token: 0x170009E5 RID: 2533
		' (get) Token: 0x0600196B RID: 6507 RVA: 0x000EC5CE File Offset: 0x000EA7CE
		' (set) Token: 0x0600196C RID: 6508 RVA: 0x000EC5D8 File Offset: 0x000EA7D8
		Friend Overridable Property PrimaryPackSize As DataGridViewTextBoxColumn

		' Token: 0x170009E6 RID: 2534
		' (get) Token: 0x0600196D RID: 6509 RVA: 0x000EC5E1 File Offset: 0x000EA7E1
		' (set) Token: 0x0600196E RID: 6510 RVA: 0x000EC5EB File Offset: 0x000EA7EB
		Friend Overridable Property ReqQty As DataGridViewTextBoxColumn

		' Token: 0x170009E7 RID: 2535
		' (get) Token: 0x0600196F RID: 6511 RVA: 0x000EC5F4 File Offset: 0x000EA7F4
		' (set) Token: 0x06001970 RID: 6512 RVA: 0x000EC5FE File Offset: 0x000EA7FE
		Friend Overridable Property IssuedQty As DataGridViewTextBoxColumn

		' Token: 0x170009E8 RID: 2536
		' (get) Token: 0x06001971 RID: 6513 RVA: 0x000EC607 File Offset: 0x000EA807
		' (set) Token: 0x06001972 RID: 6514 RVA: 0x000EC611 File Offset: 0x000EA811
		Friend Overridable Property PickedQty As DataGridViewTextBoxColumn

		' Token: 0x170009E9 RID: 2537
		' (get) Token: 0x06001973 RID: 6515 RVA: 0x000EC61A File Offset: 0x000EA81A
		' (set) Token: 0x06001974 RID: 6516 RVA: 0x000EC624 File Offset: 0x000EA824
		Friend Overridable Property lblRowsList As Label

		' Token: 0x170009EA RID: 2538
		' (get) Token: 0x06001975 RID: 6517 RVA: 0x000EC62D File Offset: 0x000EA82D
		' (set) Token: 0x06001976 RID: 6518 RVA: 0x000EC638 File Offset: 0x000EA838
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

		' Token: 0x170009EB RID: 2539
		' (get) Token: 0x06001977 RID: 6519 RVA: 0x000EC67B File Offset: 0x000EA87B
		' (set) Token: 0x06001978 RID: 6520 RVA: 0x000EC685 File Offset: 0x000EA885
		Friend Overridable Property tpRemarks As TabPage

		' Token: 0x170009EC RID: 2540
		' (get) Token: 0x06001979 RID: 6521 RVA: 0x000EC68E File Offset: 0x000EA88E
		' (set) Token: 0x0600197A RID: 6522 RVA: 0x000EC698 File Offset: 0x000EA898
		Friend Overridable Property tab_lbl5 As Label

		' Token: 0x170009ED RID: 2541
		' (get) Token: 0x0600197B RID: 6523 RVA: 0x000EC6A1 File Offset: 0x000EA8A1
		' (set) Token: 0x0600197C RID: 6524 RVA: 0x000EC6AB File Offset: 0x000EA8AB
		Friend Overridable Property lblRemarksApproval1 As Label

		' Token: 0x170009EE RID: 2542
		' (get) Token: 0x0600197D RID: 6525 RVA: 0x000EC6B4 File Offset: 0x000EA8B4
		' (set) Token: 0x0600197E RID: 6526 RVA: 0x000EC6BE File Offset: 0x000EA8BE
		Friend Overridable Property lblRemarks1 As Label

		' Token: 0x170009EF RID: 2543
		' (get) Token: 0x0600197F RID: 6527 RVA: 0x000EC6C7 File Offset: 0x000EA8C7
		' (set) Token: 0x06001980 RID: 6528 RVA: 0x000EC6D1 File Offset: 0x000EA8D1
		Friend Overridable Property Panel4 As Panel

		' Token: 0x170009F0 RID: 2544
		' (get) Token: 0x06001981 RID: 6529 RVA: 0x000EC6DA File Offset: 0x000EA8DA
		' (set) Token: 0x06001982 RID: 6530 RVA: 0x000EC6E4 File Offset: 0x000EA8E4
		Friend Overridable Property txtRemarksApproval As TextBox

		' Token: 0x170009F1 RID: 2545
		' (get) Token: 0x06001983 RID: 6531 RVA: 0x000EC6ED File Offset: 0x000EA8ED
		' (set) Token: 0x06001984 RID: 6532 RVA: 0x000EC6F7 File Offset: 0x000EA8F7
		Friend Overridable Property txtRemarks As TextBox

		' Token: 0x170009F2 RID: 2546
		' (get) Token: 0x06001985 RID: 6533 RVA: 0x000EC700 File Offset: 0x000EA900
		' (set) Token: 0x06001986 RID: 6534 RVA: 0x000EC70C File Offset: 0x000EA90C
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

		' Token: 0x170009F3 RID: 2547
		' (get) Token: 0x06001987 RID: 6535 RVA: 0x000EC74F File Offset: 0x000EA94F
		' (set) Token: 0x06001988 RID: 6536 RVA: 0x000EC75C File Offset: 0x000EA95C
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

		' Token: 0x170009F4 RID: 2548
		' (get) Token: 0x06001989 RID: 6537 RVA: 0x000EC79F File Offset: 0x000EA99F
		' (set) Token: 0x0600198A RID: 6538 RVA: 0x000EC7AC File Offset: 0x000EA9AC
		Friend Overridable Property cmbProduct As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbProduct
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbProduct_SelectedIndexChanged
				Dim comboBox As ComboBox = Me._cmbProduct
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.SelectedIndexChanged, eventHandler
				End If
				Me._cmbProduct = value
				comboBox = Me._cmbProduct
				If comboBox IsNot Nothing Then
					AddHandler comboBox.SelectedIndexChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170009F5 RID: 2549
		' (get) Token: 0x0600198B RID: 6539 RVA: 0x000EC7EF File Offset: 0x000EA9EF
		' (set) Token: 0x0600198C RID: 6540 RVA: 0x000EC7F9 File Offset: 0x000EA9F9
		Friend Overridable Property Label12 As Label

		' Token: 0x170009F6 RID: 2550
		' (get) Token: 0x0600198D RID: 6541 RVA: 0x000EC802 File Offset: 0x000EAA02
		' (set) Token: 0x0600198E RID: 6542 RVA: 0x000EC80C File Offset: 0x000EAA0C
		Friend Overridable Property btnDelete_Item As DataGridViewImageColumn

		' Token: 0x170009F7 RID: 2551
		' (get) Token: 0x0600198F RID: 6543 RVA: 0x000EC815 File Offset: 0x000EAA15
		' (set) Token: 0x06001990 RID: 6544 RVA: 0x000EC81F File Offset: 0x000EAA1F
		Friend Overridable Property uUID As DataGridViewTextBoxColumn

		' Token: 0x170009F8 RID: 2552
		' (get) Token: 0x06001991 RID: 6545 RVA: 0x000EC828 File Offset: 0x000EAA28
		' (set) Token: 0x06001992 RID: 6546 RVA: 0x000EC832 File Offset: 0x000EAA32
		Friend Overridable Property uParentUID As DataGridViewTextBoxColumn

		' Token: 0x170009F9 RID: 2553
		' (get) Token: 0x06001993 RID: 6547 RVA: 0x000EC83B File Offset: 0x000EAA3B
		' (set) Token: 0x06001994 RID: 6548 RVA: 0x000EC845 File Offset: 0x000EAA45
		Friend Overridable Property uCatalogNo As DataGridViewTextBoxColumn

		' Token: 0x170009FA RID: 2554
		' (get) Token: 0x06001995 RID: 6549 RVA: 0x000EC84E File Offset: 0x000EAA4E
		' (set) Token: 0x06001996 RID: 6550 RVA: 0x000EC858 File Offset: 0x000EAA58
		Friend Overridable Property uProductName As DataGridViewTextBoxColumn

		' Token: 0x170009FB RID: 2555
		' (get) Token: 0x06001997 RID: 6551 RVA: 0x000EC861 File Offset: 0x000EAA61
		' (set) Token: 0x06001998 RID: 6552 RVA: 0x000EC86B File Offset: 0x000EAA6B
		Friend Overridable Property uDescription As DataGridViewTextBoxColumn

		' Token: 0x170009FC RID: 2556
		' (get) Token: 0x06001999 RID: 6553 RVA: 0x000EC874 File Offset: 0x000EAA74
		' (set) Token: 0x0600199A RID: 6554 RVA: 0x000EC87E File Offset: 0x000EAA7E
		Friend Overridable Property uBatchNo As DataGridViewTextBoxColumn

		' Token: 0x170009FD RID: 2557
		' (get) Token: 0x0600199B RID: 6555 RVA: 0x000EC887 File Offset: 0x000EAA87
		' (set) Token: 0x0600199C RID: 6556 RVA: 0x000EC891 File Offset: 0x000EAA91
		Friend Overridable Property uMfgDt As DataGridViewTextBoxColumn

		' Token: 0x170009FE RID: 2558
		' (get) Token: 0x0600199D RID: 6557 RVA: 0x000EC89A File Offset: 0x000EAA9A
		' (set) Token: 0x0600199E RID: 6558 RVA: 0x000EC8A4 File Offset: 0x000EAAA4
		Friend Overridable Property uExpDt As DataGridViewTextBoxColumn

		' Token: 0x170009FF RID: 2559
		' (get) Token: 0x0600199F RID: 6559 RVA: 0x000EC8AD File Offset: 0x000EAAAD
		' (set) Token: 0x060019A0 RID: 6560 RVA: 0x000EC8B7 File Offset: 0x000EAAB7
		Friend Overridable Property uReceiptDt As DataGridViewTextBoxColumn

		' Token: 0x17000A00 RID: 2560
		' (get) Token: 0x060019A1 RID: 6561 RVA: 0x000EC8C0 File Offset: 0x000EAAC0
		' (set) Token: 0x060019A2 RID: 6562 RVA: 0x000EC8CA File Offset: 0x000EAACA
		Friend Overridable Property uProductID As DataGridViewTextBoxColumn

		' Token: 0x17000A01 RID: 2561
		' (get) Token: 0x060019A3 RID: 6563 RVA: 0x000EC8D3 File Offset: 0x000EAAD3
		' (set) Token: 0x060019A4 RID: 6564 RVA: 0x000EC8DD File Offset: 0x000EAADD
		Friend Overridable Property uExpiryType As DataGridViewTextBoxColumn

		' Token: 0x17000A02 RID: 2562
		' (get) Token: 0x060019A5 RID: 6565 RVA: 0x000EC8E6 File Offset: 0x000EAAE6
		' (set) Token: 0x060019A6 RID: 6566 RVA: 0x000EC8F0 File Offset: 0x000EAAF0
		Friend Overridable Property txtBOMVersion As TextBox

		' Token: 0x17000A03 RID: 2563
		' (get) Token: 0x060019A7 RID: 6567 RVA: 0x000EC8F9 File Offset: 0x000EAAF9
		' (set) Token: 0x060019A8 RID: 6568 RVA: 0x000EC903 File Offset: 0x000EAB03
		Friend Overridable Property pUOM As DataGridViewTextBoxColumn

		' Token: 0x17000A04 RID: 2564
		' (get) Token: 0x060019A9 RID: 6569 RVA: 0x000EC90C File Offset: 0x000EAB0C
		' (set) Token: 0x060019AA RID: 6570 RVA: 0x000EC916 File Offset: 0x000EAB16
		Friend Overridable Property pPrimaryPackSize As DataGridViewTextBoxColumn

		' Token: 0x17000A05 RID: 2565
		' (get) Token: 0x060019AB RID: 6571 RVA: 0x000EC91F File Offset: 0x000EAB1F
		' (set) Token: 0x060019AC RID: 6572 RVA: 0x000EC929 File Offset: 0x000EAB29
		Friend Overridable Property FinalConcentration As DataGridViewTextBoxColumn

		' Token: 0x17000A06 RID: 2566
		' (get) Token: 0x060019AD RID: 6573 RVA: 0x000EC932 File Offset: 0x000EAB32
		' (set) Token: 0x060019AE RID: 6574 RVA: 0x000EC93C File Offset: 0x000EAB3C
		Friend Overridable Property Titre As DataGridViewTextBoxColumn

		' Token: 0x17000A07 RID: 2567
		' (get) Token: 0x060019AF RID: 6575 RVA: 0x000EC945 File Offset: 0x000EAB45
		' (set) Token: 0x060019B0 RID: 6576 RVA: 0x000EC94F File Offset: 0x000EAB4F
		Friend Overridable Property CellCount As DataGridViewTextBoxColumn

		' Token: 0x17000A08 RID: 2568
		' (get) Token: 0x060019B1 RID: 6577 RVA: 0x000EC958 File Offset: 0x000EAB58
		' (set) Token: 0x060019B2 RID: 6578 RVA: 0x000EC962 File Offset: 0x000EAB62
		Friend Overridable Property ODPermL As DataGridViewTextBoxColumn

		' Token: 0x17000A09 RID: 2569
		' (get) Token: 0x060019B3 RID: 6579 RVA: 0x000EC96B File Offset: 0x000EAB6B
		' (set) Token: 0x060019B4 RID: 6580 RVA: 0x000EC975 File Offset: 0x000EAB75
		Friend Overridable Property pUID As DataGridViewTextBoxColumn

		' Token: 0x17000A0A RID: 2570
		' (get) Token: 0x060019B5 RID: 6581 RVA: 0x000EC97E File Offset: 0x000EAB7E
		' (set) Token: 0x060019B6 RID: 6582 RVA: 0x000EC988 File Offset: 0x000EAB88
		Friend Overridable Property pParentUID As DataGridViewTextBoxColumn

		' Token: 0x17000A0B RID: 2571
		' (get) Token: 0x060019B7 RID: 6583 RVA: 0x000EC991 File Offset: 0x000EAB91
		' (set) Token: 0x060019B8 RID: 6584 RVA: 0x000EC99B File Offset: 0x000EAB9B
		Friend Overridable Property pLocation As DataGridViewTextBoxColumn

		' Token: 0x17000A0C RID: 2572
		' (get) Token: 0x060019B9 RID: 6585 RVA: 0x000EC9A4 File Offset: 0x000EABA4
		' (set) Token: 0x060019BA RID: 6586 RVA: 0x000EC9AE File Offset: 0x000EABAE
		Friend Overridable Property pLocationName As DataGridViewTextBoxColumn

		' Token: 0x17000A0D RID: 2573
		' (get) Token: 0x060019BB RID: 6587 RVA: 0x000EC9B7 File Offset: 0x000EABB7
		' (set) Token: 0x060019BC RID: 6588 RVA: 0x000EC9C1 File Offset: 0x000EABC1
		Friend Overridable Property pCatalogNo As DataGridViewTextBoxColumn

		' Token: 0x17000A0E RID: 2574
		' (get) Token: 0x060019BD RID: 6589 RVA: 0x000EC9CA File Offset: 0x000EABCA
		' (set) Token: 0x060019BE RID: 6590 RVA: 0x000EC9D4 File Offset: 0x000EABD4
		Friend Overridable Property pProductName As DataGridViewTextBoxColumn

		' Token: 0x17000A0F RID: 2575
		' (get) Token: 0x060019BF RID: 6591 RVA: 0x000EC9DD File Offset: 0x000EABDD
		' (set) Token: 0x060019C0 RID: 6592 RVA: 0x000EC9E7 File Offset: 0x000EABE7
		Friend Overridable Property pDescription As DataGridViewTextBoxColumn

		' Token: 0x17000A10 RID: 2576
		' (get) Token: 0x060019C1 RID: 6593 RVA: 0x000EC9F0 File Offset: 0x000EABF0
		' (set) Token: 0x060019C2 RID: 6594 RVA: 0x000EC9FA File Offset: 0x000EABFA
		Friend Overridable Property pBatchNo As DataGridViewTextBoxColumn

		' Token: 0x17000A11 RID: 2577
		' (get) Token: 0x060019C3 RID: 6595 RVA: 0x000ECA03 File Offset: 0x000EAC03
		' (set) Token: 0x060019C4 RID: 6596 RVA: 0x000ECA0D File Offset: 0x000EAC0D
		Friend Overridable Property pMfgDt As DataGridViewTextBoxColumn

		' Token: 0x17000A12 RID: 2578
		' (get) Token: 0x060019C5 RID: 6597 RVA: 0x000ECA16 File Offset: 0x000EAC16
		' (set) Token: 0x060019C6 RID: 6598 RVA: 0x000ECA20 File Offset: 0x000EAC20
		Friend Overridable Property pExpDt As DataGridViewTextBoxColumn

		' Token: 0x17000A13 RID: 2579
		' (get) Token: 0x060019C7 RID: 6599 RVA: 0x000ECA29 File Offset: 0x000EAC29
		' (set) Token: 0x060019C8 RID: 6600 RVA: 0x000ECA33 File Offset: 0x000EAC33
		Friend Overridable Property pReceiptDt As DataGridViewTextBoxColumn

		' Token: 0x17000A14 RID: 2580
		' (get) Token: 0x060019C9 RID: 6601 RVA: 0x000ECA3C File Offset: 0x000EAC3C
		' (set) Token: 0x060019CA RID: 6602 RVA: 0x000ECA46 File Offset: 0x000EAC46
		Friend Overridable Property pExpiryType As DataGridViewTextBoxColumn

		' Token: 0x17000A15 RID: 2581
		' (get) Token: 0x060019CB RID: 6603 RVA: 0x000ECA4F File Offset: 0x000EAC4F
		' (set) Token: 0x060019CC RID: 6604 RVA: 0x000ECA59 File Offset: 0x000EAC59
		Friend Overridable Property pProductID As DataGridViewTextBoxColumn

		' Token: 0x060019CD RID: 6605
		Private Declare Sub SendMessage Lib "user32.DLL" (hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

		' Token: 0x060019CE RID: 6606
		Private Declare Sub ReleaseCapture Lib "user32.DLL" ()

		' Token: 0x060019CF RID: 6607 RVA: 0x000ECA62 File Offset: 0x000EAC62
		Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs)
			Picking.ReleaseCapture()
			Picking.SendMessage(MyBase.Handle, 274, 61458, 0)
		End Sub

		' Token: 0x060019D0 RID: 6608 RVA: 0x000ECA84 File Offset: 0x000EAC84
		Public Sub New(sForm As String, dr As DataRow)
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			AddHandler MyBase.Shown, AddressOf Me.Me_Shown
			Me.InitializeComponent()
			Designing.SetTheme(Me)
			Me.picFormIcon.Image = ResourceModule.imgFormIconPic
			MyBase.FormBorderStyle = FormBorderStyle.None
			Me.BackColor = Color.DarkGray
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.lblCaption.Text = Me.Text
			Me.form_btnClose.DialogResult = DialogResult.Cancel
			Me.sFormType = sForm
			Me.drData = dr
			Me.Text = Me.sFormType
		End Sub

		' Token: 0x060019D1 RID: 6609 RVA: 0x000ECB4F File Offset: 0x000EAD4F
		Private Sub form_btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x060019D2 RID: 6610 RVA: 0x000ECB5C File Offset: 0x000EAD5C
		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x060019D3 RID: 6611 RVA: 0x000ECB91 File Offset: 0x000EAD91
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Me.FillData()
			Me.SetForm()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x060019D4 RID: 6612 RVA: 0x000ECBB9 File Offset: 0x000EADB9
		Private Sub Me_Shown(sender As Object, e As EventArgs)
			Me.SetTabs()
		End Sub

		' Token: 0x060019D5 RID: 6613 RVA: 0x000ECBC4 File Offset: 0x000EADC4
		Private Sub SetTabs()
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = CInt(Math.Round(CDbl((Me.theme_tc.Width - 4)) / 5.0))
			Me.theme_tc.ItemSize = New Size(num, 30)
			Me.tab_lbl1.Width = num
			Me.tab_lbl2.Width = num + 3
			Me.tab_lbl3.Width = num + 3
			Me.tab_lbl4.Width = num + 3
			Me.tab_lbl5.Width = num + 3
			Me.tab_lbl1.Location = New Point(0, 0)
			Me.tab_lbl2.Location = New Point(num - 4, 0)
			Me.tab_lbl3.Location = New Point(num * 2 - 4, 0)
			Me.tab_lbl4.Location = New Point(num * 3 - 4, 0)
			Me.tab_lbl5.Location = New Point(num * 4 - 4, 0)
		End Sub

		' Token: 0x060019D6 RID: 6614 RVA: 0x000ECCBC File Offset: 0x000EAEBC
		Private Sub FillData()
			Try
				Dim flag As Boolean = Not Information.IsNothing(Me.drData)
				If flag Then
					Dim flag2 As Boolean = Me.drData.Table.Columns.Contains("RequestID")
					If flag2 Then
						Me.txtID.Text = Conversions.ToString(Me.drData("ID"))
						Me.txtRequestID.Text = Conversions.ToString(Me.drData("RequestID"))
						Me.txtNo.Text = Conversions.ToString(Me.drData("PickingNo"))
						Me.dtpDt.Value = Conversions.ToDate(Me.drData("PickingDt"))
						Me.txtPickingByID.Text = Me.drData("PickingBy").ToString()
						Me.txtPickingBy.Text = Me.drData("Picking By").ToString()
						Me.txtRemarks.Text = Me.drData("Remarks").ToString()
						Me.txtRemarksApproval.Text = Me.drData("ActionRemarks").ToString()
						Me.skip_lblStatus.Text = Conversions.ToString(Me.drData("Status"))
					Else
						Me.txtID.Text = ""
						Me.txtRequestID.Text = Conversions.ToString(Me.drData("ID"))
					End If
					Me.txtRequestNo.Text = Conversions.ToString(Me.drData("RequestNo"))
					Me.dtpRequestDt.Value = Conversions.ToDate(Me.drData("RequestDt"))
					Me.txtRequestedByID.Text = Conversions.ToString(Me.drData("RequestedBy"))
					Me.txtRequestedBy.Text = Conversions.ToString(Me.drData("Requested By"))
					Me.txtProductID.Text = Conversions.ToString(Me.drData("ProductID"))
					Me.txtProduct.Text = Conversions.ToString(Me.drData("ProductName"))
					Me.txtBatchNo.Text = Conversions.ToString(Me.drData("BatchNo"))
					Dim flag3 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.drData("MfgDt")))
					If flag3 Then
						Me.dtpMfgDt.Value = Conversions.ToDate(Me.drData("MfgDt"))
					Else
						Me.dtpMfgDt.CustomFormat = " "
					End If
					Dim flag4 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.drData("ExpDt")))
					If flag4 Then
						Me.dtpExpDt.Value = Conversions.ToDate(Me.drData("MfgDt"))
					Else
						Me.dtpExpDt.CustomFormat = " "
					End If
					Me.txtBOMVersion.Text = Me.drData("BOMVersion").ToString()
					Me.GetPickList()
					Me.FillItems()
					Me.FillUID()
					Dim flag5 As Boolean = Operators.CompareString(Me.txtRemarksApproval.Text, "", False) = 0
					If flag5 Then
						Me.lblRemarksApproval.Visible = False
					Else
						Me.lblRemarksApproval.Visible = True
					End If
					Me.lblRemarks_Click(Nothing, Nothing)
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x060019D7 RID: 6615 RVA: 0x000ED0C8 File Offset: 0x000EB2C8
		Private Sub FillItems()
			Dim text As String = "  SELECT ROW_NUMBER() OVER(ORDER BY RequestDtlsID) AS SrNo, RD.ProductID, " & vbCrLf
			text += " P.ProductType, CatalogNo, P.ProductName, Description, " & vbCrLf
			text += "  P.TertiaryUOM, P.TertiaryPackSize, P.PrimaryUOM, P.PrimaryPackSize, P.ExpiryType, " & vbCrLf
			text += " RequiredQty, ISNULL(IssuedQty,0) IssuedQty , ISNULL(PickedQty,0) PickedQty " & vbCrLf
			text += " FROM RequestDtls RD INNER JOIN Product P On RD.ProductID = P.ProductID " & vbCrLf
			text += " LEFT OUTER JOIN " & vbCrLf
			text += "  (SELECT I.RequestID, ID.ProductID, COUNT(UID) AS IssuedQty " & vbCrLf
			text += "   FROM Issue I INNER JOIN IssueDtls ID ON I.IssueID = ID.IssueID " & vbCrLf
			text += "   WHERE I.Status IN ('Issued', 'QA Approved') GROUP BY I.RequestID, ID.ProductID) " & vbCrLf
			text += " AS I ON I.RequestID = RD.RequestID AND I.ProductID = RD.ProductID " & vbCrLf
			text += " LEFT OUTER JOIN " & vbCrLf
			text += "  (SELECT I.RequestID, ID.ProductID, COUNT(UID) AS PickedQty " & vbCrLf
			text += "   FROM Issue I INNER JOIN IssueDtls ID ON I.IssueID = ID.IssueID " & vbCrLf
			text += "   WHERE I.Status IN ('Picked', 'QA On-Hold') GROUP BY I.RequestID, ID.ProductID) " & vbCrLf
			text += " AS Pk ON Pk.RequestID = RD.RequestID AND Pk.ProductID = RD.ProductID " & vbCrLf
			text = text + " WHERE RD.RequestID = '" + Me.txtRequestID.Text + "'"
			Me.dtItems = MainModule.GetData(text)
			Me.dgvDtls.DataSource = Me.dtItems
		End Sub

		' Token: 0x060019D8 RID: 6616 RVA: 0x000ED1C0 File Offset: 0x000EB3C0
		Private Sub GetPickList()
			Dim text As String = " SELECT P.PrimaryUOM, GI.PrimaryPackSize, UID, ParentUID, GU.LocationCode, LocationName, P.ProductID, P.ProductType, P.CatalogNo, P.ProductName, " & vbCrLf
			text += " GU.Description, GU.BatchNo, GU.MfgDt, GU.ExpDt, GU.CreationDt ReceiptDt, GU.ExpiryType, "
			text += " FinalConcentration, Titre, CellCount, ODPermL " & vbCrLf
			text += " FROM RequestDtls RD " & vbCrLf
			text += " INNER JOIN GRNUID GU ON RD.ProductID = GU.ProductID " & vbCrLf
			text += " INNER JOIN GRNItems GI ON GU.GRNItemsID = GI.GRNItemsID " & vbCrLf
			text += " INNER JOIN Product P ON GU.ProductID = P.ProductID " & vbCrLf
			text += " LEFT OUTER JOIN Location L ON GU.LocationCode = L.LocationCode " & vbCrLf
			text = text + " WHERE GU.Status = 'Available' AND RD.RequestID = '" + Me.txtRequestID.Text + "' " & vbCrLf
			text += " AND ISNULL(GU.ExpDt,'01/01/2050') > GETDATE() " & vbCrLf
			text += " ORDER BY P.ProductID, ExpDt " & vbCrLf
			Me.dtPicklist = MainModule.GetData(text)
			Dim dataTable As DataTable = Me.dtPicklist.DefaultView.ToTable(True, New String() { "ProductID", "CatalogNo" })
			dataTable.Rows.InsertAt(dataTable.NewRow(), 0)
			Me.cmbProduct.ValueMember = "ProductID"
			Me.cmbProduct.DisplayMember = "CatalogNo"
			Me.cmbProduct.DataSource = dataTable
			Me.cmbProduct.SelectedIndex = -1
		End Sub

		' Token: 0x060019D9 RID: 6617 RVA: 0x000ED2E0 File Offset: 0x000EB4E0
		Private Sub FillUID()
			Dim text As String = " SELECT ID.UID, GU.ParentUID, P.CatalogNo, P.ProductName, " & vbCrLf
			text += " GU.BatchNo, GU.MfgDt, GU.ExpDt, GU.CreationDt ReceiptDt, GU.Description, GU.ExpiryType, GU.Expiry, ID.ProductID " & vbCrLf
			text += " FROM IssueDtls ID " & vbCrLf
			text += " INNER JOIN Product P ON ID.ProductID = P.ProductID " & vbCrLf
			text += " INNER JOIN GRNUID GU ON ID.UID = GU.UID " & vbCrLf
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				text = text + " WHERE ID.IssueID = '" + Me.txtID.Text + "'"
			Else
				text += " WHERE ID.IssueID = '0'"
			End If
			Me.dtUID = MainModule.GetData(text)
			Me.dgvUID.DataSource = Me.dtUID
			Me.lblRows.Text = Conversions.ToString(Me.dtUID.Rows.Count) + " - Row(s)"
		End Sub

		' Token: 0x060019DA RID: 6618 RVA: 0x000ED3B8 File Offset: 0x000EB5B8
		Private Sub SetForm()
			Dim text As String = Me.sFormType
			If Operators.CompareString(text, "Picking", False) <> 0 Then
				If Operators.CompareString(text, "QA Approval", False) <> 0 Then
					If Operators.CompareString(text, "Issue", False) = 0 Then
						Me.txtBarcode.Enabled = False
						Me.txtRemarks.[ReadOnly] = True
						Me.dgvUID.Columns("btnDelete_Item").Visible = False
						Me.sml_btnAdd.Enabled = False
						Me.btnSave.Visible = False
						Me.btnClear.Visible = False
					End If
				Else
					Me.lblCaption.Text = "Picking Approval"
					Me.txtBarcode.Enabled = False
					Me.txtRemarks.[ReadOnly] = True
					Me.dgvUID.Columns("btnDelete_Item").Visible = False
					Me.sml_btnAdd.Enabled = False
					Me.btnSave.Visible = False
					Me.btnClear.Visible = False
					Me.flpButton.Width = (Me.btnApprove.Width + 2) * 7 - Me.btnApprove.Width * 3
				End If
			Else
				Me.btnApprove.Visible = False
				Me.btnOnHold.Visible = False
				Me.btnReject.Visible = False
				Me.flpButton.Width = (Me.btnApprove.Width + 2) * 7 - Me.btnApprove.Width * 3
			End If
			Dim text2 As String = Me.skip_lblStatus.Text
			If Operators.CompareString(text2, "New Picking", False) <> 0 Then
				If Operators.CompareString(text2, "Picked", False) <> 0 Then
					If Operators.CompareString(text2, "QA Approved", False) = 0 OrElse Operators.CompareString(text2, "QA Rejected", False) = 0 OrElse Operators.CompareString(text2, "Cancelled", False) = 0 OrElse Operators.CompareString(text2, "Issued", False) = 0 Then
						Me.dgvUID.Columns("btnDelete_Item").Visible = False
						Me.sml_btnAdd.Enabled = False
						Me.btnSave.Enabled = False
						Me.btnClear.Enabled = False
						Me.btnApprove.Enabled = False
						Me.btnOnHold.Enabled = False
						Me.btnReject.Enabled = False
						Me.btnCancel.Enabled = False
					End If
				End If
			Else
				Me.btnCancel.Enabled = False
			End If
			Me.flpButton.Left = CInt(Math.Round(CDbl(MyBase.Width) / 2.0 - CDbl(Me.flpButton.Width) / 2.0))
			Me.sEmailTo = GlobalVariables.gsEmailID
			Dim flag As Boolean = Not Information.IsNothing(Me.drData)
			If flag Then
				Dim flag2 As Boolean = (Operators.CompareString(Me.drData("CreatedByEmailID").ToString(), "", False) <> 0) And (Operators.CompareString(Me.drData("CreatedByEmailID").ToString(), GlobalVariables.gsEmailID, False) <> 0)
				If flag2 Then
					Dim ptr As __ByRef(Of String) = Me.sEmailTo
					Me.sEmailTo = ptr + ":" + Me.drData("CreatedByEmailID").ToString()
				End If
			End If
		End Sub

		' Token: 0x060019DB RID: 6619 RVA: 0x000ED718 File Offset: 0x000EB918
		Private Sub ClearForm()
			Me.txtBarcode.Text = ""
			Me.dtUID.Rows.Clear()
			Me.lblRows.Text = Conversions.ToString(Me.dtUID.Rows.Count) + " - Row(s)"
			Me.dgvUID.DataSource = Me.dtUID
		End Sub

		' Token: 0x060019DC RID: 6620 RVA: 0x000ED785 File Offset: 0x000EB985
		Private Sub btnClear_Click(sender As Object, e As EventArgs)
			Me.ClearForm()
		End Sub

		' Token: 0x060019DD RID: 6621 RVA: 0x000ED78F File Offset: 0x000EB98F
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x060019DE RID: 6622 RVA: 0x000ED79C File Offset: 0x000EB99C
		Private Sub cmbProduct_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbProduct.SelectedIndex > 0
			If flag Then
				Me.FillPickList()
			Else
				Me.cmbProduct.Text = ""
				Dim dataView As DataView = New DataView(Me.dtPicklist, "ProductID = 0", "", DataViewRowState.CurrentRows)
				Me.dgvPicklist.DataSource = dataView.ToTable()
				Me.lblRowsList.Text = Conversions.ToString(dataView.ToTable().Rows.Count) + " - Rows"
			End If
		End Sub

		' Token: 0x060019DF RID: 6623 RVA: 0x000ED830 File Offset: 0x000EBA30
		Private Sub FillPickList()
			Dim dataRow As DataRow = Me.dtPicklist.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("ProductID = '", Me.cmbProduct.SelectedValue), "'")))(0)
			Dim text As String = ""
			Dim text2 As String = dataRow("ExpiryType").ToString()
			If Operators.CompareString(text2, "NA", False) <> 0 Then
				If Operators.CompareString(text2, "Expiry Date", False) <> 0 Then
					If Operators.CompareString(text2, "When Delivered", False) <> 0 Then
						If Operators.CompareString(text2, "When Opened", False) = 0 Then
							text = "ReceiptDt"
						End If
					Else
						text = "ExpDt"
					End If
				Else
					text = "ExpDt"
				End If
			Else
				text = "ReceiptDt"
			End If
			Dim text3 As String = dataRow("ProductType").ToString()
			Dim text4 As String
			If Operators.CompareString(text3, "Cell Bank - Mammalian", False) <> 0 Then
				If Operators.CompareString(text3, "Cell Bank - Bacterial", False) <> 0 Then
					If Operators.CompareString(text3, "Semi Finished", False) <> 0 Then
						text4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(" ProductID = '", Me.cmbProduct.SelectedValue), "'"))
						Me.dgvPicklist.Columns("FinalConcentration").Visible = False
						Me.dgvPicklist.Columns("Titre").Visible = False
						Me.dgvPicklist.Columns("CellCount").Visible = False
						Me.dgvPicklist.Columns("ODPermL").Visible = False
					Else
						text4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(" ProductID = '", Me.cmbProduct.SelectedValue), "'"))
						text4 += " AND ISNULL(FinalConcentration, '') <> ''"
						text4 += " AND ISNULL(Titre, '') <> ''"
						Me.dgvPicklist.Columns("FinalConcentration").Visible = True
						Me.dgvPicklist.Columns("Titre").Visible = True
						Me.dgvPicklist.Columns("CellCount").Visible = False
						Me.dgvPicklist.Columns("ODPermL").Visible = False
						Me.dgvPicklist.Columns("pPrimaryPackSize").Visible = True
						Me.dgvPicklist.Columns("pPrimaryPackSize").HeaderText = "Volume"
					End If
				Else
					text4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(" ProductID = '", Me.cmbProduct.SelectedValue), "'"))
					Me.dgvPicklist.Columns("FinalConcentration").Visible = False
					Me.dgvPicklist.Columns("Titre").Visible = False
					Me.dgvPicklist.Columns("CellCount").Visible = False
					Me.dgvPicklist.Columns("ODPermL").Visible = True
					Me.dgvPicklist.Columns("pPrimaryPackSize").Visible = True
					Me.dgvPicklist.Columns("pPrimaryPackSize").HeaderText = "Volume"
				End If
			Else
				text4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(" ProductID = '", Me.cmbProduct.SelectedValue), "' "))
				Me.dgvPicklist.Columns("FinalConcentration").Visible = False
				Me.dgvPicklist.Columns("Titre").Visible = False
				Me.dgvPicklist.Columns("CellCount").Visible = True
				Me.dgvPicklist.Columns("ODPermL").Visible = False
				Me.dgvPicklist.Columns("pPrimaryPackSize").Visible = True
				Me.dgvPicklist.Columns("pPrimaryPackSize").HeaderText = "Volume"
			End If
			Dim flag As Boolean = Not Information.IsNothing(Me.dtPicklist)
			If flag Then
				Dim dataView As DataView = New DataView(Me.dtPicklist, text4, text, DataViewRowState.CurrentRows)
				Me.dgvPicklist.DataSource = dataView.ToTable()
				Me.lblRowsList.Text = Conversions.ToString(dataView.ToTable().Rows.Count) + " - Rows"
			End If
		End Sub

		' Token: 0x060019E0 RID: 6624 RVA: 0x000EDCD4 File Offset: 0x000EBED4
		Private Sub txtBarcode_KeyDown(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = e.KeyCode = Keys.[Return]
			If flag Then
				Me.AddBarcode()
			End If
		End Sub

		' Token: 0x060019E1 RID: 6625 RVA: 0x000EDCF9 File Offset: 0x000EBEF9
		Private Sub sml_btnAdd_Click(sender As Object, e As EventArgs)
			Me.AddBarcode()
		End Sub

		' Token: 0x060019E2 RID: 6626 RVA: 0x000EDD04 File Offset: 0x000EBF04
		Private Function ValidateAdd() As Boolean
			Dim flag As Boolean = (Strings.Trim(Me.txtBarcode.Text).Length <> 10) And (Strings.Trim(Me.txtBarcode.Text).Length <> 9)
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Invalid Product Barcode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.txtBarcode.Focus()
				flag2 = False
			Else
				Dim flag3 As Boolean = (Operators.CompareString(Strings.Mid(Strings.Trim(Me.txtBarcode.Text), 1, 2), "IA", False) <> 0) Or Not Versioned.IsNumeric(Strings.Mid(Strings.Trim(Me.txtBarcode.Text), 6))
				If flag3 Then
					CustomMsgBox.Show("Invalid Product Barcode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.txtBarcode.Focus()
					flag2 = False
				Else
					Dim flag4 As Boolean = Strings.Trim(Me.txtBarcode.Text).Length = 9
					Dim array As DataRow()
					If flag4 Then
						Dim flag5 As Boolean = Me.dtUID.[Select]("ParentUID = '" + Strings.Trim(Me.txtBarcode.Text) + "'").Length > 0
						If flag5 Then
							CustomMsgBox.Show("Parent Barcode Already In List.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.txtBarcode.Focus()
							Return False
						End If
						array = Me.dtPicklist.[Select]("ParentUID = '" + Strings.Trim(Me.txtBarcode.Text) + "'")
						Dim flag6 As Boolean = array.Length = 0
						If flag6 Then
							CustomMsgBox.Show("Parent Barcode Not In Picklist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.txtBarcode.Focus()
							Return False
						End If
					Else
						Dim flag7 As Boolean = Strings.Trim(Me.txtBarcode.Text).Length = 10
						If Not flag7 Then
							Return False
						End If
						Dim flag8 As Boolean = Me.dtUID.[Select]("UID = '" + Strings.Trim(Me.txtBarcode.Text) + "'").Length > 0
						If flag8 Then
							CustomMsgBox.Show("Product Barcode Already In List.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.txtBarcode.Focus()
							Return False
						End If
						array = Me.dtPicklist.[Select]("UID = '" + Strings.Trim(Me.txtBarcode.Text) + "'")
						Dim flag9 As Boolean = array.Length = 0
						If flag9 Then
							CustomMsgBox.Show("Product Barcode Not In Picklist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.txtBarcode.Focus()
							Return False
						End If
					End If
					Dim dataRow As DataRow = Me.dtItems.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("ProductID = '", array(0)("ProductID")), "'")))(0)
					Dim num As Integer = Conversions.ToInteger(dataRow("RequiredQty"))
					Dim num2 As Integer = Conversions.ToInteger(dataRow("IssuedQty"))
					Dim num3 As Integer = Conversions.ToInteger(dataRow("PickedQty"))
					Dim num4 As Integer = Conversions.ToInteger(Me.dtUID.Compute("COUNT(UID)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("ProductID = '", array(0)("ProductID")), "'"))))
					Dim flag10 As Boolean = num < num2 + num3 + array.Length
					If flag10 Then
						CustomMsgBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Required Quantity Exceeded For Product : ", dataRow("ProductName")), ".")), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.txtBarcode.Focus()
						flag2 = False
					Else
						flag2 = True
					End If
				End If
			End If
			Return flag2
		End Function

		' Token: 0x060019E3 RID: 6627 RVA: 0x000EE0B4 File Offset: 0x000EC2B4
		Private Sub AddBarcode()
			' The following expression was wrapped in a checked-statement
			Try
				Dim flag As Boolean = Not Me.ValidateAdd()
				If Not flag Then
					Dim flag2 As Boolean = Strings.Trim(Me.txtBarcode.Text).Length = 9
					Dim array As DataRow()
					If flag2 Then
						array = Me.dtPicklist.[Select]("ParentUID = '" + Strings.Trim(Me.txtBarcode.Text) + "'")
					Else
						Dim flag3 As Boolean = Strings.Trim(Me.txtBarcode.Text).Length = 10
						If Not flag3 Then
							Return
						End If
						array = Me.dtPicklist.[Select]("UID = '" + Strings.Trim(Me.txtBarcode.Text) + "'")
					End If
					Dim num As Integer = array.Length - 1
					For i As Integer = 0 To num
						Me.dtUID.Rows.InsertAt(Me.dtUID.NewRow(), 0)
						Me.dtUID.Rows(0)("UID") = RuntimeHelpers.GetObjectValue(array(i)("UID"))
						Me.dtUID.Rows(0)("ParentUID") = RuntimeHelpers.GetObjectValue(array(i)("ParentUID"))
						Me.dtUID.Rows(0)("CatalogNo") = RuntimeHelpers.GetObjectValue(array(i)("CatalogNo"))
						Me.dtUID.Rows(0)("ProductName") = RuntimeHelpers.GetObjectValue(array(i)("ProductName"))
						Me.dtUID.Rows(0)("BatchNo") = RuntimeHelpers.GetObjectValue(array(i)("BatchNo"))
						Me.dtUID.Rows(0)("MfgDt") = RuntimeHelpers.GetObjectValue(array(i)("MfgDt"))
						Me.dtUID.Rows(0)("ExpDt") = RuntimeHelpers.GetObjectValue(array(i)("ExpDt"))
						Me.dtUID.Rows(0)("ProductID") = RuntimeHelpers.GetObjectValue(array(i)("ProductID"))
						Me.dtUID.Rows(0)("ExpiryType") = RuntimeHelpers.GetObjectValue(array(i)("ExpiryType"))
						Dim dataRow As DataRow = Me.dtItems.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("ProductID = '", array(i)("ProductID")), "'")))(0)
						dataRow("PickedQty") = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("PickedQty"))) + 1.0
						Me.dtItems.AcceptChanges()
					Next
					Me.lblRows.Text = Conversions.ToString(Me.dtUID.Rows.Count) + " - Row(s)"
					Me.txtBarcode.Text = ""
					Me.txtBarcode.Focus()
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x060019E4 RID: 6628 RVA: 0x000EE460 File Offset: 0x000EC660
		Private Sub dgvUID_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = e.RowIndex > -1
			If flag Then
				Dim array As DataRow() = Me.dtUID.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UID = '", Me.dgvUID.Rows(e.RowIndex).Cells("uUID").Value), "'")))
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(array(0)("ProductID"))
				Dim flag2 As Boolean = array.Length = 1
				If flag2 Then
					Dim text As String = Me.dgvUID.Columns(e.ColumnIndex).Name.ToString()
					If Operators.CompareString(text, "btnDelete_Item", False) = 0 Then
						Me.dtUID.Rows.Remove(array(0))
						Me.dtUID.AcceptChanges()
						Me.lblRows.Text = Conversions.ToString(Me.dtUID.Rows.Count) + " - Row(s)"
						Dim dataRow As DataRow = Me.dtItems.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("ProductID = '", objectValue), "'")))(0)
						dataRow("PickedQty") = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("PickedQty"))) - 1.0
						Me.dtItems.AcceptChanges()
					End If
				End If
			End If
		End Sub

		' Token: 0x060019E5 RID: 6629 RVA: 0x000EE5E0 File Offset: 0x000EC7E0
		Private Function ValidateForm() As Boolean
			Dim flag As Boolean = Me.dtUID.Rows.Count = 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("No Data To Save.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.txtBarcode.Focus()
				flag2 = False
			Else
				flag2 = True
			End If
			Return flag2
		End Function

		' Token: 0x060019E6 RID: 6630 RVA: 0x000EE630 File Offset: 0x000EC830
		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SavePicking()
				EmailModule.SendMail("Material Picking", Me.txtID.Text, "Picked", Me.sEmailTo)
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnSave.Enabled = True
				Me.btnClear.Enabled = True
				Me.btnCancel.Enabled = True
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x060019E7 RID: 6631 RVA: 0x000EE6E4 File Offset: 0x000EC8E4
		Private Sub SavePicking()
			Dim flag As Boolean = CustomMsgBox.Show("Save..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
			If flag Then
				Dim flag2 As Boolean = Not Me.ValidateForm()
				If Not flag2 Then
					Me.btnSave.Enabled = False
					Me.btnClear.Enabled = False
					Me.btnCancel.Enabled = False
					Dim flag3 As Boolean = Operators.CompareString(Me.txtID.Text, "", False) = 0
					If flag3 Then
						Me.InsertPicking()
					Else
						Me.UpdatePicking()
					End If
				End If
			End If
		End Sub

		' Token: 0x060019E8 RID: 6632 RVA: 0x000EE774 File Offset: 0x000EC974
		Private Sub InsertPicking()
			Dim text As String = "EXEC usp_GetIssueNo"
			Dim dataTable As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				Dim text2 As String = Conversions.ToString(dataTable.Rows(0)("TrnNo"))
				Dim flag2 As Boolean = Operators.CompareString(Me.txtBOMVersion.Text, "", False) = 0
				Dim text3 As String
				If flag2 Then
					text3 = "Picked"
				Else
					text3 = "QA Approved"
				End If
				Me.skip_lblStatus.Text = text3
				text = " INSERT INTO Issue (RequestID, IssueNo, PickingBy, PickingDt, Status, Remarks, CreationDt, CreatedBy) " & vbCrLf
				text = String.Concat(New String() { text, " VALUES ('", Me.txtRequestID.Text, "', '", text2, "', '", GlobalVariables.gsUserID, "', GETDATE(), " & vbCrLf })
				text = String.Concat(New String() { text, " '", text3, "', '", Strings.Trim(Me.txtRemarks.Text), "', GETDATE(), '", GlobalVariables.gsUserID, "')" & vbCrLf })
				text += " SELECT SCOPE_IDENTITY() AS ID"
				dataTable = MainModule.GetData(text)
				Dim flag3 As Boolean = dataTable.Rows.Count > 0
				If flag3 Then
					Me.txtID.Text = Conversions.ToString(dataTable.Rows(0)("ID"))
					Me.txtNo.Text = text2
					Me.sID = Me.txtID.Text
					Me.InsertItems()
					Me.Update_Request_Status()
					Dim text4 As String = "ID : " + Me.txtID.Text + vbCrLf
					text4 = text4 + "Trn No. : " + Me.txtNo.Text
					MainModule.TrnLog(Me.Text, "Picking Generated", text4, Nothing)
					CustomMsgBox.Show("Picking Generated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					MyBase.DialogResult = DialogResult.OK
					MyBase.Close()
				End If
			End If
		End Sub

		' Token: 0x060019E9 RID: 6633 RVA: 0x000EE98C File Offset: 0x000ECB8C
		Private Sub UpdatePicking()
			Dim text As String = "Picked"
			Me.skip_lblStatus.Text = text
			Dim text2 As String = String.Concat(New String() { " UPDATE Issue SET Status = '", text, "', PickingBy = '", GlobalVariables.gsUserID, "', PickingDt = GETDATE(), " })
			text2 = text2 + " Remarks = '" + Strings.Trim(Me.txtRemarks.Text) + "', "
			text2 = text2 + " ModificationDt = GETDATE(), ModifiedBy = '" + GlobalVariables.gsUserID + "'" & vbCrLf
			text2 = text2 + " WHERE IssueID = '" + Me.txtID.Text + "' "
			Dim flag As Boolean = MainModule.ExecuteSQL(text2) = 1
			If flag Then
				Me.sID = Me.txtID.Text
				Me.InsertItems()
				Me.Update_Request_Status()
				Dim text3 As String = "ID : " + Me.txtID.Text + vbCrLf
				text3 = text3 + "Trn No. : " + Me.txtNo.Text
				MainModule.TrnLog(Me.Text, "Picking Updated", text3, Nothing)
				CustomMsgBox.Show("Picking Updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				MyBase.DialogResult = DialogResult.OK
				MyBase.Close()
			End If
		End Sub

		' Token: 0x060019EA RID: 6634 RVA: 0x000EEAC8 File Offset: 0x000ECCC8
		Private Sub InsertItems()
			Dim flag As Boolean = (Operators.CompareString(Me.txtID.Text, "", False) <> 0) And (Me.dtUID.Rows.Count > 0)
			If flag Then
				Dim sqlConnection As SqlConnection = New SqlConnection(GlobalVariables.gsConStr)
				sqlConnection.Open()
				Dim sqlTransaction As SqlTransaction = sqlConnection.BeginTransaction(IsolationLevel.Serializable)
				Try
					Dim text As String = " UPDATE GRNUID SET Status = 'Available' " & vbCrLf
					text += " FROM IssueDtls ID INNER JOIN GRNUID GU ON ID.UID = GU.UID " & vbCrLf
					text = text + " WHERE IssueID = '" + Me.txtID.Text + "' " & vbCrLf
					Dim flag2 As Boolean = MainModule.ExecuteSQL(text, sqlConnection, sqlTransaction) = 1
					If flag2 Then
						text = "DELETE FROM IssueDtls WHERE IssueID = '" + Me.txtID.Text + "'"
						Dim flag3 As Boolean = MainModule.ExecuteSQL(text, sqlConnection, sqlTransaction) = 1
						If flag3 Then
							Dim dataTable As DataTable = Me.dtUID.Copy()
							dataTable.Columns.Remove("ParentUID")
							dataTable.Columns.Remove("ProductName")
							dataTable.Columns.Remove("CatalogNo")
							dataTable.Columns.Remove("BatchNo")
							dataTable.Columns.Remove("MfgDt")
							dataTable.Columns.Remove("ExpDt")
							dataTable.Columns.Remove("ExpiryType")
							dataTable.Columns.Remove("Expiry")
							dataTable.Columns.Remove("ReceiptDt")
							Dim dataColumn As DataColumn = New DataColumn("IssueID", GetType(Integer))
							dataColumn.DefaultValue = Me.txtID.Text
							dataTable.Columns.Add(dataColumn)
							MainModule.BulkInsertTemp(dataTable, "IssueDtls", sqlConnection, sqlTransaction)
							text = " UPDATE GRNUID SET Status = 'Picked' " & vbCrLf
							text += " FROM IssueDtls ID INNER JOIN GRNUID GU ON ID.UID = GU.UID " & vbCrLf
							text = text + " WHERE IssueID = '" + Me.txtID.Text + "' " & vbCrLf
							Dim flag4 As Boolean = MainModule.ExecuteSQL(text, sqlConnection, sqlTransaction) = 1
							If flag4 Then
								sqlTransaction.Commit()
								sqlConnection.Close()
								Return
							End If
						End If
					End If
				Catch ex As Exception
					CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				End Try
				sqlTransaction.Rollback()
				sqlConnection.Close()
			End If
		End Sub

		' Token: 0x060019EB RID: 6635 RVA: 0x000EED44 File Offset: 0x000ECF44
		Private Sub Update_Request_Status()
			Dim flag As Boolean = Operators.CompareString(Me.txtRequestID.Text, "", False) <> 0
			If flag Then
				Dim text As String = "EXEC usp_Set_Request_Status '" + Me.txtRequestID.Text + "'"
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text) = 1
				If flag2 Then
				End If
			End If
		End Sub

		' Token: 0x060019EC RID: 6636 RVA: 0x000EED9C File Offset: 0x000ECF9C
		Private Sub btnCancel_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.CancelPicking()
				EmailModule.SendMail("Material Picking", Me.txtID.Text, "Cancelled", Me.sEmailTo)
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnSave.Enabled = True
				Me.btnClear.Enabled = True
				Me.btnCancel.Enabled = True
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x060019ED RID: 6637 RVA: 0x000EEE50 File Offset: 0x000ED050
		Private Sub CancelPicking()
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				Dim flag2 As Boolean = CustomMsgBox.Show("Changes Cannot Be Reverted." & vbCrLf & "Cancel Picking..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
				If flag2 Then
					Dim captureReasons As CaptureReasons = New CaptureReasons("Cancellation")
					Dim flag3 As Boolean = captureReasons.ShowDialog() = DialogResult.OK
					If flag3 Then
						Dim sRemarks As String = captureReasons.sRemarks
						Me.btnSave.Enabled = False
						Me.btnClear.Enabled = False
						Me.btnCancel.Enabled = False
						Dim text As String = String.Concat(New String() { " UPDATE Issue SET Status = 'Cancelled', CancelledBy = '", GlobalVariables.gsUserID, "', CancelledDt = GETDATE(), CancelledRemarks = '", sRemarks, "'" })
						text = text + " WHERE IssueID = '" + Me.txtID.Text + "'"
						text += " UPDATE GRNUID SET Status = 'Available' " & vbCrLf
						text += " FROM IssueDtls ID INNER JOIN GRNUID GU ON ID.UID = GU.UID " & vbCrLf
						text = text + " WHERE IssueID = '" + Me.txtID.Text + "' " & vbCrLf
						Dim flag4 As Boolean = MainModule.ExecuteSQL(text) = 1
						If flag4 Then
							Me.Update_Request_Status()
							Me.sID = Me.txtID.Text
							Me.skip_lblStatus.Text = "Cancelled"
							Dim text2 As String = "ID : " + Me.txtID.Text + vbCrLf
							text2 = text2 + "Trn No. : " + Me.txtNo.Text
							MainModule.TrnLog(Me.Text, "Picking Cancelled", text2, Nothing)
							CustomMsgBox.Show("Picking Cancelled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							MyBase.DialogResult = DialogResult.OK
							MyBase.Close()
						End If
					Else
						CustomMsgBox.Show("Remark For Rejection Is Mandatory.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					End If
				End If
			End If
		End Sub

		' Token: 0x060019EE RID: 6638 RVA: 0x000EF034 File Offset: 0x000ED234
		Private Sub btnApprove_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.Approve_Reject("Approved")
				Me.Set_Expiry_For_When_Opened()
				EmailModule.SendMail("Picking QA Approval", Me.txtID.Text, "Approved", Me.sEmailTo)
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnApprove.Enabled = True
				Me.btnOnHold.Enabled = True
				Me.btnReject.Enabled = True
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x060019EF RID: 6639 RVA: 0x000EF0F4 File Offset: 0x000ED2F4
		Private Sub btnReject_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.Approve_Reject("Rejected")
				EmailModule.SendMail("Picking QA Approval", Me.txtID.Text, "Rejected", Me.sEmailTo)
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnApprove.Enabled = True
				Me.btnOnHold.Enabled = True
				Me.btnReject.Enabled = True
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x060019F0 RID: 6640 RVA: 0x000EF1B0 File Offset: 0x000ED3B0
		Private Sub Approve_Reject(sStatus As String)
			Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
			If flag Then
				Dim text As String = "Approve Picking..?"
				Dim flag2 As Boolean = Operators.CompareString(sStatus, "Rejected", False) = 0
				If flag2 Then
					text = "Reject Picking..?"
				End If
				Dim flag3 As Boolean = CustomMsgBox.Show("Changes Cannot Be Reverted." & vbCrLf + text, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
				If flag3 Then
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
						text2 = text2 + "Action : " + sStatus + vbCrLf
						text2 = text2 + "Action By : " + GlobalVariables.gsUserName + vbCrLf
						text2 = text2 + "Action On : " + Strings.Format(MainModule.GetServerDate(), "dd-MMM-yyyy hh:mm:ss tt") + vbCrLf
						text2 = text2 + "Remarks : " + captureReasons.sRemarks
						Dim txtRemarksApproval As TextBox = Me.txtRemarksApproval
						Dim textBox As TextBox = txtRemarksApproval
						txtRemarksApproval.Text = textBox.Text + text2
						Me.lblRemarksApproval_Click(Nothing, Nothing)
						Dim text4 As String = String.Concat(New String() { " UPDATE Issue SET Status = 'QA ", sStatus, "', ActionRemarks = '", Me.txtRemarksApproval.Text, "', " & vbCrLf })
						text4 = text4 + " ActionDt = GETDATE(), ActionBy = '" + GlobalVariables.gsUserID + "'" & vbCrLf
						text4 = text4 + " WHERE IssueID = '" + Me.txtID.Text + "'"
						Dim flag6 As Boolean = Operators.CompareString(sStatus, "Rejected", False) = 0
						If flag6 Then
							text4 += " UPDATE GRNUID SET Status = 'Available' " & vbCrLf
							text4 += " FROM IssueDtls ID INNER JOIN GRNUID GU ON ID.UID = GU.UID " & vbCrLf
							text4 = text4 + " WHERE IssueID = '" + Me.txtID.Text + "' " & vbCrLf
						End If
						Dim flag7 As Boolean = MainModule.ExecuteSQL(text4) = 1
						If flag7 Then
							Me.skip_lblStatus.Text = "QA " + sStatus
							Me.Update_Request_Status()
							Me.btnApprove.Enabled = False
							Me.btnOnHold.Enabled = False
							Me.btnReject.Enabled = False
							Dim text5 As String = "ID : " + Me.txtID.Text + vbCrLf
							text5 = text5 + "Trn No. : " + Me.txtNo.Text
							MainModule.TrnLog(Me.Text, If(("Picking " + sStatus), ""), text5, Nothing)
							CustomMsgBox.Show("Picking " + sStatus + ".", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
							MyBase.DialogResult = DialogResult.OK
							MyBase.Close()
						End If
					Else
						CustomMsgBox.Show("Remark For " + text3 + " Is Mandatory.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					End If
				End If
			End If
		End Sub

		' Token: 0x060019F1 RID: 6641 RVA: 0x000EF4C4 File Offset: 0x000ED6C4
		Private Sub btnOnHold_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Dim flag As Boolean = CustomMsgBox.Show("Put On Hold..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
				If flag Then
					Me.OnHold()
					EmailModule.SendMail("Picking QA Approval", Me.txtID.Text, "On-Hold", Me.sEmailTo)
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

		' Token: 0x060019F2 RID: 6642 RVA: 0x000EF5A0 File Offset: 0x000ED7A0
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
				Dim text2 As String = " UPDATE Issue SET Status = 'QA On-Hold', ActionRemarks = '" + Me.txtRemarksApproval.Text + "', " & vbCrLf
				text2 = text2 + " ActionDt = GETDATE(), ActionBy = '" + GlobalVariables.gsUserID + "'" & vbCrLf
				text2 = text2 + " WHERE IssueID  = '" + Me.txtID.Text + "'"
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text2) = 1
				If flag2 Then
					Dim text3 As String = "ID : " + Me.txtID.Text + vbCrLf
					text3 = text3 + "Trn No. : " + Me.txtNo.Text
					Me.skip_lblStatus.Text = "QA On-Hold"
					MainModule.TrnLog(Me.Text, "Picking On-Hold", text3, Nothing)
					CustomMsgBox.Show("Picking On-Hold.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Else
					Me.btnApprove.Enabled = True
					Me.btnOnHold.Enabled = True
					Me.btnReject.Enabled = True
					Me.btnCancel.Enabled = True
				End If
			End If
		End Sub

		' Token: 0x060019F3 RID: 6643 RVA: 0x000EF78C File Offset: 0x000ED98C
		Private Sub Set_Expiry_For_When_Opened()
			Dim text As String = ""
			Dim array As DataRow() = Me.dtUID.[Select]("ExpiryType = 'When Opened'")
			Dim num As Integer = array.Length - 1
			For i As Integer = 0 To num
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("'", array(i)("UID")), "',")))
			Next
			Dim flag As Boolean = Operators.CompareString(text, "", False) <> 0
			If flag Then
				Dim text2 As String = " UPDATE GRNUID SET ExpDt = DATEADD(MONTH, CONVERT(INTEGER, Expiry), GETDATE())" & vbCrLf
				text2 = text2 + " WHERE ExpiryType = 'When Opened' AND  UID IN (" + Strings.Mid(text, text.Length - 1) + ")" & vbCrLf
				MainModule.ExecuteSQL(text2)
			End If
		End Sub

		' Token: 0x060019F4 RID: 6644 RVA: 0x000EF838 File Offset: 0x000EDA38
		Private Sub lblRemarks_Click(sender As Object, e As EventArgs)
			Me.lblRemarks.BorderStyle = BorderStyle.FixedSingle
			Me.lblRemarksApproval.BorderStyle = BorderStyle.None
			Me.lblRemarks1.Visible = True
			Me.lblRemarksApproval1.Visible = False
			Me.txtRemarks.Visible = True
			Me.txtRemarksApproval.Visible = False
		End Sub

		' Token: 0x060019F5 RID: 6645 RVA: 0x000EF894 File Offset: 0x000EDA94
		Private Sub lblRemarksApproval_Click(sender As Object, e As EventArgs)
			Me.lblRemarks.BorderStyle = BorderStyle.None
			Me.lblRemarksApproval.BorderStyle = BorderStyle.FixedSingle
			Me.lblRemarks1.Visible = False
			Me.lblRemarksApproval.Visible = True
			Me.lblRemarksApproval1.Visible = True
			Me.txtRemarks.Visible = False
			Me.txtRemarksApproval.Visible = True
		End Sub

		' Token: 0x04000B2F RID: 2863
		Private sFormType As String

		' Token: 0x04000B30 RID: 2864
		Private sEmailTo As String

		' Token: 0x04000B31 RID: 2865
		Private drData As DataRow

		' Token: 0x04000B32 RID: 2866
		Private dtItems As DataTable

		' Token: 0x04000B33 RID: 2867
		Private dtPicklist As DataTable

		' Token: 0x04000B34 RID: 2868
		Private dtUID As DataTable

		' Token: 0x04000B35 RID: 2869
		Public sID As String
	End Class
End Namespace
