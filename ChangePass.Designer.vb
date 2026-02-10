Namespace Datasoft_PIMS
	' Token: 0x02000048 RID: 72
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class ChangePass
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000CE0 RID: 3296 RVA: 0x00075990 File Offset: 0x00073B90
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

		' Token: 0x06000CE1 RID: 3297 RVA: 0x000759E0 File Offset: 0x00073BE0
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.Datasoft_PIMS.ChangePass))
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.txtOld = New Global.System.Windows.Forms.TextBox()
			Me.txtNew = New Global.System.Windows.Forms.TextBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.txtConfirm = New Global.System.Windows.Forms.TextBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.btnChange = New Global.System.Windows.Forms.Button()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.LogoPictureBox = New Global.System.Windows.Forms.PictureBox()
			CType(Me.LogoPictureBox, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.Label1.AutoSize = True
			Me.Label1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.Location = New Global.System.Drawing.Point(167, 17)
			Me.Label1.Margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(103, 18)
			Me.Label1.TabIndex = 0
			Me.Label1.Text = "Old Password"
			Me.txtOld.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtOld.Location = New Global.System.Drawing.Point(316, 14)
			Me.txtOld.Margin = New Global.System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.txtOld.Name = "txtOld"
			Me.txtOld.PasswordChar = "*"c
			Me.txtOld.Size = New Global.System.Drawing.Size(275, 24)
			Me.txtOld.TabIndex = 1
			Me.txtNew.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtNew.Location = New Global.System.Drawing.Point(316, 48)
			Me.txtNew.Margin = New Global.System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.txtNew.Name = "txtNew"
			Me.txtNew.PasswordChar = "*"c
			Me.txtNew.Size = New Global.System.Drawing.Size(275, 24)
			Me.txtNew.TabIndex = 3
			Me.Label2.AutoSize = True
			Me.Label2.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.Location = New Global.System.Drawing.Point(167, 52)
			Me.Label2.Margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.Label2.Name = "Label2"
			Me.Label2.Size = New Global.System.Drawing.Size(109, 18)
			Me.Label2.TabIndex = 2
			Me.Label2.Text = "New Password"
			Me.txtConfirm.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtConfirm.Location = New Global.System.Drawing.Point(316, 82)
			Me.txtConfirm.Margin = New Global.System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.txtConfirm.Name = "txtConfirm"
			Me.txtConfirm.PasswordChar = "*"c
			Me.txtConfirm.Size = New Global.System.Drawing.Size(275, 24)
			Me.txtConfirm.TabIndex = 5
			Me.Label3.AutoSize = True
			Me.Label3.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.Location = New Global.System.Drawing.Point(167, 86)
			Me.Label3.Margin = New Global.System.Windows.Forms.Padding(4, 0, 4, 0)
			Me.Label3.Name = "Label3"
			Me.Label3.Size = New Global.System.Drawing.Size(135, 18)
			Me.Label3.TabIndex = 4
			Me.Label3.Text = "Confirm Password"
			Me.btnChange.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnChange.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnChange.Location = New Global.System.Drawing.Point(316, 134)
			Me.btnChange.Margin = New Global.System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.btnChange.Name = "btnChange"
			Me.btnChange.Size = New Global.System.Drawing.Size(133, 32)
			Me.btnChange.TabIndex = 6
			Me.btnChange.Text = "Change"
			Me.btnChange.UseVisualStyleBackColor = True
			Me.btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnClose.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClose.Location = New Global.System.Drawing.Point(459, 134)
			Me.btnClose.Margin = New Global.System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.btnClose.Name = "btnClose"
			Me.btnClose.Size = New Global.System.Drawing.Size(133, 32)
			Me.btnClose.TabIndex = 7
			Me.btnClose.Text = "Close"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.LogoPictureBox.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.LogoPictureBox.BackgroundImage = CType(componentResourceManager.GetObject("LogoPictureBox.BackgroundImage"), Global.System.Drawing.Image)
			Me.LogoPictureBox.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.LogoPictureBox.Location = New Global.System.Drawing.Point(-1, 0)
			Me.LogoPictureBox.Margin = New Global.System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.LogoPictureBox.Name = "LogoPictureBox"
			Me.LogoPictureBox.Size = New Global.System.Drawing.Size(160, 174)
			Me.LogoPictureBox.TabIndex = 8
			Me.LogoPictureBox.TabStop = False
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(120F, 120F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.White
			Me.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			MyBase.ClientSize = New Global.System.Drawing.Size(608, 175)
			MyBase.Controls.Add(Me.LogoPictureBox)
			MyBase.Controls.Add(Me.btnClose)
			MyBase.Controls.Add(Me.btnChange)
			MyBase.Controls.Add(Me.txtConfirm)
			MyBase.Controls.Add(Me.Label3)
			MyBase.Controls.Add(Me.txtNew)
			MyBase.Controls.Add(Me.Label2)
			MyBase.Controls.Add(Me.txtOld)
			MyBase.Controls.Add(Me.Label1)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			MyBase.Margin = New Global.System.Windows.Forms.Padding(4, 4, 4, 4)
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "ChangePass"
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Change Password"
			CType(Me.LogoPictureBox, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000557 RID: 1367
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
