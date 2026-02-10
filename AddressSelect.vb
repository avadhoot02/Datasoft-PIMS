Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x0200005C RID: 92
	<DesignerGenerated()>
	Public Partial Class AddressSelect
		Inherits Form

		' Token: 0x170007DE RID: 2014
		' (get) Token: 0x0600148F RID: 5263 RVA: 0x000BE3FA File Offset: 0x000BC5FA
		' (set) Token: 0x06001490 RID: 5264 RVA: 0x000BE404 File Offset: 0x000BC604
		Friend Overridable Property pnlBorder As Panel

		' Token: 0x170007DF RID: 2015
		' (get) Token: 0x06001491 RID: 5265 RVA: 0x000BE40D File Offset: 0x000BC60D
		' (set) Token: 0x06001492 RID: 5266 RVA: 0x000BE417 File Offset: 0x000BC617
		Friend Overridable Property pnlMain As Panel

		' Token: 0x170007E0 RID: 2016
		' (get) Token: 0x06001493 RID: 5267 RVA: 0x000BE420 File Offset: 0x000BC620
		' (set) Token: 0x06001494 RID: 5268 RVA: 0x000BE42C File Offset: 0x000BC62C
		Friend Overridable Property panelTitleBar As Panel
			<CompilerGenerated()>
			Get
				Return Me._panelTitleBar
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.panelTitleBar_MouseDown
				Dim panel As Panel = Me._panelTitleBar
				If panel IsNot Nothing Then
					RemoveHandler panel.MouseDown, mouseEventHandler
				End If
				Me._panelTitleBar = value
				panel = Me._panelTitleBar
				If panel IsNot Nothing Then
					AddHandler panel.MouseDown, mouseEventHandler
				End If
			End Set
		End Property

		' Token: 0x170007E1 RID: 2017
		' (get) Token: 0x06001495 RID: 5269 RVA: 0x000BE46F File Offset: 0x000BC66F
		' (set) Token: 0x06001496 RID: 5270 RVA: 0x000BE479 File Offset: 0x000BC679
		Friend Overridable Property picFormIcon As PictureBox

		' Token: 0x170007E2 RID: 2018
		' (get) Token: 0x06001497 RID: 5271 RVA: 0x000BE482 File Offset: 0x000BC682
		' (set) Token: 0x06001498 RID: 5272 RVA: 0x000BE48C File Offset: 0x000BC68C
		Friend Overridable Property lblCaption As Label

		' Token: 0x170007E3 RID: 2019
		' (get) Token: 0x06001499 RID: 5273 RVA: 0x000BE495 File Offset: 0x000BC695
		' (set) Token: 0x0600149A RID: 5274 RVA: 0x000BE4A0 File Offset: 0x000BC6A0
		Friend Overridable Property form_btnClose As Button
			<CompilerGenerated()>
			Get
				Return Me._form_btnClose
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.form_btnClose_Click
				Dim button As Button = Me._form_btnClose
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._form_btnClose = value
				button = Me._form_btnClose
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170007E4 RID: 2020
		' (get) Token: 0x0600149B RID: 5275 RVA: 0x000BE4E3 File Offset: 0x000BC6E3
		' (set) Token: 0x0600149C RID: 5276 RVA: 0x000BE4ED File Offset: 0x000BC6ED
		Friend Overridable Property lblShadow1 As Label

		' Token: 0x170007E5 RID: 2021
		' (get) Token: 0x0600149D RID: 5277 RVA: 0x000BE4F6 File Offset: 0x000BC6F6
		' (set) Token: 0x0600149E RID: 5278 RVA: 0x000BE500 File Offset: 0x000BC700
		Friend Overridable Property lblShadow2 As Label

		' Token: 0x170007E6 RID: 2022
		' (get) Token: 0x0600149F RID: 5279 RVA: 0x000BE509 File Offset: 0x000BC709
		' (set) Token: 0x060014A0 RID: 5280 RVA: 0x000BE514 File Offset: 0x000BC714
		Friend Overridable Property dgvDtls As DataGridView
			<CompilerGenerated()>
			Get
				Return Me._dgvDtls
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim dataGridViewCellEventHandler As DataGridViewCellEventHandler = AddressOf Me.dgvDtls_CellDoubleClick
				Dim dataGridView As DataGridView = Me._dgvDtls
				If dataGridView IsNot Nothing Then
					RemoveHandler dataGridView.CellDoubleClick, dataGridViewCellEventHandler
				End If
				Me._dgvDtls = value
				dataGridView = Me._dgvDtls
				If dataGridView IsNot Nothing Then
					AddHandler dataGridView.CellDoubleClick, dataGridViewCellEventHandler
				End If
			End Set
		End Property

		' Token: 0x170007E7 RID: 2023
		' (get) Token: 0x060014A1 RID: 5281 RVA: 0x000BE557 File Offset: 0x000BC757
		' (set) Token: 0x060014A2 RID: 5282 RVA: 0x000BE561 File Offset: 0x000BC761
		Friend Overridable Property Label42 As Label

		' Token: 0x170007E8 RID: 2024
		' (get) Token: 0x060014A3 RID: 5283 RVA: 0x000BE56A File Offset: 0x000BC76A
		' (set) Token: 0x060014A4 RID: 5284 RVA: 0x000BE574 File Offset: 0x000BC774
		Friend Overridable Property ID As DataGridViewTextBoxColumn

		' Token: 0x170007E9 RID: 2025
		' (get) Token: 0x060014A5 RID: 5285 RVA: 0x000BE57D File Offset: 0x000BC77D
		' (set) Token: 0x060014A6 RID: 5286 RVA: 0x000BE587 File Offset: 0x000BC787
		Friend Overridable Property AddressType As DataGridViewTextBoxColumn

		' Token: 0x170007EA RID: 2026
		' (get) Token: 0x060014A7 RID: 5287 RVA: 0x000BE590 File Offset: 0x000BC790
		' (set) Token: 0x060014A8 RID: 5288 RVA: 0x000BE59A File Offset: 0x000BC79A
		Friend Overridable Property Address As DataGridViewTextBoxColumn

		' Token: 0x170007EB RID: 2027
		' (get) Token: 0x060014A9 RID: 5289 RVA: 0x000BE5A3 File Offset: 0x000BC7A3
		' (set) Token: 0x060014AA RID: 5290 RVA: 0x000BE5AD File Offset: 0x000BC7AD
		Friend Overridable Property ContactName As DataGridViewTextBoxColumn

		' Token: 0x170007EC RID: 2028
		' (get) Token: 0x060014AB RID: 5291 RVA: 0x000BE5B6 File Offset: 0x000BC7B6
		' (set) Token: 0x060014AC RID: 5292 RVA: 0x000BE5C0 File Offset: 0x000BC7C0
		Friend Overridable Property LandlineNo As DataGridViewTextBoxColumn

		' Token: 0x170007ED RID: 2029
		' (get) Token: 0x060014AD RID: 5293 RVA: 0x000BE5C9 File Offset: 0x000BC7C9
		' (set) Token: 0x060014AE RID: 5294 RVA: 0x000BE5D3 File Offset: 0x000BC7D3
		Friend Overridable Property CellNo As DataGridViewTextBoxColumn

		' Token: 0x170007EE RID: 2030
		' (get) Token: 0x060014AF RID: 5295 RVA: 0x000BE5DC File Offset: 0x000BC7DC
		' (set) Token: 0x060014B0 RID: 5296 RVA: 0x000BE5E6 File Offset: 0x000BC7E6
		Friend Overridable Property EmailAddress As DataGridViewTextBoxColumn

		' Token: 0x170007EF RID: 2031
		' (get) Token: 0x060014B1 RID: 5297 RVA: 0x000BE5EF File Offset: 0x000BC7EF
		' (set) Token: 0x060014B2 RID: 5298 RVA: 0x000BE5F9 File Offset: 0x000BC7F9
		Friend Overridable Property GSTINNo As DataGridViewTextBoxColumn

		' Token: 0x170007F0 RID: 2032
		' (get) Token: 0x060014B3 RID: 5299 RVA: 0x000BE602 File Offset: 0x000BC802
		' (set) Token: 0x060014B4 RID: 5300 RVA: 0x000BE60C File Offset: 0x000BC80C
		Friend Overridable Property PANNo As DataGridViewTextBoxColumn

		' Token: 0x060014B5 RID: 5301
		Private Declare Sub SendMessage Lib "user32.DLL" (hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

		' Token: 0x060014B6 RID: 5302
		Private Declare Sub ReleaseCapture Lib "user32.DLL" ()

		' Token: 0x060014B7 RID: 5303 RVA: 0x000BE615 File Offset: 0x000BC815
		Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs)
			AddressSelect.ReleaseCapture()
			AddressSelect.SendMessage(MyBase.Handle, 274, 61458, 0)
		End Sub

		' Token: 0x060014B8 RID: 5304 RVA: 0x000BE638 File Offset: 0x000BC838
		Public Sub New(AddressType As String, Where As String)
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.InitializeComponent()
			Designing.SetTheme(Me)
			Me.picFormIcon.Image = ResourceModule.imgFormIconPic
			MyBase.FormBorderStyle = FormBorderStyle.None
			Me.BackColor = Color.DarkGray
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.lblCaption.Text = Me.Text
			Me.form_btnClose.DialogResult = DialogResult.Cancel
			Me.sAddressType = AddressType
			Me.sWhere = Where
		End Sub

		' Token: 0x060014B9 RID: 5305 RVA: 0x000BE6D0 File Offset: 0x000BC8D0
		Private Sub form_btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x060014BA RID: 5306 RVA: 0x000BE6DA File Offset: 0x000BC8DA
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Me.FillAddress()
		End Sub

		' Token: 0x060014BB RID: 5307 RVA: 0x000BE6E4 File Offset: 0x000BC8E4
		Private Sub FillAddress()
			Dim flag As Boolean = Operators.CompareString(Me.sAddressType, "ImmunoACT", False) = 0
			Dim text As String
			If flag Then
				text = " SELECT AddressID AS ID, AddressType, Address + CHAR(13)+CHAR(10) + City + " & vbCrLf
				text += " ', ' + Pincode + ', ' + State AS Address, " & vbCrLf
				text += " ContactName, LandlineNo, CellNo, EmailAddress, GSTINNo, PANNo" & vbCrLf
				text += " FROM Address" & vbCrLf
			Else
				text = " SELECT VendorDtlsID AS ID, AddressType, Address + CHAR(13)+CHAR(10) + City + " & vbCrLf
				text += " ', ' + Pincode + ', ' + State AS Address, " & vbCrLf
				text += " ContactName, LandlineNo, CellNo, EmailAddress, GSTINNo, PANNo" & vbCrLf
				text += " FROM VendorDtls" & vbCrLf
			End If
			Dim flag2 As Boolean = Operators.CompareString(Me.sWhere, "", False) <> 0
			If flag2 Then
				text += Me.sWhere
			End If
			Me.dtAddress = MainModule.GetData(text)
			Me.dgvDtls.DataSource = Me.dtAddress
		End Sub

		' Token: 0x060014BC RID: 5308 RVA: 0x000BE7A8 File Offset: 0x000BC9A8
		Private Sub dgvDtls_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = (e.RowIndex > -1) And (e.ColumnIndex > -1)
			If flag Then
				Dim array As DataRow() = Me.dtAddress.[Select](Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("ID = '", Me.dgvDtls.Rows(e.RowIndex).Cells("ID").Value), "'")))
				Dim flag2 As Boolean = array.Length > 0
				If flag2 Then
					Me.dr = array(0)
					MyBase.DialogResult = DialogResult.OK
					MyBase.Close()
				End If
			End If
		End Sub

		' Token: 0x040008D6 RID: 2262
		Private sAddressType As String

		' Token: 0x040008D7 RID: 2263
		Private sWhere As String

		' Token: 0x040008D8 RID: 2264
		Private dtAddress As DataTable

		' Token: 0x040008D9 RID: 2265
		Public dr As DataRow
	End Class
End Namespace
