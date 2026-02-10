Namespace Datasoft_PIMS
	' Token: 0x02000041 RID: 65
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class ReportCrystal
		Inherits Global.WeifenLuo.WinFormsUI.Docking.DockContent

		' Token: 0x06000C90 RID: 3216 RVA: 0x00074EC8 File Offset: 0x000730C8
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				Dim flag As Boolean = disposing AndAlso Me.components IsNot Nothing
				If flag Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x06000C91 RID: 3217 RVA: 0x00074F18 File Offset: 0x00073118
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.CrystalReportViewer1 = New Global.CrystalDecisions.Windows.Forms.CrystalReportViewer()
			MyBase.SuspendLayout()
			Me.CrystalReportViewer1.ActiveViewIndex = -1
			Me.CrystalReportViewer1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.CrystalReportViewer1.Cursor = Global.System.Windows.Forms.Cursors.[Default]
			Me.CrystalReportViewer1.DisplayStatusBar = False
			Me.CrystalReportViewer1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.CrystalReportViewer1.Location = New Global.System.Drawing.Point(0, 0)
			Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
			Me.CrystalReportViewer1.ShowCloseButton = False
			Me.CrystalReportViewer1.ShowCopyButton = False
			Me.CrystalReportViewer1.ShowGotoPageButton = False
			Me.CrystalReportViewer1.ShowGroupTreeButton = False
			Me.CrystalReportViewer1.ShowLogo = False
			Me.CrystalReportViewer1.ShowParameterPanelButton = False
			Me.CrystalReportViewer1.ShowTextSearchButton = False
			Me.CrystalReportViewer1.Size = New Global.System.Drawing.Size(913, 423)
			Me.CrystalReportViewer1.TabIndex = 0
			Me.CrystalReportViewer1.ToolPanelView = Global.CrystalDecisions.Windows.Forms.ToolPanelViewType.None
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			MyBase.ClientSize = New Global.System.Drawing.Size(913, 423)
			MyBase.Controls.Add(Me.CrystalReportViewer1)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.Name = "ReportCrystal"
			Me.Text = "ReportCrystal"
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000553 RID: 1363
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
