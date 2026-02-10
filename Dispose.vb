Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports WeifenLuo.WinFormsUI.Docking

Namespace Datasoft_PIMS
	' Token: 0x0200005F RID: 95
	<DesignerGenerated()>
	Public Partial Class Dispose
		Inherits DockContent

		' Token: 0x0600152C RID: 5420 RVA: 0x000C1CBC File Offset: 0x000BFEBC
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Dispose_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Dispose_Load
			Me.dtUID = New DataTable()
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000817 RID: 2071
		' (get) Token: 0x0600152F RID: 5423 RVA: 0x000C2A4D File Offset: 0x000C0C4D
		' (set) Token: 0x06001530 RID: 5424 RVA: 0x000C2A58 File Offset: 0x000C0C58
		Friend Overridable Property dgvUID As DataGridView
			<CompilerGenerated()>
			Get
				Return Me._dgvUID
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim dataGridViewCellEventHandler As DataGridViewCellEventHandler = AddressOf Me.dgvUID_CellContentClick
				Dim dataGridView As DataGridView = Me._dgvUID
				If dataGridView IsNot Nothing Then
					RemoveHandler dataGridView.CellContentClick, dataGridViewCellEventHandler
				End If
				Me._dgvUID = value
				dataGridView = Me._dgvUID
				If dataGridView IsNot Nothing Then
					AddHandler dataGridView.CellContentClick, dataGridViewCellEventHandler
				End If
			End Set
		End Property

		' Token: 0x17000818 RID: 2072
		' (get) Token: 0x06001531 RID: 5425 RVA: 0x000C2A9B File Offset: 0x000C0C9B
		' (set) Token: 0x06001532 RID: 5426 RVA: 0x000C2AA8 File Offset: 0x000C0CA8
		Friend Overridable Property sml_btnAdd As Button
			<CompilerGenerated()>
			Get
				Return Me._sml_btnAdd
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.sml_btnAdd_Click
				Dim button As Button = Me._sml_btnAdd
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._sml_btnAdd = value
				button = Me._sml_btnAdd
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000819 RID: 2073
		' (get) Token: 0x06001533 RID: 5427 RVA: 0x000C2AEB File Offset: 0x000C0CEB
		' (set) Token: 0x06001534 RID: 5428 RVA: 0x000C2AF5 File Offset: 0x000C0CF5
		Friend Overridable Property lblRows As Label

		' Token: 0x1700081A RID: 2074
		' (get) Token: 0x06001535 RID: 5429 RVA: 0x000C2AFE File Offset: 0x000C0CFE
		' (set) Token: 0x06001536 RID: 5430 RVA: 0x000C2B08 File Offset: 0x000C0D08
		Friend Overridable Property Label1 As Label

		' Token: 0x1700081B RID: 2075
		' (get) Token: 0x06001537 RID: 5431 RVA: 0x000C2B11 File Offset: 0x000C0D11
		' (set) Token: 0x06001538 RID: 5432 RVA: 0x000C2B1C File Offset: 0x000C0D1C
		Friend Overridable Property txtBarcode As TextBox
			<CompilerGenerated()>
			Get
				Return Me._txtBarcode
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim keyEventHandler As KeyEventHandler = AddressOf Me.txtBarcode_KeyDown
				Dim textBox As TextBox = Me._txtBarcode
				If textBox IsNot Nothing Then
					RemoveHandler textBox.KeyDown, keyEventHandler
				End If
				Me._txtBarcode = value
				textBox = Me._txtBarcode
				If textBox IsNot Nothing Then
					AddHandler textBox.KeyDown, keyEventHandler
				End If
			End Set
		End Property

		' Token: 0x1700081C RID: 2076
		' (get) Token: 0x06001539 RID: 5433 RVA: 0x000C2B5F File Offset: 0x000C0D5F
		' (set) Token: 0x0600153A RID: 5434 RVA: 0x000C2B69 File Offset: 0x000C0D69
		Friend Overridable Property txtRemarks As TextBox

		' Token: 0x1700081D RID: 2077
		' (get) Token: 0x0600153B RID: 5435 RVA: 0x000C2B72 File Offset: 0x000C0D72
		' (set) Token: 0x0600153C RID: 5436 RVA: 0x000C2B7C File Offset: 0x000C0D7C
		Friend Overridable Property Label2 As Label

		' Token: 0x1700081E RID: 2078
		' (get) Token: 0x0600153D RID: 5437 RVA: 0x000C2B85 File Offset: 0x000C0D85
		' (set) Token: 0x0600153E RID: 5438 RVA: 0x000C2B90 File Offset: 0x000C0D90
		Friend Overridable Property btnDispose As Button
			<CompilerGenerated()>
			Get
				Return Me._btnDispose
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Dispose_Click
				Dim button As Button = Me._btnDispose
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnDispose = value
				button = Me._btnDispose
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700081F RID: 2079
		' (get) Token: 0x0600153F RID: 5439 RVA: 0x000C2BD3 File Offset: 0x000C0DD3
		' (set) Token: 0x06001540 RID: 5440 RVA: 0x000C2BE0 File Offset: 0x000C0DE0
		Friend Overridable Property btnClear As Button
			<CompilerGenerated()>
			Get
				Return Me._btnClear
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnClear_Click
				Dim button As Button = Me._btnClear
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnClear = value
				button = Me._btnClear
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000820 RID: 2080
		' (get) Token: 0x06001541 RID: 5441 RVA: 0x000C2C23 File Offset: 0x000C0E23
		' (set) Token: 0x06001542 RID: 5442 RVA: 0x000C2C30 File Offset: 0x000C0E30
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

		' Token: 0x17000821 RID: 2081
		' (get) Token: 0x06001543 RID: 5443 RVA: 0x000C2C73 File Offset: 0x000C0E73
		' (set) Token: 0x06001544 RID: 5444 RVA: 0x000C2C7D File Offset: 0x000C0E7D
		Friend Overridable Property btnDelete_Item As DataGridViewImageColumn

		' Token: 0x17000822 RID: 2082
		' (get) Token: 0x06001545 RID: 5445 RVA: 0x000C2C86 File Offset: 0x000C0E86
		' (set) Token: 0x06001546 RID: 5446 RVA: 0x000C2C90 File Offset: 0x000C0E90
		Friend Overridable Property UID As DataGridViewTextBoxColumn

		' Token: 0x17000823 RID: 2083
		' (get) Token: 0x06001547 RID: 5447 RVA: 0x000C2C99 File Offset: 0x000C0E99
		' (set) Token: 0x06001548 RID: 5448 RVA: 0x000C2CA3 File Offset: 0x000C0EA3
		Friend Overridable Property LocationCode As DataGridViewTextBoxColumn

		' Token: 0x17000824 RID: 2084
		' (get) Token: 0x06001549 RID: 5449 RVA: 0x000C2CAC File Offset: 0x000C0EAC
		' (set) Token: 0x0600154A RID: 5450 RVA: 0x000C2CB6 File Offset: 0x000C0EB6
		Friend Overridable Property CatalogNo As DataGridViewTextBoxColumn

		' Token: 0x17000825 RID: 2085
		' (get) Token: 0x0600154B RID: 5451 RVA: 0x000C2CBF File Offset: 0x000C0EBF
		' (set) Token: 0x0600154C RID: 5452 RVA: 0x000C2CC9 File Offset: 0x000C0EC9
		Friend Overridable Property ProductName As DataGridViewTextBoxColumn

		' Token: 0x17000826 RID: 2086
		' (get) Token: 0x0600154D RID: 5453 RVA: 0x000C2CD2 File Offset: 0x000C0ED2
		' (set) Token: 0x0600154E RID: 5454 RVA: 0x000C2CDC File Offset: 0x000C0EDC
		Friend Overridable Property Description As DataGridViewTextBoxColumn

		' Token: 0x17000827 RID: 2087
		' (get) Token: 0x0600154F RID: 5455 RVA: 0x000C2CE5 File Offset: 0x000C0EE5
		' (set) Token: 0x06001550 RID: 5456 RVA: 0x000C2CEF File Offset: 0x000C0EEF
		Friend Overridable Property GRNNo As DataGridViewTextBoxColumn

		' Token: 0x17000828 RID: 2088
		' (get) Token: 0x06001551 RID: 5457 RVA: 0x000C2CF8 File Offset: 0x000C0EF8
		' (set) Token: 0x06001552 RID: 5458 RVA: 0x000C2D02 File Offset: 0x000C0F02
		Friend Overridable Property BatchNo As DataGridViewTextBoxColumn

		' Token: 0x17000829 RID: 2089
		' (get) Token: 0x06001553 RID: 5459 RVA: 0x000C2D0B File Offset: 0x000C0F0B
		' (set) Token: 0x06001554 RID: 5460 RVA: 0x000C2D15 File Offset: 0x000C0F15
		Friend Overridable Property ExpDt As DataGridViewTextBoxColumn

		' Token: 0x1700082A RID: 2090
		' (get) Token: 0x06001555 RID: 5461 RVA: 0x000C2D1E File Offset: 0x000C0F1E
		' (set) Token: 0x06001556 RID: 5462 RVA: 0x000C2D28 File Offset: 0x000C0F28
		Friend Overridable Property Status As DataGridViewTextBoxColumn

		' Token: 0x06001557 RID: 5463 RVA: 0x000C2D34 File Offset: 0x000C0F34
		Private Sub Dispose_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x06001558 RID: 5464 RVA: 0x000C2D69 File Offset: 0x000C0F69
		Private Sub Dispose_Load(sender As Object, e As EventArgs)
			Designing.SetTheme(Me)
			Me.ClearForm()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x06001559 RID: 5465 RVA: 0x000C2D94 File Offset: 0x000C0F94
		Private Sub ClearForm()
			Me.txtBarcode.Text = ""
			Me.txtRemarks.Text = ""
			Me.dtUID = New DataTable() With { .Columns = { { "UID", Type.[GetType]("System.String") }, { "LocationCode", Type.[GetType]("System.String") }, { "CatalogNo", Type.[GetType]("System.String") }, { "ProductName", Type.[GetType]("System.String") }, { "Description", Type.[GetType]("System.String") }, { "GRNNo", Type.[GetType]("System.String") }, { "BatchNo", Type.[GetType]("System.String") }, { "ExpDt", Type.[GetType]("System.DateTime") }, { "Status", Type.[GetType]("System.String") } } }
			Me.lblRows.Text = "0 - Rows"
			Me.dgvUID.DataSource = Me.dtUID
		End Sub

		' Token: 0x0600155A RID: 5466 RVA: 0x000C2EE7 File Offset: 0x000C10E7
		Private Sub btnClear_Click(sender As Object, e As EventArgs)
			Me.ClearForm()
		End Sub

		' Token: 0x0600155B RID: 5467 RVA: 0x000C2EF1 File Offset: 0x000C10F1
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x0600155C RID: 5468 RVA: 0x000C2EFC File Offset: 0x000C10FC
		Private Sub txtBarcode_KeyDown(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = e.KeyCode = Keys.[Return]
			If flag Then
				Cursor.Current = Cursors.WaitCursor
				Me.AddBarcode()
				Cursor.Current = Cursors.[Default]
			End If
		End Sub

		' Token: 0x0600155D RID: 5469 RVA: 0x000C2F37 File Offset: 0x000C1137
		Private Sub sml_btnAdd_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Me.AddBarcode()
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x0600155E RID: 5470 RVA: 0x000C2F58 File Offset: 0x000C1158
		Private Function ValidateAdd() As Boolean
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.txtBarcode.Text), "", False) = 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Scan/ Entr Product Barcode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.txtBarcode.Focus()
				flag2 = False
			Else
				Dim flag3 As Boolean = Strings.Trim(Me.txtBarcode.Text).Length <> 10
				If flag3 Then
					CustomMsgBox.Show("Invalid Product Barcode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.txtBarcode.Focus()
					flag2 = False
				Else
					Dim flag4 As Boolean = (Operators.CompareString(Strings.Mid(Strings.Trim(Me.txtBarcode.Text), 1, 2), "IA", False) <> 0) Or Not Versioned.IsNumeric(Strings.Mid(Strings.Trim(Me.txtBarcode.Text), 6))
					If flag4 Then
						CustomMsgBox.Show("Invalid Product Barcode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						Me.txtBarcode.Focus()
						flag2 = False
					Else
						Dim flag5 As Boolean = Me.dtUID.[Select]("UID = '" + Strings.Trim(Me.txtBarcode.Text) + "'").Length > 0
						If flag5 Then
							CustomMsgBox.Show("Product Barcode Already In List.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Me.txtBarcode.Focus()
							flag2 = False
						Else
							flag2 = True
						End If
					End If
				End If
			End If
			Return flag2
		End Function

		' Token: 0x0600155F RID: 5471 RVA: 0x000C30C0 File Offset: 0x000C12C0
		Private Sub AddBarcode()
			Try
				Dim flag As Boolean = Not Me.ValidateAdd()
				If Not flag Then
					Dim text As String = " SELECT UID, LocationCode, P.CatalogNo, P.ProductName, Description, GRNNo, BatchNo, ExpDt, GU.Status " & vbCrLf
					text += " FROM GRNUID GU  " & vbCrLf
					text += " INNER JOIN Product P ON GU.ProductID = P.ProductID  " & vbCrLf
					text += " INNER JOIN GRN G ON GU.GRNID = G.GRNID " & vbCrLf
					text = text + " WHERE UID = '" + Strings.Trim(Me.txtBarcode.Text) + "' " & vbCrLf
					Dim data As DataTable = MainModule.GetData(text)
					Dim flag2 As Boolean = data.Rows.Count > 0
					If flag2 Then
						Dim obj As Object = data.Rows(0)("Status")
						Dim flag3 As Boolean = Operators.ConditionalCompareObjectEqual(obj, "Available", False)
						If flag3 Then
							Me.dtUID.Rows.InsertAt(Me.dtUID.NewRow(), 0)
							Me.dtUID.Rows(0)("UID") = RuntimeHelpers.GetObjectValue(data.Rows(0)("UID"))
							Me.dtUID.Rows(0)("LocationCode") = RuntimeHelpers.GetObjectValue(data.Rows(0)("LocationCode"))
							Me.dtUID.Rows(0)("CatalogNo") = RuntimeHelpers.GetObjectValue(data.Rows(0)("CatalogNo"))
							Me.dtUID.Rows(0)("ProductName") = RuntimeHelpers.GetObjectValue(data.Rows(0)("ProductName"))
							Me.dtUID.Rows(0)("Description") = RuntimeHelpers.GetObjectValue(data.Rows(0)("Description"))
							Me.dtUID.Rows(0)("GRNNo") = RuntimeHelpers.GetObjectValue(data.Rows(0)("GRNNo"))
							Me.dtUID.Rows(0)("BatchNo") = RuntimeHelpers.GetObjectValue(data.Rows(0)("BatchNo"))
							Me.dtUID.Rows(0)("ExpDt") = RuntimeHelpers.GetObjectValue(data.Rows(0)("ExpDt"))
							Me.dgvUID.DataSource = Me.dtUID
							Me.lblRows.Text = Conversions.ToString(Me.dtUID.Rows.Count) + " - Row(s)"
							Me.txtBarcode.Text = ""
							Me.txtBarcode.Focus()
						Else
							CustomMsgBox.Show("Product Barcode Not In Disposable State.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						End If
					Else
						CustomMsgBox.Show("Invalid Product Barcode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					End If
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06001560 RID: 5472 RVA: 0x000C3424 File Offset: 0x000C1624
		Private Sub dgvUID_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = e.RowIndex > -1
			If flag Then
				Dim array As DataRow() = Me.dtUID.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UID = '", Me.dgvUID.Rows(e.RowIndex).Cells("UID").Value), "'")))
				Dim flag2 As Boolean = array.Length = 1
				If flag2 Then
					Dim text As String = Me.dgvUID.Columns(e.ColumnIndex).Name.ToString()
					If Operators.CompareString(text, "btnDelete_Item", False) = 0 Then
						Me.dtUID.Rows.Remove(array(0))
						Me.dtUID.AcceptChanges()
						Me.lblRows.Text = Conversions.ToString(Me.dtUID.Rows.Count) + " - Row(s)"
					End If
				End If
			End If
		End Sub

		' Token: 0x06001561 RID: 5473 RVA: 0x000C3524 File Offset: 0x000C1724
		Private Function ValidateDipose() As Object
			Dim flag As Boolean = Me.dtUID.Rows.Count = 0
			Dim obj As Object
			If flag Then
				CustomMsgBox.Show("No Product Barcode To Dispose.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.txtBarcode.Focus()
				obj = False
			Else
				Dim flag2 As Boolean = Operators.CompareString(Me.txtRemarks.Text, "", False) = 0
				If flag2 Then
					CustomMsgBox.Show("Enter Dispose Remarks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.txtRemarks.Focus()
					obj = False
				Else
					obj = True
				End If
			End If
			Return obj
		End Function

		' Token: 0x06001562 RID: 5474 RVA: 0x000C35C4 File Offset: 0x000C17C4
		Private Sub Dispose_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.DisposeBarcode()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.btnDispose.Enabled = True
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06001563 RID: 5475 RVA: 0x000C3640 File Offset: 0x000C1840
		Private Sub DisposeBarcode()
			Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(Me.ValidateDipose(), False, False)
			If Not flag Then
				Me.btnDispose.Enabled = False
				Dim text As String = ""
				Dim num As Integer = Me.dtUID.Rows.Count - 1
				For i As Integer = 0 To num
					text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Me.dtUID.Rows(i)("UID")), "',")))
				Next
				Dim text2 As String = " UPDATE GRNUID SET Status = 'Disposed', ActionBy = '" + GlobalVariables.gsUserID + "', ActionDt = GETDATE(), " & vbCrLf
				text2 = text2 + " Remarks = '" + Strings.Trim(Me.txtRemarks.Text) + "'" & vbCrLf
				text2 = text2 + " WHERE UID IN (" + Strings.Mid(text, 1, text.Length - 1) + ")"
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text2) = 1
				If flag2 Then
					MainModule.TrnLog(Me.Text, "Product Disposed", "UID List : " + Strings.Replace(Strings.Mid(text, 1, text.Length - 1), "'", "", 1, -1, CompareMethod.Binary), Nothing)
					EmailModule.SendMail("Dispose", Strings.Replace(Strings.Mid(text, 1, text.Length - 1), "'", "", 1, -1, CompareMethod.Binary), Me.txtRemarks.Text, "")
					CustomMsgBox.Show("Product Barcode(s) Disposed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				End If
			End If
		End Sub

		' Token: 0x0400091A RID: 2330
		Private dtUID As DataTable
	End Class
End Namespace
