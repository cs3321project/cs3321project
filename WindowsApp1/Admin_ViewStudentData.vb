Public Class Admin_ViewStudentData
    Private Sub Admin_ViewStudentData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
        'prepares GPA And AVG Before loaded on screen
        Me.DataTable1TableAdapter.UpdateAVG()
        Me.DataTable1TableAdapter.UpdateGPA()
        Me.DataTable1TableAdapter.FillBy(Me.StudentData_ChrisDataSet.DataTable1)
        Me.TableAdapterManager.UpdateAll(Me.StudentData_ChrisDataSet)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub


    Private Sub ChangeGradesBtn_Click(sender As Object, e As EventArgs) Handles ChnageGradesBtn.Click
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form1 As New AddRemove_Student
        form1.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub rdoButtons_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton1.Click, RadioButton2.Click, RadioButton3.Click, RadioButton4.Click, RadioButton5.Click
        If RadioButton1.Checked = True Then
            Me.Validate()
            Me.DataTable1TableAdapter.FillMATH(Me.StudentData_ChrisDataSet.DataTable1)
        End If

        If RadioButton2.Checked = True Then
            Me.Validate()
            Me.DataTable1TableAdapter.FillSCI(Me.StudentData_ChrisDataSet.DataTable1)
        End If

        If RadioButton3.Checked = True Then
            Me.Validate()
            Me.DataTable1TableAdapter.FillHIST(Me.StudentData_ChrisDataSet.DataTable1)
        End If

        If RadioButton4.Checked = True Then
            Me.Validate()
            Me.DataTable1TableAdapter.FillENG(Me.StudentData_ChrisDataSet.DataTable1)
        End If

        If RadioButton5.Checked = True Then
            Me.Validate()
            Me.DataTable1TableAdapter.FillBy(Me.StudentData_ChrisDataSet.DataTable1)
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub
End Class