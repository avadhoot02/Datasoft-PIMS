Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x0200000F RID: 15
	<DesignerGenerated()>
	Public Partial Class Form1
		Inherits Form

		' Token: 0x060000FB RID: 251 RVA: 0x0000B4F8 File Offset: 0x000096F8
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form1_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x060000FC RID: 252 RVA: 0x0000B518 File Offset: 0x00009718
		Private Sub Form1_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060000FD RID: 253 RVA: 0x0000B51C File Offset: 0x0000971C
		Private Sub btn1_Click(sender As Object, e As EventArgs)
			Try
				Me.txt3.Text = Strings.Format(Conversion.Val(Me.txt1.Text), Me.txt2.Text)
				Dim num As Double = Conversion.Val(Me.txt1.Text) Mod 10.0
				Me.txt4.Text = Strings.Format(Conversion.Val(Me.txt1.Text), "#0.####")
			Catch ex As Exception
				Interaction.MsgBox(ex.Message.ToString(), MsgBoxStyle.OkOnly, Nothing)
			End Try
		End Sub

		' Token: 0x1700004B RID: 75
		' (get) Token: 0x06000100 RID: 256 RVA: 0x0000BC88 File Offset: 0x00009E88
		' (set) Token: 0x06000101 RID: 257 RVA: 0x0000BC94 File Offset: 0x00009E94
		Friend Overridable Property btn1 As Button
			<CompilerGenerated()>
			Get
				Return Me._btn1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btn1_Click
				Dim button As Button = Me._btn1
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btn1 = value
				button = Me._btn1
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700004C RID: 76
		' (get) Token: 0x06000102 RID: 258 RVA: 0x0000BCD7 File Offset: 0x00009ED7
		' (set) Token: 0x06000103 RID: 259 RVA: 0x0000BCE1 File Offset: 0x00009EE1
		Friend Overridable Property txt1 As TextBox

		' Token: 0x1700004D RID: 77
		' (get) Token: 0x06000104 RID: 260 RVA: 0x0000BCEA File Offset: 0x00009EEA
		' (set) Token: 0x06000105 RID: 261 RVA: 0x0000BCF4 File Offset: 0x00009EF4
		Friend Overridable Property txt3 As TextBox

		' Token: 0x1700004E RID: 78
		' (get) Token: 0x06000106 RID: 262 RVA: 0x0000BCFD File Offset: 0x00009EFD
		' (set) Token: 0x06000107 RID: 263 RVA: 0x0000BD07 File Offset: 0x00009F07
		Friend Overridable Property txt2 As TextBox

		' Token: 0x1700004F RID: 79
		' (get) Token: 0x06000108 RID: 264 RVA: 0x0000BD10 File Offset: 0x00009F10
		' (set) Token: 0x06000109 RID: 265 RVA: 0x0000BD1A File Offset: 0x00009F1A
		Friend Overridable Property Label4 As Label

		' Token: 0x17000050 RID: 80
		' (get) Token: 0x0600010A RID: 266 RVA: 0x0000BD23 File Offset: 0x00009F23
		' (set) Token: 0x0600010B RID: 267 RVA: 0x0000BD2D File Offset: 0x00009F2D
		Friend Overridable Property Label1 As Label

		' Token: 0x17000051 RID: 81
		' (get) Token: 0x0600010C RID: 268 RVA: 0x0000BD36 File Offset: 0x00009F36
		' (set) Token: 0x0600010D RID: 269 RVA: 0x0000BD40 File Offset: 0x00009F40
		Friend Overridable Property Label2 As Label

		' Token: 0x17000052 RID: 82
		' (get) Token: 0x0600010E RID: 270 RVA: 0x0000BD49 File Offset: 0x00009F49
		' (set) Token: 0x0600010F RID: 271 RVA: 0x0000BD53 File Offset: 0x00009F53
		Friend Overridable Property txt4 As TextBox

		' Token: 0x17000053 RID: 83
		' (get) Token: 0x06000110 RID: 272 RVA: 0x0000BD5C File Offset: 0x00009F5C
		' (set) Token: 0x06000111 RID: 273 RVA: 0x0000BD66 File Offset: 0x00009F66
		Friend Overridable Property Label3 As Label
	End Class
End Namespace
