<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.MainWindowStyle = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.windowLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.studentsRecordView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentstblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SrsdbDataSet = New StudentRecordSystem.srsdbDataSet()
        Me.departmentComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.departmentLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.maximizeBtn = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.searchTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.minimizeBtn = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.exitBtn = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Students_tblTableAdapter = New StudentRecordSystem.srsdbDataSetTableAdapters.students_tblTableAdapter()
        CType(Me.studentsRecordView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentstblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SrsdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainWindowStyle
        '
        Me.MainWindowStyle.BorderRadius = 2
        Me.MainWindowStyle.ContainerControl = Me
        Me.MainWindowStyle.DockIndicatorTransparencyValue = 0.6R
        Me.MainWindowStyle.TransparentWhileDrag = True
        '
        'windowLabel
        '
        Me.windowLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.windowLabel.BackColor = System.Drawing.Color.Transparent
        Me.windowLabel.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.windowLabel.Location = New System.Drawing.Point(280, 71)
        Me.windowLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.windowLabel.Name = "windowLabel"
        Me.windowLabel.Size = New System.Drawing.Size(245, 39)
        Me.windowLabel.TabIndex = 0
        Me.windowLabel.Text = "STUDENTS RECORDS"
        '
        'studentsRecordView
        '
        Me.studentsRecordView.AllowUserToAddRows = False
        Me.studentsRecordView.AllowUserToDeleteRows = False
        Me.studentsRecordView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.studentsRecordView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.studentsRecordView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.studentsRecordView.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.studentsRecordView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.studentsRecordView.ColumnHeadersHeight = 29
        Me.studentsRecordView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.studentsRecordView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.studentsRecordView.DataSource = Me.StudentstblBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.studentsRecordView.DefaultCellStyle = DataGridViewCellStyle3
        Me.studentsRecordView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.studentsRecordView.Location = New System.Drawing.Point(37, 216)
        Me.studentsRecordView.Name = "studentsRecordView"
        Me.studentsRecordView.ReadOnly = True
        Me.studentsRecordView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.studentsRecordView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.studentsRecordView.RowHeadersVisible = False
        Me.studentsRecordView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSlateGray
        Me.studentsRecordView.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.studentsRecordView.Size = New System.Drawing.Size(722, 264)
        Me.studentsRecordView.TabIndex = 1
        Me.studentsRecordView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.studentsRecordView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.studentsRecordView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.studentsRecordView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.studentsRecordView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.studentsRecordView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.studentsRecordView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.studentsRecordView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.studentsRecordView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.studentsRecordView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentsRecordView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.studentsRecordView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.studentsRecordView.ThemeStyle.HeaderStyle.Height = 29
        Me.studentsRecordView.ThemeStyle.ReadOnly = True
        Me.studentsRecordView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.studentsRecordView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.studentsRecordView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentsRecordView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.studentsRecordView.ThemeStyle.RowsStyle.Height = 22
        Me.studentsRecordView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.studentsRecordView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "student_no"
        Me.DataGridViewTextBoxColumn2.HeaderText = "STUDENT NO."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "first_name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FIRST NAME"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "last_name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "LAST NAME"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "course"
        Me.DataGridViewTextBoxColumn5.HeaderText = "COURSE"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "gender"
        Me.DataGridViewTextBoxColumn6.HeaderText = "GENDER"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "phone"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CONTACT"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "department_id"
        Me.DataGridViewTextBoxColumn8.HeaderText = "department_id"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "profile_id"
        Me.DataGridViewTextBoxColumn9.HeaderText = "profile_id"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'StudentstblBindingSource
        '
        Me.StudentstblBindingSource.DataMember = "students_tbl"
        Me.StudentstblBindingSource.DataSource = Me.SrsdbDataSet
        '
        'SrsdbDataSet
        '
        Me.SrsdbDataSet.DataSetName = "srsdbDataSet"
        Me.SrsdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'departmentComboBox
        '
        Me.departmentComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.departmentComboBox.BackColor = System.Drawing.Color.Transparent
        Me.departmentComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.departmentComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.departmentComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.departmentComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.departmentComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.departmentComboBox.ItemHeight = 30
        Me.departmentComboBox.Location = New System.Drawing.Point(178, 154)
        Me.departmentComboBox.Name = "departmentComboBox"
        Me.departmentComboBox.Size = New System.Drawing.Size(181, 36)
        Me.departmentComboBox.TabIndex = 2
        '
        'departmentLabel
        '
        Me.departmentLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.departmentLabel.BackColor = System.Drawing.Color.Transparent
        Me.departmentLabel.Font = New System.Drawing.Font("Segoe UI Light", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departmentLabel.Location = New System.Drawing.Point(37, 153)
        Me.departmentLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.departmentLabel.Name = "departmentLabel"
        Me.departmentLabel.Size = New System.Drawing.Size(134, 37)
        Me.departmentLabel.TabIndex = 3
        Me.departmentLabel.Text = "Department:"
        '
        'maximizeBtn
        '
        Me.maximizeBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maximizeBtn.BackColor = System.Drawing.Color.Transparent
        Me.maximizeBtn.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.maximizeBtn.HoverState.Image = Global.StudentRecordSystem.My.Resources.Resources.maximize
        Me.maximizeBtn.HoverState.ImageSize = New System.Drawing.Size(16, 16)
        Me.maximizeBtn.Image = CType(resources.GetObject("maximizeBtn.Image"), System.Drawing.Image)
        Me.maximizeBtn.ImageOffset = New System.Drawing.Point(0, 0)
        Me.maximizeBtn.ImageRotate = 0!
        Me.maximizeBtn.ImageSize = New System.Drawing.Size(16, 16)
        Me.maximizeBtn.Location = New System.Drawing.Point(730, 0)
        Me.maximizeBtn.Name = "maximizeBtn"
        Me.maximizeBtn.PressedState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.maximizeBtn.PressedState.ImageSize = New System.Drawing.Size(16, 16)
        Me.maximizeBtn.Size = New System.Drawing.Size(29, 23)
        Me.maximizeBtn.TabIndex = 5
        Me.maximizeBtn.UseTransparentBackground = True
        '
        'searchTextBox
        '
        Me.searchTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchTextBox.AutoRoundedCorners = True
        Me.searchTextBox.BorderRadius = 17
        Me.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchTextBox.DefaultText = ""
        Me.searchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.searchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.searchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.searchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchTextBox.IconRight = Global.StudentRecordSystem.My.Resources.Resources.search
        Me.searchTextBox.IconRightSize = New System.Drawing.Size(16, 16)
        Me.searchTextBox.Location = New System.Drawing.Point(461, 153)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchTextBox.PlaceholderText = "Search"
        Me.searchTextBox.SelectedText = ""
        Me.searchTextBox.Size = New System.Drawing.Size(298, 36)
        Me.searchTextBox.TabIndex = 4
        '
        'minimizeBtn
        '
        Me.minimizeBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimizeBtn.BackColor = System.Drawing.Color.Transparent
        Me.minimizeBtn.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.minimizeBtn.HoverState.Image = Global.StudentRecordSystem.My.Resources.Resources.minus
        Me.minimizeBtn.HoverState.ImageSize = New System.Drawing.Size(16, 16)
        Me.minimizeBtn.Image = Global.StudentRecordSystem.My.Resources.Resources.minus
        Me.minimizeBtn.ImageOffset = New System.Drawing.Point(0, 0)
        Me.minimizeBtn.ImageRotate = 0!
        Me.minimizeBtn.ImageSize = New System.Drawing.Size(16, 16)
        Me.minimizeBtn.Location = New System.Drawing.Point(686, 0)
        Me.minimizeBtn.Name = "minimizeBtn"
        Me.minimizeBtn.PressedState.Image = Global.StudentRecordSystem.My.Resources.Resources.minus
        Me.minimizeBtn.PressedState.ImageSize = New System.Drawing.Size(16, 16)
        Me.minimizeBtn.Size = New System.Drawing.Size(29, 23)
        Me.minimizeBtn.TabIndex = 6
        Me.minimizeBtn.UseTransparentBackground = True
        '
        'exitBtn
        '
        Me.exitBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitBtn.BackColor = System.Drawing.Color.Transparent
        Me.exitBtn.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.exitBtn.HoverState.Image = Global.StudentRecordSystem.My.Resources.Resources.close
        Me.exitBtn.HoverState.ImageSize = New System.Drawing.Size(16, 16)
        Me.exitBtn.Image = Global.StudentRecordSystem.My.Resources.Resources.close
        Me.exitBtn.ImageOffset = New System.Drawing.Point(0, 0)
        Me.exitBtn.ImageRotate = 0!
        Me.exitBtn.ImageSize = New System.Drawing.Size(16, 16)
        Me.exitBtn.Location = New System.Drawing.Point(768, 0)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.PressedState.Image = Global.StudentRecordSystem.My.Resources.Resources.close
        Me.exitBtn.PressedState.ImageSize = New System.Drawing.Size(16, 16)
        Me.exitBtn.Size = New System.Drawing.Size(29, 23)
        Me.exitBtn.TabIndex = 7
        Me.exitBtn.UseTransparentBackground = True
        '
        'Students_tblTableAdapter
        '
        Me.Students_tblTableAdapter.ClearBeforeFill = True
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 522)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.minimizeBtn)
        Me.Controls.Add(Me.maximizeBtn)
        Me.Controls.Add(Me.searchTextBox)
        Me.Controls.Add(Me.departmentLabel)
        Me.Controls.Add(Me.departmentComboBox)
        Me.Controls.Add(Me.studentsRecordView)
        Me.Controls.Add(Me.windowLabel)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(800, 522)
        Me.Name = "MainWindow"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.studentsRecordView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentstblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SrsdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainWindowStyle As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents studentsRecordView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents windowLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents searchTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents departmentLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents departmentComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents maximizeBtn As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents minimizeBtn As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents exitBtn As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProfileidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SrsdbDataSet As srsdbDataSet
    Friend WithEvents StudentstblBindingSource As BindingSource
    Friend WithEvents Students_tblTableAdapter As srsdbDataSetTableAdapters.students_tblTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
End Class
