Imports System
Imports System.Windows.Forms

Namespace Datasoft_PIMS
	' Token: 0x02000009 RID: 9
	Public Class CustomMsgBox
		' Token: 0x06000031 RID: 49 RVA: 0x00002C74 File Offset: 0x00000E74
		Public Shared Function Show(text As String) As DialogResult
			Dim dialogResult As DialogResult
			Using formMessageBox As FormMessageBox = New FormMessageBox(text)
				dialogResult = formMessageBox.ShowDialog()
			End Using
			Return dialogResult
		End Function

		' Token: 0x06000032 RID: 50 RVA: 0x00002CB4 File Offset: 0x00000EB4
		Public Shared Function Show(text As String, caption As String) As DialogResult
			Dim dialogResult As DialogResult
			Using formMessageBox As FormMessageBox = New FormMessageBox(text, caption)
				dialogResult = formMessageBox.ShowDialog()
			End Using
			Return dialogResult
		End Function

		' Token: 0x06000033 RID: 51 RVA: 0x00002CF8 File Offset: 0x00000EF8
		Public Shared Function Show(text As String, caption As String, buttons As MessageBoxButtons) As DialogResult
			Dim dialogResult As DialogResult
			Using formMessageBox As FormMessageBox = New FormMessageBox(text, caption, buttons)
				dialogResult = formMessageBox.ShowDialog()
			End Using
			Return dialogResult
		End Function

		' Token: 0x06000034 RID: 52 RVA: 0x00002D3C File Offset: 0x00000F3C
		Public Shared Function Show(text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon) As DialogResult
			Dim dialogResult As DialogResult
			Using formMessageBox As FormMessageBox = New FormMessageBox(text, caption, buttons, icon)
				dialogResult = formMessageBox.ShowDialog()
			End Using
			Return dialogResult
		End Function

		' Token: 0x06000035 RID: 53 RVA: 0x00002D80 File Offset: 0x00000F80
		Public Shared Function Show(text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon, defaultButton As MessageBoxDefaultButton) As DialogResult
			Dim dialogResult As DialogResult
			Using formMessageBox As FormMessageBox = New FormMessageBox(text, caption, buttons, icon, defaultButton)
				dialogResult = formMessageBox.ShowDialog()
			End Using
			Return dialogResult
		End Function

		' Token: 0x06000036 RID: 54 RVA: 0x00002DC8 File Offset: 0x00000FC8
		Public Shared Function Show(owner As IWin32Window, text As String) As DialogResult
			Dim dialogResult As DialogResult
			Using formMessageBox As FormMessageBox = New FormMessageBox(text)
				dialogResult = formMessageBox.ShowDialog(owner)
			End Using
			Return dialogResult
		End Function

		' Token: 0x06000037 RID: 55 RVA: 0x00002E0C File Offset: 0x0000100C
		Public Shared Function Show(owner As IWin32Window, text As String, caption As String) As DialogResult
			Dim dialogResult As DialogResult
			Using formMessageBox As FormMessageBox = New FormMessageBox(text, caption)
				dialogResult = formMessageBox.ShowDialog(owner)
			End Using
			Return dialogResult
		End Function

		' Token: 0x06000038 RID: 56 RVA: 0x00002E50 File Offset: 0x00001050
		Public Shared Function Show(owner As IWin32Window, text As String, caption As String, buttons As MessageBoxButtons) As DialogResult
			Dim dialogResult As DialogResult
			Using formMessageBox As FormMessageBox = New FormMessageBox(text, caption, buttons)
				dialogResult = formMessageBox.ShowDialog(owner)
			End Using
			Return dialogResult
		End Function

		' Token: 0x06000039 RID: 57 RVA: 0x00002E94 File Offset: 0x00001094
		Public Shared Function Show(owner As IWin32Window, text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon) As DialogResult
			Dim dialogResult As DialogResult
			Using formMessageBox As FormMessageBox = New FormMessageBox(text, caption, buttons, icon)
				dialogResult = formMessageBox.ShowDialog(owner)
			End Using
			Return dialogResult
		End Function

		' Token: 0x0600003A RID: 58 RVA: 0x00002EDC File Offset: 0x000010DC
		Public Shared Function Show(owner As IWin32Window, text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon, defaultButton As MessageBoxDefaultButton) As DialogResult
			Dim dialogResult As DialogResult
			Using formMessageBox As FormMessageBox = New FormMessageBox(text, caption, buttons, icon, defaultButton)
				dialogResult = formMessageBox.ShowDialog(owner)
			End Using
			Return dialogResult
		End Function
	End Class
End Namespace
