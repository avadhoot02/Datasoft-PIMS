Imports System
Imports System.Windows.Forms

Namespace Datasoft_PIMS
	' Token: 0x0200002B RID: 43
	Public Class BrowserMenuRenderer
		Inherits ToolStripProfessionalRenderer

		' Token: 0x06000B41 RID: 2881 RVA: 0x00068FF0 File Offset: 0x000671F0
		Public Sub New()
			MyBase.New(New BrowserColors())
		End Sub

		' Token: 0x06000B42 RID: 2882 RVA: 0x00068FFF File Offset: 0x000671FF
		Protected Overrides Sub OnRenderItemText(e As ToolStripItemTextRenderEventArgs)
			MyBase.OnRenderItemText(e)
		End Sub
	End Class
End Namespace
