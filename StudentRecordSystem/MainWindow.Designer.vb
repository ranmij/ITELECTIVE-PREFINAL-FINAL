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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.DepartmentstblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentDataSet = New StudentRecordSystem.DepartmentDataSet()
        Me.departmentLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.searchTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.exitBtn = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.ProfilesDataSet = New StudentRecordSystem.ProfilesDataSet()
        Me.ProfilestblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Profiles_tblTableAdapter = New StudentRecordSystem.ProfilesDataSetTableAdapters.profiles_tblTableAdapter()
        Me.addStudentBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Students_tblTableAdapter = New StudentRecordSystem.srsdbDataSetTableAdapters.students_tblTableAdapter()
        Me.Departments_tblTableAdapter = New StudentRecordSystem.DepartmentDataSetTableAdapters.departments_tblTableAdapter()
        CType(Me.studentsRecordView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentstblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SrsdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentstblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfilesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfilestblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainWindowStyle
        '
        Me.MainWindowStyle.BorderRadius = 2
        Me.MainWindowStyle.ContainerControl = Me
        Me.MainWindowStyle.DockIndicatorTransparencyValue = 0.6R
        Me.MainWindowStyle.ResizeForm = False
        Me.MainWindowStyle.TransparentWhileDrag = True
        '
        'windowLabel
        '
        Me.windowLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.windowLabel.BackColor = System.Drawing.Color.Transparent
        Me.windowLabel.Font = New System.Drawing.Font("Segoe UI Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.windowLabel.Location = New System.Drawing.Point(280, 54)
        Me.windowLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.windowLabel.Name = "windowLabel"
        Me.windowLabel.Size = New System.Drawing.Size(245, 39)
        Me.windowLabel.TabIndex = 0
        Me.windowLabel.Text = Global.StudentRecordSystem.My.Resources.Resources.studentRecordWindowLabel
        '
        'studentsRecordView
        '
        Me.studentsRecordView.AllowUserToAddRows = False
        Me.studentsRecordView.AllowUserToDeleteRows = False
        Me.studentsRecordView.AllowUserToResizeRows = False
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        Me.studentsRecordView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.studentsRecordView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.studentsRecordView.AutoGenerateColumns = False
        Me.studentsRecordView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.studentsRecordView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.studentsRecordView.ColumnHeadersHeight = 29
        Me.studentsRecordView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.studentsRecordView.DataSource = Me.StudentstblBindingSource
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.studentsRecordView.DefaultCellStyle = DataGridViewCellStyle13
        Me.studentsRecordView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.studentsRecordView.Location = New System.Drawing.Point(37, 216)
        Me.studentsRecordView.Name = "studentsRecordView"
        Me.studentsRecordView.ReadOnly = True
        Me.studentsRecordView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightSlateGray
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.studentsRecordView.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.studentsRecordView.RowHeadersVisible = False
        Me.studentsRecordView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.LightSlateGray
        Me.studentsRecordView.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.studentsRecordView.Size = New System.Drawing.Size(722, 277)
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
        Me.studentsRecordView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
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
        Me.departmentComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.departmentComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.departmentComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.departmentComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.departmentComboBox.ItemHeight = 30
        Me.departmentComboBox.Location = New System.Drawing.Point(190, 126)
        Me.departmentComboBox.Name = "departmentComboBox"
        Me.departmentComboBox.Size = New System.Drawing.Size(181, 36)
        Me.departmentComboBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.departmentComboBox.TabIndex = 2
        '
        'DepartmentstblBindingSource
        '
        Me.DepartmentstblBindingSource.DataMember = "departments_tbl"
        Me.DepartmentstblBindingSource.DataSource = Me.DepartmentDataSet
        '
        'DepartmentDataSet
        '
        Me.DepartmentDataSet.DataSetName = "DepartmentDataSet"
        Me.DepartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'departmentLabel
        '
        Me.departmentLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.departmentLabel.BackColor = System.Drawing.Color.Transparent
        Me.departmentLabel.Font = New System.Drawing.Font("Segoe UI Light", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departmentLabel.Location = New System.Drawing.Point(37, 126)
        Me.departmentLabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.departmentLabel.Name = "departmentLabel"
        Me.departmentLabel.Size = New System.Drawing.Size(146, 33)
        Me.departmentLabel.TabIndex = 3
        Me.departmentLabel.Text = Global.StudentRecordSystem.My.Resources.Resources.departmentLabel
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
        Me.searchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.searchTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.searchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.searchTextBox.IconRight = Global.StudentRecordSystem.My.Resources.Resources.search
        Me.searchTextBox.IconRightSize = New System.Drawing.Size(16, 16)
        Me.searchTextBox.Location = New System.Drawing.Point(461, 122)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchTextBox.PlaceholderText = Global.StudentRecordSystem.My.Resources.Resources.searchHint
        Me.searchTextBox.SelectedText = ""
        Me.searchTextBox.Size = New System.Drawing.Size(298, 36)
        Me.searchTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.searchTextBox.TabIndex = 4
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
        Me.exitBtn.Location = New System.Drawing.Point(757, 0)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.PressedState.Image = Global.StudentRecordSystem.My.Resources.Resources.close
        Me.exitBtn.PressedState.ImageSize = New System.Drawing.Size(16, 16)
        Me.exitBtn.Size = New System.Drawing.Size(41, 33)
        Me.exitBtn.TabIndex = 7
        Me.exitBtn.UseTransparentBackground = True
        '
        'ProfilesDataSet
        '
        Me.ProfilesDataSet.DataSetName = "ProfilesDataSet"
        Me.ProfilesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProfilestblBindingSource
        '
        Me.ProfilestblBindingSource.DataMember = "profiles_tbl"
        Me.ProfilestblBindingSource.DataSource = Me.ProfilesDataSet
        '
        'Profiles_tblTableAdapter
        '
        Me.Profiles_tblTableAdapter.ClearBeforeFill = True
        '
        'addStudentBtn
        '
        Me.addStudentBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addStudentBtn.AutoRoundedCorners = True
        Me.addStudentBtn.BackColor = System.Drawing.Color.Transparent
        Me.addStudentBtn.BorderRadius = 17
        Me.addStudentBtn.BorderThickness = 1
        Me.addStudentBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addStudentBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addStudentBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addStudentBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addStudentBtn.FillColor = System.Drawing.Color.Transparent
        Me.addStudentBtn.FocusedColor = System.Drawing.Color.Transparent
        Me.addStudentBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.addStudentBtn.ForeColor = System.Drawing.Color.Black
        Me.addStudentBtn.HoverState.FillColor = System.Drawing.Color.Black
        Me.addStudentBtn.HoverState.ForeColor = System.Drawing.Color.White
        Me.addStudentBtn.Location = New System.Drawing.Point(619, 171)
        Me.addStudentBtn.Name = "addStudentBtn"
        Me.addStudentBtn.Size = New System.Drawing.Size(140, 36)
        Me.addStudentBtn.TabIndex = 8
        Me.addStudentBtn.Text = "Add Student"
        '
        'Students_tblTableAdapter
        '
        Me.Students_tblTableAdapter.ClearBeforeFill = True
        '
        'Departments_tblTableAdapter
        '
        Me.Departments_tblTableAdapter.ClearBeforeFill = True
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 522)
        Me.Controls.Add(Me.addStudentBtn)
        Me.Controls.Add(Me.exitBtn)
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
        CType(Me.DepartmentstblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfilesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfilestblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainWindowStyle As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents studentsRecordView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents windowLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents searchTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents departmentLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents departmentComboBox As Guna.UI2.WinForms.Guna2ComboBox
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
    Friend WithEvents ProfilesDataSet As ProfilesDataSet
    Friend WithEvents ProfilestblBindingSource As BindingSource
    Friend WithEvents Profiles_tblTableAdapter As ProfilesDataSetTableAdapters.profiles_tblTableAdapter
    Friend WithEvents addStudentBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DepartmentDataSet As DepartmentDataSet
    Friend WithEvents DepartmentstblBindingSource As BindingSource
    Friend WithEvents Departments_tblTableAdapter As DepartmentDataSetTableAdapters.departments_tblTableAdapter
End Class
