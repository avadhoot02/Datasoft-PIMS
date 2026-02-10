Namespace Datasoft_PIMS
	' Token: 0x0200004E RID: 78
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class ReLogin
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000E11 RID: 3601 RVA: 0x0007E794 File Offset: 0x0007C994
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

		' Token: 0x06000E12 RID: 3602 RVA: 0x0007E7E4 File Offset: 0x0007C9E4
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.lblLogin = New Global.System.Windows.Forms.Label()
			Me.picShow = New Global.System.Windows.Forms.PictureBox()
			Me.picPwd = New Global.System.Windows.Forms.PictureBox()
			Me.picUser = New Global.System.Windows.Forms.PictureBox()
			Me.btnOK = New Global.System.Windows.Forms.Button()
			Me.txtPass = New Global.System.Windows.Forms.TextBox()
			Me.txtUser = New Global.System.Windows.Forms.TextBox()
			CType(Me.picShow, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.picPwd, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.picUser, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.lblLogin.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.lblLogin.AutoSize = True
			Me.lblLogin.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 26.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblLogin.ForeColor = Global.System.Drawing.Color.SteelBlue
			Me.lblLogin.Location = New Global.System.Drawing.Point(40, 17)
			Me.lblLogin.Name = "lblLogin"
			Me.lblLogin.Size = New Global.System.Drawing.Size(450, 55)
			Me.lblLogin.TabIndex = 60
			Me.lblLogin.Text = "* Session Locked*"
			Me.picShow.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.picShow.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.picShow.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.picShow.Location = New Global.System.Drawing.Point(386, 110)
			Me.picShow.Name = "picShow"
			Me.picShow.Size = New Global.System.Drawing.Size(23, 23)
			Me.picShow.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.picShow.TabIndex = 67
			Me.picShow.TabStop = False
			Me.picPwd.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.picPwd.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.picPwd.Location = New Global.System.Drawing.Point(122, 110)
			Me.picPwd.Name = "picPwd"
			Me.picPwd.Size = New Global.System.Drawing.Size(23, 23)
			Me.picPwd.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.picPwd.TabIndex = 66
			Me.picPwd.TabStop = False
			Me.picUser.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.picUser.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.picUser.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.picUser.Location = New Global.System.Drawing.Point(122, 80)
			Me.picUser.Name = "picUser"
			Me.picUser.Size = New Global.System.Drawing.Size(23, 23)
			Me.picUser.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.picUser.TabIndex = 65
			Me.picUser.TabStop = False
			Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.btnOK.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnOK.Location = New Global.System.Drawing.Point(121, 140)
			Me.btnOK.Name = "btnOK"
			Me.btnOK.Size = New Global.System.Drawing.Size(289, 28)
			Me.btnOK.TabIndex = 1
			Me.btnOK.Text = "&Login"
			Me.txtPass.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.txtPass.BackColor = Global.System.Drawing.Color.White
			Me.txtPass.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtPass.ForeColor = Global.System.Drawing.Color.DarkGray
			Me.txtPass.Location = New Global.System.Drawing.Point(146, 110)
			Me.txtPass.Name = "txtPass"
			Me.txtPass.Size = New Global.System.Drawing.Size(241, 27)
			Me.txtPass.TabIndex = 0
			Me.txtPass.Text = "Enter Password"
			Me.txtUser.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.txtUser.BackColor = Global.System.Drawing.Color.White
			Me.txtUser.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.75F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtUser.ForeColor = Global.System.Drawing.Color.DarkGray
			Me.txtUser.Location = New Global.System.Drawing.Point(146, 80)
			Me.txtUser.Name = "txtUser"
			Me.txtUser.Size = New Global.System.Drawing.Size(263, 27)
			Me.txtUser.TabIndex = 2
			Me.txtUser.Text = "Enter LoginID"
			MyBase.AcceptButton = Me.btnOK
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(9F, 18F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			MyBase.ClientSize = New Global.System.Drawing.Size(531, 185)
			MyBase.Controls.Add(Me.picShow)
			MyBase.Controls.Add(Me.picPwd)
			MyBase.Controls.Add(Me.picUser)
			MyBase.Controls.Add(Me.btnOK)
			MyBase.Controls.Add(Me.txtPass)
			MyBase.Controls.Add(Me.txtUser)
			MyBase.Controls.Add(Me.lblLogin)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Name = "ReLogin"
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "ReLogin"
			CType(Me.picShow, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.picPwd, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.picUser, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x040005CF RID: 1487
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
