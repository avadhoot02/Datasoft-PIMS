Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports WeifenLuo.WinFormsUI.Docking

Namespace Datasoft_PIMS
	' Token: 0x0200005B RID: 91
	<DesignerGenerated()>
	Public Partial Class UIDPrinting
		Inherits DockContent

		' Token: 0x1700078C RID: 1932
		' (get) Token: 0x060013CD RID: 5069 RVA: 0x000B9F33 File Offset: 0x000B8133
		' (set) Token: 0x060013CE RID: 5070 RVA: 0x000B9F3D File Offset: 0x000B813D
		Friend Overridable Property Label12 As Label

		' Token: 0x1700078D RID: 1933
		' (get) Token: 0x060013CF RID: 5071 RVA: 0x000B9F46 File Offset: 0x000B8146
		' (set) Token: 0x060013D0 RID: 5072 RVA: 0x000B9F50 File Offset: 0x000B8150
		Friend Overridable Property Label16 As Label

		' Token: 0x1700078E RID: 1934
		' (get) Token: 0x060013D1 RID: 5073 RVA: 0x000B9F59 File Offset: 0x000B8159
		' (set) Token: 0x060013D2 RID: 5074 RVA: 0x000B9F63 File Offset: 0x000B8163
		Friend Overridable Property GroupBox5 As GroupBox

		' Token: 0x1700078F RID: 1935
		' (get) Token: 0x060013D3 RID: 5075 RVA: 0x000B9F6C File Offset: 0x000B816C
		' (set) Token: 0x060013D4 RID: 5076 RVA: 0x000B9F78 File Offset: 0x000B8178
		Friend Overridable Property btnPrintParent As Button
			<CompilerGenerated()>
			Get
				Return Me._btnPrintParent
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnPrintParent_Click
				Dim button As Button = Me._btnPrintParent
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnPrintParent = value
				button = Me._btnPrintParent
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000790 RID: 1936
		' (get) Token: 0x060013D5 RID: 5077 RVA: 0x000B9FBB File Offset: 0x000B81BB
		' (set) Token: 0x060013D6 RID: 5078 RVA: 0x000B9FC8 File Offset: 0x000B81C8
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

		' Token: 0x17000791 RID: 1937
		' (get) Token: 0x060013D7 RID: 5079 RVA: 0x000BA00B File Offset: 0x000B820B
		' (set) Token: 0x060013D8 RID: 5080 RVA: 0x000BA018 File Offset: 0x000B8218
		Friend Overridable Property btnPrintUID As Button
			<CompilerGenerated()>
			Get
				Return Me._btnPrintUID
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnPrintUID_Click
				Dim button As Button = Me._btnPrintUID
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnPrintUID = value
				button = Me._btnPrintUID
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000792 RID: 1938
		' (get) Token: 0x060013D9 RID: 5081 RVA: 0x000BA05B File Offset: 0x000B825B
		' (set) Token: 0x060013DA RID: 5082 RVA: 0x000BA065 File Offset: 0x000B8265
		Friend Overridable Property GroupBox4 As GroupBox

		' Token: 0x17000793 RID: 1939
		' (get) Token: 0x060013DB RID: 5083 RVA: 0x000BA06E File Offset: 0x000B826E
		' (set) Token: 0x060013DC RID: 5084 RVA: 0x000BA078 File Offset: 0x000B8278
		Friend Overridable Property lblRowsT As Label

		' Token: 0x17000794 RID: 1940
		' (get) Token: 0x060013DD RID: 5085 RVA: 0x000BA081 File Offset: 0x000B8281
		' (set) Token: 0x060013DE RID: 5086 RVA: 0x000BA08B File Offset: 0x000B828B
		Friend Overridable Property Panel3 As Panel

		' Token: 0x17000795 RID: 1941
		' (get) Token: 0x060013DF RID: 5087 RVA: 0x000BA094 File Offset: 0x000B8294
		' (set) Token: 0x060013E0 RID: 5088 RVA: 0x000BA0A0 File Offset: 0x000B82A0
		Friend Overridable Property chkAllT As CheckBox
			<CompilerGenerated()>
			Get
				Return Me._chkAllT
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim eventHandler As EventHandler = AddressOf Me.chkAllT_CheckedChanged
				Dim checkBox As CheckBox = Me._chkAllT
				If checkBox IsNot Nothing Then
					RemoveHandler checkBox.CheckedChanged, eventHandler
				End If
				Me._chkAllT = value
				checkBox = Me._chkAllT
				If checkBox IsNot Nothing Then
					AddHandler checkBox.CheckedChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000796 RID: 1942
		' (get) Token: 0x060013E1 RID: 5089 RVA: 0x000BA0E3 File Offset: 0x000B82E3
		' (set) Token: 0x060013E2 RID: 5090 RVA: 0x000BA0ED File Offset: 0x000B82ED
		Friend Overridable Property txtStorage As TextBox

		' Token: 0x17000797 RID: 1943
		' (get) Token: 0x060013E3 RID: 5091 RVA: 0x000BA0F6 File Offset: 0x000B82F6
		' (set) Token: 0x060013E4 RID: 5092 RVA: 0x000BA100 File Offset: 0x000B8300
		Friend Overridable Property txtProductID As TextBox

		' Token: 0x17000798 RID: 1944
		' (get) Token: 0x060013E5 RID: 5093 RVA: 0x000BA109 File Offset: 0x000B8309
		' (set) Token: 0x060013E6 RID: 5094 RVA: 0x000BA113 File Offset: 0x000B8313
		Friend Overridable Property GroupBox3 As GroupBox

		' Token: 0x17000799 RID: 1945
		' (get) Token: 0x060013E7 RID: 5095 RVA: 0x000BA11C File Offset: 0x000B831C
		' (set) Token: 0x060013E8 RID: 5096 RVA: 0x000BA126 File Offset: 0x000B8326
		Friend Overridable Property lblRows As Label

		' Token: 0x1700079A RID: 1946
		' (get) Token: 0x060013E9 RID: 5097 RVA: 0x000BA12F File Offset: 0x000B832F
		' (set) Token: 0x060013EA RID: 5098 RVA: 0x000BA139 File Offset: 0x000B8339
		Friend Overridable Property Panel2 As Panel

		' Token: 0x1700079B RID: 1947
		' (get) Token: 0x060013EB RID: 5099 RVA: 0x000BA142 File Offset: 0x000B8342
		' (set) Token: 0x060013EC RID: 5100 RVA: 0x000BA14C File Offset: 0x000B834C
		Friend Overridable Property chkAll As CheckBox
			<CompilerGenerated()>
			Get
				Return Me._chkAll
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim eventHandler As EventHandler = AddressOf Me.chkAll_CheckedChanged
				Dim checkBox As CheckBox = Me._chkAll
				If checkBox IsNot Nothing Then
					RemoveHandler checkBox.CheckedChanged, eventHandler
				End If
				Me._chkAll = value
				checkBox = Me._chkAll
				If checkBox IsNot Nothing Then
					AddHandler checkBox.CheckedChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700079C RID: 1948
		' (get) Token: 0x060013ED RID: 5101 RVA: 0x000BA18F File Offset: 0x000B838F
		' (set) Token: 0x060013EE RID: 5102 RVA: 0x000BA19C File Offset: 0x000B839C
		Friend Overridable Property chkDsiplayParentwise As CheckBox
			<CompilerGenerated()>
			Get
				Return Me._chkDsiplayParentwise
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim eventHandler As EventHandler = AddressOf Me.chkDsiplayParentwise_CheckedChanged
				Dim checkBox As CheckBox = Me._chkDsiplayParentwise
				If checkBox IsNot Nothing Then
					RemoveHandler checkBox.CheckedChanged, eventHandler
				End If
				Me._chkDsiplayParentwise = value
				checkBox = Me._chkDsiplayParentwise
				If checkBox IsNot Nothing Then
					AddHandler checkBox.CheckedChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700079D RID: 1949
		' (get) Token: 0x060013EF RID: 5103 RVA: 0x000BA1DF File Offset: 0x000B83DF
		' (set) Token: 0x060013F0 RID: 5104 RVA: 0x000BA1E9 File Offset: 0x000B83E9
		Friend Overridable Property txtID As TextBox

		' Token: 0x1700079E RID: 1950
		' (get) Token: 0x060013F1 RID: 5105 RVA: 0x000BA1F2 File Offset: 0x000B83F2
		' (set) Token: 0x060013F2 RID: 5106 RVA: 0x000BA1FC File Offset: 0x000B83FC
		Friend Overridable Property txtPONo As TextBox

		' Token: 0x1700079F RID: 1951
		' (get) Token: 0x060013F3 RID: 5107 RVA: 0x000BA205 File Offset: 0x000B8405
		' (set) Token: 0x060013F4 RID: 5108 RVA: 0x000BA20F File Offset: 0x000B840F
		Friend Overridable Property txtProductType As TextBox

		' Token: 0x170007A0 RID: 1952
		' (get) Token: 0x060013F5 RID: 5109 RVA: 0x000BA218 File Offset: 0x000B8418
		' (set) Token: 0x060013F6 RID: 5110 RVA: 0x000BA222 File Offset: 0x000B8422
		Friend Overridable Property GroupBox1 As GroupBox

		' Token: 0x170007A1 RID: 1953
		' (get) Token: 0x060013F7 RID: 5111 RVA: 0x000BA22B File Offset: 0x000B842B
		' (set) Token: 0x060013F8 RID: 5112 RVA: 0x000BA235 File Offset: 0x000B8435
		Friend Overridable Property Label7 As Label

		' Token: 0x170007A2 RID: 1954
		' (get) Token: 0x060013F9 RID: 5113 RVA: 0x000BA23E File Offset: 0x000B843E
		' (set) Token: 0x060013FA RID: 5114 RVA: 0x000BA248 File Offset: 0x000B8448
		Friend Overridable Property lblDisposed As Label

		' Token: 0x170007A3 RID: 1955
		' (get) Token: 0x060013FB RID: 5115 RVA: 0x000BA251 File Offset: 0x000B8451
		' (set) Token: 0x060013FC RID: 5116 RVA: 0x000BA25B File Offset: 0x000B845B
		Friend Overridable Property Label6 As Label

		' Token: 0x170007A4 RID: 1956
		' (get) Token: 0x060013FD RID: 5117 RVA: 0x000BA264 File Offset: 0x000B8464
		' (set) Token: 0x060013FE RID: 5118 RVA: 0x000BA26E File Offset: 0x000B846E
		Friend Overridable Property lblIssued As Label

		' Token: 0x170007A5 RID: 1957
		' (get) Token: 0x060013FF RID: 5119 RVA: 0x000BA277 File Offset: 0x000B8477
		' (set) Token: 0x06001400 RID: 5120 RVA: 0x000BA281 File Offset: 0x000B8481
		Friend Overridable Property txtPOID As TextBox

		' Token: 0x170007A6 RID: 1958
		' (get) Token: 0x06001401 RID: 5121 RVA: 0x000BA28A File Offset: 0x000B848A
		' (set) Token: 0x06001402 RID: 5122 RVA: 0x000BA294 File Offset: 0x000B8494
		Friend Overridable Property txtVendor As TextBox

		' Token: 0x170007A7 RID: 1959
		' (get) Token: 0x06001403 RID: 5123 RVA: 0x000BA29D File Offset: 0x000B849D
		' (set) Token: 0x06001404 RID: 5124 RVA: 0x000BA2A7 File Offset: 0x000B84A7
		Friend Overridable Property txtPOType As TextBox

		' Token: 0x170007A8 RID: 1960
		' (get) Token: 0x06001405 RID: 5125 RVA: 0x000BA2B0 File Offset: 0x000B84B0
		' (set) Token: 0x06001406 RID: 5126 RVA: 0x000BA2BA File Offset: 0x000B84BA
		Friend Overridable Property Label9 As Label

		' Token: 0x170007A9 RID: 1961
		' (get) Token: 0x06001407 RID: 5127 RVA: 0x000BA2C3 File Offset: 0x000B84C3
		' (set) Token: 0x06001408 RID: 5128 RVA: 0x000BA2CD File Offset: 0x000B84CD
		Friend Overridable Property Label24 As Label

		' Token: 0x170007AA RID: 1962
		' (get) Token: 0x06001409 RID: 5129 RVA: 0x000BA2D6 File Offset: 0x000B84D6
		' (set) Token: 0x0600140A RID: 5130 RVA: 0x000BA2E0 File Offset: 0x000B84E0
		Friend Overridable Property dtpDt As DateTimePicker

		' Token: 0x170007AB RID: 1963
		' (get) Token: 0x0600140B RID: 5131 RVA: 0x000BA2E9 File Offset: 0x000B84E9
		' (set) Token: 0x0600140C RID: 5132 RVA: 0x000BA2F3 File Offset: 0x000B84F3
		Friend Overridable Property Label1 As Label

		' Token: 0x170007AC RID: 1964
		' (get) Token: 0x0600140D RID: 5133 RVA: 0x000BA2FC File Offset: 0x000B84FC
		' (set) Token: 0x0600140E RID: 5134 RVA: 0x000BA306 File Offset: 0x000B8506
		Friend Overridable Property Label2 As Label

		' Token: 0x170007AD RID: 1965
		' (get) Token: 0x0600140F RID: 5135 RVA: 0x000BA30F File Offset: 0x000B850F
		' (set) Token: 0x06001410 RID: 5136 RVA: 0x000BA319 File Offset: 0x000B8519
		Friend Overridable Property txtNo As TextBox

		' Token: 0x170007AE RID: 1966
		' (get) Token: 0x06001411 RID: 5137 RVA: 0x000BA322 File Offset: 0x000B8522
		' (set) Token: 0x06001412 RID: 5138 RVA: 0x000BA32C File Offset: 0x000B852C
		Friend Overridable Property dtpPODt As DateTimePicker

		' Token: 0x170007AF RID: 1967
		' (get) Token: 0x06001413 RID: 5139 RVA: 0x000BA335 File Offset: 0x000B8535
		' (set) Token: 0x06001414 RID: 5140 RVA: 0x000BA33F File Offset: 0x000B853F
		Friend Overridable Property Label28 As Label

		' Token: 0x170007B0 RID: 1968
		' (get) Token: 0x06001415 RID: 5141 RVA: 0x000BA348 File Offset: 0x000B8548
		' (set) Token: 0x06001416 RID: 5142 RVA: 0x000BA352 File Offset: 0x000B8552
		Friend Overridable Property Label27 As Label

		' Token: 0x170007B1 RID: 1969
		' (get) Token: 0x06001417 RID: 5143 RVA: 0x000BA35B File Offset: 0x000B855B
		' (set) Token: 0x06001418 RID: 5144 RVA: 0x000BA365 File Offset: 0x000B8565
		Friend Overridable Property txtExpDt As TextBox

		' Token: 0x170007B2 RID: 1970
		' (get) Token: 0x06001419 RID: 5145 RVA: 0x000BA36E File Offset: 0x000B856E
		' (set) Token: 0x0600141A RID: 5146 RVA: 0x000BA378 File Offset: 0x000B8578
		Friend Overridable Property txtProductCode As TextBox

		' Token: 0x170007B3 RID: 1971
		' (get) Token: 0x0600141B RID: 5147 RVA: 0x000BA381 File Offset: 0x000B8581
		' (set) Token: 0x0600141C RID: 5148 RVA: 0x000BA38B File Offset: 0x000B858B
		Friend Overridable Property Label18 As Label

		' Token: 0x170007B4 RID: 1972
		' (get) Token: 0x0600141D RID: 5149 RVA: 0x000BA394 File Offset: 0x000B8594
		' (set) Token: 0x0600141E RID: 5150 RVA: 0x000BA39E File Offset: 0x000B859E
		Friend Overridable Property Label14 As Label

		' Token: 0x170007B5 RID: 1973
		' (get) Token: 0x0600141F RID: 5151 RVA: 0x000BA3A7 File Offset: 0x000B85A7
		' (set) Token: 0x06001420 RID: 5152 RVA: 0x000BA3B1 File Offset: 0x000B85B1
		Friend Overridable Property Label11 As Label

		' Token: 0x170007B6 RID: 1974
		' (get) Token: 0x06001421 RID: 5153 RVA: 0x000BA3BA File Offset: 0x000B85BA
		' (set) Token: 0x06001422 RID: 5154 RVA: 0x000BA3C4 File Offset: 0x000B85C4
		Friend Overridable Property Label10 As Label

		' Token: 0x170007B7 RID: 1975
		' (get) Token: 0x06001423 RID: 5155 RVA: 0x000BA3CD File Offset: 0x000B85CD
		' (set) Token: 0x06001424 RID: 5156 RVA: 0x000BA3D7 File Offset: 0x000B85D7
		Friend Overridable Property Label4 As Label

		' Token: 0x170007B8 RID: 1976
		' (get) Token: 0x06001425 RID: 5157 RVA: 0x000BA3E0 File Offset: 0x000B85E0
		' (set) Token: 0x06001426 RID: 5158 RVA: 0x000BA3EA File Offset: 0x000B85EA
		Friend Overridable Property Panel1 As Panel

		' Token: 0x170007B9 RID: 1977
		' (get) Token: 0x06001427 RID: 5159 RVA: 0x000BA3F3 File Offset: 0x000B85F3
		' (set) Token: 0x06001428 RID: 5160 RVA: 0x000BA3FD File Offset: 0x000B85FD
		Friend Overridable Property txtODPermL As TextBox

		' Token: 0x170007BA RID: 1978
		' (get) Token: 0x06001429 RID: 5161 RVA: 0x000BA406 File Offset: 0x000B8606
		' (set) Token: 0x0600142A RID: 5162 RVA: 0x000BA410 File Offset: 0x000B8610
		Friend Overridable Property Label5 As Label

		' Token: 0x170007BB RID: 1979
		' (get) Token: 0x0600142B RID: 5163 RVA: 0x000BA419 File Offset: 0x000B8619
		' (set) Token: 0x0600142C RID: 5164 RVA: 0x000BA423 File Offset: 0x000B8623
		Friend Overridable Property txtPassageNo As TextBox

		' Token: 0x170007BC RID: 1980
		' (get) Token: 0x0600142D RID: 5165 RVA: 0x000BA42C File Offset: 0x000B862C
		' (set) Token: 0x0600142E RID: 5166 RVA: 0x000BA436 File Offset: 0x000B8636
		Friend Overridable Property txtBatchNo As TextBox

		' Token: 0x170007BD RID: 1981
		' (get) Token: 0x0600142F RID: 5167 RVA: 0x000BA43F File Offset: 0x000B863F
		' (set) Token: 0x06001430 RID: 5168 RVA: 0x000BA449 File Offset: 0x000B8649
		Friend Overridable Property txtPrimaryPackSize As TextBox

		' Token: 0x170007BE RID: 1982
		' (get) Token: 0x06001431 RID: 5169 RVA: 0x000BA452 File Offset: 0x000B8652
		' (set) Token: 0x06001432 RID: 5170 RVA: 0x000BA45C File Offset: 0x000B865C
		Friend Overridable Property Label8 As Label

		' Token: 0x170007BF RID: 1983
		' (get) Token: 0x06001433 RID: 5171 RVA: 0x000BA465 File Offset: 0x000B8665
		' (set) Token: 0x06001434 RID: 5172 RVA: 0x000BA46F File Offset: 0x000B866F
		Friend Overridable Property txtCellCount As TextBox

		' Token: 0x170007C0 RID: 1984
		' (get) Token: 0x06001435 RID: 5173 RVA: 0x000BA478 File Offset: 0x000B8678
		' (set) Token: 0x06001436 RID: 5174 RVA: 0x000BA482 File Offset: 0x000B8682
		Friend Overridable Property txtCatalogNo As TextBox

		' Token: 0x170007C1 RID: 1985
		' (get) Token: 0x06001437 RID: 5175 RVA: 0x000BA48B File Offset: 0x000B868B
		' (set) Token: 0x06001438 RID: 5176 RVA: 0x000BA495 File Offset: 0x000B8695
		Friend Overridable Property txtMfgDt As TextBox

		' Token: 0x170007C2 RID: 1986
		' (get) Token: 0x06001439 RID: 5177 RVA: 0x000BA49E File Offset: 0x000B869E
		' (set) Token: 0x0600143A RID: 5178 RVA: 0x000BA4A8 File Offset: 0x000B86A8
		Friend Overridable Property Label3 As Label

		' Token: 0x170007C3 RID: 1987
		' (get) Token: 0x0600143B RID: 5179 RVA: 0x000BA4B1 File Offset: 0x000B86B1
		' (set) Token: 0x0600143C RID: 5180 RVA: 0x000BA4BB File Offset: 0x000B86BB
		Friend Overridable Property Label17 As Label

		' Token: 0x170007C4 RID: 1988
		' (get) Token: 0x0600143D RID: 5181 RVA: 0x000BA4C4 File Offset: 0x000B86C4
		' (set) Token: 0x0600143E RID: 5182 RVA: 0x000BA4CE File Offset: 0x000B86CE
		Friend Overridable Property txtProductName As TextBox

		' Token: 0x170007C5 RID: 1989
		' (get) Token: 0x0600143F RID: 5183 RVA: 0x000BA4D7 File Offset: 0x000B86D7
		' (set) Token: 0x06001440 RID: 5184 RVA: 0x000BA4E1 File Offset: 0x000B86E1
		Friend Overridable Property Label15 As Label

		' Token: 0x170007C6 RID: 1990
		' (get) Token: 0x06001441 RID: 5185 RVA: 0x000BA4EA File Offset: 0x000B86EA
		' (set) Token: 0x06001442 RID: 5186 RVA: 0x000BA4F4 File Offset: 0x000B86F4
		Friend Overridable Property Label13 As Label

		' Token: 0x170007C7 RID: 1991
		' (get) Token: 0x06001443 RID: 5187 RVA: 0x000BA4FD File Offset: 0x000B86FD
		' (set) Token: 0x06001444 RID: 5188 RVA: 0x000BA507 File Offset: 0x000B8707
		Friend Overridable Property cmbCopies As ComboBox

		' Token: 0x170007C8 RID: 1992
		' (get) Token: 0x06001445 RID: 5189 RVA: 0x000BA510 File Offset: 0x000B8710
		' (set) Token: 0x06001446 RID: 5190 RVA: 0x000BA51A File Offset: 0x000B871A
		Friend Overridable Property GroupBox2 As GroupBox

		' Token: 0x170007C9 RID: 1993
		' (get) Token: 0x06001447 RID: 5191 RVA: 0x000BA523 File Offset: 0x000B8723
		' (set) Token: 0x06001448 RID: 5192 RVA: 0x000BA530 File Offset: 0x000B8730
		Friend Overridable Property dgvT As DataGridView
			<CompilerGenerated()>
			Get
				Return Me._dgvT
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim dataGridViewCellMouseEventHandler As DataGridViewCellMouseEventHandler = AddressOf Me.dgvT_CellMouseUp
				Dim dataGridView As DataGridView = Me._dgvT
				If dataGridView IsNot Nothing Then
					RemoveHandler dataGridView.CellMouseUp, dataGridViewCellMouseEventHandler
				End If
				Me._dgvT = value
				dataGridView = Me._dgvT
				If dataGridView IsNot Nothing Then
					AddHandler dataGridView.CellMouseUp, dataGridViewCellMouseEventHandler
				End If
			End Set
		End Property

		' Token: 0x170007CA RID: 1994
		' (get) Token: 0x06001449 RID: 5193 RVA: 0x000BA573 File Offset: 0x000B8773
		' (set) Token: 0x0600144A RID: 5194 RVA: 0x000BA57D File Offset: 0x000B877D
		Friend Overridable Property tChk As DataGridViewCheckBoxColumn

		' Token: 0x170007CB RID: 1995
		' (get) Token: 0x0600144B RID: 5195 RVA: 0x000BA586 File Offset: 0x000B8786
		' (set) Token: 0x0600144C RID: 5196 RVA: 0x000BA590 File Offset: 0x000B8790
		Friend Overridable Property tParentUID As DataGridViewTextBoxColumn

		' Token: 0x170007CC RID: 1996
		' (get) Token: 0x0600144D RID: 5197 RVA: 0x000BA599 File Offset: 0x000B8799
		' (set) Token: 0x0600144E RID: 5198 RVA: 0x000BA5A3 File Offset: 0x000B87A3
		Friend Overridable Property tCatalogNo As DataGridViewTextBoxColumn

		' Token: 0x170007CD RID: 1997
		' (get) Token: 0x0600144F RID: 5199 RVA: 0x000BA5AC File Offset: 0x000B87AC
		' (set) Token: 0x06001450 RID: 5200 RVA: 0x000BA5B6 File Offset: 0x000B87B6
		Friend Overridable Property imgFill As DataGridViewImageColumn

		' Token: 0x170007CE RID: 1998
		' (get) Token: 0x06001451 RID: 5201 RVA: 0x000BA5BF File Offset: 0x000B87BF
		' (set) Token: 0x06001452 RID: 5202 RVA: 0x000BA5C9 File Offset: 0x000B87C9
		Friend Overridable Property dgv1 As DataGridView

		' Token: 0x170007CF RID: 1999
		' (get) Token: 0x06001453 RID: 5203 RVA: 0x000BA5D2 File Offset: 0x000B87D2
		' (set) Token: 0x06001454 RID: 5204 RVA: 0x000BA5DC File Offset: 0x000B87DC
		Friend Overridable Property chk As DataGridViewCheckBoxColumn

		' Token: 0x170007D0 RID: 2000
		' (get) Token: 0x06001455 RID: 5205 RVA: 0x000BA5E5 File Offset: 0x000B87E5
		' (set) Token: 0x06001456 RID: 5206 RVA: 0x000BA5EF File Offset: 0x000B87EF
		Friend Overridable Property UID As DataGridViewTextBoxColumn

		' Token: 0x170007D1 RID: 2001
		' (get) Token: 0x06001457 RID: 5207 RVA: 0x000BA5F8 File Offset: 0x000B87F8
		' (set) Token: 0x06001458 RID: 5208 RVA: 0x000BA602 File Offset: 0x000B8802
		Friend Overridable Property ParentUID As DataGridViewTextBoxColumn

		' Token: 0x170007D2 RID: 2002
		' (get) Token: 0x06001459 RID: 5209 RVA: 0x000BA60B File Offset: 0x000B880B
		' (set) Token: 0x0600145A RID: 5210 RVA: 0x000BA615 File Offset: 0x000B8815
		Friend Overridable Property Product As DataGridViewTextBoxColumn

		' Token: 0x170007D3 RID: 2003
		' (get) Token: 0x0600145B RID: 5211 RVA: 0x000BA61E File Offset: 0x000B881E
		' (set) Token: 0x0600145C RID: 5212 RVA: 0x000BA628 File Offset: 0x000B8828
		Friend Overridable Property CatalogNo As DataGridViewTextBoxColumn

		' Token: 0x170007D4 RID: 2004
		' (get) Token: 0x0600145D RID: 5213 RVA: 0x000BA631 File Offset: 0x000B8831
		' (set) Token: 0x0600145E RID: 5214 RVA: 0x000BA63B File Offset: 0x000B883B
		Friend Overridable Property Description As DataGridViewTextBoxColumn

		' Token: 0x170007D5 RID: 2005
		' (get) Token: 0x0600145F RID: 5215 RVA: 0x000BA644 File Offset: 0x000B8844
		' (set) Token: 0x06001460 RID: 5216 RVA: 0x000BA64E File Offset: 0x000B884E
		Friend Overridable Property BatchNo As DataGridViewTextBoxColumn

		' Token: 0x170007D6 RID: 2006
		' (get) Token: 0x06001461 RID: 5217 RVA: 0x000BA657 File Offset: 0x000B8857
		' (set) Token: 0x06001462 RID: 5218 RVA: 0x000BA661 File Offset: 0x000B8861
		Friend Overridable Property Price As DataGridViewTextBoxColumn

		' Token: 0x170007D7 RID: 2007
		' (get) Token: 0x06001463 RID: 5219 RVA: 0x000BA66A File Offset: 0x000B886A
		' (set) Token: 0x06001464 RID: 5220 RVA: 0x000BA674 File Offset: 0x000B8874
		Friend Overridable Property IsParentApplicable As DataGridViewCheckBoxColumn

		' Token: 0x170007D8 RID: 2008
		' (get) Token: 0x06001465 RID: 5221 RVA: 0x000BA67D File Offset: 0x000B887D
		' (set) Token: 0x06001466 RID: 5222 RVA: 0x000BA687 File Offset: 0x000B8887
		Friend Overridable Property IsUnitsEditable As DataGridViewCheckBoxColumn

		' Token: 0x170007D9 RID: 2009
		' (get) Token: 0x06001467 RID: 5223 RVA: 0x000BA690 File Offset: 0x000B8890
		' (set) Token: 0x06001468 RID: 5224 RVA: 0x000BA69A File Offset: 0x000B889A
		Friend Overridable Property Status As DataGridViewTextBoxColumn

		' Token: 0x170007DA RID: 2010
		' (get) Token: 0x06001469 RID: 5225 RVA: 0x000BA6A3 File Offset: 0x000B88A3
		' (set) Token: 0x0600146A RID: 5226 RVA: 0x000BA6AD File Offset: 0x000B88AD
		Friend Overridable Property ProductID As DataGridViewTextBoxColumn

		' Token: 0x170007DB RID: 2011
		' (get) Token: 0x0600146B RID: 5227 RVA: 0x000BA6B6 File Offset: 0x000B88B6
		' (set) Token: 0x0600146C RID: 5228 RVA: 0x000BA6C0 File Offset: 0x000B88C0
		Friend Overridable Property txtMeasurement As TextBox

		' Token: 0x170007DC RID: 2012
		' (get) Token: 0x0600146D RID: 5229 RVA: 0x000BA6C9 File Offset: 0x000B88C9
		' (set) Token: 0x0600146E RID: 5230 RVA: 0x000BA6D3 File Offset: 0x000B88D3
		Friend Overridable Property Label19 As Label

		' Token: 0x170007DD RID: 2013
		' (get) Token: 0x0600146F RID: 5231 RVA: 0x000BA6DC File Offset: 0x000B88DC
		' (set) Token: 0x06001470 RID: 5232 RVA: 0x000BA6E6 File Offset: 0x000B88E6
		Friend Overridable Property cmbPrinter As ComboBox

		' Token: 0x06001471 RID: 5233 RVA: 0x000BA6F0 File Offset: 0x000B88F0
		Public Sub New(dr As DataRow)
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			AddHandler MyBase.Shown, AddressOf Me.Me_Shown
			Me.InitializeComponent()
			Designing.SetTheme(Me)
			Me.drData = dr
		End Sub

		' Token: 0x06001472 RID: 5234 RVA: 0x000BA754 File Offset: 0x000B8954
		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x06001473 RID: 5235 RVA: 0x000BA789 File Offset: 0x000B8989
		Private Sub Me_Load(sender As Object, e As EventArgs)
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x06001474 RID: 5236 RVA: 0x000BA7A3 File Offset: 0x000B89A3
		Private Sub Me_Shown(sender As Object, e As EventArgs)
			Me.FillData()
		End Sub

		' Token: 0x06001475 RID: 5237 RVA: 0x000BA7B0 File Offset: 0x000B89B0
		Private Sub FillCombo()
			Dim text As String = " SELECT PrinterID, PrinterCode, PrinterName,'' PrinterIP, PrinterIP EnPrinterIP, PrinterPort "
			text += " FROM LANPrinter ORDER BY PrinterName"
			Me.dtPrinter = MainModule.GetData(text)
			Try
				Dim num As Integer = Me.dtPrinter.Rows.Count - 1
				For i As Integer = 0 To num
					Me.dtPrinter.Rows(i)("PrinterIP") = MainModule.DecryptData(Conversions.ToString(Me.dtPrinter.Rows(i)("EnPrinterIP")), GlobalVariables.gsPwd)
				Next
			Catch ex As Exception
				Return
			End Try
			Dim flag As Boolean = Me.dtPrinter.Rows.Count > 0
			If flag Then
				Me.dtPrinter.Rows.InsertAt(Me.dtPrinter.NewRow(), 0)
			Else
				Me.cmbPrinter.ValueMember = "PrinterID"
				Me.cmbPrinter.DisplayMember = "PrinterName"
				Me.cmbPrinter.DataSource = Me.dtPrinter
				Me.cmbPrinter.SelectedIndex = 0
			End If
		End Sub

		' Token: 0x06001476 RID: 5238 RVA: 0x000BA8E0 File Offset: 0x000B8AE0
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
						Me.txtVendor.Text = Conversions.ToString(Me.drData("VendorName"))
						Me.txtPOType.Text = Me.drData("POType").ToString()
						Me.txtPONo.Text = Me.drData("PONo").ToString()
						Dim flag3 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.drData("PODt")))
						If flag3 Then
							Me.dtpPODt.Value = Conversions.ToDate(Me.drData("PODt"))
							Me.dtpPODt.Checked = True
						Else
							Me.dtpPODt.Value = DateAndTime.Now
							Me.dtpPODt.Checked = False
							Me.dtpPODt.CustomFormat = " "
						End If
						Me.txtProductID.Text = Conversions.ToString(Me.drData("ProductID"))
						Me.txtProductType.Text = Conversions.ToString(Me.drData("ProductType"))
						Me.txtProductCode.Text = Conversions.ToString(Me.drData("ProductCode"))
						Me.txtProductName.Text = Conversions.ToString(Me.drData("ProductName"))
						Me.txtCatalogNo.Text = Conversions.ToString(Me.drData("CatalogNo"))
						Me.txtBatchNo.Text = Conversions.ToString(Me.drData("BatchNo"))
						Dim flag4 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.drData("MfgDt")))
						If flag4 Then
							Me.txtMfgDt.Text = Conversions.ToDate(Me.drData("MfgDt")).ToString("dd'/'MM'/'yyyy")
						Else
							Me.txtMfgDt.Text = ""
						End If
						Dim flag5 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.drData("ExpDt")))
						If flag5 Then
							Me.txtExpDt.Text = Strings.Format(Conversions.ToDate(Me.drData("ExpDt")), "dd'/'MM'/'yyyy")
						Else
							Me.txtExpDt.Text = ""
						End If
						Me.txtStorage.Text = Me.drData("StorageCondition").ToString()
						Me.txtPrimaryPackSize.Text = Me.drData("PrimaryPackSize").ToString()
						Me.txtMeasurement.Text = Me.drData("Measurement").ToString()
						Me.txtCellCount.Text = Me.drData("CellCount").ToString()
						Me.txtPassageNo.Text = Me.drData("PassageNo").ToString()
						Me.txtODPermL.Text = Me.drData("ODPermL").ToString()
						Me.cmbCopies.Text = "1"
					End If
					Me.FillGRNBarcodes()
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06001477 RID: 5239 RVA: 0x000BAD58 File Offset: 0x000B8F58
		Private Sub FillGRNBarcodes()
			Dim text As String = " SELECT 0 AS Chk, GU.ProductID, GU.UID, GU.ParentUID, " & vbCrLf
			text += " P.ProductName, GU.CatalogNo, GU.Description, " & vbCrLf
			text += " GU.BatchNo, GU.Price, GU.IsUnitsEditable, GU.IsParentApplicable, GU.Status" & vbCrLf
			text += " FROM GRNUID AS GU" & vbCrLf
			text += " INNER JOIN Product AS P ON GU.ProductID = P.ProductID" & vbCrLf
			text = String.Concat(New String() { text, " WHERE GRNID = '", Me.txtID.Text, "' AND GU.ProductID = '", Me.txtProductID.Text, "' AND GU.BatchNo = '", Me.txtBatchNo.Text, "'" })
			Me.dtBarcodes = MainModule.GetData(text)
			Me.dtBarcodeTemp = Me.dtBarcodes.Clone()
			Me.dtParent = Me.dtBarcodes.DefaultView.ToTable(True, New String() { "Chk", "ParentUID", "CatalogNo" })
			Dim dataColumn As DataColumn = New DataColumn("imgFill", GetType(Byte()))
			dataColumn.DefaultValue = MainModule.ImageToBytes(ResourceModule.imgBlank)
			Me.dtParent.Columns.Add(dataColumn)
			Me.lblRowsT.Text = Conversions.ToString(Me.dtParent.Rows.Count) + " - Rows"
			Me.dgvT.DataSource = Me.dtParent
			Me.chkDsiplayParentwise.Checked = False
			Me.lblRows.Text = Conversions.ToString(Me.dtBarcodes.Rows.Count) + " - Rows"
			Me.dgv1.DataSource = Me.dtBarcodes
			Me.dgvT.Columns("imgFill").Visible = False
			Dim num As Integer = Me.dgv1.Rows.Count - 1
			For i As Integer = 0 To num
				Dim text2 As String = Me.dgv1.Rows(i).Cells("Status").Value.ToString()
				If Operators.CompareString(text2, "Created", False) <> 0 AndAlso Operators.CompareString(text2, "Available", False) <> 0 AndAlso Operators.CompareString(text2, "Picked", False) <> 0 Then
					If Operators.CompareString(text2, "Issued", False) <> 0 Then
						If Operators.CompareString(text2, "Disposed", False) <> 0 Then
							Me.dgv1.Rows(i).Cells("chk").[ReadOnly] = True
							Me.dgv1.Rows(i).DefaultCellStyle.ForeColor = Me.lblDisposed.BackColor
						Else
							Me.dgv1.Rows(i).Cells("chk").[ReadOnly] = True
							Me.dgv1.Rows(i).DefaultCellStyle.ForeColor = Me.lblDisposed.BackColor
						End If
					Else
						Dim flag As Boolean = Operators.CompareString(GlobalVariables.gsUserGroup, "Super Admin", False) <> 0
						If flag Then
							Me.dgv1.Rows(i).Cells("chk").[ReadOnly] = True
						End If
						Me.dgv1.Rows(i).DefaultCellStyle.ForeColor = Me.lblIssued.BackColor
					End If
				Else
					Me.dgv1.Rows(i).DefaultCellStyle.BackColor = Color.White
				End If
			Next
		End Sub

		' Token: 0x06001478 RID: 5240 RVA: 0x000BB101 File Offset: 0x000B9301
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06001479 RID: 5241 RVA: 0x000BB10C File Offset: 0x000B930C
		Private Sub dgvT_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs)
			Dim flag As Boolean = e.RowIndex > -1
			If flag Then
				Dim name As String = Me.dgvT.Columns(e.ColumnIndex).Name
				If Operators.CompareString(name, "tChk", False) <> 0 Then
					If Operators.CompareString(name, "tParentUID", False) <> 0 Then
						If Operators.CompareString(name, "imgFill", False) = 0 Then
							Dim checked As Boolean = Me.chkDsiplayParentwise.Checked
							If checked Then
								Me.SetGridFill(e.RowIndex)
								Me.chkAll.Checked = False
								Dim text As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("ParentUID IN ('", Me.dgvT.Rows(e.RowIndex).Cells("tParentUID").Value), "')"))
								Dim dataView As DataView = New DataView(Me.dtBarcodes, text, "UID", DataViewRowState.OriginalRows)
								Dim dataTable As DataTable = dataView.ToTable()
								Me.lblRows.Text = Conversions.ToString(dataTable.Rows.Count) + " - Rows"
								Me.dgv1.DataSource = dataTable
								Dim num As Integer = Me.dgv1.Rows.Count - 1
								For i As Integer = 0 To num
									Dim text2 As String = Me.dgv1.Rows(i).Cells("Status").Value.ToString()
									If Operators.CompareString(text2, "Created", False) <> 0 AndAlso Operators.CompareString(text2, "Available", False) <> 0 AndAlso Operators.CompareString(text2, "Picked", False) <> 0 Then
										Me.dgv1.Rows(i).Cells("chk").[ReadOnly] = True
										Me.dgv1.Rows(i).DefaultCellStyle.ForeColor = Me.lblIssued.BackColor
									Else
										Me.dgv1.Rows(i).DefaultCellStyle.BackColor = Color.White
									End If
								Next
							End If
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x0600147A RID: 5242 RVA: 0x000BB350 File Offset: 0x000B9550
		Private Sub SetGridFill(iRow As Integer)
			Dim dataTable As DataTable = CType(Me.dgvT.DataSource, DataTable)
			Dim num As Integer = dataTable.Rows.Count - 1
			For i As Integer = 0 To num
				Dim flag As Boolean = i = iRow
				If flag Then
					dataTable.Rows(i)("imgFill") = MainModule.ImageToBytes(ResourceModule.imgRightArrow)
				Else
					dataTable.Rows(i)("imgFill") = MainModule.ImageToBytes(ResourceModule.imgBlank)
				End If
			Next
			Me.dgvT.DataSource = dataTable
		End Sub

		' Token: 0x0600147B RID: 5243 RVA: 0x000BB3E8 File Offset: 0x000B95E8
		Private Sub chkDsiplayParentwise_CheckedChanged(sender As Object, e As EventArgs)
			Me.chkAll.Checked = False
			Me.SetGridFill(-1)
			Dim checked As Boolean = Me.chkDsiplayParentwise.Checked
			If checked Then
				Me.dgvT.Columns("imgFill").Visible = True
				Me.lblRows.Text = Conversions.ToString(Me.dtBarcodeTemp.Rows.Count) + " - Rows"
				Me.dgv1.DataSource = Me.dtBarcodeTemp
			Else
				Me.dgvT.Columns("imgFill").Visible = False
				Me.lblRows.Text = Conversions.ToString(Me.dtBarcodes.Rows.Count) + " - Rows"
				Me.dgv1.DataSource = Me.dtBarcodes
				Dim num As Integer = Me.dgv1.Rows.Count - 1
				For i As Integer = 0 To num
					Dim text As String = Me.dgv1.Rows(i).Cells("Status").Value.ToString()
					If Operators.CompareString(text, "Created", False) <> 0 AndAlso Operators.CompareString(text, "Available", False) <> 0 AndAlso Operators.CompareString(text, "Picked", False) <> 0 Then
						Me.dgv1.Rows(i).Cells("chk").[ReadOnly] = True
						Me.dgv1.Rows(i).DefaultCellStyle.ForeColor = Me.lblIssued.BackColor
					Else
						Me.dgv1.Rows(i).DefaultCellStyle.BackColor = Color.White
					End If
				Next
			End If
		End Sub

		' Token: 0x0600147C RID: 5244 RVA: 0x000BB5C8 File Offset: 0x000B97C8
		Private Sub chkAllT_CheckedChanged(sender As Object, e As EventArgs)
			Dim num As Integer = 0
			Dim checked As Boolean = Me.chkAllT.Checked
			If checked Then
				num = 1
			End If
			Dim dataTable As DataTable = CType(Me.dgvT.DataSource, DataTable)
			Dim num2 As Integer = dataTable.Rows.Count - 1
			For i As Integer = 0 To num2
				dataTable.Rows(i)("chk") = num
			Next
			Me.dgvT.DataSource = dataTable
		End Sub

		' Token: 0x0600147D RID: 5245 RVA: 0x000BB648 File Offset: 0x000B9848
		Private Sub chkAll_CheckedChanged(sender As Object, e As EventArgs)
			Dim num As Integer = 0
			Dim checked As Boolean = Me.chkAll.Checked
			If checked Then
				num = 1
			End If
			Dim dataTable As DataTable = CType(Me.dgv1.DataSource, DataTable)
			Dim num2 As Integer = dataTable.Rows.Count - 1
			For i As Integer = 0 To num2
				Dim text As String = Me.dgv1.Rows(i).Cells("Status").Value.ToString()
				If Operators.CompareString(text, "Created", False) <> 0 AndAlso Operators.CompareString(text, "Available", False) <> 0 AndAlso Operators.CompareString(text, "Picked", False) <> 0 Then
					If Operators.CompareString(text, "Disposed", False) <> 0 Then
						Dim flag As Boolean = Operators.CompareString(GlobalVariables.gsUserGroup, "Super Admin", False) = 0
						If flag Then
							dataTable.Rows(i)("chk") = num
						End If
					End If
				Else
					dataTable.Rows(i)("chk") = num
				End If
			Next
			Me.dgv1.DataSource = dataTable
		End Sub

		' Token: 0x0600147E RID: 5246 RVA: 0x000BB77C File Offset: 0x000B997C
		Private Sub btnPrintParent_Click(sender As Object, e As EventArgs)
			Try
				Me.PrintData("ParentUID")
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x0600147F RID: 5247 RVA: 0x000BB7D8 File Offset: 0x000B99D8
		Private Sub btnPrintUID_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Operators.CompareString(Me.txtID.Text, "", False) <> 0
				If flag Then
					Me.SetPrintStatus()
					Me.PrintData("UID")
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06001480 RID: 5248 RVA: 0x000BB85C File Offset: 0x000B9A5C
		Private Sub SetPrintStatus()
			Dim text As String = String.Concat(New String() { "UPDATE GRN SET PrintBy = '", GlobalVariables.gsUserID, "', PrintDt = GETDATE() WHERE GRNID = '", Me.txtID.Text, "'" })
			Dim flag As Boolean = MainModule.ExecuteSQL(text) = 1
			If flag Then
			End If
		End Sub

		' Token: 0x06001481 RID: 5249 RVA: 0x000BB8B4 File Offset: 0x000B9AB4
		Private Sub PrintData(sType As String)
			Dim text As String = AppDomain.CurrentDomain.BaseDirectory.ToString()
			Dim text2 As String = "lpt3"
			File.Delete(text + "Text.txt")
			File.Delete(text + "Batch.bat")
			Dim flag As Boolean = Operators.CompareString(sType, "UID", False) = 0
			Dim text3 As String
			If flag Then
				text3 = Me.PrintUID_30x30()
			Else
				text3 = Me.PrintParentUID_30x30()
			End If
			Dim flag2 As Boolean = Operators.CompareString(text3, "", False) <> 0
			If flag2 Then
				Dim fileStream As FileStream = New FileStream(text + "Text.txt", FileMode.Create)
				Dim streamWriter As StreamWriter = New StreamWriter(fileStream)
				streamWriter.BaseStream.Seek(0L, SeekOrigin.Begin)
				streamWriter.WriteLine(text3)
				streamWriter.Close()
				fileStream.Close()
				text3 = "cd\" & vbCrLf
				text3 = text3 + Strings.Mid(text, 1, 2) + vbCrLf
				text3 = text3 + "cd " + text + vbCrLf
				text3 = text3 + "copy Text.txt " + text2 + vbCrLf
				text3 += "exit"
				Dim fileStream2 As FileStream = New FileStream(text + "Batch.bat", FileMode.Create, FileAccess.Write)
				Dim streamWriter2 As StreamWriter = New StreamWriter(fileStream2)
				streamWriter2.BaseStream.Seek(0L, SeekOrigin.[End])
				streamWriter2.WriteLine(text3)
				streamWriter2.Close()
				fileStream2.Close()
				Dim num As Integer = Interaction.Shell(text + "Batch.bat", AppWinStyle.MaximizedFocus, True, -1)
			End If
			Me.cmbCopies.Text = "1"
		End Sub

		' Token: 0x06001482 RID: 5250 RVA: 0x000BBA3C File Offset: 0x000B9C3C
		Private Sub PrintData_TCPIP(sType As String)
			Try
				Dim flag As Boolean = Me.cmbPrinter.SelectedIndex < 1
				If flag Then
					CustomMsgBox.Show("Printer Not Selected.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.cmbPrinter.Focus()
				Else
					Dim dataRow As DataRow = Me.dtPrinter.[Select]("PrinterID = '" + Me.cmbPrinter.SelectedValue.ToString() + "'")(0)
					Dim text As String = dataRow("PrinterIP").ToString()
					Dim text2 As String = dataRow("PrinterPort").ToString()
					Dim flag2 As Boolean = Not MainModule.GetPing(text)
					If Not flag2 Then
						Dim flag3 As Boolean = Operators.CompareString(sType, "UID", False) = 0
						Dim text3 As String
						If flag3 Then
							text3 = Me.PrintUID_30x30()
						Else
							text3 = Me.PrintParentUID_30x30()
						End If
						Dim flag4 As Boolean = Operators.CompareString(text3, "", False) <> 0
						If flag4 Then
							Me.SendDataToPrinter(text, text2, text3)
						End If
					End If
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06001483 RID: 5251 RVA: 0x000BBB7C File Offset: 0x000B9D7C
		Private Function PrintUID() As String
			Dim text As String = ""
			Dim dataView As DataView = New DataView(CType(Me.dgv1.DataSource, DataTable), "UID <> '' AND Chk = 1", "UID", DataViewRowState.CurrentRows)
			Dim dataTable As DataTable = dataView.ToTable()
			Dim dataTable2 As DataTable = dataTable.DefaultView.ToTable(True, New String() { "Chk", "UID", "CatalogNo", "BatchNo" })
			Dim text2 As String = ""
			Dim num As Integer = dataTable2.Rows.Count - 1
			For i As Integer = 0 To num Step 2
				Dim text3 As String = ""
				Dim text4 As String = Conversions.ToString(dataTable2.Rows(i)("UID"))
				text += "<xpml><page quantity='0' pitch='15.0 mm'></xpml>^XA" & vbCrLf
				text += "^SZ2^JMA" & vbCrLf
				text += "^MCY^PMN" & vbCrLf
				text += "^PW636" & vbCrLf
				text += "~JSN" & vbCrLf
				text += "^JZY" & vbCrLf
				text += "^LH0,0" & vbCrLf
				text += "^CW3,E:REFSANB.TTF^fs" & vbCrLf
				text += "^LRN" & vbCrLf
				text += "^XZ" & vbCrLf
				text += "<xpml></page></xpml><xpml><page quantity='1' pitch='15.0 mm'></xpml>^XA" & vbCrLf
				text += "^FO24,17" & vbCrLf
				text = String.Concat(New String() { text, "^BY2^BCN,32,N,N^FD>:", Strings.Mid(text4, 1, 6), ">5", Strings.Mid(text4, 7, 4), "^FS" & vbCrLf })
				text += "^FT123,61" & vbCrLf
				text += "^CI0" & vbCrLf
				text = text + "^A0N,11,16^FD" + text4 + "^FS" & vbCrLf
				text += "^FT24,85" & vbCrLf
				text += "^A3N,17,14^FDCatalog No. ^FS" & vbCrLf
				text += "^FT109,85" & vbCrLf
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("^A3N,17,14^FD : ", dataTable2.Rows(i)("CatalogNo")), "^FS"), vbCrLf)))
				text += "^FT109,107" & vbCrLf
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("^A3N,17,14^FD : ", dataTable2.Rows(i)("BatchNo")), "^FS"), vbCrLf)))
				text += "^FT24,107" & vbCrLf
				text += "^A3N,17,14^FDBatch No. ^FS" & vbCrLf
				Dim flag As Boolean = i + 1 < dataTable2.Rows.Count
				If flag Then
					text3 = Conversions.ToString(dataTable2.Rows(i + 1)("UID"))
					text += "^FO352,17" & vbCrLf
					text = String.Concat(New String() { text, "^BCN,32,N,N^FD>:", Strings.Mid(text3, 1, 6), ">5", Strings.Mid(text3, 7, 4), "^FS" & vbCrLf })
					text += "^FT452,61" & vbCrLf
					text = text + "^A0N,11,16^FD" + text3 + "^FS" & vbCrLf
					text += "^FT351,85" & vbCrLf
					text += "^A3N,17,14^FDCatalog No. ^FS" & vbCrLf
					text += "^FT435,85" & vbCrLf
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("^A3N,17,14^FD : ", dataTable2.Rows(i + 1)("CatalogNo")), "^FS"), vbCrLf)))
					text += "^FT435,107" & vbCrLf
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("^A3N,17,14^FD : ", dataTable2.Rows(i + 1)("BatchNo")), "^FS"), vbCrLf)))
					text += "^FT351,107" & vbCrLf
					text += "^A3N,17,14^FDBatch No. ^FS" & vbCrLf
				End If
				text += "^PQ1,0,1,Y" & vbCrLf
				text += "^XZ" & vbCrLf
				text += "<xpml></page></xpml><xpml><end/></xpml>" & vbCrLf
				text2 = String.Concat(New String() { text2, text4, " : ", text3, " : " })
			Next
			Dim flag2 As Boolean = Operators.CompareString(text2, "", False) <> 0
			If flag2 Then
				MainModule.TrnLog(Me.Text, "UID Printed : UID", " UID List : " + text2, Nothing)
			End If
			Return text
		End Function

		' Token: 0x06001484 RID: 5252 RVA: 0x000BC060 File Offset: 0x000BA260
		Private Function PrintParentUID() As String
			Dim text As String = ""
			Dim dataView As DataView = New DataView(CType(Me.dgvT.DataSource, DataTable), "ParentUID <> '' AND Chk = 1", "ParentUID", DataViewRowState.CurrentRows)
			Dim dataTable As DataTable = dataView.ToTable()
			Dim dataTable2 As DataTable = dataTable.DefaultView.ToTable(True, New String() { "Chk", "ParentUID", "CatalogNo" })
			Dim text2 As String = ""
			Dim num As Integer = dataTable2.Rows.Count - 1
			For i As Integer = 0 To num Step 2
				Dim text3 As String = ""
				Dim flag As Boolean = Convert.ToInt16(RuntimeHelpers.GetObjectValue(dataTable2.Rows(i)("Chk"))) = 1S
				If flag Then
					Dim text4 As String = dataTable2.Rows(i)("ParentUID").ToString()
					text += "<xpml><page quantity='0' pitch='15.0 mm'></xpml>^XA" & vbCrLf
					text += "^SZ2^JMA" & vbCrLf
					text += "^MCY^PMN" & vbCrLf
					text += "^PW636" & vbCrLf
					text += "~JSN" & vbCrLf
					text += "^JZY" & vbCrLf
					text += "^LH0,0" & vbCrLf
					text += "^CW3,E:REFSANB.TTF^fs" & vbCrLf
					text += "^LRN" & vbCrLf
					text += "^XZ" & vbCrLf
					text += "<xpml></page></xpml><xpml><page quantity='1' pitch='15.0 mm'></xpml>^XA" & vbCrLf
					text += "^FO24,17" & vbCrLf
					text = String.Concat(New String() { text, "^BY2^BCN,32,N,N^FD>:", Strings.Mid(text4, 1, 5), ">5", Strings.Mid(text4, 6, 4), "^FS" & vbCrLf })
					text += "^FT123,61" & vbCrLf
					text += "^CI0" & vbCrLf
					text = text + "^A0N,11,16^FD" + text4 + "^FS" & vbCrLf
					text += "^FT24,85" & vbCrLf
					text += "^A3N,17,14^FDCatalog No. ^FS" & vbCrLf
					text += "^FT109,85" & vbCrLf
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("^A3N,17,14^FD : ", dataTable2.Rows(i)("CatalogNo")), "^FS"), vbCrLf)))
					Dim flag2 As Boolean = i + 1 < dataTable2.Rows.Count
					If flag2 Then
						Dim flag3 As Boolean = Convert.ToInt16(RuntimeHelpers.GetObjectValue(dataTable2.Rows(i + 1)("Chk"))) = 1S
						If flag3 Then
							text3 = dataTable2.Rows(i + 1)("ParentUID").ToString()
							Dim flag4 As Boolean = Operators.CompareString(text4, text3, False) <> 0
							If flag4 Then
								text += "^FO352,17" & vbCrLf
								text = String.Concat(New String() { text, "^BCN,32,N,N^FD>:", Strings.Mid(text3, 1, 5), ">5", Strings.Mid(text3, 6, 4), "^FS" & vbCrLf })
								text += "^FT452,61" & vbCrLf
								text = text + "^A0N,11,16^FD" + text3 + "^FS" & vbCrLf
								text += "^FT351,85" & vbCrLf
								text += "^A3N,17,14^FDCatalog No. ^FS" & vbCrLf
								text += "^FT435,85" & vbCrLf
								text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("^A3N,17,14^FD : ", dataTable2.Rows(i + 1)("CatalogNo")), "^FS"), vbCrLf)))
							End If
						End If
					End If
					text += "^PQ1,0,1,Y" & vbCrLf
					text += "^XZ" & vbCrLf
					text += "<xpml></page></xpml><xpml><end/></xpml>" & vbCrLf
					text2 = String.Concat(New String() { text2, text4, " : ", text3, " : " })
				End If
			Next
			Dim flag5 As Boolean = Operators.CompareString(text2, "", False) <> 0
			If flag5 Then
				MainModule.TrnLog(Me.Text, "UID Printed : ParentUID", " UID List : " + text2, Nothing)
			End If
			Return text
		End Function

		' Token: 0x06001485 RID: 5253 RVA: 0x000BC4D4 File Offset: 0x000BA6D4
		Private Function PrintParentUID_30x30() As String
			Dim text As String = ""
			Dim dataView As DataView = New DataView(CType(Me.dgvT.DataSource, DataTable), "ParentUID <> '' AND Chk = 1", "ParentUID", DataViewRowState.CurrentRows)
			Dim dataTable As DataTable = dataView.ToTable()
			Dim dataTable2 As DataTable = dataTable.DefaultView.ToTable(True, New String() { "Chk", "ParentUID", "CatalogNo" })
			Dim text2 As String = ""
			Dim num As Integer = dataTable2.Rows.Count - 1
			For i As Integer = 0 To num
				Dim flag As Boolean = Convert.ToInt16(RuntimeHelpers.GetObjectValue(dataTable2.Rows(i)("Chk"))) = 1S
				If flag Then
					Dim text3 As String = dataTable2.Rows(i)("ParentUID").ToString()
					text += "^XA" & vbCrLf
					text += "^SZ2^JMA" & vbCrLf
					text += "^MCY^PMN" & vbCrLf
					text += "^PW239" & vbCrLf
					text += "~JSN" & vbCrLf
					text += "^MD3" & vbCrLf
					text += "^JZY" & vbCrLf
					text += "^LH010,40 " & vbCrLf
					text += "^FO85,60" & vbCrLf
					text = text + "^BY4^BXN,4,200,14,14,4,_^FD" + text3 + "^FS" & vbCrLf
					text += "^FT80,135" & vbCrLf
					text += "^CI28" & vbCrLf
					text = text + "^A0N,18,15^FD" + text3 + "^FS" & vbCrLf
					text += "^FT08,28" & vbCrLf
					text = text + "^A0N,20,16^FDProduct Name: " + Me.txtProductName.Text + "^FS" & vbCrLf
					text += "^FT08,48" & vbCrLf
					Dim text4 As String = Me.txtProductType.Text
					Dim num2 As UInteger = <PrivateImplementationDetails>.ComputeStringHash(text4)
					If num2 <= 2424042855UI Then
						If num2 <= 1381572122UI Then
							If num2 <> 478348301UI Then
								If num2 = 1381572122UI Then
									If Operators.CompareString(text4, "Raw Material", False) = 0 Then
										GoTo IL_02E5
									End If
								End If
							ElseIf Operators.CompareString(text4, "Cell Bank - Mammalian", False) = 0 Then
								GoTo IL_0304
							End If
						ElseIf num2 <> 1773852434UI Then
							If num2 = 2424042855UI Then
								If Operators.CompareString(text4, "Semi Finished", False) = 0 Then
									GoTo IL_0304
								End If
							End If
						ElseIf Operators.CompareString(text4, "Others", False) = 0 Then
							GoTo IL_02E5
						End If
					ElseIf num2 <= 2982502317UI Then
						If num2 <> 2480381874UI Then
							If num2 = 2982502317UI Then
								If Operators.CompareString(text4, "Finished Goods", False) = 0 Then
									GoTo IL_0304
								End If
							End If
						ElseIf Operators.CompareString(text4, "Consumable", False) = 0 Then
							GoTo IL_02E5
						End If
					ElseIf num2 <> 3661748803UI Then
						If num2 = 3955665341UI Then
							If Operators.CompareString(text4, "Packaging Material", False) = 0 Then
								GoTo IL_02E5
							End If
						End If
					ElseIf Operators.CompareString(text4, "Cell Bank - Bacterial", False) = 0 Then
						GoTo IL_0304
					End If
					IL_0323:
					text += "^FT08,69" & vbCrLf
					text = text + "^PQ" + Me.cmbCopies.Text + ",0,1,Y" & vbCrLf
					text += "^XZ" & vbCrLf
					text2 = text2 + text3 + " : "
					GoTo IL_0366
					IL_02E5:
					text = text + "^A0N,20,16^FDCatalog No.: " + Me.txtCatalogNo.Text + "^FS" & vbCrLf
					GoTo IL_0323
					IL_0304:
					text = text + "^A0N,20,16^FDProduct Code: " + Me.txtProductCode.Text + "^FS" & vbCrLf
					GoTo IL_0323
				End If
				IL_0366:
			Next
			Dim flag2 As Boolean = Operators.CompareString(text2, "", False) <> 0
			If flag2 Then
				MainModule.TrnLog(Me.Text, "UID Printed : ParentUID", " UID List : " + text2, Nothing)
			End If
			Return text
		End Function

		' Token: 0x06001486 RID: 5254 RVA: 0x000BC890 File Offset: 0x000BAA90
		Private Function PrintUID_30x30() As String
			Dim text As String = ""
			Dim dataTable As DataTable = CType(Me.dgv1.DataSource, DataTable)
			Dim text2 As String = ""
			Dim num As Integer = dataTable.Rows.Count - 1
			For i As Integer = 0 To num
				Dim text3 As String = Conversions.ToString(dataTable.Rows(i)("UID"))
				Dim flag As Boolean = Convert.ToInt16(RuntimeHelpers.GetObjectValue(dataTable.Rows(i)("Chk"))) = 1S
				If flag Then
					Dim text4 As String = Me.txtProductType.Text
					Dim num2 As UInteger = <PrivateImplementationDetails>.ComputeStringHash(text4)
					If num2 <= 2424042855UI Then
						If num2 <= 1381572122UI Then
							If num2 <> 478348301UI Then
								If num2 = 1381572122UI Then
									If Operators.CompareString(text4, "Raw Material", False) = 0 Then
										GoTo IL_01C8
									End If
								End If
							ElseIf Operators.CompareString(text4, "Cell Bank - Mammalian", False) = 0 Then
								text += Me.Print_CellBank_Mammalian_30x30(text3, i, dataTable.Rows.Count)
							End If
						ElseIf num2 <> 1773852434UI Then
							If num2 = 2424042855UI Then
								If Operators.CompareString(text4, "Semi Finished", False) = 0 Then
									text += Me.Print_SFG_30x30(text3, i, dataTable.Rows.Count)
								End If
							End If
						ElseIf Operators.CompareString(text4, "Others", False) = 0 Then
							GoTo IL_01C8
						End If
					ElseIf num2 <= 2982502317UI Then
						If num2 <> 2480381874UI Then
							If num2 = 2982502317UI Then
								If Operators.CompareString(text4, "Finished Goods", False) = 0 Then
									text += Me.Print_FG_30x30(text3)
								End If
							End If
						ElseIf Operators.CompareString(text4, "Consumable", False) = 0 Then
							GoTo IL_01C8
						End If
					ElseIf num2 <> 3661748803UI Then
						If num2 = 3955665341UI Then
							If Operators.CompareString(text4, "Packaging Material", False) = 0 Then
								GoTo IL_01C8
							End If
						End If
					ElseIf Operators.CompareString(text4, "Cell Bank - Bacterial", False) = 0 Then
						text += Me.Print_CellBank_Bacterial_30x30(text3, i, dataTable.Rows.Count)
					End If
					GoTo IL_0249
					IL_01C8:
					text += Me.Print_RM_30x30(text3)
				End If
				IL_0249:
				text2 = text2 + text3 + " : "
			Next
			Dim flag2 As Boolean = Operators.CompareString(text2, "", False) <> 0
			If flag2 Then
				MainModule.TrnLog(Me.Text, "UID Printed : UID", " UID List : " + text2, Nothing)
			End If
			Return text
		End Function

		' Token: 0x06001487 RID: 5255 RVA: 0x000BCB3C File Offset: 0x000BAD3C
		Private Function Print_RM_30x30(sUID As String) As String
			Dim text As String = ""
			text += "^XA" & vbCrLf
			text += "^SZ2^JMA" & vbCrLf
			text += "^MCY^PMN" & vbCrLf
			text += "^PW239" & vbCrLf
			text += "~JSN" & vbCrLf
			text += "^MD3" & vbCrLf
			text += "^JZY" & vbCrLf
			text += "^LH10,10^LRN" & vbCrLf
			text += "^XZ" & vbCrLf
			text += "^XA" & vbCrLf
			text += "^FO12,100" & vbCrLf
			text = text + "^BY4^BXN,4,200,14,14,4,_^FD" + sUID + "^FS" & vbCrLf
			text += "^FT05,175" & vbCrLf
			text += "^CI28" & vbCrLf
			text = text + "^A0N,18,15^FD" + sUID + "^FS" & vbCrLf
			text += "^FT08,28" & vbCrLf
			text = text + "^A0N,20,16^FDProduct Name: " + Me.txtProductName.Text + "^FS" & vbCrLf
			text += "^FT08,48" & vbCrLf
			text = text + "^A0N,20,16^FDCatalog No.: " + Me.txtCatalogNo.Text + "^FS" & vbCrLf
			text += "^FT08,69" & vbCrLf
			text = text + "^A0N,20,17^FDBatch No.: " + Me.txtBatchNo.Text + "^FS" & vbCrLf
			text += "^FT08,90" & vbCrLf
			text = text + "^A0N,20,17^FDStore At: " + Me.txtStorage.Text + "^FS" & vbCrLf
			text += "^FT80,132" & vbCrLf
			text += "^FT80,115" & vbCrLf
			text = text + "^A0N,20,17^FDMfg. Date: " + Me.txtMfgDt.Text + "^FS" & vbCrLf
			text += "^FT80,134" & vbCrLf
			text = text + "^A0N,20,17^FDExp. Date: " + Me.txtExpDt.Text + " ^FS" & vbCrLf
			text = text + "^PQ" + Me.cmbCopies.Text + ",0,1,Y" & vbCrLf
			Return text + "^XZ" & vbCrLf
		End Function

		' Token: 0x06001488 RID: 5256 RVA: 0x000BCD3C File Offset: 0x000BAF3C
		Private Function Print_SFG_30x30(sUID As String, iRow As Integer, iTotal As Integer) As String
			Dim text As String = ""
			text += "^XA" & vbCrLf
			text += "^SZ2^JMA" & vbCrLf
			text += "^MCY^PMN" & vbCrLf
			text += "^PW239" & vbCrLf
			text += "~JSN" & vbCrLf
			text += "^MD3" & vbCrLf
			text += "^JZY" & vbCrLf
			text += "^LH10,10^LRN" & vbCrLf
			text += "^XZ" & vbCrLf
			text += "^XA" & vbCrLf
			text += "^FO12,118" & vbCrLf
			text = text + "^BY4^BXN,4,200,14,14,4,_^FD" + sUID + "^FS" & vbCrLf
			text += "^FT05,192" & vbCrLf
			text += "^CI28" & vbCrLf
			text = text + "^A0N,18,15^FD" + sUID + "^FS" & vbCrLf
			text += "^FT08,28" & vbCrLf
			text = text + "^A0N,20,16^FDProduct Name: " + Me.txtProductName.Text + "^FS" & vbCrLf
			text += "^FT08,49" & vbCrLf
			text = text + "^A0N,20,17^FDBatch No.: " + Me.txtBatchNo.Text + "^FS" & vbCrLf
			text += "^FT08,110" & vbCrLf
			text = text + "^A0N,20,17^FDStore At: " + Me.txtStorage.Text + "^FS" & vbCrLf
			text += "^FT08,69" & vbCrLf
			text = text + "^A0N,20,17^FDMfg. Date: " + Me.txtMfgDt.Text + "^FS" & vbCrLf
			text += "^FT08,90" & vbCrLf
			text = text + "^A0N,20,17^FDExp. Date: " + Me.txtExpDt.Text + "^FS" & vbCrLf
			text += "^FT80,132" & vbCrLf
			text = String.Concat(New String() { text, "^A0N,20,17^FDVol.: ", Strings.Format(Conversion.Val(Me.txtPrimaryPackSize.Text), "#0.###"), Me.txtMeasurement.Text, "^FS" & vbCrLf })
			text += "^FT80,150" & vbCrLf
			text = text + "^A0N,20,17^FDVial No.: " + Conversions.ToString(iRow + 1) + " ^FS" & vbCrLf
			text = text + "^PQ" + Me.cmbCopies.Text + ",0,1,Y" & vbCrLf
			Return text + "^XZ" & vbCrLf
		End Function

		' Token: 0x06001489 RID: 5257 RVA: 0x000BCF88 File Offset: 0x000BB188
		Private Function Print_CellBank_Bacterial_30x30(sUID As String, iRow As Integer, iTotal As Integer) As String
			Dim text As String = ""
			text += "^XA" & vbCrLf
			text += "^SZ2^JMA" & vbCrLf
			text += "^MCY^PMN" & vbCrLf
			text += "^PW239" & vbCrLf
			text += "~JSN" & vbCrLf
			text += "^MD3" & vbCrLf
			text += "^JZY" & vbCrLf
			text += "^LH10,10^LRN" & vbCrLf
			text += "^XZ" & vbCrLf
			text += "^XA" & vbCrLf
			text += "^FO12,139" & vbCrLf
			text = text + "^BY4^BXN,4,200,14,14,4,_^FD" + sUID + "^FS" & vbCrLf
			text += "^FT05,213" & vbCrLf
			text += "^CI28" & vbCrLf
			text = text + "^A0N,18,15^FD" + sUID + "^FS" & vbCrLf
			text += "^FT08,28" & vbCrLf
			text = text + "^A0N,20,16^FDProduct Name: " + Me.txtProductName.Text + "^FS" & vbCrLf
			text += "^FT08,49" & vbCrLf
			text = text + "^A0N,20,17^FDBatch No.: " + Me.txtBatchNo.Text + "^FS" & vbCrLf
			text += "^FT08,70" & vbCrLf
			text = text + "^A0N,20,17^FDMfg. Date: " + Me.txtMfgDt.Text + "^FS" & vbCrLf
			text += "^FT08,91" & vbCrLf
			text = text + "^A0N,20,17^FH^FDExp Date: " + Me.txtExpDt.Text + "^FS" & vbCrLf
			text += "^FT08,112" & vbCrLf
			text = text + "^A0N,20,17^FDStore At: " + Me.txtStorage.Text + "^FS" & vbCrLf
			text += "^FT08,133" & vbCrLf
			text = text + "^A0N,20,17^FDOD(600nm)/mL: " + Me.txtODPermL.Text + "^FS" & vbCrLf
			text += "^FT80,154" & vbCrLf
			text = String.Concat(New String() { text, "^A0N,20,17^FDVol.: ", Strings.Format(Conversion.Val(Me.txtPrimaryPackSize.Text), "#0.###"), Me.txtMeasurement.Text, "^FS" & vbCrLf })
			text += "^FT80,175" & vbCrLf
			text = text + "^A0N,20,17^FDVial No.: " + Conversions.ToString(iRow + 1) + "^FS" & vbCrLf
			text = text + "^PQ" + Me.cmbCopies.Text + ",0,1,Y" & vbCrLf
			Return text + "^XZ" & vbCrLf
		End Function

		' Token: 0x0600148A RID: 5258 RVA: 0x000BD1FC File Offset: 0x000BB3FC
		Private Function Print_CellBank_Mammalian_30x30(sUID As String, iRow As Integer, iTotal As Integer) As String
			Dim text As String = ""
			text += "^XA" & vbCrLf
			text += "^SZ2^JMA" & vbCrLf
			text += "^MCY^PMN" & vbCrLf
			text += "^PW239" & vbCrLf
			text += "~JSN" & vbCrLf
			text += "^MD3" & vbCrLf
			text += "^JZY" & vbCrLf
			text += "^LH10,10^LRN" & vbCrLf
			text += "^XZ" & vbCrLf
			text += "^XA" & vbCrLf
			text += "^FO12,118" & vbCrLf
			text = text + "^BY4^BXN,4,200,14,14,4,_^FD" + sUID + "^FS" & vbCrLf
			text += "^FT05,192" & vbCrLf
			text += "^CI28" & vbCrLf
			text = text + "^A0N,18,15^FD" + sUID + "^FS" & vbCrLf
			text += "^FT08,28" & vbCrLf
			text = text + "^A0N,20,16^FDProduct Name: " + Me.txtProductName.Text + "^FS" & vbCrLf
			text += "^FT08,49" & vbCrLf
			text = text + "^A0N,20,17^FDBatch No.: " + Me.txtBatchNo.Text + "^FS" & vbCrLf
			text += "^FT08,70" & vbCrLf
			text = text + "^A0N,20,17^FDMfg Date: " + Me.txtMfgDt.Text + "^FS" & vbCrLf
			text += "^FT08,91" & vbCrLf
			text = text + "^A0N,20,17^FH^FDCell Count: " + Strings.Replace(Me.txtCellCount.Text, "^", "_5e", 1, -1, CompareMethod.Binary) + "^FS" & vbCrLf
			text += "^FT08,112" & vbCrLf
			text = text + "^A0N,20,17^FDStore At: " + Me.txtStorage.Text + "^FS" & vbCrLf
			text += "^FT80,134" & vbCrLf
			text = text + "^A0N,20,17^FDPassage No.: " + Me.txtPassageNo.Text + "^FS" & vbCrLf
			text += "^FT80,154" & vbCrLf
			text = String.Concat(New String() { text, "^A0N,20,17^FDVol.: ", Strings.Format(Conversion.Val(Me.txtPrimaryPackSize.Text), "#0.###"), Me.txtMeasurement.Text, "^FS" & vbCrLf })
			text += "^FT80,174" & vbCrLf
			text = text + "^A0N,20,17^FDVial No.: " + Conversions.ToString(iRow + 1) + "^FS" & vbCrLf
			text = text + "^PQ" + Me.cmbCopies.Text + ",0,1,Y" & vbCrLf
			Return text + "^XZ" & vbCrLf
		End Function

		' Token: 0x0600148B RID: 5259 RVA: 0x000BD480 File Offset: 0x000BB680
		Private Function Print_FG_30x30(sUID As String) As String
			Dim text As String = ""
			text += "^XA" & vbCrLf
			text += "^SZ2^JMA" & vbCrLf
			text += "^MCY^PMN" & vbCrLf
			text += "^PW239" & vbCrLf
			text += "~JSN" & vbCrLf
			text += "^MD3" & vbCrLf
			text += "^JZY" & vbCrLf
			text += "^LH10,10^LRN" & vbCrLf
			text += "^XZ" & vbCrLf
			text += "^XA" & vbCrLf
			text += "^FO12,118" & vbCrLf
			text = text + "^BY4^BXN,4,200,14,14,4,_^FD" + sUID + "^FS" & vbCrLf
			text += "^FT05,192" & vbCrLf
			text += "^CI28" & vbCrLf
			text = text + "^A0N,18,15^FD" + sUID + "^FS" & vbCrLf
			text += "^FT08,28" & vbCrLf
			text = text + "^A0N,20,16^FDProduct Name: " + Me.txtProductName.Text + "^FS" & vbCrLf
			text += "^FT08,49" & vbCrLf
			text = text + "^A0N,20,17^FDBatch No.: " + Me.txtBatchNo.Text + "^FS" & vbCrLf
			text += "^FT08,110" & vbCrLf
			text = text + "^A0N,20,17^FDStore At: " + Me.txtStorage.Text + "^FS" & vbCrLf
			text += "^FT70,132" & vbCrLf
			text += "^FT08,69" & vbCrLf
			text = text + "^A0N,20,17^FDMfg. Date: " + Me.txtMfgDt.Text + "^FS" & vbCrLf
			text += "^FT08,90" & vbCrLf
			text = text + "^A0N,20,17^FDExp. Date: " + Me.txtExpDt.Text + "^FS" & vbCrLf
			text += "^FT80,135" & vbCrLf
			text = String.Concat(New String() { text, "^A0N,20,17^FDVol.: ", Strings.Format(Conversion.Val(Me.txtPrimaryPackSize.Text), "#0.###"), Me.txtMeasurement.Text, "^FS" & vbCrLf })
			text = text + "^PQ" + Me.cmbCopies.Text + ",0,1,Y" & vbCrLf
			Return text + "^XZ" & vbCrLf
		End Function

		' Token: 0x0600148C RID: 5260 RVA: 0x000BD6B4 File Offset: 0x000BB8B4
		Private Function SendDataToPrinter(sPrinterIP As String, sPrinterPort As String, sPrintData As String) As Integer
			Dim socket As Socket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
			Dim num As Integer
			Try
				Dim bytes As Byte() = Encoding.ASCII.GetBytes(sPrintData.Trim())
				socket.Connect(sPrinterIP.Trim(), Conversions.ToInteger(sPrinterPort.Trim()))
				Dim socketError As SocketError
				socket.Send(bytes, 0, bytes.Length, SocketFlags.None, socketError)
				socket.Disconnect(False)
				socket.Close()
				num = 1
			Catch ex As Exception
				MessageBox.Show("Error " + ex.Message.ToString(), "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				socket.Disconnect(False)
				socket.Close()
				num = 0
			End Try
			Return num
		End Function

		' Token: 0x040008BB RID: 2235
		Private sFormType As String

		' Token: 0x040008BC RID: 2236
		Private drData As DataRow

		' Token: 0x040008BD RID: 2237
		Private dtItems As DataTable

		' Token: 0x040008BE RID: 2238
		Private dtParent As DataTable

		' Token: 0x040008BF RID: 2239
		Private dtBarcodes As DataTable

		' Token: 0x040008C0 RID: 2240
		Private dtBarcodeTemp As DataTable

		' Token: 0x040008C1 RID: 2241
		Private dtPrinter As DataTable
	End Class
End Namespace
