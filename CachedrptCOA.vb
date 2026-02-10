Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.[Shared]

Namespace Datasoft_PIMS
	' Token: 0x0200001B RID: 27
	<ToolboxBitmap(GetType(ExportOptions), "report.bmp")>
	Public Class CachedrptCOA
		Inherits Component
		Implements ICachedReport

		' Token: 0x17000198 RID: 408
		' (get) Token: 0x0600043C RID: 1084 RVA: 0x0002837C File Offset: 0x0002657C
		' (set) Token: 0x0600043D RID: 1085 RVA: 0x0002838F File Offset: 0x0002658F
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property IsCacheable As Boolean Implements CrystalDecisions.ReportSource.ICachedReport.IsCacheable
			Get
				Return True
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x17000199 RID: 409
		' (get) Token: 0x0600043E RID: 1086 RVA: 0x00028394 File Offset: 0x00026594
		' (set) Token: 0x0600043F RID: 1087 RVA: 0x000283A7 File Offset: 0x000265A7
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property ShareDBLogonInfo As Boolean Implements CrystalDecisions.ReportSource.ICachedReport.ShareDBLogonInfo
			Get
				Return False
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x1700019A RID: 410
		' (get) Token: 0x06000440 RID: 1088 RVA: 0x000283AC File Offset: 0x000265AC
		' (set) Token: 0x06000441 RID: 1089 RVA: 0x000283C3 File Offset: 0x000265C3
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property CacheTimeOut As TimeSpan Implements CrystalDecisions.ReportSource.ICachedReport.CacheTimeOut
			Get
				Return CachedReportConstants.DEFAULT_TIMEOUT
			End Get
			Set(value As TimeSpan)
			End Set
		End Property

		' Token: 0x06000442 RID: 1090 RVA: 0x000283C8 File Offset: 0x000265C8
		Public Overridable Function CreateReport() As ReportDocument Implements CrystalDecisions.ReportSource.ICachedReport.CreateReport
			Return New rptCOA() With { .Site = Me.Site }
		End Function

		' Token: 0x06000443 RID: 1091 RVA: 0x000283F0 File Offset: 0x000265F0
		Public Overridable Function GetCustomizedCacheKey(request As RequestContext) As String Implements CrystalDecisions.ReportSource.ICachedReport.GetCustomizedCacheKey
			Return Nothing
		End Function
	End Class
End Namespace
