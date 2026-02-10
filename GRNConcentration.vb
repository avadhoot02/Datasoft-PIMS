Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x02000056 RID: 86
	<DesignerGenerated()>
	Public Partial Class GRNConcentration
		Inherits Form

		' Token: 0x17000621 RID: 1569
		' (get) Token: 0x0600104D RID: 4173 RVA: 0x00098778 File Offset: 0x00096978
		' (set) Token: 0x0600104E RID: 4174 RVA: 0x00098782 File Offset: 0x00096982
		Friend Overridable Property pnlBorder As Panel

		' Token: 0x17000622 RID: 1570
		' (get) Token: 0x0600104F RID: 4175 RVA: 0x0009878B File Offset: 0x0009698B
		' (set) Token: 0x06001050 RID: 4176 RVA: 0x00098795 File Offset: 0x00096995
		Friend Overridable Property pnlMain As Panel

		' Token: 0x17000623 RID: 1571
		' (get) Token: 0x06001051 RID: 4177 RVA: 0x0009879E File Offset: 0x0009699E
		' (set) Token: 0x06001052 RID: 4178 RVA: 0x000987A8 File Offset: 0x000969A8
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

		' Token: 0x17000624 RID: 1572
		' (get) Token: 0x06001053 RID: 4179 RVA: 0x000987EB File Offset: 0x000969EB
		' (set) Token: 0x06001054 RID: 4180 RVA: 0x000987F5 File Offset: 0x000969F5
		Friend Overridable Property picFormIcon As PictureBox

		' Token: 0x17000625 RID: 1573
		' (get) Token: 0x06001055 RID: 4181 RVA: 0x000987FE File Offset: 0x000969FE
		' (set) Token: 0x06001056 RID: 4182 RVA: 0x00098808 File Offset: 0x00096A08
		Friend Overridable Property lblCaption As Label

		' Token: 0x17000626 RID: 1574
		' (get) Token: 0x06001057 RID: 4183 RVA: 0x00098811 File Offset: 0x00096A11
		' (set) Token: 0x06001058 RID: 4184 RVA: 0x0009881C File Offset: 0x00096A1C
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

		' Token: 0x17000627 RID: 1575
		' (get) Token: 0x06001059 RID: 4185 RVA: 0x0009885F File Offset: 0x00096A5F
		' (set) Token: 0x0600105A RID: 4186 RVA: 0x00098869 File Offset: 0x00096A69
		Friend Overridable Property pnlShadow As Panel

		' Token: 0x17000628 RID: 1576
		' (get) Token: 0x0600105B RID: 4187 RVA: 0x00098872 File Offset: 0x00096A72
		' (set) Token: 0x0600105C RID: 4188 RVA: 0x0009887C File Offset: 0x00096A7C
		Friend Overridable Property txtVendor As TextBox

		' Token: 0x17000629 RID: 1577
		' (get) Token: 0x0600105D RID: 4189 RVA: 0x00098885 File Offset: 0x00096A85
		' (set) Token: 0x0600105E RID: 4190 RVA: 0x0009888F File Offset: 0x00096A8F
		Friend Overridable Property Label9 As Label

		' Token: 0x1700062A RID: 1578
		' (get) Token: 0x0600105F RID: 4191 RVA: 0x00098898 File Offset: 0x00096A98
		' (set) Token: 0x06001060 RID: 4192 RVA: 0x000988A2 File Offset: 0x00096AA2
		Friend Overridable Property dtpDt As DateTimePicker

		' Token: 0x1700062B RID: 1579
		' (get) Token: 0x06001061 RID: 4193 RVA: 0x000988AB File Offset: 0x00096AAB
		' (set) Token: 0x06001062 RID: 4194 RVA: 0x000988B5 File Offset: 0x00096AB5
		Friend Overridable Property Label1 As Label

		' Token: 0x1700062C RID: 1580
		' (get) Token: 0x06001063 RID: 4195 RVA: 0x000988BE File Offset: 0x00096ABE
		' (set) Token: 0x06001064 RID: 4196 RVA: 0x000988C8 File Offset: 0x00096AC8
		Friend Overridable Property Label2 As Label

		' Token: 0x1700062D RID: 1581
		' (get) Token: 0x06001065 RID: 4197 RVA: 0x000988D1 File Offset: 0x00096AD1
		' (set) Token: 0x06001066 RID: 4198 RVA: 0x000988DB File Offset: 0x00096ADB
		Friend Overridable Property txtNo As TextBox

		' Token: 0x1700062E RID: 1582
		' (get) Token: 0x06001067 RID: 4199 RVA: 0x000988E4 File Offset: 0x00096AE4
		' (set) Token: 0x06001068 RID: 4200 RVA: 0x000988EE File Offset: 0x00096AEE
		Friend Overridable Property txtID As TextBox

		' Token: 0x1700062F RID: 1583
		' (get) Token: 0x06001069 RID: 4201 RVA: 0x000988F7 File Offset: 0x00096AF7
		' (set) Token: 0x0600106A RID: 4202 RVA: 0x00098901 File Offset: 0x00096B01
		Friend Overridable Property txtBatchNo As TextBox

		' Token: 0x17000630 RID: 1584
		' (get) Token: 0x0600106B RID: 4203 RVA: 0x0009890A File Offset: 0x00096B0A
		' (set) Token: 0x0600106C RID: 4204 RVA: 0x00098914 File Offset: 0x00096B14
		Friend Overridable Property txtProductName As TextBox

		' Token: 0x17000631 RID: 1585
		' (get) Token: 0x0600106D RID: 4205 RVA: 0x0009891D File Offset: 0x00096B1D
		' (set) Token: 0x0600106E RID: 4206 RVA: 0x00098927 File Offset: 0x00096B27
		Friend Overridable Property Label8 As Label

		' Token: 0x17000632 RID: 1586
		' (get) Token: 0x0600106F RID: 4207 RVA: 0x00098930 File Offset: 0x00096B30
		' (set) Token: 0x06001070 RID: 4208 RVA: 0x0009893A File Offset: 0x00096B3A
		Friend Overridable Property txtCatalogNo As TextBox

		' Token: 0x17000633 RID: 1587
		' (get) Token: 0x06001071 RID: 4209 RVA: 0x00098943 File Offset: 0x00096B43
		' (set) Token: 0x06001072 RID: 4210 RVA: 0x0009894D File Offset: 0x00096B4D
		Friend Overridable Property Label4 As Label

		' Token: 0x17000634 RID: 1588
		' (get) Token: 0x06001073 RID: 4211 RVA: 0x00098956 File Offset: 0x00096B56
		' (set) Token: 0x06001074 RID: 4212 RVA: 0x00098960 File Offset: 0x00096B60
		Friend Overridable Property Label3 As Label

		' Token: 0x17000635 RID: 1589
		' (get) Token: 0x06001075 RID: 4213 RVA: 0x00098969 File Offset: 0x00096B69
		' (set) Token: 0x06001076 RID: 4214 RVA: 0x00098973 File Offset: 0x00096B73
		Friend Overridable Property Label5 As Label

		' Token: 0x17000636 RID: 1590
		' (get) Token: 0x06001077 RID: 4215 RVA: 0x0009897C File Offset: 0x00096B7C
		' (set) Token: 0x06001078 RID: 4216 RVA: 0x00098986 File Offset: 0x00096B86
		Friend Overridable Property txtProductType As TextBox

		' Token: 0x17000637 RID: 1591
		' (get) Token: 0x06001079 RID: 4217 RVA: 0x0009898F File Offset: 0x00096B8F
		' (set) Token: 0x0600107A RID: 4218 RVA: 0x00098999 File Offset: 0x00096B99
		Friend Overridable Property txtProductID As TextBox

		' Token: 0x17000638 RID: 1592
		' (get) Token: 0x0600107B RID: 4219 RVA: 0x000989A2 File Offset: 0x00096BA2
		' (set) Token: 0x0600107C RID: 4220 RVA: 0x000989AC File Offset: 0x00096BAC
		Friend Overridable Property pnlCon As Panel

		' Token: 0x17000639 RID: 1593
		' (get) Token: 0x0600107D RID: 4221 RVA: 0x000989B5 File Offset: 0x00096BB5
		' (set) Token: 0x0600107E RID: 4222 RVA: 0x000989BF File Offset: 0x00096BBF
		Friend Overridable Property txtQCApproved As TextBox

		' Token: 0x1700063A RID: 1594
		' (get) Token: 0x0600107F RID: 4223 RVA: 0x000989C8 File Offset: 0x00096BC8
		' (set) Token: 0x06001080 RID: 4224 RVA: 0x000989D2 File Offset: 0x00096BD2
		Friend Overridable Property Label6 As Label

		' Token: 0x1700063B RID: 1595
		' (get) Token: 0x06001081 RID: 4225 RVA: 0x000989DB File Offset: 0x00096BDB
		' (set) Token: 0x06001082 RID: 4226 RVA: 0x000989E5 File Offset: 0x00096BE5
		Friend Overridable Property txtConcentration As TextBox

		' Token: 0x1700063C RID: 1596
		' (get) Token: 0x06001083 RID: 4227 RVA: 0x000989EE File Offset: 0x00096BEE
		' (set) Token: 0x06001084 RID: 4228 RVA: 0x000989F8 File Offset: 0x00096BF8
		Friend Overridable Property Label7 As Label

		' Token: 0x1700063D RID: 1597
		' (get) Token: 0x06001085 RID: 4229 RVA: 0x00098A01 File Offset: 0x00096C01
		' (set) Token: 0x06001086 RID: 4230 RVA: 0x00098A0B File Offset: 0x00096C0B
		Friend Overridable Property Panel1 As Panel

		' Token: 0x1700063E RID: 1598
		' (get) Token: 0x06001087 RID: 4231 RVA: 0x00098A14 File Offset: 0x00096C14
		' (set) Token: 0x06001088 RID: 4232 RVA: 0x00098A1E File Offset: 0x00096C1E
		Friend Overridable Property pnlTitre As Panel

		' Token: 0x1700063F RID: 1599
		' (get) Token: 0x06001089 RID: 4233 RVA: 0x00098A27 File Offset: 0x00096C27
		' (set) Token: 0x0600108A RID: 4234 RVA: 0x00098A31 File Offset: 0x00096C31
		Friend Overridable Property txtTitre As TextBox

		' Token: 0x17000640 RID: 1600
		' (get) Token: 0x0600108B RID: 4235 RVA: 0x00098A3A File Offset: 0x00096C3A
		' (set) Token: 0x0600108C RID: 4236 RVA: 0x00098A44 File Offset: 0x00096C44
		Friend Overridable Property Label11 As Label

		' Token: 0x17000641 RID: 1601
		' (get) Token: 0x0600108D RID: 4237 RVA: 0x00098A4D File Offset: 0x00096C4D
		' (set) Token: 0x0600108E RID: 4238 RVA: 0x00098A57 File Offset: 0x00096C57
		Friend Overridable Property pnlCells As Panel

		' Token: 0x17000642 RID: 1602
		' (get) Token: 0x0600108F RID: 4239 RVA: 0x00098A60 File Offset: 0x00096C60
		' (set) Token: 0x06001090 RID: 4240 RVA: 0x00098A6A File Offset: 0x00096C6A
		Friend Overridable Property txtCells As TextBox

		' Token: 0x17000643 RID: 1603
		' (get) Token: 0x06001091 RID: 4241 RVA: 0x00098A73 File Offset: 0x00096C73
		' (set) Token: 0x06001092 RID: 4242 RVA: 0x00098A7D File Offset: 0x00096C7D
		Friend Overridable Property Label10 As Label

		' Token: 0x17000644 RID: 1604
		' (get) Token: 0x06001093 RID: 4243 RVA: 0x00098A86 File Offset: 0x00096C86
		' (set) Token: 0x06001094 RID: 4244 RVA: 0x00098A90 File Offset: 0x00096C90
		Friend Overridable Property btnSave As Button
			<CompilerGenerated()>
			Get
				Return Me._btnSave
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnSave_Click
				Dim button As Button = Me._btnSave
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnSave = value
				button = Me._btnSave
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000645 RID: 1605
		' (get) Token: 0x06001095 RID: 4245 RVA: 0x00098AD3 File Offset: 0x00096CD3
		' (set) Token: 0x06001096 RID: 4246 RVA: 0x00098AE0 File Offset: 0x00096CE0
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

		' Token: 0x17000646 RID: 1606
		' (get) Token: 0x06001097 RID: 4247 RVA: 0x00098B23 File Offset: 0x00096D23
		' (set) Token: 0x06001098 RID: 4248 RVA: 0x00098B2D File Offset: 0x00096D2D
		Friend Overridable Property txtBMRNo As TextBox

		' Token: 0x17000647 RID: 1607
		' (get) Token: 0x06001099 RID: 4249 RVA: 0x00098B36 File Offset: 0x00096D36
		' (set) Token: 0x0600109A RID: 4250 RVA: 0x00098B40 File Offset: 0x00096D40
		Friend Overridable Property Label12 As Label

		' Token: 0x17000648 RID: 1608
		' (get) Token: 0x0600109B RID: 4251 RVA: 0x00098B49 File Offset: 0x00096D49
		' (set) Token: 0x0600109C RID: 4252 RVA: 0x00098B53 File Offset: 0x00096D53
		Friend Overridable Property txtGRNItemsID As TextBox

		' Token: 0x0600109D RID: 4253
		Private Declare Sub SendMessage Lib "user32.DLL" (hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

		' Token: 0x0600109E RID: 4254
		Private Declare Sub ReleaseCapture Lib "user32.DLL" ()

		' Token: 0x0600109F RID: 4255 RVA: 0x00098B5C File Offset: 0x00096D5C
		Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs)
			GRNConcentration.ReleaseCapture()
			GRNConcentration.SendMessage(MyBase.Handle, 274, 61458, 0)
		End Sub

		' Token: 0x060010A0 RID: 4256 RVA: 0x00098B7C File Offset: 0x00096D7C
		Public Sub New(FormType As String, dr As DataRow)
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.InitializeComponent()
			Designing.SetTheme(Me)
			Me.picFormIcon.Image = ResourceModule.imgFormIconPic
			MyBase.FormBorderStyle = FormBorderStyle.None
			Me.BackColor = Color.GhostWhite
			MyBase.TransparencyKey = Color.GhostWhite
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.lblCaption.Text = Strings.Replace(Me.Text, "&", "&&", 1, -1, CompareMethod.Binary)
			Me.form_btnClose.DialogResult = DialogResult.Cancel
			Me.sFormType = FormType
			Me.drData = dr
		End Sub

		' Token: 0x060010A1 RID: 4257 RVA: 0x00098C32 File Offset: 0x00096E32
		Private Sub form_btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x060010A2 RID: 4258 RVA: 0x00098C3C File Offset: 0x00096E3C
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Me.SetForm()
			Me.FillData()
		End Sub

		' Token: 0x060010A3 RID: 4259 RVA: 0x00098C50 File Offset: 0x00096E50
		Private Sub SetForm()
			Dim flag As Boolean = Not Information.IsNothing(Me.drData)
			If flag Then
				Dim text As String = Me.drData("ProductType").ToString()
				If Operators.CompareString(text, "Cell Bank - Mammalian", False) <> 0 Then
					If Operators.CompareString(text, "Cell Bank - Bacterial", False) = 0 Then
						Me.pnlCells.Visible = False
					End If
				End If
			End If
			AddHandler Me.txtConcentration.KeyDown, AddressOf Me.Keydown_Numeric
			AddHandler Me.txtCells.KeyDown, AddressOf Me.Keydown_Numeric
			AddHandler Me.txtTitre.KeyDown, AddressOf Me.Keydown_Numeric
		End Sub

		' Token: 0x060010A4 RID: 4260 RVA: 0x00098D04 File Offset: 0x00096F04
		Private Sub Keydown_Numeric(sender As Object, e As KeyEventArgs)
			Dim keyCode As Keys = e.KeyCode
			Dim flag As Boolean = (keyCode >= Keys.D0 AndAlso keyCode <= Keys.D9) OrElse (keyCode >= Keys.NumPad0 AndAlso keyCode <= Keys.NumPad9) OrElse keyCode = Keys.Back OrElse keyCode = Keys.[Decimal] OrElse keyCode = Keys.OemPeriod
			If Not flag Then
				e.SuppressKeyPress = True
			End If
		End Sub

		' Token: 0x060010A5 RID: 4261 RVA: 0x00098D54 File Offset: 0x00096F54
		Private Sub FillData()
			Dim flag As Boolean = Not Information.IsNothing(Me.drData)
			If flag Then
				Me.txtID.Text = Conversions.ToString(Me.drData("GRNID"))
				Me.txtNo.Text = Conversions.ToString(Me.drData("GRNNo"))
				Me.dtpDt.Value = Conversions.ToDate(Me.drData("GRNDt"))
				Me.txtVendor.Text = Conversions.ToString(Me.drData("VendorName"))
				Me.txtProductID.Text = Conversions.ToString(Me.drData("ProductID"))
				Me.txtProductName.Text = Conversions.ToString(Me.drData("ProductName"))
				Me.txtProductType.Text = Conversions.ToString(Me.drData("ProductType"))
				Me.txtCatalogNo.Text = Conversions.ToString(Me.drData("CatalogNo"))
				Me.txtBatchNo.Text = Conversions.ToString(Me.drData("BatchNo"))
				Me.txtQCApproved.Text = Conversions.ToString(Me.drData("QCActionBy"))
				Dim text As String = " SELECT GRNItemsID, GRNID, ProductID, CatalogNo, Description, " & vbCrLf
				text += " BMRNo, BatchNo, FinalConcentration, ActivatedCells, Titre " & vbCrLf
				text += " FROM GRNItems " & vbCrLf
				text = String.Concat(New String() { text, " WHERE GRNID = '", Me.txtID.Text, "' AND ProductID = '", Me.txtProductID.Text, "' " })
				text = text + " AND BatchNo = '" + Me.txtBatchNo.Text + "'" & vbCrLf
				Dim data As DataTable = MainModule.GetData(text)
				Dim flag2 As Boolean = data.Rows.Count > 0
				If flag2 Then
					Me.txtGRNItemsID.Text = data.Rows(0)("GRNItemsID").ToString()
					Me.txtConcentration.Text = data.Rows(0)("FinalConcentration").ToString()
					Me.txtCells.Text = data.Rows(0)("ActivatedCells").ToString()
					Me.txtTitre.Text = data.Rows(0)("Titre").ToString()
				End If
			End If
		End Sub

		' Token: 0x060010A6 RID: 4262 RVA: 0x00098FFB File Offset: 0x000971FB
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x060010A7 RID: 4263 RVA: 0x00099008 File Offset: 0x00097208
		Private Function ValidateForm() As Boolean
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.txtConcentration.Text), "", False) = 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Enter Final Concentration.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.txtConcentration.Focus()
				flag2 = False
			Else
				Dim flag3 As Boolean = (Operators.CompareString(Me.txtProductType.Text, "Cell Bank - Mammalian", False) = 0) And (Operators.CompareString(Strings.Trim(Me.txtCells.Text), "", False) = 0)
				If flag3 Then
					CustomMsgBox.Show("Enter Activated Cells.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.txtCells.Focus()
					flag2 = False
				Else
					Dim flag4 As Boolean = Operators.CompareString(Strings.Trim(Me.txtTitre.Text), "", False) = 0
					If flag4 Then
						CustomMsgBox.Show("Enter Titre.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.txtTitre.Focus()
						flag2 = False
					Else
						Dim flag5 As Boolean = Not Versioned.IsNumeric(Me.txtConcentration.Text)
						If flag5 Then
							CustomMsgBox.Show("Invalid Final Concentration.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.txtConcentration.Focus()
							flag2 = False
						Else
							Dim flag6 As Boolean = Not Versioned.IsNumeric(Me.txtCells.Text)
							If flag6 Then
								CustomMsgBox.Show("Invalid Activated Cells.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								Me.txtCells.Focus()
								flag2 = False
							Else
								Dim flag7 As Boolean = Not Versioned.IsNumeric(Me.txtTitre.Text)
								If flag7 Then
									CustomMsgBox.Show("Invalid Titre.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
									Me.txtTitre.Focus()
									flag2 = False
								Else
									flag2 = True
								End If
							End If
						End If
					End If
				End If
			End If
			Return flag2
		End Function

		' Token: 0x060010A8 RID: 4264 RVA: 0x000991C8 File Offset: 0x000973C8
		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			Try
				Me.SaveData()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x060010A9 RID: 4265 RVA: 0x00099220 File Offset: 0x00097420
		Private Sub SaveData()
			Dim flag As Boolean = Not Me.ValidateForm()
			If Not flag Then
				Dim text As String = " UPDATE GRNItems SET FinalConcentration = '" + Me.txtConcentration.Text + "', " & vbCrLf
				text = String.Concat(New String() { text, " ActivatedCells = '", Me.txtCells.Text, "', Titre = '", Me.txtTitre.Text, "' " & vbCrLf })
				text = text + " WHERE GRNItemsID = '" + Me.txtGRNItemsID.Text + "'"
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text) = 1
				If flag2 Then
					Dim text2 As String = "GRN No.: " + Me.txtNo.Text + vbCrLf
					text2 = text2 + "Catalog No.: " + Me.txtCatalogNo.Text + vbCrLf
					text2 = text2 + "Batch No.: " + Me.txtBatchNo.Text
					MainModule.TrnLog(Me.Text, "Update Concentration", text2, Nothing)
					CustomMsgBox.Show("Update Complete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					MyBase.Close()
				End If
			End If
		End Sub

		' Token: 0x04000705 RID: 1797
		Private sFormType As String

		' Token: 0x04000706 RID: 1798
		Private sEmailTo As String

		' Token: 0x04000707 RID: 1799
		Private drData As DataRow
	End Class
End Namespace
