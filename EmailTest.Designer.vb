Namespace Datasoft_PIMS
	' Token: 0x0200004C RID: 76
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class EmailTest
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000D99 RID: 3481 RVA: 0x0007B4C8 File Offset: 0x000796C8
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

		' Token: 0x06000D9A RID: 3482 RVA: 0x0007B518 File Offset: 0x00079718
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.Label8 = New Global.System.Windows.Forms.Label()
			Me.cmbSSL = New Global.System.Windows.Forms.ComboBox()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.txtPort = New Global.System.Windows.Forms.TextBox()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.txtSMTP = New Global.System.Windows.Forms.TextBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.txtBody = New Global.System.Windows.Forms.TextBox()
			Me.txtSubject = New Global.System.Windows.Forms.TextBox()
			Me.txtPwd = New Global.System.Windows.Forms.TextBox()
			Me.txtTo = New Global.System.Windows.Forms.TextBox()
			Me.txtFrom = New Global.System.Windows.Forms.TextBox()
			Me.btnSend = New Global.System.Windows.Forms.Button()
			MyBase.SuspendLayout()
			Me.Label8.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label8.Location = New Global.System.Drawing.Point(13, 66)
			Me.Label8.Name = "Label8"
			Me.Label8.Size = New Global.System.Drawing.Size(65, 23)
			Me.Label8.TabIndex = 34
			Me.Label8.Text = "SSL"
			Me.Label8.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.cmbSSL.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbSSL.FormattingEnabled = True
			Me.cmbSSL.Items.AddRange(New Object() { "True", "False" })
			Me.cmbSSL.Location = New Global.System.Drawing.Point(82, 66)
			Me.cmbSSL.Name = "cmbSSL"
			Me.cmbSSL.Size = New Global.System.Drawing.Size(340, 23)
			Me.cmbSSL.TabIndex = 33
			Me.Label7.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label7.Location = New Global.System.Drawing.Point(13, 39)
			Me.Label7.Name = "Label7"
			Me.Label7.Size = New Global.System.Drawing.Size(65, 21)
			Me.Label7.TabIndex = 32
			Me.Label7.Text = "Port"
			Me.Label7.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.txtPort.Location = New Global.System.Drawing.Point(82, 39)
			Me.txtPort.Name = "txtPort"
			Me.txtPort.ScrollBars = Global.System.Windows.Forms.ScrollBars.Both
			Me.txtPort.Size = New Global.System.Drawing.Size(340, 21)
			Me.txtPort.TabIndex = 31
			Me.txtPort.Text = "25"
			Me.Label6.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label6.Location = New Global.System.Drawing.Point(13, 12)
			Me.Label6.Name = "Label6"
			Me.Label6.Size = New Global.System.Drawing.Size(65, 21)
			Me.Label6.TabIndex = 30
			Me.Label6.Text = "Host"
			Me.Label6.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.txtSMTP.Location = New Global.System.Drawing.Point(82, 12)
			Me.txtSMTP.Name = "txtSMTP"
			Me.txtSMTP.ScrollBars = Global.System.Windows.Forms.ScrollBars.Both
			Me.txtSMTP.Size = New Global.System.Drawing.Size(340, 21)
			Me.txtSMTP.TabIndex = 29
			Me.txtSMTP.Text = "smtp.outlook.com"
			Me.Label5.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label5.Location = New Global.System.Drawing.Point(13, 203)
			Me.Label5.Name = "Label5"
			Me.Label5.Size = New Global.System.Drawing.Size(65, 103)
			Me.Label5.TabIndex = 28
			Me.Label5.Text = "Body"
			Me.Label5.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label4.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label4.Location = New Global.System.Drawing.Point(13, 176)
			Me.Label4.Name = "Label4"
			Me.Label4.Size = New Global.System.Drawing.Size(65, 21)
			Me.Label4.TabIndex = 27
			Me.Label4.Text = "Subject"
			Me.Label4.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label3.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label3.Location = New Global.System.Drawing.Point(13, 149)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(65, 21)
			Me.Label3.TabIndex = 26
			Me.Label3.Text = "To"
			Me.Label3.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label2.Location = New Global.System.Drawing.Point(13, 122)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(65, 21)
			Me.Label2.TabIndex = 25
			Me.Label2.Text = "Password"
			Me.Label2.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Label1.Location = New Global.System.Drawing.Point(13, 95)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(65, 21)
			Me.Label1.TabIndex = 24
			Me.Label1.Text = "From"
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.txtBody.Location = New Global.System.Drawing.Point(82, 203)
			Me.txtBody.Multiline = True
			Me.txtBody.Name = "txtBody"
			Me.txtBody.ScrollBars = Global.System.Windows.Forms.ScrollBars.Both
			Me.txtBody.Size = New Global.System.Drawing.Size(340, 103)
			Me.txtBody.TabIndex = 23
			Me.txtBody.Text = "Hi," & vbCrLf & vbCrLf & "This is a test mail" & vbCrLf & vbCrLf & "Regards," & vbCrLf & "ImmunoACT"
			Me.txtSubject.Location = New Global.System.Drawing.Point(82, 176)
			Me.txtSubject.Name = "txtSubject"
			Me.txtSubject.ScrollBars = Global.System.Windows.Forms.ScrollBars.Both
			Me.txtSubject.Size = New Global.System.Drawing.Size(340, 21)
			Me.txtSubject.TabIndex = 22
			Me.txtSubject.Text = "Mail Testing"
			Me.txtPwd.Location = New Global.System.Drawing.Point(82, 122)
			Me.txtPwd.Name = "txtPwd"
			Me.txtPwd.ScrollBars = Global.System.Windows.Forms.ScrollBars.Both
			Me.txtPwd.Size = New Global.System.Drawing.Size(340, 21)
			Me.txtPwd.TabIndex = 21
			Me.txtPwd.Text = "kartik@r977"
			Me.txtTo.Location = New Global.System.Drawing.Point(82, 149)
			Me.txtTo.Name = "txtTo"
			Me.txtTo.ScrollBars = Global.System.Windows.Forms.ScrollBars.Both
			Me.txtTo.Size = New Global.System.Drawing.Size(340, 21)
			Me.txtTo.TabIndex = 20
			Me.txtTo.Text = "anwar@datacodeindia.com"
			Me.txtFrom.Location = New Global.System.Drawing.Point(82, 95)
			Me.txtFrom.Name = "txtFrom"
			Me.txtFrom.ScrollBars = Global.System.Windows.Forms.ScrollBars.Both
			Me.txtFrom.Size = New Global.System.Drawing.Size(340, 21)
			Me.txtFrom.TabIndex = 19
			Me.txtFrom.Text = "Kamlesh.yadav@immunoact.com"
			Me.btnSend.Location = New Global.System.Drawing.Point(68, 331)
			Me.btnSend.Name = "btnSend"
			Me.btnSend.Size = New Global.System.Drawing.Size(301, 40)
			Me.btnSend.TabIndex = 18
			Me.btnSend.Text = "Send"
			Me.btnSend.UseVisualStyleBackColor = True
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			MyBase.ClientSize = New Global.System.Drawing.Size(435, 382)
			MyBase.Controls.Add(Me.Label8)
			MyBase.Controls.Add(Me.cmbSSL)
			MyBase.Controls.Add(Me.Label7)
			MyBase.Controls.Add(Me.txtPort)
			MyBase.Controls.Add(Me.Label6)
			MyBase.Controls.Add(Me.txtSMTP)
			MyBase.Controls.Add(Me.Label5)
			MyBase.Controls.Add(Me.Label4)
			MyBase.Controls.Add(Me.Label3)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.Label1)
			MyBase.Controls.Add(Me.txtBody)
			MyBase.Controls.Add(Me.txtSubject)
			MyBase.Controls.Add(Me.txtPwd)
			MyBase.Controls.Add(Me.txtTo)
			MyBase.Controls.Add(Me.txtFrom)
			MyBase.Controls.Add(Me.btnSend)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "EmailTest"
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Email Test"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0400059B RID: 1435
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
