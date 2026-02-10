Imports System
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x0200002E RID: 46
	Friend NotInheritable Module FeaturesVariables
		' Token: 0x040004AE RID: 1198
		Public gsWebVerify As String = "No"

		' Token: 0x040004AF RID: 1199
		Public gs21_CFR_Part_11 As String = "Yes"

		' Token: 0x040004B0 RID: 1200
		Public gs21_CFR_Part_11_Dtls As String = "No"

		' Token: 0x040004B1 RID: 1201
		Public gsEmail_Alert As String = "Yes"

		' Token: 0x040004B2 RID: 1202
		Public gsProtecetd_Excel As String = "No"

		' Token: 0x040004B3 RID: 1203
		Public gsWrong_Attempt As Integer = 3

		' Token: 0x040004B4 RID: 1204
		Public gsPassword_History_Count As Integer = 3

		' Token: 0x040004B5 RID: 1205
		Public gsAuto_Lock_Time As Long = 1800L

		' Token: 0x040004B6 RID: 1206
		Public gsPassword_Length As Integer = 7

		' Token: 0x040004B7 RID: 1207
		Public gsPassword_Rest_Duration As Integer = 90
	End Module
End Namespace
