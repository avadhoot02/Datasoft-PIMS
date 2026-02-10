Namespace Datasoft_PIMS
	' Token: 0x02000053 RID: 83
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class TCPPrinting
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000F7E RID: 3966 RVA: 0x0008D268 File Offset: 0x0008B468
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

		' Token: 0x06000F7F RID: 3967 RVA: 0x0008D2B8 File Offset: 0x0008B4B8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.txtIP = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.txtPort = New Global.System.Windows.Forms.TextBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.txtData = New Global.System.Windows.Forms.TextBox()
			Me.btnPing = New Global.System.Windows.Forms.Button()
			Me.btnPrint = New Global.System.Windows.Forms.Button()
			MyBase.SuspendLayout()
			Me.Label5.AutoSize = True
			Me.Label5.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label5.Location = New Global.System.Drawing.Point(9, 10)
			Me.Label5.Name = "Label5"
			Me.Label5.Size = New Global.System.Drawing.Size(61, 15)
			Me.Label5.TabIndex = 1069
			Me.Label5.Text = "Printer IP"
			Me.txtIP.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtIP.Location = New Global.System.Drawing.Point(84, 7)
			Me.txtIP.Name = "txtIP"
			Me.txtIP.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtIP.TabIndex = 1068
			Me.txtIP.TabStop = False
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.Location = New Global.System.Drawing.Point(9, 37)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(72, 15)
			Me.Label1.TabIndex = 1071
			Me.Label1.Text = "Printer Port"
			Me.txtPort.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPort.Location = New Global.System.Drawing.Point(84, 34)
			Me.txtPort.Name = "txtPort"
			Me.txtPort.Size = New Global.System.Drawing.Size(176, 21)
			Me.txtPort.TabIndex = 1070
			Me.txtPort.TabStop = False
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.Location = New Global.System.Drawing.Point(9, 64)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(30, 15)
			Me.Label2.TabIndex = 1073
			Me.Label2.Text = "PRN"
			Me.txtData.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtData.Location = New Global.System.Drawing.Point(84, 61)
			Me.txtData.Multiline = True
			Me.txtData.Name = "txtData"
			Me.txtData.Size = New Global.System.Drawing.Size(589, 239)
			Me.txtData.TabIndex = 1072
			Me.txtData.TabStop = False
			Me.btnPing.Location = New Global.System.Drawing.Point(595, 6)
			Me.btnPing.Name = "btnPing"
			Me.btnPing.Size = New Global.System.Drawing.Size(75, 23)
			Me.btnPing.TabIndex = 1074
			Me.btnPing.Text = "Ping"
			Me.btnPing.UseVisualStyleBackColor = True
			Me.btnPrint.Location = New Global.System.Drawing.Point(595, 32)
			Me.btnPrint.Name = "btnPrint"
			Me.btnPrint.Size = New Global.System.Drawing.Size(75, 23)
			Me.btnPrint.TabIndex = 1075
			Me.btnPrint.Text = "Print"
			Me.btnPrint.UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			MyBase.ClientSize = New Global.System.Drawing.Size(682, 307)
			MyBase.Controls.Add(Me.btnPrint)
			MyBase.Controls.Add(Me.btnPing)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.txtData)
			MyBase.Controls.Add(Me.Label1)
			MyBase.Controls.Add(Me.txtPort)
			MyBase.Controls.Add(Me.Label5)
			MyBase.Controls.Add(Me.txtIP)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedToolWindow
			MyBase.Name = "TCPPrinting"
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "TCP Printing"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000670 RID: 1648
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
