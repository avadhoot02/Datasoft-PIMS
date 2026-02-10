Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.[Shared]

Namespace Datasoft_PIMS
	' Token: 0x0200003E RID: 62
	<ToolboxBitmap(GetType(ExportOptions), "report.bmp")>
	Public Class CachedrptConsumption
		Inherits Component
		Implements ICachedReport

		' Token: 0x170004A1 RID: 1185
		' (get) Token: 0x06000C6F RID: 3183 RVA: 0x00074C08 File Offset: 0x00072E08
		' (set) Token: 0x06000C70 RID: 3184 RVA: 0x00074C1B File Offset: 0x00072E1B
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property IsCacheable As Boolean Implements CrystalDecisions.ReportSource.ICachedReport.IsCacheable
			Get
				Return True
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x170004A2 RID: 1186
		' (get) Token: 0x06000C71 RID: 3185 RVA: 0x00074C20 File Offset: 0x00072E20
		' (set) Token: 0x06000C72 RID: 3186 RVA: 0x00074C33 File Offset: 0x00072E33
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property ShareDBLogonInfo As Boolean Implements CrystalDecisions.ReportSource.ICachedReport.ShareDBLogonInfo
			Get
				Return False
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x170004A3 RID: 1187
		' (get) Token: 0x06000C73 RID: 3187 RVA: 0x00074C38 File Offset: 0x00072E38
		' (set) Token: 0x06000C74 RID: 3188 RVA: 0x00074C4F File Offset: 0x00072E4F
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property CacheTimeOut As TimeSpan Implements CrystalDecisions.ReportSource.ICachedReport.CacheTimeOut
			Get
				Return CachedReportConstants.DEFAULT_TIMEOUT
			End Get
			Set(value As TimeSpan)
			End Set
		End Property

		' Token: 0x06000C75 RID: 3189 RVA: 0x00074C54 File Offset: 0x00072E54
		Public Overridable Function CreateReport() As ReportDocument Implements CrystalDecisions.ReportSource.ICachedReport.CreateReport
			Return New rptConsumption() With { .Site = Me.Site }
		End Function

		' Token: 0x06000C76 RID: 3190 RVA: 0x00074C7C File Offset: 0x00072E7C
		Public Overridable Function GetCustomizedCacheKey(request As RequestContext) As String Implements CrystalDecisions.ReportSource.ICachedReport.GetCustomizedCacheKey
			Return Nothing
		End Function
	End Class
End Namespace
