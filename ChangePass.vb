Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Datasoft_PIMS.My
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x02000048 RID: 72
	<DesignerGenerated()>
	Public Partial Class ChangePass
		Inherits Form

		' Token: 0x06000CDF RID: 3295 RVA: 0x0007595D File Offset: 0x00073B5D
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.ChangePass_FormClosing
			AddHandler MyBase.Load, AddressOf Me.ChangePass_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x170004DE RID: 1246
		' (get) Token: 0x06000CE2 RID: 3298 RVA: 0x0007618C File Offset: 0x0007438C
		' (set) Token: 0x06000CE3 RID: 3299 RVA: 0x00076196 File Offset: 0x00074396
		Friend Overridable Property Label1 As Label

		' Token: 0x170004DF RID: 1247
		' (get) Token: 0x06000CE4 RID: 3300 RVA: 0x0007619F File Offset: 0x0007439F
		' (set) Token: 0x06000CE5 RID: 3301 RVA: 0x000761AC File Offset: 0x000743AC
		Friend Overridable Property txtOld As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtOld
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim keyEventHandler As KeyEventHandler = AddressOf Me.txtOld_KeyDown
				Dim textBox As TextBox = Me._txtOld
				If textBox IsNot Nothing Then
					RemoveHandler textBox.KeyDown, keyEventHandler
				End If
				Me._txtOld = value
				textBox = Me._txtOld
				If textBox IsNot Nothing Then
					AddHandler textBox.KeyDown, keyEventHandler
				End If
			End Set
		End Property

		' Token: 0x170004E0 RID: 1248
		' (get) Token: 0x06000CE6 RID: 3302 RVA: 0x000761EF File Offset: 0x000743EF
		' (set) Token: 0x06000CE7 RID: 3303 RVA: 0x000761FC File Offset: 0x000743FC
		Friend Overridable Property txtNew As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtNew
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim keyEventHandler As KeyEventHandler = AddressOf Me.txtNew_KeyDown
				Dim textBox As TextBox = Me._txtNew
				If textBox IsNot Nothing Then
					RemoveHandler textBox.KeyDown, keyEventHandler
				End If
				Me._txtNew = value
				textBox = Me._txtNew
				If textBox IsNot Nothing Then
					AddHandler textBox.KeyDown, keyEventHandler
				End If
			End Set
		End Property

		' Token: 0x170004E1 RID: 1249
		' (get) Token: 0x06000CE8 RID: 3304 RVA: 0x0007623F File Offset: 0x0007443F
		' (set) Token: 0x06000CE9 RID: 3305 RVA: 0x00076249 File Offset: 0x00074449
		Friend Overridable Property Label2 As Label

		' Token: 0x170004E2 RID: 1250
		' (get) Token: 0x06000CEA RID: 3306 RVA: 0x00076252 File Offset: 0x00074452
		' (set) Token: 0x06000CEB RID: 3307 RVA: 0x0007625C File Offset: 0x0007445C
		Friend Overridable Property txtConfirm As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtConfirm
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim keyEventHandler As KeyEventHandler = AddressOf Me.txtConfirm_KeyDown
				Dim textBox As TextBox = Me._txtConfirm
				If textBox IsNot Nothing Then
					RemoveHandler textBox.KeyDown, keyEventHandler
				End If
				Me._txtConfirm = value
				textBox = Me._txtConfirm
				If textBox IsNot Nothing Then
					AddHandler textBox.KeyDown, keyEventHandler
				End If
			End Set
		End Property

		' Token: 0x170004E3 RID: 1251
		' (get) Token: 0x06000CEC RID: 3308 RVA: 0x0007629F File Offset: 0x0007449F
		' (set) Token: 0x06000CED RID: 3309 RVA: 0x000762A9 File Offset: 0x000744A9
		Friend Overridable Property Label3 As Label

		' Token: 0x170004E4 RID: 1252
		' (get) Token: 0x06000CEE RID: 3310 RVA: 0x000762B2 File Offset: 0x000744B2
		' (set) Token: 0x06000CEF RID: 3311 RVA: 0x000762BC File Offset: 0x000744BC
		Friend Overridable Property btnChange As Button
			<CompilerGenerated()>
			Get
				Return Me._btnChange
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnChange_Click
				Dim button As Button = Me._btnChange
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnChange = value
				button = Me._btnChange
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170004E5 RID: 1253
		' (get) Token: 0x06000CF0 RID: 3312 RVA: 0x000762FF File Offset: 0x000744FF
		' (set) Token: 0x06000CF1 RID: 3313 RVA: 0x0007630C File Offset: 0x0007450C
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

		' Token: 0x170004E6 RID: 1254
		' (get) Token: 0x06000CF2 RID: 3314 RVA: 0x0007634F File Offset: 0x0007454F
		' (set) Token: 0x06000CF3 RID: 3315 RVA: 0x00076359 File Offset: 0x00074559
		Friend Overridable Property LogoPictureBox As PictureBox

		' Token: 0x06000CF4 RID: 3316 RVA: 0x00076364 File Offset: 0x00074564
		Private Sub ChangePass_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x06000CF5 RID: 3317 RVA: 0x00076399 File Offset: 0x00074599
		Private Sub ChangePass_Load(sender As Object, e As EventArgs)
			MyBase.Icon = MyProject.Forms.MDIMain.Icon
			Designing.SetTheme(Me)
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x06000CF6 RID: 3318 RVA: 0x000763D0 File Offset: 0x000745D0
		Private Function ValidateForm() As Boolean
			Dim flag As Boolean = Operators.CompareString(Me.txtOld.Text, "", False) = 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Enter Old Password.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				flag2 = False
			Else
				Dim flag3 As Boolean = Operators.CompareString(Me.txtNew.Text, "", False) = 0
				If flag3 Then
					CustomMsgBox.Show("Enter New Password.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					flag2 = False
				Else
					Dim flag4 As Boolean = Operators.CompareString(Me.txtConfirm.Text, Me.txtNew.Text, False) <> 0
					If flag4 Then
						CustomMsgBox.Show("New Password Does Not Match Confirm Password.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						flag2 = False
					Else
						Dim text As String = "SELECT UserID, Password FROM [User] WHERE (UserID = '" + GlobalVariables.gsUserID + "')"
						Dim data As DataTable = MainModule.GetData(text)
						Dim flag5 As Boolean = data.Rows.Count > 0
						If flag5 Then
							Dim flag6 As Boolean = Operators.ConditionalCompareObjectNotEqual(data.Rows(0)("Password"), MainModule.Encrypt(Strings.Trim(Me.txtOld.Text), GlobalVariables.gsPwd), False)
							If flag6 Then
								CustomMsgBox.Show("Incorrect Password.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								flag2 = False
							Else
								flag2 = True
							End If
						Else
							CustomMsgBox.Show("Invalid Password.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							flag2 = False
						End If
					End If
				End If
			End If
			Return flag2
		End Function

		' Token: 0x06000CF7 RID: 3319 RVA: 0x00076534 File Offset: 0x00074734
		Private Sub btnChange_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Me.ValidateForm()
			If Not flag Then
				Dim text As String = " UPDATE [User] SET Password = '" + MainModule.Encrypt(Me.txtNew.Text, GlobalVariables.gsPwd) + "', LastReset = GETDATE() "
				text = text + " WHERE (UserID = '" + GlobalVariables.gsUserID + "') "
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text) = 1
				If flag2 Then
					MainModule.TrnLog(Me.Text, "Password Changed", "", Nothing)
					CustomMsgBox.Show("Password Changed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					MyBase.Close()
				End If
			End If
		End Sub

		' Token: 0x06000CF8 RID: 3320 RVA: 0x000765CC File Offset: 0x000747CC
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06000CF9 RID: 3321 RVA: 0x000765D8 File Offset: 0x000747D8
		Private Sub txtOld_KeyDown(sender As Object, e As KeyEventArgs)
			Dim keyValue As Integer = e.KeyValue
			If keyValue = 32 Then
				e.SuppressKeyPress = True
			End If
		End Sub

		' Token: 0x06000CFA RID: 3322 RVA: 0x00076604 File Offset: 0x00074804
		Private Sub txtNew_KeyDown(sender As Object, e As KeyEventArgs)
			Dim keyValue As Integer = e.KeyValue
			If keyValue = 32 Then
				e.SuppressKeyPress = True
			End If
		End Sub

		' Token: 0x06000CFB RID: 3323 RVA: 0x00076630 File Offset: 0x00074830
		Private Sub txtConfirm_KeyDown(sender As Object, e As KeyEventArgs)
			Dim keyValue As Integer = e.KeyValue
			If keyValue = 32 Then
				e.SuppressKeyPress = True
			End If
		End Sub
	End Class
End Namespace
