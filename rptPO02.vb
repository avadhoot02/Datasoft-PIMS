Imports System
Imports System.ComponentModel
Imports CrystalDecisions.CrystalReports.Engine

Namespace Datasoft_PIMS
	' Token: 0x02000042 RID: 66
	Public Class rptPO02
		Inherits ReportClass

		' Token: 0x170004B4 RID: 1204
		' (get) Token: 0x06000C98 RID: 3224 RVA: 0x00075338 File Offset: 0x00073538
		' (set) Token: 0x06000C99 RID: 3225 RVA: 0x0007534F File Offset: 0x0007354F
		Public Overrides Property ResourceName As String
			Get
				Return "rptPO02.rpt"
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x170004B5 RID: 1205
		' (get) Token: 0x06000C9A RID: 3226 RVA: 0x00075354 File Offset: 0x00073554
		' (set) Token: 0x06000C9B RID: 3227 RVA: 0x00075367 File Offset: 0x00073567
		Public Overrides Property NewGenerator As Boolean
			Get
				Return True
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x170004B6 RID: 1206
		' (get) Token: 0x06000C9C RID: 3228 RVA: 0x0007536C File Offset: 0x0007356C
		' (set) Token: 0x06000C9D RID: 3229 RVA: 0x00075383 File Offset: 0x00073583
		Public Overrides Property FullResourceName As String
			Get
				Return "Datasoft_PIMS.rptPO02.rpt"
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x170004B7 RID: 1207
		' (get) Token: 0x06000C9E RID: 3230 RVA: 0x00075388 File Offset: 0x00073588
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section1 As Section
			Get
				Return Me.ReportDefinition.Sections(0)
			End Get
		End Property

		' Token: 0x170004B8 RID: 1208
		' (get) Token: 0x06000C9F RID: 3231 RVA: 0x000753AC File Offset: 0x000735AC
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section2 As Section
			Get
				Return Me.ReportDefinition.Sections(1)
			End Get
		End Property

		' Token: 0x170004B9 RID: 1209
		' (get) Token: 0x06000CA0 RID: 3232 RVA: 0x000753D0 File Offset: 0x000735D0
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property PageHeaderSection2 As Section
			Get
				Return Me.ReportDefinition.Sections(2)
			End Get
		End Property

		' Token: 0x170004BA RID: 1210
		' (get) Token: 0x06000CA1 RID: 3233 RVA: 0x000753F4 File Offset: 0x000735F4
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property PageHeaderSection3 As Section
			Get
				Return Me.ReportDefinition.Sections(3)
			End Get
		End Property

		' Token: 0x170004BB RID: 1211
		' (get) Token: 0x06000CA2 RID: 3234 RVA: 0x00075418 File Offset: 0x00073618
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section3 As Section
			Get
				Return Me.ReportDefinition.Sections(4)
			End Get
		End Property

		' Token: 0x170004BC RID: 1212
		' (get) Token: 0x06000CA3 RID: 3235 RVA: 0x0007543C File Offset: 0x0007363C
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property DetailSection2 As Section
			Get
				Return Me.ReportDefinition.Sections(5)
			End Get
		End Property

		' Token: 0x170004BD RID: 1213
		' (get) Token: 0x06000CA4 RID: 3236 RVA: 0x00075460 File Offset: 0x00073660
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section4 As Section
			Get
				Return Me.ReportDefinition.Sections(6)
			End Get
		End Property

		' Token: 0x170004BE RID: 1214
		' (get) Token: 0x06000CA5 RID: 3237 RVA: 0x00075484 File Offset: 0x00073684
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property PageFooterSection11 As Section
			Get
				Return Me.ReportDefinition.Sections(7)
			End Get
		End Property

		' Token: 0x170004BF RID: 1215
		' (get) Token: 0x06000CA6 RID: 3238 RVA: 0x000754A8 File Offset: 0x000736A8
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property PageFooterSection3 As Section
			Get
				Return Me.ReportDefinition.Sections(8)
			End Get
		End Property
	End Class
End Namespace
