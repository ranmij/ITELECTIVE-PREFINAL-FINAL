Imports System.Data.SqlClient
Imports System.IO

Public Class Modal
    Private Sub Click_Events(sender As Object, e As EventArgs) Handles okBtn.Click, closeStudentForm.Click
        If sender.Equals(okBtn) Then
            ' Refresh the data table then set the current row again aaaaaaaand refresh profile datatable
            Dim rowIndex As Integer = MainWindow.studentsRecordView.CurrentRow.Index
            MainWindow.Students_tblTableAdapter.Fill(MainWindow.SrsdbDataSet.students_tbl)
            MainWindow.studentsRecordView.Rows(0).Selected = False
            MainWindow.studentsRecordView.Rows(rowIndex).Selected = True
            MainWindow.Profiles_tblTableAdapter.Fill(MainWindow.ProfilesDataSet.profiles_tbl)
        ElseIf sender.Equals(closeStudentForm) Then
            Me.Close()
        End If

    End Sub

    Public Sub AddImage(sender As Object, e As EventArgs) Handles addStudentImage.Click
        Dim fileDialog As New OpenFileDialog
        Dim fileName As String = Nothing
        ' For the file dialog
        fileDialog.Title = My.Resources.fileDialogTitle
        fileDialog.InitialDirectory = If(Directory.Exists(My.Resources.baseDDirectory), My.Resources.baseDDirectory, My.Resources.baseCDirectory)
        fileDialog.Filter = My.Resources.fileTypeFilter
        fileDialog.RestoreDirectory = True

        If fileDialog.ShowDialog() = DialogResult.OK Then
            fileName = MainWindow.SaveProfile(fileDialog.FileName)
            If fileName <> Nothing Then
                ' Inserts image to the table and update students.
                If MainWindow.Profiles_tblTableAdapter.insertImage(fileName) <> 0 Then
                    Dim id As Integer = MainWindow.studentsRecordView.CurrentRow.Cells.Item(0).Value
                    If MainWindow.Students_tblTableAdapter.UpdateStudentQuery(id, fileName) <> 0 Then
                        addStudentImage.Visible = False
                        studentProfilePicture.Image = Image.FromFile(fileName)
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub closeStudentForm_Click(sender As Object, e As EventArgs) Handles closeStudentForm.Click
        Me.Close()
    End Sub

End Class