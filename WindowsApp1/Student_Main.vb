Public Class Student_Main
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentData_ChrisDataSet.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.UpdateGPA()
        Me.DataTable1TableAdapter.UpdateAVG()
        Me.TableAdapterManager.UpdateAll(Me.StudentData_ChrisDataSet)
        Me.DataTable1TableAdapter.SelectLoggedInStudent(Me.StudentData_ChrisDataSet.DataTable1)



    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DataTable1TableAdapter.setLogOutState(Student_NameTextBox.Text)
        Close()
    End Sub

    Private Sub rdoButtons_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton1.Click, RadioButton2.Click, RadioButton3.Click, RadioButton4.Click


        If RadioButton1.Checked Then
            Me.Validate()
            Me.DataTable1TableAdapter.FillENG_student(Me.StudentData_ChrisDataSet.DataTable1, Student_NameTextBox.Text)
        End If
        If RadioButton2.Checked Then
            Me.Validate()
            Me.DataTable1TableAdapter.FillMATH_student(Me.StudentData_ChrisDataSet.DataTable1, Student_NameTextBox.Text)
        End If
        If RadioButton3.Checked Then
            Me.Validate()
            Me.DataTable1TableAdapter.FillHIST_student(Me.StudentData_ChrisDataSet.DataTable1, Student_NameTextBox.Text)
        End If
        If RadioButton4.Checked Then
            Me.Validate()
            Me.DataTable1TableAdapter.FillSCI_student(Me.StudentData_ChrisDataSet.DataTable1, Student_NameTextBox.Text)
        End If


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

            'Updates GPA Text
            Me.TableAdapterManager.UpdateAll(Me.StudentData_ChrisDataSet)
            GPATextBox.Text = GPA.ToString()

        Catch ex As Exception
            MessageBox.Show("Updated")
        End Try

    End Sub



    Private Sub Exam1TextBox_TextChanged(sender As Object, e As EventArgs) Handles Exam1TextBox.TextChanged
        'possible fix
        If RadioButton1.Checked = False Then
            If RadioButton2.Checked = False Then
                If RadioButton3.Checked = False Then
                    If RadioButton4.Checked = False Then
                        Exam1TextBox.Text = Nothing
                        Exam2TextBox.Text = Nothing
                        Exam3TextBox.Text = Nothing
                        Exam4TextBox.Text = Nothing
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Exam2TextBox_TextChanged(sender As Object, e As EventArgs) Handles Exam2TextBox.TextChanged
        'possible fix
        If RadioButton1.Checked = False Then
            If RadioButton2.Checked = False Then
                If RadioButton3.Checked = False Then
                    If RadioButton4.Checked = False Then
                        Exam1TextBox.Text = Nothing
                        Exam2TextBox.Text = Nothing
                        Exam3TextBox.Text = Nothing
                        Exam4TextBox.Text = Nothing
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Exam3TextBox_TextChanged(sender As Object, e As EventArgs) Handles Exam3TextBox.TextChanged
        'possible fix
        If RadioButton1.Checked = False Then
            If RadioButton2.Checked = False Then
                If RadioButton3.Checked = False Then
                    If RadioButton4.Checked = False Then
                        Exam1TextBox.Text = Nothing
                        Exam2TextBox.Text = Nothing
                        Exam3TextBox.Text = Nothing
                        Exam4TextBox.Text = Nothing
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Exam4TextBox_TextChanged(sender As Object, e As EventArgs) Handles Exam4TextBox.TextChanged
        'possible fix
        If RadioButton1.Checked = False Then
            If RadioButton2.Checked = False Then
                If RadioButton3.Checked = False Then
                    If RadioButton4.Checked = False Then
                        Exam1TextBox.Text = Nothing
                        Exam2TextBox.Text = Nothing
                        Exam3TextBox.Text = Nothing
                        Exam4TextBox.Text = Nothing
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
End Class