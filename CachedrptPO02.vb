Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.[Shared]

Namespace Datasoft_PIMS
	' Token: 0x02000043 RID: 67
	<ToolboxBitmap(GetType(ExportOptions), "report.bmp")>
	Public Class CachedrptPO02
		Inherits Component
		Implements ICachedReport

		' Token: 0x170004C0 RID: 1216
		' (get) Token: 0x06000CA8 RID: 3240 RVA: 0x000754D8 File Offset: 0x000736D8
		' (set) Token: 0x06000CA9 RID: 3241 RVA: 0x000754EB File Offset: 0x000736EB
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property IsCacheable As Boolean Implements CrystalDecisions.ReportSource.ICachedReport.IsCacheable
			Get
				Return True
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x170004C1 RID: 1217
		' (get) Token: 0x06000CAA RID: 3242 RVA: 0x000754F0 File Offset: 0x000736F0
		' (set) Token: 0x06000CAB RID: 3243 RVA: 0x00075503 File Offset: 0x00073703
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property ShareDBLogonInfo As Boolean Implements CrystalDecisions.ReportSource.ICachedReport.ShareDBLogonInfo
			Get
				Return False
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x170004C2 RID: 1218
		' (get) Token: 0x06000CAC RID: 3244 RVA: 0x00075508 File Offset: 0x00073708
		' (set) Token: 0x06000CAD RID: 3245 RVA: 0x0007551F File Offset: 0x0007371F
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property CacheTimeOut As TimeSpan Implements CrystalDecisions.ReportSource.ICachedReport.CacheTimeOut
			Get
				Return CachedReportConstants.DEFAULT_TIMEOUT
			End Get
			Set(value As TimeSpan)
			End Set
		End Property

		' Token: 0x06000CAE RID: 3246 RVA: 0x00075524 File Offset: 0x00073724
		Public Overridable Function CreateReport() As ReportDocument Implements CrystalDecisions.ReportSource.ICachedReport.CreateReport
			Return New rptPO02() With { .Site = Me.Site }
		End Function

		' Token: 0x06000CAF RID: 3247 RVA: 0x0007554C File Offset: 0x0007374C
		Public Overridable Function GetCustomizedCacheKey(request As RequestContext) As String Implements CrystalDecisions.ReportSource.ICachedReport.GetCustomizedCacheKey
			Return Nothing
		End Function
	End Class
End Namespace
