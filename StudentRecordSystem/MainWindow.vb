Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.IO
Imports System.Windows.Forms.VisualStyles

Public Class MainWindow
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Departments_tblTableAdapter.Fill(Me.DepartmentDataSet.departments_tbl)   ' Fill the profile data table
        Me.Profiles_tblTableAdapter.Fill(Me.ProfilesDataSet.profiles_tbl)           ' Fill the profile data table
        Me.Students_tblTableAdapter.Fill(Me.SrsdbDataSet.students_tbl)              ' Fill the students data table

        ' Bind the department data table to the department combo box
        departmentComboBox.DataSource = Me.DepartmentDataSet.departments_tbl
        departmentComboBox.DisplayMember = My.Resources.departmentNameColumn
        departmentComboBox.ValueMember = My.Resources.departmentIdColumn
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
    Private Sub OnHoverBtns(sender As Object, e As EventArgs) Handles exitBtn.Click, addStudentBtn.Click
        If sender.Equals(exitBtn) Then
            Me.Close()
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
        If Me.WindowState = FormWindowState.Maximized Then
            modal.Size = New Drawing.Size(Me.Width / 3, Me.Height - 350)
        Else
            modal.Size = New Drawing.Size(Me.Width - 400, Me.Height - 10)
        End If
        Try
            With studentsRecordView.CurrentRow.Cells
                modal.studentNoTextBox.Text = .Item(1).Value                                                                                        ' Student Number
                modal.nameTextBox.Text = .Item(2).Value & " " & .Item(3).Value                                                                      ' Student's Name
                modal.courseTextBox.Text = .Item(4).Value                                                                                           ' Course
                modal.genderTextBox.Text = If(.Item(5).Value = My.Resources.femaleInitial, My.Resources.femaleText, My.Resources.maleText)          ' Gender
                modal.contactTextBox.Text = .Item(6).Value                                                                                          ' Contact
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

    Private Sub searchTextBox_IconRightClick(sender As Object, e As EventArgs) Handles searchTextBox.IconRightClick
        Dim query As String = searchTextBox.Text
        If Not String.IsNullOrEmpty(searchTextBox.Text) Then
            Me.Students_tblTableAdapter.FillByQuery(Me.SrsdbDataSet.students_tbl, query)
        Else
            Me.Students_tblTableAdapter.Fill(Me.SrsdbDataSet.students_tbl)
        End If

    End Sub
    Private Sub departmentComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles departmentComboBox.SelectionChangeCommitted
        Me.Students_tblTableAdapter.FillByDepartmentId(Me.SrsdbDataSet.students_tbl, departmentComboBox.SelectedValue)
    End Sub
#End Region
End Class