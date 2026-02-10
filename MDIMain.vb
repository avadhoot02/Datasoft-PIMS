Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Timers
Imports System.Windows.Forms
Imports Datasoft_PIMS.My
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports WeifenLuo.WinFormsUI.Docking

Namespace Datasoft_PIMS
	' Token: 0x02000023 RID: 35
	<DesignerGenerated()>
	Public Partial Class MDIMain
		Inherits Form

		' Token: 0x1700030B RID: 779
		' (get) Token: 0x060007E3 RID: 2019 RVA: 0x0004A5C1 File Offset: 0x000487C1
		' (set) Token: 0x060007E4 RID: 2020 RVA: 0x0004A5CC File Offset: 0x000487CC
		Friend Overridable Property pnlBar As Panel
			<CompilerGenerated()>
			Get
				Return Me._pnlBar
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim paintEventHandler As PaintEventHandler = AddressOf Me.pnlBar_Paint
				Dim panel As Panel = Me._pnlBar
				If panel IsNot Nothing Then
					RemoveHandler panel.Paint, paintEventHandler
				End If
				Me._pnlBar = value
				panel = Me._pnlBar
				If panel IsNot Nothing Then
					AddHandler panel.Paint, paintEventHandler
				End If
			End Set
		End Property

		' Token: 0x1700030C RID: 780
		' (get) Token: 0x060007E5 RID: 2021 RVA: 0x0004A60F File Offset: 0x0004880F
		' (set) Token: 0x060007E6 RID: 2022 RVA: 0x0004A619 File Offset: 0x00048819
		Friend Overridable Property skip_lblSession As Label

		' Token: 0x1700030D RID: 781
		' (get) Token: 0x060007E7 RID: 2023 RVA: 0x0004A622 File Offset: 0x00048822
		' (set) Token: 0x060007E8 RID: 2024 RVA: 0x0004A62C File Offset: 0x0004882C
		Friend Overridable Property skip_lblMemory As Label

		' Token: 0x1700030E RID: 782
		' (get) Token: 0x060007E9 RID: 2025 RVA: 0x0004A635 File Offset: 0x00048835
		' (set) Token: 0x060007EA RID: 2026 RVA: 0x0004A63F File Offset: 0x0004883F
		Friend Overridable Property skip_lblSessionLabel As Label

		' Token: 0x1700030F RID: 783
		' (get) Token: 0x060007EB RID: 2027 RVA: 0x0004A648 File Offset: 0x00048848
		' (set) Token: 0x060007EC RID: 2028 RVA: 0x0004A652 File Offset: 0x00048852
		Friend Overridable Property pnlHeader As Panel

		' Token: 0x17000310 RID: 784
		' (get) Token: 0x060007ED RID: 2029 RVA: 0x0004A65B File Offset: 0x0004885B
		' (set) Token: 0x060007EE RID: 2030 RVA: 0x0004A665 File Offset: 0x00048865
		Friend Overridable Property PicLogo As PictureBox

		' Token: 0x17000311 RID: 785
		' (get) Token: 0x060007EF RID: 2031 RVA: 0x0004A66E File Offset: 0x0004886E
		' (set) Token: 0x060007F0 RID: 2032 RVA: 0x0004A678 File Offset: 0x00048878
		Friend Overridable Property StatusStrip1 As StatusStrip

		' Token: 0x17000312 RID: 786
		' (get) Token: 0x060007F1 RID: 2033 RVA: 0x0004A681 File Offset: 0x00048881
		' (set) Token: 0x060007F2 RID: 2034 RVA: 0x0004A68B File Offset: 0x0004888B
		Friend Overridable Property ToolStripStatusLabel4 As ToolStripStatusLabel

		' Token: 0x17000313 RID: 787
		' (get) Token: 0x060007F3 RID: 2035 RVA: 0x0004A694 File Offset: 0x00048894
		' (set) Token: 0x060007F4 RID: 2036 RVA: 0x0004A69E File Offset: 0x0004889E
		Friend Overridable Property ToolStripStatusLabel1 As ToolStripStatusLabel

		' Token: 0x17000314 RID: 788
		' (get) Token: 0x060007F5 RID: 2037 RVA: 0x0004A6A7 File Offset: 0x000488A7
		' (set) Token: 0x060007F6 RID: 2038 RVA: 0x0004A6B1 File Offset: 0x000488B1
		Friend Overridable Property gslblServer As ToolStripStatusLabel

		' Token: 0x17000315 RID: 789
		' (get) Token: 0x060007F7 RID: 2039 RVA: 0x0004A6BA File Offset: 0x000488BA
		' (set) Token: 0x060007F8 RID: 2040 RVA: 0x0004A6C4 File Offset: 0x000488C4
		Friend Overridable Property ToolStripStatusLabel2 As ToolStripStatusLabel

		' Token: 0x17000316 RID: 790
		' (get) Token: 0x060007F9 RID: 2041 RVA: 0x0004A6CD File Offset: 0x000488CD
		' (set) Token: 0x060007FA RID: 2042 RVA: 0x0004A6D7 File Offset: 0x000488D7
		Friend Overridable Property ToolStripStatusLabel3 As ToolStripStatusLabel

		' Token: 0x17000317 RID: 791
		' (get) Token: 0x060007FB RID: 2043 RVA: 0x0004A6E0 File Offset: 0x000488E0
		' (set) Token: 0x060007FC RID: 2044 RVA: 0x0004A6EA File Offset: 0x000488EA
		Friend Overridable Property gslblDatabase As ToolStripStatusLabel

		' Token: 0x17000318 RID: 792
		' (get) Token: 0x060007FD RID: 2045 RVA: 0x0004A6F3 File Offset: 0x000488F3
		' (set) Token: 0x060007FE RID: 2046 RVA: 0x0004A6FD File Offset: 0x000488FD
		Friend Overridable Property ToolStripStatusLabel5 As ToolStripStatusLabel

		' Token: 0x17000319 RID: 793
		' (get) Token: 0x060007FF RID: 2047 RVA: 0x0004A706 File Offset: 0x00048906
		' (set) Token: 0x06000800 RID: 2048 RVA: 0x0004A710 File Offset: 0x00048910
		Friend Overridable Property ToolStripStatusLabel7 As ToolStripStatusLabel

		' Token: 0x1700031A RID: 794
		' (get) Token: 0x06000801 RID: 2049 RVA: 0x0004A719 File Offset: 0x00048919
		' (set) Token: 0x06000802 RID: 2050 RVA: 0x0004A723 File Offset: 0x00048923
		Friend Overridable Property ToolStripStatusLabel6 As ToolStripStatusLabel

		' Token: 0x1700031B RID: 795
		' (get) Token: 0x06000803 RID: 2051 RVA: 0x0004A72C File Offset: 0x0004892C
		' (set) Token: 0x06000804 RID: 2052 RVA: 0x0004A738 File Offset: 0x00048938
		Friend Overridable Property picProfile As PictureBox
			<CompilerGenerated()>
			Get
				Return Me._picProfile
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim eventHandler As EventHandler = AddressOf Me.picProfile_Click
				Dim pictureBox As PictureBox = Me._picProfile
				If pictureBox IsNot Nothing Then
					RemoveHandler pictureBox.Click, eventHandler
				End If
				Me._picProfile = value
				pictureBox = Me._picProfile
				If pictureBox IsNot Nothing Then
					AddHandler pictureBox.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700031C RID: 796
		' (get) Token: 0x06000805 RID: 2053 RVA: 0x0004A77B File Offset: 0x0004897B
		' (set) Token: 0x06000806 RID: 2054 RVA: 0x0004A785 File Offset: 0x00048985
		Friend Overridable Property picSSDatacode As PictureBox

		' Token: 0x1700031D RID: 797
		' (get) Token: 0x06000807 RID: 2055 RVA: 0x0004A78E File Offset: 0x0004898E
		' (set) Token: 0x06000808 RID: 2056 RVA: 0x0004A798 File Offset: 0x00048998
		Friend Overridable Property DockPanel As DockPanel
			<CompilerGenerated()>
			Get
				Return Me._DockPanel
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DockPanel)
				Dim eventHandler As EventHandler(Of DockContentEventArgs) = AddressOf Me.DockPanel_ContentAdded
				Dim eventHandler2 As EventHandler(Of DockContentEventArgs) = AddressOf Me.DockPanel_ContentRemoved
				Dim dockPanel As DockPanel = Me._DockPanel
				If dockPanel IsNot Nothing Then
					RemoveHandler dockPanel.ContentAdded, eventHandler
					RemoveHandler dockPanel.ContentRemoved, eventHandler2
				End If
				Me._DockPanel = value
				dockPanel = Me._DockPanel
				If dockPanel IsNot Nothing Then
					AddHandler dockPanel.ContentAdded, eventHandler
					AddHandler dockPanel.ContentRemoved, eventHandler2
				End If
			End Set
		End Property

		' Token: 0x1700031E RID: 798
		' (get) Token: 0x06000809 RID: 2057 RVA: 0x0004A7F6 File Offset: 0x000489F6
		' (set) Token: 0x0600080A RID: 2058 RVA: 0x0004A800 File Offset: 0x00048A00
		Friend Overridable Property lblLogin As Label

		' Token: 0x1700031F RID: 799
		' (get) Token: 0x0600080B RID: 2059 RVA: 0x0004A809 File Offset: 0x00048A09
		' (set) Token: 0x0600080C RID: 2060 RVA: 0x0004A813 File Offset: 0x00048A13
		Friend Overridable Property pnlLogin As Panel

		' Token: 0x17000320 RID: 800
		' (get) Token: 0x0600080D RID: 2061 RVA: 0x0004A81C File Offset: 0x00048A1C
		' (set) Token: 0x0600080E RID: 2062 RVA: 0x0004A826 File Offset: 0x00048A26
		Friend Overridable Property picPwd As PictureBox

		' Token: 0x17000321 RID: 801
		' (get) Token: 0x0600080F RID: 2063 RVA: 0x0004A82F File Offset: 0x00048A2F
		' (set) Token: 0x06000810 RID: 2064 RVA: 0x0004A839 File Offset: 0x00048A39
		Friend Overridable Property picUser As PictureBox

		' Token: 0x17000322 RID: 802
		' (get) Token: 0x06000811 RID: 2065 RVA: 0x0004A842 File Offset: 0x00048A42
		' (set) Token: 0x06000812 RID: 2066 RVA: 0x0004A84C File Offset: 0x00048A4C
		Friend Overridable Property btnOK As Button
			<CompilerGenerated()>
			Get
				Return Me._btnOK
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnOK_Click
				Dim button As Button = Me._btnOK
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnOK = value
				button = Me._btnOK
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000323 RID: 803
		' (get) Token: 0x06000813 RID: 2067 RVA: 0x0004A88F File Offset: 0x00048A8F
		' (set) Token: 0x06000814 RID: 2068 RVA: 0x0004A89C File Offset: 0x00048A9C
		Friend Overridable Property skip_txtPass As TextBox
			<CompilerGenerated()>
			Get
				Return Me._skip_txtPass
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim eventHandler As EventHandler = AddressOf Me.txtPass_GotFocus
				Dim eventHandler2 As EventHandler = AddressOf Me.txtPass_LostFocus
				Dim eventHandler3 As EventHandler = AddressOf Me.txtPass_TextChanged
				Dim textBox As TextBox = Me._skip_txtPass
				If textBox IsNot Nothing Then
					RemoveHandler textBox.GotFocus, eventHandler
					RemoveHandler textBox.LostFocus, eventHandler2
					RemoveHandler textBox.TextChanged, eventHandler3
				End If
				Me._skip_txtPass = value
				textBox = Me._skip_txtPass
				If textBox IsNot Nothing Then
					AddHandler textBox.GotFocus, eventHandler
					AddHandler textBox.LostFocus, eventHandler2
					AddHandler textBox.TextChanged, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x17000324 RID: 804
		' (get) Token: 0x06000815 RID: 2069 RVA: 0x0004A915 File Offset: 0x00048B15
		' (set) Token: 0x06000816 RID: 2070 RVA: 0x0004A920 File Offset: 0x00048B20
		Friend Overridable Property skip_txtUser As TextBox
			<CompilerGenerated()>
			Get
				Return Me._skip_txtUser
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim eventHandler As EventHandler = AddressOf Me.txtUser_GotFocus
				Dim eventHandler2 As EventHandler = AddressOf Me.txtUser_LostFocus
				Dim eventHandler3 As EventHandler = AddressOf Me.txtUser_TextChanged
				Dim keyEventHandler As KeyEventHandler = AddressOf Me.skip_txtUser_KeyDown
				Dim textBox As TextBox = Me._skip_txtUser
				If textBox IsNot Nothing Then
					RemoveHandler textBox.GotFocus, eventHandler
					RemoveHandler textBox.LostFocus, eventHandler2
					RemoveHandler textBox.TextChanged, eventHandler3
					RemoveHandler textBox.KeyDown, keyEventHandler
				End If
				Me._skip_txtUser = value
				textBox = Me._skip_txtUser
				If textBox IsNot Nothing Then
					AddHandler textBox.GotFocus, eventHandler
					AddHandler textBox.LostFocus, eventHandler2
					AddHandler textBox.TextChanged, eventHandler3
					AddHandler textBox.KeyDown, keyEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000325 RID: 805
		' (get) Token: 0x06000817 RID: 2071 RVA: 0x0004A9C0 File Offset: 0x00048BC0
		' (set) Token: 0x06000818 RID: 2072 RVA: 0x0004A9CA File Offset: 0x00048BCA
		Friend Overridable Property pnlProfile As Panel

		' Token: 0x17000326 RID: 806
		' (get) Token: 0x06000819 RID: 2073 RVA: 0x0004A9D3 File Offset: 0x00048BD3
		' (set) Token: 0x0600081A RID: 2074 RVA: 0x0004A9E0 File Offset: 0x00048BE0
		Friend Overridable Property sml_btnSignOut As Button
			<CompilerGenerated()>
			Get
				Return Me._sml_btnSignOut
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnSignOut_Click
				Dim button As Button = Me._sml_btnSignOut
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._sml_btnSignOut = value
				button = Me._sml_btnSignOut
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000327 RID: 807
		' (get) Token: 0x0600081B RID: 2075 RVA: 0x0004AA23 File Offset: 0x00048C23
		' (set) Token: 0x0600081C RID: 2076 RVA: 0x0004AA2D File Offset: 0x00048C2D
		Friend Overridable Property gslblPlant As Label

		' Token: 0x17000328 RID: 808
		' (get) Token: 0x0600081D RID: 2077 RVA: 0x0004AA36 File Offset: 0x00048C36
		' (set) Token: 0x0600081E RID: 2078 RVA: 0x0004AA40 File Offset: 0x00048C40
		Friend Overridable Property gslblCompany As Label

		' Token: 0x17000329 RID: 809
		' (get) Token: 0x0600081F RID: 2079 RVA: 0x0004AA49 File Offset: 0x00048C49
		' (set) Token: 0x06000820 RID: 2080 RVA: 0x0004AA53 File Offset: 0x00048C53
		Friend Overridable Property gslblUser As Label

		' Token: 0x1700032A RID: 810
		' (get) Token: 0x06000821 RID: 2081 RVA: 0x0004AA5C File Offset: 0x00048C5C
		' (set) Token: 0x06000822 RID: 2082 RVA: 0x0004AA68 File Offset: 0x00048C68
		Friend Overridable Property profileTimer As Global.System.Windows.Forms.Timer
			<CompilerGenerated()>
			Get
				Return Me._profileTimer
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Global.System.Windows.Forms.Timer)
				Dim eventHandler As EventHandler = AddressOf Me.profileTimer_Tick
				Dim timer As Global.System.Windows.Forms.Timer = Me._profileTimer
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, eventHandler
				End If
				Me._profileTimer = value
				timer = Me._profileTimer
				If timer IsNot Nothing Then
					AddHandler timer.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700032B RID: 811
		' (get) Token: 0x06000823 RID: 2083 RVA: 0x0004AAAB File Offset: 0x00048CAB
		' (set) Token: 0x06000824 RID: 2084 RVA: 0x0004AAB8 File Offset: 0x00048CB8
		Friend Overridable Property skip_btnShow As Button
			<CompilerGenerated()>
			Get
				Return Me._skip_btnShow
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.skip_btnShow_MouseDown
				Dim mouseEventHandler2 As MouseEventHandler = AddressOf Me.skip_btnShow_MouseUp
				Dim button As Button = Me._skip_btnShow
				If button IsNot Nothing Then
					RemoveHandler button.MouseDown, mouseEventHandler
					RemoveHandler button.MouseUp, mouseEventHandler2
				End If
				Me._skip_btnShow = value
				button = Me._skip_btnShow
				If button IsNot Nothing Then
					AddHandler button.MouseDown, mouseEventHandler
					AddHandler button.MouseUp, mouseEventHandler2
				End If
			End Set
		End Property

		' Token: 0x1700032C RID: 812
		' (get) Token: 0x06000825 RID: 2085 RVA: 0x0004AB16 File Offset: 0x00048D16
		' (set) Token: 0x06000826 RID: 2086 RVA: 0x0004AB20 File Offset: 0x00048D20
		Friend Overridable Property MemoryTimer As Global.System.Windows.Forms.Timer
			<CompilerGenerated()>
			Get
				Return Me._MemoryTimer
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Global.System.Windows.Forms.Timer)
				Dim eventHandler As EventHandler = AddressOf Me.MemoryTimer_Tick
				Dim timer As Global.System.Windows.Forms.Timer = Me._MemoryTimer
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, eventHandler
				End If
				Me._MemoryTimer = value
				timer = Me._MemoryTimer
				If timer IsNot Nothing Then
					AddHandler timer.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700032D RID: 813
		' (get) Token: 0x06000827 RID: 2087 RVA: 0x0004AB63 File Offset: 0x00048D63
		' (set) Token: 0x06000828 RID: 2088 RVA: 0x0004AB6D File Offset: 0x00048D6D
		Friend Overridable Property mnuMain As MenuStrip

		' Token: 0x1700032E RID: 814
		' (get) Token: 0x06000829 RID: 2089 RVA: 0x0004AB76 File Offset: 0x00048D76
		' (set) Token: 0x0600082A RID: 2090 RVA: 0x0004AB80 File Offset: 0x00048D80
		Friend Overridable Property mnuMasters As ToolStripMenuItem

		' Token: 0x1700032F RID: 815
		' (get) Token: 0x0600082B RID: 2091 RVA: 0x0004AB89 File Offset: 0x00048D89
		' (set) Token: 0x0600082C RID: 2092 RVA: 0x0004AB94 File Offset: 0x00048D94
		Friend Overridable Property mnuProduct As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuProduct
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuProduct_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuProduct
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuProduct = value
				toolStripMenuItem = Me._mnuProduct
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000330 RID: 816
		' (get) Token: 0x0600082D RID: 2093 RVA: 0x0004ABD7 File Offset: 0x00048DD7
		' (set) Token: 0x0600082E RID: 2094 RVA: 0x0004ABE4 File Offset: 0x00048DE4
		Friend Overridable Property mnuUser As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuUser
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuUser_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuUser
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuUser = value
				toolStripMenuItem = Me._mnuUser
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000331 RID: 817
		' (get) Token: 0x0600082F RID: 2095 RVA: 0x0004AC27 File Offset: 0x00048E27
		' (set) Token: 0x06000830 RID: 2096 RVA: 0x0004AC34 File Offset: 0x00048E34
		Friend Overridable Property mnuUserGroup As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuUserGroup
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuUserGroup_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuUserGroup
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuUserGroup = value
				toolStripMenuItem = Me._mnuUserGroup
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000332 RID: 818
		' (get) Token: 0x06000831 RID: 2097 RVA: 0x0004AC77 File Offset: 0x00048E77
		' (set) Token: 0x06000832 RID: 2098 RVA: 0x0004AC81 File Offset: 0x00048E81
		Friend Overridable Property mnuPurchase As ToolStripMenuItem

		' Token: 0x17000333 RID: 819
		' (get) Token: 0x06000833 RID: 2099 RVA: 0x0004AC8A File Offset: 0x00048E8A
		' (set) Token: 0x06000834 RID: 2100 RVA: 0x0004AC94 File Offset: 0x00048E94
		Friend Overridable Property mnuMISReports As ToolStripMenuItem

		' Token: 0x17000334 RID: 820
		' (get) Token: 0x06000835 RID: 2101 RVA: 0x0004AC9D File Offset: 0x00048E9D
		' (set) Token: 0x06000836 RID: 2102 RVA: 0x0004ACA8 File Offset: 0x00048EA8
		Friend Overridable Property mnuActivityLog As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuActivityLog
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuActivityLog_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuActivityLog
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuActivityLog = value
				toolStripMenuItem = Me._mnuActivityLog
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000335 RID: 821
		' (get) Token: 0x06000837 RID: 2103 RVA: 0x0004ACEB File Offset: 0x00048EEB
		' (set) Token: 0x06000838 RID: 2104 RVA: 0x0004ACF5 File Offset: 0x00048EF5
		Friend Overridable Property mnuSettings As ToolStripMenuItem

		' Token: 0x17000336 RID: 822
		' (get) Token: 0x06000839 RID: 2105 RVA: 0x0004ACFE File Offset: 0x00048EFE
		' (set) Token: 0x0600083A RID: 2106 RVA: 0x0004AD08 File Offset: 0x00048F08
		Friend Overridable Property mnuChangePassword As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuChangePassword
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuChangePassword_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuChangePassword
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuChangePassword = value
				toolStripMenuItem = Me._mnuChangePassword
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000337 RID: 823
		' (get) Token: 0x0600083B RID: 2107 RVA: 0x0004AD4B File Offset: 0x00048F4B
		' (set) Token: 0x0600083C RID: 2108 RVA: 0x0004AD58 File Offset: 0x00048F58
		Friend Overridable Property mnuEmailAlertSettings As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuEmailAlertSettings
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuEmailAlerts_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuEmailAlertSettings
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuEmailAlertSettings = value
				toolStripMenuItem = Me._mnuEmailAlertSettings
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000338 RID: 824
		' (get) Token: 0x0600083D RID: 2109 RVA: 0x0004AD9B File Offset: 0x00048F9B
		' (set) Token: 0x0600083E RID: 2110 RVA: 0x0004ADA8 File Offset: 0x00048FA8
		Friend Overridable Property mnuAbout As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuAbout
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuAbout_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuAbout
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuAbout = value
				toolStripMenuItem = Me._mnuAbout
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000339 RID: 825
		' (get) Token: 0x0600083F RID: 2111 RVA: 0x0004ADEB File Offset: 0x00048FEB
		' (set) Token: 0x06000840 RID: 2112 RVA: 0x0004ADF8 File Offset: 0x00048FF8
		Friend Overridable Property mnuEmailTest As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuEmailTest
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuEmailTest_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuEmailTest
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuEmailTest = value
				toolStripMenuItem = Me._mnuEmailTest
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700033A RID: 826
		' (get) Token: 0x06000841 RID: 2113 RVA: 0x0004AE3B File Offset: 0x0004903B
		' (set) Token: 0x06000842 RID: 2114 RVA: 0x0004AE48 File Offset: 0x00049048
		Friend Overridable Property mnuVendor As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuVendor
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuVendor_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuVendor
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuVendor = value
				toolStripMenuItem = Me._mnuVendor
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700033B RID: 827
		' (get) Token: 0x06000843 RID: 2115 RVA: 0x0004AE8B File Offset: 0x0004908B
		' (set) Token: 0x06000844 RID: 2116 RVA: 0x0004AE98 File Offset: 0x00049098
		Friend Overridable Property mnuLocation As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuLocation
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuLocation_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuLocation
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuLocation = value
				toolStripMenuItem = Me._mnuLocation
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700033C RID: 828
		' (get) Token: 0x06000845 RID: 2117 RVA: 0x0004AEDB File Offset: 0x000490DB
		' (set) Token: 0x06000846 RID: 2118 RVA: 0x0004AEE8 File Offset: 0x000490E8
		Friend Overridable Property mnuPOCreation As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuPOCreation
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuPOCreation_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuPOCreation
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuPOCreation = value
				toolStripMenuItem = Me._mnuPOCreation
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700033D RID: 829
		' (get) Token: 0x06000847 RID: 2119 RVA: 0x0004AF2B File Offset: 0x0004912B
		' (set) Token: 0x06000848 RID: 2120 RVA: 0x0004AF38 File Offset: 0x00049138
		Friend Overridable Property mnuPOModification As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuPOModification
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuPOModfication_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuPOModification
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuPOModification = value
				toolStripMenuItem = Me._mnuPOModification
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700033E RID: 830
		' (get) Token: 0x06000849 RID: 2121 RVA: 0x0004AF7B File Offset: 0x0004917B
		' (set) Token: 0x0600084A RID: 2122 RVA: 0x0004AF88 File Offset: 0x00049188
		Friend Overridable Property mnuPOApproval As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuPOApproval
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuPOApproval_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuPOApproval
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuPOApproval = value
				toolStripMenuItem = Me._mnuPOApproval
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700033F RID: 831
		' (get) Token: 0x0600084B RID: 2123 RVA: 0x0004AFCB File Offset: 0x000491CB
		' (set) Token: 0x0600084C RID: 2124 RVA: 0x0004AFD8 File Offset: 0x000491D8
		Friend Overridable Property mnuPOAmendment As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuPOAmendment
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuPOAmmendment_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuPOAmendment
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuPOAmendment = value
				toolStripMenuItem = Me._mnuPOAmendment
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000340 RID: 832
		' (get) Token: 0x0600084D RID: 2125 RVA: 0x0004B01B File Offset: 0x0004921B
		' (set) Token: 0x0600084E RID: 2126 RVA: 0x0004B025 File Offset: 0x00049225
		Friend Overridable Property mnuInventory As ToolStripMenuItem

		' Token: 0x17000341 RID: 833
		' (get) Token: 0x0600084F RID: 2127 RVA: 0x0004B02E File Offset: 0x0004922E
		' (set) Token: 0x06000850 RID: 2128 RVA: 0x0004B038 File Offset: 0x00049238
		Friend Overridable Property mnuGRN As ToolStripMenuItem

		' Token: 0x17000342 RID: 834
		' (get) Token: 0x06000851 RID: 2129 RVA: 0x0004B041 File Offset: 0x00049241
		' (set) Token: 0x06000852 RID: 2130 RVA: 0x0004B04C File Offset: 0x0004924C
		Friend Overridable Property mnuQCRelease As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuQCRelease
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuQC_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuQCRelease
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuQCRelease = value
				toolStripMenuItem = Me._mnuQCRelease
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000343 RID: 835
		' (get) Token: 0x06000853 RID: 2131 RVA: 0x0004B08F File Offset: 0x0004928F
		' (set) Token: 0x06000854 RID: 2132 RVA: 0x0004B099 File Offset: 0x00049299
		Friend Overridable Property mnuVendorReturn As ToolStripMenuItem

		' Token: 0x17000344 RID: 836
		' (get) Token: 0x06000855 RID: 2133 RVA: 0x0004B0A2 File Offset: 0x000492A2
		' (set) Token: 0x06000856 RID: 2134 RVA: 0x0004B0AC File Offset: 0x000492AC
		Friend Overridable Property mnuMaterialRequest As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuMaterialRequest
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuMaterialRequest_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuMaterialRequest
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuMaterialRequest = value
				toolStripMenuItem = Me._mnuMaterialRequest
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000345 RID: 837
		' (get) Token: 0x06000857 RID: 2135 RVA: 0x0004B0EF File Offset: 0x000492EF
		' (set) Token: 0x06000858 RID: 2136 RVA: 0x0004B0FC File Offset: 0x000492FC
		Friend Overridable Property mnuQAApproval As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuQAApproval
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuQAApproval_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuQAApproval
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuQAApproval = value
				toolStripMenuItem = Me._mnuQAApproval
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000346 RID: 838
		' (get) Token: 0x06000859 RID: 2137 RVA: 0x0004B13F File Offset: 0x0004933F
		' (set) Token: 0x0600085A RID: 2138 RVA: 0x0004B14C File Offset: 0x0004934C
		Friend Overridable Property mnuMaterialIssue As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuMaterialIssue
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuMaterialIssue_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuMaterialIssue
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuMaterialIssue = value
				toolStripMenuItem = Me._mnuMaterialIssue
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000347 RID: 839
		' (get) Token: 0x0600085B RID: 2139 RVA: 0x0004B18F File Offset: 0x0004938F
		' (set) Token: 0x0600085C RID: 2140 RVA: 0x0004B19C File Offset: 0x0004939C
		Friend Overridable Property mnuPOReport As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuPOReport
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuPOReport_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuPOReport
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuPOReport = value
				toolStripMenuItem = Me._mnuPOReport
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000348 RID: 840
		' (get) Token: 0x0600085D RID: 2141 RVA: 0x0004B1DF File Offset: 0x000493DF
		' (set) Token: 0x0600085E RID: 2142 RVA: 0x0004B1EC File Offset: 0x000493EC
		Friend Overridable Property mnuGRNReport As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuGRNReport
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuGRNReport_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuGRNReport
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuGRNReport = value
				toolStripMenuItem = Me._mnuGRNReport
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000349 RID: 841
		' (get) Token: 0x0600085F RID: 2143 RVA: 0x0004B22F File Offset: 0x0004942F
		' (set) Token: 0x06000860 RID: 2144 RVA: 0x0004B23C File Offset: 0x0004943C
		Friend Overridable Property mnuRequestReport As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuRequestReport
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuRequestReport_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuRequestReport
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuRequestReport = value
				toolStripMenuItem = Me._mnuRequestReport
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700034A RID: 842
		' (get) Token: 0x06000861 RID: 2145 RVA: 0x0004B27F File Offset: 0x0004947F
		' (set) Token: 0x06000862 RID: 2146 RVA: 0x0004B28C File Offset: 0x0004948C
		Friend Overridable Property mnuGRNPrinting As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuGRNPrinting
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuGRNPrinting_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuGRNPrinting
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuGRNPrinting = value
				toolStripMenuItem = Me._mnuGRNPrinting
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700034B RID: 843
		' (get) Token: 0x06000863 RID: 2147 RVA: 0x0004B2CF File Offset: 0x000494CF
		' (set) Token: 0x06000864 RID: 2148 RVA: 0x0004B2DC File Offset: 0x000494DC
		Friend Overridable Property mnuLocationMapping As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuLocationMapping
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuLocationMapping_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuLocationMapping
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuLocationMapping = value
				toolStripMenuItem = Me._mnuLocationMapping
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700034C RID: 844
		' (get) Token: 0x06000865 RID: 2149 RVA: 0x0004B31F File Offset: 0x0004951F
		' (set) Token: 0x06000866 RID: 2150 RVA: 0x0004B32C File Offset: 0x0004952C
		Friend Overridable Property mnuPicking As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuPicking
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuPicking_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuPicking
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuPicking = value
				toolStripMenuItem = Me._mnuPicking
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700034D RID: 845
		' (get) Token: 0x06000867 RID: 2151 RVA: 0x0004B36F File Offset: 0x0004956F
		' (set) Token: 0x06000868 RID: 2152 RVA: 0x0004B379 File Offset: 0x00049579
		Friend Overridable Property mnuGRNApproval As ToolStripMenuItem

		' Token: 0x1700034E RID: 846
		' (get) Token: 0x06000869 RID: 2153 RVA: 0x0004B382 File Offset: 0x00049582
		' (set) Token: 0x0600086A RID: 2154 RVA: 0x0004B38C File Offset: 0x0004958C
		Friend Overridable Property mnuPOPrinting As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuPOPrinting
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuPOPrinting_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuPOPrinting
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuPOPrinting = value
				toolStripMenuItem = Me._mnuPOPrinting
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700034F RID: 847
		' (get) Token: 0x0600086B RID: 2155 RVA: 0x0004B3CF File Offset: 0x000495CF
		' (set) Token: 0x0600086C RID: 2156 RVA: 0x0004B3DC File Offset: 0x000495DC
		Friend Overridable Property mnuStockReport As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuStockReport
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuStockReport_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuStockReport
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuStockReport = value
				toolStripMenuItem = Me._mnuStockReport
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000350 RID: 848
		' (get) Token: 0x0600086D RID: 2157 RVA: 0x0004B41F File Offset: 0x0004961F
		' (set) Token: 0x0600086E RID: 2158 RVA: 0x0004B42C File Offset: 0x0004962C
		Friend Overridable Property mnuQCEntry As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuQCEntry
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuQCEntry_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuQCEntry
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuQCEntry = value
				toolStripMenuItem = Me._mnuQCEntry
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000351 RID: 849
		' (get) Token: 0x0600086F RID: 2159 RVA: 0x0004B46F File Offset: 0x0004966F
		' (set) Token: 0x06000870 RID: 2160 RVA: 0x0004B47C File Offset: 0x0004967C
		Friend Overridable Property mnuTest As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuTest
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuTest_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuTest
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuTest = value
				toolStripMenuItem = Me._mnuTest
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000352 RID: 850
		' (get) Token: 0x06000871 RID: 2161 RVA: 0x0004B4BF File Offset: 0x000496BF
		' (set) Token: 0x06000872 RID: 2162 RVA: 0x0004B4CC File Offset: 0x000496CC
		Friend Overridable Property mnuGRNCancellation As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuGRNCancellation
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuGRNCancellation_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuGRNCancellation
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuGRNCancellation = value
				toolStripMenuItem = Me._mnuGRNCancellation
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000353 RID: 851
		' (get) Token: 0x06000873 RID: 2163 RVA: 0x0004B50F File Offset: 0x0004970F
		' (set) Token: 0x06000874 RID: 2164 RVA: 0x0004B51C File Offset: 0x0004971C
		Friend Overridable Property mnuConsumptionReport As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuConsumptionReport
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuConsumptionReport_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuConsumptionReport
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuConsumptionReport = value
				toolStripMenuItem = Me._mnuConsumptionReport
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000354 RID: 852
		' (get) Token: 0x06000875 RID: 2165 RVA: 0x0004B55F File Offset: 0x0004975F
		' (set) Token: 0x06000876 RID: 2166 RVA: 0x0004B56C File Offset: 0x0004976C
		Friend Overridable Property mnuClosingStockReport As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuClosingStockReport
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuClosingStockReport_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuClosingStockReport
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuClosingStockReport = value
				toolStripMenuItem = Me._mnuClosingStockReport
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000355 RID: 853
		' (get) Token: 0x06000877 RID: 2167 RVA: 0x0004B5AF File Offset: 0x000497AF
		' (set) Token: 0x06000878 RID: 2168 RVA: 0x0004B5BC File Offset: 0x000497BC
		Friend Overridable Property mnuQuarentineStockReport As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuQuarentineStockReport
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuQuarentineStockReport_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuQuarentineStockReport
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuQuarentineStockReport = value
				toolStripMenuItem = Me._mnuQuarentineStockReport
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000356 RID: 854
		' (get) Token: 0x06000879 RID: 2169 RVA: 0x0004B5FF File Offset: 0x000497FF
		' (set) Token: 0x0600087A RID: 2170 RVA: 0x0004B60C File Offset: 0x0004980C
		Friend Overridable Property mnuDispose As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuDispose
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuDispose_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuDispose
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuDispose = value
				toolStripMenuItem = Me._mnuDispose
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000357 RID: 855
		' (get) Token: 0x0600087B RID: 2171 RVA: 0x0004B64F File Offset: 0x0004984F
		' (set) Token: 0x0600087C RID: 2172 RVA: 0x0004B659 File Offset: 0x00049859
		Friend Overridable Property skip_lblSanbox As Label

		' Token: 0x17000358 RID: 856
		' (get) Token: 0x0600087D RID: 2173 RVA: 0x0004B662 File Offset: 0x00049862
		' (set) Token: 0x0600087E RID: 2174 RVA: 0x0004B66C File Offset: 0x0004986C
		Friend Overridable Property mnuStockUpload As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuStockUpload
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuStockUpload_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuStockUpload
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuStockUpload = value
				toolStripMenuItem = Me._mnuStockUpload
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000359 RID: 857
		' (get) Token: 0x0600087F RID: 2175 RVA: 0x0004B6AF File Offset: 0x000498AF
		' (set) Token: 0x06000880 RID: 2176 RVA: 0x0004B6BC File Offset: 0x000498BC
		Friend Overridable Property mnuPRApproverList As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuPRApproverList
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuPRApproverList_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuPRApproverList
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuPRApproverList = value
				toolStripMenuItem = Me._mnuPRApproverList
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700035A RID: 858
		' (get) Token: 0x06000881 RID: 2177 RVA: 0x0004B6FF File Offset: 0x000498FF
		' (set) Token: 0x06000882 RID: 2178 RVA: 0x0004B709 File Offset: 0x00049909
		Friend Overridable Property mnuReq As ToolStripMenuItem

		' Token: 0x1700035B RID: 859
		' (get) Token: 0x06000883 RID: 2179 RVA: 0x0004B712 File Offset: 0x00049912
		' (set) Token: 0x06000884 RID: 2180 RVA: 0x0004B71C File Offset: 0x0004991C
		Friend Overridable Property mnuPRCreation As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuPRCreation
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuPRCreation_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuPRCreation
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuPRCreation = value
				toolStripMenuItem = Me._mnuPRCreation
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700035C RID: 860
		' (get) Token: 0x06000885 RID: 2181 RVA: 0x0004B75F File Offset: 0x0004995F
		' (set) Token: 0x06000886 RID: 2182 RVA: 0x0004B76C File Offset: 0x0004996C
		Friend Overridable Property mnuPRModification As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuPRModification
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuPRModfication_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuPRModification
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuPRModification = value
				toolStripMenuItem = Me._mnuPRModification
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700035D RID: 861
		' (get) Token: 0x06000887 RID: 2183 RVA: 0x0004B7AF File Offset: 0x000499AF
		' (set) Token: 0x06000888 RID: 2184 RVA: 0x0004B7BC File Offset: 0x000499BC
		Friend Overridable Property mnuPRApproval As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuPRApproval
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuPRApproval_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuPRApproval
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuPRApproval = value
				toolStripMenuItem = Me._mnuPRApproval
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700035E RID: 862
		' (get) Token: 0x06000889 RID: 2185 RVA: 0x0004B7FF File Offset: 0x000499FF
		' (set) Token: 0x0600088A RID: 2186 RVA: 0x0004B80C File Offset: 0x00049A0C
		Friend Overridable Property mnuReceipt As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuReceipt
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuReceipt_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuReceipt
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuReceipt = value
				toolStripMenuItem = Me._mnuReceipt
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700035F RID: 863
		' (get) Token: 0x0600088B RID: 2187 RVA: 0x0004B84F File Offset: 0x00049A4F
		' (set) Token: 0x0600088C RID: 2188 RVA: 0x0004B85C File Offset: 0x00049A5C
		Friend Overridable Property mnuPO As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuPO
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuPO_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuPO
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuPO = value
				toolStripMenuItem = Me._mnuPO
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000360 RID: 864
		' (get) Token: 0x0600088D RID: 2189 RVA: 0x0004B89F File Offset: 0x00049A9F
		' (set) Token: 0x0600088E RID: 2190 RVA: 0x0004B8AC File Offset: 0x00049AAC
		Friend Overridable Property mnuBMR As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuBMR
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuBMR_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuBMR
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuBMR = value
				toolStripMenuItem = Me._mnuBMR
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000361 RID: 865
		' (get) Token: 0x0600088F RID: 2191 RVA: 0x0004B8EF File Offset: 0x00049AEF
		' (set) Token: 0x06000890 RID: 2192 RVA: 0x0004B8FC File Offset: 0x00049AFC
		Friend Overridable Property mnuReturn As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuReturn
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuReturn_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuReturn
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuReturn = value
				toolStripMenuItem = Me._mnuReturn
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000362 RID: 866
		' (get) Token: 0x06000891 RID: 2193 RVA: 0x0004B93F File Offset: 0x00049B3F
		' (set) Token: 0x06000892 RID: 2194 RVA: 0x0004B949 File Offset: 0x00049B49
		Friend Overridable Property mnuGRNModification As ToolStripMenuItem

		' Token: 0x17000363 RID: 867
		' (get) Token: 0x06000893 RID: 2195 RVA: 0x0004B952 File Offset: 0x00049B52
		' (set) Token: 0x06000894 RID: 2196 RVA: 0x0004B95C File Offset: 0x00049B5C
		Friend Overridable Property mnuConcentration As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuConcentration
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuConcentration_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuConcentration
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuConcentration = value
				toolStripMenuItem = Me._mnuConcentration
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000364 RID: 868
		' (get) Token: 0x06000895 RID: 2197 RVA: 0x0004B99F File Offset: 0x00049B9F
		' (set) Token: 0x06000896 RID: 2198 RVA: 0x0004B9AC File Offset: 0x00049BAC
		Friend Overridable Property mnuPRReport As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuPRReport
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuPRReport_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuPRReport
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuPRReport = value
				toolStripMenuItem = Me._mnuPRReport
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000365 RID: 869
		' (get) Token: 0x06000897 RID: 2199 RVA: 0x0004B9EF File Offset: 0x00049BEF
		' (set) Token: 0x06000898 RID: 2200 RVA: 0x0004B9FC File Offset: 0x00049BFC
		Friend Overridable Property mnuReceipt_Modify As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuReceipt_Modify
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuReceipt_Modify_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuReceipt_Modify
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuReceipt_Modify = value
				toolStripMenuItem = Me._mnuReceipt_Modify
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000366 RID: 870
		' (get) Token: 0x06000899 RID: 2201 RVA: 0x0004BA3F File Offset: 0x00049C3F
		' (set) Token: 0x0600089A RID: 2202 RVA: 0x0004BA4C File Offset: 0x00049C4C
		Friend Overridable Property mnuPO_Modify As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuPO_Modify
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuPO_Modify_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuPO_Modify
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuPO_Modify = value
				toolStripMenuItem = Me._mnuPO_Modify
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000367 RID: 871
		' (get) Token: 0x0600089B RID: 2203 RVA: 0x0004BA8F File Offset: 0x00049C8F
		' (set) Token: 0x0600089C RID: 2204 RVA: 0x0004BA9C File Offset: 0x00049C9C
		Friend Overridable Property mnuBMR_Modify As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuBMR_Modify
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuBMR_Modify_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuBMR_Modify
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuBMR_Modify = value
				toolStripMenuItem = Me._mnuBMR_Modify
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000368 RID: 872
		' (get) Token: 0x0600089D RID: 2205 RVA: 0x0004BADF File Offset: 0x00049CDF
		' (set) Token: 0x0600089E RID: 2206 RVA: 0x0004BAEC File Offset: 0x00049CEC
		Friend Overridable Property mnuReturn_Modify As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuReturn_Modify
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuReturn_Modify_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuReturn_Modify
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuReturn_Modify = value
				toolStripMenuItem = Me._mnuReturn_Modify
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000369 RID: 873
		' (get) Token: 0x0600089F RID: 2207 RVA: 0x0004BB2F File Offset: 0x00049D2F
		' (set) Token: 0x060008A0 RID: 2208 RVA: 0x0004BB3C File Offset: 0x00049D3C
		Friend Overridable Property mnuReceipt_Approval As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuReceipt_Approval
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuReceipt_Approval_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuReceipt_Approval
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuReceipt_Approval = value
				toolStripMenuItem = Me._mnuReceipt_Approval
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700036A RID: 874
		' (get) Token: 0x060008A1 RID: 2209 RVA: 0x0004BB7F File Offset: 0x00049D7F
		' (set) Token: 0x060008A2 RID: 2210 RVA: 0x0004BB8C File Offset: 0x00049D8C
		Friend Overridable Property mnuPO_Approval As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuPO_Approval
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuPO_Approval_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuPO_Approval
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuPO_Approval = value
				toolStripMenuItem = Me._mnuPO_Approval
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700036B RID: 875
		' (get) Token: 0x060008A3 RID: 2211 RVA: 0x0004BBCF File Offset: 0x00049DCF
		' (set) Token: 0x060008A4 RID: 2212 RVA: 0x0004BBDC File Offset: 0x00049DDC
		Friend Overridable Property mnuBMR_Approval As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuBMR_Approval
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuBMR_Approval_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuBMR_Approval
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuBMR_Approval = value
				toolStripMenuItem = Me._mnuBMR_Approval
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700036C RID: 876
		' (get) Token: 0x060008A5 RID: 2213 RVA: 0x0004BC1F File Offset: 0x00049E1F
		' (set) Token: 0x060008A6 RID: 2214 RVA: 0x0004BC2C File Offset: 0x00049E2C
		Friend Overridable Property mnuReturn_Approval As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuReturn_Approval
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuReturn_Approval_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuReturn_Approval
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuReturn_Approval = value
				toolStripMenuItem = Me._mnuReturn_Approval
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700036D RID: 877
		' (get) Token: 0x060008A7 RID: 2215 RVA: 0x0004BC6F File Offset: 0x00049E6F
		' (set) Token: 0x060008A8 RID: 2216 RVA: 0x0004BC7C File Offset: 0x00049E7C
		Friend Overridable Property mnuProductBOMReport As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuProductBOMReport
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuProductBOMReport_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuProductBOMReport
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuProductBOMReport = value
				toolStripMenuItem = Me._mnuProductBOMReport
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700036E RID: 878
		' (get) Token: 0x060008A9 RID: 2217 RVA: 0x0004BCBF File Offset: 0x00049EBF
		' (set) Token: 0x060008AA RID: 2218 RVA: 0x0004BCCC File Offset: 0x00049ECC
		Friend Overridable Property mnuProductBOM As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuProductBOM
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuProductBOM_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuProductBOM
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuProductBOM = value
				toolStripMenuItem = Me._mnuProductBOM
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700036F RID: 879
		' (get) Token: 0x060008AB RID: 2219 RVA: 0x0004BD0F File Offset: 0x00049F0F
		' (set) Token: 0x060008AC RID: 2220 RVA: 0x0004BD19 File Offset: 0x00049F19
		Friend Overridable Property gslblReportingTo As Label

		' Token: 0x17000370 RID: 880
		' (get) Token: 0x060008AD RID: 2221 RVA: 0x0004BD22 File Offset: 0x00049F22
		' (set) Token: 0x060008AE RID: 2222 RVA: 0x0004BD2C File Offset: 0x00049F2C
		Friend Overridable Property gslblManager As Label

		' Token: 0x17000371 RID: 881
		' (get) Token: 0x060008AF RID: 2223 RVA: 0x0004BD35 File Offset: 0x00049F35
		' (set) Token: 0x060008B0 RID: 2224 RVA: 0x0004BD3F File Offset: 0x00049F3F
		Friend Overridable Property gslblDepartment As Label

		' Token: 0x17000372 RID: 882
		' (get) Token: 0x060008B1 RID: 2225 RVA: 0x0004BD48 File Offset: 0x00049F48
		' (set) Token: 0x060008B2 RID: 2226 RVA: 0x0004BD54 File Offset: 0x00049F54
		Friend Overridable Property mnuPOApproverList As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuPOApproverList
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuPOApproverList_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuPOApproverList
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuPOApproverList = value
				toolStripMenuItem = Me._mnuPOApproverList
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000373 RID: 883
		' (get) Token: 0x060008B3 RID: 2227 RVA: 0x0004BD97 File Offset: 0x00049F97
		' (set) Token: 0x060008B4 RID: 2228 RVA: 0x0004BDA4 File Offset: 0x00049FA4
		Friend Overridable Property mnuPRCostApproval As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuPRCostApproval
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuPRCostApproval_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuPRCostApproval
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuPRCostApproval = value
				toolStripMenuItem = Me._mnuPRCostApproval
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000374 RID: 884
		' (get) Token: 0x060008B5 RID: 2229 RVA: 0x0004BDE7 File Offset: 0x00049FE7
		' (set) Token: 0x060008B6 RID: 2230 RVA: 0x0004BDF4 File Offset: 0x00049FF4
		Friend Overridable Property mnuPOCostApproval As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuPOCostApproval
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuPOCostApproval_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuPOCostApproval
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuPOCostApproval = value
				toolStripMenuItem = Me._mnuPOCostApproval
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000375 RID: 885
		' (get) Token: 0x060008B7 RID: 2231 RVA: 0x0004BE37 File Offset: 0x0004A037
		' (set) Token: 0x060008B8 RID: 2232 RVA: 0x0004BE44 File Offset: 0x0004A044
		Friend Overridable Property mnuQARelease As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuQARelease
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuQARelease_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuQARelease
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuQARelease = value
				toolStripMenuItem = Me._mnuQARelease
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000376 RID: 886
		' (get) Token: 0x060008B9 RID: 2233 RVA: 0x0004BE87 File Offset: 0x0004A087
		' (set) Token: 0x060008BA RID: 2234 RVA: 0x0004BE94 File Offset: 0x0004A094
		Friend Overridable Property mnuBOMApproval As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._mnuBOMApproval
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.mnuBOMApproval_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._mnuBOMApproval
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._mnuBOMApproval = value
				toolStripMenuItem = Me._mnuBOMApproval
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x060008BB RID: 2235 RVA: 0x0004BED8 File Offset: 0x0004A0D8
		Private Sub LogoutTimer(sender As Object, e As ElapsedEventArgs)
			' The following expression was wrapped in a checked-statement
			Try
				Application.DoEvents()
				Dim flag As Boolean = Not GlobalVariables.gsIsLocked
				If flag Then
					Dim inactiveTime As TimeSpan? = Me.IdleTimer.GetInactiveTime()
					Dim flag2 As Boolean = (inactiveTime Is Nothing) Or (Me.AutoLockTime <= 0L)
					If flag2 Then
						Me.oLogoutTimer.Enabled = False
					Else
						' The following expression was wrapped in a unchecked-expression
						' The following expression was wrapped in a checked-expression
						Dim num As Long = Me.AutoLockTime - CLng((CInt(Math.Round(inactiveTime.Value.TotalSeconds))))
						Me.sSession = "                                   Session Time Out : " + Conversions.ToString(num) + "/" + Conversions.ToString(Me.AutoLockTime)
						Dim num2 As Integer = CInt(Math.Floor(CDbl(num) / 60.0))
						Dim num3 As Integer = CInt((num Mod 60L))
						Me.skip_lblSession.Text = Strings.Format(num2, "#00") + ":" + Strings.Format(num3, "#00")
						Dim flag3 As Boolean = num = 0L
						If flag3 Then
							Me.oLogoutTimer.[Stop]()
							GlobalVariables.gsIsLocked = True
							MyBase.Enabled = False
							Dim flag4 As Boolean = Not Me.sReLoadLockScreen
							If flag4 Then
								Me.sReLoadLockScreen = True
								Me.oFormReLogin = New ReLogin()
								Dim flag5 As Boolean = Me.oFormReLogin.ShowDialog() = DialogResult.OK
								If flag5 Then
									Me.oLogoutTimer.Start()
									Me.sReLoadLockScreen = False
								End If
							End If
							Me.oFormReLogin.Dispose()
							Me.oFormReLogin = Nothing
							Dim flag6 As Boolean = Not GlobalVariables.gsIsLocked
							If flag6 Then
								Me.DockPanel.Enabled = True
								MyBase.Enabled = True
							End If
						End If
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060008BC RID: 2236 RVA: 0x0004C0B4 File Offset: 0x0004A2B4
		Private Sub TickFunctin()
			Try
				Dim flag As Boolean = Not GlobalVariables.gsIsLocked
				If flag Then
					Dim inactiveTime As TimeSpan? = Me.IdleTimer.GetInactiveTime()
					Dim flag2 As Boolean = (inactiveTime Is Nothing) Or (Me.AutoLockTime <= 0L)
					If Not flag2 Then
						Dim num As Long
						Dim flag3 As Boolean
						num = CLng(Math.Round(CDbl(Me.AutoLockTime) - inactiveTime.Value.TotalSeconds))
						Me.sSession = "                                   Session Time Out : " + Conversions.ToString(num) + "/" + Conversions.ToString(Me.AutoLockTime)
						flag3 = (CDbl(num) / 60.0 > 1.0) And (num Mod 60L > 0L)
						Dim num2 As Integer
						If flag3 Then
							num2 = Conversions.ToInteger(Strings.Format(CDbl(num) / 60.0 - 1.0, "#00"))
						Else
							num2 = Conversions.ToInteger(Strings.Format(CDbl(num) / 60.0, "#00"))
						End If
						Dim num3 As Integer = Conversions.ToInteger(Strings.Format(num Mod 60L, "#00"))
						Me.skip_lblSession.Text = Strings.Format(num2, "#00") + ":" + Strings.Format(num3, "#00")
						Dim flag4 As Boolean = num = 0L
						If flag4 Then
							GlobalVariables.gsIsLocked = True
							MyBase.Enabled = False
							Dim flag5 As Boolean = Not Me.sReLoadLockScreen
							If flag5 Then
								Me.lblLogin.Visible = True
								Me.oFormReLogin = New ReLogin()
								Dim flag6 As Boolean = Me.oFormReLogin.ShowDialog() = DialogResult.OK
								If flag6 Then
									Me.sReLoadLockScreen = False
								End If
							End If
							Me.oFormReLogin.Dispose()
							Me.oFormReLogin = Nothing
							Dim flag7 As Boolean = Not GlobalVariables.gsIsLocked
							If flag7 Then
								Me.DockPanel.Enabled = True
								MyBase.Enabled = True
							End If
						End If
					End If
					Me.oThread = AddressOf Me.TickFunctin
					Me.oThread.Start()
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060008BD RID: 2237 RVA: 0x0004C304 File Offset: 0x0004A504
		Private Sub InactivityTimer_Tick(sender As Object, e As EventArgs)
			Me.TickFunctin()
		End Sub

		' Token: 0x060008BE RID: 2238 RVA: 0x0004C310 File Offset: 0x0004A510
		Private Sub MemoryTimer_Tick(sender As Object, e As EventArgs)
			Dim text As String = "Memory Usage : " & vbCrLf + Conversions.ToString(GC.GetTotalMemory(True))
			Me.skip_lblMemory.Text = text
		End Sub

		' Token: 0x060008BF RID: 2239 RVA: 0x0004C344 File Offset: 0x0004A544
		Public Sub New()
			AddHandler MyBase.Activated, AddressOf Me.MDIMain_Activated
			AddHandler MyBase.FormClosing, AddressOf Me.MDIMain_FormClosing
			AddHandler MyBase.Load, AddressOf Me.MDIMain_Load
			AddHandler MyBase.Shown, AddressOf Me.MDIMain_Shown
			Me.cnt = 0L
			Me.oFormReLogin = New Form()
			Me.AutoLockTime = FeaturesVariables.gsAuto_Lock_Time
			Me.IdleTimer = New IdleTime1()
			Me.lDeactiveTime = 0L
			Me.oLogoutTimer = New Global.System.Timers.Timer(1000.0)
			Me.InitializeComponent()
			Me.iAttemptLock = 0
			Me.bProfilePanelExpand = False
			Me.iProfilePanelHeight = Me.pnlProfile.Height
		End Sub

		' Token: 0x060008C0 RID: 2240 RVA: 0x0004C410 File Offset: 0x0004A610
		Private Sub DockPanel_ContentAdded(sender As Object, e As DockContentEventArgs)
			Dim flag As Boolean = Me.DockPanel.Contents.Count > 0
			If flag Then
				Me.DockPanel.AllowEndUserDocking = False
				Me.DockPanel.Visible = True
			End If
		End Sub

		' Token: 0x060008C1 RID: 2241 RVA: 0x0004C454 File Offset: 0x0004A654
		Private Sub DockPanel_ContentRemoved(sender As Object, e As DockContentEventArgs)
			Dim flag As Boolean = Me.DockPanel.Contents.Count <= 0
			If flag Then
				Me.DockPanel.Visible = False
			End If
		End Sub

		' Token: 0x060008C2 RID: 2242 RVA: 0x0004C48C File Offset: 0x0004A68C
		Private Sub MDIMain_Activated(sender As Object, e As EventArgs)
			Dim gsIsLocked As Boolean = GlobalVariables.gsIsLocked
			If gsIsLocked Then
				Dim flag As Boolean = Not Information.IsNothing(Me.oFormReLogin)
				If flag Then
					Me.oFormReLogin.Focus()
					Me.oFormReLogin.BringToFront()
				End If
			End If
		End Sub

		' Token: 0x060008C3 RID: 2243 RVA: 0x0004C4D4 File Offset: 0x0004A6D4
		Private Sub MDIMain_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = CustomMsgBox.Show("Close Application ? ", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
			If flag Then
				Me.oLogoutTimer.[Stop]()
				Dim flag2 As Boolean = Me.DockPanel.Contents.Count > 1
				If flag2 Then
					CustomMsgBox.Show("Please Close All Open Forms Before Closing The Application.", "Close Forms", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					e.Cancel = True
				Else
					Dim flag3 As Boolean = Not Me.CloseSession()
					If flag3 Then
						e.Cancel = True
					Else
						Dim gsbSQLConnection As Boolean = GlobalVariables.gsbSQLConnection
						If gsbSQLConnection Then
							MainModule.TrnLog("Main", "Application Closed", "", Nothing)
						End If
					End If
				End If
			Else
				e.Cancel = True
			End If
		End Sub

		' Token: 0x060008C4 RID: 2244 RVA: 0x0004C584 File Offset: 0x0004A784
		Private Sub MDIMain_Load(sender As Object, e As EventArgs)
			MyBase.WindowState = FormWindowState.Maximized
			Designing.SetTheme(Me)
			Me.SetState()
			Control.CheckForIllegalCrossThreadCalls = False
			AddHandler Me.oLogoutTimer.Elapsed, AddressOf Me.LogoutTimer
			MyBase.Enabled = False
		End Sub

		' Token: 0x060008C5 RID: 2245 RVA: 0x0004C5C4 File Offset: 0x0004A7C4
		Private Sub MDIMain_Shown(sender As Object, e As EventArgs)
			Dim gsbSQLConnection As Boolean = GlobalVariables.gsbSQLConnection
			If gsbSQLConnection Then
				Dim flag As Boolean = Not MainModule.TrnLog("Main", "Application Started", "", Nothing)
				If flag Then
					MyBase.Close()
				End If
			End If
			Dim flag2 As Boolean = Operators.CompareString(MySettingsProperty.Settings.sConfigIsSandbox, "True", False) = 0
			If flag2 Then
				Me.skip_lblSanbox.Visible = True
			End If
			Dim flag3 As Boolean = (Operators.CompareString(MySettingsProperty.Settings.sConfigCompany, "Anwar", False) = 0) And GlobalVariables.gsbSQLConnection
			If flag3 Then
				Me.skip_txtPass.PasswordChar = "*"c
				Me.skip_txtUser.Text = "admin"
				Me.skip_txtPass.Text = "1"
				Me.btnOK_Click(RuntimeHelpers.GetObjectValue(sender), e)
				Me.mnuStockUpload.Visible = True
				Me.mnuStockUpload.Enabled = True
			End If
			MyBase.Enabled = True
		End Sub

		' Token: 0x060008C6 RID: 2246 RVA: 0x0004C6B0 File Offset: 0x0004A8B0
		Private Function MainControl(bState As Boolean) As Boolean
			Dim mdiChildren As Form() = MyBase.MdiChildren
			Dim num As Integer = mdiChildren.Length - 1
			For i As Integer = 0 To num
				mdiChildren(i).Close()
			Next
			Dim flag As Boolean = MyBase.MdiChildren.Length > 0
			Dim flag2 As Boolean
			If flag Then
				flag2 = False
			Else
				If bState Then
					Me.pnlLogin.Visible = False
					Me.lblLogin.Visible = False
					Dim num2 As Integer = Me.mnuMain.Items.Count - 1
					For j As Integer = 0 To num2
						Dim toolStripItem As ToolStripItem = Me.mnuMain.Items(j)
						toolStripItem.Visible = True
					Next
					Dim num3 As Integer = Me.StatusStrip1.Items.Count - 1
					For k As Integer = 0 To num3
						Dim toolStripItem2 As ToolStripItem = Me.StatusStrip1.Items(k)
						toolStripItem2.Visible = True
					Next
					Me.picProfile.Visible = True
					Me.skip_lblSessionLabel.Visible = True
					Me.skip_lblSession.Visible = True
					Me.gslblUser.Text = "Welcome " + GlobalVariables.gsUserName
					Me.gslblCompany.Text = GlobalVariables.gsCompanyName
					Me.gslblPlant.Text = GlobalVariables.gsPlantName
					Me.gslblDepartment.Text = "Department : " + GlobalVariables.gsDepartment
					Me.gslblManager.Text = "Manager : " + GlobalVariables.gsManager
					Me.gslblReportingTo.Text = "Reporting To : " + GlobalVariables.gsReportingTo
				Else
					Me.pnlLogin.Visible = True
					Me.lblLogin.Visible = True
					Dim num4 As Integer = Me.mnuMain.Items.Count - 1
					For l As Integer = 0 To num4
						Dim toolStripItem3 As ToolStripItem = Me.mnuMain.Items(l)
						toolStripItem3.Visible = False
					Next
					Me.picProfile.Visible = False
					Me.skip_lblSessionLabel.Visible = False
					Me.skip_lblSession.Visible = False
					Me.gslblUser.Text = ""
					Me.gslblCompany.Text = ""
					Me.gslblPlant.Text = ""
					Me.gslblDepartment.Text = ""
					Me.gslblManager.Text = ""
					Me.gslblReportingTo.Text = ""
				End If
				Me.SetProfilePanel()
				flag2 = True
			End If
			Return flag2
		End Function

		' Token: 0x060008C7 RID: 2247 RVA: 0x0004C954 File Offset: 0x0004AB54
		Private Sub SetState()
			Me.MainControl(False)
			MyBase.AcceptButton = Me.btnOK
			Me.pnlProfile.Height = 0
			Me.DockPanel.Visible = False
			Try
				For Each obj As Object In MyBase.Controls
					Dim control As Control = CType(obj, Control)
					Dim flag As Boolean = control.[GetType]() Is GetType(MdiClient)
					If flag Then
						control.BackColor = Me.BackColor
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Me.gslblServer.Text = GlobalVariables.gsServerName
			Me.gslblDatabase.Text = GlobalVariables.gsDbName
			Dim flag2 As Boolean = Not GlobalVariables.gsbSQLConnection
			If flag2 Then
				Me.btnOK.Enabled = False
			End If
		End Sub

		' Token: 0x060008C8 RID: 2248 RVA: 0x0004CA44 File Offset: 0x0004AC44
		Private Sub SetProfilePanel()
			Dim flag As Boolean = Me.gslblUser.Width > Me.gslblCompany.Width
			Dim num As Integer
			If flag Then
				num = Me.gslblUser.Width
			Else
				num = Me.gslblCompany.Width
			End If
			Dim flag2 As Boolean = Me.gslblPlant.Width > num
			If flag2 Then
				num = Me.gslblPlant.Width
			End If
			Dim flag3 As Boolean = Me.gslblDepartment.Width > num
			If flag3 Then
				num = Me.gslblDepartment.Width
			End If
			Dim flag4 As Boolean = Me.gslblManager.Width > num
			If flag4 Then
				num = Me.gslblManager.Width
			End If
			Dim flag5 As Boolean = Me.gslblReportingTo.Width > num
			If flag5 Then
				num = Me.gslblReportingTo.Width
			End If
			Me.pnlProfile.Width = num + 30
			Me.gslblUser.Left = 8
			Me.gslblDepartment.Left = 22
			Me.gslblManager.Left = 22
			Me.gslblReportingTo.Left = 22
			Me.pnlProfile.Left = MyBase.Width - Me.pnlProfile.Width - 12
		End Sub

		' Token: 0x060008C9 RID: 2249 RVA: 0x0004CB78 File Offset: 0x0004AD78
		Private Sub picProfile_Click(sender As Object, e As EventArgs)
			Dim name As String = Me.pnlProfile.Parent.Name
			Dim flag As Boolean = Not Me.bProfilePanelExpand
			If flag Then
				Me.bProfilePanelExpand = True
			Else
				Me.bProfilePanelExpand = False
			End If
			Me.profileTimer.Start()
		End Sub

		' Token: 0x060008CA RID: 2250 RVA: 0x0004CBC3 File Offset: 0x0004ADC3
		Private Sub profileTimer_Tick(sender As Object, e As EventArgs)
			Me.ProfileOpen(Conversions.ToString(Me.bProfilePanelExpand))
		End Sub

		' Token: 0x060008CB RID: 2251 RVA: 0x0004CBD8 File Offset: 0x0004ADD8
		Private Sub ProfileOpen(sType As String)
			Dim flag As Boolean = Me.bProfilePanelExpand
			If flag Then
				Dim flag2 As Boolean = Me.pnlProfile.Height < Me.iProfilePanelHeight
				If flag2 Then
					Dim pnlProfile As Panel = Me.pnlProfile
					Dim panel As Panel = pnlProfile
					pnlProfile.Height = panel.Height + 10
				Else
					Me.profileTimer.[Stop]()
				End If
			Else
				Dim flag3 As Boolean = Me.pnlProfile.Height > 0
				If flag3 Then
					Dim pnlProfile2 As Panel = Me.pnlProfile
					Dim panel As Panel = pnlProfile2
					pnlProfile2.Height = panel.Height - 10
				Else
					Me.profileTimer.[Stop]()
				End If
			End If
		End Sub

		' Token: 0x060008CC RID: 2252 RVA: 0x0004CC70 File Offset: 0x0004AE70
		Private Sub btnSignOut_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.DockPanel.Contents.Count > 1
			If flag Then
				CustomMsgBox.Show("Work In Progress, Unable To Logout.", "Close Forms", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Else
				Dim flag2 As Boolean = Not Me.MainControl(False)
				If flag2 Then
					CustomMsgBox.Show("Work In Progress, Unable To Logout.", "Close Forms", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Else
					Dim flag3 As Boolean = Not Me.CloseSession()
					If Not flag3 Then
						MainModule.TrnLog("Access", "Logged Out", "Logout Successful", Nothing)
						GlobalVariables.gsUserID = ""
						GlobalVariables.gsUserName = ""
						GlobalVariables.gsLoginID = ""
						GlobalVariables.gsLoginPwd = ""
						GlobalVariables.gsEmailID = ""
						GlobalVariables.gsManagerID = ""
						GlobalVariables.gsReportingToID = ""
						GlobalVariables.gsManager = ""
						GlobalVariables.gsReportingTo = ""
						GlobalVariables.gsUserGroupID = ""
						GlobalVariables.gsUserGroup = ""
						GlobalVariables.gsCompanyID = ""
						GlobalVariables.gsGS1Code = ""
						GlobalVariables.gsCompanyCode = ""
						GlobalVariables.gsCompanyName = ""
						GlobalVariables.gsCompanyAddress = ""
						GlobalVariables.gsIdentifier = ""
						GlobalVariables.gsPlantID = ""
						GlobalVariables.gsPlantCode = ""
						GlobalVariables.gsPlantName = ""
						GlobalVariables.gsMultiPlant = False
						MyBase.AcceptButton = Me.btnOK
						Me.skip_txtUser.Focus()
						Me.txtPass_LostFocus(RuntimeHelpers.GetObjectValue(sender), e)
						MyBase.AcceptButton = Me.btnOK
						Me.oLogoutTimer.[Stop]()
						Me.picProfile_Click(RuntimeHelpers.GetObjectValue(sender), e)
					End If
				End If
			End If
		End Sub

		' Token: 0x060008CD RID: 2253 RVA: 0x0004CE1C File Offset: 0x0004B01C
		Private Function ValidateForm() As Boolean
			Dim flag As Boolean = (Operators.CompareString(Me.skip_txtUser.Text, "", False) = 0) Or (Me.skip_txtPass.ForeColor = Color.DarkGray)
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Enter Login ID.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				flag2 = False
			Else
				Dim flag3 As Boolean = (Operators.CompareString(Me.skip_txtPass.Text, "", False) = 0) Or (Me.skip_txtPass.ForeColor = Color.DarkGray)
				If flag3 Then
					CustomMsgBox.Show("Enter Password.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					flag2 = False
				Else
					flag2 = True
				End If
			End If
			Return flag2
		End Function

		' Token: 0x060008CE RID: 2254 RVA: 0x0004CEC4 File Offset: 0x0004B0C4
		Private Sub btnOK_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Me.ValidateForm()
			If Not flag Then
				Me.LoginCheck(Strings.Trim(Me.skip_txtUser.Text), Strings.Trim(Me.skip_txtPass.Text))
			End If
		End Sub

		' Token: 0x060008CF RID: 2255 RVA: 0x0004CF08 File Offset: 0x0004B108
		Private Sub LoginCheck(sLoginID As String, sLoginPwd As String)
			Dim text As String = " SET DATEFORMAT mdy " & vbCrLf & vbCrLf
			text += " SELECT U.UserID, U.UserName, U.LoginID, U.Password, U.EmailID, U.UserGroupID, UG.UserGroup, " & vbCrLf
			text += " U.Department, U.ManagerID, U.ReportingToID, M.UserName Manager, R.UserName ReportingTo, " & vbCrLf
			text += " U.IsLocked, U.Attempts, ISNULL(U.LastReset,'01/01/2000') AS LastReset, " & vbCrLf
			text += " ISNULL(U.SessionState,'False') SessionState, U.SessionID, U.SessionComputerName, U.SessionIPAddress," & vbCrLf
			text += " P.PlantID, P.Plant, C.CompanyID, C.CompanyCode, C.Address, C.GS1Code, " & vbCrLf
			text += " C.CompanyName, C.Identifier, C.SSCCExtensionDigit" & vbCrLf
			text += " FROM [User] U INNER JOIN UserGroup UG ON U.UserGroupID = UG.UserGroupID " & vbCrLf
			text += " LEFT JOIN Plant P ON U.PlantID = P.PlantID " & vbCrLf
			text += " LEFT JOIN Company C ON C.CompanyID = P.CompanyID " & vbCrLf
			text += " LEFT JOIN [User] M ON U.ManagerID = M.UserID " & vbCrLf
			text += " LEFT JOIN [User] R ON U.ReportingToID = R.UserID " & vbCrLf
			text = text + " WHERE (U.LoginID = '" + sLoginID + "') AND (U.IsActive='True') AND (UG.IsActive='True')" & vbCrLf
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim text2 As String = MainModule.DecryptData(data.Rows(0)("Password").ToString(), GlobalVariables.gsPwd)
				Dim flag2 As Boolean = Strings.InStr(text2, "Error", CompareMethod.Binary) > 0
				If flag2 Then
					MainModule.TrnLog("Main", "Access - Validation Error", "Data Manupulation Observed..! - User", Nothing)
					CustomMsgBox.Show("Data Manupulation Observed..! - User.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.btnOK.Enabled = False
				Else
					Dim flag3 As Boolean = Operators.CompareString(data.Rows(0)("IsLocked").ToString(), "True", False) = 0
					If flag3 Then
						MainModule.TrnLog("Main", "Log In Failed", "Locked User Trying To Access", Nothing)
						CustomMsgBox.Show("User Is Locked.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.btnOK.Enabled = False
						Me.skip_txtPass.Text = ""
					Else
						Dim flag4 As Boolean = Operators.CompareString(text2, sLoginPwd, False) = 0
						If flag4 Then
							Dim flag5 As Boolean = Conversion.Val(data.Rows(0)("Attempts").ToString()) > 0.0
							If flag5 Then
								Me.SetAttemptLock(data, "RELEASE")
							End If
							GlobalVariables.gsUserID = data.Rows(0)("UserID").ToString()
							GlobalVariables.gsUserName = data.Rows(0)("UserName").ToString()
							GlobalVariables.gsLoginID = data.Rows(0)("LoginID").ToString()
							GlobalVariables.gsLoginPwd = data.Rows(0)("Password").ToString()
							GlobalVariables.gsEmailID = data.Rows(0)("EmailID").ToString()
							GlobalVariables.gsDepartment = data.Rows(0)("Department").ToString()
							GlobalVariables.gsManagerID = data.Rows(0)("ManagerID").ToString()
							GlobalVariables.gsReportingToID = data.Rows(0)("ReportingToID").ToString()
							GlobalVariables.gsManager = data.Rows(0)("Manager").ToString()
							GlobalVariables.gsReportingTo = data.Rows(0)("ReportingTo").ToString()
							GlobalVariables.gsUserGroupID = data.Rows(0)("UserGroupID").ToString()
							GlobalVariables.gsUserGroup = data.Rows(0)("UserGroup").ToString()
							GlobalVariables.gsCompanyID = data.Rows(0)("CompanyID").ToString()
							GlobalVariables.gsCompanyCode = data.Rows(0)("CompanyCode").ToString()
							GlobalVariables.gsCompanyName = data.Rows(0)("CompanyName").ToString()
							GlobalVariables.gsCompanyAddress = data.Rows(0)("Address").ToString()
							GlobalVariables.gsPlantID = data.Rows(0)("PlantID").ToString()
							GlobalVariables.gsPlantName = data.Rows(0)("Plant").ToString()
							GlobalVariables.gsGS1Code = MainModule.DecryptData(data.Rows(0)("GS1Code").ToString(), GlobalVariables.gsPwd)
							GlobalVariables.gsIdentifier = MainModule.DecryptData(data.Rows(0)("Identifier").ToString(), GlobalVariables.gsPwd)
							GlobalVariables.gsSSCCExtensionDigit = CInt(Math.Round(Conversion.Val(MainModule.DecryptData(data.Rows(0)("SSCCExtensionDigit").ToString(), GlobalVariables.gsPwd))))
							Dim flag6 As Boolean = (Strings.InStr(GlobalVariables.gsGS1Code, "Error", CompareMethod.Binary) > 0) Or (Strings.InStr(GlobalVariables.gsIdentifier, "Error", CompareMethod.Binary) > 0) Or (Strings.InStr(Conversions.ToString(GlobalVariables.gsSSCCExtensionDigit), "Error", CompareMethod.Binary) > 0)
							If flag6 Then
								MainModule.TrnLog("Main", "Validation Error", "Data Manupulation Observed..! - Company", Nothing)
								CustomMsgBox.Show("Data Corruption..!", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								Me.btnOK.Enabled = False
							Else
								Dim flag7 As Boolean = Not Me.CheckLastReset(Conversions.ToDate(data.Rows(0)("LastReset")))
								If flag7 Then
									CustomMsgBox.Show("Please Re-Login.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
									Me.skip_txtUser.Focus()
								Else
									Me.ClearForm()
									MainModule.TrnLog("Main", "Logged In", "Login Successful", Nothing)
									Me.SetAccess()
									MyBase.AcceptButton = Nothing
									Me.MainControl(True)
									Me.oLogoutTimer.Start()
									MyProject.Forms.Dashboard.Show(Me.DockPanel)
								End If
							End If
						Else
							Me.SetAttemptLock(data, "SET")
							MainModule.TrnLog("Main", "Login Failed", "Login failed, invalid login details. Attempts : " + Conversions.ToString(Me.iAttemptLock), Nothing)
							Dim text3 As String = "Invalid Login." & vbCrLf
							text3 = text3 + "Account Will Be Locked After " + Conversions.ToString(FeaturesVariables.gsWrong_Attempt) + " Attempts." & vbCrLf
							text3 = text3 + Conversions.ToString(FeaturesVariables.gsWrong_Attempt - Me.iAttemptLock) + " Attempts Left."
							CustomMsgBox.Show(text3, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.ClearForm()
						End If
					End If
				End If
			Else
				MainModule.TrnLog("Main", "Login Failed", "Login failed, invalid Login ID", Nothing)
				CustomMsgBox.Show("Invalid Login", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.skip_txtPass.Text = ""
			End If
		End Sub

		' Token: 0x060008D0 RID: 2256 RVA: 0x0004D5DC File Offset: 0x0004B7DC
		Private Sub SetAttemptLock(dt As DataTable, sType As String)
			Dim text As String = ""
			If Operators.CompareString(sType, "SET", False) <> 0 Then
				If Operators.CompareString(sType, "RELEASE", False) = 0 Then
					text = " UPDATE [User] SET Attempts = 0"
				End If
			Else
				Dim flag As Boolean = Operators.CompareString(dt.Rows(0)("Attempts").ToString(), "", False) = 0
				If flag Then
					Me.iAttemptLock = 1
				Else
					' The following expression was wrapped in a unchecked-expression
					Me.iAttemptLock = CInt(Math.Round(Conversion.Val(dt.Rows(0)("Attempts").ToString()) + 1.0))
				End If
				text = " UPDATE [User] SET Attempts = " + Conversions.ToString(Me.iAttemptLock) + " "
				Dim flag2 As Boolean = Me.iAttemptLock >= FeaturesVariables.gsWrong_Attempt
				If flag2 Then
					text += " , [User].IsLocked = 1"
				End If
			End If
			text = text + " WHERE ([User].LoginID = '" + Strings.Trim(Me.skip_txtUser.Text) + "')"
			MainModule.GetData(text)
			Dim flag3 As Boolean = Me.iAttemptLock >= FeaturesVariables.gsWrong_Attempt
			If flag3 Then
				CustomMsgBox.Show("User Account Locked. Multiple Incorrect Attempts.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				MainModule.TrnLog("Main", "Login Failed", "User is locked as he has exceeded allowed number of attempts.", Nothing)
			End If
		End Sub

		' Token: 0x060008D1 RID: 2257 RVA: 0x0004D73C File Offset: 0x0004B93C
		Private Function CheckLastReset(sLastRestDate As DateTime) As Boolean
			Dim serverDate As DateTime = MainModule.GetServerDate()
			Dim num As Long = DateAndTime.DateDiff(DateInterval.Day, sLastRestDate, serverDate, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)
			Dim flag As Boolean = num > 10000L
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("This is your first login, reset password", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				Dim changePassword As ChangePassword = New ChangePassword("Reset Password")
				changePassword.ShowDialog()
				flag2 = False
			Else
				Dim flag3 As Boolean = num > CLng(FeaturesVariables.gsPassword_Rest_Duration)
				If flag3 Then
					CustomMsgBox.Show("Password Expired, Reset Password", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Dim changePass As ChangePass = New ChangePass()
					changePass.ShowDialog()
					flag2 = False
				Else
					flag2 = True
				End If
			End If
			Return flag2
		End Function

		' Token: 0x060008D2 RID: 2258 RVA: 0x0004D7D0 File Offset: 0x0004B9D0
		Private Function SetSession(dt As DataTable) As Boolean
			Dim flag2 As Boolean
			Try
				Dim text As String = GlobalVariables.gsPCIP + " - " + Strings.Format(DateAndTime.Now, "dd MMM yyyy hh:mm:ss tt")
				GlobalVariables.gsSessionID = MainModule.EncryptData(text, GlobalVariables.gsPath)
				Dim text2 As String = " UPDATE [User] SET SessionState = 1, SessionID = '" + text + "', "
				text2 = String.Concat(New String() { text2, " SessionComputerName = '", GlobalVariables.gsPCName, "', SessionIPAddress = '", GlobalVariables.gsPCIP, "'" })
				text2 = text2 + " WHERE UserID = '" + dt.Rows(0)("UserID").ToString() + "'"
				Dim flag As Boolean = MainModule.ExecuteSQL(text2) = 1
				If flag Then
					flag2 = True
				Else
					flag2 = False
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				flag2 = False
			End Try
			Return flag2
		End Function

		' Token: 0x060008D3 RID: 2259 RVA: 0x0004D8E0 File Offset: 0x0004BAE0
		Private Function CloseSession() As Boolean
			Dim flag2 As Boolean
			Try
				Dim flag As Boolean = Operators.CompareString(GlobalVariables.gsUserID, "", False) <> 0
				If flag Then
					Dim text As String = " UPDATE [User] SET SessionState=0, SessionID='', SessionComputerName='', SessionIPAddress=''"
					text = text + " WHERE UserID = '" + GlobalVariables.gsUserID + "'"
					MainModule.CheckConnection(text)
					flag2 = True
				Else
					flag2 = True
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				flag2 = False
			End Try
			Return flag2
		End Function

		' Token: 0x060008D4 RID: 2260 RVA: 0x0004D974 File Offset: 0x0004BB74
		Private Sub btnCancel_Click(sender As Object, e As EventArgs)
			Application.[Exit]()
		End Sub

		' Token: 0x060008D5 RID: 2261 RVA: 0x0004D97D File Offset: 0x0004BB7D
		Private Sub ClearForm()
			Me.skip_txtUser.Text = ""
			Me.skip_txtPass.Text = ""
		End Sub

		' Token: 0x060008D6 RID: 2262 RVA: 0x0004D9A4 File Offset: 0x0004BBA4
		Private Sub SetAccess()
			Dim text As String = " SELECT UserGroupDtls.FormName, FormName.FormID "
			text += " FROM [User] INNER JOIN UserGroup ON [User].UserGroupID = UserGroup.UserGroupID  "
			text += " INNER JOIN UserGroupDtls ON UserGroup.UserGroupID = UserGroupDtls.UserGroupID "
			text += " INNER JOIN FormName On UserGroupDtls.FormName = FormName.FormName"
			text = text + " WHERE ([User].UserID = '" + GlobalVariables.gsUserID + "')"
			Dim data As DataTable = MainModule.GetData(text)
			GlobalVariables.gsdtAccessRights = data
			Dim flag As Boolean = data.Rows.Count = 0
			If flag Then
				CustomMsgBox.Show("No Access Rights Set.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End If
			Dim flag2 As Boolean = Operators.CompareString(MySettingsProperty.Settings.sConfigCompany, "Config", False) = 0
			If flag2 Then
				Try
					For Each obj As Object In Me.mnuMain.Items
						Dim toolStripMenuItem As ToolStripMenuItem = CType(obj, ToolStripMenuItem)
						Try
							For Each obj2 As Object In toolStripMenuItem.DropDownItems
								Dim toolStripItem As ToolStripItem = CType(obj2, ToolStripItem)
								Dim flag3 As Boolean = data.[Select]("FormID='" + toolStripItem.Name.ToString() + "'").Length > 0
								If flag3 Then
									toolStripItem.Visible = False
								Else
									toolStripItem.Enabled = False
								End If
							Next
						Finally
							Dim enumerator2 As IEnumerator
							If TypeOf enumerator2 Is IDisposable Then
								TryCast(enumerator2, IDisposable).Dispose()
							End If
						End Try
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			Else
				Try
					For Each obj3 As Object In Me.mnuMain.Items
						Dim toolStripMenuItem2 As ToolStripMenuItem = CType(obj3, ToolStripMenuItem)
						Try
							For Each obj4 As Object In toolStripMenuItem2.DropDownItems
								Dim toolStripItem2 As ToolStripItem = CType(obj4, ToolStripItem)
								Dim flag4 As Boolean = data.[Select]("FormID='" + toolStripItem2.Name.ToString() + "'").Length > 0
								If flag4 Then
									toolStripItem2.Enabled = True
								Else
									toolStripItem2.Enabled = False
								End If
							Next
						Finally
							Dim enumerator4 As IEnumerator
							If TypeOf enumerator4 Is IDisposable Then
								TryCast(enumerator4, IDisposable).Dispose()
							End If
						End Try
					Next
				Finally
					Dim enumerator3 As IEnumerator
					If TypeOf enumerator3 Is IDisposable Then
						TryCast(enumerator3, IDisposable).Dispose()
					End If
				End Try
				Dim flag5 As Boolean = data.[Select]("FormID='Multi Plant'").Length > 0
				If flag5 Then
					GlobalVariables.gsMultiPlant = True
				Else
					GlobalVariables.gsMultiPlant = False
				End If
				Dim flag6 As Boolean = data.[Select]("FormID='Line Control'").Length > 0
				If flag6 Then
					GlobalVariables.gsLineControl = True
				Else
					GlobalVariables.gsLineControl = False
				End If
				Dim flag7 As Boolean = data.[Select]("FormID='Multi Company'").Length > 0
				If flag7 Then
					GlobalVariables.gsMultiCompany = True
				Else
					GlobalVariables.gsMultiCompany = False
				End If
				Dim flag8 As Boolean = data.[Select]("FormID='GRN Attachment After Approval'").Length > 0
				If flag8 Then
					GlobalVariables.gsGRNAttachmentAfterApproval = True
				Else
					GlobalVariables.gsGRNAttachmentAfterApproval = False
				End If
				Dim flag9 As Boolean = data.[Select]("FormID='Enable Product Details'").Length > 0
				If flag9 Then
					GlobalVariables.gsProductDetails = Conversions.ToString(True)
				Else
					GlobalVariables.gsProductDetails = Conversions.ToString(False)
				End If
				Dim flag10 As Boolean = data.[Select]("FormID='Enable Product QC Specification'").Length > 0
				If flag10 Then
					GlobalVariables.gsProductQC = Conversions.ToString(True)
				Else
					GlobalVariables.gsProductQC = Conversions.ToString(False)
				End If
				Dim flag11 As Boolean = data.[Select]("FormID='Enable Product BOM'").Length > 0
				If flag11 Then
					GlobalVariables.gsProductBOM = Conversions.ToString(True)
				Else
					GlobalVariables.gsProductBOM = Conversions.ToString(False)
				End If
				Dim flag12 As Boolean = Operators.CompareString(GlobalVariables.gsLoginID.ToLower(), "admin", False) = 0
				If flag12 Then
					Me.mnuEmailTest.Visible = True
					Me.mnuEmailTest.Enabled = True
					Me.mnuTest.Visible = True
					Me.mnuTest.Enabled = True
				Else
					Me.mnuEmailTest.Visible = False
					Me.mnuEmailTest.Enabled = False
					Me.mnuTest.Visible = False
					Me.mnuTest.Enabled = False
				End If
			End If
		End Sub

		' Token: 0x060008D7 RID: 2263 RVA: 0x0004DDE8 File Offset: 0x0004BFE8
		Private Sub txtUser_GotFocus(sender As Object, e As EventArgs)
			Me.SetTextBox(True, Me.skip_txtUser)
		End Sub

		' Token: 0x060008D8 RID: 2264 RVA: 0x0004DDF9 File Offset: 0x0004BFF9
		Private Sub txtPass_GotFocus(sender As Object, e As EventArgs)
			Me.SetTextBox(True, Me.skip_txtPass)
		End Sub

		' Token: 0x060008D9 RID: 2265 RVA: 0x0004DE0A File Offset: 0x0004C00A
		Private Sub txtUser_LostFocus(sender As Object, e As EventArgs)
			Me.SetTextBox(False, Me.skip_txtUser)
		End Sub

		' Token: 0x060008DA RID: 2266 RVA: 0x0004DE1B File Offset: 0x0004C01B
		Private Sub txtPass_LostFocus(sender As Object, e As EventArgs)
			Me.SetTextBox(False, Me.skip_txtPass)
		End Sub

		' Token: 0x060008DB RID: 2267 RVA: 0x0004DE2C File Offset: 0x0004C02C
		Private Sub SetTextBox(sType As Boolean, sCtrl As TextBox)
			Dim flag As Boolean = Operators.CompareString(sCtrl.Name, "skip_txtUser", False) = 0
			If flag Then
				Dim flag2 As Boolean = (Operators.CompareString(sCtrl.Text, "", False) = 0) Or (Operators.CompareString(sCtrl.Text, "Enter LoginID", False) = 0)
				If flag2 Then
					sCtrl.ForeColor = Color.DarkGray
					If sType Then
						sCtrl.Text = ""
					Else
						sCtrl.Text = "Enter LoginID"
					End If
				Else
					sCtrl.ForeColor = ResourceModule.TextForecolor
				End If
			Else
				Dim flag3 As Boolean = (Operators.CompareString(sCtrl.Text, "", False) = 0) Or (Operators.CompareString(sCtrl.Text, "Enter Password", False) = 0)
				If flag3 Then
					sCtrl.ForeColor = Color.DarkGray
					If sType Then
						sCtrl.Text = ""
						sCtrl.PasswordChar = "*"c
					Else
						sCtrl.Text = "Enter Password"
						sCtrl.PasswordChar = vbNullChar
					End If
				Else
					sCtrl.ForeColor = ResourceModule.TextForecolor
					sCtrl.PasswordChar = "*"c
				End If
			End If
		End Sub

		' Token: 0x060008DC RID: 2268 RVA: 0x0004DF50 File Offset: 0x0004C150
		Private Sub txtUser_TextChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = (Operators.CompareString(Me.skip_txtUser.Text, "", False) = 0) Or (Operators.CompareString(Me.skip_txtUser.Text, "Enter LoginID", False) = 0)
			If flag Then
				Me.skip_txtUser.ForeColor = Color.DarkGray
			Else
				Me.skip_txtUser.ForeColor = ResourceModule.TextForecolor
			End If
		End Sub

		' Token: 0x060008DD RID: 2269 RVA: 0x0004DFBC File Offset: 0x0004C1BC
		Private Sub txtPass_TextChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = (Operators.CompareString(Me.skip_txtPass.Text, "", False) = 0) Or (Operators.CompareString(Me.skip_txtPass.Text, "Enter Password", False) = 0)
			If flag Then
				Me.skip_txtPass.ForeColor = Color.DarkGray
			Else
				Me.skip_txtPass.ForeColor = ResourceModule.TextForecolor
			End If
		End Sub

		' Token: 0x060008DE RID: 2270 RVA: 0x0004E028 File Offset: 0x0004C228
		Private Sub skip_btnShow_MouseDown(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.skip_txtPass.Text, "Enter Password", False) <> 0
			If flag Then
				Me.skip_btnShow.BackgroundImage = ResourceModule.imgMDIHide
				Me.skip_txtPass.PasswordChar = vbNullChar
			End If
		End Sub

		' Token: 0x060008DF RID: 2271 RVA: 0x0004E074 File Offset: 0x0004C274
		Private Sub skip_btnShow_MouseUp(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.skip_txtPass.Text, "Enter Password", False) <> 0
			If flag Then
				Me.skip_btnShow.BackgroundImage = ResourceModule.imgMDIReveal
				Me.skip_txtPass.PasswordChar = "*"c
			End If
		End Sub

		' Token: 0x060008E0 RID: 2272 RVA: 0x0004E0C0 File Offset: 0x0004C2C0
		Private Sub skip_txtUser_KeyDown(sender As Object, e As KeyEventArgs)
			Dim keyCode As Keys = e.KeyCode
			Dim flag As Boolean = keyCode = Keys.Left OrElse keyCode = Keys.Right OrElse (keyCode >= Keys.D0 AndAlso keyCode <= Keys.D9) OrElse (keyCode >= Keys.A AndAlso keyCode <= Keys.Z) OrElse (keyCode >= Keys.NumPad0 AndAlso keyCode <= Keys.NumPad9) OrElse keyCode = Keys.Back
			If Not flag Then
				flag = keyCode = Keys.Space
				If flag Then
					e.SuppressKeyPress = True
				Else
					e.SuppressKeyPress = True
				End If
			End If
		End Sub

		' Token: 0x060008E1 RID: 2273 RVA: 0x0004E128 File Offset: 0x0004C328
		Private Sub mnuVendor_Click(sender As Object, e As EventArgs)
			Dim vendor As Vendor = New Vendor()
			vendor.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008E2 RID: 2274 RVA: 0x0004E14C File Offset: 0x0004C34C
		Private Sub mnuProduct_Click(sender As Object, e As EventArgs)
			Dim product As Product01 = New Product01("Menu")
			product.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008E3 RID: 2275 RVA: 0x0004E174 File Offset: 0x0004C374
		Private Sub mnuProductBOM_Click(sender As Object, e As EventArgs)
			Dim productBOM As ProductBOM01 = New ProductBOM01("Entry")
			productBOM.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008E4 RID: 2276 RVA: 0x0004E19C File Offset: 0x0004C39C
		Private Sub mnuBOMApproval_Click(sender As Object, e As EventArgs)
			Dim productBOM As ProductBOM01 = New ProductBOM01("Approval")
			productBOM.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008E5 RID: 2277 RVA: 0x0004E1C4 File Offset: 0x0004C3C4
		Private Sub mnuLocation_Click(sender As Object, e As EventArgs)
			Dim locationMap As LocationMap = New LocationMap()
			locationMap.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008E6 RID: 2278 RVA: 0x0004E1E8 File Offset: 0x0004C3E8
		Private Sub mnuUser_Click(sender As Object, e As EventArgs)
			Dim userMst As UserMst = New UserMst()
			userMst.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008E7 RID: 2279 RVA: 0x0004E20C File Offset: 0x0004C40C
		Private Sub mnuUserGroup_Click(sender As Object, e As EventArgs)
			Dim userGroup As UserGroup = New UserGroup()
			userGroup.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008E8 RID: 2280 RVA: 0x0004E230 File Offset: 0x0004C430
		Private Sub mnuPRCreation_Click(sender As Object, e As EventArgs)
			Dim prgeneration As PRGeneration = New PRGeneration("PR Add", Nothing)
			prgeneration.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008E9 RID: 2281 RVA: 0x0004E258 File Offset: 0x0004C458
		Private Sub mnuPRModfication_Click(sender As Object, e As EventArgs)
			Dim prlist As PRList = New PRList("PR")
			prlist.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008EA RID: 2282 RVA: 0x0004E280 File Offset: 0x0004C480
		Private Sub mnuPRApproval_Click(sender As Object, e As EventArgs)
			Dim prlist As PRList = New PRList("PR Approval")
			prlist.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008EB RID: 2283 RVA: 0x0004E2A8 File Offset: 0x0004C4A8
		Private Sub mnuPRCostApproval_Click(sender As Object, e As EventArgs)
			Dim prlist As PRList = New PRList("PR Cost Approval")
			prlist.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008EC RID: 2284 RVA: 0x0004E2D0 File Offset: 0x0004C4D0
		Private Sub mnuPOCreation_Click(sender As Object, e As EventArgs)
			Dim pogeneration As POGeneration01 = New POGeneration01("PO Add", Nothing)
			pogeneration.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008ED RID: 2285 RVA: 0x0004E2F8 File Offset: 0x0004C4F8
		Private Sub mnuPOModfication_Click(sender As Object, e As EventArgs)
			Dim polist As POList = New POList("PO")
			polist.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008EE RID: 2286 RVA: 0x0004E320 File Offset: 0x0004C520
		Private Sub mnuPOApproval_Click(sender As Object, e As EventArgs)
			Dim polist As POList = New POList("PO Approval")
			polist.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008EF RID: 2287 RVA: 0x0004E348 File Offset: 0x0004C548
		Private Sub mnuPOCostApproval_Click(sender As Object, e As EventArgs)
			Dim polist As POList = New POList("PO Cost Approval")
			polist.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008F0 RID: 2288 RVA: 0x0004E370 File Offset: 0x0004C570
		Private Sub mnuPOPrinting_Click(sender As Object, e As EventArgs)
			Dim polist As POList = New POList("PO Printing")
			polist.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008F1 RID: 2289 RVA: 0x0004E398 File Offset: 0x0004C598
		Private Sub mnuPOAmmendment_Click(sender As Object, e As EventArgs)
			Dim polist As POList = New POList("PO Amendment")
			polist.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008F2 RID: 2290 RVA: 0x0004E3C0 File Offset: 0x0004C5C0
		Private Sub mnuReceipt_Click(sender As Object, e As EventArgs)
			Dim grn As GRN = New GRN("GRN Entry", "Receipt", Nothing)
			grn.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008F3 RID: 2291 RVA: 0x0004E3EC File Offset: 0x0004C5EC
		Private Sub mnuPO_Click(sender As Object, e As EventArgs)
			Dim grnlist As GRNList = New GRNList("GRN PO Receipt", "Receipt")
			grnlist.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008F4 RID: 2292 RVA: 0x0004E418 File Offset: 0x0004C618
		Private Sub mnuBMR_Click(sender As Object, e As EventArgs)
			Dim grn As GRN = New GRN("GRN Entry", "BMR", Nothing)
			grn.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008F5 RID: 2293 RVA: 0x0004E444 File Offset: 0x0004C644
		Private Sub mnuReturn_Click(sender As Object, e As EventArgs)
			Dim grn As GRN = New GRN("GRN Entry", "Return", Nothing)
			grn.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008F6 RID: 2294 RVA: 0x0004E470 File Offset: 0x0004C670
		Private Sub mnuReceipt_Modify_Click(sender As Object, e As EventArgs)
			Dim grnlist As GRNList = New GRNList("GRN", "Receipt")
			grnlist.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008F7 RID: 2295 RVA: 0x0004E49C File Offset: 0x0004C69C
		Private Sub mnuPO_Modify_Click(sender As Object, e As EventArgs)
			Dim grnlist As GRNList = New GRNList("GRN", "Receipt")
			grnlist.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008F8 RID: 2296 RVA: 0x0004E4C8 File Offset: 0x0004C6C8
		Private Sub mnuBMR_Modify_Click(sender As Object, e As EventArgs)
			Dim grnlist As GRNList = New GRNList("GRN", "BMR")
			grnlist.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008F9 RID: 2297 RVA: 0x0004E4F4 File Offset: 0x0004C6F4
		Private Sub mnuReturn_Modify_Click(sender As Object, e As EventArgs)
			Dim grnlist As GRNList = New GRNList("GRN", "Return")
			grnlist.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008FA RID: 2298 RVA: 0x0004E520 File Offset: 0x0004C720
		Private Sub mnuReceipt_Approval_Click(sender As Object, e As EventArgs)
			Dim grnlist As GRNList = New GRNList("GRN Approval", "Receipt")
			grnlist.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008FB RID: 2299 RVA: 0x0004E54C File Offset: 0x0004C74C
		Private Sub mnuPO_Approval_Click(sender As Object, e As EventArgs)
			Dim grnlist As GRNList = New GRNList("GRN Approval", "Receipt")
			grnlist.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008FC RID: 2300 RVA: 0x0004E578 File Offset: 0x0004C778
		Private Sub mnuBMR_Approval_Click(sender As Object, e As EventArgs)
			Dim grnlist As GRNList = New GRNList("GRN Approval", "BMR")
			grnlist.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008FD RID: 2301 RVA: 0x0004E5A4 File Offset: 0x0004C7A4
		Private Sub mnuReturn_Approval_Click(sender As Object, e As EventArgs)
			Dim grnlist As GRNList = New GRNList("GRN Approval", "Return")
			grnlist.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008FE RID: 2302 RVA: 0x0004E5D0 File Offset: 0x0004C7D0
		Private Sub mnuGRNCancellation_Click(sender As Object, e As EventArgs)
			Dim grnlist As GRNList = New GRNList("GRN Cancellation", "")
			grnlist.Show(Me.DockPanel)
		End Sub

		' Token: 0x060008FF RID: 2303 RVA: 0x0004E5FC File Offset: 0x0004C7FC
		Private Sub mnuGRNPrinting_Click(sender As Object, e As EventArgs)
			Dim grnlistItem As GRNListItem = New GRNListItem("GRN Printing")
			grnlistItem.Show(Me.DockPanel)
		End Sub

		' Token: 0x06000900 RID: 2304 RVA: 0x0004E624 File Offset: 0x0004C824
		Private Sub mnuQCEntry_Click(sender As Object, e As EventArgs)
			Dim grnlistItem As GRNListItem = New GRNListItem("GRN QC Entry")
			grnlistItem.Show(Me.DockPanel)
		End Sub

		' Token: 0x06000901 RID: 2305 RVA: 0x0004E64C File Offset: 0x0004C84C
		Private Sub mnuQC_Click(sender As Object, e As EventArgs)
			Dim grnlistItem As GRNListItem = New GRNListItem("GRN QC Release")
			grnlistItem.Show(Me.DockPanel)
		End Sub

		' Token: 0x06000902 RID: 2306 RVA: 0x0004E674 File Offset: 0x0004C874
		Private Sub mnuQARelease_Click(sender As Object, e As EventArgs)
			Dim grnlistItem As GRNListItem = New GRNListItem("GRN QA Release")
			grnlistItem.Show(Me.DockPanel)
		End Sub

		' Token: 0x06000903 RID: 2307 RVA: 0x0004E69C File Offset: 0x0004C89C
		Private Sub mnuConcentration_Click(sender As Object, e As EventArgs)
			Dim grnlistItem As GRNListItem = New GRNListItem("Concentration & Titre")
			grnlistItem.Show(Me.DockPanel)
		End Sub

		' Token: 0x06000904 RID: 2308 RVA: 0x0004E6C4 File Offset: 0x0004C8C4
		Private Sub mnuMaterialRequest_Click(sender As Object, e As EventArgs)
			Dim requestList As RequestList = New RequestList("Request")
			requestList.Show(Me.DockPanel)
		End Sub

		' Token: 0x06000905 RID: 2309 RVA: 0x0004E6EC File Offset: 0x0004C8EC
		Private Sub mnuPicking_Click(sender As Object, e As EventArgs)
			Dim issueList As IssueList = New IssueList("Picking")
			issueList.Show(Me.DockPanel)
		End Sub

		' Token: 0x06000906 RID: 2310 RVA: 0x0004E714 File Offset: 0x0004C914
		Private Sub mnuQAApproval_Click(sender As Object, e As EventArgs)
			Dim issueList As IssueList = New IssueList("QA Approval")
			issueList.Show(Me.DockPanel)
		End Sub

		' Token: 0x06000907 RID: 2311 RVA: 0x0004E73C File Offset: 0x0004C93C
		Private Sub mnuMaterialIssue_Click(sender As Object, e As EventArgs)
			Dim issueList As IssueList = New IssueList("Issue")
			issueList.Show(Me.DockPanel)
		End Sub

		' Token: 0x06000908 RID: 2312 RVA: 0x0004E764 File Offset: 0x0004C964
		Private Sub mnuDispose_Click(sender As Object, e As EventArgs)
			Dim dispose As Dispose = New Dispose()
			dispose.Show(Me.DockPanel)
		End Sub

		' Token: 0x06000909 RID: 2313 RVA: 0x0004E788 File Offset: 0x0004C988
		Private Sub mnuLocationMapping_Click(sender As Object, e As EventArgs)
			Dim binning As Binning = New Binning()
			binning.ShowDialog()
		End Sub

		' Token: 0x0600090A RID: 2314 RVA: 0x0004E7A4 File Offset: 0x0004C9A4
		Private Sub mnuPRReport_Click(sender As Object, e As EventArgs)
			Dim prreport As PRReport = New PRReport("")
			prreport.Show(Me.DockPanel)
		End Sub

		' Token: 0x0600090B RID: 2315 RVA: 0x0004E7CC File Offset: 0x0004C9CC
		Private Sub mnuPOReport_Click(sender As Object, e As EventArgs)
			Dim poreport As POReport = New POReport()
			poreport.Show(Me.DockPanel)
		End Sub

		' Token: 0x0600090C RID: 2316 RVA: 0x0004E7F0 File Offset: 0x0004C9F0
		Private Sub mnuGRNReport_Click(sender As Object, e As EventArgs)
			Dim grnreport As GRNReport = New GRNReport()
			grnreport.Show(Me.DockPanel)
		End Sub

		' Token: 0x0600090D RID: 2317 RVA: 0x0004E814 File Offset: 0x0004CA14
		Private Sub mnuRequestReport_Click(sender As Object, e As EventArgs)
			Dim requestReport As RequestReport = New RequestReport()
			requestReport.Show(Me.DockPanel)
		End Sub

		' Token: 0x0600090E RID: 2318 RVA: 0x0004E838 File Offset: 0x0004CA38
		Private Sub mnuActivityLog_Click(sender As Object, e As EventArgs)
			Dim activityLog As ActivityLog = New ActivityLog()
			activityLog.Show(Me.DockPanel)
		End Sub

		' Token: 0x0600090F RID: 2319 RVA: 0x0004E85C File Offset: 0x0004CA5C
		Private Sub mnuStockReport_Click(sender As Object, e As EventArgs)
			Dim stockReport As StockReport = New StockReport("")
			stockReport.Show(Me.DockPanel)
		End Sub

		' Token: 0x06000910 RID: 2320 RVA: 0x0004E884 File Offset: 0x0004CA84
		Private Sub mnuConsumptionReport_Click(sender As Object, e As EventArgs)
			Dim consumptionReport As ConsumptionReport = New ConsumptionReport()
			consumptionReport.Show(Me.DockPanel)
		End Sub

		' Token: 0x06000911 RID: 2321 RVA: 0x0004E8A8 File Offset: 0x0004CAA8
		Private Sub mnuClosingStockReport_Click(sender As Object, e As EventArgs)
			Dim closingStock As ClosingStock = New ClosingStock()
			closingStock.Show(Me.DockPanel)
		End Sub

		' Token: 0x06000912 RID: 2322 RVA: 0x0004E8CC File Offset: 0x0004CACC
		Private Sub mnuQuarentineStockReport_Click(sender As Object, e As EventArgs)
			Dim qurantineReport As QurantineReport = New QurantineReport()
			qurantineReport.Show(Me.DockPanel)
		End Sub

		' Token: 0x06000913 RID: 2323 RVA: 0x0004E8F0 File Offset: 0x0004CAF0
		Private Sub mnuProductBOMReport_Click(sender As Object, e As EventArgs)
			Dim bomreport As BOMReport = New BOMReport()
			bomreport.Show(Me.DockPanel)
		End Sub

		' Token: 0x06000914 RID: 2324 RVA: 0x0004E914 File Offset: 0x0004CB14
		Private Sub mnuEmailAlerts_Click(sender As Object, e As EventArgs)
			Dim emailAlert As EmailAlert = New EmailAlert()
			emailAlert.Show(Me.DockPanel)
		End Sub

		' Token: 0x06000915 RID: 2325 RVA: 0x0004E938 File Offset: 0x0004CB38
		Private Sub mnuChangePassword_Click(sender As Object, e As EventArgs)
			Dim changePassword As ChangePassword = New ChangePassword("Reset Password")
			changePassword.ShowDialog()
		End Sub

		' Token: 0x06000916 RID: 2326 RVA: 0x0004E958 File Offset: 0x0004CB58
		Private Sub mnuPRApproverList_Click(sender As Object, e As EventArgs)
			Dim approvalRange As ApprovalRange = New ApprovalRange()
			approvalRange.Show(Me.DockPanel)
		End Sub

		' Token: 0x06000917 RID: 2327 RVA: 0x0004E97C File Offset: 0x0004CB7C
		Private Sub mnuPOApproverList_Click(sender As Object, e As EventArgs)
			Dim poapprovalRange As POApprovalRange = New POApprovalRange()
			poapprovalRange.Show(Me.DockPanel)
		End Sub

		' Token: 0x06000918 RID: 2328 RVA: 0x0004E9A0 File Offset: 0x0004CBA0
		Private Sub mnuEmailTest_Click(sender As Object, e As EventArgs)
			Dim emailTest As EmailTest = New EmailTest()
			emailTest.ShowDialog()
		End Sub

		' Token: 0x06000919 RID: 2329 RVA: 0x0004E9BC File Offset: 0x0004CBBC
		Private Sub mnuTest_Click(sender As Object, e As EventArgs)
			Dim tcpprinting As TCPPrinting = New TCPPrinting()
			tcpprinting.Show()
		End Sub

		' Token: 0x0600091A RID: 2330 RVA: 0x0004E9D7 File Offset: 0x0004CBD7
		Private Sub pnlBar_Paint(sender As Object, e As PaintEventArgs)
		End Sub

		' Token: 0x0600091B RID: 2331 RVA: 0x0004E9DC File Offset: 0x0004CBDC
		Private Sub mnuStockUpload_Click(sender As Object, e As EventArgs)
			Dim uploadStock As UploadStock = New UploadStock()
			uploadStock.Show(Me.DockPanel)
		End Sub

		' Token: 0x0600091C RID: 2332 RVA: 0x0004EA00 File Offset: 0x0004CC00
		Private Sub mnuAbout_Click(sender As Object, e As EventArgs)
			Dim about As About = New About()
			about.ShowDialog()
		End Sub

		' Token: 0x040003BD RID: 957
		Private cnt As Long

		' Token: 0x040003BE RID: 958
		Private iAttemptLock As Integer

		' Token: 0x040003BF RID: 959
		Private bProfilePanelExpand As Boolean

		' Token: 0x040003C0 RID: 960
		Private iProfilePanelHeight As Integer

		' Token: 0x040003C1 RID: 961
		Private oFormReLogin As Form

		' Token: 0x040003C2 RID: 962
		Private AutoLockTime As Long

		' Token: 0x040003C3 RID: 963
		Private IdleTimer As IdleTime1

		' Token: 0x040003C4 RID: 964
		Private lDeactiveTime As Long

		' Token: 0x040003C5 RID: 965
		Private sMeText As String

		' Token: 0x040003C6 RID: 966
		Private sSession As String

		' Token: 0x040003C7 RID: 967
		Private sReLoadLockScreen As Boolean

		' Token: 0x040003C8 RID: 968
		Private oThread As Thread

		' Token: 0x040003C9 RID: 969
		Private oLogoutTimer As Global.System.Timers.Timer
	End Class
End Namespace
