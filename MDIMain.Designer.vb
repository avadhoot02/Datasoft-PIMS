
Namespace Datasoft_PIMS
	' Token: 0x02000023 RID: 35
	Partial Public Class MDIMain
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060007E1 RID: 2017 RVA: 0x000468F0 File Offset: 0x00044AF0
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

		' Token: 0x060007E2 RID: 2018 RVA: 0x00046940 File Offset: 0x00044B40
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim dockPanelSkin As Global.WeifenLuo.WinFormsUI.Docking.DockPanelSkin = New Global.WeifenLuo.WinFormsUI.Docking.DockPanelSkin()
			Dim autoHideStripSkin As Global.WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin = New Global.WeifenLuo.WinFormsUI.Docking.AutoHideStripSkin()
			Dim dockPanelGradient As Global.WeifenLuo.WinFormsUI.Docking.DockPanelGradient = New Global.WeifenLuo.WinFormsUI.Docking.DockPanelGradient()
			Dim tabGradient As Global.WeifenLuo.WinFormsUI.Docking.TabGradient = New Global.WeifenLuo.WinFormsUI.Docking.TabGradient()
			Dim dockPaneStripSkin As Global.WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin = New Global.WeifenLuo.WinFormsUI.Docking.DockPaneStripSkin()
			Dim dockPaneStripGradient As Global.WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient = New Global.WeifenLuo.WinFormsUI.Docking.DockPaneStripGradient()
			Dim tabGradient2 As Global.WeifenLuo.WinFormsUI.Docking.TabGradient = New Global.WeifenLuo.WinFormsUI.Docking.TabGradient()
			Dim dockPanelGradient2 As Global.WeifenLuo.WinFormsUI.Docking.DockPanelGradient = New Global.WeifenLuo.WinFormsUI.Docking.DockPanelGradient()
			Dim tabGradient3 As Global.WeifenLuo.WinFormsUI.Docking.TabGradient = New Global.WeifenLuo.WinFormsUI.Docking.TabGradient()
			Dim dockPaneStripToolWindowGradient As Global.WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient = New Global.WeifenLuo.WinFormsUI.Docking.DockPaneStripToolWindowGradient()
			Dim tabGradient4 As Global.WeifenLuo.WinFormsUI.Docking.TabGradient = New Global.WeifenLuo.WinFormsUI.Docking.TabGradient()
			Dim tabGradient5 As Global.WeifenLuo.WinFormsUI.Docking.TabGradient = New Global.WeifenLuo.WinFormsUI.Docking.TabGradient()
			Dim dockPanelGradient3 As Global.WeifenLuo.WinFormsUI.Docking.DockPanelGradient = New Global.WeifenLuo.WinFormsUI.Docking.DockPanelGradient()
			Dim tabGradient6 As Global.WeifenLuo.WinFormsUI.Docking.TabGradient = New Global.WeifenLuo.WinFormsUI.Docking.TabGradient()
			Dim tabGradient7 As Global.WeifenLuo.WinFormsUI.Docking.TabGradient = New Global.WeifenLuo.WinFormsUI.Docking.TabGradient()
			Me.pnlBar = New Global.System.Windows.Forms.Panel()
			Me.skip_lblSession = New Global.System.Windows.Forms.Label()
			Me.skip_lblMemory = New Global.System.Windows.Forms.Label()
			Me.skip_lblSessionLabel = New Global.System.Windows.Forms.Label()
			Me.pnlHeader = New Global.System.Windows.Forms.Panel()
			Me.skip_lblSanbox = New Global.System.Windows.Forms.Label()
			Me.picProfile = New Global.System.Windows.Forms.PictureBox()
			Me.mnuMain = New Global.System.Windows.Forms.MenuStrip()
			Me.mnuMasters = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuProduct = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuProductBOM = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuBOMApproval = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuLocation = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuVendor = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuUser = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuUserGroup = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuReq = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuPRCreation = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuPRModification = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuPRApproval = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuPRCostApproval = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuPurchase = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuPOCreation = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuPOModification = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuPOApproval = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuPOCostApproval = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuPOPrinting = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuPOAmendment = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuInventory = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuGRN = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuReceipt = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuPO = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuBMR = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuReturn = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuGRNModification = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuReceipt_Modify = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuPO_Modify = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuBMR_Modify = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuReturn_Modify = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuGRNCancellation = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuGRNApproval = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuReceipt_Approval = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuPO_Approval = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuBMR_Approval = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuReturn_Approval = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuGRNPrinting = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuQCEntry = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuQCRelease = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuQARelease = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuConcentration = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuVendorReturn = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuLocationMapping = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuMaterialRequest = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuPicking = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuQAApproval = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuMaterialIssue = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuDispose = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuMISReports = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuPRReport = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuPOReport = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuGRNReport = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuRequestReport = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuProductBOMReport = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuStockReport = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuConsumptionReport = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuClosingStockReport = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuQuarentineStockReport = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuActivityLog = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuSettings = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuChangePassword = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuEmailAlertSettings = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuPRApproverList = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuPOApproverList = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuEmailTest = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuTest = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuStockUpload = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.mnuAbout = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.PicLogo = New Global.System.Windows.Forms.PictureBox()
			Me.StatusStrip1 = New Global.System.Windows.Forms.StatusStrip()
			Me.ToolStripStatusLabel4 = New Global.System.Windows.Forms.ToolStripStatusLabel()
			Me.ToolStripStatusLabel1 = New Global.System.Windows.Forms.ToolStripStatusLabel()
			Me.gslblServer = New Global.System.Windows.Forms.ToolStripStatusLabel()
			Me.ToolStripStatusLabel2 = New Global.System.Windows.Forms.ToolStripStatusLabel()
			Me.ToolStripStatusLabel3 = New Global.System.Windows.Forms.ToolStripStatusLabel()
			Me.gslblDatabase = New Global.System.Windows.Forms.ToolStripStatusLabel()
			Me.ToolStripStatusLabel5 = New Global.System.Windows.Forms.ToolStripStatusLabel()
			Me.ToolStripStatusLabel7 = New Global.System.Windows.Forms.ToolStripStatusLabel()
			Me.ToolStripStatusLabel6 = New Global.System.Windows.Forms.ToolStripStatusLabel()
			Me.picSSDatacode = New Global.System.Windows.Forms.PictureBox()
			Me.DockPanel = New Global.WeifenLuo.WinFormsUI.Docking.DockPanel()
			Me.lblLogin = New Global.System.Windows.Forms.Label()
			Me.pnlLogin = New Global.System.Windows.Forms.Panel()
			Me.skip_btnShow = New Global.System.Windows.Forms.Button()
			Me.picPwd = New Global.System.Windows.Forms.PictureBox()
			Me.picUser = New Global.System.Windows.Forms.PictureBox()
			Me.btnOK = New Global.System.Windows.Forms.Button()
			Me.skip_txtPass = New Global.System.Windows.Forms.TextBox()
			Me.skip_txtUser = New Global.System.Windows.Forms.TextBox()
			Me.pnlProfile = New Global.System.Windows.Forms.Panel()
			Me.gslblDepartment = New Global.System.Windows.Forms.Label()
			Me.gslblReportingTo = New Global.System.Windows.Forms.Label()
			Me.gslblManager = New Global.System.Windows.Forms.Label()
			Me.sml_btnSignOut = New Global.System.Windows.Forms.Button()
			Me.gslblPlant = New Global.System.Windows.Forms.Label()
			Me.gslblCompany = New Global.System.Windows.Forms.Label()
			Me.gslblUser = New Global.System.Windows.Forms.Label()
			Me.profileTimer = New Global.System.Windows.Forms.Timer(Me.components)
			Me.MemoryTimer = New Global.System.Windows.Forms.Timer(Me.components)
			Me.pnlBar.SuspendLayout()
			Me.pnlHeader.SuspendLayout()
			CType(Me.picProfile, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.mnuMain.SuspendLayout()
			CType(Me.PicLogo, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.StatusStrip1.SuspendLayout()
			CType(Me.picSSDatacode, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlLogin.SuspendLayout()
			CType(Me.picPwd, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.picUser, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlProfile.SuspendLayout()
			MyBase.SuspendLayout()
			Me.pnlBar.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.pnlBar.Controls.Add(Me.skip_lblSession)
			Me.pnlBar.Controls.Add(Me.skip_lblMemory)
			Me.pnlBar.Controls.Add(Me.skip_lblSessionLabel)
			Me.pnlBar.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.pnlBar.Location = New Global.System.Drawing.Point(0, 0)
			Me.pnlBar.Name = "pnlBar"
			Me.pnlBar.Size = New Global.System.Drawing.Size(1131, 27)
			Me.pnlBar.TabIndex = 99
			Me.skip_lblSession.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.skip_lblSession.BackColor = Global.System.Drawing.Color.Transparent
			Me.skip_lblSession.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.skip_lblSession.ForeColor = Global.System.Drawing.Color.Red
			Me.skip_lblSession.Location = New Global.System.Drawing.Point(1077, 5)
			Me.skip_lblSession.Name = "skip_lblSession"
			Me.skip_lblSession.Size = New Global.System.Drawing.Size(46, 16)
			Me.skip_lblSession.TabIndex = 4
			Me.skip_lblSession.Text = "00:00"
			Me.skip_lblMemory.BackColor = Global.System.Drawing.Color.Transparent
			Me.skip_lblMemory.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.skip_lblMemory.ForeColor = Global.System.Drawing.Color.Red
			Me.skip_lblMemory.Location = New Global.System.Drawing.Point(4, 1)
			Me.skip_lblMemory.Name = "skip_lblMemory"
			Me.skip_lblMemory.Size = New Global.System.Drawing.Size(296, 20)
			Me.skip_lblMemory.TabIndex = 8
			Me.skip_lblMemory.Text = "Memory Usage : "
			Me.skip_lblMemory.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.skip_lblMemory.Visible = False
			Me.skip_lblSessionLabel.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.skip_lblSessionLabel.AutoSize = True
			Me.skip_lblSessionLabel.BackColor = Global.System.Drawing.Color.Transparent
			Me.skip_lblSessionLabel.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.skip_lblSessionLabel.ForeColor = Global.System.Drawing.Color.Red
			Me.skip_lblSessionLabel.Location = New Global.System.Drawing.Point(953, 5)
			Me.skip_lblSessionLabel.Name = "skip_lblSessionLabel"
			Me.skip_lblSessionLabel.Size = New Global.System.Drawing.Size(123, 15)
			Me.skip_lblSessionLabel.TabIndex = 3
			Me.skip_lblSessionLabel.Text = "Auto Log Out In :"
			Me.pnlHeader.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.pnlHeader.Controls.Add(Me.skip_lblSanbox)
			Me.pnlHeader.Controls.Add(Me.picProfile)
			Me.pnlHeader.Controls.Add(Me.mnuMain)
			Me.pnlHeader.Controls.Add(Me.PicLogo)
			Me.pnlHeader.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.pnlHeader.Location = New Global.System.Drawing.Point(0, 27)
			Me.pnlHeader.Name = "pnlHeader"
			Me.pnlHeader.Size = New Global.System.Drawing.Size(1131, 51)
			Me.pnlHeader.TabIndex = 101
			Me.skip_lblSanbox.BackColor = Global.System.Drawing.Color.Transparent
			Me.skip_lblSanbox.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 14.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.skip_lblSanbox.ForeColor = Global.System.Drawing.Color.Red
			Me.skip_lblSanbox.Location = New Global.System.Drawing.Point(177, 14)
			Me.skip_lblSanbox.Name = "skip_lblSanbox"
			Me.skip_lblSanbox.Size = New Global.System.Drawing.Size(296, 30)
			Me.skip_lblSanbox.TabIndex = 39
			Me.skip_lblSanbox.Text = "SANDBOX"
			Me.skip_lblSanbox.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.skip_lblSanbox.Visible = False
			Me.picProfile.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.picProfile.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.picProfile.Location = New Global.System.Drawing.Point(1070, 3)
			Me.picProfile.Name = "picProfile"
			Me.picProfile.Size = New Global.System.Drawing.Size(55, 42)
			Me.picProfile.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.picProfile.TabIndex = 37
			Me.picProfile.TabStop = False
			Me.mnuMain.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.mnuMain.AutoSize = False
			Me.mnuMain.BackColor = Global.System.Drawing.Color.Transparent
			Me.mnuMain.Dock = Global.System.Windows.Forms.DockStyle.None
			Me.mnuMain.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuMain.ImageScalingSize = New Global.System.Drawing.Size(20, 20)
			Me.mnuMain.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() {Me.mnuMasters, Me.mnuReq, Me.mnuPurchase, Me.mnuInventory, Me.mnuMISReports, Me.mnuSettings, Me.mnuAbout})
			Me.mnuMain.LayoutStyle = Global.System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
			Me.mnuMain.Location = New Global.System.Drawing.Point(491, 4)
			Me.mnuMain.Name = "mnuMain"
			Me.mnuMain.Size = New Global.System.Drawing.Size(576, 42)
			Me.mnuMain.TabIndex = 36
			Me.mnuMasters.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() {Me.mnuProduct, Me.mnuProductBOM, Me.mnuBOMApproval, Me.mnuLocation, Me.mnuVendor, Me.mnuUser, Me.mnuUserGroup})
			Me.mnuMasters.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.0F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuMasters.Name = "mnuMasters"
			Me.mnuMasters.Size = New Global.System.Drawing.Size(81, 38)
			Me.mnuMasters.Text = "Database"
			Me.mnuProduct.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuProduct.Name = "mnuProduct"
			Me.mnuProduct.Size = New Global.System.Drawing.Size(157, 22)
			Me.mnuProduct.Text = "Product"
			Me.mnuProductBOM.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuProductBOM.Name = "mnuProductBOM"
			Me.mnuProductBOM.Size = New Global.System.Drawing.Size(157, 22)
			Me.mnuProductBOM.Text = "Product BOM"
			Me.mnuBOMApproval.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuBOMApproval.Name = "mnuBOMApproval"
			Me.mnuBOMApproval.Size = New Global.System.Drawing.Size(157, 22)
			Me.mnuBOMApproval.Text = "BOM Approval"
			Me.mnuLocation.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuLocation.Name = "mnuLocation"
			Me.mnuLocation.Size = New Global.System.Drawing.Size(157, 22)
			Me.mnuLocation.Text = "Store Location"
			Me.mnuVendor.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuVendor.Name = "mnuVendor"
			Me.mnuVendor.Size = New Global.System.Drawing.Size(157, 22)
			Me.mnuVendor.Text = "Vendor"
			Me.mnuUser.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.mnuUser.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuUser.Name = "mnuUser"
			Me.mnuUser.Size = New Global.System.Drawing.Size(157, 22)
			Me.mnuUser.Text = "User"
			Me.mnuUserGroup.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.mnuUserGroup.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuUserGroup.Name = "mnuUserGroup"
			Me.mnuUserGroup.Size = New Global.System.Drawing.Size(157, 22)
			Me.mnuUserGroup.Text = "User Group"
			Me.mnuReq.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() {Me.mnuPRCreation, Me.mnuPRModification, Me.mnuPRApproval, Me.mnuPRCostApproval})
			Me.mnuReq.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.0F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuReq.Name = "mnuReq"
			Me.mnuReq.Size = New Global.System.Drawing.Size(89, 38)
			Me.mnuReq.Text = "Requisition"
			Me.mnuPRCreation.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuPRCreation.Name = "mnuPRCreation"
			Me.mnuPRCreation.Size = New Global.System.Drawing.Size(175, 22)
			Me.mnuPRCreation.Text = "PR Creation"
			Me.mnuPRModification.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuPRModification.Name = "mnuPRModification"
			Me.mnuPRModification.Size = New Global.System.Drawing.Size(175, 22)
			Me.mnuPRModification.Text = "PR Modfication"
			Me.mnuPRApproval.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuPRApproval.Name = "mnuPRApproval"
			Me.mnuPRApproval.Size = New Global.System.Drawing.Size(175, 22)
			Me.mnuPRApproval.Text = "PR Approval"
			Me.mnuPRCostApproval.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuPRCostApproval.Name = "mnuPRCostApproval"
			Me.mnuPRCostApproval.Size = New Global.System.Drawing.Size(175, 22)
			Me.mnuPRCostApproval.Text = "PR Cost Approval"
			Me.mnuPurchase.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() {Me.mnuPOCreation, Me.mnuPOModification, Me.mnuPOApproval, Me.mnuPOCostApproval, Me.mnuPOPrinting, Me.mnuPOAmendment})
			Me.mnuPurchase.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.0F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuPurchase.Name = "mnuPurchase"
			Me.mnuPurchase.Size = New Global.System.Drawing.Size(78, 38)
			Me.mnuPurchase.Text = "Purchase"
			Me.mnuPOCreation.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuPOCreation.Name = "mnuPOCreation"
			Me.mnuPOCreation.Size = New Global.System.Drawing.Size(176, 22)
			Me.mnuPOCreation.Text = "PO Creation"
			Me.mnuPOModification.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuPOModification.Name = "mnuPOModification"
			Me.mnuPOModification.Size = New Global.System.Drawing.Size(176, 22)
			Me.mnuPOModification.Text = "PO Modfication"
			Me.mnuPOApproval.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuPOApproval.Name = "mnuPOApproval"
			Me.mnuPOApproval.Size = New Global.System.Drawing.Size(176, 22)
			Me.mnuPOApproval.Text = "PO Approval"
			Me.mnuPOCostApproval.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuPOCostApproval.Name = "mnuPOCostApproval"
			Me.mnuPOCostApproval.Size = New Global.System.Drawing.Size(176, 22)
			Me.mnuPOCostApproval.Text = "PO Cost Approval"
			Me.mnuPOPrinting.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuPOPrinting.Name = "mnuPOPrinting"
			Me.mnuPOPrinting.Size = New Global.System.Drawing.Size(176, 22)
			Me.mnuPOPrinting.Text = "PO Printing"
			Me.mnuPOAmendment.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuPOAmendment.Name = "mnuPOAmendment"
			Me.mnuPOAmendment.Size = New Global.System.Drawing.Size(176, 22)
			Me.mnuPOAmendment.Text = "PO Amendment"
			Me.mnuInventory.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() {Me.mnuGRN, Me.mnuGRNModification, Me.mnuGRNCancellation, Me.mnuGRNApproval, Me.mnuGRNPrinting, Me.mnuQCEntry, Me.mnuQCRelease, Me.mnuQARelease, Me.mnuConcentration, Me.mnuVendorReturn, Me.mnuLocationMapping, Me.mnuMaterialRequest, Me.mnuPicking, Me.mnuQAApproval, Me.mnuMaterialIssue, Me.mnuDispose})
			Me.mnuInventory.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.0F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuInventory.Name = "mnuInventory"
			Me.mnuInventory.Size = New Global.System.Drawing.Size(81, 38)
			Me.mnuInventory.Text = "Inventory"
			Me.mnuGRN.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() {Me.mnuReceipt, Me.mnuPO, Me.mnuBMR, Me.mnuReturn})
			Me.mnuGRN.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuGRN.Name = "mnuGRN"
			Me.mnuGRN.Size = New Global.System.Drawing.Size(197, 22)
			Me.mnuGRN.Text = "GRN Creation"
			Me.mnuReceipt.Name = "mnuReceipt"
			Me.mnuReceipt.Size = New Global.System.Drawing.Size(211, 22)
			Me.mnuReceipt.Text = "Against Material Receipt"
			Me.mnuPO.Name = "mnuPO"
			Me.mnuPO.Size = New Global.System.Drawing.Size(211, 22)
			Me.mnuPO.Text = "Against Purchase Order"
			Me.mnuBMR.Name = "mnuBMR"
			Me.mnuBMR.Size = New Global.System.Drawing.Size(211, 22)
			Me.mnuBMR.Text = "Against BMR"
			Me.mnuReturn.Name = "mnuReturn"
			Me.mnuReturn.Size = New Global.System.Drawing.Size(211, 22)
			Me.mnuReturn.Text = "Against Material Return"
			Me.mnuGRNModification.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() {Me.mnuReceipt_Modify, Me.mnuPO_Modify, Me.mnuBMR_Modify, Me.mnuReturn_Modify})
			Me.mnuGRNModification.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuGRNModification.Name = "mnuGRNModification"
			Me.mnuGRNModification.Size = New Global.System.Drawing.Size(197, 22)
			Me.mnuGRNModification.Text = "GRN Modification"
			Me.mnuReceipt_Modify.Name = "mnuReceipt_Modify"
			Me.mnuReceipt_Modify.Size = New Global.System.Drawing.Size(211, 22)
			Me.mnuReceipt_Modify.Text = "Against Material Receipt"
			Me.mnuPO_Modify.Name = "mnuPO_Modify"
			Me.mnuPO_Modify.Size = New Global.System.Drawing.Size(211, 22)
			Me.mnuPO_Modify.Text = "Against Purchase Order"
			Me.mnuBMR_Modify.Name = "mnuBMR_Modify"
			Me.mnuBMR_Modify.Size = New Global.System.Drawing.Size(211, 22)
			Me.mnuBMR_Modify.Text = "Against BMR"
			Me.mnuReturn_Modify.Name = "mnuReturn_Modify"
			Me.mnuReturn_Modify.Size = New Global.System.Drawing.Size(211, 22)
			Me.mnuReturn_Modify.Text = "Against Material Return"
			Me.mnuGRNCancellation.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuGRNCancellation.Name = "mnuGRNCancellation"
			Me.mnuGRNCancellation.Size = New Global.System.Drawing.Size(197, 22)
			Me.mnuGRNCancellation.Text = "GRN Cancellation"
			Me.mnuGRNCancellation.Visible = False
			Me.mnuGRNApproval.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() {Me.mnuReceipt_Approval, Me.mnuPO_Approval, Me.mnuBMR_Approval, Me.mnuReturn_Approval})
			Me.mnuGRNApproval.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuGRNApproval.Name = "mnuGRNApproval"
			Me.mnuGRNApproval.Size = New Global.System.Drawing.Size(197, 22)
			Me.mnuGRNApproval.Text = "GRN Approval"
			Me.mnuReceipt_Approval.Name = "mnuReceipt_Approval"
			Me.mnuReceipt_Approval.Size = New Global.System.Drawing.Size(211, 22)
			Me.mnuReceipt_Approval.Text = "Against Material Receipt"
			Me.mnuPO_Approval.Name = "mnuPO_Approval"
			Me.mnuPO_Approval.Size = New Global.System.Drawing.Size(211, 22)
			Me.mnuPO_Approval.Text = "Against Purchase Order"
			Me.mnuBMR_Approval.Name = "mnuBMR_Approval"
			Me.mnuBMR_Approval.Size = New Global.System.Drawing.Size(211, 22)
			Me.mnuBMR_Approval.Text = "Against BMR"
			Me.mnuReturn_Approval.Name = "mnuReturn_Approval"
			Me.mnuReturn_Approval.Size = New Global.System.Drawing.Size(211, 22)
			Me.mnuReturn_Approval.Text = "Against Material Return"
			Me.mnuGRNPrinting.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuGRNPrinting.Name = "mnuGRNPrinting"
			Me.mnuGRNPrinting.Size = New Global.System.Drawing.Size(197, 22)
			Me.mnuGRNPrinting.Text = "GRN Printing"
			Me.mnuQCEntry.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuQCEntry.Name = "mnuQCEntry"
			Me.mnuQCEntry.Size = New Global.System.Drawing.Size(197, 22)
			Me.mnuQCEntry.Text = "QC Entry"
			Me.mnuQCRelease.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuQCRelease.Name = "mnuQCRelease"
			Me.mnuQCRelease.Size = New Global.System.Drawing.Size(197, 22)
			Me.mnuQCRelease.Text = "QC Release"
			Me.mnuQARelease.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuQARelease.Name = "mnuQARelease"
			Me.mnuQARelease.Size = New Global.System.Drawing.Size(197, 22)
			Me.mnuQARelease.Text = "QA Release"
			Me.mnuConcentration.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuConcentration.Name = "mnuConcentration"
			Me.mnuConcentration.Size = New Global.System.Drawing.Size(197, 22)
			Me.mnuConcentration.Text = "Concentration && Titre"
			Me.mnuConcentration.Visible = False
			Me.mnuVendorReturn.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuVendorReturn.Name = "mnuVendorReturn"
			Me.mnuVendorReturn.Size = New Global.System.Drawing.Size(197, 22)
			Me.mnuVendorReturn.Text = "Vendor Return"
			Me.mnuVendorReturn.Visible = False
			Me.mnuLocationMapping.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuLocationMapping.Name = "mnuLocationMapping"
			Me.mnuLocationMapping.Size = New Global.System.Drawing.Size(197, 22)
			Me.mnuLocationMapping.Text = "Location Mapping"
			Me.mnuMaterialRequest.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuMaterialRequest.Name = "mnuMaterialRequest"
			Me.mnuMaterialRequest.Size = New Global.System.Drawing.Size(197, 22)
			Me.mnuMaterialRequest.Text = "Material Request"
			Me.mnuPicking.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuPicking.Name = "mnuPicking"
			Me.mnuPicking.Size = New Global.System.Drawing.Size(197, 22)
			Me.mnuPicking.Text = "Picking"
			Me.mnuQAApproval.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuQAApproval.Name = "mnuQAApproval"
			Me.mnuQAApproval.Size = New Global.System.Drawing.Size(197, 22)
			Me.mnuQAApproval.Text = "QA Verification"
			Me.mnuMaterialIssue.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuMaterialIssue.Name = "mnuMaterialIssue"
			Me.mnuMaterialIssue.Size = New Global.System.Drawing.Size(197, 22)
			Me.mnuMaterialIssue.Text = "Material Issue"
			Me.mnuDispose.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuDispose.Name = "mnuDispose"
			Me.mnuDispose.Size = New Global.System.Drawing.Size(197, 22)
			Me.mnuDispose.Text = "Dispose"
			Me.mnuMISReports.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() {Me.mnuPRReport, Me.mnuPOReport, Me.mnuGRNReport, Me.mnuRequestReport, Me.mnuProductBOMReport, Me.mnuStockReport, Me.mnuConsumptionReport, Me.mnuClosingStockReport, Me.mnuQuarentineStockReport, Me.mnuActivityLog})
			Me.mnuMISReports.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.0F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuMISReports.Name = "mnuMISReports"
			Me.mnuMISReports.Size = New Global.System.Drawing.Size(96, 38)
			Me.mnuMISReports.Text = "MIS Reports"
			Me.mnuPRReport.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuPRReport.Name = "mnuPRReport"
			Me.mnuPRReport.Size = New Global.System.Drawing.Size(216, 22)
			Me.mnuPRReport.Text = "PR Report"
			Me.mnuPOReport.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuPOReport.Name = "mnuPOReport"
			Me.mnuPOReport.Size = New Global.System.Drawing.Size(216, 22)
			Me.mnuPOReport.Text = "PO Report"
			Me.mnuGRNReport.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuGRNReport.Name = "mnuGRNReport"
			Me.mnuGRNReport.Size = New Global.System.Drawing.Size(216, 22)
			Me.mnuGRNReport.Text = "GRN Report"
			Me.mnuRequestReport.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuRequestReport.Name = "mnuRequestReport"
			Me.mnuRequestReport.Size = New Global.System.Drawing.Size(216, 22)
			Me.mnuRequestReport.Text = "Request Report"
			Me.mnuProductBOMReport.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuProductBOMReport.Name = "mnuProductBOMReport"
			Me.mnuProductBOMReport.Size = New Global.System.Drawing.Size(216, 22)
			Me.mnuProductBOMReport.Text = "Product BOM Report"
			Me.mnuProductBOMReport.Visible = False
			Me.mnuStockReport.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuStockReport.Name = "mnuStockReport"
			Me.mnuStockReport.Size = New Global.System.Drawing.Size(216, 22)
			Me.mnuStockReport.Text = "Stock Report"
			Me.mnuConsumptionReport.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuConsumptionReport.Name = "mnuConsumptionReport"
			Me.mnuConsumptionReport.Size = New Global.System.Drawing.Size(216, 22)
			Me.mnuConsumptionReport.Text = "Consumption Report"
			Me.mnuClosingStockReport.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuClosingStockReport.Name = "mnuClosingStockReport"
			Me.mnuClosingStockReport.Size = New Global.System.Drawing.Size(216, 22)
			Me.mnuClosingStockReport.Text = "Closing Stock Report"
			Me.mnuQuarentineStockReport.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuQuarentineStockReport.Name = "mnuQuarentineStockReport"
			Me.mnuQuarentineStockReport.Size = New Global.System.Drawing.Size(216, 22)
			Me.mnuQuarentineStockReport.Text = "Quarantine Stock Report"
			Me.mnuActivityLog.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuActivityLog.Name = "mnuActivityLog"
			Me.mnuActivityLog.Size = New Global.System.Drawing.Size(216, 22)
			Me.mnuActivityLog.Text = "Activity Log"
			Me.mnuSettings.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() {Me.mnuChangePassword, Me.mnuEmailAlertSettings, Me.mnuPRApproverList, Me.mnuPOApproverList, Me.mnuEmailTest, Me.mnuTest, Me.mnuStockUpload})
			Me.mnuSettings.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.0F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuSettings.Name = "mnuSettings"
			Me.mnuSettings.Size = New Global.System.Drawing.Size(72, 38)
			Me.mnuSettings.Text = "Settings"
			Me.mnuChangePassword.AutoSize = False
			Me.mnuChangePassword.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.mnuChangePassword.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuChangePassword.Name = "mnuChangePassword"
			Me.mnuChangePassword.Size = New Global.System.Drawing.Size(177, 25)
			Me.mnuChangePassword.Text = "Change Password"
			Me.mnuEmailAlertSettings.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuEmailAlertSettings.Name = "mnuEmailAlertSettings"
			Me.mnuEmailAlertSettings.Size = New Global.System.Drawing.Size(181, 22)
			Me.mnuEmailAlertSettings.Text = "Email Alert Setting"
			Me.mnuPRApproverList.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuPRApproverList.Name = "mnuPRApproverList"
			Me.mnuPRApproverList.Size = New Global.System.Drawing.Size(181, 22)
			Me.mnuPRApproverList.Text = "PR Approver List"
			Me.mnuPOApproverList.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuPOApproverList.Name = "mnuPOApproverList"
			Me.mnuPOApproverList.Size = New Global.System.Drawing.Size(181, 22)
			Me.mnuPOApproverList.Text = "PO Approver List"
			Me.mnuEmailTest.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuEmailTest.Name = "mnuEmailTest"
			Me.mnuEmailTest.Size = New Global.System.Drawing.Size(181, 22)
			Me.mnuEmailTest.Text = "Email Test"
			Me.mnuEmailTest.Visible = False
			Me.mnuTest.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuTest.Name = "mnuTest"
			Me.mnuTest.Size = New Global.System.Drawing.Size(181, 22)
			Me.mnuTest.Text = "Test"
			Me.mnuTest.Visible = False
			Me.mnuStockUpload.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuStockUpload.Name = "mnuStockUpload"
			Me.mnuStockUpload.Size = New Global.System.Drawing.Size(181, 22)
			Me.mnuStockUpload.Text = "Stock Upload"
			Me.mnuStockUpload.Visible = False
			Me.mnuAbout.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.0F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.mnuAbout.Name = "mnuAbout"
			Me.mnuAbout.Size = New Global.System.Drawing.Size(57, 38)
			Me.mnuAbout.Text = "About"
			Me.PicLogo.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.PicLogo.Location = New Global.System.Drawing.Point(3, 0)
			Me.PicLogo.Name = "PicLogo"
			Me.PicLogo.Size = New Global.System.Drawing.Size(168, 46)
			Me.PicLogo.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PicLogo.TabIndex = 0
			Me.PicLogo.TabStop = False
			Me.StatusStrip1.BackColor = Global.System.Drawing.Color.White
			Me.StatusStrip1.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.StatusStrip1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.0F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.StatusStrip1.ImageScalingSize = New Global.System.Drawing.Size(20, 20)
			Me.StatusStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel1, Me.gslblServer, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.gslblDatabase, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel6})
			Me.StatusStrip1.Location = New Global.System.Drawing.Point(0, 499)
			Me.StatusStrip1.Name = "StatusStrip1"
			Me.StatusStrip1.Size = New Global.System.Drawing.Size(1131, 22)
			Me.StatusStrip1.TabIndex = 102
			Me.StatusStrip1.Text = "StatusStrip1"
			Me.ToolStripStatusLabel4.BackColor = Global.System.Drawing.Color.Transparent
			Me.ToolStripStatusLabel4.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ToolStripStatusLabel4.ForeColor = Global.System.Drawing.Color.Black
			Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
			Me.ToolStripStatusLabel4.Size = New Global.System.Drawing.Size(15, 17)
			Me.ToolStripStatusLabel4.Text = "  "
			Me.ToolStripStatusLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.ToolStripStatusLabel1.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ToolStripStatusLabel1.ForeColor = Global.System.Drawing.Color.FromArgb(17, 72, 111)
			Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
			Me.ToolStripStatusLabel1.Size = New Global.System.Drawing.Size(105, 17)
			Me.ToolStripStatusLabel1.Text = "Server Name :"
			Me.gslblServer.BackColor = Global.System.Drawing.Color.Transparent
			Me.gslblServer.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.gslblServer.ForeColor = Global.System.Drawing.Color.FromArgb(17, 72, 111)
			Me.gslblServer.Name = "gslblServer"
			Me.gslblServer.Size = New Global.System.Drawing.Size(52, 17)
			Me.gslblServer.Text = "Server"
			Me.ToolStripStatusLabel2.BackColor = Global.System.Drawing.Color.Transparent
			Me.ToolStripStatusLabel2.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ToolStripStatusLabel2.ForeColor = Global.System.Drawing.Color.Black
			Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
			Me.ToolStripStatusLabel2.Size = New Global.System.Drawing.Size(39, 17)
			Me.ToolStripStatusLabel2.Text = "        "
			Me.ToolStripStatusLabel3.BackColor = Global.System.Drawing.Color.Transparent
			Me.ToolStripStatusLabel3.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ToolStripStatusLabel3.ForeColor = Global.System.Drawing.Color.FromArgb(17, 72, 111)
			Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
			Me.ToolStripStatusLabel3.Size = New Global.System.Drawing.Size(122, 17)
			Me.ToolStripStatusLabel3.Text = "Database Name :"
			Me.gslblDatabase.BackColor = Global.System.Drawing.Color.Transparent
			Me.gslblDatabase.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.gslblDatabase.ForeColor = Global.System.Drawing.Color.FromArgb(17, 72, 111)
			Me.gslblDatabase.Name = "gslblDatabase"
			Me.gslblDatabase.Size = New Global.System.Drawing.Size(69, 17)
			Me.gslblDatabase.Text = "Database"
			Me.ToolStripStatusLabel5.BackColor = Global.System.Drawing.Color.Transparent
			Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
			Me.ToolStripStatusLabel5.Size = New Global.System.Drawing.Size(12, 17)
			Me.ToolStripStatusLabel5.Text = " "
			Me.ToolStripStatusLabel7.BackColor = Global.System.Drawing.Color.Transparent
			Me.ToolStripStatusLabel7.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ToolStripStatusLabel7.ForeColor = Global.System.Drawing.Color.Black
			Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
			Me.ToolStripStatusLabel7.Size = New Global.System.Drawing.Size(39, 17)
			Me.ToolStripStatusLabel7.Text = "        "
			Me.ToolStripStatusLabel6.BackColor = Global.System.Drawing.Color.Transparent
			Me.ToolStripStatusLabel6.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ToolStripStatusLabel6.ForeColor = Global.System.Drawing.Color.Black
			Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
			Me.ToolStripStatusLabel6.Size = New Global.System.Drawing.Size(39, 17)
			Me.ToolStripStatusLabel6.Text = "        "
			Me.picSSDatacode.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.picSSDatacode.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.picSSDatacode.Location = New Global.System.Drawing.Point(906, 503)
			Me.picSSDatacode.Name = "picSSDatacode"
			Me.picSSDatacode.Size = New Global.System.Drawing.Size(223, 14)
			Me.picSSDatacode.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.picSSDatacode.TabIndex = 104
			Me.picSSDatacode.TabStop = False
			Me.DockPanel.ActiveAutoHideContent = Nothing
			Me.DockPanel.BackColor = Global.System.Drawing.Color.Transparent
			Me.DockPanel.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.DockPanel.DockBackColor = Global.System.Drawing.Color.White
			Me.DockPanel.Location = New Global.System.Drawing.Point(0, 78)
			Me.DockPanel.Name = "DockPanel"
			Me.DockPanel.Size = New Global.System.Drawing.Size(1131, 421)
			dockPanelGradient.EndColor = Global.System.Drawing.SystemColors.ControlLight
			dockPanelGradient.StartColor = Global.System.Drawing.SystemColors.ControlLight
			autoHideStripSkin.DockStripGradient = dockPanelGradient
			tabGradient.EndColor = Global.System.Drawing.SystemColors.Control
			tabGradient.StartColor = Global.System.Drawing.SystemColors.Control
			tabGradient.TextColor = Global.System.Drawing.SystemColors.ControlDarkDark
			autoHideStripSkin.TabGradient = tabGradient
			dockPanelSkin.AutoHideStripSkin = autoHideStripSkin
			tabGradient2.EndColor = Global.System.Drawing.SystemColors.ControlLightLight
			tabGradient2.StartColor = Global.System.Drawing.SystemColors.ControlLightLight
			tabGradient2.TextColor = Global.System.Drawing.SystemColors.ControlText
			dockPaneStripGradient.ActiveTabGradient = tabGradient2
			dockPanelGradient2.EndColor = Global.System.Drawing.SystemColors.Control
			dockPanelGradient2.StartColor = Global.System.Drawing.SystemColors.Control
			dockPaneStripGradient.DockStripGradient = dockPanelGradient2
			tabGradient3.EndColor = Global.System.Drawing.SystemColors.ControlLight
			tabGradient3.StartColor = Global.System.Drawing.SystemColors.ControlLight
			tabGradient3.TextColor = Global.System.Drawing.SystemColors.ControlText
			dockPaneStripGradient.InactiveTabGradient = tabGradient3
			dockPaneStripSkin.DocumentGradient = dockPaneStripGradient
			tabGradient4.EndColor = Global.System.Drawing.SystemColors.ActiveCaption
			tabGradient4.LinearGradientMode = Global.System.Drawing.Drawing2D.LinearGradientMode.Vertical
			tabGradient4.StartColor = Global.System.Drawing.SystemColors.GradientActiveCaption
			tabGradient4.TextColor = Global.System.Drawing.SystemColors.ActiveCaptionText
			dockPaneStripToolWindowGradient.ActiveCaptionGradient = tabGradient4
			tabGradient5.EndColor = Global.System.Drawing.SystemColors.Control
			tabGradient5.StartColor = Global.System.Drawing.SystemColors.Control
			tabGradient5.TextColor = Global.System.Drawing.SystemColors.ControlText
			dockPaneStripToolWindowGradient.ActiveTabGradient = tabGradient5
			dockPanelGradient3.EndColor = Global.System.Drawing.SystemColors.ControlLight
			dockPanelGradient3.StartColor = Global.System.Drawing.SystemColors.ControlLight
			dockPaneStripToolWindowGradient.DockStripGradient = dockPanelGradient3
			tabGradient6.EndColor = Global.System.Drawing.SystemColors.GradientInactiveCaption
			tabGradient6.LinearGradientMode = Global.System.Drawing.Drawing2D.LinearGradientMode.Vertical
			tabGradient6.StartColor = Global.System.Drawing.SystemColors.GradientInactiveCaption
			tabGradient6.TextColor = Global.System.Drawing.SystemColors.ControlText
			dockPaneStripToolWindowGradient.InactiveCaptionGradient = tabGradient6
			tabGradient7.EndColor = Global.System.Drawing.Color.Transparent
			tabGradient7.StartColor = Global.System.Drawing.Color.Transparent
			tabGradient7.TextColor = Global.System.Drawing.SystemColors.ControlDarkDark
			dockPaneStripToolWindowGradient.InactiveTabGradient = tabGradient7
			dockPaneStripSkin.ToolWindowGradient = dockPaneStripToolWindowGradient
			dockPanelSkin.DockPaneStripSkin = dockPaneStripSkin
			Me.DockPanel.Skin = dockPanelSkin
			Me.DockPanel.TabIndex = 107
			Me.lblLogin.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.lblLogin.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 26.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.lblLogin.ForeColor = Global.System.Drawing.Color.FromArgb(17, 72, 111)
			Me.lblLogin.Location = New Global.System.Drawing.Point(352, 127)
			Me.lblLogin.Name = "lblLogin"
			Me.lblLogin.Size = New Global.System.Drawing.Size(426, 55)
			Me.lblLogin.TabIndex = 109
			Me.lblLogin.Text = "* Please Login *"
			Me.lblLogin.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.pnlLogin.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.pnlLogin.BackColor = Global.System.Drawing.Color.White
			Me.pnlLogin.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.pnlLogin.Controls.Add(Me.skip_btnShow)
			Me.pnlLogin.Controls.Add(Me.picPwd)
			Me.pnlLogin.Controls.Add(Me.picUser)
			Me.pnlLogin.Controls.Add(Me.btnOK)
			Me.pnlLogin.Controls.Add(Me.skip_txtPass)
			Me.pnlLogin.Controls.Add(Me.skip_txtUser)
			Me.pnlLogin.Location = New Global.System.Drawing.Point(368, 184)
			Me.pnlLogin.Name = "pnlLogin"
			Me.pnlLogin.Size = New Global.System.Drawing.Size(395, 155)
			Me.pnlLogin.TabIndex = 108
			Me.skip_btnShow.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.skip_btnShow.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.skip_btnShow.FlatAppearance.BorderColor = Global.System.Drawing.Color.Gray
			Me.skip_btnShow.FlatAppearance.MouseDownBackColor = Global.System.Drawing.Color.Transparent
			Me.skip_btnShow.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.Transparent
			Me.skip_btnShow.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.skip_btnShow.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.0F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.skip_btnShow.Location = New Global.System.Drawing.Point(318, 62)
			Me.skip_btnShow.Margin = New Global.System.Windows.Forms.Padding(2, 0, 0, 0)
			Me.skip_btnShow.Name = "skip_btnShow"
			Me.skip_btnShow.Size = New Global.System.Drawing.Size(25, 25)
			Me.skip_btnShow.TabIndex = 719
			Me.skip_btnShow.UseVisualStyleBackColor = True
			Me.picPwd.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.picPwd.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.picPwd.Location = New Global.System.Drawing.Point(49, 62)
			Me.picPwd.Name = "picPwd"
			Me.picPwd.Size = New Global.System.Drawing.Size(25, 25)
			Me.picPwd.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.picPwd.TabIndex = 59
			Me.picPwd.TabStop = False
			Me.picUser.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.picUser.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.picUser.Location = New Global.System.Drawing.Point(49, 32)
			Me.picUser.Name = "picUser"
			Me.picUser.Size = New Global.System.Drawing.Size(25, 25)
			Me.picUser.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.picUser.TabIndex = 58
			Me.picUser.TabStop = False
			Me.btnOK.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.btnOK.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 10.8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.btnOK.Location = New Global.System.Drawing.Point(47, 93)
			Me.btnOK.Name = "btnOK"
			Me.btnOK.Size = New Global.System.Drawing.Size(303, 30)
			Me.btnOK.TabIndex = 0
			Me.btnOK.Text = "&Login"
			Me.skip_txtPass.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.skip_txtPass.BackColor = Global.System.Drawing.Color.White
			Me.skip_txtPass.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 10.8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.skip_txtPass.ForeColor = Global.System.Drawing.Color.DarkGray
			Me.skip_txtPass.Location = New Global.System.Drawing.Point(77, 62)
			Me.skip_txtPass.Name = "skip_txtPass"
			Me.skip_txtPass.Size = New Global.System.Drawing.Size(239, 25)
			Me.skip_txtPass.TabIndex = 1
			Me.skip_txtPass.Text = "Enter Password"
			Me.skip_txtUser.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.skip_txtUser.BackColor = Global.System.Drawing.Color.White
			Me.skip_txtUser.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 10.8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.skip_txtUser.ForeColor = Global.System.Drawing.Color.DarkGray
			Me.skip_txtUser.Location = New Global.System.Drawing.Point(77, 32)
			Me.skip_txtUser.Name = "skip_txtUser"
			Me.skip_txtUser.Size = New Global.System.Drawing.Size(266, 25)
			Me.skip_txtUser.TabIndex = 0
			Me.skip_txtUser.Text = "Enter LoginID"
			Me.pnlProfile.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.pnlProfile.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.pnlProfile.Controls.Add(Me.gslblDepartment)
			Me.pnlProfile.Controls.Add(Me.gslblReportingTo)
			Me.pnlProfile.Controls.Add(Me.gslblManager)
			Me.pnlProfile.Controls.Add(Me.sml_btnSignOut)
			Me.pnlProfile.Controls.Add(Me.gslblPlant)
			Me.pnlProfile.Controls.Add(Me.gslblCompany)
			Me.pnlProfile.Controls.Add(Me.gslblUser)
			Me.pnlProfile.Location = New Global.System.Drawing.Point(806, 79)
			Me.pnlProfile.Name = "pnlProfile"
			Me.pnlProfile.Size = New Global.System.Drawing.Size(323, 168)
			Me.pnlProfile.TabIndex = 110
			Me.gslblDepartment.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.gslblDepartment.AutoEllipsis = True
			Me.gslblDepartment.AutoSize = True
			Me.gslblDepartment.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.0F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.gslblDepartment.ForeColor = Global.System.Drawing.Color.FromArgb(17, 72, 111)
			Me.gslblDepartment.Location = New Global.System.Drawing.Point(22, 34)
			Me.gslblDepartment.Name = "gslblDepartment"
			Me.gslblDepartment.Size = New Global.System.Drawing.Size(83, 16)
			Me.gslblDepartment.TabIndex = 10
			Me.gslblDepartment.Text = "Department"
			Me.gslblDepartment.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.gslblReportingTo.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.gslblReportingTo.AutoEllipsis = True
			Me.gslblReportingTo.AutoSize = True
			Me.gslblReportingTo.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.0F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.gslblReportingTo.ForeColor = Global.System.Drawing.Color.FromArgb(17, 72, 111)
			Me.gslblReportingTo.Location = New Global.System.Drawing.Point(22, 80)
			Me.gslblReportingTo.Name = "gslblReportingTo"
			Me.gslblReportingTo.Size = New Global.System.Drawing.Size(88, 16)
			Me.gslblReportingTo.TabIndex = 9
			Me.gslblReportingTo.Text = "Reporting To"
			Me.gslblReportingTo.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.gslblManager.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.gslblManager.AutoEllipsis = True
			Me.gslblManager.AutoSize = True
			Me.gslblManager.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.0F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.gslblManager.ForeColor = Global.System.Drawing.Color.FromArgb(17, 72, 111)
			Me.gslblManager.Location = New Global.System.Drawing.Point(22, 57)
			Me.gslblManager.Name = "gslblManager"
			Me.gslblManager.Size = New Global.System.Drawing.Size(63, 16)
			Me.gslblManager.TabIndex = 8
			Me.gslblManager.Text = "Manager"
			Me.gslblManager.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.sml_btnSignOut.Anchor = Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.sml_btnSignOut.FlatAppearance.BorderColor = Global.System.Drawing.Color.ForestGreen
			Me.sml_btnSignOut.FlatAppearance.BorderSize = 0
			Me.sml_btnSignOut.FlatAppearance.MouseOverBackColor = Global.System.Drawing.Color.LawnGreen
			Me.sml_btnSignOut.ForeColor = Global.System.Drawing.Color.FromArgb(17, 72, 111)
			Me.sml_btnSignOut.Location = New Global.System.Drawing.Point(226, 124)
			Me.sml_btnSignOut.Name = "sml_btnSignOut"
			Me.sml_btnSignOut.Size = New Global.System.Drawing.Size(86, 26)
			Me.sml_btnSignOut.TabIndex = 7
			Me.sml_btnSignOut.Text = "Log Out"
			Me.sml_btnSignOut.UseVisualStyleBackColor = False
			Me.gslblPlant.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.gslblPlant.AutoEllipsis = True
			Me.gslblPlant.AutoSize = True
			Me.gslblPlant.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.0F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.gslblPlant.ForeColor = Global.System.Drawing.Color.FromArgb(17, 72, 111)
			Me.gslblPlant.Location = New Global.System.Drawing.Point(274, 104)
			Me.gslblPlant.Name = "gslblPlant"
			Me.gslblPlant.Size = New Global.System.Drawing.Size(40, 16)
			Me.gslblPlant.TabIndex = 6
			Me.gslblPlant.Text = "Plant"
			Me.gslblPlant.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.gslblPlant.Visible = False
			Me.gslblCompany.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.gslblCompany.AutoEllipsis = True
			Me.gslblCompany.AutoSize = True
			Me.gslblCompany.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 9.0F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.gslblCompany.ForeColor = Global.System.Drawing.Color.FromArgb(17, 72, 111)
			Me.gslblCompany.Location = New Global.System.Drawing.Point(158, 104)
			Me.gslblCompany.Name = "gslblCompany"
			Me.gslblCompany.Size = New Global.System.Drawing.Size(107, 16)
			Me.gslblCompany.TabIndex = 5
			Me.gslblCompany.Text = "Company Name"
			Me.gslblCompany.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.gslblCompany.Visible = False
			Me.gslblUser.Anchor = Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right
			Me.gslblUser.AutoEllipsis = True
			Me.gslblUser.AutoSize = True
			Me.gslblUser.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 12.0F, Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.gslblUser.ForeColor = Global.System.Drawing.Color.FromArgb(17, 72, 111)
			Me.gslblUser.Location = New Global.System.Drawing.Point(8, 5)
			Me.gslblUser.Name = "gslblUser"
			Me.gslblUser.Size = New Global.System.Drawing.Size(99, 20)
			Me.gslblUser.TabIndex = 4
			Me.gslblUser.Text = "User Name"
			Me.gslblUser.TextAlign = Global.System.Drawing.ContentAlignment.MiddleRight
			Me.profileTimer.Interval = 1
			Me.MemoryTimer.Interval = 10000
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.None
			Me.BackColor = Global.System.Drawing.Color.White
			MyBase.ClientSize = New Global.System.Drawing.Size(1131, 521)
			MyBase.Controls.Add(Me.pnlProfile)
			MyBase.Controls.Add(Me.lblLogin)
			MyBase.Controls.Add(Me.pnlLogin)
			MyBase.Controls.Add(Me.DockPanel)
			MyBase.Controls.Add(Me.picSSDatacode)
			MyBase.Controls.Add(Me.StatusStrip1)
			MyBase.Controls.Add(Me.pnlHeader)
			MyBase.Controls.Add(Me.pnlBar)
			Me.Font = New Global.System.Drawing.Font("MS Reference Sans Serif", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			MyBase.IsMdiContainer = True
			MyBase.Name = "MDIMain"
			Me.Text = "Datasoft PIMS - Procurement & Inventory Management System"
			Me.pnlBar.ResumeLayout(False)
			Me.pnlBar.PerformLayout()
			Me.pnlHeader.ResumeLayout(False)
			CType(Me.picProfile, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.mnuMain.ResumeLayout(False)
			Me.mnuMain.PerformLayout()
			CType(Me.PicLogo, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.StatusStrip1.ResumeLayout(False)
			Me.StatusStrip1.PerformLayout()
			CType(Me.picSSDatacode, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlLogin.ResumeLayout(False)
			Me.pnlLogin.PerformLayout()
			CType(Me.picPwd, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.picUser, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlProfile.ResumeLayout(False)
			Me.pnlProfile.PerformLayout()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000350 RID: 848
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
