Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports WeifenLuo.WinFormsUI.Docking

Namespace Datasoft_PIMS
	' Token: 0x0200000D RID: 13
	<DesignerGenerated()>
	Public Partial Class Dashboard
		Inherits DockContent

		' Token: 0x06000096 RID: 150 RVA: 0x00005424 File Offset: 0x00003624
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Dashboard_Load
			AddHandler MyBase.Activated, AddressOf Me.Dashboard_Activated
			AddHandler MyBase.Shown, AddressOf Me.Dashboard_Shown
			Me.InitializeComponent()
		End Sub

		' Token: 0x17000034 RID: 52
		' (get) Token: 0x06000099 RID: 153 RVA: 0x00006997 File Offset: 0x00004B97
		' (set) Token: 0x0600009A RID: 154 RVA: 0x000069A1 File Offset: 0x00004BA1
		Friend Overridable Property SplitContainer1 As SplitContainer

		' Token: 0x17000035 RID: 53
		' (get) Token: 0x0600009B RID: 155 RVA: 0x000069AA File Offset: 0x00004BAA
		' (set) Token: 0x0600009C RID: 156 RVA: 0x000069B4 File Offset: 0x00004BB4
		Friend Overridable Property Chart0 As Chart

		' Token: 0x17000036 RID: 54
		' (get) Token: 0x0600009D RID: 157 RVA: 0x000069BD File Offset: 0x00004BBD
		' (set) Token: 0x0600009E RID: 158 RVA: 0x000069C7 File Offset: 0x00004BC7
		Friend Overridable Property TableLayoutPanel1 As TableLayoutPanel

		' Token: 0x17000037 RID: 55
		' (get) Token: 0x0600009F RID: 159 RVA: 0x000069D0 File Offset: 0x00004BD0
		' (set) Token: 0x060000A0 RID: 160 RVA: 0x000069DA File Offset: 0x00004BDA
		Friend Overridable Property Chart2 As Chart

		' Token: 0x17000038 RID: 56
		' (get) Token: 0x060000A1 RID: 161 RVA: 0x000069E3 File Offset: 0x00004BE3
		' (set) Token: 0x060000A2 RID: 162 RVA: 0x000069ED File Offset: 0x00004BED
		Friend Overridable Property Chart1 As Chart

		' Token: 0x17000039 RID: 57
		' (get) Token: 0x060000A3 RID: 163 RVA: 0x000069F6 File Offset: 0x00004BF6
		' (set) Token: 0x060000A4 RID: 164 RVA: 0x00006A00 File Offset: 0x00004C00
		Friend Overridable Property Chart3 As Chart

		' Token: 0x1700003A RID: 58
		' (get) Token: 0x060000A5 RID: 165 RVA: 0x00006A09 File Offset: 0x00004C09
		' (set) Token: 0x060000A6 RID: 166 RVA: 0x00006A14 File Offset: 0x00004C14
		Friend Overridable Property dgvView As DataGridView
			<CompilerGenerated()>
			Get
				Return Me._dgvView
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As DataGridView)
				Dim dataGridViewCellEventHandler As DataGridViewCellEventHandler = AddressOf Me.dgvView_CellDoubleClick
				Dim dataGridView As DataGridView = Me._dgvView
				If dataGridView IsNot Nothing Then
					RemoveHandler dataGridView.CellDoubleClick, dataGridViewCellEventHandler
				End If
				Me._dgvView = value
				dataGridView = Me._dgvView
				If dataGridView IsNot Nothing Then
					AddHandler dataGridView.CellDoubleClick, dataGridViewCellEventHandler
				End If
			End Set
		End Property

		' Token: 0x1700003B RID: 59
		' (get) Token: 0x060000A7 RID: 167 RVA: 0x00006A57 File Offset: 0x00004C57
		' (set) Token: 0x060000A8 RID: 168 RVA: 0x00006A61 File Offset: 0x00004C61
		Friend Overridable Property ContextMenuStrip1 As ContextMenuStrip

		' Token: 0x1700003C RID: 60
		' (get) Token: 0x060000A9 RID: 169 RVA: 0x00006A6A File Offset: 0x00004C6A
		' (set) Token: 0x060000AA RID: 170 RVA: 0x00006A74 File Offset: 0x00004C74
		Friend Overridable Property RefreshToolStripMenuItem As ToolStripMenuItem
			<CompilerGenerated()>
			Get
				Return Me._RefreshToolStripMenuItem
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim eventHandler As EventHandler = AddressOf Me.RefreshToolStripMenuItem_Click
				Dim toolStripMenuItem As ToolStripMenuItem = Me._RefreshToolStripMenuItem
				If toolStripMenuItem IsNot Nothing Then
					RemoveHandler toolStripMenuItem.Click, eventHandler
				End If
				Me._RefreshToolStripMenuItem = value
				toolStripMenuItem = Me._RefreshToolStripMenuItem
				If toolStripMenuItem IsNot Nothing Then
					AddHandler toolStripMenuItem.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700003D RID: 61
		' (get) Token: 0x060000AB RID: 171 RVA: 0x00006AB7 File Offset: 0x00004CB7
		' (set) Token: 0x060000AC RID: 172 RVA: 0x00006AC1 File Offset: 0x00004CC1
		Friend Overridable Property Description As DataGridViewTextBoxColumn

		' Token: 0x1700003E RID: 62
		' (get) Token: 0x060000AD RID: 173 RVA: 0x00006ACA File Offset: 0x00004CCA
		' (set) Token: 0x060000AE RID: 174 RVA: 0x00006AD4 File Offset: 0x00004CD4
		Friend Overridable Property Count As DataGridViewTextBoxColumn

		' Token: 0x1700003F RID: 63
		' (get) Token: 0x060000AF RID: 175 RVA: 0x00006ADD File Offset: 0x00004CDD
		' (set) Token: 0x060000B0 RID: 176 RVA: 0x00006AE7 File Offset: 0x00004CE7
		Friend Overridable Property FormName As DataGridViewTextBoxColumn

		' Token: 0x17000040 RID: 64
		' (get) Token: 0x060000B1 RID: 177 RVA: 0x00006AF0 File Offset: 0x00004CF0
		' (set) Token: 0x060000B2 RID: 178 RVA: 0x00006AFA File Offset: 0x00004CFA
		Friend Overridable Property FormMode As DataGridViewTextBoxColumn

		' Token: 0x17000041 RID: 65
		' (get) Token: 0x060000B3 RID: 179 RVA: 0x00006B03 File Offset: 0x00004D03
		' (set) Token: 0x060000B4 RID: 180 RVA: 0x00006B0D File Offset: 0x00004D0D
		Friend Overridable Property TabTextVal As DataGridViewTextBoxColumn

		' Token: 0x060000B5 RID: 181 RVA: 0x00006B16 File Offset: 0x00004D16
		Private Sub Dashboard_Load(sender As Object, e As EventArgs)
			Designing.SetTheme(Me)
		End Sub

		' Token: 0x060000B6 RID: 182 RVA: 0x00006B20 File Offset: 0x00004D20
		Private Sub Dashboard_Activated(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060000B7 RID: 183 RVA: 0x00006B23 File Offset: 0x00004D23
		Private Sub Dashboard_Shown(sender As Object, e As EventArgs)
			Me.FillDataDashBoard()
		End Sub

		' Token: 0x060000B8 RID: 184 RVA: 0x00006B2D File Offset: 0x00004D2D
		Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.FillDataDashBoard()
		End Sub

		' Token: 0x060000B9 RID: 185 RVA: 0x00006B37 File Offset: 0x00004D37
		Private Sub FillDataDashBoard()
			Me.SetTaskReportGrid()
			Me.SetCharts()
		End Sub

		' Token: 0x060000BA RID: 186 RVA: 0x00006B48 File Offset: 0x00004D48
		Private Sub SetTaskReportGrid()
			Me.dgvView.Rows.Clear()
			Dim flag As Boolean = GlobalVariables.gsdtAccessRights.Rows.Count > 0
			If flag Then
				Dim flag2 As Boolean = GlobalVariables.gsdtAccessRights.[Select]("FormName='Product'").Length > 0
				If flag2 Then
					Me.Product_Creation_Pending()
				End If
				Dim flag3 As Boolean = GlobalVariables.gsdtAccessRights.[Select]("FormName='Enable Product QC Specification'").Length > 0
				If flag3 Then
					Me.Product_Approval_Pending()
				End If
				Dim flag4 As Boolean = GlobalVariables.gsdtAccessRights.[Select]("FormName='Product BOM'").Length > 0
				If flag4 Then
					Me.BOM_Approval_OnHold()
				End If
				Dim flag5 As Boolean = GlobalVariables.gsdtAccessRights.[Select]("FormName='BOM Approval'").Length > 0
				If flag5 Then
					Me.BOM_Approval_Pending()
				End If
				Dim flag6 As Boolean = GlobalVariables.gsdtAccessRights.[Select]("FormName='PR Modification'").Length > 0
				If flag6 Then
					Me.PR_On_Hold()
					Me.PR_Cost_On_Hold()
				End If
				Dim flag7 As Boolean = GlobalVariables.gsdtAccessRights.[Select]("FormName='PR Approval'").Length > 0
				If flag7 Then
					Me.PR_Approval_Pending()
				End If
				Dim flag8 As Boolean = GlobalVariables.gsdtAccessRights.[Select]("FormName='PR Cost Approval'").Length > 0
				If flag8 Then
					Me.PR_Cost_Approval_Pending()
				End If
				Dim flag9 As Boolean = GlobalVariables.gsdtAccessRights.[Select]("FormName='PR Report'").Length > 0
				If flag9 Then
					Me.PR_PO_Pending()
				End If
				Dim flag10 As Boolean = GlobalVariables.gsdtAccessRights.[Select]("FormName='PO Modification'").Length > 0
				If flag10 Then
					Me.PO_On_Hold()
					Me.PO_Cost_On_Hold()
				End If
				Dim flag11 As Boolean = GlobalVariables.gsdtAccessRights.[Select]("FormName='PO Approval'").Length > 0
				If flag11 Then
					Me.PO_Approval_Pending()
				End If
				Dim flag12 As Boolean = GlobalVariables.gsdtAccessRights.[Select]("FormName='PO Cost Approval'").Length > 0
				If flag12 Then
					Me.PO_Cost_Approval_Pending()
				End If
				Dim flag13 As Boolean = GlobalVariables.gsdtAccessRights.[Select]("FormName='PO Printing'").Length > 0
				If flag13 Then
					Me.PO_Printing_Pending()
				End If
				Dim flag14 As Boolean = GlobalVariables.gsdtAccessRights.[Select]("FormName='GRN'").Length > 0
				If flag14 Then
					Me.PO_Receipt_Pending()
				End If
				Dim flag15 As Boolean = GlobalVariables.gsdtAccessRights.[Select]("FormName='GRN'").Length > 0
				If flag15 Then
					Me.GRN_On_Hold()
				End If
				Dim flag16 As Boolean = GlobalVariables.gsdtAccessRights.[Select]("FormName='GRN Approval'").Length > 0
				If flag16 Then
					Me.GRN_Approval_Pending()
				End If
				Dim flag17 As Boolean = GlobalVariables.gsdtAccessRights.[Select]("FormName='QC Entry'").Length > 0
				If flag17 Then
					Me.QC_Entry_Pending()
					Me.QC_Release_OnHold()
					Me.QA_Release_OnHold()
				End If
				Dim flag18 As Boolean = GlobalVariables.gsdtAccessRights.[Select]("FormName='QC Release'").Length > 0
				If flag18 Then
					Me.QC_Release_Pending()
				End If
				Dim flag19 As Boolean = GlobalVariables.gsdtAccessRights.[Select]("FormName='QA Release'").Length > 0
				If flag19 Then
					Me.QA_Release_Pending()
				End If
				Dim flag20 As Boolean = GlobalVariables.gsdtAccessRights.[Select]("FormName='Picking'").Length > 0
				If flag20 Then
					Me.Material_Request_In_Picking()
				End If
				Dim flag21 As Boolean = GlobalVariables.gsdtAccessRights.[Select]("FormName='Picking'").Length > 0
				If flag21 Then
					Me.Material_Request_In_QA_OnHold()
				End If
				Dim flag22 As Boolean = GlobalVariables.gsdtAccessRights.[Select]("FormName='QA Verification'").Length > 0
				If flag22 Then
					Me.Material_Request_In_QA_Approval()
				End If
				Dim flag23 As Boolean = GlobalVariables.gsdtAccessRights.[Select]("FormName='Material Issue'").Length > 0
				If flag23 Then
					Me.Material_Request_Waiting_For_Issue()
				End If
				Me.AlertGridBlankRows()
			End If
		End Sub

		' Token: 0x060000BB RID: 187 RVA: 0x00006EA4 File Offset: 0x000050A4
		Private Sub AlertGridBlankRows()
			Dim height As Integer = Me.dgvView.RowTemplate.Height
			Dim height2 As Integer = Me.dgvView.Height
			Dim rowCount As Integer = Me.dgvView.RowCount
			Dim flag As Boolean = height2 > rowCount * height
			If flag Then
				Dim num As Integer = height2 - rowCount * height
				Dim num2 As Double = Math.Floor(CDbl(num) / CDbl(height))
				Dim flag2 As Boolean = num2 >= 1.0
				If flag2 Then

						Dim flag3 As Boolean = num2 * CDbl(height) > CDbl(height2)
						If flag3 Then
							num2 -= 1.0
						End If

					Me.dgvView.Rows.Add(CInt(Math.Round(num2)))
				End If
			End If
		End Sub

		' Token: 0x060000BC RID: 188 RVA: 0x00006F4C File Offset: 0x0000514C
		Private Sub dgvView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
			Dim flag As Boolean = (e.RowIndex > -1) And (e.ColumnIndex > -1)
			If flag Then
				' The following expression was wrapped in a checked-expression
				Dim num As Integer = CInt(Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(Me.dgvView.Rows(e.RowIndex).Cells("Count").Value))))
				Dim text As String = Conversions.ToString(Me.dgvView.Rows(e.RowIndex).Cells("FormName").Value)
				Dim text2 As String = Conversions.ToString(Me.dgvView.Rows(e.RowIndex).Cells("FormMode").Value)
				Dim text3 As String = Conversions.ToString(Me.dgvView.Rows(e.RowIndex).Cells("TabTextVal").Value)
				Dim num2 As UInteger = <PrivateImplementationDetails>.ComputeStringHash(text)
				Dim dockContent As DockContent
				If num2 <= 3358899663UI Then
					If num2 <= 1648763071UI Then
						If num2 <> 124888258UI Then
							If num2 <> 1648763071UI Then
								GoTo IL_02C5
							End If
							If Operators.CompareString(text, "Product Approval", False) <> 0 Then
								GoTo IL_02C5
							End If
							dockContent = New Product01(text2)
							GoTo IL_02C8
						Else
							If Operators.CompareString(text, "GRNList", False) <> 0 Then
								GoTo IL_02C5
							End If
							dockContent = New GRNList(text2, "")
							GoTo IL_02C8
						End If
					ElseIf num2 <> 1972001657UI Then
						If num2 <> 2770244757UI Then
							If num2 <> 3358899663UI Then
								GoTo IL_02C5
							End If
							If Operators.CompareString(text, "PRList", False) <> 0 Then
								GoTo IL_02C5
							End If
							dockContent = New PRList(text2)
							GoTo IL_02C8
						ElseIf Operators.CompareString(text, "BOM Entry", False) <> 0 Then
							GoTo IL_02C5
						End If
					Else
						If Operators.CompareString(text, "GRNListItem", False) <> 0 Then
							GoTo IL_02C5
						End If
						dockContent = New GRNListItem(text2)
						GoTo IL_02C8
					End If
				ElseIf num2 <= 3839683240UI Then
					If num2 <> 3568814474UI Then
						If num2 <> 3839683240UI Then
							GoTo IL_02C5
						End If
						If Operators.CompareString(text, "POList", False) <> 0 Then
							GoTo IL_02C5
						End If
						dockContent = New POList(text2)
						GoTo IL_02C8
					Else
						If Operators.CompareString(text, "Unregistered Products", False) <> 0 Then
							GoTo IL_02C5
						End If
						dockContent = New UnregisteredProducts()
						GoTo IL_02C8
					End If
				ElseIf num2 <> 3921611528UI Then
					If num2 <> 3965349392UI Then
						If num2 <> 3999726841UI Then
							GoTo IL_02C5
						End If
						If Operators.CompareString(text, "PRReport", False) <> 0 Then
							GoTo IL_02C5
						End If
						dockContent = New PRReport(text2)
						GoTo IL_02C8
					ElseIf Operators.CompareString(text, "BOM Approval", False) <> 0 Then
						GoTo IL_02C5
					End If
				Else
					If Operators.CompareString(text, "IssueList", False) <> 0 Then
						GoTo IL_02C5
					End If
					dockContent = New IssueList(text2)
					GoTo IL_02C8
				End If
				dockContent = New ProductBOM01(text2)
				GoTo IL_02C8
				IL_02C5:
				Return
				IL_02C8:
				Dim flag2 As Boolean = Not Information.IsNothing(dockContent)
				If flag2 Then
					dockContent.TabText = text3
					dockContent.Show(MyBase.DockPanel)
				End If
			End If
		End Sub

		' Token: 0x060000BD RID: 189 RVA: 0x0000724C File Offset: 0x0000544C
		Private Sub Product_Creation_Pending()
			Dim text As String = " SELECT COUNT(ProductID) AS Cnt " & vbCrLf
			text += " FROM PRItems PI" & vbCrLf
			text += " INNER JOIN PR P ON PI.PRID = P.PRID " & vbCrLf
			text += " WHERE ProductID = '0' AND P.Status = 'Cost Approved'" & vbCrLf
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim num As Integer = Conversions.ToInteger(data.Rows(0)("Cnt"))
				Dim flag2 As Boolean = num > 0
				If flag2 Then
					Me.dgvView.Rows.Add()
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Description").Value = "Product(s) Pending For Creation"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Count").Value = num
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormName").Value = "Unregistered Products"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormMode").Value = ""
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("TabTextVal").Value = "Unregistered Products"
				End If
			End If
		End Sub

		' Token: 0x060000BE RID: 190 RVA: 0x000073F4 File Offset: 0x000055F4
		Private Sub Product_Approval_Pending()
			Dim text As String = " SELECT COUNT(ProductID) AS Cnt FROM Product WHERE Status = 'Approval Pending' "
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim num As Integer = Conversions.ToInteger(data.Rows(0)("Cnt"))
				Dim flag2 As Boolean = num > 0
				If flag2 Then
					Me.dgvView.Rows.Add()
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Description").Value = "Product(s) Pending For Approval"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Count").Value = num
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormName").Value = "Product Approval"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormMode").Value = "Approval"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("TabTextVal").Value = "Product"
				End If
			End If
		End Sub

		' Token: 0x060000BF RID: 191 RVA: 0x00007578 File Offset: 0x00005778
		Private Sub BOM_Approval_OnHold()
			Dim text As String = " SELECT COUNT(ProductBOMID) AS Cnt FROM ProductBOM WHERE Status = 'On-Hold' "
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim num As Integer = Conversions.ToInteger(data.Rows(0)("Cnt"))
				Dim flag2 As Boolean = num > 0
				If flag2 Then
					Me.dgvView.Rows.Add()
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Description").Value = "Product BOM(s) Approval On-Hold"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Count").Value = num
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormName").Value = "BOM Entry"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormMode").Value = "On-Hold"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("TabTextVal").Value = "BOM Entry"
				End If
			End If
		End Sub

		' Token: 0x060000C0 RID: 192 RVA: 0x000076FC File Offset: 0x000058FC
		Private Sub BOM_Approval_Pending()
			Dim text As String = " SELECT COUNT(ProductBOMID) AS Cnt FROM ProductBOM WHERE Status = 'Approval Pending' "
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim num As Integer = Conversions.ToInteger(data.Rows(0)("Cnt"))
				Dim flag2 As Boolean = num > 0
				If flag2 Then
					Me.dgvView.Rows.Add()
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Description").Value = "Product BOM(s) Pending For Approval"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Count").Value = num
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormName").Value = "BOM Approval"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormMode").Value = "Approval"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("TabTextVal").Value = "BOM Approval"
				End If
			End If
		End Sub

		' Token: 0x060000C1 RID: 193 RVA: 0x00007880 File Offset: 0x00005A80
		Private Sub PR_On_Hold()
			Dim text As String = " SELECT COUNT(PRID) AS Cnt FROM PR WHERE Status = 'On-Hold' "
			Dim flag As Boolean = Strings.InStr(GlobalVariables.gsUserGroup.ToLower(), "admin", Microsoft.VisualBasic.CompareMethod.Binary) = 0
			If flag Then
				text = text + " AND Department = '" + GlobalVariables.gsDepartment + "' "
			End If
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag2 As Boolean = data.Rows.Count > 0
			If flag2 Then
				Dim num As Integer = Conversions.ToInteger(data.Rows(0)("Cnt"))
				Dim flag3 As Boolean = num > 0
				If flag3 Then
					Me.dgvView.Rows.Add()
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Description").Value = "PR(s) On-Hold"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Count").Value = num
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormName").Value = "PRList"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormMode").Value = "PR On-Hold"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("TabTextVal").Value = "PR On-Hold List"
				End If
			End If
		End Sub

		' Token: 0x060000C2 RID: 194 RVA: 0x00007A3C File Offset: 0x00005C3C
		Private Sub PR_Cost_On_Hold()
			Dim text As String = " SELECT COUNT(PRID) AS Cnt FROM PR WHERE Status = 'Cost On-Hold' "
			Dim flag As Boolean = Strings.InStr(GlobalVariables.gsUserGroup.ToLower(), "admin", Microsoft.VisualBasic.CompareMethod.Binary) = 0
			If flag Then
				text = text + " AND Department = '" + GlobalVariables.gsDepartment + "' "
			End If
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag2 As Boolean = data.Rows.Count > 0
			If flag2 Then
				Dim num As Integer = Conversions.ToInteger(data.Rows(0)("Cnt"))
				Dim flag3 As Boolean = num > 0
				If flag3 Then
					Me.dgvView.Rows.Add()
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Description").Value = "PR(s) Cost On-Hold"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Count").Value = num
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormName").Value = "PRList"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormMode").Value = "PR Cost On-Hold"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("TabTextVal").Value = "PR Cost On-Hold List"
				End If
			End If
		End Sub

		' Token: 0x060000C3 RID: 195 RVA: 0x00007BF8 File Offset: 0x00005DF8
		Private Sub PR_Approval_Pending()
			Dim text As String = " SELECT COUNT(PRID) AS Cnt FROM PR WHERE Status = 'In Approval' "
			Dim flag As Boolean = Strings.InStr(GlobalVariables.gsUserGroup.ToLower(), "admin", Microsoft.VisualBasic.CompareMethod.Binary) = 0
			If flag Then
				text = text + " AND Department = '" + GlobalVariables.gsDepartment + "' "
			End If
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag2 As Boolean = data.Rows.Count > 0
			If flag2 Then
				Dim num As Integer = Conversions.ToInteger(data.Rows(0)("Cnt"))
				Dim flag3 As Boolean = num > 0
				If flag3 Then
					Me.dgvView.Rows.Add()
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Description").Value = "PR(s) Pending For Approval"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Count").Value = num
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormName").Value = "PRList"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormMode").Value = "PR Approval"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("TabTextVal").Value = "PR Approval List"
				End If
			End If
		End Sub

		' Token: 0x060000C4 RID: 196 RVA: 0x00007DB4 File Offset: 0x00005FB4
		Private Sub PR_Cost_Approval_Pending()
			Dim text As String = " SELECT COUNT(PRID) AS Cnt FROM PR WHERE Status = 'In Cost Approval' "
			Dim flag As Boolean = Strings.InStr(GlobalVariables.gsUserGroup.ToLower(), "admin", Microsoft.VisualBasic.CompareMethod.Binary) = 0
			If flag Then
				text = text + " AND Department = '" + GlobalVariables.gsDepartment + "' "
			End If
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag2 As Boolean = data.Rows.Count > 0
			If flag2 Then
				Dim num As Integer = Conversions.ToInteger(data.Rows(0)("Cnt"))
				Dim flag3 As Boolean = num > 0
				If flag3 Then
					Me.dgvView.Rows.Add()
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Description").Value = "PR(s) Pending For Cost Approval"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Count").Value = num
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormName").Value = "PRList"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormMode").Value = "PR Cost Approval"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("TabTextVal").Value = "PR Cost Approval List"
				End If
			End If
		End Sub

		' Token: 0x060000C5 RID: 197 RVA: 0x00007F70 File Offset: 0x00006170
		Private Sub PR_PO_Pending()
			Dim text As String = " SELECT COUNT(PRID) AS Cnt FROM PR WHERE Status = 'Cost Approved' "
			Dim flag As Boolean = Strings.InStr(GlobalVariables.gsUserGroup.ToLower(), "admin", Microsoft.VisualBasic.CompareMethod.Binary) = 0
			If flag Then
				text = text + " AND Department = '" + GlobalVariables.gsDepartment + "' "
			End If
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag2 As Boolean = data.Rows.Count > 0
			If flag2 Then
				Dim num As Integer = Conversions.ToInteger(data.Rows(0)("Cnt"))
				Dim flag3 As Boolean = num > 0
				If flag3 Then
					Me.dgvView.Rows.Add()
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Description").Value = "PR(s) Pending For PO Release"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Count").Value = num
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormName").Value = "PRReport"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormMode").Value = "PO Pending"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("TabTextVal").Value = "PO Pending List"
				End If
			End If
		End Sub

		' Token: 0x060000C6 RID: 198 RVA: 0x0000812C File Offset: 0x0000632C
		Private Sub PO_On_Hold()
			Dim text As String = " SELECT COUNT(POID) AS Cnt FROM PO WHERE Status = 'On-Hold' "
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim num As Integer = Conversions.ToInteger(data.Rows(0)("Cnt"))
				Dim flag2 As Boolean = num > 0
				If flag2 Then
					Me.dgvView.Rows.Add()
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Description").Value = "PO(s) On-Hold"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Count").Value = num
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormName").Value = "POList"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormMode").Value = "PO On-Hold"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("TabTextVal").Value = "PO On-Hold List"
				End If
			End If
		End Sub

		' Token: 0x060000C7 RID: 199 RVA: 0x000082B0 File Offset: 0x000064B0
		Private Sub PO_Cost_On_Hold()
			Dim text As String = " SELECT COUNT(POID) AS Cnt FROM PO WHERE Status = 'Cost On-Hold' "
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim num As Integer = Conversions.ToInteger(data.Rows(0)("Cnt"))
				Dim flag2 As Boolean = num > 0
				If flag2 Then
					Me.dgvView.Rows.Add()
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Description").Value = "PO(s) Cost On-Hold"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Count").Value = num
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormName").Value = "POList"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormMode").Value = "PO Cost On-Hold"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("TabTextVal").Value = "PO Cost On-Hold List"
				End If
			End If
		End Sub

		' Token: 0x060000C8 RID: 200 RVA: 0x00008434 File Offset: 0x00006634
		Private Sub PO_Approval_Pending()
			Dim text As String = " SELECT COUNT(POID) AS Cnt FROM PO WHERE Status = 'In Approval' "
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim num As Integer = Conversions.ToInteger(data.Rows(0)("Cnt"))
				Dim flag2 As Boolean = num > 0
				If flag2 Then
					Me.dgvView.Rows.Add()
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Description").Value = "PO(s) Pending For Approval"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Count").Value = num
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormName").Value = "POList"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormMode").Value = "PO Approval"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("TabTextVal").Value = "PO Approval List"
				End If
			End If
		End Sub

		' Token: 0x060000C9 RID: 201 RVA: 0x000085B8 File Offset: 0x000067B8
		Private Sub PO_Cost_Approval_Pending()
			Dim text As String = " SELECT COUNT(POID) AS Cnt FROM PO WHERE Status = 'In Cost Approval' "
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim num As Integer = Conversions.ToInteger(data.Rows(0)("Cnt"))
				Dim flag2 As Boolean = num > 0
				If flag2 Then
					Me.dgvView.Rows.Add()
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Description").Value = "PO(s) Pending For Cost Approval"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Count").Value = num
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormName").Value = "POList"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormMode").Value = "PO Cost Approval"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("TabTextVal").Value = "PO Cost Approval List"
				End If
			End If
		End Sub

		' Token: 0x060000CA RID: 202 RVA: 0x0000873C File Offset: 0x0000693C
		Private Sub PO_Printing_Pending()
			Dim text As String = " SELECT COUNT(POID) AS Cnt FROM PO WHERE Status = 'Cost Approved' "
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim num As Integer = Conversions.ToInteger(data.Rows(0)("Cnt"))
				Dim flag2 As Boolean = num > 0
				If flag2 Then
					Me.dgvView.Rows.Add()
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Description").Value = "PO(s) Pending For Printing"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Count").Value = num
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormName").Value = "POList"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormMode").Value = "PO Printing"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("TabTextVal").Value = "PO Printing List"
				End If
			End If
		End Sub

		' Token: 0x060000CB RID: 203 RVA: 0x000088C0 File Offset: 0x00006AC0
		Private Sub PO_Receipt_Pending()
			Dim text As String = " SELECT COUNT(DISTINCT PO.POID) AS Cnt " & vbCrLf
			text += " FROM PO INNER JOIN POItems POI ON PO.POID =  POI.POID" & vbCrLf
			text += " INNER JOIN Product P ON POI.ProductID = P.ProductID" & vbCrLf
			text += " WHERE P.IsGRNApplicable = 1 AND PO.Status = 'Printed' AND PO.POType = 'Item'" & vbCrLf
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim num As Integer = Conversions.ToInteger(data.Rows(0)("Cnt"))
				Dim flag2 As Boolean = num > 0
				If flag2 Then
					Me.dgvView.Rows.Add()
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Description").Value = "PO(s) Pending For Material Receipt"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Count").Value = num
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormName").Value = "GRNList"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormMode").Value = "GRN PO Receipt"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("TabTextVal").Value = "PO Receipt List"
				End If
			End If
		End Sub

		' Token: 0x060000CC RID: 204 RVA: 0x00008A68 File Offset: 0x00006C68
		Private Sub GRN_On_Hold()
			Dim text As String = " SELECT COUNT(GRNID) AS Cnt FROM GRN WHERE Status = 'GRN On-Hold' "
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim num As Integer = Conversions.ToInteger(data.Rows(0)("Cnt"))
				Dim flag2 As Boolean = num > 0
				If flag2 Then
					Me.dgvView.Rows.Add()
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Description").Value = "GRN(s) On-Hold"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Count").Value = num
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormName").Value = "GRNList"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormMode").Value = "GRN On-Hold"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("TabTextVal").Value = "GRN On-Hold List"
				End If
			End If
		End Sub

		' Token: 0x060000CD RID: 205 RVA: 0x00008BEC File Offset: 0x00006DEC
		Private Sub GRN_Approval_Pending()
			Dim text As String = " SELECT COUNT(GRNID) AS Cnt FROM GRN WHERE Status = 'GRN In Approval' "
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim num As Integer = Conversions.ToInteger(data.Rows(0)("Cnt"))
				Dim flag2 As Boolean = num > 0
				If flag2 Then
					Me.dgvView.Rows.Add()
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Description").Value = "GRN(s) Pending For Approval"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Count").Value = num
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormName").Value = "GRNList"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormMode").Value = "GRN Approval"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("TabTextVal").Value = "GRN Approval List"
				End If
			End If
		End Sub

		' Token: 0x060000CE RID: 206 RVA: 0x00008D70 File Offset: 0x00006F70
		Private Sub QC_Entry_Pending()
			Dim text As String = " SELECT COUNT(GRNItemsID) AS Cnt " & vbCrLf
			text += " FROM GRN AS G " & vbCrLf
			text += " INNER JOIN GRNItems AS GI ON G.GRNID = GI.GRNID " & vbCrLf
			text += " WHERE GI.IsQCApplicable = 1 AND GI.Status = 'In QC Release' " & vbCrLf
			text += " AND G.Status IN ('GRN Approved', 'Under Release', 'Release Complete')" & vbCrLf
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim num As Integer = Conversions.ToInteger(data.Rows(0)("Cnt"))
				Dim flag2 As Boolean = num > 0
				If flag2 Then
					Me.dgvView.Rows.Add()
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Description").Value = "Item(s) Pending For QC Entry"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Count").Value = num
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormName").Value = "GRNListItem"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormMode").Value = "GRN QC Entry"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("TabTextVal").Value = "QC Entry List"
				End If
			End If
		End Sub

		' Token: 0x060000CF RID: 207 RVA: 0x00008F24 File Offset: 0x00007124
		Private Sub QC_Release_OnHold()
			Dim text As String = " SELECT COUNT(GRNItemsID) AS Cnt " & vbCrLf
			text += " FROM  GRN AS G " & vbCrLf
			text += " INNER JOIN GRNItems AS GI ON G.GRNID = GI.GRNID " & vbCrLf
			text += " WHERE GI.IsQCApplicable = 1 AND GI.Status = 'QC On-Hold' " & vbCrLf
			text += " AND G.Status IN ('GRN Approved', 'Under Release', 'Release Complete')" & vbCrLf
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim num As Integer = Conversions.ToInteger(data.Rows(0)("Cnt"))
				Dim flag2 As Boolean = num > 0
				If flag2 Then
					Me.dgvView.Rows.Add()
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Description").Value = "Item(s) On QC Hold"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Count").Value = num
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormName").Value = "GRNListItem"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormMode").Value = "GRN QC Entry"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("TabTextVal").Value = "QC On-Hold List"
				End If
			End If
		End Sub

		' Token: 0x060000D0 RID: 208 RVA: 0x000090D8 File Offset: 0x000072D8
		Private Sub QA_Release_OnHold()
			Dim text As String = " SELECT COUNT(GRNItemsID) AS Cnt " & vbCrLf
			text += " FROM  GRN AS G " & vbCrLf
			text += " INNER JOIN GRNItems AS GI ON G.GRNID = GI.GRNID " & vbCrLf
			text += " WHERE GI.IsQCApplicable = 1 AND GI.Status = 'QA On-Hold' " & vbCrLf
			text += " AND G.Status IN ('GRN Approved', 'Under Release', 'Release Complete')" & vbCrLf
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim num As Integer = Conversions.ToInteger(data.Rows(0)("Cnt"))
				Dim flag2 As Boolean = num > 0
				If flag2 Then
					Me.dgvView.Rows.Add()
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Description").Value = "Item(s) On QA Hold"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Count").Value = num
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormName").Value = "GRNListItem"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormMode").Value = "GRN QC Entry"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("TabTextVal").Value = "QA On-Hold List"
				End If
			End If
		End Sub

		' Token: 0x060000D1 RID: 209 RVA: 0x0000928C File Offset: 0x0000748C
		Private Sub QC_Release_Pending()
			Dim text As String = " SELECT COUNT(GRNItemsID) AS Cnt " & vbCrLf
			text += " FROM  GRN AS G " & vbCrLf
			text += " INNER JOIN GRNItems AS GI ON G.GRNID = GI.GRNID " & vbCrLf
			text += " WHERE GI.IsQCApplicable = 1 AND GI.Status = 'QC Saved' " & vbCrLf
			text += " AND G.Status IN ('GRN Approved', 'Under Release', 'Release Complete')" & vbCrLf
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim num As Integer = Conversions.ToInteger(data.Rows(0)("Cnt"))
				Dim flag2 As Boolean = num > 0
				If flag2 Then
					Me.dgvView.Rows.Add()
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Description").Value = "Item(s) Pending For QC Release"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Count").Value = num
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormName").Value = "GRNListItem"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormMode").Value = "GRN QC Release"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("TabTextVal").Value = "QC Release List"
				End If
			End If
		End Sub

		' Token: 0x060000D2 RID: 210 RVA: 0x00009440 File Offset: 0x00007640
		Private Sub QA_Release_Pending()
			Dim text As String = " SELECT COUNT(GRNItemsID) AS Cnt " & vbCrLf
			text += " FROM  GRN AS G " & vbCrLf
			text += " INNER JOIN GRNItems AS GI ON G.GRNID = GI.GRNID " & vbCrLf
			text += " WHERE GI.IsQCApplicable = 1 AND GI.Status = 'QC Approved' " & vbCrLf
			text += " AND G.Status IN ('GRN Approved', 'Under Release', 'Release Complete')" & vbCrLf
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim num As Integer = Conversions.ToInteger(data.Rows(0)("Cnt"))
				Dim flag2 As Boolean = num > 0
				If flag2 Then
					Me.dgvView.Rows.Add()
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Description").Value = "Item(s) Pending For QA Release"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Count").Value = num
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormName").Value = "GRNListItem"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormMode").Value = "GRN QA Release"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("TabTextVal").Value = "QA Release List"
				End If
			End If
		End Sub

		' Token: 0x060000D3 RID: 211 RVA: 0x000095F4 File Offset: 0x000077F4
		Private Sub Material_Request_In_Picking()
			Dim text As String = " SELECT COUNT(RequestID) AS Cnt FROM Request WHERE Status = 'Request Generated' "
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim num As Integer = Conversions.ToInteger(data.Rows(0)("Cnt"))
				Dim flag2 As Boolean = num > 0
				If flag2 Then
					Me.dgvView.Rows.Add()
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Description").Value = "Material Request(s) In Picking"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Count").Value = num
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormName").Value = "IssueList"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormMode").Value = "Picking"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("TabTextVal").Value = "Picking List"
				End If
			End If
		End Sub

		' Token: 0x060000D4 RID: 212 RVA: 0x00009778 File Offset: 0x00007978
		Private Sub Material_Request_In_QA_OnHold()
			Dim text As String = " SELECT COUNT(IssueID) AS Cnt FROM Issue WHERE Status = 'QA On-Hold' "
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim num As Integer = Conversions.ToInteger(data.Rows(0)("Cnt"))
				Dim flag2 As Boolean = num > 0
				If flag2 Then
					Me.dgvView.Rows.Add()
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Description").Value = "Material Picking(s) On QA On-Hold"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Count").Value = num
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormName").Value = "IssueList"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormMode").Value = "Picking"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("TabTextVal").Value = "QA On-Hold List"
				End If
			End If
		End Sub

		' Token: 0x060000D5 RID: 213 RVA: 0x000098FC File Offset: 0x00007AFC
		Private Sub Material_Request_In_QA_Approval()
			Dim text As String = " SELECT COUNT(IssueID) AS Cnt FROM Issue WHERE Status = 'Picked' "
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim num As Integer = Conversions.ToInteger(data.Rows(0)("Cnt"))
				Dim flag2 As Boolean = num > 0
				If flag2 Then
					Me.dgvView.Rows.Add()
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Description").Value = "Material Picking(s) Pending For QA Approval"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Count").Value = num
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormName").Value = "IssueList"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormMode").Value = "QA Approval"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("TabTextVal").Value = "QA Approval List"
				End If
			End If
		End Sub

		' Token: 0x060000D6 RID: 214 RVA: 0x00009A80 File Offset: 0x00007C80
		Private Sub Material_Request_Waiting_For_Issue()
			Dim text As String = " SELECT COUNT(IssueID) AS Cnt FROM Issue WHERE Status = 'QA Approved' "
			Dim data As DataTable = MainModule.GetData(text)
			Dim flag As Boolean = data.Rows.Count > 0
			If flag Then
				Dim num As Integer = Conversions.ToInteger(data.Rows(0)("Cnt"))
				Dim flag2 As Boolean = num > 0
				If flag2 Then
					Me.dgvView.Rows.Add()
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Description").Value = "Material Picking(s) Waiting For Issue"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("Count").Value = num
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormName").Value = "IssueList"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("FormMode").Value = "Issue"
					Me.dgvView.Rows(Me.dgvView.RowCount - 1).Cells("TabTextVal").Value = "Material Issue List"
				End If
			End If
		End Sub

		' Token: 0x060000D7 RID: 215 RVA: 0x00009C04 File Offset: 0x00007E04
		Private Sub SetCharts()
			Dim now As DateTime = DateAndTime.Now
			Me.dtWeeks = Me.GetWeekDates(now)
			Me.New_Material_This_Month(now)
			Me.PO_This_Month(now)
			Me.GRN_This_Month(now)
			Me.Request_This_Month(now)
		End Sub

		' Token: 0x060000D8 RID: 216 RVA: 0x00009C48 File Offset: 0x00007E48
		Private Function GetWeekDates(dMonth As DateTime) As DataTable
			Dim dataTable As DataTable = New DataTable()
			dataTable.Columns.Add("StartDate", Type.[GetType]("System.DateTime"))
			dataTable.Columns.Add("EndDate", Type.[GetType]("System.DateTime"))
			Dim num As Integer = DateTime.DaysInMonth(dMonth.Year, dMonth.Month)
			Dim dateTime As DateTime = Conversions.ToDate(Strings.Format(dMonth, Strings.Format(num, "#00") + "/MMM/yyyy 23:59:59"))
			Dim dateTime2 As DateTime = Conversions.ToDate(Strings.Format(dMonth, "01/MMM/yyyy 00:00:00"))
			Dim num2 As Integer = CInt((dateTime2.DayOfWeek + 1))
			Dim dateTime3 As DateTime = Conversions.ToDate(Strings.Format(DateAndTime.DateAdd(DateInterval.Day, CDbl((7 - num2)), dateTime2), "dd/MMM/yyyy 23:59:59"))
			dataTable.Rows.Add(New Object(-1) {})
			dataTable.Rows(dataTable.Rows.Count - 1)("StartDate") = dateTime2
			dataTable.Rows(dataTable.Rows.Count - 1)("EndDate") = dateTime3
			Dim flag2 As Boolean
			Do
				dateTime2 = Conversions.ToDate(Strings.Format(DateAndTime.DateAdd(DateInterval.Day, 1.0, dateTime3), "dd/MMM/yyyy 00:00:00"))
				Dim flag As Boolean = dateTime3.Day + 7 <= dateTime.Day
				If flag Then
					dateTime3 = Conversions.ToDate(Strings.Format(DateAndTime.DateAdd(DateInterval.Day, 7.0, dateTime3), "dd/MMM/yyyy 23:59:59"))
				Else
					dateTime3 = dateTime
				End If
				dataTable.Rows.Add(New Object(-1) {})
				dataTable.Rows(dataTable.Rows.Count - 1)("StartDate") = dateTime2
				dataTable.Rows(dataTable.Rows.Count - 1)("EndDate") = dateTime3
				flag2 = DateTime.Compare(dateTime3, dateTime) = 0
			Loop While Not flag2
			Return dataTable
		End Function

		' Token: 0x060000D9 RID: 217 RVA: 0x00009E7C File Offset: 0x0000807C
		Private Sub New_Material_This_Month(dCheckDt As DateTime)
			Dim dateTime As DateTime = Conversions.ToDate("01" + Strings.Format(dCheckDt, "/MMM/") + Strings.Format(dCheckDt, "yyyy"))
			Dim dateTime2 As DateTime = Conversions.ToDate(Conversions.ToString(DateTime.DaysInMonth(Conversions.ToInteger(Strings.Format(dCheckDt, "yyyy")), Conversions.ToInteger(Strings.Format(dCheckDt, "MM")))) + Strings.Format(dCheckDt, "/MMM/") + Strings.Format(dCheckDt, "yyyy"))
			Dim text As String = " SELECT GRNUIDID, Status, CreationDt "
			text += " FROM GRNUID "
			text += " WHERE 1=1 "
			text = String.Concat(New String() { text, " AND CreationDt BETWEEN '", Strings.Format(dateTime, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(dateTime2, "MM/dd/yyyy 23:59:59"), "'" })
			Dim data As DataTable = MainModule.GetData(text)
			Me.Chart0.Titles("Title1").Text = "Material  Received In  Month  Of - " + Strings.Format(dCheckDt, "MMM")
			Me.Chart0.Series("Quantity").Points.Clear()
			Dim num As Integer = Me.dtWeeks.Rows.Count - 1
			For i As Integer = 0 To num
				Dim text2 As String = String.Concat(New String() { "CreationDt >= '", Strings.Format(RuntimeHelpers.GetObjectValue(Me.dtWeeks.Rows(i)("StartDate")), "MM/dd/yyyy 00:00:00"), "' AND CreationDt <= '", Strings.Format(RuntimeHelpers.GetObjectValue(Me.dtWeeks.Rows(i)("EndDate")), "MM/dd/yyyy 23:59:59"), "'" })
				Dim dataView As DataView = New DataView(data, text2, "", DataViewRowState.CurrentRows)
				Dim dataTable As DataTable = dataView.ToTable()
				Dim num2 As Long = 0L
				Dim flag As Boolean = dataTable.Rows.Count > 0
				If flag Then
					' The following expression was wrapped in a unchecked-expression
					num2 = CLng(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Compute("COUNT(GRNUIDID)", String.Empty))))
				End If
				Me.Chart0.Series("Quantity").Points.AddXY("Week " + Conversions.ToString(i + 1), New Object() { num2 })
			Next
		End Sub

		' Token: 0x060000DA RID: 218 RVA: 0x0000A124 File Offset: 0x00008324
		Private Sub PO_This_Month(dCheckDt As DateTime)
			Dim dateTime As DateTime = Conversions.ToDate("01" + Strings.Format(dCheckDt, "/MMM/") + Strings.Format(dCheckDt, "yyyy"))
			Dim dateTime2 As DateTime = Conversions.ToDate(Conversions.ToString(DateTime.DaysInMonth(Conversions.ToInteger(Strings.Format(dCheckDt, "yyyy")), Conversions.ToInteger(Strings.Format(dCheckDt, "MM")))) + Strings.Format(dCheckDt, "/MMM/") + Strings.Format(dCheckDt, "yyyy"))
			Dim text As String = " SELECT POID, PONo, Department, Status, CreationDt "
			text += " FROM PO "
			text += " WHERE 1=1 "
			text = String.Concat(New String() { text, " AND CreationDt BETWEEN '", Strings.Format(dateTime, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(dateTime2, "MM/dd/yyyy 23:59:59"), "'" })
			Dim data As DataTable = MainModule.GetData(text)
			Me.Chart1.Titles("Title1").Text = "PO  Created  In  Month  Of - " + Strings.Format(dCheckDt, "MMM")
			Me.Chart1.Series("No. Of PO").Points.Clear()
			Dim num As Integer = Me.dtWeeks.Rows.Count - 1
			For i As Integer = 0 To num
				Dim text2 As String = String.Concat(New String() { "CreationDt >= '", Strings.Format(RuntimeHelpers.GetObjectValue(Me.dtWeeks.Rows(i)("StartDate")), "MM/dd/yyyy 00:00:00"), "' AND CreationDt <= '", Strings.Format(RuntimeHelpers.GetObjectValue(Me.dtWeeks.Rows(i)("EndDate")), "MM/dd/yyyy 23:59:59"), "'" })
				Dim dataView As DataView = New DataView(data, text2, "", DataViewRowState.CurrentRows)
				Dim dataTable As DataTable = dataView.ToTable()
				Dim num2 As Long = 0L
				Dim flag As Boolean = dataTable.Rows.Count > 0
				If flag Then
					' The following expression was wrapped in a unchecked-expression
					num2 = CLng(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Compute("COUNT(POID)", String.Empty))))
				End If
				Me.Chart1.Series("No. Of PO").Points.AddXY("Week " + Conversions.ToString(i + 1), New Object() { num2 })
			Next
		End Sub

		' Token: 0x060000DB RID: 219 RVA: 0x0000A3CC File Offset: 0x000085CC
		Private Sub GRN_This_Month(dCheckDt As DateTime)
			Dim dateTime As DateTime = Conversions.ToDate("01" + Strings.Format(dCheckDt, "/MMM/") + Strings.Format(dCheckDt, "yyyy"))
			Dim dateTime2 As DateTime = Conversions.ToDate(Conversions.ToString(DateTime.DaysInMonth(Conversions.ToInteger(Strings.Format(dCheckDt, "yyyy")), Conversions.ToInteger(Strings.Format(dCheckDt, "MM")))) + Strings.Format(dCheckDt, "/MMM/") + Strings.Format(dCheckDt, "yyyy"))
			Dim text As String = " SELECT GRNID, GRNNo, Status, CreationDt "
			text += " FROM GRN "
			text += " WHERE 1=1 "
			text = String.Concat(New String() { text, " AND CreationDt BETWEEN '", Strings.Format(dateTime, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(dateTime2, "MM/dd/yyyy 23:59:59"), "'" })
			Dim data As DataTable = MainModule.GetData(text)
			Me.Chart2.Titles("Title1").Text = "GRN  Created  In  Month  Of - " + Strings.Format(dCheckDt, "MMM")
			Me.Chart2.Series("No. Of GRN").Points.Clear()
			Dim num As Integer = Me.dtWeeks.Rows.Count - 1
			For i As Integer = 0 To num
				Dim text2 As String = String.Concat(New String() { "CreationDt >= '", Strings.Format(RuntimeHelpers.GetObjectValue(Me.dtWeeks.Rows(i)("StartDate")), "MM/dd/yyyy 00:00:00"), "' AND CreationDt <= '", Strings.Format(RuntimeHelpers.GetObjectValue(Me.dtWeeks.Rows(i)("EndDate")), "MM/dd/yyyy 23:59:59"), "'" })
				Dim dataView As DataView = New DataView(data, text2, "", DataViewRowState.CurrentRows)
				Dim dataTable As DataTable = dataView.ToTable()
				Dim num2 As Long = 0L
				Dim flag As Boolean = dataTable.Rows.Count > 0
				If flag Then
					' The following expression was wrapped in a unchecked-expression
					num2 = CLng(Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Compute("COUNT(GRNID)", String.Empty))))
				End If
				Me.Chart2.Series("No. Of GRN").Points.AddXY("Week " + Conversions.ToString(i + 1), New Object() { num2 })
			Next
		End Sub

		' Token: 0x060000DC RID: 220 RVA: 0x0000A674 File Offset: 0x00008874
		Private Sub Request_This_Month(dCheckDt As DateTime)
			Dim dateTime As DateTime = Conversions.ToDate("01" + Strings.Format(dCheckDt, "/MMM/") + Strings.Format(dCheckDt, "yyyy"))
			Dim dateTime2 As DateTime = Conversions.ToDate(Conversions.ToString(DateTime.DaysInMonth(Conversions.ToInteger(Strings.Format(dCheckDt, "yyyy")), Conversions.ToInteger(Strings.Format(dCheckDt, "MM")))) + Strings.Format(dCheckDt, "/MMM/") + Strings.Format(dCheckDt, "yyyy"))
			Dim text As String = " SELECT RequestID, RequestNo, Status, CreationDt "
			text += " FROM Request "
			text += " WHERE 1=1 "
			text = String.Concat(New String() { text, " AND CreationDt BETWEEN '", Strings.Format(dateTime, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(dateTime2, "MM/dd/yyyy 23:59:59"), "'" })
			Dim data As DataTable = MainModule.GetData(text)
			Me.Chart3.Titles("Title1").Text = "Material  Request  Status  In  Month  Of - " + Strings.Format(dCheckDt, "MMM")
			Dim array As DataRow() = data.[Select]("Status = 'Request Generated'")
			Dim array2 As DataRow() = data.[Select]("Status = 'In Picking'")
			Dim array3 As DataRow() = data.[Select]("Status = 'Issue Complete'")
			Me.Chart3.Series("Status").Points.Clear()
			Me.Chart3.Series("Status").Points.AddXY("Request Generated", New Object() { array.Length })
			Me.Chart3.Series("Status").Points.AddXY("In Picking", New Object() { array2.Length })
			Me.Chart3.Series("Status").Points.AddXY("Issue Complete", New Object() { array3.Length })
		End Sub

		' Token: 0x060000DD RID: 221 RVA: 0x0000A8A8 File Offset: 0x00008AA8
		Private Sub PO_This_Year(dCheckDt As DateTime)
			Dim flag As Boolean = dCheckDt.Month > 3
			If flag Then
				Dim dateTime As DateTime = Conversions.ToDate("01-Apr-" + Strings.Format(dCheckDt.Year, "#0000") + " 00:00:00")
				Dim dateTime2 As DateTime = Conversions.ToDate("31-Mar-" + Strings.Format(dCheckDt.Year + 1, "#0000") + " 23:59:59")
			Else
				Dim dateTime As DateTime = Conversions.ToDate("01-Apr-" + Strings.Format(dCheckDt.Year - 1, "#0000") + " 00:00:00")
				Dim dateTime2 As DateTime = Conversions.ToDate("31-Mar-" + Strings.Format(dCheckDt.Year, "#0000") + " 23:59:59")
			End If
		End Sub

		' Token: 0x04000041 RID: 65
		Private dtWeeks As DataTable
	End Class
End Namespace
