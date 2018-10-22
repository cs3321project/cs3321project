Public Class Admin_ChangeExamScores
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub StudentData_ChrisBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StudentData_ChrisBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentData_ChrisDataSet)

    End Sub

    Private Sub StudentData_ChrisBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles StudentData_ChrisBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StudentData_ChrisBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentData_ChrisDataSet)

    End Sub

    Private Sub Admin_ChangeExamScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Me.Validate()
            Me.WindowState = FormWindowState.Normal

            'TODO: This line of code loads data into the 'StudentData_ChrisDataSet.studentData_Chris' table. You can move, or remove it, as needed.
            Me.DataTable1TableAdapter.FillBy(Me.StudentData_ChrisDataSet.DataTable1)
            '   Me.StudentData_ChrisBindingSource.EndEdit()
            ' Me.TableAdapterManager.UpdateAll(Me.StudentData_ChrisDataSet)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub StudentData_ChrisBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles StudentData_ChrisBindingNavigator.RefreshItems

    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Dim exam1 As Integer = Exam1TextBox.Text
        Dim exam2 As Integer = Exam2TextBox.Text
        Dim exam3 As Integer = Exam3TextBox.Text
        Dim exam4 As Integer = Exam4TextBox.Text
        Dim avg As Double = (exam1 + exam2 + exam3 + exam4) / 4
        Dim GPA As Decimal = ((exam1 + exam2 + exam3 + exam4) / 400) * 4
        Try
            Me.Validate()
            Me.DataTable1TableAdapter.UpdateAVG()
            Me.DataTable1TableAdapter.UpdateGPA()


            Me.StudentData_ChrisBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.StudentData_ChrisDataSet)
            Class_AVGTextBox.Text = avg.ToString()
            GPATextBox.Text = GPA.ToString()

        Catch ex As Exception
            MessageBox.Show("Scores Have Been Updated")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form As New Admin_ViewStudentData
        form.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)


    End Sub


End Class