Imports System
Imports System.ComponentModel
Imports CrystalDecisions.CrystalReports.Engine

Namespace Datasoft_PIMS
	' Token: 0x0200003B RID: 59
	Public Class rptClosingStock
		Inherits ReportClass

		' Token: 0x17000484 RID: 1156
		' (get) Token: 0x06000C44 RID: 3140 RVA: 0x000747EC File Offset: 0x000729EC
		' (set) Token: 0x06000C45 RID: 3141 RVA: 0x00074803 File Offset: 0x00072A03
		Public Overrides Property ResourceName As String
			Get
				Return "rptClosingStock.rpt"
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x17000485 RID: 1157
		' (get) Token: 0x06000C46 RID: 3142 RVA: 0x00074808 File Offset: 0x00072A08
		' (set) Token: 0x06000C47 RID: 3143 RVA: 0x0007481B File Offset: 0x00072A1B
		Public Overrides Property NewGenerator As Boolean
			Get
				Return True
			End Get
			Set(value As Boolean)
			End Set
		End Property

		' Token: 0x17000486 RID: 1158
		' (get) Token: 0x06000C48 RID: 3144 RVA: 0x00074820 File Offset: 0x00072A20
		' (set) Token: 0x06000C49 RID: 3145 RVA: 0x00074837 File Offset: 0x00072A37
		Public Overrides Property FullResourceName As String
			Get
				Return "Datasoft_PIMS.rptClosingStock.rpt"
			End Get
			Set(value As String)
			End Set
		End Property

		' Token: 0x17000487 RID: 1159
		' (get) Token: 0x06000C4A RID: 3146 RVA: 0x0007483C File Offset: 0x00072A3C
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section1 As Section
			Get
				Return Me.ReportDefinition.Sections(0)
			End Get
		End Property

		' Token: 0x17000488 RID: 1160
		' (get) Token: 0x06000C4B RID: 3147 RVA: 0x00074860 File Offset: 0x00072A60
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section2 As Section
			Get
				Return Me.ReportDefinition.Sections(1)
			End Get
		End Property

		' Token: 0x17000489 RID: 1161
		' (get) Token: 0x06000C4C RID: 3148 RVA: 0x00074884 File Offset: 0x00072A84
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property GroupHeaderSection2 As Section
			Get
				Return Me.ReportDefinition.Sections(2)
			End Get
		End Property

		' Token: 0x1700048A RID: 1162
		' (get) Token: 0x06000C4D RID: 3149 RVA: 0x000748A8 File Offset: 0x00072AA8
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property GroupHeaderSection3 As Section
			Get
				Return Me.ReportDefinition.Sections(3)
			End Get
		End Property

		' Token: 0x1700048B RID: 1163
		' (get) Token: 0x06000C4E RID: 3150 RVA: 0x000748CC File Offset: 0x00072ACC
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section3 As Section
			Get
				Return Me.ReportDefinition.Sections(4)
			End Get
		End Property

		' Token: 0x1700048C RID: 1164
		' (get) Token: 0x06000C4F RID: 3151 RVA: 0x000748F0 File Offset: 0x00072AF0
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property GroupFooterSection3 As Section
			Get
				Return Me.ReportDefinition.Sections(5)
			End Get
		End Property

		' Token: 0x1700048D RID: 1165
		' (get) Token: 0x06000C50 RID: 3152 RVA: 0x00074914 File Offset: 0x00072B14
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property GroupFooterSection2 As Section
			Get
				Return Me.ReportDefinition.Sections(6)
			End Get
		End Property

		' Token: 0x1700048E RID: 1166
		' (get) Token: 0x06000C51 RID: 3153 RVA: 0x00074938 File Offset: 0x00072B38
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section4 As Section
			Get
				Return Me.ReportDefinition.Sections(7)
			End Get
		End Property

		' Token: 0x1700048F RID: 1167
		' (get) Token: 0x06000C52 RID: 3154 RVA: 0x0007495C File Offset: 0x00072B5C
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Section5 As Section
			Get
				Return Me.ReportDefinition.Sections(8)
			End Get
		End Property
	End Class
End Namespace
