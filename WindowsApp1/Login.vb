Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form As New Admin_Main
        Dim form2 As New Student_Main
        Dim login = LoginDatabaseTableAdapter.userPasswordString(USERTextBox.Text, PASSWORDTextBox.Text)

        If login Is Nothing Then
            MsgBox("Invalid username or password", MsgBoxStyle.Critical)
        ElseIf (login And USERTextBox.Text = "Admin") Then
            MsgBox("Welcome " + USERTextBox.Text, MsgBoxStyle.Information)
            form.ShowDialog()
        Else
            MsgBox("Welcome " + USERTextBox.Text, MsgBoxStyle.Information)
            Me.DataTable1TableAdapter.setLoginState(USERTextBox.Text)
            form2.ShowDialog()
        End If


        '  If ((TextBox1.Text = "Chris" And TextBox2.Text = "123") Or (TextBox1.Text = "Mark" And TextBox2.Text = "123") Or (TextBox1.Text = "Anthony" And TextBox2.Text = "123") Or (TextBox1.Text = "Bob" And TextBox2.Text = "123") Or (TextBox1.Text = "William" And TextBox2.Text = "123")) Then
        'MsgBox("Hello " + TextBox1.Text, MsgBoxStyle.Information, "Welcome")
        'form2.ShowDialog()
        '  Else
        'If (TextBox1.Text = "Admin" And TextBox2.Text = "password") Then
        'MsgBox("Logged in as Admin", MsgBoxStyle.Information, "Welcome")
        'form.ShowDialog()
        'Else
        '  If TextBox1.Text = "" And TextBox2.Text = "" Then
        '         MsgBox("No Username and/or Password Found!", MsgBoxStyle.Critical, "Error")
        ' Else
        'If TextBox1.Text = "" Then
        '  MsgBox("No username found", MsgBoxStyle.Critical, "Error")
        '         Else
        '  If TextBox2.Text = "" Then

        'MsgBox("No Password Found", MsgBoxStyle.Critical, "Error")
        '   Else
        'MsgBox("Invalid Username And/Or Password !", MsgBoxStyle.Critical, "Error")
        'End If
        'End If
        'End If
        'End If
        'End If


    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentData_ChrisDataSet.DataTable1' table. You can move, or remove it, as needed.
        ' Me.DataTable1TableAdapter.FillBy(Me.StudentData_ChrisDataSet.DataTable1)
        Me.DataTable1TableAdapter.setInitialLoginState()
        USERTextBox.Select()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

End Class
