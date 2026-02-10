Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports WeifenLuo.WinFormsUI.Docking

Namespace Datasoft_PIMS
	' Token: 0x0200004A RID: 74
	<DesignerGenerated()>
	Public Partial Class EmailAlert
		Inherits DockContent

		' Token: 0x06000D3D RID: 3389 RVA: 0x0007850F File Offset: 0x0007670F
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.EmailAlert_FormClosing
			AddHandler MyBase.Load, AddressOf Me.EmailAlert_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x170004FC RID: 1276
		' (get) Token: 0x06000D40 RID: 3392 RVA: 0x00078BB8 File Offset: 0x00076DB8
		' (set) Token: 0x06000D41 RID: 3393 RVA: 0x00078BC2 File Offset: 0x00076DC2
		Friend Overridable Property btnSave As Button

		' Token: 0x170004FD RID: 1277
		' (get) Token: 0x06000D42 RID: 3394 RVA: 0x00078BCB File Offset: 0x00076DCB
		' (set) Token: 0x06000D43 RID: 3395 RVA: 0x00078BD8 File Offset: 0x00076DD8
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

		' Token: 0x170004FE RID: 1278
		' (get) Token: 0x06000D44 RID: 3396 RVA: 0x00078C1B File Offset: 0x00076E1B
		' (set) Token: 0x06000D45 RID: 3397 RVA: 0x00078C28 File Offset: 0x00076E28
		Friend Overridable Property skip_dgvAutoMailing As DataGridView
			<CompilerGenerated()>
			Get
				Return Me._skip_dgvAutoMailing
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim dataGridViewCellEventHandler As DataGridViewCellEventHandler = AddressOf Me.skip_dgvAutoMailing_CellContentClick
				Dim dataGridViewCellMouseEventHandler As DataGridViewCellMouseEventHandler = AddressOf Me.skip_dgvAutoMailing_CellMouseDown
				Dim dataGridViewCellEventHandler2 As DataGridViewCellEventHandler = AddressOf Me.skip_dgvAutoMailing_CellMouseEnter
				Dim dataGridViewCellEventHandler3 As DataGridViewCellEventHandler = AddressOf Me.skip_dgvAutoMailing_CellMouseLeave
				Dim dataGridViewCellMouseEventHandler2 As DataGridViewCellMouseEventHandler = AddressOf Me.skip_dgvAutoMailing_CellMouseUp
				Dim dataGridView As DataGridView = Me._skip_dgvAutoMailing
				If dataGridView IsNot Nothing Then
					RemoveHandler dataGridView.CellContentClick, dataGridViewCellEventHandler
					RemoveHandler dataGridView.CellMouseDown, dataGridViewCellMouseEventHandler
					RemoveHandler dataGridView.CellMouseEnter, dataGridViewCellEventHandler2
					RemoveHandler dataGridView.CellMouseLeave, dataGridViewCellEventHandler3
					RemoveHandler dataGridView.CellMouseUp, dataGridViewCellMouseEventHandler2
				End If
				Me._skip_dgvAutoMailing = value
				dataGridView = Me._skip_dgvAutoMailing
				If dataGridView IsNot Nothing Then
					AddHandler dataGridView.CellContentClick, dataGridViewCellEventHandler
					AddHandler dataGridView.CellMouseDown, dataGridViewCellMouseEventHandler
					AddHandler dataGridView.CellMouseEnter, dataGridViewCellEventHandler2
					AddHandler dataGridView.CellMouseLeave, dataGridViewCellEventHandler3
					AddHandler dataGridView.CellMouseUp, dataGridViewCellMouseEventHandler2
				End If
			End Set
		End Property

		' Token: 0x170004FF RID: 1279
		' (get) Token: 0x06000D46 RID: 3398 RVA: 0x00078CE8 File Offset: 0x00076EE8
		' (set) Token: 0x06000D47 RID: 3399 RVA: 0x00078CF2 File Offset: 0x00076EF2
		Friend Overridable Property Setting As DataGridViewImageColumn

		' Token: 0x17000500 RID: 1280
		' (get) Token: 0x06000D48 RID: 3400 RVA: 0x00078CFB File Offset: 0x00076EFB
		' (set) Token: 0x06000D49 RID: 3401 RVA: 0x00078D05 File Offset: 0x00076F05
		Friend Overridable Property EmailSettingsID As DataGridViewTextBoxColumn

		' Token: 0x17000501 RID: 1281
		' (get) Token: 0x06000D4A RID: 3402 RVA: 0x00078D0E File Offset: 0x00076F0E
		' (set) Token: 0x06000D4B RID: 3403 RVA: 0x00078D18 File Offset: 0x00076F18
		Friend Overridable Property Transactions As DataGridViewTextBoxColumn

		' Token: 0x17000502 RID: 1282
		' (get) Token: 0x06000D4C RID: 3404 RVA: 0x00078D21 File Offset: 0x00076F21
		' (set) Token: 0x06000D4D RID: 3405 RVA: 0x00078D2B File Offset: 0x00076F2B
		Friend Overridable Property AutoMailing As DataGridViewImageColumn

		' Token: 0x17000503 RID: 1283
		' (get) Token: 0x06000D4E RID: 3406 RVA: 0x00078D34 File Offset: 0x00076F34
		' (set) Token: 0x06000D4F RID: 3407 RVA: 0x00078D3E File Offset: 0x00076F3E
		Friend Overridable Property AutoMailingVal As DataGridViewTextBoxColumn

		' Token: 0x06000D50 RID: 3408 RVA: 0x00078D48 File Offset: 0x00076F48
		Private Sub EmailAlert_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x06000D51 RID: 3409 RVA: 0x00078D7D File Offset: 0x00076F7D
		Private Sub EmailAlert_Load(sender As Object, e As EventArgs)
			Designing.SetTheme(Me)
			Me.SetDatagridDesign()
			Me.FillData()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x06000D52 RID: 3410 RVA: 0x00078DAC File Offset: 0x00076FAC
		Private Sub SetDatagridDesign()
			Me.skip_dgvAutoMailing.Columns("Transactions").DefaultCellStyle.SelectionBackColor = ResourceModule.dgvRowsDefaultCellStyleSelectionBackColor
			Me.skip_dgvAutoMailing.Columns("AutoMailing").DefaultCellStyle.SelectionBackColor = Color.White
			Me.Setting.Image = ResourceModule.imgSettingRound
			Me.AutoMailing.Image = ResourceModule.imgGrayToggleSwitch
		End Sub

		' Token: 0x06000D53 RID: 3411 RVA: 0x00078E28 File Offset: 0x00077028
		Private Sub FillData()
			' The following expression was wrapped in a checked-statement
			Try
				Dim text As String = " SELECT EmailSettingsID, SortOrder, Transactions, AutoMailing " & vbCrLf
				text += " FROM EmailSettings WHERE IsActive = 1 ORDER BY SortOrder " & vbCrLf
				Dim data As DataTable = MainModule.GetData(text)
				Me.skip_dgvAutoMailing.Rows.Clear()
				Dim num As Integer = data.Rows.Count - 1
				For i As Integer = 0 To num
					Me.skip_dgvAutoMailing.Rows.Add()
					Me.skip_dgvAutoMailing.Rows(Me.skip_dgvAutoMailing.RowCount - 1).Cells("EmailSettingsID").Value = data.Rows(i)("EmailSettingsID").ToString()
					Me.skip_dgvAutoMailing.Rows(Me.skip_dgvAutoMailing.RowCount - 1).Cells("Transactions").Value = data.Rows(i)("Transactions").ToString()
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(data.Rows(i)("AutoMailing"))
					Me.skip_dgvAutoMailing.Rows(Me.skip_dgvAutoMailing.RowCount - 1).Cells("AutoMailingVal").Value = data.Rows(i)("AutoMailing").ToString()
					Dim flag As Boolean = Operators.CompareString(data.Rows(i)("AutoMailing").ToString(), "False", False) = 0
					If flag Then
						Me.skip_dgvAutoMailing.Rows(Me.skip_dgvAutoMailing.RowCount - 1).Cells("AutoMailing").Value = ResourceModule.imgGrayToggleSwitch
						Me.skip_dgvAutoMailing.Rows(Me.skip_dgvAutoMailing.RowCount - 1).Cells("AutoMailingVal").Value = "False"
					Else
						Me.skip_dgvAutoMailing.Rows(Me.skip_dgvAutoMailing.RowCount - 1).Cells("AutoMailing").Value = ResourceModule.imgGreenToggleSwitch
						Me.skip_dgvAutoMailing.Rows(Me.skip_dgvAutoMailing.RowCount - 1).Cells("AutoMailingVal").Value = "True"
					End If
				Next
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06000D54 RID: 3412 RVA: 0x000790F4 File Offset: 0x000772F4
		Private Function SetOnOff(sID As String, sTrn As String, sVal As String) As Boolean
			Try
				Dim text As String = "Transaction ID : " + sID + vbCrLf
				text = text + "Transaction : " + sTrn + vbCrLf
				Dim flag As Boolean = Operators.CompareString(sVal, "True", False) = 0
				Dim num As Integer
				If flag Then
					num = 0
					text += "Email Alerrts : OFF"
				Else
					num = 1
					text += "Email Alerrts : ON"
				End If
				Dim text2 As String = String.Concat(New String() { "UPDATE EmailSettings SET AutoMailing = ", Conversions.ToString(num), "  WHERE EmailSettingsID = '", sID, "'" })
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text2) = 1
				If flag2 Then
					MainModule.TrnLog(Me.Text, "Alert Status", text, Nothing)
					Return True
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Return False
		End Function

		' Token: 0x06000D55 RID: 3413 RVA: 0x000791FC File Offset: 0x000773FC
		Private Sub skip_dgvAutoMailing_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = (e.RowIndex > -1) And (e.ColumnIndex > -1)
			If flag Then
				Dim text As String = Me.skip_dgvAutoMailing.Columns(e.ColumnIndex).Name.ToString()
				If Operators.CompareString(text, "AutoMailing", False) = 0 Then
					Dim text2 As String = Conversions.ToString(Me.skip_dgvAutoMailing.Rows(e.RowIndex).Cells("EmailSettingsID").Value)
					Dim text3 As String = Conversions.ToString(Me.skip_dgvAutoMailing.Rows(e.RowIndex).Cells("Transactions").Value)
					Dim text4 As String = Conversions.ToString(Me.skip_dgvAutoMailing.Rows(e.RowIndex).Cells("AutoMailingVal").Value)
					Dim flag2 As Boolean = Me.SetOnOff(text2, text3, text4)
					If flag2 Then
						Dim flag3 As Boolean = Operators.ConditionalCompareObjectEqual(Me.skip_dgvAutoMailing.Rows(e.RowIndex).Cells("AutoMailingVal").Value, "False", False)
						If flag3 Then
							Me.skip_dgvAutoMailing.Rows(e.RowIndex).Cells("AutoMailing").Value = ResourceModule.imgGreenToggleSwitch
							Me.skip_dgvAutoMailing.Rows(e.RowIndex).Cells("AutoMailingVal").Value = "True"
						Else
							Me.skip_dgvAutoMailing.Rows(e.RowIndex).Cells("AutoMailing").Value = ResourceModule.imgGrayToggleSwitch
							Me.skip_dgvAutoMailing.Rows(e.RowIndex).Cells("AutoMailingVal").Value = "False"
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x06000D56 RID: 3414 RVA: 0x00079408 File Offset: 0x00077608
		Private Sub skip_dgvAutoMailing_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs)
			Dim flag As Boolean = (e.RowIndex > -1) And (e.ColumnIndex > -1)
			If flag Then
				Dim text As String = Me.skip_dgvAutoMailing.Columns(e.ColumnIndex).Name.ToString()
				If Operators.CompareString(text, "Setting", False) = 0 Then
					Me.skip_dgvAutoMailing.Rows(e.RowIndex).Cells("Setting").Value = ResourceModule.imgSettingRoundClick
				End If
			End If
		End Sub

		' Token: 0x06000D57 RID: 3415 RVA: 0x00079498 File Offset: 0x00077698
		Private Sub skip_dgvAutoMailing_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = (e.RowIndex > -1) And (e.ColumnIndex > -1)
			If flag Then
				Dim text As String = Me.skip_dgvAutoMailing.Columns(e.ColumnIndex).Name.ToString()
				If Operators.CompareString(text, "Setting", False) = 0 Then
					Me.skip_dgvAutoMailing.Rows(e.RowIndex).Cells("Setting").Value = ResourceModule.imgSettingRoundHover
				End If
			End If
		End Sub

		' Token: 0x06000D58 RID: 3416 RVA: 0x00079528 File Offset: 0x00077728
		Private Sub skip_dgvAutoMailing_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = (e.RowIndex > -1) And (e.ColumnIndex > -1)
			If flag Then
				Dim text As String = Me.skip_dgvAutoMailing.Columns(e.ColumnIndex).Name.ToString()
				If Operators.CompareString(text, "Setting", False) = 0 Then
					Me.skip_dgvAutoMailing.Rows(e.RowIndex).Cells("Setting").Value = ResourceModule.imgSettingRound
				End If
			End If
		End Sub

		' Token: 0x06000D59 RID: 3417 RVA: 0x000795B8 File Offset: 0x000777B8
		Private Sub skip_dgvAutoMailing_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs)
			Dim flag As Boolean = (e.RowIndex > -1) And (e.ColumnIndex > -1)
			If flag Then
				Dim text As String = Me.skip_dgvAutoMailing.Columns(e.ColumnIndex).Name.ToString()
				If Operators.CompareString(text, "Setting", False) = 0 Then
					Me.skip_dgvAutoMailing.Rows(e.RowIndex).Cells("Setting").Value = ResourceModule.imgSettingRound
					Dim emailAlertDtls As EmailAlertDtls = New EmailAlertDtls(Me.skip_dgvAutoMailing.Rows(e.RowIndex))
					emailAlertDtls.ShowDialog()
				End If
			End If
		End Sub

		' Token: 0x06000D5A RID: 3418 RVA: 0x0007966B File Offset: 0x0007786B
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub
	End Class
End Namespace
