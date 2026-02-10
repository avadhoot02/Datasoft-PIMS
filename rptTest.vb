Imports System
Imports System.ComponentModel
Imports CrystalDecisions.CrystalReports.Engine

Namespace Datasoft_PIMS
	' Token: 0x02000046 RID: 70
	Public Class rptTest
		Inherits ReportClass

		' Token: 0x170004D3 RID: 1235
		' (get) Token: 0x06000CCB RID: 3275 RVA: 0x000757C4 File Offset: 0x000739C4
		' (set) Token: 0x06000CCC RID: 3276 RVA: 0x000757DB File Offset: 0x000739DB
		Public Overrides Property ResourceName As String
			Get
				Return "rptTest.rpt"
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x170004D4 RID: 1236
		' (get) Token: 0x06000CCD RID: 3277 RVA: 0x000757E0 File Offset: 0x000739E0
		' (set) Token: 0x06000CCE RID: 3278 RVA: 0x000757F3 File Offset: 0x000739F3
		Public Overrides Property NewGenerator As Boolean
			Get
				Return True
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x170004D5 RID: 1237
		' (get) Token: 0x06000CCF RID: 3279 RVA: 0x000757F8 File Offset: 0x000739F8
		' (set) Token: 0x06000CD0 RID: 3280 RVA: 0x0007580F File Offset: 0x00073A0F
		Public Overrides Property FullResourceName As String
			Get
				Return "Datasoft_PIMS.rptTest.rpt"
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x170004D6 RID: 1238
		' (get) Token: 0x06000CD1 RID: 3281 RVA: 0x00075814 File Offset: 0x00073A14
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section1 As Section
			Get
				Return Me.ReportDefinition.Sections(0)
			End Get
		End Property

		' Token: 0x170004D7 RID: 1239
		' (get) Token: 0x06000CD2 RID: 3282 RVA: 0x00075838 File Offset: 0x00073A38
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section2 As Section
			Get
				Return Me.ReportDefinition.Sections(1)
			End Get
		End Property

		' Token: 0x170004D8 RID: 1240
		' (get) Token: 0x06000CD3 RID: 3283 RVA: 0x0007585C File Offset: 0x00073A5C
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section3 As Section
			Get
				Return Me.ReportDefinition.Sections(2)
			End Get
		End Property

		' Token: 0x170004D9 RID: 1241
		' (get) Token: 0x06000CD4 RID: 3284 RVA: 0x00075880 File Offset: 0x00073A80
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section4 As Section
			Get
				Return Me.ReportDefinition.Sections(3)
			End Get
		End Property

		' Token: 0x170004DA RID: 1242
		' (get) Token: 0x06000CD5 RID: 3285 RVA: 0x000758A4 File Offset: 0x00073AA4
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section5 As Section
			Get
				Return Me.ReportDefinition.Sections(4)
			End Get
		End Property
	End Class
End Namespace
