Imports System
Imports System.ComponentModel
Imports CrystalDecisions.CrystalReports.Engine

Namespace Datasoft_PIMS
	' Token: 0x02000035 RID: 53
	Public Class rptPO04Bkp
		Inherits ReportClass

		' Token: 0x1700044A RID: 1098
		' (get) Token: 0x06000BEC RID: 3052 RVA: 0x00073F7C File Offset: 0x0007217C
		' (set) Token: 0x06000BED RID: 3053 RVA: 0x00073F93 File Offset: 0x00072193
		Public Overrides Property ResourceName As String
			Get
				Return "rptPO04Bkp.rpt"
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x1700044B RID: 1099
		' (get) Token: 0x06000BEE RID: 3054 RVA: 0x00073F98 File Offset: 0x00072198
		' (set) Token: 0x06000BEF RID: 3055 RVA: 0x00073FAB File Offset: 0x000721AB
		Public Overrides Property NewGenerator As Boolean
			Get
				Return True
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x1700044C RID: 1100
		' (get) Token: 0x06000BF0 RID: 3056 RVA: 0x00073FB0 File Offset: 0x000721B0
		' (set) Token: 0x06000BF1 RID: 3057 RVA: 0x00073FC7 File Offset: 0x000721C7
		Public Overrides Property FullResourceName As String
			Get
				Return "Datasoft_PIMS.rptPO04Bkp.rpt"
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x1700044D RID: 1101
		' (get) Token: 0x06000BF2 RID: 3058 RVA: 0x00073FCC File Offset: 0x000721CC
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section1 As Section
			Get
				Return Me.ReportDefinition.Sections(0)
			End Get
		End Property

		' Token: 0x1700044E RID: 1102
		' (get) Token: 0x06000BF3 RID: 3059 RVA: 0x00073FF0 File Offset: 0x000721F0
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section2 As Section
			Get
				Return Me.ReportDefinition.Sections(1)
			End Get
		End Property

		' Token: 0x1700044F RID: 1103
		' (get) Token: 0x06000BF4 RID: 3060 RVA: 0x00074014 File Offset: 0x00072214
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property PageHeaderSection2 As Section
			Get
				Return Me.ReportDefinition.Sections(2)
			End Get
		End Property

		' Token: 0x17000450 RID: 1104
		' (get) Token: 0x06000BF5 RID: 3061 RVA: 0x00074038 File Offset: 0x00072238
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property PageHeaderSection3 As Section
			Get
				Return Me.ReportDefinition.Sections(3)
			End Get
		End Property

		' Token: 0x17000451 RID: 1105
		' (get) Token: 0x06000BF6 RID: 3062 RVA: 0x0007405C File Offset: 0x0007225C
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section3 As Section
			Get
				Return Me.ReportDefinition.Sections(4)
			End Get
		End Property

		' Token: 0x17000452 RID: 1106
		' (get) Token: 0x06000BF7 RID: 3063 RVA: 0x00074080 File Offset: 0x00072280
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property DetailSection2 As Section
			Get
				Return Me.ReportDefinition.Sections(5)
			End Get
		End Property

		' Token: 0x17000453 RID: 1107
		' (get) Token: 0x06000BF8 RID: 3064 RVA: 0x000740A4 File Offset: 0x000722A4
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section4 As Section
			Get
				Return Me.ReportDefinition.Sections(6)
			End Get
		End Property

		' Token: 0x17000454 RID: 1108
		' (get) Token: 0x06000BF9 RID: 3065 RVA: 0x000740C8 File Offset: 0x000722C8
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property ReportFooterSection7 As Section
			Get
				Return Me.ReportDefinition.Sections(7)
			End Get
		End Property

		' Token: 0x17000455 RID: 1109
		' (get) Token: 0x06000BFA RID: 3066 RVA: 0x000740EC File Offset: 0x000722EC
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property ReportFooterSection8 As Section
			Get
				Return Me.ReportDefinition.Sections(8)
			End Get
		End Property

		' Token: 0x17000456 RID: 1110
		' (get) Token: 0x06000BFB RID: 3067 RVA: 0x00074110 File Offset: 0x00072310
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property ReportFooterSection9 As Section
			Get
				Return Me.ReportDefinition.Sections(9)
			End Get
		End Property

		' Token: 0x17000457 RID: 1111
		' (get) Token: 0x06000BFC RID: 3068 RVA: 0x00074134 File Offset: 0x00072334
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property ReportFooterSection10 As Section
			Get
				Return Me.ReportDefinition.Sections(10)
			End Get
		End Property

		' Token: 0x17000458 RID: 1112
		' (get) Token: 0x06000BFD RID: 3069 RVA: 0x00074158 File Offset: 0x00072358
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property ReportFooterSection11 As Section
			Get
				Return Me.ReportDefinition.Sections(11)
			End Get
		End Property

		' Token: 0x17000459 RID: 1113
		' (get) Token: 0x06000BFE RID: 3070 RVA: 0x0007417C File Offset: 0x0007237C
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property ReportFooterSection12 As Section
			Get
				Return Me.ReportDefinition.Sections(12)
			End Get
		End Property

		' Token: 0x1700045A RID: 1114
		' (get) Token: 0x06000BFF RID: 3071 RVA: 0x000741A0 File Offset: 0x000723A0
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property PageFooterSection11 As Section
			Get
				Return Me.ReportDefinition.Sections(13)
			End Get
		End Property

		' Token: 0x1700045B RID: 1115
		' (get) Token: 0x06000C00 RID: 3072 RVA: 0x000741C4 File Offset: 0x000723C4
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property PageFooterSection3 As Section
			Get
				Return Me.ReportDefinition.Sections(14)
			End Get
		End Property
	End Class
End Namespace
