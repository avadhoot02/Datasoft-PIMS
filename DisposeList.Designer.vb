Namespace Datasoft_PIMS
	' Token: 0x02000051 RID: 81
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class DisposeList
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000E54 RID: 3668 RVA: 0x00081DC0 File Offset: 0x0007FFC0
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

		' Token: 0x06000E55 RID: 3669 RVA: 0x00081E10 File Offset: 0x00080010
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.btnRead = New Global.System.Windows.Forms.Button()
			Me.dgv1 = New Global.System.Windows.Forms.DataGridView()
			CType(Me.dgv1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.btnRead.Location = New Global.System.Drawing.Point(13, 13)
			Me.btnRead.Name = "btnRead"
			Me.btnRead.Size = New Global.System.Drawing.Size(79, 26)
			Me.btnRead.TabIndex = 0
			Me.btnRead.Text = "Read File"
			Me.btnRead.UseVisualStyleBackColor = True
			Me.dgv1.AllowUserToAddRows = False
			Me.dgv1.AllowUserToDeleteRows = False
			Me.dgv1.BackgroundColor = Global.System.Drawing.Color.WhiteSmoke
			Me.dgv1.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dgv1.Location = New Global.System.Drawing.Point(5, 46)
			Me.dgv1.Name = "dgv1"
			Me.dgv1.[ReadOnly] = True
			Me.dgv1.Size = New Global.System.Drawing.Size(922, 466)
			Me.dgv1.TabIndex = 1
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			MyBase.ClientSize = New Global.System.Drawing.Size(933, 519)
			MyBase.Controls.Add(Me.dgv1)
			MyBase.Controls.Add(Me.btnRead)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.Name = "DisposeList"
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "DisposeList"
			CType(Me.dgv1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x040005E7 RID: 1511
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
