Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Data
Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.Serialization
Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x0200000E RID: 14
	<DesignerCategory("code")>
	<ToolboxItem(True)>
	<XmlSchemaProvider("GetTypedDataSetSchema")>
	<XmlRoot("PIMSDataSet")>
	<HelpKeyword("vs.data.DataSet")>
	<Serializable()>
	Public Class PIMSDataSet
		Inherits DataSet

		' Token: 0x060000DE RID: 222 RVA: 0x0000A97C File Offset: 0x00008B7C
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Public Sub New()
			Me._schemaSerializationMode = SchemaSerializationMode.IncludeSchema
			MyBase.BeginInit()
			Me.InitClass()
			Dim collectionChangeEventHandler As CollectionChangeEventHandler = AddressOf Me.SchemaChanged
			AddHandler MyBase.Tables.CollectionChanged, collectionChangeEventHandler
			AddHandler MyBase.Relations.CollectionChanged, collectionChangeEventHandler
			MyBase.EndInit()
		End Sub

		' Token: 0x060000DF RID: 223 RVA: 0x0000A9D4 File Offset: 0x00008BD4
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Protected Sub New(info As SerializationInfo, context As StreamingContext)
			MyBase.New(info, context, False)
			Me._schemaSerializationMode = SchemaSerializationMode.IncludeSchema
			Dim flag As Boolean = MyBase.IsBinarySerialized(info, context)
			If flag Then
				Me.InitVars(False)
				Dim collectionChangeEventHandler As CollectionChangeEventHandler = AddressOf Me.SchemaChanged
				AddHandler Me.Tables.CollectionChanged, collectionChangeEventHandler
				AddHandler Me.Relations.CollectionChanged, collectionChangeEventHandler
			Else
				Dim text As String = Conversions.ToString(info.GetValue("XmlSchema", GetType(String)))
				Dim flag2 As Boolean = MyBase.DetermineSchemaSerializationMode(info, context) = SchemaSerializationMode.IncludeSchema
				If flag2 Then
					Dim dataSet As DataSet = New DataSet()
					dataSet.ReadXmlSchema(New XmlTextReader(New StringReader(text)))
					Dim flag3 As Boolean = dataSet.Tables("PO") IsNot Nothing
					If flag3 Then
						MyBase.Tables.Add(New PIMSDataSet.PODataTable(dataSet.Tables("PO")))
					End If
					Dim flag4 As Boolean = dataSet.Tables("Test") IsNot Nothing
					If flag4 Then
						MyBase.Tables.Add(New PIMSDataSet.TestDataTable(dataSet.Tables("Test")))
					End If
					Dim flag5 As Boolean = dataSet.Tables("QC") IsNot Nothing
					If flag5 Then
						MyBase.Tables.Add(New PIMSDataSet.QCDataTable(dataSet.Tables("QC")))
					End If
					Dim flag6 As Boolean = dataSet.Tables("Issue") IsNot Nothing
					If flag6 Then
						MyBase.Tables.Add(New PIMSDataSet.IssueDataTable(dataSet.Tables("Issue")))
					End If
					Dim flag7 As Boolean = dataSet.Tables("Consumption") IsNot Nothing
					If flag7 Then
						MyBase.Tables.Add(New PIMSDataSet.ConsumptionDataTable(dataSet.Tables("Consumption")))
					End If
					Dim flag8 As Boolean = dataSet.Tables("COA") IsNot Nothing
					If flag8 Then
						MyBase.Tables.Add(New PIMSDataSet.COADataTable(dataSet.Tables("COA")))
					End If
					MyBase.DataSetName = dataSet.DataSetName
					MyBase.Prefix = dataSet.Prefix
					MyBase.[Namespace] = dataSet.[Namespace]
					MyBase.Locale = dataSet.Locale
					MyBase.CaseSensitive = dataSet.CaseSensitive
					MyBase.EnforceConstraints = dataSet.EnforceConstraints
					MyBase.Merge(dataSet, False, MissingSchemaAction.Add)
					Me.InitVars()
				Else
					MyBase.ReadXmlSchema(New XmlTextReader(New StringReader(text)))
				End If
				MyBase.GetSerializationData(info, context)
				Dim collectionChangeEventHandler2 As CollectionChangeEventHandler = AddressOf Me.SchemaChanged
				AddHandler MyBase.Tables.CollectionChanged, collectionChangeEventHandler2
				AddHandler Me.Relations.CollectionChanged, collectionChangeEventHandler2
			End If
		End Sub

		' Token: 0x17000042 RID: 66
		' (get) Token: 0x060000E0 RID: 224 RVA: 0x0000ACA0 File Offset: 0x00008EA0
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
		Public ReadOnly Property PO As PIMSDataSet.PODataTable
			Get
				Return Me.tablePO
			End Get
		End Property

		' Token: 0x17000043 RID: 67
		' (get) Token: 0x060000E1 RID: 225 RVA: 0x0000ACB8 File Offset: 0x00008EB8
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
		Public ReadOnly Property Test As PIMSDataSet.TestDataTable
			Get
				Return Me.tableTest
			End Get
		End Property

		' Token: 0x17000044 RID: 68
		' (get) Token: 0x060000E2 RID: 226 RVA: 0x0000ACD0 File Offset: 0x00008ED0
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
		Public ReadOnly Property QC As PIMSDataSet.QCDataTable
			Get
				Return Me.tableQC
			End Get
		End Property

		' Token: 0x17000045 RID: 69
		' (get) Token: 0x060000E3 RID: 227 RVA: 0x0000ACE8 File Offset: 0x00008EE8
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
		Public ReadOnly Property Issue As PIMSDataSet.IssueDataTable
			Get
				Return Me.tableIssue
			End Get
		End Property

		' Token: 0x17000046 RID: 70
		' (get) Token: 0x060000E4 RID: 228 RVA: 0x0000AD00 File Offset: 0x00008F00
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
		Public ReadOnly Property Consumption As PIMSDataSet.ConsumptionDataTable
			Get
				Return Me.tableConsumption
			End Get
		End Property

		' Token: 0x17000047 RID: 71
		' (get) Token: 0x060000E5 RID: 229 RVA: 0x0000AD18 File Offset: 0x00008F18
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		<Browsable(False)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
		Public ReadOnly Property COA As PIMSDataSet.COADataTable
			Get
				Return Me.tableCOA
			End Get
		End Property

		' Token: 0x17000048 RID: 72
		' (get) Token: 0x060000E6 RID: 230 RVA: 0x0000AD30 File Offset: 0x00008F30
		' (set) Token: 0x060000E7 RID: 231 RVA: 0x0000AD48 File Offset: 0x00008F48
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		<Browsable(True)>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
		Public Overrides Property SchemaSerializationMode As SchemaSerializationMode
			Get
				Return Me._schemaSerializationMode
			End Get
			Set(value As SchemaSerializationMode)
				Me._schemaSerializationMode = value
			End Set
		End Property

		' Token: 0x17000049 RID: 73
		' (get) Token: 0x060000E8 RID: 232 RVA: 0x0000AD54 File Offset: 0x00008F54
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Tables As DataTableCollection
			Get
				Return MyBase.Tables
			End Get
		End Property

		' Token: 0x1700004A RID: 74
		' (get) Token: 0x060000E9 RID: 233 RVA: 0x0000AD6C File Offset: 0x00008F6C
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
		Public ReadOnly Property Relations As DataRelationCollection
			Get
				Return MyBase.Relations
			End Get
		End Property

		' Token: 0x060000EA RID: 234 RVA: 0x0000AD84 File Offset: 0x00008F84
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Protected Overrides Sub InitializeDerivedDataSet()
			MyBase.BeginInit()
			Me.InitClass()
			MyBase.EndInit()
		End Sub

		' Token: 0x060000EB RID: 235 RVA: 0x0000AD9C File Offset: 0x00008F9C
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Public Overrides Function Clone() As DataSet
			Dim pimsdataSet As PIMSDataSet = CType(MyBase.Clone(), PIMSDataSet)
			pimsdataSet.InitVars()
			pimsdataSet.SchemaSerializationMode = Me.SchemaSerializationMode
			Return pimsdataSet
		End Function

		' Token: 0x060000EC RID: 236 RVA: 0x0000ADD0 File Offset: 0x00008FD0
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Protected Overrides Function ShouldSerializeTables() As Boolean
			Return False
		End Function

		' Token: 0x060000ED RID: 237 RVA: 0x0000ADE4 File Offset: 0x00008FE4
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Protected Overrides Function ShouldSerializeRelations() As Boolean
			Return False
		End Function

		' Token: 0x060000EE RID: 238 RVA: 0x0000ADF8 File Offset: 0x00008FF8
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Protected Overrides Sub ReadXmlSerializable(reader As XmlReader)
			Dim flag As Boolean = MyBase.DetermineSchemaSerializationMode(reader) = SchemaSerializationMode.IncludeSchema
			If flag Then
				Me.Reset()
				Dim dataSet As DataSet = New DataSet()
				dataSet.ReadXml(reader)
				Dim flag2 As Boolean = dataSet.Tables("PO") IsNot Nothing
				If flag2 Then
					MyBase.Tables.Add(New PIMSDataSet.PODataTable(dataSet.Tables("PO")))
				End If
				Dim flag3 As Boolean = dataSet.Tables("Test") IsNot Nothing
				If flag3 Then
					MyBase.Tables.Add(New PIMSDataSet.TestDataTable(dataSet.Tables("Test")))
				End If
				Dim flag4 As Boolean = dataSet.Tables("QC") IsNot Nothing
				If flag4 Then
					MyBase.Tables.Add(New PIMSDataSet.QCDataTable(dataSet.Tables("QC")))
				End If
				Dim flag5 As Boolean = dataSet.Tables("Issue") IsNot Nothing
				If flag5 Then
					MyBase.Tables.Add(New PIMSDataSet.IssueDataTable(dataSet.Tables("Issue")))
				End If
				Dim flag6 As Boolean = dataSet.Tables("Consumption") IsNot Nothing
				If flag6 Then
					MyBase.Tables.Add(New PIMSDataSet.ConsumptionDataTable(dataSet.Tables("Consumption")))
				End If
				Dim flag7 As Boolean = dataSet.Tables("COA") IsNot Nothing
				If flag7 Then
					MyBase.Tables.Add(New PIMSDataSet.COADataTable(dataSet.Tables("COA")))
				End If
				MyBase.DataSetName = dataSet.DataSetName
				MyBase.Prefix = dataSet.Prefix
				MyBase.[Namespace] = dataSet.[Namespace]
				MyBase.Locale = dataSet.Locale
				MyBase.CaseSensitive = dataSet.CaseSensitive
				MyBase.EnforceConstraints = dataSet.EnforceConstraints
				MyBase.Merge(dataSet, False, MissingSchemaAction.Add)
				Me.InitVars()
			Else
				MyBase.ReadXml(reader)
				Me.InitVars()
			End If
		End Sub

		' Token: 0x060000EF RID: 239 RVA: 0x0000B004 File Offset: 0x00009204
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Protected Overrides Function GetSchemaSerializable() As XmlSchema
			Dim memoryStream As MemoryStream = New MemoryStream()
			MyBase.WriteXmlSchema(New XmlTextWriter(memoryStream, Nothing))
			memoryStream.Position = 0L
			Return XmlSchema.Read(New XmlTextReader(memoryStream), Nothing)
		End Function

		' Token: 0x060000F0 RID: 240 RVA: 0x0000B03F File Offset: 0x0000923F
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Friend Sub InitVars()
			Me.InitVars(True)
		End Sub

		' Token: 0x060000F1 RID: 241 RVA: 0x0000B04C File Offset: 0x0000924C
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Friend Sub InitVars(initTable As Boolean)
			Me.tablePO = CType(MyBase.Tables("PO"), PIMSDataSet.PODataTable)
			If initTable Then
				Dim flag As Boolean = Me.tablePO IsNot Nothing
				If flag Then
					Me.tablePO.InitVars()
				End If
			End If
			Me.tableTest = CType(MyBase.Tables("Test"), PIMSDataSet.TestDataTable)
			If initTable Then
				Dim flag2 As Boolean = Me.tableTest IsNot Nothing
				If flag2 Then
					Me.tableTest.InitVars()
				End If
			End If
			Me.tableQC = CType(MyBase.Tables("QC"), PIMSDataSet.QCDataTable)
			If initTable Then
				Dim flag3 As Boolean = Me.tableQC IsNot Nothing
				If flag3 Then
					Me.tableQC.InitVars()
				End If
			End If
			Me.tableIssue = CType(MyBase.Tables("Issue"), PIMSDataSet.IssueDataTable)
			If initTable Then
				Dim flag4 As Boolean = Me.tableIssue IsNot Nothing
				If flag4 Then
					Me.tableIssue.InitVars()
				End If
			End If
			Me.tableConsumption = CType(MyBase.Tables("Consumption"), PIMSDataSet.ConsumptionDataTable)
			If initTable Then
				Dim flag5 As Boolean = Me.tableConsumption IsNot Nothing
				If flag5 Then
					Me.tableConsumption.InitVars()
				End If
			End If
			Me.tableCOA = CType(MyBase.Tables("COA"), PIMSDataSet.COADataTable)
			If initTable Then
				Dim flag6 As Boolean = Me.tableCOA IsNot Nothing
				If flag6 Then
					Me.tableCOA.InitVars()
				End If
			End If
		End Sub

		' Token: 0x060000F2 RID: 242 RVA: 0x0000B1D8 File Offset: 0x000093D8
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Private Sub InitClass()
			MyBase.DataSetName = "PIMSDataSet"
			MyBase.Prefix = ""
			MyBase.[Namespace] = "http://tempuri.org/PIMSDataSet.xsd"
			MyBase.EnforceConstraints = True
			Me.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema
			Me.tablePO = New PIMSDataSet.PODataTable()
			MyBase.Tables.Add(Me.tablePO)
			Me.tableTest = New PIMSDataSet.TestDataTable()
			MyBase.Tables.Add(Me.tableTest)
			Me.tableQC = New PIMSDataSet.QCDataTable()
			MyBase.Tables.Add(Me.tableQC)
			Me.tableIssue = New PIMSDataSet.IssueDataTable()
			MyBase.Tables.Add(Me.tableIssue)
			Me.tableConsumption = New PIMSDataSet.ConsumptionDataTable()
			MyBase.Tables.Add(Me.tableConsumption)
			Me.tableCOA = New PIMSDataSet.COADataTable()
			MyBase.Tables.Add(Me.tableCOA)
		End Sub

		' Token: 0x060000F3 RID: 243 RVA: 0x0000B2C8 File Offset: 0x000094C8
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Private Function ShouldSerializePO() As Boolean
			Return False
		End Function

		' Token: 0x060000F4 RID: 244 RVA: 0x0000B2DC File Offset: 0x000094DC
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Private Function ShouldSerializeTest() As Boolean
			Return False
		End Function

		' Token: 0x060000F5 RID: 245 RVA: 0x0000B2F0 File Offset: 0x000094F0
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Private Function ShouldSerializeQC() As Boolean
			Return False
		End Function

		' Token: 0x060000F6 RID: 246 RVA: 0x0000B304 File Offset: 0x00009504
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Private Function ShouldSerializeIssue() As Boolean
			Return False
		End Function

		' Token: 0x060000F7 RID: 247 RVA: 0x0000B318 File Offset: 0x00009518
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Private Function ShouldSerializeConsumption() As Boolean
			Return False
		End Function

		' Token: 0x060000F8 RID: 248 RVA: 0x0000B32C File Offset: 0x0000952C
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Private Function ShouldSerializeCOA() As Boolean
			Return False
		End Function

		' Token: 0x060000F9 RID: 249 RVA: 0x0000B340 File Offset: 0x00009540
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Private Sub SchemaChanged(sender As Object, e As CollectionChangeEventArgs)
			Dim flag As Boolean = e.Action = CollectionChangeAction.Remove
			If flag Then
				Me.InitVars()
			End If
		End Sub

		' Token: 0x060000FA RID: 250 RVA: 0x0000B364 File Offset: 0x00009564
		<DebuggerNonUserCode()>
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Public Shared Function GetTypedDataSetSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
			Dim pimsdataSet As PIMSDataSet = New PIMSDataSet()
			Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
			Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
			Dim xmlSchemaAny As XmlSchemaAny = New XmlSchemaAny()
			xmlSchemaAny.[Namespace] = pimsdataSet.[Namespace]
			xmlSchemaSequence.Items.Add(xmlSchemaAny)
			xmlSchemaComplexType.Particle = xmlSchemaSequence
			Dim schemaSerializable As XmlSchema = pimsdataSet.GetSchemaSerializable()
			Dim flag As Boolean = xs.Contains(schemaSerializable.TargetNamespace)
			If flag Then
				Dim memoryStream As MemoryStream = New MemoryStream()
				Dim memoryStream2 As MemoryStream = New MemoryStream()
				Try
					schemaSerializable.Write(memoryStream)
					For Each obj As Object In xs.Schemas(schemaSerializable.TargetNamespace)
						Dim xmlSchema As XmlSchema = CType(obj, XmlSchema)
						memoryStream2.SetLength(0L)
						xmlSchema.Write(memoryStream2)
						Dim flag2 As Boolean = memoryStream.Length = memoryStream2.Length
						If flag2 Then
							memoryStream.Position = 0L
							memoryStream2.Position = 0L
							While memoryStream.Position <> memoryStream.Length AndAlso memoryStream.ReadByte() = memoryStream2.ReadByte()
							End While
							Dim flag3 As Boolean = memoryStream.Position = memoryStream.Length
							If flag3 Then
								Return xmlSchemaComplexType
							End If
						End If
					Next
				Finally
					Dim flag4 As Boolean = memoryStream IsNot Nothing
					If flag4 Then
						memoryStream.Close()
					End If
					Dim flag5 As Boolean = memoryStream2 IsNot Nothing
					If flag5 Then
						memoryStream2.Close()
					End If
				End Try
			End If
			xs.Add(schemaSerializable)
			Return xmlSchemaComplexType
		End Function

		' Token: 0x04000042 RID: 66
		Private tablePO As PIMSDataSet.PODataTable

		' Token: 0x04000043 RID: 67
		Private tableTest As PIMSDataSet.TestDataTable

		' Token: 0x04000044 RID: 68
		Private tableQC As PIMSDataSet.QCDataTable

		' Token: 0x04000045 RID: 69
		Private tableIssue As PIMSDataSet.IssueDataTable

		' Token: 0x04000046 RID: 70
		Private tableConsumption As PIMSDataSet.ConsumptionDataTable

		' Token: 0x04000047 RID: 71
		Private tableCOA As PIMSDataSet.COADataTable

		' Token: 0x04000048 RID: 72
		Private _schemaSerializationMode As SchemaSerializationMode

		' Token: 0x02000071 RID: 113
		' (Invoke) Token: 0x06001DED RID: 7661
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Public Delegate Sub PORowChangeEventHandler(sender As Object, e As PIMSDataSet.PORowChangeEvent)

		' Token: 0x02000072 RID: 114
		' (Invoke) Token: 0x06001DF1 RID: 7665
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Public Delegate Sub TestRowChangeEventHandler(sender As Object, e As PIMSDataSet.TestRowChangeEvent)

		' Token: 0x02000073 RID: 115
		' (Invoke) Token: 0x06001DF5 RID: 7669
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Public Delegate Sub QCRowChangeEventHandler(sender As Object, e As PIMSDataSet.QCRowChangeEvent)

		' Token: 0x02000074 RID: 116
		' (Invoke) Token: 0x06001DF9 RID: 7673
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Public Delegate Sub IssueRowChangeEventHandler(sender As Object, e As PIMSDataSet.IssueRowChangeEvent)

		' Token: 0x02000075 RID: 117
		' (Invoke) Token: 0x06001DFD RID: 7677
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Public Delegate Sub ConsumptionRowChangeEventHandler(sender As Object, e As PIMSDataSet.ConsumptionRowChangeEvent)

		' Token: 0x02000076 RID: 118
		' (Invoke) Token: 0x06001E01 RID: 7681
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Public Delegate Sub COARowChangeEventHandler(sender As Object, e As PIMSDataSet.COARowChangeEvent)

		' Token: 0x02000077 RID: 119
		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class PODataTable
			Inherits TypedTableBase(Of PIMSDataSet.PORow)

			' Token: 0x06001E02 RID: 7682 RVA: 0x00114DB4 File Offset: 0x00112FB4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub New()
				MyBase.TableName = "PO"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			' Token: 0x06001E03 RID: 7683 RVA: 0x00114DE0 File Offset: 0x00112FE0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Friend Sub New(table As DataTable)
				MyBase.TableName = table.TableName
				Dim flag As Boolean = table.CaseSensitive <> table.DataSet.CaseSensitive
				If flag Then
					MyBase.CaseSensitive = table.CaseSensitive
				End If
				Dim flag2 As Boolean = Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0
				If flag2 Then
					MyBase.Locale = table.Locale
				End If
				Dim flag3 As Boolean = Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0
				If flag3 Then
					MyBase.[Namespace] = table.[Namespace]
				End If
				MyBase.Prefix = table.Prefix
				MyBase.MinimumCapacity = table.MinimumCapacity
			End Sub

			' Token: 0x06001E04 RID: 7684 RVA: 0x00114EA9 File Offset: 0x001130A9
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.New(info, context)
				Me.InitVars()
			End Sub

			' Token: 0x17000BA5 RID: 2981
			' (get) Token: 0x06001E05 RID: 7685 RVA: 0x00114EBC File Offset: 0x001130BC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property POIDColumn As DataColumn
				Get
					Return Me.columnPOID
				End Get
			End Property

			' Token: 0x17000BA6 RID: 2982
			' (get) Token: 0x06001E06 RID: 7686 RVA: 0x00114ED4 File Offset: 0x001130D4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property POTypeColumn As DataColumn
				Get
					Return Me.columnPOType
				End Get
			End Property

			' Token: 0x17000BA7 RID: 2983
			' (get) Token: 0x06001E07 RID: 7687 RVA: 0x00114EEC File Offset: 0x001130EC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property PONoColumn As DataColumn
				Get
					Return Me.columnPONo
				End Get
			End Property

			' Token: 0x17000BA8 RID: 2984
			' (get) Token: 0x06001E08 RID: 7688 RVA: 0x00114F04 File Offset: 0x00113104
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property PODtColumn As DataColumn
				Get
					Return Me.columnPODt
				End Get
			End Property

			' Token: 0x17000BA9 RID: 2985
			' (get) Token: 0x06001E09 RID: 7689 RVA: 0x00114F1C File Offset: 0x0011311C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property PRNoColumn As DataColumn
				Get
					Return Me.columnPRNo
				End Get
			End Property

			' Token: 0x17000BAA RID: 2986
			' (get) Token: 0x06001E0A RID: 7690 RVA: 0x00114F34 File Offset: 0x00113134
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property PRDtColumn As DataColumn
				Get
					Return Me.columnPRDt
				End Get
			End Property

			' Token: 0x17000BAB RID: 2987
			' (get) Token: 0x06001E0B RID: 7691 RVA: 0x00114F4C File Offset: 0x0011314C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property ValidUptoColumn As DataColumn
				Get
					Return Me.columnValidUpto
				End Get
			End Property

			' Token: 0x17000BAC RID: 2988
			' (get) Token: 0x06001E0C RID: 7692 RVA: 0x00114F64 File Offset: 0x00113164
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property DeliveryDtColumn As DataColumn
				Get
					Return Me.columnDeliveryDt
				End Get
			End Property

			' Token: 0x17000BAD RID: 2989
			' (get) Token: 0x06001E0D RID: 7693 RVA: 0x00114F7C File Offset: 0x0011317C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property DepartmentColumn As DataColumn
				Get
					Return Me.columnDepartment
				End Get
			End Property

			' Token: 0x17000BAE RID: 2990
			' (get) Token: 0x06001E0E RID: 7694 RVA: 0x00114F94 File Offset: 0x00113194
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property InvoiceAddressColumn As DataColumn
				Get
					Return Me.columnInvoiceAddress
				End Get
			End Property

			' Token: 0x17000BAF RID: 2991
			' (get) Token: 0x06001E0F RID: 7695 RVA: 0x00114FAC File Offset: 0x001131AC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property BillingEmailIDColumn As DataColumn
				Get
					Return Me.columnBillingEmailID
				End Get
			End Property

			' Token: 0x17000BB0 RID: 2992
			' (get) Token: 0x06001E10 RID: 7696 RVA: 0x00114FC4 File Offset: 0x001131C4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property ShipAddressColumn As DataColumn
				Get
					Return Me.columnShipAddress
				End Get
			End Property

			' Token: 0x17000BB1 RID: 2993
			' (get) Token: 0x06001E11 RID: 7697 RVA: 0x00114FDC File Offset: 0x001131DC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property ShippingEmailIDColumn As DataColumn
				Get
					Return Me.columnShippingEmailID
				End Get
			End Property

			' Token: 0x17000BB2 RID: 2994
			' (get) Token: 0x06001E12 RID: 7698 RVA: 0x00114FF4 File Offset: 0x001131F4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property GSTNoColumn As DataColumn
				Get
					Return Me.columnGSTNo
				End Get
			End Property

			' Token: 0x17000BB3 RID: 2995
			' (get) Token: 0x06001E13 RID: 7699 RVA: 0x0011500C File Offset: 0x0011320C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property PANNoColumn As DataColumn
				Get
					Return Me.columnPANNo
				End Get
			End Property

			' Token: 0x17000BB4 RID: 2996
			' (get) Token: 0x06001E14 RID: 7700 RVA: 0x00115024 File Offset: 0x00113224
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property VendorNameColumn As DataColumn
				Get
					Return Me.columnVendorName
				End Get
			End Property

			' Token: 0x17000BB5 RID: 2997
			' (get) Token: 0x06001E15 RID: 7701 RVA: 0x0011503C File Offset: 0x0011323C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property VendorBillingAddressColumn As DataColumn
				Get
					Return Me.columnVendorBillingAddress
				End Get
			End Property

			' Token: 0x17000BB6 RID: 2998
			' (get) Token: 0x06001E16 RID: 7702 RVA: 0x00115054 File Offset: 0x00113254
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property VendorContactPersonColumn As DataColumn
				Get
					Return Me.columnVendorContactPerson
				End Get
			End Property

			' Token: 0x17000BB7 RID: 2999
			' (get) Token: 0x06001E17 RID: 7703 RVA: 0x0011506C File Offset: 0x0011326C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property VendorContactNoColumn As DataColumn
				Get
					Return Me.columnVendorContactNo
				End Get
			End Property

			' Token: 0x17000BB8 RID: 3000
			' (get) Token: 0x06001E18 RID: 7704 RVA: 0x00115084 File Offset: 0x00113284
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property VendorEmailIDColumn As DataColumn
				Get
					Return Me.columnVendorEmailID
				End Get
			End Property

			' Token: 0x17000BB9 RID: 3001
			' (get) Token: 0x06001E19 RID: 7705 RVA: 0x0011509C File Offset: 0x0011329C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property VendorGSTNoColumn As DataColumn
				Get
					Return Me.columnVendorGSTNo
				End Get
			End Property

			' Token: 0x17000BBA RID: 3002
			' (get) Token: 0x06001E1A RID: 7706 RVA: 0x001150B4 File Offset: 0x001132B4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property VendorPANNoColumn As DataColumn
				Get
					Return Me.columnVendorPANNo
				End Get
			End Property

			' Token: 0x17000BBB RID: 3003
			' (get) Token: 0x06001E1B RID: 7707 RVA: 0x001150CC File Offset: 0x001132CC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property BankNameColumn As DataColumn
				Get
					Return Me.columnBankName
				End Get
			End Property

			' Token: 0x17000BBC RID: 3004
			' (get) Token: 0x06001E1C RID: 7708 RVA: 0x001150E4 File Offset: 0x001132E4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property BankAddressColumn As DataColumn
				Get
					Return Me.columnBankAddress
				End Get
			End Property

			' Token: 0x17000BBD RID: 3005
			' (get) Token: 0x06001E1D RID: 7709 RVA: 0x001150FC File Offset: 0x001132FC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property AccountNoColumn As DataColumn
				Get
					Return Me.columnAccountNo
				End Get
			End Property

			' Token: 0x17000BBE RID: 3006
			' (get) Token: 0x06001E1E RID: 7710 RVA: 0x00115114 File Offset: 0x00113314
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property IFSCCodeColumn As DataColumn
				Get
					Return Me.columnIFSCCode
				End Get
			End Property

			' Token: 0x17000BBF RID: 3007
			' (get) Token: 0x06001E1F RID: 7711 RVA: 0x0011512C File Offset: 0x0011332C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property IBANNoColumn As DataColumn
				Get
					Return Me.columnIBANNo
				End Get
			End Property

			' Token: 0x17000BC0 RID: 3008
			' (get) Token: 0x06001E20 RID: 7712 RVA: 0x00115144 File Offset: 0x00113344
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property BankRoutingNoColumn As DataColumn
				Get
					Return Me.columnBankRoutingNo
				End Get
			End Property

			' Token: 0x17000BC1 RID: 3009
			' (get) Token: 0x06001E21 RID: 7713 RVA: 0x0011515C File Offset: 0x0011335C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property BankSortCodeColumn As DataColumn
				Get
					Return Me.columnBankSortCode
				End Get
			End Property

			' Token: 0x17000BC2 RID: 3010
			' (get) Token: 0x06001E22 RID: 7714 RVA: 0x00115174 File Offset: 0x00113374
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property SWIFTCodeColumn As DataColumn
				Get
					Return Me.columnSWIFTCode
				End Get
			End Property

			' Token: 0x17000BC3 RID: 3011
			' (get) Token: 0x06001E23 RID: 7715 RVA: 0x0011518C File Offset: 0x0011338C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property ModeOfPaymentColumn As DataColumn
				Get
					Return Me.columnModeOfPayment
				End Get
			End Property

			' Token: 0x17000BC4 RID: 3012
			' (get) Token: 0x06001E24 RID: 7716 RVA: 0x001151A4 File Offset: 0x001133A4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property DispatchedThroughColumn As DataColumn
				Get
					Return Me.columnDispatchedThrough
				End Get
			End Property

			' Token: 0x17000BC5 RID: 3013
			' (get) Token: 0x06001E25 RID: 7717 RVA: 0x001151BC File Offset: 0x001133BC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property PaymentTermsColumn As DataColumn
				Get
					Return Me.columnPaymentTerms
				End Get
			End Property

			' Token: 0x17000BC6 RID: 3014
			' (get) Token: 0x06001E26 RID: 7718 RVA: 0x001151D4 File Offset: 0x001133D4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property IncoTermsColumn As DataColumn
				Get
					Return Me.columnIncoTerms
				End Get
			End Property

			' Token: 0x17000BC7 RID: 3015
			' (get) Token: 0x06001E27 RID: 7719 RVA: 0x001151EC File Offset: 0x001133EC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property DeliveryTermsColumn As DataColumn
				Get
					Return Me.columnDeliveryTerms
				End Get
			End Property

			' Token: 0x17000BC8 RID: 3016
			' (get) Token: 0x06001E28 RID: 7720 RVA: 0x00115204 File Offset: 0x00113404
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property CurrencyColumn As DataColumn
				Get
					Return Me.columnCurrency
				End Get
			End Property

			' Token: 0x17000BC9 RID: 3017
			' (get) Token: 0x06001E29 RID: 7721 RVA: 0x0011521C File Offset: 0x0011341C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property CommentsColumn As DataColumn
				Get
					Return Me.columnComments
				End Get
			End Property

			' Token: 0x17000BCA RID: 3018
			' (get) Token: 0x06001E2A RID: 7722 RVA: 0x00115234 File Offset: 0x00113434
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property CreatedByColumn As DataColumn
				Get
					Return Me.columnCreatedBy
				End Get
			End Property

			' Token: 0x17000BCB RID: 3019
			' (get) Token: 0x06001E2B RID: 7723 RVA: 0x0011524C File Offset: 0x0011344C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property CreationDtColumn As DataColumn
				Get
					Return Me.columnCreationDt
				End Get
			End Property

			' Token: 0x17000BCC RID: 3020
			' (get) Token: 0x06001E2C RID: 7724 RVA: 0x00115264 File Offset: 0x00113464
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property ApprovedByColumn As DataColumn
				Get
					Return Me.columnApprovedBy
				End Get
			End Property

			' Token: 0x17000BCD RID: 3021
			' (get) Token: 0x06001E2D RID: 7725 RVA: 0x0011527C File Offset: 0x0011347C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property PrintedByColumn As DataColumn
				Get
					Return Me.columnPrintedBy
				End Get
			End Property

			' Token: 0x17000BCE RID: 3022
			' (get) Token: 0x06001E2E RID: 7726 RVA: 0x00115294 File Offset: 0x00113494
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property SrNoColumn As DataColumn
				Get
					Return Me.columnSrNo
				End Get
			End Property

			' Token: 0x17000BCF RID: 3023
			' (get) Token: 0x06001E2F RID: 7727 RVA: 0x001152AC File Offset: 0x001134AC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property ProductNameColumn As DataColumn
				Get
					Return Me.columnProductName
				End Get
			End Property

			' Token: 0x17000BD0 RID: 3024
			' (get) Token: 0x06001E30 RID: 7728 RVA: 0x001152C4 File Offset: 0x001134C4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property DescriptionColumn As DataColumn
				Get
					Return Me.columnDescription
				End Get
			End Property

			' Token: 0x17000BD1 RID: 3025
			' (get) Token: 0x06001E31 RID: 7729 RVA: 0x001152DC File Offset: 0x001134DC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property CatalogNoColumn As DataColumn
				Get
					Return Me.columnCatalogNo
				End Get
			End Property

			' Token: 0x17000BD2 RID: 3026
			' (get) Token: 0x06001E32 RID: 7730 RVA: 0x001152F4 File Offset: 0x001134F4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property HSNSACCodeColumn As DataColumn
				Get
					Return Me.columnHSNSACCode
				End Get
			End Property

			' Token: 0x17000BD3 RID: 3027
			' (get) Token: 0x06001E33 RID: 7731 RVA: 0x0011530C File Offset: 0x0011350C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property UOMColumn As DataColumn
				Get
					Return Me.columnUOM
				End Get
			End Property

			' Token: 0x17000BD4 RID: 3028
			' (get) Token: 0x06001E34 RID: 7732 RVA: 0x00115324 File Offset: 0x00113524
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property QuantityColumn As DataColumn
				Get
					Return Me.columnQuantity
				End Get
			End Property

			' Token: 0x17000BD5 RID: 3029
			' (get) Token: 0x06001E35 RID: 7733 RVA: 0x0011533C File Offset: 0x0011353C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property UnitPriceColumn As DataColumn
				Get
					Return Me.columnUnitPrice
				End Get
			End Property

			' Token: 0x17000BD6 RID: 3030
			' (get) Token: 0x06001E36 RID: 7734 RVA: 0x00115354 File Offset: 0x00113554
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property BasicValueColumn As DataColumn
				Get
					Return Me.columnBasicValue
				End Get
			End Property

			' Token: 0x17000BD7 RID: 3031
			' (get) Token: 0x06001E37 RID: 7735 RVA: 0x0011536C File Offset: 0x0011356C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property DiscountPerColumn As DataColumn
				Get
					Return Me.columnDiscountPer
				End Get
			End Property

			' Token: 0x17000BD8 RID: 3032
			' (get) Token: 0x06001E38 RID: 7736 RVA: 0x00115384 File Offset: 0x00113584
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property DiscountAmtColumn As DataColumn
				Get
					Return Me.columnDiscountAmt
				End Get
			End Property

			' Token: 0x17000BD9 RID: 3033
			' (get) Token: 0x06001E39 RID: 7737 RVA: 0x0011539C File Offset: 0x0011359C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property NetAmtColumn As DataColumn
				Get
					Return Me.columnNetAmt
				End Get
			End Property

			' Token: 0x17000BDA RID: 3034
			' (get) Token: 0x06001E3A RID: 7738 RVA: 0x001153B4 File Offset: 0x001135B4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property TaxPerColumn As DataColumn
				Get
					Return Me.columnTaxPer
				End Get
			End Property

			' Token: 0x17000BDB RID: 3035
			' (get) Token: 0x06001E3B RID: 7739 RVA: 0x001153CC File Offset: 0x001135CC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property TaxAmtColumn As DataColumn
				Get
					Return Me.columnTaxAmt
				End Get
			End Property

			' Token: 0x17000BDC RID: 3036
			' (get) Token: 0x06001E3C RID: 7740 RVA: 0x001153E4 File Offset: 0x001135E4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property TransportationColumn As DataColumn
				Get
					Return Me.columnTransportation
				End Get
			End Property

			' Token: 0x17000BDD RID: 3037
			' (get) Token: 0x06001E3D RID: 7741 RVA: 0x001153FC File Offset: 0x001135FC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property FreightColumn As DataColumn
				Get
					Return Me.columnFreight
				End Get
			End Property

			' Token: 0x17000BDE RID: 3038
			' (get) Token: 0x06001E3E RID: 7742 RVA: 0x00115414 File Offset: 0x00113614
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property LoadingUnloadingColumn As DataColumn
				Get
					Return Me.columnLoadingUnloading
				End Get
			End Property

			' Token: 0x17000BDF RID: 3039
			' (get) Token: 0x06001E3F RID: 7743 RVA: 0x0011542C File Offset: 0x0011362C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property PackingColumn As DataColumn
				Get
					Return Me.columnPacking
				End Get
			End Property

			' Token: 0x17000BE0 RID: 3040
			' (get) Token: 0x06001E40 RID: 7744 RVA: 0x00115444 File Offset: 0x00113644
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property OtherChargesColumn As DataColumn
				Get
					Return Me.columnOtherCharges
				End Get
			End Property

			' Token: 0x17000BE1 RID: 3041
			' (get) Token: 0x06001E41 RID: 7745 RVA: 0x0011545C File Offset: 0x0011365C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property FinalAmtColumn As DataColumn
				Get
					Return Me.columnFinalAmt
				End Get
			End Property

			' Token: 0x17000BE2 RID: 3042
			' (get) Token: 0x06001E42 RID: 7746 RVA: 0x00115474 File Offset: 0x00113674
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			<Browsable(False)>
			Public ReadOnly Property Count As Integer
				Get
					Return MyBase.Rows.Count
				End Get
			End Property

			' Token: 0x17000BE3 RID: 3043
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Default Property Item(index As Integer) As PIMSDataSet.PORow
				Get
					Return CType(MyBase.Rows(index), PIMSDataSet.PORow)
				End Get
			End Property

			' Token: 0x14000001 RID: 1
			' (add) Token: 0x06001E44 RID: 7748 RVA: 0x001154B8 File Offset: 0x001136B8
			' (remove) Token: 0x06001E45 RID: 7749 RVA: 0x001154F0 File Offset: 0x001136F0
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Event PORowChanging As PIMSDataSet.PORowChangeEventHandler

			' Token: 0x14000002 RID: 2
			' (add) Token: 0x06001E46 RID: 7750 RVA: 0x00115528 File Offset: 0x00113728
			' (remove) Token: 0x06001E47 RID: 7751 RVA: 0x00115560 File Offset: 0x00113760
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Event PORowChanged As PIMSDataSet.PORowChangeEventHandler

			' Token: 0x14000003 RID: 3
			' (add) Token: 0x06001E48 RID: 7752 RVA: 0x00115598 File Offset: 0x00113798
			' (remove) Token: 0x06001E49 RID: 7753 RVA: 0x001155D0 File Offset: 0x001137D0
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Event PORowDeleting As PIMSDataSet.PORowChangeEventHandler

			' Token: 0x14000004 RID: 4
			' (add) Token: 0x06001E4A RID: 7754 RVA: 0x00115608 File Offset: 0x00113808
			' (remove) Token: 0x06001E4B RID: 7755 RVA: 0x00115640 File Offset: 0x00113840
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Event PORowDeleted As PIMSDataSet.PORowChangeEventHandler

			' Token: 0x06001E4C RID: 7756 RVA: 0x00115675 File Offset: 0x00113875
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub AddPORow(row As PIMSDataSet.PORow)
				MyBase.Rows.Add(row)
			End Sub

			' Token: 0x06001E4D RID: 7757 RVA: 0x00115688 File Offset: 0x00113888
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function AddPORow(POID As Integer, POType As String, PONo As String, PODt As DateTime, PRNo As String, PRDt As DateTime, ValidUpto As DateTime, DeliveryDt As DateTime, Department As String, InvoiceAddress As String, BillingEmailID As String, ShipAddress As String, ShippingEmailID As String, GSTNo As String, PANNo As String, VendorName As String, VendorBillingAddress As String, VendorContactPerson As String, VendorContactNo As String, VendorEmailID As String, VendorGSTNo As String, VendorPANNo As String, BankName As String, BankAddress As String, AccountNo As String, IFSCCode As String, IBANNo As String, BankRoutingNo As String, BankSortCode As String, SWIFTCode As String, ModeOfPayment As String, DispatchedThrough As String, PaymentTerms As String, IncoTerms As String, DeliveryTerms As String, Currency As String, Comments As String, CreatedBy As String, CreationDt As DateTime, ApprovedBy As String, PrintedBy As String, SrNo As Integer, ProductName As String, Description As String, CatalogNo As String, HSNSACCode As String, UOM As String, Quantity As Integer, UnitPrice As Double, BasicValue As Double, DiscountPer As Double, DiscountAmt As Double, NetAmt As Double, TaxPer As String, TaxAmt As Double, Transportation As Double, Freight As Double, LoadingUnloading As Double, Packing As Double, OtherCharges As Double, FinalAmt As Double) As PIMSDataSet.PORow
				Dim porow As PIMSDataSet.PORow = CType(MyBase.NewRow(), PIMSDataSet.PORow)
				Dim array As Object() = New Object() { POID, POType, PONo, PODt, PRNo, PRDt, ValidUpto, DeliveryDt, Department, InvoiceAddress, BillingEmailID, ShipAddress, ShippingEmailID, GSTNo, PANNo, VendorName, VendorBillingAddress, VendorContactPerson, VendorContactNo, VendorEmailID, VendorGSTNo, VendorPANNo, BankName, BankAddress, AccountNo, IFSCCode, IBANNo, BankRoutingNo, BankSortCode, SWIFTCode, ModeOfPayment, DispatchedThrough, PaymentTerms, IncoTerms, DeliveryTerms, Currency, Comments, CreatedBy, CreationDt, ApprovedBy, PrintedBy, SrNo, ProductName, Description, CatalogNo, HSNSACCode, UOM, Quantity, UnitPrice, BasicValue, DiscountPer, DiscountAmt, NetAmt, TaxPer, TaxAmt, Transportation, Freight, LoadingUnloading, Packing, OtherCharges, FinalAmt }
				porow.ItemArray = array
				MyBase.Rows.Add(porow)
				Return porow
			End Function

			' Token: 0x06001E4E RID: 7758 RVA: 0x0011588C File Offset: 0x00113A8C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Overrides Function Clone() As DataTable
				Dim podataTable As PIMSDataSet.PODataTable = CType(MyBase.Clone(), PIMSDataSet.PODataTable)
				podataTable.InitVars()
				Return podataTable
			End Function

			' Token: 0x06001E4F RID: 7759 RVA: 0x001158B4 File Offset: 0x00113AB4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Function CreateInstance() As DataTable
				Return New PIMSDataSet.PODataTable()
			End Function

			' Token: 0x06001E50 RID: 7760 RVA: 0x001158CC File Offset: 0x00113ACC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Friend Sub InitVars()
				Me.columnPOID = MyBase.Columns("POID")
				Me.columnPOType = MyBase.Columns("POType")
				Me.columnPONo = MyBase.Columns("PONo")
				Me.columnPODt = MyBase.Columns("PODt")
				Me.columnPRNo = MyBase.Columns("PRNo")
				Me.columnPRDt = MyBase.Columns("PRDt")
				Me.columnValidUpto = MyBase.Columns("ValidUpto")
				Me.columnDeliveryDt = MyBase.Columns("DeliveryDt")
				Me.columnDepartment = MyBase.Columns("Department")
				Me.columnInvoiceAddress = MyBase.Columns("InvoiceAddress")
				Me.columnBillingEmailID = MyBase.Columns("BillingEmailID")
				Me.columnShipAddress = MyBase.Columns("ShipAddress")
				Me.columnShippingEmailID = MyBase.Columns("ShippingEmailID")
				Me.columnGSTNo = MyBase.Columns("GSTNo")
				Me.columnPANNo = MyBase.Columns("PANNo")
				Me.columnVendorName = MyBase.Columns("VendorName")
				Me.columnVendorBillingAddress = MyBase.Columns("VendorBillingAddress")
				Me.columnVendorContactPerson = MyBase.Columns("VendorContactPerson")
				Me.columnVendorContactNo = MyBase.Columns("VendorContactNo")
				Me.columnVendorEmailID = MyBase.Columns("VendorEmailID")
				Me.columnVendorGSTNo = MyBase.Columns("VendorGSTNo")
				Me.columnVendorPANNo = MyBase.Columns("VendorPANNo")
				Me.columnBankName = MyBase.Columns("BankName")
				Me.columnBankAddress = MyBase.Columns("BankAddress")
				Me.columnAccountNo = MyBase.Columns("AccountNo")
				Me.columnIFSCCode = MyBase.Columns("IFSCCode")
				Me.columnIBANNo = MyBase.Columns("IBANNo")
				Me.columnBankRoutingNo = MyBase.Columns("BankRoutingNo")
				Me.columnBankSortCode = MyBase.Columns("BankSortCode")
				Me.columnSWIFTCode = MyBase.Columns("SWIFTCode")
				Me.columnModeOfPayment = MyBase.Columns("ModeOfPayment")
				Me.columnDispatchedThrough = MyBase.Columns("DispatchedThrough")
				Me.columnPaymentTerms = MyBase.Columns("PaymentTerms")
				Me.columnIncoTerms = MyBase.Columns("IncoTerms")
				Me.columnDeliveryTerms = MyBase.Columns("DeliveryTerms")
				Me.columnCurrency = MyBase.Columns("Currency")
				Me.columnComments = MyBase.Columns("Comments")
				Me.columnCreatedBy = MyBase.Columns("CreatedBy")
				Me.columnCreationDt = MyBase.Columns("CreationDt")
				Me.columnApprovedBy = MyBase.Columns("ApprovedBy")
				Me.columnPrintedBy = MyBase.Columns("PrintedBy")
				Me.columnSrNo = MyBase.Columns("SrNo")
				Me.columnProductName = MyBase.Columns("ProductName")
				Me.columnDescription = MyBase.Columns("Description")
				Me.columnCatalogNo = MyBase.Columns("CatalogNo")
				Me.columnHSNSACCode = MyBase.Columns("HSNSACCode")
				Me.columnUOM = MyBase.Columns("UOM")
				Me.columnQuantity = MyBase.Columns("Quantity")
				Me.columnUnitPrice = MyBase.Columns("UnitPrice")
				Me.columnBasicValue = MyBase.Columns("BasicValue")
				Me.columnDiscountPer = MyBase.Columns("DiscountPer")
				Me.columnDiscountAmt = MyBase.Columns("DiscountAmt")
				Me.columnNetAmt = MyBase.Columns("NetAmt")
				Me.columnTaxPer = MyBase.Columns("TaxPer")
				Me.columnTaxAmt = MyBase.Columns("TaxAmt")
				Me.columnTransportation = MyBase.Columns("Transportation")
				Me.columnFreight = MyBase.Columns("Freight")
				Me.columnLoadingUnloading = MyBase.Columns("LoadingUnloading")
				Me.columnPacking = MyBase.Columns("Packing")
				Me.columnOtherCharges = MyBase.Columns("OtherCharges")
				Me.columnFinalAmt = MyBase.Columns("FinalAmt")
			End Sub

			' Token: 0x06001E51 RID: 7761 RVA: 0x00115E18 File Offset: 0x00114018
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Private Sub InitClass()
				Me.columnPOID = New DataColumn("POID", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnPOID)
				Me.columnPOType = New DataColumn("POType", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnPOType)
				Me.columnPONo = New DataColumn("PONo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnPONo)
				Me.columnPODt = New DataColumn("PODt", GetType(DateTime), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnPODt)
				Me.columnPRNo = New DataColumn("PRNo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnPRNo)
				Me.columnPRDt = New DataColumn("PRDt", GetType(DateTime), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnPRDt)
				Me.columnValidUpto = New DataColumn("ValidUpto", GetType(DateTime), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnValidUpto)
				Me.columnDeliveryDt = New DataColumn("DeliveryDt", GetType(DateTime), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDeliveryDt)
				Me.columnDepartment = New DataColumn("Department", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDepartment)
				Me.columnInvoiceAddress = New DataColumn("InvoiceAddress", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnInvoiceAddress)
				Me.columnBillingEmailID = New DataColumn("BillingEmailID", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnBillingEmailID)
				Me.columnShipAddress = New DataColumn("ShipAddress", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnShipAddress)
				Me.columnShippingEmailID = New DataColumn("ShippingEmailID", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnShippingEmailID)
				Me.columnGSTNo = New DataColumn("GSTNo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnGSTNo)
				Me.columnPANNo = New DataColumn("PANNo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnPANNo)
				Me.columnVendorName = New DataColumn("VendorName", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnVendorName)
				Me.columnVendorBillingAddress = New DataColumn("VendorBillingAddress", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnVendorBillingAddress)
				Me.columnVendorContactPerson = New DataColumn("VendorContactPerson", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnVendorContactPerson)
				Me.columnVendorContactNo = New DataColumn("VendorContactNo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnVendorContactNo)
				Me.columnVendorEmailID = New DataColumn("VendorEmailID", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnVendorEmailID)
				Me.columnVendorGSTNo = New DataColumn("VendorGSTNo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnVendorGSTNo)
				Me.columnVendorPANNo = New DataColumn("VendorPANNo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnVendorPANNo)
				Me.columnBankName = New DataColumn("BankName", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnBankName)
				Me.columnBankAddress = New DataColumn("BankAddress", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnBankAddress)
				Me.columnAccountNo = New DataColumn("AccountNo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnAccountNo)
				Me.columnIFSCCode = New DataColumn("IFSCCode", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnIFSCCode)
				Me.columnIBANNo = New DataColumn("IBANNo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnIBANNo)
				Me.columnBankRoutingNo = New DataColumn("BankRoutingNo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnBankRoutingNo)
				Me.columnBankSortCode = New DataColumn("BankSortCode", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnBankSortCode)
				Me.columnSWIFTCode = New DataColumn("SWIFTCode", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnSWIFTCode)
				Me.columnModeOfPayment = New DataColumn("ModeOfPayment", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnModeOfPayment)
				Me.columnDispatchedThrough = New DataColumn("DispatchedThrough", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDispatchedThrough)
				Me.columnPaymentTerms = New DataColumn("PaymentTerms", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnPaymentTerms)
				Me.columnIncoTerms = New DataColumn("IncoTerms", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnIncoTerms)
				Me.columnDeliveryTerms = New DataColumn("DeliveryTerms", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDeliveryTerms)
				Me.columnCurrency = New DataColumn("Currency", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnCurrency)
				Me.columnComments = New DataColumn("Comments", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnComments)
				Me.columnCreatedBy = New DataColumn("CreatedBy", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnCreatedBy)
				Me.columnCreationDt = New DataColumn("CreationDt", GetType(DateTime), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnCreationDt)
				Me.columnApprovedBy = New DataColumn("ApprovedBy", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnApprovedBy)
				Me.columnPrintedBy = New DataColumn("PrintedBy", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnPrintedBy)
				Me.columnSrNo = New DataColumn("SrNo", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnSrNo)
				Me.columnProductName = New DataColumn("ProductName", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnProductName)
				Me.columnDescription = New DataColumn("Description", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDescription)
				Me.columnCatalogNo = New DataColumn("CatalogNo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnCatalogNo)
				Me.columnHSNSACCode = New DataColumn("HSNSACCode", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnHSNSACCode)
				Me.columnUOM = New DataColumn("UOM", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnUOM)
				Me.columnQuantity = New DataColumn("Quantity", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnQuantity)
				Me.columnUnitPrice = New DataColumn("UnitPrice", GetType(Double), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnUnitPrice)
				Me.columnBasicValue = New DataColumn("BasicValue", GetType(Double), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnBasicValue)
				Me.columnDiscountPer = New DataColumn("DiscountPer", GetType(Double), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDiscountPer)
				Me.columnDiscountAmt = New DataColumn("DiscountAmt", GetType(Double), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDiscountAmt)
				Me.columnNetAmt = New DataColumn("NetAmt", GetType(Double), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnNetAmt)
				Me.columnTaxPer = New DataColumn("TaxPer", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnTaxPer)
				Me.columnTaxAmt = New DataColumn("TaxAmt", GetType(Double), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnTaxAmt)
				Me.columnTransportation = New DataColumn("Transportation", GetType(Double), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnTransportation)
				Me.columnFreight = New DataColumn("Freight", GetType(Double), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnFreight)
				Me.columnLoadingUnloading = New DataColumn("LoadingUnloading", GetType(Double), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnLoadingUnloading)
				Me.columnPacking = New DataColumn("Packing", GetType(Double), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnPacking)
				Me.columnOtherCharges = New DataColumn("OtherCharges", GetType(Double), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnOtherCharges)
				Me.columnFinalAmt = New DataColumn("FinalAmt", GetType(Double), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnFinalAmt)
			End Sub

			' Token: 0x06001E52 RID: 7762 RVA: 0x0011691C File Offset: 0x00114B1C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function NewPORow() As PIMSDataSet.PORow
				Return CType(MyBase.NewRow(), PIMSDataSet.PORow)
			End Function

			' Token: 0x06001E53 RID: 7763 RVA: 0x0011693C File Offset: 0x00114B3C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New PIMSDataSet.PORow(builder)
			End Function

			' Token: 0x06001E54 RID: 7764 RVA: 0x00116954 File Offset: 0x00114B54
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Function GetRowType() As Type
				Return GetType(PIMSDataSet.PORow)
			End Function

			' Token: 0x06001E55 RID: 7765 RVA: 0x00116970 File Offset: 0x00114B70
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.PORowChangedEvent IsNot Nothing
				If flag Then
					Dim porowChangedEvent As PIMSDataSet.PORowChangeEventHandler = Me.PORowChangedEvent
					If porowChangedEvent IsNot Nothing Then
						porowChangedEvent(Me, New PIMSDataSet.PORowChangeEvent(CType(e.Row, PIMSDataSet.PORow), e.Action))
					End If
				End If
			End Sub

			' Token: 0x06001E56 RID: 7766 RVA: 0x001169C0 File Offset: 0x00114BC0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.PORowChangingEvent IsNot Nothing
				If flag Then
					Dim porowChangingEvent As PIMSDataSet.PORowChangeEventHandler = Me.PORowChangingEvent
					If porowChangingEvent IsNot Nothing Then
						porowChangingEvent(Me, New PIMSDataSet.PORowChangeEvent(CType(e.Row, PIMSDataSet.PORow), e.Action))
					End If
				End If
			End Sub

			' Token: 0x06001E57 RID: 7767 RVA: 0x00116A10 File Offset: 0x00114C10
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.PORowDeletedEvent IsNot Nothing
				If flag Then
					Dim porowDeletedEvent As PIMSDataSet.PORowChangeEventHandler = Me.PORowDeletedEvent
					If porowDeletedEvent IsNot Nothing Then
						porowDeletedEvent(Me, New PIMSDataSet.PORowChangeEvent(CType(e.Row, PIMSDataSet.PORow), e.Action))
					End If
				End If
			End Sub

			' Token: 0x06001E58 RID: 7768 RVA: 0x00116A60 File Offset: 0x00114C60
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.PORowDeletingEvent IsNot Nothing
				If flag Then
					Dim porowDeletingEvent As PIMSDataSet.PORowChangeEventHandler = Me.PORowDeletingEvent
					If porowDeletingEvent IsNot Nothing Then
						porowDeletingEvent(Me, New PIMSDataSet.PORowChangeEvent(CType(e.Row, PIMSDataSet.PORow), e.Action))
					End If
				End If
			End Sub

			' Token: 0x06001E59 RID: 7769 RVA: 0x00116AAD File Offset: 0x00114CAD
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub RemovePORow(row As PIMSDataSet.PORow)
				MyBase.Rows.Remove(row)
			End Sub

			' Token: 0x06001E5A RID: 7770 RVA: 0x00116AC0 File Offset: 0x00114CC0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim pimsdataSet As PIMSDataSet = New PIMSDataSet()
				Dim xmlSchemaAny As XmlSchemaAny = New XmlSchemaAny()
				xmlSchemaAny.[Namespace] = "http://www.w3.org/2001/XMLSchema"
				xmlSchemaAny.MinOccurs = 0D
				xmlSchemaAny.MaxOccurs = Decimal.MaxValue
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax
				xmlSchemaSequence.Items.Add(xmlSchemaAny)
				Dim xmlSchemaAny2 As XmlSchemaAny = New XmlSchemaAny()
				xmlSchemaAny2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
				xmlSchemaAny2.MinOccurs = 1D
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax
				xmlSchemaSequence.Items.Add(xmlSchemaAny2)
				Dim xmlSchemaAttribute As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute.Name = "namespace"
				xmlSchemaAttribute.FixedValue = pimsdataSet.[Namespace]
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute)
				Dim xmlSchemaAttribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute2.Name = "tableTypeName"
				xmlSchemaAttribute2.FixedValue = "PODataTable"
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2)
				xmlSchemaComplexType.Particle = xmlSchemaSequence
				Dim schemaSerializable As XmlSchema = pimsdataSet.GetSchemaSerializable()
				Dim flag As Boolean = xs.Contains(schemaSerializable.TargetNamespace)
				If flag Then
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim memoryStream2 As MemoryStream = New MemoryStream()
					Try
						schemaSerializable.Write(memoryStream)
						For Each obj As Object In xs.Schemas(schemaSerializable.TargetNamespace)
							Dim xmlSchema As XmlSchema = CType(obj, XmlSchema)
							memoryStream2.SetLength(0L)
							xmlSchema.Write(memoryStream2)
							Dim flag2 As Boolean = memoryStream.Length = memoryStream2.Length
							If flag2 Then
								memoryStream.Position = 0L
								memoryStream2.Position = 0L
								While memoryStream.Position <> memoryStream.Length AndAlso memoryStream.ReadByte() = memoryStream2.ReadByte()
								End While
								Dim flag3 As Boolean = memoryStream.Position = memoryStream.Length
								If flag3 Then
									Return xmlSchemaComplexType
								End If
							End If
						Next
					Finally
						Dim flag4 As Boolean = memoryStream IsNot Nothing
						If flag4 Then
							memoryStream.Close()
						End If
						Dim flag5 As Boolean = memoryStream2 IsNot Nothing
						If flag5 Then
							memoryStream2.Close()
						End If
					End Try
				End If
				xs.Add(schemaSerializable)
				Return xmlSchemaComplexType
			End Function

			' Token: 0x04000CFB RID: 3323
			Private columnPOID As DataColumn

			' Token: 0x04000CFC RID: 3324
			Private columnPOType As DataColumn

			' Token: 0x04000CFD RID: 3325
			Private columnPONo As DataColumn

			' Token: 0x04000CFE RID: 3326
			Private columnPODt As DataColumn

			' Token: 0x04000CFF RID: 3327
			Private columnPRNo As DataColumn

			' Token: 0x04000D00 RID: 3328
			Private columnPRDt As DataColumn

			' Token: 0x04000D01 RID: 3329
			Private columnValidUpto As DataColumn

			' Token: 0x04000D02 RID: 3330
			Private columnDeliveryDt As DataColumn

			' Token: 0x04000D03 RID: 3331
			Private columnDepartment As DataColumn

			' Token: 0x04000D04 RID: 3332
			Private columnInvoiceAddress As DataColumn

			' Token: 0x04000D05 RID: 3333
			Private columnBillingEmailID As DataColumn

			' Token: 0x04000D06 RID: 3334
			Private columnShipAddress As DataColumn

			' Token: 0x04000D07 RID: 3335
			Private columnShippingEmailID As DataColumn

			' Token: 0x04000D08 RID: 3336
			Private columnGSTNo As DataColumn

			' Token: 0x04000D09 RID: 3337
			Private columnPANNo As DataColumn

			' Token: 0x04000D0A RID: 3338
			Private columnVendorName As DataColumn

			' Token: 0x04000D0B RID: 3339
			Private columnVendorBillingAddress As DataColumn

			' Token: 0x04000D0C RID: 3340
			Private columnVendorContactPerson As DataColumn

			' Token: 0x04000D0D RID: 3341
			Private columnVendorContactNo As DataColumn

			' Token: 0x04000D0E RID: 3342
			Private columnVendorEmailID As DataColumn

			' Token: 0x04000D0F RID: 3343
			Private columnVendorGSTNo As DataColumn

			' Token: 0x04000D10 RID: 3344
			Private columnVendorPANNo As DataColumn

			' Token: 0x04000D11 RID: 3345
			Private columnBankName As DataColumn

			' Token: 0x04000D12 RID: 3346
			Private columnBankAddress As DataColumn

			' Token: 0x04000D13 RID: 3347
			Private columnAccountNo As DataColumn

			' Token: 0x04000D14 RID: 3348
			Private columnIFSCCode As DataColumn

			' Token: 0x04000D15 RID: 3349
			Private columnIBANNo As DataColumn

			' Token: 0x04000D16 RID: 3350
			Private columnBankRoutingNo As DataColumn

			' Token: 0x04000D17 RID: 3351
			Private columnBankSortCode As DataColumn

			' Token: 0x04000D18 RID: 3352
			Private columnSWIFTCode As DataColumn

			' Token: 0x04000D19 RID: 3353
			Private columnModeOfPayment As DataColumn

			' Token: 0x04000D1A RID: 3354
			Private columnDispatchedThrough As DataColumn

			' Token: 0x04000D1B RID: 3355
			Private columnPaymentTerms As DataColumn

			' Token: 0x04000D1C RID: 3356
			Private columnIncoTerms As DataColumn

			' Token: 0x04000D1D RID: 3357
			Private columnDeliveryTerms As DataColumn

			' Token: 0x04000D1E RID: 3358
			Private columnCurrency As DataColumn

			' Token: 0x04000D1F RID: 3359
			Private columnComments As DataColumn

			' Token: 0x04000D20 RID: 3360
			Private columnCreatedBy As DataColumn

			' Token: 0x04000D21 RID: 3361
			Private columnCreationDt As DataColumn

			' Token: 0x04000D22 RID: 3362
			Private columnApprovedBy As DataColumn

			' Token: 0x04000D23 RID: 3363
			Private columnPrintedBy As DataColumn

			' Token: 0x04000D24 RID: 3364
			Private columnSrNo As DataColumn

			' Token: 0x04000D25 RID: 3365
			Private columnProductName As DataColumn

			' Token: 0x04000D26 RID: 3366
			Private columnDescription As DataColumn

			' Token: 0x04000D27 RID: 3367
			Private columnCatalogNo As DataColumn

			' Token: 0x04000D28 RID: 3368
			Private columnHSNSACCode As DataColumn

			' Token: 0x04000D29 RID: 3369
			Private columnUOM As DataColumn

			' Token: 0x04000D2A RID: 3370
			Private columnQuantity As DataColumn

			' Token: 0x04000D2B RID: 3371
			Private columnUnitPrice As DataColumn

			' Token: 0x04000D2C RID: 3372
			Private columnBasicValue As DataColumn

			' Token: 0x04000D2D RID: 3373
			Private columnDiscountPer As DataColumn

			' Token: 0x04000D2E RID: 3374
			Private columnDiscountAmt As DataColumn

			' Token: 0x04000D2F RID: 3375
			Private columnNetAmt As DataColumn

			' Token: 0x04000D30 RID: 3376
			Private columnTaxPer As DataColumn

			' Token: 0x04000D31 RID: 3377
			Private columnTaxAmt As DataColumn

			' Token: 0x04000D32 RID: 3378
			Private columnTransportation As DataColumn

			' Token: 0x04000D33 RID: 3379
			Private columnFreight As DataColumn

			' Token: 0x04000D34 RID: 3380
			Private columnLoadingUnloading As DataColumn

			' Token: 0x04000D35 RID: 3381
			Private columnPacking As DataColumn

			' Token: 0x04000D36 RID: 3382
			Private columnOtherCharges As DataColumn

			' Token: 0x04000D37 RID: 3383
			Private columnFinalAmt As DataColumn
		End Class

		' Token: 0x02000078 RID: 120
		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class TestDataTable
			Inherits TypedTableBase(Of PIMSDataSet.TestRow)

			' Token: 0x06001E5B RID: 7771 RVA: 0x00116D14 File Offset: 0x00114F14
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub New()
				MyBase.TableName = "Test"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			' Token: 0x06001E5C RID: 7772 RVA: 0x00116D40 File Offset: 0x00114F40
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Friend Sub New(table As DataTable)
				MyBase.TableName = table.TableName
				Dim flag As Boolean = table.CaseSensitive <> table.DataSet.CaseSensitive
				If flag Then
					MyBase.CaseSensitive = table.CaseSensitive
				End If
				Dim flag2 As Boolean = Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0
				If flag2 Then
					MyBase.Locale = table.Locale
				End If
				Dim flag3 As Boolean = Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0
				If flag3 Then
					MyBase.[Namespace] = table.[Namespace]
				End If
				MyBase.Prefix = table.Prefix
				MyBase.MinimumCapacity = table.MinimumCapacity
			End Sub

			' Token: 0x06001E5D RID: 7773 RVA: 0x00116E09 File Offset: 0x00115009
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.New(info, context)
				Me.InitVars()
			End Sub

			' Token: 0x17000BE4 RID: 3044
			' (get) Token: 0x06001E5E RID: 7774 RVA: 0x00116E1C File Offset: 0x0011501C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property DataFieldColumn As DataColumn
				Get
					Return Me.columnDataField
				End Get
			End Property

			' Token: 0x17000BE5 RID: 3045
			' (get) Token: 0x06001E5F RID: 7775 RVA: 0x00116E34 File Offset: 0x00115034
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			<Browsable(False)>
			Public ReadOnly Property Count As Integer
				Get
					Return MyBase.Rows.Count
				End Get
			End Property

			' Token: 0x17000BE6 RID: 3046
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Default Property Item(index As Integer) As PIMSDataSet.TestRow
				Get
					Return CType(MyBase.Rows(index), PIMSDataSet.TestRow)
				End Get
			End Property

			' Token: 0x14000005 RID: 5
			' (add) Token: 0x06001E61 RID: 7777 RVA: 0x00116E78 File Offset: 0x00115078
			' (remove) Token: 0x06001E62 RID: 7778 RVA: 0x00116EB0 File Offset: 0x001150B0
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Event TestRowChanging As PIMSDataSet.TestRowChangeEventHandler

			' Token: 0x14000006 RID: 6
			' (add) Token: 0x06001E63 RID: 7779 RVA: 0x00116EE8 File Offset: 0x001150E8
			' (remove) Token: 0x06001E64 RID: 7780 RVA: 0x00116F20 File Offset: 0x00115120
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Event TestRowChanged As PIMSDataSet.TestRowChangeEventHandler

			' Token: 0x14000007 RID: 7
			' (add) Token: 0x06001E65 RID: 7781 RVA: 0x00116F58 File Offset: 0x00115158
			' (remove) Token: 0x06001E66 RID: 7782 RVA: 0x00116F90 File Offset: 0x00115190
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Event TestRowDeleting As PIMSDataSet.TestRowChangeEventHandler

			' Token: 0x14000008 RID: 8
			' (add) Token: 0x06001E67 RID: 7783 RVA: 0x00116FC8 File Offset: 0x001151C8
			' (remove) Token: 0x06001E68 RID: 7784 RVA: 0x00117000 File Offset: 0x00115200
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Event TestRowDeleted As PIMSDataSet.TestRowChangeEventHandler

			' Token: 0x06001E69 RID: 7785 RVA: 0x00117035 File Offset: 0x00115235
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub AddTestRow(row As PIMSDataSet.TestRow)
				MyBase.Rows.Add(row)
			End Sub

			' Token: 0x06001E6A RID: 7786 RVA: 0x00117048 File Offset: 0x00115248
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function AddTestRow(DataField As String) As PIMSDataSet.TestRow
				Dim testRow As PIMSDataSet.TestRow = CType(MyBase.NewRow(), PIMSDataSet.TestRow)
				Dim array As Object() = New Object() { DataField }
				testRow.ItemArray = array
				MyBase.Rows.Add(testRow)
				Return testRow
			End Function

			' Token: 0x06001E6B RID: 7787 RVA: 0x00117088 File Offset: 0x00115288
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Overrides Function Clone() As DataTable
				Dim testDataTable As PIMSDataSet.TestDataTable = CType(MyBase.Clone(), PIMSDataSet.TestDataTable)
				testDataTable.InitVars()
				Return testDataTable
			End Function

			' Token: 0x06001E6C RID: 7788 RVA: 0x001170B0 File Offset: 0x001152B0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Function CreateInstance() As DataTable
				Return New PIMSDataSet.TestDataTable()
			End Function

			' Token: 0x06001E6D RID: 7789 RVA: 0x001170C7 File Offset: 0x001152C7
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Friend Sub InitVars()
				Me.columnDataField = MyBase.Columns("DataField")
			End Sub

			' Token: 0x06001E6E RID: 7790 RVA: 0x001170E0 File Offset: 0x001152E0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Private Sub InitClass()
				Me.columnDataField = New DataColumn("DataField", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDataField)
			End Sub

			' Token: 0x06001E6F RID: 7791 RVA: 0x00117114 File Offset: 0x00115314
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function NewTestRow() As PIMSDataSet.TestRow
				Return CType(MyBase.NewRow(), PIMSDataSet.TestRow)
			End Function

			' Token: 0x06001E70 RID: 7792 RVA: 0x00117134 File Offset: 0x00115334
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New PIMSDataSet.TestRow(builder)
			End Function

			' Token: 0x06001E71 RID: 7793 RVA: 0x0011714C File Offset: 0x0011534C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Function GetRowType() As Type
				Return GetType(PIMSDataSet.TestRow)
			End Function

			' Token: 0x06001E72 RID: 7794 RVA: 0x00117168 File Offset: 0x00115368
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.TestRowChangedEvent IsNot Nothing
				If flag Then
					Dim testRowChangedEvent As PIMSDataSet.TestRowChangeEventHandler = Me.TestRowChangedEvent
					If testRowChangedEvent IsNot Nothing Then
						testRowChangedEvent(Me, New PIMSDataSet.TestRowChangeEvent(CType(e.Row, PIMSDataSet.TestRow), e.Action))
					End If
				End If
			End Sub

			' Token: 0x06001E73 RID: 7795 RVA: 0x001171B8 File Offset: 0x001153B8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.TestRowChangingEvent IsNot Nothing
				If flag Then
					Dim testRowChangingEvent As PIMSDataSet.TestRowChangeEventHandler = Me.TestRowChangingEvent
					If testRowChangingEvent IsNot Nothing Then
						testRowChangingEvent(Me, New PIMSDataSet.TestRowChangeEvent(CType(e.Row, PIMSDataSet.TestRow), e.Action))
					End If
				End If
			End Sub

			' Token: 0x06001E74 RID: 7796 RVA: 0x00117208 File Offset: 0x00115408
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.TestRowDeletedEvent IsNot Nothing
				If flag Then
					Dim testRowDeletedEvent As PIMSDataSet.TestRowChangeEventHandler = Me.TestRowDeletedEvent
					If testRowDeletedEvent IsNot Nothing Then
						testRowDeletedEvent(Me, New PIMSDataSet.TestRowChangeEvent(CType(e.Row, PIMSDataSet.TestRow), e.Action))
					End If
				End If
			End Sub

			' Token: 0x06001E75 RID: 7797 RVA: 0x00117258 File Offset: 0x00115458
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.TestRowDeletingEvent IsNot Nothing
				If flag Then
					Dim testRowDeletingEvent As PIMSDataSet.TestRowChangeEventHandler = Me.TestRowDeletingEvent
					If testRowDeletingEvent IsNot Nothing Then
						testRowDeletingEvent(Me, New PIMSDataSet.TestRowChangeEvent(CType(e.Row, PIMSDataSet.TestRow), e.Action))
					End If
				End If
			End Sub

			' Token: 0x06001E76 RID: 7798 RVA: 0x001172A5 File Offset: 0x001154A5
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub RemoveTestRow(row As PIMSDataSet.TestRow)
				MyBase.Rows.Remove(row)
			End Sub

			' Token: 0x06001E77 RID: 7799 RVA: 0x001172B8 File Offset: 0x001154B8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim pimsdataSet As PIMSDataSet = New PIMSDataSet()
				Dim xmlSchemaAny As XmlSchemaAny = New XmlSchemaAny()
				xmlSchemaAny.[Namespace] = "http://www.w3.org/2001/XMLSchema"
				xmlSchemaAny.MinOccurs = 0D
				xmlSchemaAny.MaxOccurs = Decimal.MaxValue
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax
				xmlSchemaSequence.Items.Add(xmlSchemaAny)
				Dim xmlSchemaAny2 As XmlSchemaAny = New XmlSchemaAny()
				xmlSchemaAny2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
				xmlSchemaAny2.MinOccurs = 1D
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax
				xmlSchemaSequence.Items.Add(xmlSchemaAny2)
				Dim xmlSchemaAttribute As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute.Name = "namespace"
				xmlSchemaAttribute.FixedValue = pimsdataSet.[Namespace]
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute)
				Dim xmlSchemaAttribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute2.Name = "tableTypeName"
				xmlSchemaAttribute2.FixedValue = "TestDataTable"
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2)
				xmlSchemaComplexType.Particle = xmlSchemaSequence
				Dim schemaSerializable As XmlSchema = pimsdataSet.GetSchemaSerializable()
				Dim flag As Boolean = xs.Contains(schemaSerializable.TargetNamespace)
				If flag Then
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim memoryStream2 As MemoryStream = New MemoryStream()
					Try
						schemaSerializable.Write(memoryStream)
						For Each obj As Object In xs.Schemas(schemaSerializable.TargetNamespace)
							Dim xmlSchema As XmlSchema = CType(obj, XmlSchema)
							memoryStream2.SetLength(0L)
							xmlSchema.Write(memoryStream2)
							Dim flag2 As Boolean = memoryStream.Length = memoryStream2.Length
							If flag2 Then
								memoryStream.Position = 0L
								memoryStream2.Position = 0L
								While memoryStream.Position <> memoryStream.Length AndAlso memoryStream.ReadByte() = memoryStream2.ReadByte()
								End While
								Dim flag3 As Boolean = memoryStream.Position = memoryStream.Length
								If flag3 Then
									Return xmlSchemaComplexType
								End If
							End If
						Next
					Finally
						Dim flag4 As Boolean = memoryStream IsNot Nothing
						If flag4 Then
							memoryStream.Close()
						End If
						Dim flag5 As Boolean = memoryStream2 IsNot Nothing
						If flag5 Then
							memoryStream2.Close()
						End If
					End Try
				End If
				xs.Add(schemaSerializable)
				Return xmlSchemaComplexType
			End Function

			' Token: 0x04000D3C RID: 3388
			Private columnDataField As DataColumn
		End Class

		' Token: 0x02000079 RID: 121
		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class QCDataTable
			Inherits TypedTableBase(Of PIMSDataSet.QCRow)

			' Token: 0x06001E78 RID: 7800 RVA: 0x0011750C File Offset: 0x0011570C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub New()
				MyBase.TableName = "QC"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			' Token: 0x06001E79 RID: 7801 RVA: 0x00117538 File Offset: 0x00115738
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Friend Sub New(table As DataTable)
				MyBase.TableName = table.TableName
				Dim flag As Boolean = table.CaseSensitive <> table.DataSet.CaseSensitive
				If flag Then
					MyBase.CaseSensitive = table.CaseSensitive
				End If
				Dim flag2 As Boolean = Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0
				If flag2 Then
					MyBase.Locale = table.Locale
				End If
				Dim flag3 As Boolean = Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0
				If flag3 Then
					MyBase.[Namespace] = table.[Namespace]
				End If
				MyBase.Prefix = table.Prefix
				MyBase.MinimumCapacity = table.MinimumCapacity
			End Sub

			' Token: 0x06001E7A RID: 7802 RVA: 0x00117601 File Offset: 0x00115801
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.New(info, context)
				Me.InitVars()
			End Sub

			' Token: 0x17000BE7 RID: 3047
			' (get) Token: 0x06001E7B RID: 7803 RVA: 0x00117614 File Offset: 0x00115814
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property _RMNo_Column As DataColumn
				Get
					Return Me._columnRMNo_
				End Get
			End Property

			' Token: 0x17000BE8 RID: 3048
			' (get) Token: 0x06001E7C RID: 7804 RVA: 0x0011762C File Offset: 0x0011582C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property FormatNoColumn As DataColumn
				Get
					Return Me.columnFormatNo
				End Get
			End Property

			' Token: 0x17000BE9 RID: 3049
			' (get) Token: 0x06001E7D RID: 7805 RVA: 0x00117644 File Offset: 0x00115844
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property ReferenceSOPNoColumn As DataColumn
				Get
					Return Me.columnReferenceSOPNo
				End Get
			End Property

			' Token: 0x17000BEA RID: 3050
			' (get) Token: 0x06001E7E RID: 7806 RVA: 0x0011765C File Offset: 0x0011585C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property EffectiveDtColumn As DataColumn
				Get
					Return Me.columnEffectiveDt
				End Get
			End Property

			' Token: 0x17000BEB RID: 3051
			' (get) Token: 0x06001E7F RID: 7807 RVA: 0x00117674 File Offset: 0x00115874
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property ValidUptoColumn As DataColumn
				Get
					Return Me.columnValidUpto
				End Get
			End Property

			' Token: 0x17000BEC RID: 3052
			' (get) Token: 0x06001E80 RID: 7808 RVA: 0x0011768C File Offset: 0x0011588C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property MaterialNameColumn As DataColumn
				Get
					Return Me.columnMaterialName
				End Get
			End Property

			' Token: 0x17000BED RID: 3053
			' (get) Token: 0x06001E81 RID: 7809 RVA: 0x001176A4 File Offset: 0x001158A4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property SpecificationNoColumn As DataColumn
				Get
					Return Me.columnSpecificationNo
				End Get
			End Property

			' Token: 0x17000BEE RID: 3054
			' (get) Token: 0x06001E82 RID: 7810 RVA: 0x001176BC File Offset: 0x001158BC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property ReferenceColumn As DataColumn
				Get
					Return Me.columnReference
				End Get
			End Property

			' Token: 0x17000BEF RID: 3055
			' (get) Token: 0x06001E83 RID: 7811 RVA: 0x001176D4 File Offset: 0x001158D4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property VendorNameColumn As DataColumn
				Get
					Return Me.columnVendorName
				End Get
			End Property

			' Token: 0x17000BF0 RID: 3056
			' (get) Token: 0x06001E84 RID: 7812 RVA: 0x001176EC File Offset: 0x001158EC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property CatalogNoColumn As DataColumn
				Get
					Return Me.columnCatalogNo
				End Get
			End Property

			' Token: 0x17000BF1 RID: 3057
			' (get) Token: 0x06001E85 RID: 7813 RVA: 0x00117704 File Offset: 0x00115904
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property BatchNoColumn As DataColumn
				Get
					Return Me.columnBatchNo
				End Get
			End Property

			' Token: 0x17000BF2 RID: 3058
			' (get) Token: 0x06001E86 RID: 7814 RVA: 0x0011771C File Offset: 0x0011591C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property SrNoColumn As DataColumn
				Get
					Return Me.columnSrNo
				End Get
			End Property

			' Token: 0x17000BF3 RID: 3059
			' (get) Token: 0x06001E87 RID: 7815 RVA: 0x00117734 File Offset: 0x00115934
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property SpecificationColumn As DataColumn
				Get
					Return Me.columnSpecification
				End Get
			End Property

			' Token: 0x17000BF4 RID: 3060
			' (get) Token: 0x06001E88 RID: 7816 RVA: 0x0011774C File Offset: 0x0011594C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property AcceptanceCriteriaColumn As DataColumn
				Get
					Return Me.columnAcceptanceCriteria
				End Get
			End Property

			' Token: 0x17000BF5 RID: 3061
			' (get) Token: 0x06001E89 RID: 7817 RVA: 0x00117764 File Offset: 0x00115964
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property CompliesColumn As DataColumn
				Get
					Return Me.columnComplies
				End Get
			End Property

			' Token: 0x17000BF6 RID: 3062
			' (get) Token: 0x06001E8A RID: 7818 RVA: 0x0011777C File Offset: 0x0011597C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property RemarksColumn As DataColumn
				Get
					Return Me.columnRemarks
				End Get
			End Property

			' Token: 0x17000BF7 RID: 3063
			' (get) Token: 0x06001E8B RID: 7819 RVA: 0x00117794 File Offset: 0x00115994
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property QCEntryByColumn As DataColumn
				Get
					Return Me.columnQCEntryBy
				End Get
			End Property

			' Token: 0x17000BF8 RID: 3064
			' (get) Token: 0x06001E8C RID: 7820 RVA: 0x001177AC File Offset: 0x001159AC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property QCEntryDesignationColumn As DataColumn
				Get
					Return Me.columnQCEntryDesignation
				End Get
			End Property

			' Token: 0x17000BF9 RID: 3065
			' (get) Token: 0x06001E8D RID: 7821 RVA: 0x001177C4 File Offset: 0x001159C4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property QCEntryDtColumn As DataColumn
				Get
					Return Me.columnQCEntryDt
				End Get
			End Property

			' Token: 0x17000BFA RID: 3066
			' (get) Token: 0x06001E8E RID: 7822 RVA: 0x001177DC File Offset: 0x001159DC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property QCActionByColumn As DataColumn
				Get
					Return Me.columnQCActionBy
				End Get
			End Property

			' Token: 0x17000BFB RID: 3067
			' (get) Token: 0x06001E8F RID: 7823 RVA: 0x001177F4 File Offset: 0x001159F4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property QCActionDesignationColumn As DataColumn
				Get
					Return Me.columnQCActionDesignation
				End Get
			End Property

			' Token: 0x17000BFC RID: 3068
			' (get) Token: 0x06001E90 RID: 7824 RVA: 0x0011780C File Offset: 0x00115A0C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property QCActionDtColumn As DataColumn
				Get
					Return Me.columnQCActionDt
				End Get
			End Property

			' Token: 0x17000BFD RID: 3069
			' (get) Token: 0x06001E91 RID: 7825 RVA: 0x00117824 File Offset: 0x00115A24
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			<Browsable(False)>
			Public ReadOnly Property Count As Integer
				Get
					Return MyBase.Rows.Count
				End Get
			End Property

			' Token: 0x17000BFE RID: 3070
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Default Property Item(index As Integer) As PIMSDataSet.QCRow
				Get
					Return CType(MyBase.Rows(index), PIMSDataSet.QCRow)
				End Get
			End Property

			' Token: 0x14000009 RID: 9
			' (add) Token: 0x06001E93 RID: 7827 RVA: 0x00117868 File Offset: 0x00115A68
			' (remove) Token: 0x06001E94 RID: 7828 RVA: 0x001178A0 File Offset: 0x00115AA0
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Event QCRowChanging As PIMSDataSet.QCRowChangeEventHandler

			' Token: 0x1400000A RID: 10
			' (add) Token: 0x06001E95 RID: 7829 RVA: 0x001178D8 File Offset: 0x00115AD8
			' (remove) Token: 0x06001E96 RID: 7830 RVA: 0x00117910 File Offset: 0x00115B10
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Event QCRowChanged As PIMSDataSet.QCRowChangeEventHandler

			' Token: 0x1400000B RID: 11
			' (add) Token: 0x06001E97 RID: 7831 RVA: 0x00117948 File Offset: 0x00115B48
			' (remove) Token: 0x06001E98 RID: 7832 RVA: 0x00117980 File Offset: 0x00115B80
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Event QCRowDeleting As PIMSDataSet.QCRowChangeEventHandler

			' Token: 0x1400000C RID: 12
			' (add) Token: 0x06001E99 RID: 7833 RVA: 0x001179B8 File Offset: 0x00115BB8
			' (remove) Token: 0x06001E9A RID: 7834 RVA: 0x001179F0 File Offset: 0x00115BF0
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Event QCRowDeleted As PIMSDataSet.QCRowChangeEventHandler

			' Token: 0x06001E9B RID: 7835 RVA: 0x00117A25 File Offset: 0x00115C25
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub AddQCRow(row As PIMSDataSet.QCRow)
				MyBase.Rows.Add(row)
			End Sub

			' Token: 0x06001E9C RID: 7836 RVA: 0x00117A38 File Offset: 0x00115C38
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function AddQCRow(_RMNo_ As String, FormatNo As String, ReferenceSOPNo As String, EffectiveDt As DateTime, ValidUpto As DateTime, MaterialName As String, SpecificationNo As String, Reference As String, VendorName As String, CatalogNo As String, BatchNo As String, SrNo As Integer, Specification As String, AcceptanceCriteria As String, Complies As String, Remarks As String, QCEntryBy As String, QCEntryDesignation As String, QCEntryDt As DateTime, QCActionBy As String, QCActionDesignation As String, QCActionDt As DateTime) As PIMSDataSet.QCRow
				Dim qcrow As PIMSDataSet.QCRow = CType(MyBase.NewRow(), PIMSDataSet.QCRow)
				Dim array As Object() = New Object() { _RMNo_, FormatNo, ReferenceSOPNo, EffectiveDt, ValidUpto, MaterialName, SpecificationNo, Reference, VendorName, CatalogNo, BatchNo, SrNo, Specification, AcceptanceCriteria, Complies, Remarks, QCEntryBy, QCEntryDesignation, QCEntryDt, QCActionBy, QCActionDesignation, QCActionDt }
				qcrow.ItemArray = array
				MyBase.Rows.Add(qcrow)
				Return qcrow
			End Function

			' Token: 0x06001E9D RID: 7837 RVA: 0x00117B08 File Offset: 0x00115D08
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Overrides Function Clone() As DataTable
				Dim qcdataTable As PIMSDataSet.QCDataTable = CType(MyBase.Clone(), PIMSDataSet.QCDataTable)
				qcdataTable.InitVars()
				Return qcdataTable
			End Function

			' Token: 0x06001E9E RID: 7838 RVA: 0x00117B30 File Offset: 0x00115D30
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Function CreateInstance() As DataTable
				Return New PIMSDataSet.QCDataTable()
			End Function

			' Token: 0x06001E9F RID: 7839 RVA: 0x00117B48 File Offset: 0x00115D48
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Friend Sub InitVars()
				Me._columnRMNo_ = MyBase.Columns("RMNo.")
				Me.columnFormatNo = MyBase.Columns("FormatNo")
				Me.columnReferenceSOPNo = MyBase.Columns("ReferenceSOPNo")
				Me.columnEffectiveDt = MyBase.Columns("EffectiveDt")
				Me.columnValidUpto = MyBase.Columns("ValidUpto")
				Me.columnMaterialName = MyBase.Columns("MaterialName")
				Me.columnSpecificationNo = MyBase.Columns("SpecificationNo")
				Me.columnReference = MyBase.Columns("Reference")
				Me.columnVendorName = MyBase.Columns("VendorName")
				Me.columnCatalogNo = MyBase.Columns("CatalogNo")
				Me.columnBatchNo = MyBase.Columns("BatchNo")
				Me.columnSrNo = MyBase.Columns("SrNo")
				Me.columnSpecification = MyBase.Columns("Specification")
				Me.columnAcceptanceCriteria = MyBase.Columns("AcceptanceCriteria")
				Me.columnComplies = MyBase.Columns("Complies")
				Me.columnRemarks = MyBase.Columns("Remarks")
				Me.columnQCEntryBy = MyBase.Columns("QCEntryBy")
				Me.columnQCEntryDesignation = MyBase.Columns("QCEntryDesignation")
				Me.columnQCEntryDt = MyBase.Columns("QCEntryDt")
				Me.columnQCActionBy = MyBase.Columns("QCActionBy")
				Me.columnQCActionDesignation = MyBase.Columns("QCActionDesignation")
				Me.columnQCActionDt = MyBase.Columns("QCActionDt")
			End Sub

			' Token: 0x06001EA0 RID: 7840 RVA: 0x00117D3C File Offset: 0x00115F3C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Private Sub InitClass()
				Me._columnRMNo_ = New DataColumn("RMNo.", GetType(String), Nothing, MappingType.Element)
				Me._columnRMNo_.ExtendedProperties.Add("Generator_ColumnVarNameInTable", "_columnRMNo_")
				Me._columnRMNo_.ExtendedProperties.Add("Generator_UserColumnName", "RMNo.")
				MyBase.Columns.Add(Me._columnRMNo_)
				Me.columnFormatNo = New DataColumn("FormatNo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnFormatNo)
				Me.columnReferenceSOPNo = New DataColumn("ReferenceSOPNo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnReferenceSOPNo)
				Me.columnEffectiveDt = New DataColumn("EffectiveDt", GetType(DateTime), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnEffectiveDt)
				Me.columnValidUpto = New DataColumn("ValidUpto", GetType(DateTime), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnValidUpto)
				Me.columnMaterialName = New DataColumn("MaterialName", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnMaterialName)
				Me.columnSpecificationNo = New DataColumn("SpecificationNo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnSpecificationNo)
				Me.columnReference = New DataColumn("Reference", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnReference)
				Me.columnVendorName = New DataColumn("VendorName", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnVendorName)
				Me.columnCatalogNo = New DataColumn("CatalogNo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnCatalogNo)
				Me.columnBatchNo = New DataColumn("BatchNo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnBatchNo)
				Me.columnSrNo = New DataColumn("SrNo", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnSrNo)
				Me.columnSpecification = New DataColumn("Specification", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnSpecification)
				Me.columnAcceptanceCriteria = New DataColumn("AcceptanceCriteria", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnAcceptanceCriteria)
				Me.columnComplies = New DataColumn("Complies", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnComplies)
				Me.columnRemarks = New DataColumn("Remarks", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnRemarks)
				Me.columnQCEntryBy = New DataColumn("QCEntryBy", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnQCEntryBy)
				Me.columnQCEntryDesignation = New DataColumn("QCEntryDesignation", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnQCEntryDesignation)
				Me.columnQCEntryDt = New DataColumn("QCEntryDt", GetType(DateTime), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnQCEntryDt)
				Me.columnQCActionBy = New DataColumn("QCActionBy", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnQCActionBy)
				Me.columnQCActionDesignation = New DataColumn("QCActionDesignation", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnQCActionDesignation)
				Me.columnQCActionDt = New DataColumn("QCActionDt", GetType(DateTime), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnQCActionDt)
			End Sub

			' Token: 0x06001EA1 RID: 7841 RVA: 0x00118174 File Offset: 0x00116374
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function NewQCRow() As PIMSDataSet.QCRow
				Return CType(MyBase.NewRow(), PIMSDataSet.QCRow)
			End Function

			' Token: 0x06001EA2 RID: 7842 RVA: 0x00118194 File Offset: 0x00116394
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New PIMSDataSet.QCRow(builder)
			End Function

			' Token: 0x06001EA3 RID: 7843 RVA: 0x001181AC File Offset: 0x001163AC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Function GetRowType() As Type
				Return GetType(PIMSDataSet.QCRow)
			End Function

			' Token: 0x06001EA4 RID: 7844 RVA: 0x001181C8 File Offset: 0x001163C8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.QCRowChangedEvent IsNot Nothing
				If flag Then
					Dim qcrowChangedEvent As PIMSDataSet.QCRowChangeEventHandler = Me.QCRowChangedEvent
					If qcrowChangedEvent IsNot Nothing Then
						qcrowChangedEvent(Me, New PIMSDataSet.QCRowChangeEvent(CType(e.Row, PIMSDataSet.QCRow), e.Action))
					End If
				End If
			End Sub

			' Token: 0x06001EA5 RID: 7845 RVA: 0x00118218 File Offset: 0x00116418
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.QCRowChangingEvent IsNot Nothing
				If flag Then
					Dim qcrowChangingEvent As PIMSDataSet.QCRowChangeEventHandler = Me.QCRowChangingEvent
					If qcrowChangingEvent IsNot Nothing Then
						qcrowChangingEvent(Me, New PIMSDataSet.QCRowChangeEvent(CType(e.Row, PIMSDataSet.QCRow), e.Action))
					End If
				End If
			End Sub

			' Token: 0x06001EA6 RID: 7846 RVA: 0x00118268 File Offset: 0x00116468
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.QCRowDeletedEvent IsNot Nothing
				If flag Then
					Dim qcrowDeletedEvent As PIMSDataSet.QCRowChangeEventHandler = Me.QCRowDeletedEvent
					If qcrowDeletedEvent IsNot Nothing Then
						qcrowDeletedEvent(Me, New PIMSDataSet.QCRowChangeEvent(CType(e.Row, PIMSDataSet.QCRow), e.Action))
					End If
				End If
			End Sub

			' Token: 0x06001EA7 RID: 7847 RVA: 0x001182B8 File Offset: 0x001164B8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.QCRowDeletingEvent IsNot Nothing
				If flag Then
					Dim qcrowDeletingEvent As PIMSDataSet.QCRowChangeEventHandler = Me.QCRowDeletingEvent
					If qcrowDeletingEvent IsNot Nothing Then
						qcrowDeletingEvent(Me, New PIMSDataSet.QCRowChangeEvent(CType(e.Row, PIMSDataSet.QCRow), e.Action))
					End If
				End If
			End Sub

			' Token: 0x06001EA8 RID: 7848 RVA: 0x00118305 File Offset: 0x00116505
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub RemoveQCRow(row As PIMSDataSet.QCRow)
				MyBase.Rows.Remove(row)
			End Sub

			' Token: 0x06001EA9 RID: 7849 RVA: 0x00118318 File Offset: 0x00116518
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim pimsdataSet As PIMSDataSet = New PIMSDataSet()
				Dim xmlSchemaAny As XmlSchemaAny = New XmlSchemaAny()
				xmlSchemaAny.[Namespace] = "http://www.w3.org/2001/XMLSchema"
				xmlSchemaAny.MinOccurs = 0D
				xmlSchemaAny.MaxOccurs = Decimal.MaxValue
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax
				xmlSchemaSequence.Items.Add(xmlSchemaAny)
				Dim xmlSchemaAny2 As XmlSchemaAny = New XmlSchemaAny()
				xmlSchemaAny2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
				xmlSchemaAny2.MinOccurs = 1D
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax
				xmlSchemaSequence.Items.Add(xmlSchemaAny2)
				Dim xmlSchemaAttribute As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute.Name = "namespace"
				xmlSchemaAttribute.FixedValue = pimsdataSet.[Namespace]
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute)
				Dim xmlSchemaAttribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute2.Name = "tableTypeName"
				xmlSchemaAttribute2.FixedValue = "QCDataTable"
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2)
				xmlSchemaComplexType.Particle = xmlSchemaSequence
				Dim schemaSerializable As XmlSchema = pimsdataSet.GetSchemaSerializable()
				Dim flag As Boolean = xs.Contains(schemaSerializable.TargetNamespace)
				If flag Then
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim memoryStream2 As MemoryStream = New MemoryStream()
					Try
						schemaSerializable.Write(memoryStream)
						For Each obj As Object In xs.Schemas(schemaSerializable.TargetNamespace)
							Dim xmlSchema As XmlSchema = CType(obj, XmlSchema)
							memoryStream2.SetLength(0L)
							xmlSchema.Write(memoryStream2)
							Dim flag2 As Boolean = memoryStream.Length = memoryStream2.Length
							If flag2 Then
								memoryStream.Position = 0L
								memoryStream2.Position = 0L
								While memoryStream.Position <> memoryStream.Length AndAlso memoryStream.ReadByte() = memoryStream2.ReadByte()
								End While
								Dim flag3 As Boolean = memoryStream.Position = memoryStream.Length
								If flag3 Then
									Return xmlSchemaComplexType
								End If
							End If
						Next
					Finally
						Dim flag4 As Boolean = memoryStream IsNot Nothing
						If flag4 Then
							memoryStream.Close()
						End If
						Dim flag5 As Boolean = memoryStream2 IsNot Nothing
						If flag5 Then
							memoryStream2.Close()
						End If
					End Try
				End If
				xs.Add(schemaSerializable)
				Return xmlSchemaComplexType
			End Function

			' Token: 0x04000D41 RID: 3393
			Private _columnRMNo_ As DataColumn

			' Token: 0x04000D42 RID: 3394
			Private columnFormatNo As DataColumn

			' Token: 0x04000D43 RID: 3395
			Private columnReferenceSOPNo As DataColumn

			' Token: 0x04000D44 RID: 3396
			Private columnEffectiveDt As DataColumn

			' Token: 0x04000D45 RID: 3397
			Private columnValidUpto As DataColumn

			' Token: 0x04000D46 RID: 3398
			Private columnMaterialName As DataColumn

			' Token: 0x04000D47 RID: 3399
			Private columnSpecificationNo As DataColumn

			' Token: 0x04000D48 RID: 3400
			Private columnReference As DataColumn

			' Token: 0x04000D49 RID: 3401
			Private columnVendorName As DataColumn

			' Token: 0x04000D4A RID: 3402
			Private columnCatalogNo As DataColumn

			' Token: 0x04000D4B RID: 3403
			Private columnBatchNo As DataColumn

			' Token: 0x04000D4C RID: 3404
			Private columnSrNo As DataColumn

			' Token: 0x04000D4D RID: 3405
			Private columnSpecification As DataColumn

			' Token: 0x04000D4E RID: 3406
			Private columnAcceptanceCriteria As DataColumn

			' Token: 0x04000D4F RID: 3407
			Private columnComplies As DataColumn

			' Token: 0x04000D50 RID: 3408
			Private columnRemarks As DataColumn

			' Token: 0x04000D51 RID: 3409
			Private columnQCEntryBy As DataColumn

			' Token: 0x04000D52 RID: 3410
			Private columnQCEntryDesignation As DataColumn

			' Token: 0x04000D53 RID: 3411
			Private columnQCEntryDt As DataColumn

			' Token: 0x04000D54 RID: 3412
			Private columnQCActionBy As DataColumn

			' Token: 0x04000D55 RID: 3413
			Private columnQCActionDesignation As DataColumn

			' Token: 0x04000D56 RID: 3414
			Private columnQCActionDt As DataColumn
		End Class

		' Token: 0x0200007A RID: 122
		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class IssueDataTable
			Inherits TypedTableBase(Of PIMSDataSet.IssueRow)

			' Token: 0x06001EAA RID: 7850 RVA: 0x0011856C File Offset: 0x0011676C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub New()
				MyBase.TableName = "Issue"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			' Token: 0x06001EAB RID: 7851 RVA: 0x00118598 File Offset: 0x00116798
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Friend Sub New(table As DataTable)
				MyBase.TableName = table.TableName
				Dim flag As Boolean = table.CaseSensitive <> table.DataSet.CaseSensitive
				If flag Then
					MyBase.CaseSensitive = table.CaseSensitive
				End If
				Dim flag2 As Boolean = Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0
				If flag2 Then
					MyBase.Locale = table.Locale
				End If
				Dim flag3 As Boolean = Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0
				If flag3 Then
					MyBase.[Namespace] = table.[Namespace]
				End If
				MyBase.Prefix = table.Prefix
				MyBase.MinimumCapacity = table.MinimumCapacity
			End Sub

			' Token: 0x06001EAC RID: 7852 RVA: 0x00118661 File Offset: 0x00116861
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.New(info, context)
				Me.InitVars()
			End Sub

			' Token: 0x17000BFF RID: 3071
			' (get) Token: 0x06001EAD RID: 7853 RVA: 0x00118674 File Offset: 0x00116874
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property FormatNoColumn As DataColumn
				Get
					Return Me.columnFormatNo
				End Get
			End Property

			' Token: 0x17000C00 RID: 3072
			' (get) Token: 0x06001EAE RID: 7854 RVA: 0x0011868C File Offset: 0x0011688C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property ReferenceSOPNoColumn As DataColumn
				Get
					Return Me.columnReferenceSOPNo
				End Get
			End Property

			' Token: 0x17000C01 RID: 3073
			' (get) Token: 0x06001EAF RID: 7855 RVA: 0x001186A4 File Offset: 0x001168A4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property ProductNameColumn As DataColumn
				Get
					Return Me.columnProductName
				End Get
			End Property

			' Token: 0x17000C02 RID: 3074
			' (get) Token: 0x06001EB0 RID: 7856 RVA: 0x001186BC File Offset: 0x001168BC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property BOMVersionColumn As DataColumn
				Get
					Return Me.columnBOMVersion
				End Get
			End Property

			' Token: 0x17000C03 RID: 3075
			' (get) Token: 0x06001EB1 RID: 7857 RVA: 0x001186D4 File Offset: 0x001168D4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property BatchNoColumn As DataColumn
				Get
					Return Me.columnBatchNo
				End Get
			End Property

			' Token: 0x17000C04 RID: 3076
			' (get) Token: 0x06001EB2 RID: 7858 RVA: 0x001186EC File Offset: 0x001168EC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property RequestedByColumn As DataColumn
				Get
					Return Me.columnRequestedBy
				End Get
			End Property

			' Token: 0x17000C05 RID: 3077
			' (get) Token: 0x06001EB3 RID: 7859 RVA: 0x00118704 File Offset: 0x00116904
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property RequestDtColumn As DataColumn
				Get
					Return Me.columnRequestDt
				End Get
			End Property

			' Token: 0x17000C06 RID: 3078
			' (get) Token: 0x06001EB4 RID: 7860 RVA: 0x0011871C File Offset: 0x0011691C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property IssuedDtColumn As DataColumn
				Get
					Return Me.columnIssuedDt
				End Get
			End Property

			' Token: 0x17000C07 RID: 3079
			' (get) Token: 0x06001EB5 RID: 7861 RVA: 0x00118734 File Offset: 0x00116934
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property SrNoColumn As DataColumn
				Get
					Return Me.columnSrNo
				End Get
			End Property

			' Token: 0x17000C08 RID: 3080
			' (get) Token: 0x06001EB6 RID: 7862 RVA: 0x0011874C File Offset: 0x0011694C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property MaterialNameColumn As DataColumn
				Get
					Return Me.columnMaterialName
				End Get
			End Property

			' Token: 0x17000C09 RID: 3081
			' (get) Token: 0x06001EB7 RID: 7863 RVA: 0x00118764 File Offset: 0x00116964
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property CatalogNoColumn As DataColumn
				Get
					Return Me.columnCatalogNo
				End Get
			End Property

			' Token: 0x17000C0A RID: 3082
			' (get) Token: 0x06001EB8 RID: 7864 RVA: 0x0011877C File Offset: 0x0011697C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property UOMColumn As DataColumn
				Get
					Return Me.columnUOM
				End Get
			End Property

			' Token: 0x17000C0B RID: 3083
			' (get) Token: 0x06001EB9 RID: 7865 RVA: 0x00118794 File Offset: 0x00116994
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property RequiredQtyColumn As DataColumn
				Get
					Return Me.columnRequiredQty
				End Get
			End Property

			' Token: 0x17000C0C RID: 3084
			' (get) Token: 0x06001EBA RID: 7866 RVA: 0x001187AC File Offset: 0x001169AC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property LotNoColumn As DataColumn
				Get
					Return Me.columnLotNo
				End Get
			End Property

			' Token: 0x17000C0D RID: 3085
			' (get) Token: 0x06001EBB RID: 7867 RVA: 0x001187C4 File Offset: 0x001169C4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property ExpiryDtColumn As DataColumn
				Get
					Return Me.columnExpiryDt
				End Get
			End Property

			' Token: 0x17000C0E RID: 3086
			' (get) Token: 0x06001EBC RID: 7868 RVA: 0x001187DC File Offset: 0x001169DC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property IssuedQtyColumn As DataColumn
				Get
					Return Me.columnIssuedQty
				End Get
			End Property

			' Token: 0x17000C0F RID: 3087
			' (get) Token: 0x06001EBD RID: 7869 RVA: 0x001187F4 File Offset: 0x001169F4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property IssuedByColumn As DataColumn
				Get
					Return Me.columnIssuedBy
				End Get
			End Property

			' Token: 0x17000C10 RID: 3088
			' (get) Token: 0x06001EBE RID: 7870 RVA: 0x0011880C File Offset: 0x00116A0C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property VerifiedByColumn As DataColumn
				Get
					Return Me.columnVerifiedBy
				End Get
			End Property

			' Token: 0x17000C11 RID: 3089
			' (get) Token: 0x06001EBF RID: 7871 RVA: 0x00118824 File Offset: 0x00116A24
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			<Browsable(False)>
			Public ReadOnly Property Count As Integer
				Get
					Return MyBase.Rows.Count
				End Get
			End Property

			' Token: 0x17000C12 RID: 3090
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Default Property Item(index As Integer) As PIMSDataSet.IssueRow
				Get
					Return CType(MyBase.Rows(index), PIMSDataSet.IssueRow)
				End Get
			End Property

			' Token: 0x1400000D RID: 13
			' (add) Token: 0x06001EC1 RID: 7873 RVA: 0x00118868 File Offset: 0x00116A68
			' (remove) Token: 0x06001EC2 RID: 7874 RVA: 0x001188A0 File Offset: 0x00116AA0
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Event IssueRowChanging As PIMSDataSet.IssueRowChangeEventHandler

			' Token: 0x1400000E RID: 14
			' (add) Token: 0x06001EC3 RID: 7875 RVA: 0x001188D8 File Offset: 0x00116AD8
			' (remove) Token: 0x06001EC4 RID: 7876 RVA: 0x00118910 File Offset: 0x00116B10
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Event IssueRowChanged As PIMSDataSet.IssueRowChangeEventHandler

			' Token: 0x1400000F RID: 15
			' (add) Token: 0x06001EC5 RID: 7877 RVA: 0x00118948 File Offset: 0x00116B48
			' (remove) Token: 0x06001EC6 RID: 7878 RVA: 0x00118980 File Offset: 0x00116B80
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Event IssueRowDeleting As PIMSDataSet.IssueRowChangeEventHandler

			' Token: 0x14000010 RID: 16
			' (add) Token: 0x06001EC7 RID: 7879 RVA: 0x001189B8 File Offset: 0x00116BB8
			' (remove) Token: 0x06001EC8 RID: 7880 RVA: 0x001189F0 File Offset: 0x00116BF0
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Event IssueRowDeleted As PIMSDataSet.IssueRowChangeEventHandler

			' Token: 0x06001EC9 RID: 7881 RVA: 0x00118A25 File Offset: 0x00116C25
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub AddIssueRow(row As PIMSDataSet.IssueRow)
				MyBase.Rows.Add(row)
			End Sub

			' Token: 0x06001ECA RID: 7882 RVA: 0x00118A38 File Offset: 0x00116C38
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function AddIssueRow(FormatNo As String, ReferenceSOPNo As String, ProductName As String, BOMVersion As String, BatchNo As String, RequestedBy As String, RequestDt As DateTime, IssuedDt As DateTime, SrNo As Integer, MaterialName As String, CatalogNo As String, UOM As String, RequiredQty As Integer, LotNo As String, ExpiryDt As DateTime, IssuedQty As Integer, IssuedBy As String, VerifiedBy As String) As PIMSDataSet.IssueRow
				Dim issueRow As PIMSDataSet.IssueRow = CType(MyBase.NewRow(), PIMSDataSet.IssueRow)
				Dim array As Object() = New Object() { FormatNo, ReferenceSOPNo, ProductName, BOMVersion, BatchNo, RequestedBy, RequestDt, IssuedDt, SrNo, MaterialName, CatalogNo, UOM, RequiredQty, LotNo, ExpiryDt, IssuedQty, IssuedBy, VerifiedBy }
				issueRow.ItemArray = array
				MyBase.Rows.Add(issueRow)
				Return issueRow
			End Function

			' Token: 0x06001ECB RID: 7883 RVA: 0x00118AF4 File Offset: 0x00116CF4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Overrides Function Clone() As DataTable
				Dim issueDataTable As PIMSDataSet.IssueDataTable = CType(MyBase.Clone(), PIMSDataSet.IssueDataTable)
				issueDataTable.InitVars()
				Return issueDataTable
			End Function

			' Token: 0x06001ECC RID: 7884 RVA: 0x00118B1C File Offset: 0x00116D1C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Function CreateInstance() As DataTable
				Return New PIMSDataSet.IssueDataTable()
			End Function

			' Token: 0x06001ECD RID: 7885 RVA: 0x00118B34 File Offset: 0x00116D34
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Friend Sub InitVars()
				Me.columnFormatNo = MyBase.Columns("FormatNo")
				Me.columnReferenceSOPNo = MyBase.Columns("ReferenceSOPNo")
				Me.columnProductName = MyBase.Columns("ProductName")
				Me.columnBOMVersion = MyBase.Columns("BOMVersion")
				Me.columnBatchNo = MyBase.Columns("BatchNo")
				Me.columnRequestedBy = MyBase.Columns("RequestedBy")
				Me.columnRequestDt = MyBase.Columns("RequestDt")
				Me.columnIssuedDt = MyBase.Columns("IssuedDt")
				Me.columnSrNo = MyBase.Columns("SrNo")
				Me.columnMaterialName = MyBase.Columns("MaterialName")
				Me.columnCatalogNo = MyBase.Columns("CatalogNo")
				Me.columnUOM = MyBase.Columns("UOM")
				Me.columnRequiredQty = MyBase.Columns("RequiredQty")
				Me.columnLotNo = MyBase.Columns("LotNo")
				Me.columnExpiryDt = MyBase.Columns("ExpiryDt")
				Me.columnIssuedQty = MyBase.Columns("IssuedQty")
				Me.columnIssuedBy = MyBase.Columns("IssuedBy")
				Me.columnVerifiedBy = MyBase.Columns("VerifiedBy")
			End Sub

			' Token: 0x06001ECE RID: 7886 RVA: 0x00118CD0 File Offset: 0x00116ED0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Private Sub InitClass()
				Me.columnFormatNo = New DataColumn("FormatNo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnFormatNo)
				Me.columnReferenceSOPNo = New DataColumn("ReferenceSOPNo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnReferenceSOPNo)
				Me.columnProductName = New DataColumn("ProductName", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnProductName)
				Me.columnBOMVersion = New DataColumn("BOMVersion", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnBOMVersion)
				Me.columnBatchNo = New DataColumn("BatchNo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnBatchNo)
				Me.columnRequestedBy = New DataColumn("RequestedBy", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnRequestedBy)
				Me.columnRequestDt = New DataColumn("RequestDt", GetType(DateTime), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnRequestDt)
				Me.columnIssuedDt = New DataColumn("IssuedDt", GetType(DateTime), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnIssuedDt)
				Me.columnSrNo = New DataColumn("SrNo", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnSrNo)
				Me.columnMaterialName = New DataColumn("MaterialName", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnMaterialName)
				Me.columnCatalogNo = New DataColumn("CatalogNo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnCatalogNo)
				Me.columnUOM = New DataColumn("UOM", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnUOM)
				Me.columnRequiredQty = New DataColumn("RequiredQty", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnRequiredQty)
				Me.columnLotNo = New DataColumn("LotNo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnLotNo)
				Me.columnExpiryDt = New DataColumn("ExpiryDt", GetType(DateTime), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnExpiryDt)
				Me.columnIssuedQty = New DataColumn("IssuedQty", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnIssuedQty)
				Me.columnIssuedBy = New DataColumn("IssuedBy", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnIssuedBy)
				Me.columnVerifiedBy = New DataColumn("VerifiedBy", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnVerifiedBy)
			End Sub

			' Token: 0x06001ECF RID: 7887 RVA: 0x0011901C File Offset: 0x0011721C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function NewIssueRow() As PIMSDataSet.IssueRow
				Return CType(MyBase.NewRow(), PIMSDataSet.IssueRow)
			End Function

			' Token: 0x06001ED0 RID: 7888 RVA: 0x0011903C File Offset: 0x0011723C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New PIMSDataSet.IssueRow(builder)
			End Function

			' Token: 0x06001ED1 RID: 7889 RVA: 0x00119054 File Offset: 0x00117254
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Function GetRowType() As Type
				Return GetType(PIMSDataSet.IssueRow)
			End Function

			' Token: 0x06001ED2 RID: 7890 RVA: 0x00119070 File Offset: 0x00117270
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.IssueRowChangedEvent IsNot Nothing
				If flag Then
					Dim issueRowChangedEvent As PIMSDataSet.IssueRowChangeEventHandler = Me.IssueRowChangedEvent
					If issueRowChangedEvent IsNot Nothing Then
						issueRowChangedEvent(Me, New PIMSDataSet.IssueRowChangeEvent(CType(e.Row, PIMSDataSet.IssueRow), e.Action))
					End If
				End If
			End Sub

			' Token: 0x06001ED3 RID: 7891 RVA: 0x001190C0 File Offset: 0x001172C0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.IssueRowChangingEvent IsNot Nothing
				If flag Then
					Dim issueRowChangingEvent As PIMSDataSet.IssueRowChangeEventHandler = Me.IssueRowChangingEvent
					If issueRowChangingEvent IsNot Nothing Then
						issueRowChangingEvent(Me, New PIMSDataSet.IssueRowChangeEvent(CType(e.Row, PIMSDataSet.IssueRow), e.Action))
					End If
				End If
			End Sub

			' Token: 0x06001ED4 RID: 7892 RVA: 0x00119110 File Offset: 0x00117310
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.IssueRowDeletedEvent IsNot Nothing
				If flag Then
					Dim issueRowDeletedEvent As PIMSDataSet.IssueRowChangeEventHandler = Me.IssueRowDeletedEvent
					If issueRowDeletedEvent IsNot Nothing Then
						issueRowDeletedEvent(Me, New PIMSDataSet.IssueRowChangeEvent(CType(e.Row, PIMSDataSet.IssueRow), e.Action))
					End If
				End If
			End Sub

			' Token: 0x06001ED5 RID: 7893 RVA: 0x00119160 File Offset: 0x00117360
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.IssueRowDeletingEvent IsNot Nothing
				If flag Then
					Dim issueRowDeletingEvent As PIMSDataSet.IssueRowChangeEventHandler = Me.IssueRowDeletingEvent
					If issueRowDeletingEvent IsNot Nothing Then
						issueRowDeletingEvent(Me, New PIMSDataSet.IssueRowChangeEvent(CType(e.Row, PIMSDataSet.IssueRow), e.Action))
					End If
				End If
			End Sub

			' Token: 0x06001ED6 RID: 7894 RVA: 0x001191AD File Offset: 0x001173AD
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub RemoveIssueRow(row As PIMSDataSet.IssueRow)
				MyBase.Rows.Remove(row)
			End Sub

			' Token: 0x06001ED7 RID: 7895 RVA: 0x001191C0 File Offset: 0x001173C0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim pimsdataSet As PIMSDataSet = New PIMSDataSet()
				Dim xmlSchemaAny As XmlSchemaAny = New XmlSchemaAny()
				xmlSchemaAny.[Namespace] = "http://www.w3.org/2001/XMLSchema"
				xmlSchemaAny.MinOccurs = 0D
				xmlSchemaAny.MaxOccurs = Decimal.MaxValue
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax
				xmlSchemaSequence.Items.Add(xmlSchemaAny)
				Dim xmlSchemaAny2 As XmlSchemaAny = New XmlSchemaAny()
				xmlSchemaAny2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
				xmlSchemaAny2.MinOccurs = 1D
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax
				xmlSchemaSequence.Items.Add(xmlSchemaAny2)
				Dim xmlSchemaAttribute As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute.Name = "namespace"
				xmlSchemaAttribute.FixedValue = pimsdataSet.[Namespace]
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute)
				Dim xmlSchemaAttribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute2.Name = "tableTypeName"
				xmlSchemaAttribute2.FixedValue = "IssueDataTable"
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2)
				xmlSchemaComplexType.Particle = xmlSchemaSequence
				Dim schemaSerializable As XmlSchema = pimsdataSet.GetSchemaSerializable()
				Dim flag As Boolean = xs.Contains(schemaSerializable.TargetNamespace)
				If flag Then
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim memoryStream2 As MemoryStream = New MemoryStream()
					Try
						schemaSerializable.Write(memoryStream)
						For Each obj As Object In xs.Schemas(schemaSerializable.TargetNamespace)
							Dim xmlSchema As XmlSchema = CType(obj, XmlSchema)
							memoryStream2.SetLength(0L)
							xmlSchema.Write(memoryStream2)
							Dim flag2 As Boolean = memoryStream.Length = memoryStream2.Length
							If flag2 Then
								memoryStream.Position = 0L
								memoryStream2.Position = 0L
								While memoryStream.Position <> memoryStream.Length AndAlso memoryStream.ReadByte() = memoryStream2.ReadByte()
								End While
								Dim flag3 As Boolean = memoryStream.Position = memoryStream.Length
								If flag3 Then
									Return xmlSchemaComplexType
								End If
							End If
						Next
					Finally
						Dim flag4 As Boolean = memoryStream IsNot Nothing
						If flag4 Then
							memoryStream.Close()
						End If
						Dim flag5 As Boolean = memoryStream2 IsNot Nothing
						If flag5 Then
							memoryStream2.Close()
						End If
					End Try
				End If
				xs.Add(schemaSerializable)
				Return xmlSchemaComplexType
			End Function

			' Token: 0x04000D5B RID: 3419
			Private columnFormatNo As DataColumn

			' Token: 0x04000D5C RID: 3420
			Private columnReferenceSOPNo As DataColumn

			' Token: 0x04000D5D RID: 3421
			Private columnProductName As DataColumn

			' Token: 0x04000D5E RID: 3422
			Private columnBOMVersion As DataColumn

			' Token: 0x04000D5F RID: 3423
			Private columnBatchNo As DataColumn

			' Token: 0x04000D60 RID: 3424
			Private columnRequestedBy As DataColumn

			' Token: 0x04000D61 RID: 3425
			Private columnRequestDt As DataColumn

			' Token: 0x04000D62 RID: 3426
			Private columnIssuedDt As DataColumn

			' Token: 0x04000D63 RID: 3427
			Private columnSrNo As DataColumn

			' Token: 0x04000D64 RID: 3428
			Private columnMaterialName As DataColumn

			' Token: 0x04000D65 RID: 3429
			Private columnCatalogNo As DataColumn

			' Token: 0x04000D66 RID: 3430
			Private columnUOM As DataColumn

			' Token: 0x04000D67 RID: 3431
			Private columnRequiredQty As DataColumn

			' Token: 0x04000D68 RID: 3432
			Private columnLotNo As DataColumn

			' Token: 0x04000D69 RID: 3433
			Private columnExpiryDt As DataColumn

			' Token: 0x04000D6A RID: 3434
			Private columnIssuedQty As DataColumn

			' Token: 0x04000D6B RID: 3435
			Private columnIssuedBy As DataColumn

			' Token: 0x04000D6C RID: 3436
			Private columnVerifiedBy As DataColumn
		End Class

		' Token: 0x0200007B RID: 123
		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class ConsumptionDataTable
			Inherits TypedTableBase(Of PIMSDataSet.ConsumptionRow)

			' Token: 0x06001ED8 RID: 7896 RVA: 0x00119414 File Offset: 0x00117614
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub New()
				MyBase.TableName = "Consumption"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			' Token: 0x06001ED9 RID: 7897 RVA: 0x00119440 File Offset: 0x00117640
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Friend Sub New(table As DataTable)
				MyBase.TableName = table.TableName
				Dim flag As Boolean = table.CaseSensitive <> table.DataSet.CaseSensitive
				If flag Then
					MyBase.CaseSensitive = table.CaseSensitive
				End If
				Dim flag2 As Boolean = Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0
				If flag2 Then
					MyBase.Locale = table.Locale
				End If
				Dim flag3 As Boolean = Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0
				If flag3 Then
					MyBase.[Namespace] = table.[Namespace]
				End If
				MyBase.Prefix = table.Prefix
				MyBase.MinimumCapacity = table.MinimumCapacity
			End Sub

			' Token: 0x06001EDA RID: 7898 RVA: 0x00119509 File Offset: 0x00117709
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.New(info, context)
				Me.InitVars()
			End Sub

			' Token: 0x17000C13 RID: 3091
			' (get) Token: 0x06001EDB RID: 7899 RVA: 0x0011951C File Offset: 0x0011771C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property DepartmentColumn As DataColumn
				Get
					Return Me.columnDepartment
				End Get
			End Property

			' Token: 0x17000C14 RID: 3092
			' (get) Token: 0x06001EDC RID: 7900 RVA: 0x00119534 File Offset: 0x00117734
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property StartDtColumn As DataColumn
				Get
					Return Me.columnStartDt
				End Get
			End Property

			' Token: 0x17000C15 RID: 3093
			' (get) Token: 0x06001EDD RID: 7901 RVA: 0x0011954C File Offset: 0x0011774C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property EndDtColumn As DataColumn
				Get
					Return Me.columnEndDt
				End Get
			End Property

			' Token: 0x17000C16 RID: 3094
			' (get) Token: 0x06001EDE RID: 7902 RVA: 0x00119564 File Offset: 0x00117764
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property ProductTypeColumn As DataColumn
				Get
					Return Me.columnProductType
				End Get
			End Property

			' Token: 0x17000C17 RID: 3095
			' (get) Token: 0x06001EDF RID: 7903 RVA: 0x0011957C File Offset: 0x0011777C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property ProductNameColumn As DataColumn
				Get
					Return Me.columnProductName
				End Get
			End Property

			' Token: 0x17000C18 RID: 3096
			' (get) Token: 0x06001EE0 RID: 7904 RVA: 0x00119594 File Offset: 0x00117794
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property BatchNoColumn As DataColumn
				Get
					Return Me.columnBatchNo
				End Get
			End Property

			' Token: 0x17000C19 RID: 3097
			' (get) Token: 0x06001EE1 RID: 7905 RVA: 0x001195AC File Offset: 0x001177AC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property ExpiryDtColumn As DataColumn
				Get
					Return Me.columnExpiryDt
				End Get
			End Property

			' Token: 0x17000C1A RID: 3098
			' (get) Token: 0x06001EE2 RID: 7906 RVA: 0x001195C4 File Offset: 0x001177C4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property QuantityColumn As DataColumn
				Get
					Return Me.columnQuantity
				End Get
			End Property

			' Token: 0x17000C1B RID: 3099
			' (get) Token: 0x06001EE3 RID: 7907 RVA: 0x001195DC File Offset: 0x001177DC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property RateColumn As DataColumn
				Get
					Return Me.columnRate
				End Get
			End Property

			' Token: 0x17000C1C RID: 3100
			' (get) Token: 0x06001EE4 RID: 7908 RVA: 0x001195F4 File Offset: 0x001177F4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property ValueColumn As DataColumn
				Get
					Return Me.columnValue
				End Get
			End Property

			' Token: 0x17000C1D RID: 3101
			' (get) Token: 0x06001EE5 RID: 7909 RVA: 0x0011960C File Offset: 0x0011780C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			<Browsable(False)>
			Public ReadOnly Property Count As Integer
				Get
					Return MyBase.Rows.Count
				End Get
			End Property

			' Token: 0x17000C1E RID: 3102
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Default Property Item(index As Integer) As PIMSDataSet.ConsumptionRow
				Get
					Return CType(MyBase.Rows(index), PIMSDataSet.ConsumptionRow)
				End Get
			End Property

			' Token: 0x14000011 RID: 17
			' (add) Token: 0x06001EE7 RID: 7911 RVA: 0x00119650 File Offset: 0x00117850
			' (remove) Token: 0x06001EE8 RID: 7912 RVA: 0x00119688 File Offset: 0x00117888
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Event ConsumptionRowChanging As PIMSDataSet.ConsumptionRowChangeEventHandler

			' Token: 0x14000012 RID: 18
			' (add) Token: 0x06001EE9 RID: 7913 RVA: 0x001196C0 File Offset: 0x001178C0
			' (remove) Token: 0x06001EEA RID: 7914 RVA: 0x001196F8 File Offset: 0x001178F8
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Event ConsumptionRowChanged As PIMSDataSet.ConsumptionRowChangeEventHandler

			' Token: 0x14000013 RID: 19
			' (add) Token: 0x06001EEB RID: 7915 RVA: 0x00119730 File Offset: 0x00117930
			' (remove) Token: 0x06001EEC RID: 7916 RVA: 0x00119768 File Offset: 0x00117968
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Event ConsumptionRowDeleting As PIMSDataSet.ConsumptionRowChangeEventHandler

			' Token: 0x14000014 RID: 20
			' (add) Token: 0x06001EED RID: 7917 RVA: 0x001197A0 File Offset: 0x001179A0
			' (remove) Token: 0x06001EEE RID: 7918 RVA: 0x001197D8 File Offset: 0x001179D8
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Event ConsumptionRowDeleted As PIMSDataSet.ConsumptionRowChangeEventHandler

			' Token: 0x06001EEF RID: 7919 RVA: 0x0011980D File Offset: 0x00117A0D
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub AddConsumptionRow(row As PIMSDataSet.ConsumptionRow)
				MyBase.Rows.Add(row)
			End Sub

			' Token: 0x06001EF0 RID: 7920 RVA: 0x00119820 File Offset: 0x00117A20
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function AddConsumptionRow(Department As String, StartDt As DateTime, EndDt As DateTime, ProductType As String, ProductName As String, BatchNo As String, ExpiryDt As DateTime, Quantity As Integer, Rate As Double, Value As Double) As PIMSDataSet.ConsumptionRow
				Dim consumptionRow As PIMSDataSet.ConsumptionRow = CType(MyBase.NewRow(), PIMSDataSet.ConsumptionRow)
				Dim array As Object() = New Object() { Department, StartDt, EndDt, ProductType, ProductName, BatchNo, ExpiryDt, Quantity, Rate, Value }
				consumptionRow.ItemArray = array
				MyBase.Rows.Add(consumptionRow)
				Return consumptionRow
			End Function

			' Token: 0x06001EF1 RID: 7921 RVA: 0x001198AC File Offset: 0x00117AAC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Overrides Function Clone() As DataTable
				Dim consumptionDataTable As PIMSDataSet.ConsumptionDataTable = CType(MyBase.Clone(), PIMSDataSet.ConsumptionDataTable)
				consumptionDataTable.InitVars()
				Return consumptionDataTable
			End Function

			' Token: 0x06001EF2 RID: 7922 RVA: 0x001198D4 File Offset: 0x00117AD4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Function CreateInstance() As DataTable
				Return New PIMSDataSet.ConsumptionDataTable()
			End Function

			' Token: 0x06001EF3 RID: 7923 RVA: 0x001198EC File Offset: 0x00117AEC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Friend Sub InitVars()
				Me.columnDepartment = MyBase.Columns("Department")
				Me.columnStartDt = MyBase.Columns("StartDt")
				Me.columnEndDt = MyBase.Columns("EndDt")
				Me.columnProductType = MyBase.Columns("ProductType")
				Me.columnProductName = MyBase.Columns("ProductName")
				Me.columnBatchNo = MyBase.Columns("BatchNo")
				Me.columnExpiryDt = MyBase.Columns("ExpiryDt")
				Me.columnQuantity = MyBase.Columns("Quantity")
				Me.columnRate = MyBase.Columns("Rate")
				Me.columnValue = MyBase.Columns("Value")
			End Sub

			' Token: 0x06001EF4 RID: 7924 RVA: 0x001199D8 File Offset: 0x00117BD8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Private Sub InitClass()
				Me.columnDepartment = New DataColumn("Department", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDepartment)
				Me.columnStartDt = New DataColumn("StartDt", GetType(DateTime), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnStartDt)
				Me.columnEndDt = New DataColumn("EndDt", GetType(DateTime), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnEndDt)
				Me.columnProductType = New DataColumn("ProductType", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnProductType)
				Me.columnProductName = New DataColumn("ProductName", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnProductName)
				Me.columnBatchNo = New DataColumn("BatchNo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnBatchNo)
				Me.columnExpiryDt = New DataColumn("ExpiryDt", GetType(DateTime), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnExpiryDt)
				Me.columnQuantity = New DataColumn("Quantity", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnQuantity)
				Me.columnRate = New DataColumn("Rate", GetType(Double), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnRate)
				Me.columnValue = New DataColumn("Value", GetType(Double), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnValue)
			End Sub

			' Token: 0x06001EF5 RID: 7925 RVA: 0x00119BB4 File Offset: 0x00117DB4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function NewConsumptionRow() As PIMSDataSet.ConsumptionRow
				Return CType(MyBase.NewRow(), PIMSDataSet.ConsumptionRow)
			End Function

			' Token: 0x06001EF6 RID: 7926 RVA: 0x00119BD4 File Offset: 0x00117DD4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New PIMSDataSet.ConsumptionRow(builder)
			End Function

			' Token: 0x06001EF7 RID: 7927 RVA: 0x00119BEC File Offset: 0x00117DEC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Function GetRowType() As Type
				Return GetType(PIMSDataSet.ConsumptionRow)
			End Function

			' Token: 0x06001EF8 RID: 7928 RVA: 0x00119C08 File Offset: 0x00117E08
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.ConsumptionRowChangedEvent IsNot Nothing
				If flag Then
					Dim consumptionRowChangedEvent As PIMSDataSet.ConsumptionRowChangeEventHandler = Me.ConsumptionRowChangedEvent
					If consumptionRowChangedEvent IsNot Nothing Then
						consumptionRowChangedEvent(Me, New PIMSDataSet.ConsumptionRowChangeEvent(CType(e.Row, PIMSDataSet.ConsumptionRow), e.Action))
					End If
				End If
			End Sub

			' Token: 0x06001EF9 RID: 7929 RVA: 0x00119C58 File Offset: 0x00117E58
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.ConsumptionRowChangingEvent IsNot Nothing
				If flag Then
					Dim consumptionRowChangingEvent As PIMSDataSet.ConsumptionRowChangeEventHandler = Me.ConsumptionRowChangingEvent
					If consumptionRowChangingEvent IsNot Nothing Then
						consumptionRowChangingEvent(Me, New PIMSDataSet.ConsumptionRowChangeEvent(CType(e.Row, PIMSDataSet.ConsumptionRow), e.Action))
					End If
				End If
			End Sub

			' Token: 0x06001EFA RID: 7930 RVA: 0x00119CA8 File Offset: 0x00117EA8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.ConsumptionRowDeletedEvent IsNot Nothing
				If flag Then
					Dim consumptionRowDeletedEvent As PIMSDataSet.ConsumptionRowChangeEventHandler = Me.ConsumptionRowDeletedEvent
					If consumptionRowDeletedEvent IsNot Nothing Then
						consumptionRowDeletedEvent(Me, New PIMSDataSet.ConsumptionRowChangeEvent(CType(e.Row, PIMSDataSet.ConsumptionRow), e.Action))
					End If
				End If
			End Sub

			' Token: 0x06001EFB RID: 7931 RVA: 0x00119CF8 File Offset: 0x00117EF8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.ConsumptionRowDeletingEvent IsNot Nothing
				If flag Then
					Dim consumptionRowDeletingEvent As PIMSDataSet.ConsumptionRowChangeEventHandler = Me.ConsumptionRowDeletingEvent
					If consumptionRowDeletingEvent IsNot Nothing Then
						consumptionRowDeletingEvent(Me, New PIMSDataSet.ConsumptionRowChangeEvent(CType(e.Row, PIMSDataSet.ConsumptionRow), e.Action))
					End If
				End If
			End Sub

			' Token: 0x06001EFC RID: 7932 RVA: 0x00119D45 File Offset: 0x00117F45
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub RemoveConsumptionRow(row As PIMSDataSet.ConsumptionRow)
				MyBase.Rows.Remove(row)
			End Sub

			' Token: 0x06001EFD RID: 7933 RVA: 0x00119D58 File Offset: 0x00117F58
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim pimsdataSet As PIMSDataSet = New PIMSDataSet()
				Dim xmlSchemaAny As XmlSchemaAny = New XmlSchemaAny()
				xmlSchemaAny.[Namespace] = "http://www.w3.org/2001/XMLSchema"
				xmlSchemaAny.MinOccurs = 0D
				xmlSchemaAny.MaxOccurs = Decimal.MaxValue
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax
				xmlSchemaSequence.Items.Add(xmlSchemaAny)
				Dim xmlSchemaAny2 As XmlSchemaAny = New XmlSchemaAny()
				xmlSchemaAny2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
				xmlSchemaAny2.MinOccurs = 1D
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax
				xmlSchemaSequence.Items.Add(xmlSchemaAny2)
				Dim xmlSchemaAttribute As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute.Name = "namespace"
				xmlSchemaAttribute.FixedValue = pimsdataSet.[Namespace]
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute)
				Dim xmlSchemaAttribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute2.Name = "tableTypeName"
				xmlSchemaAttribute2.FixedValue = "ConsumptionDataTable"
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2)
				xmlSchemaComplexType.Particle = xmlSchemaSequence
				Dim schemaSerializable As XmlSchema = pimsdataSet.GetSchemaSerializable()
				Dim flag As Boolean = xs.Contains(schemaSerializable.TargetNamespace)
				If flag Then
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim memoryStream2 As MemoryStream = New MemoryStream()
					Try
						schemaSerializable.Write(memoryStream)
						For Each obj As Object In xs.Schemas(schemaSerializable.TargetNamespace)
							Dim xmlSchema As XmlSchema = CType(obj, XmlSchema)
							memoryStream2.SetLength(0L)
							xmlSchema.Write(memoryStream2)
							Dim flag2 As Boolean = memoryStream.Length = memoryStream2.Length
							If flag2 Then
								memoryStream.Position = 0L
								memoryStream2.Position = 0L
								While memoryStream.Position <> memoryStream.Length AndAlso memoryStream.ReadByte() = memoryStream2.ReadByte()
								End While
								Dim flag3 As Boolean = memoryStream.Position = memoryStream.Length
								If flag3 Then
									Return xmlSchemaComplexType
								End If
							End If
						Next
					Finally
						Dim flag4 As Boolean = memoryStream IsNot Nothing
						If flag4 Then
							memoryStream.Close()
						End If
						Dim flag5 As Boolean = memoryStream2 IsNot Nothing
						If flag5 Then
							memoryStream2.Close()
						End If
					End Try
				End If
				xs.Add(schemaSerializable)
				Return xmlSchemaComplexType
			End Function

			' Token: 0x04000D71 RID: 3441
			Private columnDepartment As DataColumn

			' Token: 0x04000D72 RID: 3442
			Private columnStartDt As DataColumn

			' Token: 0x04000D73 RID: 3443
			Private columnEndDt As DataColumn

			' Token: 0x04000D74 RID: 3444
			Private columnProductType As DataColumn

			' Token: 0x04000D75 RID: 3445
			Private columnProductName As DataColumn

			' Token: 0x04000D76 RID: 3446
			Private columnBatchNo As DataColumn

			' Token: 0x04000D77 RID: 3447
			Private columnExpiryDt As DataColumn

			' Token: 0x04000D78 RID: 3448
			Private columnQuantity As DataColumn

			' Token: 0x04000D79 RID: 3449
			Private columnRate As DataColumn

			' Token: 0x04000D7A RID: 3450
			Private columnValue As DataColumn
		End Class

		' Token: 0x0200007C RID: 124
		<XmlSchemaProvider("GetTypedTableSchema")>
		<Serializable()>
		Public Class COADataTable
			Inherits TypedTableBase(Of PIMSDataSet.COARow)

			' Token: 0x06001EFE RID: 7934 RVA: 0x00119FAC File Offset: 0x001181AC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub New()
				MyBase.TableName = "COA"
				Me.BeginInit()
				Me.InitClass()
				Me.EndInit()
			End Sub

			' Token: 0x06001EFF RID: 7935 RVA: 0x00119FD8 File Offset: 0x001181D8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Friend Sub New(table As DataTable)
				MyBase.TableName = table.TableName
				Dim flag As Boolean = table.CaseSensitive <> table.DataSet.CaseSensitive
				If flag Then
					MyBase.CaseSensitive = table.CaseSensitive
				End If
				Dim flag2 As Boolean = Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), False) <> 0
				If flag2 Then
					MyBase.Locale = table.Locale
				End If
				Dim flag3 As Boolean = Operators.CompareString(table.[Namespace], table.DataSet.[Namespace], False) <> 0
				If flag3 Then
					MyBase.[Namespace] = table.[Namespace]
				End If
				MyBase.Prefix = table.Prefix
				MyBase.MinimumCapacity = table.MinimumCapacity
			End Sub

			' Token: 0x06001F00 RID: 7936 RVA: 0x0011A0A1 File Offset: 0x001182A1
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Sub New(info As SerializationInfo, context As StreamingContext)
				MyBase.New(info, context)
				Me.InitVars()
			End Sub

			' Token: 0x17000C1F RID: 3103
			' (get) Token: 0x06001F01 RID: 7937 RVA: 0x0011A0B4 File Offset: 0x001182B4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property ProgramCodeColumn As DataColumn
				Get
					Return Me.columnProgramCode
				End Get
			End Property

			' Token: 0x17000C20 RID: 3104
			' (get) Token: 0x06001F02 RID: 7938 RVA: 0x0011A0CC File Offset: 0x001182CC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property ProductNameColumn As DataColumn
				Get
					Return Me.columnProductName
				End Get
			End Property

			' Token: 0x17000C21 RID: 3105
			' (get) Token: 0x06001F03 RID: 7939 RVA: 0x0011A0E4 File Offset: 0x001182E4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property ImmunoACTPatientIDColumn As DataColumn
				Get
					Return Me.columnImmunoACTPatientID
				End Get
			End Property

			' Token: 0x17000C22 RID: 3106
			' (get) Token: 0x06001F04 RID: 7940 RVA: 0x0011A0FC File Offset: 0x001182FC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property BatchNoColumn As DataColumn
				Get
					Return Me.columnBatchNo
				End Get
			End Property

			' Token: 0x17000C23 RID: 3107
			' (get) Token: 0x06001F05 RID: 7941 RVA: 0x0011A114 File Offset: 0x00118314
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property MfgDtColumn As DataColumn
				Get
					Return Me.columnMfgDt
				End Get
			End Property

			' Token: 0x17000C24 RID: 3108
			' (get) Token: 0x06001F06 RID: 7942 RVA: 0x0011A12C File Offset: 0x0011832C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property ExpiryDtColumn As DataColumn
				Get
					Return Me.columnExpiryDt
				End Get
			End Property

			' Token: 0x17000C25 RID: 3109
			' (get) Token: 0x06001F07 RID: 7943 RVA: 0x0011A144 File Offset: 0x00118344
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property StorageConditionColumn As DataColumn
				Get
					Return Me.columnStorageCondition
				End Get
			End Property

			' Token: 0x17000C26 RID: 3110
			' (get) Token: 0x06001F08 RID: 7944 RVA: 0x0011A15C File Offset: 0x0011835C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property SpecificationNoColumn As DataColumn
				Get
					Return Me.columnSpecificationNo
				End Get
			End Property

			' Token: 0x17000C27 RID: 3111
			' (get) Token: 0x06001F09 RID: 7945 RVA: 0x0011A174 File Offset: 0x00118374
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property SrNoColumn As DataColumn
				Get
					Return Me.columnSrNo
				End Get
			End Property

			' Token: 0x17000C28 RID: 3112
			' (get) Token: 0x06001F0A RID: 7946 RVA: 0x0011A18C File Offset: 0x0011838C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property TestColumn As DataColumn
				Get
					Return Me.columnTest
				End Get
			End Property

			' Token: 0x17000C29 RID: 3113
			' (get) Token: 0x06001F0B RID: 7947 RVA: 0x0011A1A4 File Offset: 0x001183A4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property SpecificationColumn As DataColumn
				Get
					Return Me.columnSpecification
				End Get
			End Property

			' Token: 0x17000C2A RID: 3114
			' (get) Token: 0x06001F0C RID: 7948 RVA: 0x0011A1BC File Offset: 0x001183BC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property ResultColumn As DataColumn
				Get
					Return Me.columnResult
				End Get
			End Property

			' Token: 0x17000C2B RID: 3115
			' (get) Token: 0x06001F0D RID: 7949 RVA: 0x0011A1D4 File Offset: 0x001183D4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property RemarksColumn As DataColumn
				Get
					Return Me.columnRemarks
				End Get
			End Property

			' Token: 0x17000C2C RID: 3116
			' (get) Token: 0x06001F0E RID: 7950 RVA: 0x0011A1EC File Offset: 0x001183EC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property VersioNoColumn As DataColumn
				Get
					Return Me.columnVersioNo
				End Get
			End Property

			' Token: 0x17000C2D RID: 3117
			' (get) Token: 0x06001F0F RID: 7951 RVA: 0x0011A204 File Offset: 0x00118404
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property EffectiveDtColumn As DataColumn
				Get
					Return Me.columnEffectiveDt
				End Get
			End Property

			' Token: 0x17000C2E RID: 3118
			' (get) Token: 0x06001F10 RID: 7952 RVA: 0x0011A21C File Offset: 0x0011841C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property RevisionDtlsColumn As DataColumn
				Get
					Return Me.columnRevisionDtls
				End Get
			End Property

			' Token: 0x17000C2F RID: 3119
			' (get) Token: 0x06001F11 RID: 7953 RVA: 0x0011A234 File Offset: 0x00118434
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property BatchIDColumn As DataColumn
				Get
					Return Me.columnBatchID
				End Get
			End Property

			' Token: 0x17000C30 RID: 3120
			' (get) Token: 0x06001F12 RID: 7954 RVA: 0x0011A24C File Offset: 0x0011844C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property QCEntryDtColumn As DataColumn
				Get
					Return Me.columnQCEntryDt
				End Get
			End Property

			' Token: 0x17000C31 RID: 3121
			' (get) Token: 0x06001F13 RID: 7955 RVA: 0x0011A264 File Offset: 0x00118464
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property QCEntryByColumn As DataColumn
				Get
					Return Me.columnQCEntryBy
				End Get
			End Property

			' Token: 0x17000C32 RID: 3122
			' (get) Token: 0x06001F14 RID: 7956 RVA: 0x0011A27C File Offset: 0x0011847C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property QCEntryBySignColumn As DataColumn
				Get
					Return Me.columnQCEntryBySign
				End Get
			End Property

			' Token: 0x17000C33 RID: 3123
			' (get) Token: 0x06001F15 RID: 7957 RVA: 0x0011A294 File Offset: 0x00118494
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property Date_Of_QC_ReleaseColumn As DataColumn
				Get
					Return Me.columnDate_Of_QC_Release
				End Get
			End Property

			' Token: 0x17000C34 RID: 3124
			' (get) Token: 0x06001F16 RID: 7958 RVA: 0x0011A2AC File Offset: 0x001184AC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property QCCheckByColumn As DataColumn
				Get
					Return Me.columnQCCheckBy
				End Get
			End Property

			' Token: 0x17000C35 RID: 3125
			' (get) Token: 0x06001F17 RID: 7959 RVA: 0x0011A2C4 File Offset: 0x001184C4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property QCCheckBySignColumn As DataColumn
				Get
					Return Me.columnQCCheckBySign
				End Get
			End Property

			' Token: 0x17000C36 RID: 3126
			' (get) Token: 0x06001F18 RID: 7960 RVA: 0x0011A2DC File Offset: 0x001184DC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property Date_Of_QA_ReleaseColumn As DataColumn
				Get
					Return Me.columnDate_Of_QA_Release
				End Get
			End Property

			' Token: 0x17000C37 RID: 3127
			' (get) Token: 0x06001F19 RID: 7961 RVA: 0x0011A2F4 File Offset: 0x001184F4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property QACheckByColumn As DataColumn
				Get
					Return Me.columnQACheckBy
				End Get
			End Property

			' Token: 0x17000C38 RID: 3128
			' (get) Token: 0x06001F1A RID: 7962 RVA: 0x0011A30C File Offset: 0x0011850C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property QACheckBySignColumn As DataColumn
				Get
					Return Me.columnQACheckBySign
				End Get
			End Property

			' Token: 0x17000C39 RID: 3129
			' (get) Token: 0x06001F1B RID: 7963 RVA: 0x0011A324 File Offset: 0x00118524
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			<Browsable(False)>
			Public ReadOnly Property Count As Integer
				Get
					Return MyBase.Rows.Count
				End Get
			End Property

			' Token: 0x17000C3A RID: 3130
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Default Property Item(index As Integer) As PIMSDataSet.COARow
				Get
					Return CType(MyBase.Rows(index), PIMSDataSet.COARow)
				End Get
			End Property

			' Token: 0x14000015 RID: 21
			' (add) Token: 0x06001F1D RID: 7965 RVA: 0x0011A368 File Offset: 0x00118568
			' (remove) Token: 0x06001F1E RID: 7966 RVA: 0x0011A3A0 File Offset: 0x001185A0
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Event COARowChanging As PIMSDataSet.COARowChangeEventHandler

			' Token: 0x14000016 RID: 22
			' (add) Token: 0x06001F1F RID: 7967 RVA: 0x0011A3D8 File Offset: 0x001185D8
			' (remove) Token: 0x06001F20 RID: 7968 RVA: 0x0011A410 File Offset: 0x00118610
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Event COARowChanged As PIMSDataSet.COARowChangeEventHandler

			' Token: 0x14000017 RID: 23
			' (add) Token: 0x06001F21 RID: 7969 RVA: 0x0011A448 File Offset: 0x00118648
			' (remove) Token: 0x06001F22 RID: 7970 RVA: 0x0011A480 File Offset: 0x00118680
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Event COARowDeleting As PIMSDataSet.COARowChangeEventHandler

			' Token: 0x14000018 RID: 24
			' (add) Token: 0x06001F23 RID: 7971 RVA: 0x0011A4B8 File Offset: 0x001186B8
			' (remove) Token: 0x06001F24 RID: 7972 RVA: 0x0011A4F0 File Offset: 0x001186F0
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Event COARowDeleted As PIMSDataSet.COARowChangeEventHandler

			' Token: 0x06001F25 RID: 7973 RVA: 0x0011A525 File Offset: 0x00118725
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub AddCOARow(row As PIMSDataSet.COARow)
				MyBase.Rows.Add(row)
			End Sub

			' Token: 0x06001F26 RID: 7974 RVA: 0x0011A538 File Offset: 0x00118738
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function AddCOARow(ProgramCode As String, ProductName As String, ImmunoACTPatientID As String, BatchNo As String, MfgDt As DateTime, ExpiryDt As DateTime, StorageCondition As String, SpecificationNo As String, SrNo As Integer, Test As String, Specification As String, Result As String, Remarks As String, VersioNo As String, EffectiveDt As DateTime, RevisionDtls As String, BatchID As String, QCEntryDt As DateTime, QCEntryBy As String, QCEntryBySign As String, Date_Of_QC_Release As DateTime, QCCheckBy As String, QCCheckBySign As String, Date_Of_QA_Release As DateTime, QACheckBy As String, QACheckBySign As String) As PIMSDataSet.COARow
				Dim coarow As PIMSDataSet.COARow = CType(MyBase.NewRow(), PIMSDataSet.COARow)
				Dim array As Object() = New Object() { ProgramCode, ProductName, ImmunoACTPatientID, BatchNo, MfgDt, ExpiryDt, StorageCondition, SpecificationNo, SrNo, Test, Specification, Result, Remarks, VersioNo, EffectiveDt, RevisionDtls, BatchID, QCEntryDt, QCEntryBy, QCEntryBySign, Date_Of_QC_Release, QCCheckBy, QCCheckBySign, Date_Of_QA_Release, QACheckBy, QACheckBySign }
				coarow.ItemArray = array
				MyBase.Rows.Add(coarow)
				Return coarow
			End Function

			' Token: 0x06001F27 RID: 7975 RVA: 0x0011A628 File Offset: 0x00118828
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Overrides Function Clone() As DataTable
				Dim coadataTable As PIMSDataSet.COADataTable = CType(MyBase.Clone(), PIMSDataSet.COADataTable)
				coadataTable.InitVars()
				Return coadataTable
			End Function

			' Token: 0x06001F28 RID: 7976 RVA: 0x0011A650 File Offset: 0x00118850
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Function CreateInstance() As DataTable
				Return New PIMSDataSet.COADataTable()
			End Function

			' Token: 0x06001F29 RID: 7977 RVA: 0x0011A668 File Offset: 0x00118868
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Friend Sub InitVars()
				Me.columnProgramCode = MyBase.Columns("ProgramCode")
				Me.columnProductName = MyBase.Columns("ProductName")
				Me.columnImmunoACTPatientID = MyBase.Columns("ImmunoACTPatientID")
				Me.columnBatchNo = MyBase.Columns("BatchNo")
				Me.columnMfgDt = MyBase.Columns("MfgDt")
				Me.columnExpiryDt = MyBase.Columns("ExpiryDt")
				Me.columnStorageCondition = MyBase.Columns("StorageCondition")
				Me.columnSpecificationNo = MyBase.Columns("SpecificationNo")
				Me.columnSrNo = MyBase.Columns("SrNo")
				Me.columnTest = MyBase.Columns("Test")
				Me.columnSpecification = MyBase.Columns("Specification")
				Me.columnResult = MyBase.Columns("Result")
				Me.columnRemarks = MyBase.Columns("Remarks")
				Me.columnVersioNo = MyBase.Columns("VersioNo")
				Me.columnEffectiveDt = MyBase.Columns("EffectiveDt")
				Me.columnRevisionDtls = MyBase.Columns("RevisionDtls")
				Me.columnBatchID = MyBase.Columns("BatchID")
				Me.columnQCEntryDt = MyBase.Columns("QCEntryDt")
				Me.columnQCEntryBy = MyBase.Columns("QCEntryBy")
				Me.columnQCEntryBySign = MyBase.Columns("QCEntryBySign")
				Me.columnDate_Of_QC_Release = MyBase.Columns("Date_Of_QC_Release")
				Me.columnQCCheckBy = MyBase.Columns("QCCheckBy")
				Me.columnQCCheckBySign = MyBase.Columns("QCCheckBySign")
				Me.columnDate_Of_QA_Release = MyBase.Columns("Date_Of_QA_Release")
				Me.columnQACheckBy = MyBase.Columns("QACheckBy")
				Me.columnQACheckBySign = MyBase.Columns("QACheckBySign")
			End Sub

			' Token: 0x06001F2A RID: 7978 RVA: 0x0011A8B4 File Offset: 0x00118AB4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Private Sub InitClass()
				Me.columnProgramCode = New DataColumn("ProgramCode", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnProgramCode)
				Me.columnProductName = New DataColumn("ProductName", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnProductName)
				Me.columnImmunoACTPatientID = New DataColumn("ImmunoACTPatientID", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnImmunoACTPatientID)
				Me.columnBatchNo = New DataColumn("BatchNo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnBatchNo)
				Me.columnMfgDt = New DataColumn("MfgDt", GetType(DateTime), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnMfgDt)
				Me.columnExpiryDt = New DataColumn("ExpiryDt", GetType(DateTime), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnExpiryDt)
				Me.columnStorageCondition = New DataColumn("StorageCondition", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnStorageCondition)
				Me.columnSpecificationNo = New DataColumn("SpecificationNo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnSpecificationNo)
				Me.columnSrNo = New DataColumn("SrNo", GetType(Integer), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnSrNo)
				Me.columnTest = New DataColumn("Test", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnTest)
				Me.columnSpecification = New DataColumn("Specification", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnSpecification)
				Me.columnResult = New DataColumn("Result", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnResult)
				Me.columnRemarks = New DataColumn("Remarks", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnRemarks)
				Me.columnVersioNo = New DataColumn("VersioNo", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnVersioNo)
				Me.columnEffectiveDt = New DataColumn("EffectiveDt", GetType(DateTime), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnEffectiveDt)
				Me.columnRevisionDtls = New DataColumn("RevisionDtls", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnRevisionDtls)
				Me.columnBatchID = New DataColumn("BatchID", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnBatchID)
				Me.columnQCEntryDt = New DataColumn("QCEntryDt", GetType(DateTime), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnQCEntryDt)
				Me.columnQCEntryBy = New DataColumn("QCEntryBy", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnQCEntryBy)
				Me.columnQCEntryBySign = New DataColumn("QCEntryBySign", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnQCEntryBySign)
				Me.columnDate_Of_QC_Release = New DataColumn("Date_Of_QC_Release", GetType(DateTime), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDate_Of_QC_Release)
				Me.columnQCCheckBy = New DataColumn("QCCheckBy", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnQCCheckBy)
				Me.columnQCCheckBySign = New DataColumn("QCCheckBySign", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnQCCheckBySign)
				Me.columnDate_Of_QA_Release = New DataColumn("Date_Of_QA_Release", GetType(DateTime), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnDate_Of_QA_Release)
				Me.columnQACheckBy = New DataColumn("QACheckBy", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnQACheckBy)
				Me.columnQACheckBySign = New DataColumn("QACheckBySign", GetType(String), Nothing, MappingType.Element)
				MyBase.Columns.Add(Me.columnQACheckBySign)
			End Sub

			' Token: 0x06001F2B RID: 7979 RVA: 0x0011AD70 File Offset: 0x00118F70
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function NewCOARow() As PIMSDataSet.COARow
				Return CType(MyBase.NewRow(), PIMSDataSet.COARow)
			End Function

			' Token: 0x06001F2C RID: 7980 RVA: 0x0011AD90 File Offset: 0x00118F90
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Function NewRowFromBuilder(builder As DataRowBuilder) As DataRow
				Return New PIMSDataSet.COARow(builder)
			End Function

			' Token: 0x06001F2D RID: 7981 RVA: 0x0011ADA8 File Offset: 0x00118FA8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Function GetRowType() As Type
				Return GetType(PIMSDataSet.COARow)
			End Function

			' Token: 0x06001F2E RID: 7982 RVA: 0x0011ADC4 File Offset: 0x00118FC4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Sub OnRowChanged(e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				Dim flag As Boolean = Me.COARowChangedEvent IsNot Nothing
				If flag Then
					Dim coarowChangedEvent As PIMSDataSet.COARowChangeEventHandler = Me.COARowChangedEvent
					If coarowChangedEvent IsNot Nothing Then
						coarowChangedEvent(Me, New PIMSDataSet.COARowChangeEvent(CType(e.Row, PIMSDataSet.COARow), e.Action))
					End If
				End If
			End Sub

			' Token: 0x06001F2F RID: 7983 RVA: 0x0011AE14 File Offset: 0x00119014
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Sub OnRowChanging(e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				Dim flag As Boolean = Me.COARowChangingEvent IsNot Nothing
				If flag Then
					Dim coarowChangingEvent As PIMSDataSet.COARowChangeEventHandler = Me.COARowChangingEvent
					If coarowChangingEvent IsNot Nothing Then
						coarowChangingEvent(Me, New PIMSDataSet.COARowChangeEvent(CType(e.Row, PIMSDataSet.COARow), e.Action))
					End If
				End If
			End Sub

			' Token: 0x06001F30 RID: 7984 RVA: 0x0011AE64 File Offset: 0x00119064
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Sub OnRowDeleted(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				Dim flag As Boolean = Me.COARowDeletedEvent IsNot Nothing
				If flag Then
					Dim coarowDeletedEvent As PIMSDataSet.COARowChangeEventHandler = Me.COARowDeletedEvent
					If coarowDeletedEvent IsNot Nothing Then
						coarowDeletedEvent(Me, New PIMSDataSet.COARowChangeEvent(CType(e.Row, PIMSDataSet.COARow), e.Action))
					End If
				End If
			End Sub

			' Token: 0x06001F31 RID: 7985 RVA: 0x0011AEB4 File Offset: 0x001190B4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Protected Overrides Sub OnRowDeleting(e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				Dim flag As Boolean = Me.COARowDeletingEvent IsNot Nothing
				If flag Then
					Dim coarowDeletingEvent As PIMSDataSet.COARowChangeEventHandler = Me.COARowDeletingEvent
					If coarowDeletingEvent IsNot Nothing Then
						coarowDeletingEvent(Me, New PIMSDataSet.COARowChangeEvent(CType(e.Row, PIMSDataSet.COARow), e.Action))
					End If
				End If
			End Sub

			' Token: 0x06001F32 RID: 7986 RVA: 0x0011AF01 File Offset: 0x00119101
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub RemoveCOARow(row As PIMSDataSet.COARow)
				MyBase.Rows.Remove(row)
			End Sub

			' Token: 0x06001F33 RID: 7987 RVA: 0x0011AF14 File Offset: 0x00119114
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Shared Function GetTypedTableSchema(xs As XmlSchemaSet) As XmlSchemaComplexType
				Dim xmlSchemaComplexType As XmlSchemaComplexType = New XmlSchemaComplexType()
				Dim xmlSchemaSequence As XmlSchemaSequence = New XmlSchemaSequence()
				Dim pimsdataSet As PIMSDataSet = New PIMSDataSet()
				Dim xmlSchemaAny As XmlSchemaAny = New XmlSchemaAny()
				xmlSchemaAny.[Namespace] = "http://www.w3.org/2001/XMLSchema"
				xmlSchemaAny.MinOccurs = 0D
				xmlSchemaAny.MaxOccurs = Decimal.MaxValue
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax
				xmlSchemaSequence.Items.Add(xmlSchemaAny)
				Dim xmlSchemaAny2 As XmlSchemaAny = New XmlSchemaAny()
				xmlSchemaAny2.[Namespace] = "urn:schemas-microsoft-com:xml-diffgram-v1"
				xmlSchemaAny2.MinOccurs = 1D
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax
				xmlSchemaSequence.Items.Add(xmlSchemaAny2)
				Dim xmlSchemaAttribute As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute.Name = "namespace"
				xmlSchemaAttribute.FixedValue = pimsdataSet.[Namespace]
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute)
				Dim xmlSchemaAttribute2 As XmlSchemaAttribute = New XmlSchemaAttribute()
				xmlSchemaAttribute2.Name = "tableTypeName"
				xmlSchemaAttribute2.FixedValue = "COADataTable"
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2)
				xmlSchemaComplexType.Particle = xmlSchemaSequence
				Dim schemaSerializable As XmlSchema = pimsdataSet.GetSchemaSerializable()
				Dim flag As Boolean = xs.Contains(schemaSerializable.TargetNamespace)
				If flag Then
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim memoryStream2 As MemoryStream = New MemoryStream()
					Try
						schemaSerializable.Write(memoryStream)
						For Each obj As Object In xs.Schemas(schemaSerializable.TargetNamespace)
							Dim xmlSchema As XmlSchema = CType(obj, XmlSchema)
							memoryStream2.SetLength(0L)
							xmlSchema.Write(memoryStream2)
							Dim flag2 As Boolean = memoryStream.Length = memoryStream2.Length
							If flag2 Then
								memoryStream.Position = 0L
								memoryStream2.Position = 0L
								While memoryStream.Position <> memoryStream.Length AndAlso memoryStream.ReadByte() = memoryStream2.ReadByte()
								End While
								Dim flag3 As Boolean = memoryStream.Position = memoryStream.Length
								If flag3 Then
									Return xmlSchemaComplexType
								End If
							End If
						Next
					Finally
						Dim flag4 As Boolean = memoryStream IsNot Nothing
						If flag4 Then
							memoryStream.Close()
						End If
						Dim flag5 As Boolean = memoryStream2 IsNot Nothing
						If flag5 Then
							memoryStream2.Close()
						End If
					End Try
				End If
				xs.Add(schemaSerializable)
				Return xmlSchemaComplexType
			End Function

			' Token: 0x04000D7F RID: 3455
			Private columnProgramCode As DataColumn

			' Token: 0x04000D80 RID: 3456
			Private columnProductName As DataColumn

			' Token: 0x04000D81 RID: 3457
			Private columnImmunoACTPatientID As DataColumn

			' Token: 0x04000D82 RID: 3458
			Private columnBatchNo As DataColumn

			' Token: 0x04000D83 RID: 3459
			Private columnMfgDt As DataColumn

			' Token: 0x04000D84 RID: 3460
			Private columnExpiryDt As DataColumn

			' Token: 0x04000D85 RID: 3461
			Private columnStorageCondition As DataColumn

			' Token: 0x04000D86 RID: 3462
			Private columnSpecificationNo As DataColumn

			' Token: 0x04000D87 RID: 3463
			Private columnSrNo As DataColumn

			' Token: 0x04000D88 RID: 3464
			Private columnTest As DataColumn

			' Token: 0x04000D89 RID: 3465
			Private columnSpecification As DataColumn

			' Token: 0x04000D8A RID: 3466
			Private columnResult As DataColumn

			' Token: 0x04000D8B RID: 3467
			Private columnRemarks As DataColumn

			' Token: 0x04000D8C RID: 3468
			Private columnVersioNo As DataColumn

			' Token: 0x04000D8D RID: 3469
			Private columnEffectiveDt As DataColumn

			' Token: 0x04000D8E RID: 3470
			Private columnRevisionDtls As DataColumn

			' Token: 0x04000D8F RID: 3471
			Private columnBatchID As DataColumn

			' Token: 0x04000D90 RID: 3472
			Private columnQCEntryDt As DataColumn

			' Token: 0x04000D91 RID: 3473
			Private columnQCEntryBy As DataColumn

			' Token: 0x04000D92 RID: 3474
			Private columnQCEntryBySign As DataColumn

			' Token: 0x04000D93 RID: 3475
			Private columnDate_Of_QC_Release As DataColumn

			' Token: 0x04000D94 RID: 3476
			Private columnQCCheckBy As DataColumn

			' Token: 0x04000D95 RID: 3477
			Private columnQCCheckBySign As DataColumn

			' Token: 0x04000D96 RID: 3478
			Private columnDate_Of_QA_Release As DataColumn

			' Token: 0x04000D97 RID: 3479
			Private columnQACheckBy As DataColumn

			' Token: 0x04000D98 RID: 3480
			Private columnQACheckBySign As DataColumn
		End Class

		' Token: 0x0200007D RID: 125
		Public Class PORow
			Inherits DataRow

			' Token: 0x06001F34 RID: 7988 RVA: 0x0011B168 File Offset: 0x00119368
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.New(rb)
				Me.tablePO = CType(MyBase.Table, PIMSDataSet.PODataTable)
			End Sub

			' Token: 0x17000C3B RID: 3131
			' (get) Token: 0x06001F35 RID: 7989 RVA: 0x0011B184 File Offset: 0x00119384
			' (set) Token: 0x06001F36 RID: 7990 RVA: 0x0011B1D4 File Offset: 0x001193D4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property POID As Integer
				Get
					Dim num As Integer
					Try
						num = Conversions.ToInteger(MyBase(Me.tablePO.POIDColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'POID' in table 'PO' is DBNull.", ex)
					End Try
					Return num
				End Get
				Set(value As Integer)
					MyBase(Me.tablePO.POIDColumn) = value
				End Set
			End Property

			' Token: 0x17000C3C RID: 3132
			' (get) Token: 0x06001F37 RID: 7991 RVA: 0x0011B1F0 File Offset: 0x001193F0
			' (set) Token: 0x06001F38 RID: 7992 RVA: 0x0011B240 File Offset: 0x00119440
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property POType As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.POTypeColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'POType' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.POTypeColumn) = value
				End Set
			End Property

			' Token: 0x17000C3D RID: 3133
			' (get) Token: 0x06001F39 RID: 7993 RVA: 0x0011B258 File Offset: 0x00119458
			' (set) Token: 0x06001F3A RID: 7994 RVA: 0x0011B2A8 File Offset: 0x001194A8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property PONo As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.PONoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'PONo' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.PONoColumn) = value
				End Set
			End Property

			' Token: 0x17000C3E RID: 3134
			' (get) Token: 0x06001F3B RID: 7995 RVA: 0x0011B2C0 File Offset: 0x001194C0
			' (set) Token: 0x06001F3C RID: 7996 RVA: 0x0011B310 File Offset: 0x00119510
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property PODt As DateTime
				Get
					Dim dateTime As DateTime
					Try
						dateTime = Conversions.ToDate(MyBase(Me.tablePO.PODtColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'PODt' in table 'PO' is DBNull.", ex)
					End Try
					Return dateTime
				End Get
				Set(value As DateTime)
					MyBase(Me.tablePO.PODtColumn) = value
				End Set
			End Property

			' Token: 0x17000C3F RID: 3135
			' (get) Token: 0x06001F3D RID: 7997 RVA: 0x0011B32C File Offset: 0x0011952C
			' (set) Token: 0x06001F3E RID: 7998 RVA: 0x0011B37C File Offset: 0x0011957C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property PRNo As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.PRNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'PRNo' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.PRNoColumn) = value
				End Set
			End Property

			' Token: 0x17000C40 RID: 3136
			' (get) Token: 0x06001F3F RID: 7999 RVA: 0x0011B394 File Offset: 0x00119594
			' (set) Token: 0x06001F40 RID: 8000 RVA: 0x0011B3E4 File Offset: 0x001195E4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property PRDt As DateTime
				Get
					Dim dateTime As DateTime
					Try
						dateTime = Conversions.ToDate(MyBase(Me.tablePO.PRDtColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'PRDt' in table 'PO' is DBNull.", ex)
					End Try
					Return dateTime
				End Get
				Set(value As DateTime)
					MyBase(Me.tablePO.PRDtColumn) = value
				End Set
			End Property

			' Token: 0x17000C41 RID: 3137
			' (get) Token: 0x06001F41 RID: 8001 RVA: 0x0011B400 File Offset: 0x00119600
			' (set) Token: 0x06001F42 RID: 8002 RVA: 0x0011B450 File Offset: 0x00119650
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property ValidUpto As DateTime
				Get
					Dim dateTime As DateTime
					Try
						dateTime = Conversions.ToDate(MyBase(Me.tablePO.ValidUptoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'ValidUpto' in table 'PO' is DBNull.", ex)
					End Try
					Return dateTime
				End Get
				Set(value As DateTime)
					MyBase(Me.tablePO.ValidUptoColumn) = value
				End Set
			End Property

			' Token: 0x17000C42 RID: 3138
			' (get) Token: 0x06001F43 RID: 8003 RVA: 0x0011B46C File Offset: 0x0011966C
			' (set) Token: 0x06001F44 RID: 8004 RVA: 0x0011B4BC File Offset: 0x001196BC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property DeliveryDt As DateTime
				Get
					Dim dateTime As DateTime
					Try
						dateTime = Conversions.ToDate(MyBase(Me.tablePO.DeliveryDtColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'DeliveryDt' in table 'PO' is DBNull.", ex)
					End Try
					Return dateTime
				End Get
				Set(value As DateTime)
					MyBase(Me.tablePO.DeliveryDtColumn) = value
				End Set
			End Property

			' Token: 0x17000C43 RID: 3139
			' (get) Token: 0x06001F45 RID: 8005 RVA: 0x0011B4D8 File Offset: 0x001196D8
			' (set) Token: 0x06001F46 RID: 8006 RVA: 0x0011B528 File Offset: 0x00119728
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property Department As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.DepartmentColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'Department' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.DepartmentColumn) = value
				End Set
			End Property

			' Token: 0x17000C44 RID: 3140
			' (get) Token: 0x06001F47 RID: 8007 RVA: 0x0011B540 File Offset: 0x00119740
			' (set) Token: 0x06001F48 RID: 8008 RVA: 0x0011B590 File Offset: 0x00119790
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property InvoiceAddress As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.InvoiceAddressColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'InvoiceAddress' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.InvoiceAddressColumn) = value
				End Set
			End Property

			' Token: 0x17000C45 RID: 3141
			' (get) Token: 0x06001F49 RID: 8009 RVA: 0x0011B5A8 File Offset: 0x001197A8
			' (set) Token: 0x06001F4A RID: 8010 RVA: 0x0011B5F8 File Offset: 0x001197F8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property BillingEmailID As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.BillingEmailIDColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'BillingEmailID' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.BillingEmailIDColumn) = value
				End Set
			End Property

			' Token: 0x17000C46 RID: 3142
			' (get) Token: 0x06001F4B RID: 8011 RVA: 0x0011B610 File Offset: 0x00119810
			' (set) Token: 0x06001F4C RID: 8012 RVA: 0x0011B660 File Offset: 0x00119860
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property ShipAddress As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.ShipAddressColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'ShipAddress' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.ShipAddressColumn) = value
				End Set
			End Property

			' Token: 0x17000C47 RID: 3143
			' (get) Token: 0x06001F4D RID: 8013 RVA: 0x0011B678 File Offset: 0x00119878
			' (set) Token: 0x06001F4E RID: 8014 RVA: 0x0011B6C8 File Offset: 0x001198C8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property ShippingEmailID As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.ShippingEmailIDColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'ShippingEmailID' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.ShippingEmailIDColumn) = value
				End Set
			End Property

			' Token: 0x17000C48 RID: 3144
			' (get) Token: 0x06001F4F RID: 8015 RVA: 0x0011B6E0 File Offset: 0x001198E0
			' (set) Token: 0x06001F50 RID: 8016 RVA: 0x0011B730 File Offset: 0x00119930
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property GSTNo As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.GSTNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'GSTNo' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.GSTNoColumn) = value
				End Set
			End Property

			' Token: 0x17000C49 RID: 3145
			' (get) Token: 0x06001F51 RID: 8017 RVA: 0x0011B748 File Offset: 0x00119948
			' (set) Token: 0x06001F52 RID: 8018 RVA: 0x0011B798 File Offset: 0x00119998
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property PANNo As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.PANNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'PANNo' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.PANNoColumn) = value
				End Set
			End Property

			' Token: 0x17000C4A RID: 3146
			' (get) Token: 0x06001F53 RID: 8019 RVA: 0x0011B7B0 File Offset: 0x001199B0
			' (set) Token: 0x06001F54 RID: 8020 RVA: 0x0011B800 File Offset: 0x00119A00
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property VendorName As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.VendorNameColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'VendorName' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.VendorNameColumn) = value
				End Set
			End Property

			' Token: 0x17000C4B RID: 3147
			' (get) Token: 0x06001F55 RID: 8021 RVA: 0x0011B818 File Offset: 0x00119A18
			' (set) Token: 0x06001F56 RID: 8022 RVA: 0x0011B868 File Offset: 0x00119A68
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property VendorBillingAddress As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.VendorBillingAddressColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'VendorBillingAddress' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.VendorBillingAddressColumn) = value
				End Set
			End Property

			' Token: 0x17000C4C RID: 3148
			' (get) Token: 0x06001F57 RID: 8023 RVA: 0x0011B880 File Offset: 0x00119A80
			' (set) Token: 0x06001F58 RID: 8024 RVA: 0x0011B8D0 File Offset: 0x00119AD0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property VendorContactPerson As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.VendorContactPersonColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'VendorContactPerson' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.VendorContactPersonColumn) = value
				End Set
			End Property

			' Token: 0x17000C4D RID: 3149
			' (get) Token: 0x06001F59 RID: 8025 RVA: 0x0011B8E8 File Offset: 0x00119AE8
			' (set) Token: 0x06001F5A RID: 8026 RVA: 0x0011B938 File Offset: 0x00119B38
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property VendorContactNo As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.VendorContactNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'VendorContactNo' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.VendorContactNoColumn) = value
				End Set
			End Property

			' Token: 0x17000C4E RID: 3150
			' (get) Token: 0x06001F5B RID: 8027 RVA: 0x0011B950 File Offset: 0x00119B50
			' (set) Token: 0x06001F5C RID: 8028 RVA: 0x0011B9A0 File Offset: 0x00119BA0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property VendorEmailID As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.VendorEmailIDColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'VendorEmailID' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.VendorEmailIDColumn) = value
				End Set
			End Property

			' Token: 0x17000C4F RID: 3151
			' (get) Token: 0x06001F5D RID: 8029 RVA: 0x0011B9B8 File Offset: 0x00119BB8
			' (set) Token: 0x06001F5E RID: 8030 RVA: 0x0011BA08 File Offset: 0x00119C08
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property VendorGSTNo As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.VendorGSTNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'VendorGSTNo' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.VendorGSTNoColumn) = value
				End Set
			End Property

			' Token: 0x17000C50 RID: 3152
			' (get) Token: 0x06001F5F RID: 8031 RVA: 0x0011BA20 File Offset: 0x00119C20
			' (set) Token: 0x06001F60 RID: 8032 RVA: 0x0011BA70 File Offset: 0x00119C70
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property VendorPANNo As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.VendorPANNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'VendorPANNo' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.VendorPANNoColumn) = value
				End Set
			End Property

			' Token: 0x17000C51 RID: 3153
			' (get) Token: 0x06001F61 RID: 8033 RVA: 0x0011BA88 File Offset: 0x00119C88
			' (set) Token: 0x06001F62 RID: 8034 RVA: 0x0011BAD8 File Offset: 0x00119CD8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property BankName As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.BankNameColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'BankName' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.BankNameColumn) = value
				End Set
			End Property

			' Token: 0x17000C52 RID: 3154
			' (get) Token: 0x06001F63 RID: 8035 RVA: 0x0011BAF0 File Offset: 0x00119CF0
			' (set) Token: 0x06001F64 RID: 8036 RVA: 0x0011BB40 File Offset: 0x00119D40
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property BankAddress As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.BankAddressColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'BankAddress' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.BankAddressColumn) = value
				End Set
			End Property

			' Token: 0x17000C53 RID: 3155
			' (get) Token: 0x06001F65 RID: 8037 RVA: 0x0011BB58 File Offset: 0x00119D58
			' (set) Token: 0x06001F66 RID: 8038 RVA: 0x0011BBA8 File Offset: 0x00119DA8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property AccountNo As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.AccountNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'AccountNo' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.AccountNoColumn) = value
				End Set
			End Property

			' Token: 0x17000C54 RID: 3156
			' (get) Token: 0x06001F67 RID: 8039 RVA: 0x0011BBC0 File Offset: 0x00119DC0
			' (set) Token: 0x06001F68 RID: 8040 RVA: 0x0011BC10 File Offset: 0x00119E10
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property IFSCCode As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.IFSCCodeColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'IFSCCode' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.IFSCCodeColumn) = value
				End Set
			End Property

			' Token: 0x17000C55 RID: 3157
			' (get) Token: 0x06001F69 RID: 8041 RVA: 0x0011BC28 File Offset: 0x00119E28
			' (set) Token: 0x06001F6A RID: 8042 RVA: 0x0011BC78 File Offset: 0x00119E78
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property IBANNo As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.IBANNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'IBANNo' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.IBANNoColumn) = value
				End Set
			End Property

			' Token: 0x17000C56 RID: 3158
			' (get) Token: 0x06001F6B RID: 8043 RVA: 0x0011BC90 File Offset: 0x00119E90
			' (set) Token: 0x06001F6C RID: 8044 RVA: 0x0011BCE0 File Offset: 0x00119EE0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property BankRoutingNo As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.BankRoutingNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'BankRoutingNo' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.BankRoutingNoColumn) = value
				End Set
			End Property

			' Token: 0x17000C57 RID: 3159
			' (get) Token: 0x06001F6D RID: 8045 RVA: 0x0011BCF8 File Offset: 0x00119EF8
			' (set) Token: 0x06001F6E RID: 8046 RVA: 0x0011BD48 File Offset: 0x00119F48
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property BankSortCode As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.BankSortCodeColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'BankSortCode' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.BankSortCodeColumn) = value
				End Set
			End Property

			' Token: 0x17000C58 RID: 3160
			' (get) Token: 0x06001F6F RID: 8047 RVA: 0x0011BD60 File Offset: 0x00119F60
			' (set) Token: 0x06001F70 RID: 8048 RVA: 0x0011BDB0 File Offset: 0x00119FB0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property SWIFTCode As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.SWIFTCodeColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'SWIFTCode' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.SWIFTCodeColumn) = value
				End Set
			End Property

			' Token: 0x17000C59 RID: 3161
			' (get) Token: 0x06001F71 RID: 8049 RVA: 0x0011BDC8 File Offset: 0x00119FC8
			' (set) Token: 0x06001F72 RID: 8050 RVA: 0x0011BE18 File Offset: 0x0011A018
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property ModeOfPayment As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.ModeOfPaymentColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'ModeOfPayment' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.ModeOfPaymentColumn) = value
				End Set
			End Property

			' Token: 0x17000C5A RID: 3162
			' (get) Token: 0x06001F73 RID: 8051 RVA: 0x0011BE30 File Offset: 0x0011A030
			' (set) Token: 0x06001F74 RID: 8052 RVA: 0x0011BE80 File Offset: 0x0011A080
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property DispatchedThrough As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.DispatchedThroughColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'DispatchedThrough' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.DispatchedThroughColumn) = value
				End Set
			End Property

			' Token: 0x17000C5B RID: 3163
			' (get) Token: 0x06001F75 RID: 8053 RVA: 0x0011BE98 File Offset: 0x0011A098
			' (set) Token: 0x06001F76 RID: 8054 RVA: 0x0011BEE8 File Offset: 0x0011A0E8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property PaymentTerms As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.PaymentTermsColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'PaymentTerms' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.PaymentTermsColumn) = value
				End Set
			End Property

			' Token: 0x17000C5C RID: 3164
			' (get) Token: 0x06001F77 RID: 8055 RVA: 0x0011BF00 File Offset: 0x0011A100
			' (set) Token: 0x06001F78 RID: 8056 RVA: 0x0011BF50 File Offset: 0x0011A150
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property IncoTerms As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.IncoTermsColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'IncoTerms' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.IncoTermsColumn) = value
				End Set
			End Property

			' Token: 0x17000C5D RID: 3165
			' (get) Token: 0x06001F79 RID: 8057 RVA: 0x0011BF68 File Offset: 0x0011A168
			' (set) Token: 0x06001F7A RID: 8058 RVA: 0x0011BFB8 File Offset: 0x0011A1B8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property DeliveryTerms As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.DeliveryTermsColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'DeliveryTerms' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.DeliveryTermsColumn) = value
				End Set
			End Property

			' Token: 0x17000C5E RID: 3166
			' (get) Token: 0x06001F7B RID: 8059 RVA: 0x0011BFD0 File Offset: 0x0011A1D0
			' (set) Token: 0x06001F7C RID: 8060 RVA: 0x0011C020 File Offset: 0x0011A220
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property Currency As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.CurrencyColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'Currency' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.CurrencyColumn) = value
				End Set
			End Property

			' Token: 0x17000C5F RID: 3167
			' (get) Token: 0x06001F7D RID: 8061 RVA: 0x0011C038 File Offset: 0x0011A238
			' (set) Token: 0x06001F7E RID: 8062 RVA: 0x0011C088 File Offset: 0x0011A288
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property Comments As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.CommentsColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'Comments' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.CommentsColumn) = value
				End Set
			End Property

			' Token: 0x17000C60 RID: 3168
			' (get) Token: 0x06001F7F RID: 8063 RVA: 0x0011C0A0 File Offset: 0x0011A2A0
			' (set) Token: 0x06001F80 RID: 8064 RVA: 0x0011C0F0 File Offset: 0x0011A2F0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property CreatedBy As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.CreatedByColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'CreatedBy' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.CreatedByColumn) = value
				End Set
			End Property

			' Token: 0x17000C61 RID: 3169
			' (get) Token: 0x06001F81 RID: 8065 RVA: 0x0011C108 File Offset: 0x0011A308
			' (set) Token: 0x06001F82 RID: 8066 RVA: 0x0011C158 File Offset: 0x0011A358
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property CreationDt As DateTime
				Get
					Dim dateTime As DateTime
					Try
						dateTime = Conversions.ToDate(MyBase(Me.tablePO.CreationDtColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'CreationDt' in table 'PO' is DBNull.", ex)
					End Try
					Return dateTime
				End Get
				Set(value As DateTime)
					MyBase(Me.tablePO.CreationDtColumn) = value
				End Set
			End Property

			' Token: 0x17000C62 RID: 3170
			' (get) Token: 0x06001F83 RID: 8067 RVA: 0x0011C174 File Offset: 0x0011A374
			' (set) Token: 0x06001F84 RID: 8068 RVA: 0x0011C1C4 File Offset: 0x0011A3C4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property ApprovedBy As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.ApprovedByColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'ApprovedBy' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.ApprovedByColumn) = value
				End Set
			End Property

			' Token: 0x17000C63 RID: 3171
			' (get) Token: 0x06001F85 RID: 8069 RVA: 0x0011C1DC File Offset: 0x0011A3DC
			' (set) Token: 0x06001F86 RID: 8070 RVA: 0x0011C22C File Offset: 0x0011A42C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property PrintedBy As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.PrintedByColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'PrintedBy' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.PrintedByColumn) = value
				End Set
			End Property

			' Token: 0x17000C64 RID: 3172
			' (get) Token: 0x06001F87 RID: 8071 RVA: 0x0011C244 File Offset: 0x0011A444
			' (set) Token: 0x06001F88 RID: 8072 RVA: 0x0011C294 File Offset: 0x0011A494
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property SrNo As Integer
				Get
					Dim num As Integer
					Try
						num = Conversions.ToInteger(MyBase(Me.tablePO.SrNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'SrNo' in table 'PO' is DBNull.", ex)
					End Try
					Return num
				End Get
				Set(value As Integer)
					MyBase(Me.tablePO.SrNoColumn) = value
				End Set
			End Property

			' Token: 0x17000C65 RID: 3173
			' (get) Token: 0x06001F89 RID: 8073 RVA: 0x0011C2B0 File Offset: 0x0011A4B0
			' (set) Token: 0x06001F8A RID: 8074 RVA: 0x0011C300 File Offset: 0x0011A500
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property ProductName As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.ProductNameColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'ProductName' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.ProductNameColumn) = value
				End Set
			End Property

			' Token: 0x17000C66 RID: 3174
			' (get) Token: 0x06001F8B RID: 8075 RVA: 0x0011C318 File Offset: 0x0011A518
			' (set) Token: 0x06001F8C RID: 8076 RVA: 0x0011C368 File Offset: 0x0011A568
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property Description As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.DescriptionColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'Description' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.DescriptionColumn) = value
				End Set
			End Property

			' Token: 0x17000C67 RID: 3175
			' (get) Token: 0x06001F8D RID: 8077 RVA: 0x0011C380 File Offset: 0x0011A580
			' (set) Token: 0x06001F8E RID: 8078 RVA: 0x0011C3D0 File Offset: 0x0011A5D0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property CatalogNo As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.CatalogNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'CatalogNo' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.CatalogNoColumn) = value
				End Set
			End Property

			' Token: 0x17000C68 RID: 3176
			' (get) Token: 0x06001F8F RID: 8079 RVA: 0x0011C3E8 File Offset: 0x0011A5E8
			' (set) Token: 0x06001F90 RID: 8080 RVA: 0x0011C438 File Offset: 0x0011A638
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property HSNSACCode As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.HSNSACCodeColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'HSNSACCode' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.HSNSACCodeColumn) = value
				End Set
			End Property

			' Token: 0x17000C69 RID: 3177
			' (get) Token: 0x06001F91 RID: 8081 RVA: 0x0011C450 File Offset: 0x0011A650
			' (set) Token: 0x06001F92 RID: 8082 RVA: 0x0011C4A0 File Offset: 0x0011A6A0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property UOM As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.UOMColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'UOM' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.UOMColumn) = value
				End Set
			End Property

			' Token: 0x17000C6A RID: 3178
			' (get) Token: 0x06001F93 RID: 8083 RVA: 0x0011C4B8 File Offset: 0x0011A6B8
			' (set) Token: 0x06001F94 RID: 8084 RVA: 0x0011C508 File Offset: 0x0011A708
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property Quantity As Integer
				Get
					Dim num As Integer
					Try
						num = Conversions.ToInteger(MyBase(Me.tablePO.QuantityColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'Quantity' in table 'PO' is DBNull.", ex)
					End Try
					Return num
				End Get
				Set(value As Integer)
					MyBase(Me.tablePO.QuantityColumn) = value
				End Set
			End Property

			' Token: 0x17000C6B RID: 3179
			' (get) Token: 0x06001F95 RID: 8085 RVA: 0x0011C524 File Offset: 0x0011A724
			' (set) Token: 0x06001F96 RID: 8086 RVA: 0x0011C574 File Offset: 0x0011A774
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property UnitPrice As Double
				Get
					Dim num As Double
					Try
						num = Conversions.ToDouble(MyBase(Me.tablePO.UnitPriceColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'UnitPrice' in table 'PO' is DBNull.", ex)
					End Try
					Return num
				End Get
				Set(value As Double)
					MyBase(Me.tablePO.UnitPriceColumn) = value
				End Set
			End Property

			' Token: 0x17000C6C RID: 3180
			' (get) Token: 0x06001F97 RID: 8087 RVA: 0x0011C590 File Offset: 0x0011A790
			' (set) Token: 0x06001F98 RID: 8088 RVA: 0x0011C5E0 File Offset: 0x0011A7E0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property BasicValue As Double
				Get
					Dim num As Double
					Try
						num = Conversions.ToDouble(MyBase(Me.tablePO.BasicValueColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'BasicValue' in table 'PO' is DBNull.", ex)
					End Try
					Return num
				End Get
				Set(value As Double)
					MyBase(Me.tablePO.BasicValueColumn) = value
				End Set
			End Property

			' Token: 0x17000C6D RID: 3181
			' (get) Token: 0x06001F99 RID: 8089 RVA: 0x0011C5FC File Offset: 0x0011A7FC
			' (set) Token: 0x06001F9A RID: 8090 RVA: 0x0011C64C File Offset: 0x0011A84C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property DiscountPer As Double
				Get
					Dim num As Double
					Try
						num = Conversions.ToDouble(MyBase(Me.tablePO.DiscountPerColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'DiscountPer' in table 'PO' is DBNull.", ex)
					End Try
					Return num
				End Get
				Set(value As Double)
					MyBase(Me.tablePO.DiscountPerColumn) = value
				End Set
			End Property

			' Token: 0x17000C6E RID: 3182
			' (get) Token: 0x06001F9B RID: 8091 RVA: 0x0011C668 File Offset: 0x0011A868
			' (set) Token: 0x06001F9C RID: 8092 RVA: 0x0011C6B8 File Offset: 0x0011A8B8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property DiscountAmt As Double
				Get
					Dim num As Double
					Try
						num = Conversions.ToDouble(MyBase(Me.tablePO.DiscountAmtColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'DiscountAmt' in table 'PO' is DBNull.", ex)
					End Try
					Return num
				End Get
				Set(value As Double)
					MyBase(Me.tablePO.DiscountAmtColumn) = value
				End Set
			End Property

			' Token: 0x17000C6F RID: 3183
			' (get) Token: 0x06001F9D RID: 8093 RVA: 0x0011C6D4 File Offset: 0x0011A8D4
			' (set) Token: 0x06001F9E RID: 8094 RVA: 0x0011C724 File Offset: 0x0011A924
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property NetAmt As Double
				Get
					Dim num As Double
					Try
						num = Conversions.ToDouble(MyBase(Me.tablePO.NetAmtColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'NetAmt' in table 'PO' is DBNull.", ex)
					End Try
					Return num
				End Get
				Set(value As Double)
					MyBase(Me.tablePO.NetAmtColumn) = value
				End Set
			End Property

			' Token: 0x17000C70 RID: 3184
			' (get) Token: 0x06001F9F RID: 8095 RVA: 0x0011C740 File Offset: 0x0011A940
			' (set) Token: 0x06001FA0 RID: 8096 RVA: 0x0011C790 File Offset: 0x0011A990
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property TaxPer As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tablePO.TaxPerColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'TaxPer' in table 'PO' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tablePO.TaxPerColumn) = value
				End Set
			End Property

			' Token: 0x17000C71 RID: 3185
			' (get) Token: 0x06001FA1 RID: 8097 RVA: 0x0011C7A8 File Offset: 0x0011A9A8
			' (set) Token: 0x06001FA2 RID: 8098 RVA: 0x0011C7F8 File Offset: 0x0011A9F8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property TaxAmt As Double
				Get
					Dim num As Double
					Try
						num = Conversions.ToDouble(MyBase(Me.tablePO.TaxAmtColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'TaxAmt' in table 'PO' is DBNull.", ex)
					End Try
					Return num
				End Get
				Set(value As Double)
					MyBase(Me.tablePO.TaxAmtColumn) = value
				End Set
			End Property

			' Token: 0x17000C72 RID: 3186
			' (get) Token: 0x06001FA3 RID: 8099 RVA: 0x0011C814 File Offset: 0x0011AA14
			' (set) Token: 0x06001FA4 RID: 8100 RVA: 0x0011C864 File Offset: 0x0011AA64
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property Transportation As Double
				Get
					Dim num As Double
					Try
						num = Conversions.ToDouble(MyBase(Me.tablePO.TransportationColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'Transportation' in table 'PO' is DBNull.", ex)
					End Try
					Return num
				End Get
				Set(value As Double)
					MyBase(Me.tablePO.TransportationColumn) = value
				End Set
			End Property

			' Token: 0x17000C73 RID: 3187
			' (get) Token: 0x06001FA5 RID: 8101 RVA: 0x0011C880 File Offset: 0x0011AA80
			' (set) Token: 0x06001FA6 RID: 8102 RVA: 0x0011C8D0 File Offset: 0x0011AAD0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property Freight As Double
				Get
					Dim num As Double
					Try
						num = Conversions.ToDouble(MyBase(Me.tablePO.FreightColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'Freight' in table 'PO' is DBNull.", ex)
					End Try
					Return num
				End Get
				Set(value As Double)
					MyBase(Me.tablePO.FreightColumn) = value
				End Set
			End Property

			' Token: 0x17000C74 RID: 3188
			' (get) Token: 0x06001FA7 RID: 8103 RVA: 0x0011C8EC File Offset: 0x0011AAEC
			' (set) Token: 0x06001FA8 RID: 8104 RVA: 0x0011C93C File Offset: 0x0011AB3C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property LoadingUnloading As Double
				Get
					Dim num As Double
					Try
						num = Conversions.ToDouble(MyBase(Me.tablePO.LoadingUnloadingColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'LoadingUnloading' in table 'PO' is DBNull.", ex)
					End Try
					Return num
				End Get
				Set(value As Double)
					MyBase(Me.tablePO.LoadingUnloadingColumn) = value
				End Set
			End Property

			' Token: 0x17000C75 RID: 3189
			' (get) Token: 0x06001FA9 RID: 8105 RVA: 0x0011C958 File Offset: 0x0011AB58
			' (set) Token: 0x06001FAA RID: 8106 RVA: 0x0011C9A8 File Offset: 0x0011ABA8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property Packing As Double
				Get
					Dim num As Double
					Try
						num = Conversions.ToDouble(MyBase(Me.tablePO.PackingColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'Packing' in table 'PO' is DBNull.", ex)
					End Try
					Return num
				End Get
				Set(value As Double)
					MyBase(Me.tablePO.PackingColumn) = value
				End Set
			End Property

			' Token: 0x17000C76 RID: 3190
			' (get) Token: 0x06001FAB RID: 8107 RVA: 0x0011C9C4 File Offset: 0x0011ABC4
			' (set) Token: 0x06001FAC RID: 8108 RVA: 0x0011CA14 File Offset: 0x0011AC14
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property OtherCharges As Double
				Get
					Dim num As Double
					Try
						num = Conversions.ToDouble(MyBase(Me.tablePO.OtherChargesColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'OtherCharges' in table 'PO' is DBNull.", ex)
					End Try
					Return num
				End Get
				Set(value As Double)
					MyBase(Me.tablePO.OtherChargesColumn) = value
				End Set
			End Property

			' Token: 0x17000C77 RID: 3191
			' (get) Token: 0x06001FAD RID: 8109 RVA: 0x0011CA30 File Offset: 0x0011AC30
			' (set) Token: 0x06001FAE RID: 8110 RVA: 0x0011CA80 File Offset: 0x0011AC80
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property FinalAmt As Double
				Get
					Dim num As Double
					Try
						num = Conversions.ToDouble(MyBase(Me.tablePO.FinalAmtColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'FinalAmt' in table 'PO' is DBNull.", ex)
					End Try
					Return num
				End Get
				Set(value As Double)
					MyBase(Me.tablePO.FinalAmtColumn) = value
				End Set
			End Property

			' Token: 0x06001FAF RID: 8111 RVA: 0x0011CA9C File Offset: 0x0011AC9C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsPOIDNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.POIDColumn)
			End Function

			' Token: 0x06001FB0 RID: 8112 RVA: 0x0011CABF File Offset: 0x0011ACBF
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetPOIDNull()
				MyBase(Me.tablePO.POIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FB1 RID: 8113 RVA: 0x0011CAE0 File Offset: 0x0011ACE0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsPOTypeNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.POTypeColumn)
			End Function

			' Token: 0x06001FB2 RID: 8114 RVA: 0x0011CB03 File Offset: 0x0011AD03
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetPOTypeNull()
				MyBase(Me.tablePO.POTypeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FB3 RID: 8115 RVA: 0x0011CB24 File Offset: 0x0011AD24
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsPONoNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.PONoColumn)
			End Function

			' Token: 0x06001FB4 RID: 8116 RVA: 0x0011CB47 File Offset: 0x0011AD47
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetPONoNull()
				MyBase(Me.tablePO.PONoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FB5 RID: 8117 RVA: 0x0011CB68 File Offset: 0x0011AD68
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsPODtNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.PODtColumn)
			End Function

			' Token: 0x06001FB6 RID: 8118 RVA: 0x0011CB8B File Offset: 0x0011AD8B
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetPODtNull()
				MyBase(Me.tablePO.PODtColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FB7 RID: 8119 RVA: 0x0011CBAC File Offset: 0x0011ADAC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsPRNoNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.PRNoColumn)
			End Function

			' Token: 0x06001FB8 RID: 8120 RVA: 0x0011CBCF File Offset: 0x0011ADCF
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetPRNoNull()
				MyBase(Me.tablePO.PRNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FB9 RID: 8121 RVA: 0x0011CBF0 File Offset: 0x0011ADF0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsPRDtNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.PRDtColumn)
			End Function

			' Token: 0x06001FBA RID: 8122 RVA: 0x0011CC13 File Offset: 0x0011AE13
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetPRDtNull()
				MyBase(Me.tablePO.PRDtColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FBB RID: 8123 RVA: 0x0011CC34 File Offset: 0x0011AE34
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsValidUptoNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.ValidUptoColumn)
			End Function

			' Token: 0x06001FBC RID: 8124 RVA: 0x0011CC57 File Offset: 0x0011AE57
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetValidUptoNull()
				MyBase(Me.tablePO.ValidUptoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FBD RID: 8125 RVA: 0x0011CC78 File Offset: 0x0011AE78
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsDeliveryDtNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.DeliveryDtColumn)
			End Function

			' Token: 0x06001FBE RID: 8126 RVA: 0x0011CC9B File Offset: 0x0011AE9B
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetDeliveryDtNull()
				MyBase(Me.tablePO.DeliveryDtColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FBF RID: 8127 RVA: 0x0011CCBC File Offset: 0x0011AEBC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsDepartmentNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.DepartmentColumn)
			End Function

			' Token: 0x06001FC0 RID: 8128 RVA: 0x0011CCDF File Offset: 0x0011AEDF
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetDepartmentNull()
				MyBase(Me.tablePO.DepartmentColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FC1 RID: 8129 RVA: 0x0011CD00 File Offset: 0x0011AF00
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsInvoiceAddressNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.InvoiceAddressColumn)
			End Function

			' Token: 0x06001FC2 RID: 8130 RVA: 0x0011CD23 File Offset: 0x0011AF23
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetInvoiceAddressNull()
				MyBase(Me.tablePO.InvoiceAddressColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FC3 RID: 8131 RVA: 0x0011CD44 File Offset: 0x0011AF44
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsBillingEmailIDNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.BillingEmailIDColumn)
			End Function

			' Token: 0x06001FC4 RID: 8132 RVA: 0x0011CD67 File Offset: 0x0011AF67
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetBillingEmailIDNull()
				MyBase(Me.tablePO.BillingEmailIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FC5 RID: 8133 RVA: 0x0011CD88 File Offset: 0x0011AF88
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsShipAddressNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.ShipAddressColumn)
			End Function

			' Token: 0x06001FC6 RID: 8134 RVA: 0x0011CDAB File Offset: 0x0011AFAB
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetShipAddressNull()
				MyBase(Me.tablePO.ShipAddressColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FC7 RID: 8135 RVA: 0x0011CDCC File Offset: 0x0011AFCC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsShippingEmailIDNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.ShippingEmailIDColumn)
			End Function

			' Token: 0x06001FC8 RID: 8136 RVA: 0x0011CDEF File Offset: 0x0011AFEF
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetShippingEmailIDNull()
				MyBase(Me.tablePO.ShippingEmailIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FC9 RID: 8137 RVA: 0x0011CE10 File Offset: 0x0011B010
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsGSTNoNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.GSTNoColumn)
			End Function

			' Token: 0x06001FCA RID: 8138 RVA: 0x0011CE33 File Offset: 0x0011B033
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetGSTNoNull()
				MyBase(Me.tablePO.GSTNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FCB RID: 8139 RVA: 0x0011CE54 File Offset: 0x0011B054
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsPANNoNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.PANNoColumn)
			End Function

			' Token: 0x06001FCC RID: 8140 RVA: 0x0011CE77 File Offset: 0x0011B077
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetPANNoNull()
				MyBase(Me.tablePO.PANNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FCD RID: 8141 RVA: 0x0011CE98 File Offset: 0x0011B098
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsVendorNameNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.VendorNameColumn)
			End Function

			' Token: 0x06001FCE RID: 8142 RVA: 0x0011CEBB File Offset: 0x0011B0BB
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetVendorNameNull()
				MyBase(Me.tablePO.VendorNameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FCF RID: 8143 RVA: 0x0011CEDC File Offset: 0x0011B0DC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsVendorBillingAddressNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.VendorBillingAddressColumn)
			End Function

			' Token: 0x06001FD0 RID: 8144 RVA: 0x0011CEFF File Offset: 0x0011B0FF
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetVendorBillingAddressNull()
				MyBase(Me.tablePO.VendorBillingAddressColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FD1 RID: 8145 RVA: 0x0011CF20 File Offset: 0x0011B120
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsVendorContactPersonNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.VendorContactPersonColumn)
			End Function

			' Token: 0x06001FD2 RID: 8146 RVA: 0x0011CF43 File Offset: 0x0011B143
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetVendorContactPersonNull()
				MyBase(Me.tablePO.VendorContactPersonColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FD3 RID: 8147 RVA: 0x0011CF64 File Offset: 0x0011B164
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsVendorContactNoNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.VendorContactNoColumn)
			End Function

			' Token: 0x06001FD4 RID: 8148 RVA: 0x0011CF87 File Offset: 0x0011B187
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetVendorContactNoNull()
				MyBase(Me.tablePO.VendorContactNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FD5 RID: 8149 RVA: 0x0011CFA8 File Offset: 0x0011B1A8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsVendorEmailIDNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.VendorEmailIDColumn)
			End Function

			' Token: 0x06001FD6 RID: 8150 RVA: 0x0011CFCB File Offset: 0x0011B1CB
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetVendorEmailIDNull()
				MyBase(Me.tablePO.VendorEmailIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FD7 RID: 8151 RVA: 0x0011CFEC File Offset: 0x0011B1EC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsVendorGSTNoNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.VendorGSTNoColumn)
			End Function

			' Token: 0x06001FD8 RID: 8152 RVA: 0x0011D00F File Offset: 0x0011B20F
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetVendorGSTNoNull()
				MyBase(Me.tablePO.VendorGSTNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FD9 RID: 8153 RVA: 0x0011D030 File Offset: 0x0011B230
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsVendorPANNoNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.VendorPANNoColumn)
			End Function

			' Token: 0x06001FDA RID: 8154 RVA: 0x0011D053 File Offset: 0x0011B253
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetVendorPANNoNull()
				MyBase(Me.tablePO.VendorPANNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FDB RID: 8155 RVA: 0x0011D074 File Offset: 0x0011B274
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsBankNameNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.BankNameColumn)
			End Function

			' Token: 0x06001FDC RID: 8156 RVA: 0x0011D097 File Offset: 0x0011B297
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetBankNameNull()
				MyBase(Me.tablePO.BankNameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FDD RID: 8157 RVA: 0x0011D0B8 File Offset: 0x0011B2B8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsBankAddressNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.BankAddressColumn)
			End Function

			' Token: 0x06001FDE RID: 8158 RVA: 0x0011D0DB File Offset: 0x0011B2DB
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetBankAddressNull()
				MyBase(Me.tablePO.BankAddressColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FDF RID: 8159 RVA: 0x0011D0FC File Offset: 0x0011B2FC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsAccountNoNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.AccountNoColumn)
			End Function

			' Token: 0x06001FE0 RID: 8160 RVA: 0x0011D11F File Offset: 0x0011B31F
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetAccountNoNull()
				MyBase(Me.tablePO.AccountNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FE1 RID: 8161 RVA: 0x0011D140 File Offset: 0x0011B340
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsIFSCCodeNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.IFSCCodeColumn)
			End Function

			' Token: 0x06001FE2 RID: 8162 RVA: 0x0011D163 File Offset: 0x0011B363
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetIFSCCodeNull()
				MyBase(Me.tablePO.IFSCCodeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FE3 RID: 8163 RVA: 0x0011D184 File Offset: 0x0011B384
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsIBANNoNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.IBANNoColumn)
			End Function

			' Token: 0x06001FE4 RID: 8164 RVA: 0x0011D1A7 File Offset: 0x0011B3A7
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetIBANNoNull()
				MyBase(Me.tablePO.IBANNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FE5 RID: 8165 RVA: 0x0011D1C8 File Offset: 0x0011B3C8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsBankRoutingNoNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.BankRoutingNoColumn)
			End Function

			' Token: 0x06001FE6 RID: 8166 RVA: 0x0011D1EB File Offset: 0x0011B3EB
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetBankRoutingNoNull()
				MyBase(Me.tablePO.BankRoutingNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FE7 RID: 8167 RVA: 0x0011D20C File Offset: 0x0011B40C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsBankSortCodeNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.BankSortCodeColumn)
			End Function

			' Token: 0x06001FE8 RID: 8168 RVA: 0x0011D22F File Offset: 0x0011B42F
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetBankSortCodeNull()
				MyBase(Me.tablePO.BankSortCodeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FE9 RID: 8169 RVA: 0x0011D250 File Offset: 0x0011B450
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsSWIFTCodeNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.SWIFTCodeColumn)
			End Function

			' Token: 0x06001FEA RID: 8170 RVA: 0x0011D273 File Offset: 0x0011B473
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetSWIFTCodeNull()
				MyBase(Me.tablePO.SWIFTCodeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FEB RID: 8171 RVA: 0x0011D294 File Offset: 0x0011B494
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsModeOfPaymentNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.ModeOfPaymentColumn)
			End Function

			' Token: 0x06001FEC RID: 8172 RVA: 0x0011D2B7 File Offset: 0x0011B4B7
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetModeOfPaymentNull()
				MyBase(Me.tablePO.ModeOfPaymentColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FED RID: 8173 RVA: 0x0011D2D8 File Offset: 0x0011B4D8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsDispatchedThroughNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.DispatchedThroughColumn)
			End Function

			' Token: 0x06001FEE RID: 8174 RVA: 0x0011D2FB File Offset: 0x0011B4FB
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetDispatchedThroughNull()
				MyBase(Me.tablePO.DispatchedThroughColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FEF RID: 8175 RVA: 0x0011D31C File Offset: 0x0011B51C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsPaymentTermsNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.PaymentTermsColumn)
			End Function

			' Token: 0x06001FF0 RID: 8176 RVA: 0x0011D33F File Offset: 0x0011B53F
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetPaymentTermsNull()
				MyBase(Me.tablePO.PaymentTermsColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FF1 RID: 8177 RVA: 0x0011D360 File Offset: 0x0011B560
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsIncoTermsNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.IncoTermsColumn)
			End Function

			' Token: 0x06001FF2 RID: 8178 RVA: 0x0011D383 File Offset: 0x0011B583
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetIncoTermsNull()
				MyBase(Me.tablePO.IncoTermsColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FF3 RID: 8179 RVA: 0x0011D3A4 File Offset: 0x0011B5A4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsDeliveryTermsNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.DeliveryTermsColumn)
			End Function

			' Token: 0x06001FF4 RID: 8180 RVA: 0x0011D3C7 File Offset: 0x0011B5C7
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetDeliveryTermsNull()
				MyBase(Me.tablePO.DeliveryTermsColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FF5 RID: 8181 RVA: 0x0011D3E8 File Offset: 0x0011B5E8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsCurrencyNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.CurrencyColumn)
			End Function

			' Token: 0x06001FF6 RID: 8182 RVA: 0x0011D40B File Offset: 0x0011B60B
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetCurrencyNull()
				MyBase(Me.tablePO.CurrencyColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FF7 RID: 8183 RVA: 0x0011D42C File Offset: 0x0011B62C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsCommentsNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.CommentsColumn)
			End Function

			' Token: 0x06001FF8 RID: 8184 RVA: 0x0011D44F File Offset: 0x0011B64F
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetCommentsNull()
				MyBase(Me.tablePO.CommentsColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FF9 RID: 8185 RVA: 0x0011D470 File Offset: 0x0011B670
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsCreatedByNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.CreatedByColumn)
			End Function

			' Token: 0x06001FFA RID: 8186 RVA: 0x0011D493 File Offset: 0x0011B693
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetCreatedByNull()
				MyBase(Me.tablePO.CreatedByColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FFB RID: 8187 RVA: 0x0011D4B4 File Offset: 0x0011B6B4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsCreationDtNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.CreationDtColumn)
			End Function

			' Token: 0x06001FFC RID: 8188 RVA: 0x0011D4D7 File Offset: 0x0011B6D7
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetCreationDtNull()
				MyBase(Me.tablePO.CreationDtColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FFD RID: 8189 RVA: 0x0011D4F8 File Offset: 0x0011B6F8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsApprovedByNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.ApprovedByColumn)
			End Function

			' Token: 0x06001FFE RID: 8190 RVA: 0x0011D51B File Offset: 0x0011B71B
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetApprovedByNull()
				MyBase(Me.tablePO.ApprovedByColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06001FFF RID: 8191 RVA: 0x0011D53C File Offset: 0x0011B73C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsPrintedByNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.PrintedByColumn)
			End Function

			' Token: 0x06002000 RID: 8192 RVA: 0x0011D55F File Offset: 0x0011B75F
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetPrintedByNull()
				MyBase(Me.tablePO.PrintedByColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002001 RID: 8193 RVA: 0x0011D580 File Offset: 0x0011B780
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsSrNoNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.SrNoColumn)
			End Function

			' Token: 0x06002002 RID: 8194 RVA: 0x0011D5A3 File Offset: 0x0011B7A3
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetSrNoNull()
				MyBase(Me.tablePO.SrNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002003 RID: 8195 RVA: 0x0011D5C4 File Offset: 0x0011B7C4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsProductNameNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.ProductNameColumn)
			End Function

			' Token: 0x06002004 RID: 8196 RVA: 0x0011D5E7 File Offset: 0x0011B7E7
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetProductNameNull()
				MyBase(Me.tablePO.ProductNameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002005 RID: 8197 RVA: 0x0011D608 File Offset: 0x0011B808
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsDescriptionNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.DescriptionColumn)
			End Function

			' Token: 0x06002006 RID: 8198 RVA: 0x0011D62B File Offset: 0x0011B82B
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetDescriptionNull()
				MyBase(Me.tablePO.DescriptionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002007 RID: 8199 RVA: 0x0011D64C File Offset: 0x0011B84C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsCatalogNoNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.CatalogNoColumn)
			End Function

			' Token: 0x06002008 RID: 8200 RVA: 0x0011D66F File Offset: 0x0011B86F
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetCatalogNoNull()
				MyBase(Me.tablePO.CatalogNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002009 RID: 8201 RVA: 0x0011D690 File Offset: 0x0011B890
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsHSNSACCodeNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.HSNSACCodeColumn)
			End Function

			' Token: 0x0600200A RID: 8202 RVA: 0x0011D6B3 File Offset: 0x0011B8B3
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetHSNSACCodeNull()
				MyBase(Me.tablePO.HSNSACCodeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x0600200B RID: 8203 RVA: 0x0011D6D4 File Offset: 0x0011B8D4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsUOMNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.UOMColumn)
			End Function

			' Token: 0x0600200C RID: 8204 RVA: 0x0011D6F7 File Offset: 0x0011B8F7
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetUOMNull()
				MyBase(Me.tablePO.UOMColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x0600200D RID: 8205 RVA: 0x0011D718 File Offset: 0x0011B918
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsQuantityNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.QuantityColumn)
			End Function

			' Token: 0x0600200E RID: 8206 RVA: 0x0011D73B File Offset: 0x0011B93B
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetQuantityNull()
				MyBase(Me.tablePO.QuantityColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x0600200F RID: 8207 RVA: 0x0011D75C File Offset: 0x0011B95C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsUnitPriceNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.UnitPriceColumn)
			End Function

			' Token: 0x06002010 RID: 8208 RVA: 0x0011D77F File Offset: 0x0011B97F
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetUnitPriceNull()
				MyBase(Me.tablePO.UnitPriceColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002011 RID: 8209 RVA: 0x0011D7A0 File Offset: 0x0011B9A0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsBasicValueNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.BasicValueColumn)
			End Function

			' Token: 0x06002012 RID: 8210 RVA: 0x0011D7C3 File Offset: 0x0011B9C3
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetBasicValueNull()
				MyBase(Me.tablePO.BasicValueColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002013 RID: 8211 RVA: 0x0011D7E4 File Offset: 0x0011B9E4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsDiscountPerNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.DiscountPerColumn)
			End Function

			' Token: 0x06002014 RID: 8212 RVA: 0x0011D807 File Offset: 0x0011BA07
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetDiscountPerNull()
				MyBase(Me.tablePO.DiscountPerColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002015 RID: 8213 RVA: 0x0011D828 File Offset: 0x0011BA28
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsDiscountAmtNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.DiscountAmtColumn)
			End Function

			' Token: 0x06002016 RID: 8214 RVA: 0x0011D84B File Offset: 0x0011BA4B
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetDiscountAmtNull()
				MyBase(Me.tablePO.DiscountAmtColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002017 RID: 8215 RVA: 0x0011D86C File Offset: 0x0011BA6C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsNetAmtNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.NetAmtColumn)
			End Function

			' Token: 0x06002018 RID: 8216 RVA: 0x0011D88F File Offset: 0x0011BA8F
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetNetAmtNull()
				MyBase(Me.tablePO.NetAmtColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002019 RID: 8217 RVA: 0x0011D8B0 File Offset: 0x0011BAB0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsTaxPerNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.TaxPerColumn)
			End Function

			' Token: 0x0600201A RID: 8218 RVA: 0x0011D8D3 File Offset: 0x0011BAD3
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetTaxPerNull()
				MyBase(Me.tablePO.TaxPerColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x0600201B RID: 8219 RVA: 0x0011D8F4 File Offset: 0x0011BAF4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsTaxAmtNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.TaxAmtColumn)
			End Function

			' Token: 0x0600201C RID: 8220 RVA: 0x0011D917 File Offset: 0x0011BB17
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetTaxAmtNull()
				MyBase(Me.tablePO.TaxAmtColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x0600201D RID: 8221 RVA: 0x0011D938 File Offset: 0x0011BB38
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsTransportationNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.TransportationColumn)
			End Function

			' Token: 0x0600201E RID: 8222 RVA: 0x0011D95B File Offset: 0x0011BB5B
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetTransportationNull()
				MyBase(Me.tablePO.TransportationColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x0600201F RID: 8223 RVA: 0x0011D97C File Offset: 0x0011BB7C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsFreightNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.FreightColumn)
			End Function

			' Token: 0x06002020 RID: 8224 RVA: 0x0011D99F File Offset: 0x0011BB9F
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetFreightNull()
				MyBase(Me.tablePO.FreightColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002021 RID: 8225 RVA: 0x0011D9C0 File Offset: 0x0011BBC0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsLoadingUnloadingNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.LoadingUnloadingColumn)
			End Function

			' Token: 0x06002022 RID: 8226 RVA: 0x0011D9E3 File Offset: 0x0011BBE3
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetLoadingUnloadingNull()
				MyBase(Me.tablePO.LoadingUnloadingColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002023 RID: 8227 RVA: 0x0011DA04 File Offset: 0x0011BC04
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsPackingNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.PackingColumn)
			End Function

			' Token: 0x06002024 RID: 8228 RVA: 0x0011DA27 File Offset: 0x0011BC27
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetPackingNull()
				MyBase(Me.tablePO.PackingColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002025 RID: 8229 RVA: 0x0011DA48 File Offset: 0x0011BC48
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsOtherChargesNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.OtherChargesColumn)
			End Function

			' Token: 0x06002026 RID: 8230 RVA: 0x0011DA6B File Offset: 0x0011BC6B
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetOtherChargesNull()
				MyBase(Me.tablePO.OtherChargesColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002027 RID: 8231 RVA: 0x0011DA8C File Offset: 0x0011BC8C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsFinalAmtNull() As Boolean
				Return MyBase.IsNull(Me.tablePO.FinalAmtColumn)
			End Function

			' Token: 0x06002028 RID: 8232 RVA: 0x0011DAAF File Offset: 0x0011BCAF
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetFinalAmtNull()
				MyBase(Me.tablePO.FinalAmtColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x04000D9D RID: 3485
			Private tablePO As PIMSDataSet.PODataTable
		End Class

		' Token: 0x0200007E RID: 126
		Public Class TestRow
			Inherits DataRow

			' Token: 0x06002029 RID: 8233 RVA: 0x0011DACE File Offset: 0x0011BCCE
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.New(rb)
				Me.tableTest = CType(MyBase.Table, PIMSDataSet.TestDataTable)
			End Sub

			' Token: 0x17000C78 RID: 3192
			' (get) Token: 0x0600202A RID: 8234 RVA: 0x0011DAEC File Offset: 0x0011BCEC
			' (set) Token: 0x0600202B RID: 8235 RVA: 0x0011DB3C File Offset: 0x0011BD3C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property DataField As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableTest.DataFieldColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'DataField' in table 'Test' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableTest.DataFieldColumn) = value
				End Set
			End Property

			' Token: 0x0600202C RID: 8236 RVA: 0x0011DB54 File Offset: 0x0011BD54
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsDataFieldNull() As Boolean
				Return MyBase.IsNull(Me.tableTest.DataFieldColumn)
			End Function

			' Token: 0x0600202D RID: 8237 RVA: 0x0011DB77 File Offset: 0x0011BD77
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetDataFieldNull()
				MyBase(Me.tableTest.DataFieldColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x04000D9E RID: 3486
			Private tableTest As PIMSDataSet.TestDataTable
		End Class

		' Token: 0x0200007F RID: 127
		Public Class QCRow
			Inherits DataRow

			' Token: 0x0600202E RID: 8238 RVA: 0x0011DB96 File Offset: 0x0011BD96
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.New(rb)
				Me.tableQC = CType(MyBase.Table, PIMSDataSet.QCDataTable)
			End Sub

			' Token: 0x17000C79 RID: 3193
			' (get) Token: 0x0600202F RID: 8239 RVA: 0x0011DBB4 File Offset: 0x0011BDB4
			' (set) Token: 0x06002030 RID: 8240 RVA: 0x0011DC04 File Offset: 0x0011BE04
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property _RMNo_ As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableQC._RMNo_Column))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'RMNo.' in table 'QC' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableQC._RMNo_Column) = value
				End Set
			End Property

			' Token: 0x17000C7A RID: 3194
			' (get) Token: 0x06002031 RID: 8241 RVA: 0x0011DC1C File Offset: 0x0011BE1C
			' (set) Token: 0x06002032 RID: 8242 RVA: 0x0011DC6C File Offset: 0x0011BE6C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property FormatNo As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableQC.FormatNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'FormatNo' in table 'QC' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableQC.FormatNoColumn) = value
				End Set
			End Property

			' Token: 0x17000C7B RID: 3195
			' (get) Token: 0x06002033 RID: 8243 RVA: 0x0011DC84 File Offset: 0x0011BE84
			' (set) Token: 0x06002034 RID: 8244 RVA: 0x0011DCD4 File Offset: 0x0011BED4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property ReferenceSOPNo As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableQC.ReferenceSOPNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'ReferenceSOPNo' in table 'QC' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableQC.ReferenceSOPNoColumn) = value
				End Set
			End Property

			' Token: 0x17000C7C RID: 3196
			' (get) Token: 0x06002035 RID: 8245 RVA: 0x0011DCEC File Offset: 0x0011BEEC
			' (set) Token: 0x06002036 RID: 8246 RVA: 0x0011DD3C File Offset: 0x0011BF3C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property EffectiveDt As DateTime
				Get
					Dim dateTime As DateTime
					Try
						dateTime = Conversions.ToDate(MyBase(Me.tableQC.EffectiveDtColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'EffectiveDt' in table 'QC' is DBNull.", ex)
					End Try
					Return dateTime
				End Get
				Set(value As DateTime)
					MyBase(Me.tableQC.EffectiveDtColumn) = value
				End Set
			End Property

			' Token: 0x17000C7D RID: 3197
			' (get) Token: 0x06002037 RID: 8247 RVA: 0x0011DD58 File Offset: 0x0011BF58
			' (set) Token: 0x06002038 RID: 8248 RVA: 0x0011DDA8 File Offset: 0x0011BFA8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property ValidUpto As DateTime
				Get
					Dim dateTime As DateTime
					Try
						dateTime = Conversions.ToDate(MyBase(Me.tableQC.ValidUptoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'ValidUpto' in table 'QC' is DBNull.", ex)
					End Try
					Return dateTime
				End Get
				Set(value As DateTime)
					MyBase(Me.tableQC.ValidUptoColumn) = value
				End Set
			End Property

			' Token: 0x17000C7E RID: 3198
			' (get) Token: 0x06002039 RID: 8249 RVA: 0x0011DDC4 File Offset: 0x0011BFC4
			' (set) Token: 0x0600203A RID: 8250 RVA: 0x0011DE14 File Offset: 0x0011C014
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property MaterialName As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableQC.MaterialNameColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'MaterialName' in table 'QC' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableQC.MaterialNameColumn) = value
				End Set
			End Property

			' Token: 0x17000C7F RID: 3199
			' (get) Token: 0x0600203B RID: 8251 RVA: 0x0011DE2C File Offset: 0x0011C02C
			' (set) Token: 0x0600203C RID: 8252 RVA: 0x0011DE7C File Offset: 0x0011C07C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property SpecificationNo As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableQC.SpecificationNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'SpecificationNo' in table 'QC' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableQC.SpecificationNoColumn) = value
				End Set
			End Property

			' Token: 0x17000C80 RID: 3200
			' (get) Token: 0x0600203D RID: 8253 RVA: 0x0011DE94 File Offset: 0x0011C094
			' (set) Token: 0x0600203E RID: 8254 RVA: 0x0011DEE4 File Offset: 0x0011C0E4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property Reference As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableQC.ReferenceColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'Reference' in table 'QC' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableQC.ReferenceColumn) = value
				End Set
			End Property

			' Token: 0x17000C81 RID: 3201
			' (get) Token: 0x0600203F RID: 8255 RVA: 0x0011DEFC File Offset: 0x0011C0FC
			' (set) Token: 0x06002040 RID: 8256 RVA: 0x0011DF4C File Offset: 0x0011C14C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property VendorName As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableQC.VendorNameColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'VendorName' in table 'QC' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableQC.VendorNameColumn) = value
				End Set
			End Property

			' Token: 0x17000C82 RID: 3202
			' (get) Token: 0x06002041 RID: 8257 RVA: 0x0011DF64 File Offset: 0x0011C164
			' (set) Token: 0x06002042 RID: 8258 RVA: 0x0011DFB4 File Offset: 0x0011C1B4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property CatalogNo As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableQC.CatalogNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'CatalogNo' in table 'QC' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableQC.CatalogNoColumn) = value
				End Set
			End Property

			' Token: 0x17000C83 RID: 3203
			' (get) Token: 0x06002043 RID: 8259 RVA: 0x0011DFCC File Offset: 0x0011C1CC
			' (set) Token: 0x06002044 RID: 8260 RVA: 0x0011E01C File Offset: 0x0011C21C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property BatchNo As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableQC.BatchNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'BatchNo' in table 'QC' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableQC.BatchNoColumn) = value
				End Set
			End Property

			' Token: 0x17000C84 RID: 3204
			' (get) Token: 0x06002045 RID: 8261 RVA: 0x0011E034 File Offset: 0x0011C234
			' (set) Token: 0x06002046 RID: 8262 RVA: 0x0011E084 File Offset: 0x0011C284
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property SrNo As Integer
				Get
					Dim num As Integer
					Try
						num = Conversions.ToInteger(MyBase(Me.tableQC.SrNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'SrNo' in table 'QC' is DBNull.", ex)
					End Try
					Return num
				End Get
				Set(value As Integer)
					MyBase(Me.tableQC.SrNoColumn) = value
				End Set
			End Property

			' Token: 0x17000C85 RID: 3205
			' (get) Token: 0x06002047 RID: 8263 RVA: 0x0011E0A0 File Offset: 0x0011C2A0
			' (set) Token: 0x06002048 RID: 8264 RVA: 0x0011E0F0 File Offset: 0x0011C2F0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property Specification As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableQC.SpecificationColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'Specification' in table 'QC' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableQC.SpecificationColumn) = value
				End Set
			End Property

			' Token: 0x17000C86 RID: 3206
			' (get) Token: 0x06002049 RID: 8265 RVA: 0x0011E108 File Offset: 0x0011C308
			' (set) Token: 0x0600204A RID: 8266 RVA: 0x0011E158 File Offset: 0x0011C358
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property AcceptanceCriteria As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableQC.AcceptanceCriteriaColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'AcceptanceCriteria' in table 'QC' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableQC.AcceptanceCriteriaColumn) = value
				End Set
			End Property

			' Token: 0x17000C87 RID: 3207
			' (get) Token: 0x0600204B RID: 8267 RVA: 0x0011E170 File Offset: 0x0011C370
			' (set) Token: 0x0600204C RID: 8268 RVA: 0x0011E1C0 File Offset: 0x0011C3C0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property Complies As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableQC.CompliesColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'Complies' in table 'QC' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableQC.CompliesColumn) = value
				End Set
			End Property

			' Token: 0x17000C88 RID: 3208
			' (get) Token: 0x0600204D RID: 8269 RVA: 0x0011E1D8 File Offset: 0x0011C3D8
			' (set) Token: 0x0600204E RID: 8270 RVA: 0x0011E228 File Offset: 0x0011C428
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property Remarks As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableQC.RemarksColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'Remarks' in table 'QC' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableQC.RemarksColumn) = value
				End Set
			End Property

			' Token: 0x17000C89 RID: 3209
			' (get) Token: 0x0600204F RID: 8271 RVA: 0x0011E240 File Offset: 0x0011C440
			' (set) Token: 0x06002050 RID: 8272 RVA: 0x0011E290 File Offset: 0x0011C490
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property QCEntryBy As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableQC.QCEntryByColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'QCEntryBy' in table 'QC' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableQC.QCEntryByColumn) = value
				End Set
			End Property

			' Token: 0x17000C8A RID: 3210
			' (get) Token: 0x06002051 RID: 8273 RVA: 0x0011E2A8 File Offset: 0x0011C4A8
			' (set) Token: 0x06002052 RID: 8274 RVA: 0x0011E2F8 File Offset: 0x0011C4F8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property QCEntryDesignation As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableQC.QCEntryDesignationColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'QCEntryDesignation' in table 'QC' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableQC.QCEntryDesignationColumn) = value
				End Set
			End Property

			' Token: 0x17000C8B RID: 3211
			' (get) Token: 0x06002053 RID: 8275 RVA: 0x0011E310 File Offset: 0x0011C510
			' (set) Token: 0x06002054 RID: 8276 RVA: 0x0011E360 File Offset: 0x0011C560
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property QCEntryDt As DateTime
				Get
					Dim dateTime As DateTime
					Try
						dateTime = Conversions.ToDate(MyBase(Me.tableQC.QCEntryDtColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'QCEntryDt' in table 'QC' is DBNull.", ex)
					End Try
					Return dateTime
				End Get
				Set(value As DateTime)
					MyBase(Me.tableQC.QCEntryDtColumn) = value
				End Set
			End Property

			' Token: 0x17000C8C RID: 3212
			' (get) Token: 0x06002055 RID: 8277 RVA: 0x0011E37C File Offset: 0x0011C57C
			' (set) Token: 0x06002056 RID: 8278 RVA: 0x0011E3CC File Offset: 0x0011C5CC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property QCActionBy As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableQC.QCActionByColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'QCActionBy' in table 'QC' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableQC.QCActionByColumn) = value
				End Set
			End Property

			' Token: 0x17000C8D RID: 3213
			' (get) Token: 0x06002057 RID: 8279 RVA: 0x0011E3E4 File Offset: 0x0011C5E4
			' (set) Token: 0x06002058 RID: 8280 RVA: 0x0011E434 File Offset: 0x0011C634
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property QCActionDesignation As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableQC.QCActionDesignationColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'QCActionDesignation' in table 'QC' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableQC.QCActionDesignationColumn) = value
				End Set
			End Property

			' Token: 0x17000C8E RID: 3214
			' (get) Token: 0x06002059 RID: 8281 RVA: 0x0011E44C File Offset: 0x0011C64C
			' (set) Token: 0x0600205A RID: 8282 RVA: 0x0011E49C File Offset: 0x0011C69C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property QCActionDt As DateTime
				Get
					Dim dateTime As DateTime
					Try
						dateTime = Conversions.ToDate(MyBase(Me.tableQC.QCActionDtColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'QCActionDt' in table 'QC' is DBNull.", ex)
					End Try
					Return dateTime
				End Get
				Set(value As DateTime)
					MyBase(Me.tableQC.QCActionDtColumn) = value
				End Set
			End Property

			' Token: 0x0600205B RID: 8283 RVA: 0x0011E4B8 File Offset: 0x0011C6B8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function Is_RMNo_Null() As Boolean
				Return MyBase.IsNull(Me.tableQC._RMNo_Column)
			End Function

			' Token: 0x0600205C RID: 8284 RVA: 0x0011E4DB File Offset: 0x0011C6DB
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub Set_RMNo_Null()
				MyBase(Me.tableQC._RMNo_Column) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x0600205D RID: 8285 RVA: 0x0011E4FC File Offset: 0x0011C6FC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsFormatNoNull() As Boolean
				Return MyBase.IsNull(Me.tableQC.FormatNoColumn)
			End Function

			' Token: 0x0600205E RID: 8286 RVA: 0x0011E51F File Offset: 0x0011C71F
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetFormatNoNull()
				MyBase(Me.tableQC.FormatNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x0600205F RID: 8287 RVA: 0x0011E540 File Offset: 0x0011C740
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsReferenceSOPNoNull() As Boolean
				Return MyBase.IsNull(Me.tableQC.ReferenceSOPNoColumn)
			End Function

			' Token: 0x06002060 RID: 8288 RVA: 0x0011E563 File Offset: 0x0011C763
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetReferenceSOPNoNull()
				MyBase(Me.tableQC.ReferenceSOPNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002061 RID: 8289 RVA: 0x0011E584 File Offset: 0x0011C784
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsEffectiveDtNull() As Boolean
				Return MyBase.IsNull(Me.tableQC.EffectiveDtColumn)
			End Function

			' Token: 0x06002062 RID: 8290 RVA: 0x0011E5A7 File Offset: 0x0011C7A7
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetEffectiveDtNull()
				MyBase(Me.tableQC.EffectiveDtColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002063 RID: 8291 RVA: 0x0011E5C8 File Offset: 0x0011C7C8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsValidUptoNull() As Boolean
				Return MyBase.IsNull(Me.tableQC.ValidUptoColumn)
			End Function

			' Token: 0x06002064 RID: 8292 RVA: 0x0011E5EB File Offset: 0x0011C7EB
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetValidUptoNull()
				MyBase(Me.tableQC.ValidUptoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002065 RID: 8293 RVA: 0x0011E60C File Offset: 0x0011C80C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsMaterialNameNull() As Boolean
				Return MyBase.IsNull(Me.tableQC.MaterialNameColumn)
			End Function

			' Token: 0x06002066 RID: 8294 RVA: 0x0011E62F File Offset: 0x0011C82F
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetMaterialNameNull()
				MyBase(Me.tableQC.MaterialNameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002067 RID: 8295 RVA: 0x0011E650 File Offset: 0x0011C850
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsSpecificationNoNull() As Boolean
				Return MyBase.IsNull(Me.tableQC.SpecificationNoColumn)
			End Function

			' Token: 0x06002068 RID: 8296 RVA: 0x0011E673 File Offset: 0x0011C873
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetSpecificationNoNull()
				MyBase(Me.tableQC.SpecificationNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002069 RID: 8297 RVA: 0x0011E694 File Offset: 0x0011C894
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsReferenceNull() As Boolean
				Return MyBase.IsNull(Me.tableQC.ReferenceColumn)
			End Function

			' Token: 0x0600206A RID: 8298 RVA: 0x0011E6B7 File Offset: 0x0011C8B7
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetReferenceNull()
				MyBase(Me.tableQC.ReferenceColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x0600206B RID: 8299 RVA: 0x0011E6D8 File Offset: 0x0011C8D8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsVendorNameNull() As Boolean
				Return MyBase.IsNull(Me.tableQC.VendorNameColumn)
			End Function

			' Token: 0x0600206C RID: 8300 RVA: 0x0011E6FB File Offset: 0x0011C8FB
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetVendorNameNull()
				MyBase(Me.tableQC.VendorNameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x0600206D RID: 8301 RVA: 0x0011E71C File Offset: 0x0011C91C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsCatalogNoNull() As Boolean
				Return MyBase.IsNull(Me.tableQC.CatalogNoColumn)
			End Function

			' Token: 0x0600206E RID: 8302 RVA: 0x0011E73F File Offset: 0x0011C93F
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetCatalogNoNull()
				MyBase(Me.tableQC.CatalogNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x0600206F RID: 8303 RVA: 0x0011E760 File Offset: 0x0011C960
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsBatchNoNull() As Boolean
				Return MyBase.IsNull(Me.tableQC.BatchNoColumn)
			End Function

			' Token: 0x06002070 RID: 8304 RVA: 0x0011E783 File Offset: 0x0011C983
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetBatchNoNull()
				MyBase(Me.tableQC.BatchNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002071 RID: 8305 RVA: 0x0011E7A4 File Offset: 0x0011C9A4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsSrNoNull() As Boolean
				Return MyBase.IsNull(Me.tableQC.SrNoColumn)
			End Function

			' Token: 0x06002072 RID: 8306 RVA: 0x0011E7C7 File Offset: 0x0011C9C7
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetSrNoNull()
				MyBase(Me.tableQC.SrNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002073 RID: 8307 RVA: 0x0011E7E8 File Offset: 0x0011C9E8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsSpecificationNull() As Boolean
				Return MyBase.IsNull(Me.tableQC.SpecificationColumn)
			End Function

			' Token: 0x06002074 RID: 8308 RVA: 0x0011E80B File Offset: 0x0011CA0B
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetSpecificationNull()
				MyBase(Me.tableQC.SpecificationColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002075 RID: 8309 RVA: 0x0011E82C File Offset: 0x0011CA2C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsAcceptanceCriteriaNull() As Boolean
				Return MyBase.IsNull(Me.tableQC.AcceptanceCriteriaColumn)
			End Function

			' Token: 0x06002076 RID: 8310 RVA: 0x0011E84F File Offset: 0x0011CA4F
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetAcceptanceCriteriaNull()
				MyBase(Me.tableQC.AcceptanceCriteriaColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002077 RID: 8311 RVA: 0x0011E870 File Offset: 0x0011CA70
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsCompliesNull() As Boolean
				Return MyBase.IsNull(Me.tableQC.CompliesColumn)
			End Function

			' Token: 0x06002078 RID: 8312 RVA: 0x0011E893 File Offset: 0x0011CA93
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetCompliesNull()
				MyBase(Me.tableQC.CompliesColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002079 RID: 8313 RVA: 0x0011E8B4 File Offset: 0x0011CAB4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsRemarksNull() As Boolean
				Return MyBase.IsNull(Me.tableQC.RemarksColumn)
			End Function

			' Token: 0x0600207A RID: 8314 RVA: 0x0011E8D7 File Offset: 0x0011CAD7
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetRemarksNull()
				MyBase(Me.tableQC.RemarksColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x0600207B RID: 8315 RVA: 0x0011E8F8 File Offset: 0x0011CAF8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsQCEntryByNull() As Boolean
				Return MyBase.IsNull(Me.tableQC.QCEntryByColumn)
			End Function

			' Token: 0x0600207C RID: 8316 RVA: 0x0011E91B File Offset: 0x0011CB1B
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetQCEntryByNull()
				MyBase(Me.tableQC.QCEntryByColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x0600207D RID: 8317 RVA: 0x0011E93C File Offset: 0x0011CB3C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsQCEntryDesignationNull() As Boolean
				Return MyBase.IsNull(Me.tableQC.QCEntryDesignationColumn)
			End Function

			' Token: 0x0600207E RID: 8318 RVA: 0x0011E95F File Offset: 0x0011CB5F
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetQCEntryDesignationNull()
				MyBase(Me.tableQC.QCEntryDesignationColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x0600207F RID: 8319 RVA: 0x0011E980 File Offset: 0x0011CB80
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsQCEntryDtNull() As Boolean
				Return MyBase.IsNull(Me.tableQC.QCEntryDtColumn)
			End Function

			' Token: 0x06002080 RID: 8320 RVA: 0x0011E9A3 File Offset: 0x0011CBA3
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetQCEntryDtNull()
				MyBase(Me.tableQC.QCEntryDtColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002081 RID: 8321 RVA: 0x0011E9C4 File Offset: 0x0011CBC4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsQCActionByNull() As Boolean
				Return MyBase.IsNull(Me.tableQC.QCActionByColumn)
			End Function

			' Token: 0x06002082 RID: 8322 RVA: 0x0011E9E7 File Offset: 0x0011CBE7
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetQCActionByNull()
				MyBase(Me.tableQC.QCActionByColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002083 RID: 8323 RVA: 0x0011EA08 File Offset: 0x0011CC08
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsQCActionDesignationNull() As Boolean
				Return MyBase.IsNull(Me.tableQC.QCActionDesignationColumn)
			End Function

			' Token: 0x06002084 RID: 8324 RVA: 0x0011EA2B File Offset: 0x0011CC2B
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetQCActionDesignationNull()
				MyBase(Me.tableQC.QCActionDesignationColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002085 RID: 8325 RVA: 0x0011EA4C File Offset: 0x0011CC4C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsQCActionDtNull() As Boolean
				Return MyBase.IsNull(Me.tableQC.QCActionDtColumn)
			End Function

			' Token: 0x06002086 RID: 8326 RVA: 0x0011EA6F File Offset: 0x0011CC6F
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetQCActionDtNull()
				MyBase(Me.tableQC.QCActionDtColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x04000D9F RID: 3487
			Private tableQC As PIMSDataSet.QCDataTable
		End Class

		' Token: 0x02000080 RID: 128
		Public Class IssueRow
			Inherits DataRow

			' Token: 0x06002087 RID: 8327 RVA: 0x0011EA8E File Offset: 0x0011CC8E
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.New(rb)
				Me.tableIssue = CType(MyBase.Table, PIMSDataSet.IssueDataTable)
			End Sub

			' Token: 0x17000C8F RID: 3215
			' (get) Token: 0x06002088 RID: 8328 RVA: 0x0011EAAC File Offset: 0x0011CCAC
			' (set) Token: 0x06002089 RID: 8329 RVA: 0x0011EAFC File Offset: 0x0011CCFC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property FormatNo As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableIssue.FormatNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'FormatNo' in table 'Issue' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableIssue.FormatNoColumn) = value
				End Set
			End Property

			' Token: 0x17000C90 RID: 3216
			' (get) Token: 0x0600208A RID: 8330 RVA: 0x0011EB14 File Offset: 0x0011CD14
			' (set) Token: 0x0600208B RID: 8331 RVA: 0x0011EB64 File Offset: 0x0011CD64
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property ReferenceSOPNo As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableIssue.ReferenceSOPNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'ReferenceSOPNo' in table 'Issue' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableIssue.ReferenceSOPNoColumn) = value
				End Set
			End Property

			' Token: 0x17000C91 RID: 3217
			' (get) Token: 0x0600208C RID: 8332 RVA: 0x0011EB7C File Offset: 0x0011CD7C
			' (set) Token: 0x0600208D RID: 8333 RVA: 0x0011EBCC File Offset: 0x0011CDCC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property ProductName As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableIssue.ProductNameColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'ProductName' in table 'Issue' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableIssue.ProductNameColumn) = value
				End Set
			End Property

			' Token: 0x17000C92 RID: 3218
			' (get) Token: 0x0600208E RID: 8334 RVA: 0x0011EBE4 File Offset: 0x0011CDE4
			' (set) Token: 0x0600208F RID: 8335 RVA: 0x0011EC34 File Offset: 0x0011CE34
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property BOMVersion As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableIssue.BOMVersionColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'BOMVersion' in table 'Issue' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableIssue.BOMVersionColumn) = value
				End Set
			End Property

			' Token: 0x17000C93 RID: 3219
			' (get) Token: 0x06002090 RID: 8336 RVA: 0x0011EC4C File Offset: 0x0011CE4C
			' (set) Token: 0x06002091 RID: 8337 RVA: 0x0011EC9C File Offset: 0x0011CE9C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property BatchNo As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableIssue.BatchNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'BatchNo' in table 'Issue' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableIssue.BatchNoColumn) = value
				End Set
			End Property

			' Token: 0x17000C94 RID: 3220
			' (get) Token: 0x06002092 RID: 8338 RVA: 0x0011ECB4 File Offset: 0x0011CEB4
			' (set) Token: 0x06002093 RID: 8339 RVA: 0x0011ED04 File Offset: 0x0011CF04
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property RequestedBy As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableIssue.RequestedByColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'RequestedBy' in table 'Issue' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableIssue.RequestedByColumn) = value
				End Set
			End Property

			' Token: 0x17000C95 RID: 3221
			' (get) Token: 0x06002094 RID: 8340 RVA: 0x0011ED1C File Offset: 0x0011CF1C
			' (set) Token: 0x06002095 RID: 8341 RVA: 0x0011ED6C File Offset: 0x0011CF6C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property RequestDt As DateTime
				Get
					Dim dateTime As DateTime
					Try
						dateTime = Conversions.ToDate(MyBase(Me.tableIssue.RequestDtColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'RequestDt' in table 'Issue' is DBNull.", ex)
					End Try
					Return dateTime
				End Get
				Set(value As DateTime)
					MyBase(Me.tableIssue.RequestDtColumn) = value
				End Set
			End Property

			' Token: 0x17000C96 RID: 3222
			' (get) Token: 0x06002096 RID: 8342 RVA: 0x0011ED88 File Offset: 0x0011CF88
			' (set) Token: 0x06002097 RID: 8343 RVA: 0x0011EDD8 File Offset: 0x0011CFD8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property IssuedDt As DateTime
				Get
					Dim dateTime As DateTime
					Try
						dateTime = Conversions.ToDate(MyBase(Me.tableIssue.IssuedDtColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'IssuedDt' in table 'Issue' is DBNull.", ex)
					End Try
					Return dateTime
				End Get
				Set(value As DateTime)
					MyBase(Me.tableIssue.IssuedDtColumn) = value
				End Set
			End Property

			' Token: 0x17000C97 RID: 3223
			' (get) Token: 0x06002098 RID: 8344 RVA: 0x0011EDF4 File Offset: 0x0011CFF4
			' (set) Token: 0x06002099 RID: 8345 RVA: 0x0011EE44 File Offset: 0x0011D044
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property SrNo As Integer
				Get
					Dim num As Integer
					Try
						num = Conversions.ToInteger(MyBase(Me.tableIssue.SrNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'SrNo' in table 'Issue' is DBNull.", ex)
					End Try
					Return num
				End Get
				Set(value As Integer)
					MyBase(Me.tableIssue.SrNoColumn) = value
				End Set
			End Property

			' Token: 0x17000C98 RID: 3224
			' (get) Token: 0x0600209A RID: 8346 RVA: 0x0011EE60 File Offset: 0x0011D060
			' (set) Token: 0x0600209B RID: 8347 RVA: 0x0011EEB0 File Offset: 0x0011D0B0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property MaterialName As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableIssue.MaterialNameColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'MaterialName' in table 'Issue' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableIssue.MaterialNameColumn) = value
				End Set
			End Property

			' Token: 0x17000C99 RID: 3225
			' (get) Token: 0x0600209C RID: 8348 RVA: 0x0011EEC8 File Offset: 0x0011D0C8
			' (set) Token: 0x0600209D RID: 8349 RVA: 0x0011EF18 File Offset: 0x0011D118
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property CatalogNo As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableIssue.CatalogNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'CatalogNo' in table 'Issue' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableIssue.CatalogNoColumn) = value
				End Set
			End Property

			' Token: 0x17000C9A RID: 3226
			' (get) Token: 0x0600209E RID: 8350 RVA: 0x0011EF30 File Offset: 0x0011D130
			' (set) Token: 0x0600209F RID: 8351 RVA: 0x0011EF80 File Offset: 0x0011D180
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property UOM As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableIssue.UOMColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'UOM' in table 'Issue' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableIssue.UOMColumn) = value
				End Set
			End Property

			' Token: 0x17000C9B RID: 3227
			' (get) Token: 0x060020A0 RID: 8352 RVA: 0x0011EF98 File Offset: 0x0011D198
			' (set) Token: 0x060020A1 RID: 8353 RVA: 0x0011EFE8 File Offset: 0x0011D1E8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property RequiredQty As Integer
				Get
					Dim num As Integer
					Try
						num = Conversions.ToInteger(MyBase(Me.tableIssue.RequiredQtyColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'RequiredQty' in table 'Issue' is DBNull.", ex)
					End Try
					Return num
				End Get
				Set(value As Integer)
					MyBase(Me.tableIssue.RequiredQtyColumn) = value
				End Set
			End Property

			' Token: 0x17000C9C RID: 3228
			' (get) Token: 0x060020A2 RID: 8354 RVA: 0x0011F004 File Offset: 0x0011D204
			' (set) Token: 0x060020A3 RID: 8355 RVA: 0x0011F054 File Offset: 0x0011D254
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property LotNo As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableIssue.LotNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'LotNo' in table 'Issue' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableIssue.LotNoColumn) = value
				End Set
			End Property

			' Token: 0x17000C9D RID: 3229
			' (get) Token: 0x060020A4 RID: 8356 RVA: 0x0011F06C File Offset: 0x0011D26C
			' (set) Token: 0x060020A5 RID: 8357 RVA: 0x0011F0BC File Offset: 0x0011D2BC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property ExpiryDt As DateTime
				Get
					Dim dateTime As DateTime
					Try
						dateTime = Conversions.ToDate(MyBase(Me.tableIssue.ExpiryDtColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'ExpiryDt' in table 'Issue' is DBNull.", ex)
					End Try
					Return dateTime
				End Get
				Set(value As DateTime)
					MyBase(Me.tableIssue.ExpiryDtColumn) = value
				End Set
			End Property

			' Token: 0x17000C9E RID: 3230
			' (get) Token: 0x060020A6 RID: 8358 RVA: 0x0011F0D8 File Offset: 0x0011D2D8
			' (set) Token: 0x060020A7 RID: 8359 RVA: 0x0011F128 File Offset: 0x0011D328
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property IssuedQty As Integer
				Get
					Dim num As Integer
					Try
						num = Conversions.ToInteger(MyBase(Me.tableIssue.IssuedQtyColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'IssuedQty' in table 'Issue' is DBNull.", ex)
					End Try
					Return num
				End Get
				Set(value As Integer)
					MyBase(Me.tableIssue.IssuedQtyColumn) = value
				End Set
			End Property

			' Token: 0x17000C9F RID: 3231
			' (get) Token: 0x060020A8 RID: 8360 RVA: 0x0011F144 File Offset: 0x0011D344
			' (set) Token: 0x060020A9 RID: 8361 RVA: 0x0011F194 File Offset: 0x0011D394
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property IssuedBy As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableIssue.IssuedByColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'IssuedBy' in table 'Issue' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableIssue.IssuedByColumn) = value
				End Set
			End Property

			' Token: 0x17000CA0 RID: 3232
			' (get) Token: 0x060020AA RID: 8362 RVA: 0x0011F1AC File Offset: 0x0011D3AC
			' (set) Token: 0x060020AB RID: 8363 RVA: 0x0011F1FC File Offset: 0x0011D3FC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property VerifiedBy As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableIssue.VerifiedByColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'VerifiedBy' in table 'Issue' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableIssue.VerifiedByColumn) = value
				End Set
			End Property

			' Token: 0x060020AC RID: 8364 RVA: 0x0011F214 File Offset: 0x0011D414
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsFormatNoNull() As Boolean
				Return MyBase.IsNull(Me.tableIssue.FormatNoColumn)
			End Function

			' Token: 0x060020AD RID: 8365 RVA: 0x0011F237 File Offset: 0x0011D437
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetFormatNoNull()
				MyBase(Me.tableIssue.FormatNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x060020AE RID: 8366 RVA: 0x0011F258 File Offset: 0x0011D458
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsReferenceSOPNoNull() As Boolean
				Return MyBase.IsNull(Me.tableIssue.ReferenceSOPNoColumn)
			End Function

			' Token: 0x060020AF RID: 8367 RVA: 0x0011F27B File Offset: 0x0011D47B
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetReferenceSOPNoNull()
				MyBase(Me.tableIssue.ReferenceSOPNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x060020B0 RID: 8368 RVA: 0x0011F29C File Offset: 0x0011D49C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsProductNameNull() As Boolean
				Return MyBase.IsNull(Me.tableIssue.ProductNameColumn)
			End Function

			' Token: 0x060020B1 RID: 8369 RVA: 0x0011F2BF File Offset: 0x0011D4BF
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetProductNameNull()
				MyBase(Me.tableIssue.ProductNameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x060020B2 RID: 8370 RVA: 0x0011F2E0 File Offset: 0x0011D4E0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsBOMVersionNull() As Boolean
				Return MyBase.IsNull(Me.tableIssue.BOMVersionColumn)
			End Function

			' Token: 0x060020B3 RID: 8371 RVA: 0x0011F303 File Offset: 0x0011D503
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetBOMVersionNull()
				MyBase(Me.tableIssue.BOMVersionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x060020B4 RID: 8372 RVA: 0x0011F324 File Offset: 0x0011D524
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsBatchNoNull() As Boolean
				Return MyBase.IsNull(Me.tableIssue.BatchNoColumn)
			End Function

			' Token: 0x060020B5 RID: 8373 RVA: 0x0011F347 File Offset: 0x0011D547
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetBatchNoNull()
				MyBase(Me.tableIssue.BatchNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x060020B6 RID: 8374 RVA: 0x0011F368 File Offset: 0x0011D568
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsRequestedByNull() As Boolean
				Return MyBase.IsNull(Me.tableIssue.RequestedByColumn)
			End Function

			' Token: 0x060020B7 RID: 8375 RVA: 0x0011F38B File Offset: 0x0011D58B
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetRequestedByNull()
				MyBase(Me.tableIssue.RequestedByColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x060020B8 RID: 8376 RVA: 0x0011F3AC File Offset: 0x0011D5AC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsRequestDtNull() As Boolean
				Return MyBase.IsNull(Me.tableIssue.RequestDtColumn)
			End Function

			' Token: 0x060020B9 RID: 8377 RVA: 0x0011F3CF File Offset: 0x0011D5CF
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetRequestDtNull()
				MyBase(Me.tableIssue.RequestDtColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x060020BA RID: 8378 RVA: 0x0011F3F0 File Offset: 0x0011D5F0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsIssuedDtNull() As Boolean
				Return MyBase.IsNull(Me.tableIssue.IssuedDtColumn)
			End Function

			' Token: 0x060020BB RID: 8379 RVA: 0x0011F413 File Offset: 0x0011D613
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetIssuedDtNull()
				MyBase(Me.tableIssue.IssuedDtColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x060020BC RID: 8380 RVA: 0x0011F434 File Offset: 0x0011D634
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsSrNoNull() As Boolean
				Return MyBase.IsNull(Me.tableIssue.SrNoColumn)
			End Function

			' Token: 0x060020BD RID: 8381 RVA: 0x0011F457 File Offset: 0x0011D657
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetSrNoNull()
				MyBase(Me.tableIssue.SrNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x060020BE RID: 8382 RVA: 0x0011F478 File Offset: 0x0011D678
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsMaterialNameNull() As Boolean
				Return MyBase.IsNull(Me.tableIssue.MaterialNameColumn)
			End Function

			' Token: 0x060020BF RID: 8383 RVA: 0x0011F49B File Offset: 0x0011D69B
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetMaterialNameNull()
				MyBase(Me.tableIssue.MaterialNameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x060020C0 RID: 8384 RVA: 0x0011F4BC File Offset: 0x0011D6BC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsCatalogNoNull() As Boolean
				Return MyBase.IsNull(Me.tableIssue.CatalogNoColumn)
			End Function

			' Token: 0x060020C1 RID: 8385 RVA: 0x0011F4DF File Offset: 0x0011D6DF
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetCatalogNoNull()
				MyBase(Me.tableIssue.CatalogNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x060020C2 RID: 8386 RVA: 0x0011F500 File Offset: 0x0011D700
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsUOMNull() As Boolean
				Return MyBase.IsNull(Me.tableIssue.UOMColumn)
			End Function

			' Token: 0x060020C3 RID: 8387 RVA: 0x0011F523 File Offset: 0x0011D723
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetUOMNull()
				MyBase(Me.tableIssue.UOMColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x060020C4 RID: 8388 RVA: 0x0011F544 File Offset: 0x0011D744
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsRequiredQtyNull() As Boolean
				Return MyBase.IsNull(Me.tableIssue.RequiredQtyColumn)
			End Function

			' Token: 0x060020C5 RID: 8389 RVA: 0x0011F567 File Offset: 0x0011D767
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetRequiredQtyNull()
				MyBase(Me.tableIssue.RequiredQtyColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x060020C6 RID: 8390 RVA: 0x0011F588 File Offset: 0x0011D788
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsLotNoNull() As Boolean
				Return MyBase.IsNull(Me.tableIssue.LotNoColumn)
			End Function

			' Token: 0x060020C7 RID: 8391 RVA: 0x0011F5AB File Offset: 0x0011D7AB
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetLotNoNull()
				MyBase(Me.tableIssue.LotNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x060020C8 RID: 8392 RVA: 0x0011F5CC File Offset: 0x0011D7CC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsExpiryDtNull() As Boolean
				Return MyBase.IsNull(Me.tableIssue.ExpiryDtColumn)
			End Function

			' Token: 0x060020C9 RID: 8393 RVA: 0x0011F5EF File Offset: 0x0011D7EF
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetExpiryDtNull()
				MyBase(Me.tableIssue.ExpiryDtColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x060020CA RID: 8394 RVA: 0x0011F610 File Offset: 0x0011D810
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsIssuedQtyNull() As Boolean
				Return MyBase.IsNull(Me.tableIssue.IssuedQtyColumn)
			End Function

			' Token: 0x060020CB RID: 8395 RVA: 0x0011F633 File Offset: 0x0011D833
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetIssuedQtyNull()
				MyBase(Me.tableIssue.IssuedQtyColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x060020CC RID: 8396 RVA: 0x0011F654 File Offset: 0x0011D854
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsIssuedByNull() As Boolean
				Return MyBase.IsNull(Me.tableIssue.IssuedByColumn)
			End Function

			' Token: 0x060020CD RID: 8397 RVA: 0x0011F677 File Offset: 0x0011D877
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetIssuedByNull()
				MyBase(Me.tableIssue.IssuedByColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x060020CE RID: 8398 RVA: 0x0011F698 File Offset: 0x0011D898
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsVerifiedByNull() As Boolean
				Return MyBase.IsNull(Me.tableIssue.VerifiedByColumn)
			End Function

			' Token: 0x060020CF RID: 8399 RVA: 0x0011F6BB File Offset: 0x0011D8BB
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetVerifiedByNull()
				MyBase(Me.tableIssue.VerifiedByColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x04000DA0 RID: 3488
			Private tableIssue As PIMSDataSet.IssueDataTable
		End Class

		' Token: 0x02000081 RID: 129
		Public Class ConsumptionRow
			Inherits DataRow

			' Token: 0x060020D0 RID: 8400 RVA: 0x0011F6DA File Offset: 0x0011D8DA
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.New(rb)
				Me.tableConsumption = CType(MyBase.Table, PIMSDataSet.ConsumptionDataTable)
			End Sub

			' Token: 0x17000CA1 RID: 3233
			' (get) Token: 0x060020D1 RID: 8401 RVA: 0x0011F6F8 File Offset: 0x0011D8F8
			' (set) Token: 0x060020D2 RID: 8402 RVA: 0x0011F748 File Offset: 0x0011D948
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property Department As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableConsumption.DepartmentColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'Department' in table 'Consumption' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableConsumption.DepartmentColumn) = value
				End Set
			End Property

			' Token: 0x17000CA2 RID: 3234
			' (get) Token: 0x060020D3 RID: 8403 RVA: 0x0011F760 File Offset: 0x0011D960
			' (set) Token: 0x060020D4 RID: 8404 RVA: 0x0011F7B0 File Offset: 0x0011D9B0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property StartDt As DateTime
				Get
					Dim dateTime As DateTime
					Try
						dateTime = Conversions.ToDate(MyBase(Me.tableConsumption.StartDtColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'StartDt' in table 'Consumption' is DBNull.", ex)
					End Try
					Return dateTime
				End Get
				Set(value As DateTime)
					MyBase(Me.tableConsumption.StartDtColumn) = value
				End Set
			End Property

			' Token: 0x17000CA3 RID: 3235
			' (get) Token: 0x060020D5 RID: 8405 RVA: 0x0011F7CC File Offset: 0x0011D9CC
			' (set) Token: 0x060020D6 RID: 8406 RVA: 0x0011F81C File Offset: 0x0011DA1C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property EndDt As DateTime
				Get
					Dim dateTime As DateTime
					Try
						dateTime = Conversions.ToDate(MyBase(Me.tableConsumption.EndDtColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'EndDt' in table 'Consumption' is DBNull.", ex)
					End Try
					Return dateTime
				End Get
				Set(value As DateTime)
					MyBase(Me.tableConsumption.EndDtColumn) = value
				End Set
			End Property

			' Token: 0x17000CA4 RID: 3236
			' (get) Token: 0x060020D7 RID: 8407 RVA: 0x0011F838 File Offset: 0x0011DA38
			' (set) Token: 0x060020D8 RID: 8408 RVA: 0x0011F888 File Offset: 0x0011DA88
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property ProductType As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableConsumption.ProductTypeColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'ProductType' in table 'Consumption' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableConsumption.ProductTypeColumn) = value
				End Set
			End Property

			' Token: 0x17000CA5 RID: 3237
			' (get) Token: 0x060020D9 RID: 8409 RVA: 0x0011F8A0 File Offset: 0x0011DAA0
			' (set) Token: 0x060020DA RID: 8410 RVA: 0x0011F8F0 File Offset: 0x0011DAF0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property ProductName As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableConsumption.ProductNameColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'ProductName' in table 'Consumption' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableConsumption.ProductNameColumn) = value
				End Set
			End Property

			' Token: 0x17000CA6 RID: 3238
			' (get) Token: 0x060020DB RID: 8411 RVA: 0x0011F908 File Offset: 0x0011DB08
			' (set) Token: 0x060020DC RID: 8412 RVA: 0x0011F958 File Offset: 0x0011DB58
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property BatchNo As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableConsumption.BatchNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'BatchNo' in table 'Consumption' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableConsumption.BatchNoColumn) = value
				End Set
			End Property

			' Token: 0x17000CA7 RID: 3239
			' (get) Token: 0x060020DD RID: 8413 RVA: 0x0011F970 File Offset: 0x0011DB70
			' (set) Token: 0x060020DE RID: 8414 RVA: 0x0011F9C0 File Offset: 0x0011DBC0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property ExpiryDt As DateTime
				Get
					Dim dateTime As DateTime
					Try
						dateTime = Conversions.ToDate(MyBase(Me.tableConsumption.ExpiryDtColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'ExpiryDt' in table 'Consumption' is DBNull.", ex)
					End Try
					Return dateTime
				End Get
				Set(value As DateTime)
					MyBase(Me.tableConsumption.ExpiryDtColumn) = value
				End Set
			End Property

			' Token: 0x17000CA8 RID: 3240
			' (get) Token: 0x060020DF RID: 8415 RVA: 0x0011F9DC File Offset: 0x0011DBDC
			' (set) Token: 0x060020E0 RID: 8416 RVA: 0x0011FA2C File Offset: 0x0011DC2C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property Quantity As Integer
				Get
					Dim num As Integer
					Try
						num = Conversions.ToInteger(MyBase(Me.tableConsumption.QuantityColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'Quantity' in table 'Consumption' is DBNull.", ex)
					End Try
					Return num
				End Get
				Set(value As Integer)
					MyBase(Me.tableConsumption.QuantityColumn) = value
				End Set
			End Property

			' Token: 0x17000CA9 RID: 3241
			' (get) Token: 0x060020E1 RID: 8417 RVA: 0x0011FA48 File Offset: 0x0011DC48
			' (set) Token: 0x060020E2 RID: 8418 RVA: 0x0011FA98 File Offset: 0x0011DC98
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property Rate As Double
				Get
					Dim num As Double
					Try
						num = Conversions.ToDouble(MyBase(Me.tableConsumption.RateColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'Rate' in table 'Consumption' is DBNull.", ex)
					End Try
					Return num
				End Get
				Set(value As Double)
					MyBase(Me.tableConsumption.RateColumn) = value
				End Set
			End Property

			' Token: 0x17000CAA RID: 3242
			' (get) Token: 0x060020E3 RID: 8419 RVA: 0x0011FAB4 File Offset: 0x0011DCB4
			' (set) Token: 0x060020E4 RID: 8420 RVA: 0x0011FB04 File Offset: 0x0011DD04
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property Value As Double
				Get
					Dim num As Double
					Try
						num = Conversions.ToDouble(MyBase(Me.tableConsumption.ValueColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'Value' in table 'Consumption' is DBNull.", ex)
					End Try
					Return num
				End Get
				Set(value As Double)
					MyBase(Me.tableConsumption.ValueColumn) = value
				End Set
			End Property

			' Token: 0x060020E5 RID: 8421 RVA: 0x0011FB20 File Offset: 0x0011DD20
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsDepartmentNull() As Boolean
				Return MyBase.IsNull(Me.tableConsumption.DepartmentColumn)
			End Function

			' Token: 0x060020E6 RID: 8422 RVA: 0x0011FB43 File Offset: 0x0011DD43
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetDepartmentNull()
				MyBase(Me.tableConsumption.DepartmentColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x060020E7 RID: 8423 RVA: 0x0011FB64 File Offset: 0x0011DD64
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsStartDtNull() As Boolean
				Return MyBase.IsNull(Me.tableConsumption.StartDtColumn)
			End Function

			' Token: 0x060020E8 RID: 8424 RVA: 0x0011FB87 File Offset: 0x0011DD87
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetStartDtNull()
				MyBase(Me.tableConsumption.StartDtColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x060020E9 RID: 8425 RVA: 0x0011FBA8 File Offset: 0x0011DDA8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsEndDtNull() As Boolean
				Return MyBase.IsNull(Me.tableConsumption.EndDtColumn)
			End Function

			' Token: 0x060020EA RID: 8426 RVA: 0x0011FBCB File Offset: 0x0011DDCB
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetEndDtNull()
				MyBase(Me.tableConsumption.EndDtColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x060020EB RID: 8427 RVA: 0x0011FBEC File Offset: 0x0011DDEC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsProductTypeNull() As Boolean
				Return MyBase.IsNull(Me.tableConsumption.ProductTypeColumn)
			End Function

			' Token: 0x060020EC RID: 8428 RVA: 0x0011FC0F File Offset: 0x0011DE0F
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetProductTypeNull()
				MyBase(Me.tableConsumption.ProductTypeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x060020ED RID: 8429 RVA: 0x0011FC30 File Offset: 0x0011DE30
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsProductNameNull() As Boolean
				Return MyBase.IsNull(Me.tableConsumption.ProductNameColumn)
			End Function

			' Token: 0x060020EE RID: 8430 RVA: 0x0011FC53 File Offset: 0x0011DE53
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetProductNameNull()
				MyBase(Me.tableConsumption.ProductNameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x060020EF RID: 8431 RVA: 0x0011FC74 File Offset: 0x0011DE74
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsBatchNoNull() As Boolean
				Return MyBase.IsNull(Me.tableConsumption.BatchNoColumn)
			End Function

			' Token: 0x060020F0 RID: 8432 RVA: 0x0011FC97 File Offset: 0x0011DE97
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetBatchNoNull()
				MyBase(Me.tableConsumption.BatchNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x060020F1 RID: 8433 RVA: 0x0011FCB8 File Offset: 0x0011DEB8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsExpiryDtNull() As Boolean
				Return MyBase.IsNull(Me.tableConsumption.ExpiryDtColumn)
			End Function

			' Token: 0x060020F2 RID: 8434 RVA: 0x0011FCDB File Offset: 0x0011DEDB
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetExpiryDtNull()
				MyBase(Me.tableConsumption.ExpiryDtColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x060020F3 RID: 8435 RVA: 0x0011FCFC File Offset: 0x0011DEFC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsQuantityNull() As Boolean
				Return MyBase.IsNull(Me.tableConsumption.QuantityColumn)
			End Function

			' Token: 0x060020F4 RID: 8436 RVA: 0x0011FD1F File Offset: 0x0011DF1F
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetQuantityNull()
				MyBase(Me.tableConsumption.QuantityColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x060020F5 RID: 8437 RVA: 0x0011FD40 File Offset: 0x0011DF40
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsRateNull() As Boolean
				Return MyBase.IsNull(Me.tableConsumption.RateColumn)
			End Function

			' Token: 0x060020F6 RID: 8438 RVA: 0x0011FD63 File Offset: 0x0011DF63
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetRateNull()
				MyBase(Me.tableConsumption.RateColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x060020F7 RID: 8439 RVA: 0x0011FD84 File Offset: 0x0011DF84
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsValueNull() As Boolean
				Return MyBase.IsNull(Me.tableConsumption.ValueColumn)
			End Function

			' Token: 0x060020F8 RID: 8440 RVA: 0x0011FDA7 File Offset: 0x0011DFA7
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetValueNull()
				MyBase(Me.tableConsumption.ValueColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x04000DA1 RID: 3489
			Private tableConsumption As PIMSDataSet.ConsumptionDataTable
		End Class

		' Token: 0x02000082 RID: 130
		Public Class COARow
			Inherits DataRow

			' Token: 0x060020F9 RID: 8441 RVA: 0x0011FDC6 File Offset: 0x0011DFC6
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Friend Sub New(rb As DataRowBuilder)
				MyBase.New(rb)
				Me.tableCOA = CType(MyBase.Table, PIMSDataSet.COADataTable)
			End Sub

			' Token: 0x17000CAB RID: 3243
			' (get) Token: 0x060020FA RID: 8442 RVA: 0x0011FDE4 File Offset: 0x0011DFE4
			' (set) Token: 0x060020FB RID: 8443 RVA: 0x0011FE34 File Offset: 0x0011E034
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property ProgramCode As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableCOA.ProgramCodeColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'ProgramCode' in table 'COA' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableCOA.ProgramCodeColumn) = value
				End Set
			End Property

			' Token: 0x17000CAC RID: 3244
			' (get) Token: 0x060020FC RID: 8444 RVA: 0x0011FE4C File Offset: 0x0011E04C
			' (set) Token: 0x060020FD RID: 8445 RVA: 0x0011FE9C File Offset: 0x0011E09C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property ProductName As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableCOA.ProductNameColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'ProductName' in table 'COA' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableCOA.ProductNameColumn) = value
				End Set
			End Property

			' Token: 0x17000CAD RID: 3245
			' (get) Token: 0x060020FE RID: 8446 RVA: 0x0011FEB4 File Offset: 0x0011E0B4
			' (set) Token: 0x060020FF RID: 8447 RVA: 0x0011FF04 File Offset: 0x0011E104
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property ImmunoACTPatientID As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableCOA.ImmunoACTPatientIDColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'ImmunoACTPatientID' in table 'COA' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableCOA.ImmunoACTPatientIDColumn) = value
				End Set
			End Property

			' Token: 0x17000CAE RID: 3246
			' (get) Token: 0x06002100 RID: 8448 RVA: 0x0011FF1C File Offset: 0x0011E11C
			' (set) Token: 0x06002101 RID: 8449 RVA: 0x0011FF6C File Offset: 0x0011E16C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property BatchNo As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableCOA.BatchNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'BatchNo' in table 'COA' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableCOA.BatchNoColumn) = value
				End Set
			End Property

			' Token: 0x17000CAF RID: 3247
			' (get) Token: 0x06002102 RID: 8450 RVA: 0x0011FF84 File Offset: 0x0011E184
			' (set) Token: 0x06002103 RID: 8451 RVA: 0x0011FFD4 File Offset: 0x0011E1D4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property MfgDt As DateTime
				Get
					Dim dateTime As DateTime
					Try
						dateTime = Conversions.ToDate(MyBase(Me.tableCOA.MfgDtColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'MfgDt' in table 'COA' is DBNull.", ex)
					End Try
					Return dateTime
				End Get
				Set(value As DateTime)
					MyBase(Me.tableCOA.MfgDtColumn) = value
				End Set
			End Property

			' Token: 0x17000CB0 RID: 3248
			' (get) Token: 0x06002104 RID: 8452 RVA: 0x0011FFF0 File Offset: 0x0011E1F0
			' (set) Token: 0x06002105 RID: 8453 RVA: 0x00120040 File Offset: 0x0011E240
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property ExpiryDt As DateTime
				Get
					Dim dateTime As DateTime
					Try
						dateTime = Conversions.ToDate(MyBase(Me.tableCOA.ExpiryDtColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'ExpiryDt' in table 'COA' is DBNull.", ex)
					End Try
					Return dateTime
				End Get
				Set(value As DateTime)
					MyBase(Me.tableCOA.ExpiryDtColumn) = value
				End Set
			End Property

			' Token: 0x17000CB1 RID: 3249
			' (get) Token: 0x06002106 RID: 8454 RVA: 0x0012005C File Offset: 0x0011E25C
			' (set) Token: 0x06002107 RID: 8455 RVA: 0x001200AC File Offset: 0x0011E2AC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property StorageCondition As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableCOA.StorageConditionColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'StorageCondition' in table 'COA' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableCOA.StorageConditionColumn) = value
				End Set
			End Property

			' Token: 0x17000CB2 RID: 3250
			' (get) Token: 0x06002108 RID: 8456 RVA: 0x001200C4 File Offset: 0x0011E2C4
			' (set) Token: 0x06002109 RID: 8457 RVA: 0x00120114 File Offset: 0x0011E314
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property SpecificationNo As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableCOA.SpecificationNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'SpecificationNo' in table 'COA' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableCOA.SpecificationNoColumn) = value
				End Set
			End Property

			' Token: 0x17000CB3 RID: 3251
			' (get) Token: 0x0600210A RID: 8458 RVA: 0x0012012C File Offset: 0x0011E32C
			' (set) Token: 0x0600210B RID: 8459 RVA: 0x0012017C File Offset: 0x0011E37C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property SrNo As Integer
				Get
					Dim num As Integer
					Try
						num = Conversions.ToInteger(MyBase(Me.tableCOA.SrNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'SrNo' in table 'COA' is DBNull.", ex)
					End Try
					Return num
				End Get
				Set(value As Integer)
					MyBase(Me.tableCOA.SrNoColumn) = value
				End Set
			End Property

			' Token: 0x17000CB4 RID: 3252
			' (get) Token: 0x0600210C RID: 8460 RVA: 0x00120198 File Offset: 0x0011E398
			' (set) Token: 0x0600210D RID: 8461 RVA: 0x001201E8 File Offset: 0x0011E3E8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property Test As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableCOA.TestColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'Test' in table 'COA' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableCOA.TestColumn) = value
				End Set
			End Property

			' Token: 0x17000CB5 RID: 3253
			' (get) Token: 0x0600210E RID: 8462 RVA: 0x00120200 File Offset: 0x0011E400
			' (set) Token: 0x0600210F RID: 8463 RVA: 0x00120250 File Offset: 0x0011E450
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property Specification As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableCOA.SpecificationColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'Specification' in table 'COA' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableCOA.SpecificationColumn) = value
				End Set
			End Property

			' Token: 0x17000CB6 RID: 3254
			' (get) Token: 0x06002110 RID: 8464 RVA: 0x00120268 File Offset: 0x0011E468
			' (set) Token: 0x06002111 RID: 8465 RVA: 0x001202B8 File Offset: 0x0011E4B8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property Result As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableCOA.ResultColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'Result' in table 'COA' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableCOA.ResultColumn) = value
				End Set
			End Property

			' Token: 0x17000CB7 RID: 3255
			' (get) Token: 0x06002112 RID: 8466 RVA: 0x001202D0 File Offset: 0x0011E4D0
			' (set) Token: 0x06002113 RID: 8467 RVA: 0x00120320 File Offset: 0x0011E520
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property Remarks As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableCOA.RemarksColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'Remarks' in table 'COA' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableCOA.RemarksColumn) = value
				End Set
			End Property

			' Token: 0x17000CB8 RID: 3256
			' (get) Token: 0x06002114 RID: 8468 RVA: 0x00120338 File Offset: 0x0011E538
			' (set) Token: 0x06002115 RID: 8469 RVA: 0x00120388 File Offset: 0x0011E588
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property VersioNo As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableCOA.VersioNoColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'VersioNo' in table 'COA' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableCOA.VersioNoColumn) = value
				End Set
			End Property

			' Token: 0x17000CB9 RID: 3257
			' (get) Token: 0x06002116 RID: 8470 RVA: 0x001203A0 File Offset: 0x0011E5A0
			' (set) Token: 0x06002117 RID: 8471 RVA: 0x001203F0 File Offset: 0x0011E5F0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property EffectiveDt As DateTime
				Get
					Dim dateTime As DateTime
					Try
						dateTime = Conversions.ToDate(MyBase(Me.tableCOA.EffectiveDtColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'EffectiveDt' in table 'COA' is DBNull.", ex)
					End Try
					Return dateTime
				End Get
				Set(value As DateTime)
					MyBase(Me.tableCOA.EffectiveDtColumn) = value
				End Set
			End Property

			' Token: 0x17000CBA RID: 3258
			' (get) Token: 0x06002118 RID: 8472 RVA: 0x0012040C File Offset: 0x0011E60C
			' (set) Token: 0x06002119 RID: 8473 RVA: 0x0012045C File Offset: 0x0011E65C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property RevisionDtls As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableCOA.RevisionDtlsColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'RevisionDtls' in table 'COA' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableCOA.RevisionDtlsColumn) = value
				End Set
			End Property

			' Token: 0x17000CBB RID: 3259
			' (get) Token: 0x0600211A RID: 8474 RVA: 0x00120474 File Offset: 0x0011E674
			' (set) Token: 0x0600211B RID: 8475 RVA: 0x001204C4 File Offset: 0x0011E6C4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property BatchID As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableCOA.BatchIDColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'BatchID' in table 'COA' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableCOA.BatchIDColumn) = value
				End Set
			End Property

			' Token: 0x17000CBC RID: 3260
			' (get) Token: 0x0600211C RID: 8476 RVA: 0x001204DC File Offset: 0x0011E6DC
			' (set) Token: 0x0600211D RID: 8477 RVA: 0x0012052C File Offset: 0x0011E72C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property QCEntryDt As DateTime
				Get
					Dim dateTime As DateTime
					Try
						dateTime = Conversions.ToDate(MyBase(Me.tableCOA.QCEntryDtColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'QCEntryDt' in table 'COA' is DBNull.", ex)
					End Try
					Return dateTime
				End Get
				Set(value As DateTime)
					MyBase(Me.tableCOA.QCEntryDtColumn) = value
				End Set
			End Property

			' Token: 0x17000CBD RID: 3261
			' (get) Token: 0x0600211E RID: 8478 RVA: 0x00120548 File Offset: 0x0011E748
			' (set) Token: 0x0600211F RID: 8479 RVA: 0x00120598 File Offset: 0x0011E798
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property QCEntryBy As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableCOA.QCEntryByColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'QCEntryBy' in table 'COA' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableCOA.QCEntryByColumn) = value
				End Set
			End Property

			' Token: 0x17000CBE RID: 3262
			' (get) Token: 0x06002120 RID: 8480 RVA: 0x001205B0 File Offset: 0x0011E7B0
			' (set) Token: 0x06002121 RID: 8481 RVA: 0x00120600 File Offset: 0x0011E800
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property QCEntryBySign As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableCOA.QCEntryBySignColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'QCEntryBySign' in table 'COA' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableCOA.QCEntryBySignColumn) = value
				End Set
			End Property

			' Token: 0x17000CBF RID: 3263
			' (get) Token: 0x06002122 RID: 8482 RVA: 0x00120618 File Offset: 0x0011E818
			' (set) Token: 0x06002123 RID: 8483 RVA: 0x00120668 File Offset: 0x0011E868
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property Date_Of_QC_Release As DateTime
				Get
					Dim dateTime As DateTime
					Try
						dateTime = Conversions.ToDate(MyBase(Me.tableCOA.Date_Of_QC_ReleaseColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'Date_Of_QC_Release' in table 'COA' is DBNull.", ex)
					End Try
					Return dateTime
				End Get
				Set(value As DateTime)
					MyBase(Me.tableCOA.Date_Of_QC_ReleaseColumn) = value
				End Set
			End Property

			' Token: 0x17000CC0 RID: 3264
			' (get) Token: 0x06002124 RID: 8484 RVA: 0x00120684 File Offset: 0x0011E884
			' (set) Token: 0x06002125 RID: 8485 RVA: 0x001206D4 File Offset: 0x0011E8D4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property QCCheckBy As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableCOA.QCCheckByColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'QCCheckBy' in table 'COA' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableCOA.QCCheckByColumn) = value
				End Set
			End Property

			' Token: 0x17000CC1 RID: 3265
			' (get) Token: 0x06002126 RID: 8486 RVA: 0x001206EC File Offset: 0x0011E8EC
			' (set) Token: 0x06002127 RID: 8487 RVA: 0x0012073C File Offset: 0x0011E93C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property QCCheckBySign As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableCOA.QCCheckBySignColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'QCCheckBySign' in table 'COA' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableCOA.QCCheckBySignColumn) = value
				End Set
			End Property

			' Token: 0x17000CC2 RID: 3266
			' (get) Token: 0x06002128 RID: 8488 RVA: 0x00120754 File Offset: 0x0011E954
			' (set) Token: 0x06002129 RID: 8489 RVA: 0x001207A4 File Offset: 0x0011E9A4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property Date_Of_QA_Release As DateTime
				Get
					Dim dateTime As DateTime
					Try
						dateTime = Conversions.ToDate(MyBase(Me.tableCOA.Date_Of_QA_ReleaseColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'Date_Of_QA_Release' in table 'COA' is DBNull.", ex)
					End Try
					Return dateTime
				End Get
				Set(value As DateTime)
					MyBase(Me.tableCOA.Date_Of_QA_ReleaseColumn) = value
				End Set
			End Property

			' Token: 0x17000CC3 RID: 3267
			' (get) Token: 0x0600212A RID: 8490 RVA: 0x001207C0 File Offset: 0x0011E9C0
			' (set) Token: 0x0600212B RID: 8491 RVA: 0x00120810 File Offset: 0x0011EA10
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property QACheckBy As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableCOA.QACheckByColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'QACheckBy' in table 'COA' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableCOA.QACheckByColumn) = value
				End Set
			End Property

			' Token: 0x17000CC4 RID: 3268
			' (get) Token: 0x0600212C RID: 8492 RVA: 0x00120828 File Offset: 0x0011EA28
			' (set) Token: 0x0600212D RID: 8493 RVA: 0x00120878 File Offset: 0x0011EA78
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Property QACheckBySign As String
				Get
					Dim text As String
					Try
						text = Conversions.ToString(MyBase(Me.tableCOA.QACheckBySignColumn))
					Catch ex As InvalidCastException
						Throw New StrongTypingException("The value for column 'QACheckBySign' in table 'COA' is DBNull.", ex)
					End Try
					Return text
				End Get
				Set(value As String)
					MyBase(Me.tableCOA.QACheckBySignColumn) = value
				End Set
			End Property

			' Token: 0x0600212E RID: 8494 RVA: 0x00120890 File Offset: 0x0011EA90
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsProgramCodeNull() As Boolean
				Return MyBase.IsNull(Me.tableCOA.ProgramCodeColumn)
			End Function

			' Token: 0x0600212F RID: 8495 RVA: 0x001208B3 File Offset: 0x0011EAB3
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetProgramCodeNull()
				MyBase(Me.tableCOA.ProgramCodeColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002130 RID: 8496 RVA: 0x001208D4 File Offset: 0x0011EAD4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsProductNameNull() As Boolean
				Return MyBase.IsNull(Me.tableCOA.ProductNameColumn)
			End Function

			' Token: 0x06002131 RID: 8497 RVA: 0x001208F7 File Offset: 0x0011EAF7
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetProductNameNull()
				MyBase(Me.tableCOA.ProductNameColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002132 RID: 8498 RVA: 0x00120918 File Offset: 0x0011EB18
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsImmunoACTPatientIDNull() As Boolean
				Return MyBase.IsNull(Me.tableCOA.ImmunoACTPatientIDColumn)
			End Function

			' Token: 0x06002133 RID: 8499 RVA: 0x0012093B File Offset: 0x0011EB3B
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetImmunoACTPatientIDNull()
				MyBase(Me.tableCOA.ImmunoACTPatientIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002134 RID: 8500 RVA: 0x0012095C File Offset: 0x0011EB5C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsBatchNoNull() As Boolean
				Return MyBase.IsNull(Me.tableCOA.BatchNoColumn)
			End Function

			' Token: 0x06002135 RID: 8501 RVA: 0x0012097F File Offset: 0x0011EB7F
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetBatchNoNull()
				MyBase(Me.tableCOA.BatchNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002136 RID: 8502 RVA: 0x001209A0 File Offset: 0x0011EBA0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsMfgDtNull() As Boolean
				Return MyBase.IsNull(Me.tableCOA.MfgDtColumn)
			End Function

			' Token: 0x06002137 RID: 8503 RVA: 0x001209C3 File Offset: 0x0011EBC3
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetMfgDtNull()
				MyBase(Me.tableCOA.MfgDtColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002138 RID: 8504 RVA: 0x001209E4 File Offset: 0x0011EBE4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsExpiryDtNull() As Boolean
				Return MyBase.IsNull(Me.tableCOA.ExpiryDtColumn)
			End Function

			' Token: 0x06002139 RID: 8505 RVA: 0x00120A07 File Offset: 0x0011EC07
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetExpiryDtNull()
				MyBase(Me.tableCOA.ExpiryDtColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x0600213A RID: 8506 RVA: 0x00120A28 File Offset: 0x0011EC28
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsStorageConditionNull() As Boolean
				Return MyBase.IsNull(Me.tableCOA.StorageConditionColumn)
			End Function

			' Token: 0x0600213B RID: 8507 RVA: 0x00120A4B File Offset: 0x0011EC4B
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetStorageConditionNull()
				MyBase(Me.tableCOA.StorageConditionColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x0600213C RID: 8508 RVA: 0x00120A6C File Offset: 0x0011EC6C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsSpecificationNoNull() As Boolean
				Return MyBase.IsNull(Me.tableCOA.SpecificationNoColumn)
			End Function

			' Token: 0x0600213D RID: 8509 RVA: 0x00120A8F File Offset: 0x0011EC8F
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetSpecificationNoNull()
				MyBase(Me.tableCOA.SpecificationNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x0600213E RID: 8510 RVA: 0x00120AB0 File Offset: 0x0011ECB0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsSrNoNull() As Boolean
				Return MyBase.IsNull(Me.tableCOA.SrNoColumn)
			End Function

			' Token: 0x0600213F RID: 8511 RVA: 0x00120AD3 File Offset: 0x0011ECD3
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetSrNoNull()
				MyBase(Me.tableCOA.SrNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002140 RID: 8512 RVA: 0x00120AF4 File Offset: 0x0011ECF4
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsTestNull() As Boolean
				Return MyBase.IsNull(Me.tableCOA.TestColumn)
			End Function

			' Token: 0x06002141 RID: 8513 RVA: 0x00120B17 File Offset: 0x0011ED17
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetTestNull()
				MyBase(Me.tableCOA.TestColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002142 RID: 8514 RVA: 0x00120B38 File Offset: 0x0011ED38
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsSpecificationNull() As Boolean
				Return MyBase.IsNull(Me.tableCOA.SpecificationColumn)
			End Function

			' Token: 0x06002143 RID: 8515 RVA: 0x00120B5B File Offset: 0x0011ED5B
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetSpecificationNull()
				MyBase(Me.tableCOA.SpecificationColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002144 RID: 8516 RVA: 0x00120B7C File Offset: 0x0011ED7C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsResultNull() As Boolean
				Return MyBase.IsNull(Me.tableCOA.ResultColumn)
			End Function

			' Token: 0x06002145 RID: 8517 RVA: 0x00120B9F File Offset: 0x0011ED9F
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetResultNull()
				MyBase(Me.tableCOA.ResultColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002146 RID: 8518 RVA: 0x00120BC0 File Offset: 0x0011EDC0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsRemarksNull() As Boolean
				Return MyBase.IsNull(Me.tableCOA.RemarksColumn)
			End Function

			' Token: 0x06002147 RID: 8519 RVA: 0x00120BE3 File Offset: 0x0011EDE3
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetRemarksNull()
				MyBase(Me.tableCOA.RemarksColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002148 RID: 8520 RVA: 0x00120C04 File Offset: 0x0011EE04
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsVersioNoNull() As Boolean
				Return MyBase.IsNull(Me.tableCOA.VersioNoColumn)
			End Function

			' Token: 0x06002149 RID: 8521 RVA: 0x00120C27 File Offset: 0x0011EE27
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetVersioNoNull()
				MyBase(Me.tableCOA.VersioNoColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x0600214A RID: 8522 RVA: 0x00120C48 File Offset: 0x0011EE48
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsEffectiveDtNull() As Boolean
				Return MyBase.IsNull(Me.tableCOA.EffectiveDtColumn)
			End Function

			' Token: 0x0600214B RID: 8523 RVA: 0x00120C6B File Offset: 0x0011EE6B
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetEffectiveDtNull()
				MyBase(Me.tableCOA.EffectiveDtColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x0600214C RID: 8524 RVA: 0x00120C8C File Offset: 0x0011EE8C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsRevisionDtlsNull() As Boolean
				Return MyBase.IsNull(Me.tableCOA.RevisionDtlsColumn)
			End Function

			' Token: 0x0600214D RID: 8525 RVA: 0x00120CAF File Offset: 0x0011EEAF
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetRevisionDtlsNull()
				MyBase(Me.tableCOA.RevisionDtlsColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x0600214E RID: 8526 RVA: 0x00120CD0 File Offset: 0x0011EED0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsBatchIDNull() As Boolean
				Return MyBase.IsNull(Me.tableCOA.BatchIDColumn)
			End Function

			' Token: 0x0600214F RID: 8527 RVA: 0x00120CF3 File Offset: 0x0011EEF3
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetBatchIDNull()
				MyBase(Me.tableCOA.BatchIDColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002150 RID: 8528 RVA: 0x00120D14 File Offset: 0x0011EF14
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsQCEntryDtNull() As Boolean
				Return MyBase.IsNull(Me.tableCOA.QCEntryDtColumn)
			End Function

			' Token: 0x06002151 RID: 8529 RVA: 0x00120D37 File Offset: 0x0011EF37
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetQCEntryDtNull()
				MyBase(Me.tableCOA.QCEntryDtColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002152 RID: 8530 RVA: 0x00120D58 File Offset: 0x0011EF58
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsQCEntryByNull() As Boolean
				Return MyBase.IsNull(Me.tableCOA.QCEntryByColumn)
			End Function

			' Token: 0x06002153 RID: 8531 RVA: 0x00120D7B File Offset: 0x0011EF7B
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetQCEntryByNull()
				MyBase(Me.tableCOA.QCEntryByColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002154 RID: 8532 RVA: 0x00120D9C File Offset: 0x0011EF9C
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsQCEntryBySignNull() As Boolean
				Return MyBase.IsNull(Me.tableCOA.QCEntryBySignColumn)
			End Function

			' Token: 0x06002155 RID: 8533 RVA: 0x00120DBF File Offset: 0x0011EFBF
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetQCEntryBySignNull()
				MyBase(Me.tableCOA.QCEntryBySignColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002156 RID: 8534 RVA: 0x00120DE0 File Offset: 0x0011EFE0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsDate_Of_QC_ReleaseNull() As Boolean
				Return MyBase.IsNull(Me.tableCOA.Date_Of_QC_ReleaseColumn)
			End Function

			' Token: 0x06002157 RID: 8535 RVA: 0x00120E03 File Offset: 0x0011F003
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetDate_Of_QC_ReleaseNull()
				MyBase(Me.tableCOA.Date_Of_QC_ReleaseColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002158 RID: 8536 RVA: 0x00120E24 File Offset: 0x0011F024
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsQCCheckByNull() As Boolean
				Return MyBase.IsNull(Me.tableCOA.QCCheckByColumn)
			End Function

			' Token: 0x06002159 RID: 8537 RVA: 0x00120E47 File Offset: 0x0011F047
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetQCCheckByNull()
				MyBase(Me.tableCOA.QCCheckByColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x0600215A RID: 8538 RVA: 0x00120E68 File Offset: 0x0011F068
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsQCCheckBySignNull() As Boolean
				Return MyBase.IsNull(Me.tableCOA.QCCheckBySignColumn)
			End Function

			' Token: 0x0600215B RID: 8539 RVA: 0x00120E8B File Offset: 0x0011F08B
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetQCCheckBySignNull()
				MyBase(Me.tableCOA.QCCheckBySignColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x0600215C RID: 8540 RVA: 0x00120EAC File Offset: 0x0011F0AC
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsDate_Of_QA_ReleaseNull() As Boolean
				Return MyBase.IsNull(Me.tableCOA.Date_Of_QA_ReleaseColumn)
			End Function

			' Token: 0x0600215D RID: 8541 RVA: 0x00120ECF File Offset: 0x0011F0CF
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetDate_Of_QA_ReleaseNull()
				MyBase(Me.tableCOA.Date_Of_QA_ReleaseColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x0600215E RID: 8542 RVA: 0x00120EF0 File Offset: 0x0011F0F0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsQACheckByNull() As Boolean
				Return MyBase.IsNull(Me.tableCOA.QACheckByColumn)
			End Function

			' Token: 0x0600215F RID: 8543 RVA: 0x00120F13 File Offset: 0x0011F113
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetQACheckByNull()
				MyBase(Me.tableCOA.QACheckByColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x06002160 RID: 8544 RVA: 0x00120F34 File Offset: 0x0011F134
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Function IsQACheckBySignNull() As Boolean
				Return MyBase.IsNull(Me.tableCOA.QACheckBySignColumn)
			End Function

			' Token: 0x06002161 RID: 8545 RVA: 0x00120F57 File Offset: 0x0011F157
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub SetQACheckBySignNull()
				MyBase(Me.tableCOA.QACheckBySignColumn) = RuntimeHelpers.GetObjectValue(Convert.DBNull)
			End Sub

			' Token: 0x04000DA2 RID: 3490
			Private tableCOA As PIMSDataSet.COADataTable
		End Class

		' Token: 0x02000083 RID: 131
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Public Class PORowChangeEvent
			Inherits EventArgs

			' Token: 0x06002162 RID: 8546 RVA: 0x00120F76 File Offset: 0x0011F176
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub New(row As PIMSDataSet.PORow, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			' Token: 0x17000CC5 RID: 3269
			' (get) Token: 0x06002163 RID: 8547 RVA: 0x00120F90 File Offset: 0x0011F190
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property Row As PIMSDataSet.PORow
				Get
					Return Me.eventRow
				End Get
			End Property

			' Token: 0x17000CC6 RID: 3270
			' (get) Token: 0x06002164 RID: 8548 RVA: 0x00120FA8 File Offset: 0x0011F1A8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property Action As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			' Token: 0x04000DA3 RID: 3491
			Private eventRow As PIMSDataSet.PORow

			' Token: 0x04000DA4 RID: 3492
			Private eventAction As DataRowAction
		End Class

		' Token: 0x02000084 RID: 132
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Public Class TestRowChangeEvent
			Inherits EventArgs

			' Token: 0x06002165 RID: 8549 RVA: 0x00120FC0 File Offset: 0x0011F1C0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub New(row As PIMSDataSet.TestRow, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			' Token: 0x17000CC7 RID: 3271
			' (get) Token: 0x06002166 RID: 8550 RVA: 0x00120FD8 File Offset: 0x0011F1D8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property Row As PIMSDataSet.TestRow
				Get
					Return Me.eventRow
				End Get
			End Property

			' Token: 0x17000CC8 RID: 3272
			' (get) Token: 0x06002167 RID: 8551 RVA: 0x00120FF0 File Offset: 0x0011F1F0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property Action As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			' Token: 0x04000DA5 RID: 3493
			Private eventRow As PIMSDataSet.TestRow

			' Token: 0x04000DA6 RID: 3494
			Private eventAction As DataRowAction
		End Class

		' Token: 0x02000085 RID: 133
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Public Class QCRowChangeEvent
			Inherits EventArgs

			' Token: 0x06002168 RID: 8552 RVA: 0x00121008 File Offset: 0x0011F208
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub New(row As PIMSDataSet.QCRow, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			' Token: 0x17000CC9 RID: 3273
			' (get) Token: 0x06002169 RID: 8553 RVA: 0x00121020 File Offset: 0x0011F220
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property Row As PIMSDataSet.QCRow
				Get
					Return Me.eventRow
				End Get
			End Property

			' Token: 0x17000CCA RID: 3274
			' (get) Token: 0x0600216A RID: 8554 RVA: 0x00121038 File Offset: 0x0011F238
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property Action As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			' Token: 0x04000DA7 RID: 3495
			Private eventRow As PIMSDataSet.QCRow

			' Token: 0x04000DA8 RID: 3496
			Private eventAction As DataRowAction
		End Class

		' Token: 0x02000086 RID: 134
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Public Class IssueRowChangeEvent
			Inherits EventArgs

			' Token: 0x0600216B RID: 8555 RVA: 0x00121050 File Offset: 0x0011F250
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub New(row As PIMSDataSet.IssueRow, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			' Token: 0x17000CCB RID: 3275
			' (get) Token: 0x0600216C RID: 8556 RVA: 0x00121068 File Offset: 0x0011F268
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property Row As PIMSDataSet.IssueRow
				Get
					Return Me.eventRow
				End Get
			End Property

			' Token: 0x17000CCC RID: 3276
			' (get) Token: 0x0600216D RID: 8557 RVA: 0x00121080 File Offset: 0x0011F280
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property Action As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			' Token: 0x04000DA9 RID: 3497
			Private eventRow As PIMSDataSet.IssueRow

			' Token: 0x04000DAA RID: 3498
			Private eventAction As DataRowAction
		End Class

		' Token: 0x02000087 RID: 135
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Public Class ConsumptionRowChangeEvent
			Inherits EventArgs

			' Token: 0x0600216E RID: 8558 RVA: 0x00121098 File Offset: 0x0011F298
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub New(row As PIMSDataSet.ConsumptionRow, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			' Token: 0x17000CCD RID: 3277
			' (get) Token: 0x0600216F RID: 8559 RVA: 0x001210B0 File Offset: 0x0011F2B0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property Row As PIMSDataSet.ConsumptionRow
				Get
					Return Me.eventRow
				End Get
			End Property

			' Token: 0x17000CCE RID: 3278
			' (get) Token: 0x06002170 RID: 8560 RVA: 0x001210C8 File Offset: 0x0011F2C8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property Action As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			' Token: 0x04000DAB RID: 3499
			Private eventRow As PIMSDataSet.ConsumptionRow

			' Token: 0x04000DAC RID: 3500
			Private eventAction As DataRowAction
		End Class

		' Token: 0x02000088 RID: 136
		<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
		Public Class COARowChangeEvent
			Inherits EventArgs

			' Token: 0x06002171 RID: 8561 RVA: 0x001210E0 File Offset: 0x0011F2E0
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public Sub New(row As PIMSDataSet.COARow, action As DataRowAction)
				Me.eventRow = row
				Me.eventAction = action
			End Sub

			' Token: 0x17000CCF RID: 3279
			' (get) Token: 0x06002172 RID: 8562 RVA: 0x001210F8 File Offset: 0x0011F2F8
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property Row As PIMSDataSet.COARow
				Get
					Return Me.eventRow
				End Get
			End Property

			' Token: 0x17000CD0 RID: 3280
			' (get) Token: 0x06002173 RID: 8563 RVA: 0x00121110 File Offset: 0x0011F310
			<DebuggerNonUserCode()>
			<GeneratedCode("System.Data.Design.TypedDataSetGenerator", "15.0.0.0")>
			Public ReadOnly Property Action As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property

			' Token: 0x04000DAD RID: 3501
			Private eventRow As PIMSDataSet.COARow

			' Token: 0x04000DAE RID: 3502
			Private eventAction As DataRowAction
		End Class
	End Class
End Namespace
