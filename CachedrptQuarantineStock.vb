Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.[Shared]

Namespace Datasoft_PIMS
	' Token: 0x0200003A RID: 58
	<ToolboxBitmap(GetType(ExportOptions), "report.bmp")>
	Public Class CachedrptQuarantineStock
		Inherits Component
		Implements ICachedReport

		' Token: 0x17000481 RID: 1153
		' (get) Token: 0x06000C3B RID: 3131 RVA: 0x00074758 File Offset: 0x00072958
		' (set) Token: 0x06000C3C RID: 3132 RVA: 0x0007476B File Offset: 0x0007296B
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property IsCacheable As Boolean Implements CrystalDecisions.ReportSource.ICachedReport.IsCacheable
			Get
				Return True
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x17000482 RID: 1154
		' (get) Token: 0x06000C3D RID: 3133 RVA: 0x00074770 File Offset: 0x00072970
		' (set) Token: 0x06000C3E RID: 3134 RVA: 0x00074783 File Offset: 0x00072983
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property ShareDBLogonInfo As Boolean Implements CrystalDecisions.ReportSource.ICachedReport.ShareDBLogonInfo
			Get
				Return False
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x17000483 RID: 1155
		' (get) Token: 0x06000C3F RID: 3135 RVA: 0x00074788 File Offset: 0x00072988
		' (set) Token: 0x06000C40 RID: 3136 RVA: 0x0007479F File Offset: 0x0007299F
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property CacheTimeOut As TimeSpan Implements CrystalDecisions.ReportSource.ICachedReport.CacheTimeOut
			Get
				Return CachedReportConstants.DEFAULT_TIMEOUT
			End Get
			Set(value As TimeSpan)
			End Set
		End Property

		' Token: 0x06000C41 RID: 3137 RVA: 0x000747A4 File Offset: 0x000729A4
		Public Overridable Function CreateReport() As ReportDocument Implements CrystalDecisions.ReportSource.ICachedReport.CreateReport
			Return New rptQuarantineStock() With { .Site = Me.Site }
		End Function

		' Token: 0x06000C42 RID: 3138 RVA: 0x000747CC File Offset: 0x000729CC
		Public Overridable Function GetCustomizedCacheKey(request As RequestContext) As String Implements CrystalDecisions.ReportSource.ICachedReport.GetCustomizedCacheKey
			Return Nothing
		End Function
	End Class
End Namespace
