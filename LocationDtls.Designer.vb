Namespace Datasoft_PIMS
	' Token: 0x0200001E RID: 30
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class LocationDtls
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000505 RID: 1285 RVA: 0x0002E348 File Offset: 0x0002C548
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

		' Token: 0x06000506 RID: 1286 RVA: 0x0002E398 File Offset: 0x0002C598
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.pnlBorder = New Global.System.Windows.Forms.Panel()
			Me.pnlMain = New Global.System.Windows.Forms.Panel()
			Me.btnSave = New Global.System.Windows.Forms.Button()
			Me.btnClose = New Global.System.Windows.Forms.Button()
			Me.txtID = New Global.System.Windows.Forms.TextBox()
			Me.panelTitleBar = New Global.System.Windows.Forms.Panel()
			Me.picFormIcon = New Global.System.Windows.Forms.PictureBox()
			Me.lblCaption = New Global.System.Windows.Forms.Label()
			Me.form_btnClose = New Global.System.Windows.Forms.Button()
			Me.lblShadow1 = New Global.System.Windows.Forms.Label()
			Me.lblShadow2 = New Global.System.Windows.Forms.Label()
			Me.txtDesc = New Global.System.Windows.Forms.TextBox()
			Me.Label19 = New Global.System.Windows.Forms.Label()
			Me.txtCode = New Global.System.Windows.Forms.TextBox()
			Me.Label18 = New Global.System.Windows.Forms.Label()
			Me.txtName = New Global.System.Windows.Forms.TextBox()
			Me.Label9 = New Global.System.Windows.Forms.Label()
			Me.Label17 = New Global.System.Windows.Forms.Label()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.pnlBorder.SuspendLayout()
			Me.pnlMain.SuspendLayout()
			Me.panelTitleBar.SuspendLayout()
			CType(Me.picFormIcon, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.pnlBorder.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.pnlBorder.BackColor = Global.System.Drawing.Color.SteelBlue
			Me.pnlBorder.Controls.Add(Me.pnlMain)
			Me.pnlBorder.Location = New Global.System.Drawing.Point(0, 0)
			Me.pnlBorder.Name = "pnlBorder"
			Me.pnlBorder.Padding = New Global.System.Windows.Forms.Padding(3)
			Me.pnlBorder.Size = New Global.System.Drawing.Size(558, 191)
			Me.pnlBorder.TabIndex = 4
			Me.pnlMain.BackColor = Global.System.Drawing.Color.White
			Me.pnlMain.Controls.Add(Me.Label1)
			Me.pnlMain.Controls.Add(Me.Label17)
			Me.pnlMain.Controls.Add(Me.txtDesc)
			Me.pnlMain.Controls.Add(Me.Label19)
			Me.pnlMain.Controls.Add(Me.txtCode)
			Me.pnlMain.Controls.Add(Me.Label18)
			Me.pnlMain.Controls.Add(Me.txtName)
			Me.pnlMain.Controls.Add(Me.Label9)
			Me.pnlMain.Controls.Add(Me.btnSave)
			Me.pnlMain.Controls.Add(Me.btnClose)
			Me.pnlMain.Controls.Add(Me.txtID)
			Me.pnlMain.Controls.Add(Me.panelTitleBar)
			Me.pnlMain.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.pnlMain.Location = New Global.System.Drawing.Point(3, 3)
			Me.pnlMain.Name = "pnlMain"
			Me.pnlMain.Size = New Global.System.Drawing.Size(552, 185)
			Me.pnlMain.TabIndex = 1
			Me.btnSave.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnSave.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnSave.Location = New Global.System.Drawing.Point(192, 150)
			Me.btnSave.Name = "btnSave"
			Me.btnSave.Size = New Global.System.Drawing.Size(83, 29)
			Me.btnSave.TabIndex = 17
			Me.btnSave.Text = "&Save"
			Me.btnSave.UseVisualStyleBackColor = True
			Me.btnClose.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom
			Me.btnClose.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnClose.Location = New Global.System.Drawing.Point(278, 150)
			Me.btnClose.Name = "btnClose"
			Me.btnClose.Size = New Global.System.Drawing.Size(83, 29)
			Me.btnClose.TabIndex = 18
			Me.btnClose.Text = "C&lose"
			Me.btnClose.UseVisualStyleBackColor = True
			Me.txtID.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtID.Location = New Global.System.Drawing.Point(507, 141)
			Me.txtID.Name = "txtID"
			Me.txtID.Size = New Global.System.Drawing.Size(34, 21)
			Me.txtID.TabIndex = 16
			Me.txtID.TabStop = False
			Me.txtID.Visible = False
			Me.panelTitleBar.BackColor = Global.System.Drawing.Color.FromArgb(204, 231, 255)
			Me.panelTitleBar.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.panelTitleBar.Controls.Add(Me.picFormIcon)
			Me.panelTitleBar.Controls.Add(Me.lblCaption)
			Me.panelTitleBar.Controls.Add(Me.form_btnClose)
			Me.panelTitleBar.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.panelTitleBar.Location = New Global.System.Drawing.Point(0, 0)
			Me.panelTitleBar.Name = "panelTitleBar"
			Me.panelTitleBar.Size = New Global.System.Drawing.Size(552, 27)
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
			Me.form_btnClose.Location = New Global.System.Drawing.Point(526, 1)
			Me.form_btnClose.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.form_btnClose.Name = "form_btnClose"
			Me.form_btnClose.Size = New Global.System.Drawing.Size(24, 24)
			Me.form_btnClose.TabIndex = 719
			Me.form_btnClose.UseVisualStyleBackColor = True
			Me.lblShadow1.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.lblShadow1.BackColor = Global.System.Drawing.Color.White
			Me.lblShadow1.Location = New Global.System.Drawing.Point(558, 0)
			Me.lblShadow1.Name = "lblShadow1"
			Me.lblShadow1.Size = New Global.System.Drawing.Size(6, 9)
			Me.lblShadow1.TabIndex = 6
			Me.lblShadow2.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left
			Me.lblShadow2.BackColor = Global.System.Drawing.Color.White
			Me.lblShadow2.Location = New Global.System.Drawing.Point(0, 190)
			Me.lblShadow2.Name = "lblShadow2"
			Me.lblShadow2.Size = New Global.System.Drawing.Size(9, 7)
			Me.lblShadow2.TabIndex = 5
			Me.txtDesc.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtDesc.Location = New Global.System.Drawing.Point(143, 90)
			Me.txtDesc.Multiline = True
			Me.txtDesc.Name = "txtDesc"
			Me.txtDesc.Size = New Global.System.Drawing.Size(398, 45)
			Me.txtDesc.TabIndex = 1007
			Me.Label19.AutoSize = True
			Me.Label19.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label19.Location = New Global.System.Drawing.Point(14, 96)
			Me.Label19.Name = "Label19"
			Me.Label19.Size = New Global.System.Drawing.Size(71, 15)
			Me.Label19.TabIndex = 1010
			Me.Label19.Text = "Description"
			Me.txtCode.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtCode.Location = New Global.System.Drawing.Point(143, 36)
			Me.txtCode.Name = "txtCode"
			Me.txtCode.[ReadOnly] = True
			Me.txtCode.Size = New Global.System.Drawing.Size(398, 21)
			Me.txtCode.TabIndex = 1005
			Me.Label18.AutoSize = True
			Me.Label18.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label18.Location = New Global.System.Drawing.Point(14, 39)
			Me.Label18.Name = "Label18"
			Me.Label18.Size = New Global.System.Drawing.Size(123, 15)
			Me.Label18.TabIndex = 1009
			Me.Label18.Text = "Store Location Code"
			Me.txtName.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.txtName.Location = New Global.System.Drawing.Point(143, 63)
			Me.txtName.Name = "txtName"
			Me.txtName.Size = New Global.System.Drawing.Size(398, 21)
			Me.txtName.TabIndex = 1006
			Me.Label9.AutoSize = True
			Me.Label9.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label9.Location = New Global.System.Drawing.Point(14, 66)
			Me.Label9.Name = "Label9"
			Me.Label9.Size = New Global.System.Drawing.Size(126, 15)
			Me.Label9.TabIndex = 1008
			Me.Label9.Text = "Store Location Name"
			Me.Label17.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label17.ForeColor = Global.System.Drawing.Color.Red
			Me.Label17.Location = New Global.System.Drawing.Point(5, 39)
			Me.Label17.Name = "Label17"
			Me.Label17.Size = New Global.System.Drawing.Size(11, 15)
			Me.Label17.TabIndex = 1011
			Me.Label17.Text = "*"
			Me.Label17.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.Label1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Global.System.Drawing.Color.Red
			Me.Label1.Location = New Global.System.Drawing.Point(5, 66)
			Me.Label1.Name = "Label1"
			Me.Label1.Size = New Global.System.Drawing.Size(11, 15)
			Me.Label1.TabIndex = 1012
			Me.Label1.Text = "*"
			Me.Label1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(7F, 15F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.DarkGray
			MyBase.ClientSize = New Global.System.Drawing.Size(563, 196)
			MyBase.Controls.Add(Me.pnlBorder)
			MyBase.Controls.Add(Me.lblShadow1)
			MyBase.Controls.Add(Me.lblShadow2)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedToolWindow
			MyBase.Name = "LocationDtls"
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Location Details"
			Me.pnlBorder.ResumeLayout(False)
			Me.pnlMain.ResumeLayout(False)
			Me.pnlMain.PerformLayout()
			Me.panelTitleBar.ResumeLayout(False)
			Me.panelTitleBar.PerformLayout()
			CType(Me.picFormIcon, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x0400020F RID: 527
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
