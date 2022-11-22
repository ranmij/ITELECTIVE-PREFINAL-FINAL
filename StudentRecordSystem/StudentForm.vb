Imports System.Data.SqlClient
Imports System.IO

Public Class StudentForm
    Private filePath As String = Nothing
    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        departmentComboBox.DataSource = MainWindow.DepartmentDataSet.departments_tbl
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
                ' Check if all the fields are not empty.
                If textBoxes.All(Function(textBox) Not String.IsNullOrEmpty(textBox.Text)) AndAlso gender <> Nothing AndAlso String.IsNullOrEmpty(departmentComboBox.SelectedText) Then
                    ' Inserts profile and student's information
                    If MainWindow.Profiles_tblTableAdapter.insertImage(filePath) <> 0 Then
                        If MainWindow.Students_tblTableAdapter.InsertStudentQuery(student_no:=studentNoTextBox.Text, first_name:=firstNameTextBox.Text, last_name:=lastNameTextBox.Text,
                                                       course:=courseTextBox.Text, gender:=gender, phone:=phoneNumberTextBox.Text, department_id:=Convert.ToInt32(departmentComboBox.SelectedValue), fileDir:=filePath) <> 0 Then
                            onSuccess.Caption = My.Resources.successCaption
                            onSuccess.Text = My.Resources.successStudentText
                            onSuccess.Show()
                            MainWindow.Students_tblTableAdapter.Fill(MainWindow.SrsdbDataSet.students_tbl)
                            MainWindow.studentsRecordView.Rows(0).Selected = False
                            MainWindow.Profiles_tblTableAdapter.Fill(MainWindow.ProfilesDataSet.profiles_tbl)
                            Me.Close()
                        End If
                    Else
                        onError.Caption = My.Resources.errorCaption
                        onError.Text = My.Resources.savingImageErrorText
                        onError.Show()
                    End If
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