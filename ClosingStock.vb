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
	' Token: 0x02000014 RID: 20
	<DesignerGenerated()>
	Public Partial Class ClosingStock
		Inherits DockContent

		' Token: 0x170000FA RID: 250
		' (get) Token: 0x060002B8 RID: 696 RVA: 0x0001B224 File Offset: 0x00019424
		' (set) Token: 0x060002B9 RID: 697 RVA: 0x0001B22E File Offset: 0x0001942E
		Friend Overridable Property GbBasic As GroupBox

		' Token: 0x170000FB RID: 251
		' (get) Token: 0x060002BA RID: 698 RVA: 0x0001B237 File Offset: 0x00019437
		' (set) Token: 0x060002BB RID: 699 RVA: 0x0001B241 File Offset: 0x00019441
		Friend Overridable Property txtName As TextBox

		' Token: 0x170000FC RID: 252
		' (get) Token: 0x060002BC RID: 700 RVA: 0x0001B24A File Offset: 0x0001944A
		' (set) Token: 0x060002BD RID: 701 RVA: 0x0001B254 File Offset: 0x00019454
		Friend Overridable Property Label11 As Label

		' Token: 0x170000FD RID: 253
		' (get) Token: 0x060002BE RID: 702 RVA: 0x0001B25D File Offset: 0x0001945D
		' (set) Token: 0x060002BF RID: 703 RVA: 0x0001B267 File Offset: 0x00019467
		Friend Overridable Property txtCode As TextBox

		' Token: 0x170000FE RID: 254
		' (get) Token: 0x060002C0 RID: 704 RVA: 0x0001B270 File Offset: 0x00019470
		' (set) Token: 0x060002C1 RID: 705 RVA: 0x0001B27A File Offset: 0x0001947A
		Friend Overridable Property Label14 As Label

		' Token: 0x170000FF RID: 255
		' (get) Token: 0x060002C2 RID: 706 RVA: 0x0001B283 File Offset: 0x00019483
		' (set) Token: 0x060002C3 RID: 707 RVA: 0x0001B290 File Offset: 0x00019490
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

		' Token: 0x17000100 RID: 256
		' (get) Token: 0x060002C4 RID: 708 RVA: 0x0001B2D3 File Offset: 0x000194D3
		' (set) Token: 0x060002C5 RID: 709 RVA: 0x0001B2DD File Offset: 0x000194DD
		Friend Overridable Property cmbType As ComboBox

		' Token: 0x17000101 RID: 257
		' (get) Token: 0x060002C6 RID: 710 RVA: 0x0001B2E6 File Offset: 0x000194E6
		' (set) Token: 0x060002C7 RID: 711 RVA: 0x0001B2F0 File Offset: 0x000194F0
		Friend Overridable Property Label7 As Label

		' Token: 0x17000102 RID: 258
		' (get) Token: 0x060002C8 RID: 712 RVA: 0x0001B2F9 File Offset: 0x000194F9
		' (set) Token: 0x060002C9 RID: 713 RVA: 0x0001B303 File Offset: 0x00019503
		Friend Overridable Property dtpFrom As DateTimePicker

		' Token: 0x17000103 RID: 259
		' (get) Token: 0x060002CA RID: 714 RVA: 0x0001B30C File Offset: 0x0001950C
		' (set) Token: 0x060002CB RID: 715 RVA: 0x0001B316 File Offset: 0x00019516
		Friend Overridable Property dtpTo As DateTimePicker

		' Token: 0x17000104 RID: 260
		' (get) Token: 0x060002CC RID: 716 RVA: 0x0001B31F File Offset: 0x0001951F
		' (set) Token: 0x060002CD RID: 717 RVA: 0x0001B329 File Offset: 0x00019529
		Friend Overridable Property Label1 As Label

		' Token: 0x17000105 RID: 261
		' (get) Token: 0x060002CE RID: 718 RVA: 0x0001B332 File Offset: 0x00019532
		' (set) Token: 0x060002CF RID: 719 RVA: 0x0001B33C File Offset: 0x0001953C
		Friend Overridable Property Label3 As Label

		' Token: 0x17000106 RID: 262
		' (get) Token: 0x060002D0 RID: 720 RVA: 0x0001B345 File Offset: 0x00019545
		' (set) Token: 0x060002D1 RID: 721 RVA: 0x0001B34F File Offset: 0x0001954F
		Friend Overridable Property grpListButton As GroupBox

		' Token: 0x17000107 RID: 263
		' (get) Token: 0x060002D2 RID: 722 RVA: 0x0001B358 File Offset: 0x00019558
		' (set) Token: 0x060002D3 RID: 723 RVA: 0x0001B362 File Offset: 0x00019562
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x17000108 RID: 264
		' (get) Token: 0x060002D4 RID: 724 RVA: 0x0001B36B File Offset: 0x0001956B
		' (set) Token: 0x060002D5 RID: 725 RVA: 0x0001B378 File Offset: 0x00019578
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

		' Token: 0x17000109 RID: 265
		' (get) Token: 0x060002D6 RID: 726 RVA: 0x0001B3BB File Offset: 0x000195BB
		' (set) Token: 0x060002D7 RID: 727 RVA: 0x0001B3C8 File Offset: 0x000195C8
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

		' Token: 0x1700010A RID: 266
		' (get) Token: 0x060002D8 RID: 728 RVA: 0x0001B40B File Offset: 0x0001960B
		' (set) Token: 0x060002D9 RID: 729 RVA: 0x0001B418 File Offset: 0x00019618
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

		' Token: 0x1700010B RID: 267
		' (get) Token: 0x060002DA RID: 730 RVA: 0x0001B45B File Offset: 0x0001965B
		' (set) Token: 0x060002DB RID: 731 RVA: 0x0001B465 File Offset: 0x00019665
		Friend Overridable Property lblRows As Label

		' Token: 0x1700010C RID: 268
		' (get) Token: 0x060002DC RID: 732 RVA: 0x0001B46E File Offset: 0x0001966E
		' (set) Token: 0x060002DD RID: 733 RVA: 0x0001B478 File Offset: 0x00019678
		Friend Overridable Property dgvList As DataGridView

		' Token: 0x1700010D RID: 269
		' (get) Token: 0x060002DE RID: 734 RVA: 0x0001B481 File Offset: 0x00019681
		' (set) Token: 0x060002DF RID: 735 RVA: 0x0001B48B File Offset: 0x0001968B
		Friend Overridable Property txtCatalogNo As TextBox

		' Token: 0x1700010E RID: 270
		' (get) Token: 0x060002E0 RID: 736 RVA: 0x0001B494 File Offset: 0x00019694
		' (set) Token: 0x060002E1 RID: 737 RVA: 0x0001B49E File Offset: 0x0001969E
		Friend Overridable Property Label6 As Label

		' Token: 0x1700010F RID: 271
		' (get) Token: 0x060002E2 RID: 738 RVA: 0x0001B4A7 File Offset: 0x000196A7
		' (set) Token: 0x060002E3 RID: 739 RVA: 0x0001B4B4 File Offset: 0x000196B4
		Friend Overridable Property cmbReportType As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbReportType
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbReportType_SelectedIndexChanged
				Dim comboBox As ComboBox = Me._cmbReportType
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.SelectedIndexChanged, eventHandler
				End If
				Me._cmbReportType = value
				comboBox = Me._cmbReportType
				If comboBox IsNot Nothing Then
					AddHandler comboBox.SelectedIndexChanged, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000110 RID: 272
		' (get) Token: 0x060002E4 RID: 740 RVA: 0x0001B4F7 File Offset: 0x000196F7
		' (set) Token: 0x060002E5 RID: 741 RVA: 0x0001B501 File Offset: 0x00019701
		Friend Overridable Property Label4 As Label

		' Token: 0x17000111 RID: 273
		' (get) Token: 0x060002E6 RID: 742 RVA: 0x0001B50A File Offset: 0x0001970A
		' (set) Token: 0x060002E7 RID: 743 RVA: 0x0001B514 File Offset: 0x00019714
		Friend Overridable Property pnlDate As Panel

		' Token: 0x060002E8 RID: 744 RVA: 0x0001B520 File Offset: 0x00019720
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.InitializeComponent()
			Designing.SetTheme(Me)
			Me.pnlBasicDefaultHeight = Me.GbBasic.Height
			Me.pnlBasicSetHeight = 23
		End Sub

		' Token: 0x060002E9 RID: 745 RVA: 0x0001B582 File Offset: 0x00019782
		Private Sub SetSearchPanel()
			Me.GbBasic.Height = Me.pnlBasicDefaultHeight
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
		End Sub

		' Token: 0x060002EA RID: 746 RVA: 0x0001B5A8 File Offset: 0x000197A8
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

		' Token: 0x060002EB RID: 747 RVA: 0x0001B618 File Offset: 0x00019818
		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x060002EC RID: 748 RVA: 0x0001B64D File Offset: 0x0001984D
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Me.SetSearchPanel()
			Me.FillCombo()
			Me.ClearList()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x060002ED RID: 749 RVA: 0x0001B67C File Offset: 0x0001987C
		Private Sub FillCombo()
		End Sub

		' Token: 0x060002EE RID: 750 RVA: 0x0001B68C File Offset: 0x0001988C
		Private Sub ClearList()
			Me.txtCode.Text = ""
			Me.txtCatalogNo.Text = ""
			Me.txtName.Text = ""
			Me.cmbType.Text = ""
			Me.cmbReportType.Text = "Product-wise"
			Me.dtpFrom.Value = DateAndTime.Now
			Me.dtpTo.Value = DateAndTime.Now
			Me.dtpFrom.Checked = False
			Me.dtpTo.Checked = False
			Me.lblRows.Text = "0 - Rows"
			Me.dgvList.DataSource = Nothing
		End Sub

		' Token: 0x060002EF RID: 751 RVA: 0x0001B749 File Offset: 0x00019949
		Private Sub btnClearList_Click(sender As Object, e As EventArgs)
			Me.ClearList()
		End Sub

		' Token: 0x060002F0 RID: 752 RVA: 0x0001B753 File Offset: 0x00019953
		Private Sub btnExport_Click(sender As Object, e As EventArgs)
			MainModule.ExportToExcel(Me.dgvList, Me.Text)
		End Sub

		' Token: 0x060002F1 RID: 753 RVA: 0x0001B768 File Offset: 0x00019968
		Private Sub cmbReportType_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim text As String = Me.cmbReportType.Text
			If Operators.CompareString(text, "Product-wise", False) <> 0 AndAlso Operators.CompareString(text, "Batch-wise", False) <> 0 Then
				If Operators.CompareString(text, "Transaction-wise", False) = 0 Then
					Me.pnlDate.Visible = True
					Me.GbBasic.Height = 136
				End If
			Else
				Me.pnlDate.Visible = False
				Me.GbBasic.Height = 106
			End If
		End Sub

		' Token: 0x060002F2 RID: 754 RVA: 0x0001B7F0 File Offset: 0x000199F0
		Private Sub btnSearch_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SearchData("")
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x060002F3 RID: 755 RVA: 0x0001B864 File Offset: 0x00019A64
		Private Sub SearchData(sID As String)
			Dim text As String = ""
			Dim text2 As String = Me.cmbReportType.Text
			Dim text3 As String
			If Operators.CompareString(text2, "Product-wise", False) <> 0 Then
				If Operators.CompareString(text2, "Batch-wise", False) <> 0 Then
					If Operators.CompareString(text2, "Transaction-wise", False) = 0 Then
						Return
					End If
				Else
					text3 = " SELECT P.ProductID, ProductType, ItemGroup, ProductCode, P.CatalogNo, ProductName, PrimaryUOM, " & vbCrLf
					text3 += " GU.BatchNo LotNo, GU.MfgDt, GU.ExpDt, " & vbCrLf
					text3 += " COUNT(UID) AS AvlQty, FORMAT(AVG(GU.Price),'#0.00') AS GRNPrice, " & vbCrLf
					text3 += " FORMAT(AVG(AvgPrice),'#0.00') WeightedAvgPrice, FORMAT(COUNT(UID) * AVG(AvgPrice),'#0.00') AS Value" & vbCrLf
					text3 += " FROM GRN G " & vbCrLf
					text3 += " INNER JOIN GRNItems GI ON G.GRNID = GI.GRNID" & vbCrLf
					text3 += " INNER JOIN GRNUID GU ON GI.GRNItemsID = GU.GRNItemsID " & vbCrLf
					text3 += " INNER JOIN Product P ON GU.ProductID = P.ProductID " & vbCrLf
					text3 += " WHERE 1=1  AND (GU.Status IN ('Available'))" & vbCrLf
				End If
			Else
				text3 = " SELECT P.ProductID, ProductType, ItemGroup, ProductCode, P.CatalogNo, ProductName, PrimaryUOM, " & vbCrLf
				text3 += " COUNT(UID) AS AvlQty, FORMAT(AVG(GU.Price),'#0.00') AS GRNPrice, " & vbCrLf
				text3 += " FORMAT(AVG(AvgPrice),'#0.00') WeightedAvgPrice, FORMAT(COUNT(UID) * AVG(AvgPrice),'#0.00') AS Value" & vbCrLf
				text3 += " FROM GRN G " & vbCrLf
				text3 += " INNER JOIN GRNItems GI ON G.GRNID = GI.GRNID" & vbCrLf
				text3 += " INNER JOIN GRNUID GU ON GI.GRNItemsID = GU.GRNItemsID " & vbCrLf
				text3 += " INNER JOIN Product P ON GU.ProductID = P.ProductID " & vbCrLf
				text3 += " WHERE 1=1  AND (GU.Status IN ('Available'))" & vbCrLf
			End If
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.txtCode.Text), "", False) <> 0
			If flag Then
				text3 = text3 + " AND (ProductCode Like '%" + Strings.Trim(Me.txtCode.Text) + "%') " & vbCrLf
				text = text + "ProductCode LIKE " + Strings.Trim(Me.txtCode.Text) + vbCrLf
			End If
			Dim flag2 As Boolean = Operators.CompareString(Strings.Trim(Me.txtName.Text), "", False) <> 0
			If flag2 Then
				text3 = text3 + " AND (ProductName Like '%" + Strings.Trim(Me.txtName.Text) + "%') " & vbCrLf
				text = text + "ProductName LIKE " + Strings.Trim(Me.txtName.Text) + vbCrLf
			End If
			Dim flag3 As Boolean = Operators.CompareString(Strings.Trim(Me.cmbType.Text), "", False) <> 0
			If flag3 Then
				text3 = text3 + " AND (ProductType LIKE '%" + Strings.Trim(Me.cmbType.Text) + "%')" & vbCrLf
				text = text + "ProductType LIKE " + Strings.Trim(Me.cmbType.Text) + vbCrLf
			End If
			Dim text4 As String = Me.cmbReportType.Text
			If Operators.CompareString(text4, "Product-wise", False) <> 0 Then
				If Operators.CompareString(text4, "Batch-wise", False) <> 0 Then
					If Operators.CompareString(text4, "Transaction-wise", False) = 0 Then
						Return
					End If
				Else
					text3 += " GROUP By P.ProductID, ProductType, ItemGroup, ProductCode, P.CatalogNo, ProductName, PrimaryUOM, GU.BatchNo, GU.MfgDt, GU.ExpDt" & vbCrLf
				End If
			Else
				text3 += " GROUP By P.ProductID, ProductType, ItemGroup, ProductCode, P.CatalogNo, ProductName, PrimaryUOM" & vbCrLf
			End If
			text3 += " ORDER BY ProductType, ProductCode, ProductName " & vbCrLf
			Dim data As DataTable = MainModule.GetData(text3)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = Nothing
			Me.dgvList.DataSource = data
			Me.dgvList.Columns("ProductID").Visible = False
			Me.dgvList.Columns("ProductCode").HeaderText = "Product Code"
			Me.dgvList.Columns("ProductName").HeaderText = "Product Name"
			Me.dgvList.Columns("ProductType").HeaderText = "Product Type"
			Me.dgvList.Columns("CatalogNo").HeaderText = "Catalog No."
			Me.dgvList.Columns("ProductCode").Width = 150
			Me.dgvList.Columns("ProductName").Width = 350
			Me.dgvList.Columns("ProductType").Width = 130
			Me.dgvList.Columns("CatalogNo").Width = 140
			Dim flag4 As Boolean = Me.dgvList.Columns.Contains("MfgDt")
			If flag4 Then
				Me.dgvList.Columns("MfgDt").HeaderText = "Mfg. Date"
				Me.dgvList.Columns("MfgDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
				Me.dgvList.Columns("MfgDt").Width = 120
			End If
			Dim flag5 As Boolean = Me.dgvList.Columns.Contains("ExpDt")
			If flag5 Then
				Me.dgvList.Columns("ExpDt").HeaderText = "Expiry Date"
				Me.dgvList.Columns("ExpDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
				Me.dgvList.Columns("ExpDt").Width = 120
			End If
			Dim flag6 As Boolean = Me.dgvList.Columns.Contains("PrimaryUOM")
			If flag6 Then
				Me.dgvList.Columns("PrimaryUOM").HeaderText = "Primary UOM"
			End If
			Dim flag7 As Boolean = Me.dgvList.Columns.Contains("AvlQty")
			If flag7 Then
				Me.dgvList.Columns("GRNPrice").Visible = False
				Me.dgvList.Columns("AvlQty").HeaderText = "Available Qty."
				Me.dgvList.Columns("GRNPrice").HeaderText = "Batch Avg. Price"
				Me.dgvList.Columns("WeightedAvgPrice").HeaderText = "Weighted Avg. Price"
				Me.dgvList.Columns("Value").HeaderText = "Weighted Avg. Value"
				Me.dgvList.Columns("AvlQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("GRNPrice").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("WeightedAvgPrice").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("Value").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
		End Sub

		' Token: 0x04000128 RID: 296
		Private pnlBasicDefaultHeight As Integer

		' Token: 0x04000129 RID: 297
		Private pnlBasicSetHeight As Integer

		' Token: 0x0400012A RID: 298
		Private pnlAdvDefaultHeight As Integer

		' Token: 0x0400012B RID: 299
		Private pnlAdvSetHeight As Integer
	End Class
End Namespace
