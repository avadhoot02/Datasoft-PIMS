Imports System
Imports System.Drawing
Imports Datasoft_PIMS_UI
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x02000033 RID: 51
	Friend NotInheritable Module ResourceModule
		' Token: 0x040004F7 RID: 1271
		Private oUI As UIResource = New UIResource()

		' Token: 0x040004F8 RID: 1272
		Public FormBackcolor As Color = Color.White

		' Token: 0x040004F9 RID: 1273
		Public LabelForecolor As Color = ColorTranslator.FromHtml("#0d3959")

		' Token: 0x040004FA RID: 1274
		Public ButtonForeColor As Color = Color.White

		' Token: 0x040004FB RID: 1275
		Public ButtonBorderColor As Color = Color.White

		' Token: 0x040004FC RID: 1276
		Public TextForecolor As Color = ColorTranslator.FromHtml("#0d3959")

		' Token: 0x040004FD RID: 1277
		Public TablabelBackColor As Color = ColorTranslator.FromHtml("#336699")

		' Token: 0x040004FE RID: 1278
		Public MenuItemSelectedColor As Object = Color.FromArgb(140, 51, 204, 255)

		' Token: 0x040004FF RID: 1279
		Public MenuItemBorderColor As Object = Color.FromArgb(0, 102, 153)

		' Token: 0x04000500 RID: 1280
		Public MenuItemSelectedGradientBeginColor As Object = Color.FromArgb(51, 204, 255)

		' Token: 0x04000501 RID: 1281
		Public MenuItemSelectedGradientEndColor As Object = Color.FromArgb(204, 238, 255)

		' Token: 0x04000502 RID: 1282
		Public MenuItemPressedGradientBeginColor As Object = Color.FromArgb(51, 204, 255)

		' Token: 0x04000503 RID: 1283
		Public MenuItemPressedGradientEndColor As Object = Color.FromArgb(204, 238, 255)

		' Token: 0x04000504 RID: 1284
		Public ModalTitleBarBackColor As Color = ColorTranslator.FromHtml("#cce7ff")

		' Token: 0x04000505 RID: 1285
		Public SelectedTabForeColor As Color = ColorTranslator.FromHtml("#0d3959")

		' Token: 0x04000506 RID: 1286
		Public SelectedTabBackColor As Color = Color.White

		' Token: 0x04000507 RID: 1287
		Public UnselectedTabForeColor As Color = Color.White

		' Token: 0x04000508 RID: 1288
		Public UnselectedTabBackColor As Color = ColorTranslator.FromHtml("#0d3959")

		' Token: 0x04000509 RID: 1289
		Public dgvBackgroundColor As Color = Color.White

		' Token: 0x0400050A RID: 1290
		Public dgvColumnHeadersDefaultCellStyleBackColor As Color = Color.SteelBlue

		' Token: 0x0400050B RID: 1291
		Public dgvColumnHeadersDefaultCellStyleForeColor As Color = Color.White

		' Token: 0x0400050C RID: 1292
		Public dgvRowHeadersDefaultCellStyleBackColor As Color = Color.SteelBlue

		' Token: 0x0400050D RID: 1293
		Public dgvRowHeadersDefaultCellStyleForeColor As Color = Color.White

		' Token: 0x0400050E RID: 1294
		Public dgvRowsDefaultCellStyleSelectionBackColor As Color = Color.SkyBlue

		' Token: 0x0400050F RID: 1295
		Public dgvRowsDefaultCellStyleSelectionForeColor As Color = ColorTranslator.FromHtml("#0d3959")

		' Token: 0x04000510 RID: 1296
		Public dgvAlternatingRowsDefaultCellStyleBackColor As Color = Color.Azure

		' Token: 0x04000511 RID: 1297
		Public imgFormIcon As Icon = ResourceModule.oUI.imgFormIcon

		' Token: 0x04000512 RID: 1298
		Public imgFormIconPic As Image = ResourceModule.oUI.imgFormIconPic

		' Token: 0x04000513 RID: 1299
		Public imgModalFormBackground As Image = ResourceModule.oUI.imgModalFormBackground

		' Token: 0x04000514 RID: 1300
		Public imgMDITitle As Image = ResourceModule.oUI.imgMDITitle

		' Token: 0x04000515 RID: 1301
		Public imgMDIShadowBottom As Image = ResourceModule.oUI.imgMDIShadowBottom

		' Token: 0x04000516 RID: 1302
		Public imgMDIShadowTop As Image = ResourceModule.oUI.imgMDIShadowTop

		' Token: 0x04000517 RID: 1303
		Public imgMDICompanyLogo As Image = ResourceModule.oUI.imgMDICompanyLogo

		' Token: 0x04000518 RID: 1304
		Public imgMDICompanyLogoGif As Image = ResourceModule.oUI.imgMDICompanyLogoGif

		' Token: 0x04000519 RID: 1305
		Public imgSSDatacode As Image = ResourceModule.oUI.imgSSDatacode

		' Token: 0x0400051A RID: 1306
		Public imgLoading As Image = ResourceModule.oUI.imgLoading

		' Token: 0x0400051B RID: 1307
		Public imgAbout As Image = ResourceModule.oUI.imgAbout

		' Token: 0x0400051C RID: 1308
		Public imgMDIUser As Image = ResourceModule.oUI.imgMDIUser

		' Token: 0x0400051D RID: 1309
		Public imgMDIPwd As Image = ResourceModule.oUI.imgMDIPwd

		' Token: 0x0400051E RID: 1310
		Public imgMDIHide As Image = ResourceModule.oUI.imgMDIHide

		' Token: 0x0400051F RID: 1311
		Public imgMDIReveal As Image = ResourceModule.oUI.imgMDIReveal

		' Token: 0x04000520 RID: 1312
		Public imgMDIProfile As Image = ResourceModule.oUI.imgMDIProfile

		' Token: 0x04000521 RID: 1313
		Public imgMDIProfileGif As Image = ResourceModule.oUI.imgMDIProfileGif

		' Token: 0x04000522 RID: 1314
		Public imgMDILoginPanel As Image = ResourceModule.oUI.imgMDILoginPanel

		' Token: 0x04000523 RID: 1315
		Public imgMDIProfilePanel As Image = ResourceModule.oUI.imgMDIProfilePanel

		' Token: 0x04000524 RID: 1316
		Public imgStandardButton As Image = ResourceModule.oUI.imgStandardButton

		' Token: 0x04000525 RID: 1317
		Public imgStandardButtonHover As Image = ResourceModule.oUI.imgStandardButtonHover

		' Token: 0x04000526 RID: 1318
		Public imgStandardButtonClick As Image = ResourceModule.oUI.imgStandardButtonClick

		' Token: 0x04000527 RID: 1319
		Public imgArrowUp As Image = ResourceModule.oUI.imgArrowUp

		' Token: 0x04000528 RID: 1320
		Public imgArrowUpHover As Image = ResourceModule.oUI.imgArrowUpHover

		' Token: 0x04000529 RID: 1321
		Public imgArrowUpClick As Image = ResourceModule.oUI.imgArrowUpClick

		' Token: 0x0400052A RID: 1322
		Public imgArrowDown As Image = ResourceModule.oUI.imgArrowDown

		' Token: 0x0400052B RID: 1323
		Public imgArrowDownHover As Image = ResourceModule.oUI.imgArrowDownHover

		' Token: 0x0400052C RID: 1324
		Public imgArrowDownClick As Image = ResourceModule.oUI.imgArrowDownClick

		' Token: 0x0400052D RID: 1325
		Public imgdgvDelete As Image = ResourceModule.oUI.imgdgvDelete

		' Token: 0x0400052E RID: 1326
		Public imgdgvDeleteHover As Image = ResourceModule.oUI.imgdgvDeleteHover

		' Token: 0x0400052F RID: 1327
		Public imgdgvDeleteClick As Image = ResourceModule.oUI.imgdgvDeleteClick

		' Token: 0x04000530 RID: 1328
		Public imgdgvDeleteDisable As Image = ResourceModule.oUI.imgdgvDeleteDisable

		' Token: 0x04000531 RID: 1329
		Public imgdgvDownload As Image = ResourceModule.oUI.imgdgvDownload

		' Token: 0x04000532 RID: 1330
		Public imgdgvDownloadHover As Image = ResourceModule.oUI.imgdgvDownloadHover

		' Token: 0x04000533 RID: 1331
		Public imgdgvDownloadClick As Image = ResourceModule.oUI.imgdgvDownloadClick

		' Token: 0x04000534 RID: 1332
		Public imgMenu As Image = ResourceModule.oUI.imgMenu

		' Token: 0x04000535 RID: 1333
		Public imgCustomMsg As Image = ResourceModule.oUI.imgCustomMsg

		' Token: 0x04000536 RID: 1334
		Public imgBlank As Image = ResourceModule.oUI.imgBlank

		' Token: 0x04000537 RID: 1335
		Public imgSave As Image = ResourceModule.oUI.imgSave

		' Token: 0x04000538 RID: 1336
		Public imgSaveClick As Image = ResourceModule.oUI.imgSaveClick

		' Token: 0x04000539 RID: 1337
		Public imgSaveDisabled As Image = ResourceModule.oUI.imgSaveDisabled

		' Token: 0x0400053A RID: 1338
		Public imgPrevious As Image = ResourceModule.oUI.imgPrevious

		' Token: 0x0400053B RID: 1339
		Public imgPreviousClick As Image = ResourceModule.oUI.imgPreviousClick

		' Token: 0x0400053C RID: 1340
		Public imgPreviousDisabled As Image = ResourceModule.oUI.imgPreviousDisabled

		' Token: 0x0400053D RID: 1341
		Public imgNext As Image = ResourceModule.oUI.imgNext

		' Token: 0x0400053E RID: 1342
		Public imgNextClick As Image = ResourceModule.oUI.imgNextClick

		' Token: 0x0400053F RID: 1343
		Public imgNextDisabled As Image = ResourceModule.oUI.imgNextDisabled

		' Token: 0x04000540 RID: 1344
		Public imgMsgInformation As Image = ResourceModule.oUI.imgMsgInformation

		' Token: 0x04000541 RID: 1345
		Public imgMsgError As Image = ResourceModule.oUI.imgMsgError

		' Token: 0x04000542 RID: 1346
		Public imgMsgWarning As Image = ResourceModule.oUI.imgMsgWarning

		' Token: 0x04000543 RID: 1347
		Public imgMsgQuestion As Image = ResourceModule.oUI.imgMsgQuestion

		' Token: 0x04000544 RID: 1348
		Public imgGrayToggleSwitch As Image = ResourceModule.oUI.imgGrayToggleSwitch

		' Token: 0x04000545 RID: 1349
		Public imgGreenToggleSwitch As Image = ResourceModule.oUI.imgGreenToggleSwitch

		' Token: 0x04000546 RID: 1350
		Public imgSettingRound As Image = ResourceModule.oUI.imgSettingRound

		' Token: 0x04000547 RID: 1351
		Public imgSettingRoundClick As Image = ResourceModule.oUI.imgSettingRoundClick

		' Token: 0x04000548 RID: 1352
		Public imgSettingRoundHover As Image = ResourceModule.oUI.imgSettingRoundHover

		' Token: 0x04000549 RID: 1353
		Public imgRightArrow As Image = ResourceModule.oUI.imgRightArrow
	End Module
End Namespace
