Imports System.Data.SqlClient
Imports System.IO

Public Class Modal
    Private connection As New SqlConnection(My.Settings.srsdbConnectionString)
    Private Sub okBtn_Click(sender As Object, e As EventArgs) Handles okBtn.Click
        Me.Close()
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
                connection.Open()
                ' Inserts the profile the table
                Using cmd As New SqlCommand($"INSERT INTO profiles_tbl VALUES ('{fileName}')", connection)
                    If cmd.ExecuteNonQuery() <> 0 Then
                        Dim id As Integer = MainWindow.studentsRecordView.CurrentRow.Cells.Item(0).Value
                        ' Update the user's data
                        Using ncmd As New SqlCommand($"UPDATE students_tbl SET profile_id = (SELECT id FROM profiles_tbl WHERE image_path = '{fileName}') WHERE id = {id}", connection)
                            If ncmd.ExecuteNonQuery() <> 0 Then
                                addStudentImage.Visible = False
                                studentProfilePicture.Image = Image.FromFile(fileName)
                            End If
                        End Using
                    End If
                End Using
            End If
        End If

        ' Refresh the data table then set the current row again aaaaaaaand refresh profile datatable
        Dim rowIndex As Integer = MainWindow.studentsRecordView.CurrentRow.Index
        MainWindow.Students_tblTableAdapter.Fill(MainWindow.SrsdbDataSet.students_tbl)
        MainWindow.studentsRecordView.Rows(0).Selected = False
        MainWindow.studentsRecordView.Rows(rowIndex).Selected = True
        MainWindow.Profiles_tblTableAdapter.Fill(MainWindow.ProfilesDataSet.profiles_tbl)
    End Sub
End Class