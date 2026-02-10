Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x02000053 RID: 83
	<DesignerGenerated()>
	Public Partial Class TCPPrinting
		Inherits Form

		' Token: 0x06000F7D RID: 3965 RVA: 0x0008D248 File Offset: 0x0008B448
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.TCPPrinting_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x170005D3 RID: 1491
		' (get) Token: 0x06000F80 RID: 3968 RVA: 0x0008D83B File Offset: 0x0008BA3B
		' (set) Token: 0x06000F81 RID: 3969 RVA: 0x0008D845 File Offset: 0x0008BA45
		Friend Overridable Property Label5 As Label

		' Token: 0x170005D4 RID: 1492
		' (get) Token: 0x06000F82 RID: 3970 RVA: 0x0008D84E File Offset: 0x0008BA4E
		' (set) Token: 0x06000F83 RID: 3971 RVA: 0x0008D858 File Offset: 0x0008BA58
		Friend Overridable Property txtIP As TextBox

		' Token: 0x170005D5 RID: 1493
		' (get) Token: 0x06000F84 RID: 3972 RVA: 0x0008D861 File Offset: 0x0008BA61
		' (set) Token: 0x06000F85 RID: 3973 RVA: 0x0008D86B File Offset: 0x0008BA6B
		Friend Overridable Property Label1 As Label

		' Token: 0x170005D6 RID: 1494
		' (get) Token: 0x06000F86 RID: 3974 RVA: 0x0008D874 File Offset: 0x0008BA74
		' (set) Token: 0x06000F87 RID: 3975 RVA: 0x0008D87E File Offset: 0x0008BA7E
		Friend Overridable Property txtPort As TextBox

		' Token: 0x170005D7 RID: 1495
		' (get) Token: 0x06000F88 RID: 3976 RVA: 0x0008D887 File Offset: 0x0008BA87
		' (set) Token: 0x06000F89 RID: 3977 RVA: 0x0008D891 File Offset: 0x0008BA91
		Friend Overridable Property Label2 As Label

		' Token: 0x170005D8 RID: 1496
		' (get) Token: 0x06000F8A RID: 3978 RVA: 0x0008D89A File Offset: 0x0008BA9A
		' (set) Token: 0x06000F8B RID: 3979 RVA: 0x0008D8A4 File Offset: 0x0008BAA4
		Friend Overridable Property txtData As TextBox

		' Token: 0x170005D9 RID: 1497
		' (get) Token: 0x06000F8C RID: 3980 RVA: 0x0008D8AD File Offset: 0x0008BAAD
		' (set) Token: 0x06000F8D RID: 3981 RVA: 0x0008D8B8 File Offset: 0x0008BAB8
		Friend Overridable Property btnPing As Button
			<CompilerGenerated()>
			Get
				Return Me._btnPing
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnPing_Click
				Dim button As Button = Me._btnPing
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnPing = value
				button = Me._btnPing
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170005DA RID: 1498
		' (get) Token: 0x06000F8E RID: 3982 RVA: 0x0008D8FB File Offset: 0x0008BAFB
		' (set) Token: 0x06000F8F RID: 3983 RVA: 0x0008D908 File Offset: 0x0008BB08
		Friend Overridable Property btnPrint As Button
			<CompilerGenerated()>
			Get
				Return Me._btnPrint
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnPrint_Click
				Dim button As Button = Me._btnPrint
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnPrint = value
				button = Me._btnPrint
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x06000F90 RID: 3984 RVA: 0x0008D94B File Offset: 0x0008BB4B
		Private Sub TCPPrinting_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000F91 RID: 3985 RVA: 0x0008D94E File Offset: 0x0008BB4E
		Private Sub btnPing_Click(sender As Object, e As EventArgs)
			MainModule.GetPing(Strings.Trim(Me.txtIP.Text))
		End Sub

		' Token: 0x06000F92 RID: 3986 RVA: 0x0008D967 File Offset: 0x0008BB67
		Private Sub btnPrint_Click(sender As Object, e As EventArgs)
			Me.SendDataToPrinter(Strings.Trim(Me.txtIP.Text), Strings.Trim(Me.txtPort.Text), Strings.Trim(Me.txtData.Text))
		End Sub

		' Token: 0x06000F93 RID: 3987 RVA: 0x0008D9A4 File Offset: 0x0008BBA4
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
				CustomMsgBox.Show("Error " + ex.Message.ToString(), "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				socket.Disconnect(False)
				socket.Close()
				num = 0
			End Try
			Return num
		End Function
	End Class
End Namespace
