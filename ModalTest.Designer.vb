Namespace Datasoft_PIMS
	' Token: 0x0200000B RID: 11
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class ModalTest
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000068 RID: 104 RVA: 0x00004378 File Offset: 0x00002578
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

		' Token: 0x06000069 RID: 105 RVA: 0x000043C8 File Offset: 0x000025C8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.pnlBorder = New Global.System.Windows.Forms.Panel()
			Me.pnlMain = New Global.System.Windows.Forms.Panel()
			Me.panelTitleBar = New Global.System.Windows.Forms.Panel()
			Me.picFormIcon = New Global.System.Windows.Forms.PictureBox()
			Me.lblCaption = New Global.System.Windows.Forms.Label()
			Me.form_btnClose = New Global.System.Windows.Forms.Button()
			Me.lblShadow2 = New Global.System.Windows.Forms.Label()
			Me.lblShadow1 = New Global.System.Windows.Forms.Label()
			Me.pnlBorder.SuspendLayout()
			Me.pnlMain.SuspendLayout()
			Me.panelTitleBar.SuspendLayout()
			CType(Me.picFormIcon, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.pnlBorder.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.pnlBorder.BackColor = Global.System.Drawing.Color.SteelBlue
			Me.pnlBorder.Controls.Add(Me.pnlMain)
			Me.pnlBorder.Location = New Global.System.Drawing.Point(-1, -1)
			Me.pnlBorder.Name = "pnlBorder"
			Me.pnlBorder.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.pnlBorder.Size = New Global.System.Drawing.Size(467, 225)
			Me.pnlBorder.TabIndex = 0
			Me.pnlMain.BackColor = Global.System.Drawing.Color.White
			Me.pnlMain.Controls.Add(Me.panelTitleBar)
			Me.pnlMain.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.pnlMain.Location = New Global.System.Drawing.Point(3, 3)
			Me.pnlMain.Name = "pnlMain"
			Me.pnlMain.Size = New Global.System.Drawing.Size(461, 219)
			Me.pnlMain.TabIndex = 1
			Me.panelTitleBar.BackColor = Global.System.Drawing.Color.FromArgb(204, 231, 255)
			Me.panelTitleBar.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.panelTitleBar.Controls.Add(Me.picFormIcon)
			Me.panelTitleBar.Controls.Add(Me.lblCaption)
			Me.panelTitleBar.Controls.Add(Me.form_btnClose)
			Me.panelTitleBar.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.panelTitleBar.Location = New Global.System.Drawing.Point(0, 0)
			Me.panelTitleBar.Name = "panelTitleBar"
			Me.panelTitleBar.Size = New Global.System.Drawing.Size(461, 27)
			Me.panelTitleBar.TabIndex = 10
			Me.picFormIcon.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.picFormIcon.Dock = Global.System.Windows.Forms.DockStyle.Left
			Me.picFormIcon.Location = New Global.System.Drawing.Point(0, 0)
			Me.picFormIcon.Name = "picFormIcon"
			Me.picFormIcon.Padding = New Global.System.Windows.Forms.Padding(2)
			Me.picFormIcon.Size = New Global.System.Drawing.Size(27, 27)
			Me.picFormIcon.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.picFormIcon.TabIndex = 721
			Me.picFormIcon.TabStop = False
			Me.lblCaption.AutoSize = True
			Me.lblCaption.Location = New Global.System.Drawing.Point(31, 6)
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
			Me.form_btnClose.Location = New Global.System.Drawing.Point(435, 1)
			Me.form_btnClose.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.form_btnClose.Name = "form_btnClose"
			Me.form_btnClose.Size = New Global.System.Drawing.Size(24, 24)
			Me.form_btnClose.TabIndex = 719
			Me.form_btnClose.UseVisualStyleBackColor = True
			Me.lblShadow2.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
			Me.lblShadow2.BackColor = Global.System.Drawing.Color.White
			Me.lblShadow2.Location = New Global.System.Drawing.Point(-1, 223)
			Me.lblShadow2.Name = "lblShadow2"
			Me.lblShadow2.Size = New Global.System.Drawing.Size(9, 7)
			Me.lblShadow2.TabIndex = 2
			Me.lblShadow1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblShadow1.BackColor = Global.System.Drawing.Color.White
			Me.lblShadow1.Location = New Global.System.Drawing.Point(466, -1)
			Me.lblShadow1.Name = "lblShadow1"
			Me.lblShadow1.Size = New Global.System.Drawing.Size(6, 9)
			Me.lblShadow1.TabIndex = 3
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.DarkGray
			MyBase.ClientSize = New Global.System.Drawing.Size(472, 230)
			MyBase.Controls.Add(Me.lblShadow1)
			MyBase.Controls.Add(Me.lblShadow2)
			MyBase.Controls.Add(Me.pnlBorder)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedToolWindow
			MyBase.Name = "ModalTest"
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "ModalTest"
			Me.pnlBorder.ResumeLayout(False)
			Me.pnlMain.ResumeLayout(False)
			Me.panelTitleBar.ResumeLayout(False)
			Me.panelTitleBar.PerformLayout()
			CType(Me.picFormIcon, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000021 RID: 33
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
