Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Datasoft_PIMS.My
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x0200004E RID: 78
	<DesignerGenerated()>
	Public Partial Class ReLogin
		Inherits Form

		' Token: 0x17000548 RID: 1352
		' (get) Token: 0x06000E13 RID: 3603 RVA: 0x0007EDC8 File Offset: 0x0007CFC8
		' (set) Token: 0x06000E14 RID: 3604 RVA: 0x0007EDD2 File Offset: 0x0007CFD2
		Friend Overridable Property lblLogin As Label

		' Token: 0x17000549 RID: 1353
		' (get) Token: 0x06000E15 RID: 3605 RVA: 0x0007EDDB File Offset: 0x0007CFDB
		' (set) Token: 0x06000E16 RID: 3606 RVA: 0x0007EDE8 File Offset: 0x0007CFE8
		Friend Overridable Property picShow As PictureBox
			<CompilerGenerated()>
			Get
				Return Me._picShow
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.picShow_MouseDown
				Dim mouseEventHandler2 As MouseEventHandler = AddressOf Me.picShow_MouseUp
				Dim pictureBox As PictureBox = Me._picShow
				If pictureBox IsNot Nothing Then
					RemoveHandler pictureBox.MouseDown, mouseEventHandler
					RemoveHandler pictureBox.MouseUp, mouseEventHandler2
				End If
				Me._picShow = value
				pictureBox = Me._picShow
				If pictureBox IsNot Nothing Then
					AddHandler pictureBox.MouseDown, mouseEventHandler
					AddHandler pictureBox.MouseUp, mouseEventHandler2
				End If
			End Set
		End Property

		' Token: 0x1700054A RID: 1354
		' (get) Token: 0x06000E17 RID: 3607 RVA: 0x0007EE46 File Offset: 0x0007D046
		' (set) Token: 0x06000E18 RID: 3608 RVA: 0x0007EE50 File Offset: 0x0007D050
		Friend Overridable Property picPwd As PictureBox

		' Token: 0x1700054B RID: 1355
		' (get) Token: 0x06000E19 RID: 3609 RVA: 0x0007EE59 File Offset: 0x0007D059
		' (set) Token: 0x06000E1A RID: 3610 RVA: 0x0007EE63 File Offset: 0x0007D063
		Friend Overridable Property picUser As PictureBox

		' Token: 0x1700054C RID: 1356
		' (get) Token: 0x06000E1B RID: 3611 RVA: 0x0007EE6C File Offset: 0x0007D06C
		' (set) Token: 0x06000E1C RID: 3612 RVA: 0x0007EE78 File Offset: 0x0007D078
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

		' Token: 0x1700054D RID: 1357
		' (get) Token: 0x06000E1D RID: 3613 RVA: 0x0007EEBB File Offset: 0x0007D0BB
		' (set) Token: 0x06000E1E RID: 3614 RVA: 0x0007EEC8 File Offset: 0x0007D0C8
		Friend Overridable Property txtPass As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtPass
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim eventHandler As EventHandler = AddressOf Me.txtPass_GotFocus
				Dim eventHandler2 As EventHandler = AddressOf Me.txtPass_LostFocus
				Dim eventHandler3 As EventHandler = AddressOf Me.txtPass_TextChanged
				Dim textBox As TextBox = Me._txtPass
				If textBox IsNot Nothing Then
					RemoveHandler textBox.GotFocus, eventHandler
					RemoveHandler textBox.LostFocus, eventHandler2
					RemoveHandler textBox.TextChanged, eventHandler3
				End If
				Me._txtPass = value
				textBox = Me._txtPass
				If textBox IsNot Nothing Then
					AddHandler textBox.GotFocus, eventHandler
					AddHandler textBox.LostFocus, eventHandler2
					AddHandler textBox.TextChanged, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x1700054E RID: 1358
		' (get) Token: 0x06000E1F RID: 3615 RVA: 0x0007EF41 File Offset: 0x0007D141
		' (set) Token: 0x06000E20 RID: 3616 RVA: 0x0007EF4C File Offset: 0x0007D14C
		Friend Overridable Property txtUser As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtUser
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim eventHandler As EventHandler = AddressOf Me.txtUser_GotFocus
				Dim eventHandler2 As EventHandler = AddressOf Me.txtUser_LostFocus
				Dim eventHandler3 As EventHandler = AddressOf Me.txtUser_TextChanged
				Dim textBox As TextBox = Me._txtUser
				If textBox IsNot Nothing Then
					RemoveHandler textBox.GotFocus, eventHandler
					RemoveHandler textBox.LostFocus, eventHandler2
					RemoveHandler textBox.TextChanged, eventHandler3
				End If
				Me._txtUser = value
				textBox = Me._txtUser
				If textBox IsNot Nothing Then
					AddHandler textBox.GotFocus, eventHandler
					AddHandler textBox.LostFocus, eventHandler2
					AddHandler textBox.TextChanged, eventHandler3
				End If
			End Set
		End Property

		' Token: 0x06000E21 RID: 3617 RVA: 0x0007EFC8 File Offset: 0x0007D1C8
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.ReLogin_Load
			Me.iAttemptLock = 0
			Me.InitializeComponent()
			Me.picShow.BackgroundImage = ResourceModule.imgMDIReveal
			Me.picPwd.BackgroundImage = ResourceModule.imgMDIPwd
			Me.picUser.BackgroundImage = ResourceModule.imgMDIUser
		End Sub

		' Token: 0x06000E22 RID: 3618 RVA: 0x0007F034 File Offset: 0x0007D234
		Private Sub ReLogin_Load(sender As Object, e As EventArgs)
			MyBase.Icon = MyProject.Forms.MDIMain.Icon
			Designing.SetTheme(Me)
			Me.Text = "Re-Login : " + MySettingsProperty.Settings.sConfigCompany
			Me.txtUser.Text = GlobalVariables.gsLoginID
			Me.txtPass.Focus()
			Me.txtPass.Text = ""
			Me.sDtls = "Login ID : " + GlobalVariables.gsLoginID
			MainModule.TrnLog("Logout Timer", "Screen Locked", Me.sDtls, Nothing)
		End Sub

		' Token: 0x06000E23 RID: 3619 RVA: 0x0007F0D4 File Offset: 0x0007D2D4
		Private Function ValidateForm() As Boolean
			Dim flag As Boolean = Operators.CompareString(Me.txtUser.Text, "", False) = 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Enter Login ID.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				flag2 = False
			Else
				Dim flag3 As Boolean = Operators.CompareString(Me.txtPass.Text, "", False) = 0
				If flag3 Then
					CustomMsgBox.Show("Enter Password.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					flag2 = False
				Else
					flag2 = True
				End If
			End If
			Return flag2
		End Function

		' Token: 0x06000E24 RID: 3620 RVA: 0x0007F150 File Offset: 0x0007D350
		Private Sub btnOK_Click(sender As Object, e As EventArgs)
			Dim gsIsLocked As Boolean = GlobalVariables.gsIsLocked
			If gsIsLocked Then
				Dim flag As Boolean = Not Me.ValidateForm()
				If Not flag Then
					Dim flag2 As Boolean = (Operators.CompareString(GlobalVariables.gsLoginID.ToLower(), Me.txtUser.Text.Trim().ToLower(), False) = 0) And (Operators.CompareString(GlobalVariables.gsLoginPwd, MainModule.Encrypt(Strings.Trim(Me.txtPass.Text.Trim()), GlobalVariables.gsPwd), False) = 0)
					If flag2 Then
						GlobalVariables.gsIsLocked = False
						Dim flag3 As Boolean = Me.iAttemptLock > 0
						If flag3 Then
							Me.SetAttemptLock("RELEASE")
						End If
						MainModule.TrnLog("Logout Timer", "Screen Unlocked", Me.sDtls, Nothing)
						MyBase.DialogResult = DialogResult.OK
						MyBase.Close()
					Else
						Me.SetAttemptLock("SET")
						CustomMsgBox.Show("Invalid Login.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.txtPass.Text = ""
					End If
				End If
			End If
		End Sub

		' Token: 0x06000E25 RID: 3621 RVA: 0x0007F254 File Offset: 0x0007D454
		Private Sub SetAttemptLock(sType As String)
			Dim text As String = ""
			If Operators.CompareString(sType, "SET", False) <> 0 Then
				If Operators.CompareString(sType, "RELEASE", False) = 0 Then
					text = " UPDATE [User] SET Attempts = 0"
					Me.iAttemptLock = 0
				End If
			Else
				Dim ptr As __ByRef(Of Integer) = Me.iAttemptLock
				Me.iAttemptLock = ptr + 1
				text = " UPDATE [User] SET Attempts = " + Conversions.ToString(Me.iAttemptLock) + " "
				Dim flag As Boolean = Me.iAttemptLock >= FeaturesVariables.gsWrong_Attempt
				If flag Then
					text += " , [User].IsLocked = 1"
				End If
			End If
			text = text + " WHERE ([User].LoginID = '" + Strings.Trim(Me.txtUser.Text) + "')"
			MainModule.GetData(text)
			Dim flag2 As Boolean = Me.iAttemptLock >= FeaturesVariables.gsWrong_Attempt
			If flag2 Then
				MainModule.TrnLog("Re-Login", "Sign In Failed", "User is locked as he has exceeded allowed number of attempts.", Nothing)
			End If
		End Sub

		' Token: 0x06000E26 RID: 3622 RVA: 0x0007F33D File Offset: 0x0007D53D
		Private Sub txtUser_GotFocus(sender As Object, e As EventArgs)
			Me.SetTextBox(True, Me.txtUser)
		End Sub

		' Token: 0x06000E27 RID: 3623 RVA: 0x0007F34E File Offset: 0x0007D54E
		Private Sub txtPass_GotFocus(sender As Object, e As EventArgs)
			Me.SetTextBox(True, Me.txtPass)
		End Sub

		' Token: 0x06000E28 RID: 3624 RVA: 0x0007F35F File Offset: 0x0007D55F
		Private Sub txtUser_LostFocus(sender As Object, e As EventArgs)
			Me.SetTextBox(False, Me.txtUser)
		End Sub

		' Token: 0x06000E29 RID: 3625 RVA: 0x0007F370 File Offset: 0x0007D570
		Private Sub txtPass_LostFocus(sender As Object, e As EventArgs)
			Me.SetTextBox(False, Me.txtPass)
		End Sub

		' Token: 0x06000E2A RID: 3626 RVA: 0x0007F384 File Offset: 0x0007D584
		Private Sub SetTextBox(sType As Boolean, sCtrl As TextBox)
			Dim flag As Boolean = Operators.CompareString(sCtrl.Name, "txtUser", False) = 0
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
					sCtrl.ForeColor = Color.Black
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
					sCtrl.ForeColor = Color.Black
					sCtrl.PasswordChar = "*"c
				End If
			End If
		End Sub

		' Token: 0x06000E2B RID: 3627 RVA: 0x0007F4A8 File Offset: 0x0007D6A8
		Private Sub txtUser_TextChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = (Operators.CompareString(Me.txtUser.Text, "", False) = 0) Or (Operators.CompareString(Me.txtUser.Text, "Enter LoginID", False) = 0)
			If flag Then
				Me.txtUser.ForeColor = Color.DarkGray
			Else
				Me.txtUser.ForeColor = Color.Black
			End If
		End Sub

		' Token: 0x06000E2C RID: 3628 RVA: 0x0007F514 File Offset: 0x0007D714
		Private Sub txtPass_TextChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = (Operators.CompareString(Me.txtPass.Text, "", False) = 0) Or (Operators.CompareString(Me.txtPass.Text, "Enter Password", False) = 0)
			If flag Then
				Me.txtPass.ForeColor = Color.DarkGray
			Else
				Me.txtPass.ForeColor = Color.Black
			End If
		End Sub

		' Token: 0x06000E2D RID: 3629 RVA: 0x0007F580 File Offset: 0x0007D780
		Private Sub picShow_MouseDown(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.txtPass.Text, "Enter Password", False) <> 0
			If flag Then
				Me.picShow.BackgroundImage = ResourceModule.imgMDIHide
				Me.txtPass.PasswordChar = vbNullChar
			End If
		End Sub

		' Token: 0x06000E2E RID: 3630 RVA: 0x0007F5CC File Offset: 0x0007D7CC
		Private Sub picShow_MouseUp(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.txtPass.Text, "Enter Password", False) <> 0
			If flag Then
				Me.picShow.BackgroundImage = ResourceModule.imgMDIReveal
				Me.txtPass.PasswordChar = "*"c
			End If
		End Sub

		' Token: 0x040005D7 RID: 1495
		Private iAttemptLock As Integer

		' Token: 0x040005D8 RID: 1496
		Private sDtls As String
	End Class
End Namespace
