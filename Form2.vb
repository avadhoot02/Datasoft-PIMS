Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x02000034 RID: 52
	<DesignerGenerated()>
	Public Partial Class Form2
		Inherits Form

		' Token: 0x06000BCF RID: 3023 RVA: 0x000730B8 File Offset: 0x000712B8
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Form2_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000442 RID: 1090
		' (get) Token: 0x06000BD2 RID: 3026 RVA: 0x000736A5 File Offset: 0x000718A5
		' (set) Token: 0x06000BD3 RID: 3027 RVA: 0x000736B0 File Offset: 0x000718B0
		Friend Overridable Property btnCon As Button
			<CompilerGenerated()>
			Get
				Return Me._btnCon
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnCon_Click
				Dim button As Button = Me._btnCon
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnCon = value
				button = Me._btnCon
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000443 RID: 1091
		' (get) Token: 0x06000BD4 RID: 3028 RVA: 0x000736F3 File Offset: 0x000718F3
		' (set) Token: 0x06000BD5 RID: 3029 RVA: 0x00073700 File Offset: 0x00071900
		Friend Overridable Property btnPrintIssue As Button
			<CompilerGenerated()>
			Get
				Return Me._btnPrintIssue
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnPrintIssue_Click
				Dim button As Button = Me._btnPrintIssue
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnPrintIssue = value
				button = Me._btnPrintIssue
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000444 RID: 1092
		' (get) Token: 0x06000BD6 RID: 3030 RVA: 0x00073743 File Offset: 0x00071943
		' (set) Token: 0x06000BD7 RID: 3031 RVA: 0x00073750 File Offset: 0x00071950
		Friend Overridable Property btnPrintQC As Button
			<CompilerGenerated()>
			Get
				Return Me._btnPrintQC
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnPrintQC_Click
				Dim button As Button = Me._btnPrintQC
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnPrintQC = value
				button = Me._btnPrintQC
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000445 RID: 1093
		' (get) Token: 0x06000BD8 RID: 3032 RVA: 0x00073793 File Offset: 0x00071993
		' (set) Token: 0x06000BD9 RID: 3033 RVA: 0x0007379D File Offset: 0x0007199D
		Friend Overridable Property txt1 As TextBox

		' Token: 0x17000446 RID: 1094
		' (get) Token: 0x06000BDA RID: 3034 RVA: 0x000737A6 File Offset: 0x000719A6
		' (set) Token: 0x06000BDB RID: 3035 RVA: 0x000737B0 File Offset: 0x000719B0
		Friend Overridable Property btnRpt As Button
			<CompilerGenerated()>
			Get
				Return Me._btnRpt
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnRpt_Click
				Dim button As Button = Me._btnRpt
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnRpt = value
				button = Me._btnRpt
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000447 RID: 1095
		' (get) Token: 0x06000BDC RID: 3036 RVA: 0x000737F3 File Offset: 0x000719F3
		' (set) Token: 0x06000BDD RID: 3037 RVA: 0x00073800 File Offset: 0x00071A00
		Friend Overridable Property btnLoc As Button
			<CompilerGenerated()>
			Get
				Return Me._btnLoc
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnLoc_Click
				Dim button As Button = Me._btnLoc
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnLoc = value
				button = Me._btnLoc
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000448 RID: 1096
		' (get) Token: 0x06000BDE RID: 3038 RVA: 0x00073843 File Offset: 0x00071A43
		' (set) Token: 0x06000BDF RID: 3039 RVA: 0x00073850 File Offset: 0x00071A50
		Friend Overridable Property Button1 As Button
			<CompilerGenerated()>
			Get
				Return Me._Button1
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.Button1_Click
				Dim button As Button = Me._Button1
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._Button1 = value
				button = Me._Button1
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000449 RID: 1097
		' (get) Token: 0x06000BE0 RID: 3040 RVA: 0x00073893 File Offset: 0x00071A93
		' (set) Token: 0x06000BE1 RID: 3041 RVA: 0x000738A0 File Offset: 0x00071AA0
		Friend Overridable Property btnPrint As Button
			<CompilerGenerated()>
			Get
				Return Me._btnPrint
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnPrint_Click
				Dim button As Button = Me._btnPrint
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnPrint = value
				button = Me._btnPrint
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x06000BE2 RID: 3042 RVA: 0x000738E3 File Offset: 0x00071AE3
		Private Sub Form2_Load(sender As Object, e As EventArgs)
			Me.btnPrint_Click(RuntimeHelpers.GetObjectValue(sender), e)
		End Sub

		' Token: 0x06000BE3 RID: 3043 RVA: 0x000738F4 File Offset: 0x00071AF4
		Private Sub btnPrint_Click(sender As Object, e As EventArgs)
			Dim text As String = " SELECT PO.POID, POType, PONo, PODt, PRNo, PRDt, ValidUpto, DeliveryDt, Department, " & vbCrLf
			text += " InvoiceAddress, BillingEmailID, ShipAddress, ShippingEmailID, GSTNo, PANNo, " & vbCrLf
			text += " VendorName, VendorBillingAddress, VendorContactPerson, VendorContactNo, VendorEmailID, VendorGSTNo, VendorPANNo, " & vbCrLf
			text += " BankType, BankName, BankAddress, AccountNo, IFSCCode, IBANNo, BankRoutingNo, BankSortCode, SWIFTCode, " & vbCrLf
			text += " ModeOfPayment, DispatchedThrough, PaymentTerms, IncoTerms, DeliveryTerms, PO.Currency, " & vbCrLf
			text += " CASE WHEN PO.ModifiedBy IS NOT NULL THEN M.UserName ELSE C.UserName END AS CreatedBy, " & vbCrLf
			text += " CASE WHEN PO.ModificationDt IS NOT NULL THEN PO.ModificationDt ELSE PO.CreationDt END AS CreationDt, " & vbCrLf
			text = text + " A.UserName AS ApprovedBy, '" + GlobalVariables.gsUserName + "' AS PrintedBy, " & vbCrLf
			text += " ROW_NUMBER() OVER(ORDER BY POItemsID) AS SrNo, ProductName, Description, CatalogNo, HSNSACCode, UOM, " & vbCrLf
			text += " Quantity, POI.UnitPrice, BasicValue, DiscountPer, DiscountAmt, NetAmt, TaxPer, TaxAmt, " & vbCrLf
			text += " Transportation, Freight, LoadingUnloading, Packing, OtherCharges, FinalAmt " & vbCrLf
			text += " FROM PO " & vbCrLf
			text += " INNER JOIN Vendor V ON PO.VendorID = V.VendorID " & vbCrLf
			text += " INNER JOIN [User] C ON PO.CreatedBy = C.UserID " & vbCrLf
			text += " LEFT OUTER JOIN [User] M ON Po.ModifiedBy = M.UserID " & vbCrLf
			text += " LEFT OUTER JOIN [User] A ON PO.ActionBy = A.UserID " & vbCrLf
			text += " INNER JOIN POItems POI ON PO.POID = POI.POID " & vbCrLf
			text += " INNER JOIN Product Prod ON POI.ProductID = Prod.ProductID " & vbCrLf
			text += " WHERE PO.POID = '3' " & vbCrLf
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim reportCrystal As ReportCrystal = New ReportCrystal("PO4", data)
				reportCrystal.Show()
				MyBase.Close()
			End If
		End Sub

		' Token: 0x06000BE4 RID: 3044 RVA: 0x00073A20 File Offset: 0x00071C20
		Private Sub btnPrintQC_Click(sender As Object, e As EventArgs)
			Dim text As String = " SELECT '' AS RMNo, 'F/SOP/QC/006/NN-XX' AS FormatNo, 'SOP/QC/006' AS ReferenceSOPNo, NULL AS EffectiveDt, NULL AS ValidUpto, " & vbCrLf
			text += " P.ProductName AS MaterialName, P.SpecificationNo, P.Reference, V.VendorName, P.CatalogNo, GIQC.BatchNo, " & vbCrLf
			text += " ROW_NUMBER() OVER(ORDER BY GIQC.GRNItemsQCID) AS  SrNo, GIQC.Specification, GIQC.AcceptanceCriteria, GIQC.Complies, GI.Remarks, " & vbCrLf
			text += " Entry.UserName AS QCEntryBy, Entry.Designation AS QCEntryDesignation, GI.QCEntryDt, " & vbCrLf
			text += " Action.UserName AS QCActionBy, Action.Designation AS QCActionDesignation, GI.QCActionDt" & vbCrLf
			text += " FROM GRN AS G " & vbCrLf
			text += " INNER JOIN GRNItems AS GI ON G.GRNID = GI.GRNID " & vbCrLf
			text += " INNER JOIN GRNItemsQC AS GIQC ON GI.GRNItemsID = GIQC.GRNItemsID " & vbCrLf
			text += " INNER JOIN Product AS P ON GI.ProductID = P.ProductID " & vbCrLf
			text += " INNER JOIN Vendor AS V ON G.VendorID = V.VendorID " & vbCrLf
			text += " LEFT OUTER JOIN [User] AS Entry ON GI.QCEntryBy = Entry.UserID " & vbCrLf
			text += " LEFT OUTER JOIN [User] AS Action ON GI.QCActionBy = Action.UserID" & vbCrLf
			text += " WHERE G.GRNID = '11' AND GIQC.ProductID = '10002' AND GIQC.BatchNo = 'B001'" & vbCrLf
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim reportCrystal As ReportCrystal = New ReportCrystal("QC", data)
				reportCrystal.Show()
				MyBase.Close()
			End If
		End Sub

		' Token: 0x06000BE5 RID: 3045 RVA: 0x00073AFC File Offset: 0x00071CFC
		Private Sub btnPrintIssue_Click(sender As Object, e As EventArgs)
			Dim text As String = " SELECT R.RequestID, RequestNo, P.ProductName, R.BatchNo, ReqBy.UserName AS RequestedBy, RequestDt, " & vbCrLf
			text += " ROW_NUMBER() OVER(ORDER BY RD.RequestDtlsID) AS  SrNo, M.ProductName AS MaterialName, M.CatalogNo, " & vbCrLf
			text += " RD.RequiredQty, ID.BatchNo AS LotNo, ID.ExpDt AS ExpiryDt, ID.IssuedQty, " & vbCrLf
			text += " IssBy.UserName AS IssuedBy, Action.UserName AS VerifiedBy" & vbCrLf
			text += " FROM Request R" & vbCrLf
			text += " INNER JOIN RequestDtls RD ON R.RequestID = RD.RequestID" & vbCrLf
			text += " INNER JOIN Product P ON R.ProductID = P.ProductID " & vbCrLf
			text += " INNER JOIN [User] ReqBy ON R.RequestedBy = ReqBy.UserID" & vbCrLf
			text += " INNER JOIN Product M ON RD.ProductID = M.ProductID " & vbCrLf
			text += " INNER JOIN Issue I ON R.RequestID = I.RequestID" & vbCrLf
			text += " INNER JOIN [User] Action ON I.ActionBy = Action.UserID" & vbCrLf
			text += " INNER JOIN [User] IssBy ON I.IssuedBy = IssBy.UserID" & vbCrLf
			text += " INNER JOIN (" & vbCrLf
			text += "     SELECT IssueID, ISD.ProductID, ISD.BatchNo, GU.ExpDt, COUNT(ISD.UID) AS IssuedQty " & vbCrLf
			text += "     FROM IssueDtls ISD INNER JOIN GRNUID GU ON ISD.UID = GU.UID" & vbCrLf
			text += "     GROUP BY IssueID, ISD.ProductID, ISD.BatchNo, GU.ExpDt" & vbCrLf
			text += "     ) ID ON I.IssueID = ID.IssueID AND RD.ProductID = ID.ProductID" & vbCrLf
			text += " WHERE I.IssueID = '3'" & vbCrLf
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim reportCrystal As ReportCrystal = New ReportCrystal("Issue", data)
				reportCrystal.Show()
				MyBase.Close()
			End If
		End Sub

		' Token: 0x06000BE6 RID: 3046 RVA: 0x00073C14 File Offset: 0x00071E14
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Dim executingAssembly As Assembly = Assembly.GetExecutingAssembly()
			Dim manifestResourceNames As String() = executingAssembly.GetManifestResourceNames()
			Dim [namespace] As String = GetType(EmailModule).[Namespace]
			Dim text As String = "Datasoft_PIMS.Standard.html"
			Dim manifestResourceStream As Stream = executingAssembly.GetManifestResourceStream(text)
		End Sub

		' Token: 0x06000BE7 RID: 3047 RVA: 0x00073C50 File Offset: 0x00071E50
		Private Sub btnLoc_Click(sender As Object, e As EventArgs)
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("SrNo", Type.[GetType]("System.String"))
			dataTable.Columns.Add("LocationCode", Type.[GetType]("System.String"))
			dataTable.Columns.Add("ProductBarcode", Type.[GetType]("System.String"))
			Dim num As Integer = 0
			Do
				dataTable.Rows.Add(New Object(-1) {})
				dataTable.Rows(dataTable.Rows.Count - 1)("SrNo") = dataTable.Rows.Count
				dataTable.Rows(dataTable.Rows.Count - 1)("LocationCode") = "IALBEA0001"
				dataTable.Rows(dataTable.Rows.Count - 1)("ProductBarcode") = "IALBEA000" + Conversions.ToString(num)
				num += 1
			Loop While num <= 9
			Dim enumerableRowCollection As EnumerableRowCollection(Of DataRow) = dataTable.AsEnumerable()
			Dim func As Func(Of DataRow, String)
			If Form2._Closure$__.$I41-0 IsNot Nothing Then
				func = Form2._Closure$__.$I41-0
			Else
				Dim func2 As Func(Of DataRow, String) = Function(x As DataRow) x.Field("ProductBarcode")
				func = func2
				Form2._Closure$__.$I41-0 = func2
			End If
			Dim array As String() = enumerableRowCollection.[Select](func).ToArray()
			Dim text As String = String.Join(", ", array)
		End Sub

		' Token: 0x06000BE8 RID: 3048 RVA: 0x00073DAC File Offset: 0x00071FAC
		Private Function GetMappingList(dt As DataTable) As String
			Dim text As String = ""
			Dim num As Integer = dt.Rows.Count - 1
			For i As Integer = 0 To num
				text = Conversions.ToString(Operators.AddObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dt.Rows(i)("ProductBarcode"), " => "), dt.Rows(i)("LocationCode")), vbCrLf)))
			Next
			Return text
		End Function

		' Token: 0x06000BE9 RID: 3049 RVA: 0x00073E30 File Offset: 0x00072030
		Private Sub btnRpt_Click(sender As Object, e As EventArgs)
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("DataField")
			dataTable.Rows.Add(New Object(-1) {})
			dataTable.Rows(dataTable.Rows.Count - 1)("DataField") = Me.txt1.Text
			Dim reportCrystal As ReportCrystal = New ReportCrystal("Test", dataTable)
			reportCrystal.Show()
			MyBase.Close()
		End Sub

		' Token: 0x06000BEA RID: 3050 RVA: 0x00073EB0 File Offset: 0x000720B0
		Private Sub btnCon_Click(sender As Object, e As EventArgs)
			Dim text As String = " SELECT R.Department, '01/Jul/2024' AS StartDt, '31/Jul/2024' AS EndDt, " & vbCrLf
			text += " P.ProductType, P.ProductName, U.BatchNo, U.ExpDt,  " & vbCrLf
			text += " COUNT(ID.UID) AS Quantity, U.Price AS Rate, COUNT(ID.UID) * U.Price AS Value " & vbCrLf
			text += " FROM Issue AS I  " & vbCrLf
			text += " INNER JOIN IssueDtls AS ID ON I.IssueID = ID.IssueID " & vbCrLf
			text += " INNER JOIN Product AS P ON ID.ProductID = P.ProductID " & vbCrLf
			text += " INNER JOIN GRNUID AS U ON ID.UID = U.UID " & vbCrLf
			text += " INNER JOIN Request AS R ON I.RequestID = R.RequestID  " & vbCrLf
			text += " WHERE I.IssuedDt BETWEEN '07/01/2024 00:00:00' AND '07/31/2024 23:59:59' " & vbCrLf
			text += " GROUP BY R.Department, P.ProductType, P.ProductName, U.BatchNo, U.ExpDt, U.Price " & vbCrLf
			text += " ORDER BY R.Department, P.ProductType, P.ProductName, U.BatchNo " & vbCrLf
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim reportCrystal As ReportCrystal = New ReportCrystal("Consumption", data)
				reportCrystal.Show()
				MyBase.Close()
			End If
		End Sub
	End Class
End Namespace
