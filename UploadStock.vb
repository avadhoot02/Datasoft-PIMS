Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports WeifenLuo.WinFormsUI.Docking

Namespace Datasoft_PIMS
	' Token: 0x02000054 RID: 84
	<DesignerGenerated()>
	Public Partial Class UploadStock
		Inherits DockContent

		' Token: 0x06000F94 RID: 3988 RVA: 0x0008DA60 File Offset: 0x0008BC60
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			AddHandler MyBase.Shown, AddressOf Me.UploadStock_Shown
			Me.InitializeComponent()
		End Sub

		' Token: 0x170005DB RID: 1499
		' (get) Token: 0x06000F97 RID: 3991 RVA: 0x0008E96C File Offset: 0x0008CB6C
		' (set) Token: 0x06000F98 RID: 3992 RVA: 0x0008E978 File Offset: 0x0008CB78
		Friend Overridable Property btnStock As Button
			<CompilerGenerated()>
			Get
				Return Me._btnStock
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnStock_Click
				Dim button As Button = Me._btnStock
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnStock = value
				button = Me._btnStock
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170005DC RID: 1500
		' (get) Token: 0x06000F99 RID: 3993 RVA: 0x0008E9BB File Offset: 0x0008CBBB
		' (set) Token: 0x06000F9A RID: 3994 RVA: 0x0008E9C5 File Offset: 0x0008CBC5
		Friend Overridable Property theme_tc As TabControl

		' Token: 0x170005DD RID: 1501
		' (get) Token: 0x06000F9B RID: 3995 RVA: 0x0008E9CE File Offset: 0x0008CBCE
		' (set) Token: 0x06000F9C RID: 3996 RVA: 0x0008E9D8 File Offset: 0x0008CBD8
		Friend Overridable Property tpDetails As TabPage

		' Token: 0x170005DE RID: 1502
		' (get) Token: 0x06000F9D RID: 3997 RVA: 0x0008E9E1 File Offset: 0x0008CBE1
		' (set) Token: 0x06000F9E RID: 3998 RVA: 0x0008E9EB File Offset: 0x0008CBEB
		Friend Overridable Property Panel1 As Panel

		' Token: 0x170005DF RID: 1503
		' (get) Token: 0x06000F9F RID: 3999 RVA: 0x0008E9F4 File Offset: 0x0008CBF4
		' (set) Token: 0x06000FA0 RID: 4000 RVA: 0x0008E9FE File Offset: 0x0008CBFE
		Friend Overridable Property lblRowsG As Label

		' Token: 0x170005E0 RID: 1504
		' (get) Token: 0x06000FA1 RID: 4001 RVA: 0x0008EA07 File Offset: 0x0008CC07
		' (set) Token: 0x06000FA2 RID: 4002 RVA: 0x0008EA11 File Offset: 0x0008CC11
		Friend Overridable Property tab_lbl1 As Label

		' Token: 0x170005E1 RID: 1505
		' (get) Token: 0x06000FA3 RID: 4003 RVA: 0x0008EA1A File Offset: 0x0008CC1A
		' (set) Token: 0x06000FA4 RID: 4004 RVA: 0x0008EA24 File Offset: 0x0008CC24
		Friend Overridable Property tpList As TabPage

		' Token: 0x170005E2 RID: 1506
		' (get) Token: 0x06000FA5 RID: 4005 RVA: 0x0008EA2D File Offset: 0x0008CC2D
		' (set) Token: 0x06000FA6 RID: 4006 RVA: 0x0008EA37 File Offset: 0x0008CC37
		Friend Overridable Property tab_lbl2 As Label

		' Token: 0x170005E3 RID: 1507
		' (get) Token: 0x06000FA7 RID: 4007 RVA: 0x0008EA40 File Offset: 0x0008CC40
		' (set) Token: 0x06000FA8 RID: 4008 RVA: 0x0008EA4A File Offset: 0x0008CC4A
		Friend Overridable Property dgvList As DataGridView

		' Token: 0x170005E4 RID: 1508
		' (get) Token: 0x06000FA9 RID: 4009 RVA: 0x0008EA53 File Offset: 0x0008CC53
		' (set) Token: 0x06000FAA RID: 4010 RVA: 0x0008EA5D File Offset: 0x0008CC5D
		Friend Overridable Property lblRows As Label

		' Token: 0x170005E5 RID: 1509
		' (get) Token: 0x06000FAB RID: 4011 RVA: 0x0008EA66 File Offset: 0x0008CC66
		' (set) Token: 0x06000FAC RID: 4012 RVA: 0x0008EA70 File Offset: 0x0008CC70
		Friend Overridable Property Panel2 As Panel

		' Token: 0x170005E6 RID: 1510
		' (get) Token: 0x06000FAD RID: 4013 RVA: 0x0008EA79 File Offset: 0x0008CC79
		' (set) Token: 0x06000FAE RID: 4014 RVA: 0x0008EA83 File Offset: 0x0008CC83
		Friend Overridable Property dgvGRN As DataGridView

		' Token: 0x170005E7 RID: 1511
		' (get) Token: 0x06000FAF RID: 4015 RVA: 0x0008EA8C File Offset: 0x0008CC8C
		' (set) Token: 0x06000FB0 RID: 4016 RVA: 0x0008EA98 File Offset: 0x0008CC98
		Friend Overridable Property btnProcess As Button
			<CompilerGenerated()>
			Get
				Return Me._btnProcess
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnProcess_Click
				Dim button As Button = Me._btnProcess
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnProcess = value
				button = Me._btnProcess
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170005E8 RID: 1512
		' (get) Token: 0x06000FB1 RID: 4017 RVA: 0x0008EADB File Offset: 0x0008CCDB
		' (set) Token: 0x06000FB2 RID: 4018 RVA: 0x0008EAE8 File Offset: 0x0008CCE8
		Friend Overridable Property btnSetStock As Button
			<CompilerGenerated()>
			Get
				Return Me._btnSetStock
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnSetStock_Click
				Dim button As Button = Me._btnSetStock
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnSetStock = value
				button = Me._btnSetStock
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170005E9 RID: 1513
		' (get) Token: 0x06000FB3 RID: 4019 RVA: 0x0008EB2B File Offset: 0x0008CD2B
		' (set) Token: 0x06000FB4 RID: 4020 RVA: 0x0008EB38 File Offset: 0x0008CD38
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

		' Token: 0x06000FB5 RID: 4021 RVA: 0x0008EB7B File Offset: 0x0008CD7B
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Designing.SetTheme(Me)
			Me.SetData()
		End Sub

		' Token: 0x06000FB6 RID: 4022 RVA: 0x0008EB8C File Offset: 0x0008CD8C
		Private Sub UploadStock_Shown(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = CInt(Math.Round(CDbl((Me.theme_tc.Width - 4)) / 2.0))
			Me.theme_tc.ItemSize = New Size(num, 30)
			Me.tab_lbl1.Width = num
			Me.tab_lbl2.Width = num + 4
			Me.tab_lbl1.Location = New Point(0, 0)
			Me.tab_lbl2.Location = New Point(num - 4, 0)
		End Sub

		' Token: 0x06000FB7 RID: 4023 RVA: 0x0008EC14 File Offset: 0x0008CE14
		Private Sub SetData()
			Dim text As String = " DELETE FROM zGRN"
			text += " SELECT GRNID, GRNNo, GRNDt, VendorID, Status, " & vbCrLf
			text += " GRNItemsID, ProductID, CatalogNo, BatchNo, MfgDt, ExpDt, ReceivedQty, TertiaryPackSize, PrimaryPackSize," & vbCrLf
			text += " UnitPrice, GSTPer, LandingCost, TotalCost, ExpiryType, Expiry, IsQCApplicable, IsParentApplicable, Status_Item, " & vbCrLf
			text += " GRNUIDID, UID, ParentUID, Price, Status_UID" & vbCrLf
			text += " FROM zGRN" & vbCrLf
			text += " WHERE 1=2" & vbCrLf
			Dim data As DataTable = MainModule.GetData(text)
			Me.dtGRN = data.Copy()
			text = " SELECT ISNULL(MAX(GRNID), 0) AS GRNID, ISNULL(MAX(GRNNo), '') AS GRNNo FROM GRN"
			Dim dataTable As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = dataTable.Rows.Count > 0
			If flag Then
				' The following expression was wrapped in a unchecked-expression
				Me.iLastGRNID = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("GRNID"))) + 1.0))
				Dim flag2 As Boolean = Operators.CompareString(dataTable.Rows(0)("GRNNo").ToString(), "", False) = 0
				If flag2 Then
					Dim num As Integer = Conversions.ToInteger(Strings.Mid(Conversions.ToString(DateAndTime.Now.Year), 3))
					Dim flag3 As Boolean = DateAndTime.Now.Month > 3
					If flag3 Then
						Me.sLastGRNNo = "IA/GRN/" + Strings.Format(num, "#00") + Strings.Format(num + 1, "#00") + "/000001"
					Else
						Me.sLastGRNNo = "IA/GRN/" + Strings.Format(num - 1, "#00") + Strings.Format(num, "#00") + "/000001"
					End If
				Else
					' The following expression was wrapped in a unchecked-expression
					Me.sLastGRNNo = Strings.Mid(Conversions.ToString(dataTable.Rows(0)("GRNNo")), 1, 12) + Strings.Format(Conversion.Val(Conversions.ToDouble(Strings.Mid(Conversions.ToString(dataTable.Rows(0)("GRNNo")), 13)) + 1.0), "#000000")
				End If
				text = " SELECT ISNULL(MAX(GRNItemsID), 0) AS GRNItemsID FROM GRNItems"
				dataTable = MainModule.GetData(text)
				Dim flag4 As Boolean = dataTable.Rows.Count > 0
				If flag4 Then
					Me.iLastGRNItemID = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("GRNItemsID")))))
				End If
				text = " SELECT ISNULL(MAX(GRNUIDID), 0) AS GRNUIDID FROM GRNUID"
				dataTable = MainModule.GetData(text)
				Dim flag5 As Boolean = dataTable.Rows.Count > 0
				If flag5 Then
					Me.iLastGRNUIDID = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataTable.Rows(0)("GRNUIDID")))))
				End If
				Me.dtUnq = MainModule.SetLookUpTable()
				Me.dUIDDate = MainModule.GetServerDate()
				Me.SetUID()
			Else
				Me.btnStock.Enabled = False
			End If
		End Sub

		' Token: 0x06000FB8 RID: 4024 RVA: 0x0008EF0C File Offset: 0x0008D10C
		Private Sub SetUID()
			Me.sDay = Conversions.ToString(Me.dtUnq.[Select]("sType='D' AND sVal='" + Strings.Format(Me.dUIDDate, "dd") + "'")(0)("ID"))
			Me.sMon = Conversions.ToString(Me.dtUnq.[Select]("sType='M' AND sVal='" + Strings.Format(Me.dUIDDate, "MMM") + "'")(0)("ID"))
			Me.sYr = Conversions.ToString(Me.dtUnq.[Select]("sType='Y' AND sVal='" + Strings.Format(Me.dUIDDate, "yyyy") + "'")(0)("ID"))
			Dim text As String = " SELECT ISNULL(MAX(UID),'IADMY00000') AS MaxUID, ISNULL(MAX(ParentUID),'IADMY0000') AS MaxParentUID FROM GRNUID "
			text = String.Concat(New String() { text, " WHERE (CreationDt BETWEEN '", Strings.Format(Me.dUIDDate, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dUIDDate, "MM/dd/yyyy 23:59:59"), "') " })
			Dim data As DataTable = MainModule.GetData(text)
			Me.sLastUID = Conversions.ToString(data.Rows(0)("MaxUID"))
			Me.sLastParentUID = Conversions.ToString(data.Rows(0)("MaxParentUID"))
			Me.iMaxUID = Conversions.ToInteger(Strings.Mid(Me.sLastUID, 6, 5))
			Me.iMaxParentUID = Conversions.ToInteger(Strings.Mid(Me.sLastParentUID, 6, 4))
		End Sub

		' Token: 0x06000FB9 RID: 4025 RVA: 0x0008F0C4 File Offset: 0x0008D2C4
		Private Sub btnStock_Click(sender As Object, e As EventArgs)
			Dim text As String = " SELECT zS.ID,zP.ProductID, zS.CatalogNo, BatchNo, MfgDt, ExpDt, zP.ExpiryType, zP.Expiry, zP.IsQCApplicable, zP.IsParentApplicable," & vbCrLf
			text += " zP.TertiaryPacksize, zP.PrimaryPackSize, " & vbCrLf
			text += " zS.Price UnitPrice, zS.GSTPer, zS.LandingCost, " & vbCrLf
			text += " CASE WHEN CONVERT(BIT,zP.IsParentApplicable) = 1" & vbCrLf
			text += " THEN CONVERT(INT, CEILING(CONVERT(decimal, PrimaryQty) / CONVERT(INT, zP.TertiaryPacksize)))" & vbCrLf
			text += " ELSE  CONVERT(INT, PrimaryQty) END AS [TertiaryQty], " & vbCrLf
			text += " PrimaryQty" & vbCrLf
			text += " FROM zStock zS INNER JOIN Product zP ON zS.CatalogNo = zP.ProductCode" & vbCrLf
			text += " WHERE 1=1 " & vbCrLf
			text += " AND PrimaryQty > 0 " & vbCrLf
			text += " ORDER BY zS.CatalogNo, BatchNo, CONVERT(DATETIME,ExpDt)" & vbCrLf
			Dim data As DataTable = MainModule.GetData(text)
			Me.dtStock = data.Copy()
			Me.dgvList.DataSource = Me.dtStock
			Me.lblRowsG.Text = Conversions.ToString(Me.dtStock.Rows.Count) + " Rows"
			text = " SELECT GRNID, GRNNo, GRNDt, GRNType, VendorID, Status, GRNItemsID, ProductID, CatalogNo, BatchNo, MfgDt, ExpDt, " & vbCrLf
			text += " ReceivedQty, TertiaryPackSize, PrimaryPackSize, UnitPrice, GSTPer, BasicValue, LandingCost, TotalCost, ExpiryType, Expiry, " & vbCrLf
			text += " IsQCApplicable, IsParentApplicable, Status_Item, GRNUIDID, UID, ParentUID, Price, Status_UID" & vbCrLf
			text += " FROM zGRN" & vbCrLf
			Me.dtGRN = MainModule.GetData(text)
		End Sub

		' Token: 0x06000FBA RID: 4026 RVA: 0x0008F1D6 File Offset: 0x0008D3D6
		Private Sub btnProcess_Click(sender As Object, e As EventArgs)
			Me.ProcessData1()
		End Sub

		' Token: 0x06000FBB RID: 4027 RVA: 0x0008F1E0 File Offset: 0x0008D3E0
		Private Sub ProcessData()
			Dim num As Integer = 0
			Me.SetUID()
			Dim num2 As Integer = Me.dtStock.Rows.Count - 1
			For i As Integer = 0 To num2
				Dim ptr As __ByRef(Of Integer) = Me.iLastGRNItemID
				Me.iLastGRNItemID = ptr + 1
				num = CInt(Math.Round(CDbl(num) + Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("PrimaryQty")))))
				Dim flag As Boolean = num > 50
				If flag Then
					num = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("PrimaryQty")))))
					ptr = Me.iLastGRNID
					Me.iLastGRNID = ptr + 1
					Me.sLastGRNNo = Strings.Mid(Me.sLastGRNNo, 1, 12) + Strings.Format(Conversion.Val(Conversions.ToDouble(Strings.Mid(Me.sLastGRNNo, 13)) + 1.0), "#000000")
				End If
				Dim flag2 As Boolean = Me.iMaxUID + 1 > 99999
				If flag2 Then
					Me.dUIDDate = DateAndTime.DateAdd(DateInterval.Day, 1.0, Me.dUIDDate)
					Me.SetUID()
				End If
				Dim num3 As Integer = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("TertiaryQty"))) - 1.0))
				For j As Integer = 0 To num3
					Dim num4 As Integer = 0
					Dim flag3 As Boolean = Convert.ToInt16(RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("IsParentApplicable"))) = 1S
					If flag3 Then
						ptr = Me.iMaxParentUID
						Me.iMaxParentUID = ptr + 1
						Me.sParentBarcode = String.Concat(New String() { "IA", Me.sDay, Me.sMon, Me.sYr, Strings.Format(Me.iMaxParentUID, "0000") })
					Else
						Me.sParentBarcode = ""
					End If
					Dim num5 As Integer = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("PrimaryQty"))) - 1.0))
					For k As Integer = 0 To num5
						ptr = Me.iLastGRNUIDID
						Me.iLastGRNUIDID = ptr + 1
						num4 += 1
						ptr = Me.iMaxUID
						Me.iMaxUID = ptr + 1
						Me.sUIDBarcode = String.Concat(New String() { "IA", Me.sDay, Me.sMon, Me.sYr, Strings.Format(Me.iMaxUID, "00000") })
						Me.dtGRN.Rows.Add(New Object(-1) {})
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("GRNID") = Me.iLastGRNID
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("GRNNo") = Me.sLastGRNNo
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("GRNDt") = Strings.Format(Me.dUIDDate, "dd-MMM-yyyy 00:00:00")
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("GRNType") = "Receipt"
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("VendorID") = "97"
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("Status") = "Release Complete"
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("GRNItemsID") = Me.iLastGRNItemID
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("ProductID") = RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("ProductID"))
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("CatalogNo") = RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("CatalogNo"))
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("BatchNo") = Me.dtStock.Rows(i)("BatchNo").ToString()
						Dim flag4 As Boolean = Operators.CompareString(Me.dtStock.Rows(i)("MfgDt").ToString(), "", False) <> 0
						If flag4 Then
							Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("MfgDt") = Strings.Format(Conversions.ToDate(Me.dtStock.Rows(i)("MfgDt")), "dd-MMM-yyyy 00:00:00")
						Else
							Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("MfgDt") = DBNull.Value
						End If
						Dim flag5 As Boolean = Operators.CompareString(Me.dtStock.Rows(i)("ExpDt").ToString(), "", False) <> 0
						If flag5 Then
							Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("ExpDt") = Strings.Format(Conversions.ToDate(Me.dtStock.Rows(i)("ExpDt")), "dd-MMM-yyyy 00:00:00")
						Else
							Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("ExpDt") = DBNull.Value
						End If
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("ReceivedQty") = RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("TertiaryQty"))
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("TertiaryPackSize") = RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("TertiaryPackSize"))
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("PrimaryPackSize") = RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("PrimaryPackSize"))
						Dim flag6 As Boolean = Operators.CompareString(Me.dtStock.Rows(i)("UnitPrice").ToString(), "", False) = 0
						Dim num6 As Double
						If flag6 Then
							num6 = 0.0
						Else
							num6 = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("UnitPrice")))
						End If
						Dim flag7 As Boolean = Operators.CompareString(Me.dtStock.Rows(i)("GSTPer").ToString(), "", False) = 0
						Dim num7 As Double
						If flag7 Then
							num7 = 0.0
						Else
							num7 = 0.0
						End If
						Dim flag8 As Boolean = Operators.CompareString(Me.dtStock.Rows(i)("LandingCost").ToString(), "", False) = 0
						Dim num8 As Double
						If flag8 Then
							num8 = 0.0
						Else
							num8 = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("LandingCost")))
						End If
						Dim num9 As Double
						Dim num10 As Double

							num9 = (num6 + num7) * Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("PrimaryQty")))
							num10 = num9 + num8

						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("UnitPrice") = num6
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("GSTPer") = "0 %"
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("BasicValue") = num9
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("LandingCost") = num8
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("TotalCost") = num10
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("ExpiryType") = RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("ExpiryType"))
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("Expiry") = RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("Expiry"))
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("IsQCApplicable") = RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("IsQCApplicable"))
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("IsParentApplicable") = RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("IsParentApplicable"))
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("Status_Item") = "Batch Released"
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("GRNUIDID") = Me.iLastGRNUIDID
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("UID") = Me.sUIDBarcode
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("ParentUID") = Me.sParentBarcode
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("Price") = num6
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("Status_UID") = "Available"
						Dim flag9 As Boolean = CDbl(num4) = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("TertiaryPackSize")))
						If flag9 Then
							Exit For
						End If
					Next
				Next
			Next
			Me.dgvGRN.DataSource = Me.dtGRN
			Me.lblRows.Text = Conversions.ToString(Me.dtGRN.Rows.Count) + " Rows"
			Me.dgvGRN.Columns("GRNDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvGRN.Columns("MfgDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvGRN.Columns("ExpDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvGRN.Columns("GRNID").Width = 57
			Me.dgvGRN.Columns("GRNNo").Width = 147
			Me.dgvGRN.Columns("GRNDt").Width = 100
			Me.dgvGRN.Columns("VendorID").Width = 77
			Me.dgvGRN.Columns("Status").Width = 121
			Me.dgvGRN.Columns("GRNItemsID").Width = 93
			Me.dgvGRN.Columns("ProductID").Width = 83
			Me.dgvGRN.Columns("CatalogNo").Width = 100
			Me.dgvGRN.Columns("BatchNo").Width = 100
			Me.dgvGRN.Columns("MfgDt").Width = 100
			Me.dgvGRN.Columns("ExpDt").Width = 100
			Me.dgvGRN.Columns("ReceivedQty").Width = 100
			Me.dgvGRN.Columns("TertiaryPackSize").Width = 113
			Me.dgvGRN.Columns("PrimaryPackSize").Width = 108
			Me.dgvGRN.Columns("UnitPrice").Width = 100
			Me.dgvGRN.Columns("GSTPer").Width = 100
			Me.dgvGRN.Columns("BasicValue").Width = 100
			Me.dgvGRN.Columns("LandingCost").Width = 100
			Me.dgvGRN.Columns("TotalCost").Width = 100
			Me.dgvGRN.Columns("ExpiryType").Width = 100
			Me.dgvGRN.Columns("Expiry").Width = 100
			Me.dgvGRN.Columns("IsQCApplicable").Width = 100
			Me.dgvGRN.Columns("IsParentApplicable").Width = 125
			Me.dgvGRN.Columns("Status_Item").Width = 100
			Me.dgvGRN.Columns("GRNUIDID").Width = 100
			Me.dgvGRN.Columns("UID").Width = 100
			Me.dgvGRN.Columns("ParentUID").Width = 100
			Me.dgvGRN.Columns("Price").Width = 100
			Me.dgvGRN.Columns("Status_UID").Width = 100
		End Sub

		' Token: 0x06000FBC RID: 4028 RVA: 0x000902B0 File Offset: 0x0008E4B0
		Private Sub ProcessData1()
			Dim num As Integer = 0
			Dim num2 As Integer = 0
			Me.SetUID()
			Dim num3 As Integer = Me.dtStock.Rows.Count - 1
			For i As Integer = 0 To num3
				Dim ptr As __ByRef(Of Integer) = Me.iLastGRNItemID
				Me.iLastGRNItemID = ptr + 1
				Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(Me.dtStock.Rows(i)("CatalogNo"), "430166", False)
				If flag Then
				End If
				num = CInt(Math.Round(CDbl(num) + Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("PrimaryQty")))))
				Dim flag2 As Boolean = num > 50
				If flag2 Then
					num = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("PrimaryQty")))))
					ptr = Me.iLastGRNID
					Me.iLastGRNID = ptr + 1
					Me.sLastGRNNo = Strings.Mid(Me.sLastGRNNo, 1, 12) + Strings.Format(Conversion.Val(Conversions.ToDouble(Strings.Mid(Me.sLastGRNNo, 13)) + 1.0), "#000000")
				End If
				Dim flag3 As Boolean = Me.iMaxUID + 1 > 99999
				If flag3 Then
					Me.dUIDDate = DateAndTime.DateAdd(DateInterval.Day, 1.0, Me.dUIDDate)
					Me.SetUID()
				End If
				Dim num4 As Integer = 0
				Dim num5 As Integer = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("TertiaryQty"))) - 1.0))
				For j As Integer = 0 To num5
					Dim flag4 As Boolean = Convert.ToInt16(RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("IsParentApplicable"))) = 1S
					If flag4 Then
						ptr = Me.iMaxParentUID
						Me.iMaxParentUID = ptr + 1
						Me.sParentBarcode = String.Concat(New String() { "IA", Me.sDay, Me.sMon, Me.sYr, Strings.Format(Me.iMaxParentUID, "0000") })
					Else
						Me.sParentBarcode = ""
					End If
					Dim num6 As Integer = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("TertiaryPackSize"))) - 1.0))
					For k As Integer = 0 To num6
						Dim flag5 As Boolean = CDbl(num4) = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("PrimaryQty")))
						If flag5 Then
							Exit For
						End If
						num4 += 1
						ptr = Me.iLastGRNUIDID
						Me.iLastGRNUIDID = ptr + 1
						num2 += 1
						ptr = Me.iMaxUID
						Me.iMaxUID = ptr + 1
						Me.sUIDBarcode = String.Concat(New String() { "IA", Me.sDay, Me.sMon, Me.sYr, Strings.Format(Me.iMaxUID, "00000") })
						Me.dtGRN.Rows.Add(New Object(-1) {})
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("GRNID") = Me.iLastGRNID
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("GRNNo") = Me.sLastGRNNo
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("GRNDt") = Strings.Format(Me.dUIDDate, "dd-MMM-yyyy 00:00:00")
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("GRNType") = "Receipt"
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("VendorID") = "97"
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("Status") = "Release Complete"
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("GRNItemsID") = Me.iLastGRNItemID
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("ProductID") = RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("ProductID"))
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("CatalogNo") = RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("CatalogNo"))
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("BatchNo") = Me.dtStock.Rows(i)("BatchNo").ToString()
						Dim flag6 As Boolean = Operators.CompareString(Me.dtStock.Rows(i)("MfgDt").ToString(), "", False) <> 0
						If flag6 Then
							Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("MfgDt") = Strings.Format(Conversions.ToDate(Me.dtStock.Rows(i)("MfgDt")), "dd-MMM-yyyy 00:00:00")
						Else
							Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("MfgDt") = DBNull.Value
						End If
						Dim flag7 As Boolean = Operators.CompareString(Me.dtStock.Rows(i)("ExpDt").ToString(), "", False) <> 0
						If flag7 Then
							Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("ExpDt") = Strings.Format(Conversions.ToDate(Me.dtStock.Rows(i)("ExpDt")), "dd-MMM-yyyy 00:00:00")
						Else
							Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("ExpDt") = DBNull.Value
						End If
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("ReceivedQty") = RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("TertiaryQty"))
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("TertiaryPackSize") = RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("TertiaryPackSize"))
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("PrimaryPackSize") = RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("PrimaryPackSize"))
						Dim flag8 As Boolean = Operators.CompareString(Me.dtStock.Rows(i)("UnitPrice").ToString(), "", False) = 0
						Dim num7 As Double
						If flag8 Then
							num7 = 0.0
						Else
							num7 = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("UnitPrice")))
						End If
						Dim flag9 As Boolean = Operators.CompareString(Me.dtStock.Rows(i)("GSTPer").ToString(), "", False) = 0
						Dim num8 As Double
						If flag9 Then
							num8 = 0.0
						Else
							num8 = 0.0
						End If
						Dim flag10 As Boolean = Operators.CompareString(Me.dtStock.Rows(i)("LandingCost").ToString(), "", False) = 0
						Dim num9 As Double
						If flag10 Then
							num9 = 0.0
						Else
							num9 = Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("LandingCost")))
						End If
						Dim num10 As Double
						Dim num11 As Double

							num10 = (num7 + num8) * Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("PrimaryQty")))
							num11 = num10 + num9

						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("UnitPrice") = num7
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("GSTPer") = "0 %"
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("BasicValue") = num10
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("LandingCost") = num9
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("TotalCost") = num11
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("ExpiryType") = RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("ExpiryType"))
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("Expiry") = RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("Expiry"))
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("IsQCApplicable") = RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("IsQCApplicable"))
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("IsParentApplicable") = RuntimeHelpers.GetObjectValue(Me.dtStock.Rows(i)("IsParentApplicable"))
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("Status_Item") = "Batch Released"
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("GRNUIDID") = Me.iLastGRNUIDID
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("UID") = Me.sUIDBarcode
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("ParentUID") = Me.sParentBarcode
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("Price") = num7
						Me.dtGRN.Rows(Me.dtGRN.Rows.Count - 1)("Status_UID") = "Available"
					Next
				Next
			Next
			Me.dgvGRN.DataSource = Me.dtGRN
			Me.lblRows.Text = Conversions.ToString(Me.dtGRN.Rows.Count) + " Rows"
			Me.dgvGRN.Columns("GRNDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvGRN.Columns("MfgDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvGRN.Columns("ExpDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvGRN.Columns("GRNID").Width = 57
			Me.dgvGRN.Columns("GRNNo").Width = 147
			Me.dgvGRN.Columns("GRNDt").Width = 100
			Me.dgvGRN.Columns("VendorID").Width = 77
			Me.dgvGRN.Columns("Status").Width = 121
			Me.dgvGRN.Columns("GRNItemsID").Width = 93
			Me.dgvGRN.Columns("ProductID").Width = 83
			Me.dgvGRN.Columns("CatalogNo").Width = 100
			Me.dgvGRN.Columns("BatchNo").Width = 100
			Me.dgvGRN.Columns("MfgDt").Width = 100
			Me.dgvGRN.Columns("ExpDt").Width = 100
			Me.dgvGRN.Columns("ReceivedQty").Width = 100
			Me.dgvGRN.Columns("TertiaryPackSize").Width = 113
			Me.dgvGRN.Columns("PrimaryPackSize").Width = 108
			Me.dgvGRN.Columns("UnitPrice").Width = 100
			Me.dgvGRN.Columns("GSTPer").Width = 100
			Me.dgvGRN.Columns("BasicValue").Width = 100
			Me.dgvGRN.Columns("LandingCost").Width = 100
			Me.dgvGRN.Columns("TotalCost").Width = 100
			Me.dgvGRN.Columns("ExpiryType").Width = 100
			Me.dgvGRN.Columns("Expiry").Width = 100
			Me.dgvGRN.Columns("IsQCApplicable").Width = 100
			Me.dgvGRN.Columns("IsParentApplicable").Width = 125
			Me.dgvGRN.Columns("Status_Item").Width = 100
			Me.dgvGRN.Columns("GRNUIDID").Width = 100
			Me.dgvGRN.Columns("UID").Width = 100
			Me.dgvGRN.Columns("ParentUID").Width = 100
			Me.dgvGRN.Columns("Price").Width = 100
			Me.dgvGRN.Columns("Status_UID").Width = 100
		End Sub

		' Token: 0x06000FBD RID: 4029 RVA: 0x000913BC File Offset: 0x0008F5BC
		Private Sub btnSetStock_Click(sender As Object, e As EventArgs)
			Dim sqlConnection As SqlConnection = New SqlConnection(GlobalVariables.gsConStr)
			sqlConnection.Open()
			Dim sqlTransaction As SqlTransaction = sqlConnection.BeginTransaction(IsolationLevel.Serializable)
			Try
				Me.InsertBarcodes(sqlConnection, sqlTransaction)
				Me.InsertGRN(sqlConnection, sqlTransaction)
				sqlTransaction.Commit()
				sqlConnection.Close()
				CustomMsgBox.Show("GRN Generated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			Catch ex As Exception
				sqlTransaction.Rollback()
				sqlConnection.Close()
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06000FBE RID: 4030 RVA: 0x0009146C File Offset: 0x0008F66C
		Private Function InsertBarcodes(oCon As SqlConnection, oTrn As SqlTransaction) As Boolean
			Dim flag As Boolean = Me.dtGRN.Rows.Count > 0
			Dim flag3 As Boolean
			If flag Then
				Dim text As String = "DELETE FROM zGRN"
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text, oCon, oTrn) = 1
				If flag2 Then
					Dim dataTable As DataTable = Me.dtGRN.Copy()
					MainModule.BulkInsertTemp(dataTable, "zGRN", oCon, oTrn)
					flag3 = True
				Else
					flag3 = False
				End If
			Else
				flag3 = False
			End If
			Return flag3
		End Function

		' Token: 0x06000FBF RID: 4031 RVA: 0x000914D4 File Offset: 0x0008F6D4
		Private Sub InsertGRN(oCon As SqlConnection, oTrn As SqlTransaction)
			Dim text As String = " -- GRN ENTRY -----------------------------------------------------------------------------------------------------------------------------------" & vbCrLf
			text += " SET IDENTITY_INSERT [dbo].[GRN] ON " & vbCrLf
			text += " INSERT INTO GRN (GRNID, GRNNo, GRNDt, GRNType, VendorID, Status, CreationDt)" & vbCrLf
			text += " SELECT DISTINCT GRNID, GRNNo, GRNDt, GRNType, VendorID, Status, GRNDt" & vbCrLf
			text += " FROM zGRN" & vbCrLf
			text += " SET IDENTITY_INSERT [dbo].[GRN] OFF" & vbCrLf
			text += " " & vbCrLf
			text += " " & vbCrLf
			text += " -- GRNItems ENTRY ------------------------------------------------------------------------------------------------------------------------------" & vbCrLf
			text += " SET IDENTITY_INSERT [dbo].[GRNItems] ON " & vbCrLf
			text += " INSERT INTO GRNItems (GRNID, GRNItemsID, ProductID, CatalogNo, BatchNo, MfgDt, ExpDt, ReceivedQty, " & vbCrLf
			text += " TertiaryPackSize, PrimaryPackSize, UnitPrice, GSTPer, BasicValue, LandingCost, TotalCost, ExpiryType, Expiry, " & vbCrLf
			text += " IsQCApplicable, IsParentApplicable, Status)" & vbCrLf
			text += " SELECT DISTINCT GRNID, GRNItemsID, ProductID, CatalogNo, BatchNo, MfgDt, ExpDt, " & vbCrLf
			text += " ReceivedQty, TertiaryPackSize, PrimaryPackSize, UnitPrice, GSTPer, BasicValue, LandingCost, TotalCost, ExpiryType, Expiry, " & vbCrLf
			text += " IsQCApplicable, IsParentApplicable, Status_Item" & vbCrLf
			text += " FROM zGRN" & vbCrLf
			text += " SET IDENTITY_INSERT [dbo].[GRNItems] OFF" & vbCrLf
			text += " " & vbCrLf
			text += " " & vbCrLf
			text += " -- GRNUID ENTRY --------------------------------------------------------------------------------------------------------------------------------" & vbCrLf
			text += " SET IDENTITY_INSERT [dbo].[GRNUID] ON " & vbCrLf
			text += " INSERT INTO GRNUID (GRNID, GRNItemsID, GRNUIDID, ProductID, UID, ParentUID, LocationCode, CatalogNo,  " & vbCrLf
			text += " BatchNo, MfgDt, ExpDt, Price, ExpiryType, Expiry, IsParentApplicable, Status, CreationDt)" & vbCrLf
			text += " SELECT DISTINCT GRNID, GRNItemsID, GRNUIDID, ProductID, UID, ParentUID, '' LocationCode, CatalogNo, " & vbCrLf
			text += " BatchNo, MfgDt, ExpDt, Price, ExpiryType, Expiry, IsParentApplicable, Status_UID, GRNDt" & vbCrLf
			text += " FROM zGRN" & vbCrLf
			text += " SET IDENTITY_INSERT [dbo].[GRNUID] OFF" & vbCrLf
			Dim flag As Boolean = MainModule.ExecuteSQL(text, oCon, oTrn) <> 0
			If flag Then
			End If
		End Sub

		' Token: 0x06000FC0 RID: 4032 RVA: 0x0009163D File Offset: 0x0008F83D
		Private Sub btnExport_Click(sender As Object, e As EventArgs)
			MainModule.ExportToExcel(Me.dgvGRN, Me.Text)
		End Sub

		' Token: 0x04000689 RID: 1673
		Private dtStock As DataTable

		' Token: 0x0400068A RID: 1674
		Private dtGRN As DataTable

		' Token: 0x0400068B RID: 1675
		Private dtItem As DataTable

		' Token: 0x0400068C RID: 1676
		Private dtUnq As DataTable

		' Token: 0x0400068D RID: 1677
		Private sLastGRNNo As String

		' Token: 0x0400068E RID: 1678
		Private iLastGRNID As Integer

		' Token: 0x0400068F RID: 1679
		Private iLastGRNItemID As Integer

		' Token: 0x04000690 RID: 1680
		Private iLastGRNUIDID As Integer

		' Token: 0x04000691 RID: 1681
		Private sLastUID As String

		' Token: 0x04000692 RID: 1682
		Private sLastParentUID As String

		' Token: 0x04000693 RID: 1683
		Private iMaxUID As Integer

		' Token: 0x04000694 RID: 1684
		Private iMaxParentUID As Integer

		' Token: 0x04000695 RID: 1685
		Private dUIDDate As DateTime

		' Token: 0x04000696 RID: 1686
		Private sDay As String

		' Token: 0x04000697 RID: 1687
		Private sMon As String

		' Token: 0x04000698 RID: 1688
		Private sYr As String

		' Token: 0x04000699 RID: 1689
		Private sUIDBarcode As String

		' Token: 0x0400069A RID: 1690
		Private sParentBarcode As String
	End Class
End Namespace
