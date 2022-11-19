Imports System.IO
Imports StudentRecordSystem.srsdbDataSetTableAdapters

Public Class MainWindow
    Private DepartmentAdapter As New departments_tblTableAdapter
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Profiles_tblTableAdapter.Fill(Me.ProfilesDataSet.profiles_tbl)
        Me.Students_tblTableAdapter.Fill(Me.SrsdbDataSet.students_tbl)
        DepartmentAdapter.Fill(Me.SrsdbDataSet.departments_tbl)
        departmentComboBox.DataSource = Me.SrsdbDataSet.Tables(2)
        departmentComboBox.DisplayMember = "department_name"
    End Sub
#Region "CustomFunctions"
    Public Function SaveProfile(Optional filePath As String = Nothing) As String
        Dim randomFileName As String = "D:\StudentsProfile\" & Path.GetRandomFileName() & If(filePath.EndsWith(".png"), ".png", ".jpg")
        If Directory.Exists("D:\StudentsProfile") Then
            If File.Exists(filePath) AndAlso filePath IsNot Nothing Then
                File.Copy(filePath, randomFileName)
                Return randomFileName
            End If
        Else
            My.Computer.FileSystem.CreateDirectory("D:\StudentsProfile")
            If File.Exists(filePath) AndAlso Directory.Exists("D:\StudentsProfile") AndAlso filePath IsNot Nothing Then
                File.Copy(filePath, randomFileName)
                Return randomFileName
            End If
        End If
        Return Nothing
    End Function
#End Region
    Private Sub studentsRecordView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentsRecordView.CellClick
        Dim modal As New Modal
        Try
            With studentsRecordView.CurrentRow.Cells
                modal.studentNoData.Text = .Item(1).Value
                modal.nameData.Text = .Item(2).Value & " " & .Item(3).Value
                modal.courseData.Text = .Item(4).Value
                modal.genderData.Text = .Item(5).Value
                modal.contactData.Text = .Item(6).Value
                Dim id As Integer = If(IsNumeric(.Item(8).Value), .Item(8).Value, Nothing)
                For Each row As DataRow In Me.ProfilesDataSet.profiles_tbl.AsEnumerable
                    If IsNumeric(row.Item("id")) AndAlso row.Item("id") = id Then
                        modal.studentProfilePicture.Image = Image.FromFile(row.Item("image_path"))
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

#Region "Click Events"
    Private Sub OnHoverBtns(sender As Object, e As EventArgs) Handles exitBtn.Click, maximizeBtn.Click, minimizeBtn.Click
        If sender.Equals(exitBtn) Then
            Me.Close()
        ElseIf sender.Equals(maximizeBtn) Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf sender.Equals(minimizeBtn) Then
            Me.WindowState = FormWindowState.Minimized
        End If

    End Sub
#End Region
End Class