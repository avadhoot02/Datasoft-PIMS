Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms
Imports Datasoft_PIMS.My
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Systems

Namespace Datasoft_PIMS
	' Token: 0x02000032 RID: 50
	Friend NotInheritable Module MainModule
		' Token: 0x06000B83 RID: 2947 RVA: 0x0006CB18 File Offset: 0x0006AD18
		Public Function SetConnectionString(ByRef dtResult As DataTable) As Boolean
			dtResult.Rows.Clear()
			Dim flag4 As Boolean
			Try
				Dim sConfigCompany As String = MySettingsProperty.Settings.sConfigCompany
				Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(sConfigCompany)
				If num <= 1779622119UI Then
					If num <> 198317500UI Then
						If num <> 1035924105UI Then
							If num = 1779622119UI Then
								If Operators.CompareString(sConfigCompany, "Config", False) = 0 Then
									GlobalVariables.gsConStr = MySettingsProperty.Settings.sConfigConStr.ToString()
								End If
							End If
						ElseIf Operators.CompareString(sConfigCompany, "Avadhoot", False) = 0 Then
							GlobalVariables.gsConStr = "Data Source=AVADHOOT\SQLEXPRESS;Initial Catalog=Datasoft-PIMS;Persist Security Info=True;User ID=sa;Password=admin123"
						End If
					ElseIf Operators.CompareString(sConfigCompany, "Anwar", False) = 0 Then
						GlobalVariables.gsConStr = "Data Source=ANWAR\SQLEXPRESS;Initial Catalog=Datasoft-PIMS-Sandbox;Persist Security Info=True;User ID=sa;Password=Data$Code#"
					End If
				ElseIf num <= 3332973484UI Then
					If num <> 2884176116UI Then
						If num = 3332973484UI Then
							If Operators.CompareString(sConfigCompany, "Amar", False) = 0 Then
								GlobalVariables.gsConStr = "Data Source=DESKTOP-CG5BL2T;Initial Catalog=DatasoftTnTRussia07July20;Integrated Security =True;User ID=sa;Password=amar"
							End If
						End If
					ElseIf Operators.CompareString(sConfigCompany, "Datacode", False) <> 0 Then
					End If
				ElseIf num <> 3347834262UI Then
					If num = 3752360223UI Then
						If Operators.CompareString(sConfigCompany, "Akash", False) = 0 Then
							GlobalVariables.gsConStr = "Data Source=DESKTOP-P2AGGGM;Initial Catalog=Datasoft-PIMS;Persist Security Info=True;User ID=sa;Password=datacode@123"
						End If
					End If
				ElseIf Operators.CompareString(sConfigCompany, "ImmunoACT", False) = 0 Then
					Dim flag As Boolean = Operators.CompareString(MySettingsProperty.Settings.sConfigIsSandbox, "True", False) = 0
					If flag Then
						GlobalVariables.gsConStr = "Data Source=192.168.10.11,1433;Initial Catalog=Datasoft-PIMS-Sandbox;Persist Security Info=True;User ID=sa;Password=P@ss123*"
					Else
						GlobalVariables.gsConStr = "Data Source=192.168.10.11,1433;Initial Catalog=Datasoft-PIMS;Persist Security Info=True;User ID=sa;Password=P@ss123*"
					End If
				End If
				Dim flag2 As Boolean = Operators.CompareString(GlobalVariables.gsConStr, "", False) <> 0
				If flag2 Then
					MainModule.GetConnectionDtls()
					Dim dataTable As DataTable = MainModule.CheckConnection("")
					Dim flag3 As Boolean = Operators.CompareString(dataTable.Columns(0).ColumnName, "ErrorColumn", False) <> 0
					If flag3 Then
						dtResult.Rows.Add(New Object(-1) {})
						dtResult.Rows(0)("ResultStatus") = "Success"
						dtResult.Rows(0)("ResultMessage") = ""
						flag4 = True
					Else
						dtResult.Rows.Add(New Object(-1) {})
						dtResult.Rows(0)("ResultStatus") = "Fail"
						dtResult.Rows(0)("ResultMessage") = dataTable.Rows(0)(0).ToString()
						flag4 = False
					End If
				Else
					dtResult.Rows.Add(New Object(-1) {})
					dtResult.Rows(0)("ResultStatus") = "Fail"
					dtResult.Rows(0)("ResultMessage") = "Connection string is empty."
					flag4 = False
				End If
			Catch ex As Exception
				dtResult.Rows.Add(New Object(-1) {})
				dtResult.Rows(0)("ResultStatus") = "Fail"
				dtResult.Rows(0)("ResultMessage") = "Setting Missing : " + ex.Message
				flag4 = False
			End Try
			Return flag4
		End Function

		' Token: 0x06000B84 RID: 2948 RVA: 0x0006CEA8 File Offset: 0x0006B0A8
		Public Function VerifyVersion(ByRef dtResult As DataTable) As Boolean
			dtResult.Rows.Clear()
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
								flag6 = MainModule.ExecuteSQLParam(text5, arrayList)
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
								flag8 = MainModule.ExecuteSQLParam(text5, arrayList2)
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
								flag10 = MainModule.ExecuteSQLParam(text5, arrayList3)
						End Select
					Else
						flag10 = True
					End If
					Dim flag11 As Boolean = flag6 AndAlso flag8 AndAlso flag10
					If flag11 Then
						dtResult.Rows.Add(New Object(-1) {})
						dtResult.Rows(0)("ResultStatus") = "Success"
						dtResult.Rows(0)("ResultMessage") = ""
						flag12 = True
					Else
						Dim flag13 As Boolean = Not Directory.Exists(GlobalVariables.gsPath + "\Updates")
						If flag13 Then
							Directory.CreateDirectory(GlobalVariables.gsPath + "\Updates")
						End If
						Dim flag14 As Boolean = Not flag6
						If flag14 Then
							Dim array4 As Byte() = CType(array(0)("InfoFile"), Byte())
							Dim flag15 As Boolean = File.Exists(GlobalVariables.gsPath + "\Updates\" + text)
							If flag15 Then
								File.Delete(GlobalVariables.gsPath + "\Updates\" + text)
							End If
							File.WriteAllBytes(GlobalVariables.gsPath + "\Updates\" + text, array4)
						End If
						Dim flag16 As Boolean = Not flag8
						If flag16 Then
							Dim array5 As Byte() = CType(array2(0)("InfoFile"), Byte())
							Dim flag17 As Boolean = File.Exists(GlobalVariables.gsPath + "\Updates\" + text2)
							If flag17 Then
								File.Delete(GlobalVariables.gsPath + "\Updates\" + text2)
							End If
							File.WriteAllBytes(GlobalVariables.gsPath + "\Updates\" + text2, array5)
						End If
						Dim flag18 As Boolean = Not flag10
						If flag18 Then
							Dim array6 As Byte() = CType(array3(0)("InfoFile"), Byte())
							Dim flag19 As Boolean = File.Exists(GlobalVariables.gsPath + "\Updates\" + text4)
							If flag19 Then
								File.Delete(GlobalVariables.gsPath + "\Updates\" + text4)
							End If
							File.WriteAllBytes(GlobalVariables.gsPath + "\Updates\" + text4, array6)
						End If
						MainModule.CallAppUpdater(text, text2, text4)
						Environment.[Exit](0)
						flag12 = False
					End If
				Else
					Dim flag20 As Boolean = dataTable.Columns.Contains("ErrorColumn")
					If flag20 Then
						Dim text6 As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable.Rows(0)("ErrorColumn"), " : "), vbCrLf))
						text6 = Conversions.ToString(Operators.AddObject(text6, dataTable.Rows(0)("ExceptionMsg")))
						dtResult.Rows.Add(New Object(-1) {})
						dtResult.Rows(0)("ResultStatus") = "Fail"
						dtResult.Rows(0)("ResultMessage") = text6
					End If
					flag12 = False
				End If
			Catch ex As Exception
				dtResult.Rows.Add(New Object(-1) {})
				dtResult.Rows(0)("ResultStatus") = "Fail"
				dtResult.Rows(0)("ResultMessage") = "Setting Missing : " + ex.Message
				flag12 = False
			End Try
			Return flag12
		End Function

		' Token: 0x06000B85 RID: 2949 RVA: 0x0006D5F8 File Offset: 0x0006B7F8
		Public Function VerifiyClient(ByRef dtResult As DataTable) As Boolean
			dtResult.Rows.Clear()
			Dim flag As Boolean = Operators.CompareString(FeaturesVariables.gsWebVerify, "No", False) = 0
			Dim flag2 As Boolean
			If flag Then
				dtResult.Rows.Add(New Object(-1) {})
				dtResult.Rows(0)("ResultStatus") = "Success"
				dtResult.Rows(0)("ResultMessage") = ""
				flag2 = True
			Else
				Dim flag3 As Boolean = Not MainModule.CheckInternet()
				If flag3 Then
					dtResult.Rows.Add(New Object(-1) {})
					dtResult.Rows(0)("ResultStatus") = "Success"
					dtResult.Rows(0)("ResultMessage") = ""
					flag2 = True
				Else
					Dim clientID As String = MainModule.GetClientID()
					Dim flag4 As Boolean = Operators.CompareString(GlobalVariables.gsIdentifier, "", False) <> 0
					If flag4 Then
					End If
					MainModule.TrnLog("Access", "Application Verification Failed", "service level issue", Nothing)
					dtResult.Rows.Add(New Object(-1) {})
					dtResult.Rows(0)("ResultStatus") = "Fail"
					dtResult.Rows(0)("ResultMessage") = "The Application Services Failed To Initialize."
					flag2 = False
				End If
			End If
			Return flag2
		End Function

		' Token: 0x06000B86 RID: 2950 RVA: 0x0006D76C File Offset: 0x0006B96C
		Public Function SetLock(ByRef dtResult As DataTable) As Boolean
			dtResult.Rows.Clear()
			GlobalVariables.oDB = New SysClass(GlobalVariables.gsConStr)
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(GlobalVariables.oDB, Nothing, "GetData", New Object() { "SELECT GETDATE()" }, Nothing, Nothing, Nothing))
			Dim flag As Boolean = Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, Nothing, "rows", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "count", New Object(-1) {}, Nothing, Nothing, Nothing), 0, False)
			Dim flag2 As Boolean
			If flag Then
				dtResult.Rows.Add(New Object(-1) {})
				dtResult.Rows(0)("ResultStatus") = "Success"
				dtResult.Rows(0)("ResultMessage") = ""
				flag2 = True
			Else
				MainModule.TrnLog("Access", "Application Initialization Failed", "dll level issue", Nothing)
				dtResult.Rows.Add(New Object(-1) {})
				dtResult.Rows(0)("ResultStatus") = "Fail"
				dtResult.Rows(0)("ResultMessage") = "The Application Failed To Initialize DataBase Connection."
				flag2 = False
			End If
			Return flag2
		End Function

		' Token: 0x06000B87 RID: 2951 RVA: 0x0006D8B0 File Offset: 0x0006BAB0
		Public Function SetConnectionString_Old() As Boolean
			Dim flag4 As Boolean
			Try
				Dim sConfigCompany As String = MySettingsProperty.Settings.sConfigCompany
				Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(sConfigCompany)
				If num <= 1779622119UI Then
					If num <> 198317500UI Then
						If num <> 1035924105UI Then
							If num = 1779622119UI Then
								If Operators.CompareString(sConfigCompany, "Config", False) = 0 Then
									GlobalVariables.gsConStr = MySettingsProperty.Settings.sConfigConStr.ToString()
								End If
							End If
						ElseIf Operators.CompareString(sConfigCompany, "Avadhoot", False) = 0 Then
							GlobalVariables.gsConStr = "Data Source=AVADHOOT\SQLEXPRESS;Initial Catalog=Datasoft-PIMS;Persist Security Info=True;User ID=sa;Password=admin123"
						End If
					ElseIf Operators.CompareString(sConfigCompany, "Anwar", False) = 0 Then
						GlobalVariables.gsConStr = "Data Source=ANWAR\SQLEXPRESS;Initial Catalog=Datasoft-PIMS-251122-Live;Persist Security Info=True;User ID=sa;Password=Data$Code#"
					End If
				ElseIf num <= 3332973484UI Then
					If num <> 2884176116UI Then
						If num = 3332973484UI Then
							If Operators.CompareString(sConfigCompany, "Amar", False) = 0 Then
								GlobalVariables.gsConStr = "Data Source=DESKTOP-CG5BL2T;Initial Catalog=DatasoftTnTRussia07July20;Integrated Security =True;User ID=sa;Password=amar"
							End If
						End If
					ElseIf Operators.CompareString(sConfigCompany, "Datacode", False) <> 0 Then
					End If
				ElseIf num <> 3347834262UI Then
					If num = 3752360223UI Then
						If Operators.CompareString(sConfigCompany, "Akash", False) = 0 Then
							GlobalVariables.gsConStr = "Data Source=DESKTOP-P2AGGGM;Initial Catalog=Datasoft-PIMS;Persist Security Info=True;User ID=sa;Password=datacode@123"
						End If
					End If
				ElseIf Operators.CompareString(sConfigCompany, "ImmunoACT", False) = 0 Then
					Dim flag As Boolean = Operators.CompareString(MySettingsProperty.Settings.sConfigIsSandbox, "True", False) = 0
					If flag Then
						GlobalVariables.gsConStr = "Data Source=FILESERVER\MSSQLSERVER2;Initial Catalog=Datasoft-PIMS-Sandbox;Persist Security Info=True;User ID=sa;Password=P@ss123*"
					Else
						GlobalVariables.gsConStr = "Data Source=FILESERVER\MSSQLSERVER2;Initial Catalog=Datasoft-PIMS;Persist Security Info=True;User ID=sa;Password=P@ss123*"
					End If
				End If
				Dim flag2 As Boolean = Operators.CompareString(GlobalVariables.gsConStr, "", False) <> 0
				If flag2 Then
					MainModule.GetConnectionDtls()
					Dim dataTable As DataTable = MainModule.CheckConnection("")
					Dim flag3 As Boolean = Operators.CompareString(dataTable.Columns(0).ColumnName, "ErrorColumn", False) <> 0
					If flag3 Then
						MainModule.GetIPv4Address()
						Return True
					End If
					CustomMsgBox.Show(dataTable.Rows(0)(0).ToString(), "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				End If
				flag4 = False
			Catch ex As Exception
				CustomMsgBox.Show("Setting Missing : " + ex.Message, "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				flag4 = False
			End Try
			Return flag4
		End Function

		' Token: 0x06000B88 RID: 2952 RVA: 0x0006DB20 File Offset: 0x0006BD20
		Public Function CheckConnection(sSQL As String) As DataTable
			Dim dataTable2 As DataTable
			Try
				Dim sqlConnection As SqlConnection = New SqlConnection(GlobalVariables.gsConStr)
				Dim flag As Boolean = Operators.CompareString(sSQL, "", False) = 0
				Dim sqlCommand As SqlCommand
				If flag Then
					sqlCommand = New SqlCommand("SELECT GETDATE()", sqlConnection)
				Else
					sqlCommand = New SqlCommand(sSQL, sqlConnection)
				End If
				sqlCommand.CommandTimeout = 500
				Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter()
				sqlDataAdapter.SelectCommand = sqlCommand
				Dim dataTable As DataTable = New DataTable()
				dataTable.Locale = CultureInfo.InvariantCulture
				sqlDataAdapter.Fill(dataTable)
				dataTable2 = dataTable
			Catch ex As Exception
				Dim dataTable3 As DataTable = New DataTable()
				dataTable3.Columns.Add("ErrorColumn", Type.[GetType]("System.String"))
				dataTable3.Columns.Add("ExceptionMsg", Type.[GetType]("System.String"))
				dataTable3.Rows.Add(New Object(-1) {})
				dataTable3.Rows(0)(0) = "Error: Unable to connect SQL Server. Please check connection and try again"
				dataTable3.Rows(0)(1) = ex.Message
				dataTable2 = dataTable3
			End Try
			Return dataTable2
		End Function

		' Token: 0x06000B89 RID: 2953 RVA: 0x0006DC54 File Offset: 0x0006BE54
		Public Sub GetConnectionDtls()
			Dim array As String() = Strings.Split(GlobalVariables.gsConStr, ";", -1, CompareMethod.Binary)
			Dim num As Integer = Information.UBound(array, 1)
			For i As Integer = 0 To num
				Dim array2 As String() = Strings.Split(array(i), "=", -1, CompareMethod.Binary)
				Dim text As String = Strings.LCase(array2(0))
				Dim num2 As UInteger = <PrivateImplementationDetails>.ComputeStringHash(text)
				If num2 <= 1433271620UI Then
					If num2 <> 121252069UI Then
						If num2 <> 910909208UI Then
							If num2 <> 1433271620UI Then
								GoTo IL_016B
							End If
							If Operators.CompareString(text, "pwd", False) <> 0 Then
								GoTo IL_016B
							End If
						ElseIf Operators.CompareString(text, "password", False) <> 0 Then
							GoTo IL_016B
						End If
						GlobalVariables.gsDbPwd = array2(1)
					ElseIf Operators.CompareString(text, "Persist Security Info", False) = 0 Then
						GlobalVariables.gsIsWindowsAuthentication = array2(1)
					End If
				Else
					If num2 <= 3185837300UI Then
						If num2 <> 2906666283UI Then
							If num2 <> 3185837300UI Then
								GoTo IL_016B
							End If
							If Operators.CompareString(text, "initial catalog", False) <> 0 Then
								GoTo IL_016B
							End If
						Else
							If Operators.CompareString(text, "user id", False) <> 0 Then
								GoTo IL_016B
							End If
							GlobalVariables.gsDbUserID = array2(1)
							GoTo IL_016B
						End If
					ElseIf num2 <> 3278991610UI Then
						If num2 <> 4039813955UI Then
							GoTo IL_016B
						End If
						If Operators.CompareString(text, "attachdbfilename", False) <> 0 Then
							GoTo IL_016B
						End If
					Else
						If Operators.CompareString(text, "data source", False) <> 0 Then
							GoTo IL_016B
						End If
						GlobalVariables.gsServerName = array2(1)
						GoTo IL_016B
					End If
					GlobalVariables.gsDbName = array2(1)
				End If
				IL_016B:
			Next
		End Sub

		' Token: 0x06000B8A RID: 2954 RVA: 0x0006DDD8 File Offset: 0x0006BFD8
		Public Function GetIPv4Address() As String
			Dim text As String = String.Empty
			Dim hostName As String = Dns.GetHostName()
			Dim hostEntry As IPHostEntry = Dns.GetHostEntry(hostName)
			For Each ipaddress As IPAddress In hostEntry.AddressList
				Dim flag As Boolean = ipaddress.AddressFamily = AddressFamily.InterNetwork
				If flag Then
					text = ipaddress.ToString()
				End If
			Next
			GlobalVariables.gsPCName = hostName
			GlobalVariables.gsPCIP = text
			Return text
		End Function

		' Token: 0x06000B8B RID: 2955 RVA: 0x0006DE48 File Offset: 0x0006C048
		Public Function SetLock() As Boolean
			GlobalVariables.oDB = New SysClass(GlobalVariables.gsConStr)
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(GlobalVariables.oDB, Nothing, "GetData", New Object() { "SELECT GETDATE()" }, Nothing, Nothing, Nothing))
			Dim flag As Boolean = Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, Nothing, "rows", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "count", New Object(-1) {}, Nothing, Nothing, Nothing), 0, False)
			Dim flag2 As Boolean
			If flag Then
				flag2 = True
			Else
				MainModule.TrnLog("Access", "Application Initialization Failed", "dll level issue", Nothing)
				CustomMsgBox.Show("The Application Failed To Initialize DataBase Connection.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				flag2 = False
			End If
			Return flag2
		End Function

		' Token: 0x06000B8C RID: 2956 RVA: 0x0006DEF8 File Offset: 0x0006C0F8
		Public Function CheckAccess() As Boolean
			Dim flag2 As Boolean
			Try
				GlobalVariables.oDB = New SysClass(GlobalVariables.gsConStr)
				Dim text As String = "SELECT * FROM FormName WHERE FormName='ZPL'"
				Dim dataTable As DataTable = MainModule.CheckConnection(text)
				Dim flag As Boolean = dataTable.Rows.Count > 0
				If flag Then
					MainModule.TrnLog("Access", "Application Initialization Failed", "Form level issue", Nothing)
					CustomMsgBox.Show("The Application Failed To Initialize Properly.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					flag2 = False
				Else
					Dim dateTime As DateTime = Conversions.ToDate("16/Nov/2018")
					GlobalVariables.sSDate = Strings.Format(dateTime, "ddMMyy")
					GlobalVariables.sDays = 118
					Dim serverDate As DateTime = MainModule.GetServerDate()
					Dim flag3 As Boolean = DateAndTime.DateDiff(DateInterval.Day, dateTime, serverDate, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1) > CLng(GlobalVariables.sDays)
					If flag3 Then
						text = "INSERT INTO FormName(FormName, SortOrder) VALUES('ZPL','100')"
						MainModule.ExecuteSQL(text)
						MainModule.TrnLog("Access", "Application Initialization Failed", "Form level issue", Nothing)
						CustomMsgBox.Show("The Application Failed To Initialize Properly.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
						flag2 = False
					Else
						flag2 = True
					End If
				End If
			Catch ex As Exception
				MainModule.TrnLog("Access", "Application Initialization Failed", "Form level issue" + ex.Message, Nothing)
				CustomMsgBox.Show("Incorrect Connection Setting :At CheckAccess().", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				flag2 = False
			End Try
			Return flag2
		End Function

		' Token: 0x06000B8D RID: 2957 RVA: 0x0006E048 File Offset: 0x0006C248
		Public Function VerifiyClient() As Boolean
			Dim flag As Boolean = Operators.CompareString(FeaturesVariables.gsWebVerify, "No", False) = 0
			Dim flag2 As Boolean
			If flag Then
				flag2 = True
			Else
				Dim flag3 As Boolean = Not MainModule.CheckInternet()
				If flag3 Then
					flag2 = True
				Else
					Dim clientID As String = MainModule.GetClientID()
					Dim flag4 As Boolean = Operators.CompareString(GlobalVariables.gsIdentifier, "", False) <> 0
					If flag4 Then
					End If
					MainModule.TrnLog("Access", "Application Verification Failed", "service level issue", Nothing)
					CustomMsgBox.Show("The Application Services Failed To Initialize.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					flag2 = False
				End If
			End If
			Return flag2
		End Function

		' Token: 0x06000B8E RID: 2958 RVA: 0x0006E0D4 File Offset: 0x0006C2D4
		Private Function CheckInternet() As Boolean
			Try
				Using webClient As WebClient = New WebClient()
					Using webClient.OpenRead("https://www.google.com/")
						Return True
					End Using
				End Using
			Catch ex As Exception
			End Try
			Return False
		End Function

		' Token: 0x06000B8F RID: 2959 RVA: 0x0006E150 File Offset: 0x0006C350
		Private Function GetClientID() As String
			Dim text As String = ""
			Try
				Dim text2 As String = "SELECT TOP (1) CompanyID, CompanyCode, CompanyName, Identifier FROM Company"
				Dim dataTable As DataTable = MainModule.CheckConnection(text2)
				Dim flag As Boolean = dataTable.Rows.Count > 0
				If flag Then
					text = Conversions.ToString(dataTable.Rows(0)("Identifier"))
				End If
			Catch ex As Exception
			End Try
			Return text
		End Function

		' Token: 0x06000B90 RID: 2960 RVA: 0x0006E1CC File Offset: 0x0006C3CC
		Private Function SetUnsetIDGen(sType As String) As Boolean
			Try
				Dim flag As Boolean = Operators.CompareString(sType, "OPEN", False) = 0
				Dim text As String
				If flag Then
					text = "UPDATE IDGen SET Field3='73855ED4-7706-4E25-BAC9-CD869FC9D5FE' WHERE Field3='1283BC4E-EE8C-4779-A422-702023780074'"
				Else
					text = "UPDATE IDGen SET Field3='1283BC4E-EE8C-4779-A422-702023780074' WHERE Field3='73855ED4-7706-4E25-BAC9-CD869FC9D5FE'"
				End If
				Dim sqlConnection As SqlConnection = New SqlConnection(GlobalVariables.gsConStr)
				Dim sqlCommand As SqlCommand = New SqlCommand()
				sqlConnection.Open()
				sqlCommand.CommandType = CommandType.Text
				sqlCommand.CommandText = text
				sqlCommand.Connection = sqlConnection
				sqlCommand.ExecuteNonQuery()
				sqlConnection.Close()
			Catch ex As Exception
				Return False
			End Try
			Return True
		End Function

		' Token: 0x06000B91 RID: 2961 RVA: 0x0006E26C File Offset: 0x0006C46C
		Public Function GetVersionInfo() As Boolean
			Dim text As String = AppDomain.CurrentDomain.BaseDirectory.ToString()
			Dim text2 As String = "Systems.dll"
			Dim text3 As String = Strings.Replace(AppDomain.CurrentDomain.FriendlyName, ".vshost", "", 1, -1, CompareMethod.Binary)
			GlobalVariables.gsSysVersionInfo = FileVersionInfo.GetVersionInfo(text + "\" + text2)
			GlobalVariables.gsAppVersionInfo = FileVersionInfo.GetVersionInfo(text + "\" + text3)
			Dim num As Long = CLng(Math.Round(Conversion.Val(Strings.Replace(GlobalVariables.gsSysVersionInfo.FileVersion, ".", "", 1, -1, CompareMethod.Binary))))
			Dim num2 As Long = CLng(Math.Round(Conversion.Val(Strings.Replace(GlobalVariables.gsAppVersionInfo.FileVersion, ".", "", 1, -1, CompareMethod.Binary))))
			Dim text4 As String = "SELECT  InfoType, '' AS InfoVersion, InfoVersion As EnInfoVersion FROM Info"
			Dim dataTable As DataTable = MainModule.CheckConnection(text4)
			Dim flag As Boolean = dataTable.Rows.Count > 1
			Dim flag11 As Boolean
			If flag Then
				dataTable.Rows(0)("InfoVersion") = MainModule.DecryptData(Conversions.ToString(dataTable.Rows(0)("EnInfoVersion")), GlobalVariables.gsPwd)
				dataTable.Rows(1)("InfoVersion") = MainModule.DecryptData(Conversions.ToString(dataTable.Rows(1)("EnInfoVersion")), GlobalVariables.gsPwd)
				Dim num3 As Long = CLng(Math.Round(Conversion.Val(Strings.Replace(Conversions.ToString(dataTable.Rows(0)("InfoVersion")), ".", "", 1, -1, CompareMethod.Binary))))
				Dim num4 As Long = CLng(Math.Round(Conversion.Val(Strings.Replace(Conversions.ToString(dataTable.Rows(1)("InfoVersion")), ".", "", 1, -1, CompareMethod.Binary))))
				Dim flag2 As Boolean = num = num3
				Dim flag3 As Boolean
				If flag2 Then
					flag3 = True
				Else
					Dim flag4 As Boolean = num > num3
					If flag4 Then
						flag3 = True
						text4 = "UPDATE Info SET InfoVersion='" + MainModule.EncryptData(GlobalVariables.gsSysVersionInfo.FileVersion, GlobalVariables.gsPwd) + "' WHERE InfoType='System'"
						MainModule.CheckConnection(text4)
					Else
						Dim flag5 As Boolean = num < num3
						If flag5 Then
							flag3 = False
							CustomMsgBox.Show("Update Datasoft-PIMS Dll.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							MainModule.TrnLog("Access", "Run Old Link Library", Conversions.ToString(Operators.ConcatenateObject("Incorrect Link Library version - version is " + GlobalVariables.gsSysVersionInfo.FileVersion + " required version is ", dataTable.Rows(0)("InfoVersion"))), Nothing)
						End If
					End If
				End If
				Dim flag6 As Boolean = num2 = num4
				Dim flag7 As Boolean
				If flag6 Then
					flag7 = True
				Else
					Dim flag8 As Boolean = num2 > num4
					If flag8 Then
						flag7 = True
						text4 = "UPDATE Info SET InfoVersion='" + MainModule.EncryptData(GlobalVariables.gsAppVersionInfo.FileVersion, GlobalVariables.gsPwd) + "' WHERE InfoType='Application'"
						MainModule.CheckConnection(text4)
					Else
						Dim flag9 As Boolean = num2 < num4
						If flag9 Then
							flag7 = False
							CustomMsgBox.Show("Update Datasoft-PIMS Appication.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							MainModule.TrnLog("Access", "Run Old Application", Conversions.ToString(Operators.ConcatenateObject("Incorrect exe version - version is " + GlobalVariables.gsAppVersionInfo.FileVersion + " required version is ", dataTable.Rows(1)("InfoVersion"))), Nothing)
						End If
					End If
				End If
				Dim flag10 As Boolean = flag3 AndAlso flag7
				flag11 = flag10
			Else
				CustomMsgBox.Show("Incorrect Connection Setting.", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				flag11 = False
			End If
			Return flag11
		End Function

		' Token: 0x06000B92 RID: 2962 RVA: 0x0006E5F8 File Offset: 0x0006C7F8
		Public Function VerifyVersion() As Boolean
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
								flag6 = MainModule.ExecuteSQLParam(text5, arrayList)
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
								flag8 = MainModule.ExecuteSQLParam(text5, arrayList2)
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
								flag8 = MainModule.ExecuteSQLParam(text5, arrayList3)
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
							MainModule.CallAppUpdater(text, text2, text4)
						End If
						Environment.[Exit](0)
						flag12 = False
					End If
				Else
					Dim flag21 As Boolean = dataTable.Columns.Contains("ErrorColumn")
					If flag21 Then
						Dim text6 As String = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataTable.Rows(0)("ErrorColumn"), " : "), vbCrLf))
						text6 = Conversions.ToString(Operators.AddObject(text6, dataTable.Rows(0)("ExceptionMsg")))
						CustomMsgBox.Show(text6, "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					End If
					flag12 = False
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				flag12 = False
			End Try
			Return flag12
		End Function

		' Token: 0x06000B93 RID: 2963 RVA: 0x0006EC98 File Offset: 0x0006CE98
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

		' Token: 0x06000B94 RID: 2964 RVA: 0x0006ED4C File Offset: 0x0006CF4C
		Public Function GetPing(Addr As String) As Boolean
			Dim flag As Boolean = MyProject.Computer.Network.Ping(Addr, 3000)
			Dim flag2 As Boolean
			If flag Then
				flag2 = True
			Else
				CustomMsgBox.Show("Check Network Connectivity.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				flag2 = False
			End If
			Return flag2
		End Function

		' Token: 0x06000B95 RID: 2965 RVA: 0x0006ED90 File Offset: 0x0006CF90
		Public Function FilterSQL(sStr As String) As String
			Dim text As String = Strings.Replace(sStr, "'", "''", 1, -1, CompareMethod.Binary)
			Return Strings.Trim(text)
		End Function

		' Token: 0x06000B96 RID: 2966 RVA: 0x0006EDBC File Offset: 0x0006CFBC
		Public Function GetData(sSQL As String) As DataTable
			Dim dataTable2 As DataTable
			Try
				Dim oDB As Object = GlobalVariables.oDB
				Dim type As Type = Nothing
				Dim text As String = "GetData"
				Dim array As Object() = New Object() { sSQL }
				Dim array2 As Object() = array
				Dim array3 As String() = Nothing
				Dim array4 As Type() = Nothing
				Dim array5 As Boolean() = New Boolean() { True }
				Dim array6 As Boolean() = array5
				Dim obj As Object = NewLateBinding.LateGet(oDB, type, text, array, array3, array4, array5)
				If array6(0) Then
					sSQL = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(String)))
				End If
				Dim dataTable As DataTable = CType(obj, DataTable)
				dataTable2 = dataTable
			Catch ex As Exception
				CustomMsgBox.Show("Error at GetData() method - " + ex.Message, "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Dim dataTable3 As DataTable = New DataTable()
				dataTable2 = dataTable3
			End Try
			Return dataTable2
		End Function

		' Token: 0x06000B97 RID: 2967 RVA: 0x0006EE74 File Offset: 0x0006D074
		Public Function GetData(sSQL As String, oCon As SqlConnection, oTrn As SqlTransaction) As DataTable
			Dim dataTable As DataTable
			Try
				Dim oDB As Object = GlobalVariables.oDB
				Dim type As Type = Nothing
				Dim text As String = "GetData"
				Dim array As Object() = New Object() { sSQL, oCon, oTrn }
				Dim array2 As Object() = array
				Dim array3 As String() = Nothing
				Dim array4 As Type() = Nothing
				Dim array5 As Boolean() = New Boolean() { True, True, True }
				Dim array6 As Boolean() = array5
				Dim obj As Object = NewLateBinding.LateGet(oDB, type, text, array, array3, array4, array5)
				If array6(0) Then
					sSQL = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(String)))
				End If
				If array6(1) Then
					oCon = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(1)), GetType(SqlConnection)), SqlConnection)
				End If
				If array6(2) Then
					oTrn = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(2)), GetType(SqlTransaction)), SqlTransaction)
				End If
				dataTable = CType(obj, DataTable)
			Catch ex As Exception
				CustomMsgBox.Show("Error at GetData() method - " + ex.Message, "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Dim dataTable2 As DataTable = New DataTable()
				dataTable = dataTable2
			End Try
			Return dataTable
		End Function

		' Token: 0x06000B98 RID: 2968 RVA: 0x0006EF80 File Offset: 0x0006D180
		Public Function ExecuteSQL(sSQL As String) As Integer
			Dim num As Integer
			Try
				Dim oDB As Object = GlobalVariables.oDB
				Dim type As Type = Nothing
				Dim text As String = "ExecuteSQL"
				Dim array As Object() = New Object() { sSQL }
				Dim array2 As Object() = array
				Dim array3 As String() = Nothing
				Dim array4 As Type() = Nothing
				Dim array5 As Boolean() = New Boolean() { True }
				Dim array6 As Boolean() = array5
				Dim obj As Object = NewLateBinding.LateGet(oDB, type, text, array, array3, array4, array5)
				If array6(0) Then
					sSQL = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(String)))
				End If
				num = Conversions.ToInteger(obj)
			Catch ex As Exception
				CustomMsgBox.Show("Error at ExecuteSQL() method - " + ex.Message, "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				num = 0
			End Try
			Return num
		End Function

		' Token: 0x06000B99 RID: 2969 RVA: 0x0006F02C File Offset: 0x0006D22C
		Public Function ExecuteSQL(sSQL As String, oCon As SqlConnection, oTrn As SqlTransaction) As Integer
			Dim oDB As Object = GlobalVariables.oDB
			Dim type As Type = Nothing
			Dim text As String = "ExecuteSQL"
			Dim array As Object() = New Object() { sSQL, oCon, oTrn }
			Dim array2 As Object() = array
			Dim array3 As String() = Nothing
			Dim array4 As Type() = Nothing
			Dim array5 As Boolean() = New Boolean() { True, True, True }
			Dim array6 As Boolean() = array5
			Dim obj As Object = NewLateBinding.LateGet(oDB, type, text, array, array3, array4, array5)
			If array6(0) Then
				sSQL = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(String)))
			End If
			If array6(1) Then
				oCon = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(1)), GetType(SqlConnection)), SqlConnection)
			End If
			If array6(2) Then
				oTrn = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(2)), GetType(SqlTransaction)), SqlTransaction)
			End If
			Return Conversions.ToInteger(obj)
		End Function

		' Token: 0x06000B9A RID: 2970 RVA: 0x0006F0EC File Offset: 0x0006D2EC
		Public Function ExecuteSQLParam(sSQL As String, arrList As ArrayList) As Boolean
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

		' Token: 0x06000B9B RID: 2971 RVA: 0x0006F288 File Offset: 0x0006D488
		Public Function GetServerDate() As DateTime
			Dim data As DataTable = MainModule.GetData("SELECT GETDATE()")
			Return Conversions.ToDate(data.Rows(0)(0))
		End Function

		' Token: 0x06000B9C RID: 2972 RVA: 0x0006F2BC File Offset: 0x0006D4BC
		Public Function GetServerDateUTC() As String
			Dim data As DataTable = MainModule.GetData("SELECT GETDATE()")
			Dim dateTime As DateTime = Conversions.ToDate(data.Rows(0)(0)).ToUniversalTime()
			Return Conversions.ToString(dateTime)
		End Function

		' Token: 0x06000B9D RID: 2973 RVA: 0x0006F300 File Offset: 0x0006D500
		Public Sub SaveDocuments(dtFile As DataTable)
			Dim flag As Boolean = dtFile.Rows.Count > 0
			If flag Then
				Dim sqlConnection As SqlConnection = New SqlConnection(GlobalVariables.gsConStr)
				sqlConnection.Open()
				Dim sqlTransaction As SqlTransaction = sqlConnection.BeginTransaction(IsolationLevel.ReadCommitted)
				Try
					Dim sqlBulkCopy As SqlBulkCopy = New SqlBulkCopy(sqlConnection, SqlBulkCopyOptions.[Default], sqlTransaction)
					sqlBulkCopy.DestinationTableName = "FileDocs"
					sqlBulkCopy.BulkCopyTimeout = 60000
					sqlBulkCopy.BatchSize = 500
					sqlBulkCopy.ColumnMappings.Add("RefID", "RefID")
					sqlBulkCopy.ColumnMappings.Add("RefType", "RefType")
					sqlBulkCopy.ColumnMappings.Add("FileName", "FileName")
					sqlBulkCopy.ColumnMappings.Add("FileDesc", "FileDesc")
					sqlBulkCopy.ColumnMappings.Add("FileContentType", "FileContentType")
					sqlBulkCopy.ColumnMappings.Add("FileData", "FileData")
					sqlBulkCopy.WriteToServer(dtFile)
					sqlBulkCopy.Close()
					sqlTransaction.Commit()
					sqlConnection.Close()
				Catch ex As Exception
					sqlTransaction.Rollback()
					CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				End Try
			End If
		End Sub

		' Token: 0x06000B9E RID: 2974 RVA: 0x0006F45C File Offset: 0x0006D65C
		Public Function CreateTempTable(dt As DataTable, sTabPref As String) As String
			Dim text As String = ""
			Dim serverDate As DateTime = MainModule.GetServerDate()
			Dim flag As Boolean = (dt.Columns.Count > 0) And (dt.Rows.Count > 0)
			If flag Then
				text = String.Concat(New String() { "z", sTabPref, GlobalVariables.gsUserID, "_", Strings.Format(serverDate, "MMddyyhhmmss") })
				Dim text2 As String = String.Concat(New String() { " If(OBJECT_ID('dbo.", text, "') Is Not Null) Begin  Drop Table ", text, " End" })
				text2 = text2 + " CREATE TABLE " + text + " ( "
				Dim num As Integer = dt.Columns.Count - 1
				For i As Integer = 0 To num
					text2 = text2 + " " + dt.Columns(i).ColumnName.ToString() + " Varchar(100),"
				Next
				text2 = Strings.Mid(text2, 1, text2.Length - 1) + ")"
				Dim flag2 As Boolean = MainModule.ExecuteSQL(text2) = 1
				If flag2 Then
					Dim sqlConnection As SqlConnection = New SqlConnection(GlobalVariables.gsConStr)
					sqlConnection.Open()
					Dim sqlTransaction As SqlTransaction = sqlConnection.BeginTransaction(IsolationLevel.Serializable)
					Try
						MainModule.BulkInsertTemp(dt, text, sqlConnection, sqlTransaction)
						sqlTransaction.Commit()
						sqlConnection.Close()
					Catch ex As Exception
						text = ""
						sqlTransaction.Rollback()
						CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					End Try
				End If
			End If
			Return text
		End Function

		' Token: 0x06000B9F RID: 2975 RVA: 0x0006F624 File Offset: 0x0006D824
		Public Sub BulkInsertTemp(dt As DataTable, sTableName As String, oCon As SqlConnection, oTrn As SqlTransaction)
			Dim sqlBulkCopy As SqlBulkCopy = New SqlBulkCopy(oCon, SqlBulkCopyOptions.[Default], oTrn)
			sqlBulkCopy.DestinationTableName = sTableName
			sqlBulkCopy.BulkCopyTimeout = 60000
			sqlBulkCopy.BatchSize = 5000
			Dim num As Integer = dt.Columns.Count - 1
			For i As Integer = 0 To num
				sqlBulkCopy.ColumnMappings.Add(dt.Columns(i).ColumnName.ToString(), dt.Columns(i).ColumnName.ToString())
			Next
			sqlBulkCopy.WriteToServer(dt)
		End Sub

		' Token: 0x06000BA0 RID: 2976 RVA: 0x0006F6B8 File Offset: 0x0006D8B8
		Public Function ReadExcelFile(sExcelType As String, sPath As String, sSheet As String, Optional sWhere As String = "") As DataTable
			Dim dataTable2 As DataTable
			Try
				Dim flag As Boolean = Operators.CompareString(sExcelType, "xls", False) = 0
				Dim text As String
				If flag Then
					text = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" + sPath + "; Extended Properties=Excel 8.0"
				Else
					text = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + sPath + ";Extended Properties=Excel 12.0"
				End If
				Dim text2 As String = "Select * From [" + sSheet + "$] Where 1=1 "
				Dim flag2 As Boolean = Operators.CompareString(sWhere, "", False) <> 0
				If flag2 Then
					text2 = text2 + " AND " + sWhere
				End If
				Dim oleDbConnection As OleDbConnection = New OleDbConnection(text)
				oleDbConnection.Open()
				Dim oleDbCommand As OleDbCommand = New OleDbCommand(text2, oleDbConnection)
				Dim oleDbDataReader As OleDbDataReader = oleDbCommand.ExecuteReader()
				Dim dataTable As DataTable = New DataTable()
				dataTable.Load(oleDbDataReader)
				oleDbDataReader.Close()
				oleDbConnection.Close()
				dataTable2 = dataTable
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Dim dataTable3 As DataTable = New DataTable()
				dataTable2 = dataTable3
			End Try
			Return dataTable2
		End Function

		' Token: 0x06000BA1 RID: 2977 RVA: 0x0006F7C8 File Offset: 0x0006D9C8
		Public Function SetDBTableLock(sTab As String, oCon As SqlConnection, oTrn As SqlTransaction) As Integer
			Dim text As String = "SELECT * FROM sys.dm_tran_locks WHERE resource_associated_entity_id = object_id('" + sTab + "')"
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Columns.Count > 0
			Dim flag3 As Boolean
			If flag Then
				Dim flag2 As Boolean = data.Rows.Count = 0
				flag3 = Not flag2
			Else
				flag3 = False
			End If
			Dim flag4 As Boolean = Not flag3
			If flag4 Then
				Try
					text = "SELECT * FROM " + sTab + " WITH (TABLOCKX)"
					Dim flag5 As Boolean = MainModule.ExecuteSQL(text, oCon, oTrn) = 1
					If flag5 Then
						Return 1
					End If
					Return 0
				Catch ex As Exception
					Interaction.MsgBox("SetDBTableLock : " + ex.Message, MsgBoxStyle.Critical, "Critical")
					Return 0
				End Try
			End If
			Return 0
		End Function

		' Token: 0x06000BA2 RID: 2978 RVA: 0x0006F8A4 File Offset: 0x0006DAA4
		Public Function GetData(sSQL As String, Optional params As List(Of SqlParameter) = Nothing) As DataTable
			Dim dataTable2 As DataTable
			Try
				Using sqlConnection As SqlConnection = New SqlConnection(GlobalVariables.gsConStr)
					Using sqlCommand As SqlCommand = New SqlCommand(sSQL, sqlConnection)
						sqlCommand.CommandType = CommandType.Text
						sqlCommand.CommandTimeout = 500
						Dim flag As Boolean = params IsNot Nothing AndAlso params.Count > 0
						If flag Then
							sqlCommand.Parameters.AddRange(params.ToArray())
						End If
						Using sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(sqlCommand)
							Dim dataTable As DataTable = New DataTable()
							sqlDataAdapter.Fill(dataTable)
							dataTable2 = dataTable
						End Using
					End Using
				End Using
			Catch ex As Exception
				CustomMsgBox.Show("Error at GetData() method - " + ex.Message, "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Dim dataTable3 As DataTable = New DataTable()
				dataTable2 = dataTable3
			End Try
			Return dataTable2
		End Function

		' Token: 0x06000BA3 RID: 2979 RVA: 0x0006F9B8 File Offset: 0x0006DBB8
		Public Function GetData(sSQL As String, oCon As SqlConnection, oTrn As SqlTransaction, Optional params As List(Of SqlParameter) = Nothing) As DataTable
			Dim dataTable2 As DataTable
			Using sqlCommand As SqlCommand = New SqlCommand(sSQL, oCon)
				sqlCommand.CommandType = CommandType.Text
				sqlCommand.CommandTimeout = 500
				sqlCommand.Transaction = oTrn
				Dim flag As Boolean = params IsNot Nothing AndAlso params.Count > 0
				If flag Then
					sqlCommand.Parameters.AddRange(params.ToArray())
				End If
				Using sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter(sqlCommand)
					Dim dataTable As DataTable = New DataTable()
					sqlDataAdapter.Fill(dataTable)
					dataTable2 = dataTable
				End Using
			End Using
			Return dataTable2
		End Function

		' Token: 0x06000BA4 RID: 2980 RVA: 0x0006FA64 File Offset: 0x0006DC64
		Private Sub How_To_Use_GetData_Params()
		End Sub

		' Token: 0x06000BA5 RID: 2981 RVA: 0x0006FA68 File Offset: 0x0006DC68
		Public Function ExecuteSQL(sSQL As String, Optional params As List(Of SqlParameter) = Nothing) As Integer
			Dim num As Integer
			Try
				Using sqlConnection As SqlConnection = New SqlConnection(GlobalVariables.gsConStr)
					Using sqlCommand As SqlCommand = New SqlCommand(sSQL, sqlConnection)
						sqlCommand.CommandType = CommandType.Text
						sqlCommand.CommandTimeout = 500
						Dim flag As Boolean = params IsNot Nothing AndAlso params.Count > 0
						If flag Then
							sqlCommand.Parameters.AddRange(params.ToArray())
						End If
						sqlConnection.Open()
						sqlCommand.ExecuteNonQuery()
						num = 1
					End Using
				End Using
			Catch ex As Exception
				CustomMsgBox.Show("Error at ExecuteSQL() method - " + ex.Message, "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				num = 0
			End Try
			Return num
		End Function

		' Token: 0x06000BA6 RID: 2982 RVA: 0x0006FB4C File Offset: 0x0006DD4C
		Public Function ExecuteSQL(sSQL As String, oCon As SqlConnection, oTrn As SqlTransaction, Optional params As List(Of SqlParameter) = Nothing) As Integer
			Dim num As Integer
			Using sqlCommand As SqlCommand = New SqlCommand(sSQL, oCon)
				sqlCommand.CommandType = CommandType.Text
				sqlCommand.CommandTimeout = 500
				sqlCommand.Transaction = oTrn
				Dim flag As Boolean = params IsNot Nothing AndAlso params.Count > 0
				If flag Then
					sqlCommand.Parameters.AddRange(params.ToArray())
				End If
				num = sqlCommand.ExecuteNonQuery()
			End Using
			Return num
		End Function

		' Token: 0x06000BA7 RID: 2983 RVA: 0x0006FBCC File Offset: 0x0006DDCC
		Private Sub How_To_Use_ExecuteSQL_Params()
		End Sub

		' Token: 0x06000BA8 RID: 2984 RVA: 0x0006FBD0 File Offset: 0x0006DDD0
		Public Sub ExportToExcel(dgvList As DataGridView, sFormName As String)
			Try
				Dim flag As Boolean = dgvList.RowCount > 0
				If flag Then
					Dim folderBrowserDialog As FolderBrowserDialog = New FolderBrowserDialog()
					Dim arrayList As ArrayList = New ArrayList()
					Dim flag2 As Boolean = folderBrowserDialog.ShowDialog() = DialogResult.OK
					If flag2 Then
						Dim text As String = folderBrowserDialog.SelectedPath
						Dim text2 As String = Strings.Replace(sFormName + " List", "List List", "List", 1, -1, CompareMethod.Binary)
						arrayList = CType(MainModule.MakeArray(text2), ArrayList)
						Dim flag3 As Boolean = Operators.CompareString(FeaturesVariables.gsProtecetd_Excel, "Yes", False) = 0
						If flag3 Then
							text = MainModule.ExportToXl_LateBind(dgvList, arrayList, text, GlobalVariables.gsExcelPassword)
						Else
							text = MainModule.ExportToXl_LateBind(dgvList, arrayList, text, "")
						End If
						CustomMsgBox.Show("Export Completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
						Dim text3 As String = "No. Of Rows: " + Conversions.ToString(dgvList.Rows.Count) + " - Row(s)" & vbCrLf
						text3 = text3 + "File Path: " + text
						MainModule.TrnLog(sFormName, "Data Exported", text3, Nothing)
					End If
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06000BA9 RID: 2985
		Private Declare Auto Function GetWindowThreadProcessId Lib "user32.dll" (hwnd As IntPtr, ByRef lpdwProcessId As Integer) As Integer

		' Token: 0x06000BAA RID: 2986 RVA: 0x0006FD18 File Offset: 0x0006DF18
		Public Sub ExportToXl(dgv As DataGridView, hdr As ArrayList)
			Try
				Dim oDB As Object = GlobalVariables.oDB
				Dim type As Type = Nothing
				Dim text As String = "ExportToExcel"
				Dim array As Object() = New Object() { dgv, hdr }
				Dim array2 As Object() = array
				Dim array3 As String() = Nothing
				Dim array4 As Type() = Nothing
				Dim array5 As Boolean() = New Boolean() { True, True }
				Dim array6 As Boolean() = array5
				NewLateBinding.LateCall(oDB, type, text, array, array3, array4, array5, True)
				If array6(0) Then
					dgv = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(DataGridView)), DataGridView)
				End If
				If array6(1) Then
					hdr = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(1)), GetType(ArrayList)), ArrayList)
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06000BAB RID: 2987 RVA: 0x0006FDE8 File Offset: 0x0006DFE8
		Public Function ExportToXl(dgv As DataGridView, shdr As ArrayList, sPath As String, sPwd As String) As String
			Cursor.Current = Cursors.WaitCursor
			Dim text As String = "Error :"
			Dim text2 As String = Strings.Format(DateAndTime.Now, "ddMMyy_hhmmss") + ".xlsx"
			sPath = Strings.Replace(sPath + "\" + text2, "\\", "\", 1, -1, CompareMethod.Binary)
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Excel.Application", ""))
			Dim num As Integer = Conversions.ToInteger(NewLateBinding.LateGet(objectValue, Nothing, "hwnd", New Object(-1) {}, Nothing, Nothing, Nothing))
			Dim num2 As Integer = 0
			MainModule.GetWindowThreadProcessId(CType(num, IntPtr), num2)
			Dim processById As Process = Process.GetProcessById(num2)
			Dim flag As Boolean = Not Information.IsNothing(RuntimeHelpers.GetObjectValue(objectValue))
			If flag Then
				Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, Nothing, "Workbooks", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Add", New Object(-1) {}, Nothing, Nothing, Nothing))
				Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, Nothing, "Sheets", New Object() { 1 }, Nothing, Nothing, Nothing))
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, Nothing, "Cells", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "EntireColumn", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "NumberFormat", New Object() { "@" }, Nothing, Nothing, False, True)
				Try
					Dim num3 As Integer = shdr.Count - 1
					For i As Integer = 0 To num3
						NewLateBinding.LateSet(objectValue, Nothing, "Cells", New Object() { i + 1, 1, shdr(i).ToString() }, Nothing, Nothing)
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, Nothing, "Cells", New Object() { i + 1, 1 }, Nothing, Nothing, Nothing), Nothing, "Font", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Bold", New Object() { True }, Nothing, Nothing, False, True)
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, Nothing, "Cells", New Object() { i + 1, 1 }, Nothing, Nothing, Nothing), Nothing, "Font", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Size", New Object() { 14 }, Nothing, Nothing, False, True)
					Next
					Dim num4 As Integer = dgv.Rows.Count - 1
					For j As Integer = 0 To num4
						Dim num5 As Integer = 0
						Dim num6 As Integer = dgv.Columns.Count - 1
						For k As Integer = 0 To num6
							Dim visible As Boolean = dgv.Columns(k).Visible
							If visible Then
								Dim flag2 As Boolean = j = 0
								If flag2 Then
									Dim obj As Object = NewLateBinding.LateGet(objectValue, Nothing, "Cells", New Object() { j + shdr.Count + 2, k + 1 - num5 }, Nothing, Nothing, Nothing)
									NewLateBinding.LateSetComplex(obj, Nothing, "Value", New Object() { dgv.Columns(k).HeaderText }, Nothing, Nothing, False, True)
									NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, Nothing, "Font", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Bold", New Object() { True }, Nothing, Nothing, False, True)
									NewLateBinding.LateSetComplex(obj, Nothing, "HorizontalAlignment", New Object() { -4108 }, Nothing, Nothing, False, True)
								End If
								Dim name As String = dgv.Columns(k).ValueType.Name
								If Operators.CompareString(name, "String", False) <> 0 AndAlso Operators.CompareString(name, "Boolean", False) <> 0 Then
									If Operators.CompareString(name, "Decimal", False) <> 0 AndAlso Operators.CompareString(name, "Int32", False) <> 0 Then
										If Operators.CompareString(name, "DateTime", False) = 0 Then
											Dim flag3 As Boolean = Information.IsDate(RuntimeHelpers.GetObjectValue(dgv.Rows(j).Cells(k).Value))
											If flag3 Then
												Dim flag4 As Boolean = Strings.InStr(dgv.Rows(j).Cells(k).Value.ToString(), "00:00:00", CompareMethod.Binary) > 0
												If flag4 Then
													NewLateBinding.LateSet(objectValue, Nothing, "Cells", New Object() { j + shdr.Count + 3, k + 1 - num5, Strings.Format(RuntimeHelpers.GetObjectValue(dgv.Rows(j).Cells(k).Value), "dd-MMM-yyyy") }, Nothing, Nothing)
												Else
													NewLateBinding.LateSet(objectValue, Nothing, "Cells", New Object() { j + shdr.Count + 3, k + 1 - num5, Strings.Format(RuntimeHelpers.GetObjectValue(dgv.Rows(j).Cells(k).Value), "dd-MMM-yyyy hh:mm:ss tt") }, Nothing, Nothing)
												End If
											Else
												NewLateBinding.LateSet(objectValue, Nothing, "Cells", New Object() { j + shdr.Count + 3, k + 1 - num5, dgv.Rows(j).Cells(k).Value.ToString() }, Nothing, Nothing)
											End If
										End If
									Else
										Dim obj2 As Object = NewLateBinding.LateGet(objectValue, Nothing, "Cells", New Object() { j + shdr.Count + 3, k + 1 - num5 }, Nothing, Nothing, Nothing)
										NewLateBinding.LateSetComplex(obj2, Nothing, "Value", New Object() { dgv.Rows(j).Cells(k).Value.ToString() }, Nothing, Nothing, False, True)
										NewLateBinding.LateSetComplex(obj2, Nothing, "HorizontalAlignment", New Object() { -4108 }, Nothing, Nothing, False, True)
									End If
								Else
									Dim obj3 As Object = NewLateBinding.LateGet(objectValue, Nothing, "Cells", New Object() { j + shdr.Count + 3, k + 1 - num5 }, Nothing, Nothing, Nothing)
									NewLateBinding.LateSetComplex(obj3, Nothing, "Value", New Object() { dgv.Rows(j).Cells(k).Value.ToString() }, Nothing, Nothing, False, True)
								End If
							Else
								num5 += 1
							End If
						Next
					Next
					Dim flag5 As Boolean = Operators.CompareString(sPwd, "", False) <> 0
					Dim array3 As Object()
					Dim array7 As Boolean()
					If flag5 Then
						Dim obj4 As Object = objectValue3
						Dim type As Type = Nothing
						Dim text3 As String = "Protect"
						Dim array As Object() = New Object() { Nothing, sPwd }
						array(0) = True
						Dim array2 As Object() = array
						array3 = array2
						Dim array4 As String() = New String() { "AllowFormattingColumns" }
						Dim array5 As Type() = Nothing
						Dim array6 As Boolean() = New Boolean() { Nothing, True }
						array7 = array6
						NewLateBinding.LateCall(obj4, type, text3, array2, array4, array5, array6, True)
						If array7(1) Then
							sPwd = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3(1)), GetType(String)))
						End If
					End If
					Dim obj5 As Object = objectValue2
					Dim type2 As Type = Nothing
					Dim text4 As String = "SaveAs"
					Dim array8 As Object() = New Object() { sPath }
					array3 = array8
					Dim array9 As String() = Nothing
					Dim array10 As Type() = Nothing
					Dim array11 As Boolean() = New Boolean() { True }
					array7 = array11
					NewLateBinding.LateCall(obj5, type2, text4, array8, array9, array10, array11, True)
					If array7(0) Then
						sPath = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3(0)), GetType(String)))
					End If
					NewLateBinding.LateCall(objectValue, Nothing, "Quit", New Object(-1) {}, Nothing, Nothing, Nothing, True)
					text = sPath
				Catch ex As Exception
					text += ex.Message
				End Try
			End If
			Dim flag6 As Boolean = Not processById.HasExited
			If flag6 Then
				processById.Kill()
			End If
			Cursor.Current = Cursors.[Default]
			Dim text5 As String
			Return text5
		End Function

		' Token: 0x06000BAC RID: 2988 RVA: 0x00070658 File Offset: 0x0006E858
		Public Sub ExportToXl(dt As DataTable, shdr As ArrayList, sPath As String, sPwd As String)
			Try
				Dim oDB As Object = GlobalVariables.oDB
				Dim type As Type = Nothing
				Dim text As String = "ExportToExcel"
				Dim array As Object() = New Object() { dt, shdr, sPath, sPwd }
				Dim array2 As Object() = array
				Dim array3 As String() = Nothing
				Dim array4 As Type() = Nothing
				Dim array5 As Boolean() = New Boolean() { True, True, True, True }
				Dim array6 As Boolean() = array5
				NewLateBinding.LateCall(oDB, type, text, array, array3, array4, array5, True)
				If array6(0) Then
					dt = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(DataTable)), DataTable)
				End If
				If array6(1) Then
					shdr = CType(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(1)), GetType(ArrayList)), ArrayList)
				End If
				If array6(2) Then
					sPath = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(2)), GetType(String)))
				End If
				If array6(3) Then
					sPwd = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(3)), GetType(String)))
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06000BAD RID: 2989 RVA: 0x0007077C File Offset: 0x0006E97C
		Public Function ExportToXl_LateBind(dgv As DataGridView, shdr As ArrayList, sPath As String, sPwd As String) As String
			Dim text As String = Strings.Format(DateAndTime.Now, "ddMMyy_hhmmss") + ".xlsx"
			Dim text2 As String = Path.Combine(sPath, text)
			Dim text3 As String = "Error: "
			Dim obj As Object = Nothing
			Dim obj2 As Object = Nothing
			Dim obj3 As Object = Nothing
			Dim obj4 As Object = Nothing
			Dim obj5 As Object = Nothing
			Cursor.Current = Cursors.WaitCursor
			Try
				obj = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Excel.Application", ""))
				obj2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj, Nothing, "Workbooks", New Object(-1) {}, Nothing, Nothing, Nothing))
				obj3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj2, Nothing, "Add", New Object(-1) {}, Nothing, Nothing, Nothing))
				obj4 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj3, Nothing, "Sheets", New Object(-1) {}, Nothing, Nothing, Nothing))
				obj5 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(obj4, New Object() { 1 }, Nothing))
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, Nothing, "Cells", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "EntireColumn", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "NumberFormat", New Object() { "@" }, Nothing, Nothing, False, True)
				Dim num As Integer = Conversions.ToInteger(NewLateBinding.LateGet(obj, Nothing, "hwnd", New Object(-1) {}, Nothing, Nothing, Nothing))
				Dim num2 As Integer = 0
				MainModule.GetWindowThreadProcessId(CType(num, IntPtr), num2)
				Dim processById As Process = Process.GetProcessById(num2)
				Dim num3 As Integer = shdr.Count - 1
				For i As Integer = 0 To num3
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj5, Nothing, "Cells", New Object() { i + 1, 1 }, Nothing, Nothing, Nothing))
					NewLateBinding.LateSet(objectValue, Nothing, "Value", New Object() { shdr(i) }, Nothing, Nothing)
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, Nothing, "Font", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Bold", New Object() { True }, Nothing, Nothing, False, True)
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, Nothing, "Font", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Size", New Object() { 14 }, Nothing, Nothing, False, True)
					MainModule.ReleaseComObjectSafe(RuntimeHelpers.GetObjectValue(objectValue))
				Next
				Dim enumerable As IEnumerable(Of DataGridViewColumn) = dgv.Columns.Cast()
				Dim func As Func(Of DataGridViewColumn, Boolean)
				If MainModule._Closure$__.$I42-0 IsNot Nothing Then
					func = MainModule._Closure$__.$I42-0
				Else
					Dim func2 As Func(Of DataGridViewColumn, Boolean) = Function(c As DataGridViewColumn) c.Visible AndAlso New String() { "String", "Int32", "Decimal", "Double", "DateTime", "Boolean" }.Contains(c.ValueType.Name)
					func = func2
					MainModule._Closure$__.$I42-0 = func2
				End If
				Dim list As List(Of DataGridViewColumn) = enumerable.Where(func).ToList()
				Dim num4 As Integer = 1
				Dim array2 As Object()
				Dim array6 As Boolean()
				Try
					For Each dataGridViewColumn As DataGridViewColumn In list
						Dim obj6 As Object = obj5
						Dim type As Type = Nothing
						Dim text4 As String = "Cells"
						Dim array As Object() = New Object() { shdr.Count + 2, num4 }
						array2 = array
						Dim array3 As String() = Nothing
						Dim array4 As Type() = Nothing
						Dim array5 As Boolean() = New Boolean() { Nothing, True }
						array6 = array5
						Dim obj7 As Object = NewLateBinding.LateGet(obj6, type, text4, array, array3, array4, array5)
						If array6(1) Then
							num4 = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(1)), GetType(Integer)))
						End If
						Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(obj7)
						NewLateBinding.LateSet(objectValue2, Nothing, "Value", New Object() { dataGridViewColumn.HeaderText }, Nothing, Nothing)
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue2, Nothing, "Font", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Bold", New Object() { True }, Nothing, Nothing, False, True)
						NewLateBinding.LateSet(objectValue2, Nothing, "HorizontalAlignment", New Object() { -4108 }, Nothing, Nothing)
						MainModule.ReleaseComObjectSafe(RuntimeHelpers.GetObjectValue(objectValue2))
						num4 += 1
					Next
				Finally
					Dim enumerator As List(Of DataGridViewColumn).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Dim num5 As Integer = shdr.Count + 3
				Dim num6 As Integer = dgv.Rows.Count - 1
				For j As Integer = 0 To num6
					Dim isNewRow As Boolean = dgv.Rows(j).IsNewRow
					If Not isNewRow Then
						num4 = 1
						Try
							For Each dataGridViewColumn2 As DataGridViewColumn In list
								Dim objectValue3 As Object = RuntimeHelpers.GetObjectValue(dgv.Rows(j).Cells(dataGridViewColumn2.Index).Value)
								Dim flag As Boolean = objectValue3 Is Nothing
								If flag Then
									num4 += 1
								Else
									Dim obj8 As Object = obj5
									Dim type2 As Type = Nothing
									Dim text5 As String = "Cells"
									Dim array7 As Object() = New Object() { num5 + j, num4 }
									array2 = array7
									Dim array8 As String() = Nothing
									Dim array9 As Type() = Nothing
									Dim array10 As Boolean() = New Boolean() { Nothing, True }
									array6 = array10
									Dim obj7 As Object = NewLateBinding.LateGet(obj8, type2, text5, array7, array8, array9, array10)
									If array6(1) Then
										num4 = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(1)), GetType(Integer)))
									End If
									Dim objectValue4 As Object = RuntimeHelpers.GetObjectValue(obj7)
									Dim name As String = dataGridViewColumn2.ValueType.Name
									If Operators.CompareString(name, "String", False) <> 0 AndAlso Operators.CompareString(name, "Boolean", False) <> 0 Then
										If Operators.CompareString(name, "Int32", False) <> 0 AndAlso Operators.CompareString(name, "Decimal", False) <> 0 AndAlso Operators.CompareString(name, "Double", False) <> 0 Then
											If Operators.CompareString(name, "DateTime", False) = 0 Then
												Dim dateTime As DateTime
												Dim flag2 As Boolean = DateTime.TryParse(objectValue3.ToString(), dateTime)
												If flag2 Then
													NewLateBinding.LateSet(objectValue4, Nothing, "Value", New Object() { dateTime }, Nothing, Nothing)
													Dim flag3 As Boolean = Not String.IsNullOrEmpty(dataGridViewColumn2.DefaultCellStyle.Format)
													If flag3 Then
														NewLateBinding.LateSet(objectValue4, Nothing, "NumberFormat", New Object() { dataGridViewColumn2.DefaultCellStyle.Format }, Nothing, Nothing)
													Else
														NewLateBinding.LateSet(objectValue4, Nothing, "NumberFormat", New Object() { "dd-mmm-yyyy hh:mm:ss" }, Nothing, Nothing)
													End If
												Else
													NewLateBinding.LateSet(objectValue4, Nothing, "Value", New Object() { objectValue3.ToString() }, Nothing, Nothing)
												End If
												NewLateBinding.LateSet(objectValue4, Nothing, "HorizontalAlignment", New Object() { -4108 }, Nothing, Nothing)
											End If
										Else
											NewLateBinding.LateSet(objectValue4, Nothing, "Value", New Object() { objectValue3 }, Nothing, Nothing)
											Dim flag4 As Boolean = Not String.IsNullOrEmpty(dataGridViewColumn2.DefaultCellStyle.Format)
											If flag4 Then
												NewLateBinding.LateSet(objectValue4, Nothing, "NumberFormat", New Object() { dataGridViewColumn2.DefaultCellStyle.Format }, Nothing, Nothing)
											End If
											NewLateBinding.LateSet(objectValue4, Nothing, "HorizontalAlignment", New Object() { -4152 }, Nothing, Nothing)
										End If
									Else
										NewLateBinding.LateSet(objectValue4, Nothing, "Value", New Object() { objectValue3.ToString() }, Nothing, Nothing)
										NewLateBinding.LateSet(objectValue4, Nothing, "HorizontalAlignment", New Object() { -4131 }, Nothing, Nothing)
									End If
									Dim alignment As DataGridViewContentAlignment = dataGridViewColumn2.DefaultCellStyle.Alignment
									If alignment <> DataGridViewContentAlignment.MiddleCenter Then
										If alignment <> DataGridViewContentAlignment.MiddleRight Then
											NewLateBinding.LateSet(objectValue4, Nothing, "HorizontalAlignment", New Object() { -4131 }, Nothing, Nothing)
										Else
											NewLateBinding.LateSet(objectValue4, Nothing, "HorizontalAlignment", New Object() { -4152 }, Nothing, Nothing)
										End If
									Else
										NewLateBinding.LateSet(objectValue4, Nothing, "HorizontalAlignment", New Object() { -4108 }, Nothing, Nothing)
									End If
									MainModule.ReleaseComObjectSafe(RuntimeHelpers.GetObjectValue(objectValue4))
									num4 += 1
								End If
							Next
						Finally
							Dim enumerator2 As List(Of DataGridViewColumn).Enumerator
							CType(enumerator2, IDisposable).Dispose()
						End Try
					End If
				Next
				NewLateBinding.LateCall(NewLateBinding.LateGet(obj5, Nothing, "Columns", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "AutoFit", New Object(-1) {}, Nothing, Nothing, Nothing, True)
				Dim flag5 As Boolean = Not String.IsNullOrWhiteSpace(sPwd)
				If flag5 Then
					Dim obj9 As Object = obj5
					Dim type3 As Type = Nothing
					Dim text6 As String = "Protect"
					Dim array11 As Object() = New Object() { Nothing, sPwd }
					array11(0) = True
					Dim array12 As Object() = array11
					array2 = array12
					Dim array13 As String() = New String() { "AllowFormattingColumns" }
					Dim array14 As Type() = Nothing
					Dim array15 As Boolean() = New Boolean() { Nothing, True }
					array6 = array15
					NewLateBinding.LateCall(obj9, type3, text6, array12, array13, array14, array15, True)
					If array6(1) Then
						sPwd = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(1)), GetType(String)))
					End If
				End If
				Dim obj10 As Object = obj3
				Dim type4 As Type = Nothing
				Dim text7 As String = "SaveAs"
				Dim array16 As Object() = New Object() { text2 }
				array2 = array16
				Dim array17 As String() = Nothing
				Dim array18 As Type() = Nothing
				Dim array19 As Boolean() = New Boolean() { True }
				array6 = array19
				NewLateBinding.LateCall(obj10, type4, text7, array16, array17, array18, array19, True)
				If array6(0) Then
					text2 = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(String)))
				End If
				text3 = text2
			Catch ex As Exception
				text3 += ex.Message
			Finally
				Try
					Dim flag6 As Boolean = obj3 IsNot Nothing
					If flag6 Then
						NewLateBinding.LateCall(obj3, Nothing, "Close", New Object() { False }, Nothing, Nothing, Nothing, True)
					End If
					Dim flag7 As Boolean = obj IsNot Nothing
					If flag7 Then
						NewLateBinding.LateCall(obj, Nothing, "Quit", New Object(-1) {}, Nothing, Nothing, Nothing, True)
					End If
				Catch ex2 As Exception
				End Try
				MainModule.ReleaseComObjectSafe(RuntimeHelpers.GetObjectValue(obj5))
				MainModule.ReleaseComObjectSafe(RuntimeHelpers.GetObjectValue(obj4))
				MainModule.ReleaseComObjectSafe(RuntimeHelpers.GetObjectValue(obj3))
				MainModule.ReleaseComObjectSafe(RuntimeHelpers.GetObjectValue(obj2))
				MainModule.ReleaseComObjectSafe(RuntimeHelpers.GetObjectValue(obj))
				obj5 = Nothing
				obj4 = Nothing
				obj3 = Nothing
				obj2 = Nothing
				obj = Nothing
				GC.Collect()
				GC.WaitForPendingFinalizers()
				GC.Collect()
				GC.WaitForPendingFinalizers()
				Dim processById As Process
				Dim flag8 As Boolean = Not processById.HasExited
				If flag8 Then
					processById.Kill()
				End If
				Cursor.Current = Cursors.[Default]
			End Try
			Return text3
		End Function

		' Token: 0x06000BAE RID: 2990 RVA: 0x000711D4 File Offset: 0x0006F3D4
		Private Sub ReleaseComObjectSafe(obj As Object)
			Try
				Dim flag As Boolean = obj IsNot Nothing
				If flag Then
					Marshal.FinalReleaseComObject(RuntimeHelpers.GetObjectValue(obj))
				End If
			Catch ex As Exception
			Finally
				obj = Nothing
			End Try
		End Sub

		' Token: 0x06000BAF RID: 2991 RVA: 0x0007122C File Offset: 0x0006F42C
		Public Function MakeArray(sHeading As String) As Object
			Dim serverDate As DateTime = MainModule.GetServerDate()
			Return New ArrayList() From { sHeading, "Action By Name :" + GlobalVariables.gsUserName, "Action By ID       :" + GlobalVariables.gsLoginID, "Action On" & vbTab & "           :" + Conversions.ToString(serverDate) }
		End Function

		' Token: 0x06000BB0 RID: 2992 RVA: 0x00071298 File Offset: 0x0006F498
		Public Function CheckEAN(sEAN As String) As Boolean
			Dim oDB As Object = GlobalVariables.oDB
			Dim type As Type = Nothing
			Dim text As String = "CheckEAN"
			Dim array As Object() = New Object() { sEAN }
			Dim array2 As Object() = array
			Dim array3 As String() = Nothing
			Dim array4 As Type() = Nothing
			Dim array5 As Boolean() = New Boolean() { True }
			Dim array6 As Boolean() = array5
			Dim obj As Object = NewLateBinding.LateGet(oDB, type, text, array, array3, array4, array5)
			If array6(0) Then
				sEAN = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(String)))
			End If
			Return Conversions.ToBoolean(obj)
		End Function

		' Token: 0x06000BB1 RID: 2993 RVA: 0x00071300 File Offset: 0x0006F500
		Public Function GetCheckEAN(sEAN As String) As Integer
			Dim oDB As Object = GlobalVariables.oDB
			Dim type As Type = Nothing
			Dim text As String = "GetCheckEAN"
			Dim array As Object() = New Object() { sEAN }
			Dim array2 As Object() = array
			Dim array3 As String() = Nothing
			Dim array4 As Type() = Nothing
			Dim array5 As Boolean() = New Boolean() { True }
			Dim array6 As Boolean() = array5
			Dim obj As Object = NewLateBinding.LateGet(oDB, type, text, array, array3, array4, array5)
			If array6(0) Then
				sEAN = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(String)))
			End If
			Return Conversions.ToInteger(obj)
		End Function

		' Token: 0x06000BB2 RID: 2994 RVA: 0x00071368 File Offset: 0x0006F568
		Public Function GetCheckGTIN(sEAN As String) As Integer
			Dim oDB As Object = GlobalVariables.oDB
			Dim type As Type = Nothing
			Dim text As String = "GetCheckGTIN"
			Dim array As Object() = New Object() { sEAN }
			Dim array2 As Object() = array
			Dim array3 As String() = Nothing
			Dim array4 As Type() = Nothing
			Dim array5 As Boolean() = New Boolean() { True }
			Dim array6 As Boolean() = array5
			Dim obj As Object = NewLateBinding.LateGet(oDB, type, text, array, array3, array4, array5)
			If array6(0) Then
				sEAN = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(String)))
			End If
			Return Conversions.ToInteger(obj)
		End Function

		' Token: 0x06000BB3 RID: 2995 RVA: 0x000713D0 File Offset: 0x0006F5D0
		Public Function GetCheckSum(sStr As String) As Integer
			Dim oDB As Object = GlobalVariables.oDB
			Dim type As Type = Nothing
			Dim text As String = "GetCheckSum"
			Dim array As Object() = New Object() { sStr }
			Dim array2 As Object() = array
			Dim array3 As String() = Nothing
			Dim array4 As Type() = Nothing
			Dim array5 As Boolean() = New Boolean() { True }
			Dim array6 As Boolean() = array5
			Dim obj As Object = NewLateBinding.LateGet(oDB, type, text, array, array3, array4, array5)
			If array6(0) Then
				sStr = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(String)))
			End If
			Return Conversions.ToInteger(obj)
		End Function

		' Token: 0x06000BB4 RID: 2996 RVA: 0x00071438 File Offset: 0x0006F638
		Public Function Reverse(value As String) As String
			Dim oDB As Object = GlobalVariables.oDB
			Dim type As Type = Nothing
			Dim text As String = "Reverse"
			Dim array As Object() = New Object() { value }
			Dim array2 As Object() = array
			Dim array3 As String() = Nothing
			Dim array4 As Type() = Nothing
			Dim array5 As Boolean() = New Boolean() { True }
			Dim array6 As Boolean() = array5
			Dim obj As Object = NewLateBinding.LateGet(oDB, type, text, array, array3, array4, array5)
			If array6(0) Then
				value = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(String)))
			End If
			Return Conversions.ToString(obj)
		End Function

		' Token: 0x06000BB5 RID: 2997 RVA: 0x000714A0 File Offset: 0x0006F6A0
		Public Function GetUniqueNo(sPlant As String, sLine As String, sDay As String, sMon As String, sYr As String, sLastSeqNo As String) As String
			Dim oDB As Object = GlobalVariables.oDB
			Dim type As Type = Nothing
			Dim text As String = "GetUniqueNo"
			Dim array As Object() = New Object() { sPlant, sLine, sDay, sMon, sYr, sLastSeqNo }
			Dim array2 As Object() = array
			Dim array3 As String() = Nothing
			Dim array4 As Type() = Nothing
			Dim array5 As Boolean() = New Boolean() { True, True, True, True, True, True }
			Dim array6 As Boolean() = array5
			Dim obj As Object = NewLateBinding.LateGet(oDB, type, text, array, array3, array4, array5)
			If array6(0) Then
				sPlant = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(String)))
			End If
			If array6(1) Then
				sLine = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(1)), GetType(String)))
			End If
			If array6(2) Then
				sDay = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(2)), GetType(String)))
			End If
			If array6(3) Then
				sMon = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(3)), GetType(String)))
			End If
			If array6(4) Then
				sYr = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(4)), GetType(String)))
			End If
			If array6(5) Then
				sLastSeqNo = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(5)), GetType(String)))
			End If
			Return Conversions.ToString(obj)
		End Function

		' Token: 0x06000BB6 RID: 2998 RVA: 0x000715E0 File Offset: 0x0006F7E0
		Public Function GetUniqueNo12(sDay As String, sMon As String, sYr As String, sLastSeqNo As String) As String
			Dim oDB As Object = GlobalVariables.oDB
			Dim type As Type = Nothing
			Dim text As String = "GetUniqueNo12"
			Dim array As Object() = New Object() { sDay, sMon, sYr, sLastSeqNo }
			Dim array2 As Object() = array
			Dim array3 As String() = Nothing
			Dim array4 As Type() = Nothing
			Dim array5 As Boolean() = New Boolean() { True, True, True, True }
			Dim array6 As Boolean() = array5
			Dim obj As Object = NewLateBinding.LateGet(oDB, type, text, array, array3, array4, array5)
			If array6(0) Then
				sDay = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(String)))
			End If
			If array6(1) Then
				sMon = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(1)), GetType(String)))
			End If
			If array6(2) Then
				sYr = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(2)), GetType(String)))
			End If
			If array6(3) Then
				sLastSeqNo = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(3)), GetType(String)))
			End If
			Return Conversions.ToString(obj)
		End Function

		' Token: 0x06000BB7 RID: 2999 RVA: 0x000716CC File Offset: 0x0006F8CC
		Public Function GetRandomNo(iMaxVal As Integer) As String
			Dim oDB As Object = GlobalVariables.oDB
			Dim type As Type = Nothing
			Dim text As String = "GetRandomNo"
			Dim array As Object() = New Object() { iMaxVal }
			Dim array2 As Object() = array
			Dim array3 As String() = Nothing
			Dim array4 As Type() = Nothing
			Dim array5 As Boolean() = New Boolean() { True }
			Dim array6 As Boolean() = array5
			Dim obj As Object = NewLateBinding.LateGet(oDB, type, text, array, array3, array4, array5)
			If array6(0) Then
				iMaxVal = CInt(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(Integer)))
			End If
			Return obj.ToString().ToUpper()
		End Function

		' Token: 0x06000BB8 RID: 3000 RVA: 0x00071740 File Offset: 0x0006F940
		Public Function GetSeqNo(sStr As String) As String
			Dim oDB As Object = GlobalVariables.oDB
			Dim type As Type = Nothing
			Dim text As String = "GetSeqNo"
			Dim array As Object() = New Object() { sStr }
			Dim array2 As Object() = array
			Dim array3 As String() = Nothing
			Dim array4 As Type() = Nothing
			Dim array5 As Boolean() = New Boolean() { True }
			Dim array6 As Boolean() = array5
			Dim obj As Object = NewLateBinding.LateGet(oDB, type, text, array, array3, array4, array5)
			If array6(0) Then
				sStr = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(String)))
			End If
			Return Conversions.ToString(obj)
		End Function

		' Token: 0x06000BB9 RID: 3001 RVA: 0x000717A8 File Offset: 0x0006F9A8
		Public Function MaxSeqNo(sStr As String, iQty As Long) As String
			Dim oDB As Object = GlobalVariables.oDB
			Dim type As Type = Nothing
			Dim text As String = "MaxSeqNo"
			Dim array As Object() = New Object() { sStr, iQty }
			Dim array2 As Object() = array
			Dim array3 As String() = Nothing
			Dim array4 As Type() = Nothing
			Dim array5 As Boolean() = New Boolean() { True, True }
			Dim array6 As Boolean() = array5
			Dim obj As Object = NewLateBinding.LateGet(oDB, type, text, array, array3, array4, array5)
			If array6(0) Then
				sStr = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(String)))
			End If
			If array6(1) Then
				iQty = CLng(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(1)), GetType(Long)))
			End If
			Return Conversions.ToString(obj)
		End Function

		' Token: 0x06000BBA RID: 3002 RVA: 0x00071844 File Offset: 0x0006FA44
		Public Function SetLookUpTable() As DataTable
			Return CType(NewLateBinding.LateGet(GlobalVariables.oDB, Nothing, "SetLookUpTable", New Object(-1) {}, Nothing, Nothing, Nothing), DataTable)
		End Function

		' Token: 0x06000BBB RID: 3003 RVA: 0x00071874 File Offset: 0x0006FA74
		Public Function Encrypt(sData As String, sPwd As String) As String
			Dim oDB As Object = GlobalVariables.oDB
			Dim type As Type = Nothing
			Dim text As String = "Encrypt"
			Dim array As Object() = New Object() { sData, sPwd }
			Dim array2 As Object() = array
			Dim array3 As String() = Nothing
			Dim array4 As Type() = Nothing
			Dim array5 As Boolean() = New Boolean() { True, True }
			Dim array6 As Boolean() = array5
			Dim obj As Object = NewLateBinding.LateGet(oDB, type, text, array, array3, array4, array5)
			If array6(0) Then
				sData = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(String)))
			End If
			If array6(1) Then
				sPwd = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(1)), GetType(String)))
			End If
			Return Conversions.ToString(obj)
		End Function

		' Token: 0x06000BBC RID: 3004 RVA: 0x0007190C File Offset: 0x0006FB0C
		Public Function Decrypt(sData As String, sPwd As String) As String
			Dim oDB As Object = GlobalVariables.oDB
			Dim type As Type = Nothing
			Dim text As String = "Decrypt"
			Dim array As Object() = New Object() { sData, sPwd }
			Dim array2 As Object() = array
			Dim array3 As String() = Nothing
			Dim array4 As Type() = Nothing
			Dim array5 As Boolean() = New Boolean() { True, True }
			Dim array6 As Boolean() = array5
			Dim obj As Object = NewLateBinding.LateGet(oDB, type, text, array, array3, array4, array5)
			If array6(0) Then
				sData = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(String)))
			End If
			If array6(1) Then
				sPwd = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(1)), GetType(String)))
			End If
			Return Conversions.ToString(obj)
		End Function

		' Token: 0x06000BBD RID: 3005 RVA: 0x000719A4 File Offset: 0x0006FBA4
		Public Function EncryptData(input As String, pass As String) As String
			Dim rijndaelManaged As RijndaelManaged = New RijndaelManaged()
			Dim md5CryptoServiceProvider As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
			Dim text2 As String
			Try
				Dim array As Byte() = New Byte(31) {}
				Dim array2 As Byte() = md5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass))
				Array.Copy(array2, 0, array, 0, 16)
				Array.Copy(array2, 0, array, 15, 16)
				rijndaelManaged.Key = array
				rijndaelManaged.Mode = CipherMode.ECB
				Dim cryptoTransform As ICryptoTransform = rijndaelManaged.CreateEncryptor()
				Dim bytes As Byte() = Encoding.ASCII.GetBytes(input)
				Dim text As String = Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length))
				text2 = text
			Catch ex As Exception
				text2 = "Error " + ex.Message
			End Try
			Return text2
		End Function

		' Token: 0x06000BBE RID: 3006 RVA: 0x00071A70 File Offset: 0x0006FC70
		Public Function DecryptData(input As String, pass As String) As String
			Dim rijndaelManaged As RijndaelManaged = New RijndaelManaged()
			Dim md5CryptoServiceProvider As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
			Dim text As String
			Try
				Dim array As Byte() = New Byte(31) {}
				Dim array2 As Byte() = md5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass))
				Array.Copy(array2, 0, array, 0, 16)
				Array.Copy(array2, 0, array, 15, 16)
				rijndaelManaged.Key = array
				rijndaelManaged.Mode = CipherMode.ECB
				Dim cryptoTransform As ICryptoTransform = rijndaelManaged.CreateDecryptor()
				Dim array3 As Byte() = Convert.FromBase64String(input)
				Dim b As Byte = 0
				Dim array4 As Byte() = cryptoTransform.TransformFinalBlock(array3, 0, CInt(Math.Round(Conversion.Val(array3.Length))))
				Dim [string] As String = Encoding.ASCII.GetString(array4, 0, CInt(Math.Round(Conversion.Val(array4.Length))))
				text = [string]
			Catch ex As Exception
				text = "Error " + ex.Message
			End Try
			Return text
		End Function

		' Token: 0x06000BBF RID: 3007 RVA: 0x00071B6C File Offset: 0x0006FD6C
		Public Function TrnLog(sTrnOn As String, sTrnType As String, sDetails As String, Optional dt As DataTable = Nothing) As Boolean
			Dim flag As Boolean = Operators.CompareString(FeaturesVariables.gs21_CFR_Part_11, "Yes", False) = 0
			If flag Then
				Try
					Dim dateTime As DateTime = Conversions.ToDate(MainModule.CheckConnection("").Rows(0)(0))
					Dim text As String = Conversions.ToString(1)
					Dim text2 As String = Conversions.ToString(1)
					Dim text3 As String = Conversions.ToString(1)
					Dim flag2 As Boolean = Operators.CompareString(GlobalVariables.gsCompanyID, "", False) <> 0
					If flag2 Then
						text = GlobalVariables.gsCompanyID
					End If
					Dim flag3 As Boolean = Operators.CompareString(GlobalVariables.gsPlantID, "", False) <> 0
					If flag3 Then
						text2 = GlobalVariables.gsPlantID
					End If
					Dim flag4 As Boolean = Operators.CompareString(GlobalVariables.gsUserID, "", False) <> 0
					If flag4 Then
						text3 = GlobalVariables.gsUserID
					End If
					Dim text4 As String = MainModule.EncryptData(String.Concat(New String() { Strings.Format(dateTime, "MM-dd-yyyy HH:mm:ss"), vbTab, sTrnOn, vbTab, sTrnType, vbTab, text, vbTab, text2, vbTab, text3 }), GlobalVariables.gsPwd)
					Dim text5 As String = String.Concat(New String() { "Login ID:", GlobalVariables.gsLoginID, vbCrLf & ", Computer Name:", GlobalVariables.gsPCName, vbCrLf & ", Computer IP:", GlobalVariables.gsPCIP, vbCrLf & ", Application:", GlobalVariables.gsAppVersionInfo.FileVersion, vbCrLf & ", Systems:", GlobalVariables.gsSysVersionInfo.FileVersion })
					Dim text6 As String = " INSERT INTO TrnLog(TrnDate, TrnOn, TrnType, CompanyID, PlantID, TrnDtls, LogDtls, TrnBy, DataCheckSum)"
					text6 = String.Concat(New String() { text6, " VALUES ('", Strings.Format(dateTime, "MM/dd/yyyy HH:mm:ss"), "', '", sTrnOn, "', '", sTrnType, "', " })
					text6 = String.Concat(New String() { text6, " '", text, "', '", text2, "','", sDetails, "', '", text5, "', '", text3, "', '", text4, "')" })
					text6 += " SELECT SCOPE_IDENTITY() AS NewID"
					Dim dataTable As DataTable = MainModule.CheckConnection(text6)
					Dim flag5 As Boolean = dataTable.Columns.Count > 0
					If flag5 Then
						Dim flag6 As Boolean = Operators.CompareString(dataTable.Columns(0).ColumnName, "ErrorColumn", False) = 0
						If flag6 Then
							Dim flag7 As Boolean = Strings.InStr(Conversions.ToString(dataTable.Rows(0)("ExceptionMsg")), "Login failed for user", CompareMethod.Binary) > 0
							If flag7 Then
								CustomMsgBox.Show(Conversions.ToString(dataTable.Rows(0)("ErrorColumn")), "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
							Else
								Dim flag8 As Boolean = Strings.InStr(Conversions.ToString(dataTable.Rows(0)("ExceptionMsg")), "A network-related or instance-specific error", CompareMethod.Binary) > 0
								If flag8 Then
									CustomMsgBox.Show(Conversions.ToString(dataTable.Rows(0)("ErrorColumn")), "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								Else
									CustomMsgBox.Show(Conversions.ToString(dataTable.Rows(0)("ErrorColumn")), "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
								End If
							End If
							Return False
						End If
						MainModule.TrnDtlsInsert(dt, Conversions.ToString(dataTable.Rows(0)("NewID")))
					End If
					Return True
				Catch ex As Exception
					CustomMsgBox.Show("Error : " + ex.Message, "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Return False
				End Try
			End If
			Return True
		End Function

		' Token: 0x06000BC0 RID: 3008 RVA: 0x00071F88 File Offset: 0x00070188
		Private Function TrnDtlsInsert(dt As DataTable, sTrnID As String) As Boolean
			Dim flag As Boolean = Not Information.IsNothing(dt) And (Operators.CompareString(FeaturesVariables.gs21_CFR_Part_11, "Yes", False) = 0) And (Operators.CompareString(FeaturesVariables.gs21_CFR_Part_11_Dtls, "Yes", False) = 0)
			If flag Then
				Dim flag2 As Boolean = dt.Rows.Count > 0
				If flag2 Then
					Dim sqlConnection As SqlConnection = New SqlConnection(GlobalVariables.gsConStr)
					sqlConnection.Open()
					Dim sqlTransaction As SqlTransaction = sqlConnection.BeginTransaction(IsolationLevel.ReadCommitted)
					Try
						dt.Columns.Add(New DataColumn() With { .ColumnName = "TrnID", .DataType = GetType(String), .DefaultValue = sTrnID })
						Dim sqlBulkCopy As SqlBulkCopy = New SqlBulkCopy(sqlConnection, SqlBulkCopyOptions.[Default], sqlTransaction)
						sqlBulkCopy.DestinationTableName = "TrnLogDtls"
						sqlBulkCopy.BulkCopyTimeout = 60000
						sqlBulkCopy.BatchSize = 500
						sqlBulkCopy.ColumnMappings.Add("FieldName", "FieldName")
						sqlBulkCopy.ColumnMappings.Add("OldValue", "OldValue")
						sqlBulkCopy.ColumnMappings.Add("NewValue", "NewValue")
						sqlBulkCopy.ColumnMappings.Add("TrnID", "TrnID")
						sqlBulkCopy.WriteToServer(dt)
						sqlBulkCopy.Close()
						sqlTransaction.Commit()
						sqlConnection.Close()
						Return True
					Catch ex As Exception
						sqlTransaction.Rollback()
						CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					End Try
					Return False
				End If
			End If
			Return True
		End Function

		' Token: 0x06000BC1 RID: 3009 RVA: 0x00072148 File Offset: 0x00070348
		Public Sub DownloadTemplate(sTemplateName As String, sDestination As String)
			Try
				Dim text As String = ""
				Dim num As UInteger = <PrivateImplementationDetails>.ComputeStringHash(sTemplateName)
				If num <= 3027875361UI Then
					If num <= 1836194042UI Then
						If num <> 1691845658UI Then
							If num = 1836194042UI Then
								If Operators.CompareString(sTemplateName, "UserMasterTemplate", False) = 0 Then
									text = "UserMasterTemplate.zip"
								End If
							End If
						ElseIf Operators.CompareString(sTemplateName, "PlantMasterTemplate", False) = 0 Then
							text = "PlantMasterTemplate.zip"
						End If
					ElseIf num <> 2550441563UI Then
						If num = 3027875361UI Then
							If Operators.CompareString(sTemplateName, "UserGroupMasterTemplate", False) = 0 Then
								text = "UserGroupMasterTemplate.zip"
							End If
						End If
					ElseIf Operators.CompareString(sTemplateName, "ChecklistMasterTemplate", False) = 0 Then
						text = "ChecklistMasterTemplate.zip"
					End If
				ElseIf num <= 3556837068UI Then
					If num <> 3311689939UI Then
						If num = 3556837068UI Then
							If Operators.CompareString(sTemplateName, "DispensingAreaMasterTemplate", False) = 0 Then
								text = "DispensingAreaMasterTemplate.zip"
							End If
						End If
					ElseIf Operators.CompareString(sTemplateName, "EquipmentMasterTemplate", False) = 0 Then
						text = "EquipmentMasterTemplate.zip"
					End If
				ElseIf num <> 3644139308UI Then
					If num = 3700201400UI Then
						If Operators.CompareString(sTemplateName, "MaterialMasterTemplate", False) = 0 Then
							text = "MaterialMasterTemplate.zip"
						End If
					End If
				ElseIf Operators.CompareString(sTemplateName, "ProductMasterTemplate", False) = 0 Then
					text = "ProductMasterTemplate.zip"
				End If
				Dim text2 As String = GlobalVariables.gsTemplatePath + text
				sDestination = Strings.Replace(sDestination + "\" + text, "\\", "", 1, -1, CompareMethod.Binary)
				Dim flag As Boolean = Not MyProject.Computer.FileSystem.FileExists(text2)
				If flag Then
					CustomMsgBox.Show(sTemplateName + " Missing, Contact Vendor.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Else
					Dim flag2 As Boolean = MyProject.Computer.FileSystem.FileExists(sDestination)
					If flag2 Then
						CustomMsgBox.Show(sTemplateName + " File Already Exists In Destination.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
					Else
						Dim flag3 As Boolean = (Operators.CompareString(sDestination, "", False) <> 0) And (Operators.CompareString(text2, "", False) <> 0)
						If flag3 Then
							MyProject.Computer.FileSystem.CopyFile(text2, sDestination)
						End If
						Dim text3 As String = "Source : " + text2 + vbCrLf
						text3 = text3 + "Destination : " + sDestination
						MainModule.TrnLog(sTemplateName, "Download Template", text3, Nothing)
						CustomMsgBox.Show("Download Complete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
					End If
				End If
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x06000BC2 RID: 3010 RVA: 0x00072434 File Offset: 0x00070634
		Public Function FilteredSQLString(SQL As String, Len As Integer) As String
			Dim text As String = ""
			Dim length As Integer = SQL.Length
			For i As Integer = 1 To length
				Dim text2 As String = Strings.Mid(SQL, i, 1)
				Dim text3 As String = Strings.LCase(text2)
				If Operators.CompareString(text3, "&", False) <> 0 Then
					If Operators.CompareString(text3, "<", False) <> 0 Then
						If Operators.CompareString(text3, ">", False) <> 0 Then
							If Operators.CompareString(text3, "'", False) <> 0 Then
								If Operators.CompareString(text3, """", False) <> 0 Then
									text += text2
								Else
									text += "`"
								End If
							Else
								text += "`"
							End If
						Else
							text += "&gt;"
						End If
					Else
						text += "&lt;"
					End If
				Else
					text += "&amp;"
				End If
			Next
			Dim flag As Boolean = text.Length > Len
			Dim text4 As String
			If flag Then
				text4 = "False"
			Else
				text4 = text
			End If
			Return text4
		End Function

		' Token: 0x06000BC3 RID: 3011 RVA: 0x00072538 File Offset: 0x00070738
		Public Function FilteredPRNComma(sStr As String) As String
			Return sStr.Replace(",", " ")
		End Function

		' Token: 0x06000BC4 RID: 3012 RVA: 0x0007255C File Offset: 0x0007075C
		Public Function GenMaxSerial(sQty As String, oCon As SqlConnection, oTrn As SqlTransaction) As Object
			Dim flag As Boolean = False
			Dim num As Integer = Conversions.ToInteger(sQty)
			Dim text As String = "0000000000000000"
			text = Strings.Mid(text, 1, text.Length - GlobalVariables.gsGS1Code.Length)
			Dim num2 As Long = CLng((16 - GlobalVariables.gsGS1Code.Length))
			Dim num3 As Integer = CInt(num2)
			Dim num4 As Long
			For i As Integer = 1 To num3
				num4 = Conversions.ToLong(Conversions.ToString(num4) + Conversions.ToString(9))
			Next
			Dim text2 As String = " SELECT ISNULL (MAX(MaxSerialNo),0) AS MaxSerialNo FROM OrderManagement "
			text2 += " INNER JOIN Plant ON OrderManagement.PlantID = Plant.PlantID "
			text2 += " INNER JOIN Company ON plant.CompanyID = Company.CompanyID "
			text2 += " WHERE OrderManagement.PackingLevel = 'Tertiary' "
			text2 = text2 + " AND Company.GS1Code = '" + GlobalVariables.gsGS1Code + "' "
			Dim data As DataTable = MainModule.GetData(text2, oCon, oTrn)
			Dim text3 As String = Strings.Format(Conversion.Val(data.Rows(0)("MaxSerialNo").ToString()), "#" + text)
			Dim flag2 As Boolean = Conversion.Val(text3) = 0.0
			Dim num5 As Long
			Dim num6 As Long
			If flag2 Then
				' The following expression was wrapped in a unchecked-expression
				num5 = CLng(GlobalVariables.gsSSCCExtensionDigit)
				num6 = CLng(Math.Round(Conversion.Val(Strings.Mid(text3, 2)) + CDbl(num)))
			Else
				num5 = Conversions.ToLong(Strings.Mid(text3, 1, 1))
				Dim flag3 As Boolean = Conversion.Val(Strings.Mid(text3, 2)) + CDbl(num) >= CDbl(num4)
				If flag3 Then
					' The following expression was wrapped in a unchecked-expression
					num6 = CLng(Math.Round(Conversion.Val(text3) + CDbl(num)))
					flag = True
				Else
					' The following expression was wrapped in a unchecked-expression
					num6 = CLng(Math.Round(Conversion.Val(Strings.Mid(text3, 2)) + CDbl(num)))
				End If
			End If
			Dim flag4 As Boolean = flag
			Dim text4 As String
			If flag4 Then
				text4 = Conversions.ToString(num6)
			Else
				text4 = Conversions.ToString(num5) + Strings.Format(num6, "#" + text)
			End If
			Dim text5 As String = text4
			Return text3 + "," + text5
		End Function

		' Token: 0x06000BC5 RID: 3013 RVA: 0x00072744 File Offset: 0x00070944
		Public Function GetPlantCode(value As String) As String
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = 10 * "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".IndexOf(value.Substring(0, 1)) + Integer.Parse(value.Substring(1, 1))
			num += 1
			Return "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".Substring(num / 10, 1) + (num Mod 10).ToString().PadLeft(1, "0"c)
		End Function

		' Token: 0x06000BC6 RID: 3014 RVA: 0x000727A8 File Offset: 0x000709A8
		Public Function ValidateEmailID(sEmailID As String) As Boolean
			Try
				Dim mailAddress As MailAddress = New MailAddress(sEmailID)
			Catch ex As Exception
				Return False
			End Try
			Return True
		End Function

		' Token: 0x06000BC7 RID: 3015 RVA: 0x000727E8 File Offset: 0x000709E8
		Public Sub TextToSpeech(sText As String)
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("SAPI.spvoice", ""))
			NewLateBinding.LateSet(objectValue, Nothing, "Voice", New Object() { NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, Nothing, "GetVoices", New Object(-1) {}, Nothing, Nothing, Nothing), Nothing, "Item", New Object() { 0 }, Nothing, Nothing, Nothing) }, Nothing, Nothing)
			Dim obj As Object = objectValue
			Dim type As Type = Nothing
			Dim text As String = "Speak"
			Dim array As Object() = New Object() { sText, 1 }
			Dim array2 As Object() = array
			Dim array3 As String() = Nothing
			Dim array4 As Type() = Nothing
			Dim array5 As Boolean() = New Boolean(1) {}
			array5(0) = True
			Dim array6 As Boolean() = array5
			NewLateBinding.LateCall(obj, type, text, array, array3, array4, array5, True)
			If array6(0) Then
				sText = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2(0)), GetType(String)))
			End If
		End Sub

		' Token: 0x06000BC8 RID: 3016 RVA: 0x000728AC File Offset: 0x00070AAC
		Public Function ImageToBase64(_image As Image) As String
			Dim text2 As String
			Using memoryStream As MemoryStream = New MemoryStream()
				Dim bmp As ImageFormat = ImageFormat.Bmp
				_image.Save(memoryStream, bmp)
				Dim array As Byte() = memoryStream.ToArray()
				Dim text As String = Convert.ToBase64String(array)
				memoryStream.Close()
				memoryStream.Dispose()
				text2 = text
			End Using
			Return text2
		End Function

		' Token: 0x06000BC9 RID: 3017 RVA: 0x00072910 File Offset: 0x00070B10
		Public Function ImageToBytes(_image As Image) As Byte()
			Dim array2 As Byte()
			Using memoryStream As MemoryStream = New MemoryStream()
				Dim bmp As ImageFormat = ImageFormat.Bmp
				_image.Save(memoryStream, bmp)
				Dim array As Byte() = memoryStream.ToArray()
				Dim text As String = Convert.ToBase64String(array)
				memoryStream.Close()
				memoryStream.Dispose()
				array2 = array
			End Using
			Return array2
		End Function

		' Token: 0x06000BCA RID: 3018 RVA: 0x00072974 File Offset: 0x00070B74
		Public Function Base64ToImage(base64String As String) As Image
			Dim array As Byte() = Convert.FromBase64String(base64String)
			Dim memoryStream As MemoryStream = New MemoryStream(array, 0, array.Length)
			memoryStream.Write(array, 0, array.Length)
			Return Image.FromStream(memoryStream, True)
		End Function

		' Token: 0x06000BCB RID: 3019 RVA: 0x000729B0 File Offset: 0x00070BB0
		Public Function BytesToImage(imageBytes As Byte()) As Image
			Dim memoryStream As MemoryStream = New MemoryStream(imageBytes, 0, imageBytes.Length)
			memoryStream.Write(imageBytes, 0, imageBytes.Length)
			Return Image.FromStream(memoryStream, True)
		End Function

		' Token: 0x06000BCC RID: 3020 RVA: 0x000729E4 File Offset: 0x00070BE4
		Public Function IsValidEmailFormat(sEmailID As String) As Boolean
			Try
				Dim mailAddress As MailAddress = New MailAddress(sEmailID)
			Catch ex As Exception
				Return False
			End Try
			Return True
		End Function

		' Token: 0x06000BCD RID: 3021 RVA: 0x00072A24 File Offset: 0x00070C24
		Public Sub SetDataGridViewColumns(dgv As DataGridView, sType As String)
			Dim text As String = AppDomain.CurrentDomain.BaseDirectory.ToString()
			Dim fileStream As FileStream = New FileStream(text + "dgvCol.txt", FileMode.Create)
			Dim streamWriter As StreamWriter = New StreamWriter(fileStream)
			streamWriter.BaseStream.Seek(0L, SeekOrigin.Begin)
			Dim text2 As String = ""
			Dim num As Integer = dgv.Columns.Count - 1
			For i As Integer = 0 To num
				Dim visible As Boolean = dgv.Columns(i).Visible
				If visible Then
					If Operators.CompareString(sType, "width", False) <> 0 Then
						If Operators.CompareString(sType, "date format", False) <> 0 Then
							If Operators.CompareString(sType, "header", False) = 0 Then
								text2 = String.Concat(New String() { "dgvList.Columns(""", dgv.Columns(i).Name, """).HeaderText = """, dgv.Columns(i).Name, """" })
							End If
						Else
							text2 = "dgvList.Columns(""" + dgv.Columns(i).Name + """).DefaultCellStyle.Format = ""dd MMM yyyy"""
						End If
					Else
						text2 = "dgvList.Columns(""" + dgv.Columns(i).Name + """).Width =" + Conversions.ToString(dgv.Columns(i).Width)
					End If
					streamWriter.WriteLine(text2)
				End If
			Next
			streamWriter.Close()
			fileStream.Close()
			Interaction.MsgBox("Done", MsgBoxStyle.OkOnly, Nothing)
		End Sub
	End Module
End Namespace
