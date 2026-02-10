Imports System
Imports System.Data
Imports System.Diagnostics
Imports Datasoft_PIMS.My
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x02000030 RID: 48
	Friend NotInheritable Module GlobalVariables
		' Token: 0x040004B8 RID: 1208
		Public MdiClose As Boolean

		' Token: 0x040004B9 RID: 1209
		Public gsServerName As String

		' Token: 0x040004BA RID: 1210
		Public gsDbName As String

		' Token: 0x040004BB RID: 1211
		Public gsUserID As String

		' Token: 0x040004BC RID: 1212
		Public gsUserName As String

		' Token: 0x040004BD RID: 1213
		Public gsLoginID As String

		' Token: 0x040004BE RID: 1214
		Public gsLoginPwd As String

		' Token: 0x040004BF RID: 1215
		Public gsUserRFID As String

		' Token: 0x040004C0 RID: 1216
		Public gsEmailID As String

		' Token: 0x040004C1 RID: 1217
		Public gsUserGroupID As String

		' Token: 0x040004C2 RID: 1218
		Public gsUserGroup As String

		' Token: 0x040004C3 RID: 1219
		Public gsDepartment As String

		' Token: 0x040004C4 RID: 1220
		Public gsManager As String

		' Token: 0x040004C5 RID: 1221
		Public gsReportingTo As String

		' Token: 0x040004C6 RID: 1222
		Public gsManagerID As String

		' Token: 0x040004C7 RID: 1223
		Public gsReportingToID As String

		' Token: 0x040004C8 RID: 1224
		Public gsCompanyID As String

		' Token: 0x040004C9 RID: 1225
		Public gsGS1Code As String

		' Token: 0x040004CA RID: 1226
		Public gsCompanyCode As String

		' Token: 0x040004CB RID: 1227
		Public gsCompanyName As String

		' Token: 0x040004CC RID: 1228
		Public gsCompanyAddress As String

		' Token: 0x040004CD RID: 1229
		Public gsIdentifier As String

		' Token: 0x040004CE RID: 1230
		Public gsSSCCExtensionDigit As Integer

		' Token: 0x040004CF RID: 1231
		Public gsPlantID As String

		' Token: 0x040004D0 RID: 1232
		Public gsPlantCode As String

		' Token: 0x040004D1 RID: 1233
		Public gsPlantName As String

		' Token: 0x040004D2 RID: 1234
		Public gsMultiCompany As Boolean

		' Token: 0x040004D3 RID: 1235
		Public gsMultiPlant As Boolean

		' Token: 0x040004D4 RID: 1236
		Public gsLineControl As Boolean

		' Token: 0x040004D5 RID: 1237
		Public gsGRNAttachmentAfterApproval As Boolean

		' Token: 0x040004D6 RID: 1238
		Public gsdtAccessRights As DataTable

		' Token: 0x040004D7 RID: 1239
		Public gsDbUserID As String

		' Token: 0x040004D8 RID: 1240
		Public gsDbPwd As String

		' Token: 0x040004D9 RID: 1241
		Public gsIsWindowsAuthentication As String

		' Token: 0x040004DA RID: 1242
		Public gsLastSeqNo As String

		' Token: 0x040004DB RID: 1243
		Public gsConStr As String

		' Token: 0x040004DC RID: 1244
		Public gsbSQLConnection As Boolean

		' Token: 0x040004DD RID: 1245
		Public gsSessionID As String

		' Token: 0x040004DE RID: 1246
		Public gsPCName As String

		' Token: 0x040004DF RID: 1247
		Public gsPCIP As String

		' Token: 0x040004E0 RID: 1248
		Public sSDate As String

		' Token: 0x040004E1 RID: 1249
		Public sDays As Integer

		' Token: 0x040004E2 RID: 1250
		Public gsPath As String = MyProject.Application.Info.DirectoryPath

		' Token: 0x040004E3 RID: 1251
		Public gsSysVersionInfo As FileVersionInfo

		' Token: 0x040004E4 RID: 1252
		Public gsAppVersionInfo As FileVersionInfo

		' Token: 0x040004E5 RID: 1253
		Public gsUIVersionInfo As FileVersionInfo

		' Token: 0x040004E6 RID: 1254
		Public gsPwd As String = "DatacodeMaster"

		' Token: 0x040004E7 RID: 1255
		Public gsAdminPwd As String = "makesetting@786"

		' Token: 0x040004E8 RID: 1256
		Public gsOtherPwd As String = "datacode@123"

		' Token: 0x040004E9 RID: 1257
		Public gsExcelPassword As String = "datacode"

		' Token: 0x040004EA RID: 1258
		Public gsSeriveUser As String = "datacode"

		' Token: 0x040004EB RID: 1259
		Public gsServicePwd As String = "Data$C0de#"

		' Token: 0x040004EC RID: 1260
		Public gsAutoEmailID As String

		' Token: 0x040004ED RID: 1261
		Public gsAutoEmailPassword As String

		' Token: 0x040004EE RID: 1262
		Public gsDC_AutoEmailID As String = "datacode123@gmail.com"

		' Token: 0x040004EF RID: 1263
		Public gsDC_AutoEmailPassword As String = "vhfdudlxbqztxqme"

		' Token: 0x040004F0 RID: 1264
		Public gsTemplatePath As String = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Templates\"

		' Token: 0x040004F1 RID: 1265
		Public gsIsLocked As Boolean = False

		' Token: 0x040004F2 RID: 1266
		Public gsURL As String = "http://immunoact.in/"

		' Token: 0x040004F3 RID: 1267
		Public gsProductDetails As String

		' Token: 0x040004F4 RID: 1268
		Public gsProductQC As String

		' Token: 0x040004F5 RID: 1269
		Public gsProductBOM As String

		' Token: 0x040004F6 RID: 1270
		Public oDB As Object
	End Module
End Namespace
