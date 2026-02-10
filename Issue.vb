Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Datasoft_PIMS.My
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports WeifenLuo.WinFormsUI.Docking

Namespace Datasoft_PIMS
	' Token: 0x02000063 RID: 99
	<DesignerGenerated()>
	Public Partial Class Issue
		Inherits DockContent

		' Token: 0x1700093B RID: 2363
		' (get) Token: 0x060017EB RID: 6123 RVA: 0x000DE1F7 File Offset: 0x000DC3F7
		' (set) Token: 0x060017EC RID: 6124 RVA: 0x000DE201 File Offset: 0x000DC401
		Friend Overridable Property GroupBox1 As GroupBox

		' Token: 0x1700093C RID: 2364
		' (get) Token: 0x060017ED RID: 6125 RVA: 0x000DE20A File Offset: 0x000DC40A
		' (set) Token: 0x060017EE RID: 6126 RVA: 0x000DE214 File Offset: 0x000DC414
		Friend Overridable Property txtNo As TextBox

		' Token: 0x1700093D RID: 2365
		' (get) Token: 0x060017EF RID: 6127 RVA: 0x000DE21D File Offset: 0x000DC41D
		' (set) Token: 0x060017F0 RID: 6128 RVA: 0x000DE227 File Offset: 0x000DC427
		Friend Overridable Property Label5 As Label

		' Token: 0x1700093E RID: 2366
		' (get) Token: 0x060017F1 RID: 6129 RVA: 0x000DE230 File Offset: 0x000DC430
		' (set) Token: 0x060017F2 RID: 6130 RVA: 0x000DE23A File Offset: 0x000DC43A
		Friend Overridable Property Label10 As Label

		' Token: 0x1700093F RID: 2367
		' (get) Token: 0x060017F3 RID: 6131 RVA: 0x000DE243 File Offset: 0x000DC443
		' (set) Token: 0x060017F4 RID: 6132 RVA: 0x000DE24D File Offset: 0x000DC44D
		Friend Overridable Property dtpDt As DateTimePicker

		' Token: 0x17000940 RID: 2368
		' (get) Token: 0x060017F5 RID: 6133 RVA: 0x000DE256 File Offset: 0x000DC456
		' (set) Token: 0x060017F6 RID: 6134 RVA: 0x000DE260 File Offset: 0x000DC460
		Friend Overridable Property txtRequestNo As TextBox

		' Token: 0x17000941 RID: 2369
		' (get) Token: 0x060017F7 RID: 6135 RVA: 0x000DE269 File Offset: 0x000DC469
		' (set) Token: 0x060017F8 RID: 6136 RVA: 0x000DE273 File Offset: 0x000DC473
		Friend Overridable Property Label7 As Label

		' Token: 0x17000942 RID: 2370
		' (get) Token: 0x060017F9 RID: 6137 RVA: 0x000DE27C File Offset: 0x000DC47C
		' (set) Token: 0x060017FA RID: 6138 RVA: 0x000DE286 File Offset: 0x000DC486
		Friend Overridable Property Label2 As Label

		' Token: 0x17000943 RID: 2371
		' (get) Token: 0x060017FB RID: 6139 RVA: 0x000DE28F File Offset: 0x000DC48F
		' (set) Token: 0x060017FC RID: 6140 RVA: 0x000DE299 File Offset: 0x000DC499
		Friend Overridable Property dtpExpDt As DateTimePicker

		' Token: 0x17000944 RID: 2372
		' (get) Token: 0x060017FD RID: 6141 RVA: 0x000DE2A2 File Offset: 0x000DC4A2
		' (set) Token: 0x060017FE RID: 6142 RVA: 0x000DE2AC File Offset: 0x000DC4AC
		Friend Overridable Property Label1 As Label

		' Token: 0x17000945 RID: 2373
		' (get) Token: 0x060017FF RID: 6143 RVA: 0x000DE2B5 File Offset: 0x000DC4B5
		' (set) Token: 0x06001800 RID: 6144 RVA: 0x000DE2BF File Offset: 0x000DC4BF
		Friend Overridable Property Label8 As Label

		' Token: 0x17000946 RID: 2374
		' (get) Token: 0x06001801 RID: 6145 RVA: 0x000DE2C8 File Offset: 0x000DC4C8
		' (set) Token: 0x06001802 RID: 6146 RVA: 0x000DE2D2 File Offset: 0x000DC4D2
		Friend Overridable Property dtpRequestDt As DateTimePicker

		' Token: 0x17000947 RID: 2375
		' (get) Token: 0x06001803 RID: 6147 RVA: 0x000DE2DB File Offset: 0x000DC4DB
		' (set) Token: 0x06001804 RID: 6148 RVA: 0x000DE2E5 File Offset: 0x000DC4E5
		Friend Overridable Property dtpMfgDt As DateTimePicker

		' Token: 0x17000948 RID: 2376
		' (get) Token: 0x06001805 RID: 6149 RVA: 0x000DE2EE File Offset: 0x000DC4EE
		' (set) Token: 0x06001806 RID: 6150 RVA: 0x000DE2F8 File Offset: 0x000DC4F8
		Friend Overridable Property Label9 As Label

		' Token: 0x17000949 RID: 2377
		' (get) Token: 0x06001807 RID: 6151 RVA: 0x000DE301 File Offset: 0x000DC501
		' (set) Token: 0x06001808 RID: 6152 RVA: 0x000DE30B File Offset: 0x000DC50B
		Friend Overridable Property Label6 As Label

		' Token: 0x1700094A RID: 2378
		' (get) Token: 0x06001809 RID: 6153 RVA: 0x000DE314 File Offset: 0x000DC514
		' (set) Token: 0x0600180A RID: 6154 RVA: 0x000DE31E File Offset: 0x000DC51E
		Friend Overridable Property txtBatchNo As TextBox

		' Token: 0x1700094B RID: 2379
		' (get) Token: 0x0600180B RID: 6155 RVA: 0x000DE327 File Offset: 0x000DC527
		' (set) Token: 0x0600180C RID: 6156 RVA: 0x000DE331 File Offset: 0x000DC531
		Friend Overridable Property Label3 As Label

		' Token: 0x1700094C RID: 2380
		' (get) Token: 0x0600180D RID: 6157 RVA: 0x000DE33A File Offset: 0x000DC53A
		' (set) Token: 0x0600180E RID: 6158 RVA: 0x000DE344 File Offset: 0x000DC544
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

		' Token: 0x1700094D RID: 2381
		' (get) Token: 0x0600180F RID: 6159 RVA: 0x000DE387 File Offset: 0x000DC587
		' (set) Token: 0x06001810 RID: 6160 RVA: 0x000DE391 File Offset: 0x000DC591
		Friend Overridable Property GroupBox2 As GroupBox

		' Token: 0x1700094E RID: 2382
		' (get) Token: 0x06001811 RID: 6161 RVA: 0x000DE39A File Offset: 0x000DC59A
		' (set) Token: 0x06001812 RID: 6162 RVA: 0x000DE3A4 File Offset: 0x000DC5A4
		Friend Overridable Property Panel2 As Panel

		' Token: 0x1700094F RID: 2383
		' (get) Token: 0x06001813 RID: 6163 RVA: 0x000DE3AD File Offset: 0x000DC5AD
		' (set) Token: 0x06001814 RID: 6164 RVA: 0x000DE3B7 File Offset: 0x000DC5B7
		Friend Overridable Property Panel1 As Panel

		' Token: 0x17000950 RID: 2384
		' (get) Token: 0x06001815 RID: 6165 RVA: 0x000DE3C0 File Offset: 0x000DC5C0
		' (set) Token: 0x06001816 RID: 6166 RVA: 0x000DE3CC File Offset: 0x000DC5CC
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

		' Token: 0x17000951 RID: 2385
		' (get) Token: 0x06001817 RID: 6167 RVA: 0x000DE40F File Offset: 0x000DC60F
		' (set) Token: 0x06001818 RID: 6168 RVA: 0x000DE419 File Offset: 0x000DC619
		Friend Overridable Property txtID As TextBox

		' Token: 0x17000952 RID: 2386
		' (get) Token: 0x06001819 RID: 6169 RVA: 0x000DE422 File Offset: 0x000DC622
		' (set) Token: 0x0600181A RID: 6170 RVA: 0x000DE42C File Offset: 0x000DC62C
		Friend Overridable Property txtRequestID As TextBox

		' Token: 0x17000953 RID: 2387
		' (get) Token: 0x0600181B RID: 6171 RVA: 0x000DE435 File Offset: 0x000DC635
		' (set) Token: 0x0600181C RID: 6172 RVA: 0x000DE43F File Offset: 0x000DC63F
		Friend Overridable Property txtProductID As TextBox

		' Token: 0x17000954 RID: 2388
		' (get) Token: 0x0600181D RID: 6173 RVA: 0x000DE448 File Offset: 0x000DC648
		' (set) Token: 0x0600181E RID: 6174 RVA: 0x000DE452 File Offset: 0x000DC652
		Friend Overridable Property txtProduct As TextBox

		' Token: 0x17000955 RID: 2389
		' (get) Token: 0x0600181F RID: 6175 RVA: 0x000DE45B File Offset: 0x000DC65B
		' (set) Token: 0x06001820 RID: 6176 RVA: 0x000DE465 File Offset: 0x000DC665
		Friend Overridable Property txtPickingByID As TextBox

		' Token: 0x17000956 RID: 2390
		' (get) Token: 0x06001821 RID: 6177 RVA: 0x000DE46E File Offset: 0x000DC66E
		' (set) Token: 0x06001822 RID: 6178 RVA: 0x000DE478 File Offset: 0x000DC678
		Friend Overridable Property txtPickingBy As TextBox

		' Token: 0x17000957 RID: 2391
		' (get) Token: 0x06001823 RID: 6179 RVA: 0x000DE481 File Offset: 0x000DC681
		' (set) Token: 0x06001824 RID: 6180 RVA: 0x000DE48B File Offset: 0x000DC68B
		Friend Overridable Property txtRequestedByID As TextBox

		' Token: 0x17000958 RID: 2392
		' (get) Token: 0x06001825 RID: 6181 RVA: 0x000DE494 File Offset: 0x000DC694
		' (set) Token: 0x06001826 RID: 6182 RVA: 0x000DE49E File Offset: 0x000DC69E
		Friend Overridable Property txtRequestedBy As TextBox

		' Token: 0x17000959 RID: 2393
		' (get) Token: 0x06001827 RID: 6183 RVA: 0x000DE4A7 File Offset: 0x000DC6A7
		' (set) Token: 0x06001828 RID: 6184 RVA: 0x000DE4B1 File Offset: 0x000DC6B1
		Friend Overridable Property Label11 As Label

		' Token: 0x1700095A RID: 2394
		' (get) Token: 0x06001829 RID: 6185 RVA: 0x000DE4BA File Offset: 0x000DC6BA
		' (set) Token: 0x0600182A RID: 6186 RVA: 0x000DE4C4 File Offset: 0x000DC6C4
		Friend Overridable Property Label4 As Label

		' Token: 0x1700095B RID: 2395
		' (get) Token: 0x0600182B RID: 6187 RVA: 0x000DE4CD File Offset: 0x000DC6CD
		' (set) Token: 0x0600182C RID: 6188 RVA: 0x000DE4D7 File Offset: 0x000DC6D7
		Friend Overridable Property txtApprovedBy As TextBox

		' Token: 0x1700095C RID: 2396
		' (get) Token: 0x0600182D RID: 6189 RVA: 0x000DE4E0 File Offset: 0x000DC6E0
		' (set) Token: 0x0600182E RID: 6190 RVA: 0x000DE4EA File Offset: 0x000DC6EA
		Friend Overridable Property skip_lblStatus As Label

		' Token: 0x1700095D RID: 2397
		' (get) Token: 0x0600182F RID: 6191 RVA: 0x000DE4F3 File Offset: 0x000DC6F3
		' (set) Token: 0x06001830 RID: 6192 RVA: 0x000DE4FD File Offset: 0x000DC6FD
		Friend Overridable Property txtApprovedByID As TextBox

		' Token: 0x1700095E RID: 2398
		' (get) Token: 0x06001831 RID: 6193 RVA: 0x000DE506 File Offset: 0x000DC706
		' (set) Token: 0x06001832 RID: 6194 RVA: 0x000DE510 File Offset: 0x000DC710
		Friend Overridable Property dgvDtls As DataGridView

		' Token: 0x1700095F RID: 2399
		' (get) Token: 0x06001833 RID: 6195 RVA: 0x000DE519 File Offset: 0x000DC719
		' (set) Token: 0x06001834 RID: 6196 RVA: 0x000DE523 File Offset: 0x000DC723
		Friend Overridable Property dgvUID As DataGridView

		' Token: 0x17000960 RID: 2400
		' (get) Token: 0x06001835 RID: 6197 RVA: 0x000DE52C File Offset: 0x000DC72C
		' (set) Token: 0x06001836 RID: 6198 RVA: 0x000DE536 File Offset: 0x000DC736
		Friend Overridable Property lblRows As Label

		' Token: 0x17000961 RID: 2401
		' (get) Token: 0x06001837 RID: 6199 RVA: 0x000DE53F File Offset: 0x000DC73F
		' (set) Token: 0x06001838 RID: 6200 RVA: 0x000DE549 File Offset: 0x000DC749
		Friend Overridable Property Label13 As Label

		' Token: 0x17000962 RID: 2402
		' (get) Token: 0x06001839 RID: 6201 RVA: 0x000DE552 File Offset: 0x000DC752
		' (set) Token: 0x0600183A RID: 6202 RVA: 0x000DE55C File Offset: 0x000DC75C
		Friend Overridable Property dtpApprovalDt As DateTimePicker

		' Token: 0x17000963 RID: 2403
		' (get) Token: 0x0600183B RID: 6203 RVA: 0x000DE565 File Offset: 0x000DC765
		' (set) Token: 0x0600183C RID: 6204 RVA: 0x000DE56F File Offset: 0x000DC76F
		Friend Overridable Property Label12 As Label

		' Token: 0x17000964 RID: 2404
		' (get) Token: 0x0600183D RID: 6205 RVA: 0x000DE578 File Offset: 0x000DC778
		' (set) Token: 0x0600183E RID: 6206 RVA: 0x000DE582 File Offset: 0x000DC782
		Friend Overridable Property dtpPickingDt As DateTimePicker

		' Token: 0x17000965 RID: 2405
		' (get) Token: 0x0600183F RID: 6207 RVA: 0x000DE58B File Offset: 0x000DC78B
		' (set) Token: 0x06001840 RID: 6208 RVA: 0x000DE595 File Offset: 0x000DC795
		Friend Overridable Property uUID As DataGridViewTextBoxColumn

		' Token: 0x17000966 RID: 2406
		' (get) Token: 0x06001841 RID: 6209 RVA: 0x000DE59E File Offset: 0x000DC79E
		' (set) Token: 0x06001842 RID: 6210 RVA: 0x000DE5A8 File Offset: 0x000DC7A8
		Friend Overridable Property uCatalogNo As DataGridViewTextBoxColumn

		' Token: 0x17000967 RID: 2407
		' (get) Token: 0x06001843 RID: 6211 RVA: 0x000DE5B1 File Offset: 0x000DC7B1
		' (set) Token: 0x06001844 RID: 6212 RVA: 0x000DE5BB File Offset: 0x000DC7BB
		Friend Overridable Property uProductName As DataGridViewTextBoxColumn

		' Token: 0x17000968 RID: 2408
		' (get) Token: 0x06001845 RID: 6213 RVA: 0x000DE5C4 File Offset: 0x000DC7C4
		' (set) Token: 0x06001846 RID: 6214 RVA: 0x000DE5CE File Offset: 0x000DC7CE
		Friend Overridable Property uDescription As DataGridViewTextBoxColumn

		' Token: 0x17000969 RID: 2409
		' (get) Token: 0x06001847 RID: 6215 RVA: 0x000DE5D7 File Offset: 0x000DC7D7
		' (set) Token: 0x06001848 RID: 6216 RVA: 0x000DE5E1 File Offset: 0x000DC7E1
		Friend Overridable Property uBatchNo As DataGridViewTextBoxColumn

		' Token: 0x1700096A RID: 2410
		' (get) Token: 0x06001849 RID: 6217 RVA: 0x000DE5EA File Offset: 0x000DC7EA
		' (set) Token: 0x0600184A RID: 6218 RVA: 0x000DE5F4 File Offset: 0x000DC7F4
		Friend Overridable Property uMfgDt As DataGridViewTextBoxColumn

		' Token: 0x1700096B RID: 2411
		' (get) Token: 0x0600184B RID: 6219 RVA: 0x000DE5FD File Offset: 0x000DC7FD
		' (set) Token: 0x0600184C RID: 6220 RVA: 0x000DE607 File Offset: 0x000DC807
		Friend Overridable Property uExpDt As DataGridViewTextBoxColumn

		' Token: 0x1700096C RID: 2412
		' (get) Token: 0x0600184D RID: 6221 RVA: 0x000DE610 File Offset: 0x000DC810
		' (set) Token: 0x0600184E RID: 6222 RVA: 0x000DE61A File Offset: 0x000DC81A
		Friend Overridable Property uProductID As DataGridViewTextBoxColumn

		' Token: 0x1700096D RID: 2413
		' (get) Token: 0x0600184F RID: 6223 RVA: 0x000DE623 File Offset: 0x000DC823
		' (set) Token: 0x06001850 RID: 6224 RVA: 0x000DE630 File Offset: 0x000DC830
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

		' Token: 0x1700096E RID: 2414
		' (get) Token: 0x06001851 RID: 6225 RVA: 0x000DE673 File Offset: 0x000DC873
		' (set) Token: 0x06001852 RID: 6226 RVA: 0x000DE67D File Offset: 0x000DC87D
		Friend Overridable Property ProductID As DataGridViewTextBoxColumn

		' Token: 0x1700096F RID: 2415
		' (get) Token: 0x06001853 RID: 6227 RVA: 0x000DE686 File Offset: 0x000DC886
		' (set) Token: 0x06001854 RID: 6228 RVA: 0x000DE690 File Offset: 0x000DC890
		Friend Overridable Property SrNo As DataGridViewTextBoxColumn

		' Token: 0x17000970 RID: 2416
		' (get) Token: 0x06001855 RID: 6229 RVA: 0x000DE699 File Offset: 0x000DC899
		' (set) Token: 0x06001856 RID: 6230 RVA: 0x000DE6A3 File Offset: 0x000DC8A3
		Friend Overridable Property ProductType As DataGridViewTextBoxColumn

		' Token: 0x17000971 RID: 2417
		' (get) Token: 0x06001857 RID: 6231 RVA: 0x000DE6AC File Offset: 0x000DC8AC
		' (set) Token: 0x06001858 RID: 6232 RVA: 0x000DE6B6 File Offset: 0x000DC8B6
		Friend Overridable Property CatalogNo As DataGridViewTextBoxColumn

		' Token: 0x17000972 RID: 2418
		' (get) Token: 0x06001859 RID: 6233 RVA: 0x000DE6BF File Offset: 0x000DC8BF
		' (set) Token: 0x0600185A RID: 6234 RVA: 0x000DE6C9 File Offset: 0x000DC8C9
		Friend Overridable Property ProductName As DataGridViewTextBoxColumn

		' Token: 0x17000973 RID: 2419
		' (get) Token: 0x0600185B RID: 6235 RVA: 0x000DE6D2 File Offset: 0x000DC8D2
		' (set) Token: 0x0600185C RID: 6236 RVA: 0x000DE6DC File Offset: 0x000DC8DC
		Friend Overridable Property Description As DataGridViewTextBoxColumn

		' Token: 0x17000974 RID: 2420
		' (get) Token: 0x0600185D RID: 6237 RVA: 0x000DE6E5 File Offset: 0x000DC8E5
		' (set) Token: 0x0600185E RID: 6238 RVA: 0x000DE6EF File Offset: 0x000DC8EF
		Friend Overridable Property PrimaryUOM As DataGridViewTextBoxColumn

		' Token: 0x17000975 RID: 2421
		' (get) Token: 0x0600185F RID: 6239 RVA: 0x000DE6F8 File Offset: 0x000DC8F8
		' (set) Token: 0x06001860 RID: 6240 RVA: 0x000DE702 File Offset: 0x000DC902
		Friend Overridable Property ReqQty As DataGridViewTextBoxColumn

		' Token: 0x17000976 RID: 2422
		' (get) Token: 0x06001861 RID: 6241 RVA: 0x000DE70B File Offset: 0x000DC90B
		' (set) Token: 0x06001862 RID: 6242 RVA: 0x000DE715 File Offset: 0x000DC915
		Friend Overridable Property PickedQty As DataGridViewTextBoxColumn

		' Token: 0x06001863 RID: 6243 RVA: 0x000DE720 File Offset: 0x000DC920
		Public Sub New(sForm As String, dr As DataRow)
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Issue_Load
			Me.InitializeComponent()
			Me.sFormType = sForm
			Me.drData = dr
		End Sub

		' Token: 0x06001864 RID: 6244 RVA: 0x000DE770 File Offset: 0x000DC970
		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x06001865 RID: 6245 RVA: 0x000DE7A5 File Offset: 0x000DC9A5
		Private Sub Issue_Load(sender As Object, e As EventArgs)
			Designing.SetTheme(Me)
			Me.FillData()
			Me.SetForm()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x06001866 RID: 6246 RVA: 0x000DE7D4 File Offset: 0x000DC9D4
		Private Sub FillData()
			Try
				Dim flag As Boolean = Not Information.IsNothing(Me.drData)
				If flag Then
					Me.txtID.Text = Conversions.ToString(Me.drData("ID"))
					Me.txtRequestID.Text = Conversions.ToString(Me.drData("RequestID"))
					Dim flag2 As Boolean = Me.drData.Table.Columns.Contains("IssueNo")
					If flag2 Then
						Me.txtNo.Text = Conversions.ToString(Me.drData("IssueNo"))
					Else
						Me.txtNo.Text = Conversions.ToString(Me.drData("PickingNo"))
					End If
					Dim flag3 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.drData("IssuedDt")))
					If flag3 Then
						Me.dtpDt.Value = Conversions.ToDate(Me.drData("IssuedDt"))
					End If
					Me.txtRequestNo.Text = Conversions.ToString(Me.drData("RequestNo"))
					Me.dtpRequestDt.Value = Conversions.ToDate(Me.drData("RequestDt"))
					Me.dtpPickingDt.Value = Conversions.ToDate(Me.drData("PickingDt"))
					Dim flag4 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.drData("ActionDt")))
					If flag4 Then
						Me.dtpApprovalDt.Value = Conversions.ToDate(Me.drData("ActionDt"))
					Else
						Me.dtpApprovalDt.CustomFormat = " "
					End If
					Me.txtRequestedByID.Text = Conversions.ToString(Me.drData("RequestedBy"))
					Me.txtRequestedBy.Text = Conversions.ToString(Me.drData("Requested By"))
					Me.txtPickingByID.Text = Me.drData("PickingBy").ToString()
					Me.txtPickingBy.Text = Me.drData("Picking By").ToString()
					Me.txtApprovedByID.Text = Me.drData("ActionBy").ToString()
					Me.txtApprovedBy.Text = Me.drData("Action By").ToString()
					Me.txtProductID.Text = Conversions.ToString(Me.drData("ProductID"))
					Me.txtProduct.Text = Conversions.ToString(Me.drData("ProductName"))
					Me.txtBatchNo.Text = Conversions.ToString(Me.drData("BatchNo"))
					Dim flag5 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.drData("MfgDt")))
					If flag5 Then
						Me.dtpMfgDt.Value = Conversions.ToDate(Me.drData("MfgDt"))
					Else
						Me.dtpMfgDt.CustomFormat = " "
					End If
					Dim flag6 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.drData("ExpDt")))
					If flag6 Then
						Me.dtpExpDt.Value = Conversions.ToDate(Me.drData("MfgDt"))
					Else
						Me.dtpExpDt.CustomFormat = " "
					End If
					Me.skip_lblStatus.Text = Conversions.ToString(Me.drData("Status"))
					Me.FillItems()
					Me.FillUID()
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06001867 RID: 6247 RVA: 0x000DEBFC File Offset: 0x000DCDFC
		Private Sub FillItems()
			Dim text As String = " SELECT ROW_NUMBER() OVER(ORDER BY RequestDtlsID) AS SrNo, RD.ProductID, P.ProductType, " & vbCrLf
			text += " CatalogNo, P.ProductName, Description, P.PrimaryUOM, " & vbCrLf
			text += " RequiredQty, ISNULL(PickedQty,0) PickedQty " & vbCrLf
			text += " FROM RequestDtls RD INNER JOIN Product P On RD.ProductID = P.ProductID " & vbCrLf
			text += " INNER JOIN " & vbCrLf
			text += "   (SELECT I.RequestID, ID.ProductID, COUNT(UID) AS PickedQty " & vbCrLf
			text += "    FROM Issue I INNER JOIN IssueDtls ID ON I.IssueID = ID.IssueID " & vbCrLf
			text = text + "    WHERE I.Status IN ('QA Approved', 'Issued') AND I.IssueID = '" + Me.txtID.Text + "' " & vbCrLf
			text += "    GROUP BY I.RequestID, ID.ProductID) " & vbCrLf
			text += " AS I ON I.RequestID = RD.RequestID AND I.ProductID = RD.ProductID " & vbCrLf
			text = text + " WHERE RD.RequestID = '" + Me.txtRequestID.Text + "' " & vbCrLf
			Me.dtItems = MainModule.GetData(text)
			Me.dgvDtls.DataSource = Me.dtItems
		End Sub

		' Token: 0x06001868 RID: 6248 RVA: 0x000DECC8 File Offset: 0x000DCEC8
		Private Sub FillUID()
			Dim text As String = " SELECT ID.UID, P.CatalogNo, P.ProductName, " & vbCrLf
			text += " GU.BatchNo, GU.MfgDt, GU.ExpDt, GU.Description, ID.ProductID " & vbCrLf
			text += " FROM IssueDtls ID " & vbCrLf
			text += " INNER JOIN Product P ON ID.ProductID = P.ProductID " & vbCrLf
			text += " INNER JOIN GRNUID GU ON ID.UID = GU.UID " & vbCrLf
			text = text + " WHERE ID.IssueID = '" + Me.txtID.Text + "'"
			text += " ORDER BY ID.ProductID "
			Me.dtUID = MainModule.GetData(text)
			Me.dgvUID.DataSource = Me.dtUID
			Me.lblRows.Text = Conversions.ToString(Me.dtUID.Rows.Count) + " - Row(s)"
			Dim color As Color = Color.White
			Dim text2 As String = Me.dgvUID.Rows(0).Cells("uProductID").Value.ToString()
			Dim num As Integer = Me.dgvUID.Rows.Count - 1
			For i As Integer = 0 To num
				Dim flag As Boolean = Operators.CompareString(text2, Me.dgvUID.Rows(i).Cells("uProductID").Value.ToString(), False) <> 0
				If flag Then
					Dim flag2 As Boolean = color = Color.White
					If flag2 Then
						color = Color.Azure
					Else
						color = Color.White
					End If
					text2 = Me.dgvUID.Rows(i).Cells("uProductID").Value.ToString()
				End If
				Me.dgvUID.Rows(i).DefaultCellStyle.BackColor = color
			Next
		End Sub

		' Token: 0x06001869 RID: 6249 RVA: 0x000DEE80 File Offset: 0x000DD080
		Private Sub SetForm()
			Dim text As String = Me.sFormType
			If Operators.CompareString(text, "", False) <> 0 Then
			End If
			Dim text2 As String = Me.skip_lblStatus.Text
			If Operators.CompareString(text2, "QA Approved", False) <> 0 Then
				If Operators.CompareString(text2, "Issued", False) = 0 Then
					Me.btnSave.Enabled = False
					Me.btnPrint.Enabled = True
				End If
			Else
				Me.btnPrint.Enabled = False
			End If
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

		' Token: 0x0600186A RID: 6250 RVA: 0x000DEF9B File Offset: 0x000DD19B
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x0600186B RID: 6251 RVA: 0x000DEFA8 File Offset: 0x000DD1A8
		Private Function ValidateForm() As Boolean
			Dim flag As Boolean = Me.dtUID.Rows.Count = 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("No Data To Save.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				flag2 = False
			Else
				flag2 = True
			End If
			Return flag2
		End Function

		' Token: 0x0600186C RID: 6252 RVA: 0x000DEFEC File Offset: 0x000DD1EC
		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.Save()
				EmailModule.SendMail("Material Issue", Me.txtID.Text, Me.sEmailTo, "")
				Me.SendROLAlert()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnSave.Enabled = True
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x0600186D RID: 6253 RVA: 0x000DF090 File Offset: 0x000DD290
		Private Sub Save()
			Dim flag As Boolean = CustomMsgBox.Show("Save..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
			If flag Then
				Dim flag2 As Boolean = Not Me.ValidateForm()
				If Not flag2 Then
					Me.btnSave.Enabled = False
					Dim text As String = " UPDATE Issue SET Status = 'Issued', IssuedBy = '" + GlobalVariables.gsUserID + "', IssuedDt = GETDATE()" & vbCrLf
					text = text + " WHERE IssueID = '" + Me.txtID.Text + "'" & vbCrLf & vbCrLf
					text += " UPDATE GRNUID SET Status = 'Issued' " & vbCrLf
					text += " FROM IssueDtls ID INNER JOIN GRNUID GU ON ID.UID = GU.UID " & vbCrLf
					text = text + " WHERE IssueID = '" + Me.txtID.Text + "' " & vbCrLf
					Dim flag3 As Boolean = MainModule.ExecuteSQL(text) = 1
					If flag3 Then
						Me.skip_lblStatus.Text = "Issued"
						Me.btnPrint.Enabled = True
						Me.Update_Request_Status()
						Dim text2 As String = "ID : " + Me.txtID.Text + vbCrLf
						text2 = text2 + "Trn No. : " + Me.txtNo.Text
						MainModule.TrnLog(Me.Text, "Material Issued", text2, Nothing)
						CustomMsgBox.Show("Material Issued.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					End If
				End If
			End If
		End Sub

		' Token: 0x0600186E RID: 6254 RVA: 0x000DF1D4 File Offset: 0x000DD3D4
		Private Sub Update_Request_Status()
			Dim flag As Boolean = Operators.CompareString(Me.txtRequestID.Text, "", False) <> 0
			If flag Then
				Dim text As String = "EXEC usp_Set_Request_Status '" + Me.txtRequestID.Text + "'"
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text) = 1
				If flag2 Then
				End If
			End If
		End Sub

		' Token: 0x0600186F RID: 6255 RVA: 0x000DF22C File Offset: 0x000DD42C
		Private Sub SendROLAlert()
			Dim text As String = ""
			Dim num As Integer = Me.dtItems.Rows.Count - 1
			For i As Integer = 0 To num
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Me.dtItems.Rows(i)("ProductID")), "',")))
			Next
			Dim flag As Boolean = Operators.CompareString(text, "", False) <> 0
			If flag Then
				text = Strings.Mid(text, 1, text.Length - 1)
				Dim text2 As String = " SELECT P.ProductType [Product Type], P.ProductCode [Product Code], " & vbCrLf
				text2 += " P.ProductName [ProductName], ISNULL(P.ROL,0) [Reorder Level]," & vbCrLf
				text2 += " SUM(CASE WHEN ISNULL(ExpDt,'01/01/2050') > GETDATE() AND GU.Status = 'Available' THEN 1 ELSE 0 END) AS [Available Qty.]" & vbCrLf
				text2 += " FROM GRNUID GU " & vbCrLf
				text2 += " INNER JOIN Product P ON GU.ProductID = P.ProductID" & vbCrLf
				text2 = text2 + " WHERE GU.ProductID IN (" + text + ") " & vbCrLf
				text2 += " GROUP BY GU.ProductID, P.ProductType, P.ProductCode, P.ProductName, P.ROL" & vbCrLf
				text2 += " HAVING ISNULL(P.ROL,0) >= SUM(CASE WHEN ISNULL(ExpDt,'01/01/2050') > GETDATE() AND GU.Status = 'Available' THEN 1 ELSE 0 END) " & vbCrLf
				Dim data As DataTable = MainModule.GetData(text2)
				Dim flag2 As Boolean = data.Rows.Count > 0
				If flag2 Then
					EmailModule.Send_ROL_MailAlert(data, "")
				End If
			End If
		End Sub

		' Token: 0x06001870 RID: 6256 RVA: 0x000DF354 File Offset: 0x000DD554
		Private Sub btnPrint_Click(sender As Object, e As EventArgs)
			Try
				Me.PrintReport()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06001871 RID: 6257 RVA: 0x000DF3AC File Offset: 0x000DD5AC
		Private Sub PrintReport()
			Dim text As String = " SELECT R.RequestID, RequestNo, P.ProductName, R.BOMVersion, R.BatchNo, ReqBy.UserName AS RequestedBy, RequestDt, I.IssuedDt, " & vbCrLf
			text += " ROW_NUMBER() OVER(ORDER BY RD.RequestDtlsID) AS  SrNo, M.ProductName AS MaterialName, M.CatalogNo, M.PrimaryUOM UOM, " & vbCrLf
			text += " RD.RequiredQty, ID.BatchNo AS LotNo, ID.ExpDt AS ExpiryDt, ID.IssuedQty, " & vbCrLf
			text += " IssBy.UserName AS IssuedBy, Action.UserName AS VerifiedBy" & vbCrLf
			text += " FROM Request R" & vbCrLf
			text += " INNER JOIN RequestDtls RD ON R.RequestID = RD.RequestID" & vbCrLf
			text += " INNER JOIN Product P ON R.ProductID = P.ProductID " & vbCrLf
			text += " INNER JOIN [User] ReqBy ON R.RequestedBy = ReqBy.UserID" & vbCrLf
			text += " INNER JOIN Product M ON RD.ProductID = M.ProductID " & vbCrLf
			text += " INNER JOIN Issue I ON R.RequestID = I.RequestID" & vbCrLf
			text += " LEFT JOIN [User] Action ON I.ActionBy = Action.UserID" & vbCrLf
			text += " INNER JOIN [User] IssBy ON I.IssuedBy = IssBy.UserID" & vbCrLf
			text += " INNER JOIN (" & vbCrLf
			text += "     SELECT IssueID, ISD.ProductID, GU.BatchNo, GU.ExpDt, COUNT(ISD.UID) AS IssuedQty " & vbCrLf
			text += "     FROM IssueDtls ISD INNER JOIN GRNUID GU ON ISD.UID = GU.UID" & vbCrLf
			text += "     GROUP BY IssueID, ISD.ProductID, GU.BatchNo, GU.ExpDt" & vbCrLf
			text += "     ) ID ON I.IssueID = ID.IssueID AND RD.ProductID = ID.ProductID" & vbCrLf
			text = text + " WHERE I.IssueID = '" + Me.txtID.Text + "'" & vbCrLf
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim reportCrystal As ReportCrystal = New ReportCrystal("Issue", data)
				reportCrystal.Show(MyProject.Forms.MDIMain.DockPanel)
				MyBase.Close()
			End If
		End Sub

		' Token: 0x04000A82 RID: 2690
		Private sFormType As String

		' Token: 0x04000A83 RID: 2691
		Private sEmailTo As String

		' Token: 0x04000A84 RID: 2692
		Private drData As DataRow

		' Token: 0x04000A85 RID: 2693
		Private dtItems As DataTable

		' Token: 0x04000A86 RID: 2694
		Private dtPicklist As DataTable

		' Token: 0x04000A87 RID: 2695
		Private dtUID As DataTable

		' Token: 0x04000A88 RID: 2696
		Public sID As String
	End Class
End Namespace
