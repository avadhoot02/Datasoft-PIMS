Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x02000059 RID: 89
	<DesignerGenerated()>
	Public Partial Class PRItems
		Inherits Form

		' Token: 0x17000738 RID: 1848
		' (get) Token: 0x060012F6 RID: 4854 RVA: 0x000B0CC8 File Offset: 0x000AEEC8
		' (set) Token: 0x060012F7 RID: 4855 RVA: 0x000B0CD2 File Offset: 0x000AEED2
		Friend Overridable Property pnlBorder As Panel

		' Token: 0x17000739 RID: 1849
		' (get) Token: 0x060012F8 RID: 4856 RVA: 0x000B0CDB File Offset: 0x000AEEDB
		' (set) Token: 0x060012F9 RID: 4857 RVA: 0x000B0CE5 File Offset: 0x000AEEE5
		Friend Overridable Property pnlMain As Panel

		' Token: 0x1700073A RID: 1850
		' (get) Token: 0x060012FA RID: 4858 RVA: 0x000B0CEE File Offset: 0x000AEEEE
		' (set) Token: 0x060012FB RID: 4859 RVA: 0x000B0CF8 File Offset: 0x000AEEF8
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

		' Token: 0x1700073B RID: 1851
		' (get) Token: 0x060012FC RID: 4860 RVA: 0x000B0D3B File Offset: 0x000AEF3B
		' (set) Token: 0x060012FD RID: 4861 RVA: 0x000B0D45 File Offset: 0x000AEF45
		Friend Overridable Property picFormIcon As PictureBox

		' Token: 0x1700073C RID: 1852
		' (get) Token: 0x060012FE RID: 4862 RVA: 0x000B0D4E File Offset: 0x000AEF4E
		' (set) Token: 0x060012FF RID: 4863 RVA: 0x000B0D58 File Offset: 0x000AEF58
		Friend Overridable Property lblCaption As Label

		' Token: 0x1700073D RID: 1853
		' (get) Token: 0x06001300 RID: 4864 RVA: 0x000B0D61 File Offset: 0x000AEF61
		' (set) Token: 0x06001301 RID: 4865 RVA: 0x000B0D6C File Offset: 0x000AEF6C
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

		' Token: 0x1700073E RID: 1854
		' (get) Token: 0x06001302 RID: 4866 RVA: 0x000B0DAF File Offset: 0x000AEFAF
		' (set) Token: 0x06001303 RID: 4867 RVA: 0x000B0DB9 File Offset: 0x000AEFB9
		Friend Overridable Property pnlShadow As Panel

		' Token: 0x1700073F RID: 1855
		' (get) Token: 0x06001304 RID: 4868 RVA: 0x000B0DC2 File Offset: 0x000AEFC2
		' (set) Token: 0x06001305 RID: 4869 RVA: 0x000B0DCC File Offset: 0x000AEFCC
		Friend Overridable Property Label15 As Label

		' Token: 0x17000740 RID: 1856
		' (get) Token: 0x06001306 RID: 4870 RVA: 0x000B0DD5 File Offset: 0x000AEFD5
		' (set) Token: 0x06001307 RID: 4871 RVA: 0x000B0DDF File Offset: 0x000AEFDF
		Friend Overridable Property txtProductName As TextBox

		' Token: 0x17000741 RID: 1857
		' (get) Token: 0x06001308 RID: 4872 RVA: 0x000B0DE8 File Offset: 0x000AEFE8
		' (set) Token: 0x06001309 RID: 4873 RVA: 0x000B0DF4 File Offset: 0x000AEFF4
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

		' Token: 0x17000742 RID: 1858
		' (get) Token: 0x0600130A RID: 4874 RVA: 0x000B0E37 File Offset: 0x000AF037
		' (set) Token: 0x0600130B RID: 4875 RVA: 0x000B0E41 File Offset: 0x000AF041
		Friend Overridable Property Label18 As Label

		' Token: 0x17000743 RID: 1859
		' (get) Token: 0x0600130C RID: 4876 RVA: 0x000B0E4A File Offset: 0x000AF04A
		' (set) Token: 0x0600130D RID: 4877 RVA: 0x000B0E54 File Offset: 0x000AF054
		Friend Overridable Property txtOtherCharges As TextBox

		' Token: 0x17000744 RID: 1860
		' (get) Token: 0x0600130E RID: 4878 RVA: 0x000B0E5D File Offset: 0x000AF05D
		' (set) Token: 0x0600130F RID: 4879 RVA: 0x000B0E67 File Offset: 0x000AF067
		Friend Overridable Property Label10 As Label

		' Token: 0x17000745 RID: 1861
		' (get) Token: 0x06001310 RID: 4880 RVA: 0x000B0E70 File Offset: 0x000AF070
		' (set) Token: 0x06001311 RID: 4881 RVA: 0x000B0E7A File Offset: 0x000AF07A
		Friend Overridable Property cmbTaxPer As ComboBox

		' Token: 0x17000746 RID: 1862
		' (get) Token: 0x06001312 RID: 4882 RVA: 0x000B0E83 File Offset: 0x000AF083
		' (set) Token: 0x06001313 RID: 4883 RVA: 0x000B0E8D File Offset: 0x000AF08D
		Friend Overridable Property Label14 As Label

		' Token: 0x17000747 RID: 1863
		' (get) Token: 0x06001314 RID: 4884 RVA: 0x000B0E96 File Offset: 0x000AF096
		' (set) Token: 0x06001315 RID: 4885 RVA: 0x000B0EA0 File Offset: 0x000AF0A0
		Friend Overridable Property txtFinalAmt As TextBox

		' Token: 0x17000748 RID: 1864
		' (get) Token: 0x06001316 RID: 4886 RVA: 0x000B0EA9 File Offset: 0x000AF0A9
		' (set) Token: 0x06001317 RID: 4887 RVA: 0x000B0EB3 File Offset: 0x000AF0B3
		Friend Overridable Property Label7 As Label

		' Token: 0x17000749 RID: 1865
		' (get) Token: 0x06001318 RID: 4888 RVA: 0x000B0EBC File Offset: 0x000AF0BC
		' (set) Token: 0x06001319 RID: 4889 RVA: 0x000B0EC6 File Offset: 0x000AF0C6
		Friend Overridable Property txtTaxAmt As TextBox

		' Token: 0x1700074A RID: 1866
		' (get) Token: 0x0600131A RID: 4890 RVA: 0x000B0ECF File Offset: 0x000AF0CF
		' (set) Token: 0x0600131B RID: 4891 RVA: 0x000B0ED9 File Offset: 0x000AF0D9
		Friend Overridable Property Label8 As Label

		' Token: 0x1700074B RID: 1867
		' (get) Token: 0x0600131C RID: 4892 RVA: 0x000B0EE2 File Offset: 0x000AF0E2
		' (set) Token: 0x0600131D RID: 4893 RVA: 0x000B0EEC File Offset: 0x000AF0EC
		Friend Overridable Property txtNetAmt As TextBox

		' Token: 0x1700074C RID: 1868
		' (get) Token: 0x0600131E RID: 4894 RVA: 0x000B0EF5 File Offset: 0x000AF0F5
		' (set) Token: 0x0600131F RID: 4895 RVA: 0x000B0EFF File Offset: 0x000AF0FF
		Friend Overridable Property Label35 As Label

		' Token: 0x1700074D RID: 1869
		' (get) Token: 0x06001320 RID: 4896 RVA: 0x000B0F08 File Offset: 0x000AF108
		' (set) Token: 0x06001321 RID: 4897 RVA: 0x000B0F14 File Offset: 0x000AF114
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

		' Token: 0x1700074E RID: 1870
		' (get) Token: 0x06001322 RID: 4898 RVA: 0x000B0F57 File Offset: 0x000AF157
		' (set) Token: 0x06001323 RID: 4899 RVA: 0x000B0F64 File Offset: 0x000AF164
		Friend Overridable Property btnDelete As Button
			<CompilerGenerated()>
			Get
				Return Me._btnDelete
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnDelete_Click
				Dim button As Button = Me._btnDelete
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnDelete = value
				button = Me._btnDelete
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700074F RID: 1871
		' (get) Token: 0x06001324 RID: 4900 RVA: 0x000B0FA7 File Offset: 0x000AF1A7
		' (set) Token: 0x06001325 RID: 4901 RVA: 0x000B0FB4 File Offset: 0x000AF1B4
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

		' Token: 0x17000750 RID: 1872
		' (get) Token: 0x06001326 RID: 4902 RVA: 0x000B0FF7 File Offset: 0x000AF1F7
		' (set) Token: 0x06001327 RID: 4903 RVA: 0x000B1001 File Offset: 0x000AF201
		Friend Overridable Property Label5 As Label

		' Token: 0x17000751 RID: 1873
		' (get) Token: 0x06001328 RID: 4904 RVA: 0x000B100A File Offset: 0x000AF20A
		' (set) Token: 0x06001329 RID: 4905 RVA: 0x000B1014 File Offset: 0x000AF214
		Friend Overridable Property txtBasicAmt As TextBox

		' Token: 0x17000752 RID: 1874
		' (get) Token: 0x0600132A RID: 4906 RVA: 0x000B101D File Offset: 0x000AF21D
		' (set) Token: 0x0600132B RID: 4907 RVA: 0x000B1027 File Offset: 0x000AF227
		Friend Overridable Property Label1 As Label

		' Token: 0x17000753 RID: 1875
		' (get) Token: 0x0600132C RID: 4908 RVA: 0x000B1030 File Offset: 0x000AF230
		' (set) Token: 0x0600132D RID: 4909 RVA: 0x000B103A File Offset: 0x000AF23A
		Friend Overridable Property Label27 As Label

		' Token: 0x17000754 RID: 1876
		' (get) Token: 0x0600132E RID: 4910 RVA: 0x000B1043 File Offset: 0x000AF243
		' (set) Token: 0x0600132F RID: 4911 RVA: 0x000B104D File Offset: 0x000AF24D
		Friend Overridable Property txtHSNSAC As TextBox

		' Token: 0x17000755 RID: 1877
		' (get) Token: 0x06001330 RID: 4912 RVA: 0x000B1056 File Offset: 0x000AF256
		' (set) Token: 0x06001331 RID: 4913 RVA: 0x000B1060 File Offset: 0x000AF260
		Friend Overridable Property txtDesc As TextBox

		' Token: 0x17000756 RID: 1878
		' (get) Token: 0x06001332 RID: 4914 RVA: 0x000B1069 File Offset: 0x000AF269
		' (set) Token: 0x06001333 RID: 4915 RVA: 0x000B1074 File Offset: 0x000AF274
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

		' Token: 0x17000757 RID: 1879
		' (get) Token: 0x06001334 RID: 4916 RVA: 0x000B10B7 File Offset: 0x000AF2B7
		' (set) Token: 0x06001335 RID: 4917 RVA: 0x000B10C1 File Offset: 0x000AF2C1
		Friend Overridable Property Label9 As Label

		' Token: 0x17000758 RID: 1880
		' (get) Token: 0x06001336 RID: 4918 RVA: 0x000B10CA File Offset: 0x000AF2CA
		' (set) Token: 0x06001337 RID: 4919 RVA: 0x000B10D4 File Offset: 0x000AF2D4
		Friend Overridable Property Label20 As Label

		' Token: 0x17000759 RID: 1881
		' (get) Token: 0x06001338 RID: 4920 RVA: 0x000B10DD File Offset: 0x000AF2DD
		' (set) Token: 0x06001339 RID: 4921 RVA: 0x000B10E7 File Offset: 0x000AF2E7
		Friend Overridable Property txtPrimaryUOM As TextBox

		' Token: 0x1700075A RID: 1882
		' (get) Token: 0x0600133A RID: 4922 RVA: 0x000B10F0 File Offset: 0x000AF2F0
		' (set) Token: 0x0600133B RID: 4923 RVA: 0x000B10FA File Offset: 0x000AF2FA
		Friend Overridable Property txtPrimaryPackSize As TextBox

		' Token: 0x1700075B RID: 1883
		' (get) Token: 0x0600133C RID: 4924 RVA: 0x000B1103 File Offset: 0x000AF303
		' (set) Token: 0x0600133D RID: 4925 RVA: 0x000B110D File Offset: 0x000AF30D
		Friend Overridable Property Label17 As Label

		' Token: 0x1700075C RID: 1884
		' (get) Token: 0x0600133E RID: 4926 RVA: 0x000B1116 File Offset: 0x000AF316
		' (set) Token: 0x0600133F RID: 4927 RVA: 0x000B1120 File Offset: 0x000AF320
		Friend Overridable Property Label2 As Label

		' Token: 0x1700075D RID: 1885
		' (get) Token: 0x06001340 RID: 4928 RVA: 0x000B1129 File Offset: 0x000AF329
		' (set) Token: 0x06001341 RID: 4929 RVA: 0x000B1133 File Offset: 0x000AF333
		Friend Overridable Property txtTertiaryPackSize As TextBox

		' Token: 0x1700075E RID: 1886
		' (get) Token: 0x06001342 RID: 4930 RVA: 0x000B113C File Offset: 0x000AF33C
		' (set) Token: 0x06001343 RID: 4931 RVA: 0x000B1146 File Offset: 0x000AF346
		Friend Overridable Property Label3 As Label

		' Token: 0x1700075F RID: 1887
		' (get) Token: 0x06001344 RID: 4932 RVA: 0x000B114F File Offset: 0x000AF34F
		' (set) Token: 0x06001345 RID: 4933 RVA: 0x000B1159 File Offset: 0x000AF359
		Friend Overridable Property txtTertiaryUOM As TextBox

		' Token: 0x17000760 RID: 1888
		' (get) Token: 0x06001346 RID: 4934 RVA: 0x000B1162 File Offset: 0x000AF362
		' (set) Token: 0x06001347 RID: 4935 RVA: 0x000B116C File Offset: 0x000AF36C
		Friend Overridable Property Label6 As Label

		' Token: 0x17000761 RID: 1889
		' (get) Token: 0x06001348 RID: 4936 RVA: 0x000B1175 File Offset: 0x000AF375
		' (set) Token: 0x06001349 RID: 4937 RVA: 0x000B117F File Offset: 0x000AF37F
		Friend Overridable Property Label11 As Label

		' Token: 0x17000762 RID: 1890
		' (get) Token: 0x0600134A RID: 4938 RVA: 0x000B1188 File Offset: 0x000AF388
		' (set) Token: 0x0600134B RID: 4939 RVA: 0x000B1194 File Offset: 0x000AF394
		Friend Overridable Property txtReqQtyTer As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtReqQtyTer
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim eventHandler As EventHandler = AddressOf Me.txtReqQtyTer_TextChanged
				Dim textBox As TextBox = Me._txtReqQtyTer
				If textBox IsNot Nothing Then
					RemoveHandler textBox.TextChanged, eventHandler
				End If
				Me._txtReqQtyTer = value
				textBox = Me._txtReqQtyTer
				If textBox IsNot Nothing Then
					AddHandler textBox.TextChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000763 RID: 1891
		' (get) Token: 0x0600134C RID: 4940 RVA: 0x000B11D7 File Offset: 0x000AF3D7
		' (set) Token: 0x0600134D RID: 4941 RVA: 0x000B11E1 File Offset: 0x000AF3E1
		Friend Overridable Property Label12 As Label

		' Token: 0x17000764 RID: 1892
		' (get) Token: 0x0600134E RID: 4942 RVA: 0x000B11EA File Offset: 0x000AF3EA
		' (set) Token: 0x0600134F RID: 4943 RVA: 0x000B11F4 File Offset: 0x000AF3F4
		Friend Overridable Property Label13 As Label

		' Token: 0x17000765 RID: 1893
		' (get) Token: 0x06001350 RID: 4944 RVA: 0x000B11FD File Offset: 0x000AF3FD
		' (set) Token: 0x06001351 RID: 4945 RVA: 0x000B1207 File Offset: 0x000AF407
		Friend Overridable Property txtReqQty As TextBox

		' Token: 0x17000766 RID: 1894
		' (get) Token: 0x06001352 RID: 4946 RVA: 0x000B1210 File Offset: 0x000AF410
		' (set) Token: 0x06001353 RID: 4947 RVA: 0x000B121A File Offset: 0x000AF41A
		Friend Overridable Property txtCatalogNo As TextBox

		' Token: 0x17000767 RID: 1895
		' (get) Token: 0x06001354 RID: 4948 RVA: 0x000B1223 File Offset: 0x000AF423
		' (set) Token: 0x06001355 RID: 4949 RVA: 0x000B122D File Offset: 0x000AF42D
		Friend Overridable Property lblPrice As Label

		' Token: 0x17000768 RID: 1896
		' (get) Token: 0x06001356 RID: 4950 RVA: 0x000B1236 File Offset: 0x000AF436
		' (set) Token: 0x06001357 RID: 4951 RVA: 0x000B1240 File Offset: 0x000AF440
		Friend Overridable Property txtUnitPrice As TextBox

		' Token: 0x17000769 RID: 1897
		' (get) Token: 0x06001358 RID: 4952 RVA: 0x000B1249 File Offset: 0x000AF449
		' (set) Token: 0x06001359 RID: 4953 RVA: 0x000B1253 File Offset: 0x000AF453
		Friend Overridable Property txtTertiaryMeasure As TextBox

		' Token: 0x1700076A RID: 1898
		' (get) Token: 0x0600135A RID: 4954 RVA: 0x000B125C File Offset: 0x000AF45C
		' (set) Token: 0x0600135B RID: 4955 RVA: 0x000B1266 File Offset: 0x000AF466
		Friend Overridable Property txtPrimaryMeasure As TextBox

		' Token: 0x0600135C RID: 4956
		Private Declare Sub SendMessage Lib "user32.DLL" (hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

		' Token: 0x0600135D RID: 4957
		Private Declare Sub ReleaseCapture Lib "user32.DLL" ()

		' Token: 0x0600135E RID: 4958 RVA: 0x000B126F File Offset: 0x000AF46F
		Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs)
			PRItems.ReleaseCapture()
			PRItems.SendMessage(MyBase.Handle, 274, 61458, 0)
		End Sub

		' Token: 0x0600135F RID: 4959 RVA: 0x000B1290 File Offset: 0x000AF490
		Public Sub New(iR As Integer, sForm As String, Status As String, dt As DataTable)
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.InitializeComponent()
			Designing.SetTheme(Me)
			Me.picFormIcon.Image = ResourceModule.imgFormIconPic
			MyBase.FormBorderStyle = FormBorderStyle.None
			Me.BackColor = Color.GhostWhite
			MyBase.TransparencyKey = Color.GhostWhite
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.lblCaption.Text = Me.Text
			Me.form_btnClose.DialogResult = DialogResult.Cancel
			Me.iRow = iR
			Me.sFormType = sForm
			Me.sStatus = Status
			Me.dtItems = dt
		End Sub

		' Token: 0x06001360 RID: 4960 RVA: 0x000B1343 File Offset: 0x000AF543
		Private Sub form_btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06001361 RID: 4961 RVA: 0x000B134D File Offset: 0x000AF54D
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Me.ClearForm()
			Me.FillData()
			Me.SetForm()
		End Sub

		' Token: 0x06001362 RID: 4962 RVA: 0x000B1368 File Offset: 0x000AF568
		Private Sub ClearForm()
			Me.cmbProduct.Text = ""
			Me.cmbProduct.SelectedIndex = -1
			Me.txtDesc.Text = ""
			Me.txtCatalogNo.Text = ""
			Me.txtHSNSAC.Text = ""
			Me.txtUnitPrice.Text = ""
			Me.txtTertiaryUOM.Text = ""
			Me.txtTertiaryPackSize.Text = ""
			Me.txtPrimaryUOM.Text = ""
			Me.txtPrimaryPackSize.Text = ""
			Me.txtPrimaryMeasure.Text = ""
			Me.txtReqQty.Text = ""
			Me.txtReqQtyTer.Text = ""
			Me.txtBasicAmt.Text = ""
			Me.txtNetAmt.Text = ""
			Me.cmbTaxPer.Text = ""
			Me.txtTaxAmt.Text = ""
			Me.txtOtherCharges.Text = ""
			Me.txtFinalAmt.Text = ""
			Me.txtProductName.[ReadOnly] = True
			Me.txtDesc.[ReadOnly] = True
			Me.txtReqQtyTer.[ReadOnly] = True
			Me.txtUnitPrice.[ReadOnly] = True
			Me.txtOtherCharges.[ReadOnly] = True
			Me.txtFinalAmt.[ReadOnly] = True
			Me.cmbTaxPer.Enabled = False
			Me.lblPrice.Text = "Unit Price"
		End Sub

		' Token: 0x06001363 RID: 4963 RVA: 0x000B1521 File Offset: 0x000AF721
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.DialogResult = DialogResult.Cancel
			MyBase.Close()
		End Sub

		' Token: 0x06001364 RID: 4964 RVA: 0x000B1534 File Offset: 0x000AF734
		Private Sub FillData()
			Dim flag As Boolean = Me.iRow <> -1
			If flag Then
				Me.cmbType.Text = Me.dtItems.Rows(Me.iRow)("ProductType").ToString()
				Me.FillProduct()
				Me.cmbProduct.Text = Me.dtItems.Rows(Me.iRow)("ProductCode").ToString()
				Me.txtProductName.Text = Me.dtItems.Rows(Me.iRow)("ProductName").ToString()
				Me.cmbProduct.SelectedValue = Me.dtItems.Rows(Me.iRow)("ProductID").ToString()
				Me.FillProductDetails()
				Me.txtDesc.Text = Me.dtItems.Rows(Me.iRow)("Description").ToString()
				Me.txtUnitPrice.Text = Me.dtItems.Rows(Me.iRow)("UnitPrice").ToString()
				Me.txtTertiaryPackSize.Text = Me.dtItems.Rows(Me.iRow)("TertiaryPackSize").ToString()
				Me.txtPrimaryPackSize.Text = Me.dtItems.Rows(Me.iRow)("PrimaryPackSize").ToString()
				Me.txtReqQtyTer.Text = Me.dtItems.Rows(Me.iRow)("Quantity").ToString()
				Me.txtBasicAmt.Text = Me.dtItems.Rows(Me.iRow)("BasicValue").ToString()
				Me.txtNetAmt.Text = Me.dtItems.Rows(Me.iRow)("NetAmt").ToString()
				Me.cmbTaxPer.Text = Me.dtItems.Rows(Me.iRow)("TaxPer").ToString()
				Me.txtTaxAmt.Text = Me.dtItems.Rows(Me.iRow)("TaxAmt").ToString()
				Me.txtOtherCharges.Text = Me.dtItems.Rows(Me.iRow)("OtherCharges").ToString()
				Me.txtFinalAmt.Text = Me.dtItems.Rows(Me.iRow)("FinalAmt").ToString()
			End If
		End Sub

		' Token: 0x06001365 RID: 4965 RVA: 0x000B1844 File Offset: 0x000AFA44
		Private Sub SetForm()
			Dim flag As Boolean = Me.iRow = -1
			If flag Then
				Me.btnDelete.Enabled = False
			End If
			Dim text As String = Me.sFormType
			If Operators.CompareString(text, "PR Add", False) <> 0 AndAlso Operators.CompareString(text, "PR Modify", False) <> 0 Then
				Me.cmbType.Enabled = False
				Me.cmbProduct.Enabled = False
				Me.txtDesc.[ReadOnly] = True
				Me.txtReqQtyTer.[ReadOnly] = True
				Me.cmbTaxPer.Enabled = False
				Me.txtOtherCharges.[ReadOnly] = True
				Me.btnSave.Enabled = False
				Me.btnDelete.Enabled = False
			End If
			Dim text2 As String = Me.sStatus
			If Operators.CompareString(text2, "New P.R.", False) <> 0 AndAlso Operators.CompareString(text2, "In Approval", False) <> 0 AndAlso Operators.CompareString(text2, "On-Hold", False) <> 0 Then
				If Operators.CompareString(text2, "Approved", False) = 0 OrElse Operators.CompareString(text2, "Rejected", False) = 0 OrElse Operators.CompareString(text2, "Cancelled", False) = 0 Then
					Me.cmbType.Enabled = False
					Me.cmbProduct.Enabled = False
					Me.txtDesc.[ReadOnly] = True
					Me.txtReqQtyTer.[ReadOnly] = True
					Me.cmbTaxPer.Enabled = False
					Me.txtOtherCharges.[ReadOnly] = True
					Me.btnSave.Enabled = False
					Me.btnDelete.Enabled = False
				End If
			End If
			AddHandler Me.txtUnitPrice.TextChanged, Sub(a0 As Object, a1 As EventArgs)
				Me.CalculateAmount()
			End Sub
			AddHandler Me.txtReqQtyTer.TextChanged, Sub(a0 As Object, a1 As EventArgs)
				Me.CalculateAmount()
			End Sub
			AddHandler Me.cmbTaxPer.SelectedIndexChanged, Sub(a0 As Object, a1 As EventArgs)
				Me.CalculateAmount()
			End Sub
			AddHandler Me.txtOtherCharges.TextChanged, Sub(a0 As Object, a1 As EventArgs)
				Me.CalculateAmount()
			End Sub
			AddHandler Me.txtUnitPrice.KeyDown, AddressOf Me.Keydown_Numeric
			AddHandler Me.txtReqQtyTer.KeyDown, AddressOf Me.Keydown_Numeric
			AddHandler Me.cmbTaxPer.KeyDown, AddressOf Me.Keydown_Numeric
			AddHandler Me.txtOtherCharges.KeyDown, AddressOf Me.Keydown_Numeric
		End Sub

		' Token: 0x06001366 RID: 4966 RVA: 0x000B1A90 File Offset: 0x000AFC90
		Private Sub CalculateAmount()
			Dim num As Double = 0.0
			Dim flag As Boolean = Versioned.IsNumeric(Me.txtOtherCharges.Text)
			If flag Then
				num = Conversion.Val(Me.txtOtherCharges.Text)
			End If
			Dim flag2 As Boolean = (Operators.CompareString(Strings.Trim(Me.txtUnitPrice.Text), "", False) <> 0) And Versioned.IsNumeric(Me.txtUnitPrice.Text) And (Operators.CompareString(Strings.Trim(Me.txtReqQtyTer.Text), "", False) <> 0) And Versioned.IsNumeric(Me.txtReqQtyTer.Text)
			If flag2 Then
				Me.txtBasicAmt.Text = Strings.Format(Conversion.Val(Me.txtUnitPrice.Text) * Conversion.Val(Me.txtPrimaryPackSize.Text) * Conversion.Val(Me.txtTertiaryPackSize.Text) * Conversion.Val(Me.txtReqQtyTer.Text), "#0.00")
				Me.txtNetAmt.Text = Me.txtBasicAmt.Text
			Else
				Me.txtBasicAmt.Text = ""
				Me.txtNetAmt.Text = ""
			End If
			Dim flag3 As Boolean = Operators.CompareString(Strings.Trim(Me.cmbTaxPer.Text), "", False) <> 0
			If flag3 Then
				Me.txtTaxAmt.Text = Strings.Format(Conversion.Val(Me.txtNetAmt.Text) * Conversion.Val(Strings.Replace(Me.cmbTaxPer.Text, " %", "", 1, -1, CompareMethod.Binary)) / 100.0, "#0.00")
			Else
				Me.txtTaxAmt.Text = ""
			End If
			Dim flag4 As Boolean = Operators.CompareString(Me.txtNetAmt.Text, "", False) <> 0
			If flag4 Then
				Me.txtFinalAmt.Text = Strings.Format(Conversion.Val(Me.txtNetAmt.Text) + Conversion.Val(Me.txtTaxAmt.Text) + num, "#0.00")
			Else
				Me.txtFinalAmt.Text = ""
			End If
		End Sub

		' Token: 0x06001367 RID: 4967 RVA: 0x000B1CD0 File Offset: 0x000AFED0
		Private Sub Keydown_Numeric(sender As Object, e As KeyEventArgs)
			Dim keyCode As Keys = e.KeyCode
			Dim flag As Boolean = (keyCode >= Keys.D0 AndAlso keyCode <= Keys.D9) OrElse (keyCode >= Keys.NumPad0 AndAlso keyCode <= Keys.NumPad9) OrElse keyCode = Keys.Back OrElse keyCode = Keys.[Decimal] OrElse keyCode = Keys.OemPeriod
			If Not flag Then
				e.SuppressKeyPress = True
			End If
		End Sub

		' Token: 0x06001368 RID: 4968 RVA: 0x000B1D20 File Offset: 0x000AFF20
		Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.cmbType.Text, "", False) <> 0
			If flag Then
				Me.FillProduct()
			Else
				Me.cmbProduct.DataSource = Nothing
			End If
			Me.ClearForm()
		End Sub

		' Token: 0x06001369 RID: 4969 RVA: 0x000B1D6C File Offset: 0x000AFF6C
		Private Sub FillProduct()
			Dim text As String = " SELECT ProductID, ProductCode, ProductName, ProductType, SpecificationNo, Reference, " & vbCrLf
			text += " CatalogNo, HSNSACCode, TertiaryUOM, TertiaryPackSize, PrimaryUOM, PrimaryPackSize, Measurement, " & vbCrLf
			text += " Expiry, UnitPrice, GSTPer, StorageCondition, " & vbCrLf
			text += " IsActive, IsGRNApplicable, IsQCApplicable, IsParentApplicable, IsUnitsEditable" & vbCrLf
			text += " FROM Product" & vbCrLf
			text = text + " WHERE Status = 'Approved' AND ProductType IN ('" + Me.cmbType.Text + "') " & vbCrLf
			text += " AND TertiaryPackSize > 0 " & vbCrLf
			Dim flag As Boolean = Me.iRow <> -1
			If flag Then
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" AND (IsActive = 1 OR ProductID = '", Me.dtItems.Rows(Me.iRow)("ProductID")), "') "), vbCrLf)))
			Else
				text += " AND IsActive = 1" & vbCrLf
			End If
			text += " ORDER BY ProductCode" & vbCrLf
			Me.dtProduct = MainModule.GetData(text)
			Me.cmbProduct.ValueMember = "ProductID"
			Me.cmbProduct.DisplayMember = "ProductCode"
			Me.cmbProduct.DataSource = Me.dtProduct
			Me.cmbProduct.SelectedIndex = -1
		End Sub

		' Token: 0x0600136A RID: 4970 RVA: 0x000B1E9C File Offset: 0x000B009C
		Private Sub cmbProduct_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbProduct.SelectedIndex > -1
			If flag Then
				Me.FillProductDetails()
			Else
				Dim flag2 As Boolean = Operators.CompareString(Me.cmbProduct.Text, "", False) <> 0
				If flag2 Then
					Dim text As String = "Entered Product Not In Master." & vbCrLf
					text += "Do You Want To Proceed.?"
					Dim flag3 As Boolean = CustomMsgBox.Show(text, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
					If flag3 Then
						Me.txtProductName.[ReadOnly] = False
						Me.txtDesc.[ReadOnly] = False
						Me.txtUnitPrice.[ReadOnly] = False
						Me.txtReqQtyTer.[ReadOnly] = False
						Me.cmbTaxPer.Enabled = True
						Me.txtProductName.Focus()
						Return
					End If
				End If
				Me.ClearForm()
			End If
		End Sub

		' Token: 0x0600136B RID: 4971 RVA: 0x000B1F68 File Offset: 0x000B0168
		Private Sub FillProductDetails()
			Try
				Dim flag As Boolean = Me.cmbProduct.SelectedIndex > -1
				If flag Then
					Dim dataRow As DataRow = Me.dtProduct.[Select]("ProductID = '" + Me.cmbProduct.SelectedValue.ToString() + "'")(0)
					Me.txtProductName.Text = Conversions.ToString(dataRow("ProductName"))
					Me.txtCatalogNo.Text = Conversions.ToString(dataRow("CatalogNo"))
					Me.txtHSNSAC.Text = Conversions.ToString(dataRow("HSNSACCode"))
					Me.txtTertiaryUOM.Text = dataRow("TertiaryUOM").ToString()
					Me.txtTertiaryPackSize.Text = dataRow("TertiaryPackSize").ToString()
					Me.txtPrimaryUOM.Text = dataRow("PrimaryUOM").ToString()
					Me.txtPrimaryPackSize.Text = dataRow("PrimaryPackSize").ToString()
					Me.txtPrimaryMeasure.Text = dataRow("Measurement").ToString()
					Me.txtUnitPrice.Text = dataRow("UnitPrice").ToString()
					Me.cmbTaxPer.Text = dataRow("GSTPer").ToString()
					Me.lblPrice.Text = "Unit Price/ " + Me.txtPrimaryMeasure.Text
					Me.txtProductName.[ReadOnly] = True
					Me.txtUnitPrice.[ReadOnly] = True
					Me.txtDesc.[ReadOnly] = False
					Me.txtReqQtyTer.[ReadOnly] = False
					Me.txtOtherCharges.[ReadOnly] = False
					Me.cmbTaxPer.Enabled = True
				Else
					Dim flag2 As Boolean = Operators.CompareString(Me.txtProductName.Text, "", False) <> 0
					If flag2 Then
						Me.txtProductName.[ReadOnly] = False
						Me.txtDesc.[ReadOnly] = False
						Me.txtUnitPrice.[ReadOnly] = False
						Me.txtReqQtyTer.[ReadOnly] = False
						Me.cmbTaxPer.Enabled = True
					Else
						Me.txtProductName.[ReadOnly] = True
						Me.txtDesc.[ReadOnly] = True
						Me.txtReqQtyTer.[ReadOnly] = True
						Me.txtUnitPrice.[ReadOnly] = True
						Me.txtOtherCharges.[ReadOnly] = True
						Me.cmbTaxPer.Enabled = False
					End If
				End If
			Catch ex As Exception
				Dim flag3 As Boolean = Strings.InStr(ex.Message.ToString(), "'DBNull'", CompareMethod.Binary) > 0
				Dim text As String
				If flag3 Then
					text = "Error : Incorrect Product Master Data." & vbCrLf + ex.Message
				Else
					text = "Error : " + ex.Message
				End If
				CustomMsgBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnSave.Enabled = False
			End Try
		End Sub

		' Token: 0x0600136C RID: 4972 RVA: 0x000B2294 File Offset: 0x000B0494
		Private Sub txtReqQtyTer_TextChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Versioned.IsNumeric(Me.txtReqQtyTer.Text)
			If flag Then
				Me.txtReqQty.Text = Conversions.ToString(Conversion.Val(Me.txtReqQtyTer.Text) * Conversion.Val(Me.txtTertiaryPackSize.Text))
			Else
				Me.txtReqQty.Text = "0"
			End If
		End Sub

		' Token: 0x0600136D RID: 4973 RVA: 0x000B2300 File Offset: 0x000B0500
		Private Sub btnDelete_Click(sender As Object, e As EventArgs)
			Try
				Me.DeleteItem()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x0600136E RID: 4974 RVA: 0x000B2358 File Offset: 0x000B0558
		Private Sub DeleteItem()
			Dim flag As Boolean = CustomMsgBox.Show("Delete PR Item..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes
			If flag Then
				Me.dtItems.Rows.RemoveAt(Me.iRow)
				Me.dtItems.AcceptChanges()
				MyBase.DialogResult = DialogResult.OK
				MyBase.Close()
			End If
		End Sub

		' Token: 0x0600136F RID: 4975 RVA: 0x000B23B4 File Offset: 0x000B05B4
		Private Function ValidateForm() As Boolean
			Dim flag As Boolean = Operators.CompareString(Me.cmbType.Text, "", False) = 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Select Product Type.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.cmbType.Focus()
				flag2 = False
			Else
				Dim flag3 As Boolean = Operators.CompareString(Me.cmbProduct.Text, "", False) = 0
				If flag3 Then
					CustomMsgBox.Show("Select/ Enter Product Code.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.cmbProduct.Focus()
					flag2 = False
				Else
					Dim flag4 As Boolean = Operators.CompareString(Strings.Trim(Me.txtProductName.Text), "", False) = 0
					If flag4 Then
						CustomMsgBox.Show("Enter Product Name.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.txtProductName.Focus()
						flag2 = False
					Else
						Dim text As String = Me.cmbType.Text
						If Operators.CompareString(text, "Service", False) = 0 Then
							Dim flag5 As Boolean = Operators.CompareString(Strings.Trim(Me.txtDesc.Text), "", False) = 0
							If flag5 Then
								CustomMsgBox.Show("Description Is Mandatory For Services.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								Me.txtDesc.Focus()
								Return False
							End If
						End If
						Dim flag6 As Boolean = Not Versioned.IsNumeric(Me.txtUnitPrice.Text) Or (Operators.CompareString(Strings.Trim(Me.txtUnitPrice.Text), "", False) = 0)
						If flag6 Then
							CustomMsgBox.Show("Unit Price Should Be Numeric.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.txtUnitPrice.Focus()
							flag2 = False
						Else
							Dim flag7 As Boolean = Not Versioned.IsNumeric(Me.txtReqQtyTer.Text) Or (Operators.CompareString(Strings.Trim(Me.txtReqQtyTer.Text), "", False) = 0)
							If flag7 Then
								CustomMsgBox.Show("Quantity Should Be Numeric.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								Me.txtReqQtyTer.Focus()
								flag2 = False
							Else
								Dim flag8 As Boolean = Operators.CompareString(Me.cmbTaxPer.Text, "", False) = 0
								If flag8 Then
									CustomMsgBox.Show("Select Tax %.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
									Me.cmbTaxPer.Focus()
									flag2 = False
								Else
									Dim flag9 As Boolean = Operators.CompareString(Strings.Trim(Me.txtOtherCharges.Text), "", False) <> 0
									If flag9 Then
										Dim flag10 As Boolean = Not Versioned.IsNumeric(Me.txtOtherCharges.Text)
										If flag10 Then
											CustomMsgBox.Show("Other Charges Should Be Numeric.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
											Me.txtOtherCharges.Focus()
											Return False
										End If
									End If
									Dim text2 As String = ""
									text2 = text2 + "ProductCode = '" + Me.cmbProduct.Text + "' "
									text2 = text2 + " AND SrNo <> '" + Conversions.ToString(Me.iRow + 1) + "' "
									Dim text3 As String = Me.cmbType.Text
									If Operators.CompareString(text3, "Service", False) = 0 Then
										text2 = text2 + " AND Description = '" + Me.txtDesc.Text + "' "
									End If
									Dim flag11 As Boolean = Me.dtItems.[Select](text2).Length > 0
									If flag11 Then
										CustomMsgBox.Show("Product Already In The List.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
										Me.cmbProduct.Focus()
										flag2 = False
									Else
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

		' Token: 0x06001370 RID: 4976 RVA: 0x000B272C File Offset: 0x000B092C
		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			Try
				Me.Save()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06001371 RID: 4977 RVA: 0x000B2784 File Offset: 0x000B0984
		Private Sub Save()
			Dim flag As Boolean = Not Me.ValidateForm()
			If Not flag Then
				Dim flag2 As Boolean = Me.iRow = -1
				If flag2 Then
					Me.iRow = Me.dtItems.Rows.Count
					Me.dtItems.Rows.Add(New Object(-1) {})
				End If
				Me.dtItems.Rows(Me.iRow)("SrNo") = Me.iRow + 1
				Dim flag3 As Boolean = Me.cmbProduct.SelectedIndex > -1
				If flag3 Then
					Me.dtItems.Rows(Me.iRow)("ProductID") = Me.cmbProduct.SelectedValue.ToString()
				Else
					Me.dtItems.Rows(Me.iRow)("ProductID") = 0
				End If
				Me.dtItems.Rows(Me.iRow)("ProductType") = Me.cmbType.Text
				Me.dtItems.Rows(Me.iRow)("ProductCode") = Me.cmbProduct.Text
				Me.dtItems.Rows(Me.iRow)("ProductName") = Me.txtProductName.Text
				Me.dtItems.Rows(Me.iRow)("Description") = Me.txtDesc.Text
				Me.dtItems.Rows(Me.iRow)("HSNSACCode") = Me.txtHSNSAC.Text
				Me.dtItems.Rows(Me.iRow)("TertiaryUOM") = Me.txtTertiaryUOM.Text
				Dim flag4 As Boolean = Operators.CompareString(Me.txtTertiaryPackSize.Text, "", False) <> 0
				If flag4 Then
					Me.dtItems.Rows(Me.iRow)("TertiaryPackSize") = Me.txtTertiaryPackSize.Text
				Else
					Me.dtItems.Rows(Me.iRow)("TertiaryPackSize") = DBNull.Value
				End If
				Me.dtItems.Rows(Me.iRow)("PrimaryUOM") = Me.txtPrimaryUOM.Text
				Dim flag5 As Boolean = Operators.CompareString(Me.txtPrimaryPackSize.Text, "", False) <> 0
				If flag5 Then
					Me.dtItems.Rows(Me.iRow)("PrimaryPackSize") = Me.txtPrimaryPackSize.Text
				Else
					Me.dtItems.Rows(Me.iRow)("PrimaryPackSize") = DBNull.Value
				End If
				Me.dtItems.Rows(Me.iRow)("UnitPrice") = Me.txtUnitPrice.Text
				Me.dtItems.Rows(Me.iRow)("Quantity") = Me.txtReqQtyTer.Text
				Me.dtItems.Rows(Me.iRow)("BasicValue") = Me.txtBasicAmt.Text
				Me.dtItems.Rows(Me.iRow)("NetAmt") = Me.txtNetAmt.Text
				Me.dtItems.Rows(Me.iRow)("TaxPer") = Me.cmbTaxPer.Text
				Me.dtItems.Rows(Me.iRow)("TaxAmt") = Strings.Format(Conversion.Val(Me.txtTaxAmt.Text), "#0.00")
				Me.dtItems.Rows(Me.iRow)("OtherCharges") = Conversion.Val(Me.txtOtherCharges.Text)
				Me.dtItems.Rows(Me.iRow)("FinalAmt") = Strings.Format(Conversion.Val(Me.txtFinalAmt.Text), "#0.00")
				MyBase.DialogResult = DialogResult.OK
				MyBase.Close()
			End If
		End Sub

		' Token: 0x0400083C RID: 2108
		Private iRow As Integer

		' Token: 0x0400083D RID: 2109
		Private sFormType As String

		' Token: 0x0400083E RID: 2110
		Private dtProduct As DataTable

		' Token: 0x0400083F RID: 2111
		Private sStatus As String

		' Token: 0x04000840 RID: 2112
		Public dtItems As DataTable
	End Class
End Namespace
