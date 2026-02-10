Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.[Shared]

Namespace Datasoft_PIMS
	' Token: 0x02000047 RID: 71
	<ToolboxBitmap(GetType(ExportOptions), "report.bmp")>
	Public Class CachedrptTest
		Inherits Component
		Implements ICachedReport

		' Token: 0x170004DB RID: 1243
		' (get) Token: 0x06000CD7 RID: 3287 RVA: 0x000758D4 File Offset: 0x00073AD4
		' (set) Token: 0x06000CD8 RID: 3288 RVA: 0x000758E7 File Offset: 0x00073AE7
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property IsCacheable As Boolean Implements CrystalDecisions.ReportSource.ICachedReport.IsCacheable
			Get
				Return True
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x170004DC RID: 1244
		' (get) Token: 0x06000CD9 RID: 3289 RVA: 0x000758EC File Offset: 0x00073AEC
		' (set) Token: 0x06000CDA RID: 3290 RVA: 0x000758FF File Offset: 0x00073AFF
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property ShareDBLogonInfo As Boolean Implements CrystalDecisions.ReportSource.ICachedReport.ShareDBLogonInfo
			Get
				Return False
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x170004DD RID: 1245
		' (get) Token: 0x06000CDB RID: 3291 RVA: 0x00075904 File Offset: 0x00073B04
		' (set) Token: 0x06000CDC RID: 3292 RVA: 0x0007591B File Offset: 0x00073B1B
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property CacheTimeOut As TimeSpan Implements CrystalDecisions.ReportSource.ICachedReport.CacheTimeOut
			Get
				Return CachedReportConstants.DEFAULT_TIMEOUT
			End Get
			Set(value As TimeSpan)
			End Set
		End Property

		' Token: 0x06000CDD RID: 3293 RVA: 0x00075920 File Offset: 0x00073B20
		Public Overridable Function CreateReport() As ReportDocument Implements CrystalDecisions.ReportSource.ICachedReport.CreateReport
			Return New rptTest() With { .Site = Me.Site }
		End Function

		' Token: 0x06000CDE RID: 3294 RVA: 0x00075948 File Offset: 0x00073B48
		Public Overridable Function GetCustomizedCacheKey(request As RequestContext) As String Implements CrystalDecisions.ReportSource.ICachedReport.GetCustomizedCacheKey
			Return Nothing
		End Function
	End Class
End Namespace
