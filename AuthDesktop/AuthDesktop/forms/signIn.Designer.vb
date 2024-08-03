<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class signIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(signIn))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuCustomDataGrid1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextboxServiceNo = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BunifuDatepickerDR = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuDatepickerDE = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuMaterialTextboxStaffId = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuDropdownRank = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BunifuDatepickerDOB = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuMaterialTextboxOname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextboxSname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextboxContac = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextboxFName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuDropdownGender = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.ImageBox1 = New Emgu.CV.UI.ImageBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ImageBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(436, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(842, 793)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(840, 753)
        Me.Panel2.TabIndex = 0
        '
        'BunifuCustomDataGrid1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(0, 351)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.RowHeadersWidth = 51
        Me.BunifuCustomDataGrid1.RowTemplate.Height = 24
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(838, 400)
        Me.BunifuCustomDataGrid1.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.GroupBox2.Controls.Add(Me.BunifuMaterialTextboxServiceNo)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.BunifuDatepickerDR)
        Me.GroupBox2.Controls.Add(Me.BunifuDatepickerDE)
        Me.GroupBox2.Controls.Add(Me.BunifuMaterialTextboxStaffId)
        Me.GroupBox2.Controls.Add(Me.BunifuDropdownRank)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(418, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(418, 343)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Other Informations"
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox1.HintText = ""
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineThickness = 4
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(76, 115)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(329, 41)
        Me.BunifuMaterialTextbox1.TabIndex = 16
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMaterialTextboxServiceNo
        '
        Me.BunifuMaterialTextboxServiceNo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuMaterialTextboxServiceNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextboxServiceNo.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuMaterialTextboxServiceNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextboxServiceNo.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextboxServiceNo.HintText = ""
        Me.BunifuMaterialTextboxServiceNo.isPassword = False
        Me.BunifuMaterialTextboxServiceNo.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuMaterialTextboxServiceNo.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextboxServiceNo.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuMaterialTextboxServiceNo.LineThickness = 3
        Me.BunifuMaterialTextboxServiceNo.Location = New System.Drawing.Point(141, 72)
        Me.BunifuMaterialTextboxServiceNo.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BunifuMaterialTextboxServiceNo.Name = "BunifuMaterialTextboxServiceNo"
        Me.BunifuMaterialTextboxServiceNo.Size = New System.Drawing.Size(264, 36)
        Me.BunifuMaterialTextboxServiceNo.TabIndex = 15
        Me.BunifuMaterialTextboxServiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 128)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 25)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Mail "
        '
        'BunifuDatepickerDR
        '
        Me.BunifuDatepickerDR.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuDatepickerDR.BorderRadius = 0
        Me.BunifuDatepickerDR.ForeColor = System.Drawing.Color.White
        Me.BunifuDatepickerDR.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.BunifuDatepickerDR.FormatCustom = Nothing
        Me.BunifuDatepickerDR.Location = New System.Drawing.Point(168, 280)
        Me.BunifuDatepickerDR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuDatepickerDR.Name = "BunifuDatepickerDR"
        Me.BunifuDatepickerDR.Size = New System.Drawing.Size(237, 44)
        Me.BunifuDatepickerDR.TabIndex = 13
        Me.BunifuDatepickerDR.Value = New Date(2024, 7, 20, 0, 0, 0, 0)
        '
        'BunifuDatepickerDE
        '
        Me.BunifuDatepickerDE.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuDatepickerDE.BorderRadius = 0
        Me.BunifuDatepickerDE.ForeColor = System.Drawing.Color.White
        Me.BunifuDatepickerDE.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.BunifuDatepickerDE.FormatCustom = Nothing
        Me.BunifuDatepickerDE.Location = New System.Drawing.Point(168, 220)
        Me.BunifuDatepickerDE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuDatepickerDE.Name = "BunifuDatepickerDE"
        Me.BunifuDatepickerDE.Size = New System.Drawing.Size(237, 44)
        Me.BunifuDatepickerDE.TabIndex = 13
        Me.BunifuDatepickerDE.Value = New Date(2024, 7, 20, 0, 0, 0, 0)
        '
        'BunifuMaterialTextboxStaffId
        '
        Me.BunifuMaterialTextboxStaffId.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuMaterialTextboxStaffId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextboxStaffId.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuMaterialTextboxStaffId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextboxStaffId.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextboxStaffId.HintText = ""
        Me.BunifuMaterialTextboxStaffId.isPassword = False
        Me.BunifuMaterialTextboxStaffId.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuMaterialTextboxStaffId.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextboxStaffId.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuMaterialTextboxStaffId.LineThickness = 3
        Me.BunifuMaterialTextboxStaffId.Location = New System.Drawing.Point(141, 22)
        Me.BunifuMaterialTextboxStaffId.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BunifuMaterialTextboxStaffId.Name = "BunifuMaterialTextboxStaffId"
        Me.BunifuMaterialTextboxStaffId.Size = New System.Drawing.Size(264, 36)
        Me.BunifuMaterialTextboxStaffId.TabIndex = 13
        Me.BunifuMaterialTextboxStaffId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuDropdownRank
        '
        Me.BunifuDropdownRank.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdownRank.BorderRadius = 3
        Me.BunifuDropdownRank.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuDropdownRank.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdownRank.Items = New String(-1) {}
        Me.BunifuDropdownRank.Location = New System.Drawing.Point(168, 174)
        Me.BunifuDropdownRank.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuDropdownRank.Name = "BunifuDropdownRank"
        Me.BunifuDropdownRank.NomalColor = System.Drawing.Color.SeaGreen
        Me.BunifuDropdownRank.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuDropdownRank.selectedIndex = -1
        Me.BunifuDropdownRank.Size = New System.Drawing.Size(237, 38)
        Me.BunifuDropdownRank.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 291)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 25)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Date Reported"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 231)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 25)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Date Employed"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 181)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 25)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Rank"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "StaffId"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Service No."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.BunifuDatepickerDOB)
        Me.GroupBox1.Controls.Add(Me.BunifuMaterialTextboxOname)
        Me.GroupBox1.Controls.Add(Me.BunifuMaterialTextboxSname)
        Me.GroupBox1.Controls.Add(Me.BunifuMaterialTextboxContac)
        Me.GroupBox1.Controls.Add(Me.BunifuMaterialTextboxFName)
        Me.GroupBox1.Controls.Add(Me.BunifuDropdownGender)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 342)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 230)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 25)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Contact No."
        '
        'BunifuDatepickerDOB
        '
        Me.BunifuDatepickerDOB.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuDatepickerDOB.BorderRadius = 0
        Me.BunifuDatepickerDOB.ForeColor = System.Drawing.Color.White
        Me.BunifuDatepickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.BunifuDatepickerDOB.FormatCustom = Nothing
        Me.BunifuDatepickerDOB.Location = New System.Drawing.Point(153, 276)
        Me.BunifuDatepickerDOB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuDatepickerDOB.Name = "BunifuDatepickerDOB"
        Me.BunifuDatepickerDOB.Size = New System.Drawing.Size(237, 44)
        Me.BunifuDatepickerDOB.TabIndex = 12
        Me.BunifuDatepickerDOB.Value = New Date(2024, 7, 20, 0, 0, 0, 0)
        '
        'BunifuMaterialTextboxOname
        '
        Me.BunifuMaterialTextboxOname.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuMaterialTextboxOname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextboxOname.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuMaterialTextboxOname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextboxOname.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextboxOname.HintText = ""
        Me.BunifuMaterialTextboxOname.isPassword = False
        Me.BunifuMaterialTextboxOname.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuMaterialTextboxOname.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextboxOname.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuMaterialTextboxOname.LineThickness = 3
        Me.BunifuMaterialTextboxOname.Location = New System.Drawing.Point(153, 168)
        Me.BunifuMaterialTextboxOname.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BunifuMaterialTextboxOname.Name = "BunifuMaterialTextboxOname"
        Me.BunifuMaterialTextboxOname.Size = New System.Drawing.Size(237, 36)
        Me.BunifuMaterialTextboxOname.TabIndex = 11
        Me.BunifuMaterialTextboxOname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMaterialTextboxSname
        '
        Me.BunifuMaterialTextboxSname.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuMaterialTextboxSname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextboxSname.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuMaterialTextboxSname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextboxSname.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextboxSname.HintText = ""
        Me.BunifuMaterialTextboxSname.isPassword = False
        Me.BunifuMaterialTextboxSname.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuMaterialTextboxSname.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextboxSname.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuMaterialTextboxSname.LineThickness = 3
        Me.BunifuMaterialTextboxSname.Location = New System.Drawing.Point(134, 119)
        Me.BunifuMaterialTextboxSname.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BunifuMaterialTextboxSname.Name = "BunifuMaterialTextboxSname"
        Me.BunifuMaterialTextboxSname.Size = New System.Drawing.Size(256, 36)
        Me.BunifuMaterialTextboxSname.TabIndex = 10
        Me.BunifuMaterialTextboxSname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMaterialTextboxContac
        '
        Me.BunifuMaterialTextboxContac.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuMaterialTextboxContac.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextboxContac.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuMaterialTextboxContac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextboxContac.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextboxContac.HintText = ""
        Me.BunifuMaterialTextboxContac.isPassword = False
        Me.BunifuMaterialTextboxContac.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuMaterialTextboxContac.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextboxContac.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuMaterialTextboxContac.LineThickness = 3
        Me.BunifuMaterialTextboxContac.Location = New System.Drawing.Point(153, 218)
        Me.BunifuMaterialTextboxContac.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BunifuMaterialTextboxContac.Name = "BunifuMaterialTextboxContac"
        Me.BunifuMaterialTextboxContac.Size = New System.Drawing.Size(237, 36)
        Me.BunifuMaterialTextboxContac.TabIndex = 12
        Me.BunifuMaterialTextboxContac.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMaterialTextboxFName
        '
        Me.BunifuMaterialTextboxFName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuMaterialTextboxFName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextboxFName.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuMaterialTextboxFName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextboxFName.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextboxFName.HintText = ""
        Me.BunifuMaterialTextboxFName.isPassword = False
        Me.BunifuMaterialTextboxFName.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuMaterialTextboxFName.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextboxFName.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuMaterialTextboxFName.LineThickness = 3
        Me.BunifuMaterialTextboxFName.Location = New System.Drawing.Point(134, 73)
        Me.BunifuMaterialTextboxFName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.BunifuMaterialTextboxFName.Name = "BunifuMaterialTextboxFName"
        Me.BunifuMaterialTextboxFName.Size = New System.Drawing.Size(256, 36)
        Me.BunifuMaterialTextboxFName.TabIndex = 9
        Me.BunifuMaterialTextboxFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuDropdownGender
        '
        Me.BunifuDropdownGender.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdownGender.BorderRadius = 3
        Me.BunifuDropdownGender.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuDropdownGender.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdownGender.Items = New String(-1) {}
        Me.BunifuDropdownGender.Location = New System.Drawing.Point(134, 27)
        Me.BunifuDropdownGender.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuDropdownGender.Name = "BunifuDropdownGender"
        Me.BunifuDropdownGender.NomalColor = System.Drawing.Color.SeaGreen
        Me.BunifuDropdownGender.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuDropdownGender.selectedIndex = -1
        Me.BunifuDropdownGender.Size = New System.Drawing.Size(179, 38)
        Me.BunifuDropdownGender.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 25)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Date of Birth"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 25)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Other Name(s)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 25)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Surname"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Gender"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(825, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "REGISTER TO LOG IN"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.MediumSpringGreen
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(113, 388)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(145, 20)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "TAKE A PICTURE"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.BunifuThinButton22)
        Me.Panel3.Controls.Add(Me.BunifuThinButton21)
        Me.Panel3.Controls.Add(Me.LinkLabel1)
        Me.Panel3.Controls.Add(Me.ImageBox1)
        Me.Panel3.Location = New System.Drawing.Point(1283, 71)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(390, 671)
        Me.Panel3.TabIndex = 4
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.DarkRed
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.Red
        Me.BunifuThinButton22.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "CLEAR"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.Red
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.OrangeRed
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.OrangeRed
        Me.BunifuThinButton22.Location = New System.Drawing.Point(107, 477)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(181, 41)
        Me.BunifuThinButton22.TabIndex = 5
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "SUBMIT"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.Location = New System.Drawing.Point(107, 528)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(181, 41)
        Me.BunifuThinButton21.TabIndex = 4
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImageBox1
        '
        Me.ImageBox1.BackgroundImage = Global.AuthDesktop.My.Resources.Resources.WhatsApp_Image_2024_07_18_at_12_07_09_AM
        Me.ImageBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImageBox1.Location = New System.Drawing.Point(51, 14)
        Me.ImageBox1.Name = "ImageBox1"
        Me.ImageBox1.Size = New System.Drawing.Size(297, 304)
        Me.ImageBox1.TabIndex = 2
        Me.ImageBox1.TabStop = False
        '
        'signIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1744, 928)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "signIn"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ImageBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BunifuDropdownGender As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuDropdownRank As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents BunifuMaterialTextboxFName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextboxStaffId As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextboxContac As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextboxOname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextboxSname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuDatepickerDOB As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents BunifuDatepickerDE As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents BunifuDatepickerDR As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents BunifuCustomDataGrid1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents ImageBox1 As Emgu.CV.UI.ImageBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuMaterialTextboxServiceNo As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
