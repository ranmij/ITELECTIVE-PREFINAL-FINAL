<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Modal
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
        Me.modalStyle = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.updateBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.studentProfilePicture = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.nameLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.genderLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.studentLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.courseLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.contactLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.modalLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.addStudentImage = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.closeStudentForm = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.studentNoTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.nameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.courseTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.genderTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.contactTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.deleteBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.ModalMessageDialog = New Guna.UI2.WinForms.Guna2MessageDialog()
        CType(Me.studentProfilePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'modalStyle
        '
        Me.modalStyle.AnimateWindow = True
        Me.modalStyle.BorderRadius = 2
        Me.modalStyle.ContainerControl = Me
        Me.modalStyle.DockIndicatorTransparencyValue = 0.6R
        Me.modalStyle.ResizeForm = False
        Me.modalStyle.TransparentWhileDrag = True
        '
        'updateBtn
        '
        Me.updateBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.updateBtn.AutoRoundedCorners = True
        Me.updateBtn.BackColor = System.Drawing.Color.Transparent
        Me.updateBtn.BorderRadius = 15
        Me.updateBtn.BorderThickness = 1
        Me.updateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.updateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.updateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.updateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.updateBtn.FillColor = System.Drawing.Color.Transparent
        Me.updateBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.updateBtn.ForeColor = System.Drawing.Color.Black
        Me.updateBtn.HoverState.FillColor = System.Drawing.Color.Black
        Me.updateBtn.HoverState.ForeColor = System.Drawing.Color.White
        Me.updateBtn.Location = New System.Drawing.Point(235, 443)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(114, 33)
        Me.updateBtn.TabIndex = 0
        Me.updateBtn.Text = "Update"
        Me.updateBtn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase
        '
        'studentProfilePicture
        '
        Me.studentProfilePicture.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.studentProfilePicture.BackColor = System.Drawing.Color.Transparent
        Me.studentProfilePicture.ImageRotate = 0!
        Me.studentProfilePicture.Location = New System.Drawing.Point(91, 77)
        Me.studentProfilePicture.Name = "studentProfilePicture"
        Me.studentProfilePicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.studentProfilePicture.Size = New System.Drawing.Size(162, 155)
        Me.studentProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.studentProfilePicture.TabIndex = 1
        Me.studentProfilePicture.TabStop = False
        '
        'nameLabel
        '
        Me.nameLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nameLabel.BackColor = System.Drawing.Color.Transparent
        Me.nameLabel.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(34, 297)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(58, 27)
        Me.nameLabel.TabIndex = 2
        Me.nameLabel.Text = Global.StudentRecordSystem.My.Resources.Resources.nameLabel
        '
        'genderLabel
        '
        Me.genderLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.genderLabel.BackColor = System.Drawing.Color.Transparent
        Me.genderLabel.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genderLabel.Location = New System.Drawing.Point(34, 363)
        Me.genderLabel.Name = "genderLabel"
        Me.genderLabel.Size = New System.Drawing.Size(77, 27)
        Me.genderLabel.TabIndex = 3
        Me.genderLabel.Text = Global.StudentRecordSystem.My.Resources.Resources.genderLabel
        '
        'studentLabel
        '
        Me.studentLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.studentLabel.BackColor = System.Drawing.Color.Transparent
        Me.studentLabel.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentLabel.Location = New System.Drawing.Point(34, 264)
        Me.studentLabel.Name = "studentLabel"
        Me.studentLabel.Size = New System.Drawing.Size(116, 27)
        Me.studentLabel.TabIndex = 4
        Me.studentLabel.Text = Global.StudentRecordSystem.My.Resources.Resources.studentNoLabel
        '
        'courseLabel
        '
        Me.courseLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.courseLabel.BackColor = System.Drawing.Color.Transparent
        Me.courseLabel.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseLabel.Location = New System.Drawing.Point(34, 330)
        Me.courseLabel.Name = "courseLabel"
        Me.courseLabel.Size = New System.Drawing.Size(75, 27)
        Me.courseLabel.TabIndex = 5
        Me.courseLabel.Text = Global.StudentRecordSystem.My.Resources.Resources.courseLabel
        '
        'contactLabel
        '
        Me.contactLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.contactLabel.BackColor = System.Drawing.Color.Transparent
        Me.contactLabel.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactLabel.Location = New System.Drawing.Point(34, 396)
        Me.contactLabel.Name = "contactLabel"
        Me.contactLabel.Size = New System.Drawing.Size(90, 27)
        Me.contactLabel.TabIndex = 6
        Me.contactLabel.Text = Global.StudentRecordSystem.My.Resources.Resources.contactLabel
        '
        'modalLabel
        '
        Me.modalLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.modalLabel.BackColor = System.Drawing.Color.Transparent
        Me.modalLabel.Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modalLabel.Location = New System.Drawing.Point(73, 24)
        Me.modalLabel.Name = "modalLabel"
        Me.modalLabel.Size = New System.Drawing.Size(230, 32)
        Me.modalLabel.TabIndex = 12
        Me.modalLabel.Text = Global.StudentRecordSystem.My.Resources.Resources.modalWindowLabel
        '
        'addStudentImage
        '
        Me.addStudentImage.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.addStudentImage.BackColor = System.Drawing.Color.Transparent
        Me.addStudentImage.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.addStudentImage.HoverState.Image = Global.StudentRecordSystem.My.Resources.Resources.upload
        Me.addStudentImage.HoverState.ImageSize = New System.Drawing.Size(24, 24)
        Me.addStudentImage.Image = Global.StudentRecordSystem.My.Resources.Resources.upload
        Me.addStudentImage.ImageOffset = New System.Drawing.Point(0, 0)
        Me.addStudentImage.ImageRotate = 0!
        Me.addStudentImage.ImageSize = New System.Drawing.Size(24, 24)
        Me.addStudentImage.Location = New System.Drawing.Point(140, 126)
        Me.addStudentImage.Name = "addStudentImage"
        Me.addStudentImage.PressedState.Image = Global.StudentRecordSystem.My.Resources.Resources.upload
        Me.addStudentImage.PressedState.ImageSize = New System.Drawing.Size(24, 24)
        Me.addStudentImage.Size = New System.Drawing.Size(64, 54)
        Me.addStudentImage.TabIndex = 13
        Me.addStudentImage.UseTransparentBackground = True
        '
        'closeStudentForm
        '
        Me.closeStudentForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeStudentForm.BackColor = System.Drawing.Color.Transparent
        Me.closeStudentForm.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.closeStudentForm.HoverState.Image = Global.StudentRecordSystem.My.Resources.Resources.close
        Me.closeStudentForm.HoverState.ImageSize = New System.Drawing.Size(16, 16)
        Me.closeStudentForm.Image = Global.StudentRecordSystem.My.Resources.Resources.close
        Me.closeStudentForm.ImageOffset = New System.Drawing.Point(0, 0)
        Me.closeStudentForm.ImageRotate = 0!
        Me.closeStudentForm.ImageSize = New System.Drawing.Size(16, 16)
        Me.closeStudentForm.Location = New System.Drawing.Point(347, 2)
        Me.closeStudentForm.Name = "closeStudentForm"
        Me.closeStudentForm.PressedState.Image = Global.StudentRecordSystem.My.Resources.Resources.close
        Me.closeStudentForm.PressedState.ImageSize = New System.Drawing.Size(16, 16)
        Me.closeStudentForm.Size = New System.Drawing.Size(31, 28)
        Me.closeStudentForm.TabIndex = 19
        Me.closeStudentForm.UseTransparentBackground = True
        '
        'studentNoTextBox
        '
        Me.studentNoTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.studentNoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.studentNoTextBox.DefaultText = ""
        Me.studentNoTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.studentNoTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.studentNoTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.studentNoTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.studentNoTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.studentNoTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.studentNoTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.studentNoTextBox.Location = New System.Drawing.Point(162, 264)
        Me.studentNoTextBox.Name = "studentNoTextBox"
        Me.studentNoTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.studentNoTextBox.PlaceholderText = ""
        Me.studentNoTextBox.SelectedText = ""
        Me.studentNoTextBox.Size = New System.Drawing.Size(187, 27)
        Me.studentNoTextBox.TabIndex = 20
        '
        'nameTextBox
        '
        Me.nameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nameTextBox.DefaultText = ""
        Me.nameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.nameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.nameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.nameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.nameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.nameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nameTextBox.Location = New System.Drawing.Point(162, 297)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nameTextBox.PlaceholderText = ""
        Me.nameTextBox.SelectedText = ""
        Me.nameTextBox.Size = New System.Drawing.Size(187, 27)
        Me.nameTextBox.TabIndex = 21
        '
        'courseTextBox
        '
        Me.courseTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.courseTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.courseTextBox.DefaultText = ""
        Me.courseTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.courseTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.courseTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.courseTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.courseTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.courseTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.courseTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.courseTextBox.Location = New System.Drawing.Point(162, 330)
        Me.courseTextBox.Name = "courseTextBox"
        Me.courseTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.courseTextBox.PlaceholderText = ""
        Me.courseTextBox.SelectedText = ""
        Me.courseTextBox.Size = New System.Drawing.Size(187, 27)
        Me.courseTextBox.TabIndex = 22
        '
        'genderTextBox
        '
        Me.genderTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.genderTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.genderTextBox.DefaultText = ""
        Me.genderTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.genderTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.genderTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.genderTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.genderTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.genderTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.genderTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.genderTextBox.Location = New System.Drawing.Point(162, 363)
        Me.genderTextBox.Name = "genderTextBox"
        Me.genderTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.genderTextBox.PlaceholderText = ""
        Me.genderTextBox.SelectedText = ""
        Me.genderTextBox.Size = New System.Drawing.Size(187, 27)
        Me.genderTextBox.TabIndex = 23
        '
        'contactTextBox
        '
        Me.contactTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.contactTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.contactTextBox.DefaultText = ""
        Me.contactTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.contactTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.contactTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.contactTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.contactTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.contactTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.contactTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.contactTextBox.Location = New System.Drawing.Point(162, 396)
        Me.contactTextBox.Name = "contactTextBox"
        Me.contactTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.contactTextBox.PlaceholderText = ""
        Me.contactTextBox.SelectedText = ""
        Me.contactTextBox.Size = New System.Drawing.Size(187, 27)
        Me.contactTextBox.TabIndex = 24
        '
        'deleteBtn
        '
        Me.deleteBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.deleteBtn.AutoRoundedCorners = True
        Me.deleteBtn.BackColor = System.Drawing.Color.Transparent
        Me.deleteBtn.BorderRadius = 15
        Me.deleteBtn.BorderThickness = 1
        Me.deleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.deleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.deleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.deleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.deleteBtn.FillColor = System.Drawing.Color.Transparent
        Me.deleteBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.deleteBtn.ForeColor = System.Drawing.Color.Black
        Me.deleteBtn.HoverState.FillColor = System.Drawing.Color.Black
        Me.deleteBtn.HoverState.ForeColor = System.Drawing.Color.White
        Me.deleteBtn.Location = New System.Drawing.Point(34, 443)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(114, 33)
        Me.deleteBtn.TabIndex = 25
        Me.deleteBtn.Text = "Delete"
        Me.deleteBtn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase
        '
        'ModalMessageDialog
        '
        Me.ModalMessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.ModalMessageDialog.Caption = Nothing
        Me.ModalMessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.None
        Me.ModalMessageDialog.Parent = Me
        Me.ModalMessageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.[Default]
        Me.ModalMessageDialog.Text = Nothing
        '
        'Modal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 498)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.contactTextBox)
        Me.Controls.Add(Me.genderTextBox)
        Me.Controls.Add(Me.courseTextBox)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.studentNoTextBox)
        Me.Controls.Add(Me.closeStudentForm)
        Me.Controls.Add(Me.addStudentImage)
        Me.Controls.Add(Me.modalLabel)
        Me.Controls.Add(Me.contactLabel)
        Me.Controls.Add(Me.courseLabel)
        Me.Controls.Add(Me.studentLabel)
        Me.Controls.Add(Me.genderLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.studentProfilePicture)
        Me.Controls.Add(Me.updateBtn)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Modal"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update"
        Me.TopMost = True
        CType(Me.studentProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents modalStyle As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents nameLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents studentProfilePicture As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents updateBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents courseLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents studentLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents genderLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents contactLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents modalLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents addStudentImage As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents closeStudentForm As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents contactTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents genderTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents courseTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents nameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents studentNoTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents deleteBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ModalMessageDialog As Guna.UI2.WinForms.Guna2MessageDialog
End Class
