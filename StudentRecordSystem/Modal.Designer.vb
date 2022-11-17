﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.okBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.studentProfilePicture = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.nameLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.genderLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.studentLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.courseLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.contactLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.studentNoData = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.nameData = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.courseData = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.genderData = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.contactData = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
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
        'okBtn
        '
        Me.okBtn.AutoRoundedCorners = True
        Me.okBtn.BackColor = System.Drawing.Color.Transparent
        Me.okBtn.BorderRadius = 15
        Me.okBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.okBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.okBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.okBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.okBtn.FillColor = System.Drawing.Color.Black
        Me.okBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.okBtn.ForeColor = System.Drawing.Color.White
        Me.okBtn.Location = New System.Drawing.Point(340, 444)
        Me.okBtn.Name = "okBtn"
        Me.okBtn.Size = New System.Drawing.Size(111, 32)
        Me.okBtn.TabIndex = 0
        Me.okBtn.Text = "Ok"
        '
        'studentProfilePicture
        '
        Me.studentProfilePicture.BackColor = System.Drawing.Color.Transparent
        Me.studentProfilePicture.ImageRotate = 0!
        Me.studentProfilePicture.Location = New System.Drawing.Point(138, 64)
        Me.studentProfilePicture.Name = "studentProfilePicture"
        Me.studentProfilePicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.studentProfilePicture.Size = New System.Drawing.Size(190, 171)
        Me.studentProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.studentProfilePicture.TabIndex = 1
        Me.studentProfilePicture.TabStop = False
        '
        'nameLabel
        '
        Me.nameLabel.BackColor = System.Drawing.Color.Transparent
        Me.nameLabel.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(42, 285)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(58, 27)
        Me.nameLabel.TabIndex = 2
        Me.nameLabel.Text = "NAME:"
        '
        'genderLabel
        '
        Me.genderLabel.BackColor = System.Drawing.Color.Transparent
        Me.genderLabel.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genderLabel.Location = New System.Drawing.Point(42, 351)
        Me.genderLabel.Name = "genderLabel"
        Me.genderLabel.Size = New System.Drawing.Size(77, 27)
        Me.genderLabel.TabIndex = 3
        Me.genderLabel.Text = "GENDER:"
        '
        'studentLabel
        '
        Me.studentLabel.BackColor = System.Drawing.Color.Transparent
        Me.studentLabel.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentLabel.Location = New System.Drawing.Point(42, 252)
        Me.studentLabel.Name = "studentLabel"
        Me.studentLabel.Size = New System.Drawing.Size(116, 27)
        Me.studentLabel.TabIndex = 4
        Me.studentLabel.Text = "STUDENT NO:"
        '
        'courseLabel
        '
        Me.courseLabel.BackColor = System.Drawing.Color.Transparent
        Me.courseLabel.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseLabel.Location = New System.Drawing.Point(42, 318)
        Me.courseLabel.Name = "courseLabel"
        Me.courseLabel.Size = New System.Drawing.Size(75, 27)
        Me.courseLabel.TabIndex = 5
        Me.courseLabel.Text = "COURSE:"
        '
        'contactLabel
        '
        Me.contactLabel.BackColor = System.Drawing.Color.Transparent
        Me.contactLabel.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactLabel.Location = New System.Drawing.Point(42, 384)
        Me.contactLabel.Name = "contactLabel"
        Me.contactLabel.Size = New System.Drawing.Size(90, 27)
        Me.contactLabel.TabIndex = 6
        Me.contactLabel.Text = "CONTACT:"
        '
        'studentNoData
        '
        Me.studentNoData.BackColor = System.Drawing.Color.Transparent
        Me.studentNoData.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentNoData.Location = New System.Drawing.Point(164, 252)
        Me.studentNoData.Name = "studentNoData"
        Me.studentNoData.Size = New System.Drawing.Size(34, 27)
        Me.studentNoData.TabIndex = 7
        Me.studentNoData.Text = "Null"
        '
        'nameData
        '
        Me.nameData.BackColor = System.Drawing.Color.Transparent
        Me.nameData.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameData.Location = New System.Drawing.Point(106, 285)
        Me.nameData.Name = "nameData"
        Me.nameData.Size = New System.Drawing.Size(34, 27)
        Me.nameData.TabIndex = 8
        Me.nameData.Text = "Null"
        '
        'courseData
        '
        Me.courseData.BackColor = System.Drawing.Color.Transparent
        Me.courseData.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseData.Location = New System.Drawing.Point(123, 318)
        Me.courseData.Name = "courseData"
        Me.courseData.Size = New System.Drawing.Size(34, 27)
        Me.courseData.TabIndex = 9
        Me.courseData.Text = "Null"
        '
        'genderData
        '
        Me.genderData.BackColor = System.Drawing.Color.Transparent
        Me.genderData.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genderData.Location = New System.Drawing.Point(125, 351)
        Me.genderData.Name = "genderData"
        Me.genderData.Size = New System.Drawing.Size(34, 27)
        Me.genderData.TabIndex = 10
        Me.genderData.Text = "Null"
        '
        'contactData
        '
        Me.contactData.BackColor = System.Drawing.Color.Transparent
        Me.contactData.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactData.Location = New System.Drawing.Point(138, 384)
        Me.contactData.Name = "contactData"
        Me.contactData.Size = New System.Drawing.Size(34, 27)
        Me.contactData.TabIndex = 11
        Me.contactData.Text = "Null"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(138, 21)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(205, 27)
        Me.Guna2HtmlLabel1.TabIndex = 12
        Me.Guna2HtmlLabel1.Text = "STUDENT INFORMATION"
        '
        'Modal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 488)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.contactData)
        Me.Controls.Add(Me.genderData)
        Me.Controls.Add(Me.courseData)
        Me.Controls.Add(Me.nameData)
        Me.Controls.Add(Me.studentNoData)
        Me.Controls.Add(Me.contactLabel)
        Me.Controls.Add(Me.courseLabel)
        Me.Controls.Add(Me.studentLabel)
        Me.Controls.Add(Me.genderLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.studentProfilePicture)
        Me.Controls.Add(Me.okBtn)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Modal"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.studentProfilePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents modalStyle As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents nameLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents studentProfilePicture As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents okBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents courseLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents studentLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents genderLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents contactLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents contactData As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents genderData As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents courseData As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents nameData As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents studentNoData As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class