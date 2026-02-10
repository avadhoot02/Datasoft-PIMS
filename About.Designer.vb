Namespace Datasoft_PIMS
	' Token: 0x02000008 RID: 8
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public NotInheritable Partial Class About
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000020 RID: 32 RVA: 0x00002478 File Offset: 0x00000678
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

		' Token: 0x06000021 RID: 33 RVA: 0x000024C8 File Offset: 0x000006C8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.Datasoft_PIMS.About))
			Me.TextBoxDescription = New Global.System.Windows.Forms.Label()
			Me.LabelCompanyName = New Global.System.Windows.Forms.Label()
			Me.LabelCopyright = New Global.System.Windows.Forms.Label()
			Me.LabelAppVersion = New Global.System.Windows.Forms.Label()
			Me.LabelProductName = New Global.System.Windows.Forms.Label()
			Me.lableSysVersion = New Global.System.Windows.Forms.Label()
			MyBase.SuspendLayout()
			Me.TextBoxDescription.BackColor = Global.System.Drawing.Color.Transparent
			Me.TextBoxDescription.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.TextBoxDescription.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.TextBoxDescription.Location = New Global.System.Drawing.Point(32, 192)
			Me.TextBoxDescription.Margin = New Global.System.Windows.Forms.Padding(6, 0, 3, 0)
			Me.TextBoxDescription.Name = "TextBoxDescription"
			Me.TextBoxDescription.Size = New Global.System.Drawing.Size(336, 85)
			Me.TextBoxDescription.TabIndex = 10
			Me.TextBoxDescription.Text = componentResourceManager.GetString("TextBoxDescription.Text")
			Me.LabelCompanyName.BackColor = Global.System.Drawing.Color.Transparent
			Me.LabelCompanyName.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.LabelCompanyName.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.LabelCompanyName.Location = New Global.System.Drawing.Point(32, 166)
			Me.LabelCompanyName.Margin = New Global.System.Windows.Forms.Padding(6, 0, 3, 0)
			Me.LabelCompanyName.Name = "LabelCompanyName"
			Me.LabelCompanyName.Size = New Global.System.Drawing.Size(336, 21)
			Me.LabelCompanyName.TabIndex = 9
			Me.LabelCompanyName.Text = "Company Name"
			Me.LabelCompanyName.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.LabelCopyright.BackColor = Global.System.Drawing.Color.Transparent
			Me.LabelCopyright.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.LabelCopyright.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.LabelCopyright.Location = New Global.System.Drawing.Point(32, 140)
			Me.LabelCopyright.Margin = New Global.System.Windows.Forms.Padding(6, 0, 3, 0)
			Me.LabelCopyright.Name = "LabelCopyright"
			Me.LabelCopyright.Size = New Global.System.Drawing.Size(336, 21)
			Me.LabelCopyright.TabIndex = 8
			Me.LabelCopyright.Text = "Copyright"
			Me.LabelCopyright.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.LabelAppVersion.BackColor = Global.System.Drawing.Color.Transparent
			Me.LabelAppVersion.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.LabelAppVersion.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.LabelAppVersion.Location = New Global.System.Drawing.Point(32, 88)
			Me.LabelAppVersion.Margin = New Global.System.Windows.Forms.Padding(6, 0, 3, 0)
			Me.LabelAppVersion.Name = "LabelAppVersion"
			Me.LabelAppVersion.Size = New Global.System.Drawing.Size(336, 21)
			Me.LabelAppVersion.TabIndex = 7
			Me.LabelAppVersion.Text = "Application Version"
			Me.LabelAppVersion.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.LabelProductName.BackColor = Global.System.Drawing.Color.Transparent
			Me.LabelProductName.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.LabelProductName.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.LabelProductName.Location = New Global.System.Drawing.Point(32, 62)
			Me.LabelProductName.Margin = New Global.System.Windows.Forms.Padding(6, 0, 3, 0)
			Me.LabelProductName.Name = "LabelProductName"
			Me.LabelProductName.Size = New Global.System.Drawing.Size(336, 21)
			Me.LabelProductName.TabIndex = 6
			Me.LabelProductName.Text = "Product Name"
			Me.LabelProductName.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.lableSysVersion.BackColor = Global.System.Drawing.Color.Transparent
			Me.lableSysVersion.BorderStyle = Global.System.Windows.Forms.BorderStyle.Fixed3D
			Me.lableSysVersion.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lableSysVersion.Location = New Global.System.Drawing.Point(32, 114)
			Me.lableSysVersion.Margin = New Global.System.Windows.Forms.Padding(6, 0, 3, 0)
			Me.lableSysVersion.Name = "lableSysVersion"
			Me.lableSysVersion.Size = New Global.System.Drawing.Size(336, 21)
			Me.lableSysVersion.TabIndex = 11
			Me.lableSysVersion.Text = "System Version"
			Me.lableSysVersion.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.White
			Me.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			MyBase.ClientSize = New Global.System.Drawing.Size(400, 307)
			MyBase.Controls.Add(Me.lableSysVersion)
			MyBase.Controls.Add(Me.TextBoxDescription)
			MyBase.Controls.Add(Me.LabelCompanyName)
			MyBase.Controls.Add(Me.LabelCopyright)
			MyBase.Controls.Add(Me.LabelAppVersion)
			MyBase.Controls.Add(Me.LabelProductName)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedDialog
			MyBase.MaximizeBox = False
			MyBase.MinimizeBox = False
			MyBase.Name = "About"
			MyBase.Padding = New Global.System.Windows.Forms.Padding(9)
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "About Datasoft DGFT"
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x0400000B RID: 11
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
