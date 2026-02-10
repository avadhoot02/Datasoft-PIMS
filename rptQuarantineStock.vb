Imports System
Imports System.ComponentModel
Imports CrystalDecisions.CrystalReports.Engine

Namespace Datasoft_PIMS
	' Token: 0x02000039 RID: 57
	Public Class rptQuarantineStock
		Inherits ReportClass

		' Token: 0x17000475 RID: 1141
		' (get) Token: 0x06000C2B RID: 3115 RVA: 0x000745B8 File Offset: 0x000727B8
		' (set) Token: 0x06000C2C RID: 3116 RVA: 0x000745CF File Offset: 0x000727CF
		Public Overrides Property ResourceName As String
			Get
				Return "rptQuarantineStock.rpt"
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x17000476 RID: 1142
		' (get) Token: 0x06000C2D RID: 3117 RVA: 0x000745D4 File Offset: 0x000727D4
		' (set) Token: 0x06000C2E RID: 3118 RVA: 0x000745E7 File Offset: 0x000727E7
		Public Overrides Property NewGenerator As Boolean
			Get
				Return True
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x17000477 RID: 1143
		' (get) Token: 0x06000C2F RID: 3119 RVA: 0x000745EC File Offset: 0x000727EC
		' (set) Token: 0x06000C30 RID: 3120 RVA: 0x00074603 File Offset: 0x00072803
		Public Overrides Property FullResourceName As String
			Get
				Return "Datasoft_PIMS.rptQuarantineStock.rpt"
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x17000478 RID: 1144
		' (get) Token: 0x06000C31 RID: 3121 RVA: 0x00074608 File Offset: 0x00072808
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section1 As Section
			Get
				Return Me.ReportDefinition.Sections(0)
			End Get
		End Property

		' Token: 0x17000479 RID: 1145
		' (get) Token: 0x06000C32 RID: 3122 RVA: 0x0007462C File Offset: 0x0007282C
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section2 As Section
			Get
				Return Me.ReportDefinition.Sections(1)
			End Get
		End Property

		' Token: 0x1700047A RID: 1146
		' (get) Token: 0x06000C33 RID: 3123 RVA: 0x00074650 File Offset: 0x00072850
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property GroupHeaderSection2 As Section
			Get
				Return Me.ReportDefinition.Sections(2)
			End Get
		End Property

		' Token: 0x1700047B RID: 1147
		' (get) Token: 0x06000C34 RID: 3124 RVA: 0x00074674 File Offset: 0x00072874
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property GroupHeaderSection3 As Section
			Get
				Return Me.ReportDefinition.Sections(3)
			End Get
		End Property

		' Token: 0x1700047C RID: 1148
		' (get) Token: 0x06000C35 RID: 3125 RVA: 0x00074698 File Offset: 0x00072898
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section3 As Section
			Get
				Return Me.ReportDefinition.Sections(4)
			End Get
		End Property

		' Token: 0x1700047D RID: 1149
		' (get) Token: 0x06000C36 RID: 3126 RVA: 0x000746BC File Offset: 0x000728BC
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property GroupFooterSection3 As Section
			Get
				Return Me.ReportDefinition.Sections(5)
			End Get
		End Property

		' Token: 0x1700047E RID: 1150
		' (get) Token: 0x06000C37 RID: 3127 RVA: 0x000746E0 File Offset: 0x000728E0
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property GroupFooterSection2 As Section
			Get
				Return Me.ReportDefinition.Sections(6)
			End Get
		End Property

		' Token: 0x1700047F RID: 1151
		' (get) Token: 0x06000C38 RID: 3128 RVA: 0x00074704 File Offset: 0x00072904
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section4 As Section
			Get
				Return Me.ReportDefinition.Sections(7)
			End Get
		End Property

		' Token: 0x17000480 RID: 1152
		' (get) Token: 0x06000C39 RID: 3129 RVA: 0x00074728 File Offset: 0x00072928
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section5 As Section
			Get
				Return Me.ReportDefinition.Sections(8)
			End Get
		End Property
	End Class
End Namespace
