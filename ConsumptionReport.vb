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
	' Token: 0x02000015 RID: 21
	<DesignerGenerated()>
	Public Partial Class ConsumptionReport
		Inherits DockContent

		' Token: 0x17000112 RID: 274
		' (get) Token: 0x060002F6 RID: 758 RVA: 0x0001DA04 File Offset: 0x0001BC04
		' (set) Token: 0x060002F7 RID: 759 RVA: 0x0001DA0E File Offset: 0x0001BC0E
		Friend Overridable Property GbBasic As GroupBox

		' Token: 0x17000113 RID: 275
		' (get) Token: 0x060002F8 RID: 760 RVA: 0x0001DA17 File Offset: 0x0001BC17
		' (set) Token: 0x060002F9 RID: 761 RVA: 0x0001DA21 File Offset: 0x0001BC21
		Friend Overridable Property cmbDepartment As ComboBox

		' Token: 0x17000114 RID: 276
		' (get) Token: 0x060002FA RID: 762 RVA: 0x0001DA2A File Offset: 0x0001BC2A
		' (set) Token: 0x060002FB RID: 763 RVA: 0x0001DA34 File Offset: 0x0001BC34
		Friend Overridable Property lblDepartment As Label

		' Token: 0x17000115 RID: 277
		' (get) Token: 0x060002FC RID: 764 RVA: 0x0001DA3D File Offset: 0x0001BC3D
		' (set) Token: 0x060002FD RID: 765 RVA: 0x0001DA47 File Offset: 0x0001BC47
		Friend Overridable Property cmbItemGroup As ComboBox

		' Token: 0x17000116 RID: 278
		' (get) Token: 0x060002FE RID: 766 RVA: 0x0001DA50 File Offset: 0x0001BC50
		' (set) Token: 0x060002FF RID: 767 RVA: 0x0001DA5A File Offset: 0x0001BC5A
		Friend Overridable Property Label9 As Label

		' Token: 0x17000117 RID: 279
		' (get) Token: 0x06000300 RID: 768 RVA: 0x0001DA63 File Offset: 0x0001BC63
		' (set) Token: 0x06000301 RID: 769 RVA: 0x0001DA6D File Offset: 0x0001BC6D
		Friend Overridable Property Label1 As Label

		' Token: 0x17000118 RID: 280
		' (get) Token: 0x06000302 RID: 770 RVA: 0x0001DA76 File Offset: 0x0001BC76
		' (set) Token: 0x06000303 RID: 771 RVA: 0x0001DA80 File Offset: 0x0001BC80
		Friend Overridable Property dtpTo As DateTimePicker

		' Token: 0x17000119 RID: 281
		' (get) Token: 0x06000304 RID: 772 RVA: 0x0001DA89 File Offset: 0x0001BC89
		' (set) Token: 0x06000305 RID: 773 RVA: 0x0001DA93 File Offset: 0x0001BC93
		Friend Overridable Property Label16 As Label

		' Token: 0x1700011A RID: 282
		' (get) Token: 0x06000306 RID: 774 RVA: 0x0001DA9C File Offset: 0x0001BC9C
		' (set) Token: 0x06000307 RID: 775 RVA: 0x0001DAA6 File Offset: 0x0001BCA6
		Friend Overridable Property dtpFrom As DateTimePicker

		' Token: 0x1700011B RID: 283
		' (get) Token: 0x06000308 RID: 776 RVA: 0x0001DAAF File Offset: 0x0001BCAF
		' (set) Token: 0x06000309 RID: 777 RVA: 0x0001DABC File Offset: 0x0001BCBC
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

		' Token: 0x1700011C RID: 284
		' (get) Token: 0x0600030A RID: 778 RVA: 0x0001DAFF File Offset: 0x0001BCFF
		' (set) Token: 0x0600030B RID: 779 RVA: 0x0001DB09 File Offset: 0x0001BD09
		Friend Overridable Property GbAdvanced As GroupBox

		' Token: 0x1700011D RID: 285
		' (get) Token: 0x0600030C RID: 780 RVA: 0x0001DB12 File Offset: 0x0001BD12
		' (set) Token: 0x0600030D RID: 781 RVA: 0x0001DB1C File Offset: 0x0001BD1C
		Friend Overridable Property Label3 As Label

		' Token: 0x1700011E RID: 286
		' (get) Token: 0x0600030E RID: 782 RVA: 0x0001DB25 File Offset: 0x0001BD25
		' (set) Token: 0x0600030F RID: 783 RVA: 0x0001DB2F File Offset: 0x0001BD2F
		Friend Overridable Property txtLotNo As TextBox

		' Token: 0x1700011F RID: 287
		' (get) Token: 0x06000310 RID: 784 RVA: 0x0001DB38 File Offset: 0x0001BD38
		' (set) Token: 0x06000311 RID: 785 RVA: 0x0001DB42 File Offset: 0x0001BD42
		Friend Overridable Property txtMaterialName As TextBox

		' Token: 0x17000120 RID: 288
		' (get) Token: 0x06000312 RID: 786 RVA: 0x0001DB4B File Offset: 0x0001BD4B
		' (set) Token: 0x06000313 RID: 787 RVA: 0x0001DB55 File Offset: 0x0001BD55
		Friend Overridable Property Label4 As Label

		' Token: 0x17000121 RID: 289
		' (get) Token: 0x06000314 RID: 788 RVA: 0x0001DB5E File Offset: 0x0001BD5E
		' (set) Token: 0x06000315 RID: 789 RVA: 0x0001DB68 File Offset: 0x0001BD68
		Friend Overridable Property Label5 As Label

		' Token: 0x17000122 RID: 290
		' (get) Token: 0x06000316 RID: 790 RVA: 0x0001DB71 File Offset: 0x0001BD71
		' (set) Token: 0x06000317 RID: 791 RVA: 0x0001DB7B File Offset: 0x0001BD7B
		Friend Overridable Property txtMaterialCode As TextBox

		' Token: 0x17000123 RID: 291
		' (get) Token: 0x06000318 RID: 792 RVA: 0x0001DB84 File Offset: 0x0001BD84
		' (set) Token: 0x06000319 RID: 793 RVA: 0x0001DB8E File Offset: 0x0001BD8E
		Friend Overridable Property Label2 As Label

		' Token: 0x17000124 RID: 292
		' (get) Token: 0x0600031A RID: 794 RVA: 0x0001DB97 File Offset: 0x0001BD97
		' (set) Token: 0x0600031B RID: 795 RVA: 0x0001DBA1 File Offset: 0x0001BDA1
		Friend Overridable Property txtBatchNo As TextBox

		' Token: 0x17000125 RID: 293
		' (get) Token: 0x0600031C RID: 796 RVA: 0x0001DBAA File Offset: 0x0001BDAA
		' (set) Token: 0x0600031D RID: 797 RVA: 0x0001DBB4 File Offset: 0x0001BDB4
		Friend Overridable Property txtCatalogNo As TextBox

		' Token: 0x17000126 RID: 294
		' (get) Token: 0x0600031E RID: 798 RVA: 0x0001DBBD File Offset: 0x0001BDBD
		' (set) Token: 0x0600031F RID: 799 RVA: 0x0001DBC7 File Offset: 0x0001BDC7
		Friend Overridable Property Label6 As Label

		' Token: 0x17000127 RID: 295
		' (get) Token: 0x06000320 RID: 800 RVA: 0x0001DBD0 File Offset: 0x0001BDD0
		' (set) Token: 0x06000321 RID: 801 RVA: 0x0001DBDA File Offset: 0x0001BDDA
		Friend Overridable Property txtName As TextBox

		' Token: 0x17000128 RID: 296
		' (get) Token: 0x06000322 RID: 802 RVA: 0x0001DBE3 File Offset: 0x0001BDE3
		' (set) Token: 0x06000323 RID: 803 RVA: 0x0001DBED File Offset: 0x0001BDED
		Friend Overridable Property Label7 As Label

		' Token: 0x17000129 RID: 297
		' (get) Token: 0x06000324 RID: 804 RVA: 0x0001DBF6 File Offset: 0x0001BDF6
		' (set) Token: 0x06000325 RID: 805 RVA: 0x0001DC00 File Offset: 0x0001BE00
		Friend Overridable Property Label14 As Label

		' Token: 0x1700012A RID: 298
		' (get) Token: 0x06000326 RID: 806 RVA: 0x0001DC09 File Offset: 0x0001BE09
		' (set) Token: 0x06000327 RID: 807 RVA: 0x0001DC14 File Offset: 0x0001BE14
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

		' Token: 0x1700012B RID: 299
		' (get) Token: 0x06000328 RID: 808 RVA: 0x0001DC57 File Offset: 0x0001BE57
		' (set) Token: 0x06000329 RID: 809 RVA: 0x0001DC61 File Offset: 0x0001BE61
		Friend Overridable Property txtCode As TextBox

		' Token: 0x1700012C RID: 300
		' (get) Token: 0x0600032A RID: 810 RVA: 0x0001DC6A File Offset: 0x0001BE6A
		' (set) Token: 0x0600032B RID: 811 RVA: 0x0001DC74 File Offset: 0x0001BE74
		Friend Overridable Property grpListButton As GroupBox

		' Token: 0x1700012D RID: 301
		' (get) Token: 0x0600032C RID: 812 RVA: 0x0001DC7D File Offset: 0x0001BE7D
		' (set) Token: 0x0600032D RID: 813 RVA: 0x0001DC87 File Offset: 0x0001BE87
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x1700012E RID: 302
		' (get) Token: 0x0600032E RID: 814 RVA: 0x0001DC90 File Offset: 0x0001BE90
		' (set) Token: 0x0600032F RID: 815 RVA: 0x0001DC9C File Offset: 0x0001BE9C
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

		' Token: 0x1700012F RID: 303
		' (get) Token: 0x06000330 RID: 816 RVA: 0x0001DCDF File Offset: 0x0001BEDF
		' (set) Token: 0x06000331 RID: 817 RVA: 0x0001DCEC File Offset: 0x0001BEEC
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

		' Token: 0x17000130 RID: 304
		' (get) Token: 0x06000332 RID: 818 RVA: 0x0001DD2F File Offset: 0x0001BF2F
		' (set) Token: 0x06000333 RID: 819 RVA: 0x0001DD3C File Offset: 0x0001BF3C
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

		' Token: 0x17000131 RID: 305
		' (get) Token: 0x06000334 RID: 820 RVA: 0x0001DD7F File Offset: 0x0001BF7F
		' (set) Token: 0x06000335 RID: 821 RVA: 0x0001DD89 File Offset: 0x0001BF89
		Friend Overridable Property lblRows As Label

		' Token: 0x17000132 RID: 306
		' (get) Token: 0x06000336 RID: 822 RVA: 0x0001DD92 File Offset: 0x0001BF92
		' (set) Token: 0x06000337 RID: 823 RVA: 0x0001DD9C File Offset: 0x0001BF9C
		Friend Overridable Property dgvList As DataGridView

		' Token: 0x17000133 RID: 307
		' (get) Token: 0x06000338 RID: 824 RVA: 0x0001DDA5 File Offset: 0x0001BFA5
		' (set) Token: 0x06000339 RID: 825 RVA: 0x0001DDAF File Offset: 0x0001BFAF
		Friend Overridable Property cmbReportType As ComboBox

		' Token: 0x17000134 RID: 308
		' (get) Token: 0x0600033A RID: 826 RVA: 0x0001DDB8 File Offset: 0x0001BFB8
		' (set) Token: 0x0600033B RID: 827 RVA: 0x0001DDC2 File Offset: 0x0001BFC2
		Friend Overridable Property Label8 As Label

		' Token: 0x0600033C RID: 828 RVA: 0x0001DDCC File Offset: 0x0001BFCC
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Me_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Me_Load
			Me.InitializeComponent()
			Me.pnlBasicDefaultHeight = Me.GbBasic.Height
			Me.pnlBasicSetHeight = 23
			Me.pnlAdvDefaultHeight = 23
			Me.pnlAdvSetHeight = Me.GbAdvanced.Height
		End Sub

		' Token: 0x0600033D RID: 829 RVA: 0x0001DE40 File Offset: 0x0001C040
		Private Sub SetSearchPanel()
			Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
			Me.GbBasic.Height = Me.pnlBasicDefaultHeight
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
		End Sub

		' Token: 0x0600033E RID: 830 RVA: 0x0001DE94 File Offset: 0x0001C094
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

		' Token: 0x0600033F RID: 831 RVA: 0x0001DF04 File Offset: 0x0001C104
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

		' Token: 0x06000340 RID: 832 RVA: 0x0001DF74 File Offset: 0x0001C174
		Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = MainModule.TrnLog(Me.Text, "Closed", "", Nothing)
			If Not flag Then
				e.Cancel = True
			End If
		End Sub

		' Token: 0x06000341 RID: 833 RVA: 0x0001DFA9 File Offset: 0x0001C1A9
		Private Sub Me_Load(sender As Object, e As EventArgs)
			Me.SetSearchPanel()
			Designing.SetTheme(Me)
			Me.FillCombo()
			Me.ClearList()
			MainModule.TrnLog(Me.Text, "Opened", "", Nothing)
		End Sub

		' Token: 0x06000342 RID: 834 RVA: 0x0001DFE0 File Offset: 0x0001C1E0
		Private Sub FillCombo()
			Dim text As String = "SELECT DISTINCT ItemGroup FROM Product ORDER BY ItemGroup"
			Dim data As DataTable = MainModule.GetData(text)
			Me.cmbItemGroup.ValueMember = "ItemGroup"
			Me.cmbItemGroup.DisplayMember = "ItemGroup"
			Me.cmbItemGroup.DataSource = data
			Me.cmbItemGroup.SelectedIndex = -1
			text = "SELECT DISTINCT Department FROM Request ORDER BY Department"
			Dim data2 As DataTable = MainModule.GetData(text)
			Me.cmbDepartment.ValueMember = "Department"
			Me.cmbDepartment.DisplayMember = "Department"
			Me.cmbDepartment.DataSource = data2
			Me.cmbDepartment.SelectedIndex = -1
		End Sub

		' Token: 0x06000343 RID: 835 RVA: 0x0001E080 File Offset: 0x0001C280
		Private Sub ClearList()
			Me.cmbDepartment.Text = ""
			Me.txtCode.Text = ""
			Me.txtBatchNo.Text = ""
			Me.txtName.Text = ""
			Me.txtMaterialCode.Text = ""
			Me.txtCatalogNo.Text = ""
			Me.txtLotNo.Text = ""
			Me.txtMaterialName.Text = ""
			Me.cmbItemGroup.Text = ""
			Me.cmbReportType.Text = "Product-wise"
			Me.dtpFrom.Value = DateAndTime.Now
			Me.dtpTo.Value = DateAndTime.Now
			Me.dtpFrom.Checked = False
			Me.dtpTo.Checked = False
			Me.lblRows.Text = "0 - Rows"
			Me.dgvList.DataSource = Nothing
		End Sub

		' Token: 0x06000344 RID: 836 RVA: 0x0001E192 File Offset: 0x0001C392
		Private Sub btnClearList_Click(sender As Object, e As EventArgs)
			Me.ClearList()
		End Sub

		' Token: 0x06000345 RID: 837 RVA: 0x0001E19C File Offset: 0x0001C39C
		Private Sub btnExport_Click(sender As Object, e As EventArgs)
			MainModule.ExportToExcel(Me.dgvList, Me.Text)
		End Sub

		' Token: 0x06000346 RID: 838 RVA: 0x0001E1B4 File Offset: 0x0001C3B4
		Private Sub btnSearch_Click(sender As Object, e As EventArgs)
			Cursor.Current = Cursors.WaitCursor
			Try
				Me.SearchData()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
			Cursor.Current = Cursors.[Default]
		End Sub

		' Token: 0x06000347 RID: 839 RVA: 0x0001E220 File Offset: 0x0001C420
		Private Sub SearchData()
			Dim text As String = ""
			Dim text2 As String = Me.cmbReportType.Text
			Dim text3 As String
			If Operators.CompareString(text2, "Product-wise", False) <> 0 Then
				If Operators.CompareString(text2, "Batch-wise", False) = 0 Then
					text3 = " SELECT R.Department, P.ProductName MfgProductName, R.BatchNo MfgBatchNo, " & vbCrLf
					text3 += " M.ItemGroup, M.ProductCode, M.CatalogNo, M.ProductName Particulars, U.BatchNo LotNo, U.MfgDt,U.ExpDt, P.PrimaryUOM, " & vbCrLf
					text3 += " COUNT(ID.UID) AS Quantity, FORMAT(AVG(U.Price),'#0.00') AS GRNPrice, " & vbCrLf
					text3 += " FORMAT(AVG(AvgPrice),'#0.00') WeightedAvgPrice, FORMAT(COUNT(ID.UID) * AVG(AvgPrice),'#0.00') AS Value" & vbCrLf
					text3 += " FROM Request AS R " & vbCrLf
					text3 += " INNER JOIN Product P ON R.ProductID = P.ProductID " & vbCrLf
					text3 += " INNER JOIN Issue AS I ON R.RequestID = I.RequestID " & vbCrLf
					text3 += " INNER JOIN IssueDtls AS ID ON I.IssueID = ID.IssueID " & vbCrLf
					text3 += " INNER JOIN Product AS M ON ID.ProductID = M.ProductID " & vbCrLf
					text3 += " INNER JOIN GRNUID AS U ON ID.UID = U.UID " & vbCrLf
					text3 += " WHERE 1=1 AND I.Status = 'Issued'" & vbCrLf
				End If
			Else
				text3 = " SELECT R.Department, P.ProductName MfgProductName, R.BatchNo MfgBatchNo, " & vbCrLf
				text3 += " M.ItemGroup, M.ProductCode, M.CatalogNo, M.ProductName Particulars, P.PrimaryUOM, " & vbCrLf
				text3 += " COUNT(ID.UID) AS Quantity, FORMAT(AVG(U.Price),'#0.00') AS GRNPrice, " & vbCrLf
				text3 += " FORMAT(AVG(AvgPrice),'#0.00') WeightedAvgPrice, FORMAT(COUNT(ID.UID) * AVG(AvgPrice),'#0.00') AS Value" & vbCrLf
				text3 += " FROM Request AS R " & vbCrLf
				text3 += " INNER JOIN Product P ON R.ProductID = P.ProductID " & vbCrLf
				text3 += " INNER JOIN Issue AS I ON R.RequestID = I.RequestID " & vbCrLf
				text3 += " INNER JOIN IssueDtls AS ID ON I.IssueID = ID.IssueID " & vbCrLf
				text3 += " INNER JOIN Product AS M ON ID.ProductID = M.ProductID " & vbCrLf
				text3 += " INNER JOIN GRNUID AS U ON ID.UID = U.UID " & vbCrLf
				text3 += " WHERE 1=1 AND I.Status = 'Issued'" & vbCrLf
			End If
			Dim flag As Boolean = Me.dtpFrom.Checked And Me.dtpTo.Checked
			If flag Then
				text3 = String.Concat(New String() { text3, " AND I.IssuedDt BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" & vbCrLf })
				text = text + ("Issue Date BETWEEN  " + Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00") + " AND " + Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59")) + vbCrLf
			Else
				Dim checked As Boolean = Me.dtpFrom.Checked
				If checked Then
					text3 = String.Concat(New String() { text3, " AND I.IssuedDt BETWEEN '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59"), "'" & vbCrLf })
					text = text + ("Issue Date BETWEEN  " + Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 00:00:00") + " AND " + Strings.Format(Me.dtpFrom.Value, "MM/dd/yyyy 23:59:59")) + vbCrLf
				End If
				Dim checked2 As Boolean = Me.dtpTo.Checked
				If checked2 Then
					text3 = String.Concat(New String() { text3, " AND I.IssuedDt BETWEEN '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00"), "' AND '", Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59"), "'" & vbCrLf })
					text = text + ("Issue Date BETWEEN  " + Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 00:00:00") + " AND " + Strings.Format(Me.dtpTo.Value, "MM/dd/yyyy 23:59:59")) + vbCrLf
				End If
			End If
			Dim flag2 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCode.Text), "", False) <> 0
			If flag2 Then
				text3 = text3 + " AND (P.ProductCode LIKE '%" + Strings.Trim(Me.txtCode.Text) + "%') " & vbCrLf
				text = text + "ProductCode LIKE " + Strings.Trim(Me.txtCode.Text) + vbCrLf
			End If
			Dim flag3 As Boolean = Operators.CompareString(Strings.Trim(Me.txtName.Text), "", False) <> 0
			If flag3 Then
				text3 = text3 + " AND (P.ProductName LIKE '%" + Strings.Trim(Me.txtName.Text) + "%') " & vbCrLf
				text = text + "ProductName LIKE " + Strings.Trim(Me.txtName.Text) + vbCrLf
			End If
			Dim flag4 As Boolean = Operators.CompareString(Strings.Trim(Me.txtBatchNo.Text), "", False) <> 0
			If flag4 Then
				text3 = text3 + " AND (R.BatchNo LIKE '%" + Strings.Trim(Me.txtBatchNo.Text) + "%') " & vbCrLf
				text = text + "Mfg. Batch No LIKE " + Strings.Trim(Me.txtBatchNo.Text) + vbCrLf
			End If
			Dim flag5 As Boolean = Operators.CompareString(Strings.Trim(Me.txtCatalogNo.Text), "", False) <> 0
			If flag5 Then
				text3 = text3 + " AND (M.CatalogNo Like '%" + Strings.Trim(Me.txtCatalogNo.Text) + "%') "
				text = text + "Material Catalog No. LIKE " + Strings.Trim(Me.txtCatalogNo.Text) + vbCrLf
			End If
			Dim flag6 As Boolean = Operators.CompareString(Strings.Trim(Me.txtMaterialCode.Text), "", False) <> 0
			If flag6 Then
				text3 = text3 + " AND (M.ProductCode Like '%" + Strings.Trim(Me.txtMaterialCode.Text) + "%') "
				text = text + "Material Code LIKE " + Strings.Trim(Me.txtMaterialCode.Text) + vbCrLf
			End If
			Dim flag7 As Boolean = Operators.CompareString(Strings.Trim(Me.txtMaterialName.Text), "", False) <> 0
			If flag7 Then
				text3 = text3 + " AND (M.ProductName LIKE '%" + Strings.Trim(Me.txtMaterialName.Text) + "%') "
				text = text + "Material Name LIKE " + Strings.Trim(Me.txtMaterialName.Text) + vbCrLf
			End If
			Dim flag8 As Boolean = Operators.CompareString(Me.cmbItemGroup.Text, "", False) <> 0
			If flag8 Then
				text3 = text3 + " AND (M.ItemGroup LIKE '%" + Strings.Trim(Me.cmbItemGroup.Text) + "%') " & vbCrLf
				text = text + "Item Group LIKE " + Strings.Trim(Me.cmbItemGroup.Text) + vbCrLf
			End If
			Dim flag9 As Boolean = Operators.CompareString(Strings.Trim(Me.txtLotNo.Text), "", False) <> 0
			If flag9 Then
				text3 = text3 + " AND (U.BatchNo LIKE '%" + Strings.Trim(Me.txtLotNo.Text) + "%') "
				text = text + "Lot No LIKE " + Strings.Trim(Me.txtLotNo.Text) + vbCrLf
			End If
			Dim text4 As String = Me.cmbReportType.Text
			If Operators.CompareString(text4, "Product-wise", False) <> 0 Then
				If Operators.CompareString(text4, "Batch-wise", False) = 0 Then
					text3 += " GROUP BY R.Department, P.ProductName, R.BatchNo, " & vbCrLf
					text3 += " M.ItemGroup, M.ProductCode, M.CatalogNo, M.ProductName, U.BatchNo, U.MfgDt,U.ExpDt, P.PrimaryUOM" & vbCrLf
				End If
			Else
				text3 += " GROUP BY R.Department, P.ProductName, R.BatchNo, " & vbCrLf
				text3 += " M.ItemGroup, M.ProductCode, M.CatalogNo, M.ProductName, P.PrimaryUOM" & vbCrLf
			End If
			Dim data As DataTable = MainModule.GetData(text3)
			text = text + "No. Of Row(s) = " + Conversions.ToString(data.Rows.Count)
			Me.lblRows.Text = Conversions.ToString(data.Rows.Count) + " - Rows"
			Me.dgvList.DataSource = Nothing
			Me.dgvList.DataSource = data
			Me.dgvList.Columns("CatalogNo").Visible = False
			Me.dgvList.Columns("Department").HeaderText = "Department"
			Me.dgvList.Columns("MfgProductName").HeaderText = "Mfg. Product Name"
			Me.dgvList.Columns("MfgBatchNo").HeaderText = "Mfg. Batch No."
			Me.dgvList.Columns("ItemGroup").HeaderText = "Material Item Group"
			Me.dgvList.Columns("ProductCode").HeaderText = "Product Code"
			Me.dgvList.Columns("CatalogNo").HeaderText = "Catalog No."
			Me.dgvList.Columns("Particulars").HeaderText = "Particulars"
			Me.dgvList.Columns("PrimaryUOM").HeaderText = "Primary UOM"
			Me.dgvList.Columns("Department").Width = 100
			Me.dgvList.Columns("MfgProductName").Width = 300
			Me.dgvList.Columns("MfgBatchNo").Width = 100
			Me.dgvList.Columns("ItemGroup").Width = 130
			Me.dgvList.Columns("ProductCode").Width = 140
			Me.dgvList.Columns("Particulars").Width = 380
			Me.dgvList.Columns("PrimaryUOM").Width = 100
			Dim flag10 As Boolean = Me.dgvList.Columns.Contains("LotNo")
			If flag10 Then
				Me.dgvList.Columns("LotNo").HeaderText = "Lot No."
				Me.dgvList.Columns("LotNo").Width = 100
			End If
			Dim flag11 As Boolean = Me.dgvList.Columns.Contains("MfgDt")
			If flag11 Then
				Me.dgvList.Columns("MfgDt").HeaderText = "Mfg. Date"
				Me.dgvList.Columns("MfgDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
				Me.dgvList.Columns("MfgDt").Width = 120
			End If
			Dim flag12 As Boolean = Me.dgvList.Columns.Contains("ExpDt")
			If flag12 Then
				Me.dgvList.Columns("ExpDt").HeaderText = "Expiry Date"
				Me.dgvList.Columns("ExpDt").DefaultCellStyle.Format = "dd-MMM-yyyy"
				Me.dgvList.Columns("ExpDt").Width = 120
			End If
			Dim flag13 As Boolean = Me.dgvList.Columns.Contains("Quantity")
			If flag13 Then
				Dim flag14 As Boolean = Operators.CompareString(Me.cmbReportType.Text, "Product-wise", False) = 0
				If flag14 Then
					Me.dgvList.Columns("GRNPrice").Visible = False
				End If
				Me.dgvList.Columns("Quantity").HeaderText = "Quantity"
				Me.dgvList.Columns("GRNPrice").HeaderText = "Batch Avg. Price"
				Me.dgvList.Columns("WeightedAvgPrice").HeaderText = "Weighted Avg. Price"
				Me.dgvList.Columns("Value").HeaderText = "Weighted Avg. Value"
				Me.dgvList.Columns("Quantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("GRNPrice").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("WeightedAvgPrice").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
				Me.dgvList.Columns("Value").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			End If
			MainModule.TrnLog(Me.Text, "Searched", "Search Details: " + text, Nothing)
		End Sub

		' Token: 0x04000150 RID: 336
		Private pnlBasicDefaultHeight As Integer

		' Token: 0x04000151 RID: 337
		Private pnlBasicSetHeight As Integer

		' Token: 0x04000152 RID: 338
		Private pnlAdvDefaultHeight As Integer

		' Token: 0x04000153 RID: 339
		Private pnlAdvSetHeight As Integer
	End Class
End Namespace
