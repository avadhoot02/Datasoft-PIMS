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
	' Token: 0x02000061 RID: 97
	<DesignerGenerated()>
	Public Partial Class GRNItems
		Inherits Form

		' Token: 0x170008B9 RID: 2233
		' (get) Token: 0x060016B0 RID: 5808 RVA: 0x000D1BF8 File Offset: 0x000CFDF8
		' (set) Token: 0x060016B1 RID: 5809 RVA: 0x000D1C02 File Offset: 0x000CFE02
		Friend Overridable Property pnlBorder As Panel

		' Token: 0x170008BA RID: 2234
		' (get) Token: 0x060016B2 RID: 5810 RVA: 0x000D1C0B File Offset: 0x000CFE0B
		' (set) Token: 0x060016B3 RID: 5811 RVA: 0x000D1C15 File Offset: 0x000CFE15
		Friend Overridable Property pnlMain As Panel

		' Token: 0x170008BB RID: 2235
		' (get) Token: 0x060016B4 RID: 5812 RVA: 0x000D1C1E File Offset: 0x000CFE1E
		' (set) Token: 0x060016B5 RID: 5813 RVA: 0x000D1C28 File Offset: 0x000CFE28
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

		' Token: 0x170008BC RID: 2236
		' (get) Token: 0x060016B6 RID: 5814 RVA: 0x000D1C6B File Offset: 0x000CFE6B
		' (set) Token: 0x060016B7 RID: 5815 RVA: 0x000D1C75 File Offset: 0x000CFE75
		Friend Overridable Property picFormIcon As PictureBox

		' Token: 0x170008BD RID: 2237
		' (get) Token: 0x060016B8 RID: 5816 RVA: 0x000D1C7E File Offset: 0x000CFE7E
		' (set) Token: 0x060016B9 RID: 5817 RVA: 0x000D1C88 File Offset: 0x000CFE88
		Friend Overridable Property lblCaption As Label

		' Token: 0x170008BE RID: 2238
		' (get) Token: 0x060016BA RID: 5818 RVA: 0x000D1C91 File Offset: 0x000CFE91
		' (set) Token: 0x060016BB RID: 5819 RVA: 0x000D1C9C File Offset: 0x000CFE9C
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

		' Token: 0x170008BF RID: 2239
		' (get) Token: 0x060016BC RID: 5820 RVA: 0x000D1CDF File Offset: 0x000CFEDF
		' (set) Token: 0x060016BD RID: 5821 RVA: 0x000D1CE9 File Offset: 0x000CFEE9
		Friend Overridable Property lblShadow1 As Label

		' Token: 0x170008C0 RID: 2240
		' (get) Token: 0x060016BE RID: 5822 RVA: 0x000D1CF2 File Offset: 0x000CFEF2
		' (set) Token: 0x060016BF RID: 5823 RVA: 0x000D1CFC File Offset: 0x000CFEFC
		Friend Overridable Property lblShadow2 As Label

		' Token: 0x170008C1 RID: 2241
		' (get) Token: 0x060016C0 RID: 5824 RVA: 0x000D1D05 File Offset: 0x000CFF05
		' (set) Token: 0x060016C1 RID: 5825 RVA: 0x000D1D0F File Offset: 0x000CFF0F
		Friend Overridable Property Label20 As Label

		' Token: 0x170008C2 RID: 2242
		' (get) Token: 0x060016C2 RID: 5826 RVA: 0x000D1D18 File Offset: 0x000CFF18
		' (set) Token: 0x060016C3 RID: 5827 RVA: 0x000D1D22 File Offset: 0x000CFF22
		Friend Overridable Property txtPrimaryUOM As TextBox

		' Token: 0x170008C3 RID: 2243
		' (get) Token: 0x060016C4 RID: 5828 RVA: 0x000D1D2B File Offset: 0x000CFF2B
		' (set) Token: 0x060016C5 RID: 5829 RVA: 0x000D1D35 File Offset: 0x000CFF35
		Friend Overridable Property Label19 As Label

		' Token: 0x170008C4 RID: 2244
		' (get) Token: 0x060016C6 RID: 5830 RVA: 0x000D1D3E File Offset: 0x000CFF3E
		' (set) Token: 0x060016C7 RID: 5831 RVA: 0x000D1D48 File Offset: 0x000CFF48
		Friend Overridable Property txtProductName As TextBox

		' Token: 0x170008C5 RID: 2245
		' (get) Token: 0x060016C8 RID: 5832 RVA: 0x000D1D51 File Offset: 0x000CFF51
		' (set) Token: 0x060016C9 RID: 5833 RVA: 0x000D1D5B File Offset: 0x000CFF5B
		Friend Overridable Property txtCatalogNo As TextBox

		' Token: 0x170008C6 RID: 2246
		' (get) Token: 0x060016CA RID: 5834 RVA: 0x000D1D64 File Offset: 0x000CFF64
		' (set) Token: 0x060016CB RID: 5835 RVA: 0x000D1D70 File Offset: 0x000CFF70
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

		' Token: 0x170008C7 RID: 2247
		' (get) Token: 0x060016CC RID: 5836 RVA: 0x000D1DB3 File Offset: 0x000CFFB3
		' (set) Token: 0x060016CD RID: 5837 RVA: 0x000D1DBD File Offset: 0x000CFFBD
		Friend Overridable Property Label18 As Label

		' Token: 0x170008C8 RID: 2248
		' (get) Token: 0x060016CE RID: 5838 RVA: 0x000D1DC6 File Offset: 0x000CFFC6
		' (set) Token: 0x060016CF RID: 5839 RVA: 0x000D1DD0 File Offset: 0x000CFFD0
		Friend Overridable Property txtPrimaryPackSize As TextBox

		' Token: 0x170008C9 RID: 2249
		' (get) Token: 0x060016D0 RID: 5840 RVA: 0x000D1DD9 File Offset: 0x000CFFD9
		' (set) Token: 0x060016D1 RID: 5841 RVA: 0x000D1DE3 File Offset: 0x000CFFE3
		Friend Overridable Property Label17 As Label

		' Token: 0x170008CA RID: 2250
		' (get) Token: 0x060016D2 RID: 5842 RVA: 0x000D1DEC File Offset: 0x000CFFEC
		' (set) Token: 0x060016D3 RID: 5843 RVA: 0x000D1DF6 File Offset: 0x000CFFF6
		Friend Overridable Property Label14 As Label

		' Token: 0x170008CB RID: 2251
		' (get) Token: 0x060016D4 RID: 5844 RVA: 0x000D1DFF File Offset: 0x000CFFFF
		' (set) Token: 0x060016D5 RID: 5845 RVA: 0x000D1E09 File Offset: 0x000D0009
		Friend Overridable Property txtTertiaryPackSize As TextBox

		' Token: 0x170008CC RID: 2252
		' (get) Token: 0x060016D6 RID: 5846 RVA: 0x000D1E12 File Offset: 0x000D0012
		' (set) Token: 0x060016D7 RID: 5847 RVA: 0x000D1E1C File Offset: 0x000D001C
		Friend Overridable Property Label3 As Label

		' Token: 0x170008CD RID: 2253
		' (get) Token: 0x060016D8 RID: 5848 RVA: 0x000D1E25 File Offset: 0x000D0025
		' (set) Token: 0x060016D9 RID: 5849 RVA: 0x000D1E2F File Offset: 0x000D002F
		Friend Overridable Property txtTertiaryUOM As TextBox

		' Token: 0x170008CE RID: 2254
		' (get) Token: 0x060016DA RID: 5850 RVA: 0x000D1E38 File Offset: 0x000D0038
		' (set) Token: 0x060016DB RID: 5851 RVA: 0x000D1E42 File Offset: 0x000D0042
		Friend Overridable Property Label1 As Label

		' Token: 0x170008CF RID: 2255
		' (get) Token: 0x060016DC RID: 5852 RVA: 0x000D1E4B File Offset: 0x000D004B
		' (set) Token: 0x060016DD RID: 5853 RVA: 0x000D1E55 File Offset: 0x000D0055
		Friend Overridable Property Label27 As Label

		' Token: 0x170008D0 RID: 2256
		' (get) Token: 0x060016DE RID: 5854 RVA: 0x000D1E5E File Offset: 0x000D005E
		' (set) Token: 0x060016DF RID: 5855 RVA: 0x000D1E68 File Offset: 0x000D0068
		Friend Overridable Property txtHSNSAC As TextBox

		' Token: 0x170008D1 RID: 2257
		' (get) Token: 0x060016E0 RID: 5856 RVA: 0x000D1E71 File Offset: 0x000D0071
		' (set) Token: 0x060016E1 RID: 5857 RVA: 0x000D1E7B File Offset: 0x000D007B
		Friend Overridable Property txtDesc As TextBox

		' Token: 0x170008D2 RID: 2258
		' (get) Token: 0x060016E2 RID: 5858 RVA: 0x000D1E84 File Offset: 0x000D0084
		' (set) Token: 0x060016E3 RID: 5859 RVA: 0x000D1E90 File Offset: 0x000D0090
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

		' Token: 0x170008D3 RID: 2259
		' (get) Token: 0x060016E4 RID: 5860 RVA: 0x000D1ED3 File Offset: 0x000D00D3
		' (set) Token: 0x060016E5 RID: 5861 RVA: 0x000D1EDD File Offset: 0x000D00DD
		Friend Overridable Property Label9 As Label

		' Token: 0x170008D4 RID: 2260
		' (get) Token: 0x060016E6 RID: 5862 RVA: 0x000D1EE6 File Offset: 0x000D00E6
		' (set) Token: 0x060016E7 RID: 5863 RVA: 0x000D1EF0 File Offset: 0x000D00F0
		Friend Overridable Property lblBMRNo As Label

		' Token: 0x170008D5 RID: 2261
		' (get) Token: 0x060016E8 RID: 5864 RVA: 0x000D1EF9 File Offset: 0x000D00F9
		' (set) Token: 0x060016E9 RID: 5865 RVA: 0x000D1F03 File Offset: 0x000D0103
		Friend Overridable Property txtBMRNo As TextBox

		' Token: 0x170008D6 RID: 2262
		' (get) Token: 0x060016EA RID: 5866 RVA: 0x000D1F0C File Offset: 0x000D010C
		' (set) Token: 0x060016EB RID: 5867 RVA: 0x000D1F16 File Offset: 0x000D0116
		Friend Overridable Property txtPrimaryMeasure As TextBox

		' Token: 0x170008D7 RID: 2263
		' (get) Token: 0x060016EC RID: 5868 RVA: 0x000D1F1F File Offset: 0x000D011F
		' (set) Token: 0x060016ED RID: 5869 RVA: 0x000D1F29 File Offset: 0x000D0129
		Friend Overridable Property txtTertiaryMeasure As TextBox

		' Token: 0x170008D8 RID: 2264
		' (get) Token: 0x060016EE RID: 5870 RVA: 0x000D1F32 File Offset: 0x000D0132
		' (set) Token: 0x060016EF RID: 5871 RVA: 0x000D1F3C File Offset: 0x000D013C
		Friend Overridable Property txtSpecificationNo As TextBox

		' Token: 0x170008D9 RID: 2265
		' (get) Token: 0x060016F0 RID: 5872 RVA: 0x000D1F45 File Offset: 0x000D0145
		' (set) Token: 0x060016F1 RID: 5873 RVA: 0x000D1F4F File Offset: 0x000D014F
		Friend Overridable Property Lable5 As Label

		' Token: 0x170008DA RID: 2266
		' (get) Token: 0x060016F2 RID: 5874 RVA: 0x000D1F58 File Offset: 0x000D0158
		' (set) Token: 0x060016F3 RID: 5875 RVA: 0x000D1F62 File Offset: 0x000D0162
		Friend Overridable Property Panel1 As Panel

		' Token: 0x170008DB RID: 2267
		' (get) Token: 0x060016F4 RID: 5876 RVA: 0x000D1F6B File Offset: 0x000D016B
		' (set) Token: 0x060016F5 RID: 5877 RVA: 0x000D1F75 File Offset: 0x000D0175
		Friend Overridable Property pnlGRN As Panel

		' Token: 0x170008DC RID: 2268
		' (get) Token: 0x060016F6 RID: 5878 RVA: 0x000D1F7E File Offset: 0x000D017E
		' (set) Token: 0x060016F7 RID: 5879 RVA: 0x000D1F88 File Offset: 0x000D0188
		Friend Overridable Property txtMeasure3 As TextBox

		' Token: 0x170008DD RID: 2269
		' (get) Token: 0x060016F8 RID: 5880 RVA: 0x000D1F91 File Offset: 0x000D0191
		' (set) Token: 0x060016F9 RID: 5881 RVA: 0x000D1F9B File Offset: 0x000D019B
		Friend Overridable Property Label23 As Label

		' Token: 0x170008DE RID: 2270
		' (get) Token: 0x060016FA RID: 5882 RVA: 0x000D1FA4 File Offset: 0x000D01A4
		' (set) Token: 0x060016FB RID: 5883 RVA: 0x000D1FAE File Offset: 0x000D01AE
		Friend Overridable Property txtQtyMeasure As TextBox

		' Token: 0x170008DF RID: 2271
		' (get) Token: 0x060016FC RID: 5884 RVA: 0x000D1FB7 File Offset: 0x000D01B7
		' (set) Token: 0x060016FD RID: 5885 RVA: 0x000D1FC1 File Offset: 0x000D01C1
		Friend Overridable Property txtNos1 As TextBox

		' Token: 0x170008E0 RID: 2272
		' (get) Token: 0x060016FE RID: 5886 RVA: 0x000D1FCA File Offset: 0x000D01CA
		' (set) Token: 0x060016FF RID: 5887 RVA: 0x000D1FD4 File Offset: 0x000D01D4
		Friend Overridable Property txtNos2 As TextBox

		' Token: 0x170008E1 RID: 2273
		' (get) Token: 0x06001700 RID: 5888 RVA: 0x000D1FDD File Offset: 0x000D01DD
		' (set) Token: 0x06001701 RID: 5889 RVA: 0x000D1FE7 File Offset: 0x000D01E7
		Friend Overridable Property Label22 As Label

		' Token: 0x170008E2 RID: 2274
		' (get) Token: 0x06001702 RID: 5890 RVA: 0x000D1FF0 File Offset: 0x000D01F0
		' (set) Token: 0x06001703 RID: 5891 RVA: 0x000D1FFA File Offset: 0x000D01FA
		Friend Overridable Property txtExpiryType As TextBox

		' Token: 0x170008E3 RID: 2275
		' (get) Token: 0x06001704 RID: 5892 RVA: 0x000D2003 File Offset: 0x000D0203
		' (set) Token: 0x06001705 RID: 5893 RVA: 0x000D2010 File Offset: 0x000D0210
		Friend Overridable Property skip_btnPriQty As Button
			<CompilerGenerated()>
			Get
				Return Me._skip_btnPriQty
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.skip_btnPriQty_Click
				Dim button As Button = Me._skip_btnPriQty
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._skip_btnPriQty = value
				button = Me._skip_btnPriQty
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170008E4 RID: 2276
		' (get) Token: 0x06001706 RID: 5894 RVA: 0x000D2053 File Offset: 0x000D0253
		' (set) Token: 0x06001707 RID: 5895 RVA: 0x000D205D File Offset: 0x000D025D
		Friend Overridable Property txtBatchNo As TextBox

		' Token: 0x170008E5 RID: 2277
		' (get) Token: 0x06001708 RID: 5896 RVA: 0x000D2066 File Offset: 0x000D0266
		' (set) Token: 0x06001709 RID: 5897 RVA: 0x000D2070 File Offset: 0x000D0270
		Friend Overridable Property Label21 As Label

		' Token: 0x170008E6 RID: 2278
		' (get) Token: 0x0600170A RID: 5898 RVA: 0x000D2079 File Offset: 0x000D0279
		' (set) Token: 0x0600170B RID: 5899 RVA: 0x000D2083 File Offset: 0x000D0283
		Friend Overridable Property txtNoOfBarcode As TextBox

		' Token: 0x170008E7 RID: 2279
		' (get) Token: 0x0600170C RID: 5900 RVA: 0x000D208C File Offset: 0x000D028C
		' (set) Token: 0x0600170D RID: 5901 RVA: 0x000D2096 File Offset: 0x000D0296
		Friend Overridable Property Label4 As Label

		' Token: 0x170008E8 RID: 2280
		' (get) Token: 0x0600170E RID: 5902 RVA: 0x000D209F File Offset: 0x000D029F
		' (set) Token: 0x0600170F RID: 5903 RVA: 0x000D20A9 File Offset: 0x000D02A9
		Friend Overridable Property Label15 As Label

		' Token: 0x170008E9 RID: 2281
		' (get) Token: 0x06001710 RID: 5904 RVA: 0x000D20B2 File Offset: 0x000D02B2
		' (set) Token: 0x06001711 RID: 5905 RVA: 0x000D20BC File Offset: 0x000D02BC
		Friend Overridable Property txtPrimaryQty As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtPrimaryQty
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim keyEventHandler As KeyEventHandler = AddressOf Me.txtPrimaryQty_KeyDown
				Dim textBox As TextBox = Me._txtPrimaryQty
				If textBox IsNot Nothing Then
					RemoveHandler textBox.KeyDown, keyEventHandler
				End If
				Me._txtPrimaryQty = value
				textBox = Me._txtPrimaryQty
				If textBox IsNot Nothing Then
					AddHandler textBox.KeyDown, keyEventHandler
				End If
			End Set
		End Property

		' Token: 0x170008EA RID: 2282
		' (get) Token: 0x06001712 RID: 5906 RVA: 0x000D20FF File Offset: 0x000D02FF
		' (set) Token: 0x06001713 RID: 5907 RVA: 0x000D2109 File Offset: 0x000D0309
		Friend Overridable Property txtTotal As TextBox

		' Token: 0x170008EB RID: 2283
		' (get) Token: 0x06001714 RID: 5908 RVA: 0x000D2112 File Offset: 0x000D0312
		' (set) Token: 0x06001715 RID: 5909 RVA: 0x000D211C File Offset: 0x000D031C
		Friend Overridable Property cmbGST As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbGST
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbGST_SelectedIndexChanged
				Dim comboBox As ComboBox = Me._cmbGST
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.SelectedIndexChanged, eventHandler
				End If
				Me._cmbGST = value
				comboBox = Me._cmbGST
				If comboBox IsNot Nothing Then
					AddHandler comboBox.SelectedIndexChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170008EC RID: 2284
		' (get) Token: 0x06001716 RID: 5910 RVA: 0x000D215F File Offset: 0x000D035F
		' (set) Token: 0x06001717 RID: 5911 RVA: 0x000D2169 File Offset: 0x000D0369
		Friend Overridable Property Label6 As Label

		' Token: 0x170008ED RID: 2285
		' (get) Token: 0x06001718 RID: 5912 RVA: 0x000D2172 File Offset: 0x000D0372
		' (set) Token: 0x06001719 RID: 5913 RVA: 0x000D217C File Offset: 0x000D037C
		Friend Overridable Property Label13 As Label

		' Token: 0x170008EE RID: 2286
		' (get) Token: 0x0600171A RID: 5914 RVA: 0x000D2185 File Offset: 0x000D0385
		' (set) Token: 0x0600171B RID: 5915 RVA: 0x000D218F File Offset: 0x000D038F
		Friend Overridable Property Label16 As Label

		' Token: 0x170008EF RID: 2287
		' (get) Token: 0x0600171C RID: 5916 RVA: 0x000D2198 File Offset: 0x000D0398
		' (set) Token: 0x0600171D RID: 5917 RVA: 0x000D21A4 File Offset: 0x000D03A4
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

		' Token: 0x170008F0 RID: 2288
		' (get) Token: 0x0600171E RID: 5918 RVA: 0x000D21E7 File Offset: 0x000D03E7
		' (set) Token: 0x0600171F RID: 5919 RVA: 0x000D21F4 File Offset: 0x000D03F4
		Friend Overridable Property txtLanding As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtLanding
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim eventHandler As EventHandler = AddressOf Me.txtLanding_TextChanged
				Dim textBox As TextBox = Me._txtLanding
				If textBox IsNot Nothing Then
					RemoveHandler textBox.TextChanged, eventHandler
				End If
				Me._txtLanding = value
				textBox = Me._txtLanding
				If textBox IsNot Nothing Then
					AddHandler textBox.TextChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170008F1 RID: 2289
		' (get) Token: 0x06001720 RID: 5920 RVA: 0x000D2237 File Offset: 0x000D0437
		' (set) Token: 0x06001721 RID: 5921 RVA: 0x000D2241 File Offset: 0x000D0441
		Friend Overridable Property Label12 As Label

		' Token: 0x170008F2 RID: 2290
		' (get) Token: 0x06001722 RID: 5922 RVA: 0x000D224A File Offset: 0x000D044A
		' (set) Token: 0x06001723 RID: 5923 RVA: 0x000D2254 File Offset: 0x000D0454
		Friend Overridable Property Label8 As Label

		' Token: 0x170008F3 RID: 2291
		' (get) Token: 0x06001724 RID: 5924 RVA: 0x000D225D File Offset: 0x000D045D
		' (set) Token: 0x06001725 RID: 5925 RVA: 0x000D2267 File Offset: 0x000D0467
		Friend Overridable Property Label5 As Label

		' Token: 0x170008F4 RID: 2292
		' (get) Token: 0x06001726 RID: 5926 RVA: 0x000D2270 File Offset: 0x000D0470
		' (set) Token: 0x06001727 RID: 5927 RVA: 0x000D227A File Offset: 0x000D047A
		Friend Overridable Property txtBasic As TextBox

		' Token: 0x170008F5 RID: 2293
		' (get) Token: 0x06001728 RID: 5928 RVA: 0x000D2283 File Offset: 0x000D0483
		' (set) Token: 0x06001729 RID: 5929 RVA: 0x000D228D File Offset: 0x000D048D
		Friend Overridable Property dtpExpDt As DateTimePicker

		' Token: 0x170008F6 RID: 2294
		' (get) Token: 0x0600172A RID: 5930 RVA: 0x000D2296 File Offset: 0x000D0496
		' (set) Token: 0x0600172B RID: 5931 RVA: 0x000D22A0 File Offset: 0x000D04A0
		Friend Overridable Property Label2 As Label

		' Token: 0x170008F7 RID: 2295
		' (get) Token: 0x0600172C RID: 5932 RVA: 0x000D22A9 File Offset: 0x000D04A9
		' (set) Token: 0x0600172D RID: 5933 RVA: 0x000D22B4 File Offset: 0x000D04B4
		Friend Overridable Property txtUnitPrice As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtUnitPrice
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim eventHandler As EventHandler = AddressOf Me.txtUnitPrice_TextChanged
				Dim textBox As TextBox = Me._txtUnitPrice
				If textBox IsNot Nothing Then
					RemoveHandler textBox.TextChanged, eventHandler
				End If
				Me._txtUnitPrice = value
				textBox = Me._txtUnitPrice
				If textBox IsNot Nothing Then
					AddHandler textBox.TextChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170008F8 RID: 2296
		' (get) Token: 0x0600172E RID: 5934 RVA: 0x000D22F7 File Offset: 0x000D04F7
		' (set) Token: 0x0600172F RID: 5935 RVA: 0x000D2301 File Offset: 0x000D0501
		Friend Overridable Property Label7 As Label

		' Token: 0x170008F9 RID: 2297
		' (get) Token: 0x06001730 RID: 5936 RVA: 0x000D230A File Offset: 0x000D050A
		' (set) Token: 0x06001731 RID: 5937 RVA: 0x000D2314 File Offset: 0x000D0514
		Friend Overridable Property txtGRNQty As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtGRNQty
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim eventHandler As EventHandler = AddressOf Me.txtGRNQty_TextChanged
				Dim keyEventHandler As KeyEventHandler = AddressOf Me.txtGRNQty_KeyDown
				Dim textBox As TextBox = Me._txtGRNQty
				If textBox IsNot Nothing Then
					RemoveHandler textBox.TextChanged, eventHandler
					RemoveHandler textBox.KeyDown, keyEventHandler
				End If
				Me._txtGRNQty = value
				textBox = Me._txtGRNQty
				If textBox IsNot Nothing Then
					AddHandler textBox.TextChanged, eventHandler
					AddHandler textBox.KeyDown, keyEventHandler
				End If
			End Set
		End Property

		' Token: 0x170008FA RID: 2298
		' (get) Token: 0x06001732 RID: 5938 RVA: 0x000D2372 File Offset: 0x000D0572
		' (set) Token: 0x06001733 RID: 5939 RVA: 0x000D237C File Offset: 0x000D057C
		Friend Overridable Property txtExpiry As TextBox

		' Token: 0x170008FB RID: 2299
		' (get) Token: 0x06001734 RID: 5940 RVA: 0x000D2385 File Offset: 0x000D0585
		' (set) Token: 0x06001735 RID: 5941 RVA: 0x000D238F File Offset: 0x000D058F
		Friend Overridable Property pnlCellBank As Panel

		' Token: 0x170008FC RID: 2300
		' (get) Token: 0x06001736 RID: 5942 RVA: 0x000D2398 File Offset: 0x000D0598
		' (set) Token: 0x06001737 RID: 5943 RVA: 0x000D23A2 File Offset: 0x000D05A2
		Friend Overridable Property txtCellCount As TextBox

		' Token: 0x170008FD RID: 2301
		' (get) Token: 0x06001738 RID: 5944 RVA: 0x000D23AB File Offset: 0x000D05AB
		' (set) Token: 0x06001739 RID: 5945 RVA: 0x000D23B5 File Offset: 0x000D05B5
		Friend Overridable Property lblCell As Label

		' Token: 0x170008FE RID: 2302
		' (get) Token: 0x0600173A RID: 5946 RVA: 0x000D23BE File Offset: 0x000D05BE
		' (set) Token: 0x0600173B RID: 5947 RVA: 0x000D23C8 File Offset: 0x000D05C8
		Friend Overridable Property txtPassageNo As TextBox

		' Token: 0x170008FF RID: 2303
		' (get) Token: 0x0600173C RID: 5948 RVA: 0x000D23D1 File Offset: 0x000D05D1
		' (set) Token: 0x0600173D RID: 5949 RVA: 0x000D23DB File Offset: 0x000D05DB
		Friend Overridable Property lblCell1 As Label

		' Token: 0x17000900 RID: 2304
		' (get) Token: 0x0600173E RID: 5950 RVA: 0x000D23E4 File Offset: 0x000D05E4
		' (set) Token: 0x0600173F RID: 5951 RVA: 0x000D23EE File Offset: 0x000D05EE
		Friend Overridable Property pnlPOQty As Panel

		' Token: 0x17000901 RID: 2305
		' (get) Token: 0x06001740 RID: 5952 RVA: 0x000D23F7 File Offset: 0x000D05F7
		' (set) Token: 0x06001741 RID: 5953 RVA: 0x000D2401 File Offset: 0x000D0601
		Friend Overridable Property txtMeasure2 As TextBox

		' Token: 0x17000902 RID: 2306
		' (get) Token: 0x06001742 RID: 5954 RVA: 0x000D240A File Offset: 0x000D060A
		' (set) Token: 0x06001743 RID: 5955 RVA: 0x000D2414 File Offset: 0x000D0614
		Friend Overridable Property txtMeasure1 As TextBox

		' Token: 0x17000903 RID: 2307
		' (get) Token: 0x06001744 RID: 5956 RVA: 0x000D241D File Offset: 0x000D061D
		' (set) Token: 0x06001745 RID: 5957 RVA: 0x000D2427 File Offset: 0x000D0627
		Friend Overridable Property txtPOQty As TextBox

		' Token: 0x17000904 RID: 2308
		' (get) Token: 0x06001746 RID: 5958 RVA: 0x000D2430 File Offset: 0x000D0630
		' (set) Token: 0x06001747 RID: 5959 RVA: 0x000D243A File Offset: 0x000D063A
		Friend Overridable Property Label24 As Label

		' Token: 0x17000905 RID: 2309
		' (get) Token: 0x06001748 RID: 5960 RVA: 0x000D2443 File Offset: 0x000D0643
		' (set) Token: 0x06001749 RID: 5961 RVA: 0x000D244D File Offset: 0x000D064D
		Friend Overridable Property txtBalQty As TextBox

		' Token: 0x17000906 RID: 2310
		' (get) Token: 0x0600174A RID: 5962 RVA: 0x000D2456 File Offset: 0x000D0656
		' (set) Token: 0x0600174B RID: 5963 RVA: 0x000D2460 File Offset: 0x000D0660
		Friend Overridable Property Label25 As Label

		' Token: 0x17000907 RID: 2311
		' (get) Token: 0x0600174C RID: 5964 RVA: 0x000D2469 File Offset: 0x000D0669
		' (set) Token: 0x0600174D RID: 5965 RVA: 0x000D2473 File Offset: 0x000D0673
		Friend Overridable Property chkParent As CheckBox

		' Token: 0x17000908 RID: 2312
		' (get) Token: 0x0600174E RID: 5966 RVA: 0x000D247C File Offset: 0x000D067C
		' (set) Token: 0x0600174F RID: 5967 RVA: 0x000D2486 File Offset: 0x000D0686
		Friend Overridable Property chkQC As CheckBox

		' Token: 0x17000909 RID: 2313
		' (get) Token: 0x06001750 RID: 5968 RVA: 0x000D248F File Offset: 0x000D068F
		' (set) Token: 0x06001751 RID: 5969 RVA: 0x000D2499 File Offset: 0x000D0699
		Friend Overridable Property txtID As TextBox

		' Token: 0x1700090A RID: 2314
		' (get) Token: 0x06001752 RID: 5970 RVA: 0x000D24A2 File Offset: 0x000D06A2
		' (set) Token: 0x06001753 RID: 5971 RVA: 0x000D24AC File Offset: 0x000D06AC
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

		' Token: 0x1700090B RID: 2315
		' (get) Token: 0x06001754 RID: 5972 RVA: 0x000D24EF File Offset: 0x000D06EF
		' (set) Token: 0x06001755 RID: 5973 RVA: 0x000D24FC File Offset: 0x000D06FC
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

		' Token: 0x1700090C RID: 2316
		' (get) Token: 0x06001756 RID: 5974 RVA: 0x000D253F File Offset: 0x000D073F
		' (set) Token: 0x06001757 RID: 5975 RVA: 0x000D254C File Offset: 0x000D074C
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

		' Token: 0x1700090D RID: 2317
		' (get) Token: 0x06001758 RID: 5976 RVA: 0x000D258F File Offset: 0x000D078F
		' (set) Token: 0x06001759 RID: 5977 RVA: 0x000D2599 File Offset: 0x000D0799
		Friend Overridable Property Panel2 As Panel

		' Token: 0x1700090E RID: 2318
		' (get) Token: 0x0600175A RID: 5978 RVA: 0x000D25A2 File Offset: 0x000D07A2
		' (set) Token: 0x0600175B RID: 5979 RVA: 0x000D25AC File Offset: 0x000D07AC
		Friend Overridable Property txtODPermL As TextBox

		' Token: 0x0600175C RID: 5980
		Private Declare Sub SendMessage Lib "user32.DLL" (hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

		' Token: 0x0600175D RID: 5981
		Private Declare Sub ReleaseCapture Lib "user32.DLL" ()

		' Token: 0x0600175E RID: 5982 RVA: 0x000D25B5 File Offset: 0x000D07B5
		Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs)
			GRNItems.ReleaseCapture()
			GRNItems.SendMessage(MyBase.Handle, 274, 61458, 0)
		End Sub

		' Token: 0x0600175F RID: 5983 RVA: 0x000D25D8 File Offset: 0x000D07D8
		Public Sub New(iR As Integer, sForm As String, GRNType As String, GRNID As String, POID As String, dt As DataTable, Status As String)
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.InitializeComponent()
			Designing.SetTheme(Me)
			Me.picFormIcon.Image = ResourceModule.imgFormIconPic
			MyBase.FormBorderStyle = FormBorderStyle.None
			Me.BackColor = Color.DarkGray
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.lblCaption.Text = Me.Text
			Me.form_btnClose.DialogResult = DialogResult.Cancel
			Me.iRow = iR
			Me.sFormType = sForm
			Me.sGRNType = GRNType
			Me.sGRNID = GRNID
			Me.sPOID = POID
			Me.dtItems = dt
			Me.sStatus = Status
		End Sub

		' Token: 0x06001760 RID: 5984 RVA: 0x000D2697 File Offset: 0x000D0897
		Private Sub form_btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06001761 RID: 5985 RVA: 0x000D26A1 File Offset: 0x000D08A1
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Me.ClearForm()
			Me.FillCombo()
			Me.FillData()
			Me.SetForm()
		End Sub

		' Token: 0x06001762 RID: 5986 RVA: 0x000D26C0 File Offset: 0x000D08C0
		Private Sub FillCombo()
			Me.cmbType.Items.Clear()
			Dim text As String = Me.sGRNType
			If Operators.CompareString(text, "Receipt", False) <> 0 AndAlso Operators.CompareString(text, "Return", False) <> 0 Then
				If Operators.CompareString(text, "BMR", False) = 0 Then
					Me.cmbType.Items.Add("")
					Me.cmbType.Items.Add("Finished Goods")
					Me.cmbType.Items.Add("Semi Finished")
					Me.cmbType.Items.Add("Cell Bank - Mammalian")
					Me.cmbType.Items.Add("Cell Bank - Bacterial")
				End If
			Else
				Me.cmbType.Items.Add("")
				Me.cmbType.Items.Add("Raw Material")
				Me.cmbType.Items.Add("Packaging Material")
				Me.cmbType.Items.Add("Consumable")
				Me.cmbType.Items.Add("Others")
			End If
		End Sub

		' Token: 0x06001763 RID: 5987 RVA: 0x000D27FC File Offset: 0x000D09FC
		Private Sub ClearForm()
			Me.cmbProduct.Text = ""
			Me.txtProductName.Text = ""
			Me.cmbProduct.SelectedIndex = -1
			Me.txtDesc.Text = ""
			Me.txtCatalogNo.Text = ""
			Me.txtHSNSAC.Text = ""
			Me.txtSpecificationNo.Text = ""
			Me.txtTertiaryUOM.Text = ""
			Me.txtTertiaryPackSize.Text = ""
			Me.txtPrimaryUOM.Text = ""
			Me.txtPrimaryPackSize.Text = ""
			Me.txtPrimaryMeasure.Text = ""
			Me.txtMeasure1.Text = ""
			Me.txtMeasure2.Text = ""
			Me.txtMeasure3.Text = ""
			Me.txtBMRNo.Text = ""
			Me.txtBatchNo.Text = ""
			Me.dtpMfgDt.Value = DateAndTime.Now
			Me.dtpMfgDt.Checked = False
			Me.txtExpiryType.Text = ""
			Me.txtExpiry.Text = ""
			Me.dtpExpDt.Value = DateAndTime.Now
			Me.dtpExpDt.Checked = False
			Me.txtPOQty.Text = ""
			Me.txtBalQty.Text = ""
			Me.txtGRNQty.Text = ""
			Me.txtNoOfBarcode.Text = ""
			Me.txtUnitPrice.Text = ""
			Me.cmbGST.Text = ""
			Me.txtBasic.Text = ""
			Me.txtLanding.Text = ""
			Me.txtTotal.Text = ""
			Me.txtCellCount.Text = ""
			Me.txtPassageNo.Text = ""
			Me.txtODPermL.Text = ""
			Me.txtDesc.[ReadOnly] = True
			Me.txtPrimaryPackSize.[ReadOnly] = True
			Me.txtBMRNo.[ReadOnly] = True
			Me.txtBatchNo.[ReadOnly] = True
			Me.txtGRNQty.[ReadOnly] = True
			Me.txtPrimaryQty.[ReadOnly] = True
			Me.txtUnitPrice.[ReadOnly] = True
			Me.txtLanding.[ReadOnly] = True
			Me.txtCellCount.[ReadOnly] = True
			Me.txtPassageNo.[ReadOnly] = True
			Me.txtODPermL.[ReadOnly] = True
			Me.dtpMfgDt.Enabled = False
			Me.dtpExpDt.Enabled = False
			Me.cmbGST.Enabled = False
			Me.pnlCellBank.Visible = False
			Me.txtODPermL.Visible = False
			MyBase.Height = 480
		End Sub

		' Token: 0x06001764 RID: 5988 RVA: 0x000D2B2D File Offset: 0x000D0D2D
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.DialogResult = DialogResult.Cancel
			MyBase.Close()
		End Sub

		' Token: 0x06001765 RID: 5989 RVA: 0x000D2B40 File Offset: 0x000D0D40
		Private Sub FillData()
			Dim flag As Boolean = Me.iRow <> -1
			If flag Then
				Me.cmbType.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("ProductType"))
				Me.FillProduct()
				Me.cmbProduct.SelectedValue = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(Me.iRow)("ProductID"))
				Me.FillProductDetails()
				Me.txtDesc.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("Description"))
				Me.txtSpecificationNo.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("SpecificationNo"))
				Me.txtBMRNo.Text = Me.dtItems.Rows(Me.iRow)("BMRNo").ToString()
				Me.txtBatchNo.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("BatchNo"))
				Dim flag2 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(Me.iRow)("MfgDt")))
				If flag2 Then
					Me.dtpMfgDt.Value = Conversions.ToDate(Me.dtItems.Rows(Me.iRow)("MfgDt"))
					Me.dtpMfgDt.Checked = True
				Else
					Me.dtpMfgDt.Value = DateAndTime.Now
					Me.dtpMfgDt.Checked = False
				End If
				Dim flag3 As Boolean = Not Information.IsDBNull(RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(Me.iRow)("ExpDt")))
				If flag3 Then
					Me.dtpExpDt.Value = Conversions.ToDate(Me.dtItems.Rows(Me.iRow)("ExpDt"))
					Me.dtpExpDt.Checked = True
				Else
					Me.dtpExpDt.Value = DateAndTime.Now
					Me.dtpExpDt.Checked = False
				End If
				Me.txtGRNQty.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("ReceivedQty"))
				Me.txtTertiaryPackSize.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("TertiaryPackSize"))
				Me.txtPrimaryPackSize.Text = Me.dtItems.Rows(Me.iRow)("PrimaryPackSize").ToString()
				Me.txtPrimaryQty.Text = Me.dtItems.Rows(Me.iRow)("NoOfBarcode").ToString()
				Me.txtNoOfBarcode.Text = Me.dtItems.Rows(Me.iRow)("NoOfBarcode").ToString()
				Me.txtUnitPrice.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("UnitPrice"))
				Me.cmbGST.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("GSTPer"))
				Me.txtBasic.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("BasicValue"))
				Me.txtLanding.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("LandingCost"))
				Me.txtTotal.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("TotalCost"))
				Me.txtCellCount.Text = Me.dtItems.Rows(Me.iRow)("CellCount").ToString()
				Me.txtPassageNo.Text = Me.dtItems.Rows(Me.iRow)("PassageNo").ToString()
				Me.txtODPermL.Text = Me.dtItems.Rows(Me.iRow)("ODPermL").ToString()
				Me.txtQtyMeasure.Text = Conversions.ToString(Conversion.Val(Me.txtNoOfBarcode.Text) * Conversion.Val(Me.txtPrimaryPackSize.Text))
				Me.chkQC.Checked = Conversions.ToBoolean(Me.dtItems.Rows(Me.iRow)("IsQCApplicable"))
				Me.chkParent.Checked = Conversions.ToBoolean(Me.dtItems.Rows(Me.iRow)("IsParentApplicable"))
			Else
				Me.btnDelete.Enabled = False
			End If
		End Sub

		' Token: 0x06001766 RID: 5990 RVA: 0x000D30DC File Offset: 0x000D12DC
		Private Sub SetForm()
			Dim text As String = Me.sFormType
			If Operators.CompareString(text, "GRN Add", False) <> 0 AndAlso Operators.CompareString(text, "GRN Modify", False) <> 0 Then
				If Operators.CompareString(text, "GRN Approval", False) = 0 Then
					Me.cmbType.Enabled = False
					Me.cmbProduct.Enabled = False
					Me.txtDesc.[ReadOnly] = True
					Me.txtPrimaryPackSize.[ReadOnly] = True
					Me.txtBMRNo.[ReadOnly] = True
					Me.txtBatchNo.[ReadOnly] = True
					Me.txtGRNQty.[ReadOnly] = True
					Me.txtUnitPrice.[ReadOnly] = True
					Me.txtLanding.[ReadOnly] = True
					Me.txtCellCount.[ReadOnly] = True
					Me.txtPassageNo.[ReadOnly] = True
					Me.txtODPermL.[ReadOnly] = True
					Me.dtpMfgDt.Enabled = False
					Me.dtpExpDt.Enabled = False
					Me.cmbGST.Enabled = False
					Me.btnSave.Enabled = False
					Me.btnDelete.Enabled = False
				End If
			End If
			Dim text2 As String = Me.sStatus
			Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(text2)
			If num <= 2520676637UI Then
				If num <= 877785756UI Then
					If num <> 253436212UI Then
						If num = 877785756UI Then
							If Operators.CompareString(text2, "New GRN", False) <> 0 Then
							End If
						End If
					ElseIf Operators.CompareString(text2, "GRN In Approval", False) <> 0 Then
					End If
				ElseIf num <> 2405254160UI Then
					If num = 2520676637UI Then
						If Operators.CompareString(text2, "GRN Approved", False) = 0 Then
							GoTo IL_0249
						End If
					End If
				ElseIf Operators.CompareString(text2, "GRN Rejected", False) = 0 Then
					GoTo IL_0249
				End If
			ElseIf num <= 2787838396UI Then
				If num <> 2730242907UI Then
					If num = 2787838396UI Then
						If Operators.CompareString(text2, "Cancelled", False) = 0 Then
							GoTo IL_0249
						End If
					End If
				ElseIf Operators.CompareString(text2, "GRN On-Hold", False) <> 0 Then
				End If
			ElseIf num <> 2975576722UI Then
				If num = 3979088660UI Then
					If Operators.CompareString(text2, "QC Complete", False) = 0 Then
						GoTo IL_0249
					End If
				End If
			ElseIf Operators.CompareString(text2, "QC Saved", False) = 0 Then
				GoTo IL_0249
			End If
			GoTo IL_0336
			IL_0249:
			Me.cmbType.Enabled = False
			Me.cmbProduct.Enabled = False
			Me.txtDesc.[ReadOnly] = True
			Me.txtPrimaryPackSize.[ReadOnly] = True
			Me.txtBMRNo.[ReadOnly] = True
			Me.txtBatchNo.[ReadOnly] = True
			Me.txtGRNQty.[ReadOnly] = True
			Me.txtUnitPrice.[ReadOnly] = True
			Me.txtLanding.[ReadOnly] = True
			Me.txtCellCount.[ReadOnly] = True
			Me.txtPassageNo.[ReadOnly] = True
			Me.txtODPermL.[ReadOnly] = True
			Me.dtpMfgDt.Enabled = False
			Me.dtpExpDt.Enabled = False
			Me.cmbGST.Enabled = False
			Me.skip_btnPriQty.Enabled = False
			Me.btnSave.Enabled = False
			Me.btnDelete.Enabled = False
			IL_0336:
			Dim flag As Boolean = Operators.CompareString(Me.sPOID, "", False) = 0
			If flag Then
				Me.pnlPOQty.Visible = False
			Else
				Me.pnlPOQty.Visible = True
			End If
			MyBase.AcceptButton = Nothing
			Dim text3 As String = Me.sGRNType
			If Operators.CompareString(text3, "Receipt", False) <> 0 Then
				If Operators.CompareString(text3, "BMR", False) <> 0 Then
					If Operators.CompareString(text3, "Return", False) = 0 Then
						Me.skip_btnPriQty.Visible = True
						Me.txtPrimaryQty.Width = 110
					End If
				Else
					Me.lblBMRNo.Visible = True
					Me.txtBMRNo.Visible = True
					Me.txtHSNSAC.Width = 178
				End If
			Else
				Me.pnlCellBank.Visible = False
				Me.lblBMRNo.Visible = False
				Me.txtBMRNo.Visible = False
				Me.txtHSNSAC.Width = 503
				Dim flag2 As Boolean = Operators.CompareString(Me.sPOID, "", False) = 0
				If flag2 Then
					MyBase.Height = 480
				Else
					MyBase.Height = 500
				End If
			End If
			AddHandler Me.txtPrimaryPackSize.KeyDown, AddressOf Me.Keydown_Numeric
		End Sub

		' Token: 0x06001767 RID: 5991 RVA: 0x000D3578 File Offset: 0x000D1778
		Private Sub Keydown_Numeric(sender As Object, e As KeyEventArgs)
			Dim keyCode As Keys = e.KeyCode
			Dim flag As Boolean = (keyCode >= Keys.D0 AndAlso keyCode <= Keys.D9) OrElse (keyCode >= Keys.NumPad0 AndAlso keyCode <= Keys.NumPad9) OrElse keyCode = Keys.Back OrElse keyCode = Keys.Left OrElse keyCode = Keys.Right
			If Not flag Then
				e.SuppressKeyPress = True
			End If
		End Sub

		' Token: 0x06001768 RID: 5992 RVA: 0x000D35C4 File Offset: 0x000D17C4
		Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.sGRNType, "Return", False) <> 0
			If flag Then
				Dim text As String = Me.cmbType.Text
				If Operators.CompareString(text, "Consumable", False) <> 0 Then
					If Operators.CompareString(text, "Cell Bank - Mammalian", False) <> 0 Then
						If Operators.CompareString(text, "Cell Bank - Bacterial", False) <> 0 Then
							Me.pnlCellBank.Visible = False
							Me.skip_btnPriQty.Visible = False
							Me.txtPrimaryQty.Width = 111
							Dim flag2 As Boolean = Operators.CompareString(Me.sPOID, "", False) = 0
							If flag2 Then
								MyBase.Height = 480
							Else
								MyBase.Height = 500
							End If
						Else
							MyBase.Height = 500
							Me.pnlCellBank.Visible = True
							Me.skip_btnPriQty.Visible = False
							Me.txtPrimaryQty.Width = 111
							Me.lblCell.Text = "OD/ mL"
							Me.lblCell1.Visible = False
							Me.txtCellCount.Visible = False
							Me.txtPassageNo.Visible = False
							Me.txtODPermL.Visible = True
						End If
					Else
						MyBase.Height = 500
						Me.pnlCellBank.Visible = True
						Me.skip_btnPriQty.Visible = False
						Me.txtPrimaryQty.Width = 111
						Me.lblCell.Text = "Cell Count"
						Me.lblCell1.Visible = True
						Me.txtCellCount.Visible = True
						Me.txtPassageNo.Visible = True
						Me.txtODPermL.Visible = False
					End If
				Else
					Me.pnlCellBank.Visible = False
					Me.skip_btnPriQty.Visible = True
					Me.txtPrimaryQty.Width = 110
					Dim flag3 As Boolean = Operators.CompareString(Me.sPOID, "", False) = 0
					If flag3 Then
						MyBase.Height = 480
					Else
						MyBase.Height = 500
					End If
				End If
			End If
			Dim flag4 As Boolean = Operators.CompareString(Me.cmbType.Text, "", False) <> 0
			If flag4 Then
				Me.FillProduct()
			Else
				Me.cmbProduct.DataSource = Nothing
			End If
			Me.ClearForm()
		End Sub

		' Token: 0x06001769 RID: 5993 RVA: 0x000D382C File Offset: 0x000D1A2C
		Private Sub FillProduct()
			Dim text As String = " SELECT ProductID, ProductCode, ProductName, ProductType, SpecificationNo, Reference, " & vbCrLf
			text += " CatalogNo, HSNSACCode, ExpiryType, Expiry, UnitPrice, GSTPer, StorageCondition, " & vbCrLf
			text += " TertiaryUOM, TertiaryPackSize, PrimaryUOM, PrimaryPackSize, Measurement, " & vbCrLf
			text += " IsActive, IsGRNApplicable, IsQCApplicable, IsParentApplicable, IsUnitsEditable" & vbCrLf
			text += " FROM Product" & vbCrLf
			text = text + " WHERE Status = 'Approved' AND ProductType IN ('" + Me.cmbType.Text + "') AND IsGRNApplicable = 1" & vbCrLf
			text += " AND TertiaryPackSize > 0 " & vbCrLf
			Dim flag As Boolean = Me.iRow <> -1
			If flag Then
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" AND (IsActive = 1 OR ProductID = '", Me.dtItems.Rows(Me.iRow)("ProductID")), "') "), vbCrLf)))
			Else
				text += " AND IsActive = 1" & vbCrLf
			End If
			Dim flag2 As Boolean = Operators.CompareString(Me.sPOID, "", False) <> 0
			If flag2 Then
				text = text + " AND ProductID IN (SELECT ProductID FROM POItems WHERE POID = '" + Me.sPOID + "')"
			End If
			text += " ORDER BY ProductCode" & vbCrLf
			Me.dtProduct = MainModule.GetData(text)
			Me.cmbProduct.ValueMember = "ProductID"
			Me.cmbProduct.DisplayMember = "ProductCode"
			Me.cmbProduct.DataSource = Me.dtProduct
			Me.cmbProduct.SelectedIndex = -1
			Dim flag3 As Boolean = Operators.CompareString(Me.sPOID, "", False) <> 0
			If flag3 Then
				text = " SELECT PI.POID, PI.ProductID, PI.UnitPrice, PI.TaxPer, PI.Description, " & vbCrLf
				text += " PI.Quantity, ISNULL(GI.ReceivedQty, 0) AS ReceivedQty" & vbCrLf
				text += " FROM POItems PI" & vbCrLf
				text += " LEFT JOIN " & vbCrLf
				text += " (SELECT GI.POID, GI.ProductID, SUM(GI.ReceivedQty) AS ReceivedQty" & vbCrLf
				text += "  FROM GRNItems GI INNER JOIN GRN G ON G.GRNID = GI.GRNID" & vbCrLf
				text = String.Concat(New String() { text, "  WHERE GI.POID = '", Me.sPOID, "' AND GI.GRNID <> '", Me.sGRNID, "' " & vbCrLf })
				text += "  AND G.Status NOT IN ('GRN Rejected','GRN Cancelled')" & vbCrLf
				text += "  GROUP BY GI.POID, GI.ProductID ) GI" & vbCrLf
				text += " ON GI.POID = PI.POID AND GI.ProductID = PI.ProductID" & vbCrLf
				text = text + " WHERE PI.POID = '" + Me.sPOID + "'" & vbCrLf
				Me.dtPO = MainModule.GetData(text)
			End If
		End Sub

		' Token: 0x0600176A RID: 5994 RVA: 0x000D3A70 File Offset: 0x000D1C70
		Private Sub cmbProduct_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbProduct.SelectedIndex > -1
			If flag Then
				Me.FillProductDetails()
				Me.txtGRNQty.Text = ""
				Me.txtPrimaryQty.Text = ""
				Me.txtBasic.Text = ""
			Else
				Me.cmbProduct.Text = ""
				Me.ClearForm()
			End If
		End Sub

		' Token: 0x0600176B RID: 5995 RVA: 0x000D3AE8 File Offset: 0x000D1CE8
		Private Sub FillProductDetails()
			Try
				Dim flag As Boolean = Me.cmbProduct.SelectedIndex > -1
				If flag Then
					Dim dataRow As DataRow = Me.dtProduct.[Select]("ProductID = '" + Me.cmbProduct.SelectedValue.ToString() + "'")(0)
					Me.txtProductName.Text = Conversions.ToString(dataRow("ProductName"))
					Me.txtCatalogNo.Text = Conversions.ToString(dataRow("CatalogNo"))
					Me.txtHSNSAC.Text = Conversions.ToString(dataRow("HSNSACCode"))
					Me.txtSpecificationNo.Text = Conversions.ToString(dataRow("SpecificationNo"))
					Me.txtExpiryType.Text = dataRow("ExpiryType").ToString()
					Me.txtExpiry.Text = Conversions.ToString(dataRow("Expiry"))
					Me.txtTertiaryUOM.Text = Conversions.ToString(dataRow("TertiaryUOM"))
					Me.txtTertiaryPackSize.Text = Conversions.ToString(dataRow("TertiaryPackSize"))
					Me.txtPrimaryUOM.Text = Conversions.ToString(dataRow("PrimaryUOM"))
					Me.txtPrimaryPackSize.Text = Conversions.ToString(dataRow("PrimaryPackSize"))
					Me.txtPrimaryMeasure.Text = dataRow("Measurement").ToString()
					Me.txtMeasure1.Text = dataRow("Measurement").ToString()
					Me.txtMeasure2.Text = dataRow("Measurement").ToString()
					Me.txtMeasure3.Text = dataRow("Measurement").ToString()
					Me.txtUnitPrice.Text = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("UnitPrice"))) * Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("PrimaryPackSize"))))
					Me.cmbGST.Text = Conversions.ToString(dataRow("GSTPer"))
					Me.chkQC.Checked = Conversions.ToBoolean(dataRow("IsQCApplicable"))
					Me.chkParent.Checked = Conversions.ToBoolean(dataRow("IsParentApplicable"))
					Dim flag2 As Boolean = (Operators.CompareString(Me.sPOID, "", False) <> 0) And Not Information.IsNothing(Me.dtPO)
					If flag2 Then
						Dim array As DataRow() = Me.dtPO.[Select]("ProductID = '" + Me.cmbProduct.SelectedValue.ToString() + "'")
						Dim flag3 As Boolean = array.Length > 0
						If flag3 Then
							Me.txtPOQty.Text = Conversions.ToString(array(0)("Quantity"))
							Me.txtDesc.Text = Conversions.ToString(array(0)("Description"))
							Me.txtUnitPrice.Text = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(array(0)("UnitPrice"))) * Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("PrimaryPackSize"))))
							Me.cmbGST.Text = Conversions.ToString(array(0)("TaxPer"))
							Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.dtItems.Compute("SUM(ReceivedQty)", String.Concat(New String() { "ProductID = '", Me.cmbProduct.SelectedValue.ToString(), "' AND SrNo <> '", Conversions.ToString(Me.iRow + 1), "'" })))
							Me.txtBalQty.Text = Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(array(0)("Quantity"))) - Conversion.Val(RuntimeHelpers.GetObjectValue(array(0)("ReceivedQty"))) - Conversion.Val(objectValue.ToString()) * Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("PrimaryPackSize"))) * Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow("TertiaryPackSize"))))
						End If
					End If
					Dim text As String = Me.cmbType.Text
					If Operators.CompareString(text, "Finished Goods", False) <> 0 AndAlso Operators.CompareString(text, "Semi Finished", False) <> 0 AndAlso Operators.CompareString(text, "Cell Bank - Mammalian", False) <> 0 AndAlso Operators.CompareString(text, "Cell Bank - Bacterial", False) <> 0 Then
						Me.txtPrimaryPackSize.[ReadOnly] = True
					Else
						Me.txtPrimaryPackSize.[ReadOnly] = False
					End If
					Me.txtDesc.[ReadOnly] = False
					Me.txtBMRNo.[ReadOnly] = False
					Me.txtBatchNo.[ReadOnly] = False
					Me.txtGRNQty.[ReadOnly] = False
					Me.txtUnitPrice.[ReadOnly] = False
					Me.txtLanding.[ReadOnly] = False
					Me.txtCellCount.[ReadOnly] = False
					Me.txtPassageNo.[ReadOnly] = False
					Me.txtODPermL.[ReadOnly] = False
					Me.cmbGST.Enabled = True
					Me.dtpMfgDt.Checked = False
					Me.dtpExpDt.Checked = False
					Me.dtpMfgDt.Enabled = True
					Me.dtpExpDt.Enabled = True
					Dim text2 As String = Me.txtExpiryType.Text
					If Operators.CompareString(text2, "NA", False) <> 0 Then
						If Operators.CompareString(text2, "Expiry Date", False) <> 0 Then
							If Operators.CompareString(text2, "When Delivered", False) <> 0 Then
								If Operators.CompareString(text2, "When Opened", False) = 0 Then
									Me.dtpMfgDt.Enabled = False
									Me.dtpExpDt.Enabled = False
								End If
							Else
								Me.dtpMfgDt.Enabled = False
								Dim flag4 As Boolean = Conversion.Val(Me.txtExpiry.Text) > 0.0
								If flag4 Then
									Me.dtpExpDt.Value = DateAndTime.DateAdd(DateInterval.Day, -1.0, DateAndTime.DateAdd(DateInterval.Month, Conversion.Val(Me.txtExpiry.Text), DateAndTime.Now))
									Me.dtpExpDt.Enabled = False
								Else
									Me.dtpExpDt.Enabled = True
								End If
							End If
						End If
					Else
						Me.dtpMfgDt.Enabled = False
						Me.dtpExpDt.Enabled = False
					End If
				Else
					Me.txtDesc.[ReadOnly] = True
					Me.txtPrimaryPackSize.[ReadOnly] = True
					Me.txtBMRNo.[ReadOnly] = True
					Me.txtBatchNo.[ReadOnly] = True
					Me.txtGRNQty.[ReadOnly] = True
					Me.txtUnitPrice.[ReadOnly] = True
					Me.txtLanding.[ReadOnly] = True
					Me.txtCellCount.[ReadOnly] = True
					Me.txtPassageNo.[ReadOnly] = True
					Me.txtODPermL.[ReadOnly] = True
					Me.cmbGST.Enabled = False
					Me.dtpMfgDt.Checked = False
					Me.dtpExpDt.Checked = False
					Me.dtpMfgDt.Enabled = False
					Me.dtpExpDt.Enabled = False
				End If
			Catch ex As Exception
				Dim flag5 As Boolean = Strings.InStr(ex.Message.ToString(), "'DBNull'", CompareMethod.Binary) > 0
				Dim text3 As String
				If flag5 Then
					text3 = "Error : Incorrect Product Master Data." & vbCrLf + ex.Message
				Else
					text3 = "Error : " + ex.Message
				End If
				CustomMsgBox.Show(text3, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnSave.Enabled = False
			End Try
		End Sub

		' Token: 0x0600176C RID: 5996 RVA: 0x000D42D4 File Offset: 0x000D24D4
		Private Sub dtpMfgDt_ValueChanged(sender As Object, e As EventArgs)
			Dim checked As Boolean = Me.dtpMfgDt.Checked
			If checked Then
				Dim flag As Boolean = Conversion.Val(Me.txtExpiry.Text) > 0.0
				If flag Then
					Me.dtpExpDt.Value = DateAndTime.DateAdd(DateInterval.Day, -1.0, DateAndTime.DateAdd(DateInterval.Month, Conversion.Val(Me.txtExpiry.Text), Me.dtpMfgDt.Value))
				End If
			Else
				Me.dtpExpDt.Value = DateAndTime.Now
				Me.dtpExpDt.Checked = False
			End If
		End Sub

		' Token: 0x0600176D RID: 5997 RVA: 0x000D4374 File Offset: 0x000D2574
		Private Sub txtGRNQty_TextChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Conversion.Val(Me.txtGRNQty.Text) = 0.0
			If flag Then
				Me.txtNoOfBarcode.Text = ""
				Me.txtPrimaryQty.Text = ""
				Me.txtQtyMeasure.Text = ""
			End If
		End Sub

		' Token: 0x0600176E RID: 5998 RVA: 0x000D43D8 File Offset: 0x000D25D8
		Private Sub txtGRNQty_KeyDown(sender As Object, e As KeyEventArgs)
			Dim keyValue As Integer = e.KeyValue
			Dim flag As Boolean = (keyValue >= 48 AndAlso keyValue <= 57) OrElse (keyValue >= 96 AndAlso keyValue <= 105) OrElse keyValue = 8
			If Not flag Then
				flag = keyValue = 13
				If flag Then
					Dim flag2 As Boolean = Operators.CompareString(Me.txtBalQty.Text, "", False) <> 0
					If flag2 Then
						Dim flag3 As Boolean = Conversion.Val(Me.txtGRNQty.Text) > Conversion.Val(Me.txtBalQty.Text)
						If flag3 Then
							CustomMsgBox.Show("GRN Quantity Cannot Be More Than Balance Quantity.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.txtGRNQty.Focus()
							Return
						End If
					End If
					Dim flag4 As Boolean = (Conversion.Val(Me.txtGRNQty.Text) > 0.0) And (Conversion.Val(Me.txtTertiaryPackSize.Text) > 0.0)
					If flag4 Then
						Me.txtNoOfBarcode.Text = Conversions.ToString(Conversion.Val(Me.txtGRNQty.Text) * Conversion.Val(Me.txtTertiaryPackSize.Text))
						Me.txtPrimaryQty.Text = Me.txtNoOfBarcode.Text
						Me.txtQtyMeasure.Text = Conversions.ToString(Conversion.Val(Me.txtNoOfBarcode.Text) * Conversion.Val(Me.txtPrimaryPackSize.Text))
						Me.CalculateCost()
					Else
						Me.txtNoOfBarcode.Text = ""
						Me.txtPrimaryQty.Text = ""
						Me.txtQtyMeasure.Text = ""
					End If
					Me.txtPrimaryQty.[ReadOnly] = True
				Else
					e.SuppressKeyPress = True
				End If
			End If
		End Sub

		' Token: 0x0600176F RID: 5999 RVA: 0x000D459C File Offset: 0x000D279C
		Private Sub skip_btnPriQty_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbProduct.SelectedIndex > -1
			If flag Then
				Me.txtPrimaryQty.[ReadOnly] = False
				Me.txtPrimaryQty.Focus()
			End If
		End Sub

		' Token: 0x06001770 RID: 6000 RVA: 0x000D45D8 File Offset: 0x000D27D8
		Private Sub txtPrimaryQty_KeyDown(sender As Object, e As KeyEventArgs)
			Dim keyValue As Integer = e.KeyValue
			Dim flag As Boolean = (keyValue >= 48 AndAlso keyValue <= 57) OrElse (keyValue >= 96 AndAlso keyValue <= 105) OrElse keyValue = 8
			If Not flag Then
				flag = keyValue = 13
				If flag Then
					Dim num As Double = Math.Ceiling(Conversion.Val(Me.txtPrimaryQty.Text) / Conversion.Val(Me.txtTertiaryPackSize.Text))
					Dim flag2 As Boolean = Strings.InStr(num.ToString(), ".", CompareMethod.Binary) > 0
					If flag2 Then
						CustomMsgBox.Show("Invalid Primary Quantity", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.txtGRNQty.Text = ""
					Else
						Me.txtGRNQty.Text = Conversions.ToString(num)
					End If
					Me.txtNoOfBarcode.Text = Conversions.ToString(Conversion.Val(Me.txtPrimaryQty.Text))
					Me.txtQtyMeasure.Text = Conversions.ToString(Conversion.Val(Me.txtNoOfBarcode.Text) * Conversion.Val(Me.txtPrimaryPackSize.Text))
					Me.CalculateCost()
				Else
					e.SuppressKeyPress = True
				End If
			End If
		End Sub

		' Token: 0x06001771 RID: 6001 RVA: 0x000D4700 File Offset: 0x000D2900
		Private Sub txtUnitPrice_TextChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.txtUnitPrice.Text), "", False) <> 0
			If flag Then
				Dim flag2 As Boolean = Versioned.IsNumeric(Me.txtUnitPrice.Text)
				If flag2 Then
					Me.CalculateCost()
				Else
					Me.txtUnitPrice.Text = ""
				End If
			End If
		End Sub

		' Token: 0x06001772 RID: 6002 RVA: 0x000D4763 File Offset: 0x000D2963
		Private Sub cmbGST_SelectedIndexChanged(sender As Object, e As EventArgs)
			Me.CalculateCost()
		End Sub

		' Token: 0x06001773 RID: 6003 RVA: 0x000D4770 File Offset: 0x000D2970
		Private Sub txtLanding_TextChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.txtLanding.Text), "", False) <> 0
			If flag Then
				Dim flag2 As Boolean = Versioned.IsNumeric(Me.txtLanding.Text)
				If flag2 Then
					Me.CalculateCost()
				Else
					Me.txtLanding.Text = ""
				End If
			End If
		End Sub

		' Token: 0x06001774 RID: 6004 RVA: 0x000D47D4 File Offset: 0x000D29D4
		Private Sub CalculateCost()
			Dim flag As Boolean = (Conversion.Val(Me.txtGRNQty.Text) > 0.0) And (Conversion.Val(Me.txtUnitPrice.Text) > 0.0) And (Operators.CompareString(Me.cmbGST.Text, "", False) <> 0)
			If flag Then
				Dim num As Double = Conversion.Val(Me.txtNoOfBarcode.Text) * (Conversion.Val(Me.txtUnitPrice.Text) * (1.0 + Conversions.ToDouble(Strings.Replace(Me.cmbGST.Text, " %", "", 1, -1, CompareMethod.Binary)) / 100.0))
				Dim num2 As Double = num + Conversion.Val(Me.txtLanding.Text)
				Me.txtBasic.Text = Strings.Format(num, "#00.00")
				Me.txtTotal.Text = Strings.Format(num2, "#00.00")
			Else
				Me.txtBasic.Text = Conversions.ToString(0)
				Me.txtTotal.Text = Conversions.ToString(0)
			End If
		End Sub

		' Token: 0x06001775 RID: 6005 RVA: 0x000D4908 File Offset: 0x000D2B08
		Private Sub btnDelete_Click(sender As Object, e As EventArgs)
			Try
				Me.DeleteItem()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06001776 RID: 6006 RVA: 0x000D4960 File Offset: 0x000D2B60
		Private Sub DeleteItem()
			Dim flag As Boolean = CustomMsgBox.Show("Delete GRN Item..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes
			If flag Then
				Me.dtItems.Rows.RemoveAt(Me.iRow)
				Me.dtItems.AcceptChanges()
				MyBase.DialogResult = DialogResult.OK
				MyBase.Close()
			End If
		End Sub

		' Token: 0x06001777 RID: 6007 RVA: 0x000D49BC File Offset: 0x000D2BBC
		Private Function ValidateForm() As Boolean
			Dim flag As Boolean = Me.cmbProduct.SelectedIndex = -1
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Select Product.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.cmbProduct.Focus()
				flag2 = False
			Else
				Dim flag3 As Boolean = Operators.CompareString(Me.sGRNType, "BMR", False) = 0
				If flag3 Then
					Dim text As String = Me.cmbType.Text
					If Operators.CompareString(text, "Semi Finished", False) = 0 OrElse Operators.CompareString(text, "Cell Bank - Mammalian", False) = 0 OrElse Operators.CompareString(text, "Cell Bank - Bacterial", False) = 0 Then
						Dim flag4 As Boolean = Operators.CompareString(Strings.Trim(Me.txtBMRNo.Text), "", False) = 0
						If flag4 Then
							CustomMsgBox.Show("Enter BMR No.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.txtBMRNo.Focus()
							Return False
						End If
					End If
				End If
				Dim checked As Boolean = Me.chkQC.Checked
				If checked Then
					Dim flag5 As Boolean = Operators.CompareString(Strings.Trim(Me.txtBatchNo.Text), "", False) = 0
					If flag5 Then
						CustomMsgBox.Show("Enter Batch No.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.txtBatchNo.Focus()
						Return False
					End If
				End If
				Dim text2 As String = Me.txtExpiryType.Text
				If Operators.CompareString(text2, "NA", False) <> 0 AndAlso Operators.CompareString(text2, "When Delivered", False) <> 0 AndAlso Operators.CompareString(text2, "When Opened", False) <> 0 Then
					If Operators.CompareString(text2, "Expiry Date", False) = 0 Then
						Dim flag6 As Boolean = Not Me.dtpExpDt.Checked
						If flag6 Then
							CustomMsgBox.Show("Select Expiry Date.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.dtpExpDt.Focus()
							Return False
						End If
						Dim flag7 As Boolean = DateTime.Compare(Me.dtpExpDt.Value, DateAndTime.Now) <= 0
						If flag7 Then
							CustomMsgBox.Show("Invalid Expiry Date.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.dtpExpDt.Focus()
							Return False
						End If
					End If
				End If
				Dim flag8 As Boolean = Not Versioned.IsNumeric(Me.txtGRNQty.Text) Or (Operators.CompareString(Strings.Trim(Me.txtGRNQty.Text), "", False) = 0)
				If flag8 Then
					CustomMsgBox.Show("Received Quantity Should Be Numeric.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.txtGRNQty.Focus()
					flag2 = False
				Else
					Dim flag9 As Boolean = Not Versioned.IsNumeric(Me.txtNoOfBarcode.Text) Or (Operators.CompareString(Strings.Trim(Me.txtNoOfBarcode.Text), "", False) = 0)
					If flag9 Then
						CustomMsgBox.Show("No. Of Barcode Should Be Numeric.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.txtGRNQty.Focus()
						flag2 = False
					Else
						Dim flag10 As Boolean = Operators.CompareString(Strings.Trim(Me.txtUnitPrice.Text), "", False) = 0
						If flag10 Then
							CustomMsgBox.Show("Enter Price.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.txtUnitPrice.Focus()
							flag2 = False
						Else
							Dim flag11 As Boolean = Not Versioned.IsNumeric(Me.txtUnitPrice.Text)
							If flag11 Then
								CustomMsgBox.Show("Invalid Price.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								Me.txtUnitPrice.Focus()
								flag2 = False
							Else
								Dim flag12 As Boolean = Operators.CompareString(Me.cmbGST.Text, "", False) = 0
								If flag12 Then
									CustomMsgBox.Show("Select Tax.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
									Me.cmbGST.Focus()
									flag2 = False
								Else
									Dim flag13 As Boolean = Operators.CompareString(Me.txtBalQty.Text, "", False) <> 0
									If flag13 Then
										Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.dtItems.Compute("SUM(ReceivedQty)", String.Concat(New String() { "ProductID = '", Me.cmbProduct.SelectedValue.ToString(), "' AND SrNo <> '", Conversions.ToString(Me.iRow + 1), "'" })))
										Dim flag14 As Boolean = Conversion.Val(Me.txtBalQty.Text) < Conversion.Val(Me.txtGRNQty.Text) * Conversion.Val(Me.txtTertiaryPackSize.Text) * Conversion.Val(Me.txtPrimaryPackSize.Text)
										If flag14 Then
											CustomMsgBox.Show("Received Quantity Cannot Be Greater Than Balance.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
											Me.txtGRNQty.Focus()
											Return False
										End If
									End If
									Dim flag15 As Boolean = Operators.CompareString(Strings.Trim(Me.txtBatchNo.Text), "", False) <> 0
									Dim text3 As String
									If flag15 Then
										text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("ProductID = '", Me.cmbProduct.SelectedValue), "' AND BatchNo = '"), Strings.Trim(Me.txtBatchNo.Text)), "' "))
										text3 = String.Concat(New String() { text3, " AND PrimaryPackSize = '", Me.txtPrimaryPackSize.Text, "' AND SrNo <> '", Conversions.ToString(Me.iRow + 1), "'" })
									Else
										text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("ProductID = '", Me.cmbProduct.SelectedValue), "' AND PrimaryPackSize = '"), Me.txtPrimaryPackSize.Text), "' AND SrNo <> '"), Me.iRow + 1), "'"))
									End If
									Dim flag16 As Boolean = Me.dtItems.[Select](text3).Length > 0
									If flag16 Then
										CustomMsgBox.Show("Product Already In The List.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
										Me.cmbProduct.Focus()
										flag2 = False
									Else
										Dim flag17 As Boolean = Operators.CompareString(Strings.Trim(Me.txtBMRNo.Text), "", False) <> 0
										If flag17 Then
											Dim flag18 As Boolean = Operators.CompareString(Me.sGRNType, "BMR", False) <> 0
											If flag18 Then
												Dim flag19 As Boolean = Me.dtItems.[Select]("BMRNo = '" + Strings.Trim(Me.txtBMRNo.Text) + "'").Length > 0
												If flag19 Then
													CustomMsgBox.Show("BMR No. Already In The List.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
													Me.txtBMRNo.Focus()
													Return False
												End If
											End If
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

		' Token: 0x06001778 RID: 6008 RVA: 0x000D505C File Offset: 0x000D325C
		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			Try
				Me.Save()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06001779 RID: 6009 RVA: 0x000D50B4 File Offset: 0x000D32B4
		Private Sub Save()
			Dim flag As Boolean = Not Me.ValidateForm()
			If Not flag Then
				Dim flag2 As Boolean = Me.iRow = -1
				If flag2 Then
					Me.iRow = Me.dtItems.Rows.Count
					Me.dtItems.Rows.Add(New Object(-1) {})
				End If
				Me.dtItems.Rows(Me.iRow)("SrNo") = Me.iRow + 1
				Me.dtItems.Rows(Me.iRow)("ProductID") = Me.cmbProduct.SelectedValue.ToString()
				Me.dtItems.Rows(Me.iRow)("ProductType") = Me.cmbType.Text
				Me.dtItems.Rows(Me.iRow)("ProductName") = Me.txtProductName.Text
				Me.dtItems.Rows(Me.iRow)("Description") = Me.txtDesc.Text
				Me.dtItems.Rows(Me.iRow)("CatalogNo") = Me.txtCatalogNo.Text
				Me.dtItems.Rows(Me.iRow)("HSNSACCode") = Me.txtHSNSAC.Text
				Me.dtItems.Rows(Me.iRow)("SpecificationNo") = Me.txtSpecificationNo.Text
				Me.dtItems.Rows(Me.iRow)("BMRNo") = Me.txtBMRNo.Text
				Me.dtItems.Rows(Me.iRow)("BatchNo") = Me.txtBatchNo.Text
				Dim checked As Boolean = Me.dtpMfgDt.Checked
				If checked Then
					Me.dtItems.Rows(Me.iRow)("MfgDt") = Strings.Format(Me.dtpMfgDt.Value, "dd-MMM-yyyy")
				Else
					Me.dtItems.Rows(Me.iRow)("MfgDt") = DBNull.Value
				End If
				Dim checked2 As Boolean = Me.dtpExpDt.Checked
				If checked2 Then
					Me.dtItems.Rows(Me.iRow)("ExpDt") = Strings.Format(Me.dtpExpDt.Value, "dd-MMM-yyyy")
				Else
					Me.dtItems.Rows(Me.iRow)("ExpDt") = DBNull.Value
				End If
				Me.dtItems.Rows(Me.iRow)("TertiaryUOM") = Me.txtTertiaryUOM.Text
				Me.dtItems.Rows(Me.iRow)("TertiaryPackSize") = Me.txtTertiaryPackSize.Text
				Me.dtItems.Rows(Me.iRow)("PrimaryUOM") = Me.txtPrimaryUOM.Text
				Me.dtItems.Rows(Me.iRow)("PrimaryPackSize") = Me.txtPrimaryPackSize.Text
				Me.dtItems.Rows(Me.iRow)("ReceivedQty") = Me.txtGRNQty.Text
				Me.dtItems.Rows(Me.iRow)("NoOfBarcode") = Me.txtNoOfBarcode.Text
				Me.dtItems.Rows(Me.iRow)("UnitPrice") = Strings.Format(Conversion.Val(Me.txtUnitPrice.Text), "#0.00")
				Me.dtItems.Rows(Me.iRow)("GSTPer") = Me.cmbGST.Text
				Me.dtItems.Rows(Me.iRow)("BasicValue") = Me.txtBasic.Text
				Me.dtItems.Rows(Me.iRow)("LandingCost") = Conversion.Val(Me.txtLanding.Text)
				Me.dtItems.Rows(Me.iRow)("TotalCost") = Strings.Format(Conversion.Val(Me.txtTotal.Text), "#0.00")
				Me.dtItems.Rows(Me.iRow)("ExpiryType") = Me.txtExpiryType.Text
				Me.dtItems.Rows(Me.iRow)("Expiry") = Me.txtExpiry.Text
				Me.dtItems.Rows(Me.iRow)("IsQCApplicable") = Convert.ToInt16(Me.chkQC.Checked)
				Me.dtItems.Rows(Me.iRow)("IsParentApplicable") = Convert.ToInt16(Me.chkParent.Checked)
				Me.dtItems.Rows(Me.iRow)("CellCount") = Strings.Trim(Me.txtCellCount.Text)
				Me.dtItems.Rows(Me.iRow)("PassageNo") = Strings.Trim(Me.txtPassageNo.Text)
				Me.dtItems.Rows(Me.iRow)("ODPermL") = Strings.Trim(Me.txtODPermL.Text)
				MyBase.DialogResult = DialogResult.OK
				MyBase.Close()
			End If
		End Sub

		' Token: 0x04000A09 RID: 2569
		Private iRow As Integer

		' Token: 0x04000A0A RID: 2570
		Private sFormType As String

		' Token: 0x04000A0B RID: 2571
		Private sGRNType As String

		' Token: 0x04000A0C RID: 2572
		Private sGRNID As String

		' Token: 0x04000A0D RID: 2573
		Private sPOID As String

		' Token: 0x04000A0E RID: 2574
		Private dtProduct As DataTable

		' Token: 0x04000A0F RID: 2575
		Private dtPO As DataTable

		' Token: 0x04000A10 RID: 2576
		Private sStatus As String

		' Token: 0x04000A11 RID: 2577
		Public dtItems As DataTable
	End Class
End Namespace
