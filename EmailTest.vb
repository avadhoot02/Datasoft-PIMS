Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Net
Imports System.Net.Mail
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x0200004C RID: 76
	<DesignerGenerated()>
	Public Partial Class EmailTest
		Inherits Form

		' Token: 0x06000D98 RID: 3480 RVA: 0x0007B4A8 File Offset: 0x000796A8
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.EmailTest_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000519 RID: 1305
		' (get) Token: 0x06000D9B RID: 3483 RVA: 0x0007BF6A File Offset: 0x0007A16A
		' (set) Token: 0x06000D9C RID: 3484 RVA: 0x0007BF74 File Offset: 0x0007A174
		Friend Overridable Property Label8 As Label

		' Token: 0x1700051A RID: 1306
		' (get) Token: 0x06000D9D RID: 3485 RVA: 0x0007BF7D File Offset: 0x0007A17D
		' (set) Token: 0x06000D9E RID: 3486 RVA: 0x0007BF87 File Offset: 0x0007A187
		Friend Overridable Property cmbSSL As ComboBox

		' Token: 0x1700051B RID: 1307
		' (get) Token: 0x06000D9F RID: 3487 RVA: 0x0007BF90 File Offset: 0x0007A190
		' (set) Token: 0x06000DA0 RID: 3488 RVA: 0x0007BF9A File Offset: 0x0007A19A
		Friend Overridable Property Label7 As Label

		' Token: 0x1700051C RID: 1308
		' (get) Token: 0x06000DA1 RID: 3489 RVA: 0x0007BFA3 File Offset: 0x0007A1A3
		' (set) Token: 0x06000DA2 RID: 3490 RVA: 0x0007BFAD File Offset: 0x0007A1AD
		Friend Overridable Property txtPort As TextBox

		' Token: 0x1700051D RID: 1309
		' (get) Token: 0x06000DA3 RID: 3491 RVA: 0x0007BFB6 File Offset: 0x0007A1B6
		' (set) Token: 0x06000DA4 RID: 3492 RVA: 0x0007BFC0 File Offset: 0x0007A1C0
		Friend Overridable Property Label6 As Label

		' Token: 0x1700051E RID: 1310
		' (get) Token: 0x06000DA5 RID: 3493 RVA: 0x0007BFC9 File Offset: 0x0007A1C9
		' (set) Token: 0x06000DA6 RID: 3494 RVA: 0x0007BFD3 File Offset: 0x0007A1D3
		Friend Overridable Property txtSMTP As TextBox

		' Token: 0x1700051F RID: 1311
		' (get) Token: 0x06000DA7 RID: 3495 RVA: 0x0007BFDC File Offset: 0x0007A1DC
		' (set) Token: 0x06000DA8 RID: 3496 RVA: 0x0007BFE6 File Offset: 0x0007A1E6
		Friend Overridable Property Label5 As Label

		' Token: 0x17000520 RID: 1312
		' (get) Token: 0x06000DA9 RID: 3497 RVA: 0x0007BFEF File Offset: 0x0007A1EF
		' (set) Token: 0x06000DAA RID: 3498 RVA: 0x0007BFF9 File Offset: 0x0007A1F9
		Friend Overridable Property Label4 As Label

		' Token: 0x17000521 RID: 1313
		' (get) Token: 0x06000DAB RID: 3499 RVA: 0x0007C002 File Offset: 0x0007A202
		' (set) Token: 0x06000DAC RID: 3500 RVA: 0x0007C00C File Offset: 0x0007A20C
		Friend Overridable Property Label3 As Label

		' Token: 0x17000522 RID: 1314
		' (get) Token: 0x06000DAD RID: 3501 RVA: 0x0007C015 File Offset: 0x0007A215
		' (set) Token: 0x06000DAE RID: 3502 RVA: 0x0007C01F File Offset: 0x0007A21F
		Friend Overridable Property Label2 As Label

		' Token: 0x17000523 RID: 1315
		' (get) Token: 0x06000DAF RID: 3503 RVA: 0x0007C028 File Offset: 0x0007A228
		' (set) Token: 0x06000DB0 RID: 3504 RVA: 0x0007C032 File Offset: 0x0007A232
		Friend Overridable Property Label1 As Label

		' Token: 0x17000524 RID: 1316
		' (get) Token: 0x06000DB1 RID: 3505 RVA: 0x0007C03B File Offset: 0x0007A23B
		' (set) Token: 0x06000DB2 RID: 3506 RVA: 0x0007C045 File Offset: 0x0007A245
		Friend Overridable Property txtBody As TextBox

		' Token: 0x17000525 RID: 1317
		' (get) Token: 0x06000DB3 RID: 3507 RVA: 0x0007C04E File Offset: 0x0007A24E
		' (set) Token: 0x06000DB4 RID: 3508 RVA: 0x0007C058 File Offset: 0x0007A258
		Friend Overridable Property txtSubject As TextBox

		' Token: 0x17000526 RID: 1318
		' (get) Token: 0x06000DB5 RID: 3509 RVA: 0x0007C061 File Offset: 0x0007A261
		' (set) Token: 0x06000DB6 RID: 3510 RVA: 0x0007C06B File Offset: 0x0007A26B
		Friend Overridable Property txtPwd As TextBox

		' Token: 0x17000527 RID: 1319
		' (get) Token: 0x06000DB7 RID: 3511 RVA: 0x0007C074 File Offset: 0x0007A274
		' (set) Token: 0x06000DB8 RID: 3512 RVA: 0x0007C07E File Offset: 0x0007A27E
		Friend Overridable Property txtTo As TextBox

		' Token: 0x17000528 RID: 1320
		' (get) Token: 0x06000DB9 RID: 3513 RVA: 0x0007C087 File Offset: 0x0007A287
		' (set) Token: 0x06000DBA RID: 3514 RVA: 0x0007C091 File Offset: 0x0007A291
		Friend Overridable Property txtFrom As TextBox

		' Token: 0x17000529 RID: 1321
		' (get) Token: 0x06000DBB RID: 3515 RVA: 0x0007C09A File Offset: 0x0007A29A
		' (set) Token: 0x06000DBC RID: 3516 RVA: 0x0007C0A4 File Offset: 0x0007A2A4
		Friend Overridable Property btnSend As Button
			<CompilerGenerated()>
			Get
				Return Me._btnSend
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnSend_Click
				Dim button As Button = Me._btnSend
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnSend = value
				button = Me._btnSend
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x06000DBD RID: 3517 RVA: 0x0007C0E7 File Offset: 0x0007A2E7
		Private Sub EmailTest_Load(sender As Object, e As EventArgs)
			Me.cmbSSL.Text = "False"
		End Sub

		' Token: 0x06000DBE RID: 3518 RVA: 0x0007C0FC File Offset: 0x0007A2FC
		Private Sub btnSend_Click(sender As Object, e As EventArgs)
			Try
				Me.SendEmail1()
				Interaction.MsgBox("Mail Sent.", MsgBoxStyle.Information, Nothing)
			Catch ex As Exception
				Interaction.MsgBox("Error : " + ex.Message, MsgBoxStyle.OkOnly, Nothing)
			End Try
		End Sub

		' Token: 0x06000DBF RID: 3519 RVA: 0x0007C15C File Offset: 0x0007A35C
		Private Sub SendEmail(sFrom As String, sPassword As String, sTo As String, sSubject As String, sBody As String)
			Dim mailMessage As MailMessage = New MailMessage()
			Dim smtpClient As SmtpClient = New SmtpClient()
			mailMessage.IsBodyHtml = True
			smtpClient.Host = Me.txtSMTP.Text
			smtpClient.Port = CInt(Math.Round(Conversion.Val(Me.txtPort.Text)))
			Dim flag As Boolean = Operators.CompareString(Me.cmbSSL.Text, "True", False) = 0
			If flag Then
				smtpClient.EnableSsl = True
			Else
				smtpClient.EnableSsl = False
			End If
			mailMessage.From = New MailAddress(sFrom)
			mailMessage.[To].Add(New MailAddress(sTo))
			mailMessage.Subject = sSubject
			mailMessage.Body = sBody
			smtpClient.Credentials = New NetworkCredential(sFrom, sPassword)
			smtpClient.Send(mailMessage)
		End Sub

		' Token: 0x06000DC0 RID: 3520 RVA: 0x0007C228 File Offset: 0x0007A428
		Private Sub SendEmail1()
			Try
				Dim smtpClient As SmtpClient = New SmtpClient()
				Dim mailMessage As MailMessage = New MailMessage()
				smtpClient.UseDefaultCredentials = False
				smtpClient.Credentials = New NetworkCredential(Me.txtFrom.Text, Me.txtTo.Text)
				smtpClient.Port = 587
				smtpClient.EnableSsl = True
				smtpClient.Host = "smtp.rediffmailpro.com"
				smtpClient.Send(New MailMessage() With { .From = New MailAddress(Me.txtFrom.Text), .[To] = { Me.txtTo.Text }, .Subject = Me.txtSubject.Text, .IsBodyHtml = False, .Body = Me.txtBody.Text })
			Catch ex As Exception
				Interaction.MsgBox(ex.ToString(), MsgBoxStyle.OkOnly, Nothing)
			End Try
		End Sub
	End Class
End Namespace
