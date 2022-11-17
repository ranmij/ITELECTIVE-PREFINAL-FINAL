Imports System.IO
Imports StudentRecordSystem.srsdbDataSetTableAdapters

Public Class MainWindow
    Private ProfileAdapter As New profiles_tblTableAdapter
    Private DepartmentAdapter As New departments_tblTableAdapter
    Private collections As IEnumerable(Of Dictionary(Of String, String))
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Students_tblTableAdapter.Fill(Me.SrsdbDataSet.students_tbl)
        ProfileAdapter.Fill(Me.SrsdbDataSet.profiles_tbl)
        DepartmentAdapter.Fill(Me.SrsdbDataSet.departments_tbl)
        departmentComboBox.DataSource = Me.SrsdbDataSet.Tables(2)
        departmentComboBox.DisplayMember = "department_name"
        RefreshData()
        SaveProfile()
    End Sub

    Private Sub RefreshData()
        collections = From r As DataRow In Me.SrsdbDataSet.profiles_tbl.AsEnumerable()
                      Select New Dictionary(Of String, String) From {
                          {"id", r.Field(Of Integer)("id")},
                          {"image_path", r.Field(Of String)("image_path")}
                      }
    End Sub

    Private Function SaveProfile(Optional filePath As String = Nothing) As Boolean
        If Directory.Exists("D:\StudentsProfile") Then
            If File.Exists(filePath) AndAlso filePath IsNot Nothing Then
                File.Copy(filePath, "D:\StudentsProfile\" & Path.GetRandomFileName() & ".jpg")
                Return True
            End If
        Else
            My.Computer.FileSystem.CreateDirectory("D:\StudentsProfile")
            If File.Exists(filePath) AndAlso Directory.Exists("D:\StudentsProfile") AndAlso filePath IsNot Nothing Then
                File.Copy(filePath, "D:\StudentsProfile\" & Path.GetRandomFileName() & ".jpg")
                Return True
            End If
        End If
        Return False
    End Function

    Private Sub studentsRecordView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentsRecordView.CellClick
        Dim form As New Form
        Try
            Dim modal As New Modal
            With studentsRecordView.CurrentRow.Cells
                modal.studentNoData.Text = .Item(1).Value
                modal.nameData.Text = .Item(2).Value & " " & .Item(3).Value
                modal.courseData.Text = .Item(4).Value
                modal.genderData.Text = .Item(5).Value
                modal.contactData.Text = .Item(6).Value
                Dim id As Integer = .Item(8).Value
                For Each element In collections
                    Console.WriteLine(element.Item("id"))
                    If element.Item("id") = id Then
                        modal.studentProfilePicture.Image = Image.FromFile(element.Item("image_path"))
                    End If
                Next
            End With
            modal.Owner = Me
            modal.ShowDialog()
        Catch ex As Exception
            form.Dispose()
        End Try
    End Sub

#Region "HoverEffects"
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