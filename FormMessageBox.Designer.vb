Namespace Datasoft_PIMS
	' Token: 0x0200000A RID: 10
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormMessageBox
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600003B RID: 59 RVA: 0x00002F24 File Offset: 0x00001124
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

		' Token: 0x0600003C RID: 60 RVA: 0x00002F74 File Offset: 0x00001174
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.pnlBorder = New Global.System.Windows.Forms.Panel()
			Me.pnlMain = New Global.System.Windows.Forms.Panel()
			Me.pnlBody = New Global.System.Windows.Forms.Panel()
			Me.lblMsg = New Global.System.Windows.Forms.Label()
			Me.picIcon = New Global.System.Windows.Forms.PictureBox()
			Me.pnlButton = New Global.System.Windows.Forms.Panel()
			Me.flpButton = New Global.System.Windows.Forms.FlowLayoutPanel()
			Me.button1 = New Global.System.Windows.Forms.Button()
			Me.button2 = New Global.System.Windows.Forms.Button()
			Me.button3 = New Global.System.Windows.Forms.Button()
			Me.panelTitleBar = New Global.System.Windows.Forms.Panel()
			Me.lblCaption = New Global.System.Windows.Forms.Label()
			Me.form_btnClose = New Global.System.Windows.Forms.Button()
			Me.pnlShadow = New Global.System.Windows.Forms.Panel()
			Me.pnlBorder.SuspendLayout()
			Me.pnlMain.SuspendLayout()
			Me.pnlBody.SuspendLayout()
			CType(Me.picIcon, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlButton.SuspendLayout()
			Me.flpButton.SuspendLayout()
			Me.panelTitleBar.SuspendLayout()
			MyBase.SuspendLayout()
			Me.pnlBorder.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.pnlBorder.BackColor = Global.System.Drawing.Color.SteelBlue
			Me.pnlBorder.Controls.Add(Me.pnlMain)
			Me.pnlBorder.Location = New Global.System.Drawing.Point(1, 1)
			Me.pnlBorder.Name = "pnlBorder"
			Me.pnlBorder.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.pnlBorder.Size = New Global.System.Drawing.Size(393, 177)
			Me.pnlBorder.TabIndex = 4
			Me.pnlMain.BackColor = Global.System.Drawing.Color.White
			Me.pnlMain.Controls.Add(Me.pnlBody)
			Me.pnlMain.Controls.Add(Me.pnlButton)
			Me.pnlMain.Controls.Add(Me.panelTitleBar)
			Me.pnlMain.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.pnlMain.Location = New Global.System.Drawing.Point(3, 3)
			Me.pnlMain.Name = "pnlMain"
			Me.pnlMain.Size = New Global.System.Drawing.Size(387, 171)
			Me.pnlMain.TabIndex = 1
			Me.pnlBody.Controls.Add(Me.lblMsg)
			Me.pnlBody.Controls.Add(Me.picIcon)
			Me.pnlBody.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.pnlBody.Location = New Global.System.Drawing.Point(0, 27)
			Me.pnlBody.Name = "pnlBody"
			Me.pnlBody.Size = New Global.System.Drawing.Size(387, 100)
			Me.pnlBody.TabIndex = 12
			Me.lblMsg.AutoSize = True
			Me.lblMsg.Location = New Global.System.Drawing.Point(68, 24)
			Me.lblMsg.MaximumSize = New Global.System.Drawing.Size(500, 0)
			Me.lblMsg.Name = "lblMsg"
			Me.lblMsg.Size = New Global.System.Drawing.Size(44, 15)
			Me.lblMsg.TabIndex = 3
			Me.lblMsg.Text = "Label1"
			Me.lblMsg.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.picIcon.Anchor = Global.System.Windows.Forms.AnchorStyles.Left
			Me.picIcon.Location = New Global.System.Drawing.Point(13, 26)
			Me.picIcon.Name = "picIcon"
			Me.picIcon.Size = New Global.System.Drawing.Size(44, 44)
			Me.picIcon.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.picIcon.TabIndex = 0
			Me.picIcon.TabStop = False
			Me.pnlButton.BackColor = Global.System.Drawing.Color.AliceBlue
			Me.pnlButton.Controls.Add(Me.flpButton)
			Me.pnlButton.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.pnlButton.Location = New Global.System.Drawing.Point(0, 127)
			Me.pnlButton.Name = "pnlButton"
			Me.pnlButton.Size = New Global.System.Drawing.Size(387, 44)
			Me.pnlButton.TabIndex = 11
			Me.flpButton.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.flpButton.Controls.Add(Me.button1)
			Me.flpButton.Controls.Add(Me.button2)
			Me.flpButton.Controls.Add(Me.button3)
			Me.flpButton.Location = New Global.System.Drawing.Point(41, 7)
			Me.flpButton.Name = "flpButton"
			Me.flpButton.Size = New Global.System.Drawing.Size(305, 31)
			Me.flpButton.TabIndex = 0
			Me.button1.Location = New Global.System.Drawing.Point(3, 3)
			Me.button1.Name = "button1"
			Me.button1.Size = New Global.System.Drawing.Size(94, 25)
			Me.button1.TabIndex = 0
			Me.button1.Text = "button1"
			Me.button1.UseVisualStyleBackColor = True
			Me.button1.Visible = False
			Me.button2.Location = New Global.System.Drawing.Point(103, 3)
			Me.button2.Name = "button2"
			Me.button2.Size = New Global.System.Drawing.Size(94, 25)
			Me.button2.TabIndex = 1
			Me.button2.Text = "button2"
			Me.button2.UseVisualStyleBackColor = True
			Me.button2.Visible = False
			Me.button3.Location = New Global.System.Drawing.Point(203, 3)
			Me.button3.Name = "button3"
			Me.button3.Size = New Global.System.Drawing.Size(94, 25)
			Me.button3.TabIndex = 2
			Me.button3.Text = "button3"
			Me.button3.UseVisualStyleBackColor = True
			Me.button3.Visible = False
			Me.panelTitleBar.BackColor = Global.System.Drawing.Color.FromArgb(204, 231, 255)
			Me.panelTitleBar.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.panelTitleBar.Controls.Add(Me.lblCaption)
			Me.panelTitleBar.Controls.Add(Me.form_btnClose)
			Me.panelTitleBar.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.panelTitleBar.Location = New Global.System.Drawing.Point(0, 0)
			Me.panelTitleBar.Name = "panelTitleBar"
			Me.panelTitleBar.Size = New Global.System.Drawing.Size(387, 27)
			Me.panelTitleBar.TabIndex = 10
			Me.lblCaption.AutoSize = True
			Me.lblCaption.Location = New Global.System.Drawing.Point(7, 6)
			Me.lblCaption.MaximumSize = New Global.System.Drawing.Size(500, 0)
			Me.lblCaption.Name = "lblCaption"
			Me.lblCaption.Size = New Global.System.Drawing.Size(51, 15)
			Me.lblCaption.TabIndex = 720
			Me.lblCaption.Text = "Caption"
			Me.lblCaption.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.form_btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.form_btnClose.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.form_btnClose.FlatAppearance.BorderColor = Global.System.Drawing.Color.FromArgb(204, 231, 255)
			Me.form_btnClose.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.Transparent
			Me.form_btnClose.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.Transparent
			Me.form_btnClose.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.form_btnClose.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.form_btnClose.Location = New Global.System.Drawing.Point(361, 1)
			Me.form_btnClose.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.form_btnClose.Name = "form_btnClose"
			Me.form_btnClose.Size = New Global.System.Drawing.Size(24, 24)
			Me.form_btnClose.TabIndex = 719
			Me.form_btnClose.UseVisualStyleBackColor = True
			Me.pnlShadow.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.pnlShadow.BackColor = Global.System.Drawing.Color.DarkGray
			Me.pnlShadow.Location = New Global.System.Drawing.Point(9, 13)
			Me.pnlShadow.Name = "pnlShadow"
			Me.pnlShadow.Size = New Global.System.Drawing.Size(389, 170)
			Me.pnlShadow.TabIndex = 3
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.GhostWhite
			MyBase.ClientSize = New Global.System.Drawing.Size(399, 183)
			MyBase.Controls.Add(Me.pnlBorder)
			MyBase.Controls.Add(Me.pnlShadow)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.MinimumSize = New Global.System.Drawing.Size(250, 29)
			MyBase.Name = "FormMessageBox"
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			MyBase.TransparencyKey = Global.System.Drawing.Color.GhostWhite
			Me.pnlBorder.ResumeLayout(False)
			Me.pnlMain.ResumeLayout(False)
			Me.pnlBody.ResumeLayout(False)
			Me.pnlBody.PerformLayout()
			CType(Me.picIcon, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlButton.ResumeLayout(False)
			Me.flpButton.ResumeLayout(False)
			Me.panelTitleBar.ResumeLayout(False)
			Me.panelTitleBar.PerformLayout()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000012 RID: 18
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
