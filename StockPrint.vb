Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports WeifenLuo.WinFormsUI.Docking

Namespace Datasoft_PIMS
	' Token: 0x02000028 RID: 40
	<DesignerGenerated()>
	Public Partial Class StockPrint
		Inherits DockContent

		' Token: 0x17000402 RID: 1026
		' (get) Token: 0x06000A82 RID: 2690 RVA: 0x000614CC File Offset: 0x0005F6CC
		' (set) Token: 0x06000A83 RID: 2691 RVA: 0x000614D6 File Offset: 0x0005F6D6
		Friend Overridable Property GbBasic As GroupBox

		' Token: 0x17000403 RID: 1027
		' (get) Token: 0x06000A84 RID: 2692 RVA: 0x000614DF File Offset: 0x0005F6DF
		' (set) Token: 0x06000A85 RID: 2693 RVA: 0x000614EC File Offset: 0x0005F6EC
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

		' Token: 0x17000404 RID: 1028
		' (get) Token: 0x06000A86 RID: 2694 RVA: 0x0006152F File Offset: 0x0005F72F
		' (set) Token: 0x06000A87 RID: 2695 RVA: 0x00061539 File Offset: 0x0005F739
		Friend Overridable Property grpListButton As GroupBox

		' Token: 0x17000405 RID: 1029
		' (get) Token: 0x06000A88 RID: 2696 RVA: 0x00061542 File Offset: 0x0005F742
		' (set) Token: 0x06000A89 RID: 2697 RVA: 0x0006154C File Offset: 0x0005F74C
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x17000406 RID: 1030
		' (get) Token: 0x06000A8A RID: 2698 RVA: 0x00061555 File Offset: 0x0005F755
		' (set) Token: 0x06000A8B RID: 2699 RVA: 0x00061560 File Offset: 0x0005F760
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

		' Token: 0x17000407 RID: 1031
		' (get) Token: 0x06000A8C RID: 2700 RVA: 0x000615A3 File Offset: 0x0005F7A3
		' (set) Token: 0x06000A8D RID: 2701 RVA: 0x000615B0 File Offset: 0x0005F7B0
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

		' Token: 0x17000408 RID: 1032
		' (get) Token: 0x06000A8E RID: 2702 RVA: 0x000615F3 File Offset: 0x0005F7F3
		' (set) Token: 0x06000A8F RID: 2703 RVA: 0x000615FD File Offset: 0x0005F7FD
		Friend Overridable Property lblRows As Label

		' Token: 0x17000409 RID: 1033
		' (get) Token: 0x06000A90 RID: 2704 RVA: 0x00061606 File Offset: 0x0005F806
		' (set) Token: 0x06000A91 RID: 2705 RVA: 0x00061610 File Offset: 0x0005F810
		Friend Overridable Property cmbDepartment As ComboBox

		' Token: 0x1700040A RID: 1034
		' (get) Token: 0x06000A92 RID: 2706 RVA: 0x00061619 File Offset: 0x0005F819
		' (set) Token: 0x06000A93 RID: 2707 RVA: 0x00061623 File Offset: 0x0005F823
		Friend Overridable Property lblDepartment As Label

		' Token: 0x1700040B RID: 1035
		' (get) Token: 0x06000A94 RID: 2708 RVA: 0x0006162C File Offset: 0x0005F82C
		' (set) Token: 0x06000A95 RID: 2709 RVA: 0x00061636 File Offset: 0x0005F836
		Friend Overridable Property cmbItemGroup As ComboBox

		' Token: 0x1700040C RID: 1036
		' (get) Token: 0x06000A96 RID: 2710 RVA: 0x0006163F File Offset: 0x0005F83F
		' (set) Token: 0x06000A97 RID: 2711 RVA: 0x00061649 File Offset: 0x0005F849
		Friend Overridable Property Label9 As Label

		' Token: 0x1700040D RID: 1037
		' (get) Token: 0x06000A98 RID: 2712 RVA: 0x00061652 File Offset: 0x0005F852
		' (set) Token: 0x06000A99 RID: 2713 RVA: 0x0006165C File Offset: 0x0005F85C
		Friend Overridable Property Label1 As Label

		' Token: 0x1700040E RID: 1038
		' (get) Token: 0x06000A9A RID: 2714 RVA: 0x00061665 File Offset: 0x0005F865
		' (set) Token: 0x06000A9B RID: 2715 RVA: 0x0006166F File Offset: 0x0005F86F
		Friend Overridable Property dtpTo As DateTimePicker

		' Token: 0x1700040F RID: 1039
		' (get) Token: 0x06000A9C RID: 2716 RVA: 0x00061678 File Offset: 0x0005F878
		' (set) Token: 0x06000A9D RID: 2717 RVA: 0x00061682 File Offset: 0x0005F882
		Friend Overridable Property Label16 As Label

		' Token: 0x17000410 RID: 1040
		' (get) Token: 0x06000A9E RID: 2718 RVA: 0x0006168B File Offset: 0x0005F88B
		' (set) Token: 0x06000A9F RID: 2719 RVA: 0x00061695 File Offset: 0x0005F895
		Friend Overridable Property dtpFrom As DateTimePicker

		' Token: 0x17000411 RID: 1041
		' (get) Token: 0x06000AA0 RID: 2720 RVA: 0x0006169E File Offset: 0x0005F89E
		' (set) Token: 0x06000AA1 RID: 2721 RVA: 0x000616A8 File Offset: 0x0005F8A8
		Friend Overridable Property CrystalReportViewer1 As CrystalReportViewer

		' Token: 0x06000AA2 RID: 2722 RVA: 0x000616B4 File Offset: 0x0005F8B4
		Public Sub New(sType As String)
			AddHandler MyBase.FormClosing, AddressOf Me.StockPrint_FormClosing
			AddHandler MyBase.Load, AddressOf Me.StockPrint_Load
			Me.InitializeComponent()
			Designing.SetTheme(Me)
			Me.sFormType = sType
			Me.Text = Me.sFormType
			MyBase.TabText = Me.sFormType
			Dim flag As Boolean = Operators.CompareString(Me.sFormType, "Consumption Report", False) <> 0
			If flag Then
				Me.lblDepartment.Visible = False
				Me.cmbDepartment.Visible = False
				Me.GbBasic.Height = 82
			End If
			Me.pnlBasicDefaultHeight = Me.GbBasic.Height
			Me.pnlBasicSetHeight = 23
		End Sub

		' Token: 0x06000AA3 RID: 2723 RVA: 0x00061779 File Offset: 0x0005F979
		Private Sub SetSearchPanel()
			Me.GbBasic.Height = Me.pnlBasicDefaultHeight
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
		End Sub

		' Token: 0x06000AA4 RID: 2724 RVA: 0x000617A0 File Offset: 0x0005F9A0
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

		' Token: 0x06000AA5 RID: 2725 RVA: 0x00061810 File Offset: 0x0005FA10
		Private Sub StockPrint_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x06000AA6 RID: 2726 RVA: 0x00061845 File Offset: 0x0005FA45
		Private Sub StockPrint_Load(sender As Object, e As EventArgs)
			Me.SetSearchPanel()
			Me.FillCombo()
			Me.ClearList()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x06000AA7 RID: 2727 RVA: 0x00061874 File Offset: 0x0005FA74
		Private Sub FillCombo()
			Dim text As String = "SELECT DISTINCT ItemGroup FROM Product ORDER BY ItemGroup"
			Dim data As DataTable = MainModule.GetData(text)
			Me.cmbItemGroup.ValueMember = "ItemGroup"
			Me.cmbItemGroup.DisplayMember = "ItemGroup"
			Me.cmbItemGroup.DataSource = data
			Me.cmbItemGroup.SelectedIndex = -1
			text = "SELECT DISTINCT Department FROM Request ORDER BY Department"
			Dim data2 As DataTable = MainModule.GetData(text)
			Me.cmbDepartment.ValueMember = "Department"
			Me.cmbDepartment.DisplayMember = "Department"
			Me.cmbDepartment.DataSource = data2
			Me.cmbDepartment.SelectedIndex = -1
		End Sub

		' Token: 0x06000AA8 RID: 2728 RVA: 0x00061914 File Offset: 0x0005FB14
		Private Sub ClearList()
			Me.dtpFrom.Checked = True
			Me.dtpTo.Checked = True
			Me.dtpFrom.Value = Conversions.ToDate("01/" + Strings.Format(DateAndTime.Now, "MMM/yyyy"))
			Me.dtpTo.Value = DateAndTime.DateAdd(DateInterval.Day, -1.0, DateAndTime.DateAdd(DateInterval.Month, 1.0, Me.dtpFrom.Value))
			Me.cmbItemGroup.Text = ""
			Me.cmbDepartment.Text = ""
			Me.lblRows.Text = "0 - Rows"
			Me.CrystalReportViewer1.ReportSource = Nothing
		End Sub

		' Token: 0x06000AA9 RID: 2729 RVA: 0x000619E0 File Offset: 0x0005FBE0
		Private Sub btnClearList_Click(sender As Object, e As EventArgs)
			Me.ClearList()
		End Sub

		' Token: 0x06000AAA RID: 2730 RVA: 0x000619EC File Offset: 0x0005FBEC
		Private Sub btnSearch_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SearchData()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06000AAB RID: 2731 RVA: 0x00061A58 File Offset: 0x0005FC58
		Private Sub SearchData()
			Dim text As String = Me.sFormType
			If Operators.CompareString(text, "Consumption Report", False) <> 0 Then
				If Operators.CompareString(text, "Closing Stock Report", False) <> 0 Then
					If Operators.CompareString(text, "Quarentine Stock Report", False) = 0 Then
						Me.QuarantineStockReport()
					End If
				Else
					Me.ClosingStockReport()
				End If
			Else
				Me.ConsumptionReport()
			End If
		End Sub

		' Token: 0x06000AAC RID: 2732 RVA: 0x00061ABC File Offset: 0x0005FCBC
		Private Sub ConsumptionReport()
			Dim text As String = ""
			Dim text2 As String = " SELECT R.Department, '" + Strings.Format(Me.dtpFrom.Value, "dd-MMM-yyyy") + "' AS StartDt, " & vbCrLf
			text2 = text2 + " '" + Strings.Format(Me.dtpTo.Value, "dd-MMM-yyyy") + "' AS EndDt, " & vbCrLf
			text2 += " P.ItemGroup AS ProductType, P.ProductName, U.BatchNo, U.ExpDt,  " & vbCrLf
			text2 += " COUNT(ID.UID) AS Quantity, U.Price AS Rate, COUNT(ID.UID) * U.Price AS Value " & vbCrLf
			text2 += " FROM Issue AS I  " & vbCrLf
			text2 += " INNER JOIN IssueDtls AS ID ON I.IssueID = ID.IssueID " & vbCrLf
			text2 += " INNER JOIN Product AS P ON ID.ProductID = P.ProductID " & vbCrLf
			text2 += " INNER JOIN GRNUID AS U ON ID.UID = U.UID " & vbCrLf
			text2 += " INNER JOIN Request AS R ON I.RequestID = R.RequestID  " & vbCrLf
			text2 += " WHERE P.IsGRNApplicable = 1 " & vbCrLf
			text2 = String.Concat(New String() { text2, " AND I.IssuedDt BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "' " & vbCrLf })
			text = text + ("Issue Date BETWEEN  " + Strings.Format(Me.dtpFrom.Value, "dd-MMM-yyyy") + " AND " + Strings.Format(Me.dtpTo.Value, "dd-MMM-yyyy")) + vbCrLf
			Dim flag As Boolean = Operators.CompareString(Me.cmbItemGroup.Text, "", False) <> 0
			If flag Then
				text2 = text2 + " AND P.ItemGroup = '" + Me.cmbItemGroup.Text + "' " & vbCrLf
				text = text + "ItemGroup = " + Me.cmbItemGroup.Text + " " & vbCrLf
			End If
			Dim flag2 As Boolean = Operators.CompareString(Me.cmbDepartment.Text, "", False) <> 0
			If flag2 Then
				text2 = text2 + " AND R.Department = '" + Me.cmbDepartment.Text + "' " & vbCrLf
				text = text + "Department = " + Me.cmbDepartment.Text + " " & vbCrLf
			End If
			text2 += " GROUP BY R.Department, P.ItemGroup, P.ProductName, U.BatchNo, U.ExpDt, U.Price " & vbCrLf
			text2 += " ORDER BY R.Department, P.ItemGroup, P.ProductName, U.BatchNo " & vbCrLf
			Dim data As DataTable = MainModule.GetData(text2)
			Dim flag3 As Boolean = data.Rows.Count > 0
			If flag3 Then
				Dim reportDocument As ReportDocument = New ReportDocument()
				reportDocument = New rptConsumption()
				reportDocument.SetDataSource(data)
				Me.CrystalReportViewer1.ReportSource = reportDocument
			Else
				Me.CrystalReportViewer1.ReportSource = Nothing
			End If
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x06000AAD RID: 2733 RVA: 0x00061D70 File Offset: 0x0005FF70
		Private Sub ClosingStockReport()
			Dim text As String = ""
			Dim text2 As String = " SELECT '" + Strings.Format(Me.dtpFrom.Value, "dd-MMM-yyyy") + "' AS StartDt, " & vbCrLf
			text2 = text2 + " '" + Strings.Format(Me.dtpTo.Value, "dd-MMM-yyyy") + "' AS EndDt, " & vbCrLf
			text2 += " P.ItemGroup AS ProductType, P.ProductName, U.BatchNo, U.ExpDt, U.Price AS Rate, " & vbCrLf
			text2 += " SUM(CASE WHEN ISNULL(U.ExpDt,'01/01/2050') > GETDATE() AND U.Status = 'Available' THEN 1 ELSE 0 END) AS Quantity, " & vbCrLf
			text2 += " SUM(CASE WHEN ISNULL(U.ExpDt,'01/01/2050') > GETDATE() AND U.Status = 'Available' THEN 1 ELSE 0 END) * U.Price AS Value " & vbCrLf
			text2 += " FROM GRNUID AS U " & vbCrLf
			text2 += " INNER JOIN Product AS P ON U.ProductID = P.ProductID " & vbCrLf
			text2 += " WHERE P.IsGRNApplicable = 1 " & vbCrLf
			text2 = String.Concat(New String() { text2, " AND U.CreationDt BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "' " & vbCrLf })
			text = text + ("Stock Date BETWEEN  " + Strings.Format(Me.dtpFrom.Value, "dd-MMM-yyyy") + " AND " + Strings.Format(Me.dtpTo.Value, "dd-MMM-yyyy")) + vbCrLf
			Dim flag As Boolean = Operators.CompareString(Me.cmbItemGroup.Text, "", False) <> 0
			If flag Then
				text2 = text2 + " AND P.ItemGroup = '" + Me.cmbItemGroup.Text + "' " & vbCrLf
				text = text + "ItemGroup = " + Me.cmbItemGroup.Text + " " & vbCrLf
			End If
			text2 += " GROUP BY P.ItemGroup, P.ProductName, U.BatchNo, U.ExpDt, U.Price " & vbCrLf
			text2 += " ORDER BY P.ItemGroup, P.ProductName, U.BatchNo " & vbCrLf
			Dim data As DataTable = MainModule.GetData(text2)
			Dim flag2 As Boolean = data.Rows.Count > 0
			If flag2 Then
				Dim reportDocument As ReportDocument = New ReportDocument()
				reportDocument = New rptClosingStock()
				reportDocument.SetDataSource(data)
				Me.CrystalReportViewer1.ReportSource = reportDocument
			Else
				Me.CrystalReportViewer1.ReportSource = Nothing
			End If
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x06000AAE RID: 2734 RVA: 0x00061FB0 File Offset: 0x000601B0
		Private Sub QuarantineStockReport()
			Dim text As String = ""
			Dim text2 As String = " SELECT '" + Strings.Format(Me.dtpFrom.Value, "dd-MMM-yyyy") + "' AS StartDt, " & vbCrLf
			text2 = text2 + " '" + Strings.Format(Me.dtpTo.Value, "dd-MMM-yyyy") + "' AS EndDt, " & vbCrLf
			text2 += " P.ItemGroup AS ProductType, P.ProductName, U.BatchNo, U.ExpDt,  " & vbCrLf
			text2 += " COUNT(U.UID) AS Quantity, U.Price AS Rate, COUNT(U.UID) * U.Price AS Value " & vbCrLf
			text2 += " FROM GRNUID AS U" & vbCrLf
			text2 += " INNER JOIN Product AS P ON U.ProductID = P.ProductID " & vbCrLf
			text2 += " WHERE P.IsGRNApplicable = 1 AND U.Status = 'Created'" & vbCrLf
			text2 = String.Concat(New String() { text2, " AND U.CreationDt BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "' " & vbCrLf })
			text = text + ("Stock Date BETWEEN  " + Strings.Format(Me.dtpFrom.Value, "dd-MMM-yyyy") + " AND " + Strings.Format(Me.dtpTo.Value, "dd-MMM-yyyy")) + vbCrLf
			Dim flag As Boolean = Operators.CompareString(Me.cmbItemGroup.Text, "", False) <> 0
			If flag Then
				text2 = text2 + " AND P.ItemGroup = '" + Me.cmbItemGroup.Text + "' " & vbCrLf
				text = text + "ItemGroup = " + Me.cmbItemGroup.Text + " " & vbCrLf
			End If
			text2 += " GROUP BY P.ItemGroup, P.ProductName, U.BatchNo, U.ExpDt, U.Price " & vbCrLf
			text2 += " ORDER BY P.ItemGroup, P.ProductName, U.BatchNo " & vbCrLf
			Dim data As DataTable = MainModule.GetData(text2)
			Dim flag2 As Boolean = data.Rows.Count > 0
			If flag2 Then
				Dim reportDocument As ReportDocument = New ReportDocument()
				reportDocument = New rptQuarantineStock()
				reportDocument.SetDataSource(data)
				Me.CrystalReportViewer1.ReportSource = reportDocument
			Else
				Me.CrystalReportViewer1.ReportSource = Nothing
			End If
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x0400047A RID: 1146
		Private sFormType As String

		' Token: 0x0400047B RID: 1147
		Private pnlBasicDefaultHeight As Integer

		' Token: 0x0400047C RID: 1148
		Private pnlBasicSetHeight As Integer
	End Class
End Namespace
