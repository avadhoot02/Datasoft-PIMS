Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.[Shared]

Namespace Datasoft_PIMS
	' Token: 0x0200003C RID: 60
	<ToolboxBitmap(GetType(ExportOptions), "report.bmp")>
	Public Class CachedrptClosingStock
		Inherits Component
		Implements ICachedReport

		' Token: 0x17000490 RID: 1168
		' (get) Token: 0x06000C54 RID: 3156 RVA: 0x0007498C File Offset: 0x00072B8C
		' (set) Token: 0x06000C55 RID: 3157 RVA: 0x0007499F File Offset: 0x00072B9F
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property IsCacheable As Boolean Implements CrystalDecisions.ReportSource.ICachedReport.IsCacheable
			Get
				Return True
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x17000491 RID: 1169
		' (get) Token: 0x06000C56 RID: 3158 RVA: 0x000749A4 File Offset: 0x00072BA4
		' (set) Token: 0x06000C57 RID: 3159 RVA: 0x000749B7 File Offset: 0x00072BB7
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property ShareDBLogonInfo As Boolean Implements CrystalDecisions.ReportSource.ICachedReport.ShareDBLogonInfo
			Get
				Return False
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x17000492 RID: 1170
		' (get) Token: 0x06000C58 RID: 3160 RVA: 0x000749BC File Offset: 0x00072BBC
		' (set) Token: 0x06000C59 RID: 3161 RVA: 0x000749D3 File Offset: 0x00072BD3
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property CacheTimeOut As TimeSpan Implements CrystalDecisions.ReportSource.ICachedReport.CacheTimeOut
			Get
				Return CachedReportConstants.DEFAULT_TIMEOUT
			End Get
			Set(value As TimeSpan)
			End Set
		End Property

		' Token: 0x06000C5A RID: 3162 RVA: 0x000749D8 File Offset: 0x00072BD8
		Public Overridable Function CreateReport() As ReportDocument Implements CrystalDecisions.ReportSource.ICachedReport.CreateReport
			Return New rptClosingStock() With { .Site = Me.Site }
		End Function

		' Token: 0x06000C5B RID: 3163 RVA: 0x00074A00 File Offset: 0x00072C00
		Public Overridable Function GetCustomizedCacheKey(request As RequestContext) As String Implements CrystalDecisions.ReportSource.ICachedReport.GetCustomizedCacheKey
			Return Nothing
		End Function
	End Class
End Namespace
