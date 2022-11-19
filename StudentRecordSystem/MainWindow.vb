Imports System.Data.SqlClient
Imports System.IO
Imports StudentRecordSystem.srsdbDataSetTableAdapters

Public Class MainWindow
    Private connection As New SqlConnection(My.Settings.srsdbConnectionString)  ' Universal connection, even your mom can connect to it :>
    Private DepartmentAdapter As New departments_tblTableAdapter
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Profiles_tblTableAdapter.Fill(Me.ProfilesDataSet.profiles_tbl)   ' Fill the profile data table
        Me.Students_tblTableAdapter.Fill(Me.SrsdbDataSet.students_tbl)      ' Fill the students data table
        DepartmentAdapter.Fill(Me.SrsdbDataSet.departments_tbl)             ' Fill the department data table

        ' Bind the department data table to the department combo box
        departmentComboBox.DataSource = Me.SrsdbDataSet.Tables(1)
        departmentComboBox.DisplayMember = My.Resources.departmentNameColumn
    End Sub
#Region "CustomFunctions"
    ''' <summary>
    ''' (Create and) Copies the file to D:\StudentsProfile directory
    ''' </summary>
    ''' <param name="filePath">Path of the file selected from file dialog</param>
    ''' <returns> String that holds the random file name </returns>
    Public Function SaveProfile(Optional filePath As String = Nothing) As String
        ' Random name for the file
        Dim randomFileName As String = My.Resources.basePath & Path.GetRandomFileName() & If(filePath.EndsWith(My.Resources.pngType), My.Resources.pngType, My.Resources.jpgType)

        ' Copies the file to the designated directory
        If Directory.Exists(My.Resources.homeDirectory) Then
            If File.Exists(filePath) AndAlso filePath IsNot Nothing Then
                File.Copy(filePath, randomFileName)
                Return randomFileName
            End If
        Else
            My.Computer.FileSystem.CreateDirectory(My.Resources.homeDirectory)
            If File.Exists(filePath) AndAlso Directory.Exists(My.Resources.homeDirectory) AndAlso filePath IsNot Nothing Then
                File.Copy(filePath, randomFileName)
                Return randomFileName
            End If
        End If
        Return Nothing
    End Function
#End Region

    ' These are all the click events.
#Region "Click Events"
    Private Sub OnHoverBtns(sender As Object, e As EventArgs) Handles exitBtn.Click, maximizeBtn.Click, minimizeBtn.Click, addStudentBtn.Click
        If sender.Equals(exitBtn) Then
            Me.Close()
        ElseIf sender.Equals(maximizeBtn) Then

            If Me.WindowState = FormWindowState.Maximized Then
                Me.WindowState = FormWindowState.Normal
                maximizeBtn.Image = My.Resources.maximize
                maximizeBtn.HoverState.Image = My.Resources.maximize
                maximizeBtn.PressedState.Image = My.Resources.maximize
                Me.Size = New Drawing.Size(800, 522)
            Else
                maximizeBtn.Image = My.Resources.copy
                maximizeBtn.HoverState.Image = My.Resources.copy
                maximizeBtn.PressedState.Image = My.Resources.copy
                Me.WindowState = FormWindowState.Maximized
            End If
        ElseIf sender.Equals(minimizeBtn) Then
            Me.WindowState = FormWindowState.Minimized
        ElseIf sender.Equals(addStudentBtn) Then
            Dim studentModal As New StudentForm
            Try
                studentModal.Owner = Me
                studentModal.ShowDialog()
            Catch ex As Exception
                studentModal.Dispose()
            End Try
        End If
    End Sub
    Private Sub studentsRecordView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentsRecordView.CellClick
        Dim modal As New Modal
        Try
            With studentsRecordView.CurrentRow.Cells
                modal.studentNoData.Text = .Item(1).Value                                                                                        ' Student Number
                modal.nameData.Text = .Item(2).Value & " " & .Item(3).Value                                                                      ' Student's Name
                modal.courseData.Text = .Item(4).Value                                                                                           ' Course
                modal.genderData.Text = If(.Item(5).Value = My.Resources.femaleInitial, My.Resources.femaleText, My.Resources.maleText)          ' Gender
                modal.contactData.Text = .Item(6).Value                                                                                          ' Contact
                Dim id As Integer = If(IsNumeric(.Item(8).Value), .Item(8).Value, Nothing)                                                       ' profile id

                ' Check the profile if it exists in the profile table.
                ' The data table is always refreshing whenever the user add a picture.
                For Each row As DataRow In Me.ProfilesDataSet.profiles_tbl.AsEnumerable
                    If IsNumeric(row.Item(My.Resources.profileIdColumn)) AndAlso row.Item(My.Resources.profileIdColumn) = id Then
                        modal.studentProfilePicture.Image = Image.FromFile(row.Item(My.Resources.profileImagePathColumn))
                        modal.addStudentImage.Visible = False
                    End If
                Next
            End With
            modal.Owner = Me
            modal.ShowDialog()
        Catch ex As Exception
            modal.Dispose()
        End Try
    End Sub
#End Region
End Class