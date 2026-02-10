Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports Datasoft_PIMS.My
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports WeifenLuo.WinFormsUI.Docking

Namespace Datasoft_PIMS
	' Token: 0x0200002A RID: 42
	Friend NotInheritable Module Designing
		' Token: 0x06000B15 RID: 2837 RVA: 0x00067744 File Offset: 0x00065944
		Public Sub SetTheme(oForm As Form)
			oForm.Icon = ResourceModule.imgFormIcon
			oForm.ForeColor = ResourceModule.LabelForecolor
			oForm.BackColor = ResourceModule.FormBackcolor
			Dim name As String = oForm.Name
			If Operators.CompareString(name, "MDIMain", False) = 0 Then
				Designing.SetMDIMainDesign()
			End If
			Dim flag As Boolean = Operators.CompareString(oForm.Name, "MDIMain", False) = 0
			If flag Then
			End If
			Dim list As List(Of Control) = New List(Of Control)()
			Try
				For Each control As Control In Designing.FindControlRecursive(list, oForm, GetType(Button))
					Dim flag2 As Boolean = Strings.InStr(control.Name, "skip_", CompareMethod.Binary) > 0
					If Not flag2 Then
						Dim flag3 As Boolean = TypeOf control Is Button
						If flag3 Then
							Designing.SetButton(control)
						Else
							Dim flag4 As Boolean = TypeOf control Is CheckBox
							If flag4 Then
								Designing.SetCheckBox(control)
							Else
								Dim flag5 As Boolean = TypeOf control Is ComboBox
								If flag5 Then
									Designing.SetComboBox(control)
								Else
									Dim flag6 As Boolean = TypeOf control Is DataGridView
									If flag6 Then
										Designing.SetDataGridView(control)
									Else
										Dim flag7 As Boolean = TypeOf control Is DateTimePicker
										If flag7 Then
											Designing.SetDateTimePicker(control)
										Else
											Dim flag8 As Boolean = TypeOf control Is DockPanel
											If flag8 Then
												Designing.SetDockPanel(control)
											Else
												Dim flag9 As Boolean = TypeOf control Is GroupBox
												If flag9 Then
													Designing.SetGroupBox(control)
												Else
													Dim flag10 As Boolean = TypeOf control Is Label
													If flag10 Then
														Designing.SetLabel(control)
													Else
														Dim flag11 As Boolean = TypeOf control Is LinkLabel
														If flag11 Then
															Designing.SetLinkLabel(control)
														Else
															Dim flag12 As Boolean = TypeOf control Is MenuStrip
															If flag12 Then
																Designing.SetMenuStrip(control)
															Else
																Dim flag13 As Boolean = TypeOf control Is Panel
																If flag13 Then
																	Designing.SetPanel(control)
																Else
																	Dim flag14 As Boolean = TypeOf control Is PictureBox
																	If flag14 Then
																		Designing.SetPictureBox(control)
																	Else
																		Dim flag15 As Boolean = TypeOf control Is TabControl
																		If flag15 Then
																			Designing.SetTabControl(control)
																		Else
																			Dim flag16 As Boolean = TypeOf control Is TextBox
																			If flag16 Then
																				Designing.SetTextBox(control)
																			End If
																		End If
																	End If
																End If
															End If
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				Next
			Finally
				Dim enumerator As List(Of Control).Enumerator
				CType(enumerator, IDisposable).Dispose()
			End Try
		End Sub

		' Token: 0x06000B16 RID: 2838 RVA: 0x000679D0 File Offset: 0x00065BD0
		Private Sub SetButton(ctrl As Control)
			Dim button As Button = CType(ctrl, Button)
			button.FlatStyle = FlatStyle.Flat
			button.FlatAppearance.BorderColor = ResourceModule.ButtonBorderColor
			button.FlatAppearance.BorderSize = 0
			button.FlatAppearance.MouseDownBackColor = Color.Transparent
			button.FlatAppearance.MouseOverBackColor = Color.Transparent
			button.BackgroundImageLayout = ImageLayout.Stretch
			Dim flag As Boolean = Strings.InStr(ctrl.Name, "hdr_", CompareMethod.Binary) > 0
			If Not flag Then
				Dim flag2 As Boolean = Strings.InStr(ctrl.Name, "form_btnClose", CompareMethod.Binary) > 0
				If flag2 Then
					button.BackColor = ResourceModule.ModalTitleBarBackColor
					button.FlatAppearance.BorderColor = ResourceModule.ModalTitleBarBackColor
					button.BackgroundImage = ResourceModule.imgdgvDelete
				Else
					Dim flag3 As Boolean = Strings.InStr(ctrl.Name, "arrow_btnBasic", CompareMethod.Binary) > 0
					If flag3 Then
						button.ForeColor = ResourceModule.ButtonForeColor
						Dim flag4 As Boolean = Operators.ConditionalCompareObjectEqual(button.Tag, "ArrowUp", False)
						If flag4 Then
							button.BackgroundImage = ResourceModule.imgArrowUp
						Else
							button.BackgroundImage = ResourceModule.imgArrowDown
						End If
					Else
						Dim flag5 As Boolean = Strings.InStr(ctrl.Name, "arrow_btnAdvance", CompareMethod.Binary) > 0
						If flag5 Then
							button.ForeColor = ResourceModule.ButtonForeColor
							Dim flag6 As Boolean = Operators.ConditionalCompareObjectEqual(button.Tag, "ArrowUp", False)
							If flag6 Then
								button.BackgroundImage = ResourceModule.imgArrowUp
							Else
								button.BackgroundImage = ResourceModule.imgArrowDown
							End If
						Else
							button.ForeColor = ResourceModule.ButtonForeColor
							button.BackgroundImage = ResourceModule.imgStandardButton
						End If
					End If
				End If
			End If
			Dim flag7 As Boolean = Strings.InStr(ctrl.Name, "sml_", CompareMethod.Binary) > 0
			If flag7 Then
				button.Font = New Font("MS Reference Sans Serif", 8F, FontStyle.Bold)
			Else
				Dim flag8 As Boolean = Strings.InStr(ctrl.Name, "arrow_", CompareMethod.Binary) > 0
				If flag8 Then
					button.Font = New Font("MS Reference Sans Serif", 8F, FontStyle.Regular)
				Else
					button.Font = New Font("MS Reference Sans Serif", 9F, FontStyle.Bold)
				End If
			End If
			Dim flag9 As Boolean = Strings.InStr(ctrl.Name, "hdr_", CompareMethod.Binary) > 0
			If Not flag9 Then
				Dim flag10 As Boolean = Strings.InStr(ctrl.Name, "form_btnClose", CompareMethod.Binary) > 0
				If flag10 Then
					AddHandler button.MouseDown, AddressOf Designing.formbutton_MouseDown
					AddHandler button.MouseUp, AddressOf Designing.formbutton_MouseUp
					AddHandler button.MouseEnter, AddressOf Designing.formbutton_MouseEnter
					AddHandler button.MouseLeave, AddressOf Designing.formbutton_MouseLeave
					AddHandler button.GotFocus, AddressOf Designing.formbutton_GotFocus
					AddHandler button.LostFocus, AddressOf Designing.formbutton_LostFocus
					AddHandler button.EnabledChanged, AddressOf Designing.formbutton_EnabledChanged
				Else
					Dim flag11 As Boolean = Strings.InStr(ctrl.Name, "arrow_", CompareMethod.Binary) > 0
					If flag11 Then
						AddHandler button.MouseDown, AddressOf Designing.btnArrow_MouseDown
						AddHandler button.MouseUp, AddressOf Designing.btnArrow_MouseUp
						AddHandler button.MouseEnter, AddressOf Designing.btnArrow_MouseEnter
						AddHandler button.MouseLeave, AddressOf Designing.btnArrow_MouseLeave
					Else
						AddHandler button.MouseDown, AddressOf Designing.Standard_MouseDown
						AddHandler button.MouseUp, AddressOf Designing.Standard_MouseUp
						AddHandler button.MouseEnter, AddressOf Designing.Standard_MouseEnter
						AddHandler button.MouseLeave, AddressOf Designing.Standard_MouseLeave
						AddHandler button.GotFocus, AddressOf Designing.Standard_GotFocus
						AddHandler button.LostFocus, AddressOf Designing.Standard_LostFocus
					End If
				End If
			End If
		End Sub

		' Token: 0x06000B17 RID: 2839 RVA: 0x00067D92 File Offset: 0x00065F92
		Private Sub SetCheckBox(ctrl As Control)
			ctrl.ForeColor = ResourceModule.LabelForecolor
		End Sub

		' Token: 0x06000B18 RID: 2840 RVA: 0x00067DA1 File Offset: 0x00065FA1
		Private Sub SetComboBox(ctrl As Control)
			ctrl.ForeColor = ResourceModule.LabelForecolor
		End Sub

		' Token: 0x06000B19 RID: 2841 RVA: 0x00067DB0 File Offset: 0x00065FB0
		Private Sub SetDataGridView(ctrl As Control)
			Dim dataGridView As DataGridView = CType(ctrl, DataGridView)
			dataGridView.BackgroundColor = ResourceModule.dgvBackgroundColor
			dataGridView.EnableHeadersVisualStyles = False
			dataGridView.ColumnHeadersDefaultCellStyle.BackColor = ResourceModule.dgvColumnHeadersDefaultCellStyleBackColor
			dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = ResourceModule.dgvColumnHeadersDefaultCellStyleForeColor
			dataGridView.RowHeadersDefaultCellStyle.BackColor = ResourceModule.dgvRowHeadersDefaultCellStyleBackColor
			dataGridView.RowHeadersDefaultCellStyle.ForeColor = ResourceModule.dgvRowHeadersDefaultCellStyleForeColor
			dataGridView.RowsDefaultCellStyle.SelectionBackColor = ResourceModule.dgvRowsDefaultCellStyleSelectionBackColor
			dataGridView.RowsDefaultCellStyle.SelectionForeColor = ResourceModule.dgvRowsDefaultCellStyleSelectionForeColor
			dataGridView.AlternatingRowsDefaultCellStyle.BackColor = ResourceModule.dgvAlternatingRowsDefaultCellStyleBackColor
			dataGridView.RowTemplate.Height = 25
			Dim num As Integer = dataGridView.ColumnCount - 1
			For i As Integer = 0 To num
				Dim name As String = dataGridView.Columns(i).[GetType]().Name
				If Operators.CompareString(name, "DataGridViewImageColumn", False) = 0 Then
					Dim dataGridViewImageColumn As DataGridViewImageColumn = CType(dataGridView.Columns(i), DataGridViewImageColumn)
					Dim flag As Boolean = Strings.InStr(dataGridViewImageColumn.Name, "btnDelete_", CompareMethod.Binary) > 0
					If flag Then
						dataGridViewImageColumn.Image = ResourceModule.imgdgvDelete
					Else
						Dim flag2 As Boolean = Strings.InStr(dataGridViewImageColumn.Name, "btnDownload_", CompareMethod.Binary) > 0
						If flag2 Then
							dataGridViewImageColumn.Image = ResourceModule.imgdgvDownload
						End If
					End If
				End If
			Next
			AddHandler dataGridView.CellMouseDown, AddressOf Designing.dgv_CellMouseDown
			AddHandler dataGridView.CellMouseUp, AddressOf Designing.dgv_CellMouseUp
			AddHandler dataGridView.CellMouseEnter, AddressOf Designing.dgv_CellMouseEnter
			AddHandler dataGridView.CellMouseLeave, AddressOf Designing.dgv_CellMouseLeave
		End Sub

		' Token: 0x06000B1A RID: 2842 RVA: 0x00067F58 File Offset: 0x00066158
		Private Sub SetDateTimePicker(ctrl As Control)
			ctrl.ForeColor = ResourceModule.LabelForecolor
		End Sub

		' Token: 0x06000B1B RID: 2843 RVA: 0x00067F68 File Offset: 0x00066168
		Private Sub SetDockPanel(ctrl As Control)
			Dim dockPanel As DockPanel = CType(ctrl, DockPanel)
			dockPanel.ActiveAutoHideContent = Nothing
			dockPanel.SuspendLayout(True)
			dockPanel.ResumeLayout(True, True)
			dockPanel.ShowDocumentIcon = True
		End Sub

		' Token: 0x06000B1C RID: 2844 RVA: 0x00067F9E File Offset: 0x0006619E
		Private Sub SetGroupBox(ctrl As Control)
			ctrl.ForeColor = ResourceModule.LabelForecolor
		End Sub

		' Token: 0x06000B1D RID: 2845 RVA: 0x00067FB0 File Offset: 0x000661B0
		Private Sub SetLabel(ctrl As Control)
			ctrl.ForeColor = ResourceModule.LabelForecolor
			Dim flag As Boolean = Operators.CompareString(ctrl.Text, "*", False) = 0
			If flag Then
				ctrl.ForeColor = Color.Red
			End If
			Dim flag2 As Boolean = Strings.InStr(ctrl.Name.ToString(), "tab_lbl", CompareMethod.Binary) > 0
			If flag2 Then
				ctrl.BackColor = ResourceModule.TablabelBackColor
			End If
		End Sub

		' Token: 0x06000B1E RID: 2846 RVA: 0x0006801B File Offset: 0x0006621B
		Private Sub SetLinkLabel(ctrl As Control)
			ctrl.ForeColor = ResourceModule.LabelForecolor
		End Sub

		' Token: 0x06000B1F RID: 2847 RVA: 0x0006802C File Offset: 0x0006622C
		Private Sub SetMenuStrip(ctrl As Control)
			Dim menuStrip As MenuStrip = CType(ctrl, MenuStrip)
			menuStrip.Renderer = New BrowserMenuRenderer()
			ctrl.ForeColor = ResourceModule.LabelForecolor
			Dim menuStrip2 As MenuStrip = CType(ctrl, MenuStrip)
			Try
				For Each obj As Object In menuStrip2.Items
					Dim toolStripMenuItem As ToolStripMenuItem = CType(obj, ToolStripMenuItem)
					Dim text As String = toolStripMenuItem.Text
					If Operators.CompareString(text, "Home", False) <> 0 AndAlso Operators.CompareString(text, "Config", False) <> 0 AndAlso Operators.CompareString(text, "Logout", False) <> 0 AndAlso Operators.CompareString(text, "|", False) <> 0 Then
					End If
					Try
						For Each obj2 As Object In toolStripMenuItem.DropDownItems
							Dim toolStripMenuItem2 As ToolStripMenuItem = CType(obj2, ToolStripMenuItem)
							Dim text2 As String = toolStripMenuItem2.Text
							toolStripMenuItem2.BackgroundImage = ResourceModule.imgMenu
							toolStripMenuItem2.ForeColor = ResourceModule.LabelForecolor
							Try
								For Each obj3 As Object In toolStripMenuItem2.DropDownItems
									Dim toolStripMenuItem3 As ToolStripMenuItem = CType(obj3, ToolStripMenuItem)
									Dim text3 As String = toolStripMenuItem3.Text
									toolStripMenuItem3.BackgroundImage = ResourceModule.imgMenu
									toolStripMenuItem3.ForeColor = ResourceModule.LabelForecolor
								Next
							Finally
								Dim enumerator3 As IEnumerator
								If TypeOf enumerator3 Is IDisposable Then
									TryCast(enumerator3, IDisposable).Dispose()
								End If
							End Try
						Next
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06000B20 RID: 2848 RVA: 0x00068214 File Offset: 0x00066414
		Private Sub SetPanel(ctrl As Control)
			Dim flag As Boolean = Strings.InStr(ctrl.Name, "panelTitleBar", CompareMethod.Binary) > 0
			If flag Then
				ctrl.BackColor = ResourceModule.ModalTitleBarBackColor
			End If
		End Sub

		' Token: 0x06000B21 RID: 2849 RVA: 0x00068248 File Offset: 0x00066448
		Private Sub SetPictureBox(ctrl As Control)
			Dim pictureBox As PictureBox = CType(ctrl, PictureBox)
			Dim flag As Boolean = Strings.InStr(pictureBox.Name, "picFormIcon", CompareMethod.Binary) > 0
			If flag Then
				pictureBox.Padding = New Padding(2)
				pictureBox.Image = ResourceModule.imgFormIconPic
			End If
		End Sub

		' Token: 0x06000B22 RID: 2850 RVA: 0x00068290 File Offset: 0x00066490
		Private Sub SetTabControl(ctrl As Control)
			Dim tabControl As TabControl = CType(ctrl, TabControl)
			Dim flag As Boolean = Strings.InStr(tabControl.Name, "theme_tc", CompareMethod.Binary) > 0
			If flag Then
				tabControl.DrawMode = TabDrawMode.OwnerDrawFixed
				AddHandler tabControl.DrawItem, AddressOf Designing.Tab_Control_DrawItem
			End If
		End Sub

		' Token: 0x06000B23 RID: 2851 RVA: 0x000682DA File Offset: 0x000664DA
		Private Sub SetTextBox(ctrl As Control)
			ctrl.ForeColor = ResourceModule.LabelForecolor
		End Sub

		' Token: 0x06000B24 RID: 2852 RVA: 0x000682EC File Offset: 0x000664EC
		Public Function FindControlRecursive(list As List(Of Control), parent As Control, ctrlType As Type) As List(Of Control)
			Dim flag As Boolean = parent Is Nothing
			Dim list2 As List(Of Control)
			If flag Then
				list2 = list
			Else
				list.Add(parent)
				Try
					For Each obj As Object In parent.Controls
						Dim control As Control = CType(obj, Control)
						Designing.FindControlRecursive(list, control, ctrlType)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				list2 = list
			End If
			Return list2
		End Function

		' Token: 0x06000B25 RID: 2853 RVA: 0x0006836C File Offset: 0x0006656C
		Public Function MouseIsOverControl(c As Control) As Boolean
			Return c.ClientRectangle.Contains(c.PointToClient(Control.MousePosition))
		End Function

		' Token: 0x06000B26 RID: 2854 RVA: 0x00068398 File Offset: 0x00066598
		Private Sub SetMDIMainDesign()
			MyProject.Forms.MDIMain.pnlBar.BackgroundImage = ResourceModule.imgMDITitle
			MyProject.Forms.MDIMain.pnlHeader.BackgroundImage = ResourceModule.imgMDIShadowBottom
			MyProject.Forms.MDIMain.StatusStrip1.BackgroundImage = ResourceModule.imgMDIShadowTop
			MyProject.Forms.MDIMain.PicLogo.Image = ResourceModule.imgMDICompanyLogo
			MyProject.Forms.MDIMain.picSSDatacode.Image = ResourceModule.imgSSDatacode
			MyProject.Forms.MDIMain.picProfile.Image = ResourceModule.imgMDIProfile
			MyProject.Forms.MDIMain.pnlProfile.BackgroundImage = ResourceModule.imgMDIProfilePanel
			MyProject.Forms.MDIMain.pnlLogin.BackgroundImage = ResourceModule.imgMDILoginPanel
			MyProject.Forms.MDIMain.picUser.BackgroundImage = ResourceModule.imgMDIUser
			MyProject.Forms.MDIMain.picPwd.BackgroundImage = ResourceModule.imgMDIPwd
			MyProject.Forms.MDIMain.skip_btnShow.BackgroundImage = ResourceModule.imgMDIReveal
			MyProject.Forms.MDIMain.skip_btnShow.FlatAppearance.BorderColor = Color.White
			MyProject.Forms.MDIMain.skip_btnShow.FlatAppearance.BorderSize = 0
			AddHandler MyProject.Forms.MDIMain.picProfile.MouseEnter, AddressOf Designing.picProfile_MouseEnter
			AddHandler MyProject.Forms.MDIMain.picProfile.MouseLeave, AddressOf Designing.picProfile_MouseLeave
			AddHandler MyProject.Forms.MDIMain.PicLogo.MouseEnter, AddressOf Designing.PicLogo_MouseEnter
			AddHandler MyProject.Forms.MDIMain.PicLogo.MouseLeave, AddressOf Designing.PicLogo_MouseLeave
		End Sub

		' Token: 0x06000B27 RID: 2855 RVA: 0x00068584 File Offset: 0x00066784
		Private Sub picProfile_MouseEnter(sender As Object, e As EventArgs)
			Dim pictureBox As PictureBox = CType(sender, PictureBox)
			pictureBox.Image = ResourceModule.imgMDIProfileGif
		End Sub

		' Token: 0x06000B28 RID: 2856 RVA: 0x000685A8 File Offset: 0x000667A8
		Private Sub picProfile_MouseLeave(sender As Object, e As EventArgs)
			Dim pictureBox As PictureBox = CType(sender, PictureBox)
			pictureBox.Image = ResourceModule.imgMDIProfile
		End Sub

		' Token: 0x06000B29 RID: 2857 RVA: 0x000685CC File Offset: 0x000667CC
		Private Sub PicLogo_MouseEnter(sender As Object, e As EventArgs)
			Dim pictureBox As PictureBox = CType(sender, PictureBox)
			pictureBox.Image = ResourceModule.imgMDICompanyLogoGif
		End Sub

		' Token: 0x06000B2A RID: 2858 RVA: 0x000685F0 File Offset: 0x000667F0
		Private Sub PicLogo_MouseLeave(sender As Object, e As EventArgs)
			Dim pictureBox As PictureBox = CType(sender, PictureBox)
			pictureBox.Image = ResourceModule.imgMDICompanyLogo
		End Sub

		' Token: 0x06000B2B RID: 2859 RVA: 0x00068614 File Offset: 0x00066814
		Private Sub Standard_MouseDown(sender As Object, e As MouseEventArgs)
			Dim button As Button = CType(sender, Button)
			button.BackgroundImage = ResourceModule.imgStandardButtonClick
			Dim flag As Boolean = Strings.InStr(button.Name, "sml_", CompareMethod.Binary) = 0
			If flag Then
				button.Padding = New Padding(4, 4, 0, 0)
			Else
				button.Padding = New Padding(2, 2, 0, 0)
			End If
		End Sub

		' Token: 0x06000B2C RID: 2860 RVA: 0x00068674 File Offset: 0x00066874
		Private Sub Standard_MouseUp(sender As Object, e As MouseEventArgs)
			Try
				Dim button As Button = CType(sender, Button)
				button.BackgroundImage = ResourceModule.imgStandardButtonHover
				button.Padding = New Padding(0, 0, 0, 0)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000B2D RID: 2861 RVA: 0x000686C8 File Offset: 0x000668C8
		Private Sub Standard_MouseEnter(sender As Object, e As EventArgs)
			Dim button As Button = CType(sender, Button)
			button.BackgroundImage = ResourceModule.imgStandardButtonHover
			button.Padding = New Padding(0, 0, 0, 0)
		End Sub

		' Token: 0x06000B2E RID: 2862 RVA: 0x000686FC File Offset: 0x000668FC
		Private Sub Standard_MouseLeave(sender As Object, e As EventArgs)
			Dim button As Button = CType(sender, Button)
			button.BackgroundImage = ResourceModule.imgStandardButton
			button.Padding = New Padding(0, 0, 0, 0)
		End Sub

		' Token: 0x06000B2F RID: 2863 RVA: 0x00068730 File Offset: 0x00066930
		Private Sub Standard_GotFocus(sender As Object, e As EventArgs)
			Dim button As Button = CType(sender, Button)
			button.BackgroundImage = ResourceModule.imgStandardButtonHover
		End Sub

		' Token: 0x06000B30 RID: 2864 RVA: 0x00068754 File Offset: 0x00066954
		Private Sub Standard_LostFocus(sender As Object, e As EventArgs)
			Dim button As Button = CType(sender, Button)
			button.BackgroundImage = ResourceModule.imgStandardButton
			button.Padding = New Padding(0, 0, 0, 0)
		End Sub

		' Token: 0x06000B31 RID: 2865 RVA: 0x00068788 File Offset: 0x00066988
		Private Sub btnArrow_MouseDown(sender As Object, e As MouseEventArgs)
			Dim button As Button = CType(sender, Button)
			Dim text As String = button.Tag.ToString()
			If Operators.CompareString(text, "ArrowUp", False) <> 0 Then
				If Operators.CompareString(text, "ArrowDown", False) = 0 Then
					button.BackgroundImage = ResourceModule.imgArrowDownClick
				End If
			Else
				button.BackgroundImage = ResourceModule.imgArrowUpClick
			End If
		End Sub

		' Token: 0x06000B32 RID: 2866 RVA: 0x000687E8 File Offset: 0x000669E8
		Private Sub btnArrow_MouseUp(sender As Object, e As MouseEventArgs)
			Dim button As Button = CType(sender, Button)
			Dim text As String = button.Tag.ToString()
			If Operators.CompareString(text, "ArrowUp", False) <> 0 Then
				If Operators.CompareString(text, "ArrowDown", False) = 0 Then
					button.BackgroundImage = ResourceModule.imgArrowDownHover
				End If
			Else
				button.BackgroundImage = ResourceModule.imgArrowUpHover
			End If
		End Sub

		' Token: 0x06000B33 RID: 2867 RVA: 0x00068848 File Offset: 0x00066A48
		Private Sub btnArrow_MouseEnter(sender As Object, e As EventArgs)
			Dim button As Button = CType(sender, Button)
			Dim text As String = button.Tag.ToString()
			If Operators.CompareString(text, "ArrowUp", False) <> 0 Then
				If Operators.CompareString(text, "ArrowDown", False) = 0 Then
					button.BackgroundImage = ResourceModule.imgArrowDownHover
				End If
			Else
				button.BackgroundImage = ResourceModule.imgArrowUpHover
			End If
		End Sub

		' Token: 0x06000B34 RID: 2868 RVA: 0x000688A8 File Offset: 0x00066AA8
		Private Sub btnArrow_MouseLeave(sender As Object, e As EventArgs)
			Dim button As Button = CType(sender, Button)
			Dim text As String = button.Tag.ToString()
			If Operators.CompareString(text, "ArrowUp", False) <> 0 Then
				If Operators.CompareString(text, "ArrowDown", False) = 0 Then
					button.BackgroundImage = ResourceModule.imgArrowDown
				End If
			Else
				button.BackgroundImage = ResourceModule.imgArrowUp
			End If
		End Sub

		' Token: 0x06000B35 RID: 2869 RVA: 0x00068908 File Offset: 0x00066B08
		Private Sub formbutton_MouseDown(sender As Object, e As MouseEventArgs)
			Dim button As Button = CType(sender, Button)
			Dim flag As Boolean = Operators.CompareString(button.Name, "form_btnClose", False) = 0
			If flag Then
				button.BackgroundImage = ResourceModule.imgdgvDeleteClick
			End If
		End Sub

		' Token: 0x06000B36 RID: 2870 RVA: 0x00068944 File Offset: 0x00066B44
		Private Sub formbutton_MouseUp(sender As Object, e As MouseEventArgs)
			Try
				Dim button As Button = CType(sender, Button)
				Dim flag As Boolean = Operators.CompareString(button.Name, "form_btnClose", False) = 0
				If flag Then
					button.BackgroundImage = ResourceModule.imgdgvDeleteHover
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000B37 RID: 2871 RVA: 0x000689A4 File Offset: 0x00066BA4
		Private Sub formbutton_MouseEnter(sender As Object, e As EventArgs)
			Dim button As Button = CType(sender, Button)
			Dim flag As Boolean = Operators.CompareString(button.Name, "form_btnClose", False) = 0
			If flag Then
				button.BackgroundImage = ResourceModule.imgdgvDeleteHover
			End If
		End Sub

		' Token: 0x06000B38 RID: 2872 RVA: 0x000689E0 File Offset: 0x00066BE0
		Private Sub formbutton_MouseLeave(sender As Object, e As EventArgs)
			Dim button As Button = CType(sender, Button)
			Dim flag As Boolean = Operators.CompareString(button.Name, "form_btnClose", False) = 0
			If flag Then
				button.BackgroundImage = ResourceModule.imgdgvDelete
			End If
		End Sub

		' Token: 0x06000B39 RID: 2873 RVA: 0x00068A1C File Offset: 0x00066C1C
		Private Sub formbutton_GotFocus(sender As Object, e As EventArgs)
			Dim button As Button = CType(sender, Button)
			Dim flag As Boolean = Operators.CompareString(button.Name, "form_btnClose", False) = 0
			If flag Then
				button.BackgroundImage = ResourceModule.imgdgvDeleteHover
			End If
		End Sub

		' Token: 0x06000B3A RID: 2874 RVA: 0x00068A58 File Offset: 0x00066C58
		Private Sub formbutton_LostFocus(sender As Object, e As EventArgs)
			Dim button As Button = CType(sender, Button)
			Dim flag As Boolean = Operators.CompareString(button.Name, "form_btnClose", False) = 0
			If flag Then
				button.BackgroundImage = ResourceModule.imgdgvDelete
			End If
		End Sub

		' Token: 0x06000B3B RID: 2875 RVA: 0x00068A94 File Offset: 0x00066C94
		Private Sub formbutton_EnabledChanged(sender As Object, e As EventArgs)
			Dim button As Button = CType(sender, Button)
			Dim enabled As Boolean = button.Enabled
			If enabled Then
				If enabled Then
					Dim flag As Boolean = Operators.CompareString(button.Name, "form_btnClose", False) = 0
					If flag Then
						button.BackgroundImage = ResourceModule.imgdgvDelete
					End If
				End If
			Else
				Dim flag2 As Boolean = Operators.CompareString(button.Name, "form_btnClose", False) = 0
				If flag2 Then
					button.BackgroundImage = ResourceModule.imgdgvDeleteDisable
				End If
			End If
		End Sub

		' Token: 0x06000B3C RID: 2876 RVA: 0x00068B10 File Offset: 0x00066D10
		Private Sub dgv_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs)
			Dim dataGridView As DataGridView = CType(sender, DataGridView)
			Dim flag As Boolean = (dataGridView.Rows.Count > 0) And (e.RowIndex > -1) And (e.ColumnIndex > -1)
			If flag Then
				Dim flag2 As Boolean = Strings.InStr(dataGridView.Columns(e.ColumnIndex).Name, "btnDelete_", CompareMethod.Binary) > 0
				If flag2 Then
					dataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ResourceModule.imgdgvDeleteClick
				Else
					Dim flag3 As Boolean = Strings.InStr(dataGridView.Columns(e.ColumnIndex).Name, "btnDownload_", CompareMethod.Binary) > 0
					If flag3 Then
						dataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ResourceModule.imgdgvDownloadClick
					End If
				End If
			End If
		End Sub

		' Token: 0x06000B3D RID: 2877 RVA: 0x00068BFC File Offset: 0x00066DFC
		Private Sub dgv_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs)
			Dim dataGridView As DataGridView = CType(sender, DataGridView)
			Dim flag As Boolean = (dataGridView.Rows.Count > e.RowIndex) And (e.RowIndex > -1) And (e.ColumnIndex > -1)
			If flag Then
				Dim flag2 As Boolean = Strings.InStr(dataGridView.Columns(e.ColumnIndex).Name, "btnDelete_", CompareMethod.Binary) > 0
				If flag2 Then
					dataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ResourceModule.imgdgvDelete
				Else
					Dim flag3 As Boolean = Strings.InStr(dataGridView.Columns(e.ColumnIndex).Name, "btnDownload_", CompareMethod.Binary) > 0
					If flag3 Then
						dataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ResourceModule.imgdgvDownload
					End If
				End If
			End If
		End Sub

		' Token: 0x06000B3E RID: 2878 RVA: 0x00068CF0 File Offset: 0x00066EF0
		Private Sub dgv_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs)
			Dim dataGridView As DataGridView = CType(sender, DataGridView)
			Dim flag As Boolean = (dataGridView.Rows.Count > 0) And (e.RowIndex > -1) And (e.ColumnIndex > -1)
			If flag Then
				Dim flag2 As Boolean = Strings.InStr(dataGridView.Columns(e.ColumnIndex).Name, "btnDelete_", CompareMethod.Binary) > 0
				If flag2 Then
					dataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ResourceModule.imgdgvDeleteHover
				Else
					Dim flag3 As Boolean = Strings.InStr(dataGridView.Columns(e.ColumnIndex).Name, "btnDownload_", CompareMethod.Binary) > 0
					If flag3 Then
						dataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ResourceModule.imgdgvDownloadHover
					End If
				End If
			End If
		End Sub

		' Token: 0x06000B3F RID: 2879 RVA: 0x00068DDC File Offset: 0x00066FDC
		Private Sub dgv_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs)
			Dim dataGridView As DataGridView = CType(sender, DataGridView)
			Dim flag As Boolean = (dataGridView.Rows.Count > 0) And (e.RowIndex > -1) And (e.ColumnIndex > -1)
			If flag Then
				Dim flag2 As Boolean = Strings.InStr(dataGridView.Columns(e.ColumnIndex).Name, "btnDelete_", CompareMethod.Binary) > 0
				If flag2 Then
					dataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ResourceModule.imgdgvDelete
				Else
					Dim flag3 As Boolean = Strings.InStr(dataGridView.Columns(e.ColumnIndex).Name, "btnDownload_", CompareMethod.Binary) > 0
					If flag3 Then
						dataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = ResourceModule.imgdgvDownload
					End If
				End If
			End If
		End Sub

		' Token: 0x06000B40 RID: 2880 RVA: 0x00068EC8 File Offset: 0x000670C8
		Private Sub Tab_Control_DrawItem(sender As Object, e As DrawItemEventArgs)
			Dim tabControl As TabControl = CType(sender, TabControl)
			Dim graphics As Graphics = e.Graphics
			Dim tabPage As TabPage = tabControl.TabPages(e.Index)
			Dim stringFormat As StringFormat = New StringFormat()
			Dim rectangleF As RectangleF = New RectangleF(CSng(e.Bounds.X), CSng((e.Bounds.Y + 2)), CSng(e.Bounds.Width), CSng((e.Bounds.Height - 2)))
			stringFormat.Alignment = StringAlignment.Center
			stringFormat.LineAlignment = StringAlignment.Center
			Dim text As String = Strings.Trim(tabPage.Text)
			Dim flag As Boolean = tabControl.SelectedIndex = e.Index
			If flag Then
				Dim brush As Brush = New SolidBrush(ResourceModule.SelectedTabBackColor)
				graphics.FillRectangle(brush, e.Bounds)
				brush = New SolidBrush(ResourceModule.SelectedTabForeColor)
				graphics.DrawString(text, tabControl.Font, brush, rectangleF, stringFormat)
			Else
				Dim brush As Brush = New SolidBrush(ResourceModule.UnselectedTabBackColor)
				graphics.FillRectangle(brush, e.Bounds)
				brush = New SolidBrush(ResourceModule.UnselectedTabForeColor)
				graphics.DrawString(text, tabControl.Font, brush, rectangleF, stringFormat)
			End If
		End Sub

		' Token: 0x040004AC RID: 1196
		Private iScale As Integer = 7

		' Token: 0x040004AD RID: 1197
		Private iReposition As Integer = CInt(Math.Round(CDbl(Designing.iScale) / 2.0))
	End Module
End Namespace
