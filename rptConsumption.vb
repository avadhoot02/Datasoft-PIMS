Imports System
Imports System.ComponentModel
Imports CrystalDecisions.CrystalReports.Engine

Namespace Datasoft_PIMS
	' Token: 0x0200003D RID: 61
	Public Class rptConsumption
		Inherits ReportClass

		' Token: 0x17000493 RID: 1171
		' (get) Token: 0x06000C5D RID: 3165 RVA: 0x00074A20 File Offset: 0x00072C20
		' (set) Token: 0x06000C5E RID: 3166 RVA: 0x00074A37 File Offset: 0x00072C37
		Public Overrides Property ResourceName As String
			Get
				Return "rptConsumption.rpt"
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x17000494 RID: 1172
		' (get) Token: 0x06000C5F RID: 3167 RVA: 0x00074A3C File Offset: 0x00072C3C
		' (set) Token: 0x06000C60 RID: 3168 RVA: 0x00074A4F File Offset: 0x00072C4F
		Public Overrides Property NewGenerator As Boolean
			Get
				Return True
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x17000495 RID: 1173
		' (get) Token: 0x06000C61 RID: 3169 RVA: 0x00074A54 File Offset: 0x00072C54
		' (set) Token: 0x06000C62 RID: 3170 RVA: 0x00074A6B File Offset: 0x00072C6B
		Public Overrides Property FullResourceName As String
			Get
				Return "Datasoft_PIMS.rptConsumption.rpt"
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x17000496 RID: 1174
		' (get) Token: 0x06000C63 RID: 3171 RVA: 0x00074A70 File Offset: 0x00072C70
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section1 As Section
			Get
				Return Me.ReportDefinition.Sections(0)
			End Get
		End Property

		' Token: 0x17000497 RID: 1175
		' (get) Token: 0x06000C64 RID: 3172 RVA: 0x00074A94 File Offset: 0x00072C94
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section2 As Section
			Get
				Return Me.ReportDefinition.Sections(1)
			End Get
		End Property

		' Token: 0x17000498 RID: 1176
		' (get) Token: 0x06000C65 RID: 3173 RVA: 0x00074AB8 File Offset: 0x00072CB8
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property GroupHeaderSection1 As Section
			Get
				Return Me.ReportDefinition.Sections(2)
			End Get
		End Property

		' Token: 0x17000499 RID: 1177
		' (get) Token: 0x06000C66 RID: 3174 RVA: 0x00074ADC File Offset: 0x00072CDC
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property GroupHeaderSection2 As Section
			Get
				Return Me.ReportDefinition.Sections(3)
			End Get
		End Property

		' Token: 0x1700049A RID: 1178
		' (get) Token: 0x06000C67 RID: 3175 RVA: 0x00074B00 File Offset: 0x00072D00
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property GroupHeaderSection3 As Section
			Get
				Return Me.ReportDefinition.Sections(4)
			End Get
		End Property

		' Token: 0x1700049B RID: 1179
		' (get) Token: 0x06000C68 RID: 3176 RVA: 0x00074B24 File Offset: 0x00072D24
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section3 As Section
			Get
				Return Me.ReportDefinition.Sections(5)
			End Get
		End Property

		' Token: 0x1700049C RID: 1180
		' (get) Token: 0x06000C69 RID: 3177 RVA: 0x00074B48 File Offset: 0x00072D48
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property GroupFooterSection3 As Section
			Get
				Return Me.ReportDefinition.Sections(6)
			End Get
		End Property

		' Token: 0x1700049D RID: 1181
		' (get) Token: 0x06000C6A RID: 3178 RVA: 0x00074B6C File Offset: 0x00072D6C
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property GroupFooterSection2 As Section
			Get
				Return Me.ReportDefinition.Sections(7)
			End Get
		End Property

		' Token: 0x1700049E RID: 1182
		' (get) Token: 0x06000C6B RID: 3179 RVA: 0x00074B90 File Offset: 0x00072D90
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property GroupFooterSection1 As Section
			Get
				Return Me.ReportDefinition.Sections(8)
			End Get
		End Property

		' Token: 0x1700049F RID: 1183
		' (get) Token: 0x06000C6C RID: 3180 RVA: 0x00074BB4 File Offset: 0x00072DB4
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section4 As Section
			Get
				Return Me.ReportDefinition.Sections(9)
			End Get
		End Property

		' Token: 0x170004A0 RID: 1184
		' (get) Token: 0x06000C6D RID: 3181 RVA: 0x00074BD8 File Offset: 0x00072DD8
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section5 As Section
			Get
				Return Me.ReportDefinition.Sections(10)
			End Get
		End Property
	End Class
End Namespace
