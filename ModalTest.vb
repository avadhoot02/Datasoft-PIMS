Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x0200000B RID: 11
	<DesignerGenerated()>
	Public Partial Class ModalTest
		Inherits Form

		' Token: 0x17000025 RID: 37
		' (get) Token: 0x0600006A RID: 106 RVA: 0x00004A45 File Offset: 0x00002C45
		' (set) Token: 0x0600006B RID: 107 RVA: 0x00004A4F File Offset: 0x00002C4F
		Friend Overridable Property pnlBorder As Panel

		' Token: 0x17000026 RID: 38
		' (get) Token: 0x0600006C RID: 108 RVA: 0x00004A58 File Offset: 0x00002C58
		' (set) Token: 0x0600006D RID: 109 RVA: 0x00004A62 File Offset: 0x00002C62
		Friend Overridable Property pnlMain As Panel

		' Token: 0x17000027 RID: 39
		' (get) Token: 0x0600006E RID: 110 RVA: 0x00004A6B File Offset: 0x00002C6B
		' (set) Token: 0x0600006F RID: 111 RVA: 0x00004A75 File Offset: 0x00002C75
		Friend Overridable Property lblShadow2 As Label

		' Token: 0x17000028 RID: 40
		' (get) Token: 0x06000070 RID: 112 RVA: 0x00004A7E File Offset: 0x00002C7E
		' (set) Token: 0x06000071 RID: 113 RVA: 0x00004A88 File Offset: 0x00002C88
		Friend Overridable Property lblShadow1 As Label

		' Token: 0x17000029 RID: 41
		' (get) Token: 0x06000072 RID: 114 RVA: 0x00004A91 File Offset: 0x00002C91
		' (set) Token: 0x06000073 RID: 115 RVA: 0x00004A9C File Offset: 0x00002C9C
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

		' Token: 0x1700002A RID: 42
		' (get) Token: 0x06000074 RID: 116 RVA: 0x00004ADF File Offset: 0x00002CDF
		' (set) Token: 0x06000075 RID: 117 RVA: 0x00004AE9 File Offset: 0x00002CE9
		Friend Overridable Property lblCaption As Label

		' Token: 0x1700002B RID: 43
		' (get) Token: 0x06000076 RID: 118 RVA: 0x00004AF2 File Offset: 0x00002CF2
		' (set) Token: 0x06000077 RID: 119 RVA: 0x00004AFC File Offset: 0x00002CFC
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

		' Token: 0x1700002C RID: 44
		' (get) Token: 0x06000078 RID: 120 RVA: 0x00004B3F File Offset: 0x00002D3F
		' (set) Token: 0x06000079 RID: 121 RVA: 0x00004B49 File Offset: 0x00002D49
		Friend Overridable Property picFormIcon As PictureBox

		' Token: 0x0600007A RID: 122
		Private Declare Sub SendMessage Lib "user32.DLL" (hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

		' Token: 0x0600007B RID: 123
		Private Declare Sub ReleaseCapture Lib "user32.DLL" ()

		' Token: 0x0600007C RID: 124 RVA: 0x00004B52 File Offset: 0x00002D52
		Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs)
			ModalTest.ReleaseCapture()
			ModalTest.SendMessage(MyBase.Handle, 274, 61458, 0)
		End Sub

		' Token: 0x0600007D RID: 125 RVA: 0x00004B74 File Offset: 0x00002D74
		Public Sub New()
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
		End Sub

		' Token: 0x0600007E RID: 126 RVA: 0x00004BFE File Offset: 0x00002DFE
		Private Sub form_btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x0600007F RID: 127 RVA: 0x00004C08 File Offset: 0x00002E08
		Private Sub Me_Load(sender As Object, e As EventArgs)
		End Sub
	End Class
End Namespace
