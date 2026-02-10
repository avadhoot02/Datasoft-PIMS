Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x02000050 RID: 80
	<DesignerGenerated()>
	Public Partial Class DashboardTest
		Inherits Form

		' Token: 0x06000E3D RID: 3645 RVA: 0x0008045D File Offset: 0x0007E65D
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.DashboardTest_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000551 RID: 1361
		' (get) Token: 0x06000E40 RID: 3648 RVA: 0x0008141B File Offset: 0x0007F61B
		' (set) Token: 0x06000E41 RID: 3649 RVA: 0x00081428 File Offset: 0x0007F628
		Friend Overridable Property btnGen As Button
			<CompilerGenerated()>
			Get
				Return Me._btnGen
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnGen_Click
				Dim button As Button = Me._btnGen
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnGen = value
				button = Me._btnGen
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000552 RID: 1362
		' (get) Token: 0x06000E42 RID: 3650 RVA: 0x0008146B File Offset: 0x0007F66B
		' (set) Token: 0x06000E43 RID: 3651 RVA: 0x00081475 File Offset: 0x0007F675
		Friend Overridable Property TableLayoutPanel1 As TableLayoutPanel

		' Token: 0x17000553 RID: 1363
		' (get) Token: 0x06000E44 RID: 3652 RVA: 0x0008147E File Offset: 0x0007F67E
		' (set) Token: 0x06000E45 RID: 3653 RVA: 0x00081488 File Offset: 0x0007F688
		Friend Overridable Property ChartPO As Chart

		' Token: 0x17000554 RID: 1364
		' (get) Token: 0x06000E46 RID: 3654 RVA: 0x00081491 File Offset: 0x0007F691
		' (set) Token: 0x06000E47 RID: 3655 RVA: 0x0008149B File Offset: 0x0007F69B
		Friend Overridable Property ChartPOStatus As Chart

		' Token: 0x17000555 RID: 1365
		' (get) Token: 0x06000E48 RID: 3656 RVA: 0x000814A4 File Offset: 0x0007F6A4
		' (set) Token: 0x06000E49 RID: 3657 RVA: 0x000814AE File Offset: 0x0007F6AE
		Friend Overridable Property Chart2 As Chart

		' Token: 0x17000556 RID: 1366
		' (get) Token: 0x06000E4A RID: 3658 RVA: 0x000814B7 File Offset: 0x0007F6B7
		' (set) Token: 0x06000E4B RID: 3659 RVA: 0x000814C1 File Offset: 0x0007F6C1
		Friend Overridable Property Panel1 As Panel

		' Token: 0x17000557 RID: 1367
		' (get) Token: 0x06000E4C RID: 3660 RVA: 0x000814CA File Offset: 0x0007F6CA
		' (set) Token: 0x06000E4D RID: 3661 RVA: 0x000814D4 File Offset: 0x0007F6D4
		Friend Overridable Property Chart1 As Chart

		' Token: 0x06000E4E RID: 3662 RVA: 0x000814DD File Offset: 0x0007F6DD
		Private Sub DashboardTest_Load(sender As Object, e As EventArgs)
			Me.SetMonths()
		End Sub

		' Token: 0x06000E4F RID: 3663 RVA: 0x000814E8 File Offset: 0x0007F6E8
		Private Sub SetMonths()
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("Mon")
			dataTable.Rows.Add(New Object(-1) {})
			dataTable.Rows(dataTable.Rows.Count - 1)("Mon") = "Apr"
			dataTable.Rows.Add(New Object(-1) {})
			dataTable.Rows(dataTable.Rows.Count - 1)("Mon") = "May"
			dataTable.Rows.Add(New Object(-1) {})
			dataTable.Rows(dataTable.Rows.Count - 1)("Mon") = "Jun"
			dataTable.Rows.Add(New Object(-1) {})
			dataTable.Rows(dataTable.Rows.Count - 1)("Mon") = "Jul"
			dataTable.Rows.Add(New Object(-1) {})
			dataTable.Rows(dataTable.Rows.Count - 1)("Mon") = "Aug"
			dataTable.Rows.Add(New Object(-1) {})
			dataTable.Rows(dataTable.Rows.Count - 1)("Mon") = "Sep"
			dataTable.Rows.Add(New Object(-1) {})
			dataTable.Rows(dataTable.Rows.Count - 1)("Mon") = "Oct"
			dataTable.Rows.Add(New Object(-1) {})
			dataTable.Rows(dataTable.Rows.Count - 1)("Mon") = "Nov"
			dataTable.Rows.Add(New Object(-1) {})
			dataTable.Rows(dataTable.Rows.Count - 1)("Mon") = "Dec"
			dataTable.Rows.Add(New Object(-1) {})
			dataTable.Rows(dataTable.Rows.Count - 1)("Mon") = "Jan"
			dataTable.Rows.Add(New Object(-1) {})
			dataTable.Rows(dataTable.Rows.Count - 1)("Mon") = "Feb"
			dataTable.Rows.Add(New Object(-1) {})
			dataTable.Rows(dataTable.Rows.Count - 1)("Mon") = "Mar"
			Me.dtMonth = dataTable
		End Sub

		' Token: 0x06000E50 RID: 3664 RVA: 0x000817CC File Offset: 0x0007F9CC
		Private Sub btnGen_Click(sender As Object, e As EventArgs)
			Dim dateTime As DateTime = Conversions.ToDate("15/Dec/2024")
			Me.PO_This_Year(dateTime)
			Me.PO_This_Year_Status(dateTime)
		End Sub

		' Token: 0x06000E51 RID: 3665 RVA: 0x000817F8 File Offset: 0x0007F9F8
		Private Sub PO_This_Year(dCheckDt As DateTime)
			Dim flag As Boolean = dCheckDt.Month > 3
			Dim dateTime As DateTime
			Dim dateTime2 As DateTime
			If flag Then
				dateTime = Conversions.ToDate("01-Apr-" + Strings.Format(dCheckDt.Year, "#0000"))
				dateTime2 = Conversions.ToDate("31-Mar-" + Strings.Format(dCheckDt.Year + 1, "#0000"))
			Else
				dateTime = Conversions.ToDate("01-Apr-" + Strings.Format(dCheckDt.Year - 1, "#0000"))
				dateTime2 = Conversions.ToDate("31-Mar-" + Strings.Format(dCheckDt.Year, "#0000"))
			End If
			Dim text As String = " SELECT FORMAT(PODt,'MMM') AS Mon, COUNT(POID) AS Cnt " & vbCrLf
			text += " FROM PO " & vbCrLf
			text += " WHERE 1=1 " & vbCrLf
			text = String.Concat(New String() { text, " AND PODt BETWEEN '", Strings.Format(dateTime, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(dateTime2, "MM/dd/yyyy 23:59:59"), "'" & vbCrLf })
			text += " AND Status NOT IN ('Amended')" & vbCrLf
			text += " GROUP BY FORMAT(PODt,'MMM')" & vbCrLf
			Dim data As DataTable = MainModule.GetData(text)
			Dim num As Long = CLng(Convert.ToInt32(RuntimeHelpers.GetObjectValue(data.Compute("SUM(Cnt)", String.Empty))))
			Me.ChartPO.Titles("Title1").Text = String.Concat(New String() { "PO  Created  In  Year ", Strings.Format(dateTime, "yy"), "-", Strings.Format(dateTime2, "yy"), ": ", Conversions.ToString(num) })
			Me.ChartPO.Series("No. Of PO").Points.Clear()
			Dim num2 As Integer = Me.dtMonth.Rows.Count - 1
			For i As Integer = 0 To num2
				Dim array As DataRow() = data.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Mon = '", Me.dtMonth.Rows(i)("Mon")), "'")))
				Dim flag2 As Boolean = array.Length > 0
				If flag2 Then
					Me.ChartPO.Series("No. Of PO").Points.AddXY(RuntimeHelpers.GetObjectValue(Me.dtMonth.Rows(i)("Mon")), New Object() { array(0)("Cnt") })
				Else
					Me.ChartPO.Series("No. Of PO").Points.AddXY(RuntimeHelpers.GetObjectValue(Me.dtMonth.Rows(i)("Mon")), New Object() { 0 })
				End If
			Next
		End Sub

		' Token: 0x06000E52 RID: 3666 RVA: 0x00081B14 File Offset: 0x0007FD14
		Private Sub PO_This_Year_Status(dCheckDt As DateTime)
			Dim flag As Boolean = dCheckDt.Month > 3
			Dim dateTime As DateTime
			Dim dateTime2 As DateTime
			If flag Then
				dateTime = Conversions.ToDate("01-Apr-" + Strings.Format(dCheckDt.Year, "#0000"))
				dateTime2 = Conversions.ToDate("31-Mar-" + Strings.Format(dCheckDt.Year + 1, "#0000"))
			Else
				dateTime = Conversions.ToDate("01-Apr-" + Strings.Format(dCheckDt.Year - 1, "#0000"))
				dateTime2 = Conversions.ToDate("31-Mar-" + Strings.Format(dCheckDt.Year, "#0000"))
			End If
			Dim text As String = " SELECT " & vbCrLf
			text += " SUM (CASE WHEN Status = 'In Approval' THEN 1 ELSE 0 END) AS InApproval," & vbCrLf
			text += " SUM (CASE WHEN Status = 'On-Hold' THEN 1 ELSE 0 END) AS OnHold," & vbCrLf
			text += " SUM (CASE WHEN Status = 'GRN Complete' THEN 1 ELSE 0 END) AS Closed" & vbCrLf
			text += " FROM zPO " & vbCrLf
			text += " WHERE 1=1 " & vbCrLf
			text = String.Concat(New String() { text, " AND PODt BETWEEN '", Strings.Format(dateTime, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(dateTime2, "MM/dd/yyyy 23:59:59"), "'" & vbCrLf })
			Dim data As DataTable = MainModule.GetData(text)
			Me.ChartPOStatus.Titles("Title1").Text = "PO  Status  In  Year " + Strings.Format(dateTime, "yy") + "-" + Strings.Format(dateTime2, "yy")
			Me.ChartPOStatus.Series("Status").Points.Clear()
			Me.ChartPOStatus.Series("Status").Points.AddXY("In Approval", New Object() { data.Rows(0)("InApproval") })
			Me.ChartPOStatus.Series("Status").Points.AddXY("On-Hold", New Object() { data.Rows(0)("OnHold") })
			Me.ChartPOStatus.Series("Status").Points.AddXY("Closed", New Object() { data.Rows(0)("Closed") })
		End Sub

		' Token: 0x040005E6 RID: 1510
		Private dtMonth As DataTable
	End Class
End Namespace
