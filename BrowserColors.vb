Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace Datasoft_PIMS
	' Token: 0x0200002C RID: 44
	Public Class BrowserColors
		Inherits ProfessionalColorTable

		' Token: 0x1700043C RID: 1084
		' (get) Token: 0x06000B44 RID: 2884 RVA: 0x00069014 File Offset: 0x00067214
		Public Overrides ReadOnly Property MenuItemSelected As Color
			Get
				Dim menuItemSelectedColor As Object = ResourceModule.MenuItemSelectedColor
				Return If((menuItemSelectedColor IsNot Nothing), CType(menuItemSelectedColor, Color), Nothing)
			End Get
		End Property

		' Token: 0x1700043D RID: 1085
		' (get) Token: 0x06000B45 RID: 2885 RVA: 0x00069040 File Offset: 0x00067240
		Public Overrides ReadOnly Property MenuItemBorder As Color
			Get
				Dim menuItemBorderColor As Object = ResourceModule.MenuItemBorderColor
				Return If((menuItemBorderColor IsNot Nothing), CType(menuItemBorderColor, Color), Nothing)
			End Get
		End Property

		' Token: 0x1700043E RID: 1086
		' (get) Token: 0x06000B46 RID: 2886 RVA: 0x0006906C File Offset: 0x0006726C
		Public Overrides ReadOnly Property MenuItemSelectedGradientBegin As Color
			Get
				Dim menuItemSelectedGradientBeginColor As Object = ResourceModule.MenuItemSelectedGradientBeginColor
				Return If((menuItemSelectedGradientBeginColor IsNot Nothing), CType(menuItemSelectedGradientBeginColor, Color), Nothing)
			End Get
		End Property

		' Token: 0x1700043F RID: 1087
		' (get) Token: 0x06000B47 RID: 2887 RVA: 0x00069098 File Offset: 0x00067298
		Public Overrides ReadOnly Property MenuItemSelectedGradientEnd As Color
			Get
				Dim menuItemSelectedGradientEndColor As Object = ResourceModule.MenuItemSelectedGradientEndColor
				Return If((menuItemSelectedGradientEndColor IsNot Nothing), CType(menuItemSelectedGradientEndColor, Color), Nothing)
			End Get
		End Property

		' Token: 0x17000440 RID: 1088
		' (get) Token: 0x06000B48 RID: 2888 RVA: 0x000690C4 File Offset: 0x000672C4
		Public Overrides ReadOnly Property MenuItemPressedGradientBegin As Color
			Get
				Dim menuItemPressedGradientBeginColor As Object = ResourceModule.MenuItemPressedGradientBeginColor
				Return If((menuItemPressedGradientBeginColor IsNot Nothing), CType(menuItemPressedGradientBeginColor, Color), Nothing)
			End Get
		End Property

		' Token: 0x17000441 RID: 1089
		' (get) Token: 0x06000B49 RID: 2889 RVA: 0x000690F0 File Offset: 0x000672F0
		Public Overrides ReadOnly Property MenuItemPressedGradientEnd As Color
			Get
				Dim menuItemPressedGradientEndColor As Object = ResourceModule.MenuItemPressedGradientEndColor
				Return If((menuItemPressedGradientEndColor IsNot Nothing), CType(menuItemPressedGradientEndColor, Color), Nothing)
			End Get
		End Property
	End Class
End Namespace
