Imports System.Data.SqlClient
Imports System.IO
Imports Guna.UI2.WinForms

Public Class Modal
    Private Sub Click_Events(sender As Object, e As EventArgs) Handles updateBtn.Click, closeStudentForm.Click, deleteBtn.Click
        If sender.Equals(updateBtn) Then
            Dim fullNameData() As String = nameTextBox.Text.Split(" ")
            Dim lastName = fullNameData(fullNameData.Length - 1)
            Dim firstName = If(fullNameData.Length > 2, String.Join(" ", fullNameData.Skip(fullNameData.Length - 1)), fullNameData(0))
            Dim textBoxes = {studentNoTextBox.Text, courseTextBox.Text, genderTextBox.Text.ElementAt(0), contactTextBox.Text}
            Dim entry_id = MainWindow.studentsRecordView.CurrentRow.Cells(0).Value
            If MainWindow.Students_tblTableAdapter.UpdateStudentDataQuery(studentNoTextBox.Text, firstName, lastName, courseTextBox.Text, genderTextBox.Text.ElementAt(0).ToString.ToUpper(), contactTextBox.Text, entry_id) <> 0 Then
                ModalMessageDialog.Caption = My.Resources.successCaption
                ModalMessageDialog.Text = My.Resources.successStudentText
                ModalMessageDialog.Show()
            Else
                ModalMessageDialog.Icon = MessageDialogIcon.Error
                ModalMessageDialog.Caption = My.Resources.errorCaption
                ModalMessageDialog.Text = My.Resources.unknownErrrorText
                ModalMessageDialog.Show()
            End If
            ' Refresh the data table then set the current row again aaaaaaaand refresh profile datatable
            Dim rowIndex As Integer = MainWindow.studentsRecordView.CurrentRow.Index
            MainWindow.Students_tblTableAdapter.Fill(MainWindow.SrsdbDataSet.students_tbl)
            MainWindow.studentsRecordView.Rows(0).Selected = False
            MainWindow.studentsRecordView.Rows(rowIndex).Selected = True
            MainWindow.Profiles_tblTableAdapter.Fill(MainWindow.ProfilesDataSet.profiles_tbl)
            Me.Close()
        ElseIf sender.Equals(deleteBtn) Then
            Dim entry_id = MainWindow.studentsRecordView.CurrentRow.Cells(0).Value
            If MainWindow.Students_tblTableAdapter.DeleteStudentDataQuery(entry_id) <> 0 Then
                ModalMessageDialog.Caption = My.Resources.successCaption
                ModalMessageDialog.Text = My.Resources.successDeleteText
                ModalMessageDialog.Show()
            Else
                ModalMessageDialog.Icon = MessageDialogIcon.Error
                ModalMessageDialog.Caption = My.Resources.errorCaption
                ModalMessageDialog.Text = My.Resources.unknownErrrorText
                ModalMessageDialog.Show()
            End If
            MainWindow.Students_tblTableAdapter.Fill(MainWindow.SrsdbDataSet.students_tbl)
            Me.Close()
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