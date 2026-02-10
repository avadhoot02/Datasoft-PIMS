Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Datasoft_PIMS.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x02000008 RID: 8
	<DesignerGenerated()>
	Public NotInheritable Partial Class About
		Inherits Form

		' Token: 0x0600001F RID: 31 RVA: 0x00002457 File Offset: 0x00000657
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.About_Load
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000011 RID: 17
		' (get) Token: 0x06000022 RID: 34 RVA: 0x00002AA5 File Offset: 0x00000CA5
		' (set) Token: 0x06000023 RID: 35 RVA: 0x00002AAF File Offset: 0x00000CAF
		Friend Property TextBoxDescription As Label

		' Token: 0x17000012 RID: 18
		' (get) Token: 0x06000024 RID: 36 RVA: 0x00002AB8 File Offset: 0x00000CB8
		' (set) Token: 0x06000025 RID: 37 RVA: 0x00002AC2 File Offset: 0x00000CC2
		Friend Property LabelCompanyName As Label

		' Token: 0x17000013 RID: 19
		' (get) Token: 0x06000026 RID: 38 RVA: 0x00002ACB File Offset: 0x00000CCB
		' (set) Token: 0x06000027 RID: 39 RVA: 0x00002AD5 File Offset: 0x00000CD5
		Friend Property LabelCopyright As Label

		' Token: 0x17000014 RID: 20
		' (get) Token: 0x06000028 RID: 40 RVA: 0x00002ADE File Offset: 0x00000CDE
		' (set) Token: 0x06000029 RID: 41 RVA: 0x00002AE8 File Offset: 0x00000CE8
		Friend Property LabelAppVersion As Label

		' Token: 0x17000015 RID: 21
		' (get) Token: 0x0600002A RID: 42 RVA: 0x00002AF1 File Offset: 0x00000CF1
		' (set) Token: 0x0600002B RID: 43 RVA: 0x00002AFB File Offset: 0x00000CFB
		Friend Property LabelProductName As Label

		' Token: 0x17000016 RID: 22
		' (get) Token: 0x0600002C RID: 44 RVA: 0x00002B04 File Offset: 0x00000D04
		' (set) Token: 0x0600002D RID: 45 RVA: 0x00002B0E File Offset: 0x00000D0E
		Friend Property lableSysVersion As Label

		' Token: 0x0600002E RID: 46 RVA: 0x00002B18 File Offset: 0x00000D18
		Private Sub About_Load(sender As Object, e As EventArgs)
			Me.BackgroundImage = ResourceModule.imgAbout
			Dim text As String = AppDomain.CurrentDomain.BaseDirectory.ToString()
			Dim text2 As String = "Systems.dll"
			Dim versionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(text + "\" + text2)
			Dim flag As Boolean = Operators.CompareString(MyProject.Application.Info.Title, "", False) <> 0
			Dim text3 As String
			If flag Then
				text3 = MyProject.Application.Info.Title
			Else
				text3 = Path.GetFileNameWithoutExtension(MyProject.Application.Info.AssemblyName)
			End If
			Me.Text = String.Format("About {0}", text3)
			Me.LabelProductName.Text = MyProject.Application.Info.ProductName
			Me.LabelAppVersion.Text = String.Format("Application Version : {0}", MyProject.Application.Info.Version.ToString())
			Me.lableSysVersion.Text = String.Format("System Version : {0}", versionInfo.FileVersion)
			Me.LabelCopyright.Text = MyProject.Application.Info.Copyright
			Me.LabelCompanyName.Text = "Immunoadoptive Cell Therapy Private Limited"
			Me.TextBoxDescription.Text = If(GlobalVariables.sSDate, "")
		End Sub

		' Token: 0x0600002F RID: 47 RVA: 0x00002C60 File Offset: 0x00000E60
		Private Sub OKButton_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub
	End Class
End Namespace
