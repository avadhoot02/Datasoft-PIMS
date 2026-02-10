Imports System
Imports System.ComponentModel
Imports CrystalDecisions.CrystalReports.Engine

Namespace Datasoft_PIMS
	' Token: 0x02000037 RID: 55
	Public Class rptPO04
		Inherits ReportClass

		' Token: 0x1700045F RID: 1119
		' (get) Token: 0x06000C0B RID: 3083 RVA: 0x00074288 File Offset: 0x00072488
		' (set) Token: 0x06000C0C RID: 3084 RVA: 0x0007429F File Offset: 0x0007249F
		Public Overrides Property ResourceName As String
			Get
				Return "rptPO04.rpt"
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x17000460 RID: 1120
		' (get) Token: 0x06000C0D RID: 3085 RVA: 0x000742A4 File Offset: 0x000724A4
		' (set) Token: 0x06000C0E RID: 3086 RVA: 0x000742B7 File Offset: 0x000724B7
		Public Overrides Property NewGenerator As Boolean
			Get
				Return True
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x17000461 RID: 1121
		' (get) Token: 0x06000C0F RID: 3087 RVA: 0x000742BC File Offset: 0x000724BC
		' (set) Token: 0x06000C10 RID: 3088 RVA: 0x000742D3 File Offset: 0x000724D3
		Public Overrides Property FullResourceName As String
			Get
				Return "Datasoft_PIMS.rptPO04.rpt"
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x17000462 RID: 1122
		' (get) Token: 0x06000C11 RID: 3089 RVA: 0x000742D8 File Offset: 0x000724D8
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section1 As Section
			Get
				Return Me.ReportDefinition.Sections(0)
			End Get
		End Property

		' Token: 0x17000463 RID: 1123
		' (get) Token: 0x06000C12 RID: 3090 RVA: 0x000742FC File Offset: 0x000724FC
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section2 As Section
			Get
				Return Me.ReportDefinition.Sections(1)
			End Get
		End Property

		' Token: 0x17000464 RID: 1124
		' (get) Token: 0x06000C13 RID: 3091 RVA: 0x00074320 File Offset: 0x00072520
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property PageHeaderSection2 As Section
			Get
				Return Me.ReportDefinition.Sections(2)
			End Get
		End Property

		' Token: 0x17000465 RID: 1125
		' (get) Token: 0x06000C14 RID: 3092 RVA: 0x00074344 File Offset: 0x00072544
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property PageHeaderSection3 As Section
			Get
				Return Me.ReportDefinition.Sections(3)
			End Get
		End Property

		' Token: 0x17000466 RID: 1126
		' (get) Token: 0x06000C15 RID: 3093 RVA: 0x00074368 File Offset: 0x00072568
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section3 As Section
			Get
				Return Me.ReportDefinition.Sections(4)
			End Get
		End Property

		' Token: 0x17000467 RID: 1127
		' (get) Token: 0x06000C16 RID: 3094 RVA: 0x0007438C File Offset: 0x0007258C
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property DetailSection2 As Section
			Get
				Return Me.ReportDefinition.Sections(5)
			End Get
		End Property

		' Token: 0x17000468 RID: 1128
		' (get) Token: 0x06000C17 RID: 3095 RVA: 0x000743B0 File Offset: 0x000725B0
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section4 As Section
			Get
				Return Me.ReportDefinition.Sections(6)
			End Get
		End Property

		' Token: 0x17000469 RID: 1129
		' (get) Token: 0x06000C18 RID: 3096 RVA: 0x000743D4 File Offset: 0x000725D4
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property ReportFooterSection7 As Section
			Get
				Return Me.ReportDefinition.Sections(7)
			End Get
		End Property

		' Token: 0x1700046A RID: 1130
		' (get) Token: 0x06000C19 RID: 3097 RVA: 0x000743F8 File Offset: 0x000725F8
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property ReportFooterSection8 As Section
			Get
				Return Me.ReportDefinition.Sections(8)
			End Get
		End Property

		' Token: 0x1700046B RID: 1131
		' (get) Token: 0x06000C1A RID: 3098 RVA: 0x0007441C File Offset: 0x0007261C
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property ReportFooterSection9 As Section
			Get
				Return Me.ReportDefinition.Sections(9)
			End Get
		End Property

		' Token: 0x1700046C RID: 1132
		' (get) Token: 0x06000C1B RID: 3099 RVA: 0x00074440 File Offset: 0x00072640
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property ReportFooterSection10 As Section
			Get
				Return Me.ReportDefinition.Sections(10)
			End Get
		End Property

		' Token: 0x1700046D RID: 1133
		' (get) Token: 0x06000C1C RID: 3100 RVA: 0x00074464 File Offset: 0x00072664
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property ReportFooterSection11 As Section
			Get
				Return Me.ReportDefinition.Sections(11)
			End Get
		End Property

		' Token: 0x1700046E RID: 1134
		' (get) Token: 0x06000C1D RID: 3101 RVA: 0x00074488 File Offset: 0x00072688
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property ReportFooterSection12 As Section
			Get
				Return Me.ReportDefinition.Sections(12)
			End Get
		End Property

		' Token: 0x1700046F RID: 1135
		' (get) Token: 0x06000C1E RID: 3102 RVA: 0x000744AC File Offset: 0x000726AC
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property PageFooterSection11 As Section
			Get
				Return Me.ReportDefinition.Sections(13)
			End Get
		End Property

		' Token: 0x17000470 RID: 1136
		' (get) Token: 0x06000C1F RID: 3103 RVA: 0x000744D0 File Offset: 0x000726D0
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property PageFooterSection2 As Section
			Get
				Return Me.ReportDefinition.Sections(14)
			End Get
		End Property

		' Token: 0x17000471 RID: 1137
		' (get) Token: 0x06000C20 RID: 3104 RVA: 0x000744F4 File Offset: 0x000726F4
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property PageFooterSection3 As Section
			Get
				Return Me.ReportDefinition.Sections(15)
			End Get
		End Property
	End Class
End Namespace
