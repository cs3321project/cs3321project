Public Class AddRemove_Student
    Private Sub StudentData_ChrisBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DataTable1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentData_ChrisDataSet)

    End Sub

    Private Sub AddRemove_Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
        Me.DataTable1TableAdapter.FillByName(Me.StudentData_ChrisDataSet.DataTable1)

        If ComboBox1.Text = Nothing Then
            Try
                DataTable1BindingSource.AddNew()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            DataTable1BindingSource.AddNew()
            Student_NameTextBox1.Select()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Select Case MsgBox("Are you sure you want to delete the student?", MsgBoxStyle.YesNo, "Confirmation")
            Case MsgBoxResult.Yes
                Try
                    DataTable1BindingSource.RemoveCurrent()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Case MsgBoxResult.No
                ' do nothing'
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            DataTable1BindingSource.MovePrevious()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            DataTable1BindingSource.MoveNext()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If Student_NameTextBox1.Text = Nothing Then
            Student_NameTextBox1.Text = "Unknown"
        End If
        If Exam1TextBox1.Text = Nothing Then
            Exam1TextBox1.Text = "Unknown"
        End If
        If Exam2TextBox1.Text = Nothing Then
            Exam2TextBox1.Text = "Unknown"

        End If
        If Exam3TextBox1.Text = Nothing Then
            Exam3TextBox1.Text = "Unknown"
        End If
        If Class_AVGTextBox1.Text = Nothing Then
            Class_AVGTextBox1.Text = "Unknown"
        End If
        Try
            Me.Validate()
            Me.DataTable1BindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.StudentData_ChrisDataSet)
            MessageBox.Show("New Student has been added", "Information", MessageBoxButtons.OK)
            DataTable1BindingSource.AddNew()
            Student_NameTextBox1.Select()

        Catch ex As Exception
            MessageBox.Show("Complete", "Information", MessageBoxButtons.OK)
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Close()
    End Sub


End Class