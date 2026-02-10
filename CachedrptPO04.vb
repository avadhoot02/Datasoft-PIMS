Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.[Shared]

Namespace Datasoft_PIMS
	' Token: 0x02000038 RID: 56
	<ToolboxBitmap(GetType(ExportOptions), "report.bmp")>
	Public Class CachedrptPO04
		Inherits Component
		Implements ICachedReport

		' Token: 0x17000472 RID: 1138
		' (get) Token: 0x06000C22 RID: 3106 RVA: 0x00074524 File Offset: 0x00072724
		' (set) Token: 0x06000C23 RID: 3107 RVA: 0x00074537 File Offset: 0x00072737
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property IsCacheable As Boolean Implements CrystalDecisions.ReportSource.ICachedReport.IsCacheable
			Get
				Return True
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x17000473 RID: 1139
		' (get) Token: 0x06000C24 RID: 3108 RVA: 0x0007453C File Offset: 0x0007273C
		' (set) Token: 0x06000C25 RID: 3109 RVA: 0x0007454F File Offset: 0x0007274F
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property ShareDBLogonInfo As Boolean Implements CrystalDecisions.ReportSource.ICachedReport.ShareDBLogonInfo
			Get
				Return False
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x17000474 RID: 1140
		' (get) Token: 0x06000C26 RID: 3110 RVA: 0x00074554 File Offset: 0x00072754
		' (set) Token: 0x06000C27 RID: 3111 RVA: 0x0007456B File Offset: 0x0007276B
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public Overridable Property CacheTimeOut As TimeSpan Implements CrystalDecisions.ReportSource.ICachedReport.CacheTimeOut
			Get
				Return CachedReportConstants.DEFAULT_TIMEOUT
			End Get
			Set(value As TimeSpan)
			End Set
		End Property

		' Token: 0x06000C28 RID: 3112 RVA: 0x00074570 File Offset: 0x00072770
		Public Overridable Function CreateReport() As ReportDocument Implements CrystalDecisions.ReportSource.ICachedReport.CreateReport
			Return New rptPO04() With { .Site = Me.Site }
		End Function

		' Token: 0x06000C29 RID: 3113 RVA: 0x00074598 File Offset: 0x00072798
		Public Overridable Function GetCustomizedCacheKey(request As RequestContext) As String Implements CrystalDecisions.ReportSource.ICachedReport.GetCustomizedCacheKey
			Return Nothing
		End Function
	End Class
End Namespace
