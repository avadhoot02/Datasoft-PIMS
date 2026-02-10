Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Datasoft_PIMS.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x02000010 RID: 16
	<DesignerGenerated()>
	Public Partial Class LoadingScreen
		Inherits Form

		' Token: 0x17000054 RID: 84
		' (get) Token: 0x06000114 RID: 276 RVA: 0x0000C55A File Offset: 0x0000A75A
		' (set) Token: 0x06000115 RID: 277 RVA: 0x0000C564 File Offset: 0x0000A764
		Friend Overridable Property pnlBorder As Panel

		' Token: 0x17000055 RID: 85
		' (get) Token: 0x06000116 RID: 278 RVA: 0x0000C56D File Offset: 0x0000A76D
		' (set) Token: 0x06000117 RID: 279 RVA: 0x0000C577 File Offset: 0x0000A777
		Friend Overridable Property pnlMain As Panel

		' Token: 0x17000056 RID: 86
		' (get) Token: 0x06000118 RID: 280 RVA: 0x0000C580 File Offset: 0x0000A780
		' (set) Token: 0x06000119 RID: 281 RVA: 0x0000C58C File Offset: 0x0000A78C
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

		' Token: 0x17000057 RID: 87
		' (get) Token: 0x0600011A RID: 282 RVA: 0x0000C5CF File Offset: 0x0000A7CF
		' (set) Token: 0x0600011B RID: 283 RVA: 0x0000C5D9 File Offset: 0x0000A7D9
		Friend Overridable Property picFormIcon As PictureBox

		' Token: 0x17000058 RID: 88
		' (get) Token: 0x0600011C RID: 284 RVA: 0x0000C5E2 File Offset: 0x0000A7E2
		' (set) Token: 0x0600011D RID: 285 RVA: 0x0000C5EC File Offset: 0x0000A7EC
		Friend Overridable Property lblCaption As Label

		' Token: 0x17000059 RID: 89
		' (get) Token: 0x0600011E RID: 286 RVA: 0x0000C5F5 File Offset: 0x0000A7F5
		' (set) Token: 0x0600011F RID: 287 RVA: 0x0000C600 File Offset: 0x0000A800
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

		' Token: 0x1700005A RID: 90
		' (get) Token: 0x06000120 RID: 288 RVA: 0x0000C643 File Offset: 0x0000A843
		' (set) Token: 0x06000121 RID: 289 RVA: 0x0000C64D File Offset: 0x0000A84D
		Friend Overridable Property pnlShadow As Panel

		' Token: 0x1700005B RID: 91
		' (get) Token: 0x06000122 RID: 290 RVA: 0x0000C656 File Offset: 0x0000A856
		' (set) Token: 0x06000123 RID: 291 RVA: 0x0000C660 File Offset: 0x0000A860
		Friend Overridable Property lblLoading As Label

		' Token: 0x1700005C RID: 92
		' (get) Token: 0x06000124 RID: 292 RVA: 0x0000C669 File Offset: 0x0000A869
		' (set) Token: 0x06000125 RID: 293 RVA: 0x0000C673 File Offset: 0x0000A873
		Friend Overridable Property picLoader As PictureBox

		' Token: 0x1700005D RID: 93
		' (get) Token: 0x06000126 RID: 294 RVA: 0x0000C67C File Offset: 0x0000A87C
		' (set) Token: 0x06000127 RID: 295 RVA: 0x0000C688 File Offset: 0x0000A888
		Friend Overridable Property Timer1 As Global.System.Windows.Forms.Timer
			<CompilerGenerated()>
			Get
				Return Me._Timer1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Global.System.Windows.Forms.Timer)
				Dim eventHandler As EventHandler = AddressOf Me.Timer1_Tick
				Dim timer As Global.System.Windows.Forms.Timer = Me._Timer1
				If timer IsNot Nothing Then
					RemoveHandler timer.Tick, eventHandler
				End If
				Me._Timer1 = value
				timer = Me._Timer1
				If timer IsNot Nothing Then
					AddHandler timer.Tick, eventHandler
				End If
			End Set
		End Property

		' Token: 0x06000128 RID: 296
		Private Declare Sub SendMessage Lib "user32.DLL" (hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

		' Token: 0x06000129 RID: 297
		Private Declare Sub ReleaseCapture Lib "user32.DLL" ()

		' Token: 0x0600012A RID: 298 RVA: 0x0000C6CB File Offset: 0x0000A8CB
		Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs)
			LoadingScreen.ReleaseCapture()
			LoadingScreen.SendMessage(MyBase.Handle, 274, 61458, 0)
		End Sub

		' Token: 0x0600012B RID: 299 RVA: 0x0000C6EC File Offset: 0x0000A8EC
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.LoadingScreen_Load
			AddHandler MyBase.Shown, AddressOf Me.LoadingScreen_Shown
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

		' Token: 0x0600012C RID: 300 RVA: 0x0000C795 File Offset: 0x0000A995
		Private Sub form_btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x0600012D RID: 301 RVA: 0x0000C79F File Offset: 0x0000A99F
		Private Sub LoadingScreen_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600012E RID: 302 RVA: 0x0000C7A4 File Offset: 0x0000A9A4
		Private Async Sub LoadingScreen_Shown(sender As Object, e As EventArgs)
			Me.lblCaption.ForeColor = Color.White
			Me.panelTitleBar.BackColor = Color.Black
			Me.pnlMain.BackColor = Color.Black
			Me.lblLoading.ForeColor = Color.White
			Me.picLoader.Image = ResourceModule.imgLoading
			Me.picLoader.Width = CInt(Math.Round(CDbl((ResourceModule.imgLoading.Width * Me.picLoader.Height)) / CDbl(ResourceModule.imgLoading.Height)))
			Me.picLoader.Left = CInt(Math.Round(CDbl(Me.Width) / 2.0 - CDbl(Me.picLoader.Width) / 2.0))
			Await Me.LoadApplication()
		End Sub

		' Token: 0x0600012F RID: 303 RVA: 0x0000C7EC File Offset: 0x0000A9EC
		Private Async Function LoadApplication() As Task
			Me.Timer1.Start()
			Dim dtResult As DataTable = Await Task.Run(Of DataTable)(Function() Me.SetState())
			If dtResult.Rows.Count = 1 Then
				If Operators.ConditionalCompareObjectEqual(dtResult.AsEnumerable().ElementAtOrDefault(0)("ResultStatus"), "Success", False) Then
					MyProject.Forms.MDIMain.Show()
					Me.Timer1.[Stop]()
					Me.Close()
				Else
					CustomMsgBox.Show(Conversions.ToString(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject("Load Fail : ", dtResult.AsEnumerable().ElementAtOrDefault(0)("ResultMessage")))), "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.Timer1.[Stop]()
					Me.Close()
				End If
			Else
				CustomMsgBox.Show("Application Loading Failed", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.Timer1.[Stop]()
				Me.Close()
			End If
			Me.Timer1.[Stop]()
		End Function

		' Token: 0x06000130 RID: 304 RVA: 0x0000C830 File Offset: 0x0000AA30
		Private Function SetState() As DataTable
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("ResultStatus", Type.[GetType]("System.String"))
			dataTable.Columns.Add("ResultMessage", Type.[GetType]("System.String"))
			GlobalVariables.gsbSQLConnection = True
			MainModule.GetIPv4Address()
			Dim flag As Boolean = Not MainModule.SetConnectionString(dataTable)
			Dim dataTable2 As DataTable
			If flag Then
				GlobalVariables.gsbSQLConnection = False
				dataTable2 = dataTable
			Else
				Dim flag2 As Boolean = Not MainModule.VerifyVersion(dataTable)
				If flag2 Then
					GlobalVariables.gsbSQLConnection = False
					dataTable2 = dataTable
				Else
					Dim flag3 As Boolean = Not MainModule.VerifiyClient(dataTable)
					If flag3 Then
						GlobalVariables.gsbSQLConnection = False
						dataTable2 = dataTable
					Else
						Dim flag4 As Boolean = Not MainModule.SetLock(dataTable)
						If flag4 Then
							GlobalVariables.gsbSQLConnection = False
							dataTable2 = dataTable
						Else
							dataTable2 = dataTable
						End If
					End If
				End If
			End If
			Return dataTable2
		End Function

		' Token: 0x06000131 RID: 305 RVA: 0x0000C8F4 File Offset: 0x0000AAF4
		Private Async Function StartCheck2Async() As Task
			Me.Timer1.Start()
			Dim result As Boolean = Await Task.Run(Of Boolean)(Function() Me.RunChecks())
			If result Then
				MessageBox.Show("Checks passed!")
			Else
				MessageBox.Show("Checks failed!")
			End If
			Me.Timer1.[Stop]()
		End Function

		' Token: 0x06000132 RID: 306 RVA: 0x0000C938 File Offset: 0x0000AB38
		Private Function RunChecks() As Boolean
			Thread.Sleep(4000)
			Return True
		End Function

		' Token: 0x06000133 RID: 307 RVA: 0x0000C958 File Offset: 0x0000AB58
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Dim text As String = Me.lblLoading.Text
			If Operators.CompareString(text, "Loading", False) <> 0 Then
				If Operators.CompareString(text, "Loading.", False) <> 0 Then
					If Operators.CompareString(text, "Loading..", False) <> 0 Then
						If Operators.CompareString(text, "Loading...", False) <> 0 Then
							If Operators.CompareString(text, "Loading....", False) <> 0 Then
								If Operators.CompareString(text, "Loading.....", False) = 0 Then
									Me.lblLoading.Text = "Loading"
								End If
							Else
								Me.lblLoading.Text = "Loading....."
							End If
						Else
							Me.lblLoading.Text = "Loading...."
						End If
					Else
						Me.lblLoading.Text = "Loading..."
					End If
				Else
					Me.lblLoading.Text = "Loading.."
				End If
			Else
				Me.lblLoading.Text = "Loading."
			End If
		End Sub
	End Class
End Namespace
