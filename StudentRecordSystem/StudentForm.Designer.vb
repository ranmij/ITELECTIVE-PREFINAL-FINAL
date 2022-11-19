<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentForm
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
        Me.studentFormStyle = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.onSuccess = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.onError = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.studentNoLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.firstNameLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lastNameLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.courseLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.departmentLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.studentNoTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.firstNameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lastNameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.courseTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.studentProfilePicture = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.addImage = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.addStudentBtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.departmentComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.closeStudentForm = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.femaleRadioBtn = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.maleRadioBtn = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.phoneNumberLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.phoneNumberTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.studentProfilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'studentFormStyle
        '
        Me.studentFormStyle.AnimateWindow = True
        Me.studentFormStyle.BorderRadius = 2
        Me.studentFormStyle.ContainerControl = Me
        Me.studentFormStyle.DockIndicatorTransparencyValue = 0.6R
        Me.studentFormStyle.ResizeForm = False
        Me.studentFormStyle.ShadowColor = System.Drawing.Color.DimGray
        Me.studentFormStyle.TransparentWhileDrag = True
        '
        'onSuccess
        '
        Me.onSuccess.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.onSuccess.Caption = Nothing
        Me.onSuccess.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information
        Me.onSuccess.Parent = Nothing
        Me.onSuccess.Style = Guna.UI2.WinForms.MessageDialogStyle.Light
        Me.onSuccess.Text = Nothing
        '
        'onError
        '
        Me.onError.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.onError.Caption = Nothing
        Me.onError.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning
        Me.onError.Parent = Nothing
        Me.onError.Style = Guna.UI2.WinForms.MessageDialogStyle.Light
        Me.onError.Text = Nothing
        '
        'studentNoLabel
        '
        Me.studentNoLabel.BackColor = System.Drawing.Color.Transparent
        Me.studentNoLabel.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentNoLabel.Location = New System.Drawing.Point(46, 197)
        Me.studentNoLabel.Margin = New System.Windows.Forms.Padding(4)
        Me.studentNoLabel.Name = "studentNoLabel"
        Me.studentNoLabel.Size = New System.Drawing.Size(116, 27)
        Me.studentNoLabel.TabIndex = 0
        Me.studentNoLabel.Text = "STUDENT NO:"
        '
        'firstNameLabel
        '
        Me.firstNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.firstNameLabel.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNameLabel.Location = New System.Drawing.Point(46, 232)
        Me.firstNameLabel.Margin = New System.Windows.Forms.Padding(4)
        Me.firstNameLabel.Name = "firstNameLabel"
        Me.firstNameLabel.Size = New System.Drawing.Size(106, 27)
        Me.firstNameLabel.TabIndex = 1
        Me.firstNameLabel.Text = "FIRST NAME:"
        '
        'lastNameLabel
        '
        Me.lastNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.lastNameLabel.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNameLabel.Location = New System.Drawing.Point(46, 267)
        Me.lastNameLabel.Margin = New System.Windows.Forms.Padding(4)
        Me.lastNameLabel.Name = "lastNameLabel"
        Me.lastNameLabel.Size = New System.Drawing.Size(103, 27)
        Me.lastNameLabel.TabIndex = 2
        Me.lastNameLabel.Text = "LAST NAME:"
        '
        'courseLabel
        '
        Me.courseLabel.BackColor = System.Drawing.Color.Transparent
        Me.courseLabel.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseLabel.Location = New System.Drawing.Point(46, 302)
        Me.courseLabel.Margin = New System.Windows.Forms.Padding(4)
        Me.courseLabel.Name = "courseLabel"
        Me.courseLabel.Size = New System.Drawing.Size(75, 27)
        Me.courseLabel.TabIndex = 3
        Me.courseLabel.Text = "COURSE:"
        '
        'departmentLabel
        '
        Me.departmentLabel.BackColor = System.Drawing.Color.Transparent
        Me.departmentLabel.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departmentLabel.Location = New System.Drawing.Point(46, 372)
        Me.departmentLabel.Margin = New System.Windows.Forms.Padding(4)
        Me.departmentLabel.Name = "departmentLabel"
        Me.departmentLabel.Size = New System.Drawing.Size(122, 27)
        Me.departmentLabel.TabIndex = 5
        Me.departmentLabel.Text = "DEPARTMENT:"
        '
        'studentNoTextBox
        '
        Me.studentNoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.studentNoTextBox.DefaultText = ""
        Me.studentNoTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.studentNoTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.studentNoTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.studentNoTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.studentNoTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.studentNoTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.studentNoTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.studentNoTextBox.Location = New System.Drawing.Point(196, 197)
        Me.studentNoTextBox.Name = "studentNoTextBox"
        Me.studentNoTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.studentNoTextBox.PlaceholderText = ""
        Me.studentNoTextBox.SelectedText = ""
        Me.studentNoTextBox.Size = New System.Drawing.Size(258, 27)
        Me.studentNoTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.studentNoTextBox.TabIndex = 7
        '
        'firstNameTextBox
        '
        Me.firstNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.firstNameTextBox.DefaultText = ""
        Me.firstNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.firstNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.firstNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.firstNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.firstNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.firstNameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.firstNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.firstNameTextBox.Location = New System.Drawing.Point(196, 232)
        Me.firstNameTextBox.Name = "firstNameTextBox"
        Me.firstNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.firstNameTextBox.PlaceholderText = ""
        Me.firstNameTextBox.SelectedText = ""
        Me.firstNameTextBox.Size = New System.Drawing.Size(258, 27)
        Me.firstNameTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.firstNameTextBox.TabIndex = 8
        '
        'lastNameTextBox
        '
        Me.lastNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lastNameTextBox.DefaultText = ""
        Me.lastNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lastNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lastNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lastNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lastNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.lastNameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lastNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.lastNameTextBox.Location = New System.Drawing.Point(196, 267)
        Me.lastNameTextBox.Name = "lastNameTextBox"
        Me.lastNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lastNameTextBox.PlaceholderText = ""
        Me.lastNameTextBox.SelectedText = ""
        Me.lastNameTextBox.Size = New System.Drawing.Size(258, 27)
        Me.lastNameTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.lastNameTextBox.TabIndex = 9
        '
        'courseTextBox
        '
        Me.courseTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.courseTextBox.DefaultText = ""
        Me.courseTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.courseTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.courseTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.courseTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.courseTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.courseTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.courseTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.courseTextBox.Location = New System.Drawing.Point(196, 302)
        Me.courseTextBox.Name = "courseTextBox"
        Me.courseTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.courseTextBox.PlaceholderText = ""
        Me.courseTextBox.SelectedText = ""
        Me.courseTextBox.Size = New System.Drawing.Size(258, 27)
        Me.courseTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.courseTextBox.TabIndex = 10
        '
        'studentProfilePicture
        '
        Me.studentProfilePicture.BorderRadius = 2
        Me.studentProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.studentProfilePicture.ImageRotate = 0!
        Me.studentProfilePicture.Location = New System.Drawing.Point(152, 26)
        Me.studentProfilePicture.Name = "studentProfilePicture"
        Me.studentProfilePicture.Size = New System.Drawing.Size(204, 149)
        Me.studentProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.studentProfilePicture.TabIndex = 13
        Me.studentProfilePicture.TabStop = False
        '
        'addImage
        '
        Me.addImage.BackColor = System.Drawing.Color.Transparent
        Me.addImage.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.addImage.HoverState.Image = Global.StudentRecordSystem.My.Resources.Resources.upload
        Me.addImage.HoverState.ImageSize = New System.Drawing.Size(24, 24)
        Me.addImage.Image = Global.StudentRecordSystem.My.Resources.Resources.upload
        Me.addImage.ImageOffset = New System.Drawing.Point(0, 0)
        Me.addImage.ImageRotate = 0!
        Me.addImage.ImageSize = New System.Drawing.Size(24, 24)
        Me.addImage.Location = New System.Drawing.Point(224, 74)
        Me.addImage.Name = "addImage"
        Me.addImage.PressedState.Image = Global.StudentRecordSystem.My.Resources.Resources.upload
        Me.addImage.PressedState.ImageSize = New System.Drawing.Size(24, 24)
        Me.addImage.Size = New System.Drawing.Size(64, 54)
        Me.addImage.TabIndex = 15
        Me.addImage.UseTransparentBackground = True
        '
        'addStudentBtn
        '
        Me.addStudentBtn.AutoRoundedCorners = True
        Me.addStudentBtn.BorderRadius = 15
        Me.addStudentBtn.BorderThickness = 1
        Me.addStudentBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addStudentBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addStudentBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addStudentBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addStudentBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addStudentBtn.FillColor = System.Drawing.Color.Transparent
        Me.addStudentBtn.FillColor2 = System.Drawing.Color.Transparent
        Me.addStudentBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.addStudentBtn.ForeColor = System.Drawing.Color.Black
        Me.addStudentBtn.HoverState.FillColor = System.Drawing.Color.Black
        Me.addStudentBtn.HoverState.FillColor2 = System.Drawing.Color.Black
        Me.addStudentBtn.HoverState.ForeColor = System.Drawing.Color.White
        Me.addStudentBtn.Location = New System.Drawing.Point(317, 463)
        Me.addStudentBtn.Name = "addStudentBtn"
        Me.addStudentBtn.Size = New System.Drawing.Size(137, 33)
        Me.addStudentBtn.TabIndex = 16
        Me.addStudentBtn.Text = "Add Student"
        '
        'departmentComboBox
        '
        Me.departmentComboBox.BackColor = System.Drawing.Color.Transparent
        Me.departmentComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.departmentComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.departmentComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.departmentComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.departmentComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.departmentComboBox.ItemHeight = 30
        Me.departmentComboBox.Location = New System.Drawing.Point(196, 372)
        Me.departmentComboBox.Name = "departmentComboBox"
        Me.departmentComboBox.Size = New System.Drawing.Size(258, 36)
        Me.departmentComboBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.departmentComboBox.TabIndex = 17
        '
        'closeStudentForm
        '
        Me.closeStudentForm.BackColor = System.Drawing.Color.Transparent
        Me.closeStudentForm.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.closeStudentForm.HoverState.Image = Global.StudentRecordSystem.My.Resources.Resources.close
        Me.closeStudentForm.HoverState.ImageSize = New System.Drawing.Size(16, 16)
        Me.closeStudentForm.Image = Global.StudentRecordSystem.My.Resources.Resources.close
        Me.closeStudentForm.ImageOffset = New System.Drawing.Point(0, 0)
        Me.closeStudentForm.ImageRotate = 0!
        Me.closeStudentForm.ImageSize = New System.Drawing.Size(16, 16)
        Me.closeStudentForm.Location = New System.Drawing.Point(474, 0)
        Me.closeStudentForm.Name = "closeStudentForm"
        Me.closeStudentForm.PressedState.Image = Global.StudentRecordSystem.My.Resources.Resources.close
        Me.closeStudentForm.PressedState.ImageSize = New System.Drawing.Size(16, 16)
        Me.closeStudentForm.Size = New System.Drawing.Size(31, 28)
        Me.closeStudentForm.TabIndex = 18
        Me.closeStudentForm.UseTransparentBackground = True
        '
        'femaleRadioBtn
        '
        Me.femaleRadioBtn.AutoSize = True
        Me.femaleRadioBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.femaleRadioBtn.CheckedState.BorderThickness = 0
        Me.femaleRadioBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.femaleRadioBtn.CheckedState.InnerColor = System.Drawing.Color.White
        Me.femaleRadioBtn.CheckedState.InnerOffset = -4
        Me.femaleRadioBtn.Location = New System.Drawing.Point(196, 414)
        Me.femaleRadioBtn.Name = "femaleRadioBtn"
        Me.femaleRadioBtn.Size = New System.Drawing.Size(67, 21)
        Me.femaleRadioBtn.TabIndex = 19
        Me.femaleRadioBtn.Text = "Female"
        Me.femaleRadioBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.femaleRadioBtn.UncheckedState.BorderThickness = 2
        Me.femaleRadioBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.femaleRadioBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'maleRadioBtn
        '
        Me.maleRadioBtn.AutoSize = True
        Me.maleRadioBtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.maleRadioBtn.CheckedState.BorderThickness = 0
        Me.maleRadioBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.maleRadioBtn.CheckedState.InnerColor = System.Drawing.Color.White
        Me.maleRadioBtn.CheckedState.InnerOffset = -4
        Me.maleRadioBtn.Location = New System.Drawing.Point(399, 414)
        Me.maleRadioBtn.Name = "maleRadioBtn"
        Me.maleRadioBtn.Size = New System.Drawing.Size(55, 21)
        Me.maleRadioBtn.TabIndex = 20
        Me.maleRadioBtn.Text = "Male"
        Me.maleRadioBtn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.maleRadioBtn.UncheckedState.BorderThickness = 2
        Me.maleRadioBtn.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.maleRadioBtn.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'phoneNumberLabel
        '
        Me.phoneNumberLabel.BackColor = System.Drawing.Color.Transparent
        Me.phoneNumberLabel.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneNumberLabel.Location = New System.Drawing.Point(46, 337)
        Me.phoneNumberLabel.Margin = New System.Windows.Forms.Padding(4)
        Me.phoneNumberLabel.Name = "phoneNumberLabel"
        Me.phoneNumberLabel.Size = New System.Drawing.Size(67, 27)
        Me.phoneNumberLabel.TabIndex = 21
        Me.phoneNumberLabel.Text = "PHONE:"
        '
        'phoneNumberTextBox
        '
        Me.phoneNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.phoneNumberTextBox.DefaultText = ""
        Me.phoneNumberTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.phoneNumberTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.phoneNumberTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.phoneNumberTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.phoneNumberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.phoneNumberTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.phoneNumberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.phoneNumberTextBox.Location = New System.Drawing.Point(196, 337)
        Me.phoneNumberTextBox.Name = "phoneNumberTextBox"
        Me.phoneNumberTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.phoneNumberTextBox.PlaceholderText = ""
        Me.phoneNumberTextBox.SelectedText = ""
        Me.phoneNumberTextBox.Size = New System.Drawing.Size(258, 27)
        Me.phoneNumberTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.phoneNumberTextBox.TabIndex = 22
        '
        'StudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 508)
        Me.Controls.Add(Me.phoneNumberTextBox)
        Me.Controls.Add(Me.phoneNumberLabel)
        Me.Controls.Add(Me.maleRadioBtn)
        Me.Controls.Add(Me.femaleRadioBtn)
        Me.Controls.Add(Me.closeStudentForm)
        Me.Controls.Add(Me.departmentComboBox)
        Me.Controls.Add(Me.addStudentBtn)
        Me.Controls.Add(Me.addImage)
        Me.Controls.Add(Me.studentProfilePicture)
        Me.Controls.Add(Me.courseTextBox)
        Me.Controls.Add(Me.lastNameTextBox)
        Me.Controls.Add(Me.firstNameTextBox)
        Me.Controls.Add(Me.studentNoTextBox)
        Me.Controls.Add(Me.departmentLabel)
        Me.Controls.Add(Me.courseLabel)
        Me.Controls.Add(Me.lastNameLabel)
        Me.Controls.Add(Me.firstNameLabel)
        Me.Controls.Add(Me.studentNoLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "StudentForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.studentProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents studentFormStyle As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents onSuccess As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents onError As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents courseLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lastNameLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents firstNameLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents studentNoLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents studentProfilePicture As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents courseTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lastNameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents firstNameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents studentNoTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents departmentLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents addImage As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents addStudentBtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents departmentComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents closeStudentForm As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents maleRadioBtn As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents femaleRadioBtn As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents phoneNumberTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents phoneNumberLabel As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
