Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Configuration
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS.My
	' Token: 0x02000006 RID: 6
	<CompilerGenerated()>
	<GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")>
	<EditorBrowsable(EditorBrowsableState.Advanced)>
	Friend NotInheritable Partial Class MySettings
		Inherits ApplicationSettingsBase

		' Token: 0x06000011 RID: 17 RVA: 0x00002260 File Offset: 0x00000460
		<DebuggerNonUserCode()>
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Private Shared Sub AutoSaveSettings(sender As Object, e As EventArgs)
			Dim saveMySettingsOnExit As Boolean = MyProject.Application.SaveMySettingsOnExit
			If saveMySettingsOnExit Then
				MySettingsProperty.Settings.Save()
			End If
		End Sub

		' Token: 0x17000009 RID: 9
		' (get) Token: 0x06000012 RID: 18 RVA: 0x0000228C File Offset: 0x0000048C
		Public Shared ReadOnly Property [Default] As MySettings
			Get
				Dim flag As Boolean = Not MySettings.addedHandler
				If flag Then
					Dim obj As Object = MySettings.addedHandlerLockObject
					ObjectFlowControl.CheckForSyncLockOnValueType(obj)
					SyncLock obj
						Dim flag3 As Boolean = Not MySettings.addedHandler
						If flag3 Then
							AddHandler MyProject.Application.Shutdown, AddressOf MySettings.AutoSaveSettings
							MySettings.addedHandler = True
						End If
					End SyncLock
				End If
				Return MySettings.defaultInstance
			End Get
		End Property

		' Token: 0x1700000A RID: 10
		' (get) Token: 0x06000013 RID: 19 RVA: 0x00002318 File Offset: 0x00000518
		<ApplicationScopedSetting()>
		<DebuggerNonUserCode()>
		<SpecialSetting(SpecialSetting.ConnectionString)>
		<DefaultSettingValue("Data Source=ANWAR-PC\SQLEXPRESS;Initial Catalog=DatasoftTnT;Integrated Security =True")>
		Public ReadOnly Property sConfigConStr As String
			Get
				Return Conversions.ToString(Me("sConfigConStr"))
			End Get
		End Property

		' Token: 0x1700000B RID: 11
		' (get) Token: 0x06000014 RID: 20 RVA: 0x0000233C File Offset: 0x0000053C
		' (set) Token: 0x06000015 RID: 21 RVA: 0x0000235E File Offset: 0x0000055E
		<UserScopedSetting()>
		<DebuggerNonUserCode()>
		<DefaultSettingValue("Anwar")>
		Public Property sConfigCompany As String
			Get
				Return Conversions.ToString(Me("sConfigCompany"))
			End Get
			Set(value As String)
				Me("sConfigCompany") = value
			End Set
		End Property

		' Token: 0x1700000C RID: 12
		' (get) Token: 0x06000016 RID: 22 RVA: 0x00002370 File Offset: 0x00000570
		' (set) Token: 0x06000017 RID: 23 RVA: 0x00002392 File Offset: 0x00000592
		<UserScopedSetting()>
		<DebuggerNonUserCode()>
		<DefaultSettingValue("Datacode")>
		Public Property sConfigMailHost As String
			Get
				Return Conversions.ToString(Me("sConfigMailHost"))
			End Get
			Set(value As String)
				Me("sConfigMailHost") = value
			End Set
		End Property

		' Token: 0x1700000D RID: 13
		' (get) Token: 0x06000018 RID: 24 RVA: 0x000023A4 File Offset: 0x000005A4
		' (set) Token: 0x06000019 RID: 25 RVA: 0x000023C6 File Offset: 0x000005C6
		<UserScopedSetting()>
		<DebuggerNonUserCode()>
		<DefaultSettingValue("http://datacodeindia.com")>
		Public Property sConfigQRUrl As String
			Get
				Return Conversions.ToString(Me("sConfigQRUrl"))
			End Get
			Set(value As String)
				Me("sConfigQRUrl") = value
			End Set
		End Property

		' Token: 0x1700000E RID: 14
		' (get) Token: 0x0600001A RID: 26 RVA: 0x000023D8 File Offset: 0x000005D8
		' (set) Token: 0x0600001B RID: 27 RVA: 0x000023FA File Offset: 0x000005FA
		<UserScopedSetting()>
		<DebuggerNonUserCode()>
		<DefaultSettingValue("")>
		Public Property sPath As String
			Get
				Return Conversions.ToString(Me("sPath"))
			End Get
			Set(value As String)
				Me("sPath") = value
			End Set
		End Property

		' Token: 0x1700000F RID: 15
		' (get) Token: 0x0600001C RID: 28 RVA: 0x0000240C File Offset: 0x0000060C
		' (set) Token: 0x0600001D RID: 29 RVA: 0x0000242E File Offset: 0x0000062E
		<UserScopedSetting()>
		<DebuggerNonUserCode()>
		<DefaultSettingValue("False")>
		Public Property sConfigIsSandbox As String
			Get
				Return Conversions.ToString(Me("sConfigIsSandbox"))
			End Get
			Set(value As String)
				Me("sConfigIsSandbox") = value
			End Set
		End Property

		' Token: 0x04000008 RID: 8
		Private Shared defaultInstance As MySettings = CType(SettingsBase.Synchronized(New MySettings()), MySettings)

		' Token: 0x04000009 RID: 9
		Private Shared addedHandler As Boolean

		' Token: 0x0400000A RID: 10
		Private Shared addedHandlerLockObject As Object = RuntimeHelpers.GetObjectValue(New Object())
	End Class
End Namespace
