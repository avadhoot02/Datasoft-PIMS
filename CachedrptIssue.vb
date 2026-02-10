Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.[Shared]

Namespace Datasoft_PIMS
	' Token: 0x02000040 RID: 64
	<ToolboxBitmap(GetType(ExportOptions), "report.bmp")>
	Public Class CachedrptIssue
		Inherits Component
		Implements ICachedReport

		' Token: 0x170004B0 RID: 1200
		' (get) Token: 0x06000C88 RID: 3208 RVA: 0x00074E3C File Offset: 0x0007303C
		' (set) Token: 0x06000C89 RID: 3209 RVA: 0x00074E4F File Offset: 0x0007304F
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property IsCacheable As Boolean Implements CrystalDecisions.ReportSource.ICachedReport.IsCacheable
			Get
				Return True
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x170004B1 RID: 1201
		' (get) Token: 0x06000C8A RID: 3210 RVA: 0x00074E54 File Offset: 0x00073054
		' (set) Token: 0x06000C8B RID: 3211 RVA: 0x00074E67 File Offset: 0x00073067
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property ShareDBLogonInfo As Boolean Implements CrystalDecisions.ReportSource.ICachedReport.ShareDBLogonInfo
			Get
				Return False
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x170004B2 RID: 1202
		' (get) Token: 0x06000C8C RID: 3212 RVA: 0x00074E6C File Offset: 0x0007306C
		' (set) Token: 0x06000C8D RID: 3213 RVA: 0x00074E83 File Offset: 0x00073083
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property CacheTimeOut As TimeSpan Implements CrystalDecisions.ReportSource.ICachedReport.CacheTimeOut
			Get
				Return CachedReportConstants.DEFAULT_TIMEOUT
			End Get
			Set(value As TimeSpan)
			End Set
		End Property

		' Token: 0x06000C8E RID: 3214 RVA: 0x00074E88 File Offset: 0x00073088
		Public Overridable Function CreateReport() As ReportDocument Implements CrystalDecisions.ReportSource.ICachedReport.CreateReport
			Return New rptIssue() With { .Site = Me.Site }
		End Function

		' Token: 0x06000C8F RID: 3215 RVA: 0x00074EB0 File Offset: 0x000730B0
		Public Overridable Function GetCustomizedCacheKey(request As RequestContext) As String Implements CrystalDecisions.ReportSource.ICachedReport.GetCustomizedCacheKey
			Return Nothing
		End Function
	End Class
End Namespace
