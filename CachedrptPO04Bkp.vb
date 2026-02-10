Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.[Shared]

Namespace Datasoft_PIMS
	' Token: 0x02000036 RID: 54
	<ToolboxBitmap(GetType(ExportOptions), "report.bmp")>
	Public Class CachedrptPO04Bkp
		Inherits Component
		Implements ICachedReport

		' Token: 0x1700045C RID: 1116
		' (get) Token: 0x06000C02 RID: 3074 RVA: 0x000741F4 File Offset: 0x000723F4
		' (set) Token: 0x06000C03 RID: 3075 RVA: 0x00074207 File Offset: 0x00072407
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property IsCacheable As Boolean Implements CrystalDecisions.ReportSource.ICachedReport.IsCacheable
			Get
				Return True
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x1700045D RID: 1117
		' (get) Token: 0x06000C04 RID: 3076 RVA: 0x0007420C File Offset: 0x0007240C
		' (set) Token: 0x06000C05 RID: 3077 RVA: 0x0007421F File Offset: 0x0007241F
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property ShareDBLogonInfo As Boolean Implements CrystalDecisions.ReportSource.ICachedReport.ShareDBLogonInfo
			Get
				Return False
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x1700045E RID: 1118
		' (get) Token: 0x06000C06 RID: 3078 RVA: 0x00074224 File Offset: 0x00072424
		' (set) Token: 0x06000C07 RID: 3079 RVA: 0x0007423B File Offset: 0x0007243B
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property CacheTimeOut As TimeSpan Implements CrystalDecisions.ReportSource.ICachedReport.CacheTimeOut
			Get
				Return CachedReportConstants.DEFAULT_TIMEOUT
			End Get
			Set(value As TimeSpan)
			End Set
		End Property

		' Token: 0x06000C08 RID: 3080 RVA: 0x00074240 File Offset: 0x00072440
		Public Overridable Function CreateReport() As ReportDocument Implements CrystalDecisions.ReportSource.ICachedReport.CreateReport
			Return New rptPO04Bkp() With { .Site = Me.Site }
		End Function

		' Token: 0x06000C09 RID: 3081 RVA: 0x00074268 File Offset: 0x00072468
		Public Overridable Function GetCustomizedCacheKey(request As RequestContext) As String Implements CrystalDecisions.ReportSource.ICachedReport.GetCustomizedCacheKey
			Return Nothing
		End Function
	End Class
End Namespace
