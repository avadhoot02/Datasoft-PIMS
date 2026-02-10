Imports System
Imports System.ComponentModel
Imports CrystalDecisions.CrystalReports.Engine

Namespace Datasoft_PIMS
	' Token: 0x0200003F RID: 63
	Public Class rptIssue
		Inherits ReportClass

		' Token: 0x170004A4 RID: 1188
		' (get) Token: 0x06000C78 RID: 3192 RVA: 0x00074C9C File Offset: 0x00072E9C
		' (set) Token: 0x06000C79 RID: 3193 RVA: 0x00074CB3 File Offset: 0x00072EB3
		Public Overrides Property ResourceName As String
			Get
				Return "rptIssue.rpt"
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x170004A5 RID: 1189
		' (get) Token: 0x06000C7A RID: 3194 RVA: 0x00074CB8 File Offset: 0x00072EB8
		' (set) Token: 0x06000C7B RID: 3195 RVA: 0x00074CCB File Offset: 0x00072ECB
		Public Overrides Property NewGenerator As Boolean
			Get
				Return True
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x170004A6 RID: 1190
		' (get) Token: 0x06000C7C RID: 3196 RVA: 0x00074CD0 File Offset: 0x00072ED0
		' (set) Token: 0x06000C7D RID: 3197 RVA: 0x00074CE7 File Offset: 0x00072EE7
		Public Overrides Property FullResourceName As String
			Get
				Return "Datasoft_PIMS.rptIssue.rpt"
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x170004A7 RID: 1191
		' (get) Token: 0x06000C7E RID: 3198 RVA: 0x00074CEC File Offset: 0x00072EEC
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section1 As Section
			Get
				Return Me.ReportDefinition.Sections(0)
			End Get
		End Property

		' Token: 0x170004A8 RID: 1192
		' (get) Token: 0x06000C7F RID: 3199 RVA: 0x00074D10 File Offset: 0x00072F10
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section2 As Section
			Get
				Return Me.ReportDefinition.Sections(1)
			End Get
		End Property

		' Token: 0x170004A9 RID: 1193
		' (get) Token: 0x06000C80 RID: 3200 RVA: 0x00074D34 File Offset: 0x00072F34
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property PageHeaderSection3 As Section
			Get
				Return Me.ReportDefinition.Sections(2)
			End Get
		End Property

		' Token: 0x170004AA RID: 1194
		' (get) Token: 0x06000C81 RID: 3201 RVA: 0x00074D58 File Offset: 0x00072F58
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property PageHeaderSection4 As Section
			Get
				Return Me.ReportDefinition.Sections(3)
			End Get
		End Property

		' Token: 0x170004AB RID: 1195
		' (get) Token: 0x06000C82 RID: 3202 RVA: 0x00074D7C File Offset: 0x00072F7C
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section3 As Section
			Get
				Return Me.ReportDefinition.Sections(4)
			End Get
		End Property

		' Token: 0x170004AC RID: 1196
		' (get) Token: 0x06000C83 RID: 3203 RVA: 0x00074DA0 File Offset: 0x00072FA0
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property DetailSection2 As Section
			Get
				Return Me.ReportDefinition.Sections(5)
			End Get
		End Property

		' Token: 0x170004AD RID: 1197
		' (get) Token: 0x06000C84 RID: 3204 RVA: 0x00074DC4 File Offset: 0x00072FC4
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section4 As Section
			Get
				Return Me.ReportDefinition.Sections(6)
			End Get
		End Property

		' Token: 0x170004AE RID: 1198
		' (get) Token: 0x06000C85 RID: 3205 RVA: 0x00074DE8 File Offset: 0x00072FE8
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section5 As Section
			Get
				Return Me.ReportDefinition.Sections(7)
			End Get
		End Property

		' Token: 0x170004AF RID: 1199
		' (get) Token: 0x06000C86 RID: 3206 RVA: 0x00074E0C File Offset: 0x0007300C
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property PageFooterSection2 As Section
			Get
				Return Me.ReportDefinition.Sections(8)
			End Get
		End Property
	End Class
End Namespace
