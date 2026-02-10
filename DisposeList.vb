Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Datasoft_PIMS.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x02000051 RID: 81
	<DesignerGenerated()>
	Public Partial Class DisposeList
		Inherits Form

		' Token: 0x06000E53 RID: 3667 RVA: 0x00081DA0 File Offset: 0x0007FFA0
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.DisposeList_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000558 RID: 1368
		' (get) Token: 0x06000E56 RID: 3670 RVA: 0x00081FF2 File Offset: 0x000801F2
		' (set) Token: 0x06000E57 RID: 3671 RVA: 0x00081FFC File Offset: 0x000801FC
		Friend Overridable Property btnRead As Button
			<CompilerGenerated()>
			Get
				Return Me._btnRead
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnRead_Click
				Dim button As Button = Me._btnRead
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnRead = value
				button = Me._btnRead
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000559 RID: 1369
		' (get) Token: 0x06000E58 RID: 3672 RVA: 0x0008203F File Offset: 0x0008023F
		' (set) Token: 0x06000E59 RID: 3673 RVA: 0x00082049 File Offset: 0x00080249
		Friend Overridable Property dgv1 As DataGridView

		' Token: 0x06000E5A RID: 3674 RVA: 0x00082052 File Offset: 0x00080252
		Private Sub DisposeList_Load(sender As Object, e As EventArgs)
			Me.sPath = MySettingsProperty.Settings.sPath
		End Sub

		' Token: 0x06000E5B RID: 3675 RVA: 0x00082068 File Offset: 0x00080268
		Private Sub btnRead_Click(sender As Object, e As EventArgs)
			Dim dataTable As DataTable = MainModule.ReadExcelFile("xlsx", Me.sPath, "Sheet6", "")
			Me.dgv1.DataSource = dataTable
		End Sub

		' Token: 0x040005EA RID: 1514
		Private sPath As String
	End Class
End Namespace
