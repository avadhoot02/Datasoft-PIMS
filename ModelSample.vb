Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x0200000C RID: 12
	<DesignerGenerated()>
	Public Partial Class ModelSample
		Inherits Form

		' Token: 0x1700002D RID: 45
		' (get) Token: 0x06000082 RID: 130 RVA: 0x00005264 File Offset: 0x00003464
		' (set) Token: 0x06000083 RID: 131 RVA: 0x0000526E File Offset: 0x0000346E
		Friend Overridable Property pnlShadow As Panel

		' Token: 0x1700002E RID: 46
		' (get) Token: 0x06000084 RID: 132 RVA: 0x00005277 File Offset: 0x00003477
		' (set) Token: 0x06000085 RID: 133 RVA: 0x00005281 File Offset: 0x00003481
		Friend Overridable Property pnlBorder As Panel

		' Token: 0x1700002F RID: 47
		' (get) Token: 0x06000086 RID: 134 RVA: 0x0000528A File Offset: 0x0000348A
		' (set) Token: 0x06000087 RID: 135 RVA: 0x00005294 File Offset: 0x00003494
		Friend Overridable Property pnlMain As Panel

		' Token: 0x17000030 RID: 48
		' (get) Token: 0x06000088 RID: 136 RVA: 0x0000529D File Offset: 0x0000349D
		' (set) Token: 0x06000089 RID: 137 RVA: 0x000052A8 File Offset: 0x000034A8
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

		' Token: 0x17000031 RID: 49
		' (get) Token: 0x0600008A RID: 138 RVA: 0x000052EB File Offset: 0x000034EB
		' (set) Token: 0x0600008B RID: 139 RVA: 0x000052F5 File Offset: 0x000034F5
		Friend Overridable Property picFormIcon As PictureBox

		' Token: 0x17000032 RID: 50
		' (get) Token: 0x0600008C RID: 140 RVA: 0x000052FE File Offset: 0x000034FE
		' (set) Token: 0x0600008D RID: 141 RVA: 0x00005308 File Offset: 0x00003508
		Friend Overridable Property lblCaption As Label

		' Token: 0x17000033 RID: 51
		' (get) Token: 0x0600008E RID: 142 RVA: 0x00005311 File Offset: 0x00003511
		' (set) Token: 0x0600008F RID: 143 RVA: 0x0000531C File Offset: 0x0000351C
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

		' Token: 0x06000090 RID: 144
		Private Declare Sub SendMessage Lib "user32.DLL" (hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

		' Token: 0x06000091 RID: 145
		Private Declare Sub ReleaseCapture Lib "user32.DLL" ()

		' Token: 0x06000092 RID: 146 RVA: 0x0000535F File Offset: 0x0000355F
		Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs)
			ModelSample.ReleaseCapture()
			ModelSample.SendMessage(MyBase.Handle, 274, 61458, 0)
		End Sub

		' Token: 0x06000093 RID: 147 RVA: 0x00005380 File Offset: 0x00003580
		Public Sub New()
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
		End Sub

		' Token: 0x06000094 RID: 148 RVA: 0x00005416 File Offset: 0x00003616
		Private Sub form_btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06000095 RID: 149 RVA: 0x00005420 File Offset: 0x00003620
		Private Sub Me_Load(sender As Object, e As EventArgs)
		End Sub
	End Class
End Namespace
