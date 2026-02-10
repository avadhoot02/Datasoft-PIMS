Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms
Imports Datasoft_PIMS.My
Imports Microsoft.VisualBasic.CompilerServices
Imports WeifenLuo.WinFormsUI.Docking

Namespace Datasoft_PIMS
	' Token: 0x02000041 RID: 65
	<DesignerGenerated()>
	Public Partial Class ReportCrystal
		Inherits DockContent

		' Token: 0x170004B3 RID: 1203
		' (get) Token: 0x06000C92 RID: 3218 RVA: 0x000750BD File Offset: 0x000732BD
		' (set) Token: 0x06000C93 RID: 3219 RVA: 0x000750C7 File Offset: 0x000732C7
		Friend Overridable Property CrystalReportViewer1 As CrystalReportViewer

		' Token: 0x06000C94 RID: 3220 RVA: 0x000750D0 File Offset: 0x000732D0
		Public Sub New(sReport As String, dt As DataTable)
			AddHandler MyBase.Load, AddressOf Me.ReportCrystal_Load
			Me.InitializeComponent()
			Me.sReportName = sReport
			Me.Text = Me.sReportName + " Prinitng"
			MyBase.TabText = Me.sReportName + " Prinitng"
			Me.dtData = dt
		End Sub

		' Token: 0x06000C95 RID: 3221 RVA: 0x0007513B File Offset: 0x0007333B
		Private Sub ReportCrystal_Load(sender As Object, e As EventArgs)
			MyBase.Icon = MyProject.Forms.MDIMain.Icon
			Me.SetReport()
		End Sub

		' Token: 0x06000C96 RID: 3222 RVA: 0x0007515C File Offset: 0x0007335C
		Private Sub SetReport()
			Dim reportDocument As ReportDocument = New ReportDocument()
			Dim text As String = Me.sReportName
			Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(text)
			If num <= 812114866UI Then
				If num <> 570421568UI Then
					If num <> 805092869UI Then
						If num = 812114866UI Then
							If Operators.CompareString(text, "COA", False) = 0 Then
								reportDocument = New rptCOA()
								reportDocument.SetDataSource(Me.dtData)
							End If
						End If
					ElseIf Operators.CompareString(text, "Test", False) = 0 Then
						reportDocument = New rptTest()
						reportDocument.SetDataSource(Me.dtData)
					End If
				ElseIf Operators.CompareString(text, "PO", False) = 0 Then
					reportDocument = New rptPO04()
					reportDocument.SetDataSource(Me.dtData)
				End If
			ElseIf num <= 2222014164UI Then
				If num <> 1611175392UI Then
					If num = 2222014164UI Then
						If Operators.CompareString(text, "Consumption", False) = 0 Then
							reportDocument = New rptConsumption()
							reportDocument.SetDataSource(Me.dtData)
						End If
					End If
				ElseIf Operators.CompareString(text, "Issue", False) = 0 Then
					reportDocument = New rptIssue()
					reportDocument.SetDataSource(Me.dtData)
				End If
			ElseIf num <> 2382154157UI Then
				If num = 4192803228UI Then
					If Operators.CompareString(text, "PO4", False) = 0 Then
						reportDocument = New rptPO04()
						reportDocument.SetDataSource(Me.dtData)
					End If
				End If
			ElseIf Operators.CompareString(text, "QC", False) = 0 Then
				reportDocument = New rptQC()
				reportDocument.SetDataSource(Me.dtData)
			End If
			Me.CrystalReportViewer1.ReportSource = reportDocument
		End Sub

		' Token: 0x04000555 RID: 1365
		Private sReportName As String

		' Token: 0x04000556 RID: 1366
		Private dtData As DataTable
	End Class
End Namespace
