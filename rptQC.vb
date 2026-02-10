Imports System
Imports System.ComponentModel
Imports CrystalDecisions.CrystalReports.Engine

Namespace Datasoft_PIMS
	' Token: 0x02000044 RID: 68
	Public Class rptQC
		Inherits ReportClass

		' Token: 0x170004C3 RID: 1219
		' (get) Token: 0x06000CB1 RID: 3249 RVA: 0x0007556C File Offset: 0x0007376C
		' (set) Token: 0x06000CB2 RID: 3250 RVA: 0x00075583 File Offset: 0x00073783
		Public Overrides Property ResourceName As String
			Get
				Return "rptQC.rpt"
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x170004C4 RID: 1220
		' (get) Token: 0x06000CB3 RID: 3251 RVA: 0x00075588 File Offset: 0x00073788
		' (set) Token: 0x06000CB4 RID: 3252 RVA: 0x0007559B File Offset: 0x0007379B
		Public Overrides Property NewGenerator As Boolean
			Get
				Return True
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x170004C5 RID: 1221
		' (get) Token: 0x06000CB5 RID: 3253 RVA: 0x000755A0 File Offset: 0x000737A0
		' (set) Token: 0x06000CB6 RID: 3254 RVA: 0x000755B7 File Offset: 0x000737B7
		Public Overrides Property FullResourceName As String
			Get
				Return "Datasoft_PIMS.rptQC.rpt"
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x170004C6 RID: 1222
		' (get) Token: 0x06000CB7 RID: 3255 RVA: 0x000755BC File Offset: 0x000737BC
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section1 As Section
			Get
				Return Me.ReportDefinition.Sections(0)
			End Get
		End Property

		' Token: 0x170004C7 RID: 1223
		' (get) Token: 0x06000CB8 RID: 3256 RVA: 0x000755E0 File Offset: 0x000737E0
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section2 As Section
			Get
				Return Me.ReportDefinition.Sections(1)
			End Get
		End Property

		' Token: 0x170004C8 RID: 1224
		' (get) Token: 0x06000CB9 RID: 3257 RVA: 0x00075604 File Offset: 0x00073804
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property PageHeaderSection2 As Section
			Get
				Return Me.ReportDefinition.Sections(2)
			End Get
		End Property

		' Token: 0x170004C9 RID: 1225
		' (get) Token: 0x06000CBA RID: 3258 RVA: 0x00075628 File Offset: 0x00073828
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property PageHeaderSection3 As Section
			Get
				Return Me.ReportDefinition.Sections(3)
			End Get
		End Property

		' Token: 0x170004CA RID: 1226
		' (get) Token: 0x06000CBB RID: 3259 RVA: 0x0007564C File Offset: 0x0007384C
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section3 As Section
			Get
				Return Me.ReportDefinition.Sections(4)
			End Get
		End Property

		' Token: 0x170004CB RID: 1227
		' (get) Token: 0x06000CBC RID: 3260 RVA: 0x00075670 File Offset: 0x00073870
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property DetailSection2 As Section
			Get
				Return Me.ReportDefinition.Sections(5)
			End Get
		End Property

		' Token: 0x170004CC RID: 1228
		' (get) Token: 0x06000CBD RID: 3261 RVA: 0x00075694 File Offset: 0x00073894
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section4 As Section
			Get
				Return Me.ReportDefinition.Sections(6)
			End Get
		End Property

		' Token: 0x170004CD RID: 1229
		' (get) Token: 0x06000CBE RID: 3262 RVA: 0x000756B8 File Offset: 0x000738B8
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section5 As Section
			Get
				Return Me.ReportDefinition.Sections(7)
			End Get
		End Property

		' Token: 0x170004CE RID: 1230
		' (get) Token: 0x06000CBF RID: 3263 RVA: 0x000756DC File Offset: 0x000738DC
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property PageFooterSection3 As Section
			Get
				Return Me.ReportDefinition.Sections(8)
			End Get
		End Property

		' Token: 0x170004CF RID: 1231
		' (get) Token: 0x06000CC0 RID: 3264 RVA: 0x00075700 File Offset: 0x00073900
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property PageFooterSection2 As Section
			Get
				Return Me.ReportDefinition.Sections(9)
			End Get
		End Property
	End Class
End Namespace
