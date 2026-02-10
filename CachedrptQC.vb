Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.[Shared]

Namespace Datasoft_PIMS
	' Token: 0x02000045 RID: 69
	<ToolboxBitmap(GetType(ExportOptions), "report.bmp")>
	Public Class CachedrptQC
		Inherits Component
		Implements ICachedReport

		' Token: 0x170004D0 RID: 1232
		' (get) Token: 0x06000CC2 RID: 3266 RVA: 0x00075730 File Offset: 0x00073930
		' (set) Token: 0x06000CC3 RID: 3267 RVA: 0x00075743 File Offset: 0x00073943
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property IsCacheable As Boolean Implements CrystalDecisions.ReportSource.ICachedReport.IsCacheable
			Get
				Return True
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x170004D1 RID: 1233
		' (get) Token: 0x06000CC4 RID: 3268 RVA: 0x00075748 File Offset: 0x00073948
		' (set) Token: 0x06000CC5 RID: 3269 RVA: 0x0007575B File Offset: 0x0007395B
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property ShareDBLogonInfo As Boolean Implements CrystalDecisions.ReportSource.ICachedReport.ShareDBLogonInfo
			Get
				Return False
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x170004D2 RID: 1234
		' (get) Token: 0x06000CC6 RID: 3270 RVA: 0x00075760 File Offset: 0x00073960
		' (set) Token: 0x06000CC7 RID: 3271 RVA: 0x00075777 File Offset: 0x00073977
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property CacheTimeOut As TimeSpan Implements CrystalDecisions.ReportSource.ICachedReport.CacheTimeOut
			Get
				Return CachedReportConstants.DEFAULT_TIMEOUT
			End Get
			Set(value As TimeSpan)
			End Set
		End Property

		' Token: 0x06000CC8 RID: 3272 RVA: 0x0007577C File Offset: 0x0007397C
		Public Overridable Function CreateReport() As ReportDocument Implements CrystalDecisions.ReportSource.ICachedReport.CreateReport
			Return New rptQC() With { .Site = Me.Site }
		End Function

		' Token: 0x06000CC9 RID: 3273 RVA: 0x000757A4 File Offset: 0x000739A4
		Public Overridable Function GetCustomizedCacheKey(request As RequestContext) As String Implements CrystalDecisions.ReportSource.ICachedReport.GetCustomizedCacheKey
			Return Nothing
		End Function
	End Class
End Namespace
