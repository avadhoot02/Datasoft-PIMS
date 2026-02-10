Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS.My
	' Token: 0x02000004 RID: 4
	<HideModuleName()>
	<GeneratedCode("MyTemplate", "11.0.0.0")>
	Friend NotInheritable Module MyProject
		' Token: 0x17000001 RID: 1
		' (get) Token: 0x06000006 RID: 6 RVA: 0x0000210C File Offset: 0x0000030C
		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property Computer As MyComputer
			<DebuggerHidden()>
			Get
				Return MyProject.m_ComputerObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000002 RID: 2
		' (get) Token: 0x06000007 RID: 7 RVA: 0x00002128 File Offset: 0x00000328
		<HelpKeyword("My.Application")>
		Friend ReadOnly Property Application As MyApplication
			<DebuggerHidden()>
			Get
				Return MyProject.m_AppObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000003 RID: 3
		' (get) Token: 0x06000008 RID: 8 RVA: 0x00002144 File Offset: 0x00000344
		<HelpKeyword("My.User")>
		Friend ReadOnly Property User As User
			<DebuggerHidden()>
			Get
				Return MyProject.m_UserObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000004 RID: 4
		' (get) Token: 0x06000009 RID: 9 RVA: 0x00002160 File Offset: 0x00000360
		<HelpKeyword("My.Forms")>
		Friend ReadOnly Property Forms As MyProject.MyForms
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyFormsObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000005 RID: 5
		' (get) Token: 0x0600000A RID: 10 RVA: 0x0000217C File Offset: 0x0000037C
		<HelpKeyword("My.WebServices")>
		Friend ReadOnly Property WebServices As MyProject.MyWebServices
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyWebServicesObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x04000001 RID: 1
		Private m_ComputerObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyComputer) = New MyProject.ThreadSafeObjectProvider(Of MyComputer)()

		' Token: 0x04000002 RID: 2
		Private m_AppObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyApplication) = New MyProject.ThreadSafeObjectProvider(Of MyApplication)()

		' Token: 0x04000003 RID: 3
		Private m_UserObjectProvider As MyProject.ThreadSafeObjectProvider(Of User) = New MyProject.ThreadSafeObjectProvider(Of User)()

		' Token: 0x04000004 RID: 4
		Private m_MyFormsObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms)()

		' Token: 0x04000005 RID: 5
		Private m_MyWebServicesObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices)()

		' Token: 0x0200006E RID: 110
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")>
		Friend NotInheritable Class MyForms
			' Token: 0x06001D92 RID: 7570 RVA: 0x00114118 File Offset: 0x00112318
			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As{Form, New})(Instance As T) As T
				Dim flag As Boolean = Instance Is Nothing OrElse Instance.IsDisposed
				If flag Then
					Dim flag2 As Boolean = MyProject.MyForms.m_FormBeingCreated IsNot Nothing
					If flag2 Then
						Dim flag3 As Boolean = MyProject.MyForms.m_FormBeingCreated.ContainsKey(GetType(T))
						If flag3 Then
							Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(-1) {}))
						End If
					Else
						MyProject.MyForms.m_FormBeingCreated = New Hashtable()
					End If
					MyProject.MyForms.m_FormBeingCreated.Add(GetType(T), Nothing)
					Try
						Return New T()
					Catch ex As TargetInvocationException When ex.InnerException IsNot Nothing
						Dim resourceString As String = Utils.GetResourceString("WinForms_SeeInnerException", New String() { ex.InnerException.Message })
						Throw New InvalidOperationException(resourceString, ex.InnerException)
					Finally
						MyProject.MyForms.m_FormBeingCreated.Remove(GetType(T))
					End Try
				End If
				Return Instance
			End Function

			' Token: 0x06001D93 RID: 7571 RVA: 0x00114240 File Offset: 0x00112440
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T As Form)(ByRef instance As T)
				instance.Dispose()
				instance = Nothing
			End Sub

			' Token: 0x06001D94 RID: 7572 RVA: 0x00114257 File Offset: 0x00112457
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub

			' Token: 0x06001D95 RID: 7573 RVA: 0x00114264 File Offset: 0x00112464
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x06001D96 RID: 7574 RVA: 0x00114284 File Offset: 0x00112484
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x06001D97 RID: 7575 RVA: 0x0011429C File Offset: 0x0011249C
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyForms)
			End Function

			' Token: 0x06001D98 RID: 7576 RVA: 0x001142B8 File Offset: 0x001124B8
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x17000B80 RID: 2944
			' (get) Token: 0x06001D99 RID: 7577 RVA: 0x001142D0 File Offset: 0x001124D0
			' (set) Token: 0x06001DBD RID: 7613 RVA: 0x0011469C File Offset: 0x0011289C
			Public Property About As About
				<DebuggerHidden()>
				Get
					Me.m_About = MyProject.MyForms.Create__Instance__(Of About)(Me.m_About)
					Return Me.m_About
				End Get
				<DebuggerHidden()>
				Set(value As About)
					If value IsNot Me.m_About Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of About)(Me.m_About)
					End If
				End Set
			End Property

			' Token: 0x17000B81 RID: 2945
			' (get) Token: 0x06001D9A RID: 7578 RVA: 0x001142EB File Offset: 0x001124EB
			' (set) Token: 0x06001DBE RID: 7614 RVA: 0x001146C8 File Offset: 0x001128C8
			Public Property ActivityLog As ActivityLog
				<DebuggerHidden()>
				Get
					Me.m_ActivityLog = MyProject.MyForms.Create__Instance__(Of ActivityLog)(Me.m_ActivityLog)
					Return Me.m_ActivityLog
				End Get
				<DebuggerHidden()>
				Set(value As ActivityLog)
					If value IsNot Me.m_ActivityLog Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of ActivityLog)(Me.m_ActivityLog)
					End If
				End Set
			End Property

			' Token: 0x17000B82 RID: 2946
			' (get) Token: 0x06001D9B RID: 7579 RVA: 0x00114306 File Offset: 0x00112506
			' (set) Token: 0x06001DBF RID: 7615 RVA: 0x001146F4 File Offset: 0x001128F4
			Public Property ApprovalRange As ApprovalRange
				<DebuggerHidden()>
				Get
					Me.m_ApprovalRange = MyProject.MyForms.Create__Instance__(Of ApprovalRange)(Me.m_ApprovalRange)
					Return Me.m_ApprovalRange
				End Get
				<DebuggerHidden()>
				Set(value As ApprovalRange)
					If value IsNot Me.m_ApprovalRange Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of ApprovalRange)(Me.m_ApprovalRange)
					End If
				End Set
			End Property

			' Token: 0x17000B83 RID: 2947
			' (get) Token: 0x06001D9C RID: 7580 RVA: 0x00114321 File Offset: 0x00112521
			' (set) Token: 0x06001DC0 RID: 7616 RVA: 0x00114720 File Offset: 0x00112920
			Public Property AppUpdater As AppUpdater
				<DebuggerHidden()>
				Get
					Me.m_AppUpdater = MyProject.MyForms.Create__Instance__(Of AppUpdater)(Me.m_AppUpdater)
					Return Me.m_AppUpdater
				End Get
				<DebuggerHidden()>
				Set(value As AppUpdater)
					If value IsNot Me.m_AppUpdater Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of AppUpdater)(Me.m_AppUpdater)
					End If
				End Set
			End Property

			' Token: 0x17000B84 RID: 2948
			' (get) Token: 0x06001D9D RID: 7581 RVA: 0x0011433C File Offset: 0x0011253C
			' (set) Token: 0x06001DC1 RID: 7617 RVA: 0x0011474C File Offset: 0x0011294C
			Public Property Binning As Binning
				<DebuggerHidden()>
				Get
					Me.m_Binning = MyProject.MyForms.Create__Instance__(Of Binning)(Me.m_Binning)
					Return Me.m_Binning
				End Get
				<DebuggerHidden()>
				Set(value As Binning)
					If value IsNot Me.m_Binning Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Binning)(Me.m_Binning)
					End If
				End Set
			End Property

			' Token: 0x17000B85 RID: 2949
			' (get) Token: 0x06001D9E RID: 7582 RVA: 0x00114357 File Offset: 0x00112557
			' (set) Token: 0x06001DC2 RID: 7618 RVA: 0x00114778 File Offset: 0x00112978
			Public Property BOMReport As BOMReport
				<DebuggerHidden()>
				Get
					Me.m_BOMReport = MyProject.MyForms.Create__Instance__(Of BOMReport)(Me.m_BOMReport)
					Return Me.m_BOMReport
				End Get
				<DebuggerHidden()>
				Set(value As BOMReport)
					If value IsNot Me.m_BOMReport Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of BOMReport)(Me.m_BOMReport)
					End If
				End Set
			End Property

			' Token: 0x17000B86 RID: 2950
			' (get) Token: 0x06001D9F RID: 7583 RVA: 0x00114372 File Offset: 0x00112572
			' (set) Token: 0x06001DC3 RID: 7619 RVA: 0x001147A4 File Offset: 0x001129A4
			Public Property ChangePass As ChangePass
				<DebuggerHidden()>
				Get
					Me.m_ChangePass = MyProject.MyForms.Create__Instance__(Of ChangePass)(Me.m_ChangePass)
					Return Me.m_ChangePass
				End Get
				<DebuggerHidden()>
				Set(value As ChangePass)
					If value IsNot Me.m_ChangePass Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of ChangePass)(Me.m_ChangePass)
					End If
				End Set
			End Property

			' Token: 0x17000B87 RID: 2951
			' (get) Token: 0x06001DA0 RID: 7584 RVA: 0x0011438D File Offset: 0x0011258D
			' (set) Token: 0x06001DC4 RID: 7620 RVA: 0x001147D0 File Offset: 0x001129D0
			Public Property ClosingStock As ClosingStock
				<DebuggerHidden()>
				Get
					Me.m_ClosingStock = MyProject.MyForms.Create__Instance__(Of ClosingStock)(Me.m_ClosingStock)
					Return Me.m_ClosingStock
				End Get
				<DebuggerHidden()>
				Set(value As ClosingStock)
					If value IsNot Me.m_ClosingStock Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of ClosingStock)(Me.m_ClosingStock)
					End If
				End Set
			End Property

			' Token: 0x17000B88 RID: 2952
			' (get) Token: 0x06001DA1 RID: 7585 RVA: 0x001143A8 File Offset: 0x001125A8
			' (set) Token: 0x06001DC5 RID: 7621 RVA: 0x001147FC File Offset: 0x001129FC
			Public Property ConsumptionReport As ConsumptionReport
				<DebuggerHidden()>
				Get
					Me.m_ConsumptionReport = MyProject.MyForms.Create__Instance__(Of ConsumptionReport)(Me.m_ConsumptionReport)
					Return Me.m_ConsumptionReport
				End Get
				<DebuggerHidden()>
				Set(value As ConsumptionReport)
					If value IsNot Me.m_ConsumptionReport Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of ConsumptionReport)(Me.m_ConsumptionReport)
					End If
				End Set
			End Property

			' Token: 0x17000B89 RID: 2953
			' (get) Token: 0x06001DA2 RID: 7586 RVA: 0x001143C3 File Offset: 0x001125C3
			' (set) Token: 0x06001DC6 RID: 7622 RVA: 0x00114828 File Offset: 0x00112A28
			Public Property Dashboard As Dashboard
				<DebuggerHidden()>
				Get
					Me.m_Dashboard = MyProject.MyForms.Create__Instance__(Of Dashboard)(Me.m_Dashboard)
					Return Me.m_Dashboard
				End Get
				<DebuggerHidden()>
				Set(value As Dashboard)
					If value IsNot Me.m_Dashboard Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Dashboard)(Me.m_Dashboard)
					End If
				End Set
			End Property

			' Token: 0x17000B8A RID: 2954
			' (get) Token: 0x06001DA3 RID: 7587 RVA: 0x001143DE File Offset: 0x001125DE
			' (set) Token: 0x06001DC7 RID: 7623 RVA: 0x00114854 File Offset: 0x00112A54
			Public Property DashboardTest As DashboardTest
				<DebuggerHidden()>
				Get
					Me.m_DashboardTest = MyProject.MyForms.Create__Instance__(Of DashboardTest)(Me.m_DashboardTest)
					Return Me.m_DashboardTest
				End Get
				<DebuggerHidden()>
				Set(value As DashboardTest)
					If value IsNot Me.m_DashboardTest Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of DashboardTest)(Me.m_DashboardTest)
					End If
				End Set
			End Property

			' Token: 0x17000B8B RID: 2955
			' (get) Token: 0x06001DA4 RID: 7588 RVA: 0x001143F9 File Offset: 0x001125F9
			' (set) Token: 0x06001DC8 RID: 7624 RVA: 0x00114880 File Offset: 0x00112A80
			Public Property Dispose As Dispose
				<DebuggerHidden()>
				Get
					Me.m_Dispose = MyProject.MyForms.Create__Instance__(Of Dispose)(Me.m_Dispose)
					Return Me.m_Dispose
				End Get
				<DebuggerHidden()>
				Set(value As Dispose)
					If value IsNot Me.m_Dispose Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Dispose)(Me.m_Dispose)
					End If
				End Set
			End Property

			' Token: 0x17000B8C RID: 2956
			' (get) Token: 0x06001DA5 RID: 7589 RVA: 0x00114414 File Offset: 0x00112614
			' (set) Token: 0x06001DC9 RID: 7625 RVA: 0x001148AC File Offset: 0x00112AAC
			Public Property DisposeList As DisposeList
				<DebuggerHidden()>
				Get
					Me.m_DisposeList = MyProject.MyForms.Create__Instance__(Of DisposeList)(Me.m_DisposeList)
					Return Me.m_DisposeList
				End Get
				<DebuggerHidden()>
				Set(value As DisposeList)
					If value IsNot Me.m_DisposeList Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of DisposeList)(Me.m_DisposeList)
					End If
				End Set
			End Property

			' Token: 0x17000B8D RID: 2957
			' (get) Token: 0x06001DA6 RID: 7590 RVA: 0x0011442F File Offset: 0x0011262F
			' (set) Token: 0x06001DCA RID: 7626 RVA: 0x001148D8 File Offset: 0x00112AD8
			Public Property EmailAlert As EmailAlert
				<DebuggerHidden()>
				Get
					Me.m_EmailAlert = MyProject.MyForms.Create__Instance__(Of EmailAlert)(Me.m_EmailAlert)
					Return Me.m_EmailAlert
				End Get
				<DebuggerHidden()>
				Set(value As EmailAlert)
					If value IsNot Me.m_EmailAlert Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of EmailAlert)(Me.m_EmailAlert)
					End If
				End Set
			End Property

			' Token: 0x17000B8E RID: 2958
			' (get) Token: 0x06001DA7 RID: 7591 RVA: 0x0011444A File Offset: 0x0011264A
			' (set) Token: 0x06001DCB RID: 7627 RVA: 0x00114904 File Offset: 0x00112B04
			Public Property EmailTest As EmailTest
				<DebuggerHidden()>
				Get
					Me.m_EmailTest = MyProject.MyForms.Create__Instance__(Of EmailTest)(Me.m_EmailTest)
					Return Me.m_EmailTest
				End Get
				<DebuggerHidden()>
				Set(value As EmailTest)
					If value IsNot Me.m_EmailTest Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of EmailTest)(Me.m_EmailTest)
					End If
				End Set
			End Property

			' Token: 0x17000B8F RID: 2959
			' (get) Token: 0x06001DA8 RID: 7592 RVA: 0x00114465 File Offset: 0x00112665
			' (set) Token: 0x06001DCC RID: 7628 RVA: 0x00114930 File Offset: 0x00112B30
			Public Property Form1 As Form1
				<DebuggerHidden()>
				Get
					Me.m_Form1 = MyProject.MyForms.Create__Instance__(Of Form1)(Me.m_Form1)
					Return Me.m_Form1
				End Get
				<DebuggerHidden()>
				Set(value As Form1)
					If value IsNot Me.m_Form1 Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form1)(Me.m_Form1)
					End If
				End Set
			End Property

			' Token: 0x17000B90 RID: 2960
			' (get) Token: 0x06001DA9 RID: 7593 RVA: 0x00114480 File Offset: 0x00112680
			' (set) Token: 0x06001DCD RID: 7629 RVA: 0x0011495C File Offset: 0x00112B5C
			Public Property Form2 As Form2
				<DebuggerHidden()>
				Get
					Me.m_Form2 = MyProject.MyForms.Create__Instance__(Of Form2)(Me.m_Form2)
					Return Me.m_Form2
				End Get
				<DebuggerHidden()>
				Set(value As Form2)
					If value IsNot Me.m_Form2 Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form2)(Me.m_Form2)
					End If
				End Set
			End Property

			' Token: 0x17000B91 RID: 2961
			' (get) Token: 0x06001DAA RID: 7594 RVA: 0x0011449B File Offset: 0x0011269B
			' (set) Token: 0x06001DCE RID: 7630 RVA: 0x00114988 File Offset: 0x00112B88
			Public Property GRNReport As GRNReport
				<DebuggerHidden()>
				Get
					Me.m_GRNReport = MyProject.MyForms.Create__Instance__(Of GRNReport)(Me.m_GRNReport)
					Return Me.m_GRNReport
				End Get
				<DebuggerHidden()>
				Set(value As GRNReport)
					If value IsNot Me.m_GRNReport Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of GRNReport)(Me.m_GRNReport)
					End If
				End Set
			End Property

			' Token: 0x17000B92 RID: 2962
			' (get) Token: 0x06001DAB RID: 7595 RVA: 0x001144B6 File Offset: 0x001126B6
			' (set) Token: 0x06001DCF RID: 7631 RVA: 0x001149B4 File Offset: 0x00112BB4
			Public Property LoadingScreen As LoadingScreen
				<DebuggerHidden()>
				Get
					Me.m_LoadingScreen = MyProject.MyForms.Create__Instance__(Of LoadingScreen)(Me.m_LoadingScreen)
					Return Me.m_LoadingScreen
				End Get
				<DebuggerHidden()>
				Set(value As LoadingScreen)
					If value IsNot Me.m_LoadingScreen Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of LoadingScreen)(Me.m_LoadingScreen)
					End If
				End Set
			End Property

			' Token: 0x17000B93 RID: 2963
			' (get) Token: 0x06001DAC RID: 7596 RVA: 0x001144D1 File Offset: 0x001126D1
			' (set) Token: 0x06001DD0 RID: 7632 RVA: 0x001149E0 File Offset: 0x00112BE0
			Public Property LocationMap As LocationMap
				<DebuggerHidden()>
				Get
					Me.m_LocationMap = MyProject.MyForms.Create__Instance__(Of LocationMap)(Me.m_LocationMap)
					Return Me.m_LocationMap
				End Get
				<DebuggerHidden()>
				Set(value As LocationMap)
					If value IsNot Me.m_LocationMap Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of LocationMap)(Me.m_LocationMap)
					End If
				End Set
			End Property

			' Token: 0x17000B94 RID: 2964
			' (get) Token: 0x06001DAD RID: 7597 RVA: 0x001144EC File Offset: 0x001126EC
			' (set) Token: 0x06001DD1 RID: 7633 RVA: 0x00114A0C File Offset: 0x00112C0C
			Public Property MDIMain As MDIMain
				<DebuggerHidden()>
				Get
					Me.m_MDIMain = MyProject.MyForms.Create__Instance__(Of MDIMain)(Me.m_MDIMain)
					Return Me.m_MDIMain
				End Get
				<DebuggerHidden()>
				Set(value As MDIMain)
					If value IsNot Me.m_MDIMain Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of MDIMain)(Me.m_MDIMain)
					End If
				End Set
			End Property

			' Token: 0x17000B95 RID: 2965
			' (get) Token: 0x06001DAE RID: 7598 RVA: 0x00114507 File Offset: 0x00112707
			' (set) Token: 0x06001DD2 RID: 7634 RVA: 0x00114A38 File Offset: 0x00112C38
			Public Property ModalTest As ModalTest
				<DebuggerHidden()>
				Get
					Me.m_ModalTest = MyProject.MyForms.Create__Instance__(Of ModalTest)(Me.m_ModalTest)
					Return Me.m_ModalTest
				End Get
				<DebuggerHidden()>
				Set(value As ModalTest)
					If value IsNot Me.m_ModalTest Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of ModalTest)(Me.m_ModalTest)
					End If
				End Set
			End Property

			' Token: 0x17000B96 RID: 2966
			' (get) Token: 0x06001DAF RID: 7599 RVA: 0x00114522 File Offset: 0x00112722
			' (set) Token: 0x06001DD3 RID: 7635 RVA: 0x00114A64 File Offset: 0x00112C64
			Public Property ModelSample As ModelSample
				<DebuggerHidden()>
				Get
					Me.m_ModelSample = MyProject.MyForms.Create__Instance__(Of ModelSample)(Me.m_ModelSample)
					Return Me.m_ModelSample
				End Get
				<DebuggerHidden()>
				Set(value As ModelSample)
					If value IsNot Me.m_ModelSample Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of ModelSample)(Me.m_ModelSample)
					End If
				End Set
			End Property

			' Token: 0x17000B97 RID: 2967
			' (get) Token: 0x06001DB0 RID: 7600 RVA: 0x0011453D File Offset: 0x0011273D
			' (set) Token: 0x06001DD4 RID: 7636 RVA: 0x00114A90 File Offset: 0x00112C90
			Public Property POApprovalRange As POApprovalRange
				<DebuggerHidden()>
				Get
					Me.m_POApprovalRange = MyProject.MyForms.Create__Instance__(Of POApprovalRange)(Me.m_POApprovalRange)
					Return Me.m_POApprovalRange
				End Get
				<DebuggerHidden()>
				Set(value As POApprovalRange)
					If value IsNot Me.m_POApprovalRange Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of POApprovalRange)(Me.m_POApprovalRange)
					End If
				End Set
			End Property

			' Token: 0x17000B98 RID: 2968
			' (get) Token: 0x06001DB1 RID: 7601 RVA: 0x00114558 File Offset: 0x00112758
			' (set) Token: 0x06001DD5 RID: 7637 RVA: 0x00114ABC File Offset: 0x00112CBC
			Public Property POReport As POReport
				<DebuggerHidden()>
				Get
					Me.m_POReport = MyProject.MyForms.Create__Instance__(Of POReport)(Me.m_POReport)
					Return Me.m_POReport
				End Get
				<DebuggerHidden()>
				Set(value As POReport)
					If value IsNot Me.m_POReport Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of POReport)(Me.m_POReport)
					End If
				End Set
			End Property

			' Token: 0x17000B99 RID: 2969
			' (get) Token: 0x06001DB2 RID: 7602 RVA: 0x00114573 File Offset: 0x00112773
			' (set) Token: 0x06001DD6 RID: 7638 RVA: 0x00114AE8 File Offset: 0x00112CE8
			Public Property ProductBOMList As ProductBOMList
				<DebuggerHidden()>
				Get
					Me.m_ProductBOMList = MyProject.MyForms.Create__Instance__(Of ProductBOMList)(Me.m_ProductBOMList)
					Return Me.m_ProductBOMList
				End Get
				<DebuggerHidden()>
				Set(value As ProductBOMList)
					If value IsNot Me.m_ProductBOMList Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of ProductBOMList)(Me.m_ProductBOMList)
					End If
				End Set
			End Property

			' Token: 0x17000B9A RID: 2970
			' (get) Token: 0x06001DB3 RID: 7603 RVA: 0x0011458E File Offset: 0x0011278E
			' (set) Token: 0x06001DD7 RID: 7639 RVA: 0x00114B14 File Offset: 0x00112D14
			Public Property QurantineReport As QurantineReport
				<DebuggerHidden()>
				Get
					Me.m_QurantineReport = MyProject.MyForms.Create__Instance__(Of QurantineReport)(Me.m_QurantineReport)
					Return Me.m_QurantineReport
				End Get
				<DebuggerHidden()>
				Set(value As QurantineReport)
					If value IsNot Me.m_QurantineReport Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of QurantineReport)(Me.m_QurantineReport)
					End If
				End Set
			End Property

			' Token: 0x17000B9B RID: 2971
			' (get) Token: 0x06001DB4 RID: 7604 RVA: 0x001145A9 File Offset: 0x001127A9
			' (set) Token: 0x06001DD8 RID: 7640 RVA: 0x00114B40 File Offset: 0x00112D40
			Public Property ReLogin As ReLogin
				<DebuggerHidden()>
				Get
					Me.m_ReLogin = MyProject.MyForms.Create__Instance__(Of ReLogin)(Me.m_ReLogin)
					Return Me.m_ReLogin
				End Get
				<DebuggerHidden()>
				Set(value As ReLogin)
					If value IsNot Me.m_ReLogin Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of ReLogin)(Me.m_ReLogin)
					End If
				End Set
			End Property

			' Token: 0x17000B9C RID: 2972
			' (get) Token: 0x06001DB5 RID: 7605 RVA: 0x001145C4 File Offset: 0x001127C4
			' (set) Token: 0x06001DD9 RID: 7641 RVA: 0x00114B6C File Offset: 0x00112D6C
			Public Property RequestReport As RequestReport
				<DebuggerHidden()>
				Get
					Me.m_RequestReport = MyProject.MyForms.Create__Instance__(Of RequestReport)(Me.m_RequestReport)
					Return Me.m_RequestReport
				End Get
				<DebuggerHidden()>
				Set(value As RequestReport)
					If value IsNot Me.m_RequestReport Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of RequestReport)(Me.m_RequestReport)
					End If
				End Set
			End Property

			' Token: 0x17000B9D RID: 2973
			' (get) Token: 0x06001DB6 RID: 7606 RVA: 0x001145DF File Offset: 0x001127DF
			' (set) Token: 0x06001DDA RID: 7642 RVA: 0x00114B98 File Offset: 0x00112D98
			Public Property StockValuation As StockValuation
				<DebuggerHidden()>
				Get
					Me.m_StockValuation = MyProject.MyForms.Create__Instance__(Of StockValuation)(Me.m_StockValuation)
					Return Me.m_StockValuation
				End Get
				<DebuggerHidden()>
				Set(value As StockValuation)
					If value IsNot Me.m_StockValuation Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of StockValuation)(Me.m_StockValuation)
					End If
				End Set
			End Property

			' Token: 0x17000B9E RID: 2974
			' (get) Token: 0x06001DB7 RID: 7607 RVA: 0x001145FA File Offset: 0x001127FA
			' (set) Token: 0x06001DDB RID: 7643 RVA: 0x00114BC4 File Offset: 0x00112DC4
			Public Property TCPPrinting As TCPPrinting
				<DebuggerHidden()>
				Get
					Me.m_TCPPrinting = MyProject.MyForms.Create__Instance__(Of TCPPrinting)(Me.m_TCPPrinting)
					Return Me.m_TCPPrinting
				End Get
				<DebuggerHidden()>
				Set(value As TCPPrinting)
					If value IsNot Me.m_TCPPrinting Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of TCPPrinting)(Me.m_TCPPrinting)
					End If
				End Set
			End Property

			' Token: 0x17000B9F RID: 2975
			' (get) Token: 0x06001DB8 RID: 7608 RVA: 0x00114615 File Offset: 0x00112815
			' (set) Token: 0x06001DDC RID: 7644 RVA: 0x00114BF0 File Offset: 0x00112DF0
			Public Property UnregisteredProducts As UnregisteredProducts
				<DebuggerHidden()>
				Get
					Me.m_UnregisteredProducts = MyProject.MyForms.Create__Instance__(Of UnregisteredProducts)(Me.m_UnregisteredProducts)
					Return Me.m_UnregisteredProducts
				End Get
				<DebuggerHidden()>
				Set(value As UnregisteredProducts)
					If value IsNot Me.m_UnregisteredProducts Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of UnregisteredProducts)(Me.m_UnregisteredProducts)
					End If
				End Set
			End Property

			' Token: 0x17000BA0 RID: 2976
			' (get) Token: 0x06001DB9 RID: 7609 RVA: 0x00114630 File Offset: 0x00112830
			' (set) Token: 0x06001DDD RID: 7645 RVA: 0x00114C1C File Offset: 0x00112E1C
			Public Property UploadStock As UploadStock
				<DebuggerHidden()>
				Get
					Me.m_UploadStock = MyProject.MyForms.Create__Instance__(Of UploadStock)(Me.m_UploadStock)
					Return Me.m_UploadStock
				End Get
				<DebuggerHidden()>
				Set(value As UploadStock)
					If value IsNot Me.m_UploadStock Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of UploadStock)(Me.m_UploadStock)
					End If
				End Set
			End Property

			' Token: 0x17000BA1 RID: 2977
			' (get) Token: 0x06001DBA RID: 7610 RVA: 0x0011464B File Offset: 0x0011284B
			' (set) Token: 0x06001DDE RID: 7646 RVA: 0x00114C48 File Offset: 0x00112E48
			Public Property UserGroup As UserGroup
				<DebuggerHidden()>
				Get
					Me.m_UserGroup = MyProject.MyForms.Create__Instance__(Of UserGroup)(Me.m_UserGroup)
					Return Me.m_UserGroup
				End Get
				<DebuggerHidden()>
				Set(value As UserGroup)
					If value IsNot Me.m_UserGroup Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of UserGroup)(Me.m_UserGroup)
					End If
				End Set
			End Property

			' Token: 0x17000BA2 RID: 2978
			' (get) Token: 0x06001DBB RID: 7611 RVA: 0x00114666 File Offset: 0x00112866
			' (set) Token: 0x06001DDF RID: 7647 RVA: 0x00114C74 File Offset: 0x00112E74
			Public Property UserMst As UserMst
				<DebuggerHidden()>
				Get
					Me.m_UserMst = MyProject.MyForms.Create__Instance__(Of UserMst)(Me.m_UserMst)
					Return Me.m_UserMst
				End Get
				<DebuggerHidden()>
				Set(value As UserMst)
					If value IsNot Me.m_UserMst Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of UserMst)(Me.m_UserMst)
					End If
				End Set
			End Property

			' Token: 0x17000BA3 RID: 2979
			' (get) Token: 0x06001DBC RID: 7612 RVA: 0x00114681 File Offset: 0x00112881
			' (set) Token: 0x06001DE0 RID: 7648 RVA: 0x00114CA0 File Offset: 0x00112EA0
			Public Property Vendor As Vendor
				<DebuggerHidden()>
				Get
					Me.m_Vendor = MyProject.MyForms.Create__Instance__(Of Vendor)(Me.m_Vendor)
					Return Me.m_Vendor
				End Get
				<DebuggerHidden()>
				Set(value As Vendor)
					If value IsNot Me.m_Vendor Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Vendor)(Me.m_Vendor)
					End If
				End Set
			End Property

			' Token: 0x04000CD5 RID: 3285
			<ThreadStatic()>
			Private Shared m_FormBeingCreated As Hashtable

			' Token: 0x04000CD6 RID: 3286
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_About As About

			' Token: 0x04000CD7 RID: 3287
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_ActivityLog As ActivityLog

			' Token: 0x04000CD8 RID: 3288
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_ApprovalRange As ApprovalRange

			' Token: 0x04000CD9 RID: 3289
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_AppUpdater As AppUpdater

			' Token: 0x04000CDA RID: 3290
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_Binning As Binning

			' Token: 0x04000CDB RID: 3291
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_BOMReport As BOMReport

			' Token: 0x04000CDC RID: 3292
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_ChangePass As ChangePass

			' Token: 0x04000CDD RID: 3293
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_ClosingStock As ClosingStock

			' Token: 0x04000CDE RID: 3294
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_ConsumptionReport As ConsumptionReport

			' Token: 0x04000CDF RID: 3295
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_Dashboard As Dashboard

			' Token: 0x04000CE0 RID: 3296
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_DashboardTest As DashboardTest

			' Token: 0x04000CE1 RID: 3297
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_Dispose As Dispose

			' Token: 0x04000CE2 RID: 3298
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_DisposeList As DisposeList

			' Token: 0x04000CE3 RID: 3299
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_EmailAlert As EmailAlert

			' Token: 0x04000CE4 RID: 3300
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_EmailTest As EmailTest

			' Token: 0x04000CE5 RID: 3301
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_Form1 As Form1

			' Token: 0x04000CE6 RID: 3302
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_Form2 As Form2

			' Token: 0x04000CE7 RID: 3303
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_GRNReport As GRNReport

			' Token: 0x04000CE8 RID: 3304
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_LoadingScreen As LoadingScreen

			' Token: 0x04000CE9 RID: 3305
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_LocationMap As LocationMap

			' Token: 0x04000CEA RID: 3306
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_MDIMain As MDIMain

			' Token: 0x04000CEB RID: 3307
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_ModalTest As ModalTest

			' Token: 0x04000CEC RID: 3308
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_ModelSample As ModelSample

			' Token: 0x04000CED RID: 3309
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_POApprovalRange As POApprovalRange

			' Token: 0x04000CEE RID: 3310
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_POReport As POReport

			' Token: 0x04000CEF RID: 3311
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_ProductBOMList As ProductBOMList

			' Token: 0x04000CF0 RID: 3312
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_QurantineReport As QurantineReport

			' Token: 0x04000CF1 RID: 3313
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_ReLogin As ReLogin

			' Token: 0x04000CF2 RID: 3314
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_RequestReport As RequestReport

			' Token: 0x04000CF3 RID: 3315
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_StockValuation As StockValuation

			' Token: 0x04000CF4 RID: 3316
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_TCPPrinting As TCPPrinting

			' Token: 0x04000CF5 RID: 3317
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_UnregisteredProducts As UnregisteredProducts

			' Token: 0x04000CF6 RID: 3318
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_UploadStock As UploadStock

			' Token: 0x04000CF7 RID: 3319
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_UserGroup As UserGroup

			' Token: 0x04000CF8 RID: 3320
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_UserMst As UserMst

			' Token: 0x04000CF9 RID: 3321
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_Vendor As Vendor
		End Class

		' Token: 0x0200006F RID: 111
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		Friend NotInheritable Class MyWebServices
			' Token: 0x06001DE1 RID: 7649 RVA: 0x00114CCC File Offset: 0x00112ECC
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x06001DE2 RID: 7650 RVA: 0x00114CEC File Offset: 0x00112EEC
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x06001DE3 RID: 7651 RVA: 0x00114D04 File Offset: 0x00112F04
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyWebServices)
			End Function

			' Token: 0x06001DE4 RID: 7652 RVA: 0x00114D20 File Offset: 0x00112F20
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x06001DE5 RID: 7653 RVA: 0x00114D38 File Offset: 0x00112F38
			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As New)(instance As T) As T
				Dim flag As Boolean = instance Is Nothing
				Dim t As T
				If flag Then
					t = New T()
				Else
					t = instance
				End If
				Return t
			End Function

			' Token: 0x06001DE6 RID: 7654 RVA: 0x00114D61 File Offset: 0x00112F61
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T)(ByRef instance As T)
				instance = Nothing
			End Sub

			' Token: 0x06001DE7 RID: 7655 RVA: 0x00114D6B File Offset: 0x00112F6B
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub
		End Class

		' Token: 0x02000070 RID: 112
		<EditorBrowsable(EditorBrowsableState.Never)>
		<ComVisible(False)>
		Friend NotInheritable Class ThreadSafeObjectProvider(Of T As New)
			' Token: 0x17000BA4 RID: 2980
			' (get) Token: 0x06001DE8 RID: 7656 RVA: 0x00114D78 File Offset: 0x00112F78
			Friend ReadOnly Property GetInstance As T
				<DebuggerHidden()>
				Get
					Dim flag As Boolean = MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue Is Nothing
					If flag Then
						MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue = New T()
					End If
					Return MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue
				End Get
			End Property

			' Token: 0x06001DE9 RID: 7657 RVA: 0x00114DAA File Offset: 0x00112FAA
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub

			' Token: 0x04000CFA RID: 3322
			<CompilerGenerated()>
			<ThreadStatic()>
			Private Shared m_ThreadStaticValue As T
		End Class
	End Module
End Namespace
