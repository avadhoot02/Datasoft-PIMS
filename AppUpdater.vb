Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x0200004F RID: 79
	<DesignerGenerated()>
	Public Partial Class AppUpdater
		Inherits Form

		' Token: 0x06000E2F RID: 3631 RVA: 0x0007F618 File Offset: 0x0007D818
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.AppUpdater_Load
			Me.sAppPath = Strings.Replace(AppDomain.CurrentDomain.BaseDirectory.ToString() + "\", "\\", "\", 1, -1, CompareMethod.Binary)
			Me.sUpdater = "E:\Laptop\Application\RnD\AppUpdater\AppUpdater\AppUpdater\bin\Debug\AppUpdater.exe"
			Me.InitializeComponent()
		End Sub

		' Token: 0x1700054F RID: 1359
		' (get) Token: 0x06000E32 RID: 3634 RVA: 0x0007FA02 File Offset: 0x0007DC02
		' (set) Token: 0x06000E33 RID: 3635 RVA: 0x0007FA0C File Offset: 0x0007DC0C
		Friend Overridable Property dgvList As DataGridView

		' Token: 0x17000550 RID: 1360
		' (get) Token: 0x06000E34 RID: 3636 RVA: 0x0007FA15 File Offset: 0x0007DC15
		' (set) Token: 0x06000E35 RID: 3637 RVA: 0x0007FA20 File Offset: 0x0007DC20
		Friend Overridable Property btnCheck As Button
			<CompilerGenerated()>
			Get
				Return Me._btnCheck
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnCheck_Click
				Dim button As Button = Me._btnCheck
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnCheck = value
				button = Me._btnCheck
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x06000E36 RID: 3638 RVA: 0x0007FA63 File Offset: 0x0007DC63
		Private Sub AppUpdater_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000E37 RID: 3639 RVA: 0x0007FA66 File Offset: 0x0007DC66
		Private Sub btnCheck_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000E38 RID: 3640 RVA: 0x0007FA6C File Offset: 0x0007DC6C
		Private Sub CheckFunction()
			Dim arrayList As ArrayList = New ArrayList()
			Dim text As String = " UPDATE Info SET InfoVersion = @Field1, InfoFile = @Field2 WHERE InfoType='UI' "
			Dim num As Integer = 0
			Dim num2 As Integer = 1
			Dim num3 As Double = 2.5
			Dim num4 As Decimal = 3.5D
			Dim text2 As String = "123"
			Dim dateTime As DateTime = Conversions.ToDate("31-Oct-2025")
			Dim array As Byte() = File.ReadAllBytes(GlobalVariables.gsPath + "\Systems.dll")
			arrayList.Add(num)
			arrayList.Add(num2)
			arrayList.Add(num3)
			arrayList.Add(num4)
			arrayList.Add(text2)
			arrayList.Add(dateTime)
			arrayList.Add(array)
			Me.ExecuteSQLParam(text, arrayList)
		End Sub

		' Token: 0x06000E39 RID: 3641 RVA: 0x0007FB2C File Offset: 0x0007DD2C
		Private Sub AppUpdater()
			Dim text As String = "Systems.dll"
			Dim text2 As String = Strings.Replace(AppDomain.CurrentDomain.FriendlyName, ".vshost", "", 1, -1, CompareMethod.Binary)
			Dim text3 As String = """" + GlobalVariables.gsConStr + """ "
			text3 = text3 + """" + GlobalVariables.gsPath + """ "
			text3 = text3 + """" + text + """ "
			text3 = text3 + """" + text2 + """ "
			Dim flag As Boolean = Not File.Exists(Me.sUpdater)
			If flag Then
			End If
			Process.Start(New ProcessStartInfo() With { .FileName = Me.sUpdater, .Arguments = text3, .UseShellExecute = False })
		End Sub

		' Token: 0x06000E3A RID: 3642 RVA: 0x0007FBEC File Offset: 0x0007DDEC
		Private Function VerifyVersion() As Boolean
			' The following expression was wrapped in a checked-statement
			Dim flag12 As Boolean
			Try
				Dim text As String = "Systems.dll"
				Dim text2 As String = Strings.Replace(AppDomain.CurrentDomain.FriendlyName, ".vshost", "", 1, -1, CompareMethod.Binary)
				Dim text3 As String = Strings.Replace(text2, ".exe", "", 1, -1, CompareMethod.Binary)
				Dim text4 As String = text3 + "-UI.dll"
				Dim flag As Boolean = File.Exists(GlobalVariables.gsPath + "\" + text)
				If flag Then
					GlobalVariables.gsSysVersionInfo = FileVersionInfo.GetVersionInfo(GlobalVariables.gsPath + "\" + text)
				End If
				Dim flag2 As Boolean = File.Exists(GlobalVariables.gsPath + "\" + text2)
				If flag2 Then
					GlobalVariables.gsAppVersionInfo = FileVersionInfo.GetVersionInfo(GlobalVariables.gsPath + "\" + text2)
				End If
				Dim flag3 As Boolean = File.Exists(GlobalVariables.gsPath + "\" + text4)
				If flag3 Then
					GlobalVariables.gsUIVersionInfo = FileVersionInfo.GetVersionInfo(GlobalVariables.gsPath + "\" + text4)
				End If
				Dim text5 As String = "SELECT InfoID, InfoType, '' AS InfoVersion, InfoVersion As EnInfoVersion, InfoFileName, InfoFile FROM Info"
				Dim dataTable As DataTable = MainModule.CheckConnection(text5)
				Dim flag4 As Boolean = dataTable.Rows.Count > 1
				If flag4 Then
					Dim num As Integer = dataTable.Rows.Count - 1
					For i As Integer = 0 To num
						dataTable.Rows(i)("InfoVersion") = MainModule.DecryptData(Conversions.ToString(dataTable.Rows(i)("EnInfoVersion")), GlobalVariables.gsPwd)
					Next
					Dim array As DataRow() = dataTable.[Select]("InfoType = 'System'")
					Dim array2 As DataRow() = dataTable.[Select]("InfoType = 'Application'")
					Dim array3 As DataRow() = dataTable.[Select]("InfoType = 'UI'")
					Dim flag5 As Boolean = array.Length > 0
					Dim flag6 As Boolean
					If flag5 Then
						Dim version As Version = New Version(Conversions.ToString(array(0)("InfoVersion")))
						Select Case CShort(GlobalVariables.gsSysVersionInfo.FileVersion.CompareTo(version.ToString()))
							Case -1S
								flag6 = False
							Case 0S
								flag6 = True
							Case 1S
								flag6 = False
								Dim arrayList As ArrayList = New ArrayList()
								arrayList.Add(MainModule.EncryptData(GlobalVariables.gsSysVersionInfo.FileVersion, GlobalVariables.gsPwd))
								arrayList.Add(File.ReadAllBytes(GlobalVariables.gsPath + "\" + text))
								text5 = "UPDATE Info SET InfoVersion = @Field1, InfoFile = @Field2  WHERE InfoType = 'System'"
								flag6 = Me.ExecuteSQLParam(text5, arrayList)
						End Select
					Else
						flag6 = True
					End If
					Dim flag7 As Boolean = array2.Length > 0
					Dim flag8 As Boolean
					If flag7 Then
						Dim version2 As Version = New Version(Conversions.ToString(array2(0)("InfoVersion")))
						Select Case CShort(GlobalVariables.gsAppVersionInfo.FileVersion.CompareTo(version2.ToString()))
							Case -1S
								flag8 = False
							Case 0S
								flag8 = True
							Case 1S
								flag8 = False
								Dim arrayList2 As ArrayList = New ArrayList()
								arrayList2.Add(MainModule.EncryptData(GlobalVariables.gsAppVersionInfo.FileVersion, GlobalVariables.gsPwd))
								arrayList2.Add(File.ReadAllBytes(GlobalVariables.gsPath + "\" + text2))
								text5 = "UPDATE Info SET InfoVersion = @Field1, InfoFile = @Field2  WHERE InfoType = 'Application'"
								flag8 = Me.ExecuteSQLParam(text5, arrayList2)
						End Select
					Else
						flag8 = True
					End If
					Dim flag9 As Boolean = array3.Length > 0
					Dim flag10 As Boolean
					If flag9 Then
						Dim version3 As Version = New Version(Conversions.ToString(array3(0)("InfoVersion")))
						Select Case CShort(GlobalVariables.gsUIVersionInfo.FileVersion.CompareTo(version3.ToString()))
							Case -1S
								flag10 = False
							Case 0S
								flag10 = True
							Case 1S
								flag10 = False
								Dim arrayList3 As ArrayList = New ArrayList()
								arrayList3.Add(MainModule.EncryptData(GlobalVariables.gsUIVersionInfo.FileVersion, GlobalVariables.gsPwd))
								arrayList3.Add(File.ReadAllBytes(GlobalVariables.gsPath + "\" + text4))
								text5 = "UPDATE Info SET InfoVersion = @Field1, InfoFile = @Field2  WHERE InfoType = 'UI'"
								flag8 = Me.ExecuteSQLParam(text5, arrayList3)
						End Select
					Else
						flag10 = True
					End If
					Dim flag11 As Boolean = flag6 AndAlso flag8 AndAlso flag10
					If flag11 Then
						flag12 = True
					Else
						Dim flag13 As Boolean = CustomMsgBox.Show("Application Update Required. " & vbCrLf & "Proceed To Update..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
						If flag13 Then
							Dim flag14 As Boolean = Not Directory.Exists(GlobalVariables.gsPath + "\Updates")
							If flag14 Then
								Directory.CreateDirectory(GlobalVariables.gsPath + "\Updates")
							End If
							Dim flag15 As Boolean = Not flag6
							If flag15 Then
								Dim array4 As Byte() = CType(array(0)("InfoFile"), Byte())
								Dim flag16 As Boolean = File.Exists(GlobalVariables.gsPath + "\Updates\" + text)
								If flag16 Then
									File.Delete(GlobalVariables.gsPath + "\Updates\" + text)
								End If
								File.WriteAllBytes(GlobalVariables.gsPath + "\Updates\" + text, array4)
							End If
							Dim flag17 As Boolean = Not flag8
							If flag17 Then
								Dim array5 As Byte() = CType(array2(0)("InfoFile"), Byte())
								Dim flag18 As Boolean = File.Exists(GlobalVariables.gsPath + "\Updates\" + text2)
								If flag18 Then
									File.Delete(GlobalVariables.gsPath + "\Updates\" + text2)
								End If
								File.WriteAllBytes(GlobalVariables.gsPath + "\Updates\" + text2, array5)
							End If
							Dim flag19 As Boolean = Not flag10
							If flag19 Then
								Dim array6 As Byte() = CType(array3(0)("InfoFile"), Byte())
								Dim flag20 As Boolean = File.Exists(GlobalVariables.gsPath + "\Updates\" + text4)
								If flag20 Then
									File.Delete(GlobalVariables.gsPath + "\Updates\" + text4)
								End If
								File.WriteAllBytes(GlobalVariables.gsPath + "\Updates\" + text4, array6)
							End If
							Me.CallAppUpdater(text, text2, text4)
						End If
						Environment.[Exit](0)
						flag12 = False
					End If
				Else
					flag12 = False
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				flag12 = False
			End Try
			Return flag12
		End Function

		' Token: 0x06000E3B RID: 3643 RVA: 0x00080210 File Offset: 0x0007E410
		Private Function ExecuteSQLParam(sSQL As String, arrList As ArrayList) As Boolean
			Dim flag As Boolean = Operators.CompareString(sSQL, "", False) = 0
			If flag Then
				sSQL = "SELECT GETDATE()"
			End If
			Dim sqlConnection As SqlConnection = New SqlConnection(GlobalVariables.gsConStr)
			Dim sqlCommand As SqlCommand = New SqlCommand(sSQL, sqlConnection)
			Dim num As Integer = arrList.Count - 1
			For i As Integer = 0 To num
				Dim text As String = arrList(i).[GetType]().ToString()
				If Operators.CompareString(text, "System.Int32", False) <> 0 AndAlso Operators.CompareString(text, "System.Double", False) <> 0 AndAlso Operators.CompareString(text, "System.Decimal", False) <> 0 AndAlso Operators.CompareString(text, "System.DateTime", False) <> 0 Then
					If Operators.CompareString(text, "System.String", False) <> 0 Then
						If Operators.CompareString(text, "System.Byte[]", False) = 0 Then
							sqlCommand.Parameters.Add("@Field" + Conversions.ToString(i + 1), SqlDbType.VarBinary, -1).Value = RuntimeHelpers.GetObjectValue(arrList(i))
						End If
					Else
						sqlCommand.Parameters.Add("@Field" + Conversions.ToString(i + 1), SqlDbType.NVarChar).Value = RuntimeHelpers.GetObjectValue(arrList(i))
					End If
				Else
					sqlCommand.Parameters.Add("@Field" + Conversions.ToString(i + 1), SqlDbType.[Variant]).Value = RuntimeHelpers.GetObjectValue(arrList(i))
				End If
			Next
			sqlCommand.CommandTimeout = 500
			sqlConnection.Open()
			sqlCommand.ExecuteNonQuery()
			sqlConnection.Close()
			Return True
		End Function

		' Token: 0x06000E3C RID: 3644 RVA: 0x000803AC File Offset: 0x0007E5AC
		Private Sub CallAppUpdater(sSysFile As String, sAppFile As String, sUIFile As String)
			Dim text As String = GlobalVariables.gsPath + "\AppUpdater.exe"
			Dim text2 As String = """" + GlobalVariables.gsPath + """ "
			text2 = text2 + """" + sSysFile + """ "
			text2 = text2 + """" + sAppFile + """ "
			text2 = text2 + """" + sUIFile + """"
			Dim flag As Boolean = Not File.Exists(text)
			If flag Then
				CustomMsgBox.Show("Error : App Updater Not Found.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			Else
				Process.Start(New ProcessStartInfo() With { .FileName = text, .Arguments = text2, .UseShellExecute = False })
			End If
		End Sub

		' Token: 0x040005DC RID: 1500
		Private sAppPath As String

		' Token: 0x040005DD RID: 1501
		Private sUpdater As String
	End Class
End Namespace
