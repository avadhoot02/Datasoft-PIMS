Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace Datasoft_PIMS
	' Token: 0x02000022 RID: 34
	<DesignerGenerated()>
	Public Partial Class VendorAddress
		Inherits Form

		' Token: 0x170002E0 RID: 736
		' (get) Token: 0x0600077C RID: 1916 RVA: 0x000459F3 File Offset: 0x00043BF3
		' (set) Token: 0x0600077D RID: 1917 RVA: 0x000459FD File Offset: 0x00043BFD
		Friend Overridable Property pnlBorder As Panel

		' Token: 0x170002E1 RID: 737
		' (get) Token: 0x0600077E RID: 1918 RVA: 0x00045A06 File Offset: 0x00043C06
		' (set) Token: 0x0600077F RID: 1919 RVA: 0x00045A10 File Offset: 0x00043C10
		Friend Overridable Property pnlMain As Panel

		' Token: 0x170002E2 RID: 738
		' (get) Token: 0x06000780 RID: 1920 RVA: 0x00045A19 File Offset: 0x00043C19
		' (set) Token: 0x06000781 RID: 1921 RVA: 0x00045A24 File Offset: 0x00043C24
		Friend Overridable Property panelTitleBar As Panel
			<CompilerGenerated()>
			Get
				Return Me._panelTitleBar
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim mouseEventHandler As MouseEventHandler = AddressOf Me.panelTitleBar_MouseDown
				Dim panel As Panel = Me._panelTitleBar
				If panel IsNot Nothing Then
					RemoveHandler panel.MouseDown, mouseEventHandler
				End If
				Me._panelTitleBar = value
				panel = Me._panelTitleBar
				If panel IsNot Nothing Then
					AddHandler panel.MouseDown, mouseEventHandler
				End If
			End Set
		End Property

		' Token: 0x170002E3 RID: 739
		' (get) Token: 0x06000782 RID: 1922 RVA: 0x00045A67 File Offset: 0x00043C67
		' (set) Token: 0x06000783 RID: 1923 RVA: 0x00045A71 File Offset: 0x00043C71
		Friend Overridable Property picFormIcon As PictureBox

		' Token: 0x170002E4 RID: 740
		' (get) Token: 0x06000784 RID: 1924 RVA: 0x00045A7A File Offset: 0x00043C7A
		' (set) Token: 0x06000785 RID: 1925 RVA: 0x00045A84 File Offset: 0x00043C84
		Friend Overridable Property lblCaption As Label

		' Token: 0x170002E5 RID: 741
		' (get) Token: 0x06000786 RID: 1926 RVA: 0x00045A8D File Offset: 0x00043C8D
		' (set) Token: 0x06000787 RID: 1927 RVA: 0x00045A98 File Offset: 0x00043C98
		Friend Overridable Property form_btnClose As Button
			<CompilerGenerated()>
			Get
				Return Me._form_btnClose
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.form_btnClose_Click
				Dim button As Button = Me._form_btnClose
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._form_btnClose = value
				button = Me._form_btnClose
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002E6 RID: 742
		' (get) Token: 0x06000788 RID: 1928 RVA: 0x00045ADB File Offset: 0x00043CDB
		' (set) Token: 0x06000789 RID: 1929 RVA: 0x00045AE5 File Offset: 0x00043CE5
		Friend Overridable Property lblShadow1 As Label

		' Token: 0x170002E7 RID: 743
		' (get) Token: 0x0600078A RID: 1930 RVA: 0x00045AEE File Offset: 0x00043CEE
		' (set) Token: 0x0600078B RID: 1931 RVA: 0x00045AF8 File Offset: 0x00043CF8
		Friend Overridable Property lblShadow2 As Label

		' Token: 0x170002E8 RID: 744
		' (get) Token: 0x0600078C RID: 1932 RVA: 0x00045B01 File Offset: 0x00043D01
		' (set) Token: 0x0600078D RID: 1933 RVA: 0x00045B0B File Offset: 0x00043D0B
		Friend Overridable Property cmbAddressType As ComboBox

		' Token: 0x170002E9 RID: 745
		' (get) Token: 0x0600078E RID: 1934 RVA: 0x00045B14 File Offset: 0x00043D14
		' (set) Token: 0x0600078F RID: 1935 RVA: 0x00045B1E File Offset: 0x00043D1E
		Friend Overridable Property Label42 As Label

		' Token: 0x170002EA RID: 746
		' (get) Token: 0x06000790 RID: 1936 RVA: 0x00045B27 File Offset: 0x00043D27
		' (set) Token: 0x06000791 RID: 1937 RVA: 0x00045B31 File Offset: 0x00043D31
		Friend Overridable Property txtPincode As TextBox

		' Token: 0x170002EB RID: 747
		' (get) Token: 0x06000792 RID: 1938 RVA: 0x00045B3A File Offset: 0x00043D3A
		' (set) Token: 0x06000793 RID: 1939 RVA: 0x00045B44 File Offset: 0x00043D44
		Friend Overridable Property txtPANNo As TextBox

		' Token: 0x170002EC RID: 748
		' (get) Token: 0x06000794 RID: 1940 RVA: 0x00045B4D File Offset: 0x00043D4D
		' (set) Token: 0x06000795 RID: 1941 RVA: 0x00045B57 File Offset: 0x00043D57
		Friend Overridable Property Label31 As Label

		' Token: 0x170002ED RID: 749
		' (get) Token: 0x06000796 RID: 1942 RVA: 0x00045B60 File Offset: 0x00043D60
		' (set) Token: 0x06000797 RID: 1943 RVA: 0x00045B6A File Offset: 0x00043D6A
		Friend Overridable Property Label51 As Label

		' Token: 0x170002EE RID: 750
		' (get) Token: 0x06000798 RID: 1944 RVA: 0x00045B73 File Offset: 0x00043D73
		' (set) Token: 0x06000799 RID: 1945 RVA: 0x00045B7D File Offset: 0x00043D7D
		Friend Overridable Property Label52 As Label

		' Token: 0x170002EF RID: 751
		' (get) Token: 0x0600079A RID: 1946 RVA: 0x00045B86 File Offset: 0x00043D86
		' (set) Token: 0x0600079B RID: 1947 RVA: 0x00045B90 File Offset: 0x00043D90
		Friend Overridable Property Label53 As Label

		' Token: 0x170002F0 RID: 752
		' (get) Token: 0x0600079C RID: 1948 RVA: 0x00045B99 File Offset: 0x00043D99
		' (set) Token: 0x0600079D RID: 1949 RVA: 0x00045BA3 File Offset: 0x00043DA3
		Friend Overridable Property txtAddress As TextBox

		' Token: 0x170002F1 RID: 753
		' (get) Token: 0x0600079E RID: 1950 RVA: 0x00045BAC File Offset: 0x00043DAC
		' (set) Token: 0x0600079F RID: 1951 RVA: 0x00045BB6 File Offset: 0x00043DB6
		Friend Overridable Property Label54 As Label

		' Token: 0x170002F2 RID: 754
		' (get) Token: 0x060007A0 RID: 1952 RVA: 0x00045BBF File Offset: 0x00043DBF
		' (set) Token: 0x060007A1 RID: 1953 RVA: 0x00045BC9 File Offset: 0x00043DC9
		Friend Overridable Property Label46 As Label

		' Token: 0x170002F3 RID: 755
		' (get) Token: 0x060007A2 RID: 1954 RVA: 0x00045BD2 File Offset: 0x00043DD2
		' (set) Token: 0x060007A3 RID: 1955 RVA: 0x00045BDC File Offset: 0x00043DDC
		Friend Overridable Property txtContactName As TextBox

		' Token: 0x170002F4 RID: 756
		' (get) Token: 0x060007A4 RID: 1956 RVA: 0x00045BE5 File Offset: 0x00043DE5
		' (set) Token: 0x060007A5 RID: 1957 RVA: 0x00045BEF File Offset: 0x00043DEF
		Friend Overridable Property txtCellNo As TextBox

		' Token: 0x170002F5 RID: 757
		' (get) Token: 0x060007A6 RID: 1958 RVA: 0x00045BF8 File Offset: 0x00043DF8
		' (set) Token: 0x060007A7 RID: 1959 RVA: 0x00045C02 File Offset: 0x00043E02
		Friend Overridable Property Label48 As Label

		' Token: 0x170002F6 RID: 758
		' (get) Token: 0x060007A8 RID: 1960 RVA: 0x00045C0B File Offset: 0x00043E0B
		' (set) Token: 0x060007A9 RID: 1961 RVA: 0x00045C15 File Offset: 0x00043E15
		Friend Overridable Property txtEmailAddress As TextBox

		' Token: 0x170002F7 RID: 759
		' (get) Token: 0x060007AA RID: 1962 RVA: 0x00045C1E File Offset: 0x00043E1E
		' (set) Token: 0x060007AB RID: 1963 RVA: 0x00045C28 File Offset: 0x00043E28
		Friend Overridable Property txtLandlineNo As TextBox

		' Token: 0x170002F8 RID: 760
		' (get) Token: 0x060007AC RID: 1964 RVA: 0x00045C31 File Offset: 0x00043E31
		' (set) Token: 0x060007AD RID: 1965 RVA: 0x00045C3B File Offset: 0x00043E3B
		Friend Overridable Property Label49 As Label

		' Token: 0x170002F9 RID: 761
		' (get) Token: 0x060007AE RID: 1966 RVA: 0x00045C44 File Offset: 0x00043E44
		' (set) Token: 0x060007AF RID: 1967 RVA: 0x00045C4E File Offset: 0x00043E4E
		Friend Overridable Property Label50 As Label

		' Token: 0x170002FA RID: 762
		' (get) Token: 0x060007B0 RID: 1968 RVA: 0x00045C57 File Offset: 0x00043E57
		' (set) Token: 0x060007B1 RID: 1969 RVA: 0x00045C64 File Offset: 0x00043E64
		Friend Overridable Property btnSave As Button
			<CompilerGenerated()>
			Get
				Return Me._btnSave
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnSave_Click
				Dim button As Button = Me._btnSave
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnSave = value
				button = Me._btnSave
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002FB RID: 763
		' (get) Token: 0x060007B2 RID: 1970 RVA: 0x00045CA7 File Offset: 0x00043EA7
		' (set) Token: 0x060007B3 RID: 1971 RVA: 0x00045CB4 File Offset: 0x00043EB4
		Friend Overridable Property btnDelete As Button
			<CompilerGenerated()>
			Get
				Return Me._btnDelete
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnDelete_Click
				Dim button As Button = Me._btnDelete
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnDelete = value
				button = Me._btnDelete
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002FC RID: 764
		' (get) Token: 0x060007B4 RID: 1972 RVA: 0x00045CF7 File Offset: 0x00043EF7
		' (set) Token: 0x060007B5 RID: 1973 RVA: 0x00045D04 File Offset: 0x00043F04
		Friend Overridable Property btnClose As Button
			<CompilerGenerated()>
			Get
				Return Me._btnClose
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim eventHandler As EventHandler = AddressOf Me.btnClose_Click
				Dim button As Button = Me._btnClose
				If button IsNot Nothing Then
					RemoveHandler button.Click, eventHandler
				End If
				Me._btnClose = value
				button = Me._btnClose
				If button IsNot Nothing Then
					AddHandler button.Click, eventHandler
				End If
			End Set
		End Property

		' Token: 0x170002FD RID: 765
		' (get) Token: 0x060007B6 RID: 1974 RVA: 0x00045D47 File Offset: 0x00043F47
		' (set) Token: 0x060007B7 RID: 1975 RVA: 0x00045D51 File Offset: 0x00043F51
		Friend Overridable Property Label1 As Label

		' Token: 0x170002FE RID: 766
		' (get) Token: 0x060007B8 RID: 1976 RVA: 0x00045D5A File Offset: 0x00043F5A
		' (set) Token: 0x060007B9 RID: 1977 RVA: 0x00045D64 File Offset: 0x00043F64
		Friend Overridable Property txtGSTINNo As TextBox

		' Token: 0x170002FF RID: 767
		' (get) Token: 0x060007BA RID: 1978 RVA: 0x00045D6D File Offset: 0x00043F6D
		' (set) Token: 0x060007BB RID: 1979 RVA: 0x00045D77 File Offset: 0x00043F77
		Friend Overridable Property cmbGSTType As ComboBox

		' Token: 0x17000300 RID: 768
		' (get) Token: 0x060007BC RID: 1980 RVA: 0x00045D80 File Offset: 0x00043F80
		' (set) Token: 0x060007BD RID: 1981 RVA: 0x00045D8A File Offset: 0x00043F8A
		Friend Overridable Property Label2 As Label

		' Token: 0x17000301 RID: 769
		' (get) Token: 0x060007BE RID: 1982 RVA: 0x00045D93 File Offset: 0x00043F93
		' (set) Token: 0x060007BF RID: 1983 RVA: 0x00045D9D File Offset: 0x00043F9D
		Friend Overridable Property cmbGSTINRegistration As ComboBox

		' Token: 0x17000302 RID: 770
		' (get) Token: 0x060007C0 RID: 1984 RVA: 0x00045DA6 File Offset: 0x00043FA6
		' (set) Token: 0x060007C1 RID: 1985 RVA: 0x00045DB0 File Offset: 0x00043FB0
		Friend Overridable Property Label43 As Label

		' Token: 0x17000303 RID: 771
		' (get) Token: 0x060007C2 RID: 1986 RVA: 0x00045DB9 File Offset: 0x00043FB9
		' (set) Token: 0x060007C3 RID: 1987 RVA: 0x00045DC3 File Offset: 0x00043FC3
		Friend Overridable Property Label3 As Label

		' Token: 0x17000304 RID: 772
		' (get) Token: 0x060007C4 RID: 1988 RVA: 0x00045DCC File Offset: 0x00043FCC
		' (set) Token: 0x060007C5 RID: 1989 RVA: 0x00045DD6 File Offset: 0x00043FD6
		Friend Overridable Property txtTINNo As TextBox

		' Token: 0x17000305 RID: 773
		' (get) Token: 0x060007C6 RID: 1990 RVA: 0x00045DDF File Offset: 0x00043FDF
		' (set) Token: 0x060007C7 RID: 1991 RVA: 0x00045DE9 File Offset: 0x00043FE9
		Friend Overridable Property txtID As TextBox

		' Token: 0x17000306 RID: 774
		' (get) Token: 0x060007C8 RID: 1992 RVA: 0x00045DF2 File Offset: 0x00043FF2
		' (set) Token: 0x060007C9 RID: 1993 RVA: 0x00045DFC File Offset: 0x00043FFC
		Friend Overridable Property txtDtlsID As TextBox

		' Token: 0x17000307 RID: 775
		' (get) Token: 0x060007CA RID: 1994 RVA: 0x00045E05 File Offset: 0x00044005
		' (set) Token: 0x060007CB RID: 1995 RVA: 0x00045E0F File Offset: 0x0004400F
		Friend Overridable Property Label5 As Label

		' Token: 0x17000308 RID: 776
		' (get) Token: 0x060007CC RID: 1996 RVA: 0x00045E18 File Offset: 0x00044018
		' (set) Token: 0x060007CD RID: 1997 RVA: 0x00045E22 File Offset: 0x00044022
		Friend Overridable Property Label4 As Label

		' Token: 0x17000309 RID: 777
		' (get) Token: 0x060007CE RID: 1998 RVA: 0x00045E2B File Offset: 0x0004402B
		' (set) Token: 0x060007CF RID: 1999 RVA: 0x00045E35 File Offset: 0x00044035
		Friend Overridable Property cmbState As ComboBox

		' Token: 0x1700030A RID: 778
		' (get) Token: 0x060007D0 RID: 2000 RVA: 0x00045E3E File Offset: 0x0004403E
		' (set) Token: 0x060007D1 RID: 2001 RVA: 0x00045E48 File Offset: 0x00044048
		Friend Overridable Property cmbCity As ComboBox
			<CompilerGenerated()>
			Get
				Return Me._cmbCity
			End Get
			<CompilerGenerated()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim eventHandler As EventHandler = AddressOf Me.cmbCity_Validated
				Dim comboBox As ComboBox = Me._cmbCity
				If comboBox IsNot Nothing Then
					RemoveHandler comboBox.Validated, eventHandler
				End If
				Me._cmbCity = value
				comboBox = Me._cmbCity
				If comboBox IsNot Nothing Then
					AddHandler comboBox.Validated, eventHandler
				End If
			End Set
		End Property

		' Token: 0x060007D2 RID: 2002
		Private Declare Sub SendMessage Lib "user32.DLL" (hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

		' Token: 0x060007D3 RID: 2003
		Private Declare Sub ReleaseCapture Lib "user32.DLL" ()

		' Token: 0x060007D4 RID: 2004 RVA: 0x00045E8B File Offset: 0x0004408B
		Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs)
			VendorAddress.ReleaseCapture()
			VendorAddress.SendMessage(MyBase.Handle, 274, 61458, 0)
		End Sub

		' Token: 0x060007D5 RID: 2005 RVA: 0x00045EAC File Offset: 0x000440AC
		Public Sub New(iR As Integer, dt As DataTable)
			AddHandler MyBase.Load, AddressOf Me.VendorAddress_Load
			Me.InitializeComponent()
			Designing.SetTheme(Me)
			Me.picFormIcon.Image = ResourceModule.imgFormIconPic
			MyBase.FormBorderStyle = FormBorderStyle.None
			Me.BackColor = Color.DarkGray
			MyBase.ShowInTaskbar = False
			MyBase.StartPosition = FormStartPosition.CenterScreen
			Me.lblCaption.Text = Me.Text
			Me.form_btnClose.DialogResult = DialogResult.Cancel
			Me.iRow = iR
			Me.dtAddress = dt
		End Sub

		' Token: 0x060007D6 RID: 2006 RVA: 0x00045F44 File Offset: 0x00044144
		Private Sub form_btnClose_Click(sender As Object, e As EventArgs)
			MyBase.Close()
		End Sub

		' Token: 0x060007D7 RID: 2007 RVA: 0x00045F4E File Offset: 0x0004414E
		Private Sub VendorAddress_Load(sender As Object, e As EventArgs)
			Me.FillCombo()
			Me.FillData()
		End Sub

		' Token: 0x060007D8 RID: 2008 RVA: 0x00045F60 File Offset: 0x00044160
		Private Sub FillCombo()
			Dim text As String = "SELECT DISTINCT City, State FROM VendorDtls ORDER BY City"
			Dim data As DataTable = MainModule.GetData(text)
			Dim dataTable As DataTable = data.DefaultView.ToTable(True, New String() { "State" })
			Dim dataView As DataView = New DataView(dataTable, "1=1", "", DataViewRowState.CurrentRows)
			Me.cmbCity.ValueMember = "City"
			Me.cmbCity.DisplayMember = "City"
			Me.cmbCity.DataSource = data
			Me.cmbCity.Text = ""
			Me.cmbState.ValueMember = "State"
			Me.cmbState.DisplayMember = "State"
			Me.cmbState.DataSource = dataView
			Me.cmbState.Text = ""
		End Sub

		' Token: 0x060007D9 RID: 2009 RVA: 0x0004602C File Offset: 0x0004422C
		Private Sub cmbCity_Validated(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.cmbCity.Text, "", False) <> 0
			If flag Then
				Dim dataTable As DataTable = CType(Me.cmbCity.DataSource, DataTable)
				Dim array As DataRow() = dataTable.[Select]("City = '" + Strings.Trim(Me.cmbCity.Text) + "'")
				Dim flag2 As Boolean = array.Length > 0
				If flag2 Then
					Me.cmbState.Text = Conversions.ToString(array(0)("State"))
				Else
					Me.cmbState.Text = ""
				End If
			End If
		End Sub

		' Token: 0x060007DA RID: 2010 RVA: 0x000460D0 File Offset: 0x000442D0
		Private Sub FillData()
			Dim flag As Boolean = Me.iRow <> -1
			If flag Then
				Me.txtDtlsID.Text = Conversions.ToString(Me.dtAddress.Rows(Me.iRow)("VendorDtlsID"))
				Me.txtID.Text = Conversions.ToString(Me.dtAddress.Rows(Me.iRow)("VendorID"))
				Me.cmbAddressType.Text = Conversions.ToString(Me.dtAddress.Rows(Me.iRow)("AddressType"))
				Me.txtAddress.Text = Conversions.ToString(Me.dtAddress.Rows(Me.iRow)("Address"))
				Me.cmbCity.Text = Conversions.ToString(Me.dtAddress.Rows(Me.iRow)("City"))
				Me.txtPincode.Text = Conversions.ToString(Me.dtAddress.Rows(Me.iRow)("Pincode"))
				Me.cmbState.Text = Conversions.ToString(Me.dtAddress.Rows(Me.iRow)("State"))
				Me.txtPANNo.Text = Conversions.ToString(Me.dtAddress.Rows(Me.iRow)("PANNo"))
				Me.txtContactName.Text = Conversions.ToString(Me.dtAddress.Rows(Me.iRow)("ContactName"))
				Me.txtLandlineNo.Text = Conversions.ToString(Me.dtAddress.Rows(Me.iRow)("LandlineNo"))
				Me.txtCellNo.Text = Conversions.ToString(Me.dtAddress.Rows(Me.iRow)("CellNo"))
				Me.txtEmailAddress.Text = Conversions.ToString(Me.dtAddress.Rows(Me.iRow)("EmailAddress"))
				Me.cmbGSTINRegistration.Text = Conversions.ToString(Me.dtAddress.Rows(Me.iRow)("GSTINRegistration"))
				Me.cmbGSTType.Text = Conversions.ToString(Me.dtAddress.Rows(Me.iRow)("GSTType"))
				Me.txtGSTINNo.Text = Conversions.ToString(Me.dtAddress.Rows(Me.iRow)("GSTINNo"))
				Me.txtTINNo.Text = Conversions.ToString(Me.dtAddress.Rows(Me.iRow)("TINNo"))
			End If
		End Sub

		' Token: 0x060007DB RID: 2011 RVA: 0x00046406 File Offset: 0x00044606
		Private Sub btnClose_Click(sender As Object, e As EventArgs)
			MyBase.DialogResult = DialogResult.Cancel
			MyBase.Close()
		End Sub

		' Token: 0x060007DC RID: 2012 RVA: 0x00046418 File Offset: 0x00044618
		Private Sub btnDelete_Click(sender As Object, e As EventArgs)
			Try
				Me.DeleteContact()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x060007DD RID: 2013 RVA: 0x00046470 File Offset: 0x00044670
		Private Sub DeleteContact()
			Dim flag As Boolean = CustomMsgBox.Show("Delete Contact..?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes
			If flag Then
				Me.dtAddress.Rows.RemoveAt(Me.iRow)
				Me.dtAddress.AcceptChanges()
				MyBase.DialogResult = DialogResult.OK
				MyBase.Close()
			End If
		End Sub

		' Token: 0x060007DE RID: 2014 RVA: 0x000464CC File Offset: 0x000446CC
		Private Function ValidateForm() As Boolean
			Dim flag As Boolean = Operators.CompareString(Strings.Trim(Me.cmbAddressType.Text), "", False) = 0
			Dim flag2 As Boolean
			If flag Then
				CustomMsgBox.Show("Select Address Type.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
				Me.cmbAddressType.Focus()
				flag2 = False
			Else
				Dim flag3 As Boolean = Operators.CompareString(Strings.Trim(Me.txtAddress.Text), "", False) = 0
				If flag3 Then
					CustomMsgBox.Show("Enter Address.", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Hand)
					Me.txtAddress.Focus()
					flag2 = False
				Else
					flag2 = True
				End If
			End If
			Return flag2
		End Function

		' Token: 0x060007DF RID: 2015 RVA: 0x0004656C File Offset: 0x0004476C
		Private Sub btnSave_Click(sender As Object, e As EventArgs)
			Try
				Me.Save()
			Catch ex As Exception
				CustomMsgBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub

		' Token: 0x060007E0 RID: 2016 RVA: 0x000465C4 File Offset: 0x000447C4
		Private Sub Save()
			Dim flag As Boolean = Not Me.ValidateForm()
			If Not flag Then
				Dim flag2 As Boolean = Me.iRow = -1
				If flag2 Then
					Me.iRow = Me.dtAddress.Rows.Count
					Me.dtAddress.Rows.Add(New Object(-1) {})
				End If
				Me.dtAddress.Rows(Me.iRow)("VendorDtlsID") = Me.iRow
				Me.dtAddress.Rows(Me.iRow)("VendorID") = Me.iRow
				Me.dtAddress.Rows(Me.iRow)("AddressType") = Me.cmbAddressType.Text
				Me.dtAddress.Rows(Me.iRow)("Address") = Me.txtAddress.Text
				Me.dtAddress.Rows(Me.iRow)("City") = Me.cmbCity.Text
				Me.dtAddress.Rows(Me.iRow)("Pincode") = Me.txtPincode.Text
				Me.dtAddress.Rows(Me.iRow)("State") = Me.cmbState.Text
				Me.dtAddress.Rows(Me.iRow)("PANNo") = Me.txtPANNo.Text
				Me.dtAddress.Rows(Me.iRow)("ContactName") = Me.txtContactName.Text
				Me.dtAddress.Rows(Me.iRow)("LandlineNo") = Me.txtLandlineNo.Text
				Me.dtAddress.Rows(Me.iRow)("CellNo") = Me.txtCellNo.Text
				Me.dtAddress.Rows(Me.iRow)("EmailAddress") = Me.txtEmailAddress.Text
				Me.dtAddress.Rows(Me.iRow)("GSTINRegistration") = Me.cmbGSTINRegistration.Text
				Me.dtAddress.Rows(Me.iRow)("GSTType") = Me.cmbGSTType.Text
				Me.dtAddress.Rows(Me.iRow)("GSTINNo") = Me.txtGSTINNo.Text
				Me.dtAddress.Rows(Me.iRow)("TINNo") = Me.txtTINNo.Text
				MyBase.DialogResult = DialogResult.OK
				MyBase.Close()
			End If
		End Sub

		' Token: 0x0400034E RID: 846
		Private iRow As Integer

		' Token: 0x0400034F RID: 847
		Public dtAddress As DataTable
	End Class
End Namespace
