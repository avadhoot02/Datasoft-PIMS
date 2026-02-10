Imports System
Imports System.Runtime.InteropServices

Namespace Datasoft_PIMS
	' Token: 0x02000031 RID: 49
	Public Class IdleTime1
		' Token: 0x06000B81 RID: 2945
		Private Declare Function GetLastInputInfo Lib "user32.dll" (ByRef plii As IdleTime1.LASTINPUTINFO) As Boolean

		' Token: 0x06000B82 RID: 2946 RVA: 0x0006CAC0 File Offset: 0x0006ACC0
		Public Function GetInactiveTime() As TimeSpan?
			Dim lastinputinfo As IdleTime1.LASTINPUTINFO = Nothing
			lastinputinfo.cbSize = CUInt(Marshal.SizeOf(Of IdleTime1.LASTINPUTINFO)(lastinputinfo))
			Dim lastInputInfo As Boolean = IdleTime1.GetLastInputInfo(lastinputinfo)
			Dim timeSpan As TimeSpan?
			If lastInputInfo Then
				' The following expression was wrapped in a unchecked-expression
				' The following expression was wrapped in a unchecked-expression
				timeSpan = New TimeSpan?(TimeSpan.FromMilliseconds(CDbl((CLng(Environment.TickCount) - CLng((CULng(lastinputinfo.dwTime)))))))
			Else
				timeSpan = Nothing
			End If
			Return timeSpan
		End Function

		' Token: 0x0200008D RID: 141
		Public Structure LASTINPUTINFO
			' Token: 0x04000DC1 RID: 3521
			Public cbSize As UInteger

			' Token: 0x04000DC2 RID: 3522
			Public dwTime As UInteger
		End Structure
	End Class
End Namespace
