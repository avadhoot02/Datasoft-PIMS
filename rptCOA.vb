Imports System
Imports System.ComponentModel
Imports CrystalDecisions.CrystalReports.Engine

Namespace Datasoft_PIMS
	' Token: 0x0200001A RID: 26
	Public Class rptCOA
		Inherits ReportClass

		' Token: 0x1700018E RID: 398
		' (get) Token: 0x0600042E RID: 1070 RVA: 0x00028224 File Offset: 0x00026424
		' (set) Token: 0x0600042F RID: 1071 RVA: 0x0002823B File Offset: 0x0002643B
		Public Overrides Property ResourceName As String
			Get
				Return "rptCOA.rpt"
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x1700018F RID: 399
		' (get) Token: 0x06000430 RID: 1072 RVA: 0x00028240 File Offset: 0x00026440
		' (set) Token: 0x06000431 RID: 1073 RVA: 0x00028253 File Offset: 0x00026453
		Public Overrides Property NewGenerator As Boolean
			Get
				Return True
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x17000190 RID: 400
		' (get) Token: 0x06000432 RID: 1074 RVA: 0x00028258 File Offset: 0x00026458
		' (set) Token: 0x06000433 RID: 1075 RVA: 0x0002826F File Offset: 0x0002646F
		Public Overrides Property FullResourceName As String
			Get
				Return "Datasoft_PIMS.rptCOA.rpt"
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x17000191 RID: 401
		' (get) Token: 0x06000434 RID: 1076 RVA: 0x00028274 File Offset: 0x00026474
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section1 As Section
			Get
				Return Me.ReportDefinition.Sections(0)
			End Get
		End Property

		' Token: 0x17000192 RID: 402
		' (get) Token: 0x06000435 RID: 1077 RVA: 0x00028298 File Offset: 0x00026498
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section2 As Section
			Get
				Return Me.ReportDefinition.Sections(1)
			End Get
		End Property

		' Token: 0x17000193 RID: 403
		' (get) Token: 0x06000436 RID: 1078 RVA: 0x000282BC File Offset: 0x000264BC
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property PageHeaderSection2 As Section
			Get
				Return Me.ReportDefinition.Sections(2)
			End Get
		End Property

		' Token: 0x17000194 RID: 404
		' (get) Token: 0x06000437 RID: 1079 RVA: 0x000282E0 File Offset: 0x000264E0
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property PageHeaderSection3 As Section
			Get
				Return Me.ReportDefinition.Sections(3)
			End Get
		End Property

		' Token: 0x17000195 RID: 405
		' (get) Token: 0x06000438 RID: 1080 RVA: 0x00028304 File Offset: 0x00026504
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section3 As Section
			Get
				Return Me.ReportDefinition.Sections(4)
			End Get
		End Property

		' Token: 0x17000196 RID: 406
		' (get) Token: 0x06000439 RID: 1081 RVA: 0x00028328 File Offset: 0x00026528
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section4 As Section
			Get
				Return Me.ReportDefinition.Sections(5)
			End Get
		End Property

		' Token: 0x17000197 RID: 407
		' (get) Token: 0x0600043A RID: 1082 RVA: 0x0002834C File Offset: 0x0002654C
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section5 As Section
			Get
				Return Me.ReportDefinition.Sections(6)
			End Get
		End Property
	End Class
End Namespace
