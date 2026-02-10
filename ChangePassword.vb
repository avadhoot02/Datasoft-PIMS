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
	' Token: 0x02000049 RID: 73
	<DesignerGenerated()>
	Public Partial Class ChangePassword
		Inherits Form

		' Token: 0x170004E7 RID: 1255
		' (get) Token: 0x06000CFE RID: 3326 RVA: 0x0007768E File Offset: 0x0007588E
		' (set) Token: 0x06000CFF RID: 3327 RVA: 0x00077698 File Offset: 0x00075898
		Friend Overridable Property pnlBorder As Panel

		' Token: 0x170004E8 RID: 1256
		' (get) Token: 0x06000D00 RID: 3328 RVA: 0x000776A1 File Offset: 0x000758A1
		' (set) Token: 0x06000D01 RID: 3329 RVA: 0x000776AB File Offset: 0x000758AB
		Friend Overridable Property pnlMain As Panel

		' Token: 0x170004E9 RID: 1257
		' (get) Token: 0x06000D02 RID: 3330 RVA: 0x000776B4 File Offset: 0x000758B4
		' (set) Token: 0x06000D03 RID: 3331 RVA: 0x000776C0 File Offset: 0x000758C0
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

		' Token: 0x170004EA RID: 1258
		' (get) Token: 0x06000D04 RID: 3332 RVA: 0x00077703 File Offset: 0x00075903
		' (set) Token: 0x06000D05 RID: 3333 RVA: 0x0007770D File Offset: 0x0007590D
		Friend Overridable Property picFormIcon As PictureBox

		' Token: 0x170004EB RID: 1259
		' (get) Token: 0x06000D06 RID: 3334 RVA: 0x00077716 File Offset: 0x00075916
		' (set) Token: 0x06000D07 RID: 3335 RVA: 0x00077720 File Offset: 0x00075920
		Friend Overridable Property lblCaption As Label

		' Token: 0x170004EC RID: 1260
		' (get) Token: 0x06000D08 RID: 3336 RVA: 0x00077729 File Offset: 0x00075929
		' (set) Token: 0x06000D09 RID: 3337 RVA: 0x00077734 File Offset: 0x00075934
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

		' Token: 0x170004ED RID: 1261
		' (get) Token: 0x06000D0A RID: 3338 RVA: 0x00077777 File Offset: 0x00075977
		' (set) Token: 0x06000D0B RID: 3339 RVA: 0x00077781 File Offset: 0x00075981
		Friend Overridable Property lblShadow1 As Label

		' Token: 0x170004EE RID: 1262
		' (get) Token: 0x06000D0C RID: 3340 RVA: 0x0007778A File Offset: 0x0007598A
		' (set) Token: 0x06000D0D RID: 3341 RVA: 0x00077794 File Offset: 0x00075994
		Friend Overridable Property lblShadow2 As Label

		' Token: 0x170004EF RID: 1263
		' (get) Token: 0x06000D0E RID: 3342 RVA: 0x0007779D File Offset: 0x0007599D
		' (set) Token: 0x06000D0F RID: 3343 RVA: 0x000777A7 File Offset: 0x000759A7
		Friend Overridable Property LogoPictureBox As PictureBox

		' Token: 0x170004F0 RID: 1264
		' (get) Token: 0x06000D10 RID: 3344 RVA: 0x000777B0 File Offset: 0x000759B0
		' (set) Token: 0x06000D11 RID: 3345 RVA: 0x000777BC File Offset: 0x000759BC
		Friend Overridable Property btnSendOTP As Button
			<CompilerGenerated()>
			Get
				Return Me._btnSendOTP
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnSendOTP_Click
				Dim button As Button = Me._btnSendOTP
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnSendOTP = value
				button = Me._btnSendOTP
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170004F1 RID: 1265
		' (get) Token: 0x06000D12 RID: 3346 RVA: 0x000777FF File Offset: 0x000759FF
		' (set) Token: 0x06000D13 RID: 3347 RVA: 0x00077809 File Offset: 0x00075A09
		Friend Overridable Property txtEmailID As TextBox

		' Token: 0x170004F2 RID: 1266
		' (get) Token: 0x06000D14 RID: 3348 RVA: 0x00077812 File Offset: 0x00075A12
		' (set) Token: 0x06000D15 RID: 3349 RVA: 0x0007781C File Offset: 0x00075A1C
		Friend Overridable Property Label1 As Label

		' Token: 0x170004F3 RID: 1267
		' (get) Token: 0x06000D16 RID: 3350 RVA: 0x00077825 File Offset: 0x00075A25
		' (set) Token: 0x06000D17 RID: 3351 RVA: 0x00077830 File Offset: 0x00075A30
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

		' Token: 0x170004F4 RID: 1268
		' (get) Token: 0x06000D18 RID: 3352 RVA: 0x00077873 File Offset: 0x00075A73
		' (set) Token: 0x06000D19 RID: 3353 RVA: 0x00077880 File Offset: 0x00075A80
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

		' Token: 0x170004F5 RID: 1269
		' (get) Token: 0x06000D1A RID: 3354 RVA: 0x000778C3 File Offset: 0x00075AC3
		' (set) Token: 0x06000D1B RID: 3355 RVA: 0x000778D0 File Offset: 0x00075AD0
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

		' Token: 0x170004F6 RID: 1270
		' (get) Token: 0x06000D1C RID: 3356 RVA: 0x00077913 File Offset: 0x00075B13
		' (set) Token: 0x06000D1D RID: 3357 RVA: 0x0007791D File Offset: 0x00075B1D
		Friend Overridable Property Label3 As Label

		' Token: 0x170004F7 RID: 1271
		' (get) Token: 0x06000D1E RID: 3358 RVA: 0x00077926 File Offset: 0x00075B26
		' (set) Token: 0x06000D1F RID: 3359 RVA: 0x00077930 File Offset: 0x00075B30
		Friend Overridable Property txtNew As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtNew
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim keyEventHandler As KeyEventHandler = AddressOf Me.txtNew_KeyDown
				Dim eventHandler As EventHandler = AddressOf Me.txtNew_TextChanged
				Dim textBox As TextBox = Me._txtNew
				If textBox IsNot Nothing Then
					RemoveHandler textBox.KeyDown, keyEventHandler
					RemoveHandler textBox.TextChanged, eventHandler
				End If
				Me._txtNew = value
				textBox = Me._txtNew
				If textBox IsNot Nothing Then
					AddHandler textBox.KeyDown, keyEventHandler
					AddHandler textBox.TextChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170004F8 RID: 1272
		' (get) Token: 0x06000D20 RID: 3360 RVA: 0x0007798E File Offset: 0x00075B8E
		' (set) Token: 0x06000D21 RID: 3361 RVA: 0x00077998 File Offset: 0x00075B98
		Friend Overridable Property Label2 As Label

		' Token: 0x170004F9 RID: 1273
		' (get) Token: 0x06000D22 RID: 3362 RVA: 0x000779A1 File Offset: 0x00075BA1
		' (set) Token: 0x06000D23 RID: 3363 RVA: 0x000779AC File Offset: 0x00075BAC
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

		' Token: 0x170004FA RID: 1274
		' (get) Token: 0x06000D24 RID: 3364 RVA: 0x000779EF File Offset: 0x00075BEF
		' (set) Token: 0x06000D25 RID: 3365 RVA: 0x000779F9 File Offset: 0x00075BF9
		Friend Overridable Property lblOld As Label

		' Token: 0x170004FB RID: 1275
		' (get) Token: 0x06000D26 RID: 3366 RVA: 0x00077A02 File Offset: 0x00075C02
		' (set) Token: 0x06000D27 RID: 3367 RVA: 0x00077A0C File Offset: 0x00075C0C
		Friend Overridable Property lblStrength As Label

		' Token: 0x06000D28 RID: 3368
		Private Declare Sub SendMessage Lib "user32.DLL" (hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

		' Token: 0x06000D29 RID: 3369
		Private Declare Sub ReleaseCapture Lib "user32.DLL" ()

		' Token: 0x06000D2A RID: 3370 RVA: 0x00077A15 File Offset: 0x00075C15
		Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs)
			Datasoft_PIMS.ChangePassword.ReleaseCapture()
			Datasoft_PIMS.ChangePassword.SendMessage(MyBase.Handle, 274, 61458, 0)
		End Sub

		' Token: 0x06000D2B RID: 3371 RVA: 0x00077A38 File Offset: 0x00075C38
		Public Sub New(FormType As String)
			AddHandler MyBase.FormClosing, AddressOf Me.ChangePassword_FormClosing
			AddHandler MyBase.Load, AddressOf Me.ChangePassword_Load
			Me.bIsPwdValid = False
			Me.InitializeComponent()
			Designing.SetTheme(Me)
			Me.picFormIcon.Image = ResourceModule.imgFormIconPic
			MyBase.FormBorderStyle = FormBorderStyle.None
			Me.BackColor = Color.DarkGray
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.lblCaption.Text = Me.Text
			Me.form_btnClose.DialogResult = DialogResult.Cancel
			Me.sFormType = FormType
		End Sub

		' Token: 0x06000D2C RID: 3372 RVA: 0x00077AE3 File Offset: 0x00075CE3
		Private Sub form_btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06000D2D RID: 3373 RVA: 0x00077AF0 File Offset: 0x00075CF0
		Private Sub ChangePassword_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x06000D2E RID: 3374 RVA: 0x00077B25 File Offset: 0x00075D25
		Private Sub ChangePassword_Load(sender As Object, e As EventArgs)
			Me.SetForm()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x06000D2F RID: 3375 RVA: 0x00077B48 File Offset: 0x00075D48
		Private Sub SetForm()
			Me.Text = Me.sFormType
			Dim text As String = Me.sFormType
			If Operators.CompareString(text, "Reset Password", False) <> 0 Then
				If Operators.CompareString(text, "Forgot Password", False) = 0 Then
					Me.txtEmailID.[ReadOnly] = False
					Me.txtEmailID.Focus()
					Me.lblOld.Text = "Enter OTP"
					Me.txtNew.Enabled = False
					Me.txtConfirm.Enabled = False
					Me.btnSendOTP.Visible = True
					Me.btnChange.Enabled = False
				End If
			Else
				Me.txtEmailID.Text = GlobalVariables.gsEmailID
				Me.txtEmailID.[ReadOnly] = True
				Me.lblOld.Text = "Old Password"
				Me.btnSendOTP.Visible = False
				Me.txtOld.Focus()
			End If
		End Sub

		' Token: 0x06000D30 RID: 3376 RVA: 0x00077C39 File Offset: 0x00075E39
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x06000D31 RID: 3377 RVA: 0x00077C44 File Offset: 0x00075E44
		Private Sub txtOld_KeyDown(sender As Object, e As KeyEventArgs)
			Dim keyValue As Integer = e.KeyValue
			If keyValue = 32 Then
				e.SuppressKeyPress = True
			End If
		End Sub

		' Token: 0x06000D32 RID: 3378 RVA: 0x00077C70 File Offset: 0x00075E70
		Private Sub txtNew_KeyDown(sender As Object, e As KeyEventArgs)
			Dim keyValue As Integer = e.KeyValue
			If keyValue = 32 Then
				e.SuppressKeyPress = True
			End If
		End Sub

		' Token: 0x06000D33 RID: 3379 RVA: 0x00077C9C File Offset: 0x00075E9C
		Private Sub txtConfirm_KeyDown(sender As Object, e As KeyEventArgs)
			Dim keyValue As Integer = e.KeyValue
			If keyValue = 32 Then
				e.SuppressKeyPress = True
			End If
		End Sub

		' Token: 0x06000D34 RID: 3380 RVA: 0x00077CC8 File Offset: 0x00075EC8
		Private Sub txtNew_TextChanged(sender As Object, e As EventArgs)
			Me.CheckStrength()
		End Sub

		' Token: 0x06000D35 RID: 3381 RVA: 0x00077CD4 File Offset: 0x00075ED4
		Private Sub CheckStrength()
			Dim text As String = Me.txtNew.Text.Trim()
			Dim flag As Boolean = False
			Dim flag2 As Boolean = False
			Dim flag3 As Boolean = False
			Dim flag4 As Boolean = text.Length > 0
			If flag4 Then
				Dim flag5 As Boolean = text.Length < Convert.ToInt32(FeaturesVariables.gsPassword_Length)
				If flag5 Then
					Me.bIsPwdValid = False
					Me.lblStrength.Text = "Invalid"
					Me.lblStrength.ForeColor = Color.Red
				Else
					Dim num As Integer = text.Length - 1
					For i As Integer = 0 To num
						Dim c As Char = Convert.ToChar(text.Substring(i, 1))
						Dim flag6 As Boolean = Char.IsNumber(c)
						If flag6 Then
							flag = True
						Else
							Dim flag7 As Boolean = Char.IsLetter(c)
							If flag7 Then
								flag2 = True
							Else
								Dim flag8 As Boolean = Char.IsSymbol(c) OrElse Char.IsPunctuation(c)
								If flag8 Then
									flag3 = True
								End If
							End If
						End If
					Next
					Dim flag9 As Boolean = Not flag And Not flag2 And Not flag3
					If flag9 Then
						Me.bIsPwdValid = False
						Me.lblStrength.Text = ""
						Me.lblStrength.ForeColor = Color.Black
					Else
						Dim flag10 As Boolean = (Not flag And Not flag2) AndAlso flag3
						If flag10 Then
							Me.bIsPwdValid = False
							Me.lblStrength.Text = "Weak"
							Me.lblStrength.ForeColor = Color.Orange
						Else
							Dim flag11 As Boolean = (Not flag AndAlso flag2) And Not flag3
							If flag11 Then
								Me.bIsPwdValid = False
								Me.lblStrength.Text = "Weak"
								Me.lblStrength.ForeColor = Color.Orange
							Else
								Dim flag12 As Boolean = Not flag AndAlso flag2 AndAlso flag3
								If flag12 Then
									Me.bIsPwdValid = True
									Me.lblStrength.Text = "Good"
									Me.lblStrength.ForeColor = Color.LightGreen
								Else
									Dim flag13 As Boolean = flag And Not flag2 And Not flag3
									If flag13 Then
										Me.bIsPwdValid = False
										Me.lblStrength.Text = "Weak"
										Me.lblStrength.ForeColor = Color.Orange
									Else
										Dim flag14 As Boolean = (flag And Not flag2) AndAlso flag3
										If flag14 Then
											Me.bIsPwdValid = True
											Me.lblStrength.Text = "Good"
											Me.lblStrength.ForeColor = Color.LightGreen
										Else
											Dim flag15 As Boolean = (flag AndAlso flag2) And Not flag3
											If flag15 Then
												Me.bIsPwdValid = True
												Me.lblStrength.Text = "Good"
												Me.lblStrength.ForeColor = Color.LightGreen
											Else
												Dim flag16 As Boolean = flag AndAlso flag2 AndAlso flag3
												If flag16 Then
													Me.bIsPwdValid = True
													Me.lblStrength.Text = "Strong"
													Me.lblStrength.ForeColor = Color.DarkGreen
												End If
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			Else
				Me.bIsPwdValid = False
				Me.lblStrength.Text = ""
				Me.lblStrength.ForeColor = Color.Black
			End If
		End Sub

		' Token: 0x06000D36 RID: 3382 RVA: 0x00077FD5 File Offset: 0x000761D5
		Private Sub btnSendOTP_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000D37 RID: 3383 RVA: 0x00077FD8 File Offset: 0x000761D8
		Private Sub btnChange_Click(sender As Object, e As EventArgs)
			Try
				Dim text As String = Me.sFormType
				If Operators.CompareString(text, "Reset Password", False) <> 0 Then
					If Operators.CompareString(text, "Forgot Password", False) = 0 Then
						Me.ForgotPassword()
					End If
				Else
					Me.ResetPassword()
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06000D38 RID: 3384 RVA: 0x00078064 File Offset: 0x00076264
		Private Function ValidateResetPassword() As Boolean
			Dim flag As Boolean = Operators.CompareString(Me.txtOld.Text, "", False) = 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Enter Old Password.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.txtOld.Focus()
				flag2 = False
			Else
				Dim flag3 As Boolean = Operators.CompareString(MainModule.EncryptData(Strings.Trim(Me.txtOld.Text), GlobalVariables.gsPwd), GlobalVariables.gsLoginPwd, False) <> 0
				If flag3 Then
					CustomMsgBox.Show("Incorrect Password.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.txtOld.Focus()
					flag2 = False
				Else
					Dim flag4 As Boolean = Operators.CompareString(Me.txtNew.Text, "", False) = 0
					If flag4 Then
						CustomMsgBox.Show("Enter New Password.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.txtNew.Focus()
						flag2 = False
					Else
						Dim flag5 As Boolean = (Operators.CompareString(Strings.Trim(Me.txtNew.Text), "", False) = 0) Or Not Me.bIsPwdValid
						If flag5 Then
							Dim text As String = ""
							text += "Enter Valid Password" & vbCrLf
							text = text + "Password length must be more than " + Conversions.ToString(FeaturesVariables.gsPassword_Length) + vbCrLf
							text += "Password must have combination of letters, numbers and/or special characters"
							CustomMsgBox.Show(text, "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.txtNew.Focus()
							flag2 = False
						Else
							Dim flag6 As Boolean = Operators.CompareString(Me.txtConfirm.Text, Me.txtNew.Text, False) <> 0
							If flag6 Then
								CustomMsgBox.Show("New Password Does Not Match Confirm Password.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								Me.txtConfirm.Focus()
								flag2 = False
							Else
								flag2 = True
							End If
						End If
					End If
				End If
			End If
			Return flag2
		End Function

		' Token: 0x06000D39 RID: 3385 RVA: 0x0007822C File Offset: 0x0007642C
		Private Sub ResetPassword()
			Dim flag As Boolean = CustomMsgBox.Show("Change Password..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
			If flag Then
				Dim flag2 As Boolean = Not Me.ValidateResetPassword()
				If Not flag2 Then
					Me.ChangePassword()
				End If
			End If
		End Sub

		' Token: 0x06000D3A RID: 3386 RVA: 0x0007826C File Offset: 0x0007646C
		Private Function ValidateForgotPassword() As Boolean
			Dim flag As Boolean = Operators.CompareString(Me.txtOld.Text, "", False) = 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Enter OTP.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.txtOld.Focus()
				flag2 = False
			Else
				Dim flag3 As Boolean = Operators.CompareString(Me.txtOld.Text, Me.sOTP, False) <> 0
				If flag3 Then
					CustomMsgBox.Show("Invalid OTP.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.txtOld.Focus()
					flag2 = False
				Else
					Dim flag4 As Boolean = Operators.CompareString(Me.txtNew.Text, "", False) = 0
					If flag4 Then
						CustomMsgBox.Show("Enter New Password.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.txtNew.Focus()
						flag2 = False
					Else
						Dim flag5 As Boolean = (Operators.CompareString(Strings.Trim(Me.txtNew.Text), "", False) = 0) Or Not Me.bIsPwdValid
						If flag5 Then
							Dim text As String = ""
							text += "Enter Valid Password" & vbCrLf
							text = text + "Password length must be more than " + Conversions.ToString(FeaturesVariables.gsPassword_Length) + vbCrLf
							text += "Password must have combination of letters, numbers and/or special characters"
							CustomMsgBox.Show(text, "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.txtNew.Focus()
							flag2 = False
						Else
							Dim flag6 As Boolean = Operators.CompareString(Me.txtConfirm.Text, Me.txtNew.Text, False) <> 0
							If flag6 Then
								CustomMsgBox.Show("New Password Does Not Match Confirm Password.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								Me.txtConfirm.Focus()
								flag2 = False
							Else
								flag2 = True
							End If
						End If
					End If
				End If
			End If
			Return flag2
		End Function

		' Token: 0x06000D3B RID: 3387 RVA: 0x00078424 File Offset: 0x00076624
		Private Sub ForgotPassword()
			Dim flag As Boolean = CustomMsgBox.Show("Change Password..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
			If flag Then
				Dim flag2 As Boolean = Not Me.ValidateForgotPassword()
				If Not flag2 Then
					Me.ChangePassword()
				End If
			End If
		End Sub

		' Token: 0x06000D3C RID: 3388 RVA: 0x00078464 File Offset: 0x00076664
		Private Sub ChangePassword()
			Dim text As String = " UPDATE [User] SET Password = '" + MainModule.Encrypt(Me.txtNew.Text, GlobalVariables.gsPwd) + "', LastReset = GETDATE()"
			text = text + "  WHERE (UserID = '" + GlobalVariables.gsUserID + "') "
			Dim flag As Boolean = MainModule.ExecuteSQL(text) = 1
			If flag Then
				Dim text2 As String = "User ID : " + GlobalVariables.gsUserID + vbCrLf
				text2 = text2 + "Login ID : " + GlobalVariables.gsLoginID
				MainModule.TrnLog(Me.Text, "Password Changed", text2, Nothing)
				CustomMsgBox.Show("Password Changed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				MyBase.Close()
			End If
		End Sub

		' Token: 0x04000577 RID: 1399
		Private sFormType As String

		' Token: 0x04000578 RID: 1400
		Private sOTP As String

		' Token: 0x04000579 RID: 1401
		Private bIsPwdValid As Boolean
	End Class
End Namespace
