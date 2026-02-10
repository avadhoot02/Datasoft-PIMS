Namespace Datasoft_PIMS
	' Token: 0x0200000F RID: 15
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Form1
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060000FE RID: 254 RVA: 0x0000B5D8 File Offset: 0x000097D8
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

		' Token: 0x060000FF RID: 255 RVA: 0x0000B628 File Offset: 0x00009828
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.btn1 = New Global.System.Windows.Forms.Button()
			Me.txt1 = New Global.System.Windows.Forms.TextBox()
			Me.txt3 = New Global.System.Windows.Forms.TextBox()
			Me.txt2 = New Global.System.Windows.Forms.TextBox()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.txt4 = New Global.System.Windows.Forms.TextBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			MyBase.SuspendLayout()
			Me.btn1.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btn1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btn1.Location = New Global.System.Drawing.Point(159, 247)
			Me.btn1.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.btn1.Name = "btn1"
			Me.btn1.Size = New Global.System.Drawing.Size(129, 32)
			Me.btn1.TabIndex = 1082
			Me.btn1.Text = "Format"
			Me.btn1.UseVisualStyleBackColor = True
			Me.txt1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txt1.Location = New Global.System.Drawing.Point(145, 87)
			Me.txt1.Name = "txt1"
			Me.txt1.Size = New Global.System.Drawing.Size(176, 21)
			Me.txt1.TabIndex = 1083
			Me.txt1.TabStop = False
			Me.txt3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txt3.Location = New Global.System.Drawing.Point(145, 157)
			Me.txt3.Name = "txt3"
			Me.txt3.Size = New Global.System.Drawing.Size(176, 21)
			Me.txt3.TabIndex = 1084
			Me.txt3.TabStop = False
			Me.txt2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txt2.Location = New Global.System.Drawing.Point(145, 121)
			Me.txt2.Name = "txt2"
			Me.txt2.Size = New Global.System.Drawing.Size(176, 21)
			Me.txt2.TabIndex = 1085
			Me.txt2.TabStop = False
			Me.Label4.AutoSize = True
			Me.Label4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label4.Location = New Global.System.Drawing.Point(51, 90)
			Me.Label4.Name = "Label4"
			Me.Label4.Size = New Global.System.Drawing.Size(39, 15)
			Me.Label4.TabIndex = 1086
			Me.Label4.Text = "Value"
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.Location = New Global.System.Drawing.Point(51, 124)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(85, 15)
			Me.Label1.TabIndex = 1087
			Me.Label1.Text = "Format String"
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.Location = New Global.System.Drawing.Point(51, 160)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(53, 15)
			Me.Label2.TabIndex = 1088
			Me.Label2.Text = "Result 1"
			Me.txt4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txt4.Location = New Global.System.Drawing.Point(145, 199)
			Me.txt4.Name = "txt4"
			Me.txt4.Size = New Global.System.Drawing.Size(176, 21)
			Me.txt4.TabIndex = 1089
			Me.txt4.TabStop = False
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.Location = New Global.System.Drawing.Point(51, 202)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(53, 15)
			Me.Label3.TabIndex = 1090
			Me.Label3.Text = "Result 2"
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.None
			Me.BackColor = Global.System.Drawing.Color.White
			MyBase.ClientSize = New Global.System.Drawing.Size(933, 529)
			MyBase.Controls.Add(Me.Label3)
			MyBase.Controls.Add(Me.txt4)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.Label1)
			MyBase.Controls.Add(Me.Label4)
			MyBase.Controls.Add(Me.txt2)
			MyBase.Controls.Add(Me.btn1)
			MyBase.Controls.Add(Me.txt1)
			MyBase.Controls.Add(Me.txt3)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.Name = "Form1"
			Me.Text = "Form1"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000049 RID: 73
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
