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
	' Token: 0x02000066 RID: 102
	<DesignerGenerated()>
	Public Partial Class POItems
		Inherits Form

		' Token: 0x17000A16 RID: 2582
		' (get) Token: 0x060019F8 RID: 6648 RVA: 0x000F25B1 File Offset: 0x000F07B1
		' (set) Token: 0x060019F9 RID: 6649 RVA: 0x000F25BB File Offset: 0x000F07BB
		Friend Overridable Property pnlBorder As Panel

		' Token: 0x17000A17 RID: 2583
		' (get) Token: 0x060019FA RID: 6650 RVA: 0x000F25C4 File Offset: 0x000F07C4
		' (set) Token: 0x060019FB RID: 6651 RVA: 0x000F25CE File Offset: 0x000F07CE
		Friend Overridable Property pnlMain As Panel

		' Token: 0x17000A18 RID: 2584
		' (get) Token: 0x060019FC RID: 6652 RVA: 0x000F25D7 File Offset: 0x000F07D7
		' (set) Token: 0x060019FD RID: 6653 RVA: 0x000F25E4 File Offset: 0x000F07E4
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

		' Token: 0x17000A19 RID: 2585
		' (get) Token: 0x060019FE RID: 6654 RVA: 0x000F2627 File Offset: 0x000F0827
		' (set) Token: 0x060019FF RID: 6655 RVA: 0x000F2631 File Offset: 0x000F0831
		Friend Overridable Property picFormIcon As PictureBox

		' Token: 0x17000A1A RID: 2586
		' (get) Token: 0x06001A00 RID: 6656 RVA: 0x000F263A File Offset: 0x000F083A
		' (set) Token: 0x06001A01 RID: 6657 RVA: 0x000F2644 File Offset: 0x000F0844
		Friend Overridable Property lblCaption As Label

		' Token: 0x17000A1B RID: 2587
		' (get) Token: 0x06001A02 RID: 6658 RVA: 0x000F264D File Offset: 0x000F084D
		' (set) Token: 0x06001A03 RID: 6659 RVA: 0x000F2658 File Offset: 0x000F0858
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

		' Token: 0x17000A1C RID: 2588
		' (get) Token: 0x06001A04 RID: 6660 RVA: 0x000F269B File Offset: 0x000F089B
		' (set) Token: 0x06001A05 RID: 6661 RVA: 0x000F26A5 File Offset: 0x000F08A5
		Friend Overridable Property lblShadow1 As Label

		' Token: 0x17000A1D RID: 2589
		' (get) Token: 0x06001A06 RID: 6662 RVA: 0x000F26AE File Offset: 0x000F08AE
		' (set) Token: 0x06001A07 RID: 6663 RVA: 0x000F26B8 File Offset: 0x000F08B8
		Friend Overridable Property lblShadow2 As Label

		' Token: 0x17000A1E RID: 2590
		' (get) Token: 0x06001A08 RID: 6664 RVA: 0x000F26C1 File Offset: 0x000F08C1
		' (set) Token: 0x06001A09 RID: 6665 RVA: 0x000F26CC File Offset: 0x000F08CC
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

		' Token: 0x17000A1F RID: 2591
		' (get) Token: 0x06001A0A RID: 6666 RVA: 0x000F270F File Offset: 0x000F090F
		' (set) Token: 0x06001A0B RID: 6667 RVA: 0x000F2719 File Offset: 0x000F0919
		Friend Overridable Property Label9 As Label

		' Token: 0x17000A20 RID: 2592
		' (get) Token: 0x06001A0C RID: 6668 RVA: 0x000F2722 File Offset: 0x000F0922
		' (set) Token: 0x06001A0D RID: 6669 RVA: 0x000F272C File Offset: 0x000F092C
		Friend Overridable Property txtDesc As TextBox

		' Token: 0x17000A21 RID: 2593
		' (get) Token: 0x06001A0E RID: 6670 RVA: 0x000F2735 File Offset: 0x000F0935
		' (set) Token: 0x06001A0F RID: 6671 RVA: 0x000F273F File Offset: 0x000F093F
		Friend Overridable Property Label1 As Label

		' Token: 0x17000A22 RID: 2594
		' (get) Token: 0x06001A10 RID: 6672 RVA: 0x000F2748 File Offset: 0x000F0948
		' (set) Token: 0x06001A11 RID: 6673 RVA: 0x000F2752 File Offset: 0x000F0952
		Friend Overridable Property Label27 As Label

		' Token: 0x17000A23 RID: 2595
		' (get) Token: 0x06001A12 RID: 6674 RVA: 0x000F275B File Offset: 0x000F095B
		' (set) Token: 0x06001A13 RID: 6675 RVA: 0x000F2765 File Offset: 0x000F0965
		Friend Overridable Property txtHSNSAC As TextBox

		' Token: 0x17000A24 RID: 2596
		' (get) Token: 0x06001A14 RID: 6676 RVA: 0x000F276E File Offset: 0x000F096E
		' (set) Token: 0x06001A15 RID: 6677 RVA: 0x000F2778 File Offset: 0x000F0978
		Friend Overridable Property Label4 As Label

		' Token: 0x17000A25 RID: 2597
		' (get) Token: 0x06001A16 RID: 6678 RVA: 0x000F2781 File Offset: 0x000F0981
		' (set) Token: 0x06001A17 RID: 6679 RVA: 0x000F278C File Offset: 0x000F098C
		Friend Overridable Property txtQty As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtQty
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim keyEventHandler As KeyEventHandler = AddressOf Me.txtQty_KeyDown
				Dim textBox As TextBox = Me._txtQty
				If textBox IsNot Nothing Then
					RemoveHandler textBox.KeyDown, keyEventHandler
				End If
				Me._txtQty = value
				textBox = Me._txtQty
				If textBox IsNot Nothing Then
					AddHandler textBox.KeyDown, keyEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000A26 RID: 2598
		' (get) Token: 0x06001A18 RID: 6680 RVA: 0x000F27CF File Offset: 0x000F09CF
		' (set) Token: 0x06001A19 RID: 6681 RVA: 0x000F27D9 File Offset: 0x000F09D9
		Friend Overridable Property Label3 As Label

		' Token: 0x17000A27 RID: 2599
		' (get) Token: 0x06001A1A RID: 6682 RVA: 0x000F27E2 File Offset: 0x000F09E2
		' (set) Token: 0x06001A1B RID: 6683 RVA: 0x000F27EC File Offset: 0x000F09EC
		Friend Overridable Property txtTertiaryUOM As TextBox

		' Token: 0x17000A28 RID: 2600
		' (get) Token: 0x06001A1C RID: 6684 RVA: 0x000F27F5 File Offset: 0x000F09F5
		' (set) Token: 0x06001A1D RID: 6685 RVA: 0x000F27FF File Offset: 0x000F09FF
		Friend Overridable Property lblPrice As Label

		' Token: 0x17000A29 RID: 2601
		' (get) Token: 0x06001A1E RID: 6686 RVA: 0x000F2808 File Offset: 0x000F0A08
		' (set) Token: 0x06001A1F RID: 6687 RVA: 0x000F2812 File Offset: 0x000F0A12
		Friend Overridable Property txtUnitPrice As TextBox

		' Token: 0x17000A2A RID: 2602
		' (get) Token: 0x06001A20 RID: 6688 RVA: 0x000F281B File Offset: 0x000F0A1B
		' (set) Token: 0x06001A21 RID: 6689 RVA: 0x000F2825 File Offset: 0x000F0A25
		Friend Overridable Property Label5 As Label

		' Token: 0x17000A2B RID: 2603
		' (get) Token: 0x06001A22 RID: 6690 RVA: 0x000F282E File Offset: 0x000F0A2E
		' (set) Token: 0x06001A23 RID: 6691 RVA: 0x000F2838 File Offset: 0x000F0A38
		Friend Overridable Property txtBasicAmt As TextBox

		' Token: 0x17000A2C RID: 2604
		' (get) Token: 0x06001A24 RID: 6692 RVA: 0x000F2841 File Offset: 0x000F0A41
		' (set) Token: 0x06001A25 RID: 6693 RVA: 0x000F284C File Offset: 0x000F0A4C
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

		' Token: 0x17000A2D RID: 2605
		' (get) Token: 0x06001A26 RID: 6694 RVA: 0x000F288F File Offset: 0x000F0A8F
		' (set) Token: 0x06001A27 RID: 6695 RVA: 0x000F289C File Offset: 0x000F0A9C
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

		' Token: 0x17000A2E RID: 2606
		' (get) Token: 0x06001A28 RID: 6696 RVA: 0x000F28DF File Offset: 0x000F0ADF
		' (set) Token: 0x06001A29 RID: 6697 RVA: 0x000F28EC File Offset: 0x000F0AEC
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

		' Token: 0x17000A2F RID: 2607
		' (get) Token: 0x06001A2A RID: 6698 RVA: 0x000F292F File Offset: 0x000F0B2F
		' (set) Token: 0x06001A2B RID: 6699 RVA: 0x000F2939 File Offset: 0x000F0B39
		Friend Overridable Property Label7 As Label

		' Token: 0x17000A30 RID: 2608
		' (get) Token: 0x06001A2C RID: 6700 RVA: 0x000F2942 File Offset: 0x000F0B42
		' (set) Token: 0x06001A2D RID: 6701 RVA: 0x000F294C File Offset: 0x000F0B4C
		Friend Overridable Property txtTaxAmt As TextBox

		' Token: 0x17000A31 RID: 2609
		' (get) Token: 0x06001A2E RID: 6702 RVA: 0x000F2955 File Offset: 0x000F0B55
		' (set) Token: 0x06001A2F RID: 6703 RVA: 0x000F295F File Offset: 0x000F0B5F
		Friend Overridable Property Label8 As Label

		' Token: 0x17000A32 RID: 2610
		' (get) Token: 0x06001A30 RID: 6704 RVA: 0x000F2968 File Offset: 0x000F0B68
		' (set) Token: 0x06001A31 RID: 6705 RVA: 0x000F2972 File Offset: 0x000F0B72
		Friend Overridable Property Label6 As Label

		' Token: 0x17000A33 RID: 2611
		' (get) Token: 0x06001A32 RID: 6706 RVA: 0x000F297B File Offset: 0x000F0B7B
		' (set) Token: 0x06001A33 RID: 6707 RVA: 0x000F2985 File Offset: 0x000F0B85
		Friend Overridable Property txtNetAmt As TextBox

		' Token: 0x17000A34 RID: 2612
		' (get) Token: 0x06001A34 RID: 6708 RVA: 0x000F298E File Offset: 0x000F0B8E
		' (set) Token: 0x06001A35 RID: 6709 RVA: 0x000F2998 File Offset: 0x000F0B98
		Friend Overridable Property Label35 As Label

		' Token: 0x17000A35 RID: 2613
		' (get) Token: 0x06001A36 RID: 6710 RVA: 0x000F29A1 File Offset: 0x000F0BA1
		' (set) Token: 0x06001A37 RID: 6711 RVA: 0x000F29AB File Offset: 0x000F0BAB
		Friend Overridable Property txtDiscAmt As TextBox

		' Token: 0x17000A36 RID: 2614
		' (get) Token: 0x06001A38 RID: 6712 RVA: 0x000F29B4 File Offset: 0x000F0BB4
		' (set) Token: 0x06001A39 RID: 6713 RVA: 0x000F29BE File Offset: 0x000F0BBE
		Friend Overridable Property Label33 As Label

		' Token: 0x17000A37 RID: 2615
		' (get) Token: 0x06001A3A RID: 6714 RVA: 0x000F29C7 File Offset: 0x000F0BC7
		' (set) Token: 0x06001A3B RID: 6715 RVA: 0x000F29D1 File Offset: 0x000F0BD1
		Friend Overridable Property Label34 As Label

		' Token: 0x17000A38 RID: 2616
		' (get) Token: 0x06001A3C RID: 6716 RVA: 0x000F29DA File Offset: 0x000F0BDA
		' (set) Token: 0x06001A3D RID: 6717 RVA: 0x000F29E4 File Offset: 0x000F0BE4
		Friend Overridable Property txtLoading As TextBox

		' Token: 0x17000A39 RID: 2617
		' (get) Token: 0x06001A3E RID: 6718 RVA: 0x000F29ED File Offset: 0x000F0BED
		' (set) Token: 0x06001A3F RID: 6719 RVA: 0x000F29F7 File Offset: 0x000F0BF7
		Friend Overridable Property Label11 As Label

		' Token: 0x17000A3A RID: 2618
		' (get) Token: 0x06001A40 RID: 6720 RVA: 0x000F2A00 File Offset: 0x000F0C00
		' (set) Token: 0x06001A41 RID: 6721 RVA: 0x000F2A0A File Offset: 0x000F0C0A
		Friend Overridable Property txtPacking As TextBox

		' Token: 0x17000A3B RID: 2619
		' (get) Token: 0x06001A42 RID: 6722 RVA: 0x000F2A13 File Offset: 0x000F0C13
		' (set) Token: 0x06001A43 RID: 6723 RVA: 0x000F2A1D File Offset: 0x000F0C1D
		Friend Overridable Property Label12 As Label

		' Token: 0x17000A3C RID: 2620
		' (get) Token: 0x06001A44 RID: 6724 RVA: 0x000F2A26 File Offset: 0x000F0C26
		' (set) Token: 0x06001A45 RID: 6725 RVA: 0x000F2A30 File Offset: 0x000F0C30
		Friend Overridable Property txtFreight As TextBox

		' Token: 0x17000A3D RID: 2621
		' (get) Token: 0x06001A46 RID: 6726 RVA: 0x000F2A39 File Offset: 0x000F0C39
		' (set) Token: 0x06001A47 RID: 6727 RVA: 0x000F2A43 File Offset: 0x000F0C43
		Friend Overridable Property Label13 As Label

		' Token: 0x17000A3E RID: 2622
		' (get) Token: 0x06001A48 RID: 6728 RVA: 0x000F2A4C File Offset: 0x000F0C4C
		' (set) Token: 0x06001A49 RID: 6729 RVA: 0x000F2A56 File Offset: 0x000F0C56
		Friend Overridable Property txtTransportation As TextBox

		' Token: 0x17000A3F RID: 2623
		' (get) Token: 0x06001A4A RID: 6730 RVA: 0x000F2A5F File Offset: 0x000F0C5F
		' (set) Token: 0x06001A4B RID: 6731 RVA: 0x000F2A69 File Offset: 0x000F0C69
		Friend Overridable Property Label23 As Label

		' Token: 0x17000A40 RID: 2624
		' (get) Token: 0x06001A4C RID: 6732 RVA: 0x000F2A72 File Offset: 0x000F0C72
		' (set) Token: 0x06001A4D RID: 6733 RVA: 0x000F2A7C File Offset: 0x000F0C7C
		Friend Overridable Property txtDiscPer As TextBox

		' Token: 0x17000A41 RID: 2625
		' (get) Token: 0x06001A4E RID: 6734 RVA: 0x000F2A85 File Offset: 0x000F0C85
		' (set) Token: 0x06001A4F RID: 6735 RVA: 0x000F2A8F File Offset: 0x000F0C8F
		Friend Overridable Property cmbTaxPer As ComboBox

		' Token: 0x17000A42 RID: 2626
		' (get) Token: 0x06001A50 RID: 6736 RVA: 0x000F2A98 File Offset: 0x000F0C98
		' (set) Token: 0x06001A51 RID: 6737 RVA: 0x000F2AA2 File Offset: 0x000F0CA2
		Friend Overridable Property Label14 As Label

		' Token: 0x17000A43 RID: 2627
		' (get) Token: 0x06001A52 RID: 6738 RVA: 0x000F2AAB File Offset: 0x000F0CAB
		' (set) Token: 0x06001A53 RID: 6739 RVA: 0x000F2AB5 File Offset: 0x000F0CB5
		Friend Overridable Property txtFinalAmt As TextBox

		' Token: 0x17000A44 RID: 2628
		' (get) Token: 0x06001A54 RID: 6740 RVA: 0x000F2ABE File Offset: 0x000F0CBE
		' (set) Token: 0x06001A55 RID: 6741 RVA: 0x000F2AC8 File Offset: 0x000F0CC8
		Friend Overridable Property txtOtherCharges As TextBox

		' Token: 0x17000A45 RID: 2629
		' (get) Token: 0x06001A56 RID: 6742 RVA: 0x000F2AD1 File Offset: 0x000F0CD1
		' (set) Token: 0x06001A57 RID: 6743 RVA: 0x000F2ADB File Offset: 0x000F0CDB
		Friend Overridable Property Label10 As Label

		' Token: 0x17000A46 RID: 2630
		' (get) Token: 0x06001A58 RID: 6744 RVA: 0x000F2AE4 File Offset: 0x000F0CE4
		' (set) Token: 0x06001A59 RID: 6745 RVA: 0x000F2AF0 File Offset: 0x000F0CF0
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

		' Token: 0x17000A47 RID: 2631
		' (get) Token: 0x06001A5A RID: 6746 RVA: 0x000F2B33 File Offset: 0x000F0D33
		' (set) Token: 0x06001A5B RID: 6747 RVA: 0x000F2B3D File Offset: 0x000F0D3D
		Friend Overridable Property Label18 As Label

		' Token: 0x17000A48 RID: 2632
		' (get) Token: 0x06001A5C RID: 6748 RVA: 0x000F2B46 File Offset: 0x000F0D46
		' (set) Token: 0x06001A5D RID: 6749 RVA: 0x000F2B50 File Offset: 0x000F0D50
		Friend Overridable Property txtCatalogNo As TextBox

		' Token: 0x17000A49 RID: 2633
		' (get) Token: 0x06001A5E RID: 6750 RVA: 0x000F2B59 File Offset: 0x000F0D59
		' (set) Token: 0x06001A5F RID: 6751 RVA: 0x000F2B63 File Offset: 0x000F0D63
		Friend Overridable Property Label15 As Label

		' Token: 0x17000A4A RID: 2634
		' (get) Token: 0x06001A60 RID: 6752 RVA: 0x000F2B6C File Offset: 0x000F0D6C
		' (set) Token: 0x06001A61 RID: 6753 RVA: 0x000F2B76 File Offset: 0x000F0D76
		Friend Overridable Property txtProductName As TextBox

		' Token: 0x17000A4B RID: 2635
		' (get) Token: 0x06001A62 RID: 6754 RVA: 0x000F2B7F File Offset: 0x000F0D7F
		' (set) Token: 0x06001A63 RID: 6755 RVA: 0x000F2B89 File Offset: 0x000F0D89
		Friend Overridable Property txtPrimaryMeasure As TextBox

		' Token: 0x17000A4C RID: 2636
		' (get) Token: 0x06001A64 RID: 6756 RVA: 0x000F2B92 File Offset: 0x000F0D92
		' (set) Token: 0x06001A65 RID: 6757 RVA: 0x000F2B9C File Offset: 0x000F0D9C
		Friend Overridable Property Label20 As Label

		' Token: 0x17000A4D RID: 2637
		' (get) Token: 0x06001A66 RID: 6758 RVA: 0x000F2BA5 File Offset: 0x000F0DA5
		' (set) Token: 0x06001A67 RID: 6759 RVA: 0x000F2BAF File Offset: 0x000F0DAF
		Friend Overridable Property txtPrimaryUOM As TextBox

		' Token: 0x17000A4E RID: 2638
		' (get) Token: 0x06001A68 RID: 6760 RVA: 0x000F2BB8 File Offset: 0x000F0DB8
		' (set) Token: 0x06001A69 RID: 6761 RVA: 0x000F2BC2 File Offset: 0x000F0DC2
		Friend Overridable Property txtTertiaryMeasure As TextBox

		' Token: 0x17000A4F RID: 2639
		' (get) Token: 0x06001A6A RID: 6762 RVA: 0x000F2BCB File Offset: 0x000F0DCB
		' (set) Token: 0x06001A6B RID: 6763 RVA: 0x000F2BD5 File Offset: 0x000F0DD5
		Friend Overridable Property txtPrimaryPackSize As TextBox

		' Token: 0x17000A50 RID: 2640
		' (get) Token: 0x06001A6C RID: 6764 RVA: 0x000F2BDE File Offset: 0x000F0DDE
		' (set) Token: 0x06001A6D RID: 6765 RVA: 0x000F2BE8 File Offset: 0x000F0DE8
		Friend Overridable Property Label17 As Label

		' Token: 0x17000A51 RID: 2641
		' (get) Token: 0x06001A6E RID: 6766 RVA: 0x000F2BF1 File Offset: 0x000F0DF1
		' (set) Token: 0x06001A6F RID: 6767 RVA: 0x000F2BFB File Offset: 0x000F0DFB
		Friend Overridable Property Label16 As Label

		' Token: 0x17000A52 RID: 2642
		' (get) Token: 0x06001A70 RID: 6768 RVA: 0x000F2C04 File Offset: 0x000F0E04
		' (set) Token: 0x06001A71 RID: 6769 RVA: 0x000F2C0E File Offset: 0x000F0E0E
		Friend Overridable Property txtTertiaryPackSize As TextBox

		' Token: 0x17000A53 RID: 2643
		' (get) Token: 0x06001A72 RID: 6770 RVA: 0x000F2C17 File Offset: 0x000F0E17
		' (set) Token: 0x06001A73 RID: 6771 RVA: 0x000F2C21 File Offset: 0x000F0E21
		Friend Overridable Property txtNoOfBarcodes As TextBox

		' Token: 0x17000A54 RID: 2644
		' (get) Token: 0x06001A74 RID: 6772 RVA: 0x000F2C2A File Offset: 0x000F0E2A
		' (set) Token: 0x06001A75 RID: 6773 RVA: 0x000F2C34 File Offset: 0x000F0E34
		Friend Overridable Property Label19 As Label

		' Token: 0x06001A76 RID: 6774
		Private Declare Sub SendMessage Lib "user32.DLL" (hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

		' Token: 0x06001A77 RID: 6775
		Private Declare Sub ReleaseCapture Lib "user32.DLL" ()

		' Token: 0x06001A78 RID: 6776 RVA: 0x000F2C3D File Offset: 0x000F0E3D
		Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs)
			POItems.ReleaseCapture()
			POItems.SendMessage(MyBase.Handle, 274, 61458, 0)
		End Sub

		' Token: 0x06001A79 RID: 6777 RVA: 0x000F2C60 File Offset: 0x000F0E60
		Public Sub New(iR As Integer, sForm As String, Status As String, dt As DataTable, dt1 As DataTable)
			AddHandler MyBase.Load, AddressOf Me.POItems_Load
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
			Me.sStatus = Status
			Me.dtItems = dt
			Me.dtPR = dt1
		End Sub

		' Token: 0x06001A7A RID: 6778 RVA: 0x000F2D0F File Offset: 0x000F0F0F
		Private Sub form_btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06001A7B RID: 6779 RVA: 0x000F2D19 File Offset: 0x000F0F19
		Private Sub POItems_Load(sender As Object, e As EventArgs)
			Me.ClearForm()
			Me.FillData()
			Me.SetForm()
		End Sub

		' Token: 0x06001A7C RID: 6780 RVA: 0x000F2D34 File Offset: 0x000F0F34
		Private Sub ClearForm()
			Me.cmbProduct.Text = ""
			Me.txtProductName.Text = ""
			Me.cmbProduct.SelectedIndex = -1
			Me.txtDesc.Text = ""
			Me.txtCatalogNo.Text = ""
			Me.txtHSNSAC.Text = ""
			Me.txtTertiaryUOM.Text = ""
			Me.txtTertiaryPackSize.Text = ""
			Me.txtPrimaryUOM.Text = ""
			Me.txtPrimaryPackSize.Text = ""
			Me.txtPrimaryMeasure.Text = ""
			Me.txtUnitPrice.Text = ""
			Me.txtQty.Text = ""
			Me.txtBasicAmt.Text = ""
			Me.txtDiscPer.Text = ""
			Me.txtDiscAmt.Text = ""
			Me.txtNetAmt.Text = ""
			Me.cmbTaxPer.Text = ""
			Me.txtTaxAmt.Text = ""
			Me.txtTransportation.Text = ""
			Me.txtFreight.Text = ""
			Me.txtLoading.Text = ""
			Me.txtPacking.Text = ""
			Me.txtOtherCharges.Text = ""
			Me.txtFinalAmt.Text = ""
			Me.txtDesc.[ReadOnly] = True
			Me.txtQty.[ReadOnly] = True
			Me.txtDiscPer.[ReadOnly] = True
			Me.txtUnitPrice.[ReadOnly] = True
			Me.txtTransportation.[ReadOnly] = True
			Me.txtFreight.[ReadOnly] = True
			Me.txtLoading.[ReadOnly] = True
			Me.txtPacking.[ReadOnly] = True
			Me.txtOtherCharges.[ReadOnly] = True
			Me.txtFinalAmt.[ReadOnly] = True
			Me.cmbTaxPer.Enabled = False
			Me.lblPrice.Text = "Unit Price"
		End Sub

		' Token: 0x06001A7D RID: 6781 RVA: 0x000F2F87 File Offset: 0x000F1187
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.DialogResult = DialogResult.Cancel
			MyBase.Close()
		End Sub

		' Token: 0x06001A7E RID: 6782 RVA: 0x000F2F9C File Offset: 0x000F119C
		Private Sub FillData()
			Dim flag As Boolean = Me.iRow <> -1
			If flag Then
				Me.cmbType.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("ProductType"))
				Me.FillProduct()
				Me.cmbProduct.SelectedValue = RuntimeHelpers.GetObjectValue(Me.dtItems.Rows(Me.iRow)("ProductID"))
				Me.FillProductDetails()
				Me.txtDesc.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("Description"))
				Me.txtCatalogNo.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("CatalogNo"))
				Me.txtHSNSAC.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("HSNSACCode"))
				Me.txtUnitPrice.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("UnitPrice"))
				Me.txtQty.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("Quantity"))
				Me.txtBasicAmt.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("BasicValue"))
				Me.txtDiscPer.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("DiscountPer"))
				Me.txtDiscAmt.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("DiscountAmt"))
				Me.txtNetAmt.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("NetAmt"))
				Me.cmbTaxPer.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("TaxPer"))
				Me.txtTaxAmt.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("TaxAmt"))
				Me.txtTransportation.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("Transportation"))
				Me.txtFreight.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("Freight"))
				Me.txtLoading.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("LoadingUnloading"))
				Me.txtPacking.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("Packing"))
				Me.txtOtherCharges.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("OtherCharges"))
				Me.txtFinalAmt.Text = Conversions.ToString(Me.dtItems.Rows(Me.iRow)("FinalAmt"))
				Dim flag2 As Boolean = Operators.CompareString(Me.txtPrimaryPackSize.Text, "", False) <> 0
				If flag2 Then
					Dim flag3 As Boolean = Conversion.Val(Me.txtQty.Text) Mod Conversion.Val(Me.txtPrimaryPackSize.Text) = 0.0
					If flag3 Then
						Me.txtNoOfBarcodes.Text = Conversions.ToString(Conversion.Val(Me.txtQty.Text) / Conversion.Val(Me.txtPrimaryPackSize.Text))
						Me.btnSave.Enabled = True
					Else
						CustomMsgBox.Show("Invalid Quantity or Primary Pack Size", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.btnSave.Enabled = False
					End If
				Else
					CustomMsgBox.Show("Incorrect Product Master Data.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.btnSave.Enabled = False
				End If
			End If
		End Sub

		' Token: 0x06001A7F RID: 6783 RVA: 0x000F344C File Offset: 0x000F164C
		Private Sub SetForm()
			Dim flag As Boolean = Me.iRow = -1
			If flag Then
				Me.btnDelete.Enabled = False
			End If
			Dim flag2 As Boolean = Me.dtPR.Rows.Count > 0
			If flag2 Then
				Dim flag3 As Boolean = (Operators.CompareString(GlobalVariables.gsUserGroup, "Super Admin", False) <> 0) And (Operators.CompareString(GlobalVariables.gsUserGroup, "Admin", False) <> 0)
				If flag3 Then
					Me.txtQty.[ReadOnly] = True
					Me.btnDelete.Enabled = False
				End If
			End If
			Dim text As String = Me.sFormType
			If Operators.CompareString(text, "PO Add", False) <> 0 AndAlso Operators.CompareString(text, "PO Modify", False) <> 0 Then
				Me.cmbType.Enabled = False
				Me.cmbProduct.Enabled = False
				Me.txtDesc.[ReadOnly] = True
				Me.txtUnitPrice.[ReadOnly] = True
				Me.txtQty.[ReadOnly] = True
				Me.txtDiscPer.[ReadOnly] = True
				Me.cmbTaxPer.Enabled = False
				Me.txtTransportation.[ReadOnly] = True
				Me.txtFreight.[ReadOnly] = True
				Me.txtLoading.[ReadOnly] = True
				Me.txtPacking.[ReadOnly] = True
				Me.txtOtherCharges.[ReadOnly] = True
				Me.btnSave.Enabled = False
				Me.btnDelete.Enabled = False
			End If
			Dim text2 As String = Me.sStatus
			Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(text2)
			If num <= 2512310814UI Then
				If num <= 293822401UI Then
					If num <> 289852080UI Then
						If num = 293822401UI Then
							If Operators.CompareString(text2, "Amended", False) = 0 Then
								GoTo IL_02A6
							End If
						End If
					ElseIf Operators.CompareString(text2, "New P.O.", False) <> 0 Then
					End If
				ElseIf num <> 1072715097UI Then
					If num = 2512310814UI Then
						If Operators.CompareString(text2, "On-Hold", False) <> 0 Then
						End If
					End If
				ElseIf Operators.CompareString(text2, "In Approval", False) <> 0 Then
				End If
				GoTo IL_035F
			End If
			If num <= 3145224873UI Then
				If num <> 2787838396UI Then
					If num <> 3145224873UI Then
						GoTo IL_035F
					End If
					If Operators.CompareString(text2, "Printed", False) <> 0 Then
						GoTo IL_035F
					End If
				ElseIf Operators.CompareString(text2, "Cancelled", False) <> 0 Then
					GoTo IL_035F
				End If
			ElseIf num <> 3331920026UI Then
				If num <> 4031823975UI Then
					GoTo IL_035F
				End If
				If Operators.CompareString(text2, "Rejected", False) <> 0 Then
					GoTo IL_035F
				End If
			ElseIf Operators.CompareString(text2, "Approved", False) <> 0 Then
				GoTo IL_035F
			End If
			IL_02A6:
			Me.cmbType.Enabled = False
			Me.cmbProduct.Enabled = False
			Me.txtDesc.[ReadOnly] = True
			Me.txtUnitPrice.[ReadOnly] = True
			Me.txtQty.[ReadOnly] = True
			Me.txtDiscPer.[ReadOnly] = True
			Me.cmbTaxPer.Enabled = False
			Me.txtTransportation.[ReadOnly] = True
			Me.txtFreight.[ReadOnly] = True
			Me.txtLoading.[ReadOnly] = True
			Me.txtPacking.[ReadOnly] = True
			Me.txtOtherCharges.[ReadOnly] = True
			Me.btnSave.Enabled = False
			Me.btnDelete.Enabled = False
			IL_035F:
			AddHandler Me.txtUnitPrice.TextChanged, Sub(a0 As Object, a1 As EventArgs)
				Me.CalculateAmount()
			End Sub
			AddHandler Me.txtQty.TextChanged, Sub(a0 As Object, a1 As EventArgs)
				Me.CalculateAmount()
			End Sub
			AddHandler Me.txtDiscPer.TextChanged, Sub(a0 As Object, a1 As EventArgs)
				Me.CalculateAmount()
			End Sub
			AddHandler Me.cmbTaxPer.SelectedIndexChanged, Sub(a0 As Object, a1 As EventArgs)
				Me.CalculateAmount()
			End Sub
			AddHandler Me.txtTransportation.TextChanged, Sub(a0 As Object, a1 As EventArgs)
				Me.CalculateAmount()
			End Sub
			AddHandler Me.txtFreight.TextChanged, Sub(a0 As Object, a1 As EventArgs)
				Me.CalculateAmount()
			End Sub
			AddHandler Me.txtLoading.TextChanged, Sub(a0 As Object, a1 As EventArgs)
				Me.CalculateAmount()
			End Sub
			AddHandler Me.txtPacking.TextChanged, Sub(a0 As Object, a1 As EventArgs)
				Me.CalculateAmount()
			End Sub
			AddHandler Me.txtOtherCharges.TextChanged, Sub(a0 As Object, a1 As EventArgs)
				Me.CalculateAmount()
			End Sub
			AddHandler Me.txtUnitPrice.KeyDown, AddressOf Me.Keydown_Numeric
			AddHandler Me.txtDiscPer.KeyDown, AddressOf Me.Keydown_Numeric
			AddHandler Me.cmbTaxPer.KeyDown, AddressOf Me.Keydown_Numeric
			AddHandler Me.txtTransportation.KeyDown, AddressOf Me.Keydown_Numeric
			AddHandler Me.txtFreight.KeyDown, AddressOf Me.Keydown_Numeric
			AddHandler Me.txtLoading.KeyDown, AddressOf Me.Keydown_Numeric
			AddHandler Me.txtPacking.KeyDown, AddressOf Me.Keydown_Numeric
			AddHandler Me.txtOtherCharges.KeyDown, AddressOf Me.Keydown_Numeric
		End Sub

		' Token: 0x06001A80 RID: 6784 RVA: 0x000F3954 File Offset: 0x000F1B54
		Private Sub CalculateAmount()
			Dim num As Double = 0.0
			Dim num2 As Double = 0.0
			Dim num3 As Double = 0.0
			Dim num4 As Double = 0.0
			Dim num5 As Double = 0.0
			Dim flag As Boolean = Versioned.IsNumeric(Me.txtTransportation.Text)
			If flag Then
				num = Conversion.Val(Me.txtTransportation.Text)
			End If
			Dim flag2 As Boolean = Versioned.IsNumeric(Me.txtFreight.Text)
			If flag2 Then
				num2 = Conversion.Val(Me.txtFreight.Text)
			End If
			Dim flag3 As Boolean = Versioned.IsNumeric(Me.txtLoading.Text)
			If flag3 Then
				num3 = Conversion.Val(Me.txtLoading.Text)
			End If
			Dim flag4 As Boolean = Versioned.IsNumeric(Me.txtPacking.Text)
			If flag4 Then
				num4 = Conversion.Val(Me.txtPacking.Text)
			End If
			Dim flag5 As Boolean = Versioned.IsNumeric(Me.txtOtherCharges.Text)
			If flag5 Then
				num5 = Conversion.Val(Me.txtOtherCharges.Text)
			End If
			Dim flag6 As Boolean = (Operators.CompareString(Strings.Trim(Me.txtUnitPrice.Text), "", False) <> 0) And Versioned.IsNumeric(Me.txtUnitPrice.Text) And (Operators.CompareString(Strings.Trim(Me.txtQty.Text), "", False) <> 0) And Versioned.IsNumeric(Me.txtQty.Text)
			If flag6 Then
				Me.txtBasicAmt.Text = Strings.Format(Conversion.Val(Me.txtUnitPrice.Text) * Conversion.Val(Me.txtQty.Text), "#0.00")
				Me.txtNetAmt.Text = Me.txtBasicAmt.Text
			Else
				Me.txtBasicAmt.Text = ""
				Me.txtNetAmt.Text = ""
			End If
			Dim flag7 As Boolean = (Operators.CompareString(Me.txtBasicAmt.Text, "", False) <> 0) And (Operators.CompareString(Strings.Trim(Me.txtDiscPer.Text), "", False) <> 0) And Versioned.IsNumeric(Me.txtDiscPer.Text)
			If flag7 Then
				Me.txtDiscAmt.Text = Strings.Format(Conversion.Val(Me.txtBasicAmt.Text) * Conversion.Val(Me.txtDiscPer.Text) / 100.0, "#0.00")
				Me.txtNetAmt.Text = Strings.Format(Conversion.Val(Me.txtBasicAmt.Text) - Conversion.Val(Me.txtDiscAmt.Text), "#0.00")
			Else
				Me.txtDiscAmt.Text = ""
			End If
			Dim flag8 As Boolean = (Operators.CompareString(Me.txtNetAmt.Text, "", False) <> 0) And (Operators.CompareString(Strings.Trim(Me.cmbTaxPer.Text), "", False) <> 0)
			If flag8 Then
				Me.txtTaxAmt.Text = Strings.Format(Conversion.Val(Me.txtNetAmt.Text) * Conversion.Val(Strings.Replace(Me.cmbTaxPer.Text, " %", "", 1, -1, CompareMethod.Binary)) / 100.0, "#0.00")
			Else
				Me.txtTaxAmt.Text = ""
			End If
			Dim flag9 As Boolean = Operators.CompareString(Me.txtNetAmt.Text, "", False) <> 0
			If flag9 Then
				Me.txtFinalAmt.Text = Strings.Format(Conversion.Val(Me.txtNetAmt.Text) + Conversion.Val(Me.txtTaxAmt.Text) + num + num2 + num3 + num4 + num5, "#0.00")
			Else
				Me.txtFinalAmt.Text = ""
			End If
		End Sub

		' Token: 0x06001A81 RID: 6785 RVA: 0x000F3D4C File Offset: 0x000F1F4C
		Private Sub Keydown_Numeric(sender As Object, e As KeyEventArgs)
			Dim keyCode As Keys = e.KeyCode
			Dim flag As Boolean = (keyCode >= Keys.D0 AndAlso keyCode <= Keys.D9) OrElse (keyCode >= Keys.NumPad0 AndAlso keyCode <= Keys.NumPad9) OrElse keyCode = Keys.Back OrElse keyCode = Keys.[Decimal] OrElse keyCode = Keys.OemPeriod
			If Not flag Then
				e.SuppressKeyPress = True
			End If
		End Sub

		' Token: 0x06001A82 RID: 6786 RVA: 0x000F3D9C File Offset: 0x000F1F9C
		Private Sub txtQty_KeyDown(sender As Object, e As KeyEventArgs)
			Dim keyCode As Keys = e.KeyCode
			Dim flag As Boolean = (keyCode >= Keys.D0 AndAlso keyCode <= Keys.D9) OrElse (keyCode >= Keys.NumPad0 AndAlso keyCode <= Keys.NumPad9) OrElse keyCode = Keys.Back OrElse keyCode = Keys.[Decimal] OrElse keyCode = Keys.OemPeriod
			If Not flag Then
				flag = keyCode = Keys.[Return]
				If flag Then
					Dim flag2 As Boolean = Operators.CompareString(Me.txtQty.Text, "", False) <> 0
					If flag2 Then
						Dim flag3 As Boolean = Versioned.IsNumeric(Me.txtPrimaryPackSize.Text)
						If flag3 Then
							Dim flag4 As Boolean = Conversion.Val(Me.txtQty.Text) Mod Conversion.Val(Me.txtPrimaryPackSize.Text) = 0.0
							If flag4 Then
								Me.txtNoOfBarcodes.Text = Conversions.ToString(Conversion.Val(Me.txtQty.Text) / Conversion.Val(Me.txtPrimaryPackSize.Text))
								Dim flag5 As Boolean = Conversion.Val(Me.txtNoOfBarcodes.Text) Mod Conversion.Val(Me.txtTertiaryPackSize.Text) = 0.0
								If flag5 Then
									Me.btnSave.Enabled = True
								Else
									CustomMsgBox.Show("Invalid Quantity or Tertiary Pack Size", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
									Me.btnSave.Enabled = False
								End If
							Else
								CustomMsgBox.Show("Invalid Quantity or Primary Pack Size", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								Me.btnSave.Enabled = False
							End If
						Else
							CustomMsgBox.Show("Incorrect Product Master Data.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.btnSave.Enabled = False
						End If
					Else
						Me.txtNoOfBarcodes.Text = ""
					End If
				Else
					e.SuppressKeyPress = True
				End If
			End If
		End Sub

		' Token: 0x06001A83 RID: 6787 RVA: 0x000F3F5C File Offset: 0x000F215C
		Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.cmbType.Text, "", False) <> 0
			If flag Then
				Me.FillProduct()
			Else
				Me.cmbProduct.DataSource = Nothing
			End If
			Me.ClearForm()
		End Sub

		' Token: 0x06001A84 RID: 6788 RVA: 0x000F3FA8 File Offset: 0x000F21A8
		Private Sub FillProduct()
			Dim text As String = " SELECT ProductID, ProductCode, ProductName, ProductType, SpecificationNo, Reference, " & vbCrLf
			text += " CatalogNo, HSNSACCode, Expiry, UnitPrice, GSTPer, StorageCondition, " & vbCrLf
			text += " TertiaryUOM, TertiaryPackSize, PrimaryUOM, PrimaryPackSize, Measurement," & vbCrLf
			text += " IsActive, IsGRNApplicable, IsQCApplicable, IsParentApplicable, IsUnitsEditable" & vbCrLf
			text += " FROM Product" & vbCrLf
			text = text + " WHERE Status = 'Approved' AND ProductType IN ('" + Me.cmbType.Text + "') " & vbCrLf
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

		' Token: 0x06001A85 RID: 6789 RVA: 0x000F40CC File Offset: 0x000F22CC
		Private Sub cmbProduct_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.cmbProduct.SelectedIndex > -1
			If flag Then
				Me.FillProductDetails()
			Else
				Me.cmbProduct.Text = ""
				Me.ClearForm()
			End If
		End Sub

		' Token: 0x06001A86 RID: 6790 RVA: 0x000F4110 File Offset: 0x000F2310
		Private Sub FillProductDetails()
			Dim flag As Boolean = Me.cmbProduct.SelectedIndex > -1
			If flag Then
				Dim dataRow As DataRow = Me.dtProduct.[Select]("ProductID = '" + Me.cmbProduct.SelectedValue.ToString() + "'")(0)
				Me.txtProductName.Text = Conversions.ToString(dataRow("ProductName"))
				Me.txtCatalogNo.Text = Conversions.ToString(dataRow("CatalogNo"))
				Me.txtHSNSAC.Text = Conversions.ToString(dataRow("HSNSACCode"))
				Me.txtTertiaryUOM.Text = Conversions.ToString(dataRow("TertiaryUOM"))
				Me.txtTertiaryPackSize.Text = Conversions.ToString(dataRow("TertiaryPackSize"))
				Me.txtPrimaryUOM.Text = dataRow("PrimaryUOM").ToString()
				Me.txtPrimaryPackSize.Text = dataRow("PrimaryPackSize").ToString()
				Me.txtPrimaryMeasure.Text = dataRow("Measurement").ToString()
				Me.txtUnitPrice.Text = Conversions.ToString(dataRow("UnitPrice"))
				Me.cmbTaxPer.Text = Conversions.ToString(dataRow("GSTPer"))
				Me.lblPrice.Text = "Unit Price/ " + Me.txtPrimaryMeasure.Text
				Me.txtDesc.[ReadOnly] = False
				Me.txtQty.[ReadOnly] = False
				Me.txtDiscPer.[ReadOnly] = False
				Me.txtUnitPrice.[ReadOnly] = False
				Me.txtTransportation.[ReadOnly] = False
				Me.txtFreight.[ReadOnly] = False
				Me.txtLoading.[ReadOnly] = False
				Me.txtPacking.[ReadOnly] = False
				Me.txtOtherCharges.[ReadOnly] = False
				Me.cmbTaxPer.Enabled = True
				Dim flag2 As Boolean = Operators.CompareString(Me.txtPrimaryPackSize.Text, "", False) = 0
				If flag2 Then
					CustomMsgBox.Show("Incorrect Product Master Data.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.btnSave.Enabled = False
				End If
			Else
				Me.txtDesc.[ReadOnly] = True
				Me.txtQty.[ReadOnly] = True
				Me.txtDiscPer.[ReadOnly] = True
				Me.txtUnitPrice.[ReadOnly] = True
				Me.txtTransportation.[ReadOnly] = True
				Me.txtFreight.[ReadOnly] = True
				Me.txtLoading.[ReadOnly] = True
				Me.txtPacking.[ReadOnly] = True
				Me.txtOtherCharges.[ReadOnly] = True
				Me.cmbTaxPer.Enabled = False
				Me.btnSave.Enabled = False
			End If
		End Sub

		' Token: 0x06001A87 RID: 6791 RVA: 0x000F43F4 File Offset: 0x000F25F4
		Private Function ValidateDelete() As Boolean
			Dim flag As Boolean = Me.dtPR.Rows.Count > 0
			If flag Then
				Dim flag2 As Boolean = Me.dtPR.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("ProductID = '", Me.cmbProduct.SelectedValue), "'"))).Length > 0
				If flag2 Then
					CustomMsgBox.Show("Cannot Delete PR Product.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Return False
				End If
			End If
			Return True
		End Function

		' Token: 0x06001A88 RID: 6792 RVA: 0x000F4470 File Offset: 0x000F2670
		Private Sub btnDelete_Click(sender As Object, e As EventArgs)
			Try
				Me.DeleteItem()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06001A89 RID: 6793 RVA: 0x000F44C8 File Offset: 0x000F26C8
		Private Sub DeleteItem()
			Dim flag As Boolean = CustomMsgBox.Show("Delete PO Item..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes
			If flag Then
				Dim flag2 As Boolean = Not Me.ValidateDelete()
				If Not flag2 Then
					Me.dtItems.Rows.RemoveAt(Me.iRow)
					Me.dtItems.AcceptChanges()
					MyBase.DialogResult = DialogResult.OK
					MyBase.Close()
				End If
			End If
		End Sub

		' Token: 0x06001A8A RID: 6794 RVA: 0x000F4534 File Offset: 0x000F2734
		Private Function ValidateForm() As Boolean
			Dim flag As Boolean = Me.cmbProduct.SelectedIndex = -1
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Select Product.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.cmbProduct.Focus()
				flag2 = False
			Else
				Dim flag3 As Boolean = Not Versioned.IsNumeric(Me.txtUnitPrice.Text) Or (Operators.CompareString(Strings.Trim(Me.txtUnitPrice.Text), "", False) = 0)
				If flag3 Then
					CustomMsgBox.Show("Unit Price Should Be Numeric.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.txtUnitPrice.Focus()
					flag2 = False
				Else
					Dim flag4 As Boolean = Not Versioned.IsNumeric(Me.txtQty.Text) Or (Operators.CompareString(Strings.Trim(Me.txtQty.Text), "", False) = 0)
					If flag4 Then
						CustomMsgBox.Show("Quantity Should Be Numeric.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.txtQty.Focus()
						flag2 = False
					Else
						Dim flag5 As Boolean = Not Versioned.IsNumeric(Me.txtNoOfBarcodes.Text) Or (Operators.CompareString(Strings.Trim(Me.txtNoOfBarcodes.Text), "", False) = 0)
						If flag5 Then
							CustomMsgBox.Show("Invalid No. Of Issueable Units.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.txtNoOfBarcodes.Focus()
							flag2 = False
						Else
							Dim flag6 As Boolean = Operators.CompareString(Strings.Trim(Me.txtDiscPer.Text), "", False) <> 0
							If flag6 Then
								Dim flag7 As Boolean = Not Versioned.IsNumeric(Me.txtDiscPer.Text)
								If flag7 Then
									CustomMsgBox.Show("Discount % Should Be Numeric.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
									Me.txtDiscPer.Focus()
									Return False
								End If
							End If
							Dim flag8 As Boolean = Operators.CompareString(Me.cmbTaxPer.Text, "", False) = 0
							If flag8 Then
								CustomMsgBox.Show("Select Tax %.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								Me.cmbTaxPer.Focus()
								flag2 = False
							Else
								Dim flag9 As Boolean = Operators.CompareString(Strings.Trim(Me.txtTransportation.Text), "", False) <> 0
								If flag9 Then
									Dim flag10 As Boolean = Not Versioned.IsNumeric(Me.txtTransportation.Text)
									If flag10 Then
										CustomMsgBox.Show("Transportation Charges Should Be Numeric.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
										Me.txtTransportation.Focus()
										Return False
									End If
								End If
								Dim flag11 As Boolean = Operators.CompareString(Strings.Trim(Me.txtFreight.Text), "", False) <> 0
								If flag11 Then
									Dim flag12 As Boolean = Not Versioned.IsNumeric(Me.txtFreight.Text)
									If flag12 Then
										CustomMsgBox.Show("Freight Charges Should Be Numeric.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
										Me.txtFreight.Focus()
										Return False
									End If
								End If
								Dim flag13 As Boolean = Operators.CompareString(Strings.Trim(Me.txtLoading.Text), "", False) <> 0
								If flag13 Then
									Dim flag14 As Boolean = Not Versioned.IsNumeric(Me.txtLoading.Text)
									If flag14 Then
										CustomMsgBox.Show("Loading/Unloading Charges Should Be Numeric.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
										Me.txtLoading.Focus()
										Return False
									End If
								End If
								Dim flag15 As Boolean = Operators.CompareString(Strings.Trim(Me.txtPacking.Text), "", False) <> 0
								If flag15 Then
									Dim flag16 As Boolean = Not Versioned.IsNumeric(Me.txtPacking.Text)
									If flag16 Then
										CustomMsgBox.Show("Packing Charges Should Be Numeric.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
										Me.txtPacking.Focus()
										Return False
									End If
								End If
								Dim flag17 As Boolean = Operators.CompareString(Strings.Trim(Me.txtOtherCharges.Text), "", False) <> 0
								If flag17 Then
									Dim flag18 As Boolean = Not Versioned.IsNumeric(Me.txtOtherCharges.Text)
									If flag18 Then
										CustomMsgBox.Show("Other Charges Should Be Numeric.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
										Me.txtOtherCharges.Focus()
										Return False
									End If
								End If
								Dim text As String = ""
								text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("ProductID = '", Me.cmbProduct.SelectedValue), "' ")))
								text = text + " AND SrNo <> '" + Conversions.ToString(Me.iRow + 1) + "'"
								Dim text2 As String = Me.cmbType.Text
								If Operators.CompareString(text2, "Service", False) = 0 Then
									text = text + " AND Description = '" + Me.txtDesc.Text + "' "
								End If
								Dim flag19 As Boolean = Me.dtItems.[Select](text).Length > 0
								If flag19 Then
									CustomMsgBox.Show("Product Already In The List.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
									Me.cmbProduct.Focus()
									flag2 = False
								Else
									Dim text3 As String = ""
									text3 = Conversions.ToString(Operators.AddObject(text3, Operators.ConcatenateObject(Operators.ConcatenateObject("ProductID = '", Me.cmbProduct.SelectedValue), "' ")))
									Dim text4 As String = Me.cmbType.Text
									If Operators.CompareString(text4, "Service", False) = 0 Then
										text3 = text3 + " AND Description = '" + Me.txtDesc.Text + "' "
									End If
									Dim flag20 As Boolean = Me.dtPR.Rows.Count > 0
									If flag20 Then
										Dim num As Integer = Convert.ToInt32(RuntimeHelpers.GetObjectValue(Me.dtPR.Compute("SUM(Quantity)", text3)))
										Dim flag21 As Boolean = Conversion.Val(Me.txtQty.Text) < CDbl(num)
										If flag21 Then
											CustomMsgBox.Show("Product Quantity Cannot Be Less Than Required PR Quantity.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
											Me.txtQty.Focus()
											Return False
										End If
									End If
									flag2 = True
								End If
							End If
						End If
					End If
				End If
			End If
			Return flag2
		End Function

		' Token: 0x06001A8B RID: 6795 RVA: 0x000F4AFC File Offset: 0x000F2CFC
		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			Try
				Me.Save()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06001A8C RID: 6796 RVA: 0x000F4B54 File Offset: 0x000F2D54
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
				Me.dtItems.Rows(Me.iRow)("TertiaryUOM") = Me.txtTertiaryUOM.Text
				Me.dtItems.Rows(Me.iRow)("UnitPrice") = Me.txtUnitPrice.Text
				Me.dtItems.Rows(Me.iRow)("Quantity") = Me.txtQty.Text
				Me.dtItems.Rows(Me.iRow)("BasicValue") = Me.txtBasicAmt.Text
				Me.dtItems.Rows(Me.iRow)("DiscountPer") = Conversion.Val(Me.txtDiscPer.Text)
				Me.dtItems.Rows(Me.iRow)("DiscountAmt") = Strings.Format(Conversion.Val(Me.txtDiscAmt.Text), "#0.00")
				Me.dtItems.Rows(Me.iRow)("NetAmt") = Me.txtNetAmt.Text
				Me.dtItems.Rows(Me.iRow)("TaxPer") = Me.cmbTaxPer.Text
				Me.dtItems.Rows(Me.iRow)("TaxAmt") = Strings.Format(Conversion.Val(Me.txtTaxAmt.Text), "#0.00")
				Me.dtItems.Rows(Me.iRow)("Transportation") = Conversion.Val(Me.txtTransportation.Text)
				Me.dtItems.Rows(Me.iRow)("Freight") = Conversion.Val(Me.txtFreight.Text)
				Me.dtItems.Rows(Me.iRow)("LoadingUnloading") = Conversion.Val(Me.txtLoading.Text)
				Me.dtItems.Rows(Me.iRow)("Packing") = Conversion.Val(Me.txtPacking.Text)
				Me.dtItems.Rows(Me.iRow)("OtherCharges") = Conversion.Val(Me.txtOtherCharges.Text)
				Me.dtItems.Rows(Me.iRow)("FinalAmt") = Strings.Format(Conversion.Val(Me.txtFinalAmt.Text), "#0.00")
				MyBase.DialogResult = DialogResult.OK
				MyBase.Close()
			End If
		End Sub

		' Token: 0x04000B76 RID: 2934
		Private iRow As Integer

		' Token: 0x04000B77 RID: 2935
		Private sFormType As String

		' Token: 0x04000B78 RID: 2936
		Private dtProduct As DataTable

		' Token: 0x04000B79 RID: 2937
		Private dtPR As DataTable

		' Token: 0x04000B7A RID: 2938
		Private sStatus As String

		' Token: 0x04000B7B RID: 2939
		Public dtItems As DataTable
	End Class
End Namespace
