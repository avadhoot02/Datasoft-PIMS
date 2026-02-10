Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Media
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Datasoft_PIMS.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x0200000A RID: 10
	<DesignerGenerated()>
	Public Partial Class FormMessageBox
		Inherits Form

		' Token: 0x17000017 RID: 23
		' (get) Token: 0x0600003D RID: 61 RVA: 0x000039A9 File Offset: 0x00001BA9
		' (set) Token: 0x0600003E RID: 62 RVA: 0x000039B3 File Offset: 0x00001BB3
		Friend Overridable Property pnlBorder As Panel

		' Token: 0x17000018 RID: 24
		' (get) Token: 0x0600003F RID: 63 RVA: 0x000039BC File Offset: 0x00001BBC
		' (set) Token: 0x06000040 RID: 64 RVA: 0x000039C6 File Offset: 0x00001BC6
		Friend Overridable Property pnlMain As Panel

		' Token: 0x17000019 RID: 25
		' (get) Token: 0x06000041 RID: 65 RVA: 0x000039CF File Offset: 0x00001BCF
		' (set) Token: 0x06000042 RID: 66 RVA: 0x000039DC File Offset: 0x00001BDC
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

		' Token: 0x1700001A RID: 26
		' (get) Token: 0x06000043 RID: 67 RVA: 0x00003A1F File Offset: 0x00001C1F
		' (set) Token: 0x06000044 RID: 68 RVA: 0x00003A29 File Offset: 0x00001C29
		Friend Overridable Property lblCaption As Label

		' Token: 0x1700001B RID: 27
		' (get) Token: 0x06000045 RID: 69 RVA: 0x00003A32 File Offset: 0x00001C32
		' (set) Token: 0x06000046 RID: 70 RVA: 0x00003A3C File Offset: 0x00001C3C
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

		' Token: 0x1700001C RID: 28
		' (get) Token: 0x06000047 RID: 71 RVA: 0x00003A7F File Offset: 0x00001C7F
		' (set) Token: 0x06000048 RID: 72 RVA: 0x00003A89 File Offset: 0x00001C89
		Friend Overridable Property pnlShadow As Panel

		' Token: 0x1700001D RID: 29
		' (get) Token: 0x06000049 RID: 73 RVA: 0x00003A92 File Offset: 0x00001C92
		' (set) Token: 0x0600004A RID: 74 RVA: 0x00003A9C File Offset: 0x00001C9C
		Friend Overridable Property pnlButton As Panel

		' Token: 0x1700001E RID: 30
		' (get) Token: 0x0600004B RID: 75 RVA: 0x00003AA5 File Offset: 0x00001CA5
		' (set) Token: 0x0600004C RID: 76 RVA: 0x00003AAF File Offset: 0x00001CAF
		Friend Overridable Property flpButton As FlowLayoutPanel

		' Token: 0x1700001F RID: 31
		' (get) Token: 0x0600004D RID: 77 RVA: 0x00003AB8 File Offset: 0x00001CB8
		' (set) Token: 0x0600004E RID: 78 RVA: 0x00003AC2 File Offset: 0x00001CC2
		Friend Overridable Property button1 As Button

		' Token: 0x17000020 RID: 32
		' (get) Token: 0x0600004F RID: 79 RVA: 0x00003ACB File Offset: 0x00001CCB
		' (set) Token: 0x06000050 RID: 80 RVA: 0x00003AD5 File Offset: 0x00001CD5
		Friend Overridable Property button2 As Button

		' Token: 0x17000021 RID: 33
		' (get) Token: 0x06000051 RID: 81 RVA: 0x00003ADE File Offset: 0x00001CDE
		' (set) Token: 0x06000052 RID: 82 RVA: 0x00003AE8 File Offset: 0x00001CE8
		Friend Overridable Property button3 As Button

		' Token: 0x17000022 RID: 34
		' (get) Token: 0x06000053 RID: 83 RVA: 0x00003AF1 File Offset: 0x00001CF1
		' (set) Token: 0x06000054 RID: 84 RVA: 0x00003AFB File Offset: 0x00001CFB
		Friend Overridable Property pnlBody As Panel

		' Token: 0x17000023 RID: 35
		' (get) Token: 0x06000055 RID: 85 RVA: 0x00003B04 File Offset: 0x00001D04
		' (set) Token: 0x06000056 RID: 86 RVA: 0x00003B0E File Offset: 0x00001D0E
		Friend Overridable Property lblMsg As Label

		' Token: 0x17000024 RID: 36
		' (get) Token: 0x06000057 RID: 87 RVA: 0x00003B17 File Offset: 0x00001D17
		' (set) Token: 0x06000058 RID: 88 RVA: 0x00003B21 File Offset: 0x00001D21
		Friend Overridable Property picIcon As PictureBox

		' Token: 0x06000059 RID: 89
		Private Declare Sub SendMessage Lib "user32.DLL" (hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

		' Token: 0x0600005A RID: 90
		Private Declare Sub ReleaseCapture Lib "user32.DLL" ()

		' Token: 0x0600005B RID: 91 RVA: 0x00003B2A File Offset: 0x00001D2A
		Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs)
			FormMessageBox.ReleaseCapture()
			FormMessageBox.SendMessage(MyBase.Handle, 274, 61458, 0)
		End Sub

		' Token: 0x0600005C RID: 92 RVA: 0x00003B4C File Offset: 0x00001D4C
		Public Sub New(text As String)
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.InitializeComponent()
			Me.InitializeItems()
			Me.lblMsg.Text = text
			Me.lblCaption.Text = ""
			Me.SetFormSize()
			Me.SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1)
			Me.SetIcon(MessageBoxIcon.None)
		End Sub

		' Token: 0x0600005D RID: 93 RVA: 0x00003BB8 File Offset: 0x00001DB8
		Public Sub New(text As String, caption As String)
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.InitializeComponent()
			Me.InitializeItems()
			Me.lblMsg.Text = text
			Me.lblCaption.Text = caption
			Me.SetFormSize()
			Me.SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1)
			Me.SetIcon(MessageBoxIcon.None)
		End Sub

		' Token: 0x0600005E RID: 94 RVA: 0x00003C20 File Offset: 0x00001E20
		Public Sub New(text As String, caption As String, buttons As MessageBoxButtons)
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.InitializeComponent()
			Me.InitializeItems()
			Me.lblMsg.Text = text
			Me.lblCaption.Text = caption
			Me.SetFormSize()
			Me.SetButtons(buttons, MessageBoxDefaultButton.Button1)
			Me.SetIcon(MessageBoxIcon.None)
		End Sub

		' Token: 0x0600005F RID: 95 RVA: 0x00003C88 File Offset: 0x00001E88
		Public Sub New(text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon)
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.InitializeComponent()
			Me.InitializeItems()
			Me.lblMsg.Text = text
			Me.lblCaption.Text = caption
			Me.SetFormSize()
			Me.SetButtons(buttons, MessageBoxDefaultButton.Button1)
			Me.SetIcon(icon)
		End Sub

		' Token: 0x06000060 RID: 96 RVA: 0x00003CF4 File Offset: 0x00001EF4
		Public Sub New(text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon, defaultButton As MessageBoxDefaultButton)
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.InitializeComponent()
			Me.InitializeItems()
			Me.lblMsg.Text = text
			Me.lblCaption.Text = caption
			Me.SetFormSize()
			Me.SetButtons(buttons, defaultButton)
			Me.SetIcon(icon)
		End Sub

		' Token: 0x06000061 RID: 97 RVA: 0x00003D60 File Offset: 0x00001F60
		Private Sub InitializeItems()
			Designing.SetTheme(Me)
			MyBase.FormBorderStyle = FormBorderStyle.None
			Me.BackColor = Color.GhostWhite
			Me.lblMsg.MaximumSize = New Size(550, 0)
			Me.form_btnClose.DialogResult = DialogResult.Cancel
			Me.button1.DialogResult = DialogResult.OK
			Me.button1.Visible = False
			Me.button2.Visible = False
			Me.button3.Visible = False
		End Sub

		' Token: 0x06000062 RID: 98 RVA: 0x00003DE4 File Offset: 0x00001FE4
		Private Sub SetFormSize()
			' The following expression was wrapped in a checked-statement
			MyBase.Width = Me.picIcon.Width + Me.lblMsg.Width + 70
			Dim flag As Boolean = Me.lblMsg.Height > Me.pnlBody.Height
			If flag Then
				MyBase.Height = Me.lblMsg.Height + Me.pnlButton.Height + 70
			End If
			Dim num As Integer = MyBase.Height - Me.pnlButton.Height
			Dim height As Integer = Me.lblMsg.Height
			Me.lblMsg.Top = CInt(Math.Round(CDbl(num) / 2.0 - CDbl(height) / 2.0 - 20.0))
		End Sub

		' Token: 0x06000063 RID: 99 RVA: 0x00003EA8 File Offset: 0x000020A8
		Private Sub SetButtons(buttons As MessageBoxButtons, defaultButton As MessageBoxDefaultButton)
			Dim num As Integer
			Select Case buttons
				Case MessageBoxButtons.OK
					Me.button1.Visible = True
					Me.button1.Text = "Ok"
					Me.button1.DialogResult = DialogResult.OK
					num = 2
					Me.SetDefaultButton(defaultButton)
					Me.form_btnClose.Enabled = True
				Case MessageBoxButtons.OKCancel
					Me.button1.Visible = True
					Me.button1.Text = "Ok"
					Me.button1.DialogResult = DialogResult.OK
					Me.button2.Visible = True
					Me.button2.Text = "Cancel"
					Me.button2.DialogResult = DialogResult.Cancel
					num = 1
					Dim flag As Boolean = defaultButton <> MessageBoxDefaultButton.Button3
					If flag Then
						Me.SetDefaultButton(defaultButton)
					Else
						Me.SetDefaultButton(MessageBoxDefaultButton.Button1)
					End If
					Me.form_btnClose.Enabled = True
				Case MessageBoxButtons.AbortRetryIgnore
					Me.button1.Visible = True
					Me.button1.Text = "Abort"
					Me.button1.DialogResult = DialogResult.Abort
					Me.button2.Visible = True
					Me.button2.Text = "Retry"
					Me.button2.DialogResult = DialogResult.Retry
					Me.button3.Visible = True
					Me.button3.Text = "Ignore"
					Me.button3.DialogResult = DialogResult.Ignore
					num = 0
					Me.SetDefaultButton(defaultButton)
					Me.form_btnClose.Enabled = False
				Case MessageBoxButtons.YesNoCancel
					Me.button1.Visible = True
					Me.button1.Text = "Yes"
					Me.button1.DialogResult = DialogResult.Yes
					Me.button2.Visible = True
					Me.button2.Text = "No"
					Me.button2.DialogResult = DialogResult.No
					Me.button3.Visible = True
					Me.button3.Text = "Cancel"
					Me.button3.DialogResult = DialogResult.Cancel
					num = 0
					Me.SetDefaultButton(defaultButton)
					Me.form_btnClose.Enabled = True
				Case MessageBoxButtons.YesNo
					Me.button1.Visible = True
					Me.button1.Text = "Yes"
					Me.button1.DialogResult = DialogResult.Yes
					Me.button2.Visible = True
					Me.button2.Text = "No"
					Me.button2.DialogResult = DialogResult.No
					num = 1
					Dim flag2 As Boolean = defaultButton <> MessageBoxDefaultButton.Button3
					If flag2 Then
						Me.SetDefaultButton(defaultButton)
					Else
						Me.SetDefaultButton(MessageBoxDefaultButton.Button1)
					End If
					Me.form_btnClose.Enabled = False
				Case MessageBoxButtons.RetryCancel
					Me.button1.Visible = True
					Me.button1.Text = "Retry"
					Me.button1.DialogResult = DialogResult.Retry
					Me.button2.Visible = True
					Me.button2.Text = "Cancel"
					Me.button2.DialogResult = DialogResult.Cancel
					num = 1
					Dim flag3 As Boolean = defaultButton <> MessageBoxDefaultButton.Button3
					If flag3 Then
						Me.SetDefaultButton(defaultButton)
					Else
						Me.SetDefaultButton(MessageBoxDefaultButton.Button1)
					End If
					Me.form_btnClose.Enabled = True
			End Select
			Me.flpButton.Width = Me.flpButton.Width - Me.button1.Width * num - 3
			Me.flpButton.Left = CInt(Math.Round(CDbl(MyBase.Width) / 2.0 - CDbl(Me.flpButton.Width) / 2.0))
		End Sub

		' Token: 0x06000064 RID: 100 RVA: 0x00004270 File Offset: 0x00002470
		Private Sub SetDefaultButton(defaultButton As MessageBoxDefaultButton)
			If defaultButton <> MessageBoxDefaultButton.Button1 Then
				If defaultButton <> MessageBoxDefaultButton.Button2 Then
					If defaultButton = MessageBoxDefaultButton.Button3 Then
						Me.button3.[Select]()
					End If
				Else
					Me.button2.[Select]()
				End If
			Else
				Me.button1.[Select]()
			End If
		End Sub

		' Token: 0x06000065 RID: 101 RVA: 0x000042C8 File Offset: 0x000024C8
		Private Sub SetIcon(icon As MessageBoxIcon)
			If icon <= MessageBoxIcon.Hand Then
				If icon <> MessageBoxIcon.None Then
					If icon = MessageBoxIcon.Hand Then
						Me.picIcon.Image = ResourceModule.imgMsgError
					End If
				End If
			ElseIf icon <> MessageBoxIcon.Question Then
				If icon <> MessageBoxIcon.Exclamation Then
					If icon = MessageBoxIcon.Asterisk Then
						Me.picIcon.Image = ResourceModule.imgMsgInformation
					End If
				Else
					Me.picIcon.Image = ResourceModule.imgMsgWarning
				End If
			Else
				Me.picIcon.Image = ResourceModule.imgMsgQuestion
			End If
		End Sub

		' Token: 0x06000066 RID: 102 RVA: 0x00004353 File Offset: 0x00002553
		Private Sub form_btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06000067 RID: 103 RVA: 0x0000435D File Offset: 0x0000255D
		Private Sub Me_Load(sender As Object, e As EventArgs)
			MyProject.Computer.Audio.PlaySystemSound(SystemSounds.Asterisk)
		End Sub
	End Class
End Namespace
