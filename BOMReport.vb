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
	' Token: 0x02000013 RID: 19
	<DesignerGenerated()>
	Public Partial Class BOMReport
		Inherits DockContent

		' Token: 0x170000DF RID: 223
		' (get) Token: 0x06000275 RID: 629 RVA: 0x00018FD4 File Offset: 0x000171D4
		' (set) Token: 0x06000276 RID: 630 RVA: 0x00018FDE File Offset: 0x000171DE
		Friend Overridable Property GbBasic As GroupBox

		' Token: 0x170000E0 RID: 224
		' (get) Token: 0x06000277 RID: 631 RVA: 0x00018FE7 File Offset: 0x000171E7
		' (set) Token: 0x06000278 RID: 632 RVA: 0x00018FF1 File Offset: 0x000171F1
		Friend Overridable Property cmbStatus As ComboBox

		' Token: 0x170000E1 RID: 225
		' (get) Token: 0x06000279 RID: 633 RVA: 0x00018FFA File Offset: 0x000171FA
		' (set) Token: 0x0600027A RID: 634 RVA: 0x00019004 File Offset: 0x00017204
		Friend Overridable Property Label13 As Label

		' Token: 0x170000E2 RID: 226
		' (get) Token: 0x0600027B RID: 635 RVA: 0x0001900D File Offset: 0x0001720D
		' (set) Token: 0x0600027C RID: 636 RVA: 0x00019017 File Offset: 0x00017217
		Friend Overridable Property txtBOMVersion As TextBox

		' Token: 0x170000E3 RID: 227
		' (get) Token: 0x0600027D RID: 637 RVA: 0x00019020 File Offset: 0x00017220
		' (set) Token: 0x0600027E RID: 638 RVA: 0x0001902A File Offset: 0x0001722A
		Friend Overridable Property Label1 As Label

		' Token: 0x170000E4 RID: 228
		' (get) Token: 0x0600027F RID: 639 RVA: 0x00019033 File Offset: 0x00017233
		' (set) Token: 0x06000280 RID: 640 RVA: 0x0001903D File Offset: 0x0001723D
		Friend Overridable Property txtSCatalogNo As TextBox

		' Token: 0x170000E5 RID: 229
		' (get) Token: 0x06000281 RID: 641 RVA: 0x00019046 File Offset: 0x00017246
		' (set) Token: 0x06000282 RID: 642 RVA: 0x00019050 File Offset: 0x00017250
		Friend Overridable Property Label37 As Label

		' Token: 0x170000E6 RID: 230
		' (get) Token: 0x06000283 RID: 643 RVA: 0x00019059 File Offset: 0x00017259
		' (set) Token: 0x06000284 RID: 644 RVA: 0x00019063 File Offset: 0x00017263
		Friend Overridable Property txtSName As TextBox

		' Token: 0x170000E7 RID: 231
		' (get) Token: 0x06000285 RID: 645 RVA: 0x0001906C File Offset: 0x0001726C
		' (set) Token: 0x06000286 RID: 646 RVA: 0x00019076 File Offset: 0x00017276
		Friend Overridable Property Label11 As Label

		' Token: 0x170000E8 RID: 232
		' (get) Token: 0x06000287 RID: 647 RVA: 0x0001907F File Offset: 0x0001727F
		' (set) Token: 0x06000288 RID: 648 RVA: 0x00019089 File Offset: 0x00017289
		Friend Overridable Property txtSCode As TextBox

		' Token: 0x170000E9 RID: 233
		' (get) Token: 0x06000289 RID: 649 RVA: 0x00019092 File Offset: 0x00017292
		' (set) Token: 0x0600028A RID: 650 RVA: 0x0001909C File Offset: 0x0001729C
		Friend Overridable Property Label14 As Label

		' Token: 0x170000EA RID: 234
		' (get) Token: 0x0600028B RID: 651 RVA: 0x000190A5 File Offset: 0x000172A5
		' (set) Token: 0x0600028C RID: 652 RVA: 0x000190B0 File Offset: 0x000172B0
		Friend Overridable Property arrow_btnBasicExp_sml As Button
			<CompilerGenerated()>
			Get
				Return Me._arrow_btnBasicExp_sml
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.skip_btnBasicExp_sml_Click
				Dim button As Button = Me._arrow_btnBasicExp_sml
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._arrow_btnBasicExp_sml = value
				button = Me._arrow_btnBasicExp_sml
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170000EB RID: 235
		' (get) Token: 0x0600028D RID: 653 RVA: 0x000190F3 File Offset: 0x000172F3
		' (set) Token: 0x0600028E RID: 654 RVA: 0x000190FD File Offset: 0x000172FD
		Friend Overridable Property GbAdvanced As GroupBox

		' Token: 0x170000EC RID: 236
		' (get) Token: 0x0600028F RID: 655 RVA: 0x00019106 File Offset: 0x00017306
		' (set) Token: 0x06000290 RID: 656 RVA: 0x00019110 File Offset: 0x00017310
		Friend Overridable Property dtpFrom As DateTimePicker

		' Token: 0x170000ED RID: 237
		' (get) Token: 0x06000291 RID: 657 RVA: 0x00019119 File Offset: 0x00017319
		' (set) Token: 0x06000292 RID: 658 RVA: 0x00019123 File Offset: 0x00017323
		Friend Overridable Property dtpTo As DateTimePicker

		' Token: 0x170000EE RID: 238
		' (get) Token: 0x06000293 RID: 659 RVA: 0x0001912C File Offset: 0x0001732C
		' (set) Token: 0x06000294 RID: 660 RVA: 0x00019136 File Offset: 0x00017336
		Friend Overridable Property Label16 As Label

		' Token: 0x170000EF RID: 239
		' (get) Token: 0x06000295 RID: 661 RVA: 0x0001913F File Offset: 0x0001733F
		' (set) Token: 0x06000296 RID: 662 RVA: 0x00019149 File Offset: 0x00017349
		Friend Overridable Property lblSDate As ComboBox

		' Token: 0x170000F0 RID: 240
		' (get) Token: 0x06000297 RID: 663 RVA: 0x00019152 File Offset: 0x00017352
		' (set) Token: 0x06000298 RID: 664 RVA: 0x0001915C File Offset: 0x0001735C
		Friend Overridable Property arrow_btnAdvanceExp_sml As Button
			<CompilerGenerated()>
			Get
				Return Me._arrow_btnAdvanceExp_sml
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.skip_btnAdvanceExp_sml_Click
				Dim button As Button = Me._arrow_btnAdvanceExp_sml
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._arrow_btnAdvanceExp_sml = value
				button = Me._arrow_btnAdvanceExp_sml
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170000F1 RID: 241
		' (get) Token: 0x06000299 RID: 665 RVA: 0x0001919F File Offset: 0x0001739F
		' (set) Token: 0x0600029A RID: 666 RVA: 0x000191A9 File Offset: 0x000173A9
		Friend Overridable Property grpListButton As GroupBox

		' Token: 0x170000F2 RID: 242
		' (get) Token: 0x0600029B RID: 667 RVA: 0x000191B2 File Offset: 0x000173B2
		' (set) Token: 0x0600029C RID: 668 RVA: 0x000191BC File Offset: 0x000173BC
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x170000F3 RID: 243
		' (get) Token: 0x0600029D RID: 669 RVA: 0x000191C5 File Offset: 0x000173C5
		' (set) Token: 0x0600029E RID: 670 RVA: 0x000191D0 File Offset: 0x000173D0
		Friend Overridable Property btnSearch As Button
			<CompilerGenerated()>
			Get
				Return Me._btnSearch
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnSearch_Click
				Dim button As Button = Me._btnSearch
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnSearch = value
				button = Me._btnSearch
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170000F4 RID: 244
		' (get) Token: 0x0600029F RID: 671 RVA: 0x00019213 File Offset: 0x00017413
		' (set) Token: 0x060002A0 RID: 672 RVA: 0x00019220 File Offset: 0x00017420
		Friend Overridable Property btnClearList As Button
			<CompilerGenerated()>
			Get
				Return Me._btnClearList
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnClearList_Click
				Dim button As Button = Me._btnClearList
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnClearList = value
				button = Me._btnClearList
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170000F5 RID: 245
		' (get) Token: 0x060002A1 RID: 673 RVA: 0x00019263 File Offset: 0x00017463
		' (set) Token: 0x060002A2 RID: 674 RVA: 0x00019270 File Offset: 0x00017470
		Friend Overridable Property btnExport As Button
			<CompilerGenerated()>
			Get
				Return Me._btnExport
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnExport_Click
				Dim button As Button = Me._btnExport
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnExport = value
				button = Me._btnExport
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170000F6 RID: 246
		' (get) Token: 0x060002A3 RID: 675 RVA: 0x000192B3 File Offset: 0x000174B3
		' (set) Token: 0x060002A4 RID: 676 RVA: 0x000192BD File Offset: 0x000174BD
		Friend Overridable Property lblRows As Label

		' Token: 0x170000F7 RID: 247
		' (get) Token: 0x060002A5 RID: 677 RVA: 0x000192C6 File Offset: 0x000174C6
		' (set) Token: 0x060002A6 RID: 678 RVA: 0x000192D0 File Offset: 0x000174D0
		Friend Overridable Property dgvList As DataGridView

		' Token: 0x170000F8 RID: 248
		' (get) Token: 0x060002A7 RID: 679 RVA: 0x000192D9 File Offset: 0x000174D9
		' (set) Token: 0x060002A8 RID: 680 RVA: 0x000192E3 File Offset: 0x000174E3
		Friend Overridable Property cmbSType As ComboBox

		' Token: 0x170000F9 RID: 249
		' (get) Token: 0x060002A9 RID: 681 RVA: 0x000192EC File Offset: 0x000174EC
		' (set) Token: 0x060002AA RID: 682 RVA: 0x000192F6 File Offset: 0x000174F6
		Friend Overridable Property Label7 As Label

		' Token: 0x060002AB RID: 683 RVA: 0x00019300 File Offset: 0x00017500
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.InitializeComponent()
			Me.pnlBasicDefaultHeight = Me.GbBasic.Height
			Me.pnlBasicSetHeight = 23
			Me.pnlAdvDefaultHeight = 23
			Me.pnlAdvSetHeight = Me.GbAdvanced.Height
			Me.Text = "Product BOM Report"
		End Sub

		' Token: 0x060002AC RID: 684 RVA: 0x00019380 File Offset: 0x00017580
		Private Sub SetSearchPanel()
			Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
			Me.GbBasic.Height = Me.pnlBasicDefaultHeight
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
		End Sub

		' Token: 0x060002AD RID: 685 RVA: 0x000193D4 File Offset: 0x000175D4
		Private Sub skip_btnBasicExp_sml_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.GbBasic.Height = Me.pnlBasicDefaultHeight
			If flag Then
				Me.GbBasic.Height = Me.pnlBasicSetHeight
				Me.arrow_btnBasicExp_sml.Tag = "ArrowDown"
			Else
				Me.GbBasic.Height = Me.pnlBasicDefaultHeight
				Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			End If
		End Sub

		' Token: 0x060002AE RID: 686 RVA: 0x00019444 File Offset: 0x00017644
		Private Sub skip_btnAdvanceExp_sml_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
			If flag Then
				Me.GbAdvanced.Height = Me.pnlAdvSetHeight
				Me.arrow_btnAdvanceExp_sml.Tag = "ArrowUp"
			Else
				Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
				Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
			End If
		End Sub

		' Token: 0x060002AF RID: 687 RVA: 0x000194B4 File Offset: 0x000176B4
		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x060002B0 RID: 688 RVA: 0x000194E9 File Offset: 0x000176E9
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Me.SetSearchPanel()
			Designing.SetTheme(Me)
			Me.ClearList()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x060002B1 RID: 689 RVA: 0x00019518 File Offset: 0x00017718
		Private Sub ClearList()
			Me.lblSDate.SelectedIndex = 0
			Me.txtSCode.Text = ""
			Me.txtSCatalogNo.Text = ""
			Me.txtSName.Text = ""
			Me.txtBOMVersion.Text = ""
			Me.cmbSType.Text = ""
			Me.cmbStatus.SelectedIndex = 0
			Me.dtpFrom.Value = DateAndTime.Now
			Me.dtpTo.Value = DateAndTime.Now
			Me.dtpFrom.Checked = False
			Me.dtpTo.Checked = False
			Me.lblRows.Text = "0 - Rows"
			Me.dgvList.DataSource = Nothing
		End Sub

		' Token: 0x060002B2 RID: 690 RVA: 0x000195EF File Offset: 0x000177EF
		Private Sub btnClearList_Click(sender As Object, e As EventArgs)
			Me.ClearList()
		End Sub

		' Token: 0x060002B3 RID: 691 RVA: 0x000195F9 File Offset: 0x000177F9
		Private Sub btnExport_Click(sender As Object, e As EventArgs)
			MainModule.ExportToExcel(Me.dgvList, Me.Text)
		End Sub

		' Token: 0x060002B4 RID: 692 RVA: 0x00019610 File Offset: 0x00017810
		Private Sub btnSearch_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SearchData("")
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x060002B5 RID: 693 RVA: 0x00019684 File Offset: 0x00017884
		Private Sub SearchData(sID As String)
			Dim text As String = ""
			Dim text2 As String = " SELECT P.ProductID, P.ProductCode, P.ProductName, P.ProductType, " & vbCrLf
			text2 += " B.BOMVersion, B.EffectiveDt, B.ExpiryDt, B.IsActive " & vbCrLf
			text2 += " FROM Product AS P " & vbCrLf
			text2 += " INNER JOIN ProductBOM AS B ON P.ProductID = B.ProductID " & vbCrLf
			text2 += " WHERE 1 = 1" & vbCrLf
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.txtSCode.Text), "", False) <> 0
			If flag Then
				text2 = text2 + " And (ProductCode Like '%" + Strings.Trim(Me.txtSCode.Text) + "%') "
				text = text + "ProductCode LIKE " + Strings.Trim(Me.txtSCode.Text) + vbCrLf
			End If
			Dim flag2 As Boolean = Operators.CompareString(Strings.Trim(Me.txtSCatalogNo.Text), "", False) <> 0
			If flag2 Then
				text2 = text2 + " And (CatalogNo Like '%" + Strings.Trim(Me.txtSCatalogNo.Text) + "%') "
				text = text + "CatalogNo LIKE " + Strings.Trim(Me.txtSCatalogNo.Text) + vbCrLf
			End If
			Dim flag3 As Boolean = Operators.CompareString(Strings.Trim(Me.txtSName.Text), "", False) <> 0
			If flag3 Then
				text2 = text2 + " And (ProductName Like '%" + Strings.Trim(Me.txtSName.Text) + "%') "
				text = text + "ProductName LIKE " + Strings.Trim(Me.txtSName.Text) + vbCrLf
			End If
			Dim flag4 As Boolean = Operators.CompareString(Strings.Trim(Me.cmbSType.Text), "", False) <> 0
			If flag4 Then
				text2 = text2 + " AND (ProductType = '" + Strings.Trim(Me.cmbSType.Text) + "')"
				text = text + "ProductType = " + Strings.Trim(Me.cmbSType.Text) + vbCrLf
			End If
			Dim flag5 As Boolean = Me.cmbStatus.SelectedIndex > 0
			If flag5 Then
				Dim flag6 As Boolean = Me.cmbStatus.SelectedIndex = 1
				If flag6 Then
					text2 += " AND (B.IsActive = 1)"
					text += "IsActive = 1" & vbCrLf
				Else
					text2 += " AND (B.IsActive = 0)"
					text += "IsActive = 0" & vbCrLf
				End If
			End If
			Dim flag7 As Boolean = Me.lblSDate.SelectedIndex >= 0
			If flag7 Then
				Dim flag8 As Boolean = Me.lblSDate.SelectedIndex = 0
				Dim text3 As String
				If flag8 Then
					text3 = "EffectiveDt"
				Else
					text3 = "ExpiryDt"
				End If
				Dim flag9 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
				If flag9 Then
					text2 = String.Concat(New String() { text2, " AND B.", text3, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
					text = text + String.Concat(New String() { text3, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
				Else
					Dim checked As Boolean = Me.dtpFrom.Checked
					If checked Then
						text2 = String.Concat(New String() { text2, " AND B.", text3, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59"), "'" })
						text = text + String.Concat(New String() { text3, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
					End If
					Dim checked2 As Boolean = Me.dtpTo.Checked
					If checked2 Then
						text2 = String.Concat(New String() { text2, " AND B.", text3, " BETWEEN '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
						text = text + String.Concat(New String() { text3, " BETWEEN  ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
					End If
				End If
			End If
			text2 += " ORDER BY ProductName"
			Dim data As DataTable = MainModule.GetData(text2)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = data
			Me.dgvList.Columns("ProductID").Visible = False
			Me.dgvList.Columns("ProductCode").HeaderText = "Product Code"
			Me.dgvList.Columns("ProductName").HeaderText = "Product Name"
			Me.dgvList.Columns("ProductType").HeaderText = "Product Type"
			Me.dgvList.Columns("BOMVersion").HeaderText = "BOM Version"
			Me.dgvList.Columns("EffectiveDt").HeaderText = "Effective Date"
			Me.dgvList.Columns("ExpiryDt").HeaderText = "Expiry Date"
			Me.dgvList.Columns("IsActive").HeaderText = "Is Active"
			Me.dgvList.Columns("ProductCode").Width = 140
			Me.dgvList.Columns("ProductName").Width = 350
			Me.dgvList.Columns("ProductType").Width = 130
			Me.dgvList.Columns("BOMVersion").Width = 140
			Me.dgvList.Columns("EffectiveDt").Width = 120
			Me.dgvList.Columns("ExpiryDt").Width = 120
			Me.dgvList.Columns("IsActive").Width = 70
			Me.dgvList.Columns("EffectiveDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("ExpiryDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x0400010B RID: 267
		Private pnlBasicDefaultHeight As Integer

		' Token: 0x0400010C RID: 268
		Private pnlBasicSetHeight As Integer

		' Token: 0x0400010D RID: 269
		Private pnlAdvDefaultHeight As Integer

		' Token: 0x0400010E RID: 270
		Private pnlAdvSetHeight As Integer
	End Class
End Namespace
