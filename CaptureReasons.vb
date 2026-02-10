Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x0200005E RID: 94
	<DesignerGenerated()>
	Public Partial Class CaptureReasons
		Inherits Form

		' Token: 0x1700080C RID: 2060
		' (get) Token: 0x0600150E RID: 5390 RVA: 0x000C190D File Offset: 0x000BFB0D
		' (set) Token: 0x0600150F RID: 5391 RVA: 0x000C1917 File Offset: 0x000BFB17
		Friend Overridable Property pnlBorder As Panel

		' Token: 0x1700080D RID: 2061
		' (get) Token: 0x06001510 RID: 5392 RVA: 0x000C1920 File Offset: 0x000BFB20
		' (set) Token: 0x06001511 RID: 5393 RVA: 0x000C192A File Offset: 0x000BFB2A
		Friend Overridable Property pnlMain As Panel

		' Token: 0x1700080E RID: 2062
		' (get) Token: 0x06001512 RID: 5394 RVA: 0x000C1933 File Offset: 0x000BFB33
		' (set) Token: 0x06001513 RID: 5395 RVA: 0x000C1940 File Offset: 0x000BFB40
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

		' Token: 0x1700080F RID: 2063
		' (get) Token: 0x06001514 RID: 5396 RVA: 0x000C1983 File Offset: 0x000BFB83
		' (set) Token: 0x06001515 RID: 5397 RVA: 0x000C198D File Offset: 0x000BFB8D
		Friend Overridable Property picFormIcon As PictureBox

		' Token: 0x17000810 RID: 2064
		' (get) Token: 0x06001516 RID: 5398 RVA: 0x000C1996 File Offset: 0x000BFB96
		' (set) Token: 0x06001517 RID: 5399 RVA: 0x000C19A0 File Offset: 0x000BFBA0
		Friend Overridable Property lblCaption As Label

		' Token: 0x17000811 RID: 2065
		' (get) Token: 0x06001518 RID: 5400 RVA: 0x000C19A9 File Offset: 0x000BFBA9
		' (set) Token: 0x06001519 RID: 5401 RVA: 0x000C19B4 File Offset: 0x000BFBB4
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

		' Token: 0x17000812 RID: 2066
		' (get) Token: 0x0600151A RID: 5402 RVA: 0x000C19F7 File Offset: 0x000BFBF7
		' (set) Token: 0x0600151B RID: 5403 RVA: 0x000C1A01 File Offset: 0x000BFC01
		Friend Overridable Property lblShadow1 As Label

		' Token: 0x17000813 RID: 2067
		' (get) Token: 0x0600151C RID: 5404 RVA: 0x000C1A0A File Offset: 0x000BFC0A
		' (set) Token: 0x0600151D RID: 5405 RVA: 0x000C1A14 File Offset: 0x000BFC14
		Friend Overridable Property lblShadow2 As Label

		' Token: 0x17000814 RID: 2068
		' (get) Token: 0x0600151E RID: 5406 RVA: 0x000C1A1D File Offset: 0x000BFC1D
		' (set) Token: 0x0600151F RID: 5407 RVA: 0x000C1A27 File Offset: 0x000BFC27
		Friend Overridable Property txtCancelReason As TextBox

		' Token: 0x17000815 RID: 2069
		' (get) Token: 0x06001520 RID: 5408 RVA: 0x000C1A30 File Offset: 0x000BFC30
		' (set) Token: 0x06001521 RID: 5409 RVA: 0x000C1A3C File Offset: 0x000BFC3C
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

		' Token: 0x17000816 RID: 2070
		' (get) Token: 0x06001522 RID: 5410 RVA: 0x000C1A7F File Offset: 0x000BFC7F
		' (set) Token: 0x06001523 RID: 5411 RVA: 0x000C1A89 File Offset: 0x000BFC89
		Friend Overridable Property lblReason As Label

		' Token: 0x06001524 RID: 5412
		Private Declare Sub SendMessage Lib "user32.DLL" (hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

		' Token: 0x06001525 RID: 5413
		Private Declare Sub ReleaseCapture Lib "user32.DLL" ()

		' Token: 0x06001526 RID: 5414 RVA: 0x000C1A92 File Offset: 0x000BFC92
		Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs)
			CaptureReasons.ReleaseCapture()
			CaptureReasons.SendMessage(MyBase.Handle, 274, 61458, 0)
		End Sub

		' Token: 0x06001527 RID: 5415 RVA: 0x000C1AB4 File Offset: 0x000BFCB4
		Public Sub New(sType As String)
			AddHandler MyBase.Load, AddressOf Me.CaptureReasons_Load
			Me.InitializeComponent()
			Designing.SetTheme(Me)
			Me.picFormIcon.Image = ResourceModule.imgFormIconPic
			MyBase.FormBorderStyle = FormBorderStyle.None
			Me.BackColor = Color.DarkGray
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.lblCaption.Text = Me.Text
			Me.form_btnClose.DialogResult = DialogResult.Cancel
			Me.sFormType = sType
		End Sub

		' Token: 0x06001528 RID: 5416 RVA: 0x000C1B45 File Offset: 0x000BFD45
		Private Sub form_btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06001529 RID: 5417 RVA: 0x000C1B4F File Offset: 0x000BFD4F
		Private Sub CaptureReasons_Load(sender As Object, e As EventArgs)
			Me.SetForm()
			Me.txtCancelReason.Focus()
		End Sub

		' Token: 0x0600152A RID: 5418 RVA: 0x000C1B68 File Offset: 0x000BFD68
		Private Sub SetForm()
			Me.sRemarks = ""
			Dim text As String = Me.sFormType
			If Operators.CompareString(text, "Cancellation", False) <> 0 Then
				If Operators.CompareString(text, "Rejection", False) <> 0 Then
					If Operators.CompareString(text, "Amendment", False) <> 0 Then
						If Operators.CompareString(text, "Approval", False) <> 0 Then
							If Operators.CompareString(text, "On-Hold", False) = 0 Then
								Me.lblReason.Text = "Reason For On-Hold"
							End If
						Else
							Me.lblReason.Text = "Reason For Approval"
						End If
					Else
						Me.lblReason.Text = "Reason For Amendment"
					End If
				Else
					Me.lblReason.Text = "Reason For Rejection"
				End If
			Else
				Me.lblReason.Text = "Reason For Cancellation"
			End If
		End Sub

		' Token: 0x0600152B RID: 5419 RVA: 0x000C1C38 File Offset: 0x000BFE38
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.txtCancelReason.Text), "", False) = 0
			If flag Then
				CustomMsgBox.Show("Enter " + Me.lblReason.Text + ".", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Else
				Me.sRemarks = Strings.Trim(Me.txtCancelReason.Text)
				MyBase.DialogResult = DialogResult.OK
				MyBase.Close()
			End If
		End Sub

		' Token: 0x04000903 RID: 2307
		Public sRemarks As String

		' Token: 0x04000904 RID: 2308
		Private sFormType As String
	End Class
End Namespace
