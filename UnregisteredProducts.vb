Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports WeifenLuo.WinFormsUI.Docking

Namespace Datasoft_PIMS
	' Token: 0x02000019 RID: 25
	<DesignerGenerated()>
	Public Partial Class UnregisteredProducts
		Inherits DockContent

		' Token: 0x17000174 RID: 372
		' (get) Token: 0x060003EC RID: 1004 RVA: 0x00026E57 File Offset: 0x00025057
		' (set) Token: 0x060003ED RID: 1005 RVA: 0x00026E61 File Offset: 0x00025061
		Friend Overridable Property GbBasic As GroupBox

		' Token: 0x17000175 RID: 373
		' (get) Token: 0x060003EE RID: 1006 RVA: 0x00026E6A File Offset: 0x0002506A
		' (set) Token: 0x060003EF RID: 1007 RVA: 0x00026E74 File Offset: 0x00025074
		Friend Overridable Property cmbPlant As ComboBox

		' Token: 0x17000176 RID: 374
		' (get) Token: 0x060003F0 RID: 1008 RVA: 0x00026E7D File Offset: 0x0002507D
		' (set) Token: 0x060003F1 RID: 1009 RVA: 0x00026E87 File Offset: 0x00025087
		Friend Overridable Property Label1 As Label

		' Token: 0x17000177 RID: 375
		' (get) Token: 0x060003F2 RID: 1010 RVA: 0x00026E90 File Offset: 0x00025090
		' (set) Token: 0x060003F3 RID: 1011 RVA: 0x00026E9A File Offset: 0x0002509A
		Friend Overridable Property txtNo As TextBox

		' Token: 0x17000178 RID: 376
		' (get) Token: 0x060003F4 RID: 1012 RVA: 0x00026EA3 File Offset: 0x000250A3
		' (set) Token: 0x060003F5 RID: 1013 RVA: 0x00026EAD File Offset: 0x000250AD
		Friend Overridable Property cmbStatus As ComboBox

		' Token: 0x17000179 RID: 377
		' (get) Token: 0x060003F6 RID: 1014 RVA: 0x00026EB6 File Offset: 0x000250B6
		' (set) Token: 0x060003F7 RID: 1015 RVA: 0x00026EC0 File Offset: 0x000250C0
		Friend Overridable Property dtpFrom As DateTimePicker

		' Token: 0x1700017A RID: 378
		' (get) Token: 0x060003F8 RID: 1016 RVA: 0x00026EC9 File Offset: 0x000250C9
		' (set) Token: 0x060003F9 RID: 1017 RVA: 0x00026ED3 File Offset: 0x000250D3
		Friend Overridable Property Label11 As Label

		' Token: 0x1700017B RID: 379
		' (get) Token: 0x060003FA RID: 1018 RVA: 0x00026EDC File Offset: 0x000250DC
		' (set) Token: 0x060003FB RID: 1019 RVA: 0x00026EE6 File Offset: 0x000250E6
		Friend Overridable Property dtpTo As DateTimePicker

		' Token: 0x1700017C RID: 380
		' (get) Token: 0x060003FC RID: 1020 RVA: 0x00026EEF File Offset: 0x000250EF
		' (set) Token: 0x060003FD RID: 1021 RVA: 0x00026EF9 File Offset: 0x000250F9
		Friend Overridable Property Label16 As Label

		' Token: 0x1700017D RID: 381
		' (get) Token: 0x060003FE RID: 1022 RVA: 0x00026F02 File Offset: 0x00025102
		' (set) Token: 0x060003FF RID: 1023 RVA: 0x00026F0C File Offset: 0x0002510C
		Friend Overridable Property lblDate As ComboBox

		' Token: 0x1700017E RID: 382
		' (get) Token: 0x06000400 RID: 1024 RVA: 0x00026F15 File Offset: 0x00025115
		' (set) Token: 0x06000401 RID: 1025 RVA: 0x00026F20 File Offset: 0x00025120
		Friend Overridable Property arrow_btnBasicExp_sml As Button
			<CompilerGenerated()>
			Get
				Return Me._arrow_btnBasicExp_sml
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.skip_btnBasicExp_sml_Click
				Dim button As Button = Me._arrow_btnBasicExp_sml
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._arrow_btnBasicExp_sml = value
				button = Me._arrow_btnBasicExp_sml
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700017F RID: 383
		' (get) Token: 0x06000402 RID: 1026 RVA: 0x00026F63 File Offset: 0x00025163
		' (set) Token: 0x06000403 RID: 1027 RVA: 0x00026F6D File Offset: 0x0002516D
		Friend Overridable Property GbAdvanced As GroupBox

		' Token: 0x17000180 RID: 384
		' (get) Token: 0x06000404 RID: 1028 RVA: 0x00026F76 File Offset: 0x00025176
		' (set) Token: 0x06000405 RID: 1029 RVA: 0x00026F80 File Offset: 0x00025180
		Friend Overridable Property txtName As TextBox

		' Token: 0x17000181 RID: 385
		' (get) Token: 0x06000406 RID: 1030 RVA: 0x00026F89 File Offset: 0x00025189
		' (set) Token: 0x06000407 RID: 1031 RVA: 0x00026F93 File Offset: 0x00025193
		Friend Overridable Property txtCode As TextBox

		' Token: 0x17000182 RID: 386
		' (get) Token: 0x06000408 RID: 1032 RVA: 0x00026F9C File Offset: 0x0002519C
		' (set) Token: 0x06000409 RID: 1033 RVA: 0x00026FA6 File Offset: 0x000251A6
		Friend Overridable Property Label14 As Label

		' Token: 0x17000183 RID: 387
		' (get) Token: 0x0600040A RID: 1034 RVA: 0x00026FAF File Offset: 0x000251AF
		' (set) Token: 0x0600040B RID: 1035 RVA: 0x00026FB9 File Offset: 0x000251B9
		Friend Overridable Property Label9 As Label

		' Token: 0x17000184 RID: 388
		' (get) Token: 0x0600040C RID: 1036 RVA: 0x00026FC2 File Offset: 0x000251C2
		' (set) Token: 0x0600040D RID: 1037 RVA: 0x00026FCC File Offset: 0x000251CC
		Friend Overridable Property txtCreated As TextBox

		' Token: 0x17000185 RID: 389
		' (get) Token: 0x0600040E RID: 1038 RVA: 0x00026FD5 File Offset: 0x000251D5
		' (set) Token: 0x0600040F RID: 1039 RVA: 0x00026FDF File Offset: 0x000251DF
		Friend Overridable Property lblCreated As ComboBox

		' Token: 0x17000186 RID: 390
		' (get) Token: 0x06000410 RID: 1040 RVA: 0x00026FE8 File Offset: 0x000251E8
		' (set) Token: 0x06000411 RID: 1041 RVA: 0x00026FF4 File Offset: 0x000251F4
		Friend Overridable Property arrow_btnAdvanceExp_sml As Button
			<CompilerGenerated()>
			Get
				Return Me._arrow_btnAdvanceExp_sml
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.skip_btnAdvanceExp_sml_Click
				Dim button As Button = Me._arrow_btnAdvanceExp_sml
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._arrow_btnAdvanceExp_sml = value
				button = Me._arrow_btnAdvanceExp_sml
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000187 RID: 391
		' (get) Token: 0x06000412 RID: 1042 RVA: 0x00027037 File Offset: 0x00025237
		' (set) Token: 0x06000413 RID: 1043 RVA: 0x00027041 File Offset: 0x00025241
		Friend Overridable Property grpListButton As GroupBox

		' Token: 0x17000188 RID: 392
		' (get) Token: 0x06000414 RID: 1044 RVA: 0x0002704A File Offset: 0x0002524A
		' (set) Token: 0x06000415 RID: 1045 RVA: 0x00027054 File Offset: 0x00025254
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x17000189 RID: 393
		' (get) Token: 0x06000416 RID: 1046 RVA: 0x0002705D File Offset: 0x0002525D
		' (set) Token: 0x06000417 RID: 1047 RVA: 0x00027068 File Offset: 0x00025268
		Friend Overridable Property btnSearch As Button
			<CompilerGenerated()>
			Get
				Return Me._btnSearch
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnSearch_Click
				Dim button As Button = Me._btnSearch
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnSearch = value
				button = Me._btnSearch
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700018A RID: 394
		' (get) Token: 0x06000418 RID: 1048 RVA: 0x000270AB File Offset: 0x000252AB
		' (set) Token: 0x06000419 RID: 1049 RVA: 0x000270B8 File Offset: 0x000252B8
		Friend Overridable Property btnClearList As Button
			<CompilerGenerated()>
			Get
				Return Me._btnClearList
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnClearList_Click
				Dim button As Button = Me._btnClearList
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnClearList = value
				button = Me._btnClearList
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700018B RID: 395
		' (get) Token: 0x0600041A RID: 1050 RVA: 0x000270FB File Offset: 0x000252FB
		' (set) Token: 0x0600041B RID: 1051 RVA: 0x00027108 File Offset: 0x00025308
		Friend Overridable Property btnExport As Button
			<CompilerGenerated()>
			Get
				Return Me._btnExport
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnExport_Click
				Dim button As Button = Me._btnExport
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnExport = value
				button = Me._btnExport
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700018C RID: 396
		' (get) Token: 0x0600041C RID: 1052 RVA: 0x0002714B File Offset: 0x0002534B
		' (set) Token: 0x0600041D RID: 1053 RVA: 0x00027155 File Offset: 0x00025355
		Friend Overridable Property lblRows As Label

		' Token: 0x1700018D RID: 397
		' (get) Token: 0x0600041E RID: 1054 RVA: 0x0002715E File Offset: 0x0002535E
		' (set) Token: 0x0600041F RID: 1055 RVA: 0x00027168 File Offset: 0x00025368
		Friend Overridable Property dgvList As DataGridView

		' Token: 0x06000420 RID: 1056 RVA: 0x00027174 File Offset: 0x00025374
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.InitializeComponent()
			Me.pnlBasicDefaultHeight = Me.GbBasic.Height
			Me.pnlBasicSetHeight = 24
			Me.pnlAdvDefaultHeight = 24
			Me.pnlAdvSetHeight = Me.GbAdvanced.Height
		End Sub

		' Token: 0x06000421 RID: 1057 RVA: 0x000271E8 File Offset: 0x000253E8
		Private Sub SetSearchPanel()
			Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
			Me.GbBasic.Height = Me.pnlBasicDefaultHeight
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
		End Sub

		' Token: 0x06000422 RID: 1058 RVA: 0x0002723C File Offset: 0x0002543C
		Private Sub skip_btnBasicExp_sml_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.GbBasic.Height = Me.pnlBasicDefaultHeight
			If flag Then
				Me.GbBasic.Height = Me.pnlBasicSetHeight
				Me.arrow_btnBasicExp_sml.Tag = "ArrowDown"
			Else
				Me.GbBasic.Height = Me.pnlBasicDefaultHeight
				Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			End If
		End Sub

		' Token: 0x06000423 RID: 1059 RVA: 0x000272AC File Offset: 0x000254AC
		Private Sub skip_btnAdvanceExp_sml_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
			If flag Then
				Me.GbAdvanced.Height = Me.pnlAdvSetHeight
				Me.arrow_btnAdvanceExp_sml.Tag = "ArrowUp"
			Else
				Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
				Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
			End If
		End Sub

		' Token: 0x06000424 RID: 1060 RVA: 0x0002731C File Offset: 0x0002551C
		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x06000425 RID: 1061 RVA: 0x00027351 File Offset: 0x00025551
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Me.SetSearchPanel()
			Designing.SetTheme(Me)
			Me.FillCombo()
			Me.ClearList()
			Me.SetForm()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x06000426 RID: 1062 RVA: 0x00027390 File Offset: 0x00025590
		Private Sub FillCombo()
		End Sub

		' Token: 0x06000427 RID: 1063 RVA: 0x0002739E File Offset: 0x0002559E
		Private Sub SetForm()
			Me.SearchData()
		End Sub

		' Token: 0x06000428 RID: 1064 RVA: 0x000273A8 File Offset: 0x000255A8
		Private Sub ClearList()
			Me.lblDate.SelectedIndex = 0
			Me.lblCreated.SelectedIndex = 0
			Me.txtNo.Text = ""
			Me.txtCreated.Text = ""
			Me.cmbStatus.SelectedIndex = 0
			Me.dtpFrom.Value = DateAndTime.Now
			Me.dtpTo.Value = DateAndTime.Now
			Me.dtpFrom.Checked = False
			Me.dtpTo.Checked = False
			Me.lblRows.Text = "0 - Rows"
			Me.txtCode.Text = ""
			Me.txtName.Text = ""
			Me.dgvList.DataSource = Nothing
		End Sub

		' Token: 0x06000429 RID: 1065 RVA: 0x0002747B File Offset: 0x0002567B
		Private Sub btnClearList_Click(sender As Object, e As EventArgs)
			Me.ClearList()
		End Sub

		' Token: 0x0600042A RID: 1066 RVA: 0x00027485 File Offset: 0x00025685
		Private Sub btnExport_Click(sender As Object, e As EventArgs)
			MainModule.ExportToExcel(Me.dgvList, Me.Text)
		End Sub

		' Token: 0x0600042B RID: 1067 RVA: 0x0002749C File Offset: 0x0002569C
		Private Sub btnSearch_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SearchData()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x0600042C RID: 1068 RVA: 0x00027508 File Offset: 0x00025708
		Private Sub SearchData()
			Dim text As String = ""
			Dim text2 As String = " SELECT P.PRID AS ID, P.Status, P.ApprovalLevel, P.PRNo, P.PRDt, P.RequestedBy RequestedByID,  " & vbCrLf
			text2 += " Req.UserName AS RequestedBy, Req.EmailID ReqEmailID, P.Department, " & vbCrLf
			text2 += " PI.ProductID, PI.ProductType, PI.ProductCode, PI.ProductName, Pr.TertiaryUOM, PI.TertiaryPackSize, PI.Quantity,  " & vbCrLf
			text2 += " Action.UserName AS ActionBy, P.ActionDt,  " & vbCrLf
			text2 += " Created.EmailID AS CreatedByEmailID, Modified.EmailID AS ModifiedByEmailID,  " & vbCrLf
			text2 += " P.CreationDt, Created.UserName AS CreatedBy, P.ModificationDt, Modified.UserName AS ModifiedBy " & vbCrLf
			text2 += " FROM PR AS P  " & vbCrLf
			text2 += " INNER JOIN PRItems PI ON P.PRID = PI.PRID  " & vbCrLf
			text2 += " LEFT OUTER JOIN Vendor AS V ON P.VendorID = V.VendorID  " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Action ON P.ActionBy = Action.UserID  " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Req ON P.RequestedBy = Req.UserID  " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Can ON P.CancelledBy = Can.UserID " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Created ON P.CreatedBy = Created.UserID  " & vbCrLf
			text2 += " LEFT OUTER JOIN [User] AS Modified ON P.ModifiedBy = Modified.UserID " & vbCrLf
			text2 += " LEFT OUTER JOIN Product Pr ON Pr.ProductID = PI.ProductID  " & vbCrLf
			text2 += " WHERE 1=1 AND PI.ProductID = '0' " & vbCrLf
			text2 += " AND P.Status IN ('Cost Approved')"
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.txtNo.Text), "", False) <> 0
			If flag Then
				text2 = text2 + " AND (PRNo LIKE '%" + Strings.Trim(Me.txtNo.Text) + "%')" & vbCrLf
				text = text + "PRNo LIKE " + Strings.Trim(Me.txtNo.Text) + vbCrLf
			End If
			Dim flag2 As Boolean = Me.cmbStatus.SelectedIndex > 0
			If flag2 Then
				text2 = text2 + " AND (P.Status = '" + Me.cmbStatus.Text + "')" & vbCrLf
				text = text + ("P.Status = " + Me.cmbStatus.Text) + vbCrLf
			End If
			Dim flag3 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCreated.Text), "", False) <> 0
			If flag3 Then
				Dim flag4 As Boolean = Me.lblCreated.SelectedIndex >= 0
				If flag4 Then
					Dim text3 As String = Me.lblCreated.Text
					Dim text4 As String
					If Operators.CompareString(text3, "Requested By", False) <> 0 Then
						If Operators.CompareString(text3, "Created By", False) <> 0 Then
							If Operators.CompareString(text3, "Last Modified By", False) = 0 Then
								text4 = "Modified"
							End If
						Else
							text4 = "Created"
						End If
					Else
						text4 = "Req"
					End If
					text2 = String.Concat(New String() { text2, " AND ", text4, ".UserName LIKE '%", Strings.Trim(Me.txtCreated.Text), "%'" })
					text = text + (text4 + "By LIKE " + Strings.Trim(Me.txtCreated.Text)) + vbCrLf
				End If
			End If
			Dim flag5 As Boolean = Me.lblDate.SelectedIndex >= 0
			If flag5 Then
				Dim text5 As String = Me.lblDate.Text
				Dim text6 As String
				If Operators.CompareString(text5, "Creation", False) <> 0 Then
					If Operators.CompareString(text5, "Last Modification", False) <> 0 Then
						If Operators.CompareString(text5, "P.R. Date", False) <> 0 Then
							If Operators.CompareString(text5, "Required By Date", False) <> 0 Then
								text6 = ""
							Else
								text6 = "RequiredByDt"
							End If
						Else
							text6 = "PRDt"
						End If
					Else
						text6 = "ModificationDt"
					End If
				Else
					text6 = "CreationDt"
				End If
				Dim flag6 As Boolean = Operators.CompareString(text6, "", False) <> 0
				If flag6 Then
					Dim flag7 As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
					If flag7 Then
						text2 = String.Concat(New String() { text2, " AND ", text6, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
						text = text + String.Concat(New String() { text6, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
					Else
						Dim checked As Boolean = Me.dtpFrom.Checked
						If checked Then
							text2 = String.Concat(New String() { text2, " AND ", text6, " BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59"), "'" })
							text = text + String.Concat(New String() { text6, " BETWEEN  ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
						End If
						Dim checked2 As Boolean = Me.dtpTo.Checked
						If checked2 Then
							text2 = String.Concat(New String() { text2, " AND ", text6, " BETWEEN '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" })
							text = text + String.Concat(New String() { text6, " BETWEEN  ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), " AND ", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59") }) + vbCrLf
						End If
					End If
				End If
			End If
			text2 += " ORDER BY PRDt" & vbCrLf
			Dim data As DataTable = MainModule.GetData(text2)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = Nothing
			Me.dgvList.DataSource = data
			Me.dgvList.Columns("ID").Visible = False
			Me.dgvList.Columns("ProductID").Visible = False
			Me.dgvList.Columns("RequestedByID").Visible = False
			Me.dgvList.Columns("ReqEmailID").Visible = False
			Me.dgvList.Columns("CreatedByEmailID").Visible = False
			Me.dgvList.Columns("ModifiedByEmailID").Visible = False
			Me.dgvList.Columns("PRNo").HeaderText = "PR No."
			Me.dgvList.Columns("PRDt").HeaderText = "PR Date"
			Me.dgvList.Columns("RequestedBy").HeaderText = "Requested By"
			Me.dgvList.Columns("ActionBy").HeaderText = "Action By"
			Me.dgvList.Columns("ActionDt").HeaderText = "Action Date"
			Me.dgvList.Columns("Status").HeaderText = "Status"
			Me.dgvList.Columns("CreationDt").HeaderText = "Creation Date"
			Me.dgvList.Columns("CreatedBy").HeaderText = "Created By"
			Me.dgvList.Columns("ModificationDt").HeaderText = "Modification Date"
			Me.dgvList.Columns("ModifiedBy").HeaderText = "Modified By"
			Me.dgvList.Columns("PRDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("ActionDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
			Me.dgvList.Columns("CreationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			Me.dgvList.Columns("ModificationDt").DefaultCellStyle.Format = "dd-MMM-yyyy hh:mm:ss tt"
			Me.dgvList.Columns("PRNo").Width = 130
			Me.dgvList.Columns("PRDt").Width = 120
			Me.dgvList.Columns("RequestedBy").Width = 130
			Me.dgvList.Columns("ActionBy").Width = 130
			Me.dgvList.Columns("ActionDt").Width = 120
			Me.dgvList.Columns("Status").Width = 132
			Me.dgvList.Columns("CreationDt").Width = 170
			Me.dgvList.Columns("CreatedBy").Width = 140
			Me.dgvList.Columns("ModificationDt").Width = 170
			Me.dgvList.Columns("ModifiedBy").Width = 140
			Dim flag8 As Boolean = data.Columns.Contains("ProductCode")
			If flag8 Then
				Me.dgvList.Columns("ProductCode").HeaderText = "Product Code"
				Me.dgvList.Columns("ProductName").HeaderText = "Product Name"
				Me.dgvList.Columns("ProductType").HeaderText = "Product Type"
				Me.dgvList.Columns("TertiaryUOM").HeaderText = "Tertiary UOM"
				Me.dgvList.Columns("TertiaryPackSize").HeaderText = "Tertiary PackSize"
				Me.dgvList.Columns("Quantity").HeaderText = "Tertiary Qty."
				Me.dgvList.Columns("ProductCode").Width = 180
				Me.dgvList.Columns("ProductName").Width = 300
				Me.dgvList.Columns("ProductType").Width = 110
				Me.dgvList.Columns("TertiaryUOM").Width = 90
				Me.dgvList.Columns("TertiaryPackSize").Width = 72
				Me.dgvList.Columns("Quantity").Width = 60
				Me.dgvList.Columns("TertiaryPackSize").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("Quantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Dim flag9 As Boolean = data.Columns.Contains("ReceivedQty")
				If flag9 Then
					Me.dgvList.Columns("ReceivedQty").HeaderText = "Received Qty."
					Me.dgvList.Columns("BalanceQty").HeaderText = "Balance Qty."
					Me.dgvList.Columns("ReceivedQty").Width = 65
					Me.dgvList.Columns("BalanceQty").Width = 60
					Me.dgvList.Columns("ReceivedQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
					Me.dgvList.Columns("BalanceQty").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				End If
			End If
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x040001BA RID: 442
		Private pnlBasicDefaultHeight As Integer

		' Token: 0x040001BB RID: 443
		Private pnlBasicSetHeight As Integer

		' Token: 0x040001BC RID: 444
		Private pnlAdvDefaultHeight As Integer

		' Token: 0x040001BD RID: 445
		Private pnlAdvSetHeight As Integer
	End Class
End Namespace
