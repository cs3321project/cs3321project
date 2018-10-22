<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_ChangeExamScores
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SubjectLabel As System.Windows.Forms.Label
        Dim Student_IDLabel As System.Windows.Forms.Label
        Dim Student_NameLabel As System.Windows.Forms.Label
        Dim Exam1Label As System.Windows.Forms.Label
        Dim Exam2Label As System.Windows.Forms.Label
        Dim Exam3Label As System.Windows.Forms.Label
        Dim Exam4Label As System.Windows.Forms.Label
        Dim Class_AVGLabel As System.Windows.Forms.Label
        Dim GPALabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_ChangeExamScores))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StudentData_ChrisBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.StudentData_ChrisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentData_ChrisDataSet = New WindowsApp1.StudentData_ChrisDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StudentData_ChrisBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.SubjectTextBox = New System.Windows.Forms.TextBox()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Student_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Exam1TextBox = New System.Windows.Forms.TextBox()
        Me.Exam2TextBox = New System.Windows.Forms.TextBox()
        Me.Exam3TextBox = New System.Windows.Forms.TextBox()
        Me.Exam4TextBox = New System.Windows.Forms.TextBox()
        Me.Class_AVGTextBox = New System.Windows.Forms.TextBox()
        Me.GPATextBox = New System.Windows.Forms.TextBox()
        Me.DataTable1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.StudentData_ChrisTableAdapter = New WindowsApp1.StudentData_ChrisDataSetTableAdapters.studentData_ChrisTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.StudentData_ChrisDataSetTableAdapters.TableAdapterManager()
        Me.DataTable1TableAdapter = New WindowsApp1.StudentData_ChrisDataSetTableAdapters.DataTable1TableAdapter()
        SubjectLabel = New System.Windows.Forms.Label()
        Student_IDLabel = New System.Windows.Forms.Label()
        Student_NameLabel = New System.Windows.Forms.Label()
        Exam1Label = New System.Windows.Forms.Label()
        Exam2Label = New System.Windows.Forms.Label()
        Exam3Label = New System.Windows.Forms.Label()
        Exam4Label = New System.Windows.Forms.Label()
        Class_AVGLabel = New System.Windows.Forms.Label()
        GPALabel = New System.Windows.Forms.Label()
        CType(Me.StudentData_ChrisBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StudentData_ChrisBindingNavigator.SuspendLayout()
        CType(Me.StudentData_ChrisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentData_ChrisDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SubjectLabel
        '
        SubjectLabel.AutoSize = True
        SubjectLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SubjectLabel.Location = New System.Drawing.Point(33, 33)
        SubjectLabel.Name = "SubjectLabel"
        SubjectLabel.Size = New System.Drawing.Size(70, 21)
        SubjectLabel.TabIndex = 20
        SubjectLabel.Text = "Subject:"
        '
        'Student_IDLabel
        '
        Student_IDLabel.AutoSize = True
        Student_IDLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_IDLabel.Location = New System.Drawing.Point(33, 68)
        Student_IDLabel.Name = "Student_IDLabel"
        Student_IDLabel.Size = New System.Drawing.Size(92, 21)
        Student_IDLabel.TabIndex = 22
        Student_IDLabel.Text = "student ID:"
        '
        'Student_NameLabel
        '
        Student_NameLabel.AutoSize = True
        Student_NameLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_NameLabel.Location = New System.Drawing.Point(33, 102)
        Student_NameLabel.Name = "Student_NameLabel"
        Student_NameLabel.Size = New System.Drawing.Size(116, 21)
        Student_NameLabel.TabIndex = 24
        Student_NameLabel.Text = "student Name:"
        '
        'Exam1Label
        '
        Exam1Label.AutoSize = True
        Exam1Label.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Exam1Label.Location = New System.Drawing.Point(332, 27)
        Exam1Label.Name = "Exam1Label"
        Exam1Label.Size = New System.Drawing.Size(65, 21)
        Exam1Label.TabIndex = 26
        Exam1Label.Text = "Exam1:"
        '
        'Exam2Label
        '
        Exam2Label.AutoSize = True
        Exam2Label.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Exam2Label.Location = New System.Drawing.Point(332, 53)
        Exam2Label.Name = "Exam2Label"
        Exam2Label.Size = New System.Drawing.Size(65, 21)
        Exam2Label.TabIndex = 28
        Exam2Label.Text = "Exam2:"
        '
        'Exam3Label
        '
        Exam3Label.AutoSize = True
        Exam3Label.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Exam3Label.Location = New System.Drawing.Point(332, 79)
        Exam3Label.Name = "Exam3Label"
        Exam3Label.Size = New System.Drawing.Size(65, 21)
        Exam3Label.TabIndex = 30
        Exam3Label.Text = "Exam3:"
        '
        'Exam4Label
        '
        Exam4Label.AutoSize = True
        Exam4Label.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Exam4Label.Location = New System.Drawing.Point(332, 105)
        Exam4Label.Name = "Exam4Label"
        Exam4Label.Size = New System.Drawing.Size(65, 21)
        Exam4Label.TabIndex = 32
        Exam4Label.Text = "Exam4:"
        '
        'Class_AVGLabel
        '
        Class_AVGLabel.AutoSize = True
        Class_AVGLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Class_AVGLabel.Location = New System.Drawing.Point(552, 39)
        Class_AVGLabel.Name = "Class_AVGLabel"
        Class_AVGLabel.Size = New System.Drawing.Size(97, 21)
        Class_AVGLabel.TabIndex = 34
        Class_AVGLabel.Text = "Class AVG:"
        '
        'GPALabel
        '
        GPALabel.AutoSize = True
        GPALabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GPALabel.Location = New System.Drawing.Point(552, 98)
        GPALabel.Name = "GPALabel"
        GPALabel.Size = New System.Drawing.Size(50, 21)
        GPALabel.TabIndex = 38
        GPALabel.Text = "GPA:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(50, 385)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 51)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StudentData_ChrisBindingNavigator
        '
        Me.StudentData_ChrisBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StudentData_ChrisBindingNavigator.BindingSource = Me.StudentData_ChrisBindingSource
        Me.StudentData_ChrisBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StudentData_ChrisBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StudentData_ChrisBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StudentData_ChrisBindingNavigatorSaveItem})
        Me.StudentData_ChrisBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StudentData_ChrisBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StudentData_ChrisBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StudentData_ChrisBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StudentData_ChrisBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StudentData_ChrisBindingNavigator.Name = "StudentData_ChrisBindingNavigator"
        Me.StudentData_ChrisBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StudentData_ChrisBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.StudentData_ChrisBindingNavigator.TabIndex = 1
        Me.StudentData_ChrisBindingNavigator.Text = "BindingNavigator1"
        Me.StudentData_ChrisBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'StudentData_ChrisBindingSource
        '
        Me.StudentData_ChrisBindingSource.DataMember = "studentData_Chris"
        Me.StudentData_ChrisBindingSource.DataSource = Me.StudentData_ChrisDataSet
        '
        'StudentData_ChrisDataSet
        '
        Me.StudentData_ChrisDataSet.DataSetName = "StudentData_ChrisDataSet"
        Me.StudentData_ChrisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'StudentData_ChrisBindingNavigatorSaveItem
        '
        Me.StudentData_ChrisBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StudentData_ChrisBindingNavigatorSaveItem.Image = CType(resources.GetObject("StudentData_ChrisBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StudentData_ChrisBindingNavigatorSaveItem.Name = "StudentData_ChrisBindingNavigatorSaveItem"
        Me.StudentData_ChrisBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.StudentData_ChrisBindingNavigatorSaveItem.Text = "Save Data"
        '
        'UpdateBtn
        '
        Me.UpdateBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.UpdateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.UpdateBtn.Location = New System.Drawing.Point(823, 39)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(213, 85)
        Me.UpdateBtn.TabIndex = 18
        Me.UpdateBtn.Text = "Update"
        Me.UpdateBtn.UseVisualStyleBackColor = False
        '
        'SubjectTextBox
        '
        Me.SubjectTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SubjectTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "Subject", True))
        Me.SubjectTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectTextBox.Location = New System.Drawing.Point(158, 27)
        Me.SubjectTextBox.Name = "SubjectTextBox"
        Me.SubjectTextBox.ReadOnly = True
        Me.SubjectTextBox.Size = New System.Drawing.Size(100, 26)
        Me.SubjectTextBox.TabIndex = 21
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.StudentData_ChrisDataSet
        '
        'Student_IDTextBox
        '
        Me.Student_IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Student_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "student_ID", True))
        Me.Student_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_IDTextBox.Location = New System.Drawing.Point(158, 62)
        Me.Student_IDTextBox.Name = "Student_IDTextBox"
        Me.Student_IDTextBox.ReadOnly = True
        Me.Student_IDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Student_IDTextBox.TabIndex = 23
        '
        'Student_NameTextBox
        '
        Me.Student_NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Student_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "student_Name", True))
        Me.Student_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_NameTextBox.Location = New System.Drawing.Point(158, 96)
        Me.Student_NameTextBox.Name = "Student_NameTextBox"
        Me.Student_NameTextBox.ReadOnly = True
        Me.Student_NameTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Student_NameTextBox.TabIndex = 25
        '
        'Exam1TextBox
        '
        Me.Exam1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "Exam1", True))
        Me.Exam1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exam1TextBox.Location = New System.Drawing.Point(414, 24)
        Me.Exam1TextBox.Name = "Exam1TextBox"
        Me.Exam1TextBox.Size = New System.Drawing.Size(100, 26)
        Me.Exam1TextBox.TabIndex = 27
        '
        'Exam2TextBox
        '
        Me.Exam2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "Exam2", True))
        Me.Exam2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exam2TextBox.Location = New System.Drawing.Point(414, 50)
        Me.Exam2TextBox.Name = "Exam2TextBox"
        Me.Exam2TextBox.Size = New System.Drawing.Size(100, 26)
        Me.Exam2TextBox.TabIndex = 29
        '
        'Exam3TextBox
        '
        Me.Exam3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "Exam3", True))
        Me.Exam3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exam3TextBox.Location = New System.Drawing.Point(414, 76)
        Me.Exam3TextBox.Name = "Exam3TextBox"
        Me.Exam3TextBox.Size = New System.Drawing.Size(100, 26)
        Me.Exam3TextBox.TabIndex = 31
        '
        'Exam4TextBox
        '
        Me.Exam4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "Exam4", True))
        Me.Exam4TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exam4TextBox.Location = New System.Drawing.Point(414, 102)
        Me.Exam4TextBox.Name = "Exam4TextBox"
        Me.Exam4TextBox.Size = New System.Drawing.Size(100, 26)
        Me.Exam4TextBox.TabIndex = 33
        '
        'Class_AVGTextBox
        '
        Me.Class_AVGTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Class_AVGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "Class AVG", True))
        Me.Class_AVGTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Class_AVGTextBox.Location = New System.Drawing.Point(670, 36)
        Me.Class_AVGTextBox.Name = "Class_AVGTextBox"
        Me.Class_AVGTextBox.ReadOnly = True
        Me.Class_AVGTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Class_AVGTextBox.TabIndex = 35
        '
        'GPATextBox
        '
        Me.GPATextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GPATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "GPA", True))
        Me.GPATextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPATextBox.Location = New System.Drawing.Point(670, 95)
        Me.GPATextBox.Name = "GPATextBox"
        Me.GPATextBox.ReadOnly = True
        Me.GPATextBox.Size = New System.Drawing.Size(100, 26)
        Me.GPATextBox.TabIndex = 39
        '
        'DataTable1DataGridView
        '
        Me.DataTable1DataGridView.AutoGenerateColumns = False
        Me.DataTable1DataGridView.BackgroundColor = System.Drawing.Color.Black
        Me.DataTable1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataTable1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn9})
        Me.DataTable1DataGridView.DataSource = Me.DataTable1BindingSource
        Me.DataTable1DataGridView.Location = New System.Drawing.Point(12, 159)
        Me.DataTable1DataGridView.Name = "DataTable1DataGridView"
        Me.DataTable1DataGridView.ReadOnly = True
        Me.DataTable1DataGridView.Size = New System.Drawing.Size(844, 220)
        Me.DataTable1DataGridView.TabIndex = 39
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "student_ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "student_ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "student_Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "student_Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Exam1"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Exam1"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Exam2"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Exam2"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Exam3"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Exam3"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Exam4"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Exam4"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Subject"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Subject"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Class AVG"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Class AVG"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(876, 376)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(178, 60)
        Me.Button3.TabIndex = 40
        Me.Button3.Text = "View Exam Scores"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'StudentData_ChrisTableAdapter
        '
        Me.StudentData_ChrisTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.StudentData_ChrisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'Admin_ChangeExamScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1066, 448)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataTable1DataGridView)
        Me.Controls.Add(SubjectLabel)
        Me.Controls.Add(Me.SubjectTextBox)
        Me.Controls.Add(Student_IDLabel)
        Me.Controls.Add(Me.Student_IDTextBox)
        Me.Controls.Add(Student_NameLabel)
        Me.Controls.Add(Me.Student_NameTextBox)
        Me.Controls.Add(Exam1Label)
        Me.Controls.Add(Me.Exam1TextBox)
        Me.Controls.Add(Exam2Label)
        Me.Controls.Add(Me.Exam2TextBox)
        Me.Controls.Add(Exam3Label)
        Me.Controls.Add(Me.Exam3TextBox)
        Me.Controls.Add(Exam4Label)
        Me.Controls.Add(Me.Exam4TextBox)
        Me.Controls.Add(Class_AVGLabel)
        Me.Controls.Add(Me.Class_AVGTextBox)
        Me.Controls.Add(GPALabel)
        Me.Controls.Add(Me.GPATextBox)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.StudentData_ChrisBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Admin_ChangeExamScores"
        Me.Text = "Admin_ChangeExamScores"
        CType(Me.StudentData_ChrisBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudentData_ChrisBindingNavigator.ResumeLayout(False)
        Me.StudentData_ChrisBindingNavigator.PerformLayout()
        CType(Me.StudentData_ChrisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentData_ChrisDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents StudentData_ChrisDataSet As StudentData_ChrisDataSet
    Friend WithEvents StudentData_ChrisBindingSource As BindingSource
    Friend WithEvents StudentData_ChrisTableAdapter As StudentData_ChrisDataSetTableAdapters.studentData_ChrisTableAdapter
    Friend WithEvents TableAdapterManager As StudentData_ChrisDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentData_ChrisBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents StudentData_ChrisBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataTable1TableAdapter As StudentData_ChrisDataSetTableAdapters.DataTable1TableAdapter
    Friend WithEvents SubjectTextBox As TextBox
    Friend WithEvents Student_IDTextBox As TextBox
    Friend WithEvents Student_NameTextBox As TextBox
    Friend WithEvents Exam1TextBox As TextBox
    Friend WithEvents Exam2TextBox As TextBox
    Friend WithEvents Exam3TextBox As TextBox
    Friend WithEvents Exam4TextBox As TextBox
    Friend WithEvents Class_AVGTextBox As TextBox
    Friend WithEvents GPATextBox As TextBox
    Friend WithEvents DataTable1DataGridView As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
End Class
