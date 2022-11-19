Imports System.Data.SqlClient
Imports System.IO

Public Class StudentForm
    Private connection As New SqlConnection(My.Settings.srsdbConnectionString)
    Private filePath As String = Nothing
    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        departmentComboBox.DataSource = MainWindow.SrsdbDataSet.Tables(1)
        departmentComboBox.DisplayMember = My.Resources.departmentNameColumn
        departmentComboBox.ValueMember = My.Resources.departmentIdColumn
    End Sub
    Private Sub addImage_Click(sender As Object, e As EventArgs) Handles addImage.Click
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
                filePath = fileName
                addImage.Visible = False
                studentProfilePicture.Image = Image.FromFile(fileName)
                MainWindow.Profiles_tblTableAdapter.Fill(MainWindow.ProfilesDataSet.profiles_tbl)
            Else
                onSuccess.Caption = My.Resources.errorCaption
                onSuccess.Text = My.Resources.copyErrorText
                onSuccess.Show()
            End If
        End If
    End Sub

#Region "Click Events"
    Private Sub ClickEvents(sender As Object, e As EventArgs) Handles addStudentBtn.Click, closeStudentForm.Click
        Dim textBoxes() As Object = {studentNoTextBox, firstNameTextBox, lastNameTextBox, courseTextBox, phoneNumberTextBox}
        Dim gender = If(maleRadioBtn.Checked, My.Resources.maleInitial, If(femaleRadioBtn.Checked, My.Resources.femaleInitial, Nothing))
        If sender.Equals(addStudentBtn) Then
            If filePath <> Nothing Then
                If textBoxes.All(Function(textBox) Not String.IsNullOrEmpty(textBox.Text)) AndAlso gender <> Nothing AndAlso String.IsNullOrEmpty(departmentComboBox.SelectedText) Then
                    connection.Open()
                    Using pcmd As New SqlCommand($"INSERT INTO profiles_tbl VALUES ('{filePath}')", connection)
                        If pcmd.ExecuteNonQuery() <> 0 Then
                            pcmd.Dispose()
                            Using cmd As New SqlCommand("INSERT INTO students_tbl (student_no, first_name, last_name, course, gender, phone, department_id, profile_id) VALUES " &
                            $"('{studentNoTextBox.Text}', '{firstNameTextBox.Text}', '{lastNameTextBox.Text}', '{courseTextBox.Text}', '{gender}', '{phoneNumberTextBox.Text}', {departmentComboBox.SelectedValue}, (SELECT id FROM profiles_tbl WHERE image_path = '{filePath}'))", connection)
                                If cmd.ExecuteNonQuery() <> 0 Then
                                    onSuccess.Caption = My.Resources.successCaption
                                    onSuccess.Text = My.Resources.successStudentText
                                    onSuccess.Show()
                                    MainWindow.Students_tblTableAdapter.Fill(MainWindow.SrsdbDataSet.students_tbl)
                                    MainWindow.studentsRecordView.Rows(0).Selected = False
                                    MainWindow.Profiles_tblTableAdapter.Fill(MainWindow.ProfilesDataSet.profiles_tbl)
                                    Me.Close()
                                Else
                                    onError.Caption = My.Resources.errorCaption
                                    onError.Text = My.Resources.unknownErrrorText
                                    onError.Show()
                                End If
                            End Using
                        Else
                            onError.Caption = My.Resources.errorCaption
                            onError.Text = My.Resources.savingImageErrorText
                            onError.Show()
                        End If
                    End Using
                Else
                    onError.Caption = My.Resources.invalidCaption
                    onError.Text = My.Resources.emptyFieldsErrorText
                    onError.Show()
                End If
            Else
                onSuccess.Caption = My.Resources.profileCaption
                onSuccess.Text = My.Resources.provideProfileErrorText
                onSuccess.Show()
            End If
        ElseIf sender.Equals(closeStudentForm) Then
            Me.Close()
        End If
    End Sub



#End Region
End Class