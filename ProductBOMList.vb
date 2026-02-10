Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports WeifenLuo.WinFormsUI.Docking

Namespace Datasoft_PIMS
	' Token: 0x02000012 RID: 18
	<DesignerGenerated()>
	Public Partial Class ProductBOMList
		Inherits DockContent

		' Token: 0x170000C5 RID: 197
		' (get) Token: 0x0600023B RID: 571 RVA: 0x000175D5 File Offset: 0x000157D5
		' (set) Token: 0x0600023C RID: 572 RVA: 0x000175DF File Offset: 0x000157DF
		Friend Overridable Property GbBasic As GroupBox

		' Token: 0x170000C6 RID: 198
		' (get) Token: 0x0600023D RID: 573 RVA: 0x000175E8 File Offset: 0x000157E8
		' (set) Token: 0x0600023E RID: 574 RVA: 0x000175F2 File Offset: 0x000157F2
		Friend Overridable Property txtBOMVersion As TextBox

		' Token: 0x170000C7 RID: 199
		' (get) Token: 0x0600023F RID: 575 RVA: 0x000175FB File Offset: 0x000157FB
		' (set) Token: 0x06000240 RID: 576 RVA: 0x00017605 File Offset: 0x00015805
		Friend Overridable Property Label1 As Label

		' Token: 0x170000C8 RID: 200
		' (get) Token: 0x06000241 RID: 577 RVA: 0x0001760E File Offset: 0x0001580E
		' (set) Token: 0x06000242 RID: 578 RVA: 0x00017618 File Offset: 0x00015818
		Friend Overridable Property txtSCatalogNo As TextBox

		' Token: 0x170000C9 RID: 201
		' (get) Token: 0x06000243 RID: 579 RVA: 0x00017621 File Offset: 0x00015821
		' (set) Token: 0x06000244 RID: 580 RVA: 0x0001762B File Offset: 0x0001582B
		Friend Overridable Property Label37 As Label

		' Token: 0x170000CA RID: 202
		' (get) Token: 0x06000245 RID: 581 RVA: 0x00017634 File Offset: 0x00015834
		' (set) Token: 0x06000246 RID: 582 RVA: 0x0001763E File Offset: 0x0001583E
		Friend Overridable Property txtSName As TextBox

		' Token: 0x170000CB RID: 203
		' (get) Token: 0x06000247 RID: 583 RVA: 0x00017647 File Offset: 0x00015847
		' (set) Token: 0x06000248 RID: 584 RVA: 0x00017651 File Offset: 0x00015851
		Friend Overridable Property Label11 As Label

		' Token: 0x170000CC RID: 204
		' (get) Token: 0x06000249 RID: 585 RVA: 0x0001765A File Offset: 0x0001585A
		' (set) Token: 0x0600024A RID: 586 RVA: 0x00017664 File Offset: 0x00015864
		Friend Overridable Property txtSCode As TextBox

		' Token: 0x170000CD RID: 205
		' (get) Token: 0x0600024B RID: 587 RVA: 0x0001766D File Offset: 0x0001586D
		' (set) Token: 0x0600024C RID: 588 RVA: 0x00017677 File Offset: 0x00015877
		Friend Overridable Property Label14 As Label

		' Token: 0x170000CE RID: 206
		' (get) Token: 0x0600024D RID: 589 RVA: 0x00017680 File Offset: 0x00015880
		' (set) Token: 0x0600024E RID: 590 RVA: 0x0001768C File Offset: 0x0001588C
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

		' Token: 0x170000CF RID: 207
		' (get) Token: 0x0600024F RID: 591 RVA: 0x000176CF File Offset: 0x000158CF
		' (set) Token: 0x06000250 RID: 592 RVA: 0x000176D9 File Offset: 0x000158D9
		Friend Overridable Property GbAdvanced As GroupBox

		' Token: 0x170000D0 RID: 208
		' (get) Token: 0x06000251 RID: 593 RVA: 0x000176E2 File Offset: 0x000158E2
		' (set) Token: 0x06000252 RID: 594 RVA: 0x000176EC File Offset: 0x000158EC
		Friend Overridable Property txtSCreated As TextBox

		' Token: 0x170000D1 RID: 209
		' (get) Token: 0x06000253 RID: 595 RVA: 0x000176F5 File Offset: 0x000158F5
		' (set) Token: 0x06000254 RID: 596 RVA: 0x000176FF File Offset: 0x000158FF
		Friend Overridable Property lblSCreated As ComboBox

		' Token: 0x170000D2 RID: 210
		' (get) Token: 0x06000255 RID: 597 RVA: 0x00017708 File Offset: 0x00015908
		' (set) Token: 0x06000256 RID: 598 RVA: 0x00017712 File Offset: 0x00015912
		Friend Overridable Property dtpFrom As DateTimePicker

		' Token: 0x170000D3 RID: 211
		' (get) Token: 0x06000257 RID: 599 RVA: 0x0001771B File Offset: 0x0001591B
		' (set) Token: 0x06000258 RID: 600 RVA: 0x00017725 File Offset: 0x00015925
		Friend Overridable Property dtpTo As DateTimePicker

		' Token: 0x170000D4 RID: 212
		' (get) Token: 0x06000259 RID: 601 RVA: 0x0001772E File Offset: 0x0001592E
		' (set) Token: 0x0600025A RID: 602 RVA: 0x00017738 File Offset: 0x00015938
		Friend Overridable Property Label16 As Label

		' Token: 0x170000D5 RID: 213
		' (get) Token: 0x0600025B RID: 603 RVA: 0x00017741 File Offset: 0x00015941
		' (set) Token: 0x0600025C RID: 604 RVA: 0x0001774B File Offset: 0x0001594B
		Friend Overridable Property lblSDate As ComboBox

		' Token: 0x170000D6 RID: 214
		' (get) Token: 0x0600025D RID: 605 RVA: 0x00017754 File Offset: 0x00015954
		' (set) Token: 0x0600025E RID: 606 RVA: 0x00017760 File Offset: 0x00015960
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

		' Token: 0x170000D7 RID: 215
		' (get) Token: 0x0600025F RID: 607 RVA: 0x000177A3 File Offset: 0x000159A3
		' (set) Token: 0x06000260 RID: 608 RVA: 0x000177AD File Offset: 0x000159AD
		Friend Overridable Property grpListButton As GroupBox

		' Token: 0x170000D8 RID: 216
		' (get) Token: 0x06000261 RID: 609 RVA: 0x000177B6 File Offset: 0x000159B6
		' (set) Token: 0x06000262 RID: 610 RVA: 0x000177C0 File Offset: 0x000159C0
		Friend Overridable Property FlowLayoutPanel1 As FlowLayoutPanel

		' Token: 0x170000D9 RID: 217
		' (get) Token: 0x06000263 RID: 611 RVA: 0x000177C9 File Offset: 0x000159C9
		' (set) Token: 0x06000264 RID: 612 RVA: 0x000177D3 File Offset: 0x000159D3
		Friend Overridable Property btnSearch As Button

		' Token: 0x170000DA RID: 218
		' (get) Token: 0x06000265 RID: 613 RVA: 0x000177DC File Offset: 0x000159DC
		' (set) Token: 0x06000266 RID: 614 RVA: 0x000177E6 File Offset: 0x000159E6
		Friend Overridable Property btnClearList As Button

		' Token: 0x170000DB RID: 219
		' (get) Token: 0x06000267 RID: 615 RVA: 0x000177EF File Offset: 0x000159EF
		' (set) Token: 0x06000268 RID: 616 RVA: 0x000177F9 File Offset: 0x000159F9
		Friend Overridable Property btnExport As Button

		' Token: 0x170000DC RID: 220
		' (get) Token: 0x06000269 RID: 617 RVA: 0x00017802 File Offset: 0x00015A02
		' (set) Token: 0x0600026A RID: 618 RVA: 0x0001780C File Offset: 0x00015A0C
		Friend Overridable Property lblRows As Label

		' Token: 0x170000DD RID: 221
		' (get) Token: 0x0600026B RID: 619 RVA: 0x00017815 File Offset: 0x00015A15
		' (set) Token: 0x0600026C RID: 620 RVA: 0x0001781F File Offset: 0x00015A1F
		Friend Overridable Property dgvList As DataGridView

		' Token: 0x170000DE RID: 222
		' (get) Token: 0x0600026D RID: 621 RVA: 0x00017828 File Offset: 0x00015A28
		' (set) Token: 0x0600026E RID: 622 RVA: 0x00017832 File Offset: 0x00015A32
		Friend Overridable Property btnAdd As Button

		' Token: 0x0600026F RID: 623 RVA: 0x0001783C File Offset: 0x00015A3C
		Public Sub New()
			Me.InitializeComponent()
			Me.pnlBasicDefaultHeight = Me.GbBasic.Height
			Me.pnlBasicSetHeight = 23
			Me.pnlAdvDefaultHeight = 23
			Me.pnlAdvSetHeight = Me.GbAdvanced.Height
			Me.arrow_btnBasicExp_sml.Tag = "ArrowUp"
			Me.arrow_btnAdvanceExp_sml.Tag = "ArrowDown"
		End Sub

		' Token: 0x06000270 RID: 624 RVA: 0x000178AC File Offset: 0x00015AAC
		Private Sub SetSearchPanel()
			Me.GbAdvanced.Height = Me.pnlAdvDefaultHeight
			Me.GbBasic.Height = Me.pnlBasicDefaultHeight
		End Sub

		' Token: 0x06000271 RID: 625 RVA: 0x000178D4 File Offset: 0x00015AD4
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

		' Token: 0x06000272 RID: 626 RVA: 0x00017944 File Offset: 0x00015B44
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

		' Token: 0x040000EB RID: 235
		Private pnlBasicDefaultHeight As Integer

		' Token: 0x040000EC RID: 236
		Private pnlBasicSetHeight As Integer

		' Token: 0x040000ED RID: 237
		Private pnlAdvDefaultHeight As Integer

		' Token: 0x040000EE RID: 238
		Private pnlAdvSetHeight As Integer
	End Class
End Namespace
